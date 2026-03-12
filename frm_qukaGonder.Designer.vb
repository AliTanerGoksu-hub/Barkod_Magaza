<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_qukaGonder
    Inherits System.Windows.Forms.Form

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
        Me.tabControl1 = New System.Windows.Forms.TabControl()
        Me.tabKlasik = New System.Windows.Forms.TabPage()
        Me.grpKriterler = New System.Windows.Forms.GroupBox()
        Me.chkPazaryeriFiyatlari = New System.Windows.Forms.CheckBox()
        Me.chkTumStoklar = New System.Windows.Forms.CheckBox()
        Me.chkFiyatDegisenleri = New System.Windows.Forms.CheckBox()
        Me.chkMiktarDegisenleri = New System.Windows.Forms.CheckBox()
        Me.chkResimGonder = New System.Windows.Forms.CheckBox()
        Me.chkVaryantGuncelle = New System.Windows.Forms.CheckBox()
        Me.chkKategoriGuncelle = New System.Windows.Forms.CheckBox()
        Me.chkSiparisAl = New System.Windows.Forms.CheckBox()
        Me.chkTumSiparisler = New System.Windows.Forms.CheckBox()
        Me.chkKargoEkle = New System.Windows.Forms.CheckBox()
        Me.lblKargoMinTutar = New System.Windows.Forms.Label()
        Me.txtKargoMinTutar = New System.Windows.Forms.NumericUpDown()
        Me.lblKargoStokKodu = New System.Windows.Forms.Label()
        Me.txtKargoStokKodu = New System.Windows.Forms.TextBox()
        Me.lblKargoFiyat = New System.Windows.Forms.Label()
        Me.txtKargoFiyat = New System.Windows.Forms.NumericUpDown()
        Me.grpTimerlar = New System.Windows.Forms.GroupBox()
        Me.lblStokTimer = New System.Windows.Forms.Label()
        Me.txtStokTimerDakika = New System.Windows.Forms.NumericUpDown()
        Me.lblSiparisTimer = New System.Windows.Forms.Label()
        Me.txtSiparisTimerDakika = New System.Windows.Forms.NumericUpDown()
        Me.grpGonderimAyarlari = New System.Windows.Forms.GroupBox()
        Me.chkTumunuGonder = New System.Windows.Forms.CheckBox()
        Me.chkMarkaGonder = New System.Windows.Forms.CheckBox()
        Me.chkKategoriGonder = New System.Windows.Forms.CheckBox()
        Me.chkUzunAciklamaGonder = New System.Windows.Forms.CheckBox()
        Me.chkKisaAciklamaGonder = New System.Windows.Forms.CheckBox()
        Me.chkSEOGonder = New System.Windows.Forms.CheckBox()
        Me.chkDesiGonder = New System.Windows.Forms.CheckBox()
        Me.grpGonderimModu = New System.Windows.Forms.GroupBox()
        Me.rdoApiDogrudan = New System.Windows.Forms.RadioButton()
        Me.rdoPhpEntegrasyon = New System.Windows.Forms.RadioButton()
        Me.grpTarihliSiparis = New System.Windows.Forms.GroupBox()
        Me.lblFiyatTipi = New System.Windows.Forms.Label()
        Me.lblBaslangicTarihi = New System.Windows.Forms.Label()
        Me.cmbFiyatTipi = New System.Windows.Forms.ComboBox()
        Me.dtpBaslangic = New System.Windows.Forms.DateTimePicker()
        Me.lblBitisTarihi = New System.Windows.Forms.Label()
        Me.dtpBitis = New System.Windows.Forms.DateTimePicker()
        Me.lblSiparisStatus = New System.Windows.Forms.Label()
        Me.cmbSiparisStatus = New System.Windows.Forms.ComboBox()
        Me.btnTarihliSiparisCek = New System.Windows.Forms.Button()
        Me.btnEksikBilgiGuncelle = New System.Windows.Forms.Button()
        Me.btnManuelBaslat = New System.Windows.Forms.Button()
        Me.btnOtomatikBaslat = New System.Windows.Forms.Button()
        Me.btnDurdur = New System.Windows.Forms.Button()
        Me.btnWebdeOlmayanlar = New System.Windows.Forms.Button()
        Me.btnHataliUrunler = New System.Windows.Forms.Button()
        Me.tabTrigger = New System.Windows.Forms.TabPage()
        Me.grpTriggerAyarlar = New System.Windows.Forms.GroupBox()
        Me.chkTriggerAktif = New System.Windows.Forms.CheckBox()
        Me.chkTriggerStok = New System.Windows.Forms.CheckBox()
        Me.chkTriggerFiyat = New System.Windows.Forms.CheckBox()
        Me.chkTriggerResim = New System.Windows.Forms.CheckBox()
        Me.chkTriggerKategori = New System.Windows.Forms.CheckBox()
        Me.grpTriggerTimer = New System.Windows.Forms.GroupBox()
        Me.lblTriggerTimer = New System.Windows.Forms.Label()
        Me.txtTriggerTimerDakika = New System.Windows.Forms.NumericUpDown()
        Me.grpTriggerIstatistik = New System.Windows.Forms.GroupBox()
        Me.lblBekleyenStok = New System.Windows.Forms.Label()
        Me.lblBekleyenFiyat = New System.Windows.Forms.Label()
        Me.lblBekleyenResim = New System.Windows.Forms.Label()
        Me.lblBekleyenKategori = New System.Windows.Forms.Label()
        Me.btnTriggerYenile = New System.Windows.Forms.Button()
        Me.grpManuelGuncelleme = New System.Windows.Forms.GroupBox()
        Me.btnSinifEsleme = New System.Windows.Forms.Button()
        Me.btnKategoriGuncelle = New System.Windows.Forms.Button()
        Me.btnResimGuncelle = New System.Windows.Forms.Button()
        Me.btnTriggerBaslat = New System.Windows.Forms.Button()
        Me.btnTriggerDurdur = New System.Windows.Forms.Button()
        Me.lblTriggerBilgi = New System.Windows.Forms.Label()
        Me.lblTriggerDurum = New System.Windows.Forms.Label()
        Me.lblDurum = New System.Windows.Forms.Label()
        Me.prgKlasik = New System.Windows.Forms.ProgressBar()
        Me.lblKlasikSayac = New System.Windows.Forms.Label()
        Me.prgTrigger = New System.Windows.Forms.ProgressBar()
        Me.lblTriggerSayac = New System.Windows.Forms.Label()
        Me.txtLog = New System.Windows.Forms.TextBox()
        Me.tabControl1.SuspendLayout()
        Me.tabKlasik.SuspendLayout()
        Me.grpKriterler.SuspendLayout()
        CType(Me.txtKargoMinTutar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKargoFiyat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpTimerlar.SuspendLayout()
        CType(Me.txtStokTimerDakika, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSiparisTimerDakika, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpGonderimAyarlari.SuspendLayout()
        Me.grpGonderimModu.SuspendLayout()
        Me.grpTarihliSiparis.SuspendLayout()
        Me.tabTrigger.SuspendLayout()
        Me.grpTriggerAyarlar.SuspendLayout()
        Me.grpTriggerTimer.SuspendLayout()
        CType(Me.txtTriggerTimerDakika, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpTriggerIstatistik.SuspendLayout()
        Me.grpManuelGuncelleme.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabControl1
        '
        Me.tabControl1.Controls.Add(Me.tabKlasik)
        Me.tabControl1.Controls.Add(Me.tabTrigger)
        Me.tabControl1.Location = New System.Drawing.Point(12, 12)
        Me.tabControl1.Name = "tabControl1"
        Me.tabControl1.SelectedIndex = 0
        Me.tabControl1.Size = New System.Drawing.Size(1452, 535)
        Me.tabControl1.TabIndex = 0
        '
        'tabKlasik
        '
        Me.tabKlasik.Controls.Add(Me.grpKriterler)
        Me.tabKlasik.Controls.Add(Me.grpTimerlar)
        Me.tabKlasik.Controls.Add(Me.grpGonderimAyarlari)
        Me.tabKlasik.Controls.Add(Me.grpGonderimModu)
        Me.tabKlasik.Controls.Add(Me.grpTarihliSiparis)
        Me.tabKlasik.Controls.Add(Me.btnManuelBaslat)
        Me.tabKlasik.Controls.Add(Me.btnOtomatikBaslat)
        Me.tabKlasik.Controls.Add(Me.btnDurdur)
        Me.tabKlasik.Controls.Add(Me.btnWebdeOlmayanlar)
        Me.tabKlasik.Controls.Add(Me.btnHataliUrunler)
        Me.tabKlasik.Location = New System.Drawing.Point(4, 29)
        Me.tabKlasik.Name = "tabKlasik"
        Me.tabKlasik.Padding = New System.Windows.Forms.Padding(8)
        Me.tabKlasik.Size = New System.Drawing.Size(1444, 502)
        Me.tabKlasik.TabIndex = 0
        Me.tabKlasik.Text = "Klasik Senkronizasyon"
        Me.tabKlasik.UseVisualStyleBackColor = True
        '
        'grpKriterler
        '
        Me.grpKriterler.Controls.Add(Me.chkPazaryeriFiyatlari)
        Me.grpKriterler.Controls.Add(Me.chkTumStoklar)
        Me.grpKriterler.Controls.Add(Me.chkFiyatDegisenleri)
        Me.grpKriterler.Controls.Add(Me.chkMiktarDegisenleri)
        Me.grpKriterler.Controls.Add(Me.chkResimGonder)
        Me.grpKriterler.Controls.Add(Me.chkVaryantGuncelle)
        Me.grpKriterler.Controls.Add(Me.chkKategoriGuncelle)
        Me.grpKriterler.Controls.Add(Me.chkSiparisAl)
        Me.grpKriterler.Controls.Add(Me.chkTumSiparisler)
        Me.grpKriterler.Controls.Add(Me.chkKargoEkle)
        Me.grpKriterler.Controls.Add(Me.lblKargoMinTutar)
        Me.grpKriterler.Controls.Add(Me.txtKargoMinTutar)
        Me.grpKriterler.Controls.Add(Me.lblKargoStokKodu)
        Me.grpKriterler.Controls.Add(Me.txtKargoStokKodu)
        Me.grpKriterler.Controls.Add(Me.lblKargoFiyat)
        Me.grpKriterler.Controls.Add(Me.txtKargoFiyat)
        Me.grpKriterler.Location = New System.Drawing.Point(11, 11)
        Me.grpKriterler.Name = "grpKriterler"
        Me.grpKriterler.Size = New System.Drawing.Size(419, 430)
        Me.grpKriterler.TabIndex = 0
        Me.grpKriterler.TabStop = False
        Me.grpKriterler.Text = "Senkronizasyon Kriterleri"
        '
        'chkPazaryeriFiyatlari
        '
        Me.chkPazaryeriFiyatlari.AutoSize = True
        Me.chkPazaryeriFiyatlari.Location = New System.Drawing.Point(15, 254)
        Me.chkPazaryeriFiyatlari.Name = "chkPazaryeriFiyatlari"
        Me.chkPazaryeriFiyatlari.Size = New System.Drawing.Size(228, 24)
        Me.chkPazaryeriFiyatlari.TabIndex = 8
        Me.chkPazaryeriFiyatlari.Text = "Pazaryeri Fiyatlarini Gonder"
        Me.chkPazaryeriFiyatlari.UseVisualStyleBackColor = True
        '
        'chkTumStoklar
        '
        Me.chkTumStoklar.AutoSize = True
        Me.chkTumStoklar.Location = New System.Drawing.Point(15, 28)
        Me.chkTumStoklar.Name = "chkTumStoklar"
        Me.chkTumStoklar.Size = New System.Drawing.Size(181, 24)
        Me.chkTumStoklar.TabIndex = 0
        Me.chkTumStoklar.Text = "Tum Stoklari Gonder"
        Me.chkTumStoklar.UseVisualStyleBackColor = True
        '
        'chkFiyatDegisenleri
        '
        Me.chkFiyatDegisenleri.AutoSize = True
        Me.chkFiyatDegisenleri.Checked = True
        Me.chkFiyatDegisenleri.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkFiyatDegisenleri.Location = New System.Drawing.Point(15, 56)
        Me.chkFiyatDegisenleri.Name = "chkFiyatDegisenleri"
        Me.chkFiyatDegisenleri.Size = New System.Drawing.Size(213, 24)
        Me.chkFiyatDegisenleri.TabIndex = 1
        Me.chkFiyatDegisenleri.Text = "Fiyati Degisenleri Gonder"
        Me.chkFiyatDegisenleri.UseVisualStyleBackColor = True
        '
        'chkMiktarDegisenleri
        '
        Me.chkMiktarDegisenleri.AutoSize = True
        Me.chkMiktarDegisenleri.Checked = True
        Me.chkMiktarDegisenleri.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkMiktarDegisenleri.Location = New System.Drawing.Point(15, 84)
        Me.chkMiktarDegisenleri.Name = "chkMiktarDegisenleri"
        Me.chkMiktarDegisenleri.Size = New System.Drawing.Size(222, 24)
        Me.chkMiktarDegisenleri.TabIndex = 2
        Me.chkMiktarDegisenleri.Text = "Miktari Degisenleri Gonder"
        Me.chkMiktarDegisenleri.UseVisualStyleBackColor = True
        '
        'chkResimGonder
        '
        Me.chkResimGonder.AutoSize = True
        Me.chkResimGonder.Checked = True
        Me.chkResimGonder.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkResimGonder.Location = New System.Drawing.Point(15, 112)
        Me.chkResimGonder.Name = "chkResimGonder"
        Me.chkResimGonder.Size = New System.Drawing.Size(138, 24)
        Me.chkResimGonder.TabIndex = 3
        Me.chkResimGonder.Text = "Resim Gonder"
        Me.chkResimGonder.UseVisualStyleBackColor = True
        '
        'chkVaryantGuncelle
        '
        Me.chkVaryantGuncelle.AutoSize = True
        Me.chkVaryantGuncelle.Location = New System.Drawing.Point(15, 140)
        Me.chkVaryantGuncelle.Name = "chkVaryantGuncelle"
        Me.chkVaryantGuncelle.Size = New System.Drawing.Size(157, 24)
        Me.chkVaryantGuncelle.TabIndex = 4
        Me.chkVaryantGuncelle.Text = "Varyant Guncelle"
        Me.chkVaryantGuncelle.UseVisualStyleBackColor = True
        '
        'chkKategoriGuncelle
        '
        Me.chkKategoriGuncelle.AutoSize = True
        Me.chkKategoriGuncelle.Location = New System.Drawing.Point(15, 168)
        Me.chkKategoriGuncelle.Name = "chkKategoriGuncelle"
        Me.chkKategoriGuncelle.Size = New System.Drawing.Size(161, 24)
        Me.chkKategoriGuncelle.TabIndex = 5
        Me.chkKategoriGuncelle.Text = "Kategori Guncelle"
        Me.chkKategoriGuncelle.UseVisualStyleBackColor = True
        '
        'chkSiparisAl
        '
        Me.chkSiparisAl.AutoSize = True
        Me.chkSiparisAl.Checked = True
        Me.chkSiparisAl.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSiparisAl.Location = New System.Drawing.Point(15, 196)
        Me.chkSiparisAl.Name = "chkSiparisAl"
        Me.chkSiparisAl.Size = New System.Drawing.Size(121, 24)
        Me.chkSiparisAl.TabIndex = 6
        Me.chkSiparisAl.Text = "Siparisleri Al"
        Me.chkSiparisAl.UseVisualStyleBackColor = True
        '
        'chkTumSiparisler
        '
        Me.chkTumSiparisler.AutoSize = True
        Me.chkTumSiparisler.Location = New System.Drawing.Point(30, 224)
        Me.chkTumSiparisler.Name = "chkTumSiparisler"
        Me.chkTumSiparisler.Size = New System.Drawing.Size(236, 24)
        Me.chkTumSiparisler.TabIndex = 7
        Me.chkTumSiparisler.Text = "Tum Siparisleri Cek (Manuel)"
        Me.chkTumSiparisler.UseVisualStyleBackColor = True
        '
        'chkKargoEkle
        '
        Me.chkKargoEkle.AutoSize = True
        Me.chkKargoEkle.Location = New System.Drawing.Point(79, 313)
        Me.chkKargoEkle.Name = "chkKargoEkle"
        Me.chkKargoEkle.Size = New System.Drawing.Size(240, 24)
        Me.chkKargoEkle.TabIndex = 8
        Me.chkKargoEkle.Text = "Kargo Bedeli Ekle (Min Tutar)"
        Me.chkKargoEkle.UseVisualStyleBackColor = True
        '
        'lblKargoMinTutar
        '
        Me.lblKargoMinTutar.AutoSize = True
        Me.lblKargoMinTutar.Location = New System.Drawing.Point(30, 340)
        Me.lblKargoMinTutar.Name = "lblKargoMinTutar"
        Me.lblKargoMinTutar.Size = New System.Drawing.Size(111, 20)
        Me.lblKargoMinTutar.TabIndex = 9
        Me.lblKargoMinTutar.Text = "Min Tutar (TL):"
        '
        'txtKargoMinTutar
        '
        Me.txtKargoMinTutar.DecimalPlaces = 2
        Me.txtKargoMinTutar.Location = New System.Drawing.Point(203, 342)
        Me.txtKargoMinTutar.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.txtKargoMinTutar.Name = "txtKargoMinTutar"
        Me.txtKargoMinTutar.Size = New System.Drawing.Size(210, 26)
        Me.txtKargoMinTutar.TabIndex = 10
        Me.txtKargoMinTutar.Value = New Decimal(New Integer() {500, 0, 0, 0})
        '
        'lblKargoStokKodu
        '
        Me.lblKargoStokKodu.AutoSize = True
        Me.lblKargoStokKodu.Location = New System.Drawing.Point(30, 370)
        Me.lblKargoStokKodu.Name = "lblKargoStokKodu"
        Me.lblKargoStokKodu.Size = New System.Drawing.Size(110, 20)
        Me.lblKargoStokKodu.TabIndex = 11
        Me.lblKargoStokKodu.Text = "Kargo Barkod:"
        '
        'txtKargoStokKodu
        '
        Me.txtKargoStokKodu.Location = New System.Drawing.Point(203, 370)
        Me.txtKargoStokKodu.Name = "txtKargoStokKodu"
        Me.txtKargoStokKodu.Size = New System.Drawing.Size(210, 26)
        Me.txtKargoStokKodu.TabIndex = 12
        Me.txtKargoStokKodu.Text = "KARGO"
        '
        'lblKargoFiyat
        '
        Me.lblKargoFiyat.AutoSize = True
        Me.lblKargoFiyat.Location = New System.Drawing.Point(30, 400)
        Me.lblKargoFiyat.Name = "lblKargoFiyat"
        Me.lblKargoFiyat.Size = New System.Drawing.Size(125, 20)
        Me.lblKargoFiyat.TabIndex = 13
        Me.lblKargoFiyat.Text = "Kargo Fiyat (TL):"
        Me.lblKargoFiyat.Visible = False
        '
        'txtKargoFiyat
        '
        Me.txtKargoFiyat.DecimalPlaces = 2
        Me.txtKargoFiyat.Location = New System.Drawing.Point(203, 398)
        Me.txtKargoFiyat.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.txtKargoFiyat.Name = "txtKargoFiyat"
        Me.txtKargoFiyat.Size = New System.Drawing.Size(210, 26)
        Me.txtKargoFiyat.TabIndex = 14
        Me.txtKargoFiyat.Value = New Decimal(New Integer() {50, 0, 0, 0})
        Me.txtKargoFiyat.Visible = False
        '
        'grpTimerlar
        '
        Me.grpTimerlar.Controls.Add(Me.lblStokTimer)
        Me.grpTimerlar.Controls.Add(Me.txtStokTimerDakika)
        Me.grpTimerlar.Controls.Add(Me.lblSiparisTimer)
        Me.grpTimerlar.Controls.Add(Me.txtSiparisTimerDakika)
        Me.grpTimerlar.Location = New System.Drawing.Point(867, 25)
        Me.grpTimerlar.Name = "grpTimerlar"
        Me.grpTimerlar.Size = New System.Drawing.Size(250, 195)
        Me.grpTimerlar.TabIndex = 1
        Me.grpTimerlar.TabStop = False
        Me.grpTimerlar.Text = "Otomatik Kontrol Sureleri"
        '
        'lblStokTimer
        '
        Me.lblStokTimer.AutoSize = True
        Me.lblStokTimer.Location = New System.Drawing.Point(28, 46)
        Me.lblStokTimer.Name = "lblStokTimer"
        Me.lblStokTimer.Size = New System.Drawing.Size(212, 20)
        Me.lblStokTimer.TabIndex = 0
        Me.lblStokTimer.Text = "Stok Kontrol Suresi (Dakika):"
        '
        'txtStokTimerDakika
        '
        Me.txtStokTimerDakika.Location = New System.Drawing.Point(19, 72)
        Me.txtStokTimerDakika.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.txtStokTimerDakika.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtStokTimerDakika.Name = "txtStokTimerDakika"
        Me.txtStokTimerDakika.Size = New System.Drawing.Size(221, 26)
        Me.txtStokTimerDakika.TabIndex = 1
        Me.txtStokTimerDakika.Value = New Decimal(New Integer() {60, 0, 0, 0})
        '
        'lblSiparisTimer
        '
        Me.lblSiparisTimer.AutoSize = True
        Me.lblSiparisTimer.Location = New System.Drawing.Point(19, 129)
        Me.lblSiparisTimer.Name = "lblSiparisTimer"
        Me.lblSiparisTimer.Size = New System.Drawing.Size(227, 20)
        Me.lblSiparisTimer.TabIndex = 2
        Me.lblSiparisTimer.Text = "Siparis Kontrol Suresi (Dakika):"
        '
        'txtSiparisTimerDakika
        '
        Me.txtSiparisTimerDakika.Location = New System.Drawing.Point(19, 152)
        Me.txtSiparisTimerDakika.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.txtSiparisTimerDakika.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtSiparisTimerDakika.Name = "txtSiparisTimerDakika"
        Me.txtSiparisTimerDakika.Size = New System.Drawing.Size(225, 26)
        Me.txtSiparisTimerDakika.TabIndex = 3
        Me.txtSiparisTimerDakika.Value = New Decimal(New Integer() {30, 0, 0, 0})
        '
        'grpGonderimAyarlari
        '
        Me.grpGonderimAyarlari.Controls.Add(Me.chkTumunuGonder)
        Me.grpGonderimAyarlari.Controls.Add(Me.chkMarkaGonder)
        Me.grpGonderimAyarlari.Controls.Add(Me.chkKategoriGonder)
        Me.grpGonderimAyarlari.Controls.Add(Me.chkUzunAciklamaGonder)
        Me.grpGonderimAyarlari.Controls.Add(Me.chkKisaAciklamaGonder)
        Me.grpGonderimAyarlari.Controls.Add(Me.chkSEOGonder)
        Me.grpGonderimAyarlari.Controls.Add(Me.chkDesiGonder)
        Me.grpGonderimAyarlari.Location = New System.Drawing.Point(1123, 11)
        Me.grpGonderimAyarlari.Name = "grpGonderimAyarlari"
        Me.grpGonderimAyarlari.Size = New System.Drawing.Size(310, 209)
        Me.grpGonderimAyarlari.TabIndex = 6
        Me.grpGonderimAyarlari.TabStop = False
        Me.grpGonderimAyarlari.Text = "Gönderim Ayarlari"
        '
        'chkTumunuGonder
        '
        Me.chkTumunuGonder.AutoSize = True
        Me.chkTumunuGonder.Checked = True
        Me.chkTumunuGonder.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkTumunuGonder.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.chkTumunuGonder.ForeColor = System.Drawing.Color.DarkBlue
        Me.chkTumunuGonder.Location = New System.Drawing.Point(54, 44)
        Me.chkTumunuGonder.Name = "chkTumunuGonder"
        Me.chkTumunuGonder.Size = New System.Drawing.Size(195, 29)
        Me.chkTumunuGonder.TabIndex = 0
        Me.chkTumunuGonder.Text = "✓ Tümünü Gönder"
        Me.chkTumunuGonder.UseVisualStyleBackColor = True
        '
        'chkMarkaGonder
        '
        Me.chkMarkaGonder.AutoSize = True
        Me.chkMarkaGonder.Checked = True
        Me.chkMarkaGonder.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkMarkaGonder.Location = New System.Drawing.Point(15, 84)
        Me.chkMarkaGonder.Name = "chkMarkaGonder"
        Me.chkMarkaGonder.Size = New System.Drawing.Size(79, 24)
        Me.chkMarkaGonder.TabIndex = 1
        Me.chkMarkaGonder.Text = "Marka"
        Me.chkMarkaGonder.UseVisualStyleBackColor = True
        '
        'chkKategoriGonder
        '
        Me.chkKategoriGonder.AutoSize = True
        Me.chkKategoriGonder.Checked = True
        Me.chkKategoriGonder.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkKategoriGonder.Location = New System.Drawing.Point(15, 128)
        Me.chkKategoriGonder.Name = "chkKategoriGonder"
        Me.chkKategoriGonder.Size = New System.Drawing.Size(111, 24)
        Me.chkKategoriGonder.TabIndex = 2
        Me.chkKategoriGonder.Text = "Kategoriler"
        Me.chkKategoriGonder.UseVisualStyleBackColor = True
        '
        'chkUzunAciklamaGonder
        '
        Me.chkUzunAciklamaGonder.AutoSize = True
        Me.chkUzunAciklamaGonder.Checked = True
        Me.chkUzunAciklamaGonder.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkUzunAciklamaGonder.Location = New System.Drawing.Point(15, 168)
        Me.chkUzunAciklamaGonder.Name = "chkUzunAciklamaGonder"
        Me.chkUzunAciklamaGonder.Size = New System.Drawing.Size(141, 24)
        Me.chkUzunAciklamaGonder.TabIndex = 3
        Me.chkUzunAciklamaGonder.Text = "Uzun Aciklama"
        Me.chkUzunAciklamaGonder.UseVisualStyleBackColor = True
        '
        'chkKisaAciklamaGonder
        '
        Me.chkKisaAciklamaGonder.AutoSize = True
        Me.chkKisaAciklamaGonder.Checked = True
        Me.chkKisaAciklamaGonder.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkKisaAciklamaGonder.Location = New System.Drawing.Point(165, 84)
        Me.chkKisaAciklamaGonder.Name = "chkKisaAciklamaGonder"
        Me.chkKisaAciklamaGonder.Size = New System.Drawing.Size(133, 24)
        Me.chkKisaAciklamaGonder.TabIndex = 4
        Me.chkKisaAciklamaGonder.Text = "Kisa Aciklama"
        Me.chkKisaAciklamaGonder.UseVisualStyleBackColor = True
        '
        'chkSEOGonder
        '
        Me.chkSEOGonder.AutoSize = True
        Me.chkSEOGonder.Checked = True
        Me.chkSEOGonder.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSEOGonder.Location = New System.Drawing.Point(165, 128)
        Me.chkSEOGonder.Name = "chkSEOGonder"
        Me.chkSEOGonder.Size = New System.Drawing.Size(122, 24)
        Me.chkSEOGonder.TabIndex = 5
        Me.chkSEOGonder.Text = "SEO Bilgileri"
        Me.chkSEOGonder.UseVisualStyleBackColor = True
        '
        'chkDesiGonder
        '
        Me.chkDesiGonder.AutoSize = True
        Me.chkDesiGonder.Checked = True
        Me.chkDesiGonder.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDesiGonder.Location = New System.Drawing.Point(165, 168)
        Me.chkDesiGonder.Name = "chkDesiGonder"
        Me.chkDesiGonder.Size = New System.Drawing.Size(113, 24)
        Me.chkDesiGonder.TabIndex = 6
        Me.chkDesiGonder.Text = "Desi/Agirlik"
        Me.chkDesiGonder.UseVisualStyleBackColor = True
        '
        'grpGonderimModu
        '
        Me.grpGonderimModu.Controls.Add(Me.rdoApiDogrudan)
        Me.grpGonderimModu.Controls.Add(Me.rdoPhpEntegrasyon)
        Me.grpGonderimModu.ForeColor = System.Drawing.Color.DarkBlue
        Me.grpGonderimModu.Location = New System.Drawing.Point(440, 11)
        Me.grpGonderimModu.Name = "grpGonderimModu"
        Me.grpGonderimModu.Size = New System.Drawing.Size(421, 86)
        Me.grpGonderimModu.TabIndex = 7
        Me.grpGonderimModu.TabStop = False
        Me.grpGonderimModu.Text = "Gönderim Modu"
        '
        'rdoApiDogrudan
        '
        Me.rdoApiDogrudan.AutoSize = True
        Me.rdoApiDogrudan.Checked = True
        Me.rdoApiDogrudan.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.rdoApiDogrudan.ForeColor = System.Drawing.Color.Green
        Me.rdoApiDogrudan.Location = New System.Drawing.Point(18, 38)
        Me.rdoApiDogrudan.Name = "rdoApiDogrudan"
        Me.rdoApiDogrudan.Size = New System.Drawing.Size(171, 29)
        Me.rdoApiDogrudan.TabIndex = 0
        Me.rdoApiDogrudan.TabStop = True
        Me.rdoApiDogrudan.Text = "API (Doğrudan)"
        Me.rdoApiDogrudan.UseVisualStyleBackColor = True
        '
        'rdoPhpEntegrasyon
        '
        Me.rdoPhpEntegrasyon.AutoSize = True
        Me.rdoPhpEntegrasyon.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.rdoPhpEntegrasyon.ForeColor = System.Drawing.Color.DarkOrange
        Me.rdoPhpEntegrasyon.Location = New System.Drawing.Point(231, 38)
        Me.rdoPhpEntegrasyon.Name = "rdoPhpEntegrasyon"
        Me.rdoPhpEntegrasyon.Size = New System.Drawing.Size(184, 29)
        Me.rdoPhpEntegrasyon.TabIndex = 1
        Me.rdoPhpEntegrasyon.Text = "PHP Entegrasyon"
        Me.rdoPhpEntegrasyon.UseVisualStyleBackColor = True
        '
        'grpTarihliSiparis
        '
        Me.grpTarihliSiparis.Controls.Add(Me.lblFiyatTipi)
        Me.grpTarihliSiparis.Controls.Add(Me.lblBaslangicTarihi)
        Me.grpTarihliSiparis.Controls.Add(Me.cmbFiyatTipi)
        Me.grpTarihliSiparis.Controls.Add(Me.dtpBaslangic)
        Me.grpTarihliSiparis.Controls.Add(Me.lblBitisTarihi)
        Me.grpTarihliSiparis.Controls.Add(Me.dtpBitis)
        Me.grpTarihliSiparis.Controls.Add(Me.lblSiparisStatus)
        Me.grpTarihliSiparis.Controls.Add(Me.cmbSiparisStatus)
        Me.grpTarihliSiparis.Controls.Add(Me.btnTarihliSiparisCek)
        Me.grpTarihliSiparis.Controls.Add(Me.btnEksikBilgiGuncelle)
        Me.grpTarihliSiparis.ForeColor = System.Drawing.Color.DarkGreen
        Me.grpTarihliSiparis.Location = New System.Drawing.Point(867, 235)
        Me.grpTarihliSiparis.Name = "grpTarihliSiparis"
        Me.grpTarihliSiparis.Size = New System.Drawing.Size(566, 264)
        Me.grpTarihliSiparis.TabIndex = 8
        Me.grpTarihliSiparis.TabStop = False
        Me.grpTarihliSiparis.Text = "Tarih Araliginda Siparis Cek"
        '
        'lblFiyatTipi
        '
        Me.lblFiyatTipi.AutoSize = True
        Me.lblFiyatTipi.Location = New System.Drawing.Point(28, 212)
        Me.lblFiyatTipi.Name = "lblFiyatTipi"
        Me.lblFiyatTipi.Size = New System.Drawing.Size(75, 20)
        Me.lblFiyatTipi.TabIndex = 15
        Me.lblFiyatTipi.Text = "Fiyat Tipi:"
        '
        'lblBaslangicTarihi
        '
        Me.lblBaslangicTarihi.AutoSize = True
        Me.lblBaslangicTarihi.ForeColor = System.Drawing.Color.Black
        Me.lblBaslangicTarihi.Location = New System.Drawing.Point(28, 48)
        Me.lblBaslangicTarihi.Name = "lblBaslangicTarihi"
        Me.lblBaslangicTarihi.Size = New System.Drawing.Size(82, 20)
        Me.lblBaslangicTarihi.TabIndex = 0
        Me.lblBaslangicTarihi.Text = "Baslangic:"
        '
        'cmbFiyatTipi
        '
        Me.cmbFiyatTipi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFiyatTipi.FormattingEnabled = True
        Me.cmbFiyatTipi.Location = New System.Drawing.Point(131, 204)
        Me.cmbFiyatTipi.Name = "cmbFiyatTipi"
        Me.cmbFiyatTipi.Size = New System.Drawing.Size(165, 28)
        Me.cmbFiyatTipi.TabIndex = 16
        '
        'dtpBaslangic
        '
        Me.dtpBaslangic.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpBaslangic.Location = New System.Drawing.Point(131, 43)
        Me.dtpBaslangic.Name = "dtpBaslangic"
        Me.dtpBaslangic.Size = New System.Drawing.Size(165, 26)
        Me.dtpBaslangic.TabIndex = 1
        '
        'lblBitisTarihi
        '
        Me.lblBitisTarihi.AutoSize = True
        Me.lblBitisTarihi.ForeColor = System.Drawing.Color.Black
        Me.lblBitisTarihi.Location = New System.Drawing.Point(294, 46)
        Me.lblBitisTarihi.Name = "lblBitisTarihi"
        Me.lblBitisTarihi.Size = New System.Drawing.Size(43, 20)
        Me.lblBitisTarihi.TabIndex = 2
        Me.lblBitisTarihi.Text = "Bitis:"
        '
        'dtpBitis
        '
        Me.dtpBitis.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpBitis.Location = New System.Drawing.Point(344, 43)
        Me.dtpBitis.Name = "dtpBitis"
        Me.dtpBitis.Size = New System.Drawing.Size(153, 26)
        Me.dtpBitis.TabIndex = 3
        '
        'lblSiparisStatus
        '
        Me.lblSiparisStatus.AutoSize = True
        Me.lblSiparisStatus.ForeColor = System.Drawing.Color.Black
        Me.lblSiparisStatus.Location = New System.Drawing.Point(26, 119)
        Me.lblSiparisStatus.Name = "lblSiparisStatus"
        Me.lblSiparisStatus.Size = New System.Drawing.Size(60, 20)
        Me.lblSiparisStatus.TabIndex = 4
        Me.lblSiparisStatus.Text = "Status:"
        '
        'cmbSiparisStatus
        '
        Me.cmbSiparisStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSiparisStatus.FormattingEnabled = True
        Me.cmbSiparisStatus.Items.AddRange(New Object() {"Tumu (0,1,2)", "0 - Yeni", "1 - Onaylandi", "2 - Hazirlaniyor"})
        Me.cmbSiparisStatus.Location = New System.Drawing.Point(131, 117)
        Me.cmbSiparisStatus.Name = "cmbSiparisStatus"
        Me.cmbSiparisStatus.Size = New System.Drawing.Size(165, 28)
        Me.cmbSiparisStatus.TabIndex = 5
        '
        'btnTarihliSiparisCek
        '
        Me.btnTarihliSiparisCek.BackColor = System.Drawing.Color.LightBlue
        Me.btnTarihliSiparisCek.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnTarihliSiparisCek.ForeColor = System.Drawing.Color.Black
        Me.btnTarihliSiparisCek.Location = New System.Drawing.Point(344, 102)
        Me.btnTarihliSiparisCek.Name = "btnTarihliSiparisCek"
        Me.btnTarihliSiparisCek.Size = New System.Drawing.Size(210, 55)
        Me.btnTarihliSiparisCek.TabIndex = 6
        Me.btnTarihliSiparisCek.Text = "Tarihe Gore Siparis Cek"
        Me.btnTarihliSiparisCek.UseVisualStyleBackColor = False
        '
        'btnEksikBilgiGuncelle
        '
        Me.btnEksikBilgiGuncelle.BackColor = System.Drawing.Color.LightGreen
        Me.btnEksikBilgiGuncelle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnEksikBilgiGuncelle.ForeColor = System.Drawing.Color.Black
        Me.btnEksikBilgiGuncelle.Location = New System.Drawing.Point(344, 174)
        Me.btnEksikBilgiGuncelle.Name = "btnEksikBilgiGuncelle"
        Me.btnEksikBilgiGuncelle.Size = New System.Drawing.Size(210, 68)
        Me.btnEksikBilgiGuncelle.TabIndex = 7
        Me.btnEksikBilgiGuncelle.Text = "Eksik Sipariş Bilgileri Güncelle"
        Me.btnEksikBilgiGuncelle.UseVisualStyleBackColor = False
        '
        'btnManuelBaslat
        '
        Me.btnManuelBaslat.BackColor = System.Drawing.Color.Maroon
        Me.btnManuelBaslat.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnManuelBaslat.Location = New System.Drawing.Point(440, 268)
        Me.btnManuelBaslat.Name = "btnManuelBaslat"
        Me.btnManuelBaslat.Size = New System.Drawing.Size(183, 106)
        Me.btnManuelBaslat.TabIndex = 2
        Me.btnManuelBaslat.Text = "Manuel Calistir"
        Me.btnManuelBaslat.UseVisualStyleBackColor = False
        '
        'btnOtomatikBaslat
        '
        Me.btnOtomatikBaslat.BackColor = System.Drawing.Color.Lime
        Me.btnOtomatikBaslat.Location = New System.Drawing.Point(671, 112)
        Me.btnOtomatikBaslat.Name = "btnOtomatikBaslat"
        Me.btnOtomatikBaslat.Size = New System.Drawing.Size(183, 105)
        Me.btnOtomatikBaslat.TabIndex = 3
        Me.btnOtomatikBaslat.Text = "Otomatik Baslat"
        Me.btnOtomatikBaslat.UseVisualStyleBackColor = False
        '
        'btnDurdur
        '
        Me.btnDurdur.BackColor = System.Drawing.Color.Red
        Me.btnDurdur.Enabled = False
        Me.btnDurdur.Location = New System.Drawing.Point(436, 403)
        Me.btnDurdur.Name = "btnDurdur"
        Me.btnDurdur.Size = New System.Drawing.Size(431, 99)
        Me.btnDurdur.TabIndex = 4
        Me.btnDurdur.Text = "Durdur"
        Me.btnDurdur.UseVisualStyleBackColor = False
        '
        'btnWebdeOlmayanlar
        '
        Me.btnWebdeOlmayanlar.BackColor = System.Drawing.Color.DarkGreen
        Me.btnWebdeOlmayanlar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnWebdeOlmayanlar.Location = New System.Drawing.Point(671, 273)
        Me.btnWebdeOlmayanlar.Name = "btnWebdeOlmayanlar"
        Me.btnWebdeOlmayanlar.Size = New System.Drawing.Size(183, 106)
        Me.btnWebdeOlmayanlar.TabIndex = 6
        Me.btnWebdeOlmayanlar.Text = "Olmayanlari Gonder"
        Me.btnWebdeOlmayanlar.UseVisualStyleBackColor = False
        '
        'btnHataliUrunler
        '
        Me.btnHataliUrunler.BackColor = System.Drawing.Color.MistyRose
        Me.btnHataliUrunler.Location = New System.Drawing.Point(440, 110)
        Me.btnHataliUrunler.Name = "btnHataliUrunler"
        Me.btnHataliUrunler.Size = New System.Drawing.Size(183, 105)
        Me.btnHataliUrunler.TabIndex = 5
        Me.btnHataliUrunler.Text = "Hatali Urunler"
        Me.btnHataliUrunler.UseVisualStyleBackColor = False
        '
        'tabTrigger
        '
        Me.tabTrigger.Controls.Add(Me.grpTriggerAyarlar)
        Me.tabTrigger.Controls.Add(Me.grpTriggerTimer)
        Me.tabTrigger.Controls.Add(Me.grpTriggerIstatistik)
        Me.tabTrigger.Controls.Add(Me.grpManuelGuncelleme)
        Me.tabTrigger.Controls.Add(Me.btnTriggerBaslat)
        Me.tabTrigger.Controls.Add(Me.btnTriggerDurdur)
        Me.tabTrigger.Controls.Add(Me.lblTriggerBilgi)
        Me.tabTrigger.Controls.Add(Me.lblTriggerDurum)
        Me.tabTrigger.Location = New System.Drawing.Point(4, 29)
        Me.tabTrigger.Name = "tabTrigger"
        Me.tabTrigger.Padding = New System.Windows.Forms.Padding(8)
        Me.tabTrigger.Size = New System.Drawing.Size(1444, 502)
        Me.tabTrigger.TabIndex = 1
        Me.tabTrigger.Text = "Trigger Tabanli (Hizli)"
        Me.tabTrigger.UseVisualStyleBackColor = True
        '
        'grpTriggerAyarlar
        '
        Me.grpTriggerAyarlar.Controls.Add(Me.chkTriggerAktif)
        Me.grpTriggerAyarlar.Controls.Add(Me.chkTriggerStok)
        Me.grpTriggerAyarlar.Controls.Add(Me.chkTriggerFiyat)
        Me.grpTriggerAyarlar.Controls.Add(Me.chkTriggerResim)
        Me.grpTriggerAyarlar.Controls.Add(Me.chkTriggerKategori)
        Me.grpTriggerAyarlar.Location = New System.Drawing.Point(11, 11)
        Me.grpTriggerAyarlar.Name = "grpTriggerAyarlar"
        Me.grpTriggerAyarlar.Size = New System.Drawing.Size(280, 315)
        Me.grpTriggerAyarlar.TabIndex = 0
        Me.grpTriggerAyarlar.TabStop = False
        Me.grpTriggerAyarlar.Text = "Trigger Senkronizasyon"
        '
        'chkTriggerAktif
        '
        Me.chkTriggerAktif.AutoSize = True
        Me.chkTriggerAktif.Checked = True
        Me.chkTriggerAktif.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkTriggerAktif.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.chkTriggerAktif.ForeColor = System.Drawing.Color.Green
        Me.chkTriggerAktif.Location = New System.Drawing.Point(15, 55)
        Me.chkTriggerAktif.Name = "chkTriggerAktif"
        Me.chkTriggerAktif.Size = New System.Drawing.Size(218, 26)
        Me.chkTriggerAktif.TabIndex = 0
        Me.chkTriggerAktif.Text = "Trigger Sistemi Aktif"
        Me.chkTriggerAktif.UseVisualStyleBackColor = True
        '
        'chkTriggerStok
        '
        Me.chkTriggerStok.AutoSize = True
        Me.chkTriggerStok.Checked = True
        Me.chkTriggerStok.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkTriggerStok.Location = New System.Drawing.Point(15, 116)
        Me.chkTriggerStok.Name = "chkTriggerStok"
        Me.chkTriggerStok.Size = New System.Drawing.Size(212, 24)
        Me.chkTriggerStok.TabIndex = 1
        Me.chkTriggerStok.Text = "Stok Degisikliklerini Algila"
        Me.chkTriggerStok.UseVisualStyleBackColor = True
        '
        'chkTriggerFiyat
        '
        Me.chkTriggerFiyat.AutoSize = True
        Me.chkTriggerFiyat.Checked = True
        Me.chkTriggerFiyat.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkTriggerFiyat.Location = New System.Drawing.Point(15, 165)
        Me.chkTriggerFiyat.Name = "chkTriggerFiyat"
        Me.chkTriggerFiyat.Size = New System.Drawing.Size(213, 24)
        Me.chkTriggerFiyat.TabIndex = 2
        Me.chkTriggerFiyat.Text = "Fiyat Degisikliklerini Algila"
        Me.chkTriggerFiyat.UseVisualStyleBackColor = True
        '
        'chkTriggerResim
        '
        Me.chkTriggerResim.AutoSize = True
        Me.chkTriggerResim.Checked = True
        Me.chkTriggerResim.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkTriggerResim.Location = New System.Drawing.Point(15, 217)
        Me.chkTriggerResim.Name = "chkTriggerResim"
        Me.chkTriggerResim.Size = New System.Drawing.Size(224, 24)
        Me.chkTriggerResim.TabIndex = 3
        Me.chkTriggerResim.Text = "Resim Degisikliklerini Algila"
        Me.chkTriggerResim.UseVisualStyleBackColor = True
        '
        'chkTriggerKategori
        '
        Me.chkTriggerKategori.AutoSize = True
        Me.chkTriggerKategori.Checked = True
        Me.chkTriggerKategori.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkTriggerKategori.Location = New System.Drawing.Point(15, 270)
        Me.chkTriggerKategori.Name = "chkTriggerKategori"
        Me.chkTriggerKategori.Size = New System.Drawing.Size(238, 24)
        Me.chkTriggerKategori.TabIndex = 4
        Me.chkTriggerKategori.Text = "Kategori Degisikliklerini Algila"
        Me.chkTriggerKategori.UseVisualStyleBackColor = True
        '
        'grpTriggerTimer
        '
        Me.grpTriggerTimer.Controls.Add(Me.lblTriggerTimer)
        Me.grpTriggerTimer.Controls.Add(Me.txtTriggerTimerDakika)
        Me.grpTriggerTimer.Location = New System.Drawing.Point(305, 11)
        Me.grpTriggerTimer.Name = "grpTriggerTimer"
        Me.grpTriggerTimer.Size = New System.Drawing.Size(220, 140)
        Me.grpTriggerTimer.TabIndex = 1
        Me.grpTriggerTimer.TabStop = False
        Me.grpTriggerTimer.Text = "Kontrol Suresi"
        '
        'lblTriggerTimer
        '
        Me.lblTriggerTimer.AutoSize = True
        Me.lblTriggerTimer.Location = New System.Drawing.Point(25, 55)
        Me.lblTriggerTimer.Name = "lblTriggerTimer"
        Me.lblTriggerTimer.Size = New System.Drawing.Size(175, 20)
        Me.lblTriggerTimer.TabIndex = 0
        Me.lblTriggerTimer.Text = "Kontrol Suresi (Dakika):"
        '
        'txtTriggerTimerDakika
        '
        Me.txtTriggerTimerDakika.Location = New System.Drawing.Point(14, 90)
        Me.txtTriggerTimerDakika.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.txtTriggerTimerDakika.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtTriggerTimerDakika.Name = "txtTriggerTimerDakika"
        Me.txtTriggerTimerDakika.Size = New System.Drawing.Size(200, 26)
        Me.txtTriggerTimerDakika.TabIndex = 1
        Me.txtTriggerTimerDakika.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'grpTriggerIstatistik
        '
        Me.grpTriggerIstatistik.Controls.Add(Me.lblBekleyenStok)
        Me.grpTriggerIstatistik.Controls.Add(Me.lblBekleyenFiyat)
        Me.grpTriggerIstatistik.Controls.Add(Me.lblBekleyenResim)
        Me.grpTriggerIstatistik.Controls.Add(Me.lblBekleyenKategori)
        Me.grpTriggerIstatistik.Controls.Add(Me.btnTriggerYenile)
        Me.grpTriggerIstatistik.Location = New System.Drawing.Point(577, 20)
        Me.grpTriggerIstatistik.Name = "grpTriggerIstatistik"
        Me.grpTriggerIstatistik.Size = New System.Drawing.Size(587, 180)
        Me.grpTriggerIstatistik.TabIndex = 2
        Me.grpTriggerIstatistik.TabStop = False
        Me.grpTriggerIstatistik.Text = "Bekleyen Degisiklikler"
        '
        'lblBekleyenStok
        '
        Me.lblBekleyenStok.AutoSize = True
        Me.lblBekleyenStok.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.lblBekleyenStok.Location = New System.Drawing.Point(15, 30)
        Me.lblBekleyenStok.Name = "lblBekleyenStok"
        Me.lblBekleyenStok.Size = New System.Drawing.Size(152, 20)
        Me.lblBekleyenStok.TabIndex = 0
        Me.lblBekleyenStok.Text = "Stok: 0 urun bekliyor"
        '
        'lblBekleyenFiyat
        '
        Me.lblBekleyenFiyat.AutoSize = True
        Me.lblBekleyenFiyat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.lblBekleyenFiyat.Location = New System.Drawing.Point(15, 55)
        Me.lblBekleyenFiyat.Name = "lblBekleyenFiyat"
        Me.lblBekleyenFiyat.Size = New System.Drawing.Size(153, 20)
        Me.lblBekleyenFiyat.TabIndex = 1
        Me.lblBekleyenFiyat.Text = "Fiyat: 0 urun bekliyor"
        '
        'lblBekleyenResim
        '
        Me.lblBekleyenResim.AutoSize = True
        Me.lblBekleyenResim.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.lblBekleyenResim.Location = New System.Drawing.Point(15, 80)
        Me.lblBekleyenResim.Name = "lblBekleyenResim"
        Me.lblBekleyenResim.Size = New System.Drawing.Size(164, 20)
        Me.lblBekleyenResim.TabIndex = 2
        Me.lblBekleyenResim.Text = "Resim: 0 urun bekliyor"
        '
        'lblBekleyenKategori
        '
        Me.lblBekleyenKategori.AutoSize = True
        Me.lblBekleyenKategori.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.lblBekleyenKategori.Location = New System.Drawing.Point(15, 111)
        Me.lblBekleyenKategori.Name = "lblBekleyenKategori"
        Me.lblBekleyenKategori.Size = New System.Drawing.Size(178, 20)
        Me.lblBekleyenKategori.TabIndex = 3
        Me.lblBekleyenKategori.Text = "Kategori: 0 urun bekliyor"
        '
        'btnTriggerYenile
        '
        Me.btnTriggerYenile.Location = New System.Drawing.Point(19, 141)
        Me.btnTriggerYenile.Name = "btnTriggerYenile"
        Me.btnTriggerYenile.Size = New System.Drawing.Size(562, 30)
        Me.btnTriggerYenile.TabIndex = 4
        Me.btnTriggerYenile.Text = "Yenile"
        Me.btnTriggerYenile.UseVisualStyleBackColor = True
        '
        'grpManuelGuncelleme
        '
        Me.grpManuelGuncelleme.Controls.Add(Me.btnSinifEsleme)
        Me.grpManuelGuncelleme.Controls.Add(Me.btnKategoriGuncelle)
        Me.grpManuelGuncelleme.Controls.Add(Me.btnResimGuncelle)
        Me.grpManuelGuncelleme.Location = New System.Drawing.Point(1170, 11)
        Me.grpManuelGuncelleme.Name = "grpManuelGuncelleme"
        Me.grpManuelGuncelleme.Size = New System.Drawing.Size(271, 260)
        Me.grpManuelGuncelleme.TabIndex = 5
        Me.grpManuelGuncelleme.TabStop = False
        Me.grpManuelGuncelleme.Text = "Manuel Guncelleme"
        '
        'btnSinifEsleme
        '
        Me.btnSinifEsleme.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSinifEsleme.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSinifEsleme.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnSinifEsleme.ForeColor = System.Drawing.Color.White
        Me.btnSinifEsleme.Location = New System.Drawing.Point(44, 191)
        Me.btnSinifEsleme.Name = "btnSinifEsleme"
        Me.btnSinifEsleme.Size = New System.Drawing.Size(200, 50)
        Me.btnSinifEsleme.TabIndex = 2
        Me.btnSinifEsleme.Text = "Sinif Eslestirme"
        Me.btnSinifEsleme.UseVisualStyleBackColor = False
        '
        'btnKategoriGuncelle
        '
        Me.btnKategoriGuncelle.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnKategoriGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKategoriGuncelle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnKategoriGuncelle.ForeColor = System.Drawing.Color.White
        Me.btnKategoriGuncelle.Location = New System.Drawing.Point(44, 42)
        Me.btnKategoriGuncelle.Name = "btnKategoriGuncelle"
        Me.btnKategoriGuncelle.Size = New System.Drawing.Size(200, 50)
        Me.btnKategoriGuncelle.TabIndex = 0
        Me.btnKategoriGuncelle.Text = "Kategorileri Guncelle"
        Me.btnKategoriGuncelle.UseVisualStyleBackColor = False
        '
        'btnResimGuncelle
        '
        Me.btnResimGuncelle.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.btnResimGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnResimGuncelle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnResimGuncelle.ForeColor = System.Drawing.Color.White
        Me.btnResimGuncelle.Location = New System.Drawing.Point(44, 116)
        Me.btnResimGuncelle.Name = "btnResimGuncelle"
        Me.btnResimGuncelle.Size = New System.Drawing.Size(200, 50)
        Me.btnResimGuncelle.TabIndex = 1
        Me.btnResimGuncelle.Text = "Resimleri Guncelle"
        Me.btnResimGuncelle.UseVisualStyleBackColor = False
        '
        'btnTriggerBaslat
        '
        Me.btnTriggerBaslat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnTriggerBaslat.ForeColor = System.Drawing.Color.Green
        Me.btnTriggerBaslat.Location = New System.Drawing.Point(11, 359)
        Me.btnTriggerBaslat.Name = "btnTriggerBaslat"
        Me.btnTriggerBaslat.Size = New System.Drawing.Size(247, 60)
        Me.btnTriggerBaslat.TabIndex = 3
        Me.btnTriggerBaslat.Text = "Trigger Baslat"
        Me.btnTriggerBaslat.UseVisualStyleBackColor = True
        '
        'btnTriggerDurdur
        '
        Me.btnTriggerDurdur.Enabled = False
        Me.btnTriggerDurdur.Location = New System.Drawing.Point(319, 359)
        Me.btnTriggerDurdur.Name = "btnTriggerDurdur"
        Me.btnTriggerDurdur.Size = New System.Drawing.Size(200, 60)
        Me.btnTriggerDurdur.TabIndex = 4
        Me.btnTriggerDurdur.Text = "Durdur"
        Me.btnTriggerDurdur.UseVisualStyleBackColor = True
        '
        'lblTriggerBilgi
        '
        Me.lblTriggerBilgi.AutoSize = True
        Me.lblTriggerBilgi.ForeColor = System.Drawing.Color.Gray
        Me.lblTriggerBilgi.Location = New System.Drawing.Point(301, 211)
        Me.lblTriggerBilgi.Name = "lblTriggerBilgi"
        Me.lblTriggerBilgi.Size = New System.Drawing.Size(243, 60)
        Me.lblTriggerBilgi.TabIndex = 5
        Me.lblTriggerBilgi.Text = "Trigger sistemi veritabanindaki" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "degisiklikleri otomatik algilar ve" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "sadece degis" &
    "en urunleri gonderir."
        '
        'lblTriggerDurum
        '
        Me.lblTriggerDurum.AutoSize = True
        Me.lblTriggerDurum.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblTriggerDurum.ForeColor = System.Drawing.Color.Gray
        Me.lblTriggerDurum.Location = New System.Drawing.Point(1210, 416)
        Me.lblTriggerDurum.Name = "lblTriggerDurum"
        Me.lblTriggerDurum.Size = New System.Drawing.Size(178, 22)
        Me.lblTriggerDurum.TabIndex = 6
        Me.lblTriggerDurum.Text = "Durum: Beklemede"
        '
        'lblDurum
        '
        Me.lblDurum.AutoSize = True
        Me.lblDurum.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblDurum.Location = New System.Drawing.Point(4, 550)
        Me.lblDurum.Name = "lblDurum"
        Me.lblDurum.Size = New System.Drawing.Size(195, 25)
        Me.lblDurum.TabIndex = 5
        Me.lblDurum.Text = "Durum: Beklemede"
        '
        'prgKlasik
        '
        Me.prgKlasik.Location = New System.Drawing.Point(0, 600)
        Me.prgKlasik.Name = "prgKlasik"
        Me.prgKlasik.Size = New System.Drawing.Size(688, 28)
        Me.prgKlasik.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.prgKlasik.TabIndex = 7
        '
        'lblKlasikSayac
        '
        Me.lblKlasikSayac.AutoSize = True
        Me.lblKlasikSayac.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblKlasikSayac.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblKlasikSayac.Location = New System.Drawing.Point(102, 575)
        Me.lblKlasikSayac.Name = "lblKlasikSayac"
        Me.lblKlasikSayac.Size = New System.Drawing.Size(275, 22)
        Me.lblKlasikSayac.TabIndex = 9
        Me.lblKlasikSayac.Text = "Siparis: 0/0 | Basarili: 0 | Kalan: 0"
        '
        'prgTrigger
        '
        Me.prgTrigger.Location = New System.Drawing.Point(709, 600)
        Me.prgTrigger.Name = "prgTrigger"
        Me.prgTrigger.Size = New System.Drawing.Size(755, 28)
        Me.prgTrigger.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.prgTrigger.TabIndex = 8
        '
        'lblTriggerSayac
        '
        Me.lblTriggerSayac.AutoSize = True
        Me.lblTriggerSayac.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblTriggerSayac.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblTriggerSayac.Location = New System.Drawing.Point(919, 575)
        Me.lblTriggerSayac.Name = "lblTriggerSayac"
        Me.lblTriggerSayac.Size = New System.Drawing.Size(288, 22)
        Me.lblTriggerSayac.TabIndex = 10
        Me.lblTriggerSayac.Text = "Urun: 0/0 | Gonderilen: 0 | Kalan: 0"
        '
        'txtLog
        '
        Me.txtLog.Location = New System.Drawing.Point(0, 634)
        Me.txtLog.Multiline = True
        Me.txtLog.Name = "txtLog"
        Me.txtLog.ReadOnly = True
        Me.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtLog.Size = New System.Drawing.Size(1464, 434)
        Me.txtLog.TabIndex = 6
        '
        'frm_qukaGonder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1464, 1064)
        Me.Controls.Add(Me.txtLog)
        Me.Controls.Add(Me.lblTriggerSayac)
        Me.Controls.Add(Me.prgTrigger)
        Me.Controls.Add(Me.lblKlasikSayac)
        Me.Controls.Add(Me.prgKlasik)
        Me.Controls.Add(Me.lblDurum)
        Me.Controls.Add(Me.tabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_qukaGonder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "E-Ticaret Senkronizasyon Yonetimi"
        Me.tabControl1.ResumeLayout(False)
        Me.tabKlasik.ResumeLayout(False)
        Me.grpKriterler.ResumeLayout(False)
        Me.grpKriterler.PerformLayout()
        CType(Me.txtKargoMinTutar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKargoFiyat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpTimerlar.ResumeLayout(False)
        Me.grpTimerlar.PerformLayout()
        CType(Me.txtStokTimerDakika, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSiparisTimerDakika, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpGonderimAyarlari.ResumeLayout(False)
        Me.grpGonderimAyarlari.PerformLayout()
        Me.grpGonderimModu.ResumeLayout(False)
        Me.grpGonderimModu.PerformLayout()
        Me.grpTarihliSiparis.ResumeLayout(False)
        Me.grpTarihliSiparis.PerformLayout()
        Me.tabTrigger.ResumeLayout(False)
        Me.tabTrigger.PerformLayout()
        Me.grpTriggerAyarlar.ResumeLayout(False)
        Me.grpTriggerAyarlar.PerformLayout()
        Me.grpTriggerTimer.ResumeLayout(False)
        Me.grpTriggerTimer.PerformLayout()
        CType(Me.txtTriggerTimerDakika, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpTriggerIstatistik.ResumeLayout(False)
        Me.grpTriggerIstatistik.PerformLayout()
        Me.grpManuelGuncelleme.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tabControl1 As TabControl
    Friend WithEvents tabKlasik As TabPage
    Friend WithEvents tabTrigger As TabPage
    Friend WithEvents grpKriterler As GroupBox
    Friend WithEvents chkTumStoklar As CheckBox
    Friend WithEvents chkFiyatDegisenleri As CheckBox
    Friend WithEvents chkMiktarDegisenleri As CheckBox
    Friend WithEvents chkResimGonder As CheckBox
    Friend WithEvents chkVaryantGuncelle As CheckBox
    Friend WithEvents chkKategoriGuncelle As CheckBox
    Friend WithEvents chkSiparisAl As CheckBox
    Friend WithEvents chkTumSiparisler As CheckBox
    Friend WithEvents chkKargoEkle As CheckBox
    Friend WithEvents lblKargoMinTutar As Label
    Friend WithEvents txtKargoMinTutar As NumericUpDown
    Friend WithEvents lblKargoStokKodu As Label
    Friend WithEvents txtKargoStokKodu As TextBox
    Friend WithEvents lblKargoFiyat As Label
    Friend WithEvents txtKargoFiyat As NumericUpDown
    Friend WithEvents chkPazaryeriFiyatlari As CheckBox
    Friend WithEvents lblFiyatTipi As Label
    Friend WithEvents cmbFiyatTipi As ComboBox
    Friend WithEvents grpTimerlar As GroupBox
    Friend WithEvents lblStokTimer As Label
    Friend WithEvents txtStokTimerDakika As NumericUpDown
    Friend WithEvents lblSiparisTimer As Label
    Friend WithEvents txtSiparisTimerDakika As NumericUpDown
    Friend WithEvents btnManuelBaslat As Button
    Friend WithEvents btnOtomatikBaslat As Button
    Friend WithEvents btnDurdur As Button
    Friend WithEvents btnHataliUrunler As Button
    Friend WithEvents btnWebdeOlmayanlar As Button
    Friend WithEvents lblDurum As Label
    Friend WithEvents prgKlasik As ProgressBar
    Friend WithEvents lblKlasikSayac As Label
    Friend WithEvents prgTrigger As ProgressBar
    Friend WithEvents lblTriggerSayac As Label
    Friend WithEvents txtLog As TextBox
    Friend WithEvents grpTriggerAyarlar As GroupBox
    Friend WithEvents chkTriggerAktif As CheckBox
    Friend WithEvents chkTriggerStok As CheckBox
    Friend WithEvents chkTriggerFiyat As CheckBox
    Friend WithEvents chkTriggerResim As CheckBox
    Friend WithEvents chkTriggerKategori As CheckBox
    Friend WithEvents grpTriggerTimer As GroupBox
    Friend WithEvents lblTriggerTimer As Label
    Friend WithEvents txtTriggerTimerDakika As NumericUpDown
    Friend WithEvents btnTriggerBaslat As Button
    Friend WithEvents btnTriggerDurdur As Button
    Friend WithEvents lblTriggerBilgi As Label
    Friend WithEvents grpTriggerIstatistik As GroupBox
    Friend WithEvents lblBekleyenStok As Label
    Friend WithEvents lblBekleyenFiyat As Label
    Friend WithEvents lblBekleyenResim As Label
    Friend WithEvents lblBekleyenKategori As Label
    Friend WithEvents btnTriggerYenile As Button
    Friend WithEvents lblTriggerDurum As Label
    ' Manuel Güncelleme Butonları
    Friend WithEvents grpManuelGuncelleme As GroupBox
    Friend WithEvents btnKategoriGuncelle As Button
    Friend WithEvents btnResimGuncelle As Button
    Friend WithEvents btnSinifEsleme As Button
    ' Yeni Gönderim Ayarları Checkbox'ları
    Friend WithEvents grpGonderimAyarlari As GroupBox
    Friend WithEvents chkTumunuGonder As CheckBox
    Friend WithEvents chkMarkaGonder As CheckBox
    Friend WithEvents chkKategoriGonder As CheckBox
    Friend WithEvents chkUzunAciklamaGonder As CheckBox
    Friend WithEvents chkKisaAciklamaGonder As CheckBox
    Friend WithEvents chkSEOGonder As CheckBox
    Friend WithEvents chkDesiGonder As CheckBox
    ' Gönderim Modu Seçimi (API/PHP)
    Friend WithEvents grpGonderimModu As GroupBox
    Friend WithEvents rdoApiDogrudan As RadioButton
    Friend WithEvents rdoPhpEntegrasyon As RadioButton
    ' Tarih Araliginda Siparis Cek
    Friend WithEvents grpTarihliSiparis As GroupBox
    Friend WithEvents lblBaslangicTarihi As Label
    Friend WithEvents dtpBaslangic As DateTimePicker
    Friend WithEvents lblBitisTarihi As Label
    Friend WithEvents dtpBitis As DateTimePicker
    Friend WithEvents lblSiparisStatus As Label
    Friend WithEvents cmbSiparisStatus As ComboBox
    Friend WithEvents btnTarihliSiparisCek As Button
    Friend WithEvents btnEksikBilgiGuncelle As Button
End Class
