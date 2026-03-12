<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_UretimAyarlar
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btn_AsamaSil = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_AsamaEkle = New DevExpress.XtraEditors.SimpleButton()
        Me.grd_Asamalar = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btn_YetkiliSil = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_YetkiliEkle = New DevExpress.XtraEditors.SimpleButton()
        Me.grd_Yetkililer = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.btn_TalepReddet = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_TalepOnayla = New DevExpress.XtraEditors.SimpleButton()
        Me.grd_SatinAlma = New DevExpress.XtraGrid.GridControl()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.TabPageBildirim = New System.Windows.Forms.TabPage()
        Me.LabelBildirimAsama = New DevExpress.XtraEditors.LabelControl()
        Me.cmb_BildirimAsama = New DevExpress.XtraEditors.LookUpEdit()
        Me.btn_BildirimKaydet = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_BildirimSil = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_BildirimEkle = New DevExpress.XtraEditors.SimpleButton()
        Me.grd_UretimBildirim = New DevExpress.XtraGrid.GridControl()
        Me.GridViewBildirim = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.TabPage9 = New System.Windows.Forms.TabPage()
        Me.btn_UretimYeriSil = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_UretimYeriDuzenle = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_UretimYeriEkle = New DevExpress.XtraEditors.SimpleButton()
        Me.grd_UretimYerleri = New DevExpress.XtraGrid.GridControl()
        Me.GridView7 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.TabPage10 = New System.Windows.Forms.TabPage()
        Me.btn_UretimAraciSil = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_UretimAraciDuzenle = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_UretimAraciEkle = New DevExpress.XtraEditors.SimpleButton()
        Me.grd_UretimAraclari = New DevExpress.XtraGrid.GridControl()
        Me.GridView8 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.TabPage11 = New System.Windows.Forms.TabPage()
        Me.btn_VardiyaSil = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_VardiyaDuzenle = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_VardiyaEkle = New DevExpress.XtraEditors.SimpleButton()
        Me.grd_Vardiyalar = New DevExpress.XtraGrid.GridControl()
        Me.GridView9 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.TabPage12 = New System.Windows.Forms.TabPage()
        Me.btn_KaliteSil = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_KaliteDuzenle = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_KaliteEkle = New DevExpress.XtraEditors.SimpleButton()
        Me.grd_KaliteGruplari = New DevExpress.XtraGrid.GridControl()
        Me.GridView10 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.grd_Asamalar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.grd_Yetkililer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.grd_SatinAlma, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageBildirim.SuspendLayout()
        CType(Me.cmb_BildirimAsama.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd_UretimBildirim, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewBildirim, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage9.SuspendLayout()
        CType(Me.grd_UretimYerleri, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage10.SuspendLayout()
        CType(Me.grd_UretimAraclari, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage11.SuspendLayout()
        CType(Me.grd_Vardiyalar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage12.SuspendLayout()
        CType(Me.grd_KaliteGruplari, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPageBildirim)
        Me.TabControl1.Controls.Add(Me.TabPage9)
        Me.TabControl1.Controls.Add(Me.TabPage10)
        Me.TabControl1.Controls.Add(Me.TabPage11)
        Me.TabControl1.Controls.Add(Me.TabPage12)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1650, 1000)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btn_AsamaSil)
        Me.TabPage1.Controls.Add(Me.btn_AsamaEkle)
        Me.TabPage1.Controls.Add(Me.grd_Asamalar)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(1642, 967)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Üretim Aşamaları"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btn_AsamaSil
        '
        Me.btn_AsamaSil.Location = New System.Drawing.Point(180, 895)
        Me.btn_AsamaSil.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_AsamaSil.Name = "btn_AsamaSil"
        Me.btn_AsamaSil.Size = New System.Drawing.Size(150, 46)
        Me.btn_AsamaSil.TabIndex = 0
        Me.btn_AsamaSil.Text = "Aşama Sil"
        '
        'btn_AsamaEkle
        '
        Me.btn_AsamaEkle.Location = New System.Drawing.Point(15, 895)
        Me.btn_AsamaEkle.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_AsamaEkle.Name = "btn_AsamaEkle"
        Me.btn_AsamaEkle.Size = New System.Drawing.Size(150, 46)
        Me.btn_AsamaEkle.TabIndex = 1
        Me.btn_AsamaEkle.Text = "Aşama Ekle"
        '
        'grd_Asamalar
        '
        Me.grd_Asamalar.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grd_Asamalar.Location = New System.Drawing.Point(15, 15)
        Me.grd_Asamalar.MainView = Me.GridView1
        Me.grd_Asamalar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grd_Asamalar.Name = "grd_Asamalar"
        Me.grd_Asamalar.Size = New System.Drawing.Size(1605, 862)
        Me.grd_Asamalar.TabIndex = 2
        Me.grd_Asamalar.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.grd_Asamalar
        Me.GridView1.Name = "GridView1"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btn_YetkiliSil)
        Me.TabPage2.Controls.Add(Me.btn_YetkiliEkle)
        Me.TabPage2.Controls.Add(Me.grd_Yetkililer)
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(1642, 967)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Aşama Yetkililer"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btn_YetkiliSil
        '
        Me.btn_YetkiliSil.Location = New System.Drawing.Point(180, 895)
        Me.btn_YetkiliSil.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_YetkiliSil.Name = "btn_YetkiliSil"
        Me.btn_YetkiliSil.Size = New System.Drawing.Size(150, 46)
        Me.btn_YetkiliSil.TabIndex = 0
        Me.btn_YetkiliSil.Text = "Yetkili Sil"
        '
        'btn_YetkiliEkle
        '
        Me.btn_YetkiliEkle.Location = New System.Drawing.Point(15, 895)
        Me.btn_YetkiliEkle.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_YetkiliEkle.Name = "btn_YetkiliEkle"
        Me.btn_YetkiliEkle.Size = New System.Drawing.Size(150, 46)
        Me.btn_YetkiliEkle.TabIndex = 1
        Me.btn_YetkiliEkle.Text = "Yetkili Ekle"
        '
        'grd_Yetkililer
        '
        Me.grd_Yetkililer.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grd_Yetkililer.Location = New System.Drawing.Point(15, 15)
        Me.grd_Yetkililer.MainView = Me.GridView2
        Me.grd_Yetkililer.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grd_Yetkililer.Name = "grd_Yetkililer"
        Me.grd_Yetkililer.Size = New System.Drawing.Size(1605, 862)
        Me.grd_Yetkililer.TabIndex = 2
        Me.grd_Yetkililer.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.grd_Yetkililer
        Me.GridView2.Name = "GridView2"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.btn_TalepReddet)
        Me.TabPage3.Controls.Add(Me.btn_TalepOnayla)
        Me.TabPage3.Controls.Add(Me.grd_SatinAlma)
        Me.TabPage3.Location = New System.Drawing.Point(4, 29)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(1642, 967)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Satın Alma Talepleri"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'btn_TalepReddet
        '
        Me.btn_TalepReddet.Location = New System.Drawing.Point(180, 895)
        Me.btn_TalepReddet.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_TalepReddet.Name = "btn_TalepReddet"
        Me.btn_TalepReddet.Size = New System.Drawing.Size(150, 46)
        Me.btn_TalepReddet.TabIndex = 0
        Me.btn_TalepReddet.Text = "Reddet"
        '
        'btn_TalepOnayla
        '
        Me.btn_TalepOnayla.Location = New System.Drawing.Point(15, 895)
        Me.btn_TalepOnayla.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_TalepOnayla.Name = "btn_TalepOnayla"
        Me.btn_TalepOnayla.Size = New System.Drawing.Size(150, 46)
        Me.btn_TalepOnayla.TabIndex = 1
        Me.btn_TalepOnayla.Text = "Onayla"
        '
        'grd_SatinAlma
        '
        Me.grd_SatinAlma.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grd_SatinAlma.Location = New System.Drawing.Point(15, 15)
        Me.grd_SatinAlma.MainView = Me.GridView3
        Me.grd_SatinAlma.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grd_SatinAlma.Name = "grd_SatinAlma"
        Me.grd_SatinAlma.Size = New System.Drawing.Size(1605, 862)
        Me.grd_SatinAlma.TabIndex = 2
        Me.grd_SatinAlma.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'GridView3
        '
        Me.GridView3.GridControl = Me.grd_SatinAlma
        Me.GridView3.Name = "GridView3"
        '
        'TabPageBildirim
        '
        Me.TabPageBildirim.Controls.Add(Me.LabelBildirimAsama)
        Me.TabPageBildirim.Controls.Add(Me.cmb_BildirimAsama)
        Me.TabPageBildirim.Controls.Add(Me.btn_BildirimKaydet)
        Me.TabPageBildirim.Controls.Add(Me.btn_BildirimSil)
        Me.TabPageBildirim.Controls.Add(Me.btn_BildirimEkle)
        Me.TabPageBildirim.Controls.Add(Me.grd_UretimBildirim)
        Me.TabPageBildirim.Location = New System.Drawing.Point(4, 29)
        Me.TabPageBildirim.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPageBildirim.Name = "TabPageBildirim"
        Me.TabPageBildirim.Size = New System.Drawing.Size(1642, 967)
        Me.TabPageBildirim.TabIndex = 3
        Me.TabPageBildirim.Text = "Üretim Bildirimleri"
        Me.TabPageBildirim.UseVisualStyleBackColor = True
        '
        'LabelBildirimAsama
        '
        Me.LabelBildirimAsama.Location = New System.Drawing.Point(15, 23)
        Me.LabelBildirimAsama.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LabelBildirimAsama.Name = "LabelBildirimAsama"
        Me.LabelBildirimAsama.Size = New System.Drawing.Size(54, 19)
        Me.LabelBildirimAsama.TabIndex = 0
        Me.LabelBildirimAsama.Text = "Aşama:"
        '
        'cmb_BildirimAsama
        '
        Me.cmb_BildirimAsama.Location = New System.Drawing.Point(90, 18)
        Me.cmb_BildirimAsama.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmb_BildirimAsama.Name = "cmb_BildirimAsama"
        Me.cmb_BildirimAsama.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmb_BildirimAsama.Size = New System.Drawing.Size(450, 26)
        Me.cmb_BildirimAsama.TabIndex = 1
        '
        'btn_BildirimKaydet
        '
        Me.btn_BildirimKaydet.Location = New System.Drawing.Point(345, 895)
        Me.btn_BildirimKaydet.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_BildirimKaydet.Name = "btn_BildirimKaydet"
        Me.btn_BildirimKaydet.Size = New System.Drawing.Size(150, 46)
        Me.btn_BildirimKaydet.TabIndex = 2
        Me.btn_BildirimKaydet.Text = "Kaydet"
        '
        'btn_BildirimSil
        '
        Me.btn_BildirimSil.Location = New System.Drawing.Point(180, 895)
        Me.btn_BildirimSil.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_BildirimSil.Name = "btn_BildirimSil"
        Me.btn_BildirimSil.Size = New System.Drawing.Size(150, 46)
        Me.btn_BildirimSil.TabIndex = 3
        Me.btn_BildirimSil.Text = "Kişi Sil"
        '
        'btn_BildirimEkle
        '
        Me.btn_BildirimEkle.Location = New System.Drawing.Point(15, 895)
        Me.btn_BildirimEkle.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_BildirimEkle.Name = "btn_BildirimEkle"
        Me.btn_BildirimEkle.Size = New System.Drawing.Size(150, 46)
        Me.btn_BildirimEkle.TabIndex = 4
        Me.btn_BildirimEkle.Text = "Kişi Ekle"
        '
        'grd_UretimBildirim
        '
        Me.grd_UretimBildirim.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grd_UretimBildirim.Location = New System.Drawing.Point(15, 69)
        Me.grd_UretimBildirim.MainView = Me.GridViewBildirim
        Me.grd_UretimBildirim.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grd_UretimBildirim.Name = "grd_UretimBildirim"
        Me.grd_UretimBildirim.Size = New System.Drawing.Size(1605, 808)
        Me.grd_UretimBildirim.TabIndex = 5
        Me.grd_UretimBildirim.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewBildirim})
        '
        'GridViewBildirim
        '
        Me.GridViewBildirim.GridControl = Me.grd_UretimBildirim
        Me.GridViewBildirim.Name = "GridViewBildirim"
        '
        'TabPage9
        '
        Me.TabPage9.Controls.Add(Me.btn_UretimYeriSil)
        Me.TabPage9.Controls.Add(Me.btn_UretimYeriDuzenle)
        Me.TabPage9.Controls.Add(Me.btn_UretimYeriEkle)
        Me.TabPage9.Controls.Add(Me.grd_UretimYerleri)
        Me.TabPage9.Location = New System.Drawing.Point(4, 29)
        Me.TabPage9.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage9.Name = "TabPage9"
        Me.TabPage9.Size = New System.Drawing.Size(1642, 967)
        Me.TabPage9.TabIndex = 4
        Me.TabPage9.Text = "Üretim Yerleri"
        Me.TabPage9.UseVisualStyleBackColor = True
        '
        'btn_UretimYeriSil
        '
        Me.btn_UretimYeriSil.Location = New System.Drawing.Point(345, 895)
        Me.btn_UretimYeriSil.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_UretimYeriSil.Name = "btn_UretimYeriSil"
        Me.btn_UretimYeriSil.Size = New System.Drawing.Size(150, 46)
        Me.btn_UretimYeriSil.TabIndex = 0
        Me.btn_UretimYeriSil.Text = "Sil"
        '
        'btn_UretimYeriDuzenle
        '
        Me.btn_UretimYeriDuzenle.Location = New System.Drawing.Point(180, 895)
        Me.btn_UretimYeriDuzenle.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_UretimYeriDuzenle.Name = "btn_UretimYeriDuzenle"
        Me.btn_UretimYeriDuzenle.Size = New System.Drawing.Size(150, 46)
        Me.btn_UretimYeriDuzenle.TabIndex = 1
        Me.btn_UretimYeriDuzenle.Text = "Düzenle"
        '
        'btn_UretimYeriEkle
        '
        Me.btn_UretimYeriEkle.Location = New System.Drawing.Point(15, 895)
        Me.btn_UretimYeriEkle.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_UretimYeriEkle.Name = "btn_UretimYeriEkle"
        Me.btn_UretimYeriEkle.Size = New System.Drawing.Size(150, 46)
        Me.btn_UretimYeriEkle.TabIndex = 2
        Me.btn_UretimYeriEkle.Text = "Ekle"
        '
        'grd_UretimYerleri
        '
        Me.grd_UretimYerleri.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grd_UretimYerleri.Location = New System.Drawing.Point(15, 15)
        Me.grd_UretimYerleri.MainView = Me.GridView7
        Me.grd_UretimYerleri.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grd_UretimYerleri.Name = "grd_UretimYerleri"
        Me.grd_UretimYerleri.Size = New System.Drawing.Size(1605, 862)
        Me.grd_UretimYerleri.TabIndex = 3
        Me.grd_UretimYerleri.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView7})
        '
        'GridView7
        '
        Me.GridView7.GridControl = Me.grd_UretimYerleri
        Me.GridView7.Name = "GridView7"
        '
        'TabPage10
        '
        Me.TabPage10.Controls.Add(Me.btn_UretimAraciSil)
        Me.TabPage10.Controls.Add(Me.btn_UretimAraciDuzenle)
        Me.TabPage10.Controls.Add(Me.btn_UretimAraciEkle)
        Me.TabPage10.Controls.Add(Me.grd_UretimAraclari)
        Me.TabPage10.Location = New System.Drawing.Point(4, 29)
        Me.TabPage10.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage10.Name = "TabPage10"
        Me.TabPage10.Size = New System.Drawing.Size(1642, 967)
        Me.TabPage10.TabIndex = 5
        Me.TabPage10.Text = "Üretim Araçları"
        Me.TabPage10.UseVisualStyleBackColor = True
        '
        'btn_UretimAraciSil
        '
        Me.btn_UretimAraciSil.Location = New System.Drawing.Point(345, 895)
        Me.btn_UretimAraciSil.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_UretimAraciSil.Name = "btn_UretimAraciSil"
        Me.btn_UretimAraciSil.Size = New System.Drawing.Size(150, 46)
        Me.btn_UretimAraciSil.TabIndex = 0
        Me.btn_UretimAraciSil.Text = "Sil"
        '
        'btn_UretimAraciDuzenle
        '
        Me.btn_UretimAraciDuzenle.Location = New System.Drawing.Point(180, 895)
        Me.btn_UretimAraciDuzenle.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_UretimAraciDuzenle.Name = "btn_UretimAraciDuzenle"
        Me.btn_UretimAraciDuzenle.Size = New System.Drawing.Size(150, 46)
        Me.btn_UretimAraciDuzenle.TabIndex = 1
        Me.btn_UretimAraciDuzenle.Text = "Düzenle"
        '
        'btn_UretimAraciEkle
        '
        Me.btn_UretimAraciEkle.Location = New System.Drawing.Point(15, 895)
        Me.btn_UretimAraciEkle.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_UretimAraciEkle.Name = "btn_UretimAraciEkle"
        Me.btn_UretimAraciEkle.Size = New System.Drawing.Size(150, 46)
        Me.btn_UretimAraciEkle.TabIndex = 2
        Me.btn_UretimAraciEkle.Text = "Ekle"
        '
        'grd_UretimAraclari
        '
        Me.grd_UretimAraclari.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grd_UretimAraclari.Location = New System.Drawing.Point(15, 15)
        Me.grd_UretimAraclari.MainView = Me.GridView8
        Me.grd_UretimAraclari.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grd_UretimAraclari.Name = "grd_UretimAraclari"
        Me.grd_UretimAraclari.Size = New System.Drawing.Size(1605, 862)
        Me.grd_UretimAraclari.TabIndex = 3
        Me.grd_UretimAraclari.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView8})
        '
        'GridView8
        '
        Me.GridView8.GridControl = Me.grd_UretimAraclari
        Me.GridView8.Name = "GridView8"
        '
        'TabPage11
        '
        Me.TabPage11.Controls.Add(Me.btn_VardiyaSil)
        Me.TabPage11.Controls.Add(Me.btn_VardiyaDuzenle)
        Me.TabPage11.Controls.Add(Me.btn_VardiyaEkle)
        Me.TabPage11.Controls.Add(Me.grd_Vardiyalar)
        Me.TabPage11.Location = New System.Drawing.Point(4, 29)
        Me.TabPage11.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage11.Name = "TabPage11"
        Me.TabPage11.Size = New System.Drawing.Size(1642, 967)
        Me.TabPage11.TabIndex = 6
        Me.TabPage11.Text = "Vardiyalar"
        Me.TabPage11.UseVisualStyleBackColor = True
        '
        'btn_VardiyaSil
        '
        Me.btn_VardiyaSil.Location = New System.Drawing.Point(345, 895)
        Me.btn_VardiyaSil.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_VardiyaSil.Name = "btn_VardiyaSil"
        Me.btn_VardiyaSil.Size = New System.Drawing.Size(150, 46)
        Me.btn_VardiyaSil.TabIndex = 0
        Me.btn_VardiyaSil.Text = "Sil"
        '
        'btn_VardiyaDuzenle
        '
        Me.btn_VardiyaDuzenle.Location = New System.Drawing.Point(180, 895)
        Me.btn_VardiyaDuzenle.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_VardiyaDuzenle.Name = "btn_VardiyaDuzenle"
        Me.btn_VardiyaDuzenle.Size = New System.Drawing.Size(150, 46)
        Me.btn_VardiyaDuzenle.TabIndex = 1
        Me.btn_VardiyaDuzenle.Text = "Düzenle"
        '
        'btn_VardiyaEkle
        '
        Me.btn_VardiyaEkle.Location = New System.Drawing.Point(15, 895)
        Me.btn_VardiyaEkle.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_VardiyaEkle.Name = "btn_VardiyaEkle"
        Me.btn_VardiyaEkle.Size = New System.Drawing.Size(150, 46)
        Me.btn_VardiyaEkle.TabIndex = 2
        Me.btn_VardiyaEkle.Text = "Ekle"
        '
        'grd_Vardiyalar
        '
        Me.grd_Vardiyalar.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grd_Vardiyalar.Location = New System.Drawing.Point(15, 15)
        Me.grd_Vardiyalar.MainView = Me.GridView9
        Me.grd_Vardiyalar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grd_Vardiyalar.Name = "grd_Vardiyalar"
        Me.grd_Vardiyalar.Size = New System.Drawing.Size(1605, 862)
        Me.grd_Vardiyalar.TabIndex = 3
        Me.grd_Vardiyalar.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView9})
        '
        'GridView9
        '
        Me.GridView9.GridControl = Me.grd_Vardiyalar
        Me.GridView9.Name = "GridView9"
        '
        'TabPage12
        '
        Me.TabPage12.Controls.Add(Me.btn_KaliteSil)
        Me.TabPage12.Controls.Add(Me.btn_KaliteDuzenle)
        Me.TabPage12.Controls.Add(Me.btn_KaliteEkle)
        Me.TabPage12.Controls.Add(Me.grd_KaliteGruplari)
        Me.TabPage12.Location = New System.Drawing.Point(4, 29)
        Me.TabPage12.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage12.Name = "TabPage12"
        Me.TabPage12.Size = New System.Drawing.Size(1642, 967)
        Me.TabPage12.TabIndex = 7
        Me.TabPage12.Text = "Pozisyonlar"
        Me.TabPage12.UseVisualStyleBackColor = True
        '
        'btn_KaliteSil
        '
        Me.btn_KaliteSil.Location = New System.Drawing.Point(345, 895)
        Me.btn_KaliteSil.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_KaliteSil.Name = "btn_KaliteSil"
        Me.btn_KaliteSil.Size = New System.Drawing.Size(150, 46)
        Me.btn_KaliteSil.TabIndex = 0
        Me.btn_KaliteSil.Text = "Sil"
        '
        'btn_KaliteDuzenle
        '
        Me.btn_KaliteDuzenle.Location = New System.Drawing.Point(180, 895)
        Me.btn_KaliteDuzenle.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_KaliteDuzenle.Name = "btn_KaliteDuzenle"
        Me.btn_KaliteDuzenle.Size = New System.Drawing.Size(150, 46)
        Me.btn_KaliteDuzenle.TabIndex = 1
        Me.btn_KaliteDuzenle.Text = "Düzenle"
        '
        'btn_KaliteEkle
        '
        Me.btn_KaliteEkle.Location = New System.Drawing.Point(15, 895)
        Me.btn_KaliteEkle.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_KaliteEkle.Name = "btn_KaliteEkle"
        Me.btn_KaliteEkle.Size = New System.Drawing.Size(150, 46)
        Me.btn_KaliteEkle.TabIndex = 2
        Me.btn_KaliteEkle.Text = "Ekle"
        '
        'grd_KaliteGruplari
        '
        Me.grd_KaliteGruplari.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grd_KaliteGruplari.Location = New System.Drawing.Point(15, 15)
        Me.grd_KaliteGruplari.MainView = Me.GridView10
        Me.grd_KaliteGruplari.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grd_KaliteGruplari.Name = "grd_KaliteGruplari"
        Me.grd_KaliteGruplari.Size = New System.Drawing.Size(1605, 862)
        Me.grd_KaliteGruplari.TabIndex = 3
        Me.grd_KaliteGruplari.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView10})
        '
        'GridView10
        '
        Me.GridView10.GridControl = Me.grd_KaliteGruplari
        Me.GridView10.Name = "GridView10"
        '
        'frm_UretimAyarlar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1650, 1000)
        Me.Controls.Add(Me.TabControl1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frm_UretimAyarlar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Üretim Ayarları"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.grd_Asamalar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.grd_Yetkililer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.grd_SatinAlma, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageBildirim.ResumeLayout(False)
        Me.TabPageBildirim.PerformLayout()
        CType(Me.cmb_BildirimAsama.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd_UretimBildirim, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewBildirim, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage9.ResumeLayout(False)
        CType(Me.grd_UretimYerleri, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage10.ResumeLayout(False)
        CType(Me.grd_UretimAraclari, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage11.ResumeLayout(False)
        CType(Me.grd_Vardiyalar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage12.ResumeLayout(False)
        CType(Me.grd_KaliteGruplari, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPageBildirim As System.Windows.Forms.TabPage
    Friend WithEvents TabPage9 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage10 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage11 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage12 As System.Windows.Forms.TabPage
    Friend WithEvents grd_Asamalar As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents grd_Yetkililer As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents grd_SatinAlma As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents grd_UretimBildirim As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewBildirim As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents grd_UretimYerleri As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView7 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents grd_UretimAraclari As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView8 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents grd_Vardiyalar As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView9 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents grd_KaliteGruplari As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView10 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btn_AsamaEkle As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_AsamaSil As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_YetkiliEkle As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_YetkiliSil As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_TalepOnayla As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_TalepReddet As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_BildirimEkle As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_BildirimSil As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_BildirimKaydet As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmb_BildirimAsama As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelBildirimAsama As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_UretimYeriEkle As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_UretimYeriDuzenle As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_UretimYeriSil As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_UretimAraciEkle As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_UretimAraciDuzenle As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_UretimAraciSil As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_VardiyaEkle As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_VardiyaDuzenle As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_VardiyaSil As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_KaliteEkle As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_KaliteDuzenle As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_KaliteSil As DevExpress.XtraEditors.SimpleButton
End Class
