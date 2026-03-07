<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_BizeSorun
    Inherits DevExpress.XtraEditors.XtraForm

    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_BizeSorun))
        
        ' Ana kontroller
        Me.tabControl = New DevExpress.XtraTab.XtraTabControl()
        Me.tabYeniTicket = New DevExpress.XtraTab.XtraTabPage()
        Me.tabTicketGecmisi = New DevExpress.XtraTab.XtraTabPage()
        
        ' Header Panel
        Me.pnl_Header = New DevExpress.XtraEditors.PanelControl()
        Me.lbl_TicketNo = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_Baslik = New DevExpress.XtraEditors.LabelControl()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        
        ' Footer Panel  
        Me.pnl_Footer = New DevExpress.XtraEditors.PanelControl()
        Me.lbl_Durum = New DevExpress.XtraEditors.LabelControl()
        Me.btn_Gonder = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_Vazgec = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_SistemBilgisi = New DevExpress.XtraEditors.SimpleButton()
        
        ' Progress Panel
        Me.progressPanel = New DevExpress.XtraEditors.PanelControl()
        Me.progressBar = New DevExpress.XtraEditors.MarqueeProgressBarControl()
        Me.lbl_Progress = New DevExpress.XtraEditors.LabelControl()
        
        ' Müşteri Bilgileri Group
        Me.grp_MusteriBilgileri = New DevExpress.XtraEditors.GroupControl()
        Me.txt_mail = New DevExpress.XtraEditors.TextEdit()
        Me.txt_sKimden = New DevExpress.XtraEditors.TextEdit()
        Me.txt_Telefon = New DevExpress.XtraEditors.TextEdit()
        Me.lbl_Mail = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_Kimden = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_Telefon = New DevExpress.XtraEditors.LabelControl()
        
        ' Talep Detayları Group
        Me.grp_TalepDetaylari = New DevExpress.XtraEditors.GroupControl()
        Me.txt_sKategori = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txt_sKonu = New DevExpress.XtraEditors.TextEdit()
        Me.txt_sOncelik = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.lbl_Kategori = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_Konu = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_Oncelik = New DevExpress.XtraEditors.LabelControl()
        
        ' Mesaj Group
        Me.grp_Mesaj = New DevExpress.XtraEditors.GroupControl()
        Me.txt_sMesaj = New DevExpress.XtraEditors.MemoEdit()
        
        ' Dosya Ekleme Group
        Me.grp_DosyaEkleme = New DevExpress.XtraEditors.GroupControl()
        Me.pnl_DosyaAlani = New DevExpress.XtraEditors.PanelControl()
        Me.lbl_SurukleBirak = New DevExpress.XtraEditors.LabelControl()
        Me.listDosyalar = New DevExpress.XtraEditors.ListBoxControl()
        Me.btn_DosyaSec = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_DosyaSil = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_EkranGoruntusu = New DevExpress.XtraEditors.SimpleButton()
        Me.lbl_DosyaBilgi = New DevExpress.XtraEditors.LabelControl()
        
        ' Ticket Geçmişi
        Me.gridTicketGecmisi = New DevExpress.XtraGrid.GridControl()
        Me.gridViewTicket = New DevExpress.XtraGrid.Views.Grid.GridView()
        
        ' SuspendLayout
        CType(Me.tabControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabControl.SuspendLayout()
        Me.tabYeniTicket.SuspendLayout()
        Me.tabTicketGecmisi.SuspendLayout()
        CType(Me.pnl_Header, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_Header.SuspendLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnl_Footer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_Footer.SuspendLayout()
        CType(Me.progressPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.progressPanel.SuspendLayout()
        CType(Me.progressBar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grp_MusteriBilgileri, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_MusteriBilgileri.SuspendLayout()
        CType(Me.txt_mail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sKimden.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Telefon.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grp_TalepDetaylari, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_TalepDetaylari.SuspendLayout()
        CType(Me.txt_sKategori.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sKonu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sOncelik.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grp_Mesaj, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_Mesaj.SuspendLayout()
        CType(Me.txt_sMesaj.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grp_DosyaEkleme, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_DosyaEkleme.SuspendLayout()
        CType(Me.pnl_DosyaAlani, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_DosyaAlani.SuspendLayout()
        CType(Me.listDosyalar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridTicketGecmisi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridViewTicket, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()

        '
        ' pnl_Header
        '
        Me.pnl_Header.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.pnl_Header.Appearance.Options.UseBackColor = True
        Me.pnl_Header.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pnl_Header.Controls.Add(Me.lbl_TicketNo)
        Me.pnl_Header.Controls.Add(Me.lbl_Baslik)
        Me.pnl_Header.Controls.Add(Me.pictureBox1)
        Me.pnl_Header.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_Header.Location = New System.Drawing.Point(0, 0)
        Me.pnl_Header.Name = "pnl_Header"
        Me.pnl_Header.Size = New System.Drawing.Size(950, 70)
        Me.pnl_Header.TabIndex = 0

        '
        ' pictureBox1
        '
        Me.pictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.pictureBox1.Location = New System.Drawing.Point(15, 10)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(50, 50)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pictureBox1.TabIndex = 0
        Me.pictureBox1.TabStop = False

        '
        ' lbl_Baslik
        '
        Me.lbl_Baslik.Appearance.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_Baslik.Appearance.ForeColor = System.Drawing.Color.White
        Me.lbl_Baslik.Appearance.Options.UseFont = True
        Me.lbl_Baslik.Appearance.Options.UseForeColor = True
        Me.lbl_Baslik.Location = New System.Drawing.Point(75, 12)
        Me.lbl_Baslik.Name = "lbl_Baslik"
        Me.lbl_Baslik.Size = New System.Drawing.Size(200, 32)
        Me.lbl_Baslik.TabIndex = 1
        Me.lbl_Baslik.Text = "Destek Talebi"

        '
        ' lbl_TicketNo
        '
        Me.lbl_TicketNo.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular)
        Me.lbl_TicketNo.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbl_TicketNo.Appearance.Options.UseFont = True
        Me.lbl_TicketNo.Appearance.Options.UseForeColor = True
        Me.lbl_TicketNo.Location = New System.Drawing.Point(75, 44)
        Me.lbl_TicketNo.Name = "lbl_TicketNo"
        Me.lbl_TicketNo.Size = New System.Drawing.Size(200, 20)
        Me.lbl_TicketNo.TabIndex = 2
        Me.lbl_TicketNo.Text = "Ticket: TKT-2024-00001"

        '
        ' tabControl
        '
        Me.tabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabControl.Location = New System.Drawing.Point(0, 70)
        Me.tabControl.Name = "tabControl"
        Me.tabControl.SelectedTabPage = Me.tabYeniTicket
        Me.tabControl.Size = New System.Drawing.Size(950, 480)
        Me.tabControl.TabIndex = 1
        Me.tabControl.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabYeniTicket, Me.tabTicketGecmisi})

        '
        ' tabYeniTicket
        '
        Me.tabYeniTicket.Controls.Add(Me.grp_Mesaj)
        Me.tabYeniTicket.Controls.Add(Me.grp_DosyaEkleme)
        Me.tabYeniTicket.Controls.Add(Me.grp_TalepDetaylari)
        Me.tabYeniTicket.Controls.Add(Me.grp_MusteriBilgileri)
        Me.tabYeniTicket.Name = "tabYeniTicket"
        Me.tabYeniTicket.Size = New System.Drawing.Size(944, 449)
        Me.tabYeniTicket.Text = "  Yeni Talep  "
        Me.tabYeniTicket.Padding = New System.Windows.Forms.Padding(10)

        '
        ' tabTicketGecmisi
        '
        Me.tabTicketGecmisi.Controls.Add(Me.gridTicketGecmisi)
        Me.tabTicketGecmisi.Name = "tabTicketGecmisi"
        Me.tabTicketGecmisi.Size = New System.Drawing.Size(944, 449)
        Me.tabTicketGecmisi.Text = "  Geçmiş Taleplerim  "
        Me.tabTicketGecmisi.Padding = New System.Windows.Forms.Padding(10)

        '
        ' grp_MusteriBilgileri
        '
        Me.grp_MusteriBilgileri.AppearanceCaption.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.grp_MusteriBilgileri.AppearanceCaption.ForeColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.grp_MusteriBilgileri.AppearanceCaption.Options.UseFont = True
        Me.grp_MusteriBilgileri.AppearanceCaption.Options.UseForeColor = True
        Me.grp_MusteriBilgileri.Controls.Add(Me.lbl_Mail)
        Me.grp_MusteriBilgileri.Controls.Add(Me.txt_mail)
        Me.grp_MusteriBilgileri.Controls.Add(Me.lbl_Kimden)
        Me.grp_MusteriBilgileri.Controls.Add(Me.txt_sKimden)
        Me.grp_MusteriBilgileri.Controls.Add(Me.lbl_Telefon)
        Me.grp_MusteriBilgileri.Controls.Add(Me.txt_Telefon)
        Me.grp_MusteriBilgileri.Location = New System.Drawing.Point(10, 10)
        Me.grp_MusteriBilgileri.Name = "grp_MusteriBilgileri"
        Me.grp_MusteriBilgileri.Size = New System.Drawing.Size(450, 130)
        Me.grp_MusteriBilgileri.TabIndex = 0
        Me.grp_MusteriBilgileri.Text = "Müşteri Bilgileri"

        '
        ' lbl_Mail
        '
        Me.lbl_Mail.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Mail.Location = New System.Drawing.Point(15, 35)
        Me.lbl_Mail.Name = "lbl_Mail"
        Me.lbl_Mail.Size = New System.Drawing.Size(80, 15)
        Me.lbl_Mail.TabIndex = 0
        Me.lbl_Mail.Text = "E-posta *"

        '
        ' txt_mail
        '
        Me.txt_mail.Location = New System.Drawing.Point(100, 32)
        Me.txt_mail.Name = "txt_mail"
        Me.txt_mail.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txt_mail.Properties.Appearance.Options.UseFont = True
        Me.txt_mail.Size = New System.Drawing.Size(335, 24)
        Me.txt_mail.TabIndex = 1

        '
        ' lbl_Kimden
        '
        Me.lbl_Kimden.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Kimden.Location = New System.Drawing.Point(15, 67)
        Me.lbl_Kimden.Name = "lbl_Kimden"
        Me.lbl_Kimden.Size = New System.Drawing.Size(80, 15)
        Me.lbl_Kimden.TabIndex = 2
        Me.lbl_Kimden.Text = "Ad Soyad *"

        '
        ' txt_sKimden
        '
        Me.txt_sKimden.Location = New System.Drawing.Point(100, 64)
        Me.txt_sKimden.Name = "txt_sKimden"
        Me.txt_sKimden.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txt_sKimden.Properties.Appearance.Options.UseFont = True
        Me.txt_sKimden.Size = New System.Drawing.Size(335, 24)
        Me.txt_sKimden.TabIndex = 3

        '
        ' lbl_Telefon
        '
        Me.lbl_Telefon.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Telefon.Location = New System.Drawing.Point(15, 99)
        Me.lbl_Telefon.Name = "lbl_Telefon"
        Me.lbl_Telefon.Size = New System.Drawing.Size(80, 15)
        Me.lbl_Telefon.TabIndex = 4
        Me.lbl_Telefon.Text = "Telefon"

        '
        ' txt_Telefon
        '
        Me.txt_Telefon.Location = New System.Drawing.Point(100, 96)
        Me.txt_Telefon.Name = "txt_Telefon"
        Me.txt_Telefon.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txt_Telefon.Properties.Appearance.Options.UseFont = True
        Me.txt_Telefon.Properties.Mask.EditMask = "(000) 000-0000"
        Me.txt_Telefon.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.txt_Telefon.Size = New System.Drawing.Size(180, 24)
        Me.txt_Telefon.TabIndex = 5

        '
        ' grp_TalepDetaylari
        '
        Me.grp_TalepDetaylari.AppearanceCaption.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.grp_TalepDetaylari.AppearanceCaption.ForeColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.grp_TalepDetaylari.AppearanceCaption.Options.UseFont = True
        Me.grp_TalepDetaylari.AppearanceCaption.Options.UseForeColor = True
        Me.grp_TalepDetaylari.Controls.Add(Me.lbl_Kategori)
        Me.grp_TalepDetaylari.Controls.Add(Me.txt_sKategori)
        Me.grp_TalepDetaylari.Controls.Add(Me.lbl_Konu)
        Me.grp_TalepDetaylari.Controls.Add(Me.txt_sKonu)
        Me.grp_TalepDetaylari.Controls.Add(Me.lbl_Oncelik)
        Me.grp_TalepDetaylari.Controls.Add(Me.txt_sOncelik)
        Me.grp_TalepDetaylari.Location = New System.Drawing.Point(470, 10)
        Me.grp_TalepDetaylari.Name = "grp_TalepDetaylari"
        Me.grp_TalepDetaylari.Size = New System.Drawing.Size(464, 130)
        Me.grp_TalepDetaylari.TabIndex = 1
        Me.grp_TalepDetaylari.Text = "Talep Detayları"

        '
        ' lbl_Kategori
        '
        Me.lbl_Kategori.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Kategori.Location = New System.Drawing.Point(15, 35)
        Me.lbl_Kategori.Name = "lbl_Kategori"
        Me.lbl_Kategori.Size = New System.Drawing.Size(70, 15)
        Me.lbl_Kategori.TabIndex = 0
        Me.lbl_Kategori.Text = "Kategori *"

        '
        ' txt_sKategori
        '
        Me.txt_sKategori.Location = New System.Drawing.Point(90, 32)
        Me.txt_sKategori.Name = "txt_sKategori"
        Me.txt_sKategori.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txt_sKategori.Properties.Appearance.Options.UseFont = True
        Me.txt_sKategori.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_sKategori.Properties.Items.AddRange(New Object() {"Hata Bildirimi", "Kullanım Sorusu", "Özellik Talebi", "Lisans/Aktivasyon", "Performans", "Entegrasyon", "Diğer"})
        Me.txt_sKategori.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txt_sKategori.Size = New System.Drawing.Size(180, 24)
        Me.txt_sKategori.TabIndex = 1

        '
        ' lbl_Oncelik
        '
        Me.lbl_Oncelik.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Oncelik.Location = New System.Drawing.Point(280, 35)
        Me.lbl_Oncelik.Name = "lbl_Oncelik"
        Me.lbl_Oncelik.Size = New System.Drawing.Size(50, 15)
        Me.lbl_Oncelik.TabIndex = 2
        Me.lbl_Oncelik.Text = "Öncelik"

        '
        ' txt_sOncelik
        '
        Me.txt_sOncelik.Location = New System.Drawing.Point(335, 32)
        Me.txt_sOncelik.Name = "txt_sOncelik"
        Me.txt_sOncelik.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txt_sOncelik.Properties.Appearance.Options.UseFont = True
        Me.txt_sOncelik.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_sOncelik.Properties.Items.AddRange(New Object() {"Normal", "Acil", "Arayın"})
        Me.txt_sOncelik.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txt_sOncelik.Size = New System.Drawing.Size(115, 24)
        Me.txt_sOncelik.TabIndex = 3

        '
        ' lbl_Konu
        '
        Me.lbl_Konu.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Konu.Location = New System.Drawing.Point(15, 67)
        Me.lbl_Konu.Name = "lbl_Konu"
        Me.lbl_Konu.Size = New System.Drawing.Size(70, 15)
        Me.lbl_Konu.TabIndex = 4
        Me.lbl_Konu.Text = "Konu *"

        '
        ' txt_sKonu
        '
        Me.txt_sKonu.Location = New System.Drawing.Point(90, 64)
        Me.txt_sKonu.Name = "txt_sKonu"
        Me.txt_sKonu.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txt_sKonu.Properties.Appearance.Options.UseFont = True
        Me.txt_sKonu.Size = New System.Drawing.Size(360, 24)
        Me.txt_sKonu.TabIndex = 5

        '
        ' grp_Mesaj
        '
        Me.grp_Mesaj.AppearanceCaption.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.grp_Mesaj.AppearanceCaption.ForeColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.grp_Mesaj.AppearanceCaption.Options.UseFont = True
        Me.grp_Mesaj.AppearanceCaption.Options.UseForeColor = True
        Me.grp_Mesaj.Controls.Add(Me.txt_sMesaj)
        Me.grp_Mesaj.Location = New System.Drawing.Point(10, 150)
        Me.grp_Mesaj.Name = "grp_Mesaj"
        Me.grp_Mesaj.Size = New System.Drawing.Size(620, 290)
        Me.grp_Mesaj.TabIndex = 2
        Me.grp_Mesaj.Text = "Mesajınız *"

        '
        ' txt_sMesaj
        '
        Me.txt_sMesaj.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_sMesaj.Location = New System.Drawing.Point(2, 23)
        Me.txt_sMesaj.Name = "txt_sMesaj"
        Me.txt_sMesaj.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txt_sMesaj.Properties.Appearance.Options.UseFont = True
        Me.txt_sMesaj.Size = New System.Drawing.Size(616, 265)
        Me.txt_sMesaj.TabIndex = 0

        '
        ' grp_DosyaEkleme
        '
        Me.grp_DosyaEkleme.AppearanceCaption.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.grp_DosyaEkleme.AppearanceCaption.ForeColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.grp_DosyaEkleme.AppearanceCaption.Options.UseFont = True
        Me.grp_DosyaEkleme.AppearanceCaption.Options.UseForeColor = True
        Me.grp_DosyaEkleme.Controls.Add(Me.pnl_DosyaAlani)
        Me.grp_DosyaEkleme.Controls.Add(Me.listDosyalar)
        Me.grp_DosyaEkleme.Controls.Add(Me.btn_DosyaSec)
        Me.grp_DosyaEkleme.Controls.Add(Me.btn_DosyaSil)
        Me.grp_DosyaEkleme.Controls.Add(Me.btn_EkranGoruntusu)
        Me.grp_DosyaEkleme.Controls.Add(Me.lbl_DosyaBilgi)
        Me.grp_DosyaEkleme.Location = New System.Drawing.Point(640, 150)
        Me.grp_DosyaEkleme.Name = "grp_DosyaEkleme"
        Me.grp_DosyaEkleme.Size = New System.Drawing.Size(294, 290)
        Me.grp_DosyaEkleme.TabIndex = 3
        Me.grp_DosyaEkleme.Text = "Dosya Ekleme (Opsiyonel)"

        '
        ' pnl_DosyaAlani
        '
        Me.pnl_DosyaAlani.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.pnl_DosyaAlani.Appearance.Options.UseBackColor = True
        Me.pnl_DosyaAlani.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.pnl_DosyaAlani.Controls.Add(Me.lbl_SurukleBirak)
        Me.pnl_DosyaAlani.Location = New System.Drawing.Point(10, 30)
        Me.pnl_DosyaAlani.Name = "pnl_DosyaAlani"
        Me.pnl_DosyaAlani.Size = New System.Drawing.Size(274, 70)
        Me.pnl_DosyaAlani.TabIndex = 0

        '
        ' lbl_SurukleBirak
        '
        Me.lbl_SurukleBirak.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_SurukleBirak.Appearance.ForeColor = System.Drawing.Color.Gray
        Me.lbl_SurukleBirak.Appearance.Options.UseFont = True
        Me.lbl_SurukleBirak.Appearance.Options.UseForeColor = True
        Me.lbl_SurukleBirak.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lbl_SurukleBirak.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_SurukleBirak.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_SurukleBirak.Location = New System.Drawing.Point(2, 2)
        Me.lbl_SurukleBirak.Name = "lbl_SurukleBirak"
        Me.lbl_SurukleBirak.Size = New System.Drawing.Size(270, 66)
        Me.lbl_SurukleBirak.TabIndex = 0
        Me.lbl_SurukleBirak.Text = "Dosyaları buraya sürükleyin" & vbCrLf & "veya Ctrl+V ile yapıştırın" & vbCrLf & "(Resim: max 10MB, Video: max 50MB)"

        '
        ' listDosyalar
        '
        Me.listDosyalar.Location = New System.Drawing.Point(10, 108)
        Me.listDosyalar.Name = "listDosyalar"
        Me.listDosyalar.Size = New System.Drawing.Size(274, 100)
        Me.listDosyalar.TabIndex = 1

        '
        ' btn_DosyaSec
        '
        Me.btn_DosyaSec.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_DosyaSec.Appearance.Options.UseFont = True
        Me.btn_DosyaSec.Location = New System.Drawing.Point(10, 215)
        Me.btn_DosyaSec.Name = "btn_DosyaSec"
        Me.btn_DosyaSec.Size = New System.Drawing.Size(85, 28)
        Me.btn_DosyaSec.TabIndex = 2
        Me.btn_DosyaSec.Text = "Dosya Seç"

        '
        ' btn_DosyaSil
        '
        Me.btn_DosyaSil.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_DosyaSil.Appearance.Options.UseFont = True
        Me.btn_DosyaSil.Location = New System.Drawing.Point(100, 215)
        Me.btn_DosyaSil.Name = "btn_DosyaSil"
        Me.btn_DosyaSil.Size = New System.Drawing.Size(60, 28)
        Me.btn_DosyaSil.TabIndex = 3
        Me.btn_DosyaSil.Text = "Sil"

        '
        ' btn_EkranGoruntusu
        '
        Me.btn_EkranGoruntusu.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_EkranGoruntusu.Appearance.Options.UseFont = True
        Me.btn_EkranGoruntusu.Location = New System.Drawing.Point(165, 215)
        Me.btn_EkranGoruntusu.Name = "btn_EkranGoruntusu"
        Me.btn_EkranGoruntusu.Size = New System.Drawing.Size(119, 28)
        Me.btn_EkranGoruntusu.TabIndex = 4
        Me.btn_EkranGoruntusu.Text = "Ekran Görüntüsü"

        '
        ' lbl_DosyaBilgi
        '
        Me.lbl_DosyaBilgi.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lbl_DosyaBilgi.Appearance.ForeColor = System.Drawing.Color.Gray
        Me.lbl_DosyaBilgi.Location = New System.Drawing.Point(10, 250)
        Me.lbl_DosyaBilgi.Name = "lbl_DosyaBilgi"
        Me.lbl_DosyaBilgi.Size = New System.Drawing.Size(200, 15)
        Me.lbl_DosyaBilgi.TabIndex = 5
        Me.lbl_DosyaBilgi.Text = "0 dosya ekli (Toplam: 0 MB)"

        '
        ' gridTicketGecmisi
        '
        Me.gridTicketGecmisi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridTicketGecmisi.Location = New System.Drawing.Point(10, 10)
        Me.gridTicketGecmisi.MainView = Me.gridViewTicket
        Me.gridTicketGecmisi.Name = "gridTicketGecmisi"
        Me.gridTicketGecmisi.Size = New System.Drawing.Size(924, 429)
        Me.gridTicketGecmisi.TabIndex = 0

        '
        ' gridViewTicket
        '
        Me.gridViewTicket.GridControl = Me.gridTicketGecmisi
        Me.gridViewTicket.Name = "gridViewTicket"
        Me.gridViewTicket.OptionsBehavior.Editable = False
        Me.gridViewTicket.OptionsView.ShowGroupPanel = False

        '
        ' pnl_Footer
        '
        Me.pnl_Footer.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.pnl_Footer.Appearance.Options.UseBackColor = True
        Me.pnl_Footer.Controls.Add(Me.progressPanel)
        Me.pnl_Footer.Controls.Add(Me.lbl_Durum)
        Me.pnl_Footer.Controls.Add(Me.btn_Gonder)
        Me.pnl_Footer.Controls.Add(Me.btn_Vazgec)
        Me.pnl_Footer.Controls.Add(Me.btn_SistemBilgisi)
        Me.pnl_Footer.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnl_Footer.Location = New System.Drawing.Point(0, 550)
        Me.pnl_Footer.Name = "pnl_Footer"
        Me.pnl_Footer.Size = New System.Drawing.Size(950, 60)
        Me.pnl_Footer.TabIndex = 2

        '
        ' progressPanel
        '
        Me.progressPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.progressPanel.Controls.Add(Me.progressBar)
        Me.progressPanel.Controls.Add(Me.lbl_Progress)
        Me.progressPanel.Location = New System.Drawing.Point(350, 12)
        Me.progressPanel.Name = "progressPanel"
        Me.progressPanel.Size = New System.Drawing.Size(250, 40)
        Me.progressPanel.TabIndex = 0
        Me.progressPanel.Visible = False

        '
        ' progressBar
        '
        Me.progressBar.EditValue = 0
        Me.progressBar.Location = New System.Drawing.Point(5, 22)
        Me.progressBar.Name = "progressBar"
        Me.progressBar.Size = New System.Drawing.Size(240, 15)
        Me.progressBar.TabIndex = 0

        '
        ' lbl_Progress
        '
        Me.lbl_Progress.Location = New System.Drawing.Point(5, 5)
        Me.lbl_Progress.Name = "lbl_Progress"
        Me.lbl_Progress.Size = New System.Drawing.Size(80, 13)
        Me.lbl_Progress.TabIndex = 1
        Me.lbl_Progress.Text = "Gönderiliyor..."

        '
        ' lbl_Durum
        '
        Me.lbl_Durum.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Durum.Appearance.ForeColor = System.Drawing.Color.Gray
        Me.lbl_Durum.Location = New System.Drawing.Point(15, 22)
        Me.lbl_Durum.Name = "lbl_Durum"
        Me.lbl_Durum.Size = New System.Drawing.Size(300, 15)
        Me.lbl_Durum.TabIndex = 1
        Me.lbl_Durum.Text = "Hazır"

        '
        ' btn_Gonder
        '
        Me.btn_Gonder.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.btn_Gonder.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btn_Gonder.Appearance.ForeColor = System.Drawing.Color.White
        Me.btn_Gonder.Appearance.Options.UseBackColor = True
        Me.btn_Gonder.Appearance.Options.UseFont = True
        Me.btn_Gonder.Appearance.Options.UseForeColor = True
        Me.btn_Gonder.Location = New System.Drawing.Point(620, 15)
        Me.btn_Gonder.Name = "btn_Gonder"
        Me.btn_Gonder.Size = New System.Drawing.Size(120, 35)
        Me.btn_Gonder.TabIndex = 2
        Me.btn_Gonder.Text = "Gönder"

        '
        ' btn_Vazgec
        '
        Me.btn_Vazgec.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btn_Vazgec.Appearance.Options.UseFont = True
        Me.btn_Vazgec.Location = New System.Drawing.Point(750, 15)
        Me.btn_Vazgec.Name = "btn_Vazgec"
        Me.btn_Vazgec.Size = New System.Drawing.Size(90, 35)
        Me.btn_Vazgec.TabIndex = 3
        Me.btn_Vazgec.Text = "Vazgeç"

        '
        ' btn_SistemBilgisi
        '
        Me.btn_SistemBilgisi.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_SistemBilgisi.Appearance.Options.UseFont = True
        Me.btn_SistemBilgisi.Location = New System.Drawing.Point(850, 15)
        Me.btn_SistemBilgisi.Name = "btn_SistemBilgisi"
        Me.btn_SistemBilgisi.Size = New System.Drawing.Size(90, 35)
        Me.btn_SistemBilgisi.TabIndex = 4
        Me.btn_SistemBilgisi.Text = "Sistem Bilgisi"

        '
        ' frm_BizeSorun
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(950, 610)
        Me.Controls.Add(Me.tabControl)
        Me.Controls.Add(Me.pnl_Footer)
        Me.Controls.Add(Me.pnl_Header)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frm_BizeSorun"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Destek Talebi - Barkod Mağaza"
        
        ' ResumeLayout
        CType(Me.tabControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabControl.ResumeLayout(False)
        Me.tabYeniTicket.ResumeLayout(False)
        Me.tabTicketGecmisi.ResumeLayout(False)
        CType(Me.pnl_Header, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_Header.ResumeLayout(False)
        Me.pnl_Header.PerformLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnl_Footer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_Footer.ResumeLayout(False)
        Me.pnl_Footer.PerformLayout()
        CType(Me.progressPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.progressPanel.ResumeLayout(False)
        Me.progressPanel.PerformLayout()
        CType(Me.progressBar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grp_MusteriBilgileri, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_MusteriBilgileri.ResumeLayout(False)
        Me.grp_MusteriBilgileri.PerformLayout()
        CType(Me.txt_mail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sKimden.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Telefon.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grp_TalepDetaylari, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_TalepDetaylari.ResumeLayout(False)
        Me.grp_TalepDetaylari.PerformLayout()
        CType(Me.txt_sKategori.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sKonu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sOncelik.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grp_Mesaj, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_Mesaj.ResumeLayout(False)
        CType(Me.txt_sMesaj.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grp_DosyaEkleme, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_DosyaEkleme.ResumeLayout(False)
        Me.grp_DosyaEkleme.PerformLayout()
        CType(Me.pnl_DosyaAlani, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_DosyaAlani.ResumeLayout(False)
        CType(Me.listDosyalar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridTicketGecmisi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridViewTicket, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    ' Header
    Friend WithEvents pnl_Header As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lbl_Baslik As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_TicketNo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents pictureBox1 As System.Windows.Forms.PictureBox
    
    ' Tab Control
    Friend WithEvents tabControl As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tabYeniTicket As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabTicketGecmisi As DevExpress.XtraTab.XtraTabPage
    
    ' Müşteri Bilgileri
    Friend WithEvents grp_MusteriBilgileri As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txt_mail As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_sKimden As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_Telefon As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lbl_Mail As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_Kimden As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_Telefon As DevExpress.XtraEditors.LabelControl
    
    ' Talep Detayları
    Friend WithEvents grp_TalepDetaylari As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txt_sKategori As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txt_sKonu As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_sOncelik As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents lbl_Kategori As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_Konu As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_Oncelik As DevExpress.XtraEditors.LabelControl
    
    ' Mesaj
    Friend WithEvents grp_Mesaj As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txt_sMesaj As DevExpress.XtraEditors.MemoEdit
    
    ' Dosya Ekleme
    Friend WithEvents grp_DosyaEkleme As DevExpress.XtraEditors.GroupControl
    Friend WithEvents pnl_DosyaAlani As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lbl_SurukleBirak As DevExpress.XtraEditors.LabelControl
    Friend WithEvents listDosyalar As DevExpress.XtraEditors.ListBoxControl
    Friend WithEvents btn_DosyaSec As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_DosyaSil As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_EkranGoruntusu As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lbl_DosyaBilgi As DevExpress.XtraEditors.LabelControl
    
    ' Ticket Geçmişi
    Friend WithEvents gridTicketGecmisi As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridViewTicket As DevExpress.XtraGrid.Views.Grid.GridView
    
    ' Footer
    Friend WithEvents pnl_Footer As DevExpress.XtraEditors.PanelControl
    Friend WithEvents progressPanel As DevExpress.XtraEditors.PanelControl
    Friend WithEvents progressBar As DevExpress.XtraEditors.MarqueeProgressBarControl
    Friend WithEvents lbl_Progress As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_Durum As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_Gonder As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_Vazgec As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_SistemBilgisi As DevExpress.XtraEditors.SimpleButton

End Class
