Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Public Class frm_ozelkod
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
    Friend WithEvents Panel3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Panel1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Panel2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents DataTable1 As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents ps As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents printlink As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents colIND As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colACIKLAMA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKOD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem9 As System.Windows.Forms.MenuItem
    Friend WithEvents Label1 As DevExpress.XtraEditors.LabelControl
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ozelkod))
        Me.Panel3 = New DevExpress.XtraEditors.PanelControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.DataTable1 = New System.Data.DataTable()
        Me.DataColumn1 = New System.Data.DataColumn()
        Me.DataColumn2 = New System.Data.DataColumn()
        Me.DataColumn3 = New System.Data.DataColumn()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colIND = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colACIKLAMA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKOD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Panel1 = New DevExpress.XtraEditors.PanelControl()
        Me.Label1 = New DevExpress.XtraEditors.LabelControl()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New DevExpress.XtraEditors.PanelControl()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.DataSet1 = New System.Data.DataSet()
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MenuItem6 = New System.Windows.Forms.MenuItem()
        Me.MenuItem5 = New System.Windows.Forms.MenuItem()
        Me.MenuItem9 = New System.Windows.Forms.MenuItem()
        Me.MenuItem7 = New System.Windows.Forms.MenuItem()
        Me.MenuItem8 = New System.Windows.Forms.MenuItem()
        Me.ps = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.printlink = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        CType(Me.Panel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.Appearance.BackColor = System.Drawing.Color.White
        Me.Panel3.Appearance.Options.UseBackColor = True
        Me.Panel3.Controls.Add(Me.GridControl1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 52)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(410, 292)
        Me.Panel3.TabIndex = 0
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.DataTable1
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GridControl1.Location = New System.Drawing.Point(2, 2)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(406, 288)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3})
        Me.DataTable1.TableName = "OZELKOD"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "IND"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "ACIKLAMA"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "KOD"
        Me.DataColumn3.DataType = GetType(Short)
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIND, Me.colACIKLAMA, Me.colKOD})
        Me.GridView1.CustomizationFormBounds = New System.Drawing.Rectangle(249, 288, 208, 170)
        Me.GridView1.DetailHeight = 160
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupFormat = "{0}: {1} {2}"
        Me.GridView1.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView1.IndicatorWidth = 12
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowIncrementalSearch = True
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsDetail.ShowDetailTabs = False
        Me.GridView1.OptionsMenu.EnableColumnMenu = False
        Me.GridView1.OptionsMenu.EnableFooterMenu = False
        Me.GridView1.OptionsMenu.EnableGroupPanelMenu = False
        Me.GridView1.OptionsNavigation.UseTabKey = False
        Me.GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowIndicator = False
        '
        'colIND
        '
        Me.colIND.Caption = "Kayýt No"
        Me.colIND.FieldName = "IND"
        Me.colIND.Name = "colIND"
        Me.colIND.Visible = True
        Me.colIND.VisibleIndex = 0
        Me.colIND.Width = 198
        '
        'colACIKLAMA
        '
        Me.colACIKLAMA.Caption = "Açýklama"
        Me.colACIKLAMA.FieldName = "ACIKLAMA"
        Me.colACIKLAMA.Name = "colACIKLAMA"
        Me.colACIKLAMA.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "ACIKLAMA", "Kayýt: {0}")})
        Me.colACIKLAMA.Visible = True
        Me.colACIKLAMA.VisibleIndex = 1
        Me.colACIKLAMA.Width = 651
        '
        'colKOD
        '
        Me.colKOD.Caption = "KOD"
        Me.colKOD.FieldName = "KOD"
        Me.colKOD.Name = "colKOD"
        '
        'Panel1
        '
        Me.Panel1.Appearance.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel1.Appearance.Options.UseBackColor = True
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(410, 52)
        Me.Panel1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(2, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(358, 26)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Özel Kod Tanýmlarý Aþaðýdadýr.Özel Kod eklemek için [insert] tuþuna, düzeltmet iç" & _
    "in [F4] tuþuna, silmek için ise [Ctrl+Delete] tuþlarýna basýnýz... "
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(360, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.SimpleButton2)
        Me.Panel2.Controls.Add(Me.SimpleButton1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 344)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(410, 43)
        Me.Panel2.TabIndex = 1
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(325, 9)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(80, 25)
        Me.SimpleButton2.TabIndex = 1
        Me.SimpleButton2.Text = "&Vazgeç"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(245, 9)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(80, 25)
        Me.SimpleButton1.TabIndex = 0
        Me.SimpleButton1.Text = "&Tamam"
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem2, Me.MenuItem4, Me.MenuItem3, Me.MenuItem6, Me.MenuItem5, Me.MenuItem9, Me.MenuItem7, Me.MenuItem8})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.Text = "Ara"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 1
        Me.MenuItem2.Shortcut = System.Windows.Forms.Shortcut.Ins
        Me.MenuItem2.Text = "Yeni"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 2
        Me.MenuItem4.Shortcut = System.Windows.Forms.Shortcut.F4
        Me.MenuItem4.Text = "Düzelt"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 3
        Me.MenuItem3.Shortcut = System.Windows.Forms.Shortcut.CtrlDel
        Me.MenuItem3.Text = "Sil"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 4
        Me.MenuItem6.Text = "-"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 5
        Me.MenuItem5.Shortcut = System.Windows.Forms.Shortcut.CtrlP
        Me.MenuItem5.Text = "Yazdýr"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 6
        Me.MenuItem9.Text = "-"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 7
        Me.MenuItem7.Shortcut = System.Windows.Forms.Shortcut.F2
        Me.MenuItem7.Text = "Tamam"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 8
        Me.MenuItem8.Shortcut = System.Windows.Forms.Shortcut.F3
        Me.MenuItem8.Text = "Vazgeç"
        '
        'ps
        '
        Me.ps.Links.AddRange(New Object() {Me.printlink})
        '
        'printlink
        '
        Me.printlink.Component = Me.GridControl1
        '
        '
        '
        Me.printlink.ImageCollection.ImageStream = CType(resources.GetObject("printlink.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.printlink.Margins = New System.Drawing.Printing.Margins(20, 20, 60, 60)
        Me.printlink.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[Date Printed][Time Printed]", "ÖzelKodListesi", ""}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Barkod Yazýlým", "", ""}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Me.printlink.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.printlink.PrintingSystem = Me.ps
        Me.printlink.PrintingSystemBase = Me.ps
        '
        'frm_ozelkod
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(410, 387)
        Me.ContextMenu = Me.ContextMenu1
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_ozelkod"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Özel Kodlar"
        CType(Me.Panel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub
#End Region
    Public modul
    Public category
    Dim cmd As New OleDb.OleDbCommand
    Dim con As New OleDb.OleDbConnection
    Dim dr As DataRow
    Public Shared ozelkod
    Public connection
    Public firmano
    Public donemno
    Public userno
    Public kullanici
    Private Sub frmozelkod_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.ConnectionString = connection
        cmd.Connection = con
        dataload()
        ozelkod = ""
    End Sub
    Private Sub ozelkod_yeni()
        'Dim aciklama = InputBox("Lütfen Bir Açýklama Giriniz...", "OzelKod Tanýmla")
        'If aciklama.ToString <> "" Then
        '    con.ConnectionString = connection
        '    con.Open()
        '    cmd.Connection = con
        '    cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO *!FTBL" & modul & "KODTAN (KOD, CATEGORY) VALUES     ('" & aciklama & "', " & category & ")")
        '    cmd.ExecuteNonQuery()
        '    con.Close()
        'End If
    End Sub
    Private Sub ozelkod_duzelt()
        'dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        'Dim aciklama = InputBox("Lütfen Bir Açýklama Giriniz...", "OzelKod Tanýmla", "" & dr("ACIKLAMA") & "")
        'If aciklama.ToString <> "" Then
        '    con.ConnectionString = connection
        '    con.Open()
        '    cmd.Connection = con
        '    cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    *!FTBL" & modul & "KODTAN SET              KOD ='" & aciklama & "'  WHERE IND = " & dr("IND") & "")
        '    cmd.ExecuteNonQuery()
        '    con.Close()
        '    dataload()
        '    dr.BeginEdit()
        '    dr("ACIKLAMA") = aciklama
        '    dr.EndEdit()
        'End If
    End Sub
    Private Sub ozelkod_sil()
        'dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        'If XtraMessageBox.Show(Sorgu_sDil("Seçili Kaydý Silmek Ýstediðinize Emin misiniz...?",sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question,sorgu_sDil("Dikkat",sDil)) = MsgBoxResult.Yes Then
        '    con.ConnectionString = connection
        '    con.Open()
        '    cmd.Connection = con
        '    cmd.CommandText = sorgu_query("DELETE FROM *!FTBL" & modul & "KODTAN WHERE IND = " & dr("IND") & "")
        '    cmd.ExecuteNonQuery()
        '    con.Close()
        '    dr.BeginEdit()
        '    dr.Delete()
        'End If
    End Sub
    Private Sub dataload()
        DataSet1.Tables(0).Clear()
        Dim adapter As New OleDb.OleDbDataAdapter
        con.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sSinifKodu AS IND, sAciklama AS ACIKLAMA  FROM         tbMSinif" & category & "")
        cmd.Connection = con
        con.Open()
        Dim N As Integer = adapter.Fill(DataSet1, "OZELKOD")
        con.Close()
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        kontrol()
    End Sub
    Private Sub kontrol()
        If GridView1.RowCount > 0 Then
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            ozelkod = dr("IND")
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            ozelkod = ""
            Me.Close()
        End If
    End Sub
    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        ozelkod_yeni()
        dataload()
    End Sub
    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        ozelkod_duzelt()
    End Sub
    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        ozelkod_sil()
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub GridView1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridView1.KeyDown
        If e.KeyCode = Keys.Enter Then
            kontrol()
        ElseIf e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub
    Private Sub GridControl1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridControl1.DoubleClick
        kontrol()
        DialogResult = Windows.Forms.DialogResult.OK
    End Sub
    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        printlink.CreateDocument(ps)
        ps.PreviewFormEx.ShowDialog()
    End Sub
    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        kontrol()
    End Sub
    Private Sub MenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem8.Click
        Me.Close()
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
    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
    End Sub
End Class
