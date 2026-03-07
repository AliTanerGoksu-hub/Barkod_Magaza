Public Class frm_Keyboard 
    Dim shift As String = ""
    Public Delegate Sub KeyboardDelegate(ByVal sender As Object, ByVal e As KeyboardEventArgs)
    Private shiftindicator As [Boolean] = False
    Private capslockindicator As [Boolean] = False
    Private controlindicator As [Boolean] = False
    Private pvtKeyboardKeyPressed As String = ""
    Public Class KeyboardEventArgs
        Inherits EventArgs
        Private ReadOnly pvtKeyboardKeyPressed As String
        Public Sub New(ByVal KeyboardKeyPressed As String)
            Me.pvtKeyboardKeyPressed = KeyboardKeyPressed
        End Sub
        Public ReadOnly Property KeyboardKeyPressed() As String
            Get
                Return pvtKeyboardKeyPressed
            End Get
        End Property
    End Class
    Public Event UserKeyPressed As KeyboardDelegate
    Protected Overridable Sub OnUserKeyPressed(ByVal e As KeyboardEventArgs)
        shiftindicator = False
        RaiseEvent UserKeyPressed(Me, e)
    End Sub
    Private Sub SimpleButton52_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_1.Click
        SendKeys.Send("1")
    End Sub
    Private Sub SimpleButton51_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_2.Click
        SendKeys.Send("2")
    End Sub
    Private Sub SimpleButton50_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton50.Click
        SendKeys.Send("3")
    End Sub
    Private Sub SimpleButton49_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton49.Click
        SendKeys.Send("4")
    End Sub
    Private Sub SimpleButton48_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton48.Click
        SendKeys.Send("5")
    End Sub
    Private Sub SimpleButton47_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton47.Click
        SendKeys.Send("&")
    End Sub
    Private Sub SimpleButton46_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton46.Click
        SendKeys.Send("7")
    End Sub
    Private Sub SimpleButton45_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton45.Click
        SendKeys.Send("8")
    End Sub
    Private Sub SimpleButton44_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton44.Click
        SendKeys.Send("9")
    End Sub
    Private Sub SimpleButton43_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton43.Click
        SendKeys.Send("0")
    End Sub
    Private Sub SimpleButton42_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton42.Click
        SendKeys.Send("*")
    End Sub
    Private Sub SimpleButton41_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton41.Click
        SendKeys.Send("-")
    End Sub
    Private Sub SimpleButton40_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_ESC.Click
        SendKeys.Send("{ESCAPE}")
    End Sub
    Private Sub SimpleButton37_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_TAB.Click
        SendKeys.Send("{TAB}")
    End Sub
    Private Sub SimpleButton53_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton53.Click
        SendKeys.Send("{BACKSPACE}")
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_Q.Click
        SendKeys.Send("Q")
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_W.Click
        SendKeys.Send("W")
    End Sub
    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_E.Click
        SendKeys.Send("E")
    End Sub
    Private Sub SimpleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_R.Click
        SendKeys.Send("R")
    End Sub
    Private Sub SimpleButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_T.Click
        SendKeys.Send("T")
    End Sub
    Private Sub SimpleButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_Y.Click
        SendKeys.Send("Y")
    End Sub
    Private Sub SimpleButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_U.Click
        SendKeys.Send("U")
    End Sub
    Private Sub SimpleButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_I.Click
        SendKeys.Send("I")
    End Sub
    Private Sub SimpleButton9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton9.Click
        SendKeys.Send("0")
    End Sub
    Private Sub SimpleButton10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton10.Click
        SendKeys.Send("P")
    End Sub
    Private Sub SimpleButton11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton11.Click
        SendKeys.Send("Ğ")
    End Sub
    Private Sub SimpleButton12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton12.Click
        SendKeys.Send("Ü")
    End Sub
    Private Sub SimpleButton24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton24.Click
        SendKeys.Send("A")
    End Sub
    Private Sub SimpleButton23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton23.Click
        SendKeys.Send("S")
    End Sub
    Private Sub SimpleButton22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton22.Click
        SendKeys.Send("D")
    End Sub
    Private Sub SimpleButton21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton21.Click
        SendKeys.Send("F")
    End Sub
    Private Sub SimpleButton20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton20.Click
        SendKeys.Send("G")
    End Sub
    Private Sub SimpleButton19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton19.Click
        SendKeys.Send("H")
    End Sub
    Private Sub SimpleButton18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton18.Click
        SendKeys.Send("J")
    End Sub
    Private Sub SimpleButton17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton17.Click
        SendKeys.Send("K")
    End Sub
    Private Sub SimpleButton16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton16.Click
        SendKeys.Send("L")
    End Sub
    Private Sub SimpleButton15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton15.Click
        SendKeys.Send("Ş")
    End Sub
    Private Sub SimpleButton14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton14.Click
        SendKeys.Send("İ")
    End Sub
    Private Sub SimpleButton13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton13.Click
        SendKeys.Send(",")
    End Sub
    Private Sub SimpleButton54_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton54.Click
        SendKeys.Send("{ENTER}")
    End Sub
    Private Sub SimpleButton36_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton36.Click
        SendKeys.Send("<")
    End Sub
    Private Sub SimpleButton35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton35.Click
        SendKeys.Send("Z")
    End Sub
    Private Sub SimpleButton34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton34.Click
        SendKeys.Send("X")
    End Sub
    Private Sub SimpleButton33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton33.Click
        SendKeys.Send("C")
    End Sub
    Private Sub SimpleButton32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton32.Click
        SendKeys.Send("V")
    End Sub
    Private Sub SimpleButton31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton31.Click
        SendKeys.Send("B")
    End Sub
    Private Sub SimpleButton30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton30.Click
        SendKeys.Send("N")
    End Sub
    Private Sub SimpleButton29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton29.Click
        SendKeys.Send("M")
    End Sub
    Private Sub SimpleButton28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton28.Click
        SendKeys.Send("Ö")
    End Sub
    Private Sub SimpleButton27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton27.Click
        SendKeys.Send("Ç")
    End Sub
    Private Sub SimpleButton26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton26.Click
        SendKeys.Send(".")
    End Sub
    Private Sub SimpleButton67_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton67.Click
        SendKeys.Send("{SPACE}")
    End Sub
    Private Sub SimpleButton59_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton59.Click
        SendKeys.Send("{INSERT}")
    End Sub
    Private Sub SimpleButton60_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton60.Click
        SendKeys.Send("{HOME}")
    End Sub
    Private Sub SimpleButton61_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton61.Click
        SendKeys.Send("{PAGEUP}")
    End Sub
    Private Sub SimpleButton62_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton62.Click
        SendKeys.Send("{DEL}")
    End Sub
    Private Sub SimpleButton63_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton63.Click
        SendKeys.Send("{END}")
    End Sub
    Private Sub SimpleButton64_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton64.Click
        SendKeys.Send("{PAGEDOWN}")
    End Sub
    Private Sub SimpleButton55_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton55.Click
        SendKeys.Send("{LEFT}")
    End Sub
    Private Sub SimpleButton58_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton58.Click
        SendKeys.Send("{UP}")
    End Sub
    Private Sub SimpleButton56_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton56.Click
        SendKeys.Send("{DOWN}")
    End Sub
    Private Sub SimpleButton57_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton57.Click
        SendKeys.Send("{RIGHT}")
    End Sub
    Private Sub SimpleButton73_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton73.Click
        SendKeys.Send("/")
    End Sub
    Private Sub SimpleButton74_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton74.Click
        SendKeys.Send("*")
    End Sub
    Private Sub SimpleButton75_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton75.Click
        SendKeys.Send("-")
    End Sub
    Private Sub SimpleButton89_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton89.Click
        SendKeys.Send("{ENTER}")
    End Sub
    Private Sub SimpleButton78_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton78.Click
        SendKeys.Send("7")
    End Sub
    Private Sub SimpleButton77_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton77.Click
        SendKeys.Send("8")
    End Sub
    Private Sub SimpleButton76_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton76.Click
        SendKeys.Send("9")
    End Sub
    Private Sub SimpleButton81_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton81.Click
        SendKeys.Send("4")
    End Sub
    Private Sub SimpleButton80_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton80.Click
        SendKeys.Send("5")
    End Sub
    Private Sub SimpleButton79_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton79.Click
        SendKeys.Send("6")
    End Sub
    Private Sub SimpleButton84_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton84.Click
        SendKeys.Send("1")
    End Sub
    Private Sub SimpleButton83_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton83.Click
        SendKeys.Send("2")
    End Sub
    Private Sub SimpleButton82_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton82.Click
        SendKeys.Send("3")
    End Sub
    Private Sub SimpleButton87_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton87.Click
        SendKeys.Send("0")
    End Sub
    Private Sub SimpleButton85_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton85.Click
        SendKeys.Send(".")
    End Sub
    Private Sub SimpleButton88_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton88.Click
        SendKeys.Send("+")
    End Sub
    Private Sub SimpleButton65_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton65.Click
        If controlindicator = False Then
            controlindicator = True
        ElseIf controlindicator = True Then
            controlindicator = False
        End If
    End Sub
    Private Sub SimpleButton38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_CAPS.Click
        If capslockindicator = False Then
            capslockindicator = True
        ElseIf capslockindicator = True Then
            capslockindicator = False
        End If
    End Sub
    Private Sub SimpleButton25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton25.Click
        If shiftindicator = False Then
            shiftindicator = True
        ElseIf shiftindicator = True Then
            shiftindicator = False
        End If
    End Sub
End Class