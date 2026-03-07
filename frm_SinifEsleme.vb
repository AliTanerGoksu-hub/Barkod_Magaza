Imports System.Data.OleDb
Imports System.Windows.Forms
Imports System.Collections.Generic
Imports System.Drawing

''' <summary>
''' E-Ticaret Sınıf Eşleştirme Ayarları Formu
''' Müşterinin stok sınıf alanlarını (sSinifKodu1-8) e-ticaret alanlarına eşleştirmesini sağlar
''' </summary>
Public Class frm_SinifEsleme
    Inherits Form
    
    Private connection As String = KeyCode.connection
    
    ' UI Kontrolleri
    Private lblBaslik As Label
    Private lblAciklama As Label
    
    ' Sol Panel - Marka ve Kategoriler
    Private grpSol As GroupBox
    Private lblMarka As Label
    Private cmbMarka As ComboBox
    Private lblKategori1 As Label
    Private cmbKategori1 As ComboBox
    Private lblKategori2 As Label
    Private cmbKategori2 As ComboBox
    Private lblKategori3 As Label
    Private cmbKategori3 As ComboBox
    Private lblKategori4 As Label
    Private cmbKategori4 As ComboBox
    Private lblKategori5 As Label
    Private cmbKategori5 As ComboBox
    
    ' Sağ Panel - Etiketler
    Private grpSag As GroupBox
    Private lblEtiket1 As Label
    Private cmbEtiket1 As ComboBox
    Private lblEtiket2 As Label
    Private cmbEtiket2 As ComboBox
    Private lblEtiket3 As Label
    Private cmbEtiket3 As ComboBox
    
    Private btnKaydet As Button
    Private btnIptal As Button
    Private btnVarsayilan As Button
    
    Private pnlOnizleme As GroupBox
    Private dgvOnizleme As DataGridView
    
    ' Sınıf seçenekleri
    Private sinifSecenekleri As New List(Of KeyValuePair(Of String, String))
    
    Public Sub New()
        InitializeComponent()
        LoadSinifSecenekleri()
        LoadCurrentSettings()
    End Sub
    
    Private Sub InitializeComponent()
        Me.Text = "E-Ticaret Sınıf Eşleştirme Ayarları"
        Me.Size = New Size(850, 700)
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.FormBorderStyle = FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.BackColor = Color.FromArgb(250, 250, 252)
        
        Dim yPos As Integer = 15
        
        ' Başlık
        lblBaslik = New Label()
        lblBaslik.Text = "Stok Sınıf Alanları Eşleştirmesi"
        lblBaslik.Font = New Font("Segoe UI", 16, FontStyle.Bold)
        lblBaslik.ForeColor = Color.FromArgb(33, 37, 41)
        lblBaslik.Location = New Point(20, yPos)
        lblBaslik.AutoSize = True
        Me.Controls.Add(lblBaslik)
        
        yPos += 40
        
        ' Açıklama
        lblAciklama = New Label()
        lblAciklama.Text = "Aşağıda e-ticaret için kullanılacak alanları, stok kartınızdaki sınıf alanlarıyla eşleştirin."
        lblAciklama.Font = New Font("Segoe UI", 9)
        lblAciklama.ForeColor = Color.FromArgb(108, 117, 125)
        lblAciklama.Location = New Point(20, yPos)
        lblAciklama.Size = New Size(800, 20)
        Me.Controls.Add(lblAciklama)
        
        yPos += 35
        
        ' ===== SOL PANEL - Marka ve Kategoriler =====
        grpSol = New GroupBox()
        grpSol.Text = "Marka ve Kategoriler"
        grpSol.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        grpSol.ForeColor = Color.FromArgb(33, 37, 41)
        grpSol.Location = New Point(20, yPos)
        grpSol.Size = New Size(390, 280)
        grpSol.BackColor = Color.White
        Me.Controls.Add(grpSol)
        
        Dim solY As Integer = 30
        Dim lblWidth As Integer = 100
        Dim cmbWidth As Integer = 250
        Dim cmbX As Integer = 115
        
        lblMarka = CreateLabel("Marka:", 15, solY, lblWidth, grpSol)
        cmbMarka = CreateComboBox(cmbX, solY - 3, cmbWidth, "cmbMarka", grpSol)
        
        solY += 40
        lblKategori1 = CreateLabel("Kategori 1:", 15, solY, lblWidth, grpSol)
        cmbKategori1 = CreateComboBox(cmbX, solY - 3, cmbWidth, "cmbKategori1", grpSol)
        
        solY += 40
        lblKategori2 = CreateLabel("Kategori 2:", 15, solY, lblWidth, grpSol)
        cmbKategori2 = CreateComboBox(cmbX, solY - 3, cmbWidth, "cmbKategori2", grpSol)
        
        solY += 40
        lblKategori3 = CreateLabel("Kategori 3:", 15, solY, lblWidth, grpSol)
        cmbKategori3 = CreateComboBox(cmbX, solY - 3, cmbWidth, "cmbKategori3", grpSol)
        
        solY += 40
        lblKategori4 = CreateLabel("Kategori 4:", 15, solY, lblWidth, grpSol)
        cmbKategori4 = CreateComboBox(cmbX, solY - 3, cmbWidth, "cmbKategori4", grpSol)
        
        solY += 40
        lblKategori5 = CreateLabel("Kategori 5:", 15, solY, lblWidth, grpSol)
        cmbKategori5 = CreateComboBox(cmbX, solY - 3, cmbWidth, "cmbKategori5", grpSol)
        
        ' ===== SAĞ PANEL - Etiketler =====
        grpSag = New GroupBox()
        grpSag.Text = "Etiketler"
        grpSag.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        grpSag.ForeColor = Color.FromArgb(33, 37, 41)
        grpSag.Location = New Point(430, yPos)
        grpSag.Size = New Size(390, 160)
        grpSag.BackColor = Color.White
        Me.Controls.Add(grpSag)
        
        Dim sagY As Integer = 30
        
        lblEtiket1 = CreateLabel("Etiket 1:", 15, sagY, lblWidth, grpSag)
        cmbEtiket1 = CreateComboBox(cmbX, sagY - 3, cmbWidth, "cmbEtiket1", grpSag)
        
        sagY += 40
        lblEtiket2 = CreateLabel("Etiket 2:", 15, sagY, lblWidth, grpSag)
        cmbEtiket2 = CreateComboBox(cmbX, sagY - 3, cmbWidth, "cmbEtiket2", grpSag)
        
        sagY += 40
        lblEtiket3 = CreateLabel("Etiket 3:", 15, sagY, lblWidth, grpSag)
        cmbEtiket3 = CreateComboBox(cmbX, sagY - 3, cmbWidth, "cmbEtiket3", grpSag)
        
        yPos += 300
        
        ' ===== ÖNİZLEME PANELİ =====
        pnlOnizleme = New GroupBox()
        pnlOnizleme.Text = "Önizleme (İlk 5 Ürün)"
        pnlOnizleme.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        pnlOnizleme.ForeColor = Color.FromArgb(33, 37, 41)
        pnlOnizleme.Location = New Point(20, yPos)
        pnlOnizleme.Size = New Size(800, 200)
        pnlOnizleme.BackColor = Color.White
        Me.Controls.Add(pnlOnizleme)
        
        dgvOnizleme = New DataGridView()
        dgvOnizleme.Location = New Point(10, 25)
        dgvOnizleme.Size = New Size(778, 165)
        dgvOnizleme.ReadOnly = True
        dgvOnizleme.AllowUserToAddRows = False
        dgvOnizleme.AllowUserToDeleteRows = False
        dgvOnizleme.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvOnizleme.RowHeadersVisible = False
        dgvOnizleme.BackgroundColor = Color.White
        dgvOnizleme.BorderStyle = BorderStyle.FixedSingle
        dgvOnizleme.Font = New Font("Segoe UI", 9)
        dgvOnizleme.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        dgvOnizleme.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(248, 249, 250)
        dgvOnizleme.EnableHeadersVisualStyles = False
        pnlOnizleme.Controls.Add(dgvOnizleme)
        
        yPos += 220
        
        ' ===== BUTONLAR =====
        btnVarsayilan = New Button()
        btnVarsayilan.Text = "Varsayılana Dön"
        btnVarsayilan.Location = New Point(20, yPos)
        btnVarsayilan.Size = New Size(140, 40)
        btnVarsayilan.BackColor = Color.FromArgb(108, 117, 125)
        btnVarsayilan.ForeColor = Color.White
        btnVarsayilan.FlatStyle = FlatStyle.Flat
        btnVarsayilan.FlatAppearance.BorderSize = 0
        btnVarsayilan.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        btnVarsayilan.Cursor = Cursors.Hand
        AddHandler btnVarsayilan.Click, AddressOf btnVarsayilan_Click
        Me.Controls.Add(btnVarsayilan)
        
        btnKaydet = New Button()
        btnKaydet.Text = "Kaydet"
        btnKaydet.Location = New Point(560, yPos)
        btnKaydet.Size = New Size(120, 40)
        btnKaydet.BackColor = Color.FromArgb(40, 167, 69)
        btnKaydet.ForeColor = Color.White
        btnKaydet.FlatStyle = FlatStyle.Flat
        btnKaydet.FlatAppearance.BorderSize = 0
        btnKaydet.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        btnKaydet.Cursor = Cursors.Hand
        AddHandler btnKaydet.Click, AddressOf btnKaydet_Click
        Me.Controls.Add(btnKaydet)
        
        btnIptal = New Button()
        btnIptal.Text = "İptal"
        btnIptal.Location = New Point(695, yPos)
        btnIptal.Size = New Size(120, 40)
        btnIptal.BackColor = Color.FromArgb(220, 53, 69)
        btnIptal.ForeColor = Color.White
        btnIptal.FlatStyle = FlatStyle.Flat
        btnIptal.FlatAppearance.BorderSize = 0
        btnIptal.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        btnIptal.Cursor = Cursors.Hand
        AddHandler btnIptal.Click, AddressOf btnIptal_Click
        Me.Controls.Add(btnIptal)
    End Sub
    
    Private Function CreateLabel(text As String, x As Integer, y As Integer, width As Integer, parent As Control) As Label
        Dim lbl As New Label()
        lbl.Text = text
        lbl.Font = New Font("Segoe UI", 10)
        lbl.ForeColor = Color.FromArgb(73, 80, 87)
        lbl.Location = New Point(x, y)
        lbl.Size = New Size(width, 25)
        lbl.TextAlign = ContentAlignment.MiddleLeft
        parent.Controls.Add(lbl)
        Return lbl
    End Function
    
    Private Function CreateComboBox(x As Integer, y As Integer, width As Integer, name As String, parent As Control) As ComboBox
        Dim cmb As New ComboBox()
        cmb.Name = name
        cmb.Location = New Point(x, y)
        cmb.Size = New Size(width, 28)
        cmb.DropDownStyle = ComboBoxStyle.DropDownList
        cmb.Font = New Font("Segoe UI", 9)
        AddHandler cmb.SelectedIndexChanged, AddressOf ComboBox_SelectedIndexChanged
        parent.Controls.Add(cmb)
        Return cmb
    End Function
    
    Private Sub LoadSinifSecenekleri()
        ' Önce sınıf isimlerini veritabanından çek
        Dim sinifIsimleri As New Dictionary(Of Integer, String)
        
        Try
            Using conn As New OleDbConnection(connection)
                conn.Open()
                
                ' Her sınıf tablosunun adını çek (tbSSinif1, tbSSinif2, ... tbSSinif8)
                For i As Integer = 1 To 8
                    Try
                        ' Sınıf tablosunun var olup olmadığını ve ilk kaydın açıklamasını kontrol et
                        Dim checkSql As String = $"SELECT TOP 1 sAciklama FROM tbSSinif{i}"
                        Using cmd As New OleDbCommand(checkSql, conn)
                            Dim result As Object = cmd.ExecuteScalar()
                            If result IsNot Nothing AndAlso result IsNot DBNull.Value Then
                                ' İlk kaydın açıklaması varsa onu kullan (sınıf tipini gösterir)
                                sinifIsimleri(i) = $"Sınıf {i}"
                            Else
                                sinifIsimleri(i) = $"Sınıf {i}"
                            End If
                        End Using
                        
                        ' Sınıf adını bulmak için tbSinifTanimlari veya benzeri tablo kontrol et
                        Try
                            Dim adSql As String = $"SELECT sSinifAdi FROM tbSinifTanimlari WHERE nSinifNo = {i}"
                            Using cmdAd As New OleDbCommand(adSql, conn)
                                Dim adResult As Object = cmdAd.ExecuteScalar()
                                If adResult IsNot Nothing AndAlso adResult IsNot DBNull.Value AndAlso Not String.IsNullOrEmpty(adResult.ToString()) Then
                                    sinifIsimleri(i) = $"Sınıf {i} - {adResult.ToString()}"
                                End If
                            End Using
                        Catch
                            ' Tablo yoksa veya hata varsa varsayılan ismi kullan
                        End Try
                        
                    Catch
                        sinifIsimleri(i) = $"Sınıf {i}"
                    End Try
                Next
                
                conn.Close()
            End Using
        Catch
        End Try
        
        ' Boş seçenek
        sinifSecenekleri.Add(New KeyValuePair(Of String, String)("", "(Kullanılmasın)"))
        
        ' Sınıf 1-8
        For i As Integer = 1 To 8
            Dim sinifAdi As String = If(sinifIsimleri.ContainsKey(i), sinifIsimleri(i), $"Sınıf {i}")
            sinifSecenekleri.Add(New KeyValuePair(Of String, String)($"sSinifKodu{i}", sinifAdi))
        Next
        
        ' Grup alanları
        sinifSecenekleri.Add(New KeyValuePair(Of String, String)("sGrup1", "Grup 1"))
        sinifSecenekleri.Add(New KeyValuePair(Of String, String)("sGrup2", "Grup 2"))
        sinifSecenekleri.Add(New KeyValuePair(Of String, String)("sGrup3", "Grup 3"))
        
        ' Diğer alanlar
        sinifSecenekleri.Add(New KeyValuePair(Of String, String)("sModel", "Model"))
        sinifSecenekleri.Add(New KeyValuePair(Of String, String)("sRenk", "Renk"))
        sinifSecenekleri.Add(New KeyValuePair(Of String, String)("sBeden", "Beden"))
        
        ' ComboBox'ları doldur
        Dim allCombos() As ComboBox = {cmbMarka, cmbKategori1, cmbKategori2, cmbKategori3, cmbKategori4, cmbKategori5, cmbEtiket1, cmbEtiket2, cmbEtiket3}
        
        For Each cmb As ComboBox In allCombos
            cmb.Items.Clear()
            For Each kvp As KeyValuePair(Of String, String) In sinifSecenekleri
                cmb.Items.Add(kvp)
            Next
            cmb.DisplayMember = "Value"
            cmb.ValueMember = "Key"
        Next
    End Sub
    
    Private Sub LoadCurrentSettings()
        Try
            Using conn As New OleDbConnection(connection)
                conn.Open()
                
                ' Ayarları veritabanından yükle
                SetComboValue(cmbMarka, AyarOku(conn, "ETICARET_SINIF_MARKA", "sSinifKodu3"))
                SetComboValue(cmbKategori1, AyarOku(conn, "ETICARET_SINIF_KAT1", "sSinifKodu4"))
                SetComboValue(cmbKategori2, AyarOku(conn, "ETICARET_SINIF_KAT2", "sSinifKodu5"))
                SetComboValue(cmbKategori3, AyarOku(conn, "ETICARET_SINIF_KAT3", "sSinifKodu6"))
                SetComboValue(cmbKategori4, AyarOku(conn, "ETICARET_SINIF_KAT4", "sSinifKodu7"))
                SetComboValue(cmbKategori5, AyarOku(conn, "ETICARET_SINIF_KAT5", "sSinifKodu8"))
                SetComboValue(cmbEtiket1, AyarOku(conn, "ETICARET_SINIF_ETIKET1", "sSinifKodu5"))
                SetComboValue(cmbEtiket2, AyarOku(conn, "ETICARET_SINIF_ETIKET2", "sSinifKodu6"))
                SetComboValue(cmbEtiket3, AyarOku(conn, "ETICARET_SINIF_ETIKET3", "sSinifKodu7"))
                
                conn.Close()
            End Using
            
            ' Önizleme yükle
            LoadPreview()
            
        Catch ex As Exception
            MessageBox.Show($"Ayarlar yüklenirken hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    
    Private Function AyarOku(conn As OleDbConnection, ayarKodu As String, varsayilan As String) As String
        Try
            Using cmd As New OleDbCommand($"SELECT sAyarDeger FROM tbSistemAyar WHERE sAyarKodu = '{ayarKodu}'", conn)
                Dim result As Object = cmd.ExecuteScalar()
                If result IsNot Nothing AndAlso result IsNot DBNull.Value Then
                    Return result.ToString()
                End If
            End Using
        Catch
        End Try
        Return varsayilan
    End Function
    
    Private Sub AyarKaydet(conn As OleDbConnection, ayarKodu As String, deger As String, aciklama As String)
        Try
            ' Önce var mı kontrol et
            Using cmdCheck As New OleDbCommand($"SELECT COUNT(*) FROM tbSistemAyar WHERE sAyarKodu = '{ayarKodu}'", conn)
                Dim count As Integer = CInt(cmdCheck.ExecuteScalar())
                
                If count > 0 Then
                    ' Güncelle
                    Using cmdUpdate As New OleDbCommand($"UPDATE tbSistemAyar SET sAyarDeger = '{deger}' WHERE sAyarKodu = '{ayarKodu}'", conn)
                        cmdUpdate.ExecuteNonQuery()
                    End Using
                Else
                    ' Ekle
                    Using cmdInsert As New OleDbCommand($"INSERT INTO tbSistemAyar (sAyarKodu, sAyarDeger, sAciklama) VALUES ('{ayarKodu}', '{deger}', '{aciklama}')", conn)
                        cmdInsert.ExecuteNonQuery()
                    End Using
                End If
            End Using
        Catch ex As Exception
            Debug.WriteLine($"AyarKaydet hatası: {ex.Message}")
        End Try
    End Sub
    
    Private Sub SetComboValue(cmb As ComboBox, value As String)
        For i As Integer = 0 To cmb.Items.Count - 1
            Dim kvp As KeyValuePair(Of String, String) = CType(cmb.Items(i), KeyValuePair(Of String, String))
            If kvp.Key = value Then
                cmb.SelectedIndex = i
                Exit For
            End If
        Next
    End Sub
    
    Private Function GetComboValue(cmb As ComboBox) As String
        If cmb.SelectedItem IsNot Nothing Then
            Dim kvp As KeyValuePair(Of String, String) = CType(cmb.SelectedItem, KeyValuePair(Of String, String))
            Return kvp.Key
        End If
        Return ""
    End Function
    
    Private Sub ComboBox_SelectedIndexChanged(sender As Object, e As EventArgs)
        LoadPreview()
    End Sub
    
    Private Sub LoadPreview()
        Try
            dgvOnizleme.DataSource = Nothing
            dgvOnizleme.Columns.Clear()
            
            ' Seçili combo'lardan açıklayıcı isimleri al
            Dim markaDisplayName As String = GetComboDisplayName(cmbMarka)
            Dim kat1DisplayName As String = GetComboDisplayName(cmbKategori1)
            Dim kat2DisplayName As String = GetComboDisplayName(cmbKategori2)
            Dim kat3DisplayName As String = GetComboDisplayName(cmbKategori3)
            
            Dim markaField As String = GetSqlField(GetComboValue(cmbMarka), "Marka")
            Dim kat1Field As String = GetSqlField(GetComboValue(cmbKategori1), "Kategori1")
            Dim kat2Field As String = GetSqlField(GetComboValue(cmbKategori2), "Kategori2")
            Dim kat3Field As String = GetSqlField(GetComboValue(cmbKategori3), "Kategori3")
            
            Dim sql As String = "SELECT TOP 5 s.sModel AS Model, s.sRenk AS Renk, " & markaField & ", " & kat1Field & ", " & kat2Field & ", " & kat3Field & " " &
                               "FROM tbStok s " &
                               "LEFT JOIN tbStokSinifi ss ON ss.nStokID = s.nStokID " &
                               "WHERE s.bWebGoruntule = 1 " &
                               "ORDER BY s.nStokID DESC"
            
            Using conn As New OleDbConnection(connection)
                conn.Open()
                Using cmd As New OleDbCommand(sql, conn)
                    Using adapter As New OleDbDataAdapter(cmd)
                        Dim dt As New DataTable()
                        adapter.Fill(dt)
                        dgvOnizleme.DataSource = dt
                        
                        ' Sütun başlıklarını açıklayıcı isimlerle güncelle
                        If dgvOnizleme.Columns.Count >= 6 Then
                            dgvOnizleme.Columns(0).HeaderText = "Model"
                            dgvOnizleme.Columns(1).HeaderText = "Renk"
                            dgvOnizleme.Columns(2).HeaderText = If(String.IsNullOrEmpty(markaDisplayName), "Marka", markaDisplayName)
                            dgvOnizleme.Columns(3).HeaderText = If(String.IsNullOrEmpty(kat1DisplayName), "Kategori 1", kat1DisplayName)
                            dgvOnizleme.Columns(4).HeaderText = If(String.IsNullOrEmpty(kat2DisplayName), "Kategori 2", kat2DisplayName)
                            dgvOnizleme.Columns(5).HeaderText = If(String.IsNullOrEmpty(kat3DisplayName), "Kategori 3", kat3DisplayName)
                        End If
                    End Using
                End Using
            End Using
            
        Catch ex As Exception
            Debug.WriteLine($"Önizleme hatası: {ex.Message}")
        End Try
    End Sub
    
    ''' <summary>
    ''' ComboBox'tan seçili öğenin görüntülenen adını döndürür
    ''' </summary>
    Private Function GetComboDisplayName(cmb As ComboBox) As String
        If cmb.SelectedItem IsNot Nothing Then
            Dim kvp As KeyValuePair(Of String, String) = CType(cmb.SelectedItem, KeyValuePair(Of String, String))
            Return kvp.Value
        End If
        Return ""
    End Function
    
    Private Function GetSqlField(fieldCode As String, aliasName As String) As String
        If String.IsNullOrEmpty(fieldCode) Then
            Return "'' AS " & aliasName
        End If
        
        ' Sınıf alanları için lookup
        If fieldCode.StartsWith("sSinifKodu") Then
            Dim sinifNo As String = fieldCode.Replace("sSinifKodu", "")
            Return "(SELECT sAciklama FROM tbSSinif" & sinifNo & " WHERE sSinifKodu = ss." & fieldCode & ") AS " & aliasName
        End If
        
        ' Doğrudan alan
        Return "s." & fieldCode & " AS " & aliasName
    End Function
    
    Private Sub btnKaydet_Click(sender As Object, e As EventArgs)
        Try
            Using conn As New OleDbConnection(connection)
                conn.Open()
                
                AyarKaydet(conn, "ETICARET_SINIF_MARKA", GetComboValue(cmbMarka), "E-Ticaret Marka Sınıf Eşleştirmesi")
                AyarKaydet(conn, "ETICARET_SINIF_KAT1", GetComboValue(cmbKategori1), "E-Ticaret Kategori 1 Sınıf Eşleştirmesi")
                AyarKaydet(conn, "ETICARET_SINIF_KAT2", GetComboValue(cmbKategori2), "E-Ticaret Kategori 2 Sınıf Eşleştirmesi")
                AyarKaydet(conn, "ETICARET_SINIF_KAT3", GetComboValue(cmbKategori3), "E-Ticaret Kategori 3 Sınıf Eşleştirmesi")
                AyarKaydet(conn, "ETICARET_SINIF_KAT4", GetComboValue(cmbKategori4), "E-Ticaret Kategori 4 Sınıf Eşleştirmesi")
                AyarKaydet(conn, "ETICARET_SINIF_KAT5", GetComboValue(cmbKategori5), "E-Ticaret Kategori 5 Sınıf Eşleştirmesi")
                AyarKaydet(conn, "ETICARET_SINIF_ETIKET1", GetComboValue(cmbEtiket1), "E-Ticaret Etiket 1 Sınıf Eşleştirmesi")
                AyarKaydet(conn, "ETICARET_SINIF_ETIKET2", GetComboValue(cmbEtiket2), "E-Ticaret Etiket 2 Sınıf Eşleştirmesi")
                AyarKaydet(conn, "ETICARET_SINIF_ETIKET3", GetComboValue(cmbEtiket3), "E-Ticaret Etiket 3 Sınıf Eşleştirmesi")
                
                conn.Close()
            End Using
            
            MessageBox.Show("Sınıf eşleştirme ayarları kaydedildi." & vbCrLf & vbCrLf & _
                           "Not: Değişikliklerin uygulanması için e-ticaret senkronizasyonunu yeniden başlatın.", _
                           "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information)
            
            Me.DialogResult = DialogResult.OK
            Me.Close()
            
        Catch ex As Exception
            MessageBox.Show($"Kaydetme hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    
    Private Sub btnIptal_Click(sender As Object, e As EventArgs)
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
    
    Private Sub btnVarsayilan_Click(sender As Object, e As EventArgs)
        ' Varsayılan değerlere dön
        SetComboValue(cmbMarka, "sSinifKodu3")
        SetComboValue(cmbKategori1, "sSinifKodu4")
        SetComboValue(cmbKategori2, "sSinifKodu5")
        SetComboValue(cmbKategori3, "sSinifKodu6")
        SetComboValue(cmbKategori4, "sSinifKodu7")
        SetComboValue(cmbKategori5, "sSinifKodu8")
        SetComboValue(cmbEtiket1, "sSinifKodu5")
        SetComboValue(cmbEtiket2, "sSinifKodu6")
        SetComboValue(cmbEtiket3, "sSinifKodu7")
        
        LoadPreview()
    End Sub
End Class
