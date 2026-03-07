Imports Microsoft.Win32
Imports DevExpress.XtraEditors
Public Class frm_tbPerakende_Toplu
    Public firmano
    Public donemno
    Public kullanici
    Public connection
    Public nFirmaID As Int64 = 0
    Public nStokID As Int64 = 0
    Public sFirmaKodu As String
    Public sFirmaAciklama As String
    Public lFisNo As Int64 = 0
    Dim cmd As New OleDb.OleDbCommand
    Dim con As New OleDb.OleDbConnection
    Dim dr As DataRow
    Dim ds_tbStokTedarikcisi As DataSet
    Public bFirma As Boolean = False
    Public bTahsilat As Boolean = False
    Private Sub frm_tbStokTedarik_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txt_musterino.Focus()
        txt_musterino.SelectAll()
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
        dataload_DovizCinsi()
        dataload_Depo()
        dataload_Satici()
        If bTahsilat = False Then
            'colsFirmaKodu.Visible = False
            'colsFirmaAciklama.Visible = False
            colsOdemeSekli.Visible = False
        Else
            colsKodu.Visible = False
            colsAciklama.Visible = False
            colnStokID.Visible = False
            colsModel.Visible = False
            colsRenk.Visible = False
            colsBeden.Visible = False
            colsRenkAdi.Visible = False
            colsFiyatTipi.Visible = False
            colnTaksit.Visible = False
            coldteTarihi.Visible = False
            collMiktar.Visible = False
            colsSaticiRumuzu.Visible = False
        End If
        'If bFirma = True And nFirmaID = 0 Then
        '    satir_ekle_firma()
        'ElseIf bFirma = False And nStokID = 0 Then
        '    stok_sec()
        'End If
        'If nFirmaID <> 0 Then
        '    ara()
        'ElseIf nStokID <> 0 Then
        '    ara()
        'End If
    End Sub
    Private Sub ara()
        Label2.Text = Sorgu_sDil("Lütfen Bekleyiniz...", sDil)
        Label2.Refresh()
        dataload_tbStokTedarikcisi(nFirmaID, txt_musterino.Text, "Kodu", "Başlar")
        GridControl1.Focus()
        GridControl1.Select()
        Label2.Text = Sorgu_sDil("Tamamlandı...", sDil)
    End Sub
    Private Sub ara1(txt_musterino)
        Label2.Text = Sorgu_sDil("Lütfen Bekleyiniz...", sDil)
        Label2.Refresh()
        dataload_tbStokTedarikcisi(nFirmaID, txt_musterino, "Kodu", "Başlar")
        GridControl1.Focus()
        GridControl1.Select()
        Label2.Text = Sorgu_sDil("Tamamlandı...", sDil)
    End Sub
    Private Sub gorunum_kaydet()
        If bTahsilat = True Then
            GridView1.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\" & Me.Name.ToString & "\Tahsilat")
        ElseIf bTahsilat = False Then
            GridView1.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\" & Me.Name.ToString & "\Satis")
        End If
        XtraMessageBox.Show(Sorgu_sDil("Görünüm Kaydedildi", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub gorunum_yukle()
        Try
        Catch ex As Exception
        End Try
        Try
            If nFontSize > 0 Then
                Dim sayi As Single = nFontSize
                GridView1.Appearance.Row.Font = New System.Drawing.Font("Tahoma", sayi, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
                GridView1.Appearance.FooterPanel.Font = New System.Drawing.Font("Tahoma", sayi, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
                GridView1.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", sayi, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
                'VGrid_Baslik.Appearance.RecordValue.Font = New System.Drawing.Font("Tahoma", sayi, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
                sayi = Nothing
            End If
        Catch ex As Exception
        End Try
        For Each btn As DevExpress.XtraBars.BarItem In BarManager1.Items
            btn.Caption = Sorgu_sDil(btn.Caption, sDil)
        Next
        For Each clmn As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            clmn.Caption = Sorgu_sDil(clmn.Caption, sDil)
        Next
        SimpleButton1.Text = Sorgu_sDil(SimpleButton1.Text, sDil)
        SimpleButton2.Text = Sorgu_sDil(SimpleButton2.Text, sDil)
        SimpleButton3.Text = Sorgu_sDil(SimpleButton3.Text, sDil)
        If bTahsilat = True Then
            GridView1.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\" & Me.Name.ToString & "\Tahsilat")
        ElseIf bTahsilat = False Then
            GridView1.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\" & Me.Name.ToString & "\Satis")
        End If
    End Sub
    Private Sub dataload_DovizCinsi()
        sec_sOdemeSekli.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sOdemeSekli, sAciklama FROM         tbOdemeSekli ORDER BY sOdemeSekli")).Tables(0) 'DataSet2.Tables(0)
        sec_sFiyatTipi.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sFiyatTipi, sAciklama FROM         tbFiyatTipi where (aktif = 1) and (aktifDepo like '%" & Trim(sDepo) & "%') ORDER BY sFiyatTipi")).Tables(0) 'DataSet2.Tables(0)
    End Sub
    Private Sub dataload_Depo()
        sec_sDepo.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sDepo, sAciklama FROM         tbDepo  Where sDepo <> '' ORDER BY sDepo")).Tables(0) 'DataSet2.Tables(0)
    End Sub
    Private Sub dataload_Satici()
        sec_sSaticiRumuzu.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sSaticiRumuzu, sAdi + ' '+ sSoyadi as sAciklama FROM         tbSatici  Where sSaticiRumuzu <> '' ORDER BY sSaticiRumuzu")).Tables(0) 'DataSet2.Tables(0)
    End Sub
    Private Sub dataload_tbStokTedarikcisi(ByVal nMusteriID As String, ByVal ara As String, ByVal konum As String, ByVal ara_kriter As String)
        Dim kriter = "  "
        lFisNo = ara
        kriter = " Where  tbParekendeToplu.lFisNo = " & lFisNo & " "
        If bFirma = True Then
            ds_tbStokTedarikcisi = sorgu(sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbParekendeToplu.*, tbMusteri.lKodu AS lKodu, tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS sMusteri, tbMusteri.sAdi,tbMusteri.sSoyadi,tbMusteri.sEvAdresi1,tbMusteri.sEvAdresi2,tbMusteri.sVergiDairesi,tbMusteri.sVergiNo,tbStok.sModel,tbStok.sKodu, tbStok.sAciklama AS sStokAciklama, tbStok.sRenk, tbRenk.sRenkAdi AS sRenkAdi, tbStok.sBeden, tbStok.sKavala FROM tbRenk INNER JOIN tbStok ON tbRenk.sRenk = tbStok.sRenk RIGHT OUTER JOIN tbParekendeToplu INNER JOIN tbMusteri ON tbParekendeToplu.nMusteriID = tbMusteri.nMusteriID ON tbStok.nStokID = tbParekendeToplu.nStokID " & kriter & " order by tbParekendeToplu.nSira"))
        Else
            ds_tbStokTedarikcisi = sorgu(sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbParekendeToplu.*, tbMusteri.lKodu AS lKodu, tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS sMusteri, tbMusteri.sAdi,tbMusteri.sSoyadi,tbMusteri.sEvAdresi1,tbMusteri.sEvAdresi2,tbMusteri.sVergiDairesi,tbMusteri.sVergiNo,tbStok.sModel,tbStok.sKodu, tbStok.sAciklama AS sStokAciklama, tbStok.sRenk, tbRenk.sRenkAdi AS sRenkAdi, tbStok.sBeden, tbStok.sKavala FROM tbRenk INNER JOIN tbStok ON tbRenk.sRenk = tbStok.sRenk RIGHT OUTER JOIN tbParekendeToplu INNER JOIN tbMusteri ON tbParekendeToplu.nMusteriID = tbMusteri.nMusteriID ON tbStok.nStokID = tbParekendeToplu.nStokID " & kriter & " order by tbParekendeToplu.nSira"))
        End If
        GridControl1.DataMember = Nothing
        GridControl1.DataSource = ds_tbStokTedarikcisi.Tables(0)
    End Sub
    Private Function sorgu(ByVal query As String) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = query
        cmd.Connection = conn
        conn.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, "TABLE1")
        conn.Close()
        Return DS
        cmd = Nothing
        adapter = Nothing
    End Function
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
    Private Function sorgu_query(ByVal query As String) As String
        query = Replace(query, "*!F", "F0" + firmano.ToString)
        query = Replace(query, "!D", "D000" + donemno.ToString)
        Return query
    End Function
    Private Sub firma_sec(Optional ByVal islem As Integer = 0)
        Dim dr As DataRow
        dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        Dim frm As New frm_firma_liste
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.islemstatus = True
        frm.kullanici = kullanici
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim dr1 As DataRow
            dr1 = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
            nFirmaID = dr1("nFirmaID")
            sFirmaKodu = dr1("sKodu")
            lbl_Firma.Text = Trim(dr1("sAciklama").ToString)
            sFirmaAciklama = Trim(dr1("sAciklama").ToString)
            txt_musterino.EditValue = sFirmaKodu
            dr1 = Nothing
        End If
    End Sub
    Private Sub stok_sec(Optional ByVal islem As Integer = 0)
        Dim dr As DataRow
        dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        Dim frm As New frm_stok
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.islemstatus = True
        frm.kullanici = kullanici
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim dr1 As DataRow
            dr1 = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
            dr("nStokID") = dr1("nStokID")
            dr("sKodu") = dr1("sKodu")
            dr("sStokAciklama") = dr1("sAciklama")
            dr("sRenk") = dr1("sRenk")
            dr("sRenkAdi") = dr1("sRenkAdi")
            dr("sBeden") = dr1("sBeden")
            dr("sKavala") = dr1("sKavala")
            tbStokTedarik_hesapla()
            dr1 = Nothing
        End If
    End Sub
    Private Function tbParekendeToplu_kaydet_yeni(ByVal lFisNo As Int64, ByVal nSira As Int64, ByVal sDepo As String, ByVal sSaticiRumuzu As String, ByVal nMusteriID As Int64, ByVal nStokID As Int64, ByVal sFisTipi As String, ByVal sFiyatTipi As String, ByVal sOdemeSekli As String, ByVal lMiktar As Decimal, ByVal lTutar As Decimal, ByVal nTaksit As Int64, ByVal dteTarihi As DateTime, ByVal sAciklama As String, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal sSonKullaniciAdi As String, ByVal dteSonUpdateTarihi As DateTime, ByVal Bakiye As Decimal) As Int64
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        Dim nKayitID As Decimal = 0
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbParekendeToplu (lFisNo,nSira,sDepo,sSaticiRumuzu,nMusteriID, nStokID, sFisTipi,sFiyatTipi, sOdemeSekli, lMiktar,lTutar,nTaksit,dteTarihi,sAciklama, sKullaniciAdi, dteKayitTarihi, sSonKullaniciAdi, dteSonUpdateTarihi,Bakiye) VALUES     (" & lFisNo & "," & nSira & ",'" & sDepo & "','" & sSaticiRumuzu & "'," & nMusteriID & ", " & nStokID & ", '" & sFisTipi & "','" & sFiyatTipi & "', '" & sOdemeSekli & "', " & lMiktar & "," & lTutar & "," & nTaksit & ",'" & dteTarihi & "','" & sAciklama & "', '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', '" & sSonKullaniciAdi & "', '" & dteSonUpdateTarihi & "', '" & Bakiye & "')")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        nKayitID = cmd.ExecuteScalar
        con.Close()
        Return nKayitID
    End Function
    Private Function tbParekendeToplu_kaydet_yeni1(ByVal lFisNo As Int64) As Int64
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        Dim nKayitID As Decimal = 0
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbParekendeToplu (lFisNo) VALUES     (" & lFisNo & ")")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        nKayitID = cmd.ExecuteScalar
        con.Close()
        Return nKayitID
    End Function

    Private Sub tbParekendeToplu_kaydet_kopyala(ByVal nFirmaID As Int64, ByVal nYeniFirmaID As Int64, Optional ByVal bFirma As Boolean = True)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        If bFirma = True Then
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbProtokol SELECT " & nYeniFirmaID & " AS nFirmaID, nMusteriID, nStokID, sFiyatTipi, sDovizCinsi, sHangiKur, nKdvOrani, lFiyat, nIskontoYuzdesi1, nIskontoYuzdesi2, nIskontoYuzdesi3, nIskontoYuzdesi4 FROM tbProtokol WHERE (nFirmaID = " & nFirmaID & ") and nStokID NOT IN (Select nStokID from tbProtokol where nFirmaID = " & nYeniFirmaID & ")")
            cmd.ExecuteNonQuery()
        Else
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbProtokol SELECT nFirmaID, nMusteriID, " & nYeniFirmaID & ", sFiyatTipi, sDovizCinsi, sHangiKur, nKdvOrani, lFiyat, nIskontoYuzdesi1, nIskontoYuzdesi2, nIskontoYuzdesi3, nIskontoYuzdesi4 FROM tbProtokol WHERE (nStokID = " & nFirmaID & ") and nFirmaID NOT IN (Select nFirmaID from tbProtokol where nStokID = " & nYeniFirmaID & ")")
            cmd.ExecuteNonQuery()
        End If
        con.Close()
    End Sub
    Private Sub tbParekendeToplu_kaydet_degistir(ByVal nKayitID As Int64, ByVal lFisNo As Int64, ByVal nSira As Int64, ByVal sDepo As String, ByVal sSaticiRumuzu As String, ByVal nMusteriID As Int64, ByVal nStokID As Int64, ByVal sFisTipi As String, ByVal sFiyatTipi As String, ByVal sOdemeSekli As String, ByVal lMiktar As Decimal, ByVal lTutar As Decimal, ByVal nTaksit As Int64, ByVal dteTarihi As DateTime, ByVal sAciklama As String, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal sSonKullaniciAdi As String, ByVal dteSonUpdateTarihi As DateTime)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbParekendeToplu SET              nSira= " & nSira & ",sDepo = '" & sDepo & "',sSaticiRumuzu = '" & sSaticiRumuzu & "',nMusteriID = " & nMusteriID & ", nStokID = " & nStokID & ", sFisTipi = '" & sFisTipi & "',sFiyatTipi = '" & sFiyatTipi & "', sOdemeSekli = '" & sOdemeSekli & "', lMiktar = " & lMiktar & ",lTutar = " & lTutar & ",nTaksit = " & nTaksit & ",dteTarihi = '" & dteTarihi & "',sAciklama = '" & sAciklama & "',  sSonKullaniciAdi = '" & sSonKullaniciAdi & "', dteSonUpdateTarihi = '" & dteSonUpdateTarihi & "' Where lFisNo = " & lFisNo & " and nKayitID = '" & nKayitID & "' AND nMusteriID = '" & nMusteriID & "' ")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbParekendeToplu_kaydet_sil(ByVal nKayitID As String, ByVal nMusteriID As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE FROM tbParekendeToplu Where nKayitID = '" & nKayitID & "' AND nMusteriID = '" & nMusteriID & "' ")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Public Function sorgu_ntbStokTedarikcisi(ByVal nMusteriID As String, ByVal lFisNo As String) As Int64
        'kriter = "WHERE (sKodu = '" & kod & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     COUNT(*) AS nKayit FROM         tbParekendeToplu WHERE     (nMusteriID = " & nMusteriID & ") AND (lFisNo = " & lFisNo & ")")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Public Function sorgu_ntbStokTedarikcisiVarmi(ByVal lFisNo As String) As Int64
        'kriter = "WHERE (sKodu = '" & kod & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     COUNT(*) AS nKayit FROM         tbParekendeToplu WHERE     (lFisNo = " & lFisNo & ")")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Public Function sorgu_nSira(ByVal lFisNo As Int64) As Int64
        'kriter = "WHERE (sKodu = '" & kod & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     MAX(nSira) + 1 AS nSira FROM         tbParekendeToplu WHERE     (lFisNo = " & lFisNo & ")")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Private Sub satir_ekle_stok()
        Dim frm As New frm_stok
        frm.islemstatus = True
        frm.connection = connection
        frm.firmano = firmano
        frm.donemno = donemno
        frm.islemstatus = True
        frm.kullanici = kullanici
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim s As String
            Dim arr As Integer()
            Dim i As Integer
            Dim dr1 As DataRow
            Dim dr As DataRow
            arr = frm.GridView1.GetSelectedRows()
            If arr Is Nothing Then
            Else
                Array.Sort(arr)
                For Each i In arr
                    s = i.ToString
                    dr1 = frm.GridView1.GetDataRow(s)
                    If sorgu_ntbStokTedarikcisi(nFirmaID, lFisNo) = 0 Then
                        dr = ds_tbStokTedarikcisi.Tables(0).NewRow
                        dr("lFisNo") = lFisNo
                        dr("nSira") = sorgu_nSira(lFisNo)
                        dr("sDepo") = sDepo
                        dr("sSaticiRumuzu") = ""
                        dr("nMusteriID") = dr1("nMusteriID")
                        dr("nStokID") = nStokID
                        dr("sFiyatTipi") = ""
                        dr("sOdemeSekli") = ""
                        dr("sFisTipi") = ""
                        dr("lMiktar") = 1
                        dr("lTutar") = 0
                        dr("nTaksit") = 0
                        dr("dteTarihi") = Today
                        dr("sAciklama") = ""
                        dr("sKullaniciAdi") = kullaniciadi
                        dr("dteKayitTarihi") = Now
                        dr("sSonKullaniciAdi") = kullaniciadi
                        dr("dteSonUpdateTarihi") = Now
                        dr("nKayitID") = tbParekendeToplu_kaydet_yeni(dr("lFisNo"), dr("nSira"), dr("sDepo"), dr("sSaticiRumuzu"), dr("nMusteriID"), dr("nStokID"), dr("sFisTipi"), dr("sFiyatTipi"), dr("sOdemeSekli"), dr("lMiktar"), dr("lTutar"), dr("nTaksit"), dr("dteTarihi"), dr("sAciklama"), dr("sKullaniciAdi"), dr("dteKayitTarihi"), dr("sSonKullaniciAdi"), dr("dteSonUpdateTarihi"), 0)
                        ds_tbStokTedarikcisi.Tables(0).Rows.Add(dr)
                    End If
                Next
            End If
            ara()
        End If
    End Sub
    Private Sub satir_ekle_stok_kopyala()
        Dim frm As New frm_stok
        frm.islemstatus = True
        frm.connection = connection
        frm.firmano = firmano
        frm.donemno = donemno
        frm.islemstatus = True
        frm.kullanici = kullanici
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim s As String
            Dim arr As Integer()
            Dim i As Integer
            Dim dr1 As DataRow
            arr = frm.GridView1.GetSelectedRows()
            If arr Is Nothing Then
            Else
                Array.Sort(arr)
                For Each i In arr
                    s = i.ToString
                    dr1 = frm.GridView1.GetDataRow(s)
                    'tbParekendeToplu_kaydet_kopyala(nStokID, dr1("nStokID"), False)
                Next
            End If
            dr1 = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
            nStokID = dr1("nStokID")
            sFirmaKodu = dr1("sKodu")
            lbl_Firma.Text = Trim(dr1("sAciklama").ToString)
            sFirmaAciklama = Trim(dr1("sAciklama").ToString)
            txt_musterino.EditValue = sFirmaKodu
            ara()
        End If
    End Sub
    Private Sub satir_ekle_firma()
        Dim frm As New frm_musteri_liste
        frm.islemstatus = True
        frm.connection = connection
        frm.firmano = firmano
        frm.donemno = donemno
        frm.islemstatus = True
        frm.kullanici = kullanici
        frm.Drum = True
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim s As String
            Dim arr As Integer()
            Dim i As Integer
            Dim dr1 As DataRow
            arr = frm.GridView1.GetSelectedRows()
            If arr Is Nothing Then
            Else
                Array.Sort(arr)
                For Each i In arr
                    s = i.ToString
                    dr1 = frm.GridView1.GetDataRow(s)
                    If sorgu_ntbStokTedarikcisi(dr1("nMusteriID"), lFisNo) = 0 Then
                        dr = ds_tbStokTedarikcisi.Tables(0).NewRow
                        dr("lFisNo") = lFisNo
                        dr("nSira") = sorgu_nSira(lFisNo)
                        dr("sDepo") = sDepo
                        dr("sSaticiRumuzu") = ""
                        dr("nMusteriID") = dr1("nMusteriID")
                        dr("nStokID") = nStokID
                        If bTahsilat = True Then
                            dr("sFisTipi") = "OD"
                            dr("sOdemeSekli") = "N"
                        Else
                            dr("sFisTipi") = "P"
                            dr("sOdemeSekli") = ""
                        End If
                        dr("sFiyatTipi") = ""

                        dr("lMiktar") = 1
                            dr("lTutar") = 0
                            dr("nTaksit") = 0
                            dr("dteTarihi") = Today
                            dr("sAciklama") = ""
                            dr("sKullaniciAdi") = kullaniciadi
                            dr("dteKayitTarihi") = Now
                            dr("sSonKullaniciAdi") = kullaniciadi
                        dr("dteSonUpdateTarihi") = Now

                        dr("Bakiye") = dr1("Bakiye")
                            'dr("nKayitID") = tbParekendeToplu_kaydet_yeni(dr("lFisNo"), dr("nSira"), dr("sDepo"), dr("sSaticiRumuzu"), dr("nMusteriID"), dr("nStokID"), dr("sFisTipi"), dr("sFiyatTipi"), dr("sOdemeSekli"), dr("lMiktar"), dr("lTutar"), dr("nTaksit"), dr("dteTarihi"), dr("sAciklama"), dr("sKullaniciAdi"), dr("dteKayitTarihi"), dr("sSonKullaniciAdi"), dr("dteSonUpdateTarihi"), dr("Bakiye"))
                            dr("nKayitID") = tbParekendeToplu_kaydet_yeni(dr("lFisNo"), dr("nSira"), dr("sDepo"), dr("sSaticiRumuzu"), dr("nMusteriID"), dr("nStokID"), dr("sFisTipi"), dr("sFiyatTipi"), dr("sOdemeSekli"), dr("lMiktar"), dr("lTutar"), dr("nTaksit"), dr("dteTarihi"), dr("sAciklama"), dr("sKullaniciAdi"), dr("dteKayitTarihi"), dr("sSonKullaniciAdi"), dr("dteSonUpdateTarihi"), dr("Bakiye"))
                            ds_tbStokTedarikcisi.Tables(0).Rows.Add(dr)
                        End If
                Next
            End If
            ara()
        End If
    End Sub
    Private Sub satir_ekle_firma_kopyala(ByVal lFisNo As Int64)
        Dim dr As DataRow
        For Each dr In ds_tbStokTedarikcisi.Tables(0).Rows
            tbParekendeToplu_kaydet_yeni(lFisNo, dr("nSira"), dr("sDepo"), dr("sSaticiRumuzu"), dr("nMusteriID"), dr("nStokID"), dr("sFisTipi"), dr("sFiyatTipi"), dr("sOdemeSekli"), dr("lMiktar"), dr("lTutar"), dr("nTaksit"), dr("dteTarihi"), dr("sAciklama"), dr("sKullaniciAdi"), dr("dteKayitTarihi"), dr("sSonKullaniciAdi"), dr("dteSonUpdateTarihi"), 0)
        Next
        txt_musterino.Text = txt_sYeniKod.Text
        ara()
    End Sub
    Private Sub satir_ekle_firma_kopyala1(ByVal lFisNo As Int64)
        Dim dr As DataRow

        tbParekendeToplu_kaydet_yeni1(lFisNo)


        ara()
    End Sub
    Private Sub stok_sil()
        If XtraMessageBox.Show(Sorgu_sDil("Seçili Kayıtları Silmek İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim s As String
            Dim arr As Integer()
            Dim i As Integer
            Dim dr1 As DataRow
            Dim satir As String = GridView1.FocusedRowHandle
            arr = GridView1.GetSelectedRows()
            If arr Is Nothing Then
            Else
                Array.Sort(arr)
                For Each i In arr
                    s = i.ToString
                    dr1 = GridView1.GetDataRow(s)
                    tbParekendeToplu_kaydet_sil(dr1("nKayitID"), dr1("nMusteriID"))
                Next
            End If
            s = Nothing
            arr = Nothing
            i = Nothing
            dr1 = Nothing
            'MsgBox(Sorgu_sDil("İşlem Tamamlandı...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            ara()
            GridView1.FocusedRowHandle = satir
            satir = Nothing
        End If
    End Sub
    Private Sub degeryay(ByVal columnkriter As String)
        Dim durum
        Dim sayi = GridView1.RowCount  'kl.Count
        Dim satir = GridView1.FocusedRowHandle 'kl.Position
        Dim TOPLAM = sayi - GridView1.FocusedRowHandle 'kl.Position
        Dim t As Int64
        Dim İ As Integer
        İ = 0
        Dim dr_hareket As DataRow
        Dim dr As DataRow
        dr_hareket = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        durum = dr_hareket("" & columnkriter & "")
        For İ = 1 To TOPLAM
            'dr_hareket = GridView2.GetDataRow(GridView2.FocusedRowHandle)
            'dr_hareket.BeginEdit()
            'dr_hareket("" & columnkriter & "") = durum
            'dr_hareket.EndEdit()
            t += 1
            GridView1.PostEditor()
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            dr("" & columnkriter & "") = durum
            dr.EndEdit()
            tbStokTedarik_hesapla()
            'toplam_hesapla()
            GridView1.FocusedRowHandle += 1
        Next
        GridView1.FocusedRowHandle = satir
        GridView1.GetDataRow(satir)
        durum = Nothing
        sayi = Nothing
        satir = Nothing
        İ = Nothing
    End Sub
    Private Sub tbStokTedarik_hesapla()
        If GridView1.RowCount > 0 Then
            GridView1.PostEditor()
            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            If dr("lMiktar") <= 0 Then
                dr("lMiktar") = 1
            End If
            If dr("nTaksit") <= 0 Then
                dr("nTaksit") = 1
            End If
            dr.EndEdit()
            tbParekendeToplu_kaydet_degistir(dr("nKayitID"), dr("lFisNo"), dr("nSira"), dr("sDepo"), dr("sSaticiRumuzu"), dr("nMusteriID"), dr("nStokID"), dr("sFisTipi"), dr("sFiyatTipi"), dr("sOdemeSekli"), dr("lMiktar"), dr("lTutar"), dr("nTaksit"), dr("dteTarihi"), dr("sAciklama"), dr("sKullaniciAdi"), dr("dteKayitTarihi"), dr("sSonKullaniciAdi"), dr("dteSonUpdateTarihi"))
        End If
    End Sub
    Private Sub stok_duzelt()
        If GridView1.RowCount > 0 Then
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_stok_kart
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.nStokID = dr("nStokID")
            frm.sKodu = dr("sKodu")
            frm.sModel = dr("sModel")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            Dim satir = GridView1.FocusedRowHandle
            ara()
            GridView1.FocusedRowHandle = satir
            satir = Nothing
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub analiz_envanter()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_stok_envanter
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.stokno = dr("nStokId")
            frm.stokkodu = dr("sKodu")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub analiz_hareket_transfer()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_stok_hareketleri_transfer
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            'frm.stokno = dr("nStokId")
            frm.stokkodu = dr("sKodu")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub analiz_stok_hareket()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_stok_hareketleri
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.musterino = dr("sKodu")
            frm.nFirmaID = 0
            frm.sec_firma.Checked = False
            frm.sec_giris.Text = "[Tümü]"
            frm.collGirisFiyat.Visible = False
            frm.collGirisFiyat.OptionsColumn.ShowInCustomizationForm = False
            frm.collCikisFiyat.Visible = False
            frm.collCikisFiyat.OptionsColumn.ShowInCustomizationForm = False
            frm.collBrutFiyat.Visible = False
            frm.collBrutFiyat.OptionsColumn.ShowInCustomizationForm = False
            frm.collBrutTutar.Visible = False
            frm.collBrutTutar.OptionsColumn.ShowInCustomizationForm = False
            frm.colnKdvOrani.Visible = False
            frm.colnKdvOrani.OptionsColumn.ShowInCustomizationForm = False
            frm.collIskontoTutari.Visible = False
            frm.collIskontoTutari.OptionsColumn.ShowInCustomizationForm = False
            frm.colnGirisCikis.Visible = False
            frm.MenuItem16.Enabled = False
            frm.MenuItem17.Enabled = False
            frm.MenuItem20.Enabled = False
            frm.Label1.Text = dr("sAciklama") & vbCrLf & frm.Label1.Text
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub analiz_envanter_model()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_stok_envanter_model
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.modelno = dr("sModel")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub analiz_hareket()
        Dim dr As DataRow
        dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        'stkdll.firmano = firmano
        'stkdll.donemno = donemno
        'stkdll.connection = connection
        'stkdll.stokno = dr("IND")
        'stkdll.rptfiyatanalizi(dr("IND"), 100, dr("MALINCINSI"), 2)
    End Sub
    Private Sub stok_fiyat()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_stok_fiyatlandir
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.nStokID = dr("nStokId")
            frm.sModel = dr("sModel")
            frm.sKodu = dr("sKodu")
            frm.sRenk = dr("sRenk")
            frm.sBeden = dr("sBeden")
            frm.txt_musteriNo.Text = dr("sModel")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
            Dim satir = GridView1.FocusedRowHandle
            ara()
            GridView1.FocusedRowHandle = satir
            satir = Nothing
        End If
    End Sub
    Private Sub stok_satis_detay()
        If GridView1.RowCount > 0 Then
            Dim frm As New frm_stok_cari_satis
            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            frm.status = True
            frm.firmano = 100
            frm.donemno = 1
            frm.connection = connection
            frm.islemstatus = True
            frm.stokno = dr("nAlisverisID")
            frm.fistipi = Trim(dr("sFisTipi").ToString)
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            dr = Nothing
        End If
    End Sub
    Private Sub analiz_musteri_karti()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_musteri_karti
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.musterino = dr("lKodu")
            frm.musteriID = dr("nMusteriID")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub analiz_acik_faturalar_analiz()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_cari_faturalar_acik_analiz
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.musterino = dr("nMusteriID")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub analiz_acik_faturalar()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_cari_faturalar_acik
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.musterino = dr("nMusteriID")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub analiz_iletisim()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_firma_iletisim
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.musterino = dr("nFirmaID")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub analiz_musteri_satislar()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_cari_faturalar_kapatma
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.musterino = dr("lKodu")
            frm.musteriID = dr("nMusteriID")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub analiz_musteri_hareket_ekstre()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_cari_ekstre
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.musterino = dr("lKodu")
            frm.musteriID = dr("nMusteriID")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub lIhtiyac_belirle()
        'If ds_tbStokTedarikcisi.Tables(0).Rows.Count > 0 Then
        'Dim dr As DataRow
        'Dim lIhtiyac As Integer = 0
        'For Each dr In ds_tbStokTedarikcisi.Tables(0).Rows
        '    If dr("lSatilan") > 0 Then
        '        lIhtiyac = (txt_nGun.EditValue * dr("lSatilan")) / dr("nGun")
        '        dr("lIhtiyac") = (lIhtiyac - dr("lMevcut"))
        '        dr("lIhtiyac2") = ((lIhtiyac - dr("lMevcut"))) / dr("nBirimCarpan")
        '    End If
        'Next
        'dr = Nothing
        'lIhtiyac = Nothing
        'MsgBox(Sorgu_sDil("Tamamlandı...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
        'End If
    End Sub
    Private Sub txt_musteriNo_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs)
        firma_sec()
    End Sub
    Private Sub txt_musteriNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Space Then
            firma_sec()
        ElseIf e.KeyCode = Keys.Enter Then
            If Trim(txt_musterino.Text) = "" Then
                firma_sec()
            End If
        End If
    End Sub
    Private Sub GridControl1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyDown
        If e.KeyCode = Keys.Escape Then
            If XtraMessageBox.Show(Sorgu_sDil("Ekranı Kapatmak İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Me.Close()
            End If
        End If
    End Sub
    Private Sub MenuItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txt_musterino.EditValue = ""
        txt_musterino.Focus()
        txt_musterino.SelectAll()
    End Sub
    Private Sub MenuItem16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        satir_ekle_stok()
    End Sub
    Private Sub GridView1_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanged
        If GridView1.RowCount > 0 Then
            GridView1.PostEditor()
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            dr.EndEdit()
            tbStokTedarik_hesapla()
        End If
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
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
            Label2.Text = Sorgu_sDil("Kayıt Sayısı :", sDil) & GridView1.RowCount & " / " & Sorgu_sDil("Satır :", sDil) & GridView1.FocusedRowHandle + 1 & " / " & Sorgu_sDil("Seçili :", sDil) & GridView1.SelectedRowsCount
        ElseIf GridView1.SelectedRowsCount = 1 Then
            Label2.Text = Sorgu_sDil("Kayıt Sayısı :", sDil) & GridView1.RowCount & " / " & Sorgu_sDil("Satır :", sDil) & GridView1.FocusedRowHandle + 1
        Else
            Label2.Text = ""
        End If
    End Sub
    Private Sub MenuItem24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem24.Click
        If nFirmaID = 0 Then
            satir_ekle_firma()
        ElseIf nStokID = 0 Then
            satir_ekle_stok()
        End If
    End Sub
    Private Sub MenuItem27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem27.Click
        txt_musterino.EditValue = ""
        txt_musterino.Focus()
        txt_musterino.SelectAll()
    End Sub
    Private Sub SimpleButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ara()
    End Sub
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        GridView1.ColumnsCustomization()
    End Sub
    Private Sub MenuItem23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem23.Click
        If MenuItem23.Checked = False Then
            GridView1.OptionsView.ShowAutoFilterRow = True
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
            GridView1.OptionsCustomization.AllowFilter = True
            MenuItem23.Checked = True
        ElseIf MenuItem23.Checked = True Then
            GridView1.OptionsView.ShowAutoFilterRow = False
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
            GridView1.OptionsCustomization.AllowFilter = False
            MenuItem23.Checked = True
        End If
    End Sub
    Private Sub MenuItem16_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem16.Click
        analiz_envanter()
    End Sub
    Private Sub MenuItem17_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem17.Click
        stok_duzelt()
    End Sub
    Private Sub MenuItem18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem18.Click
        analiz_stok_hareket()
    End Sub
    Private Sub MenuItem21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem21.Click
        analiz_hareket_transfer()
    End Sub
    Private Sub MenuItem22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem22.Click
        stok_fiyat()
    End Sub
    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        gorunum_kaydet()
    End Sub
    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
        GridView1.OptionsCustomization.AllowFilter = True
    End Sub
    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        GridView1.OptionsView.ShowGroupPanel = True
        GridView1.OptionsCustomization.AllowGroup = True
    End Sub
    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        GridView1.ExpandAllGroups()
    End Sub
    Private Sub MenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem8.Click
        GridView1.CollapseAllGroups()
    End Sub
    Private Sub MenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem9.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        ElseIf Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
    Private Sub MenuItem26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem26.Click
        stok_sil()
    End Sub
    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        printlink1.CreateDocument(ps)
        ps.PreviewRibbonFormEx.Show()
    End Sub
    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        ara()
    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAra.ItemClick
        ara()
    End Sub
    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        If nFirmaID = 0 Then
            satir_ekle_firma()
        ElseIf nStokID = 0 Then
            satir_ekle_stok()
        End If
    End Sub
    Private Sub BarButtonItem4_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        stok_duzelt()
    End Sub
    Private Sub BarButtonItem3_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        stok_sil()
    End Sub
    Private Sub BarButtonItem5_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        analiz_envanter()
    End Sub
    Private Sub BarButtonItem6_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        analiz_stok_hareket()
    End Sub
    Private Sub BarButtonItem7_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem7.ItemClick
        analiz_hareket_transfer()
    End Sub
    Private Sub BarButtonItem8_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem8.ItemClick
        stok_fiyat()
    End Sub
    Private Sub btn_IhtiyacAra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Label2.Text = Sorgu_sDil("Lütfen Bekleyiniz...", sDil)
        Label2.Refresh()
        lIhtiyac_belirle()
        Label2.Text = Sorgu_sDil("Tamamlandı...", sDil)
    End Sub
    Private Sub BarButtonItem9_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem9.ItemClick
        tbSiparisVer(2)
    End Sub
    Private Sub tbSiparisVer(ByVal nSiparisTipi As Integer)
        Dim dr As DataRow
        Dim dr1 As DataRow
        dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        Dim frm As New frm_firma_liste
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.islemstatus = True
        frm.kullanici = kullanici
        Dim nFirmaID As Int64
        Dim sKodu As String = ""
        Dim lSiparisNo As Int64 = 0
        Dim sSatirAciklama As String = ""
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            dr1 = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
            nFirmaID = dr1("nFirmaID")
            sKodu = dr1("sKodu")
            lSiparisNo = sorgu_lSiparisNo(nSiparisTipi)
            'lbl_Firma.Text = dr1("sAciklama")
            'txt_musteriNo.EditValue = sKodu
            dr1 = Nothing
            Dim sayi As Integer = 0
            For Each dr In ds_tbStokTedarikcisi.Tables(0).Rows
                If dr("lIhtiyac") <> 0 Then
                    Dim nSiparisID As Int64 = sorgu_nSiparisID()
                    sSatirAciklama = "Isk1:" & uzunluk_tamamla(FormatNumber(0, 2), 5) & " Isk2:" & uzunluk_tamamla(FormatNumber(0, 2), 5) & " Isk3:" & uzunluk_tamamla(FormatNumber(0, 2), 5) & " Isk4:" & uzunluk_tamamla(FormatNumber(0, 2), 5)
                    tbSiparis_kaydet_yeni(nSiparisID, nSiparisTipi, lSiparisNo, nFirmaID, dr("nStokID"), Today, Today, "", 0, "", "", 1, dr("lIhtiyac"), 0.01, dr("lIhtiyac") * 0.01, "", 0, dr("nKdvOrani"), 0, dr("lIhtiyac") * 0.01, "SA", Now, 0, 0, "", 0, sSatirAciklama, 0, "", 0, 0, "")
                    sayi += 1
                End If
            Next
            If sayi > 0 Then
                Dim frm1 As New frm_tbSiparis
                frm1.firmano = firmano
                frm1.donemno = donemno
                frm1.connection = connection
                frm1.dteSiparisTarihi = Today
                frm1.lSiparisNo = lSiparisNo
                frm1.nFirmaID = nFirmaID
                'frm.txt_musteriNo.EditValue = dr("sFirmaKodu")
                frm1.sSiparisiAlan = ""
                frm1.sSiparisiVeren = ""
                frm1.nSiparisTipi = nSiparisTipi
                frm1.kullanici = kullanici
                frm1.islemstatus = True
                If yetki_kontrol(kullanici, frm1.Name) = True Then
                    frm1.ShowDialog()
                End If
                frm1.Close()
                frm1.Dispose()
                frm1 = Nothing
            End If
        End If
    End Sub
    Private Function uzunluk_tamamla(ByVal deger As String, ByVal uzunluk As Int64, Optional ByVal simge As String = "0") As String
        deger = FormatNumber(deger, 2)
        If Len(deger) < uzunluk Then
            Dim fark As Integer = uzunluk - Len(deger)
            Dim i As Integer
            For i = 1 To fark
                deger = deger.Insert(0, simge)
            Next
        End If
        Return deger
    End Function
    Public Function sorgu_nSiparisID() As Int64
        Dim kriter As String = ""
        'kriter = "WHERE (sKodu = '" & kod & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     TOP 1 ISNULL(nSiparisID + 1, 1) AS nSiparisID FROM         tbSiparis ORDER BY nSiparisID DESC")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Public Function sorgu_lSiparisNo(ByVal nSiparisTipi As Integer) As Int64
        Dim kriter As String = ""
        'kriter = "WHERE (sKodu = '" & kod & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        If nSiparisTipi = 1 Then
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(lSonSiparisNo,1) as lSiparisNo FROM         tbParamAlSiparis")
        ElseIf nSiparisTipi = 2 Then
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(lSonSiparisNo,1) as lSiparisNo FROM         tbParamVerSiparis")
        ElseIf nSiparisTipi = 3 Then
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(lSonSiparisNo,1) as lSiparisNo FROM         tbParamVerSiparis")
        ElseIf nSiparisTipi = 4 Then
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(lSonSiparisNo,1) as lSiparisNo FROM         tbParamVerSiparis")
        Else
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(lSonSiparisNo,1) as lSiparisNo FROM         tbParamVerSiparis")
        End If
        Dim kayitsayisi = cmd.ExecuteScalar
        If kayitsayisi = 0 Then
            kayitsayisi = 1
        End If
        Return kayitsayisi
    End Function
    Private Sub tbSiparis_kaydet_yeni(ByVal nSiparisID As Int64, ByVal nSiparisTipi As Int64, ByVal lSiparisNo As Int64, ByVal nFirmaID As Int64, ByVal nStokID As Int64, ByVal dteSiparisTarihi As DateTime, ByVal dteTeslimTarihi As DateTime, ByVal sSiparisIslem As String, ByVal nReceteNo As Int64, ByVal sSiparisiAlan As String, ByVal sSiparisiVeren As String, ByVal sFiyatTipi As String, ByVal lMiktari As Decimal, ByVal lFiyati As Decimal, ByVal lTutari As Decimal, ByVal sAsortiTipi As String, ByVal sAsortiMiktari As String, ByVal nKdvOrani As Int64, ByVal nIskontoYuzdesi As Int64, ByVal lIskontosuzTutari As Decimal, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal bKapandimi As Integer, ByVal lReserveMiktari As Decimal, ByVal sHangiUygulama As String, ByVal nPartiID As Int64, ByVal sSatirAciklama As String, ByVal nValorGun As Int64, ByVal sDovizCinsi As String, ByVal lDovizFiyati As Decimal, ByVal lDovizKuru As Decimal, ByVal sSaticiRumuzu As String)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        'sSiparisiAlan = degeruzunlukkontrol(sSiparisiAlan, 30).ToString + degeruzunlukkontrol(sSiparisiVeren, 30).ToString
        'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbSiparis (nSiparisID, nSiparisTipi, lSiparisNo, nFirmaID, nStokID, dteSiparisTarihi, dteTeslimTarihi, sSiparisIslem, nReceteNo, sSiparisiAlan, sSiparisiVeren, sFiyatTipi, lMiktari, lFiyati, lTutari, sAsortiTipi, sAsortiMiktari, nKdvOrani, nIskontoYuzdesi, lIskontosuzTutari, sKullaniciAdi, dteKayitTarihi, bKapandimi, lReserveMiktari, sHangiUygulama, nPartiID, sSatirAciklama, nValorGun, sDovizCinsi, lDovizFiyati, lDovizKuru,sSaticiRumuzu) VALUES     (" & nSiparisID & ", " & nSiparisTipi & ", " & lSiparisNo & ", " & nFirmaID & ", " & nStokID & ", '" & dteSiparisTarihi & "', '" & dteTeslimTarihi & "', '" & sSiparisIslem & "', " & nReceteNo & ", '" & sSiparisiAlan & "', '" & sSiparisiVeren & "', '" & sFiyatTipi & "', " & lMiktari & ", " & lFiyati & ", " & lTutari & ", '" & sAsortiTipi & "', " & sAsortiMiktari & ", " & nKdvOrani & ", " & nIskontoYuzdesi & ", " & lIskontosuzTutari & ", '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', " & bKapandimi & ", " & lReserveMiktari & ", '" & sHangiUygulama & "', " & nPartiID & ", '" & sSatirAciklama & "', " & nValorGun & ", '" & sDovizCinsi & "', " & lDovizFiyati & ", " & lDovizKuru & ",'" & sSaticiRumuzu & "')")
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbSiparis (nSiparisTipi, lSiparisNo, nFirmaID, nStokID, dteSiparisTarihi, dteTeslimTarihi, sSiparisIslem, nReceteNo, sSiparisiAlan, sSiparisiVeren, sFiyatTipi, lMiktari, lFiyati, lTutari, sAsortiTipi, sAsortiMiktari, nKdvOrani, nIskontoYuzdesi, lIskontosuzTutari, sKullaniciAdi, dteKayitTarihi, bKapandimi, lReserveMiktari, sHangiUygulama, nPartiID, sSatirAciklama, nValorGun, sDovizCinsi, lDovizFiyati, lDovizKuru,sSaticiRumuzu) VALUES (" & nSiparisTipi & ", " & lSiparisNo & ", " & nFirmaID & ", " & nStokID & ", '" & dteSiparisTarihi & "', '" & dteTeslimTarihi & "', '" & sSiparisIslem & "', " & nReceteNo & ", '" & sSiparisiAlan & "', '" & sSiparisiVeren & "', '" & sFiyatTipi & "', " & lMiktari & ", " & lFiyati & ", " & lTutari & ", '" & sAsortiTipi & "', " & sAsortiMiktari & ", " & nKdvOrani & ", " & nIskontoYuzdesi & ", " & lIskontosuzTutari & ", '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', " & bKapandimi & ", " & lReserveMiktari & ", '" & sHangiUygulama & "', " & nPartiID & ", '" & sSatirAciklama & "', " & nValorGun & ", '" & sDovizCinsi & "', " & lDovizFiyati & ", " & lDovizKuru & ",'" & sSaticiRumuzu & "')")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub BarButtonItem10_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem10.ItemClick
        tbSiparisVer(1)
    End Sub
    Private Sub analiz_Firma_karti()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_firma_kart
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.sKodu = dr("sFirmaKodu")
            frm.nFirmaID = dr("nFirmaID")
            frm.kullanici = kullanici
            frm.sModul = "Cari"
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
                Dim satir = GridView1.FocusedRowHandle
                ara()
                GridView1.FocusedRowHandle = satir
                satir = Nothing
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub analiz_cari_hareket()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_cari_hareketler_ozet
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.musterino = dr("sFirmaKodu")
            frm.kullanici = kullanici
            'frm.sDovizCinsi = dr("sDovizCinsi")
            If yetki_kontrol(kullanici, frm.Name) = True Then
                If yetki_kontrol(kullanici, "frm_firma_liste_hesapTuru_" & Trim(CariHesapTuruSorgula(dr("sFirmaKodu")))) = True Then
                    frm.ShowDialog()
                End If
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub MenuItem19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        analiz_Firma_karti()
    End Sub
    Private Sub MenuItem13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        analiz_cari_hareket()
    End Sub
    Private Sub MenuItem14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem14.Click
        If GridView1.RowCount > 0 Then
            If XtraMessageBox.Show(Sorgu_sDil("[" & GridView1.FocusedColumn().Caption & "] Kolonundaki verileri Aşağı Doğru Yaymak istediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                'info = False
                Cursor.Current = Cursors.WaitCursor
                Cursor.Show()
                degeryay(GridView1.FocusedColumn().FieldName)
                'info = True
                Cursor.Current = Cursors.Default
                Cursor.Hide()
            End If
        End If
    End Sub
    Public Sub calc()
        Dim frm As New frm_calc
        If frm.ShowDialog = DialogResult.OK Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            If GridView1.FocusedColumn.OptionsColumn.AllowEdit = True Then
                dr(GridView1.FocusedColumn().FieldName) = frm.CalcEdit1.EditValue
                tbStokTedarik_hesapla()
            End If
        End If
        frm.Close()
        frm = Nothing
    End Sub
    Private Sub MenuItem25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem25.Click
        calc()
    End Sub
    Private Sub MenuItem29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem29.Click
        GroupControl6.Visible = True
        txt_sYeniKod.Focus()
        txt_sYeniKod.SelectAll()
        If bFirma = True Then
            satir_ekle_firma_kopyala(lFisNo)
        Else
            satir_ekle_stok_kopyala()
        End If
    End Sub
    Private Sub MenuItem30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem30.Click
        stok_sec()
    End Sub
    Private Sub MenuItem32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem32.Click
        analiz_musteri_hareket_ekstre()
    End Sub
    Private Sub MenuItem31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem31.Click
        analiz_musteri_karti()
    End Sub
    Private Sub MenuItem13_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem13.Click
        analiz_acik_faturalar_analiz()
    End Sub
    Private Sub SimpleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton4.Click
        If XtraMessageBox.Show("Toplu Entegrasyon İşlemine Başlamak İstediğinize Emin misiniz...?", Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Faturala("K")
        End If
    End Sub
    Private Sub Faturala(ByVal sFisTipi As String)
        Dim dr As DataRow
        For Each dr In ds_tbStokTedarikcisi.Tables(0).Rows
            If dr("lTutar") <> 0 Then
                Dim sKasiyerRumuzu = "VC"
                If Trim(dr("sFisTipi")) <> "OD" Then
                    Dim nAlisVerisID As String = ""
                    Dim dteFisTarihi = Today
                    Dim lFaturaNo = 0
                    Dim nMusteriID = 0
                    Dim sAdi = dr("sAdi")
                    Dim sSoyadi = dr("sSoyadi")
                    Dim sMagaza = dr("sDepo")
                    'Dim sKasiyerRumuzu = sKasiyerRumuzu
                    'Dim sKasiyer = sKasiyer
                    Dim sHareketTipi = ""
                    Dim nKasaNo = 1
                    Dim sAdres1 As String = dr("sEvAdresi1")
                    Dim sAdres2 As String = dr("sEvAdresi2")
                    nMusteriID = dr("nMusteriID") 'sorgu_nfirmaID(dr_baslik("lKodu"))
                    If nAlisVerisID = "" Then
                        nAlisVerisID = sorgu_nAlisVerisID(sMagaza)
                        lFaturaNo = sorgu_lFaturaNo(sMagaza)
                        sHareketTipi = sorgu_sHareketTipi(sMagaza)
                        tbAlisVeris_kaydet_yeni(sMagaza & nAlisVerisID.ToString, sFisTipi, dteFisTarihi, 3, lFaturaNo, nMusteriID, sMagaza, sKasiyerRumuzu, sAdi, sSoyadi, dr("lMiktar"), dr("lTutar"), 0, 0, 0, 0, dr("lTutar"), 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "", dr("lTutar"), sHareketTipi, 0, nKasaNo, kullanici, Now, ygeneltoplam(dr("lTutar")))
                        tbAvSirano_degistir(1, nAlisVerisID, sMagaza)
                        lFaturaNo_degistir(lFaturaNo, sMagaza)
                        nAlisVerisID = sMagaza & nAlisVerisID.ToString
                        Dim kayitsayisi = sorgu_tbAlisVerisAdres_kontrol(nAlisVerisID)
                        If kayitsayisi = 0 Then
                            tbAlisVerisAdres_kaydet_yeni(nAlisVerisID, "", sAdres1, sAdres2, "", "", "Türkiye", "", dr("sVergiDairesi"), dr("sVergiNo"), "")
                        Else
                        End If
                    End If
                    If Trim(dr("sFisTipi")) = "K" Or Trim(dr("sFisTipi")) = "P" Then
                        Dim nIslemID As Int64 = sorgu_nStokIslemID()
                        Dim nStokID As Int64 = dr("nStokID")
                        Dim sOdemeKodu As String = ""
                        Dim lMiktar As Decimal = dr("lMiktar")
                        Dim lCikisFiyat As Decimal = dr("lTutar") / lMiktar
                        Dim lCikisTutar As Decimal = dr("lTutar")
                        Dim nKdvOrani As Decimal = 0
                        Dim lBrutFiyat As Decimal = lCikisFiyat
                        Dim lBrutTutar As Decimal = lCikisTutar
                        Dim sFiyatTipi As String = dr("sFiyatTipi")
                        nStokID = dr("nStokID")
                        nIslemID = tbStokFisidetay_kaydet_yeni(nIslemID, nStokID, dteFisTarihi, 0, nMusteriID, sFisTipi, dteFisTarihi, lFaturaNo, 3, sMagaza, 0, sFisTipi, sKasiyerRumuzu, "", sOdemeKodu, dteFisTarihi, 0, 0, 0, 0, 0, lMiktar, 0, lCikisFiyat, lCikisTutar, sFiyatTipi, lBrutFiyat, lBrutTutar, 0, 0, 0, 0, 0, "", 0, "", 0, "", "", nKdvOrani, 0, dr("sAciklama"), sHareketTipi, 0, kullanici, Now, "", 0, 0, "", 0, 0, 0, "", nAlisVerisID, 0, "", "", sFisTipi, 0, 0, 0, 0, kullanici, Now)
                        fis_detay_fisno_degistir(nIslemID)
                    ElseIf Trim(dr("sFisTipi")) = "SK" Or Trim(dr("sFisTipi")) = "SP" Then
                        Dim nSiparisID As Int64 = sorgu_nSiparisID(sMagaza)
                        Dim nStokID As Int64 = dr("nStokID")
                        Dim sOdemeKodu As String = ""
                        Dim lMiktar As Decimal = dr("lMiktar")
                        Dim lCikisFiyat As Decimal = dr("lTutar") / lMiktar
                        Dim lCikisTutar As Decimal = dr("lTutar")
                        Dim nKdvOrani As Decimal = 0
                        Dim lBrutFiyat As Decimal = lCikisFiyat
                        Dim lBrutTutar As Decimal = lCikisTutar
                        Dim sFiyatTipi As String = dr("sFiyatTipi")
                        tbAlisVerisSiparis_kaydet_yeni(nAlisVerisID, sMagaza, nSiparisID, 3, nStokID, sKasiyerRumuzu, dr("sSaticiRumuzu"), sOdemeKodu, 0, sFiyatTipi, lMiktar, lBrutFiyat, lBrutTutar, 0, 0, lCikisFiyat, lCikisTutar, nKdvOrani, "", 0, DateAdd(DateInterval.Day, 1, dteFisTarihi), "01/01/1900", 0, 0, dr("sAciklama").ToString, 0, 0, 0, "", 0, 0, kullanici, Now, "01/01/1900")
                        tbAvSirano_degistir(5, nSiparisID, sMagaza)
                    End If
                    tbTaksit_ekle_toplu(sMagaza, nAlisVerisID, dr("dteTarihi"), dr("nTaksit"), "Ay", dr("lTutar") / dr("nTaksit"), dr("lTutar"))
                Else
                    Dim ds_taksit As DataSet = tbTaksit(dr("nMusteriID"))
                    Dim tutar As Decimal = 0
                    Dim lOdemeTutar As Decimal = 0
                    Dim lKur As Decimal = 0
                    Dim lDovizTutar As Decimal = 0
                    Dim nOdemeID As Int64 = 0
                    Dim sMagaza As String = dr("sDepo")
                    Dim lMakbuzNo As Int64 = sorgu_lMakbuzNo(sMagaza, 2)
                    Dim lToplamTutar As Decimal = 0
                    lOdemeTutar = dr("lTutar")
                    Dim dr1 As DataRow
                    If lOdemeTutar > 0 Then
                        For Each dr1 In ds_taksit.Tables(0).Rows
                            If dr1("KALAN") > 0 And lOdemeTutar > 0 Then
                                If lOdemeTutar > dr1("KALAN") Then
                                    tutar = dr1("KALAN")
                                    lOdemeTutar -= dr1("KALAN")
                                    dr1("KALAN") = 0
                                ElseIf lOdemeTutar = dr1("KALAN") Then
                                    tutar = dr1("KALAN")
                                    lOdemeTutar -= dr1("KALAN")
                                    dr1("KALAN") = 0
                                ElseIf lOdemeTutar < dr1("KALAN") Then
                                    tutar = lOdemeTutar 'dr("KALAN") - lOdemeTutar
                                    lOdemeTutar = 0
                                    dr1("KALAN") = dr1("KALAN") - lOdemeTutar
                                End If
                                lToplamTutar += tutar
                                nOdemeID = sorgu_nOdemeID(sMagaza)
                                'dr1("dteKayitTarihi") = Now
                                If lKur <> 0 Then
                                    lDovizTutar = tutar / lKur
                                Else
                                    lDovizTutar = 0
                                End If
                                tbOdeme_kaydet_yeni(sMagaza & nOdemeID.ToString, dr1("nAlisVerisID"), dr("sOdemeSekli"), 2, sKasiyerRumuzu, Today, Today, tutar, "", 0, lMakbuzNo, lMakbuzNo, dr1("nTaksitID"), "", 0, 1, dr("sAciklama"), kullaniciadi, Now, sMagaza)
                                tbAvSirano_degistir(2, nOdemeID, sMagaza)
                                lMakbuzNo_degistir(lMakbuzNo, sMagaza)
                            End If
                        Next
                    End If
                End If
            End If
        Next
        XtraMessageBox.Show(Sorgu_sDil("İşlem Başarıyla Tamamlandı...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
        'fatura_detay(nAlisVerisID, sFisTipi)
        'ara()
    End Sub
    Private Sub tbOdeme_kaydet_yeni(ByVal nOdemeID As String, ByVal nAlisverisID As String, ByVal sOdemeSekli As String, ByVal nOdemeKodu As Int64, ByVal sKasiyerRumuzu As String, ByVal dteOdemeTarihi As DateTime, ByVal dteValorTarihi As DateTime, ByVal lOdemeTutar As Decimal, ByVal sDovizCinsi As String, ByVal lDovizTutar As Decimal, ByVal lMakbuzNo As String, ByVal lOdemeNo As String, ByVal nTaksitID As String, ByVal nIadeAlisverisID As String, ByVal bMuhasebeyeIslendimi As Byte, ByVal nKasaNo As Int64, ByVal sKartNo As String, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal sMagaza As String)
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY INSERT INTO tbOdeme                       (nOdemeID, nAlisverisID, sOdemeSekli, nOdemeKodu, sKasiyerRumuzu, dteOdemeTarihi, dteValorTarihi, lOdemeTutar, sDovizCinsi, lDovizTutar, lMakbuzNo, lOdemeNo, nTaksitID, nIadeAlisverisID, bMuhasebeyeIslendimi, nKasaNo, sKartNo, sKullaniciAdi, dteKayitTarihi, sMagaza) VALUES     ('" & nOdemeID & "', '" & nAlisverisID & "', '" & sOdemeSekli & "', " & nOdemeKodu & ", '" & sKasiyerRumuzu & "', '" & dteOdemeTarihi & "', '" & dteValorTarihi & "', " & lOdemeTutar & ", '" & sDovizCinsi & "', " & lDovizTutar & ", " & lMakbuzNo & ", " & lOdemeNo & ", '" & nTaksitID & "', '" & nIadeAlisverisID & "', " & bMuhasebeyeIslendimi & ", " & nKasaNo & ", '" & sKartNo & "', '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', '" & sMagaza & "')")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Public Function sorgu_nOdemeID(ByVal sDepo As String) As Int64
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query(" SELECT nSonID + 1 AS nSonID FROM tbAVSiraNo WHERE (sDepo = '" & sDepo & "') AND (nSiraIndex = 2)")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Public Function sorgu_lMakbuzNo(ByVal sDepo As String, ByVal nOdemeKodu As Integer) As Int64
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SELECT     MAX(lMakbuzNo) as lMakbuzNo FROM         tbOdeme WHERE     (sMagaza = '" & sDepo & "') and nOdemeKodu=" & nOdemeKodu & "")
        Dim kayitsayisi = sorgu_sayi(cmd.ExecuteScalar, 0) + 1
        Return kayitsayisi
    End Function
    Public Function sorgu_lMakbuzNo_varmi(ByVal sDepo As String, ByVal nAlisVerisID As String) As Int64
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SELECT     MAX(lMakbuzNo) AS lMakbuzNo FROM         tbOdeme WHERE     (sMagaza = '" & sDepo & "') and (nOdemeKodu = 1) AND (nAlisverisID = '" & nAlisVerisID & "')")
        Dim kayitsayisi = sorgu_sayi(cmd.ExecuteScalar, 0)
        Return kayitsayisi
    End Function
    Private Sub lMakbuzNo_degistir(ByVal nSonID As Int64, ByVal sDepo As String)
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        nSonID += 1
        cmd.CommandText = sorgu_query(" UPDATE    tbStokFisNolar SET              lPerakendeFatura1 ='" & nSonID & "' WHERE     (sDepo = '" & sDepo & "')")
        cmd.ExecuteNonQuery()
        conn.Close()
    End Sub
    Public Function tbTaksit(ByVal nMusteriID As Int64) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbMusteri.nMusteriID, tbMusteri.lKodu AS kodu, ISNULL(SUM(tbTaksit.lTutari), 0) AS TUTAR, ISNULL(SUM(tbOdeme.odeme), 0) AS TAHSILAT, ISNULL(ISNULL(SUM(tbTaksit.lTutari), 0) - ISNULL(SUM(tbOdeme.odeme), 0), 0) AS KALAN, MONTH(tbTaksit.dteTarihi) AS AY, YEAR(tbTaksit.dteTarihi) AS YIL, tbTaksit.dteTarihi, tbAlisVeris.sFisTipi, tbAlisVeris.dteFaturaTarihi, tbAlisVeris.lFaturaNo, tbAlisVeris.lToplamMiktar, tbAlisVeris.lPesinat, tbAlisVeris.lNetTutar, tbAlisVeris.sYaziIle, tbAlisVeris.nKasaNo, tbAlisVeris.sKasiyerRumuzu, tbAlisVeris.dteKayitTarihi, tbAlisVeris.nAlisverisID, tbTaksit.nTaksitID,tbMusteri.sAdi, tbMusteri.sSoyadi,tbAlisVeris.sAlisverisYapanAdi, tbAlisVeris.sAlisverisYapanSoyadi,ROUND(CAST(GETDATE() - (CAST(tbTaksit.dteTarihi AS INT) + 1) AS FLOAT), 0) AS GECIKME FROM (SELECT isnull(SUM(lOdemeTutar) , 0) AS odeme , nTaksitId FROM tbOdeme GROUP BY nTaksitId) tbOdeme RIGHT OUTER JOIN tbTaksit INNER JOIN tbAlisVeris ON tbTaksit.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID ON tbOdeme.nTaksitId = tbTaksit.nTaksitID WHERE (tbMusteri.nMusteriID = " & nMusteriID & ") GROUP BY tbMusteri.nMusteriID, tbMusteri.lKodu, tbTaksit.dteTarihi, tbAlisVeris.sFisTipi, tbAlisVeris.dteFaturaTarihi, tbAlisVeris.lFaturaNo,tbAlisVeris.sAlisverisYapanAdi, tbAlisVeris.sAlisverisYapanSoyadi, tbAlisVeris.lToplamMiktar, tbAlisVeris.lPesinat, tbAlisVeris.lNetTutar, tbAlisVeris.sYaziIle, tbAlisVeris.nKasaNo, tbAlisVeris.sKasiyerRumuzu, tbAlisVeris.dteKayitTarihi, tbMusteri.sAdi, tbMusteri.sSoyadi,  tbAlisVeris.nAlisverisID, tbTaksit.nTaksitID HAVING (ISNULL(ISNULL(SUM(tbTaksit.lTutari), 0) - ISNULL(SUM(tbOdeme.odeme), 0), 0) <> 0) ORDER BY tbTaksit.dteTarihi")
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "DATATABLE1")
        conn.Close()
        Return Datastoklar1
    End Function
    Private Sub tbTaksit_ekle_toplu(ByVal sMagaza As String, ByVal nAlisVerisID As String, ByVal dteBaslangic As DateTime, ByVal TaksitSayisi As Int64, ByVal sAralik As String, ByVal TaksitTutari As Decimal, ByVal lKalanTutar As Decimal)
        Dim i As Integer
        Dim dteTarihi As DateTime
        Dim nTaksitID As String = ""
        For i = 1 To TaksitSayisi
            If lKalanTutar > 0 Then
                If TaksitTutari > lKalanTutar Then
                    TaksitTutari = lKalanTutar
                End If
                'dr = ds_taksit.Tables(0).NewRow
                If i > 1 Then
                    If sAralik = "Gün" Then
                        dteTarihi = DateAdd(DateInterval.Day, 1, dteTarihi)
                    ElseIf sAralik = "Hafta" Then
                        dteTarihi = DateAdd(DateInterval.Day, 7, dteTarihi)
                    ElseIf sAralik = "Ay" Then
                        dteTarihi = DateAdd(DateInterval.Month, 1, dteTarihi)
                    ElseIf sAralik = "3Ay" Then
                        dteTarihi = DateAdd(DateInterval.Quarter, 1, dteTarihi)
                    ElseIf sAralik = "Yıl" Then
                        dteTarihi = DateAdd(DateInterval.Year, 1, dteTarihi)
                    End If
                    'dteTarihi = DateAdd(DateInterval.Month, 1, dteTarihi)
                Else
                    dteTarihi = dteBaslangic
                End If
                nTaksitID = sorgu_nTaksitID(sMagaza)
                Dim sTaksitID As String = sMagaza & nTaksitID
                tbTaksit_kaydet_yeni(sTaksitID, nAlisVerisID, dteTarihi, TaksitTutari)
                tbAvSirano_degistir(3, nTaksitID, sMagaza)
                lKalanTutar = lKalanTutar - TaksitTutari
            End If
        Next
        'txt_sayi.EditValue = 1
        'txt_tutar.EditValue = 0
    End Sub
    Private Sub tbTaksit_kaydet_yeni(ByVal nTaksitID As String, ByVal nAlisverisID As String, ByVal dteTarihi As String, ByVal lTutari As Decimal)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbTaksit (nTaksitID, nAlisverisID, dteTarihi, lTutari) VALUES     ('" & nTaksitID & "', '" & nAlisverisID & "', '" & dteTarihi & "', " & lTutari & ")")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Public Function sorgu_nStokIslemID() As Int64
        Dim kriter As String = ""
        'kriter = "WHERE (sKodu = '" & kod & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = connection
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     TOP 1 ISNULL(nIslemID + 1, 0) AS nStokIslemID  FROM         tbStokFisiDetayi " & kriter & " ORDER BY nIslemID DESC")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
        cmd = Nothing
        adapter = Nothing
    End Function
    Public Function sorgu_nSiparisID(ByVal sMagazaKodu As String) As Int64
        Dim kriter As String = ""
        'kriter = "WHERE (sKodu = '" & kod & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = connection
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(MAX(nSiparisID), 0) + 1 AS nSiparisID FROM         tbAlisverisSiparis Where sMagazaKodu ='" & sMagazaKodu & "'")
        Dim kayitsayisi = cmd.ExecuteScalar
        If kayitsayisi = 0 Then
            kayitsayisi = 1
        End If
        Return kayitsayisi
        cmd = Nothing
        adapter = Nothing
    End Function
    Public Function sorgu_nAlisVerisID(ByVal sDepo As String) As Int64
        'kriter = "WHERE (sKodu = '" & kod & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = connection
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT nSonID + 1 AS nSonID FROM tbAVSiraNo WHERE (sDepo = '" & sDepo & "') AND (nSiraIndex = 1)")
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     TOP 1 ISNULL(REPLACE(nAlisverisID, '" & sDepo & "', ''), 0) + 1 AS nSonID FROM         tbAlisVeris WHERE     (nAlisVerisID  like '" & sDepo & "%') ORDER BY CAST(ISNULL(REPLACE(nAlisverisID, '" & sDepo & "', ''), 0) AS DECIMAL) DESC")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
        cmd = Nothing
        adapter = Nothing
    End Function
    Public Function sorgu_nTaksitID(ByVal sDepo As String) As Int64
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT nSonID + 1 AS nSonID FROM tbAVSiraNo WHERE (sDepo = '" & sDepo & "') AND (nSiraIndex = 3)")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Public Function sorgu_lFaturaNo(ByVal sDepo As String) As Int64
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     TOP 1 ISNULL(lFaturaNo, 0) + 1 AS nSonID FROM         tbAlisVeris WHERE     (sMagaza = '" & sDepo & "') AND (nGirisCikis = 3) AND (sFisTipi IN ('K', 'P')) ORDER BY lFaturaNo DESC")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
        cmd = Nothing
        adapter = Nothing
    End Function
    Public Function sorgu_sHareketTipi(ByVal sDepo As String) As String
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(sDefaultHareketTipi,'') as sHareketTipi FROM         tbParamAlisVeris WHERE     (sMagazaKodu = '" & sDepo & "')")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
        cmd = Nothing
        adapter = Nothing
    End Function
    Private Sub tbAvSirano_degistir(ByVal nSiraIndex As Integer, ByVal nSonID As Int64, ByVal sDepo As String)
        'kriter = "WHERE (sFisTipi = '" & sFistipi & "') and (dteFisTarihi = '" & dteFisTarihi & "') and (lFisNo = '" & lFisno & "') and (nFirmaID= '" & nFirmaID & "') and (nGirisCikis = '" & nGirisCikis & "')  "
        'sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbFirmaHareketi " & kriter & ""))
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbAvSiraNo SET              nSonID = '" & nSonID & "' where nSiraIndex = " & nSiraIndex & " and sDepo = '" & sDepo & "'")
        cmd.ExecuteNonQuery()
        conn.Close()
        cmd = Nothing
        adapter = Nothing
    End Sub
    Private Sub lFaturaNo_degistir(ByVal nSonID As Int64, ByVal sDepo As String)
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbStokFisNolar SET              lPerakendeFatura1 ='" & nSonID & "' WHERE     (sDepo = '" & sDepo & "')")
        cmd.ExecuteNonQuery()
        conn.Close()
    End Sub
    Public Function sorgu_tbAlisVerisAdres_kontrol(ByVal nAlisVerisID As String) As Int64
        Dim kriter As String = ""
        kriter = "WHERE (nAlisVerisID = '" & nAlisVerisID & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = connection
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(*), 0) AS KAYIT FROM         tbAlisVerisAdres " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
        cmd = Nothing
        adapter = Nothing
    End Function
    Private Sub tbAlisVeris_kaydet_yeni(ByVal nAlisverisID As String, ByVal sFisTipi As String, ByVal dteFaturaTarihi As DateTime, ByVal nGirisCikis As Int64, ByVal lFaturaNo As String, ByVal nMusteriID As Int64, ByVal sMagaza As String, ByVal sKasiyerRumuzu As String, ByVal sAlisverisYapanAdi As String, ByVal sAlisverisYapanSoyadi As String, ByVal lToplamMiktar As Decimal, ByVal lMalBedeli As Decimal, ByVal lMalIskontoTutari As Decimal, ByVal nDipIskontoYuzdesi As Decimal, ByVal lDipIskontoTutari As Decimal, ByVal nKdvOrani1 As Decimal, ByVal lKdvMatrahi1 As Decimal, ByVal lKdv1 As Decimal, ByVal nKdvOrani2 As Decimal, ByVal lKdvMatrahi2 As Decimal, ByVal lKdv2 As Decimal, ByVal nKdvOrani3 As Decimal, ByVal lKdvMatrahi3 As Decimal, ByVal lKdv3 As Decimal, ByVal nKdvOrani4 As Decimal, ByVal lKdvMatrahi4 As Decimal, ByVal lKdv4 As Decimal, ByVal nKdvOrani5 As Decimal, ByVal lKdvMatrahi5 As Decimal, ByVal lKdv5 As Decimal, ByVal lPesinat As Decimal, ByVal nVadeFarkiYuzdesi As Decimal, ByVal nVadeKdvOrani As Decimal, ByVal lVadeKdvMatrahi As Decimal, ByVal lVadeKdv As Decimal, ByVal lVadeFarki As Decimal, ByVal sOdemeKodu As String, ByVal lNetTutar As Decimal, ByVal sHareketTipi As String, ByVal bMuhasebeyeIslendimi As Integer, ByVal nKasaNo As Int64, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal sYaziIle As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbAlisVeris (nAlisverisID, sFisTipi, dteFaturaTarihi, nGirisCikis, lFaturaNo, nMusteriID, sMagaza, sKasiyerRumuzu, sAlisverisYapanAdi, sAlisverisYapanSoyadi, lToplamMiktar, lMalBedeli, lMalIskontoTutari, nDipIskontoYuzdesi, lDipIskontoTutari, nKdvOrani1, lKdvMatrahi1, lKdv1, nKdvOrani2, lKdvMatrahi2, lKdv2, nKdvOrani3, lKdvMatrahi3, lKdv3, nKdvOrani4, lKdvMatrahi4, lKdv4, nKdvOrani5, lKdvMatrahi5, lKdv5, lPesinat, nVadeFarkiYuzdesi, nVadeKdvOrani, lVadeKdvMatrahi, lVadeKdv, lVadeFarki, sOdemeKodu, lNetTutar, sHareketTipi, bMuhasebeyeIslendimi, nKasaNo, sKullaniciAdi, dteKayitTarihi, sYaziIle) VALUES     ('" & nAlisverisID & "', '" & sFisTipi & "', '" & dteFaturaTarihi & "', " & nGirisCikis & ", '" & lFaturaNo & "', " & nMusteriID & ", '" & sMagaza & "', '" & sKasiyerRumuzu & "', '" & sAlisverisYapanAdi & "', '" & sAlisverisYapanSoyadi & "', " & lToplamMiktar & ", " & lMalBedeli & ", " & lMalIskontoTutari & ", " & nDipIskontoYuzdesi & ", " & lDipIskontoTutari & ", " & nKdvOrani1 & ", " & lKdvMatrahi1 & ", " & lKdv1 & ", " & nKdvOrani2 & ", " & lKdvMatrahi2 & ", " & lKdv2 & ", " & nKdvOrani3 & ", " & lKdvMatrahi3 & ", " & lKdv3 & ", " & nKdvOrani4 & ", " & lKdvMatrahi4 & ", " & lKdv4 & ", " & nKdvOrani5 & ", " & lKdvMatrahi5 & ", " & lKdv5 & ", " & lPesinat & ", " & nVadeFarkiYuzdesi & ", " & nVadeKdvOrani & ", " & lVadeKdvMatrahi & ", " & lVadeKdv & ", " & lVadeFarki & ", '" & sOdemeKodu & "', " & lNetTutar & ", '" & sHareketTipi & "', " & bMuhasebeyeIslendimi & ", " & nKasaNo & ", '" & sKullaniciAdi & "',  '" & dteKayitTarihi & "', '" & sYaziIle & "')")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbAlisVerisAdres_kaydet_yeni(ByVal nAlisVerisID As String, ByVal sAciklama As String, ByVal sAdres1 As String, ByVal sAdres2 As String, ByVal sSemt As String, ByVal sIl As String, ByVal sUlke As String, ByVal sPostaKodu As String, ByVal sVergiDairesi As String, ByVal sVergiNo As String, ByVal sSubeMagaza As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbAlisVerisAdres (nAlisVerisID, sAciklama, sAdres1, sAdres2, sSemt, sIl, sUlke, sPostaKodu, sVergiDairesi, sVergiNo, sSubeMagaza) VALUES     ('" & nAlisVerisID & "', N'" & sAciklama & "', '" & sAdres1 & "', '" & sAdres2 & "', '" & sSemt & "', '" & sIl & "', '" & sUlke & "', '" & sPostaKodu & "', '" & sVergiDairesi & "', '" & sVergiNo & "', '" & sSubeMagaza & "')")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Function tbStokFisidetay_kaydet_yeni(ByVal nIslemID As Int64, ByVal nStokID As Int64, ByVal dteIslemTarihi As DateTime, ByVal nFirmaID As Int64, ByVal nMusteriID As Int64, ByVal sFisTipi As String, ByVal dteFisTarihi As DateTime, ByVal lFisNo As String, ByVal nGirisCikis As Int64, ByVal sDepo As String, ByVal lReyonFisNo As String, ByVal sStokIslem As String, ByVal sKasiyerRumuzu As String, ByVal sSaticiRumuzu As String, ByVal sOdemeKodu As String, ByVal dteIrsaliyeTarihi As DateTime, ByVal lIrsaliyeNo As String, ByVal lGirisMiktar1 As Decimal, ByVal lGirisMiktar2 As Decimal, ByVal lGirisFiyat As Decimal, ByVal lGirisTutar As Decimal, ByVal lCikisMiktar1 As Decimal, ByVal lCikisMiktar2 As Decimal, ByVal lCikisFiyat As Decimal, ByVal lCikisTutar As Decimal, ByVal sFiyatTipi As String, ByVal lBrutFiyat As Decimal, ByVal lBrutTutar As Decimal, ByVal lMaliyetFiyat As Decimal, ByVal lMaliyetTutar As Decimal, ByVal lIlaveMaliyetTutar As Decimal, ByVal nIskontoYuzdesi As Decimal, ByVal lIskontoTutari As Decimal, ByVal sDovizCinsi As String, ByVal lDovizFiyat As Decimal, ByVal nSiparisID As String, ByVal nReceteNo As String, ByVal nTransferID As String, ByVal sTransferDepo As String, ByVal nKdvOrani As Decimal, ByVal nHesapID As Int64, ByVal sAciklama As String, ByVal sHareketTipi As String, ByVal bMuhasebeyeIslendimi As Byte, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal sDovizCinsi1 As String, ByVal lDovizMiktari1 As Decimal, ByVal lDovizKuru1 As Decimal, ByVal sDovizCinsi2 As String, ByVal lDovizMiktari2 As Decimal, ByVal lDovizKuru2 As Decimal, ByVal nOTVOrani As Decimal, ByVal nTransferFirmaID As String, ByVal nAlisverisID As String, ByVal nStokFisiID As Int64, ByVal nIrsaliyeFisiID As String, ByVal sMasrafYontemi As String, ByVal sHangiUygulama As String, ByVal nEkSaha1 As Int64, ByVal nEkSaha2 As Int64, ByVal bEkSoru1 As Int64, ByVal bEkSoru2 As Int64, ByVal sSonKullaniciAdi As String, ByVal dteSonUpdateTarihi As DateTime) As Int64
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbStokFisiDetayi                       (nStokID, dteIslemTarihi, nFirmaID, nMusteriID, sFisTipi, dteFisTarihi, lFisNo, nGirisCikis, sDepo, lReyonFisNo, sStokIslem, sKasiyerRumuzu, sSaticiRumuzu, sOdemeKodu, dteIrsaliyeTarihi, lIrsaliyeNo, lGirisMiktar1, lGirisMiktar2, lGirisFiyat, lGirisTutar, lCikisMiktar1, lCikisMiktar2, lCikisFiyat, lCikisTutar, sFiyatTipi, lBrutFiyat, lBrutTutar, lMaliyetFiyat, lMaliyetTutar, lIlaveMaliyetTutar, nIskontoYuzdesi, lIskontoTutari, sDovizCinsi, lDovizFiyat, nSiparisID, nReceteNo, nTransferID, sTransferDepo, nKdvOrani, nHesapID, sAciklama, sHareketTipi, bMuhasebeyeIslendimi, sKullaniciAdi, dteKayitTarihi, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, nOTVOrani, nTransferFirmaID, nAlisverisID, nStokFisiID, nIrsaliyeFisiID, sMasrafYontemi, sHangiUygulama, nEkSaha1, nEkSaha2, bEkSoru1, bEkSoru2, sSonKullaniciAdi, dteSonUpdateTarihi) VALUES     ('" & nStokID & "', '" & dteIslemTarihi & "', '" & nFirmaID & "', '" & nMusteriID & "', '" & sFisTipi & "', '" & dteFisTarihi & "', '" & lFisNo & "', " & nGirisCikis & ", '" & sDepo & "', '" & lReyonFisNo & "', '" & sStokIslem & "', '" & sKasiyerRumuzu & "', '" & sSaticiRumuzu & "', '" & sOdemeKodu & "', '" & dteIrsaliyeTarihi & "', '" & lIrsaliyeNo & "', " & lGirisMiktar1 & ", " & lGirisMiktar2 & ", " & lGirisFiyat & ", " & lGirisTutar & ", " & lCikisMiktar1 & ", " & lCikisMiktar2 & " , " & lCikisFiyat & ", " & lCikisTutar & " , '" & sFiyatTipi & "' , " & lBrutFiyat & ", " & lBrutTutar & " , " & lMaliyetFiyat & ", " & lMaliyetTutar & ", " & lIlaveMaliyetTutar & ", " & nIskontoYuzdesi & ", " & lIskontoTutari & ", '" & sDovizCinsi & "', " & lDovizFiyat & ", NULL, '" & nReceteNo & "', NULL, NULL, " & nKdvOrani & ", '" & nHesapID & "', N'" & sAciklama & "', '" & sHareketTipi & "'," & bMuhasebeyeIslendimi & ", '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', '" & sDovizCinsi1 & "', " & lDovizMiktari1 & ", " & lDovizKuru1 & ", '" & sDovizCinsi2 & "', " & lDovizMiktari2 & " , " & lDovizKuru2 & ", " & nOTVOrani & ", NULL,  '" & nAlisverisID & "', NULL, NULL, '" & sMasrafYontemi & "', '" & sHangiUygulama & "', " & nEkSaha1 & ", " & nEkSaha2 & ", " & bEkSoru1 & " , " & bEkSoru2 & ", '" & sSonKullaniciAdi & "', '" & dteSonUpdateTarihi & "')")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        nIslemID = cmd.ExecuteScalar
        Return nIslemID
        con.Close()
    End Function
    Private Sub tbAlisVerisSiparis_kaydet_yeni(ByVal nAlisverisID As String, ByVal sMagazaKodu As String, ByVal nSiparisID As Int64, ByVal nGirisCikis As Int64, ByVal nStokID As Int64, ByVal sKasiyerRumuzu As String, ByVal sSaticiRumuzu As String, ByVal sOdemeKodu As String, ByVal lReyonFisNo As Int64, ByVal sFiyatTipi As String, ByVal lGCMiktar As Decimal, ByVal lBrutFiyat As Decimal, ByVal lBrutTutar As Decimal, ByVal nIskontoYuzdesi As Decimal, ByVal lIskontoTutari As Decimal, ByVal lFiyat As Decimal, ByVal lTutar As Decimal, ByVal nKdvOrani As Decimal, ByVal sIadeNedeni As String, ByVal nPartiID As Int64, ByVal dteTeslimEdilecek As DateTime, ByVal dteTeslimEdilen As DateTime, ByVal bTeslimEdildi As Byte, ByVal bMuhasebeyeIslendimi As Byte, ByVal sAciklama As String, ByVal bEkSoru As Byte, ByVal bEkAlan1 As Byte, ByVal bEkAlan2 As String, ByVal sDovizCinsi1 As String, ByVal lDovizMiktari1 As Decimal, ByVal lDovizKuru1 As Decimal, ByVal sSonKullaniciAdi As String, ByVal dteSonUpdateTarihi As DateTime, ByVal dteOnayTarihi As DateTime)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbAlisverisSiparis (nAlisverisID, sMagazaKodu, nSiparisID, nGirisCikis, nStokID, sKasiyerRumuzu, sSaticiRumuzu, sOdemeKodu, lReyonFisNo, sFiyatTipi, lGCMiktar, lBrutFiyat, lBrutTutar, nIskontoYuzdesi, lIskontoTutari, lFiyat, lTutar, nKdvOrani, sIadeNedeni, nPartiID, dteTeslimEdilecek, dteTeslimEdilen, bTeslimEdildi, bMuhasebeyeIslendimi, sAciklama, bEkSoru, bEkAlan1, bEkAlan2, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sSonKullaniciAdi, dteSonUpdateTarihi, dteOnayTarihi) VALUES     ('" & nAlisverisID & "', '" & sMagazaKodu & "', " & nSiparisID & ", " & nGirisCikis & ", " & nStokID & ", '" & sKasiyerRumuzu & "', '" & sSaticiRumuzu & "', '" & sOdemeKodu & "', " & lReyonFisNo & ", '" & sFiyatTipi & "', " & lGCMiktar & ", " & lBrutFiyat & ", " & lBrutTutar & ", " & nIskontoYuzdesi & ", " & lIskontoTutari & ", " & lFiyat & ", " & lTutar & ", " & nKdvOrani & ", '" & sIadeNedeni & "', " & nPartiID & ", '" & dteTeslimEdilecek & "', '" & dteTeslimEdilen & "', " & bTeslimEdildi & ", " & bMuhasebeyeIslendimi & ", N'" & sAciklama & "', " & bEkSoru & ", " & bEkAlan1 & ", '" & bEkAlan2 & "', '" & sDovizCinsi1 & "', " & lDovizMiktari1 & ", " & lDovizKuru1 & ", '" & sSonKullaniciAdi & "', '" & dteSonUpdateTarihi & "', '" & dteOnayTarihi & "') ")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub fis_detay_fisno_degistir(ByVal nstokIslemID As String)
        'kriter = "WHERE (sFisTipi = '" & sFistipi & "') and (dteFisTarihi = '" & dteFisTarihi & "') and (lFisNo = '" & lFisno & "') and (nFirmaID= '" & nFirmaID & "') and (nGirisCikis = '" & nGirisCikis & "')  "
        'sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbFirmaHareketi " & kriter & ""))
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbStokSiraNo SET              nSonID = '" & nstokIslemID & "' where nSiraIndex = 1")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub SimpleButton17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton17.Click
        GroupControl6.Visible = False
        GridControl1.Focus()
        GridControl1.Select()
    End Sub
    Private Sub SimpleButton18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton18.Click
        If sorgu_ntbStokTedarikcisiVarmi(txt_sYeniKod.Text) = 0 Then
            If XtraMessageBox.Show(txt_sYeniKod.Text & " Nolu Fiş Numarasına Kayıtları Atamak İstediğinize Emin misiniz...?", Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                satir_ekle_firma_kopyala(txt_sYeniKod.Text)
                GroupControl6.Visible = False
                GridControl1.Focus()
                GridControl1.Select()
            End If
        Else
            XtraMessageBox.Show("Üzgünüm Kayıt İçerde Var...!", Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub BarButtonItem1_ItemClick_1(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        If con.State = ConnectionState.Closed Then
            con.ConnectionString = connection
            cmd.Connection = con
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SELECT ISNULL(MAX(lFisNo), 0) + 1 AS lFisNo  From   tbParekendeToplu")
        txt_musterino.Text = cmd.ExecuteScalar.ToString()
        con.Close()
        If sorgu_ntbStokTedarikcisiVarmi(txt_musterino.Text) = 0 Then
            If XtraMessageBox.Show(txt_musterino.Text & " Nolu Fiş Numarasına Kayıtları Atamak İstediğinize Emin misiniz...?", Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                satir_ekle_firma_kopyala1(txt_musterino.Text)
                GroupControl6.Visible = False
                GridControl1.Focus()
                GridControl1.Select()
            End If
        Else
            XtraMessageBox.Show("Üzgünüm Kayıt İçerde Var...!", Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
End Class