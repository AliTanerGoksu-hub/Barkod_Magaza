Imports System.Data.OleDb

''' <summary>
''' Uretim Ayarlari Formu
''' Uretim asamalari, yetkililer, uretim yerleri, araclar, vardiyalar, pozisyonlar
''' </summary>
Public Class frm_UretimAyarlar
    Private connection As String = KeyCode.sConnection
    
    ''' <summary>
    ''' Acilista hangi sekmenin secilecegini belirler
    ''' 0=Asamalar, 1=Yetkililer, 2=SatinAlma, 3=Bildirimler, 4=UretimYerleri, 5=Araclar, 6=Vardiyalar, 7=Pozisyonlar
    ''' </summary>
    Public Property AcilisSekmesi As Integer = 0
    
    Private Sub frm_UretimAyarlar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Üretim Ayarları"
        
        ' Verileri yukle
        AsamalariYukle()
        YetkililerYukle()
        SatinAlmaTalepleriniYukle()
        UretimBildirimAsamalariYukle()
        UretimYerleriYukle()
        UretimAraclariYukle()
        VardiyalarYukle()
        KaliteGruplariYukle()
        
        ' Acilis sekmesini sec
        If AcilisSekmesi >= 0 AndAlso AcilisSekmesi < TabControl1.TabCount Then
            TabControl1.SelectedIndex = AcilisSekmesi
        End If
    End Sub
    
    ' =============================================
    ' URETIM ASAMALARI
    ' =============================================
    
    Private Sub AsamalariYukle()
        Try
            Dim dt As DataTable = SQLCalistir("SELECT nAsamaID, sAsamaKodu, sAsamaAdi, nSiraNo, bAktif, nGerekliOnay, sOnayTurleri, nStandartSure FROM tbUretimAsamaTanim ORDER BY nSiraNo")
            grd_Asamalar.DataSource = dt
            
            Dim gv As DevExpress.XtraGrid.Views.Grid.GridView = CType(grd_Asamalar.MainView, DevExpress.XtraGrid.Views.Grid.GridView)
            If gv IsNot Nothing Then
                gv.OptionsView.ShowGroupPanel = False
                For Each col As DevExpress.XtraGrid.Columns.GridColumn In gv.Columns
                    Select Case col.FieldName
                        Case "nAsamaID"
                            col.Visible = False
                        Case "sAsamaKodu"
                            col.Caption = "Kod"
                            col.Width = 80
                        Case "sAsamaAdi"
                            col.Caption = "Aşama Adı"
                            col.Width = 200
                        Case "nSiraNo"
                            col.Caption = "Sıra"
                            col.Width = 50
                        Case "bAktif"
                            col.Caption = "Aktif"
                            col.Width = 50
                            col.ColumnEdit = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
                        Case "nGerekliOnay"
                            col.Caption = "Gerekli Onay"
                            col.Width = 80
                        Case "sOnayTurleri"
                            col.Caption = "Onay Türleri"
                            col.Width = 150
                        Case "nStandartSure"
                            col.Caption = "Standart Süre (dk)"
                            col.Width = 100
                    End Select
                Next
            End If
        Catch ex As Exception
            Debug.WriteLine("AsamalariYukle Hata: " & ex.Message)
        End Try
    End Sub
    
    Private Sub btn_AsamaEkle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_AsamaEkle.Click
        Try
            Dim frm As New frm_AsamaEkle()
            If frm.ShowDialog() = DialogResult.OK Then
                AsamalariYukle()
            End If
        Catch ex As Exception
            MessageBox.Show("Asama ekleme hatasi: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    
    Private Sub btn_AsamaSil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_AsamaSil.Click
        Try
            Dim gv As DevExpress.XtraGrid.Views.Grid.GridView = CType(grd_Asamalar.MainView, DevExpress.XtraGrid.Views.Grid.GridView)
            If gv.FocusedRowHandle >= 0 Then
                Dim nAsamaID As Integer = Convert.ToInt32(gv.GetRowCellValue(gv.FocusedRowHandle, "nAsamaID"))
                If MessageBox.Show("Bu asamayi silmek istediginizden emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    SQLCalistir("DELETE FROM tbUretimAsamaTanim WHERE nAsamaID = " & nAsamaID)
                    AsamalariYukle()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Asama silme hatasi: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    
    ' =============================================
    ' ASAMA YETKILILER
    ' =============================================
    
    Private Sub YetkililerYukle()
        Try
            Dim dt As DataTable = SQLCalistir("SELECT oy.nID, ISNULL(ot.sOnayTurAdi, 'Bilinmiyor') AS sOnayTurAdi, ISNULL(a.sAsamaAdi, 'Tüm Aşamalar') AS sAsamaAdi, ISNULL(p.PERSONELADI, 'Bilinmiyor') AS Personel, oy.bAktif FROM tbOnayYetkilisi oy LEFT JOIN tbOnayTurleri ot ON oy.nOnayTurID = ot.nOnayTurID LEFT JOIN APERSONEL p ON oy.nPersonelID = p.IND LEFT JOIN tbUretimAsamaTanim a ON oy.nAsamaID = a.nAsamaID ORDER BY ot.nOncelik, a.nSiraNo, p.PERSONELADI")
            grd_Yetkililer.DataSource = dt
            
            Dim gv As DevExpress.XtraGrid.Views.Grid.GridView = CType(grd_Yetkililer.MainView, DevExpress.XtraGrid.Views.Grid.GridView)
            If gv IsNot Nothing Then
                gv.OptionsView.ShowGroupPanel = False
                For Each col As DevExpress.XtraGrid.Columns.GridColumn In gv.Columns
                    Select Case col.FieldName
                        Case "nID"
                            col.Visible = False
                        Case "sOnayTurAdi"
                            col.Caption = "Onay Türü"
                            col.Width = 150
                        Case "sAsamaAdi"
                            col.Caption = "Aşama"
                            col.Width = 150
                        Case "Personel"
                            col.Caption = "Personel"
                            col.Width = 200
                        Case "bAktif"
                            col.Caption = "Aktif"
                            col.Width = 60
                            col.ColumnEdit = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
                    End Select
                Next
            End If
        Catch ex As Exception
            Debug.WriteLine("YetkililerYukle Hata: " & ex.Message)
        End Try
    End Sub
    
    Private Sub btn_YetkiliEkle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_YetkiliEkle.Click
        Try
            Dim frm As New frm_YetkiliEkle()
            If frm.ShowDialog() = DialogResult.OK Then
                YetkililerYukle()
            End If
        Catch ex As Exception
            MessageBox.Show("Yetkili ekleme hatasi: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    
    Private Sub btn_YetkiliSil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_YetkiliSil.Click
        Try
            Dim gv As DevExpress.XtraGrid.Views.Grid.GridView = CType(grd_Yetkililer.MainView, DevExpress.XtraGrid.Views.Grid.GridView)
            If gv.FocusedRowHandle >= 0 Then
                Dim nID As Integer = Convert.ToInt32(gv.GetRowCellValue(gv.FocusedRowHandle, "nID"))
                If MessageBox.Show("Bu yetkiliyi silmek istediginizden emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    SQLCalistir("DELETE FROM tbOnayYetkilisi WHERE nID = " & nID)
                    YetkililerYukle()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Yetkili silme hatasi: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    
    ' =============================================
    ' SATIN ALMA TALEPLERI
    ' =============================================
    
    Private Sub SatinAlmaTalepleriniYukle()
        Try
            Dim dt As DataTable = SQLCalistir("SELECT nID AS nTalepID, sStokKodu, sStokAdi, nMiktar, sOlcuBirimi, sDurum, sAciklama, dteOlusturma FROM tbOtomatikSiparis WHERE sDurum = 'Beklemede' ORDER BY dteOlusturma DESC")
            grd_SatinAlma.DataSource = dt
            
            Dim gv As DevExpress.XtraGrid.Views.Grid.GridView = CType(grd_SatinAlma.MainView, DevExpress.XtraGrid.Views.Grid.GridView)
            If gv IsNot Nothing Then
                gv.OptionsView.ShowGroupPanel = False
            End If
        Catch ex As Exception
            Debug.WriteLine("SatinAlmaTalepleriniYukle Hata: " & ex.Message)
        End Try
    End Sub
    
    Private Sub btn_TalepOnayla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_TalepOnayla.Click
        Try
            Dim gv As DevExpress.XtraGrid.Views.Grid.GridView = CType(grd_SatinAlma.MainView, DevExpress.XtraGrid.Views.Grid.GridView)
            If gv.FocusedRowHandle >= 0 Then
                Dim nTalepID As Integer = Convert.ToInt32(gv.GetRowCellValue(gv.FocusedRowHandle, "nTalepID"))
                If MessageBox.Show("Bu talebi onaylamak istediginizden emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    SQLCalistir("UPDATE tbOtomatikSiparis SET sDurum = 'Onaylandi', nOnaylayanID = " & CInt(KeyCode.kullanici) & ", dteOnay = GETDATE() WHERE nID = " & nTalepID)
                    SatinAlmaTalepleriniYukle()
                    MessageBox.Show("Talep onaylandi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Onaylama hatasi: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    
    Private Sub btn_TalepReddet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_TalepReddet.Click
        Try
            Dim gv As DevExpress.XtraGrid.Views.Grid.GridView = CType(grd_SatinAlma.MainView, DevExpress.XtraGrid.Views.Grid.GridView)
            If gv.FocusedRowHandle >= 0 Then
                Dim nTalepID As Integer = Convert.ToInt32(gv.GetRowCellValue(gv.FocusedRowHandle, "nTalepID"))
                
                Dim frm As New frm_TekAlanGiris()
                frm.FormBaslik = "Talep Reddetme"
                frm.AlanBaslik = "Reddetme Nedeni:"
                frm.Aciklama = "Bu talebi neden reddettiginizi aciklayin."
                frm.CokSatirli = True
                
                If frm.ShowDialog() = DialogResult.OK Then
                    If MessageBox.Show("Bu talebi reddetmek istediginizden emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        SQLCalistir("UPDATE tbOtomatikSiparis SET sDurum = 'Reddedildi', nOnaylayanID = " & CInt(KeyCode.kullanici) & ", dteOnay = GETDATE(), sAciklama = ISNULL(sAciklama,'') + ' RED: " & frm.GirilenDeger.Replace("'", "''") & "' WHERE nID = " & nTalepID)
                        SatinAlmaTalepleriniYukle()
                        MessageBox.Show("Talep reddedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Reddetme hatasi: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    
    ' =============================================
    ' URETIM BILDIRIMLERI
    ' =============================================
    
    Private Sub UretimBildirimAsamalariYukle()
        Try
            ' Asama listesini yukle
            Dim dt As DataTable = SQLCalistir("SELECT nAsamaID, sAsamaAdi FROM tbUretimAsamaTanim WHERE bAktif = 1 ORDER BY nSiraNo")
            
            ' Tum Asamalar secenegi ekle
            Dim dtWithAll As DataTable = dt.Clone()
            Dim drAll As DataRow = dtWithAll.NewRow()
            drAll("nAsamaID") = 0
            drAll("sAsamaAdi") = "-- Tüm Aşamalar --"
            dtWithAll.Rows.Add(drAll)
            
            For Each dr As DataRow In dt.Rows
                dtWithAll.ImportRow(dr)
            Next
            
            cmb_BildirimAsama.Properties.DataSource = dtWithAll
            cmb_BildirimAsama.Properties.DisplayMember = "sAsamaAdi"
            cmb_BildirimAsama.Properties.ValueMember = "nAsamaID"
            cmb_BildirimAsama.Properties.Columns.Clear()
            cmb_BildirimAsama.Properties.Columns.Add(New DevExpress.XtraEditors.Controls.LookUpColumnInfo("sAsamaAdi", "Aşama", 250))
            cmb_BildirimAsama.Properties.ShowHeader = False
            cmb_BildirimAsama.Properties.NullText = "Aşama seçin..."
            
            ' Ilk secim
            If dtWithAll.Rows.Count > 0 Then
                cmb_BildirimAsama.EditValue = 0
            End If
            
            ' Bildirim listesini yukle
            UretimBildirimleriniYukle()
        Catch ex As Exception
            Debug.WriteLine("UretimBildirimAsamalariYukle Hata: " & ex.Message)
        End Try
    End Sub
    
    Private Sub cmb_BildirimAsama_EditValueChanged(sender As Object, e As EventArgs) Handles cmb_BildirimAsama.EditValueChanged
        UretimBildirimleriniYukle()
    End Sub
    
    Private Sub UretimBildirimleriniYukle()
        Try
            Dim nAsamaID As Integer = 0
            If cmb_BildirimAsama.EditValue IsNot Nothing AndAlso cmb_BildirimAsama.EditValue IsNot DBNull.Value Then
                nAsamaID = Convert.ToInt32(cmb_BildirimAsama.EditValue)
            End If
            
            Dim sql As String
            If nAsamaID = 0 Then
                ' Tum asamalar
                sql = "SELECT ub.nID, ISNULL(a.sAsamaAdi, 'Tüm Aşamalar') AS sAsamaAdi, p.PERSONELADI, p.CEPNO, p.EMAIL, ub.bWhatsApp, ub.bEmail, ub.bSMS, ub.bAktif " &
                      "FROM tbUretimBildirimAlici ub " &
                      "LEFT JOIN tbUretimAsamaTanim a ON ub.nAsamaID = a.nAsamaID " &
                      "INNER JOIN APERSONEL p ON ub.nPersonelID = p.IND " &
                      "ORDER BY a.nSiraNo, p.PERSONELADI"
            Else
                ' Belirli asama
                sql = "SELECT ub.nID, ISNULL(a.sAsamaAdi, 'Tüm Aşamalar') AS sAsamaAdi, p.PERSONELADI, p.CEPNO, p.EMAIL, ub.bWhatsApp, ub.bEmail, ub.bSMS, ub.bAktif " &
                      "FROM tbUretimBildirimAlici ub " &
                      "LEFT JOIN tbUretimAsamaTanim a ON ub.nAsamaID = a.nAsamaID " &
                      "INNER JOIN APERSONEL p ON ub.nPersonelID = p.IND " &
                      "WHERE ub.nAsamaID = " & nAsamaID & " OR ub.nAsamaID IS NULL " &
                      "ORDER BY a.nSiraNo, p.PERSONELADI"
            End If
            
            Dim dt As DataTable = SQLCalistir(sql)
            grd_UretimBildirim.DataSource = dt
            
            Dim gv As DevExpress.XtraGrid.Views.Grid.GridView = CType(grd_UretimBildirim.MainView, DevExpress.XtraGrid.Views.Grid.GridView)
            If gv IsNot Nothing Then
                gv.OptionsView.ShowGroupPanel = False
                For Each col As DevExpress.XtraGrid.Columns.GridColumn In gv.Columns
                    Select Case col.FieldName
                        Case "nID"
                            col.Visible = False
                        Case "sAsamaAdi"
                            col.Caption = "Aşama"
                            col.Width = 150
                        Case "PERSONELADI"
                            col.Caption = "Personel"
                            col.Width = 200
                        Case "CEPNO"
                            col.Caption = "Cep No"
                            col.Width = 120
                        Case "EMAIL"
                            col.Caption = "Email"
                            col.Width = 200
                        Case "bWhatsApp"
                            col.Caption = "WhatsApp"
                            col.Width = 80
                            col.ColumnEdit = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
                        Case "bEmail"
                            col.Caption = "Email"
                            col.Width = 60
                            col.ColumnEdit = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
                        Case "bSMS"
                            col.Caption = "SMS"
                            col.Width = 50
                            col.ColumnEdit = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
                        Case "bAktif"
                            col.Caption = "Aktif"
                            col.Width = 50
                            col.ColumnEdit = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
                    End Select
                Next
            End If
        Catch ex As Exception
            Debug.WriteLine("UretimBildirimleriniYukle Hata: " & ex.Message)
        End Try
    End Sub
    
    Private Sub btn_BildirimEkle_Click(sender As Object, e As EventArgs) Handles btn_BildirimEkle.Click
        Try
            ' Personel secimi formu
            Dim frm As New frm_GenelSecim()
            frm.FormBaslik = "Bildirim Alacak Personel Seç"
            frm.TabloAdi = "APERSONEL"
            frm.IDKolonu = "IND"
            frm.KodKolonu = "PERSONELKODU"
            frm.AdKolonu = "PERSONELADI"
            frm.EkKolonlar = "" ' CEPNO ve EMAIL kolonlari olmayabilir
            frm.FiltreSorgu = "WHERE AKTIF = 1"
            frm.SiralamaKolonu = "PERSONELADI"
            
            If frm.ShowDialog() = DialogResult.OK Then
                Dim nPersonelID As Integer = frm.SecilenID
                Dim nAsamaID As Integer? = Nothing
                
                If cmb_BildirimAsama.EditValue IsNot Nothing AndAlso cmb_BildirimAsama.EditValue IsNot DBNull.Value Then
                    Dim secilen As Integer = Convert.ToInt32(cmb_BildirimAsama.EditValue)
                    If secilen > 0 Then nAsamaID = secilen
                End If
                
                ' Kayit ekle
                If nAsamaID.HasValue Then
                    SQLCalistir("INSERT INTO tbUretimBildirimAlici (nAsamaID, nPersonelID, bWhatsApp, bEmail, bSMS, bAktif) VALUES (" & nAsamaID.Value & ", " & nPersonelID & ", 1, 1, 0, 1)")
                Else
                    SQLCalistir("INSERT INTO tbUretimBildirimAlici (nPersonelID, bWhatsApp, bEmail, bSMS, bAktif) VALUES (" & nPersonelID & ", 1, 1, 0, 1)")
                End If
                
                UretimBildirimleriniYukle()
                MessageBox.Show("Bildirim alıcısı eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Ekleme hatası: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    
    Private Sub btn_BildirimSil_Click(sender As Object, e As EventArgs) Handles btn_BildirimSil.Click
        Try
            Dim gv As DevExpress.XtraGrid.Views.Grid.GridView = CType(grd_UretimBildirim.MainView, DevExpress.XtraGrid.Views.Grid.GridView)
            If gv.FocusedRowHandle >= 0 Then
                Dim nID As Integer = Convert.ToInt32(gv.GetRowCellValue(gv.FocusedRowHandle, "nID"))
                If MessageBox.Show("Bu bildirim alıcısını silmek istediğinizden emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    SQLCalistir("DELETE FROM tbUretimBildirimAlici WHERE nID = " & nID)
                    UretimBildirimleriniYukle()
                    MessageBox.Show("Bildirim alıcısı silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Silme hatası: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    
    Private Sub btn_BildirimKaydet_Click(sender As Object, e As EventArgs) Handles btn_BildirimKaydet.Click
        Try
            Dim gv As DevExpress.XtraGrid.Views.Grid.GridView = CType(grd_UretimBildirim.MainView, DevExpress.XtraGrid.Views.Grid.GridView)
            
            For i As Integer = 0 To gv.RowCount - 1
                Dim nID As Integer = Convert.ToInt32(gv.GetRowCellValue(i, "nID"))
                Dim bWhatsApp As Boolean = Convert.ToBoolean(gv.GetRowCellValue(i, "bWhatsApp"))
                Dim bEmail As Boolean = Convert.ToBoolean(gv.GetRowCellValue(i, "bEmail"))
                Dim bSMS As Boolean = Convert.ToBoolean(gv.GetRowCellValue(i, "bSMS"))
                Dim bAktif As Boolean = Convert.ToBoolean(gv.GetRowCellValue(i, "bAktif"))
                
                SQLCalistir("UPDATE tbUretimBildirimAlici SET bWhatsApp = " & If(bWhatsApp, 1, 0) & ", bEmail = " & If(bEmail, 1, 0) & ", bSMS = " & If(bSMS, 1, 0) & ", bAktif = " & If(bAktif, 1, 0) & " WHERE nID = " & nID)
            Next
            
            MessageBox.Show("Bildirim ayarları kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Kaydetme hatası: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    
    ' =============================================
    ' URETIM YERLERI
    ' =============================================
    
    Private Sub UretimYerleriYukle()
        Try
            Dim dt As DataTable = SQLCalistir("SELECT IND, KOD, AD, UNVAN FROM TBLUREURETIMYERLERI ORDER BY KOD")
            grd_UretimYerleri.DataSource = dt
            
            Dim gv As DevExpress.XtraGrid.Views.Grid.GridView = CType(grd_UretimYerleri.MainView, DevExpress.XtraGrid.Views.Grid.GridView)
            If gv IsNot Nothing Then
                gv.OptionsView.ShowGroupPanel = False
                For Each col As DevExpress.XtraGrid.Columns.GridColumn In gv.Columns
                    If col.FieldName = "IND" Then col.Visible = False
                Next
            End If
        Catch ex As Exception
            Debug.WriteLine("UretimYerleriYukle Hata: " & ex.Message)
        End Try
    End Sub
    
    Private Sub btn_UretimYeriEkle_Click(sender As Object, e As EventArgs) Handles btn_UretimYeriEkle.Click
        Dim frm As New frm_GenelSecim()
        frm.FormBaslik = "Üretim Yeri Seç/Ekle"
        frm.TabloAdi = "TBLUREURETIMYERLERI"
        frm.IDKolonu = "IND"
        frm.KodKolonu = "KOD"
        frm.AdKolonu = "AD"
        frm.InsertSQL = "INSERT INTO TBLUREURETIMYERLERI (KOD, AD, CARINO, UNVAN, ADRESSEVK, TELEFON, FAX, VERGIDAIRESI, VERGINO, DEPONO, DEPOKODU) VALUES ('{KOD}', '{AD}', 0, '', '', '', '', '', '', 0, '')"
        
        If frm.ShowDialog() = DialogResult.OK OrElse frm.YeniKayitEklendi Then
            UretimYerleriYukle()
        End If
    End Sub
    
    Private Sub btn_UretimYeriDuzenle_Click(sender As Object, e As EventArgs) Handles btn_UretimYeriDuzenle.Click
        If GridView7.FocusedRowHandle < 0 Then
            MessageBox.Show("Lütfen bir kayit secin.", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        
        Dim nID As Integer = Convert.ToInt32(GridView7.GetRowCellValue(GridView7.FocusedRowHandle, "IND"))
        Dim sKod As String = Convert.ToString(GridView7.GetRowCellValue(GridView7.FocusedRowHandle, "KOD"))
        Dim sAd As String = Convert.ToString(GridView7.GetRowCellValue(GridView7.FocusedRowHandle, "AD"))
        
        Dim frm As New frm_GenelDuzenle()
        frm.FormBaslik = "Üretim Yeri Düzenle"
        frm.KodBaslik = "Üretim Yeri Kodu:"
        frm.AdBaslik = "Üretim Yeri Adi:"
        frm.MevcutKod = sKod
        frm.MevcutAd = sAd
        
        If frm.ShowDialog() = DialogResult.OK Then
            SQLCalistir("UPDATE TBLUREURETIMYERLERI SET KOD = '" & frm.YeniKod.Replace("'", "''") & "', AD = '" & frm.YeniAd.Replace("'", "''") & "' WHERE IND = " & nID)
            UretimYerleriYukle()
        End If
    End Sub
    
    Private Sub btn_UretimYeriSil_Click(sender As Object, e As EventArgs) Handles btn_UretimYeriSil.Click
        If GridView7.FocusedRowHandle < 0 Then Exit Sub
        
        Dim nID As Integer = Convert.ToInt32(GridView7.GetRowCellValue(GridView7.FocusedRowHandle, "IND"))
        If MessageBox.Show("Bu kaydi silmek istediginizden emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            SQLCalistir("DELETE FROM TBLUREURETIMYERLERI WHERE IND = " & nID)
            UretimYerleriYukle()
        End If
    End Sub
    
    ' =============================================
    ' URETIM ARACLARI
    ' =============================================
    
    Private Sub UretimAraclariYukle()
        Try
            Dim dt As DataTable = SQLCalistir("SELECT IND, KOD, AD, CALISMAUSULU FROM TBLUREARAC ORDER BY KOD")
            grd_UretimAraclari.DataSource = dt
            
            Dim gv As DevExpress.XtraGrid.Views.Grid.GridView = CType(grd_UretimAraclari.MainView, DevExpress.XtraGrid.Views.Grid.GridView)
            If gv IsNot Nothing Then
                gv.OptionsView.ShowGroupPanel = False
                For Each col As DevExpress.XtraGrid.Columns.GridColumn In gv.Columns
                    If col.FieldName = "IND" Then col.Visible = False
                Next
            End If
        Catch ex As Exception
            Debug.WriteLine("UretimAraclariYukle Hata: " & ex.Message)
        End Try
    End Sub
    
    Private Sub btn_UretimAraciEkle_Click(sender As Object, e As EventArgs) Handles btn_UretimAraciEkle.Click
        Dim frm As New frm_GenelSecim()
        frm.FormBaslik = "Üretim Araci Seç/Ekle"
        frm.TabloAdi = "TBLUREARAC"
        frm.IDKolonu = "IND"
        frm.KodKolonu = "KOD"
        frm.AdKolonu = "AD"
        frm.InsertSQL = "INSERT INTO TBLUREARAC (KOD, AD, CALISMAUSULU) VALUES ('{KOD}', '{AD}', 0)"
        
        If frm.ShowDialog() = DialogResult.OK OrElse frm.YeniKayitEklendi Then
            UretimAraclariYukle()
        End If
    End Sub
    
    Private Sub btn_UretimAraciDuzenle_Click(sender As Object, e As EventArgs) Handles btn_UretimAraciDuzenle.Click
        If GridView8.FocusedRowHandle < 0 Then
            MessageBox.Show("Lütfen bir kayit secin.", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        
        Dim nID As Integer = Convert.ToInt32(GridView8.GetRowCellValue(GridView8.FocusedRowHandle, "IND"))
        Dim sKod As String = Convert.ToString(GridView8.GetRowCellValue(GridView8.FocusedRowHandle, "KOD"))
        Dim sAd As String = Convert.ToString(GridView8.GetRowCellValue(GridView8.FocusedRowHandle, "AD"))
        
        Dim frm As New frm_GenelDuzenle()
        frm.FormBaslik = "Üretim Araci Düzenle"
        frm.KodBaslik = "Araç Kodu:"
        frm.AdBaslik = "Araç Adi:"
        frm.MevcutKod = sKod
        frm.MevcutAd = sAd
        
        If frm.ShowDialog() = DialogResult.OK Then
            SQLCalistir("UPDATE TBLUREARAC SET KOD = '" & frm.YeniKod.Replace("'", "''") & "', AD = '" & frm.YeniAd.Replace("'", "''") & "' WHERE IND = " & nID)
            UretimAraclariYukle()
        End If
    End Sub
    
    Private Sub btn_UretimAraciSil_Click(sender As Object, e As EventArgs) Handles btn_UretimAraciSil.Click
        If GridView8.FocusedRowHandle < 0 Then Exit Sub
        
        Dim nID As Integer = Convert.ToInt32(GridView8.GetRowCellValue(GridView8.FocusedRowHandle, "IND"))
        If MessageBox.Show("Bu kaydi silmek istediginizden emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            SQLCalistir("DELETE FROM TBLUREARAC WHERE IND = " & nID)
            UretimAraclariYukle()
        End If
    End Sub
    
    ' =============================================
    ' VARDIYALAR
    ' =============================================
    
    Private Sub VardiyalarYukle()
        Try
            Dim dt As DataTable = SQLCalistir("SELECT IND, GRUPADI, BASLAMASAATI, BITISAATI FROM TBLUREVARDIYALIST ORDER BY GRUPADI")
            grd_Vardiyalar.DataSource = dt
            
            Dim gv As DevExpress.XtraGrid.Views.Grid.GridView = CType(grd_Vardiyalar.MainView, DevExpress.XtraGrid.Views.Grid.GridView)
            If gv IsNot Nothing Then
                gv.OptionsView.ShowGroupPanel = False
                For Each col As DevExpress.XtraGrid.Columns.GridColumn In gv.Columns
                    If col.FieldName = "IND" Then col.Visible = False
                Next
            End If
        Catch ex As Exception
            Debug.WriteLine("VardiyalarYukle Hata: " & ex.Message)
        End Try
    End Sub
    
    Private Sub btn_VardiyaEkle_Click(sender As Object, e As EventArgs) Handles btn_VardiyaEkle.Click
        Dim frm As New frm_GenelSecim()
        frm.FormBaslik = "Vardiya Seç/Ekle"
        frm.TabloAdi = "TBLUREVARDIYALIST"
        frm.IDKolonu = "IND"
        frm.KodKolonu = "GRUPADI"
        frm.AdKolonu = "BASLAMASAATI"
        frm.KodZorunlu = True
        frm.AdZorunlu = False
        frm.InsertSQL = "INSERT INTO TBLUREVARDIYALIST (GRUPADI, BASLAMASAATI, BITISAATI) VALUES ('{KOD}', '08:00', '17:00')"
        
        If frm.ShowDialog() = DialogResult.OK OrElse frm.YeniKayitEklendi Then
            VardiyalarYukle()
        End If
    End Sub
    
    Private Sub btn_VardiyaDuzenle_Click(sender As Object, e As EventArgs) Handles btn_VardiyaDuzenle.Click
        If GridView9.FocusedRowHandle < 0 Then
            MessageBox.Show("Lütfen bir kayit secin.", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        
        Dim nID As Integer = Convert.ToInt32(GridView9.GetRowCellValue(GridView9.FocusedRowHandle, "IND"))
        Dim sGrupAdi As String = Convert.ToString(GridView9.GetRowCellValue(GridView9.FocusedRowHandle, "GRUPADI"))
        
        Dim frm As New frm_GenelDuzenle()
        frm.FormBaslik = "Vardiya Düzenle"
        frm.KodBaslik = "Vardiya Adi:"
        frm.AdBaslik = ""
        frm.MevcutKod = sGrupAdi
        frm.AdZorunlu = False
        
        If frm.ShowDialog() = DialogResult.OK Then
            SQLCalistir("UPDATE TBLUREVARDIYALIST SET GRUPADI = '" & frm.YeniKod.Replace("'", "''") & "' WHERE IND = " & nID)
            VardiyalarYukle()
        End If
    End Sub
    
    Private Sub btn_VardiyaSil_Click(sender As Object, e As EventArgs) Handles btn_VardiyaSil.Click
        If GridView9.FocusedRowHandle < 0 Then Exit Sub
        
        Dim nID As Integer = Convert.ToInt32(GridView9.GetRowCellValue(GridView9.FocusedRowHandle, "IND"))
        If MessageBox.Show("Bu kaydi silmek istediginizden emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            SQLCalistir("DELETE FROM TBLUREVARDIYALIST WHERE IND = " & nID)
            VardiyalarYukle()
        End If
    End Sub
    
    ' =============================================
    ' POZISYONLAR
    ' =============================================
    
    Private Sub KaliteGruplariYukle()
        Try
            Dim dt As DataTable = SQLCalistir("SELECT IND, KOD, ACIKLAMA, SURE FROM TBLUREPOZISYONLIST ORDER BY KOD")
            grd_KaliteGruplari.DataSource = dt
            
            Dim gv As DevExpress.XtraGrid.Views.Grid.GridView = CType(grd_KaliteGruplari.MainView, DevExpress.XtraGrid.Views.Grid.GridView)
            If gv IsNot Nothing Then
                gv.OptionsView.ShowGroupPanel = False
                For Each col As DevExpress.XtraGrid.Columns.GridColumn In gv.Columns
                    If col.FieldName = "IND" Then col.Visible = False
                Next
            End If
        Catch ex As Exception
            Debug.WriteLine("KaliteGruplariYukle Hata: " & ex.Message)
        End Try
    End Sub
    
    Private Sub btn_KaliteEkle_Click(sender As Object, e As EventArgs) Handles btn_KaliteEkle.Click
        Dim frm As New frm_GenelSecim()
        frm.FormBaslik = "Pozisyon Seç/Ekle"
        frm.TabloAdi = "TBLUREPOZISYONLIST"
        frm.IDKolonu = "IND"
        frm.KodKolonu = "KOD"
        frm.AdKolonu = "ACIKLAMA"
        frm.InsertSQL = "INSERT INTO TBLUREPOZISYONLIST (KOD, ACIKLAMA, SURE) VALUES ('{KOD}', '{AD}', 0)"
        
        If frm.ShowDialog() = DialogResult.OK OrElse frm.YeniKayitEklendi Then
            KaliteGruplariYukle()
        End If
    End Sub
    
    Private Sub btn_KaliteDuzenle_Click(sender As Object, e As EventArgs) Handles btn_KaliteDuzenle.Click
        If GridView10.FocusedRowHandle < 0 Then
            MessageBox.Show("Lütfen bir kayit secin.", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        
        Dim nID As Integer = Convert.ToInt32(GridView10.GetRowCellValue(GridView10.FocusedRowHandle, "IND"))
        Dim sKod As String = Convert.ToString(GridView10.GetRowCellValue(GridView10.FocusedRowHandle, "KOD"))
        Dim sAciklama As String = Convert.ToString(GridView10.GetRowCellValue(GridView10.FocusedRowHandle, "ACIKLAMA"))
        
        Dim frm As New frm_GenelDuzenle()
        frm.FormBaslik = "Pozisyon Düzenle"
        frm.KodBaslik = "Pozisyon Kodu:"
        frm.AdBaslik = "Açiklama:"
        frm.MevcutKod = sKod
        frm.MevcutAd = sAciklama
        
        If frm.ShowDialog() = DialogResult.OK Then
            SQLCalistir("UPDATE TBLUREPOZISYONLIST SET KOD = '" & frm.YeniKod.Replace("'", "''") & "', ACIKLAMA = '" & frm.YeniAd.Replace("'", "''") & "' WHERE IND = " & nID)
            KaliteGruplariYukle()
        End If
    End Sub
    
    Private Sub btn_KaliteSil_Click(sender As Object, e As EventArgs) Handles btn_KaliteSil.Click
        If GridView10.FocusedRowHandle < 0 Then Exit Sub
        
        Dim nID As Integer = Convert.ToInt32(GridView10.GetRowCellValue(GridView10.FocusedRowHandle, "IND"))
        If MessageBox.Show("Bu kaydi silmek istediginizden emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            SQLCalistir("DELETE FROM TBLUREPOZISYONLIST WHERE IND = " & nID)
            KaliteGruplariYukle()
        End If
    End Sub
    
    ' =============================================
    ' YARDIMCI FONKSIYONLAR
    ' =============================================
    
    Private Function SQLCalistir(ByVal sql As String) As DataTable
        Dim dt As New DataTable()
        Try
            Using con As New OleDbConnection(connection)
                Using cmd As New OleDbCommand(KeyCode.sorgu_query(sql), con)
                    Using adapter As New OleDbDataAdapter(cmd)
                        con.Open()
                        adapter.Fill(dt)
                    End Using
                End Using
            End Using
        Catch ex As Exception
            Debug.WriteLine("SQLCalistir Hata: " & ex.Message)
        End Try
        Return dt
    End Function
    
End Class
