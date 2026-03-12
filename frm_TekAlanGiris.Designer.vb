<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_TekAlanGiris
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
        Me.txt_Deger = New DevExpress.XtraEditors.TextEdit()
        Me.txt_CokSatir = New DevExpress.XtraEditors.MemoEdit()
        Me.btn_Tamam = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_Iptal = New DevExpress.XtraEditors.SimpleButton()
        Me.lbl_Alan = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_Aciklama = New DevExpress.XtraEditors.LabelControl()
        
        CType(Me.txt_Deger.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_CokSatir.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        
        ' lbl_Aciklama
        Me.lbl_Aciklama.Appearance.ForeColor = System.Drawing.Color.Gray
        Me.lbl_Aciklama.Appearance.Options.UseForeColor = True
        Me.lbl_Aciklama.Location = New System.Drawing.Point(20, 10)
        Me.lbl_Aciklama.Name = "lbl_Aciklama"
        Me.lbl_Aciklama.Size = New System.Drawing.Size(50, 13)
        Me.lbl_Aciklama.Text = "Açıklama"
        Me.lbl_Aciklama.Visible = False
        
        ' lbl_Alan
        Me.lbl_Alan.Location = New System.Drawing.Point(20, 35)
        Me.lbl_Alan.Name = "lbl_Alan"
        Me.lbl_Alan.Size = New System.Drawing.Size(35, 13)
        Me.lbl_Alan.Text = "Değer:"
        
        ' txt_Deger
        Me.txt_Deger.Location = New System.Drawing.Point(20, 55)
        Me.txt_Deger.Name = "txt_Deger"
        Me.txt_Deger.Size = New System.Drawing.Size(340, 20)
        Me.txt_Deger.TabIndex = 0
        
        ' txt_CokSatir
        Me.txt_CokSatir.Location = New System.Drawing.Point(20, 55)
        Me.txt_CokSatir.Name = "txt_CokSatir"
        Me.txt_CokSatir.Size = New System.Drawing.Size(340, 80)
        Me.txt_CokSatir.TabIndex = 0
        Me.txt_CokSatir.Visible = False
        
        ' btn_Tamam
        Me.btn_Tamam.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btn_Tamam.Appearance.Options.UseFont = True
        Me.btn_Tamam.Location = New System.Drawing.Point(170, 150)
        Me.btn_Tamam.Name = "btn_Tamam"
        Me.btn_Tamam.Size = New System.Drawing.Size(90, 35)
        Me.btn_Tamam.TabIndex = 1
        Me.btn_Tamam.Text = "Tamam"
        
        ' btn_Iptal
        Me.btn_Iptal.Location = New System.Drawing.Point(270, 150)
        Me.btn_Iptal.Name = "btn_Iptal"
        Me.btn_Iptal.Size = New System.Drawing.Size(90, 35)
        Me.btn_Iptal.TabIndex = 2
        Me.btn_Iptal.Text = "İptal"
        
        ' frm_TekAlanGiris
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 200)
        Me.Controls.Add(Me.btn_Iptal)
        Me.Controls.Add(Me.btn_Tamam)
        Me.Controls.Add(Me.txt_CokSatir)
        Me.Controls.Add(Me.txt_Deger)
        Me.Controls.Add(Me.lbl_Alan)
        Me.Controls.Add(Me.lbl_Aciklama)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_TekAlanGiris"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Değer Girin"
        
        CType(Me.txt_Deger.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_CokSatir.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub
End Class
