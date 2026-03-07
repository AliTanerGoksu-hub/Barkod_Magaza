<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_CariStokListesi
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
        Me.panelTop = New System.Windows.Forms.Panel()
        Me.rgGorunumTipi = New DevExpress.XtraEditors.RadioGroup()
        Me.chkSonradanTeslimli = New DevExpress.XtraEditors.CheckEdit()
        Me.btnExcel = New DevExpress.XtraEditors.SimpleButton()
        Me.btnRaporla = New DevExpress.XtraEditors.SimpleButton()
        Me.lblTarihBitis = New System.Windows.Forms.Label()
        Me.lblTarihBaslangic = New System.Windows.Forms.Label()
        Me.dtBitis = New DevExpress.XtraEditors.DateEdit()
        Me.dtBaslangic = New DevExpress.XtraEditors.DateEdit()
        Me.lblFirma = New System.Windows.Forms.Label()
        Me.cmbFirma = New DevExpress.XtraEditors.LookUpEdit()
        Me.btnGorunumDuzenle = New DevExpress.XtraEditors.SimpleButton()
        Me.btnGorunumKaydet = New DevExpress.XtraEditors.SimpleButton()
        Me.btnYazdir = New DevExpress.XtraEditors.SimpleButton()
        Me.panelOzet = New System.Windows.Forms.Panel()
        Me.lblAciklama = New System.Windows.Forms.Label()
        Me.lblGercekBorc = New System.Windows.Forms.Label()
        Me.lblBekleyenTutar = New System.Windows.Forms.Label()
        Me.lblSatilanTutar = New System.Windows.Forms.Label()
        Me.lblToplamAlis = New System.Windows.Forms.Label()
        Me.lblFirmaBakiye = New System.Windows.Forms.Label()
        Me.gridControlRapor = New DevExpress.XtraGrid.GridControl()
        Me.gridViewRapor = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.panelStatus = New System.Windows.Forms.Panel()
        Me.lblDurum = New System.Windows.Forms.Label()
        Me.panelTop.SuspendLayout()
        CType(Me.rgGorunumTipi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSonradanTeslimli.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtBitis.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtBaslangic.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbFirma.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelOzet.SuspendLayout()
        CType(Me.gridControlRapor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridViewRapor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelStatus.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelTop
        '
        Me.panelTop.BackColor = System.Drawing.Color.WhiteSmoke
        Me.panelTop.Controls.Add(Me.rgGorunumTipi)
        Me.panelTop.Controls.Add(Me.btnYazdir)
        Me.panelTop.Controls.Add(Me.btnGorunumKaydet)
        Me.panelTop.Controls.Add(Me.btnGorunumDuzenle)
        Me.panelTop.Controls.Add(Me.chkSonradanTeslimli)
        Me.panelTop.Controls.Add(Me.btnExcel)
        Me.panelTop.Controls.Add(Me.btnRaporla)
        Me.panelTop.Controls.Add(Me.lblTarihBitis)
        Me.panelTop.Controls.Add(Me.lblTarihBaslangic)
        Me.panelTop.Controls.Add(Me.dtBitis)
        Me.panelTop.Controls.Add(Me.dtBaslangic)
        Me.panelTop.Controls.Add(Me.lblFirma)
        Me.panelTop.Controls.Add(Me.cmbFirma)
        Me.panelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelTop.Location = New System.Drawing.Point(0, 0)
        Me.panelTop.Name = "panelTop"
        Me.panelTop.Size = New System.Drawing.Size(1200, 70)
        Me.panelTop.TabIndex = 0
        '
        'rgGorunumTipi
        '
        Me.rgGorunumTipi.Location = New System.Drawing.Point(700, 40)
        Me.rgGorunumTipi.Name = "rgGorunumTipi"
        Me.rgGorunumTipi.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke
        Me.rgGorunumTipi.Properties.Appearance.Options.UseBackColor = True
        Me.rgGorunumTipi.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.rgGorunumTipi.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {
            New DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Detay"),
            New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Özet (Firma Bazlı)")})
        Me.rgGorunumTipi.Size = New System.Drawing.Size(200, 25)
        Me.rgGorunumTipi.TabIndex = 10
        Me.rgGorunumTipi.EditValue = 0
        '
        'btnGorunumDuzenle
        '
        Me.btnGorunumDuzenle.Appearance.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnGorunumDuzenle.Appearance.ForeColor = System.Drawing.Color.White
        Me.btnGorunumDuzenle.Appearance.Options.UseBackColor = True
        Me.btnGorunumDuzenle.Appearance.Options.UseForeColor = True
        Me.btnGorunumDuzenle.Location = New System.Drawing.Point(12, 47)
        Me.btnGorunumDuzenle.Name = "btnGorunumDuzenle"
        Me.btnGorunumDuzenle.Size = New System.Drawing.Size(110, 20)
        Me.btnGorunumDuzenle.TabIndex = 11
        Me.btnGorunumDuzenle.Text = "Görünüm Düzenle"
        '
        'btnGorunumKaydet
        '
        Me.btnGorunumKaydet.Appearance.BackColor = System.Drawing.Color.Teal
        Me.btnGorunumKaydet.Appearance.ForeColor = System.Drawing.Color.White
        Me.btnGorunumKaydet.Appearance.Options.UseBackColor = True
        Me.btnGorunumKaydet.Appearance.Options.UseForeColor = True
        Me.btnGorunumKaydet.Location = New System.Drawing.Point(128, 47)
        Me.btnGorunumKaydet.Name = "btnGorunumKaydet"
        Me.btnGorunumKaydet.Size = New System.Drawing.Size(110, 20)
        Me.btnGorunumKaydet.TabIndex = 10
        Me.btnGorunumKaydet.Text = "Görünüm Kaydet"
        '
        'btnYazdir
        '
        Me.btnYazdir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnYazdir.Appearance.BackColor = System.Drawing.Color.DarkOrange
        Me.btnYazdir.Appearance.ForeColor = System.Drawing.Color.White
        Me.btnYazdir.Appearance.Options.UseBackColor = True
        Me.btnYazdir.Appearance.Options.UseForeColor = True
        Me.btnYazdir.Location = New System.Drawing.Point(1030, 47)
        Me.btnYazdir.Name = "btnYazdir"
        Me.btnYazdir.Size = New System.Drawing.Size(80, 20)
        Me.btnYazdir.TabIndex = 9
        Me.btnYazdir.Text = "Yazdır"
        '
        'chkSonradanTeslimli
        '
        Me.chkSonradanTeslimli.Location = New System.Drawing.Point(700, 20)
        Me.chkSonradanTeslimli.Name = "chkSonradanTeslimli"
        Me.chkSonradanTeslimli.Properties.Caption = "Sonradan Teslimli Ürünleri Hesapla"
        Me.chkSonradanTeslimli.Size = New System.Drawing.Size(200, 24)
        Me.chkSonradanTeslimli.TabIndex = 8
        '
        'btnExcel
        '
        Me.btnExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcel.Appearance.BackColor = System.Drawing.Color.ForestGreen
        Me.btnExcel.Appearance.ForeColor = System.Drawing.Color.White
        Me.btnExcel.Appearance.Options.UseBackColor = True
        Me.btnExcel.Appearance.Options.UseForeColor = True
        Me.btnExcel.Location = New System.Drawing.Point(1090, 17)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(100, 30)
        Me.btnExcel.TabIndex = 7
        Me.btnExcel.Text = "Excel'e Aktar"
        '
        'btnRaporla
        '
        Me.btnRaporla.Appearance.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnRaporla.Appearance.ForeColor = System.Drawing.Color.White
        Me.btnRaporla.Appearance.Options.UseBackColor = True
        Me.btnRaporla.Appearance.Options.UseForeColor = True
        Me.btnRaporla.Location = New System.Drawing.Point(920, 17)
        Me.btnRaporla.Name = "btnRaporla"
        Me.btnRaporla.Size = New System.Drawing.Size(100, 30)
        Me.btnRaporla.TabIndex = 6
        Me.btnRaporla.Text = "Raporla"
        '
        'lblTarihBitis
        '
        Me.lblTarihBitis.AutoSize = True
        Me.lblTarihBitis.Location = New System.Drawing.Point(520, 24)
        Me.lblTarihBitis.Name = "lblTarihBitis"
        Me.lblTarihBitis.Size = New System.Drawing.Size(52, 17)
        Me.lblTarihBitis.TabIndex = 5
        Me.lblTarihBitis.Text = "Bitiş:"
        '
        'lblTarihBaslangic
        '
        Me.lblTarihBaslangic.AutoSize = True
        Me.lblTarihBaslangic.Location = New System.Drawing.Point(360, 24)
        Me.lblTarihBaslangic.Name = "lblTarihBaslangic"
        Me.lblTarihBaslangic.Size = New System.Drawing.Size(73, 17)
        Me.lblTarihBaslangic.TabIndex = 4
        Me.lblTarihBaslangic.Text = "Başlangıç:"
        '
        'dtBitis
        '
        Me.dtBitis.EditValue = Nothing
        Me.dtBitis.Location = New System.Drawing.Point(578, 20)
        Me.dtBitis.Name = "dtBitis"
        Me.dtBitis.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtBitis.Properties.DisplayFormat.FormatString = "dd.MM.yyyy"
        Me.dtBitis.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtBitis.Properties.EditFormat.FormatString = "dd.MM.yyyy"
        Me.dtBitis.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtBitis.Properties.Mask.EditMask = "dd.MM.yyyy"
        Me.dtBitis.Size = New System.Drawing.Size(110, 24)
        Me.dtBitis.TabIndex = 3
        '
        'dtBaslangic
        '
        Me.dtBaslangic.EditValue = Nothing
        Me.dtBaslangic.Location = New System.Drawing.Point(439, 20)
        Me.dtBaslangic.Name = "dtBaslangic"
        Me.dtBaslangic.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtBaslangic.Properties.DisplayFormat.FormatString = "dd.MM.yyyy"
        Me.dtBaslangic.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtBaslangic.Properties.EditFormat.FormatString = "dd.MM.yyyy"
        Me.dtBaslangic.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtBaslangic.Properties.Mask.EditMask = "dd.MM.yyyy"
        Me.dtBaslangic.Size = New System.Drawing.Size(75, 24)
        Me.dtBaslangic.TabIndex = 2
        '
        'lblFirma
        '
        Me.lblFirma.AutoSize = True
        Me.lblFirma.Location = New System.Drawing.Point(12, 24)
        Me.lblFirma.Name = "lblFirma"
        Me.lblFirma.Size = New System.Drawing.Size(50, 17)
        Me.lblFirma.TabIndex = 1
        Me.lblFirma.Text = "Firma:"
        '
        'cmbFirma
        '
        Me.cmbFirma.Location = New System.Drawing.Point(68, 20)
        Me.cmbFirma.Name = "cmbFirma"
        Me.cmbFirma.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbFirma.Properties.NullText = "Firma Seçin..."
        Me.cmbFirma.Properties.PopupSizeable = False
        Me.cmbFirma.Size = New System.Drawing.Size(280, 24)
        Me.cmbFirma.TabIndex = 0
        '
        'panelOzet
        '
        Me.panelOzet.BackColor = System.Drawing.Color.LightYellow
        Me.panelOzet.Controls.Add(Me.lblAciklama)
        Me.panelOzet.Controls.Add(Me.lblGercekBorc)
        Me.panelOzet.Controls.Add(Me.lblBekleyenTutar)
        Me.panelOzet.Controls.Add(Me.lblSatilanTutar)
        Me.panelOzet.Controls.Add(Me.lblToplamAlis)
        Me.panelOzet.Controls.Add(Me.lblFirmaBakiye)
        Me.panelOzet.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelOzet.Location = New System.Drawing.Point(0, 550)
        Me.panelOzet.Name = "panelOzet"
        Me.panelOzet.Size = New System.Drawing.Size(1200, 100)
        Me.panelOzet.TabIndex = 1
        '
        'lblAciklama
        '
        Me.lblAciklama.AutoSize = True
        Me.lblAciklama.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Italic)
        Me.lblAciklama.ForeColor = System.Drawing.Color.DimGray
        Me.lblAciklama.Location = New System.Drawing.Point(12, 70)
        Me.lblAciklama.Name = "lblAciklama"
        Me.lblAciklama.Size = New System.Drawing.Size(147, 18)
        Me.lblAciklama.TabIndex = 5
        Me.lblAciklama.Text = "Hesaplama detayları..."
        '
        'lblGercekBorc
        '
        Me.lblGercekBorc.AutoSize = True
        Me.lblGercekBorc.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblGercekBorc.ForeColor = System.Drawing.Color.DarkRed
        Me.lblGercekBorc.Location = New System.Drawing.Point(800, 40)
        Me.lblGercekBorc.Name = "lblGercekBorc"
        Me.lblGercekBorc.Size = New System.Drawing.Size(165, 24)
        Me.lblGercekBorc.TabIndex = 4
        Me.lblGercekBorc.Text = "GERÇEK BORÇ: -"
        '
        'lblBekleyenTutar
        '
        Me.lblBekleyenTutar.AutoSize = True
        Me.lblBekleyenTutar.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular)
        Me.lblBekleyenTutar.ForeColor = System.Drawing.Color.DarkOrange
        Me.lblBekleyenTutar.Location = New System.Drawing.Point(600, 40)
        Me.lblBekleyenTutar.Name = "lblBekleyenTutar"
        Me.lblBekleyenTutar.Size = New System.Drawing.Size(160, 21)
        Me.lblBekleyenTutar.TabIndex = 3
        Me.lblBekleyenTutar.Text = "Bekleyen Sipariş: -"
        Me.lblBekleyenTutar.Visible = False
        '
        'lblSatilanTutar
        '
        Me.lblSatilanTutar.AutoSize = True
        Me.lblSatilanTutar.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular)
        Me.lblSatilanTutar.ForeColor = System.Drawing.Color.Green
        Me.lblSatilanTutar.Location = New System.Drawing.Point(320, 40)
        Me.lblSatilanTutar.Name = "lblSatilanTutar"
        Me.lblSatilanTutar.Size = New System.Drawing.Size(194, 21)
        Me.lblSatilanTutar.TabIndex = 2
        Me.lblSatilanTutar.Text = "Satılan (Alış Fiyatıyla): -"
        '
        'lblToplamAlis
        '
        Me.lblToplamAlis.AutoSize = True
        Me.lblToplamAlis.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular)
        Me.lblToplamAlis.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblToplamAlis.Location = New System.Drawing.Point(160, 40)
        Me.lblToplamAlis.Name = "lblToplamAlis"
        Me.lblToplamAlis.Size = New System.Drawing.Size(109, 21)
        Me.lblToplamAlis.TabIndex = 1
        Me.lblToplamAlis.Text = "Toplam Alış: -"
        '
        'lblFirmaBakiye
        '
        Me.lblFirmaBakiye.AutoSize = True
        Me.lblFirmaBakiye.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblFirmaBakiye.Location = New System.Drawing.Point(12, 12)
        Me.lblFirmaBakiye.Name = "lblFirmaBakiye"
        Me.lblFirmaBakiye.Size = New System.Drawing.Size(140, 21)
        Me.lblFirmaBakiye.TabIndex = 0
        Me.lblFirmaBakiye.Text = "Firma Bakiyesi: -"
        '
        'gridControlRapor
        '
        Me.gridControlRapor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridControlRapor.Location = New System.Drawing.Point(0, 70)
        Me.gridControlRapor.MainView = Me.gridViewRapor
        Me.gridControlRapor.Name = "gridControlRapor"
        Me.gridControlRapor.Size = New System.Drawing.Size(1200, 480)
        Me.gridControlRapor.TabIndex = 2
        Me.gridControlRapor.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridViewRapor})
        '
        'gridViewRapor
        '
        Me.gridViewRapor.GridControl = Me.gridControlRapor
        Me.gridViewRapor.Name = "gridViewRapor"
        Me.gridViewRapor.OptionsBehavior.Editable = False
        Me.gridViewRapor.OptionsView.ShowGroupPanel = True
        Me.gridViewRapor.OptionsView.ShowFooter = True
        '
        'panelStatus
        '
        Me.panelStatus.BackColor = System.Drawing.SystemColors.Control
        Me.panelStatus.Controls.Add(Me.lblDurum)
        Me.panelStatus.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelStatus.Location = New System.Drawing.Point(0, 650)
        Me.panelStatus.Name = "panelStatus"
        Me.panelStatus.Size = New System.Drawing.Size(1200, 25)
        Me.panelStatus.TabIndex = 3
        '
        'lblDurum
        '
        Me.lblDurum.AutoSize = True
        Me.lblDurum.Location = New System.Drawing.Point(12, 4)
        Me.lblDurum.Name = "lblDurum"
        Me.lblDurum.Size = New System.Drawing.Size(50, 17)
        Me.lblDurum.TabIndex = 0
        Me.lblDurum.Text = "Hazır."
        '
        'frm_CariStokListesi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 675)
        Me.Controls.Add(Me.gridControlRapor)
        Me.Controls.Add(Me.panelOzet)
        Me.Controls.Add(Me.panelTop)
        Me.Controls.Add(Me.panelStatus)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Name = "frm_CariStokListesi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cari Stok Listesi - Firma Bazlı Ürün Alış/Satış Raporu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.panelTop.ResumeLayout(False)
        Me.panelTop.PerformLayout()
        CType(Me.rgGorunumTipi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSonradanTeslimli.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtBitis.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtBaslangic.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbFirma.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelOzet.ResumeLayout(False)
        Me.panelOzet.PerformLayout()
        CType(Me.gridControlRapor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridViewRapor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelStatus.ResumeLayout(False)
        Me.panelStatus.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelTop As Panel
    Friend WithEvents rgGorunumTipi As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents lblFirma As Label
    Friend WithEvents cmbFirma As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblTarihBitis As Label
    Friend WithEvents lblTarihBaslangic As Label
    Friend WithEvents dtBitis As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dtBaslangic As DevExpress.XtraEditors.DateEdit
    Friend WithEvents btnRaporla As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnExcel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents chkSonradanTeslimli As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents btnGorunumDuzenle As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnGorunumKaydet As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnYazdir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents panelOzet As Panel
    Friend WithEvents lblFirmaBakiye As Label
    Friend WithEvents lblToplamAlis As Label
    Friend WithEvents lblSatilanTutar As Label
    Friend WithEvents lblBekleyenTutar As Label
    Friend WithEvents lblGercekBorc As Label
    Friend WithEvents lblAciklama As Label
    Friend WithEvents gridControlRapor As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridViewRapor As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents panelStatus As Panel
    Friend WithEvents lblDurum As Label

End Class
