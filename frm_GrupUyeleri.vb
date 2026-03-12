Imports System.Data.OleDb

Public Class frm_GrupUyeleri
    
    Public nGrupID As Integer = 0
    Public sGrupAdi As String = ""
    
    Private connection As String = KeyCode.sConnection
    
    Private Sub frm_GrupUyeleri_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Grup Uyeleri - " & sGrupAdi
        PersonelListesiniYukle()
        UyeleriYukle()
    End Sub
    
    Private Sub PersonelListesiniYukle()
        Try
            ' APERSONEL tablosundan personel listesi - gercek kolon adlarini kullan
            Dim dt As DataTable = SQLCalistir("SELECT IND AS nKullaniciID, PERSONELADI AS AdSoyad, ISNULL(TELEFON1,'') AS Telefon FROM APERSONEL ORDER BY PERSONELADI")
            
            Debug.WriteLine("PersonelListesiniYukle: " & dt.Rows.Count & " kayit bulundu")
            
            If dt.Rows.Count = 0 Then
                MessageBox.Show("APERSONEL tablosunda kayit bulunamadi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            
            grd_Personeller.DataSource = dt
            
            ' Grid ayarlari
            Dim gv As DevExpress.XtraGrid.Views.Grid.GridView = CType(grd_Personeller.MainView, DevExpress.XtraGrid.Views.Grid.GridView)
            If gv IsNot Nothing Then
                gv.OptionsView.ShowGroupPanel = False
                For Each col As DevExpress.XtraGrid.Columns.GridColumn In gv.Columns
                    Select Case col.FieldName
                        Case "nKullaniciID"
                            col.Visible = False
                        Case "AdSoyad"
                            col.Caption = "Personel Adı"
                            col.Width = 200
                        Case "Telefon"
                            col.Caption = "Telefon"
                            col.Width = 120
                    End Select
                Next
            End If
        Catch ex As Exception
            MessageBox.Show("Personel listesi yuklenirken hata: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    
    Private Sub UyeleriYukle()
        Try
            ' tbWhatsappGrupUyeleri tablosunda kolon adi nUyeID
            Dim dt As DataTable = SQLCalistir("SELECT u.nUyeID, p.PERSONELADI AS AdSoyad, ISNULL(p.TELEFON1,'') AS Telefon, u.bAktif FROM tbWhatsappGrupUyeleri u INNER JOIN APERSONEL p ON u.nPersonelID = p.IND WHERE u.nGrupID = " & nGrupID & " ORDER BY p.PERSONELADI")
            grd_Uyeler.DataSource = dt
            
            ' Grid ayarlari
            Dim gv As DevExpress.XtraGrid.Views.Grid.GridView = CType(grd_Uyeler.MainView, DevExpress.XtraGrid.Views.Grid.GridView)
            If gv IsNot Nothing Then
                gv.OptionsView.ShowGroupPanel = False
                For Each col As DevExpress.XtraGrid.Columns.GridColumn In gv.Columns
                    Select Case col.FieldName
                        Case "nUyeID"
                            col.Visible = False
                        Case "AdSoyad"
                            col.Caption = "Personel Adı"
                            col.Width = 200
                        Case "Telefon"
                            col.Caption = "Telefon"
                            col.Width = 120
                        Case "bAktif"
                            col.Caption = "Aktif"
                            col.Width = 50
                            col.ColumnEdit = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
                    End Select
                Next
            End If
        Catch ex As Exception
            MessageBox.Show("Uyeler yuklenirken hata: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    
    Private Sub btn_UyeEkle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_UyeEkle.Click
        Try
            Dim gv As DevExpress.XtraGrid.Views.Grid.GridView = CType(grd_Personeller.MainView, DevExpress.XtraGrid.Views.Grid.GridView)
            If gv.FocusedRowHandle >= 0 Then
                Dim nPersonelID As Integer = Convert.ToInt32(gv.GetRowCellValue(gv.FocusedRowHandle, "nKullaniciID"))
                
                ' Daha once eklenmis mi kontrol et
                Dim dtKontrol As DataTable = SQLCalistir("SELECT COUNT(*) AS Sayi FROM tbWhatsappGrupUyeleri WHERE nGrupID = " & nGrupID & " AND nPersonelID = " & nPersonelID)
                If Convert.ToInt32(dtKontrol.Rows(0)("Sayi")) > 0 Then
                    MessageBox.Show("Bu personel zaten grupta.", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If
                
                ' dteKayitTarihi kolonu tabloda yok, sadece nGrupID, nPersonelID, bAktif
                SQLCalistir("INSERT INTO tbWhatsappGrupUyeleri (nGrupID, nPersonelID, bAktif) VALUES (" & nGrupID & ", " & nPersonelID & ", 1)")
                UyeleriYukle()
                MessageBox.Show("Uye eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Uye ekleme hatasi: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    
    Private Sub btn_UyeCikar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_UyeCikar.Click
        Try
            Dim gv As DevExpress.XtraGrid.Views.Grid.GridView = CType(grd_Uyeler.MainView, DevExpress.XtraGrid.Views.Grid.GridView)
            If gv.FocusedRowHandle >= 0 Then
                Dim nUyeID As Integer = Convert.ToInt32(gv.GetRowCellValue(gv.FocusedRowHandle, "nUyeID"))
                
                If MessageBox.Show("Bu uyeyi gruptan cikarmak istediginizden emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    SQLCalistir("DELETE FROM tbWhatsappGrupUyeleri WHERE nUyeID = " & nUyeID)
                    UyeleriYukle()
                    MessageBox.Show("Uye cikarildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Uye cikarma hatasi: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
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
            Debug.WriteLine("SQLCalistir Hata: " & ex.Message & " | SQL: " & sql)
            MessageBox.Show("Veritabani hatasi: " & ex.Message, "SQL Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function
    
    ' UI Controls
    Friend WithEvents grd_Personeller As DevExpress.XtraGrid.GridControl
    Friend WithEvents grd_Uyeler As DevExpress.XtraGrid.GridControl
    Friend WithEvents btn_UyeEkle As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_UyeCikar As DevExpress.XtraEditors.SimpleButton
    
End Class
