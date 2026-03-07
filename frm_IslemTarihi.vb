Public Class frm_IslemTarihi 
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub
    Private Sub frm_IslemTarihi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DateEdit1.EditValue = dteSistemTarihi
        DateEdit1.Focus()
        DateEdit1.SelectAll()
    End Sub
    Private Sub SimpleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton4.Click
        DateEdit1.EditValue = Today
    End Sub
    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        DateEdit1.EditValue = DateAdd(DateInterval.Day, -1, DateEdit1.EditValue)
    End Sub
    Private Sub SimpleButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton5.Click
        DateEdit1.EditValue = DateAdd(DateInterval.Day, 1, DateEdit1.EditValue)
    End Sub
End Class