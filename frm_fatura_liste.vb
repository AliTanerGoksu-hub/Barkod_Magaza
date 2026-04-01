'Imports DevExpress.Data 'KApat
'Imports DevExpress.Utils 'KApat
'Imports DevExpress.XtraBars 'KApat
Imports DevExpress.XtraEditors 'KApat
Imports DevExpress.XtraEditors.Controls
'Imports DevExpress.XtraGrid 'KApat
'Imports DevExpress.XtraGrid.Columns 'KApat
'Imports DevExpress.XtraGrid.Views.Base 'KApat
'Imports DevExpress.XtraGrid.Views.Grid 'KApat
'Imports DevExpress.XtraPrinting 'KApat
Imports FastReport
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports Microsoft.Win32
Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.OleDb
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Printing
Imports System.Globalization
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports System.Threading.Tasks
Imports business_smart.eFaturaGelen
Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports System.Text
Imports System.Xml
Imports System.Xml.Xsl
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports iTextSharp.tool.xml
Imports iTextSharp.tool.xml.pipeline.css
Imports iTextSharp.tool.xml.pipeline.html
Imports iTextSharp.tool.xml.pipeline.end
Imports iTextSharp.tool.xml.parser
Imports iTextSharp.tool.xml.css
Imports iTextSharp.tool.xml.html
Imports iTextSharp.tool.xml.css.parser
Imports System.Text.RegularExpressions
Imports HtmlAgilityPack

Public Class frm_fatura_liste
    Inherits DevExpress.XtraEditors.XtraForm
#Region " Windows Form Designer generated code "
    Public Sub New()
        MyBase.New()
        InitializeComponent()
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
    Friend WithEvents coldteFisTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collFisNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnGirisCikis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collToplamMiktar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collNetTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsDepo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDepo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsKodu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsAciklama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsTransferDepo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltDepo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsFaturalasti As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMuhasebelesti As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsHareketTipi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsNot As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTamamlandi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collTevkifatKdvMatrahi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collTevkifatKdv As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHizmet As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnFirmaID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsFisTipi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnStokFisiID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKdvTutari As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKdvMatrahi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collMalIskontoTutari As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collMalBedeli As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEkMaliyet As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colISKONTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEkOran As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_lFisNo2 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_lFisNo1 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_dteFisTarihi2 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_dteFisTarihi1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sec_sHareketTipi As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents MenuItem19 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem16 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem22 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem23 As System.Windows.Forms.MenuItem
    Friend WithEvents label3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents btnEkle As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDuzelt As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnYazdir As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem8 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem6 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem7 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents sec_resmi1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents sec_resmi As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents colbPesinmi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MenuItem14 As System.Windows.Forms.MenuItem
    Friend WithEvents lbl_istihbarat As DevExpress.XtraEditors.LabelControl
    Friend WithEvents MenuItem24 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem25 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem26 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem27 As System.Windows.Forms.MenuItem
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents MenuItem13 As System.Windows.Forms.MenuItem
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents collOTV2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnSayfa As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MenuItem28 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem29 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem30 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem31 As System.Windows.Forms.MenuItem
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents BarSubItem1 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarButtonItem9 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem10 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem11 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents colsKullaniciAdi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteKayitTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sec_sSatici As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents MenuItem32 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem33 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem34 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem35 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem36 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem37 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem38 As System.Windows.Forms.MenuItem
    Friend WithEvents colbKilitli As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MenuItem39 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem40 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem41 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem43 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem44 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem45 As System.Windows.Forms.MenuItem
    Friend WithEvents sec_bSatisMaliyetHesapla As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txt_sKaydeden As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents sec_grid As DevExpress.XtraEditors.PopupContainerControl
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSEC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKOD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colACIKLAMA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sec_sdepo As DevExpress.XtraEditors.PopupContainerEdit
    Friend WithEvents Group_Muhasebelestir As DevExpress.XtraEditors.GroupControl
    Friend WithEvents sec_sMuhasebeIslemTuru As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents sec_sMuhasebeEntegrasyonTuru As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton5 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_dteEntegreTarihi As DevExpress.XtraEditors.DateEdit
    Friend WithEvents bar1 As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents sec_sTarihTipi As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents BarButtonItem12 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents sec_bFaturayaDonustumu As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents MenuItem42 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem46 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem47 As System.Windows.Forms.MenuItem
    Dim gibUser As String = ""
    Dim gibPass As String = ""
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_fatura_liste))
        Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem1 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim ToolTipSeparatorItem1 As DevExpress.Utils.ToolTipSeparatorItem = New DevExpress.Utils.ToolTipSeparatorItem()
        Dim ToolTipTitleItem2 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim SuperToolTip2 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem3 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem2 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim ToolTipSeparatorItem2 As DevExpress.Utils.ToolTipSeparatorItem = New DevExpress.Utils.ToolTipSeparatorItem()
        Dim ToolTipTitleItem4 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim SuperToolTip3 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem5 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem3 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim ToolTipSeparatorItem3 As DevExpress.Utils.ToolTipSeparatorItem = New DevExpress.Utils.ToolTipSeparatorItem()
        Dim ToolTipTitleItem6 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim SuperToolTip4 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem7 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem4 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim ToolTipSeparatorItem4 As DevExpress.Utils.ToolTipSeparatorItem = New DevExpress.Utils.ToolTipSeparatorItem()
        Dim ToolTipTitleItem8 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim SuperToolTip5 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem9 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem5 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim ToolTipSeparatorItem5 As DevExpress.Utils.ToolTipSeparatorItem = New DevExpress.Utils.ToolTipSeparatorItem()
        Dim ToolTipTitleItem10 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim SuperToolTip6 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem11 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem6 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim ToolTipSeparatorItem6 As DevExpress.Utils.ToolTipSeparatorItem = New DevExpress.Utils.ToolTipSeparatorItem()
        Dim ToolTipTitleItem12 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim SuperToolTip7 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem13 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem7 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim ToolTipSeparatorItem7 As DevExpress.Utils.ToolTipSeparatorItem = New DevExpress.Utils.ToolTipSeparatorItem()
        Dim ToolTipTitleItem14 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim SuperToolTip8 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem15 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem8 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim ToolTipSeparatorItem8 As DevExpress.Utils.ToolTipSeparatorItem = New DevExpress.Utils.ToolTipSeparatorItem()
        Dim ToolTipTitleItem16 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim SuperToolTip9 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem17 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem9 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim ToolTipTitleItem18 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Me.colbPesinmi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.sec_Aktar = New DevExpress.XtraEditors.CheckEdit()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.sec_bFaturayaDonustumu = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.btnEkle = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDuzelt = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.btnYazdir = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem8 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem6 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem7 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarSubItem1 = New DevExpress.XtraBars.BarSubItem()
        Me.BarButtonItem9 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem10 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem11 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem12 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem13 = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.sec_sTarihTipi = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txt_sKaydeden = New DevExpress.XtraEditors.ButtonEdit()
        Me.sec_sdepo = New DevExpress.XtraEditors.PopupContainerEdit()
        Me.sec_grid = New DevExpress.XtraEditors.PopupContainerControl()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSEC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKOD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colACIKLAMA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_sSatici = New DevExpress.XtraEditors.LookUpEdit()
        Me.sec_resmi1 = New DevExpress.XtraEditors.CheckEdit()
        Me.sec_resmi = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.sec_sHareketTipi = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_dteFisTarihi2 = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_dteFisTarihi1 = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_lFisNo2 = New DevExpress.XtraEditors.SpinEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_lFisNo1 = New DevExpress.XtraEditors.SpinEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
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
        Me.sec_kriter = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txt_ara = New DevExpress.XtraEditors.TextEdit()
        Me.sec_konum = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.Label1 = New DevExpress.XtraEditors.LabelControl()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbl_istihbarat = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.bar1 = New DevExpress.XtraEditors.ProgressBarControl()
        Me.label3 = New DevExpress.XtraEditors.LabelControl()
        Me.Label2 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.Group_Muhasebelestir = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_dteEntegreTarihi = New DevExpress.XtraEditors.DateEdit()
        Me.sec_bSatisMaliyetHesapla = New DevExpress.XtraEditors.CheckEdit()
        Me.sec_sMuhasebeIslemTuru = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.sec_sMuhasebeEntegrasyonTuru = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton5 = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu()
        Me.MenuItem21 = New System.Windows.Forms.MenuItem()
        Me.MenuItem23 = New System.Windows.Forms.MenuItem()
        Me.MenuItem46 = New System.Windows.Forms.MenuItem()
        Me.MenuItem47 = New System.Windows.Forms.MenuItem()
        Me.MenuItem24 = New System.Windows.Forms.MenuItem()
        Me.MenuItem18 = New System.Windows.Forms.MenuItem()
        Me.MenuItem13 = New System.Windows.Forms.MenuItem()
        Me.MenuItem39 = New System.Windows.Forms.MenuItem()
        Me.MenuItem40 = New System.Windows.Forms.MenuItem()
        Me.MenuItem41 = New System.Windows.Forms.MenuItem()
        Me.MenuItem48 = New System.Windows.Forms.MenuItem()
        Me.MenuItem49 = New System.Windows.Forms.MenuItem()
        Me.MenuItem50 = New System.Windows.Forms.MenuItem()
        Me.MenuItem51 = New System.Windows.Forms.MenuItem()
        Me.MenuItem52 = New System.Windows.Forms.MenuItem()
        Me.MenuItem53 = New System.Windows.Forms.MenuItem()
        Me.MenuItem43 = New System.Windows.Forms.MenuItem()
        Me.MenuItem55 = New System.Windows.Forms.MenuItem()
        Me.MenuItem54 = New System.Windows.Forms.MenuItem()
        Me.MenuItem44 = New System.Windows.Forms.MenuItem()
        Me.MenuItem45 = New System.Windows.Forms.MenuItem()
        Me.MenuItem57 = New System.Windows.Forms.MenuItem()
        Me.MenuItem56 = New System.Windows.Forms.MenuItem()
        Me.MenuItem58 = New System.Windows.Forms.MenuItem()
        Me.MenuItem59 = New System.Windows.Forms.MenuItem()
        Me.MenuItem15 = New System.Windows.Forms.MenuItem()
        Me.MenuItem19 = New System.Windows.Forms.MenuItem()
        Me.MenuItem16 = New System.Windows.Forms.MenuItem()
        Me.MenuItem17 = New System.Windows.Forms.MenuItem()
        Me.MenuItem22 = New System.Windows.Forms.MenuItem()
        Me.MenuItem42 = New System.Windows.Forms.MenuItem()
        Me.MenuItem20 = New System.Windows.Forms.MenuItem()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.MenuItem10 = New System.Windows.Forms.MenuItem()
        Me.MenuItem25 = New System.Windows.Forms.MenuItem()
        Me.MenuItem28 = New System.Windows.Forms.MenuItem()
        Me.MenuItem29 = New System.Windows.Forms.MenuItem()
        Me.MenuItem30 = New System.Windows.Forms.MenuItem()
        Me.MenuItem31 = New System.Windows.Forms.MenuItem()
        Me.MenuItem26 = New System.Windows.Forms.MenuItem()
        Me.MenuItem27 = New System.Windows.Forms.MenuItem()
        Me.MenuItem36 = New System.Windows.Forms.MenuItem()
        Me.MenuItem32 = New System.Windows.Forms.MenuItem()
        Me.MenuItem33 = New System.Windows.Forms.MenuItem()
        Me.MenuItem34 = New System.Windows.Forms.MenuItem()
        Me.MenuItem35 = New System.Windows.Forms.MenuItem()
        Me.MenuItem38 = New System.Windows.Forms.MenuItem()
        Me.MenuItem37 = New System.Windows.Forms.MenuItem()
        Me.MenuItem14 = New System.Windows.Forms.MenuItem()
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
        Me.coldteFisTarihi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collFisNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnGirisCikis = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collToplamMiktar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collNetTutar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsDepo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDepo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsTransferDepo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltDepo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsKodu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsAciklama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsFaturalasti = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMuhasebelesti = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsHareketTipi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsNot = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTamamlandi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collTevkifatKdvMatrahi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collTevkifatKdv = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHizmet = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnFirmaID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsFisTipi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnStokFisiID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKdvTutari = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKdvMatrahi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collMalIskontoTutari = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collMalBedeli = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEkMaliyet = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colISKONTO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEkOran = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collOTV2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnSayfa = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsKullaniciAdi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldteKayitTarihi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colbKilitli = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsYazdirma = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsOnizleme = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsBelgeTipi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnEvrakNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsSinifKodu1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsSinifKodu2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsCariSinif3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldteVadeTarihi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsAciklama1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGibFaturaNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsEfaturaUrl = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ps = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.printlink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.sec_Aktar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_bFaturayaDonustumu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sTarihTipi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sKaydeden.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sdepo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.sec_grid.SuspendLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sSatici.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_resmi1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_resmi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sHareketTipi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_dteFisTarihi2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_dteFisTarihi2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_dteFisTarihi1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_dteFisTarihi1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_lFisNo2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_lFisNo1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_nGirisCikis.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sFisTipi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_lNetTutar2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_lNetTutar1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_kriter.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ara.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_konum.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.bar1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.Group_Muhasebelestir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Group_Muhasebelestir.SuspendLayout()
        CType(Me.txt_dteEntegreTarihi.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_dteEntegreTarihi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_bSatisMaliyetHesapla.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sMuhasebeIslemTuru.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sMuhasebeEntegrasyonTuru.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'colbPesinmi
        '
        Me.colbPesinmi.Caption = "Kapali"
        Me.colbPesinmi.FieldName = "bPesinmi"
        Me.colbPesinmi.Name = "colbPesinmi"
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
        Me.PanelControl1.Size = New System.Drawing.Size(2156, 214)
        Me.PanelControl1.TabIndex = 3
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.sec_Aktar)
        Me.GroupControl1.Controls.Add(Me.SimpleButton3)
        Me.GroupControl1.Controls.Add(Me.sec_bFaturayaDonustumu)
        Me.GroupControl1.Controls.Add(Me.sec_sTarihTipi)
        Me.GroupControl1.Controls.Add(Me.txt_sKaydeden)
        Me.GroupControl1.Controls.Add(Me.sec_sdepo)
        Me.GroupControl1.Controls.Add(Me.sec_sSatici)
        Me.GroupControl1.Controls.Add(Me.sec_resmi1)
        Me.GroupControl1.Controls.Add(Me.sec_resmi)
        Me.GroupControl1.Controls.Add(Me.LabelControl15)
        Me.GroupControl1.Controls.Add(Me.sec_sHareketTipi)
        Me.GroupControl1.Controls.Add(Me.LabelControl9)
        Me.GroupControl1.Controls.Add(Me.txt_dteFisTarihi2)
        Me.GroupControl1.Controls.Add(Me.LabelControl11)
        Me.GroupControl1.Controls.Add(Me.txt_dteFisTarihi1)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.txt_lFisNo2)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.txt_lFisNo1)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.LabelControl12)
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
        Me.GroupControl1.Controls.Add(Me.sec_kriter)
        Me.GroupControl1.Controls.Add(Me.txt_ara)
        Me.GroupControl1.Controls.Add(Me.sec_konum)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(154, 2)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1588, 210)
        Me.GroupControl1.TabIndex = 34
        Me.GroupControl1.Text = "Ara"
        '
        'sec_Aktar
        '
        Me.sec_Aktar.Location = New System.Drawing.Point(728, 29)
        Me.sec_Aktar.Name = "sec_Aktar"
        Me.sec_Aktar.Properties.Caption = "Aktar"
        Me.sec_Aktar.Size = New System.Drawing.Size(102, 24)
        Me.sec_Aktar.TabIndex = 59
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Image = CType(resources.GetObject("SimpleButton3.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(627, 170)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(120, 29)
        Me.SimpleButton3.TabIndex = 14
        Me.SimpleButton3.Text = "&Listele"
        '
        'sec_bFaturayaDonustumu
        '
        Me.sec_bFaturayaDonustumu.EditValue = "[Tümü]"
        Me.sec_bFaturayaDonustumu.Location = New System.Drawing.Point(627, 141)
        Me.sec_bFaturayaDonustumu.MenuManager = Me.BarManager1
        Me.sec_bFaturayaDonustumu.Name = "sec_bFaturayaDonustumu"
        Me.sec_bFaturayaDonustumu.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_bFaturayaDonustumu.Properties.Items.AddRange(New Object() {"[Tümü]", "Faturalaştı", "Faturalaşmadı"})
        Me.sec_bFaturayaDonustumu.Size = New System.Drawing.Size(120, 26)
        Me.sec_bFaturayaDonustumu.TabIndex = 58
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnEkle, Me.btnDuzelt, Me.BarButtonItem3, Me.btnYazdir, Me.BarButtonItem5, Me.BarButtonItem6, Me.BarButtonItem7, Me.BarButtonItem8, Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem4, Me.BarSubItem1, Me.BarButtonItem9, Me.BarButtonItem10, Me.BarButtonItem11, Me.BarButtonItem12, Me.BarButtonItem13})
        Me.BarManager1.MaxItemId = 17
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnEkle), New DevExpress.XtraBars.LinkPersistInfo(Me.btnDuzelt, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem3, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btnYazdir, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem5, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem8, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem6, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem7, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem2, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem1, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem12), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.KeyTip, Me.BarButtonItem13, "", False, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.Standard, "", "")})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.MultiLine = True
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'btnEkle
        '
        Me.btnEkle.Caption = "Ekle,Insert"
        Me.btnEkle.Id = 0
        Me.btnEkle.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnEkle.ItemAppearance.Normal.Options.UseFont = True
        Me.btnEkle.Name = "btnEkle"
        ToolTipTitleItem1.Text = "Ekle"
        ToolTipItem1.LeftIndent = 6
        ToolTipItem1.Text = "Yeni Bir Fis açar Cari Hesabını seçtikten sonra Fis Bilgilerini Girebilirsiniz..." &
    ""
        ToolTipTitleItem2.LeftIndent = 6
        ToolTipTitleItem2.Text = "Insert"
        SuperToolTip1.Items.Add(ToolTipTitleItem1)
        SuperToolTip1.Items.Add(ToolTipItem1)
        SuperToolTip1.Items.Add(ToolTipSeparatorItem1)
        SuperToolTip1.Items.Add(ToolTipTitleItem2)
        Me.btnEkle.SuperTip = SuperToolTip1
        '
        'btnDuzelt
        '
        Me.btnDuzelt.Caption = "Düzelt,F4"
        Me.btnDuzelt.Id = 1
        Me.btnDuzelt.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnDuzelt.ItemAppearance.Normal.Options.UseFont = True
        Me.btnDuzelt.Name = "btnDuzelt"
        ToolTipTitleItem3.Text = "Duzelt"
        ToolTipItem2.LeftIndent = 6
        ToolTipItem2.Text = "Seçili Fişi Ekrana getirir,değişiklik yapmanıza olanak sağlar."
        ToolTipTitleItem4.LeftIndent = 6
        ToolTipTitleItem4.Text = "F4"
        SuperToolTip2.Items.Add(ToolTipTitleItem3)
        SuperToolTip2.Items.Add(ToolTipItem2)
        SuperToolTip2.Items.Add(ToolTipSeparatorItem2)
        SuperToolTip2.Items.Add(ToolTipTitleItem4)
        Me.btnDuzelt.SuperTip = SuperToolTip2
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Sil, Ctrl+Delete"
        Me.BarButtonItem3.Id = 2
        Me.BarButtonItem3.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem3.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem3.Name = "BarButtonItem3"
        ToolTipTitleItem5.Text = "Sil"
        ToolTipItem3.LeftIndent = 6
        ToolTipItem3.Text = "Seçili Fişleri siler. Irsaliyeden veya Faturadan Dönüşüm yapılmış ise sadece dönü" &
    "şüm işlemini iptal eder,Irsaliyedene değişiklik yapmanıza olanak sağlar."
        ToolTipTitleItem6.LeftIndent = 6
        ToolTipTitleItem6.Text = "Ctrl+Delete"
        SuperToolTip3.Items.Add(ToolTipTitleItem5)
        SuperToolTip3.Items.Add(ToolTipItem3)
        SuperToolTip3.Items.Add(ToolTipSeparatorItem3)
        SuperToolTip3.Items.Add(ToolTipTitleItem6)
        Me.BarButtonItem3.SuperTip = SuperToolTip3
        '
        'btnYazdir
        '
        Me.btnYazdir.Caption = "Yazdır,Ctrl+P"
        Me.btnYazdir.Id = 3
        Me.btnYazdir.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnYazdir.ItemAppearance.Normal.Options.UseFont = True
        Me.btnYazdir.Name = "btnYazdir"
        ToolTipTitleItem7.Text = "Yazdır"
        ToolTipItem4.LeftIndent = 6
        ToolTipItem4.Text = "Ekranda listelenmiş Fişlerin Listesini Yazdırmak için kullanılır."
        ToolTipTitleItem8.LeftIndent = 6
        ToolTipTitleItem8.Text = "Ctrl+P"
        SuperToolTip4.Items.Add(ToolTipTitleItem7)
        SuperToolTip4.Items.Add(ToolTipItem4)
        SuperToolTip4.Items.Add(ToolTipSeparatorItem4)
        SuperToolTip4.Items.Add(ToolTipTitleItem8)
        Me.btnYazdir.SuperTip = SuperToolTip4
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "Firma Kartı"
        Me.BarButtonItem5.Id = 4
        Me.BarButtonItem5.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem5.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem5.Name = "BarButtonItem5"
        ToolTipTitleItem9.Text = "Firma Kartı"
        ToolTipItem5.LeftIndent = 6
        ToolTipItem5.Text = "Seçili Hesabın Carisini Ekrana Getirir"
        ToolTipTitleItem10.LeftIndent = 6
        ToolTipTitleItem10.Text = "Ctrl+F4"
        SuperToolTip5.Items.Add(ToolTipTitleItem9)
        SuperToolTip5.Items.Add(ToolTipItem5)
        SuperToolTip5.Items.Add(ToolTipSeparatorItem5)
        SuperToolTip5.Items.Add(ToolTipTitleItem10)
        Me.BarButtonItem5.SuperTip = SuperToolTip5
        '
        'BarButtonItem8
        '
        Me.BarButtonItem8.Caption = "Firma Bakiyesi"
        Me.BarButtonItem8.Id = 7
        Me.BarButtonItem8.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem8.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem8.Name = "BarButtonItem8"
        ToolTipTitleItem11.Text = "Firma Bakiyesi"
        ToolTipItem6.LeftIndent = 6
        ToolTipItem6.Text = "Seçili Satırın Cari Bakiyesini Ekrana Getirir"
        ToolTipTitleItem12.LeftIndent = 6
        ToolTipTitleItem12.Text = "F6"
        SuperToolTip6.Items.Add(ToolTipTitleItem11)
        SuperToolTip6.Items.Add(ToolTipItem6)
        SuperToolTip6.Items.Add(ToolTipSeparatorItem6)
        SuperToolTip6.Items.Add(ToolTipTitleItem12)
        Me.BarButtonItem8.SuperTip = SuperToolTip6
        '
        'BarButtonItem6
        '
        Me.BarButtonItem6.Caption = "Firma Hareketleri"
        Me.BarButtonItem6.Id = 5
        Me.BarButtonItem6.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem6.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem6.Name = "BarButtonItem6"
        ToolTipTitleItem13.Text = "Firma Hareketleri"
        ToolTipItem7.LeftIndent = 6
        ToolTipItem7.Text = "Seçili Satır Carisinin Hesap Hareketlerini Ekrana Getirir"
        ToolTipTitleItem14.LeftIndent = 6
        ToolTipTitleItem14.Text = "F7"
        SuperToolTip7.Items.Add(ToolTipTitleItem13)
        SuperToolTip7.Items.Add(ToolTipItem7)
        SuperToolTip7.Items.Add(ToolTipSeparatorItem7)
        SuperToolTip7.Items.Add(ToolTipTitleItem14)
        Me.BarButtonItem6.SuperTip = SuperToolTip7
        '
        'BarButtonItem7
        '
        Me.BarButtonItem7.Caption = "İletişim"
        Me.BarButtonItem7.Id = 6
        Me.BarButtonItem7.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem7.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem7.Name = "BarButtonItem7"
        ToolTipTitleItem15.Text = "Iletişim"
        ToolTipItem8.LeftIndent = 6
        ToolTipItem8.Text = "Seçili Satır Cari Hesabın Iletişim Bilgilerini Ekrana Getirir"
        ToolTipTitleItem16.LeftIndent = 6
        ToolTipTitleItem16.Text = "F8"
        SuperToolTip8.Items.Add(ToolTipTitleItem15)
        SuperToolTip8.Items.Add(ToolTipItem8)
        SuperToolTip8.Items.Add(ToolTipSeparatorItem8)
        SuperToolTip8.Items.Add(ToolTipTitleItem16)
        Me.BarButtonItem7.SuperTip = SuperToolTip8
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Excel"
        Me.BarButtonItem1.Id = 8
        Me.BarButtonItem1.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem1.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Txt"
        Me.BarButtonItem2.Id = 9
        Me.BarButtonItem2.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem2.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarSubItem1
        '
        Me.BarSubItem1.Caption = "Toplamlar"
        Me.BarSubItem1.Id = 11
        Me.BarSubItem1.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarSubItem1.ItemAppearance.Normal.Options.UseFont = True
        Me.BarSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem9), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem10), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem11)})
        Me.BarSubItem1.Name = "BarSubItem1"
        '
        'BarButtonItem9
        '
        Me.BarButtonItem9.Caption = "Döviz Toplamları"
        Me.BarButtonItem9.Id = 12
        Me.BarButtonItem9.Name = "BarButtonItem9"
        '
        'BarButtonItem10
        '
        Me.BarButtonItem10.Caption = "Depo Toplamları"
        Me.BarButtonItem10.Id = 13
        Me.BarButtonItem10.Name = "BarButtonItem10"
        '
        'BarButtonItem11
        '
        Me.BarButtonItem11.Caption = "Kdv Toplamları"
        Me.BarButtonItem11.Id = 14
        Me.BarButtonItem11.Name = "BarButtonItem11"
        '
        'BarButtonItem12
        '
        Me.BarButtonItem12.Caption = "(R)"
        Me.BarButtonItem12.Id = 15
        Me.BarButtonItem12.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem12.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem12.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R))
        Me.BarButtonItem12.Name = "BarButtonItem12"
        '
        'BarButtonItem13
        '
        Me.BarButtonItem13.Caption = "Muhasebe Fişi"
        Me.BarButtonItem13.Id = 16
        Me.BarButtonItem13.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BarButtonItem13.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem13.ItemShortcut = New DevExpress.XtraBars.BarShortcut(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                Or System.Windows.Forms.Keys.M))
        Me.BarButtonItem13.Name = "BarButtonItem13"
        ToolTipTitleItem17.Text = "Muhasebe Fişi"
        ToolTipItem9.LeftIndent = 6
        ToolTipItem9.Text = "Listede seçili olan Faturaya ait Muhasebe fişini açar"
        ToolTipTitleItem18.LeftIndent = 6
        ToolTipTitleItem18.Text = "Ctrl+Shift+M"
        SuperToolTip9.Items.Add(ToolTipTitleItem17)
        SuperToolTip9.Items.Add(ToolTipItem9)
        SuperToolTip9.Items.Add(ToolTipTitleItem18)
        Me.BarButtonItem13.SuperTip = SuperToolTip9
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(2156, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 1159)
        Me.barDockControlBottom.Size = New System.Drawing.Size(2156, 30)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 1159)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(2156, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 1159)
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "Mail"
        Me.BarButtonItem4.Id = 10
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'sec_sTarihTipi
        '
        Me.sec_sTarihTipi.EditValue = "Tarih:"
        Me.sec_sTarihTipi.EnterMoveNextControl = True
        Me.sec_sTarihTipi.Location = New System.Drawing.Point(5, 56)
        Me.sec_sTarihTipi.Name = "sec_sTarihTipi"
        Me.sec_sTarihTipi.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.sec_sTarihTipi.Properties.Appearance.Options.UseBackColor = True
        Me.sec_sTarihTipi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sTarihTipi.Properties.Items.AddRange(New Object() {"Tarih:", "Kayıt Tarihi:", "Valor Tarihi:"})
        Me.sec_sTarihTipi.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_sTarihTipi.Size = New System.Drawing.Size(104, 26)
        Me.sec_sTarihTipi.TabIndex = 57
        '
        'txt_sKaydeden
        '
        Me.txt_sKaydeden.Location = New System.Drawing.Point(627, 84)
        Me.txt_sKaydeden.MenuManager = Me.BarManager1
        Me.txt_sKaydeden.Name = "txt_sKaydeden"
        Me.txt_sKaydeden.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_sKaydeden.Size = New System.Drawing.Size(122, 26)
        Me.txt_sKaydeden.TabIndex = 56
        '
        'sec_sdepo
        '
        Me.sec_sdepo.EditValue = "[Tümü]"
        Me.sec_sdepo.EnterMoveNextControl = True
        Me.sec_sdepo.Location = New System.Drawing.Point(114, 141)
        Me.sec_sdepo.Name = "sec_sdepo"
        Me.sec_sdepo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sdepo.Properties.PopupControl = Me.sec_grid
        Me.sec_sdepo.Properties.ShowPopupCloseButton = False
        Me.sec_sdepo.Size = New System.Drawing.Size(160, 26)
        Me.sec_sdepo.TabIndex = 8
        '
        'sec_grid
        '
        Me.sec_grid.Controls.Add(Me.GridControl2)
        Me.sec_grid.Location = New System.Drawing.Point(91, 41)
        Me.sec_grid.Name = "sec_grid"
        Me.sec_grid.Size = New System.Drawing.Size(371, 183)
        Me.sec_grid.TabIndex = 57
        '
        'GridControl2
        '
        Me.GridControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl2.Location = New System.Drawing.Point(0, 0)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.Size = New System.Drawing.Size(371, 183)
        Me.GridControl2.TabIndex = 0
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSEC, Me.colKOD, Me.colACIKLAMA})
        Me.GridView2.DetailHeight = 160
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.GridControl = Me.GridControl2
        Me.GridView2.GroupFormat = "{0}: {1} {2}"
        Me.GridView2.GroupPanelText = "Gruplamak İstediğiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView2.IndicatorWidth = 12
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsCustomization.AllowFilter = False
        Me.GridView2.OptionsCustomization.AllowGroup = False
        Me.GridView2.OptionsDetail.ShowDetailTabs = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        Me.GridView2.OptionsView.ShowIndicator = False
        '
        'colSEC
        '
        Me.colSEC.Caption = "Seçim"
        Me.colSEC.FieldName = "SEC"
        Me.colSEC.Name = "colSEC"
        Me.colSEC.Visible = True
        Me.colSEC.VisibleIndex = 0
        Me.colSEC.Width = 48
        '
        'colKOD
        '
        Me.colKOD.Caption = "Kod"
        Me.colKOD.FieldName = "KOD"
        Me.colKOD.Name = "colKOD"
        Me.colKOD.OptionsColumn.AllowFocus = False
        Me.colKOD.Visible = True
        Me.colKOD.VisibleIndex = 1
        Me.colKOD.Width = 52
        '
        'colACIKLAMA
        '
        Me.colACIKLAMA.Caption = "Açıklama"
        Me.colACIKLAMA.FieldName = "ACIKLAMA"
        Me.colACIKLAMA.Name = "colACIKLAMA"
        Me.colACIKLAMA.OptionsColumn.AllowFocus = False
        Me.colACIKLAMA.Visible = True
        Me.colACIKLAMA.VisibleIndex = 2
        Me.colACIKLAMA.Width = 128
        '
        'sec_sSatici
        '
        Me.sec_sSatici.EnterMoveNextControl = True
        Me.sec_sSatici.Location = New System.Drawing.Point(507, 141)
        Me.sec_sSatici.Name = "sec_sSatici"
        Me.sec_sSatici.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.sec_sSatici.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.sec_sSatici.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.sec_sSatici.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.sec_sSatici.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.sec_sSatici.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sSatici.Properties.DisplayMember = "sSaticiRumuzu"
        Me.sec_sSatici.Properties.NullText = "[Satici]"
        Me.sec_sSatici.Properties.ValueMember = "sSaticiRumuzu"
        Me.sec_sSatici.Size = New System.Drawing.Size(120, 26)
        Me.sec_sSatici.TabIndex = 10
        '
        'sec_resmi1
        '
        Me.sec_resmi1.Location = New System.Drawing.Point(656, 29)
        Me.sec_resmi1.Name = "sec_resmi1"
        Me.sec_resmi1.Properties.Caption = "R1"
        Me.sec_resmi1.Size = New System.Drawing.Size(77, 24)
        Me.sec_resmi1.TabIndex = 55
        '
        'sec_resmi
        '
        Me.sec_resmi.Location = New System.Drawing.Point(595, 27)
        Me.sec_resmi.Name = "sec_resmi"
        Me.sec_resmi.Properties.Caption = "R"
        Me.sec_resmi.Size = New System.Drawing.Size(51, 24)
        Me.sec_resmi.TabIndex = 54
        '
        'LabelControl15
        '
        Me.LabelControl15.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl15.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl15.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl15.Location = New System.Drawing.Point(275, 141)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(66, 29)
        Me.LabelControl15.TabIndex = 43
        Me.LabelControl15.Text = "Hareket"
        '
        'sec_sHareketTipi
        '
        Me.sec_sHareketTipi.EnterMoveNextControl = True
        Me.sec_sHareketTipi.Location = New System.Drawing.Point(347, 141)
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
        Me.sec_sHareketTipi.Size = New System.Drawing.Size(160, 26)
        Me.sec_sHareketTipi.TabIndex = 9
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.LabelControl9.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl9.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl9.Location = New System.Drawing.Point(507, 56)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(120, 28)
        Me.LabelControl9.TabIndex = 41
        Me.LabelControl9.Text = "Arasındaki"
        '
        'txt_dteFisTarihi2
        '
        Me.txt_dteFisTarihi2.EditValue = Nothing
        Me.txt_dteFisTarihi2.EnterMoveNextControl = True
        Me.txt_dteFisTarihi2.Location = New System.Drawing.Point(347, 56)
        Me.txt_dteFisTarihi2.Name = "txt_dteFisTarihi2"
        Me.txt_dteFisTarihi2.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_dteFisTarihi2.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_dteFisTarihi2.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_dteFisTarihi2.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_dteFisTarihi2.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_dteFisTarihi2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_dteFisTarihi2.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_dteFisTarihi2.Size = New System.Drawing.Size(160, 26)
        Me.txt_dteFisTarihi2.TabIndex = 3
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl11.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl11.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl11.Location = New System.Drawing.Point(283, 54)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(39, 29)
        Me.LabelControl11.TabIndex = 40
        Me.LabelControl11.Text = "ve"
        '
        'txt_dteFisTarihi1
        '
        Me.txt_dteFisTarihi1.EditValue = Nothing
        Me.txt_dteFisTarihi1.EnterMoveNextControl = True
        Me.txt_dteFisTarihi1.Location = New System.Drawing.Point(114, 56)
        Me.txt_dteFisTarihi1.Name = "txt_dteFisTarihi1"
        Me.txt_dteFisTarihi1.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_dteFisTarihi1.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_dteFisTarihi1.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_dteFisTarihi1.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_dteFisTarihi1.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_dteFisTarihi1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_dteFisTarihi1.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_dteFisTarihi1.Size = New System.Drawing.Size(160, 26)
        Me.txt_dteFisTarihi1.TabIndex = 2
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.LabelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl1.Location = New System.Drawing.Point(507, 84)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(120, 29)
        Me.LabelControl1.TabIndex = 36
        Me.LabelControl1.Text = "Kaydeden:"
        '
        'txt_lFisNo2
        '
        Me.txt_lFisNo2.EditValue = New Decimal(New Integer() {1410065407, 2, 0, 0})
        Me.txt_lFisNo2.EnterMoveNextControl = True
        Me.txt_lFisNo2.Location = New System.Drawing.Point(347, 84)
        Me.txt_lFisNo2.Name = "txt_lFisNo2"
        Me.txt_lFisNo2.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_lFisNo2.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_lFisNo2.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_lFisNo2.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_lFisNo2.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_lFisNo2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_lFisNo2.Size = New System.Drawing.Size(160, 26)
        Me.txt_lFisNo2.TabIndex = 5
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl2.Location = New System.Drawing.Point(283, 81)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(39, 28)
        Me.LabelControl2.TabIndex = 35
        Me.LabelControl2.Text = "ve"
        '
        'txt_lFisNo1
        '
        Me.txt_lFisNo1.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txt_lFisNo1.EnterMoveNextControl = True
        Me.txt_lFisNo1.Location = New System.Drawing.Point(114, 84)
        Me.txt_lFisNo1.Name = "txt_lFisNo1"
        Me.txt_lFisNo1.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_lFisNo1.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_lFisNo1.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_lFisNo1.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_lFisNo1.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_lFisNo1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_lFisNo1.Size = New System.Drawing.Size(160, 26)
        Me.txt_lFisNo1.TabIndex = 4
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl3.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl3.Location = New System.Drawing.Point(0, 84)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(104, 29)
        Me.LabelControl3.TabIndex = 34
        Me.LabelControl3.Text = "Fiş No:"
        '
        'LabelControl12
        '
        Me.LabelControl12.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl12.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl12.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl12.Location = New System.Drawing.Point(0, 141)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(104, 29)
        Me.LabelControl12.TabIndex = 29
        Me.LabelControl12.Text = "Depo:"
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl8.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl8.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl8.Location = New System.Drawing.Point(278, 27)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(56, 29)
        Me.LabelControl8.TabIndex = 23
        Me.LabelControl8.Text = "İşlem:"
        '
        'sec_nGirisCikis
        '
        Me.sec_nGirisCikis.Enabled = False
        Me.sec_nGirisCikis.EnterMoveNextControl = True
        Me.sec_nGirisCikis.Location = New System.Drawing.Point(347, 27)
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
        Me.sec_nGirisCikis.Size = New System.Drawing.Size(160, 26)
        Me.sec_nGirisCikis.TabIndex = 1
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl7.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl7.Location = New System.Drawing.Point(0, 27)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(104, 29)
        Me.LabelControl7.TabIndex = 21
        Me.LabelControl7.Text = "Fiş Tipi:"
        '
        'sec_sFisTipi
        '
        Me.sec_sFisTipi.Enabled = False
        Me.sec_sFisTipi.EnterMoveNextControl = True
        Me.sec_sFisTipi.Location = New System.Drawing.Point(114, 27)
        Me.sec_sFisTipi.Name = "sec_sFisTipi"
        Me.sec_sFisTipi.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.sec_sFisTipi.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.sec_sFisTipi.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.sec_sFisTipi.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.sec_sFisTipi.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.sec_sFisTipi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sFisTipi.Properties.DisplayMember = "sAciklama"
        Me.sec_sFisTipi.Properties.NullText = "[FişTipleri]"
        Me.sec_sFisTipi.Properties.ValueMember = "sFisTipi"
        Me.sec_sFisTipi.Size = New System.Drawing.Size(160, 26)
        Me.sec_sFisTipi.TabIndex = 0
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl10.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl10.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl10.Location = New System.Drawing.Point(0, 170)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(104, 29)
        Me.LabelControl10.TabIndex = 19
        Me.LabelControl10.Text = "Firma:"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.LabelControl6.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl6.Location = New System.Drawing.Point(507, 113)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(120, 28)
        Me.LabelControl6.TabIndex = 13
        Me.LabelControl6.Text = "Arasındaki"
        '
        'txt_lNetTutar2
        '
        Me.txt_lNetTutar2.EditValue = New Decimal(New Integer() {1410065407, 2, 0, 0})
        Me.txt_lNetTutar2.EnterMoveNextControl = True
        Me.txt_lNetTutar2.Location = New System.Drawing.Point(347, 113)
        Me.txt_lNetTutar2.Name = "txt_lNetTutar2"
        Me.txt_lNetTutar2.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_lNetTutar2.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_lNetTutar2.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_lNetTutar2.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_lNetTutar2.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_lNetTutar2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_lNetTutar2.Size = New System.Drawing.Size(160, 26)
        Me.txt_lNetTutar2.TabIndex = 7
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl5.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl5.Location = New System.Drawing.Point(283, 109)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(39, 27)
        Me.LabelControl5.TabIndex = 11
        Me.LabelControl5.Text = "ve"
        '
        'txt_lNetTutar1
        '
        Me.txt_lNetTutar1.EditValue = New Decimal(New Integer() {1410065407, 2, 0, -2147483648})
        Me.txt_lNetTutar1.EnterMoveNextControl = True
        Me.txt_lNetTutar1.Location = New System.Drawing.Point(114, 113)
        Me.txt_lNetTutar1.Name = "txt_lNetTutar1"
        Me.txt_lNetTutar1.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_lNetTutar1.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_lNetTutar1.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_lNetTutar1.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_lNetTutar1.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_lNetTutar1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_lNetTutar1.Size = New System.Drawing.Size(160, 26)
        Me.txt_lNetTutar1.TabIndex = 6
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl4.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl4.Location = New System.Drawing.Point(0, 113)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(104, 28)
        Me.LabelControl4.TabIndex = 9
        Me.LabelControl4.Text = "Tutar:"
        '
        'sec_kriter
        '
        Me.sec_kriter.EditValue = "Başlar"
        Me.sec_kriter.EnterMoveNextControl = True
        Me.sec_kriter.Location = New System.Drawing.Point(507, 170)
        Me.sec_kriter.Name = "sec_kriter"
        Me.sec_kriter.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_kriter.Properties.Items.AddRange(New Object() {"Başlar", "Biter", "Eşittir", "İçerir", "Boş", "Dolu", "Farklı", "Büyük", "Küçük", "Aralık"})
        Me.sec_kriter.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_kriter.Size = New System.Drawing.Size(120, 26)
        Me.sec_kriter.TabIndex = 13
        '
        'txt_ara
        '
        Me.txt_ara.EnterMoveNextControl = True
        Me.txt_ara.Location = New System.Drawing.Point(114, 170)
        Me.txt_ara.Name = "txt_ara"
        Me.txt_ara.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_ara.Properties.Appearance.Options.UseFont = True
        Me.txt_ara.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_ara.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_ara.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_ara.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_ara.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_ara.Properties.MaxLength = 15
        Me.txt_ara.Size = New System.Drawing.Size(233, 28)
        Me.txt_ara.TabIndex = 11
        '
        'sec_konum
        '
        Me.sec_konum.EditValue = "Kodu"
        Me.sec_konum.EnterMoveNextControl = True
        Me.sec_konum.Location = New System.Drawing.Point(347, 170)
        Me.sec_konum.Name = "sec_konum"
        Me.sec_konum.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_konum.Properties.Items.AddRange(New Object() {"Kodu", "Adı"})
        Me.sec_konum.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_konum.Size = New System.Drawing.Size(160, 26)
        Me.sec_konum.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(154, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 19)
        Me.Label1.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(152, 210)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'lbl_istihbarat
        '
        Me.lbl_istihbarat.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.lbl_istihbarat.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.lbl_istihbarat.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbl_istihbarat.Location = New System.Drawing.Point(1742, 2)
        Me.lbl_istihbarat.Name = "lbl_istihbarat"
        Me.lbl_istihbarat.Size = New System.Drawing.Size(412, 19)
        Me.lbl_istihbarat.TabIndex = 40
        Me.lbl_istihbarat.Text = "istihbarat"
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.bar1)
        Me.PanelControl2.Controls.Add(Me.label3)
        Me.PanelControl2.Controls.Add(Me.Label2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 1091)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(2156, 68)
        Me.PanelControl2.TabIndex = 1
        '
        'bar1
        '
        Me.bar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.bar1.Location = New System.Drawing.Point(2, 19)
        Me.bar1.MenuManager = Me.BarManager1
        Me.bar1.Name = "bar1"
        Me.bar1.Properties.ShowTitle = True
        Me.bar1.Size = New System.Drawing.Size(2152, 26)
        Me.bar1.TabIndex = 8
        Me.bar1.Visible = False
        '
        'label3
        '
        Me.label3.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.label3.Location = New System.Drawing.Point(2, 45)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(11, 21)
        Me.label3.TabIndex = 7
        Me.label3.Text = "*"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(13, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(205, 19)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "*** Kayıt Bulunamadı...! ***"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(2016, 11)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(120, 35)
        Me.SimpleButton2.TabIndex = 5
        Me.SimpleButton2.Text = "&Vazgeç"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(1896, 11)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(120, 35)
        Me.SimpleButton1.TabIndex = 4
        Me.SimpleButton1.Text = "&Tamam"
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.Group_Muhasebelestir)
        Me.PanelControl3.Controls.Add(Me.sec_grid)
        Me.PanelControl3.Controls.Add(Me.GridControl1)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl3.Location = New System.Drawing.Point(0, 214)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(2156, 877)
        Me.PanelControl3.TabIndex = 0
        '
        'Group_Muhasebelestir
        '
        Me.Group_Muhasebelestir.Controls.Add(Me.LabelControl17)
        Me.Group_Muhasebelestir.Controls.Add(Me.txt_dteEntegreTarihi)
        Me.Group_Muhasebelestir.Controls.Add(Me.sec_bSatisMaliyetHesapla)
        Me.Group_Muhasebelestir.Controls.Add(Me.sec_sMuhasebeIslemTuru)
        Me.Group_Muhasebelestir.Controls.Add(Me.sec_sMuhasebeEntegrasyonTuru)
        Me.Group_Muhasebelestir.Controls.Add(Me.SimpleButton4)
        Me.Group_Muhasebelestir.Controls.Add(Me.SimpleButton5)
        Me.Group_Muhasebelestir.Controls.Add(Me.LabelControl16)
        Me.Group_Muhasebelestir.Controls.Add(Me.LabelControl14)
        Me.Group_Muhasebelestir.Location = New System.Drawing.Point(477, 59)
        Me.Group_Muhasebelestir.Name = "Group_Muhasebelestir"
        Me.Group_Muhasebelestir.Size = New System.Drawing.Size(456, 202)
        Me.Group_Muhasebelestir.TabIndex = 58
        Me.Group_Muhasebelestir.Text = "Muhasebeleştirme"
        Me.Group_Muhasebelestir.Visible = False
        '
        'LabelControl17
        '
        Me.LabelControl17.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl17.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl17.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl17.Location = New System.Drawing.Point(18, 23)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(161, 28)
        Me.LabelControl17.TabIndex = 57
        Me.LabelControl17.Text = "Entegrasyon Tarihi:"
        '
        'txt_dteEntegreTarihi
        '
        Me.txt_dteEntegreTarihi.EditValue = Nothing
        Me.txt_dteEntegreTarihi.EnterMoveNextControl = True
        Me.txt_dteEntegreTarihi.Location = New System.Drawing.Point(200, 21)
        Me.txt_dteEntegreTarihi.Name = "txt_dteEntegreTarihi"
        Me.txt_dteEntegreTarihi.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_dteEntegreTarihi.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_dteEntegreTarihi.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_dteEntegreTarihi.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_dteEntegreTarihi.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_dteEntegreTarihi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_dteEntegreTarihi.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_dteEntegreTarihi.Size = New System.Drawing.Size(243, 26)
        Me.txt_dteEntegreTarihi.TabIndex = 0
        '
        'sec_bSatisMaliyetHesapla
        '
        Me.sec_bSatisMaliyetHesapla.EditValue = True
        Me.sec_bSatisMaliyetHesapla.Location = New System.Drawing.Point(197, 117)
        Me.sec_bSatisMaliyetHesapla.Name = "sec_bSatisMaliyetHesapla"
        Me.sec_bSatisMaliyetHesapla.Properties.Caption = "Satışların Maliyetini Hesapla"
        Me.sec_bSatisMaliyetHesapla.Size = New System.Drawing.Size(246, 24)
        Me.sec_bSatisMaliyetHesapla.TabIndex = 3
        '
        'sec_sMuhasebeIslemTuru
        '
        Me.sec_sMuhasebeIslemTuru.EditValue = "Entegrasyon İptal"
        Me.sec_sMuhasebeIslemTuru.EnterMoveNextControl = True
        Me.sec_sMuhasebeIslemTuru.Location = New System.Drawing.Point(200, 86)
        Me.sec_sMuhasebeIslemTuru.Name = "sec_sMuhasebeIslemTuru"
        Me.sec_sMuhasebeIslemTuru.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.sec_sMuhasebeIslemTuru.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.sec_sMuhasebeIslemTuru.Properties.Appearance.Options.UseBackColor = True
        Me.sec_sMuhasebeIslemTuru.Properties.Appearance.Options.UseForeColor = True
        Me.sec_sMuhasebeIslemTuru.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sMuhasebeIslemTuru.Properties.Items.AddRange(New Object() {"Entegrasyon İptal", "Muhasebeleştirme"})
        Me.sec_sMuhasebeIslemTuru.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_sMuhasebeIslemTuru.Size = New System.Drawing.Size(243, 26)
        Me.sec_sMuhasebeIslemTuru.TabIndex = 2
        '
        'sec_sMuhasebeEntegrasyonTuru
        '
        Me.sec_sMuhasebeEntegrasyonTuru.EditValue = "Gib'e Gönderimi İptal Et"
        Me.sec_sMuhasebeEntegrasyonTuru.EnterMoveNextControl = True
        Me.sec_sMuhasebeEntegrasyonTuru.Location = New System.Drawing.Point(200, 54)
        Me.sec_sMuhasebeEntegrasyonTuru.Name = "sec_sMuhasebeEntegrasyonTuru"
        Me.sec_sMuhasebeEntegrasyonTuru.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.sec_sMuhasebeEntegrasyonTuru.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.sec_sMuhasebeEntegrasyonTuru.Properties.Appearance.Options.UseBackColor = True
        Me.sec_sMuhasebeEntegrasyonTuru.Properties.Appearance.Options.UseForeColor = True
        Me.sec_sMuhasebeEntegrasyonTuru.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sMuhasebeEntegrasyonTuru.Properties.Items.AddRange(New Object() {"Gib'e Gönderimi İptal Et", "Bire-Bir Muhasebeleştirme", "Günlük Muhasebeleştirme", "Toplu Muhasebeleştirme"})
        Me.sec_sMuhasebeEntegrasyonTuru.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_sMuhasebeEntegrasyonTuru.Size = New System.Drawing.Size(243, 26)
        Me.sec_sMuhasebeEntegrasyonTuru.TabIndex = 1
        Me.sec_sMuhasebeEntegrasyonTuru.TabStop = False
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton4.Image = CType(resources.GetObject("SimpleButton4.Image"), System.Drawing.Image)
        Me.SimpleButton4.Location = New System.Drawing.Point(323, 151)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(120, 35)
        Me.SimpleButton4.TabIndex = 5
        Me.SimpleButton4.Text = "&Vazgeç"
        '
        'SimpleButton5
        '
        Me.SimpleButton5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton5.Image = CType(resources.GetObject("SimpleButton5.Image"), System.Drawing.Image)
        Me.SimpleButton5.Location = New System.Drawing.Point(203, 151)
        Me.SimpleButton5.Name = "SimpleButton5"
        Me.SimpleButton5.Size = New System.Drawing.Size(120, 35)
        Me.SimpleButton5.TabIndex = 4
        Me.SimpleButton5.Text = "&Tamam"
        '
        'LabelControl16
        '
        Me.LabelControl16.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl16.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl16.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl16.Location = New System.Drawing.Point(18, 84)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(161, 29)
        Me.LabelControl16.TabIndex = 11
        Me.LabelControl16.Text = "İşlem Türü:"
        '
        'LabelControl14
        '
        Me.LabelControl14.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl14.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl14.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl14.Location = New System.Drawing.Point(18, 53)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(161, 28)
        Me.LabelControl14.TabIndex = 10
        Me.LabelControl14.Text = "Entegrasyon Türü:"
        '
        'GridControl1
        '
        Me.GridControl1.ContextMenu = Me.ContextMenu1
        Me.GridControl1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GridControl1.DataMember = "Table1"
        Me.GridControl1.DataSource = Me.DataSet1
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(2, 2)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(2152, 873)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem21, Me.MenuItem23, Me.MenuItem46, Me.MenuItem47, Me.MenuItem24, Me.MenuItem18, Me.MenuItem13, Me.MenuItem39, Me.MenuItem48, Me.MenuItem50, Me.MenuItem52, Me.MenuItem43, Me.MenuItem56, Me.MenuItem58, Me.MenuItem59, Me.MenuItem15, Me.MenuItem19, Me.MenuItem16, Me.MenuItem17, Me.MenuItem22, Me.MenuItem42, Me.MenuItem20, Me.MenuItem1, Me.MenuItem2, Me.MenuItem3, Me.MenuItem4, Me.MenuItem10, Me.MenuItem25, Me.MenuItem36, Me.MenuItem32, Me.MenuItem37, Me.MenuItem14, Me.MenuItem5, Me.MenuItem6, Me.MenuItem11, Me.MenuItem7, Me.MenuItem8, Me.MenuItem12, Me.MenuItem9})
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
        'MenuItem46
        '
        Me.MenuItem46.Index = 2
        Me.MenuItem46.Shortcut = System.Windows.Forms.Shortcut.CtrlDel
        Me.MenuItem46.Text = "Sil"
        '
        'MenuItem47
        '
        Me.MenuItem47.Index = 3
        Me.MenuItem47.Text = "-"
        '
        'MenuItem24
        '
        Me.MenuItem24.Index = 4
        Me.MenuItem24.Shortcut = System.Windows.Forms.Shortcut.F2
        Me.MenuItem24.Text = "Listele"
        '
        'MenuItem18
        '
        Me.MenuItem18.Index = 5
        Me.MenuItem18.Shortcut = System.Windows.Forms.Shortcut.F4
        Me.MenuItem18.Text = "Düzelt"
        '
        'MenuItem13
        '
        Me.MenuItem13.Index = 6
        Me.MenuItem13.Text = "Faturalaştır"
        '
        'MenuItem39
        '
        Me.MenuItem39.Index = 7
        Me.MenuItem39.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem40, Me.MenuItem41})
        Me.MenuItem39.Text = "Kilit"
        '
        'MenuItem40
        '
        Me.MenuItem40.Index = 0
        Me.MenuItem40.Text = "Kilitle"
        '
        'MenuItem41
        '
        Me.MenuItem41.Index = 1
        Me.MenuItem41.Text = "Kilit Kaldır"
        '
        'MenuItem48
        '
        Me.MenuItem48.Index = 8
        Me.MenuItem48.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem49})
        Me.MenuItem48.Text = "Mikro"
        '
        'MenuItem49
        '
        Me.MenuItem49.Index = 0
        Me.MenuItem49.Text = "Gönder"
        '
        'MenuItem50
        '
        Me.MenuItem50.Index = 9
        Me.MenuItem50.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem51})
        Me.MenuItem50.Text = "Zirve"
        '
        'MenuItem51
        '
        Me.MenuItem51.Index = 0
        Me.MenuItem51.Text = "Gönder"
        '
        'MenuItem52
        '
        Me.MenuItem52.Index = 10
        Me.MenuItem52.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem53})
        Me.MenuItem52.Text = "Logo"
        '
        'MenuItem53
        '
        Me.MenuItem53.Index = 0
        Me.MenuItem53.Text = "Gönder"
        '
        'MenuItem43
        '
        Me.MenuItem43.Index = 11
        Me.MenuItem43.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem55, Me.MenuItem54, Me.MenuItem44, Me.MenuItem45, Me.MenuItem57})
        Me.MenuItem43.Text = "Muhasebe"
        '
        'MenuItem55
        '
        Me.MenuItem55.Index = 0
        Me.MenuItem55.Text = "Gib'e Gönder"
        '
        'MenuItem54
        '
        Me.MenuItem54.Index = 1
        Me.MenuItem54.Text = "Gib'den Al"
        '
        'MenuItem44
        '
        Me.MenuItem44.Index = 2
        Me.MenuItem44.Text = "Muhasebeleştir"
        '
        'MenuItem45
        '
        Me.MenuItem45.Index = 3
        Me.MenuItem45.Text = "Entegrasyonu İptal Et"
        '
        'MenuItem57
        '
        Me.MenuItem57.Index = 4
        Me.MenuItem57.Text = "Pazaryeri Fatura Gönder"
        '
        'MenuItem56
        '
        Me.MenuItem56.Index = 12
        Me.MenuItem56.Text = "Gib Fatura Önizle"
        '
        'MenuItem58
        '
        Me.MenuItem58.Index = 13
        Me.MenuItem58.Text = "Toplu Tarih Değiştir"
        '
        'MenuItem59
        '
        Me.MenuItem59.Index = 14
        Me.MenuItem59.Text = "Toplu Maliyet Güncelle"
        '
        'MenuItem15
        '
        Me.MenuItem15.Index = 15
        Me.MenuItem15.Text = "-"
        '
        'MenuItem19
        '
        Me.MenuItem19.Index = 16
        Me.MenuItem19.Shortcut = System.Windows.Forms.Shortcut.CtrlF4
        Me.MenuItem19.Text = "Firma Kartı"
        '
        'MenuItem16
        '
        Me.MenuItem16.Index = 17
        Me.MenuItem16.Shortcut = System.Windows.Forms.Shortcut.F8
        Me.MenuItem16.Text = "İletişim Bilgileri"
        '
        'MenuItem17
        '
        Me.MenuItem17.Index = 18
        Me.MenuItem17.Shortcut = System.Windows.Forms.Shortcut.F7
        Me.MenuItem17.Text = "Firma Hareketleri"
        '
        'MenuItem22
        '
        Me.MenuItem22.Index = 19
        Me.MenuItem22.Shortcut = System.Windows.Forms.Shortcut.F6
        Me.MenuItem22.Text = "Firma Bakiyesi"
        '
        'MenuItem42
        '
        Me.MenuItem42.Index = 20
        Me.MenuItem42.Shortcut = System.Windows.Forms.Shortcut.F9
        Me.MenuItem42.Text = "Notlar"
        '
        'MenuItem20
        '
        Me.MenuItem20.Index = 21
        Me.MenuItem20.Text = "-"
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 22
        Me.MenuItem1.Text = "Görünümü Düzenle"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 23
        Me.MenuItem2.Text = "Başlık Değiştir"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 24
        Me.MenuItem3.Text = "Görünümü Kaydet"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 25
        Me.MenuItem4.Shortcut = System.Windows.Forms.Shortcut.CtrlP
        Me.MenuItem4.Text = "Görünümü Yazdır"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 26
        Me.MenuItem10.Text = "-"
        '
        'MenuItem25
        '
        Me.MenuItem25.Index = 27
        Me.MenuItem25.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem28, Me.MenuItem29, Me.MenuItem30, Me.MenuItem31, Me.MenuItem26, Me.MenuItem27})
        Me.MenuItem25.Text = "Raporla"
        '
        'MenuItem28
        '
        Me.MenuItem28.Index = 0
        Me.MenuItem28.Text = "Önizle"
        '
        'MenuItem29
        '
        Me.MenuItem29.Index = 1
        Me.MenuItem29.Text = "Dizayn"
        '
        'MenuItem30
        '
        Me.MenuItem30.Index = 2
        Me.MenuItem30.Text = "Yazdır"
        '
        'MenuItem31
        '
        Me.MenuItem31.Index = 3
        Me.MenuItem31.Text = "-"
        '
        'MenuItem26
        '
        Me.MenuItem26.Index = 4
        Me.MenuItem26.Text = "Excel"
        '
        'MenuItem27
        '
        Me.MenuItem27.Index = 5
        Me.MenuItem27.Text = "Text"
        '
        'MenuItem36
        '
        Me.MenuItem36.Index = 28
        Me.MenuItem36.Text = "-"
        '
        'MenuItem32
        '
        Me.MenuItem32.Index = 29
        Me.MenuItem32.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem33, Me.MenuItem34, Me.MenuItem35, Me.MenuItem38})
        Me.MenuItem32.Text = "Döküm"
        '
        'MenuItem33
        '
        Me.MenuItem33.Index = 0
        Me.MenuItem33.Text = "Önizle"
        '
        'MenuItem34
        '
        Me.MenuItem34.Index = 1
        Me.MenuItem34.Text = "Dizayn"
        '
        'MenuItem35
        '
        Me.MenuItem35.Index = 2
        Me.MenuItem35.Text = "Yazdır"
        '
        'MenuItem38
        '
        Me.MenuItem38.Index = 3
        Me.MenuItem38.Text = "Direkt Yazdır"
        '
        'MenuItem37
        '
        Me.MenuItem37.Index = 30
        Me.MenuItem37.Text = "-"
        '
        'MenuItem14
        '
        Me.MenuItem14.Index = 31
        Me.MenuItem14.Text = "Hızlı Filtre"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 32
        Me.MenuItem5.Text = "Filtrele"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 33
        Me.MenuItem6.Text = "Gruplandır"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 34
        Me.MenuItem11.Text = "-"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 35
        Me.MenuItem7.Text = "Satırları Aç"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 36
        Me.MenuItem8.Text = "Satırları Kapat"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 37
        Me.MenuItem12.Text = "-"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 38
        Me.MenuItem9.Shortcut = System.Windows.Forms.Shortcut.F12
        Me.MenuItem9.Text = "Ekranı Kapla"
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
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.coldteFisTarihi, Me.collFisNo, Me.colnGirisCikis, Me.collToplamMiktar, Me.collNetTutar, Me.colsDepo, Me.colDepo, Me.colsTransferDepo, Me.coltDepo, Me.colsKodu, Me.colsAciklama, Me.colsFaturalasti, Me.colMuhasebelesti, Me.colsHareketTipi, Me.colsNot, Me.colTamamlandi, Me.collTevkifatKdvMatrahi, Me.collTevkifatKdv, Me.colHizmet, Me.colnFirmaID, Me.colsFisTipi, Me.colnStokFisiID, Me.colKdvTutari, Me.colKdvMatrahi, Me.collMalIskontoTutari, Me.collMalBedeli, Me.colEkMaliyet, Me.colISKONTO, Me.colEkOran, Me.colbPesinmi, Me.collOTV2, Me.colnSayfa, Me.colsKullaniciAdi, Me.coldteKayitTarihi, Me.colbKilitli, Me.colsYazdirma, Me.colsOnizleme, Me.colsBelgeTipi, Me.colnEvrakNo, Me.colsSinifKodu1, Me.colsSinifKodu2, Me.colsCariSinif3, Me.coldteVadeTarihi, Me.colsAciklama1, Me.colGibFaturaNo, Me.colsEfaturaUrl})
        Me.GridView1.CustomizationFormBounds = New System.Drawing.Rectangle(796, 271, 208, 156)
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        StyleFormatCondition1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        StyleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        StyleFormatCondition1.Appearance.Options.UseFont = True
        StyleFormatCondition1.Appearance.Options.UseForeColor = True
        StyleFormatCondition1.ApplyToRow = True
        StyleFormatCondition1.Column = Me.colbPesinmi
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition1.Value1 = True
        Me.GridView1.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupPanelText = "Gruplamak İstediğiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "MIKTAR", Nothing, "{0:#,0.##}")})
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
        Me.GridView1.OptionsView.EnableAppearanceEvenRow = True
        Me.GridView1.OptionsView.EnableAppearanceOddRow = True
        Me.GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'coldteFisTarihi
        '
        Me.coldteFisTarihi.Caption = "Tarih"
        Me.coldteFisTarihi.FieldName = "dteFisTarihi"
        Me.coldteFisTarihi.Name = "coldteFisTarihi"
        Me.coldteFisTarihi.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "dteFisTarihi", "{0} Kayıt")})
        Me.coldteFisTarihi.Visible = True
        Me.coldteFisTarihi.VisibleIndex = 0
        Me.coldteFisTarihi.Width = 92
        '
        'collFisNo
        '
        Me.collFisNo.Caption = "Fiş No"
        Me.collFisNo.FieldName = "lFisNo"
        Me.collFisNo.Name = "collFisNo"
        Me.collFisNo.Visible = True
        Me.collFisNo.VisibleIndex = 2
        Me.collFisNo.Width = 48
        '
        'colnGirisCikis
        '
        Me.colnGirisCikis.Caption = "Giriş/Çıkış"
        Me.colnGirisCikis.FieldName = "nGirisCikis"
        Me.colnGirisCikis.Name = "colnGirisCikis"
        Me.colnGirisCikis.Width = 55
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
        Me.collToplamMiktar.VisibleIndex = 3
        Me.collToplamMiktar.Width = 72
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
        Me.collNetTutar.VisibleIndex = 8
        Me.collNetTutar.Width = 131
        '
        'colsDepo
        '
        Me.colsDepo.Caption = "DepoKodu"
        Me.colsDepo.FieldName = "sDepo"
        Me.colsDepo.Name = "colsDepo"
        '
        'colDepo
        '
        Me.colDepo.Caption = "DepoAdı"
        Me.colDepo.FieldName = "Depo"
        Me.colDepo.Name = "colDepo"
        '
        'colsTransferDepo
        '
        Me.colsTransferDepo.Caption = "Transfer Depo"
        Me.colsTransferDepo.FieldName = "sTransferDepo"
        Me.colsTransferDepo.Name = "colsTransferDepo"
        '
        'coltDepo
        '
        Me.coltDepo.Caption = "Transfer Depo Adı"
        Me.coltDepo.FieldName = "tDepo"
        Me.coltDepo.Name = "coltDepo"
        '
        'colsKodu
        '
        Me.colsKodu.Caption = "Firma Kodu"
        Me.colsKodu.FieldName = "sKodu"
        Me.colsKodu.Name = "colsKodu"
        Me.colsKodu.Width = 142
        '
        'colsAciklama
        '
        Me.colsAciklama.Caption = "Firma Adı"
        Me.colsAciklama.FieldName = "sAciklama"
        Me.colsAciklama.Name = "colsAciklama"
        Me.colsAciklama.Visible = True
        Me.colsAciklama.VisibleIndex = 1
        Me.colsAciklama.Width = 147
        '
        'colsFaturalasti
        '
        Me.colsFaturalasti.Caption = "Faturalaştı ?"
        Me.colsFaturalasti.FieldName = "sFaturalasti"
        Me.colsFaturalasti.Name = "colsFaturalasti"
        Me.colsFaturalasti.Visible = True
        Me.colsFaturalasti.VisibleIndex = 18
        '
        'colMuhasebelesti
        '
        Me.colMuhasebelesti.Caption = "Muhasebeleşti"
        Me.colMuhasebelesti.FieldName = "Muhasebelesti"
        Me.colMuhasebelesti.Name = "colMuhasebelesti"
        '
        'colsHareketTipi
        '
        Me.colsHareketTipi.Caption = "Hareket Tipi"
        Me.colsHareketTipi.FieldName = "sHareketTipi"
        Me.colsHareketTipi.Name = "colsHareketTipi"
        Me.colsHareketTipi.Width = 67
        '
        'colsNot
        '
        Me.colsNot.Caption = "Notlar"
        Me.colsNot.FieldName = "sNot"
        Me.colsNot.Name = "colsNot"
        Me.colsNot.Visible = True
        Me.colsNot.VisibleIndex = 9
        Me.colsNot.Width = 187
        '
        'colTamamlandi
        '
        Me.colTamamlandi.Caption = "Tamamlandi?"
        Me.colTamamlandi.FieldName = "Tamamlandi"
        Me.colTamamlandi.Name = "colTamamlandi"
        Me.colTamamlandi.Width = 82
        '
        'collTevkifatKdvMatrahi
        '
        Me.collTevkifatKdvMatrahi.Caption = "Tevkifat Kdv Matrahı"
        Me.collTevkifatKdvMatrahi.FieldName = "lTevkifatKdvMatrahi"
        Me.collTevkifatKdvMatrahi.Name = "collTevkifatKdvMatrahi"
        '
        'collTevkifatKdv
        '
        Me.collTevkifatKdv.Caption = "Tevkifat Kdv"
        Me.collTevkifatKdv.FieldName = "lTevkifatKdv"
        Me.collTevkifatKdv.Name = "collTevkifatKdv"
        '
        'colHizmet
        '
        Me.colHizmet.Caption = "Hizmet?"
        Me.colHizmet.FieldName = "Hizmet"
        Me.colHizmet.Name = "colHizmet"
        '
        'colnFirmaID
        '
        Me.colnFirmaID.Caption = "Firma No"
        Me.colnFirmaID.FieldName = "nFirmaID"
        Me.colnFirmaID.Name = "colnFirmaID"
        '
        'colsFisTipi
        '
        Me.colsFisTipi.Caption = "FisTipi"
        Me.colsFisTipi.FieldName = "sFisTipi"
        Me.colsFisTipi.Name = "colsFisTipi"
        Me.colsFisTipi.Width = 44
        '
        'colnStokFisiID
        '
        Me.colnStokFisiID.Caption = "Kayıt No"
        Me.colnStokFisiID.FieldName = "nStokFisiID"
        Me.colnStokFisiID.Name = "colnStokFisiID"
        '
        'colKdvTutari
        '
        Me.colKdvTutari.Caption = "Kdv Tutarı"
        Me.colKdvTutari.DisplayFormat.FormatString = "#,#.##"
        Me.colKdvTutari.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colKdvTutari.FieldName = "KdvTutari"
        Me.colKdvTutari.Name = "colKdvTutari"
        Me.colKdvTutari.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "KdvTutari", "{0:#,0.00}")})
        Me.colKdvTutari.Visible = True
        Me.colKdvTutari.VisibleIndex = 7
        Me.colKdvTutari.Width = 73
        '
        'colKdvMatrahi
        '
        Me.colKdvMatrahi.Caption = "Kdv Matrahı"
        Me.colKdvMatrahi.DisplayFormat.FormatString = "#,0.00"
        Me.colKdvMatrahi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colKdvMatrahi.FieldName = "KdvMatrahi"
        Me.colKdvMatrahi.Name = "colKdvMatrahi"
        Me.colKdvMatrahi.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "KdvMatrahi", "{0:#,0.00}")})
        '
        'collMalIskontoTutari
        '
        Me.collMalIskontoTutari.Caption = "İskonto"
        Me.collMalIskontoTutari.DisplayFormat.FormatString = "#,#.##"
        Me.collMalIskontoTutari.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collMalIskontoTutari.FieldName = "lIskontoTutari"
        Me.collMalIskontoTutari.Name = "collMalIskontoTutari"
        Me.collMalIskontoTutari.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lIskontoTutari", "{0:#,0.00}")})
        Me.collMalIskontoTutari.Visible = True
        Me.collMalIskontoTutari.VisibleIndex = 5
        Me.collMalIskontoTutari.Width = 85
        '
        'collMalBedeli
        '
        Me.collMalBedeli.Caption = "Brüt"
        Me.collMalBedeli.DisplayFormat.FormatString = "#,0.00"
        Me.collMalBedeli.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collMalBedeli.FieldName = "lMalBedeli"
        Me.collMalBedeli.Name = "collMalBedeli"
        Me.collMalBedeli.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lMalBedeli", "{0:#,0.00}")})
        Me.collMalBedeli.Visible = True
        Me.collMalBedeli.VisibleIndex = 4
        Me.collMalBedeli.Width = 85
        '
        'colEkMaliyet
        '
        Me.colEkMaliyet.Caption = "Ek Maliyet"
        Me.colEkMaliyet.DisplayFormat.FormatString = "#,#.##"
        Me.colEkMaliyet.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colEkMaliyet.FieldName = "EkMaliyet"
        Me.colEkMaliyet.Name = "colEkMaliyet"
        Me.colEkMaliyet.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "EkMaliyet", "{0:#,0.00}")})
        Me.colEkMaliyet.Width = 52
        '
        'colISKONTO
        '
        Me.colISKONTO.Caption = "% İsk."
        Me.colISKONTO.DisplayFormat.FormatString = "P"
        Me.colISKONTO.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colISKONTO.FieldName = "ISKONTO"
        Me.colISKONTO.Name = "colISKONTO"
        Me.colISKONTO.Visible = True
        Me.colISKONTO.VisibleIndex = 6
        Me.colISKONTO.Width = 46
        '
        'colEkOran
        '
        Me.colEkOran.Caption = "% Ek Oran"
        Me.colEkOran.DisplayFormat.FormatString = "P"
        Me.colEkOran.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colEkOran.FieldName = "EkOran"
        Me.colEkOran.Name = "colEkOran"
        Me.colEkOran.Width = 66
        '
        'collOTV2
        '
        Me.collOTV2.Caption = "OTV2"
        Me.collOTV2.FieldName = "lOTV2"
        Me.collOTV2.Name = "collOTV2"
        Me.collOTV2.Width = 91
        '
        'colnSayfa
        '
        Me.colnSayfa.Caption = "Sayfa"
        Me.colnSayfa.FieldName = "nSayfa"
        Me.colnSayfa.Name = "colnSayfa"
        '
        'colsKullaniciAdi
        '
        Me.colsKullaniciAdi.Caption = "Kaydeden"
        Me.colsKullaniciAdi.FieldName = "sKullaniciAdi"
        Me.colsKullaniciAdi.Name = "colsKullaniciAdi"
        '
        'coldteKayitTarihi
        '
        Me.coldteKayitTarihi.Caption = "Kayıt Tarihi"
        Me.coldteKayitTarihi.DisplayFormat.FormatString = "dd/MM/yyyy HH:m:s t"
        Me.coldteKayitTarihi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.coldteKayitTarihi.FieldName = "dteKayitTarihi"
        Me.coldteKayitTarihi.Name = "coldteKayitTarihi"
        '
        'colbKilitli
        '
        Me.colbKilitli.Caption = "Kilitli?"
        Me.colbKilitli.FieldName = "bKilitli"
        Me.colbKilitli.Name = "colbKilitli"
        Me.colbKilitli.Visible = True
        Me.colbKilitli.VisibleIndex = 10
        Me.colbKilitli.Width = 48
        '
        'colsYazdirma
        '
        Me.colsYazdirma.Caption = "Yazdırma"
        Me.colsYazdirma.FieldName = "sYazdirma"
        Me.colsYazdirma.Name = "colsYazdirma"
        Me.colsYazdirma.Visible = True
        Me.colsYazdirma.VisibleIndex = 11
        '
        'colsOnizleme
        '
        Me.colsOnizleme.Caption = "Belge Durum"
        Me.colsOnizleme.FieldName = "nEfaturaDurum"
        Me.colsOnizleme.Name = "colsOnizleme"
        '
        'colsBelgeTipi
        '
        Me.colsBelgeTipi.Caption = "Belge Tipi"
        Me.colsBelgeTipi.FieldName = "sEfaturaTipi"
        Me.colsBelgeTipi.Name = "colsBelgeTipi"
        '
        'colnEvrakNo
        '
        Me.colnEvrakNo.Caption = "Evrak No"
        Me.colnEvrakNo.FieldName = "nEvrakNo"
        Me.colnEvrakNo.Name = "colnEvrakNo"
        Me.colnEvrakNo.Visible = True
        Me.colnEvrakNo.VisibleIndex = 12
        '
        'colsSinifKodu1
        '
        Me.colsSinifKodu1.Caption = "Cari Sınıf1"
        Me.colsSinifKodu1.FieldName = "sCariSinif1"
        Me.colsSinifKodu1.Name = "colsSinifKodu1"
        Me.colsSinifKodu1.Visible = True
        Me.colsSinifKodu1.VisibleIndex = 13
        '
        'colsSinifKodu2
        '
        Me.colsSinifKodu2.Caption = "Cari Sınıf2"
        Me.colsSinifKodu2.FieldName = "sCariSinif2"
        Me.colsSinifKodu2.Name = "colsSinifKodu2"
        Me.colsSinifKodu2.Visible = True
        Me.colsSinifKodu2.VisibleIndex = 14
        '
        'colsCariSinif3
        '
        Me.colsCariSinif3.Caption = "Cari Sınıf3"
        Me.colsCariSinif3.FieldName = "sCariSinif3"
        Me.colsCariSinif3.Name = "colsCariSinif3"
        Me.colsCariSinif3.Visible = True
        Me.colsCariSinif3.VisibleIndex = 15
        '
        'coldteVadeTarihi
        '
        Me.coldteVadeTarihi.Caption = "Vade Tarihi"
        Me.coldteVadeTarihi.FieldName = "dteValorTarihi"
        Me.coldteVadeTarihi.Name = "coldteVadeTarihi"
        Me.coldteVadeTarihi.Visible = True
        Me.coldteVadeTarihi.VisibleIndex = 16
        '
        'colsAciklama1
        '
        Me.colsAciklama1.Caption = "Açıklama1"
        Me.colsAciklama1.FieldName = "sAciklama1"
        Me.colsAciklama1.Name = "colsAciklama1"
        Me.colsAciklama1.Visible = True
        Me.colsAciklama1.VisibleIndex = 17
        '
        'colGibFaturaNo
        '
        Me.colGibFaturaNo.Caption = "Gib Fatura No"
        Me.colGibFaturaNo.FieldName = "GibFaturaNo"
        Me.colGibFaturaNo.Name = "colGibFaturaNo"
        Me.colGibFaturaNo.Visible = True
        Me.colGibFaturaNo.VisibleIndex = 19
        '
        'colsEfaturaUrl
        '
        Me.colsEfaturaUrl.Caption = "e-Fatura Link"
        Me.colsEfaturaUrl.FieldName = "sEfaturaUrl"
        Me.colsEfaturaUrl.Name = "colsEfaturaUrl"
        Me.colsEfaturaUrl.Visible = True
        Me.colsEfaturaUrl.VisibleIndex = 20
        Me.colsEfaturaUrl.Width = 200
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
        Me.printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", "Fiş Listesi", "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Stok Yönetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Me.printlink1.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.printlink1.PrintingSystem = Me.ps
        Me.printlink1.PrintingSystemBase = Me.ps
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frm_fatura_liste
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(8, 20)
        Me.ClientSize = New System.Drawing.Size(2156, 1189)
        Me.ContextMenu = Me.ContextMenu1
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_fatura_liste"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fiş Listesi"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.sec_Aktar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_bFaturayaDonustumu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sTarihTipi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sKaydeden.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sdepo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.sec_grid.ResumeLayout(False)
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sSatici.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_resmi1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_resmi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sHareketTipi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_dteFisTarihi2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_dteFisTarihi2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_dteFisTarihi1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_dteFisTarihi1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_lFisNo2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_lFisNo1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_nGirisCikis.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sFisTipi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_lNetTutar2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_lNetTutar1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_kriter.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ara.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_konum.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.bar1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.Group_Muhasebelestir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Group_Muhasebelestir.ResumeLayout(False)
        CType(Me.txt_dteEntegreTarihi.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_dteEntegreTarihi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_bSatisMaliyetHesapla.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sMuhasebeIslemTuru.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sMuhasebeEntegrasyonTuru.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
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
    Public sKodu As String
    Public nFirmaID As Int64 = 0
    Dim sCon = New OleDbConnection
    Dim sCmd = New OleDbCommand
    Dim sConnectionLogo = ""
    Dim count As String = ""
    Public islemstatus As Boolean = False
    Dim ds_tbFisTipi As DataSet
    Dim ds_tbGirisCikis As DataSet
    Dim ds_tbDepo As DataSet
    Dim ds_tbHareketTipi As DataSet
    Dim ds_satir_firma As DataSet
    Dim ds_tbSatici As DataSet
    Public sFisTipi As String = ""
    Public nGirisCikis As Int64 = 1
    Dim status As Boolean = False
    Public kapla As Boolean = False
    Dim bInfo As Boolean = False
    Dim nFaturaCiktiSatirSayisi As Integer = 25
    Dim nIrsaliyeCiktiSatirSayisi As Integer = 25
    Dim nStokFisiCiktiSatirSayisi As Integer = 25
    Dim sSorgu_Hareket As String = ""
    Dim sKriter As String = ""
    Dim sorgu_txt_baslik As String = ""
    Dim sorgu_txt_hareket As String = ""
    Dim sorgu_txt_toplam As String = ""
    Dim sorgu_txt_imports As String = ""
    Dim sorgu_txt_dtoplam As String = ""
    Dim sorgu_txt_kesinti As String = ""
    Dim nSayfaSayisi As Integer = 1
    Public s_nIslemID As String = ""
    Dim dr_baslik As DataRow
    Dim ds_baslik As DataSet
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
    Private Sub gorunum_kaydet()
        GridView1.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\" & Me.Name.ToString & "")
        XtraMessageBox.Show(Sorgu_sDil("Görünüm Kaydedildi", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub gorunum_yukle()
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
        sec_sTarihTipi.Text = Sorgu_sDil(sec_sTarihTipi.Text, sDil)
        LabelControl15.Text = Sorgu_sDil(LabelControl15.Text, sDil)
        SimpleButton1.Text = Sorgu_sDil(SimpleButton1.Text, sDil)
        SimpleButton2.Text = Sorgu_sDil(SimpleButton2.Text, sDil)
        SimpleButton3.Text = Sorgu_sDil(SimpleButton3.Text, sDil)
        GridView1.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\" & Me.Name.ToString & "")
    End Sub
    Private Sub gorunum_yazdir()
        Dim kriter As String = ""
        kriter += "EvrakTipi = " & Trim(sec_sFisTipi.Text) & vbTab & " Islem = " & Trim(sec_nGirisCikis.Text)
        kriter += txt_dteFisTarihi1.EditValue & " ve " & txt_dteFisTarihi2.EditValue & " Tarihleri Arasındaki" & vbCrLf
        kriter += "FisNo: " & txt_lFisNo1.Text & " ve " & txt_lFisNo1.Text & " Arasindaki " & "Depo = " & sec_sdepo.Text & " "
        printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", kriter, "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Stok Yönetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        printlink1.CreateDocument(ps)
        ps.PreviewRibbonFormEx.Show()
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
    Private Function sorgu(ByVal query As String, Optional ByVal sTable As String = "TABLE1") As DataSet
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
        Dim N As Integer = adapter.Fill(DS, sTable)
        con.Close()
        Return DS
    End Function
    Private Function uzunluk_tamamla(ByVal deger As String, ByVal uzunluk As Long, Optional ByVal simge As String = "0") As String
        deger = FormatNumber(deger, 2, TriState.UseDefault, TriState.UseDefault, TriState.UseDefault)
        If (Len(deger) < uzunluk) Then
            Dim num3 As Integer = (CInt(uzunluk) - Len(deger))
            Dim i As Integer = 1
            Do While (i <= num3)
                deger = deger.Insert(0, simge)
                i += 1
            Loop
        End If
        Return deger
    End Function
    '********** Logo Entegre Logo Entegre   Logo Entegre************
    Private Function CLFLINE_kaydet_yeni(ByVal LOGICALREF As Object, ByVal CLIENTREF As Object, ByVal CLACCREF As Object, ByVal CLCENTERREF As Object, ByVal CASHCENTERREF As Object, ByVal CASHACCOUNTREF As Object, ByVal VIRMANREF As Object, ByVal SOURCEFREF As Object, ByVal DATE_ As Object, ByVal DEPARTMENT As Object, ByVal BRANCH As Object, ByVal MODULENR As Object, ByVal TRCODE As Object, ByVal LINENR As Object, ByVal SPECODE As Object, ByVal CYPHCODE As Object, ByVal TRANNO As Object, ByVal DOCODE As Object, ByVal LINEEXP As Object, ByVal ACCOUNTED As Object, ByVal SIGN As Object, ByVal AMOUNT As Object, ByVal TRCURR As Object, ByVal TRRATE As Object, ByVal TRNET As Object, ByVal REPORTRATE As Object, ByVal REPORTNET As Object, ByVal EXTENREF As Object, ByVal PAYDEFREF As Object, ByVal ACCFICHEREF As Object, ByVal PRINTCNT As Object, ByVal CAPIBLOCK_CREATEDBY As Object, ByVal CAPIBLOCK_CREADEDDATE As Object, ByVal CAPIBLOCK_CREATEDHOUR As Object, ByVal CAPIBLOCK_CREATEDMIN As Object, ByVal CAPIBLOCK_CREATEDSEC As Object, ByVal CAPIBLOCK_MODIFIEDBY As Object, ByVal CAPIBLOCK_MODIFIEDDATE As Object, ByVal CAPIBLOCK_MODIFIEDHOUR As Object, ByVal CAPIBLOCK_MODIFIEDMIN As Object, ByVal CAPIBLOCK_MODIFIEDSEC As Object, ByVal CANCELLED As Object, ByVal TRGFLAG As Object, ByVal TRADINGGRP As Object, ByVal LINEEXCTYP As Object, ByVal ONLYONEPAYLINE As Object, ByVal DISCFLAG As Object, ByVal DISCRATE As Object, ByVal VATRATE As Object, ByVal CASHAMOUNT As Object, ByVal DISCACCREF As Object, ByVal DISCCENREF As Object, ByVal VATRACCREF As Object, ByVal VATRCENREF As Object, ByVal PAYMENTREF As Object, ByVal VATAMOUNT As Object, ByVal SITEID As Object, ByVal RECSTATUS As Object, ByVal ORGLOGICREF As Object, ByVal INFIDX As Object, ByVal POSCOMMACCREF As Object, ByVal POSCOMMCENREF As Object, ByVal POINTCOMMACCREF As Object, ByVal POINTCOMMCENREF As Object, ByVal CHEQINFO As Object, ByVal CREDITCNO As Object, ByVal CLPRJREF As Object, ByVal STATUS As Object, ByVal EXIMFILEREF As Object, ByVal EXIMPROCNR As Object, ByVal MONTH_ As Object, ByVal YEAR_ As Object, ByVal FUNDSHARERAT As Object, ByVal AFFECTCOLLATRL As Object, ByVal GRPFIRMTRANS As Object, ByVal REFLVATACCREF As Object, ByVal REFLVATOTHACCREF As Object, ByVal AFFECTRISK As Object, ByVal BATCHNR As Object, ByVal APPROVENR As Object, ByVal BATCHNUM As Object, ByVal APPROVENUM As Object, ByVal EUVATSTATUS As Object, ByVal ORGLOGOID As Object) As Long
        Try
            If (Me.sCon.State = ConnectionState.Closed) Then
                Me.sCon.Open()
            End If
        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            Dim exception As Exception = exception1
            Me.sCon.Close()
            Me.sCon.Open()
            ProjectData.ClearProjectError()
        End Try
        Me.sCmd.CommandText = Me.sorgu_query(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED  SET DATEFORMAT DMY INSERT INTO LG_*!F_!D_CLFLINE( CLIENTREF, CLACCREF, CLCENTERREF, CASHCENTERREF, CASHACCOUNTREF, VIRMANREF, SOURCEFREF, DATE_, DEPARTMENT, BRANCH, MODULENR, TRCODE, LINENR, SPECODE, CYPHCODE, TRANNO, DOCODE, LINEEXP, ACCOUNTED, SIGN, AMOUNT, TRCURR, TRRATE, TRNET, REPORTRATE, REPORTNET, EXTENREF, PAYDEFREF, ACCFICHEREF, PRINTCNT, CAPIBLOCK_CREATEDBY, CAPIBLOCK_CREADEDDATE, CAPIBLOCK_CREATEDHOUR, CAPIBLOCK_CREATEDMIN, CAPIBLOCK_CREATEDSEC, CAPIBLOCK_MODIFIEDBY, CAPIBLOCK_MODIFIEDDATE, CAPIBLOCK_MODIFIEDHOUR, CAPIBLOCK_MODIFIEDMIN, CAPIBLOCK_MODIFIEDSEC, CANCELLED, TRGFLAG, TRADINGGRP, LINEEXCTYP, ONLYONEPAYLINE, DISCFLAG, DISCRATE, VATRATE, CASHAMOUNT, DISCACCREF, DISCCENREF, VATRACCREF, VATRCENREF, PAYMENTREF, VATAMOUNT, SITEID, RECSTATUS, ORGLOGICREF, INFIDX, POSCOMMACCREF, POSCOMMCENREF, POINTCOMMACCREF, POINTCOMMCENREF, CHEQINFO, CREDITCNO, CLPRJREF, STATUS, EXIMFILEREF, EXIMPROCNR, MONTH_, YEAR_, FUNDSHARERAT, AFFECTCOLLATRL, GRPFIRMTRANS, REFLVATACCREF, REFLVATOTHACCREF, AFFECTRISK, BATCHNR, APPROVENR, BATCHNUM, APPROVENUM, EUVATSTATUS, ORGLOGOID) VALUES ( ", CLIENTREF), " , "), CLACCREF), " , "), CLCENTERREF), " , "), CASHCENTERREF), " , "), CASHACCOUNTREF), " , "), VIRMANREF), " , "), SOURCEFREF), " , '"), DATE_), "' , "), DEPARTMENT), " , "), BRANCH), " , "), MODULENR), " , "), TRCODE), " , "), LINENR), " , '"), SPECODE), "' , '"), CYPHCODE), "' , "), TRANNO), " , '"), DOCODE), "' , '"), LINEEXP), "' , "), ACCOUNTED), " , "), SIGN), " , "), AMOUNT), " , "), TRCURR), " , "), TRRATE), " , "), TRNET), " , "), REPORTRATE), " , "), REPORTNET), " , "), EXTENREF), " , "), PAYDEFREF), " , "), ACCFICHEREF), " , "), PRINTCNT), " , "), CAPIBLOCK_CREATEDBY), " , '"), CAPIBLOCK_CREADEDDATE), "' , "), CAPIBLOCK_CREATEDHOUR), " , "), CAPIBLOCK_CREATEDMIN), " , "), CAPIBLOCK_CREATEDSEC), " , "), CAPIBLOCK_MODIFIEDBY), " , '"), CAPIBLOCK_MODIFIEDDATE), "' , "), CAPIBLOCK_MODIFIEDHOUR), " , "), CAPIBLOCK_MODIFIEDMIN), " , "), CAPIBLOCK_MODIFIEDSEC), " , "), CANCELLED), " , "), TRGFLAG), " , '"), TRADINGGRP), "' , "), LINEEXCTYP), " , "), ONLYONEPAYLINE), " , "), DISCFLAG), " , "), DISCRATE), " , "), VATRATE), " , "), CASHAMOUNT), " , "), DISCACCREF), " , "), DISCCENREF), " , "), VATRACCREF), " , "), VATRCENREF), " , "), PAYMENTREF), " , "), VATAMOUNT), " , "), SITEID), " , "), RECSTATUS), " , "), ORGLOGICREF), " , "), INFIDX), " , "), POSCOMMACCREF), " , "), POSCOMMCENREF), " , "), POINTCOMMACCREF), " , "), POINTCOMMCENREF), " , '"), CHEQINFO), "' , '"), CREDITCNO), "' , "), CLPRJREF), " , "), STATUS), " , "), EXIMFILEREF), " , "), EXIMPROCNR), " , "), MONTH_), " , "), YEAR_), " , "), FUNDSHARERAT), " , "), AFFECTCOLLATRL), " , "), GRPFIRMTRANS), " , "), REFLVATACCREF), " , "), REFLVATOTHACCREF), " , "), AFFECTRISK), " , "), BATCHNR), " , "), APPROVENR), " , '"), BATCHNUM), "' , '"), APPROVENUM), "' , "), EUVATSTATUS), " , '"), ORGLOGOID), "' )")))
        Me.sCmd.ExecuteNonQuery()
        Me.sCmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        LOGICALREF = RuntimeHelpers.GetObjectValue(Me.sCmd.ExecuteScalar)
        Return Conversions.ToLong(LOGICALREF)
    End Function
    Private Function ITEMS_kaydet_yeni(ByVal LOGICALREF As Object, ByVal ACTIVE As Object, ByVal CARDTYPE As Object, ByVal CODE As Object, ByVal NAME As Object, ByVal STGRPCODE As Object, ByVal PRODUCERCODE As Object, ByVal SPECODE As Object, ByVal CYPHCODE As Object, ByVal CLASSTYPE As Object, ByVal PURCHBRWS As Object, ByVal SALESBRWS As Object, ByVal MTRLBRWS As Object, ByVal VAT As Object, ByVal PAYMENTREF As Object, ByVal TRACKTYPE As Object, ByVal LOCTRACKING As Object, ByVal TOOL As Object, ByVal AUTOINCSL As Object, ByVal DIVLOTSIZE As Object, ByVal SHELFLIFE As Object, ByVal SHELFDATE As Object, ByVal DOMINANTREFS1 As Object, ByVal DOMINANTREFS2 As Object, ByVal DOMINANTREFS3 As Object, ByVal DOMINANTREFS4 As Object, ByVal DOMINANTREFS5 As Object, ByVal DOMINANTREFS6 As Object, ByVal DOMINANTREFS7 As Object, ByVal DOMINANTREFS8 As Object, ByVal DOMINANTREFS9 As Object, ByVal DOMINANTREFS10 As Object, ByVal DOMINANTREFS11 As Object, ByVal DOMINANTREFS12 As Object, ByVal IMAGEINC As Object, ByVal TEXTINC As Object, ByVal DEPRTYPE As Object, ByVal DEPRRATE As Object, ByVal DEPRDUR As Object, ByVal SALVAGEVAL As Object, ByVal REVALFLAG As Object, ByVal REVDEPRFLAG As Object, ByVal PARTDEP As Object, ByVal DEPRTYPE2 As Object, ByVal DEPRRATE2 As Object, ByVal DEPRDUR2 As Object, ByVal REVALFLAG2 As Object, ByVal REVDEPRFLAG2 As Object, ByVal PARTDEP2 As Object, ByVal APPROVED As Object, ByVal UNITSETREF As Object, ByVal QCCSETREF As Object, ByVal DISTAMOUNT As Object, ByVal CAPIBLOCK_CREATEDBY As Object, ByVal CAPIBLOCK_CREADEDDATE As Object, ByVal CAPIBLOCK_CREATEDHOUR As Object, ByVal CAPIBLOCK_CREATEDMIN As Object, ByVal CAPIBLOCK_CREATEDSEC As Object, ByVal CAPIBLOCK_MODIFIEDBY As Object, ByVal CAPIBLOCK_MODIFIEDDATE As Object, ByVal CAPIBLOCK_MODIFIEDHOUR As Object, ByVal CAPIBLOCK_MODIFIEDMIN As Object, ByVal CAPIBLOCK_MODIFIEDSEC As Object, ByVal SITEID As Object, ByVal RECSTATUS As Object, ByVal ORGLOGICREF As Object, ByVal UNIVID As Object, ByVal DISTLOTUNITS As Object, ByVal COMBLOTUNITS As Object, ByVal WFSTATUS As Object, ByVal DISTPOINT As Object, ByVal CAMPPOINT As Object, ByVal CANUSEINTRNS As Object, ByVal ISONR As Object, ByVal GROUPNR As Object, ByVal PRODCOUNTRY As Object, ByVal ADDTAXREF As Object, ByVal QPRODAMNT As Object, ByVal QPRODUOM As Object, ByVal QPRODSRCINDEX As Object, ByVal EXTACCESSFLAGS As Object, ByVal PACKET As Object, ByVal SALVAGEVAL2 As Object, ByVal SELLVAT As Object, ByVal RETURNVAT As Object, ByVal LOGOID As Object, ByVal LIDCONFIRMED As Object, ByVal GTIPCODE As Object, ByVal EXPCTGNO As Object, ByVal B2CCODE As Object, ByVal MARKREF As Object, ByVal IMAGE2INC As Object, ByVal AVRWHDURATION As Object, ByVal EXTCARDFLAGS As Object, ByVal MINORDAMOUNT As Object, ByVal FREIGHTPLACE As Object, ByVal FREIGHTTYPCODE1 As Object, ByVal FREIGHTTYPCODE2 As Object, ByVal FREIGHTTYPCODE3 As Object, ByVal FREIGHTTYPCODE4 As Object, ByVal FREIGHTTYPCODE5 As Object, ByVal FREIGHTTYPCODE6 As Object, ByVal FREIGHTTYPCODE7 As Object, ByVal FREIGHTTYPCODE8 As Object, ByVal FREIGHTTYPCODE9 As Object, ByVal FREIGHTTYPCODE10 As Object, ByVal STATECODE As Object, ByVal STATENAME As Object, ByVal EXPCATEGORY As Object, ByVal LOSTFACTOR As Object, ByVal TEXTINCENG As Object, ByVal EANBARCODE As Object, ByVal DEPRCLASSTYPE As Object, ByVal WFLOWCRDREF As Object, ByVal SELLPRVAT As Object, ByVal RETURNPRVAT As Object, ByVal LOWLEVELCODES1 As Object, ByVal LOWLEVELCODES2 As Object, ByVal LOWLEVELCODES3 As Object, ByVal LOWLEVELCODES4 As Object, ByVal LOWLEVELCODES5 As Object, ByVal LOWLEVELCODES6 As Object, ByVal LOWLEVELCODES7 As Object, ByVal LOWLEVELCODES8 As Object, ByVal LOWLEVELCODES9 As Object, ByVal LOWLEVELCODES10 As Object, ByVal ORGLOGOID As Object, ByVal QPRODDEPART As Object, ByVal CANCONFIGURE As Object, ByVal CHARSETREF As Object, ByVal CANDEDUCT As Object, ByVal CONSCODEREF As Object, ByVal SPECODE2 As Object, ByVal SPECODE3 As Object, ByVal SPECODE4 As Object, ByVal SPECODE5 As Object, ByVal EXPENSE As Object, ByVal ORIGIN As Object, ByVal NAME2 As Object) As Long
        Try
            If (Me.sCon.State = ConnectionState.Closed) Then
                Me.sCon.Open()
            End If
        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            Dim exception As Exception = exception1
            Me.sCon.Close()
            Me.sCon.Open()
            ProjectData.ClearProjectError()
        End Try
        Me.sCmd.CommandText = Me.sorgu_query(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED  SET DATEFORMAT DMY INSERT INTO LG_*!F_ITEMS(ACTIVE, CARDTYPE, CODE, NAME, STGRPCODE, PRODUCERCODE, SPECODE, CYPHCODE, CLASSTYPE, PURCHBRWS, SALESBRWS, MTRLBRWS, VAT, PAYMENTREF, TRACKTYPE, LOCTRACKING, TOOL, AUTOINCSL, DIVLOTSIZE, SHELFLIFE, SHELFDATE, DOMINANTREFS1, DOMINANTREFS2, DOMINANTREFS3, DOMINANTREFS4, DOMINANTREFS5, DOMINANTREFS6, DOMINANTREFS7, DOMINANTREFS8, DOMINANTREFS9, DOMINANTREFS10, DOMINANTREFS11, DOMINANTREFS12, IMAGEINC, TEXTINC, DEPRTYPE, DEPRRATE, DEPRDUR, SALVAGEVAL, REVALFLAG, REVDEPRFLAG, PARTDEP, DEPRTYPE2, DEPRRATE2, DEPRDUR2, REVALFLAG2, REVDEPRFLAG2, PARTDEP2, APPROVED, UNITSETREF, QCCSETREF, DISTAMOUNT, CAPIBLOCK_CREATEDBY, CAPIBLOCK_CREADEDDATE, CAPIBLOCK_CREATEDHOUR, CAPIBLOCK_CREATEDMIN, CAPIBLOCK_CREATEDSEC, CAPIBLOCK_MODIFIEDBY, CAPIBLOCK_MODIFIEDDATE, CAPIBLOCK_MODIFIEDHOUR, CAPIBLOCK_MODIFIEDMIN, CAPIBLOCK_MODIFIEDSEC, SITEID, RECSTATUS, ORGLOGICREF, UNIVID, DISTLOTUNITS, COMBLOTUNITS, WFSTATUS, DISTPOINT, CAMPPOINT, CANUSEINTRNS, ISONR, GROUPNR, PRODCOUNTRY, ADDTAXREF, QPRODAMNT, QPRODUOM, QPRODSRCINDEX, EXTACCESSFLAGS, PACKET, SALVAGEVAL2, SELLVAT, RETURNVAT, LOGOID, LIDCONFIRMED, GTIPCODE, EXPCTGNO, B2CCODE, MARKREF, IMAGE2INC, AVRWHDURATION, EXTCARDFLAGS, MINORDAMOUNT, FREIGHTPLACE, FREIGHTTYPCODE1, FREIGHTTYPCODE2, FREIGHTTYPCODE3, FREIGHTTYPCODE4, FREIGHTTYPCODE5, FREIGHTTYPCODE6, FREIGHTTYPCODE7, FREIGHTTYPCODE8, FREIGHTTYPCODE9, FREIGHTTYPCODE10, STATECODE, STATENAME, EXPCATEGORY, LOSTFACTOR, TEXTINCENG, EANBARCODE, DEPRCLASSTYPE, WFLOWCRDREF, SELLPRVAT, RETURNPRVAT, LOWLEVELCODES1, LOWLEVELCODES2, LOWLEVELCODES3, LOWLEVELCODES4, LOWLEVELCODES5, LOWLEVELCODES6, LOWLEVELCODES7, LOWLEVELCODES8, LOWLEVELCODES9, LOWLEVELCODES10, ORGLOGOID, QPRODDEPART, CANCONFIGURE, CHARSETREF, CANDEDUCT, CONSCODEREF, SPECODE2, SPECODE3, SPECODE4, SPECODE5, EXPENSE, ORIGIN, NAME2) VALUES ( ", ACTIVE), " , "), CARDTYPE), " , '"), CODE), "' , '"), NAME), "' , '"), STGRPCODE), "' , '"), PRODUCERCODE), "' , '"), SPECODE), "' , '"), CYPHCODE), "' , "), CLASSTYPE), " , "), PURCHBRWS), " , "), SALESBRWS), " , "), MTRLBRWS), " , "), VAT), " , "), PAYMENTREF), " , "), TRACKTYPE), " , "), LOCTRACKING), " , "), TOOL), " , "), AUTOINCSL), " , "), DIVLOTSIZE), " , "), SHELFLIFE), " , "), SHELFDATE), " , "), DOMINANTREFS1), " , "), DOMINANTREFS2), " , "), DOMINANTREFS3), " , "), DOMINANTREFS4), " , "), DOMINANTREFS5), " , "), DOMINANTREFS6), " , "), DOMINANTREFS7), " , "), DOMINANTREFS8), " , "), DOMINANTREFS9), " , "), DOMINANTREFS10), " , "), DOMINANTREFS11), " , "), DOMINANTREFS12), " , "), IMAGEINC), " , "), TEXTINC), " , "), DEPRTYPE), " , "), DEPRRATE), " , "), DEPRDUR), " , "), SALVAGEVAL), " , "), REVALFLAG), " , "), REVDEPRFLAG), " , "), PARTDEP), " , "), DEPRTYPE2), " , "), DEPRRATE2), " , "), DEPRDUR2), " , "), REVALFLAG2), " , "), REVDEPRFLAG2), " , "), PARTDEP2), " , "), APPROVED), " , "), UNITSETREF), " , "), QCCSETREF), " , "), DISTAMOUNT), " , "), CAPIBLOCK_CREATEDBY), " , '"), CAPIBLOCK_CREADEDDATE), "' , "), CAPIBLOCK_CREATEDHOUR), " , "), CAPIBLOCK_CREATEDMIN), " , "), CAPIBLOCK_CREATEDSEC), " , "), CAPIBLOCK_MODIFIEDBY), " , '"), CAPIBLOCK_MODIFIEDDATE), "' , "), CAPIBLOCK_MODIFIEDHOUR), " , "), CAPIBLOCK_MODIFIEDMIN), " , "), CAPIBLOCK_MODIFIEDSEC), " , "), SITEID), " , "), RECSTATUS), " , "), ORGLOGICREF), " , '"), UNIVID), "' , "), DISTLOTUNITS), " , "), COMBLOTUNITS), " , "), WFSTATUS), " , "), DISTPOINT), " , "), CAMPPOINT), " , "), CANUSEINTRNS), " , '"), ISONR), "' , '"), GROUPNR), "' , '"), PRODCOUNTRY), "' , "), ADDTAXREF), " , "), QPRODAMNT), " , "), QPRODUOM), " , "), QPRODSRCINDEX), " , "), EXTACCESSFLAGS), " , "), PACKET), " , "), SALVAGEVAL2), " , "), SELLVAT), " , "), RETURNVAT), " , '"), LOGOID), "' , "), LIDCONFIRMED), " , '"), GTIPCODE), "' , '"), EXPCTGNO), "' , '"), B2CCODE), "' , "), MARKREF), " , "), IMAGE2INC), " , "), AVRWHDURATION), " , "), EXTCARDFLAGS), " , "), MINORDAMOUNT), " , '"), FREIGHTPLACE), "' , '"), FREIGHTTYPCODE1), "' , '"), FREIGHTTYPCODE2), "' , '"), FREIGHTTYPCODE3), "' , '"), FREIGHTTYPCODE4), "' , '"), FREIGHTTYPCODE5), "' , '"), FREIGHTTYPCODE6), "' , '"), FREIGHTTYPCODE7), "' , '"), FREIGHTTYPCODE8), "' , '"), FREIGHTTYPCODE9), "' , '"), FREIGHTTYPCODE10), "' , '"), STATECODE), "' , '"), STATENAME), "' , '"), EXPCATEGORY), "' , "), LOSTFACTOR), " , "), TEXTINCENG), " , '"), EANBARCODE), "' , '"), DEPRCLASSTYPE), "' , "), WFLOWCRDREF), " , "), SELLPRVAT), " , "), RETURNPRVAT), " , "), LOWLEVELCODES1), " , "), LOWLEVELCODES2), " , "), LOWLEVELCODES3), " , "), LOWLEVELCODES4), " , "), LOWLEVELCODES5), " , "), LOWLEVELCODES6), " , "), LOWLEVELCODES7), " , "), LOWLEVELCODES8), " , "), LOWLEVELCODES9), " , "), LOWLEVELCODES10), " , '"), ORGLOGOID), "' , "), QPRODDEPART), " , "), CANCONFIGURE), " , "), CHARSETREF), " , "), CANDEDUCT), " , "), CONSCODEREF), " , '"), SPECODE2), "' , '"), SPECODE3), "' , '"), SPECODE4), "' , '"), SPECODE5), "' , "), EXPENSE), " , '"), ORIGIN), "' , '"), NAME2), "' )")))
        Me.sCmd.ExecuteNonQuery()
        Me.sCmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        LOGICALREF = RuntimeHelpers.GetObjectValue(Me.sCmd.ExecuteScalar)
        Return Conversions.ToLong(LOGICALREF)
    End Function
    Private Function INVOICE_kaydet_yeni(ByVal LOGICALREF As Object, ByVal GRPCODE As Object, ByVal TRCODE As Object, ByVal FICHENO As Object, ByVal DATE_ As Object, ByVal TIME_ As Object, ByVal DOCODE As Object, ByVal SPECODE As Object, ByVal CYPHCODE As Object, ByVal CLIENTREF As Object, ByVal RECVREF As Object, ByVal CENTERREF As Object, ByVal ACCOUNTREF As Object, ByVal SOURCEINDEX As Object, ByVal SOURCECOSTGRP As Object, ByVal CANCELLED As Object, ByVal ACCOUNTED As Object, ByVal PAIDINCASH As Object, ByVal FROMKASA As Object, ByVal ENTEGSET As Object, ByVal VAT As Object, ByVal ADDDISCOUNTS As Object, ByVal TOTALDISCOUNTS As Object, ByVal TOTALDISCOUNTED As Object, ByVal ADDEXPENSES As Object, ByVal TOTALEXPENSES As Object, ByVal DISTEXPENSE As Object, ByVal TOTALDEPOZITO As Object, ByVal TOTALPROMOTIONS As Object, ByVal VATINCGROSS As Object, ByVal TOTALVAT As Object, ByVal GROSSTOTAL As Object, ByVal NETTOTAL As Object, ByVal GENEXP1 As Object, ByVal GENEXP2 As Object, ByVal GENEXP3 As Object, ByVal GENEXP4 As Object, ByVal INTERESTAPP As Object, ByVal TRCURR As Object, ByVal TRRATE As Object, ByVal TRNET As Object, ByVal REPORTRATE As Object, ByVal REPORTNET As Object, ByVal ONLYONEPAYLINE As Object, ByVal KASTRANSREF As Object, ByVal PAYDEFREF As Object, ByVal PRINTCNT As Object, ByVal GVATINC As Object, ByVal BRANCH As Object, ByVal DEPARTMENT As Object, ByVal ACCFICHEREF As Object, ByVal ADDEXPACCREF As Object, ByVal ADDEXPCENTREF As Object, ByVal DECPRDIFF As Object, ByVal CAPIBLOCK_CREATEDBY As Object, ByVal CAPIBLOCK_CREADEDDATE As Object, ByVal CAPIBLOCK_CREATEDHOUR As Object, ByVal CAPIBLOCK_CREATEDMIN As Object, ByVal CAPIBLOCK_CREATEDSEC As Object, ByVal CAPIBLOCK_MODIFIEDBY As Object, ByVal CAPIBLOCK_MODIFIEDDATE As Object, ByVal CAPIBLOCK_MODIFIEDHOUR As Object, ByVal CAPIBLOCK_MODIFIEDMIN As Object, ByVal CAPIBLOCK_MODIFIEDSEC As Object, ByVal SALESMANREF As Object, ByVal CANCELLEDACC As Object, ByVal SHPTYPCOD As Object, ByVal SHPAGNCOD As Object, ByVal TRACKNR As Object, ByVal GENEXCTYP As Object, ByVal LINEEXCTYP As Object, ByVal TRADINGGRP As Object, ByVal TEXTINC As Object, ByVal SITEID As Object, ByVal RECSTATUS As Object, ByVal ORGLOGICREF As Object, ByVal FACTORYNR As Object, ByVal WFSTATUS As Object, ByVal SHIPINFOREF As Object, ByVal DISTORDERREF As Object, ByVal SENDCNT As Object, ByVal DLVCLIENT As Object, ByVal COSTOFSALEFCREF As Object, ByVal OPSTAT As Object, ByVal DOCTRACKINGNR As Object, ByVal TOTALADDTAX As Object, ByVal PAYMENTTYPE As Object, ByVal INFIDX As Object, ByVal ACCOUNTEDCNT As Object, ByVal ORGLOGOID As Object, ByVal FROMEXIM As Object, ByVal FRGTYPCOD As Object, ByVal EXIMFCTYPE As Object, ByVal FROMORDWITHPAY As Object, ByVal PROJECTREF As Object, ByVal WFLOWCRDREF As Object, ByVal STATUS As Object, ByVal DEDUCTIONPART1 As Object, ByVal DEDUCTIONPART2 As Object, ByVal TOTALEXADDTAX As Object, ByVal EXACCOUNTED As Object, ByVal FROMBANK As Object, ByVal BNTRANSREF As Object, ByVal AFFECTCOLLATRL As Object, ByVal GRPFIRMTRANS As Object, ByVal AFFECTRISK As Object, ByVal CONTROLINFO As Object, ByVal POSTRANSFERINFO As Object, ByVal TAXFREECHX As Object, ByVal PASSPORTNO As Object, ByVal CREDITCARDNO As Object, ByVal INEFFECTIVECOST As Object, ByVal REFLECTED As Object, ByVal REFLACCFICHEREF As Object, ByVal CANCELLEDREFLACC As Object, ByVal CREDITCARDNUM As Object, ByVal APPROVE As Object, ByVal CANTCREDEDUCT As Object, ByVal DEVIR As Object) As Long
        Try
            If (Me.sCon.State = ConnectionState.Closed) Then
                Me.sCon.Open()
            End If
        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            Dim exception As Exception = exception1
            Me.sCon.Close()
            Me.sCon.Open()
            ProjectData.ClearProjectError()
        End Try
        Me.sCmd.CommandText = Me.sorgu_query(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SET DATEFORMAT DMY INSERT INTO LG_*!F_!D_INVOICE(GRPCODE, TRCODE, FICHENO, DATE_, TIME_, DOCODE, SPECODE, CYPHCODE, CLIENTREF, RECVREF, CENTERREF, ACCOUNTREF, SOURCEINDEX, SOURCECOSTGRP, CANCELLED, ACCOUNTED, PAIDINCASH, FROMKASA, ENTEGSET, VAT, ADDDISCOUNTS, TOTALDISCOUNTS, TOTALDISCOUNTED, ADDEXPENSES, TOTALEXPENSES, DISTEXPENSE, TOTALDEPOZITO, TOTALPROMOTIONS, VATINCGROSS, TOTALVAT, GROSSTOTAL, NETTOTAL, GENEXP1, GENEXP2, GENEXP3, GENEXP4, INTERESTAPP, TRCURR, TRRATE, TRNET, REPORTRATE, REPORTNET, ONLYONEPAYLINE, KASTRANSREF, PAYDEFREF, PRINTCNT, GVATINC, BRANCH, DEPARTMENT, ACCFICHEREF, ADDEXPACCREF, ADDEXPCENTREF, DECPRDIFF, CAPIBLOCK_CREATEDBY, CAPIBLOCK_CREADEDDATE, CAPIBLOCK_CREATEDHOUR, CAPIBLOCK_CREATEDMIN, CAPIBLOCK_CREATEDSEC, CAPIBLOCK_MODIFIEDBY, CAPIBLOCK_MODIFIEDDATE, CAPIBLOCK_MODIFIEDHOUR, CAPIBLOCK_MODIFIEDMIN, CAPIBLOCK_MODIFIEDSEC, SALESMANREF, CANCELLEDACC, SHPTYPCOD, SHPAGNCOD, TRACKNR, GENEXCTYP, LINEEXCTYP, TRADINGGRP, TEXTINC, SITEID, RECSTATUS, ORGLOGICREF, FACTORYNR, WFSTATUS, SHIPINFOREF, DISTORDERREF, SENDCNT, DLVCLIENT, COSTOFSALEFCREF, OPSTAT, DOCTRACKINGNR, TOTALADDTAX, PAYMENTTYPE, INFIDX, ACCOUNTEDCNT, ORGLOGOID, FROMEXIM, FRGTYPCOD, EXIMFCTYPE, FROMORDWITHPAY, PROJECTREF, WFLOWCRDREF, STATUS, DEDUCTIONPART1, DEDUCTIONPART2, TOTALEXADDTAX, EXACCOUNTED, FROMBANK, BNTRANSREF, AFFECTCOLLATRL, GRPFIRMTRANS, AFFECTRISK, CONTROLINFO, POSTRANSFERINFO, TAXFREECHX, PASSPORTNO, CREDITCARDNO, INEFFECTIVECOST, REFLECTED, REFLACCFICHEREF, CANCELLEDREFLACC, CREDITCARDNUM, APPROVE, CANTCREDEDUCT,DEVIR) VALUES ( ", GRPCODE), ", "), TRCODE), ", '"), FICHENO), "', '"), DATE_), "', '"), TIME_), "', '"), DOCODE), "', '"), SPECODE), "', '"), CYPHCODE), "', "), CLIENTREF), ", "), RECVREF), ", "), CENTERREF), ", "), ACCOUNTREF), ", "), SOURCEINDEX), ", "), SOURCECOSTGRP), ", "), CANCELLED), ", "), ACCOUNTED), ", "), PAIDINCASH), ", "), FROMKASA), ", "), ENTEGSET), ", "), VAT), ", "), ADDDISCOUNTS), ", "), TOTALDISCOUNTS), ", "), TOTALDISCOUNTED), ", "), ADDEXPENSES), ", "), TOTALEXPENSES), ", "), DISTEXPENSE), ", "), TOTALDEPOZITO), ", "), TOTALPROMOTIONS), ", "), VATINCGROSS), ", "), TOTALVAT), ", "), GROSSTOTAL), ", "), NETTOTAL), ", '"), GENEXP1), "', '"), GENEXP2), "', '"), GENEXP3), "', '"), GENEXP4), "', "), INTERESTAPP), ", "), TRCURR), ", "), TRRATE), ", "), TRNET), ", "), REPORTRATE), ", "), REPORTNET), ", "), ONLYONEPAYLINE), ", "), KASTRANSREF), ", "), PAYDEFREF), ", "), PRINTCNT), ", "), GVATINC), ", "), BRANCH), ", "), DEPARTMENT), ", "), ACCFICHEREF), ", "), ADDEXPACCREF), ", "), ADDEXPCENTREF), ", "), DECPRDIFF), ", "), CAPIBLOCK_CREATEDBY), ", '"), CAPIBLOCK_CREADEDDATE), "' , "), CAPIBLOCK_CREATEDHOUR), ", "), CAPIBLOCK_CREATEDMIN), ", "), CAPIBLOCK_CREATEDSEC), ", "), CAPIBLOCK_MODIFIEDBY), ", '"), CAPIBLOCK_MODIFIEDDATE), "', "), CAPIBLOCK_MODIFIEDHOUR), ", "), CAPIBLOCK_MODIFIEDMIN), ", "), CAPIBLOCK_MODIFIEDSEC), ", "), SALESMANREF), ", "), CANCELLEDACC), ", '"), SHPTYPCOD), "', '"), SHPAGNCOD), "', '"), TRACKNR), "', "), GENEXCTYP), ", "), LINEEXCTYP), ", '"), TRADINGGRP), "', "), TEXTINC), ", "), SITEID), ", "), RECSTATUS), ", "), ORGLOGICREF), ", "), FACTORYNR), ", "), WFSTATUS), ", "), SHIPINFOREF), ", "), DISTORDERREF), ", "), SENDCNT), ", "), DLVCLIENT), ", "), COSTOFSALEFCREF), ", "), OPSTAT), ", '"), DOCTRACKINGNR), "', "), TOTALADDTAX), ", "), PAYMENTTYPE), ", "), INFIDX), ", "), ACCOUNTEDCNT), ", '"), ORGLOGOID), "', "), FROMEXIM), ", '"), FRGTYPCOD), "', "), EXIMFCTYPE), ", "), FROMORDWITHPAY), ", "), PROJECTREF), ", "), WFLOWCRDREF), ", "), STATUS), ", "), DEDUCTIONPART1), ", "), DEDUCTIONPART2), ", "), TOTALEXADDTAX), ", "), EXACCOUNTED), ", "), FROMBANK), ", "), BNTRANSREF), ", "), AFFECTCOLLATRL), ", "), GRPFIRMTRANS), ", "), AFFECTRISK), ", "), CONTROLINFO), ", "), POSTRANSFERINFO), ", "), TAXFREECHX), ", '"), PASSPORTNO), "', '"), CREDITCARDNO), "', "), INEFFECTIVECOST), ", "), REFLECTED), ", "), REFLACCFICHEREF), ", "), CANCELLEDREFLACC), ", '"), CREDITCARDNUM), "', "), APPROVE), ", "), CANTCREDEDUCT), ","), DEVIR), ")")))
        Me.sCmd.ExecuteNonQuery()
        Me.sCmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        LOGICALREF = RuntimeHelpers.GetObjectValue(Me.sCmd.ExecuteScalar)
        Return Conversions.ToLong(LOGICALREF)
    End Function
    Public Function sorgu_fis_kontrol_logo(ByVal sFistipi As String, ByVal nGirisCikis As String, ByVal dteFisTarihi As DateTime, ByVal lFisno As String, ByVal nFirmaID As String, Optional ByVal resmi As Boolean = True, Optional ByVal sDatabase As String = "") As Long
        Dim str As String = ""
        If (sDatabase <> "") Then
            str = ("USE " & sDatabase)
        End If
        Dim obj3 As Object = String.Concat(New String() {"WHERE (sFisTipi = '", sFistipi, "') and (dteFisTarihi = '", Conversions.ToString(dteFisTarihi), "') and (lFisNo = '", lFisno, "') and (nFirmaID= '", nFirmaID, "') and (nGirisCikis = '", nGirisCikis, "')  "})
        Try
            If (Me.sCon.State = ConnectionState.Closed) Then
                Me.sCon.Open()
            End If
        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            Dim exception As Exception = exception1
            Me.sCon.Close()
            Me.sCon.Open()
            ProjectData.ClearProjectError()
        End Try
        Me.sCmd.CommandText = Me.sorgu_query(String.Concat(New String() {"", str, " SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     COUNT(LOGICALREF) AS KAYIT  FROM         LG_*!F_!D_INVOICE WHERE     (CLIENTREF = ", nFirmaID, ") AND (DATE_ = '", Conversions.ToString(dteFisTarihi), "') AND (TRCODE = ", sFistipi, ") AND (FICHENO = ", lFisno, ")"}))
        Return Conversions.ToLong(RuntimeHelpers.GetObjectValue(Me.sCmd.ExecuteScalar))
    End Function
    Private Function CLCARD_kaydet_yeni(ByVal LOGICALREF As Long, ByVal ACTIVE As Byte, ByVal CARDTYPE As Long, ByVal CODE As String, ByVal DEFINITION_ As String) As Long
        Try
            If (Me.sCon.State = ConnectionState.Closed) Then
                Me.sCon.Open()
            End If
        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            Dim exception As Exception = exception1
            Me.sCon.Close()
            Me.sCon.Open()
            ProjectData.ClearProjectError()
        End Try
        Me.sCmd.CommandText = Me.sorgu_query(String.Concat(New String() {"SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED  SET DATEFORMAT DMY INSERT INTO LG_*!F_CLCARD(ACTIVE, CARDTYPE, CODE, DEFINITION_) VALUES (  ", Conversions.ToString(ACTIVE), ", ", Conversions.ToString(CARDTYPE), ", '", CODE, "', '", DEFINITION_, "')"}))
        Me.sCmd.ExecuteNonQuery()
        Me.sCmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        LOGICALREF = Conversions.ToLong(Me.sCmd.ExecuteScalar)
        Return LOGICALREF
    End Function
    Private Sub logo_entegre()
        If (Me.GridView1.RowCount > 0) Then
            Dim _kopyala As New frm_fatura_kopyala1 With {
                .firmano = RuntimeHelpers.GetObjectValue(Me.firmano),
                .donemno = RuntimeHelpers.GetObjectValue(Me.donemno),
                .connection = RuntimeHelpers.GetObjectValue(Me.connection),
                .sFisTipi = "FS ",
                .nGirisCikis = 3,
                .kapla = True,
                .nFirmaID = 0,
                .sKodu = "393.01.001"
            }
            _kopyala.txt_musteriNo.EditValue = _kopyala.sKodu
            _kopyala.lbl_Firma.Text = ""
            _kopyala.txt_dteFisTarihi1.EditValue = KeyCode.dteSistemTarihi
            _kopyala.bAktar = True
            _kopyala.txt_lFisNo.Text = KeyCode.sayiuzunlukkontrol(Conversions.ToString(1), Conversions.ToString(6), "0")
            Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Me.connection)
            Dim sConnection As Object = KeyCode.sConnection
            _kopyala.bLogo = True
            If (_kopyala.ShowDialog(Me) = DialogResult.OK) Then
                Me.firmano = _kopyala.txt_nFirmaNo.Text
                Me.donemno = _kopyala.txt_nDonemNo.Text
                Me.sConnectionLogo = _kopyala.sUzakConnection
                KeyCode.sConnection = _kopyala.sConnection
                If (XtraMessageBox.Show(KeyCode.Sorgu_sDil("Seçili Kayıtları Entegre Etmek İstediğinize Emin misiniz...?", KeyCode.sDil), KeyCode.Sorgu_sDil("Dikkat", KeyCode.sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
                    Dim current As DataRow
                    Dim selectedRowsCount As Object = Me.GridView1.SelectedRowsCount
                    Dim selectedRows As Integer() = Me.GridView1.GetSelectedRows
                    If (Not selectedRows Is Nothing) Then
                        Array.Sort(Of Integer)(selectedRows)
                        Me.bar1.Properties.Maximum = Me.GridView1.SelectedRowsCount
                        Me.bar1.Visible = True
                        Me.bar1.Position = 0
                        Me.sCon.ConnectionString = Me.sConnectionLogo
                        Me.sCmd.Connection = Me.sCon
                        Me.sCmd.CommandTimeout = 400
                        If (Me.sCon.State = ConnectionState.Closed) Then
                            Me.sCon.Open()
                        End If
                        Dim num As Integer
                        For Each num In selectedRows
                            Dim str As String = num.ToString
                            Dim dataRow As DataRow = Me.GridView1.GetDataRow(Conversions.ToInteger(str))
                            Dim tRCODE As Long = 8
                            Dim sTFICHELNNO As Integer = 1
                            Dim time2 As DateTime = Conversions.ToDate(dataRow.Item("dteFisTarihi"))
                            Dim lOGICALREF As Long = 0
                            Dim num3 As Long = 0
                            Dim num4 As Long = 0
                            Dim num16 As Long = 0
                            Dim aCCOUNTREF As Long = 0
                            Dim vATACCREF As Long = 0
                            Dim vAT As Decimal = 8
                            Dim tOTALVAT As Decimal = 0.74
                            Dim cODE As String = "000002"
                            Dim nAME As String = "EKMEK IKILI"
                            Dim eANBARCODE As String = "000002"
                            Dim time As DateTime = Conversions.ToDate(dataRow.Item("dteKayitTarihi"))
                            Dim num10 As Integer = 0
                            Dim str6 As String = "00"
                            Dim str4 As String = "00"
                            Dim str7 As String = "00"
                            Dim month As Long = time2.Month
                            Dim year As Long = time2.Year
                            str6 = DateAndTime.Now.ToLongTimeString.Substring(0, 2)
                            str4 = DateAndTime.Now.ToLongTimeString.Substring(3, 2)
                            str7 = DateAndTime.Now.ToLongTimeString.Substring(6, 2)
                            num10 = CInt(Math.Round(CDbl((((Conversions.ToDouble(str6) * 16777216) + (Conversions.ToDouble(str4) * 65536)) + (Conversions.ToDouble(str7) * 256)))))
                            Dim sALESMANREF As Integer = 0
                            Dim sOURCEINDEX As Integer = 0
                            num3 = Me.sorgula_logo_nStokID(Me.sorgu_query(("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(LOGICALREF, 0) AS CLIENTREF  FROM         LG_*!F_CLCARD WHERE     (CODE = '" & Trim(Conversions.ToString(dataRow.Item("sKodu"))) & "')")))
                            If (num3 = 0) Then
                                num3 = Me.CLCARD_kaydet_yeni(num3, 1, 3, Trim(dataRow.Item("sKodu").ToString), Trim(dataRow.Item("sAciklama").ToString))
                            End If
                            If (Me.sorgu_fis_kontrol_logo(Conversions.ToString(8), Conversions.ToString(3), Conversions.ToDate(dataRow.Item("dteFisTarihi")), Conversions.ToString(dataRow.Item("lFisNo")), Conversions.ToString(num3), True, "") = 0) Then
                                Dim enumerator As IEnumerator
                                Dim enumerator2 As IEnumerator
                                Dim obj2 As Object = Me.sorgu(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(((((("SELECT tbStokFisiDetayi.*, tbStok.sKodu AS sStokKodu, tbStok.sAciklama AS sStokAciklama,tbStok.sKisaAdi,tbStok.sBirimCinsi1,tbStok.sModel, tbStok.sBeden,tbStok.nFiyatlandirma,tbStok.nStokTipi,tbRenk.sRenkAdi,tbStokBarkodu.sBarkod ,(Select lFiyat from tbStokFiyati where nStokID = tbStok.nStokID and sFiyatTipi = '" & KeyCode.sFiyatM & "') AS lMaliyet,(Select lFiyat from tbStokFiyati where nStokID = tbStok.nStokID and sFiyatTipi = '") & KeyCode.sFiyatA & "') as lAlis, (Select lFiyat from tbStokFiyati where nStokID = tbStok.nStokID and sFiyatTipi = '") & KeyCode.sFiyat1 & "') AS lFiyat1,(Select lFiyat from tbStokFiyati where nStokID = tbStok.nStokID and sFiyatTipi = '") & KeyCode.sFiyat2 & "') AS lFiyat2,(Select lFiyat from tbStokFiyati where nStokID = tbStok.nStokID and sFiyatTipi = '") & KeyCode.sFiyat3 & "') AS lFiyat3,CAST(0 AS FLOAT) AS ISK1, CAST(0 AS FLOAT) AS ISK2,CAST(0 AS FLOAT) AS ISK3,CAST(0 AS FLOAT) AS ISK4,CAST(0 AS FLOAT) AS ISK5,CAST(0 AS FLOAT) AS nMasrafSatiri,CAST(0 AS MONEY) AS GERCEKFIYAT, CAST(0 AS MONEY) AS GERCEKTOPLAM, ABS((tbStokFisiDetayi.lBrutTutar - tbStokFisiDetayi.lIskontoTutari) * (tbStokFisiDetayi.nKdvOrani / 100)) AS lKdvTutari,CAST(tbStokFisiDetayi.lBrutFiyat * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS FLOAT) AS lDahilBrutFiyat,CAST(tbStokFisiDetayi.lBrutTutar * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS FLOAT) AS lDahilBrutTutar, tbStokFisiDetayi.lBrutTutar as lDovizTutar, tbStokFisiDetayi.lBrutFiyat lDovizFiyati, (tbStokFisiDetayi.lBrutTutar)* (100 + tbStokFisiDetayi.nKdvOrani) / 100  lDahilDovizTutar, (tbStokFisiDetayi.lBrutFiyat)* (100 + tbStokFisiDetayi.nKdvOrani) / 100 lDahilDovizFiyati,tbStokFisiMaster.lKdv1,tbStokFisiMaster.lKdv2,tbStokFisiMaster.lKdv3,tbStokFisiMaster.lKdv4,tbStokFisiMaster.lKdv5 FROM tbStokFisiDetayi INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID INNER JOIN tbRenk ON tbStok.sRenk = tbRenk.sRenk INNER JOIN tbStokBarkodu ON tbStok.nStokID = tbStokBarkodu.nStokID AND tbStokBarkodu.nKisim = 0  INNER JOIN   tbStokFisiMaster ON tbStokFisiDetayi.nStokFisiID = tbStokFisiMaster.nStokFisiID WHERE     (tbStokFisiDetayi.nStokFisiID = '"), dataRow.Item("nStokFisiID")), "') ORDER BY tbStokFisiDetayi.nIslemID")), "TABLE1")
                                Try
                                    enumerator = DirectCast(NewLateBinding.LateGet(NewLateBinding.LateGet(obj2, Nothing, "Tables", New Object() {0}, Nothing, Nothing, Nothing), Nothing, "Rows", New Object(0 - 1) {}, Nothing, Nothing, Nothing), IEnumerable).GetEnumerator
                                    Do While enumerator.MoveNext
                                        current = DirectCast(enumerator.Current, DataRow)
                                        Try
                                            sOURCEINDEX = Convert.ToInt32(KeyCode.sorgu_sayi(RuntimeHelpers.GetObjectValue(current.Item("sDepo")), Decimal.Zero))
                                        Catch exception1 As Exception
                                            ProjectData.SetProjectError(exception1)
                                            Dim exception As Exception = exception1
                                            sOURCEINDEX = 1
                                            ProjectData.ClearProjectError()
                                        End Try
                                        sALESMANREF = Convert.ToInt32(KeyCode.sorgu_sayi(RuntimeHelpers.GetObjectValue(current.Item("sSaticiRumuzu")), Decimal.Zero))
                                    Loop
                                Finally
                                    If TypeOf enumerator Is IDisposable Then
                                        TryCast(enumerator, IDisposable).Dispose()
                                    End If
                                End Try
                                tOTALVAT = Conversions.ToDecimal(dataRow.Item("KdvTutari"))
                                num4 = Me.INVOICE_kaydet_yeni(lOGICALREF, 2, tRCODE, RuntimeHelpers.GetObjectValue(dataRow.Item("lFisNo")), time2, num10, RuntimeHelpers.GetObjectValue(dataRow.Item("lFisNo")), "", "", num3, 0, 0, 0, sOURCEINDEX, sOURCEINDEX, 0, 0, 0, 0, &HF7, 0, 0, RuntimeHelpers.GetObjectValue(dataRow.Item("lMalIskontoTutari")), Operators.SubtractObject(dataRow.Item("lMalBedeli"), dataRow.Item("lMalIskontoTutari")), 0, 0, 0, 0, 0, 0, tOTALVAT, RuntimeHelpers.GetObjectValue(dataRow.Item("lMalBedeli")), RuntimeHelpers.GetObjectValue(dataRow.Item("lNetTutar")), "", "", "", "", 0, 0, 0, RuntimeHelpers.GetObjectValue(dataRow.Item("lNetTutar")), 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 1, time2, str6, str4, str7, 1, time2, str6, str4, str7, sALESMANREF, 0, "", "", "", 2, 0, "", 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, "", 0, 0, 0, 0, "", 0, "", 0, 0, 0, 0, 0, 2, 3, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, "", "", 0, 0, 0, 0, "", 0, 0, 0)
                                lOGICALREF = Me.sorgula_logo_nStokID(Me.sorgu_query("SELECT     ISNULL(MAX(LOGICALREF),0) + 1 AS LOGICALREF FROM         LG_*!F_!D_STFICHE"))
                                Dim sTFICHEREF As Long = Me.STFICHE_kaydet_yeni(lOGICALREF, 2, tRCODE, 3, RuntimeHelpers.GetObjectValue(dataRow.Item("lFisNo")), time2, &H10352149, sALESMANREF, lOGICALREF, "", "", num4, num3, 0, 0, 0, 0, "", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, Operators.SubtractObject(dataRow.Item("lMalBedeli"), dataRow.Item("lMalIskontoTutari")), 0, 0, 0, 0, tOTALVAT, RuntimeHelpers.GetObjectValue(dataRow.Item("lNetTutar")), RuntimeHelpers.GetObjectValue(dataRow.Item("lNetTutar")), "", "", "", "", 0, 0, 0, 0, 0, 1, 0, 1, time2, str6, str4, str7, 1, time2, str6, str4, str7, 0, 0, "", "", "", 2, 0, "", 0, 0, 0, 0, 0, 0, 0, 0, 0, "", 0, 0, "", 0, 0, 0, "", 0, "", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 3, 0, 1, 1, 0, 0)
                                Dim num25 As New Decimal
                                Dim num24 As New Decimal
                                Dim num26 As New Decimal
                                Dim num27 As Decimal = KeyCode.sorgu_sayi(RuntimeHelpers.GetObjectValue(dataRow.Item("lNetTutar")), Decimal.Zero)
                                Dim num19 As New Decimal
                                Dim num20 As New Decimal
                                Dim num21 As New Decimal
                                Dim num22 As New Decimal
                                Dim num23 As New Decimal
                                If Operators.ConditionalCompareObjectEqual(dataRow.Item("nGirisCikis"), 1, False) Then
                                    num25 = New Decimal
                                    num24 = Math.Abs(num27)
                                ElseIf Operators.ConditionalCompareObjectEqual(dataRow.Item("nGirisCikis"), 2, False) Then
                                    num25 = Math.Abs(num27)
                                    num24 = New Decimal
                                ElseIf Operators.ConditionalCompareObjectEqual(dataRow.Item("nGirisCikis"), 3, False) Then
                                    num25 = Math.Abs(num27)
                                    num24 = New Decimal
                                ElseIf Operators.ConditionalCompareObjectEqual(dataRow.Item("nGirisCikis"), 4, False) Then
                                    num25 = New Decimal
                                    num24 = Math.Abs(num27)
                                End If
                                Try
                                    enumerator2 = DirectCast(NewLateBinding.LateGet(NewLateBinding.LateGet(obj2, Nothing, "Tables", New Object() {0}, Nothing, Nothing, Nothing), Nothing, "Rows", New Object(0 - 1) {}, Nothing, Nothing, Nothing), IEnumerable).GetEnumerator
                                    Do While enumerator2.MoveNext
                                        current = DirectCast(enumerator2.Current, DataRow)
                                        If current.Item("sAciklama").ToString.Contains("+") Then
                                            Dim strArray2 As String() = current.Item("sAciklama").ToString.Split(New Char() {"+"c})
                                            Try
                                                current.Item("ISK1") = strArray2(0)
                                            Catch exception8 As Exception
                                                ProjectData.SetProjectError(exception8)
                                                Dim exception2 As Exception = exception8
                                                current.Item("ISK1") = 0
                                                ProjectData.ClearProjectError()
                                            End Try
                                            Try
                                                current.Item("ISK2") = strArray2(1)
                                            Catch exception9 As Exception
                                                ProjectData.SetProjectError(exception9)
                                                Dim exception3 As Exception = exception9
                                                current.Item("ISK2") = 0
                                                ProjectData.ClearProjectError()
                                            End Try
                                            Try
                                                current.Item("ISK3") = strArray2(2)
                                            Catch exception10 As Exception
                                                ProjectData.SetProjectError(exception10)
                                                Dim exception4 As Exception = exception10
                                                current.Item("ISK3") = 0
                                                ProjectData.ClearProjectError()
                                            End Try
                                            Try
                                                current.Item("ISK4") = strArray2(3)
                                            Catch exception11 As Exception
                                                ProjectData.SetProjectError(exception11)
                                                Dim exception5 As Exception = exception11
                                                current.Item("ISK4") = 0
                                                ProjectData.ClearProjectError()
                                            End Try
                                            Try
                                                current.Item("ISK5") = strArray2(4)
                                            Catch exception12 As Exception
                                                ProjectData.SetProjectError(exception12)
                                                Dim exception6 As Exception = exception12
                                                current.Item("ISK5") = 0
                                                ProjectData.ClearProjectError()
                                            End Try
                                        End If
                                        Dim str9 As String = ""
                                        If Operators.ConditionalCompareObjectEqual(current.Item("nIskontoYuzdesi"), 0, False) Then
                                            current.Item("sAciklama") = ""
                                        Else
                                            If Operators.ConditionalCompareObjectNotEqual(current.Item("ISK1"), 0, False) Then
                                                str9 = (str9 & Me.uzunluk_tamamla(FormatNumber(RuntimeHelpers.GetObjectValue(current.Item("ISK1")), 2, TriState.UseDefault, TriState.UseDefault, TriState.UseDefault), 5, "0") & "+")
                                            End If
                                            If Operators.ConditionalCompareObjectNotEqual(current.Item("ISK2"), 0, False) Then
                                                str9 = (str9 & Me.uzunluk_tamamla(FormatNumber(RuntimeHelpers.GetObjectValue(current.Item("ISK2")), 2, TriState.UseDefault, TriState.UseDefault, TriState.UseDefault), 5, "0"))
                                            End If
                                            If Operators.ConditionalCompareObjectNotEqual(current.Item("ISK3"), 0, False) Then
                                                str9 = (str9 & "+" & Me.uzunluk_tamamla(FormatNumber(RuntimeHelpers.GetObjectValue(current.Item("ISK3")), 2, TriState.UseDefault, TriState.UseDefault, TriState.UseDefault), 5, "0"))
                                            End If
                                            If Operators.ConditionalCompareObjectNotEqual(current.Item("ISK4"), 0, False) Then
                                                str9 = (str9 & "+" & Me.uzunluk_tamamla(FormatNumber(RuntimeHelpers.GetObjectValue(current.Item("ISK4")), 2, TriState.UseDefault, TriState.UseDefault, TriState.UseDefault), 5, "0"))
                                            End If
                                            If (Decimal.Compare(KeyCode.sorgu_sayi(RuntimeHelpers.GetObjectValue(current.Item("ISK5")), Decimal.Zero), Decimal.Zero) <> 0) Then
                                                str9 = (str9 & "+" & Me.uzunluk_tamamla(FormatNumber(RuntimeHelpers.GetObjectValue(current.Item("ISK5")), 2, TriState.UseDefault, TriState.UseDefault, TriState.UseDefault), 5, "0"))
                                            End If
                                            current.Item("sAciklama") = str9
                                        End If
                                        cODE = Trim(Conversions.ToString(current.Item("sStokKodu")))
                                        nAME = Trim(Conversions.ToString(current.Item("sStokAciklama")))
                                        vAT = Conversions.ToDecimal(current.Item("nKdvOrani"))
                                        num16 = Me.sorgula_logo_nStokID(Me.sorgu_query(("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(LOGICALREF, 0) AS STOCKF  FROM         LG_*!F_ITEMS WHERE     (CODE = '" & cODE & "')")))
                                        If ((num16 = 0) Or (num16 = 1)) Then
                                            num16 = Me.ITEMS_kaydet_yeni(num16, 0, 1, cODE, nAME, "", "", "", "", 0, 1, 1, 1, vAT, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 5, 0, 0, 1, time2, str6, str4, str7, 1, time2, str6, str4, str7, 0, 1, 0, "", 1, 0, 0, 0, 0, 0, "", "", "", 0, 0, 0, 0, 3, 0, 0, vAT, vAT, "", 0, "", "", "", 0, 0, 0, &H3F, 0, "", "", "", "", "", "", "", "", "", "", "", "", "", "", 0, 0, eANBARCODE, "", 0, vAT, vAT, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "", 0, 0, 0, 0, 0, "", "", "", "", 0, "", "")
                                        End If
                                        aCCOUNTREF = 0
                                        If (Decimal.Compare(vAT, Decimal.One) = 0) Then
                                            vATACCREF = Me.sorgula_logo_nStokID(Me.sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(LOGICALREF, 0) AS LOGICALREF FROM         LG_*!F_EMUHACC WHERE     (CODE = '391.01.001')"))
                                        ElseIf (Decimal.Compare(vAT, 8) = 0) Then
                                            vATACCREF = Me.sorgula_logo_nStokID(Me.sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(LOGICALREF, 0) AS LOGICALREF FROM         LG_*!F_EMUHACC WHERE     (CODE = '391.01.002')"))
                                        ElseIf (Decimal.Compare(vAT, 18) = 0) Then
                                            vATACCREF = Me.sorgula_logo_nStokID(Me.sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(LOGICALREF, 0) AS LOGICALREF FROM         LG_*!F_EMUHACC WHERE     (CODE = '391.01.003')"))
                                        Else
                                            vATACCREF = 0
                                        End If
                                        lOGICALREF = Me.sorgula_logo_nStokID(Me.sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(MAX(LOGICALREF),0) + 1 AS LASTREF FROM         LG_*!F_!D_STLINE"))
                                        Dim aMOUNT As New Decimal
                                        Dim pRICE As New Decimal
                                        Dim tOTAL As New Decimal
                                        Dim dISCPER As New Decimal
                                        Dim dISTCOST As New Decimal
                                        Dim lINEEXP As String = Conversions.ToString(current.Item("sAciklama"))
                                        Dim vATMATRAH As New Decimal
                                        Dim uOMREF As Long = 0
                                        Dim uSREF As Long = 0
                                        Dim num29 As Long = 0
                                        Try
                                            sOURCEINDEX = Convert.ToInt32(KeyCode.sorgu_sayi(RuntimeHelpers.GetObjectValue(current.Item("sDepo")), Decimal.Zero))
                                        Catch exception13 As Exception
                                            ProjectData.SetProjectError(exception13)
                                            Dim exception7 As Exception = exception13
                                            sOURCEINDEX = 1
                                            ProjectData.ClearProjectError()
                                        End Try
                                        Dim strArray As String() = current.Item("sKisaAdi").ToString.Split(New Char() {";"c})
                                        uOMREF = 0
                                        uSREF = 0
                                        num29 = 0
                                        aMOUNT = Conversions.ToDecimal(current.Item("lCikisMiktar1"))
                                        pRICE = Conversions.ToDecimal(current.Item("lBrutFiyat"))
                                        tOTAL = Conversions.ToDecimal(current.Item("lBrutTutar"))
                                        dISCPER = Conversions.ToDecimal(current.Item("nIskontoYuzdesi"))
                                        dISTCOST = Conversions.ToDecimal(current.Item("lIskontoTutari"))
                                        vATMATRAH = Conversions.ToDecimal(current.Item("lCikisMiktar1"))
                                        sALESMANREF = Convert.ToInt32(KeyCode.sorgu_sayi(RuntimeHelpers.GetObjectValue(current.Item("sSaticiRumuzu")), Decimal.Zero))
                                        lOGICALREF = Me.STLINE_kaydet_yeni(lOGICALREF, num16, 0, 0, 0, 0, tRCODE, RuntimeHelpers.GetObjectValue(dataRow.Item("dteFisTarihi")), num10, 0, 0, 0, 0, sOURCEINDEX, sOURCEINDEX, 0, 0, 0, 0, 0, 0, 0, 0, 4, sTFICHEREF, sTFICHELNNO, num4, sTFICHELNNO, num3, 0, 0, 0, aCCOUNTREF, vATACCREF, 0, 0, 0, 0, 0, 0, 0, "", "", aMOUNT, pRICE, tOTAL, 0, 0, 0, 0, 1, dISTCOST, dISTCOST, 0, 0, dISCPER, lINEEXP, uOMREF, uSREF, num29, 1, 0, 0, 0, 0, 0, 0, 0, 1, vAT, tOTALVAT, vATMATRAH, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, vATMATRAH, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, sALESMANREF, 0, 0, "", 0, 0, 0, 0, 0, 0, 0, 0, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "", "", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, month, year, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0)
                                        sTFICHELNNO += 1
                                    Loop
                                Finally
                                    If TypeOf enumerator2 Is IDisposable Then
                                        TryCast(enumerator2, IDisposable).Dispose()
                                    End If
                                End Try
                                lOGICALREF = Me.sorgula_logo_nStokID(Me.sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(MAX(LOGICALREF),0) + 1 AS LOGICALREF FROM         LG_*!F_!D_CLFLINE"))
                                lOGICALREF = Me.CLFLINE_kaydet_yeni(lOGICALREF, num3, 0, 0, 0, 0, 0, num4, time2, 0, 0, 4, &H26, 0, "", "", num4, "", "", 0, 0, RuntimeHelpers.GetObjectValue(dataRow.Item("lNetTutar")), 0, 0, RuntimeHelpers.GetObjectValue(dataRow.Item("lNetTutar")), 1, 0, 0, 0, 0, 0, 1, time2, str6, str4, str7, 1, time2, str6, str4, str6, 0, 0, "", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "", "", 0, 0, 0, 0, month, year, 0, 0, 0, 0, 0, 1, 0, 0, "", "", 0, "")
                            End If
                            Dim control As ProgressBarControl = Me.bar1
                            control.Position += 1
                            Me.bar1.Refresh()
                        Next
                        XtraMessageBox.Show(KeyCode.Sorgu_sDil("İşlem Başarıyla Tamamlandı...", KeyCode.sDil), KeyCode.Sorgu_sDil("Dikkat", KeyCode.sDil), MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                        Me.bar1.Visible = False
                    End If
                    current = Nothing
                End If
            End If
            Me.sCon.Close()
            Me.connection = RuntimeHelpers.GetObjectValue(objectValue)
            KeyCode.sConnection = Conversions.ToString(sConnection)
        End If
    End Sub
    ' ********************** Mikro Etegre1
    Public Function sorgula_Mikro_nStokID(ByVal query As String) As Long
        Try
            If (Me.sCon.State = ConnectionState.Closed) Then
                Me.sCon.Open()
            End If
        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            Dim exception As Exception = exception1
            Me.sCon.Close()
            Me.sCon.Open()
            ProjectData.ClearProjectError()
        End Try
        Me.sCmd.CommandText = query
        Return Conversions.ToLong(RuntimeHelpers.GetObjectValue(Me.sCmd.ExecuteScalar))
    End Function
    Public Function sorgula_Mikro_string(ByVal query As String) As String
        Try
            If (Me.sCon.State = ConnectionState.Closed) Then
                Me.sCon.Open()
            End If
        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            Dim exception As Exception = exception1
            Me.sCon.Close()
            Me.sCon.Open()
            ProjectData.ClearProjectError()
        End Try
        Me.sCmd.CommandText = query
        Return Conversions.ToString(RuntimeHelpers.GetObjectValue(Me.sCmd.ExecuteScalar))
    End Function

    Private Function STFICHE_kaydet_yeni_Mikro(ByVal LOGICALREF As Object, ByVal GRPCODE As Object, ByVal TRCODE As Object, ByVal IOCODE As Object, ByVal FICHENO As Object, ByVal DATE_ As Object, ByVal FTIME As Object, ByVal DOCODE As Object, ByVal INVNO As Object, ByVal SPECODE As Object, ByVal CYPHCODE As Object, ByVal INVOICEREF As Object, ByVal CLIENTREF As Object, ByVal RECVREF As Object, ByVal ACCOUNTREF As Object, ByVal CENTERREF As Object, ByVal PRODORDERREF As Object, ByVal PORDERFICHENO As Object, ByVal SOURCETYPE As Object, ByVal SOURCEINDEX As Object, ByVal SOURCEWSREF As Object, ByVal SOURCEPOLNREF As Object, ByVal SOURCECOSTGRP As Object, ByVal DESTTYPE As Object, ByVal DESTINDEX As Object, ByVal DESTWSREF As Object, ByVal DESTPOLNREF As Object, ByVal DESTCOSTGRP As Object, ByVal FACTORYNR As Object, ByVal BRANCH As Object, ByVal DEPARTMENT As Object, ByVal COMPBRANCH As Object, ByVal COMPDEPARTMENT As Object, ByVal COMPFACTORY As Object, ByVal PRODSTAT As Object, ByVal DEVIR As Object, ByVal CANCELLED As Object, ByVal BILLED As Object, ByVal ACCOUNTED As Object, ByVal UPDCURR As Object, ByVal INUSE As Object, ByVal INVKIND As Object, ByVal ADDDISCOUNTS As Object, ByVal TOTALDISCOUNTS As Object, ByVal TOTALDISCOUNTED As Object, ByVal ADDEXPENSES As Object, ByVal TOTALEXPENSES As Object, ByVal TOTALDEPOZITO As Object, ByVal TOTALPROMOTIONS As Object, ByVal TOTALVAT As Object, ByVal GROSSTOTAL As Object, ByVal NETTOTAL As Object, ByVal GENEXP1 As Object, ByVal GENEXP2 As Object, ByVal GENEXP3 As Object, ByVal GENEXP4 As Object, ByVal REPORTRATE As Object, ByVal REPORTNET As Object, ByVal EXTENREF As Object, ByVal PAYDEFREF As Object, ByVal PRINTCNT As Object, ByVal FICHECNT As Object, ByVal ACCFICHEREF As Object, ByVal CAPIBLOCK_CREATEDBY As Object, ByVal CAPIBLOCK_CREADEDDATE As Object, ByVal CAPIBLOCK_CREATEDHOUR As Object, ByVal CAPIBLOCK_CREATEDMIN As Object, ByVal CAPIBLOCK_CREATEDSEC As Object, ByVal CAPIBLOCK_MODIFIEDBY As Object, ByVal CAPIBLOCK_MODIFIEDDATE As Object, ByVal CAPIBLOCK_MODIFIEDHOUR As Object, ByVal CAPIBLOCK_MODIFIEDMIN As Object, ByVal CAPIBLOCK_MODIFIEDSEC As Object, ByVal SALESMANREF As Object, ByVal CANCELLEDACC As Object, ByVal SHPTYPCOD As Object, ByVal SHPAGNCOD As Object, ByVal TRACKNR As Object, ByVal GENEXCTYP As Object, ByVal LINEEXCTYP As Object, ByVal TRADINGGRP As Object, ByVal TEXTINC As Object, ByVal SITEID As Object, ByVal RECSTATUS As Object, ByVal ORGLOGICREF As Object, ByVal WFSTATUS As Object, ByVal SHIPINFOREF As Object, ByVal DISTORDERREF As Object, ByVal SENDCNT As Object, ByVal DLVCLIENT As Object, ByVal DOCTRACKINGNR As Object, ByVal ADDTAXCALC As Object, ByVal TOTALADDTAX As Object, ByVal UGIRTRACKINGNO As Object, ByVal QPRODFCREF As Object, ByVal VAACCREF As Object, ByVal VACENTERREF As Object, ByVal ORGLOGOID As Object, ByVal FROMEXIM As Object, ByVal FRGTYPCOD As Object, ByVal TRCURR As Object, ByVal TRRATE As Object, ByVal TRNET As Object, ByVal EXIMWHFCREF As Object, ByVal EXIMFCTYPE As Object, ByVal MAINSTFCREF As Object, ByVal FROMORDWITHPAY As Object, ByVal PROJECTREF As Object, ByVal WFLOWCRDREF As Object, ByVal STATUS As Object, ByVal UPDTRCURR As Object, ByVal TOTALEXADDTAX As Object, ByVal AFFECTCOLLATRL As Object, ByVal DEDUCTIONPART1 As Object, ByVal DEDUCTIONPART2 As Object, ByVal GRPFIRMTRANS As Object, ByVal AFFECTRISK As Object, ByVal DISPSTATUS As Object, ByVal APPROVE As Object, ByVal CANTCREDEDUCT As Object) As Long
        Try
            If (Me.sCon.State = ConnectionState.Closed) Then
                Me.sCon.Open()
            End If
        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            Dim exception As Exception = exception1
            Me.sCon.Close()
            Me.sCon.Open()
            ProjectData.ClearProjectError()
        End Try
        Me.sCmd.CommandText = Me.sorgu_query(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED  SET DATEFORMAT DMY INSERT INTO LG_*!F_!D_STFICHE(GRPCODE, TRCODE, IOCODE, FICHENO, DATE_, FTIME, DOCODE, INVNO, SPECODE, CYPHCODE, INVOICEREF, CLIENTREF, RECVREF, ACCOUNTREF, CENTERREF, PRODORDERREF, PORDERFICHENO, SOURCETYPE, SOURCEINDEX, SOURCEWSREF, SOURCEPOLNREF, SOURCECOSTGRP, DESTTYPE, DESTINDEX, DESTWSREF, DESTPOLNREF, DESTCOSTGRP, FACTORYNR, BRANCH, DEPARTMENT, COMPBRANCH, COMPDEPARTMENT, COMPFACTORY, PRODSTAT, DEVIR, CANCELLED, BILLED, ACCOUNTED, UPDCURR, INUSE, INVKIND, ADDDISCOUNTS, TOTALDISCOUNTS, TOTALDISCOUNTED, ADDEXPENSES, TOTALEXPENSES, TOTALDEPOZITO, TOTALPROMOTIONS, TOTALVAT, GROSSTOTAL, NETTOTAL, GENEXP1, GENEXP2, GENEXP3, GENEXP4, REPORTRATE, REPORTNET, EXTENREF, PAYDEFREF, PRINTCNT, FICHECNT, ACCFICHEREF, CAPIBLOCK_CREATEDBY, CAPIBLOCK_CREADEDDATE, CAPIBLOCK_CREATEDHOUR, CAPIBLOCK_CREATEDMIN, CAPIBLOCK_CREATEDSEC, CAPIBLOCK_MODIFIEDBY, CAPIBLOCK_MODIFIEDDATE, CAPIBLOCK_MODIFIEDHOUR, CAPIBLOCK_MODIFIEDMIN, CAPIBLOCK_MODIFIEDSEC, SALESMANREF, CANCELLEDACC, SHPTYPCOD, SHPAGNCOD, TRACKNR, GENEXCTYP, LINEEXCTYP, TRADINGGRP, TEXTINC, SITEID, RECSTATUS, ORGLOGICREF, WFSTATUS, SHIPINFOREF, DISTORDERREF, SENDCNT, DLVCLIENT, DOCTRACKINGNR, ADDTAXCALC, TOTALADDTAX, UGIRTRACKINGNO, QPRODFCREF, VAACCREF, VACENTERREF, ORGLOGOID, FROMEXIM, FRGTYPCOD, TRCURR, TRRATE, TRNET, EXIMWHFCREF, EXIMFCTYPE, MAINSTFCREF, FROMORDWITHPAY, PROJECTREF, WFLOWCRDREF, STATUS, UPDTRCURR, TOTALEXADDTAX, AFFECTCOLLATRL, DEDUCTIONPART1, DEDUCTIONPART2, GRPFIRMTRANS, AFFECTRISK, DISPSTATUS, APPROVE, CANTCREDEDUCT) VALUES (", GRPCODE), ","), TRCODE), ", "), IOCODE), ", '"), FICHENO), "', '"), DATE_), "', "), FTIME), ", '"), DOCODE), "', '"), INVNO), "', '"), SPECODE), "', '"), CYPHCODE), "', "), INVOICEREF), ", "), CLIENTREF), ", "), RECVREF), ", "), ACCOUNTREF), ", "), CENTERREF), ", "), PRODORDERREF), ", '"), PORDERFICHENO), "', "), SOURCETYPE), ", "), SOURCEINDEX), ", "), SOURCEWSREF), ", "), SOURCEPOLNREF), ", "), SOURCECOSTGRP), ", "), DESTTYPE), ", "), DESTINDEX), ", "), DESTWSREF), ", "), DESTPOLNREF), ", "), DESTCOSTGRP), ", "), FACTORYNR), ", "), BRANCH), ", "), DEPARTMENT), ", "), COMPBRANCH), ", "), COMPDEPARTMENT), ", "), COMPFACTORY), ", "), PRODSTAT), ", "), DEVIR), ", "), CANCELLED), ", "), BILLED), ", "), ACCOUNTED), ", "), UPDCURR), ", "), INUSE), ", "), INVKIND), ", "), ADDDISCOUNTS), ", "), TOTALDISCOUNTS), ", "), TOTALDISCOUNTED), ", "), ADDEXPENSES), ", "), TOTALEXPENSES), ", "), TOTALDEPOZITO), ", "), TOTALPROMOTIONS), ", "), TOTALVAT), ", "), GROSSTOTAL), ", "), NETTOTAL), ", '"), GENEXP1), "', '"), GENEXP2), "', '"), GENEXP3), "', '"), GENEXP4), "', "), REPORTRATE), ", "), REPORTNET), ", "), EXTENREF), ", "), PAYDEFREF), ", "), PRINTCNT), ", "), FICHECNT), ", "), ACCFICHEREF), ", "), CAPIBLOCK_CREATEDBY), ", '"), CAPIBLOCK_CREADEDDATE), "', "), CAPIBLOCK_CREATEDHOUR), ", "), CAPIBLOCK_CREATEDMIN), ", "), CAPIBLOCK_CREATEDSEC), ", "), CAPIBLOCK_MODIFIEDBY), ", '"), CAPIBLOCK_MODIFIEDDATE), "', "), CAPIBLOCK_MODIFIEDHOUR), ", "), CAPIBLOCK_MODIFIEDMIN), ", "), CAPIBLOCK_MODIFIEDSEC), ", "), SALESMANREF), ", "), CANCELLEDACC), ", '"), SHPTYPCOD), "', '"), SHPAGNCOD), "', '"), TRACKNR), "', "), GENEXCTYP), ", "), LINEEXCTYP), ", '"), TRADINGGRP), "', "), TEXTINC), ", "), SITEID), ", "), RECSTATUS), ", "), ORGLOGICREF), ", "), WFSTATUS), ", "), SHIPINFOREF), ", "), DISTORDERREF), ", "), SENDCNT), ", "), DLVCLIENT), ", '"), DOCTRACKINGNR), "', "), ADDTAXCALC), ", "), TOTALADDTAX), ", '"), UGIRTRACKINGNO), "', "), QPRODFCREF), ", "), VAACCREF), ", "), VACENTERREF), ", '"), ORGLOGOID), "', "), FROMEXIM), ", '"), FRGTYPCOD), "', "), TRCURR), ", "), TRRATE), ", "), TRNET), ", "), EXIMWHFCREF), ", "), EXIMFCTYPE), ", "), MAINSTFCREF), ", "), FROMORDWITHPAY), ", "), PROJECTREF), ", "), WFLOWCRDREF), ", "), STATUS), ", "), UPDTRCURR), ", "), TOTALEXADDTAX), ", "), AFFECTCOLLATRL), ", "), DEDUCTIONPART1), ", "), DEDUCTIONPART2), ", "), GRPFIRMTRANS), ", "), AFFECTRISK), ", "), DISPSTATUS), ", "), APPROVE), ", "), CANTCREDEDUCT), ")")))
        Me.sCmd.ExecuteNonQuery()
        Me.sCmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        LOGICALREF = RuntimeHelpers.GetObjectValue(Me.sCmd.ExecuteScalar)
        Return Conversions.ToLong(LOGICALREF)
    End Function

    Private Function STLINE_kaydet_yeni_Mikro(ByVal LOGICALREF As Object, ByVal STOCKREF As Object, ByVal LINETYPE As Object, ByVal PREVLINEREF As Object, ByVal PREVLINENO As Object, ByVal DETLINE As Object, ByVal TRCODE As Object, ByVal DATE_ As Object, ByVal FTIME As Object, ByVal GLOBTRANS As Object, ByVal CALCTYPE As Object, ByVal PRODORDERREF As Object, ByVal SOURCETYPE As Object, ByVal SOURCEINDEX As Object, ByVal SOURCECOSTGRP As Object, ByVal SOURCEWSREF As Object, ByVal SOURCEPOLNREF As Object, ByVal DESTTYPE As Object, ByVal DESTINDEX As Object, ByVal DESTCOSTGRP As Object, ByVal DESTWSREF As Object, ByVal DESTPOLNREF As Object, ByVal FACTORYNR As Object, ByVal IOCODE As Object, ByVal STFICHEREF As Object, ByVal STFICHELNNO As Object, ByVal INVOICEREF As Object, ByVal INVOICELNNO As Object, ByVal CLIENTREF As Object, ByVal ORDTRANSREF As Object, ByVal ORDFICHEREF As Object, ByVal CENTERREF As Object, ByVal ACCOUNTREF As Object, ByVal VATACCREF As Object, ByVal VATCENTERREF As Object, ByVal PRACCREF As Object, ByVal PRCENTERREF As Object, ByVal PRVATACCREF As Object, ByVal PRVATCENREF As Object, ByVal PROMREF As Object, ByVal PAYDEFREF As Object, ByVal SPECODE As Object, ByVal DELVRYCODE As Object, ByVal AMOUNT As Object, ByVal PRICE As Object, ByVal TOTAL As Object, ByVal PRCURR As Object, ByVal PRPRICE As Object, ByVal TRCURR As Object, ByVal TRRATE As Object, ByVal REPORTRATE As Object, ByVal DISTCOST As Object, ByVal DISTDISC As Object, ByVal DISTEXP As Object, ByVal DISTPROM As Object, ByVal DISCPER As Object, ByVal LINEEXP As Object, ByVal UOMREF As Object, ByVal USREF As Object, ByVal UINFO1 As Object, ByVal UINFO2 As Object, ByVal UINFO3 As Object, ByVal UINFO4 As Object, ByVal UINFO5 As Object, ByVal UINFO6 As Object, ByVal UINFO7 As Object, ByVal UINFO8 As Object, ByVal PLNAMOUNT As Object, ByVal VATINC As Object, ByVal VAT As Object, ByVal VATAMNT As Object, ByVal VATMATRAH As Object, ByVal BILLEDITEM As Object, ByVal BILLED As Object, ByVal CPSTFLAG As Object, ByVal RETCOSTTYPE As Object, ByVal SOURCELINK As Object, ByVal RETCOST As Object, ByVal RETCOSTCURR As Object, ByVal OUTCOST As Object, ByVal OUTCOSTCURR As Object, ByVal RETAMOUNT As Object, ByVal FAREGREF As Object, ByVal FAATTRIB As Object, ByVal CANCELLED As Object, ByVal LINENET As Object, ByVal DISTADDEXP As Object, ByVal FADACCREF As Object, ByVal FADCENTERREF As Object, ByVal FARACCREF As Object, ByVal FARCENTERREF As Object, ByVal DIFFPRICE As Object, ByVal DIFFPRCOST As Object, ByVal DECPRDIFF As Object, ByVal LPRODSTAT As Object, ByVal PRDEXPTOTAL As Object, ByVal DIFFREPPRICE As Object, ByVal DIFFPRCRCOST As Object, ByVal SALESMANREF As Object, ByVal FAPLACCREF As Object, ByVal FAPLCENTERREF As Object, ByVal OUTPUTIDCODE As Object, ByVal DREF As Object, ByVal COSTRATE As Object, ByVal XPRICEUPD As Object, ByVal XPRICE As Object, ByVal XREPRATE As Object, ByVal DISTCOEF As Object, ByVal TRANSQCOK As Object, ByVal SITEID As Object, ByVal RECSTATUS As Object, ByVal ORGLOGICREF As Object, ByVal WFSTATUS As Object, ByVal POLINEREF As Object, ByVal PLNSTTRANSREF As Object, ByVal NETDISCFLAG As Object, ByVal NETDISCPERC As Object, ByVal NETDISCAMNT As Object, ByVal VATCALCDIFF As Object, ByVal CONDITIONREF As Object, ByVal DISTORDERREF As Object, ByVal DISTORDLINEREF As Object, ByVal CAMPAIGNREFS1 As Object, ByVal CAMPAIGNREFS2 As Object, ByVal CAMPAIGNREFS3 As Object, ByVal CAMPAIGNREFS4 As Object, ByVal CAMPAIGNREFS5 As Object, ByVal POINTCAMPREF As Object, ByVal CAMPPOINT As Object, ByVal PROMCLASITEMREF As Object, ByVal CMPGLINEREF As Object, ByVal PLNSTTRANSPERNR As Object, ByVal PORDCLSPLNAMNT As Object, ByVal VENDCOMM As Object, ByVal PREVIOUSOUTCOST As Object, ByVal COSTOFSALEACCREF As Object, ByVal PURCHACCREF As Object, ByVal COSTOFSALECNTREF As Object, ByVal PURCHCENTREF As Object, ByVal PREVOUTCOSTCURR As Object, ByVal ABVATAMOUNT As Object, ByVal ABVATSTATUS As Object, ByVal PRRATE As Object, ByVal ADDTAXRATE As Object, ByVal ADDTAXCONVFACT As Object, ByVal ADDTAXAMOUNT As Object, ByVal ADDTAXPRCOST As Object, ByVal ADDTAXRETCOST As Object, ByVal ADDTAXRETCOSTCURR As Object, ByVal GROSSUINFO1 As Object, ByVal GROSSUINFO2 As Object, ByVal ADDTAXPRCOSTCURR As Object, ByVal ADDTAXACCREF As Object, ByVal ADDTAXCENTERREF As Object, ByVal ADDTAXAMNTISUPD As Object, ByVal INFIDX As Object, ByVal ADDTAXCOSACCREF As Object, ByVal ADDTAXCOSCNTREF As Object, ByVal PREVIOUSATAXPRCOST As Object, ByVal PREVATAXPRCOSTCURR As Object, ByVal PRDORDTOTCOEF As Object, ByVal DEMPEGGEDAMNT As Object, ByVal STDUNITCOST As Object, ByVal STDRPUNITCOST As Object, ByVal COSTDIFFACCREF As Object, ByVal COSTDIFFCENREF As Object, ByVal TEXTINC As Object, ByVal ADDTAXDISCAMOUNT As Object, ByVal ORGLOGOID As Object, ByVal EXIMFICHENO As Object, ByVal EXIMFCTYPE As Object, ByVal TRANSEXPLINE As Object, ByVal INSEXPLINE As Object, ByVal EXIMWHFCREF As Object, ByVal EXIMWHLNREF As Object, ByVal EXIMFILEREF As Object, ByVal EXIMPROCNR As Object, ByVal EISRVDSTTYP As Object, ByVal MAINSTLNREF As Object, ByVal MADEOFSHRED As Object, ByVal FROMORDWITHPAY As Object, ByVal PROJECTREF As Object, ByVal STATUS As Object, ByVal DORESERVE As Object, ByVal POINTCAMPREFS1 As Object, ByVal POINTCAMPREFS2 As Object, ByVal POINTCAMPREFS3 As Object, ByVal POINTCAMPREFS4 As Object, ByVal CAMPPOINTS1 As Object, ByVal CAMPPOINTS2 As Object, ByVal CAMPPOINTS3 As Object, ByVal CAMPPOINTS4 As Object, ByVal CMPGLINEREFS1 As Object, ByVal CMPGLINEREFS2 As Object, ByVal CMPGLINEREFS3 As Object, ByVal CMPGLINEREFS4 As Object, ByVal PRCLISTREF As Object, ByVal PORDSYMOUTLN As Object, ByVal MONTH_ As Object, ByVal YEAR_ As Object, ByVal EXADDTAXRATE As Object, ByVal EXADDTAXCONVF As Object, ByVal EXADDTAXAREF As Object, ByVal EXADDTAXCREF As Object, ByVal OTHRADDTAXAREF As Object, ByVal OTHRADDTAXCREF As Object, ByVal EXADDTAXAMNT As Object, ByVal AFFECTCOLLATRL As Object, ByVal ALTPROMFLAG As Object, ByVal EIDISTFLNNR As Object, ByVal EXIMTYPE As Object, ByVal VARIANTREF As Object, ByVal CANDEDUCT As Object, ByVal OUTREMAMNT As Object, ByVal OUTREMCOST As Object, ByVal OUTREMCOSTCURR As Object, ByVal REFLVATACCREF As Object, ByVal REFLVATOTHACCREF As Object, ByVal PARENTLNREF As Object, ByVal AFFECTRISK As Object, ByVal INEFFECTIVECOST As Object, ByVal ADDTAXVATMATRAH As Object, ByVal REFLACCREF As Object, ByVal REFLOTHACCREF As Object) As Long
        Try
            If (Me.sCon.State = ConnectionState.Closed) Then
                Me.sCon.Open()
            End If
        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            Dim exception As Exception = exception1
            Me.sCon.Close()
            Me.sCon.Open()
            ProjectData.ClearProjectError()
        End Try
        Me.sCmd.CommandText = Me.sorgu_query(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED  SET DATEFORMAT DMY INSERT INTO LG_*!F_!D_STLINE(STOCKREF, LINETYPE, PREVLINEREF, PREVLINENO, DETLINE, TRCODE, DATE_, FTIME, GLOBTRANS, CALCTYPE, PRODORDERREF, SOURCETYPE, SOURCEINDEX, SOURCECOSTGRP, SOURCEWSREF, SOURCEPOLNREF, DESTTYPE, DESTINDEX, DESTCOSTGRP, DESTWSREF, DESTPOLNREF, FACTORYNR, IOCODE, STFICHEREF, STFICHELNNO, INVOICEREF, INVOICELNNO, CLIENTREF, ORDTRANSREF, ORDFICHEREF, CENTERREF, ACCOUNTREF, VATACCREF, VATCENTERREF, PRACCREF, PRCENTERREF, PRVATACCREF, PRVATCENREF, PROMREF, PAYDEFREF, SPECODE, DELVRYCODE, AMOUNT, PRICE, TOTAL, PRCURR, PRPRICE, TRCURR, TRRATE, REPORTRATE, DISTCOST, DISTDISC, DISTEXP, DISTPROM, DISCPER, LINEEXP, UOMREF, USREF, UINFO1, UINFO2, UINFO3, UINFO4, UINFO5, UINFO6, UINFO7, UINFO8, PLNAMOUNT, VATINC, VAT, VATAMNT, VATMATRAH, BILLEDITEM, BILLED, CPSTFLAG, RETCOSTTYPE, SOURCELINK, RETCOST, RETCOSTCURR, OUTCOST, OUTCOSTCURR, RETAMOUNT, FAREGREF, FAATTRIB, CANCELLED, LINENET, DISTADDEXP, FADACCREF, FADCENTERREF, FARACCREF, FARCENTERREF, DIFFPRICE, DIFFPRCOST, DECPRDIFF, LPRODSTAT, PRDEXPTOTAL, DIFFREPPRICE, DIFFPRCRCOST, SALESMANREF, FAPLACCREF, FAPLCENTERREF, OUTPUTIDCODE, DREF, COSTRATE, XPRICEUPD, XPRICE, XREPRATE, DISTCOEF, TRANSQCOK, SITEID, RECSTATUS, ORGLOGICREF, WFSTATUS, POLINEREF, PLNSTTRANSREF, NETDISCFLAG, NETDISCPERC, NETDISCAMNT, VATCALCDIFF, CONDITIONREF, DISTORDERREF, DISTORDLINEREF, CAMPAIGNREFS1, CAMPAIGNREFS2, CAMPAIGNREFS3, CAMPAIGNREFS4, CAMPAIGNREFS5, POINTCAMPREF, CAMPPOINT, PROMCLASITEMREF, CMPGLINEREF, PLNSTTRANSPERNR, PORDCLSPLNAMNT, VENDCOMM, PREVIOUSOUTCOST, COSTOFSALEACCREF, PURCHACCREF, COSTOFSALECNTREF, PURCHCENTREF, PREVOUTCOSTCURR, ABVATAMOUNT, ABVATSTATUS, PRRATE, ADDTAXRATE, ADDTAXCONVFACT, ADDTAXAMOUNT, ADDTAXPRCOST, ADDTAXRETCOST, ADDTAXRETCOSTCURR, GROSSUINFO1, GROSSUINFO2, ADDTAXPRCOSTCURR, ADDTAXACCREF, ADDTAXCENTERREF, ADDTAXAMNTISUPD, INFIDX, ADDTAXCOSACCREF, ADDTAXCOSCNTREF, PREVIOUSATAXPRCOST, PREVATAXPRCOSTCURR, PRDORDTOTCOEF, DEMPEGGEDAMNT, STDUNITCOST, STDRPUNITCOST, COSTDIFFACCREF, COSTDIFFCENREF, TEXTINC, ADDTAXDISCAMOUNT, ORGLOGOID, EXIMFICHENO, EXIMFCTYPE, TRANSEXPLINE, INSEXPLINE, EXIMWHFCREF, EXIMWHLNREF, EXIMFILEREF, EXIMPROCNR, EISRVDSTTYP, MAINSTLNREF, MADEOFSHRED, FROMORDWITHPAY, PROJECTREF, STATUS, DORESERVE, POINTCAMPREFS1, POINTCAMPREFS2, POINTCAMPREFS3, POINTCAMPREFS4, CAMPPOINTS1, CAMPPOINTS2, CAMPPOINTS3, CAMPPOINTS4, CMPGLINEREFS1, CMPGLINEREFS2, CMPGLINEREFS3, CMPGLINEREFS4, PRCLISTREF, PORDSYMOUTLN, MONTH_, YEAR_, EXADDTAXRATE, EXADDTAXCONVF, EXADDTAXAREF, EXADDTAXCREF, OTHRADDTAXAREF, OTHRADDTAXCREF, EXADDTAXAMNT, AFFECTCOLLATRL, ALTPROMFLAG, EIDISTFLNNR, EXIMTYPE, VARIANTREF, CANDEDUCT, OUTREMAMNT, OUTREMCOST, OUTREMCOSTCURR, REFLVATACCREF, REFLVATOTHACCREF, PARENTLNREF, AFFECTRISK, INEFFECTIVECOST, ADDTAXVATMATRAH, REFLACCREF, REFLOTHACCREF) VALUES ( ", STOCKREF), " , "), LINETYPE), " , "), PREVLINEREF), " , "), PREVLINENO), " , "), DETLINE), " , "), TRCODE), " , '"), DATE_), "' , "), FTIME), " , "), GLOBTRANS), " , "), CALCTYPE), " , "), PRODORDERREF), " , "), SOURCETYPE), " , "), SOURCEINDEX), " , "), SOURCECOSTGRP), " , "), SOURCEWSREF), " , "), SOURCEPOLNREF), " , "), DESTTYPE), " , "), DESTINDEX), " , "), DESTCOSTGRP), " , "), DESTWSREF), " , "), DESTPOLNREF), " , "), FACTORYNR), " , "), IOCODE), " , "), STFICHEREF), " , "), STFICHELNNO), " , "), INVOICEREF), " , "), INVOICELNNO), " , "), CLIENTREF), " , "), ORDTRANSREF), " , "), ORDFICHEREF), " , "), CENTERREF), " , "), ACCOUNTREF), " , "), VATACCREF), " , "), VATCENTERREF), " , "), PRACCREF), " , "), PRCENTERREF), " , "), PRVATACCREF), " , "), PRVATCENREF), " , "), PROMREF), " , "), PAYDEFREF), " , '"), SPECODE), "' , '"), DELVRYCODE), "' , "), AMOUNT), " , "), PRICE), " , "), TOTAL), " , "), PRCURR), " , "), PRPRICE), " , "), TRCURR), " , "), TRRATE), " , "), REPORTRATE), " , "), DISTCOST), " , "), DISTDISC), " , "), DISTEXP), " , "), DISTPROM), " , "), DISCPER), " , '"), LINEEXP), "' , "), UOMREF), " , "), USREF), " , "), UINFO1), " , "), UINFO2), " , "), UINFO3), " , "), UINFO4), " , "), UINFO5), " , "), UINFO6), " , "), UINFO7), " , "), UINFO8), " , "), PLNAMOUNT), " , "), VATINC), " , "), VAT), " , "), VATAMNT), " , "), VATMATRAH), " , "), BILLEDITEM), " , "), BILLED), " , "), CPSTFLAG), " , "), RETCOSTTYPE), " , "), SOURCELINK), " , "), RETCOST), " , "), RETCOSTCURR), " , "), OUTCOST), " , "), OUTCOSTCURR), " , "), RETAMOUNT), " , "), FAREGREF), " , "), FAATTRIB), " , "), CANCELLED), " , "), LINENET), " , "), DISTADDEXP), " , "), FADACCREF), " , "), FADCENTERREF), " , "), FARACCREF), " , "), FARCENTERREF), " , "), DIFFPRICE), " , "), DIFFPRCOST), " , "), DECPRDIFF), " , "), LPRODSTAT), " , "), PRDEXPTOTAL), " , "), DIFFREPPRICE), " , "), DIFFPRCRCOST), " , "), SALESMANREF), " , "), FAPLACCREF), " , "), FAPLCENTERREF), " , '"), OUTPUTIDCODE), "' , "), DREF), " , "), COSTRATE), " , "), XPRICEUPD), " , "), XPRICE), " , "), XREPRATE), " , "), DISTCOEF), " , "), TRANSQCOK), " , "), SITEID), " , "), RECSTATUS), " , "), ORGLOGICREF), " , "), WFSTATUS), " , "), POLINEREF), " , "), PLNSTTRANSREF), " , "), NETDISCFLAG), " , "), NETDISCPERC), " , "), NETDISCAMNT), " , "), VATCALCDIFF), " , "), CONDITIONREF), " , "), DISTORDERREF), " , "), DISTORDLINEREF), " , "), CAMPAIGNREFS1), " , "), CAMPAIGNREFS2), " , "), CAMPAIGNREFS3), " , "), CAMPAIGNREFS4), " , "), CAMPAIGNREFS5), " , "), POINTCAMPREF), " , "), CAMPPOINT), " , "), PROMCLASITEMREF), " , "), CMPGLINEREF), " , "), PLNSTTRANSPERNR), " , "), PORDCLSPLNAMNT), " , "), VENDCOMM), " , "), PREVIOUSOUTCOST), " , "), COSTOFSALEACCREF), " , "), PURCHACCREF), " , "), COSTOFSALECNTREF), " , "), PURCHCENTREF), " , "), PREVOUTCOSTCURR), " , "), ABVATAMOUNT), " , "), ABVATSTATUS), " , "), PRRATE), " , "), ADDTAXRATE), " , "), ADDTAXCONVFACT), " , "), ADDTAXAMOUNT), " , "), ADDTAXPRCOST), " , "), ADDTAXRETCOST), " , "), ADDTAXRETCOSTCURR), " , "), GROSSUINFO1), " , "), GROSSUINFO2), " , "), ADDTAXPRCOSTCURR), " , "), ADDTAXACCREF), " , "), ADDTAXCENTERREF), " , "), ADDTAXAMNTISUPD), " , "), INFIDX), " , "), ADDTAXCOSACCREF), " , "), ADDTAXCOSCNTREF), " , "), PREVIOUSATAXPRCOST), " , "), PREVATAXPRCOSTCURR), " , "), PRDORDTOTCOEF), " , "), DEMPEGGEDAMNT), " , "), STDUNITCOST), " , "), STDRPUNITCOST), " , "), COSTDIFFACCREF), " , "), COSTDIFFCENREF), " , "), TEXTINC), " , "), ADDTAXDISCAMOUNT), " , '"), ORGLOGOID), "' , '"), EXIMFICHENO), "' , "), EXIMFCTYPE), " , "), TRANSEXPLINE), " , "), INSEXPLINE), " , "), EXIMWHFCREF), " , "), EXIMWHLNREF), " , "), EXIMFILEREF), " , "), EXIMPROCNR), " , "), EISRVDSTTYP), " , "), MAINSTLNREF), " , "), MADEOFSHRED), " , "), FROMORDWITHPAY), " , "), PROJECTREF), " , "), STATUS), " , "), DORESERVE), " , "), POINTCAMPREFS1), " , "), POINTCAMPREFS2), " , "), POINTCAMPREFS3), " , "), POINTCAMPREFS4), " , "), CAMPPOINTS1), " , "), CAMPPOINTS2), " , "), CAMPPOINTS3), " , "), CAMPPOINTS4), " , "), CMPGLINEREFS1), " , "), CMPGLINEREFS2), " , "), CMPGLINEREFS3), " , "), CMPGLINEREFS4), " , "), PRCLISTREF), " , "), PORDSYMOUTLN), " , "), MONTH_), " , "), YEAR_), " , "), EXADDTAXRATE), " , "), EXADDTAXCONVF), " , "), EXADDTAXAREF), " , "), EXADDTAXCREF), " , "), OTHRADDTAXAREF), " , "), OTHRADDTAXCREF), " , "), EXADDTAXAMNT), " , "), AFFECTCOLLATRL), " , "), ALTPROMFLAG), " , "), EIDISTFLNNR), " , "), EXIMTYPE), " , "), VARIANTREF), " , "), CANDEDUCT), " , "), OUTREMAMNT), " , "), OUTREMCOST), " , "), OUTREMCOSTCURR), " , "), REFLVATACCREF), " , "), REFLVATOTHACCREF), " , "), PARENTLNREF), " , "), AFFECTRISK), " , "), INEFFECTIVECOST), " , "), ADDTAXVATMATRAH), " , "), REFLACCREF), " , "), REFLOTHACCREF), ")")))
        Me.sCmd.ExecuteNonQuery()
        Me.sCmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        LOGICALREF = RuntimeHelpers.GetObjectValue(Me.sCmd.ExecuteScalar)
        Return Conversions.ToLong(LOGICALREF)
    End Function
    Private Function CARI_kaydet_yeni_Mikro(ByVal cari_RECno As Long, ByVal cari_RECid_DBCno As Integer, ByVal cari_RECid_RECno As Long, ByVal cari_SpecRECno As Long, ByVal cari_iptal As Boolean, ByVal cari_fileid As Integer, ByVal cari_hidden As Boolean, ByVal cari_kilitli As Boolean, ByVal cari_degisti As Boolean, ByVal cari_checksum As Long, ByVal cari_create_user As Integer, ByVal cari_create_date As DateTime, ByVal cari_lastup_user As Integer, ByVal cari_lastup_date As DateTime, ByVal cari_special1 As String, ByVal cari_special2 As String, ByVal cari_special3 As String, ByVal cari_kod As String, ByVal cari_unvan1 As String, ByVal cari_unvan2 As String, ByVal cari_hareket_tipi As Byte, ByVal cari_baglanti_tipi As Byte, ByVal cari_stok_alim_cinsi As Byte, ByVal cari_stok_satim_cinsi As Byte, ByVal cari_muh_kod As String, ByVal cari_muh_kod1 As String, ByVal cari_muh_kod2 As String, ByVal cari_doviz_cinsi As Byte, ByVal cari_doviz_cinsi1 As Byte, ByVal cari_doviz_cinsi2 As Byte, ByVal cari_vade_fark_yuz As Decimal, ByVal cari_vade_fark_yuz1 As Decimal, ByVal cari_vade_fark_yuz2 As Decimal, ByVal cari_KurHesapSekli As Byte, ByVal cari_vdaire_adi As String, ByVal cari_vdaire_no As String, ByVal cari_sicil_no As String, ByVal cari_VergiKimlikNo As String, ByVal cari_satis_fk As Long, ByVal cari_odeme_cinsi As Byte, ByVal cari_odeme_gunu As Byte, ByVal cari_odemeplan_no As Long, ByVal cari_opsiyon_gun As Long, ByVal cari_cariodemetercihi As Byte, ByVal cari_fatura_adres_no As Long, ByVal cari_sevk_adres_no As Long, ByVal cari_banka_tcmb_kod1 As String, ByVal cari_banka_tcmb_subekod1 As String, ByVal cari_banka_tcmb_ilkod1 As String, ByVal cari_banka_hesapno1 As String, ByVal cari_banka_swiftkodu1 As String, ByVal cari_banka_tcmb_kod2 As String, ByVal cari_banka_tcmb_subekod2 As String, ByVal cari_banka_tcmb_ilkod2 As String, ByVal cari_banka_hesapno2 As String, ByVal cari_banka_swiftkodu2 As String, ByVal cari_banka_tcmb_kod3 As String, ByVal cari_banka_tcmb_subekod3 As String, ByVal cari_banka_tcmb_ilkod3 As String, ByVal cari_banka_hesapno3 As String, ByVal cari_banka_swiftkodu3 As String, ByVal cari_banka_tcmb_kod4 As String, ByVal cari_banka_tcmb_subekod4 As String, ByVal cari_banka_tcmb_ilkod4 As String, ByVal cari_banka_hesapno4 As String, ByVal cari_banka_swiftkodu4 As String, ByVal cari_banka_tcmb_kod5 As String, ByVal cari_banka_tcmb_subekod5 As String, ByVal cari_banka_tcmb_ilkod5 As String, ByVal cari_banka_hesapno5 As String, ByVal cari_banka_swiftkodu5 As String, ByVal cari_banka_tcmb_kod6 As String, ByVal cari_banka_tcmb_subekod6 As String, ByVal cari_banka_tcmb_ilkod6 As String, ByVal cari_banka_hesapno6 As String, ByVal Cari_banka_swiftkodu6 As String, ByVal cari_banka_tcmb_kod7 As String, ByVal cari_banka_tcmb_subekod7 As String, ByVal cari_banka_tcmb_ilkod7 As String, ByVal cari_banka_hesapno7 As String, ByVal cari_banka_swiftkodu7 As String, ByVal cari_banka_tcmb_kod8 As String, ByVal cari_banka_tcmb_subekod8 As String, ByVal cari_banka_tcmb_ilkod8 As String, ByVal cari_banka_hesapno8 As String, ByVal cari_banka_swiftkodu8 As String, ByVal cari_banka_tcmb_kod9 As String, ByVal cari_banka_tcmb_subekod9 As String, ByVal cari_banka_tcmb_ilkod9 As String, ByVal cari_banka_hesapno9 As String, ByVal cari_banka_swiftkodu9 As String, ByVal cari_banka_tcmb_kod10 As String, ByVal cari_banka_tcmb_subekod10 As String, ByVal cari_banka_tcmb_ilkod10 As String, ByVal cari_banka_hesapno10 As String, ByVal cari_banka_swiftkodu10 As String, ByVal cari_EftHesapNum As Byte, ByVal cari_Ana_cari_kodu As String, ByVal cari_satis_isk_kod As String, ByVal cari_sektor_kodu As String, ByVal cari_bolge_kodu As String, ByVal cari_grup_kodu As String, ByVal cari_temsilci_kodu As String, ByVal cari_muhartikeli As String, ByVal cari_firma_acik_kapal As Boolean, ByVal cari_BUV_tabi_fl As Boolean, ByVal cari_cari_kilitli_flg As Boolean, ByVal cari_etiket_bas_fl As Boolean, ByVal cari_Detay_incele_flg As Boolean, ByVal cari_efatura_fl As Boolean, ByVal cari_POS_ongpesyuzde As Decimal, ByVal cari_POS_ongtaksayi As Decimal, ByVal cari_POS_ongIskOran As Decimal, ByVal cari_kaydagiristarihi As DateTime, ByVal cari_KabEdFCekTutar As Decimal, ByVal cari_hal_caritip As Byte, ByVal cari_HalKomYuzdesi As Decimal, ByVal cari_TeslimSuresi As Integer, ByVal cari_wwwadresi As String, ByVal cari_EMail As String, ByVal cari_CepTel As String, ByVal cari_VarsayilanGirisDepo As Long, ByVal cari_VarsayilanCikisDepo As Long, ByVal cari_Portal_Enabled As Long, ByVal cari_Portal_PW As String, ByVal cari_BagliOrtaklisa_Firma As Long, ByVal cari_kampanyakodu As String, ByVal cari_b_bakiye_degerlendirilmesin_fl As Boolean, ByVal cari_a_bakiye_degerlendirilmesin_fl As Boolean, ByVal cari_b_irsbakiye_degerlendirilmesin_fl As Boolean, ByVal cari_a_irsbakiye_degerlendirilmesin_fl As Boolean, ByVal cari_b_sipbakiye_degerlendirilmesin_fl As Boolean, ByVal cari_a_sipbakiye_degerlendirilmesin_fl As Boolean, ByVal cari_AvmBilgileri1KiraKodu As String, ByVal cari_AvmBilgileri1TebligatSekli As Byte, ByVal cari_AvmBilgileri2KiraKodu As String, ByVal cari_AvmBilgileri2TebligatSekli As Byte, ByVal cari_AvmBilgileri3KiraKodu As String, ByVal cari_AvmBilgileri3TebligatSekli As Byte, ByVal cari_AvmBilgileri4KiraKodu As String, ByVal cari_AvmBilgileri4TebligatSekli As Byte, ByVal cari_AvmBilgileri5KiraKodu As String, ByVal cari_AvmBilgileri5TebligatSekli As Byte, ByVal cari_AvmBilgileri6KiraKodu As String, ByVal cari_AvmBilgileri6TebligatSekli As Byte, ByVal cari_AvmBilgileri7KiraKodu As String, ByVal cari_AvmBilgileri7TebligatSekli As Byte, ByVal cari_AvmBilgileri8KiraKodu As String, ByVal cari_AvmBilgileri8TebligatSekli As Byte, ByVal cari_AvmBilgileri9KiraKodu As String, ByVal cari_AvmBilgileri9TebligatSekli As Byte, ByVal cari_AvmBilgileri10KiraKodu As String, ByVal cari_AvmBilgileri10TebligatSekli As Byte, ByVal cari_KrediRiskTakibiVar_flg As Boolean, ByVal cari_ufrs_fark_muh_kod As String, ByVal cari_ufrs_fark_muh_kod1 As String, ByVal cari_ufrs_fark_muh_kod2 As String, ByVal cari_odeme_sekli As Byte, ByVal cari_TeminatMekAlacakMuhKodu As String, ByVal cari_TeminatMekAlacakMuhKodu1 As String, ByVal cari_TeminatMekAlacakMuhKodu2 As String, ByVal cari_TeminatMekBorcMuhKodu As String, ByVal cari_TeminatMekBorcMuhKodu1 As String, ByVal cari_TeminatMekBorcMuhKodu2 As String, ByVal cari_VerilenDepozitoTeminatMuhKodu As String, ByVal cari_VerilenDepozitoTeminatMuhKodu1 As String, ByVal cari_VerilenDepozitoTeminatMuhKodu2 As String, ByVal cari_AlinanDepozitoTeminatMuhKodu As String, ByVal cari_AlinanDepozitoTeminatMuhKodu1 As String, ByVal cari_AlinanDepozitoTeminatMuhKodu2 As String, ByVal cari_def_efatura_cinsi As Byte, ByVal cari_otv_tevkifatina_tabii_fl As Boolean) As Long
        Try
            If (Me.sCon.State = ConnectionState.Closed) Then
                Me.sCon.Open()
            End If
        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            Dim exception As Exception = exception1
            Me.sCon.Close()
            Me.sCon.Open()
            ProjectData.ClearProjectError()
        End Try
        Me.sCmd.CommandText = Me.sorgu_query(String.Concat(New String() {"SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED  SET DATEFORMAT DMY INSERT INTO CARI_HESAPLAR (cari_RECid_DBCno,cari_RECid_RECno,cari_SpecRECno,cari_iptal,cari_fileid,cari_hidden,cari_kilitli,cari_degisti,cari_checksum,cari_create_user,cari_create_date,cari_lastup_user,cari_lastup_date,cari_special1,cari_special2,cari_special3,cari_kod,cari_unvan1,cari_unvan2,cari_hareket_tipi,cari_baglanti_tipi,cari_stok_alim_cinsi,cari_stok_satim_cinsi,cari_muh_kod,cari_muh_kod1,cari_muh_kod2,cari_doviz_cinsi,cari_doviz_cinsi1,cari_doviz_cinsi2,cari_vade_fark_yuz,cari_vade_fark_yuz1,cari_vade_fark_yuz2,cari_KurHesapSekli,cari_vdaire_adi,cari_vdaire_no,cari_sicil_no,cari_VergiKimlikNo,cari_satis_fk,cari_odeme_cinsi,cari_odeme_gunu,cari_odemeplan_no,cari_opsiyon_gun,cari_cariodemetercihi,cari_fatura_adres_no,cari_sevk_adres_no,cari_banka_tcmb_kod1,cari_banka_tcmb_subekod1,cari_banka_tcmb_ilkod1,cari_banka_hesapno1,cari_banka_swiftkodu1,cari_banka_tcmb_kod2,cari_banka_tcmb_subekod2,cari_banka_tcmb_ilkod2,cari_banka_hesapno2,cari_banka_swiftkodu2,cari_banka_tcmb_kod3,cari_banka_tcmb_subekod3,cari_banka_tcmb_ilkod3,cari_banka_hesapno3,cari_banka_swiftkodu3,cari_banka_tcmb_kod4,cari_banka_tcmb_subekod4,cari_banka_tcmb_ilkod4,cari_banka_hesapno4,cari_banka_swiftkodu4,cari_banka_tcmb_kod5,cari_banka_tcmb_subekod5,cari_banka_tcmb_ilkod5,cari_banka_hesapno5,cari_banka_swiftkodu5,cari_banka_tcmb_kod6,cari_banka_tcmb_subekod6,cari_banka_tcmb_ilkod6,cari_banka_hesapno6,Cari_banka_swiftkodu6,cari_banka_tcmb_kod7,cari_banka_tcmb_subekod7,cari_banka_tcmb_ilkod7,cari_banka_hesapno7,cari_banka_swiftkodu7,cari_banka_tcmb_kod8,cari_banka_tcmb_subekod8,cari_banka_tcmb_ilkod8,cari_banka_hesapno8,cari_banka_swiftkodu8,cari_banka_tcmb_kod9,cari_banka_tcmb_subekod9,cari_banka_tcmb_ilkod9,cari_banka_hesapno9,cari_banka_swiftkodu9,cari_banka_tcmb_kod10,cari_banka_tcmb_subekod10,cari_banka_tcmb_ilkod10,cari_banka_hesapno10,cari_banka_swiftkodu10,cari_EftHesapNum,cari_Ana_cari_kodu,cari_satis_isk_kod,cari_sektor_kodu,cari_bolge_kodu,cari_grup_kodu,cari_temsilci_kodu,cari_muhartikeli,cari_firma_acik_kapal,cari_BUV_tabi_fl,cari_cari_kilitli_flg,cari_etiket_bas_fl,cari_Detay_incele_flg,cari_efatura_fl,cari_POS_ongpesyuzde,cari_POS_ongtaksayi,cari_POS_ongIskOran,cari_kaydagiristarihi,cari_KabEdFCekTutar,cari_hal_caritip,cari_HalKomYuzdesi,cari_TeslimSuresi,cari_wwwadresi,cari_EMail,cari_CepTel,cari_VarsayilanGirisDepo,cari_VarsayilanCikisDepo,cari_Portal_Enabled,cari_Portal_PW,cari_BagliOrtaklisa_Firma,cari_kampanyakodu,cari_b_bakiye_degerlendirilmesin_fl,cari_a_bakiye_degerlendirilmesin_fl,cari_b_irsbakiye_degerlendirilmesin_fl,cari_a_irsbakiye_degerlendirilmesin_fl,cari_b_sipbakiye_degerlendirilmesin_fl,cari_a_sipbakiye_degerlendirilmesin_fl,cari_AvmBilgileri1KiraKodu,cari_AvmBilgileri1TebligatSekli,cari_AvmBilgileri2KiraKodu,cari_AvmBilgileri2TebligatSekli,cari_AvmBilgileri3KiraKodu,cari_AvmBilgileri3TebligatSekli,cari_AvmBilgileri4KiraKodu,cari_AvmBilgileri4TebligatSekli,cari_AvmBilgileri5KiraKodu,cari_AvmBilgileri5TebligatSekli,cari_AvmBilgileri6KiraKodu,cari_AvmBilgileri6TebligatSekli,cari_AvmBilgileri7KiraKodu,cari_AvmBilgileri7TebligatSekli,cari_AvmBilgileri8KiraKodu,cari_AvmBilgileri8TebligatSekli,cari_AvmBilgileri9KiraKodu,cari_AvmBilgileri9TebligatSekli,cari_AvmBilgileri10KiraKodu,cari_AvmBilgileri10TebligatSekli,cari_KrediRiskTakibiVar_flg,cari_ufrs_fark_muh_kod,cari_ufrs_fark_muh_kod1,cari_ufrs_fark_muh_kod2,cari_odeme_sekli,cari_TeminatMekAlacakMuhKodu,cari_TeminatMekAlacakMuhKodu1,cari_TeminatMekAlacakMuhKodu2,cari_TeminatMekBorcMuhKodu,cari_TeminatMekBorcMuhKodu1,cari_TeminatMekBorcMuhKodu2,cari_VerilenDepozitoTeminatMuhKodu,cari_VerilenDepozitoTeminatMuhKodu1,cari_VerilenDepozitoTeminatMuhKodu2,cari_AlinanDepozitoTeminatMuhKodu,cari_AlinanDepozitoTeminatMuhKodu1,cari_AlinanDepozitoTeminatMuhKodu2,cari_def_efatura_cinsi,cari_otv_tevkifatina_tabii_fl ) VALUES  (0, '", cari_RECid_DBCno, "', 0, 0, 31, 0, 0, 0, 0, 1,'", cari_create_date, "', 1,'", cari_lastup_date, "', '', '', '','", cari_kod, "', '", cari_unvan1, "', '', 0, 0, 0, 0, '", cari_muh_kod1, "', '', '', 0, 1, 255, 25.0, 0, 0, 1,'", cari_vdaire_adi, "','", cari_vdaire_no, "' ,'', '', 1, 0, 0, 0, 0, 0, 1, 1, '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', 1, '', '', '', '', '', '', '', 0, 0, 0, 0, 0, 0, 0, 0, 0,'20150101', 0, 0, 0, 0, '', '', '', 0, 0, 0, '', 0, '', 0, 0, 0, 0, 0, 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, '', 0, 0, '', '', '', 0, '910', '', '', '912', '', '', '226', '', '', '326', '', '', 0, 0)    "}))
        Me.sCmd.ExecuteNonQuery()
        Me.sCmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        Return Conversions.ToLong(RuntimeHelpers.GetObjectValue(Me.sCmd.ExecuteScalar))
    End Function
    Private Function CARI_Adres_kaydet_yeni_Mikro(ByVal adr_RECid_DBCno As Integer, ByVal adr_RECid_RECno As Long, ByVal adr_SpecRECno As Long, ByVal adr_iptal As Boolean, ByVal adr_fileid As Integer, ByVal adr_hidden As Boolean, ByVal adr_kilitli As Boolean, ByVal adr_degisti As Boolean, ByVal adr_checksum As Long, ByVal adr_create_user As Integer, ByVal adr_create_date As DateTime, ByVal adr_lastup_user As Integer, ByVal adr_lastup_date As DateTime, ByVal adr_special1 As String, ByVal adr_special2 As String, ByVal adr_special3 As String, ByVal adr_cari_kod As String, ByVal adr_adres_no As Long, ByVal adr_aprint_fl As Boolean, ByVal adr_cadde As String, ByVal adr_mahalle As String, ByVal adr_sokak As String, ByVal adr_Semt As String, ByVal adr_Apt_No As String, ByVal adr_Daire_No As String, ByVal adr_posta_kodu As String, ByVal adr_ilce As String, ByVal adr_il As String, ByVal adr_ulke As String, ByVal adr_Adres_kodu As String, ByVal adr_tel_ulke_kodu As String, ByVal adr_tel_bolge_kodu As String, ByVal adr_tel_no1 As String, ByVal adr_tel_no2 As String, ByVal adr_tel_faxno As String, ByVal adr_tel_modem As String, ByVal adr_yon_kodu As String, ByVal adr_uzaklik_kodu As Integer, ByVal adr_temsilci_kodu As String, ByVal adr_ozel_not As String, ByVal adr_ziyaretperyodu As Byte, ByVal adr_ziyaretgunu As Decimal, ByVal adr_gps_enlem As Decimal, ByVal adr_gps_boylam As Decimal, ByVal adr_ziyarethaftasi As Byte, ByVal adr_ziygunu2_1 As Boolean, ByVal adr_ziygunu2_2 As Boolean, ByVal adr_ziygunu2_3 As Boolean, ByVal adr_ziygunu2_4 As Boolean, ByVal adr_ziygunu2_5 As Boolean, ByVal adr_ziygunu2_6 As Boolean, ByVal adr_ziygunu2_7 As Boolean, ByVal adr_efatura_alias As String) As Long
        Try
            If (Me.sCon.State = ConnectionState.Closed) Then
                Me.sCon.Open()
            End If
        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            Dim exception As Exception = exception1
            Me.sCon.Close()
            Me.sCon.Open()
            ProjectData.ClearProjectError()
        End Try
        Me.sCmd.CommandText = Me.sorgu_query(String.Concat(New String() {"SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED  SET DATEFORMAT DMY INSERT INTO CARI_HESAP_ADRESLERI (adr_RECid_DBCno, adr_RECid_RECno, adr_SpecRECno, adr_iptal, adr_fileid,adr_hidden, adr_kilitli, adr_degisti, adr_checksum, adr_create_user, adr_create_date, adr_lastup_user, adr_lastup_date, adr_special1,adr_special2, adr_special3, adr_cari_kod, adr_adres_no, adr_aprint_fl, adr_cadde, adr_mahalle, adr_sokak, adr_Semt, adr_Apt_No, adr_Daire_No,adr_posta_kodu, adr_ilce, adr_il, adr_ulke, adr_Adres_kodu, adr_tel_ulke_kodu, adr_tel_bolge_kodu, adr_tel_no1, adr_tel_no2, adr_tel_faxno,adr_tel_modem, adr_yon_kodu, adr_uzaklik_kodu, adr_temsilci_kodu, adr_ozel_not, adr_ziyaretperyodu, adr_ziyaretgunu, adr_gps_enlem, adr_gps_boylam,adr_ziyarethaftasi, adr_ziygunu2_1, adr_ziygunu2_2, adr_ziygunu2_3, adr_ziygunu2_4, adr_ziygunu2_5, adr_ziygunu2_6, adr_ziygunu2_7, adr_efatura_alias ) VALUES  (0,'", adr_RECid_RECno, "' ,0,0,32,0,0,0,0,1,'", adr_create_date, "',1,'", adr_lastup_date, "','','','','", adr_cari_kod, "',1,0,'", adr_cadde, "','','", adr_sokak, "','','','','','", adr_ilce, "','", adr_il, "','", adr_ulke, "','','','','','','','','','','','',0,0,0,0,0,0,0,0,0,0,0,0,'')    "}))
        'Adres_RECid = Me.CARI_Adres_kaydet_yeni_Mikro(0, Adres_RECid, 0, 0, 32, 0, 0, 0, 0, 1, Conversions.ToDate(DataRow.Item("dteFisTarihi")), 1, Conversions.ToDate(DataRow.Item("dteFisTarihi")), "''", "''", "''", DataRow.Item("sKodu").ToString, 1, 0, DataRow.Item("sAdres1").ToString, "''", DataRow.Item("sAdres2").ToString, "''", "''", "''", "''", DataRow.Item("sIl").ToString, "''", "''", "'ADRES KODU'", "'+90'", "'342'", DataRow.Item("sTelefon1").ToString, DataRow.Item("sTelefon2").ToString, DataRow.Item("sFax").ToString, "''", "''", 0, "''", "''", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "''")
        Me.sCmd.ExecuteNonQuery()
        Me.sCmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        Return Conversions.ToLong(RuntimeHelpers.GetObjectValue(Me.sCmd.ExecuteScalar))
    End Function
    Public Function sorgu_fis_kontrol_Mikro(ByVal sFistipi As String, ByVal nGirisCikis As String, ByVal dteFisTarihi As DateTime, ByVal lFisno As String, ByVal nFirmaID As String, Optional ByVal resmi As Boolean = True, Optional ByVal sDatabase As String = "") As Long
        Dim str As String = ""
        If (sDatabase <> "") Then
            str = ("USE " & sDatabase)
        End If
        Dim obj3 As Object = String.Concat(New String() {"WHERE (sFisTipi = '", sFistipi, "') and (dteFisTarihi = '", Conversions.ToString(dteFisTarihi), "') and (lFisNo = '", lFisno, "') and (nFirmaID= '", nFirmaID, "') and (nGirisCikis = '", nGirisCikis, "')  "})
        Try
            If (Me.sCon.State = ConnectionState.Closed) Then
                Me.sCon.Open()
            End If
        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            Dim exception As Exception = exception1
            Me.sCon.Close()
            Me.sCon.Open()
            ProjectData.ClearProjectError()
        End Try
        'Me.sCmd.CommandText = Me.sorgu_query(String.Concat(New String() {"", str, " SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Select COUNT(SIRANO) from FATURA WHERE CARIREF = ", nFirmaID, " AND EVRAKTAR = '", Conversions.ToString(dteFisTarihi), "' AND EVRAKNO = '", lFisno, "' AND TUR = ", sFistipi, " AND AORS = '", nGirisCikis, "'"}))
        'Me.sCmd.CommandText = Me.sorgu_query(String.Concat(New String() {"SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Select COUNT(sth_RECno) from STOK_HAREKETLERI WHERE sth_SpecRECno = ", nFirmaID, "  AND sth_belge_tarih = '", Conversions.ToString(dteFisTarihi), "' AND sth_belge_no = '", lFisno, "' AND sth_evraktip = ", sFistipi, " AND sth_tip = '", nGirisCikis, "'"}))
        Me.sCmd.CommandText = Me.sorgu_query(String.Concat(New String() {"SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Select COUNT(sth_RECno) from STOK_HAREKETLERI WHERE sth_SpecRECno = ", nFirmaID, "   AND sth_belge_no = '", lFisno, "' "}))

        Return Conversions.ToLong(RuntimeHelpers.GetObjectValue(Me.sCmd.ExecuteScalar))
    End Function
    Private Function FATURA_kaydet_yeni_Mikro(ByVal sth_RECid_DBCno As Integer, ByVal sth_RECid_RECno As Long, ByVal sth_SpecRECno As Long, ByVal sth_iptal As Boolean, ByVal sth_fileid As Integer, ByVal sth_hidden As Boolean, ByVal sth_kilitli As Boolean, ByVal sth_degisti As Boolean, ByVal sth_checksum As Boolean, ByVal sth_create_user As Integer, ByVal sth_create_date As DateTime, ByVal sth_lastup_user As Integer, ByVal sth_lastup_date As DateTime, ByVal sth_special1 As String, ByVal sth_special2 As String, ByVal sth_special3 As String, ByVal sth_firmano As Long, ByVal sth_subeno As Long, ByVal sth_tarih As DateTime, ByVal sth_tip As Byte, ByVal sth_cins As Byte, ByVal sth_normal_iade As Byte, ByVal sth_evraktip As Byte, ByVal sth_evrakno_seri As String, ByVal sth_evrakno_sira As Long, ByVal sth_satirno As Long, ByVal sth_belge_no As String, ByVal sth_belge_tarih As DateTime, ByVal sth_stok_kod As String, ByVal sth_isk_mas1 As Byte, ByVal sth_isk_mas2 As Byte, ByVal sth_isk_mas3 As Byte, ByVal sth_isk_mas4 As Byte, ByVal sth_isk_mas5 As Byte, ByVal sth_isk_mas6 As Byte, ByVal sth_isk_mas7 As Byte, ByVal sth_isk_mas8 As Byte, ByVal sth_isk_mas9 As Byte, ByVal sth_isk_mas10 As Byte, ByVal sth_sat_iskmas1 As Boolean, ByVal sth_sat_iskmas2 As Boolean, ByVal sth_sat_iskmas3 As Boolean, ByVal sth_sat_iskmas4 As Boolean, ByVal sth_sat_iskmas5 As Boolean, ByVal sth_sat_iskmas6 As Boolean, ByVal sth_sat_iskmas7 As Boolean, ByVal sth_sat_iskmas8 As Boolean, ByVal sth_sat_iskmas9 As Boolean, ByVal sth_sat_iskmas10 As Boolean, ByVal sth_pos_satis As Boolean, ByVal sth_promosyon_fl As Boolean, ByVal sth_cari_cinsi As Byte, ByVal sth_cari_kodu As String, ByVal sth_cari_grup_no As Byte, ByVal sth_isemri_gider_kodu As String, ByVal sth_plasiyer_kodu As String, ByVal sth_har_doviz_cinsi As Byte, ByVal sth_har_doviz_kuru As Decimal, ByVal sth_alt_doviz_kuru As Decimal, ByVal sth_stok_doviz_cinsi As Byte, ByVal sth_stok_doviz_kuru As Decimal, ByVal sth_miktar As Decimal, ByVal sth_miktar2 As Decimal, ByVal sth_birim_pntr As Byte, ByVal sth_tutar As Decimal, ByVal sth_iskonto1 As Decimal, ByVal sth_iskonto2 As Decimal, ByVal sth_iskonto3 As Decimal, ByVal sth_iskonto4 As Decimal, ByVal sth_iskonto5 As Decimal, ByVal sth_iskonto6 As Decimal, ByVal sth_masraf1 As Decimal, ByVal sth_masraf2 As Decimal, ByVal sth_masraf3 As Decimal, ByVal sth_masraf4 As Decimal, ByVal sth_vergi_pntr As Byte, ByVal sth_vergi As Decimal, ByVal sth_masraf_vergi_pntr As Byte, ByVal sth_masraf_vergi As Decimal, ByVal sth_netagirlik As Decimal, ByVal sth_odeme_op As Long, ByVal sth_aciklama As String, ByVal sth_sip_recid_dbcno As Integer, ByVal sth_sip_recid_recno As Long, ByVal sth_fat_recid_dbcno As Integer, ByVal sth_fat_recid_recno As Long, ByVal sth_giris_depo_no As Long, ByVal sth_cikis_depo_no As Long, ByVal sth_malkbl_sevk_tarihi As DateTime, ByVal sth_cari_srm_merkezi As String, ByVal sth_stok_srm_merkezi As String, ByVal sth_fis_tarihi As DateTime, ByVal sth_fis_sirano As Long, ByVal sth_vergisiz_fl As Boolean, ByVal sth_maliyet_ana As Decimal, ByVal sth_maliyet_alternatif As Decimal, ByVal sth_maliyet_orjinal As Decimal, ByVal sth_adres_no As Long, ByVal sth_parti_kodu As String, ByVal sth_lot_no As Long, ByVal sth_kons_recid_dbcno As Integer, ByVal sth_kons_recid_recno As Long, ByVal sth_proje_kodu As String, ByVal sth_exim_kodu As String, ByVal sth_otv_pntr As Byte, ByVal sth_otv_vergi As Decimal, ByVal sth_brutagirlik As Decimal, ByVal sth_disticaret_turu As Byte, ByVal sth_otvtutari As Decimal, ByVal sth_otvvergisiz_fl As Boolean, ByVal sth_oiv_pntr As Byte, ByVal sth_oiv_vergi As Decimal, ByVal sth_oivvergisiz_fl As Boolean, ByVal sth_fiyat_liste_no As Long, ByVal sth_oivtutari As Decimal, ByVal sth_Tevkifat_turu As Byte, ByVal sth_nakliyedeposu As Long, ByVal sth_nakliyedurumu As Byte, ByVal sth_yetkili_recid_dbcno As Integer, ByVal sth_yetkili_recid_recno As Long, ByVal sth_taxfree_fl As Boolean, ByVal sth_ilave_edilecek_kdv As Decimal) As Long
        Try
            If (Me.sCon.State = ConnectionState.Closed) Then
                Me.sCon.Open()
            End If
        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            Dim exception As Exception = exception1
            Me.sCon.Close()
            Me.sCon.Open()
            ProjectData.ClearProjectError()
        End Try
        'Me.sCmd.CommandText = Me.sorgu_query(String.Concat(New String() {"SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED  INSERT INTO FATURA ( SUBE, EVRAKTAR, TUR, AORS, ISLEMTIPI, EVRAKNO, OZELKOD1, OZELKOD2, DOVIZC, IPTAL, KAPORAC, KULLANICI, KDVDH, TURAC, CARIADI, DEPOREF, CARIREF, KASAKODU, VADETARIHI, YIORYD, MASRAFMERKEZI, CRK, GENELTOPLAM, GENELTOPLAMD, TOPLAMKDV, TOPLAMKDVD, DEKONTVAR, CARIKULLAN,  SEVKVAR, IRSBAGLI, SIPBAGLI, P_ID, yaziylaTL, CARIDVZCINSI,CARIDVZTUTAR, CARIDVZUGDK, IRSNO, IRSEKLE, TOPLAMNINDTL, DZP_ID, CARIP_ID, INT_1, IHRAKIYE, ITHR, SAAT, EFATURA) VALUES     ( ", Conversions.ToString(CInt(SUBE)), ", '", Conversions.ToString(EVRAKTAR), "', ", Conversions.ToString(TUR), ", '", AORS, "', ", Conversions.ToString(ISLEMTIPI), ", '", EVRAKNO, "', '", OZELKOD1, "', '", OZELKOD2, "', ", Conversions.ToString(DOVIZC), ", ", Conversions.ToString(IPTAL), ", ", Conversions.ToString(KAPORAC), ", '", KULLANICI, "', ", Conversions.ToString(KDVDH), ", '", TURAC, "', '", CARIADI, "', ", Conversions.ToString(DEPOREF), ", ", Conversions.ToString(CARIREF), ", ", KASAKODU, ", '", Conversions.ToString(VADETARIHI), "', ", Conversions.ToString(YIORYD), ", '", MASRAFMERKEZI, "', '", CRK, "', ", Conversions.ToString(GENELTOPLAM), ", ", Conversions.ToString(GENELTOPLAMD), ", ", Conversions.ToString(TOPLAMKDV), ", ", Conversions.ToString(TOPLAMKDVD), ", ", Conversions.ToString(DEKONTVAR), ", ", Conversions.ToString(CARIKULLAN), ", ", Conversions.ToString(SEVKVAR), ", '", IRSBAGLI, "', '", SIPBAGLI, "', '", P_ID, "', '", yaziylaTL, "', 1,", Conversions.ToString(CARIDVZTUTAR), ", ", Conversions.ToString(CARIDVZUGDK), ", '", IRSNO, "', '", Conversions.ToString(IRSEKLE), "', ", Conversions.ToString(TOPLAMNINDTL), ", NULL, '", CARIP_ID, "', ", Conversions.ToString(INT_1), ", ", Conversions.ToString(IHRAKIYE), ", ", Conversions.ToString(ITHR), ", '", Conversions.ToString(SAAT), "', '", EFATURA, "')"}))
        'Me.sCmd.CommandText = Me.sorgu_query(String.Concat(New String() {"SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED  INSERT INTO STOK_HAREKETLERI(sth_RECid_DBCno,sth_RECid_RECno,sth_SpecRECno,sth_iptal,sth_fileid,sth_hidden,sth_kilitli,sth_degisti,sth_checksum,sth_create_user,sth_create_date,sth_lastup_user,sth_lastup_date,sth_special1,sth_special2,sth_special3,sth_firmano,sth_subeno,sth_tarih,sth_tip,sth_cins,sth_normal_iade,sth_evraktip,sth_evrakno_seri,sth_evrakno_sira,sth_satirno,sth_belge_no,sth_belge_tarih,sth_stok_kod,sth_isk_mas1,sth_isk_mas2,sth_isk_mas3,sth_isk_mas4,sth_isk_mas5,sth_isk_mas6,sth_isk_mas7,sth_isk_mas8,sth_isk_mas9,sth_isk_mas10,sth_sat_iskmas1,sth_sat_iskmas2,sth_sat_iskmas3,sth_sat_iskmas4,sth_sat_iskmas5,sth_sat_iskmas6,sth_sat_iskmas7,sth_sat_iskmas8,sth_sat_iskmas9,sth_sat_iskmas10,sth_pos_satis,sth_promosyon_fl,sth_cari_cinsi,sth_cari_kodu,sth_cari_grup_no,sth_isemri_gider_kodu,sth_plasiyer_kodu,sth_har_doviz_cinsi,sth_har_doviz_kuru,sth_alt_doviz_kuru,sth_stok_doviz_cinsi,sth_stok_doviz_kuru,sth_miktar,sth_miktar2,sth_birim_pntr,sth_tutar,sth_iskonto1,sth_iskonto2,sth_iskonto3,sth_iskonto4,sth_iskonto5,sth_iskonto6,sth_masraf1,sth_masraf2,sth_masraf3,sth_masraf4,sth_vergi_pntr,sth_vergi,sth_masraf_vergi_pntr,sth_masraf_vergi,sth_netagirlik,sth_odeme_op,sth_aciklama,sth_sip_recid_dbcno,sth_sip_recid_recno,sth_fat_recid_dbcno,sth_fat_recid_recno,sth_giris_depo_no,sth_cikis_depo_no,sth_malkbl_sevk_tarihi,sth_cari_srm_merkezi,sth_stok_srm_merkezi,sth_fis_tarihi,sth_fis_sirano,sth_vergisiz_fl,sth_maliyet_ana,sth_maliyet_alternatif,sth_maliyet_orjinal,sth_adres_no,sth_parti_kodu,sth_lot_no,sth_kons_recid_dbcno,sth_kons_recid_recno,sth_proje_kodu,sth_exim_kodu,sth_otv_pntr,sth_otv_vergi,sth_brutagirlik,sth_disticaret_turu,sth_otvtutari,sth_otvvergisiz_fl,sth_oiv_pntr,sth_oiv_vergi,sth_oivvergisiz_fl,sth_fiyat_liste_no,sth_oivtutari,sth_Tevkifat_turu,sth_nakliyedeposu,sth_nakliyedurumu,sth_yetkili_recid_dbcno,sth_yetkili_recid_recno,sth_taxfree_fl,sth_ilave_edilecek_kdv) VALUES (0,'", sth_RECid_RECno, "',0,0,0,16,0,0,0,0,1,'", sth_create_date, "',1,'", sth_lastup_date, "','','','',0,0,'", sth_tarih, "',1,0,0,1,'", sth_evrakno_seri, "',1,0,'", sth_belge_no, "','", sth_belge_tarih, "','", sth_stok_kod, "',0,1,1,1,1,1,1,1,1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,'", sth_cari_kodu, "',0,'','',0,1.000000000000,1.000000000000,0,1.000000000000,'", sth_miktar, "','", sth_miktar2, "',1,'", sth_tutar, "','", sth_iskonto1, "',0,0,0,0,0,0,0,0,0,4,'", sth_vergi, "',0,0,0,0,'',0,0,0,0,0,1,'", sth_malkbl_sevk_tarihi, "','','','", sth_fis_tarihi, "',0,0,0,0,0,1,'',0,0,0,'','',0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0)"}))
        Me.sCmd.CommandText = Me.sorgu_query(String.Concat(New String() {"SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED  INSERT INTO STOK_HAREKETLERI (sth_RECid_DBCno,sth_RECid_RECno,sth_SpecRECno,sth_iptal,sth_fileid,sth_hidden,sth_kilitli,sth_degisti,sth_checksum,sth_create_user,sth_create_date,sth_lastup_user,sth_lastup_date,sth_special1,sth_special2,sth_special3,sth_firmano,sth_subeno,sth_tarih,sth_tip,sth_cins,sth_normal_iade,sth_evraktip,sth_evrakno_seri,sth_evrakno_sira,sth_satirno,sth_belge_no,sth_belge_tarih,sth_stok_kod,sth_isk_mas1,sth_isk_mas2,sth_isk_mas3,sth_isk_mas4,sth_isk_mas5,sth_isk_mas6,sth_isk_mas7,sth_isk_mas8,sth_isk_mas9,sth_isk_mas10,sth_sat_iskmas1,sth_sat_iskmas2,sth_sat_iskmas3,sth_sat_iskmas4,sth_sat_iskmas5,sth_sat_iskmas6,sth_sat_iskmas7,sth_sat_iskmas8,sth_sat_iskmas9,sth_sat_iskmas10,sth_pos_satis,sth_promosyon_fl,sth_cari_cinsi,sth_cari_kodu,sth_cari_grup_no,sth_isemri_gider_kodu,sth_plasiyer_kodu,sth_har_doviz_cinsi,sth_har_doviz_kuru,sth_alt_doviz_kuru,sth_stok_doviz_cinsi,sth_stok_doviz_kuru,sth_miktar,sth_miktar2,sth_birim_pntr,sth_tutar,sth_iskonto1,sth_iskonto2,sth_iskonto3,sth_iskonto4,sth_iskonto5,sth_iskonto6,sth_masraf1,sth_masraf2,sth_masraf3,sth_masraf4,sth_vergi_pntr,sth_vergi,sth_masraf_vergi_pntr,sth_masraf_vergi,sth_netagirlik,sth_odeme_op,sth_aciklama,sth_sip_recid_dbcno,sth_sip_recid_recno,sth_fat_recid_dbcno,sth_fat_recid_recno,sth_giris_depo_no,sth_cikis_depo_no,sth_malkbl_sevk_tarihi,sth_cari_srm_merkezi,sth_stok_srm_merkezi,sth_fis_tarihi,sth_fis_sirano,sth_vergisiz_fl,sth_maliyet_ana,sth_maliyet_alternatif,sth_maliyet_orjinal,sth_adres_no,sth_parti_kodu,sth_lot_no,sth_kons_recid_dbcno,sth_kons_recid_recno,sth_proje_kodu,sth_exim_kodu,sth_otv_pntr,sth_otv_vergi,sth_brutagirlik,sth_disticaret_turu,sth_otvtutari,sth_otvvergisiz_fl,sth_oiv_pntr,sth_oiv_vergi,sth_oivvergisiz_fl,sth_fiyat_liste_no,sth_oivtutari,sth_Tevkifat_turu,sth_nakliyedeposu,sth_nakliyedurumu,sth_yetkili_recid_dbcno,sth_yetkili_recid_recno,sth_taxfree_fl,sth_ilave_edilecek_kdv) VALUES (0,'", sth_RECid_DBCno, "','", sth_RECid_RECno, "',0,16,0,0,0,0,1,'", sth_create_date, "',1,'", sth_lastup_date, "','','','',0,0,'", sth_tarih, "','", sth_tip, "',0,'", sth_normal_iade, "','", sth_evraktip, "','", sth_evrakno_seri, "','", sth_evrakno_sira, "',0,'", sth_belge_no, "','", sth_belge_tarih, "','", sth_stok_kod, "',0,1,1,1,1,1,1,1,1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,'", sth_cari_kodu, "',0,'','',0,1.000000000000,1.000000000000,0,1.000000000000,'", sth_miktar, "','", sth_miktar2, "',1,'", sth_tutar, "','", sth_iskonto1, "',0,0,0,0,0,0,0,0,0,4,'", sth_vergi, "',0,0,0,0,'',0,0,0,0,0,1,'", sth_malkbl_sevk_tarihi, "','','','", sth_fis_tarihi, "',0,0,0,0,0,1,'',0,0,0,'','',0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0)"}))
        Me.sCmd.ExecuteNonQuery()
        Me.sCmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        Return Conversions.ToLong(RuntimeHelpers.GetObjectValue(Me.sCmd.ExecuteScalar))
    End Function
    Private Function STOK_kaydet_yeni_Mikro(ByVal sto_RECno As Long, ByVal sto_RECid_DBCno As Integer, ByVal sto_RECid_RECno As Long, ByVal sto_SpecRECno As Long, ByVal sto_iptal As Boolean, ByVal sto_fileid As Long, ByVal sto_hidden As Boolean, ByVal sto_kilitli As Boolean, ByVal sto_degisti As Boolean, ByVal sto_checksum As Long, ByVal sto_create_user As Decimal, ByVal sto_create_date As DateTime, ByVal sto_lastup_user As Integer, ByVal sto_lastup_date As DateTime, ByVal sto_special1 As Integer, ByVal sto_special2 As Integer, ByVal sto_special3 As Integer, ByVal sto_kod As String, ByVal sto_isim As String, ByVal sto_kisa_ismi As String, ByVal sto_yabanci_isim As String, ByVal sto_sat_cari_kod As String, ByVal sto_cins As Byte, ByVal sto_doviz_cinsi As Byte, ByVal sto_detay_takip As Byte, ByVal sto_birim1_ad As String, ByVal sto_birim1_katsayi As Decimal, ByVal sto_birim1_agirlik As Decimal, ByVal sto_birim1_en As Decimal, ByVal sto_birim1_boy As Decimal, ByVal sto_birim1_yukseklik As Decimal, ByVal sto_birim1_dara As Decimal, ByVal sto_birim2_ad As String, ByVal sto_birim2_katsayi As Decimal, ByVal sto_birim2_agirlik As Decimal, ByVal sto_birim2_en As Decimal, ByVal sto_birim2_boy As Decimal, ByVal sto_birim2_yukseklik As Decimal, ByVal sto_birim2_dara As Decimal, ByVal sto_birim3_ad As String, ByVal sto_birim3_katsayi As Decimal, ByVal sto_birim3_agirlik As Decimal, ByVal sto_birim3_en As Decimal, ByVal sto_birim3_boy As Decimal, ByVal sto_birim3_yukseklik As Decimal, ByVal sto_birim3_dara As Decimal, ByVal sto_birim4_ad As String, ByVal sto_birim4_katsayi As Decimal, ByVal sto_birim4_agirlik As Decimal, ByVal sto_birim4_en As Decimal, ByVal sto_birim4_boy As Decimal, ByVal sto_birim4_yukseklik As Decimal, ByVal sto_birim4_dara As Decimal, ByVal sto_muh_kod As String, ByVal sto_muh_Iade_kod As String, ByVal sto_muh_sat_muh_kod As String, ByVal sto_muh_satIadmuhkod As String, ByVal sto_muh_sat_isk_kod As String, ByVal sto_muh_aIiskmuhkod As String, ByVal sto_muh_satmalmuhkod As String, ByVal sto_yurtdisi_satmuhk As String, ByVal sto_ilavemasmuhkod As String, ByVal sto_yatirimtesmuhkod As String, ByVal sto_depsatmuhkod As String, ByVal sto_depsatmalmuhkod As String, ByVal sto_bagortsatmuhkod As String, ByVal sto_bagortsatIadmuhkod As String, ByVal sto_bagortsatIskmuhkod As String, ByVal sto_satfiyfarkmuhkod As String, ByVal sto_yurtdisisatmalmuhkod As String, ByVal sto_bagortsatmalmuhkod As String, ByVal sto_sifirbedsatmalmuhkod As String, ByVal sto_karorani As Decimal, ByVal sto_min_stok As Decimal, ByVal sto_siparis_stok As Decimal, ByVal sto_max_stok As Decimal, ByVal sto_ver_sip_birim As Byte, ByVal sto_al_sip_birim As Byte, ByVal sto_siparis_sure As Integer, ByVal sto_perakende_vergi As Byte, ByVal sto_toptan_vergi As Byte, ByVal sto_yer_kod As String, ByVal sto_elk_etk_tipi As Byte, ByVal sto_raf_etiketli As Byte, ByVal sto_etiket_bas As Byte, ByVal sto_satis_dursun As Byte, ByVal sto_siparis_dursun As Byte, ByVal sto_malkabul_dursun As Byte, ByVal sto_malkabul_gun1 As Boolean, ByVal sto_malkabul_gun2 As Boolean, ByVal sto_malkabul_gun3 As Boolean, ByVal sto_malkabul_gun4 As Boolean, ByVal sto_malkabul_gun5 As Boolean, ByVal sto_malkabul_gun6 As Boolean, ByVal sto_malkabul_gun7 As Boolean, ByVal sto_siparis_gun1 As Boolean, ByVal sto_siparis_gun2 As Boolean, ByVal sto_siparis_gun3 As Boolean, ByVal sto_siparis_gun4 As Boolean, ByVal sto_siparis_gun5 As Boolean, ByVal sto_siparis_gun6 As Boolean, ByVal sto_siparis_gun7 As Boolean, ByVal sto_iskon_yapilamaz As Boolean, ByVal sto_tasfiyede As Boolean, ByVal sto_alt_grup_no As Integer, ByVal sto_kategori_kodu As String, ByVal sto_urun_sorkod As String, ByVal sto_altgrup_kod As String, ByVal sto_anagrup_kod As String, ByVal sto_uretici_kodu As String, ByVal sto_sektor_kodu As String, ByVal sto_reyon_kodu As String, ByVal sto_muhgrup_kodu As Char, ByVal sto_ambalaj_kodu As String, ByVal sto_marka_kodu As String, ByVal sto_beden_kodu As String, ByVal sto_renk_kodu As String, ByVal sto_model_kodu As String, ByVal sto_sezon_kodu As String, ByVal sto_hammadde_kodu As String, ByVal sto_prim_kodu As String, ByVal sto_kalkon_kodu As String, ByVal sto_paket_kodu As String, ByVal sto_pozisyonbayrak_kodu As String, ByVal sto_mkod_artik As String, ByVal sto_kasa_tarti_fl As Boolean, ByVal sto_bedenli_takip As Boolean, ByVal sto_renkDetayli As Boolean, ByVal sto_miktarondalikli_fl As Boolean, ByVal sto_pasif_fl As Boolean, ByVal sto_eksiyedusebilir_fl As Boolean, ByVal sto_GtipNo As String, ByVal sto_puan As Decimal, ByVal sto_komisyon_hzmkodu As String, ByVal sto_komisyon_orani As Boolean, ByVal sto_otvuygulama As Byte, ByVal sto_otvtutar As Decimal, ByVal sto_otvliste As Byte, ByVal sto_otvbirimi As Byte, ByVal sto_prim_orani As Decimal, ByVal sto_garanti_sure As Integer, ByVal sto_garanti_sure_tipi As Byte, ByVal sto_iplik_Ne_no As Decimal, ByVal sto_standartmaliyet As Decimal, ByVal sto_kanban_kasa_miktari As Decimal, ByVal sto_oivuygulama As Byte, ByVal sto_zraporu_stoku_fl As Boolean, ByVal sto_maxiskonto_orani As Decimal, ByVal sto_detay_takibinde_depo_kontrolu_fl As Boolean, ByVal sto_tamamlayici_kodu As String, ByVal sto_oto_barkod_acma_sekli As Byte, ByVal sto_oto_barkod_kod_yapisi As String, ByVal sto_KasaIskontoOrani As Decimal, ByVal sto_KasaIskontoTutari As Decimal, ByVal sto_gelirpayi As Decimal, ByVal sto_oivtutar As Decimal, ByVal sto_oivturu As Byte, ByVal sto_giderkodu As String, ByVal sto_oivvergipntr As Byte, ByVal sto_Tevkifat_turu As Byte, ByVal sto_SKT_fl As Boolean, ByVal sto_terazi_SKT As Integer, ByVal sto_RafOmru As Integer, ByVal sto_KasadaTaksitlenebilir_fl As Boolean, ByVal sto_ufrsfark_kod As String, ByVal sto_iade_ufrsfark_kod As String, ByVal sto_yurticisat_ufrsfark_kod As String, ByVal sto_satiade_ufrsfark_kod As String, ByVal sto_satisk_ufrsfark_kod As String, ByVal sto_alisk_ufrsfark_kod As String, ByVal sto_satmal_ufrsfark_kod As String, ByVal sto_yurtdisisat_ufrsfark_kod As String, ByVal sto_ilavemas_ufrsfark_kod As String, ByVal sto_yatirimtes_ufrsfark_kod As String, ByVal sto_depsat_ufrsfark_kod As String, ByVal sto_depsatmal_ufrsfark_kod As String, ByVal sto_bagortsat_ufrsfark_kod As String, ByVal sto_bagortsatiade_ufrsfark_kod As String, ByVal sto_bagortsatisk_ufrsfark_kod As String, ByVal sto_satfiyfark_ufrsfark_kod As String, ByVal sto_yurtdisisatmal_ufrsfark_kod As String, ByVal sto_bagortsatmal_ufrsfark_kod As String, ByVal sto_sifirbedsatmal_ufrsfark_kod As String, ByVal sto_uretimmaliyet_ufrsfark_kod As String, ByVal sto_uretimkapasite_ufrsfark_kod As String, ByVal sto_degerdusuklugu_ufrs_kod As String, ByVal sto_halrusumyudesi As Decimal, ByVal sto_webe_gonderilecek_fl As Boolean, ByVal sto_min_stok_belirleme_gun As Integer, ByVal sto_max_stok_belirleme_gun As Integer, ByVal sto_sev_bel_opr_degerlendime_fl As Boolean, ByVal sto_otv_tevkifat_turu As Byte) As Long
        Try
            If (Me.sCon.State = ConnectionState.Closed) Then
                Me.sCon.Open()
            End If
        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            Dim exception As Exception = exception1
            Me.sCon.Close()
            Me.sCon.Open()
            ProjectData.ClearProjectError()
        End Try
        'Me.sCmd.CommandText = Me.sorgu_query(String.Concat(New String() {"SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED  INSERT INTO STOKGEN ( MASTERREF, DETAY, SUBE, STK, STA, STB, STGM, STGT, STCM, STCT, KAR, BARKOD, TEMINS, ASSTOK, AZSTOK, TURU, DOVIZC, SAT1_1, SAT1_2, SAT1_3, SAT1_4, SAT1_5, SAT1_6, SAT1_7, SAT1_8, SAT1_9, SAT1_10, SAT1_1D, SAT1_2D, SAT1_3D, SAT1_4D, SAT1_5D, SAT1_6D, SAT1_7D, SAT1_8D, SAT1_9D, SAT1_10D,INDY, HSF, TVS, KS, TAS, BS, DEV, KM, EK, OTV, ANABROR2, ANABROR3, STOKKILIDI, ALIS1_1, ALIS1_2, ALIS1_3, ALIS1_4, ALIS1_5, ALIS1_1D, ALIS1_2D, ALIS1_3D, ALIS1_4D, ALIS1_5D, FIELD11, FIELD12, FIELD13, FIELD14, FIELD15, FIELD17, BIRIM1NETA, BIRIM1GROSA, BIRIM2NETA, BIRIM2GROSA, BIRIM3NETA, BIRIM3GROSA, RENK, BEDEN, ACIKLAMA, ASGM, ASCM, PSGM, PSCM, TUR, KSGM, KSCM, BZGM, BZCM, ARGM, ARCM, URGM, URCM, SPGM, SPCM, URETIMMIKTARI, OPREF, BBMIKTAR, URETIMDVZCINS, URETIMBRFIYATTL, URETIMBRFIYATDVZ, URGT, URCT, KSGT, KSCT, BZGT, BZCT, ARGT, ARCT, SIPGT, SIPCT, KDV, BAKMIKTAR, INT_1, INT_2, INT_3, INT_4, INT_5, STOKURET, STOKURET2, P_ID, FANTOM, GRUPNO, ANAGRUP, KULLANICI, GORUNSUN, SERINOKULLAN, CBBOLEN, BR2ISLEM, BR3ISLEM, EBATSONUCU) VALUES     (", Conversions.ToString(MASTERREF), " , '", DETAY, "' , ", Conversions.ToString(SUBE), " , '", STK, "' , '", STA, "' , '", STB, "' , ", Conversions.ToString(STGM), " , ", Conversions.ToString(STGT), " , ", Conversions.ToString(STCM), " , ", Conversions.ToString(STCT), " , ", Conversions.ToString(KAR), " , '", BARKOD, "' , ", Conversions.ToString(TEMINS), " , ", Conversions.ToString(ASSTOK), " , ", Conversions.ToString(AZSTOK), " , ", Conversions.ToString(TURU), " , ", Conversions.ToString(DOVIZC), " , ", Conversions.ToString(SAT1_1), " , ", Conversions.ToString(SAT1_2), " , ", Conversions.ToString(SAT1_3), " , ", Conversions.ToString(SAT1_4), " , ", Conversions.ToString(SAT1_5), " , ", Conversions.ToString(SAT1_6), " , ", Conversions.ToString(SAT1_7), " , ", Conversions.ToString(SAT1_8), " , ", Conversions.ToString(SAT1_9), " , ", Conversions.ToString(SAT1_10), " , ", Conversions.ToString(SAT1_1D), " , ", Conversions.ToString(SAT1_2D), " , ", Conversions.ToString(SAT1_3D), " , ", Conversions.ToString(SAT1_4D), " , ", Conversions.ToString(SAT1_5D), " , ", Conversions.ToString(SAT1_6D), " , ", Conversions.ToString(SAT1_7D), " , ", Conversions.ToString(SAT1_8D), " , ", Conversions.ToString(SAT1_9D), " , ", Conversions.ToString(SAT1_10D), " , ", Conversions.ToString(INDY), " , ", Conversions.ToString(HSF), " , ", Conversions.ToString(TVS), " , ", Conversions.ToString(KS), " , ", Conversions.ToString(TAS), " , ", Conversions.ToString(BS), " , ", Conversions.ToString(DEV), " , ", Conversions.ToString(KM), " , ", Conversions.ToString(EK), " , ", Conversions.ToString(OTV), " , ", Conversions.ToString(ANABROR2), " , ", Conversions.ToString(ANABROR3), " , ", Conversions.ToString(STOKKILIDI), " , ", Conversions.ToString(ALIS1_1), " , ", Conversions.ToString(ALIS1_2), " , ", Conversions.ToString(ALIS1_3), " , ", Conversions.ToString(ALIS1_4), " , ", Conversions.ToString(ALIS1_5), " , ", Conversions.ToString(ALIS1_1D), " , ", Conversions.ToString(ALIS1_2D), " , ", Conversions.ToString(ALIS1_3D), " , ", Conversions.ToString(ALIS1_4D), " , ", Conversions.ToString(ALIS1_5D), " , ", Conversions.ToString(FIELD11), " , ", Conversions.ToString(FIELD12), " , ", Conversions.ToString(FIELD13), " , ", Conversions.ToString(FIELD14), " , ", Conversions.ToString(FIELD15), " , ", Conversions.ToString(FIELD17), " , ", Conversions.ToString(BIRIM1NETA), " , ", Conversions.ToString(BIRIM1GROSA), " , ", Conversions.ToString(BIRIM2NETA), " , ", Conversions.ToString(BIRIM2GROSA), " , ", Conversions.ToString(BIRIM3NETA), " , ", Conversions.ToString(BIRIM3GROSA), " , '", RENK, "' , '", BEDEN, "' , '", ACIKLAMA, "' , ", Conversions.ToString(ASGM), " , ", Conversions.ToString(ASCM), " , ", Conversions.ToString(PSGM), " , ", Conversions.ToString(PSCM), " , ", Conversions.ToString(TUR), " , ", Conversions.ToString(KSGM), " , ", Conversions.ToString(KSCM), " , ", Conversions.ToString(BZGM), " , ", Conversions.ToString(BZCM), " , ", Conversions.ToString(ARGM), " , ", Conversions.ToString(ARCM), " , ", Conversions.ToString(URGM), " , ", Conversions.ToString(URCM), " , ", Conversions.ToString(SPGM), " , ", Conversions.ToString(SPCM), " , ", Conversions.ToString(URETIMMIKTARI), " , ", Conversions.ToString(OPREF), " , ", Conversions.ToString(BBMIKTAR), " , ", Conversions.ToString(URETIMDVZCINS), " , ", Conversions.ToString(URETIMBRFIYATTL), " , ", Conversions.ToString(URETIMBRFIYATDVZ), " , ", Conversions.ToString(URGT), " , ", Conversions.ToString(URCT), " , ", Conversions.ToString(KSGT), " , ", Conversions.ToString(KSCT), " , ", Conversions.ToString(BZGT), " , ", Conversions.ToString(BZCT), " , ", Conversions.ToString(ARGT), " , ", Conversions.ToString(ARCT), " , ", Conversions.ToString(SIPGT), " , ", Conversions.ToString(SIPCT), " , ", Conversions.ToString(KDV), " , ", Conversions.ToString(BAKMIKTAR), " , ", Conversions.ToString(INT_1), " , ", Conversions.ToString(INT_2), " , ", Conversions.ToString(INT_3), " , ", Conversions.ToString(INT_4), " , ", Conversions.ToString(INT_5), " , ", Conversions.ToString(STOKURET), " , ", Conversions.ToString(STOKURET2), " , '", P_ID, "' , ", Conversions.ToString(FANTOM), " , '", GRUPNO, "' , '", ANAGRUP, "' , '", kullanici, "' , '", GORUNSUN, "' , ", Conversions.ToString(SERINOKULLAN), " , ", Conversions.ToString(CBBOLEN), " , '", BR2ISLEM, "' , '", BR3ISLEM, "' , ", Conversions.ToString(EBATSONUCU), ")"}))
        'Me.sCmd.CommandText = Me.sorgu_query(String.Concat(New String() {"SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED  INSERT INTO STOKLAR (sto_RECno,sto_RECid_DBCno,sto_RECid_RECno,sto_SpecRECno,sto_iptal,sto_fileid,sto_hidden,sto_kilitli,sto_degisti,sto_checksum,sto_create_user,sto_create_date,sto_lastup_user,sto_lastup_date,sto_special1,sto_special2,sto_special3,sto_kod,sto_isim,sto_kisa_ismi,sto_yabanci_isim,sto_sat_cari_kod,sto_cins,sto_doviz_cinsi,sto_detay_takip,sto_birim1_ad,sto_birim1_katsayi,sto_birim1_agirlik,sto_birim1_en,sto_birim1_boy,sto_birim1_yukseklik,sto_birim1_dara,sto_birim2_ad,sto_birim2_katsayi,sto_birim2_agirlik,sto_birim2_en,sto_birim2_boy,sto_birim2_yukseklik,sto_birim2_dara,sto_birim3_ad,sto_birim3_katsayi,sto_birim3_agirlik,sto_birim3_en,sto_birim3_boy,sto_birim3_yukseklik,sto_birim3_dara,sto_birim4_ad,sto_birim4_katsayi,sto_birim4_agirlik,sto_birim4_en,sto_birim4_boy,sto_birim4_yukseklik,sto_birim4_dara,sto_muh_kod,sto_muh_Iade_kod,sto_muh_sat_muh_kod,sto_muh_satIadmuhkod,sto_muh_sat_isk_kod,sto_muh_aIiskmuhkod,sto_muh_satmalmuhkod,sto_yurtdisi_satmuhk,sto_ilavemasmuhkod,sto_yatirimtesmuhkod,sto_depsatmuhkod,sto_depsatmalmuhkod,sto_bagortsatmuhkod,sto_bagortsatIadmuhkod,sto_bagortsatIskmuhkod,sto_satfiyfarkmuhkod,sto_yurtdisisatmalmuhkod,sto_bagortsatmalmuhkod,sto_sifirbedsatmalmuhkod,sto_karorani,sto_min_stok,sto_siparis_stok,sto_max_stok,sto_ver_sip_birim,sto_al_sip_birim,sto_siparis_sure,sto_perakende_vergi,sto_toptan_vergi,sto_yer_kod,sto_elk_etk_tipi,sto_raf_etiketli,sto_etiket_bas,sto_satis_dursun,sto_siparis_dursun,sto_malkabul_dursun,sto_malkabul_gun1,sto_malkabul_gun2,sto_malkabul_gun3,sto_malkabul_gun4,sto_malkabul_gun5,sto_malkabul_gun6,sto_malkabul_gun7,sto_siparis_gun1,sto_siparis_gun2,sto_siparis_gun3,sto_siparis_gun4,sto_siparis_gun5,sto_siparis_gun6,sto_siparis_gun7,sto_iskon_yapilamaz,sto_tasfiyede,sto_alt_grup_no,sto_kategori_kodu,sto_urun_sorkod,sto_altgrup_kod,sto_anagrup_kod,sto_uretici_kodu,sto_sektor_kodu,sto_reyon_kodu,sto_muhgrup_kodu,sto_ambalaj_kodu,sto_marka_kodu,sto_beden_kodu,sto_renk_kodu,sto_model_kodu,sto_sezon_kodu,sto_hammadde_kodu,sto_prim_kodu,sto_kalkon_kodu,sto_paket_kodu,sto_pozisyonbayrak_kodu,sto_mkod_artik,sto_kasa_tarti_fl,sto_bedenli_takip,sto_renkDetayli,sto_miktarondalikli_fl,sto_pasif_fl,sto_eksiyedusebilir_fl,sto_GtipNo,sto_puan,sto_komisyon_hzmkodu,sto_komisyon_orani,sto_otvuygulama,sto_otvtutar,sto_otvliste,sto_otvbirimi,sto_prim_orani,sto_garanti_sure,sto_garanti_sure_tipi,sto_iplik_Ne_no,sto_standartmaliyet,sto_kanban_kasa_miktari,sto_oivuygulama,sto_zraporu_stoku_fl,sto_maxiskonto_orani,sto_detay_takibinde_depo_kontrolu_fl,sto_tamamlayici_kodu,sto_oto_barkod_acma_sekli,sto_oto_barkod_kod_yapisi,sto_KasaIskontoOrani,sto_KasaIskontoTutari,sto_gelirpayi,sto_oivtutar,sto_oivturu,sto_giderkodu,sto_oivvergipntr,sto_Tevkifat_turu,sto_SKT_fl,sto_terazi_SKT,sto_RafOmru,sto_KasadaTaksitlenebilir_fl,sto_ufrsfark_kod,sto_iade_ufrsfark_kod,sto_yurticisat_ufrsfark_kod,sto_satiade_ufrsfark_kod,sto_satisk_ufrsfark_kod,sto_alisk_ufrsfark_kod,sto_satmal_ufrsfark_kod,sto_yurtdisisat_ufrsfark_kod,sto_ilavemas_ufrsfark_kod,sto_yatirimtes_ufrsfark_kod,sto_depsat_ufrsfark_kod,sto_depsatmal_ufrsfark_kod,sto_bagortsat_ufrsfark_kod,sto_bagortsatiade_ufrsfark_kod,sto_bagortsatisk_ufrsfark_kod,sto_satfiyfark_ufrsfark_kod,sto_yurtdisisatmal_ufrsfark_kod,sto_bagortsatmal_ufrsfark_kod,sto_sifirbedsatmal_ufrsfark_kod,sto_uretimmaliyet_ufrsfark_kod,sto_uretimkapasite_ufrsfark_kod,sto_degerdusuklugu_ufrs_kod,sto_halrusumyudesi,sto_webe_gonderilecek_fl,sto_min_stok_belirleme_gun,sto_sip_stok_belirleme_gun,sto_max_stok_belirleme_gun,sto_sev_bel_opr_degerlendime_fl,sto_otv_tevkifat_turu) VALUES (, 0, 0, 0, 0, 13, 0, 0, 0, 0,'", sto_create_user, "','", sto_create_date, "',1,'", sto_lastup_date, "', '', '', '', '", sto_kod, "','", sto_isim, "', '", sto_kisa_ismi, "', '", sto_yabanci_isim, "', '', 0, 0, 0, '", sto_birim1_ad, "' ,", sto_birim1_katsayi, "', 0, 0, 0, 0, 0, ", sto_birim2_ad, "', ", sto_birim2_katsayi, "', 0, 0, 0, 0, 0, ", sto_birim3_ad, "', ", sto_birim3_katsayi, "', 0, 0, 0, 0, 0, ", sto_birim4_ad, "', ", sto_birim4_katsayi, "', 0, 0, 0, 0, 0, 153, 153, 600, 610, 611, 153, 621, 601, 153, 258, 600, 621, 600, 610, 611, 600, 621, 621, 760, 0, 0, 0, 0, 0, 0, 0, 4, 4, '', 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', 0, 0, 1, 0, 0, 0, '', 0, '', 0, 0, 0, 0, 1, 0, 0, 0, 0, 90.0, 0, 0, 0, 0, 0, '', 0, '8692700123456', 0, 0, 0, 0, 0, '', 0, 0, 0, 0, 0, 0, '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', 0, 0, 0, 0, 0, 0, 0) "}))
        Me.sCmd.CommandText = Me.sorgu_query(String.Concat(New String() {"SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED  INSERT INTO STOKLAR (sto_RECid_DBCno,sto_RECid_RECno,sto_SpecRECno,sto_iptal,sto_fileid,sto_hidden,sto_kilitli,sto_degisti, sto_checksum, sto_create_user, sto_create_date, sto_lastup_user, sto_lastup_date, sto_special1, sto_special2, sto_special3, sto_kod,sto_isim, sto_kisa_ismi, sto_yabanci_isim, sto_sat_cari_kod, sto_cins, sto_doviz_cinsi, sto_detay_takip, sto_birim1_ad, sto_birim1_katsayi,sto_birim1_agirlik, sto_birim1_en, sto_birim1_boy, sto_birim1_yukseklik, sto_birim1_dara, sto_birim2_ad, sto_birim2_katsayi, sto_birim2_agirlik,sto_birim2_en, sto_birim2_boy, sto_birim2_yukseklik, sto_birim2_dara, sto_birim3_ad, sto_birim3_katsayi, sto_birim3_agirlik, sto_birim3_en,sto_birim3_boy, sto_birim3_yukseklik, sto_birim3_dara, sto_birim4_ad, sto_birim4_katsayi, sto_birim4_agirlik, sto_birim4_en, sto_birim4_boy,sto_birim4_yukseklik, sto_birim4_dara, sto_muh_kod, sto_muh_Iade_kod, sto_muh_sat_muh_kod, sto_muh_satIadmuhkod, sto_muh_sat_isk_kod,sto_muh_aIiskmuhkod, sto_muh_satmalmuhkod, sto_yurtdisi_satmuhk, sto_ilavemasmuhkod, sto_yatirimtesmuhkod, sto_depsatmuhkod, sto_depsatmalmuhkod, sto_bagortsatmuhkod, sto_bagortsatIadmuhkod, sto_bagortsatIskmuhkod, sto_satfiyfarkmuhkod, sto_yurtdisisatmalmuhkod, sto_bagortsatmalmuhkod,sto_sifirbedsatmalmuhkod, sto_karorani, sto_min_stok, sto_siparis_stok, sto_max_stok, sto_ver_sip_birim, sto_al_sip_birim, sto_siparis_sure, sto_perakende_vergi, sto_toptan_vergi, sto_yer_kod, sto_elk_etk_tipi, sto_raf_etiketli, sto_etiket_bas, sto_satis_dursun, sto_siparis_dursun,sto_malkabul_dursun, sto_malkabul_gun1, sto_malkabul_gun2, sto_malkabul_gun3, sto_malkabul_gun4, sto_malkabul_gun5, sto_malkabul_gun6, sto_malkabul_gun7, sto_siparis_gun1, sto_siparis_gun2, sto_siparis_gun3, sto_siparis_gun4, sto_siparis_gun5, sto_siparis_gun6, sto_siparis_gun7, sto_iskon_yapilamaz, sto_tasfiyede, sto_alt_grup_no, sto_kategori_kodu, sto_urun_sorkod, sto_altgrup_kod, sto_anagrup_kod, sto_uretici_kodu,sto_sektor_kodu, sto_reyon_kodu, sto_muhgrup_kodu, sto_ambalaj_kodu, sto_marka_kodu, sto_beden_kodu, sto_renk_kodu, sto_model_kodu, sto_sezon_kodu, sto_hammadde_kodu, sto_prim_kodu, sto_kalkon_kodu, sto_paket_kodu, sto_pozisyonbayrak_kodu, sto_mkod_artik, sto_kasa_tarti_fl, sto_bedenli_takip,sto_renkDetayli, sto_miktarondalikli_fl, sto_pasif_fl, sto_eksiyedusebilir_fl, sto_GtipNo, sto_puan, sto_komisyon_hzmkodu, sto_komisyon_orani, sto_otvuygulama, sto_otvtutar, sto_otvliste, sto_otvbirimi, sto_prim_orani, sto_garanti_sure, sto_garanti_sure_tipi, sto_iplik_Ne_no, sto_standartmaliyet,sto_kanban_kasa_miktari, sto_oivuygulama, sto_zraporu_stoku_fl, sto_maxiskonto_orani, sto_detay_takibinde_depo_kontrolu_fl, sto_tamamlayici_kodu,sto_oto_barkod_acma_sekli, sto_oto_barkod_kod_yapisi, sto_KasaIskontoOrani, sto_KasaIskontoTutari, sto_gelirpayi, sto_oivtutar, sto_oivturu,sto_giderkodu, sto_oivvergipntr, sto_Tevkifat_turu, sto_SKT_fl, sto_terazi_SKT, sto_RafOmru, sto_KasadaTaksitlenebilir_fl, sto_ufrsfark_kod,sto_iade_ufrsfark_kod, sto_yurticisat_ufrsfark_kod, sto_satiade_ufrsfark_kod, sto_satisk_ufrsfark_kod, sto_alisk_ufrsfark_kod, sto_satmal_ufrsfark_kod,sto_yurtdisisat_ufrsfark_kod, sto_ilavemas_ufrsfark_kod, sto_yatirimtes_ufrsfark_kod, sto_depsat_ufrsfark_kod, sto_depsatmal_ufrsfark_kod,sto_bagortsat_ufrsfark_kod, sto_bagortsatiade_ufrsfark_kod, sto_bagortsatisk_ufrsfark_kod, sto_satfiyfark_ufrsfark_kod, sto_yurtdisisatmal_ufrsfark_kod,sto_bagortsatmal_ufrsfark_kod, sto_sifirbedsatmal_ufrsfark_kod, sto_uretimmaliyet_ufrsfark_kod, sto_uretimkapasite_ufrsfark_kod,sto_degerdusuklugu_ufrs_kod, sto_halrusumyudesi, sto_webe_gonderilecek_fl, sto_min_stok_belirleme_gun, sto_sip_stok_belirleme_gun,sto_max_stok_belirleme_gun, sto_sev_bel_opr_degerlendime_fl, sto_otv_tevkifat_turu) VALUES (0,'", sto_RECid_RECno, "',0,0,13,0,0,0,0,'", sto_create_user, "','", sto_create_date, "',1,'", sto_lastup_date, "','','','','", sto_kod, "','", sto_isim, "','", sto_kisa_ismi, "', '", sto_yabanci_isim, "','',0,0,0,'", sto_birim1_ad, "',0,0,0,0,0,0,0,0,0,0,0,0,0,'',0,0,0,0,0,0,'',0,0,0,0,0,0,'153','153','600','610','611','153','621','601','153','258','600','621','600','610','611','600','621','621','760',0,0,0,0,0,0,0,'", sto_perakende_vergi, "','", sto_toptan_vergi, "','',0,1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,'','','','','','','','','','','','','','','','','','','','',0,0,0,0,0,0,N'',0,'',0,0,0,0,1,0,0,0,0,90.000000000000,0,0,0,0,0,'',0,'',0,0,0,0,0,'',0,0,0,0,0,0,'','','','','','','','','','','','','','','','','','','','','','',0,0,0,0,0,0,0)"}))
        Me.sCmd.ExecuteNonQuery()
        Me.sCmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        Return Conversions.ToLong(RuntimeHelpers.GetObjectValue(Me.sCmd.ExecuteScalar))
    End Function
    Private Function FATURA1_kaydet_yeni_Mikro(ByVal sip_RECid_DBCno As Integer, ByVal sip_RECid_RECno As Long, ByVal sip_SpecRECno As Long, ByVal sip_iptal As Boolean, ByVal sip_fileid As Integer, ByVal sip_hidden As Boolean, ByVal sip_kilitli As Boolean, ByVal sip_degisti As Boolean, ByVal sip_checksum As Boolean, ByVal sip_create_user As Integer, ByVal sip_create_date As DateTime, ByVal sip_lastup_user As Integer, ByVal sip_lastup_date As DateTime, ByVal sip_special1 As String, ByVal sip_special2 As String, ByVal sip_special3 As String, ByVal sip_firmano As Long, ByVal sip_subeno As Long, ByVal sip_tarih As DateTime, ByVal sip_teslim_tarih As DateTime, sip_tip As Byte, ByVal sip_cins As Byte, ByVal sip_evrakno_seri As String, ByVal sip_evrakno_sira As Long, ByVal sip_satirno As Long, ByVal sip_belge_no As String, ByVal sip_belge_tarih As DateTime, ByVal sip_satici_kod As Integer, ByVal sip_musteri_kod As String, ByVal sip_stok_kod As String, ByVal sip_b_fiyat As Decimal, ByVal sip_miktar As Decimal, ByVal sip_birim_pntr As Byte, ByVal sip_teslim_miktar As Decimal, ByVal sip_tutar As Decimal, ByVal sip_iskonto_1 As Decimal, ByVal sip_iskonto_2 As Decimal, ByVal sip_iskonto_3 As Decimal, ByVal sip_iskonto_4 As Decimal, ByVal sip_iskonto_5 As Decimal, ByVal sip_iskonto_6 As Decimal, ByVal sip_masraf_1 As Decimal, ByVal sip_masraf_2 As Decimal, ByVal sip_masraf_3 As Decimal, ByVal sip_masraf_4 As Decimal, ByVal sip_vergi_pntr As Byte, ByVal sip_vergi As Decimal, ByVal sip_masvergi_pntr As Byte, ByVal sip_masvergi As Decimal, ByVal sip_opno As Long, ByVal sip_aciklama As Integer, ByVal sip_aciklama2 As Integer, ByVal sip_depono As Long, ByVal sip_OnaylayanKulNo As Integer, ByVal sip_vergisiz_fl As Boolean, ByVal sip_kapat_fl As Boolean, ByVal sip_promosyon_fl As Boolean, ByVal sip_cari_sormerk As Integer, ByVal sip_stok_sormerk As Integer, ByVal sip_cari_grupno As Byte, ByVal sip_doviz_cinsi As Byte, ByVal sip_doviz_kuru As Decimal, ByVal sip_alt_doviz_kuru As Decimal, ByVal sip_adresno As Long, ByVal sip_teslimturu As String, ByVal sip_cagrilabilir_fl As Boolean, ByVal sip_prosiprecDbId As Integer, ByVal sip_prosiprecrecI As Long, ByVal sip_iskonto1 As Byte, ByVal sip_iskonto2 As Byte, ByVal sip_iskonto3 As Byte, ByVal sip_iskonto4 As Byte, ByVal sip_iskonto5 As Byte, ByVal sip_iskonto6 As Byte, ByVal sip_masraf1 As Byte, ByVal sip_masraf2 As Byte, ByVal sip_masraf3 As Byte, ByVal sip_masraf4 As Byte, ByVal sip_isk1 As Boolean, ByVal sip_isk2 As Boolean, ByVal sip_isk3 As Boolean, ByVal sip_isk4 As Boolean, ByVal sip_isk5 As Boolean, ByVal sip_isk6 As Boolean, ByVal sip_mas1 As Boolean, ByVal sip_mas2 As Boolean, ByVal sip_mas3 As Boolean, ByVal sip_mas4 As Boolean, ByVal sip_Exp_Imp_Kodu As String, ByVal sip_kar_orani As Decimal, ByVal sip_durumu As Byte, ByVal sip_stalRecId_DBCno As Integer, ByVal sip_stalRecId_RECno As Long, ByVal sip_planlananmiktar As Integer, ByVal sip_teklifRecId_DBCno As Long, ByVal sip_teklifRecId_RECno As Long, ByVal sip_parti_kodu As String, ByVal sip_lot_no As Long, ByVal sip_projekodu As String, ByVal sip_fiyat_liste_no As Long, ByVal sip_Otv_Pntr As Byte, ByVal sip_Otv_Vergi As Decimal, ByVal sip_otvtutari As Decimal, ByVal sip_OtvVergisiz_Fl As Byte, ByVal sip_paket_kod As String, ByVal sip_RezRecId_DBCno As Integer, ByVal sip_RezRecId_RECno As Long, ByVal sip_harekettipi As Byte, ByVal sip_yetkili_recid_dbcno As Integer, ByVal sip_yetkili_recid_recno As Long, ByVal sip_kapatmanedenkod As String, ByVal sip_gecerlilik_tarihi As DateTime, ByVal sip_onodeme_evrak_tip As Byte, ByVal sip_onodeme_evrak_seri As String, ByVal sip_onodeme_evrak_sira As Long, ByVal sip_rezervasyon_miktari As Decimal, ByVal sip_rezerveden_teslim_edilen As Decimal) As Long
        Try
            If (Me.sCon.State = ConnectionState.Closed) Then
                Me.sCon.Open()
            End If
        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            Dim exception As Exception = exception1
            Me.sCon.Close()
            Me.sCon.Open()
            ProjectData.ClearProjectError()
        End Try
        'Me.sCmd.CommandText = Me.sorgu_query(String.Concat(New String() {"SET IDENTITY_INSERT STOK_HAREKETLERI ON SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED  INSERT INTO FATURA_ALT                       (FATIP, STOKREF, STK, STA, STB, BRKODU, FREEBR, MIKTAR, DOVIZC, BRFTL, TUTARTL, KDVY, KDVTL, KDVD, OTVY, OTVTL, INDY, INDTL, IND1, IND2, IND3,  IND4, IND5, IND6, OZELKOD1, OZELKOD2, ACIKLAMA, STOKTUR,TUR, TURAC, AORS, SATINDTL, GRMIK, CKMIK, GRBRFTL, CKBRFTL, GRBRFD, CKBRFD, GRTUTARTL, CKTUTARTL, KALANMIKTAR, FATREF, IRSREF, SIPREF, FATEVRAKNO, FATIRSTUR, FATSATIRREF, IPTAL, SUBE, MASRAFMERKEZI, KAMPKODU, KULLANICI, SATICI, KDVDH, TARIH, ISLEMTIPI, EVRAKNO, CARIREF, DEPOREF, SIPMIKTAR, IRSMIKTAR, FATMIKTAR, SATIRREF, ISEMRINO, P_ID, ANABROR2, ANABROR3, p2var, RECETEVAR, AKTARIM, NETTUTARTL, MDAGIT, IDAGIT, OLDSTOKREF, SIRALAMA, KARTDOVIZC, KARTUGDK, KARTDOVIZTUTAR, GVSTOPAJTUTARITL, GVSTOPAJTUTARD, SATIRP_ID, BR2ISLEM, BR3ISLEM, STOKP_ID, IRSEKLE, FATACIKLAMA, INDSIZKDV, NETKG, BRUTKG, PAKETM, PAKETACK, KALITEKODU, STOKNETKG, STOKBRUTKG, SEVKTARIHI, OTVBRNO, OTVVERGIMATRAH, EMSALBEDEL, OIVTUTARTL, OIVVERGIMATRAH) VALUES     ('", FATIP, "', ", Conversions.ToString(STOKREF), ", '", STK, "', '", STA, "', '", STB, "', '", BRKODU, "', '", FREEBR, "', ", Conversions.ToString(MIKTAR), ", ", Conversions.ToString(DOVIZC), ", ", Conversions.ToString(BRFTL), ", ", Conversions.ToString(TUTARTL), ", ", Conversions.ToString(KDVY), ", ", Conversions.ToString(KDVTL), ", ", Conversions.ToString(KDVD), ", ", Conversions.ToString(OTVY), ", ", Conversions.ToString(OTVTL), ", ", Conversions.ToString(INDY), ", ", Conversions.ToString(INDTL), ", ", Conversions.ToString(IND1), ", ", Conversions.ToString(IND2), ", ", Conversions.ToString(IND3), ", ", Conversions.ToString(IND4), ", ", Conversions.ToString(IND5), ", ", Conversions.ToString(IND6), ", '", OZELKOD1, "', '", OZELKOD2, "', '", ACIKLAMA, "', ", Conversions.ToString(STOKTUR), ",", Conversions.ToString(TUR), ", '", TURAC, "', '", AORS, "', ", Conversions.ToString(SATINDTL), ", ", Conversions.ToString(GRMIK), ", ", Conversions.ToString(CKMIK), ", ", Conversions.ToString(GRBRFTL), ", ", Conversions.ToString(CKBRFTL), ", ", Conversions.ToString(GRBRFD), ", ", Conversions.ToString(CKBRFD), ", ", Conversions.ToString(GRTUTARTL), ", ", Conversions.ToString(CKTUTARTL), ", ", Conversions.ToString(KALANMIKTAR), ", ", Conversions.ToString(FATREF), ", ", Conversions.ToString(IRSREF), ", ", Conversions.ToString(SIPREF), ", '", FATEVRAKNO, "', ", Conversions.ToString(FATIRSTUR), ", ", Conversions.ToString(FATSATIRREF), ", ", Conversions.ToString(IPTAL), ", ", Conversions.ToString(SUBE), ", '", MASRAFMERKEZI, "', '", KAMPKODU, "', '", KULLANICI, "', '", SATICI, "', ", Conversions.ToString(KDVDH), ",  '", Conversions.ToString(TARIH), "', ", Conversions.ToString(ISLEMTIPI), ", '", EVRAKNO, "', ", Conversions.ToString(CARIREF), ", ", Conversions.ToString(DEPOREF), ", ", Conversions.ToString(SIPMIKTAR), ", ", Conversions.ToString(IRSMIKTAR), ", ", Conversions.ToString(FATMIKTAR), ", ", Conversions.ToString(SATIRREF), ", '", ISEMRINO, "', '", P_ID, "', ", Conversions.ToString(ANABROR2), ", ", Conversions.ToString(ANABROR3), ", ", Conversions.ToString(p2var), ", ", Conversions.ToString(RECETEVAR), ", ", Conversions.ToString(AKTARIM), ", ", Conversions.ToString(NETTUTARTL), ", ", Conversions.ToString(MDAGIT), ", ", Conversions.ToString(IDAGIT), ", ", Conversions.ToString(OLDSTOKREF), ", ", Conversions.ToString(SIRALAMA), ", ", Conversions.ToString(KARTDOVIZC), ", ", Conversions.ToString(KARTUGDK), ", ", Conversions.ToString(KARTDOVIZTUTAR), ", ", Conversions.ToString(GVSTOPAJTUTARITL), ", ", Conversions.ToString(GVSTOPAJTUTARD), ", '", SATIRP_ID, "', '", BR2ISLEM, "', '", BR3ISLEM, "', '", STOKP_ID, "', ", Conversions.ToString(IRSEKLE), ", '", FATACIKLAMA, "', ", Conversions.ToString(INDSIZKDV), ", ", Conversions.ToString(NETKG), ", ", Conversions.ToString(BRUTKG), ", ", Conversions.ToString(PAKETM), ", '", PAKETACK, "', '", KALITEKODU, "', ", Conversions.ToString(STOKNETKG), ", ", Conversions.ToString(STOKBRUTKG), ", '", Conversions.ToString(SEVKTARIHI), "', ", Conversions.ToString(OTVBRNO), ", ", Conversions.ToString(OTVVERGIMATRAH), ", ", Conversions.ToString(EMSALBEDEL), ", ", Conversions.ToString(OIVTUTARTL), ", ", Conversions.ToString(OIVVERGIMATRAH), ")"}))
        'Me.sCmd.CommandText = Me.sorgu_query(String.Concat(New String() {"SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED  INSERT INTO STOK_HAREKETLERI (sip_RECid_DBCno,sip_RECid_RECno,sip_SpecRECno,sip_iptal,sip_fileid,sip_hidden,sip_kilitli,sip_degisti,sip_checksum,sip_create_user,sip_create_date,sip_lastup_user,sip_lastup_date,sip_special1,sip_special2,sip_special3,sip_firmano,sip_subeno,sip_tarih,sip_tip,sip_cins,sip_normal_iade,sip_evraktip,sip_evrakno_seri,sip_evrakno_sira,sip_satirno,sip_belge_no,sip_belge_tarih,sip_stok_kod,sip_isk_mas1,sip_isk_mas2,sip_isk_mas3,sip_isk_mas4,sip_isk_mas5,sip_isk_mas6,sip_isk_mas7,sip_isk_mas8,sip_isk_mas9,sip_isk_mas10,sip_sat_iskmas1,sip_sat_iskmas2,sip_sat_iskmas3,sip_sat_iskmas4,sip_sat_iskmas5,sip_sat_iskmas6,sip_sat_iskmas7,sip_sat_iskmas8,sip_sat_iskmas9,sip_sat_iskmas10,sip_pos_satis,sip_promosyon_fl,sip_cari_cinsi,sip_cari_kodu,sip_cari_grup_no,sip_isemri_gider_kodu,sip_plasiyer_kodu,sip_har_doviz_cinsi,sip_har_doviz_kuru,sip_alt_doviz_kuru,sip_stok_doviz_cinsi,sip_stok_doviz_kuru,sip_miktar,sip_miktar2,sip_birim_pntr,sip_tutar,sip_iskonto1,sip_iskonto2,sip_iskonto3,sip_iskonto4,sip_iskonto5,sip_iskonto6,sip_masraf1,sip_masraf2,sip_masraf3,sip_masraf4,sip_vergi_pntr,sip_vergi,sip_masraf_vergi_pntr,sip_masraf_vergi,sip_netagirlik,sip_odeme_op,sip_aciklama,sip_sip_recid_dbcno,sip_sip_recid_recno,sip_fat_recid_dbcno,sip_fat_recid_recno,sip_giris_depo_no,sip_cikis_depo_no,sip_malkbl_sevk_tarihi,sip_cari_srm_merkezi,sip_stok_srm_merkezi,sip_fis_tarihi,sip_fis_sirano,sip_vergisiz_fl,sip_maliyet_ana,sip_maliyet_alternatif,sip_maliyet_orjinal,sip_adres_no,sip_parti_kodu,sip_lot_no,sip_kons_recid_dbcno,sip_kons_recid_recno,sip_proje_kodu,sip_exim_kodu,sip_otv_pntr,sip_otv_vergi,sip_brutagirlik,sip_disticaret_turu,sip_otvtutari,sip_otvvergisiz_fl,sip_oiv_pntr,sip_oiv_vergi,sip_oivvergisiz_fl,sip_fiyat_liste_no,sip_oivtutari,sip_Tevkifat_turu,sip_nakliyedeposu,sip_nakliyedurumu) VALUES (0,'", sip_RECid_RECno, "','", sip_SpecRECno, "' ,0,16,0,0,0,0,1,'", sip_create_date, "',1,'", sip_lastup_date, "','','','',0,0,'", sip_tarih, "','", sip_tip, "',0,'", sip_normal_iade, "','", sip_evraktip, "','", sip_evrakno_seri, "','", sip_evrakno_sira, "','", sip_satirno, "','", sip_belge_no, "','", sip_belge_tarih, "','", sip_stok_kod, "',0,1,1,1,1,1,1,1,1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,'", sip_cari_kodu, "',0,'','',0,1.000000000000,1.000000000000,0,1.000000000000,'", sip_miktar, "','", sip_miktar2, "',1,'", sip_tutar, "','", sip_iskonto1, "',0,0,0,0,0,0,0,0,0,4,'", sip_vergi, "',0,0,0,0,'',0,0,0,0,0,1,'", sip_malkbl_sevk_tarihi, "','','','", sip_fis_tarihi, "',0,0,0,0,0,1,'',0,0,0,'','',0,0,0,0,0,0,0,0,0,1,0,0,0,0,0) "}))
        'Me.sCmd.CommandText = Me.sorgu_query(String.Concat(New String() {"SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED  INSERT INTO SIPARISLER (sip_RECid_DBCno, sip_RECid_RECno, sip_SpecRECno, sip_iptal, sip_fileid, sip_hidden, sip_kilitli, sip_degisti, sip_checksum, sip_create_user, sip_create_date, sip_lastup_user, sip_lastup_date, sip_special1, sip_special2, sip_special3, sip_firmano, sip_subeno, sip_tarih, sip_teslim_tarih, sip_tip, sip_cins, sip_evrakno_seri, sip_evrakno_sira, sip_satirno, sip_belgeno, sip_belge_tarih, sip_satici_kod, sip_musteri_kod, sip_stok_kod, sip_b_fiyat, sip_miktar, sip_birim_pntr, sip_teslim_miktar, sip_tutar, sip_iskonto_1, sip_iskonto_2, sip_iskonto_3, sip_iskonto_4, sip_iskonto_5, sip_iskonto_6, sip_masraf_1, sip_masraf_2, sip_masraf_3, sip_masraf_4, sip_vergi_pntr, sip_vergi, sip_masvergi_pntr, sip_masvergi, sip_opno, sip_aciklama, sip_aciklama2, sip_depono, sip_OnaylayanKulNo, sip_vergisiz_fl, sip_kapat_fl, sip_promosyon_fl, sip_cari_sormerk, sip_stok_sormerk, sip_cari_grupno, sip_doviz_cinsi, sip_doviz_kuru, sip_alt_doviz_kuru, sip_adresno, sip_teslimturu, sip_cagrilabilir_fl, sip_prosiprecDbId, sip_prosiprecrecI, sip_iskonto1, sip_iskonto2, sip_iskonto3, sip_iskonto4, sip_iskonto5, sip_iskonto6, sip_masraf1, sip_masraf2, sip_masraf3, sip_masraf4, sip_isk1, sip_isk2, sip_isk3, sip_isk4, sip_isk5, sip_isk6, sip_mas1, sip_mas2, sip_mas3, sip_mas4, sip_Exp_Imp_Kodu, sip_kar_orani, sip_durumu, sip_stalRecId_DBCno, sip_stalRecId_RECno, sip_planlananmiktar, sip_teklifRecId_DBCno, sip_teklifRecId_RECno, sip_parti_kodu, sip_lot_no, sip_projekodu, sip_fiyat_liste_no, sip_Otv_Pntr, sip_Otv_Vergi, sip_otvtutari, sip_OtvVergisiz_Fl, sip_paket_kod, sip_RezRecId_DBCno, sip_RezRecId_RECno, sip_harekettipi, sip_yetkili_recid_dbcno, sip_yetkili_recid_recno, sip_kapatmanedenkod, sip_gecerlilik_tarihi, sip_onodeme_evrak_tip, sip_onodeme_evrak_seri, sip_onodeme_evrak_sira, sip_rezervasyon_miktari, sip_rezerveden_teslim_edilen) VALUES (0,sip_RECid_RECno,0,0,sip_Fileid,0,0,0,0,1,sip_create_date,1,sip_lastup_date,'','','',0,0,sip_tarih,sip_teslim_tarih,0,'',0,sip_satirno,sip_belgeno,sip_belge_tarih,'',sip_musteri_kod,sip_stok_kod,sip_b_fiyat,sip_miktar,1,0,sip_tutar,0,0,0,0,0,0,0,0,0,0,4,sip_vergi,0,0,0,'','',1,0,0,0,0,'','',0,0,1.000000000000,1.000000000000,1,'',1,0,0,0,1,1,1,1,1,1,1,1,1,0,0,0,0,0,0,0,0,0,0,'',0,0,0,0,0,0,0,'',0,'',0,0,0,0,0,'',0,0,0,0,0,'',sip_gecerlilik_tarihi,0,'',0,0,0)"}))
        Me.sCmd.CommandText = Me.sorgu_query(String.Concat(New String() {"SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED  INSERT INTO SIPARISLER (sip_RECid_DBCno,sip_RECid_RECno,sip_SpecRECno,sip_iptal,sip_fileid,sip_hidden,sip_kilitli,sip_degisti,sip_checksum,sip_create_user,sip_create_date,sip_lastup_user,sip_lastup_date,sip_special1,sip_special2,sip_special3,sip_firmano,sip_subeno,sip_tarih,sip_teslim_tarih,sip_tip,sip_cins,sip_evrakno_seri,sip_evrakno_sira,sip_satirno,sip_belgeno,sip_belge_tarih,sip_satici_kod,sip_musteri_kod,sip_stok_kod,sip_b_fiyat,sip_miktar,sip_birim_pntr,sip_teslim_miktar,sip_tutar,sip_iskonto_1,sip_iskonto_2,sip_iskonto_3,sip_iskonto_4,sip_iskonto_5,sip_iskonto_6,sip_masraf_1,sip_masraf_2,sip_masraf_3,sip_masraf_4,sip_vergi_pntr,sip_vergi,sip_masvergi_pntr,sip_masvergi,sip_opno,sip_aciklama,sip_aciklama2,sip_depono,sip_OnaylayanKulNo,sip_vergisiz_fl,sip_kapat_fl,sip_promosyon_fl,sip_cari_sormerk,sip_stok_sormerk,sip_cari_grupno,sip_doviz_cinsi,sip_doviz_kuru,sip_alt_doviz_kuru,sip_adresno,sip_teslimturu,sip_cagrilabilir_fl,sip_prosiprecDbId,sip_prosiprecrecI,sip_iskonto1,sip_iskonto2,sip_iskonto3,sip_iskonto4,sip_iskonto5,sip_iskonto6,sip_masraf1,sip_masraf2,sip_masraf3,sip_masraf4,sip_isk1,sip_isk2,sip_isk3,sip_isk4,sip_isk5,sip_isk6,sip_mas1,sip_mas2,sip_mas3,sip_mas4,sip_Exp_Imp_Kodu,sip_kar_orani,sip_durumu,sip_stalRecId_DBCno,sip_stalRecId_RECno,sip_planlananmiktar,sip_teklifRecId_DBCno,sip_teklifRecId_RECno,sip_parti_kodu,sip_lot_no,sip_projekodu,sip_fiyat_liste_no,sip_Otv_Pntr,sip_Otv_Vergi,sip_otvtutari,sip_OtvVergisiz_Fl,sip_paket_kod,sip_RezRecId_DBCno,sip_RezRecId_RECno,sip_harekettipi,sip_yetkili_recid_dbcno,sip_yetkili_recid_recno,sip_kapatmanedenkod,sip_gecerlilik_tarihi,sip_onodeme_evrak_tip,sip_onodeme_evrak_seri,sip_onodeme_evrak_sira,sip_rezervasyon_miktari,sip_rezerveden_teslim_edilen) VALUES (0,'", sip_RECid_RECno, "',0,0,'", sip_fileid, "',0,0,0,0,1,'", sip_create_date, "',1,'", sip_lastup_date, "','", sip_special1, "','','',0,0,'", sip_tarih, "','", sip_teslim_tarih, "','", sip_tip, "',0,'','", sip_evrakno_sira, "','", sip_satirno, "','", sip_belge_no, "','", sip_belge_tarih, "','','", sip_musteri_kod, "','", sip_stok_kod, "','", sip_b_fiyat, "','", sip_miktar, "',1,0,'", sip_tutar, "','", sip_iskonto_1, "',0,0,0,0,0,0,0,0,0,'", sip_vergi_pntr, "','", sip_vergi, "',0,0,0,'','',1,0,0,0,0,'','',0,0,1.000000000000,1.000000000000,1,'',1,0,0,0,1,1,1,1,1,1,1,1,1,0,0,0,0,0,0,0,0,0,0,'',0,0,0,0,0,0,0,'',0,'',0,0,0,0,0,'',0,0,0,0,0,'','", sip_gecerlilik_tarihi, "',0,'',0,0,0)"}))
        Me.sCmd.ExecuteNonQuery()
        Me.sCmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        Return Conversions.ToLong(RuntimeHelpers.GetObjectValue(Me.sCmd.ExecuteScalar))
        ' Me.sCmd.CommandText = Me.sorgu_query(String.Concat(New String() {"UPDATE MikroDB_V15_CZM.dbo.STOK_HAREKETLERI SET sth_RECid_RECno= '", sth_RECid_RECno, "',sth_giris_depo_no=1 Where sth_RECno = '", sth_RECno, "' "}))
    End Function
    Private Sub mikro_entegre()
        If (Me.GridView1.RowCount > 0) Then
            Dim _kopyala As New frm_fatura_kopyala1 With {
                .firmano = RuntimeHelpers.GetObjectValue(Me.firmano),
                .donemno = RuntimeHelpers.GetObjectValue(Me.donemno),
                .connection = RuntimeHelpers.GetObjectValue(Me.connection),
                .sFisTipi = "FS ",
                .nGirisCikis = 3,
                .kapla = True,
                .nFirmaID = 0,
                .sKodu = "32027001"
            }
            _kopyala.txt_musteriNo.EditValue = _kopyala.sKodu
            _kopyala.lbl_Firma.Text = ""
            _kopyala.txt_dteFisTarihi1.EditValue = KeyCode.dteSistemTarihi
            _kopyala.bAktar = True
            _kopyala.txt_lFisNo.Text = KeyCode.sayiuzunlukkontrol(Conversions.ToString(1), Conversions.ToString(6), "0")
            Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Me.connection)
            Dim sConnection As Object = KeyCode.sConnection
            _kopyala.bLogo = True
            If (_kopyala.ShowDialog(Me) = DialogResult.OK) Then
                Me.firmano = _kopyala.txt_nFirmaNo.Text
                Me.donemno = _kopyala.txt_nDonemNo.Text
                Me.sConnectionLogo = _kopyala.sUzakConnection
                KeyCode.sConnection = _kopyala.sConnection
                If (XtraMessageBox.Show(KeyCode.Sorgu_sDil("Seçili Kayıtları Entegre Etmek İstediğinize Emin misiniz...?", KeyCode.sDil), KeyCode.Sorgu_sDil("Dikkat", KeyCode.sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
                    Dim current As DataRow
                    Dim selectedRowsCount As Object = Me.GridView1.SelectedRowsCount
                    Dim selectedRows As Integer() = Me.GridView1.GetSelectedRows
                    If (Not selectedRows Is Nothing) Then
                        Array.Sort(Of Integer)(selectedRows)
                        Me.bar1.Properties.Maximum = Me.GridView1.SelectedRowsCount
                        Me.bar1.Visible = True
                        Me.bar1.Position = 0
                        Me.sCon.ConnectionString = Me.sConnectionLogo
                        Me.sCmd.Connection = Me.sCon
                        Me.sCmd.CommandTimeout = 400
                        If (Me.sCon.State = ConnectionState.Closed) Then
                            Me.sCon.Open()
                        End If
                        Dim num As Integer
                        For Each num In selectedRows
                            Dim str As String = num.ToString
                            Dim dataRow As DataRow = Me.GridView1.GetDataRow(Conversions.ToInteger(str))
                            Dim num9 As Integer = 1
                            Dim time As DateTime = Conversions.ToDate(dataRow.Item("dteFisTarihi"))
                            Dim cari_RECid As Long = 0
                            Dim rEF As Long = 0
                            Dim str3 As String = ""
                            Dim fATREF As Long = 0
                            Dim str4 As String = ""
                            Dim num11 As Long = 0
                            Dim numM As Long = 0
                            Dim str9 As String = ""
                            Dim normal_iade As String = "0"
                            Dim num13 As Integer = 60
                            Dim tURAC As String = "1"
                            Dim nGirisCikis As String = "1"
                            Dim sKodu1 As String = dataRow.Item("sKodu")
                            sKodu1 = sKodu1.TrimEnd
                            Dim sip_Tip As String
                            If (Trim(Conversions.ToString(dataRow.Item("sFisTipi"))) = "FS") Then
                                If Operators.ConditionalCompareObjectEqual(dataRow.Item("nGirisCikis"), 3, False) Then
                                    num13 = 60
                                    'nGirisCikis = "1"
                                    sip_Tip = "0"
                                ElseIf Operators.ConditionalCompareObjectEqual(dataRow.Item("nGirisCikis"), 4, False) Then
                                    num13 = &H3D
                                    'nGirisCikis = "0"
                                    sip_Tip = "1"
                                End If
                            ElseIf (Trim(Conversions.ToString(dataRow.Item("sFisTipi"))) = "FA") Then
                                If Operators.ConditionalCompareObjectEqual(dataRow.Item("nGirisCikis"), 1, False) Then
                                    num13 = &H3E
                                    'nGirisCikis = "A"
                                    sip_Tip = "1"
                                ElseIf Operators.ConditionalCompareObjectEqual(dataRow.Item("nGirisCikis"), 2, False) Then
                                    num13 = &H3F
                                    'nGirisCikis = "S"
                                    sip_Tip = "0"
                                End If
                                'ElseIf (Trim(Conversions.ToString(dataRow.Item("sFisTipi"))) = "MM") Then
                                '    num13 = &H45
                                '    nGirisCikis = "S"
                                '    tURAC = "Müstahsil Makbuzu"
                                'ElseIf (Trim(Conversions.ToString(dataRow.Item("sFisTipi"))) = "HA") Then
                                '    num13 = &H40
                                '    nGirisCikis = "A"
                                '    tURAC = "Gider Faturası"
                                'ElseIf (Trim(Conversions.ToString(dataRow.Item("sFisTipi"))) = "HS") Then
                                '    num13 = 60
                                '    nGirisCikis = "S"
                                '    tURAC = "Satış Faturası"
                            End If
                            Dim num8 As Decimal = 8
                            Dim sTK As String = ""
                            Dim sTA As String = ""
                            Dim stok_RECid As String = "0"
                            Dim fat_RECid As String = "0"
                            Dim sth_RECno As String = "0"
                            Dim Adres_RECid As String = "0"

                            rEF = Me.sorgula_Mikro_nStokID(Me.sorgu_query(("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT ISNULL(cari_RECno, 0) AS CLIENTREF FROM CARI_HESAPLAR WHERE (cari_kod = '" & sKodu1 & "')")))
                            If (rEF = 0) Then
                                str3 = Me.sorgula_Mikro_string("Select LOWER(NEWID())")
                                cari_RECid = Me.sorgula_Mikro_string("DECLARE @CARI int; SET @CARI = (SELECT ISNULL(MAX(cari_RECid_RECno),'') + 1 from CARI_HESAPLAR)SELECT @CARI AS 'CARI'")
                                Adres_RECid = Me.sorgula_Mikro_string("DECLARE @CARI_AD int; SET @CARI_AD = (SELECT ISNULL(MAX(adr_RECid_RECno),'') + 1 from CARI_HESAP_ADRESLERI)SELECT @CARI_AD AS 'CARI_AD'")

                                'If sKodu1 Like "*120*" Then
                                '    sKodu1 = "120.01.001"
                                'Else
                                '    sKodu1 = "320.01.001"
                                'End If
                                Dim Ulke As String = dataRow.Item("sUlke")
                                If Ulke = "Turkey" Then
                                    Ulke = "TÜRKİYE"
                                End If
                                cari_RECid = Me.CARI_kaydet_yeni_Mikro(0, cari_RECid, 0, 0, 0, 31, 0, 0, 0, 0, 1, Conversions.ToDate(dataRow.Item("dteFisTarihi")), 1, Conversions.ToDate(dataRow.Item("dteFisTarihi")), "''", "''", "''", sKodu1, dataRow.Item("sAciklama").ToString, "''", 0, 0, 0, 0, "''", sKodu, "''", 0, 1, 255, 25.0, 0, 0, 1, dataRow.Item("sVergiDairesi").ToString, dataRow.Item("sVergiNo").ToString, "''", "''", 1, 0, 0, 0, 0, 0, 1, 1, "''", "''", "''", "''", "''", "''", "''", "''", "''", "''", "''", "''", "''", "''", "''", "''", "''", "''", "''", "''", "''", "''", "''", "''", "''", "''", "''", "''", "''", "''", "''", "''", "''", "''", "''", "''", "''", "''", "''", "''", "''", "''", "''", "''", "''", "''", "''", "''", "''", "''", 1, "''", "''", "''", "''", "''", "''", "''", 0, 0, 0, 0, 0, 0, 0, 0, 0, Conversions.ToDate(dataRow.Item("dteFisTarihi")), 0, 0, 0, 0, "''", "''", "''", 0, 0, 0, "''", 0, "''", 0, 0, 0, 0, 0, 0, "''", 0, "''", 0, "''", 0, "''", 0, "''", 0, "''", 0, "''", 0, "''", 0, "''", 0, "''", 0, 0, "''", "''", "''", 0, "'910'", "''", "''", "'912'", "''", "''", "'226'", "''", "''", "'326'", "''", "''", 0, 0)
                                Adres_RECid = Me.CARI_Adres_kaydet_yeni_Mikro(0, Adres_RECid, 0, 0, 32, 0, 0, 0, 0, 1, Conversions.ToDate(dataRow.Item("dteFisTarihi")), 1, Conversions.ToDate(dataRow.Item("dteFisTarihi")), "''", "''", "''", sKodu1, 1, 0, dataRow.Item("sAdres1").ToString, "''", dataRow.Item("sAdres2").ToString, "''", "''", "''", "''", dataRow.Item("sSemt").ToString, dataRow.Item("sIl").ToString, Ulke, "''", "''", "''", "''", "''", "''", "''", "''", 0, "''", "''", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "''")
                                numM = Me.sorgula_Mikro_string("DECLARE @numM int; SET @numM = (SELECT ISNULL(MAX(sth_RECno),'') + 1 from STOK_HAREKETLERI)SELECT @numM AS 'numM'")
                            Else
                                str3 = Me.sorgula_Mikro_string(("Select cari_RECid_RECno from CARI_HESAPLAR WHERE cari_kod = '" & sKodu1 & "'"))
                            End If
                            If (Me.sorgu_fis_kontrol_Mikro(Conversions.ToString(num13), nGirisCikis, Conversions.ToDate(dataRow.Item("dteFisTarihi")), Conversions.ToString(dataRow.Item("lFisNo")), Conversions.ToString(dataRow.Item("nFirmaID")), True, "") = 0) Then
                                Dim enumerator As IEnumerator
                                Dim obj2 As Object = Me.sorgu(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(((((("SELECT tbStokFisiDetayi.*, tbStok.sKodu AS sStokKodu, tbStok.sAciklama AS sStokAciklama,tbStok.sKisaAdi,tbStok.sBirimCinsi1,tbStok.sBirimCinsi2,tbStok.sModel, tbStok.sBeden,tbStok.nFiyatlandirma,tbStok.nStokTipi,tbRenk.sRenkAdi,tbStokBarkodu.sBarkod ,(Select lFiyat from tbStokFiyati where nStokID = tbStok.nStokID and sFiyatTipi = '" & KeyCode.sFiyatM & "') AS lMaliyet,(Select lFiyat from tbStokFiyati where nStokID = tbStok.nStokID and sFiyatTipi = '") & KeyCode.sFiyatA & "') as lAlis, (Select lFiyat from tbStokFiyati where nStokID = tbStok.nStokID and sFiyatTipi = '") & KeyCode.sFiyat1 & "') AS lFiyat1,(Select lFiyat from tbStokFiyati where nStokID = tbStok.nStokID and sFiyatTipi = '") & KeyCode.sFiyat2 & "') AS lFiyat2,(Select lFiyat from tbStokFiyati where nStokID = tbStok.nStokID and sFiyatTipi = '") & KeyCode.sFiyat3 & "') AS lFiyat3,CAST(0 AS FLOAT) AS ISK1, CAST(0 AS FLOAT) AS ISK2,CAST(0 AS FLOAT) AS ISK3,CAST(0 AS FLOAT) AS ISK4,CAST(0 AS FLOAT) AS ISK5,CAST(0 AS FLOAT) AS nMasrafSatiri,CAST(0 AS MONEY) AS GERCEKFIYAT, CAST(0 AS MONEY) AS GERCEKTOPLAM, ABS((tbStokFisiDetayi.lBrutTutar - tbStokFisiDetayi.lIskontoTutari) * (tbStokFisiDetayi.nKdvOrani / 100)) AS lKdvTutari,CAST(tbStokFisiDetayi.lBrutFiyat * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS FLOAT) AS lDahilBrutFiyat,CAST(tbStokFisiDetayi.lBrutTutar * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS FLOAT) AS lDahilBrutTutar, tbStokFisiDetayi.lBrutTutar as lDovizTutar, tbStokFisiDetayi.lBrutFiyat lDovizFiyati, (tbStokFisiDetayi.lBrutTutar)* (100 + tbStokFisiDetayi.nKdvOrani) / 100  lDahilDovizTutar, (tbStokFisiDetayi.lBrutFiyat)* (100 + tbStokFisiDetayi.nKdvOrani) / 100 lDahilDovizFiyati,tbStokFisiMaster.lKdv1,tbStokFisiMaster.lKdv2,tbStokFisiMaster.lKdv3,tbStokFisiMaster.lKdv4,tbStokFisiMaster.lKdv5 FROM tbStokFisiDetayi INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID INNER JOIN tbRenk ON tbStok.sRenk = tbRenk.sRenk INNER JOIN tbStokBarkodu ON tbStok.nStokID = tbStokBarkodu.nStokID AND tbStokBarkodu.nKisim = 0  INNER JOIN   tbStokFisiMaster ON tbStokFisiDetayi.nStokFisiID = tbStokFisiMaster.nStokFisiID WHERE     (tbStokFisiDetayi.nStokFisiID = '"), dataRow.Item("nStokFisiID")), "') ORDER BY tbStokFisiDetayi.nIslemID")), "TABLE1")
                                Dim num21 As New Decimal
                                Dim num20 As New Decimal
                                Dim num22 As New Decimal
                                Dim num23 As Decimal = KeyCode.sorgu_sayi(RuntimeHelpers.GetObjectValue(dataRow.Item("lNetTutar")), Decimal.Zero)
                                Dim num15 As New Decimal
                                Dim num16 As New Decimal
                                Dim num17 As New Decimal
                                Dim num18 As New Decimal
                                Dim num19 As New Decimal
                                If Operators.ConditionalCompareObjectEqual(dataRow.Item("nGirisCikis"), 1, False) Then
                                    num21 = New Decimal
                                    num20 = Math.Abs(num23)
                                ElseIf Operators.ConditionalCompareObjectEqual(dataRow.Item("nGirisCikis"), 2, False) Then
                                    num21 = Math.Abs(num23)
                                    num20 = New Decimal
                                ElseIf Operators.ConditionalCompareObjectEqual(dataRow.Item("nGirisCikis"), 3, False) Then
                                    num21 = Math.Abs(num23)
                                    num20 = New Decimal
                                ElseIf Operators.ConditionalCompareObjectEqual(dataRow.Item("nGirisCikis"), 4, False) Then
                                    num21 = New Decimal
                                    num20 = Math.Abs(num23)
                                End If
                                str4 = Me.sorgula_logo_string("Select LOWER(NEWID())")
                                fat_RECid = Me.sorgula_Mikro_string("DECLARE @FAT int; SET @FAT = (SELECT ISNULL(MAX(sip_RECid_RECno),'') + 1 from SIPARISLER )SELECT @FAT AS 'FAT'")
                                num9 = 0
                                Try
                                    enumerator = DirectCast(NewLateBinding.LateGet(NewLateBinding.LateGet(obj2, Nothing, "Tables", New Object() {0}, Nothing, Nothing, Nothing), Nothing, "Rows", New Object(0 - 1) {}, Nothing, Nothing, Nothing), IEnumerable).GetEnumerator
                                    Do While enumerator.MoveNext
                                        Dim obj5 As Object
                                        current = DirectCast(enumerator.Current, DataRow)
                                        If current.Item("sAciklama").ToString.Contains("+") Then
                                            Dim strArray2 As String() = current.Item("sAciklama").ToString.Split(New Char() {"+"c})
                                            Try
                                                current.Item("ISK1") = strArray2(0)
                                            Catch exception1 As Exception
                                                ProjectData.SetProjectError(exception1)
                                                Dim exception As Exception = exception1
                                                current.Item("ISK1") = 0
                                                ProjectData.ClearProjectError()
                                            End Try
                                            Try
                                                current.Item("ISK2") = strArray2(1)
                                            Catch exception7 As Exception
                                                ProjectData.SetProjectError(exception7)
                                                Dim exception2 As Exception = exception7
                                                current.Item("ISK2") = 0
                                                ProjectData.ClearProjectError()
                                            End Try
                                            Try
                                                current.Item("ISK3") = strArray2(2)
                                            Catch exception8 As Exception
                                                ProjectData.SetProjectError(exception8)
                                                Dim exception3 As Exception = exception8
                                                current.Item("ISK3") = 0
                                                ProjectData.ClearProjectError()
                                            End Try
                                            Try
                                                current.Item("ISK4") = strArray2(3)
                                            Catch exception9 As Exception
                                                ProjectData.SetProjectError(exception9)
                                                Dim exception4 As Exception = exception9
                                                current.Item("ISK4") = 0
                                                ProjectData.ClearProjectError()
                                            End Try
                                            Try
                                                current.Item("ISK5") = strArray2(4)
                                            Catch exception10 As Exception
                                                ProjectData.SetProjectError(exception10)
                                                Dim exception5 As Exception = exception10
                                                current.Item("ISK5") = 0
                                                ProjectData.ClearProjectError()
                                            End Try
                                        End If
                                        Dim str12 As String = ""
                                        If Operators.ConditionalCompareObjectEqual(current.Item("nIskontoYuzdesi"), 0, False) Then
                                            current.Item("sAciklama") = ""
                                        Else
                                            If Operators.ConditionalCompareObjectNotEqual(current.Item("ISK1"), 0, False) Then
                                                str12 = (str12 & Me.uzunluk_tamamla(FormatNumber(RuntimeHelpers.GetObjectValue(current.Item("ISK1")), 2, TriState.UseDefault, TriState.UseDefault, TriState.UseDefault), 5, "0") & "+")
                                            End If
                                            If Operators.ConditionalCompareObjectNotEqual(current.Item("ISK2"), 0, False) Then
                                                str12 = (str12 & Me.uzunluk_tamamla(FormatNumber(RuntimeHelpers.GetObjectValue(current.Item("ISK2")), 2, TriState.UseDefault, TriState.UseDefault, TriState.UseDefault), 5, "0"))
                                            End If
                                            If Operators.ConditionalCompareObjectNotEqual(current.Item("ISK3"), 0, False) Then
                                                str12 = (str12 & "+" & Me.uzunluk_tamamla(FormatNumber(RuntimeHelpers.GetObjectValue(current.Item("ISK3")), 2, TriState.UseDefault, TriState.UseDefault, TriState.UseDefault), 5, "0"))
                                            End If
                                            If Operators.ConditionalCompareObjectNotEqual(current.Item("ISK4"), 0, False) Then
                                                str12 = (str12 & "+" & Me.uzunluk_tamamla(FormatNumber(RuntimeHelpers.GetObjectValue(current.Item("ISK4")), 2, TriState.UseDefault, TriState.UseDefault, TriState.UseDefault), 5, "0"))
                                            End If
                                            If (Decimal.Compare(KeyCode.sorgu_sayi(RuntimeHelpers.GetObjectValue(current.Item("ISK5")), Decimal.Zero), Decimal.Zero) <> 0) Then
                                                str12 = (str12 & "+" & Me.uzunluk_tamamla(FormatNumber(RuntimeHelpers.GetObjectValue(current.Item("ISK5")), 2, TriState.UseDefault, TriState.UseDefault, TriState.UseDefault), 5, "0"))
                                            End If
                                            current.Item("sAciklama") = str12
                                        End If
                                        sTK = Trim(Conversions.ToString(current.Item("sStokKodu")))
                                        sTA = Trim(Conversions.ToString(current.Item("sStokAciklama")))
                                        num8 = Conversions.ToDecimal(current.Item("nKdvOrani"))
                                        num11 = Me.sorgula_Mikro_nStokID(Me.sorgu_query(("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(sto_RECno, 0) AS STOCKF  FROM         STOKLAR WHERE     (sto_kod = '" & sTK & "')")))
                                        If ((num11 = 0) Or (num11 = 1)) Then
                                            str9 = Me.sorgula_Mikro_string("Select LOWER(NEWID())")
                                            stok_RECid = Me.sorgula_Mikro_string("DECLARE @STOK int; SET @STOK = (SELECT ISNULL(MAX(sto_RECid_RECno),'') + 1 from STOKLAR)SELECT @STOK AS 'STOK'")
                                            Dim birim1 As String = Trim(Conversions.ToString(current.Item("sBirimCinsi1")))
                                            Dim birim2 As String = Trim(Conversions.ToString(current.Item("sBirimCinsi2")))
                                            Dim lKdvOranix As String = Trim(Conversions.ToString(current.Item("nKdvOrani")))
                                            If lKdvOranix = "8.00" Then
                                                lKdvOranix = "3"
                                            ElseIf lKdvOranix = "18.00" Then
                                                lKdvOranix = "4"
                                            End If

                                            If birim1 = "AD" Then
                                                birim1 = "ADET"
                                            ElseIf birim1 = "KO" Then
                                                birim1 = "KOLİ"
                                            ElseIf birim1 = "PL" Then
                                                birim1 = "PALET"
                                            End If
                                            'If birim2 = birim1 Then
                                            '    birim2 = ""
                                            'ElseIf birim2 = "AD" Then
                                            '    birim2 = "ADET"
                                            'ElseIf birim2 = "KO" Then
                                            '    birim2 = "KOLİ"
                                            'ElseIf birim2 = "PL" Then
                                            '    birim2 = "PALET"
                                            'ElseIf birim2 = birim1 Then
                                            '    birim2 = ""
                                            'End If
                                            num11 = Me.STOK_kaydet_yeni_Mikro(num11, 0, stok_RECid, 0, 0, 13, 0, 0, 0, 0, 1, Conversions.ToDate(current.Item("dteFisTarihi")), 1, Conversions.ToDate(current.Item("dteFisTarihi")), 0, 0, 0, sTK, sTA, "''", sTA, 0, 0, 0, 0, birim1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 153, 153, 600, 610, 611, 153, 621, 601, 153, 258, 600, 621, 600, 610, 611, 600, 621, 621, 760, 0, 0, 0, 0, 0, 0, 0, lKdvOranix, lKdvOranix, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "'()'", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 90.0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0)
                                            sth_RECno = Me.sorgula_Mikro_string("DECLARE @sth_RECno int; SET @sth_RECno = (SELECT ISNULL(MAX(sth_RECno),'') from STOK_HAREKETLERI)SELECT @sth_RECno AS sth_RECno")
                                        Else
                                            str9 = Me.sorgula_Mikro_string(("Select sto_RECno from STOKLAR WHERE sto_kod = '" & sTK & "'"))
                                        End If
                                        Dim mIKTAR As New Decimal
                                        Dim num26 As New Decimal
                                        Dim num27 As New Decimal
                                        Dim num33 As New Decimal
                                        Dim num31 As New Decimal
                                        Dim kARTDOVIZTUTAR As New Decimal
                                        Dim num29 As New Decimal
                                        Dim str11 As String = Conversions.ToString(current.Item("sAciklama"))
                                        Dim left As New Decimal
                                        Dim num24 As Long = 0

                                        Try
                                            obj5 = KeyCode.sorgu_sayi(RuntimeHelpers.GetObjectValue(current.Item("sDepo")), Decimal.Zero)
                                        Catch exception11 As Exception
                                            ProjectData.SetProjectError(exception11)
                                            Dim exception6 As Exception = exception11
                                            obj5 = 1
                                            ProjectData.ClearProjectError()
                                        End Try
                                        Dim strArray As String() = current.Item("sKisaAdi").ToString.Split(New Char() {";"c})
                                        num24 = 0
                                        If Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(current.Item("nGirisCikis"), 1, False), Operators.CompareObjectEqual(current.Item("nGirisCikis"), 2, False))) Then
                                            mIKTAR = Conversions.ToDecimal(current.Item("lGirisMiktar1"))
                                            num26 = Conversions.ToDecimal(current.Item("lBrutFiyat"))
                                            num27 = Conversions.ToDecimal(current.Item("lBrutTutar"))
                                            num33 = Conversions.ToDecimal(current.Item("nIskontoYuzdesi"))
                                            num31 = Conversions.ToDecimal(current.Item("lIskontoTutari"))
                                            kARTDOVIZTUTAR = Conversions.ToDecimal(current.Item("lGirisFiyat"))
                                            num29 = Conversions.ToDecimal(current.Item("lGirisTutar"))
                                            left = Conversions.ToDecimal(current.Item("lGirisTutar"))
                                            KeyCode.sSaticiRumuzu = current.Item("sSaticiRumuzu").ToString
                                        ElseIf Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(current.Item("nGirisCikis"), 3, False), Operators.CompareObjectEqual(current.Item("nGirisCikis"), 4, False))) Then
                                            mIKTAR = Conversions.ToDecimal(current.Item("lCikisMiktar1"))
                                            num26 = Conversions.ToDecimal(current.Item("lBrutFiyat"))
                                            num27 = Conversions.ToDecimal(current.Item("lBrutTutar"))
                                            num33 = Conversions.ToDecimal(current.Item("nIskontoYuzdesi"))
                                            num31 = Conversions.ToDecimal(current.Item("lIskontoTutari"))
                                            kARTDOVIZTUTAR = Conversions.ToDecimal(current.Item("lCikisFiyat"))
                                            num29 = Conversions.ToDecimal(current.Item("lCikisTutar"))
                                            left = Conversions.ToDecimal(current.Item("lCikisTutar"))
                                            KeyCode.sSaticiRumuzu = current.Item("sSaticiRumuzu").ToString
                                        End If
                                        Dim lKdvOrani1 As String = Trim(Conversions.ToString(current.Item("nKdvOrani")))
                                        If lKdvOrani1 = "8.00" Then
                                            lKdvOrani1 = "3"
                                        ElseIf lKdvOrani1 = "18.00" Then
                                            lKdvOrani1 = "4"
                                        End If
                                        Dim CRK1 As String = dataRow.Item("sKodu").ToString
                                        Dim BYE As String = "BYE"
                                        CRK1 = CRK1.TrimEnd
                                        Dim obj3 As Object = Me.sorgula_Mikro_string("Select LOWER(NEWID())")
                                        numM = Me.sorgula_Mikro_string("DECLARE @numM int; SET @numM = (SELECT ISNULL(MAX(sth_RECno),'') + 1 from STOK_HAREKETLERI)SELECT @numM AS 'numM'")
                                        'fATREF = Me.FATURA1_kaydet_yeni_Mikro(0, fat_RECid, Conversions.ToString(dataRow.Item("nFirmaID")), 0, 16, 0, 0, 0, 0, 1, Conversions.ToDate(dataRow.Item("dteFisTarihi")), 1, Conversions.ToDate(dataRow.Item("dteKayitTarihi")), "''", "''", "''", 0, 0, Conversions.ToDate(dataRow.Item("dteFisTarihi")), nGirisCikis, 0, normal_iade, tURAC, 0, Conversions.ToString(dataRow.Item("lFisNo")), num9, Conversions.ToString(dataRow.Item("lFisNo")), Conversions.ToDate(dataRow.Item("dteFisTarihi")), sTK, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, Conversions.ToString(dataRow.Item("sKodu")), 0, "''", "''", 0, 1.0, 1.0, 0, 1.0, mIKTAR, 0, 1, Conversions.ToDecimal(current.Item("lBrutTutar")), Conversions.ToDecimal(current.Item("lIskontoTutari")), 0, 0, 0, 0, 0, 0, 0, 0, 0, 4, Conversions.ToDecimal(current.Item("lKdvTutari")), 0, 0, 0, 0, "''", 0, 0, 0, 0, 0, 1, Conversions.ToDate(dataRow.Item("dteKayitTarihi")), "''", "''", Conversions.ToDate(dataRow.Item("dteKayitTarihi")), 0, 0, 0, 0, 0, 1, "''", 0, 0, 0, "''", "''", 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0)
                                        'fATREF = Me.FATURA1_kaydet_yeni_Mikro(0, fat_RECid, 0, 0, 21, 0, 0, 0, 0, 1, Conversions.ToDate(dataRow.Item("dteFisTarihi")), 1, Conversions.ToDate(dataRow.Item("dteFisTarihi")), "''", "''", "''", 0, 0, Conversions.ToDate(dataRow.Item("dteKayitTarihi")), Conversions.ToDate(dataRow.Item("dteKayitTarihi")), 0, 0, 0, 1, 0, Conversions.ToString(dataRow.Item("lFisNo")), Conversions.ToDate(dataRow.Item("dteKayitTarihi")), 0, Conversions.ToString(dataRow.Item("nFirmaID")), sTK, Conversions.ToDecimal(current.Item("lBrutFiyat")), mIKTAR, 1, 0, Conversions.ToDecimal(current.Item("lBrutTutar")), 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 4, Conversions.ToDecimal(current.Item("lKdvTutari")), 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1.0, 1.0, 1, 0, 1, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, Conversions.ToDate(dataRow.Item("dteKayitTarihi")), 0, 0, 0, 0, 0)
                                        fATREF = Me.FATURA1_kaydet_yeni_Mikro(0, fat_RECid, 0, 0, 21, 0, 0, 0, 0, 1, Conversions.ToDate(dataRow.Item("dteKayitTarihi")), 1, Conversions.ToDate(dataRow.Item("dteKayitTarihi")), BYE, 0, 0, 0, 0, Conversions.ToDate(dataRow.Item("dteFisTarihi")), Conversions.ToDate(dataRow.Item("dteFisTarihi")), sip_Tip, 0, 0, Conversions.ToString(dataRow.Item("nEvrakNo")), num9, Conversions.ToString(dataRow.Item("nEvrakNo")), Conversions.ToDate(dataRow.Item("dteFisTarihi")), 0, CRK1, sTK, Conversions.ToDecimal(current.Item("lBrutFiyat")), mIKTAR, 1, 0, Conversions.ToDecimal(current.Item("lBrutTutar")), num33, 0, 0, 0, 0, 0, 0, 0, 0, 0, lKdvOrani1, Conversions.ToDecimal(current.Item("lKdvTutari")), 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1.0, 1.0, 1, 0, 1, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, Conversions.ToDate(dataRow.Item("dteKayitTarihi")), 0, 0, 0, 0, 0)
                                        fat_RECid = Me.sorgula_Mikro_string("DECLARE @FAT int; SET @FAT = (SELECT ISNULL(MAX(sip_RECid_RECno),'') + 1 from SIPARISLER)SELECT @FAT AS 'FAT'")
                                        num9 += 1
                                    Loop
                                Finally
                                    If TypeOf enumerator Is IDisposable Then
                                        TryCast(enumerator, IDisposable).Dispose()
                                    End If
                                End Try
                            End If
                        Next
                        XtraMessageBox.Show(KeyCode.Sorgu_sDil("İşlem Başarıyla Tamamlandı...", KeyCode.sDil), KeyCode.Sorgu_sDil("Dikkat", KeyCode.sDil), MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                        Me.bar1.Visible = False
                    End If
                    current = Nothing
                End If
            End If
            Me.sCon.Close()
            Me.connection = RuntimeHelpers.GetObjectValue(objectValue)
            KeyCode.sConnection = Conversions.ToString(sConnection)
        End If
    End Sub
    '************* Zirve Entegre  Zirve Entegre  Zirve Entegre ************

    Public Function sorgula_logo_nStokID(ByVal query As String) As Long
        Try
            If (Me.sCon.State = ConnectionState.Closed) Then
                Me.sCon.Open()
            End If
        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            Dim exception As Exception = exception1
            Me.sCon.Close()
            Me.sCon.Open()
            ProjectData.ClearProjectError()
        End Try
        Me.sCmd.CommandText = query
        Return Conversions.ToLong(RuntimeHelpers.GetObjectValue(Me.sCmd.ExecuteScalar))
    End Function
    Public Function sorgula_logo_string(ByVal query As String) As String
        Try
            If (Me.sCon.State = ConnectionState.Closed) Then
                Me.sCon.Open()
            End If
        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            Dim exception As Exception = exception1
            Me.sCon.Close()
            Me.sCon.Open()
            ProjectData.ClearProjectError()
        End Try
        Me.sCmd.CommandText = query
        Return Conversions.ToString(RuntimeHelpers.GetObjectValue(Me.sCmd.ExecuteScalar))
    End Function

    Private Function STFICHE_kaydet_yeni(ByVal LOGICALREF As Object, ByVal GRPCODE As Object, ByVal TRCODE As Object, ByVal IOCODE As Object, ByVal FICHENO As Object, ByVal DATE_ As Object, ByVal FTIME As Object, ByVal DOCODE As Object, ByVal INVNO As Object, ByVal SPECODE As Object, ByVal CYPHCODE As Object, ByVal INVOICEREF As Object, ByVal CLIENTREF As Object, ByVal RECVREF As Object, ByVal ACCOUNTREF As Object, ByVal CENTERREF As Object, ByVal PRODORDERREF As Object, ByVal PORDERFICHENO As Object, ByVal SOURCETYPE As Object, ByVal SOURCEINDEX As Object, ByVal SOURCEWSREF As Object, ByVal SOURCEPOLNREF As Object, ByVal SOURCECOSTGRP As Object, ByVal DESTTYPE As Object, ByVal DESTINDEX As Object, ByVal DESTWSREF As Object, ByVal DESTPOLNREF As Object, ByVal DESTCOSTGRP As Object, ByVal FACTORYNR As Object, ByVal BRANCH As Object, ByVal DEPARTMENT As Object, ByVal COMPBRANCH As Object, ByVal COMPDEPARTMENT As Object, ByVal COMPFACTORY As Object, ByVal PRODSTAT As Object, ByVal DEVIR As Object, ByVal CANCELLED As Object, ByVal BILLED As Object, ByVal ACCOUNTED As Object, ByVal UPDCURR As Object, ByVal INUSE As Object, ByVal INVKIND As Object, ByVal ADDDISCOUNTS As Object, ByVal TOTALDISCOUNTS As Object, ByVal TOTALDISCOUNTED As Object, ByVal ADDEXPENSES As Object, ByVal TOTALEXPENSES As Object, ByVal TOTALDEPOZITO As Object, ByVal TOTALPROMOTIONS As Object, ByVal TOTALVAT As Object, ByVal GROSSTOTAL As Object, ByVal NETTOTAL As Object, ByVal GENEXP1 As Object, ByVal GENEXP2 As Object, ByVal GENEXP3 As Object, ByVal GENEXP4 As Object, ByVal REPORTRATE As Object, ByVal REPORTNET As Object, ByVal EXTENREF As Object, ByVal PAYDEFREF As Object, ByVal PRINTCNT As Object, ByVal FICHECNT As Object, ByVal ACCFICHEREF As Object, ByVal CAPIBLOCK_CREATEDBY As Object, ByVal CAPIBLOCK_CREADEDDATE As Object, ByVal CAPIBLOCK_CREATEDHOUR As Object, ByVal CAPIBLOCK_CREATEDMIN As Object, ByVal CAPIBLOCK_CREATEDSEC As Object, ByVal CAPIBLOCK_MODIFIEDBY As Object, ByVal CAPIBLOCK_MODIFIEDDATE As Object, ByVal CAPIBLOCK_MODIFIEDHOUR As Object, ByVal CAPIBLOCK_MODIFIEDMIN As Object, ByVal CAPIBLOCK_MODIFIEDSEC As Object, ByVal SALESMANREF As Object, ByVal CANCELLEDACC As Object, ByVal SHPTYPCOD As Object, ByVal SHPAGNCOD As Object, ByVal TRACKNR As Object, ByVal GENEXCTYP As Object, ByVal LINEEXCTYP As Object, ByVal TRADINGGRP As Object, ByVal TEXTINC As Object, ByVal SITEID As Object, ByVal RECSTATUS As Object, ByVal ORGLOGICREF As Object, ByVal WFSTATUS As Object, ByVal SHIPINFOREF As Object, ByVal DISTORDERREF As Object, ByVal SENDCNT As Object, ByVal DLVCLIENT As Object, ByVal DOCTRACKINGNR As Object, ByVal ADDTAXCALC As Object, ByVal TOTALADDTAX As Object, ByVal UGIRTRACKINGNO As Object, ByVal QPRODFCREF As Object, ByVal VAACCREF As Object, ByVal VACENTERREF As Object, ByVal ORGLOGOID As Object, ByVal FROMEXIM As Object, ByVal FRGTYPCOD As Object, ByVal TRCURR As Object, ByVal TRRATE As Object, ByVal TRNET As Object, ByVal EXIMWHFCREF As Object, ByVal EXIMFCTYPE As Object, ByVal MAINSTFCREF As Object, ByVal FROMORDWITHPAY As Object, ByVal PROJECTREF As Object, ByVal WFLOWCRDREF As Object, ByVal STATUS As Object, ByVal UPDTRCURR As Object, ByVal TOTALEXADDTAX As Object, ByVal AFFECTCOLLATRL As Object, ByVal DEDUCTIONPART1 As Object, ByVal DEDUCTIONPART2 As Object, ByVal GRPFIRMTRANS As Object, ByVal AFFECTRISK As Object, ByVal DISPSTATUS As Object, ByVal APPROVE As Object, ByVal CANTCREDEDUCT As Object) As Long
        Try
            If (Me.sCon.State = ConnectionState.Closed) Then
                Me.sCon.Open()
            End If
        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            Dim exception As Exception = exception1
            Me.sCon.Close()
            Me.sCon.Open()
            ProjectData.ClearProjectError()
        End Try
        Me.sCmd.CommandText = Me.sorgu_query(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED  SET DATEFORMAT DMY INSERT INTO LG_*!F_!D_STFICHE(GRPCODE, TRCODE, IOCODE, FICHENO, DATE_, FTIME, DOCODE, INVNO, SPECODE, CYPHCODE, INVOICEREF, CLIENTREF, RECVREF, ACCOUNTREF, CENTERREF, PRODORDERREF, PORDERFICHENO, SOURCETYPE, SOURCEINDEX, SOURCEWSREF, SOURCEPOLNREF, SOURCECOSTGRP, DESTTYPE, DESTINDEX, DESTWSREF, DESTPOLNREF, DESTCOSTGRP, FACTORYNR, BRANCH, DEPARTMENT, COMPBRANCH, COMPDEPARTMENT, COMPFACTORY, PRODSTAT, DEVIR, CANCELLED, BILLED, ACCOUNTED, UPDCURR, INUSE, INVKIND, ADDDISCOUNTS, TOTALDISCOUNTS, TOTALDISCOUNTED, ADDEXPENSES, TOTALEXPENSES, TOTALDEPOZITO, TOTALPROMOTIONS, TOTALVAT, GROSSTOTAL, NETTOTAL, GENEXP1, GENEXP2, GENEXP3, GENEXP4, REPORTRATE, REPORTNET, EXTENREF, PAYDEFREF, PRINTCNT, FICHECNT, ACCFICHEREF, CAPIBLOCK_CREATEDBY, CAPIBLOCK_CREADEDDATE, CAPIBLOCK_CREATEDHOUR, CAPIBLOCK_CREATEDMIN, CAPIBLOCK_CREATEDSEC, CAPIBLOCK_MODIFIEDBY, CAPIBLOCK_MODIFIEDDATE, CAPIBLOCK_MODIFIEDHOUR, CAPIBLOCK_MODIFIEDMIN, CAPIBLOCK_MODIFIEDSEC, SALESMANREF, CANCELLEDACC, SHPTYPCOD, SHPAGNCOD, TRACKNR, GENEXCTYP, LINEEXCTYP, TRADINGGRP, TEXTINC, SITEID, RECSTATUS, ORGLOGICREF, WFSTATUS, SHIPINFOREF, DISTORDERREF, SENDCNT, DLVCLIENT, DOCTRACKINGNR, ADDTAXCALC, TOTALADDTAX, UGIRTRACKINGNO, QPRODFCREF, VAACCREF, VACENTERREF, ORGLOGOID, FROMEXIM, FRGTYPCOD, TRCURR, TRRATE, TRNET, EXIMWHFCREF, EXIMFCTYPE, MAINSTFCREF, FROMORDWITHPAY, PROJECTREF, WFLOWCRDREF, STATUS, UPDTRCURR, TOTALEXADDTAX, AFFECTCOLLATRL, DEDUCTIONPART1, DEDUCTIONPART2, GRPFIRMTRANS, AFFECTRISK, DISPSTATUS, APPROVE, CANTCREDEDUCT) VALUES (", GRPCODE), ","), TRCODE), ", "), IOCODE), ", '"), FICHENO), "', '"), DATE_), "', "), FTIME), ", '"), DOCODE), "', '"), INVNO), "', '"), SPECODE), "', '"), CYPHCODE), "', "), INVOICEREF), ", "), CLIENTREF), ", "), RECVREF), ", "), ACCOUNTREF), ", "), CENTERREF), ", "), PRODORDERREF), ", '"), PORDERFICHENO), "', "), SOURCETYPE), ", "), SOURCEINDEX), ", "), SOURCEWSREF), ", "), SOURCEPOLNREF), ", "), SOURCECOSTGRP), ", "), DESTTYPE), ", "), DESTINDEX), ", "), DESTWSREF), ", "), DESTPOLNREF), ", "), DESTCOSTGRP), ", "), FACTORYNR), ", "), BRANCH), ", "), DEPARTMENT), ", "), COMPBRANCH), ", "), COMPDEPARTMENT), ", "), COMPFACTORY), ", "), PRODSTAT), ", "), DEVIR), ", "), CANCELLED), ", "), BILLED), ", "), ACCOUNTED), ", "), UPDCURR), ", "), INUSE), ", "), INVKIND), ", "), ADDDISCOUNTS), ", "), TOTALDISCOUNTS), ", "), TOTALDISCOUNTED), ", "), ADDEXPENSES), ", "), TOTALEXPENSES), ", "), TOTALDEPOZITO), ", "), TOTALPROMOTIONS), ", "), TOTALVAT), ", "), GROSSTOTAL), ", "), NETTOTAL), ", '"), GENEXP1), "', '"), GENEXP2), "', '"), GENEXP3), "', '"), GENEXP4), "', "), REPORTRATE), ", "), REPORTNET), ", "), EXTENREF), ", "), PAYDEFREF), ", "), PRINTCNT), ", "), FICHECNT), ", "), ACCFICHEREF), ", "), CAPIBLOCK_CREATEDBY), ", '"), CAPIBLOCK_CREADEDDATE), "', "), CAPIBLOCK_CREATEDHOUR), ", "), CAPIBLOCK_CREATEDMIN), ", "), CAPIBLOCK_CREATEDSEC), ", "), CAPIBLOCK_MODIFIEDBY), ", '"), CAPIBLOCK_MODIFIEDDATE), "', "), CAPIBLOCK_MODIFIEDHOUR), ", "), CAPIBLOCK_MODIFIEDMIN), ", "), CAPIBLOCK_MODIFIEDSEC), ", "), SALESMANREF), ", "), CANCELLEDACC), ", '"), SHPTYPCOD), "', '"), SHPAGNCOD), "', '"), TRACKNR), "', "), GENEXCTYP), ", "), LINEEXCTYP), ", '"), TRADINGGRP), "', "), TEXTINC), ", "), SITEID), ", "), RECSTATUS), ", "), ORGLOGICREF), ", "), WFSTATUS), ", "), SHIPINFOREF), ", "), DISTORDERREF), ", "), SENDCNT), ", "), DLVCLIENT), ", '"), DOCTRACKINGNR), "', "), ADDTAXCALC), ", "), TOTALADDTAX), ", '"), UGIRTRACKINGNO), "', "), QPRODFCREF), ", "), VAACCREF), ", "), VACENTERREF), ", '"), ORGLOGOID), "', "), FROMEXIM), ", '"), FRGTYPCOD), "', "), TRCURR), ", "), TRRATE), ", "), TRNET), ", "), EXIMWHFCREF), ", "), EXIMFCTYPE), ", "), MAINSTFCREF), ", "), FROMORDWITHPAY), ", "), PROJECTREF), ", "), WFLOWCRDREF), ", "), STATUS), ", "), UPDTRCURR), ", "), TOTALEXADDTAX), ", "), AFFECTCOLLATRL), ", "), DEDUCTIONPART1), ", "), DEDUCTIONPART2), ", "), GRPFIRMTRANS), ", "), AFFECTRISK), ", "), DISPSTATUS), ", "), APPROVE), ", "), CANTCREDEDUCT), ")")))
        Me.sCmd.ExecuteNonQuery()
        Me.sCmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        LOGICALREF = RuntimeHelpers.GetObjectValue(Me.sCmd.ExecuteScalar)
        Return Conversions.ToLong(LOGICALREF)
    End Function

    Private Function STLINE_kaydet_yeni(ByVal LOGICALREF As Object, ByVal STOCKREF As Object, ByVal LINETYPE As Object, ByVal PREVLINEREF As Object, ByVal PREVLINENO As Object, ByVal DETLINE As Object, ByVal TRCODE As Object, ByVal DATE_ As Object, ByVal FTIME As Object, ByVal GLOBTRANS As Object, ByVal CALCTYPE As Object, ByVal PRODORDERREF As Object, ByVal SOURCETYPE As Object, ByVal SOURCEINDEX As Object, ByVal SOURCECOSTGRP As Object, ByVal SOURCEWSREF As Object, ByVal SOURCEPOLNREF As Object, ByVal DESTTYPE As Object, ByVal DESTINDEX As Object, ByVal DESTCOSTGRP As Object, ByVal DESTWSREF As Object, ByVal DESTPOLNREF As Object, ByVal FACTORYNR As Object, ByVal IOCODE As Object, ByVal STFICHEREF As Object, ByVal STFICHELNNO As Object, ByVal INVOICEREF As Object, ByVal INVOICELNNO As Object, ByVal CLIENTREF As Object, ByVal ORDTRANSREF As Object, ByVal ORDFICHEREF As Object, ByVal CENTERREF As Object, ByVal ACCOUNTREF As Object, ByVal VATACCREF As Object, ByVal VATCENTERREF As Object, ByVal PRACCREF As Object, ByVal PRCENTERREF As Object, ByVal PRVATACCREF As Object, ByVal PRVATCENREF As Object, ByVal PROMREF As Object, ByVal PAYDEFREF As Object, ByVal SPECODE As Object, ByVal DELVRYCODE As Object, ByVal AMOUNT As Object, ByVal PRICE As Object, ByVal TOTAL As Object, ByVal PRCURR As Object, ByVal PRPRICE As Object, ByVal TRCURR As Object, ByVal TRRATE As Object, ByVal REPORTRATE As Object, ByVal DISTCOST As Object, ByVal DISTDISC As Object, ByVal DISTEXP As Object, ByVal DISTPROM As Object, ByVal DISCPER As Object, ByVal LINEEXP As Object, ByVal UOMREF As Object, ByVal USREF As Object, ByVal UINFO1 As Object, ByVal UINFO2 As Object, ByVal UINFO3 As Object, ByVal UINFO4 As Object, ByVal UINFO5 As Object, ByVal UINFO6 As Object, ByVal UINFO7 As Object, ByVal UINFO8 As Object, ByVal PLNAMOUNT As Object, ByVal VATINC As Object, ByVal VAT As Object, ByVal VATAMNT As Object, ByVal VATMATRAH As Object, ByVal BILLEDITEM As Object, ByVal BILLED As Object, ByVal CPSTFLAG As Object, ByVal RETCOSTTYPE As Object, ByVal SOURCELINK As Object, ByVal RETCOST As Object, ByVal RETCOSTCURR As Object, ByVal OUTCOST As Object, ByVal OUTCOSTCURR As Object, ByVal RETAMOUNT As Object, ByVal FAREGREF As Object, ByVal FAATTRIB As Object, ByVal CANCELLED As Object, ByVal LINENET As Object, ByVal DISTADDEXP As Object, ByVal FADACCREF As Object, ByVal FADCENTERREF As Object, ByVal FARACCREF As Object, ByVal FARCENTERREF As Object, ByVal DIFFPRICE As Object, ByVal DIFFPRCOST As Object, ByVal DECPRDIFF As Object, ByVal LPRODSTAT As Object, ByVal PRDEXPTOTAL As Object, ByVal DIFFREPPRICE As Object, ByVal DIFFPRCRCOST As Object, ByVal SALESMANREF As Object, ByVal FAPLACCREF As Object, ByVal FAPLCENTERREF As Object, ByVal OUTPUTIDCODE As Object, ByVal DREF As Object, ByVal COSTRATE As Object, ByVal XPRICEUPD As Object, ByVal XPRICE As Object, ByVal XREPRATE As Object, ByVal DISTCOEF As Object, ByVal TRANSQCOK As Object, ByVal SITEID As Object, ByVal RECSTATUS As Object, ByVal ORGLOGICREF As Object, ByVal WFSTATUS As Object, ByVal POLINEREF As Object, ByVal PLNSTTRANSREF As Object, ByVal NETDISCFLAG As Object, ByVal NETDISCPERC As Object, ByVal NETDISCAMNT As Object, ByVal VATCALCDIFF As Object, ByVal CONDITIONREF As Object, ByVal DISTORDERREF As Object, ByVal DISTORDLINEREF As Object, ByVal CAMPAIGNREFS1 As Object, ByVal CAMPAIGNREFS2 As Object, ByVal CAMPAIGNREFS3 As Object, ByVal CAMPAIGNREFS4 As Object, ByVal CAMPAIGNREFS5 As Object, ByVal POINTCAMPREF As Object, ByVal CAMPPOINT As Object, ByVal PROMCLASITEMREF As Object, ByVal CMPGLINEREF As Object, ByVal PLNSTTRANSPERNR As Object, ByVal PORDCLSPLNAMNT As Object, ByVal VENDCOMM As Object, ByVal PREVIOUSOUTCOST As Object, ByVal COSTOFSALEACCREF As Object, ByVal PURCHACCREF As Object, ByVal COSTOFSALECNTREF As Object, ByVal PURCHCENTREF As Object, ByVal PREVOUTCOSTCURR As Object, ByVal ABVATAMOUNT As Object, ByVal ABVATSTATUS As Object, ByVal PRRATE As Object, ByVal ADDTAXRATE As Object, ByVal ADDTAXCONVFACT As Object, ByVal ADDTAXAMOUNT As Object, ByVal ADDTAXPRCOST As Object, ByVal ADDTAXRETCOST As Object, ByVal ADDTAXRETCOSTCURR As Object, ByVal GROSSUINFO1 As Object, ByVal GROSSUINFO2 As Object, ByVal ADDTAXPRCOSTCURR As Object, ByVal ADDTAXACCREF As Object, ByVal ADDTAXCENTERREF As Object, ByVal ADDTAXAMNTISUPD As Object, ByVal INFIDX As Object, ByVal ADDTAXCOSACCREF As Object, ByVal ADDTAXCOSCNTREF As Object, ByVal PREVIOUSATAXPRCOST As Object, ByVal PREVATAXPRCOSTCURR As Object, ByVal PRDORDTOTCOEF As Object, ByVal DEMPEGGEDAMNT As Object, ByVal STDUNITCOST As Object, ByVal STDRPUNITCOST As Object, ByVal COSTDIFFACCREF As Object, ByVal COSTDIFFCENREF As Object, ByVal TEXTINC As Object, ByVal ADDTAXDISCAMOUNT As Object, ByVal ORGLOGOID As Object, ByVal EXIMFICHENO As Object, ByVal EXIMFCTYPE As Object, ByVal TRANSEXPLINE As Object, ByVal INSEXPLINE As Object, ByVal EXIMWHFCREF As Object, ByVal EXIMWHLNREF As Object, ByVal EXIMFILEREF As Object, ByVal EXIMPROCNR As Object, ByVal EISRVDSTTYP As Object, ByVal MAINSTLNREF As Object, ByVal MADEOFSHRED As Object, ByVal FROMORDWITHPAY As Object, ByVal PROJECTREF As Object, ByVal STATUS As Object, ByVal DORESERVE As Object, ByVal POINTCAMPREFS1 As Object, ByVal POINTCAMPREFS2 As Object, ByVal POINTCAMPREFS3 As Object, ByVal POINTCAMPREFS4 As Object, ByVal CAMPPOINTS1 As Object, ByVal CAMPPOINTS2 As Object, ByVal CAMPPOINTS3 As Object, ByVal CAMPPOINTS4 As Object, ByVal CMPGLINEREFS1 As Object, ByVal CMPGLINEREFS2 As Object, ByVal CMPGLINEREFS3 As Object, ByVal CMPGLINEREFS4 As Object, ByVal PRCLISTREF As Object, ByVal PORDSYMOUTLN As Object, ByVal MONTH_ As Object, ByVal YEAR_ As Object, ByVal EXADDTAXRATE As Object, ByVal EXADDTAXCONVF As Object, ByVal EXADDTAXAREF As Object, ByVal EXADDTAXCREF As Object, ByVal OTHRADDTAXAREF As Object, ByVal OTHRADDTAXCREF As Object, ByVal EXADDTAXAMNT As Object, ByVal AFFECTCOLLATRL As Object, ByVal ALTPROMFLAG As Object, ByVal EIDISTFLNNR As Object, ByVal EXIMTYPE As Object, ByVal VARIANTREF As Object, ByVal CANDEDUCT As Object, ByVal OUTREMAMNT As Object, ByVal OUTREMCOST As Object, ByVal OUTREMCOSTCURR As Object, ByVal REFLVATACCREF As Object, ByVal REFLVATOTHACCREF As Object, ByVal PARENTLNREF As Object, ByVal AFFECTRISK As Object, ByVal INEFFECTIVECOST As Object, ByVal ADDTAXVATMATRAH As Object, ByVal REFLACCREF As Object, ByVal REFLOTHACCREF As Object) As Long
        Try
            If (Me.sCon.State = ConnectionState.Closed) Then
                Me.sCon.Open()
            End If
        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            Dim exception As Exception = exception1
            Me.sCon.Close()
            Me.sCon.Open()
            ProjectData.ClearProjectError()
        End Try
        Me.sCmd.CommandText = Me.sorgu_query(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED  SET DATEFORMAT DMY INSERT INTO LG_*!F_!D_STLINE(STOCKREF, LINETYPE, PREVLINEREF, PREVLINENO, DETLINE, TRCODE, DATE_, FTIME, GLOBTRANS, CALCTYPE, PRODORDERREF, SOURCETYPE, SOURCEINDEX, SOURCECOSTGRP, SOURCEWSREF, SOURCEPOLNREF, DESTTYPE, DESTINDEX, DESTCOSTGRP, DESTWSREF, DESTPOLNREF, FACTORYNR, IOCODE, STFICHEREF, STFICHELNNO, INVOICEREF, INVOICELNNO, CLIENTREF, ORDTRANSREF, ORDFICHEREF, CENTERREF, ACCOUNTREF, VATACCREF, VATCENTERREF, PRACCREF, PRCENTERREF, PRVATACCREF, PRVATCENREF, PROMREF, PAYDEFREF, SPECODE, DELVRYCODE, AMOUNT, PRICE, TOTAL, PRCURR, PRPRICE, TRCURR, TRRATE, REPORTRATE, DISTCOST, DISTDISC, DISTEXP, DISTPROM, DISCPER, LINEEXP, UOMREF, USREF, UINFO1, UINFO2, UINFO3, UINFO4, UINFO5, UINFO6, UINFO7, UINFO8, PLNAMOUNT, VATINC, VAT, VATAMNT, VATMATRAH, BILLEDITEM, BILLED, CPSTFLAG, RETCOSTTYPE, SOURCELINK, RETCOST, RETCOSTCURR, OUTCOST, OUTCOSTCURR, RETAMOUNT, FAREGREF, FAATTRIB, CANCELLED, LINENET, DISTADDEXP, FADACCREF, FADCENTERREF, FARACCREF, FARCENTERREF, DIFFPRICE, DIFFPRCOST, DECPRDIFF, LPRODSTAT, PRDEXPTOTAL, DIFFREPPRICE, DIFFPRCRCOST, SALESMANREF, FAPLACCREF, FAPLCENTERREF, OUTPUTIDCODE, DREF, COSTRATE, XPRICEUPD, XPRICE, XREPRATE, DISTCOEF, TRANSQCOK, SITEID, RECSTATUS, ORGLOGICREF, WFSTATUS, POLINEREF, PLNSTTRANSREF, NETDISCFLAG, NETDISCPERC, NETDISCAMNT, VATCALCDIFF, CONDITIONREF, DISTORDERREF, DISTORDLINEREF, CAMPAIGNREFS1, CAMPAIGNREFS2, CAMPAIGNREFS3, CAMPAIGNREFS4, CAMPAIGNREFS5, POINTCAMPREF, CAMPPOINT, PROMCLASITEMREF, CMPGLINEREF, PLNSTTRANSPERNR, PORDCLSPLNAMNT, VENDCOMM, PREVIOUSOUTCOST, COSTOFSALEACCREF, PURCHACCREF, COSTOFSALECNTREF, PURCHCENTREF, PREVOUTCOSTCURR, ABVATAMOUNT, ABVATSTATUS, PRRATE, ADDTAXRATE, ADDTAXCONVFACT, ADDTAXAMOUNT, ADDTAXPRCOST, ADDTAXRETCOST, ADDTAXRETCOSTCURR, GROSSUINFO1, GROSSUINFO2, ADDTAXPRCOSTCURR, ADDTAXACCREF, ADDTAXCENTERREF, ADDTAXAMNTISUPD, INFIDX, ADDTAXCOSACCREF, ADDTAXCOSCNTREF, PREVIOUSATAXPRCOST, PREVATAXPRCOSTCURR, PRDORDTOTCOEF, DEMPEGGEDAMNT, STDUNITCOST, STDRPUNITCOST, COSTDIFFACCREF, COSTDIFFCENREF, TEXTINC, ADDTAXDISCAMOUNT, ORGLOGOID, EXIMFICHENO, EXIMFCTYPE, TRANSEXPLINE, INSEXPLINE, EXIMWHFCREF, EXIMWHLNREF, EXIMFILEREF, EXIMPROCNR, EISRVDSTTYP, MAINSTLNREF, MADEOFSHRED, FROMORDWITHPAY, PROJECTREF, STATUS, DORESERVE, POINTCAMPREFS1, POINTCAMPREFS2, POINTCAMPREFS3, POINTCAMPREFS4, CAMPPOINTS1, CAMPPOINTS2, CAMPPOINTS3, CAMPPOINTS4, CMPGLINEREFS1, CMPGLINEREFS2, CMPGLINEREFS3, CMPGLINEREFS4, PRCLISTREF, PORDSYMOUTLN, MONTH_, YEAR_, EXADDTAXRATE, EXADDTAXCONVF, EXADDTAXAREF, EXADDTAXCREF, OTHRADDTAXAREF, OTHRADDTAXCREF, EXADDTAXAMNT, AFFECTCOLLATRL, ALTPROMFLAG, EIDISTFLNNR, EXIMTYPE, VARIANTREF, CANDEDUCT, OUTREMAMNT, OUTREMCOST, OUTREMCOSTCURR, REFLVATACCREF, REFLVATOTHACCREF, PARENTLNREF, AFFECTRISK, INEFFECTIVECOST, ADDTAXVATMATRAH, REFLACCREF, REFLOTHACCREF) VALUES ( ", STOCKREF), " , "), LINETYPE), " , "), PREVLINEREF), " , "), PREVLINENO), " , "), DETLINE), " , "), TRCODE), " , '"), DATE_), "' , "), FTIME), " , "), GLOBTRANS), " , "), CALCTYPE), " , "), PRODORDERREF), " , "), SOURCETYPE), " , "), SOURCEINDEX), " , "), SOURCECOSTGRP), " , "), SOURCEWSREF), " , "), SOURCEPOLNREF), " , "), DESTTYPE), " , "), DESTINDEX), " , "), DESTCOSTGRP), " , "), DESTWSREF), " , "), DESTPOLNREF), " , "), FACTORYNR), " , "), IOCODE), " , "), STFICHEREF), " , "), STFICHELNNO), " , "), INVOICEREF), " , "), INVOICELNNO), " , "), CLIENTREF), " , "), ORDTRANSREF), " , "), ORDFICHEREF), " , "), CENTERREF), " , "), ACCOUNTREF), " , "), VATACCREF), " , "), VATCENTERREF), " , "), PRACCREF), " , "), PRCENTERREF), " , "), PRVATACCREF), " , "), PRVATCENREF), " , "), PROMREF), " , "), PAYDEFREF), " , '"), SPECODE), "' , '"), DELVRYCODE), "' , "), AMOUNT), " , "), PRICE), " , "), TOTAL), " , "), PRCURR), " , "), PRPRICE), " , "), TRCURR), " , "), TRRATE), " , "), REPORTRATE), " , "), DISTCOST), " , "), DISTDISC), " , "), DISTEXP), " , "), DISTPROM), " , "), DISCPER), " , '"), LINEEXP), "' , "), UOMREF), " , "), USREF), " , "), UINFO1), " , "), UINFO2), " , "), UINFO3), " , "), UINFO4), " , "), UINFO5), " , "), UINFO6), " , "), UINFO7), " , "), UINFO8), " , "), PLNAMOUNT), " , "), VATINC), " , "), VAT), " , "), VATAMNT), " , "), VATMATRAH), " , "), BILLEDITEM), " , "), BILLED), " , "), CPSTFLAG), " , "), RETCOSTTYPE), " , "), SOURCELINK), " , "), RETCOST), " , "), RETCOSTCURR), " , "), OUTCOST), " , "), OUTCOSTCURR), " , "), RETAMOUNT), " , "), FAREGREF), " , "), FAATTRIB), " , "), CANCELLED), " , "), LINENET), " , "), DISTADDEXP), " , "), FADACCREF), " , "), FADCENTERREF), " , "), FARACCREF), " , "), FARCENTERREF), " , "), DIFFPRICE), " , "), DIFFPRCOST), " , "), DECPRDIFF), " , "), LPRODSTAT), " , "), PRDEXPTOTAL), " , "), DIFFREPPRICE), " , "), DIFFPRCRCOST), " , "), SALESMANREF), " , "), FAPLACCREF), " , "), FAPLCENTERREF), " , '"), OUTPUTIDCODE), "' , "), DREF), " , "), COSTRATE), " , "), XPRICEUPD), " , "), XPRICE), " , "), XREPRATE), " , "), DISTCOEF), " , "), TRANSQCOK), " , "), SITEID), " , "), RECSTATUS), " , "), ORGLOGICREF), " , "), WFSTATUS), " , "), POLINEREF), " , "), PLNSTTRANSREF), " , "), NETDISCFLAG), " , "), NETDISCPERC), " , "), NETDISCAMNT), " , "), VATCALCDIFF), " , "), CONDITIONREF), " , "), DISTORDERREF), " , "), DISTORDLINEREF), " , "), CAMPAIGNREFS1), " , "), CAMPAIGNREFS2), " , "), CAMPAIGNREFS3), " , "), CAMPAIGNREFS4), " , "), CAMPAIGNREFS5), " , "), POINTCAMPREF), " , "), CAMPPOINT), " , "), PROMCLASITEMREF), " , "), CMPGLINEREF), " , "), PLNSTTRANSPERNR), " , "), PORDCLSPLNAMNT), " , "), VENDCOMM), " , "), PREVIOUSOUTCOST), " , "), COSTOFSALEACCREF), " , "), PURCHACCREF), " , "), COSTOFSALECNTREF), " , "), PURCHCENTREF), " , "), PREVOUTCOSTCURR), " , "), ABVATAMOUNT), " , "), ABVATSTATUS), " , "), PRRATE), " , "), ADDTAXRATE), " , "), ADDTAXCONVFACT), " , "), ADDTAXAMOUNT), " , "), ADDTAXPRCOST), " , "), ADDTAXRETCOST), " , "), ADDTAXRETCOSTCURR), " , "), GROSSUINFO1), " , "), GROSSUINFO2), " , "), ADDTAXPRCOSTCURR), " , "), ADDTAXACCREF), " , "), ADDTAXCENTERREF), " , "), ADDTAXAMNTISUPD), " , "), INFIDX), " , "), ADDTAXCOSACCREF), " , "), ADDTAXCOSCNTREF), " , "), PREVIOUSATAXPRCOST), " , "), PREVATAXPRCOSTCURR), " , "), PRDORDTOTCOEF), " , "), DEMPEGGEDAMNT), " , "), STDUNITCOST), " , "), STDRPUNITCOST), " , "), COSTDIFFACCREF), " , "), COSTDIFFCENREF), " , "), TEXTINC), " , "), ADDTAXDISCAMOUNT), " , '"), ORGLOGOID), "' , '"), EXIMFICHENO), "' , "), EXIMFCTYPE), " , "), TRANSEXPLINE), " , "), INSEXPLINE), " , "), EXIMWHFCREF), " , "), EXIMWHLNREF), " , "), EXIMFILEREF), " , "), EXIMPROCNR), " , "), EISRVDSTTYP), " , "), MAINSTLNREF), " , "), MADEOFSHRED), " , "), FROMORDWITHPAY), " , "), PROJECTREF), " , "), STATUS), " , "), DORESERVE), " , "), POINTCAMPREFS1), " , "), POINTCAMPREFS2), " , "), POINTCAMPREFS3), " , "), POINTCAMPREFS4), " , "), CAMPPOINTS1), " , "), CAMPPOINTS2), " , "), CAMPPOINTS3), " , "), CAMPPOINTS4), " , "), CMPGLINEREFS1), " , "), CMPGLINEREFS2), " , "), CMPGLINEREFS3), " , "), CMPGLINEREFS4), " , "), PRCLISTREF), " , "), PORDSYMOUTLN), " , "), MONTH_), " , "), YEAR_), " , "), EXADDTAXRATE), " , "), EXADDTAXCONVF), " , "), EXADDTAXAREF), " , "), EXADDTAXCREF), " , "), OTHRADDTAXAREF), " , "), OTHRADDTAXCREF), " , "), EXADDTAXAMNT), " , "), AFFECTCOLLATRL), " , "), ALTPROMFLAG), " , "), EIDISTFLNNR), " , "), EXIMTYPE), " , "), VARIANTREF), " , "), CANDEDUCT), " , "), OUTREMAMNT), " , "), OUTREMCOST), " , "), OUTREMCOSTCURR), " , "), REFLVATACCREF), " , "), REFLVATOTHACCREF), " , "), PARENTLNREF), " , "), AFFECTRISK), " , "), INEFFECTIVECOST), " , "), ADDTAXVATMATRAH), " , "), REFLACCREF), " , "), REFLOTHACCREF), ")")))
        Me.sCmd.ExecuteNonQuery()
        Me.sCmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        LOGICALREF = RuntimeHelpers.GetObjectValue(Me.sCmd.ExecuteScalar)
        Return Conversions.ToLong(LOGICALREF)
    End Function
    Private Function CARI_GEN_kaydet_yeni(ByVal REF As Long, ByVal SUBE As Long, ByVal STA As String, ByVal CRK As String, ByVal STGT As Integer, ByVal STCT As Integer, ByVal GMHK As String, ByVal YETKILI As String, ByVal ADRES1 As String, ByVal ADRES2 As String, ByVal SEHIR As String, ByVal RISKL As Decimal, ByVal ISKOR As Decimal, ByVal ULKE As String, ByVal POSTAKODU As String, ByVal OZELKOD As String, ByVal ALICIORSATICI As Integer, ByVal KAR As Decimal, ByVal KULLANICI As String, ByVal GORUNSUN As String, ByVal DOVIZC As Integer, ByVal VERGINO As String, ByVal VERGID As String, ByVal P_ID As String, ByVal DETAY As String, ByVal GRUPNO As String, ByVal ANAGRUP As String, ByVal ULKEKODU As String) As Long
        Try
            If (Me.sCon.State = ConnectionState.Closed) Then
                Me.sCon.Open()
            End If
        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            Dim exception As Exception = exception1
            Me.sCon.Close()
            Me.sCon.Open()
            ProjectData.ClearProjectError()
        End Try
        Me.sCmd.CommandText = Me.sorgu_query(String.Concat(New String() {"SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED  INSERT INTO CARIGEN ( SUBE, STA, CRK, STGT, STCT,GMHK, YETKILI, ADRES1, ADRES2, SEHIR, RISKL, ISKOR, ULKE, POSTAKODU, OZELKOD, ALICIORSATICI, KAR, KULLANICI, GORUNSUN,DOVIZC, VERGINO, VERGID, P_ID, DETAY, GRUPNO, ANAGRUP, ULKEKODU) VALUES     ( ", Conversions.ToString(SUBE), ", '", STA, "', '", CRK, "', ", Conversions.ToString(STGT), ", ", Conversions.ToString(STCT), ", '", GMHK, "','", YETKILI, "', '", ADRES1, "', '", ADRES2, "', '", SEHIR, "', ", Conversions.ToString(RISKL), ", ", Conversions.ToString(ISKOR), ", '", ULKE, "', '", POSTAKODU, "', '", OZELKOD, "', ", Conversions.ToString(ALICIORSATICI), ", ", Conversions.ToString(KAR), ", '", KULLANICI, "','", GORUNSUN, "', ", Conversions.ToString(DOVIZC), ", '", VERGINO, "', '", VERGID, "', '", P_ID, "', '", DETAY, "', '", GRUPNO, "', '", ANAGRUP, "', '", ULKEKODU, "')"}))
        Me.sCmd.ExecuteNonQuery()
        Me.sCmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        Return Conversions.ToLong(RuntimeHelpers.GetObjectValue(Me.sCmd.ExecuteScalar))
    End Function
    Public Function sorgu_fis_kontrol_zirve(ByVal sFistipi As String, ByVal nGirisCikis As String, ByVal dteFisTarihi As DateTime, ByVal lFisno As String, ByVal nFirmaID As String, Optional ByVal resmi As Boolean = True, Optional ByVal sDatabase As String = "") As Long
        Dim str As String = ""
        If (sDatabase <> "") Then
            str = ("USE " & sDatabase)
        End If
        Dim obj3 As Object = String.Concat(New String() {"WHERE (sFisTipi = '", sFistipi, "') and (dteFisTarihi = '", Conversions.ToString(dteFisTarihi), "') and (lFisNo = '", lFisno, "') and (nFirmaID= '", nFirmaID, "') and (nGirisCikis = '", nGirisCikis, "')  "})
        Try
            If (Me.sCon.State = ConnectionState.Closed) Then
                Me.sCon.Open()
            End If
        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            Dim exception As Exception = exception1
            Me.sCon.Close()
            Me.sCon.Open()
            ProjectData.ClearProjectError()
        End Try
        Me.sCmd.CommandText = Me.sorgu_query(String.Concat(New String() {"", str, " SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Select COUNT(SIRANO) from FATURA WHERE CARIREF = ", nFirmaID, " AND EVRAKTAR = '", Conversions.ToString(dteFisTarihi), "' AND EVRAKNO = '", lFisno, "' AND TUR = ", sFistipi, " AND AORS = '", nGirisCikis, "'"}))
        Return Conversions.ToLong(RuntimeHelpers.GetObjectValue(Me.sCmd.ExecuteScalar))
    End Function
    Private Function FATURA_kaydet_yeni(ByVal SIRANO As Long, ByVal SUBE As Short, ByVal EVRAKTAR As DateTime, ByVal TUR As Integer, ByVal AORS As String, ByVal ISLEMTIPI As Integer, ByVal EVRAKNO As String, ByVal OZELKOD1 As String, ByVal OZELKOD2 As String, ByVal DOVIZC As Integer, ByVal IPTAL As Integer, ByVal KAPORAC As Integer, ByVal KULLANICI As String, ByVal KDVDH As Integer, ByVal TURAC As String, ByVal CARIADI As String, ByVal DEPOREF As Long, ByVal CARIREF As Long, ByVal KASAKODU As String, ByVal VADETARIHI As DateTime, ByVal YIORYD As Integer, ByVal MASRAFMERKEZI As String, ByVal CRK As String, ByVal GENELTOPLAM As Decimal, ByVal GENELTOPLAMD As Decimal, ByVal TOPLAMKDV As Decimal, ByVal TOPLAMKDVD As Decimal, ByVal DEKONTVAR As Integer, ByVal CARIKULLAN As Integer, ByVal SEVKVAR As Integer, ByVal IRSBAGLI As String, ByVal SIPBAGLI As String, ByVal P_ID As String, ByVal yaziylaTL As String, ByVal CARIDVZTUTAR As Decimal, ByVal CARIDVZUGDK As Integer, ByVal IRSNO As String, ByVal IRSEKLE As Integer, ByVal TOPLAMNINDTL As Decimal, ByVal DZP_ID As String, ByVal CARIP_ID As String, ByVal INT_1 As Integer, ByVal IHRAKIYE As Integer, ByVal ITHR As Integer, ByVal SAAT As DateTime, ByVal EFATURA As String) As Long
        Try
            If (Me.sCon.State = ConnectionState.Closed) Then
                Me.sCon.Open()
            End If
        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            Dim exception As Exception = exception1
            Me.sCon.Close()
            Me.sCon.Open()
            ProjectData.ClearProjectError()
        End Try
        Me.sCmd.CommandText = Me.sorgu_query(String.Concat(New String() {"SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED  INSERT INTO FATURA ( SUBE, EVRAKTAR, TUR, AORS, ISLEMTIPI, EVRAKNO, OZELKOD1, OZELKOD2, DOVIZC, IPTAL, KAPORAC, KULLANICI, KDVDH, TURAC, CARIADI, DEPOREF, CARIREF, KASAKODU, VADETARIHI, YIORYD, MASRAFMERKEZI, CRK, GENELTOPLAM, GENELTOPLAMD, TOPLAMKDV, TOPLAMKDVD, DEKONTVAR, CARIKULLAN,  SEVKVAR, IRSBAGLI, SIPBAGLI, P_ID, yaziylaTL, CARIDVZCINSI,CARIDVZTUTAR, CARIDVZUGDK, IRSNO, IRSEKLE, TOPLAMNINDTL, DZP_ID, CARIP_ID, INT_1, IHRAKIYE, ITHR, SAAT, EFATURA) VALUES     ( ", Conversions.ToString(CInt(SUBE)), ", '", Conversions.ToString(EVRAKTAR), "', ", Conversions.ToString(TUR), ", '", AORS, "', ", Conversions.ToString(ISLEMTIPI), ", '", EVRAKNO, "', '", OZELKOD1, "', '", OZELKOD2, "', ", Conversions.ToString(DOVIZC), ", ", Conversions.ToString(IPTAL), ", ", Conversions.ToString(KAPORAC), ", '", KULLANICI, "', ", Conversions.ToString(KDVDH), ", '", TURAC, "', '", CARIADI, "', ", Conversions.ToString(DEPOREF), ", ", Conversions.ToString(CARIREF), ", ", KASAKODU, ", '", Conversions.ToString(VADETARIHI), "', ", Conversions.ToString(YIORYD), ", '", MASRAFMERKEZI, "', '", CRK, "', ", Conversions.ToString(GENELTOPLAM), ", ", Conversions.ToString(GENELTOPLAMD), ", ", Conversions.ToString(TOPLAMKDV), ", ", Conversions.ToString(TOPLAMKDVD), ", ", Conversions.ToString(DEKONTVAR), ", ", Conversions.ToString(CARIKULLAN), ", ", Conversions.ToString(SEVKVAR), ", '", IRSBAGLI, "', '", SIPBAGLI, "', '", P_ID, "', '", yaziylaTL, "', 1,", Conversions.ToString(CARIDVZTUTAR), ", ", Conversions.ToString(CARIDVZUGDK), ", '", IRSNO, "', '", Conversions.ToString(IRSEKLE), "', ", Conversions.ToString(TOPLAMNINDTL), ", NULL, '", CARIP_ID, "', ", Conversions.ToString(INT_1), ", ", Conversions.ToString(IHRAKIYE), ", ", Conversions.ToString(ITHR), ", '", Conversions.ToString(SAAT), "', '", EFATURA, "')"}))
        Me.sCmd.ExecuteNonQuery()
        Me.sCmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        Return Conversions.ToLong(RuntimeHelpers.GetObjectValue(Me.sCmd.ExecuteScalar))
    End Function
    Private Function STOK_GEN_kaydet_yeni(ByVal REF As Long, ByVal MASTERREF As Long, ByVal DETAY As String, ByVal SUBE As Integer, ByVal STK As String, ByVal STA As String, ByVal STB As String, ByVal STGM As Integer, ByVal STGT As Integer, ByVal STCM As Integer, ByVal STCT As Integer, ByVal KAR As Integer, ByVal BARKOD As String, ByVal TEMINS As Integer, ByVal ASSTOK As Integer, ByVal AZSTOK As Integer, ByVal TURU As Integer, ByVal DOVIZC As Integer, ByVal SAT1_1 As Decimal, ByVal SAT1_2 As Decimal, ByVal SAT1_3 As Decimal, ByVal SAT1_4 As Decimal, ByVal SAT1_5 As Decimal, ByVal SAT1_6 As Decimal, ByVal SAT1_7 As Decimal, ByVal SAT1_8 As Decimal, ByVal SAT1_9 As Decimal, ByVal SAT1_10 As Decimal, ByVal SAT1_1D As Decimal, ByVal SAT1_2D As Decimal, ByVal SAT1_3D As Decimal, ByVal SAT1_4D As Decimal, ByVal SAT1_5D As Decimal, ByVal SAT1_6D As Decimal, ByVal SAT1_7D As Decimal, ByVal SAT1_8D As Decimal, ByVal SAT1_9D As Decimal, ByVal SAT1_10D As Decimal, ByVal INDY As Decimal, ByVal HSF As Integer, ByVal TVS As Integer, ByVal KS As Integer, ByVal TAS As Integer, ByVal BS As Integer, ByVal DEV As Integer, ByVal KM As Integer, ByVal EK As Integer, ByVal OTV As Long, ByVal ANABROR2 As Integer, ByVal ANABROR3 As Integer, ByVal STOKKILIDI As Integer, ByVal ALIS1_1 As Decimal, ByVal ALIS1_2 As Decimal, ByVal ALIS1_3 As Decimal, ByVal ALIS1_4 As Decimal, ByVal ALIS1_5 As Decimal, ByVal ALIS1_1D As Decimal, ByVal ALIS1_2D As Decimal, ByVal ALIS1_3D As Decimal, ByVal ALIS1_4D As Decimal, ByVal ALIS1_5D As Decimal, ByVal FIELD11 As Long, ByVal FIELD12 As Long, ByVal FIELD13 As Long, ByVal FIELD14 As Long, ByVal FIELD15 As Long, ByVal FIELD17 As Long, ByVal BIRIM1NETA As Long, ByVal BIRIM1GROSA As Long, ByVal BIRIM2NETA As Long, ByVal BIRIM2GROSA As Long, ByVal BIRIM3NETA As Long, ByVal BIRIM3GROSA As Long, ByVal RENK As String, ByVal BEDEN As String, ByVal ACIKLAMA As String, ByVal ASGM As Long, ByVal ASCM As Long, ByVal PSGM As Long, ByVal PSCM As Long, ByVal TUR As Long, ByVal KSGM As Long, ByVal KSCM As Long, ByVal BZGM As Long, ByVal BZCM As Long, ByVal ARGM As Long, ByVal ARCM As Long, ByVal URGM As Long, ByVal URCM As Long, ByVal SPGM As Long, ByVal SPCM As Long, ByVal URETIMMIKTARI As Long, ByVal OPREF As Long, ByVal BBMIKTAR As Long, ByVal URETIMDVZCINS As Long, ByVal URETIMBRFIYATTL As Long, ByVal URETIMBRFIYATDVZ As Long, ByVal URGT As Long, ByVal URCT As Long, ByVal KSGT As Long, ByVal KSCT As Long, ByVal BZGT As Long, ByVal BZCT As Long, ByVal ARGT As Long, ByVal ARCT As Long, ByVal SIPGT As Long, ByVal SIPCT As Long, ByVal KDV As Decimal, ByVal BAKMIKTAR As Long, ByVal INT_1 As Long, ByVal INT_2 As Long, ByVal INT_3 As Long, ByVal INT_4 As Long, ByVal INT_5 As Long, ByVal STOKURET As Long, ByVal STOKURET2 As Long, ByVal P_ID As String, ByVal FANTOM As Long, ByVal GRUPNO As String, ByVal ANAGRUP As String, ByVal KULLANICI As String, ByVal GORUNSUN As String, ByVal SERINOKULLAN As Integer, ByVal CBBOLEN As Integer, ByVal BR2ISLEM As String, ByVal BR3ISLEM As String, ByVal EBATSONUCU As Integer) As Long
        Try
            If (Me.sCon.State = ConnectionState.Closed) Then
                Me.sCon.Open()
            End If
        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            Dim exception As Exception = exception1
            Me.sCon.Close()
            Me.sCon.Open()
            ProjectData.ClearProjectError()
        End Try
        Me.sCmd.CommandText = Me.sorgu_query(String.Concat(New String() {"SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED  INSERT INTO STOKGEN ( MASTERREF, DETAY, SUBE, STK, STA, STB, STGM, STGT, STCM, STCT, KAR, BARKOD, TEMINS, ASSTOK, AZSTOK, TURU, DOVIZC, SAT1_1, SAT1_2, SAT1_3, SAT1_4, SAT1_5, SAT1_6, SAT1_7, SAT1_8, SAT1_9, SAT1_10, SAT1_1D, SAT1_2D, SAT1_3D, SAT1_4D, SAT1_5D, SAT1_6D, SAT1_7D, SAT1_8D, SAT1_9D, SAT1_10D,INDY, HSF, TVS, KS, TAS, BS, DEV, KM, EK, OTV, ANABROR2, ANABROR3, STOKKILIDI, ALIS1_1, ALIS1_2, ALIS1_3, ALIS1_4, ALIS1_5, ALIS1_1D, ALIS1_2D, ALIS1_3D, ALIS1_4D, ALIS1_5D, FIELD11, FIELD12, FIELD13, FIELD14, FIELD15, FIELD17, BIRIM1NETA, BIRIM1GROSA, BIRIM2NETA, BIRIM2GROSA, BIRIM3NETA, BIRIM3GROSA, RENK, BEDEN, ACIKLAMA, ASGM, ASCM, PSGM, PSCM, TUR, KSGM, KSCM, BZGM, BZCM, ARGM, ARCM, URGM, URCM, SPGM, SPCM, URETIMMIKTARI, OPREF, BBMIKTAR, URETIMDVZCINS, URETIMBRFIYATTL, URETIMBRFIYATDVZ, URGT, URCT, KSGT, KSCT, BZGT, BZCT, ARGT, ARCT, SIPGT, SIPCT, KDV, BAKMIKTAR, INT_1, INT_2, INT_3, INT_4, INT_5, STOKURET, STOKURET2, P_ID, FANTOM, GRUPNO, ANAGRUP, KULLANICI, GORUNSUN, SERINOKULLAN, CBBOLEN, BR2ISLEM, BR3ISLEM, EBATSONUCU) VALUES     (", Conversions.ToString(MASTERREF), " , '", DETAY, "' , ", Conversions.ToString(SUBE), " , '", STK, "' , '", STA, "' , '", STB, "' , ", Conversions.ToString(STGM), " , ", Conversions.ToString(STGT), " , ", Conversions.ToString(STCM), " , ", Conversions.ToString(STCT), " , ", Conversions.ToString(KAR), " , '", BARKOD, "' , ", Conversions.ToString(TEMINS), " , ", Conversions.ToString(ASSTOK), " , ", Conversions.ToString(AZSTOK), " , ", Conversions.ToString(TURU), " , ", Conversions.ToString(DOVIZC), " , ", Conversions.ToString(SAT1_1), " , ", Conversions.ToString(SAT1_2), " , ", Conversions.ToString(SAT1_3), " , ", Conversions.ToString(SAT1_4), " , ", Conversions.ToString(SAT1_5), " , ", Conversions.ToString(SAT1_6), " , ", Conversions.ToString(SAT1_7), " , ", Conversions.ToString(SAT1_8), " , ", Conversions.ToString(SAT1_9), " , ", Conversions.ToString(SAT1_10), " , ", Conversions.ToString(SAT1_1D), " , ", Conversions.ToString(SAT1_2D), " , ", Conversions.ToString(SAT1_3D), " , ", Conversions.ToString(SAT1_4D), " , ", Conversions.ToString(SAT1_5D), " , ", Conversions.ToString(SAT1_6D), " , ", Conversions.ToString(SAT1_7D), " , ", Conversions.ToString(SAT1_8D), " , ", Conversions.ToString(SAT1_9D), " , ", Conversions.ToString(SAT1_10D), " , ", Conversions.ToString(INDY), " , ", Conversions.ToString(HSF), " , ", Conversions.ToString(TVS), " , ", Conversions.ToString(KS), " , ", Conversions.ToString(TAS), " , ", Conversions.ToString(BS), " , ", Conversions.ToString(DEV), " , ", Conversions.ToString(KM), " , ", Conversions.ToString(EK), " , ", Conversions.ToString(OTV), " , ", Conversions.ToString(ANABROR2), " , ", Conversions.ToString(ANABROR3), " , ", Conversions.ToString(STOKKILIDI), " , ", Conversions.ToString(ALIS1_1), " , ", Conversions.ToString(ALIS1_2), " , ", Conversions.ToString(ALIS1_3), " , ", Conversions.ToString(ALIS1_4), " , ", Conversions.ToString(ALIS1_5), " , ", Conversions.ToString(ALIS1_1D), " , ", Conversions.ToString(ALIS1_2D), " , ", Conversions.ToString(ALIS1_3D), " , ", Conversions.ToString(ALIS1_4D), " , ", Conversions.ToString(ALIS1_5D), " , ", Conversions.ToString(FIELD11), " , ", Conversions.ToString(FIELD12), " , ", Conversions.ToString(FIELD13), " , ", Conversions.ToString(FIELD14), " , ", Conversions.ToString(FIELD15), " , ", Conversions.ToString(FIELD17), " , ", Conversions.ToString(BIRIM1NETA), " , ", Conversions.ToString(BIRIM1GROSA), " , ", Conversions.ToString(BIRIM2NETA), " , ", Conversions.ToString(BIRIM2GROSA), " , ", Conversions.ToString(BIRIM3NETA), " , ", Conversions.ToString(BIRIM3GROSA), " , '", RENK, "' , '", BEDEN, "' , '", ACIKLAMA, "' , ", Conversions.ToString(ASGM), " , ", Conversions.ToString(ASCM), " , ", Conversions.ToString(PSGM), " , ", Conversions.ToString(PSCM), " , ", Conversions.ToString(TUR), " , ", Conversions.ToString(KSGM), " , ", Conversions.ToString(KSCM), " , ", Conversions.ToString(BZGM), " , ", Conversions.ToString(BZCM), " , ", Conversions.ToString(ARGM), " , ", Conversions.ToString(ARCM), " , ", Conversions.ToString(URGM), " , ", Conversions.ToString(URCM), " , ", Conversions.ToString(SPGM), " , ", Conversions.ToString(SPCM), " , ", Conversions.ToString(URETIMMIKTARI), " , ", Conversions.ToString(OPREF), " , ", Conversions.ToString(BBMIKTAR), " , ", Conversions.ToString(URETIMDVZCINS), " , ", Conversions.ToString(URETIMBRFIYATTL), " , ", Conversions.ToString(URETIMBRFIYATDVZ), " , ", Conversions.ToString(URGT), " , ", Conversions.ToString(URCT), " , ", Conversions.ToString(KSGT), " , ", Conversions.ToString(KSCT), " , ", Conversions.ToString(BZGT), " , ", Conversions.ToString(BZCT), " , ", Conversions.ToString(ARGT), " , ", Conversions.ToString(ARCT), " , ", Conversions.ToString(SIPGT), " , ", Conversions.ToString(SIPCT), " , ", Conversions.ToString(KDV), " , ", Conversions.ToString(BAKMIKTAR), " , ", Conversions.ToString(INT_1), " , ", Conversions.ToString(INT_2), " , ", Conversions.ToString(INT_3), " , ", Conversions.ToString(INT_4), " , ", Conversions.ToString(INT_5), " , ", Conversions.ToString(STOKURET), " , ", Conversions.ToString(STOKURET2), " , '", P_ID, "' , ", Conversions.ToString(FANTOM), " , '", GRUPNO, "' , '", ANAGRUP, "' , '", KULLANICI, "' , '", GORUNSUN, "' , ", Conversions.ToString(SERINOKULLAN), " , ", Conversions.ToString(CBBOLEN), " , '", BR2ISLEM, "' , '", BR3ISLEM, "' , ", Conversions.ToString(EBATSONUCU), ")"}))
        Me.sCmd.ExecuteNonQuery()
        Me.sCmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        Return Conversions.ToLong(RuntimeHelpers.GetObjectValue(Me.sCmd.ExecuteScalar))
    End Function
    Private Function FATURA_ALT_kaydet_yeni(ByVal REF As Long, ByVal FATIP As String, ByVal STOKREF As Long, ByVal STK As String, ByVal STA As String, ByVal STB As String, ByVal BRKODU As String, ByVal FREEBR As String, ByVal MIKTAR As Decimal, ByVal DOVIZC As Decimal, ByVal BRFTL As Decimal, ByVal TUTARTL As Decimal, ByVal KDVY As Decimal, ByVal KDVTL As Decimal, ByVal KDVD As Decimal, ByVal OTVY As Decimal, ByVal OTVTL As Decimal, ByVal INDY As Decimal, ByVal INDTL As Decimal, ByVal IND1 As Decimal, ByVal IND2 As Decimal, ByVal IND3 As Decimal, ByVal IND4 As Decimal, ByVal IND5 As Decimal, ByVal IND6 As Decimal, ByVal OZELKOD1 As String, ByVal OZELKOD2 As String, ByVal ACIKLAMA As String, ByVal STOKTUR As Integer, ByVal TUR As Integer, ByVal TURAC As String, ByVal AORS As String, ByVal SATINDTL As Decimal, ByVal GRMIK As Decimal, ByVal CKMIK As Decimal, ByVal GRBRFTL As Decimal, ByVal CKBRFTL As Decimal, ByVal GRBRFD As Decimal, ByVal CKBRFD As Decimal, ByVal GRTUTARTL As Decimal, ByVal CKTUTARTL As Decimal, ByVal KALANMIKTAR As Decimal, ByVal FATREF As Long, ByVal IRSREF As Long, ByVal SIPREF As Long, ByVal FATEVRAKNO As String, ByVal FATIRSTUR As Long, ByVal FATSATIRREF As Long, ByVal IPTAL As Integer, ByVal SUBE As Integer, ByVal MASRAFMERKEZI As String, ByVal KAMPKODU As String, ByVal KULLANICI As String, ByVal SATICI As String, ByVal KDVDH As Integer, ByVal TARIH As DateTime, ByVal ISLEMTIPI As Integer, ByVal EVRAKNO As String, ByVal CARIREF As Long, ByVal DEPOREF As Long, ByVal SIPMIKTAR As Integer, ByVal IRSMIKTAR As Integer, ByVal FATMIKTAR As Decimal, ByVal SATIRREF As Long, ByVal ISEMRINO As String, ByVal P_ID As String, ByVal ANABROR2 As Long, ByVal ANABROR3 As Long, ByVal p2var As Integer, ByVal RECETEVAR As Integer, ByVal AKTARIM As Integer, ByVal NETTUTARTL As Decimal, ByVal MDAGIT As Integer, ByVal IDAGIT As Integer, ByVal OLDSTOKREF As Long, ByVal SIRALAMA As Long, ByVal KARTDOVIZC As Decimal, ByVal KARTUGDK As Long, ByVal KARTDOVIZTUTAR As Decimal, ByVal GVSTOPAJTUTARITL As Decimal, ByVal GVSTOPAJTUTARD As Decimal, ByVal SATIRP_ID As String, ByVal BR2ISLEM As String, ByVal BR3ISLEM As String, ByVal STOKP_ID As String, ByVal IRSEKLE As Integer, ByVal FATACIKLAMA As String, ByVal INDSIZKDV As Decimal, ByVal NETKG As Long, ByVal BRUTKG As Long, ByVal PAKETM As Long, ByVal PAKETACK As String, ByVal KALITEKODU As String, ByVal STOKNETKG As Long, ByVal STOKBRUTKG As Long, ByVal SEVKTARIHI As DateTime, ByVal OTVBRNO As Long, ByVal OTVVERGIMATRAH As Decimal, ByVal EMSALBEDEL As Decimal, ByVal OIVTUTARTL As Decimal, ByVal OIVVERGIMATRAH As Decimal) As Long
        Try
            If (Me.sCon.State = ConnectionState.Closed) Then
                Me.sCon.Open()
            End If
        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            Dim exception As Exception = exception1
            Me.sCon.Close()
            Me.sCon.Open()
            ProjectData.ClearProjectError()
        End Try
        Me.sCmd.CommandText = Me.sorgu_query(String.Concat(New String() {"SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED  INSERT INTO FATURA_ALT                       (FATIP, STOKREF, STK, STA, STB, BRKODU, FREEBR, MIKTAR, DOVIZC, BRFTL, TUTARTL, KDVY, KDVTL, KDVD, OTVY, OTVTL, INDY, INDTL, IND1, IND2, IND3,  IND4, IND5, IND6, OZELKOD1, OZELKOD2, ACIKLAMA, STOKTUR,TUR, TURAC, AORS, SATINDTL, GRMIK, CKMIK, GRBRFTL, CKBRFTL, GRBRFD, CKBRFD, GRTUTARTL, CKTUTARTL, KALANMIKTAR, FATREF, IRSREF, SIPREF, FATEVRAKNO, FATIRSTUR, FATSATIRREF, IPTAL, SUBE, MASRAFMERKEZI, KAMPKODU, KULLANICI, SATICI, KDVDH, TARIH, ISLEMTIPI, EVRAKNO, CARIREF, DEPOREF, SIPMIKTAR, IRSMIKTAR, FATMIKTAR, SATIRREF, ISEMRINO, P_ID, ANABROR2, ANABROR3, p2var, RECETEVAR, AKTARIM, NETTUTARTL, MDAGIT, IDAGIT, OLDSTOKREF, SIRALAMA, KARTDOVIZC, KARTUGDK, KARTDOVIZTUTAR, GVSTOPAJTUTARITL, GVSTOPAJTUTARD, SATIRP_ID, BR2ISLEM, BR3ISLEM, STOKP_ID, IRSEKLE, FATACIKLAMA, INDSIZKDV, NETKG, BRUTKG, PAKETM, PAKETACK, KALITEKODU, STOKNETKG, STOKBRUTKG, SEVKTARIHI, OTVBRNO, OTVVERGIMATRAH, EMSALBEDEL, OIVTUTARTL, OIVVERGIMATRAH) VALUES     ('", FATIP, "', ", Conversions.ToString(STOKREF), ", '", STK, "', '", STA, "', '", STB, "', '", BRKODU, "', '", FREEBR, "', ", Conversions.ToString(MIKTAR), ", ", Conversions.ToString(DOVIZC), ", ", Conversions.ToString(BRFTL), ", ", Conversions.ToString(TUTARTL), ", ", Conversions.ToString(KDVY), ", ", Conversions.ToString(KDVTL), ", ", Conversions.ToString(KDVD), ", ", Conversions.ToString(OTVY), ", ", Conversions.ToString(OTVTL), ", ", Conversions.ToString(INDY), ", ", Conversions.ToString(INDTL), ", ", Conversions.ToString(IND1), ", ", Conversions.ToString(IND2), ", ", Conversions.ToString(IND3), ", ", Conversions.ToString(IND4), ", ", Conversions.ToString(IND5), ", ", Conversions.ToString(IND6), ", '", OZELKOD1, "', '", OZELKOD2, "', '", ACIKLAMA, "', ", Conversions.ToString(STOKTUR), ",", Conversions.ToString(TUR), ", '", TURAC, "', '", AORS, "', ", Conversions.ToString(SATINDTL), ", ", Conversions.ToString(GRMIK), ", ", Conversions.ToString(CKMIK), ", ", Conversions.ToString(GRBRFTL), ", ", Conversions.ToString(CKBRFTL), ", ", Conversions.ToString(GRBRFD), ", ", Conversions.ToString(CKBRFD), ", ", Conversions.ToString(GRTUTARTL), ", ", Conversions.ToString(CKTUTARTL), ", ", Conversions.ToString(KALANMIKTAR), ", ", Conversions.ToString(FATREF), ", ", Conversions.ToString(IRSREF), ", ", Conversions.ToString(SIPREF), ", '", FATEVRAKNO, "', ", Conversions.ToString(FATIRSTUR), ", ", Conversions.ToString(FATSATIRREF), ", ", Conversions.ToString(IPTAL), ", ", Conversions.ToString(SUBE), ", '", MASRAFMERKEZI, "', '", KAMPKODU, "', '", KULLANICI, "', '", SATICI, "', ", Conversions.ToString(KDVDH), ",  '", Conversions.ToString(TARIH), "', ", Conversions.ToString(ISLEMTIPI), ", '", EVRAKNO, "', ", Conversions.ToString(CARIREF), ", ", Conversions.ToString(DEPOREF), ", ", Conversions.ToString(SIPMIKTAR), ", ", Conversions.ToString(IRSMIKTAR), ", ", Conversions.ToString(FATMIKTAR), ", ", Conversions.ToString(SATIRREF), ", '", ISEMRINO, "', '", P_ID, "', ", Conversions.ToString(ANABROR2), ", ", Conversions.ToString(ANABROR3), ", ", Conversions.ToString(p2var), ", ", Conversions.ToString(RECETEVAR), ", ", Conversions.ToString(AKTARIM), ", ", Conversions.ToString(NETTUTARTL), ", ", Conversions.ToString(MDAGIT), ", ", Conversions.ToString(IDAGIT), ", ", Conversions.ToString(OLDSTOKREF), ", ", Conversions.ToString(SIRALAMA), ", ", Conversions.ToString(KARTDOVIZC), ", ", Conversions.ToString(KARTUGDK), ", ", Conversions.ToString(KARTDOVIZTUTAR), ", ", Conversions.ToString(GVSTOPAJTUTARITL), ", ", Conversions.ToString(GVSTOPAJTUTARD), ", '", SATIRP_ID, "', '", BR2ISLEM, "', '", BR3ISLEM, "', '", STOKP_ID, "', ", Conversions.ToString(IRSEKLE), ", '", FATACIKLAMA, "', ", Conversions.ToString(INDSIZKDV), ", ", Conversions.ToString(NETKG), ", ", Conversions.ToString(BRUTKG), ", ", Conversions.ToString(PAKETM), ", '", PAKETACK, "', '", KALITEKODU, "', ", Conversions.ToString(STOKNETKG), ", ", Conversions.ToString(STOKBRUTKG), ", '", Conversions.ToString(SEVKTARIHI), "', ", Conversions.ToString(OTVBRNO), ", ", Conversions.ToString(OTVVERGIMATRAH), ", ", Conversions.ToString(EMSALBEDEL), ", ", Conversions.ToString(OIVTUTARTL), ", ", Conversions.ToString(OIVVERGIMATRAH), ")"}))
        Me.sCmd.ExecuteNonQuery()
        Me.sCmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        Return Conversions.ToLong(RuntimeHelpers.GetObjectValue(Me.sCmd.ExecuteScalar))
    End Function

    Private Sub zirve_entegre()
        If (Me.GridView1.RowCount > 0) Then
            Dim _kopyala As New frm_fatura_kopyala1 With {
                .firmano = RuntimeHelpers.GetObjectValue(Me.firmano),
                .donemno = RuntimeHelpers.GetObjectValue(Me.donemno),
                .connection = RuntimeHelpers.GetObjectValue(Me.connection),
                .sFisTipi = "FS ",
                .nGirisCikis = 3,
                .kapla = True,
                .nFirmaID = 0,
                .sKodu = "32027001"
            }
            _kopyala.txt_musteriNo.EditValue = _kopyala.sKodu
            _kopyala.lbl_Firma.Text = ""
            _kopyala.txt_dteFisTarihi1.EditValue = KeyCode.dteSistemTarihi
            _kopyala.bAktar = True
            _kopyala.txt_lFisNo.Text = KeyCode.sayiuzunlukkontrol(Conversions.ToString(1), Conversions.ToString(6), "0")
            Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Me.connection)
            Dim sConnection As Object = KeyCode.sConnection
            _kopyala.bLogo = True
            If (_kopyala.ShowDialog(Me) = DialogResult.OK) Then
                Me.firmano = _kopyala.txt_nFirmaNo.Text
                Me.donemno = _kopyala.txt_nDonemNo.Text
                Me.sConnectionLogo = _kopyala.sUzakConnection
                KeyCode.sConnection = _kopyala.sConnection
                If (XtraMessageBox.Show(KeyCode.Sorgu_sDil("Seçili Kayıtları Entegre Etmek İstediğinize Emin misiniz...?", KeyCode.sDil), KeyCode.Sorgu_sDil("Dikkat", KeyCode.sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
                    Dim current As DataRow
                    Dim selectedRowsCount As Object = Me.GridView1.SelectedRowsCount
                    Dim selectedRows As Integer() = Me.GridView1.GetSelectedRows
                    If (Not selectedRows Is Nothing) Then
                        Array.Sort(Of Integer)(selectedRows)
                        Me.bar1.Properties.Maximum = Me.GridView1.SelectedRowsCount
                        Me.bar1.Visible = True
                        Me.bar1.Position = 0
                        Me.sCon.ConnectionString = Me.sConnectionLogo
                        Me.sCmd.Connection = Me.sCon
                        Me.sCmd.CommandTimeout = 400
                        If (Me.sCon.State = ConnectionState.Closed) Then
                            Me.sCon.Open()
                        End If
                        Dim num As Integer
                        For Each num In selectedRows
                            Dim str As String = num.ToString
                            Dim dataRow As DataRow = Me.GridView1.GetDataRow(Conversions.ToInteger(str))
                            Dim num9 As Integer = 1
                            Dim time As DateTime = Conversions.ToDate(dataRow.Item("dteFisTarihi"))
                            Dim rEF As Long = 0
                            Dim str3 As String = ""
                            Dim fATREF As Long = 0
                            Dim str4 As String = ""
                            Dim num11 As Long = 0
                            Dim str9 As String = ""
                            Dim num13 As Integer = 60
                            Dim tURAC As String = "Satış Faturası"
                            Dim nGirisCikis As String = "S"
                            If (Trim(Conversions.ToString(dataRow.Item("sFisTipi"))) = "FS") Then
                                If Operators.ConditionalCompareObjectEqual(dataRow.Item("nGirisCikis"), 3, False) Then
                                    num13 = 60
                                    nGirisCikis = "S"
                                    tURAC = "Satış Faturası"
                                ElseIf Operators.ConditionalCompareObjectEqual(dataRow.Item("nGirisCikis"), 4, False) Then
                                    num13 = &H3D
                                    nGirisCikis = "A"
                                    tURAC = "Satış İade Faturası"
                                End If
                            ElseIf (Trim(Conversions.ToString(dataRow.Item("sFisTipi"))) = "FA") Then
                                If Operators.ConditionalCompareObjectEqual(dataRow.Item("nGirisCikis"), 1, False) Then
                                    num13 = &H3E
                                    nGirisCikis = "A"
                                    tURAC = "Alış Faturası"
                                ElseIf Operators.ConditionalCompareObjectEqual(dataRow.Item("nGirisCikis"), 2, False) Then
                                    num13 = &H3F
                                    nGirisCikis = "S"
                                    tURAC = "Alış İade Faturası"
                                End If
                            ElseIf (Trim(Conversions.ToString(dataRow.Item("sFisTipi"))) = "MM") Then
                                num13 = &H45
                                nGirisCikis = "S"
                                tURAC = "Müstahsil Makbuzu"
                            ElseIf (Trim(Conversions.ToString(dataRow.Item("sFisTipi"))) = "HA") Then
                                num13 = &H40
                                nGirisCikis = "A"
                                tURAC = "Gider Faturası"
                            ElseIf (Trim(Conversions.ToString(dataRow.Item("sFisTipi"))) = "HS") Then
                                num13 = 60
                                nGirisCikis = "S"
                                tURAC = "Satış Faturası"
                            End If
                            Dim num8 As Decimal = 8
                            Dim sTK As String = "000002"
                            Dim sTA As String = "EKMEK IKILI"
                            rEF = Me.sorgula_logo_nStokID(Me.sorgu_query(("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(REF, 0) AS CLIENTREF  FROM         CARIGEN WHERE     (CRK = '" & Trim(Conversions.ToString(dataRow.Item("sKodu"))) & "')")))
                            If (rEF = 0) Then
                                str3 = Me.sorgula_logo_string("Select LOWER(NEWID())")
                                rEF = Me.CARI_GEN_kaydet_yeni(rEF, 0, dataRow.Item("sAciklama").ToString, dataRow.Item("sKodu").ToString, 0, 0, dataRow.Item("sKodu").ToString, dataRow.Item("sVergiNo").ToString, dataRow.Item("sAdres1").ToString, dataRow.Item("sAdres2").ToString, dataRow.Item("sIl").ToString, Conversions.ToDecimal(dataRow.Item("lKrediLimiti")), Conversions.ToDecimal(dataRow.Item("nIskontoYuzdesi")), dataRow.Item("sUlke").ToString, dataRow.Item("sPostaKodu").ToString, "", 1, Decimal.Zero, KeyCode.kullaniciadi, "EVET", 1, dataRow.Item("sVergiNo").ToString, dataRow.Item("sVergiDairesi").ToString, str3, "E", "1000.0", "1000", "052")
                            Else
                                str3 = Me.sorgula_logo_string(("Select P_ID from CARIGEN WHERE CRK = '" & dataRow.Item("sKodu").ToString & "'"))
                            End If
                            If (Me.sorgu_fis_kontrol_zirve(Conversions.ToString(num13), nGirisCikis, Conversions.ToDate(dataRow.Item("dteFisTarihi")), Conversions.ToString(dataRow.Item("lFisNo")), Conversions.ToString(rEF), True, "") = 0) Then
                                Dim enumerator As IEnumerator
                                Dim obj2 As Object = Me.sorgu(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(((((("SELECT tbStokFisiDetayi.*, tbStok.sKodu AS sStokKodu, tbStok.sAciklama AS sStokAciklama,tbStok.sKisaAdi,tbStok.sBirimCinsi1,tbStok.sBirimCinsi2,tbStok.sModel, tbStok.sBeden,tbStok.nFiyatlandirma,tbStok.nStokTipi,tbRenk.sRenkAdi,tbStokBarkodu.sBarkod ,(Select lFiyat from tbStokFiyati where nStokID = tbStok.nStokID and sFiyatTipi = '" & KeyCode.sFiyatM & "') AS lMaliyet,(Select lFiyat from tbStokFiyati where nStokID = tbStok.nStokID and sFiyatTipi = '") & KeyCode.sFiyatA & "') as lAlis, (Select lFiyat from tbStokFiyati where nStokID = tbStok.nStokID and sFiyatTipi = '") & KeyCode.sFiyat1 & "') AS lFiyat1,(Select lFiyat from tbStokFiyati where nStokID = tbStok.nStokID and sFiyatTipi = '") & KeyCode.sFiyat2 & "') AS lFiyat2,(Select lFiyat from tbStokFiyati where nStokID = tbStok.nStokID and sFiyatTipi = '") & KeyCode.sFiyat3 & "') AS lFiyat3,CAST(0 AS FLOAT) AS ISK1, CAST(0 AS FLOAT) AS ISK2,CAST(0 AS FLOAT) AS ISK3,CAST(0 AS FLOAT) AS ISK4,CAST(0 AS FLOAT) AS ISK5,CAST(0 AS FLOAT) AS nMasrafSatiri,CAST(0 AS MONEY) AS GERCEKFIYAT, CAST(0 AS MONEY) AS GERCEKTOPLAM, ABS((tbStokFisiDetayi.lBrutTutar - tbStokFisiDetayi.lIskontoTutari) * (tbStokFisiDetayi.nKdvOrani / 100)) AS lKdvTutari,CAST(tbStokFisiDetayi.lBrutFiyat * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS FLOAT) AS lDahilBrutFiyat,CAST(tbStokFisiDetayi.lBrutTutar * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS FLOAT) AS lDahilBrutTutar, tbStokFisiDetayi.lBrutTutar as lDovizTutar, tbStokFisiDetayi.lBrutFiyat lDovizFiyati, (tbStokFisiDetayi.lBrutTutar)* (100 + tbStokFisiDetayi.nKdvOrani) / 100  lDahilDovizTutar, (tbStokFisiDetayi.lBrutFiyat)* (100 + tbStokFisiDetayi.nKdvOrani) / 100 lDahilDovizFiyati,tbStokFisiMaster.lKdv1,tbStokFisiMaster.lKdv2,tbStokFisiMaster.lKdv3,tbStokFisiMaster.lKdv4,tbStokFisiMaster.lKdv5 FROM tbStokFisiDetayi INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID INNER JOIN tbRenk ON tbStok.sRenk = tbRenk.sRenk INNER JOIN tbStokBarkodu ON tbStok.nStokID = tbStokBarkodu.nStokID AND tbStokBarkodu.nKisim = 0  INNER JOIN   tbStokFisiMaster ON tbStokFisiDetayi.nStokFisiID = tbStokFisiMaster.nStokFisiID WHERE     (tbStokFisiDetayi.nStokFisiID = '"), dataRow.Item("nStokFisiID")), "') ORDER BY tbStokFisiDetayi.nIslemID")), "TABLE1")
                                Dim num21 As New Decimal
                                Dim num20 As New Decimal
                                Dim num22 As New Decimal
                                Dim num23 As Decimal = KeyCode.sorgu_sayi(RuntimeHelpers.GetObjectValue(dataRow.Item("lNetTutar")), Decimal.Zero)
                                Dim num15 As New Decimal
                                Dim num16 As New Decimal
                                Dim num17 As New Decimal
                                Dim num18 As New Decimal
                                Dim num19 As New Decimal
                                If Operators.ConditionalCompareObjectEqual(dataRow.Item("nGirisCikis"), 1, False) Then
                                    num21 = New Decimal
                                    num20 = Math.Abs(num23)
                                ElseIf Operators.ConditionalCompareObjectEqual(dataRow.Item("nGirisCikis"), 2, False) Then
                                    num21 = Math.Abs(num23)
                                    num20 = New Decimal
                                ElseIf Operators.ConditionalCompareObjectEqual(dataRow.Item("nGirisCikis"), 3, False) Then
                                    num21 = Math.Abs(num23)
                                    num20 = New Decimal
                                ElseIf Operators.ConditionalCompareObjectEqual(dataRow.Item("nGirisCikis"), 4, False) Then
                                    num21 = New Decimal
                                    num20 = Math.Abs(num23)
                                End If
                                str4 = Me.sorgula_logo_string("Select LOWER(NEWID())")
                                fATREF = Me.FATURA_kaydet_yeni(0, 1, Conversions.ToDate(dataRow.Item("dteFisTarihi")), num13, nGirisCikis, 1, Conversions.ToString(dataRow.Item("lFisNo")), "", "", 1, 0, 0, dataRow.Item("sKullaniciAdi").ToString, 0, tURAC, dataRow.Item("sAciklama").ToString, 1, rEF, "NULL", Conversions.ToDate(dataRow.Item("dteFisTarihi")), 0, "MERKEZ", dataRow.Item("sKodu").ToString, Conversions.ToDecimal(dataRow.Item("lNetTutar")), Decimal.Zero, Conversions.ToDecimal(dataRow.Item("KdvTutari")), Decimal.Zero, 0, 0, 0, "", "", str4, "", Decimal.Zero, 1, "", 0, Conversions.ToDecimal(dataRow.Item("lIskontoTutari")), "", str3, 0, 0, 0, Conversions.ToDate(dataRow.Item("dteKayitTarihi")), "")
                                num9 = 1
                                Try
                                    enumerator = DirectCast(NewLateBinding.LateGet(NewLateBinding.LateGet(obj2, Nothing, "Tables", New Object() {0}, Nothing, Nothing, Nothing), Nothing, "Rows", New Object(0 - 1) {}, Nothing, Nothing, Nothing), IEnumerable).GetEnumerator
                                    Do While enumerator.MoveNext
                                        Dim obj5 As Object
                                        current = DirectCast(enumerator.Current, DataRow)
                                        If current.Item("sAciklama").ToString.Contains("+") Then
                                            Dim strArray2 As String() = current.Item("sAciklama").ToString.Split(New Char() {"+"c})
                                            Try
                                                current.Item("ISK1") = strArray2(0)
                                            Catch exception1 As Exception
                                                ProjectData.SetProjectError(exception1)
                                                Dim exception As Exception = exception1
                                                current.Item("ISK1") = 0
                                                ProjectData.ClearProjectError()
                                            End Try
                                            Try
                                                current.Item("ISK2") = strArray2(1)
                                            Catch exception7 As Exception
                                                ProjectData.SetProjectError(exception7)
                                                Dim exception2 As Exception = exception7
                                                current.Item("ISK2") = 0
                                                ProjectData.ClearProjectError()
                                            End Try
                                            Try
                                                current.Item("ISK3") = strArray2(2)
                                            Catch exception8 As Exception
                                                ProjectData.SetProjectError(exception8)
                                                Dim exception3 As Exception = exception8
                                                current.Item("ISK3") = 0
                                                ProjectData.ClearProjectError()
                                            End Try
                                            Try
                                                current.Item("ISK4") = strArray2(3)
                                            Catch exception9 As Exception
                                                ProjectData.SetProjectError(exception9)
                                                Dim exception4 As Exception = exception9
                                                current.Item("ISK4") = 0
                                                ProjectData.ClearProjectError()
                                            End Try
                                            Try
                                                current.Item("ISK5") = strArray2(4)
                                            Catch exception10 As Exception
                                                ProjectData.SetProjectError(exception10)
                                                Dim exception5 As Exception = exception10
                                                current.Item("ISK5") = 0
                                                ProjectData.ClearProjectError()
                                            End Try
                                        End If
                                        Dim str12 As String = ""
                                        If Operators.ConditionalCompareObjectEqual(current.Item("nIskontoYuzdesi"), 0, False) Then
                                            current.Item("sAciklama") = ""
                                        Else
                                            If Operators.ConditionalCompareObjectNotEqual(current.Item("ISK1"), 0, False) Then
                                                str12 = (str12 & Me.uzunluk_tamamla(FormatNumber(RuntimeHelpers.GetObjectValue(current.Item("ISK1")), 2, TriState.UseDefault, TriState.UseDefault, TriState.UseDefault), 5, "0") & "+")
                                            End If
                                            If Operators.ConditionalCompareObjectNotEqual(current.Item("ISK2"), 0, False) Then
                                                str12 = (str12 & Me.uzunluk_tamamla(FormatNumber(RuntimeHelpers.GetObjectValue(current.Item("ISK2")), 2, TriState.UseDefault, TriState.UseDefault, TriState.UseDefault), 5, "0"))
                                            End If
                                            If Operators.ConditionalCompareObjectNotEqual(current.Item("ISK3"), 0, False) Then
                                                str12 = (str12 & "+" & Me.uzunluk_tamamla(FormatNumber(RuntimeHelpers.GetObjectValue(current.Item("ISK3")), 2, TriState.UseDefault, TriState.UseDefault, TriState.UseDefault), 5, "0"))
                                            End If
                                            If Operators.ConditionalCompareObjectNotEqual(current.Item("ISK4"), 0, False) Then
                                                str12 = (str12 & "+" & Me.uzunluk_tamamla(FormatNumber(RuntimeHelpers.GetObjectValue(current.Item("ISK4")), 2, TriState.UseDefault, TriState.UseDefault, TriState.UseDefault), 5, "0"))
                                            End If
                                            If (Decimal.Compare(KeyCode.sorgu_sayi(RuntimeHelpers.GetObjectValue(current.Item("ISK5")), Decimal.Zero), Decimal.Zero) <> 0) Then
                                                str12 = (str12 & "+" & Me.uzunluk_tamamla(FormatNumber(RuntimeHelpers.GetObjectValue(current.Item("ISK5")), 2, TriState.UseDefault, TriState.UseDefault, TriState.UseDefault), 5, "0"))
                                            End If
                                            current.Item("sAciklama") = str12
                                        End If
                                        sTK = Trim(Conversions.ToString(current.Item("sStokKodu")))
                                        sTA = Trim(Conversions.ToString(current.Item("sStokAciklama")))
                                        num8 = Conversions.ToDecimal(current.Item("nKdvOrani"))
                                        num11 = Me.sorgula_logo_nStokID(Me.sorgu_query(("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(REF, 0) AS STOCKF  FROM         STOKGEN WHERE     (STK = '" & sTK & "')")))
                                        If ((num11 = 0) Or (num11 = 1)) Then
                                            Dim birim1 As String = Trim(Conversions.ToString(current.Item("sBirimCinsi1")))
                                            If birim1 = "AD" Then
                                                birim1 = "ADET"
                                            ElseIf birim1 = "KO" Then
                                                birim1 = "KOLİ"
                                            ElseIf birim1 = "PL" Then
                                                birim1 = "PALET"
                                            End If
                                            str9 = Me.sorgula_logo_string("Select LOWER(NEWID())")
                                            num11 = Me.STOK_GEN_kaydet_yeni(num11, 0, "E", 1, sTK, sTA, birim1, 0, 0, 0, 0, 0, sTK, 0, 0, 0, 0, 1, Decimal.Zero, Decimal.Zero, Decimal.Zero, Decimal.Zero, Decimal.Zero, Decimal.Zero, Decimal.Zero, Decimal.Zero, Decimal.Zero, Decimal.Zero, Decimal.Zero, Decimal.Zero, Decimal.Zero, Decimal.Zero, Decimal.Zero, Decimal.Zero, Decimal.Zero, Decimal.Zero, Decimal.Zero, Decimal.Zero, Decimal.Zero, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, Decimal.Zero, Decimal.Zero, Decimal.Zero, Decimal.Zero, Decimal.Zero, Decimal.Zero, Decimal.Zero, Decimal.Zero, Decimal.Zero, Decimal.Zero, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, "", "", sTA, 0, 0, 0, 0, 4, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, Conversions.ToDecimal(current.Item("nKdvOrani")), 0, 0, 0, 0, 0, 0, 0, 0, str9, 0, "1000.0", "1000", KeyCode.kullaniciadi, "EVET", 0, 1, "*", "*", 0)
                                        Else
                                            str9 = Me.sorgula_logo_string(("Select P_ID from STOKGEN WHERE STK = '" & sTK & "'"))
                                        End If
                                        Dim mIKTAR As New Decimal
                                        Dim mIKTAR1 As New Decimal
                                        Dim mIKTAR2 As New Decimal
                                        Dim num26 As New Decimal
                                        Dim num27 As New Decimal
                                        Dim num33 As New Decimal
                                        Dim num31 As New Decimal
                                        Dim kARTDOVIZTUTAR As New Decimal
                                        Dim num29 As New Decimal
                                        Dim str11 As String = Conversions.ToString(current.Item("sAciklama"))
                                        Dim left As New Decimal
                                        Dim num24 As Long = 0
                                        Try
                                            obj5 = KeyCode.sorgu_sayi(RuntimeHelpers.GetObjectValue(current.Item("sDepo")), Decimal.Zero)
                                        Catch exception11 As Exception
                                            ProjectData.SetProjectError(exception11)
                                            Dim exception6 As Exception = exception11
                                            obj5 = 1
                                            ProjectData.ClearProjectError()
                                        End Try
                                        Dim strArray As String() = current.Item("sKisaAdi").ToString.Split(New Char() {";"c})
                                        num24 = 0
                                        If Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(current.Item("nGirisCikis"), 1, False), Operators.CompareObjectEqual(current.Item("nGirisCikis"), 2, False))) Then
                                            mIKTAR = Conversions.ToDecimal(current.Item("lGirisMiktar1"))
                                            mIKTAR1 = Conversions.ToDecimal(current.Item("lBirimMiktar"))
                                            num26 = Conversions.ToDecimal(current.Item("lBrutFiyat"))
                                            num27 = Conversions.ToDecimal(current.Item("lBrutTutar"))
                                            num33 = Conversions.ToDecimal(current.Item("nIskontoYuzdesi"))
                                            num31 = Conversions.ToDecimal(current.Item("lIskontoTutari"))
                                            kARTDOVIZTUTAR = Conversions.ToDecimal(current.Item("lGirisFiyat"))
                                            num29 = Conversions.ToDecimal(current.Item("lGirisTutar"))
                                            left = Conversions.ToDecimal(current.Item("lGirisTutar"))
                                            KeyCode.sSaticiRumuzu = current.Item("sSaticiRumuzu").ToString
                                            mIKTAR2 = mIKTAR / mIKTAR1
                                        ElseIf Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(current.Item("nGirisCikis"), 3, False), Operators.CompareObjectEqual(current.Item("nGirisCikis"), 4, False))) Then
                                            mIKTAR = Conversions.ToDecimal(current.Item("lCikisMiktar1"))
                                            mIKTAR1 = Conversions.ToDecimal(current.Item("lBirimMiktar"))
                                            num26 = Conversions.ToDecimal(current.Item("lBrutFiyat"))
                                            num27 = Conversions.ToDecimal(current.Item("lBrutTutar"))
                                            num33 = Conversions.ToDecimal(current.Item("nIskontoYuzdesi"))
                                            num31 = Conversions.ToDecimal(current.Item("lIskontoTutari"))
                                            kARTDOVIZTUTAR = Conversions.ToDecimal(current.Item("lCikisFiyat"))
                                            num29 = Conversions.ToDecimal(current.Item("lCikisTutar"))
                                            left = Conversions.ToDecimal(current.Item("lCikisTutar"))
                                            KeyCode.sSaticiRumuzu = current.Item("sSaticiRumuzu").ToString
                                            mIKTAR2 = mIKTAR / mIKTAR1
                                        End If
                                        Dim birim2 As String = Trim(Conversions.ToString(current.Item("sBirimCinsi1")))
                                        If birim2 = "AD" Then
                                            birim2 = "ADET"
                                        ElseIf birim2 = "KO" Then
                                            birim2 = "KOLİ"
                                        ElseIf birim2 = "PL" Then
                                            birim2 = "PALET"
                                        End If
                                        Dim obj3 As Object = Me.sorgula_logo_string("Select LOWER(NEWID())")
                                        Dim obj4 As Object = Me.FATURA_ALT_kaydet_yeni(0, "N", num11, sTK, sTA, birim2, Conversions.ToString(1), "", mIKTAR2, Decimal.One, Conversions.ToDecimal(current.Item("lBrutFiyat")), Conversions.ToDecimal(current.Item("lBrutTutar")), Conversions.ToDecimal(current.Item("nKdvOrani")), Conversions.ToDecimal(current.Item("lKdvTutari")), Decimal.Zero, Decimal.Zero, Decimal.Zero, Conversions.ToDecimal(current.Item("nIskontoYuzdesi")), Conversions.ToDecimal(current.Item("lIskontoTutari")), Conversions.ToDecimal(current.Item("nIskontoYuzdesi")), Decimal.Zero, Decimal.Zero, Decimal.Zero, Decimal.Zero, Decimal.Zero, "", "", Conversions.ToString(current.Item("sKullaniciAdi")), 4, num13, tURAC, nGirisCikis, Conversions.ToDecimal(current.Item("lIskontoTutari")), Conversions.ToDecimal(current.Item("lGirisMiktar1")), Conversions.ToDecimal(current.Item("lCikisMiktar1")), Conversions.ToDecimal(current.Item("lGirisFiyat")), Conversions.ToDecimal(current.Item("lCikisFiyat")), Decimal.Zero, Decimal.Zero, Conversions.ToDecimal(current.Item("lGirisTutar")), Conversions.ToDecimal(current.Item("lCikisTutar")), mIKTAR, fATREF, 0, 0, Conversions.ToString(dataRow.Item("lFisNo")), 1, 1, 0, 1, "MERKEZ", "", Conversions.ToString(current.Item("sSonKullaniciAdi")), KeyCode.sSaticiRumuzu, 0, Conversions.ToDate(dataRow.Item("dteFisTarihi")), 1, Conversions.ToString(dataRow.Item("lFisNo")), rEF, 1, 0, 0, mIKTAR, CLng(num9), "", str4, 1, 1, 0, 0, 0, Conversions.ToDecimal(Operators.SubtractObject(left, current.Item("lKdvTutari"))), 0, 1, 0, 2, Decimal.One, 1, kARTDOVIZTUTAR, Decimal.Zero, Decimal.Zero, Conversions.ToString(obj3), "*", "*", str9, 0, Conversions.ToString(current.Item("sKullaniciAdi")), Conversions.ToDecimal(current.Item("lKdvTutari")), 0, 0, 0, "", "STANDART", 0, 0, Conversions.ToDate(current.Item("dteFisTarihi")), 1, Conversions.ToDecimal(current.Item("lCikisTutar")), Decimal.Zero, Decimal.Zero, Conversions.ToDecimal(current.Item("lCikisTutar")))
                                        num9 += 1
                                    Loop
                                Finally
                                    If TypeOf enumerator Is IDisposable Then
                                        TryCast(enumerator, IDisposable).Dispose()
                                    End If
                                End Try
                            End If
                        Next
                        XtraMessageBox.Show(KeyCode.Sorgu_sDil("İşlem Başarıyla Tamamlandı...", KeyCode.sDil), KeyCode.Sorgu_sDil("Dikkat", KeyCode.sDil), MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                        Me.bar1.Visible = False
                    End If
                    current = Nothing
                End If
            End If
            Me.sCon.Close()
            Me.connection = RuntimeHelpers.GetObjectValue(objectValue)
            KeyCode.sConnection = Conversions.ToString(sConnection)
        End If
    End Sub
    'Public Function stok(ByVal ara As String, ByVal konum As String, ByVal ara_kriter As String, ByVal sFisTipi As String, ByVal nGirisCikis As String, ByVal dteFisTarihi1 As DateTime, ByVal dteFisTarihi2 As DateTime, ByVal lFisNo1 As Long, ByVal lFisNo2 As Long, ByVal lNetTutar1 As Decimal, ByVal lNetTutar2 As Decimal, ByVal sDepo As String, ByVal sHareketTipi As String, ByVal sSaticiRumuzu As String, ByVal ara_stok As String, ByVal stok_konum As String, ByVal ara_kriter_stok As String, ByVal nSiparisID As String) As DataSet
    '    Dim right As String = ("WHERE (tbStokFisiMaster.sFisTipi = '" & sFisTipi & "')")
    '    If (Me.sec_sTarihTipi.SelectedIndex = 0) Then
    '        right = String.Concat(New String() {right, " AND tbStokFisiMaster.dteFisTarihi between '", Conversions.ToString(dteFisTarihi1), "' and '", Conversions.ToString(dteFisTarihi2), "' "})
    '    ElseIf (Me.sec_sTarihTipi.SelectedIndex = 1) Then
    '        dteFisTarihi1 = Conversions.ToDate((Strings.Left(dteFisTarihi1.ToString, 10) & " 00:00:00"))
    '        dteFisTarihi2 = Conversions.ToDate((Strings.Left(dteFisTarihi2.ToString, 10) & " 23:59:59"))
    '        right = String.Concat(New String() {right, " AND tbStokFisiMaster.dteKayitTarihi between '", Conversions.ToString(dteFisTarihi1), "' and '", Conversions.ToString(dteFisTarihi2), "' "})
    '    Else
    '        right = String.Concat(New String() {right, " AND tbStokFisiMaster.dteFisTarihi between '", Conversions.ToString(dteFisTarihi1), "' and '", Conversions.ToString(dteFisTarihi2), "' "})
    '    End If
    '    right = String.Concat(New String() {right, " and tbStokFisiMaster.lFisNo between '", Conversions.ToString(lFisNo1), "' and '", Conversions.ToString(lFisNo2), "'"})
    '    right = String.Concat(New String() {right, " and tbStokFisiMaster.lNetTutar between '", Conversions.ToString(lNetTutar1), "' and '", Conversions.ToString(lNetTutar2), "'"})
    '    If (Trim(sHareketTipi) <> "") Then
    '        right = (right & " And tbStokFisiMaster.sHareketTipi = '" & sHareketTipi & "' ")
    '    End If
    '    If (Conversions.ToDouble(nGirisCikis) > 0) Then
    '        right = (right & " and tbStokFisiMaster.nGirisCikis =" & nGirisCikis & " ")
    '    End If
    '    If (Trim(Me.txt_sKaydeden.Text) <> "") Then
    '        right = (right & " and tbStokFisiMaster.sKullaniciAdi ='" & Trim(Me.txt_sKaydeden.Text) & "'")
    '    End If
    '    If (Trim(sFisTipi) = "PF") Then
    '        If (Trim(ara.ToString) <> "") Then
    '            If (Me.sec_konum.Text = KeyCode.Sorgu_sDil("Kodu", KeyCode.sDil)) Then
    '                right = (right & " AND   (tbMusteri.lKodu " & Me.sorgu_kriter_string(ara, ara_kriter) & " )")
    '            ElseIf (Me.sec_konum.Text = KeyCode.Sorgu_sDil("Adı", KeyCode.sDil)) Then
    '                right = (right & " AND  (tbMusteri.sAdi " & Me.sorgu_kriter_string(ara, ara_kriter) & " )")
    '            End If
    '        End If
    '    ElseIf (Trim(ara.ToString) <> "") Then
    '        If (Me.sec_konum.Text = KeyCode.Sorgu_sDil("Kodu", KeyCode.sDil)) Then
    '            right = (right & " AND   (tbFirma.sKodu " & Me.sorgu_kriter_string(ara, ara_kriter) & " )")
    '        ElseIf (Me.sec_konum.Text = KeyCode.Sorgu_sDil("Adı", KeyCode.sDil)) Then
    '            right = (right & " AND  (tbFirma.sAciklama " & Me.sorgu_kriter_string(ara, ara_kriter) & " )")
    '        End If
    '    End If
    '    If (Trim(sDepo) <> KeyCode.Sorgu_sDil("[Tümü]", KeyCode.sDil)) Then
    '        If (Me.sec_sTarihTipi.SelectedIndex = 0) Then
    '            right = String.Concat(New String() {right, " And tbStokFisiMaster.nStokFisiID IN  (SELECT DISTINCT nStokFisiID FROM         tbStokFisiDetayi WHERE     (sDepo IN (", sDepo, ")) and (dteFisTarihi between '", Conversions.ToString(dteFisTarihi1), "' and '", Conversions.ToString(dteFisTarihi2), "') and (sFisTipi ='", sFisTipi, "') and (nGirisCikis =", nGirisCikis, ") and (lFisNo between '", Conversions.ToString(lFisNo1), "' and '", Conversions.ToString(lFisNo2), "') )"})
    '        ElseIf (Me.sec_sTarihTipi.SelectedIndex = 1) Then
    '            right = String.Concat(New String() {right, " And tbStokFisiMaster.nStokFisiID IN  (SELECT DISTINCT nStokFisiID FROM         tbStokFisiDetayi WHERE     (sDepo IN (", sDepo, ")) and (dteKayitTarihi between '", Conversions.ToString(dteFisTarihi1), "' and '", Conversions.ToString(dteFisTarihi2), "') and (sFisTipi ='", sFisTipi, "') and (nGirisCikis =", nGirisCikis, ") and (lFisNo between '", Conversions.ToString(lFisNo1), "' and '", Conversions.ToString(lFisNo2), "') )"})
    '        End If
    '    End If
    '    If (Trim(sSaticiRumuzu) <> "") Then
    '        If (Me.sec_sTarihTipi.SelectedIndex = 0) Then
    '            right = String.Concat(New String() {right, " And tbStokFisiMaster.nStokFisiID IN  (SELECT DISTINCT nStokFisiID FROM         tbStokFisiDetayi WHERE     (sSaticiRumuzu IN ('", sSaticiRumuzu, "')) and (dteFisTarihi between '", Conversions.ToString(dteFisTarihi1), "' and '", Conversions.ToString(dteFisTarihi2), "') and (sFisTipi ='", sFisTipi, "') and (nGirisCikis =", nGirisCikis, ") and (lFisNo between '", Conversions.ToString(lFisNo1), "' and '", Conversions.ToString(lFisNo2), "') )"})
    '        ElseIf (Me.sec_sTarihTipi.SelectedIndex = 1) Then
    '            right = String.Concat(New String() {right, " And tbStokFisiMaster.nStokFisiID IN  (SELECT DISTINCT nStokFisiID FROM         tbStokFisiDetayi WHERE     (sSaticiRumuzu IN ('", sSaticiRumuzu, "')) and (dteKayitTarihi between '", Conversions.ToString(dteFisTarihi1), "' and '", Conversions.ToString(dteFisTarihi2), "') and (sFisTipi ='", sFisTipi, "') and (nGirisCikis =", nGirisCikis, ") and (lFisNo between '", Conversions.ToString(lFisNo1), "' and '", Conversions.ToString(lFisNo2), "') )"})
    '        End If
    '    End If
    '    If (Trim(nSiparisID) <> "") Then
    '        right = String.Concat(New String() {right, " And tbStokFisiMaster.nStokFisiID IN  (SELECT DISTINCT nStokFisiID FROM         tbStokFisiDetayi WHERE     (nSiparisID IN ('", nSiparisID, "')) and (dteFisTarihi between '", Conversions.ToString(dteFisTarihi1), "' and '", Conversions.ToString(dteFisTarihi2), "') and (sFisTipi ='", sFisTipi, "') and (nGirisCikis =", nGirisCikis, ") and (lFisNo between '", Conversions.ToString(lFisNo1), "' and '", Conversions.ToString(lFisNo2), "') )"})
    '    End If
    '    If (Me.sec_bFaturayaDonustumu.Text <> KeyCode.Sorgu_sDil("[Tümü]", KeyCode.sDil)) Then
    '        If (Me.sec_bFaturayaDonustumu.SelectedIndex = 1) Then
    '            right = (right & " And tbStokFisiMaster.bFaturayaDonustumu = 1 ")
    '        ElseIf (Me.sec_bFaturayaDonustumu.SelectedIndex = 2) Then
    '            right = (right & " And tbStokFisiMaster.bFaturayaDonustumu = 0 ")
    '        End If
    '    End If
    '    If Me.sec_bEfatura.Checked Then
    '        right = (right & " And tbStokFisiMaster.bEfatura = 1 ")
    '    End If
    '    If Me.sec_bPesinmi.Checked Then
    '        right = (right & " And tbStokFisiMaster.bPesinmi = 1 ")
    '    End If
    '    If (ara_stok.ToString <> "") Then
    '        If (stok_konum = KeyCode.Sorgu_sDil("Kod", KeyCode.sDil)) Then
    '            right = String.Concat(New String() {right, " and tbStokFisiMaster.nStokFisiID IN (SELECT DISTINCT tbStokFisiDetayi.nStokFisiID FROM tbStokFisiDetayi INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID Where tbStokFisiDetayi.dteFisTarihi between '", Conversions.ToString(dteFisTarihi1), "' and '", Conversions.ToString(dteFisTarihi2), "' and tbStokFisiDetayi.sFisTipi = '", sFisTipi, "' AND ( tbStok.sKodu ", Me.sorgu_kriter_string(ara_stok, ara_kriter_stok), " ))"})
    '        ElseIf (stok_konum = KeyCode.Sorgu_sDil("Ad", KeyCode.sDil)) Then
    '            right = String.Concat(New String() {right, " and tbStokFisiMaster.nStokFisiID IN (SELECT DISTINCT tbStokFisiDetayi.nStokFisiID FROM tbStokFisiDetayi INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID Where tbStokFisiDetayi.dteFisTarihi between '", Conversions.ToString(dteFisTarihi1), "' and '", Conversions.ToString(dteFisTarihi2), "' and tbStokFisiDetayi.sFisTipi = '", sFisTipi, "' AND ( tbStok.sAciklama ", Me.sorgu_kriter_string(ara_stok, ara_kriter_stok), " ))"})
    '        ElseIf (stok_konum = KeyCode.Sorgu_sDil("Sınıf1", KeyCode.sDil)) Then
    '            right = String.Concat(New String() {right, " and tbStokFisiMaster.nStokFisiID IN (SELECT DISTINCT tbStokFisiDetayi.nStokFisiID FROM tbStokFisiDetayi INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID Where tbStokFisiDetayi.dteFisTarihi between '", Conversions.ToString(dteFisTarihi1), "' and '", Conversions.ToString(dteFisTarihi2), "' and tbStokFisiDetayi.sFisTipi = '", sFisTipi, "' AND tbStok.nStokID IN ( SELECT     tbStok.nStokID FROM         tbStok INNER JOIN  tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN  tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu WHERE tbSSinif1.sAciklama ", Me.sorgu_kriter_string(ara_stok, ara_kriter_stok), " ))"})
    '        ElseIf (stok_konum = KeyCode.Sorgu_sDil("Sınıf2", KeyCode.sDil)) Then
    '            right = String.Concat(New String() {right, " and tbStokFisiMaster.nStokFisiID IN (SELECT DISTINCT tbStokFisiDetayi.nStokFisiID FROM tbStokFisiDetayi INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID Where tbStokFisiDetayi.dteFisTarihi between '", Conversions.ToString(dteFisTarihi1), "' and '", Conversions.ToString(dteFisTarihi2), "' and tbStokFisiDetayi.sFisTipi = '", sFisTipi, "' AND tbStok.nStokID IN ( SELECT     tbStok.nStokID FROM         tbStok INNER JOIN  tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN  tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu WHERE tbSSinif2.sAciklama ", Me.sorgu_kriter_string(ara_stok, ara_kriter_stok), " ))"})
    '        ElseIf (stok_konum = KeyCode.Sorgu_sDil("Sınıf3", KeyCode.sDil)) Then
    '            right = String.Concat(New String() {right, " and tbStokFisiMaster.nStokFisiID IN (SELECT DISTINCT tbStokFisiDetayi.nStokFisiID FROM tbStokFisiDetayi INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID Where tbStokFisiDetayi.dteFisTarihi between '", Conversions.ToString(dteFisTarihi1), "' and '", Conversions.ToString(dteFisTarihi2), "' and tbStokFisiDetayi.sFisTipi = '", sFisTipi, "' AND tbStok.nStokID IN ( SELECT     tbStok.nStokID FROM         tbStok INNER JOIN  tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN  tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu WHERE tbSSinif3.sAciklama ", Me.sorgu_kriter_string(ara_stok, ara_kriter_stok), " ))"})
    '        ElseIf (stok_konum = KeyCode.Sorgu_sDil("Sınıf4", KeyCode.sDil)) Then
    '            right = String.Concat(New String() {right, " and tbStokFisiMaster.nStokFisiID IN (SELECT DISTINCT tbStokFisiDetayi.nStokFisiID FROM tbStokFisiDetayi INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID Where tbStokFisiDetayi.dteFisTarihi between '", Conversions.ToString(dteFisTarihi1), "' and '", Conversions.ToString(dteFisTarihi2), "' and tbStokFisiDetayi.sFisTipi = '", sFisTipi, "' AND tbStok.nStokID IN ( SELECT     tbStok.nStokID FROM         tbStok INNER JOIN  tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN  tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu WHERE tbSSinif4.sAciklama ", Me.sorgu_kriter_string(ara_stok, ara_kriter_stok), " ))"})
    '        ElseIf (stok_konum = KeyCode.Sorgu_sDil("Sınıf5", KeyCode.sDil)) Then
    '            right = String.Concat(New String() {right, " and tbStokFisiMaster.nStokFisiID IN (SELECT DISTINCT tbStokFisiDetayi.nStokFisiID FROM tbStokFisiDetayi INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID Where tbStokFisiDetayi.dteFisTarihi between '", Conversions.ToString(dteFisTarihi1), "' and '", Conversions.ToString(dteFisTarihi2), "' and tbStokFisiDetayi.sFisTipi = '", sFisTipi, "' AND tbStok.nStokID IN ( SELECT     tbStok.nStokID FROM         tbStok INNER JOIN  tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN  tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu WHERE tbSSinif5.sAciklama ", Me.sorgu_kriter_string(ara_stok, ara_kriter_stok), " ))"})
    '        ElseIf (stok_konum = KeyCode.Sorgu_sDil("Sınıf6", KeyCode.sDil)) Then
    '            right = String.Concat(New String() {right, " and tbStokFisiMaster.nStokFisiID IN (SELECT DISTINCT tbStokFisiDetayi.nStokFisiID FROM tbStokFisiDetayi INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID Where tbStokFisiDetayi.dteFisTarihi between '", Conversions.ToString(dteFisTarihi1), "' and '", Conversions.ToString(dteFisTarihi2), "' and tbStokFisiDetayi.sFisTipi = '", sFisTipi, "' AND tbStok.nStokID IN ( SELECT     tbStok.nStokID FROM         tbStok INNER JOIN  tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN  tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu WHERE tbSSinif6.sAciklama ", Me.sorgu_kriter_string(ara_stok, ara_kriter_stok), " ))"})
    '        ElseIf (stok_konum = KeyCode.Sorgu_sDil("Sınıf7", KeyCode.sDil)) Then
    '            right = String.Concat(New String() {right, " and tbStokFisiMaster.nStokFisiID IN (SELECT DISTINCT tbStokFisiDetayi.nStokFisiID FROM tbStokFisiDetayi INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID Where tbStokFisiDetayi.dteFisTarihi between '", Conversions.ToString(dteFisTarihi1), "' and '", Conversions.ToString(dteFisTarihi2), "' and tbStokFisiDetayi.sFisTipi = '", sFisTipi, "' AND tbStok.nStokID IN ( SELECT     tbStok.nStokID FROM         tbStok INNER JOIN  tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN  tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu WHERE tbSSinif7.sAciklama ", Me.sorgu_kriter_string(ara_stok, ara_kriter_stok), " ))"})
    '        ElseIf (stok_konum = KeyCode.Sorgu_sDil("Sınıf8", KeyCode.sDil)) Then
    '            right = String.Concat(New String() {right, " and tbStokFisiMaster.nStokFisiID IN (SELECT DISTINCT tbStokFisiDetayi.nStokFisiID FROM tbStokFisiDetayi INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID Where tbStokFisiDetayi.dteFisTarihi between '", Conversions.ToString(dteFisTarihi1), "' and '", Conversions.ToString(dteFisTarihi2), "' and tbStokFisiDetayi.sFisTipi = '", sFisTipi, "' AND tbStok.nStokID IN ( SELECT     tbStok.nStokID FROM         tbStok INNER JOIN  tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN  tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu WHERE tbSSinif8.sAciklama ", Me.sorgu_kriter_string(ara_stok, ara_kriter_stok), " ))"})
    '        ElseIf (stok_konum = KeyCode.Sorgu_sDil("Sınıf9", KeyCode.sDil)) Then
    '            right = String.Concat(New String() {right, " and tbStokFisiMaster.nStokFisiID IN (SELECT DISTINCT tbStokFisiDetayi.nStokFisiID FROM tbStokFisiDetayi INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID Where tbStokFisiDetayi.dteFisTarihi between '", Conversions.ToString(dteFisTarihi1), "' and '", Conversions.ToString(dteFisTarihi2), "' and tbStokFisiDetayi.sFisTipi = '", sFisTipi, "' AND tbStok.nStokID IN ( SELECT     tbStok.nStokID FROM         tbStok INNER JOIN  tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN  tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu WHERE tbSSinif9.sAciklama ", Me.sorgu_kriter_string(ara_stok, ara_kriter_stok), " ))"})
    '        ElseIf (stok_konum = KeyCode.Sorgu_sDil("Sınıf10", KeyCode.sDil)) Then
    '            right = String.Concat(New String() {right, " and tbStokFisiMaster.nStokFisiID IN (SELECT DISTINCT tbStokFisiDetayi.nStokFisiID FROM tbStokFisiDetayi INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID Where tbStokFisiDetayi.dteFisTarihi between '", Conversions.ToString(dteFisTarihi1), "' and '", Conversions.ToString(dteFisTarihi2), "' and tbStokFisiDetayi.sFisTipi = '", sFisTipi, "' AND tbStok.nStokID IN ( SELECT     tbStok.nStokID FROM         tbStok INNER JOIN  tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN  tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu WHERE tbSSinif10.sAciklama ", Me.sorgu_kriter_string(ara_stok, ara_kriter_stok), " ))"})
    '        ElseIf (stok_konum = KeyCode.Sorgu_sDil("Barkod", KeyCode.sDil)) Then
    '            right = String.Concat(New String() {right, " and tbStokFisiMaster.nStokFisiID IN (SELECT DISTINCT tbStokFisiDetayi.nStokFisiID FROM tbStokFisiDetayi INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID Where tbStokFisiDetayi.dteFisTarihi between '", Conversions.ToString(dteFisTarihi1), "' and '", Conversions.ToString(dteFisTarihi2), "' and tbStokFisiDetayi.sFisTipi = '", sFisTipi, "' AND tbStok.nStokID IN ( SELECT     tbStok.nStokID  FROM         tbStok INNER JOIN                       tbStokBarkodu ON tbStok.nStokID = tbStokBarkodu.nStokID WHERE tbStokBarkodu.sBarkod ", Me.sorgu_kriter_string(ara_stok, ara_kriter_stok), " ))"})
    '        End If
    '    End If
    '    If (Me.txt_sAciklama1.Text <> "") Then
    '        If (Me.sec_sAciklamaTipi.Text = KeyCode.Sorgu_sDil("Not1:", KeyCode.sDil)) Then
    '            right = String.Concat(New String() {right, " AND tbStokFisiMaster.nStokFisiID IN (SELECT tbStokFisiAciklamasi.nStokFisiID FROM tbStokFisiAciklamasi INNER JOIN tbStokFisiMaster ON tbStokFisiAciklamasi.nStokFisiID = tbStokFisiMaster.nStokFisiID WHERE (tbStokFisiMaster.dteFisTarihi BETWEEN '", Conversions.ToString(dteFisTarihi1), "' AND '", Conversions.ToString(dteFisTarihi2), "') and (tbStokFisiMaster.sFisTipi = '", sFisTipi, "') and (tbStokFisiMaster.lFisNo between '", Conversions.ToString(lFisNo1), "' and '", Conversions.ToString(lFisNo2), "') and (tbStokFisiAciklamasi.sAciklama1 like '", Me.txt_sAciklama1.Text, "%') )"})
    '        ElseIf (Me.sec_sAciklamaTipi.Text = KeyCode.Sorgu_sDil("Not2:", KeyCode.sDil)) Then
    '            right = String.Concat(New String() {right, " AND tbStokFisiMaster.nStokFisiID IN (SELECT tbStokFisiAciklamasi.nStokFisiID FROM tbStokFisiAciklamasi INNER JOIN tbStokFisiMaster ON tbStokFisiAciklamasi.nStokFisiID = tbStokFisiMaster.nStokFisiID WHERE (tbStokFisiMaster.dteFisTarihi BETWEEN '", Conversions.ToString(dteFisTarihi1), "' AND '", Conversions.ToString(dteFisTarihi2), "') and (tbStokFisiMaster.sFisTipi = '", sFisTipi, "') and (tbStokFisiMaster.lFisNo between '", Conversions.ToString(lFisNo1), "' and '", Conversions.ToString(lFisNo2), "') and (tbStokFisiAciklamasi.sAciklama2 like '", Me.txt_sAciklama1.Text, "%') )"})
    '        ElseIf (Me.sec_sAciklamaTipi.Text = KeyCode.Sorgu_sDil("Not3:", KeyCode.sDil)) Then
    '            right = String.Concat(New String() {right, " AND tbStokFisiMaster.nStokFisiID IN (SELECT tbStokFisiAciklamasi.nStokFisiID FROM tbStokFisiAciklamasi INNER JOIN tbStokFisiMaster ON tbStokFisiAciklamasi.nStokFisiID = tbStokFisiMaster.nStokFisiID WHERE (tbStokFisiMaster.dteFisTarihi BETWEEN '", Conversions.ToString(dteFisTarihi1), "' AND '", Conversions.ToString(dteFisTarihi2), "') and (tbStokFisiMaster.sFisTipi = '", sFisTipi, "') and (tbStokFisiMaster.lFisNo between '", Conversions.ToString(lFisNo1), "' and '", Conversions.ToString(lFisNo2), "') and (tbStokFisiAciklamasi.sAciklama3 like '", Me.txt_sAciklama1.Text, "%') )"})
    '        ElseIf (Me.sec_sAciklamaTipi.Text = KeyCode.Sorgu_sDil("Not4:", KeyCode.sDil)) Then
    '            right = String.Concat(New String() {right, " AND tbStokFisiMaster.nStokFisiID IN (SELECT tbStokFisiAciklamasi.nStokFisiID FROM tbStokFisiAciklamasi INNER JOIN tbStokFisiMaster ON tbStokFisiAciklamasi.nStokFisiID = tbStokFisiMaster.nStokFisiID WHERE (tbStokFisiMaster.dteFisTarihi BETWEEN '", Conversions.ToString(dteFisTarihi1), "' AND '", Conversions.ToString(dteFisTarihi2), "') and (tbStokFisiMaster.sFisTipi = '", sFisTipi, "') and (tbStokFisiMaster.lFisNo between '", Conversions.ToString(lFisNo1), "' and '", Conversions.ToString(lFisNo2), "') and (tbStokFisiAciklamasi.sAciklama4 like '", Me.txt_sAciklama1.Text, "%') )"})
    '        ElseIf (Me.sec_sAciklamaTipi.Text = KeyCode.Sorgu_sDil("Not5:", KeyCode.sDil)) Then
    '            right = String.Concat(New String() {right, " AND tbStokFisiMaster.nStokFisiID IN (SELECT tbStokFisiAciklamasi.nStokFisiID FROM tbStokFisiAciklamasi INNER JOIN tbStokFisiMaster ON tbStokFisiAciklamasi.nStokFisiID = tbStokFisiMaster.nStokFisiID WHERE (tbStokFisiMaster.dteFisTarihi BETWEEN '", Conversions.ToString(dteFisTarihi1), "' AND '", Conversions.ToString(dteFisTarihi2), "') and (tbStokFisiMaster.sFisTipi = '", sFisTipi, "') and (tbStokFisiMaster.lFisNo between '", Conversions.ToString(lFisNo1), "' and '", Conversions.ToString(lFisNo2), "') and (tbStokFisiAciklamasi.sAciklama5 like '", Me.txt_sAciklama1.Text, "%') )"})
    '        ElseIf (Me.sec_sAciklamaTipi.Text = KeyCode.Sorgu_sDil("Açıklama:", KeyCode.sDil)) Then
    '            right = String.Concat(New String() {right, " AND tbStokFisiMaster.nStokFisiID IN (SELECT nStokFisiID FROM tbStokFisiDetayi  WHERE (tbStokFisiDetayi.dteFisTarihi BETWEEN '", Conversions.ToString(dteFisTarihi1), "' AND '", Conversions.ToString(dteFisTarihi2), "') and (tbStokFisiDetayi.sFisTipi = '", sFisTipi, "') and (tbStokFisiDetayi.lFisNo between '", Conversions.ToString(lFisNo1), "' and '", Conversions.ToString(lFisNo2), "') and (tbStokFisiDetayi.sKullaniciAdi like '", Me.txt_sAciklama1.Text, "%') )"})
    '        End If
    '    End If
    '    Dim nFaturaCiktiSatirSayisi As Integer = &H19
    '    If ((Conversions.ToDouble(nGirisCikis) = 3) Or (Conversions.ToDouble(nGirisCikis) = 4)) Then
    '        If (Trim(sFisTipi) = "FS") Then
    '            nFaturaCiktiSatirSayisi = Me.nFaturaCiktiSatirSayisi
    '        ElseIf (Trim(sFisTipi) = "IS") Then
    '            nFaturaCiktiSatirSayisi = Me.nIrsaliyeCiktiSatirSayisi
    '        ElseIf (Trim(sFisTipi) = "DC") Then
    '            nFaturaCiktiSatirSayisi = Me.nStokFisiCiktiSatirSayisi
    '        ElseIf (Trim(sFisTipi) = "HS") Then
    '            nFaturaCiktiSatirSayisi = Me.nFaturaCiktiSatirSayisi
    '        End If
    '    End If
    '    If (KeyCode.sDatabaseGenel = "BAMCO") Then
    '    End If
    '    Dim obj2 As Object = ""
    '    Me.sKriter = right
    '    Dim connection As New OleDbConnection
    '    Dim command As New OleDbCommand
    '    Dim adapter As New OleDbDataAdapter
    '    connection.ConnectionString = Conversions.ToString(Me.connection)
    '    command.CommandTimeout = 0
    '    adapter.SelectCommand = command
    '    If (Trim(sFisTipi) = "PF") Then
    '        command.CommandText = Me.sorgu_query(("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbStokFisiMaster.dteFisTarihi,ROUND(CAST(GETDATE() - (CAST(tbStokFisiMaster.dteFisTarihi AS INT) ) AS FLOAT), 0) AS GUN, ROUND(CAST(GETDATE() - (CAST(tbStokFisiMaster.dteFisTarihi AS INT) ) AS FLOAT), 0) * tbStokFisiMaster.lNetTutar AS HESAPLA,tbStokFisiMaster.lFisNo, tbStokFisiMaster.nGirisCikis, tbStokFisiMaster.lToplamMiktar, tbStokFisiMaster.lNetTutar, tbStokFisiMaster.sDepo, (SELECT sAciklama FROM tbDepo WHERE sDepo = tbStokFisiMaster.sDepo) AS Depo, tbStokFisiMaster.lTransferFisiID,tbStokFisiMaster.sTransferDepo, (SELECT sAciklama FROM tbDepo WHERE sDepo = tbStokFisiMaster.sTransferDepo) AS tDepo, tbStokFisiMaster.bFaturayaDonustumu AS sFaturalasti, tbStokFisiMaster.bPesinmi,tbStokFisiMaster.bMuhasebeyeIslendimi AS Muhasebelesti, tbStokFisiMaster.sHareketTipi, RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama1, '')) + ' ' + RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama2, '')) + ' ' + RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama3, '')) + ' ' + RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama4, '')) + ' ' + RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama5, '')) AS sNot, tbStokFisiMaster.bFisTamamlandimi AS Tamamlandi, tbStokFisiMaster.lTevkifatKdvMatrahi, tbStokFisiMaster.lTevkifatKdv, tbStokFisiMaster.lNetTutar AS lNetTutar, CONVERT (char(1), tbStokFisiMaster.bHizmetFaturasimi) AS Hizmet, tbStokFisiMaster.nFirmaID, tbStokFisiMaster.sFisTipi, tbStokFisiMaster.nStokFisiID, tbStokFisiMaster.lKdv1 + tbStokFisiMaster.lKdv2 + tbStokFisiMaster.lKdv3 + tbStokFisiMaster.lKdv4 + tbStokFisiMaster.lKdv5 AS KdvTutari, tbStokFisiMaster.lKdvMatrahi1 + tbStokFisiMaster.lKdvMatrahi2 + tbStokFisiMaster.lKdvMatrahi3 + tbStokFisiMaster.lKdvMatrahi4 + tbStokFisiMaster.lKdvMatrahi5 AS KdvMatrahi, tbStokFisiMaster.lEkmaliyet1 + tbStokFisiMaster.lEkmaliyet2 + tbStokFisiMaster.lEkmaliyet3 AS EkMaliyet, tbStokFisiMaster.lMalIskontoTutari, tbStokFisiMaster.lMalIskontoTutari+tbStokFisiMaster.lDipIskontoTutari1 + tbStokFisiMaster.lDipIskontoTutari2 + tbStokFisiMaster.lDipIskontoTutari3 as lIskontoTutari,tbStokFisiMaster.lMalBedeli, CAST(0 AS MONEY) AS ISKONTO, tbStokFisiMaster.lMalBedeli - tbStokFisiMaster.lMalIskontoTutari AS FATURATUTARI, CAST(0 AS MONEY) AS EkOran, tbStokFisiMaster.lDipIskontoTutari1 + tbStokFisiMaster.lDipIskontoTutari2 + tbStokFisiMaster.lDipIskontoTutari3 AS lDipIskontoTutari3, tbStokFisiMaster.lOTVMatrahi2,tbMusteri.nMusteriID, tbMusteri.lKodu AS sKodu, tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS sAciklama,'' as sFiyatTipi,tbStokFisiMaster.sKullaniciAdi,tbStokFisiMaster.dteKayitTarihi,tbStokFisiMaster.bKilitli,tbStokFisiMaster.bEfatura, tbStokFisiMaster.sEfaturaTipi, tbStokFisiMaster.sEfaturaGuid, tbStokFisiMaster.nEfaturaDurum FROM tbStokFisiMaster INNER JOIN tbHareketTipi ON tbStokFisiMaster.sHareketTipi = tbHareketTipi.sHareketTipi INNER JOIN tbStokFisiAciklamasi ON tbStokFisiMaster.nStokFisiID = tbStokFisiAciklamasi.nStokFisiID LEFT OUTER JOIN tbMusteri ON tbStokFisiMaster.lFisNo = tbMusteri.lKodu " & right & " ORDER BY tbStokFisiMaster.dteFisTarihi, tbStokFisiMaster.lFisNo"))
    '    Else
    '        command.CommandText = Me.sorgu_query(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbStokFisiMaster.dteFisTarihi, ROUND(CAST(GETDATE() - (CAST(tbStokFisiMaster.dteFisTarihi AS INT) ) AS FLOAT), 0) AS GUN, ROUND(CAST(GETDATE() - (CAST(tbStokFisiMaster.dteFisTarihi AS INT) ) AS FLOAT), 0) * tbStokFisiMaster.lNetTutar AS HESAPLA,tbStokFisiMaster.lFisNo, tbStokFisiMaster.nGirisCikis, tbStokFisiMaster.lToplamMiktar, tbStokFisiMaster.lNetTutar, tbStokFisiMaster.sDepo, (SELECT sAciklama FROM tbDepo WHERE sDepo = tbStokFisiMaster.sDepo) AS Depo, tbStokFisiMaster.lTransferFisiID,tbFirma.sKodu, sAciklama = Case When tbStokFisiMaster.bPesinmi =1 and tbStokFisiPesinAdres.sAciklama <> '' THEN tbStokFisiPesinAdres.sAciklama ELSE tbFirma.sAciklama END, tbFirma.sAdres1,tbFirma.sAdres2,tbFirma.sIl,tbFirma.sUlke,tbFirma.sPostaKodu,tbFirma.nOzelIskontosu as nIskontoYuzdesi,tbFirma.lKrediLimiti,tbFirma.sVergiDairesi,tbFirma.sVergiNo,'' sYetkili,tbFirma.sFiyatTipi,tbStokFisiMaster.sTransferDepo, (SELECT sAciklama FROM tbDepo WHERE sDepo = tbStokFisiMaster.sTransferDepo) AS tDepo, tbStokFisiMaster.bFaturayaDonustumu AS sFaturalasti,tbStokFisiMaster.bPesinmi, tbStokFisiMaster.bMuhasebeyeIslendimi AS Muhasebelesti, tbStokFisiMaster.sHareketTipi, RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama1, '')) + ' ' + RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama2, '')) + ' ' + RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama3, '')) + ' ' + RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama4, '')) + ' ' + RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama5, '')) AS sNot,  tbStokFisiMaster.bFisTamamlandimi AS Tamamlandi, tbStokFisiMaster.lTevkifatKdvMatrahi, tbStokFisiMaster.lTevkifatKdv, tbStokFisiMaster.lNetTutar AS lNetTutar, CONVERT (char(1), tbStokFisiMaster.bHizmetFaturasimi) AS Hizmet, tbStokFisiMaster.nFirmaID, tbStokFisiMaster.sFisTipi, tbStokFisiMaster.nStokFisiID, tbStokFisiMaster.lKdv1+ tbStokFisiMaster.lKdv2+ tbStokFisiMaster.lKdv3+ tbStokFisiMaster.lKdv4+ tbStokFisiMaster.lKdv5 as KdvTutari,tbStokFisiMaster.lKdvMatrahi1+tbStokFisiMaster.lKdvMatrahi2+tbStokFisiMaster.lKdvMatrahi3+tbStokFisiMaster.lKdvMatrahi4+tbStokFisiMaster.lKdvMatrahi5 as KdvMatrahi,tbStokFisiMaster.lEkmaliyet1+tbStokFisiMaster.lEkmaliyet2+tbStokFisiMaster.lEkmaliyet3 as EkMaliyet, tbStokFisiMaster.lMalIskontoTutari,tbStokFisiMaster.lMalIskontoTutari+tbStokFisiMaster.lDipIskontoTutari1 + tbStokFisiMaster.lDipIskontoTutari2 + tbStokFisiMaster.lDipIskontoTutari3 as lIskontoTutari,tbStokFisiMaster.lMalBedeli,tbStokFisiMaster.lOTVMatrahi2,ISKONTO = CASE WHEN (tbStokFisiMaster.lMalIskontoTutari + tbStokFisiMaster.lDipIskontoTutari1 + tbStokFisiMaster.lDipIskontoTutari2 + tbStokFisiMaster.lDipIskontoTutari3) = 0 OR tbStokFisiMaster.lMalBedeli = 0 THEN 0 ELSE (tbStokFisiMaster.lMalIskontoTutari + tbStokFisiMaster.lDipIskontoTutari1 + tbStokFisiMaster.lDipIskontoTutari2 + tbStokFisiMaster.lDipIskontoTutari3) / tbStokFisiMaster.lMalBedeli END, EkOran = CASE WHEN tbStokFisiMaster.lEkmaliyet1 + tbStokFisiMaster.lEkmaliyet2 + tbStokFisiMaster.lEkmaliyet3 = 0 OR tbStokFisiMaster.lMalBedeli = 0 THEN 0 ELSE (tbStokFisiMaster.lEkmaliyet1 + tbStokFisiMaster.lEkmaliyet2 + tbStokFisiMaster.lEkmaliyet3) / (tbStokFisiMaster.lMalBedeli - tbStokFisiMaster.lMalIskontoTutari - tbStokFisiMaster.lDipIskontoTutari1 - tbStokFisiMaster.lDipIskontoTutari2 - tbStokFisiMaster.lDipIskontoTutari3) END,tbStokFisiMaster.lMalBedeli - tbStokFisiMaster.lMalIskontoTutari AS FATURATUTARI,tbStokFisiMaster.lDipIskontoTutari1 + tbStokFisiMaster.lDipIskontoTutari2 + tbStokFisiMaster.lDipIskontoTutari3 AS lDipIskontoTutari,tbStokFisiMaster.lOTV2,tbStokFisiMaster.sKullaniciAdi,tbStokFisiMaster.dteKayitTarihi,tbStokFisiMaster.bKilitli,tbStokFisiMaster.bEfatura, tbStokFisiMaster.sEfaturaTipi, tbStokFisiMaster.sEfaturaGuid, (SELECT      SUM(lAlacakTutar)  AS lTahsilat FROM         tbFirmaHareketi  Where nFirmaID = tbStokFisiMaster.nFirmaID  and dteIslemTarihi = tbStokFisiMaster.dteFisTarihi and sCariIslem IN ('','N','AC','AS','TCG','CG')) as lTahsilat,(Select ISNULL(SUM(lBorcTutar-lAlacakTutar),0) as lBakiye from tbFirmaHareketi where nFirmaID = tbFirma.nFirmaID and tbFirmaHareketi.dteIslemTarihi <= tbStokFisiMaster.dteFisTarihi) as lBakiye,tbDoviz.sDovizCinsi1,tbDoviz.lDovizKuru1,tbStokFisiMaster.nEfaturaDurum ", obj2), "  FROM tbFirma INNER JOIN tbStokFisiMaster ON tbFirma.nFirmaID = tbStokFisiMaster.nFirmaID INNER JOIN tbHareketTipi ON tbStokFisiMaster.sHareketTipi = tbHareketTipi.sHareketTipi INNER JOIN tbStokFisiAciklamasi ON tbStokFisiMaster.nStokFisiID = tbStokFisiAciklamasi.nStokFisiID LEFT OUTER JOIN tbStokFisiPesinAdres ON tbStokFisiMaster.nStokFisiID = tbStokFisiPesinAdres.nStokFisiID LEFT OUTER JOIN (SELECT     TOP 1 tbStokFisiMaster.nStokFisiID, ISNULL(sDovizCinsi1,'') sDovizCinsi1, lDovizKuru1 = Case When ISNULL(lDovizKuru1,0) = 0 THEN 1 ELSE lDovizKuru1 END FROM          tbStokFisiDetayi INNER JOIN tbStokFisiMaster ON tbStokFisiMaster.nStokFisiID = tbStokFisiDetayi.nStokFisiID INNER JOIN tbFirma ON tbStokFisiDetayi.nFirmaID = tbFirma.nFirmaID "), right), " GROUP BY tbStokFisiMaster.nStokFisiID, sDovizCinsi1, lDovizKuru1 ORDER BY tbStokFisiMaster.nStokFisiID,sDovizCinsi1 DESC) tbDoviz ON tbStokFisiMaster.nStokFisiID = tbDoviz.nStokFisiID "), right), " ORDER BY tbStokFisiMaster.dteFisTarihi, tbStokFisiMaster.lFisNo")))
    '    End If
    '    Me.sSorgu_Hareket = command.CommandText
    '    command.Connection = connection
    '    connection.Open()
    '    Dim dataSet As New DataSet
    '    Dim num As Integer = adapter.Fill(dataSet, "Table1")
    '    connection.Close()
    '    Return dataSet
    'End Function
    Private Sub dataload_tbFisTipi()
        ds_tbFisTipi = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT sFisTipi, sAciklama FROM tbFisTipi Where sFisTipi IN ('DG', 'DC', 'FS', 'FA', 'HA', 'HS', 'IA', 'IS', 'MM', 'PF', 'T', 'DDC', 'DDG', 'DFA', 'DFS', 'DIA', 'DIS', 'DT')"))
        sec_sFisTipi.Properties.DataSource = ds_tbFisTipi.Tables(0)
        'sec_sFisTipi.EditValue = sFisTipi
        sec_sFisTipi.ItemIndex = 0
    End Sub
    Private Sub dataload_tbGirisCikis(ByVal nGirisCikis As Int64)
        If kapla = False Then
            ds_tbGirisCikis = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT nGirisCikis,sAciklama FROM tbGirisCikis Where nGirisCikis = '" & nGirisCikis & "'"))
            sec_nGirisCikis.Properties.DataSource = ds_tbGirisCikis.Tables(0)
            sec_nGirisCikis.ItemIndex = 0
        ElseIf kapla = True Then
            If sec_sFisTipi.EditValue = "FS " Or sec_sFisTipi.EditValue = "DFS" Or sec_sFisTipi.EditValue = "HS " Or sec_sFisTipi.EditValue = "DC " Or sec_sFisTipi.EditValue = "DDC" Or sec_sFisTipi.EditValue = "IS " Or sec_sFisTipi.EditValue = "DIS" Or sec_sFisTipi.EditValue = "DT " Or sec_sFisTipi.EditValue = "T  " Then
                ds_tbGirisCikis = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT nGirisCikis, sAciklama FROM tbGirisCikis Where nGirisCikis IN (3,4)"))
            ElseIf sec_sFisTipi.EditValue = "FA " Or sec_sFisTipi.EditValue = "DFA" Or sec_sFisTipi.EditValue = "HA " Or sec_sFisTipi.EditValue = "DG " Or sec_sFisTipi.EditValue = "DDG" Or sec_sFisTipi.EditValue = "IA " Or sec_sFisTipi.EditValue = "DIA" Or sec_sFisTipi.EditValue = "MM " Then
                ds_tbGirisCikis = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT nGirisCikis, sAciklama FROM tbGirisCikis Where nGirisCikis IN (1,2)"))
            End If
            sec_nGirisCikis.Properties.DataSource = ds_tbGirisCikis.Tables(0)
            sec_nGirisCikis.ItemIndex = 0
            sec_nGirisCikis.EditValue = nGirisCikis
            If nGirisCikis = 2 Or nGirisCikis = 4 Then
                sec_nGirisCikis.ItemIndex = 1
            End If
            'sec_nGirisCikis.ItemIndex = 0
        End If
        If Trim(sec_sFisTipi.EditValue) = "MM" Then
            colKdvTutari.Caption = "ToplamKesinti"
        Else
            colKdvTutari.Caption = "Kdv Tutarı"
        End If
        If Trim(sec_sFisTipi.EditValue) = "T" Then
            colsDepo.Visible = True
            colsTransferDepo.Visible = True
        Else
            colsTransferDepo.Visible = False
        End If
        If Trim(sec_sFisTipi.EditValue) = "IS" Or Trim(sec_sFisTipi.EditValue) = "DIS" Or Trim(sec_sFisTipi.EditValue) = "IA" Or Trim(sec_sFisTipi.EditValue) = "DIA" Then
            sec_bFaturayaDonustumu.Enabled = True
        Else
            sec_bFaturayaDonustumu.Enabled = False
            sec_bFaturayaDonustumu.SelectedIndex = 0
        End If
    End Sub
    Private Sub dataload_tbdepo()
        If Trim(sDepo) = "D012" Or Trim(sDepo) = "D013" Then
            ds_tbDepo = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     CAST('0' as bit) AS SEC, sDepo AS KOD, sAciklama AS ACIKLAMA FROM         tbDepo Where sDepo IN ('D012','D013')"))
            'sec_sDepo.Properties.DataSource = ds_tbDepo.Tables(0)
        Else
            'ds_tbDepo = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     CAST('0' as bit) AS SEC, sDepo AS KOD, sAciklama AS ACIKLAMA FROM         tbDepo WHERE sDepo <> '' ORDER BY sDepo"))
            ds_tbDepo = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     CAST('0' as bit) AS SEC, sDepo AS KOD, sAciklama AS ACIKLAMA FROM         tbDepo  ORDER BY sDepo"))
            'sec_sDepo.Properties.DataSource = ds_tbDepo.Tables(0)
        End If
        If Trim(sDepo) = "D001" Or Trim(sDepo) = "D012" Or Trim(sDepo) = "D013" Then
            sec_sdepo.EditValue = "'" & sDepo & "'"
            If kullanici > 3 Then
                sec_sdepo.Properties.ReadOnly = False
            Else
                sec_sdepo.Properties.ReadOnly = False
            End If
        Else
            If kullanici > 3 Then
                sec_sdepo.EditValue = "'" & sDepo & "'"
                sec_sdepo.Properties.ReadOnly = True
            Else
                'sec_sDepo.EditValue = sDepo
                sec_sdepo.Properties.ReadOnly = False
            End If
            'sec_sDepo.EditValue = sDepo
            'sec_sDepo.Properties.ReadOnly = False
        End If
        'sec_sDepo.ItemIndex = 1
    End Sub
    Private Sub dataload_tbHareketTipi()
        ds_tbHareketTipi = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     CAST(sHareketTipi AS CHAR(4)) AS sHareketTipi, sAciklama FROM         tbHareketTipi where aktif = 1"))
        sec_sHareketTipi.Properties.DataSource = ds_tbHareketTipi.Tables(0)
        'sec_sHareketTipi.ItemIndex = 1
    End Sub
    Private Sub dataload_tbSatici()
        ds_tbSatici = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sSaticiRumuzu,sAdi,sSoyadi FROM         tbSatici where bAktif =1"))
        sec_sSatici.Properties.DataSource = ds_tbSatici.Tables(0)
        'sec_sHareketTipi.ItemIndex = 1
    End Sub
    Public Function stok(ByVal ara As String, ByVal konum As String, ByVal ara_kriter As String, ByVal sFisTipi As String, ByVal nGirisCikis As String, ByVal dteFisTarihi1 As DateTime, ByVal dteFisTarihi2 As DateTime, ByVal lFisNo1 As Int64, ByVal lFisNo2 As Int64, ByVal lNetTutar1 As Decimal, ByVal lNetTutar2 As Decimal, ByVal sDepo As String, ByVal sHareketTipi As String, ByVal sSaticiRumuzu As String) As DataSet
        Dim kriter As String = "WHERE (tbStokFisiMaster.sFisTipi = '" & sFisTipi & "')"
        Dim obj2 As Object = ""
        Dim Obx As Integer = 0
        If sec_sTarihTipi.SelectedIndex = 0 Then
            kriter += " AND tbStokFisiMaster.dteFisTarihi between '" & dteFisTarihi1 & "' and '" & dteFisTarihi2 & "' "
        ElseIf sec_sTarihTipi.SelectedIndex = 1 Then
            dteFisTarihi1 = Microsoft.VisualBasic.Left(dteFisTarihi1.ToString, 10) + " 00:00:00"
            dteFisTarihi2 = Microsoft.VisualBasic.Left(dteFisTarihi2.ToString, 10) + " 23:59:59"
            kriter += " AND tbStokFisiMaster.dteKayitTarihi between '" & dteFisTarihi1 & "' and '" & dteFisTarihi2 & "' "
        ElseIf sec_sTarihTipi.SelectedIndex = 2 Then
            kriter += " AND tbStokFisiMaster.dteValorTarihi between '" & dteFisTarihi1 & "' and '" & dteFisTarihi2 & "' "
        End If
        kriter += " and tbStokFisiMaster.lFisNo between '" & lFisNo1 & "' and '" & lFisNo2 & "'"
        kriter += " and tbStokFisiMaster.lNetTutar between '" & lNetTutar1 & "' and '" & lNetTutar2 & "'"
        'If Trim(sDepo) <> "" Then
        '    kriter += " And tbStokFisiMaster.nStokFisiID IN  (SELECT DISTINCT nStokFisiID FROM         tbStokFisiDetayi WHERE     (sDepo IN ('" & sDepo & "')) and dteFisTarihi between '" & dteFisTarihi1 & "' and '" & dteFisTarihi2 & "' and sFisTipi '" & sFisTipi & "' and nGirisCikis =" & nGirisCikis & ") "
        'End If
        If Trim(sHareketTipi) <> "" Then
            kriter += " And tbStokFisiMaster.sHareketTipi = '" & sHareketTipi & "' "
        End If
        If nGirisCikis > 0 Then
            kriter += " and tbStokFisiMaster.nGirisCikis =" & nGirisCikis & " "
        End If
        If Trim(txt_sKaydeden.Text) <> "" Then
            kriter += " and tbStokFisiMaster.sKullaniciAdi ='" & Trim(txt_sKaydeden.Text) & "'"
        End If
        If Trim(sFisTipi) = "PF" Then
            If CStr(Trim(ara.ToString)) <> "" Then
                If sec_konum.Text = "Kodu" Then
                    kriter += " AND   (tbMusteri.lKodu " & sorgu_kriter_string(ara, ara_kriter) & " )"
                ElseIf sec_konum.Text = "Adı" Then
                    kriter += " AND  (tbMusteri.sAdi " & sorgu_kriter_string(ara, ara_kriter) & " )"
                End If
            End If
        Else
            If CStr(Trim(ara.ToString)) <> "" Then
                If sec_konum.Text = "Kodu" Then
                    kriter += " AND   (tbFirma.sKodu " & sorgu_kriter_string(ara, ara_kriter) & " )"
                ElseIf sec_konum.Text = "Adı" Then
                    kriter += " AND  (tbFirma.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
                End If
            End If
        End If
        If Trim(sDepo) <> "[Tümü]" Then
            If sec_sTarihTipi.SelectedIndex = 0 Then
                kriter += " And tbStokFisiMaster.nStokFisiID IN (SELECT DISTINCT nStokFisiID FROM tbStokFisiDetayi WHERE (sDepo IN (" & sDepo & ")) and (dteFisTarihi between '" & dteFisTarihi1 & "' and '" & dteFisTarihi2 & "') and (sFisTipi ='" & sFisTipi & "') and (nGirisCikis =" & nGirisCikis & ") and (lFisNo between '" & lFisNo1 & "' and '" & lFisNo2 & "'))"
            ElseIf sec_sTarihTipi.SelectedIndex = 1 Then
                kriter += " And tbStokFisiMaster.nStokFisiID IN (SELECT DISTINCT nStokFisiID FROM tbStokFisiDetayi WHERE (sDepo IN (" & sDepo & ")) and (dteKayitTarihi between '" & dteFisTarihi1 & "' and '" & dteFisTarihi2 & "') and (sFisTipi ='" & sFisTipi & "') and (nGirisCikis =" & nGirisCikis & ") and (lFisNo between '" & lFisNo1 & "' and '" & lFisNo2 & "'))"
            ElseIf sec_sTarihTipi.SelectedIndex = 2 Then
                kriter += " And tbStokFisiMaster.nStokFisiID IN (SELECT DISTINCT nStokFisiID FROM tbStokFisiDetayi WHERE (sDepo IN (" & sDepo & ")) and (dteValorTarihi between '" & dteFisTarihi1 & "' and '" & dteFisTarihi2 & "') and (sFisTipi ='" & sFisTipi & "') and (nGirisCikis =" & nGirisCikis & ") and (lFisNo between '" & lFisNo1 & "' and '" & lFisNo2 & "'))"
            End If
        End If
        If Trim(sSaticiRumuzu) <> "" Then
            If sec_sTarihTipi.SelectedIndex = 0 Then
                kriter += " And tbStokFisiMaster.nStokFisiID IN (SELECT DISTINCT nStokFisiID FROM tbStokFisiDetayi WHERE (sSaticiRumuzu IN ('" & sSaticiRumuzu & "')) and (dteFisTarihi between '" & dteFisTarihi1 & "' and '" & dteFisTarihi2 & "') and (sFisTipi ='" & sFisTipi & "') and (nGirisCikis =" & nGirisCikis & ") and (lFisNo between '" & lFisNo1 & "' and '" & lFisNo2 & "'))"
            ElseIf sec_sTarihTipi.SelectedIndex = 1 Then
                kriter += " And tbStokFisiMaster.nStokFisiID IN (SELECT DISTINCT nStokFisiID FROM tbStokFisiDetayi WHERE (sSaticiRumuzu IN ('" & sSaticiRumuzu & "')) and (dteKayitTarihi between '" & dteFisTarihi1 & "' and '" & dteFisTarihi2 & "') and (sFisTipi ='" & sFisTipi & "') and (nGirisCikis =" & nGirisCikis & ") and (lFisNo between '" & lFisNo1 & "' and '" & lFisNo2 & "'))"
            ElseIf sec_sTarihTipi.SelectedIndex = 2 Then
                kriter += " And tbStokFisiMaster.nStokFisiID IN (SELECT DISTINCT nStokFisiID FROM tbStokFisiDetayi WHERE (sSaticiRumuzu IN ('" & sSaticiRumuzu & "')) and (dteValorTarihi between '" & dteFisTarihi1 & "' and '" & dteFisTarihi2 & "') and (sFisTipi ='" & sFisTipi & "') and (nGirisCikis =" & nGirisCikis & ") and (lFisNo between '" & lFisNo1 & "' and '" & lFisNo2 & "'))"
            End If
        End If
        If sec_bFaturayaDonustumu.Text <> "[Tümü]" Then
            If sec_bFaturayaDonustumu.SelectedIndex = 1 Then
                kriter += " And tbStokFisiMaster.bFaturayaDonustumu = 1 "
            ElseIf sec_bFaturayaDonustumu.SelectedIndex = 2 Then
                kriter += " And tbStokFisiMaster.bFaturayaDonustumu = 0 "
            End If
        End If
        Dim nCiktiSatirSayisi As Integer = 25
        If nGirisCikis = 3 Or nGirisCikis = 4 Then
            'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT      ISNULL(MAX(lFisNo), 0) + 1 AS lFisNo FROM         tbStokFisiMaster  Where sFisTipi = '" & sFisTipi & "'  AND nStokFisiID IN (Select TOP 3 nStokFisiID from tbStokFisiMaster Where sFisTipi ='" & sFisTipi & "' Order by dteFisTarihi DESC)")
            'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT ISNULL(MAX(lFisNo), 0) + 1 AS lFisNo FROM tbStokFisiDetayi WHERE (sFisTipi = 'FS ') AND (nStokFisiID IN (SELECT TOP 3 nStokFisiID FROM (SELECT DISTINCT nStokFisiID , dteFisTarihi FROM tbStokFisiDetayi WHERE (sFisTipi = '" & sFisTipi & "') AND (sDepo = '" & sDepo & "')) DERIVEDTBL ORDER BY dteFisTarihi DESC))")
            If Trim(sFisTipi) = "FS" Then
                nCiktiSatirSayisi = nFaturaCiktiSatirSayisi
            ElseIf Trim(sFisTipi) = "IS" Then
                nCiktiSatirSayisi = nIrsaliyeCiktiSatirSayisi
            ElseIf Trim(sFisTipi) = "DC" Then
                nCiktiSatirSayisi = nStokFisiCiktiSatirSayisi
            ElseIf Trim(sFisTipi) = "HS" Then
                nCiktiSatirSayisi = nFaturaCiktiSatirSayisi
            End If
        End If
        Dim nSayfa = "" '",(SELECT (COUNT(nIslemID) / " & nCiktiSatirSayisi & " ) + 1 FROM tbStokFisiDetayi WHERE sFisTipi = tbStokFisiMaster.sFisTipi AND nGirisCikis = tbStokFisiMaster.nGirisCikis AND lFisNo = tbStokFisiMaster.lFisNo AND nFirmaID = tbStokFisiMaster.nFirmaID) AS nSayfa"
        sKriter = kriter
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.CommandTimeout = False
        adapter.SelectCommand = cmd
        If Trim(sFisTipi) = "PF" Then
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbStokFisiMaster.dteFisTarihi, tbStokFisiMaster.lFisNo, tbStokFisiMaster.nEvrakNo, tbStokFisiMaster.nGirisCikis, tbStokFisiMaster.lToplamMiktar, tbStokFisiMaster.lNetTutar, tbStokFisiMaster.sDepo, (SELECT sAciklama FROM tbDepo WHERE sDepo = tbStokFisiMaster.sDepo) AS Depo, tbStokFisiMaster.lTransferFisiID,tbStokFisiMaster.sTransferDepo, (SELECT sAciklama FROM tbDepo WHERE sDepo = tbStokFisiMaster.sTransferDepo) AS tDepo, tbStokFisiMaster.bFaturayaDonustumu AS sFaturalasti, tbStokFisiMaster.bPesinmi,CONVERT (char(1), tbStokFisiMaster.bMuhasebeyeIslendimi) AS Muhasebelesti, tbStokFisiMaster.sHareketTipi, RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama1, '')) + ' ' + RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama2, '')) + ' ' + RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama3, '')) + ' ' + RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama4, '')) + ' ' + RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama5, '')) + ' ' + RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama6, '')) + ' ' + RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama7, '')) + ' ' + RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama8, '')) + ' ' + RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama9, '')) + ' ' + RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama10, '')) AS sNot, tbStokFisiMaster.bFisTamamlandimi AS Tamamlandi, tbStokFisiMaster.lTevkifatKdvMatrahi, tbStokFisiMaster.lTevkifatKdv, tbStokFisiMaster.lNetTutar AS lNetTutar, CONVERT (char(1), tbStokFisiMaster.bHizmetFaturasimi) AS Hizmet, tbStokFisiMaster.nFirmaID, tbStokFisiMaster.sFisTipi, tbStokFisiMaster.nStokFisiID, tbStokFisiMaster.lKdv1 + tbStokFisiMaster.lKdv2 + tbStokFisiMaster.lKdv3 + tbStokFisiMaster.lKdv4 + tbStokFisiMaster.lKdv5 AS KdvTutari, tbStokFisiMaster.lKdvMatrahi1 + tbStokFisiMaster.lKdvMatrahi2 + tbStokFisiMaster.lKdvMatrahi3 + tbStokFisiMaster.lKdvMatrahi4 + tbStokFisiMaster.lKdvMatrahi5 AS KdvMatrahi, tbStokFisiMaster.lEkmaliyet1 + tbStokFisiMaster.lEkmaliyet2 + tbStokFisiMaster.lEkmaliyet3 AS EkMaliyet, tbStokFisiMaster.lMalIskontoTutari, tbStokFisiMaster.lMalIskontoTutari+tbStokFisiMaster.lDipIskontoTutari1 + tbStokFisiMaster.lDipIskontoTutari2 + tbStokFisiMaster.lDipIskontoTutari3 as lIskontoTutari,tbStokFisiMaster.lMalBedeli, CAST(0 AS MONEY) AS ISKONTO, tbStokFisiMaster.lMalBedeli - tbStokFisiMaster.lMalIskontoTutari AS FATURATUTARI, CAST(0 AS MONEY) AS EkOran, tbStokFisiMaster.lDipIskontoTutari1 + tbStokFisiMaster.lDipIskontoTutari2 + tbStokFisiMaster.lDipIskontoTutari3 AS lDipIskontoTutari3, tbMusteri.nMusteriID, tbMusteri.lKodu AS sKodu, tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS sAciklama,tbStokFisiMaster.sKullaniciAdi,tbStokFisiMaster.dteKayitTarihi,tbStokFisiMaster.bKilitli, tbStokFisiMaster.sYazdirma, tbStokFisiMaster.sOnizleme, tbStokFisiMaster.sDizayn FROM tbStokFisiMaster INNER JOIN tbHareketTipi ON tbStokFisiMaster.sHareketTipi = tbHareketTipi.sHareketTipi INNER JOIN tbStokFisiAciklamasi ON tbStokFisiMaster.nStokFisiID = tbStokFisiAciklamasi.nStokFisiID LEFT OUTER JOIN tbMusteri ON tbStokFisiMaster.lFisNo = tbMusteri.lKodu " & kriter & " ORDER BY tbStokFisiMaster.dteFisTarihi, tbStokFisiMaster.lFisNo")
        ElseIf sec_Aktar.Checked = False Then
            'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbStokFisiMaster.dteFisTarihi, tbStokFisiMaster.lFisNo, tbStokFisiMaster.nGirisCikis, tbStokFisiMaster.lToplamMiktar, tbStokFisiMaster.lNetTutar, tbStokFisiMaster.sDepo, (SELECT sAciklama FROM tbDepo WHERE sDepo = tbStokFisiMaster.sDepo) AS Depo, tbFirma.sKodu, tbFirma.sAciklama, tbStokFisiMaster.sTransferDepo, (SELECT sAciklama FROM tbDepo WHERE sDepo = tbStokFisiMaster.sTransferDepo) AS tDepo, tbStokFisiMaster.bFaturayaDonustumu AS sFaturalasti,tbStokFisiMaster.bPesinmi, CONVERT (char(1), tbStokFisiMaster.bMuhasebeyeIslendimi) AS Muhasebelesti, tbHareketTipi.sHareketTipi + ' ' + tbHareketTipi.sAciklama AS sHareketTipi, RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama1, '')) + ' ' + RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama2, '')) + ' ' + RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama3, '')) + ' ' + RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama4, '')) + ' ' + RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama5, '')) AS sNot,  tbStokFisiMaster.bFisTamamlandimi AS Tamamlandi, tbStokFisiMaster.lTevkifatKdvMatrahi, tbStokFisiMaster.lTevkifatKdv, tbStokFisiMaster.lNetTutar AS lNetTutar, CONVERT (char(1), tbStokFisiMaster.bHizmetFaturasimi) AS Hizmet, tbStokFisiMaster.nFirmaID, tbStokFisiMaster.sFisTipi, tbStokFisiMaster.nStokFisiID, tbStokFisiMaster.lKdv1+ tbStokFisiMaster.lKdv2+ tbStokFisiMaster.lKdv3+ tbStokFisiMaster.lKdv4+ tbStokFisiMaster.lKdv5 as KdvTutari,tbStokFisiMaster.lKdvMatrahi1+tbStokFisiMaster.lKdvMatrahi2+tbStokFisiMaster.lKdvMatrahi3+tbStokFisiMaster.lKdvMatrahi4+tbStokFisiMaster.lKdvMatrahi5 as KdvMatrahi,tbStokFisiMaster.lEkmaliyet1+tbStokFisiMaster.lEkmaliyet2+tbStokFisiMaster.lEkmaliyet3 as EkMaliyet, tbStokFisiMaster.lMalIskontoTutari,tbStokFisiMaster.lMalIskontoTutari+tbStokFisiMaster.lDipIskontoTutari1 + tbStokFisiMaster.lDipIskontoTutari2 + tbStokFisiMaster.lDipIskontoTutari3 as lIskontoTutari,tbStokFisiMaster.lMalBedeli,CAST(0 AS MONEY) AS ISKONTO,tbStokFisiMaster.lMalBedeli - tbStokFisiMaster.lMalIskontoTutari AS FATURATUTARI,CAST(0 AS MONEY) AS EkOran,tbStokFisiMaster.lDipIskontoTutari1 + tbStokFisiMaster.lDipIskontoTutari2 + tbStokFisiMaster.lDipIskontoTutari3 AS lDipIskontoTutari,tbStokFisiMaster.lOTV2,tbStokFisiMaster.sKullaniciAdi,tbStokFisiMaster.dteKayitTarihi,tbStokFisiMaster.bKilitli " & nSayfa & "  FROM tbFirma INNER JOIN tbStokFisiMaster ON tbFirma.nFirmaID = tbStokFisiMaster.nFirmaID INNER JOIN tbHareketTipi ON tbStokFisiMaster.sHareketTipi = tbHareketTipi.sHareketTipi INNER JOIN tbStokFisiAciklamasi ON tbStokFisiMaster.nStokFisiID = tbStokFisiAciklamasi.nStokFisiID " & kriter & " ORDER BY tbStokFisiMaster.dteFisTarihi, tbStokFisiMaster.lFisNo")
            'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbStokFisiMaster.dteFisTarihi, tbStokFisiMaster.lFisNo, tbStokFisiMaster.nGirisCikis, tbStokFisiMaster.lToplamMiktar, tbStokFisiMaster.lNetTutar, tbStokFisiMaster.sDepo, (SELECT sAciklama FROM tbDepo WHERE sDepo = tbStokFisiMaster.sDepo) AS Depo, tbFirma.sKodu, tbFirma.sAciklama, tbStokFisiMaster.sTransferDepo, (SELECT sAciklama FROM tbDepo WHERE sDepo = tbStokFisiMaster.sTransferDepo) AS tDepo, tbStokFisiMaster.bFaturayaDonustumu AS sFaturalasti,tbStokFisiMaster.bPesinmi, CONVERT (char(1), tbStokFisiMaster.bMuhasebeyeIslendimi) AS Muhasebelesti, tbStokFisiMaster.sHareketTipi, RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama1, '')) + ' ' + RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama2, '')) + ' ' + RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama3, '')) + ' ' + RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama4, '')) + ' ' + RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama5, '')) AS sNot,  tbStokFisiMaster.bFisTamamlandimi AS Tamamlandi, tbStokFisiMaster.lTevkifatKdvMatrahi, tbStokFisiMaster.lTevkifatKdv, tbStokFisiMaster.lNetTutar AS lNetTutar, CONVERT (char(1), tbStokFisiMaster.bHizmetFaturasimi) AS Hizmet, tbStokFisiMaster.nFirmaID, tbStokFisiMaster.sFisTipi, tbStokFisiMaster.nStokFisiID, tbStokFisiMaster.lKdv1+ tbStokFisiMaster.lKdv2+ tbStokFisiMaster.lKdv3+ tbStokFisiMaster.lKdv4+ tbStokFisiMaster.lKdv5 as KdvTutari,tbStokFisiMaster.lKdvMatrahi1+tbStokFisiMaster.lKdvMatrahi2+tbStokFisiMaster.lKdvMatrahi3+tbStokFisiMaster.lKdvMatrahi4+tbStokFisiMaster.lKdvMatrahi5 as KdvMatrahi,tbStokFisiMaster.lEkmaliyet1+tbStokFisiMaster.lEkmaliyet2+tbStokFisiMaster.lEkmaliyet3 as EkMaliyet, tbStokFisiMaster.lMalIskontoTutari,tbStokFisiMaster.lMalIskontoTutari+tbStokFisiMaster.lDipIskontoTutari1 + tbStokFisiMaster.lDipIskontoTutari2 + tbStokFisiMaster.lDipIskontoTutari3 as lIskontoTutari,tbStokFisiMaster.lMalBedeli,CAST(0 AS MONEY) AS ISKONTO,tbStokFisiMaster.lMalBedeli - tbStokFisiMaster.lMalIskontoTutari AS FATURATUTARI,CAST(0 AS MONEY) AS EkOran,tbStokFisiMaster.lDipIskontoTutari1 + tbStokFisiMaster.lDipIskontoTutari2 + tbStokFisiMaster.lDipIskontoTutari3 AS lDipIskontoTutari,tbStokFisiMaster.lOTV2,tbStokFisiMaster.sKullaniciAdi,tbStokFisiMaster.dteKayitTarihi,tbStokFisiMaster.bKilitli " & nSayfa & "  FROM tbFirma INNER JOIN tbStokFisiMaster ON tbFirma.nFirmaID = tbStokFisiMaster.nFirmaID INNER JOIN tbHareketTipi ON tbStokFisiMaster.sHareketTipi = tbHareketTipi.sHareketTipi INNER JOIN tbStokFisiAciklamasi ON tbStokFisiMaster.nStokFisiID = tbStokFisiAciklamasi.nStokFisiID " & kriter & " ORDER BY tbStokFisiMaster.dteFisTarihi, tbStokFisiMaster.lFisNo")
            'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbStokFisiMaster.dteFisTarihi, tbStokFisiMaster.lFisNo, tbStokFisiMaster.nEvrakNo, tbStokFisiMaster.nGirisCikis, tbStokFisiMaster.lToplamMiktar, tbStokFisiMaster.lNetTutar, tbStokFisiMaster.sDepo, (SELECT sAciklama FROM tbDepo WHERE sDepo = tbStokFisiMaster.sDepo) AS Depo, tbStokFisiMaster.lTransferFisiID,tbFirma.sKodu, tbFirma.sAciklama, tbFSinif1.sAciklama as sCariSinif1,  tbFSinif2.sAciklama as sCariSinif2 , tbFSinif3.sAciklama as sCariSinif3 , tbStokFisiMaster.sTransferDepo, (SELECT sAciklama FROM tbDepo WHERE sDepo = tbStokFisiMaster.sTransferDepo) AS tDepo, tbStokFisiMaster.bFaturayaDonustumu AS sFaturalasti,tbStokFisiMaster.bPesinmi, CONVERT (char(1), tbStokFisiMaster.bMuhasebeyeIslendimi) AS Muhasebelesti, tbStokFisiMaster.sHareketTipi, RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama1, '')) + ' ' + RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama2, '')) + ' ' + RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama3, '')) + ' ' + RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama4, '')) + ' ' + RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama5, '')) AS sNot,  tbStokFisiMaster.bFisTamamlandimi AS Tamamlandi, tbStokFisiMaster.lTevkifatKdvMatrahi, tbStokFisiMaster.lTevkifatKdv, tbStokFisiMaster.lNetTutar AS lNetTutar, CONVERT (char(1), tbStokFisiMaster.bHizmetFaturasimi) AS Hizmet, tbStokFisiMaster.nFirmaID, tbStokFisiMaster.sFisTipi, tbStokFisiMaster.nStokFisiID, tbStokFisiMaster.lKdv1+ tbStokFisiMaster.lKdv2+ tbStokFisiMaster.lKdv3+ tbStokFisiMaster.lKdv4+ tbStokFisiMaster.lKdv5 as KdvTutari,tbStokFisiMaster.lKdvMatrahi1+tbStokFisiMaster.lKdvMatrahi2+tbStokFisiMaster.lKdvMatrahi3+tbStokFisiMaster.lKdvMatrahi4+tbStokFisiMaster.lKdvMatrahi5 as KdvMatrahi,tbStokFisiMaster.lEkmaliyet1+tbStokFisiMaster.lEkmaliyet2+tbStokFisiMaster.lEkmaliyet3 as EkMaliyet, tbStokFisiMaster.lMalIskontoTutari,tbStokFisiMaster.lMalIskontoTutari+tbStokFisiMaster.lDipIskontoTutari1 + tbStokFisiMaster.lDipIskontoTutari2 + tbStokFisiMaster.lDipIskontoTutari3 as lIskontoTutari,tbStokFisiMaster.lMalBedeli,ISKONTO = CASE WHEN (tbStokFisiMaster.lMalIskontoTutari + tbStokFisiMaster.lDipIskontoTutari1 + tbStokFisiMaster.lDipIskontoTutari2 + tbStokFisiMaster.lDipIskontoTutari3) = 0 OR tbStokFisiMaster.lMalBedeli = 0 THEN 0 ELSE (tbStokFisiMaster.lMalIskontoTutari + tbStokFisiMaster.lDipIskontoTutari1 + tbStokFisiMaster.lDipIskontoTutari2 + tbStokFisiMaster.lDipIskontoTutari3) / tbStokFisiMaster.lMalBedeli END, EkOran = CASE WHEN tbStokFisiMaster.lEkmaliyet1 + tbStokFisiMaster.lEkmaliyet2 + tbStokFisiMaster.lEkmaliyet3 = 0 OR tbStokFisiMaster.lMalBedeli = 0 THEN 0 ELSE (tbStokFisiMaster.lEkmaliyet1 + tbStokFisiMaster.lEkmaliyet2 + tbStokFisiMaster.lEkmaliyet3) / (tbStokFisiMaster.lMalBedeli - tbStokFisiMaster.lMalIskontoTutari - tbStokFisiMaster.lDipIskontoTutari1 - tbStokFisiMaster.lDipIskontoTutari2 - tbStokFisiMaster.lDipIskontoTutari3) END,tbStokFisiMaster.lMalBedeli - tbStokFisiMaster.lMalIskontoTutari AS FATURATUTARI,tbStokFisiMaster.lDipIskontoTutari1 + tbStokFisiMaster.lDipIskontoTutari2 + tbStokFisiMaster.lDipIskontoTutari3 AS lDipIskontoTutari,tbStokFisiMaster.lOTV2,tbStokFisiMaster.sKullaniciAdi,tbStokFisiMaster.dteKayitTarihi,tbStokFisiMaster.bKilitli, tbStokFisiMaster.sYazdirma, tbStokFisiMaster.sOnizleme, tbStokFisiMaster.sDizayn " & nSayfa & "  FROM tbFirma INNER JOIN tbStokFisiMaster ON tbFirma.nFirmaID = tbStokFisiMaster.nFirmaID INNER JOIN tbHareketTipi ON tbStokFisiMaster.sHareketTipi = tbHareketTipi.sHareketTipi INNER JOIN tbFirmaSinifi ON tbFirma.nFirmaID = tbFirmaSinifi.nFirmaID INNER JOIN tbFSinif1 ON tbFirmaSinifi.sSinifKodu1 = tbFSinif1.sSinifKodu INNER JOIN tbFSinif2 ON tbFirmaSinifi.sSinifKodu2 = tbFSinif2.sSinifKodu INNER JOIN tbFSinif3 ON tbFirmaSinifi.sSinifKodu3 = tbFSinif3.sSinifKodu INNER JOIN tbStokFisiAciklamasi ON tbStokFisiMaster.nStokFisiID = tbStokFisiAciklamasi.nStokFisiID " & kriter & " ORDER BY tbStokFisiMaster.dteFisTarihi, tbStokFisiMaster.lFisNo")
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbStokFisiMaster.dteFisTarihi,tbStokFisiMaster.GibFaturaNo, tbStokFisiMaster.sEfaturaUrl, tbStokFisiAciklamasi.sAciklama1, tbStokFisiMaster.dteValorTarihi, tbStokFisiMaster.lFisNo, tbStokFisiMaster.nEvrakNo, tbStokFisiMaster.nGirisCikis, tbStokFisiMaster.lToplamMiktar, tbStokFisiMaster.lNetTutar, tbStokFisiMaster.sDepo, (SELECT sAciklama FROM tbDepo WHERE sDepo = tbStokFisiMaster.sDepo) AS Depo, tbStokFisiMaster.lTransferFisiID,tbFirma.sKodu, tbFirma.sAciklama, tbFSinif1.sAciklama as sCariSinif1,  tbFSinif2.sAciklama as sCariSinif2 , tbFSinif3.sAciklama as sCariSinif3 , tbStokFisiMaster.sTransferDepo, (SELECT sAciklama FROM tbDepo WHERE sDepo = tbStokFisiMaster.sTransferDepo) AS tDepo, tbStokFisiMaster.bFaturayaDonustumu AS sFaturalasti,tbStokFisiMaster.bPesinmi, CONVERT (char(1), tbStokFisiMaster.bMuhasebeyeIslendimi) AS Muhasebelesti, tbStokFisiMaster.sHareketTipi, RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama1, '')) + ' ' + RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama2, '')) + ' ' + RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama3, '')) + ' ' + RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama4, '')) + ' ' + RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama5, ''))  + ' ' + RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama6, '')) + ' ' + RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama7, '')) + ' ' + RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama8, '')) + ' ' + RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama9, '')) + ' ' + RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama10, '')) AS sNot,  tbStokFisiMaster.bFisTamamlandimi AS Tamamlandi, tbStokFisiMaster.lTevkifatKdvMatrahi, tbStokFisiMaster.lTevkifatKdv, tbStokFisiMaster.lNetTutar AS lNetTutar, CONVERT (char(1), tbStokFisiMaster.bHizmetFaturasimi) AS Hizmet, tbStokFisiMaster.nFirmaID, tbStokFisiMaster.sFisTipi, tbStokFisiMaster.nStokFisiID, tbStokFisiMaster.lKdv1+ tbStokFisiMaster.lKdv2+ tbStokFisiMaster.lKdv3+ tbStokFisiMaster.lKdv4+ tbStokFisiMaster.lKdv5 as KdvTutari,tbStokFisiMaster.lKdvMatrahi1+tbStokFisiMaster.lKdvMatrahi2+tbStokFisiMaster.lKdvMatrahi3+tbStokFisiMaster.lKdvMatrahi4+tbStokFisiMaster.lKdvMatrahi5 as KdvMatrahi,tbStokFisiMaster.lEkmaliyet1+tbStokFisiMaster.lEkmaliyet2+tbStokFisiMaster.lEkmaliyet3 as EkMaliyet, tbStokFisiMaster.lMalIskontoTutari,tbStokFisiMaster.lMalIskontoTutari+tbStokFisiMaster.lDipIskontoTutari1 + tbStokFisiMaster.lDipIskontoTutari2 + tbStokFisiMaster.lDipIskontoTutari3 as lIskontoTutari,tbStokFisiMaster.lMalBedeli,ISKONTO = CASE WHEN (tbStokFisiMaster.lMalIskontoTutari + tbStokFisiMaster.lDipIskontoTutari1 + tbStokFisiMaster.lDipIskontoTutari2 + tbStokFisiMaster.lDipIskontoTutari3) = 0 OR tbStokFisiMaster.lMalBedeli = 0 THEN 0 ELSE (tbStokFisiMaster.lMalIskontoTutari + tbStokFisiMaster.lDipIskontoTutari1 + tbStokFisiMaster.lDipIskontoTutari2 + tbStokFisiMaster.lDipIskontoTutari3) / tbStokFisiMaster.lMalBedeli END, EkOran = CASE WHEN tbStokFisiMaster.lEkmaliyet1 + tbStokFisiMaster.lEkmaliyet2 + tbStokFisiMaster.lEkmaliyet3 = 0 OR tbStokFisiMaster.lMalBedeli = 0 THEN 0 ELSE (tbStokFisiMaster.lEkmaliyet1 + tbStokFisiMaster.lEkmaliyet2 + tbStokFisiMaster.lEkmaliyet3) / (tbStokFisiMaster.lMalBedeli - tbStokFisiMaster.lMalIskontoTutari - tbStokFisiMaster.lDipIskontoTutari1 - tbStokFisiMaster.lDipIskontoTutari2 - tbStokFisiMaster.lDipIskontoTutari3) END,tbStokFisiMaster.lMalBedeli - tbStokFisiMaster.lMalIskontoTutari AS FATURATUTARI,tbStokFisiMaster.lDipIskontoTutari1 + tbStokFisiMaster.lDipIskontoTutari2 + tbStokFisiMaster.lDipIskontoTutari3 AS lDipIskontoTutari,tbStokFisiMaster.lOTV2,tbStokFisiMaster.sKullaniciAdi,tbStokFisiMaster.dteKayitTarihi,tbStokFisiMaster.bKilitli, tbStokFisiMaster.sYazdirma, tbStokFisiMaster.nEfaturaDurum, tbStokFisiMaster.sEfaturaTipi " & nSayfa & "  FROM tbFirma INNER JOIN tbStokFisiMaster ON tbFirma.nFirmaID = tbStokFisiMaster.nFirmaID INNER JOIN tbHareketTipi ON tbStokFisiMaster.sHareketTipi = tbHareketTipi.sHareketTipi INNER JOIN tbFirmaSinifi ON tbFirma.nFirmaID = tbFirmaSinifi.nFirmaID INNER JOIN tbFSinif1 ON tbFirmaSinifi.sSinifKodu1 = tbFSinif1.sSinifKodu INNER JOIN tbFSinif2 ON tbFirmaSinifi.sSinifKodu2 = tbFSinif2.sSinifKodu INNER JOIN tbFSinif3 ON tbFirmaSinifi.sSinifKodu3 = tbFSinif3.sSinifKodu INNER JOIN tbStokFisiAciklamasi ON tbStokFisiMaster.nStokFisiID = tbStokFisiAciklamasi.nStokFisiID " & kriter & " ORDER BY tbStokFisiMaster.dteFisTarihi, tbStokFisiMaster.lFisNo")
        Else
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbStokFisiMaster.nEvrakNo,tbStokFisiMaster.dteValorTarihi,tbStokFisiMaster.dteFisTarihi, ROUND(CAST(GETDATE() - (CAST(tbStokFisiMaster.dteFisTarihi AS INT) ) AS FLOAT), 0) AS GUN, ROUND(CAST(GETDATE() - (CAST(tbStokFisiMaster.dteFisTarihi AS INT) ) AS FLOAT), 0) * tbStokFisiMaster.lNetTutar AS HESAPLA,tbStokFisiMaster.lFisNo, tbStokFisiMaster.nGirisCikis, tbStokFisiMaster.lToplamMiktar, tbStokFisiMaster.lNetTutar, tbStokFisiMaster.sDepo, (SELECT sAciklama FROM tbDepo WHERE sDepo = tbStokFisiMaster.sDepo) AS Depo, tbStokFisiMaster.lTransferFisiID,tbFirma.sKodu, sAciklama = Case When tbStokFisiMaster.bPesinmi =1 and tbStokFisiPesinAdres.sAciklama <> '' THEN tbStokFisiPesinAdres.sAciklama ELSE tbFirma.sAciklama END, tbFirma.sAdres1,tbFirma.sAdres2,tbFirma.sIl,tbFirma.sSemt,tbFirma.sUlke,tbFirma.sPostaKodu,tbFirma.nOzelIskontosu as nIskontoYuzdesi,tbFirma.lKrediLimiti,tbFirma.sVergiDairesi,tbFirma.sVergiNo,'' sYetkili,tbFirma.sFiyatTipi,tbStokFisiMaster.sTransferDepo, (SELECT sAciklama FROM tbDepo WHERE sDepo = tbStokFisiMaster.sTransferDepo) AS tDepo, tbStokFisiMaster.bFaturayaDonustumu AS sFaturalasti,tbStokFisiMaster.bPesinmi, tbStokFisiMaster.bMuhasebeyeIslendimi AS Muhasebelesti, tbStokFisiMaster.sHareketTipi, RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama1, '')) + ' ' + RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama2, '')) + ' ' + RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama3, '')) + ' ' + RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama4, '')) +' ' + RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama5, ''))  + ' ' + RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama6, '')) + ' ' + RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama7, '')) + ' ' + RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama8, '')) + ' ' + RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama9, '')) + ' ' + RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama10, '')) AS sNot,  tbStokFisiMaster.bFisTamamlandimi AS Tamamlandi, tbStokFisiMaster.lTevkifatKdvMatrahi, tbStokFisiMaster.lTevkifatKdv, tbStokFisiMaster.lNetTutar AS lNetTutar, CONVERT (char(1), tbStokFisiMaster.bHizmetFaturasimi) AS Hizmet, tbStokFisiMaster.nFirmaID, tbStokFisiMaster.sFisTipi, tbStokFisiMaster.nStokFisiID, tbStokFisiMaster.lKdv1+ tbStokFisiMaster.lKdv2+ tbStokFisiMaster.lKdv3+ tbStokFisiMaster.lKdv4+ tbStokFisiMaster.lKdv5 as KdvTutari,tbStokFisiMaster.lKdvMatrahi1+tbStokFisiMaster.lKdvMatrahi2+tbStokFisiMaster.lKdvMatrahi3+tbStokFisiMaster.lKdvMatrahi4+tbStokFisiMaster.lKdvMatrahi5 as KdvMatrahi,tbStokFisiMaster.lEkmaliyet1+tbStokFisiMaster.lEkmaliyet2+tbStokFisiMaster.lEkmaliyet3 as EkMaliyet, tbStokFisiMaster.lMalIskontoTutari,tbStokFisiMaster.lMalIskontoTutari+tbStokFisiMaster.lDipIskontoTutari1 + tbStokFisiMaster.lDipIskontoTutari2 + tbStokFisiMaster.lDipIskontoTutari3 as lIskontoTutari,tbStokFisiMaster.lMalBedeli,tbStokFisiMaster.lOTVMatrahi2,ISKONTO = CASE WHEN (tbStokFisiMaster.lMalIskontoTutari + tbStokFisiMaster.lDipIskontoTutari1 + tbStokFisiMaster.lDipIskontoTutari2 + tbStokFisiMaster.lDipIskontoTutari3) = 0 OR tbStokFisiMaster.lMalBedeli = 0 THEN 0 ELSE (tbStokFisiMaster.lMalIskontoTutari + tbStokFisiMaster.lDipIskontoTutari1 + tbStokFisiMaster.lDipIskontoTutari2 + tbStokFisiMaster.lDipIskontoTutari3) / tbStokFisiMaster.lMalBedeli END, EkOran = CASE WHEN tbStokFisiMaster.lEkmaliyet1 + tbStokFisiMaster.lEkmaliyet2 + tbStokFisiMaster.lEkmaliyet3 = 0 OR tbStokFisiMaster.lMalBedeli = 0 THEN 0 ELSE (tbStokFisiMaster.lEkmaliyet1 + tbStokFisiMaster.lEkmaliyet2 + tbStokFisiMaster.lEkmaliyet3) / (tbStokFisiMaster.lMalBedeli - tbStokFisiMaster.lMalIskontoTutari - tbStokFisiMaster.lDipIskontoTutari1 - tbStokFisiMaster.lDipIskontoTutari2 - tbStokFisiMaster.lDipIskontoTutari3) END,tbStokFisiMaster.lMalBedeli - tbStokFisiMaster.lMalIskontoTutari AS FATURATUTARI,tbStokFisiMaster.lDipIskontoTutari1 + tbStokFisiMaster.lDipIskontoTutari2 + tbStokFisiMaster.lDipIskontoTutari3 AS lDipIskontoTutari,tbStokFisiMaster.lOTV2,tbStokFisiMaster.sKullaniciAdi,tbStokFisiMaster.dteKayitTarihi,tbStokFisiMaster.bKilitli,tbStokFisiMaster.bEfatura, tbStokFisiMaster.sEfaturaTipi, tbStokFisiMaster.sEfaturaGuid, (SELECT      SUM(lAlacakTutar)  AS lTahsilat FROM         tbFirmaHareketi  Where nFirmaID = tbStokFisiMaster.nFirmaID  and dteIslemTarihi = tbStokFisiMaster.dteFisTarihi and sCariIslem IN ('','N','AC','AS','TCG','CG')) as lTahsilat,(Select ISNULL(SUM(lBorcTutar-lAlacakTutar),0) as lBakiye from tbFirmaHareketi where nFirmaID = tbFirma.nFirmaID and tbFirmaHareketi.dteIslemTarihi <= tbStokFisiMaster.dteFisTarihi) as lBakiye,tbDoviz.sDovizCinsi1,tbDoviz.lDovizKuru1,tbStokFisiMaster.nEfaturaDurum   FROM tbFirma INNER JOIN tbStokFisiMaster ON tbFirma.nFirmaID = tbStokFisiMaster.nFirmaID INNER JOIN tbHareketTipi ON tbStokFisiMaster.sHareketTipi = tbHareketTipi.sHareketTipi INNER JOIN tbStokFisiAciklamasi ON tbStokFisiMaster.nStokFisiID = tbStokFisiAciklamasi.nStokFisiID LEFT OUTER JOIN tbStokFisiPesinAdres ON tbStokFisiMaster.nStokFisiID = tbStokFisiPesinAdres.nStokFisiID LEFT OUTER JOIN (SELECT     TOP 1 tbStokFisiMaster.nStokFisiID, ISNULL(sDovizCinsi1,'') sDovizCinsi1, lDovizKuru1 = Case When ISNULL(lDovizKuru1,0) = 0 THEN 1 ELSE lDovizKuru1 END FROM          tbStokFisiDetayi INNER JOIN tbStokFisiMaster ON tbStokFisiMaster.nStokFisiID = tbStokFisiDetayi.nStokFisiID INNER JOIN tbFirma ON tbStokFisiDetayi.nFirmaID = tbFirma.nFirmaID  GROUP BY tbStokFisiMaster.nStokFisiID, sDovizCinsi1, lDovizKuru1 ORDER BY tbStokFisiMaster.nStokFisiID,sDovizCinsi1 DESC) tbDoviz ON tbStokFisiMaster.nStokFisiID = tbDoviz.nStokFisiID  " & kriter & " ORDER BY tbStokFisiMaster.dteFisTarihi, tbStokFisiMaster.lFisNo")

        End If
        sSorgu_Hareket = cmd.CommandText
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
        Dim connection As New OleDbConnection
        Dim adapter As New OleDbDataAdapter
        Dim command As New OleDbCommand
        connection.ConnectionString = Conversions.ToString(Me.connection)
        adapter.SelectCommand = command
        command.CommandText = Me.sorgu_query(("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbFirma.nFirmaID, tbFirma.sKodu, tbFirma.sAciklama, tbFirma.nOzelIskontosu, tbFirma.lKrediLimiti, SUM(tbFirmaHareketi.lBorcTutar) AS BORC, SUM(tbFirmaHareketi.lAlacakTutar) AS ALACAK, SUM(tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) AS BAKIYE FROM tbFirmaHareketi INNER JOIN tbFirma ON tbFirmaHareketi.nFirmaID = tbFirma.nFirmaID WHERE tbFirma.nFirmaID ='" & nFirmaID & "' GROUP BY tbFirma.nFirmaID, tbFirma.sKodu, tbFirma.sAciklama, tbFirma.nOzelIskontosu, tbFirma.lKrediLimiti"))
        command.Connection = connection
        connection.Open()
        Dim dataSet As New DataSet
        Dim num As Integer = adapter.Fill(dataSet, "BASLIK")
        connection.Close()
        connection = Nothing
        command = Nothing
        adapter = Nothing
        Return dataSet
    End Function
    Private Function KayitSiniri_kontrol(ByVal tbTable As String, ByVal kriter As String, ByVal nKayitSinir As Integer) As Boolean
        Dim pass As Boolean = False
        If nKayitSinir > 0 Then
            Dim yetki As Int64 = Sorgu_tbKayitSayisi(tbTable, kriter, nKayitSinir)
            If yetki = 0 Then
                XtraMessageBox.Show(Sorgu_sDil("Üzgünüm Kısıtlı Kullanım.Maximum Kayıt Sınırını Aşamazsınız...!" & vbCrLf & "Lütfen Yetkili Satıcınızla Görüşün...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
                status = True
                pass = False
            ElseIf yetki = 1 Then
                pass = True
            End If
        Else
            pass = True
        End If
        Return pass
    End Function
    Private Function Sorgu_tbKayitSayisi(ByVal tbTable As String, ByVal kriter As String, ByVal nKayitSinir As Integer) As Int64
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim kayitsayisi As Int64 = 0
        Dim formkayitsayisi As Int64 = 0
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(*), 0) AS Kayit FROM         " & tbTable & "  " & kriter & " ")
        formkayitsayisi = cmd.ExecuteScalar
        con.Close()
        If formkayitsayisi >= nKayitSinir Then
            kayitsayisi = 0
        Else
            kayitsayisi = 1
        End If
        Return kayitsayisi
        'kayitsayisi = Nothing
        formkayitsayisi = Nothing
        cmd = Nothing
        con = Nothing
    End Function
    Private Sub dataload(ByVal ara As String, ByVal konum As String, ByVal ara_kriter As String, ByVal sFisTipi As String, ByVal nGirisCikis As String, ByVal dteFisTarihi1 As DateTime, ByVal dteFisTarihi2 As DateTime, ByVal lFisNo1 As Int64, ByVal lFisNo2 As Int64, ByVal lNetTutar1 As Decimal, ByVal lNetTutar2 As Decimal, ByVal sDepo As String, ByVal sHareketTipi As String, ByVal sSaticiRumuzu As String, Optional ByVal bListele As Boolean = True)
        bInfo = False
        status = True
        DataSet1 = stok(ara, konum, ara_kriter, sFisTipi, nGirisCikis, dteFisTarihi1, dteFisTarihi2, lFisNo1, lFisNo2, lNetTutar1, lNetTutar2, sDepo, sHareketTipi, sSaticiRumuzu)
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
        If Trim(sFisTipi) = "IA" Or Trim(sFisTipi) = "IS" Then
            colsFaturalasti.Visible = True
        Else
            colsFaturalasti.Visible = False
        End If
        If bListele = True Then
            If GridView1.RowCount > 0 Then
                GridView1.ClearSelection()
                GridView1.FocusedRowHandle = GridView1.RowCount - 1
                GridView1.SelectRow(GridView1.FocusedRowHandle)
                GridControl1.Focus()
            End If
        End If
        bInfo = True
        satir_firma_info()
        status = True
    End Sub
    Private Sub analiz_Firma_karti()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            If Trim(dr("sFisTipi")) = "PF" Then
                Dim frm As New frm_musteri_karti
                frm.firmano = firmano
                frm.donemno = donemno
                frm.connection = connection
                frm.musterino = dr("sKodu")
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
                frm.sKodu = dr("sKodu")
                frm.nFirmaID = dr("nFirmaID")
                frm.kullanici = kullanici
                If yetki_kontrol(kullanici, frm.Name) = True Then
                    Dim conn As New OleDb.OleDbConnection(sConnection)



                    conn.Open()
                    Dim cmd As New OleDb.OleDbCommand("select * from aPersonelYetki  where  PersonelNo='" + kullanici + "' and Form='frm_firma_kartı_limiti'", conn)
                    Dim dr1 As OleDb.OleDbDataReader
                    dr1 = cmd.ExecuteReader()
                    While dr1.Read()
                        If Convert.ToBoolean((dr1.Item("Yetki"))) = False Then

                            frm.txt_lKrediLimiti.Enabled = False
                            frm.ShowDialog()

                        Else
                            frm.txt_lKrediLimiti.Enabled = True
                            frm.ShowDialog()

                        End If

                    End While
                    conn.Close()
                End If
                frm.Close()
                frm.Dispose()
                frm = Nothing
            End If
            dr = Nothing
        End If
    End Sub
    Private Sub tbFisDepo_ekle(ByVal sFisTipi As String, ByVal nGirisCikis As Integer)
        If KayitSiniri_kontrol("tbStokFisiMaster", "Where sFisTipi = '" & sFisTipi & "' and nGirisCikis =" & nGirisCikis & "", nKayitSinir) = True Then
            If yetki_kontrol(kullanici, sFisTipi) = True And yetki_kontrol(kullanici, Trim(sFisTipi) & "_IslemYapamaz", False, 0) = False Then
                Dim frm As New frm_fatura_depo
                frm.firmano = firmano
                frm.donemno = donemno
                frm.connection = connection
                frm.txt_dteFisTarihi1.EditValue = dteSistemTarihi
                frm.sFisTipi = sFisTipi
                frm.nGirisCikis = nGirisCikis
                frm.kullanici = kullanici
                frm.kasiyer = kullaniciadi
                frm.nFirmaID = 0
                frm.Show()
            End If
        End If
    End Sub
    Private Sub tbFis_ekle(ByVal sFisTipi As String, ByVal nGirisCikis As Integer)
        If Trim(sFisTipi) = "T" Then
            tbFisDepo_ekle(sFisTipi, nGirisCikis)
        Else
            If KayitSiniri_kontrol("tbStokFisiMaster", "Where sFisTipi = '" & sFisTipi & "'", nKayitSinir) = True Then
                If yetki_kontrol(kullanici, sFisTipi) = True And yetki_kontrol(kullanici, Trim(sFisTipi) & "_IslemYapamaz", False, 0) = False Then
                    Dim frm_firma As New frm_firma_liste
                    frm_firma.firmano = firmano
                    frm_firma.donemno = donemno
                    frm_firma.connection = connection
                    frm_firma.islemstatus = True
                    frm_firma.kullanici = kullanici
                    frm_firma.nGirisCikis = nGirisCikis
                    frm_firma.bFis = True
                    If frm_firma.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                        Dim dr1 As DataRow
                        dr1 = frm_firma.GridView1.GetDataRow(frm_firma.GridView1.FocusedRowHandle)
                        'If nGirisCikis <> 3 Then
                        '    dr1("bSatisYapilamaz") = True
                        'End If
                        If dr1("bSatisYapilamaz") = False Then
                            Dim frm As New frm_fatura
                            frm.firmano = firmano
                            frm.donemno = donemno
                            frm.connection = connection
                            frm.kullanici = kullanici
                            frm.nStokFisiID = ""
                            frm.nFirmaID = dr1("nFirmaID")
                            frm.nOpsiyon = dr1("nVadeGun")
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
                        Else
                            XtraMessageBox.Show(Sorgu_sDil("Seçtiğiniz Hesabın Satış Yetkisi Yok, Lütfen Kontrol Ediniz...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If
                        ara()
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub fis_duzelt()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            If sorgu_nStokFisiID_lSayi(dr("nStokFisiID")) > 0 Then
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
                frm.bResmi = sec_resmi.Checked
                If yetki_kontrol(kullanici, frm.Name) = True Then
                    Try
                        frm.Show()
                    Catch ex As Exception
                    End Try
                End If
            Else
                XtraMessageBox.Show(Sorgu_sDil("Kayıt Bulunamadı...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
            dr = Nothing
        End If
    End Sub
    Public Function sorgu_nStokFisiID_lSayi(ByVal nStokFisiID As String) As Integer
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        conn.ConnectionString = connection
        cmd.Connection = conn
        Dim kayitsayisi
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(nStokFisiID), 0) AS nKayit FROM         tbStokFisiMaster WHERE     (nStokFisiID = '" & nStokFisiID & "')")
        kayitsayisi = 0
        'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT ISNULL(SUM(lOdemeTutar),0) AS lOdemeTutar FROM (SELECT ISNULL(SUM(lOdemeTutar) , 0) AS lOdemeTutar FROM tbOdeme WHERE (nOdemeKodu = 1) AND (nAlisverisID = '" & nAlisVerisID & "') UNION ALL SELECT ISNULL(SUM(lTutari) , 0) AS lOdemeTutar FROM tbTaksit WHERE nAlisVerisID = '" & nAlisVerisID & "') as Kapatma")
        kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
        cmd = Nothing
        conn = Nothing
    End Function
    Private Sub analiz_cari_hareket()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_cari_hareketler_ozet
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.musterino = dr("sKodu")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                If yetki_kontrol(kullanici, "frm_firma_liste_hesapTuru_" & Trim(CariHesapTuruSorgula(dr("sKodu")))) = True Then
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
    Private Sub analiz_toplam(ByVal sIslem As String)
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_tbToplam
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.sKriter = sKriter
            frm.sIslem = sIslem
            frm.kullanici = kullanici
            frm.ShowDialog()
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub analiz_cari_bakiye()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_Firma_bakiye
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.sKodu = dr("sKodu")
            frm.txt_musteriNo.EditValue = dr("sKodu")
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
            If GridView1.RowCount > 0 And bInfo = True Then
                Dim dr As DataRow
                dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                ds_satir_firma = sorgu_firma_info(dr("nFirmaID"))
                Dim dr1 As DataRow = ds_satir_firma.Tables(0).Rows(0)
                label3.Text = dr1("sAciklama") & vbTab & "    Iskontosu: " & dr1("nOzelIskontosu") & " Kredilimiti: " & dr1("lKrediLimiti") & "   Borç: " & FormatNumber(dr1("BORC"), 2) & "   Alacak: " & FormatNumber(dr1("ALACAK"), 2) & "   Bakiye: " & Microsoft.VisualBasic.Format(dr1("BAKIYE"), "#,#0.00(B);#,#0.00(A);-")
                label3.Refresh()
                dr1 = Nothing
            End If
        Catch ex As Exception
            label3.Text = "*"
            label3.Refresh()
        End Try
    End Sub
    Private Sub satirlar_kilit(ByVal bKilitli As Byte)
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
                tbStokMaster_Kilit(dr("nStokFisiID"), bKilitli)
            Next
        End If
        ara()
        XtraMessageBox.Show(Sorgu_sDil("İşlem Başarıyla Tamamlandı", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
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
            If Trim(sec_sFisTipi.EditValue) = "IA" Or Trim(sec_sFisTipi.EditValue) = "IS" Then
                MenuItem13.Visible = True
                MenuItem13.Enabled = True
            End If
        Else
            MenuItem13.Visible = False
            MenuItem13.Enabled = False
        End If
    End Sub
    Private Sub fis_faturala()
        Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        Dim frm As New frm_stok_cari_alis_aciklama
        frm.txt_tarih.EditValue = dteSistemTarihi
        If Trim(sec_sFisTipi.EditValue) = "IS" Then
            frm.txt_belgeno.EditValue = sorgu_lFisNo(dr("nFirmaID"), "FS", 3, sDepo)
        ElseIf Trim(sec_sFisTipi.EditValue) = "IA" Then
            frm.txt_belgeno.EditValue = sorgu_lFisNo(dr("nFirmaID"), "FA", 1, sDepo)
        Else
            frm.txt_belgeno.EditValue = 1
        End If
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
            Dim s As String = ""
            'Dim dr As DataRow
            Dim lFisNo As Int64 = 1
            Dim dteFisTarihi As DateTime
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
            If XtraMessageBox.Show(sFisNolari & Sorgu_sDil(" Nolu Fişleri ", sDil) & frm.txt_tarih.EditValue & Sorgu_sDil(" Tarih ", sDil) & frm.txt_belgeno.EditValue & Sorgu_sDil(" Nolu Faturaya Dönüştürmek İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
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
                nStokFisiID = tbStokFisiMaster_kaydet_yeni(nStokFisiID, sFisTipi, dteFisTarihi, nGirisCikis, lFisNo, nFirmaID, "", dteFisTarihi, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "", "", "", "", "", sHareketTipi, 0, 0, 0, "", "", 0, kullanici, Now, "", 0, 0, 0, 0, 0, 0)
                'tbStokFisiMaster_lFisno_degistir(nStokFisiID)
                tbStokFisiAciklamasi_kaydet_yeni(nStokFisiID, "", "", "", "", "", "", "", "", "", "")
                tbStokFisidetay_kaydet_faturala(sFisTipi, dteFisTarihi, lFisNo, sHareketTipi, nStokFisiID, enStokFisiID)
                'Fişi Göster
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
                fm.Text = "Fis#Faturalanmış"
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
    Public Function sorgu_lFisNo(ByVal nFirmaID As String, ByVal sFisTipi As String, ByVal nGirisCikis As Integer, ByVal sDepo As String, Optional ByVal bDegistir As Boolean = True, Optional ByVal sOperator As String = "+", Optional ByVal nSayfa As Integer = 1) As Int64
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        cmd.Connection = con
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim kayitsayisi As Int64 = 0
        If sOperator = "+" And nSayfa = 1 Then
            If nGirisCikis = 1 Or nGirisCikis = 2 Or nGirisCikis = 4 Then
                If Trim(sFisTipi) = "MM" Then
                    cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(lSevkFaturasi2,0) + 1 AS lFisNo FROM         tbStokFisNolar WHERE     (sDepo = '" & sDepo & "')")
                Else
                    cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT      ISNULL(MAX(lFisNo), 0) + 1 AS lFisNo FROM         tbStokFisiMaster  Where sFisTipi = '" & sFisTipi & "'  AND nStokFisiID IN (Select TOP 3 nStokFisiID from tbStokFisiMaster Where sFisTipi ='" & sFisTipi & "' and nFirmaID = " & nFirmaID & " and nGirisCikis =" & nGirisCikis & " Order by dteFisTarihi DESC)")
                End If
                'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT      ISNULL(MAX(lFisNo), 0) + 1 AS lFisNo FROM         tbStokFisiMaster  Where sFisTipi = '" & sFisTipi & "'  AND nStokFisiID IN (Select TOP 3 nStokFisiID from tbStokFisiMaster Where sFisTipi ='" & sFisTipi & "' and nFirmaID = " & nFirmaID & " and nGirisCikis =" & nGirisCikis & " Order by dteFisTarihi DESC)")
            ElseIf nGirisCikis = 3 Then
                Dim nCiktiSatirSayisi As Integer = 25
                If bKendiFisNo = True Then
                    If Trim(sFisTipi) = "FS" Then
                        nCiktiSatirSayisi = nFaturaCiktiSatirSayisi
                        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(lToptanFatura2,0) + 1 AS lFisNo FROM         tbStokFisNolar WHERE     (sDepo = '" & sDepo & "') ")
                    ElseIf Trim(sFisTipi) = "IS" Then
                        nCiktiSatirSayisi = nIrsaliyeCiktiSatirSayisi
                        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(lToptanIrsaliye2,0) + 1 AS lFisNo FROM         tbStokFisNolar WHERE     (sDepo = '" & sDepo & "')")
                    ElseIf Trim(sFisTipi) = "DC" Then
                        nCiktiSatirSayisi = nStokFisiCiktiSatirSayisi
                        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(lSevkFaturasi2,0) + 1 AS lFisNo FROM         tbStokFisNolar WHERE     (sDepo = '" & sDepo & "')")
                    ElseIf Trim(sFisTipi) = "HS" Then
                        nCiktiSatirSayisi = nFaturaCiktiSatirSayisi
                        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(lToptanFatura2,0) + 1 AS lFisNo FROM         tbStokFisNolar WHERE     (sDepo = '" & sDepo & "')")
                    End If
                Else
                    If Trim(sFisTipi) = "FS" Then
                        nCiktiSatirSayisi = nFaturaCiktiSatirSayisi
                        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(lToptanFatura1,0) + 1 AS lFisNo FROM         tbStokFisNolar WHERE     (sDepo = '" & sDepo & "') ")
                    ElseIf Trim(sFisTipi) = "IS" Then
                        nCiktiSatirSayisi = nIrsaliyeCiktiSatirSayisi
                        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(lToptanIrsaliye1,0) + 1 AS lFisNo FROM         tbStokFisNolar WHERE     (sDepo = '" & sDepo & "')")
                    ElseIf Trim(sFisTipi) = "DC" Then
                        nCiktiSatirSayisi = nStokFisiCiktiSatirSayisi
                        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(lSevkFaturasi1,0) + 1 AS lFisNo FROM         tbStokFisNolar WHERE     (sDepo = '" & sDepo & "')")
                    ElseIf Trim(sFisTipi) = "HS" Then
                        nCiktiSatirSayisi = nFaturaCiktiSatirSayisi
                        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(lToptanFatura1,0) + 1 AS lFisNo FROM         tbStokFisNolar WHERE     (sDepo = '" & sDepo & "')")
                    End If
                End If
            End If
            If cmd.CommandText <> "" Then
                kayitsayisi = cmd.ExecuteScalar
            End If
        End If
        If kayitsayisi = 0 Then
            kayitsayisi = 1
        End If
        If bDegistir = True Then
            If nGirisCikis = 3 Then
                If bKendiFisNo = True Then
                    If Trim(sFisTipi) = "FS" Then
                        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbStokFisNolar SET              lToptanFatura2 = lToptanFatura2 " & sOperator & " " & nSayfa & " WHERE     (sDepo = '" & sDepo & "')")
                    ElseIf Trim(sFisTipi) = "IS" Then
                        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbStokFisNolar SET              lToptanIrsaliye2 = lToptanIrsaliye2 " & sOperator & " " & nSayfa & " WHERE     (sDepo = '" & sDepo & "')")
                    ElseIf Trim(sFisTipi) = "DC" Then
                        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbStokFisNolar SET              lSevkFaturasi2 = lSevkFaturasi2 " & sOperator & " " & nSayfa & " WHERE     (sDepo = '" & sDepo & "')")
                    ElseIf Trim(sFisTipi) = "HS" Then
                        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbStokFisNolar SET              lToptanFatura2 = lToptanFatura2 " & sOperator & " " & nSayfa & " WHERE     (sDepo = '" & sDepo & "')")
                    End If
                Else
                    If Trim(sFisTipi) = "FS" Then
                        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbStokFisNolar SET              lToptanFatura1 = lToptanFatura1 " & sOperator & " " & nSayfa & " WHERE     (sDepo = '" & sDepo & "')")
                    ElseIf Trim(sFisTipi) = "IS" Then
                        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbStokFisNolar SET              lToptanIrsaliye1 = lToptanIrsaliye1 " & sOperator & " " & nSayfa & " WHERE     (sDepo = '" & sDepo & "')")
                    ElseIf Trim(sFisTipi) = "DC" Then
                        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbStokFisNolar SET              lSevkFaturasi1 = lSevkFaturasi1 " & sOperator & " " & nSayfa & " WHERE     (sDepo = '" & sDepo & "')")
                    ElseIf Trim(sFisTipi) = "HS" Then
                        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbStokFisNolar SET              lToptanFatura1 = lToptanFatura1 " & sOperator & " " & nSayfa & " WHERE     (sDepo = '" & sDepo & "')")
                    End If
                End If
                cmd.ExecuteNonQuery()
            ElseIf Trim(sFisTipi) = "MM" Then
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbStokFisNolar SET              lSevkFaturasi2 = lSevkFaturasi2 " & sOperator & " " & nSayfa & " WHERE     (sDepo = '" & sDepo & "')")
                cmd.ExecuteNonQuery()
            End If
        End If
        Return kayitsayisi
        con.Dispose()
        cmd.Dispose()
        adapter.Dispose()
        cmd = Nothing
    End Function
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
        'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY INSERT INTO tbStokFisiMaster (sFisTipi, dteFisTarihi, nGirisCikis, lFisNo, nFirmaID, sDepo, dteValorTarihi, bPesinmi, bListelendimi, bHizmetFaturasimi, lToplamMiktar, lMalBedeli, lMalIskontoTutari, nDipIskontoYuzdesi1, lDipIskontoTutari1, nDipIskontoYuzdesi2, lDipIskontoTutari2, lDipIskontoTutari3, lEkmaliyet1, lEkmaliyet2, lEkmaliyet3, nKdvOrani1, lKdvMatrahi1, lKdv1, nKdvOrani2, lKdvMatrahi2, lKdv2, nKdvOrani3, lKdvMatrahi3, lKdv3, nKdvOrani4, lKdvMatrahi4, lKdv4, nKdvOrani5, lKdvMatrahi5, lKdv5, lNetTutar, nTevkifatKdvOrani, lTevkifatKdvMatrahi, lTevkifatKdv, sCariIslem, nCariHareketID, nKasaIslemID, sCariKdvIslem, nCariKdvHareketID, sHareketTipi, bMuhasebeyeIslendimi, bFisTamamlandimi, lTransferFisiID, nTransferFirmaID, sTransferDepo, bFaturayaDonustumu, sKullaniciAdi, dteKayitTarihi, sYaziIle, nOTVOrani1, lOTVMatrahi1, lOTV1, nOTVOrani2, lOTVMatrahi2, lOTV2, bFaturaTipi, sKdvMuafiyetKodu, nTasimaSekli, lBrutAgirlik, lNetAgirlik, nPaketSayisi, sPaketTipi, sGumrukCikisNo, sTeslimatUlke) VALUES     ('" & sFisTipi & "', '" & dteFisTarihi & "', " & nGirisCikis & " , '" & lFisNo & "', " & nFirmaID & ", '" & sDepo & "', '" & dteValorTarihi & "', " & bPesinmi & " , " & bListelendimi & " , " & bHizmetFaturasimi & " , " & lToplamMiktar & " , " & lMalBedeli & ", " & lMalIskontoTutari & " , " & nDipIskontoYuzdesi1 & " , " & lDipIskontoTutari1 & " , " & nDipIskontoYuzdesi2 & " , " & lDipIskontoTutari2 & " , " & lDipIskontoTutari3 & " , " & lEkmaliyet1 & " , " & lEkmaliyet2 & " , " & lEkmaliyet3 & " , " & nKdvOrani1 & " , " & lKdvMatrahi1 & ", " & lKdv1 & " , " & nKdvOrani2 & ", " & lKdvMatrahi2 & " , " & lKdv2 & ", " & nKdvOrani3 & " , " & lKdvMatrahi3 & ", " & lKdv3 & " , " & nKdvOrani4 & ", " & lKdvMatrahi4 & " , " & lKdv4 & " , " & nKdvOrani5 & " , " & lKdvMatrahi5 & " , " & lKdv5 & " , " & lNetTutar & " , " & nTevkifatKdvOrani & " , " & lTevkifatKdvMatrahi & ", " & lTevkifatKdv & " , '" & sCariIslem & "', '" & nCariHareketID & "', '" & nKasaIslemID & "', '" & sCariKdvIslem & "', '" & nCariKdvHareketID & "', '" & sHareketTipi & "', " & bMuhasebeyeIslendimi & ", " & bFisTamamlandimi & ", '" & lTransferFisiID & "', '" & nTransferFirmaID & "', '" & sTransferDepo & "', " & bFaturayaDonustumu & " , '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', '" & sYaziIle & "', " & nOTVOrani1 & ", " & lOTVMatrahi1 & ", " & lOTV1 & ", " & nOTVOrani2 & " , " & lOTVMatrahi2 & ", " & lOTV2 & ", '', '', 0, 0, 0, 0, '', '', '')")
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY INSERT INTO tbStokFisiMaster (sFisTipi, dteFisTarihi, nGirisCikis, lFisNo, nFirmaID, sDepo, dteValorTarihi, bPesinmi, bListelendimi, bHizmetFaturasimi, lToplamMiktar, lMalBedeli, lMalIskontoTutari, nDipIskontoYuzdesi1, lDipIskontoTutari1, nDipIskontoYuzdesi2, lDipIskontoTutari2, lDipIskontoTutari3, lEkmaliyet1, lEkmaliyet2, lEkmaliyet3, nKdvOrani1, lKdvMatrahi1, lKdv1, nKdvOrani2, lKdvMatrahi2, lKdv2, nKdvOrani3, lKdvMatrahi3, lKdv3, nKdvOrani4, lKdvMatrahi4, lKdv4, nKdvOrani5, lKdvMatrahi5, lKdv5, lNetTutar, nTevkifatKdvOrani, lTevkifatKdvMatrahi, lTevkifatKdv, sHareketTipi, bMuhasebeyeIslendimi, bFisTamamlandimi, lTransferFisiID,  sTransferDepo, bFaturayaDonustumu, sKullaniciAdi, dteKayitTarihi, sYaziIle, nOTVOrani1, lOTVMatrahi1, lOTV1, nOTVOrani2, lOTVMatrahi2, lOTV2, bFaturaTipi, sKdvMuafiyetKodu, nTasimaSekli, lBrutAgirlik, lNetAgirlik, nPaketSayisi, sPaketTipi, sGumrukCikisNo, sTeslimatUlke) VALUES     ('" & sFisTipi & "', '" & dteFisTarihi & "', " & nGirisCikis & " , '" & lFisNo & "', " & nFirmaID & ", '" & sDepo & "', '" & dteValorTarihi & "', " & bPesinmi & " , " & bListelendimi & " , " & bHizmetFaturasimi & " , " & lToplamMiktar & " , " & lMalBedeli & ", " & lMalIskontoTutari & " , " & nDipIskontoYuzdesi1 & " , " & lDipIskontoTutari1 & " , " & nDipIskontoYuzdesi2 & " , " & lDipIskontoTutari2 & " , " & lDipIskontoTutari3 & " , " & lEkmaliyet1 & " , " & lEkmaliyet2 & " , " & lEkmaliyet3 & " , " & nKdvOrani1 & " , " & lKdvMatrahi1 & ", " & lKdv1 & " , " & nKdvOrani2 & ", " & lKdvMatrahi2 & " , " & lKdv2 & ", " & nKdvOrani3 & " , " & lKdvMatrahi3 & ", " & lKdv3 & " , " & nKdvOrani4 & ", " & lKdvMatrahi4 & " , " & lKdv4 & " , " & nKdvOrani5 & " , " & lKdvMatrahi5 & " , " & lKdv5 & " , " & lNetTutar & " , " & nTevkifatKdvOrani & " , " & lTevkifatKdvMatrahi & ", " & lTevkifatKdv & " ,  '" & sHareketTipi & "', " & bMuhasebeyeIslendimi & ", " & bFisTamamlandimi & ", '" & lTransferFisiID & "',  '" & sTransferDepo & "', " & bFaturayaDonustumu & " , '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', '" & sYaziIle & "', " & nOTVOrani1 & ", " & lOTVMatrahi1 & ", " & lOTV1 & ", " & nOTVOrani2 & " , " & lOTVMatrahi2 & ", " & lOTV2 & ", '', '', 0, 0, 0, 0, '', '', '')")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        nStokFisiID = cmd.ExecuteScalar
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
    Private Sub tbStokFisiAciklamasi_kaydet_yeni(ByVal nStokFisiID As String, ByVal sAciklama1 As String, ByVal sAciklama2 As String, ByVal sAciklama3 As String, ByVal sAciklama4 As String, ByVal sAciklama5 As String, ByVal sAciklama6 As String, ByVal sAciklama7 As String, ByVal sAciklama8 As String, ByVal sAciklama9 As String, ByVal sAciklama10 As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY INSERT INTO tbStokFisiAciklamasi                       (nStokFisiID, sAciklama1, sAciklama2, sAciklama3, sAciklama4, sAciklama5,sAciklama6,sAciklama7,sAciklama8,sAciklama9,sAciklama10) VALUES     ('" & nStokFisiID & "', '" & sAciklama1 & "', '" & sAciklama2 & "', '" & sAciklama3 & "', '" & sAciklama4 & "', '" & sAciklama5 & "', '" & sAciklama6 & "', '" & sAciklama7 & "', '" & sAciklama8 & "', '" & sAciklama9 & "', '" & sAciklama10 & "')")
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
    Private Sub tbStokMaster_Kilit(ByVal nStokFisiID As String, ByVal bKilitli As Byte)
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        conn.ConnectionString = connection
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Update tbStokFisiMaster set bKilitli = " & bKilitli & " where nStokFisiID  =" & nStokFisiID & "")
        cmd.ExecuteNonQuery()
        conn.Close()
        cmd = Nothing
    End Sub
    Private Sub raporla(ByVal rapor As Integer, ByVal nIslem As Integer)
        Dim sfile As String
        OpenFileDialog1.Filter = "Rapor Dosyaları (form_liste_*.frx) |form_liste*.frx"
        OpenFileDialog1.InitialDirectory = "c:\Formlar\Raporlar\Dokumler"
        OpenFileDialog1.FileName = "c:\Formlar\Raporlar\Dokumler\Form_liste.frx"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            sfile = OpenFileDialog1.FileName.ToString
            'report_create_stok(file, "", islem)
            Dim report As New FastReport.Report
            report.Load(sfile)
            report.RegisterData(DataSet1)
            report.RegisterData(ds_tbParamGenel)
            report.SetParameterValue("dteFisTarihi1", txt_dteFisTarihi1.EditValue)
            report.SetParameterValue("dteFisTarihi2", txt_dteFisTarihi2.EditValue)
            report.SetParameterValue("lFisNo1", txt_lFisNo1.EditValue)
            report.SetParameterValue("lFisNo2", txt_lFisNo2.EditValue)
            report.SetParameterValue("sFisTipi", sec_sFisTipi.Text)
            report.SetParameterValue("nGirisCikis", sec_nGirisCikis.Text)
            report.SetParameterValue("sDepo", sec_sdepo.Text)
            report.SetParameterValue("sHareketTipi", sec_sHareketTipi.Text)
            report.SetParameterValue("sSaticiRumuzu", sec_sSatici.Text)
            report.ScriptLanguage = Language.Vb
            If nIslem = 0 Then
                report.Show()
            ElseIf nIslem = 2 Then
                report.Design()
            ElseIf nIslem = 1 Then
                report.Print()
            End If
            report.Dispose()
            report = Nothing
        End If
    End Sub
    Private Sub raporla_dokum(ByVal rapor As Integer, ByVal nIslem As Integer)
        Dim dr1 As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        Dim OpenFileDialog1 As New Windows.Forms.OpenFileDialog
        OpenFileDialog1.Title = "Rapor Seç..."
        OpenFileDialog1.Filter = "Rapor Dosyaları (Form*.fr*) |Form*.fr*"
        OpenFileDialog1.FileName = "c:\Formlar\Raporlar\Dokumler\Form_" & Trim(dr1("sFisTipi")) & "" & sRaporUzanti & ""
        OpenFileDialog1.InitialDirectory = "c:\Formlar\Raporlar\Dokumler"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim sFile = OpenFileDialog1.FileName.ToString
            If Microsoft.VisualBasic.Right(sFile, 3) = "fr3" Then
                Dim dr As DataRow
                Dim s As String
                Dim arr As Integer()
                Dim i As Integer
                arr = GridView1.GetSelectedRows()
                If arr Is Nothing Then
                Else
                    Array.Sort(arr)
                    For Each i In arr
                        s = i.ToString
                        dr = GridView1.GetDataRow(s)
                        report_create_stok(dr("nStokFisiID"), sFile, "", nIslem)
                    Next
                End If
            ElseIf Microsoft.VisualBasic.Right(sFile, 3) = "frx" Then
                Dim dr As DataRow
                Dim s As String
                Dim arr As Integer()
                Dim i As Integer
                arr = GridView1.GetSelectedRows()
                If arr Is Nothing Then
                Else
                    Array.Sort(arr)
                    For Each i In arr
                        s = i.ToString
                        dr = GridView1.GetDataRow(s)
                        Dim report As New FastReport.Report
                        report.Load(sFile)
                        Dim ds_baslik As DataSet
                        Dim ds_hareket As DataSet
                        Dim ds_toplam As DataSet
                        Dim ds_DToplam As DataSet
                        Dim ds_iskonto As DataSet
                        Dim ds_Kesinti As DataSet
                        Dim ds_masraf As DataSet
                        Dim nStokFisiID As String = dr("nStokFisiID")
                        'Dim sFisTipi As String = dr("sFisTipi")
                        If Trim(dr("sFisTipi")) = "PF" Then
                            ds_baslik = sorgu(sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbStokFisiMaster.*, DATEDIFF(day, tbStokFisiMaster.dteFisTarihi, tbStokFisiMaster.dteValorTarihi) AS nOpsiyon,tbStokFisiAciklamasi.sAciklama1, tbStokFisiAciklamasi.sAciklama2, tbStokFisiAciklamasi.sAciklama3, tbStokFisiAciklamasi.sAciklama4, tbStokFisiAciklamasi.sAciklama5,  tbStokFisiAciklamasi.sAciklama6,  tbStokFisiAciklamasi.sAciklama7 , tbStokFisiAciklamasi.sAciklama8 , tbStokFisiAciklamasi.sAciklama9 , tbStokFisiAciklamasi.sAciklama10, (SELECT nGCT FROM tbFisTipi WHERE sFisTipi = tbStokFisiMaster.sFisTipi) AS nGCT, tbMusteri.nMusteriID, tbMusteri.lKodu as sKodu, tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi as sAciklama,tbMusteri.sAdi, tbMusteri.sSoyadi, tbMusteri.nIskontoPesin, tbMusteri.nIskontoKredili, tbMusteri.sUnvan, tbMusteri.sVergiDairesi, tbMusteri.sVergiNo, tbMusteri.bYazismaEvAdresinemi, tbMusteri.sEmail, tbMusteri.sIsYeriAdi, tbMusteri.sIsAdresi1, tbMusteri.sIsAdresi2, tbMusteri.sIsSemt, tbMusteri.sIsIl, tbMusteri.sIsPostaKodu, tbMusteri.sIsTelefonu, tbMusteri.sEvAdresi1 as sAdres1, tbMusteri.sEvAdresi2 as sAdres2, tbMusteri.sEvSemt as sSemt, tbMusteri.sEvPostaKodu as sPostaKodu, tbMusteri.sEvIl as sIl, tbMusteri.sEvTelefonu, tbMusteri.sSigortaNo, tbMusteri.bEvlimi, tbMusteri.dteEvlilikTarihi, tbMusteri.dteDogumTarihi, tbMusteri.sDogumYeri, tbMusteri.sEhliyetNo, tbMusteri.sKanGrubu, tbMusteri.sHitap, tbMusteri.sAciklama1 AS sMusteriAciklama1, tbMusteri.sAciklama2 AS sMusteriAciklama2, tbMusteri.sAciklama3 AS sMusteriAciklama3, tbMusteri.sAciklama4 AS sMusteriAciklama4, tbMusteri.sAciklama5 AS sMusteriAciklama5, tbMusteri.sAciklama6 AS sMusteriAciklama6 , tbMusteri.sAciklama7 AS sMusteriAciklama7 , tbMusteri.sAciklama8 AS sMusteriAciklama8 , tbMusteri.sAciklama9 AS sMusteriAciklama9 , tbMusteri.sAciklama10 AS sMusteriAciklama10, tbMusteri.sGSM, tbMusteri.sFax, 0 as lBakiye FROM tbStokFisiMaster INNER JOIN tbStokFisiAciklamasi ON tbStokFisiMaster.nStokFisiID = tbStokFisiAciklamasi.nStokFisiID INNER JOIN tbMusteri ON tbStokFisiMaster.lFisNo = tbMusteri.lKodu WHERE (tbStokFisiMaster.nStokFisiID = '" & nStokFisiID & "')"), "BASLIK")
                            ds_hareket = sorgu(sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbStokFisiDetayi.*, (SELECT ISNULL(SUM(lTutar) , 0) FROM tbStokFisiEkMaliyet WHERE nStokFisiID = tbStokFisiDetayi.nStokFisiID AND nIslemID = tbStokFisiDetayi.nIslemID) AS lEkIlaveMaliyetTutar,tbStok.sKodu AS sStokKodu, tbStok.sAciklama AS sStokAciklama,tbStok.sBirimCinsi1,tbStok.sBirimCinsi2,ISNULL((SELECT     ISNULL(lOran, 0) FROM         tbStokBirimCevrimi WHERE     nStokID = tbStok.nStokID AND sBirimCinsi = tbStok.sBirimCinsi2), 1) AS nBirimCarpan,dbo.ROUNDYTL(lCikisMiktar1 / ISNULL((SELECT     ISNULL(lOran, 0) FROM         tbStokBirimCevrimi WHERE     nStokID = tbStok.nStokID AND sBirimCinsi = tbStok.sBirimCinsi2), 1) ) as lCikisBirimMiktar , dbo.ROUNDYTL(lGirisMiktar1 / ISNULL((SELECT     ISNULL(lOran, 0) FROM         tbStokBirimCevrimi WHERE     nStokID = tbStok.nStokID AND sBirimCinsi = tbStok.sBirimCinsi2), 1) ) as lGirisBirimMiktar,dbo.ROUNDYTL(tbStokFisiDetayi.lGirisMiktar1 / tbStokFisiDetayi.lBirimMiktar) AS lGirisMiktar,dbo.ROUNDYTL(tbStokFisiDetayi.lCikisMiktar1 / tbStokFisiDetayi.lBirimMiktar) AS lCikisMiktar,tbStok.sModel,tbStok.sBeden, tbStok.nFiyatlandirma,tbStok.nStokTipi,(Select sRenkAdi from tbRenk where sRenk = tbStok.sRenk) as sRenkAdi,(SELECT TOP 1 ISNULL(sBarkod , '') AS sBarkod FROM tbStokBarkodu WHERE nStokID = tbStok.nStokID) AS sBarkod,(SELECT     nKdvOrani FROM          tbKdv WHERE      sKdvTipi = tbStok.sKdvTipi) AS nStokKdvOrani, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatM & "'),0) AS lMaliyet,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatA & "'),0) AS lAlis,CAST(0 AS MONEY) AS ISK1, CAST(0 AS MONEY) AS ISK2, CAST(0 AS MONEY) AS ISK3, CAST(0 AS MONEY) AS ISK4, CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 66, 9) AS MONEY) AS nMasrafSatiri,CAST(0 AS MONEY) AS GERCEKFIYAT, CAST(0 AS MONEY) AS GERCEKTOPLAM, ISNULL(ABS(ROUND((tbStokFisiDetayi.lBrutTutar - tbStokFisiDetayi.lIskontoTutari) * (tbStokFisiDetayi.nKdvOrani / 100), 2)), 0) AS lKdvTutari,dbo.ROUNDYTL(tbStokFisiDetayi.lBrutFiyat * tbStokFisiDetayi.lBirimMiktar) AS lFiyat,CAST(dbo.ROUNDYTL(tbStokFisiDetayi.lBrutFiyat*tbStokFisiDetayi.lBirimMiktar) * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS FLOAT) AS lDahilFiyat,lDovizTutar = CASE WHEN sDovizCinsi1 <> '' AND lDovizKuru1 <> 0 THEN lBrutTutar / lDovizKuru1 ELSE lBrutTutar END, lDovizFiyat = CASE WHEN sDovizCinsi1 <> '' AND lDovizKuru1 <> 0 THEN lBrutFiyat / lDovizKuru1 ELSE lBrutFiyat END FROM tbStokFisiDetayi INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID  WHERE     (tbStokFisiDetayi.nStokFisiID = '" & nStokFisiID & "') ORDER BY tbStokFisiDetayi.nEkSaha1,tbStokFisiDetayi.nIslemID"), "HAREKET")
                        ElseIf Trim(sFisTipi) = "IS" Or Trim(sFisTipi) = "IA" Then
                            ds_baslik = sorgu(sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbStokFisiMaster.*, IADEMI = CASE WHEN tbStokFisiMaster.nGirisCikis = 2 OR tbStokFisiMaster.nGirisCikis =4  THEN 'BU BİR İADE FATURASIDIR' ELSE '' END,DATEDIFF(day, tbStokFisiMaster.dteFisTarihi, tbStokFisiMaster.dteValorTarihi) AS nOpsiyon,tbFirma.sKodu, tbFirma.sAciklama, tbFirma.nOzelIskontosu,tbFirma.nOzelIskontosu2,tbFirma.nOzelIskontosu3,tbFirma.nOzelIskontosu4,tbFirma.sSaticiRumuzu, tbFirma.lKrediLimiti, tbFirma.dteMutabakatTarihi, tbFirma.nVadeGun, tbFirma.sHitap, tbFirma.sAdres1, tbFirma.sAdres2, tbFirma.sSemt, tbFirma.sIl, tbFirma.sUlke, tbFirma.sPostaKodu, tbFirma.sVergiDairesi, tbFirma.sVergiNo, tbFirma.sFiyatTipi, tbStokFisiAciklamasi.sAciklama1, tbStokFisiAciklamasi.sAciklama2, tbStokFisiAciklamasi.sAciklama3, tbStokFisiAciklamasi.sAciklama4, tbStokFisiAciklamasi.sAciklama5, tbStokFisiAciklamasi.sAciklama6, tbStokFisiAciklamasi.sAciklama7, tbStokFisiAciklamasi.sAciklama8,tbStokFisiAciklamasi.sAciklama9, tbStokFisiAciklamasi.sAciklama10, (Select nGCT from tbFisTipi Where sFisTipi = tbStokFisiMaster.sFisTipi) as nGCT,(Select ISNULL(SUM(lBorcTutar-lAlacakTutar),0) as lBakiye from tbFirmaHareketi where nFirmaID = tbFirma.nFirmaID) as lBakiye,(SELECT     TOP 1 sIletisimAdresi FROM          tbFirmaIletisimi WHERE      nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'E-Mail') AS [E-Mail],(SELECT     TOP 1 sIletisimAdresi FROM          tbFirmaIletisimi WHERE      nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Fax') AS [Fax],(SELECT     TOP 1 sIletisimAdresi FROM          tbFirmaIletisimi WHERE      nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Gsm') AS [Gsm],(SELECT     TOP 1 sIletisimAdresi FROM          tbFirmaIletisimi WHERE      nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Telefon') AS [Telefon],(SELECT     TOP 1 sIletisimAdresi FROM          tbFirmaIletisimi WHERE      nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Web') AS [Web],(SELECT     TOP 1 sIletisimAdresi FROM          tbFirmaIletisimi WHERE      nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Yetkili') AS [Yetkili],ISNULL(tbDoviz.sDovizCinsi1,'') as sDovizCinsi1,ISNULL(tbDoviz.lDovizKuru1,0) as lDovizKuru1  FROM tbStokFisiMaster INNER JOIN tbFirma ON tbStokFisiMaster.nFirmaID = tbFirma.nFirmaID INNER JOIN tbStokFisiAciklamasi ON tbStokFisiMaster.nStokFisiID = tbStokFisiAciklamasi.nStokFisiID LEFT OUTER JOIN (SELECT     TOP 1 nStokFisiID, ISNULL(sDovizCinsi1,'') sDovizCinsi1, lDovizKuru1 FROM          tbStokFisiDetayi WHERE (nStokFisiID = '" & nStokFisiID & "') GROUP BY nStokFisiID, sDovizCinsi1, lDovizKuru1 ORDER BY sDovizCinsi1 DESC) tbDoviz ON tbStokFisiMaster.nStokFisiID = tbDoviz.nStokFisiID WHERE (tbStokFisiMaster.nStokFisiID = '" & nStokFisiID & "')"), "BASLIK")
                            ds_hareket = sorgu(sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbStokFisiDetayi.*, (SELECT ISNULL(SUM(lTutar) , 0) FROM tbStokFisiEkMaliyet WHERE nStokFisiID = tbStokFisiDetayi.nStokFisiID AND nIslemID = tbStokFisiDetayi.nIslemID) AS lEkIlaveMaliyetTutar,tbStok.sKodu AS sStokKodu, tbStok.sAciklama AS sStokAciklama,tbStok.sBirimCinsi1,tbStok.sBirimCinsi2,ISNULL((SELECT     ISNULL(lOran, 0) FROM         tbStokBirimCevrimi WHERE     nStokID = tbStok.nStokID AND sBirimCinsi = tbStok.sBirimCinsi2), 1) AS nBirimCarpan,dbo.ROUNDYTL(lCikisMiktar1 / ISNULL((SELECT     ISNULL(lOran, 0) FROM         tbStokBirimCevrimi WHERE     nStokID = tbStok.nStokID AND sBirimCinsi = tbStok.sBirimCinsi2), 1) ) as lCikisBirimMiktar , dbo.ROUNDYTL(lGirisMiktar1 / ISNULL((SELECT     ISNULL(lOran, 0) FROM         tbStokBirimCevrimi WHERE     nStokID = tbStok.nStokID AND sBirimCinsi = tbStok.sBirimCinsi2), 1) ) as lGirisBirimMiktar,dbo.ROUNDYTL(tbStokFisiDetayi.lGirisMiktar1 / tbStokFisiDetayi.lBirimMiktar) AS lGirisMiktar,dbo.ROUNDYTL(tbStokFisiDetayi.lCikisMiktar1 / tbStokFisiDetayi.lBirimMiktar) AS lCikisMiktar,tbStok.sModel, tbStok.sBeden,tbStok.nFiyatlandirma,tbStok.nStokTipi,(Select sRenkAdi from tbRenk where sRenk = tbStok.sRenk) as sRenkAdi,(SELECT TOP 1 ISNULL(sBarkod , '') AS sBarkod FROM tbStokBarkodu WHERE nStokID = tbStok.nStokID) AS sBarkod, (SELECT     nKdvOrani FROM          tbKdv WHERE      sKdvTipi = tbStok.sKdvTipi) AS nStokKdvOrani,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatM & "'),0) AS lMaliyet,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatA & "'),0) AS lAlis,CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 6, 5) AS MONEY) AS ISK1, CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 17, 5) AS MONEY) AS ISK2, CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 28, 5) AS MONEY) AS ISK3, CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 39, 5) AS MONEY) AS ISK4, CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 66, 9) AS MONEY) AS nMasrafSatiri,CAST(0 AS MONEY) AS GERCEKFIYAT, CAST(0 AS MONEY) AS GERCEKTOPLAM, ISNULL(ABS(ROUND((tbStokFisiDetayi.lBrutTutar - tbStokFisiDetayi.lIskontoTutari) * (tbStokFisiDetayi.nKdvOrani / 100), 2)), 0) AS lKdvTutari,dbo.ROUNDYTL(tbStokFisiDetayi.lBrutFiyat * tbStokFisiDetayi.lBirimMiktar) AS lFiyat,CAST(dbo.ROUNDYTL(tbStokFisiDetayi.lBrutFiyat*tbStokFisiDetayi.lBirimMiktar) * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS FLOAT) AS lDahilFiyat,CAST(tbStokFisiDetayi.lBrutFiyat * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS FLOAT) AS lDahilBrutFiyat,CAST(tbStokFisiDetayi.lBrutTutar * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS FLOAT) AS lDahilBrutTutar,lDovizTutar = CASE WHEN sDovizCinsi1 <> '' AND lDovizKuru1 <> 0 THEN lBrutTutar / lDovizKuru1 ELSE lBrutTutar END, lDovizFiyati = CASE WHEN sDovizCinsi1 <> '' AND lDovizKuru1 <> 0 THEN dbo.ROUNDYTL((lBrutFiyat*lBirimMiktar)) / lDovizKuru1 ELSE dbo.ROUNDYTL(lBrutFiyat*lBirimMiktar) END,lDovizBrutFiyati = CASE WHEN sDovizCinsi1 <> '' AND lDovizKuru1 <> 0 THEN lBrutFiyat / lDovizKuru1 ELSE lBrutFiyat END, lDahilDovizTutar = CASE WHEN sDovizCinsi1 <> '' AND lDovizKuru1 <> 0 THEN (lBrutTutar / lDovizKuru1) * (100 + tbStokFisiDetayi.nKdvOrani) / 100 ELSE (lBrutTutar)* (100 + tbStokFisiDetayi.nKdvOrani) / 100  END, lDahilDovizFiyati = CASE WHEN sDovizCinsi1 <> '' AND lDovizKuru1 <> 0 THEN ((lBrutFiyat*lBirimMiktar) / lDovizKuru1)* (100 + tbStokFisiDetayi.nKdvOrani) / 100 ELSE ((lBrutFiyat*lBirimMiktar))* (100 + tbStokFisiDetayi.nKdvOrani) / 100 END,lDahilDovizBrutFiyati = CASE WHEN sDovizCinsi1 <> '' AND lDovizKuru1 <> 0 THEN (lBrutFiyat / lDovizKuru1)* (100 + tbStokFisiDetayi.nKdvOrani) / 100 ELSE (lBrutFiyat)* (100 + tbStokFisiDetayi.nKdvOrani) / 100 END FROM tbStokFisiDetayi INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID  WHERE     (tbStokFisiDetayi.nIrsaliyeFisiID = '" & nStokFisiID & "') ORDER BY tbStokFisiDetayi.nEkSaha1,tbStokFisiDetayi.nIslemID"), "HAREKET")
                        Else
                            ds_baslik = sorgu(sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbStokFisiMaster.*, IADEMI = CASE WHEN tbStokFisiMaster.nGirisCikis = 2 OR tbStokFisiMaster.nGirisCikis =4  THEN 'BU BİR İADE FATURASIDIR' ELSE '' END,DATEDIFF(day, tbStokFisiMaster.dteFisTarihi, tbStokFisiMaster.dteValorTarihi) AS nOpsiyon,tbFirma.sKodu, tbFirma.sAciklama, tbFirma.nOzelIskontosu,tbFirma.nOzelIskontosu2,tbFirma.nOzelIskontosu3,tbFirma.nOzelIskontosu4,tbFirma.sSaticiRumuzu, tbFirma.lKrediLimiti, tbFirma.dteMutabakatTarihi, tbFirma.nVadeGun, tbFirma.sHitap, tbFirma.sAdres1, tbFirma.sAdres2, tbFirma.sSemt, tbFirma.sIl, tbFirma.sUlke, tbFirma.sPostaKodu, tbFirma.sVergiDairesi, tbFirma.sVergiNo, tbFirma.sFiyatTipi, tbStokFisiAciklamasi.sAciklama1, tbStokFisiAciklamasi.sAciklama2, tbStokFisiAciklamasi.sAciklama3, tbStokFisiAciklamasi.sAciklama4, tbStokFisiAciklamasi.sAciklama5,(Select nGCT from tbFisTipi Where sFisTipi = tbStokFisiMaster.sFisTipi) as nGCT,(Select ISNULL(SUM(lBorcTutar-lAlacakTutar),0) as lBakiye from tbFirmaHareketi where nFirmaID = tbFirma.nFirmaID) as lBakiye,(SELECT     TOP 1 sIletisimAdresi FROM          tbFirmaIletisimi WHERE      nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'E-Mail') AS [E-Mail],(SELECT     TOP 1 sIletisimAdresi FROM          tbFirmaIletisimi WHERE      nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Fax') AS [Fax],(SELECT     TOP 1 sIletisimAdresi FROM          tbFirmaIletisimi WHERE      nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Gsm') AS [Gsm],(SELECT     TOP 1 sIletisimAdresi FROM          tbFirmaIletisimi WHERE      nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Telefon') AS [Telefon],(SELECT     TOP 1 sIletisimAdresi FROM          tbFirmaIletisimi WHERE      nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Web') AS [Web],(SELECT     TOP 1 sIletisimAdresi FROM          tbFirmaIletisimi WHERE      nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Yetkili') AS [Yetkili],ISNULL(tbDoviz.sDovizCinsi1,'') as sDovizCinsi1,ISNULL(tbDoviz.lDovizKuru1,0) as lDovizKuru1  FROM tbStokFisiMaster INNER JOIN tbFirma ON tbStokFisiMaster.nFirmaID = tbFirma.nFirmaID INNER JOIN tbStokFisiAciklamasi ON tbStokFisiMaster.nStokFisiID = tbStokFisiAciklamasi.nStokFisiID LEFT OUTER JOIN (SELECT     TOP 1 nStokFisiID, ISNULL(sDovizCinsi1,'') sDovizCinsi1, lDovizKuru1 FROM          tbStokFisiDetayi WHERE (nStokFisiID = '" & nStokFisiID & "') GROUP BY nStokFisiID, sDovizCinsi1, lDovizKuru1 ORDER BY sDovizCinsi1 DESC) tbDoviz ON tbStokFisiMaster.nStokFisiID = tbDoviz.nStokFisiID WHERE (tbStokFisiMaster.nStokFisiID = '" & nStokFisiID & "')"), "BASLIK")
                            ds_hareket = sorgu(sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbStokFisiDetayi.*, (SELECT ISNULL(SUM(lTutar) , 0) FROM tbStokFisiEkMaliyet WHERE nStokFisiID = tbStokFisiDetayi.nStokFisiID AND nIslemID = tbStokFisiDetayi.nIslemID) AS lEkIlaveMaliyetTutar,tbStok.sKodu AS sStokKodu, tbStok.sAciklama AS sStokAciklama,tbStok.sBirimCinsi1,tbStok.sBirimCinsi2,ISNULL((SELECT     ISNULL(lOran, 0) FROM         tbStokBirimCevrimi WHERE     nStokID = tbStok.nStokID AND sBirimCinsi = tbStok.sBirimCinsi2), 1) AS nBirimCarpan,dbo.ROUNDYTL(lCikisMiktar1 / ISNULL((SELECT     ISNULL(lOran, 0) FROM         tbStokBirimCevrimi WHERE     nStokID = tbStok.nStokID AND sBirimCinsi = tbStok.sBirimCinsi2), 1) ) as lCikisBirimMiktar , dbo.ROUNDYTL(lGirisMiktar1 / ISNULL((SELECT     ISNULL(lOran, 0) FROM         tbStokBirimCevrimi WHERE     nStokID = tbStok.nStokID AND sBirimCinsi = tbStok.sBirimCinsi2), 1) ) as lGirisBirimMiktar,dbo.ROUNDYTL(tbStokFisiDetayi.lGirisMiktar1 / tbStokFisiDetayi.lBirimMiktar) AS lGirisMiktar,dbo.ROUNDYTL(tbStokFisiDetayi.lCikisMiktar1 / tbStokFisiDetayi.lBirimMiktar) AS lCikisMiktar,tbStok.sModel, tbStok.sBeden,tbStok.nFiyatlandirma,tbStok.nStokTipi,(Select sRenkAdi from tbRenk where sRenk = tbStok.sRenk) as sRenkAdi,(SELECT TOP 1 ISNULL(sBarkod , '') AS sBarkod FROM tbStokBarkodu WHERE nStokID = tbStok.nStokID) AS sBarkod,(SELECT     nKdvOrani FROM          tbKdv WHERE      sKdvTipi = tbStok.sKdvTipi) AS nStokKdvOrani,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatM & "'),0) AS lMaliyet,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatA & "'),0) AS lAlis, CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 6, 5) AS MONEY) AS ISK1, CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 17, 5) AS MONEY) AS ISK2, CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 28, 5) AS MONEY) AS ISK3, CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 39, 5) AS MONEY) AS ISK4, CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 66, 9) AS MONEY) AS nMasrafSatiri,CAST(0 AS MONEY) AS GERCEKFIYAT, CAST(0 AS MONEY) AS GERCEKTOPLAM, ISNULL(ABS(ROUND((tbStokFisiDetayi.lBrutTutar - tbStokFisiDetayi.lIskontoTutari) * (tbStokFisiDetayi.nKdvOrani / 100), 2)), 0) AS lKdvTutari,dbo.ROUNDYTL(tbStokFisiDetayi.lBrutFiyat * tbStokFisiDetayi.lBirimMiktar) AS lFiyat,CAST(dbo.ROUNDYTL(tbStokFisiDetayi.lBrutFiyat*tbStokFisiDetayi.lBirimMiktar) * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS FLOAT) AS lDahilFiyat,CAST(tbStokFisiDetayi.lBrutFiyat * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS FLOAT) AS lDahilBrutFiyat,CAST(tbStokFisiDetayi.lBrutTutar * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS FLOAT) AS lDahilBrutTutar,lDovizTutar = CASE WHEN sDovizCinsi1 <> '' AND lDovizKuru1 <> 0 THEN lBrutTutar / lDovizKuru1 ELSE lBrutTutar END, lDovizFiyati = CASE WHEN sDovizCinsi1 <> '' AND lDovizKuru1 <> 0 THEN dbo.ROUNDYTL((lBrutFiyat*lBirimMiktar)) / lDovizKuru1 ELSE dbo.ROUNDYTL(lBrutFiyat*lBirimMiktar) END,lDovizBrutFiyati = CASE WHEN sDovizCinsi1 <> '' AND lDovizKuru1 <> 0 THEN lBrutFiyat / lDovizKuru1 ELSE lBrutFiyat END, lDahilDovizTutar = CASE WHEN sDovizCinsi1 <> '' AND lDovizKuru1 <> 0 THEN (lBrutTutar / lDovizKuru1) * (100 + tbStokFisiDetayi.nKdvOrani) / 100 ELSE (lBrutTutar)* (100 + tbStokFisiDetayi.nKdvOrani) / 100  END, lDahilDovizFiyati = CASE WHEN sDovizCinsi1 <> '' AND lDovizKuru1 <> 0 THEN ((lBrutFiyat*lBirimMiktar) / lDovizKuru1)* (100 + tbStokFisiDetayi.nKdvOrani) / 100 ELSE ((lBrutFiyat*lBirimMiktar))* (100 + tbStokFisiDetayi.nKdvOrani) / 100 END,lDahilDovizBrutFiyati = CASE WHEN sDovizCinsi1 <> '' AND lDovizKuru1 <> 0 THEN (lBrutFiyat / lDovizKuru1)* (100 + tbStokFisiDetayi.nKdvOrani) / 100 ELSE (lBrutFiyat)* (100 + tbStokFisiDetayi.nKdvOrani) / 100 END FROM tbStokFisiDetayi INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID  WHERE     (tbStokFisiDetayi.nStokFisiID = '" & nStokFisiID & "') ORDER BY tbStokFisiDetayi.nEkSaha1,tbStokFisiDetayi.nIslemID"), "HAREKET")
                        End If
                        ds_toplam = sorgu(sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT nStokFisiID, lToplamMiktar, lMalBedeli, lMalIskontoTutari,CAST(0 AS money) AS nMalIskontoYuzdesi, nDipIskontoYuzdesi1, lDipIskontoTutari1, nDipIskontoYuzdesi2, lDipIskontoTutari2, lDipIskontoTutari3, CAST(0 AS money) AS nDipIskontoYuzdesi3, lDipIskontoTutari1+lDipIskontoTutari2+lDipIskontoTutari3 as lDipIskontoTutari,CAST(0 AS money) AS nDipIskontoYuzdesi,lEkmaliyet1, lEkmaliyet2, lEkmaliyet3,lEkmaliyet1+lEkmaliyet2+lEkmaliyet3 as lEkmaliyet,(SELECT ISNULL(SUM(lTutar) , 0) FROM tbStokFisiEkMaliyet WHERE nStokFisiID = tbStokFisiMaster.nStokFisiID and nIslemID =0) AS lEkMaliyet4,(SELECT ISNULL(SUM(lTutar) , 0) FROM tbStokFisiEkMaliyet WHERE nStokFisiID = tbStokFisiMaster.nStokFisiID and nIslemID > 0) AS lEkMaliyet5, CAST(0 AS money) AS nEkmaliyetYuzdesi, nKdvOrani1, lKdvMatrahi1, lKdv1, nKdvOrani2, lKdvMatrahi2, lKdv2, nKdvOrani3, lKdvMatrahi3, lKdv3, nKdvOrani4, lKdvMatrahi4, lKdv4, nKdvOrani5, lKdvMatrahi5, lKdv5, lNetTutar, nTevkifatKdvOrani, lTevkifatKdvMatrahi, lTevkifatKdv, sYaziIle, nOTVOrani1, lOTVMatrahi1, lOTV1, nOTVOrani2, lOTVMatrahi2, lOTV2, lKdv1 + lKdv2 + lKdv3 + lKdv4 + lKdv5 AS lKdv,(lMalBedeli) - (lMalIskontoTutari + lDipIskontoTutari1 + lDipIskontoTutari2 + lDipIskontoTutari3) AS lTutar FROM tbStokFisiMaster WHERE (nStokFisiID =  '" & nStokFisiID & "')"), "TOPLAM")
                        ds_DToplam = sorgu(sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT nStokFisiID, lToplamMiktar, lMalBedeli, lMalIskontoTutari,CAST(0 AS money) AS nMalIskontoYuzdesi, nDipIskontoYuzdesi1, lDipIskontoTutari1, nDipIskontoYuzdesi2, lDipIskontoTutari2, lDipIskontoTutari3, CAST(0 AS money) AS nDipIskontoYuzdesi3, lDipIskontoTutari1+lDipIskontoTutari2+lDipIskontoTutari3 as lDipIskontoTutari,CAST(0 AS money) AS nDipIskontoYuzdesi,lEkmaliyet1, lEkmaliyet2, lEkmaliyet3,lEkmaliyet1+lEkmaliyet2+lEkmaliyet3 as lEkmaliyet,CAST(0 AS money) AS nEkmaliyetYuzdesi, nKdvOrani1, lKdvMatrahi1, lKdv1, nKdvOrani2, lKdvMatrahi2, lKdv2, nKdvOrani3, lKdvMatrahi3, lKdv3, nKdvOrani4, lKdvMatrahi4, lKdv4, nKdvOrani5, lKdvMatrahi5, lKdv5, lNetTutar, nTevkifatKdvOrani, lTevkifatKdvMatrahi, lTevkifatKdv, sYaziIle, nOTVOrani1, lOTVMatrahi1, lOTV1, nOTVOrani2, lOTVMatrahi2, lOTV2, lKdv1 + lKdv2 + lKdv3 + lKdv4 + lKdv5 AS lKdv FROM tbStokFisiMaster WHERE (nStokFisiID =  '" & nStokFisiID & "')"), "DTOPLAM")
                        ds_iskonto = sorgu(sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT nStokFisiID, nDipIskontoYuzdesi1, lDipIskontoTutari1, nDipIskontoYuzdesi2, lDipIskontoTutari2, lDipIskontoTutari3,cast(0 as money) as nDipIskontoYuzdesi3 FROM tbStokFisiMaster WHERE nStokFisiID = '" & nStokFisiID & "' "), "ISKONTO")
                        ds_Kesinti = sorgu(sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT nStokFisiID, nKdvOrani1, lKdvMatrahi1, lKdv1, nKdvOrani2, lKdvMatrahi2, lKdv2, nKdvOrani3, lKdvMatrahi3, lKdv3, nKdvOrani4, lKdvMatrahi4, lKdv4, nKdvOrani5, lKdvMatrahi5, lKdv5, lKdv1 + lKdv2 + lKdv3 + lKdv4 + lKdv5 AS lKdv FROM tbStokFisiMaster WHERE (nStokFisiID =  '" & nStokFisiID & "')"))
                        ds_masraf = sorgu(sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT nStokFisiID, lEkmaliyet1, lEkmaliyet2, lEkmaliyet3 FROM tbStokFisiMaster  WHERE nStokFisiID = '" & nStokFisiID & "' "), "MASRAF")
                        report.RegisterData(ds_baslik)
                        report.RegisterData(ds_hareket)
                        report.RegisterData(ds_toplam)
                        report.RegisterData(ds_iskonto)
                        report.RegisterData(ds_Kesinti)
                        report.RegisterData(ds_masraf)
                        report.RegisterData(ds_tbParamGenel)
                        Dim ds_MHareket As DataSet
                        ds_MHareket = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbStok.sModel AS sStokKodu, tbStok.sAciklama AS sStokAciklama, tbStok.sBirimCinsi1, tbStokFisiDetayi.sDepo,tbStokFisiDetayi.sFiyatTipi,tbStokFisiDetayi.nKdvOrani, SUM(tbStokFisiDetayi.lGirisMiktar1) AS lGirisMiktar1, SUM(tbStokFisiDetayi.lCikisMiktar1) AS lCikisMiktar1, tbStokFisiDetayi.lGirisFiyat, SUM(tbStokFisiDetayi.lGirisTutar) AS lGirisTutar, tbStokFisiDetayi.lCikisFiyat, SUM(tbStokFisiDetayi.lCikisTutar) AS lCikisTutar, tbStokFisiDetayi.lBrutFiyat, SUM(tbStokFisiDetayi.lBrutTutar) AS lBrutTutar, CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 6, 5) AS MONEY) AS ISK1, CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 17, 5) AS MONEY) AS ISK2, CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 28, 5) AS MONEY) AS ISK3, CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 39, 5) AS MONEY) AS ISK4, CAST(0 AS MONEY) AS GERCEKFIYAT, CAST(0 AS MONEY) AS GERCEKTOPLAM, tbStokFisiDetayi.nIskontoYuzdesi, SUM(tbStokFisiDetayi.lIskontoTutari) AS lIskontoTutari, SUM(ISNULL(ABS(ROUND((tbStokFisiDetayi.lBrutTutar - tbStokFisiDetayi.lIskontoTutari) * (tbStokFisiDetayi.nKdvOrani / 100), 2)), 0)) AS lKdvTutari, CAST(tbStokFisiDetayi.lBrutFiyat * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS FLOAT) AS lDahilBrutFiyat, SUM(CAST(tbStokFisiDetayi.lBrutTutar * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS FLOAT)) AS lDahilBrutTutar FROM tbStokFisiDetayi INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID WHERE (tbStokFisiDetayi.nStokFisiID = '" & nStokFisiID & "') GROUP BY tbStok.sModel, tbStok.sAciklama, tbStok.sBirimCinsi1, tbStokFisiDetayi.sAciklama, tbStokFisiDetayi.nKdvOrani, tbStokFisiDetayi.nIskontoYuzdesi, tbStokFisiDetayi.lBrutFiyat, tbStokFisiDetayi.lGirisFiyat, tbStokFisiDetayi.lCikisFiyat, tbStokFisiDetayi.sDepo,tbStokFisiDetayi.sFiyatTipi "), "MHAREKET")
                        report.RegisterData(ds_MHareket)
                        report.SetParameterValue("dteFisTarihi", dr("dteFisTarihi"))
                        report.SetParameterValue("lFisNo", dr("lFisNo"))
                        'report.SetParameterValue("sFisTipi", dr("sFisTipi"))
                        report.SetParameterValue("sFisTipi", sec_sFisTipi.Text)
                        report.SetParameterValue("nGirisCikis", dr("nGirisCikis"))
                        report.ScriptLanguage = Language.Vb
                        If nIslem = 0 Then
                            report.Show()
                        ElseIf nIslem = 2 Then
                            report.Design()
                        ElseIf nIslem = 1 Then
                            report.PrintSettings.SavePrinterWithReport = True
                            report.Print()
                        ElseIf nIslem = 3 Then
                            report.PrintSettings.SavePrinterWithReport = True
                            report.PrintSettings.ShowDialog = False
                            report.Print()
                        End If
                        ds_baslik.Dispose()
                        ds_hareket.Dispose()
                        ds_toplam.Dispose()
                        ds_DToplam.Dispose()
                        ds_iskonto.Dispose()
                        ds_Kesinti.Dispose()
                        ds_masraf.Dispose()
                        ds_baslik = Nothing
                        ds_hareket = Nothing
                        ds_toplam = Nothing
                        ds_DToplam = Nothing
                        ds_iskonto = Nothing
                        ds_Kesinti = Nothing
                        ds_masraf = Nothing
                        ds_MHareket = Nothing
                        report.Dispose()
                        report = Nothing
                    Next
                End If
            End If
        End If
    End Sub
    Private Function cevirNull(ByVal deger As Object, Optional ByVal sayi As Boolean = False) As Object
        If IsDBNull(deger) Then
            If sayi = False Then
                deger = ""
            Else
                deger = 0
            End If
        End If
        Return deger
    End Function
    Private Sub report_create_stok(ByVal nStokFisiID As Int64, ByVal dosya As String, ByVal kriter As String, ByVal status As Integer)
        Dim stokno = 0
        Dim satir_line = "100"
        If IntPtr.Size = 4 Then
            '32 Bit
            Dim frx As New TfrxReportClass
            Dim qr_hareket As New TfrxADOQuery
            Dim qr_hareket_model As New TfrxADOQuery
            Dim qr_baslik As New TfrxADOQuery
            Dim qr_toplam As New TfrxADOQuery
            frx.Resources.LoadLanguageResourcesFromFile("C:\Program Files\FastReports\FastReport Studio\bin\turkish.frc")
            frx.LoadReportFromFile(dosya)
            frx.SetVariable("FIRMANO", "" & firmano & "")
            frx.SetVariable("DONEMNO", "" & donemno & "")
            frx.SetVariable("STOKNO", "" & stokno & "")
            frx.SetVariable("nSayfaSayisi", "" & nSayfaSayisi & "")
            frx.SetVariable("SATIRLINE", "'" & satir_line & "'")
            'frx.SetVariable("FISTIPI", "'BU BİR İADE FATUARASIDIR'")
            ds_baslik = sorgu_baslik(nStokFisiID)
            dr_baslik = ds_baslik.Tables(0).Rows(0)
            If dr_baslik("nGirisCikis") = 2 Or dr_baslik("nGirisCikis") = 4 Then
                'frx.SetVariable("IADE", "''*** BU BİR İADE FATURASIDIR ***''")
                frx.SetVariable("IADE", "'BU BİR İADE FATUARASIDIR'")
            Else
                frx.SetVariable("IADE", "")
            End If
            qr_baslik = frx.FindObject("qr_baslik")
            qr_baslik.Query = sorgu_txt_baslik
            sorgu_harekets(dr_baslik("nStokFisiID"), dr_baslik("sFiyatTipi"), dr_baslik("sFisTipi"), "")
            qr_hareket = frx.FindObject("qr_hareket")
            qr_hareket.Query = sorgu_txt_hareket
            Try
                qr_hareket_model = frx.FindObject("qr_hareket_model")
                qr_hareket_model.Query = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbStok.sModel AS sStokKodu, tbStok.sAciklama AS sStokAciklama,tbStok.sKisaAdi,tbStok.nHacim,tbStok.nAgirlik, tbStok.sBirimCinsi1, tbStokFisiDetayi.sDepo,tbStokFisiDetayi.sFiyatTipi,tbStokFisiDetayi.nKdvOrani, SUM(tbStokFisiDetayi.lGirisMiktar1) AS lGirisMiktar1, SUM(tbStokFisiDetayi.lCikisMiktar1) AS lCikisMiktar1, tbStokFisiDetayi.lGirisFiyat, SUM(tbStokFisiDetayi.lGirisTutar) AS lGirisTutar, tbStokFisiDetayi.lCikisFiyat, SUM(tbStokFisiDetayi.lCikisTutar) AS lCikisTutar, tbStokFisiDetayi.lBrutFiyat, SUM(tbStokFisiDetayi.lBrutTutar) AS lBrutTutar, CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 6, 5) AS MONEY) AS ISK1, CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 17, 5) AS MONEY) AS ISK2, CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 28, 5) AS MONEY) AS ISK3, CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 39, 5) AS MONEY) AS ISK4, CAST(0 AS MONEY) AS GERCEKFIYAT, CAST(0 AS MONEY) AS GERCEKTOPLAM, tbStokFisiDetayi.nIskontoYuzdesi, SUM(tbStokFisiDetayi.lIskontoTutari) AS lIskontoTutari, SUM(ISNULL(ABS(ROUND((tbStokFisiDetayi.lBrutTutar - tbStokFisiDetayi.lIskontoTutari) * (tbStokFisiDetayi.nKdvOrani / 100), 2)), 0)) AS lKdvTutari, CAST(tbStokFisiDetayi.lBrutFiyat * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS MONEY) AS lDahilBrutFiyat, SUM(CAST(tbStokFisiDetayi.lBrutTutar * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS MONEY)) AS lDahilBrutTutar FROM tbStokFisiDetayi INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID WHERE (tbStokFisiDetayi.nStokFisiID = '" & nStokFisiID & "') GROUP BY tbStok.sModel, tbStok.sAciklama, tbStok.sKisaAdi,tbStok.nHacim,tbStok.nAgirlik, tbStok.sBirimCinsi1, tbStokFisiDetayi.sAciklama, tbStokFisiDetayi.nKdvOrani, tbStokFisiDetayi.nIskontoYuzdesi, tbStokFisiDetayi.lBrutFiyat, tbStokFisiDetayi.lGirisFiyat, tbStokFisiDetayi.lCikisFiyat, tbStokFisiDetayi.sDepo,tbStokFisiDetayi.sFiyatTipi")
            Catch ex As Exception
            End Try
            sorgu_toplam(dr_baslik("nStokFisiID"))
            qr_toplam = frx.FindObject("qr_toplam")
            qr_toplam.Query = sorgu_txt_toplam
            Dim qr_connection As New TfrxADODatabase
            qr_connection.ConnectionString = connection.ToString
            qr_connection.LoginPrompt = False
            qr_connection.CommandTimeout = Nothing
            qr_connection.Connected = True
            qr_baslik.DataBase = qr_connection
            qr_hareket.DataBase = qr_connection
            Try
                qr_hareket_model.DataBase = qr_connection
            Catch ex As Exception
            End Try
            qr_toplam.DataBase = qr_connection
            'qr_pesinat = frx.FindObject("qr_pesinat")
            'qr_pesinat.Query = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbOdeme WHERE     (nAlisverisID = '" & nAlisVerisID & "') AND (nOdemeKodu = 1) ORDER BY nOdemeID ")
            'qr_taksit = frx.FindObject("qr_taksit")
            'qr_taksit.Query = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbTaksit WHERE     (nAlisverisID = '" & nAlisVerisID & "') ORDER BY nTaksitID ")
            frx.OldStyleProgress = True
            If status = 0 Then
                frx.PreviewOptions.ZoomMode = frxZoomMode.zm_PageWidth
                frx.DisableDialogs = True
                frx.OldStyleProgress = True
                frx.ShowReport()
            ElseIf status = 1 Then
                If cevirNull(dr_baslik("sYazdirma"), True) > 0 Then
                    If XtraMessageBox.Show(Sorgu_sDil("Belge Daha Önceden " & CInt(cevirNull(dr_baslik("sYazdirma"), True)) & " defa yazdırılmış...!" & vbCrLf & "Tekrar Yazdırmak İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = MsgBoxResult.Yes Then
                        frx.PrepareReport(True)
                        frx.PrintOptions.Collate = False
                        frx.PrintOptions.Copies = 1
                        frx.PrintReport()
                        'lOTV2_degistir(nStokFisiID)
                        'Dim dr2 As DataRow = ds_baslik.Tables(0).Rows(0)
                        'dr2.BeginEdit()
                        'dr_toplam("lOTV2") = dr_toplam("lOTV2") + 1
                        'dr2("lOTV2") = dr_baslik("lOTV2") + 1
                        'dr2.EndEdit()
                        'dr2 = Nothing
                    End If
                ElseIf cevirNull(dr_baslik("sYazdirma"), True) = 0 Then
                    frx.PrepareReport(True)
                    frx.PrintOptions.Collate = False
                    frx.PrintOptions.Copies = 1
                    frx.PrintReport()
                    'lOTV2_degistir(nStokFisiID)
                    'Dim dr2 As DataRow = ds_baslik.Tables(0).Rows(0)
                    'dr2.BeginEdit()
                    'dr_toplam("lOTV2") = dr_toplam("lOTV2") + 1
                    'dr2("lOTV2") = dr_baslik("lOTV2") + 1
                    'dr2.EndEdit()
                    'dr2 = Nothing
                End If
            ElseIf status = 2 Then
                frx.DesignReport()
            ElseIf status = 3 Then
            End If
            qr_connection = Nothing
        ElseIf IntPtr.Size = 8 Then
            '64 Bit
            Dim args(50) As String
            Dim processYol As String
            args(0) = "" & dosya & ""
            args(1) = "" & connection.ToString() & ""
            args(4) = "" & status.ToString() & ""
            args(5) = "6"
            args(6) = "FIRMANO"
            args(7) = "" & firmano.ToString() & ""
            args(8) = "DONEMNO"
            args(9) = "" & donemno.ToString() & ""
            args(10) = "STOKNO"
            args(11) = "" & stokno.ToString() & ""
            args(12) = "nSayfaSayisi"
            args(13) = "" & nSayfaSayisi.ToString() & ""
            args(14) = "SATIRLINE"
            args(15) = "'" & satir_line.ToString() & "'"
            ds_baslik = sorgu_baslik(nStokFisiID)
            dr_baslik = ds_baslik.Tables(0).Rows(0)
            If dr_baslik("nGirisCikis") = 2 Or dr_baslik("nGirisCikis") = 4 Then
                args(16) = "IADE"
                args(17) = "'BU BİR İADE FATUARASIDIR'"
            Else
                args(16) = "IADE"
                args(17) = ""
            End If
            sorgu_harekets(dr_baslik("nStokFisiID"), dr_baslik("sFiyatTipi"), dr_baslik("sFisTipi"), "")
            sorgu_toplam(dr_baslik("nStokFisiID"))
            args(2) = "" & sorgu_txt_baslik & "é" & sorgu_txt_hareket & "é" & sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbStok.sModel AS sStokKodu, tbStok.sAciklama AS sStokAciklama,tbStok.sKisaAdi,tbStok.nHacim,tbStok.nAgirlik, tbStok.sBirimCinsi1, tbStokFisiDetayi.sDepo,tbStokFisiDetayi.sFiyatTipi,tbStokFisiDetayi.nKdvOrani, SUM(tbStokFisiDetayi.lGirisMiktar1) AS lGirisMiktar1, SUM(tbStokFisiDetayi.lCikisMiktar1) AS lCikisMiktar1, tbStokFisiDetayi.lGirisFiyat, SUM(tbStokFisiDetayi.lGirisTutar) AS lGirisTutar, tbStokFisiDetayi.lCikisFiyat, SUM(tbStokFisiDetayi.lCikisTutar) AS lCikisTutar, tbStokFisiDetayi.lBrutFiyat, SUM(tbStokFisiDetayi.lBrutTutar) AS lBrutTutar, CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 6, 5) AS MONEY) AS ISK1, CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 17, 5) AS MONEY) AS ISK2, CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 28, 5) AS MONEY) AS ISK3, CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 39, 5) AS MONEY) AS ISK4, CAST(0 AS MONEY) AS GERCEKFIYAT, CAST(0 AS MONEY) AS GERCEKTOPLAM, tbStokFisiDetayi.nIskontoYuzdesi, SUM(tbStokFisiDetayi.lIskontoTutari) AS lIskontoTutari, SUM(ISNULL(ABS(ROUND((tbStokFisiDetayi.lBrutTutar - tbStokFisiDetayi.lIskontoTutari) * (tbStokFisiDetayi.nKdvOrani / 100), 2)), 0)) AS lKdvTutari, CAST(tbStokFisiDetayi.lBrutFiyat * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS MONEY) AS lDahilBrutFiyat, SUM(CAST(tbStokFisiDetayi.lBrutTutar * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS MONEY)) AS lDahilBrutTutar FROM tbStokFisiDetayi INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID WHERE (tbStokFisiDetayi.nStokFisiID = '" & nStokFisiID & "') GROUP BY tbStok.sModel, tbStok.sAciklama, tbStok.sKisaAdi,tbStok.nHacim,tbStok.nAgirlik, tbStok.sBirimCinsi1, tbStokFisiDetayi.sAciklama, tbStokFisiDetayi.nKdvOrani, tbStokFisiDetayi.nIskontoYuzdesi, tbStokFisiDetayi.lBrutFiyat, tbStokFisiDetayi.lGirisFiyat, tbStokFisiDetayi.lCikisFiyat, tbStokFisiDetayi.sDepo,tbStokFisiDetayi.sFiyatTipi") & "é" & sorgu_txt_toplam & ""
            args(3) = "qr_baslikéqr_hareketéqr_hareket_modeléqr_toplam"
            processYol = args(0)
            For i As Integer = 1 To 17
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
                If status = 1 Then
                    If cevirNull(dr_baslik("sYazdirma"), True) > 0 Then
                        If XtraMessageBox.Show(Sorgu_sDil("Belge Daha Önceden " & CInt(cevirNull(dr_baslik("sYazdirma"), True)) & " defa yazdırılmış...!" & vbCrLf & "Tekrar Yazdırmak İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = MsgBoxResult.Yes Then
                            Process.Start(sInfo)
                        End If
                    ElseIf cevirNull(dr_baslik("sYazdirma"), True) = 0 Then
                        Process.Start(sInfo)
                    End If
                End If
            Else
                MessageBox.Show("Lütfen 'RaporServis.exe' eklentisini uygulama dizinine kopyalayın.")
            End If
        End If
        stokno = Nothing
        satir_line = Nothing
        'qr_hareket = Nothing
    End Sub
    Private Function sorgu_baslik(ByVal nStokFisiID As String) As DataSet
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        Dim adapter As New OleDb.OleDbDataAdapter
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        adapter.SelectCommand = cmd
        If Trim(sFisTipi) = "PF" Then
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbStokFisiMaster.*, DATEDIFF(day, tbStokFisiMaster.dteFisTarihi, tbStokFisiMaster.dteValorTarihi) AS nOpsiyon,tbStokFisiAciklamasi.sAciklama1, tbStokFisiAciklamasi.sAciklama2, tbStokFisiAciklamasi.sAciklama3, tbStokFisiAciklamasi.sAciklama4, tbStokFisiAciklamasi.sAciklama5, tbStokFisiAciklamasi.sAciklama6, tbStokFisiAciklamasi.sAciklama7, tbStokFisiAciklamasi.sAciklama8,tbStokFisiAciklamasi.sAciklama9, tbStokFisiAciklamasi.sAciklama10, (SELECT nGCT FROM tbFisTipi WHERE sFisTipi = tbStokFisiMaster.sFisTipi) AS nGCT, tbMusteri.nMusteriID, tbMusteri.lKodu as sKodu, tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi as sAciklama,tbMusteri.sAdi, tbMusteri.sSoyadi, tbMusteri.nIskontoPesin, tbMusteri.nIskontoKredili, tbMusteri.sUnvan, tbMusteri.sVergiDairesi, tbMusteri.sVergiNo, tbMusteri.bYazismaEvAdresinemi, tbMusteri.sEmail, tbMusteri.sIsYeriAdi, tbMusteri.sIsAdresi1, tbMusteri.sIsAdresi2, tbMusteri.sIsSemt, tbMusteri.sIsIl, tbMusteri.sIsPostaKodu, tbMusteri.sIsTelefonu, tbMusteri.sEvAdresi1 as sAdres1, tbMusteri.sEvAdresi2 as sAdres2, tbMusteri.sEvSemt as sSemt, tbMusteri.sEvPostaKodu as sPostaKodu, tbMusteri.sEvIl as sIl, tbMusteri.sEvTelefonu, tbMusteri.sSigortaNo, tbMusteri.bEvlimi, tbMusteri.dteEvlilikTarihi, tbMusteri.dteDogumTarihi, tbMusteri.sDogumYeri, tbMusteri.sEhliyetNo, tbMusteri.sKanGrubu, tbMusteri.sHitap, tbMusteri.sAciklama1 AS sMusteriAciklama1, tbMusteri.sAciklama2 AS sMusteriAciklama2, tbMusteri.sAciklama3 AS sMusteriAciklama3, tbMusteri.sAciklama4 AS sMusteriAciklama4, tbMusteri.sAciklama5 AS sMusteriAciklama5, tbMusteri.sAciklama6 AS sMusteriAciklama6, tbMusteri.sAciklama7 AS sMusteriAciklama7, tbMusteri.sAciklama8 AS sMusteriAciklama8, tbMusteri.sAciklama9 AS sMusteriAciklama9, tbMusteri.sAciklama10 AS sMusteriAciklama10, tbMusteri.sGSM, tbMusteri.sFax, 0 as lBakiye,(SELECT sSinifKodu1 FROM tbMusteriSinifi WHERE nMusteriID = tbMusteri.nMusteriID) AS sSinifKodu1 FROM tbStokFisiMaster INNER JOIN tbStokFisiAciklamasi ON tbStokFisiMaster.nStokFisiID = tbStokFisiAciklamasi.nStokFisiID INNER JOIN tbMusteri ON tbStokFisiMaster.lFisNo = tbMusteri.lKodu WHERE (tbStokFisiMaster.nStokFisiID = '" & nStokFisiID & "')")
        Else
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbStokFisiMaster.*, IADEMI = CASE WHEN tbStokFisiMaster.nGirisCikis = 2 OR tbStokFisiMaster.nGirisCikis =4  THEN 'BU BİR İADE FATURASIDIR' ELSE '' END,DATEDIFF(day, tbStokFisiMaster.dteFisTarihi, tbStokFisiMaster.dteValorTarihi) AS nOpsiyon,tbFirma.sKodu, tbFirma.sAciklama, tbFirma.nOzelIskontosu,tbFirma.nOzelIskontosu2,tbFirma.nOzelIskontosu3,tbFirma.nOzelIskontosu4,tbFirma.sSaticiRumuzu, (SELECT     nPrim FROM          tbSatici  WHERE      sSaticiRumuzu = tbFirma.sSaticiRumuzu) AS nPrim,tbFirma.lKrediLimiti, tbFirma.dteMutabakatTarihi, tbFirma.nVadeGun, tbFirma.sHitap, tbFirma.sAdres1, tbFirma.sAdres2, tbFirma.sSemt, tbFirma.sIl, tbFirma.sUlke, tbFirma.sPostaKodu, tbFirma.sVergiDairesi, tbFirma.sVergiNo, tbFirma.sFiyatTipi, tbStokFisiAciklamasi.sAciklama1, tbStokFisiAciklamasi.sAciklama2, tbStokFisiAciklamasi.sAciklama3, tbStokFisiAciklamasi.sAciklama4, tbStokFisiAciklamasi.sAciklama5, tbStokFisiAciklamasi.sAciklama6, tbStokFisiAciklamasi.sAciklama7, tbStokFisiAciklamasi.sAciklama8, tbStokFisiAciklamasi.sAciklama9, tbStokFisiAciklamasi.sAciklama10, (Select nGCT from tbFisTipi Where sFisTipi = tbStokFisiMaster.sFisTipi) as nGCT,(Select ISNULL(SUM(lBorcTutar-lAlacakTutar),0) as lBakiye from tbFirmaHareketi where nFirmaID = tbFirma.nFirmaID and dteIslemTarihi <= tbStokFisiMaster.dteFisTarihi AND (nHareketID <   (SELECT     nCariHareketID FROM          tbStokFisiOdemePlani WHERE      nStokFisiID = tbStokFisiMaster.nStokFisiID))) as lEskiBakiye,(Select ISNULL(SUM(lBorcTutar-lAlacakTutar),0) as lBakiye from tbFirmaHareketi where nFirmaID = tbFirma.nFirmaID) as lBakiye,(SELECT     TOP 1 sIletisimAdresi FROM          tbFirmaIletisimi WHERE      nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'E-Mail') AS [E-Mail],(SELECT     TOP 1 sIletisimAdresi FROM          tbFirmaIletisimi WHERE      nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Fax') AS [Fax],(SELECT     TOP 1 sIletisimAdresi FROM          tbFirmaIletisimi WHERE      nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Gsm') AS [Gsm],(SELECT     TOP 1 sIletisimAdresi FROM          tbFirmaIletisimi WHERE      nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Telefon') AS [Telefon],(SELECT     TOP 1 sIletisimAdresi FROM          tbFirmaIletisimi WHERE      nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Web') AS [Web],(SELECT     TOP 1 sIletisimAdresi FROM          tbFirmaIletisimi WHERE      nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Yetkili') AS [Yetkili],(SELECT sSinifKodu1 FROM tbFirmaSinifi WHERE nFirmaID = tbFirma.nFirmaID) AS sSinifKodu1,ISNULL(tbDoviz.sDovizCinsi1,'') as sDovizCinsi1,ISNULL(tbDoviz.lDovizKuru1,0) as lDovizKuru1  FROM tbStokFisiMaster INNER JOIN tbFirma ON tbStokFisiMaster.nFirmaID = tbFirma.nFirmaID INNER JOIN tbStokFisiAciklamasi ON tbStokFisiMaster.nStokFisiID = tbStokFisiAciklamasi.nStokFisiID LEFT OUTER JOIN (SELECT     TOP 1 nStokFisiID, ISNULL(sDovizCinsi1,'') sDovizCinsi1, lDovizKuru1 FROM          tbStokFisiDetayi WHERE (nStokFisiID = '" & nStokFisiID & "') GROUP BY nStokFisiID, sDovizCinsi1, lDovizKuru1 ORDER BY sDovizCinsi1 DESC) tbDoviz ON tbStokFisiMaster.nStokFisiID = tbDoviz.nStokFisiID WHERE (tbStokFisiMaster.nStokFisiID = '" & nStokFisiID & "')")
        End If
        sorgu_txt_baslik = cmd.CommandText
        cmd.Connection = con
        con.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, "BASLIK")
        con.Close()
        con.Dispose()
        cmd.Dispose()
        con = Nothing
        cmd = Nothing
        Return DS
    End Function
    Private Function sorgu_harekets(ByVal nStokFisiID As Int64, ByVal sFiyatTipi As String, ByVal sFisTipi As String, ByVal kriter As String) As DataSet
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        Dim adapter As New OleDb.OleDbDataAdapter
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        adapter.SelectCommand = cmd
        If Trim(sFisTipi) = "PF" Then
            If s_nIslemID <> "" Then
                cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbStokFisiDetayi.*, tbSatici.sAdi + ' ' + tbSatici.sSoyadi AS sSatici,(SELECT ISNULL(SUM(lTutar) , 0) FROM tbStokFisiEkMaliyet WHERE nStokFisiID = tbStokFisiDetayi.nStokFisiID AND nIslemID = tbStokFisiDetayi.nIslemID) AS lEkIlaveMaliyetTutar,tbStok.sKodu AS sStokKodu, tbStok.sAciklama AS sStokAciklama,tbStok.sKisaAdi,tbStok.nHacim,tbStok.nAgirlik,tbStok.sBirimCinsi1,tbStok.sBirimCinsi2,ISNULL((SELECT     ISNULL(lOran, 0) FROM         tbStokBirimCevrimi WHERE     nStokID = tbStok.nStokID AND sBirimCinsi = tbStok.sBirimCinsi2), 1) AS nBirimCarpan,tbStok.sKisaAdi, tbStok.sOzelNot,(lCikisMiktar1 / ISNULL((SELECT     ISNULL(lOran, 0) FROM         tbStokBirimCevrimi WHERE     nStokID = tbStok.nStokID AND sBirimCinsi = tbStok.sBirimCinsi2), 1) ) as lCikisBirimMiktar , (lGirisMiktar1 / ISNULL((SELECT     ISNULL(lOran, 0) FROM         tbStokBirimCevrimi WHERE     nStokID = tbStok.nStokID AND sBirimCinsi = tbStok.sBirimCinsi2), 1) ) as lGirisBirimMiktar,(tbStokFisiDetayi.lGirisMiktar1 / tbStokFisiDetayi.lBirimMiktar) AS lGirisMiktar,(tbStokFisiDetayi.lCikisMiktar1 / tbStokFisiDetayi.lBirimMiktar) AS lCikisMiktar,tbStok.sModel,tbStok.sRenk,tbStok.sBeden, tbStok.sKavala,tbStok.nFiyatlandirma,tbStok.nStokTipi,(Select sRenkAdi from tbRenk where sRenk = tbStok.sRenk) as sRenkAdi,(SELECT sSinifKodu1 FROM tbStokSinifi WHERE nStokID = tbStok.nStokID) AS sSinifKodu1,(SELECT TOP 1 ISNULL(sBarkod , '') AS sBarkod FROM tbStokBarkodu WHERE nStokID = tbStok.nStokID and nKisim = 0) AS sBarkod,(SELECT     nKdvOrani FROM          tbKdv WHERE      sKdvTipi = tbStok.sKdvTipi) AS nStokKdvOrani, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'),0) AS lFiyat1,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'),0) AS lFiyat2,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'),0) AS lFiyat3,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat4 & "'),0) AS lFiyat4,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatTipi & "'),0) AS lOzelFiyat,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatM & "'),0) AS lMaliyet,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sAltFiyatTipi & "'),0) AS lAltFiyat,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatA & "'),0) AS lAlis,CAST(0 AS MONEY) AS ISK1, CAST(0 AS MONEY) AS ISK2, CAST(0 AS MONEY) AS ISK3, CAST(0 AS MONEY) AS ISK4, CAST(0 AS MONEY) AS ISK5,CAST(0 AS MONEY) AS ISK6,CAST(0 AS MONEY) AS ISK7,CAST(0 AS MONEY) AS ISK8,CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 66, 9) AS MONEY) AS nMasrafSatiri,CAST(0 AS MONEY) AS GERCEKFIYAT, CAST(0 AS MONEY) AS GERCEKTOPLAM, ISNULL(ABS(ROUND((tbStokFisiDetayi.lBrutTutar - tbStokFisiDetayi.lIskontoTutari) * (tbStokFisiDetayi.nKdvOrani / 100), 2)), 0) AS lKdvTutari,(tbStokFisiDetayi.lBrutFiyat * tbStokFisiDetayi.lBirimMiktar) AS lFiyat,CAST((tbStokFisiDetayi.lBrutFiyat*tbStokFisiDetayi.lBirimMiktar) * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS MONEY) AS lDahilFiyat,lDovizTutar = CASE WHEN sDovizCinsi1 <> '' AND lDovizKuru1 <> 0 THEN lBrutTutar / lDovizKuru1 ELSE lBrutTutar END, lDovizFiyat = CASE WHEN sDovizCinsi1 <> '' AND lDovizKuru1 <> 0 THEN lBrutFiyat / lDovizKuru1 ELSE lBrutFiyat END,CASE WHEN tbStokFisiDetayi.nGirisCikis = 1 OR nGirisCikis = 2 THEN tbStokFisiDetayi.lGirisFiyat * (100 + tbStokFisiDetayi.nKdvOrani) / 100 ELSE tbStokFisiDetayi.lCikisFiyat * (100 + tbStokFisiDetayi.nKdvOrani) / 100 END AS lNetFiyat FROM tbStokFisiDetayi INNER JOIN tbSatici ON tbStokFisiDetayi.sSaticiRumuzu = tbSatici.sSaticiRumuzu INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID  WHERE     (tbStokFisiDetayi.nStokFisiID = '" & nStokFisiID & "') " & s_nIslemID & " ORDER BY tbStokFisiDetayi.nEkSaha1,tbStokFisiDetayi.nIslemID")
            Else
                cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbStokFisiDetayi.*, tbSatici.sAdi + ' ' + tbSatici.sSoyadi AS sSatici,(SELECT ISNULL(SUM(lTutar) , 0) FROM tbStokFisiEkMaliyet WHERE nStokFisiID = tbStokFisiDetayi.nStokFisiID AND nIslemID = tbStokFisiDetayi.nIslemID) AS lEkIlaveMaliyetTutar,tbStok.sKodu AS sStokKodu, tbStok.sAciklama AS sStokAciklama,tbStok.sKisaAdi,tbStok.nHacim,tbStok.nAgirlik,tbStok.sBirimCinsi1,tbStok.sBirimCinsi2,ISNULL((SELECT     ISNULL(lOran, 0) FROM         tbStokBirimCevrimi WHERE     nStokID = tbStok.nStokID AND sBirimCinsi = tbStok.sBirimCinsi2), 1) AS nBirimCarpan,tbStok.sKisaAdi, tbStok.sOzelNot,(lCikisMiktar1 / ISNULL((SELECT     ISNULL(lOran, 0) FROM         tbStokBirimCevrimi WHERE     nStokID = tbStok.nStokID AND sBirimCinsi = tbStok.sBirimCinsi2), 1) ) as lCikisBirimMiktar , (lGirisMiktar1 / ISNULL((SELECT     ISNULL(lOran, 0) FROM         tbStokBirimCevrimi WHERE     nStokID = tbStok.nStokID AND sBirimCinsi = tbStok.sBirimCinsi2), 1) ) as lGirisBirimMiktar,(tbStokFisiDetayi.lGirisMiktar1 / tbStokFisiDetayi.lBirimMiktar) AS lGirisMiktar,(tbStokFisiDetayi.lCikisMiktar1 / tbStokFisiDetayi.lBirimMiktar) AS lCikisMiktar,tbStok.sModel,tbStok.sRenk,tbStok.sBeden, tbStok.sKavala,tbStok.nFiyatlandirma,tbStok.nStokTipi,(Select sRenkAdi from tbRenk where sRenk = tbStok.sRenk) as sRenkAdi,(SELECT sSinifKodu1 FROM tbStokSinifi WHERE nStokID = tbStok.nStokID) AS sSinifKodu1,(SELECT TOP 1 ISNULL(sBarkod , '') AS sBarkod FROM tbStokBarkodu WHERE nStokID = tbStok.nStokID and nKisim = 0) AS sBarkod,(SELECT     nKdvOrani FROM          tbKdv WHERE      sKdvTipi = tbStok.sKdvTipi) AS nStokKdvOrani, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'),0) AS lFiyat1,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'),0) AS lFiyat2,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'),0) AS lFiyat3,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat4 & "'),0) AS lFiyat4,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatTipi & "'),0) AS lOzelFiyat,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatM & "'),0) AS lMaliyet,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sAltFiyatTipi & "'),0) AS lAltFiyat,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatA & "'),0) AS lAlis,CAST(0 AS MONEY) AS ISK1, CAST(0 AS MONEY) AS ISK2, CAST(0 AS MONEY) AS ISK3, CAST(0 AS MONEY) AS ISK4,CAST(0 AS MONEY) AS ISK5,CAST(0 AS MONEY) AS ISK6,CAST(0 AS MONEY) AS ISK7,CAST(0 AS MONEY) AS ISK8, CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 66, 9) AS MONEY) AS nMasrafSatiri,CAST(0 AS MONEY) AS GERCEKFIYAT, CAST(0 AS MONEY) AS GERCEKTOPLAM, ISNULL(ABS(ROUND((tbStokFisiDetayi.lBrutTutar - tbStokFisiDetayi.lIskontoTutari) * (tbStokFisiDetayi.nKdvOrani / 100), 2)), 0) AS lKdvTutari,(tbStokFisiDetayi.lBrutFiyat * tbStokFisiDetayi.lBirimMiktar) AS lFiyat,CAST((tbStokFisiDetayi.lBrutFiyat*tbStokFisiDetayi.lBirimMiktar) * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS MONEY) AS lDahilFiyat,lDovizTutar = CASE WHEN sDovizCinsi1 <> '' AND lDovizKuru1 <> 0 THEN lBrutTutar / lDovizKuru1 ELSE lBrutTutar END, lDovizFiyat = CASE WHEN sDovizCinsi1 <> '' AND lDovizKuru1 <> 0 THEN lBrutFiyat / lDovizKuru1 ELSE lBrutFiyat END,CASE WHEN tbStokFisiDetayi.nGirisCikis = 1 OR nGirisCikis = 2 THEN tbStokFisiDetayi.lGirisFiyat * (100 + tbStokFisiDetayi.nKdvOrani) / 100 ELSE tbStokFisiDetayi.lCikisFiyat * (100 + tbStokFisiDetayi.nKdvOrani) / 100 END AS lNetFiyat FROM tbStokFisiDetayi INNER JOIN tbSatici ON tbStokFisiDetayi.sSaticiRumuzu = tbSatici.sSaticiRumuzu INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID  WHERE     (tbStokFisiDetayi.nStokFisiID = '" & nStokFisiID & "') ORDER BY tbStokFisiDetayi.nEkSaha1,tbStokFisiDetayi.nIslemID")
            End If
        ElseIf Trim(sFisTipi) = "IS" Or Trim(sFisTipi) = "IA" Then
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbStokFisiDetayi.*, tbSatici.sAdi + ' ' + tbSatici.sSoyadi AS sSatici,(SELECT ISNULL(SUM(lTutar) , 0) FROM tbStokFisiEkMaliyet WHERE nStokFisiID = tbStokFisiDetayi.nStokFisiID AND nIslemID = tbStokFisiDetayi.nIslemID) AS lEkIlaveMaliyetTutar,tbStok.sKodu AS sStokKodu, tbStok.sAciklama AS sStokAciklama,tbStok.sKisaAdi,tbStok.nHacim,tbStok.nAgirlik,tbStok.sBirimCinsi1,tbStok.sBirimCinsi2,ISNULL((SELECT     ISNULL(lOran, 0) FROM         tbStokBirimCevrimi WHERE     nStokID = tbStok.nStokID AND sBirimCinsi = tbStok.sBirimCinsi2), 1) AS nBirimCarpan,tbStok.sKisaAdi, tbStok.sOzelNot,(lCikisMiktar1 / ISNULL((SELECT     ISNULL(lOran, 0) FROM         tbStokBirimCevrimi WHERE     nStokID = tbStok.nStokID AND sBirimCinsi = tbStok.sBirimCinsi2), 1) ) as lCikisBirimMiktar , (lGirisMiktar1 / ISNULL((SELECT     ISNULL(lOran, 0) FROM         tbStokBirimCevrimi WHERE     nStokID = tbStok.nStokID AND sBirimCinsi = tbStok.sBirimCinsi2), 1) ) as lGirisBirimMiktar,(tbStokFisiDetayi.lGirisMiktar1 / tbStokFisiDetayi.lBirimMiktar) AS lGirisMiktar,(tbStokFisiDetayi.lCikisMiktar1 / tbStokFisiDetayi.lBirimMiktar) AS lCikisMiktar,tbStok.sModel, tbStok.sRenk,tbStok.sBeden,tbStok.sKavala,tbStok.nFiyatlandirma,tbStok.nStokTipi,(Select sRenkAdi from tbRenk where sRenk = tbStok.sRenk) as sRenkAdi,(SELECT sSinifKodu1 FROM tbStokSinifi WHERE nStokID = tbStok.nStokID) AS sSinifKodu1,(SELECT TOP 1 ISNULL(sBarkod , '') AS sBarkod FROM tbStokBarkodu WHERE nStokID = tbStok.nStokID and nKisim = 0) AS sBarkod, (SELECT     nKdvOrani FROM          tbKdv WHERE      sKdvTipi = tbStok.sKdvTipi) AS nStokKdvOrani,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'),0) AS lFiyat1,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'),0) AS lFiyat2,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'),0) AS lFiyat3,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat4 & "'),0) AS lFiyat4,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatTipi & "'),0) AS lOzelFiyat,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatM & "'),0) AS lMaliyet,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sAltFiyatTipi & "'),0) AS lAltFiyat,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatA & "'),0) AS lAlis,CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 6, 5) AS MONEY) AS ISK1, CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 17, 5) AS MONEY) AS ISK2, CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 28, 5) AS MONEY) AS ISK3, CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 39, 5) AS MONEY) AS ISK4, CAST(0 AS MONEY) AS ISK5,CAST(0 AS MONEY) AS ISK6,CAST(0 AS MONEY) AS ISK7,CAST(0 AS MONEY) AS ISK8,CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 66, 9) AS MONEY) AS nMasrafSatiri,CAST(0 AS MONEY) AS GERCEKFIYAT, CAST(0 AS MONEY) AS GERCEKTOPLAM, ISNULL((ROUND((tbStokFisiDetayi.lBrutTutar - tbStokFisiDetayi.lIskontoTutari) * (tbStokFisiDetayi.nKdvOrani / 100), 2)), 0) AS lKdvTutari,(tbStokFisiDetayi.lBrutFiyat * tbStokFisiDetayi.lBirimMiktar) AS lFiyat,CAST((tbStokFisiDetayi.lBrutFiyat*tbStokFisiDetayi.lBirimMiktar) * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS MONEY) AS lDahilFiyat,CAST(tbStokFisiDetayi.lBrutFiyat * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS MONEY) AS lDahilBrutFiyat,CAST(tbStokFisiDetayi.lBrutTutar * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS MONEY) AS lDahilBrutTutar,lDovizTutar = CASE WHEN sDovizCinsi1 <> '' AND lDovizKuru1 <> 0 THEN lBrutTutar / lDovizKuru1 ELSE lBrutTutar END, lDovizFiyati = CASE WHEN sDovizCinsi1 <> '' AND lDovizKuru1 <> 0 THEN ((lBrutFiyat*lBirimMiktar)) / lDovizKuru1 ELSE (lBrutFiyat*lBirimMiktar) END,lDovizBrutFiyati = CASE WHEN sDovizCinsi1 <> '' AND lDovizKuru1 <> 0 THEN lBrutFiyat / lDovizKuru1 ELSE lBrutFiyat END, lDahilDovizTutar = CASE WHEN sDovizCinsi1 <> '' AND lDovizKuru1 <> 0 THEN (lBrutTutar / lDovizKuru1) * (100 + tbStokFisiDetayi.nKdvOrani) / 100 ELSE (lBrutTutar)* (100 + tbStokFisiDetayi.nKdvOrani) / 100  END, lDahilDovizFiyati = CASE WHEN sDovizCinsi1 <> '' AND lDovizKuru1 <> 0 THEN ((lBrutFiyat*lBirimMiktar) / lDovizKuru1)* (100 + tbStokFisiDetayi.nKdvOrani) / 100 ELSE ((lBrutFiyat*lBirimMiktar))* (100 + tbStokFisiDetayi.nKdvOrani) / 100 END,lDahilDovizBrutFiyati = CASE WHEN sDovizCinsi1 <> '' AND lDovizKuru1 <> 0 THEN (lBrutFiyat / lDovizKuru1)* (100 + tbStokFisiDetayi.nKdvOrani) / 100 ELSE (lBrutFiyat)* (100 + tbStokFisiDetayi.nKdvOrani) / 100 END,CASE WHEN tbStokFisiDetayi.nGirisCikis = 1 OR nGirisCikis = 2 THEN tbStokFisiDetayi.lGirisFiyat * (100 + tbStokFisiDetayi.nKdvOrani) / 100 ELSE tbStokFisiDetayi.lCikisFiyat * (100 + tbStokFisiDetayi.nKdvOrani) / 100 END AS lNetFiyat FROM tbStokFisiDetayi INNER JOIN tbSatici ON tbStokFisiDetayi.sSaticiRumuzu = tbSatici.sSaticiRumuzu INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID  WHERE     (tbStokFisiDetayi.nIrsaliyeFisiID = '" & nStokFisiID & "') ORDER BY tbStokFisiDetayi.nEkSaha1,tbStokFisiDetayi.nIslemID")
        Else
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbStokFisiDetayi.*, tbSatici.sAdi + ' ' + tbSatici.sSoyadi AS sSatici,(SELECT ISNULL(SUM(lTutar) , 0) FROM tbStokFisiEkMaliyet WHERE nStokFisiID = tbStokFisiDetayi.nStokFisiID AND nIslemID = tbStokFisiDetayi.nIslemID) AS lEkIlaveMaliyetTutar,tbStok.sKodu AS sStokKodu, tbStok.sAciklama AS sStokAciklama,tbStok.sKisaAdi,tbStok.nHacim,tbStok.nAgirlik,tbStok.sBirimCinsi1,tbStok.sBirimCinsi2,ISNULL((SELECT     ISNULL(lOran, 0) FROM         tbStokBirimCevrimi WHERE     nStokID = tbStok.nStokID AND sBirimCinsi = tbStok.sBirimCinsi2), 1) AS nBirimCarpan,tbStok.sKisaAdi, tbStok.sOzelNot,(lCikisMiktar1 / ISNULL((SELECT     ISNULL(lOran, 0) FROM         tbStokBirimCevrimi WHERE     nStokID = tbStok.nStokID AND sBirimCinsi = tbStok.sBirimCinsi2), 1) ) as lCikisBirimMiktar , (lGirisMiktar1 / ISNULL((SELECT     ISNULL(lOran, 0) FROM         tbStokBirimCevrimi WHERE     nStokID = tbStok.nStokID AND sBirimCinsi = tbStok.sBirimCinsi2), 1) ) as lGirisBirimMiktar,(tbStokFisiDetayi.lGirisMiktar1 / tbStokFisiDetayi.lBirimMiktar) AS lGirisMiktar,(tbStokFisiDetayi.lCikisMiktar1 / tbStokFisiDetayi.lBirimMiktar) AS lCikisMiktar,tbStok.sModel, tbStok.sRenk,tbStok.sBeden,tbStok.sKavala,tbStok.nFiyatlandirma,tbStok.nStokTipi,(Select sRenkAdi from tbRenk where sRenk = tbStok.sRenk) as sRenkAdi,(SELECT sSinifKodu1 FROM tbStokSinifi WHERE nStokID = tbStok.nStokID) AS sSinifKodu1,(SELECT TOP 1 ISNULL(sBarkod , '') AS sBarkod FROM tbStokBarkodu WHERE nStokID = tbStok.nStokID and nKisim = 0) AS sBarkod,(SELECT     nKdvOrani FROM          tbKdv WHERE      sKdvTipi = tbStok.sKdvTipi) AS nStokKdvOrani,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'),0) AS lFiyat1,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'),0) AS lFiyat2,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'),0) AS lFiyat3,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat4 & "'),0) AS lFiyat4,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatTipi & "'),0) AS lOzelFiyat,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatM & "'),0) AS lMaliyet,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sAltFiyatTipi & "'),0) AS lAltFiyat,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatA & "'),0) AS lAlis, CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 6, 5) AS MONEY) AS ISK1, CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 17, 5) AS MONEY) AS ISK2, CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 28, 5) AS MONEY) AS ISK3, CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 39, 5) AS MONEY) AS ISK4, CAST(0 AS MONEY) AS ISK5,CAST(0 AS MONEY) AS ISK6,CAST(0 AS MONEY) AS ISK7,CAST(0 AS MONEY) AS ISK8,CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 66, 9) AS MONEY) AS nMasrafSatiri,CAST(0 AS MONEY) AS GERCEKFIYAT, CAST(0 AS MONEY) AS GERCEKTOPLAM, ISNULL((ROUND((tbStokFisiDetayi.lBrutTutar - tbStokFisiDetayi.lIskontoTutari) * (tbStokFisiDetayi.nKdvOrani / 100), 2)), 0) AS lKdvTutari,(tbStokFisiDetayi.lBrutFiyat * tbStokFisiDetayi.lBirimMiktar) AS lFiyat,CAST((tbStokFisiDetayi.lBrutFiyat*tbStokFisiDetayi.lBirimMiktar) * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS MONEY) AS lDahilFiyat,CAST(tbStokFisiDetayi.lBrutFiyat * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS MONEY) AS lDahilBrutFiyat,CAST(tbStokFisiDetayi.lBrutTutar * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS MONEY) AS lDahilBrutTutar,lDovizTutar = CASE WHEN sDovizCinsi1 <> '' AND lDovizKuru1 <> 0 THEN lBrutTutar / lDovizKuru1 ELSE lBrutTutar END, lDovizFiyati = CASE WHEN sDovizCinsi1 <> '' AND lDovizKuru1 <> 0 THEN ((lBrutFiyat*lBirimMiktar)) / lDovizKuru1 ELSE (lBrutFiyat*lBirimMiktar) END,lDovizBrutFiyati = CASE WHEN sDovizCinsi1 <> '' AND lDovizKuru1 <> 0 THEN lBrutFiyat / lDovizKuru1 ELSE lBrutFiyat END, lDahilDovizTutar = CASE WHEN sDovizCinsi1 <> '' AND lDovizKuru1 <> 0 THEN (lBrutTutar / lDovizKuru1) * (100 + tbStokFisiDetayi.nKdvOrani) / 100 ELSE (lBrutTutar)* (100 + tbStokFisiDetayi.nKdvOrani) / 100  END, lDahilDovizFiyati = CASE WHEN sDovizCinsi1 <> '' AND lDovizKuru1 <> 0 THEN ((lBrutFiyat*lBirimMiktar) / lDovizKuru1)* (100 + tbStokFisiDetayi.nKdvOrani) / 100 ELSE ((lBrutFiyat*lBirimMiktar))* (100 + tbStokFisiDetayi.nKdvOrani) / 100 END,lDahilDovizBrutFiyati = CASE WHEN sDovizCinsi1 <> '' AND lDovizKuru1 <> 0 THEN (lBrutFiyat / lDovizKuru1)* (100 + tbStokFisiDetayi.nKdvOrani) / 100 ELSE (lBrutFiyat)* (100 + tbStokFisiDetayi.nKdvOrani) / 100 END,CASE WHEN tbStokFisiDetayi.nGirisCikis = 1 OR nGirisCikis = 2 THEN tbStokFisiDetayi.lGirisFiyat * (100 + tbStokFisiDetayi.nKdvOrani) / 100 ELSE tbStokFisiDetayi.lCikisFiyat * (100 + tbStokFisiDetayi.nKdvOrani) / 100 END AS lNetFiyat FROM tbStokFisiDetayi INNER JOIN tbSatici ON tbStokFisiDetayi.sSaticiRumuzu = tbSatici.sSaticiRumuzu INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID  WHERE     (tbStokFisiDetayi.nStokFisiID = '" & nStokFisiID & "') ORDER BY tbStokFisiDetayi.nEkSaha1,tbStokFisiDetayi.nIslemID")
        End If
        sorgu_txt_hareket = cmd.CommandText
        cmd.Connection = con
        con.Open()
        Dim DS As New DataSet
        Dim N As Integer
        Try
            N = adapter.Fill(DS, "HAREKET")
        Catch ex As Exception
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbStokFisiDetayi.*, tbSatici.sAdi + ' ' + tbSatici.sSoyadi AS sSatici,(SELECT ISNULL(SUM(lTutar) , 0) FROM tbStokFisiEkMaliyet WHERE nStokFisiID = tbStokFisiDetayi.nStokFisiID AND nIslemID = tbStokFisiDetayi.nIslemID) AS lEkIlaveMaliyetTutar,tbStok.sKodu AS sStokKodu, tbStok.sAciklama AS sStokAciklama,tbStok.sKisaAdi,tbStok.nHacim,tbStok.nAgirlik,tbStok.sBirimCinsi1,tbStok.sBirimCinsi2,ISNULL((SELECT     ISNULL(lOran, 0) FROM         tbStokBirimCevrimi WHERE     nStokID = tbStok.nStokID AND sBirimCinsi = tbStok.sBirimCinsi2), 1) AS nBirimCarpan,tbStok.sKisaAdi, tbStok.sOzelNot,(lCikisMiktar1 / ISNULL((SELECT     ISNULL(lOran, 0) FROM         tbStokBirimCevrimi WHERE     nStokID = tbStok.nStokID AND sBirimCinsi = tbStok.sBirimCinsi2), 1) ) as lCikisBirimMiktar , (lGirisMiktar1 / ISNULL((SELECT     ISNULL(lOran, 0) FROM         tbStokBirimCevrimi WHERE     nStokID = tbStok.nStokID AND sBirimCinsi = tbStok.sBirimCinsi2), 1) ) as lGirisBirimMiktar,(tbStokFisiDetayi.lGirisMiktar1 / tbStokFisiDetayi.lBirimMiktar) AS lGirisMiktar,(tbStokFisiDetayi.lCikisMiktar1 / tbStokFisiDetayi.lBirimMiktar) AS lCikisMiktar,tbStok.sModel, tbStok.sRenk,tbStok.sBeden,tbStok.sKavala,tbStok.nFiyatlandirma,tbStok.nStokTipi,(Select sRenkAdi from tbRenk where sRenk = tbStok.sRenk) as sRenkAdi,(SELECT sSinifKodu1 FROM tbStokSinifi WHERE nStokID = tbStok.nStokID) AS sSinifKodu1,(SELECT TOP 1 ISNULL(sBarkod , '') AS sBarkod FROM tbStokBarkodu WHERE nStokID = tbStok.nStokID and nKisim = 0) AS sBarkod,(SELECT     nKdvOrani FROM          tbKdv WHERE      sKdvTipi = tbStok.sKdvTipi) AS nStokKdvOrani,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'),0) AS lFiyat1,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'),0) AS lFiyat2,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'),0) AS lFiyat3,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat4 & "'),0) AS lFiyat4,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatTipi & "'),0) AS lOzelFiyat,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatM & "'),0) AS lMaliyet,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sAltFiyatTipi & "'),0) AS lAltFiyat,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatA & "'),0) AS lAlis, CAST(0 AS MONEY) AS ISK1, CAST(0 AS MONEY) AS ISK2, CAST(0 AS MONEY) AS ISK3, CAST(0 AS MONEY) AS ISK4, CAST(0 AS MONEY) AS ISK5,CAST(0 AS MONEY) AS ISK6,CAST(0 AS MONEY) AS ISK7,CAST(0 AS MONEY) AS ISK8,CAST(0 AS MONEY) AS nMasrafSatiri,CAST(0 AS MONEY) AS GERCEKFIYAT, CAST(0 AS MONEY) AS GERCEKTOPLAM, ISNULL((ROUND((tbStokFisiDetayi.lBrutTutar - tbStokFisiDetayi.lIskontoTutari) * (tbStokFisiDetayi.nKdvOrani / 100), 2)), 0) AS lKdvTutari,(tbStokFisiDetayi.lBrutFiyat * tbStokFisiDetayi.lBirimMiktar) AS lFiyat,CAST((tbStokFisiDetayi.lBrutFiyat*tbStokFisiDetayi.lBirimMiktar) * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS MONEY) AS lDahilFiyat,CAST(tbStokFisiDetayi.lBrutFiyat * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS MONEY) AS lDahilBrutFiyat,CAST(tbStokFisiDetayi.lBrutTutar * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS MONEY) AS lDahilBrutTutar,lDovizTutar = CASE WHEN sDovizCinsi1 <> '' AND lDovizKuru1 <> 0 THEN lBrutTutar / lDovizKuru1 ELSE lBrutTutar END, lDovizFiyati = CASE WHEN sDovizCinsi1 <> '' AND lDovizKuru1 <> 0 THEN ((lBrutFiyat*lBirimMiktar)) / lDovizKuru1 ELSE (lBrutFiyat*lBirimMiktar) END,lDovizBrutFiyati = CASE WHEN sDovizCinsi1 <> '' AND lDovizKuru1 <> 0 THEN lBrutFiyat / lDovizKuru1 ELSE lBrutFiyat END, lDahilDovizTutar = CASE WHEN sDovizCinsi1 <> '' AND lDovizKuru1 <> 0 THEN (lBrutTutar / lDovizKuru1) * (100 + tbStokFisiDetayi.nKdvOrani) / 100 ELSE (lBrutTutar)* (100 + tbStokFisiDetayi.nKdvOrani) / 100  END, lDahilDovizFiyati = CASE WHEN sDovizCinsi1 <> '' AND lDovizKuru1 <> 0 THEN ((lBrutFiyat*lBirimMiktar) / lDovizKuru1)* (100 + tbStokFisiDetayi.nKdvOrani) / 100 ELSE ((lBrutFiyat*lBirimMiktar))* (100 + tbStokFisiDetayi.nKdvOrani) / 100 END,lDahilDovizBrutFiyati = CASE WHEN sDovizCinsi1 <> '' AND lDovizKuru1 <> 0 THEN (lBrutFiyat / lDovizKuru1)* (100 + tbStokFisiDetayi.nKdvOrani) / 100 ELSE (lBrutFiyat)* (100 + tbStokFisiDetayi.nKdvOrani) / 100 END,CASE WHEN tbStokFisiDetayi.nGirisCikis = 1 OR nGirisCikis = 2 THEN tbStokFisiDetayi.lGirisFiyat * (100 + tbStokFisiDetayi.nKdvOrani) / 100 ELSE tbStokFisiDetayi.lCikisFiyat * (100 + tbStokFisiDetayi.nKdvOrani) / 100 END AS lNetFiyat FROM tbStokFisiDetayi INNER JOIN tbSatici ON tbStokFisiDetayi.sSaticiRumuzu = tbSatici.sSaticiRumuzu INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID  WHERE     (tbStokFisiDetayi.nStokFisiID = '" & nStokFisiID & "') ORDER BY tbStokFisiDetayi.nEkSaha1,tbStokFisiDetayi.nIslemID")
            sorgu_txt_hareket = cmd.CommandText
            N = adapter.Fill(DS, "HAREKET")
        End Try
        con.Close()
        cmd = Nothing
        con = Nothing
        Return DS
    End Function
    Private Function sorgu_toplam(ByVal nStokFisiID As String) As DataSet
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        Dim adapter As New OleDb.OleDbDataAdapter
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        adapter.SelectCommand = cmd
        'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT nStokFisiID, lToplamMiktar, lMalBedeli, lMalIskontoTutari,CAST(0 AS money) AS nMalIskontoYuzdesi, nDipIskontoYuzdesi1, lDipIskontoTutari1, nDipIskontoYuzdesi2, lDipIskontoTutari2, lDipIskontoTutari3, CAST(0 AS money) AS nDipIskontoYuzdesi3, lDipIskontoTutari1+lDipIskontoTutari2+lDipIskontoTutari3 as lDipIskontoTutari,CAST(0 AS money) AS nDipIskontoYuzdesi,lEkmaliyet1, lEkmaliyet2, lEkmaliyet3,lEkmaliyet1+lEkmaliyet2+lEkmaliyet3 as lEkmaliyet,CAST(0 AS money) AS nEkmaliyetYuzdesi, nKdvOrani1, lKdvMatrahi1, lKdv1, nKdvOrani2, lKdvMatrahi2, lKdv2, nKdvOrani3, lKdvMatrahi3, lKdv3, nKdvOrani4, lKdvMatrahi4, lKdv4, nKdvOrani5, lKdvMatrahi5, lKdv5, lNetTutar, nTevkifatKdvOrani, lTevkifatKdvMatrahi, lTevkifatKdv, sYaziIle, nOTVOrani1, lOTVMatrahi1, lOTV1, nOTVOrani2, lOTVMatrahi2, lOTV2, lKdv1 + lKdv2 + lKdv3 + lKdv4 + lKdv5 AS lKdv FROM tbStokFisiMaster WHERE (nStokFisiID =  '" & nStokFisiID & "')")
        'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT nStokFisiID, lToplamMiktar, lMalBedeli, lMalIskontoTutari,nMalIskontoYuzdesi = CASE WHEN lMalIskontoTutari = 0 OR lMalBedeli = 0 THEN CAST(0 AS MONEY) ELSE lMalIskontoTutari / lMalBedeli END, nDipIskontoYuzdesi1, lDipIskontoTutari1, nDipIskontoYuzdesi2, lDipIskontoTutari2, lDipIskontoTutari3, nDipIskontoYuzdesi3 = CASE WHEN lDipIskontoTutari3 = 0 THEN 0 ELSE lDipIskontoTutari3 / (lMalBedeli - lDipIskontoTutari1 - lDipIskontoTutari2)*100 END, lDipIskontoTutari1+lDipIskontoTutari2+lDipIskontoTutari3 as lDipIskontoTutari,CAST(0 AS money) AS nDipIskontoYuzdesi,lEkmaliyet1, lEkmaliyet2, lEkmaliyet3,lEkmaliyet1+lEkmaliyet2+lEkmaliyet3 as lEkmaliyet,(SELECT ISNULL(SUM(lTutar) , 0) FROM tbStokFisiEkMaliyet WHERE nStokFisiID = tbStokFisiMaster.nStokFisiID and nIslemID =0) AS lEkMaliyet4,(SELECT ISNULL(SUM(lTutar) , 0) FROM tbStokFisiEkMaliyet WHERE nStokFisiID = tbStokFisiMaster.nStokFisiID and nIslemID > 0) AS lEkMaliyet5, nEkmaliyetYuzdesi = CASE WHEN tbStokFisiMaster.lEkmaliyet1 + tbStokFisiMaster.lEkmaliyet2 + tbStokFisiMaster.lEkmaliyet3 = 0 OR tbStokFisiMaster.lMalBedeli = 0 THEN 0 ELSE (tbStokFisiMaster.lEkmaliyet1 + tbStokFisiMaster.lEkmaliyet2 + tbStokFisiMaster.lEkmaliyet3) / (tbStokFisiMaster.lMalBedeli - tbStokFisiMaster.lMalIskontoTutari - tbStokFisiMaster.lDipIskontoTutari1 - tbStokFisiMaster.lDipIskontoTutari2 - tbStokFisiMaster.lDipIskontoTutari3) END, nKdvOrani1, lKdvMatrahi1, lKdv1, nKdvOrani2, lKdvMatrahi2, lKdv2, nKdvOrani3, lKdvMatrahi3, lKdv3, nKdvOrani4, lKdvMatrahi4, lKdv4, nKdvOrani5, lKdvMatrahi5, lKdv5, lNetTutar, nTevkifatKdvOrani, lTevkifatKdvMatrahi, lTevkifatKdv, sYaziIle, nOTVOrani1, lOTVMatrahi1, lOTV1, nOTVOrani2, lOTVMatrahi2, lOTV2, (lKdv1 + lKdv2 + lKdv3 + lKdv4 + lKdv5)-(lTevkifatKdv) AS lKdv,(lMalBedeli) - (lMalIskontoTutari + lDipIskontoTutari1 + lDipIskontoTutari2 + lDipIskontoTutari3) AS lTutar FROM tbStokFisiMaster WHERE (nStokFisiID =  '" & nStokFisiID & "')")
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT nStokFisiID, lToplamMiktar, lMalBedeli, lMalIskontoTutari,nMalIskontoYuzdesi = CASE WHEN lMalIskontoTutari = 0 OR lMalBedeli = 0 THEN CAST(0 AS MONEY) ELSE lMalIskontoTutari / lMalBedeli END, nDipIskontoYuzdesi1, lDipIskontoTutari1, nDipIskontoYuzdesi2, lDipIskontoTutari2, lDipIskontoTutari3, nDipIskontoYuzdesi3 = CASE WHEN lDipIskontoTutari3 = 0 THEN 0 ELSE lDipIskontoTutari3 / (lMalBedeli - lDipIskontoTutari1 - lDipIskontoTutari2)*100 END, lDipIskontoTutari1+lDipIskontoTutari2+lDipIskontoTutari3 as lDipIskontoTutari,CAST(0 AS money) AS nDipIskontoYuzdesi,lEkmaliyet1, lEkmaliyet2, lEkmaliyet3,lEkmaliyet1+lEkmaliyet2+lEkmaliyet3 as lEkmaliyet,(SELECT ISNULL(SUM(lTutar) , 0) FROM tbStokFisiEkMaliyet WHERE nStokFisiID = tbStokFisiMaster.nStokFisiID and nIslemID =0) AS lEkMaliyet4,(SELECT ISNULL(SUM(lTutar) , 0) FROM tbStokFisiEkMaliyet WHERE nStokFisiID = tbStokFisiMaster.nStokFisiID and nIslemID > 0) AS lEkMaliyet5, nEkmaliyetYuzdesi = CASE WHEN tbStokFisiMaster.lEkmaliyet1 + tbStokFisiMaster.lEkmaliyet2 + tbStokFisiMaster.lEkmaliyet3 = 0 OR tbStokFisiMaster.lMalBedeli = 0 THEN 0 ELSE (tbStokFisiMaster.lEkmaliyet1 + tbStokFisiMaster.lEkmaliyet2 + tbStokFisiMaster.lEkmaliyet3) / (tbStokFisiMaster.lMalBedeli - tbStokFisiMaster.lMalIskontoTutari - tbStokFisiMaster.lDipIskontoTutari1 - tbStokFisiMaster.lDipIskontoTutari2 - tbStokFisiMaster.lDipIskontoTutari3) END,lEkMaliyet1Oran = CASE WHEN tbStokFisiMaster.lEkmaliyet1  = 0 OR tbStokFisiMaster.lMalBedeli = 0 THEN 0 ELSE (tbStokFisiMaster.lEkmaliyet1 ) / (tbStokFisiMaster.lMalBedeli - tbStokFisiMaster.lMalIskontoTutari - tbStokFisiMaster.lDipIskontoTutari1 - tbStokFisiMaster.lDipIskontoTutari2 - tbStokFisiMaster.lDipIskontoTutari3) * 100 END,lEkMaliyet2Oran = CASE WHEN tbStokFisiMaster.lEkmaliyet2 = 0 OR tbStokFisiMaster.lMalBedeli = 0 THEN 0 ELSE (tbStokFisiMaster.lEkmaliyet2 ) / (tbStokFisiMaster.lMalBedeli - tbStokFisiMaster.lMalIskontoTutari - tbStokFisiMaster.lDipIskontoTutari1 - tbStokFisiMaster.lDipIskontoTutari2 - tbStokFisiMaster.lDipIskontoTutari3) * 100 END,lEkMaliyet3Oran = CASE WHEN tbStokFisiMaster.lEkmaliyet3  = 0 OR tbStokFisiMaster.lMalBedeli = 0 THEN 0 ELSE (tbStokFisiMaster.lEkmaliyet3 ) / (tbStokFisiMaster.lMalBedeli - tbStokFisiMaster.lMalIskontoTutari - tbStokFisiMaster.lDipIskontoTutari1 - tbStokFisiMaster.lDipIskontoTutari2 - tbStokFisiMaster.lDipIskontoTutari3) * 100 END, nKdvOrani1, lKdvMatrahi1, lKdv1, nKdvOrani2, lKdvMatrahi2, lKdv2, nKdvOrani3, lKdvMatrahi3, lKdv3, nKdvOrani4, lKdvMatrahi4, lKdv4, nKdvOrani5, lKdvMatrahi5, lKdv5, lNetTutar, nTevkifatKdvOrani, lTevkifatKdvMatrahi, lTevkifatKdv, sYaziIle, nOTVOrani1, lOTVMatrahi1, lOTV1, nOTVOrani2, lOTVMatrahi2, lOTV2, (lOTV1 + lOTV2 ) lOTV,(lKdv1 + lKdv2 + lKdv3 + lKdv4 + lKdv5)-(lTevkifatKdv) AS lKdv,(lMalBedeli) - (lMalIskontoTutari + lDipIskontoTutari1 + lDipIskontoTutari2 + lDipIskontoTutari3) AS lTutar FROM tbStokFisiMaster WHERE (nStokFisiID =  '" & nStokFisiID & "')")
        sorgu_txt_toplam = cmd.CommandText
        cmd.Connection = con
        con.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, "TOPLAM")
        con.Close()
        con.Dispose()
        cmd.Dispose()
        con = Nothing
        cmd = Nothing
        Return DS
    End Function
    ' GIB'den fatura numaralarini sorgulayip DB'yi gunceller
    ' Esleme: 1.VKN/TCKN 2.Tarih 3.Tutar
    Private Sub GibFaturaNumaralariniGuncelle()
        Try
            Dim con As New OleDb.OleDbConnection()
            con.ConnectionString = connection

            Dim bEFaturaEntegre As Boolean = False
            Dim gibKullanici As String = ""
            Dim gibSifre As String = ""

            con.Open()
            Dim cmdParam As New OleDb.OleDbCommand("SELECT TOP 1 ISNULL(EFaturaEntegre, 0) AS EFaturaEntegre, ISNULL(GibKullanici, '') AS GibKullanici, ISNULL(GibSifre, '') AS GibSifre FROM tbParamGenel", con)
            Dim rdrParam As OleDb.OleDbDataReader = cmdParam.ExecuteReader()
            If rdrParam.Read() Then
                bEFaturaEntegre = CBool(rdrParam("EFaturaEntegre"))
                gibKullanici = rdrParam("GibKullanici").ToString().Trim()
                gibSifre = rdrParam("GibSifre").ToString().Trim()
            End If
            rdrParam.Close()
            con.Close()

            If bEFaturaEntegre = False OrElse gibKullanici = "" OrElse gibSifre = "" Then Exit Sub



            con.Open()
            Dim dsEksik As New DataSet()
            Dim adpEksik As New OleDb.OleDbDataAdapter(sorgu_query( _
                "SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED " & _
                "SELECT m.nStokFisiID, m.dteFisTarihi, ISNULL(m.lNetTutar, 0) AS lNetTutar, (ISNULL(m.lKdv1,0)+ISNULL(m.lKdv2,0)+ISNULL(m.lKdv3,0)+ISNULL(m.lKdv4,0)+ISNULL(m.lKdv5,0)) AS lKdvTutar, m.nFirmaID, m.sEfaturaGuid, " & _
                "ISNULL(RTRIM(f.sVergiNo), '') AS sVergiNo, " & _
                "ISNULL(RTRIM(f.sAciklama), '') AS sAciklama, " & _
                "ISNULL(f.TC, 0) AS TC " & _
                "FROM tbStokFisiMaster m " & _
                "INNER JOIN tbFirma f ON m.nFirmaID = f.nFirmaID " & _
                "WHERE (m.GibFaturaNo IS NULL OR m.GibFaturaNo = '' OR m.GibFaturaNo = '0') AND m.nFirmaID > 0"), con)
            adpEksik.Fill(dsEksik)
            con.Close()

            If dsEksik.Tables.Count = 0 OrElse dsEksik.Tables(0).Rows.Count = 0 Then
                MsgBox("Eksik fatura bulunamadi, isleme gerek yok.", MsgBoxStyle.Information, "Bilgi")
                Exit Sub
            End If

            ' Sadece son 2 ay kontrol edilsin
            Dim dtBitis As DateTime = DateTime.Now
            Dim dtBaslangic As DateTime = dtBitis.AddMonths(-2)

            Dim client As New GibSorgula.QueryDocumentWSClient()
            Dim prop As New System.ServiceModel.Channels.HttpRequestMessageProperty()
            prop.Headers.Add("Username", gibKullanici)
            prop.Headers.Add("Password", gibSifre)

            Dim tumBelgeler As New System.Collections.Generic.List(Of GibSorgula.ResponseDocument)

            ' API ayni hesap donemi (yil) icinde olmak zorunda, yil bazinda parcala
            Dim yilBaslangic As Integer = dtBaslangic.Year
            Dim yilBitis As Integer = dtBitis.Year

            For yil As Integer = yilBaslangic To yilBitis
                Dim donemBas As String = If(yil = yilBaslangic, dtBaslangic.ToString("yyyy-MM-dd"), yil & "-01-01")
                Dim donemSon As String = If(yil = yilBitis, dtBitis.ToString("yyyy-MM-dd"), yil & "-12-31")

                Dim minRecordId As String = "0"
                Dim devamEt As Boolean = True

                While devamEt
                    Using scope As New System.ServiceModel.OperationContextScope(CType(client.InnerChannel, System.ServiceModel.IClientChannel))
                        System.ServiceModel.OperationContext.Current.OutgoingMessageProperties(System.ServiceModel.Channels.HttpRequestMessageProperty.Name) = prop

                        Dim response As GibSorgula.DocumentQueryResponse = client.QueryOutboxDocumentsWithDocumentDate( _
                            startDate:=donemBas, _
                            endDate:=donemSon, _
                            documentType:="1", _
                            queried:="ALL", _
                            withXML:="NONE", _
                            minRecordId:=minRecordId)

                        If response IsNot Nothing AndAlso response.queryState <> 0 Then
                            MsgBox("GIB Sorgu Hatasi (" & yil & "): " & If(response.stateExplanation, "Bilinmeyen hata"), MsgBoxStyle.Exclamation, "GIB Uyari")
                            devamEt = False
                        ElseIf response IsNot Nothing AndAlso response.queryState = 0 AndAlso response.documents IsNot Nothing AndAlso response.documents.Length > 0 Then
                            For Each doc As GibSorgula.ResponseDocument In response.documents
                                tumBelgeler.Add(doc)
                            Next
                            If response.documentsCount > tumBelgeler.Count Then
                                minRecordId = response.maxRecordIdinList.ToString()
                            Else
                                devamEt = False
                            End If
                        Else
                            devamEt = False
                        End If
                    End Using
                End While
            Next

            client.Close()

            ' --- E-ARSIV SORGULAMA ---
            Dim eArsivClient As New EarsivServisi.EArchiveInvoiceWSClient()
            Dim eArsivProp As New System.ServiceModel.Channels.HttpRequestMessageProperty()
            eArsivProp.Headers.Add("Username", gibKullanici)
            eArsivProp.Headers.Add("Password", gibSifre)

            Dim tumEArsivBelgeler As New System.Collections.Generic.List(Of EarsivServisi.ResponseDocument)

            For yil As Integer = yilBaslangic To yilBitis
                Dim donemBas As String = If(yil = yilBaslangic, dtBaslangic.ToString("yyyy-MM-dd"), yil & "-01-01")
                Dim donemSon As String = If(yil = yilBitis, dtBitis.ToString("yyyy-MM-dd"), yil & "-12-31")

                Dim minRecId As String = "0"
                Dim devam As Boolean = True

                While devam
                    Using scope2 As New System.ServiceModel.OperationContextScope(CType(eArsivClient.InnerChannel, System.ServiceModel.IClientChannel))
                        System.ServiceModel.OperationContext.Current.OutgoingMessageProperties(System.ServiceModel.Channels.HttpRequestMessageProperty.Name) = eArsivProp

                        Dim eArsivResponse As EarsivServisi.DocumentQueryResponse = eArsivClient.QueryInvoicesWithDocumentDate( _
                            startDate:=donemBas, _
                            endDate:=donemSon, _
                            withXML:="NONE", _
                            minRecordId:=minRecId)

                        If eArsivResponse IsNot Nothing AndAlso eArsivResponse.queryState <> 0 Then
                            MsgBox("E-Arsiv Sorgu Hatasi (" & yil & "): " & If(eArsivResponse.stateExplanation, "Bilinmeyen hata"), MsgBoxStyle.Exclamation, "E-Arsiv Uyari")
                            devam = False
                        ElseIf eArsivResponse IsNot Nothing AndAlso eArsivResponse.queryState = 0 AndAlso eArsivResponse.documents IsNot Nothing AndAlso eArsivResponse.documents.Length > 0 Then
                            For Each eDoc As EarsivServisi.ResponseDocument In eArsivResponse.documents
                                tumEArsivBelgeler.Add(eDoc)
                            Next
                            If eArsivResponse.documentsCount > tumEArsivBelgeler.Count Then
                                minRecId = eArsivResponse.maxRecordIdinList.ToString()
                            Else
                                devam = False
                            End If
                        Else
                            devam = False
                        End If
                    End Using
                End While
            Next
            eArsivClient.Close()

            MsgBox("E-Fatura: " & tumBelgeler.Count & " belge" & vbCrLf & _
                   "E-Arsiv: " & tumEArsivBelgeler.Count & " belge" & vbCrLf & _
                   "Yerel eksik: " & dsEksik.Tables(0).Rows.Count & " fatura", MsgBoxStyle.Information, "Sorgu Sonucu")

            If tumBelgeler.Count = 0 AndAlso tumEArsivBelgeler.Count = 0 Then Exit Sub

            Dim eslesmeListesi As New System.Collections.Generic.List(Of String())
            Dim eslenenGibUuidler As New System.Collections.Generic.HashSet(Of String)
            Dim eslenenFaturaIdler As New System.Collections.Generic.HashSet(Of String)

            For Each doc As GibSorgula.ResponseDocument In tumBelgeler
                If doc.document_id Is Nothing OrElse doc.document_id.Trim() = "" Then Continue For
                Dim gibDestId As String = If(doc.destination_id IsNot Nothing, doc.destination_id.Trim(), "")
                Dim gibTarih As String = If(doc.document_issue_date IsNot Nothing, doc.document_issue_date.Trim(), "")
                Dim gibTutar As String = If(doc.invoice_total IsNot Nothing, doc.invoice_total.Trim(), "")
                Dim gibDocId As String = doc.document_id.Trim()
                Dim gibUuid As String = If(doc.document_uuid IsNot Nothing, doc.document_uuid.Trim(), "")
                Dim gibAd As String = If(doc.customerPersonName IsNot Nothing, doc.customerPersonName.Trim(), "")
                Dim gibSoyad As String = If(doc.customerPersonFamilyName IsNot Nothing, doc.customerPersonFamilyName.Trim(), "")
                Dim gibAdSoyad As String = (gibAd & " " & gibSoyad).Trim().ToUpper()

                If eslenenGibUuidler.Contains(gibUuid) Then Continue For

                Dim gibTutarDec As Decimal = 0
                If gibTutar <> "" Then
                    Decimal.TryParse(gibTutar.Replace(".", ","), gibTutarDec)
                    If gibTutarDec = 0 Then Decimal.TryParse(gibTutar, gibTutarDec)
                End If

                Dim gibTarihDt As DateTime = DateTime.MinValue
                If gibTarih <> "" Then DateTime.TryParse(gibTarih, gibTarihDt)

                Dim enIyiPuan As Integer = 0
                Dim enIyiFaturaID As String = ""

                For Each drLocal As DataRow In dsEksik.Tables(0).Rows
                    Dim localID As String = drLocal("nStokFisiID").ToString()
                    If eslenenFaturaIdler.Contains(localID) Then Continue For
                    Dim puan As Integer = 0

                    ' 1. VKN eslesmesi (sahte VKN'leri atla)
                    Dim localVkn As String = drLocal("sVergiNo").ToString().Trim()
                    Dim sahteVkn As Boolean = (gibDestId = "" OrElse gibDestId = "1111111111" OrElse gibDestId = "11111111111" OrElse gibDestId = "0")
                    If Not sahteVkn AndAlso localVkn <> "" AndAlso localVkn = gibDestId Then
                        puan += 100
                    End If

                    ' 2. TC eslesmesi (sahte TC'leri atla)
                    If puan < 100 Then
                        Dim localTC As String = drLocal("TC").ToString().Trim()
                        If Not sahteVkn AndAlso localTC <> "" AndAlso localTC <> "0" AndAlso localTC = gibDestId Then
                            puan += 100
                        End If
                    End If

                    ' 3. Isim eslesmesi
                    If gibAdSoyad <> "" Then
                        Dim localAd As String = drLocal("sAciklama").ToString().Trim().ToUpper()
                        If localAd <> "" AndAlso (localAd.Contains(gibAdSoyad) OrElse gibAdSoyad.Contains(localAd) OrElse _
                            (gibAd <> "" AndAlso gibSoyad <> "" AndAlso localAd.Contains(gibAd.ToUpper()) AndAlso localAd.Contains(gibSoyad.ToUpper()))) Then
                            puan += 80
                        End If
                    End If

                    ' 4. Tutar eslesmesi
                    If gibTutarDec > 0 Then
                        Dim localNet As Decimal = 0
                        If Not IsDBNull(drLocal("lNetTutar")) Then localNet = CDec(drLocal("lNetTutar"))
                        Dim localKdv As Decimal = 0
                        If Not IsDBNull(drLocal("lKdvTutar")) Then localKdv = CDec(drLocal("lKdvTutar"))
                        Dim localToplam As Decimal = localNet + localKdv
                        If Math.Abs(localToplam - gibTutarDec) < 1D Then puan += 50
                    End If

                    ' 5. Tarih eslesmesi
                    If gibTarihDt <> DateTime.MinValue Then
                        Dim localTarih As DateTime = DateTime.MinValue
                        Try : localTarih = CDate(drLocal("dteFisTarihi")) : Catch : End Try
                        If localTarih <> DateTime.MinValue AndAlso localTarih.Date = gibTarihDt.Date Then
                            puan += 40
                        End If
                    End If

                    ' Minimum esik: tutar+tarih(90), isim+tutar(130), VKN+tutar(150)
                    If puan > enIyiPuan AndAlso puan >= 90 Then
                        enIyiPuan = puan
                        enIyiFaturaID = localID
                    End If
                Next

                If enIyiFaturaID <> "" Then
                    Dim sProfile As String = If(doc.document_profile IsNot Nothing, doc.document_profile.Trim(), "")
                    Dim sDurum As String = If(doc.state_explanation IsNot Nothing, doc.state_explanation.Trim(), "")
                    Dim sDocType As String = If(doc.document_type_code IsNot Nothing, doc.document_type_code.Trim(), "")
                    Dim sRefUuid As String = If(doc.reference_document_uuid IsNot Nothing, doc.reference_document_uuid.Trim(), "")
                    eslesmeListesi.Add(New String() {enIyiFaturaID, gibDocId, gibUuid, sProfile, sDurum, sDocType, sRefUuid})
                    eslenenGibUuidler.Add(gibUuid)
                    eslenenFaturaIdler.Add(enIyiFaturaID)
                End If
            Next

            ' --- E-ARSIV ESLESTIRME ---
            For Each eDoc As EarsivServisi.ResponseDocument In tumEArsivBelgeler
                If eDoc.document_id Is Nothing OrElse eDoc.document_id.Trim() = "" Then Continue For
                Dim gibDestId As String = If(eDoc.destination_id IsNot Nothing, eDoc.destination_id.Trim(), "")
                Dim gibTarih As String = If(eDoc.document_issue_date IsNot Nothing, eDoc.document_issue_date.Trim(), "")
                Dim gibTutar As String = If(eDoc.invoice_total IsNot Nothing, eDoc.invoice_total.Trim(), "")
                Dim gibDocId As String = eDoc.document_id.Trim()
                Dim gibUuid As String = If(eDoc.document_uuid IsNot Nothing, eDoc.document_uuid.Trim(), "")
                Dim gibAd As String = If(eDoc.customerPersonName IsNot Nothing, eDoc.customerPersonName.Trim(), "")
                Dim gibSoyad As String = If(eDoc.customerPersonFamilyName IsNot Nothing, eDoc.customerPersonFamilyName.Trim(), "")
                Dim gibAdSoyad As String = (gibAd & " " & gibSoyad).Trim().ToUpper()

                If eslenenGibUuidler.Contains(gibUuid) Then Continue For

                Dim gibTutarDec As Decimal = 0
                If gibTutar <> "" Then
                    Decimal.TryParse(gibTutar.Replace(".", ","), gibTutarDec)
                    If gibTutarDec = 0 Then Decimal.TryParse(gibTutar, gibTutarDec)
                End If

                Dim gibTarihDt As DateTime = DateTime.MinValue
                If gibTarih <> "" Then DateTime.TryParse(gibTarih, gibTarihDt)

                Dim enIyiPuan As Integer = 0
                Dim enIyiFaturaID As String = ""

                For Each drLocal As DataRow In dsEksik.Tables(0).Rows
                    Dim localID As String = drLocal("nStokFisiID").ToString()
                    If eslenenFaturaIdler.Contains(localID) Then Continue For
                    Dim puan As Integer = 0

                    ' 1. VKN eslesmesi (sahte VKN'leri atla)
                    Dim localVkn As String = drLocal("sVergiNo").ToString().Trim()
                    Dim sahteVkn As Boolean = (gibDestId = "" OrElse gibDestId = "1111111111" OrElse gibDestId = "11111111111" OrElse gibDestId = "0")
                    If Not sahteVkn AndAlso localVkn <> "" AndAlso localVkn = gibDestId Then
                        puan += 100
                    End If

                    ' 2. TC eslesmesi (sahte TC'leri atla)
                    If puan < 100 Then
                        Dim localTC As String = drLocal("TC").ToString().Trim()
                        If Not sahteVkn AndAlso localTC <> "" AndAlso localTC <> "0" AndAlso localTC = gibDestId Then
                            puan += 100
                        End If
                    End If

                    ' 3. Isim eslesmesi
                    If gibAdSoyad <> "" Then
                        Dim localAd As String = drLocal("sAciklama").ToString().Trim().ToUpper()
                        If localAd <> "" AndAlso (localAd.Contains(gibAdSoyad) OrElse gibAdSoyad.Contains(localAd) OrElse _
                            (gibAd <> "" AndAlso gibSoyad <> "" AndAlso localAd.Contains(gibAd.ToUpper()) AndAlso localAd.Contains(gibSoyad.ToUpper()))) Then
                            puan += 80
                        End If
                    End If

                    ' 4. Tutar eslesmesi
                    If gibTutarDec > 0 Then
                        Dim localNet As Decimal = 0
                        If Not IsDBNull(drLocal("lNetTutar")) Then localNet = CDec(drLocal("lNetTutar"))
                        Dim localKdv As Decimal = 0
                        If Not IsDBNull(drLocal("lKdvTutar")) Then localKdv = CDec(drLocal("lKdvTutar"))
                        Dim localToplam As Decimal = localNet + localKdv
                        If Math.Abs(localToplam - gibTutarDec) < 1D Then puan += 50
                    End If

                    ' 5. Tarih eslesmesi
                    If gibTarihDt <> DateTime.MinValue Then
                        Dim localTarih As DateTime = DateTime.MinValue
                        Try : localTarih = CDate(drLocal("dteFisTarihi")) : Catch : End Try
                        If localTarih <> DateTime.MinValue AndAlso localTarih.Date = gibTarihDt.Date Then
                            puan += 40
                        End If
                    End If

                    ' Minimum esik: tutar+tarih(90), isim+tutar(130), VKN+tutar(150)
                    If puan > enIyiPuan AndAlso puan >= 90 Then
                        enIyiPuan = puan
                        enIyiFaturaID = localID
                    End If
                Next

                If enIyiFaturaID <> "" Then
                    Dim sProfile As String = If(eDoc.document_profile IsNot Nothing, eDoc.document_profile.Trim(), "")
                    Dim sDurum As String = If(eDoc.state_explanation IsNot Nothing, eDoc.state_explanation.Trim(), "")
                    Dim sDocType As String = If(eDoc.document_type_code IsNot Nothing, eDoc.document_type_code.Trim(), "")
                    Dim sRefUuid As String = If(eDoc.reference_document_uuid IsNot Nothing, eDoc.reference_document_uuid.Trim(), "")
                    eslesmeListesi.Add(New String() {enIyiFaturaID, gibDocId, gibUuid, sProfile, sDurum, sDocType, sRefUuid})
                    eslenenGibUuidler.Add(gibUuid)
                    eslenenFaturaIdler.Add(enIyiFaturaID)
                End If
            Next

            If eslesmeListesi.Count = 0 Then
                ' DEBUG: Eslestirme neden basarisiz oldugunu goster
                Dim dbgMsg As String = "Eslestirme Bulunamadi!" & vbCrLf & _
                    "E-Fatura belge: " & tumBelgeler.Count & vbCrLf & _
                    "E-Arsiv belge: " & tumEArsivBelgeler.Count & vbCrLf & _
                    "Yerel eksik fatura: " & dsEksik.Tables(0).Rows.Count & vbCrLf & vbCrLf
                ' Ilk 3 GIB belgenin bilgisini goster
                Dim sayac As Integer = 0
                For Each eDoc As EarsivServisi.ResponseDocument In tumEArsivBelgeler
                    If sayac >= 3 Then Exit For
                    Dim gTutar As String = If(eDoc.invoice_total IsNot Nothing, eDoc.invoice_total, "BOS")
                    Dim gDest As String = If(eDoc.destination_id IsNot Nothing, eDoc.destination_id, "BOS")
                    Dim gDocId As String = If(eDoc.document_id IsNot Nothing, eDoc.document_id, "BOS")
                    Dim gAd As String = If(eDoc.customerPersonName IsNot Nothing, eDoc.customerPersonName, "BOS")
                    Dim gSoyad As String = If(eDoc.customerPersonFamilyName IsNot Nothing, eDoc.customerPersonFamilyName, "BOS")
                    dbgMsg &= "GIB[" & sayac & "]: DocId=" & gDocId & " VKN=" & gDest & " Ad=" & gAd & " Soyad=" & gSoyad & " Tutar=" & gTutar & vbCrLf
                    sayac += 1
                Next
                ' Ilk 3 yerel kaydin bilgisini goster
                dbgMsg &= vbCrLf
                sayac = 0
                For Each drDbg As DataRow In dsEksik.Tables(0).Rows
                    If sayac >= 3 Then Exit For
                    Dim lNet As String = If(IsDBNull(drDbg("lNetTutar")), "NULL", drDbg("lNetTutar").ToString())
                    Dim lKdv As String = If(IsDBNull(drDbg("lKdvTutar")), "NULL", drDbg("lKdvTutar").ToString())
                    Dim lVkn As String = drDbg("sVergiNo").ToString().Trim()
                    Dim lAd As String = drDbg("sAciklama").ToString().Trim()
                    Dim lTC As String = drDbg("TC").ToString().Trim()
                    Dim lID As String = drDbg("nStokFisiID").ToString()
                    Dim lFirmaID As String = drDbg("nFirmaID").ToString()
                    dbgMsg &= "DB[" & sayac & "]: ID=" & lID & " FirmaID=" & lFirmaID & " VKN=" & lVkn & " TC=" & lTC & " Ad=" & lAd & " Net=" & lNet & " KDV=" & lKdv & vbCrLf
                    sayac += 1
                Next
                MsgBox(dbgMsg, MsgBoxStyle.Information, "Eslestirme Detayi")
                Exit Sub
            End If

            MsgBox(eslesmeListesi.Count & " eslestirme bulundu, DB guncelleniyor...", MsgBoxStyle.Information, "Eslestirme Tamam")

            con.Open()
            For Each eslesme As String() In eslesmeListesi
                Dim nStokFisiID As String = eslesme(0)
                Dim sGibNo As String = eslesme(1)
                Dim sGuid As String = eslesme(2)
                Dim sProfile As String = eslesme(3)
                Dim sDurum As String = eslesme(4)
                Dim sDocType As String = eslesme(5)
                Dim sRefUuid As String = eslesme(6)

                Dim sIadeEk As String = ""
                If sRefUuid <> "" Then
                    Try
                        Dim cmdRef As New OleDb.OleDbCommand(sorgu_query( _
                            "SELECT TOP 1 GibFaturaNo, dteFisTarihi FROM tbStokFisiMaster WHERE sEfaturaGuid = '" & sRefUuid.Replace("'", "''") & "'"), con)
                        Dim rdrRef As OleDb.OleDbDataReader = cmdRef.ExecuteReader()
                        If rdrRef.Read() Then
                            Dim sIadeFaturaNo As String = If(IsDBNull(rdrRef("GibFaturaNo")), "", rdrRef("GibFaturaNo").ToString().Trim())
                            If sIadeFaturaNo <> "" Then sIadeEk = ", IadeFaturaNo = '" & sIadeFaturaNo.Replace("'", "''") & "'"
                            If Not IsDBNull(rdrRef("dteFisTarihi")) Then sIadeEk &= ", IadeFaturaTarihi = '" & CDate(rdrRef("dteFisTarihi")).ToString("dd/MM/yyyy") & "'"
                        End If
                        rdrRef.Close()
                    Catch
                    End Try
                End If

                Dim sGuidEk As String = ""
                If sGuid <> "" Then
                    sGuidEk = ", sEfaturaGuid = '" & sGuid.Replace("'", "''") & "'"
                    sGuidEk &= ", sEfaturaUrl = 'https://earsivportal.efatura.gov.tr/intragiris.html?ettn=" & sGuid.Replace("'", "''") & "'"
                End If

                Dim cmdUpdate As New OleDb.OleDbCommand(sorgu_query( _
                    "SET DATEFORMAT DMY UPDATE tbStokFisiMaster SET " & _
                    "GibFaturaNo = '" & sGibNo.Replace("'", "''") & "', " & _
                    "bEfatura = 1, " & _
                    "sEfaturaTipi = '" & sProfile.Replace("'", "''") & "', " & _
                    "nEfaturaDurum = '" & sDurum.Replace("'", "''") & "', " & _
                    "bFaturaTipi = '" & sDocType.Replace("'", "''") & "'" & _
                    sGuidEk & sIadeEk & _
                    " WHERE nStokFisiID = " & nStokFisiID), con)
                cmdUpdate.ExecuteNonQuery()
            Next
            con.Close()

        Catch ex As Exception
            MsgBox("GIB Fatura Guncelleme Hatasi: " & ex.ToString(), MsgBoxStyle.Critical, "Hata")
        End Try
    End Sub

    Private Sub ara(Optional ByVal bListele As Boolean = True)
        bInfo = False
        Label2.Text = Sorgu_sDil("Lütfen Bekleyiniz...", sDil)
        Label2.Refresh()
        Cursor.Current = Cursors.WaitCursor
        Cursor.Show()
        GibFaturaNumaralariniGuncelle()
        dataload(txt_ara.EditValue.ToString, sec_konum.Text, sec_kriter.Text, sec_sFisTipi.EditValue, sec_nGirisCikis.EditValue, txt_dteFisTarihi1.EditValue, txt_dteFisTarihi2.EditValue, txt_lFisNo1.EditValue, txt_lFisNo2.EditValue, txt_lNetTutar1.EditValue, txt_lNetTutar2.EditValue, sec_sdepo.EditValue, sec_sHareketTipi.EditValue, sec_sSatici.EditValue, bListele)
        Label2.Text = Sorgu_sDil("Tamamlandı...", sDil)
        Cursor.Current = Cursors.Default
        Cursor.Hide()
        bInfo = True
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
                If bInfo = True Then
                    satir_firma_info()
                End If
            Catch ex As Exception
            End Try
        End If
    End Sub
    Private Sub GridView1_SelectionChanged(ByVal sender As Object, ByVal e As DevExpress.Data.SelectionChangedEventArgs) Handles GridView1.SelectionChanged
        irsaliyelestir_kontrol()
        If GridView1.SelectedRowsCount > 1 Then
            Label2.Text = Sorgu_sDil("Kayıt Sayısı :", sDil) & GridView1.RowCount & " / " & Sorgu_sDil("Satır :", sDil) & GridView1.FocusedRowHandle + 1 & " / " & Sorgu_sDil("Seçili :", sDil) & GridView1.SelectedRowsCount
        ElseIf GridView1.SelectedRowsCount = 1 Then
            Label2.Text = Sorgu_sDil("Kayıt Sayısı :", sDil) & GridView1.RowCount & " / " & Sorgu_sDil("Satır :", sDil) & GridView1.FocusedRowHandle + 1
        Else
            Label2.Text = ""
        End If
        Try
            If GridView1.RowCount > 0 Then
                Dim dr As DataRow
                dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                lbl_istihbarat.Text = dr("sNot").ToString
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
            'If XtraMessageBox.Show(Sorgu_sDil("Açık Faturalar Kontrol Ekranından Çıkmak İstediğinize Emin misiniz...?",sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question,sorgu_sDil("Dikkat",sDil)) = MsgBoxResult.Yes Then
            Me.Close()
            'End If
        End If
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        If islemstatus = True Then
            If GridView1.RowCount > 0 Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
                XtraMessageBox.Show(Sorgu_sDil("Kayıt Bulunamadı", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
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
        dataload_tbSatici()
        sec_sFisTipi.EditValue = sFisTipi
        sec_nGirisCikis.EditValue = nGirisCikis.ToString
        txt_dteFisTarihi1.EditValue = dteSistemTarihi
        txt_dteFisTarihi2.EditValue = dteSistemTarihi
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
        Try
            nFaturaCiktiSatirSayisi = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("VIEW").OpenSubKey("MAGAZA").OpenSubKey("Global").GetValue("nFaturaCiktiSatirSayisi").ToString
        Catch ex As Exception
            nFaturaCiktiSatirSayisi = 25
        End Try
        Try
            nIrsaliyeCiktiSatirSayisi = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("VIEW").OpenSubKey("MAGAZA").OpenSubKey("Global").GetValue("nIrsaliyeCiktiSatirSayisi").ToString
        Catch ex As Exception
            nIrsaliyeCiktiSatirSayisi = 25
        End Try
        Try
            nStokFisiCiktiSatirSayisi = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("VIEW").OpenSubKey("MAGAZA").OpenSubKey("Global").GetValue("nStokFisiCiktiSatirSayisi").ToString
        Catch ex As Exception
            nStokFisiCiktiSatirSayisi = 25
        End Try
        PanelControl1.Focus()
        GroupControl1.Focus()
        GroupControl1.Select()
        If txt_ara.Text <> "" Then
        Else
            txt_ara.Text = ""
        End If
        If kapla = True Then
            sec_sFisTipi.Enabled = True
            sec_nGirisCikis.Enabled = True
        End If
        If islemstatus = True Then
            sec_sFisTipi.Enabled = True
            sec_nGirisCikis.Enabled = True
        End If
        ara()
        bInfo = True
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
        tbFis_ekle(sec_sFisTipi.EditValue, sec_nGirisCikis.EditValue)
    End Sub
    Private Sub sec_sFisTipi_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_sFisTipi.EditValueChanged
        dataload_tbGirisCikis(nGirisCikis)
        Me.Text = sec_sFisTipi.Text & " Listesi"
    End Sub
    Private Sub MenuItem13_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem13.Click
        fis_faturala()
    End Sub
    Private Sub sec_resmi_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_resmi.CheckStateChanged
        If sec_resmi.Checked = True Then
            connection = connection_resmi
            ara()
            sec_resmi1.Checked = False
            sec_Aktar.Checked = False
        ElseIf sec_resmi.Checked = False Then
            connection = connection_orj
            ara()
        End If
    End Sub
    Private Sub sec_Aktar_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_Aktar.CheckStateChanged
        If sec_Aktar.Checked = True Then
            'connection = connection_resmi
            ara()
            sec_resmi.Checked = False
            sec_resmi1.Checked = False
        ElseIf sec_Aktar.Checked = False Then
            'connection = connection_orj
            ara()
        End If
    End Sub
    Private Sub sec_resmi1_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_resmi1.CheckStateChanged
        If sec_resmi1.Checked = True Then
            connection = connection_resmi1
            ara()
            sec_resmi.Checked = False
            sec_Aktar.Checked = False
        ElseIf sec_resmi1.Checked = False Then
            connection = connection_orj
            ara()
        End If
    End Sub
    Private Sub MenuItem14_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem14.Click
        GridView1.OptionsView.ShowAutoFilterRow = True
        GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
        GridView1.OptionsCustomization.AllowFilter = True
    End Sub
    Private Sub MenuItem24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem24.Click
        ara()
    End Sub
    Private Sub MenuItem26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem26.Click
        raporla_excel()
    End Sub
    Private Sub MenuItem27_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItem27.Click
        raporla_text()
    End Sub
    Private Sub raporla_excel()
        If XtraMessageBox.Show(Sorgu_sDil("Sonuçları Excel Dosyası Oluşturmak İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim SaveFileDialog1 As New Windows.Forms.SaveFileDialog
            SaveFileDialog1.Filter = "Excel Dosyaları(*.xls) |*.xls"
            SaveFileDialog1.InitialDirectory = "c:\"
            SaveFileDialog1.FileName = "Rapor.xls"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                GridView1.ExportToXls(SaveFileDialog1.FileName.ToString)
                If XtraMessageBox.Show(Sorgu_sDil("Kaydı Açmak İster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    Process.Start(SaveFileDialog1.FileName.ToString)
                End If
            End If
            SaveFileDialog1 = Nothing
        End If
    End Sub
    Private Sub raporla_text()
        If XtraMessageBox.Show(Sorgu_sDil("Sonuçları Text Dosyası Oluşturmak İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim SaveFileDialog1 As New Windows.Forms.SaveFileDialog
            SaveFileDialog1.Filter = "Text Dosyaları(*.txt) |*.txt"
            SaveFileDialog1.InitialDirectory = "c:\"
            SaveFileDialog1.FileName = "Rapor.txt"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                GridView1.ExportToText(SaveFileDialog1.FileName.ToString)
                If XtraMessageBox.Show(Sorgu_sDil("Kaydı Açmak İster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    Process.Start(SaveFileDialog1.FileName.ToString)
                End If
            End If
            SaveFileDialog1 = Nothing
        End If
    End Sub
    Private Sub firma_sec()
        Dim frm As New frm_firma_liste
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        'frm.musterino = dr_baslik("FIRMAKODU")
        frm.islemstatus = True
        frm.kullanici = kullanici
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim dr1 As DataRow
            dr1 = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
            txt_ara.Text = dr1("sKodu")
            dr1 = Nothing
        Else
            'Me.Close()
        End If
    End Sub
    Private Sub SimpleButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        tbFis_ekle(sec_sFisTipi.EditValue, sec_nGirisCikis.EditValue)
    End Sub
    Private Sub SimpleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        fis_duzelt()
    End Sub
    Private Sub btnEkle_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEkle.ItemClick
        tbFis_ekle(sec_sFisTipi.EditValue, sec_nGirisCikis.EditValue)
    End Sub
    Private Sub btnDuzelt_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDuzelt.ItemClick
        fis_duzelt()
    End Sub
    Private Sub btnYazdir_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnYazdir.ItemClick
        gorunum_yazdir()
    End Sub
    Private Sub BarButtonItem5_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        analiz_Firma_karti()
    End Sub
    Private Sub BarButtonItem8_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem8.ItemClick
        analiz_cari_bakiye()
    End Sub
    Private Sub BarButtonItem6_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        analiz_cari_hareket()
    End Sub
    Private Sub BarButtonItem7_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem7.ItemClick
        analiz_iletisim()
    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        raporla_excel()
    End Sub
    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        raporla_text()
    End Sub
    Private Sub txt_ara_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_ara.KeyDown
        If e.KeyCode = Keys.Space Then
            firma_sec()
        End If
    End Sub
    Private Sub MenuItem28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem28.Click
        raporla(0, 0)
    End Sub
    Private Sub MenuItem29_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItem29.Click
        raporla(0, 2)
    End Sub
    Private Sub MenuItem30_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItem30.Click
        raporla(0, 1)
    End Sub
    Private Sub BarButtonItem9_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem9.ItemClick
        analiz_toplam("FaturaDepoToplam")
    End Sub
    Private Sub BarButtonItem10_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem10.ItemClick
        analiz_toplam("FaturaDepoToplamları")
    End Sub
    Private Sub BarButtonItem11_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem11.ItemClick
        analiz_toplam("FaturaGunToplamları")
    End Sub
    Private Sub MenuItem33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem33.Click
        raporla_dokum(0, 0)
    End Sub
    Private Sub MenuItem34_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItem34.Click
        raporla_dokum(0, 2)
    End Sub
    Private Sub MenuItem35_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItem35.Click
        raporla_dokum(0, 1)
    End Sub
    Private Sub MenuItem38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem38.Click
        raporla_dokum(0, 3)
    End Sub
    Private Sub MenuItem40_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem40.Click
        If kullanici < 3 Then
            If XtraMessageBox.Show(Sorgu_sDil("Seçili Fiş Kayıtlarını Kilitlemek İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) Then
                satirlar_kilit(1)
            End If
        End If
    End Sub
    Private Sub MenuItem41_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem41.Click
        If kullanici < 3 Then

            If XtraMessageBox.Show(Sorgu_sDil("Seçili Fiş Kayıtlarının Kilitlerini Kaldırmak İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) Then
                satirlar_kilit(0)

            End If
        End If
    End Sub
    Private Sub txt_sKaydeden_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_sKaydeden.EditValueChanged
    End Sub
    Private Sub sec_sdepo_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles sec_sdepo.QueryPopUp
        sec_sdepo.Properties.PopupControl = sec_grid
        GridControl2.DataSource = ds_tbDepo.Tables(0)
        GridControl2.DataMember = Nothing
    End Sub
    Private Sub sec_sdepo_QueryResultValue(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.QueryResultValueEventArgs) Handles sec_sdepo.QueryResultValue
        Dim s As String = deger(ds_tbDepo)
        If s.ToString <> "" Then
            e.Value = s.ToString
        Else
            e.Value = "[Tümü]"
        End If
    End Sub
    Private Sub ClosePopup()
        If Not sec_grid.OwnerEdit Is Nothing Then
            sec_grid.OwnerEdit.ClosePopup()
        End If
    End Sub
    Private Function deger(ByVal ds As DataSet) As String
        Dim dr As DataRow
        Dim s As String = ""
        Dim satir As String = ""
        Dim sayi As Integer = 0
        Dim sayi1 As Integer = 0
        For Each dr In ds.Tables(0).Rows
            If dr("SEC") = True Then
                sayi += 1
            End If
        Next
        For Each dr In ds.Tables(0).Rows
            If dr("SEC") = True Then
                sayi1 += 1
                s += "'" + Trim(dr("KOD")).ToString + "'"
                satir += Trim(dr("ACIKLAMA"))
                If sayi1 < sayi Then
                    s += ","
                    satir += ","
                End If
            End If
        Next
        sayi1 = Nothing
        sayi = Nothing
        Return s.ToString
    End Function
    Private Sub tbStokFisiAciklamasi_notlari()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_musteri_karti_aciklama
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.kayitno = nFirmaID
            frm.tbStokFisiAciklamasi = True
            frm.nStokFisiID = dr("nStokFisiID")
            frm.kullanici = kullanici
            'Firma Açıklaması Kontrol
            If sorgu_tbFirmaTablo_kontrol(dr("nStokFisiID"), "tbStokFisiAciklamasi") = 0 Then
                tbStokFisiAciklamasi_kaydet_yeni(dr("nStokFisiID"), "", "", "", "", "", "", "", "", "", "")
            End If
            frm.ShowDialog()
        End If
    End Sub
    'Public Function sorgu_tbFirmaTablo_kontrol(ByVal nStokFisiID As String, ByVal Tablo As String) As Int64
    '    Dim kriter
    '    kriter = "WHERE (nStokFisiID = '" & nStokFisiID & "') "
    '    Dim conn As New OleDb.OleDbConnection
    '    Dim cmd As New OleDb.OleDbCommand
    '    Dim adapter As New OleDb.OleDbDataAdapter
    '    conn.ConnectionString = connection
    '    cmd.Connection = conn
    '    conn.Open()
    '    cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(*), 0) AS KAYIT  FROM         " & Tablo & "  " & kriter & "")
    '    Dim kayitsayisi = cmd.ExecuteScalar
    '    Return kayitsayisi
    'End Function
    Public Function sorgu_tbFirmaTablo_kontrol(ByVal nStokFisiID As String, ByVal Tablo As String) As Long
        Dim right As Object = ("WHERE (nStokFisiID = '" & nStokFisiID & "') ")
        Dim connection As New OleDbConnection
        Dim command As New OleDbCommand
        Dim adapter As New OleDbDataAdapter
        connection.ConnectionString = Conversions.ToString(Me.connection)
        command.Connection = connection
        connection.Open()
        command.CommandText = Me.sorgu_query(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(*), 0) AS KAYIT  FROM         " & Tablo & "  "), right), "")))
        Return Conversions.ToLong(RuntimeHelpers.GetObjectValue(command.ExecuteScalar))
    End Function
    Private Sub MenuItem42_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem42.Click
        tbStokFisiAciklamasi_notlari()
    End Sub
    Private Sub SimpleButton4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton4.Click
        Group_Muhasebelestir.Visible = False
        GridControl1.Focus()
        GridControl1.Select()
    End Sub
    Private Sub SimpleButton5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton5.Click
        If XtraMessageBox.Show("Muhasebeleştirme İşlemine Başlamak İstediğinize Emin misiniz...?", Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            bar1.Visible = True
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            muhasebelestir(1)
            bar1.Visible = False
            Group_Muhasebelestir.Visible = False
            GridControl1.Focus()
            GridControl1.Select()
            Cursor.Current = Cursors.Default
            Cursor.Hide()
        End If
    End Sub
    Private Sub muhasebelestir(ByVal bKilitli As Byte)
        Dim arr As Integer()
        Dim i As Integer
        Dim sayi As Integer = 0
        Dim nFirmaID As String = ""
        Dim s As String = ""
        Dim dr As DataRow
        Dim dr1 As DataRow
        arr = GridView1.GetSelectedRows()
        Dim ds_Muhasebelestir As DataSet
        Dim lFisNo = sorgu_lMuhasebeFisNo()
        Dim lYevmiyeNo = lFisNo
        Dim sKodu As String = ""
        Dim nHesapID As Int64 = 0
        Dim nFisSiraID As Int64 = sorgu_nFisSiraID()
        Dim nCariHareketID = 0
        Dim nHareketID As Int64 = nCariHareketID
        Dim nKasaIslemID As String = ""
        Dim nBordroSatirID As String = ""
        Dim nSatir As Integer = 0
        Dim lGirenMiktar As Decimal = 0
        Dim lBorcTutar As Decimal = 0
        Dim lAlacakTutar As Decimal = 0
        Dim lCikanMiktar As Decimal = 0
        Dim sDovizCinsi1 As String = ""
        Dim lDovizMiktari1 As Decimal = 0
        Dim lDovizKuru1 As Decimal = 0
        Dim sDovizCinsi2 As String = ""
        Dim lDovizMiktari2 As Decimal = 0
        Dim lDovizKuru2 As Decimal = 0
        Dim sEvrakNo As String = ""
        Dim sHangiUygulama As String = "MUH"
        Dim sMasrafYontemi = ""
        Dim nKasaID As Int64 = 0
        Dim nAlacakliFirmaID As Int64 = 0
        Dim nAlacakliHesapID As Int64 = 0
        Dim sHesapKodu As String = ""
        Dim sHesapAciklama As String = ""
        Dim sStokKodu As String = ""
        Dim sStokAciklama As String = ""
        Dim sAciklama As String = ""
        Dim lToplamKdvTutari As Decimal = 0
        Dim sAciklamaNot3 As String = ""
        If Trim(sec_sFisTipi.EditValue) = "FS" Or Trim(sec_sFisTipi.EditValue) = "HS" Or Trim(sec_sFisTipi.EditValue) = "DC" Then
            sAciklamaNot3 = sec_sFisTipi.Text
        Else
            sAciklamaNot3 = sec_sFisTipi.Text
        End If
        Dim dteFisTarihi As DateTime = Today
        Dim sMuhFisTipi As Int64 = 3
        bar1.Properties.Maximum = GridView1.SelectedRowsCount
        bar1.Position = 0
        bar1.Refresh()
        If arr Is Nothing Then
        Else
            Array.Sort(arr)
            For Each i In arr
                s = i.ToString
                dr = GridView1.GetDataRow(s)
                bar1.Position += 1
                bar1.Refresh()
                ds_Muhasebelestir = sorgu(sorgu_query("SELECT tbFirma.sKodu, tbFirma.sAciklama, tbStok.sKodu AS sStokKodu, tbStok.sAciklama AS sStokAciklama, tbStok.nStokTipi,tbStokFisiDetayi.dteFisTarihi,tbStokFisiDetayi.sFisTipi, tbStokFisiDetayi.lFisNo,tbStokFisiDetayi.nKdvOrani, tbStokFisiDetayi.lGirisMiktar1, tbStokFisiDetayi.lCikisMiktar1, tbStokFisiDetayi.lBrutFiyat, tbStokFisiDetayi.lBrutTutar, tbStokFisiDetayi.lCikisFiyat, tbStokFisiDetayi.lCikisTutar, tbStokFisiDetayi.lGirisFiyat, tbStokFisiDetayi.lGirisTutar, tbStokFisiDetayi.nIskontoYuzdesi, ROUND(tbStokFisiDetayi.lIskontoTutari,2) AS lIskontoTutari, (SELECT TOP 1 ISNULL(lGirisFiyat , 0) FROM tbStokFisiDetayi tbAlis WHERE sFisTipi = 'FA' AND nGirisCikis = 1  and tbAlis.nStokID = tbStokFisiDetayi.nStokID Order by dteFisTarihi DESC) AS lMaliyet, ROUND((tbStokFisiDetayi.lBrutTutar - tbStokFisiDetayi.lIskontoTutari) * tbStokFisiDetayi.nKdvOrani / 100, 2) AS lKdvTutari, tbStokFisiMaster.nStokFisiID, tbStokFisiMaster.lToplamMiktar, tbStokFisiMaster.lMalBedeli, tbStokFisiMaster.lMalIskontoTutari, tbStokFisiMaster.nDipIskontoYuzdesi1, tbStokFisiMaster.lDipIskontoTutari1, tbStokFisiMaster.nDipIskontoYuzdesi2, tbStokFisiMaster.lDipIskontoTutari2, tbStokFisiMaster.lDipIskontoTutari3, tbStokFisiMaster.nKdvOrani1, tbStokFisiMaster.lKdvMatrahi1, tbStokFisiMaster.lKdv1, tbStokFisiMaster.nKdvOrani2, tbStokFisiMaster.lKdvMatrahi2, tbStokFisiMaster.lKdv2, tbStokFisiMaster.nKdvOrani3, tbStokFisiMaster.lKdvMatrahi3, tbStokFisiMaster.lKdv3, tbStokFisiMaster.nKdvOrani4, tbStokFisiMaster.lKdvMatrahi4, tbStokFisiMaster.lKdv4, tbStokFisiMaster.nKdvOrani5, tbStokFisiMaster.lKdvMatrahi5, tbStokFisiMaster.lKdv5, tbStokFisiMaster.lNetTutar, tbStokFisiMaster.nTevkifatKdvOrani, tbStokFisiMaster.lTevkifatKdvMatrahi, tbStokFisiMaster.lTevkifatKdv, tbStokFisiMaster.bMuhasebeyeIslendimi,tbStokFisiAciklamasi.sAciklama1 FROM tbStokFisiDetayi INNER JOIN tbStokFisiMaster ON tbStokFisiDetayi.nStokFisiID = tbStokFisiMaster.nStokFisiID INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID INNER JOIN tbFirma ON tbStokFisiMaster.nFirmaID = tbFirma.nFirmaID LEFT OUTER JOIN                       tbStokFisiAciklamasi ON tbStokFisiMaster.nStokFisiID = tbStokFisiAciklamasi.nStokFisiID WHERE (tbStokFisiMaster.sFisTipi = '" & sec_sFisTipi.EditValue & "') and (tbStokFisiMaster.nGirisCikis = '" & sec_nGirisCikis.EditValue & "') AND (tbStokFisiMaster.nStokFisiID = '" & dr("nStokFisiID") & "') ORDER BY tbStokFisiDetayi.nGirisCikis,tbStokFisiDetayi.nIslemID"))

                'Başlık Kaydet
                If ds_Muhasebelestir.Tables(0).Rows.Count > 0 Then
                    dr1 = ds_Muhasebelestir.Tables(0).Rows(0)
                    If sec_sMuhasebeEntegrasyonTuru.Text = "Gib'e Gönderimi İptal Et" Then
                        GibEntegrasyon_kaldir(dr("nStokFisiID"), kullaniciadi)
                    ElseIf sec_sMuhasebeEntegrasyonTuru.Text = "Bire-Bir Muhasebeleştirme" Then
                        lMuhasebeFisNo_degistir()
                        Try
                            tbMuhasebeFisi_Aciklamasi_kaydet_yeni(dteFisTarihi, sMuhFisTipi, lFisNo, "", "Entegre", sAciklamaNot3, "", "", 0)
                        Catch ex As Exception
                        End Try
                        lFisNo = sorgu_lMuhasebeFisNo()
                        lYevmiyeNo = lFisNo
                        dteFisTarihi = dr1("dteFisTarihi")
                    ElseIf sec_sMuhasebeEntegrasyonTuru.Text = "Günlük Muhasebeleştirme" Then
                        If dteFisTarihi <> dr1("dteFisTarihi") Then
                            lMuhasebeFisNo_degistir()
                            Try
                                tbMuhasebeFisi_Aciklamasi_kaydet_yeni(dteFisTarihi, sMuhFisTipi, lFisNo, "", "Entegre", sAciklamaNot3, "", "", 0)
                            Catch ex As Exception
                            End Try
                            lFisNo = sorgu_lMuhasebeFisNo()
                            lYevmiyeNo = lFisNo
                            dteFisTarihi = dr1("dteFisTarihi")
                        End If
                    ElseIf sec_sMuhasebeEntegrasyonTuru.Text = "Toplu Muhasebeleştirme" Then
                        dteFisTarihi = txt_dteEntegreTarihi.EditValue
                    End If
                    nSatir = 0
                    dr1("lKdvTutari") = sorgu_sayi(dr1("lKdvTutari"), 0)
                    If Trim(dr1("sFisTipi")) = "FS" Then
                        If dr1("sKodu").ToString.Contains("-") = True Then
                            sHesapKodu = Trim(dr1("sKodu"))
                            sHesapAciklama = dr1("sAciklama")
                        Else
                            sHesapKodu = "120-0001-" & sayiuzunlukkontrol(Trim(dr1("sKodu")), 7)
                            sHesapAciklama = dr1("sAciklama")
                        End If
                        sHesapKodu = "120-0001-" & sayiuzunlukkontrol(Trim(dr1("sKodu")), 7)
                        sHesapAciklama = dr1("sAciklama")
                        nHesapID = sorgula_nStokID("Select nHesapID from tbHesapPlani Where sKodu = '" & sHesapKodu & "'")
                        If nHesapID = 0 Then
                            nHesapID = tbHesapPlani_kaydet_yeni(sHesapKodu, sHesapAciklama, "", 0, "", 0, "", "", 0, "SA", Now)
                        End If
                        nFisSiraID = sorgu_nFisSiraID()
                        If dr1("lNetTutar") > 0 Then
                            lBorcTutar = FormatNumber(Math.Abs(dr1("lNetTutar")), 2)
                            lAlacakTutar = 0
                        ElseIf dr1("lNetTutar") < 0 Then
                            lAlacakTutar = FormatNumber(Math.Abs(dr1("lNetTutar")), 2)
                            lBorcTutar = 0
                        End If
                        sDovizCinsi1 = ""
                        lDovizKuru1 = 0
                        lDovizMiktari1 = 0
                        sDovizCinsi2 = ""
                        lDovizKuru2 = 0
                        lDovizMiktari2 = 0
                        lGirenMiktar = 0
                        lCikanMiktar = 0
                        If Trim(dr1("sAciklama1").ToString) = "" Then
                            sAciklama = dr1("lFisNo")
                        Else
                            If sDatabaseGenel = "AVCIMESRUBAT" Then
                                sAciklama = dr1("sAciklama1")
                            Else
                                sAciklama = dr1("lFisNo")
                            End If
                        End If
                        nFisSiraID = tbMuhasebeFisi_kaydet_yeni(nFisSiraID, dteFisTarihi, sMuhFisTipi, lFisNo, lYevmiyeNo, nHesapID, sAciklama, lGirenMiktar, lCikanMiktar, lBorcTutar, lAlacakTutar, sMasrafYontemi, nKasaID, sHangiUygulama, sHareketTipi, nCariHareketID, kullaniciadi, Now, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, nSatir, sSubeMagaza, kullaniciadi, Now)
                        nFisSiraID_degistir(nFisSiraID)
                    ElseIf Trim(dr1("sFisTipi")) = "FA" Then
                        If dr1("sKodu").ToString.Contains("-") = True Then
                            sHesapKodu = Trim(dr1("sKodu"))
                            sHesapAciklama = dr1("sAciklama")
                        Else
                            sHesapKodu = "320-0001-" & sayiuzunlukkontrol(Trim(dr1("sKodu")), 7)
                            sHesapAciklama = dr1("sAciklama")
                        End If
                        nHesapID = sorgula_nStokID("Select nHesapID from tbHesapPlani Where sKodu = '" & sHesapKodu & "'")
                        If nHesapID = 0 Then
                            nHesapID = tbHesapPlani_kaydet_yeni(sHesapKodu, sHesapAciklama, "", 0, "", 0, "", "", 0, "SA", Now)
                        End If
                        nFisSiraID = sorgu_nFisSiraID()
                        If dr1("lNetTutar") > 0 Then
                            lAlacakTutar = FormatNumber(Math.Abs(dr1("lNetTutar")), 2)
                            lBorcTutar = 0
                        ElseIf dr1("lNetTutar") < 0 Then
                            lBorcTutar = FormatNumber(Math.Abs(dr1("lNetTutar")), 2)
                            lAlacakTutar = 0
                        End If
                        sDovizCinsi1 = ""
                        lDovizKuru1 = 0
                        lDovizMiktari1 = 0
                        sDovizCinsi2 = ""
                        lDovizKuru2 = 0
                        lDovizMiktari2 = 0
                        lGirenMiktar = 0
                        lCikanMiktar = 0
                        sAciklama = dr1("lFisNo")
                        nFisSiraID = tbMuhasebeFisi_kaydet_yeni(nFisSiraID, dteFisTarihi, sMuhFisTipi, lFisNo, lYevmiyeNo, nHesapID, sAciklama, lGirenMiktar, lCikanMiktar, lBorcTutar, lAlacakTutar, sMasrafYontemi, nKasaID, sHangiUygulama, sHareketTipi, nCariHareketID, kullaniciadi, Now, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, nSatir, sSubeMagaza, kullaniciadi, Now)
                        nFisSiraID_degistir(nFisSiraID)
                    End If
                End If
                'Hareketleri Kaydet
                For Each dr1 In ds_Muhasebelestir.Tables(0).Rows
                    nSatir += 1
                    '600 veya 153 kaydet
                    If Trim(dr1("sFisTipi")) = "FS" Then
                        If dr1("lBrutFiyat") > 0 Then
                            'Satışı İşle
                            If dr1("lCikisMiktar1") > 0 And dr1("nStokTipi") < 4 Then
                                sHesapKodu = "600-0001-" & sayiuzunlukkontrol(Trim(dr1("sStokKodu")), 7)
                                sHesapAciklama = dr1("sStokAciklama")
                                nHesapID = sorgula_nStokID("Select nHesapID from tbHesapPlani Where sKodu = '" & sHesapKodu & "'")
                                If nHesapID = 0 Then
                                    nHesapID = tbHesapPlani_kaydet_yeni(sHesapKodu, sHesapAciklama, "", 0, "", 0, "", "", 0, "SA", Now)
                                End If
                                nFisSiraID = sorgu_nFisSiraID()
                                lBorcTutar = 0
                                lAlacakTutar = Math.Abs(dr1("lBrutTutar"))
                                sDovizCinsi1 = ""
                                lDovizKuru1 = 0
                                lDovizMiktari1 = 0
                                sDovizCinsi2 = ""
                                lDovizKuru2 = 0
                                lDovizMiktari2 = 0
                                lGirenMiktar = 0
                                lCikanMiktar = Math.Abs(dr1("lCikisMiktar1"))
                                nFisSiraID = tbMuhasebeFisi_kaydet_yeni(nFisSiraID, dteFisTarihi, sMuhFisTipi, lFisNo, lYevmiyeNo, nHesapID, sAciklama, lGirenMiktar, lCikanMiktar, lBorcTutar, lAlacakTutar, sMasrafYontemi, nKasaID, sHangiUygulama, sHareketTipi, nCariHareketID, kullaniciadi, Now, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, nSatir, sSubeMagaza, kullaniciadi, Now)
                                nFisSiraID_degistir(nFisSiraID)
                            ElseIf dr1("lCikisMiktar1") < 0 Then
                                sHesapKodu = "610-0001-" & sayiuzunlukkontrol(Trim(dr1("sStokKodu")), 7)
                                sHesapAciklama = dr1("sStokAciklama")
                                nHesapID = sorgula_nStokID("Select nHesapID from tbHesapPlani Where sKodu = '" & sHesapKodu & "'")
                                If nHesapID = 0 Then
                                    nHesapID = tbHesapPlani_kaydet_yeni(sHesapKodu, sHesapAciklama, "", 0, "", 0, "", "", 0, "SA", Now)
                                End If
                                nFisSiraID = sorgu_nFisSiraID()
                                lBorcTutar = Math.Abs(dr1("lBrutTutar"))
                                lAlacakTutar = 0
                                sDovizCinsi1 = ""
                                lDovizKuru1 = 0
                                lDovizMiktari1 = 0
                                sDovizCinsi2 = ""
                                lDovizKuru2 = 0
                                lDovizMiktari2 = 0
                                lGirenMiktar = Math.Abs(dr1("lCikisMiktar1"))
                                lCikanMiktar = 0
                                nFisSiraID = tbMuhasebeFisi_kaydet_yeni(nFisSiraID, dteFisTarihi, sMuhFisTipi, lFisNo, lYevmiyeNo, nHesapID, sAciklama, lGirenMiktar, lCikanMiktar, lBorcTutar, lAlacakTutar, sMasrafYontemi, nKasaID, sHangiUygulama, sHareketTipi, nCariHareketID, kullaniciadi, Now, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, nSatir, sSubeMagaza, kullaniciadi, Now)
                                nFisSiraID_degistir(nFisSiraID)
                            ElseIf dr1("lCikisMiktar1") > 0 And dr1("nStokTipi") >= 4 Then
                                If dr1("nStokTipi") = 4 Then
                                    sHesapKodu = "602-0001-" & sayiuzunlukkontrol(Trim(dr1("sStokKodu")), 7)
                                    sHesapAciklama = dr1("sStokAciklama")
                                Else
                                    sHesapKodu = "649-0002-" & sayiuzunlukkontrol(Trim(dr1("sStokKodu")), 7)
                                    sHesapAciklama = dr1("sStokAciklama")
                                End If
                                nHesapID = sorgula_nStokID("Select nHesapID from tbHesapPlani Where sKodu = '" & sHesapKodu & "'")
                                If nHesapID = 0 Then
                                    nHesapID = tbHesapPlani_kaydet_yeni(sHesapKodu, sHesapAciklama, "", 0, "", 0, "", "", 0, "SA", Now)
                                End If
                                nFisSiraID = sorgu_nFisSiraID()
                                lBorcTutar = 0
                                lAlacakTutar = Math.Abs(dr1("lBrutTutar"))
                                sDovizCinsi1 = ""
                                lDovizKuru1 = 0
                                lDovizMiktari1 = 0
                                sDovizCinsi2 = ""
                                lDovizKuru2 = 0
                                lDovizMiktari2 = 0
                                lGirenMiktar = 0
                                lCikanMiktar = Math.Abs(dr1("lCikisMiktar1"))
                                nFisSiraID = tbMuhasebeFisi_kaydet_yeni(nFisSiraID, dteFisTarihi, sMuhFisTipi, lFisNo, lYevmiyeNo, nHesapID, sAciklama, lGirenMiktar, lCikanMiktar, lBorcTutar, lAlacakTutar, sMasrafYontemi, nKasaID, sHangiUygulama, sHareketTipi, nCariHareketID, kullaniciadi, Now, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, nSatir, sSubeMagaza, kullaniciadi, Now)
                                nFisSiraID_degistir(nFisSiraID)
                            End If
                        ElseIf dr1("lBrutFiyat") < 0 Then
                            sHesapKodu = "611-0001-" & sayiuzunlukkontrol(Trim(dr1("sStokKodu")), 7)
                            sHesapAciklama = dr1("sStokAciklama")
                            nHesapID = sorgula_nStokID("Select nHesapID from tbHesapPlani Where sKodu = '" & sHesapKodu & "'")
                            If nHesapID = 0 Then
                                nHesapID = tbHesapPlani_kaydet_yeni(sHesapKodu, sHesapAciklama, "", 0, "", 0, "", "", 0, "SA", Now)
                            End If
                            nFisSiraID = sorgu_nFisSiraID()
                            If dr1("lBrutFiyat") > 0 Then
                                lBorcTutar = Math.Abs(dr1("lBrutTutar"))
                            Else
                                'lBorcTutar = Math.Abs(dr1("lIskontoTutari")) + Math.Abs(dr1("lKdvTutari"))
                                lBorcTutar = Math.Abs(dr1("lBrutTutar"))
                            End If
                            lAlacakTutar = 0
                            sDovizCinsi1 = ""
                            lDovizKuru1 = 0
                            lDovizMiktari1 = 0
                            sDovizCinsi2 = ""
                            lDovizKuru2 = 0
                            lDovizMiktari2 = 0
                            lGirenMiktar = 0
                            lCikanMiktar = dr1("lCikisMiktar1")
                            nFisSiraID = tbMuhasebeFisi_kaydet_yeni(nFisSiraID, dteFisTarihi, sMuhFisTipi, lFisNo, lYevmiyeNo, nHesapID, sAciklama, lGirenMiktar, lCikanMiktar, lBorcTutar, lAlacakTutar, sMasrafYontemi, nKasaID, sHangiUygulama, sHareketTipi, nCariHareketID, kullaniciadi, Now, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, nSatir, sSubeMagaza, kullaniciadi, Now)
                            nFisSiraID_degistir(nFisSiraID)
                        End If
                        'İskontoyu İşle
                        If Math.Abs(dr1("lIskontoTutari")) > 0 Then
                            sHesapKodu = "611-0001-" & sayiuzunlukkontrol(Trim(dr1("sStokKodu")), 7)
                            sHesapAciklama = dr1("sStokAciklama")
                            nHesapID = sorgula_nStokID("Select nHesapID from tbHesapPlani Where sKodu = '" & sHesapKodu & "'")
                            If nHesapID = 0 Then
                                nHesapID = tbHesapPlani_kaydet_yeni(sHesapKodu, sHesapAciklama, "", 0, "", 0, "", "", 0, "SA", Now)
                            End If
                            nFisSiraID = sorgu_nFisSiraID()
                            If dr1("lIskontoTutari") > 0 Then
                                lBorcTutar = Math.Abs(dr1("lIskontoTutari"))
                                lAlacakTutar = 0
                            Else
                                'lBorcTutar = Math.Abs(dr1("lIskontoTutari")) + Math.Abs(dr1("lKdvTutari"))
                                lAlacakTutar = Math.Abs(dr1("lIskontoTutari"))
                                lBorcTutar = 0
                            End If
                            sDovizCinsi1 = ""
                            lDovizKuru1 = 0
                            lDovizMiktari1 = 0
                            sDovizCinsi2 = ""
                            lDovizKuru2 = 0
                            lDovizMiktari2 = 0
                            lGirenMiktar = 0
                            lCikanMiktar = 0
                            nFisSiraID = tbMuhasebeFisi_kaydet_yeni(nFisSiraID, dteFisTarihi, sMuhFisTipi, lFisNo, lYevmiyeNo, nHesapID, sAciklama, lGirenMiktar, lCikanMiktar, lBorcTutar, lAlacakTutar, sMasrafYontemi, nKasaID, sHangiUygulama, sHareketTipi, nCariHareketID, kullaniciadi, Now, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, nSatir, sSubeMagaza, kullaniciadi, Now)
                            nFisSiraID_degistir(nFisSiraID)
                        End If
                        If Math.Abs(dr1("lKdvTutari")) <> 0 Then
                            'Kdvyi İşle
                            If sec_nGirisCikis.EditValue = 3 Then
                                sHesapKodu = "391-0001-" & sayiuzunlukkontrol(CInt(dr1("nKdvOrani")), 7)
                                sHesapAciklama = "Hesaplanan Kdv % " & CInt(dr1("nKdvOrani"))
                            Else
                                sHesapKodu = "191-0001-" & sayiuzunlukkontrol(CInt(dr1("nKdvOrani")), 7)
                                sHesapAciklama = "Hesaplanan Kdv % " & CInt(dr1("nKdvOrani"))
                            End If
                            nHesapID = sorgula_nStokID("Select nHesapID from tbHesapPlani Where sKodu = '" & sHesapKodu & "'")
                            If nHesapID = 0 Then
                                nHesapID = tbHesapPlani_kaydet_yeni(sHesapKodu, sHesapAciklama, "", 0, "", 0, "", "", 0, "SA", Now)
                            End If
                            nFisSiraID = sorgu_nFisSiraID()
                            If dr1("lKdvTutari") > 0 Then
                                lBorcTutar = 0
                                lAlacakTutar = Math.Abs(dr1("lKdvTutari"))
                            ElseIf dr1("lKdvTutari") < 0 Then
                                lBorcTutar = Math.Abs(dr1("lKdvTutari"))
                                lAlacakTutar = 0
                            End If
                            sDovizCinsi1 = ""
                            lDovizKuru1 = 0
                            lDovizMiktari1 = 0
                            sDovizCinsi2 = ""
                            lDovizKuru2 = 0
                            lDovizMiktari2 = 0
                            lGirenMiktar = 0
                            lCikanMiktar = 0
                            nFisSiraID = tbMuhasebeFisi_kaydet_yeni(nFisSiraID, dteFisTarihi, sMuhFisTipi, lFisNo, lYevmiyeNo, nHesapID, sAciklama, lGirenMiktar, lCikanMiktar, lBorcTutar, lAlacakTutar, sMasrafYontemi, nKasaID, sHangiUygulama, sHareketTipi, nCariHareketID, kullaniciadi, Now, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, nSatir, sSubeMagaza, kullaniciadi, Now)
                            nFisSiraID_degistir(nFisSiraID)
                        End If
                        If dr1("lBrutFiyat") > 0 And dr1("nStokTipi") < 4 Then
                            'Satışın Maliyetini İşle
                            If sec_bSatisMaliyetHesapla.Checked = True And sorgu_sayi(dr1("lMaliyet"), 0) <> 0 And dr1("lCikisMiktar1") > 0 Then
                                'Maliyet
                                sHesapKodu = "621-0001-" & sayiuzunlukkontrol(Trim(dr1("sStokKodu")), 7)
                                sHesapAciklama = dr1("sStokAciklama")
                                nHesapID = sorgula_nStokID("Select nHesapID from tbHesapPlani Where sKodu = '" & sHesapKodu & "'")
                                If nHesapID = 0 Then
                                    nHesapID = tbHesapPlani_kaydet_yeni(sHesapKodu, sHesapAciklama, "", 0, "", 0, "", "", 0, "SA", Now)
                                End If
                                nFisSiraID = sorgu_nFisSiraID()
                                lBorcTutar = Math.Abs(dr1("lMaliyet") * dr1("lCikisMiktar1"))
                                lAlacakTutar = 0
                                sDovizCinsi1 = ""
                                lDovizKuru1 = 0
                                lDovizMiktari1 = 0
                                sDovizCinsi2 = ""
                                lDovizKuru2 = 0
                                lDovizMiktari2 = 0
                                lGirenMiktar = Math.Abs(dr1("lCikisMiktar1"))
                                lCikanMiktar = 0
                                nFisSiraID = tbMuhasebeFisi_kaydet_yeni(nFisSiraID, dteFisTarihi, sMuhFisTipi, lFisNo, lYevmiyeNo, nHesapID, sAciklama, lGirenMiktar, lCikanMiktar, lBorcTutar, lAlacakTutar, sMasrafYontemi, nKasaID, sHangiUygulama, sHareketTipi, nCariHareketID, kullaniciadi, Now, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, nSatir, sSubeMagaza, kullaniciadi, Now)
                                nFisSiraID_degistir(nFisSiraID)
                                'Ticari Mal Hesapla
                                sHesapKodu = "153-0001-" & sayiuzunlukkontrol(Trim(dr1("sStokKodu")), 7)
                                sHesapAciklama = dr1("sStokAciklama")
                                nHesapID = sorgula_nStokID("Select nHesapID from tbHesapPlani Where sKodu = '" & sHesapKodu & "'")
                                If nHesapID = 0 Then
                                    nHesapID = tbHesapPlani_kaydet_yeni(sHesapKodu, sHesapAciklama, "", 0, "", 0, "", "", 0, "SA", Now)
                                End If
                                nFisSiraID = sorgu_nFisSiraID()
                                lBorcTutar = 0
                                lAlacakTutar = dr1("lMaliyet") * dr1("lCikisMiktar1")
                                sDovizCinsi1 = ""
                                lDovizKuru1 = 0
                                lDovizMiktari1 = 0
                                sDovizCinsi2 = ""
                                lDovizKuru2 = 0
                                lDovizMiktari2 = 0
                                lGirenMiktar = 0
                                lCikanMiktar = dr1("lCikisMiktar1")
                                nFisSiraID = tbMuhasebeFisi_kaydet_yeni(nFisSiraID, dteFisTarihi, sMuhFisTipi, lFisNo, lYevmiyeNo, nHesapID, sAciklama, lGirenMiktar, lCikanMiktar, lBorcTutar, lAlacakTutar, sMasrafYontemi, nKasaID, sHangiUygulama, sHareketTipi, nCariHareketID, kullaniciadi, Now, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, nSatir, sSubeMagaza, kullaniciadi, Now)
                                nFisSiraID_degistir(nFisSiraID)
                            End If
                        End If
                    ElseIf Trim(dr1("sFisTipi")) = "FA" Then
                        If dr1("nStokTipi") = 4 Then
                            sHesapKodu = "611-0001-" & dr1("sStokKodu")
                            sHesapAciklama = dr1("sStokAciklama")
                        ElseIf dr1("nStokTipi") = 6 Then
                            sHesapKodu = "760-0009-" & dr1("sStokKodu")
                            sHesapAciklama = dr1("sStokAciklama")
                        Else
                            sHesapKodu = "153-0001-" & dr1("sStokKodu")
                            sHesapAciklama = dr1("sStokAciklama")
                        End If
                        nHesapID = sorgula_nStokID("Select nHesapID from tbHesapPlani Where sKodu = '" & sHesapKodu & "'")
                        If nHesapID = 0 Then
                            nHesapID = tbHesapPlani_kaydet_yeni(sHesapKodu, sHesapAciklama, "", 0, "", 0, "", "", 0, "SA", Now)
                        End If
                        'Alışı İşle
                        nHesapID = sorgula_nStokID("Select nHesapID from tbHesapPlani Where sKodu = '" & sHesapKodu & "'")
                        If nHesapID = 0 Then
                            nHesapID = tbHesapPlani_kaydet_yeni(sHesapKodu, sHesapAciklama, "", 0, "", 0, "", "", 0, "SA", Now)
                        End If
                        nFisSiraID = sorgu_nFisSiraID()
                        If dr1("lGirisMiktar1") > 0 Then
                            lBorcTutar = dr1("lBrutTutar")
                            lAlacakTutar = 0
                            lGirenMiktar = dr1("lGirisMiktar1")
                            lCikanMiktar = 0
                        ElseIf dr1("lGirisMiktar1") < 0 Then
                            lAlacakTutar = dr1("lBrutTutar")
                            lBorcTutar = 0
                            lGirenMiktar = 0
                            lCikanMiktar = dr1("lGirisMiktar1")
                        End If
                        sDovizCinsi1 = ""
                        lDovizKuru1 = 0
                        lDovizMiktari1 = 0
                        sDovizCinsi2 = ""
                        lDovizKuru2 = 0
                        lDovizMiktari2 = 0
                        nFisSiraID = tbMuhasebeFisi_kaydet_yeni(nFisSiraID, dteFisTarihi, sMuhFisTipi, lFisNo, lYevmiyeNo, nHesapID, sAciklama, lGirenMiktar, lCikanMiktar, lBorcTutar, lAlacakTutar, sMasrafYontemi, nKasaID, sHangiUygulama, sHareketTipi, nCariHareketID, kullaniciadi, Now, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, nSatir, sSubeMagaza, kullaniciadi, Now)
                        nFisSiraID_degistir(nFisSiraID)
                        'İskontoyu İşle
                        If Math.Abs(dr1("lIskontoTutari")) > 0 Then
                            sHesapKodu = "649-0001-" & sayiuzunlukkontrol(Trim(dr1("sStokKodu")), 7)
                            sHesapAciklama = dr1("sStokAciklama")
                            nHesapID = sorgula_nStokID("Select nHesapID from tbHesapPlani Where sKodu = '" & sHesapKodu & "'")
                            If nHesapID = 0 Then
                                nHesapID = tbHesapPlani_kaydet_yeni(sHesapKodu, sHesapAciklama, "", 0, "", 0, "", "", 0, "SA", Now)
                            End If
                            nFisSiraID = sorgu_nFisSiraID()
                            lBorcTutar = 0
                            lAlacakTutar = Math.Abs(dr1("lIskontoTutari"))
                            sDovizCinsi1 = ""
                            lDovizKuru1 = 0
                            lDovizMiktari1 = 0
                            sDovizCinsi2 = ""
                            lDovizKuru2 = 0
                            lDovizMiktari2 = 0
                            lGirenMiktar = 0
                            lCikanMiktar = 0
                            nFisSiraID = tbMuhasebeFisi_kaydet_yeni(nFisSiraID, dteFisTarihi, sMuhFisTipi, lFisNo, lYevmiyeNo, nHesapID, sAciklama, lGirenMiktar, lCikanMiktar, lBorcTutar, lAlacakTutar, sMasrafYontemi, nKasaID, sHangiUygulama, sHareketTipi, nCariHareketID, kullaniciadi, Now, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, nSatir, sSubeMagaza, kullaniciadi, Now)
                            nFisSiraID_degistir(nFisSiraID)
                        End If
                        'Kdvyi İşle
                        If Math.Abs(dr1("lKdvTutari")) <> 0 Then
                            sHesapKodu = "191-0001-" & sayiuzunlukkontrol(CInt(dr1("nKdvOrani")), 7)
                            sHesapAciklama = "İndirilecek Kdv % " & CInt(dr1("nKdvOrani"))
                            nHesapID = sorgula_nStokID("Select nHesapID from tbHesapPlani Where sKodu = '" & sHesapKodu & "'")
                            If nHesapID = 0 Then
                                nHesapID = tbHesapPlani_kaydet_yeni(sHesapKodu, sHesapAciklama, "", 0, "", 0, "", "", 0, "SA", Now)
                            End If
                            nFisSiraID = sorgu_nFisSiraID()
                            lBorcTutar = dr1("lKdvTutari")
                            lAlacakTutar = 0
                            sDovizCinsi1 = ""
                            lDovizKuru1 = 0
                            lDovizMiktari1 = 0
                            sDovizCinsi2 = ""
                            lDovizKuru2 = 0
                            lDovizMiktari2 = 0
                            lGirenMiktar = 0
                            lCikanMiktar = 0
                            nFisSiraID = tbMuhasebeFisi_kaydet_yeni(nFisSiraID, dteFisTarihi, sMuhFisTipi, lFisNo, lYevmiyeNo, nHesapID, sAciklama, lGirenMiktar, lCikanMiktar, lBorcTutar, lAlacakTutar, sMasrafYontemi, nKasaID, sHangiUygulama, sHareketTipi, nCariHareketID, kullaniciadi, Now, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, nSatir, sSubeMagaza, kullaniciadi, Now)
                            nFisSiraID_degistir(nFisSiraID)
                        End If
                    End If
                Next
            Next
        End If
        lMuhasebeFisNo_degistir()
        Try
            tbMuhasebeFisi_Aciklamasi_kaydet_yeni(dteFisTarihi, sMuhFisTipi, lFisNo, "", "Entegre", sAciklamaNot3, "", "", 0)
        Catch ex As Exception
        End Try
        bar1.Position = 0
        bar1.Refresh()
        XtraMessageBox.Show(Sorgu_sDil("İşlem Başarıyla Tamamlandı", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Function tbHesapPlani_kaydet_yeni(ByVal sKodu As String, ByVal sAciklama As String, ByVal sAlterneAciklama As String, ByVal lBilancoSatiri As Decimal, ByVal sAktifPasif As String, ByVal lKarZararSatiri As Decimal, ByVal sKarZararGelirGider As String, ByVal sMasrafYontemi As String, ByVal bMiktarVar As Integer, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, Optional ByVal sDatabase As String = "") As Int64
        Dim use As String = ""
        If sDatabase <> "" Then
            use = "USE " & sDatabase
        End If
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("" & use & " SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(nHesapID, 0) AS nHesapID  FROM         tbHesapPlani Where sKodu = '" & sKodu & "' ")
        Dim kayitno = cmd.ExecuteScalar
        If Trim(kayitno) = "0" Or Trim(kayitno) = "" Then
            cmd.CommandText = sorgu_query("" & use & " SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbHesapPlani (sKodu, sAciklama, sAlterneAciklama, lBilancoSatiri, sAktifPasif, lKarZararSatiri, sKarZararGelirGider, sMasrafYontemi, bMiktarVar, sKullaniciAdi, dteKayitTarihi) VALUES     ('" & sKodu & "', '" & sAciklama & "', '" & sAlterneAciklama & "', " & lBilancoSatiri & ", '" & sAktifPasif & "', " & lKarZararSatiri & ", '" & sKarZararGelirGider & "', '" & sMasrafYontemi & "', " & bMiktarVar & ", '" & sKullaniciAdi & "', '" & dteKayitTarihi & "')")
            cmd.ExecuteNonQuery()
            cmd.CommandText = "select @@identity"
            kayitno = cmd.ExecuteScalar
        End If
        con.Close()
        Return kayitno
        cmd = Nothing
        con = Nothing
    End Function
    Private Function tbMuhasebeFisi_kaydet_yeni(ByVal nFisSiraID As String, ByVal dteFisTarihi As DateTime, ByVal sMuhFisTipi As Integer, ByVal lFisno As Int64, ByVal lYevmiyeNo As Int64, ByVal nHesapID As Int64, ByVal sAciklama As String, ByVal lGirenMiktar As Decimal, ByVal lCikanMiktar As Decimal, ByVal lBorcTutar As Decimal, ByVal lAlacakTutar As Decimal, ByVal sMasrafYontemi As String, ByVal nKasaID As Int64, ByVal sHangiUygulama As String, ByVal sHareketTipi As String, ByVal nCariHareketID As Int64, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal sDovizCinsi1 As String, ByVal lDovizMiktari1 As Decimal, ByVal lDovizKuru1 As Decimal, ByVal sDovizCinsi2 As String, ByVal lDovizMiktari2 As Decimal, ByVal lDovizKuru2 As Decimal, ByVal nSatir As Int64, ByVal sSubeMagaza As String, ByVal sSonKullaniciAdi As String, ByVal dteSonUpdateTarihi As DateTime) As Int64
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbMuhasebeFisi ( dteFisTarihi, sMuhFisTipi, lFisno, lYevmiyeNo, nHesapID, sAciklama, lGirenMiktar, lCikanMiktar, lBorcTutar, lAlacakTutar,sMasrafYontemi, nKasaID, sHangiUygulama, sHareketTipi, nCariHareketID, sKullaniciAdi, dteKayitTarihi, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, nSatir, sSubeMagaza, sSonKullaniciAdi, dteSonUpdateTarihi) VALUES     ( '" & dteFisTarihi & "', '" & sMuhFisTipi & "', " & lFisno & ", " & lYevmiyeNo & ", " & nHesapID & ", N'" & sAciklama & "', " & lGirenMiktar & ", " & lCikanMiktar & ", " & lBorcTutar & ", " & lAlacakTutar & ", '" & sMasrafYontemi & "', " & nKasaID & ", '" & sHangiUygulama & "', '" & sHareketTipi & "', " & nCariHareketID & ", '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', '" & sDovizCinsi1 & "', " & lDovizMiktari1 & ", " & lDovizKuru1 & ", '" & sDovizCinsi2 & "', " & lDovizMiktari2 & ", " & lDovizKuru2 & ", " & nSatir & ", '" & sSubeMagaza & "', '" & sSonKullaniciAdi & "', '" & dteSonUpdateTarihi & "')")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        nFisSiraID = cmd.ExecuteScalar
        Return nFisSiraID
        con.Close()
    End Function
    Public Function sorgu_lMuhasebeFisNo() As Int64
        Dim kriter As String = ""
        'kriter = "WHERE (sKodu = '" & kod & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(lSonMahsupNo1, 1) AS lFisNo FROM         tbMuhasebeFisNo")
        Dim kayitsayisi = cmd.ExecuteScalar
        If kayitsayisi = 1 Then
            kayitsayisi = 2
        End If
        Return kayitsayisi
    End Function
    Public Function sorgu_nFisSiraID() As Int64
        'Dim kriter As String = ""
        ''kriter = "WHERE (sKodu = '" & kod & "')  "
        'Dim conn As New OleDb.OleDbConnection
        'Dim cmd As New OleDb.OleDbCommand
        'Dim adapter As New OleDb.OleDbDataAdapter
        ''MsgBox(connection_resmi)
        'conn.ConnectionString = connection
        'cmd.Connection = conn
        'conn.Open()
        'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     TOP 1 ISNULL(nFisSiraID + 1, 1) AS nFisSiraID FROM         tbMuhasebeFisi ORDER BY nFisSiraID DESC")
        'Dim kayitsayisi = cmd.ExecuteScalar
        'Return kayitsayisi
    End Function
    Private Sub nFisSiraID_degistir(ByVal nFisSiraID As String)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        con.ConnectionString = connection
        cmd.Connection = con
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbMuhasebeSiraNo SET              nSonID = '" & nFisSiraID & "' where nSiraIndex = 1")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub lMuhasebeFisNo_degistir()
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        con.ConnectionString = connection
        cmd.Connection = con
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbMuhasebeFisNo SET lSonMahsupNo1 = ISNULL((SELECT TOP 1 ISNULL(lFisno + 1 , 1) AS lFisNo FROM tbMuhasebeFisi WHERE (sMuhFisTipi = 3) Order by lFisNo desc),1)")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub GibEntegrasyon_kaldir(ByVal nStokFisiID As Long, ByVal kullaniciadi As String)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter

        con.ConnectionString = connection
        cmd.Connection = con

        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        cmd.CommandText = sorgu_query(
        "SET DATEFORMAT DMY " &
        "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED " &
        "UPDATE tbStokFisiMaster SET " &
        "bMuhasebeyeIslendimi = 0, " &
        "bFaturayaDonustumu = 0, " &
        "bFisTamamlandimi = 0, " &
        "nEfaturaDurum = 'Gib Entegrasyon İptal Edildi " & kullaniciadi.Replace("'", "''") & "' " &
        "Where nStokFisiID = " & nStokFisiID
    )

        cmd.ExecuteNonQuery()
        con.Close()
    End Sub

    Private Sub tbMuhasebeFisi_Aciklamasi_kaydet_yeni(ByVal dteFisTarihi As DateTime, ByVal sMuhFisTipi As String, ByVal lFisno As Int64, ByVal sAciklama1 As String, ByVal sAciklama2 As String, ByVal sAciklama3 As String, ByVal sAciklama4 As String, ByVal sAciklama5 As String, ByVal bKilitli As Byte)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY  INSERT INTO tbMuhasebeFisiAciklamasi (dteFisTarihi, sMuhFisTipi, lFisno, sAciklama1, sAciklama2, sAciklama3, sAciklama4, sAciklama5, bKilitli) VALUES     ('" & dteFisTarihi & "', '" & sMuhFisTipi & "', " & lFisno & ", '" & sAciklama1 & "', '" & sAciklama2 & "', '" & sAciklama3 & "', '" & sAciklama4 & "', '" & sAciklama5 & "'," & bKilitli & " )")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbStokFisiMaster_kaydet_sil(ByVal nStokFisiID As String, ByVal sFisTipi As String)
        Dim nKasaIslemID As Int64 = sorgula_nStokID("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Select nKasaIslemID from tbStokFisiMaster where nStokFisiID = " & nStokFisiID & "")
        If sorgu_sayi(nKasaIslemID, 0) <> 0 Then
            tbNakitKasa_kaydet_sil(nKasaIslemID, 0)
        End If
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.CommandTimeout = Nothing
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        'If dr_baslik("nKasaIslemID").ToString <> "" Then
        '    tbNakitKasa_kaydet_sil(dr_baslik("nKasaIslemID").ToString, 0)
        '    'dr_baslik("nKasaIslemID") = ""
        'End If
        cmd.CommandText = sorgu_query("set implicit_transactions on")
        cmd.ExecuteNonQuery()
        Try
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE FROM tbFirmaHareketi WHERE     (nHareketID IN (SELECT     nCariHareketID FROM          tbStokFisiOdemePlani WHERE      (nStokFisiID = '" & nStokFisiID & "')))")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE FROM tbStokFisiOdemePlani WHERE     (nStokFisiID = '" & nStokFisiID & "')")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE FROM tbStokFisiPesinAdres WHERE     (nStokFisiID = '" & nStokFisiID & "')")
            cmd.ExecuteNonQuery()
            If sFisTipi = "PF" Then
                cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbAlisverisSiparis SET              nStokIslemID = NULL, dteTeslimEdilen = '01/01/1900',dteOnayTarihi = '01/01/1900', bTeslimEdildi = 0 WHERE     (nStokIslemID IN (SELECT     nIslemID FROM          tbStokFisiDetayi WHERE      nStokFisiID = '" & nStokFisiID & "' ))")
                cmd.ExecuteNonQuery()
                'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbAlisverisSiparis SET nStokIslemID = NULL , dteTeslimEdilen = '01/01/1900' ,dteOnayTarihi = '01/01/1900', bTeslimEdildi = 0 WHERE nStokIslemID IN ( SELECT nIslemID FROM tbStokFisiDetayi WHERE nStokFisiID = '" & nStokFisiID & "') SELECT DISTINCT nStokFisiID INTO #tempSilTrans FROM tbStokFisiDetayi , ( SELECT DISTINCT dteFistarihi , lFisno FROM tbStokFisiMaster , ( SELECT DISTINCT nIrsaliyeFisiID FROM tbStokFisiDetayi WHERE nStokFisiID = '" & nStokFisiID & "' ) AS Irsaliye WHERE Irsaliye.nIrsaliyeFisiID =tbStokFisiMaster.nStokFisiID ) AS TempIrs WHERE tbStokFisiDetayi.sFisTipi= 'T' AND tbStokFisiDetayi.dteFisTarihi = TempIrs.dteFisTarihi AND tbStokFisiDetayi.lFisno = TempIrs.lFisno AND tbStokFisiDetayi.sHangiUygulama = 'PI' DELETE tbStokFisiAciklamasi WHERE nStokFisiID IN ( SELECT * FROM #tempSilTrans) DELETE tbStokFisiDetayi WHERE nStokFisiID IN ( SELECT * FROM #tempSilTrans) DELETE tbStokFisiMaster WHERE nStokFisiID IN ( SELECT * FROM #tempSilTrans) DROP TABLE #tempSilTrans SELECT DISTINCT nStokFisiID INTO #tempSilTrans1 FROM tbStokFisiDetayi , ( SELECT DISTINCT dteFistarihi , lFisno FROM tbStokFisiMaster WHERE nStokFisiID = '" & nStokFisiID & "' ) AS TempIrs WHERE tbStokFisiDetayi.sFisTipi= 'T' AND tbStokFisiDetayi.dteFisTarihi = TempIrs.dteFisTarihi AND tbStokFisiDetayi.lFisno = TempIrs.lFisno AND tbStokFisiDetayi.sHangiUygulama = 'PI' DELETE tbStokFisiAciklamasi WHERE nStokFisiID IN ( SELECT * FROM #tempSilTrans1) DELETE tbStokFisiDetayi WHERE nStokFisiID IN ( SELECT * FROM #tempSilTrans1) DELETE tbStokFisiMaster WHERE nStokFisiID IN ( SELECT * FROM #tempSilTrans1) DROP TABLE #tempSilTrans1 DELETE tbRafHareketi FROM tbStokFisidetayi WHERE tbRafHareketi.nIslemID = tbStokFisidetayi.nIslemID AND nStokFisiID = '" & nStokFisiID & "' SELECT DISTINCT nIrsaliyeFisiID INTO #temp1 FROM tbStokFisiDetayi WHERE nStokFisiID = '" & nStokFisiID & "' DELETE tbStokFisiDetayi WHERE nStokFisiID = '" & nStokFisiID & "' DELETE tbStokFisiOdemePlani WHERE nStokFisiID IN ( SELECT * FROM #temp1 WHERE nIrsaliyeFisiID IS NOT NULL) DELETE tbStokFisiAciklamasi WHERE nStokFisiID IN ( SELECT * FROM #temp1 WHERE nIrsaliyeFisiID IS NOT NULL) DELETE tbStokFisiMaster WHERE nStokFisiID IN ( SELECT * FROM #temp1 WHERE nIrsaliyeFisiID IS NOT NULL) DROP TABLE #Temp1 ")
                'cmd.ExecuteNonQuery()
            End If
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE FROM tbStokFisiAciklamasi WHERE     (nStokFisiID = '" & nStokFisiID & "')")
            cmd.ExecuteNonQuery()
            If Trim(sFisTipi) <> "IA" Or Trim(sFisTipi) <> "IS" Then
                cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE FROM tbStokFisiDetayi WHERE     (nStokFisiID = '" & nStokFisiID & "') AND (nIrsaliyeFisiID IS NULL)")
                cmd.ExecuteNonQuery()
                cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbStokFisiMaster SET              bFaturayaDonustumu = 0 WHERE     (nStokFisiID IN (SELECT DISTINCT nIrsaliyeFisiID FROM          tbStokFisiDetayi WHERE      nStokFisiID = '" & nStokFisiID & "'))")
                cmd.ExecuteNonQuery()
                cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbStokFisiDetayi SET              sFisTipi = 'IA', dteFisTarihi = dteIrsaliyeTarihi, lFisNo = lIrsaliyeNo, nStokFisiID = nIrsaliyeFisiID WHERE     (nStokFisiID = '" & nStokFisiID & "')")
                cmd.ExecuteNonQuery()
            ElseIf Trim(sFisTipi) = "IA" Or Trim(sFisTipi) = "IS" Then
                'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE FROM tbStokFisiDetayi WHERE     (nStokFisiID = '" & nStokFisiID & "')")
                'cmd.ExecuteNonQuery()
            End If
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE FROM tbStokFisiDetayi WHERE     (nStokFisiID = '" & nStokFisiID & "')")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE FROM tbStokFisiMaster WHERE     (nStokFisiID = '" & nStokFisiID & "')")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("IF @@TRANCOUNT > 0 COMMIT TRAN")
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            cmd.CommandText = sorgu_query("IF @@TRANCOUNT > 0 COMMIT TRAN")
            cmd.ExecuteNonQuery()
            XtraMessageBox.Show(Sorgu_sDil("İşlem Hatası Lütfen Tekrar Deneyiniz...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
        cmd.CommandText = sorgu_query("set implicit_transactions off")
        cmd.ExecuteNonQuery()
        Try
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE FROM tbStokFisiSeriNo WHERE     (nStokFisiID = '" & nStokFisiID & "')")
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try
        Try
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE FROM tbStokFisiEkMaliyet WHERE     (nStokFisiID = '" & nStokFisiID & "')")
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        ' E-Ticaret sipariş kaydını orders tablosundan sil (eğer varsa)
        Try
            ' Önce siparişin e-ticaret siparişi olup olmadığını kontrol et
            Dim cmdCheck As New OleDb.OleDbCommand()
            cmdCheck.Connection = cmd.Connection
            cmdCheck.CommandText = sorgu_query("SELECT sAciklama3 FROM tbStokFisiAciklamasi WHERE nStokFisiID = '" & nStokFisiID & "'")
            Dim siparisKodu As Object = cmdCheck.ExecuteScalar()

            If siparisKodu IsNot Nothing AndAlso siparisKodu IsNot DBNull.Value Then
                Dim kod As String = siparisKodu.ToString().Trim()
                ' E-ticaret sipariş kodu kontrolü (TY, HB ile başlıyor veya sadece sayı)
                If kod.StartsWith("TY") OrElse kod.StartsWith("HB") OrElse IsNumeric(kod) Then
                    ' orders tablosundan sil
                    cmd.CommandText = sorgu_query("DELETE FROM orders WHERE ID IN (SELECT ID FROM orders WHERE randStr LIKE '%" & kod & "%' OR CAST(ID AS NVARCHAR(50)) = '" & kod.Replace("TY", "").Replace("HB", "") & "')")
                    cmd.ExecuteNonQuery()

                    ' fis_detay tablosundan sil
                    cmd.CommandText = sorgu_query("DELETE FROM fis_detay WHERE fisID LIKE '%" & kod & "%'")
                    cmd.ExecuteNonQuery()
                End If
            End If
        Catch ex As Exception
            ' orders veya fis_detay tablosu olmayabilir, hatayı görmezden gel
        End Try

        ' Audit Log - Stok Fişi Master Silme
        Try
            Dim recordId As Long = 0
            Try : recordId = CLng(nStokFisiID) : Catch : End Try
            AuditLogger.LogDelete(
                AuditLogger.ModulAdi.FATURA,
                "tbStokFisiMaster",
                recordId,
                "Stok Fişi Master silindi (Tip: " & sFisTipi & ")",
                Nothing
            )
        Catch ex As Exception
            ' Log hatası işlemi durdurmasın
        End Try

        con.Close()
        con.Dispose()
        cmd.Dispose()
        con = Nothing
        cmd = Nothing
    End Sub
    Private Sub tbNakitKasa_kaydet_sil(ByVal nKasaIslemID As String, ByVal nCariHareketID As String)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Select TOP 1 ISNULL(nCariHareketID,0) From tbNakitKasa Where nKasaIslemID = '" & nKasaIslemID & "' ")
        nCariHareketID = cmd.ExecuteScalar
        cmd.CommandText = sorgu_query("set implicit_transactions on")
        cmd.ExecuteNonQuery()
        Try
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED ")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("DELETE FROM tbNakitKasa Where nKasaIslemID = '" & nKasaIslemID & "'")
            cmd.ExecuteNonQuery()
            If nCariHareketID > 0 Then
                cmd.CommandText = sorgu_query("DELETE FROM tbFirmaHareketi Where nHareketID = '" & nCariHareketID & "'")
                cmd.ExecuteNonQuery()
            End If
            cmd.CommandText = sorgu_query("IF @@TRANCOUNT > 0 COMMIT TRAN")
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            cmd.CommandText = sorgu_query("IF @@TRANCOUNT > 0 COMMIT TRAN")
            cmd.ExecuteNonQuery()
            XtraMessageBox.Show(Sorgu_sDil("İşlem Hatası Lütfen Tekrar Deneyiniz...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbCariSiraNo SET nSonID = (SELECT TOP 1 ISNULL(nHareketID + 1 , 1) AS nSonID FROM tbFirmaHareketi ORDER BY nHareketID DESC) WHERE (nSiraIndex = 1)")
        cmd.ExecuteNonQuery()

        ' Audit Log - Nakit Kasa Silme
        Try
            Dim recordId As Long = 0
            Try : recordId = CLng(nKasaIslemID) : Catch : End Try
            AuditLogger.LogDelete(
                AuditLogger.ModulAdi.FATURA,
                "tbNakitKasa",
                recordId,
                "Nakit Kasa silindi",
                Nothing
            )
        Catch ex As Exception
            ' Log hatası işlemi durdurmasın
        End Try

        con.Close()
        con.Dispose()
        cmd.Dispose()
        con = Nothing
        cmd = Nothing
    End Sub
    Private Sub kayit_sil()
        If GridView1.RowCount > 0 Then
            If XtraMessageBox.Show(Sorgu_sDil("Seçili Kayıtları Silmek İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
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
                    bar1.Properties.Maximum = GridView1.SelectedRowsCount
                    'panelstatus.Visible = True
                    bar1.Visible = True
                    bar1.Position = 0
                    For Each i In arr
                        s = i.ToString
                        dr1 = GridView1.GetDataRow(s)
                        tbStokFisiMaster_kaydet_sil(dr1("nStokFisiID"), Trim(dr1("sFisTipi")))
                        If Trim(dr1("sFisTipi")) = "T" Then
                            tbStokFisiMaster_kaydet_sil(dr1("lTransferFisiID"), Trim(dr1("sFisTipi")))
                        End If
                        bar1.Position += 1
                        bar1.Refresh()
                    Next
                    XtraMessageBox.Show(Sorgu_sDil("İşlem Başarıyla Tamamlandı...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'panelstatus.Visible = False
                    bar1.Visible = False
                End If
                dr1 = Nothing
                ara()
            End If
        End If
    End Sub
    Private Sub MenuItem44_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem44.Click
        Group_Muhasebelestir.Visible = True
        sec_sMuhasebeIslemTuru.Text = "Muhasebeleştirme"
        txt_dteEntegreTarihi.EditValue = dteSistemTarihi
        sec_sMuhasebeEntegrasyonTuru.Focus()
        sec_sMuhasebeEntegrasyonTuru.Select()
    End Sub
    Private Sub MenuItem45_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem45.Click
        Group_Muhasebelestir.Visible = True
        sec_sMuhasebeIslemTuru.Text = "Entegrasyon İptal"
        txt_dteEntegreTarihi.EditValue = dteSistemTarihi
        sec_sMuhasebeEntegrasyonTuru.Focus()
        sec_sMuhasebeEntegrasyonTuru.Select()
    End Sub
    Private Sub BarButtonItem12_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem12.ItemClick
        If sec_resmi.Checked = False Then
            sec_resmi.Checked = True
        ElseIf sec_resmi.Checked = True Then
            sec_resmi.Checked = False
        End If
    End Sub
    Private Sub MenuItem46_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem46.Click
        If kullanici > 3 Then
            XtraMessageBox.Show(Sorgu_sDil("Üzgünüm Yetkiniz Yok, Sistem Yönetinizle Görüşünüz...!", sDil), Sorgu_sDil("Dikkat", sDil))
        Else
            kayit_sil()
        End If
    End Sub
    Private Sub BarButtonItem3_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        If kullanici > 3 Then
            XtraMessageBox.Show(Sorgu_sDil("Üzgünüm Yetkiniz Yok, Sistem Yönetinizle Görüşünüz...!", sDil), Sorgu_sDil("Dikkat", sDil))
        Else
            kayit_sil()
        End If
    End Sub
    Friend WithEvents colsYazdirma As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsOnizleme As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsBelgeTipi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnEvrakNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BarButtonItem13 As DevExpress.XtraBars.BarButtonItem
    Private Sub BarButtonItem13_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem13.ItemClick
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            If Trim(dr("sFisTipi").ToString()) = "FS" Or Trim(dr("sFisTipi").ToString()) = "FA" Then
                If MuhasebeFisiVarMi(dr("lFisNo").ToString(), "3") > 0 Then
                    Dim frm As New frm_tbMuhasebeFisi
                    frm.firmano = firmano
                    frm.donemno = donemno
                    frm.connection = connection
                    frm.dteFisTarihi = dr("dteFisTarihi")
                    frm.lFisNo = dr("lFisNo")
                    frm.bMuhasabe = True
                    frm.sMuhFisTipi = "3"
                    frm.kullanici = kullanici
                    If yetki_kontrol(kullanici, frm.Name) = True Then
                        frm.ShowDialog()
                    End If
                    frm.Close()
                    frm.Dispose()
                    frm = Nothing
                End If
            End If
        End If
    End Sub
    Friend WithEvents colsSinifKodu1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsSinifKodu2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsCariSinif3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MenuItem48 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem49 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem50 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem51 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem52 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem53 As System.Windows.Forms.MenuItem

    Private Sub MenuItem51_Click(sender As Object, e As EventArgs) Handles MenuItem51.Click
        zirve_entegre()
    End Sub

    Private Sub MenuItem53_Click(sender As Object, e As EventArgs) Handles MenuItem53.Click
        logo_entegre()
    End Sub

    Private Sub MenuItem49_Click(sender As Object, e As EventArgs) Handles MenuItem49.Click
        mikro_entegre()
    End Sub
    Friend WithEvents sec_Aktar As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents coldteVadeTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsAciklama1 As DevExpress.XtraGrid.Columns.GridColumn
    Public Sub GibTopluFaturaGonder(GridView1 As DevExpress.XtraGrid.Views.Grid.GridView, connection As String)
        Try
            ' E-Fatura entegrasyonu açık mı?
            Dim sEentegrasyon As String = ""
            Using con As New OleDb.OleDbConnection(connection)
                con.Open()
                Using cmd As New OleDb.OleDbCommand("SELECT EfaturaEntegre FROM tbParamGenel", con)
                    sEentegrasyon = Convert.ToString(cmd.ExecuteScalar())
                End Using
            End Using

            If sEentegrasyon Is Nothing OrElse sEentegrasyon.Trim().ToLower() <> "true" Then
                MsgBox("E-Fatura entegrasyonu açık değil!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            ' Seçimler
            Dim selectedRows() As Integer = GridView1.GetSelectedRows()
            If selectedRows Is Nothing OrElse selectedRows.Length = 0 Then
                MsgBox("Lütfen göndermek için fiş seçiniz.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            Dim total As Integer = selectedRows.Length
            Dim sentCount As Integer = 0
            Dim alreadyCount As Integer = 0
            Dim errorCount As Integer = 0

            For Each rowHandle As Integer In selectedRows
                Dim dr As DataRow = GridView1.GetDataRow(rowHandle)
                If dr Is Nothing Then Continue For ' grup satırı olabilir

                Dim nStokFisiID As Integer = Convert.ToInt32(dr("nStokFisiID"))
                Dim donustu As Boolean = False
                Dim sEvrakNo As String = ""

                ' Durum kontrolü
                Try
                    Using con As New OleDb.OleDbConnection(connection)
                        con.Open()
                        Using cmd As New OleDb.OleDbCommand("SELECT bFaturayaDonustumu, nEvrakNo FROM tbStokFisiMaster WHERE nStokFisiID = ?", con)
                            cmd.Parameters.AddWithValue("@p0", nStokFisiID)
                            Using rdr = cmd.ExecuteReader()
                                If rdr.Read() Then
                                    donustu = Convert.ToBoolean(rdr("bFaturayaDonustumu"))
                                    sEvrakNo = If(IsDBNull(rdr("nEvrakNo")), "", rdr("nEvrakNo").ToString())
                                End If
                            End Using
                        End Using
                    End Using
                Catch ex As Exception
                    errorCount += 1
                    MsgBox("Fiş kontrolünde hata: " & ex.Message, MsgBoxStyle.Exclamation)
                    Continue For
                End Try

                If donustu Then
                    alreadyCount += 1
                    MsgBox(sEvrakNo & " numaralı fiş daha önce GİB'e gönderilmiş.", MsgBoxStyle.Information)
                    Continue For
                End If

                ' Gönderim
                Try
                    ' Eğer FaturaGonder bir Function değil de Sub ise:
                    ' Başarılı saymayı Try bloğuna almak en kolayı
                    FaturaGonder(nStokFisiID)
                    sentCount += 1
                Catch ex As Exception
                    errorCount += 1
                    MsgBox($"Fiş {nStokFisiID} gönderiminde hata: {ex.Message}", MsgBoxStyle.Critical)
                    ' burada istersen log'a da yazabilirsin
                End Try
            Next

            ' Özet/son mesaj (duruma göre)
            If sentCount > 0 Then
                Dim msg As String = $"Toplam {total} fişten {sentCount} gönderildi"
                If alreadyCount > 0 Then msg &= $", {alreadyCount} fiş zaten gönderilmişti"
                If errorCount > 0 Then msg &= $", {errorCount} fişte hata oluştu"
                msg &= "."
                MsgBox(msg, MsgBoxStyle.Information)
            ElseIf alreadyCount = total Then
                MsgBox("Seçili fişlerin tamamı daha önce GİB'e gönderilmiş.", MsgBoxStyle.Information)
            ElseIf errorCount = total Then
                MsgBox("Seçili fişlerin hiçbirini gönderemedik. Ayrıntılar için logları kontrol edin.", MsgBoxStyle.Critical)
            Else
                ' ne gönderim var ne hepsi önceden gönderilmiş: muhtemelen sadece hatalar oldu
                MsgBox($"{errorCount} fişte hata oluştu, gönderim yapılamadı.", MsgBoxStyle.Exclamation)
            End If

        Catch ex As Exception
            MsgBox("Toplu gönderim sırasında beklenmeyen hata: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Friend WithEvents MenuItem55 As MenuItem

    Private Sub MenuItem55_Click(sender As Object, e As EventArgs) Handles MenuItem55.Click
        GibTopluFaturaGonder(GridView1, connection)
    End Sub
    Public Sub GelenEFaturalariAlVeIsle()
        Try
            ' === VERİTABANI BAĞLANTISI VE PARAMETRELERİ AL ===
            Dim con As New OleDb.OleDbConnection(connection)
            Dim cmd As New OleDb.OleDbCommand("SELECT TOP 1 * FROM tbParamGenel", con)
            con.Open()
            Dim drParam = cmd.ExecuteReader()
            Dim gibUser As String = ""
            Dim gibPass As String = ""
            If drParam.Read() Then
                gibUser = drParam("GibKullanici").ToString().Trim()
                gibPass = drParam("GibSifre").ToString().Trim()
            End If
            con.Close()

            ' === FATURA TARİH ARALIĞINI BELİRLE ===
            Dim startDate As String = Convert.ToDateTime(txt_dteFisTarihi1.EditValue).AddDays(-7).ToString("yyyy-MM-dd")
            Dim endDate As String = Convert.ToDateTime(txt_dteFisTarihi2.EditValue).ToString("yyyy-MM-dd")
            Dim withXML As String = "XML"
            Dim minRecordId As String = ""
            Dim documentType As String = "1" ' sadece faturalar
            Dim queried As String = "ALL"
            Dim takenFromEntegrator As String = "NO"
            ' === SERVİS BAĞLANTISI VE FATURA LİSTESİNİ AL ===
            Dim client As New business_smart.eFaturaGelen.LoadInvoiceWSClient("LoadInvoiceWSPort1")
            client.ClientCredentials.UserName.UserName = gibUser
            client.ClientCredentials.UserName.Password = gibPass
            Dim response As business_smart.eFaturaGelen.DocumentQueryResponse = client.QueryInboxDocumentsWithDocumentDate(startDate, endDate, withXML, minRecordId)
            If response Is Nothing OrElse response.documents Is Nothing Then Exit Sub

            Dim faturaListesi As business_smart.eFaturaGelen.ResponseDocument() = response.documents

            ' === TÜM GELEN FATURALARI İŞLE ===
            For Each fatura As business_smart.eFaturaGelen.ResponseDocument In faturaListesi
                Dim documentUUID As String = fatura.document_uuid

                ' === FATURA DAHA ÖNCE KAYDEDİLMİŞ Mİ KONTROL ET ===
                con.Open()
                cmd = New OleDb.OleDbCommand("SELECT COUNT(*) FROM tbStokFisiMaster WHERE sEfaturaGuid = ?", con)
                cmd.Parameters.AddWithValue("@p1", documentUUID)
                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                con.Close()
                If count > 0 Then Continue For

                ' === XML İÇERİĞİNİ YÜKLE VE GEREKLİ ALANLARI ÇEK ===
                Dim firmaID As Integer = -1
                Dim xmlData As String = Encoding.UTF8.GetString(fatura.document_content)
                Dim xmlDoc As New XmlDocument()
                xmlDoc.LoadXml(xmlData)

                Dim nsMgr As New XmlNamespaceManager(xmlDoc.NameTable)
                nsMgr.AddNamespace("cac", "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")
                nsMgr.AddNamespace("cbc", "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")

                ' === XML’DEN FİRMA BİLGİLERİNİ AL ===
                Dim firmaUnvanNode As XmlNode = xmlDoc.SelectSingleNode("//cac:AccountingSupplierParty/cac:Party/cac:PartyName/cbc:Name", nsMgr)
                Dim adresNode As XmlNode = xmlDoc.SelectSingleNode("//cac:AccountingSupplierParty/cac:Party/cac:PostalAddress", nsMgr)
                Dim telefonNode As XmlNode = xmlDoc.SelectSingleNode("//cac:AccountingSupplierParty/cac:Party/cac:Contact/cbc:Telephone", nsMgr)
                Dim emailNode As XmlNode = xmlDoc.SelectSingleNode("//cac:AccountingSupplierParty/cac:Party/cac:Contact/cbc:ElectronicMail", nsMgr)
                Dim vergiDaireNode As XmlNode = xmlDoc.SelectSingleNode("//cac:AccountingSupplierParty/cac:Party/cac:PartyTaxScheme/cbc:TaxSchemeName", nsMgr)
                Dim vknNode As XmlNode = xmlDoc.SelectSingleNode("//cac:AccountingSupplierParty/cac:Party/cac:PartyIdentification/cbc:ID", nsMgr)

                ' === FATURA BAŞLIK BİLGİLERİNİ AL ===
                Dim evrakNo As String = xmlDoc.SelectSingleNode("//cbc:ID", nsMgr)?.InnerText.Trim()
                Dim faturaTarihi As Date = Date.Parse(xmlDoc.SelectSingleNode("//cbc:IssueDate", nsMgr)?.InnerText.Trim())

                ' === FATURA KALEM BİLGİLERİNİ AL ===
                Dim kalemler = xmlDoc.SelectNodes("//cac:InvoiceLine", nsMgr)

                ' === DEĞERLERİ PARSE ET ===
                Dim firmaAdi As String = If(firmaUnvanNode?.InnerText, "").Trim()
                Dim adres As String = If(adresNode?.SelectSingleNode("cbc:StreetName", nsMgr)?.InnerText, "").Trim()
                Dim ilce As String = If(adresNode?.SelectSingleNode("cbc:CitySubdivisionName", nsMgr)?.InnerText, "").Trim()
                Dim il As String = If(adresNode?.SelectSingleNode("cbc:CityName", nsMgr)?.InnerText, "").Trim()
                Dim postaKodu As String = If(adresNode?.SelectSingleNode("cbc:PostalZone", nsMgr)?.InnerText, "").Trim()
                Dim telefon As String = If(telefonNode?.InnerText, "").Trim()
                Dim email As String = If(emailNode?.InnerText, "").Trim()
                Dim vergiDairesi As String = If(vergiDaireNode?.InnerText, "").Trim()
                Dim vknXml As String = If(vknNode?.InnerText, "").Trim()

                ' === Varsa Firma Al
                con.Open()
                cmd = New OleDbCommand("SELECT nFirmaID FROM tbFirma WHERE sVergiNo = ?", con)
                cmd.Parameters.AddWithValue("@p1", vknXml)
                Dim dr As OleDbDataReader = cmd.ExecuteReader()
                If dr.Read() Then
                    firmaID = Convert.ToInt32(dr("nFirmaID"))
                    dr.Close()
                Else
                    dr.Close()


                    ' === sKodu ve hesap oluştur ===
                    Dim bugun As String = Date.Now.ToString("dd.MM.yyyy")
                    Dim ilKodu As String = GetIlKodu(il)
                    Dim prefix As String = "320" & ilKodu
                    cmd = New OleDbCommand("SELECT MAX(sKodu) FROM tbFirma WHERE sKodu LIKE ?", con)
                    cmd.Parameters.AddWithValue("@p1", prefix & "%")
                    Dim maxSiraObj = cmd.ExecuteScalar()
                    Dim yeniSira As Integer = 1
                    If Not IsDBNull(maxSiraObj) AndAlso maxSiraObj IsNot Nothing Then
                        Dim maxSiraStr As String = maxSiraObj.ToString()
                        If maxSiraStr.Length > prefix.Length Then
                            yeniSira = Val(maxSiraStr.Substring(prefix.Length)) + 1
                        End If
                    End If
                    Dim sKodu As String = prefix & yeniSira.ToString("D3")

                    ' === tbHesapPlani kaydı
                    cmd = New OleDbCommand("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED 
INSERT INTO tbHesapPlani (sKodu, sAciklama, sAlterneAciklama, lBilancoSatiri, sAktifPasif, lKarZararSatiri, 
sKarZararGelirGider, sMasrafYontemi, bMiktarVar, sKullaniciAdi, dteKayitTarihi) 
VALUES (?, ?, '', 0, '', 0, '', '', 0, '1', ?)", con)

                    cmd.Parameters.AddWithValue("@p1", sKodu)
                    cmd.Parameters.AddWithValue("@p2", firmaAdi)
                    cmd.Parameters.AddWithValue("@p3", bugun)
                    cmd.ExecuteNonQuery()

                    ' === nHesapID'yi al
                    cmd = New OleDbCommand("SELECT nHesapID FROM tbHesapPlani WHERE sKodu = ?", con)
                    cmd.Parameters.AddWithValue("@p1", sKodu)
                    Dim nHesapID As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                    ' === tbFirma kaydı
                    cmd = New OleDbCommand("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED 
INSERT INTO tbFirma 
(sKodu, sAciklama, TC, nOzelIskontosu, lKrediLimiti, dteMutabakatTarihi, nVadeGun, sHitap, 
sAdres1, sAdres2, sSemt, sIl, sUlke, sPostaKodu, sVergiDairesi, sVergiNo, nHesapID, 
sOzelNot, sKullaniciAdi, dteKayitTarihi, sFiyatTipi, sSaticiRumuzu, nOzelIskontosu2, 
nOzelIskontosu3, nOzelIskontosu4, bAktif, bSatisYapilamaz, bSipariseKapali, 
bTahsilatYapilamaz, sDovizCinsi, nEnlem, nBoylam, nZiyaret, nPeriyod, 
sDepo, sCariHesapTuru, sEfatura) 
VALUES (?, ?, ?, 0.00, 0.00, '01/01/1990', 0, N'Sayın', ?, N' ', ?, ?, N' ', ?, ?, ?, 
N'0000000', 'sa', ?, N'3   ', N'', 0.00, 0.00, 0.00, 1, 0, 0, 0, N'   ', 0.00000000, 0.00000000, 
0000000, 0, N'D001', 'webCari','False')", con)

                    cmd.Parameters.AddWithValue("@p1", sKodu)
                    cmd.Parameters.AddWithValue("@p2", firmaAdi)
                    cmd.Parameters.AddWithValue("@p3", vknXml)
                    cmd.Parameters.AddWithValue("@p4", adres)
                    cmd.Parameters.AddWithValue("@p5", ilce)
                    cmd.Parameters.AddWithValue("@p6", il)
                    cmd.Parameters.AddWithValue("@p7", postaKodu)
                    cmd.Parameters.AddWithValue("@p8", vergiDairesi)
                    cmd.Parameters.AddWithValue("@p9", vknXml)
                    cmd.Parameters.AddWithValue("@p10", nHesapID)
                    cmd.Parameters.AddWithValue("@p11", bugun)
                    cmd.ExecuteNonQuery()
                End If
                ' === Yeni eklenen nFirmaID'yi al
                cmd = New OleDbCommand("SELECT @@IDENTITY", con)
                firmaID = Convert.ToInt32(cmd.ExecuteScalar())
                ' === İletişim: Gsm
                If Not String.IsNullOrEmpty(telefon) Then
                    cmd = New OleDbCommand("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbFirmaIletisimi (nFirmaID, sIletisimAraci, sIletisimAdresi) VALUES (?, 'Gsm', ?)", con)
                    cmd.Parameters.AddWithValue("@p1", nFirmaID)
                    cmd.Parameters.AddWithValue("@p2", telefon)
                    cmd.ExecuteNonQuery()
                End If

                ' === İletişim: E-Mail
                If Not String.IsNullOrEmpty(email) Then
                    cmd = New OleDbCommand("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbFirmaIletisimi (nFirmaID, sIletisimAraci, sIletisimAdresi) VALUES (?, 'E-Mail', ?)", con)
                    cmd.Parameters.AddWithValue("@p1", nFirmaID)
                    cmd.Parameters.AddWithValue("@p2", email)
                    cmd.ExecuteNonQuery()
                End If

                ' === Firma Sınıfları
                cmd = New OleDbCommand("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbFirmaSinifi (nFirmaID, sSinifKodu1, sSinifKodu2, sSinifKodu3, sSinifKodu4, sSinifKodu5) VALUES (?, '', '', '', '', '')", con)
                cmd.Parameters.AddWithValue("@p1", nFirmaID)
                cmd.ExecuteNonQuery()
                con.Close()

                ' === FATURA BAŞLIK INSERT (TEK SORGU İLE) ===
                con.Open()
                cmd = New OleDb.OleDbCommand("SET DATEFORMAT DMY; INSERT INTO tbStokFisiMaster (sFisTipi, dteFisTarihi, dteTeslimTarihi, nGirisCikis, lFisNo, nFirmaID, sDepo, dteValorTarihi, bPesinmi, bListelendimi, bHizmetFaturasimi, lToplamMiktar, lMalBedeli, lMalIskontoTutari, nDipIskontoYuzdesi1, lDipIskontoTutari1, nDipIskontoYuzdesi2, lDipIskontoTutari2, lDipIskontoTutari3, lEkmaliyet1, lEkmaliyet2, lEkmaliyet3, nKdvOrani1, lKdvMatrahi1, lKdv1, nKdvOrani2, lKdvMatrahi2, lKdv2, nKdvOrani3, lKdvMatrahi3, lKdv3, nKdvOrani4, lKdvMatrahi4, lKdv4,  nKdvOrani5, lKdvMatrahi5, lKdv5, lNetTutar, nTevkifatKdvOrani, lTevkifatKdvMatrahi, lTevkifatKdv, sHareketTipi, bMuhasebeyeIslendimi, bFisTamamlandimi, lTransferFisiID,  sTransferDepo, bFaturayaDonustumu, sKullaniciAdi, dteKayitTarihi, sYaziIle, nOTVOrani1, lOTVMatrahi1, lOTV1, nOTVOrani2, lOTVMatrahi2, lOTV2,bKilitli,nEvrakNo, sEfaturaGuid, sEfaturaTipi, bFaturaTipi, sKdvMuafiyetKodu, nTasimaSekli, lBrutAgirlik, lNetAgirlik, nPaketSayisi, sPaketTipi, sGumrukCikisNo, sTeslimatUlke) VALUES ('FS ', ?, ?, 3 , 0, ?, 'D001', ?, 0 , 0 , 0 , 0 , 0, 0 , 0 , 0 , 0 , 0 , 0 , 0 , 0 , 0 , 0, 0 , 0, 0 , 0, 0 , 0, 0 , 0, 0 , 0 , 0 , 0 , 0 , 0 , 0 , 0, 0 ,  '001 ', 0, 0, '0',  '', 0 , 'Admin', ?, '', 0, 0, 0, 0 , 0, 0,0, ?, ?, ?, '', '', 0, 0, 0, 0, '', '', '') ", con)
                cmd.Parameters.AddWithValue("@p1", faturaTarihi)
                cmd.Parameters.AddWithValue("@p2", faturaTarihi)
                cmd.Parameters.AddWithValue("@p3", firmaID)
                cmd.Parameters.AddWithValue("@p4", faturaTarihi)
                cmd.Parameters.AddWithValue("@p5", DateTime.Now)
                cmd.Parameters.AddWithValue("@p6", evrakNo)
                cmd.Parameters.AddWithValue("@p7", documentUUID)
                cmd.Parameters.AddWithValue("@p8", "Gelen EFatura")
                cmd.ExecuteNonQuery()

                ' === YENİ FATURA ID'SİNİ AL ===
                cmd = New OleDb.OleDbCommand("SELECT @@IDENTITY", con)
                Dim stokFisiID As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                ' === FATURA AÇIKLAMASINI EKLE ===
                cmd = New OleDb.OleDbCommand("SET DATEFORMAT DMY INSERT INTO tbStokFisiAciklamasi (nStokFisiID, sAciklama1, sAciklama2, sAciklama3, sAciklama4, sAciklama5) VALUES (?, '', '', '', '', '')", con)
                cmd.Parameters.AddWithValue("@p1", stokFisiID)
                cmd.ExecuteNonQuery()

                ' === FİŞ KİLİDİNİ EKLE ===
                cmd = New OleDb.OleDbCommand("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbFisKilit (nKayitID, sFisTipi, sKullanici, dteKayitTarihi) VALUES (?, 'FS', '1', ?)", con)
                cmd.Parameters.AddWithValue("@p1", stokFisiID)
                cmd.Parameters.AddWithValue("@p2", DateTime.Now)
                cmd.ExecuteNonQuery()


                ' === FATURA KALEMLERİNİ EKLE ===
                ' === FATURA KALEMLERİNİ EKLE VE STOK SIRA GÜNCELLE ===
                For Each kalem As XmlNode In kalemler
                    Dim miktarNode As XmlNode = kalem.SelectSingleNode("cbc:InvoicedQuantity", nsMgr)
                    Dim birimFiyatNode As XmlNode = kalem.SelectSingleNode("cac:Price/cbc:PriceAmount", nsMgr)
                    Dim toplamTutarNode As XmlNode = kalem.SelectSingleNode("cbc:LineExtensionAmount", nsMgr)
                    Dim stokAdiNode As XmlNode = kalem.SelectSingleNode("cac:Item/cbc:Name", nsMgr)
                    Dim kdvNode As XmlNode = kalem.SelectSingleNode("cac:TaxTotal/cac:TaxSubtotal/cbc:Percent", nsMgr)

                    Dim miktar As Decimal = If(miktarNode IsNot Nothing, Convert.ToDecimal(miktarNode.InnerText, Globalization.CultureInfo.InvariantCulture), 0)
                    Dim birimFiyat As Decimal = If(birimFiyatNode IsNot Nothing, Convert.ToDecimal(birimFiyatNode.InnerText, Globalization.CultureInfo.InvariantCulture), 0)
                    Dim toplamTutar As Decimal = If(toplamTutarNode IsNot Nothing, Convert.ToDecimal(toplamTutarNode.InnerText, Globalization.CultureInfo.InvariantCulture), 0)
                    Dim stokAdi As String = If(stokAdiNode IsNot Nothing, stokAdiNode.InnerText.Trim(), "")
                    Dim kdv As Decimal = If(kdvNode IsNot Nothing, Convert.ToDecimal(kdvNode.InnerText, Globalization.CultureInfo.InvariantCulture), 0)

                    ' İlgili stokID çekilebilir, şu anda sabit olarak 0
                    Dim stokID As Integer = 0

                    ' === INSERT INTO tbStokFisiDetayi ===
                    cmd = New OleDbCommand("
        SET DATEFORMAT DMY 
        SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED 
        INSERT INTO tbStokFisiDetayi 
        (nStokID, dteIslemTarihi, nFirmaID, nMusteriID, sFisTipi, dteFisTarihi, lFisNo, nGirisCikis, sDepo, 
         lReyonFisNo, sStokIslem, sKasiyerRumuzu, sSaticiRumuzu, sOdemeKodu, dteIrsaliyeTarihi, lIrsaliyeNo, 
         lGirisMiktar1, lGirisMiktar2, lGirisFiyat, lGirisTutar, lCikisMiktar1, lCikisMiktar2, 
         lCikisFiyat, lCikisTutar, sFiyatTipi, sBirimCinsi, lBirimMiktar, lBrutFiyat, lBrutTutar, 
         lMaliyetFiyat, lMaliyetTutar, lIlaveMaliyetTutar, nIskontoYuzdesi, lIskontoTutari, 
         sDovizCinsi, lDovizFiyat, nSiparisID, nReceteNo, nTransferID, sTransferDepo, nKdvOrani, 
         nHesapID, sAciklama, sHareketTipi, bMuhasebeyeIslendimi, sKullaniciAdi, dteKayitTarihi, 
         sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, 
         nOTVOrani, nTransferFirmaID, nAlisverisID, nStokFisiID, nIrsaliyeFisiID, sMasrafYontemi, 
         sHangiUygulama, nEkSaha1, nEkSaha2, bEkSoru1, bEkSoru2, sSonKullaniciAdi, 
         dteSonUpdateTarihi, nPrim, lPrimTutari) 
        VALUES (?, ?, ?, 0, 'FS ', ?, 0, 3, 'D001', 0, '', '', '100', '', ?, 0, 0, 0, 0, 0, ?, 0, ?, ?, 
                '3', 'AD ', 1, ?, ?, 0, 0, 0, 0, 0, '   ', 0, NULL, 0, NULL, '', ?, 0, 
                'Isk1:00.00 Isk2:00.00', '001 ', 0, ?, ?, '', 0, 0, '', 0, 0, ?, NULL, '', 'FS ', 
                0, 0, 0, 0, 'Admin', ?, 0, 0)
    ", con)

                    cmd.Parameters.AddWithValue("@p1", stokID)
                    cmd.Parameters.AddWithValue("@p2", faturaTarihi)
                    cmd.Parameters.AddWithValue("@p3", firmaID)
                    cmd.Parameters.AddWithValue("@p4", faturaTarihi)
                    cmd.Parameters.AddWithValue("@p5", faturaTarihi)
                    cmd.Parameters.AddWithValue("@p6", miktar)
                    cmd.Parameters.AddWithValue("@p7", birimFiyat)
                    cmd.Parameters.AddWithValue("@p8", toplamTutar)
                    cmd.Parameters.AddWithValue("@p9", birimFiyat)
                    cmd.Parameters.AddWithValue("@p10", toplamTutar)
                    cmd.Parameters.AddWithValue("@p11", birimFiyat)
                    cmd.Parameters.AddWithValue("@p12", toplamTutar)
                    cmd.Parameters.AddWithValue("@p13", kdv)
                    cmd.Parameters.AddWithValue("@p14", stokAdi)
                    cmd.Parameters.AddWithValue("@p15", DateTime.Now)
                    cmd.Parameters.AddWithValue("@p16", stokFisiID)
                    cmd.Parameters.AddWithValue("@p17", DateTime.Now)
                    cmd.ExecuteNonQuery()

                    ' === nStokIslemID güncelle
                    cmd = New OleDbCommand("SELECT @@IDENTITY", con)
                    Dim stokIslemID As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                    cmd = New OleDbCommand("
        SET DATEFORMAT DMY 
        SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED 
        UPDATE tbStokSiraNo SET nSonID = ? WHERE nSiraIndex = 1", con)
                    cmd.Parameters.AddWithValue("@p1", stokIslemID)
                    cmd.ExecuteNonQuery()
                Next
                ' === Faturalar alındı olarak işaretleniyor ===
                'Dim uuidList As New List(Of String)
                'For Each fatura2 As business_smart.eFaturaGelen.ResponseDocument In faturaListesi
                '    uuidList.Add(fatura2.document_uuid)
                'Next
                'client.SetTakenFromEntegrator(uuidList.ToArray())
            Next
        Catch ex As Exception
            MsgBox("Hata oluştu: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Function GetIlKodu(il As String) As String
        Dim ilKodlari As New Dictionary(Of String, String)(StringComparer.OrdinalIgnoreCase) From {
        {"Adana", "01"},
        {"Adıyaman", "02"},
        {"Afyonkarahisar", "03"},
        {"Ağrı", "04"},
        {"Amasya", "05"},
        {"Ankara", "06"},
        {"Antalya", "07"},
        {"Artvin", "08"},
        {"Aydın", "09"},
        {"Balıkesir", "10"},
        {"Bilecik", "11"},
        {"Bingöl", "12"},
        {"Bitlis", "13"},
        {"Bolu", "14"},
        {"Burdur", "15"},
        {"Bursa", "16"},
        {"Çanakkale", "17"},
        {"Çankırı", "18"},
        {"Çorum", "19"},
        {"Denizli", "20"},
        {"Diyarbakır", "21"},
        {"Edirne", "22"},
        {"Elazığ", "23"},
        {"Erzincan", "24"},
        {"Erzurum", "25"},
        {"Eskişehir", "26"},
        {"Gaziantep", "27"},
        {"Giresun", "28"},
        {"Gümüşhane", "29"},
        {"Hakkari", "30"},
        {"Hatay", "31"},
        {"Isparta", "32"},
        {"Mersin", "33"},
        {"İstanbul", "34"},
        {"İzmir", "35"},
        {"Kars", "36"},
        {"Kastamonu", "37"},
        {"Kayseri", "38"},
        {"Kırklareli", "39"},
        {"Kırşehir", "40"},
        {"Kocaeli", "41"},
        {"Konya", "42"},
        {"Kütahya", "43"},
        {"Malatya", "44"},
        {"Manisa", "45"},
        {"Kahramanmaraş", "46"},
        {"Mardin", "47"},
        {"Muğla", "48"},
        {"Muş", "49"},
        {"Nevşehir", "50"},
        {"Niğde", "51"},
        {"Ordu", "52"},
        {"Rize", "53"},
        {"Sakarya", "54"},
        {"Samsun", "55"},
        {"Siirt", "56"},
        {"Sinop", "57"},
        {"Sivas", "58"},
        {"Tekirdağ", "59"},
        {"Tokat", "60"},
        {"Trabzon", "61"},
        {"Tunceli", "62"},
        {"Şanlıurfa", "63"},
        {"Uşak", "64"},
        {"Van", "65"},
        {"Yozgat", "66"},
        {"Zonguldak", "67"},
        {"Aksaray", "68"},
        {"Bayburt", "69"},
        {"Karaman", "70"},
        {"Kırıkkale", "71"},
        {"Batman", "72"},
        {"Şırnak", "73"},
        {"Bartın", "74"},
        {"Ardahan", "75"},
        {"Iğdır", "76"},
        {"Yalova", "77"},
        {"Karabük", "78"},
        {"Kilis", "79"},
        {"Osmaniye", "80"},
        {"Düzce", "81"}
    }

        If ilKodlari.ContainsKey(il.Trim()) Then
            Return ilKodlari(il.Trim())
        Else
            Return "00" ' Bilinmeyen il için varsayılan
        End If
    End Function
    Friend WithEvents MenuItem54 As MenuItem

    Private Sub MenuItem54_Click(sender As Object, e As EventArgs) Handles MenuItem54.Click
        GelenEFaturalariAlVeIsle()
    End Sub

    Friend WithEvents colGibFaturaNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsEfaturaUrl As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MenuItem56 As MenuItem
    Friend WithEvents MenuItem57 As MenuItem ' Pazaryeri Fatura Gönder
    Friend WithEvents MenuItem58 As MenuItem ' Toplu Tarih Değiştir
    Friend WithEvents MenuItem59 As MenuItem ' Toplu Maliyet Güncelle
    Private Sub MenuItem56_Click(sender As Object, e As EventArgs) Handles MenuItem56.Click
        Dim selectedRows() As Integer = GridView1.GetSelectedRows()
        If selectedRows.Length = 0 Then
            MsgBox("Lütfen bir belge seçin!")
            Exit Sub
        End If

        Try
            Dim nStokFisiID As Long = CLng(GridView1.GetRowCellValue(selectedRows(0), "nStokFisiID"))
            Dim uuid As String = Guid.NewGuid().ToString().ToUpper()
            Dim xmlYolu As String = "C:\EFatura\Sablonlar\gidenFatura_" & uuid & ".xml"
            Dim htmlYolu As String = IO.Path.ChangeExtension(xmlYolu, ".html")

            ' XML oluştur
            Dim result As String = XmlOlustur(nStokFisiID)
            If String.IsNullOrEmpty(result) Then
                MsgBox("XML oluşturma başarısız!")
                Exit Sub
            End If
            Directory.CreateDirectory(Path.GetDirectoryName(xmlYolu))
            File.WriteAllText(xmlYolu, result, New UTF8Encoding(False))

            ' XSLT seçimi (e-Fatura / e-Arşiv)
            Dim efaturaMusterisi As Boolean = result.Contains("TICARIFATURA")
            Dim xsltPath As String = If(efaturaMusterisi,
                                    "C:\EFatura\Sablonlar\E-Fatura.xslt",
                                    "C:\EFatura\Sablonlar\E-Arsiv.xslt")

            ' XML -> HTML dönüştür
            Dim xmlDoc As New XmlDocument()
            xmlDoc.Load(xmlYolu)

            Dim xslt As New XslCompiledTransform()
            xslt.Load(xsltPath)

            Using writer As New XmlTextWriter(htmlYolu, New UTF8Encoding(False))
                xslt.Transform(xmlDoc, writer)
            End Using

            ' HTML'i varsayılan tarayıcıda aç
            Process.Start(New ProcessStartInfo(htmlYolu) With {.UseShellExecute = True})

        Catch ex As Exception
            MsgBox("HTML görüntüleme sırasında hata: " & ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Pazaryeri Fatura Gönder menü öğesi tıklandığında
    ''' Önce GİB'e gönderilmemişse GİB'e gönderir, sonra pazaryerine gönderir
    ''' </summary>
    Private Sub MenuItem57_Click(sender As Object, e As EventArgs) Handles MenuItem57.Click
        Dim selectedRows() As Integer = GridView1.GetSelectedRows()
        If selectedRows.Length = 0 Then
            MsgBox("Lütfen fatura seçin!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Try
            Dim basarili As Integer = 0
            Dim basarisiz As Integer = 0
            Dim gibGonderilen As Integer = 0

            For Each rowHandle As Integer In selectedRows
                Dim nStokFisiID As Long = CLng(GridView1.GetRowCellValue(rowHandle, "nStokFisiID"))
                Dim gibFaturaNo As String = ""
                Dim siparisNo As String = ""

                ' GİB Fatura No'yu kontrol et
                Dim gibFaturaNoObj As Object = GridView1.GetRowCellValue(rowHandle, "GibFaturaNo")
                If gibFaturaNoObj IsNot Nothing AndAlso gibFaturaNoObj IsNot DBNull.Value Then
                    gibFaturaNo = gibFaturaNoObj.ToString().Trim()
                End If

                ' Sipariş No'yu al (pazaryeri siparişi mi kontrol et)
                Dim siparisNoObj As Object = GridView1.GetRowCellValue(rowHandle, "sAciklama3")
                If siparisNoObj IsNot Nothing AndAlso siparisNoObj IsNot DBNull.Value Then
                    siparisNo = siparisNoObj.ToString().Trim()
                End If

                ' Pazaryeri siparişi değilse atla
                If String.IsNullOrEmpty(siparisNo) OrElse
                   (Not siparisNo.StartsWith("TY") AndAlso Not siparisNo.StartsWith("HB") AndAlso Not siparisNo.StartsWith("N11")) Then
                    Continue For
                End If

                ' GİB'e gönderilmemişse önce GİB'e gönder
                If String.IsNullOrEmpty(gibFaturaNo) Then
                    Try
                        Dim sonuc As String = FaturaGonder(nStokFisiID)
                        If Not String.IsNullOrEmpty(sonuc) AndAlso Not sonuc.ToLower().Contains("hata") Then
                            gibGonderilen += 1
                            gibFaturaNo = sonuc
                        Else
                            basarisiz += 1
                            Continue For
                        End If
                    Catch ex As Exception
                        basarisiz += 1
                        Continue For
                    End Try
                End If

                basarili += 1
            Next

            ' Pazaryeri gönderim formunu aç
            Dim frm As New frm_PazaryeriFaturaGonderim()
            frm.connection = Me.connection
            frm.ShowDialog()

            ' Listeyi yenile (ara fonksiyonu ile)
            ara()

            If gibGonderilen > 0 Then
                MsgBox("GİB'e gönderilen: " & gibGonderilen & vbCrLf &
                       "İşlem tamamlandı.", MsgBoxStyle.Information)
            End If

        Catch ex As Exception
            MsgBox("Pazaryeri Fatura Gönderim hatası: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    ''' <summary>
    ''' Toplu Tarih Değiştir menü öğesi tıklandığında
    ''' Seçili faturaların dteFisTarihi, dteValorTarihi, dteTeslimTarihi alanlarını değiştirir
    ''' </summary>
    Private Sub MenuItem58_Click(sender As Object, e As EventArgs) Handles MenuItem58.Click
        Dim selectedRows() As Integer = GridView1.GetSelectedRows()
        If selectedRows.Length = 0 Then
            MsgBox("Lütfen en az bir fatura seçin!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Try
            ' Tarih seçim formu oluştur
            Using frmTarih As New Form()
                frmTarih.Text = "Toplu Tarih Değiştir"
                frmTarih.Size = New Size(350, 200)
                frmTarih.StartPosition = FormStartPosition.CenterParent
                frmTarih.FormBorderStyle = FormBorderStyle.FixedDialog
                frmTarih.MaximizeBox = False
                frmTarih.MinimizeBox = False

                Dim lblBilgi As New Label()
                lblBilgi.Text = selectedRows.Length & " adet fatura seçildi." & vbCrLf & "Yeni tarihi seçin:"
                lblBilgi.Location = New Point(20, 20)
                lblBilgi.Size = New Size(300, 40)
                frmTarih.Controls.Add(lblBilgi)

                Dim dtpYeniTarih As New DateTimePicker()
                dtpYeniTarih.Location = New Point(20, 70)
                dtpYeniTarih.Size = New Size(200, 25)
                dtpYeniTarih.Format = DateTimePickerFormat.Short
                dtpYeniTarih.Value = DateTime.Today
                frmTarih.Controls.Add(dtpYeniTarih)

                Dim btnUygula As New Button()
                btnUygula.Text = "Uygula"
                btnUygula.Location = New Point(20, 110)
                btnUygula.Size = New Size(100, 30)
                btnUygula.DialogResult = DialogResult.OK
                frmTarih.Controls.Add(btnUygula)

                Dim btnIptal As New Button()
                btnIptal.Text = "İptal"
                btnIptal.Location = New Point(130, 110)
                btnIptal.Size = New Size(100, 30)
                btnIptal.DialogResult = DialogResult.Cancel
                frmTarih.Controls.Add(btnIptal)

                frmTarih.AcceptButton = btnUygula
                frmTarih.CancelButton = btnIptal

                If frmTarih.ShowDialog() = DialogResult.OK Then
                    Dim yeniTarih As DateTime = dtpYeniTarih.Value.Date
                    Dim guncellenen As Integer = 0

                    Using con As New OleDbConnection(connection)
                        con.Open()

                        For Each rowHandle As Integer In selectedRows
                            Dim nStokFisiID As Long = CLng(GridView1.GetRowCellValue(rowHandle, "nStokFisiID"))

                            ' 1. tbStokFisiMaster güncelle
                            Using cmd As New OleDbCommand("UPDATE tbStokFisiMaster SET " &
                                "dteFisTarihi = ?, " &
                                "dteValorTarihi = ?, " &
                                "dteTeslimTarihi = ? " &
                                "WHERE nStokFisiID = ?", con)

                                cmd.Parameters.Add("@dteFisTarihi", OleDbType.Date).Value = yeniTarih
                                cmd.Parameters.Add("@dteValorTarihi", OleDbType.Date).Value = yeniTarih
                                cmd.Parameters.Add("@dteTeslimTarihi", OleDbType.Date).Value = yeniTarih
                                cmd.Parameters.Add("@nStokFisiID", OleDbType.BigInt).Value = nStokFisiID

                                If cmd.ExecuteNonQuery() > 0 Then
                                    guncellenen += 1
                                End If
                            End Using

                            ' 2. tbStokFisiDetayi güncelle
                            Using cmdDetay As New OleDbCommand("UPDATE tbStokFisiDetayi SET " &
                                "dteIslemTarihi = ?, " &
                                "dteFisTarihi = ? " &
                                "WHERE nStokFisiID = ?", con)

                                cmdDetay.Parameters.Add("@dteIslemTarihi", OleDbType.Date).Value = yeniTarih
                                cmdDetay.Parameters.Add("@dteFisTarihi", OleDbType.Date).Value = yeniTarih
                                cmdDetay.Parameters.Add("@nStokFisiID", OleDbType.BigInt).Value = nStokFisiID

                                cmdDetay.ExecuteNonQuery()
                            End Using
                        Next

                    End Using

                    ' Listeyi yenile (ara fonksiyonu ile)
                    ara()

                    MsgBox(guncellenen & " adet faturanın tarihi güncellendi.", MsgBoxStyle.Information)
                End If
            End Using

        Catch ex As Exception
            MsgBox("Tarih değiştirme hatası: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    ' Toplu Maliyet Güncelle - seçilen faturalar için stok maliyet fiyatlarını günceller
    ' KDV dahil/hariç kontrolü yapılır
    Private Sub MenuItem59_Click(sender As Object, e As EventArgs) Handles MenuItem59.Click
        Dim selectedRows() As Integer = GridView1.GetSelectedRows()
        If selectedRows.Length = 0 Then
            MsgBox("Lütfen en az bir fatura seçin!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        ' Onay al
        If MsgBox(selectedRows.Length & " adet fatura için stok maliyetleri güncellenecek." & vbCrLf & vbCrLf &
                  "Alış fiyatı KDV dahil/hariç durumuna göre maliyet hesaplaması yapılacaktır." & vbCrLf & vbCrLf &
                  "Devam etmek istiyor musunuz?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Toplu Maliyet Güncelle") = MsgBoxResult.No Then
            Exit Sub
        End If

        Try
            Dim toplamGuncellenen As Integer = 0
            Dim toplamHata As Integer = 0

            ' Progress göster
            Dim frmProgress As New Form()
            frmProgress.Text = "Maliyetler Güncelleniyor..."
            frmProgress.Size = New Size(400, 150)
            frmProgress.StartPosition = FormStartPosition.CenterParent
            frmProgress.FormBorderStyle = FormBorderStyle.FixedDialog
            frmProgress.MaximizeBox = False
            frmProgress.MinimizeBox = False
            frmProgress.ControlBox = False

            Dim lblDurum As New Label()
            lblDurum.Location = New Point(20, 20)
            lblDurum.Size = New Size(350, 60)
            lblDurum.Text = "Hazırlanıyor..."
            frmProgress.Controls.Add(lblDurum)

            Dim progressBar As New System.Windows.Forms.ProgressBar()
            progressBar.Location = New Point(20, 80)
            progressBar.Size = New Size(350, 25)
            progressBar.Maximum = selectedRows.Length
            progressBar.Value = 0
            frmProgress.Controls.Add(progressBar)

            frmProgress.Show()
            Application.DoEvents()

            Using con As New OleDbConnection(connection)
                con.Open()

                Dim sayac As Integer = 0
                For Each rowHandle As Integer In selectedRows
                    sayac += 1
                    Dim nStokFisiID As Long = CLng(GridView1.GetRowCellValue(rowHandle, "nStokFisiID"))
                    Dim sFisTipi As String = GridView1.GetRowCellValue(rowHandle, "sFisTipi").ToString()
                    Dim lFisNo As String = GridView1.GetRowCellValue(rowHandle, "lFisNo").ToString()

                    lblDurum.Text = "İşleniyor: " & sayac & "/" & selectedRows.Length & vbCrLf & "Fiş No: " & lFisNo
                    progressBar.Value = sayac
                    Application.DoEvents()

                    Try
                        ' Bu fatura için maliyet güncelle
                        Dim guncellendi As Integer = TopluMaliyetGuncelle_Fatura(con, nStokFisiID, sFisTipi)
                        toplamGuncellenen += guncellendi
                    Catch ex As Exception
                        toplamHata += 1
                    End Try
                Next
            End Using

            frmProgress.Close()
            frmProgress.Dispose()

            MsgBox("Toplu maliyet güncelleme tamamlandı." & vbCrLf & vbCrLf &
                   "İşlenen Fatura: " & selectedRows.Length & vbCrLf &
                   "Güncellenen Stok: " & toplamGuncellenen & vbCrLf &
                   "Hata: " & toplamHata, MsgBoxStyle.Information, "Sonuç")

        Catch ex As Exception
            MsgBox("Maliyet güncelleme hatası: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    ' Tek bir fatura için maliyet güncelleme işlemi
    Private Function TopluMaliyetGuncelle_Fatura(ByVal con As OleDbConnection, ByVal nStokFisiID As Long, ByVal sFisTipi As String) As Integer
        Dim guncellenenSatir As Integer = 0

        ' Fatura master bilgilerini al (lEkMaliyet4 subquery ile hesaplanır)
        Dim dsFaturaMaster As New DataSet()
        Dim sqlMaster As String = "SELECT *, " &
            "(SELECT ISNULL(SUM(lTutar), 0) FROM tbStokFisiEkMaliyet WHERE nStokFisiID = tbStokFisiMaster.nStokFisiID AND nIslemID = 0) AS lEkMaliyet4 " &
            "FROM tbStokFisiMaster WHERE nStokFisiID = " & nStokFisiID
        Using cmdMaster As New OleDbCommand(sqlMaster, con)
            Dim daMaster As New OleDbDataAdapter(cmdMaster)
            daMaster.Fill(dsFaturaMaster, "Master")
        End Using

        If dsFaturaMaster.Tables(0).Rows.Count = 0 Then
            Return 0
        End If

        Dim drMaster As DataRow = dsFaturaMaster.Tables(0).Rows(0)
        Dim dteFisTarihi As DateTime = CType(drMaster("dteFisTarihi"), DateTime)

        ' Ek maliyet bilgilerini al
        Dim lEkmaliyet1 As Decimal = KeyCode.sorgu_sayi(drMaster("lEkmaliyet1"), 0)
        Dim lEkmaliyet3 As Decimal = KeyCode.sorgu_sayi(drMaster("lEkmaliyet3"), 0)
        Dim lEkmaliyet4 As Decimal = KeyCode.sorgu_sayi(drMaster("lEkMaliyet4"), 0)
        Dim lNetTutar As Decimal = KeyCode.sorgu_sayi(drMaster("lNetTutar"), 0)

        ' Alis fiyati KDV dahil mi kontrolu (tbFiyatTipi tablosundan)
        Dim bAlisKdvDahil As Boolean = False
        Try
            Using cmdKdv As New OleDbCommand("SELECT ISNULL(bKdvDahilmi, 0) FROM tbFiyatTipi WHERE RTRIM(sFiyatTipi) = '" & Trim(KeyCode.sFiyatA) & "'", con)
                Dim result = cmdKdv.ExecuteScalar()
                If result IsNot Nothing AndAlso result IsNot DBNull.Value Then
                    If TypeOf result Is Boolean Then
                        bAlisKdvDahil = CBool(result)
                    Else
                        bAlisKdvDahil = (Convert.ToInt32(result) <> 0)
                    End If
                End If
            End Using
        Catch exKdv As Exception
            bAlisKdvDahil = False
        End Try

        ' Fatura detaylarını al (lEkIlaveMaliyetTutar subquery ile hesaplanır)
        Dim dsFaturaDetay As New DataSet()
        Dim sqlDetay As String = "SELECT *, " &
            "(SELECT ISNULL(SUM(lTutar), 0) FROM tbStokFisiEkMaliyet WHERE nStokFisiID = tbStokFisiDetayi.nStokFisiID AND nIslemID = tbStokFisiDetayi.nIslemID) AS lEkIlaveMaliyetTutar " &
            "FROM tbStokFisiDetayi WHERE nStokFisiID = " & nStokFisiID
        Using cmdDetay As New OleDbCommand(sqlDetay, con)
            Dim daDetay As New OleDbDataAdapter(cmdDetay)
            daDetay.Fill(dsFaturaDetay, "Detay")
        End Using

        For Each drDetay As DataRow In dsFaturaDetay.Tables(0).Rows
            Try
                ' nMasrafSatiri kolonu sorguya dahil edilmiyor, varsayılan 0 kabul ediyoruz
                Dim nMasrafSatiri As Integer = 0
                Try
                    nMasrafSatiri = KeyCode.sorgu_sayi(drDetay("nMasrafSatiri"), 0)
                Catch
                    nMasrafSatiri = 0
                End Try
                Dim lBrutFiyat As Decimal = KeyCode.sorgu_sayi(drDetay("lBrutFiyat"), 0)

                If nMasrafSatiri = 0 And lBrutFiyat > 0.01 Then
                    Dim nStokID As Long = CLng(drDetay("nStokID"))
                    Dim lGirisMiktar1 As Decimal = KeyCode.sorgu_sayi(drDetay("lGirisMiktar1"), 1)
                    Dim lGirisTutar As Decimal = KeyCode.sorgu_sayi(drDetay("lGirisTutar"), 0)
                    Dim nKdvOrani As Decimal = KeyCode.sorgu_sayi(drDetay("nKdvOrani"), 0)
                    Dim lIlaveMaliyetTutar As Decimal = KeyCode.sorgu_sayi(drDetay("lIlaveMaliyetTutar"), 0)
                    Dim lEkIlaveMaliyetTutar As Decimal = KeyCode.sorgu_sayi(drDetay("lEkIlaveMaliyetTutar"), 0)
                    
                    ' İskonto tutarını al - Maliyet hesabında kullanılacak
                    Dim lIskontoTutari As Decimal = KeyCode.sorgu_sayi(drDetay("lIskontoTutari"), 0)
                    Dim lBrutTutar As Decimal = KeyCode.sorgu_sayi(drDetay("lBrutTutar"), 0)

                    ' Stok bilgilerini al
                    Dim dsStok As New DataSet()
                    Dim sqlStok As String = "SELECT nStokID, nStokTipi, nFiyatlandirma, sModel, sRenk, sBeden, sKdvTipi, " &
                        "(SELECT nKdvOrani FROM tbKdv WHERE sKdvTipi = tbStok.sKdvTipi) AS nStokKdvOrani " &
                        "FROM tbStok WHERE nStokID = " & nStokID
                    Using cmdStok As New OleDbCommand(sqlStok, con)
                        Dim daStok As New OleDbDataAdapter(cmdStok)
                        daStok.Fill(dsStok, "Stok")
                    End Using

                    If dsStok.Tables(0).Rows.Count > 0 Then
                        Dim drStok As DataRow = dsStok.Tables(0).Rows(0)
                        Dim nStokKdvOrani As Decimal = KeyCode.sorgu_sayi(drStok("nStokKdvOrani"), 0)

                        ' Maliyet ve Alis fiyati hesapla
                        ' ============================================================
                        ' bAlisKdvDahil = True  -> Alis fiyati - Iskonto + EkMaliyet
                        ' bAlisKdvDahil = False -> Alis fiyati + KDV - Iskonto + EkMaliyet
                        ' ============================================================
                        Dim maliyet As Decimal = 0
                        Dim alis As Decimal = 0
                        
                        ' Satir bazli ek maliyetleri hesapla
                        Dim lSatirEkMaliyet As Decimal = lIlaveMaliyetTutar + lEkIlaveMaliyetTutar
                        
                        ' Master seviyesindeki ek maliyetlerin bu satira dusen payini hesapla
                        Dim lNetTutarDetay As Decimal = lBrutTutar - lIskontoTutari
                        Dim lMasterEkMaliyetToplam As Decimal = lEkmaliyet1 + lEkmaliyet3 + lEkmaliyet4
                        Dim lMasterEkMaliyetPay As Decimal = 0
                        If lNetTutar > 0 AndAlso lMasterEkMaliyetToplam > 0 Then
                            lMasterEkMaliyetPay = (lNetTutarDetay / lNetTutar) * lMasterEkMaliyetToplam
                        End If
                        
                        Dim lToplamEkMaliyet As Decimal = lSatirEkMaliyet + lMasterEkMaliyetPay
                        
                        If bAlisKdvDahil = True Then
                            ' Alis fiyati KDV DAHIL girilmis - KDV ekleme
                            ' Formul: (AlisTutar - Iskonto + EkMaliyet) / Miktar
                            If lGirisMiktar1 > 0 Then
                                maliyet = (lBrutTutar - lIskontoTutari + lToplamEkMaliyet) / lGirisMiktar1
                            Else
                                maliyet = lBrutFiyat
                            End If
                            alis = maliyet
                        Else
                            ' Alis fiyati KDV HARIC girilmis - KDV sadece BrutTutar'a eklenir
                            ' Formul: (AlisTutar * (1 + KDV/100) - Iskonto + EkMaliyet) / Miktar
                            Dim lBrutTutarKdvli As Decimal = lBrutTutar * ((nKdvOrani + 100) / 100)
                            If lGirisMiktar1 > 0 Then
                                maliyet = (lBrutTutarKdvli - lIskontoTutari + lToplamEkMaliyet) / lGirisMiktar1
                            Else
                                maliyet = lBrutFiyat * ((nKdvOrani + 100) / 100)
                            End If
                            alis = maliyet
                        End If

                        ' Mevcut fiyatları sorgula
                        Dim fiyatMaliyet As Decimal = sorgu_stok_fiyat_local(KeyCode.sFiyatM, nStokID, "")
                        Dim fiyatAlis As Decimal = sorgu_stok_fiyat_local(KeyCode.sFiyatA, nStokID, "")

                        Dim nFiyatlandirma As Integer = KeyCode.sorgu_sayi(drStok("nFiyatlandirma"), 0)
                        Dim sModel As String = Trim(drStok("sModel").ToString())
                        Dim sRenk As String = Trim(drStok("sRenk").ToString())
                        Dim sBeden As String = Trim(drStok("sBeden").ToString())

                        ' Maliyetleri güncelle - orijinal frm_fatura.vb'deki gibi
                        If fiyatMaliyet = 0 Then
                            ekle_fiyat_local(nStokID, KeyCode.sFiyatM, maliyet, dteFisTarihi, KeyCode.kullaniciadi)
                            guncellenenSatir += 1
                        ElseIf fiyatMaliyet <> maliyet Then
                            duzelt_fiyat_local(nStokID, KeyCode.sFiyatM, maliyet, dteFisTarihi)
                            guncellenenSatir += 1
                        End If

                        ' Alışları güncelle - orijinal frm_fatura.vb'deki gibi
                        If fiyatAlis = 0 Then
                            ekle_fiyat_local(nStokID, KeyCode.sFiyatA, alis, dteFisTarihi, KeyCode.kullaniciadi)
                        ElseIf fiyatAlis <> alis Then
                            duzelt_fiyat_local(nStokID, KeyCode.sFiyatA, alis, dteFisTarihi)
                        End If
                    End If
                End If
            Catch
            End Try
        Next

        Return guncellenenSatir
    End Function

    ' Fiyat düzeltme yardımcı fonksiyonu
    Private Sub TopluMaliyet_FiyatDuzelt(ByVal con As OleDbConnection, ByVal nFiyatlandirma As Integer, ByVal sModel As String, ByVal sRenk As String, ByVal sBeden As String, ByVal sFiyatTipi As String, ByVal lFiyat As Decimal, ByVal dteFiyatTespitTarihi As DateTime, ByVal nStokID As Long)
        Try
            ' Boşlukları temizle
            sModel = Trim(Replace(sModel, " ", ""))
            sRenk = Trim(Replace(sRenk, " ", ""))
            sBeden = Trim(Replace(sBeden, " ", ""))

            Dim sql As String = ""

            If lFiyat = 0 Then
                If nFiyatlandirma = 0 Then
                    sql = "DELETE tbStokFiyati FROM tbStok WHERE tbStok.nStokID = tbStokFiyati.nStokID AND sFiyatTipi = '" & sFiyatTipi & "' AND RTRIM(LTRIM(sModel)) = '" & sModel & "'"
                ElseIf nFiyatlandirma = 1 Then
                    sql = "DELETE tbStokFiyati FROM tbStok WHERE tbStok.nStokID = tbStokFiyati.nStokID AND sFiyatTipi = '" & sFiyatTipi & "' AND RTRIM(LTRIM(sModel)) = '" & sModel & "' AND RTRIM(LTRIM(sRenk)) = '" & sRenk & "'"
                ElseIf nFiyatlandirma = 2 Then
                    sql = "DELETE tbStokFiyati FROM tbStok WHERE tbStok.nStokID = tbStokFiyati.nStokID AND sFiyatTipi = '" & sFiyatTipi & "' AND RTRIM(LTRIM(sModel)) = '" & sModel & "' AND RTRIM(LTRIM(sRenk)) = '" & sRenk & "' AND RTRIM(LTRIM(sBeden)) = '" & sBeden & "'"
                End If
            Else
                If nFiyatlandirma = 0 Then
                    sql = "UPDATE tbStokFiyati SET lFiyat = " & lFiyat.ToString().Replace(",", ".") & ", dteFiyatTespitTarihi = '" & dteFiyatTespitTarihi.ToString("yyyy-MM-dd") & "', dteKayitTarihi = GETDATE() FROM tbStok WHERE tbStok.nStokID = tbStokFiyati.nStokID AND sFiyatTipi = '" & sFiyatTipi & "' AND RTRIM(LTRIM(sModel)) = '" & sModel & "'"
                ElseIf nFiyatlandirma = 1 Then
                    sql = "UPDATE tbStokFiyati SET lFiyat = " & lFiyat.ToString().Replace(",", ".") & ", dteFiyatTespitTarihi = '" & dteFiyatTespitTarihi.ToString("yyyy-MM-dd") & "', dteKayitTarihi = GETDATE() FROM tbStok WHERE tbStok.nStokID = tbStokFiyati.nStokID AND sFiyatTipi = '" & sFiyatTipi & "' AND RTRIM(LTRIM(sModel)) = '" & sModel & "' AND RTRIM(LTRIM(sRenk)) = '" & sRenk & "'"
                ElseIf nFiyatlandirma = 2 Then
                    sql = "UPDATE tbStokFiyati SET lFiyat = " & lFiyat.ToString().Replace(",", ".") & ", dteFiyatTespitTarihi = '" & dteFiyatTespitTarihi.ToString("yyyy-MM-dd") & "', dteKayitTarihi = GETDATE() FROM tbStok WHERE tbStok.nStokID = tbStokFiyati.nStokID AND sFiyatTipi = '" & sFiyatTipi & "' AND RTRIM(LTRIM(sModel)) = '" & sModel & "' AND RTRIM(LTRIM(sRenk)) = '" & sRenk & "' AND RTRIM(LTRIM(sBeden)) = '" & sBeden & "'"
                End If
            End If

            If sql <> "" Then
                Using cmd As New OleDbCommand(sql, con)
                    cmd.ExecuteNonQuery()
                End Using
            End If

            ' Ayrıca doğrudan stok fiyatını da güncelle
            duzelt_fiyat_local(nStokID, sFiyatTipi, lFiyat, dteFiyatTespitTarihi)

        Catch ex As Exception
            ' Hata varsa sessizce devam et
        End Try
    End Sub

    ' Stok fiyat sorgulama - frm_fatura.vb'den alındı
    Private Function sorgu_stok_fiyat_local(ByVal fiyattipi As String, ByVal stokno As Int64, ByVal sDovizCinsi As String) As Decimal
        Dim kriter
        kriter = "WHERE     (sFiyatTipi = '" & fiyattipi & "') AND (nStokID = " & stokno & ")"
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        con.ConnectionString = connection
        cmd.Connection = con
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     lFiyat FROM         tbStokFiyati " & kriter & "")
        Dim sonuc As Decimal = 0
        Try
            sonuc = Convert.ToDecimal(cmd.ExecuteScalar())
        Catch ex As Exception
            sonuc = 0
        End Try
        con.Close()
        con.Dispose()
        cmd.Dispose()
        con = Nothing
        cmd = Nothing
        Return sonuc
    End Function

    ' Fiyat ekleme - frm_fatura.vb'den alındı
    Private Sub ekle_fiyat_local(ByVal stokno As Int64, ByVal fiyattipi As String, ByVal fiyat As Decimal, ByVal dteFiyatTespittarihi As DateTime, ByVal sKullaniciAdi As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        If fiyat = 0 Then
            cmd.CommandText = sorgu_query("DELETE FROM tbStokFiyati Where sFiyatTipi ='" & fiyattipi & "' and nStokID = " & stokno & " ")
        Else
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbStokFiyati (nStokID, sFiyatTipi, lFiyat, dteFiyatTespitTarihi, sKullaniciAdi, dteKayitTarihi) VALUES (" & stokno & ", '" & fiyattipi & "', " & fiyat & " ,'" & dteFiyatTespittarihi & "', '" & sKullaniciAdi & "', GETDATE())")
        End If
        cmd.ExecuteNonQuery()
        con.Close()
        con.Dispose()
        cmd.Dispose()
        con = Nothing
        cmd = Nothing
    End Sub

    ' Fiyat düzeltme - frm_fatura.vb'den alındı
    Private Sub duzelt_fiyat_local(ByVal stokno As Int64, ByVal fiyattipi As String, ByVal fiyat As Decimal, ByVal dteFiyatTespittarihi As DateTime)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY UPDATE tbStokFiyati SET lFiyat =" & fiyat & " , dteFiyatTespittarihi = '" & dteFiyatTespittarihi & "' where nStokID =" & stokno & " AND sFiyatTipi ='" & fiyattipi & "'")
        cmd.ExecuteNonQuery()
        con.Close()
        con.Dispose()
        cmd.Dispose()
        con = Nothing
        cmd = Nothing
    End Sub
End Class
