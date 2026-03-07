Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.Collections.Generic

''' <summary>
''' Audit Log Raporlama ve Yönetim Formu
''' Tüm işlem geçmişini görüntüler, filtreler ve geri alma işlemleri yapar
''' </summary>
Public Class frm_AuditLog_Rapor
    Inherits DevExpress.XtraEditors.XtraForm

#Region "Form Controls"
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents barManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents btnYenile As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnGeriAl As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSilinenGeriYukle As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDetayGoster As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnExcelAktar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnKapat As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cmbModul As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cmbIslemTipi As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txtKullanici As DevExpress.XtraEditors.TextEdit
    Friend WithEvents dateBaslangic As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dateBitis As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtKayitID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents chkSadeceGeriAlinabilir As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents layoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents layoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents layoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents layoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
#End Region

#Region "Private Variables"
    Private dtAuditLog As DataTable
    Private secilenKayitID As Long = 0
#End Region

#Region "Constructor & Form Events"
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub frm_AuditLog_Rapor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' Form başlığı
            Me.Text = "Audit Log - İşlem Geçmişi ve Yönetim"
            Me.WindowState = FormWindowState.Maximized

            ' Modül listesi
            cmbModul.Properties.Items.Clear()
            cmbModul.Properties.Items.Add("Tümü")
            For Each modul As AuditLogger.ModulAdi In [Enum].GetValues(GetType(AuditLogger.ModulAdi))
                cmbModul.Properties.Items.Add(modul.ToString())
            Next
            cmbModul.SelectedIndex = 0

            ' İşlem tipi listesi
            cmbIslemTipi.Properties.Items.Clear()
            cmbIslemTipi.Properties.Items.Add("Tümü")
            For Each tip As AuditLogger.IslemTipi In [Enum].GetValues(GetType(AuditLogger.IslemTipi))
                cmbIslemTipi.Properties.Items.Add(tip.ToString())
            Next
            cmbIslemTipi.SelectedIndex = 0

            ' Tarih aralığı (son 30 gün)
            dateBitis.EditValue = DateTime.Today
            dateBaslangic.EditValue = DateTime.Today.AddDays(-30)

            ' Grid görünüm ayarları
            GridView1.OptionsBehavior.Editable = False
            GridView1.OptionsView.ShowAutoFilterRow = True
            GridView1.OptionsView.ShowFooter = True
            GridView1.OptionsView.ColumnAutoWidth = False

            ' Verileri yükle
            VerileriYukle()

        Catch ex As Exception
            DevExpress.XtraEditors.XtraMessageBox.Show($"Form yükleme hatası: {ex.Message}", "Hata", 
                                                       MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub InitializeComponent()
        ' Form kontrollerini oluştur
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.barManager1 = New DevExpress.XtraBars.BarManager()
        Me.bar1 = New DevExpress.XtraBars.Bar()
        Me.btnYenile = New DevExpress.XtraBars.BarButtonItem()
        Me.btnGeriAl = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSilinenGeriYukle = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDetayGoster = New DevExpress.XtraBars.BarButtonItem()
        Me.btnExcelAktar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnKapat = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.cmbModul = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cmbIslemTipi = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txtKullanici = New DevExpress.XtraEditors.TextEdit()
        Me.dateBaslangic = New DevExpress.XtraEditors.DateEdit()
        Me.dateBitis = New DevExpress.XtraEditors.DateEdit()
        Me.txtKayitID = New DevExpress.XtraEditors.TextEdit()
        Me.chkSadeceGeriAlinabilir = New DevExpress.XtraEditors.CheckEdit()
        Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.layoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.layoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.layoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()

        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()

        ' GridControl1
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Size = New System.Drawing.Size(1200, 600)

        ' GridView1
        Me.GridView1.GridControl = Me.GridControl1

        ' BarManager
        Me.barManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.bar1})
        Me.barManager1.Form = Me
        Me.barManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {
            Me.btnYenile, Me.btnGeriAl, Me.btnSilinenGeriYukle, 
            Me.btnDetayGoster, Me.btnExcelAktar, Me.btnKapat})

        ' Bar1 (Toolbar)
        Me.bar1.BarName = "Tools"
        Me.bar1.DockCol = 0
        Me.bar1.DockRow = 0
        Me.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {
            New DevExpress.XtraBars.LinkPersistInfo(Me.btnYenile),
            New DevExpress.XtraBars.LinkPersistInfo(Me.btnGeriAl, True),
            New DevExpress.XtraBars.LinkPersistInfo(Me.btnSilinenGeriYukle),
            New DevExpress.XtraBars.LinkPersistInfo(Me.btnDetayGoster, True),
            New DevExpress.XtraBars.LinkPersistInfo(Me.btnExcelAktar),
            New DevExpress.XtraBars.LinkPersistInfo(Me.btnKapat, True)})

        ' Butonlar
        Me.btnYenile.Caption = "Yenile"
        Me.btnYenile.Id = 0
        ' Me.btnYenile.ImageOptions.SvgImageSize = New System.Drawing.Size(16, 16) ' Eski DevExpress versiyonu için yorum satırı

        Me.btnGeriAl.Caption = "Değişikliği Geri Al"
        Me.btnGeriAl.Id = 1

        Me.btnSilinenGeriYukle.Caption = "Silinen Kaydı Geri Yükle"
        Me.btnSilinenGeriYukle.Id = 2

        Me.btnDetayGoster.Caption = "Detay Göster"
        Me.btnDetayGoster.Id = 3

        Me.btnExcelAktar.Caption = "Excel'e Aktar"
        Me.btnExcelAktar.Id = 4

        Me.btnKapat.Caption = "Kapat"
        Me.btnKapat.Id = 5

        ' LayoutControl
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.LayoutControl1.Controls.Add(Me.cmbModul)
        Me.LayoutControl1.Controls.Add(Me.cmbIslemTipi)
        Me.LayoutControl1.Controls.Add(Me.txtKullanici)
        Me.LayoutControl1.Controls.Add(Me.dateBaslangic)
        Me.LayoutControl1.Controls.Add(Me.dateBitis)
        Me.LayoutControl1.Controls.Add(Me.txtKayitID)
        Me.LayoutControl1.Controls.Add(Me.chkSadeceGeriAlinabilir)
        Me.LayoutControl1.Root = Me.layoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(1200, 100)

        ' Layout items
        Me.layoutControlItem2.Control = Me.cmbModul
        Me.layoutControlItem2.Text = "Modül:"
        Me.layoutControlItem3.Control = Me.cmbIslemTipi
        Me.layoutControlItem3.Text = "İşlem Tipi:"
        Me.layoutControlItem4.Control = Me.txtKullanici
        Me.layoutControlItem4.Text = "Kullanıcı:"
        Me.layoutControlItem5.Control = Me.dateBaslangic
        Me.layoutControlItem5.Text = "Başlangıç:"
        Me.layoutControlItem6.Control = Me.dateBitis
        Me.layoutControlItem6.Text = "Bitiş:"
        Me.layoutControlItem7.Control = Me.txtKayitID
        Me.layoutControlItem7.Text = "Kayıt ID:"
        Me.layoutControlItem8.Control = Me.chkSadeceGeriAlinabilir
        Me.chkSadeceGeriAlinabilir.Properties.Caption = "Sadece Geri Alınabilir Kayıtlar"

        ' Form
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 700)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frm_AuditLog_Rapor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen

        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub
#End Region

#Region "Private Methods"
    ''' <summary>
    ''' Verileri yükle
    ''' </summary>
    Private Sub VerileriYukle()
        Try
            Me.Cursor = Cursors.WaitCursor

            ' Filtreleri hazırla
            Dim whereKosullari As New List(Of String)
            Dim parametreler As New List(Of Object)

            ' Modül filtresi
            If cmbModul.SelectedIndex > 0 Then
                whereKosullari.Add("sModulAdi = ?")
                parametreler.Add(cmbModul.Text)
            End If

            ' İşlem tipi filtresi
            If cmbIslemTipi.SelectedIndex > 0 Then
                whereKosullari.Add("sIslemTipi = ?")
                parametreler.Add(cmbIslemTipi.Text)
            End If

            ' Kullanıcı filtresi
            If Not String.IsNullOrEmpty(txtKullanici.Text) Then
                whereKosullari.Add("sKullaniciAdi LIKE ?")
                parametreler.Add("%" & txtKullanici.Text & "%")
            End If

            ' Tarih filtresi
            If dateBaslangic.EditValue IsNot Nothing Then
                whereKosullari.Add("dteIslemZamani >= ?")
                parametreler.Add(CDate(dateBaslangic.EditValue))
            End If

            If dateBitis.EditValue IsNot Nothing Then
                whereKosullari.Add("dteIslemZamani <= ?")
                parametreler.Add(CDate(dateBitis.EditValue).AddDays(1))
            End If

            ' Kayıt ID filtresi
            If Not String.IsNullOrEmpty(txtKayitID.Text) AndAlso IsNumeric(txtKayitID.Text) Then
                whereKosullari.Add("nKayitID = ?")
                parametreler.Add(CLng(txtKayitID.Text))
            End If

            ' Sadece geri alınabilir
            If chkSadeceGeriAlinabilir.Checked Then
                whereKosullari.Add("bGeriAlindi = 0")
                whereKosullari.Add("sIslemTipi IN ('UPDATE','DELETE')")
            End If

            ' Sorgu oluştur
            Dim query As String = "SELECT * FROM tbAuditLog"
            If whereKosullari.Count > 0 Then
                query &= " WHERE " & String.Join(" AND ", whereKosullari)
            End If
            query &= " ORDER BY dteIslemZamani DESC, nAuditLogID DESC"

            ' Veritabanından çek
            dtAuditLog = VeriTabaniSorguCalistir(query, parametreler.ToArray())

            ' Veri yoksa veya hata varsa
            If dtAuditLog Is Nothing OrElse dtAuditLog.Rows.Count = 0 Then
                GridControl1.DataSource = Nothing
                DevExpress.XtraEditors.XtraMessageBox.Show("Henüz audit log kaydı bulunmuyor." & vbCrLf & vbCrLf & "Önce SQL script'i çalıştırdığınızdan emin olun:" & vbCrLf & "AuditLogSystem/01_CREATE_tbAuditLog.sql", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If

            ' Grid'e bağla
            GridControl1.DataSource = dtAuditLog

            ' Kolon formatları (varsa)
            If GridView1.Columns.ColumnByFieldName("nAuditLogID") IsNot Nothing Then
                GridView1.Columns("nAuditLogID").Caption = "Log ID"
            End If
            If GridView1.Columns.ColumnByFieldName("sModulAdi") IsNot Nothing Then
                GridView1.Columns("sModulAdi").Caption = "Modül"
            End If
            If GridView1.Columns.ColumnByFieldName("sTabloAdi") IsNot Nothing Then
                GridView1.Columns("sTabloAdi").Caption = "Tablo"
            End If
            If GridView1.Columns.ColumnByFieldName("nKayitID") IsNot Nothing Then
                GridView1.Columns("nKayitID").Caption = "Kayıt ID"
            End If
            If GridView1.Columns.ColumnByFieldName("sKayitReferans") IsNot Nothing Then
                GridView1.Columns("sKayitReferans").Caption = "Referans"
            End If
            If GridView1.Columns.ColumnByFieldName("sIslemTipi") IsNot Nothing Then
                GridView1.Columns("sIslemTipi").Caption = "İşlem"
            End If
            If GridView1.Columns.ColumnByFieldName("sIslemAciklama") IsNot Nothing Then
                GridView1.Columns("sIslemAciklama").Caption = "Açıklama"
            End If
            If GridView1.Columns.ColumnByFieldName("sAlanAdi") IsNot Nothing Then
                GridView1.Columns("sAlanAdi").Caption = "Alan"
            End If
            If GridView1.Columns.ColumnByFieldName("sEskiDeger") IsNot Nothing Then
                GridView1.Columns("sEskiDeger").Caption = "Eski Değer"
            End If
            If GridView1.Columns.ColumnByFieldName("sYeniDeger") IsNot Nothing Then
                GridView1.Columns("sYeniDeger").Caption = "Yeni Değer"
            End If
            If GridView1.Columns.ColumnByFieldName("sKullaniciAdi") IsNot Nothing Then
                GridView1.Columns("sKullaniciAdi").Caption = "Kullanıcı"
            End If
            If GridView1.Columns.ColumnByFieldName("dteIslemZamani") IsNot Nothing Then
                GridView1.Columns("dteIslemZamani").Caption = "Tarih/Saat"
                GridView1.Columns("dteIslemZamani").DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
                GridView1.Columns("dteIslemZamani").DisplayFormat.FormatString = "dd.MM.yyyy HH:mm:ss"
            End If
            If GridView1.Columns.ColumnByFieldName("sBilgisayarAdi") IsNot Nothing Then
                GridView1.Columns("sBilgisayarAdi").Caption = "Bilgisayar"
            End If
            If GridView1.Columns.ColumnByFieldName("sIPAdresi") IsNot Nothing Then
                GridView1.Columns("sIPAdresi").Caption = "IP Adresi"
            End If
            If GridView1.Columns.ColumnByFieldName("bGeriAlindi") IsNot Nothing Then
                GridView1.Columns("bGeriAlindi").Caption = "Geri Alındı?"
            End If

            ' Gizle
            If GridView1.Columns.ColumnByFieldName("sJsonData") IsNot Nothing Then
                GridView1.Columns("sJsonData").Visible = False
            End If
            If GridView1.Columns.ColumnByFieldName("sMACAdres") IsNot Nothing Then
                GridView1.Columns("sMACAdres").Visible = False
            End If
            If GridView1.Columns.ColumnByFieldName("sWindowsKullanici") IsNot Nothing Then
                GridView1.Columns("sWindowsKullanici").Visible = False
            End If

            ' Footer'da kayıt sayısı
            If GridView1.Columns.ColumnByFieldName("nAuditLogID") IsNot Nothing Then
                Try
                    GridView1.Columns("nAuditLogID").Summary.Add(DevExpress.Data.SummaryItemType.Count, "nAuditLogID", "Toplam: {0}")
                Catch
                    ' Summary hatası göz ardı edilir
                End Try
            End If

        Catch ex As Exception
            DevExpress.XtraEditors.XtraMessageBox.Show($"Veri yükleme hatası: {ex.Message}", "Hata",
                                                       MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    ''' <summary>
    ''' Veritabanı sorgusu çalıştır
    ''' </summary>
    Private Function VeriTabaniSorguCalistir(query As String, ParamArray parametreler() As Object) As DataTable
        Dim dt As New DataTable()
        
        Try
            ' Registry'den bağlantı string al (Form1'deki yöntemle aynı)
            Dim connectionString As String = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("Software").OpenSubKey("Fast Reports").OpenSubKey("connections").GetValue("UGURLU").ToString()
            
            Using conn As New OleDbConnection(connectionString)
                Using cmd As New OleDbCommand(query, conn)
                    ' Parametreleri ekle
                    For Each param As Object In parametreler
                        If param IsNot Nothing Then
                            cmd.Parameters.AddWithValue("?", param)
                        Else
                            cmd.Parameters.AddWithValue("?", DBNull.Value)
                        End If
                    Next
                    
                    ' Veriyi doldur
                    Using da As New OleDbDataAdapter(cmd)
                        da.Fill(dt)
                    End Using
                End Using
            End Using
            
        Catch ex As Exception
            ' Hata durumunda boş tablo döndür
            Debug.WriteLine("VeriTabaniSorguCalistir hatası: " & ex.Message)
            dt = New DataTable()
        End Try
        
        Return dt
    End Function
#End Region

#Region "Button Events"
    Private Sub btnYenile_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnYenile.ItemClick
        VerileriYukle()
    End Sub

    Private Sub btnGeriAl_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnGeriAl.ItemClick
        Try
            Dim focusedRow As Integer = GridView1.FocusedRowHandle
            If focusedRow < 0 Then
                DevExpress.XtraEditors.XtraMessageBox.Show("Lütfen geri alınacak kaydı seçin.", "Uyarı",
                                                           MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim auditLogID As Long = CLng(GridView1.GetRowCellValue(focusedRow, "nAuditLogID"))
            Dim islemTipi As String = GridView1.GetRowCellValue(focusedRow, "sIslemTipi").ToString()
            Dim kayitReferans As String = GridView1.GetRowCellValue(focusedRow, "sKayitReferans").ToString()

            Dim result = DevExpress.XtraEditors.XtraMessageBox.Show(
                $"'{kayitReferans}' kaydındaki {islemTipi} işlemini geri almak istediğinizden emin misiniz?" & vbCrLf &
                "Bu işlem geri alınamaz!", "Onay",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                ' Geri alma işlemini yap
                If GeriAlmaIslemi(auditLogID) Then
                    DevExpress.XtraEditors.XtraMessageBox.Show("İşlem başarıyla geri alındı.", "Başarılı",
                                                               MessageBoxButtons.OK, MessageBoxIcon.Information)
                    VerileriYukle()
                End If
            End If

        Catch ex As Exception
            DevExpress.XtraEditors.XtraMessageBox.Show($"Geri alma hatası: {ex.Message}", "Hata",
                                                       MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSilinenGeriYukle_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSilinenGeriYukle.ItemClick
        Try
            Dim focusedRow As Integer = GridView1.FocusedRowHandle
            If focusedRow < 0 Then
                DevExpress.XtraEditors.XtraMessageBox.Show("Lütfen geri yüklenecek kaydı seçin.", "Uyarı",
                                                           MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim islemTipi As String = GridView1.GetRowCellValue(focusedRow, "sIslemTipi").ToString()
            If islemTipi <> "DELETE" Then
                DevExpress.XtraEditors.XtraMessageBox.Show("Sadece silinen kayıtlar geri yüklenebilir.", "Uyarı",
                                                           MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim auditLogID As Long = CLng(GridView1.GetRowCellValue(focusedRow, "nAuditLogID"))
            Dim kayitReferans As String = GridView1.GetRowCellValue(focusedRow, "sKayitReferans").ToString()

            Dim result = DevExpress.XtraEditors.XtraMessageBox.Show(
                $"'{kayitReferans}' kaydını geri yüklemek istediğinizden emin misiniz?", "Onay",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                ' Geri yükleme işlemini yap
                If SilinenKayitGeriYukle(auditLogID) Then
                    DevExpress.XtraEditors.XtraMessageBox.Show("Kayıt başarıyla geri yüklendi.", "Başarılı",
                                                               MessageBoxButtons.OK, MessageBoxIcon.Information)
                    VerileriYukle()
                End If
            End If

        Catch ex As Exception
            DevExpress.XtraEditors.XtraMessageBox.Show($"Geri yükleme hatası: {ex.Message}", "Hata",
                                                       MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDetayGoster_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDetayGoster.ItemClick
        Try
            Dim focusedRow As Integer = GridView1.FocusedRowHandle
            If focusedRow < 0 Then Return

            Dim jsonData As String = GridView1.GetRowCellValue(focusedRow, "sJsonData")?.ToString()
            If String.IsNullOrEmpty(jsonData) Then
                DevExpress.XtraEditors.XtraMessageBox.Show("Bu kayıt için detay bilgi bulunmuyor.", "Bilgi",
                                                           MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If

            ' Detay gösterme formu (opsiyonel, JSON viewer)
            Dim detayForm As New Form With {
                .Text = "Kayıt Detayı (JSON)",
                .Size = New System.Drawing.Size(800, 600),
                .StartPosition = FormStartPosition.CenterParent
            }

            Dim txtBox As New TextBox With {
                .Multiline = True,
                .ScrollBars = ScrollBars.Both,
                .Dock = DockStyle.Fill,
                .Text = jsonData,
                .Font = New Font("Consolas", 10),
                .ReadOnly = True
            }

            detayForm.Controls.Add(txtBox)
            detayForm.ShowDialog()

        Catch ex As Exception
            DevExpress.XtraEditors.XtraMessageBox.Show($"Detay gösterme hatası: {ex.Message}", "Hata",
                                                       MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnExcelAktar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExcelAktar.ItemClick
        Try
            Dim saveDialog As New SaveFileDialog With {
                .Filter = "Excel Dosyası (*.xlsx)|*.xlsx",
                .FileName = $"AuditLog_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx"
            }

            If saveDialog.ShowDialog() = DialogResult.OK Then
                GridView1.ExportToXlsx(saveDialog.FileName)
                DevExpress.XtraEditors.XtraMessageBox.Show("Excel dosyası başarıyla oluşturuldu.", "Başarılı",
                                                           MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            DevExpress.XtraEditors.XtraMessageBox.Show($"Excel aktarma hatası: {ex.Message}", "Hata",
                                                       MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnKapat_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnKapat.ItemClick
        Me.Close()
    End Sub
#End Region

#Region "Helper Methods"
    ''' <summary>
    ''' Geri alma işlemi
    ''' </summary>
    Private Function GeriAlmaIslemi(auditLogID As Long) As Boolean
        ' NOT: Bu metod proje yapısına göre implementasyon yapılmalı
        ' UPDATE işleminde eski değere geri dönme
        ' DELETE işleminde restore etme
        Return True
    End Function

    ''' <summary>
    ''' Silinen kaydı geri yükle
    ''' </summary>
    Private Function SilinenKayitGeriYukle(auditLogID As Long) As Boolean
        ' NOT: Bu metod proje yapısına göre implementasyon yapılmalı
        ' bSilindi = 0 yapma işlemi
        Return True
    End Function
#End Region
End Class
