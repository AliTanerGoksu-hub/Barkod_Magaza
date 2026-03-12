Imports System.Data.OleDb
Imports System.Collections.Generic

''' <summary>
''' Yetkili Ekleme Formu
''' Personel, Onay Turu ve Asamalari listeler ile gosterir
''' Kullanici kolayca secim yapabilir
''' </summary>
Public Class frm_YetkiliEkle
    Private connection As String = KeyCode.sConnection
    
    ' Secilen degerler
    Public Property SecilenPersonelID As Integer = 0
    Public Property SecilenPersonelAdi As String = ""
    Public Property SecilenOnayTurID As Integer = 0
    Public Property SecilenOnayTurAdi As String = ""
    Public Property SecilenAsamaID As Integer? = Nothing
    Public Property SecilenAsamaAdi As String = ""
    Public Property IslemBasarili As Boolean = False
    
    ' Coklu secim icin listeler
    Public Property SecilenAsamalar As New List(Of Integer)
    
    Private Sub frm_YetkiliEkle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Yetkili Ekle"
        PersonelListesiniYukle()
        OnayTurleriYukle()
        AsamalariYukle()
    End Sub
    
    ''' <summary>
    ''' Personel listesini yukler
    ''' </summary>
    Private Sub PersonelListesiniYukle()
        Try
            Dim dt As DataTable = SQLCalistir("SELECT IND, PERSONELKODU, PERSONELADI FROM APERSONEL WHERE AKTIF = 1 ORDER BY PERSONELADI")
            grd_Personel.DataSource = dt
            
            ' Kolon ayarlari
            Dim gv As DevExpress.XtraGrid.Views.Grid.GridView = CType(grd_Personel.MainView, DevExpress.XtraGrid.Views.Grid.GridView)
            If gv IsNot Nothing Then
                gv.OptionsView.ShowGroupPanel = False
                gv.OptionsSelection.EnableAppearanceFocusedCell = False
                gv.OptionsSelection.MultiSelect = False
                
                For Each col As DevExpress.XtraGrid.Columns.GridColumn In gv.Columns
                    Select Case col.FieldName
                        Case "IND"
                            col.Caption = "ID"
                            col.Width = 50
                            col.Visible = False
                        Case "PERSONELKODU"
                            col.Caption = "Personel Kodu"
                            col.Width = 100
                        Case "PERSONELADI"
                            col.Caption = "Personel Adi"
                            col.Width = 200
                    End Select
                Next
            End If
        Catch ex As Exception
            MessageBox.Show("Personel listesi yuklenirken hata: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    
    ''' <summary>
    ''' Onay turlerini yukler
    ''' </summary>
    Private Sub OnayTurleriYukle()
        Try
            Dim dt As DataTable = SQLCalistir("SELECT nOnayTurID, sOnayTurKodu, sOnayTurAdi FROM tbOnayTurleri WHERE bAktif = 1 ORDER BY nOncelik")
            grd_OnayTurleri.DataSource = dt
            
            ' Kolon ayarlari
            Dim gv As DevExpress.XtraGrid.Views.Grid.GridView = CType(grd_OnayTurleri.MainView, DevExpress.XtraGrid.Views.Grid.GridView)
            If gv IsNot Nothing Then
                gv.OptionsView.ShowGroupPanel = False
                gv.OptionsSelection.EnableAppearanceFocusedCell = False
                gv.OptionsSelection.MultiSelect = False
                
                For Each col As DevExpress.XtraGrid.Columns.GridColumn In gv.Columns
                    Select Case col.FieldName
                        Case "nOnayTurID"
                            col.Caption = "ID"
                            col.Width = 50
                            col.Visible = False
                        Case "sOnayTurKodu"
                            col.Caption = "Onay Tur Kodu"
                            col.Width = 120
                        Case "sOnayTurAdi"
                            col.Caption = "Onay Tur Adi"
                            col.Width = 200
                    End Select
                Next
            End If
        Catch ex As Exception
            MessageBox.Show("Onay turleri yuklenirken hata: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    
    ''' <summary>
    ''' Asamalari yukler (CheckedListBox ile coklu secim)
    ''' </summary>
    Private Sub AsamalariYukle()
        Try
            Dim dt As DataTable = SQLCalistir("SELECT nAsamaID, sAsamaKodu, sAsamaAdi FROM tbUretimAsamaTanim WHERE bAktif = 1 ORDER BY nSiraNo")
            
            ' CheckedListBox'a ekle
            chk_Asamalar.Items.Clear()
            chk_Asamalar.Items.Add(New AsamaItem(0, "TUM ASAMALAR", ""))
            
            For Each dr As DataRow In dt.Rows
                Dim item As New AsamaItem(
                    Convert.ToInt32(dr("nAsamaID")),
                    dr("sAsamaAdi").ToString(),
                    If(dr("sAsamaKodu") IsNot DBNull.Value, dr("sAsamaKodu").ToString(), "")
                )
                chk_Asamalar.Items.Add(item)
            Next
            
            ' Ilk itemi (Tum Asamalar) sec
            If chk_Asamalar.Items.Count > 0 Then
                chk_Asamalar.SetItemChecked(0, True)
            End If
        Catch ex As Exception
            MessageBox.Show("Asamalar yuklenirken hata: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    
    ''' <summary>
    ''' Ekle butonuna tiklandiginda
    ''' </summary>
    Private Sub btn_Ekle_Click(sender As Object, e As EventArgs) Handles btn_Ekle.Click
        Try
            ' Personel secimi kontrolu
            Dim gvPersonel As DevExpress.XtraGrid.Views.Grid.GridView = CType(grd_Personel.MainView, DevExpress.XtraGrid.Views.Grid.GridView)
            If gvPersonel.FocusedRowHandle < 0 Then
                MessageBox.Show("Lutfen bir personel secin.", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            SecilenPersonelID = Convert.ToInt32(gvPersonel.GetRowCellValue(gvPersonel.FocusedRowHandle, "IND"))
            SecilenPersonelAdi = gvPersonel.GetRowCellValue(gvPersonel.FocusedRowHandle, "PERSONELADI").ToString()
            
            ' Onay turu secimi kontrolu
            Dim gvOnayTur As DevExpress.XtraGrid.Views.Grid.GridView = CType(grd_OnayTurleri.MainView, DevExpress.XtraGrid.Views.Grid.GridView)
            If gvOnayTur.FocusedRowHandle < 0 Then
                MessageBox.Show("Lutfen bir onay turu secin.", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            SecilenOnayTurID = Convert.ToInt32(gvOnayTur.GetRowCellValue(gvOnayTur.FocusedRowHandle, "nOnayTurID"))
            SecilenOnayTurAdi = gvOnayTur.GetRowCellValue(gvOnayTur.FocusedRowHandle, "sOnayTurAdi").ToString()
            
            ' Asama secimleri
            SecilenAsamalar.Clear()
            Dim tumAsamalarSecili As Boolean = False
            
            For i As Integer = 0 To chk_Asamalar.Items.Count - 1
                If chk_Asamalar.GetItemChecked(i) Then
                    Dim item As AsamaItem = CType(chk_Asamalar.Items(i), AsamaItem)
                    If item.ID = 0 Then
                        tumAsamalarSecili = True
                    Else
                        SecilenAsamalar.Add(item.ID)
                    End If
                End If
            Next
            
            ' Veritabanina ekle
            Dim eklenenSayisi As Integer = 0
            
            If tumAsamalarSecili Then
                ' Tum asamalar icin tek kayit (nAsamaID = NULL)
                SQLCalistir("INSERT INTO tbOnayYetkilisi (nOnayTurID, nPersonelID, bAktif) VALUES (" & SecilenOnayTurID & ", " & SecilenPersonelID & ", 1)")
                eklenenSayisi = 1
            Else
                ' Secilen her asama icin ayri kayit
                For Each asamaID As Integer In SecilenAsamalar
                    SQLCalistir("INSERT INTO tbOnayYetkilisi (nOnayTurID, nPersonelID, nAsamaID, bAktif) VALUES (" & SecilenOnayTurID & ", " & SecilenPersonelID & ", " & asamaID & ", 1)")
                    eklenenSayisi += 1
                Next
            End If
            
            If eklenenSayisi > 0 Then
                IslemBasarili = True
                MessageBox.Show(eklenenSayisi & " adet yetkili kaydı eklendi." & vbCrLf & vbCrLf &
                               "Personel: " & SecilenPersonelAdi & vbCrLf &
                               "Onay Türü: " & SecilenOnayTurAdi, "Basarili", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.DialogResult = DialogResult.OK
                Me.Close()
            Else
                MessageBox.Show("Lutfen en az bir asama secin.", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
            
        Catch ex As Exception
            MessageBox.Show("Yetkili ekleme hatasi: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    
    ''' <summary>
    ''' Iptal butonuna tiklandiginda
    ''' </summary>
    Private Sub btn_Iptal_Click(sender As Object, e As EventArgs) Handles btn_Iptal.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
    
    ''' <summary>
    ''' Tum Asamalar secildiginde diger secimleri kaldir
    ''' </summary>
    Private Sub chk_Asamalar_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles chk_Asamalar.ItemCheck
        If e.Index = 0 AndAlso e.NewValue = CheckState.Checked Then
            ' Tum Asamalar secildi, diger secimleri kaldir
            For i As Integer = 1 To chk_Asamalar.Items.Count - 1
                chk_Asamalar.SetItemChecked(i, False)
            Next
        ElseIf e.Index > 0 AndAlso e.NewValue = CheckState.Checked Then
            ' Baska bir asama secildi, Tum Asamalar secimini kaldir
            chk_Asamalar.SetItemChecked(0, False)
        End If
    End Sub
    
    ''' <summary>
    ''' Personel arama
    ''' </summary>
    Private Sub txt_PersonelAra_TextChanged(sender As Object, e As EventArgs) Handles txt_PersonelAra.TextChanged
        Try
            Dim aramaMetni As String = txt_PersonelAra.Text.Trim().ToLower()
            Dim gv As DevExpress.XtraGrid.Views.Grid.GridView = CType(grd_Personel.MainView, DevExpress.XtraGrid.Views.Grid.GridView)
            
            If String.IsNullOrEmpty(aramaMetni) Then
                gv.ActiveFilterString = ""
            Else
                gv.ActiveFilterString = "[PERSONELADI] LIKE '%" & aramaMetni & "%' OR [PERSONELKODU] LIKE '%" & aramaMetni & "%'"
            End If
        Catch ex As Exception
            Debug.WriteLine("Arama hatasi: " & ex.Message)
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
            Debug.WriteLine("SQLCalistir Hata: " & ex.Message)
        End Try
        Return dt
    End Function
    
    ' UI Kontrolleri
    Friend WithEvents grd_Personel As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents grd_OnayTurleri As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents chk_Asamalar As System.Windows.Forms.CheckedListBox
    Friend WithEvents btn_Ekle As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_Iptal As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_PersonelAra As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    
End Class

''' <summary>
''' Asama bilgilerini tutan sinif (CheckedListBox icin)
''' </summary>
Public Class AsamaItem
    Public Property ID As Integer
    Public Property Ad As String
    Public Property Kod As String
    
    Public Sub New(id As Integer, ad As String, kod As String)
        Me.ID = id
        Me.Ad = ad
        Me.Kod = kod
    End Sub
    
    Public Overrides Function ToString() As String
        If String.IsNullOrEmpty(Kod) Then
            Return Ad
        Else
            Return Kod & " - " & Ad
        End If
    End Function
End Class
