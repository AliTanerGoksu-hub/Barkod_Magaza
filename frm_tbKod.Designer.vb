<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_tbKod
    Inherits DevExpress.XtraEditors.XtraForm
    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub
    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_tbKod))
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.LookUpEdit1 = New DevExpress.XtraEditors.LookUpEdit
        Me.lbl_sKod = New DevExpress.XtraEditors.LabelControl
        Me.Group_Depo = New DevExpress.XtraEditors.GroupControl
        Me.sec_sAktifFiyatTipi = New DevExpress.XtraEditors.CheckEdit
        Me.sec_sSubeMagaza = New DevExpress.XtraEditors.CheckEdit
        Me.sec_sHareketTipi = New DevExpress.XtraEditors.CheckEdit
        CType(Me.LookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Group_Depo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Group_Depo.SuspendLayout()
        CType(Me.sec_sAktifFiyatTipi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sSubeMagaza.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sHareketTipi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(262, 126)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(80, 24)
        Me.SimpleButton2.TabIndex = 2
        Me.SimpleButton2.Text = "&Vazgeç"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(182, 126)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(80, 24)
        Me.SimpleButton1.TabIndex = 1
        Me.SimpleButton1.Text = "&Tamam"
        '
        'LookUpEdit1
        '
        Me.LookUpEdit1.EnterMoveNextControl = True
        Me.LookUpEdit1.Location = New System.Drawing.Point(104, 12)
        Me.LookUpEdit1.Name = "LookUpEdit1"
        Me.LookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEdit1.Properties.DisplayMember = "sKod"
        Me.LookUpEdit1.Properties.NullText = ""
        Me.LookUpEdit1.Properties.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick
        Me.LookUpEdit1.Properties.ValueMember = "sKod"
        Me.LookUpEdit1.Size = New System.Drawing.Size(244, 20)
        Me.LookUpEdit1.TabIndex = 0
        '
        'lbl_sKod
        '
        Me.lbl_sKod.Location = New System.Drawing.Point(12, 15)
        Me.lbl_sKod.Name = "lbl_sKod"
        Me.lbl_sKod.Size = New System.Drawing.Size(22, 13)
        Me.lbl_sKod.TabIndex = 3
        Me.lbl_sKod.Text = "Kod:"
        '
        'Group_Depo
        '
        Me.Group_Depo.Controls.Add(Me.sec_sAktifFiyatTipi)
        Me.Group_Depo.Controls.Add(Me.sec_sSubeMagaza)
        Me.Group_Depo.Controls.Add(Me.sec_sHareketTipi)
        Me.Group_Depo.Location = New System.Drawing.Point(104, 38)
        Me.Group_Depo.Name = "Group_Depo"
        Me.Group_Depo.Size = New System.Drawing.Size(244, 82)
        Me.Group_Depo.TabIndex = 4
        Me.Group_Depo.Text = "Diger"
        '
        'sec_sAktifFiyatTipi
        '
        Me.sec_sAktifFiyatTipi.EditValue = True
        Me.sec_sAktifFiyatTipi.Location = New System.Drawing.Point(144, 28)
        Me.sec_sAktifFiyatTipi.Name = "sec_sAktifFiyatTipi"
        Me.sec_sAktifFiyatTipi.Properties.Caption = "Aktif FiyatTipi"
        Me.sec_sAktifFiyatTipi.Size = New System.Drawing.Size(93, 19)
        Me.sec_sAktifFiyatTipi.TabIndex = 2
        '
        'sec_sSubeMagaza
        '
        Me.sec_sSubeMagaza.EditValue = True
        Me.sec_sSubeMagaza.Location = New System.Drawing.Point(9, 53)
        Me.sec_sSubeMagaza.Name = "sec_sSubeMagaza"
        Me.sec_sSubeMagaza.Properties.Caption = "SubeMagaza"
        Me.sec_sSubeMagaza.Size = New System.Drawing.Size(111, 19)
        Me.sec_sSubeMagaza.TabIndex = 1
        '
        'sec_sHareketTipi
        '
        Me.sec_sHareketTipi.EditValue = True
        Me.sec_sHareketTipi.Location = New System.Drawing.Point(9, 28)
        Me.sec_sHareketTipi.Name = "sec_sHareketTipi"
        Me.sec_sHareketTipi.Properties.Caption = "HareketTipi"
        Me.sec_sHareketTipi.Size = New System.Drawing.Size(111, 19)
        Me.sec_sHareketTipi.TabIndex = 0
        '
        'frm_tbKod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(354, 162)
        Me.Controls.Add(Me.Group_Depo)
        Me.Controls.Add(Me.lbl_sKod)
        Me.Controls.Add(Me.LookUpEdit1)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_tbKod"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Kod Sec"
        CType(Me.LookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Group_Depo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Group_Depo.ResumeLayout(False)
        CType(Me.sec_sAktifFiyatTipi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sSubeMagaza.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sHareketTipi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LookUpEdit1 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lbl_sKod As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Group_Depo As DevExpress.XtraEditors.GroupControl
    Friend WithEvents sec_sAktifFiyatTipi As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents sec_sSubeMagaza As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents sec_sHareketTipi As DevExpress.XtraEditors.CheckEdit
End Class
