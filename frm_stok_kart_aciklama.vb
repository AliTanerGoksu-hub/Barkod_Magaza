Imports DevExpress.XtraEditors
Public Class frm_stok_kart_aciklama
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
    Friend WithEvents LabelControl92 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_musteriNo As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents VGridControl1 As DevExpress.XtraVerticalGrid.VGridControl
    Friend WithEvents ds_tbStokAciklama As System.Data.DataSet
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
    Friend WithEvents rownStokID As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowsAciklama1 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowsAciklama2 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowsAciklama3 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowsAciklama4 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowsAciklama5 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowsAciklama6 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowsAciklama7 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowsAciklama8 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowsAciklama9 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowsAciklama10 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents sec_sAciklama As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents lbl_Aciklama As DevExpress.XtraEditors.LabelControl
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_stok_kart_aciklama))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.Label1 = New DevExpress.XtraEditors.LabelControl
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.lbl_Aciklama = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl92 = New DevExpress.XtraEditors.LabelControl
        Me.txt_musteriNo = New DevExpress.XtraEditors.ButtonEdit
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl
        Me.VGridControl1 = New DevExpress.XtraVerticalGrid.VGridControl
        Me.ds_tbStokAciklama = New System.Data.DataSet
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
        Me.sec_sAciklama = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.rownStokID = New DevExpress.XtraVerticalGrid.Rows.EditorRow
        Me.rowsAciklama1 = New DevExpress.XtraVerticalGrid.Rows.EditorRow
        Me.rowsAciklama2 = New DevExpress.XtraVerticalGrid.Rows.EditorRow
        Me.rowsAciklama3 = New DevExpress.XtraVerticalGrid.Rows.EditorRow
        Me.rowsAciklama4 = New DevExpress.XtraVerticalGrid.Rows.EditorRow
        Me.rowsAciklama5 = New DevExpress.XtraVerticalGrid.Rows.EditorRow
        Me.rowsAciklama6 = New DevExpress.XtraVerticalGrid.Rows.EditorRow
        Me.rowsAciklama7 = New DevExpress.XtraVerticalGrid.Rows.EditorRow
        Me.rowsAciklama8 = New DevExpress.XtraVerticalGrid.Rows.EditorRow
        Me.rowsAciklama9 = New DevExpress.XtraVerticalGrid.Rows.EditorRow
        Me.rowsAciklama10 = New DevExpress.XtraVerticalGrid.Rows.EditorRow
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.txt_musteriNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.VGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_tbStokAciklama, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sAciklama, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PanelControl1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(96, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(726, 52)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Stok Kartý Açýklamalarý Aþaðýdadýr..."
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(94, 52)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.lbl_Aciklama)
        Me.PanelControl2.Controls.Add(Me.LabelControl92)
        Me.PanelControl2.Controls.Add(Me.txt_musteriNo)
        Me.PanelControl2.Controls.Add(Me.SimpleButton2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 381)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(824, 48)
        Me.PanelControl2.TabIndex = 1
        '
        'lbl_Aciklama
        '
        Me.lbl_Aciklama.Appearance.ForeColor = System.Drawing.Color.Red
        Me.lbl_Aciklama.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.lbl_Aciklama.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lbl_Aciklama.Location = New System.Drawing.Point(266, 17)
        Me.lbl_Aciklama.Name = "lbl_Aciklama"
        Me.lbl_Aciklama.Size = New System.Drawing.Size(6, 13)
        Me.lbl_Aciklama.TabIndex = 72
        Me.lbl_Aciklama.Text = "*"
        '
        'LabelControl92
        '
        Me.LabelControl92.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl92.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl92.Location = New System.Drawing.Point(11, 16)
        Me.LabelControl92.Name = "LabelControl92"
        Me.LabelControl92.Size = New System.Drawing.Size(38, 13)
        Me.LabelControl92.TabIndex = 71
        Me.LabelControl92.Text = "StokNo:"
        '
        'txt_musteriNo
        '
        Me.txt_musteriNo.Location = New System.Drawing.Point(93, 13)
        Me.txt_musteriNo.Name = "txt_musteriNo"
        Me.txt_musteriNo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txt_musteriNo.Properties.MaxLength = 13
        Me.txt_musteriNo.Size = New System.Drawing.Size(167, 20)
        Me.txt_musteriNo.TabIndex = 69
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(733, 13)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(75, 24)
        Me.SimpleButton2.TabIndex = 68
        Me.SimpleButton2.Text = "&Vazgeç"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(658, 13)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 24)
        Me.SimpleButton1.TabIndex = 67
        Me.SimpleButton1.Text = "&Tamam"
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.VGridControl1)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl3.Location = New System.Drawing.Point(0, 56)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(824, 325)
        Me.PanelControl3.TabIndex = 0
        '
        'VGridControl1
        '
        Me.VGridControl1.Appearance.Empty.BackColor = System.Drawing.Color.Transparent
        Me.VGridControl1.Appearance.Empty.Options.UseBackColor = True
        Me.VGridControl1.CustomizationFormBounds = New System.Drawing.Rectangle(627, 273, 208, 252)
        Me.VGridControl1.DataMember = "Table1"
        Me.VGridControl1.DataSource = Me.ds_tbStokAciklama
        Me.VGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VGridControl1.LayoutStyle = DevExpress.XtraVerticalGrid.LayoutViewStyle.SingleRecordView
        Me.VGridControl1.Location = New System.Drawing.Point(2, 2)
        Me.VGridControl1.Name = "VGridControl1"
        Me.VGridControl1.RecordWidth = 169
        Me.VGridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.sec_sAciklama})
        Me.VGridControl1.RowHeaderWidth = 31
        Me.VGridControl1.Rows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.rownStokID, Me.rowsAciklama1, Me.rowsAciklama2, Me.rowsAciklama3, Me.rowsAciklama4, Me.rowsAciklama5, Me.rowsAciklama6, Me.rowsAciklama7, Me.rowsAciklama8, Me.rowsAciklama9, Me.rowsAciklama10})
        Me.VGridControl1.Size = New System.Drawing.Size(820, 321)
        Me.VGridControl1.TabIndex = 0
        '
        'ds_tbStokAciklama
        '
        Me.ds_tbStokAciklama.DataSetName = "NewDataSet"
        Me.ds_tbStokAciklama.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_tbStokAciklama.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11})
        Me.DataTable1.TableName = "Table1"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "nStokID"
        Me.DataColumn1.DataType = GetType(Long)
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "sAciklama1"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "sAciklama2"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "sAciklama3"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "sAciklama4"
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "sAciklama5"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "sAciklama6"
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "sAciklama7"
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "sAciklama8"
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "sAciklama9"
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "sAciklama10"
        '
        'sec_sAciklama
        '
        Me.sec_sAciklama.AutoHeight = False
        Me.sec_sAciklama.MaxLength = 60
        Me.sec_sAciklama.Name = "sec_sAciklama"
        '
        'rownStokID
        '
        Me.rownStokID.Height = 40
        Me.rownStokID.Name = "rownStokID"
        Me.rownStokID.Properties.Caption = "nStokID"
        Me.rownStokID.Properties.FieldName = "nStokID"
        Me.rownStokID.Visible = False
        '
        'rowsAciklama1
        '
        Me.rowsAciklama1.Height = 38
        Me.rowsAciklama1.Name = "rowsAciklama1"
        Me.rowsAciklama1.Properties.Caption = "Açýklama  1"
        Me.rowsAciklama1.Properties.FieldName = "sAciklama1"
        Me.rowsAciklama1.Properties.RowEdit = Me.sec_sAciklama
        '
        'rowsAciklama2
        '
        Me.rowsAciklama2.Height = 34
        Me.rowsAciklama2.Name = "rowsAciklama2"
        Me.rowsAciklama2.Properties.Caption = "Açýklama  2"
        Me.rowsAciklama2.Properties.FieldName = "sAciklama2"
        Me.rowsAciklama2.Properties.RowEdit = Me.sec_sAciklama
        '
        'rowsAciklama3
        '
        Me.rowsAciklama3.Height = 34
        Me.rowsAciklama3.Name = "rowsAciklama3"
        Me.rowsAciklama3.Properties.Caption = "Açýklama  3"
        Me.rowsAciklama3.Properties.FieldName = "sAciklama3"
        Me.rowsAciklama3.Properties.RowEdit = Me.sec_sAciklama
        '
        'rowsAciklama4
        '
        Me.rowsAciklama4.Height = 35
        Me.rowsAciklama4.Name = "rowsAciklama4"
        Me.rowsAciklama4.Properties.Caption = "Açýklama  4"
        Me.rowsAciklama4.Properties.FieldName = "sAciklama4"
        Me.rowsAciklama4.Properties.RowEdit = Me.sec_sAciklama
        '
        'rowsAciklama5
        '
        Me.rowsAciklama5.Height = 32
        Me.rowsAciklama5.Name = "rowsAciklama5"
        Me.rowsAciklama5.Properties.Caption = "Açýklama  5"
        Me.rowsAciklama5.Properties.FieldName = "sAciklama5"
        Me.rowsAciklama5.Properties.RowEdit = Me.sec_sAciklama
        '
        'rowsAciklama6
        '
        Me.rowsAciklama6.Height = 26
        Me.rowsAciklama6.Name = "rowsAciklama6"
        Me.rowsAciklama6.Properties.Caption = "Aciklama  6"
        Me.rowsAciklama6.Properties.FieldName = "sAciklama6"
        Me.rowsAciklama6.Properties.RowEdit = Me.sec_sAciklama
        '
        'rowsAciklama7
        '
        Me.rowsAciklama7.Height = 25
        Me.rowsAciklama7.Name = "rowsAciklama7"
        Me.rowsAciklama7.Properties.Caption = "Aciklama  7"
        Me.rowsAciklama7.Properties.FieldName = "sAciklama7"
        Me.rowsAciklama7.Properties.RowEdit = Me.sec_sAciklama
        '
        'rowsAciklama8
        '
        Me.rowsAciklama8.Height = 25
        Me.rowsAciklama8.Name = "rowsAciklama8"
        Me.rowsAciklama8.Properties.Caption = "Aciklama  8"
        Me.rowsAciklama8.Properties.FieldName = "sAciklama8"
        Me.rowsAciklama8.Properties.RowEdit = Me.sec_sAciklama
        '
        'rowsAciklama9
        '
        Me.rowsAciklama9.Height = 25
        Me.rowsAciklama9.Name = "rowsAciklama9"
        Me.rowsAciklama9.Properties.Caption = "Aciklama  9"
        Me.rowsAciklama9.Properties.FieldName = "sAciklama9"
        Me.rowsAciklama9.Properties.RowEdit = Me.sec_sAciklama
        '
        'rowsAciklama10
        '
        Me.rowsAciklama10.Height = 30
        Me.rowsAciklama10.Name = "rowsAciklama10"
        Me.rowsAciklama10.Properties.Caption = "Aciklama 10"
        Me.rowsAciklama10.Properties.FieldName = "sAciklama10"
        Me.rowsAciklama10.Properties.RowEdit = Me.sec_sAciklama
        '
        'frm_stok_kart_aciklama
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(824, 429)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_stok_kart_aciklama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stok Açýklamalarý..."
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.txt_musteriNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.VGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_tbStokAciklama, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sAciklama, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub
#End Region
    Public firmano
    Public donemno
    Public connection
    Public nStokID
    Public sKodu
    Public sModel
    Public kullanici
    Dim conn As New OleDb.OleDbConnection
    Dim con As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand
    Dim adapter As New OleDb.OleDbDataAdapter
    Dim DS As New DataSet
    Dim ds_stok As DataSet
    Private Sub frm_stok_kart_aciklama_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If sModel = "" Then
            stok_sec()
        Else
            txt_musteriNo.EditValue = sModel
            dataload(sModel)
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
    Private Sub stok_sec()
        Dim frm As New frm_stok_liste
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.islemstatus = True
        frm.kullanici = kullanici
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim dr1 As DataRow
            dr1 = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
            nStokID = dr1("nStokID")
            sKodu = dr1("sKodu")
            sModel = dr1("sModel")
            txt_musteriNo.EditValue = sModel
            stok_kontrol()
            dr1 = Nothing
        End If
    End Sub
    Private Sub stok_kontrol()
        If Trim(txt_musteriNo.EditValue).ToString <> "" Then
            Dim kontrol = sorgu_stok_kontrol(txt_musteriNo.EditValue)
            If kontrol = 0 Then
                XtraMessageBox.Show(Sorgu_sDil("Kayýt Bulunumadý...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ElseIf kontrol = 1 Then
                dataload_stok(txt_musteriNo.EditValue)
                Dim dr As DataRow
                For Each dr In ds_stok.Tables(0).Rows
                    'txt_Musteri.EditValue = dr("MUSTERI")
                    sKodu = dr("sKodu")
                    nStokID = dr("nStokID")
                    sModel = dr("sModel")
                    dataload(sModel)
                Next
                dr = Nothing
            End If
        End If
    End Sub
    Public Function sorgu_stok_kontrol(ByVal kod As String) As Int64
        Dim kriter
        kriter = "WHERE (sKodu like '" & kod & "%') "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(*), 0) AS KAYIT  FROM         tbStok " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Private Sub dataload_stok(ByVal kod As String)
        Dim kriter
        kriter = "WHERE (sKodu like  '" & kod & "%') "
        ds_stok = sorgu(sorgu_query("SELECT     top 1 nStokID,sKodu,sAciklama,sModel FROM         tbStok " & kriter & ""))
    End Sub
    Private Sub dataload(ByVal sModel As String)
        If sorgu_tbStokAciklama_kontrol(sModel) = 0 Then
            tbStokAciklama_kaydet_yeni(sModel, "", "", "", "", "", "", "", "", "", "")
        End If
        Dataload_tbStokAciklama(sModel)
    End Sub
    Public Sub Dataload_tbStokAciklama(ByVal sModel As String)
        Try
            ds_tbStokAciklama.Tables(0).Clear()
        Catch ex As Exception
        End Try
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED select distinct sAciklama1, sAciklama2, sAciklama3, sAciklama4, sAciklama5, sAciklama6, sAciklama7, sAciklama8, sAciklama9, sAciklama10 from tbStokAciklama Where nStokID in  ( Select nStokID from tbStok where sModel = '" & sModel & "')")
        cmd.Connection = conn
        conn.Open()
        Dim N As Integer = adapter.Fill(ds_tbStokAciklama, "Table1")
        conn.Close()
    End Sub
    Private Sub tbStokAciklama_kaydet_yeni(ByVal sModel As String, ByVal sAciklama1 As String, ByVal sAciklama2 As String, ByVal sAciklama3 As String, ByVal sAciklama4 As String, ByVal sAciklama5 As String, ByVal sAciklama6 As String, ByVal sAciklama7 As String, ByVal sAciklama8 As String, ByVal sAciklama9 As String, ByVal sAciklama10 As String)
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Insert  Into tbStokAciklama Select nStokID ,'" & sAciklama1 & "' , '" & sAciklama2 & "' , '" & sAciklama3 & "' , '" & sAciklama4 & "' , '" & sAciklama5 & "' , '" & sAciklama6 & "' , '" & sAciklama7 & "' , '" & sAciklama8 & "' , '" & sAciklama9 & "' , '" & sAciklama10 & "' from tbStok where sModel = '" & sModel & "'")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbStokAciklama_kaydet_duzelt(ByVal sModel As String, ByVal sAciklama1 As String, ByVal sAciklama2 As String, ByVal sAciklama3 As String, ByVal sAciklama4 As String, ByVal sAciklama5 As String, ByVal sAciklama6 As String, ByVal sAciklama7 As String, ByVal sAciklama8 As String, ByVal sAciklama9 As String, ByVal sAciklama10 As String)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Update tbStokAciklama set sAciklama1 = '" & sAciklama1 & "' , sAciklama2 = '" & sAciklama2 & "' , sAciklama3 = '" & sAciklama3 & "' , sAciklama4 = '" & sAciklama4 & "' , sAciklama5 = '" & sAciklama5 & "' , sAciklama6 = '" & sAciklama6 & "' , sAciklama7 = '" & sAciklama7 & "' , sAciklama8 = '" & sAciklama8 & "' , sAciklama9 = '" & sAciklama9 & "' , sAciklama10 = '" & sAciklama10 & "' from tbStok Where tbStokAciklama.nStokID = tbStok.nStokID  and sModel = '" & sModel & "' ")
        cmd.ExecuteNonQuery()
        con.Close()
        con = Nothing
        cmd = Nothing
    End Sub
    Private Function sorgu_tbStokAciklama_kontrol(ByVal sModel As String) As Int64
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        Dim kayitsayisi As Int64
        con.ConnectionString = connection
        cmd.Connection = con
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     TOP 1 COUNT(*) AS nKayit FROM         tbStokAciklama WHERE     (nStokID IN (SELECT     nStokID FROM          tbStok WHERE      sModel = '" & sModel & "'))"
        kayitsayisi = cmd.ExecuteScalar()
        con.Close()
        Return kayitsayisi
    End Function
    Private Sub kaydet_tumu()
        Dim dr As DataRow
        dr = ds_tbStokAciklama.Tables(0).Rows(0)
        tbStokAciklama_kaydet_duzelt(sModel, dr("sAciklama1"), dr("sAciklama2"), dr("sAciklama3"), dr("sAciklama4"), dr("sAciklama5"), dr("sAciklama6"), dr("sAciklama7"), dr("sAciklama8"), dr("sAciklama9"), dr("sAciklama10"))
        Me.Close()
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        kaydet_tumu()
    End Sub
    Private Sub VGridControl1_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraVerticalGrid.Events.CellValueChangedEventArgs) Handles VGridControl1.CellValueChanged
        Try
            'Vgrid_baslik.PostEditor()
            VGridControl1.UpdateFocusedRecord()
            VGridControl1.CloseEditor()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub VGridControl1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles VGridControl1.KeyDown
        If e.KeyCode = Keys.Escape Then
            If XtraMessageBox.Show(Sorgu_sDil("Stok Açýklamasý Ekranýný Kapatmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                Me.Close()
            End If
        End If
    End Sub
End Class
