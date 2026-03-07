Imports DevExpress.XtraEditors
Public Class frm_calendar
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label1.Text = DateTime.Now
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        DateEdit1.EditValue = Today
        DateEdit2.EditValue = Today
        DateEdit3.EditValue = Today
    End Sub
    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        XtraMessageBox.Show(Sorgu_sDil("www.barkodyazilimevi.com", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub btn_Hesapla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Hesapla.Click
        lbl_GunFarki.Text = DateDiff(DateInterval.Day, DateEdit1.EditValue, DateEdit2.EditValue)
        lbl_HaftaFarki.Text = DateDiff(DateInterval.WeekOfYear, DateEdit1.EditValue, DateEdit2.EditValue)
        lbl_AyFarki.Text = DateDiff(DateInterval.Month, DateEdit1.EditValue, DateEdit2.EditValue)
        lbl_YilFarki.Text = DateDiff(DateInterval.Year, DateEdit1.EditValue, DateEdit2.EditValue)
    End Sub
    Private Sub GroupControl2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles GroupControl2.Paint
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Dim tarih1 As DateTime
        Dim tarih2 As DateTime
        Dim tarih3 As DateTime
        Dim tarih4 As DateTime
        If RadioGroup1.SelectedIndex = 0 Then
            tarih1 = DateAdd(DateInterval.Day, txt_nGun.EditValue, DateEdit3.EditValue)
            tarih2 = DateAdd(DateInterval.WeekOfYear, txt_nHafta.EditValue, tarih1)
            tarih3 = DateAdd(DateInterval.Month, txt_nAy.EditValue, tarih2)
            tarih4 = DateAdd(DateInterval.WeekOfYear, txt_nHafta.EditValue, tarih3)
            lbl_Tarih.Text = tarih4
        ElseIf RadioGroup1.SelectedIndex = 1 Then
            tarih1 = DateAdd(DateInterval.Day, -txt_nGun.EditValue, DateEdit3.EditValue)
            tarih2 = DateAdd(DateInterval.WeekOfYear, -txt_nHafta.EditValue, tarih1)
            tarih3 = DateAdd(DateInterval.Month, -txt_nAy.EditValue, tarih2)
            tarih4 = DateAdd(DateInterval.WeekOfYear, -txt_nHafta.EditValue, tarih3)
            lbl_Tarih.Text = tarih4
        End If
        MonthCalendar1.SetDate(tarih4)
    End Sub
End Class
