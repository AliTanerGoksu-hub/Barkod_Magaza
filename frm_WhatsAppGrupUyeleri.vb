Imports System.Data.OleDb

''' <summary>
''' WhatsApp Grup Uyeleri Yonetim Formu
''' </summary>
Public Class frm_WhatsAppGrupUyeleri
    
    Private connection As String = KeyCode.sConnection
    
    Public Property GrupID As Integer
    Public Property GrupAdi As String
    
    Private Sub frm_WhatsAppGrupUyeleri_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.Text = "Grup Uyeleri - " & GrupAdi
            lbl_GrupAdi.Text = "Grup: " & GrupAdi
            
            PersonelleriYukle()
            GrupUyeleriniYukle()
        Catch ex As Exception
            MessageBox.Show("Form yukleme hatasi: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    
    Private Sub PersonelleriYukle()
        Try
            ' Grupta olmayan aktif personelleri listele
            Dim sql As String = "SELECT IND, PERSONELADI, ISNULL(TELEFON1,'') AS TELEFON1 " & _
                               "FROM APERSONEL " & _
                               "WHERE AKTIF = 1 " & _
                               "AND IND NOT IN (SELECT nPersonelID FROM tbWhatsappGrupUyeleri WHERE nGrupID = " & GrupID & " AND bAktif = 1) " & _
                               "ORDER BY PERSONELADI"
            
            Dim dt As DataTable = SQLCalistir(sql)
            grd_Personeller.DataSource = dt
        Catch ex As Exception
            Debug.WriteLine("PersonelleriYukle Hata: " & ex.Message)
        End Try
    End Sub
    
    Private Sub GrupUyeleriniYukle()
        Try
            ' Gruptaki uyeleri listele
            Dim sql As String = "SELECT u.nUyeID, u.nPersonelID, p.PERSONELADI, ISNULL(p.TELEFON1,'') AS TELEFON1 " & _
                               "FROM tbWhatsappGrupUyeleri u " & _
                               "INNER JOIN APERSONEL p ON u.nPersonelID = p.IND " & _
                               "WHERE u.nGrupID = " & GrupID & " AND u.bAktif = 1 " & _
                               "ORDER BY p.PERSONELADI"
            
            Dim dt As DataTable = SQLCalistir(sql)
            grd_GrupUyeleri.DataSource = dt
            
            lbl_UyeSayisi.Text = "Uye Sayisi: " & dt.Rows.Count
        Catch ex As Exception
            Debug.WriteLine("GrupUyeleriniYukle Hata: " & ex.Message)
        End Try
    End Sub
    
    Private Sub btn_Ekle_Click(sender As Object, e As EventArgs) Handles btn_Ekle.Click
        Try
            Dim view As DevExpress.XtraGrid.Views.Grid.GridView = CType(grd_Personeller.MainView, DevExpress.XtraGrid.Views.Grid.GridView)
            If view.FocusedRowHandle >= 0 Then
                Dim nPersonelID As Integer = Convert.ToInt32(view.GetFocusedRowCellValue("IND"))
                
                ' Gruba ekle
                SQLCalistirNonQuery("INSERT INTO tbWhatsappGrupUyeleri (nGrupID, nPersonelID, bAktif) VALUES (" & GrupID & ", " & nPersonelID & ", 1)")
                
                ' Listeleri yenile
                PersonelleriYukle()
                GrupUyeleriniYukle()
            Else
                MessageBox.Show("Lutfen eklenecek bir personel secin.", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show("Uye ekleme hatasi: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    
    Private Sub btn_Cikar_Click(sender As Object, e As EventArgs) Handles btn_Cikar.Click
        Try
            Dim view As DevExpress.XtraGrid.Views.Grid.GridView = CType(grd_GrupUyeleri.MainView, DevExpress.XtraGrid.Views.Grid.GridView)
            If view.FocusedRowHandle >= 0 Then
                Dim nUyeID As Integer = Convert.ToInt32(view.GetFocusedRowCellValue("nUyeID"))
                
                If MessageBox.Show("Secili uyeyi gruptan cikarmak istediginizden emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    ' Gruptan cikar (soft delete)
                    SQLCalistirNonQuery("UPDATE tbWhatsappGrupUyeleri SET bAktif = 0 WHERE nUyeID = " & nUyeID)
                    
                    ' Listeleri yenile
                    PersonelleriYukle()
                    GrupUyeleriniYukle()
                End If
            Else
                MessageBox.Show("Lutfen cikarilacak bir uye secin.", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show("Uye cikarma hatasi: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    
    Private Sub btn_TumunuEkle_Click(sender As Object, e As EventArgs) Handles btn_TumunuEkle.Click
        Try
            If MessageBox.Show("Tum personelleri gruba eklemek istediginizden emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                ' Grupta olmayan tum personelleri ekle
                SQLCalistirNonQuery("INSERT INTO tbWhatsappGrupUyeleri (nGrupID, nPersonelID, bAktif) " & _
                                   "SELECT " & GrupID & ", IND, 1 FROM APERSONEL " & _
                                   "WHERE AKTIF = 1 AND IND NOT IN (SELECT nPersonelID FROM tbWhatsappGrupUyeleri WHERE nGrupID = " & GrupID & " AND bAktif = 1)")
                
                ' Listeleri yenile
                PersonelleriYukle()
                GrupUyeleriniYukle()
            End If
        Catch ex As Exception
            MessageBox.Show("Toplu ekleme hatasi: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    
    Private Sub btn_TumunuCikar_Click(sender As Object, e As EventArgs) Handles btn_TumunuCikar.Click
        Try
            If MessageBox.Show("Tum uyeleri gruptan cikarmak istediginizden emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                ' Tum uyeleri cikar (soft delete)
                SQLCalistirNonQuery("UPDATE tbWhatsappGrupUyeleri SET bAktif = 0 WHERE nGrupID = " & GrupID)
                
                ' Listeleri yenile
                PersonelleriYukle()
                GrupUyeleriniYukle()
            End If
        Catch ex As Exception
            MessageBox.Show("Toplu cikarma hatasi: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    
    Private Sub btn_Kapat_Click(sender As Object, e As EventArgs) Handles btn_Kapat.Click
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
        End Try
    End Sub
    
    ' UI Kontrolleri
    Friend WithEvents grd_Personeller As DevExpress.XtraGrid.GridControl
    Friend WithEvents grd_GrupUyeleri As DevExpress.XtraGrid.GridControl
    Friend WithEvents btn_Ekle As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_Cikar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_TumunuEkle As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_TumunuCikar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_Kapat As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lbl_GrupAdi As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_UyeSayisi As DevExpress.XtraEditors.LabelControl
    
End Class
