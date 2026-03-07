<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_BildirimAyarlar
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
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        
        ' Grids
        Me.grd_WhatsAppGruplar = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.grd_BildirimTipleri = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.grd_PersonelBildirim = New DevExpress.XtraGrid.GridControl()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        
        ' UltraMsg WhatsApp Controls
        Me.txt_UltraMsgInstanceID = New DevExpress.XtraEditors.TextEdit()
        Me.txt_UltraMsgToken = New DevExpress.XtraEditors.TextEdit()
        Me.lbl_ApiUrl = New DevExpress.XtraEditors.LabelControl()
        Me.chk_WhatsAppAktif = New DevExpress.XtraEditors.CheckEdit()
        Me.btn_WhatsAppKaydet = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_WhatsAppTest = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_WhatsAppBaglantiTest = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_UltraMsgPanelAc = New DevExpress.XtraEditors.SimpleButton()
        
        ' Grup Controls
        Me.btn_GrupEkle = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_GrupSil = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_UyeleriYonet = New DevExpress.XtraEditors.SimpleButton()
        
        ' Bildirim Tercihleri
        Me.cmb_Kullanici = New DevExpress.XtraEditors.LookUpEdit()
        Me.btn_TercihKaydet = New DevExpress.XtraEditors.SimpleButton()
        
        ' Personel Bildirim
        Me.btn_PersonelKaydet = New DevExpress.XtraEditors.SimpleButton()
        
        ' Email/SMS Controls
        Me.txt_EmailHost = New DevExpress.XtraEditors.TextEdit()
        Me.txt_EmailPort = New DevExpress.XtraEditors.TextEdit()
        Me.txt_EmailUser = New DevExpress.XtraEditors.TextEdit()
        Me.txt_EmailPass = New DevExpress.XtraEditors.TextEdit()
        Me.txt_EmailFrom = New DevExpress.XtraEditors.TextEdit()
        Me.chk_EmailAktif = New DevExpress.XtraEditors.CheckEdit()
        Me.btn_EmailKaydet = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_SMSApiUrl = New DevExpress.XtraEditors.TextEdit()
        Me.txt_SMSApiKey = New DevExpress.XtraEditors.TextEdit()
        Me.txt_SMSSender = New DevExpress.XtraEditors.TextEdit()
        Me.chk_SMSAktif = New DevExpress.XtraEditors.CheckEdit()
        Me.btn_SMSKaydet = New DevExpress.XtraEditors.SimpleButton()
        
        ' Labels
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        
        CType(Me.grd_WhatsAppGruplar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd_BildirimTipleri, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd_PersonelBildirim, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_UltraMsgInstanceID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_UltraMsgToken.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_WhatsAppAktif.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_Kullanici.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_EmailHost.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_EmailPort.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_EmailUser.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_EmailPass.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_EmailFrom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_EmailAktif.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_SMSApiUrl.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_SMSApiKey.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_SMSSender.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_SMSAktif.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        
        ' TabControl1
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(900, 550)
        Me.TabControl1.TabIndex = 0
        
        ' TabPage1 - UltraMsg WhatsApp Ayarlari
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(892, 524)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "WhatsApp Ayarlari (UltraMsg)"
        Me.TabPage1.UseVisualStyleBackColor = True
        
        ' GroupBox1 - UltraMsg Ayarlari
        Me.GroupBox1.Controls.Add(Me.LabelControl13)
        Me.GroupBox1.Controls.Add(Me.LabelControl1)
        Me.GroupBox1.Controls.Add(Me.txt_UltraMsgInstanceID)
        Me.GroupBox1.Controls.Add(Me.LabelControl2)
        Me.GroupBox1.Controls.Add(Me.txt_UltraMsgToken)
        Me.GroupBox1.Controls.Add(Me.lbl_ApiUrl)
        Me.GroupBox1.Controls.Add(Me.chk_WhatsAppAktif)
        Me.GroupBox1.Controls.Add(Me.btn_WhatsAppKaydet)
        Me.GroupBox1.Controls.Add(Me.btn_WhatsAppBaglantiTest)
        Me.GroupBox1.Controls.Add(Me.btn_WhatsAppTest)
        Me.GroupBox1.Controls.Add(Me.btn_UltraMsgPanelAc)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(860, 300)
        Me.GroupBox1.Text = "UltraMsg WhatsApp API Ayarlari"
        
        ' LabelControl13 - Baslik Aciklamasi
        Me.LabelControl13.Location = New System.Drawing.Point(20, 30)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(800, 26)
        Me.LabelControl13.Text = "UltraMsg panelinden (user.ultramsg.com) Instance ID ve Token bilgilerini alarak asagiya girin." & vbCrLf & "WhatsApp'inizi QR kod ile bagladiginizdan emin olun."
        Me.LabelControl13.Appearance.ForeColor = System.Drawing.Color.Gray
        
        ' LabelControl1 - Instance ID
        Me.LabelControl1.Location = New System.Drawing.Point(20, 75)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(100, 13)
        Me.LabelControl1.Text = "Instance ID:"
        
        ' txt_UltraMsgInstanceID
        Me.txt_UltraMsgInstanceID.Location = New System.Drawing.Point(150, 72)
        Me.txt_UltraMsgInstanceID.Name = "txt_UltraMsgInstanceID"
        Me.txt_UltraMsgInstanceID.Size = New System.Drawing.Size(300, 20)
        Me.txt_UltraMsgInstanceID.Properties.NullValuePrompt = "Orn: instance157897"
        
        ' LabelControl2 - Token
        Me.LabelControl2.Location = New System.Drawing.Point(20, 110)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(100, 13)
        Me.LabelControl2.Text = "Token:"
        
        ' txt_UltraMsgToken
        Me.txt_UltraMsgToken.Location = New System.Drawing.Point(150, 107)
        Me.txt_UltraMsgToken.Name = "txt_UltraMsgToken"
        Me.txt_UltraMsgToken.Size = New System.Drawing.Size(400, 20)
        Me.txt_UltraMsgToken.Properties.NullValuePrompt = "Orn: 4s5wk3zkxn17ws9"
        
        ' lbl_ApiUrl - API URL (Dinamik)
        Me.lbl_ApiUrl.Location = New System.Drawing.Point(20, 145)
        Me.lbl_ApiUrl.Name = "lbl_ApiUrl"
        Me.lbl_ApiUrl.Size = New System.Drawing.Size(600, 13)
        Me.lbl_ApiUrl.Text = "API URL: (Instance ID girin)"
        Me.lbl_ApiUrl.Appearance.ForeColor = System.Drawing.Color.Blue
        
        ' chk_WhatsAppAktif
        Me.chk_WhatsAppAktif.Location = New System.Drawing.Point(150, 175)
        Me.chk_WhatsAppAktif.Name = "chk_WhatsAppAktif"
        Me.chk_WhatsAppAktif.Properties.Caption = "WhatsApp Bildirimleri Aktif"
        Me.chk_WhatsAppAktif.Size = New System.Drawing.Size(180, 19)
        
        ' btn_WhatsAppKaydet
        Me.btn_WhatsAppKaydet.Location = New System.Drawing.Point(150, 210)
        Me.btn_WhatsAppKaydet.Name = "btn_WhatsAppKaydet"
        Me.btn_WhatsAppKaydet.Size = New System.Drawing.Size(120, 35)
        Me.btn_WhatsAppKaydet.Text = "Kaydet"
        Me.btn_WhatsAppKaydet.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.btn_WhatsAppKaydet.Appearance.ForeColor = System.Drawing.Color.White
        
        ' btn_WhatsAppBaglantiTest
        Me.btn_WhatsAppBaglantiTest.Location = New System.Drawing.Point(280, 210)
        Me.btn_WhatsAppBaglantiTest.Name = "btn_WhatsAppBaglantiTest"
        Me.btn_WhatsAppBaglantiTest.Size = New System.Drawing.Size(140, 35)
        Me.btn_WhatsAppBaglantiTest.Text = "Baglanti Test"
        Me.btn_WhatsAppBaglantiTest.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_WhatsAppBaglantiTest.Appearance.ForeColor = System.Drawing.Color.White
        
        ' btn_WhatsAppTest
        Me.btn_WhatsAppTest.Location = New System.Drawing.Point(430, 210)
        Me.btn_WhatsAppTest.Name = "btn_WhatsAppTest"
        Me.btn_WhatsAppTest.Size = New System.Drawing.Size(140, 35)
        Me.btn_WhatsAppTest.Text = "Test Mesaji Gonder"
        Me.btn_WhatsAppTest.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btn_WhatsAppTest.Appearance.ForeColor = System.Drawing.Color.White
        
        ' btn_UltraMsgPanelAc
        Me.btn_UltraMsgPanelAc.Location = New System.Drawing.Point(580, 210)
        Me.btn_UltraMsgPanelAc.Name = "btn_UltraMsgPanelAc"
        Me.btn_UltraMsgPanelAc.Size = New System.Drawing.Size(140, 35)
        Me.btn_UltraMsgPanelAc.Text = "UltraMsg Paneli"
        Me.btn_UltraMsgPanelAc.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btn_UltraMsgPanelAc.Appearance.ForeColor = System.Drawing.Color.White
        
        ' TabPage2 - WhatsApp Gruplari
        Me.TabPage2.Controls.Add(Me.btn_UyeleriYonet)
        Me.TabPage2.Controls.Add(Me.btn_GrupSil)
        Me.TabPage2.Controls.Add(Me.btn_GrupEkle)
        Me.TabPage2.Controls.Add(Me.grd_WhatsAppGruplar)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(892, 524)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "WhatsApp Gruplari"
        Me.TabPage2.UseVisualStyleBackColor = True
        
        ' grd_WhatsAppGruplar
        Me.grd_WhatsAppGruplar.Location = New System.Drawing.Point(10, 10)
        Me.grd_WhatsAppGruplar.MainView = Me.GridView1
        Me.grd_WhatsAppGruplar.Name = "grd_WhatsAppGruplar"
        Me.grd_WhatsAppGruplar.Size = New System.Drawing.Size(870, 460)
        Me.grd_WhatsAppGruplar.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        
        ' btn_GrupEkle
        Me.btn_GrupEkle.Location = New System.Drawing.Point(10, 480)
        Me.btn_GrupEkle.Name = "btn_GrupEkle"
        Me.btn_GrupEkle.Size = New System.Drawing.Size(100, 30)
        Me.btn_GrupEkle.Text = "Grup Ekle"
        
        ' btn_GrupSil
        Me.btn_GrupSil.Location = New System.Drawing.Point(120, 480)
        Me.btn_GrupSil.Name = "btn_GrupSil"
        Me.btn_GrupSil.Size = New System.Drawing.Size(100, 30)
        Me.btn_GrupSil.Text = "Grup Sil"
        
        ' btn_UyeleriYonet
        Me.btn_UyeleriYonet.Location = New System.Drawing.Point(230, 480)
        Me.btn_UyeleriYonet.Name = "btn_UyeleriYonet"
        Me.btn_UyeleriYonet.Size = New System.Drawing.Size(120, 30)
        Me.btn_UyeleriYonet.Text = "Uyeleri Yonet"
        
        ' TabPage3 - Bildirim Tercihleri
        Me.TabPage3.Controls.Add(Me.LabelControl12)
        Me.TabPage3.Controls.Add(Me.cmb_Kullanici)
        Me.TabPage3.Controls.Add(Me.btn_TercihKaydet)
        Me.TabPage3.Controls.Add(Me.grd_BildirimTipleri)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(892, 524)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Bildirim Tercihleri"
        Me.TabPage3.UseVisualStyleBackColor = True
        
        ' LabelControl12
        Me.LabelControl12.Location = New System.Drawing.Point(10, 15)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(55, 13)
        Me.LabelControl12.Text = "Kullanici:"
        
        ' cmb_Kullanici
        Me.cmb_Kullanici.Location = New System.Drawing.Point(80, 12)
        Me.cmb_Kullanici.Name = "cmb_Kullanici"
        Me.cmb_Kullanici.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmb_Kullanici.Size = New System.Drawing.Size(300, 20)
        
        ' grd_BildirimTipleri
        Me.grd_BildirimTipleri.Location = New System.Drawing.Point(10, 45)
        Me.grd_BildirimTipleri.MainView = Me.GridView2
        Me.grd_BildirimTipleri.Name = "grd_BildirimTipleri"
        Me.grd_BildirimTipleri.Size = New System.Drawing.Size(870, 425)
        Me.grd_BildirimTipleri.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        
        ' btn_TercihKaydet
        Me.btn_TercihKaydet.Location = New System.Drawing.Point(10, 480)
        Me.btn_TercihKaydet.Name = "btn_TercihKaydet"
        Me.btn_TercihKaydet.Size = New System.Drawing.Size(100, 30)
        Me.btn_TercihKaydet.Text = "Kaydet"
        
        ' TabPage4 - Personel Bildirim Ayarlari
        Me.TabPage4.Controls.Add(Me.btn_PersonelKaydet)
        Me.TabPage4.Controls.Add(Me.grd_PersonelBildirim)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(892, 524)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Personel Bildirim Ayarlari"
        Me.TabPage4.UseVisualStyleBackColor = True
        
        ' grd_PersonelBildirim
        Me.grd_PersonelBildirim.Location = New System.Drawing.Point(10, 10)
        Me.grd_PersonelBildirim.MainView = Me.GridView3
        Me.grd_PersonelBildirim.Name = "grd_PersonelBildirim"
        Me.grd_PersonelBildirim.Size = New System.Drawing.Size(870, 460)
        Me.grd_PersonelBildirim.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        
        ' btn_PersonelKaydet
        Me.btn_PersonelKaydet.Location = New System.Drawing.Point(10, 480)
        Me.btn_PersonelKaydet.Name = "btn_PersonelKaydet"
        Me.btn_PersonelKaydet.Size = New System.Drawing.Size(100, 30)
        Me.btn_PersonelKaydet.Text = "Kaydet"
        
        ' TabPage5 - Email/SMS Ayarlari
        Me.TabPage5.Controls.Add(Me.LabelControl5)
        Me.TabPage5.Controls.Add(Me.txt_EmailHost)
        Me.TabPage5.Controls.Add(Me.LabelControl6)
        Me.TabPage5.Controls.Add(Me.txt_EmailPort)
        Me.TabPage5.Controls.Add(Me.LabelControl7)
        Me.TabPage5.Controls.Add(Me.txt_EmailUser)
        Me.TabPage5.Controls.Add(Me.LabelControl8)
        Me.TabPage5.Controls.Add(Me.txt_EmailPass)
        Me.TabPage5.Controls.Add(Me.LabelControl9)
        Me.TabPage5.Controls.Add(Me.txt_EmailFrom)
        Me.TabPage5.Controls.Add(Me.chk_EmailAktif)
        Me.TabPage5.Controls.Add(Me.btn_EmailKaydet)
        Me.TabPage5.Controls.Add(Me.LabelControl10)
        Me.TabPage5.Controls.Add(Me.txt_SMSApiUrl)
        Me.TabPage5.Controls.Add(Me.LabelControl11)
        Me.TabPage5.Controls.Add(Me.txt_SMSApiKey)
        Me.TabPage5.Controls.Add(Me.txt_SMSSender)
        Me.TabPage5.Controls.Add(Me.chk_SMSAktif)
        Me.TabPage5.Controls.Add(Me.btn_SMSKaydet)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(892, 524)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Email/SMS Ayarlari"
        Me.TabPage5.UseVisualStyleBackColor = True
        
        ' Email Labels and Controls
        Me.LabelControl5.Location = New System.Drawing.Point(20, 30)
        Me.LabelControl5.Text = "Email Host:"
        Me.txt_EmailHost.Location = New System.Drawing.Point(120, 27)
        Me.txt_EmailHost.Size = New System.Drawing.Size(250, 20)
        
        Me.LabelControl6.Location = New System.Drawing.Point(20, 60)
        Me.LabelControl6.Text = "Port:"
        Me.txt_EmailPort.Location = New System.Drawing.Point(120, 57)
        Me.txt_EmailPort.Size = New System.Drawing.Size(80, 20)
        
        Me.LabelControl7.Location = New System.Drawing.Point(20, 90)
        Me.LabelControl7.Text = "Kullanici:"
        Me.txt_EmailUser.Location = New System.Drawing.Point(120, 87)
        Me.txt_EmailUser.Size = New System.Drawing.Size(250, 20)
        
        Me.LabelControl8.Location = New System.Drawing.Point(20, 120)
        Me.LabelControl8.Text = "Sifre:"
        Me.txt_EmailPass.Location = New System.Drawing.Point(120, 117)
        Me.txt_EmailPass.Size = New System.Drawing.Size(250, 20)
        Me.txt_EmailPass.Properties.UseSystemPasswordChar = True
        
        Me.LabelControl9.Location = New System.Drawing.Point(20, 150)
        Me.LabelControl9.Text = "Gonderen:"
        Me.txt_EmailFrom.Location = New System.Drawing.Point(120, 147)
        Me.txt_EmailFrom.Size = New System.Drawing.Size(250, 20)
        
        Me.chk_EmailAktif.Location = New System.Drawing.Point(120, 180)
        Me.chk_EmailAktif.Properties.Caption = "Email Aktif"
        Me.chk_EmailAktif.Size = New System.Drawing.Size(100, 19)
        
        Me.btn_EmailKaydet.Location = New System.Drawing.Point(120, 210)
        Me.btn_EmailKaydet.Size = New System.Drawing.Size(100, 30)
        Me.btn_EmailKaydet.Text = "Email Kaydet"
        
        ' SMS Labels and Controls
        Me.LabelControl10.Location = New System.Drawing.Point(450, 30)
        Me.LabelControl10.Text = "SMS API URL:"
        Me.txt_SMSApiUrl.Location = New System.Drawing.Point(550, 27)
        Me.txt_SMSApiUrl.Size = New System.Drawing.Size(300, 20)
        
        Me.LabelControl11.Location = New System.Drawing.Point(450, 60)
        Me.LabelControl11.Text = "API Key:"
        Me.txt_SMSApiKey.Location = New System.Drawing.Point(550, 57)
        Me.txt_SMSApiKey.Size = New System.Drawing.Size(300, 20)
        
        Me.txt_SMSSender.Location = New System.Drawing.Point(550, 87)
        Me.txt_SMSSender.Size = New System.Drawing.Size(150, 20)
        
        Me.chk_SMSAktif.Location = New System.Drawing.Point(550, 120)
        Me.chk_SMSAktif.Properties.Caption = "SMS Aktif"
        Me.chk_SMSAktif.Size = New System.Drawing.Size(100, 19)
        
        Me.btn_SMSKaydet.Location = New System.Drawing.Point(550, 150)
        Me.btn_SMSKaydet.Size = New System.Drawing.Size(100, 30)
        Me.btn_SMSKaydet.Text = "SMS Kaydet"
        
        ' frm_BildirimAyarlar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 550)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frm_BildirimAyarlar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bildirim Ayarlari"
        
        CType(Me.grd_WhatsAppGruplar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd_BildirimTipleri, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd_PersonelBildirim, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_UltraMsgInstanceID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_UltraMsgToken.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_WhatsAppAktif.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_Kullanici.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_EmailHost.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_EmailPort.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_EmailUser.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_EmailPass.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_EmailFrom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_EmailAktif.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_SMSApiUrl.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_SMSApiKey.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_SMSSender.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_SMSAktif.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
