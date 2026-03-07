Imports Microsoft.Win32
Imports DevExpress.XtraEditors
Public Class frm_License
    'Private Const MyProductName As String = "BusinessSolutions"
    Public UserNameT As String = ""
    Public bUyari As Boolean = False
    Dim bYasal As Boolean = True
    Public bCrack As Boolean = False
    Dim sLicenseKey As String = ""
    Private Sub frm_License_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txt_sOnayKodu.EditValue = UserNameT.ToString
        Try
            bYasal = Registry.LocalMachine.OpenSubKey("Software").OpenSubKey("SYSTEM").OpenSubKey("Sec").GetValue("UYS").ToString()
        Catch ex As Exception
            bYasal = True
        End Try
        Try
            sLicenseKey = Registry.LocalMachine.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("Key").GetValue("License").ToString()
        Catch ex As Exception
            sLicensekey = ""
        End Try
        If bYasal = False Then
            bUyari = True
            Group_Uyari.Visible = True
            Me.ClientSize = New System.Drawing.Size(480, 494)
            Me.Size = New System.Drawing.Size(486, 521)
        Else
            Me.ClientSize = New System.Drawing.Size(480, 380)
            Me.Size = New System.Drawing.Size(486, 380)
        End If
        Call GenNewKey()
        'btnDecrypt()
        Beep()
    End Sub
    Private Sub GenNewKey()
        'Dim BinKey As Object
        Dim RawKey As String
        Dim ProdNameT As String
        Dim FeatID As Integer
        FeatID = 0
        'Build bitmap from checkboxes
        UserNameT = Trim(UserNameT)
        ProdNameT = Trim(hdd)
        If Not (UserNameT = "") Or Not (ProdNameT = "") Then
            RawKey = GenKeyString(UserNameT, ProdNameT & MyProductName, FeatID)
            'BinKey = HexStrToBinStr(RawKey)
            'KeyCode.Text = FormatKeyCode(Base32Enc(BinKey), 5)
            TextEdit1.Text = FormatKeyCode(RawKey.ToString, 4)
            'TextEdit2.Text = FormatKeyCode(DigestStrToHexStr(TextEdit1.Text), 4)
        Else
            TextEdit1.Text = "Please Enter Licensee and/or Serial Number"
        End If
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        XtraMessageBox.Show(oku(TextEdit1.Text), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Function oku(ByVal key As String)
        key = Replace(key, "A", "Adana" & vbCrLf)
        key = Replace(key, "B", "Bursa" & vbCrLf)
        key = Replace(key, "C", "Ceyhun" & vbCrLf)
        key = Replace(key, "D", "Diyarbakýr" & vbCrLf)
        key = Replace(key, "E", "Edirne" & vbCrLf)
        key = Replace(key, "F", "Fatsa" & vbCrLf)
        key = Replace(key, "G", "Giresun" & vbCrLf)
        key = Replace(key, "H", "Hakkari" & vbCrLf)
        key = Replace(key, "I", "Isparta" & vbCrLf)
        key = Replace(key, "Ý", "Ýzmir" & vbCrLf)
        key = Replace(key, "J", "Jandarma" & vbCrLf)
        key = Replace(key, "K", "Kastamonu" & vbCrLf)
        key = Replace(key, "L", "Luleburgaz" & vbCrLf)
        key = Replace(key, "M", "Manisa" & vbCrLf)
        key = Replace(key, "N", "Niðde" & vbCrLf)
        key = Replace(key, "O", "Osmanli" & vbCrLf)
        key = Replace(key, "Ö", "Özbekistan" & vbCrLf)
        key = Replace(key, "P", "Paris" & vbCrLf)
        key = Replace(key, "R", "Rize" & vbCrLf)
        key = Replace(key, "S", "Sivas" & vbCrLf)
        key = Replace(key, "Þ", "Þahin" & vbCrLf)
        key = Replace(key, "T", "Tokat" & vbCrLf)
        key = Replace(key, "U", "Urfa" & vbCrLf)
        key = Replace(key, "Ü", "Üzeyir" & vbCrLf)
        key = Replace(key, "V", "Van" & vbCrLf)
        key = Replace(key, "Y", "Yozgat" & vbCrLf)
        key = Replace(key, "Z", "Zonguldak" & vbCrLf)
        key = Replace(key, "X", "X" & vbCrLf)
        key = Replace(key, "W", "Washington" & vbCrLf)
        key = Replace(key, "0", "Sýfýr" & vbCrLf)
        key = Replace(key, "1", "Bir" & vbCrLf)
        key = Replace(key, "2", "Ýki" & vbCrLf)
        key = Replace(key, "3", "Üç" & vbCrLf)
        key = Replace(key, "4", "Dört" & vbCrLf)
        key = Replace(key, "5", "Beþ" & vbCrLf)
        key = Replace(key, "6", "Altý" & vbCrLf)
        key = Replace(key, "7", "Yedi" & vbCrLf)
        key = Replace(key, "8", "Sekiz" & vbCrLf)
        key = Replace(key, "9", "Dokuz" & vbCrLf)
        key = Replace(key, "-", "" & vbCrLf)
        Return key
    End Function
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click, SimpleButton2.Click
        If bUyari = True Then
            If TextEdit2.Text = "DEMO" Then
                TextEdit2.Text = ""
            End If
        End If
        'Dim lskey As New ListBox
        'lskey.Items.Add("CD10-DB54-2863-96B1-AB89-2282-A86E-0C4F")
        'lskey.Items.Add("524E-8070-544F-6F38-AFCF-B250-E24B-2343")
        'lskey.Items.Add("3DC2-C579-2894-FEDE-8C86-58B4-6567-9340")
        'lskey.Items.Add("7D29-FC97-6CBC-6CE9-B8E0-DC25-8C24-7B1A")
        'lskey.Items.Add("CC21-374B-287D-98E3-9B6C-B3EC-7BF9-44CF")
        'lskey.Items.Add("1165-3DB6-B148-BFDF-C344-A4B8-39B7-3E77")
        'lskey.Items.Add("9543-C725-8EDD-7973-56B3-3AE2-644D-566F")
        'If lskey.Items.Contains(sLicenseKey) = True And TextEdit2.Text <> "DEMO" Then
        'TextEdit2.Text = ""
        'End If
        If TextEdit2.Text = "DEMO" Then
            Registry.LocalMachine.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("Key").SetValue("License", TextEdit2.Text)
            Registry.LocalMachine.CreateSubKey("Software").CreateSubKey("SYSTEM").CreateSubKey("Sec").SetValue("UYS", True)
            Me.DialogResult = Windows.Forms.DialogResult.OK
            'ElseIf TextEdit2.Text = "CD10-DB54-2863-96B1-AB89-2282-A86E-0C4F" Then
            'Registry.LocalMachine.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("Key").SetValue("License", TextEdit2.Text)
            'Registry.LocalMachine.CreateSubKey("Software").CreateSubKey("SYSTEM").CreateSubKey("Sec").SetValue("UYS", True)
            'bCrack = True
            'Me.DialogResult = Windows.Forms.DialogResult.OK
            'ElseIf TextEdit2.Text = "524E-8070-544F-6F38-AFCF-B250-E24B-2343" Then
            'Registry.LocalMachine.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("Key").SetValue("License", TextEdit2.Text)
            'Registry.LocalMachine.CreateSubKey("Software").CreateSubKey("SYSTEM").CreateSubKey("Sec").SetValue("UYS", True)
            'bCrack = True
            'Me.DialogResult = Windows.Forms.DialogResult.OK
            'ElseIf TextEdit2.Text = "3DC2-C579-2894-FEDE-8C86-58B4-6567-9340" Then
            'Registry.LocalMachine.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("Key").SetValue("License", TextEdit2.Text)
            'Registry.LocalMachine.CreateSubKey("Software").CreateSubKey("SYSTEM").CreateSubKey("Sec").SetValue("UYS", True)
            'bCrack = True
            'Me.DialogResult = Windows.Forms.DialogResult.OK
            'ElseIf TextEdit2.Text = "7D29-FC97-6CBC-6CE9-B8E0-DC25-8C24-7B1A" Then
            'Registry.LocalMachine.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("Key").SetValue("License", TextEdit2.Text)
            'Registry.LocalMachine.CreateSubKey("Software").CreateSubKey("SYSTEM").CreateSubKey("Sec").SetValue("UYS", True)
            'bCrack = True
            'Me.DialogResult = Windows.Forms.DialogResult.OK
            'ElseIf TextEdit2.Text = "CC21-374B-287D-98E3-9B6C-B3EC-7BF9-44CF" Then
            'Registry.LocalMachine.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("Key").SetValue("License", TextEdit2.Text)
            'Registry.LocalMachine.CreateSubKey("Software").CreateSubKey("SYSTEM").CreateSubKey("Sec").SetValue("UYS", True)
            'bCrack = True
            'Me.DialogResult = Windows.Forms.DialogResult.OK
            'ElseIf TextEdit2.Text = "1165-3DB6-B148-BFDF-C344-A4B8-39B7-3E77" Then
            'Registry.LocalMachine.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("Key").SetValue("License", TextEdit2.Text)
            'Registry.LocalMachine.CreateSubKey("Software").CreateSubKey("SYSTEM").CreateSubKey("Sec").SetValue("UYS", True)
            'bCrack = True
            'Me.DialogResult = Windows.Forms.DialogResult.OK
            'ElseIf TextEdit2.Text = "9543-C725-8EDD-7973-56B3-3AE2-644D-566F" Then
            'Registry.LocalMachine.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("Key").SetValue("License", TextEdit2.Text)
            'Registry.LocalMachine.CreateSubKey("Software").CreateSubKey("SYSTEM").CreateSubKey("Sec").SetValue("UYS", True)
            'bCrack = True
            'Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            If TextEdit2.Text = FormatKeyCode(DigestStrToHexStr(TextEdit1.Text), 4) Then
                Registry.LocalMachine.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("Key").SetValue("License", TextEdit2.Text)
                Registry.LocalMachine.CreateSubKey("Software").CreateSubKey("SYSTEM").CreateSubKey("Sec").SetValue("UYS", True)
                Registry.LocalMachine.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("Key").SetValue("sOnayKodu", txt_sOnayKodu.Text)
                'MsgBox(Sorgu_sDil("Lisans Anahtariniz Onaylanmistir..." & vbCrLf & "Lutfen Programi Yeniden Calistiriniz...",sDil), MessageBoxIcon.Information, sorgu_sDil("Dikkat",sDil))
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
                XtraMessageBox.Show(Sorgu_sDil("Hatalý Lisans Anahtarý..." & vbCrLf & "Lütfen Tekran Deneyiniz...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Registry.LocalMachine.CreateSubKey("Software").CreateSubKey("SYSTEM").CreateSubKey("Sec").SetValue("UYS", False)
                TextEdit2.Focus()
                TextEdit2.SelectAll()
            End If
        End If
    End Sub
End Class