' ============================================================================
' GORUNUM DUZENLEME FORMU
' Dosya: frmGorunumDuzenle.vb
' Aciklama: DataGridView kolon goster/gizle, genislik ayarlama
' ============================================================================

Imports System.Windows.Forms
Imports System.Drawing

Public Class frmGorunumDuzenle
    Inherits Form
    
    Private _grid As DataGridView
    Private dgvKolonlar As DataGridView
    Private btnKaydet As Button
    Private btnIptal As Button
    Private btnTumunuGoster As Button
    Private btnTumunuGizle As Button
    
    Public Sub New(grid As DataGridView)
        _grid = grid
        InitializeComponent()
        LoadColumns()
    End Sub
    
    Private Sub InitializeComponent()
        Me.Text = "Gorunum Duzenle"
        Me.Size = New Size(500, 450)
        Me.StartPosition = FormStartPosition.CenterParent
        Me.FormBorderStyle = FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.BackColor = Color.White
        
        Dim lblInfo As New Label()
        lblInfo.Text = "Kolonlari goster/gizle ve genislik ayarla:"
        lblInfo.Location = New Point(15, 15)
        lblInfo.AutoSize = True
        Me.Controls.Add(lblInfo)
        
        ' Kolon listesi grid'i
        dgvKolonlar = New DataGridView()
        dgvKolonlar.Location = New Point(15, 40)
        dgvKolonlar.Size = New Size(455, 300)
        dgvKolonlar.AllowUserToAddRows = False
        dgvKolonlar.AllowUserToDeleteRows = False
        dgvKolonlar.RowHeadersVisible = False
        dgvKolonlar.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvKolonlar.MultiSelect = False
        dgvKolonlar.BackgroundColor = Color.White
        
        ' Checkbox kolonu
        Dim chkCol As New DataGridViewCheckBoxColumn()
        chkCol.Name = "Goster"
        chkCol.HeaderText = "Goster"
        chkCol.Width = 60
        dgvKolonlar.Columns.Add(chkCol)
        
        ' Kolon adi
        Dim txtKolonAdi As New DataGridViewTextBoxColumn()
        txtKolonAdi.Name = "KolonAdi"
        txtKolonAdi.HeaderText = "Kolon Adi"
        txtKolonAdi.Width = 200
        txtKolonAdi.ReadOnly = True
        dgvKolonlar.Columns.Add(txtKolonAdi)
        
        ' Genislik
        Dim txtGenislik As New DataGridViewTextBoxColumn()
        txtGenislik.Name = "Genislik"
        txtGenislik.HeaderText = "Genislik"
        txtGenislik.Width = 80
        dgvKolonlar.Columns.Add(txtGenislik)
        
        ' Sira
        Dim txtSira As New DataGridViewTextBoxColumn()
        txtSira.Name = "Sira"
        txtSira.HeaderText = "Sira"
        txtSira.Width = 60
        dgvKolonlar.Columns.Add(txtSira)
        
        Me.Controls.Add(dgvKolonlar)
        
        ' Butonlar
        btnTumunuGoster = New Button()
        btnTumunuGoster.Text = "Tumunu Goster"
        btnTumunuGoster.Location = New Point(15, 350)
        btnTumunuGoster.Size = New Size(110, 30)
        AddHandler btnTumunuGoster.Click, AddressOf btnTumunuGoster_Click
        Me.Controls.Add(btnTumunuGoster)
        
        btnTumunuGizle = New Button()
        btnTumunuGizle.Text = "Tumunu Gizle"
        btnTumunuGizle.Location = New Point(130, 350)
        btnTumunuGizle.Size = New Size(110, 30)
        AddHandler btnTumunuGizle.Click, AddressOf btnTumunuGizle_Click
        Me.Controls.Add(btnTumunuGizle)
        
        btnKaydet = New Button()
        btnKaydet.Text = "Uygula"
        btnKaydet.Location = New Point(290, 350)
        btnKaydet.Size = New Size(80, 30)
        btnKaydet.BackColor = Color.FromArgb(76, 175, 80)
        btnKaydet.ForeColor = Color.White
        btnKaydet.FlatStyle = FlatStyle.Flat
        AddHandler btnKaydet.Click, AddressOf btnKaydet_Click
        Me.Controls.Add(btnKaydet)
        
        btnIptal = New Button()
        btnIptal.Text = "Iptal"
        btnIptal.Location = New Point(380, 350)
        btnIptal.Size = New Size(80, 30)
        btnIptal.FlatStyle = FlatStyle.Flat
        AddHandler btnIptal.Click, Sub() Me.Close()
        Me.Controls.Add(btnIptal)
    End Sub
    
    Private Sub LoadColumns()
        dgvKolonlar.Rows.Clear()
        For Each col As DataGridViewColumn In _grid.Columns
            Dim rowIndex = dgvKolonlar.Rows.Add()
            dgvKolonlar.Rows(rowIndex).Cells("Goster").Value = col.Visible
            dgvKolonlar.Rows(rowIndex).Cells("KolonAdi").Value = col.HeaderText
            dgvKolonlar.Rows(rowIndex).Cells("Genislik").Value = col.Width
            dgvKolonlar.Rows(rowIndex).Cells("Sira").Value = col.DisplayIndex
            dgvKolonlar.Rows(rowIndex).Tag = col.Name
        Next
    End Sub
    
    Private Sub btnTumunuGoster_Click(sender As Object, e As EventArgs)
        For Each row As DataGridViewRow In dgvKolonlar.Rows
            row.Cells("Goster").Value = True
        Next
    End Sub
    
    Private Sub btnTumunuGizle_Click(sender As Object, e As EventArgs)
        For Each row As DataGridViewRow In dgvKolonlar.Rows
            row.Cells("Goster").Value = False
        Next
    End Sub
    
    Private Sub btnKaydet_Click(sender As Object, e As EventArgs)
        Try
            For Each row As DataGridViewRow In dgvKolonlar.Rows
                Dim kolonAdi As String = row.Tag.ToString()
                If _grid.Columns.Contains(kolonAdi) Then
                    Dim col = _grid.Columns(kolonAdi)
                    col.Visible = CBool(row.Cells("Goster").Value)
                    
                    Dim genislik As Integer
                    If Integer.TryParse(row.Cells("Genislik").Value.ToString(), genislik) AndAlso genislik > 0 Then
                        col.Width = genislik
                    End If
                    
                    Dim sira As Integer
                    If Integer.TryParse(row.Cells("Sira").Value.ToString(), sira) AndAlso sira >= 0 Then
                        col.DisplayIndex = Math.Min(sira, _grid.Columns.Count - 1)
                    End If
                End If
            Next
            
            MessageBox.Show("Gorunum guncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Hata: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
