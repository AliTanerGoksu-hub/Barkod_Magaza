<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_GenelDuzenle
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
        Me.txt_Kod = New DevExpress.XtraEditors.TextEdit()
        Me.txt_Ad = New DevExpress.XtraEditors.TextEdit()
        Me.btn_Kaydet = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_Iptal = New DevExpress.XtraEditors.SimpleButton()
        Me.lbl_Kod = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_Ad = New DevExpress.XtraEditors.LabelControl()
        
        CType(Me.txt_Kod.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Ad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        
        ' lbl_Kod
        Me.lbl_Kod.Location = New System.Drawing.Point(20, 25)
        Me.lbl_Kod.Name = "lbl_Kod"
        Me.lbl_Kod.Size = New System.Drawing.Size(25, 13)
        Me.lbl_Kod.Text = "Kod:"
        
        ' txt_Kod
        Me.txt_Kod.Location = New System.Drawing.Point(100, 22)
        Me.txt_Kod.Name = "txt_Kod"
        Me.txt_Kod.Size = New System.Drawing.Size(250, 20)
        Me.txt_Kod.TabIndex = 0
        
        ' lbl_Ad
        Me.lbl_Ad.Location = New System.Drawing.Point(20, 55)
        Me.lbl_Ad.Name = "lbl_Ad"
        Me.lbl_Ad.Size = New System.Drawing.Size(15, 13)
        Me.lbl_Ad.Text = "Ad:"
        
        ' txt_Ad
        Me.txt_Ad.Location = New System.Drawing.Point(100, 52)
        Me.txt_Ad.Name = "txt_Ad"
        Me.txt_Ad.Size = New System.Drawing.Size(250, 20)
        Me.txt_Ad.TabIndex = 1
        
        ' btn_Kaydet
        Me.btn_Kaydet.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btn_Kaydet.Appearance.Options.UseFont = True
        Me.btn_Kaydet.Location = New System.Drawing.Point(150, 95)
        Me.btn_Kaydet.Name = "btn_Kaydet"
        Me.btn_Kaydet.Size = New System.Drawing.Size(100, 35)
        Me.btn_Kaydet.TabIndex = 2
        Me.btn_Kaydet.Text = "Kaydet"
        
        ' btn_Iptal
        Me.btn_Iptal.Location = New System.Drawing.Point(260, 95)
        Me.btn_Iptal.Name = "btn_Iptal"
        Me.btn_Iptal.Size = New System.Drawing.Size(90, 35)
        Me.btn_Iptal.TabIndex = 3
        Me.btn_Iptal.Text = "İptal"
        
        ' frm_GenelDuzenle
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(370, 145)
        Me.Controls.Add(Me.btn_Iptal)
        Me.Controls.Add(Me.btn_Kaydet)
        Me.Controls.Add(Me.txt_Ad)
        Me.Controls.Add(Me.lbl_Ad)
        Me.Controls.Add(Me.txt_Kod)
        Me.Controls.Add(Me.lbl_Kod)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_GenelDuzenle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Düzenle"
        
        CType(Me.txt_Kod.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Ad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub
End Class
