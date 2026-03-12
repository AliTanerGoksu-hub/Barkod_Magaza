<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_GrupUyeleri
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.grd_Personeller = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.grd_Uyeler = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.btn_UyeEkle = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_UyeCikar = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.grd_Personeller, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd_Uyeler, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        
        ' SplitContainerControl1
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(800, 400)
        Me.SplitContainerControl1.SplitterPosition = 390
        
        ' Left Panel - Personeller
        Me.LabelControl1.Location = New System.Drawing.Point(10, 10)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(100, 13)
        Me.LabelControl1.Text = "Tum Personeller:"
        
        Me.grd_Personeller.Location = New System.Drawing.Point(10, 30)
        Me.grd_Personeller.MainView = Me.GridView1
        Me.grd_Personeller.Name = "grd_Personeller"
        Me.grd_Personeller.Size = New System.Drawing.Size(370, 360)
        Me.grd_Personeller.TabIndex = 0
        
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.LabelControl1)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.grd_Personeller)
        
        ' Right Panel - Uyeler
        Me.LabelControl2.Location = New System.Drawing.Point(10, 10)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(100, 13)
        Me.LabelControl2.Text = "Grup Uyeleri:"
        
        Me.grd_Uyeler.Location = New System.Drawing.Point(10, 30)
        Me.grd_Uyeler.MainView = Me.GridView2
        Me.grd_Uyeler.Name = "grd_Uyeler"
        Me.grd_Uyeler.Size = New System.Drawing.Size(370, 360)
        Me.grd_Uyeler.TabIndex = 0
        
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.LabelControl2)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.grd_Uyeler)
        
        ' Buttons
        Me.btn_UyeEkle.Location = New System.Drawing.Point(300, 420)
        Me.btn_UyeEkle.Name = "btn_UyeEkle"
        Me.btn_UyeEkle.Size = New System.Drawing.Size(100, 30)
        Me.btn_UyeEkle.TabIndex = 1
        Me.btn_UyeEkle.Text = "Ekle >>"
        
        Me.btn_UyeCikar.Location = New System.Drawing.Point(410, 420)
        Me.btn_UyeCikar.Name = "btn_UyeCikar"
        Me.btn_UyeCikar.Size = New System.Drawing.Size(100, 30)
        Me.btn_UyeCikar.TabIndex = 2
        Me.btn_UyeCikar.Text = "<< Cikar"
        
        ' GridViews
        Me.GridView1.GridControl = Me.grd_Personeller
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        
        Me.GridView2.GridControl = Me.grd_Uyeler
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.Editable = False
        
        ' Form
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 470)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Controls.Add(Me.btn_UyeEkle)
        Me.Controls.Add(Me.btn_UyeCikar)
        Me.Name = "frm_GrupUyeleri"
        Me.Text = "Grup Uyeleri"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.grd_Personeller, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd_Uyeler, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
End Class
