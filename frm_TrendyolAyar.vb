' ============================================
' TRENDYOL API AYAR FORMU
' Dosya: frm_TrendyolAyar.vb
' Tarih: 2026-01-30
' Açıklama: Trendyol API bağlantı ayarları
' ============================================

Imports System.Windows.Forms
Imports DevExpress.XtraEditors

Public Class frm_TrendyolAyar

    Public connection As String = ""
    Private _isLoading As Boolean = False

#Region "Form Events"

    Private Sub frm_TrendyolAyar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Trendyol API Ayarları"
        LoadSettings()
    End Sub

#End Region

#Region "Database Operations"

    ''' <summary>
    ''' Ayarları veritabanından yükle
    ''' </summary>
    Private Sub LoadSettings()
        _isLoading = True
        Try
            Using con As New OleDb.OleDbConnection(connection)
                con.Open()
                Using cmd As New OleDb.OleDbCommand()
                    cmd.Connection = con
                    cmd.CommandText = "SELECT TOP 1 * FROM tbTrendyolAyar WHERE bAktif = 1"
                    
                    Using reader = cmd.ExecuteReader()
                        If reader.Read() Then
                            txt_SupplierId.Text = reader("sSupplierId").ToString()
                            txt_ApiKey.Text = reader("sApiKey").ToString()
                            txt_ApiSecret.Text = reader("sApiSecret").ToString()
                            txt_BaseUrl.Text = If(IsDBNull(reader("sBaseUrl")), "https://api.trendyol.com/sapigw", reader("sBaseUrl").ToString())
                            lbl_Status.Text = "Ayarlar yüklendi"
                            lbl_Status.ForeColor = Color.Green
                        Else
                            lbl_Status.Text = "Henüz ayar kaydedilmemiş"
                            lbl_Status.ForeColor = Color.Gray
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            lbl_Status.Text = "Yükleme hatası: " & ex.Message
            lbl_Status.ForeColor = Color.Red
        Finally
            _isLoading = False
        End Try
    End Sub

    ''' <summary>
    ''' Ayarları veritabanına kaydet
    ''' </summary>
    Private Sub SaveSettings()
        If String.IsNullOrWhiteSpace(txt_SupplierId.Text) OrElse
           String.IsNullOrWhiteSpace(txt_ApiKey.Text) OrElse
           String.IsNullOrWhiteSpace(txt_ApiSecret.Text) Then
            MessageBox.Show("Lütfen tüm zorunlu alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        
        Try
            Using con As New OleDb.OleDbConnection(connection)
                con.Open()
                Using cmd As New OleDb.OleDbCommand()
                    cmd.Connection = con
                    
                    ' Önce mevcut kaydı kontrol et
                    cmd.CommandText = "SELECT COUNT(*) FROM tbTrendyolAyar"
                    Dim count = Convert.ToInt32(cmd.ExecuteScalar())
                    
                    If count > 0 Then
                        ' Güncelle
                        cmd.CommandText = "UPDATE tbTrendyolAyar SET sSupplierId=?, sApiKey=?, sApiSecret=?, sBaseUrl=?, dteGuncelleme=? WHERE bAktif=1"
                        cmd.Parameters.Clear()
                        cmd.Parameters.AddWithValue("@p1", txt_SupplierId.Text.Trim())
                        cmd.Parameters.AddWithValue("@p2", txt_ApiKey.Text.Trim())
                        cmd.Parameters.AddWithValue("@p3", txt_ApiSecret.Text.Trim())
                        cmd.Parameters.AddWithValue("@p4", txt_BaseUrl.Text.Trim())
                        cmd.Parameters.AddWithValue("@p5", DateTime.Now)
                    Else
                        ' Ekle
                        cmd.CommandText = "INSERT INTO tbTrendyolAyar (sSupplierId, sApiKey, sApiSecret, sBaseUrl, bAktif, dteOlusturma) VALUES (?, ?, ?, ?, 1, ?)"
                        cmd.Parameters.Clear()
                        cmd.Parameters.AddWithValue("@p1", txt_SupplierId.Text.Trim())
                        cmd.Parameters.AddWithValue("@p2", txt_ApiKey.Text.Trim())
                        cmd.Parameters.AddWithValue("@p3", txt_ApiSecret.Text.Trim())
                        cmd.Parameters.AddWithValue("@p4", txt_BaseUrl.Text.Trim())
                        cmd.Parameters.AddWithValue("@p5", DateTime.Now)
                    End If
                    
                    cmd.ExecuteNonQuery()
                    
                    lbl_Status.Text = "Ayarlar kaydedildi ✓"
                    lbl_Status.ForeColor = Color.Green
                    
                    MessageBox.Show("Ayarlar başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Using
            End Using
        Catch ex As Exception
            lbl_Status.Text = "Kayıt hatası!"
            lbl_Status.ForeColor = Color.Red
            MessageBox.Show("Kayıt hatası: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region

#Region "Button Events"

    ''' <summary>
    ''' Bağlantı testi
    ''' </summary>
    Private Async Sub btn_Test_Click(sender As Object, e As EventArgs) Handles btn_Test.Click
        If String.IsNullOrWhiteSpace(txt_SupplierId.Text) OrElse
           String.IsNullOrWhiteSpace(txt_ApiKey.Text) OrElse
           String.IsNullOrWhiteSpace(txt_ApiSecret.Text) Then
            MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        
        btn_Test.Enabled = False
        lbl_Status.Text = "Bağlantı test ediliyor..."
        lbl_Status.ForeColor = Color.Blue
        Me.Cursor = Cursors.WaitCursor
        
        Try
            ' API'yi yapılandır
            TrendyolAPI.Instance.Configure(
                txt_SupplierId.Text.Trim(),
                txt_ApiKey.Text.Trim(),
                txt_ApiSecret.Text.Trim(),
                txt_BaseUrl.Text.Trim()
            )
            
            ' Bağlantı testi
            Dim result = Await TrendyolAPI.Instance.TestConnectionAsync()
            
            If result.Success Then
                lbl_Status.Text = "✓ Bağlantı başarılı!"
                lbl_Status.ForeColor = Color.Green
                MessageBox.Show("Trendyol API bağlantısı başarılı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                lbl_Status.Text = "✗ Bağlantı başarısız: " & result.ErrorMessage
                lbl_Status.ForeColor = Color.Red
                MessageBox.Show("Bağlantı hatası: " & result.ErrorMessage, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            lbl_Status.Text = "✗ Hata: " & ex.Message
            lbl_Status.ForeColor = Color.Red
            MessageBox.Show("Hata: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            btn_Test.Enabled = True
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    ''' <summary>
    ''' Kaydet butonu
    ''' </summary>
    Private Sub btn_Kaydet_Click(sender As Object, e As EventArgs) Handles btn_Kaydet.Click
        SaveSettings()
    End Sub

    ''' <summary>
    ''' İptal butonu
    ''' </summary>
    Private Sub btn_Iptal_Click(sender As Object, e As EventArgs) Handles btn_Iptal.Click
        Me.Close()
    End Sub

#End Region

End Class
