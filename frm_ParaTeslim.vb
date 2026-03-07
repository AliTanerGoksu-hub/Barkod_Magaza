Public Class frm_ParaTeslim 
    Private Sub frm_ParaTeslim_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dataload()
    End Sub
    Private Sub dataload()
        Dim dr As DataRow
        dr = DataSet1.Tables(0).NewRow
        dr("sDovizCinsi") = "500"
        dr("lKur") = 500
        dr("lMiktar") = 0
        dr("lTutar") = 0
        DataSet1.Tables(0).Rows.Add(dr)
        dr = DataSet1.Tables(0).NewRow
        dr("sDovizCinsi") = "200"
        dr("lKur") = 200
        dr("lMiktar") = 0
        dr("lTutar") = 0
        DataSet1.Tables(0).Rows.Add(dr)
        dr = DataSet1.Tables(0).NewRow
        dr("sDovizCinsi") = "100"
        dr("lKur") = 100
        dr("lMiktar") = 0
        dr("lTutar") = 0
        DataSet1.Tables(0).Rows.Add(dr)
        dr = DataSet1.Tables(0).NewRow
        dr("sDovizCinsi") = "50"
        dr("lKur") = 50
        dr("lMiktar") = 0
        dr("lTutar") = 0
        DataSet1.Tables(0).Rows.Add(dr)
        dr = DataSet1.Tables(0).NewRow
        dr("sDovizCinsi") = "20"
        dr("lKur") = 20
        dr("lMiktar") = 0
        dr("lTutar") = 0
        DataSet1.Tables(0).Rows.Add(dr)
        dr = DataSet1.Tables(0).NewRow
        dr("sDovizCinsi") = "10"
        dr("lKur") = 10
        dr("lMiktar") = 0
        dr("lTutar") = 0
        DataSet1.Tables(0).Rows.Add(dr)
        dr = DataSet1.Tables(0).NewRow
        dr("sDovizCinsi") = "5"
        dr("lKur") = 5
        dr("lMiktar") = 0
        dr("lTutar") = 0
        DataSet1.Tables(0).Rows.Add(dr)
        dr = DataSet1.Tables(0).NewRow
        dr("sDovizCinsi") = "1"
        dr("lKur") = 1
        dr("lMiktar") = 0
        dr("lTutar") = 0
        DataSet1.Tables(0).Rows.Add(dr)
        dr = DataSet1.Tables(0).NewRow
        dr("sDovizCinsi") = ".5"
        dr("lKur") = 0.5
        dr("lMiktar") = 0
        dr("lTutar") = 0
        DataSet1.Tables(0).Rows.Add(dr)
        dr = DataSet1.Tables(0).NewRow
        dr("sDovizCinsi") = ".25"
        dr("lKur") = 0.25
        dr("lMiktar") = 0
        dr("lTutar") = 0
        DataSet1.Tables(0).Rows.Add(dr)
        dr = DataSet1.Tables(0).NewRow
        dr("sDovizCinsi") = ".1"
        dr("lKur") = 0.1
        dr("lMiktar") = 0
        dr("lTutar") = 0
        DataSet1.Tables(0).Rows.Add(dr)
        dr = DataSet1.Tables(0).NewRow
        dr("sDovizCinsi") = ".005"
        dr("lKur") = 0.005
        dr("lMiktar") = 0
        dr("lTutar") = 0
        DataSet1.Tables(0).Rows.Add(dr)
        dr = DataSet1.Tables(0).NewRow
        dr("sDovizCinsi") = "USD"
        dr("lKur") = 1
        dr("lMiktar") = 0
        dr("lTutar") = 0
        DataSet1.Tables(0).Rows.Add(dr)
        dr = DataSet1.Tables(0).NewRow
        dr("sDovizCinsi") = "EUR"
        dr("lKur") = 1
        dr("lMiktar") = 0
        dr("lTutar") = 0
        DataSet1.Tables(0).Rows.Add(dr)
        dr = DataSet1.Tables(0).NewRow
        dr("sDovizCinsi") = "SAR"
        dr("lKur") = 1
        dr("lMiktar") = 0
        dr("lTutar") = 0
        DataSet1.Tables(0).Rows.Add(dr)
    End Sub
    Private Sub tutar_hesapla()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)

            If dr("lKur") = 0 Then
                dr("lKur") = 1
            End If
            dr("lTutar") = dr("lMiktar") * dr("lKur")
            toplam_hesapla()
        End If
    End Sub
    Private Sub toplam_hesapla()
        Dim dr As DataRow
        Dim lKagitPara As Decimal = 0
        Dim lBozukPara As Decimal = 0
        Dim lNakitPara As Decimal = 0
        Dim lKasa As Decimal = 0
        Dim lOdemeler As Decimal = 0
        Dim lPoslar As Decimal = 0
        Dim lGenelKasa As Decimal = 0
        Dim lZToplam As Decimal = 0
        Dim lAcilis As Decimal = 0
        Dim lKapanis As Decimal = 0
        Dim lFark As Decimal = 0
        Dim nIptalSayisi As Decimal = 0
        Dim lIptalTutari As Decimal = 0
        Dim lGonderilecek As Decimal = 0
        For Each dr In DataSet1.Tables(0).Rows
            lNakitPara += dr("lTutar")
            If Trim(dr("sDovizCinsi")) = "USD" Or Trim(dr("sDovizCinsi")) = "EUR" Or Trim(dr("sDovizCinsi")) = "RYL" Then
            Else
                If dr("lKur") = 500 Then
                    lKagitPara += dr("lTutar")
                ElseIf dr("lKur") = 200 Then
                    lKagitPara += dr("lTutar")
                ElseIf dr("lKur") = 100 Then
                    lKagitPara += dr("lTutar")
                ElseIf dr("lKur") = 50 Then
                    lKagitPara += dr("lTutar")
                ElseIf dr("lKur") = 20 Then
                    lKagitPara += dr("lTutar")
                ElseIf dr("lKur") = 10 Then
                    lKagitPara += dr("lTutar")
                ElseIf dr("lKur") = 5 Then
                    lKagitPara += dr("lTutar")
                ElseIf dr("lKur") = 1 Then
                    lBozukPara += dr("lTutar")
                ElseIf dr("lKur") = 0.5 Then
                    lBozukPara += dr("lTutar")
                ElseIf dr("lKur") = 0.25 Then
                    lBozukPara += dr("lTutar")
                ElseIf dr("lKur") = 0.1 Then
                    lBozukPara += dr("lTutar")
                ElseIf dr("lKur") = 0.05 Then
                    lBozukPara += dr("lTutar")
                End If
            End If

        Next
        lKasa = lNakitPara + lOdemeler
        lGenelKasa = lKasa + lPoslar
        lFark = lGenelKasa - lZToplam - lAcilis
        lGonderilecek = lNakitPara - lKapanis
        lbl_lKagitPara.Text = Microsoft.VisualBasic.Format(lKagitPara, "#,0.00")
        lbl_lBozukPara.Text = Microsoft.VisualBasic.Format(lBozukPara, "#,0.00")
        lbl_lNakitPara.Text = Microsoft.VisualBasic.Format(lNakitPara, "#,0.00")
        'lbl_lOdemeler.Text = Microsoft.VisualBasic.Format(lOdemeler, "#,0.00")
        'lbl_lKasa.Text = Microsoft.VisualBasic.Format(lKasa, "#,0.00")
        'lbl_lPoslar.Text = Microsoft.VisualBasic.Format(lPoslar, "#,0.00")
        'lbl_lGenelKasa.Text = Microsoft.VisualBasic.Format(lGenelKasa, "#,0.00")
        'lbl_lZToplam.Text = Microsoft.VisualBasic.Format(lZToplam, "#,0.00")
        'lbl_lFark.Text = Microsoft.VisualBasic.Format(lFark, "#,0.00")
    End Sub
    Private Sub gorunum_yazdir()
        Dim kriter As String = ""
        kriter += "Kağıt Para:" & lbl_lKagitPara.Text & vbCrLf & "Bozuk Para:" & lbl_lBozukPara.Text & vbCrLf & "Nakit Para: " & lbl_lNakitPara.Text
        printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", kriter, "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Finans Yönetimi-Financial Managment", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        printlink1.CreateDocument(ps)
        ps.PreviewRibbonFormEx.Show()
    End Sub
    Private Sub GridView1_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanged
        tutar_hesapla()
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        gorunum_yazdir()
    End Sub
    Private Sub GridView1_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            If dr("sDovizCinsi") = "USD" Then
                collKur.OptionsColumn.AllowFocus = True
                collKur.OptionsColumn.AllowEdit = True
            ElseIf dr("sDovizCinsi") = "EUR" Then
                collKur.OptionsColumn.AllowFocus = True
                collKur.OptionsColumn.AllowEdit = True
            ElseIf dr("sDovizCinsi") = "SAR" Then
                collKur.OptionsColumn.AllowFocus = True
                collKur.OptionsColumn.AllowEdit = True
            Else
                collKur.OptionsColumn.AllowFocus = False
                collKur.OptionsColumn.AllowEdit = False
            End If
        End If
    End Sub
End Class