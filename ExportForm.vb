Public Class ExportForm 
    Inherits DevExpress.XtraEditors.XtraForm
    Public Sub New(ByVal parent As Form)
        InitializeComponent()
        ClientSize = New Size(pictureBox1.Image.Width + DockPadding.All * 2, pictureBox1.Image.Height + DockPadding.All * 2)
        If parent IsNot Nothing Then
            Left = parent.Left + (parent.Width - Width) \ 2
            Top = parent.Top + (parent.Height - Height) \ 2
        End If
    End Sub
End Class