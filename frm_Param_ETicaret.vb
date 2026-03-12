Imports System.Data.OleDb
Imports DevExpress.XtraEditors

Public Class frm_Param_ETicaret
    Public connection As String
    Public firmano As String
    Public donemno As String
    Public kullanici As String
    
    Private Sub frm_Param_ETicaret_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' Designer kontrolleri manuel başlat
            If GridControl1 Is Nothing Then
                InitializeComponent()
            End If
            LoadData()
        Catch ex As Exception
            XtraMessageBox.Show("Form Load hatasi: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    
    Private Sub LoadData()
        Try
            ' Güvenlik kontrolleri
            If String.IsNullOrEmpty(connection) Then
                XtraMessageBox.Show("Connection string tanimli degil!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            
            If GridControl1 Is Nothing Then
                XtraMessageBox.Show("GridControl1 tanimli degil!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            
            Using conn As New OleDbConnection(connection)
                conn.Open()
                Dim sql As String = "SELECT * FROM tbParamETicaret WHERE bAktif = 1 ORDER BY sPazarYeri"
                Dim adapter As New OleDbDataAdapter(sql, conn)
                Dim dt As New DataTable()
                adapter.Fill(dt)
                
                GridControl1.DataSource = dt
                If GridView1 IsNot Nothing Then
                    GridView1.BestFitColumns()
                End If
            End Using
        Catch ex As Exception
            XtraMessageBox.Show("Veri yukleme hatasi: " + ex.Message + vbCrLf + "Stack Trace: " + ex.StackTrace, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    
    Private Sub btnKaydet_Click(sender As Object, e As EventArgs) Handles btnKaydet.Click
        Try
            ' DevExpress GridView'deki değişiklikleri commit et
            GridView1.CloseEditor()
            GridView1.UpdateCurrentRow()
            
            Using conn As New OleDbConnection(connection)
                conn.Open()
                Dim dt As DataTable = CType(GridControl1.DataSource, DataTable)
                
                ' TÜM satırları kaydet - TÜM alanları güncelle
                Dim updatedCount As Integer = 0
                For Each row As DataRow In dt.Rows
                    Dim sql As String = "UPDATE tbParamETicaret SET " &
                        "sPazarYeri = ?, " &
                        "sKodu = ?, " &
                        "sSiparisNoOnek = ?, " &
                        "nKomisyonTipi = ?, " &
                        "nKomisyonOrani = ?, " &
                        "lKomisyonSabitTutar = ?, " &
                        "lKargoSabitBedel = ?, " &
                        "nIadeOperasyonOrani = ?, " &
                        "nPaketlemeOrani = ?, " &
                        "nOdemeIslemUcretiOrani = ?, " &
                        "lOdemeIslemSabitUcret = ?, " &
                        "lDigerMasraf1 = ?, " &
                        "sDigerMasraf1Aciklama = ?, " &
                        "lDigerMasraf2 = ?, " &
                        "sDigerMasraf2Aciklama = ?, " &
                        "bAktif = ?, " &
                        "sSonKullaniciAdi = ?, " &
                        "dteSonGuncelleme = ? " &
                        "WHERE nParamID = ?"
                    
                    Using cmd As New OleDbCommand(sql, conn)
                        cmd.Parameters.AddWithValue("?", If(IsDBNull(row("sPazarYeri")), "", row("sPazarYeri")))
                        cmd.Parameters.AddWithValue("?", If(IsDBNull(row("sKodu")), DBNull.Value, row("sKodu")))
                        cmd.Parameters.AddWithValue("?", If(IsDBNull(row("sSiparisNoOnek")), DBNull.Value, row("sSiparisNoOnek")))
                        cmd.Parameters.AddWithValue("?", If(IsDBNull(row("nKomisyonTipi")), 0, row("nKomisyonTipi")))
                        cmd.Parameters.AddWithValue("?", If(IsDBNull(row("nKomisyonOrani")), 0D, row("nKomisyonOrani")))
                        cmd.Parameters.AddWithValue("?", If(IsDBNull(row("lKomisyonSabitTutar")), 0D, row("lKomisyonSabitTutar")))
                        cmd.Parameters.AddWithValue("?", If(IsDBNull(row("lKargoSabitBedel")), 0D, row("lKargoSabitBedel")))
                        cmd.Parameters.AddWithValue("?", If(IsDBNull(row("nIadeOperasyonOrani")), 0D, row("nIadeOperasyonOrani")))
                        cmd.Parameters.AddWithValue("?", If(IsDBNull(row("nPaketlemeOrani")), 0D, row("nPaketlemeOrani")))
                        cmd.Parameters.AddWithValue("?", If(IsDBNull(row("nOdemeIslemUcretiOrani")), 0D, row("nOdemeIslemUcretiOrani")))
                        cmd.Parameters.AddWithValue("?", If(IsDBNull(row("lOdemeIslemSabitUcret")), 0D, row("lOdemeIslemSabitUcret")))
                        cmd.Parameters.AddWithValue("?", If(IsDBNull(row("lDigerMasraf1")), 0D, row("lDigerMasraf1")))
                        cmd.Parameters.AddWithValue("?", If(IsDBNull(row("sDigerMasraf1Aciklama")), DBNull.Value, row("sDigerMasraf1Aciklama")))
                        cmd.Parameters.AddWithValue("?", If(IsDBNull(row("lDigerMasraf2")), 0D, row("lDigerMasraf2")))
                        cmd.Parameters.AddWithValue("?", If(IsDBNull(row("sDigerMasraf2Aciklama")), DBNull.Value, row("sDigerMasraf2Aciklama")))
                        cmd.Parameters.AddWithValue("?", If(IsDBNull(row("bAktif")), False, row("bAktif")))
                        cmd.Parameters.AddWithValue("?", kullanici) ' Son güncelleyen kullanıcı
                        cmd.Parameters.AddWithValue("?", DateTime.Now) ' Son güncelleme tarihi
                        cmd.Parameters.AddWithValue("?", row("nParamID"))
                        cmd.ExecuteNonQuery()
                        updatedCount += 1
                    End Using
                Next
                
                XtraMessageBox.Show($"Parametreler başarıyla kaydedildi! ({updatedCount} kayıt)", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadData()
            End Using
        Catch ex As Exception
            XtraMessageBox.Show("Kaydetme hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    
    Private Sub btnYenile_Click(sender As Object, e As EventArgs) Handles btnYenile.Click
        LoadData()
    End Sub
    
    Private Sub btnKapat_Click(sender As Object, e As EventArgs) Handles btnKapat.Click
        Me.Close()
    End Sub
End Class
