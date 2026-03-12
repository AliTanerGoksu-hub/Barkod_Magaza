' ============================================
' TRENDYOL API AYAR FORMU - DESIGNER
' Dosya: frm_TrendyolAyar.Designer.vb
' DevExpress 12.2 uyumlu - Standart kontroller
' ============================================

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_TrendyolAyar
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
        Me.grp_ApiAyar = New System.Windows.Forms.GroupBox()
        Me.txt_BaseUrl = New System.Windows.Forms.TextBox()
        Me.txt_ApiSecret = New System.Windows.Forms.TextBox()
        Me.txt_ApiKey = New System.Windows.Forms.TextBox()
        Me.txt_SupplierId = New System.Windows.Forms.TextBox()
        Me.lbl_BaseUrl = New System.Windows.Forms.Label()
        Me.lbl_ApiSecret = New System.Windows.Forms.Label()
        Me.lbl_ApiKey = New System.Windows.Forms.Label()
        Me.lbl_SupplierId = New System.Windows.Forms.Label()
        Me.btn_Test = New System.Windows.Forms.Button()
        Me.btn_Kaydet = New System.Windows.Forms.Button()
        Me.btn_Iptal = New System.Windows.Forms.Button()
        Me.lbl_Status = New System.Windows.Forms.Label()
        Me.grp_Bilgi = New System.Windows.Forms.GroupBox()
        Me.lbl_Bilgi = New System.Windows.Forms.Label()
        Me.grp_ApiAyar.SuspendLayout()
        Me.grp_Bilgi.SuspendLayout()
        Me.SuspendLayout()
        '
        'grp_ApiAyar
        '
        Me.grp_ApiAyar.Controls.Add(Me.txt_BaseUrl)
        Me.grp_ApiAyar.Controls.Add(Me.txt_ApiSecret)
        Me.grp_ApiAyar.Controls.Add(Me.txt_ApiKey)
        Me.grp_ApiAyar.Controls.Add(Me.txt_SupplierId)
        Me.grp_ApiAyar.Controls.Add(Me.lbl_BaseUrl)
        Me.grp_ApiAyar.Controls.Add(Me.lbl_ApiSecret)
        Me.grp_ApiAyar.Controls.Add(Me.lbl_ApiKey)
        Me.grp_ApiAyar.Controls.Add(Me.lbl_SupplierId)
        Me.grp_ApiAyar.Location = New System.Drawing.Point(12, 12)
        Me.grp_ApiAyar.Name = "grp_ApiAyar"
        Me.grp_ApiAyar.Size = New System.Drawing.Size(460, 180)
        Me.grp_ApiAyar.TabIndex = 0
        Me.grp_ApiAyar.TabStop = False
        Me.grp_ApiAyar.Text = "Trendyol API Bilgileri"
        '
        'lbl_SupplierId
        '
        Me.lbl_SupplierId.AutoSize = True
        Me.lbl_SupplierId.Location = New System.Drawing.Point(15, 32)
        Me.lbl_SupplierId.Name = "lbl_SupplierId"
        Me.lbl_SupplierId.Size = New System.Drawing.Size(52, 13)
        Me.lbl_SupplierId.TabIndex = 0
        Me.lbl_SupplierId.Text = "Satıcı ID:"
        '
        'txt_SupplierId
        '
        Me.txt_SupplierId.Location = New System.Drawing.Point(120, 29)
        Me.txt_SupplierId.Name = "txt_SupplierId"
        Me.txt_SupplierId.Size = New System.Drawing.Size(320, 20)
        Me.txt_SupplierId.TabIndex = 1
        '
        'lbl_ApiKey
        '
        Me.lbl_ApiKey.AutoSize = True
        Me.lbl_ApiKey.Location = New System.Drawing.Point(15, 62)
        Me.lbl_ApiKey.Name = "lbl_ApiKey"
        Me.lbl_ApiKey.Size = New System.Drawing.Size(48, 13)
        Me.lbl_ApiKey.TabIndex = 2
        Me.lbl_ApiKey.Text = "API Key:"
        '
        'txt_ApiKey
        '
        Me.txt_ApiKey.Location = New System.Drawing.Point(120, 59)
        Me.txt_ApiKey.Name = "txt_ApiKey"
        Me.txt_ApiKey.Size = New System.Drawing.Size(320, 20)
        Me.txt_ApiKey.TabIndex = 3
        '
        'lbl_ApiSecret
        '
        Me.lbl_ApiSecret.AutoSize = True
        Me.lbl_ApiSecret.Location = New System.Drawing.Point(15, 92)
        Me.lbl_ApiSecret.Name = "lbl_ApiSecret"
        Me.lbl_ApiSecret.Size = New System.Drawing.Size(60, 13)
        Me.lbl_ApiSecret.TabIndex = 4
        Me.lbl_ApiSecret.Text = "API Secret:"
        '
        'txt_ApiSecret
        '
        Me.txt_ApiSecret.Location = New System.Drawing.Point(120, 89)
        Me.txt_ApiSecret.Name = "txt_ApiSecret"
        Me.txt_ApiSecret.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_ApiSecret.Size = New System.Drawing.Size(320, 20)
        Me.txt_ApiSecret.TabIndex = 5
        '
        'lbl_BaseUrl
        '
        Me.lbl_BaseUrl.AutoSize = True
        Me.lbl_BaseUrl.Location = New System.Drawing.Point(15, 122)
        Me.lbl_BaseUrl.Name = "lbl_BaseUrl"
        Me.lbl_BaseUrl.Size = New System.Drawing.Size(56, 13)
        Me.lbl_BaseUrl.TabIndex = 6
        Me.lbl_BaseUrl.Text = "Base URL:"
        '
        'txt_BaseUrl
        '
        Me.txt_BaseUrl.Location = New System.Drawing.Point(120, 119)
        Me.txt_BaseUrl.Name = "txt_BaseUrl"
        Me.txt_BaseUrl.Size = New System.Drawing.Size(320, 20)
        Me.txt_BaseUrl.TabIndex = 7
        Me.txt_BaseUrl.Text = "https://api.trendyol.com/sapigw"
        '
        'btn_Test
        '
        Me.btn_Test.Location = New System.Drawing.Point(12, 200)
        Me.btn_Test.Name = "btn_Test"
        Me.btn_Test.Size = New System.Drawing.Size(140, 30)
        Me.btn_Test.TabIndex = 1
        Me.btn_Test.Text = "Bağlantıyı Test Et"
        '
        'btn_Kaydet
        '
        Me.btn_Kaydet.Location = New System.Drawing.Point(252, 200)
        Me.btn_Kaydet.Name = "btn_Kaydet"
        Me.btn_Kaydet.Size = New System.Drawing.Size(100, 30)
        Me.btn_Kaydet.TabIndex = 2
        Me.btn_Kaydet.Text = "Kaydet"
        '
        'btn_Iptal
        '
        Me.btn_Iptal.Location = New System.Drawing.Point(372, 200)
        Me.btn_Iptal.Name = "btn_Iptal"
        Me.btn_Iptal.Size = New System.Drawing.Size(100, 30)
        Me.btn_Iptal.TabIndex = 3
        Me.btn_Iptal.Text = "Kapat"
        '
        'lbl_Status
        '
        Me.lbl_Status.AutoSize = True
        Me.lbl_Status.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_Status.Location = New System.Drawing.Point(12, 240)
        Me.lbl_Status.Name = "lbl_Status"
        Me.lbl_Status.Size = New System.Drawing.Size(39, 14)
        Me.lbl_Status.TabIndex = 4
        Me.lbl_Status.Text = "Hazır"
        '
        'grp_Bilgi
        '
        Me.grp_Bilgi.Controls.Add(Me.lbl_Bilgi)
        Me.grp_Bilgi.Location = New System.Drawing.Point(12, 260)
        Me.grp_Bilgi.Name = "grp_Bilgi"
        Me.grp_Bilgi.Size = New System.Drawing.Size(460, 80)
        Me.grp_Bilgi.TabIndex = 5
        Me.grp_Bilgi.TabStop = False
        Me.grp_Bilgi.Text = "Bilgi"
        '
        'lbl_Bilgi
        '
        Me.lbl_Bilgi.ForeColor = System.Drawing.Color.Gray
        Me.lbl_Bilgi.Location = New System.Drawing.Point(15, 25)
        Me.lbl_Bilgi.Name = "lbl_Bilgi"
        Me.lbl_Bilgi.Size = New System.Drawing.Size(430, 40)
        Me.lbl_Bilgi.TabIndex = 0
        Me.lbl_Bilgi.Text = "API bilgilerinizi Trendyol Satıcı Paneli → Entegrasyon → API Bilgileri" & vbCrLf & "sayfasından alabilirsiniz."
        '
        'frm_TrendyolAyar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 351)
        Me.Controls.Add(Me.grp_Bilgi)
        Me.Controls.Add(Me.lbl_Status)
        Me.Controls.Add(Me.btn_Iptal)
        Me.Controls.Add(Me.btn_Kaydet)
        Me.Controls.Add(Me.btn_Test)
        Me.Controls.Add(Me.grp_ApiAyar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_TrendyolAyar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Trendyol API Ayarları"
        Me.grp_ApiAyar.ResumeLayout(False)
        Me.grp_ApiAyar.PerformLayout()
        Me.grp_Bilgi.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents grp_ApiAyar As System.Windows.Forms.GroupBox
    Friend WithEvents txt_BaseUrl As System.Windows.Forms.TextBox
    Friend WithEvents txt_ApiSecret As System.Windows.Forms.TextBox
    Friend WithEvents txt_ApiKey As System.Windows.Forms.TextBox
    Friend WithEvents txt_SupplierId As System.Windows.Forms.TextBox
    Friend WithEvents lbl_BaseUrl As System.Windows.Forms.Label
    Friend WithEvents lbl_ApiSecret As System.Windows.Forms.Label
    Friend WithEvents lbl_ApiKey As System.Windows.Forms.Label
    Friend WithEvents lbl_SupplierId As System.Windows.Forms.Label
    Friend WithEvents btn_Test As System.Windows.Forms.Button
    Friend WithEvents btn_Kaydet As System.Windows.Forms.Button
    Friend WithEvents btn_Iptal As System.Windows.Forms.Button
    Friend WithEvents lbl_Status As System.Windows.Forms.Label
    Friend WithEvents grp_Bilgi As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Bilgi As System.Windows.Forms.Label

End Class
