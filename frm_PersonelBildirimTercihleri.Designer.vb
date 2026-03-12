<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_PersonelBildirimTercihleri
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
        Me.lbl_PersonelAdi = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_Telefon = New DevExpress.XtraEditors.LabelControl()
        Me.chk_EmailBildirim = New DevExpress.XtraEditors.CheckEdit()
        Me.chk_SMSBildirim = New DevExpress.XtraEditors.CheckEdit()
        Me.chk_WhatsAppBildirim = New DevExpress.XtraEditors.CheckEdit()
        Me.chk_UygulamaBildirim = New DevExpress.XtraEditors.CheckEdit()
        Me.txt_WhatsAppNo = New DevExpress.XtraEditors.TextEdit()
        Me.btn_Kaydet = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_Iptal = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        
        CType(Me.chk_EmailBildirim.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_SMSBildirim.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_WhatsAppBildirim.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_UygulamaBildirim.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_WhatsAppNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        Me.SuspendLayout()
        
        ' lbl_PersonelAdi
        Me.lbl_PersonelAdi.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_PersonelAdi.Location = New System.Drawing.Point(20, 20)
        Me.lbl_PersonelAdi.Name = "lbl_PersonelAdi"
        Me.lbl_PersonelAdi.Size = New System.Drawing.Size(300, 19)
        Me.lbl_PersonelAdi.Text = "Personel: "
        
        ' lbl_Telefon
        Me.lbl_Telefon.Location = New System.Drawing.Point(20, 50)
        Me.lbl_Telefon.Name = "lbl_Telefon"
        Me.lbl_Telefon.Size = New System.Drawing.Size(200, 13)
        Me.lbl_Telefon.Text = "Telefon: "
        Me.lbl_Telefon.Appearance.ForeColor = System.Drawing.Color.Gray
        
        ' GroupControl1 - Bildirim Kanallari
        Me.GroupControl1.Location = New System.Drawing.Point(20, 80)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(360, 220)
        Me.GroupControl1.Text = "Bildirim Kanallari"
        Me.GroupControl1.Controls.Add(Me.chk_EmailBildirim)
        Me.GroupControl1.Controls.Add(Me.chk_SMSBildirim)
        Me.GroupControl1.Controls.Add(Me.chk_WhatsAppBildirim)
        Me.GroupControl1.Controls.Add(Me.chk_UygulamaBildirim)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.txt_WhatsAppNo)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        
        ' chk_EmailBildirim
        Me.chk_EmailBildirim.Location = New System.Drawing.Point(20, 35)
        Me.chk_EmailBildirim.Name = "chk_EmailBildirim"
        Me.chk_EmailBildirim.Properties.Caption = "Email Bildirimi Al"
        Me.chk_EmailBildirim.Size = New System.Drawing.Size(150, 19)
        
        ' chk_SMSBildirim
        Me.chk_SMSBildirim.Location = New System.Drawing.Point(20, 65)
        Me.chk_SMSBildirim.Name = "chk_SMSBildirim"
        Me.chk_SMSBildirim.Properties.Caption = "SMS Bildirimi Al"
        Me.chk_SMSBildirim.Size = New System.Drawing.Size(150, 19)
        
        ' chk_WhatsAppBildirim
        Me.chk_WhatsAppBildirim.Location = New System.Drawing.Point(20, 95)
        Me.chk_WhatsAppBildirim.Name = "chk_WhatsAppBildirim"
        Me.chk_WhatsAppBildirim.Properties.Caption = "WhatsApp Bildirimi Al"
        Me.chk_WhatsAppBildirim.Size = New System.Drawing.Size(150, 19)
        
        ' chk_UygulamaBildirim
        Me.chk_UygulamaBildirim.Location = New System.Drawing.Point(20, 125)
        Me.chk_UygulamaBildirim.Name = "chk_UygulamaBildirim"
        Me.chk_UygulamaBildirim.Properties.Caption = "Uygulama Ici Bildirim Al"
        Me.chk_UygulamaBildirim.Size = New System.Drawing.Size(170, 19)
        
        ' LabelControl1
        Me.LabelControl1.Location = New System.Drawing.Point(20, 160)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(100, 13)
        Me.LabelControl1.Text = "WhatsApp Numarasi:"
        
        ' txt_WhatsAppNo
        Me.txt_WhatsAppNo.Location = New System.Drawing.Point(130, 157)
        Me.txt_WhatsAppNo.Name = "txt_WhatsAppNo"
        Me.txt_WhatsAppNo.Size = New System.Drawing.Size(200, 20)
        Me.txt_WhatsAppNo.Properties.NullValuePrompt = "Orn: 5551234567"
        
        ' LabelControl2
        Me.LabelControl2.Location = New System.Drawing.Point(20, 185)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(300, 13)
        Me.LabelControl2.Text = "(Bos birakilirsa Telefon1 alani kullanilir)"
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.Gray
        
        ' btn_Kaydet
        Me.btn_Kaydet.Location = New System.Drawing.Point(120, 320)
        Me.btn_Kaydet.Name = "btn_Kaydet"
        Me.btn_Kaydet.Size = New System.Drawing.Size(100, 35)
        Me.btn_Kaydet.Text = "Kaydet"
        Me.btn_Kaydet.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.btn_Kaydet.Appearance.ForeColor = System.Drawing.Color.White
        
        ' btn_Iptal
        Me.btn_Iptal.Location = New System.Drawing.Point(230, 320)
        Me.btn_Iptal.Name = "btn_Iptal"
        Me.btn_Iptal.Size = New System.Drawing.Size(100, 35)
        Me.btn_Iptal.Text = "Iptal"
        
        ' frm_PersonelBildirimTercihleri
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 380)
        Me.Controls.Add(Me.lbl_PersonelAdi)
        Me.Controls.Add(Me.lbl_Telefon)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.btn_Kaydet)
        Me.Controls.Add(Me.btn_Iptal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_PersonelBildirimTercihleri"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Bildirim Tercihleri"
        
        CType(Me.chk_EmailBildirim.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_SMSBildirim.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_WhatsAppBildirim.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_UygulamaBildirim.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_WhatsAppNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
End Class
