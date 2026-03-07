Imports DevExpress.XtraEditors
Public Class frm_tbDovizKuru
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
    Dim dsDoviz As New DataSet("Currency")
    Private Sub frm_tbDovizKuru_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DateEdit1.EditValue = dteSistemTarihi
        dataload_tbDovizCinsi()
        Dataload_tbDovizKuru(DateEdit1.EditValue)
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
    End Sub
    Dim satir
    Private Function sorgu_kriter_string(ByVal deger As String, ByVal kriter As String) As String
        Dim sorgu_kriter As String = ""
        If kriter = "Baþlar" Then
            sorgu_kriter = " LIKE '" & deger & "%' "
        ElseIf kriter = "Biter" Then
            sorgu_kriter = " LIKE '%" & deger & "' "
        ElseIf kriter = "Ýçerir" Then
            sorgu_kriter = " LIKE '%" & deger & "%' "
        ElseIf kriter = "Boþ" Then
            sorgu_kriter = " IS NULL "
        ElseIf kriter = "Dolu" Then
            sorgu_kriter = " <> '' "
        ElseIf kriter = "Farklý" Then
            sorgu_kriter = " <> '" & deger & "' "
        ElseIf kriter = "Büyük" Then
            sorgu_kriter = " >  '" & deger & "' "
        ElseIf kriter = "Küçük" Then
            sorgu_kriter = " < '" & deger & "' "
        ElseIf kriter = "Eþittir" Then
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
    Public Sub Dataload_tbDovizKuru(ByVal dteTarih As DateTime)
        Try
            DS.Tables(0).Clear()
        Catch ex As Exception
        End Try
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbDovizCinsi.sDovizCinsi, tbDovizCinsi.sAciklama, 0 AS lParite, ISNULL(tbDovizKuru.lAlisKuru, 0) AS lAlisKuru, ISNULL(tbDovizKuru.lSatisKuru, 0) AS lSatisKuru, ISNULL(tbDovizKuru.lEfektifAlisKuru, 0) AS lEfektifAlisKuru, ISNULL(tbDovizKuru.lEfektifSatisKuru, 0) AS lEfektifSatisKuru, ISNULL(tbDovizKuru.lMerkezBankasiAlisKuru, 0) AS lMerkezBankasiAlisKuru, ISNULL(tbDovizKuru.lMerkezBankasiSatisKuru, 0) AS lMerkezBankasiSatisKuru FROM tbDovizCinsi LEFT OUTER JOIN tbDovizKuru ON tbDovizCinsi.sDovizCinsi = tbDovizKuru.sDovizCinsi AND tbDovizKuru.dteKurTarihi = '" & dteTarih & "' WHERE (tbDovizCinsi.sDovizCinsi <> '') ORDER BY tbDovizCinsi.sAciklama ")
        cmd.Connection = conn
        Dim N As Integer = adapter.Fill(DS, "Table1")
        conn.Close()
        GridControl1.DataSource = DS.Tables(0)
        GridControl1.DataMember = Nothing
        GridControl1.Focus()
        GridControl1.Select()
        dteIslemTarihi = dteTarih
    End Sub
    Private Sub dataload_tbDovizCinsi()
        ds_tbDovizCinsi = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sDovizCinsi,sAciklama FROM         tbDovizCinsi"))
        sec_sDovizCinsi.Properties.DataSource = ds_tbDovizCinsi.Tables(0)
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
    Private Sub tbDovizKuru_kaydet_duzelt(ByVal sDovizCinsi, ByVal dteKurTarihi, ByVal lAlisKuru, ByVal lSatisKuru, ByVal lEfektifAlisKuru, ByVal lEfektifSatisKuru, ByVal lMerkezBankasiAlisKuru, ByVal lMerkezBankasiSatisKuru, ByVal sKullaniciAdi, ByVal dteKayitTarihi)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbDovizKuru SET              lAlisKuru = " & lAlisKuru & ", lSatisKuru = " & lSatisKuru & ", lEfektifAlisKuru = " & lEfektifAlisKuru & ", lEfektifSatisKuru = " & lEfektifSatisKuru & ", lMerkezBankasiAlisKuru = " & lMerkezBankasiAlisKuru & ", lMerkezBankasiSatisKuru = " & lMerkezBankasiSatisKuru & " WHERE     (sDovizCinsi = '" & sDovizCinsi & "') AND (dteKurTarihi = '" & dteIslemTarihi & "')")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbDovizKuru_kaydet_sil(ByVal sDovizCinsi As String, ByVal dteIslemTarihi As DateTime)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE FROM tbDovizKuru WHERE     (sDovizCinsi = '" & sDovizCinsi & "') AND (dteKurTarihi = '" & dteIslemTarihi & "')")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tutar_hesapla()
        Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        If dr("lAlisKuru") + dr("lSatisKuru") + dr("lEfektifAlisKuru") + dr("lEfektifSatisKuru") + dr("lMerkezBankasiAlisKuru") + dr("lMerkezBankasiSatisKuru") <> 0 Then
            If sorgu_sDovizCinsi_kontrol(dr("sDovizCinsi"), dteIslemTarihi) = False Then
                tbDovizKuru_kaydet_duzelt(dr("sDovizCinsi"), dteIslemTarihi, dr("lAlisKuru"), dr("lSatisKuru"), dr("lEfektifAlisKuru"), dr("lEfektifSatisKuru"), dr("lMerkezBankasiAlisKuru"), dr("lMerkezBankasiSatisKuru"), kullanici, Now)
            Else
                tbDovizKuru_kaydet_yeni(dr("sDovizCinsi"), dteIslemTarihi, dr("lAlisKuru"), dr("lSatisKuru"), dr("lEfektifAlisKuru"), dr("lEfektifSatisKuru"), dr("lMerkezBankasiAlisKuru"), dr("lMerkezBankasiSatisKuru"), kullanici, Now)
            End If
        Else
            If sorgu_sDovizCinsi_kontrol(dr("sDovizCinsi"), dteIslemTarihi) = False Then
                tbDovizKuru_kaydet_sil(dr("sDovizCinsi"), dteIslemTarihi)
            End If
        End If
    End Sub
    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        Dataload_tbDovizKuru(DateEdit1.EditValue)
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub GridView1_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanged
        If GridView1.RowCount > 0 Then
            GridView1.PostEditor()
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            dr.EndEdit()
            tutar_hesapla()
        End If
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.Close()
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
            Label2.Text = Sorgu_sDil("Kayýt Sayýsý :", sDil) & GridView1.RowCount & " / " & Sorgu_sDil("Satýr :", sDil) & GridView1.FocusedRowHandle + 1 & " / " & Sorgu_sDil("Seçili :", sDil) & GridView1.SelectedRowsCount
        ElseIf GridView1.SelectedRowsCount = 1 Then
            Label2.Text = Sorgu_sDil("Kayýt Sayýsý :", sDil) & GridView1.RowCount & " / " & Sorgu_sDil("Satýr :", sDil) & GridView1.FocusedRowHandle + 1
        Else
            Label2.Text = ""
        End If
    End Sub
    Private Sub SimpleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton4.Click
        gorunum_yazdir()
    End Sub
    Private Sub gorunum_yazdir()
        Dim kriter As String = ""
        kriter += DateEdit1.EditValue.ToLongDateString & " Tarihli Döviz Kurlarý" & vbCrLf
        kriter += "Parite: " & sec_sDovizCinsi.Text & " Kur: " & sec_Kur.Text
        Printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", kriter, "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Finans Yönetimi-Financial Managment", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Printlink1.CreateDocument(ps)
        ps.PreviewRibbonFormEx.Show()
    End Sub
    Private Sub GridControl1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyDown
        If e.KeyCode = Keys.Escape Then
            If XtraMessageBox.Show(Sorgu_sDil("Editor Ekranindan Cikmak Ýstediginize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                Me.Close()
            End If
        End If
    End Sub
    Private Sub SimpleButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton5.Click
        Dim frm As New frm_tbDovizKurlari
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.ShowDialog()
    End Sub
    Private Sub kur_tcmb()
        Dim tarih As DateTime = DateEdit1.EditValue
        If tarih.DayOfWeek = 0 Then
            tarih = DateAdd(DateInterval.Day, -2, tarih)
        ElseIf tarih.DayOfWeek = 5 Then
            tarih = DateAdd(DateInterval.Day, -1, tarih)
        End If
        Dim i As Integer = 0
        Dim bDevam As Boolean = True
        For i = 0 To 7
            If bDevam = True Then
                Try
                    Dim adres As String = "http://www.tcmb.gov.tr/kurlar/"
                    tarih = DateAdd(DateInterval.Day, -i, tarih)
                    adres &= tarih.ToString("yyyyMM") & _
                  "/" & tarih.ToString("ddMMyyyy") & ".xml"
                    dsDoviz.ReadXml(adres)
                    bDevam = False
                Catch ex As Exception
                End Try
            End If
        Next
        Try
            Dim adres As String = "http://www.tcmb.gov.tr/kurlar/"
            If tarih.DayOfWeek = 1 And Now.Hour < 5 Then
                adres &= tarih.ToString("yyyyMM") & _
           "/" & tarih.ToString("ddMMyyyy") & ".xml"
                dsDoviz.ReadXml(adres)
            ElseIf tarih.DayOfWeek = 1 Then
                tarih = DateAdd(DateInterval.Day, -2, tarih)
                adres &= tarih.ToString("yyyyMM") & _
          "/" & tarih.ToString("ddMMyyyy") & ".xml"
                dsDoviz.ReadXml(adres)
            Else
                adres &= tarih.ToString("yyyyMM") & _
           "/" & tarih.ToString("ddMMyyyy") & ".xml"
                dsDoviz.ReadXml(adres)
            End If
        Catch ex As System.Net.WebException
            tarih = DateAdd(DateInterval.Day, -1, tarih)
            Dim adres As String = "http://www.tcmb.gov.tr/kurlar/"
            adres &= tarih.ToString("yyyyMM") & _
            "/" & tarih.ToString("ddMMyyyy") & ".xml"
            dsDoviz.ReadXml(adres)
            'XtraMessageBox.Show("Bir önceki gün kurlarý Yükleniyor..." & vbCrLf & tarih, MessageBoxIcon.Information)
        Catch ex As Exception
            'XtraMessageBox.Show(ex.Message)
        End Try
        If bDevam = False Then
            'XtraMessageBox.Show("Çekilen Kur Tarihi..." & vbCrLf & tarih, Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Function kur_kontrol_tcmb(ByVal doviz As String, ByVal fiyat As String)
        Dim dr As DataRow
        Dim kontrol_fiyat As Decimal
        For Each dr In dsDoviz.Tables("Currency").Rows
            'MsgBox(dr("Kod") & vbTab & dr("ForexBuying") & vbTab & dr("ForexSelling"))
            If dr("Kod") = doviz Then
                kontrol_fiyat = sorgu_sayi(dr(fiyat), 0)
                If fiyat = "ForexBuying" Then
                    kontrol_fiyat = dr(fiyat)
                ElseIf fiyat = "ForexSelling" Then
                End If
            End If
        Next
        Return kontrol_fiyat
        dr = Nothing
        kontrol_fiyat = Nothing
    End Function
    Private Sub kur_kontrol()
        Dim dr As DataRow
        For Each dr In DS.Tables(0).Rows
            dr("lMerkezBankasiAlisKuru") = kur_kontrol_tcmb(dr("sDovizCinsi"), "ForexBuying")
            dr("lMerkezBankasiSatisKuru") = kur_kontrol_tcmb(dr("sDovizCinsi"), "ForexSelling")
            dr("lEfektifAlisKuru") = kur_kontrol_tcmb(dr("sDovizCinsi"), "BanknoteBuying")
            dr("lEfektifSatisKuru") = kur_kontrol_tcmb(dr("sDovizCinsi"), "BanknoteSelling")
            If sorgu_sayi(dr("lMerkezBankasiAlisKuru"), 0) <> 0 And sorgu_sayi(dr("lAlisKuru"), 0) = 0 Then
                dr("lAlisKuru") = dr("lMerkezBankasiAlisKuru")
            End If
            If sorgu_sayi(dr("lMerkezBankasiSatisKuru"), 0) <> 0 And sorgu_sayi(dr("lSatisKuru"), 0) = 0 Then
                dr("lSatisKuru") = dr("lMerkezBankasiSatisKuru")
            End If
            If dr("lAlisKuru") + dr("lSatisKuru") + dr("lEfektifAlisKuru") + dr("lEfektifSatisKuru") + dr("lMerkezBankasiAlisKuru") + dr("lMerkezBankasiSatisKuru") <> 0 Then
                If sorgu_sDovizCinsi_kontrol(dr("sDovizCinsi"), dteIslemTarihi) = False Then
                    tbDovizKuru_kaydet_duzelt(dr("sDovizCinsi"), dteIslemTarihi, dr("lAlisKuru"), dr("lSatisKuru"), dr("lEfektifAlisKuru"), dr("lEfektifSatisKuru"), dr("lMerkezBankasiAlisKuru"), dr("lMerkezBankasiSatisKuru"), kullanici, Now)
                Else
                    tbDovizKuru_kaydet_yeni(dr("sDovizCinsi"), dteIslemTarihi, dr("lAlisKuru"), dr("lSatisKuru"), dr("lEfektifAlisKuru"), dr("lEfektifSatisKuru"), dr("lMerkezBankasiAlisKuru"), dr("lMerkezBankasiSatisKuru"), kullanici, Now)
                End If
            Else
                If sorgu_sDovizCinsi_kontrol(dr("sDovizCinsi"), dteIslemTarihi) = False Then
                    tbDovizKuru_kaydet_sil(dr("sDovizCinsi"), dteIslemTarihi)
                End If
            End If
        Next
        XtraMessageBox.Show("Tamamlandý", Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub SimpleButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton6.Click
        kur_tcmb()
        kur_kontrol()
    End Sub
End Class