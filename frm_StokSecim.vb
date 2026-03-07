' ============================================================================
' STOK SEÇİM FORMU
' ============================================================================
' AI işlemleri için stok seçim diyaloğu
' ============================================================================

Imports System.Windows.Forms
Imports System.Drawing
Imports System.Data
Imports System.Data.OleDb

Public Class frm_StokSecim
    Inherits Form
    
    ' Seçilen değerler
    Public SecilenStokID As Integer = 0
    Public SecilenUrunAdi As String = ""
    
    ' Kontroller
    Private txtArama As TextBox
    Private WithEvents btnAra As Button
    Private WithEvents dgvStoklar As DataGridView
    Private WithEvents btnSec As Button
    Private WithEvents btnIptal As Button
    Private lblSonuc As Label
    
    ' Veritabanı - Constructor'da set edilecek
    Private connection As String = ""
    
    Public Sub New()
        InitializeComponent()
        ' Connection string'i al
        connection = KeyCode.sConnection
    End Sub
    
    Private Sub frm_StokSecim_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Form yüklendiğinde stokları yükle
        LoadStoklar("")
    End Sub
    
    Private Sub InitializeComponent()
        Me.Text = "Stok Seçimi"
        Me.Size = New Size(900, 600)
        Me.StartPosition = FormStartPosition.CenterParent
        Me.FormBorderStyle = FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        
        Dim yPos As Integer = 15
        
        ' ===== ARAMA BÖLÜMÜ =====
        Dim lblArama As New Label With {
            .Text = "Ara (Kod, Ad, Barkod):",
            .Location = New Point(15, yPos + 3),
            .Size = New Size(140, 25),
            .Font = New Font("Segoe UI", 9, FontStyle.Bold)
        }
        Me.Controls.Add(lblArama)
        
        txtArama = New TextBox With {
            .Location = New Point(160, yPos),
            .Size = New Size(550, 28),
            .Font = New Font("Segoe UI", 10)
        }
        AddHandler txtArama.KeyDown, AddressOf txtArama_KeyDown
        Me.Controls.Add(txtArama)
        
        btnAra = New Button With {
            .Text = "🔍 Ara",
            .Location = New Point(720, yPos - 2),
            .Size = New Size(80, 30),
            .BackColor = Color.SteelBlue,
            .ForeColor = Color.White,
            .Font = New Font("Segoe UI", 9, FontStyle.Bold)
        }
        Me.Controls.Add(btnAra)
        yPos += 40
        
        ' ===== SONUÇ LABEL =====
        lblSonuc = New Label With {
            .Text = "",
            .Location = New Point(15, yPos),
            .Size = New Size(785, 20),
            .ForeColor = Color.DarkBlue
        }
        Me.Controls.Add(lblSonuc)
        yPos += 25
        
        ' ===== STOK LİSTESİ =====
        dgvStoklar = New DataGridView With {
            .Location = New Point(15, yPos),
            .Size = New Size(855, 400),
            .ReadOnly = True,
            .AllowUserToAddRows = False,
            .AllowUserToDeleteRows = False,
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect,
            .MultiSelect = False,
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
            .Font = New Font("Segoe UI", 9),
            .RowHeadersVisible = False,
            .BackgroundColor = Color.White
        }
        AddHandler dgvStoklar.CellDoubleClick, AddressOf dgvStoklar_CellDoubleClick
        Me.Controls.Add(dgvStoklar)
        yPos += 410
        
        ' ===== BUTONLAR =====
        btnSec = New Button With {
            .Text = "✓ Seç",
            .Location = New Point(620, yPos),
            .Size = New Size(120, 35),
            .BackColor = Color.Green,
            .ForeColor = Color.White,
            .Font = New Font("Segoe UI", 10, FontStyle.Bold),
            .DialogResult = DialogResult.OK
        }
        Me.Controls.Add(btnSec)
        
        btnIptal = New Button With {
            .Text = "✕ İptal",
            .Location = New Point(750, yPos),
            .Size = New Size(120, 35),
            .BackColor = Color.Gray,
            .ForeColor = Color.White,
            .Font = New Font("Segoe UI", 10, FontStyle.Bold),
            .DialogResult = DialogResult.Cancel
        }
        Me.Controls.Add(btnIptal)
        
        Me.AcceptButton = btnSec
        Me.CancelButton = btnIptal
    End Sub
    
    ''' <summary>
    ''' Stokları yükle
    ''' </summary>
    Private Sub LoadStoklar(aramaMetni As String)
        Try
            ' Connection kontrolü
            If String.IsNullOrEmpty(connection) Then
                lblSonuc.Text = "Veritabanı bağlantısı bulunamadı!"
                lblSonuc.ForeColor = Color.Red
                Return
            End If
            
            Using conn As New OleDbConnection(connection)
                conn.Open()
                
                Dim sql As String = "SELECT nStokID, sKodu, sAciklama, sModel, sRenk, sBeden " &
                                    "FROM tbStok WHERE 1=1 "
                
                If Not String.IsNullOrEmpty(aramaMetni) Then
                    sql &= "AND (sKodu LIKE ? OR sAciklama LIKE ? OR sModel LIKE ? " &
                           "OR nStokID IN (SELECT nStokID FROM tbStokBarkodu WHERE sBarkod LIKE ?)) "
                End If
                
                sql &= "ORDER BY sAciklama"
                
                Dim cmd As New OleDbCommand(sql, conn)
                
                If Not String.IsNullOrEmpty(aramaMetni) Then
                    Dim aramaParam As String = "%" & aramaMetni & "%"
                    cmd.Parameters.AddWithValue("?", aramaParam)
                    cmd.Parameters.AddWithValue("?", aramaParam)
                    cmd.Parameters.AddWithValue("?", aramaParam)
                    cmd.Parameters.AddWithValue("?", aramaParam)
                End If
                
                Dim adapter As New OleDbDataAdapter(cmd)
                Dim dt As New DataTable()
                adapter.Fill(dt)
                
                dgvStoklar.DataSource = dt
                
                ' Sütun başlıkları
                If dgvStoklar.Columns.Count >= 6 Then
                    dgvStoklar.Columns("nStokID").HeaderText = "ID"
                    dgvStoklar.Columns("nStokID").Width = 70
                    dgvStoklar.Columns("sKodu").HeaderText = "Stok Kodu"
                    dgvStoklar.Columns("sKodu").Width = 120
                    dgvStoklar.Columns("sAciklama").HeaderText = "Ürün Adı"
                    dgvStoklar.Columns("sAciklama").Width = 350
                    dgvStoklar.Columns("sModel").HeaderText = "Model"
                    dgvStoklar.Columns("sModel").Width = 120
                    dgvStoklar.Columns("sRenk").HeaderText = "Renk"
                    dgvStoklar.Columns("sRenk").Width = 80
                    dgvStoklar.Columns("sBeden").HeaderText = "Beden"
                    dgvStoklar.Columns("sBeden").Width = 60
                End If
                
                lblSonuc.Text = $"{dt.Rows.Count} ürün bulundu" & If(dt.Rows.Count = 500, " (max 500 gösteriliyor)", "")
            End Using
        Catch ex As Exception
            MessageBox.Show("Stok listesi yüklenirken hata: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    
    ''' <summary>
    ''' Arama butonu
    ''' </summary>
    Private Sub btnAra_Click(sender As Object, e As EventArgs) Handles btnAra.Click
        LoadStoklar(txtArama.Text.Trim())
    End Sub
    
    ''' <summary>
    ''' Enter ile arama
    ''' </summary>
    Private Sub txtArama_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            LoadStoklar(txtArama.Text.Trim())
            e.Handled = True
            e.SuppressKeyPress = True
        End If
    End Sub
    
    ''' <summary>
    ''' Seç butonuna basıldığında
    ''' </summary>
    Private Sub btnSec_Click(sender As Object, e As EventArgs) Handles btnSec.Click
        If dgvStoklar.CurrentRow IsNot Nothing Then
            SecilenStokID = Convert.ToInt32(dgvStoklar.CurrentRow.Cells("nStokID").Value)
            SecilenUrunAdi = dgvStoklar.CurrentRow.Cells("sAciklama").Value.ToString()
        Else
            MessageBox.Show("Lütfen bir ürün seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.DialogResult = DialogResult.None
        End If
    End Sub
    
    ''' <summary>
    ''' Çift tıklama ile seçim
    ''' </summary>
    Private Sub dgvStoklar_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs)
        If e.RowIndex >= 0 Then
            SecilenStokID = Convert.ToInt32(dgvStoklar.Rows(e.RowIndex).Cells("nStokID").Value)
            SecilenUrunAdi = dgvStoklar.Rows(e.RowIndex).Cells("sAciklama").Value.ToString()
            Me.DialogResult = DialogResult.OK
            Me.Close()
        End If
    End Sub
    
End Class
