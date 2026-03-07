Imports System.IO
Public NotInheritable Class AboutBox1
    Private Sub AboutBox1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ' Set the title of the form.
        Dim ApplicationTitle As String = If(String.Compare(My.Application.Info.Title, "", False) <> 0, My.Application.Info.Title, Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName))
        Text = String.Format("Hakkýnda {0}", ApplicationTitle)
        ' Initialize all of the text displayed on the About Box.
        ' TODO: Customize the application's assembly information in the "Application" pane of the project 
        '    properties dialog (under the "Project" menu).
        labelProductName.Text = String.Format("{0}OnayKodu: {1} Lisans Anahtarýnýz: {2}", My.Application.Info.ProductName, sOnayKodu, sLicensekey)
        LabelVersion.Text = String.Format("Version {0}", My.Application.Info.Version.ToString)
        LabelCopyright.Text = My.Application.Info.Copyright
        LabelCompanyName.Text = My.Application.Info.CompanyName
        LabelCompanyName.Text += String.Format(" Istanbul  Merkez:{0}Kocatepe Mah. 12.Sk. Megacenter C.30 Blok Kat6 No:5 Bayrampasa/Istanbul/TURKEY", vbCrLf)
        'Me.LabelCompanyName.Text += vbCrLf & " Malatya Müdürlük: +90 422 324 89 92"
        'Me.TextBoxDescription.Text = My.Application.Info.Description
        Dim dr As DataRow = DataSet1.Tables(0).NewRow
        '1
        dr("sKod") = "Ürün Geliþtirme"
        dr("sAciklama") = "Bilgisayar ve Yazýlým Mühendisi"
        dr("sYetkili") = "Abdul Kadir ÇAKIR"
        dr("sIl") = "Ýstanbul"
        dr("sSirket") = ""
        'dr("sTelefon") = "+90 533 332 91 73"
        DataSet1.Tables(0).Rows.Add(dr)
        '2
        dr = DataSet1.Tables(0).NewRow
        dr("sKod") = "Ürün Geliþtirme"
        dr("sAciklama") = "Makine Mühendisi"
        dr("sYetkili") = "Þükür Hamit ÇAKIR"
        dr("sIl") = "Ýstanbul"
        dr("sSirket") = ""
        dr("sTelefon") = ""
        DataSet1.Tables(0).Rows.Add(dr)
        '3
        dr = DataSet1.Tables(0).NewRow
        dr("sKod") = "Ürün Geliþtirme"
        dr("sAciklama") = "Bilgisayar ve Yazýlým Mühendisi"
        dr("sYetkili") = "Ýbrahim SÖNMEZ"
        dr("sIl") = "Ýstanbul"
        dr("sSirket") = ""
        'dr("sTelefon") = "+90 533 332 91 73"
        DataSet1.Tables(0).Rows.Add(dr)
        '
        '3
        dr = DataSet1.Tables(0).NewRow
        dr("sKod") = "Ürün Geliþtirme"
        dr("sAciklama") = "Bilgisayar ve Yazýlým Mühendisi"
        dr("sYetkili") = "Emre KORGÜN"
        dr("sIl") = "Ýstanbul"
        dr("sSirket") = ""
        'dr("sTelefon") = "+90 533 332 91 73"
        DataSet1.Tables(0).Rows.Add(dr)
        '
        dr = DataSet1.Tables(0).NewRow
        dr("sKod") = "Web Developer"
        dr("sAciklama") = "Web Developer"
        dr("sYetkili") = "Yýlmaz LEVENT"
        dr("sIl") = "Malatya"
        dr("sSirket") = ""
        'dr("sTelefon") = "+90 533 332 91 73"
        DataSet1.Tables(0).Rows.Add(dr)
        '
        dr = DataSet1.Tables(0).NewRow
        dr("sKod") = "Web Developer"
        dr("sAciklama") = "Web Developer"
        dr("sYetkili") = "Hasan TUTUÞ"
        dr("sIl") = "Batman"
        dr("sSirket") = ""
        DataSet1.Tables(0).Rows.Add(dr)
        '
        dr = DataSet1.Tables(0).NewRow
        dr("sKod") = "Teknoloji Geliþtirme"
        dr("sAciklama") = "Yazýlým Mühendisi"
        dr("sYetkili") = "Aleksey Mandrykin"
        dr("sIl") = "Rusia"
        dr("sSirket") = ""
        dr("sTelefon") = ""
        DataSet1.Tables(0).Rows.Add(dr)
        '
        dr = DataSet1.Tables(0).NewRow
        dr("sKod") = "Teknoloji Geliþtirme"
        dr("sAciklama") = "Yazýlým Mühendisi"
        dr("sYetkili") = "Ercan TAÞÇI"
        dr("sIl") = "ABD"
        dr("sSirket") = ""
        dr("sTelefon") = ""
        DataSet1.Tables(0).Rows.Add(dr)
        '
        dr = DataSet1.Tables(0).NewRow
        dr("sKod") = "Teknoloji Geliþtirme"
        dr("sAciklama") = "Yazýlým Mühendisi"
        dr("sYetkili") = "Murat KARABULUT"
        dr("sIl") = "ABD"
        dr("sSirket") = ""
        dr("sTelefon") = ""
        DataSet1.Tables(0).Rows.Add(dr)
        '
        dr = DataSet1.Tables(0).NewRow
        dr("sKod") = "Teknoloji Geliþtirme"
        dr("sAciklama") = "Yazýlým Mühendisi"
        dr("sYetkili") = "Hüseyin Eryiðit"
        dr("sIl") = "ABD"
        dr("sSirket") = ""
        dr("sTelefon") = ""
        DataSet1.Tables(0).Rows.Add(dr)
        '4
        dr = DataSet1.Tables(0).NewRow
        dr("sKod") = "Teknoloji Geliþtirme"
        dr("sAciklama") = "Yazýlým Mühendisi"
        dr("sYetkili") = "Brien King"
        dr("sIl") = "England"
        dr("sSirket") = ""
        dr("sTelefon") = ""
        DataSet1.Tables(0).Rows.Add(dr)
        '5
        dr = DataSet1.Tables(0).NewRow
        dr("sKod") = "Teknoloji Geliþtirme"
        dr("sAciklama") = "Yazýlým Mühendisi"
        dr("sYetkili") = "Mahmoud Baalbaki"
        dr("sIl") = "Dubai"
        dr("sSirket") = ""
        dr("sTelefon") = ""
        DataSet1.Tables(0).Rows.Add(dr)
        '
        dr = DataSet1.Tables(0).NewRow
        dr("sKod") = "Teknoloji Geliþtirme"
        dr("sAciklama") = "Yazýlým Mühendisi"
        dr("sYetkili") = "Jawad el Bradi"
        dr("sIl") = "India"
        dr("sSirket") = ""
        dr("sTelefon") = ""
        DataSet1.Tables(0).Rows.Add(dr)
        '
        dr = DataSet1.Tables(0).NewRow
        dr("sKod") = "Eðitim Destek"
        dr("sAciklama") = "Satýþ/Pazarlama"
        dr("sYetkili") = "Seyit Asým ÇAKIR"
        dr("sIl") = "Ýstanbul"
        dr("sSirket") = ""
        'dr("sTelefon") = "+90 216 389 89 17"
        DataSet1.Tables(0).Rows.Add(dr)
        ' '
        dr = DataSet1.Tables(0).NewRow
        dr("sKod") = "Eðitim Destek"
        dr("sAciklama") = "Servis/Destek"
        dr("sYetkili") = "Ercan ÇAKIR"
        dr("sIl") = "Ýstanbul"
        dr("sSirket") = ""
        'dr("sTelefon") = "+90 538 823 33 95"
        DataSet1.Tables(0).Rows.Add(dr)
        dr = DataSet1.Tables(0).NewRow
        dr("sKod") = "Eðitim Destek"
        dr("sAciklama") = "Servis/Destek"
        dr("sYetkili") = "Okan KURNAZ"
        dr("sIl") = "Malatya"
        dr("sSirket") = ""
        dr("sTelefon") = "" '"+90 216 389 89 17"
        DataSet1.Tables(0).Rows.Add(dr)
        dr = DataSet1.Tables(0).NewRow
        dr("sKod") = "Eðitim Destek"
        dr("sAciklama") = "Servis/Destek"
        dr("sYetkili") = "Akif Bozdemir"
        dr("sIl") = "Malatya"
        dr("sSirket") = ""
        dr("sTelefon") = "" '"+90 216 389 89 17"
        DataSet1.Tables(0).Rows.Add(dr)
        '
        dr = DataSet1.Tables(0).NewRow
        dr("sKod") = "Döküman"
        dr("sAciklama") = "Daðýtýcý"
        dr("sYetkili") = "Salih KOCAAÐA"
        dr("sIl") = "Tekirdað"
        dr("sSirket") = ""
        dr("sTelefon") = "" '"+90 216 389 89 17"
        DataSet1.Tables(0).Rows.Add(dr)
        ' Katký Saðlayanlar
        dr = DataSet1.Tables(0).NewRow
        dr("sKod") = "Eðitim Destek"
        dr("sAciklama") = "Bölge Müdürü"
        dr("sYetkili") = "Ali Taner GÖKSU"
        dr("sIl") = "Gaziantep"
        dr("sSirket") = ""
        'dr("sTelefon") = "+90 538 823 33 95"
        DataSet1.Tables(0).Rows.Add(dr)
        dr = DataSet1.Tables(0).NewRow
        dr("sKod") = "Katký Saðlayanlar"
        dr("sAciklama") = "Þirket Sahibi/Yönetici"
        dr("sYetkili") = "Cemil MERSÝN"
        dr("sIl") = "Hatay"
        dr("sSirket") = ""
        dr("sTelefon") = "+90 533 471 36 88"
        DataSet1.Tables(0).Rows.Add(dr)
        ' Katký Saðlayanlar
        dr = DataSet1.Tables(0).NewRow
        dr("sKod") = "Katký Saðlayanlar"
        dr("sAciklama") = "Pazarlama/SatýnAlma"
        dr("sYetkili") = "Edip KAYABAÞI"
        dr("sIl") = "Hatay"
        dr("sSirket") = "Avcý Group"
        'dr("sTelefon") = "+90 533 471 36 88"
        DataSet1.Tables(0).Rows.Add(dr)
        ' Katký Saðlayanlar
        dr = DataSet1.Tables(0).NewRow
        dr("sKod") = "Katký Saðlayanlar"
        dr("sAciklama") = "Daðýtýcý/Þirket Sahibi"
        dr("sYetkili") = "Serkan ÇÝÇEK"
        dr("sIl") = "Elazýð"
        dr("sSirket") = "B-Kare Yazýlým"
        dr("sTelefon") = "+90 532 320 78 02"
        DataSet1.Tables(0).Rows.Add(dr)
        ' Katký Saðlayanlar
        dr = DataSet1.Tables(0).NewRow
        dr("sKod") = "Katký Saðlayanlar"
        dr("sAciklama") = "Market/Þirket Sahibi"
        dr("sYetkili") = "Selim BEHÇET"
        dr("sIl") = "Malatya"
        dr("sSirket") = "Kernek Ofis"
        dr("sTelefon") = "+90 553 617 17 00"
        DataSet1.Tables(0).Rows.Add(dr)
        ' Katký Saðlayanlar
        dr = DataSet1.Tables(0).NewRow
        dr("sKod") = "Katký Saðlayanlar"
        dr("sAciklama") = "Daðýtýcý/Þirket Sahibi"
        dr("sYetkili") = "Halil KURNAZ"
        dr("sIl") = "Malatya"
        dr("sSirket") = "Datanet Bilgisayar"
        dr("sTelefon") = "+90 535 334 94 54"
        DataSet1.Tables(0).Rows.Add(dr)
        ' Katký Saðlayanlar
        dr = DataSet1.Tables(0).NewRow
        dr("sKod") = "Katký Saðlayanlar"
        dr("sAciklama") = "Þirket Sahibi"
        dr("sYetkili") = "Aydýn DÝLMEN"
        dr("sIl") = "Ýstanbul"
        dr("sSirket") = "Boðaziçi Ev Ürünleri"
        dr("sTelefon") = "+90 532 761 71 04"
        DataSet1.Tables(0).Rows.Add(dr)
        '
        dr = DataSet1.Tables(0).NewRow
        dr("sKod") = "Katký Saðlayanlar"
        dr("sAciklama") = "Genel Müdür"
        dr("sYetkili") = "Hüseyin AVCI"
        dr("sIl") = "Hatay"
        dr("sSirket") = "AVCI GROUP"
        dr("sTelefon") = ""
        DataSet1.Tables(0).Rows.Add(dr)
        ' Katký Saðlayanlar
        dr = DataSet1.Tables(0).NewRow
        dr("sKod") = "Katký Saðlayanlar"
        dr("sAciklama") = "Maðaza/Þirket Sahibi"
        dr("sYetkili") = "Coþkun UÐURLU"
        dr("sIl") = "GaziAntep"
        dr("sSirket") = ""
        dr("sTelefon") = ""
        DataSet1.Tables(0).Rows.Add(dr)
        ' Katký Saðlayanlar
        dr = DataSet1.Tables(0).NewRow
        dr("sKod") = "Katký Saðlayanlar"
        dr("sAciklama") = "Market/Þirket Sahibi"
        dr("sYetkili") = "Mükremin GÜLAY"
        dr("sIl") = "Zonguldak"
        dr("sSirket") = "Metro Alýþveriþ Merkezi"
        dr("sTelefon") = ""
        DataSet1.Tables(0).Rows.Add(dr)
        ' Katký Saðlayanlar
        dr = DataSet1.Tables(0).NewRow
        dr("sKod") = "Katký Saðlayanlar"
        dr("sAciklama") = "Temizlik/Kozmetik/Ambalaj/Þirket Sahibi"
        dr("sYetkili") = "Mustafa BALCI"
        dr("sIl") = "Ýstanbul"
        dr("sSirket") = "Güneysu Temizlik"
        dr("sTelefon") = ""
        DataSet1.Tables(0).Rows.Add(dr)
        dr = DataSet1.Tables(0).NewRow
        dr("sKod") = "Katký Saðlayanlar"
        dr("sAciklama") = "Market/Þirket Sahibi"
        dr("sYetkili") = "Naci GÜNEL"
        dr("sIl") = "Ýstanbul"
        dr("sSirket") = "MKM HiperMarket"
        dr("sTelefon") = ""
        DataSet1.Tables(0).Rows.Add(dr)
        dr = DataSet1.Tables(0).NewRow
        dr("sKod") = "Katký Saðlayanlar"
        dr("sAciklama") = "GIDA/Genel Müdür"
        dr("sYetkili") = "Mehmet IÞIK"
        dr("sIl") = "Ýstanbul"
        dr("sSirket") = "ISPARTALILAR GIDA"
        dr("sTelefon") = ""
        DataSet1.Tables(0).Rows.Add(dr)
        dr = DataSet1.Tables(0).NewRow
        dr("sKod") = "Katký Saðlayanlar"
        dr("sAciklama") = "Maðaza/Þirket Sahibi"
        dr("sYetkili") = "Mehmet DARBAZ"
        dr("sIl") = "Ýstanbul"
        dr("sSirket") = "Darbaz Halý/AlýþVeriþ Merkezi"
        dr("sTelefon") = ""
        DataSet1.Tables(0).Rows.Add(dr)
        dr = DataSet1.Tables(0).NewRow
        dr("sKod") = "Katký Saðlayanlar"
        dr("sAciklama") = "DAÐITICI/Þirket Sahibi"
        dr("sYetkili") = "Yusuf AY"
        dr("sIl") = "Tokat"
        dr("sSirket") = "Business TEKNOLOJÝ Sistemleri"
        dr("sTelefon") = ""
        DataSet1.Tables(0).Rows.Add(dr)
        dr = DataSet1.Tables(0).NewRow
        dr("sKod") = "Katký Saðlayanlar"
        dr("sAciklama") = "Biliþim/Genel Müdür"
        dr("sYetkili") = "Ýsa Can AVCI"
        dr("sIl") = "ANTAKYA"
        dr("sSirket") = "TEKNOTÝME"
        dr("sTelefon") = ""
        DataSet1.Tables(0).Rows.Add(dr)
        dr = DataSet1.Tables(0).NewRow
        dr("sKod") = "Katký Saðlayanlar"
        dr("sAciklama") = "Tekstil/Perde/Þirket Sahibi"
        dr("sYetkili") = "Selim AÐBAHT"
        dr("sIl") = "Hatay"
        dr("sSirket") = "AÐBAHT TEKSTÝL"
        dr("sTelefon") = ""
        DataSet1.Tables(0).Rows.Add(dr)
        dr = DataSet1.Tables(0).NewRow
        dr("sKod") = "Katký Saðlayanlar"
        dr("sAciklama") = "Giyim/Þirket Sahibi"
        dr("sYetkili") = "Orhan ÖZKARA"
        dr("sIl") = "Ýstanbul"
        dr("sSirket") = "ORHAN GÝYÝM MAÐAZALARI"
        dr("sTelefon") = ""
        DataSet1.Tables(0).Rows.Add(dr)
        dr = DataSet1.Tables(0).NewRow
        dr("sKod") = "Katký Saðlayanlar"
        dr("sAciklama") = "Bilgi Ýþlem"
        dr("sYetkili") = "MURAT ZORLU"
        dr("sIl") = "Ýstanbul"
        dr("sSirket") = "RAMMAR MARKETLER"
        dr("sTelefon") = ""
        dr = DataSet1.Tables(0).NewRow
        dr("sKod") = "Katký Saðlayanlar"
        dr("sAciklama") = "AYAKKABI/YÖNETÝCÝ"
        dr("sYetkili") = "Mahmut CANDAÞ"
        dr("sIl") = "Malatya"
        dr("sSirket") = "DC"
        dr("sTelefon") = ""
        DataSet1.Tables(0).Rows.Add(dr)
        dr = DataSet1.Tables(0).NewRow
        dr("sKod") = "Katký Saðlayanlar"
        dr("sAciklama") = "Kuruyemiþ/Toptan/YÖNETÝCÝ"
        dr("sYetkili") = "Salih URFALI"
        dr("sIl") = "Malatya"
        dr("sSirket") = "Urfalýoðlu Kuruyemiþ"
        dr("sTelefon") = ""
        DataSet1.Tables(0).Rows.Add(dr)
        dr = DataSet1.Tables(0).NewRow
        dr("sKod") = "Katký Saðlayanlar"
        dr("sAciklama") = "Mücevherat/YÖNETÝCÝ"
        dr("sYetkili") = "Kerim Dað"
        dr("sIl") = "ÝSTANBUL"
        dr("sSirket") = "JÝVAL"
        dr("sTelefon") = ""
        DataSet1.Tables(0).Rows.Add(dr)
        dr = DataSet1.Tables(0).NewRow
        dr("sKod") = "Katký Saðlayanlar"
        dr("sAciklama") = "Mobilya"
        dr("sYetkili") = "Hasan ÖZKARA"
        dr("sIl") = "AFYON"
        dr("sSirket") = "ÖZKARA MOBÝLYA"
        dr("sTelefon") = ""
        DataSet1.Tables(0).Rows.Add(dr)
        dr = DataSet1.Tables(0).NewRow
        dr("sKod") = "Katký Saðlayanlar"
        dr("sAciklama") = "TOPTAN"
        dr("sYetkili") = "Salih AVCI"
        dr("sIl") = "JEDDAH"
        dr("sSirket") = "BAMCO"
        dr("sTelefon") = ""
        DataSet1.Tables(0).Rows.Add(dr)
        dr = DataSet1.Tables(0).NewRow
        dr("sKod") = "Katký Saðlayanlar"
        dr("sAciklama") = "MARKET"
        dr("sYetkili") = "Hasan Ali GÜLAY"
        dr("sIl") = "ZONGULDAK"
        dr("sSirket") = "HEYBEM GIDA"
        dr("sTelefon") = ""
        DataSet1.Tables(0).Rows.Add(dr)
        dr = DataSet1.Tables(0).NewRow
        dr("sKod") = "Katký Saðlayanlar"
        dr("sAciklama") = "ÇAYKUR"
        dr("sYetkili") = "Mahmut GÜRSOY"
        dr("sIl") = "SAMSUN"
        dr("sSirket") = "ÖZDE KARADENÝZ"
        dr("sTelefon") = ""
        DataSet1.Tables(0).Rows.Add(dr)
        dr = DataSet1.Tables(0).NewRow
        dr("sKod") = "Katký Saðlayanlar"
        dr("sAciklama") = "ELEKTRONÝK"
        dr("sYetkili") = "Ahmet YAZIR"
        dr("sIl") = "SAMSUN"
        dr("sSirket") = "TÝRYAKÝ BÝLGÝSAYAR"
        dr("sTelefon") = ""
        DataSet1.Tables(0).Rows.Add(dr)
        dr = DataSet1.Tables(0).NewRow
        dr("sKod") = "Katký Saðlayanlar"
        dr("sAciklama") = "MUHASEBE"
        dr("sYetkili") = "Yalým ÖZDEN"
        dr("sIl") = "GAZÝANTEP"
        dr("sSirket") = "UÐURLU ÇEYÝZ"
        dr("sTelefon") = ""
        DataSet1.Tables(0).Rows.Add(dr)
        dr = DataSet1.Tables(0).NewRow
        dr("sKod") = "Katký Saðlayanlar"
        dr("sAciklama") = "MUHASEBE"
        dr("sYetkili") = "Mehmet BOZKURT"
        dr("sIl") = "GAZÝANTEP"
        dr("sSirket") = "UÐURLU ÇEYÝZ"
        dr("sTelefon") = ""
        DataSet1.Tables(0).Rows.Add(dr)
        dr = DataSet1.Tables(0).NewRow
        dr("sKod") = "Katký Saðlayanlar"
        dr("sAciklama") = "MAÐAZA"
        dr("sYetkili") = "Mustafa ABACI"
        dr("sIl") = "Hatay"
        dr("sSirket") = "ÝMREN ZÜCCACÝYE"
        dr("sTelefon") = ""
        DataSet1.Tables(0).Rows.Add(dr)
        dr = DataSet1.Tables(0).NewRow
        dr("sKod") = "Katký Saðlayanlar"
        dr("sAciklama") = "SATIÞ/DAÐITIM"
        dr("sYetkili") = "Salih ULUDOÐAN"
        dr("sIl") = "SAMSUN"
        dr("sSirket") = "TÝRYAKÝ BÝLGÝSAYAR"
        dr("sTelefon") = ""
        DataSet1.Tables(0).Rows.Add(dr)
        dr = DataSet1.Tables(0).NewRow
        dr("sKod") = "Katký Saðlayanlar"
        dr("sAciklama") = "MUHASEBE"
        dr("sYetkili") = "Eser SAMSUM"
        dr("sIl") = "JEDDAH"
        dr("sSirket") = "BAMCO"
        dr("sTelefon") = ""
        DataSet1.Tables(0).Rows.Add(dr)
        dr = DataSet1.Tables(0).NewRow
        dr("sKod") = "Katký Saðlayanlar"
        dr("sAciklama") = "MAÐAZA"
        dr("sYetkili") = "TOLGA BAÞHELVACI"
        dr("sIl") = "Gaziantep"
        dr("sSirket") = "Niþantaþý Home Store"
        dr("sTelefon") = ""
        DataSet1.Tables(0).Rows.Add(dr)
        dr = DataSet1.Tables(0).NewRow
        dr("sKod") = "Katký Saðlayanlar"
        dr("sAciklama") = "MARKET"
        dr("sYetkili") = "SERKAN BEHÇET"
        dr("sIl") = "Malatya"
        dr("sSirket") = "Sever Ýnþaat"
        dr("sTelefon") = ""
        DataSet1.Tables(0).Rows.Add(dr)
        Beep()
    End Sub
    Private Sub OKButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles OKButton.Click
        Close()
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Dim frm As New SysInfo
        frm.StartPosition = FormStartPosition.CenterScreen
        SysInfo.Show()
    End Sub
End Class
