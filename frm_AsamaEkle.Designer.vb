<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_AsamaEkle
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
        Me.txt_AsamaKodu = New DevExpress.XtraEditors.TextEdit()
        Me.txt_AsamaAdi = New DevExpress.XtraEditors.TextEdit()
        Me.txt_SiraNo = New DevExpress.XtraEditors.TextEdit()
        Me.txt_StandartSure = New DevExpress.XtraEditors.TextEdit()
        Me.txt_GerekliOnay = New DevExpress.XtraEditors.TextEdit()
        Me.txt_Aciklama = New DevExpress.XtraEditors.MemoEdit()
        Me.chk_Aktif = New DevExpress.XtraEditors.CheckEdit()
        Me.chk_OnayTurleri = New System.Windows.Forms.CheckedListBox()
        Me.btn_Ekle = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_Iptal = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        
        CType(Me.txt_AsamaKodu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_AsamaAdi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_SiraNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_StandartSure.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_GerekliOnay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Aciklama.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_Aktif.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        Me.SuspendLayout()
        
        ' GroupControl1 - Temel Bilgiler
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.txt_AsamaKodu)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.txt_AsamaAdi)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.txt_SiraNo)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.txt_StandartSure)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.txt_GerekliOnay)
        Me.GroupControl1.Controls.Add(Me.chk_Aktif)
        Me.GroupControl1.Controls.Add(Me.LabelControl6)
        Me.GroupControl1.Controls.Add(Me.txt_Aciklama)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 12)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(400, 280)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Aşama Bilgileri"
        
        ' LabelControl1
        Me.LabelControl1.Location = New System.Drawing.Point(15, 35)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(70, 13)
        Me.LabelControl1.Text = "Aşama Kodu:"
        
        ' txt_AsamaKodu
        Me.txt_AsamaKodu.Location = New System.Drawing.Point(120, 32)
        Me.txt_AsamaKodu.Name = "txt_AsamaKodu"
        Me.txt_AsamaKodu.Size = New System.Drawing.Size(150, 20)
        Me.txt_AsamaKodu.Properties.NullValuePrompt = "Örn: KESIM"
        
        ' LabelControl2
        Me.LabelControl2.Location = New System.Drawing.Point(15, 65)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(70, 13)
        Me.LabelControl2.Text = "Aşama Adı: *"
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl2.Appearance.Options.UseForeColor = True
        
        ' txt_AsamaAdi
        Me.txt_AsamaAdi.Location = New System.Drawing.Point(120, 62)
        Me.txt_AsamaAdi.Name = "txt_AsamaAdi"
        Me.txt_AsamaAdi.Size = New System.Drawing.Size(265, 20)
        Me.txt_AsamaAdi.Properties.NullValuePrompt = "Örn: Kesim Aşaması"
        
        ' LabelControl3
        Me.LabelControl3.Location = New System.Drawing.Point(15, 95)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(45, 13)
        Me.LabelControl3.Text = "Sıra No:"
        
        ' txt_SiraNo
        Me.txt_SiraNo.Location = New System.Drawing.Point(120, 92)
        Me.txt_SiraNo.Name = "txt_SiraNo"
        Me.txt_SiraNo.Size = New System.Drawing.Size(80, 20)
        Me.txt_SiraNo.Properties.Mask.EditMask = "d"
        Me.txt_SiraNo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        
        ' LabelControl4
        Me.LabelControl4.Location = New System.Drawing.Point(15, 125)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(100, 13)
        Me.LabelControl4.Text = "Standart Süre (dk):"
        
        ' txt_StandartSure
        Me.txt_StandartSure.Location = New System.Drawing.Point(120, 122)
        Me.txt_StandartSure.Name = "txt_StandartSure"
        Me.txt_StandartSure.Size = New System.Drawing.Size(80, 20)
        Me.txt_StandartSure.Properties.Mask.EditMask = "d"
        Me.txt_StandartSure.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        
        ' LabelControl5
        Me.LabelControl5.Location = New System.Drawing.Point(15, 155)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(80, 13)
        Me.LabelControl5.Text = "Gerekli Onay:"
        
        ' txt_GerekliOnay
        Me.txt_GerekliOnay.Location = New System.Drawing.Point(120, 152)
        Me.txt_GerekliOnay.Name = "txt_GerekliOnay"
        Me.txt_GerekliOnay.Size = New System.Drawing.Size(80, 20)
        Me.txt_GerekliOnay.Properties.Mask.EditMask = "d"
        Me.txt_GerekliOnay.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        
        ' chk_Aktif
        Me.chk_Aktif.Location = New System.Drawing.Point(220, 152)
        Me.chk_Aktif.Name = "chk_Aktif"
        Me.chk_Aktif.Properties.Caption = "Aktif"
        Me.chk_Aktif.Size = New System.Drawing.Size(75, 19)
        
        ' LabelControl6
        Me.LabelControl6.Location = New System.Drawing.Point(15, 185)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(50, 13)
        Me.LabelControl6.Text = "Açıklama:"
        
        ' txt_Aciklama
        Me.txt_Aciklama.Location = New System.Drawing.Point(120, 182)
        Me.txt_Aciklama.Name = "txt_Aciklama"
        Me.txt_Aciklama.Size = New System.Drawing.Size(265, 80)
        
        ' GroupControl2 - Onay Turleri
        Me.GroupControl2.Controls.Add(Me.LabelControl7)
        Me.GroupControl2.Controls.Add(Me.chk_OnayTurleri)
        Me.GroupControl2.Location = New System.Drawing.Point(418, 12)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(250, 280)
        Me.GroupControl2.TabIndex = 1
        Me.GroupControl2.Text = "Onay Türleri"
        
        ' LabelControl7
        Me.LabelControl7.Location = New System.Drawing.Point(10, 30)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(200, 13)
        Me.LabelControl7.Text = "Bu aşamada geçerli onay türleri:"
        
        ' chk_OnayTurleri
        Me.chk_OnayTurleri.CheckOnClick = True
        Me.chk_OnayTurleri.FormattingEnabled = True
        Me.chk_OnayTurleri.Location = New System.Drawing.Point(10, 50)
        Me.chk_OnayTurleri.Name = "chk_OnayTurleri"
        Me.chk_OnayTurleri.Size = New System.Drawing.Size(230, 214)
        
        ' btn_Ekle
        Me.btn_Ekle.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btn_Ekle.Appearance.Options.UseFont = True
        Me.btn_Ekle.Location = New System.Drawing.Point(468, 305)
        Me.btn_Ekle.Name = "btn_Ekle"
        Me.btn_Ekle.Size = New System.Drawing.Size(100, 35)
        Me.btn_Ekle.TabIndex = 2
        Me.btn_Ekle.Text = "Ekle"
        
        ' btn_Iptal
        Me.btn_Iptal.Location = New System.Drawing.Point(578, 305)
        Me.btn_Iptal.Name = "btn_Iptal"
        Me.btn_Iptal.Size = New System.Drawing.Size(90, 35)
        Me.btn_Iptal.TabIndex = 3
        Me.btn_Iptal.Text = "İptal"
        
        ' frm_AsamaEkle
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 352)
        Me.Controls.Add(Me.btn_Iptal)
        Me.Controls.Add(Me.btn_Ekle)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_AsamaEkle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Yeni Aşama Ekle"
        
        CType(Me.txt_AsamaKodu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_AsamaAdi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_SiraNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_StandartSure.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_GerekliOnay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Aciklama.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_Aktif.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
End Class
