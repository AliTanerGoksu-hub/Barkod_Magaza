Imports System.Data.OleDb

''' <summary>
''' Tek Alanli Giris Formu - InputBox yerine kullanilacak
''' </summary>
Public Class frm_TekAlanGiris
    
    ' Form ayarlari
    Public Property FormBaslik As String = "Değer Girin"
    Public Property AlanBaslik As String = "Değer:"
    Public Property Aciklama As String = ""
    Public Property MevcutDeger As String = ""
    Public Property Zorunlu As Boolean = True
    Public Property CokSatirli As Boolean = False
    
    ' Donus degeri
    Public Property GirilenDeger As String = ""
    Public Property IslemBasarili As Boolean = False
    
    Private Sub frm_TekAlanGiris_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = FormBaslik
        lbl_Alan.Text = AlanBaslik
        lbl_Aciklama.Text = Aciklama
        lbl_Aciklama.Visible = Not String.IsNullOrEmpty(Aciklama)
        
        If CokSatirli Then
            txt_Deger.Visible = False
            txt_CokSatir.Visible = True
            txt_CokSatir.Text = MevcutDeger
            txt_CokSatir.Focus()
        Else
            txt_Deger.Visible = True
            txt_CokSatir.Visible = False
            txt_Deger.Text = MevcutDeger
            txt_Deger.Focus()
        End If
    End Sub
    
    Private Sub btn_Tamam_Click(sender As Object, e As EventArgs) Handles btn_Tamam.Click
        Try
            Dim deger As String
            If CokSatirli Then
                deger = txt_CokSatir.Text.Trim()
            Else
                deger = txt_Deger.Text.Trim()
            End If
            
            If Zorunlu AndAlso String.IsNullOrWhiteSpace(deger) Then
                MessageBox.Show(AlanBaslik.Replace(":", "") & " boş olamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If CokSatirli Then txt_CokSatir.Focus() Else txt_Deger.Focus()
                Exit Sub
            End If
            
            GirilenDeger = deger
            IslemBasarili = True
            Me.DialogResult = DialogResult.OK
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Hata: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    
    Private Sub btn_Iptal_Click(sender As Object, e As EventArgs) Handles btn_Iptal.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
    
    ' UI Kontrolleri
    Friend WithEvents txt_Deger As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_CokSatir As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents btn_Tamam As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_Iptal As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lbl_Alan As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_Aciklama As DevExpress.XtraEditors.LabelControl
    
End Class
