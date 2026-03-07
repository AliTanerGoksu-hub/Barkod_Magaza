Imports Microsoft.Win32
Imports DevExpress.XtraEditors
Imports System.IO
Public Class frm_WebEntegrasyon
    Dim sorguC As SorguClass = New SorguClass
    Dim WebBaglanti As String = ""
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        If Trim(WebBaglanti) <> "" Then
            If XtraMessageBox.Show("Web Aktarým Ýþlemini Baþlatmak Ýstiyormusunuz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False
                Dim trd As Threading.Thread = New Threading.Thread(AddressOf Senkronizasyon)
                trd.IsBackground = True
                trd.Start()
            End If
        Else
            MessageBox.Show("Web Baðlantý Bilgileri Bulunamadý.", "Business Smart")
        End If
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub frm_WebEntegrasyon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            WebBaglanti = Registry.LocalMachine.OpenSubKey("Software").OpenSubKey("BusinessSmart").GetValue("WebBaglanti").ToString()
        Catch ex As Exception
            WebBaglanti = ""
        End Try
    End Sub
    Private Sub Senkronizasyon()
        Me.Enabled = False
        Dim ds As DataSet
        Dim dr As DataRow
        Dim ds1 As DataSet
        Dim dr1 As DataRow
        Dim tbSSinif1S As Integer = 0
        Dim tbSSinif7S As Integer = 0
        Dim tbSSinif8S As Integer = 0
        Dim tbStokS As Integer = 0
        Dim tbStokResmiS As Integer = 0
        Dim tbStokSinifiS As Integer = 0
        Dim tbSSinif1SUzak As Integer = 0
        Dim tbSSinif7SUzak As Integer = 0
        Dim tbSSinif8SUzak As Integer = 0
        Dim tbStokSUzak As Integer = 0
        Dim tbStokResmiSUzak As Integer = 0
        Dim tbStokSinifiSUzak As Integer = 0
        Dim tbStokFiyatiS As Integer = 0
        Dim tbStokFiyatiSUzak As Integer = 0
        Dim tbStokUzunNotS As Integer = 0
        Dim tbStokUzunNotSUzak As Integer = 0
        ProgressBarControl1.Position = 0
        ProgressBarControl1.Refresh()
        ListBoxControl1.Items.Clear()
        Try
            ds = sorguC.sorgu_DS("SET DATEFORMAT DMY Select * from tbWebGuncel")
            For Each dr In ds.Tables(0).Rows
                tbSSinif1S = Integer.Parse(dr("tbSSinif1S").ToString())
                tbSSinif7S = Integer.Parse(dr("tbSSinif7S").ToString())
                tbSSinif8S = Integer.Parse(dr("tbSSinif8S").ToString())
                tbStokS = Integer.Parse(dr("tbStokS").ToString())
                tbStokResmiS = Integer.Parse(dr("tbStokResmiS").ToString())
                tbStokSinifiS = Integer.Parse(dr("tbStokSinifiS").ToString())
                tbStokFiyatiS = Integer.Parse(dr("tbStokFiyatiS").ToString())
                tbStokUzunNotS = Integer.Parse(dr("tbStokUzunNotS").ToString())
            Next
        Catch ex As Exception
        End Try
        ds = Nothing
        dr = Nothing
        Try
            ds = sorguC.sorgu_DS("SET DATEFORMAT DMY Select * from tbWebGuncel", "TABLE1", WebBaglanti)
            For Each dr In ds.Tables(0).Rows
                tbSSinif1SUzak = Integer.Parse(dr("tbSSinif1S").ToString())
                tbSSinif7SUzak = Integer.Parse(dr("tbSSinif7S").ToString())
                tbSSinif8SUzak = Integer.Parse(dr("tbSSinif8S").ToString())
                tbStokSUzak = Integer.Parse(dr("tbStokS").ToString())
                tbStokResmiSUzak = Integer.Parse(dr("tbStokResmiS").ToString())
                tbStokSinifiSUzak = Integer.Parse(dr("tbStokSinifiS").ToString())
                tbStokFiyatiSUzak = Integer.Parse(dr("tbStokFiyatiS").ToString())
                tbStokUzunNotSUzak = Integer.Parse(dr("tbStokUzunNotS").ToString())
            Next
        Catch ex As Exception
        End Try
        ds = Nothing
        dr = Nothing
        If tbSSinif1S <> tbSSinif1SUzak Then
            Try
                ds = sorguC.sorgu_DS("SET DATEFORMAT DMY Select * from tbWebGuncelVeriler Where (tabloAdi = 'tbSSinif1')", "TABLE1")
                ProgressBarControl1.Properties.Maximum = ds.Tables(0).Rows.Count
                ProgressBarControl1.Position = 0
                ProgressBarControl1.Refresh()
                For Each dr In ds.Tables(0).Rows
                    If Integer.Parse(dr("islem").ToString()) = 0 Then
                        If sorguC.sorgu_tamWeb("Delete From tbSSinif1 Where (sSinifKodu = '" & dr("deger").ToString() & "')", WebBaglanti) = True Then
                            sorguC.sorgu_tamWeb("Delete From tbWebGuncelVeriler Where (id = " & dr("id").ToString() & ")")
                            sorguC.sorgu_tamWeb("Update tbWebGuncel Set tbSSinif1S = " & tbSSinif1S & ", sonGuncelleme = GETDATE()", WebBaglanti)
                        End If
                    ElseIf Integer.Parse(dr("islem").ToString()) = 1 Then
                        ds1 = sorguC.sorgu_DS("SET DATEFORMAT DMY Select * from tbSSinif1 Where (sSinifKodu = '" & dr("deger").ToString() & "')", "TABLE1")
                        For Each dr1 In ds1.Tables(0).Rows
                            If Integer.Parse(sorguC.sorgu_Web("SET DATEFORMAT DMY Select Count(*) from tbSSinif1 Where (sSinifKodu = '" & dr("deger").ToString() & "')", WebBaglanti)) > 0 Then
                                If sorguC.sorgu_tamWeb("Update tbSSinif1 Set sAciklama = '" & dr1("sAciklama").ToString() & "', sSinifKodu7 = '" & dr1("sSinifKodu7").ToString() & "', " &
                                                       "sSinifKodu8 = '" & dr1("sSinifKodu8").ToString() & "' Where (sSinifKodu = '" & dr("deger").ToString() & "')", WebBaglanti) = True Then
                                    sorguC.sorgu_tamWeb("Delete From tbWebGuncelVeriler Where (id = " & dr("id").ToString() & ")")
                                    sorguC.sorgu_tamWeb("Update tbWebGuncel Set tbSSinif1S = " & tbSSinif1S & ", sonGuncelleme = GETDATE()", WebBaglanti)
                                End If
                            Else
                                If sorguC.sorgu_tamWeb("Insert Into tbSSinif1 Values('" & dr("deger").ToString() & "', '" & dr1("sAciklama").ToString() & "', " &
                                                       "'" & dr1("sSinifKodu7").ToString() & "', '" & dr1("sSinifKodu8").ToString() & "')", WebBaglanti) = True Then
                                    sorguC.sorgu_tamWeb("Delete From tbWebGuncelVeriler Where (id = " & dr("id").ToString() & ")")
                                    sorguC.sorgu_tamWeb("Update tbWebGuncel Set tbSSinif1S = " & tbSSinif1S & ", sonGuncelleme = GETDATE()", WebBaglanti)
                                End If
                            End If
                        Next
                        ds1 = Nothing
                        dr1 = Nothing
                    ElseIf Integer.Parse(dr("islem").ToString()) = 2 Then
                        ds1 = sorguC.sorgu_DS("SET DATEFORMAT DMY Select * from tbSSinif1 Where (sSinifKodu = '" & dr("deger").ToString() & "')", "TABLE1")
                        For Each dr1 In ds1.Tables(0).Rows
                            If sorguC.sorgu_tamWeb("Insert Into tbSSinif1 Values('" & dr("deger").ToString() & "', '" & dr1("sAciklama").ToString() & "', " &
                                                   "'" & dr1("sSinifKodu7").ToString() & "', '" & dr1("sSinifKodu8").ToString() & "')", WebBaglanti) = True Then
                                sorguC.sorgu_tamWeb("Delete From tbWebGuncelVeriler Where (id = " & dr("id").ToString() & ")")
                                sorguC.sorgu_tamWeb("Update tbWebGuncel Set tbSSinif1S = " & tbSSinif1S & ", sonGuncelleme = GETDATE()", WebBaglanti)
                            End If
                        Next
                        ds1 = Nothing
                        dr1 = Nothing
                    ElseIf Integer.Parse(dr("islem").ToString()) = 3 Then
                        ds1 = sorguC.sorgu_DS("SET DATEFORMAT DMY Select * from tbSSinif1 Where (sSinifKodu = '" & dr("deger").ToString() & "')", "TABLE1")
                        For Each dr1 In ds1.Tables(0).Rows
                            sorguC.sorgu_tamWeb("Delete From tbSSinif1 Where (sSinifKodu = '" & dr("deger").ToString() & "')", WebBaglanti)
                            If sorguC.sorgu_tamWeb("Insert Into tbSSinif1 Values('" & dr("deger").ToString() & "', '" & dr1("sAciklama").ToString() & "', " &
                                                   "'" & dr1("sSinifKodu7").ToString() & "', '" & dr1("sSinifKodu8").ToString() & "')", WebBaglanti) = True Then
                                sorguC.sorgu_tamWeb("Delete From tbWebGuncelVeriler Where (id = " & dr("id").ToString() & ")")
                                sorguC.sorgu_tamWeb("Update tbWebGuncel Set tbSSinif1S = " & tbSSinif1S & ", sonGuncelleme = GETDATE()", WebBaglanti)
                            End If
                        Next
                        ds1 = Nothing
                        dr1 = Nothing
                    End If
                    ProgressBarControl1.Position += 1
                    ProgressBarControl1.Refresh()
                Next
                ListBoxControl1.Items.Add("Sýnýf 1 Verileri Aktarýmý Baþarýlý.")
            Catch ex As Exception
                ListBoxControl1.Items.Add("Sýnýf 1 Verileri Aktarýmý Baþarýsýz!")
                MessageBox.Show("Sýnýf 1 Verileri Aktarýmý Baþarýsýz!", "Business Smart")
            End Try
            ds = Nothing
            dr = Nothing
        End If
        If tbSSinif7S <> tbSSinif7SUzak Then
            Try
                ds = sorguC.sorgu_DS("SET DATEFORMAT DMY Select * from tbWebGuncelVeriler Where (tabloAdi = 'tbSSinif7')", "TABLE1")
                ProgressBarControl1.Properties.Maximum = ds.Tables(0).Rows.Count
                ProgressBarControl1.Position = 0
                ProgressBarControl1.Refresh()
                For Each dr In ds.Tables(0).Rows
                    If Integer.Parse(dr("islem").ToString()) = 0 Then
                        If sorguC.sorgu_tamWeb("Delete From tbSSinif7 Where (sSinifKodu = '" & dr("deger").ToString() & "')", WebBaglanti) = True Then
                            sorguC.sorgu_tamWeb("Delete From tbWebGuncelVeriler Where (id = " & dr("id").ToString() & ")")
                            sorguC.sorgu_tamWeb("Update tbWebGuncel Set tbSSinif7S = " & tbSSinif7S & ", sonGuncelleme = GETDATE()", WebBaglanti)
                        End If
                    ElseIf Integer.Parse(dr("islem").ToString()) = 1 Then
                        ds1 = sorguC.sorgu_DS("SET DATEFORMAT DMY Select * from tbSSinif7 Where (sSinifKodu = '" & dr("deger").ToString() & "')", "TABLE1")
                        For Each dr1 In ds1.Tables(0).Rows
                            If Integer.Parse(sorguC.sorgu_Web("SET DATEFORMAT DMY Select Count(*) from tbSSinif7 Where (sSinifKodu = '" & dr("deger").ToString() & "')", WebBaglanti)) > 0 Then
                                If sorguC.sorgu_tamWeb("Update tbSSinif7 Set sAciklama = '" & dr1("sAciklama").ToString() & "', sSinifKodu1 = '" & dr1("sSinifKodu1").ToString() & "', " &
                                                       "sSinifKodu8 = '" & dr1("sSinifKodu8").ToString() & "' Where (sSinifKodu = '" & dr("deger").ToString() & "')", WebBaglanti) = True Then
                                    sorguC.sorgu_tamWeb("Delete From tbWebGuncelVeriler Where (id = " & dr("id").ToString() & ")")
                                    sorguC.sorgu_tamWeb("Update tbWebGuncel Set tbSSinif7S = " & tbSSinif7S & ", sonGuncelleme = GETDATE()", WebBaglanti)
                                End If
                            Else
                                If sorguC.sorgu_tamWeb("Insert Into tbSSinif7 Values('" & dr("deger").ToString() & "', '" & dr1("sAciklama").ToString() & "', " &
                                                       "'" & dr1("sSinifKodu1").ToString() & "', '" & dr1("sSinifKodu8").ToString() & "')", WebBaglanti) = True Then
                                    sorguC.sorgu_tamWeb("Delete From tbWebGuncelVeriler Where (id = " & dr("id").ToString() & ")")
                                    sorguC.sorgu_tamWeb("Update tbWebGuncel Set tbSSinif7S = " & tbSSinif7S & ", sonGuncelleme = GETDATE()", WebBaglanti)
                                End If
                            End If
                        Next
                        ds1 = Nothing
                        dr1 = Nothing
                    ElseIf Integer.Parse(dr("islem").ToString()) = 2 Then
                        ds1 = sorguC.sorgu_DS("SET DATEFORMAT DMY Select * from tbSSinif7 Where (sSinifKodu = '" & dr("deger").ToString() & "')", "TABLE1")
                        For Each dr1 In ds1.Tables(0).Rows
                            If sorguC.sorgu_tamWeb("Insert Into tbSSinif7 Values('" & dr("deger").ToString() & "', '" & dr1("sAciklama").ToString() & "', " &
                                                   "'" & dr1("sSinifKodu1").ToString() & "', '" & dr1("sSinifKodu8").ToString() & "')", WebBaglanti) = True Then
                                sorguC.sorgu_tamWeb("Delete From tbWebGuncelVeriler Where (id = " & dr("id").ToString() & ")")
                                sorguC.sorgu_tamWeb("Update tbWebGuncel Set tbSSinif7S = " & tbSSinif7S & ", sonGuncelleme = GETDATE()", WebBaglanti)
                            End If
                        Next
                        ds1 = Nothing
                        dr1 = Nothing
                    ElseIf Integer.Parse(dr("islem").ToString()) = 3 Then
                        ds1 = sorguC.sorgu_DS("SET DATEFORMAT DMY Select * from tbSSinif7 Where (sSinifKodu = '" & dr("deger").ToString() & "')", "TABLE1")
                        For Each dr1 In ds1.Tables(0).Rows
                            sorguC.sorgu_tamWeb("Delete From tbSSinif7 Where (sSinifKodu = '" & dr("deger").ToString() & "')", WebBaglanti)
                            If sorguC.sorgu_tamWeb("Insert Into tbSSinif7 Values('" & dr("deger").ToString() & "', '" & dr1("sAciklama").ToString() & "', " &
                                                   "'" & dr1("sSinifKodu1").ToString() & "', '" & dr1("sSinifKodu8").ToString() & "')", WebBaglanti) = True Then
                                sorguC.sorgu_tamWeb("Delete From tbWebGuncelVeriler Where (id = " & dr("id").ToString() & ")")
                                sorguC.sorgu_tamWeb("Update tbWebGuncel Set tbSSinif7S = " & tbSSinif7S & ", sonGuncelleme = GETDATE()", WebBaglanti)
                            End If
                        Next
                        ds1 = Nothing
                        dr1 = Nothing
                    End If
                    ProgressBarControl1.Position += 1
                    ProgressBarControl1.Refresh()
                Next
                ListBoxControl1.Items.Add("Sýnýf 7 Verileri Aktarýmý Baþarýlý.")
            Catch ex As Exception
                ListBoxControl1.Items.Add("Sýnýf 7 Verileri Aktarýmý Baþarýsýz!")
                MessageBox.Show("Sýnýf 7 Verileri Aktarýmý Baþarýsýz!", "Business Smart")
            End Try
            ds = Nothing
            dr = Nothing
        End If
        If tbSSinif8S <> tbSSinif8SUzak Then
            Try
                ds = sorguC.sorgu_DS("SET DATEFORMAT DMY Select * from tbWebGuncelVeriler Where (tabloAdi = 'tbSSinif8')", "TABLE1")
                ProgressBarControl1.Properties.Maximum = ds.Tables(0).Rows.Count
                ProgressBarControl1.Position = 0
                ProgressBarControl1.Refresh()
                For Each dr In ds.Tables(0).Rows
                    If Integer.Parse(dr("islem").ToString()) = 0 Then
                        If sorguC.sorgu_tamWeb("Delete From tbSSinif8 Where (sSinifKodu = '" & dr("deger").ToString() & "')", WebBaglanti) = True Then
                            sorguC.sorgu_tamWeb("Delete From tbWebGuncelVeriler Where (id = " & dr("id").ToString() & ")")
                            sorguC.sorgu_tamWeb("Update tbWebGuncel Set tbSSinif8S = " & tbSSinif8S & ", sonGuncelleme = GETDATE()", WebBaglanti)
                        End If
                    ElseIf Integer.Parse(dr("islem").ToString()) = 1 Then
                        ds1 = sorguC.sorgu_DS("SET DATEFORMAT DMY Select * from tbSSinif8 Where (sSinifKodu = '" & dr("deger").ToString() & "')", "TABLE1")
                        For Each dr1 In ds1.Tables(0).Rows
                            If Integer.Parse(sorguC.sorgu_Web("SET DATEFORMAT DMY Select Count(*) from tbSSinif8 Where (sSinifKodu = '" & dr("deger").ToString() & "')", WebBaglanti)) > 0 Then
                                If sorguC.sorgu_tamWeb("Update tbSSinif8 Set sAciklama = '" & dr1("sAciklama").ToString() & "', sSinifKodu1 = '" & dr1("sSinifKodu1").ToString() & "', " &
                                                       "sSinifKodu7 = '" & dr1("sSinifKodu7").ToString() & "' Where (sSinifKodu = '" & dr("deger").ToString() & "')", WebBaglanti) = True Then
                                    sorguC.sorgu_tamWeb("Delete From tbWebGuncelVeriler Where (id = " & dr("id").ToString() & ")")
                                    sorguC.sorgu_tamWeb("Update tbWebGuncel Set tbSSinif8S = " & tbSSinif8S & ", sonGuncelleme = GETDATE()", WebBaglanti)
                                End If
                            Else
                                If sorguC.sorgu_tamWeb("Insert Into tbSSinif8 Values('" & dr("deger").ToString() & "', '" & dr1("sAciklama").ToString() & "', " &
                                                       "'" & dr1("sSinifKodu1").ToString() & "', '" & dr1("sSinifKodu7").ToString() & "')", WebBaglanti) = True Then
                                    sorguC.sorgu_tamWeb("Delete From tbWebGuncelVeriler Where (id = " & dr("id").ToString() & ")")
                                    sorguC.sorgu_tamWeb("Update tbWebGuncel Set tbSSinif8S = " & tbSSinif8S & ", sonGuncelleme = GETDATE()", WebBaglanti)
                                End If
                            End If
                        Next
                        ds1 = Nothing
                        dr1 = Nothing
                    ElseIf Integer.Parse(dr("islem").ToString()) = 2 Then
                        ds1 = sorguC.sorgu_DS("SET DATEFORMAT DMY Select * from tbSSinif8 Where (sSinifKodu = '" & dr("deger").ToString() & "')", "TABLE1")
                        For Each dr1 In ds1.Tables(0).Rows
                            If sorguC.sorgu_tamWeb("Insert Into tbSSinif8 Values('" & dr("deger").ToString() & "', '" & dr1("sAciklama").ToString() & "', " &
                                                   "'" & dr1("sSinifKodu1").ToString() & "', '" & dr1("sSinifKodu7").ToString() & "')", WebBaglanti) = True Then
                                sorguC.sorgu_tamWeb("Delete From tbWebGuncelVeriler Where (id = " & dr("id").ToString() & ")")
                                sorguC.sorgu_tamWeb("Update tbWebGuncel Set tbSSinif8S = " & tbSSinif8S & ", sonGuncelleme = GETDATE()", WebBaglanti)
                            End If
                        Next
                        ds1 = Nothing
                        dr1 = Nothing
                    ElseIf Integer.Parse(dr("islem").ToString()) = 3 Then
                        ds1 = sorguC.sorgu_DS("SET DATEFORMAT DMY Select * from tbSSinif8 Where (sSinifKodu = '" & dr("deger").ToString() & "')", "TABLE1")
                        For Each dr1 In ds1.Tables(0).Rows
                            sorguC.sorgu_tamWeb("Delete From tbSSinif8 Where (sSinifKodu = '" & dr("deger").ToString() & "')", WebBaglanti)
                            If sorguC.sorgu_tamWeb("Insert Into tbSSinif8 Values('" & dr("deger").ToString() & "', '" & dr1("sAciklama").ToString() & "', " &
                                                   "'" & dr1("sSinifKodu1").ToString() & "', '" & dr1("sSinifKodu7").ToString() & "')", WebBaglanti) = True Then
                                sorguC.sorgu_tamWeb("Delete From tbWebGuncelVeriler Where (id = " & dr("id").ToString() & ")")
                                sorguC.sorgu_tamWeb("Update tbWebGuncel Set tbSSinif8S = " & tbSSinif8S & ", sonGuncelleme = GETDATE()", WebBaglanti)
                            End If
                        Next
                        ds1 = Nothing
                        dr1 = Nothing
                    End If
                    ProgressBarControl1.Position += 1
                    ProgressBarControl1.Refresh()
                Next
                ListBoxControl1.Items.Add("Sýnýf 8 Verileri Aktarýmý Baþarýlý.")
            Catch ex As Exception
                ListBoxControl1.Items.Add("Sýnýf 8 Verileri Aktarýmý Baþarýsýz!")
                MessageBox.Show("Sýnýf 8 Verileri Aktarýmý Baþarýsýz!", "Business Smart")
            End Try
            ds = Nothing
            dr = Nothing
        End If
        If tbStokS <> tbStokSUzak Then
            Try
                ds = sorguC.sorgu_DS("SET DATEFORMAT DMY Select * from tbWebGuncelVeriler Where (tabloAdi = 'tbStok')", "TABLE1")
                ProgressBarControl1.Properties.Maximum = ds.Tables(0).Rows.Count
                ProgressBarControl1.Position = 0
                ProgressBarControl1.Refresh()
                For Each dr In ds.Tables(0).Rows
                    If Integer.Parse(dr("islem").ToString()) = 0 Then
                        If sorguC.sorgu_tamWeb("Delete From tbStok Where (nStokID = " & dr("deger").ToString() & ")", WebBaglanti) = True Then
                            sorguC.sorgu_tamWeb("Delete From tbWebGuncelVeriler Where (id = " & dr("id").ToString() & ")")
                            sorguC.sorgu_tamWeb("Update tbWebGuncel Set tbStokS = " & tbStokS & ", sonGuncelleme = GETDATE()", WebBaglanti)
                        End If
                    ElseIf Integer.Parse(dr("islem").ToString()) = 1 Then
                        ds1 = sorguC.sorgu_DS("SET DATEFORMAT DMY Select * from tbStok Where (nStokID = " & dr("deger").ToString() & ")", "TABLE1")
                        For Each dr1 In ds1.Tables(0).Rows
                            If Integer.Parse(sorguC.sorgu_Web("SET DATEFORMAT DMY Select Count(*) from tbStok Where (nStokID = " & dr("deger").ToString() & ")", WebBaglanti)) > 0 Then
                                If sorguC.sorgu_tamWeb("Update tbStok Set sKodu = '" & dr1("sKodu").ToString() & "', sAciklama = '" & dr1("sAciklama").ToString() & "', " &
                                                   "sKisaAdi = '" & dr1("sKisaAdi").ToString() & "', nStokTipi = " & dr1("nStokTipi").ToString() & ", " &
                                                   "sBedenTipi = '" & dr1("sBedenTipi").ToString() & "', sKavalaTipi = '" & dr1("sKavalaTipi").ToString() & "', " &
                                                   "sRenk = '" & dr1("sRenk").ToString() & "', sBeden = '" & dr1("sBeden").ToString() & "', " &
                                                   "sKavala = '" & dr1("sKavala").ToString() & "', sBirimCinsi1 = '" & dr1("sBirimCinsi1").ToString() & "', " &
                                                   "sBirimCinsi2 = '" & dr1("sBirimCinsi2").ToString() & "', nIskontoYuzdesi = " & dr1("nIskontoYuzdesi").ToString() & ", " &
                                                   "sKdvTipi = '" & dr1("sKdvTipi").ToString() & "', " &
                                                   "sOzelNot = '" & dr1("sOzelNot").ToString() & "', sModel = '" & dr1("sModel").ToString() & "', " &
                                                   "dteKayitTarihi = '" & dr1("dteKayitTarihi").ToString() & "', nEn = " & dr1("nEn").ToString() & ", " &
                                                   "nBoy = " & dr1("nBoy").ToString() & ", nYukseklik = " & dr1("nYukseklik").ToString() & ", " &
                                                   "nHacim = " & dr1("nHacim").ToString() & ", nAgirlik = " & dr1("nAgirlik").ToString() & ", " &
                                                   "nWebIskontoYuzdesi = " & dr1("nWebIskontoYuzdesi").ToString() & ", bWebGoruntule = " & Convert.ToInt32(dr1("bWebGoruntule")) & ", " &
                                                   "bWebTavsiye = " & Convert.ToInt32(dr1("bWebTavsiye")) & " Where (nStokID = " & dr("deger").ToString() & ")", WebBaglanti) = True Then
                                    sorguC.sorgu_tamWeb("Delete From tbWebGuncelVeriler Where (id = " & dr("id").ToString() & ")")
                                    sorguC.sorgu_tamWeb("Update tbWebGuncel Set tbStokS = " & tbStokS & ", sonGuncelleme = GETDATE()", WebBaglanti)
                                End If
                            Else
                                If sorguC.sorgu_tamWeb("Insert Into tbStok Values(" & dr("deger").ToString() & ", '" & dr1("sKodu").ToString() & "', '" & dr1("sAciklama").ToString() & "', " &
                                                   "'" & dr1("sKisaAdi").ToString() & "', " & dr1("nStokTipi").ToString() & ", '" & dr1("sBedenTipi").ToString() & "', " &
                                                   "'" & dr1("sKavalaTipi").ToString() & "', '" & dr1("sRenk").ToString() & "', '" & dr1("sBeden").ToString() & "', " &
                                                   "'" & dr1("sKavala").ToString() & "', '" & dr1("sBirimCinsi1").ToString() & "', '" & dr1("sBirimCinsi2").ToString() & "', " &
                                                   "" & dr1("nIskontoYuzdesi").ToString() & ", '" & dr1("sKdvTipi").ToString() & "', '" & dr1("sOzelNot").ToString() & "', " &
                                                   "'" & dr1("sModel").ToString() & "', '" & dr1("dteKayitTarihi").ToString() & "', " & dr1("nEn").ToString() & ", " &
                                                   "" & dr1("nBoy").ToString() & ", " & dr1("nYukseklik").ToString() & ", " & dr1("nHacim").ToString() & ", " & dr1("nAgirlik").ToString() & ", " &
                                                   "" & dr1("nWebIskontoYuzdesi").ToString() & ", " & Convert.ToInt32(dr1("bWebGoruntule")) & ", " &
                                                   "" & Convert.ToInt32(dr1("bWebTavsiye")) & ",'','','','','',0.00)", WebBaglanti) = True Then
                                    sorguC.sorgu_tamWeb("Delete From tbWebGuncelVeriler Where (id = " & dr("id").ToString() & ")")
                                    sorguC.sorgu_tamWeb("Update tbWebGuncel Set tbStokS = " & tbStokS & ", sonGuncelleme = GETDATE()", WebBaglanti)
                                End If
                            End If
                        Next
                        ds1 = Nothing
                        dr1 = Nothing
                    ElseIf Integer.Parse(dr("islem").ToString()) = 2 Then
                        ds1 = sorguC.sorgu_DS("SET DATEFORMAT DMY Select * from tbStok Where (nStokID = " & dr("deger").ToString() & ")", "TABLE1")
                        For Each dr1 In ds1.Tables(0).Rows
                            If sorguC.sorgu_tamWeb("Insert Into tbStok Values(" & dr("deger").ToString() & ", '" & dr1("sKodu").ToString() & "', '" & dr1("sAciklama").ToString() & "', " &
                                                   "'" & dr1("sKisaAdi").ToString() & "', " & dr1("nStokTipi").ToString() & ", '" & dr1("sBedenTipi").ToString() & "', " &
                                                   "'" & dr1("sKavalaTipi").ToString() & "', '" & dr1("sRenk").ToString() & "', '" & dr1("sBeden").ToString() & "', " &
                                                   "'" & dr1("sKavala").ToString() & "', '" & dr1("sBirimCinsi1").ToString() & "', '" & dr1("sBirimCinsi2").ToString() & "', " &
                                                   "" & dr1("nIskontoYuzdesi").ToString() & ", '" & dr1("sKdvTipi").ToString() & "', '" & dr1("sOzelNot").ToString() & "', " &
                                                   "'" & dr1("sModel").ToString() & "', '" & dr1("dteKayitTarihi").ToString() & "', " & dr1("nEn").ToString() & ", " &
                                                   "" & dr1("nBoy").ToString() & ", " & dr1("nYukseklik").ToString() & ", " & dr1("nHacim").ToString() & ", " & dr1("nAgirlik").ToString() & ", " &
                                                   "" & dr1("nWebIskontoYuzdesi").ToString() & ", " & Convert.ToInt32(dr1("bWebGoruntule")) & ", " &
                                                   "" & Convert.ToInt32(dr1("bWebTavsiye")) & ",'','','','','',0.00)", WebBaglanti) = True Then
                                sorguC.sorgu_tamWeb("Delete From tbWebGuncelVeriler Where (id = " & dr("id").ToString() & ")")
                                sorguC.sorgu_tamWeb("Update tbWebGuncel Set tbStokS = " & tbStokS & ", sonGuncelleme = GETDATE()", WebBaglanti)
                            End If
                        Next
                        ds1 = Nothing
                        dr1 = Nothing
                    ElseIf Integer.Parse(dr("islem").ToString()) = 3 Then
                        ds1 = sorguC.sorgu_DS("SET DATEFORMAT DMY Select * from tbStok Where (nStokID = " & dr("deger").ToString() & ")", "TABLE1")
                        For Each dr1 In ds1.Tables(0).Rows
                            sorguC.sorgu_tamWeb("Delete From tbStok Where (nStokID = " & dr("deger").ToString() & ")", WebBaglanti)
                            If sorguC.sorgu_tamWeb("Insert Into tbStok Values(" & dr("deger").ToString() & ", '" & dr1("sKodu").ToString() & "', '" & dr1("sAciklama").ToString() & "', " &
                                                   "'" & dr1("sKisaAdi").ToString() & "', " & dr1("nStokTipi").ToString() & ", '" & dr1("sBedenTipi").ToString() & "', " &
                                                   "'" & dr1("sKavalaTipi").ToString() & "', '" & dr1("sRenk").ToString() & "', '" & dr1("sBeden").ToString() & "', " &
                                                   "'" & dr1("sKavala").ToString() & "', '" & dr1("sBirimCinsi1").ToString() & "', '" & dr1("sBirimCinsi2").ToString() & "', " &
                                                   "" & dr1("nIskontoYuzdesi").ToString() & ", '" & dr1("sKdvTipi").ToString() & "', '" & dr1("sOzelNot").ToString() & "', " &
                                                   "'" & dr1("sModel").ToString() & "', '" & dr1("dteKayitTarihi").ToString() & "', " & dr1("nEn").ToString() & ", " &
                                                   "" & dr1("nBoy").ToString() & ", " & dr1("nYukseklik").ToString() & ", " & dr1("nHacim").ToString() & ", " & dr1("nAgirlik").ToString() & ", " &
                                                   "" & dr1("nWebIskontoYuzdesi").ToString() & ", " & Convert.ToInt32(dr1("bWebGoruntule")) & ", " &
                                                   "" & Convert.ToInt32(dr1("bWebTavsiye")) & ",'','','','','',0.00)", WebBaglanti) = True Then
                                sorguC.sorgu_tamWeb("Delete From tbWebGuncelVeriler Where (id = " & dr("id").ToString() & ")")
                                sorguC.sorgu_tamWeb("Update tbWebGuncel Set tbStokS = " & tbStokS & ", sonGuncelleme = GETDATE()", WebBaglanti)
                            End If
                        Next
                        ds1 = Nothing
                        dr1 = Nothing
                    End If
                    ProgressBarControl1.Position += 1
                    ProgressBarControl1.Refresh()
                Next
                ListBoxControl1.Items.Add("Stok Verileri Aktarýmý Baþarýlý.")
            Catch ex As Exception
                ListBoxControl1.Items.Add("Stok Verileri Aktarýmý Baþarýsýz!")
                MessageBox.Show("Stok Verileri Aktarýmý Baþarýsýz!", "Business Smart")
            End Try
            ds = Nothing
            dr = Nothing
        End If
        If tbStokResmiS <> tbStokResmiSUzak Then
            Try
                ds = sorguC.sorgu_DS("SET DATEFORMAT DMY Select * from tbWebGuncelVeriler Where (tabloAdi = 'tbStokResmi')", "TABLE1")
                ProgressBarControl1.Properties.Maximum = ds.Tables(0).Rows.Count
                ProgressBarControl1.Position = 0
                ProgressBarControl1.Refresh()
                For Each dr In ds.Tables(0).Rows
                    If Integer.Parse(dr("islem").ToString()) = 0 Then
                        If sorguC.sorgu_tamWeb("Delete From tbStokResmi Where (sModel = '" & dr("deger").ToString() & "') AND (nSira = " & dr("nSira").ToString() & ")", WebBaglanti) = True Then
                            sorguC.sorgu_tamWeb("Delete From tbWebGuncelVeriler Where (id = " & dr("id").ToString() & ") AND (nSira = " & dr("nSira").ToString() & ")")
                            sorguC.sorgu_tamWeb("Update tbWebGuncel Set tbStokResmiS = " & tbStokResmiS & ", sonGuncelleme = GETDATE()", WebBaglanti)
                        End If
                        'ElseIf Integer.Parse(dr("islem").ToString()) = 1 Then
                        '    ds1 = sorguC.sorgu_DS("SET DATEFORMAT DMY Select * from tbStokResmi Where (sModel = '" & dr("deger").ToString() & "')", "TABLE1")
                        '    For Each dr1 In ds1.Tables(0).Rows
                        '        If Integer.Parse(sorguC.sorgu_Web("SET DATEFORMAT DMY Select Count(*) from tbStokResmi Where (sModel = '" & dr("deger").ToString() & "')", WebBaglanti)) > 0 Then
                        '            If sorguC.sorgu_tamWeb("Update tbStokResmi Set pResim = '" & dr1("pResim").ToString() & "', " &
                        '                                   "sAciklama = '" & dr1("sAciklama").ToString() & "', nSira = " & dr1("nSira").ToString() & ", sKullaniciAdi = '" &
                        '                                   dr1("sKullaniciAdi").ToString() & "', dteKayitTarihi = '" & dr1("dteKayitTarihi").ToString() & "' Where (sModel = '" &
                        '                                   dr("deger").ToString() & "')", WebBaglanti) = True Then
                        '                sorguC.sorgu_tamWeb("Delete From tbWebGuncelVeriler Where (id = " & dr("id").ToString() & ")")
                        '                sorguC.sorgu_tamWeb("Update tbWebGuncel Set tbStokResmiS = " & tbStokResmiS & ", sonGuncelleme = GETDATE()", WebBaglanti)
                        '            End If
                        '        Else
                        '            If sorguC.sorgu_tamWeb("Insert Into tbStokResmi Values('" & dr("deger").ToString() & "', '" & dr1("pResim").ToString() & "', " &
                        '                                   "'" & dr1("sAciklama").ToString() & "', " & dr1("nSira").ToString() & ", '" & dr1("sKullaniciAdi").ToString() & "', " &
                        '                                   "'" & dr1("dteKayitTarihi").ToString() & "')", WebBaglanti) = True Then
                        '                sorguC.sorgu_tamWeb("Delete From tbWebGuncelVeriler Where (id = " & dr("id").ToString() & ")")
                        '                sorguC.sorgu_tamWeb("Update tbWebGuncel Set tbStokResmiS = " & tbStokResmiS & ", sonGuncelleme = GETDATE()", WebBaglanti)
                        '            End If
                        '        End If
                        '    Next
                        '    ds1 = Nothing
                        '    dr1 = Nothing
                        'ElseIf Integer.Parse(dr("islem").ToString()) = 2 Then
                        '    ds1 = sorguC.sorgu_DS("SET DATEFORMAT DMY Select * from tbStokResmi Where (sModel = '" & dr("deger").ToString() & "')", "TABLE1")
                        '    For Each dr1 In ds1.Tables(0).Rows
                        '        If sorguC.sorgu_tamWeb("Insert Into tbStokResmi Values('" & dr("deger").ToString() & "', '" & dr1("pResim").ToString() & "', " &
                        '                               "'" & dr1("sAciklama").ToString() & "', " & dr1("nSira").ToString() & ", '" & dr1("sKullaniciAdi").ToString() & "', " &
                        '                               "'" & dr1("dteKayitTarihi").ToString() & "')", WebBaglanti) = True Then
                        '            sorguC.sorgu_tamWeb("Delete From tbWebGuncelVeriler Where (id = " & dr("id").ToString() & ")")
                        '            sorguC.sorgu_tamWeb("Update tbWebGuncel Set tbStokResmiS = " & tbStokResmiS & ", sonGuncelleme = GETDATE()", WebBaglanti)
                        '        End If
                        '    Next
                        '    ds1 = Nothing
                        '    dr1 = Nothing
                    ElseIf Integer.Parse(dr("islem").ToString()) = 1 Or Integer.Parse(dr("islem").ToString()) = 2 Or Integer.Parse(dr("islem").ToString()) = 3 Then
                        ds_tbStokResmi = sorguC.sorgu_DS("SET DATEFORMAT DMY Select sModel,pResim,sAciklama,nSira,sKullaniciAdi,dteKayitTarihi,yol from tbStokResmi Where (sModel = '" & dr("deger").ToString() & "')", "TABLE1")
                        ds_tbStokResmiAt = sorguC.sorgu_DS("SET DATEFORMAT DMY Select sModel,pResim,sAciklama,nSira,sKullaniciAdi,dteKayitTarihi from tbStokResmi Where (sModel = '" & dr("deger").ToString() & "')", "TABLE1")
                        ds_tbStokResmiAt.Tables(0).Clear()
                        Dim i As Integer = 0
                        Dim drResim As DataRow
                        sorguC.sorgu_tamWeb("Delete From tbStokResmi Where (sModel = '" & dr("deger").ToString() & "')", WebBaglanti)
                        For Each drResim In ds_tbStokResmi.Tables(0).Rows
                            Dim yeniAdi As String = Trim(dr("deger").ToString()) & i.ToString()
                            Dim fs As New FileStream(drResim("yol").ToString(), FileMode.Open, FileAccess.Read)
                            Dim MyData(fs.Length) As Byte
                            fs.Read(MyData, 0, fs.Length)
                            fs.Close()
                            Dim drRes As DataRow
                            drRes = ds_tbStokResmiAt.Tables(0).NewRow
                            drRes("sModel") = dr("deger").ToString()
                            drRes("pResim") = MyData
                            drRes("sAciklama") = drResim("sAciklama").ToString()
                            drRes("nSira") = drResim("nSira")
                            drRes("sKullaniciAdi") = drResim("sKullaniciAdi")
                            drRes("dteKayitTarihi") = Now
                            ds_tbStokResmiAt.Tables(0).Rows.Add(drRes)
                            Dim da As New OleDb.OleDbDataAdapter
                            Dim cmd As New OleDb.OleDbCommand
                            Dim con As New OleDb.OleDbConnection
                            da.InsertCommand = cmd
                            cmd.Connection = con
                            con.ConnectionString = WebBaglanti
                            cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbStokResmi (sModel,pResim,sAciklama,nSira,sKullaniciAdi,dteKayitTarihi) VALUES (?,?,?,?,?,?) "
                            cmd.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("sModel", System.Data.OleDb.OleDbType.[Char], 0, "sModel"), New System.Data.OleDb.OleDbParameter("pResim", System.Data.OleDb.OleDbType.VarBinary, 2147483647, "pResim"), New System.Data.OleDb.OleDbParameter("sAciklama", System.Data.OleDb.OleDbType.[Char], 0, "sAciklama"), New System.Data.OleDb.OleDbParameter("nSira", System.Data.OleDb.OleDbType.[Integer], 0, "nSira"), New System.Data.OleDb.OleDbParameter("sKullaniciAdi", System.Data.OleDb.OleDbType.[Char], 0, "sKullaniciAdi"), New System.Data.OleDb.OleDbParameter("dteKayitTarihi", System.Data.OleDb.OleDbType.DBTimeStamp, 0, "dteKayitTarihi")})
                            da.Update(ds_tbStokResmiAt.Tables(0))
                            da = Nothing
                        Next
                        sorguC.sorgu_tamWeb("Delete From tbWebGuncelVeriler Where (id = " & dr("id").ToString() & ")")
                        sorguC.sorgu_tamWeb("Update tbWebGuncel Set tbStokResmiS = " & tbStokResmiS & ", sonGuncelleme = GETDATE()", WebBaglanti)
                        ds1 = Nothing
                        dr1 = Nothing
                    End If
                    ProgressBarControl1.Position += 1
                    ProgressBarControl1.Refresh()
                Next
                ListBoxControl1.Items.Add("Stok Resim Verileri Aktarýmý Baþarýlý.")
            Catch ex As Exception
                ListBoxControl1.Items.Add("Stok Resim Verileri Aktarýmý Baþarýsýz!")
                MessageBox.Show("Stok Resim Verileri Aktarýmý Baþarýsýz!", "Business Smart")
            End Try
            ds = Nothing
            dr = Nothing
        End If
        If tbStokSinifiS <> tbStokSinifiSUzak Then
            Try
                ds = sorguC.sorgu_DS("SET DATEFORMAT DMY Select * from tbWebGuncelVeriler Where (tabloAdi = 'tbStokSinifi')")
                ProgressBarControl1.Properties.Maximum = ds.Tables(0).Rows.Count
                ProgressBarControl1.Position = 0
                ProgressBarControl1.Refresh()
                For Each dr In ds.Tables(0).Rows
                    If Integer.Parse(dr("islem").ToString()) = 0 Then
                        If sorguC.sorgu_tamWeb("Delete From tbStokSinifi Where (nStokID = " & dr("deger").ToString() & ")", WebBaglanti) = True Then
                            sorguC.sorgu_tamWeb("Delete From tbWebGuncelVeriler Where (id = " & dr("id").ToString() & ")")
                            sorguC.sorgu_tamWeb("Update tbWebGuncel Set tbStokSinifiS = " & tbStokSinifiS & ", sonGuncelleme = GETDATE()", WebBaglanti)
                        End If
                    ElseIf Integer.Parse(dr("islem").ToString()) = 1 Then
                        ds1 = sorguC.sorgu_DS("SET DATEFORMAT DMY Select * from tbStokSinifi Where (nStokID = " & dr("deger").ToString() & ")", "TABLE1")
                        For Each dr1 In ds1.Tables(0).Rows
                            If Integer.Parse(sorguC.sorgu_Web("SET DATEFORMAT DMY Select Count(*) from tbStokSinifi Where (nStokID = " & dr("deger").ToString() & ")", WebBaglanti)) > 0 Then
                                If sorguC.sorgu_tamWeb("Update tbStokSinifi Set sSinifKodu1 = '" & dr1("sSinifKodu1").ToString() & "', sSinifKodu7 = '" & dr1("sSinifKodu7").ToString() & "', " &
                                                       "sSinifKodu8 = '" & dr1("sSinifKodu8").ToString() & "' Where (nStokID = " & dr("deger").ToString() & ")", WebBaglanti) = True Then
                                    sorguC.sorgu_tamWeb("Delete From tbWebGuncelVeriler Where (id = " & dr("id").ToString() & ")")
                                    sorguC.sorgu_tamWeb("Update tbWebGuncel Set tbStokSinifiS = " & tbStokSinifiS & ", sonGuncelleme = GETDATE()", WebBaglanti)
                                End If
                            Else
                                If sorguC.sorgu_tamWeb("Insert Into tbStokSinifi Values(" & dr("deger").ToString() & ", '" & dr1("sSinifKodu1").ToString() & "', " &
                                                       "'" & dr1("sSinifKodu7").ToString() & "', '" & dr1("sSinifKodu8").ToString() & "')", WebBaglanti) = True Then
                                    sorguC.sorgu_tamWeb("Delete From tbWebGuncelVeriler Where (id = " & dr("id").ToString() & ")")
                                    sorguC.sorgu_tamWeb("Update tbWebGuncel Set tbStokSinifiS = " & tbStokSinifiS & ", sonGuncelleme = GETDATE()", WebBaglanti)
                                End If
                            End If
                        Next
                        ds1 = Nothing
                        dr1 = Nothing
                    ElseIf Integer.Parse(dr("islem").ToString()) = 2 Then
                        ds1 = sorguC.sorgu_DS("SET DATEFORMAT DMY Select * from tbStokSinifi Where (nStokID = " & dr("deger").ToString() & ")", "TABLE1")
                        For Each dr1 In ds1.Tables(0).Rows
                            If sorguC.sorgu_tamWeb("Insert Into tbStokSinifi Values(" & dr("deger").ToString() & ", '" & dr1("sSinifKodu1").ToString() & "', " &
                                                   "'" & dr1("sSinifKodu7").ToString() & "', '" & dr1("sSinifKodu8").ToString() & "')", WebBaglanti) = True Then
                                sorguC.sorgu_tamWeb("Delete From tbWebGuncelVeriler Where (id = " & dr("id").ToString() & ")")
                                sorguC.sorgu_tamWeb("Update tbWebGuncel Set tbStokSinifiS = " & tbStokSinifiS & ", sonGuncelleme = GETDATE()", WebBaglanti)
                            End If
                        Next
                        ds1 = Nothing
                        dr1 = Nothing
                    ElseIf Integer.Parse(dr("islem").ToString()) = 3 Then
                        ds1 = sorguC.sorgu_DS("SET DATEFORMAT DMY Select * from tbStokSinifi Where (nStokID = " & dr("deger").ToString() & ")", "TABLE1")
                        For Each dr1 In ds1.Tables(0).Rows
                            sorguC.sorgu_tamWeb("Delete From tbStokSinifi Where (nStokID = " & dr("deger").ToString() & ")", WebBaglanti)
                            If sorguC.sorgu_tamWeb("Insert Into tbStokSinifi Values(" & dr("deger").ToString() & ", '" & dr1("sSinifKodu1").ToString() & "', " &
                                                   "'" & dr1("sSinifKodu7").ToString() & "', '" & dr1("sSinifKodu8").ToString() & "')", WebBaglanti) = True Then
                                sorguC.sorgu_tamWeb("Delete From tbWebGuncelVeriler Where (id = " & dr("id").ToString() & ")")
                                sorguC.sorgu_tamWeb("Update tbWebGuncel Set tbStokSinifiS = " & tbStokSinifiS & ", sonGuncelleme = GETDATE()", WebBaglanti)
                            End If
                        Next
                        ds1 = Nothing
                        dr1 = Nothing
                    End If
                    ProgressBarControl1.Position += 1
                    ProgressBarControl1.Refresh()
                Next
                ListBoxControl1.Items.Add("Stok Sýnýf Verileri Aktarýmý Baþarýlý.")
            Catch ex As Exception
                ListBoxControl1.Items.Add("Stok Sýnýf Verileri Aktarýmý Baþarýsýz!")
                MessageBox.Show("Stok Sýnýf Veriler,i Aktarýmý Baþarýsýz!", "Business Smart")
            End Try
            ds = Nothing
            dr = Nothing
        End If
        If tbStokFiyatiS <> tbStokFiyatiSUzak Then
            Try
                ds = sorguC.sorgu_DS("SET DATEFORMAT DMY Select * from tbWebGuncelVeriler Where (tabloAdi = 'tbStokFiyati')")
                ProgressBarControl1.Properties.Maximum = ds.Tables(0).Rows.Count
                ProgressBarControl1.Position = 0
                ProgressBarControl1.Refresh()
                For Each dr In ds.Tables(0).Rows
                    If Integer.Parse(dr("islem").ToString()) = 0 Then
                        If sorguC.sorgu_tamWeb("Delete From tbStokFiyati Where (nStokID = " & dr("deger").ToString() & ")", WebBaglanti) = True Then
                            sorguC.sorgu_tamWeb("Delete From tbWebGuncelVeriler Where (id = " & dr("id").ToString() & ")")
                            sorguC.sorgu_tamWeb("Update tbWebGuncel Set tbStokFiyatiS = " & tbStokFiyatiS & ", sonGuncelleme = GETDATE()", WebBaglanti)
                        End If
                    ElseIf Integer.Parse(dr("islem").ToString()) = 1 Then
                        ds1 = sorguC.sorgu_DS("SET DATEFORMAT DMY Select * from tbStokFiyati Where (nStokID = " & dr("deger").ToString() & ") AND (sFiyatTipi IN('WEBP', 'WEBK'))", "TABLE1")
                        For Each dr1 In ds1.Tables(0).Rows
                            If Integer.Parse(sorguC.sorgu_Web("SET DATEFORMAT DMY Select Count(*) from tbStokFiyati Where (nStokID = " & dr("deger").ToString() & ")", WebBaglanti)) > 0 Then
                                If sorguC.sorgu_tamWeb("Update tbStokFiyati Set sFiyatTipi = '" & dr1("sFiyatTipi").ToString() & "', lFiyat = " & dr1("lFiyat").ToString() & ", " &
                                                       "dteFiyatTespitTarihi = '" & dr1("dteFiyatTespitTarihi").ToString() & "', sKullaniciAdi = '" & dr1("sKullaniciAdi") & "', " &
                                                       "dteKayitTarihi = '" & dr1("dteKayitTarihi") & "' Where (nStokID = " & dr("deger").ToString() & ")", WebBaglanti) = True Then
                                    sorguC.sorgu_tamWeb("Delete From tbWebGuncelVeriler Where (id = " & dr("id").ToString() & ")")
                                    sorguC.sorgu_tamWeb("Update tbWebGuncel Set tbStokFiyatiS = " & tbStokSinifiS & ", sonGuncelleme = GETDATE()", WebBaglanti)
                                End If
                            Else
                                If sorguC.sorgu_tamWeb("Insert Into tbStokFiyati Values(" & dr("deger").ToString() & ", '" & dr1("sFiyatTipi").ToString() & "', " &
                                                       "" & dr1("lFiyat").ToString() & ", '" & dr1("dteFiyatTespitTarihi").ToString() & "', '" & dr1("sKullaniciAdi") &
                                                       "', '" & dr1("dteKayitTarihi") & "')", WebBaglanti) = True Then
                                    sorguC.sorgu_tamWeb("Delete From tbWebGuncelVeriler Where (id = " & dr("id").ToString() & ")")
                                    sorguC.sorgu_tamWeb("Update tbWebGuncel Set tbStokFiyatiS = " & tbStokSinifiS & ", sonGuncelleme = GETDATE()", WebBaglanti)
                                End If
                            End If
                        Next
                        ds1 = Nothing
                        dr1 = Nothing
                    ElseIf Integer.Parse(dr("islem").ToString()) = 2 Then
                        ds1 = sorguC.sorgu_DS("SET DATEFORMAT DMY Select * from tbStokFiyati Where (nStokID = " & dr("deger").ToString() & ") AND (sFiyatTipi IN('WEBP', 'WEBK'))", "TABLE1")
                        For Each dr1 In ds1.Tables(0).Rows
                            If sorguC.sorgu_tamWeb("Insert Into tbStokFiyati Values(" & dr("deger").ToString() & ", '" & dr1("sFiyatTipi").ToString() & "', " &
                                                   "" & dr1("lFiyat").ToString() & ", '" & dr1("dteFiyatTespitTarihi").ToString() & "', '" & dr1("sKullaniciAdi") &
                                                   "', '" & dr1("dteKayitTarihi") & "')", WebBaglanti) = True Then
                                sorguC.sorgu_tamWeb("Delete From tbWebGuncelVeriler Where (id = " & dr("id").ToString() & ")")
                                sorguC.sorgu_tamWeb("Update tbWebGuncel Set tbStokFiyatiS = " & tbStokSinifiS & ", sonGuncelleme = GETDATE()", WebBaglanti)
                            End If
                        Next
                        ds1 = Nothing
                        dr1 = Nothing
                    ElseIf Integer.Parse(dr("islem").ToString()) = 3 Then
                        ds1 = sorguC.sorgu_DS("SET DATEFORMAT DMY Select * from tbStokFiyati Where (nStokID = " & dr("deger").ToString() & ") AND (sFiyatTipi IN('WEBP', 'WEBK'))", "TABLE1")
                        For Each dr1 In ds1.Tables(0).Rows
                            sorguC.sorgu_tamWeb("Delete From tbStokFiyati Where (nStokID = " & dr("deger").ToString() & ")", WebBaglanti)
                            If sorguC.sorgu_tamWeb("Insert Into tbStokFiyati Values(" & dr("deger").ToString() & ", '" & dr1("sFiyatTipi").ToString() & "', " &
                                                   "" & dr1("lFiyat").ToString() & ", '" & dr1("dteFiyatTespitTarihi").ToString() & "', '" & dr1("sKullaniciAdi") &
                                                   "', '" & dr1("dteKayitTarihi") & "')", WebBaglanti) = True Then
                                sorguC.sorgu_tamWeb("Delete From tbWebGuncelVeriler Where (id = " & dr("id").ToString() & ")")
                                sorguC.sorgu_tamWeb("Update tbWebGuncel Set tbStokFiyatiS = " & tbStokSinifiS & ", sonGuncelleme = GETDATE()", WebBaglanti)
                            End If
                        Next
                        ds1 = Nothing
                        dr1 = Nothing
                    End If
                    ProgressBarControl1.Position += 1
                    ProgressBarControl1.Refresh()
                Next
                ListBoxControl1.Items.Add("Stok Fiyat Verileri Aktarýmý Baþarýlý.")
            Catch ex As Exception
                ListBoxControl1.Items.Add("Stok Fiyat Verileri Aktarýmý Baþarýsýz!")
                MessageBox.Show("Stok Fiyat Verileri Aktarýmý Baþarýsýz!", "Business Smart")
            End Try
            ds = Nothing
            dr = Nothing
        End If
        If tbStokUzunNotS <> tbStokUzunNotSUzak Then
            Try
                ds = sorguC.sorgu_DS("SET DATEFORMAT DMY Select * from tbWebGuncelVeriler Where (tabloAdi = 'tbStokUzunNot')")
                ProgressBarControl1.Properties.Maximum = ds.Tables(0).Rows.Count
                ProgressBarControl1.Position = 0
                ProgressBarControl1.Refresh()
                For Each dr In ds.Tables(0).Rows
                    If Integer.Parse(dr("islem").ToString()) = 0 Then
                        If sorguC.sorgu_tamWeb("Delete From tbStokUzunNot Where (sModel = '" & dr("deger").ToString() & "')", WebBaglanti) = True Then
                            sorguC.sorgu_tamWeb("Delete From tbWebGuncelVeriler Where (id = " & dr("id").ToString() & ")")
                            sorguC.sorgu_tamWeb("Update tbWebGuncel Set tbStokUzunNotS = " & tbStokUzunNotS & ", sonGuncelleme = GETDATE()", WebBaglanti)
                        End If
                    ElseIf Integer.Parse(dr("islem").ToString()) = 1 Then
                        ds1 = sorguC.sorgu_DS("SET DATEFORMAT DMY Select * from tbStokUzunNot Where (sModel = '" & dr("deger").ToString() & "')", "TABLE1")
                        For Each dr1 In ds1.Tables(0).Rows
                            If Integer.Parse(sorguC.sorgu_Web("SET DATEFORMAT DMY Select Count(*) from tbStokUzunNot Where (sModel = '" & dr("deger").ToString() & "')", WebBaglanti)) > 0 Then
                                If sorguC.sorgu_tamWeb("Update tbStokUzunNot Set sUzunNot = '" & dr1("sUzunNot").ToString() & "', sSonKullaniciAdi = '" & dr1("sSonKullaniciAdi").ToString() &
                                                       "', " & "dteSonUpdateTarihi = '" & dr1("dteSonUpdateTarihi").ToString() & "' Where (sModel = '" & dr("deger").ToString() & "')", WebBaglanti) = True Then
                                    sorguC.sorgu_tamWeb("Delete From tbWebGuncelVeriler Where (id = " & dr("id").ToString() & ")")
                                    sorguC.sorgu_tamWeb("Update tbWebGuncel Set tbStokUzunNotS = " & tbStokUzunNotS & ", sonGuncelleme = GETDATE()", WebBaglanti)
                                End If
                            Else
                                If sorguC.sorgu_tamWeb("Insert Into tbStokUzunNot Values('" & dr("deger").ToString() & "', '" & dr1("sUzunNot").ToString() & "', " &
                                                       "'" & dr1("sSonKullaniciAdi").ToString() & "', '" & dr1("dteSonUpdateTarihi").ToString() & "')", WebBaglanti) = True Then
                                    sorguC.sorgu_tamWeb("Delete From tbWebGuncelVeriler Where (id = " & dr("id").ToString() & ")")
                                    sorguC.sorgu_tamWeb("Update tbWebGuncel Set tbStokUzunNotS = " & tbStokUzunNotS & ", sonGuncelleme = GETDATE()", WebBaglanti)
                                End If
                            End If
                        Next
                        ds1 = Nothing
                        dr1 = Nothing
                    ElseIf Integer.Parse(dr("islem").ToString()) = 2 Then
                        ds1 = sorguC.sorgu_DS("SET DATEFORMAT DMY Select * from tbStokUzunNot Where (sModel = '" & dr("deger").ToString() & "')", "TABLE1")
                        For Each dr1 In ds1.Tables(0).Rows
                            If sorguC.sorgu_tamWeb("Insert Into tbStokUzunNot Values('" & dr("deger").ToString() & "', '" & dr1("sUzunNot").ToString() & "', " &
                                                   "'" & dr1("sSonKullaniciAdi").ToString() & "', '" & dr1("dteSonUpdateTarihi").ToString() & "')", WebBaglanti) = True Then
                                sorguC.sorgu_tamWeb("Delete From tbWebGuncelVeriler Where (id = " & dr("id").ToString() & ")")
                                sorguC.sorgu_tamWeb("Update tbWebGuncel Set tbStokUzunNotS = " & tbStokUzunNotS & ", sonGuncelleme = GETDATE()", WebBaglanti)
                            End If
                        Next
                        ds1 = Nothing
                        dr1 = Nothing
                    ElseIf Integer.Parse(dr("islem").ToString()) = 3 Then
                        ds1 = sorguC.sorgu_DS("SET DATEFORMAT DMY Select * from tbStokUzunNot Where (sModel = '" & dr("deger").ToString() & "')", "TABLE1")
                        For Each dr1 In ds1.Tables(0).Rows
                            sorguC.sorgu_tamWeb("Delete From tbStokUzunNot Where (sModel = '" & dr("deger").ToString() & "')", WebBaglanti)
                            If sorguC.sorgu_tamWeb("Insert Into tbStokUzunNot Values('" & dr("deger").ToString() & "', '" & dr1("sUzunNot").ToString() & "', " &
                                                   "'" & dr1("sSonKullaniciAdi").ToString() & "', '" & dr1("dteSonUpdateTarihi").ToString() & "')", WebBaglanti) = True Then
                                sorguC.sorgu_tamWeb("Delete From tbWebGuncelVeriler Where (id = " & dr("id").ToString() & ")")
                                sorguC.sorgu_tamWeb("Update tbWebGuncel Set tbStokUzunNotS = " & tbStokUzunNotS & ", sonGuncelleme = GETDATE()", WebBaglanti)
                            End If
                        Next
                        ds1 = Nothing
                        dr1 = Nothing
                    End If
                    ProgressBarControl1.Position += 1
                    ProgressBarControl1.Refresh()
                Next
                ListBoxControl1.Items.Add("Stok Not Verileri Aktarýmý Baþarýlý.")
            Catch ex As Exception
                ListBoxControl1.Items.Add("Stok Not Verileri Aktarýmý Baþarýsýz!")
                MessageBox.Show("Stok Not Verileri Aktarýmý Baþarýsýz!", "Business Smart")
            End Try
            ds = Nothing
            dr = Nothing
        End If
        Me.Enabled = True
    End Sub
    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        Try
            If XtraMessageBox.Show("Sýfýrdan Web Aktarým Ýþlemini Baþlatmak Ýstiyormusunuz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                sorguC.sorgu_tamWeb("Delete From tbWebGuncelVeriler")
                sorguC.sorgu_tamWeb("insert tbWebGuncelVeriler Select 3, 'tbSSinif1', sSinifKodu, GETDATE(), ROW_NUMBER() over (order by ssinifkodu) as row From tbSSinif1")
                sorguC.sorgu_tamWeb("insert tbWebGuncelVeriler Select 3, 'tbSSinif7', sSinifKodu, GETDATE(), ROW_NUMBER() over (order by ssinifkodu) as row From tbSSinif7")
                sorguC.sorgu_tamWeb("insert tbWebGuncelVeriler Select 3, 'tbSSinif8', sSinifKodu, GETDATE(), ROW_NUMBER() over (order by ssinifkodu) as row From tbSSinif8")
                sorguC.sorgu_tamWeb("insert tbWebGuncelVeriler Select 3, 'tbStok', nStokID, GETDATE(), ROW_NUMBER() over (order by nStokID) as row From tbStok where (bWebGoruntule = 1)")
                sorguC.sorgu_tamWeb("insert tbWebGuncelVeriler Select 3, 'tbStokResmi', sModel, GETDATE(), ROW_NUMBER() over (order by sModel) as row From tbStokResmi Where (sModel IN(Select sModel From tbStok Where (bWebGoruntule = 1)))")
                sorguC.sorgu_tamWeb("insert tbWebGuncelVeriler Select 3, 'tbStokUzunNot', sModel, GETDATE(), ROW_NUMBER() over (order by sModel) as row From tbStokUzunNot Where (sModel IN(Select sModel From tbStok Where (bWebGoruntule = 1)))")
                sorguC.sorgu_tamWeb("insert tbWebGuncelVeriler Select 3, 'tbStokSinifi', nStokID, GETDATE(), ROW_NUMBER() over (order by nStokID) as row From tbStokSinifi Where (nStokID IN(Select nStokID From tbStok Where (bWebGoruntule = 1)))")
                sorguC.sorgu_tamWeb("insert tbWebGuncelVeriler Select 3, 'tbStokFiyati', nStokID, GETDATE(), ROW_NUMBER() over (order by nStokID) as row From tbStokFiyati Where (nStokID IN(Select nStokID From tbStok Where (bWebGoruntule = 1))) AND (sFiyatTipi IN('WEBP', 'WEBK'))")
                sorguC.sorgu_tamWeb("update tbWebGuncel Set tbSSinif1S += 5, tbSSinif7S += 5, tbSSinif8S += 5, tbStokFiyatiS += 5, tbStokResmiS += 5, tbStokS += 5, tbStokSinifiS += 5, tbStokUzunNotS += 5, sonGuncelleme = GETDATE()")
                If Trim(WebBaglanti) <> "" Then
                    System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False
                    Dim trd As Threading.Thread = New Threading.Thread(AddressOf Senkronizasyon)
                    trd.IsBackground = True
                    trd.Start()
                Else
                    MessageBox.Show("Web Baðlantý Bilgileri Bulunamadý.", "Business Smart")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Sýfýrdan Aktarým Ýþlemi Sýrasýnda Bir Sorun Oluþtu!", "Business Smart")
        End Try
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        If Trim(WebBaglanti) <> "" Then
            If XtraMessageBox.Show("Web Alým Ýþlemini Baþlatmak Ýstiyormusunuz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False
                Dim trd As Threading.Thread = New Threading.Thread(AddressOf Senkronizasyon)
                trd.IsBackground = True
                trd.Start()
            End If
        Else
            MessageBox.Show("Web Baðlantý Bilgileri Bulunamadý.", "Business Smart")
        End If
    End Sub
End Class