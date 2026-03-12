Imports System.IO
Imports Microsoft.Win32
Imports System.Text
Public Class frmkasaizle
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
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents DataTable1 As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents colKASANO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colACIKLAMA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmkasaizle))
        Me.Panel1 = New DevExpress.XtraEditors.PanelControl
        Me.Label1 = New DevExpress.XtraEditors.LabelControl
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Panel2 = New DevExpress.XtraEditors.PanelControl
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.Panel3 = New DevExpress.XtraEditors.PanelControl
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.DataTable1 = New System.Data.DataTable
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.DataColumn3 = New System.Data.DataColumn
        Me.DataColumn4 = New System.Data.DataColumn
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colKASANO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colACIKLAMA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsMessage = New DevExpress.XtraGrid.Columns.GridColumn
        Me.DataSet1 = New System.Data.DataSet
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.Panel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.Panel1.Size = New System.Drawing.Size(330, 60)
        Me.Panel1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(2, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(270, 52)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Pos Kasa Mesaj Takibi ; Aþaðýda sisteme baðlý kasa bilgilerini ve yapýlan iþlemin" & _
            " sonuçlarýný görmektesiniz. Takip iþlemini bitirmek için [Tamam], ekrandan çýkma" & _
            "k için [Çýkýþ] butonuna týklayýnýz..."
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(272, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(56, 56)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.SimpleButton2)
        Me.Panel2.Controls.Add(Me.SimpleButton1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 387)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(330, 44)
        Me.Panel2.TabIndex = 1
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Image = Global.business_smart.My.Resources.Resources.button_cancel
        Me.SimpleButton2.Location = New System.Drawing.Point(239, 9)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(84, 24)
        Me.SimpleButton2.TabIndex = 1
        Me.SimpleButton2.Text = "&Vazgeç"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Image = Global.business_smart.My.Resources.Resources.button_ok
        Me.SimpleButton1.Location = New System.Drawing.Point(157, 9)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(82, 24)
        Me.SimpleButton1.TabIndex = 0
        Me.SimpleButton1.Text = "&Tamam"
        '
        'Panel3
        '
        Me.Panel3.Appearance.BackColor = System.Drawing.Color.White
        Me.Panel3.Appearance.Options.UseBackColor = True
        Me.Panel3.Controls.Add(Me.GridControl1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 60)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(330, 327)
        Me.Panel3.TabIndex = 0
        '
        'GridControl1
        '
        Me.GridControl1.ContextMenu = Me.ContextMenu1
        Me.GridControl1.DataSource = Me.DataTable1
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(2, 2)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(326, 323)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
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
        Me.DataColumn1.ColumnName = "IND"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "KASANO"
        Me.DataColumn2.DataType = GetType(Integer)
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "ACIKLAMA"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "MESSAGE"
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
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colKASANO, Me.colACIKLAMA, Me.colsMessage})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView1.IndicatorWidth = 35
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsCustomization.AllowSort = False
        Me.GridView1.OptionsMenu.EnableColumnMenu = False
        Me.GridView1.OptionsMenu.EnableFooterMenu = False
        Me.GridView1.OptionsMenu.EnableGroupPanelMenu = False
        Me.GridView1.OptionsNavigation.AutoFocusNewRow = True
        Me.GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colKASANO
        '
        Me.colKASANO.Caption = "KasaNo"
        Me.colKASANO.FieldName = "KASANO"
        Me.colKASANO.Name = "colKASANO"
        Me.colKASANO.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "KASANO", "Kayýt: {0}")})
        Me.colKASANO.Visible = True
        Me.colKASANO.VisibleIndex = 0
        Me.colKASANO.Width = 40
        '
        'colACIKLAMA
        '
        Me.colACIKLAMA.Caption = "Açýklama"
        Me.colACIKLAMA.FieldName = "ACIKLAMA"
        Me.colACIKLAMA.Name = "colACIKLAMA"
        Me.colACIKLAMA.Visible = True
        Me.colACIKLAMA.VisibleIndex = 1
        Me.colACIKLAMA.Width = 100
        '
        'colsMessage
        '
        Me.colsMessage.Caption = "Mesaj"
        Me.colsMessage.FieldName = "MESSAGE"
        Me.colsMessage.Name = "colsMessage"
        Me.colsMessage.Visible = True
        Me.colsMessage.VisibleIndex = 2
        Me.colsMessage.Width = 149
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 3000
        '
        'frmkasaizle
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(330, 431)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmkasaizle"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PosKasaÝzle"
        CType(Me.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.Panel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub
#End Region
    Public ilkkasa As Integer
    Public sonkasa As Integer
    Public kasa As String
    Public sPath As String
    Public sAyrac As String = ":"
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub
    Private Sub frmkasaizle_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Timer1.Enabled = False
    End Sub
    Private Sub frmkasaizle_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i As Integer
        Dim t As Integer = ilkkasa - 1
        For i = ilkkasa To sonkasa
            t += 1
            Dim dr As DataRow = DataSet1.Tables(0).NewRow
            dr(1) = sayiuzunlukkontrol(t, 3)
            dr(2) = "Mesaj Koyuldu"
            dr(3) = ""
            DataSet1.Tables(0).Rows.Add(dr)
            'Dim Z As String = "" & path & ":\POSKON\MESAJ." & sayiuzunlukkontrol(t, 3) & ""
            'Dim sw As StreamWriter = File.CreateText(Z)
            'sw.WriteLine("107100000000000")
            'sw.Close()
        Next
        If sPath = "\\tsclient\C" Or sPath = "\\tsclient\D" Or sPath = "\\tsclient\E" Or sPath = "\\tsclient\F" Then
            sAyrac = ""
        End If
        Timer1.Enabled = True
    End Sub
    Private Sub GridControl1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyDown
        If e.KeyCode = Windows.Forms.Keys.Enter Then
            Timer1.Enabled = False
            Me.Close()
        End If
    End Sub
    Private Sub mesaj_kontrol()
        Dim dr As DataRow
        For Each dr In DataSet1.Tables(0).Rows
            If dr(2) = "Ýþlem Tamam" Then
            ElseIf dr(2) = "Ýþlem Baþarýlamadý" Then
            Else
                Dim path = sPath 'Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("INTERPOS").GetValue("PATH")
                Dim dosya As String = "" & path & sAyrac & "\poskon\mesaj.001" 'SAVE.FileName.ToString
                If kasa = "inter" Then
                    dosya = "" & path & sAyrac & "\POSKON\MESAJ." & sayiuzunlukkontrol(dr(1), 3) & "" 'SAVE.FileName.ToString
                ElseIf kasa = "escort" Then
                    dosya = "" & path & sAyrac & "\POSGENEL\DATA\MESAJ." & sayiuzunlukkontrol(dr(1), 3) & "" 'SAVE.FileName.ToString
                End If
                Dim dosya1 As New FileInfo(dosya)
                If dosya1.Exists Then
                    'dosya1.CopyTo(dosya & "YDK", True)
                    'Dim z = dosya & "YDK"
                    Dim fs As FileStream = New FileStream(dosya, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)
                    Dim sr As StreamReader = New StreamReader(fs)
                    'Dim fs As FileStream = File.Open(z, FileMode.Open, FileAccess.Read)
                    'Dim sr As StreamReader = File.OpenRead(dosya)
                    'Dim s As String
                    Dim satir As String
                    Dim takipno
                    Dim message As String = ""
                    Dim kontrol As String = ""
                    Do While sr.Peek() > -1
                        satir = sr.ReadLine
                        takipno = satir.Substring(0, 1)
                        message = satir.Substring(1, 2)
                        If takipno = 1 Then
                            kontrol = "Mesaj Gönderildi"
                        ElseIf takipno = 2 Then
                            kontrol = "Mesaj Kasa Tarafýndan Alýndý"
                        ElseIf takipno = 3 Then
                            kontrol = "Ýþlem Tamam"
                        ElseIf takipno = 4 Then
                            kontrol = "Ýþlem Baþarýlamadý"
                        End If
                        If message = "01" Then
                            dr(3) = "X Raporu Al"
                        ElseIf message = "02" Then
                            dr(3) = "Z Raporu Al"
                        ElseIf message = "03" Then
                            dr(3) = "Mali Bellek Raporu Al Z"
                        ElseIf message = "04" Then
                            dr(3) = "Mali Beller Raporu Al Tarih"
                        ElseIf message = "05" Then
                            dr(3) = "Aylýk Rapor Al"
                        ElseIf message = "06" Then
                            dr(3) = "Program Dosyasý Al"
                        ElseIf message = "07" Then
                            dr(3) = "Ürün Dosyasý Al"
                        ElseIf message = "08" Then
                            dr(3) = "Müþteri Dosyasý Al"
                        ElseIf message = "09" Then
                            dr(3) = "Kasiyer Dosyasý Al"
                        ElseIf message = "10" Then
                            dr(3) = "Döviz Dosyasý Al"
                        ElseIf message = "11" Then
                            dr(3) = "Promosyon Dosyasý Al"
                        ElseIf message = "12" Then
                            dr(3) = "Taksit Dosyasý Al"
                        ElseIf message = "13" Then
                            dr(3) = "Ekrana Mesaj Al"
                        ElseIf message = "14" Then
                            dr(3) = "Tüm Dosyalarý Al"
                        ElseIf message = "15" Then
                            dr(3) = "Puan Dosyasý Al"
                        ElseIf message = "16" Then
                            dr(3) = "Karma Koli Dosyasý Al"
                        ElseIf message = "17" Then
                            dr(3) = "Kara Listesi Dosyasý Al"
                        ElseIf message = "18" Then
                            dr(3) = "Hediye Çeki Dosyasý Al"
                        ElseIf message = "19" Then
                            dr(3) = "Ürünlerin Taksitli Fiyat Listesini Al"
                        ElseIf message = "20" Then
                            dr(3) = "Özel Gün Dosyasý Al"
                        ElseIf message = "21" Then
                            dr(3) = "Smart Kart Promosyon Dosyasý Al"
                        ElseIf message = "22" Then
                            dr(3) = "SDXFARK.DAT DOSYASINI AL"
                        ElseIf message = "23" Then
                            dr(3) = "TEKURUN.DAT DOSYASINI AL"
                        ElseIf message = "24" Then
                            dr(3) = "URUNPUAN.DAT DOSYASINI AL"
                        ElseIf message = "25" Then
                            dr(3) = "VERGÝ GRUBU DOSYASI AL"
                        ElseIf message = "26" Then
                            dr(3) = "REYON DOSYASI AL"
                        ElseIf message = "27" Then
                            dr(3) = "DÝPNOT DOSYASI AL"
                        ElseIf message = "28" Then
                            dr(3) = "YETKÝ DOSYASI AL"
                        ElseIf message = "29" Then
                            dr(3) = "TOPTAN DOSYASI AL"
                        ElseIf message = "30" Then
                            dr(3) = "PREFIX DOSYASI AL"
                        ElseIf message = "31" Then
                            dr(3) = "MÜÞTERÝ DOGUM GÜN DOSYASI AL"
                        ElseIf message = "32" Then
                            dr(3) = "JURNAL DETAY RAPORU AL"
                        ElseIf message = "33" Then
                            dr(3) = "ÝLERÝ TARÝHLÝ FÝYAT DOSYASI AL."
                        ElseIf message = "34" Then
                            dr(3) = "ÜCRETLÝ EMEKLÝ MESAJ DOSYASI AL"
                        ElseIf message = "35" Then
                            dr(3) = "NOPROMO.DAT DOSYASI AL"
                        ElseIf message = "36" Then
                            dr(3) = "GRUP.DAT DOSYASI AL"
                        ElseIf message = "37" Then
                            dr(3) = "TICKET.DAT DOSYASI AL"
                        ElseIf message = "38" Then
                            dr(3) = "OZELKOD.DAT DOSYASI AL"
                        ElseIf message = "39" Then
                            dr(3) = "TEVKIFAT.DAT DOSYASI AL"
                        ElseIf message = "40" Then
                            dr(3) = "GRDIPNOT.DAT DOSYASI AL"
                        ElseIf message = "41" Then
                            dr(3) = "PRMISIM.DAT DOSYASI AL"
                        ElseIf message = "42" Then
                            dr(3) = "NOURUN.DAT DOSYASI AL"
                        ElseIf message = "43" Then
                            dr(3) = "NOPUAN DOSYASI AL"
                        ElseIf message = "95" Then
                            dr(3) = "BÝTMAP LOGO BÝLGÝSÝ SÝL"
                        ElseIf message = "96" Then
                            dr(3) = "FÝÞ BAÞINDAKÝ BÝTMAP LOGO BÝLGÝSÝ AL "
                        ElseIf message = "97" Then
                            dr(3) = "FÝÞ SONUNDAKÝ BÝTMAP LOGO BÝLGÝSÝ AL "
                        ElseIf message = "98" Then
                            '198ggaayyyyGGAAYYYYcrlf
                            dr(3) = "ARKA OFÝSE HAREKET DOSYALARINI GÖNDER"
                        ElseIf message = "99" Then
                            dr(3) = "ÖN OFÝS EXE LERÝNÝ GÜNCELLE"
                        End If
                        dr.BeginEdit()
                        dr(2) = kontrol
                        dr.EndEdit()
                    Loop
                    sr.Close()
                    sr.Dispose()
                    sr = Nothing
                End If
                dosya = Nothing
                dosya1 = Nothing
            End If
        Next
        dr = Nothing
    End Sub
    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        mesaj_kontrol()
    End Sub
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        Me.Close()
    End Sub
    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        Me.Close()
    End Sub
    Private Sub GridView1_CustomDrawRowIndicator(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles GridView1.CustomDrawRowIndicator
        If e.RowHandle >= 0 Then
            e.Info.DisplayText = e.RowHandle + 1
        Else
            e.Info.DisplayText = ""
        End If
    End Sub
    Private Sub GridView1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridView1.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents colsMessage As DevExpress.XtraGrid.Columns.GridColumn
End Class
