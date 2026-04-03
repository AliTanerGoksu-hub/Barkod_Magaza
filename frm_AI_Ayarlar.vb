Imports System.Windows.Forms
Imports System.Drawing

Public Class frm_AI_Ayarlar
    Inherits Form

    Private dgv As DataGridView
    Private btnKaydet As Button
    Private btnKapat As Button
    Private lblBaslik As Label

    Public sConnection As String = ""
    Private kullanici As String = ""

    Public Sub New(ByVal connectionString As String, ByVal kullaniciAdi As String)
        sConnection = connectionString
        kullanici = kullaniciAdi
        InitForm()
    End Sub

    Private Sub InitForm()
        Me.Text = "AI Modul Ayarlari"
        Me.Size = New Size(650, 500)
        Me.StartPosition = FormStartPosition.CenterParent
        Me.FormBorderStyle = FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False

        lblBaslik = New Label()
        lblBaslik.Text = "AI ve Parametrik Ayarlar"
        lblBaslik.Font = New Font("Segoe UI", 14, FontStyle.Bold)
        lblBaslik.ForeColor = Color.FromArgb(44, 62, 80)
        lblBaslik.Location = New Point(20, 15)
        lblBaslik.AutoSize = True
        Me.Controls.Add(lblBaslik)

        Dim lblAciklama As New Label()
        lblAciklama.Text = "Ayar degerini 1 yaparak aktif, 0 yaparak pasif edebilirsiniz."
        lblAciklama.Font = New Font("Segoe UI", 9)
        lblAciklama.ForeColor = Color.Gray
        lblAciklama.Location = New Point(20, 45)
        lblAciklama.AutoSize = True
        Me.Controls.Add(lblAciklama)

        dgv = New DataGridView()
        dgv.Location = New Point(20, 75)
        dgv.Size = New Size(600, 330)
        dgv.AllowUserToAddRows = False
        dgv.AllowUserToDeleteRows = False
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgv.BackgroundColor = Color.White
        dgv.GridColor = Color.FromArgb(220, 220, 220)
        dgv.DefaultCellStyle.Font = New Font("Segoe UI", 9)
        dgv.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 73, 94)
        dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        dgv.EnableHeadersVisualStyles = False
        dgv.RowHeadersVisible = False

        Dim colKod As New DataGridViewTextBoxColumn()
        colKod.Name = "sAyarKodu"
        colKod.HeaderText = "Ayar Kodu"
        colKod.ReadOnly = True
        colKod.FillWeight = 40

        Dim colDeger As New DataGridViewTextBoxColumn()
        colDeger.Name = "sAyarDeger"
        colDeger.HeaderText = "Deger"
        colDeger.FillWeight = 15

        Dim colAciklama As New DataGridViewTextBoxColumn()
        colAciklama.Name = "sAciklama"
        colAciklama.HeaderText = "Aciklama"
        colAciklama.ReadOnly = True
        colAciklama.FillWeight = 45

        dgv.Columns.Add(colKod)
        dgv.Columns.Add(colDeger)
        dgv.Columns.Add(colAciklama)
        Me.Controls.Add(dgv)

        btnKaydet = New Button()
        btnKaydet.Text = "Kaydet"
        btnKaydet.Location = New Point(430, 420)
        btnKaydet.Size = New Size(90, 32)
        btnKaydet.BackColor = Color.FromArgb(39, 174, 96)
        btnKaydet.ForeColor = Color.White
        btnKaydet.FlatStyle = FlatStyle.Flat
        btnKaydet.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        AddHandler btnKaydet.Click, AddressOf btnKaydet_Click
        Me.Controls.Add(btnKaydet)

        btnKapat = New Button()
        btnKapat.Text = "Kapat"
        btnKapat.Location = New Point(530, 420)
        btnKapat.Size = New Size(90, 32)
        btnKapat.BackColor = Color.FromArgb(149, 165, 166)
        btnKapat.ForeColor = Color.White
        btnKapat.FlatStyle = FlatStyle.Flat
        btnKapat.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        AddHandler btnKapat.Click, Sub(s, ev) Me.Close()
        Me.Controls.Add(btnKapat)
    End Sub

    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)
        AyarlariYukle()
    End Sub

    Private Sub AyarlariYukle()
        dgv.Rows.Clear()

        Dim ayarlar As New Dictionary(Of String, String) From {
            {"AI_MODUL_AKTIF", "AI modulu acik/kapali (0=kapali, 1=acik)"},
            {"AI_API_URL", "AI API adresi (ornek: https://api.openai.com/v1/chat/completions)"},
            {"AI_API_KEY", "AI API anahtari"},
            {"RISK_SKORU_AKTIF", "Risk skoru hesaplama (0=kapali, 1=acik)"},
            {"PERAKENDE_RISK_AKTIF", "Perakende musterilerde risk takibi (0=kapali, 1=acik)"},
            {"VALOR_TARIHI_ZORUNLU", "Faturada valor tarihi zorunlu (0=kapali, 1=acik)"},
            {"KREDI_LIMIT_UYARI", "Firma kartinda kredi limit uyarisi (0=kapali, 1=acik)"},
            {"SIPARIS_LIMIT_KONTROL", "Sipariste kredi limit kontrolu (0=kapali, 1=acik)"},
            {"TAHSILAT_AI_AKTIF", "AI tahsilat plani (0=kapali, 1=acik)"},
            {"SATIS_ONERI_AKTIF", "AI satis onerisi (0=kapali, 1=acik)"},
            {"YONETICI_OZET_AKTIF", "AI yonetici gun sonu ozeti (0=kapali, 1=acik)"},
            {"ICERIK_YARDIMCI_AKTIF", "AI icerik yardimcisi (0=kapali, 1=acik)"}
        }

        Try
            Dim conn As New OleDb.OleDbConnection(sConnection)
            conn.Open()
            For Each kvp In ayarlar
                Dim cmd As New OleDb.OleDbCommand("SELECT ISNULL(sAyarDeger,'') FROM tbSistemAyar WHERE sAyarKodu='" & kvp.Key & "'", conn)
                Dim deger As String = ""
                Try : deger = cmd.ExecuteScalar().ToString() : Catch : End Try
                dgv.Rows.Add(kvp.Key, deger, kvp.Value)
            Next
            conn.Close()
        Catch ex As Exception
            ' Tablo yoksa bos goster
            For Each kvp In ayarlar
                dgv.Rows.Add(kvp.Key, "0", kvp.Value)
            Next
        End Try
    End Sub

    Private Sub btnKaydet_Click(sender As Object, e As EventArgs)
        Try
            Dim conn As New OleDb.OleDbConnection(sConnection)
            conn.Open()

            For Each row As DataGridViewRow In dgv.Rows
                Dim kod As String = row.Cells("sAyarKodu").Value.ToString()
                Dim deger As String = row.Cells("sAyarDeger").Value.ToString()

                Dim cmd As New OleDb.OleDbCommand
                cmd.Connection = conn
                cmd.CommandText = "IF EXISTS (SELECT 1 FROM tbSistemAyar WHERE sAyarKodu='" & kod & "') " & _
                    "UPDATE tbSistemAyar SET sAyarDeger='" & deger & "' WHERE sAyarKodu='" & kod & "' " & _
                    "ELSE INSERT INTO tbSistemAyar (sAyarKodu, sAyarDeger) VALUES ('" & kod & "', '" & deger & "')"
                cmd.ExecuteNonQuery()
            Next

            conn.Close()
            MessageBox.Show("Ayarlar kaydedildi.", "Basarili", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Hata: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
