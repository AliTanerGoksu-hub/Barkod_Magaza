Imports System.Data.OleDb

''' <summary>
''' Personel Bildirim Tercihleri Formu
''' APERSONEL tablosundaki bildirim alanlarini duzenler
''' </summary>
Public Class frm_PersonelBildirimTercihleri
    
    Private connection As String = KeyCode.sConnection
    
    Public Property PersonelID As Integer
    Public Property PersonelAdi As String
    
    Private Sub frm_PersonelBildirimTercihleri_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.Text = "Bildirim Tercihleri - " & PersonelAdi
            lbl_PersonelAdi.Text = "Personel: " & PersonelAdi
            
            BildirimTercihleriniYukle()
        Catch ex As Exception
            MessageBox.Show("Form yukleme hatasi: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    
    Private Sub BildirimTercihleriniYukle()
        Try
            Dim sql As String = "SELECT ISNULL(bEmailBildirimAl, 0) AS bEmailBildirimAl, " & _
                               "ISNULL(bSMSBildirimAl, 0) AS bSMSBildirimAl, " & _
                               "ISNULL(bWhatsAppBildirimAl, 0) AS bWhatsAppBildirimAl, " & _
                               "ISNULL(bUygulamaBildirimAl, 1) AS bUygulamaBildirimAl, " & _
                               "ISNULL(sWhatsApp, '') AS sWhatsApp, " & _
                               "ISNULL(TELEFON1, '') AS TELEFON1 " & _
                               "FROM APERSONEL WHERE IND = " & PersonelID
            
            Dim dt As DataTable = SQLCalistir(sql)
            
            If dt.Rows.Count > 0 Then
                Dim dr As DataRow = dt.Rows(0)
                
                chk_EmailBildirim.Checked = Convert.ToBoolean(dr("bEmailBildirimAl"))
                chk_SMSBildirim.Checked = Convert.ToBoolean(dr("bSMSBildirimAl"))
                chk_WhatsAppBildirim.Checked = Convert.ToBoolean(dr("bWhatsAppBildirimAl"))
                chk_UygulamaBildirim.Checked = Convert.ToBoolean(dr("bUygulamaBildirimAl"))
                txt_WhatsAppNo.Text = dr("sWhatsApp").ToString()
                lbl_Telefon.Text = "Telefon: " & dr("TELEFON1").ToString()
            End If
        Catch ex As Exception
            Debug.WriteLine("BildirimTercihleriniYukle Hata: " & ex.Message)
            MessageBox.Show("Bildirim tercihleri yuklenemedi: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    
    Private Sub btn_Kaydet_Click(sender As Object, e As EventArgs) Handles btn_Kaydet.Click
        Try
            Dim bEmailBildirimAl As Integer = If(chk_EmailBildirim.Checked, 1, 0)
            Dim bSMSBildirimAl As Integer = If(chk_SMSBildirim.Checked, 1, 0)
            Dim bWhatsAppBildirimAl As Integer = If(chk_WhatsAppBildirim.Checked, 1, 0)
            Dim bUygulamaBildirimAl As Integer = If(chk_UygulamaBildirim.Checked, 1, 0)
            Dim sWhatsApp As String = txt_WhatsAppNo.Text.Trim().Replace("'", "''")
            
            Dim sql As String = "UPDATE APERSONEL SET " & _
                               "bEmailBildirimAl = " & bEmailBildirimAl & ", " & _
                               "bSMSBildirimAl = " & bSMSBildirimAl & ", " & _
                               "bWhatsAppBildirimAl = " & bWhatsAppBildirimAl & ", " & _
                               "bUygulamaBildirimAl = " & bUygulamaBildirimAl & ", " & _
                               "sWhatsApp = '" & sWhatsApp & "' " & _
                               "WHERE IND = " & PersonelID
            
            SQLCalistirNonQuery(sql)
            
            MessageBox.Show("Bildirim tercihleri kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.DialogResult = DialogResult.OK
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Kaydetme hatasi: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
                    Using da As New OleDbDataAdapter(cmd)
                        con.Open()
                        da.Fill(dt)
                    End Using
                End Using
            End Using
        Catch ex As Exception
            Debug.WriteLine("SQLCalistir Hata: " & ex.Message)
        End Try
        Return dt
    End Function
    
    Private Sub SQLCalistirNonQuery(ByVal sql As String)
        Try
            Using con As New OleDbConnection(connection)
                Using cmd As New OleDbCommand(KeyCode.sorgu_query(sql), con)
                    con.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            Debug.WriteLine("SQLCalistirNonQuery Hata: " & ex.Message)
            Throw
        End Try
    End Sub
    
    ' UI Kontrolleri
    Friend WithEvents lbl_PersonelAdi As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_Telefon As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chk_EmailBildirim As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chk_SMSBildirim As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chk_WhatsAppBildirim As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chk_UygulamaBildirim As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txt_WhatsAppNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btn_Kaydet As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_Iptal As DevExpress.XtraEditors.SimpleButton
    
End Class
