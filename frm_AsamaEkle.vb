Imports System.Data.OleDb
Imports System.Collections.Generic

''' <summary>
''' Asama Ekleme Formu
''' Kullanici asamayi kolayca tanimlar
''' </summary>
Public Class frm_AsamaEkle
    Private connection As String = KeyCode.sConnection
    
    Public Property IslemBasarili As Boolean = False
    
    Private Sub frm_AsamaEkle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Yeni Aşama Ekle"
        OnayTurleriYukle()
        
        ' Varsayilan degerler
        txt_SiraNo.Text = "1"
        txt_StandartSure.Text = "60"
        txt_GerekliOnay.Text = "1"
        chk_Aktif.Checked = True
    End Sub
    
    ''' <summary>
    ''' Onay turlerini checkedlistbox'a yukler
    ''' </summary>
    Private Sub OnayTurleriYukle()
        Try
            Dim dt As DataTable = SQLCalistir("SELECT nOnayTurID, sOnayTurKodu, sOnayTurAdi FROM tbOnayTurleri WHERE bAktif = 1 ORDER BY nOncelik")
            
            chk_OnayTurleri.Items.Clear()
            For Each dr As DataRow In dt.Rows
                Dim item As New OnayTurItem(
                    Convert.ToInt32(dr("nOnayTurID")),
                    dr("sOnayTurKodu").ToString(),
                    dr("sOnayTurAdi").ToString()
                )
                chk_OnayTurleri.Items.Add(item)
            Next
            
            ' Varsayilan olarak ilk itemi sec
            If chk_OnayTurleri.Items.Count > 0 Then
                chk_OnayTurleri.SetItemChecked(0, True)
            End If
        Catch ex As Exception
            MessageBox.Show("Onay turleri yuklenirken hata: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    
    ''' <summary>
    ''' Ekle butonuna tiklandiginda
    ''' </summary>
    Private Sub btn_Ekle_Click(sender As Object, e As EventArgs) Handles btn_Ekle.Click
        Try
            ' Validasyon
            If String.IsNullOrWhiteSpace(txt_AsamaAdi.Text) Then
                MessageBox.Show("Aşama adı boş olamaz.", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txt_AsamaAdi.Focus()
                Exit Sub
            End If
            
            Dim sAsamaKodu As String = txt_AsamaKodu.Text.Trim()
            Dim sAsamaAdi As String = txt_AsamaAdi.Text.Trim()
            Dim nSiraNo As Integer = 0
            Integer.TryParse(txt_SiraNo.Text, nSiraNo)
            Dim nStandartSure As Integer = 60
            Integer.TryParse(txt_StandartSure.Text, nStandartSure)
            Dim nGerekliOnay As Integer = 1
            Integer.TryParse(txt_GerekliOnay.Text, nGerekliOnay)
            Dim bAktif As Boolean = chk_Aktif.Checked
            Dim sAciklama As String = txt_Aciklama.Text.Trim()
            
            ' Secilen onay turlerini al
            Dim onayTurleri As New List(Of String)
            For i As Integer = 0 To chk_OnayTurleri.Items.Count - 1
                If chk_OnayTurleri.GetItemChecked(i) Then
                    Dim item As OnayTurItem = CType(chk_OnayTurleri.Items(i), OnayTurItem)
                    onayTurleri.Add(item.Kod)
                End If
            Next
            
            Dim sOnayTurleri As String = String.Join(",", onayTurleri)
            If String.IsNullOrEmpty(sOnayTurleri) Then
                sOnayTurleri = "URETIM_YETKILISI"
            End If
            
            ' Insert
            Dim sql As String = "INSERT INTO tbUretimAsamaTanim (sAsamaKodu, sAsamaAdi, nSiraNo, bAktif, nGerekliOnay, sOnayTurleri, nStandartSure, sAciklama) VALUES ('" &
                               sAsamaKodu.Replace("'", "''") & "', '" &
                               sAsamaAdi.Replace("'", "''") & "', " &
                               nSiraNo & ", " &
                               If(bAktif, 1, 0) & ", " &
                               nGerekliOnay & ", '" &
                               sOnayTurleri.Replace("'", "''") & "', " &
                               nStandartSure & ", '" &
                               sAciklama.Replace("'", "''") & "')"
            
            SQLCalistir(sql)
            
            IslemBasarili = True
            MessageBox.Show("Aşama başarıyla eklendi." & vbCrLf & vbCrLf &
                           "Aşama Adı: " & sAsamaAdi & vbCrLf &
                           "Sıra No: " & nSiraNo, "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.DialogResult = DialogResult.OK
            Me.Close()
            
        Catch ex As Exception
            MessageBox.Show("Aşama ekleme hatası: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
    Friend WithEvents txt_AsamaKodu As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_AsamaAdi As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_SiraNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_StandartSure As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_GerekliOnay As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_Aciklama As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents chk_Aktif As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chk_OnayTurleri As System.Windows.Forms.CheckedListBox
    Friend WithEvents btn_Ekle As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_Iptal As DevExpress.XtraEditors.SimpleButton
    
End Class

''' <summary>
''' Onay Tur bilgilerini tutan sinif
''' </summary>
Public Class OnayTurItem
    Public Property ID As Integer
    Public Property Kod As String
    Public Property Ad As String
    
    Public Sub New(id As Integer, kod As String, ad As String)
        Me.ID = id
        Me.Kod = kod
        Me.Ad = ad
    End Sub
    
    Public Overrides Function ToString() As String
        Return Kod & " - " & Ad
    End Function
End Class
