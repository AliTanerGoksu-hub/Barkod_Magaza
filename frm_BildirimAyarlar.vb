Imports System.Data.OleDb

''' <summary>
''' Bildirim Ayarlari Formu
''' WhatsApp (UltraMsg API), SMS, Email ayarlari ve bildirim tercihleri
''' 
''' UltraMsg Panel: https://user.ultramsg.com
''' API Dokumantasyonu: https://docs.ultramsg.com
''' </summary>
Public Class frm_BildirimAyarlar
    
    Private connection As String = KeyCode.sConnection
    
    ' =============================================
    ' FORM LOAD
    ' =============================================
    
    Private Sub frm_BildirimAyarlar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            WhatsAppAyarlariYukle()
            WhatsAppGruplariYukle()
            BildirimTipleriYukle()
            EmailAyarlariYukle()
            SMSAyarlariYukle()
            KullanicilariYukle()
            PersonelBildirimAyarlariYukle()
        Catch ex As Exception
            MessageBox.Show("Form yukleme hatasi: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    
    ' =============================================
    ' WHATSAPP AYARLARI (UltraMsg API)
    ' =============================================
    
    Private Sub WhatsAppAyarlariYukle()
        Try
            ' UltraMsg API ayarlari
            txt_UltraMsgInstanceID.Text = SistemAyarGetir("ULTRAMSG_INSTANCE_ID")
            txt_UltraMsgToken.Text = SistemAyarGetir("ULTRAMSG_TOKEN")
            chk_WhatsAppAktif.Checked = (SistemAyarGetir("WHATSAPP_AKTIF") = "1")
            
            ' API URL'ini otomatik goster
            If txt_UltraMsgInstanceID.Text <> "" Then
                lbl_ApiUrl.Text = "API URL: https://api.ultramsg.com/" & txt_UltraMsgInstanceID.Text & "/messages/chat"
            Else
                lbl_ApiUrl.Text = "API URL: (Instance ID girin)"
            End If
        Catch ex As Exception
            Debug.WriteLine("WhatsAppAyarlariYukle Hata: " & ex.Message)
        End Try
    End Sub
    
    Private Sub txt_UltraMsgInstanceID_EditValueChanged(sender As Object, e As EventArgs) Handles txt_UltraMsgInstanceID.EditValueChanged
        ' Instance ID degistiginde API URL'ini guncelle
        If txt_UltraMsgInstanceID.Text <> "" Then
            lbl_ApiUrl.Text = "API URL: https://api.ultramsg.com/" & txt_UltraMsgInstanceID.Text & "/messages/chat"
        Else
            lbl_ApiUrl.Text = "API URL: (Instance ID girin)"
        End If
    End Sub
    
    Private Sub btn_WhatsAppKaydet_Click(sender As Object, e As EventArgs) Handles btn_WhatsAppKaydet.Click
        Try
            ' UltraMsg API ayarlarini kaydet
            SistemAyarKaydet("ULTRAMSG_INSTANCE_ID", txt_UltraMsgInstanceID.Text.Trim())
            SistemAyarKaydet("ULTRAMSG_TOKEN", txt_UltraMsgToken.Text.Trim())
            SistemAyarKaydet("WHATSAPP_AKTIF", If(chk_WhatsAppAktif.Checked, "1", "0"))
            
            MessageBox.Show("UltraMsg WhatsApp ayarlari kaydedildi." & vbCrLf & vbCrLf & _
                           "Instance ID: " & txt_UltraMsgInstanceID.Text & vbCrLf & _
                           "Aktif: " & If(chk_WhatsAppAktif.Checked, "Evet", "Hayir"), _
                           "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Kaydetme hatasi: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    
    Private Sub btn_WhatsAppBaglantiTest_Click(sender As Object, e As EventArgs) Handles btn_WhatsAppBaglantiTest.Click
        Try
            Dim sInstanceID As String = txt_UltraMsgInstanceID.Text.Trim()
            Dim sToken As String = txt_UltraMsgToken.Text.Trim()
            
            If String.IsNullOrEmpty(sInstanceID) Then
                MessageBox.Show("Instance ID bos olamaz!" & vbCrLf & vbCrLf & _
                               "UltraMsg panelinden (user.ultramsg.com) Instance ID'nizi alin.", _
                               "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            
            If String.IsNullOrEmpty(sToken) Then
                MessageBox.Show("Token bos olamaz!" & vbCrLf & vbCrLf & _
                               "UltraMsg panelinden (user.ultramsg.com) Token'inizi alin.", _
                               "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            
            Me.Cursor = Cursors.WaitCursor
            
            ' UltraMsg baglanti durumunu kontrol et
            Dim sUrl As String = "https://api.ultramsg.com/" & sInstanceID & "/instance/status?token=" & sToken
            
            Dim request As System.Net.HttpWebRequest = CType(System.Net.WebRequest.Create(sUrl), System.Net.HttpWebRequest)
            request.Method = "GET"
            request.Timeout = 15000
            
            Dim sResponse As String = ""
            Try
                Using response As System.Net.HttpWebResponse = CType(request.GetResponse(), System.Net.HttpWebResponse)
                    Using reader As New System.IO.StreamReader(response.GetResponseStream())
                        sResponse = reader.ReadToEnd()
                    End Using
                End Using
                
                Debug.WriteLine("UltraMsg Baglanti Test - Response: " & sResponse)
                
                If sResponse.Contains("""status"":""connected""") OrElse sResponse.Contains("""accountStatus"":""authenticated""") Then
                    MessageBox.Show("BAGLANTI BASARILI!" & vbCrLf & vbCrLf & _
                                   "WhatsApp baglantisi aktif ve calisiyor." & vbCrLf & vbCrLf & _
                                   "Instance ID: " & sInstanceID, _
                                   "Baglanti Testi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("BAGLANTI KONTROLU" & vbCrLf & vbCrLf & _
                                   "API yanit verdi ama durum kontrol edilmeli." & vbCrLf & vbCrLf & _
                                   "API Yaniti: " & sResponse & vbCrLf & vbCrLf & _
                                   "UltraMsg panelinden WhatsApp baglantisini kontrol edin.", _
                                   "Baglanti Testi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
                
            Catch webEx As System.Net.WebException
                If webEx.Response IsNot Nothing Then
                    Using reader As New System.IO.StreamReader(webEx.Response.GetResponseStream())
                        sResponse = reader.ReadToEnd()
                    End Using
                End If
                MessageBox.Show("BAGLANTI HATASI!" & vbCrLf & vbCrLf & _
                               "Hata: " & webEx.Message & vbCrLf & vbCrLf & _
                               "API Yaniti: " & sResponse & vbCrLf & vbCrLf & _
                               "Instance ID ve Token bilgilerini kontrol edin.", _
                               "Baglanti Testi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            
            Me.Cursor = Cursors.Default
            
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MessageBox.Show("Baglanti test hatasi: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    
    Private Sub btn_WhatsAppTest_Click(sender As Object, e As EventArgs) Handles btn_WhatsAppTest.Click
        Try
            ' Ayarlari kontrol et
            Dim sInstanceID As String = txt_UltraMsgInstanceID.Text.Trim()
            Dim sToken As String = txt_UltraMsgToken.Text.Trim()
            
            If String.IsNullOrEmpty(sInstanceID) Then
                MessageBox.Show("Instance ID bos olamaz!", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            
            If String.IsNullOrEmpty(sToken) Then
                MessageBox.Show("Token bos olamaz!", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            
            Dim frm As New frm_TekAlanGiris()
            frm.FormBaslik = "WhatsApp Test Mesaji"
            frm.AlanBaslik = "Telefon Numarasi:"
            frm.Aciklama = "Test mesaji gonderilecek telefon numarasini girin (5xxxxxxxxx veya 905xxxxxxxxx)"
            
            If frm.ShowDialog() = DialogResult.OK Then
                Dim sTelefon As String = frm.GirilenDeger.Trim()
                
                ' Telefon numarasini formatla
                sTelefon = sTelefon.Replace(" ", "").Replace("-", "").Replace("(", "").Replace(")", "").Replace("+", "")
                If Not sTelefon.StartsWith("90") Then
                    If sTelefon.StartsWith("0") Then
                        sTelefon = "9" & sTelefon
                    Else
                        sTelefon = "90" & sTelefon
                    End If
                End If
                
                Me.Cursor = Cursors.WaitCursor
                
                ' UltraMsg API - Token URL'de GET parametresi olarak
                Dim sUrl As String = "https://api.ultramsg.com/" & sInstanceID & "/messages/chat?token=" & sToken
                Dim sMesaj As String = "Bu bir test mesajidir. - BARKOD YAZILIM" & vbCrLf & "Tarih: " & DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss")
                
                MessageBox.Show("API URL: " & sUrl & vbCrLf & vbCrLf & "Telefon: " & sTelefon, "Debug", MessageBoxButtons.OK)
                
                Dim request As System.Net.HttpWebRequest = CType(System.Net.WebRequest.Create(sUrl), System.Net.HttpWebRequest)
                request.Method = "POST"
                request.ContentType = "application/x-www-form-urlencoded"
                request.Timeout = 30000
                
                ' POST parametreleri
                Dim postData As String = "to=" & sTelefon & "&body=" & Uri.EscapeDataString(sMesaj)
                
                Debug.WriteLine("UltraMsg Test - URL: " & sUrl)
                Debug.WriteLine("UltraMsg Test - Telefon: +" & sTelefon)
                
                Dim byteArray As Byte() = System.Text.Encoding.UTF8.GetBytes(postData)
                
                Using dataStream As System.IO.Stream = request.GetRequestStream()
                    dataStream.Write(byteArray, 0, byteArray.Length)
                End Using
                
                Dim sResponse As String = ""
                Try
                    Using response As System.Net.HttpWebResponse = CType(request.GetResponse(), System.Net.HttpWebResponse)
                        Using reader As New System.IO.StreamReader(response.GetResponseStream())
                            sResponse = reader.ReadToEnd()
                        End Using
                    End Using
                    
                    Debug.WriteLine("UltraMsg Test - Response: " & sResponse)
                    
                    Me.Cursor = Cursors.Default
                    
                    If sResponse.Contains("""sent""") OrElse sResponse.Contains("""true""") OrElse sResponse.Contains("queued") Then
                        MessageBox.Show("TEST MESAJI GONDERILDI!" & vbCrLf & vbCrLf & _
                                       "Telefon: +" & sTelefon & vbCrLf & vbCrLf & _
                                       "Mesaj: " & sMesaj, _
                                       "Basarili", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("MESAJ GONDERIMI KONTROLU" & vbCrLf & vbCrLf & _
                                       "API yanit verdi:" & vbCrLf & sResponse & vbCrLf & vbCrLf & _
                                       "Telefon numarasini ve WhatsApp baglantisini kontrol edin.", _
                                       "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                    
                Catch webEx As System.Net.WebException
                    Me.Cursor = Cursors.Default
                    If webEx.Response IsNot Nothing Then
                        Using reader As New System.IO.StreamReader(webEx.Response.GetResponseStream())
                            sResponse = reader.ReadToEnd()
                        End Using
                    End If
                    Debug.WriteLine("UltraMsg Test - Hata Response: " & sResponse)
                    MessageBox.Show("MESAJ GONDERIM HATASI!" & vbCrLf & vbCrLf & _
                                   "Hata: " & webEx.Message & vbCrLf & vbCrLf & _
                                   "API Yaniti: " & sResponse, _
                                   "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MessageBox.Show("Test hatasi: " & ex.Message & vbCrLf & vbCrLf & "StackTrace: " & ex.StackTrace, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    
    Private Sub btn_UltraMsgPanelAc_Click(sender As Object, e As EventArgs) Handles btn_UltraMsgPanelAc.Click
        Try
            System.Diagnostics.Process.Start("https://user.ultramsg.com")
        Catch ex As Exception
            MessageBox.Show("Tarayici acilamadi: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    
    ' =============================================
    ' WHATSAPP GRUPLARI
    ' =============================================
    
    Private Sub WhatsAppGruplariYukle()
        Try
            Dim dt As DataTable = SQLCalistir("SELECT nGrupID, sGrupAdi, sAciklama, bAktif FROM tbWhatsappGruplari ORDER BY sGrupAdi")
            grd_WhatsAppGruplar.DataSource = dt
        Catch ex As Exception
            Debug.WriteLine("WhatsAppGruplariYukle Hata: " & ex.Message)
        End Try
    End Sub
    
    Private Sub btn_GrupEkle_Click(sender As Object, e As EventArgs) Handles btn_GrupEkle.Click
        Try
            Dim frm As New frm_TekAlanGiris()
            frm.FormBaslik = "Yeni WhatsApp Grubu"
            frm.AlanBaslik = "Grup Adi:"
            
            If frm.ShowDialog() = DialogResult.OK Then
                Dim sGrupAdi As String = frm.GirilenDeger.Trim()
                If sGrupAdi <> "" Then
                    SQLCalistirNonQuery("INSERT INTO tbWhatsappGruplari (sGrupAdi) VALUES ('" & sGrupAdi.Replace("'", "''") & "')")
                    WhatsAppGruplariYukle()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Grup ekleme hatasi: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    
    Private Sub btn_GrupSil_Click(sender As Object, e As EventArgs) Handles btn_GrupSil.Click
        Try
            Dim view As DevExpress.XtraGrid.Views.Grid.GridView = CType(grd_WhatsAppGruplar.MainView, DevExpress.XtraGrid.Views.Grid.GridView)
            If view.FocusedRowHandle >= 0 Then
                Dim nGrupID As Integer = Convert.ToInt32(view.GetFocusedRowCellValue("nGrupID"))
                If MessageBox.Show("Bu grubu silmek istediginizden emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    SQLCalistirNonQuery("DELETE FROM tbWhatsappGrupUyeleri WHERE nGrupID = " & nGrupID)
                    SQLCalistirNonQuery("DELETE FROM tbWhatsappGruplari WHERE nGrupID = " & nGrupID)
                    WhatsAppGruplariYukle()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Grup silme hatasi: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    
    Private Sub btn_UyeleriYonet_Click(sender As Object, e As EventArgs) Handles btn_UyeleriYonet.Click
        Try
            Dim view As DevExpress.XtraGrid.Views.Grid.GridView = CType(grd_WhatsAppGruplar.MainView, DevExpress.XtraGrid.Views.Grid.GridView)
            If view.FocusedRowHandle >= 0 Then
                Dim nGrupID As Integer = Convert.ToInt32(view.GetFocusedRowCellValue("nGrupID"))
                Dim sGrupAdi As String = view.GetFocusedRowCellValue("sGrupAdi").ToString()
                
                ' Grup uyeleri formunu ac
                Dim frm As New frm_WhatsAppGrupUyeleri()
                frm.GrupID = nGrupID
                frm.GrupAdi = sGrupAdi
                frm.ShowDialog()
            Else
                MessageBox.Show("Lutfen bir grup secin.", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show("Uye yonetim hatasi: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    
    ' =============================================
    ' BILDIRIM TIPLERI VE TERCIHLER
    ' =============================================
    
    Private Sub BildirimTipleriYukle()
        Try
            ' Kullanici secilmeden once bos grid goster
            ' Kullanici secilince KullaniciBildirimTercihleriniYukle cagirilacak
            grd_BildirimTipleri.DataSource = Nothing
        Catch ex As Exception
            Debug.WriteLine("BildirimTipleriYukle Hata: " & ex.Message)
        End Try
    End Sub
    
    Private Sub KullanicilariYukle()
        Try
            ' APERSONEL tablosundan aktif personelleri yukle
            Dim dt As DataTable = SQLCalistir("SELECT IND, PERSONELADI FROM APERSONEL WHERE AKTIF = 1 ORDER BY PERSONELADI")
            cmb_Kullanici.Properties.DataSource = dt
            cmb_Kullanici.Properties.DisplayMember = "PERSONELADI"
            cmb_Kullanici.Properties.ValueMember = "IND"
        Catch ex As Exception
            Debug.WriteLine("KullanicilariYukle Hata: " & ex.Message)
        End Try
    End Sub
    
    Private Sub cmb_Kullanici_EditValueChanged(sender As Object, e As EventArgs) Handles cmb_Kullanici.EditValueChanged
        Try
            If cmb_Kullanici.EditValue IsNot Nothing AndAlso cmb_Kullanici.EditValue IsNot DBNull.Value Then
                Dim nKullaniciID As Integer = Convert.ToInt32(cmb_Kullanici.EditValue)
                KullaniciBildirimTercihleriniYukle(nKullaniciID)
            End If
        Catch ex As Exception
            Debug.WriteLine("cmb_Kullanici_EditValueChanged Hata: " & ex.Message)
        End Try
    End Sub
    
    Private Sub KullaniciBildirimTercihleriniYukle(nKullaniciID As Integer)
        Try
            ' Kullanici icin bildirim tercihlerini yukle
            ' Tercih yoksa varsayilan degerler (bVarsayilan...) kullanilir
            Dim sql As String = "SELECT bt.nTipID, bt.sTipKodu, bt.sTipAdi, bt.sKategori, " & _
                               "CAST(ISNULL(kt.bEmailAktif, bt.bVarsayilanEmail) AS BIT) AS bEmailAktif, " & _
                               "CAST(ISNULL(kt.bSMSAktif, bt.bVarsayilanSMS) AS BIT) AS bSMSAktif, " & _
                               "CAST(ISNULL(kt.bWhatsAppAktif, bt.bVarsayilanWhatsApp) AS BIT) AS bWhatsAppAktif, " & _
                               "CAST(ISNULL(kt.bUygulamaAktif, bt.bVarsayilanUygulama) AS BIT) AS bUygulamaAktif " & _
                               "FROM tbBildirimTipleri bt " & _
                               "LEFT JOIN tbKullaniciBildirimTercihleri kt ON bt.nTipID = kt.nTipID AND kt.nKullaniciID = " & nKullaniciID & " " & _
                               "WHERE bt.bAktif = 1 " & _
                               "ORDER BY bt.sKategori, bt.sTipAdi"
            
            Dim dt As DataTable = SQLCalistir(sql)
            grd_BildirimTipleri.DataSource = dt
            
            ' Grid gorunumunu ayarla
            Dim view As DevExpress.XtraGrid.Views.Grid.GridView = CType(grd_BildirimTipleri.MainView, DevExpress.XtraGrid.Views.Grid.GridView)
            view.OptionsBehavior.Editable = True
            
            ' Checkbox kolonlarini duzenlenebilir yap
            If view.Columns("bEmailAktif") IsNot Nothing Then
                view.Columns("bEmailAktif").Caption = "Email"
                view.Columns("bEmailAktif").Width = 60
            End If
            If view.Columns("bSMSAktif") IsNot Nothing Then
                view.Columns("bSMSAktif").Caption = "SMS"
                view.Columns("bSMSAktif").Width = 60
            End If
            If view.Columns("bWhatsAppAktif") IsNot Nothing Then
                view.Columns("bWhatsAppAktif").Caption = "WhatsApp"
                view.Columns("bWhatsAppAktif").Width = 70
            End If
            If view.Columns("bUygulamaAktif") IsNot Nothing Then
                view.Columns("bUygulamaAktif").Caption = "Uygulama"
                view.Columns("bUygulamaAktif").Width = 70
            End If
            
            ' ID kolonunu gizle
            If view.Columns("nTipID") IsNot Nothing Then
                view.Columns("nTipID").Visible = False
            End If
            
            ' Kolon basliklarini ayarla
            If view.Columns("sTipKodu") IsNot Nothing Then
                view.Columns("sTipKodu").Caption = "Tip Kodu"
            End If
            If view.Columns("sTipAdi") IsNot Nothing Then
                view.Columns("sTipAdi").Caption = "Bildirim Tipi"
            End If
            If view.Columns("sKategori") IsNot Nothing Then
                view.Columns("sKategori").Caption = "Kategori"
            End If
            
        Catch ex As Exception
            Debug.WriteLine("KullaniciBildirimTercihleriniYukle Hata: " & ex.Message)
            MessageBox.Show("Bildirim tercihleri yuklenemedi: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    
    Private Sub btn_TercihKaydet_Click(sender As Object, e As EventArgs) Handles btn_TercihKaydet.Click
        Try
            If cmb_Kullanici.EditValue Is Nothing OrElse cmb_Kullanici.EditValue Is DBNull.Value Then
                MessageBox.Show("Lutfen bir kullanici secin.", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            
            Dim nKullaniciID As Integer = Convert.ToInt32(cmb_Kullanici.EditValue)
            Dim view As DevExpress.XtraGrid.Views.Grid.GridView = CType(grd_BildirimTipleri.MainView, DevExpress.XtraGrid.Views.Grid.GridView)
            
            For i As Integer = 0 To view.RowCount - 1
                Dim nTipID As Integer = Convert.ToInt32(view.GetRowCellValue(i, "nTipID"))
                Dim bEmailAktif As Boolean = False
                Dim bSMSAktif As Boolean = False
                Dim bWhatsAppAktif As Boolean = False
                Dim bUygulamaAktif As Boolean = True
                
                ' Null kontrolu ile deger al
                If view.GetRowCellValue(i, "bEmailAktif") IsNot Nothing AndAlso view.GetRowCellValue(i, "bEmailAktif") IsNot DBNull.Value Then
                    bEmailAktif = Convert.ToBoolean(view.GetRowCellValue(i, "bEmailAktif"))
                End If
                If view.GetRowCellValue(i, "bSMSAktif") IsNot Nothing AndAlso view.GetRowCellValue(i, "bSMSAktif") IsNot DBNull.Value Then
                    bSMSAktif = Convert.ToBoolean(view.GetRowCellValue(i, "bSMSAktif"))
                End If
                If view.GetRowCellValue(i, "bWhatsAppAktif") IsNot Nothing AndAlso view.GetRowCellValue(i, "bWhatsAppAktif") IsNot DBNull.Value Then
                    bWhatsAppAktif = Convert.ToBoolean(view.GetRowCellValue(i, "bWhatsAppAktif"))
                End If
                If view.GetRowCellValue(i, "bUygulamaAktif") IsNot Nothing AndAlso view.GetRowCellValue(i, "bUygulamaAktif") IsNot DBNull.Value Then
                    bUygulamaAktif = Convert.ToBoolean(view.GetRowCellValue(i, "bUygulamaAktif"))
                End If
                
                ' Onceki tercihi sil
                SQLCalistirNonQuery("DELETE FROM tbKullaniciBildirimTercihleri WHERE nKullaniciID = " & nKullaniciID & " AND nTipID = " & nTipID)
                
                ' Yeni tercihi ekle
                SQLCalistirNonQuery("INSERT INTO tbKullaniciBildirimTercihleri (nKullaniciID, nTipID, bEmailAktif, bSMSAktif, bWhatsAppAktif, bUygulamaAktif) VALUES (" & _
                                   nKullaniciID & ", " & nTipID & ", " & If(bEmailAktif, 1, 0) & ", " & If(bSMSAktif, 1, 0) & ", " & If(bWhatsAppAktif, 1, 0) & ", " & If(bUygulamaAktif, 1, 0) & ")")
            Next
            
            MessageBox.Show("Bildirim tercihleri kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Tercih kaydetme hatasi: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    
    ' =============================================
    ' PERSONEL BILDIRIM AYARLARI
    ' =============================================
    
    Private Sub PersonelBildirimAyarlariYukle()
        Try
            ' APERSONEL tablosundan personel listesini ve bildirim ayarlarini yukle
            Dim sql As String = "SELECT IND AS nPersonelID, PERSONELADI AS sPersonelAdi, " & _
                               "ISNULL(TELEFON1, '') AS sTelefon, " & _
                               "ISNULL(sWhatsApp, '') AS sWhatsApp, " & _
                               "ISNULL(bEmailBildirimAl, 0) AS bEmailBildirimAl, " & _
                               "ISNULL(bSMSBildirimAl, 0) AS bSMSBildirimAl, " & _
                               "ISNULL(bWhatsAppBildirimAl, 0) AS bWhatsAppBildirimAl, " & _
                               "ISNULL(bUygulamaBildirimAl, 1) AS bUygulamaBildirimAl " & _
                               "FROM APERSONEL " & _
                               "WHERE AKTIF = 1 " & _
                               "ORDER BY PERSONELADI"
            
            Dim dt As DataTable = SQLCalistir(sql)
            grd_PersonelBildirim.DataSource = dt
        Catch ex As Exception
            Debug.WriteLine("PersonelBildirimAyarlariYukle Hata: " & ex.Message)
        End Try
    End Sub
    
    Private Sub btn_PersonelKaydet_Click(sender As Object, e As EventArgs) Handles btn_PersonelKaydet.Click
        Try
            Dim view As DevExpress.XtraGrid.Views.Grid.GridView = CType(grd_PersonelBildirim.MainView, DevExpress.XtraGrid.Views.Grid.GridView)
            
            For i As Integer = 0 To view.RowCount - 1
                Dim nPersonelID As Integer = Convert.ToInt32(view.GetRowCellValue(i, "nPersonelID"))
                Dim bEmailBildirimAl As Integer = If(Convert.ToBoolean(view.GetRowCellValue(i, "bEmailBildirimAl")), 1, 0)
                Dim bSMSBildirimAl As Integer = If(Convert.ToBoolean(view.GetRowCellValue(i, "bSMSBildirimAl")), 1, 0)
                Dim bWhatsAppBildirimAl As Integer = If(Convert.ToBoolean(view.GetRowCellValue(i, "bWhatsAppBildirimAl")), 1, 0)
                Dim bUygulamaBildirimAl As Integer = If(Convert.ToBoolean(view.GetRowCellValue(i, "bUygulamaBildirimAl")), 1, 0)
                
                ' APERSONEL tablosunu guncelle
                SQLCalistirNonQuery("UPDATE APERSONEL SET " & _
                                   "bEmailBildirimAl = " & bEmailBildirimAl & ", " & _
                                   "bSMSBildirimAl = " & bSMSBildirimAl & ", " & _
                                   "bWhatsAppBildirimAl = " & bWhatsAppBildirimAl & ", " & _
                                   "bUygulamaBildirimAl = " & bUygulamaBildirimAl & " " & _
                                   "WHERE IND = " & nPersonelID)
            Next
            
            MessageBox.Show("Personel bildirim ayarlari kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Personel ayar kaydetme hatasi: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    
    ' =============================================
    ' EMAIL AYARLARI
    ' =============================================
    
    Private Sub EmailAyarlariYukle()
        Try
            txt_EmailHost.Text = SistemAyarGetir("EMAIL_HOST")
            txt_EmailPort.Text = SistemAyarGetir("EMAIL_PORT")
            txt_EmailUser.Text = SistemAyarGetir("EMAIL_USER")
            txt_EmailPass.Text = SistemAyarGetir("EMAIL_PASS")
            txt_EmailFrom.Text = SistemAyarGetir("EMAIL_FROM")
            chk_EmailAktif.Checked = (SistemAyarGetir("EMAIL_AKTIF") = "1")
        Catch ex As Exception
            Debug.WriteLine("EmailAyarlariYukle Hata: " & ex.Message)
        End Try
    End Sub
    
    Private Sub btn_EmailKaydet_Click(sender As Object, e As EventArgs) Handles btn_EmailKaydet.Click
        Try
            SistemAyarKaydet("EMAIL_HOST", txt_EmailHost.Text)
            SistemAyarKaydet("EMAIL_PORT", txt_EmailPort.Text)
            SistemAyarKaydet("EMAIL_USER", txt_EmailUser.Text)
            SistemAyarKaydet("EMAIL_PASS", txt_EmailPass.Text)
            SistemAyarKaydet("EMAIL_FROM", txt_EmailFrom.Text)
            SistemAyarKaydet("EMAIL_AKTIF", If(chk_EmailAktif.Checked, "1", "0"))
            
            MessageBox.Show("Email ayarlari kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Email ayar kaydetme hatasi: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    
    ' =============================================
    ' SMS AYARLARI
    ' =============================================
    
    Private Sub SMSAyarlariYukle()
        Try
            txt_SMSApiUrl.Text = SistemAyarGetir("SMS_API_URL")
            txt_SMSApiKey.Text = SistemAyarGetir("SMS_API_KEY")
            txt_SMSSender.Text = SistemAyarGetir("SMS_SENDER")
            chk_SMSAktif.Checked = (SistemAyarGetir("SMS_AKTIF") = "1")
        Catch ex As Exception
            Debug.WriteLine("SMSAyarlariYukle Hata: " & ex.Message)
        End Try
    End Sub
    
    Private Sub btn_SMSKaydet_Click(sender As Object, e As EventArgs) Handles btn_SMSKaydet.Click
        Try
            SistemAyarKaydet("SMS_API_URL", txt_SMSApiUrl.Text)
            SistemAyarKaydet("SMS_API_KEY", txt_SMSApiKey.Text)
            SistemAyarKaydet("SMS_SENDER", txt_SMSSender.Text)
            SistemAyarKaydet("SMS_AKTIF", If(chk_SMSAktif.Checked, "1", "0"))
            
            MessageBox.Show("SMS ayarlari kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("SMS ayar kaydetme hatasi: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    
    ' =============================================
    ' YARDIMCI FONKSIYONLAR
    ' =============================================
    
    Private Function SistemAyarGetir(sAyarKodu As String) As String
        Try
            Dim dt As DataTable = SQLCalistir("SELECT sAyarDeger FROM tbSistemAyar WHERE sAyarKodu = '" & sAyarKodu & "'")
            If dt.Rows.Count > 0 Then
                Return dt.Rows(0)("sAyarDeger").ToString()
            End If
        Catch ex As Exception
            Debug.WriteLine("SistemAyarGetir Hata: " & ex.Message)
        End Try
        Return ""
    End Function
    
    Private Sub SistemAyarKaydet(sAyarKodu As String, sAyarDeger As String)
        Try
            ' Kayit var mi kontrol et
            Dim dt As DataTable = SQLCalistir("SELECT COUNT(*) AS CNT FROM tbSistemAyar WHERE sAyarKodu = '" & sAyarKodu & "'")
            If dt.Rows.Count > 0 AndAlso Convert.ToInt32(dt.Rows(0)("CNT")) > 0 Then
                SQLCalistirNonQuery("UPDATE tbSistemAyar SET sAyarDeger = '" & sAyarDeger.Replace("'", "''") & "' WHERE sAyarKodu = '" & sAyarKodu & "'")
            Else
                SQLCalistirNonQuery("INSERT INTO tbSistemAyar (sAyarKodu, sAyarDeger, sAciklama, bAktif) VALUES ('" & sAyarKodu & "', '" & sAyarDeger.Replace("'", "''") & "', 'Otomatik eklendi', 1)")
            End If
        Catch ex As Exception
            Debug.WriteLine("SistemAyarKaydet Hata: " & ex.Message)
            MessageBox.Show("Ayar kaydetme hatasi: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    
    Private Function SQLCalistir(ByVal sql As String) As DataTable
        Dim dt As New DataTable()
        Try
            Using con As New OleDbConnection(connection)
                Using cmd As New OleDbCommand(KeyCode.sorgu_query(sql), con)
                    Using da As New OleDbDataAdapter(cmd)
                        con.Open()
                        da.Fill(dt)
                    End Using
                End Using
            End Using
        Catch ex As Exception
            Debug.WriteLine("SQLCalistir Hata: " & ex.Message)
        End Try
        Return dt
    End Function
    
    Private Sub SQLCalistirNonQuery(ByVal sql As String)
        Try
            Using con As New OleDbConnection(connection)
                Using cmd As New OleDbCommand(KeyCode.sorgu_query(sql), con)
                    con.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            Debug.WriteLine("SQLCalistirNonQuery Hata: " & ex.Message)
        End Try
    End Sub
    
    ' =============================================
    ' UI KONTROLLERI
    ' =============================================
    
    ' Grids
    Friend WithEvents grd_WhatsAppGruplar As DevExpress.XtraGrid.GridControl
    Friend WithEvents grd_BildirimTipleri As DevExpress.XtraGrid.GridControl
    Friend WithEvents grd_PersonelBildirim As DevExpress.XtraGrid.GridControl
    
    ' UI Kontrolleri - WhatsApp (UltraMsg API)
    Friend WithEvents txt_UltraMsgInstanceID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_UltraMsgToken As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lbl_ApiUrl As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chk_WhatsAppAktif As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents btn_WhatsAppKaydet As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_WhatsAppTest As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_WhatsAppBaglantiTest As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_UltraMsgPanelAc As DevExpress.XtraEditors.SimpleButton
    
    ' UI Kontrolleri - Grup
    Friend WithEvents btn_GrupEkle As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_GrupSil As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_UyeleriYonet As DevExpress.XtraEditors.SimpleButton
    
    ' UI Kontrolleri - Bildirim Tercihleri
    Friend WithEvents cmb_Kullanici As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents btn_TercihKaydet As DevExpress.XtraEditors.SimpleButton
    
    ' UI Kontrolleri - Personel
    Friend WithEvents btn_PersonelKaydet As DevExpress.XtraEditors.SimpleButton
    
    ' UI Kontrolleri - Email
    Friend WithEvents txt_EmailHost As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_EmailPort As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_EmailUser As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_EmailPass As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_EmailFrom As DevExpress.XtraEditors.TextEdit
    Friend WithEvents chk_EmailAktif As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents btn_EmailKaydet As DevExpress.XtraEditors.SimpleButton
    
    ' UI Kontrolleri - SMS
    Friend WithEvents txt_SMSApiUrl As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_SMSApiKey As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_SMSSender As DevExpress.XtraEditors.TextEdit
    Friend WithEvents chk_SMSAktif As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents btn_SMSKaydet As DevExpress.XtraEditors.SimpleButton
    
End Class
