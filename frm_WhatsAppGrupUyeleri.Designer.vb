<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_WhatsAppGrupUyeleri
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
        Me.grd_Personeller = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.grd_GrupUyeleri = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.btn_Ekle = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_Cikar = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_TumunuEkle = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_TumunuCikar = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_Kapat = New DevExpress.XtraEditors.SimpleButton()
        Me.lbl_GrupAdi = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_UyeSayisi = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        
        CType(Me.grd_Personeller, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd_GrupUyeleri, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        
        ' lbl_GrupAdi
        Me.lbl_GrupAdi.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_GrupAdi.Location = New System.Drawing.Point(12, 12)
        Me.lbl_GrupAdi.Name = "lbl_GrupAdi"
        Me.lbl_GrupAdi.Size = New System.Drawing.Size(200, 19)
        Me.lbl_GrupAdi.Text = "Grup: "
        
        ' LabelControl1 - Personeller baslik
        Me.LabelControl1.Location = New System.Drawing.Point(12, 45)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(150, 13)
        Me.LabelControl1.Text = "Mevcut Personeller:"
        
        ' grd_Personeller
        Me.grd_Personeller.Location = New System.Drawing.Point(12, 65)
        Me.grd_Personeller.MainView = Me.GridView1
        Me.grd_Personeller.Name = "grd_Personeller"
        Me.grd_Personeller.Size = New System.Drawing.Size(350, 350)
        Me.grd_Personeller.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        
        ' GridView1
        Me.GridView1.GridControl = Me.grd_Personeller
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        
        ' Butonlar (ortada)
        ' btn_Ekle
        Me.btn_Ekle.Location = New System.Drawing.Point(375, 150)
        Me.btn_Ekle.Name = "btn_Ekle"
        Me.btn_Ekle.Size = New System.Drawing.Size(80, 30)
        Me.btn_Ekle.Text = "Ekle >>"
        
        ' btn_Cikar
        Me.btn_Cikar.Location = New System.Drawing.Point(375, 190)
        Me.btn_Cikar.Name = "btn_Cikar"
        Me.btn_Cikar.Size = New System.Drawing.Size(80, 30)
        Me.btn_Cikar.Text = "<< Cikar"
        
        ' btn_TumunuEkle
        Me.btn_TumunuEkle.Location = New System.Drawing.Point(375, 240)
        Me.btn_TumunuEkle.Name = "btn_TumunuEkle"
        Me.btn_TumunuEkle.Size = New System.Drawing.Size(80, 30)
        Me.btn_TumunuEkle.Text = "Tumu >>"
        
        ' btn_TumunuCikar
        Me.btn_TumunuCikar.Location = New System.Drawing.Point(375, 280)
        Me.btn_TumunuCikar.Name = "btn_TumunuCikar"
        Me.btn_TumunuCikar.Size = New System.Drawing.Size(80, 30)
        Me.btn_TumunuCikar.Text = "<< Tumu"
        
        ' LabelControl2 - Grup Uyeleri baslik
        Me.LabelControl2.Location = New System.Drawing.Point(470, 45)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(150, 13)
        Me.LabelControl2.Text = "Grup Uyeleri:"
        
        ' grd_GrupUyeleri
        Me.grd_GrupUyeleri.Location = New System.Drawing.Point(470, 65)
        Me.grd_GrupUyeleri.MainView = Me.GridView2
        Me.grd_GrupUyeleri.Name = "grd_GrupUyeleri"
        Me.grd_GrupUyeleri.Size = New System.Drawing.Size(350, 350)
        Me.grd_GrupUyeleri.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        
        ' GridView2
        Me.GridView2.GridControl = Me.grd_GrupUyeleri
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.Editable = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        
        ' lbl_UyeSayisi
        Me.lbl_UyeSayisi.Location = New System.Drawing.Point(470, 420)
        Me.lbl_UyeSayisi.Name = "lbl_UyeSayisi"
        Me.lbl_UyeSayisi.Size = New System.Drawing.Size(100, 13)
        Me.lbl_UyeSayisi.Text = "Uye Sayisi: 0"
        
        ' btn_Kapat
        Me.btn_Kapat.Location = New System.Drawing.Point(720, 440)
        Me.btn_Kapat.Name = "btn_Kapat"
        Me.btn_Kapat.Size = New System.Drawing.Size(100, 30)
        Me.btn_Kapat.Text = "Kapat"
        
        ' frm_WhatsAppGrupUyeleri
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(834, 481)
        Me.Controls.Add(Me.lbl_GrupAdi)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.grd_Personeller)
        Me.Controls.Add(Me.btn_Ekle)
        Me.Controls.Add(Me.btn_Cikar)
        Me.Controls.Add(Me.btn_TumunuEkle)
        Me.Controls.Add(Me.btn_TumunuCikar)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.grd_GrupUyeleri)
        Me.Controls.Add(Me.lbl_UyeSayisi)
        Me.Controls.Add(Me.btn_Kapat)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_WhatsAppGrupUyeleri"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Grup Uyeleri Yonetimi"
        
        CType(Me.grd_Personeller, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd_GrupUyeleri, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
End Class
