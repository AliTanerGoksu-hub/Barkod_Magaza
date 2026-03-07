<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_KolaysoftTest
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.btnPosListesi = New System.Windows.Forms.Button()
        Me.btnFaturaTest = New System.Windows.Forms.Button()
        Me.btnPrintTest = New System.Windows.Forms.Button()
        Me.lblDurum = New System.Windows.Forms.Label()
        Me.lblToken = New System.Windows.Forms.Label()
        Me.lblFirma = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtSonuc = New System.Windows.Forms.TextBox()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtDeviceId = New System.Windows.Forms.TextBox()
        Me.btnPosDurum = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(225, 154)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(150, 46)
        Me.btnLogin.TabIndex = 4
        Me.btnLogin.Text = "Giriþ Yap"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'btnPosListesi
        '
        Me.btnPosListesi.Location = New System.Drawing.Point(225, 215)
        Me.btnPosListesi.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnPosListesi.Name = "btnPosListesi"
        Me.btnPosListesi.Size = New System.Drawing.Size(150, 46)
        Me.btnPosListesi.TabIndex = 5
        Me.btnPosListesi.Text = "POS Listesi"
        Me.btnPosListesi.UseVisualStyleBackColor = True
        '
        'btnFaturaTest
        '
        Me.btnFaturaTest.Location = New System.Drawing.Point(225, 277)
        Me.btnFaturaTest.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnFaturaTest.Name = "btnFaturaTest"
        Me.btnFaturaTest.Size = New System.Drawing.Size(150, 46)
        Me.btnFaturaTest.TabIndex = 6
        Me.btnFaturaTest.Text = "Fatura Test"
        Me.btnFaturaTest.UseVisualStyleBackColor = True
        '
        'btnPrintTest
        '
        Me.btnPrintTest.Location = New System.Drawing.Point(225, 338)
        Me.btnPrintTest.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnPrintTest.Name = "btnPrintTest"
        Me.btnPrintTest.Size = New System.Drawing.Size(150, 46)
        Me.btnPrintTest.TabIndex = 7
        Me.btnPrintTest.Text = "Yazdýrma Testi"
        Me.btnPrintTest.UseVisualStyleBackColor = True
        '
        'lblDurum
        '
        Me.lblDurum.Location = New System.Drawing.Point(75, 400)
        Me.lblDurum.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDurum.Name = "lblDurum"
        Me.lblDurum.Size = New System.Drawing.Size(300, 31)
        Me.lblDurum.TabIndex = 8
        Me.lblDurum.Text = "Durum: Bekleniyor"
        '
        'lblToken
        '
        Me.lblToken.Location = New System.Drawing.Point(75, 431)
        Me.lblToken.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblToken.Name = "lblToken"
        Me.lblToken.Size = New System.Drawing.Size(887, 56)
        Me.lblToken.TabIndex = 9
        Me.lblToken.Text = "Token: -"
        '
        'lblFirma
        '
        Me.lblFirma.Location = New System.Drawing.Point(75, 487)
        Me.lblFirma.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFirma.Name = "lblFirma"
        Me.lblFirma.Size = New System.Drawing.Size(300, 31)
        Me.lblFirma.TabIndex = 10
        Me.lblFirma.Text = "Firma ID: -"
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(225, 31)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(298, 26)
        Me.txtUsername.TabIndex = 1
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(225, 92)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(298, 26)
        Me.txtPassword.TabIndex = 2
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'txtSonuc
        '
        Me.txtSonuc.Location = New System.Drawing.Point(75, 523)
        Me.txtSonuc.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSonuc.Multiline = True
        Me.txtSonuc.Name = "txtSonuc"
        Me.txtSonuc.Size = New System.Drawing.Size(823, 152)
        Me.txtSonuc.TabIndex = 11
        '
        'lblUsername
        '
        Me.lblUsername.Location = New System.Drawing.Point(75, 31)
        Me.lblUsername.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(150, 31)
        Me.lblUsername.TabIndex = 0
        Me.lblUsername.Text = "Kullanýcý Adý:"
        '
        'lblPassword
        '
        Me.lblPassword.Location = New System.Drawing.Point(75, 92)
        Me.lblPassword.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(150, 31)
        Me.lblPassword.TabIndex = 12
        Me.lblPassword.Text = "Þifre:"
        '
        'txtDeviceId
        '
        Me.txtDeviceId.Location = New System.Drawing.Point(414, 338)
        Me.txtDeviceId.Name = "txtDeviceId"
        Me.txtDeviceId.Size = New System.Drawing.Size(434, 26)
        Me.txtDeviceId.TabIndex = 13
        '
        'btnPosDurum
        '
        Me.btnPosDurum.Location = New System.Drawing.Point(638, 38)
        Me.btnPosDurum.Name = "btnPosDurum"
        Me.btnPosDurum.Size = New System.Drawing.Size(125, 47)
        Me.btnPosDurum.TabIndex = 14
        Me.btnPosDurum.Text = "Kontrol"
        Me.btnPosDurum.UseVisualStyleBackColor = True
        '
        'frm_KolaysoftTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(975, 800)
        Me.Controls.Add(Me.btnPosDurum)
        Me.Controls.Add(Me.txtDeviceId)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.lblDurum)
        Me.Controls.Add(Me.lblToken)
        Me.Controls.Add(Me.lblFirma)
        Me.Controls.Add(Me.btnPosListesi)
        Me.Controls.Add(Me.btnFaturaTest)
        Me.Controls.Add(Me.txtSonuc)
        Me.Controls.Add(Me.btnPrintTest)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frm_KolaysoftTest"
        Me.Text = "Kolaysoft Test Formu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents btnPosListesi As System.Windows.Forms.Button
    Friend WithEvents btnFaturaTest As System.Windows.Forms.Button
    Friend WithEvents btnPrintTest As System.Windows.Forms.Button
    Friend WithEvents lblDurum As System.Windows.Forms.Label
    Friend WithEvents lblToken As System.Windows.Forms.Label
    Friend WithEvents lblFirma As System.Windows.Forms.Label
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtSonuc As System.Windows.Forms.TextBox
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents txtDeviceId As TextBox
    Friend WithEvents btnPosDurum As Button
End Class