' ============================================
' TRENDYOL BUYBOX ANALİZ FORMU - DESIGNER
' Dosya: frm_TrendyolBuyBoxAnaliz.Designer.vb
' DevExpress 12.2 uyumlu - Standart kontroller
' ============================================

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_TrendyolBuyBoxAnaliz
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
        Me.grp_Filtre = New System.Windows.Forms.GroupBox()
        Me.chk_SadeceEslesmeyen = New System.Windows.Forms.CheckBox()
        Me.txt_StokKodu = New System.Windows.Forms.TextBox()
        Me.txt_Barkod = New System.Windows.Forms.TextBox()
        Me.lbl_StokKodu = New System.Windows.Forms.Label()
        Me.lbl_Barkod = New System.Windows.Forms.Label()
        Me.btn_Yukle = New System.Windows.Forms.Button()
        Me.grd_Urunler = New DevExpress.XtraGrid.GridControl()
        Me.grdView_Urunler = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.pnl_Butonlar = New System.Windows.Forms.Panel()
        Me.btn_Kapat = New System.Windows.Forms.Button()
        Me.btn_KategoriDegistir = New System.Windows.Forms.Button()
        Me.btn_OtomatikDuzelt = New System.Windows.Forms.Button()
        Me.btn_SecimTemizle = New System.Windows.Forms.Button()
        Me.btn_TumunuSec = New System.Windows.Forms.Button()
        Me.btn_Analiz = New System.Windows.Forms.Button()
        Me.pnl_Status = New System.Windows.Forms.Panel()
        Me.progressBar = New System.Windows.Forms.ProgressBar()
        Me.lbl_Status = New System.Windows.Forms.Label()
        Me.grp_Filtre.SuspendLayout()
        CType(Me.grd_Urunler, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdView_Urunler, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_Butonlar.SuspendLayout()
        Me.pnl_Status.SuspendLayout()
        Me.SuspendLayout()
        '
        'grp_Filtre
        '
        Me.grp_Filtre.Controls.Add(Me.chk_SadeceEslesmeyen)
        Me.grp_Filtre.Controls.Add(Me.txt_StokKodu)
        Me.grp_Filtre.Controls.Add(Me.txt_Barkod)
        Me.grp_Filtre.Controls.Add(Me.lbl_StokKodu)
        Me.grp_Filtre.Controls.Add(Me.lbl_Barkod)
        Me.grp_Filtre.Controls.Add(Me.btn_Yukle)
        Me.grp_Filtre.Dock = System.Windows.Forms.DockStyle.Top
        Me.grp_Filtre.Location = New System.Drawing.Point(0, 0)
        Me.grp_Filtre.Name = "grp_Filtre"
        Me.grp_Filtre.Size = New System.Drawing.Size(984, 70)
        Me.grp_Filtre.TabIndex = 0
        Me.grp_Filtre.TabStop = False
        Me.grp_Filtre.Text = "Filtre"
        '
        'lbl_Barkod
        '
        Me.lbl_Barkod.AutoSize = True
        Me.lbl_Barkod.Location = New System.Drawing.Point(15, 30)
        Me.lbl_Barkod.Name = "lbl_Barkod"
        Me.lbl_Barkod.Size = New System.Drawing.Size(44, 13)
        Me.lbl_Barkod.TabIndex = 0
        Me.lbl_Barkod.Text = "Barkod:"
        '
        'txt_Barkod
        '
        Me.txt_Barkod.Location = New System.Drawing.Point(65, 27)
        Me.txt_Barkod.Name = "txt_Barkod"
        Me.txt_Barkod.Size = New System.Drawing.Size(150, 20)
        Me.txt_Barkod.TabIndex = 1
        '
        'lbl_StokKodu
        '
        Me.lbl_StokKodu.AutoSize = True
        Me.lbl_StokKodu.Location = New System.Drawing.Point(230, 30)
        Me.lbl_StokKodu.Name = "lbl_StokKodu"
        Me.lbl_StokKodu.Size = New System.Drawing.Size(58, 13)
        Me.lbl_StokKodu.TabIndex = 2
        Me.lbl_StokKodu.Text = "Stok Kodu:"
        '
        'txt_StokKodu
        '
        Me.txt_StokKodu.Location = New System.Drawing.Point(295, 27)
        Me.txt_StokKodu.Name = "txt_StokKodu"
        Me.txt_StokKodu.Size = New System.Drawing.Size(150, 20)
        Me.txt_StokKodu.TabIndex = 3
        '
        'chk_SadeceEslesmeyen
        '
        Me.chk_SadeceEslesmeyen.AutoSize = True
        Me.chk_SadeceEslesmeyen.Location = New System.Drawing.Point(460, 29)
        Me.chk_SadeceEslesmeyen.Name = "chk_SadeceEslesmeyen"
        Me.chk_SadeceEslesmeyen.Size = New System.Drawing.Size(130, 17)
        Me.chk_SadeceEslesmeyen.TabIndex = 4
        Me.chk_SadeceEslesmeyen.Text = "Sadece Eşleşmeyenler"
        '
        'btn_Yukle
        '
        Me.btn_Yukle.Location = New System.Drawing.Point(630, 25)
        Me.btn_Yukle.Name = "btn_Yukle"
        Me.btn_Yukle.Size = New System.Drawing.Size(100, 25)
        Me.btn_Yukle.TabIndex = 5
        Me.btn_Yukle.Text = "Ürünleri Yükle"
        '
        'grd_Urunler
        '
        Me.grd_Urunler.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grd_Urunler.Location = New System.Drawing.Point(0, 70)
        Me.grd_Urunler.MainView = Me.grdView_Urunler
        Me.grd_Urunler.Name = "grd_Urunler"
        Me.grd_Urunler.Size = New System.Drawing.Size(984, 411)
        Me.grd_Urunler.TabIndex = 1
        Me.grd_Urunler.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdView_Urunler})
        '
        'grdView_Urunler
        '
        Me.grdView_Urunler.GridControl = Me.grd_Urunler
        Me.grdView_Urunler.Name = "grdView_Urunler"
        Me.grdView_Urunler.OptionsView.ShowGroupPanel = False
        '
        'pnl_Butonlar
        '
        Me.pnl_Butonlar.Controls.Add(Me.btn_Kapat)
        Me.pnl_Butonlar.Controls.Add(Me.btn_OtomatikDuzelt)
        Me.pnl_Butonlar.Controls.Add(Me.btn_KategoriDegistir)
        Me.pnl_Butonlar.Controls.Add(Me.btn_SecimTemizle)
        Me.pnl_Butonlar.Controls.Add(Me.btn_TumunuSec)
        Me.pnl_Butonlar.Controls.Add(Me.btn_Analiz)
        Me.pnl_Butonlar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnl_Butonlar.Location = New System.Drawing.Point(0, 481)
        Me.pnl_Butonlar.Name = "pnl_Butonlar"
        Me.pnl_Butonlar.Size = New System.Drawing.Size(984, 50)
        Me.pnl_Butonlar.TabIndex = 2
        '
        'btn_Analiz
        '
        Me.btn_Analiz.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btn_Analiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Analiz.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_Analiz.ForeColor = System.Drawing.Color.White
        Me.btn_Analiz.Location = New System.Drawing.Point(12, 10)
        Me.btn_Analiz.Name = "btn_Analiz"
        Me.btn_Analiz.Size = New System.Drawing.Size(150, 30)
        Me.btn_Analiz.TabIndex = 0
        Me.btn_Analiz.Text = "Seçilenleri Analiz Et"
        Me.btn_Analiz.UseVisualStyleBackColor = False
        '
        'btn_TumunuSec
        '
        Me.btn_TumunuSec.Location = New System.Drawing.Point(170, 10)
        Me.btn_TumunuSec.Name = "btn_TumunuSec"
        Me.btn_TumunuSec.Size = New System.Drawing.Size(90, 30)
        Me.btn_TumunuSec.TabIndex = 1
        Me.btn_TumunuSec.Text = "Tümünü Seç"
        '
        'btn_SecimTemizle
        '
        Me.btn_SecimTemizle.Location = New System.Drawing.Point(270, 10)
        Me.btn_SecimTemizle.Name = "btn_SecimTemizle"
        Me.btn_SecimTemizle.Size = New System.Drawing.Size(90, 30)
        Me.btn_SecimTemizle.TabIndex = 2
        Me.btn_SecimTemizle.Text = "Seçimi Temizle"
        '
        'btn_KategoriDegistir
        '
        Me.btn_KategoriDegistir.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_KategoriDegistir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_KategoriDegistir.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_KategoriDegistir.ForeColor = System.Drawing.Color.White
        Me.btn_KategoriDegistir.Location = New System.Drawing.Point(370, 10)
        Me.btn_KategoriDegistir.Name = "btn_KategoriDegistir"
        Me.btn_KategoriDegistir.Size = New System.Drawing.Size(150, 30)
        Me.btn_KategoriDegistir.TabIndex = 4
        Me.btn_KategoriDegistir.Text = "Manuel Kategori"
        Me.btn_KategoriDegistir.UseVisualStyleBackColor = False
        '
        'btn_OtomatikDuzelt
        '
        Me.btn_OtomatikDuzelt.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btn_OtomatikDuzelt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_OtomatikDuzelt.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_OtomatikDuzelt.ForeColor = System.Drawing.Color.White
        Me.btn_OtomatikDuzelt.Location = New System.Drawing.Point(530, 10)
        Me.btn_OtomatikDuzelt.Name = "btn_OtomatikDuzelt"
        Me.btn_OtomatikDuzelt.Size = New System.Drawing.Size(200, 30)
        Me.btn_OtomatikDuzelt.TabIndex = 5
        Me.btn_OtomatikDuzelt.Text = "Tek Tikla Otomatik Duzelt"
        Me.btn_OtomatikDuzelt.UseVisualStyleBackColor = False
        '
        'btn_Kapat
        '
        Me.btn_Kapat.Location = New System.Drawing.Point(872, 10)
        Me.btn_Kapat.Name = "btn_Kapat"
        Me.btn_Kapat.Size = New System.Drawing.Size(100, 30)
        Me.btn_Kapat.TabIndex = 3
        Me.btn_Kapat.Text = "Kapat"
        '
        'pnl_Status
        '
        Me.pnl_Status.Controls.Add(Me.progressBar)
        Me.pnl_Status.Controls.Add(Me.lbl_Status)
        Me.pnl_Status.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnl_Status.Location = New System.Drawing.Point(0, 531)
        Me.pnl_Status.Name = "pnl_Status"
        Me.pnl_Status.Size = New System.Drawing.Size(984, 30)
        Me.pnl_Status.TabIndex = 3
        '
        'lbl_Status
        '
        Me.lbl_Status.AutoSize = True
        Me.lbl_Status.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_Status.Location = New System.Drawing.Point(12, 8)
        Me.lbl_Status.Name = "lbl_Status"
        Me.lbl_Status.Size = New System.Drawing.Size(39, 14)
        Me.lbl_Status.TabIndex = 0
        Me.lbl_Status.Text = "Hazır"
        '
        'progressBar
        '
        Me.progressBar.Location = New System.Drawing.Point(500, 5)
        Me.progressBar.Name = "progressBar"
        Me.progressBar.Size = New System.Drawing.Size(300, 20)
        Me.progressBar.TabIndex = 1
        Me.progressBar.Visible = False
        '
        'frm_TrendyolBuyBoxAnaliz
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 561)
        Me.Controls.Add(Me.grd_Urunler)
        Me.Controls.Add(Me.pnl_Butonlar)
        Me.Controls.Add(Me.pnl_Status)
        Me.Controls.Add(Me.grp_Filtre)
        Me.Name = "frm_TrendyolBuyBoxAnaliz"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Trendyol BuyBox Analiz"
        Me.grp_Filtre.ResumeLayout(False)
        Me.grp_Filtre.PerformLayout()
        CType(Me.grd_Urunler, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdView_Urunler, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_Butonlar.ResumeLayout(False)
        Me.pnl_Status.ResumeLayout(False)
        Me.pnl_Status.PerformLayout()
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents grp_Filtre As System.Windows.Forms.GroupBox
    Friend WithEvents chk_SadeceEslesmeyen As System.Windows.Forms.CheckBox
    Friend WithEvents txt_StokKodu As System.Windows.Forms.TextBox
    Friend WithEvents txt_Barkod As System.Windows.Forms.TextBox
    Friend WithEvents lbl_StokKodu As System.Windows.Forms.Label
    Friend WithEvents lbl_Barkod As System.Windows.Forms.Label
    Friend WithEvents btn_Yukle As System.Windows.Forms.Button
    Friend WithEvents grd_Urunler As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdView_Urunler As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents pnl_Butonlar As System.Windows.Forms.Panel
    Friend WithEvents btn_Kapat As System.Windows.Forms.Button
    Friend WithEvents btn_SecimTemizle As System.Windows.Forms.Button
    Friend WithEvents btn_TumunuSec As System.Windows.Forms.Button
    Friend WithEvents btn_Analiz As System.Windows.Forms.Button
    Friend WithEvents btn_KategoriDegistir As System.Windows.Forms.Button
    Friend WithEvents btn_OtomatikDuzelt As System.Windows.Forms.Button
    Friend WithEvents pnl_Status As System.Windows.Forms.Panel
    Friend WithEvents progressBar As System.Windows.Forms.ProgressBar
    Friend WithEvents lbl_Status As System.Windows.Forms.Label

End Class
