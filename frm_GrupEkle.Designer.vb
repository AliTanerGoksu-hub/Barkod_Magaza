<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_GrupEkle
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
        Me.txt_GrupAdi = New DevExpress.XtraEditors.TextEdit()
        Me.txt_Aciklama = New DevExpress.XtraEditors.MemoEdit()
        Me.chk_Aktif = New DevExpress.XtraEditors.CheckEdit()
        Me.btn_Ekle = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_Iptal = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        
        CType(Me.txt_GrupAdi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Aciklama.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_Aktif.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        
        ' LabelControl1
        Me.LabelControl1.Location = New System.Drawing.Point(20, 25)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(55, 13)
        Me.LabelControl1.Text = "Grup Adı: *"
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        
        ' txt_GrupAdi
        Me.txt_GrupAdi.Location = New System.Drawing.Point(100, 22)
        Me.txt_GrupAdi.Name = "txt_GrupAdi"
        Me.txt_GrupAdi.Size = New System.Drawing.Size(280, 20)
        Me.txt_GrupAdi.TabIndex = 0
        Me.txt_GrupAdi.Properties.NullValuePrompt = "WhatsApp grup adını girin..."
        
        ' LabelControl2
        Me.LabelControl2.Location = New System.Drawing.Point(20, 55)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(50, 13)
        Me.LabelControl2.Text = "Açıklama:"
        
        ' txt_Aciklama
        Me.txt_Aciklama.Location = New System.Drawing.Point(100, 52)
        Me.txt_Aciklama.Name = "txt_Aciklama"
        Me.txt_Aciklama.Size = New System.Drawing.Size(280, 80)
        Me.txt_Aciklama.TabIndex = 1
        
        ' chk_Aktif
        Me.chk_Aktif.Location = New System.Drawing.Point(100, 145)
        Me.chk_Aktif.Name = "chk_Aktif"
        Me.chk_Aktif.Properties.Caption = "Aktif"
        Me.chk_Aktif.Size = New System.Drawing.Size(75, 19)
        Me.chk_Aktif.TabIndex = 2
        Me.chk_Aktif.EditValue = True
        
        ' btn_Ekle
        Me.btn_Ekle.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btn_Ekle.Appearance.Options.UseFont = True
        Me.btn_Ekle.Location = New System.Drawing.Point(180, 180)
        Me.btn_Ekle.Name = "btn_Ekle"
        Me.btn_Ekle.Size = New System.Drawing.Size(100, 35)
        Me.btn_Ekle.TabIndex = 3
        Me.btn_Ekle.Text = "Ekle"
        
        ' btn_Iptal
        Me.btn_Iptal.Location = New System.Drawing.Point(290, 180)
        Me.btn_Iptal.Name = "btn_Iptal"
        Me.btn_Iptal.Size = New System.Drawing.Size(90, 35)
        Me.btn_Iptal.TabIndex = 4
        Me.btn_Iptal.Text = "İptal"
        
        ' frm_GrupEkle
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 230)
        Me.Controls.Add(Me.btn_Iptal)
        Me.Controls.Add(Me.btn_Ekle)
        Me.Controls.Add(Me.chk_Aktif)
        Me.Controls.Add(Me.txt_Aciklama)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.txt_GrupAdi)
        Me.Controls.Add(Me.LabelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_GrupEkle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Yeni WhatsApp Grubu Ekle"
        
        CType(Me.txt_GrupAdi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Aciklama.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_Aktif.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
End Class
