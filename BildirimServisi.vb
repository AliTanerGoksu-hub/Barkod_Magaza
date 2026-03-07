Imports System.Net
Imports System.Net.Mail
Imports System.IO
Imports System.Text
Imports System.Data.OleDb

''' <summary>
''' Merkezi Bildirim Servisi - Tum uygulama genelinde kullanilabilir
''' Desteklenen Kanallar: E-posta (SMTP), SMS (NetGSM API), WhatsApp (UltraMsg API), Uygulama Ici
''' 
''' ULTRAMSG WHATSAPP AYARLARI:
''' ===========================
''' Sistem Ayarlari Tablosuna (tbSistemAyar) asagidaki kayitlari ekleyin:
''' 
''' sAyarKodu                   | sAyarDeger
''' ----------------------------|----------------------------------
''' WHATSAPP_AKTIF              | 1
''' ULTRAMSG_INSTANCE_ID        | instance157897
''' ULTRAMSG_TOKEN              | 4s5wk3zkxn17ws9
''' 
''' UltraMsg Panel: https://user.ultramsg.com
''' API Dokumantasyonu: https://docs.ultramsg.com
''' </summary>
Public Module BildirimServisi
    
    Private connection As String = KeyCode.sConnection
    
    ' =============================================
    ' ANA BILDIRIM FONKSIYONLARI
    ' =============================================
    
    ''' <summary>
    ''' Tek kullaniciya bildirim gonderir
    ''' Ornek: BildirimServisi.Gonder("SIPARIS_YENI", "Siparis #123 olusturuldu", nKullaniciID)
    ''' </summary>
    Public Sub Gonder(ByVal sTipKodu As String, ByVal sMesaj As String, ByVal nAliciID As Integer, Optional ByVal sBaslik As String = "")
        Try
            ' Kullanici bilgilerini al - APERSONEL tablosundaki gercek kolon adlarini kullan
            Dim dtKullanici As DataTable = SQLCalistir("SELECT ISNULL(TELEFON1,'') AS Telefon, ISNULL(bEmailBildirimAl,1) AS bEmailBildirimAl, ISNULL(bSMSBildirimAl,0) AS bSMSBildirimAl, ISNULL(bWhatsAppBildirimAl,0) AS bWhatsAppBildirimAl, ISNULL(bUygulamaBildirimAl,1) AS bUygulamaBildirimAl FROM APERSONEL WHERE IND = " & nAliciID)
            
            If dtKullanici.Rows.Count = 0 Then Exit Sub
            
            Dim dr As DataRow = dtKullanici.Rows(0)
            Dim sEmail As String = "" ' Email kolonu mevcut degil
            Dim sTelefon As String = If(dr("Telefon") IsNot DBNull.Value, dr("Telefon").ToString(), "")
            Dim sWhatsApp As String = sTelefon ' WhatsApp icin de telefon kullan
            
            ' Kullanici tercihlerini kontrol et
            Dim bEmailAktif As Boolean = If(dr("bEmailBildirimAl") IsNot DBNull.Value, Convert.ToBoolean(dr("bEmailBildirimAl")), True)
            Dim bSMSAktif As Boolean = If(dr("bSMSBildirimAl") IsNot DBNull.Value, Convert.ToBoolean(dr("bSMSBildirimAl")), True)
            Dim bWhatsAppAktif As Boolean = If(dr("bWhatsAppBildirimAl") IsNot DBNull.Value, Convert.ToBoolean(dr("bWhatsAppBildirimAl")), True)
            Dim bUygulamaAktif As Boolean = If(dr("bUygulamaBildirimAl") IsNot DBNull.Value, Convert.ToBoolean(dr("bUygulamaBildirimAl")), True)
            
            ' Bildirim tipi ayarlarini al
            Dim dtTip As DataTable = SQLCalistir("SELECT nTipID, bVarsayilanEmail, bVarsayilanSMS, bVarsayilanWhatsApp, bVarsayilanUygulama FROM tbBildirimTipleri WHERE sTipKodu = '" & sTipKodu & "' AND bAktif = 1")
            
            Dim bTipEmail As Boolean = True
            Dim bTipSMS As Boolean = False
            Dim bTipWhatsApp As Boolean = True
            Dim bTipUygulama As Boolean = True
            Dim nTipID As Integer = 0
            
            If dtTip.Rows.Count > 0 Then
                nTipID = Convert.ToInt32(dtTip.Rows(0)("nTipID"))
                bTipEmail = Convert.ToBoolean(dtTip.Rows(0)("bVarsayilanEmail"))
                bTipSMS = Convert.ToBoolean(dtTip.Rows(0)("bVarsayilanSMS"))
                bTipWhatsApp = Convert.ToBoolean(dtTip.Rows(0)("bVarsayilanWhatsApp"))
                bTipUygulama = Convert.ToBoolean(dtTip.Rows(0)("bVarsayilanUygulama"))
                
                ' Kullanici ozel tercihlerini kontrol et
                Dim dtTercih As DataTable = SQLCalistir("SELECT bEmailAktif, bSMSAktif, bWhatsAppAktif, bUygulamaAktif FROM tbKullaniciBildirimTercihleri WHERE nKullaniciID = " & nAliciID & " AND nTipID = " & nTipID)
                If dtTercih.Rows.Count > 0 Then
                    bTipEmail = Convert.ToBoolean(dtTercih.Rows(0)("bEmailAktif"))
                    bTipSMS = Convert.ToBoolean(dtTercih.Rows(0)("bSMSAktif"))
                    bTipWhatsApp = Convert.ToBoolean(dtTercih.Rows(0)("bWhatsAppAktif"))
                    bTipUygulama = Convert.ToBoolean(dtTercih.Rows(0)("bUygulamaAktif"))
                End If
            End If
            
            If sBaslik = "" Then sBaslik = sTipKodu.Replace("_", " ")
            
            ' Email gonder
            If bEmailAktif AndAlso bTipEmail AndAlso sEmail <> "" Then
                EmailGonder(sEmail, sBaslik, sMesaj, nTipID, nAliciID)
            End If
            
            ' SMS gonder
            If bSMSAktif AndAlso bTipSMS AndAlso sTelefon <> "" Then
                SMSGonder(sTelefon, sMesaj, nTipID, nAliciID)
            End If
            
            ' WhatsApp gonder
            If bWhatsAppAktif AndAlso bTipWhatsApp AndAlso sWhatsApp <> "" Then
                WhatsAppGonder(sWhatsApp, sMesaj, nTipID, nAliciID)
            End If
            
            ' Uygulama ici bildirim
            If bUygulamaAktif AndAlso bTipUygulama Then
                UygulamaIciBildirimKaydet(nAliciID, sBaslik, sMesaj, nTipID)
            End If
            
        Catch ex As Exception
            Debug.WriteLine("BildirimServisi.Gonder Hata: " & ex.Message)
        End Try
    End Sub
    
    ''' <summary>
    ''' WhatsApp grubuna mesaj gonderir
    ''' Ornek: BildirimServisi.GrubaGonder("Uretim Ekibi", "Toplanti var!")
    ''' </summary>
    Public Sub GrubaGonder(ByVal sGrupAdi As String, ByVal sMesaj As String, Optional ByVal sBaslik As String = "Grup Bildirimi")
        Try
            ' Grup uyelerini al - APERSONEL tablosundaki gercek kolon adlarini kullan
            Dim dtUyeler As DataTable = SQLCalistir("SELECT p.IND AS nKullaniciID, ISNULL(p.TELEFON1,'') AS Telefon FROM tbWhatsappGrupUyeleri u INNER JOIN tbWhatsappGruplari g ON u.nGrupID = g.nGrupID INNER JOIN APERSONEL p ON u.nPersonelID = p.IND WHERE g.sGrupAdi = '" & sGrupAdi.Replace("'", "''") & "' AND g.bAktif = 1 AND u.bAktif = 1 AND p.AKTIF = 1")
            
            For Each dr As DataRow In dtUyeler.Rows
                Dim nKullaniciID As Integer = Convert.ToInt32(dr("nKullaniciID"))
                Dim sWhatsApp As String = If(dr("Telefon") IsNot DBNull.Value, dr("Telefon").ToString(), "")
                
                If sWhatsApp <> "" Then
                    WhatsAppGonder(sWhatsApp, sMesaj, 0, nKullaniciID)
                End If
                
                ' Uygulama ici bildirim de gonder
                UygulamaIciBildirimKaydet(nKullaniciID, sBaslik, sMesaj, 0)
            Next
            
        Catch ex As Exception
            Debug.WriteLine("BildirimServisi.GrubaGonder Hata: " & ex.Message)
        End Try
    End Sub
    
    ''' <summary>
    ''' Tum yoneticilere bildirim gonderir
    ''' Ornek: BildirimServisi.YoneticilereGonder("Kritik: Stok tukendi!")
    ''' </summary>
    Public Sub YoneticilereGonder(ByVal sMesaj As String, Optional ByVal sBaslik As String = "Yonetici Bildirimi")
        Try
            ' Yoneticileri al
            Dim dtYoneticiler As DataTable = SQLCalistir("SELECT IND AS nKullaniciID FROM APERSONEL WHERE ISNULL(bYonetici,0) = 1 AND AKTIF = 1")
            
            For Each dr As DataRow In dtYoneticiler.Rows
                Dim nKullaniciID As Integer = Convert.ToInt32(dr("nKullaniciID"))
                Gonder("SISTEM_UYARI", sMesaj, nKullaniciID, sBaslik)
            Next
            
        Catch ex As Exception
            Debug.WriteLine("BildirimServisi.YoneticilereGonder Hata: " & ex.Message)
        End Try
    End Sub
    
    ''' <summary>
    ''' Tum ilgili kullanicilara broadcast bildirim gonderir (WhatsApp dahil)
    ''' Ornek: BildirimServisi.Broadcast("STOK_KRITIK", "Hammadde X bitti")
    ''' </summary>
    Public Sub Broadcast(ByVal sTipKodu As String, ByVal sMesaj As String, Optional ByVal sBaslik As String = "")
        Try
            ' Bu bildirim tipini almak isteyen tum kullanicilari bul
            Dim dtKullanicilar As DataTable = SQLCalistir( _
                "SELECT DISTINCT p.IND AS nKullaniciID, p.PERSONELADI, ISNULL(p.TELEFON1,'') AS Telefon, " & _
                "ISNULL(t.bWhatsAppAktif, 0) AS bWhatsApp, ISNULL(t.bEmailAktif, 0) AS bEmail " & _
                "FROM APERSONEL p " & _
                "LEFT JOIN tbKullaniciBildirimTercihleri t ON p.IND = t.nKullaniciID " & _
                "LEFT JOIN tbBildirimTipleri bt ON t.nTipID = bt.nTipID " & _
                "WHERE p.AKTIF = 1 AND (bt.sTipKodu = '" & sTipKodu & "' OR bt.sTipKodu IS NULL)")
            
            For Each dr As DataRow In dtKullanicilar.Rows
                Dim nKullaniciID As Integer = Convert.ToInt32(dr("nKullaniciID"))
                Dim sTelefon As String = dr("Telefon").ToString().Trim()
                Dim bWhatsApp As Boolean = Convert.ToBoolean(dr("bWhatsApp"))
                
                ' Uygulama ici bildirim
                Gonder(sTipKodu, sMesaj, nKullaniciID, sBaslik)
                
                ' WhatsApp bildirimi
                If bWhatsApp AndAlso Not String.IsNullOrEmpty(sTelefon) Then
                    WhatsAppGonder(sTelefon, If(String.IsNullOrEmpty(sBaslik), sMesaj, sBaslik & vbCrLf & vbCrLf & sMesaj), 0, nKullaniciID)
                End If
            Next
            
        Catch ex As Exception
            Debug.WriteLine("BildirimServisi.Broadcast Hata: " & ex.Message)
        End Try
    End Sub
    
    ''' <summary>
    ''' Belirli bir bildirim tipine gore WhatsApp bildirimi gonderir
    ''' </summary>
    Public Sub WhatsAppBildirimGonder(ByVal sTipKodu As String, ByVal sMesaj As String, Optional ByVal sBaslik As String = "")
        Try
            ' Bu bildirim tipi icin WhatsApp aktif olan kullanicilari bul
            Dim dtKullanicilar As DataTable = SQLCalistir( _
                "SELECT DISTINCT p.IND, p.PERSONELADI, ISNULL(p.TELEFON1,'') AS Telefon " & _
                "FROM APERSONEL p " & _
                "INNER JOIN tbKullaniciBildirimTercihleri t ON p.IND = t.nKullaniciID " & _
                "INNER JOIN tbBildirimTipleri bt ON t.nTipID = bt.nTipID " & _
                "WHERE p.AKTIF = 1 AND bt.sTipKodu = '" & sTipKodu & "' " & _
                "AND t.bWhatsAppAktif = 1 AND ISNULL(p.TELEFON1, '') <> ''")
            
            If dtKullanicilar Is Nothing OrElse dtKullanicilar.Rows.Count = 0 Then
                ' Tercihler tablosunda kayit yoksa, varsayilan olarak WhatsApp bildirimi alanlara gonder
                dtKullanicilar = SQLCalistir( _
                    "SELECT IND, PERSONELADI, ISNULL(TELEFON1,'') AS Telefon " & _
                    "FROM APERSONEL WHERE AKTIF = 1 AND ISNULL(bWhatsAppBildirimAl, 0) = 1 AND ISNULL(TELEFON1, '') <> ''")
            End If
            
            If dtKullanicilar Is Nothing OrElse dtKullanicilar.Rows.Count = 0 Then Exit Sub
            
            Dim tamMesaj As String = If(String.IsNullOrEmpty(sBaslik), sMesaj, sBaslik & vbCrLf & vbCrLf & sMesaj)
            
            For Each dr As DataRow In dtKullanicilar.Rows
                Try
                    Dim sTelefon As String = dr("Telefon").ToString().Trim()
                    If Not String.IsNullOrEmpty(sTelefon) Then
                        WhatsAppGonder(sTelefon, tamMesaj, 0, Convert.ToInt32(dr("IND")))
                    End If
                Catch
                End Try
            Next
        Catch ex As Exception
            Debug.WriteLine("WhatsAppBildirimGonder Hata: " & ex.Message)
        End Try
    End Sub
    
    ''' <summary>
    ''' Hizli WhatsApp bildirimi (telefon numarasina direkt)
    ''' Ornek: BildirimServisi.HizliBildirim("5551234567", "Acil mesaj")
    ''' </summary>
    Public Sub HizliBildirim(ByVal sTelefon As String, ByVal sMesaj As String)
        Try
            WhatsAppGonder(sTelefon, sMesaj, 0, 0)
        Catch ex As Exception
            Debug.WriteLine("BildirimServisi.HizliBildirim Hata: " & ex.Message)
        End Try
    End Sub
    
    ''' <summary>
    ''' Anlik mesaj gonderir (sadece uygulama ici)
    ''' </summary>
    Public Sub AnlikMesajGonder(ByVal nAliciID As Integer, ByVal sMesaj As String, Optional ByVal sBaslik As String = "Mesaj")
        Try
            UygulamaIciBildirimKaydet(nAliciID, sBaslik, sMesaj, 0)
        Catch ex As Exception
            Debug.WriteLine("BildirimServisi.AnlikMesajGonder Hata: " & ex.Message)
        End Try
    End Sub
    
    ' =============================================
    ' GOREV BILDIRIMLERI
    ' =============================================
    
    ''' <summary>
    ''' Gorev atandiginda bildirim gonderir
    ''' </summary>
    Public Sub GorevBildirimiGonder(ByVal nGorevID As Integer, ByVal nPersonelID As Integer, ByVal sBaslik As String, ByVal sAciklama As String, ByVal bAcil As Boolean)
        Try
            Dim sTipKodu As String = If(bAcil, "GOREV_ACIL", "GOREV_ATANDI")
            Dim sEmoji As String = If(bAcil, "🚨", "📋")
            Dim sMesaj As String = sEmoji & " *" & If(bAcil, "ACİL GÖREV", "YENİ GÖREV") & "*" & vbCrLf & _
                "================================" & vbCrLf & _
                "📌 *Görev:* " & sBaslik & vbCrLf & _
                "📝 *Açıklama:* " & sAciklama & vbCrLf & _
                "📅 *Tarih:* " & DateTime.Now.ToString("dd.MM.yyyy HH:mm") & vbCrLf & _
                "================================"
            
            ' Uygulama ici bildirim
            Gonder(sTipKodu, sMesaj, nPersonelID, "Yeni Gorev")
            
            ' WhatsApp bildirimi - bu personele
            WhatsAppBildirimPersonel(nPersonelID, sTipKodu, sMesaj)
            
            ' Gorev tablosunu guncelle
            SQLCalistirNonQuery("UPDATE aEmirAjanda SET BildirimGonderildi = 1, BildirimTarihi = GETDATE() WHERE nID = " & nGorevID)
            
        Catch ex As Exception
            Debug.WriteLine("BildirimServisi.GorevBildirimiGonder Hata: " & ex.Message)
        End Try
    End Sub
    
    ''' <summary>
    ''' Gorev hatirlatma bildirimi gonderir
    ''' </summary>
    Public Sub GorevHatirlatmaBildirimiGonder(ByVal nGorevID As Integer, ByVal nPersonelID As Integer, ByVal sBaslik As String, ByVal dteBitis As DateTime)
        Try
            Dim sMesaj As String = "⏰ *GÖREV HATIRLATMA*" & vbCrLf & _
                "================================" & vbCrLf & _
                "📌 *Görev:* " & sBaslik & vbCrLf & _
                "📅 *Bitiş Tarihi:* " & dteBitis.ToString("dd.MM.yyyy HH:mm") & vbCrLf & _
                "================================"
            
            Gonder("GOREV_HATIRLATMA", sMesaj, nPersonelID, "Gorev Hatirlatmasi")
            WhatsAppBildirimPersonel(nPersonelID, "GOREV_HATIRLATMA", sMesaj)
        Catch ex As Exception
            Debug.WriteLine("BildirimServisi.GorevHatirlatmaBildirimiGonder Hata: " & ex.Message)
        End Try
    End Sub
    
    ''' <summary>
    ''' Gorev tamamlandi bildirimi gonderir (gorev verene)
    ''' </summary>
    Public Sub GorevTamamlandiBildirimiGonder(ByVal nGorevID As Integer, ByVal nGorevVerenID As Integer, ByVal sBaslik As String, ByVal sTamamlayanAdi As String)
        Try
            Dim sMesaj As String = "✅ *GÖREV TAMAMLANDI*" & vbCrLf & _
                "================================" & vbCrLf & _
                "📌 *Görev:* " & sBaslik & vbCrLf & _
                "👤 *Tamamlayan:* " & sTamamlayanAdi & vbCrLf & _
                "📅 *Tarih:* " & DateTime.Now.ToString("dd.MM.yyyy HH:mm") & vbCrLf & _
                "================================"
            
            Gonder("GOREV_TAMAMLANDI", sMesaj, nGorevVerenID, "Gorev Tamamlandi")
            WhatsAppBildirimPersonel(nGorevVerenID, "GOREV_TAMAMLANDI", sMesaj)
        Catch ex As Exception
            Debug.WriteLine("BildirimServisi.GorevTamamlandiBildirimiGonder Hata: " & ex.Message)
        End Try
    End Sub
    
    ''' <summary>
    ''' Belirli bir personele WhatsApp bildirimi gonderir (tercihine gore)
    ''' </summary>
    Private Sub WhatsAppBildirimPersonel(ByVal nPersonelID As Integer, ByVal sTipKodu As String, ByVal sMesaj As String)
        Try
            Dim dt As DataTable = SQLCalistir( _
                "SELECT p.TELEFON1, ISNULL(t.bWhatsAppAktif, p.bWhatsAppBildirimAl) AS bWhatsApp " & _
                "FROM APERSONEL p " & _
                "LEFT JOIN tbKullaniciBildirimTercihleri t ON p.IND = t.nKullaniciID " & _
                "LEFT JOIN tbBildirimTipleri bt ON t.nTipID = bt.nTipID AND bt.sTipKodu = '" & sTipKodu & "' " & _
                "WHERE p.IND = " & nPersonelID & " AND p.AKTIF = 1")
            
            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
                Dim sTelefon As String = dt.Rows(0)("TELEFON1").ToString().Trim()
                Dim bWhatsApp As Boolean = Convert.ToBoolean(If(dt.Rows(0)("bWhatsApp") Is DBNull.Value, False, dt.Rows(0)("bWhatsApp")))
                
                If bWhatsApp AndAlso Not String.IsNullOrEmpty(sTelefon) Then
                    WhatsAppGonder(sTelefon, sMesaj, 0, nPersonelID)
                End If
            End If
        Catch
        End Try
    End Sub
    
    ' =============================================
    ' URETIM BILDIRIMLERI
    ' =============================================
    
    ''' <summary>
    ''' Uretim basladi bildirimi
    ''' </summary>
    Public Sub UretimBasladiBildirimiGonder(ByVal nUretimEmriID As Integer, ByVal sEvrakNo As String, ByVal sUrunAdi As String, ByVal lMiktar As Decimal)
        Try
            Dim sMesaj As String = "🏭 *ÜRETİM BAŞLADI*" & vbCrLf & _
                "================================" & vbCrLf & _
                "📋 *Evrak No:* " & sEvrakNo & vbCrLf & _
                "📦 *Ürün:* " & sUrunAdi & vbCrLf & _
                "📊 *Miktar:* " & lMiktar.ToString("N0") & vbCrLf & _
                "📅 *Tarih:* " & DateTime.Now.ToString("dd.MM.yyyy HH:mm") & vbCrLf & _
                "================================"
            
            WhatsAppBildirimGonder("URETIM_BASLADI", sMesaj, "Üretim Başladı")
        Catch ex As Exception
            Debug.WriteLine("UretimBasladiBildirimiGonder Hata: " & ex.Message)
        End Try
    End Sub
    
    ''' <summary>
    ''' Uretim tamamlandi bildirimi
    ''' </summary>
    Public Sub UretimTamamlandiBildirimiGonder(ByVal nUretimEmriID As Integer, ByVal sEvrakNo As String, ByVal sUrunAdi As String, ByVal lMiktar As Decimal)
        Try
            Dim sMesaj As String = "✅ *ÜRETİM TAMAMLANDI*" & vbCrLf & _
                "================================" & vbCrLf & _
                "📋 *Evrak No:* " & sEvrakNo & vbCrLf & _
                "📦 *Ürün:* " & sUrunAdi & vbCrLf & _
                "📊 *Miktar:* " & lMiktar.ToString("N0") & vbCrLf & _
                "📅 *Tarih:* " & DateTime.Now.ToString("dd.MM.yyyy HH:mm") & vbCrLf & _
                "================================"
            
            WhatsAppBildirimGonder("URETIM_TAMAMLANDI", sMesaj, "Üretim Tamamlandı")
        Catch ex As Exception
            Debug.WriteLine("UretimTamamlandiBildirimiGonder Hata: " & ex.Message)
        End Try
    End Sub
    
    ''' <summary>
    ''' Uretim gecikme bildirimi
    ''' </summary>
    Public Sub UretimGecikmeBildirimiGonder(ByVal sEvrakNo As String, ByVal sUrunAdi As String, ByVal nGecikenGun As Integer)
        Try
            Dim sMesaj As String = "⚠️ *ÜRETİM GECİKMESİ*" & vbCrLf & _
                "================================" & vbCrLf & _
                "📋 *Evrak No:* " & sEvrakNo & vbCrLf & _
                "📦 *Ürün:* " & sUrunAdi & vbCrLf & _
                "⏰ *Geciken Gün:* " & nGecikenGun & vbCrLf & _
                "📅 *Tarih:* " & DateTime.Now.ToString("dd.MM.yyyy HH:mm") & vbCrLf & _
                "================================"
            
            WhatsAppBildirimGonder("URETIM_GECIKME", sMesaj, "Üretim Gecikmesi")
        Catch ex As Exception
            Debug.WriteLine("UretimGecikmeBildirimiGonder Hata: " & ex.Message)
        End Try
    End Sub
    
    ''' <summary>
    ''' Uretim fire bildirimi
    ''' </summary>
    Public Sub UretimFireBildirimiGonder(ByVal sEvrakNo As String, ByVal sUrunAdi As String, ByVal lFireMiktar As Decimal, ByVal sNeden As String)
        Try
            Dim sMesaj As String = "🔥 *ÜRETİM FİRE BİLDİRİMİ*" & vbCrLf & _
                "================================" & vbCrLf & _
                "📋 *Evrak No:* " & sEvrakNo & vbCrLf & _
                "📦 *Ürün:* " & sUrunAdi & vbCrLf & _
                "📊 *Fire Miktarı:* " & lFireMiktar.ToString("N0") & vbCrLf & _
                "📝 *Neden:* " & sNeden & vbCrLf & _
                "📅 *Tarih:* " & DateTime.Now.ToString("dd.MM.yyyy HH:mm") & vbCrLf & _
                "================================"
            
            WhatsAppBildirimGonder("URETIM_FIRE", sMesaj, "Üretim Fire")
        Catch ex As Exception
            Debug.WriteLine("UretimFireBildirimiGonder Hata: " & ex.Message)
        End Try
    End Sub
    
    ''' <summary>
    ''' Uretim onay bekliyor bildirimi
    ''' </summary>
    Public Sub UretimOnayBekliyorBildirimiGonder(ByVal sEvrakNo As String, ByVal sAsamaAdi As String, ByVal sUrunAdi As String)
        Try
            Dim sMesaj As String = "⏳ *ÜRETİM ONAYI BEKLİYOR*" & vbCrLf & _
                "================================" & vbCrLf & _
                "📋 *Evrak No:* " & sEvrakNo & vbCrLf & _
                "🔄 *Aşama:* " & sAsamaAdi & vbCrLf & _
                "📦 *Ürün:* " & sUrunAdi & vbCrLf & _
                "📅 *Tarih:* " & DateTime.Now.ToString("dd.MM.yyyy HH:mm") & vbCrLf & _
                "================================" & vbCrLf & _
                "Lütfen onayınızı verin."
            
            WhatsAppBildirimGonder("URETIM_ONAY_BEKLIYOR", sMesaj, "Üretim Onayı Bekliyor")
        Catch ex As Exception
            Debug.WriteLine("UretimOnayBekliyorBildirimiGonder Hata: " & ex.Message)
        End Try
    End Sub
    
    ''' <summary>
    ''' Uretim asamasi bildirimi (basladi, tamamlandi, onay bekliyor)
    ''' </summary>
    Public Sub UretimAsamaBildirimiGonder(ByVal nUretimEmriID As Integer, ByVal sAsamaAdi As String, ByVal sDurum As String)
        Try
            Dim sMesaj As String = "Uretim Emri #" & nUretimEmriID & vbCrLf & "Asama: " & sAsamaAdi & vbCrLf & "Durum: " & sDurum
            
            ' Asama ID'sini bul
            Dim dtAsama As DataTable = SQLCalistir("SELECT nAsamaID FROM tbUretimAsamaTanim WHERE sAsamaAdi = '" & sAsamaAdi.Replace("'", "''") & "'")
            If dtAsama.Rows.Count = 0 Then Exit Sub
            
            Dim nAsamaID As Integer = Convert.ToInt32(dtAsama.Rows(0)("nAsamaID"))
            
            ' Bu asama icin yetkili personelleri bul (tbOnayYetkilisi uzerinden)
            Dim dtYetkililer As DataTable = SQLCalistir("SELECT DISTINCT p.IND AS nKullaniciID FROM tbOnayYetkilisi oy INNER JOIN APERSONEL p ON oy.nPersonelID = p.IND WHERE (oy.nAsamaID = " & nAsamaID & " OR oy.nAsamaID IS NULL) AND oy.bAktif = 1 AND p.AKTIF = 1")
            
            ' Eger tablo bos ise eski tablodan dene
            If dtYetkililer.Rows.Count = 0 Then
                dtYetkililer = SQLCalistir("SELECT DISTINCT p.IND AS nKullaniciID FROM tbUretimAsamaYetkililer y INNER JOIN APERSONEL p ON y.nPersonelID = p.IND WHERE y.nAsamaID = " & nAsamaID & " AND p.AKTIF = 1")
            End If
            
            Dim sTipKodu As String = "URETIM_ASAMA_" & sDurum.ToUpper().Replace(" ", "_")
            
            For Each dr As DataRow In dtYetkililer.Rows
                Gonder(sTipKodu, sMesaj, Convert.ToInt32(dr("nKullaniciID")), "Uretim Asamasi: " & sAsamaAdi)
            Next
            
        Catch ex As Exception
            Debug.WriteLine("BildirimServisi.UretimAsamaBildirimiGonder Hata: " & ex.Message)
        End Try
    End Sub
    
    ''' <summary>
    ''' Uretim asamasi onay talebi bildirimi
    ''' Bir asama tamamlandiginda sonraki asama yetkilisine bildirim gonder
    ''' </summary>
    Public Sub UretimOnayTalebiBildirimiGonder(ByVal nUretimEmriID As Integer, ByVal nAsamaID As Integer, ByVal sOnayTuru As String)
        Try
            ' Asama bilgisi
            Dim dtAsama As DataTable = SQLCalistir("SELECT sAsamaAdi FROM tbUretimAsamaTanim WHERE nAsamaID = " & nAsamaID)
            Dim sAsamaAdi As String = If(dtAsama.Rows.Count > 0, dtAsama.Rows(0)("sAsamaAdi").ToString(), "")
            
            ' Uretim emri bilgisi
            Dim dtUretim As DataTable = SQLCalistir("SELECT EVRAKNO, STOKNO, MIKTAR FROM TBLUREURETIM WHERE IND = " & nUretimEmriID & " OR EVRAKNO = " & nUretimEmriID)
            Dim sEvrakNo As String = If(dtUretim.Rows.Count > 0, dtUretim.Rows(0)("EVRAKNO").ToString(), nUretimEmriID.ToString())
            
            Dim sMesaj As String = "ONAY BEKLENIYOR" & vbCrLf & vbCrLf & "Uretim Emri: #" & sEvrakNo & vbCrLf & "Asama: " & sAsamaAdi & vbCrLf & "Onay Turu: " & sOnayTuru & vbCrLf & vbCrLf & "Lutfen onayinizi verin."
            
            ' Bu onay turune sahip yetkilileri bul
            Dim dtYetkililer As DataTable = SQLCalistir("SELECT DISTINCT p.IND AS nKullaniciID FROM tbOnayYetkilisi oy INNER JOIN tbOnayTurleri ot ON oy.nOnayTurID = ot.nOnayTurID INNER JOIN APERSONEL p ON oy.nPersonelID = p.IND WHERE ot.sOnayTurKodu = '" & sOnayTuru.Replace("'", "''") & "' AND (oy.nAsamaID = " & nAsamaID & " OR oy.nAsamaID IS NULL) AND oy.bAktif = 1 AND p.AKTIF = 1")
            
            For Each dr As DataRow In dtYetkililer.Rows
                Gonder("URETIM_ONAY_TALEBI", sMesaj, Convert.ToInt32(dr("nKullaniciID")), "Onay Talebi: " & sAsamaAdi)
            Next
            
        Catch ex As Exception
            Debug.WriteLine("BildirimServisi.UretimOnayTalebiBildirimiGonder Hata: " & ex.Message)
        End Try
    End Sub
    
    ''' <summary>
    ''' Uretim asamasi tamamlandi, sonraki asamaya gecildi bildirimi
    ''' </summary>
    Public Sub UretimSonrakiAsamaBildirimiGonder(ByVal nUretimEmriID As Integer, ByVal nSonrakiAsamaID As Integer)
        Try
            ' Sonraki asama bilgisi
            Dim dtAsama As DataTable = SQLCalistir("SELECT sAsamaAdi, sOnayTurleri, nGerekliOnay FROM tbUretimAsamaTanim WHERE nAsamaID = " & nSonrakiAsamaID)
            If dtAsama.Rows.Count = 0 Then Exit Sub
            
            Dim sAsamaAdi As String = dtAsama.Rows(0)("sAsamaAdi").ToString()
            Dim sOnayTurleri As String = If(dtAsama.Rows(0)("sOnayTurleri") IsNot DBNull.Value, dtAsama.Rows(0)("sOnayTurleri").ToString(), "URETIM_YETKILISI")
            Dim nGerekliOnay As Integer = If(dtAsama.Rows(0)("nGerekliOnay") IsNot DBNull.Value, Convert.ToInt32(dtAsama.Rows(0)("nGerekliOnay")), 1)
            
            ' Uretim emri bilgisi
            Dim dtUretim As DataTable = SQLCalistir("SELECT u.EVRAKNO, s.sKodu, s.sAciklama, u.MIKTAR FROM TBLUREURETIM u INNER JOIN tbStok s ON u.STOKNO = s.nStokID WHERE u.IND = " & nUretimEmriID & " OR u.EVRAKNO = " & nUretimEmriID)
            Dim sEvrakNo As String = ""
            Dim sUrun As String = ""
            Dim sMiktar As String = ""
            
            If dtUretim.Rows.Count > 0 Then
                sEvrakNo = dtUretim.Rows(0)("EVRAKNO").ToString()
                sUrun = dtUretim.Rows(0)("sKodu").ToString() & " - " & dtUretim.Rows(0)("sAciklama").ToString()
                sMiktar = Convert.ToDecimal(dtUretim.Rows(0)("MIKTAR")).ToString("N2")
            End If
            
            Dim sMesaj As String = "YENI ASAMA BASLADI" & vbCrLf & vbCrLf & "Uretim Emri: #" & sEvrakNo & vbCrLf & "Urun: " & sUrun & vbCrLf & "Miktar: " & sMiktar & vbCrLf & "Yeni Asama: " & sAsamaAdi & vbCrLf & "Gerekli Onay: " & nGerekliOnay.ToString()
            
            ' Ilk onay turundeki yetkililere bildirim gonder
            Dim ilkOnayTur As String = sOnayTurleri.Split(","c)(0).Trim()
            UretimOnayTalebiBildirimiGonder(nUretimEmriID, nSonrakiAsamaID, ilkOnayTur)
            
            ' Asama yetkililerine de genel bildirim
            UretimAsamaBildirimiGonder(nUretimEmriID, sAsamaAdi, "Basladi")
            
        Catch ex As Exception
            Debug.WriteLine("BildirimServisi.UretimSonrakiAsamaBildirimiGonder Hata: " & ex.Message)
        End Try
    End Sub
    
    ''' <summary>
    ''' Uretim gecikme bildirimi
    ''' </summary>
    Public Sub UretimGecikmeBildirimiGonder(ByVal nUretimEmriID As Integer, ByVal sGecikmeNedeni As String, ByVal nGecikmeSuresi As Integer)
        Try
            Dim sMesaj As String = "URETIM GECIKMESI" & vbCrLf & "Uretim Emri #" & nUretimEmriID & vbCrLf & "Neden: " & sGecikmeNedeni & vbCrLf & "Sure: " & nGecikmeSuresi & " dakika"
            YoneticilereGonder(sMesaj, "Uretim Gecikmesi")
        Catch ex As Exception
            Debug.WriteLine("BildirimServisi.UretimGecikmeBildirimiGonder Hata: " & ex.Message)
        End Try
    End Sub
    
    ' =============================================
    ' STOK BILDIRIMLERI
    ' =============================================
    
    ''' <summary>
    ''' Kritik stok seviyesi bildirimi
    ''' </summary>
    Public Sub StokKritikBildirimiGonder(ByVal sStokKodu As String, ByVal sStokAdi As String, ByVal lMevcutMiktar As Decimal, ByVal lKritikSeviye As Decimal)
        Try
            Dim sMesaj As String = "⚠️ *KRİTİK STOK SEVİYESİ*" & vbCrLf & _
                "================================" & vbCrLf & _
                "📦 *Stok Kodu:* " & sStokKodu & vbCrLf & _
                "📋 *Stok Adı:* " & sStokAdi & vbCrLf & _
                "📊 *Mevcut:* " & lMevcutMiktar.ToString("N0") & vbCrLf & _
                "🔴 *Kritik Seviye:* " & lKritikSeviye.ToString("N0") & vbCrLf & _
                "================================"
            
            WhatsAppBildirimGonder("STOK_KRITIK", sMesaj, "Kritik Stok")
        Catch ex As Exception
            Debug.WriteLine("BildirimServisi.StokKritikBildirimiGonder Hata: " & ex.Message)
        End Try
    End Sub
    
    ''' <summary>
    ''' Stok fiyati maliyet altinda bildirimi
    ''' </summary>
    Public Sub StokFiyatDusukBildirimiGonder(ByVal sStokKodu As String, ByVal sStokAdi As String, ByVal lSatisFiyat As Decimal, ByVal lMaliyet As Decimal)
        Try
            Dim sMesaj As String = "💰 *STOK FİYATI MALİYETİN ALTINDA*" & vbCrLf & _
                "================================" & vbCrLf & _
                "📦 *Stok:* " & sStokKodu & " - " & sStokAdi & vbCrLf & _
                "💵 *Satış Fiyatı:* " & lSatisFiyat.ToString("N2") & " TL" & vbCrLf & _
                "📉 *Maliyet:* " & lMaliyet.ToString("N2") & " TL" & vbCrLf & _
                "================================"
            
            WhatsAppBildirimGonder("STOK_FIYAT_DUSUK", sMesaj, "Fiyat Uyarısı")
        Catch ex As Exception
            Debug.WriteLine("BildirimServisi.StokFiyatDusukBildirimiGonder Hata: " & ex.Message)
        End Try
    End Sub
    
    ' =============================================
    ' SATIN ALMA BILDIRIMLERI
    ' =============================================
    
    ''' <summary>
    ''' Satin alma talebi bildirimi
    ''' </summary>
    Public Sub SatinAlmaTalepBildirimiGonder(ByVal sStokKodu As String, ByVal sStokAdi As String, ByVal lMiktar As Decimal, ByVal sTalepEden As String)
        Try
            Dim sMesaj As String = "🛒 *SATIN ALMA TALEBİ*" & vbCrLf & _
                "================================" & vbCrLf & _
                "📦 *Hammadde:* " & sStokKodu & " - " & sStokAdi & vbCrLf & _
                "📊 *Miktar:* " & lMiktar.ToString("N0") & vbCrLf & _
                "👤 *Talep Eden:* " & sTalepEden & vbCrLf & _
                "📅 *Tarih:* " & DateTime.Now.ToString("dd.MM.yyyy HH:mm") & vbCrLf & _
                "================================"
            
            WhatsAppBildirimGonder("SATIN_ALMA_TALEP", sMesaj, "Satın Alma Talebi")
        Catch ex As Exception
            Debug.WriteLine("SatinAlmaTalepBildirimiGonder Hata: " & ex.Message)
        End Try
    End Sub
    
    ''' <summary>
    ''' Satin alma siparisi onay talebi bildirimi
    ''' </summary>
    Public Sub SatinAlmaOnayTalebiBildirimiGonder(ByVal nSatinAlmaID As Integer, ByVal sStokKodu As String, ByVal sStokAdi As String, ByVal lMiktar As Decimal, ByVal sTedarikci As String, ByVal lToplam As Decimal)
        Try
            Dim sMesaj As String = "📋 *SATIN ALMA ONAY TALEBİ*" & vbCrLf & _
                "================================" & vbCrLf & _
                "📦 *Hammadde:* " & sStokKodu & " - " & sStokAdi & vbCrLf & _
                "📊 *Miktar:* " & lMiktar.ToString("N0") & vbCrLf & _
                "🏢 *Tedarikçi:* " & sTedarikci & vbCrLf & _
                "💰 *Toplam:* " & lToplam.ToString("N2") & " TL" & vbCrLf & _
                "================================" & vbCrLf & _
                "Onayınız beklenmektedir."
            
            WhatsAppBildirimGonder("SATIN_ALMA_TALEP", sMesaj, "Satın Alma Onay Talebi")
        Catch ex As Exception
            Debug.WriteLine("BildirimServisi.SatinAlmaOnayTalebiBildirimiGonder Hata: " & ex.Message)
        End Try
    End Sub
    
    ''' <summary>
    ''' Satin alma siparisi onaylandi bildirimi
    ''' </summary>
    Public Sub SatinAlmaOnaylandiBildirimiGonder(ByVal nSatinAlmaID As Integer, ByVal sStokKodu As String, ByVal sStokAdi As String, ByVal lMiktar As Decimal, ByVal sTedarikci As String, ByVal sOnaylayan As String)
        Try
            Dim sMesaj As String = "✅ *SATIN ALMA ONAYLANDI*" & vbCrLf & _
                "================================" & vbCrLf & _
                "📦 *Hammadde:* " & sStokKodu & " - " & sStokAdi & vbCrLf & _
                "📊 *Miktar:* " & lMiktar.ToString("N0") & vbCrLf & _
                "🏢 *Tedarikçi:* " & sTedarikci & vbCrLf & _
                "👤 *Onaylayan:* " & sOnaylayan & vbCrLf & _
                "📅 *Tarih:* " & DateTime.Now.ToString("dd.MM.yyyy HH:mm") & vbCrLf & _
                "================================"
            
            WhatsAppBildirimGonder("SATIN_ALMA_ONAYLANDI", sMesaj, "Satın Alma Onaylandı")
        Catch ex As Exception
            Debug.WriteLine("BildirimServisi.SatinAlmaOnaylandiBildirimiGonder Hata: " & ex.Message)
        End Try
    End Sub
    
    ''' <summary>
    ''' Satin alma siparisi reddedildi bildirimi
    ''' </summary>
    Public Sub SatinAlmaReddedildiBildirimiGonder(ByVal nSatinAlmaID As Integer, ByVal sStokKodu As String, ByVal sStokAdi As String, ByVal sReddeden As String, ByVal sNeden As String)
        Try
            Dim sMesaj As String = "❌ *SATIN ALMA REDDEDİLDİ*" & vbCrLf & _
                "================================" & vbCrLf & _
                "📦 *Hammadde:* " & sStokKodu & " - " & sStokAdi & vbCrLf & _
                "👤 *Reddeden:* " & sReddeden & vbCrLf & _
                "📝 *Neden:* " & sNeden & vbCrLf & _
                "📅 *Tarih:* " & DateTime.Now.ToString("dd.MM.yyyy HH:mm") & vbCrLf & _
                "================================"
            
            WhatsAppBildirimGonder("SATIN_ALMA_TALEP", sMesaj, "Satın Alma Reddedildi")
        Catch ex As Exception
            Debug.WriteLine("BildirimServisi.SatinAlmaReddedildiBildirimiGonder Hata: " & ex.Message)
        End Try
    End Sub
    
    ' =============================================
    ' FINANS BILDIRIMLERI
    ' =============================================
    
    ''' <summary>
    ''' Cek vadesi yaklasti bildirimi
    ''' </summary>
    Public Sub CekVadeYaklastiBildirimiGonder(ByVal sEvrakNo As String, ByVal dteVade As DateTime, ByVal lTutar As Decimal, ByVal sFirma As String)
        Try
            Dim sMesaj As String = "📅 *ÇEK VADESİ YAKLASTI*" & vbCrLf & _
                "================================" & vbCrLf & _
                "📋 *Evrak No:* " & sEvrakNo & vbCrLf & _
                "🏢 *Firma:* " & sFirma & vbCrLf & _
                "💰 *Tutar:* " & lTutar.ToString("N2") & " TL" & vbCrLf & _
                "📅 *Vade:* " & dteVade.ToString("dd.MM.yyyy") & vbCrLf & _
                "================================"
            
            WhatsAppBildirimGonder("CEK_VADE_YAKLASTI", sMesaj, "Çek Vadesi Yaklaştı")
        Catch ex As Exception
            Debug.WriteLine("CekVadeYaklastiBildirimiGonder Hata: " & ex.Message)
        End Try
    End Sub
    
    ''' <summary>
    ''' Senet vadesi yaklasti bildirimi
    ''' </summary>
    Public Sub SenetVadeYaklastiBildirimiGonder(ByVal sEvrakNo As String, ByVal dteVade As DateTime, ByVal lTutar As Decimal, ByVal sFirma As String)
        Try
            Dim sMesaj As String = "📅 *SENET VADESİ YAKLASTI*" & vbCrLf & _
                "================================" & vbCrLf & _
                "📋 *Evrak No:* " & sEvrakNo & vbCrLf & _
                "🏢 *Firma:* " & sFirma & vbCrLf & _
                "💰 *Tutar:* " & lTutar.ToString("N2") & " TL" & vbCrLf & _
                "📅 *Vade:* " & dteVade.ToString("dd.MM.yyyy") & vbCrLf & _
                "================================"
            
            WhatsAppBildirimGonder("SENET_VADE_YAKLASTI", sMesaj, "Senet Vadesi Yaklaştı")
        Catch ex As Exception
            Debug.WriteLine("SenetVadeYaklastiBildirimiGonder Hata: " & ex.Message)
        End Try
    End Sub
    
    ''' <summary>
    ''' Yuksek tutarli nakit islem bildirimi
    ''' </summary>
    Public Sub YuksekNakitIslemBildirimiGonder(ByVal sIslemTipi As String, ByVal lTutar As Decimal, ByVal sKullanici As String)
        Try
            Dim sMesaj As String = "💵 *YÜKSEK TUTARLI NAKİT İŞLEM*" & vbCrLf & _
                "================================" & vbCrLf & _
                "📋 *İşlem Tipi:* " & sIslemTipi & vbCrLf & _
                "💰 *Tutar:* " & lTutar.ToString("N2") & " TL" & vbCrLf & _
                "👤 *Kullanıcı:* " & sKullanici & vbCrLf & _
                "📅 *Tarih:* " & DateTime.Now.ToString("dd.MM.yyyy HH:mm") & vbCrLf & _
                "================================"
            
            WhatsAppBildirimGonder("YUKSEK_NAKIT_ISLEM", sMesaj, "Yüksek Nakit İşlem")
        Catch ex As Exception
            Debug.WriteLine("YuksekNakitIslemBildirimiGonder Hata: " & ex.Message)
        End Try
    End Sub
    
    ''' <summary>
    ''' Odeme bekliyor bildirimi
    ''' </summary>
    Public Sub OdemeBekliyorBildirimiGonder(ByVal sFirma As String, ByVal lTutar As Decimal, ByVal dteVade As DateTime)
        Try
            Dim sMesaj As String = "💳 *ÖDEME BEKLİYOR*" & vbCrLf & _
                "================================" & vbCrLf & _
                "🏢 *Firma:* " & sFirma & vbCrLf & _
                "💰 *Tutar:* " & lTutar.ToString("N2") & " TL" & vbCrLf & _
                "📅 *Vade:* " & dteVade.ToString("dd.MM.yyyy") & vbCrLf & _
                "================================"
            
            WhatsAppBildirimGonder("ODEME_BEKLIYOR", sMesaj, "Ödeme Bekliyor")
        Catch ex As Exception
            Debug.WriteLine("OdemeBekliyorBildirimiGonder Hata: " & ex.Message)
        End Try
    End Sub
    
    ''' <summary>
    ''' Cek/Senet vade yaklasti bildirimi (eski fonksiyon - uyumluluk icin)
    ''' </summary>
    Public Sub VadeYaklastiBildirimiGonder(ByVal sTip As String, ByVal sEvrakNo As String, ByVal dteVade As DateTime, ByVal lTutar As Decimal)
        Try
            If sTip.ToLower().Contains("cek") Then
                CekVadeYaklastiBildirimiGonder(sEvrakNo, dteVade, lTutar, "")
            Else
                SenetVadeYaklastiBildirimiGonder(sEvrakNo, dteVade, lTutar, "")
            End If
        Catch ex As Exception
            Debug.WriteLine("BildirimServisi.VadeYaklastiBildirimiGonder Hata: " & ex.Message)
        End Try
    End Sub
    
    ' =============================================
    ' E-TICARET BILDIRIMLERI
    ' =============================================
    
    ''' <summary>
    ''' E-ticaret iade talebi bildirimi
    ''' </summary>
    Public Sub ETicaretIadeBildirimiGonder(ByVal sSiparisNo As String, ByVal sMusteriAdi As String, ByVal sUrunAdi As String, ByVal sNeden As String)
        Try
            Dim sMesaj As String = "🔄 *E-TİCARET İADE TALEBİ*" & vbCrLf & _
                "================================" & vbCrLf & _
                "📋 *Sipariş No:* " & sSiparisNo & vbCrLf & _
                "👤 *Müşteri:* " & sMusteriAdi & vbCrLf & _
                "📦 *Ürün:* " & sUrunAdi & vbCrLf & _
                "📝 *Neden:* " & sNeden & vbCrLf & _
                "📅 *Tarih:* " & DateTime.Now.ToString("dd.MM.yyyy HH:mm") & vbCrLf & _
                "================================"
            
            WhatsAppBildirimGonder("ETICARET_IADE", sMesaj, "E-Ticaret İade Talebi")
        Catch ex As Exception
            Debug.WriteLine("ETicaretIadeBildirimiGonder Hata: " & ex.Message)
        End Try
    End Sub
    
    ' =============================================
    ' BELGE BILDIRIMLERI
    ' =============================================
    
    ''' <summary>
    ''' Fatura silindi bildirimi
    ''' </summary>
    Public Sub FaturaSilindiBildirimiGonder(ByVal sEvrakNo As String, ByVal sFirma As String, ByVal lTutar As Decimal, ByVal sSilenKullanici As String)
        Try
            Dim sMesaj As String = "🗑️ *FATURA SİLİNDİ*" & vbCrLf & _
                "================================" & vbCrLf & _
                "📋 *Evrak No:* " & sEvrakNo & vbCrLf & _
                "🏢 *Firma:* " & sFirma & vbCrLf & _
                "💰 *Tutar:* " & lTutar.ToString("N2") & " TL" & vbCrLf & _
                "👤 *Silen:* " & sSilenKullanici & vbCrLf & _
                "📅 *Tarih:* " & DateTime.Now.ToString("dd.MM.yyyy HH:mm") & vbCrLf & _
                "================================"
            
            WhatsAppBildirimGonder("FATURA_SILINDI", sMesaj, "Fatura Silindi")
        Catch ex As Exception
            Debug.WriteLine("FaturaSilindiBildirimiGonder Hata: " & ex.Message)
        End Try
    End Sub
    
    ''' <summary>
    ''' Irsaliye silindi bildirimi
    ''' </summary>
    Public Sub IrsaliyeSilindiBildirimiGonder(ByVal sEvrakNo As String, ByVal sFirma As String, ByVal sSilenKullanici As String)
        Try
            Dim sMesaj As String = "🗑️ *İRSALİYE SİLİNDİ*" & vbCrLf & _
                "================================" & vbCrLf & _
                "📋 *Evrak No:* " & sEvrakNo & vbCrLf & _
                "🏢 *Firma:* " & sFirma & vbCrLf & _
                "👤 *Silen:* " & sSilenKullanici & vbCrLf & _
                "📅 *Tarih:* " & DateTime.Now.ToString("dd.MM.yyyy HH:mm") & vbCrLf & _
                "================================"
            
            WhatsAppBildirimGonder("IRSALIYE_SILINDI", sMesaj, "İrsaliye Silindi")
        Catch ex As Exception
            Debug.WriteLine("IrsaliyeSilindiBildirimiGonder Hata: " & ex.Message)
        End Try
    End Sub
    
    ''' <summary>
    ''' Siparis silindi bildirimi
    ''' </summary>
    Public Sub SiparisSilindiBildirimiGonder(ByVal sEvrakNo As String, ByVal sFirma As String, ByVal sSilenKullanici As String)
        Try
            Dim sMesaj As String = "🗑️ *SİPARİŞ SİLİNDİ*" & vbCrLf & _
                "================================" & vbCrLf & _
                "📋 *Evrak No:* " & sEvrakNo & vbCrLf & _
                "🏢 *Firma:* " & sFirma & vbCrLf & _
                "👤 *Silen:* " & sSilenKullanici & vbCrLf & _
                "📅 *Tarih:* " & DateTime.Now.ToString("dd.MM.yyyy HH:mm") & vbCrLf & _
                "================================"
            
            WhatsAppBildirimGonder("SIPARIS_SILINDI", sMesaj, "Sipariş Silindi")
        Catch ex As Exception
            Debug.WriteLine("SiparisSilindiBildirimiGonder Hata: " & ex.Message)
        End Try
    End Sub
    
    ' =============================================
    ' SISTEM BILDIRIMLERI
    ' =============================================
    
    ''' <summary>
    ''' Sistem hatasi bildirimi
    ''' </summary>
    Public Sub SistemHatasiBildirimiGonder(ByVal sModul As String, ByVal sHata As String)
        Try
            Dim sMesaj As String = "🔴 *SİSTEM HATASI*" & vbCrLf & _
                "================================" & vbCrLf & _
                "📋 *Modül:* " & sModul & vbCrLf & _
                "❌ *Hata:* " & sHata & vbCrLf & _
                "📅 *Tarih:* " & DateTime.Now.ToString("dd.MM.yyyy HH:mm") & vbCrLf & _
                "================================"
            
            WhatsAppBildirimGonder("SISTEM_HATA", sMesaj, "Sistem Hatası")
        Catch ex As Exception
            Debug.WriteLine("SistemHatasiBildirimiGonder Hata: " & ex.Message)
        End Try
    End Sub
    
    ''' <summary>
    ''' Sistem uyarisi bildirimi
    ''' </summary>
    Public Sub SistemUyarisiBildirimiGonder(ByVal sKonu As String, ByVal sAciklama As String)
        Try
            Dim sMesaj As String = "⚠️ *SİSTEM UYARISI*" & vbCrLf & _
                "================================" & vbCrLf & _
                "📋 *Konu:* " & sKonu & vbCrLf & _
                "📝 *Açıklama:* " & sAciklama & vbCrLf & _
                "📅 *Tarih:* " & DateTime.Now.ToString("dd.MM.yyyy HH:mm") & vbCrLf & _
                "================================"
            
            WhatsAppBildirimGonder("SISTEM_UYARI", sMesaj, "Sistem Uyarısı")
        Catch ex As Exception
            Debug.WriteLine("SistemUyarisiBildirimiGonder Hata: " & ex.Message)
        End Try
    End Sub
    
    ''' <summary>
    ''' Kullanici girisi bildirimi
    ''' </summary>
    Public Sub KullaniciGirisBildirimiGonder(ByVal sKullaniciAdi As String, ByVal sBilgisayar As String)
        Try
            Dim sMesaj As String = "🔑 *KULLANICI GİRİŞİ*" & vbCrLf & _
                "================================" & vbCrLf & _
                "👤 *Kullanıcı:* " & sKullaniciAdi & vbCrLf & _
                "💻 *Bilgisayar:* " & sBilgisayar & vbCrLf & _
                "📅 *Tarih:* " & DateTime.Now.ToString("dd.MM.yyyy HH:mm") & vbCrLf & _
                "================================"
            
            WhatsAppBildirimGonder("KULLANICI_GIRIS", sMesaj, "Kullanıcı Girişi")
        Catch ex As Exception
            Debug.WriteLine("KullaniciGirisBildirimiGonder Hata: " & ex.Message)
        End Try
    End Sub
    
    ' =============================================
    ' GENEL BILDIRIMLER
    ' =============================================
    
    ''' <summary>
    ''' Genel duyuru bildirimi
    ''' </summary>
    Public Sub DuyuruBildirimiGonder(ByVal sBaslik As String, ByVal sIcerik As String)
        Try
            Dim sMesaj As String = "📢 *DUYURU*" & vbCrLf & _
                "================================" & vbCrLf & _
                "📋 *" & sBaslik & "*" & vbCrLf & vbCrLf & _
                sIcerik & vbCrLf & _
                "================================" & vbCrLf & _
                "📅 " & DateTime.Now.ToString("dd.MM.yyyy HH:mm")
            
            WhatsAppBildirimGonder("DUYURU", sMesaj, "Duyuru")
        Catch ex As Exception
            Debug.WriteLine("DuyuruBildirimiGonder Hata: " & ex.Message)
        End Try
    End Sub
    
    ''' <summary>
    ''' Anlik mesaj bildirimi (belirli kisiye)
    ''' </summary>
    Public Sub AnlikMesajBildirimiGonder(ByVal nAliciID As Integer, ByVal sBaslik As String, ByVal sMesaj As String)
        Try
            Dim tamMesaj As String = "💬 *" & sBaslik & "*" & vbCrLf & _
                "================================" & vbCrLf & _
                sMesaj & vbCrLf & _
                "================================" & vbCrLf & _
                "📅 " & DateTime.Now.ToString("dd.MM.yyyy HH:mm")
            
            ' Uygulama ici bildirim
            Gonder("ANLIK_MESAJ", tamMesaj, nAliciID, sBaslik)
            
            ' WhatsApp bildirimi
            WhatsAppBildirimPersonel(nAliciID, "ANLIK_MESAJ", tamMesaj)
        Catch ex As Exception
            Debug.WriteLine("AnlikMesajBildirimiGonder Hata: " & ex.Message)
        End Try
    End Sub
    
    ' =============================================
    ' BILDIRIM LOG SISTEMI
    ' =============================================
    
    ''' <summary>
    ''' Bildirim loguna kayit ekler ve LogID dondurur
    ''' </summary>
    Public Function BildirimLogKaydet(ByVal sTipKodu As String, ByVal nAliciID As Integer, ByVal sAliciAdi As String, ByVal sKanal As String, ByVal sBaslik As String, ByVal sMesaj As String, Optional ByVal sReferansID As String = "") As Integer
        Try
            Dim sMakine As String = Environment.MachineName
            SQLCalistirNonQuery("INSERT INTO tbBildirimLog (sTipKodu, nAliciID, sAliciAdi, sKanal, sBaslik, sMesaj, sReferansID, sGonderenMakine, sGonderimDurum) VALUES ('" & sTipKodu & "', " & nAliciID & ", '" & sAliciAdi.Replace("'", "''") & "', '" & sKanal & "', '" & sBaslik.Replace("'", "''") & "', '" & sMesaj.Replace("'", "''") & "', '" & sReferansID.Replace("'", "''") & "', '" & sMakine & "', 'Gonderildi')")
            
            ' Son eklenen ID'yi al
            Dim dtID As DataTable = SQLCalistir("SELECT MAX(nLogID) AS nLogID FROM tbBildirimLog WHERE sGonderenMakine = '" & sMakine & "'")
            If dtID.Rows.Count > 0 AndAlso dtID.Rows(0)("nLogID") IsNot DBNull.Value Then
                Return Convert.ToInt32(dtID.Rows(0)("nLogID"))
            End If
        Catch ex As Exception
            Debug.WriteLine("BildirimLogKaydet Hata: " & ex.Message)
        End Try
        Return 0
    End Function
    
    ''' <summary>
    ''' Bildirimi teslim edildi olarak isaretle
    ''' </summary>
    Public Sub BildirimTeslimEdildi(ByVal nLogID As Integer)
        Try
            SQLCalistirNonQuery("UPDATE tbBildirimLog SET bTeslimEdildi = 1, dteTeslimTarihi = GETDATE() WHERE nLogID = " & nLogID)
        Catch ex As Exception
            Debug.WriteLine("BildirimTeslimEdildi Hata: " & ex.Message)
        End Try
    End Sub
    
    ''' <summary>
    ''' Bildirimi okundu olarak isaretle
    ''' </summary>
    Public Sub BildirimOkundu(ByVal nLogID As Integer)
        Try
            SQLCalistirNonQuery("UPDATE tbBildirimLog SET bOkundu = 1, dteOkunmaTarihi = GETDATE(), bTeslimEdildi = 1, dteTeslimTarihi = ISNULL(dteTeslimTarihi, GETDATE()) WHERE nLogID = " & nLogID)
        Catch ex As Exception
            Debug.WriteLine("BildirimOkundu Hata: " & ex.Message)
        End Try
    End Sub
    
    ''' <summary>
    ''' Bildirimi onaylandi olarak isaretle (onemli bildirimler icin)
    ''' </summary>
    Public Sub BildirimOnaylandi(ByVal nLogID As Integer)
        Try
            SQLCalistirNonQuery("UPDATE tbBildirimLog SET bOnaylandi = 1, dteOnayTarihi = GETDATE(), bOkundu = 1, dteOkunmaTarihi = ISNULL(dteOkunmaTarihi, GETDATE()) WHERE nLogID = " & nLogID)
        Catch ex As Exception
            Debug.WriteLine("BildirimOnaylandi Hata: " & ex.Message)
        End Try
    End Sub
    
    ''' <summary>
    ''' Kullanicinin okunmamis bildirimlerini getirir
    ''' </summary>
    Public Function OkunmamisBildirimleriGetir(ByVal nKullaniciID As Integer) As DataTable
        Try
            Return SQLCalistir("SELECT nLogID, sTipKodu, sBaslik, sMesaj, sKanal, dteOlusturma, bTeslimEdildi, bOkundu, bOnaylandi FROM tbBildirimLog WHERE nAliciID = " & nKullaniciID & " AND bOkundu = 0 ORDER BY dteOlusturma DESC")
        Catch ex As Exception
            Debug.WriteLine("OkunmamisBildirimleriGetir Hata: " & ex.Message)
            Return New DataTable()
        End Try
    End Function
    
    ''' <summary>
    ''' Kullanicinin tum bildirimlerini getirir (son 30 gun)
    ''' </summary>
    Public Function TumBildirimleriGetir(ByVal nKullaniciID As Integer, Optional ByVal nGunSayisi As Integer = 30) As DataTable
        Try
            Return SQLCalistir("SELECT nLogID, sTipKodu, sBaslik, sMesaj, sKanal, dteOlusturma, bTeslimEdildi, dteTeslimTarihi, bOkundu, dteOkunmaTarihi, bOnaylandi, dteOnayTarihi, sReferansID FROM tbBildirimLog WHERE nAliciID = " & nKullaniciID & " AND dteOlusturma >= DATEADD(DAY, -" & nGunSayisi & ", GETDATE()) ORDER BY dteOlusturma DESC")
        Catch ex As Exception
            Debug.WriteLine("TumBildirimleriGetir Hata: " & ex.Message)
            Return New DataTable()
        End Try
    End Function
    
    ''' <summary>
    ''' Okunmamis bildirim sayisini dondurur (Uygulama icin)
    ''' </summary>
    Public Function OkunmamisBildirimSayisi(ByVal nKullaniciID As Integer) As Integer
        Try
            Dim dt As DataTable = SQLCalistir("SELECT COUNT(*) AS Sayi FROM tbBildirimLog WHERE nAliciID = " & nKullaniciID & " AND sKanal = 'Uygulama' AND bOkundu = 0")
            If dt.Rows.Count > 0 Then
                Return Convert.ToInt32(dt.Rows(0)("Sayi"))
            End If
        Catch ex As Exception
            Debug.WriteLine("BildirimServisi.OkunmamisBildirimSayisi Hata: " & ex.Message)
        End Try
        Return 0
    End Function
    
    ''' <summary>
    ''' Bildirim daha once gonderilmis mi kontrol eder
    ''' </summary>
    Private Function BildirimGonderilmisMi(ByVal sTipKodu As String, ByVal sReferansID As String) As Boolean
        Try
            Dim dt As DataTable = SQLCalistir("SELECT COUNT(*) AS Sayi FROM tbBildirimGonderimKontrol WHERE sTipKodu = '" & sTipKodu & "' AND sReferansID = '" & sReferansID.Replace("'", "''") & "' AND dteGonderimTarihi = CONVERT(DATE, GETDATE())")
            If dt.Rows.Count > 0 AndAlso Convert.ToInt32(dt.Rows(0)("Sayi")) > 0 Then
                Return True ' Bugun zaten gonderilmis
            End If
        Catch
        End Try
        Return False
    End Function
    
    ''' <summary>
    ''' Bildirim gonderildigini kaydet
    ''' </summary>
    Private Sub BildirimGonderildiKaydet(ByVal sTipKodu As String, ByVal sReferansID As String)
        Try
            Dim sMakine As String = Environment.MachineName
            SQLCalistirNonQuery("INSERT INTO tbBildirimGonderimKontrol (sTipKodu, sReferansID, dteGonderimTarihi, sMakineAdi) VALUES ('" & sTipKodu & "', '" & sReferansID.Replace("'", "''") & "', CONVERT(DATE, GETDATE()), '" & sMakine & "')")
        Catch
            ' Unique constraint hatasi olabilir, onemli degil
        End Try
    End Sub
    
    ''' <summary>
    ''' 24 saat icinde teslim edilmeyen/okunmayan bildirimleri kontrol eder ve admin/sorumluya bildirir
    ''' Gunluk olarak calistirilmali (Form1_Load veya Timer ile)
    ''' </summary>
    Public Sub TeslimEdilmeyenBildirimleriKontrolEt()
        Try
            ' Takip aktif mi kontrol et
            If SistemAyarGetir("BILDIRIM_TAKIP_AKTIF") <> "1" Then Exit Sub
            
            ' Bugun zaten kontrol yapilmis mi?
            If BildirimGonderilmisMi("TESLIM_KONTROL_GUNLUK", DateTime.Now.ToString("yyyyMMdd")) Then
                Debug.WriteLine("Teslim edilmeyen bildirim kontrolu bugun zaten yapilmis, atlaniyor.")
                Exit Sub
            End If
            
            ' Kac saat sonra uyari verilecek (varsayilan 24 saat)
            Dim nTakipSureSaat As Integer = 24
            Try
                Dim sSure As String = SistemAyarGetir("BILDIRIM_TAKIP_SURESI_SAAT")
                If sSure <> "" Then Integer.TryParse(sSure, nTakipSureSaat)
            Catch
            End Try
            
            ' Sorumlu personel ID (0 ise adminlere gonder)
            Dim nSorumluID As Integer = 0
            Try
                Dim sID As String = SistemAyarGetir("BILDIRIM_TAKIP_SORUMLUSU_ID")
                If sID <> "" Then Integer.TryParse(sID, nSorumluID)
            Catch
            End Try
            
            ' Teslim edilmeyen bildirimleri bul (belirtilen saatten eski, hala teslim edilmemis)
            Dim dtTeslimEdilmeyen As DataTable = SQLCalistir( _
                "SELECT nLogID, nAliciID, sBaslik, sMesaj, sKanal, dteOlusturma, " & _
                "(SELECT ISNULL(PERSONELADI, 'Bilinmiyor') FROM APERSONEL WHERE IND = l.nAliciID) AS sAliciAdi " & _
                "FROM tbBildirimLog l " & _
                "WHERE bTeslimEdildi = 0 " & _
                "AND dteOlusturma < DATEADD(HOUR, -" & nTakipSureSaat & ", GETDATE()) " & _
                "AND sKanal IN ('EMAIL', 'SMS', 'WhatsApp') " & _
                "ORDER BY dteOlusturma DESC")
            
            ' Okunmayan bildirimleri bul (teslim edilmis ama okunmamis, belirtilen saatten eski)
            Dim dtOkunmayan As DataTable = SQLCalistir( _
                "SELECT nLogID, nAliciID, sBaslik, sMesaj, sKanal, dteOlusturma, dteTeslimTarihi, " & _
                "(SELECT ISNULL(PERSONELADI, 'Bilinmiyor') FROM APERSONEL WHERE IND = l.nAliciID) AS sAliciAdi " & _
                "FROM tbBildirimLog l " & _
                "WHERE bTeslimEdildi = 1 AND bOkundu = 0 " & _
                "AND dteTeslimTarihi < DATEADD(HOUR, -" & nTakipSureSaat & ", GETDATE()) " & _
                "ORDER BY dteTeslimTarihi DESC")
            
            Dim nTeslimEdilmeyenSayi As Integer = dtTeslimEdilmeyen.Rows.Count
            Dim nOkunmayanSayi As Integer = dtOkunmayan.Rows.Count
            
            If nTeslimEdilmeyenSayi = 0 AndAlso nOkunmayanSayi = 0 Then
                ' Sorun yok, gunluk kontrol tamamlandi olarak isaretle
                BildirimGonderildiKaydet("TESLIM_KONTROL_GUNLUK", DateTime.Now.ToString("yyyyMMdd"))
                Debug.WriteLine("Teslim edilmeyen/okunmayan bildirim yok.")
                Exit Sub
            End If
            
            ' Rapor mesaji olustur
            Dim sbMesaj As New StringBuilder()
            sbMesaj.AppendLine("BILDIRIM TAKIP RAPORU")
            sbMesaj.AppendLine("=====================")
            sbMesaj.AppendLine("Kontrol Tarihi: " & DateTime.Now.ToString("dd.MM.yyyy HH:mm"))
            sbMesaj.AppendLine("Takip Suresi: " & nTakipSureSaat & " saat")
            sbMesaj.AppendLine("")
            
            If nTeslimEdilmeyenSayi > 0 Then
                sbMesaj.AppendLine("*** TESLIM EDILMEYEN BILDIRIMLER: " & nTeslimEdilmeyenSayi & " adet ***")
                sbMesaj.AppendLine("")
                Dim nSayac As Integer = 0
                For Each dr As DataRow In dtTeslimEdilmeyen.Rows
                    nSayac += 1
                    If nSayac > 10 Then
                        sbMesaj.AppendLine("... ve " & (nTeslimEdilmeyenSayi - 10) & " bildirim daha")
                        Exit For
                    End If
                    sbMesaj.AppendLine(nSayac & ". " & dr("sAliciAdi").ToString() & " - " & dr("sKanal").ToString())
                    sbMesaj.AppendLine("   Baslik: " & dr("sBaslik").ToString())
                    sbMesaj.AppendLine("   Tarih: " & Convert.ToDateTime(dr("dteOlusturma")).ToString("dd.MM.yyyy HH:mm"))
                    sbMesaj.AppendLine("")
                Next
            End If
            
            If nOkunmayanSayi > 0 Then
                sbMesaj.AppendLine("*** OKUNMAYAN BILDIRIMLER: " & nOkunmayanSayi & " adet ***")
                sbMesaj.AppendLine("")
                Dim nSayac As Integer = 0
                For Each dr As DataRow In dtOkunmayan.Rows
                    nSayac += 1
                    If nSayac > 10 Then
                        sbMesaj.AppendLine("... ve " & (nOkunmayanSayi - 10) & " bildirim daha")
                        Exit For
                    End If
                    sbMesaj.AppendLine(nSayac & ". " & dr("sAliciAdi").ToString() & " - " & dr("sKanal").ToString())
                    sbMesaj.AppendLine("   Baslik: " & dr("sBaslik").ToString())
                    sbMesaj.AppendLine("   Teslim: " & Convert.ToDateTime(dr("dteTeslimTarihi")).ToString("dd.MM.yyyy HH:mm"))
                    sbMesaj.AppendLine("")
                Next
            End If
            
            ' Bildirim gonder
            If nSorumluID > 0 Then
                ' Secilen sorumluya gonder
                Gonder("BILDIRIM_TAKIP_RAPORU", sbMesaj.ToString(), nSorumluID, "Bildirim Takip Raporu")
            Else
                ' Adminlere (yoneticilere) gonder
                YoneticilereGonder(sbMesaj.ToString(), "Bildirim Takip Raporu")
            End If
            
            ' Gunluk kontrol tamamlandi olarak isaretle
            BildirimGonderildiKaydet("TESLIM_KONTROL_GUNLUK", DateTime.Now.ToString("yyyyMMdd"))
            
            Debug.WriteLine("Teslim edilmeyen/okunmayan bildirim kontrolu tamamlandi. Teslim edilmeyen: " & nTeslimEdilmeyenSayi & ", Okunmayan: " & nOkunmayanSayi)
            
        Catch ex As Exception
            Debug.WriteLine("TeslimEdilmeyenBildirimleriKontrolEt Hata: " & ex.Message)
        End Try
    End Sub
    
    ''' <summary>
    ''' Belirli bir kullanicinin teslim edilmeyen bildirimlerini listeler
    ''' </summary>
    Public Function KullanicininTeslimEdilmeyenBildirimleri(ByVal nKullaniciID As Integer) As DataTable
        Try
            Return SQLCalistir( _
                "SELECT nLogID, sBaslik, sMesaj, sKanal, dteOlusturma " & _
                "FROM tbBildirimLog " & _
                "WHERE nAliciID = " & nKullaniciID & " " & _
                "AND bTeslimEdildi = 0 " & _
                "ORDER BY dteOlusturma DESC")
        Catch ex As Exception
            Debug.WriteLine("KullanicininTeslimEdilmeyenBildirimleri Hata: " & ex.Message)
            Return New DataTable()
        End Try
    End Function
    
    ''' <summary>
    ''' Teslim edilmeyen bildirim sayisini dondurur (sistem geneli)
    ''' </summary>
    Public Function TeslimEdilmeyenBildirimSayisi(Optional ByVal nSaatOnce As Integer = 24) As Integer
        Try
            Dim dt As DataTable = SQLCalistir( _
                "SELECT COUNT(*) AS Sayi FROM tbBildirimLog " & _
                "WHERE bTeslimEdildi = 0 " & _
                "AND dteOlusturma < DATEADD(HOUR, -" & nSaatOnce & ", GETDATE()) " & _
                "AND sKanal IN ('EMAIL', 'SMS', 'WhatsApp')")
            If dt.Rows.Count > 0 Then Return Convert.ToInt32(dt.Rows(0)("Sayi"))
        Catch
        End Try
        Return 0
    End Function
    
    ''' <summary>
    ''' Okunmayan bildirim sayisini dondurur (sistem geneli)
    ''' </summary>
    Public Function OkunmayanBildirimSayisiSistem(Optional ByVal nSaatOnce As Integer = 24) As Integer
        Try
            Dim dt As DataTable = SQLCalistir( _
                "SELECT COUNT(*) AS Sayi FROM tbBildirimLog " & _
                "WHERE bTeslimEdildi = 1 AND bOkundu = 0 " & _
                "AND dteTeslimTarihi < DATEADD(HOUR, -" & nSaatOnce & ", GETDATE())")
            If dt.Rows.Count > 0 Then Return Convert.ToInt32(dt.Rows(0)("Sayi"))
        Catch
        End Try
        Return 0
    End Function
    
    ''' <summary>
    ''' Bildirim takip sorumlusunu ayarlar
    ''' </summary>
    Public Sub BildirimTakipSorumlusuAyarla(ByVal nPersonelID As Integer)
        Try
            SQLCalistirNonQuery("UPDATE tbSistemAyar SET sAyarDeger = '" & nPersonelID & "' WHERE sAyarKodu = 'BILDIRIM_TAKIP_SORUMLUSU_ID'")
        Catch ex As Exception
            Debug.WriteLine("BildirimTakipSorumlusuAyarla Hata: " & ex.Message)
        End Try
    End Sub
    
    ''' <summary>
    ''' Bildirim takip suresini ayarlar (saat cinsinden)
    ''' </summary>
    Public Sub BildirimTakipSuresiAyarla(ByVal nSaat As Integer)
        Try
            SQLCalistirNonQuery("UPDATE tbSistemAyar SET sAyarDeger = '" & nSaat & "' WHERE sAyarKodu = 'BILDIRIM_TAKIP_SURESI_SAAT'")
        Catch ex As Exception
            Debug.WriteLine("BildirimTakipSuresiAyarla Hata: " & ex.Message)
        End Try
    End Sub
    
    ''' <summary>
    ''' Vadesi yaklasan cek/senetleri kontrol eder ve bildirim gonderir
    ''' Uygulama acilisinda veya gunluk olarak calistirilabilir
    ''' AYNI GUN ICINDE TEKRAR GONDERMEZ (tbBildirimGonderimKontrol tablosu ile)
    ''' </summary>
    Public Sub VadeKontrolEtVeBildir()
        Try
            ' Bugun zaten vade kontrolu yapilmis mi?
            If BildirimGonderilmisMi("VADE_KONTROL_GUNLUK", DateTime.Now.ToString("yyyyMMdd")) Then
                Debug.WriteLine("Vade kontrolu bugun zaten yapilmis, atlaniyor.")
                Exit Sub
            End If
            
            ' Kac gun onceden uyarilacak
            Dim nUyariGun As Integer = 7
            Try
                Dim dtAyar As DataTable = SQLCalistir("SELECT sAyarDeger FROM tbSistemAyar WHERE sAyarKodu = 'VADE_UYARI_GUN'")
                If dtAyar.Rows.Count > 0 Then Integer.TryParse(dtAyar.Rows(0)("sAyarDeger").ToString(), nUyariGun)
            Catch
            End Try
            
            ' Vadesi yaklasan cek/senetleri bul (tbCekSenet tablosundan)
            Dim dtVadeler As DataTable = SQLCalistir("SELECT sEvrakNo, sTipi, dteVadeTarihi, lTutar, sFirmaAdi FROM tbCekSenet WHERE dteVadeTarihi BETWEEN GETDATE() AND DATEADD(DAY, " & nUyariGun & ", GETDATE()) AND sDurum = 'Portfoyde' ORDER BY dteVadeTarihi")
            
            Dim nGonderilenSayi As Integer = 0
            For Each dr As DataRow In dtVadeler.Rows
                Dim sTip As String = If(dr("sTipi") IsNot DBNull.Value, dr("sTipi").ToString(), "Cek")
                Dim sEvrakNo As String = If(dr("sEvrakNo") IsNot DBNull.Value, dr("sEvrakNo").ToString(), "")
                Dim dteVade As DateTime = If(dr("dteVadeTarihi") IsNot DBNull.Value, Convert.ToDateTime(dr("dteVadeTarihi")), DateTime.Now)
                Dim lTutar As Decimal = If(dr("lTutar") IsNot DBNull.Value, Convert.ToDecimal(dr("lTutar")), 0)
                Dim sFirma As String = If(dr("sFirmaAdi") IsNot DBNull.Value, dr("sFirmaAdi").ToString(), "")
                
                ' Bu cek/senet icin bugun bildirim gonderilmis mi?
                Dim sRefID As String = sTip & "_" & sEvrakNo
                If Not BildirimGonderilmisMi("VADE_YAKLASTI", sRefID) Then
                    VadeYaklastiBildirimiGonder(sTip, sEvrakNo & " - " & sFirma, dteVade, lTutar)
                    BildirimGonderildiKaydet("VADE_YAKLASTI", sRefID)
                    nGonderilenSayi += 1
                End If
            Next
            
            ' Gunluk kontrol yapildi olarak isaretle
            BildirimGonderildiKaydet("VADE_KONTROL_GUNLUK", DateTime.Now.ToString("yyyyMMdd"))
            
            Debug.WriteLine("Vade kontrolu tamamlandi. " & nGonderilenSayi & " bildirim gonderildi.")
        Catch ex As Exception
            Debug.WriteLine("BildirimServisi.VadeKontrolEtVeBildir Hata: " & ex.Message)
        End Try
    End Sub
    
    ''' <summary>
    ''' Yuksek tutarli nakit islem bildirimi (Detayli format)
    ''' </summary>
    Public Sub YuksekNakitIslemBildirimiGonder(ByVal lTutar As Decimal, ByVal sIslemTipi As String, ByVal sKullaniciAdi As String)
        Try
            Dim sMesaj As String = "YUKSEK TUTARLI NAKIT ISLEM" & vbCrLf & vbCrLf & _
                "Tutar: " & lTutar.ToString("N2") & " TL" & vbCrLf & _
                "Islem Tipi: " & sIslemTipi & vbCrLf & _
                "Kullanici: " & sKullaniciAdi & vbCrLf & _
                "Tarih: " & DateTime.Now.ToString("dd.MM.yyyy HH:mm")
            YoneticilereGonder(sMesaj, "Yuksek Nakit Islem Uyarisi")
        Catch ex As Exception
            Debug.WriteLine("BildirimServisi.YuksekNakitIslemBildirimiGonder Hata: " & ex.Message)
        End Try
    End Sub
    
    ' =============================================
    ' E-TICARET BILDIRIMLERI
    ' =============================================
    
    ''' <summary>
    ''' E-ticaret yeni siparis bildirimi (Detayli urun bilgileri ile)
    ''' </summary>
    Public Sub ETicaretSiparisBildirimiGonder(ByVal sSiparisNo As String, ByVal sMusteriAdi As String, ByVal lTutar As Decimal)
        Try
            ' Mesaj basligini olustur
            Dim sbMesaj As New StringBuilder()
            sbMesaj.AppendLine("YENI E-TICARET SIPARISI")
            sbMesaj.AppendLine("========================")
            sbMesaj.AppendLine("Siparis No: " & sSiparisNo)
            sbMesaj.AppendLine("Musteri: " & sMusteriAdi)
            sbMesaj.AppendLine("Tarih: " & DateTime.Now.ToString("dd.MM.yyyy HH:mm"))
            sbMesaj.AppendLine("")
            
            ' Siparis detaylarini al (tbEticaretSiparis veya benzeri tablodan)
            ' Siparis ID'sini bul
            Dim dtSiparis As DataTable = SQLCalistir("SELECT nSiparisID FROM tbEticaretSiparis WHERE sSiparisNo = '" & sSiparisNo.Replace("'", "''") & "'")
            
            If dtSiparis.Rows.Count > 0 Then
                Dim nSiparisID As Integer = Convert.ToInt32(dtSiparis.Rows(0)("nSiparisID"))
                
                ' Siparis kalemlerini al (Stok bilgileri ile birlikte)
                Dim dtKalemler As DataTable = SQLCalistir( _
                    "SELECT " & _
                    "d.nMiktar, " & _
                    "d.lBirimFiyat, " & _
                    "d.lToplam, " & _
                    "s.sKodu AS sStokKodu, " & _
                    "s.sAciklama AS sStokAdi, " & _
                    "ISNULL(s.sRenk, '') AS sRenk, " & _
                    "ISNULL(s.sBeden, '') AS sBeden, " & _
                    "ISNULL(s.sKavala, '') AS sKavala " & _
                    "FROM tbEticaretSiparisDetay d " & _
                    "INNER JOIN tbStok s ON d.nStokID = s.nStokID " & _
                    "WHERE d.nSiparisID = " & nSiparisID & " " & _
                    "ORDER BY d.nSiraNo")
                
                If dtKalemler.Rows.Count > 0 Then
                    sbMesaj.AppendLine("URUNLER:")
                    sbMesaj.AppendLine("--------")
                    
                    Dim nSira As Integer = 0
                    For Each dr As DataRow In dtKalemler.Rows
                        nSira += 1
                        
                        Dim sStokKodu As String = If(dr("sStokKodu") IsNot DBNull.Value, dr("sStokKodu").ToString(), "")
                        Dim sStokAdi As String = If(dr("sStokAdi") IsNot DBNull.Value, dr("sStokAdi").ToString(), "")
                        Dim sRenk As String = If(dr("sRenk") IsNot DBNull.Value, dr("sRenk").ToString().Trim(), "")
                        Dim sBeden As String = If(dr("sBeden") IsNot DBNull.Value, dr("sBeden").ToString().Trim(), "")
                        Dim sKavala As String = If(dr("sKavala") IsNot DBNull.Value, dr("sKavala").ToString().Trim(), "")
                        Dim nMiktar As Decimal = If(dr("nMiktar") IsNot DBNull.Value, Convert.ToDecimal(dr("nMiktar")), 0)
                        Dim lBirimFiyat As Decimal = If(dr("lBirimFiyat") IsNot DBNull.Value, Convert.ToDecimal(dr("lBirimFiyat")), 0)
                        Dim lToplam As Decimal = If(dr("lToplam") IsNot DBNull.Value, Convert.ToDecimal(dr("lToplam")), 0)
                        
                        ' Urun satiri
                        sbMesaj.AppendLine(nSira.ToString() & ". " & sStokKodu & " - " & sStokAdi)
                        
                        ' Varyant bilgileri varsa ekle
                        Dim sVaryant As String = ""
                        If sRenk <> "" Then sVaryant = "Renk: " & sRenk
                        If sBeden <> "" Then
                            If sVaryant <> "" Then sVaryant &= ", "
                            sVaryant &= "Beden: " & sBeden
                        End If
                        If sKavala <> "" Then
                            If sVaryant <> "" Then sVaryant &= ", "
                            sVaryant &= "Kavala: " & sKavala
                        End If
                        
                        If sVaryant <> "" Then
                            sbMesaj.AppendLine("   " & sVaryant)
                        End If
                        
                        sbMesaj.AppendLine("   Miktar: " & nMiktar.ToString("N0") & " | Birim: " & lBirimFiyat.ToString("N2") & " TL | Toplam: " & lToplam.ToString("N2") & " TL")
                        sbMesaj.AppendLine("")
                    Next
                End If
            Else
                ' Siparis detaylari bulunamazsa basit mesaj
                sbMesaj.AppendLine("URUNLER:")
                sbMesaj.AppendLine("(Detay bilgisi alinamadi)")
                sbMesaj.AppendLine("")
            End If
            
            ' Toplam tutar
            sbMesaj.AppendLine("========================")
            sbMesaj.AppendLine("TOPLAM TUTAR: " & lTutar.ToString("N2") & " TL")
            
            Broadcast("ETICARET_YENI_SIPARIS", sbMesaj.ToString(), "E-Ticaret Siparis")
        Catch ex As Exception
            ' Hata durumunda basit mesaj gonder
            Try
                Dim sMesajBasit As String = "YENI E-TICARET SIPARISI" & vbCrLf & "Siparis No: " & sSiparisNo & vbCrLf & "Musteri: " & sMusteriAdi & vbCrLf & "Tutar: " & lTutar.ToString("N2") & " TL" & vbCrLf & vbCrLf & "(Detay bilgisi alinamadi)"
                Broadcast("ETICARET_YENI_SIPARIS", sMesajBasit, "E-Ticaret Siparis")
            Catch
            End Try
            Debug.WriteLine("BildirimServisi.ETicaretSiparisBildirimiGonder Hata: " & ex.Message)
        End Try
    End Sub
    
    ''' <summary>
    ''' E-ticaret yeni siparis bildirimi - Dogrudan WhatsApp ile gonderir
    ''' tbKullaniciBildirimTercihleri tablosunda ETICARET_YENI_SIPARIS icin WhatsApp aktif olan personellere gonderir
    ''' </summary>
    Public Sub ETicaretSiparisWhatsAppBildirimi(ByVal sSiparisNo As String, ByVal sMusteriAdi As String, ByVal lTutar As Decimal)
        Try
            Console.WriteLine("ETicaretSiparisWhatsAppBildirimi: Baslatiliyor - Siparis: " & sSiparisNo)
            
            ' WhatsApp aktif mi kontrol et
            Dim whatsappAktif As String = SistemAyarGetir("WHATSAPP_AKTIF")
            Console.WriteLine("ETicaretSiparisWhatsAppBildirimi: WHATSAPP_AKTIF = " & whatsappAktif)
            
            If whatsappAktif <> "1" Then
                Console.WriteLine("ETicaretSiparisWhatsAppBildirimi: WhatsApp aktif degil! WHATSAPP_AKTIF = " & whatsappAktif)
                Exit Sub
            End If
            
            ' UltraMsg ayarlarini kontrol et
            Dim sInstanceID As String = SistemAyarGetir("ULTRAMSG_INSTANCE_ID")
            Dim sToken As String = SistemAyarGetir("ULTRAMSG_TOKEN")
            
            Console.WriteLine("ETicaretSiparisWhatsAppBildirimi: InstanceID = " & sInstanceID & ", Token = " & If(String.IsNullOrEmpty(sToken), "BOŞ", "***"))
            
            If String.IsNullOrEmpty(sInstanceID) OrElse String.IsNullOrEmpty(sToken) Then
                Console.WriteLine("ETicaretSiparisWhatsAppBildirimi: UltraMsg ayarlari eksik!")
                Exit Sub
            End If
            
            ' Bildirim mesajini olustur
            Dim sMesaj As String = "YENI E-TICARET SIPARISI" & vbCrLf & _
                "========================" & vbCrLf & _
                "Siparis No: " & sSiparisNo & vbCrLf & _
                "Musteri: " & sMusteriAdi & vbCrLf & _
                "Tutar: " & lTutar.ToString("N2") & " TL" & vbCrLf & _
                "Tarih: " & DateTime.Now.ToString("dd.MM.yyyy HH:mm") & vbCrLf & _
                "========================" & vbCrLf & _
                "Siparis sisteme kaydedildi."
            
            ' ETICARET_YENI_SIPARIS bildirimi icin WhatsApp aktif olan personelleri bul
            ' tbKullaniciBildirimTercihleri tablosundan kontrol et
            Console.WriteLine("ETicaretSiparisWhatsAppBildirimi: Personel sorgusu calistiriliyor...")
            
            Dim dtPersoneller As DataTable = SQLCalistir( _
                "SELECT DISTINCT p.IND, p.PERSONELADI, ISNULL(p.TELEFON1,'') AS Telefon " & _
                "FROM APERSONEL p " & _
                "INNER JOIN tbKullaniciBildirimTercihleri t ON p.IND = t.nKullaniciID " & _
                "INNER JOIN tbBildirimTipleri bt ON t.nTipID = bt.nTipID " & _
                "WHERE p.AKTIF = 1 " & _
                "AND bt.sTipKodu = 'ETICARET_YENI_SIPARIS' " & _
                "AND t.bWhatsAppAktif = 1 " & _
                "AND ISNULL(p.TELEFON1, '') <> ''")
            
            Console.WriteLine("ETicaretSiparisWhatsAppBildirimi: Tercihler sorgu sonucu = " & If(dtPersoneller IsNot Nothing, dtPersoneller.Rows.Count.ToString(), "NULL"))
            
            If dtPersoneller Is Nothing OrElse dtPersoneller.Rows.Count = 0 Then
                ' Tercihler tablosunda kayit yoksa, varsayilan olarak bWhatsAppBildirimAl = 1 olanlara gonder
                Console.WriteLine("ETicaretSiparisWhatsAppBildirimi: Tercihler tablosunda kayit yok, APERSONEL kontrolu yapiliyor...")
                dtPersoneller = SQLCalistir( _
                    "SELECT IND, PERSONELADI, ISNULL(TELEFON1,'') AS Telefon " & _
                    "FROM APERSONEL " & _
                    "WHERE AKTIF = 1 AND ISNULL(bWhatsAppBildirimAl, 0) = 1 AND ISNULL(TELEFON1, '') <> ''")
                    
                Console.WriteLine("ETicaretSiparisWhatsAppBildirimi: APERSONEL sorgu sonucu = " & If(dtPersoneller IsNot Nothing, dtPersoneller.Rows.Count.ToString(), "NULL"))
            End If
            
            If dtPersoneller Is Nothing OrElse dtPersoneller.Rows.Count = 0 Then
                Console.WriteLine("ETicaretSiparisWhatsAppBildirimi: WhatsApp bildirimi alacak personel bulunamadi!")
                Exit Sub
            End If
            
            Console.WriteLine("ETicaretSiparisWhatsAppBildirimi: " & dtPersoneller.Rows.Count & " personele bildirim gonderilecek")
            
            ' Her personele WhatsApp gonder
            Dim gonderildi As Integer = 0
            For Each dr As DataRow In dtPersoneller.Rows
                Try
                    Dim sTelefon As String = dr("Telefon").ToString().Trim()
                    Dim sPersonelAdi As String = dr("PERSONELADI").ToString()
                    
                    Console.WriteLine("ETicaretSiparisWhatsAppBildirimi: " & sPersonelAdi & " icin gonderiliyor, Tel: " & sTelefon)
                    
                    If Not String.IsNullOrEmpty(sTelefon) Then
                        WhatsAppGonder(sTelefon, sMesaj, 0, Convert.ToInt32(dr("IND")))
                        gonderildi += 1
                        Console.WriteLine("ETicaretSiparisWhatsAppBildirimi: GONDERILDI -> " & sPersonelAdi & " (" & sTelefon & ")")
                    Else
                        Console.WriteLine("ETicaretSiparisWhatsAppBildirimi: Telefon bos, atlanıyor: " & sPersonelAdi)
                    End If
                Catch pEx As Exception
                    Console.WriteLine("ETicaretSiparisWhatsAppBildirimi Personel Hata: " & pEx.Message)
                End Try
            Next
            
            Console.WriteLine("ETicaretSiparisWhatsAppBildirimi: Toplam " & gonderildi & " kisiye bildirim gonderildi")
            
        Catch ex As Exception
            Console.WriteLine("ETicaretSiparisWhatsAppBildirimi HATA: " & ex.Message)
        End Try
    End Sub
    
    ''' <summary>
    ''' E-ticaret yeni siparis bildirimi - Detayli versiyon (urun bilgileri dahil)
    ''' </summary>
    Public Sub ETicaretSiparisWhatsAppBildirimiDetayli(ByVal sSiparisNo As String, ByVal sMusteriAdi As String, ByVal lTutar As Decimal, ByVal sUrunDetaylari As String)
        Try
            ' WhatsApp aktif mi kontrol et
            Dim whatsappAktif As String = SistemAyarGetir("WHATSAPP_AKTIF")
            If whatsappAktif <> "1" Then
                Exit Sub
            End If
            
            ' UltraMsg ayarlarini kontrol et
            Dim sInstanceID As String = SistemAyarGetir("ULTRAMSG_INSTANCE_ID").Trim()
            Dim sToken As String = SistemAyarGetir("ULTRAMSG_TOKEN").Trim()
            
            If String.IsNullOrEmpty(sInstanceID) OrElse String.IsNullOrEmpty(sToken) Then
                Exit Sub
            End If
            
            ' Detayli bildirim mesajini olustur
            Dim sMesaj As String = "🛒 *YENİ E-TİCARET SİPARİŞİ*" & vbCrLf & _
                "================================" & vbCrLf & _
                "📋 *Sipariş No:* " & sSiparisNo & vbCrLf & _
                "👤 *Müşteri:* " & sMusteriAdi & vbCrLf & _
                "💰 *Toplam Tutar:* " & lTutar.ToString("N2") & " TL" & vbCrLf & _
                "📅 *Tarih:* " & DateTime.Now.ToString("dd.MM.yyyy HH:mm") & vbCrLf & _
                sUrunDetaylari & vbCrLf & _
                "================================" & vbCrLf & _
                "✅ Sipariş sisteme kaydedildi."
            
            ' WhatsApp bildirimi almak isteyen personelleri bul
            Dim dtPersoneller As DataTable = SQLCalistir( _
                "SELECT DISTINCT p.IND, p.PERSONELADI, ISNULL(p.TELEFON1,'') AS Telefon " & _
                "FROM APERSONEL p " & _
                "INNER JOIN tbKullaniciBildirimTercihleri t ON p.IND = t.nKullaniciID " & _
                "INNER JOIN tbBildirimTipleri bt ON t.nTipID = bt.nTipID " & _
                "WHERE p.AKTIF = 1 " & _
                "AND bt.sTipKodu = 'ETICARET_YENI_SIPARIS' " & _
                "AND t.bWhatsAppAktif = 1 " & _
                "AND ISNULL(p.TELEFON1, '') <> ''")
            
            If dtPersoneller Is Nothing OrElse dtPersoneller.Rows.Count = 0 Then
                dtPersoneller = SQLCalistir( _
                    "SELECT IND, PERSONELADI, ISNULL(TELEFON1,'') AS Telefon " & _
                    "FROM APERSONEL " & _
                    "WHERE AKTIF = 1 AND ISNULL(bWhatsAppBildirimAl, 0) = 1 AND ISNULL(TELEFON1, '') <> ''")
            End If
            
            If dtPersoneller Is Nothing OrElse dtPersoneller.Rows.Count = 0 Then
                Exit Sub
            End If
            
            ' Her personele WhatsApp gonder
            For Each dr As DataRow In dtPersoneller.Rows
                Try
                    Dim sTelefon As String = dr("Telefon").ToString().Trim()
                    If Not String.IsNullOrEmpty(sTelefon) Then
                        WhatsAppGonder(sTelefon, sMesaj, 0, Convert.ToInt32(dr("IND")))
                    End If
                Catch pEx As Exception
                End Try
            Next
            
        Catch ex As Exception
        End Try
    End Sub
    
    ' =============================================
    ' BELGE SILME BILDIRIMLERI
    ' =============================================
    
    ''' <summary>
    ''' Belge silindi bildirimi
    ''' </summary>
    Public Sub BelgeSilindiBildirimiGonder(ByVal sBelgeTipi As String, ByVal sEvrakNo As String, ByVal sSilenKullanici As String)
        Try
            Dim sMesaj As String = sBelgeTipi.ToUpper() & " SILINDI" & vbCrLf & "Evrak No: " & sEvrakNo & vbCrLf & "Silen: " & sSilenKullanici & vbCrLf & "Tarih: " & DateTime.Now.ToString("dd.MM.yyyy HH:mm")
            Dim sTipKodu As String = sBelgeTipi.ToUpper().Replace(" ", "_") & "_SILINDI"
            YoneticilereGonder(sMesaj, sBelgeTipi & " Silindi")
        Catch ex As Exception
            Debug.WriteLine("BildirimServisi.BelgeSilindiBildirimiGonder Hata: " & ex.Message)
        End Try
    End Sub
    
    ' =============================================
    ' GOREV BILDIRIMLERI
    ' =============================================
    
    ''' <summary>
    ''' Yeni gorev olusturuldu bildirimi
    ''' </summary>
    Public Sub GorevOlusturuldBildirimiGonder(ByVal nGorevID As Integer, ByVal sGorevKonusu As String, ByVal nAtananKisi As Integer, ByVal sAtayan As String)
        Try
            Dim sMesaj As String = "YENI GOREV ATANDI" & vbCrLf & vbCrLf & "Konu: " & sGorevKonusu & vbCrLf & "Atayan: " & sAtayan & vbCrLf & "Tarih: " & DateTime.Now.ToString("dd.MM.yyyy HH:mm")
            Gonder("GOREV_OLUSTURULDU", sMesaj, nAtananKisi, "Yeni Gorev")
        Catch ex As Exception
            Debug.WriteLine("BildirimServisi.GorevOlusturuldBildirimiGonder Hata: " & ex.Message)
        End Try
    End Sub
    
    ''' <summary>
    ''' Gorev tamamlandi bildirimi
    ''' </summary>
    Public Sub GorevTamamlandiBildirimiGonder(ByVal nGorevID As Integer, ByVal sGorevKonusu As String, ByVal nAtayanID As Integer, ByVal sTamamlayan As String)
        Try
            Dim sMesaj As String = "GOREV TAMAMLANDI" & vbCrLf & vbCrLf & "Konu: " & sGorevKonusu & vbCrLf & "Tamamlayan: " & sTamamlayan & vbCrLf & "Tarih: " & DateTime.Now.ToString("dd.MM.yyyy HH:mm")
            Gonder("GOREV_TAMAMLANDI", sMesaj, nAtayanID, "Gorev Tamamlandi")
        Catch ex As Exception
            Debug.WriteLine("BildirimServisi.GorevTamamlandiBildirimiGonder Hata: " & ex.Message)
        End Try
    End Sub
    
    ' =============================================
    ' STOK VE FIYAT BILDIRIMLERI
    ' =============================================
    
    ''' <summary>
    ''' Maliyet alti satis bildirimi
    ''' </summary>
    Public Sub MaliyetAltiSatisBildirimiGonder(ByVal sStokKodu As String, ByVal sStokAdi As String, ByVal lMaliyet As Decimal, ByVal lSatisFiyati As Decimal, ByVal sKullanici As String, ByVal sEvrakNo As String)
        Try
            Dim sMesaj As String = "MALIYET ALTI SATIS!" & vbCrLf & vbCrLf & "Stok: " & sStokKodu & " - " & sStokAdi & vbCrLf & "Maliyet: " & lMaliyet.ToString("N2") & " TL" & vbCrLf & "Satis Fiyati: " & lSatisFiyati.ToString("N2") & " TL" & vbCrLf & "Zarar: " & (lMaliyet - lSatisFiyati).ToString("N2") & " TL" & vbCrLf & "Evrak No: " & sEvrakNo & vbCrLf & "Kullanici: " & sKullanici
            YoneticilereGonder(sMesaj, "Maliyet Alti Satis Uyarisi")
        Catch ex As Exception
            Debug.WriteLine("BildirimServisi.MaliyetAltiSatisBildirimiGonder Hata: " & ex.Message)
        End Try
    End Sub
    
    ''' <summary>
    ''' Satis isleminde maliyet kontrolu yapar, maliyet altiysa bildirim gonderir
    ''' nStokID ve lSatisFiyati verilerek cagrilir
    ''' </summary>
    Public Function MaliyetKontrolEt(ByVal nStokID As Integer, ByVal lSatisFiyati As Decimal, ByVal sEvrakNo As String, ByVal sKullanici As String) As Boolean
        Try
            ' Maliyet fiyatini al
            Dim dtMaliyet As DataTable = SQLCalistir("SELECT s.sKodu, s.sAciklama, ISNULL(f.lFiyat, 0) AS lMaliyet FROM tbStok s LEFT JOIN tbStokFiyati f ON s.nStokID = f.nStokID AND f.sFiyatTipi = 'M' WHERE s.nStokID = " & nStokID)
            
            If dtMaliyet.Rows.Count > 0 Then
                Dim lMaliyet As Decimal = Convert.ToDecimal(dtMaliyet.Rows(0)("lMaliyet"))
                
                If lMaliyet > 0 AndAlso lSatisFiyati < lMaliyet Then
                    Dim sStokKodu As String = dtMaliyet.Rows(0)("sKodu").ToString()
                    Dim sStokAdi As String = dtMaliyet.Rows(0)("sAciklama").ToString()
                    
                    MaliyetAltiSatisBildirimiGonder(sStokKodu, sStokAdi, lMaliyet, lSatisFiyati, sKullanici, sEvrakNo)
                    Return True ' Maliyet alti satis var
                End If
            End If
        Catch ex As Exception
            Debug.WriteLine("BildirimServisi.MaliyetKontrolEt Hata: " & ex.Message)
        End Try
        Return False
    End Function
    
    ''' <summary>
    ''' Kritik stok seviyesindeki urunleri kontrol eder
    ''' AYNI GUN ICINDE TEKRAR GONDERMEZ
    ''' </summary>
    Public Sub KritikStokKontrolEtVeBildir()
        Try
            ' Bugun zaten kritik stok kontrolu yapilmis mi?
            If BildirimGonderilmisMi("KRITIK_STOK_GUNLUK", DateTime.Now.ToString("yyyyMMdd")) Then
                Debug.WriteLine("Kritik stok kontrolu bugun zaten yapilmis, atlaniyor.")
                Exit Sub
            End If
            
            ' Minimum stok seviyesinin altindaki urunleri bul
            Dim dtKritik As DataTable = SQLCalistir("SELECT s.nStokID, s.sKodu, s.sAciklama, s.lMinimumStok, (SELECT ISNULL(SUM(lGirisMiktar1),0) - ISNULL(SUM(lCikisMiktar1),0) FROM tbStokFisiDetayi WHERE nStokID = s.nStokID) AS lMevcutStok FROM tbStok s WHERE s.lMinimumStok > 0 AND (SELECT ISNULL(SUM(lGirisMiktar1),0) - ISNULL(SUM(lCikisMiktar1),0) FROM tbStokFisiDetayi WHERE nStokID = s.nStokID) < s.lMinimumStok AND s.bAktif = 1")
            
            Dim nGonderilenSayi As Integer = 0
            For Each dr As DataRow In dtKritik.Rows
                Dim nStokID As Integer = Convert.ToInt32(dr("nStokID"))
                Dim sStokKodu As String = dr("sKodu").ToString()
                Dim sStokAdi As String = dr("sAciklama").ToString()
                Dim lMevcut As Decimal = Convert.ToDecimal(dr("lMevcutStok"))
                Dim lMinimum As Decimal = Convert.ToDecimal(dr("lMinimumStok"))
                
                ' Bu stok icin bugun bildirim gonderilmis mi?
                Dim sRefID As String = "STOK_" & nStokID.ToString()
                If Not BildirimGonderilmisMi("KRITIK_STOK", sRefID) Then
                    KritikStokBildirimiGonder(sStokKodu, sStokAdi, lMevcut, lMinimum)
                    BildirimGonderildiKaydet("KRITIK_STOK", sRefID)
                    nGonderilenSayi += 1
                End If
            Next
            
            ' Gunluk kontrol yapildi olarak isaretle
            BildirimGonderildiKaydet("KRITIK_STOK_GUNLUK", DateTime.Now.ToString("yyyyMMdd"))
            
            Debug.WriteLine("Kritik stok kontrolu tamamlandi. " & nGonderilenSayi & " bildirim gonderildi.")
        Catch ex As Exception
            Debug.WriteLine("BildirimServisi.KritikStokKontrolEtVeBildir Hata: " & ex.Message)
        End Try
    End Sub
    
    ''' <summary>
    ''' Uygulama acilisinda tum kontrolleri yapar
    ''' Form1_Load icerisinden cagrilabilir
    ''' </summary>
    Public Sub UygulamaAcilisKontrolleri()
        Try
            ' Vade kontrol
            VadeKontrolEtVeBildir()
            
            ' Kritik stok kontrol (performans icin opsiyonel)
            ' KritikStokKontrolEtVeBildir()
        Catch ex As Exception
            Debug.WriteLine("BildirimServisi.UygulamaAcilisKontrolleri Hata: " & ex.Message)
        End Try
    End Sub
    
    ''' <summary>
    ''' Kritik stok seviyesi bildirimi
    ''' </summary>
    Public Sub KritikStokBildirimiGonder(ByVal sStokKodu As String, ByVal sStokAdi As String, ByVal lMevcutMiktar As Decimal, ByVal lMinimumMiktar As Decimal)
        Try
            Dim sMesaj As String = "KRITIK STOK SEVIYESI" & vbCrLf & vbCrLf & "Stok: " & sStokKodu & " - " & sStokAdi & vbCrLf & "Mevcut: " & lMevcutMiktar.ToString("N2") & vbCrLf & "Minimum: " & lMinimumMiktar.ToString("N2")
            Broadcast("KRITIK_STOK", sMesaj, "Kritik Stok Uyarisi")
        Catch ex As Exception
            Debug.WriteLine("BildirimServisi.KritikStokBildirimiGonder Hata: " & ex.Message)
        End Try
    End Sub
    
    ' =============================================
    ' UYGULAMA ICI BILDIRIM FONKSIYONLARI
    ' =============================================
    
    ''' <summary>
    ''' Okunmamis gorev sayisini dondurur
    ''' </summary>
    Public Function OkunmamisGorevSayisi(ByVal nPersonelID As Integer) As Integer
        Try
            Dim dt As DataTable = SQLCalistir("SELECT COUNT(*) AS Sayi FROM aEmirAjanda WHERE nKimID = " & nPersonelID & " AND ISNULL(OkunduMu, 0) = 0 AND ISNULL(bDurum, 0) = 0")
            If dt.Rows.Count > 0 Then
                Return Convert.ToInt32(dt.Rows(0)("Sayi"))
            End If
        Catch ex As Exception
            Debug.WriteLine("BildirimServisi.OkunmamisGorevSayisi Hata: " & ex.Message)
        End Try
        Return 0
    End Function
    
    ''' <summary>
    ''' Gorevi okundu olarak isaretler
    ''' </summary>
    Public Sub GorevOkunduIsaretle(ByVal nGorevID As Integer)
        Try
            SQLCalistirNonQuery("UPDATE aEmirAjanda SET OkunduMu = 1, OkunmaTarihi = GETDATE() WHERE nID = " & nGorevID)
        Catch ex As Exception
            Debug.WriteLine("BildirimServisi.GorevOkunduIsaretle Hata: " & ex.Message)
        End Try
    End Sub
    
    ''' <summary>
    ''' Bildirimi okundu olarak isaretler
    ''' </summary>
    Public Sub BildirimOkunduIsaretle(ByVal nLogID As Integer)
        Try
            SQLCalistirNonQuery("UPDATE tbBildirimLog SET bOkundu = 1, dteOkunma = GETDATE() WHERE nLogID = " & nLogID)
        Catch ex As Exception
            Debug.WriteLine("BildirimServisi.BildirimOkunduIsaretle Hata: " & ex.Message)
        End Try
    End Sub
    
    ''' <summary>
    ''' Kullanicinin son bildirimlerini getirir
    ''' </summary>
    Public Function SonBildirimleriGetir(ByVal nPersonelID As Integer, Optional ByVal nAdet As Integer = 20) As DataTable
        Try
            Return SQLCalistir("SELECT TOP " & nAdet & " nLogID, sBaslik, sMesaj, sKanal, bOkundu, dteOlusturma FROM tbBildirimLog WHERE nAliciID = " & nPersonelID & " ORDER BY dteOlusturma DESC")
        Catch ex As Exception
            Debug.WriteLine("BildirimServisi.SonBildirimleriGetir Hata: " & ex.Message)
            Return Nothing
        End Try
    End Function
    
    ' =============================================
    ' KANAL BAZLI GONDERIM FONKSIYONLARI (PRIVATE)
    ' =============================================
    
    Private Sub EmailGonder(ByVal sAlici As String, ByVal sKonu As String, ByVal sMesaj As String, ByVal nTipID As Integer, ByVal nAliciID As Integer)
        Try
            ' Sistem ayarlarini kontrol et
            If SistemAyarGetir("EMAIL_AKTIF") <> "1" Then Exit Sub
            
            Dim sHost As String = SistemAyarGetir("EMAIL_SMTP_HOST")
            Dim nPort As Integer = Convert.ToInt32(SistemAyarGetir("EMAIL_SMTP_PORT"))
            Dim sUser As String = SistemAyarGetir("EMAIL_SMTP_USER")
            Dim sPass As String = SistemAyarGetir("EMAIL_SMTP_PASS")
            Dim sFrom As String = SistemAyarGetir("EMAIL_FROM")
            
            If sHost = "" OrElse sUser = "" Then Exit Sub
            
            ' Email gonder
            Using client As New SmtpClient(sHost, nPort)
                client.EnableSsl = True
                client.Credentials = New NetworkCredential(sUser, sPass)
                
                Dim mail As New MailMessage(sFrom, sAlici, sKonu, sMesaj)
                mail.IsBodyHtml = False
                client.Send(mail)
            End Using
            
            ' Log kaydet
            BildirimLogKaydet(nTipID, nAliciID, sAlici, "", sKonu, sMesaj, "Email", "Gonderildi", "")
            
        Catch ex As Exception
            BildirimLogKaydet(nTipID, nAliciID, sAlici, "", sKonu, sMesaj, "Email", "Hata", ex.Message)
            Debug.WriteLine("EmailGonder Hata: " & ex.Message)
        End Try
    End Sub
    
    Private Sub SMSGonder(ByVal sTelefon As String, ByVal sMesaj As String, ByVal nTipID As Integer, ByVal nAliciID As Integer)
        Try
            ' Sistem ayarlarini kontrol et
            If SistemAyarGetir("SMS_AKTIF") <> "1" Then Exit Sub
            
            Dim sApiUrl As String = SistemAyarGetir("SMS_API_URL")
            Dim sApiKey As String = SistemAyarGetir("SMS_API_KEY")
            Dim sSender As String = SistemAyarGetir("SMS_SENDER")
            
            If sApiUrl = "" OrElse sApiKey = "" Then Exit Sub
            
            ' NetGSM API cagir (ornek)
            Dim request As HttpWebRequest = CType(WebRequest.Create(sApiUrl), HttpWebRequest)
            request.Method = "POST"
            request.ContentType = "application/x-www-form-urlencoded"
            
            Dim postData As String = "usercode=" & sApiKey & "&password=" & sApiKey & "&gsmno=" & sTelefon & "&message=" & sMesaj & "&msgheader=" & sSender
            Dim byteArray As Byte() = Encoding.UTF8.GetBytes(postData)
            
            Using dataStream As Stream = request.GetRequestStream()
                dataStream.Write(byteArray, 0, byteArray.Length)
            End Using
            
            Using response As WebResponse = request.GetResponse()
                ' Response islenebilir
            End Using
            
            ' Log kaydet
            BildirimLogKaydet(nTipID, nAliciID, "", sTelefon, "SMS", sMesaj, "SMS", "Gonderildi", "")
            
        Catch ex As Exception
            BildirimLogKaydet(nTipID, nAliciID, "", sTelefon, "SMS", sMesaj, "SMS", "Hata", ex.Message)
            Debug.WriteLine("SMSGonder Hata: " & ex.Message)
        End Try
    End Sub
    
    Private Sub WhatsAppGonder(ByVal sTelefon As String, ByVal sMesaj As String, ByVal nTipID As Integer, ByVal nAliciID As Integer)
        Try
            ' Sistem ayarlarini kontrol et
            Dim whatsappAktif As String = SistemAyarGetir("WHATSAPP_AKTIF")
            If whatsappAktif <> "1" Then
                Exit Sub
            End If
            
            ' UltraMsg API Ayarlari
            Dim sInstanceID As String = SistemAyarGetir("ULTRAMSG_INSTANCE_ID").Trim()
            Dim sToken As String = SistemAyarGetir("ULTRAMSG_TOKEN").Trim()
            
            If sInstanceID = "" OrElse sToken = "" Then
                Exit Sub
            End If
            
            ' Telefon numarasini formatla
            sTelefon = sTelefon.Replace(" ", "").Replace("-", "").Replace("(", "").Replace(")", "").Replace("+", "")
            If Not sTelefon.StartsWith("90") Then
                If sTelefon.StartsWith("0") Then
                    sTelefon = "9" & sTelefon
                Else
                    sTelefon = "90" & sTelefon
                End If
            End If
            
            ' UltraMsg API - Token URL'de GET parametresi olarak (Test butonuyla ayni)
            Dim sUrl As String = "https://api.ultramsg.com/" & sInstanceID & "/messages/chat?token=" & sToken
            
            Dim request As HttpWebRequest = CType(WebRequest.Create(sUrl), HttpWebRequest)
            request.Method = "POST"
            request.ContentType = "application/x-www-form-urlencoded"
            request.Timeout = 30000
            
            ' POST parametreleri (Test butonuyla ayni format)
            Dim postData As String = "to=" & sTelefon & "&body=" & Uri.EscapeDataString(sMesaj)
            
            Dim byteArray As Byte() = Encoding.UTF8.GetBytes(postData)
            request.ContentLength = byteArray.Length
            
            Using dataStream As Stream = request.GetRequestStream()
                dataStream.Write(byteArray, 0, byteArray.Length)
            End Using
            
            Dim sResponse As String = ""
            Using response As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)
                Using reader As New StreamReader(response.GetResponseStream())
                    sResponse = reader.ReadToEnd()
                End Using
            End Using
            
            ' Basarili gonderim kontrolu
            If sResponse.Contains("""sent""") OrElse sResponse.Contains("""true""") OrElse sResponse.Contains("queued") Then
                BildirimLogKaydet(nTipID, nAliciID, "", sTelefon, "WhatsApp", sMesaj, "WhatsApp", "Gonderildi", "")
            Else
                BildirimLogKaydet(nTipID, nAliciID, "", sTelefon, "WhatsApp", sMesaj, "WhatsApp", "Hata", "API Response: " & sResponse)
            End If
            
        Catch ex As Exception
            BildirimLogKaydet(nTipID, nAliciID, "", sTelefon, "WhatsApp", sMesaj, "WhatsApp", "Hata", ex.Message)
        End Try
    End Sub
    
    Private Sub UygulamaIciBildirimKaydet(ByVal nAliciID As Integer, ByVal sBaslik As String, ByVal sMesaj As String, ByVal nTipID As Integer)
        Try
            BildirimLogKaydet(nTipID, nAliciID, "", "", sBaslik, sMesaj, "Uygulama", "Gonderildi", "")
        Catch ex As Exception
            Debug.WriteLine("UygulamaIciBildirimKaydet Hata: " & ex.Message)
        End Try
    End Sub
    
    ' =============================================
    ' YARDIMCI FONKSIYONLAR
    ' =============================================
    
    Private Sub BildirimLogKaydet(ByVal nTipID As Integer, ByVal nAliciID As Integer, ByVal sEmail As String, ByVal sTelefon As String, ByVal sBaslik As String, ByVal sMesaj As String, ByVal sKanal As String, ByVal sDurum As String, ByVal sHata As String)
        Try
            Dim sql As String = "INSERT INTO tbBildirimLog (nTipID, nAliciID, sAliciEmail, sAliciTelefon, sBaslik, sMesaj, sKanal, sDurum, sHataMesaji, dteOlusturma"
            If sDurum = "Gonderildi" Then
                sql &= ", dteGonderim"
            End If
            sql &= ") VALUES (" & nTipID & ", " & nAliciID & ", '" & sEmail.Replace("'", "''") & "', '" & sTelefon.Replace("'", "''") & "', '" & sBaslik.Replace("'", "''") & "', '" & sMesaj.Replace("'", "''") & "', '" & sKanal & "', '" & sDurum & "', '" & sHata.Replace("'", "''") & "', GETDATE()"
            If sDurum = "Gonderildi" Then
                sql &= ", GETDATE()"
            End If
            sql &= ")"
            
            SQLCalistir(sql)
        Catch ex As Exception
            Debug.WriteLine("BildirimLogKaydet Hata: " & ex.Message)
        End Try
    End Sub
    
    Private Function SistemAyarGetir(ByVal sAyarKodu As String) As String
        Try
            ' Connection string kontrolü
            Dim connStr As String = KeyCode.sConnection
            If String.IsNullOrEmpty(connStr) Then
                Console.WriteLine("SistemAyarGetir: Connection string boş!")
                Return ""
            End If
            
            ' tbSistemAyar tablosundan oku
            Dim dt As DataTable = SQLCalistir("SELECT sAyarDeger FROM tbSistemAyar WHERE sAyarKodu = '" & sAyarKodu & "'")
            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 AndAlso dt.Rows(0)("sAyarDeger") IsNot DBNull.Value Then
                Return dt.Rows(0)("sAyarDeger").ToString()
            End If
        Catch ex As Exception
            Console.WriteLine("SistemAyarGetir Hata (" & sAyarKodu & "): " & ex.Message)
        End Try
        Return ""
    End Function
    
    Public Function SQLCalistir(ByVal sql As String) As DataTable
        Dim dt As New DataTable()
        Try
            ' Her seferinde güncel connection string'i al
            Dim connStr As String = KeyCode.sConnection
            If String.IsNullOrEmpty(connStr) Then
                Console.WriteLine("SQLCalistir Hata: ConnectionString boş!")
                Return dt
            End If
            Using con As New OleDbConnection(connStr)
                Using cmd As New OleDbCommand(KeyCode.sorgu_query(sql), con)
                    Using adapter As New OleDbDataAdapter(cmd)
                        con.Open()
                        adapter.Fill(dt)
                    End Using
                End Using
            End Using
        Catch ex As Exception
            Console.WriteLine("SQLCalistir Hata: " & ex.Message)
        End Try
        Return dt
    End Function
    
    Public Sub SQLCalistirNonQuery(ByVal sql As String)
        Try
            ' Her seferinde güncel connection string'i al
            Dim connStr As String = KeyCode.sConnection
            If String.IsNullOrEmpty(connStr) Then
                Console.WriteLine("SQLCalistirNonQuery Hata: ConnectionString boş!")
                Exit Sub
            End If
            Using con As New OleDbConnection(connStr)
                Using cmd As New OleDbCommand(KeyCode.sorgu_query(sql), con)
                    con.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            Console.WriteLine("SQLCalistirNonQuery Hata: " & ex.Message)
        End Try
    End Sub
    
    ' =============================================
    ' SİPARİŞ BİLDİRİMLERİ
    ' =============================================
    
    ''' <summary>
    ''' Yeni siparis bildirimi gonderir
    ''' </summary>
    Public Sub SiparisYeniBildirimiGonder(ByVal sSiparisNo As String, ByVal sMusteriAdi As String, ByVal lTutar As Decimal, Optional ByVal sUrunler As String = "")
        Try
            Dim sMesaj As String = "🛒 *YENİ SİPARİŞ*" & vbCrLf & _
                "================================" & vbCrLf & _
                "📋 *Sipariş No:* " & sSiparisNo & vbCrLf & _
                "🏢 *Müşteri:* " & sMusteriAdi & vbCrLf
            
            If Not String.IsNullOrEmpty(sUrunler) Then
                sMesaj &= vbCrLf & "📦 *Ürünler:*" & vbCrLf & sUrunler & vbCrLf
            End If
            
            sMesaj &= "💰 *Tutar:* " & lTutar.ToString("N2") & " TL" & vbCrLf & _
                "📅 *Tarih:* " & DateTime.Now.ToString("dd.MM.yyyy HH:mm") & vbCrLf & _
                "================================"
            
            WhatsAppBildirimGonder("SIPARIS_YENI", sMesaj, "Yeni Sipariş")
        Catch ex As Exception
            Debug.WriteLine("SiparisYeniBildirimiGonder Hata: " & ex.Message)
        End Try
    End Sub
    
    ''' <summary>
    ''' Siparis onaylandi bildirimi gonderir
    ''' </summary>
    Public Sub SiparisOnaylandiBildirimiGonder(ByVal sSiparisNo As String, ByVal sMusteriAdi As String, ByVal sOnaylayan As String)
        Try
            Dim sMesaj As String = "✅ *SİPARİŞ ONAYLANDI*" & vbCrLf & _
                "================================" & vbCrLf & _
                "📋 *Sipariş No:* " & sSiparisNo & vbCrLf & _
                "🏢 *Müşteri:* " & sMusteriAdi & vbCrLf & _
                "👤 *Onaylayan:* " & sOnaylayan & vbCrLf & _
                "📅 *Tarih:* " & DateTime.Now.ToString("dd.MM.yyyy HH:mm") & vbCrLf & _
                "================================"
            
            WhatsAppBildirimGonder("SIPARIS_ONAYLANDI", sMesaj, "Sipariş Onaylandı")
        Catch ex As Exception
            Debug.WriteLine("SiparisOnaylandiBildirimiGonder Hata: " & ex.Message)
        End Try
    End Sub
    
    ''' <summary>
    ''' Siparis iptal bildirimi gonderir
    ''' </summary>
    Public Sub SiparisIptalBildirimiGonder(ByVal sSiparisNo As String, ByVal sMusteriAdi As String, ByVal sIptalEden As String, Optional ByVal sNeden As String = "")
        Try
            Dim sMesaj As String = "❌ *SİPARİŞ İPTAL EDİLDİ*" & vbCrLf & _
                "================================" & vbCrLf & _
                "📋 *Sipariş No:* " & sSiparisNo & vbCrLf & _
                "🏢 *Müşteri:* " & sMusteriAdi & vbCrLf
            
            If Not String.IsNullOrEmpty(sNeden) Then
                sMesaj &= "📝 *Neden:* " & sNeden & vbCrLf
            End If
            
            sMesaj &= "👤 *İptal Eden:* " & sIptalEden & vbCrLf & _
                "📅 *Tarih:* " & DateTime.Now.ToString("dd.MM.yyyy HH:mm") & vbCrLf & _
                "================================"
            
            WhatsAppBildirimGonder("SIPARIS_IPTAL", sMesaj, "Sipariş İptal")
        Catch ex As Exception
            Debug.WriteLine("SiparisIptalBildirimiGonder Hata: " & ex.Message)
        End Try
    End Sub
    
    ''' <summary>
    ''' Siparis sevk edildi bildirimi gonderir
    ''' </summary>
    Public Sub SiparisSevkBildirimiGonder(ByVal sSiparisNo As String, ByVal sMusteriAdi As String, Optional ByVal sKargoFirma As String = "", Optional ByVal sTakipNo As String = "")
        Try
            Dim sMesaj As String = "🚚 *SİPARİŞ SEVK EDİLDİ*" & vbCrLf & _
                "================================" & vbCrLf & _
                "📋 *Sipariş No:* " & sSiparisNo & vbCrLf & _
                "🏢 *Müşteri:* " & sMusteriAdi & vbCrLf
            
            If Not String.IsNullOrEmpty(sKargoFirma) Then
                sMesaj &= "📦 *Kargo:* " & sKargoFirma & vbCrLf
            End If
            
            If Not String.IsNullOrEmpty(sTakipNo) Then
                sMesaj &= "🔢 *Takip No:* " & sTakipNo & vbCrLf
            End If
            
            sMesaj &= "📅 *Tarih:* " & DateTime.Now.ToString("dd.MM.yyyy HH:mm") & vbCrLf & _
                "================================"
            
            WhatsAppBildirimGonder("SIPARIS_SEVK", sMesaj, "Sipariş Sevk Edildi")
        Catch ex As Exception
            Debug.WriteLine("SiparisSevkBildirimiGonder Hata: " & ex.Message)
        End Try
    End Sub
    
    ''' <summary>
    ''' Uretim asamasi tamamlandi bildirimi gonderir
    ''' </summary>
    Public Sub UretimAsamaTamamlandiBildirimiGonder(ByVal sEvrakNo As String, ByVal sUrunAdi As String, ByVal sAsamaAdi As String)
        Try
            Dim sMesaj As String = "🔄 *ÜRETİM AŞAMASI TAMAMLANDI*" & vbCrLf & _
                "================================" & vbCrLf & _
                "📋 *Evrak No:* " & sEvrakNo & vbCrLf & _
                "📦 *Ürün:* " & sUrunAdi & vbCrLf & _
                "🔄 *Aşama:* " & sAsamaAdi & vbCrLf & _
                "📅 *Tarih:* " & DateTime.Now.ToString("dd.MM.yyyy HH:mm") & vbCrLf & _
                "================================"
            
            WhatsAppBildirimGonder("URETIM_ASAMA_TAMAMLANDI", sMesaj, "Üretim Aşaması Tamamlandı")
        Catch ex As Exception
            Debug.WriteLine("UretimAsamaTamamlandiBildirimiGonder Hata: " & ex.Message)
        End Try
    End Sub
    
End Module
