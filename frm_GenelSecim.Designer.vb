<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_GenelSecim
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
        Me.grd_Kayitlar = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txt_Ara = New DevExpress.XtraEditors.TextEdit()
        Me.btn_Sec = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_YeniEkle = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_Iptal = New DevExpress.XtraEditors.SimpleButton()
        Me.lbl_Baslik = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_KayitSayisi = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_Ara = New DevExpress.XtraEditors.LabelControl()
        Me.grp_YeniKayit = New DevExpress.XtraEditors.GroupControl()
        Me.txt_YeniKod = New DevExpress.XtraEditors.TextEdit()
        Me.txt_YeniAd = New DevExpress.XtraEditors.TextEdit()
        Me.btn_Kaydet = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_KayitIptal = New DevExpress.XtraEditors.SimpleButton()
        Me.lbl_Kod = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_Ad = New DevExpress.XtraEditors.LabelControl()
        
        CType(Me.grd_Kayitlar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Ara.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grp_YeniKayit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_YeniKayit.SuspendLayout()
        CType(Me.txt_YeniKod.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_YeniAd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        
        ' lbl_Baslik
        Me.lbl_Baslik.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_Baslik.Appearance.Options.UseFont = True
        Me.lbl_Baslik.Location = New System.Drawing.Point(12, 12)
        Me.lbl_Baslik.Name = "lbl_Baslik"
        Me.lbl_Baslik.Size = New System.Drawing.Size(100, 19)
        Me.lbl_Baslik.TabIndex = 0
        Me.lbl_Baslik.Text = "Kayıt Seç"
        
        ' lbl_Ara
        Me.lbl_Ara.Location = New System.Drawing.Point(12, 45)
        Me.lbl_Ara.Name = "lbl_Ara"
        Me.lbl_Ara.Size = New System.Drawing.Size(20, 13)
        Me.lbl_Ara.Text = "Ara:"
        
        ' txt_Ara
        Me.txt_Ara.Location = New System.Drawing.Point(40, 42)
        Me.txt_Ara.Name = "txt_Ara"
        Me.txt_Ara.Properties.NullValuePrompt = "Kod veya ad ile ara..."
        Me.txt_Ara.Size = New System.Drawing.Size(300, 20)
        Me.txt_Ara.TabIndex = 1
        
        ' lbl_KayitSayisi
        Me.lbl_KayitSayisi.Location = New System.Drawing.Point(360, 45)
        Me.lbl_KayitSayisi.Name = "lbl_KayitSayisi"
        Me.lbl_KayitSayisi.Size = New System.Drawing.Size(80, 13)
        Me.lbl_KayitSayisi.Text = "Toplam: 0 kayıt"
        
        ' grd_Kayitlar
        Me.grd_Kayitlar.Location = New System.Drawing.Point(12, 70)
        Me.grd_Kayitlar.MainView = Me.GridView1
        Me.grd_Kayitlar.Name = "grd_Kayitlar"
        Me.grd_Kayitlar.Size = New System.Drawing.Size(460, 280)
        Me.grd_Kayitlar.TabIndex = 2
        Me.grd_Kayitlar.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        
        ' GridView1
        Me.GridView1.GridControl = Me.grd_Kayitlar
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowGroupPanel = False
        
        ' grp_YeniKayit
        Me.grp_YeniKayit.Controls.Add(Me.lbl_Kod)
        Me.grp_YeniKayit.Controls.Add(Me.txt_YeniKod)
        Me.grp_YeniKayit.Controls.Add(Me.lbl_Ad)
        Me.grp_YeniKayit.Controls.Add(Me.txt_YeniAd)
        Me.grp_YeniKayit.Controls.Add(Me.btn_Kaydet)
        Me.grp_YeniKayit.Controls.Add(Me.btn_KayitIptal)
        Me.grp_YeniKayit.Location = New System.Drawing.Point(12, 360)
        Me.grp_YeniKayit.Name = "grp_YeniKayit"
        Me.grp_YeniKayit.Size = New System.Drawing.Size(460, 100)
        Me.grp_YeniKayit.TabIndex = 3
        Me.grp_YeniKayit.Text = "Yeni Kayıt Ekle"
        Me.grp_YeniKayit.Visible = False
        
        ' lbl_Kod
        Me.lbl_Kod.Location = New System.Drawing.Point(15, 35)
        Me.lbl_Kod.Name = "lbl_Kod"
        Me.lbl_Kod.Size = New System.Drawing.Size(25, 13)
        Me.lbl_Kod.Text = "Kod:"
        
        ' txt_YeniKod
        Me.txt_YeniKod.Location = New System.Drawing.Point(50, 32)
        Me.txt_YeniKod.Name = "txt_YeniKod"
        Me.txt_YeniKod.Size = New System.Drawing.Size(150, 20)
        
        ' lbl_Ad
        Me.lbl_Ad.Location = New System.Drawing.Point(15, 65)
        Me.lbl_Ad.Name = "lbl_Ad"
        Me.lbl_Ad.Size = New System.Drawing.Size(15, 13)
        Me.lbl_Ad.Text = "Ad:"
        
        ' txt_YeniAd
        Me.txt_YeniAd.Location = New System.Drawing.Point(50, 62)
        Me.txt_YeniAd.Name = "txt_YeniAd"
        Me.txt_YeniAd.Size = New System.Drawing.Size(250, 20)
        
        ' btn_Kaydet
        Me.btn_Kaydet.Location = New System.Drawing.Point(320, 30)
        Me.btn_Kaydet.Name = "btn_Kaydet"
        Me.btn_Kaydet.Size = New System.Drawing.Size(70, 25)
        Me.btn_Kaydet.TabIndex = 4
        Me.btn_Kaydet.Text = "Kaydet"
        
        ' btn_KayitIptal
        Me.btn_KayitIptal.Location = New System.Drawing.Point(320, 60)
        Me.btn_KayitIptal.Name = "btn_KayitIptal"
        Me.btn_KayitIptal.Size = New System.Drawing.Size(70, 25)
        Me.btn_KayitIptal.TabIndex = 5
        Me.btn_KayitIptal.Text = "İptal"
        
        ' btn_Sec
        Me.btn_Sec.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btn_Sec.Appearance.Options.UseFont = True
        Me.btn_Sec.Location = New System.Drawing.Point(192, 470)
        Me.btn_Sec.Name = "btn_Sec"
        Me.btn_Sec.Size = New System.Drawing.Size(90, 35)
        Me.btn_Sec.TabIndex = 4
        Me.btn_Sec.Text = "Seç"
        
        ' btn_YeniEkle
        Me.btn_YeniEkle.Location = New System.Drawing.Point(288, 470)
        Me.btn_YeniEkle.Name = "btn_YeniEkle"
        Me.btn_YeniEkle.Size = New System.Drawing.Size(90, 35)
        Me.btn_YeniEkle.TabIndex = 5
        Me.btn_YeniEkle.Text = "Yeni Ekle"
        
        ' btn_Iptal
        Me.btn_Iptal.Location = New System.Drawing.Point(384, 470)
        Me.btn_Iptal.Name = "btn_Iptal"
        Me.btn_Iptal.Size = New System.Drawing.Size(90, 35)
        Me.btn_Iptal.TabIndex = 6
        Me.btn_Iptal.Text = "İptal"
        
        ' frm_GenelSecim
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 517)
        Me.Controls.Add(Me.btn_Iptal)
        Me.Controls.Add(Me.btn_YeniEkle)
        Me.Controls.Add(Me.btn_Sec)
        Me.Controls.Add(Me.grp_YeniKayit)
        Me.Controls.Add(Me.grd_Kayitlar)
        Me.Controls.Add(Me.lbl_KayitSayisi)
        Me.Controls.Add(Me.txt_Ara)
        Me.Controls.Add(Me.lbl_Ara)
        Me.Controls.Add(Me.lbl_Baslik)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_GenelSecim"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Kayıt Seç"
        
        CType(Me.grd_Kayitlar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Ara.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grp_YeniKayit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_YeniKayit.ResumeLayout(False)
        Me.grp_YeniKayit.PerformLayout()
        CType(Me.txt_YeniKod.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_YeniAd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents lbl_Ara As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_Kod As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_Ad As DevExpress.XtraEditors.LabelControl
End Class
