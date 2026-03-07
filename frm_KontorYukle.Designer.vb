Partial Class frm_KontorYukle
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
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

    'Windows Form Tasarımcısı tarafından gerektirilir
    Private components As System.ComponentModel.IContainer

    'NOT: Aşağıdaki yordam Windows Form Tasarımcısı için gereklidir
    'Windows Form Tasarımcısı kullanılarak değiştirilebilir.  
    'Kod düzenleyicisini kullanarak değiştirmeyin.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblTelefon = New System.Windows.Forms.Label()
        Me.txtTelefon = New System.Windows.Forms.TextBox()
        Me.lblMiktar = New System.Windows.Forms.Label()
        Me.txtMiktar = New System.Windows.Forms.TextBox()
        Me.btnYukle = New System.Windows.Forms.Button()
        Me.lblBakiye = New System.Windows.Forms.Label()
        Me.btnSorgula = New System.Windows.Forms.Button()
        Me.lblVKN = New System.Windows.Forms.Label()
        Me.txtVKN = New System.Windows.Forms.TextBox()
        Me.lblUnvan = New System.Windows.Forms.Label()
        Me.txtUnvan = New System.Windows.Forms.TextBox()
        Me.lblOdemeTuru = New System.Windows.Forms.Label()
        Me.cmbOdemeTuru = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'lblTelefon
        '
        Me.lblTelefon.AutoSize = True
        Me.lblTelefon.Location = New System.Drawing.Point(102, 180)
        Me.lblTelefon.Name = "lblTelefon"
        Me.lblTelefon.Size = New System.Drawing.Size(133, 20)
        Me.lblTelefon.TabIndex = 0
        Me.lblTelefon.Text = "Telefon Numarası"
        '
        'txtTelefon
        '
        Me.txtTelefon.Location = New System.Drawing.Point(241, 180)
        Me.txtTelefon.Name = "txtTelefon"
        Me.txtTelefon.Size = New System.Drawing.Size(190, 26)
        Me.txtTelefon.TabIndex = 1
        '
        'lblMiktar
        '
        Me.lblMiktar.AutoSize = True
        Me.lblMiktar.Location = New System.Drawing.Point(106, 227)
        Me.lblMiktar.Name = "lblMiktar"
        Me.lblMiktar.Size = New System.Drawing.Size(103, 20)
        Me.lblMiktar.TabIndex = 2
        Me.lblMiktar.Text = "Kontör Miktar"
        '
        'txtMiktar
        '
        Me.txtMiktar.Location = New System.Drawing.Point(241, 227)
        Me.txtMiktar.Name = "txtMiktar"
        Me.txtMiktar.Size = New System.Drawing.Size(190, 26)
        Me.txtMiktar.TabIndex = 3
        '
        'btnYukle
        '
        Me.btnYukle.Location = New System.Drawing.Point(296, 346)
        Me.btnYukle.Name = "btnYukle"
        Me.btnYukle.Size = New System.Drawing.Size(154, 47)
        Me.btnYukle.TabIndex = 4
        Me.btnYukle.Text = "Yükle"
        Me.btnYukle.UseVisualStyleBackColor = True
        '
        'lblBakiye
        '
        Me.lblBakiye.AutoSize = True
        Me.lblBakiye.Location = New System.Drawing.Point(601, 186)
        Me.lblBakiye.Name = "lblBakiye"
        Me.lblBakiye.Size = New System.Drawing.Size(56, 20)
        Me.lblBakiye.TabIndex = 5
        Me.lblBakiye.Text = "Bakiye"
        '
        'btnSorgula
        '
        Me.btnSorgula.Location = New System.Drawing.Point(548, 346)
        Me.btnSorgula.Name = "btnSorgula"
        Me.btnSorgula.Size = New System.Drawing.Size(145, 47)
        Me.btnSorgula.TabIndex = 6
        Me.btnSorgula.Text = "Sorgula"
        Me.btnSorgula.UseVisualStyleBackColor = True
        '
        'lblVKN
        '
        Me.lblVKN.AutoSize = True
        Me.lblVKN.Location = New System.Drawing.Point(106, 133)
        Me.lblVKN.Name = "lblVKN"
        Me.lblVKN.Size = New System.Drawing.Size(76, 20)
        Me.lblVKN.TabIndex = 7
        Me.lblVKN.Text = "Kullanıcı VKN"
        '
        'txtVKN
        '
        Me.txtVKN.Location = New System.Drawing.Point(241, 133)
        Me.txtVKN.Name = "txtVKN"
        Me.txtVKN.Size = New System.Drawing.Size(190, 26)
        Me.txtVKN.TabIndex = 8
        '
        'lblUnvan
        '
        Me.lblUnvan.AutoSize = True
        Me.lblUnvan.Location = New System.Drawing.Point(106, 86)
        Me.lblUnvan.Name = "lblUnvan"
        Me.lblUnvan.Size = New System.Drawing.Size(50, 20)
        Me.lblUnvan.TabIndex = 9
        Me.lblUnvan.Text = "Ünvan"
        '
        'txtUnvan
        '
        Me.txtUnvan.Location = New System.Drawing.Point(241, 86)
        Me.txtUnvan.Name = "txtUnvan"
        Me.txtUnvan.Size = New System.Drawing.Size(190, 26)
        Me.txtUnvan.TabIndex = 10
        '
        'lblOdemeTuru
        '
        Me.lblOdemeTuru.AutoSize = True
        Me.lblOdemeTuru.Location = New System.Drawing.Point(106, 274)
        Me.lblOdemeTuru.Name = "lblOdemeTuru"
        Me.lblOdemeTuru.Size = New System.Drawing.Size(84, 20)
        Me.lblOdemeTuru.TabIndex = 11
        Me.lblOdemeTuru.Text = "Ödeme Tipi"
        '
        'cmbOdemeTuru
        '
        Me.cmbOdemeTuru.FormattingEnabled = True
        Me.cmbOdemeTuru.Location = New System.Drawing.Point(241, 274)
        Me.cmbOdemeTuru.Name = "cmbOdemeTuru"
        Me.cmbOdemeTuru.Size = New System.Drawing.Size(190, 28)
        Me.cmbOdemeTuru.TabIndex = 12
        '
        'frm_KontorYukle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.cmbOdemeTuru)
        Me.Controls.Add(Me.lblOdemeTuru)
        Me.Controls.Add(Me.txtUnvan)
        Me.Controls.Add(Me.lblUnvan)
        Me.Controls.Add(Me.txtVKN)
        Me.Controls.Add(Me.lblVKN)
        Me.Controls.Add(Me.btnSorgula)
        Me.Controls.Add(Me.lblBakiye)
        Me.Controls.Add(Me.btnYukle)
        Me.Controls.Add(Me.txtMiktar)
        Me.Controls.Add(Me.lblMiktar)
        Me.Controls.Add(Me.txtTelefon)
        Me.Controls.Add(Me.lblTelefon)
        Me.Name = "frm_KontorYukle"
        Me.Text = "frm_KontorYukle"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTelefon As Label
    Friend WithEvents txtTelefon As TextBox
    Friend WithEvents lblMiktar As Label
    Friend WithEvents txtMiktar As TextBox
    Friend WithEvents btnYukle As Button
    Friend WithEvents lblBakiye As Label
    Friend WithEvents btnSorgula As Button
    Friend WithEvents lblVKN As Label
    Friend WithEvents txtVKN As TextBox
    Friend WithEvents lblUnvan As Label
    Friend WithEvents txtUnvan As TextBox
    Friend WithEvents lblOdemeTuru As Label
    Friend WithEvents cmbOdemeTuru As ComboBox
End Class