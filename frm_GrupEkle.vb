Imports System.Data.OleDb

''' <summary>
''' WhatsApp Grubu Ekleme Formu
''' </summary>
Public Class frm_GrupEkle
    Private connection As String = KeyCode.sConnection
    
    Public Property IslemBasarili As Boolean = False
    
    Private Sub frm_GrupEkle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Yeni WhatsApp Grubu Ekle"
        txt_GrupAdi.Focus()
    End Sub
    
    Private Sub btn_Ekle_Click(sender As Object, e As EventArgs) Handles btn_Ekle.Click
        Try
            If String.IsNullOrWhiteSpace(txt_GrupAdi.Text) Then
                MessageBox.Show("Grup adı boş olamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txt_GrupAdi.Focus()
                Exit Sub
            End If
            
            Dim sGrupAdi As String = txt_GrupAdi.Text.Trim()
            Dim sAciklama As String = txt_Aciklama.Text.Trim()
            Dim bAktif As Boolean = chk_Aktif.Checked
            
            SQLCalistir("INSERT INTO tbWhatsappGruplari (sGrupAdi, sAciklama, bAktif, dteKayitTarihi) VALUES ('" & _
                       sGrupAdi.Replace("'", "''") & "', '" & _
                       sAciklama.Replace("'", "''") & "', " & _
                       If(bAktif, 1, 0) & ", GETDATE())")
            
            IslemBasarili = True
            MessageBox.Show("Grup başarıyla eklendi: " & sGrupAdi, "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.DialogResult = DialogResult.OK
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Grup ekleme hatası: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    
    Private Sub btn_Iptal_Click(sender As Object, e As EventArgs) Handles btn_Iptal.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
    
    Private Function SQLCalistir(ByVal sql As String) As DataTable
        Dim dt As New DataTable()
        Try
            Using con As New OleDbConnection(connection)
                Using cmd As New OleDbCommand(KeyCode.sorgu_query(sql), con)
                    Using adapter As New OleDbDataAdapter(cmd)
                        con.Open()
                        adapter.Fill(dt)
                    End Using
                End Using
            End Using
        Catch ex As Exception
            Debug.WriteLine("SQLCalistir Hata: " & ex.Message)
        End Try
        Return dt
    End Function
    
    ' UI Kontrolleri
    Friend WithEvents txt_GrupAdi As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_Aciklama As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents chk_Aktif As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents btn_Ekle As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_Iptal As DevExpress.XtraEditors.SimpleButton
    
End Class
