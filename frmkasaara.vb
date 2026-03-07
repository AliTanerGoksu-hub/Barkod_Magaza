Imports Microsoft.Win32
Imports System.IO
Imports DevExpress.XtraEditors
Public Class frmkasaara
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
    Friend WithEvents Panel1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Panel2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Panel3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents VGridControl1 As DevExpress.XtraVerticalGrid.VGridControl
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DataTable1 As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents rowILKKASA As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowSONKASA As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowTARIH As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents RepositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblpos As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents rowSURUCU As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmkasaara))
        Me.Panel1 = New DevExpress.XtraEditors.PanelControl
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New DevExpress.XtraEditors.LabelControl
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Panel2 = New DevExpress.XtraEditors.PanelControl
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.Panel3 = New DevExpress.XtraEditors.PanelControl
        Me.VGridControl1 = New DevExpress.XtraVerticalGrid.VGridControl
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.DataTable1 = New System.Data.DataTable
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.DataColumn3 = New System.Data.DataColumn
        Me.DataColumn4 = New System.Data.DataColumn
        Me.RepositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.rowILKKASA = New DevExpress.XtraVerticalGrid.Rows.EditorRow
        Me.rowSONKASA = New DevExpress.XtraVerticalGrid.Rows.EditorRow
        Me.rowTARIH = New DevExpress.XtraVerticalGrid.Rows.EditorRow
        Me.rowSURUCU = New DevExpress.XtraVerticalGrid.Rows.EditorRow
        Me.DataSet1 = New System.Data.DataSet
        Me.lblpos = New DevExpress.XtraEditors.LabelControl
        CType(Me.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.Panel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.VGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Appearance.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel1.Appearance.Options.UseBackColor = True
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(248, 52)
        Me.Panel1.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Location = New System.Drawing.Point(200, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 52)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Kasa Seçiniz..."
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Location = New System.Drawing.Point(8, 17)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(128, 9)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.SimpleButton2)
        Me.Panel2.Controls.Add(Me.SimpleButton1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 145)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(248, 44)
        Me.Panel2.TabIndex = 1
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Image = Global.business_smart.My.Resources.Resources.button_cancel
        Me.SimpleButton2.Location = New System.Drawing.Point(164, 9)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(84, 24)
        Me.SimpleButton2.TabIndex = 1
        Me.SimpleButton2.Text = "&Vazgeç"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Image = Global.business_smart.My.Resources.Resources.button_ok
        Me.SimpleButton1.Location = New System.Drawing.Point(80, 9)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(84, 24)
        Me.SimpleButton1.TabIndex = 0
        Me.SimpleButton1.Text = "&Tamam"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.VGridControl1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 52)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(248, 93)
        Me.Panel3.TabIndex = 0
        '
        'VGridControl1
        '
        Me.VGridControl1.Appearance.Empty.BackColor = System.Drawing.Color.Transparent
        Me.VGridControl1.Appearance.Empty.Options.UseBackColor = True
        Me.VGridControl1.ContextMenu = Me.ContextMenu1
        Me.VGridControl1.DataSource = Me.DataTable1
        Me.VGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VGridControl1.LayoutStyle = DevExpress.XtraVerticalGrid.LayoutViewStyle.SingleRecordView
        Me.VGridControl1.Location = New System.Drawing.Point(2, 2)
        Me.VGridControl1.Name = "VGridControl1"
        Me.VGridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemSpinEdit1, Me.RepositoryItemDateEdit1})
        Me.VGridControl1.Rows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.rowILKKASA, Me.rowSONKASA, Me.rowTARIH, Me.rowSURUCU})
        Me.VGridControl1.Size = New System.Drawing.Size(244, 89)
        Me.VGridControl1.TabIndex = 0
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem2})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.Shortcut = System.Windows.Forms.Shortcut.F2
        Me.MenuItem1.Text = "Tamam"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 1
        Me.MenuItem2.Shortcut = System.Windows.Forms.Shortcut.F3
        Me.MenuItem2.Text = "Vazgeç"
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4})
        Me.DataTable1.TableName = "Table1"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "ILKKASA"
        Me.DataColumn1.DataType = GetType(Integer)
        Me.DataColumn1.DefaultValue = 1
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "SONKASA"
        Me.DataColumn2.DataType = GetType(Integer)
        Me.DataColumn2.DefaultValue = 1
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "TARIH"
        Me.DataColumn3.DataType = GetType(Date)
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "SURUCU"
        '
        'RepositoryItemSpinEdit1
        '
        Me.RepositoryItemSpinEdit1.AutoHeight = False
        Me.RepositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.RepositoryItemSpinEdit1.MaxValue = New Decimal(New Integer() {99, 0, 0, 0})
        Me.RepositoryItemSpinEdit1.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.RepositoryItemSpinEdit1.Name = "RepositoryItemSpinEdit1"
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.Mask.EditMask = "##.##.####"
        Me.RepositoryItemDateEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        Me.RepositoryItemDateEdit1.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        '
        'rowILKKASA
        '
        Me.rowILKKASA.Name = "rowILKKASA"
        Me.rowILKKASA.Properties.Caption = "ÝlkKasa"
        Me.rowILKKASA.Properties.FieldName = "ILKKASA"
        Me.rowILKKASA.Properties.RowEdit = Me.RepositoryItemSpinEdit1
        '
        'rowSONKASA
        '
        Me.rowSONKASA.Name = "rowSONKASA"
        Me.rowSONKASA.Properties.Caption = "SonKasa"
        Me.rowSONKASA.Properties.FieldName = "SONKASA"
        Me.rowSONKASA.Properties.RowEdit = Me.RepositoryItemSpinEdit1
        '
        'rowTARIH
        '
        Me.rowTARIH.Name = "rowTARIH"
        Me.rowTARIH.Properties.Caption = "Tarih"
        Me.rowTARIH.Properties.FieldName = "TARIH"
        Me.rowTARIH.Properties.Format.FormatString = "d"
        Me.rowTARIH.Properties.Format.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.rowTARIH.Properties.RowEdit = Me.RepositoryItemDateEdit1
        '
        'rowSURUCU
        '
        Me.rowSURUCU.Name = "rowSURUCU"
        Me.rowSURUCU.Properties.Caption = "Disk"
        Me.rowSURUCU.Properties.FieldName = "SURUCU"
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'lblpos
        '
        Me.lblpos.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblpos.Location = New System.Drawing.Point(8, 1)
        Me.lblpos.Name = "lblpos"
        Me.lblpos.Size = New System.Drawing.Size(37, 16)
        Me.lblpos.TabIndex = 3
        Me.lblpos.Text = "%pos"
        '
        'frmkasaara
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(248, 189)
        Me.Controls.Add(Me.lblpos)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmkasaara"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "KasaSeç"
        CType(Me.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.Panel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.VGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub
#End Region
    Public kriter
    Public islem
    Public kasa As String = ""
    Public nIlkKasa As Integer = 1
    Public nSonKasa As Integer = 1
    Public sPath As String
    Public dteIslemTarihi As DateTime
    Public tarih As String
    Public tarih2 As String
    Dim i As Integer
    Dim s As String
    Dim gun
    Dim ay
    Dim yil
    Dim dll As New AppYazarKasa
    Private Sub frmkasaara_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dr As DataRow = DataSet1.Tables(0).NewRow
        dr(0) = nIlkKasa
        dr(1) = nSonKasa
        dr(2) = dteIslemTarihi
        dr(3) = sPath
        DataSet1.Tables(0).Rows.Add(dr)
    End Sub
    Private Sub frmkasaara_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        sorgu()
        VGridControl1.Focus()
        VGridControl1.Select()
    End Sub
    Private Sub kontrol()
        Dim dr As DataRow
        For Each dr In DataSet1.Tables(0).Rows
            nIlkKasa = dr(0).ToString
            nSonKasa = dr(1).ToString
            tarih = dr(2)
            sPath = dr(3).ToString
        Next
        If nIlkKasa > nSonKasa Then
            nIlkKasa = nSonKasa
        ElseIf nSonKasa < nIlkKasa Then
            nSonKasa = nIlkKasa
        End If

    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        sorgu()
    End Sub
    Private Sub sorgu()
        Me.Hide()
        kontrol()
        Dim frm As New frmposciro
        Dim Frmpos As New frmrptpos
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        con.ConnectionString = connection
        cmd.Connection = con
        If islem = 1 Then
            con.Open()
            cmd.CommandText = "TRUNCATE TABLE BTBLINTERSATIS"
            cmd.ExecuteNonQuery()
            con.Close()
            dll.dataset1.Clear()
        ElseIf islem = 2 Then
            dll.dataset1 = frm.DataSet1
            dll.dataset1.Tables(0).Clear()
        ElseIf islem = 3 Then
            dll.dataset1.Tables(0).Clear()
        ElseIf islem = 4 Then
            dll.dataset1 = Frmpos.DataSet1
            con.Open()
            cmd.CommandText = "TRUNCATE TABLE BTBLINTERCIRO"
            cmd.ExecuteNonQuery()
            con.Close()
        End If
        For i = nIlkKasa To nSonKasa
            yil = tarih.Substring(8, 2)
            gun = tarih.Substring(0, 2)
            ay = tarih.Substring(3, 2)
            Dim path = sPath  'Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("INTERPOS").GetValue("PATH")
            s = "" & path & ":\posgenel\HR"
            s += gun
            s += ay
            s += yil
            s += ".00"
            s += nIlkKasa.ToString
            Dim DOSYA As New FileInfo(s)
            If DOSYA.Exists Then
                DOSYA.CopyTo("" & s & "YDK", True)
                If islem = 1 Then
                    'dll.intersatisoku(s & "YDK", kasa)
                ElseIf islem = 2 Then
                    dll.ciro_INTER(s & "YDK", nIlkKasa, kasa)
                ElseIf islem = 3 Then
                    dll.interurunkontrol(s & "YDK", kasa)
                ElseIf islem = 4 Then
                    dll.satis_INTER(s & "YDK", kasa)
                End If
            Else
                XtraMessageBox.Show("Hareket Dosyasý Bulunamadý" & vbCrLf & "Kasano =" & nIlkKasa & vbCrLf & "Path :" & s, Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
            nIlkKasa += 1
        Next
        Dim DOSYA1 As New FileInfo(s)
        If DOSYA1.Exists Then
            If islem = 1 Then
                'dll.satis_INTER_sql()
            ElseIf islem = 2 Then
                frm.Label1.Text = "" & kasa & " Ciro Raporu"
                frm.DataSet1 = dll.dataset1
                frm.ShowDialog()
            End If
        End If
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub VGridControl1_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraVerticalGrid.Events.FocusedRowChangedEventArgs) Handles VGridControl1.FocusedRowChanged
        Try
            VGridControl1.PostEditor()
            VGridControl1.UpdateFocusedRecord()
            VGridControl1.CloseEditor()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        sorgu()
    End Sub
    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        Me.Close()
    End Sub
End Class
