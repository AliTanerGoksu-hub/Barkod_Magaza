Imports Microsoft.Win32
Imports DevExpress.XtraEditors
Public Class frm_musteri_kodu_degistir
    Dim sorguC As SorguClass = New SorguClass
    Private Sub frm_stok_kodu_degistir_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        PanelControl2.Visible = False
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        If XtraMessageBox.Show("Eski Müþteri No: " & Trim(eskiMusteriNo.Text) & "," & vbCrLf & "Yeni Müþteri No: " & Trim(yeniMusteriID.Text) & "," & vbCrLf & "Fiþ No: " & Trim(fisNo.Text) & vbCrLf & "Olarak Deðiþtirmek Ýstediðinize Eminmisiniz...?", Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            PanelControl2.Visible = True
            PanelControl2.BringToFront()
            Me.Enabled = False
            sorguC.sorgu_tam("Update tbStokFisiDetayi Set nMusteriID = '" & Trim(yeniMusteriID.Text) & "' Where (lFisNo = '" & Trim(fisNo.Text) & "') AND (nMusteriID = '" & eskiMusteriNo.Text & "')")
            sorguC.sorgu_Destek("Satýþ Fiþinde Müþteri Kodu Deðiþtirme", "Eski Müþteri No: " & Trim(eskiMusteriNo.Text) & ", Yeni Müþteri No: " & Trim(yeniMusteriID.Text) & ", Fiþ No: " & Trim(fisNo.Text) & "", "SimpleButton1_Click()", "frm_musteri_kodu_degistir.vb")
            MessageBox.Show("Müþteri no deðiþtirme iþlemi baþarýlý.", "Business Smart")
            PanelControl2.Visible = False
            Me.Enabled = True
            Me.Close()
        End If
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub yeniMusteriID_ButtonClick(sender As System.Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles yeniMusteriID.ButtonClick
        Dim frm As New frm_musteri_liste
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.islemstatus = True
        frm.kullanici = kullanici
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim dr1 As DataRow
            dr1 = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
            yeniMusteriID.Text = dr1("nMusteriID")
            yeniMusteri.Text = sorguC.sorgu("Select (sAdi + ' ' + sSoyadi) as sAdi from tbMusteri where nMusteriID = '" & Trim(yeniMusteriID.Text) & "'")
        End If
    End Sub
    Private Sub fisNo_TextChanged(sender As System.Object, e As System.EventArgs) Handles fisNo.TextChanged
        SimpleButton1.Enabled = False
        If fisNo.Text.Length >= 1 Then
            SimpleButton1.Enabled = True
        Else
            SimpleButton1.Enabled = False
        End If
        eskiMusteriNo.Text = sorguC.sorgu("Select nMusteriID From tbStokFisiDetayi Where lFisNo = '" & Trim(fisNo.Text) & "'")
        eskiMusteri.Text = sorguC.sorgu("Select (sAdi + ' ' + sSoyadi) as sAdi from tbMusteri where nMusteriID = '" & Trim(eskiMusteriNo.Text) & "'")
    End Sub
End Class