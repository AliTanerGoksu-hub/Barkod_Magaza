Imports DevExpress.XtraPrinting
Imports System.Drawing.Printing
Imports DevExpress.XtraLayout
Public Class frm_tbResim
    Public bTekResim As Boolean = True
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        ElseIf Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        gorunum_yazdir()
    End Sub
    Private Sub gorunum_yazdir()
        printlink1.CreateDocument(ps)
        ps.PreviewRibbonFormEx.Show()
    End Sub
    Private Sub gorunum_yazdir_resim()
        ps.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4Extra
        ps.PageSettings.Landscape = True
        ps.PageSettings.LeftMargin = 0
        ps.PageSettings.RightMargin = 0
        ps.PageSettings.TopMargin = 0
        ps.PageSettings.BottomMargin = 0
        Dim gr As DevExpress.XtraPrinting.BrickGraphics
        gr = ps.Graph
        ps.Begin()
        Dim offsetY As Single = 0
        Dim ImageBrick As New ImageBrick()
        ImageBrick.Image = PictureEdit1.EditValue
        ImageBrick.BorderWidth = 0
        ImageBrick.BorderStyle = BrickBorderStyle.Inset
        ImageBrick.Sides = BorderSide.All
        ImageBrick.SizeMode = ImageSizeMode.Squeeze
        gr.DrawBrick(ImageBrick, New RectangleF(New PointF(0, offsetY), ps.PageSettings.UsablePageSizeInPixels))
        offsetY += ps.PageSettings.UsablePageSizeInPixels.Height
        ps.End()
        ps.PreviewRibbonFormEx.Show()
    End Sub
    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Me.Close()
    End Sub
    Private Sub frm_tbResim_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If bTekResim = True Then
            Dim dr As DataRow = dsResim.Tables(0).NewRow
            dr("nResimID") = 0
            dr("nSira") = 0
            dr("sAciklama") = "Önizle"
            dr("pResim") = PictureEdit1.EditValue
            ' OLD STRUCTURE - COMMENTED OUT

            ' dr(\"pResim1\") = PictureEdit1.EditValue

            ' Yeni yapı: Her resim ayrı satır (nSira)
            ' dr(\"pResim2\") = PictureEdit1.EditValue
            dsResim.Tables(0).Rows.Add(dr)
        End If
        GridControl1.DataSource = dsResim.Tables(0)
    End Sub
End Class