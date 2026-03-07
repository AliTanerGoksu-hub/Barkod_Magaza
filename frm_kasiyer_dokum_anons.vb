Imports System.IO
Imports Microsoft.Win32
Imports DevExpress.XtraEditors
Public Class frm_kasiyer_dokum_anons
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
    Friend WithEvents Label1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txt_anons As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents adap1 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents con As System.Data.OleDb.OleDbConnection
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents sec_resim As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents DataTable1 As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_kasiyer_dokum_anons))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.Label1 = New DevExpress.XtraEditors.LabelControl
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl
        Me.sec_resim = New DevExpress.XtraEditors.PictureEdit
        Me.DataSet1 = New System.Data.DataSet
        Me.DataTable1 = New System.Data.DataTable
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.DataColumn3 = New System.Data.DataColumn
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.txt_anons = New DevExpress.XtraEditors.MemoEdit
        Me.adap1 = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand
        Me.con = New System.Data.OleDb.OleDbConnection
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.sec_resim.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txt_anons.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Controls.Add(Me.PictureBox1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(392, 48)
        Me.PanelControl1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(110, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(218, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Dökümlerde Çýkan Anons Bilgileri Aþaðýdadýr..."
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(108, 44)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.SimpleButton3)
        Me.PanelControl2.Controls.Add(Me.SimpleButton2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 222)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(392, 48)
        Me.PanelControl2.TabIndex = 1
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Image = CType(resources.GetObject("SimpleButton3.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(16, 16)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(88, 23)
        Me.SimpleButton3.TabIndex = 2
        Me.SimpleButton3.Text = "Resim Yükle"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(299, 16)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton2.TabIndex = 1
        Me.SimpleButton2.Text = "&Vazgeç"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(224, 16)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton1.TabIndex = 0
        Me.SimpleButton1.Text = "&Tamam"
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.GroupControl2)
        Me.PanelControl3.Controls.Add(Me.GroupControl1)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl3.Location = New System.Drawing.Point(0, 48)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(392, 174)
        Me.PanelControl3.TabIndex = 0
        '
        'GroupControl2
        '
        Me.GroupControl2.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupControl2.AppearanceCaption.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupControl2.AppearanceCaption.Options.UseFont = True
        Me.GroupControl2.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl2.AppearanceCaption.Options.UseTextOptions = True
        Me.GroupControl2.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GroupControl2.Controls.Add(Me.sec_resim)
        Me.GroupControl2.Location = New System.Drawing.Point(213, 13)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(168, 152)
        Me.GroupControl2.TabIndex = 1
        Me.GroupControl2.Text = "Resim"
        '
        'sec_resim
        '
        Me.sec_resim.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.RESIM", True))
        Me.sec_resim.Dock = System.Windows.Forms.DockStyle.Fill
        Me.sec_resim.Location = New System.Drawing.Point(2, 22)
        Me.sec_resim.Name = "sec_resim"
        Me.sec_resim.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.sec_resim.Properties.Appearance.Options.UseBackColor = True
        Me.sec_resim.Properties.NullText = "[Yüklü Resim Bulunamadý...]"
        Me.sec_resim.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        Me.sec_resim.Size = New System.Drawing.Size(164, 128)
        Me.sec_resim.TabIndex = 0
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3})
        Me.DataTable1.TableName = "Table1"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "IND"
        Me.DataColumn1.DataType = GetType(Long)
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "ACIKLAMA"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "RESIM"
        Me.DataColumn3.DataType = GetType(Byte())
        '
        'GroupControl1
        '
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl1.AppearanceCaption.Options.UseTextOptions = True
        Me.GroupControl1.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GroupControl1.Controls.Add(Me.txt_anons)
        Me.GroupControl1.Location = New System.Drawing.Point(8, 13)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(200, 152)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Anons"
        '
        'txt_anons
        '
        Me.txt_anons.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.ACIKLAMA", True))
        Me.txt_anons.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_anons.Location = New System.Drawing.Point(2, 22)
        Me.txt_anons.Name = "txt_anons"
        Me.txt_anons.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_anons.Properties.Appearance.Options.UseBackColor = True
        Me.txt_anons.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_anons.Size = New System.Drawing.Size(196, 128)
        Me.txt_anons.TabIndex = 0
        '
        'adap1
        '
        Me.adap1.DeleteCommand = Me.OleDbDeleteCommand1
        Me.adap1.InsertCommand = Me.OleDbInsertCommand1
        Me.adap1.SelectCommand = Me.OleDbSelectCommand1
        Me.adap1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "ATBLDOKUMANONS", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("IND", "IND"), New System.Data.Common.DataColumnMapping("ACIKLAMA", "ACIKLAMA"), New System.Data.Common.DataColumnMapping("RESIM", "RESIM")})})
        Me.adap1.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = "DELETE FROM ATBLDOKUMANONS WHERE (IND = ?)"
        Me.OleDbDeleteCommand1.Connection = Me.con
        Me.OleDbDeleteCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Original_IND", System.Data.OleDb.OleDbType.[Integer], 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IND", System.Data.DataRowVersion.Original, Nothing)})
        '
        'con
        '
        Me.con.ConnectionString = resources.GetString("con.ConnectionString")
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO  ATBLDOKUMANONS(ACIK" & _
            "LAMA, RESIM) VALUES (?, ?); SELECT IND, ACIKLAMA, RESIM FROM ATBLDOKUMANONS WHER" & _
            "E (IND = @@IDENTITY)"
        Me.OleDbInsertCommand1.Connection = Me.con
        Me.OleDbInsertCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("ACIKLAMA", System.Data.OleDb.OleDbType.VarWChar, 1073741823, "ACIKLAMA"), New System.Data.OleDb.OleDbParameter("RESIM", System.Data.OleDb.OleDbType.VarBinary, 2147483647, "RESIM")})
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT IND, ACIKLAMA, RESIM FROM" & _
            " ATBLDOKUMANONS WHERE IND =1"
        Me.OleDbSelectCommand1.Connection = Me.con
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE ATBLDOKUMANONS SET ACIKLA" & _
            "MA = ?, RESIM = ? WHERE (IND = ?); SELECT IND, ACIKLAMA, RESIM FROM ATBLDOKUMANO" & _
            "NS WHERE (IND = ?)"
        Me.OleDbUpdateCommand1.Connection = Me.con
        Me.OleDbUpdateCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("ACIKLAMA", System.Data.OleDb.OleDbType.VarWChar, 1073741823, "ACIKLAMA"), New System.Data.OleDb.OleDbParameter("RESIM", System.Data.OleDb.OleDbType.VarBinary, 2147483647, "RESIM"), New System.Data.OleDb.OleDbParameter("Original_IND", System.Data.OleDb.OleDbType.[Integer], 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IND", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Select_IND", System.Data.OleDb.OleDbType.[Integer], 4, "IND")})
        '
        'frm_kasiyer_dokum_anons
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(392, 270)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_kasiyer_dokum_anons"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Kasiyer Döküm Anonsu"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.sec_resim.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.txt_anons.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub
#End Region
    Public connection
    Public firmano
    Public donemno
    Public kullanici
    Private Sub frm_kasiyer_dokum_anons_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.ConnectionString = connection
        dataload()
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Try
            Dim ds As DataSet
            ds = DataSet1
            con.ConnectionString = connection
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = con
            con.Open()
            cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE ATBLDOKUMANONS SET ACIKLAMA ='" & txt_anons.EditValue & "' WHERE IND =1"
            cmd.ExecuteNonQuery()
            con.Close()
            Dim da As New OleDb.OleDbDataAdapter
            da.UpdateCommand = cmd
            cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE ATBLDOKUMANONS SET RESIM = ? WHERE (IND = 1) "
            cmd.Parameters.Add(New System.Data.OleDb.OleDbParameter("RESIM", System.Data.OleDb.OleDbType.VarBinary, 2147483647, "RESIM"))
            da.Update(DataSet1.Tables(0))
            da = Nothing
            Me.Close()
        Catch ex As Exception
            Me.Close()
        End Try
    End Sub
    Private Sub dataload()
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        con.ConnectionString = connection
        adapter.SelectCommand = cmd
        'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT stok.IND, stok.STOKKODU, stok.MALINCINSI, stok.ALTSEVIYE, stok.KRITIKSEVIYE, stok.USTSEVIYE,stok.depo, stok.DEPOSEVIYESI, stok.URETICI, stok.AYLIKVADE, stok.SERINO, stok.DEPO, stok.STOKGRUBU, stok.GARANTI, stok.PRIM, stok.IPTAL, stok.STOKTIPI, stok.STOKTAKIP, stok.TEMINYERI, stok.RAFOMRU, stok.KALAN, stok.REZERV, stok.SATISKOSULU, stok.KOD1, stok.KOD2, stok.KOD3, stok.KOD4, stok.KOD5, stok.KOD6, stok.KOD7, stok.KOD8, stok.KOD9, stok.KOD10,STOK.RESIM, stok.TAKSITSAYISI, stok.ISTIHBARAT, stok.FIYATYOK, stok.DELETED, stok.ALISFIYATI, stok.ALISFIYATIDEGISMETARIHI, stok.ESKIALISFIYATI, stok.SONALISTARIHI, stok.SONSATISTARIHI, stok.KARTINACILMATARIHI, stok.DEVIRIND, stok.MALIYET, stok.KDVGRUBU, stok.AKTIF, stok.ISCILIKIND, stok.ISCILIKBIRIMIND, stok.ISCILIKACIKLAMA, stok.STATUS, stok.DALISFIYATI, stok.APB,birim.IND AS BIRIMNO, birim.BIRIMADI, birim.CARPAN, birim.BARCODE, birim.BARCODESTD, birim.ACIKLAMA, birim.KDV, birim.KDVDAHIL, birim.SATISFIYATI1, birim.SATISFIYATI2, birim.SATISFIYATI3, birim.PB1, birim.PB2, birim.PB3,birim.BIRIM2,birim.BIRIM2CARPAN,birim.BIRIM3,birim.BIRIM3CARPAN FROM *!FTBLSTOKLAR stok INNER JOIN *!FTBLBIRIMLEREX birim ON stok.ANABIRIM = birim.IND AND stok.BIRIMEX = birim.IND AND stok.IND = birim.STOKNO WHERE stok.IND=" & stokno & "")
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT IND,ACIKLAMA,RESIM FROM ATBLDOKUMANONS WHERE IND =1 "
        cmd.Connection = con
        con.Open()
        adapter.Fill(DataSet1.Tables(0))
        con.Close()
        con = Nothing
        cmd = Nothing
        adapter = Nothing
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
    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        Dim dr As DataRow
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim fs As New FileStream(OpenFileDialog1.FileName.ToString, FileMode.OpenOrCreate, FileAccess.Read)
            Dim MyData(fs.Length) As Byte
            fs.Read(MyData, 0, fs.Length)
            fs.Close()
            dr = DataSet1.Tables(0).Rows(0)
            dr("RESIM") = MyData
        End If
        dr = Nothing
    End Sub
    Private Sub adap1_RowUpdated(ByVal sender As System.Object, ByVal e As System.Data.OleDb.OleDbRowUpdatedEventArgs) Handles adap1.RowUpdated
    End Sub
End Class
