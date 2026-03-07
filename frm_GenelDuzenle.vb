Imports System.Data.OleDb

''' <summary>
''' Genel Duzenleme Formu - Kod ve Ad duzenleme
''' </summary>
Public Class frm_GenelDuzenle
    Private connection As String = KeyCode.sConnection
    
    ' Form ayarlari
    Public Property FormBaslik As String = "Düzenle"
    Public Property KodBaslik As String = "Kod:"
    Public Property AdBaslik As String = "Ad:"
    Public Property MevcutKod As String = ""
    Public Property MevcutAd As String = ""
    Public Property KodZorunlu As Boolean = True
    Public Property AdZorunlu As Boolean = True
    Public Property KodReadOnly As Boolean = False
    
    ' Donus degerleri
    Public Property YeniKod As String = ""
    Public Property YeniAd As String = ""
    Public Property IslemBasarili As Boolean = False
    
    Private Sub frm_GenelDuzenle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = FormBaslik
        lbl_Kod.Text = KodBaslik
        lbl_Ad.Text = AdBaslik
        txt_Kod.Text = MevcutKod
        txt_Ad.Text = MevcutAd
        txt_Kod.Properties.ReadOnly = KodReadOnly
        
        If KodReadOnly Then
            txt_Ad.Focus()
        Else
            txt_Kod.Focus()
        End If
    End Sub
    
    Private Sub btn_Kaydet_Click(sender As Object, e As EventArgs) Handles btn_Kaydet.Click
        Try
            If KodZorunlu AndAlso String.IsNullOrWhiteSpace(txt_Kod.Text) Then
                MessageBox.Show(KodBaslik.Replace(":", "") & " boş olamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txt_Kod.Focus()
                Exit Sub
            End If
            
            If AdZorunlu AndAlso String.IsNullOrWhiteSpace(txt_Ad.Text) Then
                MessageBox.Show(AdBaslik.Replace(":", "") & " boş olamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txt_Ad.Focus()
                Exit Sub
            End If
            
            YeniKod = txt_Kod.Text.Trim()
            YeniAd = txt_Ad.Text.Trim()
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
    Friend WithEvents txt_Kod As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_Ad As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btn_Kaydet As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_Iptal As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lbl_Kod As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_Ad As DevExpress.XtraEditors.LabelControl
    
End Class
