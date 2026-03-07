Public Class frm_Fatura_MasrafSatiri 
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub
    Private Sub frm_Fatura_MasrafSatiri_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sec_satir.Properties.DataSource = ds_hareket.Tables(0)
    End Sub
End Class