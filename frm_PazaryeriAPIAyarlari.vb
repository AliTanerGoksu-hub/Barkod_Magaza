' ============================================================================
' PAZARYERI API AYARLARI
' Dosya: frm_PazaryeriAPIAyarlari.vb
' Aciklama: Tum pazaryerleri API bilgilerini tbPazaryeriAyar tablosunda saklar
' ============================================================================

Imports System.Windows.Forms
Imports System.Drawing
Imports System.Data.OleDb
Imports System.Collections.Generic

Public Class frm_PazaryeriAPIAyarlari
    
    Public connection As String = ""
    
    Private tabControl As TabControl
    Private btnKaydet As Button
    Private btnIptal As Button
    Private lblStatus As Label
    
    ' Tum pazaryerleri icin textbox'lar
    Private pazaryeriControls As New Dictionary(Of String, PazaryeriPanel)
    
    Private Class PazaryeriPanel
        Public txtSellerId As TextBox
        Public txtApiKey As TextBox
        Public txtApiSecret As TextBox
        Public txtBaseUrl As TextBox
        Public lblSellerIdLabel As String = "Satici ID:"
    End Class
    
    Private pazaryeriListesi() As String = {
        "Trendyol", "Hepsiburada", "N11", "Amazon", "PttAVM", 
        "CicekSepeti", "Pazarama", "Modanisa", "Farmazon", "Idefix", "LCWaikiki"
    }
    
    Public Sub New()
        InitializeComponent()
    End Sub
    
    Private Sub frm_PazaryeriAPIAyarlari_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If String.IsNullOrEmpty(connection) Then
            connection = KeyCode.connection
        End If
        
        ' Tablo yoksa olustur
        CreateTableIfNotExists()
        
        ' Ayarlari yukle
        LoadAllSettings()
    End Sub
    
    Private Sub InitializeComponent()
        Me.Text = "Pazaryeri API Ayarlari"
        Me.Size = New Size(600, 450)
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.FormBorderStyle = FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.BackColor = Color.White
        
        ' TabControl
        tabControl = New TabControl()
        tabControl.Location = New Point(10, 10)
        tabControl.Size = New Size(565, 340)
        Me.Controls.Add(tabControl)
        
        ' Her pazaryeri icin tab olustur
        For Each pazar As String In pazaryeriListesi
            CreatePazaryeriTab(pazar)
        Next
        
        ' Status
        lblStatus = New Label()
        lblStatus.Location = New Point(15, 360)
        lblStatus.Size = New Size(330, 20)
        lblStatus.ForeColor = Color.Gray
        Me.Controls.Add(lblStatus)
        
        ' Butonlar
        btnKaydet = New Button()
        btnKaydet.Text = "Kaydet"
        btnKaydet.Size = New Size(100, 35)
        btnKaydet.Location = New Point(360, 360)
        btnKaydet.BackColor = Color.FromArgb(76, 175, 80)
        btnKaydet.ForeColor = Color.White
        btnKaydet.FlatStyle = FlatStyle.Flat
        AddHandler btnKaydet.Click, AddressOf btnKaydet_Click
        Me.Controls.Add(btnKaydet)
        
        btnIptal = New Button()
        btnIptal.Text = "Kapat"
        btnIptal.Size = New Size(100, 35)
        btnIptal.Location = New Point(470, 360)
        btnIptal.BackColor = Color.Gray
        btnIptal.ForeColor = Color.White
        btnIptal.FlatStyle = FlatStyle.Flat
        AddHandler btnIptal.Click, AddressOf btnIptal_Click
        Me.Controls.Add(btnIptal)
    End Sub
    
    Private Sub CreatePazaryeriTab(pazaryeri As String)
        Dim tab As New TabPage(pazaryeri)
        tab.BackColor = Color.White
        tabControl.TabPages.Add(tab)
        
        Dim panel As New PazaryeriPanel()
        
        ' Her pazaryeri icin gercek API alanlari
        Select Case pazaryeri
            Case "Trendyol"
                ' Trendyol: Supplier ID, API Key, API Secret
                CreateLabel(tab, "Supplier ID:", 20, 30)
                panel.txtSellerId = CreateTextBox(tab, 140, 27, False)
                CreateLabel(tab, "API Key:", 20, 70)
                panel.txtApiKey = CreateTextBox(tab, 140, 67, False)
                CreateLabel(tab, "API Secret:", 20, 110)
                panel.txtApiSecret = CreateTextBox(tab, 140, 107, True)
                CreateLabel(tab, "Base URL:", 20, 150)
                panel.txtBaseUrl = CreateTextBox(tab, 140, 147, False)
                panel.txtBaseUrl.Text = "https://api.trendyol.com/sapigw"
                AddInfoLabel(tab, "Trendyol Satici Paneli > Entegrasyon > API Bilgileri", 190)
                
            Case "Hepsiburada"
                ' Hepsiburada: Merchant ID + Bearer Token (Servis Anahtari)
                CreateLabel(tab, "Merchant ID:", 20, 30)
                panel.txtSellerId = CreateTextBox(tab, 140, 27, False)
                CreateLabel(tab, "Bearer Token:", 20, 70)
                panel.txtApiSecret = CreateTextBox(tab, 140, 67, True)
                CreateLabel(tab, "Base URL:", 20, 110)
                panel.txtBaseUrl = CreateTextBox(tab, 140, 107, False)
                panel.txtBaseUrl.Text = "https://mpop-sit.hepsiburada.com"
                panel.txtApiKey = New TextBox()
                AddInfoLabel(tab, "Hepsiburada Satici Paneli > Hesabim > Entegrasyon > Entegrator Bilgileri", 150)
                
            Case "N11"
                ' N11: API Key + App Secret
                CreateLabel(tab, "API Key:", 20, 30)
                panel.txtApiKey = CreateTextBox(tab, 140, 27, False)
                CreateLabel(tab, "App Secret:", 20, 70)
                panel.txtApiSecret = CreateTextBox(tab, 140, 67, True)
                CreateLabel(tab, "Base URL:", 20, 110)
                panel.txtBaseUrl = CreateTextBox(tab, 140, 107, False)
                panel.txtBaseUrl.Text = "https://api.n11.com/ws"
                panel.txtSellerId = New TextBox()
                AddInfoLabel(tab, "N11 Satici Paneli > Hesabim > API Hesaplari", 150)
                
            Case "Amazon"
                ' Amazon SP-API: Client ID, Client Secret, Refresh Token
                CreateLabel(tab, "Client ID:", 20, 30)
                panel.txtSellerId = CreateTextBox(tab, 140, 27, False)
                CreateLabel(tab, "Client Secret:", 20, 70)
                panel.txtApiKey = CreateTextBox(tab, 140, 67, True)
                CreateLabel(tab, "Refresh Token:", 20, 110)
                panel.txtApiSecret = CreateTextBox(tab, 140, 107, True)
                CreateLabel(tab, "Marketplace ID:", 20, 150)
                panel.txtBaseUrl = CreateTextBox(tab, 140, 147, False)
                panel.txtBaseUrl.Text = "A33AVAJ2PDY3EV"
                AddInfoLabel(tab, "Amazon Seller Central > Partner Network > Develop Apps", 190)
                
            Case "PttAVM"
                ' PttAVM: Magaza ID, API Key (Kategori yoneticisinden istenir)
                CreateLabel(tab, "Magaza ID:", 20, 30)
                panel.txtSellerId = CreateTextBox(tab, 140, 27, False)
                CreateLabel(tab, "API Key:", 20, 70)
                panel.txtApiKey = CreateTextBox(tab, 140, 67, False)
                CreateLabel(tab, "API Secret:", 20, 110)
                panel.txtApiSecret = CreateTextBox(tab, 140, 107, True)
                CreateLabel(tab, "Base URL:", 20, 150)
                panel.txtBaseUrl = CreateTextBox(tab, 140, 147, False)
                panel.txtBaseUrl.Text = "https://api.pttavm.com"
                AddInfoLabel(tab, "PttAVM Satici Paneli > Hesap Yonetimi > Entegrasyon Bilgileri", 190)
                
            Case "CicekSepeti"
                ' CicekSepeti: API Key (bayi.ciceksepeti.com > Api Access)
                CreateLabel(tab, "Satici Kodu:", 20, 30)
                panel.txtSellerId = CreateTextBox(tab, 140, 27, False)
                CreateLabel(tab, "API Key:", 20, 70)
                panel.txtApiKey = CreateTextBox(tab, 140, 67, False)
                CreateLabel(tab, "Base URL:", 20, 110)
                panel.txtBaseUrl = CreateTextBox(tab, 140, 107, False)
                panel.txtBaseUrl.Text = "https://apis.ciceksepeti.com"
                panel.txtApiSecret = New TextBox()
                AddInfoLabel(tab, "bayi.ciceksepeti.com > Magaza Yonetimi > Urunlerim > Api Access", 150)
                
            Case "Pazarama"
                CreateLabel(tab, "Magaza ID:", 20, 30)
                panel.txtSellerId = CreateTextBox(tab, 140, 27, False)
                CreateLabel(tab, "API Key:", 20, 70)
                panel.txtApiKey = CreateTextBox(tab, 140, 67, False)
                CreateLabel(tab, "API Secret:", 20, 110)
                panel.txtApiSecret = CreateTextBox(tab, 140, 107, True)
                CreateLabel(tab, "Base URL:", 20, 150)
                panel.txtBaseUrl = CreateTextBox(tab, 140, 147, False)
                panel.txtBaseUrl.Text = "https://isortagim.pazarama.com"
                AddInfoLabel(tab, "Pazarama Satici Paneli > Entegrasyon Ayarlari", 190)
                
            Case "Modanisa"
                CreateLabel(tab, "Vendor ID:", 20, 30)
                panel.txtSellerId = CreateTextBox(tab, 140, 27, False)
                CreateLabel(tab, "API Token:", 20, 70)
                panel.txtApiKey = CreateTextBox(tab, 140, 67, False)
                CreateLabel(tab, "Base URL:", 20, 110)
                panel.txtBaseUrl = CreateTextBox(tab, 140, 107, False)
                panel.txtBaseUrl.Text = "https://api.modanisa.com"
                panel.txtApiSecret = New TextBox()
                AddInfoLabel(tab, "Modanisa Satici Paneli > API Ayarlari", 150)
                
            Case "Farmazon"
                CreateLabel(tab, "Satici ID:", 20, 30)
                panel.txtSellerId = CreateTextBox(tab, 140, 27, False)
                CreateLabel(tab, "API Key:", 20, 70)
                panel.txtApiKey = CreateTextBox(tab, 140, 67, False)
                CreateLabel(tab, "API Secret:", 20, 110)
                panel.txtApiSecret = CreateTextBox(tab, 140, 107, True)
                panel.txtBaseUrl = New TextBox()
                AddInfoLabel(tab, "Farmazon Satici Paneli > Entegrasyon", 150)
                
            Case "Idefix"
                CreateLabel(tab, "Satici ID:", 20, 30)
                panel.txtSellerId = CreateTextBox(tab, 140, 27, False)
                CreateLabel(tab, "API Key:", 20, 70)
                panel.txtApiKey = CreateTextBox(tab, 140, 67, False)
                CreateLabel(tab, "API Secret:", 20, 110)
                panel.txtApiSecret = CreateTextBox(tab, 140, 107, True)
                panel.txtBaseUrl = New TextBox()
                AddInfoLabel(tab, "Idefix Satici Paneli > API Ayarlari", 150)
                
            Case "LCWaikiki"
                CreateLabel(tab, "Vendor Code:", 20, 30)
                panel.txtSellerId = CreateTextBox(tab, 140, 27, False)
                CreateLabel(tab, "API Key:", 20, 70)
                panel.txtApiKey = CreateTextBox(tab, 140, 67, False)
                CreateLabel(tab, "API Secret:", 20, 110)
                panel.txtApiSecret = CreateTextBox(tab, 140, 107, True)
                panel.txtBaseUrl = New TextBox()
                AddInfoLabel(tab, "LCWaikiki Tedarikci Paneli > Entegrasyon", 150)
                
            Case Else
                CreateLabel(tab, "Satici ID:", 20, 30)
                panel.txtSellerId = CreateTextBox(tab, 140, 27, False)
                CreateLabel(tab, "API Key:", 20, 70)
                panel.txtApiKey = CreateTextBox(tab, 140, 67, False)
                CreateLabel(tab, "API Secret:", 20, 110)
                panel.txtApiSecret = CreateTextBox(tab, 140, 107, True)
                CreateLabel(tab, "Base URL:", 20, 150)
                panel.txtBaseUrl = CreateTextBox(tab, 140, 147, False)
        End Select
        
        pazaryeriControls(pazaryeri) = panel
    End Sub
    
    Private Sub AddInfoLabel(tab As TabPage, text As String, yPos As Integer)
        Dim lblInfo As New Label()
        lblInfo.Text = "* " & text
        lblInfo.Location = New Point(20, yPos)
        lblInfo.AutoSize = True
        lblInfo.ForeColor = Color.Gray
        lblInfo.Font = New Font("Segoe UI", 8)
        tab.Controls.Add(lblInfo)
    End Sub
    
    Private Function GetDefaultBaseUrl(pazaryeri As String) As String
        Select Case pazaryeri
            Case "Trendyol" : Return "https://api.trendyol.com/sapigw"
            Case "Hepsiburada" : Return "https://mpop-sit.hepsiburada.com"
            Case "N11" : Return "https://api.n11.com/ws"
            Case "Amazon" : Return "https://sellingpartnerapi-eu.amazon.com"
            Case "PttAVM" : Return "https://api.pttavm.com"
            Case "CicekSepeti" : Return "https://apis.ciceksepeti.com"
            Case "Pazarama" : Return "https://isortagim.pazarama.com"
            Case "Modanisa" : Return "https://api.modanisa.com"
            Case Else : Return ""
        End Select
    End Function
    
    Private Sub CreateLabel(parent As Control, text As String, x As Integer, y As Integer)
        Dim lbl As New Label()
        lbl.Text = text
        lbl.Location = New Point(x, y)
        lbl.AutoSize = True
        parent.Controls.Add(lbl)
    End Sub
    
    Private Function CreateTextBox(parent As Control, x As Integer, y As Integer, isPassword As Boolean) As TextBox
        Dim txt As New TextBox()
        txt.Location = New Point(x, y)
        txt.Size = New Size(400, 25)
        If isPassword Then txt.UseSystemPasswordChar = True
        parent.Controls.Add(txt)
        Return txt
    End Function
    
    Private Sub CreateTableIfNotExists()
        Try
            If String.IsNullOrEmpty(connection) Then Return
            
            Using con As New OleDbConnection(connection)
                con.Open()
                
                ' Tablo var mi kontrol et
                Dim tableExists As Boolean = False
                Try
                    Using cmd As New OleDbCommand("SELECT TOP 1 * FROM tbPazaryeriAyar", con)
                        cmd.ExecuteReader().Close()
                        tableExists = True
                    End Using
                Catch
                    tableExists = False
                End Try
                
                ' Tablo yoksa olustur (SQL Server)
                If Not tableExists Then
                    Dim createSql As String = "CREATE TABLE tbPazaryeriAyar (" &
                        "nID INT IDENTITY(1,1) PRIMARY KEY, " &
                        "sPazaryeri NVARCHAR(50), " &
                        "sSellerId NVARCHAR(100), " &
                        "sApiKey NVARCHAR(255), " &
                        "sApiSecret NVARCHAR(255), " &
                        "sBaseUrl NVARCHAR(255), " &
                        "bAktif BIT DEFAULT 1, " &
                        "dteOlusturma DATETIME, " &
                        "dteGuncelleme DATETIME)"
                    
                    Using cmd As New OleDbCommand(createSql, con)
                        cmd.ExecuteNonQuery()
                    End Using
                    
                    lblStatus.Text = "tbPazaryeriAyar tablosu olusturuldu"
                    lblStatus.ForeColor = Color.Blue
                End If
                
                ' Eski tbTrendyolAyar tablosundan verileri aktar
                MigrateTrendyolData(con)
            End Using
        Catch ex As Exception
            lblStatus.Text = "Tablo olusturma hatasi: " & ex.Message
            lblStatus.ForeColor = Color.Red
        End Try
    End Sub
    
    Private Sub MigrateTrendyolData(con As OleDbConnection)
        Try
            ' Yeni tabloda Trendyol kaydi var mi kontrol et
            Dim hasTrendyol As Boolean = False
            Using cmdCheck As New OleDbCommand("SELECT COUNT(*) FROM tbPazaryeriAyar WHERE sPazaryeri = 'Trendyol'", con)
                hasTrendyol = Convert.ToInt32(cmdCheck.ExecuteScalar()) > 0
            End Using
            
            ' Eger yeni tabloda Trendyol yoksa, eski tablodan aktar
            If Not hasTrendyol Then
                Try
                    Using cmdOld As New OleDbCommand("SELECT TOP 1 sSupplierId, sApiKey, sApiSecret, sBaseUrl FROM tbTrendyolAyar WHERE bAktif = 1", con)
                        Using reader = cmdOld.ExecuteReader()
                            If reader.Read() Then
                                Dim sellerId As String = If(IsDBNull(reader("sSupplierId")), "", reader("sSupplierId").ToString())
                                Dim apiKey As String = If(IsDBNull(reader("sApiKey")), "", reader("sApiKey").ToString())
                                Dim apiSecret As String = If(IsDBNull(reader("sApiSecret")), "", reader("sApiSecret").ToString())
                                Dim baseUrl As String = If(IsDBNull(reader("sBaseUrl")), "https://api.trendyol.com/sapigw", reader("sBaseUrl").ToString())
                                
                                reader.Close()
                                
                                ' Eski veriler varsa yeni tabloya ekle
                                If Not String.IsNullOrEmpty(apiKey) Then
                                    Using cmdInsert As New OleDbCommand("INSERT INTO tbPazaryeriAyar (sPazaryeri, sSellerId, sApiKey, sApiSecret, sBaseUrl, bAktif, dteOlusturma) VALUES (?, ?, ?, ?, ?, 1, ?)", con)
                                        cmdInsert.Parameters.AddWithValue("@p1", "Trendyol")
                                        cmdInsert.Parameters.AddWithValue("@p2", sellerId)
                                        cmdInsert.Parameters.AddWithValue("@p3", apiKey)
                                        cmdInsert.Parameters.AddWithValue("@p4", apiSecret)
                                        cmdInsert.Parameters.AddWithValue("@p5", baseUrl)
                                        cmdInsert.Parameters.AddWithValue("@p6", DateTime.Now)
                                        cmdInsert.ExecuteNonQuery()
                                    End Using
                                    
                                    lblStatus.Text = "Eski Trendyol ayarlari aktarildi"
                                    lblStatus.ForeColor = Color.Blue
                                End If
                            End If
                        End Using
                    End Using
                Catch
                    ' Eski tablo yoksa sessizce devam et
                End Try
            End If
        Catch ex As Exception
            ' Migration hatasi kritik degil, devam et
        End Try
    End Sub
    
    Private Sub LoadAllSettings()
        Try
            If String.IsNullOrEmpty(connection) Then Return
            
            Using con As New OleDbConnection(connection)
                con.Open()
                
                Using cmd As New OleDbCommand("SELECT * FROM tbPazaryeriAyar WHERE bAktif = 1", con)
                    Using reader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim pazar As String = reader("sPazaryeri").ToString()
                            
                            If pazaryeriControls.ContainsKey(pazar) Then
                                Dim panel = pazaryeriControls(pazar)
                                panel.txtSellerId.Text = If(IsDBNull(reader("sSellerId")), "", reader("sSellerId").ToString())
                                panel.txtApiKey.Text = If(IsDBNull(reader("sApiKey")), "", reader("sApiKey").ToString())
                                panel.txtApiSecret.Text = If(IsDBNull(reader("sApiSecret")), "", reader("sApiSecret").ToString())
                                If Not IsDBNull(reader("sBaseUrl")) AndAlso reader("sBaseUrl").ToString() <> "" Then
                                    panel.txtBaseUrl.Text = reader("sBaseUrl").ToString()
                                End If
                            End If
                        End While
                    End Using
                End Using
            End Using
            
            lblStatus.Text = "Ayarlar yuklendi"
            lblStatus.ForeColor = Color.Green
        Catch ex As Exception
            lblStatus.Text = "Yukleme hatasi: " & ex.Message
            lblStatus.ForeColor = Color.Red
        End Try
    End Sub
    
    Private Sub btnKaydet_Click(sender As Object, e As EventArgs)
        Try
            If String.IsNullOrEmpty(connection) Then
                MessageBox.Show("Veritabani baglantisi bulunamadi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            
            Using con As New OleDbConnection(connection)
                con.Open()
                
                For Each pazar As String In pazaryeriListesi
                    Dim panel = pazaryeriControls(pazar)
                    
                    ' Bu pazaryeri icin kayit var mi?
                    Dim exists As Boolean = False
                    Using cmdCheck As New OleDbCommand("SELECT COUNT(*) FROM tbPazaryeriAyar WHERE sPazaryeri = ?", con)
                        cmdCheck.Parameters.AddWithValue("@p", pazar)
                        exists = Convert.ToInt32(cmdCheck.ExecuteScalar()) > 0
                    End Using
                    
                    If exists Then
                        ' Guncelle
                        Using cmd As New OleDbCommand("UPDATE tbPazaryeriAyar SET sSellerId=?, sApiKey=?, sApiSecret=?, sBaseUrl=?, dteGuncelleme=? WHERE sPazaryeri=?", con)
                            cmd.Parameters.AddWithValue("@p1", panel.txtSellerId.Text.Trim())
                            cmd.Parameters.AddWithValue("@p2", panel.txtApiKey.Text.Trim())
                            cmd.Parameters.AddWithValue("@p3", panel.txtApiSecret.Text.Trim())
                            cmd.Parameters.AddWithValue("@p4", panel.txtBaseUrl.Text.Trim())
                            cmd.Parameters.AddWithValue("@p5", DateTime.Now)
                            cmd.Parameters.AddWithValue("@p6", pazar)
                            cmd.ExecuteNonQuery()
                        End Using
                    Else
                        ' Ekle
                        Using cmd As New OleDbCommand("INSERT INTO tbPazaryeriAyar (sPazaryeri, sSellerId, sApiKey, sApiSecret, sBaseUrl, bAktif, dteOlusturma) VALUES (?, ?, ?, ?, ?, 1, ?)", con)
                            cmd.Parameters.AddWithValue("@p1", pazar)
                            cmd.Parameters.AddWithValue("@p2", panel.txtSellerId.Text.Trim())
                            cmd.Parameters.AddWithValue("@p3", panel.txtApiKey.Text.Trim())
                            cmd.Parameters.AddWithValue("@p4", panel.txtApiSecret.Text.Trim())
                            cmd.Parameters.AddWithValue("@p5", panel.txtBaseUrl.Text.Trim())
                            cmd.Parameters.AddWithValue("@p6", DateTime.Now)
                            cmd.ExecuteNonQuery()
                        End Using
                    End If
                Next
            End Using
            
            lblStatus.Text = "Tum ayarlar kaydedildi!"
            lblStatus.ForeColor = Color.Green
            MessageBox.Show("Ayarlar kaydedildi!", "Basarili", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            lblStatus.Text = "Kaydetme hatasi: " & ex.Message
            lblStatus.ForeColor = Color.Red
            MessageBox.Show("Kaydetme hatasi: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    
    Private Sub btnIptal_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
    
    ' ===== STATIK METODLAR - Diger formlardan API bilgilerine erismek icin =====
    
    Public Shared Function GetApiKey(pazaryeri As String) As String
        Try
            Using con As New OleDbConnection(KeyCode.connection)
                con.Open()
                Using cmd As New OleDbCommand("SELECT sApiKey FROM tbPazaryeriAyar WHERE sPazaryeri = ? AND bAktif = TRUE", con)
                    cmd.Parameters.AddWithValue("@p", pazaryeri)
                    Dim result = cmd.ExecuteScalar()
                    If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                        Return result.ToString()
                    End If
                End Using
            End Using
        Catch
        End Try
        Return ""
    End Function
    
    Public Shared Function GetApiSecret(pazaryeri As String) As String
        Try
            Using con As New OleDbConnection(KeyCode.connection)
                con.Open()
                Using cmd As New OleDbCommand("SELECT sApiSecret FROM tbPazaryeriAyar WHERE sPazaryeri = ? AND bAktif = TRUE", con)
                    cmd.Parameters.AddWithValue("@p", pazaryeri)
                    Dim result = cmd.ExecuteScalar()
                    If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                        Return result.ToString()
                    End If
                End Using
            End Using
        Catch
        End Try
        Return ""
    End Function
    
    Public Shared Function GetSellerId(pazaryeri As String) As String
        Try
            Using con As New OleDbConnection(KeyCode.connection)
                con.Open()
                Using cmd As New OleDbCommand("SELECT sSellerId FROM tbPazaryeriAyar WHERE sPazaryeri = ? AND bAktif = TRUE", con)
                    cmd.Parameters.AddWithValue("@p", pazaryeri)
                    Dim result = cmd.ExecuteScalar()
                    If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                        Return result.ToString()
                    End If
                End Using
            End Using
        Catch
        End Try
        Return ""
    End Function
    
    Public Shared Function GetBaseUrl(pazaryeri As String) As String
        Try
            Using con As New OleDbConnection(KeyCode.connection)
                con.Open()
                Using cmd As New OleDbCommand("SELECT sBaseUrl FROM tbPazaryeriAyar WHERE sPazaryeri = ? AND bAktif = TRUE", con)
                    cmd.Parameters.AddWithValue("@p", pazaryeri)
                    Dim result = cmd.ExecuteScalar()
                    If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                        Return result.ToString()
                    End If
                End Using
            End Using
        Catch
        End Try
        Return ""
    End Function
End Class
