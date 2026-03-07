Partial Class frm_Param_ETicaret
    Inherits DevExpress.XtraEditors.XtraForm

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

    Private Sub InitializeComponent()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.btnKaydet = New DevExpress.XtraEditors.SimpleButton()
        Me.btnYenile = New DevExpress.XtraEditors.SimpleButton()
        Me.btnKapat = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.Location = New System.Drawing.Point(12, 50)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1160, 500)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        
        Me.btnKaydet.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnKaydet.Location = New System.Drawing.Point(890, 565)
        Me.btnKaydet.Name = "btnKaydet"
        Me.btnKaydet.Size = New System.Drawing.Size(120, 30)
        Me.btnKaydet.TabIndex = 1
        Me.btnKaydet.Text = "Kaydet"
        
        Me.btnYenile.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnYenile.Location = New System.Drawing.Point(1016, 565)
        Me.btnYenile.Name = "btnYenile"
        Me.btnYenile.Size = New System.Drawing.Size(75, 30)
        Me.btnYenile.TabIndex = 2
        Me.btnYenile.Text = "Yenile"
        
        Me.btnKapat.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnKapat.Location = New System.Drawing.Point(1097, 565)
        Me.btnKapat.Name = "btnKapat"
        Me.btnKapat.Size = New System.Drawing.Size(75, 30)
        Me.btnKapat.TabIndex = 3
        Me.btnKapat.Text = "Kapat"
        
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(12, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(289, 23)
        Me.LabelControl1.TabIndex = 4
        Me.LabelControl1.Text = "E-Ticaret Pazar Yeri Parametreleri"
        
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 611)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.btnKapat)
        Me.Controls.Add(Me.btnYenile)
        Me.Controls.Add(Me.btnKaydet)
        Me.Controls.Add(Me.GridControl1)
        Me.Name = "frm_Param_ETicaret"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "E-Ticaret Parametre Yonetimi"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnKaydet As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnYenile As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnKapat As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
End Class
