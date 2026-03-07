Imports System.Data.OleDb

''' <summary>
''' Genel Kayit Secme/Ekleme Formu
''' Liste secimi veya yeni kayit ekleme
''' </summary>
Public Class frm_GenelSecim
    Private connection As String = KeyCode.sConnection
    
    ' Form ayarlari
    Public Property FormBaslik As String = "Kayıt Seç/Ekle"
    Public Property TabloAdi As String = ""
    Public Property IDKolonu As String = "IND"
    Public Property KodKolonu As String = "KOD"
    Public Property AdKolonu As String = "AD"
    Public Property EkKolonlar As String = "" ' Ornek: "ACIKLAMA, DEPONO"
    Public Property SiralamaKolonu As String = "KOD"
    Public Property FiltreSorgu As String = "" ' Ornek: "WHERE AKTIF = 1"
    
    ' Ekleme icin gerekli bilgiler
    Public Property InsertSQL As String = "" ' Ozel INSERT sorgusu (bos ise varsayilan kullanilir)
    Public Property KodZorunlu As Boolean = True
    Public Property AdZorunlu As Boolean = True
    
    ' Donus degerleri
    Public Property SecilenID As Integer = 0
    Public Property SecilenKod As String = ""
    Public Property SecilenAd As String = ""
    Public Property IslemBasarili As Boolean = False
    Public Property YeniKayitEklendi As Boolean = False
    
    Private Sub frm_GenelSecim_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = FormBaslik
        lbl_Baslik.Text = FormBaslik
        KayitlariYukle()
    End Sub
    
    ''' <summary>
    ''' Kayitlari yukler
    ''' </summary>
    Private Sub KayitlariYukle()
        Try
            Dim kolonlar As String = IDKolonu & ", " & KodKolonu & ", " & AdKolonu
            If Not String.IsNullOrEmpty(EkKolonlar) Then
                kolonlar &= ", " & EkKolonlar
            End If
            
            Dim sql As String = "SELECT " & kolonlar & " FROM " & TabloAdi
            If Not String.IsNullOrEmpty(FiltreSorgu) Then
                sql &= " " & FiltreSorgu
            End If
            sql &= " ORDER BY " & SiralamaKolonu
            
            Debug.WriteLine("frm_GenelSecim SQL: " & sql)
            
            Dim dt As DataTable = SQLCalistir(sql)
            
            If dt Is Nothing OrElse dt.Rows.Count = 0 Then
                Debug.WriteLine("frm_GenelSecim: Kayit bulunamadi veya tablo bos")
            End If
            
            grd_Kayitlar.DataSource = dt
            
            ' Kolon ayarlari
            Dim gv As DevExpress.XtraGrid.Views.Grid.GridView = CType(grd_Kayitlar.MainView, DevExpress.XtraGrid.Views.Grid.GridView)
            If gv IsNot Nothing Then
                gv.OptionsView.ShowGroupPanel = False
                gv.OptionsSelection.EnableAppearanceFocusedCell = False
                gv.BestFitColumns()
                
                ' ID kolonunu gizle
                For Each col As DevExpress.XtraGrid.Columns.GridColumn In gv.Columns
                    If col.FieldName = IDKolonu Then
                        col.Visible = False
                    ElseIf col.FieldName = KodKolonu Then
                        col.Caption = "Kod"
                    ElseIf col.FieldName = AdKolonu Then
                        col.Caption = "Ad/Açıklama"
                    End If
                Next
            End If
            
            lbl_KayitSayisi.Text = "Toplam: " & dt.Rows.Count & " kayıt"
        Catch ex As Exception
            MessageBox.Show("Kayitlar yuklenirken hata: " & ex.Message & vbCrLf & vbCrLf & "SQL: SELECT " & IDKolonu & ", " & KodKolonu & ", " & AdKolonu & " FROM " & TabloAdi, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    
    ''' <summary>
    ''' Arama
    ''' </summary>
    Private Sub txt_Ara_TextChanged(sender As Object, e As EventArgs) Handles txt_Ara.TextChanged
        Try
            Dim aramaMetni As String = txt_Ara.Text.Trim().ToLower()
            Dim gv As DevExpress.XtraGrid.Views.Grid.GridView = CType(grd_Kayitlar.MainView, DevExpress.XtraGrid.Views.Grid.GridView)
            
            If String.IsNullOrEmpty(aramaMetni) Then
                gv.ActiveFilterString = ""
            Else
                gv.ActiveFilterString = "[" & KodKolonu & "] LIKE '%" & aramaMetni & "%' OR [" & AdKolonu & "] LIKE '%" & aramaMetni & "%'"
            End If
        Catch ex As Exception
            Debug.WriteLine("Arama hatasi: " & ex.Message)
        End Try
    End Sub
    
    ''' <summary>
    ''' Sec butonuna tiklandiginda
    ''' </summary>
    Private Sub btn_Sec_Click(sender As Object, e As EventArgs) Handles btn_Sec.Click
        Try
            Dim gv As DevExpress.XtraGrid.Views.Grid.GridView = CType(grd_Kayitlar.MainView, DevExpress.XtraGrid.Views.Grid.GridView)
            If gv.FocusedRowHandle < 0 Then
                MessageBox.Show("Lütfen bir kayıt seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            
            SecilenID = Convert.ToInt32(gv.GetRowCellValue(gv.FocusedRowHandle, IDKolonu))
            SecilenKod = If(gv.GetRowCellValue(gv.FocusedRowHandle, KodKolonu) IsNot Nothing, gv.GetRowCellValue(gv.FocusedRowHandle, KodKolonu).ToString(), "")
            SecilenAd = If(gv.GetRowCellValue(gv.FocusedRowHandle, AdKolonu) IsNot Nothing, gv.GetRowCellValue(gv.FocusedRowHandle, AdKolonu).ToString(), "")
            
            IslemBasarili = True
            Me.DialogResult = DialogResult.OK
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Seçim hatası: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    
    ''' <summary>
    ''' Grid'e cift tiklandiginda
    ''' </summary>
    Private Sub grd_Kayitlar_DoubleClick(sender As Object, e As EventArgs) Handles grd_Kayitlar.DoubleClick
        btn_Sec_Click(sender, e)
    End Sub
    
    ''' <summary>
    ''' Yeni kayit ekle
    ''' </summary>
    Private Sub btn_YeniEkle_Click(sender As Object, e As EventArgs) Handles btn_YeniEkle.Click
        Try
            ' Yeni kayit panelini goster
            grp_YeniKayit.Visible = True
            txt_YeniKod.Text = ""
            txt_YeniAd.Text = ""
            txt_YeniKod.Focus()
        Catch ex As Exception
            MessageBox.Show("Hata: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    
    ''' <summary>
    ''' Yeni kaydi kaydet
    ''' </summary>
    Private Sub btn_Kaydet_Click(sender As Object, e As EventArgs) Handles btn_Kaydet.Click
        Try
            ' Validasyon
            If KodZorunlu AndAlso String.IsNullOrWhiteSpace(txt_YeniKod.Text) Then
                MessageBox.Show("Kod alanı boş olamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txt_YeniKod.Focus()
                Exit Sub
            End If
            
            If AdZorunlu AndAlso String.IsNullOrWhiteSpace(txt_YeniAd.Text) Then
                MessageBox.Show("Ad alanı boş olamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txt_YeniAd.Focus()
                Exit Sub
            End If
            
            Dim sKod As String = txt_YeniKod.Text.Trim().Replace("'", "''")
            Dim sAd As String = txt_YeniAd.Text.Trim().Replace("'", "''")
            
            ' INSERT sorgusu
            Dim sql As String
            If Not String.IsNullOrEmpty(InsertSQL) Then
                ' Ozel INSERT sorgusu kullan
                sql = InsertSQL.Replace("{KOD}", sKod).Replace("{AD}", sAd)
            Else
                ' Varsayilan INSERT
                sql = "INSERT INTO " & TabloAdi & " (" & KodKolonu & ", " & AdKolonu & ") VALUES ('" & sKod & "', '" & sAd & "')"
            End If
            
            SQLCalistir(sql)
            
            YeniKayitEklendi = True
            grp_YeniKayit.Visible = False
            KayitlariYukle()
            
            MessageBox.Show("Yeni kayıt eklendi: " & sKod & " - " & sAd, "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Kayıt ekleme hatası: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    
    ''' <summary>
    ''' Yeni kayit iptal
    ''' </summary>
    Private Sub btn_KayitIptal_Click(sender As Object, e As EventArgs) Handles btn_KayitIptal.Click
        grp_YeniKayit.Visible = False
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
    Friend WithEvents grd_Kayitlar As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txt_Ara As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btn_Sec As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_YeniEkle As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_Iptal As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lbl_Baslik As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_KayitSayisi As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grp_YeniKayit As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txt_YeniKod As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_YeniAd As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btn_Kaydet As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_KayitIptal As DevExpress.XtraEditors.SimpleButton
    
End Class
