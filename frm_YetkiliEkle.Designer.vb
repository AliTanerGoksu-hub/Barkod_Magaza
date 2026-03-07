<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_YetkiliEkle
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
        Me.grd_Personel = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.grd_OnayTurleri = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.chk_Asamalar = New System.Windows.Forms.CheckedListBox()
        Me.btn_Ekle = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_Iptal = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_PersonelAra = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        
        CType(Me.grd_Personel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd_OnayTurleri, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_PersonelAra.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.PanelControl2.SuspendLayout()
        Me.PanelControl3.SuspendLayout()
        Me.SuspendLayout()
        
        ' PanelControl1 - Personel Paneli
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Controls.Add(Me.LabelControl4)
        Me.PanelControl1.Controls.Add(Me.txt_PersonelAra)
        Me.PanelControl1.Controls.Add(Me.grd_Personel)
        Me.PanelControl1.Location = New System.Drawing.Point(12, 12)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(350, 280)
        Me.PanelControl1.TabIndex = 0
        
        ' LabelControl1 - Personel Baslik
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(5, 5)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(150, 16)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "1. Personel Seçin:"
        
        ' LabelControl4 - Ara
        Me.LabelControl4.Location = New System.Drawing.Point(5, 28)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(25, 13)
        Me.LabelControl4.TabIndex = 1
        Me.LabelControl4.Text = "Ara:"
        
        ' txt_PersonelAra
        Me.txt_PersonelAra.Location = New System.Drawing.Point(35, 25)
        Me.txt_PersonelAra.Name = "txt_PersonelAra"
        Me.txt_PersonelAra.Properties.NullValuePrompt = "Personel ara..."
        Me.txt_PersonelAra.Size = New System.Drawing.Size(310, 20)
        Me.txt_PersonelAra.TabIndex = 2
        
        ' grd_Personel
        Me.grd_Personel.Location = New System.Drawing.Point(5, 50)
        Me.grd_Personel.MainView = Me.GridView1
        Me.grd_Personel.Name = "grd_Personel"
        Me.grd_Personel.Size = New System.Drawing.Size(340, 225)
        Me.grd_Personel.TabIndex = 3
        Me.grd_Personel.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        
        ' GridView1
        Me.GridView1.GridControl = Me.grd_Personel
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowGroupPanel = False
        
        ' PanelControl2 - Onay Turu Paneli
        Me.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl2.Controls.Add(Me.LabelControl2)
        Me.PanelControl2.Controls.Add(Me.grd_OnayTurleri)
        Me.PanelControl2.Location = New System.Drawing.Point(370, 12)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(300, 280)
        Me.PanelControl2.TabIndex = 1
        
        ' LabelControl2 - Onay Turu Baslik
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(5, 5)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(150, 16)
        Me.LabelControl2.TabIndex = 0
        Me.LabelControl2.Text = "2. Onay Türü Seçin:"
        
        ' grd_OnayTurleri
        Me.grd_OnayTurleri.Location = New System.Drawing.Point(5, 28)
        Me.grd_OnayTurleri.MainView = Me.GridView2
        Me.grd_OnayTurleri.Name = "grd_OnayTurleri"
        Me.grd_OnayTurleri.Size = New System.Drawing.Size(290, 247)
        Me.grd_OnayTurleri.TabIndex = 1
        Me.grd_OnayTurleri.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        
        ' GridView2
        Me.GridView2.GridControl = Me.grd_OnayTurleri
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsView.ShowGroupPanel = False
        
        ' PanelControl3 - Asama Paneli
        Me.PanelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl3.Controls.Add(Me.LabelControl3)
        Me.PanelControl3.Controls.Add(Me.chk_Asamalar)
        Me.PanelControl3.Location = New System.Drawing.Point(12, 300)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(658, 180)
        Me.PanelControl3.TabIndex = 2
        
        ' LabelControl3 - Asama Baslik
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(5, 5)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(300, 16)
        Me.LabelControl3.TabIndex = 0
        Me.LabelControl3.Text = "3. Aşamaları Seçin (Birden fazla seçilebilir):"
        
        ' chk_Asamalar
        Me.chk_Asamalar.CheckOnClick = True
        Me.chk_Asamalar.FormattingEnabled = True
        Me.chk_Asamalar.Location = New System.Drawing.Point(5, 28)
        Me.chk_Asamalar.Name = "chk_Asamalar"
        Me.chk_Asamalar.Size = New System.Drawing.Size(648, 145)
        Me.chk_Asamalar.TabIndex = 1
        
        ' btn_Ekle
        Me.btn_Ekle.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btn_Ekle.Appearance.Options.UseFont = True
        Me.btn_Ekle.Location = New System.Drawing.Point(460, 490)
        Me.btn_Ekle.Name = "btn_Ekle"
        Me.btn_Ekle.Size = New System.Drawing.Size(100, 35)
        Me.btn_Ekle.TabIndex = 3
        Me.btn_Ekle.Text = "Ekle"
        
        ' btn_Iptal
        Me.btn_Iptal.Location = New System.Drawing.Point(570, 490)
        Me.btn_Iptal.Name = "btn_Iptal"
        Me.btn_Iptal.Size = New System.Drawing.Size(100, 35)
        Me.btn_Iptal.TabIndex = 4
        Me.btn_Iptal.Text = "İptal"
        
        ' frm_YetkiliEkle
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 537)
        Me.Controls.Add(Me.btn_Iptal)
        Me.Controls.Add(Me.btn_Ekle)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_YetkiliEkle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Yetkili Ekle"
        
        CType(Me.grd_Personel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd_OnayTurleri, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_PersonelAra.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        Me.PanelControl3.PerformLayout()
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
End Class
