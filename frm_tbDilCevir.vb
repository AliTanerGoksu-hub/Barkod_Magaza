Imports System.IO
Imports business_smart.brkdutil
Imports DevExpress.XtraEditors
Public Class frm_tbDilCevir
    Public firmano As Integer = 100
    Public donemno As Integer = 1
    Public connection
    Public kullanici
    Public islem As String = ""
    Dim conn As New OleDb.OleDbConnection
    Dim con As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand
    Dim adapter As New OleDb.OleDbDataAdapter
    Dim DS As New DataSet
    Dim ds_tbDovizCinsi As DataSet
    Dim dteIslemTarihi As DateTime
    Dim dr As DataRow
    Private Sub frm_tbDilCevir_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
        dataload_tbDil()
        ara()
    End Sub
    Private Function sorgu_kriter_string(ByVal deger As String, ByVal kriter As String) As String
        Dim sorgu_kriter As String = ""
        If kriter = "Başlar" Then
            sorgu_kriter = " LIKE '" & deger & "%' "
        ElseIf kriter = "Biter" Then
            sorgu_kriter = " LIKE '%" & deger & "' "
        ElseIf kriter = "İçerir" Then
            sorgu_kriter = " LIKE '%" & deger & "%' "
        ElseIf kriter = "Boş" Then
            sorgu_kriter = " IS NULL "
        ElseIf kriter = "Dolu" Then
            sorgu_kriter = " <> '' "
        ElseIf kriter = "Farklı" Then
            sorgu_kriter = " <> '" & deger & "' "
        ElseIf kriter = "Büyük" Then
            sorgu_kriter = " >  '" & deger & "' "
        ElseIf kriter = "Küçük" Then
            sorgu_kriter = " < '" & deger & "' "
        ElseIf kriter = "Eşittir" Then
            sorgu_kriter = " = '" & deger & "' "
        End If
        Return sorgu_kriter
    End Function
    Private Sub gorunum_kaydet()
        GridView1.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\" & Me.Name.ToString & "")
        XtraMessageBox.Show(Sorgu_sDil("Görünüm Kaydedildi", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub gorunum_yukle()
        For Each clmn As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            clmn.Caption = Sorgu_sDil(clmn.Caption, sDil)
        Next
        SimpleButton1.Text = Sorgu_sDil(SimpleButton1.Text, sDil)
        SimpleButton2.Text = Sorgu_sDil(SimpleButton2.Text, sDil)
        SimpleButton3.Text = Sorgu_sDil(SimpleButton3.Text, sDil)
        SimpleButton4.Text = Sorgu_sDil(SimpleButton4.Text, sDil)
        SimpleButton5.Text = Sorgu_sDil(SimpleButton5.Text, sDil)
        SimpleButton6.Text = Sorgu_sDil(SimpleButton6.Text, sDil)
        SimpleButton7.Text = Sorgu_sDil(SimpleButton7.Text, sDil)
        GridView1.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\" & Me.Name.ToString & "")
    End Sub
    Private Function sorgu_query(ByVal query As String) As String
        query = Replace(query, "*!F", "F0" + firmano.ToString)
        query = Replace(query, "!D", "D000" + donemno.ToString)
        Return query
    End Function
    Private Function sorgu(ByVal query As String) As DataSet
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        adapter.SelectCommand = cmd
        cmd.CommandText = query
        cmd.Connection = con
        con.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, "TABLE1")
        con.Close()
        Return DS
    End Function
    Public Function sorgu_sDovizCinsi_kontrol(ByVal sDovizCinsi As String, ByVal dteIslemTarihi As DateTime) As Boolean
        Dim kriter
        Dim pass As Boolean
        kriter = ""
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     COUNT(*) AS nKayit FROM         tbDovizKuru WHERE     (sDovizCinsi = '" & sDovizCinsi & "') AND (dteKurTarihi = '" & dteIslemTarihi & "')")
        Dim kayitsayisi = cmd.ExecuteScalar
        If kayitsayisi = 0 Then
            pass = True
        Else
            pass = False
        End If
        Return pass
    End Function
    Public Sub Dataload_tbDilCevir(ByVal sDil As String, ByVal bBosKayitlar As Boolean)
        Try
            DS.Tables(0).Clear()
        Catch ex As Exception
        End Try
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        If bBosKayitlar = True Then
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sOrjinal, sDil, sAciklama, (SELECT sAciklama FROM tbDilCevir WHERE sDil = 'EN' AND sOrjinal = t.sOrjinal) AS sAciklamaEN,'http://translate.google.com.tr/?hl=tr&tab=wT#tr|' + sDil + '|' + REPLACE(RTRIM(sOrjinal), ' ', '%20') AS sCeviriBul FROM         tbDilCevir t WHERE     (sDil = '" & sDil & "') and (sAciklama = '')")
        Else
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sOrjinal, sDil, sAciklama, (SELECT sAciklama FROM tbDilCevir WHERE sDil = 'EN' AND sOrjinal = t.sOrjinal) AS sAciklamaEN,'http://translate.google.com.tr/?hl=tr&tab=wT#tr|' + sDil + '|' + REPLACE(RTRIM(sOrjinal), ' ', '%20') AS sCeviriBul FROM         tbDilCevir t WHERE     (sDil = '" & sDil & "') ")
        End If
        cmd.Connection = conn
        Dim N As Integer = adapter.Fill(DS, "Table1")
        conn.Close()
        GridControl1.DataSource = DS.Tables(0)
        GridControl1.DataMember = Nothing
        GridControl1.Focus()
        GridControl1.Select()
    End Sub
    Private Sub dataload_tbDil()
        ds_tbDovizCinsi = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sDil,sAciklama FROM         tbDil"))
        sec_sDil.Properties.DataSource = ds_tbDovizCinsi.Tables(0)
        sec_sDil.Text = sDil
    End Sub
    Private Sub tbDovizKuru_kaydet_yeni(ByVal sDovizCinsi, ByVal dteKurTarihi, ByVal lAlisKuru, ByVal lSatisKuru, ByVal lEfektifAlisKuru, ByVal lEfektifSatisKuru, ByVal lMerkezBankasiAlisKuru, ByVal lMerkezBankasiSatisKuru, ByVal sKullaniciAdi, ByVal dteKayitTarihi)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbDovizKuru (sDovizCinsi, dteKurTarihi, lAlisKuru, lSatisKuru, lEfektifAlisKuru, lEfektifSatisKuru, lMerkezBankasiAlisKuru, lMerkezBankasiSatisKuru, sKullaniciAdi, dteKayitTarihi) VALUES     ('" & sDovizCinsi & "', '" & dteKurTarihi & "', " & lAlisKuru & ", " & lSatisKuru & ", " & lEfektifAlisKuru & ", " & lEfektifSatisKuru & ", " & lMerkezBankasiAlisKuru & ", " & lMerkezBankasiSatisKuru & ", '" & sKullaniciAdi & "', '" & dteKayitTarihi & "') ")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbDilCevir_kaydet_duzelt(ByVal sOrjinal As String, ByVal sDil As String, ByVal sAciklama As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbDilCevir SET             sAciklama = N'" & sAciklama & "' WHERE     (sDil = '" & sDil & "') and (sOrjinal =N'" & sOrjinal & "')")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbDilCevir_kaydet_sil(ByVal sOrjinal As String, ByVal sDil As String, ByVal sAciklama As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE FROM tbDilCevir WHERE     (sDil = '" & sDil & "') and (sOrjinal = N'" & sOrjinal & "')")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tutar_hesapla()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            tbDilCevir_kaydet_duzelt(dr("sOrjinal"), dr("sDil"), dr("sAciklama"))
        End If
    End Sub
    Private Sub ara()
        Label2.Text = Sorgu_sDil("Lütfen Bekleyiniz...", sDil)
        Label2.Refresh()
        Dataload_tbDilCevir(sec_sDil.EditValue, sec_bBosKayitlar.Checked)
        Label2.Text = Sorgu_sDil("Tamamlandı...", sDil)
        Label2.Refresh()
    End Sub
    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        ara()
    End Sub
    Private Sub GridView1_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanged
        If GridView1.RowCount > 0 Then
            GridView1.PostEditor()
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            dr.EndEdit()
            tutar_hesapla()
        End If
    End Sub
    Private Sub GridView1_CustomDrawRowIndicator(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles GridView1.CustomDrawRowIndicator
        If e.RowHandle >= 0 Then
            e.Info.DisplayText = e.RowHandle + 1
        Else
            e.Info.DisplayText = ""
        End If
    End Sub
    Private Sub GridView1_SelectionChanged(ByVal sender As Object, ByVal e As DevExpress.Data.SelectionChangedEventArgs) Handles GridView1.SelectionChanged
        If GridView1.SelectedRowsCount > 1 Then
            Label2.Text = Sorgu_sDil("Kayıt Sayısı :", sDil) & GridView1.RowCount & " / " & Sorgu_sDil("Satır :", sDil) & GridView1.FocusedRowHandle + 1 & " / " & Sorgu_sDil("Seçili :", sDil) & GridView1.SelectedRowsCount
        ElseIf GridView1.SelectedRowsCount = 1 Then
            Label2.Text = Sorgu_sDil("Kayıt Sayısı :", sDil) & GridView1.RowCount & " / " & Sorgu_sDil("Satır :", sDil) & GridView1.FocusedRowHandle + 1
        Else
            Label2.Text = ""
        End If
    End Sub
    Private Sub sDil_Liste_Olustur()
        Dim z As String = "c:\tbDilCevirOrjinal.txt"
        Dim dosya As New IO.FileInfo(z)
        If dosya.Exists Then
            dosya.Delete()
        End If
        Dim sw As IO.StreamWriter = IO.File.AppendText(z)
        Dim dr As DataRow
        bar1.Properties.Maximum = DS.Tables(0).Rows.Count
        bar1.Position = 0
        bar1.Refresh()
        bar1.Visible = True
        Dim s As String = ""
        For Each dr In DS.Tables(0).Rows
            'ListBoxControl1.Items.Add(Trim(dr("sOrjinal").ToString))
            s += Trim(dr("sOrjinal").ToString) & vbCrLf
            sw.WriteLine(Trim(dr("sOrjinal").ToString))
            bar1.Position += 1
            bar1.Refresh()
        Next
        sw.Close()
        bar1.Position = 0
        bar1.Refresh()
        bar1.Visible = False
        Dim objProcess As System.Diagnostics.Process
        objProcess = New System.Diagnostics.Process()
        objProcess.StartInfo.WindowStyle = ProcessWindowStyle.Normal
        Dim sRun As String = ""
        Try
            sRun = "c:\tbDilCevirOrjinal.txt"
            objProcess.StartInfo.FileName = Trim(sRun)
            objProcess.StartInfo.Arguments = ""
            objProcess.Start()
        Catch ex As Exception
            DevExpress.XtraEditors.XtraMessageBox.Show("Islem Baslatilamiyor " & objProcess.StartInfo.FileName.ToString)
        End Try
    End Sub
    Private Sub SimpleButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton6.Click
        sDil_Liste_Olustur()
    End Sub
    Private Sub SimpleButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton7.Click
        GroupControl1.Visible = True
        MemoEdit1.Text = ""
        MemoEdit1.Focus()
        MemoEdit1.Select()
    End Sub
    Private Sub sDil_Liste_Oku2()
    End Sub
    Private Sub sDil_Liste_oku()
        Dim dr As DataRow
        Dim z As String = "c:\tbDilCevir.txt"
        Dim dosya As New IO.FileInfo(z)
        If dosya.Exists Then
            dosya.Delete()
        End If
        Dim sw As IO.StreamWriter = IO.File.AppendText(z)
        sw.WriteLine("")
        sw.Close()
        Dim objProcess As System.Diagnostics.Process
        objProcess = New System.Diagnostics.Process()
        objProcess.StartInfo.WindowStyle = ProcessWindowStyle.Normal
        Dim sRun As String = ""
        Try
            sRun = z
            objProcess.StartInfo.FileName = Trim(sRun)
            objProcess.StartInfo.Arguments = ""
            objProcess.Start()
            objProcess.WaitForExit()
            objProcess.Close()
            If XtraMessageBox.Show(Sorgu_sDil("Dosyayı Okumak İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                Dim sr As StreamReader = File.OpenText(z)
                Dim sk As StreamReader = File.OpenText(z)
                Dim satir As String = ""
                Dim s As String
                's = sr.Read
                Dim sayi As Integer
                Dim nSatirSayi As Integer = 0
                'Dim oku As Byte()
                sayi = 0
                Do While sk.Peek() > -1
                    satir = sk.ReadLine
                    Try
                        sayi += 1
                        nSatirSayi += 1
                    Catch ex As Exception
                        XtraMessageBox.Show(dosya.ToString & Sorgu_sDil("İsimli Dosyada ", sDil) & nSatirSayi & Sorgu_sDil(" Kayıtlı Satır Hatalı,Lütfen Kontrol Ediniz", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Question)
                    End Try
                Loop
                sk.Close()
                Dim dlg As New WaitDlgFrm("Toplam Satır :" & sayi)
                sayi = -1
                Dim cmd As New OleDb.OleDbCommand
                Dim con As New OleDb.OleDbConnection
                con.ConnectionString = connection
                cmd.Connection = con
                Do While sr.Peek() > -1
                    sayi += 1
                    s = sr.ReadLine()
                    Try
                        dr = GridView1.GetDataRow(sayi)
                        'oku = System.Text.Encoding.UTF7.GetBytes(s)
                        's = System.Text.Encoding.UTF7.GetString(oku)
                        'büyük harf
                        s = Replace(s, "€", "Ç")
                        s = Replace(s, "¦", "Ğ")
                        s = Replace(s, "˜", "İ")
                        s = Replace(s, "", "Ş")
                        s = Replace(s, "š", "Ü")
                        s = Replace(s, "™", "Ö")
                        'küçük harf
                        s = Replace(s, "‡", "ç")
                        s = Replace(s, "§", "ğ")
                        s = Replace(s, "i", "i")
                        s = Replace(s, "Ÿ", "ş")
                        s = Replace(s, "", "ü")
                        s = Replace(s, "�", "ı")
                        If Trim(dr("sOrjinal")) <> Trim(s) Then
                            dr("sAciklama") = s
                        End If
                        'MsgBox(sayi & vbTab & s)
                    Catch
                        XtraMessageBox.Show(dosya.ToString & Sorgu_sDil("İsimli Dosyada ", sDil) & sayi & Sorgu_sDil(" Kayıtlı Satır Hatalı,Lütfen Kontrol Ediniz", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Question)
                    End Try
                Loop
                sr.Close()
                dlg.Close()
            End If
        Catch ex As Exception
            DevExpress.XtraEditors.XtraMessageBox.Show("Islem Baslatilamiyor " & objProcess.StartInfo.FileName.ToString)
        End Try
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub
    Private Sub SimpleButton4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton4.Click
        GroupControl1.Visible = False
    End Sub
    Private Sub SimpleButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton5.Click
        sDilCeviri_liste_olustur()
    End Sub
    Private Sub sDilCeviri_liste_olustur()
        Dim z As String = "c:\tbDilCevir.txt"
        Dim dosya As New IO.FileInfo(z)
        If dosya.Exists Then
            dosya.Delete()
        End If
        Dim sw As IO.StreamWriter = IO.File.AppendText(z)
        'Dim dr As DataRow
        bar1.Properties.Maximum = DS.Tables(0).Rows.Count
        bar1.Position = 0
        bar1.Refresh()
        bar1.Visible = True
        Dim s As String = ""
        sw.WriteLine(MemoEdit1.Text)
        'For Each dr In DS.Tables(0).Rows
        '    'ListBoxControl1.Items.Add(Trim(dr("sOrjinal").ToString))
        '    s += Trim(dr("sOrjinal").ToString) & vbCrLf
        '    sw.WriteLine(Trim(dr("sOrjinal").ToString))
        '    bar1.Position += 1
        '    bar1.Refresh()
        'Next
        sw.Close()
        GroupControl1.Visible = False
        If XtraMessageBox.Show(Sorgu_sDil("Dosyayı Okumak İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim sr As StreamReader = File.OpenText(z)
            Dim sk As StreamReader = File.OpenText(z)
            Dim satir As String = ""
            's = sr.Read
            Dim sayi As Integer
            Dim nSatirSayi As Integer = 0
            'Dim oku As Byte()
            sayi = 0
            Do While sk.Peek() > -1
                satir = sk.ReadLine
                Try
                    sayi += 1
                    nSatirSayi += 1
                Catch ex As Exception
                    XtraMessageBox.Show(dosya.ToString & Sorgu_sDil("İsimli Dosyada ", sDil) & nSatirSayi & Sorgu_sDil(" Kayıtlı Satır Hatalı,Lütfen Kontrol Ediniz", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Question)
                End Try
            Loop
            sk.Close()
            Dim dlg As New WaitDlgFrm("Toplam Satır :" & sayi)
            sayi = -1
            Dim cmd As New OleDb.OleDbCommand
            Dim con As New OleDb.OleDbConnection
            con.ConnectionString = connection
            cmd.Connection = con
            Do While sr.Peek() > -1
                sayi += 1
                s = sr.ReadLine()
                Try
                    dr = GridView1.GetDataRow(sayi)
                    'oku = System.Text.Encoding.UTF7.GetBytes(s)
                    's = System.Text.Encoding.UTF7.GetString(oku)
                    'büyük harf
                    s = Replace(s, "€", "Ç")
                    s = Replace(s, "¦", "Ğ")
                    s = Replace(s, "˜", "İ")
                    s = Replace(s, "", "Ş")
                    s = Replace(s, "š", "Ü")
                    s = Replace(s, "™", "Ö")
                    'küçük harf
                    s = Replace(s, "‡", "ç")
                    s = Replace(s, "§", "ğ")
                    s = Replace(s, "i", "i")
                    s = Replace(s, "Ÿ", "ş")
                    s = Replace(s, "", "ü")
                    s = Replace(s, "�", "ı")
                    If Trim(dr("sOrjinal")) <> Trim(s) Then
                        dr("sAciklama") = s
                        tbDilCevir_kaydet_duzelt(dr("sOrjinal"), dr("sDil"), dr("sAciklama"))
                    End If
                    'MsgBox(sayi & vbTab & s)
                Catch
                    XtraMessageBox.Show(dosya.ToString & Sorgu_sDil("İsimli Dosyada ", sDil) & sayi & Sorgu_sDil(" Kayıtlı Satır Hatalı,Lütfen Kontrol Ediniz", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Question)
                End Try
                bar1.Position += 1
                bar1.Refresh()
            Loop
            sr.Close()
            dlg.Close()
            bar1.Position = 0
            bar1.Refresh()
            bar1.Visible = False
            ara()
        End If
    End Sub
    Private Sub raporla_excel()
        If XtraMessageBox.Show(Sorgu_sDil("Sonuçları Excel Dosyası Oluşturmak İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim SaveFileDialog1 As New Windows.Forms.SaveFileDialog
            SaveFileDialog1.Filter = "Excel Dosyaları(*.xls) |*.xls"
            SaveFileDialog1.InitialDirectory = "c:\"
            SaveFileDialog1.FileName = "Ekstre.xls"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                GridView1.ExportToXls(SaveFileDialog1.FileName.ToString)
                If XtraMessageBox.Show(Sorgu_sDil("Kaydı Açmak İster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    Process.Start(SaveFileDialog1.FileName.ToString)
                End If
            End If
            SaveFileDialog1 = Nothing
        End If
    End Sub
    Private Sub raporla_text()
        If XtraMessageBox.Show(Sorgu_sDil("Sonuçları Text Dosyası Oluşturmak İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim SaveFileDialog1 As New Windows.Forms.SaveFileDialog
            SaveFileDialog1.Filter = "Text Dosyaları(*.txt) |*.txt"
            SaveFileDialog1.InitialDirectory = "c:\"
            SaveFileDialog1.FileName = "Ekstre.txt"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                GridView1.ExportToText(SaveFileDialog1.FileName.ToString)
                If XtraMessageBox.Show(Sorgu_sDil("Kaydı Açmak İster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    Process.Start(SaveFileDialog1.FileName.ToString)
                End If
            End If
            SaveFileDialog1 = Nothing
        End If
    End Sub
    Private Sub raporla_rtf()
        If XtraMessageBox.Show(Sorgu_sDil("Sonuçları Metin Dosyası Oluşturmak İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim SaveFileDialog1 As New Windows.Forms.SaveFileDialog
            SaveFileDialog1.Filter = "Metin Dosyaları(*.rtf) |*.rtf"
            SaveFileDialog1.InitialDirectory = "c:\"
            SaveFileDialog1.FileName = "Ekstre.rtf"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                GridView1.ExportToRtf(SaveFileDialog1.FileName.ToString)
                If XtraMessageBox.Show(Sorgu_sDil("Kaydı Açmak İster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    Process.Start(SaveFileDialog1.FileName.ToString)
                End If
            End If
            SaveFileDialog1 = Nothing
        End If
    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        GridControl1.ShowPrintPreview()
    End Sub
    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        raporla_excel()
    End Sub
    Private Sub BarButtonItem3_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        raporla_text()
    End Sub
    Private Sub BarButtonItem4_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        raporla_rtf()
    End Sub
End Class