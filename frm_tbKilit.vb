Imports System.Security.Permissions
Imports Microsoft.Win32
Public Class frm_tbKilit
    Public kullanici
    Public oto As Integer = 0
    Public islem As Integer = 0
    Private tarih1 As DateTime
    Private tarih2 As DateTime
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        kilitle_kaldir()
    End Sub
    Private Sub kilitle_kaldir()
        SimpleButton3.Enabled = False
        lbl_info.Text = Sorgu_sDil("Lütfen Bekleyiniz...", sDil)
        lbl_info.Refresh()
        If oto <> 1 Then
            islem = sec_islem.SelectedIndex
        End If
        tarih1 = DateEdit1.EditValue
        tarih2 = DateEdit2.EditValue
        belgeleri_kilitle()
        lbl_info.Text = Sorgu_sDil("Tamamlandı...", sDil)
        SimpleButton3.Enabled = True
        If oto = 1 Then
            Me.Close()
        End If
    End Sub
    Private Sub belgeleri_kilitle()
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        cmd.CommandTimeout = False
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        If islem = 0 Then
            lbl_info.Text = "Fisler Kilitleniyor..."
            lbl_info.Refresh()
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbStokFisiMaster SET bKilitli = 1 WHERE (dteFisTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') and bKilitli=0 ")
            cmd.ExecuteNonQuery()
            lbl_info.Text = "Bordrolar Kilitleniyor..."
            lbl_info.Refresh()
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbFirmaBordroMaster SET bKilitli = 1 WHERE (dteBordroTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') and bKilitli=0")
            cmd.ExecuteNonQuery()
            lbl_info.Text = "Cek/Senet Hareketleri Kilitleniyor..."
            lbl_info.Refresh()
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbCekSenetBordro SET bKilitli = 1 WHERE (dteBordroTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') and bKilitli=0")
            cmd.ExecuteNonQuery()
            lbl_info.Text = "Muhasebe Fisleri Kilitleniyor..."
            lbl_info.Refresh()
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbMuhasebeFisiAciklamasi SET bKilitli = 1 WHERE (dteFisTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') and bKilitli=0")
            cmd.ExecuteNonQuery()
            'lbl_info.Text = "Sipariş Fişleri Kilitleniyor..."
            'lbl_info.Refresh()
            'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbSiparisAciklamasi SET bKilitli = 1 WHERE bKilitli=0")
            'cmd.ExecuteNonQuery()
            lbl_info.Text = "Talep Formları Kilitleniyor..."
            lbl_info.Refresh()
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE ASTOKETIKETTALEPBASLIK SET bKilitli = 1 WHERE (TARIH BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') and bKilitli=0")
            cmd.ExecuteNonQuery()
        ElseIf islem = 1 Then
            lbl_info.Text = "Fis Kilitleri Kaldiriliyor..."
            lbl_info.Refresh()
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbStokFisiMaster SET bKilitli = 0 WHERE (dteFisTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') and bKilitli=1")
            cmd.ExecuteNonQuery()
            lbl_info.Text = "Bordro Kilitleri Kaldiriliyor..."
            lbl_info.Refresh()
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbFirmaBordroMaster SET bKilitli = 0 WHERE (dteBordroTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') and bKilitli=1")
            cmd.ExecuteNonQuery()
            lbl_info.Text = "Cek/Senet Hareket Kilitleri Kaldiriliyor..."
            lbl_info.Refresh()
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbCekSenetBordro SET bKilitli = 0 WHERE (dteBordroTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') and bKilitli=1")
            cmd.ExecuteNonQuery()
            lbl_info.Text = "Muhasebe Fisi Kilitleri Kaldiriliyor..."
            lbl_info.Refresh()
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbMuhasebeFisiAciklamasi SET bKilitli = 0 WHERE (dteFisTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') and bKilitli=1")
            cmd.ExecuteNonQuery()
            lbl_info.Text = "Talep Formu Kilitleri Kaldiriliyor..."
            lbl_info.Refresh()
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE ASTOKETIKETTALEPBASLIK SET bKilitli = 0 WHERE (TARIH BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') and bKilitli=1")
            cmd.ExecuteNonQuery()
        End If
        con.Close()
    End Sub
    Private Function sorgu_query(ByVal query As String) As String
        query = Replace(query, "*!F", "F0" + firmano.ToString)
        query = Replace(query, "!D", "D000" + donemno.ToString)
        Return query
    End Function
    Private Function sorgu(ByVal query As String) As DataSet
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        adapter.SelectCommand = cmd
        cmd.CommandText = query
        cmd.Connection = con
        con.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, "TABLE1")
        con.Close()
        Return DS
    End Function
    Private Sub frm_tbKilit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        DateEdit1.EditValue = "01/01/1900"
        DateEdit2.EditValue = dteSistemTarihi
        Try
            CheckEdit1.Checked = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("OtoKilit").GetValue("durum")
            TimeEdit1.EditValue = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("OtoKilit").GetValue("kilitSaat")
            TimeEdit2.EditValue = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("OtoKilit").GetValue("kilitAcSaat")
        Catch ex As Exception
        End Try
        If oto = 1 Then
            If Form1.otoKilitKontrol = True Then
                kilitle_kaldir()
            End If
        End If
    End Sub
    Private Sub frm_tbKilit_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("OtoKilit").SetValue("durum", CheckEdit1.Checked.ToString())
            Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("OtoKilit").SetValue("kilitSaat", TimeEdit1.Text)
            Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("OtoKilit").SetValue("kilitAcSaat", TimeEdit2.Text)
            Form1.otoKilitKontrol = CheckEdit1.Checked
            Form1.otoKilitSaat = TimeEdit1.Text
            Form1.otoKilitAcSaat = TimeEdit2.Text
        Catch ex As Exception
        End Try
        Form1.otoKilitOnline = False
    End Sub
End Class