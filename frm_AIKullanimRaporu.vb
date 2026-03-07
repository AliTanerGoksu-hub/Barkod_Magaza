' ============================================================================
' AI KULLANIM RAPORU FORMU
' ============================================================================
' Bireysel AI kullanım istatistikleri ve maliyet raporu
' Her kullanıcı kendi kullanımını görür
' ============================================================================

Imports System.Windows.Forms
Imports System.Drawing
Imports System.IO
Imports System.Collections.Generic

Public Class frm_AIKullanimRaporu
    Inherits Form
    
    ' Form Controls
    Private dgvKullanim As DataGridView
    Private dgvGunluk As DataGridView
    Private dtpBaslangic As DateTimePicker
    Private dtpBitis As DateTimePicker
    Private btnFiltrele As Button
    Private btnYenile As Button
    Private btnExcel As Button
    Private lblToplamSorgu As Label
    Private lblToplamToken As Label
    Private lblToplamMaliyet As Label
    Private lblOrtalamaToken As Label
    Private grpOzet As GroupBox
    Private grpFiltre As GroupBox
    Private tabControl As TabControl
    Private tabDetay As TabPage
    Private tabGunluk As TabPage
    Private tabModel As TabPage
    Private dgvModel As DataGridView
    
    Private logFolder As String = Application.StartupPath
    
    Public Sub New()
        InitializeComponent()
    End Sub
    
    Private Sub InitializeComponent()
        Me.Text = "AI Kullanım Raporu"
        Me.Size = New Size(1100, 700)
        Me.StartPosition = FormStartPosition.CenterScreen
        
        ' ===== FİLTRE PANEL =====
        grpFiltre = New GroupBox With {
            .Text = "Filtre",
            .Location = New Point(10, 10),
            .Size = New Size(1060, 70),
            .Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        }
        
        Dim lblBaslangic As New Label With {
            .Text = "Başlangıç:",
            .Location = New Point(20, 28),
            .Size = New Size(70, 25)
        }
        grpFiltre.Controls.Add(lblBaslangic)
        
        dtpBaslangic = New DateTimePicker With {
            .Location = New Point(90, 25),
            .Size = New Size(150, 25),
            .Format = DateTimePickerFormat.Short,
            .Value = DateTime.Now.AddMonths(-1)
        }
        grpFiltre.Controls.Add(dtpBaslangic)
        
        Dim lblBitis As New Label With {
            .Text = "Bitiş:",
            .Location = New Point(260, 28),
            .Size = New Size(40, 25)
        }
        grpFiltre.Controls.Add(lblBitis)
        
        dtpBitis = New DateTimePicker With {
            .Location = New Point(300, 25),
            .Size = New Size(150, 25),
            .Format = DateTimePickerFormat.Short,
            .Value = DateTime.Now
        }
        grpFiltre.Controls.Add(dtpBitis)
        
        btnFiltrele = New Button With {
            .Text = "🔍 Filtrele",
            .Location = New Point(480, 22),
            .Size = New Size(100, 30),
            .BackColor = Color.SteelBlue,
            .ForeColor = Color.White,
            .FlatStyle = FlatStyle.Flat
        }
        AddHandler btnFiltrele.Click, AddressOf btnFiltrele_Click
        grpFiltre.Controls.Add(btnFiltrele)
        
        btnYenile = New Button With {
            .Text = "🔄 Yenile",
            .Location = New Point(590, 22),
            .Size = New Size(100, 30),
            .BackColor = Color.Orange,
            .ForeColor = Color.White,
            .FlatStyle = FlatStyle.Flat
        }
        AddHandler btnYenile.Click, AddressOf btnYenile_Click
        grpFiltre.Controls.Add(btnYenile)
        
        btnExcel = New Button With {
            .Text = "📊 Excel'e Aktar",
            .Location = New Point(700, 22),
            .Size = New Size(120, 30),
            .BackColor = Color.Green,
            .ForeColor = Color.White,
            .FlatStyle = FlatStyle.Flat
        }
        AddHandler btnExcel.Click, AddressOf btnExcel_Click
        grpFiltre.Controls.Add(btnExcel)
        
        Me.Controls.Add(grpFiltre)
        
        ' ===== ÖZET PANEL =====
        grpOzet = New GroupBox With {
            .Text = "📈 Özet Bilgiler",
            .Location = New Point(10, 90),
            .Size = New Size(1060, 80),
            .Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        }
        
        lblToplamSorgu = New Label With {
            .Text = "Toplam Sorgu: 0",
            .Location = New Point(20, 30),
            .Size = New Size(180, 30),
            .Font = New Font("Segoe UI", 11, FontStyle.Bold),
            .ForeColor = Color.DarkBlue
        }
        grpOzet.Controls.Add(lblToplamSorgu)
        
        lblToplamToken = New Label With {
            .Text = "Toplam Token: 0",
            .Location = New Point(220, 30),
            .Size = New Size(220, 30),
            .Font = New Font("Segoe UI", 11, FontStyle.Bold),
            .ForeColor = Color.DarkGreen
        }
        grpOzet.Controls.Add(lblToplamToken)
        
        lblOrtalamaToken = New Label With {
            .Text = "Ort. Token/Sorgu: 0",
            .Location = New Point(460, 30),
            .Size = New Size(220, 30),
            .Font = New Font("Segoe UI", 11, FontStyle.Bold),
            .ForeColor = Color.DarkOrange
        }
        grpOzet.Controls.Add(lblOrtalamaToken)
        
        lblToplamMaliyet = New Label With {
            .Text = "Tahmini Maliyet: $0.00",
            .Location = New Point(700, 30),
            .Size = New Size(300, 30),
            .Font = New Font("Segoe UI", 12, FontStyle.Bold),
            .ForeColor = Color.DarkRed
        }
        grpOzet.Controls.Add(lblToplamMaliyet)
        
        Me.Controls.Add(grpOzet)
        
        ' ===== TAB CONTROL =====
        tabControl = New TabControl With {
            .Location = New Point(10, 180),
            .Size = New Size(1060, 470),
            .Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        }
        
        ' Tab 1: Detaylı Kullanım
        tabDetay = New TabPage With {.Text = "📋 Detaylı Kullanım"}
        dgvKullanim = New DataGridView With {
            .Dock = DockStyle.Fill,
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
            .AllowUserToAddRows = False,
            .ReadOnly = True,
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect,
            .BackgroundColor = Color.White,
            .BorderStyle = BorderStyle.None,
            .RowHeadersVisible = False
        }
        tabDetay.Controls.Add(dgvKullanim)
        tabControl.TabPages.Add(tabDetay)
        
        ' Tab 2: Günlük Özet
        tabGunluk = New TabPage With {.Text = "📅 Günlük Özet"}
        dgvGunluk = New DataGridView With {
            .Dock = DockStyle.Fill,
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
            .AllowUserToAddRows = False,
            .ReadOnly = True,
            .BackgroundColor = Color.White,
            .BorderStyle = BorderStyle.None,
            .RowHeadersVisible = False
        }
        tabGunluk.Controls.Add(dgvGunluk)
        tabControl.TabPages.Add(tabGunluk)
        
        ' Tab 3: Model Bazlı
        tabModel = New TabPage With {.Text = "🤖 Model Bazlı"}
        dgvModel = New DataGridView With {
            .Dock = DockStyle.Fill,
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
            .AllowUserToAddRows = False,
            .ReadOnly = True,
            .BackgroundColor = Color.White,
            .BorderStyle = BorderStyle.None,
            .RowHeadersVisible = False
        }
        tabModel.Controls.Add(dgvModel)
        tabControl.TabPages.Add(tabModel)
        
        Me.Controls.Add(tabControl)
    End Sub
    
    Private Sub frm_AIKullanimRaporu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub
    
    Private Sub LoadData()
        LoadFromLogFiles()
        LoadFromCSVFiles()
    End Sub
    
    Private Sub LoadFromLogFiles()
        Try
            Dim tokenLogFile As String = Path.Combine(logFolder, "AI_Token_Usage.log")
            
            If Not File.Exists(tokenLogFile) Then
                MessageBox.Show("Henüz AI kullanım verisi yok." & vbCrLf & vbCrLf & 
                    "AI fonksiyonlarını kullandıkça veriler burada görünecek.", 
                    "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If
            
            Dim lines() As String = File.ReadAllLines(tokenLogFile)
            Dim dt As New DataTable()
            dt.Columns.Add("Tarih", GetType(DateTime))
            dt.Columns.Add("Model", GetType(String))
            dt.Columns.Add("Prompt Token", GetType(Integer))
            dt.Columns.Add("Completion Token", GetType(Integer))
            dt.Columns.Add("Toplam Token", GetType(Integer))
            dt.Columns.Add("Maliyet (USD)", GetType(Decimal))
            
            Dim baslangic As DateTime = dtpBaslangic.Value.Date
            Dim bitis As DateTime = dtpBitis.Value.Date.AddDays(1)
            
            Dim toplamSorgu As Integer = 0
            Dim toplamToken As Integer = 0
            Dim toplamMaliyet As Decimal = 0
            
            For Each line As String In lines
                Try
                    ' [2024-01-15 14:30:25] Model=gpt-4o-mini, PromptTokens=100, CompletionTokens=50, TotalTokens=150, Cost=$0.000150
                    If String.IsNullOrWhiteSpace(line) Then Continue For
                    
                    Dim tarihStr As String = line.Substring(1, 19)
                    Dim tarih As DateTime = DateTime.Parse(tarihStr)
                    
                    If tarih < baslangic OrElse tarih >= bitis Then Continue For
                    
                    Dim model As String = ExtractValue(line, "Model=", ",")
                    Dim promptTokens As Integer = Integer.Parse(ExtractValue(line, "PromptTokens=", ","))
                    Dim completionTokens As Integer = Integer.Parse(ExtractValue(line, "CompletionTokens=", ","))
                    Dim totalTokens As Integer = Integer.Parse(ExtractValue(line, "TotalTokens=", ","))
                    Dim cost As Decimal = Decimal.Parse(ExtractValue(line, "Cost=$", "").Replace(".", ","))
                    
                    dt.Rows.Add(tarih, model, promptTokens, completionTokens, totalTokens, cost)
                    
                    toplamSorgu += 1
                    toplamToken += totalTokens
                    toplamMaliyet += cost
                Catch
                    ' Satır parse edilemedi, devam et
                End Try
            Next
            
            dgvKullanim.DataSource = dt
            
            ' Özet bilgileri güncelle
            lblToplamSorgu.Text = $"Toplam Sorgu: {toplamSorgu:N0}"
            lblToplamToken.Text = $"Toplam Token: {toplamToken:N0}"
            lblOrtalamaToken.Text = $"Ort. Token/Sorgu: {If(toplamSorgu > 0, toplamToken \ toplamSorgu, 0):N0}"
            lblToplamMaliyet.Text = $"Tahmini Maliyet: ${toplamMaliyet:F4} (~{(toplamMaliyet * 35):F2} TL)"
            
            ' Günlük özet hesapla
            CalculateDailySummary(dt)
            
            ' Model özet hesapla
            CalculateModelSummary(dt)
            
        Catch ex As Exception
            MessageBox.Show("Veri yüklenirken hata: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    
    Private Sub LoadFromCSVFiles()
        Try
            ' CSV dosyalarını kontrol et
            Dim csvFiles = Directory.GetFiles(logFolder, "AI_Usage_*.csv")
            
            If csvFiles.Length = 0 Then Return
            
            ' En son CSV dosyasını yükle (bugünün)
            Dim todayFile As String = Path.Combine(logFolder, $"AI_Usage_{DateTime.Now:yyyyMMdd}.csv")
            
            If File.Exists(todayFile) Then
                ' Bugünün verilerini göster
            End If
            
        Catch ex As Exception
            ' CSV yükleme hatası - sessizce devam et
        End Try
    End Sub
    
    Private Function ExtractValue(line As String, startMarker As String, endMarker As String) As String
        Try
            Dim startIndex As Integer = line.IndexOf(startMarker)
            If startIndex < 0 Then Return "0"
            
            startIndex += startMarker.Length
            
            Dim endIndex As Integer
            If String.IsNullOrEmpty(endMarker) Then
                endIndex = line.Length
            Else
                endIndex = line.IndexOf(endMarker, startIndex)
                If endIndex < 0 Then endIndex = line.Length
            End If
            
            Return line.Substring(startIndex, endIndex - startIndex).Trim()
        Catch
            Return "0"
        End Try
    End Function
    
    ' Yardımcı sınıf - özet verileri tutmak için
    Private Class SummaryData
        Public Property Count As Integer
        Public Property Tokens As Integer
        Public Property Cost As Decimal
        
        Public Sub New(c As Integer, t As Integer, co As Decimal)
            Count = c
            Tokens = t
            Cost = co
        End Sub
    End Class
    
    Private Sub CalculateDailySummary(dt As DataTable)
        Try
            Dim dailyData As New Dictionary(Of Date, SummaryData)
            
            For Each row As DataRow In dt.Rows
                Dim tarih As Date = CDate(row("Tarih")).Date
                Dim tokens As Integer = CInt(row("Toplam Token"))
                Dim cost As Decimal = CDec(row("Maliyet (USD)"))
                
                If dailyData.ContainsKey(tarih) Then
                    Dim current As SummaryData = dailyData(tarih)
                    current.Count += 1
                    current.Tokens += tokens
                    current.Cost += cost
                Else
                    dailyData(tarih) = New SummaryData(1, tokens, cost)
                End If
            Next
            
            Dim dtGunluk As New DataTable()
            dtGunluk.Columns.Add("Tarih", GetType(Date))
            dtGunluk.Columns.Add("Sorgu Sayısı", GetType(Integer))
            dtGunluk.Columns.Add("Toplam Token", GetType(Integer))
            dtGunluk.Columns.Add("Maliyet (USD)", GetType(Decimal))
            dtGunluk.Columns.Add("Maliyet (TL)", GetType(Decimal))
            
            ' Tarihe göre sırala (yeniden eskiye)
            Dim sortedDates As New List(Of Date)(dailyData.Keys)
            sortedDates.Sort()
            sortedDates.Reverse()
            
            For Each tarih As Date In sortedDates
                Dim data As SummaryData = dailyData(tarih)
                dtGunluk.Rows.Add(tarih, data.Count, data.Tokens, data.Cost, data.Cost * 35)
            Next
            
            dgvGunluk.DataSource = dtGunluk
            
        Catch ex As Exception
            ' Günlük özet hesaplama hatası
        End Try
    End Sub
    
    Private Sub CalculateModelSummary(dt As DataTable)
        Try
            Dim modelData As New Dictionary(Of String, SummaryData)
            
            For Each row As DataRow In dt.Rows
                Dim model As String = row("Model").ToString()
                Dim tokens As Integer = CInt(row("Toplam Token"))
                Dim cost As Decimal = CDec(row("Maliyet (USD)"))
                
                If modelData.ContainsKey(model) Then
                    Dim current As SummaryData = modelData(model)
                    current.Count += 1
                    current.Tokens += tokens
                    current.Cost += cost
                Else
                    modelData(model) = New SummaryData(1, tokens, cost)
                End If
            Next
            
            Dim dtModel As New DataTable()
            dtModel.Columns.Add("Model", GetType(String))
            dtModel.Columns.Add("Sorgu Sayısı", GetType(Integer))
            dtModel.Columns.Add("Toplam Token", GetType(Integer))
            dtModel.Columns.Add("Ort. Token", GetType(Integer))
            dtModel.Columns.Add("Maliyet (USD)", GetType(Decimal))
            
            For Each modelName As String In modelData.Keys
                Dim data As SummaryData = modelData(modelName)
                Dim ortToken As Integer = If(data.Count > 0, data.Tokens \ data.Count, 0)
                dtModel.Rows.Add(modelName, data.Count, data.Tokens, ortToken, data.Cost)
            Next
            
            dgvModel.DataSource = dtModel
            
        Catch ex As Exception
            ' Model özet hesaplama hatası
        End Try
    End Sub
    
    Private Sub btnFiltrele_Click(sender As Object, e As EventArgs)
        LoadData()
    End Sub
    
    Private Sub btnYenile_Click(sender As Object, e As EventArgs)
        LoadData()
    End Sub
    
    Private Sub btnExcel_Click(sender As Object, e As EventArgs)
        Try
            Dim saveDialog As New SaveFileDialog With {
                .Filter = "Excel Dosyası|*.csv",
                .FileName = $"AI_Kullanim_Raporu_{DateTime.Now:yyyyMMdd_HHmmss}.csv"
            }
            
            If saveDialog.ShowDialog() = DialogResult.OK Then
                ExportToCSV(saveDialog.FileName)
                MessageBox.Show("Rapor başarıyla dışa aktarıldı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information)
                
                If MessageBox.Show("Dosyayı açmak ister misiniz?", "Aç", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    Process.Start(saveDialog.FileName)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Excel'e aktarılamadı: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    
    Private Sub ExportToCSV(filePath As String)
        Using writer As New StreamWriter(filePath, False, System.Text.Encoding.UTF8)
            ' Başlıklar
            Dim headers As New List(Of String)
            For Each col As DataGridViewColumn In dgvKullanim.Columns
                headers.Add(col.HeaderText)
            Next
            writer.WriteLine(String.Join(";", headers))
            
            ' Veriler
            For Each row As DataGridViewRow In dgvKullanim.Rows
                Dim values As New List(Of String)
                For Each col As DataGridViewColumn In dgvKullanim.Columns
                    Dim value As String = If(row.Cells(col.Index).Value IsNot Nothing, row.Cells(col.Index).Value.ToString(), "")
                    values.Add(value)
                Next
                writer.WriteLine(String.Join(";", values))
            Next
            
            ' Özet bilgileri ekle
            writer.WriteLine("")
            writer.WriteLine("=== ÖZET ===")
            writer.WriteLine(lblToplamSorgu.Text)
            writer.WriteLine(lblToplamToken.Text)
            writer.WriteLine(lblOrtalamaToken.Text)
            writer.WriteLine(lblToplamMaliyet.Text)
        End Using
    End Sub
    
End Class
