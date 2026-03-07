' ============================================
' URUN TIPI KATEGORI SECIM FORMU
' Dosya: frm_UrunTipiKategoriSec.vb
' Tarih: 2025-12
' Aciklama: Eslesme bulunamayan urun tipleri icin
'           kullanicidan kategori secimi alir
'           frm_stok_kart.vb yapisi ornek alinmistir
' ============================================

Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows.Forms
Imports System.Data
Imports System.Data.OleDb
Imports System.Drawing

''' <summary>
''' Urun tipi icin kategori secim sonucu
''' </summary>
Public Class UrunTipiKategoriSonuc
    Public Property Basarili As Boolean = False
    Public Property Atla As Boolean = False
    Public Property sSinifKodu3 As String = ""  ' Marka
    Public Property sSinifKodu4 As String = ""  ' Ana Kategori
    Public Property sSinifKodu5 As String = ""  ' Cinsiyet/Alt Kat 1
    Public Property sSinifKodu6 As String = ""  ' Alt Kategori 2
    Public Property sSinifKodu7 As String = ""  ' Alt Kategori 3
    Public Property sSinifKodu8 As String = ""  ' Alt Kategori 4
    
    ' Aciklama degerleri (gosterim icin)
    Public Property Sinif3Aciklama As String = ""
    Public Property Sinif4Aciklama As String = ""
    Public Property Sinif5Aciklama As String = ""
    Public Property Sinif6Aciklama As String = ""
    Public Property Sinif7Aciklama As String = ""
    Public Property Sinif8Aciklama As String = ""
End Class

Public Class frm_UrunTipiKategoriSec
    Inherits Form
    
    ' Dis erisim icin
    Public connection As String = ""
    Public UrunTipi As String = ""
    Public UrunSayisi As Integer = 0
    Public OrnekUrunler As List(Of String)
    Public OrnekModeller As List(Of String)  ' YENİ: Model kodları
    Public Sonuc As New UrunTipiKategoriSonuc()
    
    ' Form kontrolleri
    Private WithEvents lbl_Baslik As Label
    Private WithEvents lbl_UrunTipi As Label
    Private WithEvents lbl_OrnekUrunler As Label
    Private WithEvents txt_OrnekUrunler As TextBox
    
    Private WithEvents grp_Siniflar As GroupBox
    Private WithEvents lbl_Sinif3 As Label
    Private WithEvents cmb_Sinif3 As ComboBox
    Private WithEvents lbl_Sinif4 As Label
    Private WithEvents cmb_Sinif4 As ComboBox
    Private WithEvents lbl_Sinif5 As Label
    Private WithEvents cmb_Sinif5 As ComboBox
    Private WithEvents lbl_Sinif6 As Label
    Private WithEvents cmb_Sinif6 As ComboBox
    Private WithEvents lbl_Sinif7 As Label
    Private WithEvents cmb_Sinif7 As ComboBox
    Private WithEvents lbl_Sinif8 As Label
    Private WithEvents cmb_Sinif8 As ComboBox
    
    Private WithEvents btn_Kaydet As Button
    Private WithEvents btn_Atla As Button
    Private WithEvents btn_TumunuAtla As Button
    Private WithEvents lbl_Status As Label
    
    ' Sinif tablolari
    Private dt_Sinif3 As DataTable
    Private dt_Sinif4 As DataTable
    Private dt_Sinif5 As DataTable
    Private dt_Sinif6 As DataTable
    Private dt_Sinif7 As DataTable
    Private dt_Sinif8 As DataTable
    
    ' Sinif basliklari (tbParamStok'tan)
    Private sSinifTipi03 As String = "Marka"
    Private sSinifTipi04 As String = "Ana Kategori"
    Private sSinifTipi05 As String = "Cinsiyet"
    Private sSinifTipi06 As String = "Alt Kategori 1"
    Private sSinifTipi07 As String = "Alt Kategori 2"
    Private sSinifTipi08 As String = "Alt Kategori 3"
    
    Public TumunuAtla As Boolean = False
    
    Public Sub New()
        InitializeComponent()
    End Sub
    
    Private Sub InitializeComponent()
        Me.lbl_Baslik = New Label()
        Me.lbl_UrunTipi = New Label()
        Me.lbl_OrnekUrunler = New Label()
        Me.txt_OrnekUrunler = New TextBox()
        Me.grp_Siniflar = New GroupBox()
        Me.lbl_Sinif3 = New Label()
        Me.cmb_Sinif3 = New ComboBox()
        Me.lbl_Sinif4 = New Label()
        Me.cmb_Sinif4 = New ComboBox()
        Me.lbl_Sinif5 = New Label()
        Me.cmb_Sinif5 = New ComboBox()
        Me.lbl_Sinif6 = New Label()
        Me.cmb_Sinif6 = New ComboBox()
        Me.lbl_Sinif7 = New Label()
        Me.cmb_Sinif7 = New ComboBox()
        Me.lbl_Sinif8 = New Label()
        Me.cmb_Sinif8 = New ComboBox()
        Me.btn_Kaydet = New Button()
        Me.btn_Atla = New Button()
        Me.btn_TumunuAtla = New Button()
        Me.lbl_Status = New Label()
        Me.SuspendLayout()
        
        ' lbl_Baslik
        Me.lbl_Baslik.Location = New Point(12, 12)
        Me.lbl_Baslik.Size = New Size(560, 20)
        Me.lbl_Baslik.Text = "ESLESME BULUNAMADI - Lutfen bu urun tipi icin kategori secin:"
        Me.lbl_Baslik.Font = New Font("Tahoma", 10.0!, FontStyle.Bold)
        Me.lbl_Baslik.ForeColor = Color.FromArgb(200, 80, 0)
        
        ' lbl_UrunTipi
        Me.lbl_UrunTipi.Location = New Point(12, 40)
        Me.lbl_UrunTipi.Size = New Size(560, 30)
        Me.lbl_UrunTipi.Font = New Font("Tahoma", 14.0!, FontStyle.Bold)
        Me.lbl_UrunTipi.ForeColor = Color.FromArgb(0, 100, 180)
        
        ' lbl_OrnekUrunler
        Me.lbl_OrnekUrunler.Location = New Point(12, 75)
        Me.lbl_OrnekUrunler.Size = New Size(100, 15)
        Me.lbl_OrnekUrunler.Text = "Ornek urunler:"
        Me.lbl_OrnekUrunler.Font = New Font("Tahoma", 8.25!, FontStyle.Regular)
        
        ' txt_OrnekUrunler
        Me.txt_OrnekUrunler.Location = New Point(12, 92)
        Me.txt_OrnekUrunler.Size = New Size(560, 60)
        Me.txt_OrnekUrunler.Multiline = True
        Me.txt_OrnekUrunler.ReadOnly = True
        Me.txt_OrnekUrunler.ScrollBars = ScrollBars.Vertical
        Me.txt_OrnekUrunler.Font = New Font("Tahoma", 8.25!, FontStyle.Regular)
        Me.txt_OrnekUrunler.BackColor = Color.FromArgb(245, 245, 245)
        
        ' grp_Siniflar
        Me.grp_Siniflar.Location = New Point(12, 160)
        Me.grp_Siniflar.Size = New Size(560, 220)
        Me.grp_Siniflar.Text = "Sinif Secimi (Kategori Hiyerarsisi)"
        Me.grp_Siniflar.Font = New Font("Tahoma", 9.0!, FontStyle.Bold)
        
        Dim yPos As Integer = 25
        Dim yStep As Integer = 32
        
        ' Sinif 3 - Marka
        Me.lbl_Sinif3.Location = New Point(10, yPos)
        Me.lbl_Sinif3.Size = New Size(130, 20)
        Me.lbl_Sinif3.Text = "Sinif 3 (Marka):"
        Me.lbl_Sinif3.Font = New Font("Tahoma", 8.25!, FontStyle.Regular)
        Me.grp_Siniflar.Controls.Add(Me.lbl_Sinif3)
        
        Me.cmb_Sinif3.Location = New Point(145, yPos - 3)
        Me.cmb_Sinif3.Size = New Size(400, 21)
        Me.cmb_Sinif3.DropDownStyle = ComboBoxStyle.DropDownList
        Me.cmb_Sinif3.Font = New Font("Tahoma", 8.25!, FontStyle.Regular)
        Me.grp_Siniflar.Controls.Add(Me.cmb_Sinif3)
        yPos += yStep
        
        ' Sinif 4 - Ana Kategori
        Me.lbl_Sinif4.Location = New Point(10, yPos)
        Me.lbl_Sinif4.Size = New Size(130, 20)
        Me.lbl_Sinif4.Text = "Sinif 4 (Ana Kat):"
        Me.lbl_Sinif4.Font = New Font("Tahoma", 8.25!, FontStyle.Regular)
        Me.grp_Siniflar.Controls.Add(Me.lbl_Sinif4)
        
        Me.cmb_Sinif4.Location = New Point(145, yPos - 3)
        Me.cmb_Sinif4.Size = New Size(400, 21)
        Me.cmb_Sinif4.DropDownStyle = ComboBoxStyle.DropDownList
        Me.cmb_Sinif4.Font = New Font("Tahoma", 8.25!, FontStyle.Regular)
        Me.grp_Siniflar.Controls.Add(Me.cmb_Sinif4)
        yPos += yStep
        
        ' Sinif 5 - Cinsiyet
        Me.lbl_Sinif5.Location = New Point(10, yPos)
        Me.lbl_Sinif5.Size = New Size(130, 20)
        Me.lbl_Sinif5.Text = "Sinif 5 (Cinsiyet):"
        Me.lbl_Sinif5.Font = New Font("Tahoma", 8.25!, FontStyle.Regular)
        Me.grp_Siniflar.Controls.Add(Me.lbl_Sinif5)
        
        Me.cmb_Sinif5.Location = New Point(145, yPos - 3)
        Me.cmb_Sinif5.Size = New Size(400, 21)
        Me.cmb_Sinif5.DropDownStyle = ComboBoxStyle.DropDownList
        Me.cmb_Sinif5.Font = New Font("Tahoma", 8.25!, FontStyle.Regular)
        Me.grp_Siniflar.Controls.Add(Me.cmb_Sinif5)
        yPos += yStep
        
        ' Sinif 6 - Alt Kategori 1
        Me.lbl_Sinif6.Location = New Point(10, yPos)
        Me.lbl_Sinif6.Size = New Size(130, 20)
        Me.lbl_Sinif6.Text = "Sinif 6 (Alt Kat 1):"
        Me.lbl_Sinif6.Font = New Font("Tahoma", 8.25!, FontStyle.Regular)
        Me.grp_Siniflar.Controls.Add(Me.lbl_Sinif6)
        
        Me.cmb_Sinif6.Location = New Point(145, yPos - 3)
        Me.cmb_Sinif6.Size = New Size(400, 21)
        Me.cmb_Sinif6.DropDownStyle = ComboBoxStyle.DropDownList
        Me.cmb_Sinif6.Font = New Font("Tahoma", 8.25!, FontStyle.Regular)
        Me.grp_Siniflar.Controls.Add(Me.cmb_Sinif6)
        yPos += yStep
        
        ' Sinif 7 - Alt Kategori 2
        Me.lbl_Sinif7.Location = New Point(10, yPos)
        Me.lbl_Sinif7.Size = New Size(130, 20)
        Me.lbl_Sinif7.Text = "Sinif 7 (Alt Kat 2):"
        Me.lbl_Sinif7.Font = New Font("Tahoma", 8.25!, FontStyle.Regular)
        Me.grp_Siniflar.Controls.Add(Me.lbl_Sinif7)
        
        Me.cmb_Sinif7.Location = New Point(145, yPos - 3)
        Me.cmb_Sinif7.Size = New Size(400, 21)
        Me.cmb_Sinif7.DropDownStyle = ComboBoxStyle.DropDownList
        Me.cmb_Sinif7.Font = New Font("Tahoma", 8.25!, FontStyle.Regular)
        Me.grp_Siniflar.Controls.Add(Me.cmb_Sinif7)
        yPos += yStep
        
        ' Sinif 8 - Alt Kategori 3
        Me.lbl_Sinif8.Location = New Point(10, yPos)
        Me.lbl_Sinif8.Size = New Size(130, 20)
        Me.lbl_Sinif8.Text = "Sinif 8 (Alt Kat 3):"
        Me.lbl_Sinif8.Font = New Font("Tahoma", 8.25!, FontStyle.Regular)
        Me.grp_Siniflar.Controls.Add(Me.lbl_Sinif8)
        
        Me.cmb_Sinif8.Location = New Point(145, yPos - 3)
        Me.cmb_Sinif8.Size = New Size(400, 21)
        Me.cmb_Sinif8.DropDownStyle = ComboBoxStyle.DropDownList
        Me.cmb_Sinif8.Font = New Font("Tahoma", 8.25!, FontStyle.Regular)
        Me.grp_Siniflar.Controls.Add(Me.cmb_Sinif8)
        
        ' btn_Kaydet
        Me.btn_Kaydet.Location = New Point(300, 390)
        Me.btn_Kaydet.Size = New Size(130, 35)
        Me.btn_Kaydet.Text = "Kaydet ve Uygula"
        Me.btn_Kaydet.BackColor = Color.FromArgb(0, 150, 50)
        Me.btn_Kaydet.ForeColor = Color.White
        Me.btn_Kaydet.FlatStyle = FlatStyle.Flat
        Me.btn_Kaydet.Font = New Font("Tahoma", 9.0!, FontStyle.Bold)
        
        ' btn_Atla
        Me.btn_Atla.Location = New Point(440, 390)
        Me.btn_Atla.Size = New Size(60, 35)
        Me.btn_Atla.Text = "Atla"
        Me.btn_Atla.BackColor = Color.FromArgb(200, 200, 200)
        Me.btn_Atla.FlatStyle = FlatStyle.Flat
        Me.btn_Atla.Font = New Font("Tahoma", 8.25!, FontStyle.Regular)
        
        ' btn_TumunuAtla
        Me.btn_TumunuAtla.Location = New Point(510, 390)
        Me.btn_TumunuAtla.Size = New Size(65, 35)
        Me.btn_TumunuAtla.Text = "Tum Atla"
        Me.btn_TumunuAtla.BackColor = Color.FromArgb(180, 50, 50)
        Me.btn_TumunuAtla.ForeColor = Color.White
        Me.btn_TumunuAtla.FlatStyle = FlatStyle.Flat
        Me.btn_TumunuAtla.Font = New Font("Tahoma", 8.0!, FontStyle.Regular)
        
        ' lbl_Status
        Me.lbl_Status.Location = New Point(12, 400)
        Me.lbl_Status.Size = New Size(280, 20)
        Me.lbl_Status.Text = ""
        Me.lbl_Status.Font = New Font("Tahoma", 8.25!, FontStyle.Regular)
        
        ' Form
        Me.ClientSize = New Size(585, 435)
        Me.Controls.Add(Me.lbl_Baslik)
        Me.Controls.Add(Me.lbl_UrunTipi)
        Me.Controls.Add(Me.lbl_OrnekUrunler)
        Me.Controls.Add(Me.txt_OrnekUrunler)
        Me.Controls.Add(Me.grp_Siniflar)
        Me.Controls.Add(Me.btn_Kaydet)
        Me.Controls.Add(Me.btn_Atla)
        Me.Controls.Add(Me.btn_TumunuAtla)
        Me.Controls.Add(Me.lbl_Status)
        Me.FormBorderStyle = FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.StartPosition = FormStartPosition.CenterParent
        Me.Text = "Urun Tipi Icin Kategori Sec"
        
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub
    
    Private Sub frm_UrunTipiKategoriSec_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Baslik guncelle
        Me.lbl_UrunTipi.Text = UrunTipi & " (" & UrunSayisi & " urun)"
        Me.Text = "Kategori Sec: " & UrunTipi
        
        ' Ornek urunleri VE MODEL KODLARINI goster
        If OrnekUrunler IsNot Nothing AndAlso OrnekUrunler.Count > 0 Then
            Dim gosterilecekler As New List(Of String)
            For i As Integer = 0 To Math.Min(4, OrnekUrunler.Count - 1)
                Dim urunAdi As String = OrnekUrunler(i)
                Dim modelKodu As String = ""
                
                ' Model kodu varsa ekle
                If OrnekModeller IsNot Nothing AndAlso i < OrnekModeller.Count Then
                    modelKodu = OrnekModeller(i)
                End If
                
                ' Model kodu + Ürün adı formatında göster
                If Not String.IsNullOrEmpty(modelKodu) Then
                    ' -S kontrolü için vurgula
                    If modelKodu.EndsWith("-S") Then
                        gosterilecekler.Add($"[{modelKodu}] (YETİŞKİN) {urunAdi}")
                    Else
                        gosterilecekler.Add($"[{modelKodu}] {urunAdi}")
                    End If
                Else
                    gosterilecekler.Add(urunAdi)
                End If
            Next
            Me.txt_OrnekUrunler.Text = String.Join(vbCrLf, gosterilecekler)
        End If
        
        ' Sinif basliklarini yukle
        LoadSinifBasliklari()
        
        ' Siniflari yukle
        LoadAllSiniflar()
    End Sub
    
    ''' <summary>
    ''' tbParamStok'tan sinif basliklarini yukler
    ''' </summary>
    Private Sub LoadSinifBasliklari()
        Try
            Using conn As New OleDbConnection(connection)
                conn.Open()
                Dim cmd As New OleDbCommand( _
                    "SELECT sSinifTipi03, sSinifTipi04, sSinifTipi05, sSinifTipi06, sSinifTipi07, sSinifTipi08 FROM tbParamStok", conn)
                Using reader As OleDbDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        sSinifTipi03 = If(reader("sSinifTipi03") IsNot DBNull.Value, reader("sSinifTipi03").ToString(), "Marka")
                        sSinifTipi04 = If(reader("sSinifTipi04") IsNot DBNull.Value, reader("sSinifTipi04").ToString(), "Ana Kategori")
                        sSinifTipi05 = If(reader("sSinifTipi05") IsNot DBNull.Value, reader("sSinifTipi05").ToString(), "Cinsiyet")
                        sSinifTipi06 = If(reader("sSinifTipi06") IsNot DBNull.Value, reader("sSinifTipi06").ToString(), "Alt Kategori 1")
                        sSinifTipi07 = If(reader("sSinifTipi07") IsNot DBNull.Value, reader("sSinifTipi07").ToString(), "Alt Kategori 2")
                        sSinifTipi08 = If(reader("sSinifTipi08") IsNot DBNull.Value, reader("sSinifTipi08").ToString(), "Alt Kategori 3")
                    End If
                End Using
            End Using
            
            ' Label'lari guncelle
            lbl_Sinif3.Text = "Sinif 3 (" & sSinifTipi03 & "):"
            lbl_Sinif4.Text = "Sinif 4 (" & sSinifTipi04 & "):"
            lbl_Sinif5.Text = "Sinif 5 (" & sSinifTipi05 & "):"
            lbl_Sinif6.Text = "Sinif 6 (" & sSinifTipi06 & "):"
            lbl_Sinif7.Text = "Sinif 7 (" & sSinifTipi07 & "):"
            lbl_Sinif8.Text = "Sinif 8 (" & sSinifTipi08 & "):"
            
        Catch ex As Exception
            ' Varsayilan basliklar kullanilacak
        End Try
    End Sub
    
    ''' <summary>
    ''' Tum sinif tablolarini yukler - frm_stok_kart.vb dataload_tbSSinif ornegi
    ''' </summary>
    Private Sub LoadAllSiniflar()
        Try
            lbl_Status.Text = "Siniflar yukleniyor..."
            lbl_Status.ForeColor = Color.Blue
            Application.DoEvents()
            
            Using conn As New OleDbConnection(connection)
                conn.Open()
                
                ' Sinif 3 (Marka)
                dt_Sinif3 = LoadSinifTablosu(conn, 3)
                FillComboBox(cmb_Sinif3, dt_Sinif3)
                
                ' Sinif 4 (Ana Kategori)
                dt_Sinif4 = LoadSinifTablosu(conn, 4)
                FillComboBox(cmb_Sinif4, dt_Sinif4)
                
                ' Sinif 5 (Cinsiyet)
                dt_Sinif5 = LoadSinifTablosu(conn, 5)
                FillComboBox(cmb_Sinif5, dt_Sinif5)
                
                ' Sinif 6 (Alt Kategori 1)
                dt_Sinif6 = LoadSinifTablosu(conn, 6)
                FillComboBox(cmb_Sinif6, dt_Sinif6)
                
                ' Sinif 7 (Alt Kategori 2)
                dt_Sinif7 = LoadSinifTablosu(conn, 7)
                FillComboBox(cmb_Sinif7, dt_Sinif7)
                
                ' Sinif 8 (Alt Kategori 3)
                dt_Sinif8 = LoadSinifTablosu(conn, 8)
                FillComboBox(cmb_Sinif8, dt_Sinif8)
                
            End Using
            
            lbl_Status.Text = "Siniflar yuklendi. Secim yapin."
            lbl_Status.ForeColor = Color.Green
            
        Catch ex As Exception
            lbl_Status.Text = "Hata: " & ex.Message
            lbl_Status.ForeColor = Color.Red
        End Try
    End Sub
    
    ''' <summary>
    ''' Tek bir sinif tablosunu yukler
    ''' </summary>
    Private Function LoadSinifTablosu(conn As OleDbConnection, sinifNo As Integer) As DataTable
        Dim dt As New DataTable()
        Dim sql As String = "SELECT sSinifKodu, sAciklama FROM tbSSinif" & sinifNo.ToString() & " ORDER BY sAciklama"
        
        Using adapter As New OleDbDataAdapter(sql, conn)
            adapter.Fill(dt)
        End Using
        
        ' Bos satir ekle (secim yapilmamis durumu icin)
        Dim emptyRow As DataRow = dt.NewRow()
        emptyRow("sSinifKodu") = ""
        emptyRow("sAciklama") = "(Bos)"
        dt.Rows.InsertAt(emptyRow, 0)
        
        Return dt
    End Function
    
    ''' <summary>
    ''' ComboBox'i doldurur
    ''' </summary>
    Private Sub FillComboBox(cmb As ComboBox, dt As DataTable)
        cmb.DataSource = dt
        cmb.DisplayMember = "sAciklama"
        cmb.ValueMember = "sSinifKodu"
        cmb.SelectedIndex = 0
    End Sub
    
    ''' <summary>
    ''' Kaydet butonu - secilen siniflari sonuca yaz
    ''' </summary>
    Private Sub btn_Kaydet_Click(sender As Object, e As EventArgs) Handles btn_Kaydet.Click
        ' En az Sinif 4 ve Sinif 5 secilmeli
        Dim sinif4Kodu As String = If(cmb_Sinif4.SelectedValue IsNot Nothing, cmb_Sinif4.SelectedValue.ToString(), "")
        Dim sinif5Kodu As String = If(cmb_Sinif5.SelectedValue IsNot Nothing, cmb_Sinif5.SelectedValue.ToString(), "")
        
        If String.IsNullOrEmpty(sinif4Kodu) OrElse String.IsNullOrEmpty(sinif5Kodu) Then
            MessageBox.Show( _
                "En az Sinif 4 (" & sSinifTipi04 & ") ve Sinif 5 (" & sSinifTipi05 & ") secilmelidir!", _
                "Eksik Secim", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        
        ' Sonucu doldur
        Sonuc.Basarili = True
        Sonuc.Atla = False
        
        Sonuc.sSinifKodu3 = If(cmb_Sinif3.SelectedValue IsNot Nothing, cmb_Sinif3.SelectedValue.ToString(), "")
        Sonuc.sSinifKodu4 = sinif4Kodu
        Sonuc.sSinifKodu5 = sinif5Kodu
        Sonuc.sSinifKodu6 = If(cmb_Sinif6.SelectedValue IsNot Nothing, cmb_Sinif6.SelectedValue.ToString(), "")
        Sonuc.sSinifKodu7 = If(cmb_Sinif7.SelectedValue IsNot Nothing, cmb_Sinif7.SelectedValue.ToString(), "")
        Sonuc.sSinifKodu8 = If(cmb_Sinif8.SelectedValue IsNot Nothing, cmb_Sinif8.SelectedValue.ToString(), "")
        
        ' Aciklamalari da al (log icin)
        Sonuc.Sinif3Aciklama = If(cmb_Sinif3.Text <> "(Bos)", cmb_Sinif3.Text, "")
        Sonuc.Sinif4Aciklama = cmb_Sinif4.Text
        Sonuc.Sinif5Aciklama = cmb_Sinif5.Text
        Sonuc.Sinif6Aciklama = If(cmb_Sinif6.Text <> "(Bos)", cmb_Sinif6.Text, "")
        Sonuc.Sinif7Aciklama = If(cmb_Sinif7.Text <> "(Bos)", cmb_Sinif7.Text, "")
        Sonuc.Sinif8Aciklama = If(cmb_Sinif8.Text <> "(Bos)", cmb_Sinif8.Text, "")
        
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub
    
    ''' <summary>
    ''' Bu tipi atla
    ''' </summary>
    Private Sub btn_Atla_Click(sender As Object, e As EventArgs) Handles btn_Atla.Click
        Sonuc.Basarili = False
        Sonuc.Atla = True
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
    
    ''' <summary>
    ''' Tum kalan tipleri atla
    ''' </summary>
    Private Sub btn_TumunuAtla_Click(sender As Object, e As EventArgs) Handles btn_TumunuAtla.Click
        Dim sonuc As DialogResult = MessageBox.Show( _
            "Kalan tum urun tiplerini atlamak istediginize emin misiniz?" & vbCrLf & _
            "Bu urunler icin kategori atanmayacak.", _
            "Tumunu Atla", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        
        If sonuc = DialogResult.Yes Then
            TumunuAtla = True
            Me.Sonuc.Basarili = False
            Me.Sonuc.Atla = True
            Me.DialogResult = DialogResult.Abort
            Me.Close()
        End If
    End Sub
    
End Class
