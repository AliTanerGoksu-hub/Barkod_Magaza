Imports Microsoft.Win32
Imports DevExpress.XtraEditors
Public Class frm_tbPersonel_Liste
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
    Friend WithEvents printlink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Label39 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton6 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents sec_ekstre_tarih2 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents sec_ekstre_tarih1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents PanelControl5 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents MenuItem17 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem18 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem19 As System.Windows.Forms.MenuItem
    Friend WithEvents lbl_Firma As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents MenuItem21 As System.Windows.Forms.MenuItem
    Friend WithEvents printlink2 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents printlink As DevExpress.XtraPrintingLinks.CompositeLink
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarDockControl1 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl2 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl3 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl4 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem6 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem7 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem8 As DevExpress.XtraBars.BarButtonItem
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
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sec_konum As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents sec_kriter As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txt_ara As DevExpress.XtraEditors.TextEdit
    Friend WithEvents sec_sDurum As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents sec_sMevcut As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents BarButtonItem9 As DevExpress.XtraBars.BarButtonItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_tbPersonel_Liste))
        Dim SuperToolTip2 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
        Dim ToolTipTitleItem2 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem
        Dim ToolTipItem2 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem
        Dim SuperToolTip3 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
        Dim ToolTipTitleItem3 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem
        Dim ToolTipItem3 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.Label1 = New DevExpress.XtraEditors.LabelControl
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.Label2 = New DevExpress.XtraEditors.LabelControl
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl
        Me.PanelControl5 = New DevExpress.XtraEditors.PanelControl
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.MenuItem13 = New System.Windows.Forms.MenuItem
        Me.MenuItem21 = New System.Windows.Forms.MenuItem
        Me.MenuItem14 = New System.Windows.Forms.MenuItem
        Me.MenuItem25 = New System.Windows.Forms.MenuItem
        Me.MenuItem20 = New System.Windows.Forms.MenuItem
        Me.MenuItem23 = New System.Windows.Forms.MenuItem
        Me.MenuItem24 = New System.Windows.Forms.MenuItem
        Me.MenuItem19 = New System.Windows.Forms.MenuItem
        Me.MenuItem17 = New System.Windows.Forms.MenuItem
        Me.MenuItem18 = New System.Windows.Forms.MenuItem
        Me.MenuItem15 = New System.Windows.Forms.MenuItem
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.MenuItem10 = New System.Windows.Forms.MenuItem
        Me.MenuItem22 = New System.Windows.Forms.MenuItem
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.MenuItem6 = New System.Windows.Forms.MenuItem
        Me.MenuItem11 = New System.Windows.Forms.MenuItem
        Me.MenuItem7 = New System.Windows.Forms.MenuItem
        Me.MenuItem8 = New System.Windows.Forms.MenuItem
        Me.MenuItem12 = New System.Windows.Forms.MenuItem
        Me.MenuItem9 = New System.Windows.Forms.MenuItem
        Me.ds_tbIsBasvurusuForm = New System.Data.DataSet
        Me.DataTable2 = New System.Data.DataTable
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
        Me.DataColumn43 = New System.Data.DataColumn
        Me.DataColumn44 = New System.Data.DataColumn
        Me.DataColumn45 = New System.Data.DataColumn
        Me.DataColumn46 = New System.Data.DataColumn
        Me.DataColumn47 = New System.Data.DataColumn
        Me.DataColumn48 = New System.Data.DataColumn
        Me.DataColumn49 = New System.Data.DataColumn
        Me.DataColumn50 = New System.Data.DataColumn
        Me.DataColumn51 = New System.Data.DataColumn
        Me.DataColumn52 = New System.Data.DataColumn
        Me.DataColumn53 = New System.Data.DataColumn
        Me.DataColumn54 = New System.Data.DataColumn
        Me.DataColumn55 = New System.Data.DataColumn
        Me.DataColumn56 = New System.Data.DataColumn
        Me.DataColumn57 = New System.Data.DataColumn
        Me.DataColumn58 = New System.Data.DataColumn
        Me.DataColumn59 = New System.Data.DataColumn
        Me.DataColumn60 = New System.Data.DataColumn
        Me.DataColumn61 = New System.Data.DataColumn
        Me.DataColumn62 = New System.Data.DataColumn
        Me.DataColumn63 = New System.Data.DataColumn
        Me.DataColumn64 = New System.Data.DataColumn
        Me.DataColumn65 = New System.Data.DataColumn
        Me.DataColumn66 = New System.Data.DataColumn
        Me.DataColumn67 = New System.Data.DataColumn
        Me.DataColumn68 = New System.Data.DataColumn
        Me.DataColumn69 = New System.Data.DataColumn
        Me.DataColumn70 = New System.Data.DataColumn
        Me.DataColumn71 = New System.Data.DataColumn
        Me.DataColumn72 = New System.Data.DataColumn
        Me.DataColumn73 = New System.Data.DataColumn
        Me.DataColumn74 = New System.Data.DataColumn
        Me.DataColumn75 = New System.Data.DataColumn
        Me.DataColumn76 = New System.Data.DataColumn
        Me.DataColumn77 = New System.Data.DataColumn
        Me.DataColumn78 = New System.Data.DataColumn
        Me.DataColumn79 = New System.Data.DataColumn
        Me.DataColumn80 = New System.Data.DataColumn
        Me.DataColumn81 = New System.Data.DataColumn
        Me.DataColumn82 = New System.Data.DataColumn
        Me.DataColumn83 = New System.Data.DataColumn
        Me.DataColumn84 = New System.Data.DataColumn
        Me.DataColumn85 = New System.Data.DataColumn
        Me.DataColumn86 = New System.Data.DataColumn
        Me.DataColumn87 = New System.Data.DataColumn
        Me.DataColumn88 = New System.Data.DataColumn
        Me.DataColumn89 = New System.Data.DataColumn
        Me.DataColumn90 = New System.Data.DataColumn
        Me.DataColumn91 = New System.Data.DataColumn
        Me.DataColumn92 = New System.Data.DataColumn
        Me.DataColumn93 = New System.Data.DataColumn
        Me.DataColumn94 = New System.Data.DataColumn
        Me.DataColumn95 = New System.Data.DataColumn
        Me.DataColumn96 = New System.Data.DataColumn
        Me.DataColumn97 = New System.Data.DataColumn
        Me.DataColumn98 = New System.Data.DataColumn
        Me.DataColumn99 = New System.Data.DataColumn
        Me.DataColumn100 = New System.Data.DataColumn
        Me.DataColumn101 = New System.Data.DataColumn
        Me.DataColumn102 = New System.Data.DataColumn
        Me.DataColumn103 = New System.Data.DataColumn
        Me.DataColumn104 = New System.Data.DataColumn
        Me.DataColumn105 = New System.Data.DataColumn
        Me.DataColumn106 = New System.Data.DataColumn
        Me.DataColumn107 = New System.Data.DataColumn
        Me.DataColumn108 = New System.Data.DataColumn
        Me.DataColumn109 = New System.Data.DataColumn
        Me.DataColumn110 = New System.Data.DataColumn
        Me.DataColumn111 = New System.Data.DataColumn
        Me.DataColumn112 = New System.Data.DataColumn
        Me.DataColumn113 = New System.Data.DataColumn
        Me.DataColumn114 = New System.Data.DataColumn
        Me.DataColumn115 = New System.Data.DataColumn
        Me.DataColumn116 = New System.Data.DataColumn
        Me.DataColumn117 = New System.Data.DataColumn
        Me.DataColumn118 = New System.Data.DataColumn
        Me.DataColumn119 = New System.Data.DataColumn
        Me.DataColumn120 = New System.Data.DataColumn
        Me.DataColumn121 = New System.Data.DataColumn
        Me.DataColumn122 = New System.Data.DataColumn
        Me.DataColumn123 = New System.Data.DataColumn
        Me.DataColumn124 = New System.Data.DataColumn
        Me.DataColumn125 = New System.Data.DataColumn
        Me.DataColumn126 = New System.Data.DataColumn
        Me.DataColumn127 = New System.Data.DataColumn
        Me.DataColumn128 = New System.Data.DataColumn
        Me.DataColumn129 = New System.Data.DataColumn
        Me.DataColumn130 = New System.Data.DataColumn
        Me.DataColumn131 = New System.Data.DataColumn
        Me.DataColumn132 = New System.Data.DataColumn
        Me.DataColumn133 = New System.Data.DataColumn
        Me.DataColumn134 = New System.Data.DataColumn
        Me.DataColumn135 = New System.Data.DataColumn
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.sec_Cinsiyet = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.sec_YuksekOkul = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.sec_Bolum = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.sec_Dil = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.sec_DilSeviye = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl
        Me.sec_sBasvuruPosizyonu1 = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl
        Me.txt_nCinsiyet = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.txt_sEhliyet = New DevExpress.XtraEditors.TextEdit
        Me.sec_bEhliyetiVarmi = New DevExpress.XtraEditors.CheckEdit
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem10 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem11 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem12 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem9 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem
        Me.BarDockControl1 = New DevExpress.XtraBars.BarDockControl
        Me.BarDockControl2 = New DevExpress.XtraBars.BarDockControl
        Me.BarDockControl3 = New DevExpress.XtraBars.BarDockControl
        Me.BarDockControl4 = New DevExpress.XtraBars.BarDockControl
        Me.BarButtonItem6 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem7 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem8 = New DevExpress.XtraBars.BarButtonItem
        Me.sec_bAskerliginiYaptimi = New DevExpress.XtraEditors.CheckEdit
        Me.sec_sMevcut = New DevExpress.XtraEditors.ComboBoxEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.sec_sDurum = New DevExpress.XtraEditors.ComboBoxEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.sec_konum = New DevExpress.XtraEditors.ComboBoxEdit
        Me.sec_kriter = New DevExpress.XtraEditors.ComboBoxEdit
        Me.txt_ara = New DevExpress.XtraEditors.TextEdit
        Me.SimpleButton6 = New DevExpress.XtraEditors.SimpleButton
        Me.sec_ekstre_tarih2 = New DevExpress.XtraEditors.DateEdit
        Me.sec_ekstre_tarih1 = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.lbl_Firma = New DevExpress.XtraEditors.LabelControl
        Me.Label39 = New DevExpress.XtraEditors.LabelControl
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
        Me.ps = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.printlink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.printlink2 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.printlink = New DevExpress.XtraPrintingLinks.CompositeLink(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        Me.ds_tbPersonelOzluk = New System.Data.DataSet
        Me.DataTable3 = New System.Data.DataTable
        Me.DataColumn136 = New System.Data.DataColumn
        Me.DataColumn137 = New System.Data.DataColumn
        Me.DataColumn138 = New System.Data.DataColumn
        Me.DataColumn139 = New System.Data.DataColumn
        Me.DataColumn140 = New System.Data.DataColumn
        Me.DataColumn141 = New System.Data.DataColumn
        Me.DataColumn142 = New System.Data.DataColumn
        Me.DataColumn143 = New System.Data.DataColumn
        Me.DataColumn144 = New System.Data.DataColumn
        Me.DataColumn145 = New System.Data.DataColumn
        Me.DataColumn146 = New System.Data.DataColumn
        Me.DataColumn147 = New System.Data.DataColumn
        Me.DataColumn148 = New System.Data.DataColumn
        Me.DataColumn149 = New System.Data.DataColumn
        Me.DataColumn150 = New System.Data.DataColumn
        Me.DataColumn151 = New System.Data.DataColumn
        Me.DataColumn152 = New System.Data.DataColumn
        Me.DataColumn153 = New System.Data.DataColumn
        Me.DataColumn154 = New System.Data.DataColumn
        Me.DataColumn155 = New System.Data.DataColumn
        Me.DataColumn156 = New System.Data.DataColumn
        Me.DataColumn157 = New System.Data.DataColumn
        Me.DataColumn158 = New System.Data.DataColumn
        Me.DataColumn159 = New System.Data.DataColumn
        Me.DataColumn160 = New System.Data.DataColumn
        Me.DataColumn161 = New System.Data.DataColumn
        Me.DataColumn162 = New System.Data.DataColumn
        Me.DataColumn163 = New System.Data.DataColumn
        Me.DataColumn164 = New System.Data.DataColumn
        Me.DataColumn165 = New System.Data.DataColumn
        Me.DataColumn166 = New System.Data.DataColumn
        Me.DataColumn167 = New System.Data.DataColumn
        Me.DataColumn168 = New System.Data.DataColumn
        Me.DataColumn169 = New System.Data.DataColumn
        Me.DataColumn170 = New System.Data.DataColumn
        Me.DataColumn171 = New System.Data.DataColumn
        Me.DataColumn172 = New System.Data.DataColumn
        Me.DataColumn173 = New System.Data.DataColumn
        Me.DataColumn174 = New System.Data.DataColumn
        Me.DataColumn175 = New System.Data.DataColumn
        Me.DataColumn176 = New System.Data.DataColumn
        Me.DataColumn177 = New System.Data.DataColumn
        Me.DataColumn178 = New System.Data.DataColumn
        Me.ds_tbPersonelMeslek = New System.Data.DataSet
        Me.DataTable4 = New System.Data.DataTable
        Me.DataColumn179 = New System.Data.DataColumn
        Me.DataColumn180 = New System.Data.DataColumn
        Me.DataColumn181 = New System.Data.DataColumn
        Me.DataColumn182 = New System.Data.DataColumn
        Me.DataColumn183 = New System.Data.DataColumn
        Me.DataColumn184 = New System.Data.DataColumn
        Me.DataColumn185 = New System.Data.DataColumn
        Me.DataColumn186 = New System.Data.DataColumn
        Me.DataColumn187 = New System.Data.DataColumn
        Me.DataColumn188 = New System.Data.DataColumn
        Me.DataColumn189 = New System.Data.DataColumn
        Me.DataColumn190 = New System.Data.DataColumn
        Me.DataColumn191 = New System.Data.DataColumn
        Me.DataColumn192 = New System.Data.DataColumn
        Me.DataColumn193 = New System.Data.DataColumn
        Me.DataColumn194 = New System.Data.DataColumn
        Me.DataColumn195 = New System.Data.DataColumn
        Me.DataColumn196 = New System.Data.DataColumn
        Me.DataColumn197 = New System.Data.DataColumn
        Me.DataColumn198 = New System.Data.DataColumn
        Me.DataColumn199 = New System.Data.DataColumn
        Me.DataColumn200 = New System.Data.DataColumn
        Me.DataColumn201 = New System.Data.DataColumn
        Me.DataColumn202 = New System.Data.DataColumn
        Me.DataColumn203 = New System.Data.DataColumn
        Me.DataColumn204 = New System.Data.DataColumn
        Me.DataColumn205 = New System.Data.DataColumn
        Me.DataColumn206 = New System.Data.DataColumn
        Me.DataColumn207 = New System.Data.DataColumn
        Me.DataColumn208 = New System.Data.DataColumn
        Me.DataColumn209 = New System.Data.DataColumn
        Me.DataColumn210 = New System.Data.DataColumn
        Me.ds_tbPersonel = New System.Data.DataSet
        Me.DataTable5 = New System.Data.DataTable
        Me.DataColumn211 = New System.Data.DataColumn
        Me.DataColumn212 = New System.Data.DataColumn
        Me.DataColumn213 = New System.Data.DataColumn
        Me.DataColumn214 = New System.Data.DataColumn
        Me.DataColumn215 = New System.Data.DataColumn
        Me.DataColumn216 = New System.Data.DataColumn
        Me.DataColumn217 = New System.Data.DataColumn
        Me.DataColumn218 = New System.Data.DataColumn
        Me.DataColumn219 = New System.Data.DataColumn
        Me.DataColumn220 = New System.Data.DataColumn
        Me.DataColumn221 = New System.Data.DataColumn
        Me.DataColumn222 = New System.Data.DataColumn
        Me.DataColumn223 = New System.Data.DataColumn
        Me.DataColumn224 = New System.Data.DataColumn
        Me.DataColumn225 = New System.Data.DataColumn
        Me.DataColumn226 = New System.Data.DataColumn
        Me.DataColumn227 = New System.Data.DataColumn
        Me.DataColumn228 = New System.Data.DataColumn
        Me.DataColumn229 = New System.Data.DataColumn
        Me.DataColumn230 = New System.Data.DataColumn
        Me.DataColumn231 = New System.Data.DataColumn
        Me.DataColumn232 = New System.Data.DataColumn
        Me.DataColumn233 = New System.Data.DataColumn
        Me.DataColumn234 = New System.Data.DataColumn
        Me.DataColumn235 = New System.Data.DataColumn
        Me.DataColumn236 = New System.Data.DataColumn
        Me.DataColumn237 = New System.Data.DataColumn
        Me.DataColumn238 = New System.Data.DataColumn
        Me.DataColumn239 = New System.Data.DataColumn
        Me.DataColumn240 = New System.Data.DataColumn
        Me.DataColumn241 = New System.Data.DataColumn
        Me.DataColumn242 = New System.Data.DataColumn
        Me.DataColumn243 = New System.Data.DataColumn
        Me.DataColumn244 = New System.Data.DataColumn
        Me.DataColumn245 = New System.Data.DataColumn
        Me.DataColumn246 = New System.Data.DataColumn
        Me.DataColumn247 = New System.Data.DataColumn
        Me.DataColumn248 = New System.Data.DataColumn
        Me.colnPersonelID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collSicilNo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsDepartmanKodu = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsAdi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsIkinciAdi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsSoyadi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colnCinsiyet = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsAkedemikUnvani = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsUnvan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colbSSKKesilecekmi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colbIssizlikKesilecekmi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsSSKSicilNo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsSSKStatusu = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsVergiStatusu = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collTTFToplamOdenen = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsTTFNumarasi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colbBrutUcretlimi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsSaatGunlukAylik = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsUcretDovizCinsi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collBirimUcret = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsBankaHesapNo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsBankaHesapNoKS = New DevExpress.XtraGrid.Columns.GridColumn
        Me.coldteIseGirisTarihi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.coldteIstenCikisTarihi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsCikisSebebi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colbCalisiyormu = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colnCocukAd = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colnCocukAdOkulOncesi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colnCocukAdIlkOgrenim = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colnCocukAdLise = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colnCocukAdYuksek = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collOzelSagSigAylikPrimi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colbSendikaUyesimi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.coldteOzelSSBaslangic = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsKullaniciAdi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.coldteKayitTarihi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collOzelEmekSigAylikPrimi = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl5.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_tbIsBasvurusuForm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_Cinsiyet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_YuksekOkul, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_Bolum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_Dil, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_DilSeviye, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl4.SuspendLayout()
        CType(Me.sec_sBasvuruPosizyonu1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_nCinsiyet.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sEhliyet.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_bEhliyetiVarmi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_bAskerliginiYaptimi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sMevcut.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sDurum.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_konum.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_kriter.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ara.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_ekstre_tarih2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_ekstre_tarih2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_ekstre_tarih1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_ekstre_tarih1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.printlink2.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.printlink.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_tbPersonelOzluk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_tbPersonelMeslek, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_tbPersonel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Controls.Add(Me.PictureBox1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(824, 56)
        Me.PanelControl1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(96, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Personel Listesi"
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(94, 52)
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
        Me.PanelControl2.Location = New System.Drawing.Point(0, 358)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(824, 48)
        Me.PanelControl2.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(7, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "*** Kayýt Bulunamadý...! ***"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Image = Global.business_smart.My.Resources.Resources.button_cancel
        Me.SimpleButton2.Location = New System.Drawing.Point(738, 8)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(75, 24)
        Me.SimpleButton2.TabIndex = 5
        Me.SimpleButton2.Text = "&Vazgeç"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Image = Global.business_smart.My.Resources.Resources.button_ok
        Me.SimpleButton1.Location = New System.Drawing.Point(663, 8)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 24)
        Me.SimpleButton1.TabIndex = 4
        Me.SimpleButton1.Text = "&Tamam"
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.PanelControl5)
        Me.PanelControl3.Controls.Add(Me.PanelControl4)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl3.Location = New System.Drawing.Point(0, 56)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(824, 302)
        Me.PanelControl3.TabIndex = 0
        '
        'PanelControl5
        '
        Me.PanelControl5.Controls.Add(Me.GridControl1)
        Me.PanelControl5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl5.Location = New System.Drawing.Point(2, 130)
        Me.PanelControl5.Name = "PanelControl5"
        Me.PanelControl5.Size = New System.Drawing.Size(820, 170)
        Me.PanelControl5.TabIndex = 1
        '
        'GridControl1
        '
        Me.GridControl1.ContextMenu = Me.ContextMenu1
        Me.GridControl1.DataMember = "Table1"
        Me.GridControl1.DataSource = Me.ds_tbPersonel
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(2, 2)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.sec_Cinsiyet, Me.sec_YuksekOkul, Me.sec_Bolum, Me.sec_Dil, Me.sec_DilSeviye})
        Me.GridControl1.Size = New System.Drawing.Size(816, 166)
        Me.GridControl1.TabIndex = 2
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem13, Me.MenuItem21, Me.MenuItem14, Me.MenuItem25, Me.MenuItem20, Me.MenuItem23, Me.MenuItem24, Me.MenuItem19, Me.MenuItem17, Me.MenuItem18, Me.MenuItem15, Me.MenuItem1, Me.MenuItem2, Me.MenuItem3, Me.MenuItem4, Me.MenuItem10, Me.MenuItem22, Me.MenuItem5, Me.MenuItem6, Me.MenuItem11, Me.MenuItem7, Me.MenuItem8, Me.MenuItem12, Me.MenuItem9})
        '
        'MenuItem13
        '
        Me.MenuItem13.DefaultItem = True
        Me.MenuItem13.Index = 0
        Me.MenuItem13.Shortcut = System.Windows.Forms.Shortcut.F2
        Me.MenuItem13.Text = "Tamam"
        '
        'MenuItem21
        '
        Me.MenuItem21.Index = 1
        Me.MenuItem21.Shortcut = System.Windows.Forms.Shortcut.F3
        Me.MenuItem21.Text = "Ara"
        '
        'MenuItem14
        '
        Me.MenuItem14.Index = 2
        Me.MenuItem14.Shortcut = System.Windows.Forms.Shortcut.F3
        Me.MenuItem14.Text = "Vazgeç"
        '
        'MenuItem25
        '
        Me.MenuItem25.Index = 3
        Me.MenuItem25.Text = "-"
        '
        'MenuItem20
        '
        Me.MenuItem20.Index = 4
        Me.MenuItem20.Shortcut = System.Windows.Forms.Shortcut.Ins
        Me.MenuItem20.Text = "Ekle"
        '
        'MenuItem23
        '
        Me.MenuItem23.Index = 5
        Me.MenuItem23.Shortcut = System.Windows.Forms.Shortcut.F4
        Me.MenuItem23.Text = "Düzelt"
        '
        'MenuItem24
        '
        Me.MenuItem24.Index = 6
        Me.MenuItem24.Shortcut = System.Windows.Forms.Shortcut.CtrlDel
        Me.MenuItem24.Text = "Sil"
        '
        'MenuItem19
        '
        Me.MenuItem19.Index = 7
        Me.MenuItem19.Text = "-"
        '
        'MenuItem17
        '
        Me.MenuItem17.Index = 8
        Me.MenuItem17.Shortcut = System.Windows.Forms.Shortcut.F6
        Me.MenuItem17.Text = "Görüþmeler"
        '
        'MenuItem18
        '
        Me.MenuItem18.Index = 9
        Me.MenuItem18.Shortcut = System.Windows.Forms.Shortcut.CtrlF
        Me.MenuItem18.Text = "Eski Ýþ Yerleri"
        '
        'MenuItem15
        '
        Me.MenuItem15.Index = 10
        Me.MenuItem15.Text = "-"
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 11
        Me.MenuItem1.Text = "Görünümü Düzenle"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 12
        Me.MenuItem2.Text = "Baþlýk Deðiþtir"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 13
        Me.MenuItem3.Text = "Görünümü Kaydet"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 14
        Me.MenuItem4.Shortcut = System.Windows.Forms.Shortcut.CtrlP
        Me.MenuItem4.Text = "Görünümü Yazdýr"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 15
        Me.MenuItem10.Text = "-"
        '
        'MenuItem22
        '
        Me.MenuItem22.Index = 16
        Me.MenuItem22.Text = "Hýzlý Filtre"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 17
        Me.MenuItem5.Text = "Filtrele"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 18
        Me.MenuItem6.Text = "Gruplandýr"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 19
        Me.MenuItem11.Text = "-"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 20
        Me.MenuItem7.Text = "Satýrlarý Aç"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 21
        Me.MenuItem8.Text = "Satýrlarý Kapat"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 22
        Me.MenuItem12.Text = "-"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 23
        Me.MenuItem9.Shortcut = System.Windows.Forms.Shortcut.F12
        Me.MenuItem9.Text = "Ekraný Kapla"
        '
        'ds_tbIsBasvurusuForm
        '
        Me.ds_tbIsBasvurusuForm.DataSetName = "NewDataSet"
        Me.ds_tbIsBasvurusuForm.Tables.AddRange(New System.Data.DataTable() {Me.DataTable2})
        '
        'DataTable2
        '
        Me.DataTable2.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26, Me.DataColumn27, Me.DataColumn28, Me.DataColumn29, Me.DataColumn30, Me.DataColumn31, Me.DataColumn32, Me.DataColumn33, Me.DataColumn34, Me.DataColumn35, Me.DataColumn36, Me.DataColumn37, Me.DataColumn38, Me.DataColumn39, Me.DataColumn40, Me.DataColumn41, Me.DataColumn42, Me.DataColumn43, Me.DataColumn44, Me.DataColumn45, Me.DataColumn46, Me.DataColumn47, Me.DataColumn48, Me.DataColumn49, Me.DataColumn50, Me.DataColumn51, Me.DataColumn52, Me.DataColumn53, Me.DataColumn54, Me.DataColumn55, Me.DataColumn56, Me.DataColumn57, Me.DataColumn58, Me.DataColumn59, Me.DataColumn60, Me.DataColumn61, Me.DataColumn62, Me.DataColumn63, Me.DataColumn64, Me.DataColumn65, Me.DataColumn66, Me.DataColumn67, Me.DataColumn68, Me.DataColumn69, Me.DataColumn70, Me.DataColumn71, Me.DataColumn72, Me.DataColumn73, Me.DataColumn74, Me.DataColumn75, Me.DataColumn76, Me.DataColumn77, Me.DataColumn78, Me.DataColumn79, Me.DataColumn80, Me.DataColumn81, Me.DataColumn82, Me.DataColumn83, Me.DataColumn84, Me.DataColumn85, Me.DataColumn86, Me.DataColumn87, Me.DataColumn88, Me.DataColumn89, Me.DataColumn90, Me.DataColumn91, Me.DataColumn92, Me.DataColumn93, Me.DataColumn94, Me.DataColumn95, Me.DataColumn96, Me.DataColumn97, Me.DataColumn98, Me.DataColumn99, Me.DataColumn100, Me.DataColumn101, Me.DataColumn102, Me.DataColumn103, Me.DataColumn104, Me.DataColumn105, Me.DataColumn106, Me.DataColumn107, Me.DataColumn108, Me.DataColumn109, Me.DataColumn110, Me.DataColumn111, Me.DataColumn112, Me.DataColumn113, Me.DataColumn114, Me.DataColumn115, Me.DataColumn116, Me.DataColumn117, Me.DataColumn118, Me.DataColumn119, Me.DataColumn120, Me.DataColumn121, Me.DataColumn122, Me.DataColumn123, Me.DataColumn124, Me.DataColumn125, Me.DataColumn126, Me.DataColumn127, Me.DataColumn128, Me.DataColumn129, Me.DataColumn130, Me.DataColumn131, Me.DataColumn132, Me.DataColumn133, Me.DataColumn134, Me.DataColumn135})
        Me.DataTable2.TableName = "Table1"
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "nAdayID"
        Me.DataColumn19.DataType = GetType(Long)
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "sAdi"
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "sSoyadi"
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "nCinsiyet"
        Me.DataColumn22.DataType = GetType(Long)
        Me.DataColumn22.DefaultValue = CType(1, Long)
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "bEhliyetiVarmi"
        Me.DataColumn23.DataType = GetType(Boolean)
        Me.DataColumn23.DefaultValue = False
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "sEhliyetSinifi"
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "bAskerliginiYaptimi"
        Me.DataColumn25.DataType = GetType(Boolean)
        Me.DataColumn25.DefaultValue = False
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "dteTerhisTarihi"
        Me.DataColumn26.DataType = GetType(Date)
        Me.DataColumn26.DefaultValue = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'DataColumn27
        '
        Me.DataColumn27.ColumnName = "nTecilSuresi"
        Me.DataColumn27.DataType = GetType(Long)
        Me.DataColumn27.DefaultValue = CType(0, Long)
        '
        'DataColumn28
        '
        Me.DataColumn28.ColumnName = "sDogumYeri"
        '
        'DataColumn29
        '
        Me.DataColumn29.ColumnName = "dteDogumTarihi"
        Me.DataColumn29.DataType = GetType(Date)
        Me.DataColumn29.DefaultValue = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'DataColumn30
        '
        Me.DataColumn30.ColumnName = "bEvlimi"
        Me.DataColumn30.DataType = GetType(Boolean)
        Me.DataColumn30.DefaultValue = False
        '
        'DataColumn31
        '
        Me.DataColumn31.ColumnName = "sDini"
        '
        'DataColumn32
        '
        Me.DataColumn32.ColumnName = "sEvAdresi1"
        '
        'DataColumn33
        '
        Me.DataColumn33.ColumnName = "sEvAdresi2"
        '
        'DataColumn34
        '
        Me.DataColumn34.ColumnName = "sEvSemt"
        '
        'DataColumn35
        '
        Me.DataColumn35.ColumnName = "sEvPostaKodu"
        '
        'DataColumn36
        '
        Me.DataColumn36.ColumnName = "sEvIl"
        Me.DataColumn36.DefaultValue = " "
        '
        'DataColumn37
        '
        Me.DataColumn37.ColumnName = "sEvTelefonu"
        '
        'DataColumn38
        '
        Me.DataColumn38.ColumnName = "sCepTelefonu"
        '
        'DataColumn39
        '
        Me.DataColumn39.ColumnName = "sE_Posta"
        '
        'DataColumn40
        '
        Me.DataColumn40.ColumnName = "sIletisimPET"
        Me.DataColumn40.DataType = GetType(Long)
        Me.DataColumn40.DefaultValue = CType(1, Long)
        '
        'DataColumn41
        '
        Me.DataColumn41.ColumnName = "sIlkOgrenim"
        '
        'DataColumn42
        '
        Me.DataColumn42.ColumnName = "dteIlkBitisTarihi"
        Me.DataColumn42.DataType = GetType(Date)
        Me.DataColumn42.DefaultValue = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'DataColumn43
        '
        Me.DataColumn43.ColumnName = "sLise"
        '
        'DataColumn44
        '
        Me.DataColumn44.ColumnName = "dteLiseBitisTarihi"
        Me.DataColumn44.DataType = GetType(Date)
        Me.DataColumn44.DefaultValue = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'DataColumn45
        '
        Me.DataColumn45.ColumnName = "nYuksekOkulID1"
        Me.DataColumn45.DataType = GetType(Long)
        Me.DataColumn45.DefaultValue = CType(1, Long)
        '
        'DataColumn46
        '
        Me.DataColumn46.ColumnName = "nYuksekOkulID2"
        Me.DataColumn46.DataType = GetType(Long)
        Me.DataColumn46.DefaultValue = CType(1, Long)
        '
        'DataColumn47
        '
        Me.DataColumn47.ColumnName = "nYuksekOkulID3"
        Me.DataColumn47.DataType = GetType(Long)
        Me.DataColumn47.DefaultValue = CType(1, Long)
        '
        'DataColumn48
        '
        Me.DataColumn48.ColumnName = "nBolumID1"
        Me.DataColumn48.DataType = GetType(Long)
        Me.DataColumn48.DefaultValue = CType(1, Long)
        '
        'DataColumn49
        '
        Me.DataColumn49.ColumnName = "nBolumID2"
        Me.DataColumn49.DataType = GetType(Long)
        Me.DataColumn49.DefaultValue = CType(1, Long)
        '
        'DataColumn50
        '
        Me.DataColumn50.ColumnName = "nBolumID3"
        Me.DataColumn50.DataType = GetType(Integer)
        Me.DataColumn50.DefaultValue = 1
        '
        'DataColumn51
        '
        Me.DataColumn51.ColumnName = "sDigerYuksekOkul1"
        Me.DataColumn51.DefaultValue = " "
        '
        'DataColumn52
        '
        Me.DataColumn52.ColumnName = "sDigerYuksekOkul2"
        Me.DataColumn52.DefaultValue = " "
        '
        'DataColumn53
        '
        Me.DataColumn53.ColumnName = "sDigerYuksekOkul3"
        Me.DataColumn53.DefaultValue = " "
        '
        'DataColumn54
        '
        Me.DataColumn54.ColumnName = "dteYOBitisTarihi1"
        Me.DataColumn54.DataType = GetType(Date)
        Me.DataColumn54.DefaultValue = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'DataColumn55
        '
        Me.DataColumn55.ColumnName = "dteYOBitisTarihi2"
        Me.DataColumn55.DataType = GetType(Date)
        Me.DataColumn55.DefaultValue = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'DataColumn56
        '
        Me.DataColumn56.ColumnName = "dteYOBitisTarihi3"
        Me.DataColumn56.DataType = GetType(Date)
        Me.DataColumn56.DefaultValue = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'DataColumn57
        '
        Me.DataColumn57.ColumnName = "sMeslek"
        '
        'DataColumn58
        '
        Me.DataColumn58.ColumnName = "sIsTecrubesi"
        '
        'DataColumn59
        '
        Me.DataColumn59.ColumnName = "lSonMaasi"
        Me.DataColumn59.DataType = GetType(Decimal)
        Me.DataColumn59.DefaultValue = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DataColumn60
        '
        Me.DataColumn60.ColumnName = "sReferans1AdiSoyadi"
        '
        'DataColumn61
        '
        Me.DataColumn61.ColumnName = "sReferans2AdiSoyadi"
        '
        'DataColumn62
        '
        Me.DataColumn62.ColumnName = "sReferans3AdiSoyadi"
        '
        'DataColumn63
        '
        Me.DataColumn63.ColumnName = "sReferans1Tel"
        '
        'DataColumn64
        '
        Me.DataColumn64.ColumnName = "sReferans2Tel"
        '
        'DataColumn65
        '
        Me.DataColumn65.ColumnName = "sReferans3Tel"
        '
        'DataColumn66
        '
        Me.DataColumn66.ColumnName = "sReferans1Aciklamasi"
        '
        'DataColumn67
        '
        Me.DataColumn67.ColumnName = "sReferans2Aciklamasi"
        '
        'DataColumn68
        '
        Me.DataColumn68.ColumnName = "sReferans3Aciklamasi"
        '
        'DataColumn69
        '
        Me.DataColumn69.ColumnName = "sBasvuruPosizyonu"
        '
        'DataColumn70
        '
        Me.DataColumn70.ColumnName = "sBilgisayarTecrubesi"
        '
        'DataColumn71
        '
        Me.DataColumn71.ColumnName = "sEkAciklama"
        '
        'DataColumn72
        '
        Me.DataColumn72.ColumnName = "nYabanciDilID1"
        Me.DataColumn72.DataType = GetType(Long)
        Me.DataColumn72.DefaultValue = CType(1, Long)
        '
        'DataColumn73
        '
        Me.DataColumn73.ColumnName = "nYabanciDilID2"
        Me.DataColumn73.DataType = GetType(Long)
        Me.DataColumn73.DefaultValue = CType(1, Long)
        '
        'DataColumn74
        '
        Me.DataColumn74.ColumnName = "nYabanciDilID3"
        Me.DataColumn74.DataType = GetType(Long)
        Me.DataColumn74.DefaultValue = CType(1, Long)
        '
        'DataColumn75
        '
        Me.DataColumn75.ColumnName = "nYDSeviye1"
        Me.DataColumn75.DataType = GetType(Long)
        Me.DataColumn75.DefaultValue = CType(0, Long)
        '
        'DataColumn76
        '
        Me.DataColumn76.ColumnName = "nYDSeviye2"
        Me.DataColumn76.DataType = GetType(Long)
        Me.DataColumn76.DefaultValue = CType(0, Long)
        '
        'DataColumn77
        '
        Me.DataColumn77.ColumnName = "nYDSeviye3"
        Me.DataColumn77.DataType = GetType(Long)
        Me.DataColumn77.DefaultValue = CType(0, Long)
        '
        'DataColumn78
        '
        Me.DataColumn78.ColumnName = "dteBasvuruTarihi"
        Me.DataColumn78.DataType = GetType(Date)
        Me.DataColumn78.DefaultValue = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'DataColumn79
        '
        Me.DataColumn79.ColumnName = "sResimAdi"
        '
        'DataColumn80
        '
        Me.DataColumn80.ColumnName = "sKimlikNo"
        '
        'DataColumn81
        '
        Me.DataColumn81.ColumnName = "sBabaAdi"
        '
        'DataColumn82
        '
        Me.DataColumn82.ColumnName = "sBabaMeslek"
        '
        'DataColumn83
        '
        Me.DataColumn83.ColumnName = "sAnneAdi"
        '
        'DataColumn84
        '
        Me.DataColumn84.ColumnName = "sAnneMeslek"
        '
        'DataColumn85
        '
        Me.DataColumn85.ColumnName = "sEsAdi"
        '
        'DataColumn86
        '
        Me.DataColumn86.ColumnName = "sEsMeslek"
        '
        'DataColumn87
        '
        Me.DataColumn87.ColumnName = "sEsTelefonu"
        '
        'DataColumn88
        '
        Me.DataColumn88.ColumnName = "bTCVatandasimi"
        Me.DataColumn88.DataType = GetType(Boolean)
        Me.DataColumn88.DefaultValue = True
        '
        'DataColumn89
        '
        Me.DataColumn89.ColumnName = "sUyrugu"
        '
        'DataColumn90
        '
        Me.DataColumn90.ColumnName = "nCocukSayisi"
        Me.DataColumn90.DataType = GetType(Long)
        Me.DataColumn90.DefaultValue = CType(0, Long)
        '
        'DataColumn91
        '
        Me.DataColumn91.ColumnName = "sKanGrubu"
        '
        'DataColumn92
        '
        Me.DataColumn92.ColumnName = "bSabikalimi"
        Me.DataColumn92.DataType = GetType(Boolean)
        Me.DataColumn92.DefaultValue = False
        '
        'DataColumn93
        '
        Me.DataColumn93.ColumnName = "sSabikaNeden"
        '
        'DataColumn94
        '
        Me.DataColumn94.ColumnName = "bOnemliHastalikGecirdimi"
        Me.DataColumn94.DataType = GetType(Boolean)
        Me.DataColumn94.DefaultValue = False
        '
        'DataColumn95
        '
        Me.DataColumn95.ColumnName = "sOnemliHastalikAciklama"
        '
        'DataColumn96
        '
        Me.DataColumn96.ColumnName = "bFizikselProplemiVarmi"
        Me.DataColumn96.DataType = GetType(Boolean)
        Me.DataColumn96.DefaultValue = False
        '
        'DataColumn97
        '
        Me.DataColumn97.ColumnName = "sFizilsekProplemAciklama"
        '
        'DataColumn98
        '
        Me.DataColumn98.ColumnName = "sAcil1AdiSoyadi"
        '
        'DataColumn99
        '
        Me.DataColumn99.ColumnName = "sAcil2AdiSoyadi"
        '
        'DataColumn100
        '
        Me.DataColumn100.ColumnName = "sAcil1YakinlikDerecesi"
        '
        'DataColumn101
        '
        Me.DataColumn101.ColumnName = "sAcil2YakinlikDerecesi"
        '
        'DataColumn102
        '
        Me.DataColumn102.ColumnName = "sAcil1Telefon"
        '
        'DataColumn103
        '
        Me.DataColumn103.ColumnName = "sAcil2Telefon"
        '
        'DataColumn104
        '
        Me.DataColumn104.ColumnName = "sAcil1Adres"
        '
        'DataColumn105
        '
        Me.DataColumn105.ColumnName = "sAcil2Adres"
        '
        'DataColumn106
        '
        Me.DataColumn106.ColumnName = "sAcil1Semt"
        '
        'DataColumn107
        '
        Me.DataColumn107.ColumnName = "sAcil2Semt"
        '
        'DataColumn108
        '
        Me.DataColumn108.ColumnName = "sAcil1Il"
        Me.DataColumn108.DefaultValue = " "
        '
        'DataColumn109
        '
        Me.DataColumn109.ColumnName = "sAcil2Il"
        Me.DataColumn109.DefaultValue = " "
        '
        'DataColumn110
        '
        Me.DataColumn110.ColumnName = "sReferans1Sonuc"
        '
        'DataColumn111
        '
        Me.DataColumn111.ColumnName = "sReferans2Sonuc"
        '
        'DataColumn112
        '
        Me.DataColumn112.ColumnName = "sReferans3Sonuc"
        '
        'DataColumn113
        '
        Me.DataColumn113.ColumnName = "sBasvuruPosizyonu2"
        '
        'DataColumn114
        '
        Me.DataColumn114.ColumnName = "sBasvuruPosizyonu3"
        '
        'DataColumn115
        '
        Me.DataColumn115.ColumnName = "nBasvuruSure1"
        Me.DataColumn115.DataType = GetType(Decimal)
        Me.DataColumn115.DefaultValue = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DataColumn116
        '
        Me.DataColumn116.ColumnName = "nBasvuruSure2"
        Me.DataColumn116.DataType = GetType(Decimal)
        Me.DataColumn116.DefaultValue = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DataColumn117
        '
        Me.DataColumn117.ColumnName = "nBasvuruSure3"
        Me.DataColumn117.DataType = GetType(Decimal)
        Me.DataColumn117.DefaultValue = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DataColumn118
        '
        Me.DataColumn118.ColumnName = "sSosyalImkanOnceki"
        '
        'DataColumn119
        '
        Me.DataColumn119.ColumnName = "dteIlkBaslangicTarihi"
        Me.DataColumn119.DataType = GetType(Date)
        Me.DataColumn119.DefaultValue = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'DataColumn120
        '
        Me.DataColumn120.ColumnName = "dteOrtaBaslangicTarihi"
        Me.DataColumn120.DataType = GetType(Date)
        Me.DataColumn120.DefaultValue = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'DataColumn121
        '
        Me.DataColumn121.ColumnName = "dteLiseBaslangicTarihi"
        Me.DataColumn121.DataType = GetType(Date)
        Me.DataColumn121.DefaultValue = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'DataColumn122
        '
        Me.DataColumn122.ColumnName = "sOrtaOgrenim"
        '
        'DataColumn123
        '
        Me.DataColumn123.ColumnName = "dteOrtaBalangicTarihi"
        Me.DataColumn123.DataType = GetType(Date)
        Me.DataColumn123.DefaultValue = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'DataColumn124
        '
        Me.DataColumn124.ColumnName = "dteIlkBalangicTarihi"
        Me.DataColumn124.DataType = GetType(Date)
        Me.DataColumn124.DefaultValue = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'DataColumn125
        '
        Me.DataColumn125.ColumnName = "dteLiseBalangicTarihi"
        Me.DataColumn125.DataType = GetType(Date)
        Me.DataColumn125.DefaultValue = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'DataColumn126
        '
        Me.DataColumn126.ColumnName = "dteYOBaslangicTarihi1"
        Me.DataColumn126.DataType = GetType(Date)
        Me.DataColumn126.DefaultValue = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'DataColumn127
        '
        Me.DataColumn127.ColumnName = "dteYOBaslangicTarihi2"
        Me.DataColumn127.DataType = GetType(Date)
        Me.DataColumn127.DefaultValue = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'DataColumn128
        '
        Me.DataColumn128.ColumnName = "dteYOBaslangicTarihi3"
        Me.DataColumn128.DataType = GetType(Date)
        Me.DataColumn128.DefaultValue = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'DataColumn129
        '
        Me.DataColumn129.ColumnName = "bYODevamEdiyormu1"
        Me.DataColumn129.DataType = GetType(Boolean)
        Me.DataColumn129.DefaultValue = False
        '
        'DataColumn130
        '
        Me.DataColumn130.ColumnName = "bYODevamEdiyormu2"
        Me.DataColumn130.DataType = GetType(Boolean)
        Me.DataColumn130.DefaultValue = False
        '
        'DataColumn131
        '
        Me.DataColumn131.ColumnName = "bYODevamEdiyormu3"
        Me.DataColumn131.DataType = GetType(Boolean)
        Me.DataColumn131.DefaultValue = False
        '
        'DataColumn132
        '
        Me.DataColumn132.ColumnName = "bIseAlindi"
        Me.DataColumn132.DataType = GetType(Boolean)
        Me.DataColumn132.DefaultValue = False
        '
        'DataColumn133
        '
        Me.DataColumn133.ColumnName = "lSicilNo"
        Me.DataColumn133.DataType = GetType(Long)
        Me.DataColumn133.DefaultValue = CType(0, Long)
        '
        'DataColumn134
        '
        Me.DataColumn134.ColumnName = "dteOrtaBitisTarihi"
        Me.DataColumn134.DataType = GetType(Date)
        Me.DataColumn134.DefaultValue = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'DataColumn135
        '
        Me.DataColumn135.ColumnName = "sLiseOgrenim"
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
        Me.GridView1.Appearance.FocusedRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridView1.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedRow.Options.UseFont = True
        Me.GridView1.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GridView1.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView1.Appearance.HideSelectionRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView1.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GridView1.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colnPersonelID, Me.collSicilNo, Me.colsDepartmanKodu, Me.colsAdi, Me.colsIkinciAdi, Me.colsSoyadi, Me.colnCinsiyet, Me.colsAkedemikUnvani, Me.colsUnvan, Me.colbSSKKesilecekmi, Me.colbIssizlikKesilecekmi, Me.colsSSKSicilNo, Me.colsSSKStatusu, Me.colsVergiStatusu, Me.collTTFToplamOdenen, Me.colsTTFNumarasi, Me.colbBrutUcretlimi, Me.colsSaatGunlukAylik, Me.colsUcretDovizCinsi, Me.collBirimUcret, Me.colsBankaHesapNo, Me.colsBankaHesapNoKS, Me.coldteIseGirisTarihi, Me.coldteIstenCikisTarihi, Me.colsCikisSebebi, Me.colbCalisiyormu, Me.colnCocukAd, Me.colnCocukAdOkulOncesi, Me.colnCocukAdIlkOgrenim, Me.colnCocukAdLise, Me.colnCocukAdYuksek, Me.collOzelSagSigAylikPrimi, Me.colbSendikaUyesimi, Me.coldteOzelSSBaslangic, Me.colsKullaniciAdi, Me.coldteKayitTarihi, Me.collOzelEmekSigAylikPrimi})
        Me.GridView1.CustomizationFormBounds = New System.Drawing.Rectangle(609, 257, 208, 170)
        Me.GridView1.DetailHeight = 160
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupFormat = "{0}: {1} {2}"
        Me.GridView1.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "FIRMAKODU", Nothing, "ÝþlemSayýsý: {0} Kayýt"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "MIKTAR", Nothing, "ToplamMiktar: {0:#,0.##}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TUTAR", Nothing, "ToplamTutar: {0:#,0.00}")})
        Me.GridView1.IndicatorWidth = 35
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsDetail.ShowDetailTabs = False
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'sec_Cinsiyet
        '
        Me.sec_Cinsiyet.AutoHeight = False
        Me.sec_Cinsiyet.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_Cinsiyet.DisplayMember = "sAciklama"
        Me.sec_Cinsiyet.Name = "sec_Cinsiyet"
        Me.sec_Cinsiyet.NullText = "[Cinsiyet]"
        Me.sec_Cinsiyet.ValueMember = "nCinsiyet"
        '
        'sec_YuksekOkul
        '
        Me.sec_YuksekOkul.AutoHeight = False
        Me.sec_YuksekOkul.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_YuksekOkul.DisplayMember = "sYuksekOkul"
        Me.sec_YuksekOkul.Name = "sec_YuksekOkul"
        Me.sec_YuksekOkul.NullText = "[YüksekOkul]"
        Me.sec_YuksekOkul.ValueMember = "nYuksekOkulID"
        '
        'sec_Bolum
        '
        Me.sec_Bolum.AutoHeight = False
        Me.sec_Bolum.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_Bolum.DisplayMember = "sBolum"
        Me.sec_Bolum.Name = "sec_Bolum"
        Me.sec_Bolum.NullText = "[Bölüm]"
        Me.sec_Bolum.ValueMember = "nBolumID"
        '
        'sec_Dil
        '
        Me.sec_Dil.AutoHeight = False
        Me.sec_Dil.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_Dil.DisplayMember = "sYabanciDil"
        Me.sec_Dil.Name = "sec_Dil"
        Me.sec_Dil.NullText = "[Dil]"
        Me.sec_Dil.ValueMember = "nYabanciDilID"
        '
        'sec_DilSeviye
        '
        Me.sec_DilSeviye.AutoHeight = False
        Me.sec_DilSeviye.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_DilSeviye.DisplayMember = "sSeviye"
        Me.sec_DilSeviye.Name = "sec_DilSeviye"
        Me.sec_DilSeviye.NullText = "[Seviye]"
        Me.sec_DilSeviye.ValueMember = " nYDSeviye"
        '
        'PanelControl4
        '
        Me.PanelControl4.Controls.Add(Me.sec_sBasvuruPosizyonu1)
        Me.PanelControl4.Controls.Add(Me.LabelControl16)
        Me.PanelControl4.Controls.Add(Me.txt_nCinsiyet)
        Me.PanelControl4.Controls.Add(Me.LabelControl1)
        Me.PanelControl4.Controls.Add(Me.txt_sEhliyet)
        Me.PanelControl4.Controls.Add(Me.sec_bEhliyetiVarmi)
        Me.PanelControl4.Controls.Add(Me.sec_bAskerliginiYaptimi)
        Me.PanelControl4.Controls.Add(Me.sec_sMevcut)
        Me.PanelControl4.Controls.Add(Me.LabelControl4)
        Me.PanelControl4.Controls.Add(Me.sec_sDurum)
        Me.PanelControl4.Controls.Add(Me.LabelControl3)
        Me.PanelControl4.Controls.Add(Me.sec_konum)
        Me.PanelControl4.Controls.Add(Me.sec_kriter)
        Me.PanelControl4.Controls.Add(Me.txt_ara)
        Me.PanelControl4.Controls.Add(Me.SimpleButton6)
        Me.PanelControl4.Controls.Add(Me.sec_ekstre_tarih2)
        Me.PanelControl4.Controls.Add(Me.sec_ekstre_tarih1)
        Me.PanelControl4.Controls.Add(Me.LabelControl2)
        Me.PanelControl4.Controls.Add(Me.lbl_Firma)
        Me.PanelControl4.Controls.Add(Me.Label39)
        Me.PanelControl4.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl4.Location = New System.Drawing.Point(2, 2)
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Size = New System.Drawing.Size(820, 128)
        Me.PanelControl4.TabIndex = 0
        '
        'sec_sBasvuruPosizyonu1
        '
        Me.sec_sBasvuruPosizyonu1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbIsBasvurusuForm, "Table1.sBasvuruPosizyonu", True))
        Me.sec_sBasvuruPosizyonu1.EnterMoveNextControl = True
        Me.sec_sBasvuruPosizyonu1.Location = New System.Drawing.Point(111, 104)
        Me.sec_sBasvuruPosizyonu1.Name = "sec_sBasvuruPosizyonu1"
        Me.sec_sBasvuruPosizyonu1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.sec_sBasvuruPosizyonu1.Properties.Appearance.Options.UseBackColor = True
        Me.sec_sBasvuruPosizyonu1.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.sec_sBasvuruPosizyonu1.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.sec_sBasvuruPosizyonu1.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.sec_sBasvuruPosizyonu1.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.sec_sBasvuruPosizyonu1.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.sec_sBasvuruPosizyonu1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sBasvuruPosizyonu1.Properties.DisplayMember = "sAciklama"
        Me.sec_sBasvuruPosizyonu1.Properties.NullText = "[IsKodu]"
        Me.sec_sBasvuruPosizyonu1.Properties.ValueMember = "sIsKodu"
        Me.sec_sBasvuruPosizyonu1.Size = New System.Drawing.Size(129, 20)
        ToolTipTitleItem2.Text = "Cinsiyet"
        ToolTipItem2.LeftIndent = 6
        ToolTipItem2.Text = "Müþterinin Cinsiyet Bilgisi Buradan Girilir. Müþterilerin Cinsiyet Daðýlýmý ve Pr" & _
            "ofili Takip Edilecekse Mutlaka Belirtilmesi Gerekmektedir."
        SuperToolTip2.Items.Add(ToolTipTitleItem2)
        SuperToolTip2.Items.Add(ToolTipItem2)
        Me.sec_sBasvuruPosizyonu1.SuperTip = SuperToolTip2
        Me.sec_sBasvuruPosizyonu1.TabIndex = 130
        '
        'LabelControl16
        '
        Me.LabelControl16.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl16.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl16.Location = New System.Drawing.Point(50, 107)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(57, 13)
        Me.LabelControl16.TabIndex = 131
        Me.LabelControl16.Text = "Departman:"
        '
        'txt_nCinsiyet
        '
        Me.txt_nCinsiyet.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbIsBasvurusuForm, "Table1.nCinsiyet", True))
        Me.txt_nCinsiyet.EnterMoveNextControl = True
        Me.txt_nCinsiyet.Location = New System.Drawing.Point(237, 47)
        Me.txt_nCinsiyet.Name = "txt_nCinsiyet"
        Me.txt_nCinsiyet.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.txt_nCinsiyet.Properties.Appearance.Options.UseBackColor = True
        Me.txt_nCinsiyet.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_nCinsiyet.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_nCinsiyet.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_nCinsiyet.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_nCinsiyet.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_nCinsiyet.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_nCinsiyet.Properties.DisplayMember = "sAciklama"
        Me.txt_nCinsiyet.Properties.NullText = "[Cinsiyet]"
        Me.txt_nCinsiyet.Properties.ValueMember = "nCinsiyet"
        Me.txt_nCinsiyet.Size = New System.Drawing.Size(81, 20)
        ToolTipTitleItem3.Text = "Cinsiyet"
        ToolTipItem3.LeftIndent = 6
        ToolTipItem3.Text = "Müþterinin Cinsiyet Bilgisi Buradan Girilir. Müþterilerin Cinsiyet Daðýlýmý ve Pr" & _
            "ofili Takip Edilecekse Mutlaka Belirtilmesi Gerekmektedir."
        SuperToolTip3.Items.Add(ToolTipTitleItem3)
        SuperToolTip3.Items.Add(ToolTipItem3)
        Me.txt_nCinsiyet.SuperTip = SuperToolTip3
        Me.txt_nCinsiyet.TabIndex = 118
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl1.Location = New System.Drawing.Point(198, 50)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(42, 13)
        Me.LabelControl1.TabIndex = 37
        Me.LabelControl1.Text = "Cinsiyet:"
        '
        'txt_sEhliyet
        '
        Me.txt_sEhliyet.EnterMoveNextControl = True
        Me.txt_sEhliyet.Location = New System.Drawing.Point(237, 83)
        Me.txt_sEhliyet.Name = "txt_sEhliyet"
        Me.txt_sEhliyet.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_sEhliyet.Properties.Appearance.Options.UseFont = True
        Me.txt_sEhliyet.Properties.MaxLength = 15
        Me.txt_sEhliyet.Size = New System.Drawing.Size(81, 20)
        Me.txt_sEhliyet.TabIndex = 36
        '
        'sec_bEhliyetiVarmi
        '
        Me.sec_bEhliyetiVarmi.Location = New System.Drawing.Point(109, 86)
        Me.sec_bEhliyetiVarmi.MenuManager = Me.BarManager1
        Me.sec_bEhliyetiVarmi.Name = "sec_bEhliyetiVarmi"
        Me.sec_bEhliyetiVarmi.Properties.Caption = "Ehliyeti Varmý"
        Me.sec_bEhliyetiVarmi.Size = New System.Drawing.Size(101, 19)
        Me.sec_bEhliyetiVarmi.TabIndex = 35
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.BarDockControl1)
        Me.BarManager1.DockControls.Add(Me.BarDockControl2)
        Me.BarManager1.DockControls.Add(Me.BarDockControl3)
        Me.BarManager1.DockControls.Add(Me.BarDockControl4)
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
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem10, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem11, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem12, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem2, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem3, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem4, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem5, True)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Ara,F3"
        Me.BarButtonItem1.Id = 0
        Me.BarButtonItem1.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem1.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem10
        '
        Me.BarButtonItem10.Caption = "Ekle,INS"
        Me.BarButtonItem10.Id = 9
        Me.BarButtonItem10.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem10.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem10.Name = "BarButtonItem10"
        '
        'BarButtonItem11
        '
        Me.BarButtonItem11.Caption = "Düzelt,F4"
        Me.BarButtonItem11.Id = 10
        Me.BarButtonItem11.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem11.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem11.Name = "BarButtonItem11"
        '
        'BarButtonItem12
        '
        Me.BarButtonItem12.Caption = "Sil,Ctrl+Del"
        Me.BarButtonItem12.Id = 11
        Me.BarButtonItem12.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem12.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem12.Name = "BarButtonItem12"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Yazdýr,Ctrl+P"
        Me.BarButtonItem2.Id = 1
        Me.BarButtonItem2.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem2.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem9
        '
        Me.BarButtonItem9.Caption = "Envanter,F6"
        Me.BarButtonItem9.Id = 8
        Me.BarButtonItem9.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem9.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem9.Name = "BarButtonItem9"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Excel"
        Me.BarButtonItem3.Id = 2
        Me.BarButtonItem3.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem3.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "Text"
        Me.BarButtonItem4.Id = 3
        Me.BarButtonItem4.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem4.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "Mail"
        Me.BarButtonItem5.Id = 4
        Me.BarButtonItem5.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem5.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'BarDockControl1
        '
        Me.BarDockControl1.CausesValidation = False
        Me.BarDockControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarDockControl1.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl1.Size = New System.Drawing.Size(824, 0)
        '
        'BarDockControl2
        '
        Me.BarDockControl2.CausesValidation = False
        Me.BarDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BarDockControl2.Location = New System.Drawing.Point(0, 406)
        Me.BarDockControl2.Size = New System.Drawing.Size(824, 23)
        '
        'BarDockControl3
        '
        Me.BarDockControl3.CausesValidation = False
        Me.BarDockControl3.Dock = System.Windows.Forms.DockStyle.Left
        Me.BarDockControl3.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl3.Size = New System.Drawing.Size(0, 406)
        '
        'BarDockControl4
        '
        Me.BarDockControl4.CausesValidation = False
        Me.BarDockControl4.Dock = System.Windows.Forms.DockStyle.Right
        Me.BarDockControl4.Location = New System.Drawing.Point(824, 0)
        Me.BarDockControl4.Size = New System.Drawing.Size(0, 406)
        '
        'BarButtonItem6
        '
        Me.BarButtonItem6.Caption = "Fiþi Göster ,F4"
        Me.BarButtonItem6.Id = 5
        Me.BarButtonItem6.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem6.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem6.Name = "BarButtonItem6"
        '
        'BarButtonItem7
        '
        Me.BarButtonItem7.Caption = "Kalan Taksitleri Goster"
        Me.BarButtonItem7.Id = 6
        Me.BarButtonItem7.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem7.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem7.Name = "BarButtonItem7"
        '
        'BarButtonItem8
        '
        Me.BarButtonItem8.Caption = "Satýþ Bazlý Kalan Taksitler"
        Me.BarButtonItem8.Id = 7
        Me.BarButtonItem8.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem8.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem8.Name = "BarButtonItem8"
        '
        'sec_bAskerliginiYaptimi
        '
        Me.sec_bAskerliginiYaptimi.Location = New System.Drawing.Point(109, 67)
        Me.sec_bAskerliginiYaptimi.MenuManager = Me.BarManager1
        Me.sec_bAskerliginiYaptimi.Name = "sec_bAskerliginiYaptimi"
        Me.sec_bAskerliginiYaptimi.Properties.Caption = "Askerliðini Yaptýmý"
        Me.sec_bAskerliginiYaptimi.Size = New System.Drawing.Size(131, 19)
        Me.sec_bAskerliginiYaptimi.TabIndex = 34
        '
        'sec_sMevcut
        '
        Me.sec_sMevcut.EditValue = "Tümü"
        Me.sec_sMevcut.EnterMoveNextControl = True
        Me.sec_sMevcut.Location = New System.Drawing.Point(111, 47)
        Me.sec_sMevcut.Name = "sec_sMevcut"
        Me.sec_sMevcut.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sMevcut.Properties.Items.AddRange(New Object() {"Tümü", "Evet", "Hayýr"})
        Me.sec_sMevcut.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_sMevcut.Size = New System.Drawing.Size(88, 20)
        Me.sec_sMevcut.TabIndex = 33
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl4.Location = New System.Drawing.Point(63, 48)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl4.TabIndex = 32
        Me.LabelControl4.Text = "Çalýþýyor:"
        '
        'sec_sDurum
        '
        Me.sec_sDurum.EditValue = "Tümü"
        Me.sec_sDurum.Enabled = False
        Me.sec_sDurum.EnterMoveNextControl = True
        Me.sec_sDurum.Location = New System.Drawing.Point(318, 7)
        Me.sec_sDurum.Name = "sec_sDurum"
        Me.sec_sDurum.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sDurum.Properties.Items.AddRange(New Object() {"Tümü", "Giriþler", "Çýkýþlar"})
        Me.sec_sDurum.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_sDurum.Size = New System.Drawing.Size(75, 20)
        Me.sec_sDurum.TabIndex = 31
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl3.Location = New System.Drawing.Point(62, 28)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(45, 13)
        Me.LabelControl3.TabIndex = 30
        Me.LabelControl3.Text = "Personel:"
        '
        'sec_konum
        '
        Me.sec_konum.EditValue = "Adý"
        Me.sec_konum.EnterMoveNextControl = True
        Me.sec_konum.Location = New System.Drawing.Point(237, 27)
        Me.sec_konum.Name = "sec_konum"
        Me.sec_konum.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_konum.Properties.Items.AddRange(New Object() {"Adý", "Soyadý", "Adý+Soyadý"})
        Me.sec_konum.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_konum.Size = New System.Drawing.Size(81, 20)
        Me.sec_konum.TabIndex = 28
        '
        'sec_kriter
        '
        Me.sec_kriter.EditValue = "Baþlar"
        Me.sec_kriter.EnterMoveNextControl = True
        Me.sec_kriter.Location = New System.Drawing.Point(318, 27)
        Me.sec_kriter.Name = "sec_kriter"
        Me.sec_kriter.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_kriter.Properties.Items.AddRange(New Object() {"Baþlar", "Biter", "Eþittir", "Ýçerir", "Boþ", "Dolu", "Farklý", "Büyük", "Küçük", "Aralýk"})
        Me.sec_kriter.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_kriter.Size = New System.Drawing.Size(75, 20)
        Me.sec_kriter.TabIndex = 29
        '
        'txt_ara
        '
        Me.txt_ara.EnterMoveNextControl = True
        Me.txt_ara.Location = New System.Drawing.Point(111, 27)
        Me.txt_ara.Name = "txt_ara"
        Me.txt_ara.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_ara.Properties.Appearance.Options.UseFont = True
        Me.txt_ara.Properties.MaxLength = 15
        Me.txt_ara.Size = New System.Drawing.Size(129, 20)
        Me.txt_ara.TabIndex = 27
        '
        'SimpleButton6
        '
        Me.SimpleButton6.Image = Global.business_smart.My.Resources.Resources.find
        Me.SimpleButton6.Location = New System.Drawing.Point(318, 48)
        Me.SimpleButton6.Name = "SimpleButton6"
        Me.SimpleButton6.Size = New System.Drawing.Size(75, 58)
        Me.SimpleButton6.TabIndex = 21
        Me.SimpleButton6.Text = "&Listele"
        '
        'sec_ekstre_tarih2
        '
        Me.sec_ekstre_tarih2.EditValue = New Date(2078, 12, 31, 0, 0, 0, 0)
        Me.sec_ekstre_tarih2.EnterMoveNextControl = True
        Me.sec_ekstre_tarih2.Location = New System.Drawing.Point(237, 7)
        Me.sec_ekstre_tarih2.Name = "sec_ekstre_tarih2"
        Me.sec_ekstre_tarih2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_ekstre_tarih2.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.sec_ekstre_tarih2.Size = New System.Drawing.Size(81, 20)
        Me.sec_ekstre_tarih2.TabIndex = 2
        '
        'sec_ekstre_tarih1
        '
        Me.sec_ekstre_tarih1.EditValue = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.sec_ekstre_tarih1.EnterMoveNextControl = True
        Me.sec_ekstre_tarih1.Location = New System.Drawing.Point(111, 7)
        Me.sec_ekstre_tarih1.Name = "sec_ekstre_tarih1"
        Me.sec_ekstre_tarih1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_ekstre_tarih1.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.sec_ekstre_tarih1.Size = New System.Drawing.Size(88, 20)
        Me.sec_ekstre_tarih1.TabIndex = 1
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl2.Location = New System.Drawing.Point(36, 7)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(71, 13)
        Me.LabelControl2.TabIndex = 26
        Me.LabelControl2.Text = "Ýþe Giriþ Tarihi:"
        '
        'lbl_Firma
        '
        Me.lbl_Firma.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_Firma.Appearance.ForeColor = System.Drawing.Color.Red
        Me.lbl_Firma.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.lbl_Firma.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lbl_Firma.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_Firma.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbl_Firma.Location = New System.Drawing.Point(551, 2)
        Me.lbl_Firma.Name = "lbl_Firma"
        Me.lbl_Firma.Size = New System.Drawing.Size(267, 124)
        Me.lbl_Firma.TabIndex = 24
        Me.lbl_Firma.Text = "*"
        '
        'Label39
        '
        Me.Label39.Location = New System.Drawing.Point(205, 7)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(12, 13)
        Me.Label39.TabIndex = 22
        Me.Label39.Text = "ve"
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18})
        Me.DataTable1.TableName = "Table1"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "sSeri"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "sSeriAciklama"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "nMiktar"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "nStokID"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "sKodu"
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "sAciklama"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "sModel"
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "sRenk"
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "sBeden"
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "dteIslemTarihi"
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "sFisTipi"
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "dteFisTarihi"
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "lFisNo"
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "sDepo"
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "sSaticiRumuzu"
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "nFirmaID"
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "sFirmaKodu"
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "sFirmaAciklama"
        '
        'ps
        '
        Me.ps.Links.AddRange(New Object() {Me.printlink1, Me.printlink2, Me.printlink})
        '
        'printlink1
        '
        Me.printlink1.Component = Me.GridControl1
        '
        '
        '
        Me.printlink1.ImageCollection.ImageStream = CType(resources.GetObject("printlink1.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.printlink1.Margins = New System.Drawing.Printing.Margins(20, 20, 60, 60)
        Me.printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", "Seri Ekstre", "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Stok Yönetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Me.printlink1.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.printlink1.PrintingSystem = Me.ps
        Me.printlink1.PrintingSystemBase = Me.ps
        '
        'printlink2
        '
        '
        '
        '
        Me.printlink2.ImageCollection.ImageStream = CType(resources.GetObject("printlink2.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.printlink2.Margins = New System.Drawing.Printing.Margins(20, 20, 60, 60)
        Me.printlink2.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.printlink2.PrintingSystem = Me.ps
        Me.printlink2.PrintingSystemBase = Me.ps
        '
        'printlink
        '
        '
        '
        '
        Me.printlink.ImageCollection.ImageStream = CType(resources.GetObject("printlink.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.printlink.Links.AddRange(New Object() {Me.printlink1, Me.printlink2})
        Me.printlink.Margins = New System.Drawing.Printing.Margins(20, 20, 60, 60)
        Me.printlink.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", "", "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Perakende Yönetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Me.printlink.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.printlink.PrintingSystem = Me.ps
        Me.printlink.PrintingSystemBase = Me.ps
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(0, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlBottom.Size = New System.Drawing.Size(0, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 0)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 0)
        '
        'ds_tbPersonelOzluk
        '
        Me.ds_tbPersonelOzluk.DataSetName = "NewDataSet"
        Me.ds_tbPersonelOzluk.Tables.AddRange(New System.Data.DataTable() {Me.DataTable3})
        '
        'DataTable3
        '
        Me.DataTable3.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn136, Me.DataColumn137, Me.DataColumn138, Me.DataColumn139, Me.DataColumn140, Me.DataColumn141, Me.DataColumn142, Me.DataColumn143, Me.DataColumn144, Me.DataColumn145, Me.DataColumn146, Me.DataColumn147, Me.DataColumn148, Me.DataColumn149, Me.DataColumn150, Me.DataColumn151, Me.DataColumn152, Me.DataColumn153, Me.DataColumn154, Me.DataColumn155, Me.DataColumn156, Me.DataColumn157, Me.DataColumn158, Me.DataColumn159, Me.DataColumn160, Me.DataColumn161, Me.DataColumn162, Me.DataColumn163, Me.DataColumn164, Me.DataColumn165, Me.DataColumn166, Me.DataColumn167, Me.DataColumn168, Me.DataColumn169, Me.DataColumn170, Me.DataColumn171, Me.DataColumn172, Me.DataColumn173, Me.DataColumn174, Me.DataColumn175, Me.DataColumn176, Me.DataColumn177, Me.DataColumn178})
        Me.DataTable3.TableName = "Table1"
        '
        'DataColumn136
        '
        Me.DataColumn136.ColumnName = "nPersonelID"
        Me.DataColumn136.DataType = GetType(Long)
        '
        'DataColumn137
        '
        Me.DataColumn137.ColumnName = "sPasaportNumarasi"
        '
        'DataColumn138
        '
        Me.DataColumn138.ColumnName = "bEhliyetiVarmi"
        Me.DataColumn138.DataType = GetType(Boolean)
        '
        'DataColumn139
        '
        Me.DataColumn139.ColumnName = "sEhliyetSinifi"
        '
        'DataColumn140
        '
        Me.DataColumn140.ColumnName = "sVergiDairesi"
        '
        'DataColumn141
        '
        Me.DataColumn141.ColumnName = "sVergiNo"
        '
        'DataColumn142
        '
        Me.DataColumn142.ColumnName = "bAskerliginiYaptimi"
        Me.DataColumn142.DataType = GetType(Boolean)
        '
        'DataColumn143
        '
        Me.DataColumn143.ColumnName = "dteTerhisTarihi"
        Me.DataColumn143.DataType = GetType(Date)
        '
        'DataColumn144
        '
        Me.DataColumn144.ColumnName = "nTecilSuresi"
        Me.DataColumn144.DataType = GetType(Long)
        '
        'DataColumn145
        '
        Me.DataColumn145.ColumnName = "sMernisNo"
        '
        'DataColumn146
        '
        Me.DataColumn146.ColumnName = "sKimlikNo"
        '
        'DataColumn147
        '
        Me.DataColumn147.ColumnName = "sBabaAdi"
        '
        'DataColumn148
        '
        Me.DataColumn148.ColumnName = "sAnneAdi"
        '
        'DataColumn149
        '
        Me.DataColumn149.ColumnName = "sDogumYeri"
        '
        'DataColumn150
        '
        Me.DataColumn150.ColumnName = "dteDogumTarihi"
        Me.DataColumn150.DataType = GetType(Date)
        '
        'DataColumn151
        '
        Me.DataColumn151.ColumnName = "bEvlimi"
        '
        'DataColumn152
        '
        Me.DataColumn152.ColumnName = "sKizlikSoyadi"
        '
        'DataColumn153
        '
        Me.DataColumn153.ColumnName = "bTCVatandasimi"
        Me.DataColumn153.DataType = GetType(Boolean)
        '
        'DataColumn154
        '
        Me.DataColumn154.ColumnName = "sUyrugu"
        '
        'DataColumn155
        '
        Me.DataColumn155.ColumnName = "sDini"
        '
        'DataColumn156
        '
        Me.DataColumn156.ColumnName = "sKanGrubu"
        '
        'DataColumn157
        '
        Me.DataColumn157.ColumnName = "sKayitliIl"
        '
        'DataColumn158
        '
        Me.DataColumn158.ColumnName = "sKayitliIlce"
        '
        'DataColumn159
        '
        Me.DataColumn159.ColumnName = "sKayitliMahKoy"
        '
        'DataColumn160
        '
        Me.DataColumn160.ColumnName = "sKayitliCiltNo"
        '
        'DataColumn161
        '
        Me.DataColumn161.ColumnName = "sKayitliAileNo"
        '
        'DataColumn162
        '
        Me.DataColumn162.ColumnName = "sKayitliSiraNo"
        '
        'DataColumn163
        '
        Me.DataColumn163.ColumnName = "sVerildigiYer"
        '
        'DataColumn164
        '
        Me.DataColumn164.ColumnName = "sVerilisNedeni"
        '
        'DataColumn165
        '
        Me.DataColumn165.ColumnName = "sKayitNo"
        '
        'DataColumn166
        '
        Me.DataColumn166.ColumnName = "dteVerilisTarihi"
        Me.DataColumn166.DataType = GetType(Date)
        '
        'DataColumn167
        '
        Me.DataColumn167.ColumnName = "sEvAdresi1"
        '
        'DataColumn168
        '
        Me.DataColumn168.ColumnName = "sEvAdresi2"
        '
        'DataColumn169
        '
        Me.DataColumn169.ColumnName = "sEvSemt"
        '
        'DataColumn170
        '
        Me.DataColumn170.ColumnName = "sEvPostaKodu"
        '
        'DataColumn171
        '
        Me.DataColumn171.ColumnName = "sEvIl"
        '
        'DataColumn172
        '
        Me.DataColumn172.ColumnName = "sEvTelefonu"
        '
        'DataColumn173
        '
        Me.DataColumn173.ColumnName = "sCepTelefonu"
        '
        'DataColumn174
        '
        Me.DataColumn174.ColumnName = "sE_Posta"
        '
        'DataColumn175
        '
        Me.DataColumn175.ColumnName = "sAileTelefonu"
        '
        'DataColumn176
        '
        Me.DataColumn176.ColumnName = "bEskiHukumlumu"
        Me.DataColumn176.DataType = GetType(Boolean)
        '
        'DataColumn177
        '
        Me.DataColumn177.ColumnName = "bEsiIcinAGIAlacak"
        Me.DataColumn177.DataType = GetType(Boolean)
        '
        'DataColumn178
        '
        Me.DataColumn178.ColumnName = "nAGIAlacakCocukSayisi"
        Me.DataColumn178.DataType = GetType(Long)
        '
        'ds_tbPersonelMeslek
        '
        Me.ds_tbPersonelMeslek.DataSetName = "NewDataSet"
        Me.ds_tbPersonelMeslek.Tables.AddRange(New System.Data.DataTable() {Me.DataTable4})
        '
        'DataTable4
        '
        Me.DataTable4.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn179, Me.DataColumn180, Me.DataColumn181, Me.DataColumn182, Me.DataColumn183, Me.DataColumn184, Me.DataColumn185, Me.DataColumn186, Me.DataColumn187, Me.DataColumn188, Me.DataColumn189, Me.DataColumn190, Me.DataColumn191, Me.DataColumn192, Me.DataColumn193, Me.DataColumn194, Me.DataColumn195, Me.DataColumn196, Me.DataColumn197, Me.DataColumn198, Me.DataColumn199, Me.DataColumn200, Me.DataColumn201, Me.DataColumn202, Me.DataColumn203, Me.DataColumn204, Me.DataColumn205, Me.DataColumn206, Me.DataColumn207, Me.DataColumn208, Me.DataColumn209, Me.DataColumn210})
        Me.DataTable4.TableName = "Table1"
        '
        'DataColumn179
        '
        Me.DataColumn179.ColumnName = "nPersonelID"
        '
        'DataColumn180
        '
        Me.DataColumn180.ColumnName = "sIlkOgrenim"
        '
        'DataColumn181
        '
        Me.DataColumn181.ColumnName = "dteIlkBitisTarihi"
        Me.DataColumn181.DataType = GetType(Date)
        '
        'DataColumn182
        '
        Me.DataColumn182.ColumnName = "sLise"
        '
        'DataColumn183
        '
        Me.DataColumn183.ColumnName = "dteLiseBitisTarihi"
        '
        'DataColumn184
        '
        Me.DataColumn184.ColumnName = "nYuksekOkulID1"
        '
        'DataColumn185
        '
        Me.DataColumn185.ColumnName = "nBolumID1"
        Me.DataColumn185.DataType = GetType(Long)
        '
        'DataColumn186
        '
        Me.DataColumn186.ColumnName = "dteYOBitisTarihi1"
        Me.DataColumn186.DataType = GetType(Date)
        '
        'DataColumn187
        '
        Me.DataColumn187.ColumnName = "nYuksekOkulID2"
        '
        'DataColumn188
        '
        Me.DataColumn188.ColumnName = "nBolumID2"
        Me.DataColumn188.DataType = GetType(Long)
        '
        'DataColumn189
        '
        Me.DataColumn189.ColumnName = "dteYOBitisTarihi2"
        Me.DataColumn189.DataType = GetType(Date)
        '
        'DataColumn190
        '
        Me.DataColumn190.ColumnName = "sMeslek"
        '
        'DataColumn191
        '
        Me.DataColumn191.ColumnName = "nMeslekKidemi"
        Me.DataColumn191.DataType = GetType(Long)
        '
        'DataColumn192
        '
        Me.DataColumn192.ColumnName = "sSonIsyeri"
        '
        'DataColumn193
        '
        Me.DataColumn193.ColumnName = "sSonIsyerindeUnvani"
        '
        'DataColumn194
        '
        Me.DataColumn194.ColumnName = "sSonIsyeriAdresi1"
        '
        'DataColumn195
        '
        Me.DataColumn195.ColumnName = "sSonIsyeriAdresi2"
        '
        'DataColumn196
        '
        Me.DataColumn196.ColumnName = "sSonIsyeriSemt"
        '
        'DataColumn197
        '
        Me.DataColumn197.ColumnName = "sSonIsyeriPostaKodu"
        '
        'DataColumn198
        '
        Me.DataColumn198.ColumnName = "sSonIsyeriIl"
        '
        'DataColumn199
        '
        Me.DataColumn199.ColumnName = "sSonSicilNo"
        '
        'DataColumn200
        '
        Me.DataColumn200.ColumnName = "sSonKurum"
        '
        'DataColumn201
        '
        Me.DataColumn201.ColumnName = "nYabanciDilID1"
        Me.DataColumn201.DataType = GetType(Long)
        '
        'DataColumn202
        '
        Me.DataColumn202.ColumnName = "nYDSeviye1"
        Me.DataColumn202.DataType = GetType(Long)
        '
        'DataColumn203
        '
        Me.DataColumn203.ColumnName = "nYabanciDilID2"
        Me.DataColumn203.DataType = GetType(System.Guid)
        '
        'DataColumn204
        '
        Me.DataColumn204.ColumnName = "nYDSeviye2"
        Me.DataColumn204.DataType = GetType(Long)
        '
        'DataColumn205
        '
        Me.DataColumn205.ColumnName = "nYabanciDilID3"
        Me.DataColumn205.DataType = GetType(Long)
        '
        'DataColumn206
        '
        Me.DataColumn206.ColumnName = "nYDSeviye3"
        Me.DataColumn206.DataType = GetType(Long)
        '
        'DataColumn207
        '
        Me.DataColumn207.ColumnName = "nOgrenimDurumu"
        '
        'DataColumn208
        '
        Me.DataColumn208.ColumnName = "sOgrenimDurumuDiger"
        '
        'DataColumn209
        '
        Me.DataColumn209.ColumnName = "bAylikAliyormu"
        Me.DataColumn209.DataType = GetType(Boolean)
        '
        'DataColumn210
        '
        Me.DataColumn210.ColumnName = "nSSKAylikAliyormu"
        Me.DataColumn210.DataType = GetType(Long)
        '
        'ds_tbPersonel
        '
        Me.ds_tbPersonel.DataSetName = "NewDataSet"
        Me.ds_tbPersonel.Tables.AddRange(New System.Data.DataTable() {Me.DataTable5})
        '
        'DataTable5
        '
        Me.DataTable5.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn211, Me.DataColumn212, Me.DataColumn213, Me.DataColumn214, Me.DataColumn215, Me.DataColumn216, Me.DataColumn217, Me.DataColumn218, Me.DataColumn219, Me.DataColumn220, Me.DataColumn221, Me.DataColumn222, Me.DataColumn223, Me.DataColumn224, Me.DataColumn225, Me.DataColumn226, Me.DataColumn227, Me.DataColumn228, Me.DataColumn229, Me.DataColumn230, Me.DataColumn231, Me.DataColumn232, Me.DataColumn233, Me.DataColumn234, Me.DataColumn235, Me.DataColumn236, Me.DataColumn237, Me.DataColumn238, Me.DataColumn239, Me.DataColumn240, Me.DataColumn241, Me.DataColumn242, Me.DataColumn243, Me.DataColumn244, Me.DataColumn245, Me.DataColumn246, Me.DataColumn247, Me.DataColumn248})
        Me.DataTable5.TableName = "Table1"
        '
        'DataColumn211
        '
        Me.DataColumn211.ColumnName = "nPersonelID"
        Me.DataColumn211.DataType = GetType(Long)
        '
        'DataColumn212
        '
        Me.DataColumn212.ColumnName = "lSicilNo"
        Me.DataColumn212.DataType = GetType(Long)
        '
        'DataColumn213
        '
        Me.DataColumn213.ColumnName = "sDepartmanKodu"
        Me.DataColumn213.DefaultValue = ""
        '
        'DataColumn214
        '
        Me.DataColumn214.ColumnName = "sAdi"
        '
        'DataColumn215
        '
        Me.DataColumn215.ColumnName = "sIkinciAdi"
        '
        'DataColumn216
        '
        Me.DataColumn216.ColumnName = "sSoyadi"
        '
        'DataColumn217
        '
        Me.DataColumn217.ColumnName = "nCinsiyet"
        Me.DataColumn217.DefaultValue = "1"
        '
        'DataColumn218
        '
        Me.DataColumn218.ColumnName = "sAkedemikUnvani"
        Me.DataColumn218.DefaultValue = " "
        '
        'DataColumn219
        '
        Me.DataColumn219.ColumnName = "sUnvan"
        Me.DataColumn219.DefaultValue = ""
        '
        'DataColumn220
        '
        Me.DataColumn220.ColumnName = "bSSKKesilecekmi"
        Me.DataColumn220.DataType = GetType(Boolean)
        Me.DataColumn220.DefaultValue = False
        '
        'DataColumn221
        '
        Me.DataColumn221.ColumnName = "bIssizlikKesilecekmi"
        Me.DataColumn221.DataType = GetType(Boolean)
        Me.DataColumn221.DefaultValue = False
        '
        'DataColumn222
        '
        Me.DataColumn222.ColumnName = "sSSKSicilNo"
        Me.DataColumn222.DefaultValue = " "
        '
        'DataColumn223
        '
        Me.DataColumn223.ColumnName = "sSSKStatusu"
        Me.DataColumn223.DefaultValue = "1"
        '
        'DataColumn224
        '
        Me.DataColumn224.ColumnName = "sVergiStatusu"
        Me.DataColumn224.DefaultValue = "11"
        '
        'DataColumn225
        '
        Me.DataColumn225.ColumnName = "lTTFToplamOdenen"
        Me.DataColumn225.DataType = GetType(Decimal)
        '
        'DataColumn226
        '
        Me.DataColumn226.ColumnName = "sTTFNumarasi"
        '
        'DataColumn227
        '
        Me.DataColumn227.ColumnName = "bBrutUcretlimi"
        Me.DataColumn227.DataType = GetType(Boolean)
        Me.DataColumn227.DefaultValue = False
        '
        'DataColumn228
        '
        Me.DataColumn228.ColumnName = "sSaatGunlukAylik"
        '
        'DataColumn229
        '
        Me.DataColumn229.ColumnName = "sUcretDovizCinsi"
        Me.DataColumn229.DefaultValue = " "
        '
        'DataColumn230
        '
        Me.DataColumn230.ColumnName = "lBirimUcret"
        Me.DataColumn230.DataType = GetType(Decimal)
        Me.DataColumn230.DefaultValue = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DataColumn231
        '
        Me.DataColumn231.ColumnName = "sBankaHesapNo"
        Me.DataColumn231.DefaultValue = " "
        '
        'DataColumn232
        '
        Me.DataColumn232.ColumnName = "sBankaHesapNoKS"
        Me.DataColumn232.DefaultValue = " "
        '
        'DataColumn233
        '
        Me.DataColumn233.ColumnName = "dteIseGirisTarihi"
        Me.DataColumn233.DataType = GetType(Date)
        Me.DataColumn233.DefaultValue = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'DataColumn234
        '
        Me.DataColumn234.ColumnName = "dteIstenCikisTarihi"
        Me.DataColumn234.DataType = GetType(Date)
        Me.DataColumn234.DefaultValue = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'DataColumn235
        '
        Me.DataColumn235.ColumnName = "sCikisSebebi"
        '
        'DataColumn236
        '
        Me.DataColumn236.ColumnName = "bCalisiyormu"
        Me.DataColumn236.DataType = GetType(Boolean)
        Me.DataColumn236.DefaultValue = False
        '
        'DataColumn237
        '
        Me.DataColumn237.ColumnName = "nCocukAd"
        Me.DataColumn237.DataType = GetType(Long)
        Me.DataColumn237.DefaultValue = CType(0, Long)
        '
        'DataColumn238
        '
        Me.DataColumn238.ColumnName = "nCocukAdOkulOncesi"
        Me.DataColumn238.DataType = GetType(Long)
        Me.DataColumn238.DefaultValue = CType(0, Long)
        '
        'DataColumn239
        '
        Me.DataColumn239.ColumnName = "nCocukAdIlkOgrenim"
        Me.DataColumn239.DataType = GetType(Long)
        Me.DataColumn239.DefaultValue = CType(0, Long)
        '
        'DataColumn240
        '
        Me.DataColumn240.ColumnName = "nCocukAdLise"
        Me.DataColumn240.DataType = GetType(Long)
        Me.DataColumn240.DefaultValue = CType(0, Long)
        '
        'DataColumn241
        '
        Me.DataColumn241.ColumnName = "nCocukAdYuksek"
        Me.DataColumn241.DataType = GetType(Long)
        Me.DataColumn241.DefaultValue = CType(0, Long)
        '
        'DataColumn242
        '
        Me.DataColumn242.ColumnName = "lOzelSagSigAylikPrimi"
        Me.DataColumn242.DataType = GetType(Decimal)
        Me.DataColumn242.DefaultValue = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DataColumn243
        '
        Me.DataColumn243.ColumnName = "bSendikaUyesimi"
        Me.DataColumn243.DataType = GetType(Boolean)
        Me.DataColumn243.DefaultValue = False
        '
        'DataColumn244
        '
        Me.DataColumn244.ColumnName = "sResimAdi"
        Me.DataColumn244.DefaultValue = " "
        '
        'DataColumn245
        '
        Me.DataColumn245.ColumnName = "dteOzelSSBaslangic"
        Me.DataColumn245.DataType = GetType(Date)
        Me.DataColumn245.DefaultValue = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'DataColumn246
        '
        Me.DataColumn246.ColumnName = "sKullaniciAdi"
        '
        'DataColumn247
        '
        Me.DataColumn247.ColumnName = "dteKayitTarihi"
        Me.DataColumn247.DataType = GetType(Date)
        '
        'DataColumn248
        '
        Me.DataColumn248.ColumnName = "lOzelEmekSigAylikPrimi"
        Me.DataColumn248.DataType = GetType(Decimal)
        Me.DataColumn248.DefaultValue = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'colnPersonelID
        '
        Me.colnPersonelID.Caption = "KayýtNo"
        Me.colnPersonelID.FieldName = "nPersonelID"
        Me.colnPersonelID.Name = "colnPersonelID"
        '
        'collSicilNo
        '
        Me.collSicilNo.Caption = "SicilNo"
        Me.collSicilNo.FieldName = "lSicilNo"
        Me.collSicilNo.Name = "collSicilNo"
        Me.collSicilNo.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "lSicilNo", "{0} Kayýt")})
        Me.collSicilNo.Visible = True
        Me.collSicilNo.VisibleIndex = 0
        Me.collSicilNo.Width = 112
        '
        'colsDepartmanKodu
        '
        Me.colsDepartmanKodu.Caption = "Departman"
        Me.colsDepartmanKodu.FieldName = "sDepartmanKodu"
        Me.colsDepartmanKodu.Name = "colsDepartmanKodu"
        Me.colsDepartmanKodu.Visible = True
        Me.colsDepartmanKodu.VisibleIndex = 1
        '
        'colsAdi
        '
        Me.colsAdi.Caption = "Adý"
        Me.colsAdi.FieldName = "sAdi"
        Me.colsAdi.Name = "colsAdi"
        Me.colsAdi.Visible = True
        Me.colsAdi.VisibleIndex = 2
        Me.colsAdi.Width = 172
        '
        'colsIkinciAdi
        '
        Me.colsIkinciAdi.Caption = "Ýkinci Adý"
        Me.colsIkinciAdi.FieldName = "sIkinciAdi"
        Me.colsIkinciAdi.Name = "colsIkinciAdi"
        Me.colsIkinciAdi.Visible = True
        Me.colsIkinciAdi.VisibleIndex = 3
        Me.colsIkinciAdi.Width = 172
        '
        'colsSoyadi
        '
        Me.colsSoyadi.Caption = "Soyadý"
        Me.colsSoyadi.FieldName = "sSoyadi"
        Me.colsSoyadi.Name = "colsSoyadi"
        Me.colsSoyadi.Visible = True
        Me.colsSoyadi.VisibleIndex = 4
        Me.colsSoyadi.Width = 172
        '
        'colnCinsiyet
        '
        Me.colnCinsiyet.Caption = "Cinsiyet"
        Me.colnCinsiyet.FieldName = "nCinsiyet"
        Me.colnCinsiyet.Name = "colnCinsiyet"
        Me.colnCinsiyet.Visible = True
        Me.colnCinsiyet.VisibleIndex = 5
        Me.colnCinsiyet.Width = 172
        '
        'colsAkedemikUnvani
        '
        Me.colsAkedemikUnvani.Caption = "Akademik Ünvan"
        Me.colsAkedemikUnvani.FieldName = "sAkedemikUnvani"
        Me.colsAkedemikUnvani.Name = "colsAkedemikUnvani"
        Me.colsAkedemikUnvani.Width = 172
        '
        'colsUnvan
        '
        Me.colsUnvan.Caption = "Ünvan"
        Me.colsUnvan.FieldName = "sUnvan"
        Me.colsUnvan.Name = "colsUnvan"
        Me.colsUnvan.Visible = True
        Me.colsUnvan.VisibleIndex = 6
        Me.colsUnvan.Width = 188
        '
        'colbSSKKesilecekmi
        '
        Me.colbSSKKesilecekmi.Caption = "SSK Kesilecekmi"
        Me.colbSSKKesilecekmi.FieldName = "bSSKKesilecekmi"
        Me.colbSSKKesilecekmi.Name = "colbSSKKesilecekmi"
        '
        'colbIssizlikKesilecekmi
        '
        Me.colbIssizlikKesilecekmi.Caption = "Ýþsizlik Kesilecekmi"
        Me.colbIssizlikKesilecekmi.FieldName = "bIssizlikKesilecekmi"
        Me.colbIssizlikKesilecekmi.Name = "colbIssizlikKesilecekmi"
        '
        'colsSSKSicilNo
        '
        Me.colsSSKSicilNo.Caption = "SSK Sicil No"
        Me.colsSSKSicilNo.FieldName = "sSSKSicilNo"
        Me.colsSSKSicilNo.Name = "colsSSKSicilNo"
        '
        'colsSSKStatusu
        '
        Me.colsSSKStatusu.Caption = "SSK Statüsü"
        Me.colsSSKStatusu.FieldName = "sSSKStatusu"
        Me.colsSSKStatusu.Name = "colsSSKStatusu"
        '
        'colsVergiStatusu
        '
        Me.colsVergiStatusu.Caption = "Vergi Statüsü"
        Me.colsVergiStatusu.FieldName = "sVergiStatusu"
        Me.colsVergiStatusu.Name = "colsVergiStatusu"
        '
        'collTTFToplamOdenen
        '
        Me.collTTFToplamOdenen.FieldName = "lTTFToplamOdenen"
        Me.collTTFToplamOdenen.Name = "collTTFToplamOdenen"
        '
        'colsTTFNumarasi
        '
        Me.colsTTFNumarasi.FieldName = "sTTFNumarasi"
        Me.colsTTFNumarasi.Name = "colsTTFNumarasi"
        '
        'colbBrutUcretlimi
        '
        Me.colbBrutUcretlimi.Caption = "Brüt Ücret?"
        Me.colbBrutUcretlimi.FieldName = "bBrutUcretlimi"
        Me.colbBrutUcretlimi.Name = "colbBrutUcretlimi"
        '
        'colsSaatGunlukAylik
        '
        Me.colsSaatGunlukAylik.Caption = "SaatGunlukAylik"
        Me.colsSaatGunlukAylik.FieldName = "sSaatGunlukAylik"
        Me.colsSaatGunlukAylik.Name = "colsSaatGunlukAylik"
        '
        'colsUcretDovizCinsi
        '
        Me.colsUcretDovizCinsi.Caption = "DövizCinsi"
        Me.colsUcretDovizCinsi.FieldName = "sUcretDovizCinsi"
        Me.colsUcretDovizCinsi.Name = "colsUcretDovizCinsi"
        '
        'collBirimUcret
        '
        Me.collBirimUcret.Caption = "BirimÜcret"
        Me.collBirimUcret.FieldName = "lBirimUcret"
        Me.collBirimUcret.Name = "collBirimUcret"
        '
        'colsBankaHesapNo
        '
        Me.colsBankaHesapNo.Caption = "IBAN"
        Me.colsBankaHesapNo.FieldName = "sBankaHesapNo"
        Me.colsBankaHesapNo.Name = "colsBankaHesapNo"
        '
        'colsBankaHesapNoKS
        '
        Me.colsBankaHesapNoKS.Caption = "IbanKontrol"
        Me.colsBankaHesapNoKS.FieldName = "sBankaHesapNoKS"
        Me.colsBankaHesapNoKS.Name = "colsBankaHesapNoKS"
        '
        'coldteIseGirisTarihi
        '
        Me.coldteIseGirisTarihi.Caption = "Ýþe Giriþ Tarihi"
        Me.coldteIseGirisTarihi.FieldName = "dteIseGirisTarihi"
        Me.coldteIseGirisTarihi.Name = "coldteIseGirisTarihi"
        '
        'coldteIstenCikisTarihi
        '
        Me.coldteIstenCikisTarihi.Caption = "Ýþten Çýkýþ Tarihi"
        Me.coldteIstenCikisTarihi.FieldName = "dteIstenCikisTarihi"
        Me.coldteIstenCikisTarihi.Name = "coldteIstenCikisTarihi"
        '
        'colsCikisSebebi
        '
        Me.colsCikisSebebi.Caption = "Çýkýþ Sebebi"
        Me.colsCikisSebebi.FieldName = "sCikisSebebi"
        Me.colsCikisSebebi.Name = "colsCikisSebebi"
        '
        'colbCalisiyormu
        '
        Me.colbCalisiyormu.Caption = "Baþka Yerde Çalýþýyor"
        Me.colbCalisiyormu.FieldName = "bCalisiyormu"
        Me.colbCalisiyormu.Name = "colbCalisiyormu"
        '
        'colnCocukAd
        '
        Me.colnCocukAd.Caption = "Çocuk Sayýsý"
        Me.colnCocukAd.FieldName = "nCocukAd"
        Me.colnCocukAd.Name = "colnCocukAd"
        '
        'colnCocukAdOkulOncesi
        '
        Me.colnCocukAdOkulOncesi.Caption = "Okul Öncesi Çocuk"
        Me.colnCocukAdOkulOncesi.FieldName = "nCocukAdOkulOncesi"
        Me.colnCocukAdOkulOncesi.Name = "colnCocukAdOkulOncesi"
        '
        'colnCocukAdIlkOgrenim
        '
        Me.colnCocukAdIlkOgrenim.Caption = "Ýlk Öðrenim Çocuk"
        Me.colnCocukAdIlkOgrenim.FieldName = "nCocukAdIlkOgrenim"
        Me.colnCocukAdIlkOgrenim.Name = "colnCocukAdIlkOgrenim"
        '
        'colnCocukAdLise
        '
        Me.colnCocukAdLise.Caption = "Lise Çaðýnda Çocuk"
        Me.colnCocukAdLise.FieldName = "nCocukAdLise"
        Me.colnCocukAdLise.Name = "colnCocukAdLise"
        '
        'colnCocukAdYuksek
        '
        Me.colnCocukAdYuksek.Caption = "Yüksek Okulda Çocuk"
        Me.colnCocukAdYuksek.FieldName = "nCocukAdYuksek"
        Me.colnCocukAdYuksek.Name = "colnCocukAdYuksek"
        '
        'collOzelSagSigAylikPrimi
        '
        Me.collOzelSagSigAylikPrimi.Caption = "Özel Saðlýk Sigortasý Aylýk Primi"
        Me.collOzelSagSigAylikPrimi.FieldName = "lOzelSagSigAylikPrimi"
        Me.collOzelSagSigAylikPrimi.Name = "collOzelSagSigAylikPrimi"
        '
        'colbSendikaUyesimi
        '
        Me.colbSendikaUyesimi.Caption = "Sendika Üyesi"
        Me.colbSendikaUyesimi.FieldName = "bSendikaUyesimi"
        Me.colbSendikaUyesimi.Name = "colbSendikaUyesimi"
        '
        'coldteOzelSSBaslangic
        '
        Me.coldteOzelSSBaslangic.Caption = "Ö.S.S Baþlangýç"
        Me.coldteOzelSSBaslangic.FieldName = "dteOzelSSBaslangic"
        Me.coldteOzelSSBaslangic.Name = "coldteOzelSSBaslangic"
        '
        'colsKullaniciAdi
        '
        Me.colsKullaniciAdi.Caption = "Kaydeden"
        Me.colsKullaniciAdi.FieldName = "sKullaniciAdi"
        Me.colsKullaniciAdi.Name = "colsKullaniciAdi"
        '
        'coldteKayitTarihi
        '
        Me.coldteKayitTarihi.Caption = "KayýtTarihi"
        Me.coldteKayitTarihi.FieldName = "dteKayitTarihi"
        Me.coldteKayitTarihi.Name = "coldteKayitTarihi"
        '
        'collOzelEmekSigAylikPrimi
        '
        Me.collOzelEmekSigAylikPrimi.Caption = "Ö.Emeklilik Aylýk Primi"
        Me.collOzelEmekSigAylikPrimi.FieldName = "lOzelEmekSigAylikPrimi"
        Me.collOzelEmekSigAylikPrimi.Name = "collOzelEmekSigAylikPrimi"
        '
        'frm_tbPersonel_Liste
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(824, 429)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.BarDockControl3)
        Me.Controls.Add(Me.BarDockControl4)
        Me.Controls.Add(Me.BarDockControl2)
        Me.Controls.Add(Me.BarDockControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_tbPersonel_Liste"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Personel Listesi"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl5.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_tbIsBasvurusuForm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_Cinsiyet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_YuksekOkul, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_Bolum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_Dil, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_DilSeviye, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl4.ResumeLayout(False)
        Me.PanelControl4.PerformLayout()
        CType(Me.sec_sBasvuruPosizyonu1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_nCinsiyet.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sEhliyet.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_bEhliyetiVarmi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_bAskerliginiYaptimi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sMevcut.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sDurum.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_konum.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_kriter.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ara.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_ekstre_tarih2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_ekstre_tarih2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_ekstre_tarih1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_ekstre_tarih1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.printlink2.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.printlink.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_tbPersonelOzluk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_tbPersonelMeslek, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_tbPersonel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub
#End Region
    Public firmano
    Public donemno
    Public connection
    Public musterino
    Public musteriID
    Public kasiyerno
    Public kullanici
    Public islem As String = "Ekstre"
    Dim ds_ekstre As DataSet
    Dim ds_OdemelerKalan As DataSet
    Dim ds_tbCinsiyet As DataSet
    Dim ds_tbYabanciDil As DataSet
    Dim ds_tbYabanciDilSeviye As DataSet
    Dim ds_tbYuksekOkul As DataSet
    Dim ds_tbYuksekOkulBolum As DataSet
    Dim ds_tbIsPozisyonu As DataSet
    Private Sub frm_cari_faturalar_acik_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
        dataload_tbCinsiyet()
        dataload_tbIl()
        dataload_tbYabanciDil()
        dataload_tbYuksekOkul()
        dataload_tbIsPozisyonu()
        sec_ekstre_tarih2.EditValue = "01/01/1900"
        sec_ekstre_tarih2.EditValue = dteSistemTarihi
        txt_ara.Focus()
        txt_ara.SelectAll()
    End Sub
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
    Private Sub MenuItem13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem13.Click
        Me.Close()
    End Sub
    Private Sub MenuItem14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem14.Click
        Me.Close()
    End Sub
    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        gorunum_yazdir()
    End Sub
    Private Sub gorunum_yazdir()
        Dim kriter As String = ""
        kriter += Microsoft.VisualBasic.Left(sec_ekstre_tarih1.EditValue, 10).ToString
        kriter += " ve "
        kriter += Microsoft.VisualBasic.Left(sec_ekstre_tarih2.EditValue, 10).ToString
        kriter += " Tarihleri Arasýndaki Baþvurular "
        printlink.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", kriter, "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Ýnsan Kaynaklarý", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        printlink.CreateDocument(ps)
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
                'VGrid_Baslik.Appearance.RecordValue.Font = New System.Drawing.Font("Tahoma", sayi, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
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
    Private Function sorgu_query(ByVal query As String) As String
        query = Replace(query, "*!F", "F0" + firmano.ToString)
        query = Replace(query, "!D", "D000" + donemno.ToString)
        Return query
    End Function
    Private Sub dataload_tbIl()
        'ds_tbIl = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sIl FROM         tbIl order by sIl"))
        'txt_sEvIl.Properties.DataSource = ds_tbIl.Tables(0)
        'sec_sAcil1Il.Properties.DataSource = ds_tbIl.Tables(0)
        'sec_sAcil2Il.Properties.DataSource = ds_tbIl.Tables(0)
        'txt_sEvIl.Properties.DataSource = ds_tbIl.Tables(0)
    End Sub
    Private Sub dataload_tbIsPozisyonu()
        ds_tbIsPozisyonu = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sIsKodu, sAciklama FROM         tbIsPozisyonu"))
        sec_sBasvuruPosizyonu1.Properties.DataSource = ds_tbIsPozisyonu.Tables(0)
        'sec_sBasvuruPosizyonu2.Properties.DataSource = ds_tbIsPozisyonu.Tables(0)
        'sec_sBasvuruPosizyonu3.Properties.DataSource = ds_tbIsPozisyonu.Tables(0)
    End Sub
    Private Sub dataload_tbYabanciDil()
        ds_tbYabanciDil = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     nYabanciDilID, sYabanciDil FROM         tbYabanciDil ORDER BY sYabanciDil"))
        sec_Dil.DataSource = ds_tbYabanciDil.Tables(0)
        'sec_nYabanciDilID2.Properties.DataSource = ds_tbYabanciDil.Tables(0)
        'sec_nYabanciDilID3.Properties.DataSource = ds_tbYabanciDil.Tables(0)
        ds_tbYabanciDilSeviye = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED  SELECT     nYDSeviye, sAciklama FROM         tbYabanciDilSeviye"))
        sec_DilSeviye.DataSource = ds_tbYabanciDilSeviye.Tables(0)
        'sec_nYDSeviye2.Properties.DataSource = ds_tbYabanciDilSeviye.Tables(0)
        'sec_nYDSeviye3.Properties.DataSource = ds_tbYabanciDilSeviye.Tables(0)
    End Sub
    Private Sub dataload_tbYuksekOkul()
        ds_tbYuksekOkul = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     nYuksekOkulID, sYuksekOkul FROM         tbYuksekOkul"))
        sec_YuksekOkul.DataSource = ds_tbYuksekOkul.Tables(0)
        'sec_nYuksekOkulID2.Properties.DataSource = ds_tbYuksekOkul.Tables(0)
        'sec_nYuksekOkulID3.Properties.DataSource = ds_tbYuksekOkul.Tables(0)
        ds_tbYuksekOkulBolum = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED  SELECT     nBolumID, sBolum FROM         tbYuksekOkulBolum"))
        sec_Bolum.DataSource = ds_tbYuksekOkulBolum.Tables(0)
        'sec_nBolumID2.Properties.DataSource = ds_tbYuksekOkulBolum.Tables(0)
        'sec_nBolumID3.Properties.DataSource = ds_tbYuksekOkulBolum.Tables(0)
    End Sub
    Private Sub dataload_tbCinsiyet()
        ds_tbCinsiyet = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbCinsiyet"))
        txt_nCinsiyet.Properties.DataSource = ds_tbCinsiyet.Tables(0)
        sec_Cinsiyet.DataSource = ds_tbCinsiyet.Tables(0)
    End Sub
    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        gorunum_kaydet()
    End Sub
    Private Sub MenuItem16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        incele_basvuru()
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
    Private Sub incele()
        ds_ekstre = sorgu_ekstre_detayli(musterino, sec_ekstre_tarih1.EditValue, sec_ekstre_tarih2.EditValue, txt_ara.EditValue, sec_konum.Text, sec_kriter.Text)
        GridControl1.DataSource = ds_ekstre.Tables(0)
        GridControl1.DataMember = Nothing
        GridControl1.Focus()
        GridControl1.Select()
        If GridView1.RowCount > 0 Then
            GridView1.ClearSelection()
            GridView1.FocusedRowHandle = GridView1.RowCount - 1
            GridView1.SelectRow(GridView1.FocusedRowHandle)
            GridControl1.Focus()
        End If
    End Sub
    Public Function sorgu_ekstre_detayli(ByVal sSeri As String, ByVal tarih1 As DateTime, ByVal tarih2 As DateTime, ByVal ara As String, ByVal konum As String, ByVal ara_kriter As String) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        Dim kriter As String = ""
        kriter += " Where dteIseGirisTarihi between '" & tarih1 & "' and '" & tarih2 & "' "
        If sec_bAskerliginiYaptimi.Checked = True Then
            kriter += " and bAskerliginiYaptimi = 1"
        End If
        If sec_bEhliyetiVarmi.Checked = True Then
            kriter += " and bEhliyetiVarmi = 1 "
        End If
        If Trim(txt_nCinsiyet.EditValue) <> "" Then
            kriter += " and nCinsiyet = '" & txt_nCinsiyet.EditValue & "' "
        End If
        'If sec_sMevcut.SelectedIndex = 0 Then
        'ElseIf sec_sMevcut.SelectedIndex = 1 Then
        '    kriter += " and bIseAlindi = 1 "
        'ElseIf sec_sMevcut.SelectedIndex = 2 Then
        '    kriter += " and bIseAlindi = 0 "
        'End If
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbPersonel  ")
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
        conn.Close()
        Return Datastoklar1
    End Function
    Private Sub raporla_excel()
        If XtraMessageBox.Show(Sorgu_sDil("Sonuçlarý Excel Dosyasý Oluþturmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim SaveFileDialog1 As New Windows.Forms.SaveFileDialog
            SaveFileDialog1.Filter = "Excel Dosyalarý(*.xls) |*.xls"
            SaveFileDialog1.InitialDirectory = "c:\"
            SaveFileDialog1.FileName = "Basvuru.xls"
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
            SaveFileDialog1.FileName = "Basvuru.txt"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                GridView1.ExportToText(SaveFileDialog1.FileName.ToString)
                If XtraMessageBox.Show(Sorgu_sDil("Kaydý Açmak Ýster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    Process.Start(SaveFileDialog1.FileName.ToString)
                End If
            End If
            SaveFileDialog1 = Nothing
        End If
    End Sub
    Private Sub raporla_rtf()
        If XtraMessageBox.Show(Sorgu_sDil("Sonuçlarý Metin Dosyasý Oluþturmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim SaveFileDialog1 As New Windows.Forms.SaveFileDialog
            SaveFileDialog1.Filter = "Metin Dosyalarý(*.rtf) |*.rtf"
            SaveFileDialog1.InitialDirectory = "c:\"
            SaveFileDialog1.FileName = "Basvuru.rtf"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                GridView1.ExportToRtf(SaveFileDialog1.FileName.ToString)
                If XtraMessageBox.Show(Sorgu_sDil("Kaydý Açmak Ýster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    Process.Start(SaveFileDialog1.FileName.ToString)
                End If
            End If
            SaveFileDialog1 = Nothing
        End If
    End Sub
    Private Sub SimpleButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton6.Click
        incele()
    End Sub
    Private Sub frm_cari_ekstre_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        'PanelControl1 = Nothing
        'PanelControl2 = Nothing
        'PanelControl3 = Nothing
        'Label2 = Nothing
        'SimpleButton2 = Nothing
        'SimpleButton1 = Nothing
        'Label1 = Nothing
        'PictureBox1 = Nothing
        'DataSet1.Clear()
        'DataSet1.Dispose()
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
        'Label39 = Nothing
        'SimpleButton6 = Nothing
        'Label40 = Nothing
        'sec_ekstre_tarih2 = Nothing
        'sec_ekstre_tarih1 = Nothing
        'PanelControl5 = Nothing
        'GridControl1 = Nothing
        'GridView1 = Nothing
        'collKodu = Nothing
        'colsMusteriAdi = Nothing
        'coldteTarih = Nothing
        'colfisTipi = Nothing
        'collNo = Nothing
        'colsKodu = Nothing
        'colsStokAciklama = Nothing
        'colMiktar = Nothing
        'colFiyat = Nothing
        'colIskonto = Nothing
        'collNetTutar1 = Nothing
        'colOdemeTutar = Nothing
        'colOdemeTipi = Nothing
        'colSaticiRumuzu = Nothing
        'colKasiyerRumuzu = Nothing
        'colTeslimatci = Nothing
        'colId = Nothing
        'colOdemeAciklama = Nothing
        'colTipi = Nothing
        'colGirisCikis = Nothing
        'colIadeAvInf = Nothing
        'collMalBedeli = Nothing
        'colsHareketTipi = Nothing
        'colnIslemId = Nothing
        'colStokOdeme = Nothing
        'colSevkAciklama = Nothing
        'colKayitTarihi = Nothing
        'MenuItem17 = Nothing
        'MenuItem18 = Nothing
        'MenuItem19 = Nothing
        'MenuItem20 = Nothing
        'Me.Close()
        System.GC.Collect()
        System.GC.SuppressFinalize(Me)
    End Sub
    Private Sub GridControl1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridControl1.DoubleClick
        incele_basvuru()
    End Sub
    Private Sub GridControl1_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        gorunum_yazdir()
    End Sub
    Private Sub BarButtonItem3_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        raporla_excel()
    End Sub
    Private Sub BarButtonItem4_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        raporla_text()
    End Sub
    Private Sub BarButtonItem5_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        raporla_rtf()
    End Sub
    Private Sub MenuItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem17.Click
        analiz_envanter()
    End Sub
    Private Sub BarButtonItem6_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        incele_basvuru()
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
            incele_basvuru()
        End If
    End Sub
    Private Sub analiz_envanter()
        'If GridView1.RowCount > 0 Then
        '    Dim dr As DataRow
        '    dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        '    Dim frm As New frm_stok_envanter
        '    frm.firmano = firmano
        '    frm.donemno = donemno
        '    frm.connection = connection
        '    frm.stokno = dr("nStokID")
        '    frm.stokkodu = dr("sKodu")
        '    frm.kullanici = kullanici
        '    If yetki_kontrol(kullanici, frm.Name) = True Then
        '        frm.ShowDialog()
        '    End If
        '    frm.Close()
        '    frm.Dispose()
        '    frm = Nothing
        'End If
    End Sub
    Private Sub stok_fiyat()
        'If GridView1.RowCount > 0 Then
        '    Dim dr As DataRow
        '    dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        '    Dim frm As New frm_stok_fiyatlandir
        '    frm.firmano = firmano
        '    frm.donemno = donemno
        '    frm.connection = connection
        '    frm.nStokID = dr("nStokId")
        '    frm.sModel = dr("sModel")
        '    frm.sKodu = dr("sKodu")
        '    frm.sRenk = dr("sRenk")
        '    frm.sBeden = dr("sBeden")
        '    frm.txt_musteriNo.Text = dr("sModel")
        '    frm.kullanici = kullanici
        '    If yetki_kontrol(kullanici, frm.Name) = True Then
        '        frm.ShowDialog()
        '    End If
        '    frm.Close()
        '    frm.Dispose()
        '    frm = Nothing
        'End If
    End Sub
    Private Sub tbIsBasvuruFormu_Ekle()
        Dim frm As New frm_tbPersonel
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.kullanici = kullanici
        frm.yeni = True
        frm.nPersonelID = 0
        frm.txt_nPersonelID.Text = frm.nPersonelID
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.Show()
        End If
    End Sub
    Private Sub incele_basvuru()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_tbPersonel
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.yeni = False
            frm.nPersonelID = dr("nPersonelID")
            frm.kullanici = kullanici
            Dim satir = GridView1.FocusedRowHandle
            If yetki_kontrol(kullanici, frm.Name) = True Then
                Try
                    frm.ShowDialog()
                Catch ex As Exception
                End Try
            End If
            frm.Close()
            frm = Nothing
            dr = Nothing
            GridView1.FocusedRowHandle = satir
            satir = Nothing
        End If
    End Sub
    Private Sub satir_sil()
        If XtraMessageBox.Show(Sorgu_sDil("Seçili Kayýtlarý Silmek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim s As String
            Dim arr As Integer()
            Dim i As Integer
            Dim dr As DataRow
            arr = GridView1.GetSelectedRows()
            If arr Is Nothing Then
            Else
                Array.Sort(arr)
                For Each i In arr
                    s = i.ToString
                    dr = GridView1.GetDataRow(s)
                    tbPersonel_sil(dr("nPersonelID"))
                Next
            End If
            incele()
            XtraMessageBox.Show(Sorgu_sDil("Ýþlem Tamamlandý...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            s = Nothing
            arr = Nothing
            i = Nothing
            dr = Nothing
        End If
    End Sub
    Private Sub tbPersonel_sil(ByVal nPersonelID As String)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("set implicit_transactions on")
        cmd.ExecuteNonQuery()
        Try
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED ")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("delete from tbPersonelOzluk where nPersonelID= " & nPersonelID & "")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("delete from tbPersonelMeslek where nPersonelID = " & nPersonelID & "")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("delete from tbPersonelSinifi where nPersonelID = " & nPersonelID & "")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("delete tbPersonelIzini where nPersonelID = " & nPersonelID & "")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("delete tbPersonelYakini where nPersonelID = " & nPersonelID & "")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("delete tbPersonelEgitimIc where nPersonelID = " & nPersonelID & "")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("delete tbPersonel where nPersonelID = " & nPersonelID & "")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("IF @@TRANCOUNT > 0 COMMIT TRAN")
            cmd.ExecuteNonQuery()
            'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     TOP 1 ISNULL(sKodu,'') as sKodu FROM         tbFirma WHERE     (nFirmaID < '" & nFirmaID & "' ) ORDER BY sKodu DESC ")
            'sKodu = cmd.ExecuteScalar
            'txt_musteriNo.EditValue = sKodu
            'MsgBox(Sorgu_sDil("Kayýt Baþarýyla Silindi...",sDil), MessageBoxIcon.Information, sorgu_sDil("Dikkat",sDil))
            'musteri_kontrol()
        Catch ex As Exception
            XtraMessageBox.Show(Sorgu_sDil("Üzgünüm,Hareket Görmüþ Kaydý Silemezsiniz...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cmd.CommandText = sorgu_query("IF @@TRANCOUNT > 0 ROLLBACK TRAN")
            cmd.ExecuteNonQuery()
        End Try
        con.Close()
    End Sub
    Friend WithEvents MenuItem22 As System.Windows.Forms.MenuItem
    Private Sub MenuItem22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem22.Click
        If MenuItem22.Checked = False Then
            GridView1.OptionsView.ShowAutoFilterRow = True
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
            GridView1.OptionsCustomization.AllowFilter = True
            MenuItem22.Checked = True
        ElseIf MenuItem22.Checked = True Then
            GridView1.OptionsView.ShowAutoFilterRow = False
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
            GridView1.OptionsCustomization.AllowFilter = False
            MenuItem22.Checked = False
        End If
    End Sub
    Private Sub MenuItem18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem18.Click
        stok_fiyat()
    End Sub
    Private Sub BarButtonItem9_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem9.ItemClick
        analiz_envanter()
    End Sub
    Friend WithEvents ds_tbIsBasvurusuForm As System.Data.DataSet
    Friend WithEvents DataTable2 As System.Data.DataTable
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
    Friend WithEvents sec_bEhliyetiVarmi As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents sec_bAskerliginiYaptimi As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txt_sEhliyet As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_nCinsiyet As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents sec_sBasvuruPosizyonu1 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sec_Cinsiyet As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents sec_YuksekOkul As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents sec_Bolum As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents sec_Dil As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents sec_DilSeviye As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents MenuItem25 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem20 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem23 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem24 As System.Windows.Forms.MenuItem
    Friend WithEvents BarButtonItem10 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem11 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem12 As DevExpress.XtraBars.BarButtonItem
    Private Sub BarButtonItem10_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem10.ItemClick
        tbIsBasvuruFormu_Ekle()
    End Sub
    Private Sub BarButtonItem11_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem11.ItemClick
        incele_basvuru()
    End Sub
    Private Sub BarButtonItem12_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem12.ItemClick
        satir_sil()
    End Sub
    Private Sub MenuItem20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem20.Click
        tbIsBasvuruFormu_Ekle()
    End Sub
    Private Sub MenuItem23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem23.Click
        incele_basvuru()
    End Sub
    Private Sub MenuItem24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem24.Click
        satir_sil()
    End Sub
    Private Sub GridView1_SelectionChanged1(ByVal sender As Object, ByVal e As DevExpress.Data.SelectionChangedEventArgs) Handles GridView1.SelectionChanged
        If GridView1.SelectedRowsCount > 1 Then
            Label2.Text = Sorgu_sDil("Kayýt Sayýsý :", sDil) & GridView1.RowCount & " / " & Sorgu_sDil("Satýr :", sDil) & GridView1.FocusedRowHandle + 1 & " / " & Sorgu_sDil("Seçili :", sDil) & GridView1.SelectedRowsCount
        ElseIf GridView1.SelectedRowsCount = 1 Then
            Label2.Text = Sorgu_sDil("Kayýt Sayýsý :", sDil) & GridView1.RowCount & " / " & Sorgu_sDil("Satýr :", sDil) & GridView1.FocusedRowHandle + 1
        Else
            Label2.Text = ""
        End If
    End Sub
    Friend WithEvents ds_tbPersonel As System.Data.DataSet
    Friend WithEvents DataTable5 As System.Data.DataTable
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
    Friend WithEvents DataColumn223 As System.Data.DataColumn
    Friend WithEvents DataColumn224 As System.Data.DataColumn
    Friend WithEvents DataColumn225 As System.Data.DataColumn
    Friend WithEvents DataColumn226 As System.Data.DataColumn
    Friend WithEvents DataColumn227 As System.Data.DataColumn
    Friend WithEvents DataColumn228 As System.Data.DataColumn
    Friend WithEvents DataColumn229 As System.Data.DataColumn
    Friend WithEvents DataColumn230 As System.Data.DataColumn
    Friend WithEvents DataColumn231 As System.Data.DataColumn
    Friend WithEvents DataColumn232 As System.Data.DataColumn
    Friend WithEvents DataColumn233 As System.Data.DataColumn
    Friend WithEvents DataColumn234 As System.Data.DataColumn
    Friend WithEvents DataColumn235 As System.Data.DataColumn
    Friend WithEvents DataColumn236 As System.Data.DataColumn
    Friend WithEvents DataColumn237 As System.Data.DataColumn
    Friend WithEvents DataColumn238 As System.Data.DataColumn
    Friend WithEvents DataColumn239 As System.Data.DataColumn
    Friend WithEvents DataColumn240 As System.Data.DataColumn
    Friend WithEvents DataColumn241 As System.Data.DataColumn
    Friend WithEvents DataColumn242 As System.Data.DataColumn
    Friend WithEvents DataColumn243 As System.Data.DataColumn
    Friend WithEvents DataColumn244 As System.Data.DataColumn
    Friend WithEvents DataColumn245 As System.Data.DataColumn
    Friend WithEvents DataColumn246 As System.Data.DataColumn
    Friend WithEvents DataColumn247 As System.Data.DataColumn
    Friend WithEvents DataColumn248 As System.Data.DataColumn
    Friend WithEvents colnPersonelID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collSicilNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsDepartmanKodu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsAdi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsIkinciAdi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsSoyadi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnCinsiyet As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsAkedemikUnvani As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsUnvan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbSSKKesilecekmi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbIssizlikKesilecekmi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsSSKSicilNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsSSKStatusu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsVergiStatusu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collTTFToplamOdenen As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsTTFNumarasi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbBrutUcretlimi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsSaatGunlukAylik As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsUcretDovizCinsi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collBirimUcret As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsBankaHesapNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsBankaHesapNoKS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteIseGirisTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteIstenCikisTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsCikisSebebi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbCalisiyormu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnCocukAd As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnCocukAdOkulOncesi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnCocukAdIlkOgrenim As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnCocukAdLise As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnCocukAdYuksek As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collOzelSagSigAylikPrimi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbSendikaUyesimi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteOzelSSBaslangic As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsKullaniciAdi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteKayitTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collOzelEmekSigAylikPrimi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ds_tbPersonelOzluk As System.Data.DataSet
    Friend WithEvents DataTable3 As System.Data.DataTable
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
    Friend WithEvents DataColumn169 As System.Data.DataColumn
    Friend WithEvents DataColumn170 As System.Data.DataColumn
    Friend WithEvents DataColumn171 As System.Data.DataColumn
    Friend WithEvents DataColumn172 As System.Data.DataColumn
    Friend WithEvents DataColumn173 As System.Data.DataColumn
    Friend WithEvents DataColumn174 As System.Data.DataColumn
    Friend WithEvents DataColumn175 As System.Data.DataColumn
    Friend WithEvents DataColumn176 As System.Data.DataColumn
    Friend WithEvents DataColumn177 As System.Data.DataColumn
    Friend WithEvents DataColumn178 As System.Data.DataColumn
    Friend WithEvents ds_tbPersonelMeslek As System.Data.DataSet
    Friend WithEvents DataTable4 As System.Data.DataTable
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
End Class
