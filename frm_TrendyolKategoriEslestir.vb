' ============================================================================
' TRENDYOL KATEGORİ EŞLEŞTİRME FORMU - TOPLU İŞLEM
' ============================================================================
' bWebGoruntule=True olan ürünleri listeler ve kategorilerini eşleştirir
' ============================================================================

Imports System.Collections.Generic
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Data.OleDb
Imports System.Threading
Imports System.Threading.Tasks
Imports System.Linq

Public Class frm_TrendyolKategoriEslestir
    Inherits Form
    
    Private connection As String = KeyCode.sConnection
    Private islemDurduruldu As Boolean = False
    
    Private WithEvents dgvUrunler As DataGridView
    Private WithEvents btnListeYukle As Button
    Private WithEvents btnTumunuSec As Button
    Private WithEvents btnSecilenleriEsle As Button
    Private WithEvents btnTumunuEsle As Button
    Private WithEvents btnDurdur As Button
    Private WithEvents btnSiniflariSil As Button
    Private WithEvents btnKategoriKontrol As Button  ' YENİ: Kategori tutarsızlık kontrolü
    Private WithEvents lstLog As ListBox
    Private WithEvents progressBar As ProgressBar
    Private WithEvents lblDurum As Label
    Private WithEvents lblToplamUrun As Label
    Private WithEvents chkSadeceBosKategoriler As CheckBox
    
    ' Eşleştirme kaynağı checkbox'ları
    Private WithEvents chkTrendyol As CheckBox
    Private WithEvents chkVeritabani As CheckBox
    Private WithEvents chkExcel As CheckBox
    Private WithEvents btnExcelSec As Button
    Private _excelDosyaYolu As String = ""
    
    ' Excel matcher instance
    Private _excelMatcher As TrendyolExcelMatcher = Nothing
    
    ' Selenium scraper instance (tüm işlem boyunca açık kalır)
    Private _seleniumScraper As TrendyolSeleniumScraperService = Nothing
    
    ' Arka plan işlemi için
    Private _islemCts As CancellationTokenSource = Nothing
    
    Public Sub New()
        InitializeComponent()
    End Sub
    
    ''' <summary>
    ''' Form açıldığında öne getir
    ''' </summary>
    Private Sub Form_Shown(sender As Object, e As EventArgs)
        ' Normal durumda aç (minimize değil)
        Me.WindowState = FormWindowState.Normal
        Me.ShowInTaskbar = True
        
        ' Öne getir
        Me.TopMost = True
        Me.Activate()
        Me.BringToFront()
        Me.Focus()
        Me.TopMost = False  ' Kalıcı üstte kalmasın
    End Sub
    
    ''' <summary>
    ''' UI thread-safe güncelleme
    ''' </summary>
    Private Sub SafeUpdateUI(action As Action)
        If Me.InvokeRequired Then
            Me.Invoke(action)
        Else
            action()
        End If
    End Sub
    
    Private Sub InitializeComponent()
        Me.Text = "Trendyol Kategori Eşleştirme - Toplu İşlem"
        Me.Size = New Size(1100, 750)
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Icon = SystemIcons.Application
        Me.TopMost = False
        
        ' Form açıldığında öne gelmesi için event handler
        AddHandler Me.Shown, AddressOf Form_Shown
        
        Dim yPos As Integer = 20
        
        ' Başlık
        Dim lblBaslik As New Label With {
            .Text = "TRENDYOL KATEGORİ EŞLEŞTİRME - TOPLU İŞLEM",
            .Font = New Font("Segoe UI", 14, FontStyle.Bold),
            .Location = New Point(20, yPos),
            .Size = New Size(1050, 35),
            .ForeColor = Color.FromArgb(255, 87, 34)
        }
        Me.Controls.Add(lblBaslik)
        yPos += 40
        
        ' Açıklama
        Dim lblAciklama As New Label With {
            .Text = "bWebGoruntule=True olan ürünleri listeler ve Trendyol'dan kategorilerini çeker. BuyBox için aynı kategorileri kullanmanız gerekir.",
            .Font = New Font("Segoe UI", 9),
            .Location = New Point(20, yPos),
            .Size = New Size(1050, 25),
            .ForeColor = Color.Gray
        }
        Me.Controls.Add(lblAciklama)
        yPos += 30
        
        ' ===== BUTONLAR =====
        btnListeYukle = New Button With {
            .Text = "📋 Ürün Listesi Yükle",
            .Location = New Point(20, yPos),
            .Size = New Size(150, 40),
            .BackColor = Color.FromArgb(33, 150, 243),
            .ForeColor = Color.White,
            .Font = New Font("Segoe UI", 9, FontStyle.Bold),
            .FlatStyle = FlatStyle.Flat
        }
        Me.Controls.Add(btnListeYukle)
        
        btnTumunuSec = New Button With {
            .Text = "☑ Tümünü Seç",
            .Location = New Point(180, yPos),
            .Size = New Size(120, 40),
            .BackColor = Color.FromArgb(156, 39, 176),
            .ForeColor = Color.White,
            .Font = New Font("Segoe UI", 9, FontStyle.Bold),
            .FlatStyle = FlatStyle.Flat,
            .Enabled = True
        }
        Me.Controls.Add(btnTumunuSec)
        
        btnSecilenleriEsle = New Button With {
            .Text = "✓ Seçilenleri Eşle",
            .Location = New Point(310, yPos),
            .Size = New Size(140, 40),
            .BackColor = Color.FromArgb(76, 175, 80),
            .ForeColor = Color.White,
            .Font = New Font("Segoe UI", 9, FontStyle.Bold),
            .FlatStyle = FlatStyle.Flat,
            .Enabled = True
        }
        Me.Controls.Add(btnSecilenleriEsle)
        
        btnTumunuEsle = New Button With {
            .Text = "✓✓ Tümünü Eşle",
            .Location = New Point(460, yPos),
            .Size = New Size(140, 40),
            .BackColor = Color.FromArgb(255, 152, 0),
            .ForeColor = Color.White,
            .Font = New Font("Segoe UI", 9, FontStyle.Bold),
            .FlatStyle = FlatStyle.Flat,
            .Enabled = True  ' Liste boş olsa bile tıklanabilir (otomatik yükler)
        }
        Me.Controls.Add(btnTumunuEsle)
        
        btnDurdur = New Button With {
            .Text = "⏸ Durdur",
            .Location = New Point(610, yPos),
            .Size = New Size(100, 40),
            .BackColor = Color.Red,
            .ForeColor = Color.White,
            .Font = New Font("Segoe UI", 9, FontStyle.Bold),
            .FlatStyle = FlatStyle.Flat,
            .Enabled = False
        }
        Me.Controls.Add(btnDurdur)
        
        ' Checkbox - Sadece boş kategoriler (solda)
        chkSadeceBosKategoriler = New CheckBox With {
            .Text = "Sadece kategorisi boş olanlar",
            .Location = New Point(720, yPos + 10),
            .Size = New Size(220, 25),
            .Checked = True,
            .Font = New Font("Segoe UI", 9)
        }
        Me.Controls.Add(chkSadeceBosKategoriler)
        
        ' Tüm Sınıfları Sil butonu (üstte)
        btnSiniflariSil = New Button With {
            .Text = "🗑 Tüm Sınıfları Sil",
            .Location = New Point(940, yPos),
            .Size = New Size(140, 40),
            .BackColor = Color.DarkOrange,
            .ForeColor = Color.White,
            .Font = New Font("Segoe UI", 9, FontStyle.Bold),
            .FlatStyle = FlatStyle.Flat
        }
        Me.Controls.Add(btnSiniflariSil)
        
        yPos += 45  ' Bir sonraki satıra geç
        
        ' Kategori Tutarsızlık Kontrol Butonu (altta, aynı X pozisyonunda)
        btnKategoriKontrol = New Button With {
            .Text = "🔍 Yanlış Kategorileri Bul",
            .Location = New Point(940, yPos - 45 + 45),
            .Size = New Size(140, 40),
            .BackColor = Color.Purple,
            .ForeColor = Color.White,
            .Font = New Font("Segoe UI", 9, FontStyle.Bold),
            .FlatStyle = FlatStyle.Flat
        }
        Me.Controls.Add(btnKategoriKontrol)
        
        yPos -= 45  ' yPos'u geri al, sonraki bileşenler için
        
        yPos += 50
        
        ' ===== EŞLEŞTİRME KAYNAĞI CHECKBOX'LARI =====
        Dim lblKaynak As New Label With {
            .Text = "Eşleştirme Kaynağı:",
            .Location = New Point(20, yPos),
            .Size = New Size(130, 25),
            .Font = New Font("Segoe UI", 9, FontStyle.Bold)
        }
        Me.Controls.Add(lblKaynak)
        
        chkVeritabani = New CheckBox With {
            .Text = "Veritabanı",
            .Location = New Point(160, yPos),
            .Size = New Size(100, 25),
            .Checked = True,
            .Font = New Font("Segoe UI", 9)
        }
        Me.Controls.Add(chkVeritabani)
        
        chkTrendyol = New CheckBox With {
            .Text = "Trendyol",
            .Location = New Point(270, yPos),
            .Size = New Size(90, 25),
            .Checked = True,
            .Font = New Font("Segoe UI", 9)
        }
        Me.Controls.Add(chkTrendyol)
        
        chkExcel = New CheckBox With {
            .Text = "Excel",
            .Location = New Point(370, yPos),
            .Size = New Size(70, 25),
            .Checked = False,
            .Font = New Font("Segoe UI", 9)
        }
        Me.Controls.Add(chkExcel)
        
        btnExcelSec = New Button With {
            .Text = "📁 Excel Seç",
            .Location = New Point(450, yPos - 3),
            .Size = New Size(100, 28),
            .BackColor = Color.FromArgb(76, 175, 80),
            .ForeColor = Color.White,
            .Font = New Font("Segoe UI", 8, FontStyle.Bold),
            .FlatStyle = FlatStyle.Flat,
            .Enabled = False
        }
        Me.Controls.Add(btnExcelSec)
        
        yPos += 35
        
        ' ===== DURUM BİLGİSİ =====
        lblToplamUrun = New Label With {
            .Text = "Toplam Ürün: 0 | Seçili: 0",
            .Location = New Point(20, yPos),
            .Size = New Size(400, 25),
            .Font = New Font("Segoe UI", 10, FontStyle.Bold),
            .ForeColor = Color.FromArgb(33, 150, 243)
        }
        Me.Controls.Add(lblToplamUrun)
        
        lblDurum = New Label With {
            .Text = "Hazır",
            .Location = New Point(440, yPos),
            .Size = New Size(630, 25),
            .Font = New Font("Segoe UI", 9),
            .ForeColor = Color.Green
        }
        Me.Controls.Add(lblDurum)
        yPos += 30
        
        ' ===== DATAGRIDVIEW (ÜRÜN LİSTESİ) =====
        dgvUrunler = New DataGridView With {
            .Location = New Point(20, yPos),
            .Size = New Size(1050, 300),
            .AllowUserToAddRows = False,
            .AllowUserToDeleteRows = False,
            .ReadOnly = False,
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect,
            .MultiSelect = True,
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
            .RowHeadersVisible = True,
            .BackgroundColor = Color.White,
            .BorderStyle = BorderStyle.Fixed3D
        }
        
        ' Checkbox sütunu ekle (seçim için)
        Dim chkCol As New DataGridViewCheckBoxColumn With {
            .HeaderText = "Seç",
            .Name = "colSec",
            .Width = 50,
            .ReadOnly = False
        }
        dgvUrunler.Columns.Add(chkCol)
        
        ' Diğer sütunlar
        dgvUrunler.Columns.Add("colModel", "Model")
        dgvUrunler.Columns.Add("colRenk", "Renk")
        dgvUrunler.Columns.Add("colBarkod", "Barkod")
        dgvUrunler.Columns.Add("colUrunAdi", "Ürün Adı")
        dgvUrunler.Columns.Add("colMarka", "Marka")
        dgvUrunler.Columns.Add("colKategori", "Mevcut Kategori")
        dgvUrunler.Columns.Add("colDurum", "Durum")
        
        Me.Controls.Add(dgvUrunler)
        yPos += 310
        
        ' ===== PROGRESS BAR =====
        progressBar = New ProgressBar With {
            .Location = New Point(20, yPos),
            .Size = New Size(1050, 25),
            .Style = ProgressBarStyle.Continuous
        }
        Me.Controls.Add(progressBar)
        yPos += 30
        
        ' ===== LOG LISTBOX =====
        Dim lblLog As New Label With {
            .Text = "İşlem Logları:",
            .Location = New Point(20, yPos),
            .Size = New Size(200, 20),
            .Font = New Font("Segoe UI", 9, FontStyle.Bold)
        }
        Me.Controls.Add(lblLog)
        yPos += 25
        
        lstLog = New ListBox With {
            .Location = New Point(20, yPos),
            .Size = New Size(1050, 180),
            .Font = New Font("Consolas", 8),
            .BackColor = Color.FromArgb(250, 250, 250)
        }
        Me.Controls.Add(lstLog)
    End Sub
    
    ' ========================================================================
    ' YENİ TOPLU İŞLEM EVENT HANDLER'LARI
    ' ========================================================================
    
    ''' <summary>
    ''' Ürün listesini DataGridView'e yükler
    ''' </summary>
    Private Sub btnListeYukle_Click(sender As Object, e As EventArgs) Handles btnListeYukle.Click
        Try
            ' frm_market.vb örneğine göre frm_stok_liste_fiyat formu açılır
            Dim frm As New frm_stok_liste_fiyat
            frm.islemstatus = True
            frm.market = True
            frm.eticaret = True  ' Sadece bWebGoruntule=1 olanları getir
            frm.connection = connection
            frm.firmano = KeyCode.firmano
            frm.donemno = KeyCode.donemno
            frm.kullanici = KeyCode.kullanici
            
            AddLog("📋 Stok listesi açılıyor...")
            UpdateStatus("Stok listesinden ürün seçin...", Color.Orange)
            
            If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                Dim s As String
                Dim arr As Integer()
                Dim i As Integer
                Dim dr1 As DataRow
                
                arr = frm.GridView1.GetSelectedRows()
                If arr Is Nothing OrElse arr.Length = 0 Then
                    AddLog("⚠️ Ürün seçilmedi")
                    UpdateStatus("Ürün seçilmedi", Color.Orange)
                Else
                    Array.Sort(arr)
                    dgvUrunler.Rows.Clear()
                    Dim yuklenenSayi As Integer = 0
                    
                    For Each i In arr
                        s = i.ToString
                        dr1 = frm.GridView1.GetDataRow(s)
                        
                        ' Verileri al
                        Dim sModel As String = If(IsDBNull(dr1("sModel")), "", dr1("sModel").ToString().Trim())
                        Dim sRenk As String = If(IsDBNull(dr1("sRenk")), "", dr1("sRenk").ToString().Trim())
                        Dim sBarkod As String = If(IsDBNull(dr1("sBarkod")), "", dr1("sBarkod").ToString().Trim())
                        Dim sAciklama As String = If(IsDBNull(dr1("sAciklama")), "", dr1("sAciklama").ToString().Trim())
                        
                        ' MARKA: Sınıf eşleştirmesine göre al
                        Dim sMarka As String = ""
                        Dim markaField As String = GetSinifEslemeAyar("ETICARET_SINIF_MARKA", "sSinifKodu3")
                        Try
                            ' Sınıf alanından marka al
                            If markaField.StartsWith("sSinifKodu") Then
                                Dim sinifNo As String = markaField.Replace("sSinifKodu", "")
                                Dim sinifFieldName As String = $"Sinif{sinifNo}"
                                If dr1.Table.Columns.Contains(sinifFieldName) Then
                                    sMarka = If(IsDBNull(dr1(sinifFieldName)), "", dr1(sinifFieldName).ToString().Trim())
                                End If
                            ElseIf markaField = "sModel" Then
                                sMarka = sModel
                            End If
                        Catch
                        End Try
                        
                        ' Marka bulunamadıysa ürün adının ilk kelimesini dene
                        If String.IsNullOrWhiteSpace(sMarka) AndAlso Not String.IsNullOrWhiteSpace(sAciklama) Then
                            Dim kelimeler() As String = sAciklama.Trim().Split(New Char() {" "c}, StringSplitOptions.RemoveEmptyEntries)
                            If kelimeler.Length > 0 Then
                                sMarka = kelimeler(0)
                            End If
                        End If
                        
                        ' Mevcut kategoriyi al (Sınıf eşleştirmesine göre)
                        Dim mevcutKat As String = ""
                        Dim katField As String = GetSinifEslemeAyar("ETICARET_SINIF_KAT1", "sSinifKodu4")
                        Try
                            If katField.StartsWith("sSinifKodu") Then
                                Dim sinifNo As String = katField.Replace("sSinifKodu", "")
                                Dim sinifFieldName As String = $"Sinif{sinifNo}"
                                If dr1.Table.Columns.Contains(sinifFieldName) Then
                                    mevcutKat = If(IsDBNull(dr1(sinifFieldName)), "", dr1(sinifFieldName).ToString().Trim())
                                End If
                            ElseIf katField.StartsWith("sGrup") Then
                                If dr1.Table.Columns.Contains(katField) Then
                                    mevcutKat = If(IsDBNull(dr1(katField)), "", dr1(katField).ToString().Trim())
                                End If
                            End If
                        Catch
                            mevcutKat = ""
                        End Try
                        
                        ' DataGridView'e ekle
                        dgvUrunler.Rows.Add(
                            False,  ' Checkbox
                            sModel,
                            sRenk,
                            sBarkod,
                            sAciklama,
                            sMarka,
                            If(String.IsNullOrEmpty(mevcutKat), "(Boş)", mevcutKat),
                            "Bekliyor"
                        )
                        
                        yuklenenSayi += 1
                    Next
                    
                    lblToplamUrun.Text = $"Toplam Ürün: {yuklenenSayi} | Seçili: 0"
                    AddLog($"✅ {yuklenenSayi} ürün yüklendi")
                    UpdateStatus($"{yuklenenSayi} ürün yüklendi - Seçim yapın", Color.Green)
                    
                    ' Butonları aktif et
                    If yuklenenSayi > 0 Then
                        btnTumunuSec.Enabled = True
                        btnSecilenleriEsle.Enabled = True
                        btnTumunuEsle.Enabled = True
                    End If
                End If
                
                frm.Close()
                frm.Dispose()
                frm = Nothing
            Else
                AddLog("⚠️ İptal edildi")
                UpdateStatus("İptal edildi", Color.Gray)
            End If
            
        Catch ex As Exception
            AddLog($"❌ HATA: {ex.Message}")
            UpdateStatus($"Hata: {ex.Message}", Color.Red)
            MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            btnListeYukle.Enabled = True
        End Try
    End Sub
    
    ''' <summary>
    ''' Tümünü Seç butonu - tüm checkboxları işaretler/kaldırır
    ''' </summary>
    Private Sub btnTumunuSec_Click(sender As Object, e As EventArgs) Handles btnTumunuSec.Click
        Try
            If dgvUrunler.Rows.Count = 0 Then Return
            
            ' İlk satırın durumuna göre toggle yap
            Dim ilkDeger As Boolean = False
            If dgvUrunler.Rows(0).Cells("colSec").Value IsNot Nothing Then
                ilkDeger = CBool(dgvUrunler.Rows(0).Cells("colSec").Value)
            End If
            
            Dim yeniDeger As Boolean = Not ilkDeger
            
            For i As Integer = 0 To dgvUrunler.Rows.Count - 1
                dgvUrunler.Rows(i).Cells("colSec").Value = yeniDeger
            Next
            
            ' Buton metnini güncelle
            If yeniDeger Then
                btnTumunuSec.Text = "☐ Seçimi Kaldır"
                AddLog($"✅ {dgvUrunler.Rows.Count} ürün seçildi")
            Else
                btnTumunuSec.Text = "☑ Tümünü Seç"
                AddLog("Seçim kaldırıldı")
            End If
            
            UpdateSeciliUrunSayisi()
            
        Catch ex As Exception
            AddLog($"❌ HATA: {ex.Message}")
        End Try
    End Sub
    
    ''' <summary>
    ''' Excel checkbox değiştiğinde Excel Seç butonunu aktif/pasif yap
    ''' </summary>
    Private Sub chkExcel_CheckedChanged(sender As Object, e As EventArgs) Handles chkExcel.CheckedChanged
        btnExcelSec.Enabled = chkExcel.Checked
        If Not chkExcel.Checked Then
            _excelDosyaYolu = ""
        End If
    End Sub
    
    ''' <summary>
    ''' Excel dosyası seçme - Sütun eşleştirme ile
    ''' </summary>
    Private Sub btnExcelSec_Click(sender As Object, e As EventArgs) Handles btnExcelSec.Click
        Using ofd As New OpenFileDialog()
            ofd.Title = "Excel Dosyası Seç"
            ofd.Filter = "Excel Dosyaları|*.xlsx;*.xls|Tüm Dosyalar|*.*"
            ofd.FilterIndex = 1
            
            If ofd.ShowDialog() <> DialogResult.OK Then Exit Sub
            
            _excelDosyaYolu = ofd.FileName
            
            Try
                ' NPOI ile Excel'i oku
                Dim workbook As NPOI.SS.UserModel.IWorkbook
                Using fs As New IO.FileStream(_excelDosyaYolu, IO.FileMode.Open, IO.FileAccess.Read, IO.FileShare.ReadWrite)
                    If IO.Path.GetExtension(_excelDosyaYolu).ToLower() = ".xlsx" Then
                        workbook = New NPOI.XSSF.UserModel.XSSFWorkbook(fs)
                    Else
                        workbook = New NPOI.HSSF.UserModel.HSSFWorkbook(fs)
                    End If
                End Using
                
                Dim sheet As NPOI.SS.UserModel.ISheet = workbook.GetSheetAt(0)
                Dim headerRow As NPOI.SS.UserModel.IRow = sheet.GetRow(0)
                
                If headerRow Is Nothing Then
                    MessageBox.Show("Excel dosyasında başlık satırı bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                
                Dim colCount As Integer = headerRow.LastCellNum
                Dim rowCount As Integer = sheet.LastRowNum + 1
                
                ' Sütun başlıklarını oku
                Dim sutunlar As New List(Of String)()
                For i As Integer = 0 To colCount - 1
                    Dim cell As NPOI.SS.UserModel.ICell = headerRow.GetCell(i)
                    Dim colName As String = If(cell IsNot Nothing, GetNPOICellValue(cell).Trim(), "(Boş)")
                    sutunlar.Add(colName)
                Next
                
                ' Önizleme verisi oluştur (ilk 10 satır)
                Dim previewRowCount As Integer = Math.Min(rowCount, 11)
                Dim previewData As New DataTable()
                
                ' Sütunları ekle
                For Each col As String In sutunlar
                    previewData.Columns.Add(col)
                Next
                
                ' Veri satırlarını ekle
                For rowIdx As Integer = 1 To previewRowCount - 1
                    Dim row As NPOI.SS.UserModel.IRow = sheet.GetRow(rowIdx)
                    If row Is Nothing Then Continue For
                    
                    Dim newRow As DataRow = previewData.NewRow()
                    For colIdx As Integer = 0 To colCount - 1
                        Dim cell As NPOI.SS.UserModel.ICell = row.GetCell(colIdx)
                        newRow(colIdx) = If(cell IsNot Nothing, GetNPOICellValue(cell), "")
                    Next
                    previewData.Rows.Add(newRow)
                Next
                
                workbook.Close()
                
                ' Seçilen sütunları takip et
                Dim selectedBarkodCol As Integer = -1
                Dim selectedModelKoduCol As Integer = -1
                Dim selectedMarkaCol As Integer = -1  ' YENİ: Marka sütunu
                Dim selectedKategoriCols As New List(Of Integer)()
                
                ' ===== SÜTUN EŞLEŞTİRME FORMU =====
                Dim eslestirmeForm As New Form()
                eslestirmeForm.Text = "Excel Sütun Eşleştirme - Kategori Eşleştirme"
                eslestirmeForm.Size = New Size(1000, 700)
                eslestirmeForm.StartPosition = FormStartPosition.CenterScreen
                eslestirmeForm.FormBorderStyle = FormBorderStyle.Sizable
                eslestirmeForm.MaximizeBox = True
                eslestirmeForm.MinimizeBox = False
                
                ' Bilgi etiketi
                Dim lblInfo As New Label()
                lblInfo.Text = "Sütun başlıklarına tıklayarak seçim yapın:" & vbCrLf & 
                               "• Sol tık = Barkod sütunu (yeşil)" & vbCrLf & 
                               "• Sağ tık = Model Kodu sütunu (turuncu)" & vbCrLf &
                               "• Shift + Sol tık = Marka sütunu (mor)" & vbCrLf &
                               "• Orta tık (tekerlek) = Kategori sütunu ekle (mavi) - sırayla eklenir"
                lblInfo.Location = New Point(20, 10)
                lblInfo.AutoSize = True
                lblInfo.Font = New Font(lblInfo.Font, FontStyle.Bold)
                eslestirmeForm.Controls.Add(lblInfo)
                
                ' Sabit Ana Kategori paneli
                Dim pnlSabitKategori As New Panel()
                pnlSabitKategori.Location = New Point(500, 10)
                pnlSabitKategori.Size = New Size(470, 55)
                pnlSabitKategori.BorderStyle = BorderStyle.FixedSingle
                eslestirmeForm.Controls.Add(pnlSabitKategori)
                
                ' Checkbox - varsayılan FALSE
                Dim chkSabitKategori As New CheckBox()
                chkSabitKategori.Text = "Sabit Ana Kategori Ekle:"
                chkSabitKategori.Location = New Point(10, 5)
                chkSabitKategori.AutoSize = True
                chkSabitKategori.Checked = False  ' VARSAYILAN: KAPALI
                pnlSabitKategori.Controls.Add(chkSabitKategori)
                
                Dim txtSabitKategori As New TextBox()
                txtSabitKategori.Location = New Point(180, 3)
                txtSabitKategori.Size = New Size(100, 23)
                txtSabitKategori.Text = "Giyim"
                txtSabitKategori.Enabled = False  ' Başlangıçta devre dışı
                pnlSabitKategori.Controls.Add(txtSabitKategori)
                
                Dim lblSabitAciklama As New Label()
                lblSabitAciklama.Text = "Örn: Giyim → Cinsiyet → Kategori İsmi"
                lblSabitAciklama.Location = New Point(10, 30)
                lblSabitAciklama.AutoSize = True
                lblSabitAciklama.ForeColor = Color.Gray
                pnlSabitKategori.Controls.Add(lblSabitAciklama)
                
                ' Seçim durumu etiketi
                Dim lblSecim As New Label()
                lblSecim.Location = New Point(20, 80)
                lblSecim.AutoSize = True
                lblSecim.Text = "Barkod: (seçilmedi) | Model Kodu: (seçilmedi) | Marka: (seçilmedi)"
                eslestirmeForm.Controls.Add(lblSecim)
                
                ' Kategori sırası etiketi
                Dim lblKategoriSirasi As New Label()
                lblKategoriSirasi.Location = New Point(20, 98)
                lblKategoriSirasi.AutoSize = True
                lblKategoriSirasi.Text = "Kategori Sırası: (henüz seçilmedi)"
                lblKategoriSirasi.ForeColor = Color.Blue
                eslestirmeForm.Controls.Add(lblKategoriSirasi)
                
                ' DataGridView
                Dim dgvPreview As New DataGridView()
                dgvPreview.Location = New Point(20, 120)
                dgvPreview.Size = New Size(945, 425)
                dgvPreview.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
                dgvPreview.DataSource = previewData
                dgvPreview.ReadOnly = True
                dgvPreview.AllowUserToAddRows = False
                dgvPreview.AllowUserToDeleteRows = False
                dgvPreview.MultiSelect = False
                dgvPreview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                dgvPreview.ColumnHeadersDefaultCellStyle.Font = New Font(dgvPreview.Font, FontStyle.Bold)
                eslestirmeForm.Controls.Add(dgvPreview)
                
                ' Sütun renklerini ve sıraları güncelleme fonksiyonu
                Dim updateColumnColors As Action = Sub()
                    For i As Integer = 0 To dgvPreview.Columns.Count - 1
                        dgvPreview.Columns(i).SortMode = DataGridViewColumnSortMode.NotSortable
                        
                        If i = selectedBarkodCol Then
                            dgvPreview.Columns(i).HeaderCell.Style.BackColor = Color.LightGreen
                            dgvPreview.Columns(i).DefaultCellStyle.BackColor = Color.Honeydew
                        ElseIf i = selectedModelKoduCol Then
                            dgvPreview.Columns(i).HeaderCell.Style.BackColor = Color.Orange
                            dgvPreview.Columns(i).DefaultCellStyle.BackColor = Color.LemonChiffon
                        ElseIf i = selectedMarkaCol Then
                            dgvPreview.Columns(i).HeaderCell.Style.BackColor = Color.MediumPurple
                            dgvPreview.Columns(i).DefaultCellStyle.BackColor = Color.Lavender
                        ElseIf selectedKategoriCols.Contains(i) Then
                            dgvPreview.Columns(i).HeaderCell.Style.BackColor = Color.LightBlue
                            dgvPreview.Columns(i).DefaultCellStyle.BackColor = Color.AliceBlue
                            ' Sıra numarasını başlığa ekle
                            Dim sira As Integer = selectedKategoriCols.IndexOf(i) + 1
                            dgvPreview.Columns(i).HeaderText = $"[{sira}] {sutunlar(i)}"
                        Else
                            dgvPreview.Columns(i).HeaderCell.Style.BackColor = SystemColors.Control
                            dgvPreview.Columns(i).DefaultCellStyle.BackColor = Color.White
                            dgvPreview.Columns(i).HeaderText = sutunlar(i)
                        End If
                    Next
                    dgvPreview.Refresh()
                    
                    ' Seçim etiketini güncelle
                    Dim barkodText As String = If(selectedBarkodCol >= 0, sutunlar(selectedBarkodCol), "(seçilmedi)")
                    Dim modelText As String = If(selectedModelKoduCol >= 0, sutunlar(selectedModelKoduCol), "(seçilmedi)")
                    Dim markaText As String = If(selectedMarkaCol >= 0, sutunlar(selectedMarkaCol), "(seçilmedi)")
                    lblSecim.Text = $"Barkod: {barkodText} | Model Kodu: {modelText} | Marka: {markaText}"
                    
                    ' Kategori sırası etiketini güncelle
                    If selectedKategoriCols.Count > 0 Then
                        Dim kategoriListesi As New List(Of String)()
                        Dim sabitKat As String = ""
                        
                        ' SADECE checkbox işaretliyse sabit kategori kullan
                        If chkSabitKategori.Checked AndAlso Not String.IsNullOrEmpty(txtSabitKategori.Text.Trim()) Then
                            sabitKat = txtSabitKategori.Text.Trim()
                        End If
                        
                        ' Sabit kategori kontrolü - seçilen kategori sütunlarında var mı?
                        Dim sabitKatVarMi As Boolean = False
                        If Not String.IsNullOrEmpty(sabitKat) Then
                            For Each idx As Integer In selectedKategoriCols
                                If sutunlar(idx).Trim().ToLowerInvariant() = sabitKat.ToLowerInvariant() Then
                                    sabitKatVarMi = True
                                    Exit For
                                End If
                            Next
                            
                            If Not sabitKatVarMi Then
                                kategoriListesi.Add($"[Sabit] {sabitKat}")
                            End If
                        End If
                        
                        For Each idx As Integer In selectedKategoriCols
                            kategoriListesi.Add(sutunlar(idx))
                        Next
                        lblKategoriSirasi.Text = "Kategori Sırası: " & String.Join(" → ", kategoriListesi)
                        
                        If sabitKatVarMi Then
                            lblKategoriSirasi.Text &= " (Sabit kategori zaten mevcut, eklenmeyecek)"
                        End If
                    Else
                        lblKategoriSirasi.Text = "Kategori Sırası: (henüz seçilmedi)"
                    End If
                End Sub
                
                ' Sabit kategori değiştiğinde güncelle
                AddHandler txtSabitKategori.TextChanged, Sub()
                    updateColumnColors()
                End Sub
                
                ' Checkbox değiştiğinde de güncelle
                AddHandler chkSabitKategori.CheckedChanged, Sub()
                    txtSabitKategori.Enabled = chkSabitKategori.Checked
                    updateColumnColors()
                End Sub
                
                ' Otomatik seçim yap - Trendyol formatı için Cinsiyet'i de algıla
                For i As Integer = 0 To sutunlar.Count - 1
                    Dim headerLower As String = sutunlar(i).ToLowerInvariant().Replace("_", "").Replace(" ", "")
                    headerLower = headerLower.Replace("ı", "i").Replace("ğ", "g").Replace("ü", "u").Replace("ş", "s").Replace("ö", "o").Replace("ç", "c")
                    
                    ' Barkod sütunu
                    If selectedBarkodCol < 0 AndAlso headerLower.Contains("barkod") Then
                        selectedBarkodCol = i
                    End If
                    
                    ' Model kodu / Ürün kodu sütunu
                    If selectedModelKoduCol < 0 AndAlso (headerLower.Contains("modelkodu") OrElse headerLower.Contains("urunkodu") OrElse headerLower.Contains("stokkodu")) Then
                        selectedModelKoduCol = i
                    End If
                    
                    ' Marka sütunu - YENİ
                    If selectedMarkaCol < 0 AndAlso headerLower.Contains("marka") Then
                        selectedMarkaCol = i
                    End If
                    
                    ' Cinsiyet sütunu - Trendyol formatı için (önce Cinsiyet sonra Kategori İsmi)
                    If headerLower = "cinsiyet" Then
                        If Not selectedKategoriCols.Contains(i) Then
                            selectedKategoriCols.Add(i)
                        End If
                    End If
                Next
                
                ' Kategori İsmi sütununu en sona ekle
                For i As Integer = 0 To sutunlar.Count - 1
                    Dim headerLower As String = sutunlar(i).ToLowerInvariant().Replace("_", "").Replace(" ", "")
                    headerLower = headerLower.Replace("ı", "i").Replace("ğ", "g").Replace("ü", "u").Replace("ş", "s").Replace("ö", "o").Replace("ç", "c")
                    
                    If headerLower.Contains("kategoriismi") OrElse headerLower.Contains("kategorisi") Then
                        If Not selectedKategoriCols.Contains(i) Then
                            selectedKategoriCols.Add(i)
                        End If
                    ElseIf headerLower.Contains("anakategori") OrElse headerLower.Contains("altkategori") Then
                        If Not selectedKategoriCols.Contains(i) Then
                            selectedKategoriCols.Add(i)
                        End If
                    End If
                Next
                
                ' Başlangıç renklerini uygula
                AddHandler dgvPreview.DataBindingComplete, Sub(s, ev)
                    For i As Integer = 0 To dgvPreview.Columns.Count - 1
                        dgvPreview.Columns(i).SortMode = DataGridViewColumnSortMode.NotSortable
                    Next
                    updateColumnColors()
                End Sub
                
                ' Sütun başlığına tıklama olayı
                AddHandler dgvPreview.ColumnHeaderMouseClick, Sub(s, ev)
                    If ev.Button = MouseButtons.Left AndAlso Control.ModifierKeys = Keys.Shift Then
                        ' Shift + Sol tık: Marka sütunu seç
                        If selectedBarkodCol = ev.ColumnIndex Then selectedBarkodCol = -1
                        If selectedModelKoduCol = ev.ColumnIndex Then selectedModelKoduCol = -1
                        If selectedKategoriCols.Contains(ev.ColumnIndex) Then selectedKategoriCols.Remove(ev.ColumnIndex)
                        selectedMarkaCol = ev.ColumnIndex
                        updateColumnColors()
                        
                    ElseIf ev.Button = MouseButtons.Left Then
                        ' Sol tık: Barkod sütunu seç
                        If selectedModelKoduCol = ev.ColumnIndex Then
                            selectedModelKoduCol = -1
                        End If
                        If selectedMarkaCol = ev.ColumnIndex Then
                            selectedMarkaCol = -1
                        End If
                        If selectedKategoriCols.Contains(ev.ColumnIndex) Then
                            selectedKategoriCols.Remove(ev.ColumnIndex)
                        End If
                        selectedBarkodCol = ev.ColumnIndex
                        updateColumnColors()
                        
                    ElseIf ev.Button = MouseButtons.Right Then
                        ' Sağ tık: Model kodu sütunu seç
                        If selectedBarkodCol = ev.ColumnIndex Then
                            selectedBarkodCol = -1
                        End If
                        If selectedMarkaCol = ev.ColumnIndex Then
                            selectedMarkaCol = -1
                        End If
                        If selectedKategoriCols.Contains(ev.ColumnIndex) Then
                            selectedKategoriCols.Remove(ev.ColumnIndex)
                        End If
                        selectedModelKoduCol = ev.ColumnIndex
                        updateColumnColors()
                        
                    ElseIf ev.Button = MouseButtons.Middle Then
                        ' Orta tık: Kategori sütunu ekle/çıkar
                        If ev.ColumnIndex = selectedBarkodCol OrElse ev.ColumnIndex = selectedModelKoduCol OrElse ev.ColumnIndex = selectedMarkaCol Then
                            MessageBox.Show("Bu sütun zaten Barkod, Model Kodu veya Marka olarak seçili!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Else
                            If selectedKategoriCols.Contains(ev.ColumnIndex) Then
                                selectedKategoriCols.Remove(ev.ColumnIndex)
                            Else
                                selectedKategoriCols.Add(ev.ColumnIndex)
                            End If
                            updateColumnColors()
                        End If
                    End If
                End Sub
                
                ' Temizle butonu
                Dim btnTemizle As New Button()
                btnTemizle.Text = "Seçimleri Temizle"
                btnTemizle.Location = New Point(20, 565)
                btnTemizle.Size = New Size(120, 35)
                btnTemizle.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
                AddHandler btnTemizle.Click, Sub()
                    selectedBarkodCol = -1
                    selectedModelKoduCol = -1
                    selectedMarkaCol = -1
                    selectedKategoriCols.Clear()
                    updateColumnColors()
                End Sub
                eslestirmeForm.Controls.Add(btnTemizle)
                
                ' Tüm Kategorileri Seç butonu
                Dim btnTumKategori As New Button()
                btnTumKategori.Text = "Tüm Kategorileri Seç"
                btnTumKategori.Location = New Point(150, 565)
                btnTumKategori.Size = New Size(140, 35)
                btnTumKategori.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
                AddHandler btnTumKategori.Click, Sub()
                    For i As Integer = 0 To sutunlar.Count - 1
                        Dim headerLower As String = sutunlar(i).ToLowerInvariant().Replace("_", "").Replace(" ", "")
                        headerLower = headerLower.Replace("ı", "i").Replace("ğ", "g").Replace("ü", "u").Replace("ş", "s").Replace("ö", "o").Replace("ç", "c")
                        
                        If i <> selectedBarkodCol AndAlso i <> selectedModelKoduCol AndAlso
                           (headerLower.Contains("kategori") OrElse headerLower.Contains("alt")) Then
                            If Not selectedKategoriCols.Contains(i) Then
                                selectedKategoriCols.Add(i)
                            End If
                        End If
                    Next
                    updateColumnColors()
                End Sub
                eslestirmeForm.Controls.Add(btnTumKategori)
                
                ' Satır sayısı bilgisi
                Dim lblSatir As New Label()
                lblSatir.Text = $"Toplam satır: {rowCount - 1} (önizleme: ilk {previewRowCount - 1} satır)"
                lblSatir.Location = New Point(310, 575)
                lblSatir.AutoSize = True
                lblSatir.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
                eslestirmeForm.Controls.Add(lblSatir)
                
                ' Kullanım bilgisi
                Dim lblKullanim As New Label()
                lblKullanim.Text = "İpucu: Kategori için orta tık (tekerlek), Marka için Shift + Sol tık"
                lblKullanim.Location = New Point(20, 610)
                lblKullanim.AutoSize = True
                lblKullanim.ForeColor = Color.Gray
                lblKullanim.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
                eslestirmeForm.Controls.Add(lblKullanim)
                
                ' Başlat ve İptal butonları
                Dim btnBaslat As New Button()
                btnBaslat.Text = "Tamam"
                btnBaslat.Location = New Point(780, 565)
                btnBaslat.Size = New Size(90, 35)
                btnBaslat.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
                btnBaslat.DialogResult = DialogResult.OK
                btnBaslat.BackColor = Color.LightGreen
                eslestirmeForm.Controls.Add(btnBaslat)
                
                Dim btnIptal As New Button()
                btnIptal.Text = "İptal"
                btnIptal.Location = New Point(880, 565)
                btnIptal.Size = New Size(80, 35)
                btnIptal.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
                btnIptal.DialogResult = DialogResult.Cancel
                eslestirmeForm.Controls.Add(btnIptal)
                
                eslestirmeForm.AcceptButton = btnBaslat
                eslestirmeForm.CancelButton = btnIptal
                
                ' Formu göster
                If eslestirmeForm.ShowDialog() <> DialogResult.OK Then
                    _excelDosyaYolu = ""
                    Exit Sub
                End If
                
                ' Seçimleri kontrol et
                If selectedBarkodCol < 0 AndAlso selectedModelKoduCol < 0 Then
                    MessageBox.Show("Lütfen en az Barkod veya Model Kodu sütununu seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    _excelDosyaYolu = ""
                    Exit Sub
                End If
                
                If selectedKategoriCols.Count = 0 Then
                    MessageBox.Show("Lütfen en az bir Kategori sütunu seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    _excelDosyaYolu = ""
                    Exit Sub
                End If
                
                ' Sabit kategori değerini al - SADECE checkbox işaretliyse
                Dim sabitKategori As String = ""
                If chkSabitKategori.Checked Then
                    sabitKategori = txtSabitKategori.Text.Trim()
                End If
                
                ' NOT: Kategori sütunlarını SIRALAMIYORUZ - seçim sırası korunacak
                ' selectedKategoriCols.Sort() KALDIRILDI
                
                ' Seçili kategori sütun isimlerini al
                Dim kategoriSutunIsimleri As New List(Of String)()
                For Each idx As Integer In selectedKategoriCols
                    kategoriSutunIsimleri.Add(sutunlar(idx))
                Next
                
                ' Excel Matcher'ı oluştur - manuel sütun seçimleri, sabit kategori ve marka sütunu ile
                _excelMatcher = New TrendyolExcelMatcher()
                _excelMatcher.DosyaYukleManuel(_excelDosyaYolu, selectedBarkodCol, selectedModelKoduCol, selectedKategoriCols, sabitKategori, selectedMarkaCol, kategoriSutunIsimleri)
                
                If _excelMatcher.KayitSayisi > 0 Then
                    AddLog($"📁 Excel yüklendi: {IO.Path.GetFileName(_excelDosyaYolu)} ({_excelMatcher.KayitSayisi} kayıt)")
                    chkExcel.Text = $"Excel ({_excelMatcher.KayitSayisi})"
                    
                    ' Seçilen sütunları logla
                    AddLog("--- Seçilen Sütunlar ---")
                    If selectedBarkodCol >= 0 Then
                        AddLog($"  Barkod: {sutunlar(selectedBarkodCol)}")
                    End If
                    If selectedModelKoduCol >= 0 Then
                        AddLog($"  Model Kodu: {sutunlar(selectedModelKoduCol)}")
                    End If
                    If selectedMarkaCol >= 0 Then
                        AddLog($"  Marka: {sutunlar(selectedMarkaCol)}")
                    Else
                        AddLog($"  Marka: (seçilmedi - ürün adından çıkarılacak)")
                    End If
                    If Not String.IsNullOrEmpty(sabitKategori) Then
                        ' Koşullu sabit kategori kontrolü
                        Dim sabitZatenVar As Boolean = False
                        For Each katIsim As String In kategoriSutunIsimleri
                            If katIsim.Trim().ToLowerInvariant() = sabitKategori.ToLowerInvariant() Then
                                sabitZatenVar = True
                                Exit For
                            End If
                        Next
                        If sabitZatenVar Then
                            AddLog($"  Sabit Ana Kategori: {sabitKategori} (⚠️ sütunlarda zaten var, eklenmeyecek)")
                        Else
                            AddLog($"  Sabit Ana Kategori: {sabitKategori}")
                        End If
                    End If
                    AddLog($"  Kategori Sütunları (sırasıyla {selectedKategoriCols.Count} adet):")
                    Dim sira As Integer = 1
                    For Each idx As Integer In selectedKategoriCols
                        AddLog($"    {sira}. {sutunlar(idx)}")
                        sira += 1
                    Next
                    AddLog("--- --- ---")
                Else
                    AddLog($"❌ Excel yüklenemedi: {IO.Path.GetFileName(_excelDosyaYolu)}")
                    _excelMatcher = Nothing
                    _excelDosyaYolu = ""
                End If
                
            Catch ex As Exception
                AddLog($"❌ Excel okuma hatası: {ex.Message}")
                MessageBox.Show($"Excel okuma hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
                _excelMatcher = Nothing
                _excelDosyaYolu = ""
            End Try
        End Using
    End Sub
    
    ''' <summary>
    ''' NPOI hücre değerini string olarak alır
    ''' </summary>
    Private Function GetNPOICellValue(cell As NPOI.SS.UserModel.ICell) As String
        If cell Is Nothing Then Return ""
        
        Select Case cell.CellType
            Case NPOI.SS.UserModel.CellType.String
                Return cell.StringCellValue
            Case NPOI.SS.UserModel.CellType.Numeric
                If Math.Floor(cell.NumericCellValue) = cell.NumericCellValue Then
                    Return CLng(cell.NumericCellValue).ToString()
                Else
                    Return cell.NumericCellValue.ToString()
                End If
            Case NPOI.SS.UserModel.CellType.Boolean
                Return cell.BooleanCellValue.ToString()
            Case NPOI.SS.UserModel.CellType.Formula
                Try
                    Return cell.StringCellValue
                Catch
                    Try
                        Return cell.NumericCellValue.ToString()
                    Catch
                        Return ""
                    End Try
                End Try
            Case Else
                Return ""
        End Select
    End Function
    
    ''' <summary>
    ''' Seçili ürünleri eşleştirir
    ''' </summary>
    Private Async Sub btnSecilenleriEsle_Click(sender As Object, e As EventArgs) Handles btnSecilenleriEsle.Click
        ' Seçili satırları bul
        Dim seciliSatirlar As New List(Of Integer)
        
        For i As Integer = 0 To dgvUrunler.Rows.Count - 1
            Dim checkCell As DataGridViewCheckBoxCell = CType(dgvUrunler.Rows(i).Cells("colSec"), DataGridViewCheckBoxCell)
            If checkCell.Value IsNot Nothing AndAlso CBool(checkCell.Value) = True Then
                ' Sadece boş kategoriler checkbox'u kontrolü
                If chkSadeceBosKategoriler.Checked Then
                    Dim mevcutKategori As String = dgvUrunler.Rows(i).Cells("colKategori").Value?.ToString()
                    If String.IsNullOrWhiteSpace(mevcutKategori) Then
                        seciliSatirlar.Add(i)
                    End If
                Else
                    seciliSatirlar.Add(i)
                End If
            End If
        Next
        
        If seciliSatirlar.Count = 0 Then
            If chkSadeceBosKategoriler.Checked Then
                MessageBox.Show("Seçili ürünler arasında kategorisi boş olan bulunamadı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                MessageBox.Show("Lütfen en az bir ürün seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
            Return
        End If
        
        ' Onay al
        Dim mesaj As String = $"{seciliSatirlar.Count} ürün seçildi."
        If chkSadeceBosKategoriler.Checked Then
            mesaj &= " (Sadece kategorisi boş olanlar)"
        End If
        mesaj &= vbCrLf & vbCrLf &
                 "Bu ürünlerin kategorileri eşleştirilecek." & vbCrLf &
                 "İşlem zaman alabilir (her ürün için 3 saniye)." & vbCrLf & vbCrLf &
                 "Devam etmek istiyor musunuz?"
        
        If MessageBox.Show(mesaj, "Seçili Ürünleri Eşle", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then
            Return
        End If
        
        ' Eşleştirmeyi başlat
        Await EsleUrunler(seciliSatirlar)
    End Sub
    
    ''' <summary>
    ''' Tüm ürünleri eşleştirir
    ''' </summary>
    Private Async Sub btnTumunuEsle_Click(sender As Object, e As EventArgs) Handles btnTumunuEsle.Click
        ' Eğer liste boşsa, önce tüm bWebGoruntule=1 ürünleri yükle
        If dgvUrunler.Rows.Count = 0 Then
            Dim cevap As DialogResult = MessageBox.Show(
                "Ürün listesi boş. Önce bWebGoruntule=True olan TÜM ürünleri yükleyip eşleştirmek ister misiniz?" & vbCrLf & vbCrLf &
                "Bu işlem:" & vbCrLf &
                "• Veritabanından tüm web ürünlerini çekecek" & vbCrLf &
                "• Seçili kaynaklarla (Excel/Veritabanı/Trendyol) eşleştirecek" & vbCrLf & vbCrLf &
                "Devam etmek istiyor musunuz?",
                "Tümünü Eşle", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            
            If cevap <> DialogResult.Yes Then Return
            
            ' Tüm bWebGoruntule=1 ürünleri yükle
            AddLog("📥 Tüm web ürünleri yükleniyor (bWebGoruntule=1)...")
            Await YukleTumWebUrunleri()
            
            If dgvUrunler.Rows.Count = 0 Then
                MessageBox.Show("Hiç ürün bulunamadı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
        End If
        
        ' Sadece boş kategoriler checkbox'u kontrolü
        Dim eslesecekSatirlar As New List(Of Integer)
        
        If chkSadeceBosKategoriler.Checked Then
            ' Sadece kategorisi boş olanları ekle
            For i As Integer = 0 To dgvUrunler.Rows.Count - 1
                Dim mevcutKategori As String = dgvUrunler.Rows(i).Cells("colKategori").Value?.ToString()
                If String.IsNullOrWhiteSpace(mevcutKategori) Then
                    eslesecekSatirlar.Add(i)
                End If
            Next
            
            If eslesecekSatirlar.Count = 0 Then
                MessageBox.Show("Kategorisi boş olan ürün bulunamadı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If
        Else
            ' Tüm satırları ekle
            For i As Integer = 0 To dgvUrunler.Rows.Count - 1
                eslesecekSatirlar.Add(i)
            Next
        End If
        
        ' Onay al
        Dim mesaj As String = $"TOPLAM {eslesecekSatirlar.Count} ÜRÜN eşleştirilecek!" & vbCrLf
        If chkSadeceBosKategoriler.Checked Then
            mesaj &= "(Sadece kategorisi boş olanlar)" & vbCrLf
        End If
        mesaj &= vbCrLf &
                 "Bu işlem çok uzun sürebilir:" & vbCrLf &
                 $"• Her ürün için 3 saniye bekleme" & vbCrLf &
                 $"• Tahmini süre: {(eslesecekSatirlar.Count * 3) / 60} dakika" & vbCrLf & vbCrLf &
                 "Devam etmek istiyor musunuz?"
        
        If MessageBox.Show(mesaj, "Tümünü Eşle", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) <> DialogResult.Yes Then
            Return
        End If
        
        Await EsleUrunler(eslesecekSatirlar)
    End Sub
    
    ''' <summary>
    ''' Veritabanından tüm bWebGoruntule=1 ürünlerini yükler
    ''' </summary>
    Private Async Function YukleTumWebUrunleri() As Task
        Try
            dgvUrunler.Rows.Clear()
            
            ' Parametrik sınıf eşleştirme ayarlarını oku
            Dim markaField As String = GetSinifEslemeAyar("ETICARET_SINIF_MARKA", "sSinifKodu3")
            Dim kat1Field As String = GetSinifEslemeAyar("ETICARET_SINIF_KAT1", "sSinifKodu4")
            Dim kat2Field As String = GetSinifEslemeAyar("ETICARET_SINIF_KAT2", "sSinifKodu5")
            Dim kat3Field As String = GetSinifEslemeAyar("ETICARET_SINIF_KAT3", "sSinifKodu6")
            Dim kat4Field As String = GetSinifEslemeAyar("ETICARET_SINIF_KAT4", "sSinifKodu7")
            Dim kat5Field As String = GetSinifEslemeAyar("ETICARET_SINIF_KAT5", "sSinifKodu8")
            
            AddLog("--- Sınıf Eşleştirme Ayarları ---")
            AddLog($"  Marka: {markaField}")
            AddLog($"  Kategori 1: {kat1Field}")
            AddLog($"  Kategori 2: {kat2Field}")
            AddLog($"  Kategori 3: {kat3Field}")
            AddLog("--- --- ---")
            
            Using conn As New OleDb.OleDbConnection(connection)
                Await Task.Run(Sub() conn.Open())
                
                ' En basit sorgu - sadece temel bilgiler
                Dim sql As String = "SELECT s.nStokID, s.sKodu, s.sModel, s.sRenk, s.sAciklama " &
                                   "FROM tbStok s " &
                                   "WHERE s.bWebGoruntule = 1 " &
                                   "AND s.nStokTipi < 5 " &
                                   "ORDER BY s.sModel, s.sKodu"
                
                Dim cmd As New OleDb.OleDbCommand(sql, conn)
                Dim dt As New DataTable()
                Dim adapter As New OleDb.OleDbDataAdapter(cmd)
                Await Task.Run(Sub() adapter.Fill(dt))
                
                AddLog($"📊 {dt.Rows.Count} ürün çekildi, detaylar yükleniyor...")
                
                For Each row As DataRow In dt.Rows
                    Dim nStokID As Integer = Convert.ToInt32(row("nStokID"))
                    Dim sKodu As String = If(row("sKodu") IsNot DBNull.Value, row("sKodu").ToString(), "")
                    Dim sModel As String = If(row("sModel") IsNot DBNull.Value, row("sModel").ToString(), "")
                    Dim sRenk As String = If(row("sRenk") IsNot DBNull.Value, row("sRenk").ToString(), "")
                    Dim sAciklama As String = If(row("sAciklama") IsNot DBNull.Value, row("sAciklama").ToString(), "")
                    
                    ' Barkod al
                    Dim barkod As String = ""
                    Try
                        Dim cmdBarkod As New OleDb.OleDbCommand("SELECT TOP 1 sBarkod FROM tbStokBarkodu WHERE nStokID = " & nStokID & " AND nKisim = 0", conn)
                        Dim result = cmdBarkod.ExecuteScalar()
                        If result IsNot Nothing AndAlso result IsNot DBNull.Value Then barkod = result.ToString()
                    Catch
                    End Try
                    
                    ' MARKA al - PARAMETRİK sınıf eşleştirmesine göre
                    Dim sMarka As String = ""
                    Try
                        If Not String.IsNullOrEmpty(markaField) AndAlso markaField.StartsWith("sSinifKodu") Then
                            Dim sinifNo As String = markaField.Replace("sSinifKodu", "")
                            Dim cmdMarka As New OleDb.OleDbCommand(
                                $"SELECT TOP 1 s.sAciklama FROM tbStokSinifi si " &
                                $"INNER JOIN tbSSinif{sinifNo} s ON s.sSinifKodu = si.{markaField} " &
                                $"WHERE si.nStokID = {nStokID}", conn)
                            Dim result = cmdMarka.ExecuteScalar()
                            If result IsNot Nothing AndAlso result IsNot DBNull.Value Then sMarka = result.ToString()
                        End If
                    Catch
                    End Try
                    
                    ' Mevcut kategorileri al - PARAMETRİK sınıf eşleştirmesine göre
                    Dim mevcutKategori As String = ""
                    Try
                        Dim kategoriler As New List(Of String)
                        
                        ' Her kategori alanı için dinamik sorgu
                        Dim katFields() As String = {kat1Field, kat2Field, kat3Field, kat4Field, kat5Field}
                        For Each katField As String In katFields
                            If Not String.IsNullOrEmpty(katField) AndAlso katField.StartsWith("sSinifKodu") Then
                                Dim sinifNo As String = katField.Replace("sSinifKodu", "")
                                Dim cmdKat As New OleDb.OleDbCommand(
                                    $"SELECT TOP 1 s.sAciklama FROM tbStokSinifi si " &
                                    $"INNER JOIN tbSSinif{sinifNo} s ON s.sSinifKodu = si.{katField} " &
                                    $"WHERE si.nStokID = {nStokID}", conn)
                                Dim result = cmdKat.ExecuteScalar()
                                If result IsNot Nothing AndAlso result IsNot DBNull.Value AndAlso result.ToString().Trim() <> "" Then
                                    kategoriler.Add(result.ToString())
                                End If
                            End If
                        Next
                        
                        If kategoriler.Count > 0 Then mevcutKategori = String.Join(" / ", kategoriler)
                    Catch
                    End Try
                    
                    ' Satır ekle
                    Dim rowIndex As Integer = dgvUrunler.Rows.Add()
                    dgvUrunler.Rows(rowIndex).Cells("colBarkod").Value = barkod
                    dgvUrunler.Rows(rowIndex).Cells("colModel").Value = sModel
                    dgvUrunler.Rows(rowIndex).Cells("colRenk").Value = sRenk
                    dgvUrunler.Rows(rowIndex).Cells("colUrunAdi").Value = sAciklama
                    dgvUrunler.Rows(rowIndex).Cells("colMarka").Value = sMarka
                    dgvUrunler.Rows(rowIndex).Cells("colKategori").Value = mevcutKategori
                    dgvUrunler.Rows(rowIndex).Cells("colDurum").Value = ""
                    dgvUrunler.Rows(rowIndex).Tag = nStokID
                Next
            End Using
            
            AddLog($"✅ {dgvUrunler.Rows.Count} ürün yüklendi (bWebGoruntule=1)")
            
        Catch ex As Exception
            AddLog($"❌ Ürün yükleme hatası: {ex.Message}")
            MessageBox.Show($"Ürün yükleme hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function
    
    ''' <summary>
    ''' Belirtilen satırlardaki ürünleri eşleştirir
    ''' </summary>
    Private Async Function EsleUrunler(satirlar As List(Of Integer)) As Task
        Try
            ' Butonları devre dışı bırak
            btnListeYukle.Enabled = False
            btnSecilenleriEsle.Enabled = False
            btnTumunuEsle.Enabled = False
            btnDurdur.Enabled = True
            islemDurduruldu = False
            
            ' CancellationToken oluştur
            _islemCts = New CancellationTokenSource()
            Dim token As CancellationToken = _islemCts.Token
            
            Dim basarili As Integer = 0
            Dim basarisiz As Integer = 0
            
            ' Eşleştirme kaynaklarını belirle
            Dim kullanVeritabani As Boolean = chkVeritabani.Checked
            Dim kullanTrendyol As Boolean = chkTrendyol.Checked
            Dim kullanExcel As Boolean = chkExcel.Checked AndAlso _excelMatcher IsNot Nothing
            
            Dim kaynaklar As String = ""
            If kullanExcel Then kaynaklar &= "Excel "
            If kullanVeritabani Then kaynaklar &= "Veritabanı "
            If kullanTrendyol Then kaynaklar &= "Trendyol "
            
            AddLog($"🚀 {satirlar.Count} ÜRÜN EŞLEŞTİRME BAŞLADI (Kaynak: {kaynaklar.Trim()})")
            
            ' ============ SELENIUM'U DÖNGÜDEN ÖNCE BİR KEZ BAŞLAT ============
            If kullanTrendyol AndAlso _seleniumScraper Is Nothing Then
                AddLog("🌐 Selenium tarayıcı başlatılıyor...")
                _seleniumScraper = New TrendyolSeleniumScraperService(headless:=True)
                If Not _seleniumScraper.Initialize() Then
                    Dim hataMesaji As String = If(String.IsNullOrEmpty(_seleniumScraper.LastError), "Bilinmeyen hata", _seleniumScraper.LastError)
                    AddLog($"❌ Selenium başlatılamadı: {hataMesaji}")
                    AddLog("💡 ChromeDriver sürümü Chrome ile uyumlu mu kontrol edin.")
                    kullanTrendyol = False
                    _seleniumScraper = Nothing
                Else
                    AddLog("✅ Selenium tarayıcı hazır")
                End If
            End If
            ' ==================================================================
            
            ' Ürünleri modele göre grupla
            Dim modelGruplari As New Dictionary(Of String, List(Of Integer))
            For Each satirIndex As Integer In satirlar
                Dim sModel As String = dgvUrunler.Rows(satirIndex).Cells("colModel").Value.ToString()
                If Not modelGruplari.ContainsKey(sModel) Then
                    modelGruplari(sModel) = New List(Of Integer)
                End If
                modelGruplari(sModel).Add(satirIndex)
            Next
            
            AddLog($"📦 {modelGruplari.Count} farklı model bulundu")
            
            ' Eşleşme bulunamayan ürünleri ürün tipine göre gruplamak için
            ' Key: UrunTipi, Value: (Model, Satirlar, OrnekUrunAdi) listesi
            Dim eslesemeyenUrunTipleri As New Dictionary(Of String, List(Of Tuple(Of String, List(Of Integer), String)))
            
            ' Progress bar ayarla - model sayısına göre
            progressBar.Maximum = modelGruplari.Count
            progressBar.Value = 0
            
            ' İşlenmiş modelleri takip et
            Dim islenmisSatirlar As New HashSet(Of Integer)
            
            ' Her model için işlem yap
            For Each modelKvp As KeyValuePair(Of String, List(Of Integer)) In modelGruplari
                If islemDurduruldu OrElse token.IsCancellationRequested Then
                    AddLog("⏹️ İŞLEM DURDURULDU")
                    Exit For
                End If
                
                Dim sModel As String = modelKvp.Key
                Dim modelSatirlari As List(Of Integer) = modelKvp.Value
                Dim ilkSatir As Integer = modelSatirlari(0)
                
                ' İlk satırdan bilgileri al
                Dim sRenk As String = dgvUrunler.Rows(ilkSatir).Cells("colRenk").Value.ToString()
                Dim sMarka As String = dgvUrunler.Rows(ilkSatir).Cells("colMarka").Value.ToString()
                Dim sAciklama As String = dgvUrunler.Rows(ilkSatir).Cells("colUrunAdi").Value.ToString()
                
                ' Durum güncelle - tüm model satırlarını "İşleniyor" yap
                For Each idx As Integer In modelSatirlari
                    dgvUrunler.Rows(idx).Cells("colDurum").Value = "İşleniyor..."
                    dgvUrunler.Rows(idx).Cells("colDurum").Style.BackColor = Color.LightYellow
                Next
                UpdateStatus($"İşleniyor: {sModel} ({modelSatirlari.Count} varyant)", Color.Orange)
                
                Dim sonuc As TrendyolScraperSonuc = Nothing
                
                ' ========================================
                ' AKILLI KATEGORİ SEÇİMİ - TÜM KAYNAKLARI ARA
                ' ========================================
                Dim excelSonuc As TrendyolScraperSonuc = Nothing
                Dim veritabaniSonuc As TrendyolScraperSonuc = Nothing
                Dim trendyolSonuc As TrendyolScraperSonuc = Nothing
                
                AddLog($"  🧠 {sModel}: Akıllı kategori eşleştirme başlıyor...")
                
                ' 1. EXCEL'DE ARA (Model kodu ve barkod)
                If kullanExcel AndAlso _excelMatcher IsNot Nothing Then
                    AddLog($"    📁 Excel'de aranıyor...")
                    
                    ' Önce model kodu ile dene
                    excelSonuc = _excelMatcher.ModelKoduIleAra(sModel)
                    
                    ' Model bulunamadıysa barkod ile dene
                    If excelSonuc Is Nothing OrElse Not excelSonuc.Basarili Then
                        For Each satirIdx As Integer In modelSatirlari
                            Dim barkod As String = dgvUrunler.Rows(satirIdx).Cells("colBarkod").Value.ToString()
                            excelSonuc = _excelMatcher.BarkodIleAra(barkod)
                            If excelSonuc IsNot Nothing AndAlso excelSonuc.Basarili Then
                                Exit For
                            End If
                        Next
                    End If
                    
                    If excelSonuc IsNot Nothing AndAlso excelSonuc.Basarili Then
                        AddLog($"    ✅ Excel: {excelSonuc.KategoriYolu}")
                    End If
                End If
                
                ' 2. VERİTABANINDA ARA (Model kodu ve ürün adı)
                If kullanVeritabani Then
                    AddLog($"    💾 Veritabanında aranıyor...")
                    
                    ' Önce model kodu ile dene
                    veritabaniSonuc = Await Task.Run(Function() TrendyolDatabaseMatcher.AraVeritabaniModelKodu(connection, sModel))
                    
                    ' Model bulunamadıysa ürün adı ile dene
                    If veritabaniSonuc Is Nothing OrElse Not veritabaniSonuc.Basarili Then
                        veritabaniSonuc = Await Task.Run(Function() TrendyolDatabaseMatcher.AraVeritabani(connection, sAciklama))
                    End If
                    
                    If veritabaniSonuc IsNot Nothing AndAlso veritabaniSonuc.Basarili Then
                        AddLog($"    ✅ Veritabanı: {veritabaniSonuc.KategoriYolu}")
                    End If
                End If
                
                ' 3. TRENDYOL'DA ARA (Sadece diğerleri bulunamadıysa - zaman tasarrufu)
                If kullanTrendyol AndAlso _seleniumScraper IsNot Nothing Then
                    Dim trendyolGerekli As Boolean = (excelSonuc Is Nothing OrElse Not excelSonuc.Basarili) AndAlso _
                                                      (veritabaniSonuc Is Nothing OrElse Not veritabaniSonuc.Basarili)
                    
                    If trendyolGerekli Then
                        AddLog($"    🔍 Trendyol'da aranıyor...")
                        
                        Dim enIyiTrendyol As TrendyolScraperSonuc = Nothing
                        Dim enIyiSkor As Double = 0
                        
                        For Each satirIdx As Integer In modelSatirlari
                            If islemDurduruldu OrElse token.IsCancellationRequested Then Exit For
                            
                            Dim barkod As String = dgvUrunler.Rows(satirIdx).Cells("colBarkod").Value.ToString()
                            Dim urunAdi As String = dgvUrunler.Rows(satirIdx).Cells("colUrunAdi").Value.ToString()
                            
                            Dim barkodSonuc As TrendyolScraperSonuc = Await Task.Run(Function() _seleniumScraper.GetKategoriByBarkod(barkod, urunAdi, sMarka))
                            
                            If barkodSonuc IsNot Nothing AndAlso barkodSonuc.Basarili Then
                                If barkodSonuc.Skor > enIyiSkor Then
                                    enIyiSkor = barkodSonuc.Skor
                                    enIyiTrendyol = barkodSonuc
                                End If
                                
                                If barkodSonuc.Skor >= 0.85 Then Exit For
                            End If
                            
                            Await Task.Delay(2000, token)
                        Next
                        
                        trendyolSonuc = enIyiTrendyol
                        
                        If trendyolSonuc IsNot Nothing AndAlso trendyolSonuc.Basarili Then
                            AddLog($"    ✅ Trendyol: {trendyolSonuc.KategoriYolu}")
                        End If
                    End If
                End If
                
                ' ========================================
                ' AKILLI SEÇİM - EN UYGUN KATEGORİYİ SEÇ
                ' ========================================
                Dim akilliSecim As AkilliSecimSonuc = AkilliKategoriSecici.EnUygunKategoriyiSec( _
                    sAciklama, _
                    excelSonuc, _
                    veritabaniSonuc, _
                    trendyolSonuc _
                )
                
                If akilliSecim.Basarili Then
                    sonuc = akilliSecim.SecilenSonuc
                    sonuc.Not_ = "[" & akilliSecim.SecilenKaynak & "] " & akilliSecim.SecimNedeni
                    
                    AddLog($"  🎯 AKILLI SEÇİM: {akilliSecim.SecilenKaynak} tercih edildi")
                    AddLog($"     Neden: {akilliSecim.SecimNedeni}")
                    
                    ' Karşılaştırma detaylarını logla
                    If akilliSecim.KarsilastirmaDetayi IsNot Nothing Then
                        For Each detay As String In akilliSecim.KarsilastirmaDetayi
                            AddLog($"     - {detay}")
                        Next
                    End If
                Else
                    AddLog($"  ⚠️ Akıllı seçim başarısız: {akilliSecim.SecimNedeni}")
                End If
                
                ' Sonuç kontrolü
                ' Sonuç kontrolü
                If sonuc Is Nothing Then
                    sonuc = New TrendyolScraperSonuc()
                    sonuc.Basarili = False
                    sonuc.HataMesaji = "Hiçbir kaynak seçilmedi"
                End If
                
                If sonuc.Basarili AndAlso sonuc.Kategoriler IsNot Nothing AndAlso sonuc.Kategoriler.Count > 0 Then
                    ' Başarılı - Kaydet
                    Dim kategoriSonuc As New TrendyolKategoriSonuc()
                    kategoriSonuc.Basarili = True
                    kategoriSonuc.Barkod = sonuc.Barkod
                    kategoriSonuc.Marka = sonuc.Marka
                    kategoriSonuc.UrunBaslik = sonuc.UrunAdi
                    kategoriSonuc.UrunUrl = sonuc.UrunUrl
                    kategoriSonuc.Kategoriler = sonuc.Kategoriler
                    
                    ' TEKRARLANAN KATEGORİLERİ ATLA - benzersiz kategori listesi oluştur
                    Dim benzersizKategoriler As New List(Of String)
                    For Each kat As String In sonuc.Kategoriler
                        If Not String.IsNullOrEmpty(kat) AndAlso Not benzersizKategoriler.Contains(kat.Trim()) Then
                            benzersizKategoriler.Add(kat.Trim())
                        End If
                    Next
                    
                    ' Benzersiz kategorileri sınıflara ata
                    If benzersizKategoriler.Count > 0 Then kategoriSonuc.Kategori1 = benzersizKategoriler(0)
                    If benzersizKategoriler.Count > 1 Then kategoriSonuc.Kategori2 = benzersizKategoriler(1)
                    If benzersizKategoriler.Count > 2 Then kategoriSonuc.Kategori3 = benzersizKategoriler(2)
                    If benzersizKategoriler.Count > 3 Then kategoriSonuc.Kategori4 = benzersizKategoriler(3)
                    If benzersizKategoriler.Count > 4 Then kategoriSonuc.Kategori5 = benzersizKategoriler(4)
                    
                    ' MODEL BAZLI KAYDET - Aynı modeldeki tüm varyantlara yaz
                    ' Excel kullanılıyorsa ve marka sütunu SEÇİLMEDİYSE, marka alanına dokunma
                    Dim markaGuncelle As Boolean = True
                    If kullanExcel AndAlso _excelMatcher IsNot Nothing AndAlso Not _excelMatcher.MarkaSecildi Then
                        markaGuncelle = False
                        AddLog($"    [INFO] Excel'de marka sütunu seçilmedi - marka alanı güncellenmeyecek")
                    End If
                    Dim kayitSonuc As Boolean = KategoriKaydetModelBazli(sModel, kategoriSonuc, markaGuncelle)
                    
                    If kayitSonuc Then
                        ' Tüm model satırlarını başarılı işaretle
                        For Each idx As Integer In modelSatirlari
                            dgvUrunler.Rows(idx).Cells("colDurum").Value = "✅ Eşleşti"
                            dgvUrunler.Rows(idx).Cells("colDurum").Style.BackColor = Color.LightGreen
                            dgvUrunler.Rows(idx).Cells("colKategori").Value = sonuc.Kategoriler(0)
                        Next
                        
                        basarili += 1
                        AddLog($"✅ {sModel}: {sonuc.KategoriYolu} ({modelSatirlari.Count} varyanta yazıldı)")
                    Else
                        For Each idx As Integer In modelSatirlari
                            dgvUrunler.Rows(idx).Cells("colDurum").Value = "⚠️ Kayıt Hatası"
                            dgvUrunler.Rows(idx).Cells("colDurum").Style.BackColor = Color.Orange
                        Next
                        basarisiz += 1
                        AddLog($"⚠️ {sModel}: Kategori bulundu ama kayıt başarısız")
                    End If
                Else
                    ' Başarısız - Marka + Ürün tipi + cinsiyet bazında grupla (sonra kullanıcıya soracağız)
                    ' Model kodunun ilk 2 harfi markayı temsil eder (RP=Rolypoly, US=U.S.Polo, vb.)
                    Dim markaPrefix As String = ""
                    If Not String.IsNullOrEmpty(sModel) AndAlso sModel.Length >= 2 Then
                        markaPrefix = sModel.Substring(0, 2).ToUpper()
                    End If
                    
                    ' BulUrunTipiVeCinsiyet kullanarak ANNE KIZ ve BABA OĞUL gibi ürünleri ayrı grupluyoruz
                    ' Model kodu da geçiriyoruz - -S soneki yetişkin/çocuk ayrımı için
                    Dim urunTipiVeCinsiyet As String = BulUrunTipiVeCinsiyet(sAciklama, sModel)
                    
                    ' Grup anahtarı: MARKA_PREFIX + URUN_TIPI_CINSIYET
                    Dim grupKey As String = ""
                    If Not String.IsNullOrEmpty(markaPrefix) AndAlso Not String.IsNullOrEmpty(urunTipiVeCinsiyet) Then
                        grupKey = markaPrefix & " - " & urunTipiVeCinsiyet
                    ElseIf Not String.IsNullOrEmpty(urunTipiVeCinsiyet) Then
                        grupKey = urunTipiVeCinsiyet
                    End If
                    
                    If Not String.IsNullOrEmpty(grupKey) Then
                        If Not eslesemeyenUrunTipleri.ContainsKey(grupKey) Then
                            eslesemeyenUrunTipleri(grupKey) = New List(Of Tuple(Of String, List(Of Integer), String))
                        End If
                        eslesemeyenUrunTipleri(grupKey).Add(Tuple.Create(sModel, modelSatirlari, sAciklama))
                    End If
                    
                    ' Şimdilik "Bekliyor" olarak işaretle
                    For Each idx As Integer In modelSatirlari
                        dgvUrunler.Rows(idx).Cells("colDurum").Value = "⏳ Bekliyor"
                        dgvUrunler.Rows(idx).Cells("colDurum").Style.BackColor = Color.LightYellow
                    Next
                    
                    basarisiz += 1
                    AddLog($"⏳ {sModel}: Eşleşme bulunamadı, kullanıcı seçimi beklenecek (Tip: {grupKey})")
                End If
                
                ' Progress bar güncelle
                progressBar.Value += 1
                
            Next
            
            ' ========================================
            ' KULLANICIDAN KATEGORİ SEÇİMİ İSTE
            ' Eşleşme bulunamayan ürün tipleri için
            ' ========================================
            Dim manuelEslesen As Integer = 0
            Dim manuelAtlanan As Integer = 0
            
            If eslesemeyenUrunTipleri.Count > 0 Then
                AddLog($"")
                AddLog($"════════════════════════════════════════════════════════════")
                AddLog($"📋 {eslesemeyenUrunTipleri.Count} ÜRÜN TİPİ İÇİN EŞLEŞTİRME BULUNAMADI")
                AddLog($"   Kullanıcı kategori seçimi penceresi açılacak...")
                AddLog($"════════════════════════════════════════════════════════════")
                
                Dim tumunuAtla As Boolean = False
                
                For Each tipKvp As KeyValuePair(Of String, List(Of Tuple(Of String, List(Of Integer), String))) In eslesemeyenUrunTipleri
                    If islemDurduruldu OrElse tumunuAtla Then Exit For
                    
                    Dim urunTipi As String = tipKvp.Key
                    Dim modeller As List(Of Tuple(Of String, List(Of Integer), String)) = tipKvp.Value
                    
                    ' Toplam ürün sayısı hesapla
                    Dim toplamUrun As Integer = 0
                    Dim ornekUrunler As New List(Of String)
                    Dim ornekModeller As New List(Of String)  ' YENİ: Model kodları
                    For Each t As Tuple(Of String, List(Of Integer), String) In modeller
                        toplamUrun += t.Item2.Count
                        If ornekUrunler.Count < 5 Then
                            ornekUrunler.Add(t.Item3)  ' Ürün adı
                            ornekModeller.Add(t.Item1)  ' Model kodu
                        End If
                    Next
                    
                    AddLog($"")
                    AddLog($"📦 Ürün Tipi: {urunTipi}")
                    AddLog($"   {modeller.Count} model, {toplamUrun} ürün")
                    
                    ' Kategori seçim formunu aç
                    Dim frmSec As New frm_UrunTipiKategoriSec()
                    frmSec.connection = connection
                    frmSec.UrunTipi = urunTipi
                    frmSec.UrunSayisi = toplamUrun
                    frmSec.OrnekUrunler = ornekUrunler
                    frmSec.OrnekModeller = ornekModeller  ' YENİ: Model kodlarını da geçir
                    
                    Dim dialogSonuc As DialogResult = frmSec.ShowDialog()
                    
                    If frmSec.TumunuAtla Then
                        tumunuAtla = True
                        AddLog($"   ⏭️ Kullanıcı tüm kalan tipleri atladı")
                        
                        ' Kalan tüm bekleyen ürünleri "Atlandı" yap
                        For Each innerKvp As KeyValuePair(Of String, List(Of Tuple(Of String, List(Of Integer), String))) In eslesemeyenUrunTipleri
                            For Each modelTuple As Tuple(Of String, List(Of Integer), String) In innerKvp.Value
                                For Each idx As Integer In modelTuple.Item2
                                    If dgvUrunler.Rows(idx).Cells("colDurum").Value.ToString() = "⏳ Bekliyor" Then
                                        dgvUrunler.Rows(idx).Cells("colDurum").Value = "⏭️ Atlandı"
                                        dgvUrunler.Rows(idx).Cells("colDurum").Style.BackColor = Color.LightGray
                                    End If
                                Next
                            Next
                        Next
                        manuelAtlanan += tipKvp.Value.Count
                        Exit For
                        
                    ElseIf dialogSonuc = DialogResult.OK AndAlso frmSec.Sonuc.Basarili Then
                        ' Kullanıcı kategori seçti - tüm bu tipteki ürünlere uygula
                        Dim secim As UrunTipiKategoriSonuc = frmSec.Sonuc
                        
                        AddLog($"   ✅ Kullanıcı seçti: {secim.Sinif4Aciklama} / {secim.Sinif5Aciklama} / {secim.Sinif6Aciklama}")
                        
                        ' Her modele uygula
                        For Each modelTuple As Tuple(Of String, List(Of Integer), String) In modeller
                            Dim modelAdi As String = modelTuple.Item1
                            Dim satirIndexler As List(Of Integer) = modelTuple.Item2
                            
                            ' Veritabanına kaydet (frm_stok_kart.vb tbStokSinifi_kaydet_duzelt1 mantığı)
                            Dim kayitBasarili As Boolean = KategoriKaydetManuel(modelAdi, secim)
                            
                            If kayitBasarili Then
                                For Each idx As Integer In satirIndexler
                                    dgvUrunler.Rows(idx).Cells("colDurum").Value = "✅ Manuel Eşleşti"
                                    dgvUrunler.Rows(idx).Cells("colDurum").Style.BackColor = Color.LightGreen
                                    dgvUrunler.Rows(idx).Cells("colKategori").Value = secim.Sinif4Aciklama
                                Next
                                manuelEslesen += 1
                                AddLog($"      ✅ {modelAdi}: Kaydedildi ({satirIndexler.Count} varyant)")
                            Else
                                For Each idx As Integer In satirIndexler
                                    dgvUrunler.Rows(idx).Cells("colDurum").Value = "⚠️ Kayıt Hatası"
                                    dgvUrunler.Rows(idx).Cells("colDurum").Style.BackColor = Color.Orange
                                Next
                                AddLog($"      ⚠️ {modelAdi}: Kayıt başarısız")
                            End If
                        Next
                        
                    Else
                        ' Kullanıcı bu tipi atladı
                        AddLog($"   ⏭️ Atlandı")
                        For Each modelTuple As Tuple(Of String, List(Of Integer), String) In modeller
                            For Each idx As Integer In modelTuple.Item2
                                dgvUrunler.Rows(idx).Cells("colDurum").Value = "⏭️ Atlandı"
                                dgvUrunler.Rows(idx).Cells("colDurum").Style.BackColor = Color.LightGray
                            Next
                        Next
                        manuelAtlanan += 1
                    End If
                    
                    frmSec.Dispose()
                Next
            End If
            
            ' Sonuçları güncelle
            Dim toplamBasarili As Integer = basarili + manuelEslesen
            
            ' Tamamlandı
            AddLog($"")
            AddLog($"════════════════════════════════════════════════════════════")
            AddLog($"🎉 TAMAMLANDI!")
            AddLog($"   Otomatik Eşleşen: {basarili} model")
            AddLog($"   Manuel Eşleşen: {manuelEslesen} model")
            AddLog($"   Atlanan: {manuelAtlanan} tip")
            AddLog($"════════════════════════════════════════════════════════════")
            UpdateStatus($"Tamamlandı! Otomatik: {basarili}, Manuel: {manuelEslesen}", Color.Green)
            MessageBox.Show($"İşlem tamamlandı!" & vbCrLf & vbCrLf &
                          $"Toplam Model: {modelGruplari.Count}" & vbCrLf &
                          $"Otomatik Eşleşen: {basarili}" & vbCrLf &
                          $"Manuel Eşleşen: {manuelEslesen}" & vbCrLf &
                          $"Atlanan Tip: {manuelAtlanan}", "Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information)
            
        Catch ex As Exception
            AddLog($"❌ HATA: {ex.Message}")
            UpdateStatus($"Hata: {ex.Message}", Color.Red)
        Finally
            ' Selenium'u kapat
            If _seleniumScraper IsNot Nothing Then
                AddLog("🔒 Selenium tarayıcı kapatılıyor...")
                Try
                    _seleniumScraper.Dispose()
                Catch
                End Try
                _seleniumScraper = Nothing
            End If
            
            ' Butonları aktif et
            btnListeYukle.Enabled = True
            btnSecilenleriEsle.Enabled = True
            btnTumunuEsle.Enabled = True
            btnDurdur.Enabled = False
            progressBar.Value = 0
        End Try
    End Function
    
    ''' <summary>
    ''' DataGridView checkbox değişikliklerini takip eder ve seçili ürün sayısını günceller
    ''' </summary>
    Private Sub dgvUrunler_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUrunler.CellValueChanged
        If e.ColumnIndex = 0 AndAlso e.RowIndex >= 0 Then ' Checkbox sütunu
            UpdateSeciliUrunSayisi()
        End If
    End Sub
    
    ''' <summary>
    ''' Seçili ürün sayısını günceller
    ''' </summary>
    Private Sub UpdateSeciliUrunSayisi()
        Try
            Dim seciliSayi As Integer = 0
            Dim toplamSayi As Integer = dgvUrunler.Rows.Count
            
            For i As Integer = 0 To dgvUrunler.Rows.Count - 1
                Dim checkCell As DataGridViewCheckBoxCell = CType(dgvUrunler.Rows(i).Cells("colSec"), DataGridViewCheckBoxCell)
                If checkCell.Value IsNot Nothing AndAlso CBool(checkCell.Value) = True Then
                    seciliSayi += 1
                End If
            Next
            
            lblToplamUrun.Text = $"Toplam Ürün: {toplamSayi} | Seçili: {seciliSayi}"
            
        Catch ex As Exception
            ' Hata durumunda sessizce devam et
        End Try
    End Sub
    
    Private Sub btnDurdur_Click(sender As Object, e As EventArgs) Handles btnDurdur.Click
        islemDurduruldu = True
        
        ' CancellationToken'ı iptal et
        If _islemCts IsNot Nothing Then
            Try
                _islemCts.Cancel()
            Catch
            End Try
        End If
        
        btnDurdur.Enabled = False
        btnDurdur.Text = "Durduruluyor..."
        AddLog("⏹️ DURDURMA İSTEĞİ ALINDI")
        UpdateStatus("Durduruluyor...", Color.Orange)
    End Sub
    
    ''' <summary>
    ''' Kategorileri temizle - sadece bWebGoruntule=1 olanlar
    ''' bKategoriAtla = False yapar ve sınıfları boşaltır
    ''' </summary>
    Private Sub btnTemizle_Click(sender As Object, e As EventArgs)
        Dim mesaj As String = "DİKKAT! Bu işlem tüm web ürünlerinin (bWebGoruntule=1) kategori bilgilerini temizleyecek:" & vbCrLf & vbCrLf &
                              "• sSinifKodu4 (Cinsiyet/Ana Kategori)" & vbCrLf &
                              "• sSinifKodu7 (Alt Kategori 1)" & vbCrLf &
                              "• sSinifKodu8 (Alt Kategori 2)" & vbCrLf &
                              "• sSinifKodu9 (Alt Kategori 3)" & vbCrLf &
                              "• sSinifKodu10 (Alt Kategori 4)" & vbCrLf &
                              "• bKategoriAtla = False yapılacak" & vbCrLf & vbCrLf &
                              "Bu işlem geri alınamaz! Devam etmek istiyor musunuz?"
        
        If MessageBox.Show(mesaj, "Kategorileri Temizle", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) <> DialogResult.Yes Then
            Return
        End If
        
        Try
            AddLog("KATEGORİLER TEMİZLENİYOR...")
            UpdateStatus("Kategoriler temizleniyor...", Color.Orange)
            
            Dim temizlenenSayi As Integer = 0
            
            Using conn As New OleDbConnection(connection)
                conn.Open()
                
                ' bWebGoruntule=1 olan ürünlerin kategori alanlarını boş string ile temizle
                ' VE bKategoriAtla = False yap
                Dim cmdUpdate As New OleDbCommand(
                    "UPDATE tbStokSinifi SET " &
                    "sSinifKodu4 = '', " &
                    "sSinifKodu7 = '', " &
                    "sSinifKodu8 = '', " &
                    "sSinifKodu9 = '', " &
                    "sSinifKodu10 = '', " &
                    "bKategoriAtla = 0 " &
                    "WHERE nStokID IN (SELECT nStokID FROM tbStok WHERE bWebGoruntule = 1)", conn)
                
                temizlenenSayi = cmdUpdate.ExecuteNonQuery()
            End Using
            
            AddLog($"✅ {temizlenenSayi} ürünün kategorileri ve bKategoriAtla temizlendi")
            UpdateStatus($"Tamamlandı! {temizlenenSayi} ürün temizlendi", Color.Green)
            
            MessageBox.Show($"{temizlenenSayi} ürünün kategori bilgileri temizlendi." & vbCrLf & "bKategoriAtla = False yapıldı.", "Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information)
            
        Catch ex As Exception
            AddLog($"❌ HATA: {ex.Message}")
            UpdateStatus($"Hata: {ex.Message}", Color.Red)
            MessageBox.Show($"Hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    
    ' ESKİ TEK ÜRÜN EVENT HANDLER (KULLANILMIYOR - YENİ SİSTEMDE DataGridView VAR)
    ' Private Async Sub btnTekUrun_Click eski kod kaldırıldı
    
    ' ESKİ TOPLU İŞLEM EVENT HANDLER (KULLANILMIYOR - YENİ SİSTEMDE btnTumunuEsle/btnSecilenleriEsle VAR)
    ' Private Async Sub btnTopluIslem_Click eski kod kaldırıldı
    
    ''' <summary>
    ''' Toplu işlemi arka planda çalıştır - UI thread'i bloke etmez
    ''' </summary>
    Private Sub TopluIslemArkaPlanda(maxAdet As Integer, sadeceBosKategoriler As Boolean, token As CancellationToken)
        Try
            SafeUpdateUI(Sub()
                AddLog("TOPLU İŞLEM BAŞLADI (Arka Plan)")
                AddLog("=" & New String("="c, 50))
            End Sub)
            
            ' Ürünleri al
            SafeUpdateUI(Sub() UpdateStatus("Ürünler sorgulanıyor...", Color.Blue))
            Dim urunler As List(Of Dictionary(Of String, Object)) = GetUrunlerForKategori(maxAdet, sadeceBosKategoriler)
            
            If urunler.Count = 0 Then
                SafeUpdateUI(Sub()
                    AddLog("İşlenecek ürün bulunamadı!")
                    UpdateStatus("İşlenecek ürün yok", Color.Orange)
                    MessageBox.Show("Kategorisi eşleştirilecek ürün bulunamadı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Sub)
                Return
            End If
            
            SafeUpdateUI(Sub()
                AddLog($"{urunler.Count} ürün bulundu")
                progressBar.Minimum = 0
                progressBar.Maximum = urunler.Count
                progressBar.Value = 0
            End Sub)
            
            Dim basarili As Integer = 0
            Dim basarisiz As Integer = 0
            Dim bulunamadi As Integer = 0
            
            For i As Integer = 0 To urunler.Count - 1
                ' İptal kontrolü
                If islemDurduruldu OrElse token.IsCancellationRequested Then
                    SafeUpdateUI(Sub()
                        AddLog("")
                        AddLog("⏹️ İŞLEM DURDURULDU!")
                        AddLog($"  Başarılı: {basarili}")
                        AddLog($"  Bulunamadı: {bulunamadi}")
                        AddLog($"  Hata: {basarisiz}")
                    End Sub)
                    Exit For
                End If
                
                Dim urun As Dictionary(Of String, Object) = urunler(i)
                Dim sModel As String = urun("sModel").ToString()
                Dim sAciklama As String = urun("sAciklama").ToString()
                Dim sMarka As String = urun("sMarka").ToString()
                Dim currentIndex As Integer = i
                
                Try
                    SafeUpdateUI(Sub()
                        UpdateStatus($"İşleniyor: {currentIndex + 1}/{urunler.Count} - Model: {sModel}", Color.Blue)
                        AddLog("")
                        AddLog($"[{currentIndex + 1}/{urunler.Count}] Model: {sModel}")
                        AddLog($"  Ürün: {sAciklama}")
                        AddLog($"  Marka: {sMarka}")
                    End Sub)
                    
                    ' Bu modele ait tüm barkodları al
                    Dim barkodlar As List(Of String) = GetModelBarkodlari(sModel)
                    
                    If barkodlar.Count = 0 Then
                        SafeUpdateUI(Sub() AddLog($"  Model için barkod bulunamadı!"))
                        basarisiz += 1
                        Continue For
                    End If
                    
                    SafeUpdateUI(Sub() AddLog($"  {barkodlar.Count} barkod deneniyor..."))
                    
                    Dim modelBulundu As Boolean = False
                    
                    ' Her barkodu dene - bulana kadar devam et
                    For Each barkod As String In barkodlar
                        If islemDurduruldu OrElse token.IsCancellationRequested Then Exit For
                        
                        Dim currentBarkod As String = barkod
                        SafeUpdateUI(Sub() AddLog($"    Deneniyor: {currentBarkod}"))
                        
                        ' BARKOD İLE TAM EŞLEŞME ARAMASI (Yeni Sistem - Doğru Eşleştirme)
                        Dim sonuc As TrendyolKategoriSonuc = TrendyolBarkodKategoriService.GetKategoriByBarkod(barkod)
                        
                        ' Rate limiting - her istek arasında 3 saniye bekle
                        Thread.Sleep(3000)
                        
                        If sonuc.Basarili AndAlso sonuc.Kategoriler.Count > 0 Then
                            SafeUpdateUI(Sub()
                                AddLog($"    BULUNDU! Trendyol Ürün: {sonuc.UrunAdi}")
                                AddLog($"    Kategoriler: {sonuc.KategoriYolu}")
                            End Sub)
                            
                            ' DOĞRU EŞLEŞME - Model bazlı kaydet (tüm varyantlara)
                            Dim kayitSonuc As Boolean = KategoriKaydetModelBazli(sModel, sonuc)
                            
                            If kayitSonuc Then
                                basarili += 1
                                SafeUpdateUI(Sub() AddLog($"  ✅ MODEL KAYDEDİLDİ (tüm varyantlar güncellendi)"))
                                modelBulundu = True
                                Exit For ' Bu model tamam, sonraki modele geç
                            Else
                                basarisiz += 1
                                SafeUpdateUI(Sub() AddLog($"  KAYIT HATASI"))
                                modelBulundu = True
                                Exit For
                            End If
                        Else
                            SafeUpdateUI(Sub() AddLog($"    Bulunamadı: {sonuc.HataMesaji}"))
                        End If
                    Next
                    
                    ' Tüm barkodlar denendi - sonucu değerlendir
                    If Not modelBulundu Then
                        ' Hiç eşleşme bulunamadı
                        bulunamadi += 1
                        SafeUpdateUI(Sub() AddLog($"  ❌ MODEL BULUNAMADI (tüm barkodlar denendi)"))
                        KategoriAtlaIsaretle(sModel, True)
                    End If
                    
                Catch ex As Exception
                    basarisiz += 1
                    Dim errMsg As String = ex.Message
                    SafeUpdateUI(Sub() AddLog($"  HATA: {errMsg}"))
                End Try
                
                SafeUpdateUI(Sub() progressBar.Value = currentIndex + 1)
            Next
            
            Dim finalBasarili As Integer = basarili
            Dim finalBulunamadi As Integer = bulunamadi
            Dim finalBasarisiz As Integer = basarisiz
            
            SafeUpdateUI(Sub()
                AddLog("")
                AddLog("=" & New String("="c, 50))
                AddLog("TOPLU İŞLEM TAMAMLANDI!")
                AddLog($"  Başarılı Model: {finalBasarili}")
                AddLog($"  Bulunamadı: {finalBulunamadi}")
                AddLog($"  Hata: {finalBasarisiz}")
                
                UpdateStatus($"Tamamlandı! Başarılı: {finalBasarili}, Bulunamadı: {finalBulunamadi}, Hata: {finalBasarisiz}", Color.Green)
                
                MessageBox.Show($"Toplu işlem tamamlandı!{vbCrLf}{vbCrLf}" &
                               $"Başarılı Model: {finalBasarili}{vbCrLf}" &
                               $"Bulunamadı: {finalBulunamadi}{vbCrLf}" &
                               $"Hata: {finalBasarisiz}",
                               "Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Sub)
            
        Catch ex As Exception
            Dim errMsg As String = ex.Message
            SafeUpdateUI(Sub()
                AddLog($"KRİTİK HATA: {errMsg}")
                UpdateStatus($"Hata: {errMsg}", Color.Red)
            End Sub)
        End Try
    End Sub
    
    ''' <summary>
    ''' Kategori eşleştirmesi yapılacak MODELLERİ getirir (her modelden 1 barkod)
    ''' </summary>
    Private Function GetUrunlerForKategori(maxCount As Integer, sadeceBosKategoriler As Boolean) As List(Of Dictionary(Of String, Object))
        Dim urunler As New List(Of Dictionary(Of String, Object))
        
        ' Parametrik sınıf eşleştirme ayarlarını oku
        Dim markaField As String = GetSinifEslemeAyar("ETICARET_SINIF_MARKA", "sSinifKodu3")
        Dim kat1Field As String = GetSinifEslemeAyar("ETICARET_SINIF_KAT1", "sSinifKodu4")
        
        Try
            Using conn As New OleDbConnection(connection)
                conn.Open()
                
                Dim sql As String
                
                If sadeceBosKategoriler Then
                    ' Kategorisi boş olan MODELler (her modelden 1 barkod al)
                    ' bKategoriAtla = 1 olan MODEL'leri tamamen atla
                    ' Kategori alanı PARAMETRİK
                    sql = $"SELECT TOP {maxCount} MIN(s.nStokID) AS nStokID, s.sModel, MIN(b.sBarkod) AS sBarkod, MIN(s.sAciklama) AS sAciklama " &
                          "FROM tbStok s " &
                          "INNER JOIN tbStokBarkodu b ON b.nStokID = s.nStokID AND b.nKisim = 0 " &
                          "LEFT JOIN tbStokSinifi si ON si.nStokID = s.nStokID " &
                          "WHERE s.bWebGoruntule = 1 " &
                          "AND s.sModel IS NOT NULL AND s.sModel <> '' " &
                          $"AND (si.{kat1Field} IS NULL OR si.{kat1Field} = '') " &
                          "AND NOT EXISTS (SELECT 1 FROM tbStok s2 INNER JOIN tbStokSinifi si2 ON si2.nStokID = s2.nStokID WHERE s2.sModel = s.sModel AND si2.bKategoriAtla = 1) " &
                          "GROUP BY s.sModel " &
                          "ORDER BY s.sModel"
                Else
                    ' Tüm web MODELleri (her modelden 1 barkod al)
                    ' bKategoriAtla = 1 olan MODEL'leri tamamen atla
                    sql = $"SELECT TOP {maxCount} MIN(s.nStokID) AS nStokID, s.sModel, MIN(b.sBarkod) AS sBarkod, MIN(s.sAciklama) AS sAciklama " &
                          "FROM tbStok s " &
                          "INNER JOIN tbStokBarkodu b ON b.nStokID = s.nStokID AND b.nKisim = 0 " &
                          "WHERE s.bWebGoruntule = 1 " &
                          "AND s.sModel IS NOT NULL AND s.sModel <> '' " &
                          "AND NOT EXISTS (SELECT 1 FROM tbStok s2 INNER JOIN tbStokSinifi si2 ON si2.nStokID = s2.nStokID WHERE s2.sModel = s.sModel AND si2.bKategoriAtla = 1) " &
                          "GROUP BY s.sModel " &
                          "ORDER BY s.sModel"
                End If
                
                Using cmd As New OleDbCommand(sql, conn)
                    Using reader As OleDbDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim urun As New Dictionary(Of String, Object)
                            Dim nStokID As Integer = Convert.ToInt32(reader("nStokID"))
                            urun("nStokID") = nStokID
                            urun("sModel") = If(IsDBNull(reader("sModel")), "", reader("sModel"))
                            urun("sBarkod") = If(IsDBNull(reader("sBarkod")), "", reader("sBarkod"))
                            
                            Dim aciklama As String = If(IsDBNull(reader("sAciklama")), "", reader("sAciklama").ToString())
                            urun("sAciklama") = aciklama
                            
                            ' MARKA: Sınıf eşleştirmesine göre PARAMETRİK al
                            Dim marka As String = ""
                            Try
                                If Not String.IsNullOrEmpty(markaField) AndAlso markaField.StartsWith("sSinifKodu") Then
                                    Dim sinifNo As String = markaField.Replace("sSinifKodu", "")
                                    Dim cmdMarka As New OleDbCommand(
                                        $"SELECT TOP 1 s.sAciklama FROM tbStokSinifi si " &
                                        $"INNER JOIN tbSSinif{sinifNo} s ON s.sSinifKodu = si.{markaField} " &
                                        $"WHERE si.nStokID = {nStokID}", conn)
                                    Dim result = cmdMarka.ExecuteScalar()
                                    If result IsNot Nothing AndAlso result IsNot DBNull.Value Then
                                        marka = result.ToString()
                                    End If
                                End If
                            Catch
                            End Try
                            
                            ' Marka bulunamadıysa fallback: sAciklama'daki ilk kelime
                            If String.IsNullOrWhiteSpace(marka) AndAlso Not String.IsNullOrWhiteSpace(aciklama) Then
                                Dim kelimeler() As String = aciklama.Trim().Split(New Char() {" "c}, StringSplitOptions.RemoveEmptyEntries)
                                If kelimeler.Length > 0 Then
                                    marka = kelimeler(0)
                                End If
                            End If
                            urun("sMarka") = marka
                            
                            If Not String.IsNullOrWhiteSpace(urun("sBarkod").ToString()) Then
                                urunler.Add(urun)
                            End If
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            AddLog($"Ürün sorgulama hatası: {ex.Message}")
        End Try
        
        Return urunler
    End Function
    
    ''' <summary>
    ''' Barkod'dan ürün bilgisini getirir (tek ürün işlemi için)
    ''' MARKA: sAciklama'daki ilk kelime marka olarak kabul edilir
    ''' </summary>
    Private Function GetUrunBilgisiByBarkod(barkod As String) As Dictionary(Of String, String)
        Dim bilgi As New Dictionary(Of String, String)
        bilgi("sAciklama") = ""
        bilgi("sMarka") = ""
        
        Try
            Using conn As New OleDbConnection(connection)
                conn.Open()
                
                ' Önce barkod'u kontrol et
                Dim sqlCheck As String = "SELECT COUNT(*) FROM tbStokBarkodu WHERE sBarkod = ?"
                Using cmdCheck As New OleDbCommand(sqlCheck, conn)
                    cmdCheck.Parameters.AddWithValue("?", barkod)
                    Dim count As Integer = Convert.ToInt32(cmdCheck.ExecuteScalar())
                    If count = 0 Then
                        AddLog($"  ⚠️ Bu barkod veritabanında yok!")
                        Return bilgi
                    End If
                End Using
                
                ' Ürün bilgisini çek - sadece sAciklama
                Dim sql As String = "SELECT TOP 1 s.sAciklama " &
                                   "FROM tbStok s " &
                                   "INNER JOIN tbStokBarkodu b ON b.nStokID = s.nStokID " &
                                   "WHERE b.sBarkod = ?"
                
                Using cmd As New OleDbCommand(sql, conn)
                    cmd.Parameters.AddWithValue("?", barkod)
                    
                    Using reader As OleDbDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            Dim aciklama As String = If(IsDBNull(reader("sAciklama")), "", reader("sAciklama").ToString())
                            bilgi("sAciklama") = aciklama
                            
                            ' MARKA: Sınıf eşleştirmesine göre al
                            Dim markaField As String = GetSinifEslemeAyar("ETICARET_SINIF_MARKA", "sSinifKodu3")
                            
                            ' Markanın çekilmesi için ayrı sorgu
                            Try
                                Dim markaSql As String = ""
                                If markaField.StartsWith("sSinifKodu") Then
                                    Dim sinifNo As String = markaField.Replace("sSinifKodu", "")
                                    markaSql = $"SELECT (SELECT sAciklama FROM tbSSinif{sinifNo} WHERE sSinifKodu = ss.{markaField}) AS Marka " &
                                              "FROM tbStok s " &
                                              "INNER JOIN tbStokBarkodu b ON b.nStokID = s.nStokID " &
                                              "LEFT JOIN tbStokSinifi ss ON ss.nStokID = s.nStokID " &
                                              "WHERE b.sBarkod = ?"
                                    Using cmdMarka As New OleDbCommand(markaSql, conn)
                                        cmdMarka.Parameters.AddWithValue("?", barkod)
                                        Dim marka As Object = cmdMarka.ExecuteScalar()
                                        If marka IsNot Nothing AndAlso marka IsNot DBNull.Value Then
                                            bilgi("sMarka") = marka.ToString()
                                        End If
                                    End Using
                                End If
                            Catch
                            End Try
                            
                            ' Marka bulunamadıysa ilk kelimeyi al
                            If Not bilgi.ContainsKey("sMarka") OrElse String.IsNullOrWhiteSpace(bilgi("sMarka").ToString()) Then
                                If Not String.IsNullOrWhiteSpace(aciklama) Then
                                    Dim kelimeler() As String = aciklama.Trim().Split(New Char() {" "c}, StringSplitOptions.RemoveEmptyEntries)
                                    If kelimeler.Length > 0 Then
                                        bilgi("sMarka") = kelimeler(0)
                                    End If
                                End If
                            End If
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            AddLog($"  ⚠️ Veritabanı hatası: {ex.Message}")
        End Try
        
        Return bilgi
    End Function
    
    ''' <summary>
    ''' Bir modele ait tüm barkodları getirir
    ''' </summary>
    Private Function GetModelBarkodlari(sModel As String) As List(Of String)
        Dim barkodlar As New List(Of String)
        
        Try
            Using conn As New OleDbConnection(connection)
                conn.Open()
                
                Dim sql As String = "SELECT DISTINCT b.sBarkod " &
                                    "FROM tbStok s " &
                                    "INNER JOIN tbStokBarkodu b ON b.nStokID = s.nStokID AND b.nKisim = 0 " &
                                    "WHERE s.sModel = ? AND b.sBarkod IS NOT NULL AND b.sBarkod <> ''"
                
                Using cmd As New OleDbCommand(sql, conn)
                    cmd.Parameters.AddWithValue("?", sModel)
                    Using reader As OleDbDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim barkod As String = reader("sBarkod").ToString().Trim()
                            If Not String.IsNullOrWhiteSpace(barkod) Then
                                barkodlar.Add(barkod)
                            End If
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            AddLog($"    Barkod sorgulama hatası: {ex.Message}")
        End Try
        
        Return barkodlar
    End Function
    
    ''' <summary>
    ''' Kategoriyi model bazlı kaydeder - o modele ait TÜM ürünleri günceller
    ''' PARAMETRİK sınıf eşleştirmesi kullanır
    ''' markaGuncelle = False ise marka alanına hiç dokunmaz
    ''' </summary>
    Private Function KategoriKaydetModelBazli(sModel As String, sonuc As TrendyolKategoriSonuc, Optional markaGuncelle As Boolean = True) As Boolean
        Try
            ' PARAMETRİK sınıf eşleştirme ayarlarını oku
            Dim markaFieldNo As String = GetSinifEslemeAyar("ETICARET_SINIF_MARKA", "sSinifKodu3").Replace("sSinifKodu", "")
            Dim kat1FieldNo As String = GetSinifEslemeAyar("ETICARET_SINIF_KAT1", "sSinifKodu4").Replace("sSinifKodu", "")
            Dim kat2FieldNo As String = GetSinifEslemeAyar("ETICARET_SINIF_KAT2", "sSinifKodu5").Replace("sSinifKodu", "")
            Dim kat3FieldNo As String = GetSinifEslemeAyar("ETICARET_SINIF_KAT3", "sSinifKodu6").Replace("sSinifKodu", "")
            
            Using conn As New OleDbConnection(connection)
                conn.Open()
                
                ' Bu modele ait tüm stok ID'lerini bul
                Dim stokIds As New List(Of Integer)
                Dim cmdStokIds As New OleDbCommand("SELECT nStokID FROM tbStok WHERE sModel = ?", conn)
                cmdStokIds.Parameters.AddWithValue("?", sModel)
                Using reader As OleDbDataReader = cmdStokIds.ExecuteReader()
                    While reader.Read()
                        stokIds.Add(Convert.ToInt32(reader("nStokID")))
                    End While
                End Using
                
                If stokIds.Count = 0 Then
                    AddLog($"    Model için stok kaydı bulunamadı: {sModel}")
                    Return False
                End If
                
                AddLog($"    {stokIds.Count} varyant kontrol ediliyor...")
                
                ' Her bir stok kaydı için tbStokSinifi güncelle
                For Each nStokID As Integer In stokIds
                    
                    ' Önce mevcut sınıf değerlerini al (PARAMETRİK alanlar)
                    Dim mevcutMarka As String = ""
                    Dim mevcutKat1 As String = ""
                    Dim mevcutKat2 As String = ""
                    Dim mevcutKat3 As String = ""
                    
                    Dim cmdMevcut As New OleDbCommand(
                        $"SELECT sSinifKodu{markaFieldNo}, sSinifKodu{kat1FieldNo}, sSinifKodu{kat2FieldNo}, sSinifKodu{kat3FieldNo} " &
                        "FROM tbStokSinifi WHERE nStokID = ?", conn)
                    cmdMevcut.Parameters.AddWithValue("?", nStokID)
                    
                    Dim kayitVar As Boolean = False
                    Using readerMevcut As OleDbDataReader = cmdMevcut.ExecuteReader()
                        If readerMevcut.Read() Then
                            kayitVar = True
                            mevcutMarka = If(readerMevcut(0) IsNot DBNull.Value, readerMevcut(0).ToString().Trim(), "")
                            mevcutKat1 = If(readerMevcut(1) IsNot DBNull.Value, readerMevcut(1).ToString().Trim(), "")
                            mevcutKat2 = If(readerMevcut(2) IsNot DBNull.Value, readerMevcut(2).ToString().Trim(), "")
                            mevcutKat3 = If(readerMevcut(3) IsNot DBNull.Value, readerMevcut(3).ToString().Trim(), "")
                        End If
                    End Using
                    
                    ' MARKA: Sadece markaGuncelle=True ve sonuc.Marka doluysa güncelle
                    ' markaGuncelle=False ise marka alanına HİÇ DOKUNMA
                    Dim yeniMarkaKod As String = mevcutMarka ' Varsayılan: mevcut değeri koru
                    If markaGuncelle AndAlso Not String.IsNullOrEmpty(sonuc.Marka) Then
                        ' Sadece mevcut boşsa veya sonuçta marka varsa güncelle
                        If String.IsNullOrEmpty(mevcutMarka) Then
                            yeniMarkaKod = EnsureSinifExists(conn, $"tbSSinif{markaFieldNo}", sonuc.Marka)
                        End If
                    End If
                    
                    ' KATEGORİLER: Mevcut boşsa yeni değeri yaz, doluysa koru
                    Dim yeniKat1Kod As String = If(String.IsNullOrEmpty(mevcutKat1) AndAlso Not String.IsNullOrEmpty(sonuc.Kategori1), 
                                                   EnsureSinifExists(conn, $"tbSSinif{kat1FieldNo}", sonuc.Kategori1), mevcutKat1)
                    Dim yeniKat2Kod As String = If(String.IsNullOrEmpty(mevcutKat2) AndAlso Not String.IsNullOrEmpty(sonuc.Kategori2), 
                                                   EnsureSinifExists(conn, $"tbSSinif{kat2FieldNo}", sonuc.Kategori2), mevcutKat2)
                    Dim yeniKat3Kod As String = If(String.IsNullOrEmpty(mevcutKat3) AndAlso Not String.IsNullOrEmpty(sonuc.Kategori3), 
                                                   EnsureSinifExists(conn, $"tbSSinif{kat3FieldNo}", sonuc.Kategori3), mevcutKat3)
                    
                    ' Değişiklik kontrolü - en az bir alan değişmeliyse güncelle
                    Dim markaFarkli As Boolean = (yeniMarkaKod <> mevcutMarka)
                    Dim kat1Farkli As Boolean = (yeniKat1Kod <> mevcutKat1)
                    Dim kat2Farkli As Boolean = (yeniKat2Kod <> mevcutKat2)
                    Dim kat3Farkli As Boolean = (yeniKat3Kod <> mevcutKat3)
                    
                    If Not markaFarkli AndAlso Not kat1Farkli AndAlso Not kat2Farkli AndAlso Not kat3Farkli Then
                        Continue For ' Bu ürün için değişiklik yok, atla
                    End If
                    
                    If kayitVar Then
                        ' UPDATE - PARAMETRİK alanları güncelle
                        Dim cmdUpdate As New OleDbCommand(
                            $"UPDATE tbStokSinifi SET sSinifKodu{markaFieldNo} = ?, sSinifKodu{kat1FieldNo} = ?, " &
                            $"sSinifKodu{kat2FieldNo} = ?, sSinifKodu{kat3FieldNo} = ?, bKategoriAtla = 1 WHERE nStokID = ?", conn)
                        cmdUpdate.Parameters.AddWithValue("?", yeniMarkaKod)
                        cmdUpdate.Parameters.AddWithValue("?", yeniKat1Kod)
                        cmdUpdate.Parameters.AddWithValue("?", yeniKat2Kod)
                        cmdUpdate.Parameters.AddWithValue("?", yeniKat3Kod)
                        cmdUpdate.Parameters.AddWithValue("?", nStokID)
                        cmdUpdate.ExecuteNonQuery()
                    Else
                        ' tbStokSinifi kaydı yok - INSERT yap
                        ' Önce boş bir kayıt oluştur
                        Dim cmdInsert As New OleDbCommand(
                            "INSERT INTO tbStokSinifi (nStokID, sSinifKodu1, sSinifKodu2, sSinifKodu3, sSinifKodu4, " &
                            "sSinifKodu5, sSinifKodu6, sSinifKodu7, sSinifKodu8, sSinifKodu9, sSinifKodu10, " &
                            "sSinifKodu11, sSinifKodu12, sSinifKodu13, sSinifKodu14, sSinifKodu15, sModel, bKategoriAtla) " &
                            "VALUES (?, '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', ?, 1)", conn)
                        cmdInsert.Parameters.AddWithValue("?", nStokID)
                        cmdInsert.Parameters.AddWithValue("?", sModel)
                        cmdInsert.ExecuteNonQuery()
                        
                        ' Sonra PARAMETRİK alanları güncelle
                        Dim cmdUpdateNew As New OleDbCommand(
                            $"UPDATE tbStokSinifi SET sSinifKodu{markaFieldNo} = ?, sSinifKodu{kat1FieldNo} = ?, " &
                            $"sSinifKodu{kat2FieldNo} = ?, sSinifKodu{kat3FieldNo} = ? WHERE nStokID = ?", conn)
                        cmdUpdateNew.Parameters.AddWithValue("?", yeniMarkaKod)
                        cmdUpdateNew.Parameters.AddWithValue("?", yeniKat1Kod)
                        cmdUpdateNew.Parameters.AddWithValue("?", yeniKat2Kod)
                        cmdUpdateNew.Parameters.AddWithValue("?", yeniKat3Kod)
                        cmdUpdateNew.Parameters.AddWithValue("?", nStokID)
                        cmdUpdateNew.ExecuteNonQuery()
                    End If
                Next
                
                Return True
            End Using
        Catch ex As Exception
            AddLog($"    Model bazlı kayıt hatası: {ex.Message}")
            Return False
        End Try
    End Function
    
    ''' <summary>
    ''' Trendyol kategorilerini veritabanına kaydeder (tek barkod için - eski fonksiyon)
    ''' </summary>
    Private Function KategoriKaydet(barkod As String, sonuc As TrendyolKategoriSonuc) As Boolean
        Try
            ' PARAMETRİK sınıf eşleştirme ayarlarını oku
            Dim markaFieldNo As String = GetSinifEslemeAyar("ETICARET_SINIF_MARKA", "sSinifKodu3").Replace("sSinifKodu", "")
            Dim kat1FieldNo As String = GetSinifEslemeAyar("ETICARET_SINIF_KAT1", "sSinifKodu4").Replace("sSinifKodu", "")
            Dim kat2FieldNo As String = GetSinifEslemeAyar("ETICARET_SINIF_KAT2", "sSinifKodu5").Replace("sSinifKodu", "")
            Dim kat3FieldNo As String = GetSinifEslemeAyar("ETICARET_SINIF_KAT3", "sSinifKodu6").Replace("sSinifKodu", "")
            
            Using conn As New OleDbConnection(connection)
                conn.Open()
                
                ' Barkod ile nStokID ve sModel bul
                Dim cmdStok As New OleDbCommand(
                    "SELECT s.nStokID, s.sModel FROM tbStok s " &
                    "INNER JOIN tbStokBarkodu b ON b.nStokID = s.nStokID " &
                    "WHERE b.sBarkod = ? AND b.nKisim = 0", conn)
                cmdStok.Parameters.AddWithValue("?", barkod)
                
                Dim nStokID As Integer = 0
                Dim sModel As String = ""
                
                Using reader As OleDbDataReader = cmdStok.ExecuteReader()
                    If reader.Read() Then
                        nStokID = Convert.ToInt32(reader("nStokID"))
                        sModel = If(IsDBNull(reader("sModel")), "", reader("sModel").ToString())
                    Else
                        AddLog($"  Barkod veritabanında bulunamadı: {barkod}")
                        Return False
                    End If
                End Using
                
                ' 1. Veritabanındaki mevcut marka açıklamasını al (PARAMETRİK alan)
                Dim mevcutMarkaAciklama As String = ""
                Dim cmdMevcutMarka As New OleDbCommand(
                    $"SELECT m.sAciklama FROM tbStokSinifi si " &
                    $"INNER JOIN tbSSinif{markaFieldNo} m ON m.sSinifKodu = si.sSinifKodu{markaFieldNo} " &
                    $"WHERE si.nStokID = ? AND si.sSinifKodu{markaFieldNo} IS NOT NULL AND si.sSinifKodu{markaFieldNo} <> ''", conn)
                cmdMevcutMarka.Parameters.AddWithValue("?", nStokID)
                Dim mevcutMarkaObj As Object = cmdMevcutMarka.ExecuteScalar()
                If mevcutMarkaObj IsNot Nothing AndAlso Not IsDBNull(mevcutMarkaObj) Then
                    mevcutMarkaAciklama = mevcutMarkaObj.ToString().Trim()
                End If
                
                ' 2. Marka öncelik sırası: mevcutMarka > Trendyol markası
                Dim kullanilanMarka As String = ""
                If Not String.IsNullOrEmpty(mevcutMarkaAciklama) Then
                    kullanilanMarka = mevcutMarkaAciklama
                ElseIf Not String.IsNullOrEmpty(sonuc.Marka) Then
                    kullanilanMarka = sonuc.Marka
                End If
                
                ' Önce tbSSinif tablolarına kategorileri ekle (yoksa) - PARAMETRİK
                Dim yeniMarkaKod As String = EnsureSinifExists(conn, $"tbSSinif{markaFieldNo}", kullanilanMarka)
                Dim yeniKat1Kod As String = EnsureSinifExists(conn, $"tbSSinif{kat1FieldNo}", sonuc.Kategori1)
                Dim yeniKat2Kod As String = EnsureSinifExists(conn, $"tbSSinif{kat2FieldNo}", sonuc.Kategori2)
                Dim yeniKat3Kod As String = EnsureSinifExists(conn, $"tbSSinif{kat3FieldNo}", sonuc.Kategori3)
                
                ' tbStokSinifi'ni güncelle
                Dim cmdCheck As New OleDbCommand("SELECT COUNT(*) FROM tbStokSinifi WHERE nStokID = ?", conn)
                cmdCheck.Parameters.AddWithValue("?", nStokID)
                Dim exists As Integer = Convert.ToInt32(cmdCheck.ExecuteScalar())
                
                If exists > 0 Then
                    ' UPDATE - PARAMETRİK alanları güncelle
                    Dim cmdUpdate As New OleDbCommand(
                        $"UPDATE tbStokSinifi SET sSinifKodu{markaFieldNo} = ?, sSinifKodu{kat1FieldNo} = ?, " &
                        $"sSinifKodu{kat2FieldNo} = ?, sSinifKodu{kat3FieldNo} = ? WHERE nStokID = ?", conn)
                    cmdUpdate.Parameters.AddWithValue("?", yeniMarkaKod)
                    cmdUpdate.Parameters.AddWithValue("?", yeniKat1Kod)
                    cmdUpdate.Parameters.AddWithValue("?", yeniKat2Kod)
                    cmdUpdate.Parameters.AddWithValue("?", yeniKat3Kod)
                    cmdUpdate.Parameters.AddWithValue("?", nStokID)
                    cmdUpdate.ExecuteNonQuery()
                Else
                    ' tbStokSinifi kaydı yok - INSERT yap ve PARAMETRİK alanları güncelle
                    Dim cmdInsert As New OleDbCommand(
                        "INSERT INTO tbStokSinifi (nStokID, sSinifKodu1, sSinifKodu2, sSinifKodu3, sSinifKodu4, " &
                        "sSinifKodu5, sSinifKodu6, sSinifKodu7, sSinifKodu8, sSinifKodu9, sSinifKodu10, " &
                        "sSinifKodu11, sSinifKodu12, sSinifKodu13, sSinifKodu14, sSinifKodu15, sModel) " &
                        "VALUES (?, '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', ?)", conn)
                    cmdInsert.Parameters.AddWithValue("?", nStokID)
                    cmdInsert.Parameters.AddWithValue("?", sModel)
                    cmdInsert.ExecuteNonQuery()
                    
                    ' Sonra PARAMETRİK alanları güncelle
                    Dim cmdUpdateNew As New OleDbCommand(
                        $"UPDATE tbStokSinifi SET sSinifKodu{markaFieldNo} = ?, sSinifKodu{kat1FieldNo} = ?, " &
                        $"sSinifKodu{kat2FieldNo} = ?, sSinifKodu{kat3FieldNo} = ? WHERE nStokID = ?", conn)
                    cmdUpdateNew.Parameters.AddWithValue("?", yeniMarkaKod)
                    cmdUpdateNew.Parameters.AddWithValue("?", yeniKat1Kod)
                    cmdUpdateNew.Parameters.AddWithValue("?", yeniKat2Kod)
                    cmdUpdateNew.Parameters.AddWithValue("?", yeniKat3Kod)
                    cmdUpdateNew.Parameters.AddWithValue("?", nStokID)
                    cmdUpdateNew.ExecuteNonQuery()
                End If
                
                Return True
            End Using
        Catch ex As Exception
            AddLog($"  Kayıt hatası: {ex.Message}")
            Return False
        End Try
    End Function
    
    ''' <summary>
    ''' Trendyol kategorilerini model ve renk bazlı kaydeder (yeni toplu işlem için)
    ''' PARAMETRİK sınıf eşleştirmesi kullanır
    ''' </summary>
    Private Function KategoriKaydet(sModel As String, sRenk As String, sonuc As TrendyolKategoriSonuc) As Boolean
        Try
            ' PARAMETRİK sınıf eşleştirme ayarlarını oku
            Dim markaFieldNo As String = GetSinifEslemeAyar("ETICARET_SINIF_MARKA", "sSinifKodu3").Replace("sSinifKodu", "")
            Dim kat1FieldNo As String = GetSinifEslemeAyar("ETICARET_SINIF_KAT1", "sSinifKodu4").Replace("sSinifKodu", "")
            Dim kat2FieldNo As String = GetSinifEslemeAyar("ETICARET_SINIF_KAT2", "sSinifKodu5").Replace("sSinifKodu", "")
            Dim kat3FieldNo As String = GetSinifEslemeAyar("ETICARET_SINIF_KAT3", "sSinifKodu6").Replace("sSinifKodu", "")
            
            Using conn As New OleDbConnection(connection)
                conn.Open()
                
                ' Model ve renk ile nStokID bul
                Dim cmdStok As New OleDbCommand(
                    "SELECT nStokID FROM tbStok WHERE sModel = ? AND sRenk = ?", conn)
                cmdStok.Parameters.AddWithValue("?", sModel)
                cmdStok.Parameters.AddWithValue("?", sRenk)
                
                Dim nStokID As Integer = 0
                
                Using reader As OleDbDataReader = cmdStok.ExecuteReader()
                    If reader.Read() Then
                        nStokID = Convert.ToInt32(reader("nStokID"))
                    Else
                        AddLog($"  Model-Renk veritabanında bulunamadı: {sModel}-{sRenk}")
                        Return False
                    End If
                End Using
                
                ' 1. Veritabanındaki mevcut marka açıklamasını al (PARAMETRİK alan)
                Dim mevcutMarkaAciklama As String = ""
                Dim cmdMevcutMarka As New OleDbCommand(
                    $"SELECT m.sAciklama FROM tbStokSinifi si " &
                    $"INNER JOIN tbSSinif{markaFieldNo} m ON m.sSinifKodu = si.sSinifKodu{markaFieldNo} " &
                    $"WHERE si.nStokID = ? AND si.sSinifKodu{markaFieldNo} IS NOT NULL AND si.sSinifKodu{markaFieldNo} <> ''", conn)
                cmdMevcutMarka.Parameters.AddWithValue("?", nStokID)
                Dim mevcutMarkaObj As Object = cmdMevcutMarka.ExecuteScalar()
                If mevcutMarkaObj IsNot Nothing AndAlso Not IsDBNull(mevcutMarkaObj) Then
                    mevcutMarkaAciklama = mevcutMarkaObj.ToString().Trim()
                End If
                
                ' 2. Marka öncelik sırası: mevcutMarka > Trendyol markası
                Dim kullanilanMarka As String = ""
                If Not String.IsNullOrEmpty(mevcutMarkaAciklama) Then
                    kullanilanMarka = mevcutMarkaAciklama
                ElseIf Not String.IsNullOrEmpty(sonuc.Marka) Then
                    kullanilanMarka = sonuc.Marka
                End If
                
                ' Önce tbSSinif tablolarına kategorileri ekle (yoksa) - PARAMETRİK
                Dim yeniMarkaKod As String = EnsureSinifExists(conn, $"tbSSinif{markaFieldNo}", kullanilanMarka)
                Dim yeniKat1Kod As String = EnsureSinifExists(conn, $"tbSSinif{kat1FieldNo}", sonuc.Kategori1)
                Dim yeniKat2Kod As String = EnsureSinifExists(conn, $"tbSSinif{kat2FieldNo}", sonuc.Kategori2)
                Dim yeniKat3Kod As String = EnsureSinifExists(conn, $"tbSSinif{kat3FieldNo}", sonuc.Kategori3)
                
                ' tbStokSinifi'ni güncelle
                Dim cmdCheck As New OleDbCommand("SELECT COUNT(*) FROM tbStokSinifi WHERE nStokID = ?", conn)
                cmdCheck.Parameters.AddWithValue("?", nStokID)
                Dim exists As Integer = Convert.ToInt32(cmdCheck.ExecuteScalar())
                
                If exists > 0 Then
                    ' UPDATE - PARAMETRİK alanları güncelle
                    Dim cmdUpdate As New OleDbCommand(
                        $"UPDATE tbStokSinifi SET sSinifKodu{markaFieldNo} = ?, sSinifKodu{kat1FieldNo} = ?, " &
                        $"sSinifKodu{kat2FieldNo} = ?, sSinifKodu{kat3FieldNo} = ? WHERE nStokID = ?", conn)
                    cmdUpdate.Parameters.AddWithValue("?", yeniMarkaKod)
                    cmdUpdate.Parameters.AddWithValue("?", yeniKat1Kod)
                    cmdUpdate.Parameters.AddWithValue("?", yeniKat2Kod)
                    cmdUpdate.Parameters.AddWithValue("?", yeniKat3Kod)
                    cmdUpdate.Parameters.AddWithValue("?", nStokID)
                    cmdUpdate.ExecuteNonQuery()
                Else
                    ' tbStokSinifi kaydı yok - INSERT yap ve PARAMETRİK alanları güncelle
                    Dim cmdInsert As New OleDbCommand(
                        "INSERT INTO tbStokSinifi (nStokID, sSinifKodu1, sSinifKodu2, sSinifKodu3, sSinifKodu4, " &
                        "sSinifKodu5, sSinifKodu6, sSinifKodu7, sSinifKodu8, sSinifKodu9, sSinifKodu10, " &
                        "sSinifKodu11, sSinifKodu12, sSinifKodu13, sSinifKodu14, sSinifKodu15, sModel) " &
                        "VALUES (?, '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', ?)", conn)
                    cmdInsert.Parameters.AddWithValue("?", nStokID)
                    cmdInsert.Parameters.AddWithValue("?", sModel)
                    cmdInsert.ExecuteNonQuery()
                    
                    ' Sonra PARAMETRİK alanları güncelle
                    Dim cmdUpdateNew As New OleDbCommand(
                        $"UPDATE tbStokSinifi SET sSinifKodu{markaFieldNo} = ?, sSinifKodu{kat1FieldNo} = ?, " &
                        $"sSinifKodu{kat2FieldNo} = ?, sSinifKodu{kat3FieldNo} = ? WHERE nStokID = ?", conn)
                    cmdUpdateNew.Parameters.AddWithValue("?", yeniMarkaKod)
                    cmdUpdateNew.Parameters.AddWithValue("?", yeniKat1Kod)
                    cmdUpdateNew.Parameters.AddWithValue("?", yeniKat2Kod)
                    cmdUpdateNew.Parameters.AddWithValue("?", yeniKat3Kod)
                    cmdUpdateNew.Parameters.AddWithValue("?", nStokID)
                    cmdUpdateNew.ExecuteNonQuery()
                End If
                
                Return True
            End Using
        Catch ex As Exception
            AddLog($"  Model-Renk kayıt hatası: {ex.Message}")
            Return False
        End Try
    End Function
    
    ''' <summary>
    ''' tbSSinif tablosunda kategori yoksa ekler, varsa kodunu döndürür
    ''' </summary>
    Private Function EnsureSinifExists(conn As OleDbConnection, tableName As String, kategoriAdi As String) As String
        ' Eğer kategori adı boşsa, boş string döndür (uygulama boş string kabul ediyor)
        If String.IsNullOrWhiteSpace(kategoriAdi) Then Return ""
        
        Try
            ' Önce var mı kontrol et (açıklamaya göre)
            Dim cmdCheck As New OleDbCommand($"SELECT sSinifKodu FROM {tableName} WHERE sAciklama = ?", conn)
            cmdCheck.Parameters.AddWithValue("?", kategoriAdi)
            Dim existing As Object = cmdCheck.ExecuteScalar()
            
            If existing IsNot Nothing AndAlso Not IsDBNull(existing) Then
                Return existing.ToString()
            End If
            
            ' Yoksa yeni kod oluştur ve ekle
            Dim cmdMaxKod As New OleDbCommand($"SELECT MAX(CAST(sSinifKodu AS INT)) FROM {tableName} WHERE ISNUMERIC(sSinifKodu) = 1", conn)
            Dim maxKodObj As Object = Nothing
            Try
                maxKodObj = cmdMaxKod.ExecuteScalar()
            Catch
                ' ISNUMERIC yoksa alternatif sorgu
                Dim cmdMax2 As New OleDbCommand($"SELECT MAX(sSinifKodu) FROM {tableName}", conn)
                maxKodObj = cmdMax2.ExecuteScalar()
            End Try
            
            Dim yeniKod As String
            If maxKodObj Is Nothing OrElse IsDBNull(maxKodObj) OrElse String.IsNullOrWhiteSpace(maxKodObj.ToString()) Then
                yeniKod = "001"
            Else
                Dim maxNum As Integer = 0
                Integer.TryParse(maxKodObj.ToString(), maxNum)
                yeniKod = (maxNum + 1).ToString("D3")
            End If
            
            ' INSERT yapmadan önce bu kod var mı kontrol et (race condition için)
            Dim cmdCheckKod As New OleDbCommand($"SELECT COUNT(*) FROM {tableName} WHERE sSinifKodu = ?", conn)
            cmdCheckKod.Parameters.AddWithValue("?", yeniKod)
            Dim kodVar As Integer = CInt(cmdCheckKod.ExecuteScalar())
            
            If kodVar > 0 Then
                ' Kod zaten var, bir sonrakini dene
                Dim num As Integer = 0
                Integer.TryParse(yeniKod, num)
                yeniKod = (num + 1).ToString("D3")
            End If
            
            ' Ekle
            Dim cmdInsert As New OleDbCommand($"INSERT INTO {tableName} (sSinifKodu, sAciklama) VALUES (?, ?)", conn)
            cmdInsert.Parameters.AddWithValue("?", yeniKod)
            cmdInsert.Parameters.AddWithValue("?", kategoriAdi)
            cmdInsert.ExecuteNonQuery()
            
            AddLog($"  Yeni kategori eklendi: {tableName} -> {yeniKod} ({kategoriAdi})")
            
            Return yeniKod
            
        Catch ex As Exception
            ' Hata durumunda tekrar kontrol et - belki başka bir thread eklemiştir
            Try
                Dim cmdRecheck As New OleDbCommand($"SELECT sSinifKodu FROM {tableName} WHERE sAciklama = ?", conn)
                cmdRecheck.Parameters.AddWithValue("?", kategoriAdi)
                Dim recheck As Object = cmdRecheck.ExecuteScalar()
                If recheck IsNot Nothing AndAlso Not IsDBNull(recheck) Then
                    Return recheck.ToString()
                End If
            Catch
            End Try
            
            AddLog($"  Kategori ekleme hatası ({tableName}): {ex.Message}")
            Return ""
        End Try
    End Function
    
    ''' <summary>
    ''' Ürün eşleşmesinin doğru olup olmadığını kontrol eder
    ''' Bizim ürün açıklamamız ile Trendyol'dan gelen ürün adı/kategori karşılaştırılır
    ''' RENK KELİMELERİ YOKSAYILIR - BASİTLEŞTİRİLMİŞ VERSİYON
    ''' </summary>
    Private Function UrunEslesmesiDogruMu(bizimAciklama As String, trendyolUrunAdi As String, trendyolKategori As String) As Boolean
        If String.IsNullOrWhiteSpace(bizimAciklama) Then Return True
        If String.IsNullOrWhiteSpace(trendyolUrunAdi) AndAlso String.IsNullOrWhiteSpace(trendyolKategori) Then Return True
        
        ' Tüm metinleri normalize et (küçük harf, Türkçe karakter, nokta/tire kaldır, renkler çıkar)
        Dim bizim As String = TamNormalize(bizimAciklama)
        Dim trendyol As String = TamNormalize(trendyolUrunAdi & " " & trendyolKategori)
        
        ' Bizim açıklamamızdan anahtar kelimeleri çıkar (en az 3 karakter)
        Dim bizimKelimeler As String() = bizim.Split(New Char() {" "c}, StringSplitOptions.RemoveEmptyEntries)
        Dim eslesenSayi As Integer = 0
        Dim kontrolEdilenSayi As Integer = 0
        
        For Each kelime As String In bizimKelimeler
            If kelime.Length >= 3 AndAlso Not IsNumeric(kelime) AndAlso Not IsGenelKelime(kelime) Then
                kontrolEdilenSayi += 1
                If trendyol.Contains(kelime) Then
                    eslesenSayi += 1
                End If
            End If
        Next
        
        ' Hiç kontrol edilen kelime yoksa kabul et
        If kontrolEdilenSayi = 0 Then Return True
        
        ' En az 1 kelime eşleşmeli
        If eslesenSayi = 0 Then Return False
        
        ' ÖNEMLİ: Giyim ürünü yasaklı kategoride mi kontrol et
        Dim yassakKategoriler As String() = {
            "otomotiv", "araba", "arac", "balata", "motor", "yag", "filtre", "parca", "lastik", "aku",
            "elektronik", "telefon", "bilgisayar", "tablet", "hoparlor",
            "mobilya", "mutfak", "banyo", "dekorasyon", "hali", "perde",
            "gida", "icecek", "yiyecek", "supermarket", "market",
            "saglik", "medikal", "ilac", "vitamin", "takviye", "eczane",
            "kozmetik", "parfum", "makyaj",
            "oyuncak", "hobi", "kitap", "kirtasiye",
            "bahce", "yapi", "hirdavat",
            "pet", "mama", "kedi", "kopek",
            "endustriyel", "makine", "kablo", "pil"
        }
        
        ' Eğer bizim ürün giyim ise (mont, pijama, elbise vb. içeriyorsa)
        Dim giyimKelimeleri As String() = {"mont", "kaban", "ceket", "pijama", "elbise", "pantolon", 
                                            "gomlek", "tisort", "sort", "etek", "esofman", "takim",
                                            "ayakkabi", "bot", "terlik", "corap"}
        
        Dim bizimGiyim As Boolean = False
        For Each giyim As String In giyimKelimeleri
            If bizim.Contains(giyim) Then
                bizimGiyim = True
                Exit For
            End If
        Next
        
        ' Giyim ürünü yasaklı kategoride mi?
        If bizimGiyim Then
            For Each yasak As String In yassakKategoriler
                If trendyol.Contains(yasak) Then
                    Return False
                End If
            Next
        End If
        
        Return True
    End Function
    
    ''' <summary>
    ''' Tam normalize - küçük harf, Türkçe karakter, nokta/tire kaldır, renkleri çıkar
    ''' </summary>
    Private Function TamNormalize(text As String) As String
        If String.IsNullOrWhiteSpace(text) Then Return ""
        
        Dim result As String = text.ToLower()
        
        ' Türkçe karakterleri dönüştür
        result = result.Replace("ı", "i").Replace("ğ", "g").Replace("ü", "u")
        result = result.Replace("ş", "s").Replace("ö", "o").Replace("ç", "c")
        result = result.Replace("İ", "i").Replace("Ğ", "g").Replace("Ü", "u")
        result = result.Replace("Ş", "s").Replace("Ö", "o").Replace("Ç", "c")
        
        ' Nokta, tire ve özel karakterleri boşluğa çevir
        result = result.Replace(".", " ").Replace("-", " ").Replace("_", " ")
        result = result.Replace("/", " ").Replace(",", " ").Replace("&", " ")
        
        ' Renkleri çıkar
        Dim renkler As String() = {"beyaz", "siyah", "kirmizi", "mavi", "yesil", "sari", "turuncu", 
                                    "mor", "pembe", "gri", "kahverengi", "lacivert", "bej", "krem",
                                    "bordo", "antrasit", "ekru", "fusya", "turkuaz", "haki",
                                    "white", "black", "red", "blue", "green", "yellow", "orange",
                                    "purple", "pink", "gray", "grey", "brown", "navy", "beige"}
        For Each renk As String In renkler
            result = result.Replace(" " & renk & " ", " ")
            If result.StartsWith(renk & " ") Then result = result.Substring(renk.Length + 1)
            If result.EndsWith(" " & renk) Then result = result.Substring(0, result.Length - renk.Length - 1)
        Next
        
        ' Çoklu boşlukları tek boşluğa indir
        While result.Contains("  ")
            result = result.Replace("  ", " ")
        End While
        
        Return result.Trim()
    End Function
    
    ''' <summary>
    ''' Metni normalize eder - küçük harf, Türkçe karakter dönüşümü
    ''' </summary>
    Private Function NormalizeText(text As String) As String
        If String.IsNullOrWhiteSpace(text) Then Return ""
        
        Dim result As String = text.ToLower()
        result = result.Replace("ı", "i").Replace("ğ", "g").Replace("ü", "u")
        result = result.Replace("ş", "s").Replace("ö", "o").Replace("ç", "c")
        result = result.Replace("İ", "i").Replace("Ğ", "g").Replace("Ü", "u")
        result = result.Replace("Ş", "s").Replace("Ö", "o").Replace("Ç", "c")
        
        Return result
    End Function
    
    ''' <summary>
    ''' Genel/yaygın kelimeleri kontrol eder (bunlar eşleşme için kullanılmaz)
    ''' </summary>
    Private Function IsGenelKelime(kelime As String) As Boolean
        Dim genelKelimeler As String() = {"ile", "icin", "veya", "urun", "yeni", "ozel", "super", 
                                           "kalite", "kaliteli", "orjinal", "original", "marka"}
        Return Array.IndexOf(genelKelimeler, kelime) >= 0
    End Function
    
    ''' <summary>
    ''' Bir modelin tüm varyantları için bKategoriAtla değerini ayarlar
    ''' Eğer tbStokSinifi'de kayıt yoksa önce INSERT yapar
    ''' </summary>
    Private Sub KategoriAtlaIsaretle(sModel As String, atla As Boolean)
        Try
            Using conn As New OleDbConnection(connection)
                conn.Open()
                
                ' Bu modele ait tüm stok ID'lerini al
                Dim stokIds As New List(Of Integer)
                Dim cmdGetIds As New OleDbCommand("SELECT nStokID FROM tbStok WHERE sModel = ?", conn)
                cmdGetIds.Parameters.AddWithValue("?", sModel)
                Using reader As OleDbDataReader = cmdGetIds.ExecuteReader()
                    While reader.Read()
                        stokIds.Add(Convert.ToInt32(reader("nStokID")))
                    End While
                End Using
                
                ' Her stok için tbStokSinifi kaydını kontrol et ve güncelle/ekle
                For Each nStokID As Integer In stokIds
                    ' Kayıt var mı kontrol et
                    Dim cmdCheck As New OleDbCommand("SELECT COUNT(*) FROM tbStokSinifi WHERE nStokID = ?", conn)
                    cmdCheck.Parameters.AddWithValue("?", nStokID)
                    Dim exists As Integer = Convert.ToInt32(cmdCheck.ExecuteScalar())
                    
                    If exists > 0 Then
                        ' UPDATE - sadece bKategoriAtla güncelle
                        Dim cmdUpdate As New OleDbCommand(
                            "UPDATE tbStokSinifi SET bKategoriAtla = ? WHERE nStokID = ?", conn)
                        cmdUpdate.Parameters.AddWithValue("?", If(atla, 1, 0))
                        cmdUpdate.Parameters.AddWithValue("?", nStokID)
                        cmdUpdate.ExecuteNonQuery()
                    Else
                        ' INSERT - yeni kayıt oluştur (boş stringlerle, sadece bKategoriAtla set)
                        Dim cmdInsert As New OleDbCommand(
                            "INSERT INTO tbStokSinifi (nStokID, sSinifKodu1, sSinifKodu2, sSinifKodu3, sSinifKodu4, " &
                            "sSinifKodu5, sSinifKodu6, sSinifKodu7, sSinifKodu8, sSinifKodu9, sSinifKodu10, " &
                            "sSinifKodu11, sSinifKodu12, sSinifKodu13, sSinifKodu14, sSinifKodu15, sModel, bKategoriAtla) " &
                            "VALUES (?, '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', ?, ?)", conn)
                        cmdInsert.Parameters.AddWithValue("?", nStokID)
                        cmdInsert.Parameters.AddWithValue("?", sModel)
                        cmdInsert.Parameters.AddWithValue("?", If(atla, 1, 0))
                        cmdInsert.ExecuteNonQuery()
                        AddLog($"    tbStokSinifi'ye yeni kayıt eklendi: nStokID={nStokID}")
                    End If
                Next
                
                AddLog($"  bKategoriAtla = {If(atla, "1 (ATLA)", "0")} olarak işaretlendi ({stokIds.Count} varyant)")
                
            End Using
        Catch ex As Exception
            AddLog($"  bKategoriAtla güncelleme hatası: {ex.Message}")
        End Try
    End Sub
    
    Private Sub UpdateStatus(text As String, color As Color)
        lblDurum.Text = text
        lblDurum.ForeColor = color
        Application.DoEvents()
    End Sub
    
    Private Sub AddLog(message As String)
        Dim timestamp As String = DateTime.Now.ToString("HH:mm:ss")
        lstLog.Items.Insert(0, $"[{timestamp}] {message}")
        
        If lstLog.Items.Count > 500 Then
            lstLog.Items.RemoveAt(lstLog.Items.Count - 1)
        End If
        
        Application.DoEvents()
    End Sub
    
    ''' <summary>
    ''' Kategori bilgilerini veritabanına kaydet (Model-Renk ile)
    ''' </summary>

    ''' <summary>
    ''' Seçili ürünlerin tüm sınıf kodlarını (sSinifKodu1-15) boşaltır
    ''' tbStokSinifi tablosundan kaydı silmez, sadece sınıf alanlarını '' yapar
    ''' </summary>
    ''' <summary>
    ''' Seçili ürünlerin tüm sınıf kodlarını (sSinifKodu1-15) boşaltır
    ''' Hiç seçim yoksa tüm listedeki ürünler için işlem yapar
    ''' tbStokSinifi tablosundan kaydı silmez, sadece sınıf alanlarını '' yapar
    ''' </summary>
    Private Sub btnSiniflariSil_Click(sender As Object, e As EventArgs) Handles btnSiniflariSil.Click
        Try
            ' Önce grid'in DataSource'unun null olup olmadığını kontrol et
            Dim gridBos As Boolean = (dgvUrunler.DataSource Is Nothing OrElse dgvUrunler.Rows.Count = 0)
            
            ' Seçili satırları bul (grid boş değilse)
            Dim seciliSatirlar As New List(Of Integer)
            If Not gridBos Then
                For i As Integer = 0 To dgvUrunler.Rows.Count - 1
                    Dim chkCell As DataGridViewCheckBoxCell = CType(dgvUrunler.Rows(i).Cells("colSecim"), DataGridViewCheckBoxCell)
                    If chkCell.Value IsNot Nothing AndAlso CBool(chkCell.Value) = True Then
                        seciliSatirlar.Add(i)
                    End If
                Next
            End If
            
            Dim tumListeIcinMi As Boolean = False
            Dim tumVeritabaniIcinMi As Boolean = False
            
            ' Grid tamamen boşsa, veritabanındaki tüm bWebGoruntule=1 ürünler için sor
            If gridBos Then
                Dim sonucDB As DialogResult = MessageBox.Show(
                    "Listede hiç ürün yok." & vbCrLf & vbCrLf & 
                    "VERİTABANINDAKİ TÜM 'Web'de Görüntüle' aktif (bWebGoruntule=True) ürünlerin " & _
                    "sınıf kodlarını (sSinifKodu1-15) temizlemek ister misiniz?" & vbCrLf & vbCrLf &
                    "⚠️ DİKKAT: Bu işlem çok sayıda ürünü etkileyebilir!",
                    "Tüm Sınıfları Sil - Veritabanı Geneli",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning)
                
                If sonucDB <> DialogResult.Yes Then
                    Return
                End If
                tumVeritabaniIcinMi = True
                
            ' Hiç seçim yoksa tüm liste için sor
            ElseIf seciliSatirlar.Count = 0 Then
                Dim sonucTum As DialogResult = MessageBox.Show(
                    $"Hiç ürün seçilmedi." & vbCrLf & vbCrLf & 
                    $"Listedeki TÜM {dgvUrunler.Rows.Count} ürünün sınıflarını silmek ister misiniz?",
                    "Tüm Sınıfları Sil",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question)
                
                If sonucTum <> DialogResult.Yes Then
                    Return
                End If
                
                ' Tüm satırları ekle
                For i As Integer = 0 To dgvUrunler.Rows.Count - 1
                    seciliSatirlar.Add(i)
                Next
                tumListeIcinMi = True
            End If
            
            ' Veritabanı genelinde işlem yapılacaksa
            If tumVeritabaniIcinMi Then
                VeritabaniGeneliSiniflariSil()
                Return
            End If
            
            ' Son onay al
            Dim mesaj As String = If(tumListeIcinMi, 
                $"LİSTEDEKİ TÜM {seciliSatirlar.Count} ürünün sınıf kodları (sSinifKodu1-15) silinecek.",
                $"Seçili {seciliSatirlar.Count} ürünün sınıf kodları (sSinifKodu1-15) silinecek.")
            
            Dim sonuc As DialogResult = MessageBox.Show(
                mesaj & vbCrLf & vbCrLf & 
                "⚠️ Bu işlem geri alınamaz! Devam etmek istiyor musunuz?",
                "Tüm Sınıfları Sil - Son Onay",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning)
            
            If sonuc <> DialogResult.Yes Then
                Return
            End If
            
            AddLog("═══════════════════════════════════════")
            AddLog(If(tumListeIcinMi, "🗑 TÜM LİSTENİN SINIFLARI SİLİNİYOR", "🗑 SEÇİLİ ÜRÜNLERİN SINIFLARI SİLİNİYOR"))
            AddLog("═══════════════════════════════════════")
            
            Dim basarili As Integer = 0
            Dim hatali As Integer = 0
            
            Using conn As New OleDbConnection(connection)
                conn.Open()
                
                ' Her satır için işlem yap
                For Each satirIdx As Integer In seciliSatirlar
                    Try
                        Dim sModel As String = dgvUrunler.Rows(satirIdx).Cells("colModel").Value.ToString()
                        
                        ' Bu modele ait tüm stok ID'lerini al
                        Dim cmdGetIds As New OleDbCommand("SELECT nStokID FROM tbStok WHERE sModel = ?", conn)
                        cmdGetIds.Parameters.AddWithValue("?", sModel)
                        
                        Dim stokIds As New List(Of Integer)
                        Using reader As OleDbDataReader = cmdGetIds.ExecuteReader()
                            While reader.Read()
                                stokIds.Add(Convert.ToInt32(reader("nStokID")))
                            End While
                        End Using
                        
                        ' Her stok için sınıf kodlarını boşalt
                        For Each nStokID As Integer In stokIds
                            ' Kayıt var mı kontrol et
                            Dim cmdCheck As New OleDbCommand("SELECT COUNT(*) FROM tbStokSinifi WHERE nStokID = ?", conn)
                            cmdCheck.Parameters.AddWithValue("?", nStokID)
                            Dim exists As Integer = Convert.ToInt32(cmdCheck.ExecuteScalar())
                            
                            If exists > 0 Then
                                ' UPDATE - tüm sınıf kodlarını boşalt
                                Dim cmdUpdate As New OleDbCommand(
                                    "UPDATE tbStokSinifi SET " & _
                                    "sSinifKodu1 = '', sSinifKodu2 = '', sSinifKodu3 = '', sSinifKodu4 = '', sSinifKodu5 = '', " & _
                                    "sSinifKodu6 = '', sSinifKodu7 = '', sSinifKodu8 = '', sSinifKodu9 = '', sSinifKodu10 = '', " & _
                                    "sSinifKodu11 = '', sSinifKodu12 = '', sSinifKodu13 = '', sSinifKodu14 = '', sSinifKodu15 = '' " & _
                                    "WHERE nStokID = ?", conn)
                                cmdUpdate.Parameters.AddWithValue("?", nStokID)
                                cmdUpdate.ExecuteNonQuery()
                            End If
                        Next
                        
                        ' Grid'de sınıf sütunlarını da temizle
                        For sinifNo As Integer = 1 To 5
                            Dim colName As String = "colSinif" & sinifNo.ToString()
                            If dgvUrunler.Columns.Contains(colName) Then
                                dgvUrunler.Rows(satirIdx).Cells(colName).Value = ""
                            End If
                        Next
                        
                        AddLog($"✅ {sModel}: {stokIds.Count} varyantın sınıfları silindi")
                        basarili += 1
                        
                    Catch ex As Exception
                        AddLog($"❌ Satır {satirIdx}: Hata - {ex.Message}")
                        hatali += 1
                    End Try
                Next
                
            End Using
            
            AddLog("═══════════════════════════════════════")
            AddLog($"İŞLEM TAMAMLANDI: {basarili} başarılı, {hatali} hatalı")
            AddLog("═══════════════════════════════════════")
            
            MessageBox.Show($"İşlem tamamlandı!" & vbCrLf & vbCrLf & 
                           $"Başarılı: {basarili}" & vbCrLf & 
                           $"Hatalı: {hatali}",
                           "Tüm Sınıfları Sil",
                           MessageBoxButtons.OK,
                           If(hatali > 0, MessageBoxIcon.Warning, MessageBoxIcon.Information))
            
        Catch ex As Exception
            AddLog($"❌ Genel hata: {ex.Message}")
            MessageBox.Show($"Hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ''' <summary>
    ''' Veritabanındaki tüm bWebGoruntule=True olan ürünlerin sınıf kodlarını temizler
    ''' tbStokSinifi tablosundan kaydı silmez, sadece sınıf alanlarını '' yapar
    ''' </summary>
    Private Sub VeritabaniGeneliSiniflariSil()
        Try
            AddLog("═══════════════════════════════════════")
            AddLog("🗑 VERİTABANI GENELİNDE SINIFLAR SİLİNİYOR (bWebGoruntule=True)")
            AddLog("═══════════════════════════════════════")
            
            Dim etkilenenSatir As Integer = 0
            
            Using conn As New OleDbConnection(connection)
                conn.Open()
                
                ' Önce kaç ürün etkileneceğini bul
                Dim cmdCount As New OleDbCommand(
                    "SELECT COUNT(*) FROM tbStokSinifi si " & _
                    "INNER JOIN tbStok s ON s.nStokID = si.nStokID " & _
                    "WHERE s.bWebGoruntule = True", conn)
                Dim toplamSatir As Integer = Convert.ToInt32(cmdCount.ExecuteScalar())
                
                AddLog($"Etkilenecek toplam kayıt: {toplamSatir}")
                
                ' Son onay al
                Dim sonuc As DialogResult = MessageBox.Show(
                    $"Veritabanında {toplamSatir} adet 'Web'de Görüntüle' aktif ürün bulundu." & vbCrLf & vbCrLf & 
                    "Bu ürünlerin TÜM sınıf kodları (sSinifKodu1-15) silinecek." & vbCrLf & vbCrLf &
                    "⚠️ Bu işlem geri alınamaz! Devam etmek istiyor musunuz?",
                    "Tüm Sınıfları Sil - Son Onay",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning)
                
                If sonuc <> DialogResult.Yes Then
                    AddLog("İşlem kullanıcı tarafından iptal edildi.")
                    Return
                End If
                
                ' tbStokSinifi'deki sınıf kodlarını güncelle
                Dim cmdUpdate As New OleDbCommand(
                    "UPDATE tbStokSinifi SET " & _
                    "sSinifKodu1 = '', sSinifKodu2 = '', sSinifKodu3 = '', sSinifKodu4 = '', sSinifKodu5 = '', " & _
                    "sSinifKodu6 = '', sSinifKodu7 = '', sSinifKodu8 = '', sSinifKodu9 = '', sSinifKodu10 = '', " & _
                    "sSinifKodu11 = '', sSinifKodu12 = '', sSinifKodu13 = '', sSinifKodu14 = '', sSinifKodu15 = '' " & _
                    "WHERE nStokID IN (SELECT nStokID FROM tbStok WHERE bWebGoruntule = True)", conn)
                etkilenenSatir = cmdUpdate.ExecuteNonQuery()
                
            End Using
            
            AddLog("═══════════════════════════════════════")
            AddLog($"İŞLEM TAMAMLANDI: {etkilenenSatir} kayıt güncellendi")
            AddLog("═══════════════════════════════════════")
            
            MessageBox.Show($"İşlem tamamlandı!" & vbCrLf & vbCrLf & 
                           $"Güncellenen kayıt: {etkilenenSatir}",
                           "Tüm Sınıfları Sil - Veritabanı Geneli",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Information)
            
        Catch ex As Exception
            AddLog($"❌ Veritabanı geneli silme hatası: {ex.Message}")
            MessageBox.Show($"Hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ============================================================
    ' YARDIMCI FONKSİYONLAR - KULLANICI KATEGORİ SEÇİMİ İÇİN
    ' ============================================================
    

    ''' <summary>
    ''' Ürün açıklamasından detaylı ürün tipini bulur
    ''' Cinsiyet + Gerçek Ürün Tipi şeklinde döner
    ''' Örn: "ERKEK BEBEK/ÇOCUK - TSHIRT", "KADIN - SWEATSHIRT"
    ''' Bu sayede T-Shirt ve Sweatshirt gibi farklı ürünler aynı gruba girmez
    ''' </summary>
    Private Function BulDetayliUrunTipi(urunAdi As String, Optional modelKodu As String = "") As String
        If String.IsNullOrEmpty(urunAdi) Then Return ""
        
        Dim upper As String = urunAdi.ToUpper()
        upper = upper.Replace("İ", "I").Replace("Ş", "S").Replace("Ğ", "G").Replace("Ü", "U").Replace("Ö", "O").Replace("Ç", "C")
        
        ' Model kodu -S ile bitiyor mu? (Yetişkin ürün)
        Dim modelSonekiS As Boolean = False
        If Not String.IsNullOrEmpty(modelKodu) Then
            modelSonekiS = modelKodu.Trim().ToUpper().EndsWith("-S")
        End If
        
        ' 1) Cinsiyet belirle
        Dim cinsiyet As String = ""
        
        If upper.Contains("ANNE KIZ") OrElse upper.Contains("ANNE-KIZ") Then
            cinsiyet = If(modelSonekiS, "ANNE KIZ (YETİŞKİN)", "ANNE KIZ (ÇOCUK)")
        ElseIf upper.Contains("BABA OGUL") OrElse upper.Contains("BABA-OGUL") OrElse upper.Contains("BABA OĞUL") Then
            cinsiyet = If(modelSonekiS, "BABA OĞUL (YETİŞKİN)", "BABA OĞUL (ÇOCUK)")
        ElseIf upper.Contains("KIZ BEBEK") OrElse upper.Contains("KIZ COCUK") Then
            cinsiyet = "KIZ BEBEK/ÇOCUK"
        ElseIf upper.Contains("ERKEK BEBEK") OrElse upper.Contains("ERKEK COCUK") Then
            cinsiyet = "ERKEK BEBEK/ÇOCUK"
        ElseIf upper.Contains("KADIN") OrElse upper.Contains("BAYAN") Then
            cinsiyet = "KADIN"
        ElseIf upper.Contains("ERKEK") Then
            cinsiyet = "ERKEK"
        ElseIf upper.Contains("UNISEX") Then
            cinsiyet = "UNİSEX"
        End If
        
        ' 2) GERÇEK ürün tipini belirle (daha spesifik anahtar kelimeler önce)
        Dim gercekUrunTipi As String = ""
        
        ' T-Shirt varyasyonları
        If upper.Contains("TISORT") OrElse upper.Contains("T-SHIRT") OrElse upper.Contains("TSHIRT") Then
            gercekUrunTipi = "TSHIRT"
        ' Sweatshirt varyasyonları
        ElseIf upper.Contains("SWEATSHIRT") OrElse upper.Contains("SWEAT SHIRT") OrElse upper.Contains("SWEAT") Then
            gercekUrunTipi = "SWEATSHIRT"
        ' Eşofman takım
        ElseIf upper.Contains("ESOFMAN TAKIM") OrElse upper.Contains("ESORTMAN TAKIM") Then
            gercekUrunTipi = "ESOFMAN TAKIM"
        ' Eşofman alt
        ElseIf upper.Contains("ESOFMAN ALT") OrElse upper.Contains("ALT ESOFMAN") OrElse upper.Contains("ESORTMAN ALT") OrElse upper.Contains("ALT ESORTMAN") Then
            gercekUrunTipi = "ESOFMAN ALT"
        ' Eşofman üst
        ElseIf upper.Contains("ESOFMAN UST") OrElse upper.Contains("UST ESOFMAN") OrElse upper.Contains("ESORTMAN UST") OrElse upper.Contains("UST ESORTMAN") Then
            gercekUrunTipi = "ESOFMAN UST"
        ' Eşofman (genel)
        ElseIf upper.Contains("ESOFMAN") OrElse upper.Contains("ESORTMAN") Then
            gercekUrunTipi = "ESOFMAN"
        ' Pijama takım
        ElseIf upper.Contains("PIJAMA TAKIM") Then
            gercekUrunTipi = "PIJAMA TAKIM"
        ' Pijama alt/üst
        ElseIf upper.Contains("PIJAMA ALT") OrElse upper.Contains("ALT PIJAMA") Then
            gercekUrunTipi = "PIJAMA ALT"
        ElseIf upper.Contains("PIJAMA UST") OrElse upper.Contains("UST PIJAMA") Then
            gercekUrunTipi = "PIJAMA UST"
        ' Pijama (genel)
        ElseIf upper.Contains("PIJAMA") Then
            gercekUrunTipi = "PIJAMA"
        ' Bermuda
        ElseIf upper.Contains("BERMUDA TAKIM") Then
            gercekUrunTipi = "BERMUDA TAKIM"
        ElseIf upper.Contains("BERMUDA") Then
            gercekUrunTipi = "BERMUDA"
        ' Hırka, Kazak, Yelek
        ElseIf upper.Contains("HIRKA") Then
            gercekUrunTipi = "HIRKA"
        ElseIf upper.Contains("KAZAK") Then
            gercekUrunTipi = "KAZAK"
        ElseIf upper.Contains("YELEK") Then
            gercekUrunTipi = "YELEK"
        ' Şort, Pantolon, Tayt, Kapri
        ElseIf upper.Contains("SORT") Then
            gercekUrunTipi = "SORT"
        ElseIf upper.Contains("PANTOLON") Then
            gercekUrunTipi = "PANTOLON"
        ElseIf upper.Contains("TAYT") Then
            gercekUrunTipi = "TAYT"
        ElseIf upper.Contains("KAPRI") Then
            gercekUrunTipi = "KAPRI"
        ' Mont, Kaban
        ElseIf upper.Contains("MONT") Then
            gercekUrunTipi = "MONT"
        ElseIf upper.Contains("KABAN") Then
            gercekUrunTipi = "KABAN"
        ' Body, Tulum, Atlet
        ElseIf upper.Contains("BODY") Then
            gercekUrunTipi = "BODY"
        ElseIf upper.Contains("TULUM") Then
            gercekUrunTipi = "TULUM"
        ElseIf upper.Contains("ATLET") Then
            gercekUrunTipi = "ATLET"
        ElseIf upper.Contains("ZIBINLIK") Then
            gercekUrunTipi = "ZIBINLIK"
        ' İkili/Üçlü/Beşli takımlar
        ElseIf upper.Contains("IKILI TAKIM") OrElse upper.Contains("2LI TAKIM") OrElse upper.Contains("2 LI TAKIM") Then
            gercekUrunTipi = "IKILI TAKIM"
        ElseIf upper.Contains("UCLU TAKIM") OrElse upper.Contains("3LU TAKIM") OrElse upper.Contains("3 LU TAKIM") Then
            gercekUrunTipi = "UCLU TAKIM"
        ElseIf upper.Contains("BESLI TAKIM") OrElse upper.Contains("5LI TAKIM") OrElse upper.Contains("5 LI TAKIM") Then
            gercekUrunTipi = "BESLI TAKIM"
        ' Alt-Üst takım
        ElseIf upper.Contains("ALT UST TAKIM") OrElse upper.Contains("UST ALT TAKIM") OrElse upper.Contains("ALT-UST") OrElse upper.Contains("UST-ALT") Then
            gercekUrunTipi = "ALT-UST TAKIM"
        ' Genel takım
        ElseIf upper.Contains("TAKIM") OrElse upper.Contains("SET") Then
            gercekUrunTipi = "TAKIM"
        ' 2li, 3lü, 5li (tek başına)
        ElseIf upper.Contains("2LI") Then
            gercekUrunTipi = "2LI"
        ElseIf upper.Contains("3LU") Then
            gercekUrunTipi = "3LU"
        ElseIf upper.Contains("5LI") Then
            gercekUrunTipi = "5LI"
        Else
            gercekUrunTipi = "DIGER"
        End If
        
        ' 3) Sonucu birleştir: Cinsiyet - GerçekÜrünTipi
        If Not String.IsNullOrEmpty(cinsiyet) Then
            Return cinsiyet & " - " & gercekUrunTipi
        Else
            Return gercekUrunTipi
        End If
    End Function


    ''' <summary>
    ''' Ürün adından ürün tipini bulur (TrendyolDatabaseMatcher'dan kopyalandı)
    ''' </summary>
    Private Function BulUrunTipi(urunAdi As String) As String
        If String.IsNullOrEmpty(urunAdi) Then Return ""
        
        Dim upper As String = urunAdi.ToUpper()
        
        ' Türkçe karakter dönüşümü
        upper = upper.Replace("İ", "I").Replace("Ş", "S").Replace("Ğ", "G").Replace("Ü", "U").Replace("Ö", "O").Replace("Ç", "C")
        
        ' Ürün tipi anahtar kelimeleri - varyasyonlar dahil
        ' NOT: Daha spesifik olanlar önce gelmeli
        ' NOT: Türkçe karakterler zaten yukarıda dönüştürülüyor (Ş->S, Ö->O)
        Dim urunTipleri() As String = { _
            "ESOFMAN TAKIM", "ESORTMAN TAKIM", _
            "ESOFMAN ALT", "ALT ESOFMAN", "ESORTMAN ALT", "ALT ESORTMAN", _
            "ESOFMAN UST", "UST ESOFMAN", "ESORTMAN UST", "UST ESORTMAN", _
            "ESOFMAN", "ESORTMAN", _
            "PIJAMA TAKIM", "PIJAMA ALT", "ALT PIJAMA", "PIJAMA UST", "UST PIJAMA", "PIJAMA", _
            "BERMUDA TAKIM", "BERMUDA", _
            "TISORT", "T-SHIRT", "TSHIRT", _
            "SWEATSHIRT", "SWEAT SHIRT", "SWEAT", _
            "HIRKA", "KAZAK", "YELEK", _
            "SORT", "PANTOLON", "TAYT", "KAPRI", _
            "MONT", "KABAN", _
            "BODY", "TULUM", "ATLET", "ZIBINLIK", _
            "ALT UST TAKIM", "UST ALT TAKIM", "ALT-UST TAKIM", "UST-ALT TAKIM", _
            "IKILI TAKIM", "2LI TAKIM", "2 LI TAKIM", _
            "UCLU TAKIM", "3LU TAKIM", "3 LU TAKIM", _
            "BESLI TAKIM", "5LI TAKIM", "5 LI TAKIM", _
            "TAKIM", "SET", "2LI", "3LU", "5LI" _
        }
        
        For Each tip As String In urunTipleri
            If upper.Contains(tip) Then
                Return tip
            End If
        Next
        
        Return "DIGER"
    End Function
    
    ''' <summary>
    ''' Ürün tipini cinsiyet bilgisiyle birlikte döndürür
    ''' ANNE KIZ ve BABA OĞUL gibi ürünleri ayrı gruplamak için kullanılır
    ''' </summary>
    ''' <summary>
    ''' Ürün tipini cinsiyet bilgisiyle birlikte döndürür
    ''' ANNE KIZ ve BABA OĞUL gibi ürünleri ayrı gruplamak için kullanılır
    ''' Model kodu -S ile bitiyorsa YETİŞKİN olarak işaretler
    ''' </summary>
    Private Function BulUrunTipiVeCinsiyet(urunAdi As String, Optional modelKodu As String = "") As String
        If String.IsNullOrEmpty(urunAdi) Then Return ""
        
        Dim upper As String = urunAdi.ToUpper()
        
        ' Türkçe karakter dönüşümü
        upper = upper.Replace("İ", "I").Replace("Ş", "S").Replace("Ğ", "G").Replace("Ü", "U").Replace("Ö", "O").Replace("Ç", "C")
        
        ' Önce ürün tipini bul
        Dim urunTipi As String = BulUrunTipi(urunAdi)
        
        ' Model kodu -S ile bitiyor mu? (Yetişkin ürün)
        Dim modelSonekiS As Boolean = False
        If Not String.IsNullOrEmpty(modelKodu) Then
            modelSonekiS = modelKodu.Trim().ToUpper().EndsWith("-S")
        End If
        
        ' Cinsiyet belirleyici anahtar kelimeler
        Dim cinsiyet As String = ""
        
        ' ANNE KIZ / BABA OĞUL özel kontrol
        ' -S soneki varsa YETİŞKİN, yoksa ÇOCUK
        If upper.Contains("ANNE KIZ") OrElse upper.Contains("ANNE-KIZ") Then
            If modelSonekiS Then
                cinsiyet = "ANNE KIZ (YETİŞKİN)"  ' -S var → Kadın kategorisi seçilmeli
            Else
                cinsiyet = "ANNE KIZ (ÇOCUK)"     ' -S yok → Kız Çocuk kategorisi seçilmeli
            End If
        ElseIf upper.Contains("BABA OGUL") OrElse upper.Contains("BABA-OGUL") OrElse upper.Contains("BABA OĞUL") Then
            If modelSonekiS Then
                cinsiyet = "BABA OĞUL (YETİŞKİN)"  ' -S var → Erkek kategorisi seçilmeli
            Else
                cinsiyet = "BABA OĞUL (ÇOCUK)"     ' -S yok → Erkek Çocuk kategorisi seçilmeli
            End If
        ' Bebek cinsiyetleri
        ElseIf upper.Contains("KIZ BEBEK") OrElse upper.Contains("KIZ COCUK") Then
            cinsiyet = "KIZ BEBEK/ÇOCUK"
        ElseIf upper.Contains("ERKEK BEBEK") OrElse upper.Contains("ERKEK COCUK") Then
            cinsiyet = "ERKEK BEBEK/ÇOCUK"
        ' Yetişkin cinsiyetleri
        ElseIf upper.Contains("KADIN") OrElse upper.Contains("BAYAN") Then
            cinsiyet = "KADIN"
        ElseIf upper.Contains("ERKEK") Then
            cinsiyet = "ERKEK"
        ' Unisex/Belirsiz
        ElseIf upper.Contains("UNISEX") Then
            cinsiyet = "UNİSEX"
        End If
        
        ' Cinsiyet bilgisi varsa ürün tipine ekle
        If Not String.IsNullOrEmpty(cinsiyet) Then
            Return cinsiyet & " - " & urunTipi
        Else
            Return urunTipi
        End If
    End Function
    
    ''' <summary>
    ''' Kullanıcının manuel seçtiği kategoriyi veritabanına kaydeder
    ''' frm_stok_kart.vb tbStokSinifi_kaydet_duzelt1 fonksiyonu örnek alındı
    ''' </summary>
    Private Function KategoriKaydetManuel(sModel As String, secim As UrunTipiKategoriSonuc) As Boolean
        Try
            Using conn As New OleDbConnection(connection)
                conn.Open()
                
                ' Model bazlı güncelleme yap - tbStokSinifi_kaydet_duzelt1 mantığı
                Dim sql As String = "UPDATE tbStokSinifi SET " & _
                    "sSinifKodu3 = ?, sSinifKodu4 = ?, sSinifKodu5 = ?, " & _
                    "sSinifKodu6 = ?, sSinifKodu7 = ?, sSinifKodu8 = ? " & _
                    "WHERE nStokID IN (SELECT nStokID FROM tbStok WHERE sModel = ?)"
                
                Dim cmd As New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@p1", secim.sSinifKodu3)
                cmd.Parameters.AddWithValue("@p2", secim.sSinifKodu4)
                cmd.Parameters.AddWithValue("@p3", secim.sSinifKodu5)
                cmd.Parameters.AddWithValue("@p4", secim.sSinifKodu6)
                cmd.Parameters.AddWithValue("@p5", secim.sSinifKodu7)
                cmd.Parameters.AddWithValue("@p6", secim.sSinifKodu8)
                cmd.Parameters.AddWithValue("@p7", sModel)
                
                Dim etkilenen As Integer = cmd.ExecuteNonQuery()
                
                Return etkilenen > 0
            End Using
            
        Catch ex As Exception
            AddLog($"      ❌ Kayıt hatası ({sModel}): {ex.Message}")
            Return False
        End Try
    End Function
    
    ''' <summary>
    ''' Kategori tutarsızlıklarını bulur ve düzeltme formu açar
    ''' Aynı ürün tipindeki ürünlerin kategori farklılıklarını tespit eder
    ''' </summary>
    Private Sub btnKategoriKontrol_Click(sender As Object, e As EventArgs) Handles btnKategoriKontrol.Click
        Try
            AddLog("")
            AddLog("════════════════════════════════════════════════════════════")
            AddLog("🔍 KATEGORİ TUTARSIZLIK KONTROLÜ BAŞLIYOR...")
            AddLog("════════════════════════════════════════════════════════════")
            
            ' Ürün tipine göre grupla ve kategori dağılımını analiz et
            ' Key: UrunTipi (örn: "ERKEK BEBEK/ÇOCUK - TSHIRT")
            ' Value: Dictionary<KategoriYolu, List<Model>>
            Dim urunTipiKategoriMap As New Dictionary(Of String, Dictionary(Of String, List(Of String)))
            
            Using conn As New OleDbConnection(connection)
                conn.Open()
                
                ' Kategorisi dolu olan ürünleri al
                Dim sql As String = "SELECT T1.sModel, T1.sAciklama, " &
                    "(SELECT sAciklama FROM tbSSinif4 WHERE sSinifKodu = T2.sSinifKodu4) AS Kat4, " &
                    "(SELECT sAciklama FROM tbSSinif5 WHERE sSinifKodu = T2.sSinifKodu5) AS Kat5, " &
                    "(SELECT sAciklama FROM tbSSinif6 WHERE sSinifKodu = T2.sSinifKodu6) AS Kat6 " &
                    "FROM tbStok T1 " &
                    "INNER JOIN tbStokSinifi T2 ON T2.nStokID = T1.nStokID " &
                    "WHERE T2.sSinifKodu4 IS NOT NULL AND T2.sSinifKodu4 <> '' " &
                    "GROUP BY T1.sModel, T1.sAciklama, T2.sSinifKodu4, T2.sSinifKodu5, T2.sSinifKodu6"
                
                Dim cmd As New OleDbCommand(sql, conn)
                Using reader As OleDbDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim sModel As String = If(reader("sModel") IsNot DBNull.Value, reader("sModel").ToString(), "")
                        Dim sAciklama As String = If(reader("sAciklama") IsNot DBNull.Value, reader("sAciklama").ToString(), "")
                        Dim kat4 As String = If(reader("Kat4") IsNot DBNull.Value, reader("Kat4").ToString(), "")
                        Dim kat5 As String = If(reader("Kat5") IsNot DBNull.Value, reader("Kat5").ToString(), "")
                        Dim kat6 As String = If(reader("Kat6") IsNot DBNull.Value, reader("Kat6").ToString(), "")
                        
                        ' Detaylı ürün tipini bul (Cinsiyet + Gerçek Ürün Tipi)
                        ' Örn: "ERKEK BEBEK/ÇOCUK - TSHIRT" şeklinde
                        Dim urunTipi As String = BulDetayliUrunTipi(sAciklama, sModel)
                        If String.IsNullOrEmpty(urunTipi) Then Continue While
                        
                        ' Kategori yolu
                        Dim kategoriYolu As String = String.Join(" > ", {kat4, kat5, kat6}.Where(Function(k) Not String.IsNullOrEmpty(k)))
                        If String.IsNullOrEmpty(kategoriYolu) Then Continue While
                        
                        ' Map'e ekle
                        If Not urunTipiKategoriMap.ContainsKey(urunTipi) Then
                            urunTipiKategoriMap(urunTipi) = New Dictionary(Of String, List(Of String))
                        End If
                        
                        If Not urunTipiKategoriMap(urunTipi).ContainsKey(kategoriYolu) Then
                            urunTipiKategoriMap(urunTipi)(kategoriYolu) = New List(Of String)
                        End If
                        
                        If Not urunTipiKategoriMap(urunTipi)(kategoriYolu).Contains(sModel) Then
                            urunTipiKategoriMap(urunTipi)(kategoriYolu).Add(sModel)
                        End If
                    End While
                End Using
            End Using
            
            ' Tutarsızlıkları bul (birden fazla farklı kategoriye sahip ürün tipleri)
            Dim tutarsizliklar As New List(Of Tuple(Of String, Dictionary(Of String, List(Of String))))
            
            For Each kvp As KeyValuePair(Of String, Dictionary(Of String, List(Of String))) In urunTipiKategoriMap
                If kvp.Value.Count > 1 Then
                    ' Bu ürün tipinde birden fazla farklı kategori var - tutarsızlık!
                    tutarsizliklar.Add(Tuple.Create(kvp.Key, kvp.Value))
                End If
            Next
            
            If tutarsizliklar.Count = 0 Then
                AddLog("✅ Tutarsızlık bulunamadı - tüm kategoriler uyumlu!")
                MessageBox.Show("Kategori tutarsızlığı bulunamadı. Tüm ürün tipleri tutarlı kategorilere sahip.", 
                    "Kontrol Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If
            
            AddLog($"⚠️ {tutarsizliklar.Count} ürün tipinde tutarsızlık bulundu!")
            
            ' Tutarsızlık düzeltme formu oluştur
            Dim tutarsizlikForm As New Form()
            tutarsizlikForm.Text = "Kategori Tutarsızlıkları - Düzeltme"
            tutarsizlikForm.Size = New Size(1000, 700)
            tutarsizlikForm.StartPosition = FormStartPosition.CenterParent
            tutarsizlikForm.FormBorderStyle = FormBorderStyle.Sizable
            
            ' ListView
            Dim lvTutarsizliklar As New ListView()
            lvTutarsizliklar.Dock = DockStyle.Fill
            lvTutarsizliklar.View = View.Details
            lvTutarsizliklar.FullRowSelect = True
            lvTutarsizliklar.GridLines = True
            lvTutarsizliklar.CheckBoxes = True
            lvTutarsizliklar.Columns.Add("Ürün Tipi", 200)
            lvTutarsizliklar.Columns.Add("Çoğunluk Kategorisi", 300)
            lvTutarsizliklar.Columns.Add("Çoğunluk Sayısı", 100)
            lvTutarsizliklar.Columns.Add("Yanlış Kategori", 200)
            lvTutarsizliklar.Columns.Add("Yanlış Sayısı", 100)
            
            ' Her tutarsızlık için satır ekle
            For Each t As Tuple(Of String, Dictionary(Of String, List(Of String))) In tutarsizliklar
                Dim urunTipi As String = t.Item1
                Dim kategoriDagilimi As Dictionary(Of String, List(Of String)) = t.Item2
                
                ' En çok kullanılan kategoriyi bul (çoğunluk)
                Dim cogunlukKategori As String = ""
                Dim cogunlukSayisi As Integer = 0
                For Each kd As KeyValuePair(Of String, List(Of String)) In kategoriDagilimi
                    If kd.Value.Count > cogunlukSayisi Then
                        cogunlukSayisi = kd.Value.Count
                        cogunlukKategori = kd.Key
                    End If
                Next
                
                ' Çoğunluktan farklı olanları listele
                For Each kd As KeyValuePair(Of String, List(Of String)) In kategoriDagilimi
                    If kd.Key <> cogunlukKategori Then
                        Dim item As New ListViewItem(urunTipi)
                        item.SubItems.Add(cogunlukKategori)
                        item.SubItems.Add(cogunlukSayisi.ToString())
                        item.SubItems.Add(kd.Key)
                        item.SubItems.Add(kd.Value.Count.ToString())
                        item.Tag = Tuple.Create(urunTipi, cogunlukKategori, kd.Value) ' Düzeltme için bilgi
                        item.BackColor = Color.MistyRose
                        lvTutarsizliklar.Items.Add(item)
                        
                        AddLog($"  📌 {urunTipi}: {kd.Value.Count} ürün '{kd.Key}' → olması gereken '{cogunlukKategori}'")
                    End If
                Next
            Next
            
            ' Panel - alt kısım
            Dim pnlButtons As New Panel()
            pnlButtons.Dock = DockStyle.Bottom
            pnlButtons.Height = 60
            
            Dim btnSeciliDuzelt As New Button()
            btnSeciliDuzelt.Text = "✓ Seçilenleri Düzelt (Çoğunluğa Göre)"
            btnSeciliDuzelt.Size = New Size(250, 40)
            btnSeciliDuzelt.Location = New Point(10, 10)
            btnSeciliDuzelt.BackColor = Color.Green
            btnSeciliDuzelt.ForeColor = Color.White
            btnSeciliDuzelt.Font = New Font("Segoe UI", 10, FontStyle.Bold)
            btnSeciliDuzelt.FlatStyle = FlatStyle.Flat
            
            Dim btnTumunuSec As New Button()
            btnTumunuSec.Text = "Tümünü Seç"
            btnTumunuSec.Size = New Size(120, 40)
            btnTumunuSec.Location = New Point(270, 10)
            btnTumunuSec.FlatStyle = FlatStyle.Flat
            
            Dim btnKapat As New Button()
            btnKapat.Text = "Kapat"
            btnKapat.Size = New Size(100, 40)
            btnKapat.Location = New Point(400, 10)
            btnKapat.FlatStyle = FlatStyle.Flat
            
            AddHandler btnTumunuSec.Click, Sub()
                For Each item As ListViewItem In lvTutarsizliklar.Items
                    item.Checked = True
                Next
            End Sub
            
            AddHandler btnKapat.Click, Sub()
                tutarsizlikForm.Close()
            End Sub
            
            AddHandler btnSeciliDuzelt.Click, Sub()
                Dim seciliSayisi As Integer = lvTutarsizliklar.CheckedItems.Count
                If seciliSayisi = 0 Then
                    MessageBox.Show("Lütfen düzeltilecek satırları seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If
                
                If MessageBox.Show($"{seciliSayisi} satırdaki ürünlerin kategorileri çoğunluğa göre düzeltilecek. Devam edilsin mi?",
                    "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then
                    Return
                End If
                
                ' PARAMETRİK sınıf eşleştirme ayarlarını oku
                Dim kat1FieldNo As String = GetSinifEslemeAyar("ETICARET_SINIF_KAT1", "sSinifKodu4").Replace("sSinifKodu", "")
                Dim kat2FieldNo As String = GetSinifEslemeAyar("ETICARET_SINIF_KAT2", "sSinifKodu5").Replace("sSinifKodu", "")
                Dim kat3FieldNo As String = GetSinifEslemeAyar("ETICARET_SINIF_KAT3", "sSinifKodu6").Replace("sSinifKodu", "")
                
                Dim duzeltilen As Integer = 0
                Using conn As New OleDbConnection(connection)
                    conn.Open()
                    
                    For Each item As ListViewItem In lvTutarsizliklar.CheckedItems
                        Dim bilgi As Tuple(Of String, String, List(Of String)) = DirectCast(item.Tag, Tuple(Of String, String, List(Of String)))
                        Dim dogruKategori As String = bilgi.Item2
                        Dim modeller As List(Of String) = bilgi.Item3
                        
                        ' Doğru kategori yolunu parçala
                        Dim katParcalar() As String = dogruKategori.Split(New String() {" > "}, StringSplitOptions.RemoveEmptyEntries)
                        Dim kat1 As String = If(katParcalar.Length > 0, katParcalar(0), "")
                        Dim kat2 As String = If(katParcalar.Length > 1, katParcalar(1), "")
                        Dim kat3 As String = If(katParcalar.Length > 2, katParcalar(2), "")
                        
                        ' Her model için güncelle - PARAMETRİK
                        For Each sModel As String In modeller
                            Try
                                Dim yeniKat1Kod As String = If(Not String.IsNullOrEmpty(kat1), EnsureSinifExists(conn, $"tbSSinif{kat1FieldNo}", kat1), "")
                                Dim yeniKat2Kod As String = If(Not String.IsNullOrEmpty(kat2), EnsureSinifExists(conn, $"tbSSinif{kat2FieldNo}", kat2), "")
                                Dim yeniKat3Kod As String = If(Not String.IsNullOrEmpty(kat3), EnsureSinifExists(conn, $"tbSSinif{kat3FieldNo}", kat3), "")
                                
                                Dim sqlUpdate As String = $"UPDATE tbStokSinifi SET sSinifKodu{kat1FieldNo} = ?, sSinifKodu{kat2FieldNo} = ?, sSinifKodu{kat3FieldNo} = ? " &
                                    "WHERE nStokID IN (SELECT nStokID FROM tbStok WHERE sModel = ?)"
                                Dim cmdUpdate As New OleDbCommand(sqlUpdate, conn)
                                cmdUpdate.Parameters.AddWithValue("?", yeniKat1Kod)
                                cmdUpdate.Parameters.AddWithValue("?", yeniKat2Kod)
                                cmdUpdate.Parameters.AddWithValue("?", yeniKat3Kod)
                                cmdUpdate.Parameters.AddWithValue("?", sModel)
                                cmdUpdate.ExecuteNonQuery()
                                duzeltilen += 1
                            Catch ex As Exception
                                AddLog($"❌ Hata ({sModel}): {ex.Message}")
                            End Try
                        Next
                        
                        item.BackColor = Color.LightGreen
                        item.Checked = False
                    Next
                End Using
                
                AddLog($"✅ {duzeltilen} model düzeltildi!")
                MessageBox.Show($"{duzeltilen} modelin kategorisi düzeltildi!", "Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Sub
            
            pnlButtons.Controls.Add(btnSeciliDuzelt)
            pnlButtons.Controls.Add(btnTumunuSec)
            pnlButtons.Controls.Add(btnKapat)
            
            tutarsizlikForm.Controls.Add(lvTutarsizliklar)
            tutarsizlikForm.Controls.Add(pnlButtons)
            
            tutarsizlikForm.ShowDialog()
            
        Catch ex As Exception
            AddLog($"❌ Hata: {ex.Message}")
            MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    
    ' ========================================================================
    ' SINIF EŞLEŞTİRME HELPER FONKSİYONLARI
    ' ========================================================================
    
    ''' <summary>
    ''' Sınıf eşleştirme ayarını veritabanından okur
    ''' </summary>
    Private Function GetSinifEslemeAyar(ayarKodu As String, varsayilan As String) As String
        Try
            Using conn As New OleDbConnection(connection)
                conn.Open()
                Using cmd As New OleDbCommand($"SELECT sAyarDeger FROM tbSistemAyar WHERE sAyarKodu = '{ayarKodu}'", conn)
                    Dim result As Object = cmd.ExecuteScalar()
                    If result IsNot Nothing AndAlso result IsNot DBNull.Value AndAlso Not String.IsNullOrEmpty(result.ToString()) Then
                        Return result.ToString()
                    End If
                End Using
            End Using
        Catch
        End Try
        Return varsayilan
    End Function

End Class
