Imports System.ComponentModel
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Namespace brkdutil
    Public Class WaitDlgFrm
        Inherits Form
        Private pic As PictureBox
        Private pictureBox1 As PictureBox
        Friend WithEvents Timer1 As Timer
        Private WithEvents lblText As DevExpress.XtraEditors.LabelControl
        Private WithEvents label1 As DevExpress.XtraEditors.LabelControl
        Private components As IContainer
        Private m_caption As String = ""
        Private mi_CountTimer As New Timer()
        Private ms32_MilliSec As Integer = 0
        Private ReadOnly ms_LabelText As String = "Executing..."
        Private ReadOnly mb_PreventClose As Boolean = True
        Private mb_MadeVisible As Boolean
        Public Sub New()
            Me.New("", New Size(260, 50))
        End Sub
        Public Sub New(ByVal caption As String)
            Me.New(caption, New Size(260, 50))
        End Sub
        Public Sub New(ByVal caption As String, ByVal size As Size)
            Me.components = New Container
            Me.m_caption = caption
            ms_LabelText = caption
            Me.pic = New PictureBox()
            Me.Timer1 = New Timer(Me.components)
            Me.FormBorderStyle = FormBorderStyle.FixedDialog
            Me.StartPosition = FormStartPosition.CenterScreen
            Me.ClientSize = size
            Me.ControlBox = False
            Me.ShowInTaskbar = False
            Me.TopMost = True
            Timer1.Enabled = True
            'AddHandler Me.Timer1.Tick, New EventHandler(AddressOf Timer1_Tick)
            AddHandler Paint, New PaintEventHandler(AddressOf WaitDialogPaint)
            pic.Size = New Size(16, 16)
            pic.Location = New Point(8, ClientSize.Height \ 2 - 16)
            'pic.Image = Bitmap.FromStream(System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("wait.gif"));			
            Controls.Add(pic)
            Show()
            Refresh()
        End Sub
        Public Function GetCaption() As String
            Return Caption
        End Function
        Public Sub SetCaption(ByVal newCaption As String)
            Caption = newCaption
        End Sub
        Public Property Caption() As String
            Get
                Return m_caption
            End Get
            Set(ByVal value As String)
                m_caption = value
                Refresh()
            End Set
        End Property
        Private Sub WaitDialogPaint(ByVal sender As Object, ByVal e As PaintEventArgs)
            Dim r As Rectangle = e.ClipRectangle
            r.Inflate(-1, -1)
            Dim sf As New StringFormat()
            sf.Alignment = InlineAssignHelper(sf.LineAlignment, StringAlignment.Center)
            ControlPaint.DrawBorder3D(e.Graphics, r, Border3DStyle.RaisedInner)
            r.X += 20
            r.Width -= 20
            r.Height /= 3
            r.Y += r.Height \ 2
            e.Graphics.DrawString("Veri Yükleniyor.Lütfen Bekleyiniz...!", New Font("Arial", 8.75, FontStyle.Bold), SystemBrushes.WindowText, r, sf)
            r.Y += r.Height
            e.Graphics.DrawString(m_caption, New Font("Arial", 9), SystemBrushes.WindowText, r, sf)
        End Sub
        Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer1.Tick
            ms32_MilliSec += mi_CountTimer.Interval
            ' Move window back to origional position after one second
            If Not mb_MadeVisible AndAlso ms32_MilliSec > 700 Then
                mb_MadeVisible = True
                ' Center the window to its owner
                'Functions.CenterWindow(Me)
            End If
            Caption = String.Format("{0} ({1} sec)", ms_LabelText, ms32_MilliSec \ 1000)
            AddHandler Paint, New PaintEventHandler(AddressOf WaitDialogPaint)
            Refresh()
        End Sub
        Protected Overrides Sub OnClosing(ByVal e As CancelEventArgs)
            pic.Image = Nothing
            Timer1.Enabled = False
            Timer1 = Nothing
            MyBase.OnClosing(e)
        End Sub
        Private Sub InitializeComponent()
            Dim resources As ComponentResourceManager = New ComponentResourceManager(GetType(WaitDlgFrm))
            Me.pictureBox1 = New PictureBox
            Me.lblText = New DevExpress.XtraEditors.LabelControl
            Me.label1 = New DevExpress.XtraEditors.LabelControl
            CType(Me.pictureBox1, ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'pictureBox1
            '
            Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), Image)
            Me.pictureBox1.Location = New Point(8, 6)
            Me.pictureBox1.Name = "pictureBox1"
            Me.pictureBox1.Size = New Size(32, 32)
            Me.pictureBox1.TabIndex = 0
            Me.pictureBox1.TabStop = False
            '
            'lblText
            '
            Me.lblText.Location = New Point(46, 6)
            Me.lblText.Name = "lblText"
            Me.lblText.Size = New Size(196, 18)
            Me.lblText.TabIndex = 7
            Me.lblText.Text = "Executing..."
            '
            'Label1
            '
            Me.label1.Location = New Point(46, 24)
            Me.label1.Name = "Label1"
            Me.label1.Size = New Size(196, 18)
            Me.label1.TabIndex = 8
            Me.label1.Text = "Executing..."
            '
            'WaitDlgFrm
            '
            Me.AutoScaleBaseSize = New Size(5, 13)
            Me.BackColor = SystemColors.ControlDark
            Me.ClientSize = New Size(254, 44)
            Me.ControlBox = False
            Me.Controls.Add(Me.label1)
            Me.Controls.Add(Me.lblText)
            Me.Controls.Add(Me.pictureBox1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.Name = "WaitDlgFrm"
            Me.ShowInTaskbar = False
            Me.StartPosition = FormStartPosition.CenterScreen
            CType(Me.pictureBox1, ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub
        Private Shared Function InlineAssignHelper(Of T)(ByRef target As T, ByVal value As T) As T
            target = value
            Return value
        End Function

    End Class
End Namespace