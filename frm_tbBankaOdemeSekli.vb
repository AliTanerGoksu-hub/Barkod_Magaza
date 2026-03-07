Imports DevExpress.XtraEditors
Public Class frm_tbBankaOdemeSekli
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
        For Each btn As DevExpress.XtraBars.BarItem In BarManager1.Items
            btn.Caption = Sorgu_sDil(btn.Caption, sDil)
        Next
        For Each clmn As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            clmn.Caption = Sorgu_sDil(clmn.Caption, sDil)
        Next
        Dim itm
        For Each itm In kisayol.Items
            itm.text = Sorgu_sDil(itm.text, sDil)
        Next
        SimpleButton1.Text = Sorgu_sDil(SimpleButton1.Text, sDil)
        SimpleButton2.Text = Sorgu_sDil(SimpleButton2.Text, sDil)
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
    Public Sub Dataload_tbKdv()
        Try
            ds_tbKdv.Tables(0).Clear()
        Catch ex As Exception
        End Try
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * From  tbBankaOdemeSekli ")
        cmd.Connection = conn
        Dim N As Integer = adapter.Fill(ds_tbKdv, "Table1")
        conn.Close()
        GridControl1.Focus()
        GridControl1.Select()
    End Sub
    Private Sub tbKdv_kaydet_yeni(ByVal sOdemeSekli As String, ByVal nTaksitSayisi As Int64, ByVal nTaksit As Int64, ByVal nTaksit1 As Int64, ByVal nTaksit2 As Int64, ByVal nTaksit3 As Int64, ByVal nTaksit4 As Int64, ByVal nTaksit5 As Int64, ByVal nTaksit6 As Int64, ByVal nTaksit7 As Int64, ByVal nTaksit8 As Int64, ByVal nTaksit9 As Int64, ByVal nTaksit10 As Int64, ByVal nTaksit11 As Int64, ByVal nTaksit12 As Int64, ByVal nTaksit13 As Int64, ByVal nTaksit14 As Int64, ByVal nTaksit15 As Int64, ByVal nTaksit16 As Int64, ByVal nTaksit17 As Int64, ByVal nTaksit18 As Int64, ByVal nTaksit19 As Int64, ByVal nTaksit20 As Int64, ByVal nTaksit21 As Int64, ByVal nTaksit22 As Int64, ByVal nTaksit23 As Int64, ByVal nTaksit24 As Int64, ByVal nAlisGun1 As Int64, ByVal nAlisGun2 As Int64, ByVal nAlisGun3 As Int64, ByVal nTaksitGun1 As Int64, ByVal nTaksitGun2 As Int64, ByVal nTaksitGun3 As Int64, ByVal bS_Bulundugu_Ay1 As Int64, ByVal bS_Bulundugu_Ay2 As Int64, ByVal bS_Bulundugu_Ay3 As Int64, ByVal bServisAlisveristen As Int64, ByVal nKomisyon_Kdv_Orani As Decimal, ByVal nKomisyonOrani_2 As Decimal, ByVal nIlkTaksitSonra As Int64, ByVal bS_Cuma_Pazartesi As Integer, ByVal bS_Cuma_Pazar As Integer, ByVal bS_Cuma_Cuma As Integer, ByVal bS_Cuma_Cumartesi As Integer, ByVal bS_Cumartesi_Pazar As Integer, ByVal bS_Cumartesi_Pazartesi As Integer, ByVal bS_Cumartesi_Cumartesi As Integer, ByVal bS_Pazar_Pazartesi As Integer, ByVal bT_Cumartesi_Pazartesi As Integer, ByVal bT_Pazar_Pazartesi As Integer, ByVal nKomisyonOrani As Decimal, ByVal nBSMV As Decimal, ByVal nBonusOrani As Decimal, ByVal nBonus_KdvOrani As Decimal, ByVal bKomisyon_IlkTaksit As Integer, ByVal nBonus_Puan As Decimal, ByVal nKomisyonOrani_2_Aciklama As Int64, ByVal nAlisGun4 As Int64, ByVal nAlisGun5 As Int64, ByVal nAlisGun6 As Int64, ByVal nTaksitGun4 As Int64, ByVal nTaksitGun5 As Int64, ByVal nTaksitGun6 As Int64, ByVal bS_Bulundugu_Ay4 As Int64, ByVal bS_Bulundugu_Ay5 As Int64, ByVal bS_Bulundugu_Ay6 As Int64, ByVal bTaksit_Satis As Int64, ByVal bTaksit_Tatil_Gunleri As Integer)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbBankaOdemeSekli (sOdemeSekli, nTaksitSayisi, nTaksit, nTaksit1, nTaksit2, nTaksit3, nTaksit4, nTaksit5, nTaksit6, nTaksit7, nTaksit8, nTaksit9, nTaksit10, nTaksit11, nTaksit12, nTaksit13, nTaksit14, nTaksit15, nTaksit16, nTaksit17, nTaksit18, nTaksit19, nTaksit20, nTaksit21, nTaksit22, nTaksit23, nTaksit24, nAlisGun1, nAlisGun2, nAlisGun3, nTaksitGun1, nTaksitGun2, nTaksitGun3, bS_Bulundugu_Ay1, bS_Bulundugu_Ay2, bS_Bulundugu_Ay3, bServisAlisveristen, nKomisyon_Kdv_Orani, nKomisyonOrani_2, nIlkTaksitSonra, bS_Cuma_Pazar, bS_Cuma_Pazartesi,bS_Cuma_Cuma,bS_Cuma_Cumartesi, bS_Cumartesi_Pazar, bS_Cumartesi_Pazartesi, bS_Cumartesi_Cumartesi ,bS_Pazar_Pazartesi, bT_Cumartesi_Pazartesi, bT_Pazar_Pazartesi, nKomisyonOrani, nBSMV, nBonusOrani, nBonus_KdvOrani, bKomisyon_IlkTaksit, nBonus_Puan, nKomisyonOrani_2_Aciklama, nAlisGun4, nAlisGun5, nAlisGun6, nTaksitGun4, nTaksitGun5, nTaksitGun6, bS_Bulundugu_Ay4, bS_Bulundugu_Ay5, bS_Bulundugu_Ay6, bTaksit_Satis, bTaksit_Tatil_Gunleri) VALUES     ('" & sOdemeSekli & "', " & nTaksitSayisi & ", " & nTaksit & ", " & nTaksit1 & ", " & nTaksit2 & ", " & nTaksit3 & ", " & nTaksit4 & ", " & nTaksit5 & ", " & nTaksit6 & ", " & nTaksit7 & ", " & nTaksit8 & ", " & nTaksit9 & ", " & nTaksit10 & ", " & nTaksit11 & ", " & nTaksit12 & ", " & nTaksit13 & ", " & nTaksit14 & ", " & nTaksit15 & ", " & nTaksit16 & ", " & nTaksit17 & ", " & nTaksit18 & ", " & nTaksit19 & ", " & nTaksit20 & ", " & nTaksit21 & ", " & nTaksit22 & ", " & nTaksit23 & ", " & nTaksit24 & ", " & nAlisGun1 & ", " & nAlisGun2 & ", " & nAlisGun3 & ", " & nTaksitGun1 & ", " & nTaksitGun2 & ", " & nTaksitGun3 & ", " & bS_Bulundugu_Ay1 & ", " & bS_Bulundugu_Ay2 & ", " & bS_Bulundugu_Ay3 & ", " & bServisAlisveristen & ", " & nKomisyon_Kdv_Orani & ", " & nKomisyonOrani_2 & ", " & nIlkTaksitSonra & "," & bS_Cuma_Pazartesi & ", " & bS_Cuma_Pazar & "," & bS_Cuma_Cuma & ", " & bS_Cuma_Cumartesi & "," & bS_Cumartesi_Pazar & ", " & bS_Cumartesi_Pazartesi & ",  " & bS_Cumartesi_Cumartesi & "," & bS_Pazar_Pazartesi & ", " & bT_Cumartesi_Pazartesi & ", " & bT_Pazar_Pazartesi & ", " & nKomisyonOrani & ", " & nBSMV & ", " & nBonusOrani & ", " & nBonus_KdvOrani & ", " & bKomisyon_IlkTaksit & ", " & nBonus_Puan & ", " & nKomisyonOrani_2_Aciklama & ", " & nAlisGun4 & ", " & nAlisGun5 & ", " & nAlisGun6 & ", " & nTaksitGun4 & ", " & nTaksitGun5 & ", " & nTaksitGun6 & ", " & bS_Bulundugu_Ay4 & ", " & bS_Bulundugu_Ay5 & ", " & bS_Bulundugu_Ay6 & ", " & bTaksit_Satis & ", " & bTaksit_Tatil_Gunleri & ")")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbKdv_kaydet_duzelt(ByVal sOdemeSekli As String, ByVal nTaksitSayisi As Int64, ByVal nTaksit As Int64, ByVal nTaksit1 As Int64, ByVal nTaksit2 As Int64, ByVal nTaksit3 As Int64, ByVal nTaksit4 As Int64, ByVal nTaksit5 As Int64, ByVal nTaksit6 As Int64, ByVal nTaksit7 As Int64, ByVal nTaksit8 As Int64, ByVal nTaksit9 As Int64, ByVal nTaksit10 As Int64, ByVal nTaksit11 As Int64, ByVal nTaksit12 As Int64, ByVal nTaksit13 As Int64, ByVal nTaksit14 As Int64, ByVal nTaksit15 As Int64, ByVal nTaksit16 As Int64, ByVal nTaksit17 As Int64, ByVal nTaksit18 As Int64, ByVal nTaksit19 As Int64, ByVal nTaksit20 As Int64, ByVal nTaksit21 As Int64, ByVal nTaksit22 As Int64, ByVal nTaksit23 As Int64, ByVal nTaksit24 As Int64, ByVal nAlisGun1 As Int64, ByVal nAlisGun2 As Int64, ByVal nAlisGun3 As Int64, ByVal nTaksitGun1 As Int64, ByVal nTaksitGun2 As Int64, ByVal nTaksitGun3 As Int64, ByVal bS_Bulundugu_Ay1 As Int64, ByVal bS_Bulundugu_Ay2 As Int64, ByVal bS_Bulundugu_Ay3 As Int64, ByVal bServisAlisveristen As Int64, ByVal nKomisyon_Kdv_Orani As Decimal, ByVal nKomisyonOrani_2 As Decimal, ByVal nIlkTaksitSonra As Int64, ByVal bS_Cuma_Pazar As Integer, ByVal bS_Cuma_Pazartesi As Integer, ByVal bS_Cuma_Cuma As Integer, ByVal bS_Cuma_Cumartesi As Integer, ByVal bS_Cumartesi_Pazar As Integer, ByVal bS_Cumartesi_Pazartesi As Integer, ByVal bS_Cumartesi_Cumartesi As Integer, ByVal bS_Pazar_Pazartesi As Integer, ByVal bT_Cumartesi_Pazartesi As Integer, ByVal bT_Pazar_Pazartesi As Integer, ByVal nKomisyonOrani As Decimal, ByVal nBSMV As Decimal, ByVal nBonusOrani As Decimal, ByVal nBonus_KdvOrani As Decimal, ByVal bKomisyon_IlkTaksit As Integer, ByVal nBonus_Puan As Decimal, ByVal nKomisyonOrani_2_Aciklama As Int64, ByVal nAlisGun4 As Int64, ByVal nAlisGun5 As Int64, ByVal nAlisGun6 As Int64, ByVal nTaksitGun4 As Int64, ByVal nTaksitGun5 As Int64, ByVal nTaksitGun6 As Int64, ByVal bS_Bulundugu_Ay4 As Int64, ByVal bS_Bulundugu_Ay5 As Int64, ByVal bS_Bulundugu_Ay6 As Int64, ByVal bTaksit_Satis As Int64, ByVal bTaksit_Tatil_Gunleri As Integer)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbBankaOdemeSekli SET  nTaksitSayisi = " & nTaksitSayisi & ", nTaksit = " & nTaksit & ", nTaksit1 = " & nTaksit1 & ", nTaksit2 = " & nTaksit2 & ", nTaksit3 = " & nTaksit3 & ", nTaksit4 = " & nTaksit4 & ", nTaksit5 = " & nTaksit5 & ", nTaksit6 = " & nTaksit6 & ", nTaksit7 = " & nTaksit7 & ", nTaksit8 = " & nTaksit8 & ", nTaksit9 = " & nTaksit9 & ", nTaksit10 = " & nTaksit10 & ", nTaksit11 = " & nTaksit11 & ", nTaksit12 = " & nTaksit12 & ", nTaksit13 = " & nTaksit13 & ", nTaksit14 = " & nTaksit14 & ", nTaksit15 = " & nTaksit15 & ", nTaksit16 = " & nTaksit16 & ", nTaksit17 = " & nTaksit17 & ", nTaksit18 = " & nTaksit18 & ", nTaksit19 = " & nTaksit19 & ", nTaksit20 = " & nTaksit20 & ", nTaksit21 = " & nTaksit21 & ", nTaksit22 = " & nTaksit22 & ", nTaksit23 = " & nTaksit23 & ", nTaksit24 = " & nTaksit24 & ", nAlisGun1 = " & nAlisGun1 & ", nAlisGun2 = " & nAlisGun2 & ", nAlisGun3 = " & nAlisGun3 & ", nTaksitGun1 = " & nTaksitGun1 & ", nTaksitGun2 = " & nTaksitGun2 & ", nTaksitGun3 = " & nTaksitGun3 & ", bS_Bulundugu_Ay1 = " & bS_Bulundugu_Ay1 & ", bS_Bulundugu_Ay2 = " & bS_Bulundugu_Ay2 & ", bS_Bulundugu_Ay3 = " & bS_Bulundugu_Ay3 & ", bServisAlisveristen = " & bServisAlisveristen & ", nKomisyon_Kdv_Orani = " & nKomisyon_Kdv_Orani & ", nKomisyonOrani_2 = " & nKomisyonOrani_2 & ", nIlkTaksitSonra = " & nIlkTaksitSonra & ", bS_Cuma_Pazar = " & bS_Cuma_Pazar & ", bS_Cuma_Pazartesi = " & bS_Cuma_Pazartesi & ",  bS_Cuma_Cuma = " & bS_Cuma_Cuma & ", bS_Cuma_Cumartesi = " & bS_Cuma_Cumartesi & ", bS_Cumartesi_Pazar = " & bS_Cumartesi_Pazar & ", bS_Cumartesi_Pazartesi = " & bS_Cumartesi_Pazartesi & ",bS_Cumartesi_Cumartesi = " & bS_Cumartesi_Cumartesi & ", bS_Pazar_Pazartesi = " & bS_Pazar_Pazartesi & ", bT_Cumartesi_Pazartesi = " & bT_Cumartesi_Pazartesi & ", bT_Pazar_Pazartesi = " & bT_Pazar_Pazartesi & ", nKomisyonOrani = " & nKomisyonOrani & ", nBSMV = " & nBSMV & ", nBonusOrani = " & nBonusOrani & ", nBonus_KdvOrani = " & nBonus_KdvOrani & ", bKomisyon_IlkTaksit = " & bKomisyon_IlkTaksit & ", nBonus_Puan = " & nBonus_Puan & ", nKomisyonOrani_2_Aciklama = " & nKomisyonOrani_2_Aciklama & ", nAlisGun4 = " & nAlisGun4 & ", nAlisGun5 = " & nAlisGun5 & ", nAlisGun6 = " & nAlisGun6 & ", nTaksitGun4 =" & nTaksitGun4 & ", nTaksitGun5 = " & nTaksitGun5 & ", nTaksitGun6 = " & nTaksitGun6 & ", bS_Bulundugu_Ay4 = " & bS_Bulundugu_Ay4 & ", bS_Bulundugu_Ay5 = " & bS_Bulundugu_Ay5 & ", bS_Bulundugu_Ay6 = " & bS_Bulundugu_Ay6 & ", bTaksit_Satis = " & bTaksit_Satis & ", bTaksit_Tatil_Gunleri = " & bTaksit_Tatil_Gunleri & " Where sOdemeSekli = '" & sOdemeSekli & "'")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbKdv_kaydet_sil(ByVal sOdemeSekli As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE FROM tbBankaOdemeSekli Where sOdemeSekli ='" & sOdemeSekli & "'")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Public Function sorgu_sKdvTipi_kontrol(ByVal sOdemeSekli As String) As Boolean
        Dim kriter
        Dim pass As Boolean
        kriter = ""
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(sOdemeSekli), 0) AS nKayit FROM         tbBankaOdemeSekli WHERE     (sOdemeSekli = '" & sOdemeSekli & "') and sOdemeSekli <>'' ")
        Dim kayitsayisi = cmd.ExecuteScalar
        If kayitsayisi = 0 Then
            pass = True
        Else
            pass = False
        End If
        Return pass
    End Function
    Private Sub kayit_ekle()
        XtraTabPage1.PageVisible = False
        XtraTabPage2.PageVisible = True
        XtraTabControl2.SelectedTabPageIndex = 0
        sec_nTaksit0.Checked = True
        sec_nTaksit1.Checked = True
        sec_nTaksit2.Checked = True
        sec_nTaksit3.Checked = True
        sec_nTaksit0.Checked = False
        sec_nTaksit1.Checked = False
        sec_nTaksit2.Checked = False
        sec_nTaksit3.Checked = False
        txt_sOdemeSekli.Text = ""
        txt_nIlkTaksitSonra.EditValue = 0
        txt_nKomisyonOrani.EditValue = 0
        txt_nBSMV.EditValue = 0
        txt_nTaksitSayisi.EditValue = 1
        txt_nTaksit1.EditValue = 0
        txt_nTaksit2.EditValue = 0
        txt_nTaksit3.EditValue = 0
        txt_nTaksit4.EditValue = 0
        txt_nTaksit5.EditValue = 0
        txt_nTaksit6.EditValue = 0
        txt_nTaksit7.EditValue = 0
        txt_nTaksit8.EditValue = 0
        txt_nTaksit9.EditValue = 0
        txt_nTaksit10.EditValue = 0
        txt_nTaksit11.EditValue = 0
        txt_nTaksit12.EditValue = 0
        txt_nTaksit13.EditValue = 0
        txt_nTaksit14.EditValue = 0
        txt_nTaksit15.EditValue = 0
        txt_nTaksit16.EditValue = 0
        txt_nTaksit17.EditValue = 0
        txt_nTaksit18.EditValue = 0
        txt_nTaksit19.EditValue = 0
        txt_nTaksit20.EditValue = 0
        txt_nTaksit21.EditValue = 0
        txt_nTaksit22.EditValue = 0
        txt_nTaksit23.EditValue = 0
        txt_nTaksit24.EditValue = 0
        sec_nTaksit0.Checked = False
        sec_nTaksit1.Checked = True
        sec_nTaksit2.Checked = False
        sec_nTaksit3.Checked = False
        txt_nAlisGun1.EditValue = 1
        txt_nAlisGun2.EditValue = 31
        txt_nAlisGun3.EditValue = 31
        txt_nAlisGun4.EditValue = 31
        txt_nAlisGun5.EditValue = 31
        txt_nAlisGun6.EditValue = 31
        txt_nTaksitGun1.EditValue = 31
        txt_nTaksitGun2.EditValue = 31
        txt_nTaksitGun3.EditValue = 31
        txt_nTaksitGun4.EditValue = 31
        txt_nTaksitGun5.EditValue = 31
        txt_nTaksitGun6.EditValue = 31
        sec_bS_Bulundugu_Ay1.SelectedIndex = 1
        sec_bS_Bulundugu_Ay2.SelectedIndex = 1
        sec_bS_Bulundugu_Ay3.SelectedIndex = 1
        sec_bS_Bulundugu_Ay4.SelectedIndex = 1
        sec_bS_Bulundugu_Ay5.SelectedIndex = 1
        sec_bS_Bulundugu_Ay6.SelectedIndex = 1
        sec_bServisAlisVeristen.SelectedIndex = 0
        txt_nKomisyon_Kdv_Orani.EditValue = 0
        txt_nKomisyonOrani_2.EditValue = 0
        txt_nIlkTaksitSonra.EditValue = 0
        'yni basla
        sec_bS_Cuma_Cuma.Checked = 1
        sec_bS_Cuma_Pazartesi.Checked = 1
        sec_bS_Cuma_Pazar.Checked = 1
        sec_bS_Cuma_Cumartesi.Checked = 1
        sec_bt_Cumartesi_Pazartesi.Checked = 1
        sec_bT_Pazar_Pazartesi.Checked = 1
        sec_bS_Cumartesi_Pazar.Checked = 1
        sec_bS_Cumartesi_Pazartesi.Checked = 1
        'yeni bitir

        sec_bS_Pazar_Pazartesi.Checked = 1
        sec_bS_Cumartesi_Günü.Checked = 1
        txt_nKomisyonOrani.EditValue = 0
        txt_nBSMV.EditValue = 0
        txt_nBonusOrani.EditValue = 0
        txt_nBonus_KdvOrani.EditValue = 0
        sec_bKomisyon_IlkTaksit.Checked = 0
        sec_nBonus_Puan.SelectedIndex = 0
        sec_nKomisyonOrani_2_Aciklama.SelectedIndex = 0
        'sec_bTaksit_Satis.editvalue = dr("bTaksit_Satis")
        sec_bTaksit_Tatil_Gunleri.Checked = 1
        islem = "Ekle"
    End Sub
    Private Sub kayit_duzelt()
        XtraTabPage1.PageVisible = False
        XtraTabPage2.PageVisible = True
        satir = GridView1.FocusedRowHandle
        Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        sec_nTaksit0.Checked = True
        sec_nTaksit1.Checked = True
        sec_nTaksit2.Checked = True
        sec_nTaksit3.Checked = True
        sec_nTaksit0.Checked = False
        sec_nTaksit1.Checked = False
        sec_nTaksit2.Checked = False
        sec_nTaksit3.Checked = False
        txt_sOdemeSekli.Text = dr("sOdemeSekli")
        txt_sOdemeSekli.Enabled = False
        txt_nIlkTaksitSonra.EditValue = dr("nIlkTaksitSonra")
        txt_nKomisyonOrani.EditValue = dr("nKomisyonOrani")
        txt_nBSMV.EditValue = dr("nBSMV")
        txt_nTaksitSayisi.EditValue = dr("nTaksitSayisi")
        txt_nTaksit1.EditValue = dr("nTaksit1")
        txt_nTaksit2.EditValue = dr("nTaksit2")
        txt_nTaksit3.EditValue = dr("nTaksit3")
        txt_nTaksit4.EditValue = dr("nTaksit4")
        txt_nTaksit5.EditValue = dr("nTaksit5")
        txt_nTaksit6.EditValue = dr("nTaksit6")
        txt_nTaksit7.EditValue = dr("nTaksit7")
        txt_nTaksit8.EditValue = dr("nTaksit8")
        txt_nTaksit9.EditValue = dr("nTaksit9")
        txt_nTaksit10.EditValue = dr("nTaksit10")
        txt_nTaksit11.EditValue = dr("nTaksit11")
        txt_nTaksit12.EditValue = dr("nTaksit12")
        txt_nTaksit13.EditValue = dr("nTaksit13")
        txt_nTaksit14.EditValue = dr("nTaksit14")
        txt_nTaksit15.EditValue = dr("nTaksit15")
        txt_nTaksit16.EditValue = dr("nTaksit16")
        txt_nTaksit17.EditValue = dr("nTaksit17")
        txt_nTaksit18.EditValue = dr("nTaksit18")
        txt_nTaksit19.EditValue = dr("nTaksit19")
        txt_nTaksit20.EditValue = dr("nTaksit20")
        txt_nTaksit21.EditValue = dr("nTaksit21")
        txt_nTaksit22.EditValue = dr("nTaksit22")
        txt_nTaksit23.EditValue = dr("nTaksit23")
        txt_nTaksit24.EditValue = dr("nTaksit24")
        If dr("nTaksit") = 0 Then
            sec_nTaksit0.Checked = True
        ElseIf dr("nTaksit") = 1 Then
            sec_nTaksit1.Checked = True
        ElseIf dr("nTaksit") = 2 Then
            sec_nTaksit2.Checked = True
        ElseIf dr("nTaksit") = 3 Then
            sec_nTaksit3.Checked = True
        End If
        txt_nAlisGun1.EditValue = dr("nAlisGun1")
        txt_nAlisGun2.EditValue = dr("nAlisGun2")
        txt_nAlisGun3.EditValue = dr("nAlisGun3")
        txt_nAlisGun4.EditValue = dr("nAlisGun4")
        txt_nAlisGun5.EditValue = dr("nAlisGun5")
        txt_nAlisGun6.EditValue = dr("nAlisGun6")
        txt_nTaksitGun1.EditValue = dr("nTaksitGun1")
        txt_nTaksitGun2.EditValue = dr("nTaksitGun2")
        txt_nTaksitGun3.EditValue = dr("nTaksitGun3")
        txt_nTaksitGun4.EditValue = dr("nTaksitGun4")
        txt_nTaksitGun5.EditValue = dr("nTaksitGun5")
        txt_nTaksitGun6.EditValue = dr("nTaksitGun6")
        sec_bS_Bulundugu_Ay1.SelectedIndex = dr("bS_Bulundugu_Ay1")
        sec_bS_Bulundugu_Ay2.SelectedIndex = dr("bS_Bulundugu_Ay2")
        sec_bS_Bulundugu_Ay3.SelectedIndex = dr("bS_Bulundugu_Ay3")
        sec_bS_Bulundugu_Ay4.SelectedIndex = dr("bS_Bulundugu_Ay4")
        sec_bS_Bulundugu_Ay5.SelectedIndex = dr("bS_Bulundugu_Ay5")
        sec_bS_Bulundugu_Ay6.SelectedIndex = dr("bS_Bulundugu_Ay6")
        sec_bServisAlisVeristen.SelectedIndex = dr("bServisAlisveristen")
        txt_nKomisyon_Kdv_Orani.EditValue = dr("nKomisyon_Kdv_Orani")
        txt_nKomisyonOrani_2.EditValue = dr("nKomisyonOrani_2")
        txt_nIlkTaksitSonra.EditValue = dr("nIlkTaksitSonra")



        'If sec_bS_Cuma_Pazar.Checked = True Then
        '    dr("bS_Cuma_Pazar") = 1
        'Else
        '    dr("bS_Cuma_Pazar") = 0
        'End If
        'If sec_bS_Cuma_Pazartesi.Checked = True Then
        '    dr("bS_Cuma_Pazartesi") = 1
        'Else
        '    dr("bS_Cuma_Pazartesi") = 0
        'End If
        'If sec_bS_Cuma_Cuma.Checked = True Then
        '    dr("bS_Cuma_Cuma") = 1
        'Else
        '    dr("bS_Cuma_Cuma") = 0
        'End If
        'If sec_bS_Cuma_Cumartesi.Checked = True Then
        '    dr("bS_Cuma_Cumartesi") = 1
        'Else
        '    dr("bS_Cuma_Cumartesi") = 0
        'End If


        'If sec_bS_Cumartesi_Pazar.Checked = True Then
        '    dr("bS_Cumartesi_Pazar") = 1
        'Else
        '    dr("bS_Cumartesi_Pazar") = 0
        'End If
        'If sec_bS_Cumartesi_Pazartesi.Checked = True Then
        '    dr("bS_Cumartesi_Pazartesi") = 1
        'Else
        '    dr("bS_Cumartesi_Pazartesi") = 0
        'End If
        'If sec_bS_Cumartesi_Günü.Checked = True Then
        '    dr("bS_Cumartesi_Cumartesi") = 1
        'Else
        '    dr("bS_Cumartesi_Cumartesi") = 0
        'End If
        sec_bS_Cuma_Pazar.Checked = dr("bS_Cuma_Pazar")
        sec_bS_Cuma_Pazartesi.Checked = dr("bS_Cuma_Pazartesi")
        sec_bS_Cuma_Cuma.Checked = dr("bS_Cuma_Cuma")
        sec_bS_Cuma_Cumartesi.Checked = dr("bS_Cuma_Cumartesi")
        sec_bS_Cumartesi_Pazar.Checked = dr("bS_Cumartesi_Pazar")
        sec_bS_Cumartesi_Pazartesi.Checked = dr("bS_Cumartesi_Pazartesi")
        sec_bS_Cumartesi_Günü.Checked = dr("bS_Cumartesi_Cumartesi")

        sec_bS_Pazar_Pazartesi.Checked = dr("bS_Pazar_Pazartesi")
        sec_bt_Cumartesi_Pazartesi.Checked = dr("bT_Cumartesi_Pazartesi")
        sec_bT_Pazar_Pazartesi.Checked = dr("bT_Pazar_Pazartesi")
        txt_nKomisyonOrani.EditValue = dr("nKomisyonOrani")
        txt_nBSMV.EditValue = dr("nBSMV")
        txt_nBonusOrani.EditValue = dr("nBonusOrani")
        txt_nBonus_KdvOrani.EditValue = dr("nBonus_KdvOrani")
        sec_bKomisyon_IlkTaksit.Checked = dr("bKomisyon_IlkTaksit")
        sec_nBonus_Puan.SelectedIndex = dr("nBonus_Puan")
        sec_nKomisyonOrani_2_Aciklama.SelectedIndex = dr("nKomisyonOrani_2_Aciklama")
        'sec_bTaksit_Satis.editvalue = dr("bTaksit_Satis")
        sec_bTaksit_Tatil_Gunleri.Checked = dr("bTaksit_Tatil_Gunleri")
        islem = "Düzelt"
        dr = Nothing
        txt_nTaksitSayisi.Focus()
        txt_nTaksitSayisi.SelectAll()
        XtraTabControl2.SelectedTabPageIndex = 0
    End Sub
    Private Sub kayit_sil()
        If XtraMessageBox.Show(Sorgu_sDil("Kaydý Silmek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            tbKdv_kaydet_sil(dr("sOdemeSekli"))
            Dataload_tbKdv()
        End If
    End Sub
    Private Sub kaydet()
        Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        If islem = "Ekle" Then
            Dim nTaksit As Integer = 0
            Dim bS_Cuma_Pazar As Integer = 0
            Dim bS_Cuma_Pazartesi As Integer = 0
            Dim bS_Cuma_Cuma As Integer = 0
            Dim bS_Cuma_Cumartesi As Integer = 0
            Dim bS_Cumartesi_Pazar As Integer = 0
            Dim bS_Cumartesi_Pazartesi As Integer = 0

            If sec_nTaksit0.Checked = True Then
                nTaksit = 0
            ElseIf sec_nTaksit1.Checked = True Then
                nTaksit = 1
            ElseIf sec_nTaksit2.Checked = True Then
                nTaksit = 2
            ElseIf sec_nTaksit3.Checked = True Then
                nTaksit = 3
            End If

            'If sec_bS_Cumartesi_Pazar.Checked = True Then
            '    dr("bS_Cumartesi_Pazar") = 1
            'Else
            '    dr("bS_Cumartesi_Pazar") = 0
            'End If
            'If sec_bS_Cumartesi_Pazartesi.Checked = True Then
            '    dr("bS_Cumartesi_Pazartesi") = 1
            'Else
            '    dr("bS_Cumartesi_Pazartesi") = 0
            'End If
            'If sec_bS_Cumartesi_Günü.Checked = True Then
            '    dr("bS_Cumartesi_Cumartesi") = 1
            'Else
            '    dr("bS_Cumartesi_Cumartesi") = 0
            'End If

            'If sec_bS_Cuma_Pazar.Checked = True Then
            '    dr("bS_Cuma_Pazar") = 1
            'Else
            '    dr("bS_Cuma_Pazar") = 0
            'End If
            'If sec_bS_Cuma_Pazartesi.Checked = True Then
            '    dr("bS_Cuma_Pazartesi") = 1
            'Else
            '    dr("bS_Cuma_Pazartesi") = 0
            'End If
            'If sec_bS_Cuma_Cuma.Checked = True Then
            '    dr("bS_Cuma_Cuma") = 1
            'Else
            '    dr("bS_Cuma_Cuma") = 0
            'End If
            'If sec_bS_Cuma_Cumartesi.Checked = True Then
            '    dr("bS_Cuma_Cumartesi") = 1
            'Else
            '    dr("bS_Cuma_Cumartesi") = 0
            'End If
            'If sec_bS_Cuma_Pazar.SelectedIndex = 0 Then
            '    bS_Cuma_Pazar = 0
            '    bS_Cuma_Pazartesi = 0
            'ElseIf sec_bS_Cuma_Pazar.SelectedIndex = 1 Then
            '    bS_Cuma_Pazar = 1
            '    bS_Cuma_Pazartesi = 1
            'ElseIf sec_bS_Cuma_Pazar.SelectedIndex = 2 Then
            '    bS_Cuma_Pazar = 1
            '    bS_Cuma_Pazartesi = 0
            'ElseIf sec_bS_Cuma_Pazar.SelectedIndex = 3 Then
            '    bS_Cuma_Pazar = 0
            '    bS_Cuma_Pazartesi = 1
            'End If
            'sec_bS_Cuma_Pazar.Checked = dr("bS_Cuma_Pazar")
            'sec_bS_Cuma_Pazartesi.Checked = dr("bS_Cuma_Pazartesi")
            'sec_bS_Cuma_Cuma.Checked = dr("bS_Cuma_Cuma")
            'sec_bS_Cuma_Cumartesi.Checked = dr("bS_Cuma_Cumartesi")


            'sec_bS_Cumartesi_Günü.Checked = dr("bS_Cumartesi_Cumartesi")
            'sec_bS_Cumartesi_Pazar.Checked = dr("bS_Cumartesi_Pazar")
            'sec_bS_Cumartesi_Pazartesi.Checked = dr("bS_Cumartesi_Pazartesi")

            tbKdv_kaydet_yeni(txt_sOdemeSekli.Text, txt_nTaksitSayisi.EditValue, nTaksit, txt_nTaksit1.EditValue, txt_nTaksit2.EditValue, txt_nTaksit3.EditValue, txt_nTaksit4.EditValue, txt_nTaksit5.EditValue, txt_nTaksit6.EditValue, txt_nTaksit7.EditValue, txt_nTaksit8.EditValue, txt_nTaksit9.EditValue, txt_nTaksit10.EditValue, txt_nTaksit11.EditValue, txt_nTaksit12.EditValue, txt_nTaksit13.EditValue, txt_nTaksit14.EditValue, txt_nTaksit15.EditValue, txt_nTaksit16.EditValue, txt_nTaksit17.EditValue, txt_nTaksit18.EditValue, txt_nTaksit19.EditValue, txt_nTaksit20.EditValue, txt_nTaksit21.EditValue, txt_nTaksit22.EditValue, txt_nTaksit23.EditValue, txt_nTaksit24.EditValue, txt_nAlisGun1.EditValue, txt_nAlisGun2.EditValue, txt_nAlisGun3.EditValue, txt_nTaksitGun1.EditValue, txt_nTaksitGun2.EditValue, txt_nTaksitGun3.EditValue, sec_bS_Bulundugu_Ay1.SelectedIndex, sec_bS_Bulundugu_Ay2.SelectedIndex, sec_bS_Bulundugu_Ay3.SelectedIndex, sec_bServisAlisVeristen.SelectedIndex, txt_nKomisyon_Kdv_Orani.EditValue, txt_nKomisyonOrani_2.EditValue, txt_nIlkTaksitSonra.EditValue, sec_bS_Cuma_Pazar.Checked, sec_bS_Cuma_Pazartesi.Checked, sec_bS_Cuma_Cuma.Checked, sec_bS_Cuma_Cumartesi.Checked, sec_bS_Cumartesi_Pazartesi.Checked, sec_bS_Cumartesi_Günü.Checked, sec_bS_Cumartesi_Pazar.Checked, sec_bS_Pazar_Pazartesi.Checked, sec_bt_Cumartesi_Pazartesi.Checked, sec_bT_Pazar_Pazartesi.Checked, txt_nKomisyonOrani.EditValue, txt_nBSMV.EditValue, txt_nBonusOrani.EditValue, txt_nBonus_KdvOrani.EditValue, sec_bKomisyon_IlkTaksit.Checked, sec_nBonus_Puan.SelectedIndex, sec_nKomisyonOrani_2_Aciklama.SelectedIndex, txt_nAlisGun4.EditValue, txt_nAlisGun5.EditValue, txt_nAlisGun6.EditValue, txt_nTaksitGun4.EditValue, txt_nTaksit5.EditValue, txt_nTaksit6.EditValue, sec_bS_Bulundugu_Ay4.SelectedIndex, sec_bS_Bulundugu_Ay5.SelectedIndex, sec_bS_Bulundugu_Ay6.SelectedIndex, 2, sec_bTaksit_Tatil_Gunleri.Checked)
            Dataload_tbKdv()
            GridView1.FocusedRowHandle = GridView1.RowCount - 1
        ElseIf islem = "Düzelt" Then
            ' Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim nTaksit As Integer = 0
            Dim bS_Cuma_Pazar As Integer = 0
            Dim bS_Cuma_Pazartesi As Integer = 0
            Dim bS_Cuma_Cuma As Integer = 0
            Dim bS_Cuma_Cumartesi As Integer = 0
            Dim bS_Cumartesi_Pazar As Integer = 0
            Dim bS_Cumartesi_Pazartesi As Integer = 0
            If sec_nTaksit0.Checked = True Then
                nTaksit = 0
            ElseIf sec_nTaksit1.Checked = True Then
                nTaksit = 1
            ElseIf sec_nTaksit2.Checked = True Then
                nTaksit = 2
            ElseIf sec_nTaksit3.Checked = True Then
                nTaksit = 3
            End If
            'If sec_bS_Cumartesi_Pazar.Checked = True Then
            '    dr("bS_Cumartesi_Pazar") = 1
            'Else
            '    dr("bS_Cumartesi_Pazar") = 0
            'End If
            'If sec_bS_Cumartesi_Pazartesi.Checked = True Then
            '    dr("bS_Cumartesi_Pazartesi") = 1
            'Else
            '    dr("bS_Cumartesi_Pazartesi") = 0
            'End If
            'If sec_bS_Cumartesi_Günü.Checked = True Then
            '    dr("bS_Cumartesi_Cumartesi") = 1
            'Else
            '    dr("bS_Cumartesi_Cumartesi") = 0
            'End If

            'If sec_bS_Cuma_Pazar.Checked = True Then
            '    dr("bS_Cuma_Pazar") = 1
            'Else
            '    dr("bS_Cuma_Pazar") = 0
            'End If
            'If sec_bS_Cuma_Pazartesi.Checked = True Then
            '    dr("bS_Cuma_Pazartesi") = 1
            'Else
            '    dr("bS_Cuma_Pazartesi") = 0
            'End If
            'If sec_bS_Cuma_Cuma.Checked = True Then
            '    dr("bS_Cuma_Cuma") = 1
            'Else
            '    dr("bS_Cuma_Cuma") = 0
            'End If
            'If sec_bS_Cuma_Cumartesi.Checked = True Then
            '    dr("bS_Cuma_Cumartesi") = 1
            'Else
            '    dr("bS_Cuma_Cumartesi") = 0
            'End If
            'sec_bS_Cuma_Pazar.Checked = dr("bS_Cuma_Pazar")
            'sec_bS_Cuma_Pazartesi.Checked = dr("bS_Cuma_Pazartesi")
            'sec_bS_Cuma_Cuma.Checked = dr("bS_Cuma_Cuma")
            'sec_bS_Cuma_Cumartesi.Checked = dr("bS_Cuma_Cumartesi")

            'sec_bS_Cumartesi_Günü.Checked = dr("bS_Cumartesi_Cumartesi")
            'sec_bS_Cumartesi_Pazar.Checked = dr("bS_Cumartesi_Pazar")
            'sec_bS_Cumartesi_Pazartesi.Checked = dr("bS_Cumartesi_Pazartesi")

            'If sec_bS_Cuma_Pazar.SelectedIndex = 0 Then
            '    bS_Cuma_Pazar = 0
            '    bS_Cuma_Pazartesi = 0
            'ElseIf sec_bS_Cuma_Pazar.SelectedIndex = 1 Then
            '    bS_Cuma_Pazar = 1
            '    bS_Cuma_Pazartesi = 1
            'ElseIf sec_bS_Cuma_Pazar.SelectedIndex = 2 Then
            '    bS_Cuma_Pazar = 1
            '    bS_Cuma_Pazartesi = 0
            'ElseIf sec_bS_Cuma_Pazar.SelectedIndex = 3 Then
            '    bS_Cuma_Pazar = 0
            '    bS_Cuma_Pazartesi = 1
            'End If
            'sec_bS_Cuma_Pazar.Checked = dr("bS_Cuma_Pazar")
            'sec_bS_Cuma_Pazartesi.Checked = dr("bS_Cuma_Pazartesi")

            'sec_bS_Cumartesi_Pazar.Checked = dr("bS_Cumartesi_Pazar")
            'sec_bS_Cumartesi_Pazartesi.Checked = dr("bS_Cumartesi_Pazartesi")
            tbKdv_kaydet_duzelt(txt_sOdemeSekli.Text, txt_nTaksitSayisi.EditValue, nTaksit, txt_nTaksit1.EditValue, txt_nTaksit2.EditValue, txt_nTaksit3.EditValue, txt_nTaksit4.EditValue, txt_nTaksit5.EditValue, txt_nTaksit6.EditValue, txt_nTaksit7.EditValue, txt_nTaksit8.EditValue, txt_nTaksit9.EditValue, txt_nTaksit10.EditValue, txt_nTaksit11.EditValue, txt_nTaksit12.EditValue, txt_nTaksit13.EditValue, txt_nTaksit14.EditValue, txt_nTaksit15.EditValue, txt_nTaksit16.EditValue, txt_nTaksit17.EditValue, txt_nTaksit18.EditValue, txt_nTaksit19.EditValue, txt_nTaksit20.EditValue, txt_nTaksit21.EditValue, txt_nTaksit22.EditValue, txt_nTaksit23.EditValue, txt_nTaksit24.EditValue, txt_nAlisGun1.EditValue, txt_nAlisGun2.EditValue, txt_nAlisGun3.EditValue, txt_nTaksitGun1.EditValue, txt_nTaksitGun2.EditValue, txt_nTaksitGun3.EditValue, sec_bS_Bulundugu_Ay1.SelectedIndex, sec_bS_Bulundugu_Ay2.SelectedIndex, sec_bS_Bulundugu_Ay3.SelectedIndex, sec_bServisAlisVeristen.SelectedIndex, txt_nKomisyon_Kdv_Orani.EditValue, txt_nKomisyonOrani_2.EditValue, txt_nIlkTaksitSonra.EditValue, sec_bS_Cuma_Pazar.Checked, sec_bS_Cuma_Pazartesi.Checked, sec_bS_Cuma_Cuma.Checked, sec_bS_Cuma_Cumartesi.Checked, sec_bS_Cumartesi_Pazar.Checked, sec_bS_Cumartesi_Pazartesi.Checked, sec_bS_Cumartesi_Günü.Checked, sec_bS_Pazar_Pazartesi.Checked, sec_bt_Cumartesi_Pazartesi.Checked, sec_bT_Pazar_Pazartesi.Checked, txt_nKomisyonOrani.EditValue, txt_nBSMV.EditValue, txt_nBonusOrani.EditValue, txt_nBonus_KdvOrani.EditValue, sec_bKomisyon_IlkTaksit.Checked, sec_nBonus_Puan.SelectedIndex, sec_nKomisyonOrani_2_Aciklama.SelectedIndex, txt_nAlisGun4.EditValue, txt_nAlisGun5.EditValue, txt_nAlisGun6.EditValue, txt_nTaksitGun4.EditValue, txt_nTaksit5.EditValue, txt_nTaksit6.EditValue, sec_bS_Bulundugu_Ay4.SelectedIndex, sec_bS_Bulundugu_Ay5.SelectedIndex, sec_bS_Bulundugu_Ay6.SelectedIndex, 2, sec_bTaksit_Tatil_Gunleri.Checked)
            Dataload_tbKdv()
            GridView1.FocusedRowHandle = satir
        End If
        XtraTabControl1.SelectedTabPageIndex = 0
        XtraTabPage1.PageVisible = True
        XtraTabPage2.PageVisible = False
        XtraTabControl1.SelectedTabPageIndex = 0
        GridControl1.Focus()
        GridControl1.Select()
    End Sub
    Private Sub btn_vazgec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_vazgec.Click
        XtraTabPage1.PageVisible = True
        XtraTabPage2.PageVisible = False
    End Sub
    Private Sub btn_kaydet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_kaydet.Click
        kaydet()
    End Sub
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        kayit_ekle()
    End Sub
    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        kayit_duzelt()
    End Sub
    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        kayit_sil()
    End Sub
    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        GridView1.ColumnsCustomization()
    End Sub
    Private Sub GörünümüKaydetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GörünümüKaydetToolStripMenuItem.Click
        gorunum_kaydet()
    End Sub
    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        gorunum_yazdir()
    End Sub
    Private Sub gorunum_yazdir()
        printlink1.CreateDocument(ps)
        ps.PreviewRibbonFormEx.Show()
    End Sub
    Private Sub raporla_excel()
        If XtraMessageBox.Show(Sorgu_sDil("Sonuçlarý Excel Dosyasý Oluþturmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim SaveFileDialog1 As New Windows.Forms.SaveFileDialog
            SaveFileDialog1.Filter = "Excel Dosyalarý(*.xls) |*.xls"
            SaveFileDialog1.InitialDirectory = "c:\"
            SaveFileDialog1.FileName = "Rapor.xls"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                GridView1.ExportToXls(SaveFileDialog1.FileName.ToString)
                If XtraMessageBox.Show(Sorgu_sDil("Kaydý Açmak Ýster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    Process.Start(SaveFileDialog1.FileName.ToString)
                End If
            End If
            SaveFileDialog1 = Nothing
        End If
    End Sub
    Private Sub raporla_text()
        If XtraMessageBox.Show(Sorgu_sDil("Sonuçlarý Text Dosyasý Oluþturmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim SaveFileDialog1 As New Windows.Forms.SaveFileDialog
            SaveFileDialog1.Filter = "Text Dosyalarý(*.txt) |*.txt"
            SaveFileDialog1.InitialDirectory = "c:\"
            SaveFileDialog1.FileName = "Rapor.txt"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                GridView1.ExportToText(SaveFileDialog1.FileName.ToString)
                If XtraMessageBox.Show(Sorgu_sDil("Kaydý Açmak Ýster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    Process.Start(SaveFileDialog1.FileName.ToString)
                End If
            End If
            SaveFileDialog1 = Nothing
        End If
    End Sub
    Private Sub raporla_pdf()
        If XtraMessageBox.Show(Sorgu_sDil("Sonuçlarý Metin Dosyasý Oluþturmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim SaveFileDialog1 As New Windows.Forms.SaveFileDialog
            SaveFileDialog1.Filter = "Metin Dosyalarý(*.pdf) |*.pdf"
            SaveFileDialog1.InitialDirectory = "c:\"
            SaveFileDialog1.FileName = "Rapor.pdf"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                GridView1.ExportToPdf(SaveFileDialog1.FileName.ToString)
                If XtraMessageBox.Show(Sorgu_sDil("Kaydý Açmak Ýster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    Process.Start(SaveFileDialog1.FileName.ToString)
                End If
            End If
            SaveFileDialog1 = Nothing
        End If
    End Sub
    Private Sub HýzlýFiltreToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HýzlýFiltreToolStripMenuItem.Click
        If HýzlýFiltreToolStripMenuItem.Checked = False Then
            GridView1.OptionsCustomization.AllowFilter = True
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
            GridView1.OptionsView.ShowAutoFilterRow = True
            HýzlýFiltreToolStripMenuItem.Checked = True
        ElseIf HýzlýFiltreToolStripMenuItem.Checked = True Then
            GridView1.OptionsCustomization.AllowFilter = False
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
            GridView1.OptionsView.ShowAutoFilterRow = False
            HýzlýFiltreToolStripMenuItem.Checked = False
        End If
    End Sub
    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        If MenuItem6.Checked = False Then
            GridView1.OptionsCustomization.AllowFilter = True
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
            MenuItem6.Checked = True
        ElseIf MenuItem6.Checked = True Then
            GridView1.OptionsCustomization.AllowFilter = False
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
            MenuItem6.Checked = False
        End If
    End Sub
    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        If MenuItem7.Checked = False Then
            GridView1.OptionsCustomization.AllowGroup = True
            GridView1.OptionsView.ShowGroupPanel = True
            MenuItem7.Checked = True
        ElseIf MenuItem7.Checked = True Then
            GridView1.OptionsCustomization.AllowGroup = False
            GridView1.OptionsView.ShowGroupPanel = False
            MenuItem7.Checked = False
        End If
    End Sub
    Private Sub MenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem8.Click
        GridView1.ExpandAllGroups()
    End Sub
    Private Sub MenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem9.Click
        GridView1.CollapseAllGroups()
    End Sub
    Private Sub MenuItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem10.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        ElseIf Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub
    Private Sub GridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.DoubleClick
        kayit_duzelt()
    End Sub
    Private Sub GridView1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridView1.KeyDown
        If e.KeyCode = Keys.Enter Then
            kayit_duzelt()
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
    Private Sub frm_tbSinif_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dataload_tbKdv()
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub txt_bSatisYapilamaz_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            btn_kaydet.Focus()
            btn_kaydet.Select()
        End If
    End Sub
    Private Sub GridControl1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyDown
        If e.KeyCode = Keys.Escape Then
            If XtraMessageBox.Show(Sorgu_sDil("Editör Ekranýný Kapatmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                Me.Close()
            End If
        End If
    End Sub
    Private Sub sec_nTaksit0_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_nTaksit0.CheckStateChanged
        If sec_nTaksit0.Checked = True Then
            sec_nTaksit1.Checked = False
            sec_nTaksit2.Checked = False
            sec_nTaksit3.Checked = False
            GroupControl2.Enabled = True
        ElseIf sec_nTaksit0.Checked = False Then
            GroupControl2.Enabled = False
        End If
    End Sub
    Private Sub sec_nTaksit1_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_nTaksit1.CheckStateChanged
        If sec_nTaksit1.Checked = True Then
            sec_nTaksit0.Checked = False
            sec_nTaksit2.Checked = False
            sec_nTaksit3.Checked = False
            sec_bTaksitSatis.Enabled = True
            txt_nIlkTaksitSonra.Enabled = True
        ElseIf sec_nTaksit1.Checked = False Then
            sec_bTaksitSatis.Enabled = False
            txt_nIlkTaksitSonra.Enabled = False
        End If
    End Sub
    Private Sub sec_nTaksit2_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_nTaksit2.CheckStateChanged
        If sec_nTaksit2.Checked = True Then
            sec_nTaksit0.Checked = False
            sec_nTaksit1.Checked = False
            sec_nTaksit3.Checked = False
            txt_nTaksit1.Enabled = True
            txt_nTaksit2.Enabled = True
            txt_nTaksit3.Enabled = True
            txt_nTaksit4.Enabled = True
            txt_nTaksit5.Enabled = True
            txt_nTaksit6.Enabled = True
            txt_nTaksit7.Enabled = True
            txt_nTaksit8.Enabled = True
            txt_nTaksit9.Enabled = True
            txt_nTaksit10.Enabled = True
            txt_nTaksit11.Enabled = True
            txt_nTaksit12.Enabled = True
            txt_nTaksit13.Enabled = True
            txt_nTaksit14.Enabled = True
            txt_nTaksit15.Enabled = True
            txt_nTaksit16.Enabled = True
            txt_nTaksit17.Enabled = True
            txt_nTaksit18.Enabled = True
            txt_nTaksit19.Enabled = True
            txt_nTaksit20.Enabled = True
            txt_nTaksit21.Enabled = True
            txt_nTaksit22.Enabled = True
            txt_nTaksit23.Enabled = True
            txt_nTaksit24.Enabled = True
            GroupControl3.Enabled = True
        ElseIf sec_nTaksit2.Checked = False Then
            txt_nTaksit1.Enabled = False
            txt_nTaksit2.Enabled = False
            txt_nTaksit3.Enabled = False
            txt_nTaksit4.Enabled = False
            txt_nTaksit5.Enabled = False
            txt_nTaksit6.Enabled = False
            txt_nTaksit7.Enabled = False
            txt_nTaksit8.Enabled = False
            txt_nTaksit9.Enabled = False
            txt_nTaksit10.Enabled = False
            txt_nTaksit11.Enabled = False
            txt_nTaksit12.Enabled = False
            txt_nTaksit13.Enabled = False
            txt_nTaksit14.Enabled = False
            txt_nTaksit15.Enabled = False
            txt_nTaksit16.Enabled = False
            txt_nTaksit17.Enabled = False
            txt_nTaksit18.Enabled = False
            txt_nTaksit19.Enabled = False
            txt_nTaksit20.Enabled = False
            txt_nTaksit21.Enabled = False
            txt_nTaksit22.Enabled = False
            txt_nTaksit23.Enabled = False
            txt_nTaksit24.Enabled = False
            GroupControl3.Enabled = False
        End If
    End Sub
    Private Sub sec_nTaksit3_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_nTaksit3.CheckStateChanged
        If sec_nTaksit3.Checked = True Then
            sec_nTaksit1.Checked = False
            sec_nTaksit2.Checked = False
            sec_nTaksit0.Checked = False
        End If
    End Sub
    Private Sub txt_sOdemeSekli_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_sOdemeSekli.Validating
        If islem = "Ekle" Then
            If sorgu_sKdvTipi_kontrol(Trim(txt_sOdemeSekli.Text)) = False Then
                XtraMessageBox.Show(txt_sOdemeSekli.Text & vbTab & Sorgu_sDil("Kaydý Daha Önce Kullanýlmýþ", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
                e.Cancel = True
                txt_sOdemeSekli.Focus()
                txt_sOdemeSekli.SelectAll()
            End If
        End If
    End Sub
    Private Sub txt_nAlisGun1_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_nAlisGun1.EditValueChanged
        If txt_nAlisGun1.EditValue > 0 And txt_nAlisGun1.EditValue < 31 Then
            SpinEdit2.EditValue = txt_nAlisGun1.EditValue + 1
            txt_nAlisGun2.EditValue = 31
            txt_nAlisGun2.Enabled = True
            txt_nTaksitGun2.EditValue = 31
            txt_nTaksitGun2.Enabled = True
            sec_bS_Bulundugu_Ay2.SelectedIndex = 0
            sec_bS_Bulundugu_Ay2.Enabled = True
        Else
            SpinEdit2.EditValue = 0
            txt_nAlisGun2.EditValue = 0
            txt_nAlisGun2.Enabled = False
            txt_nTaksitGun2.EditValue = 0
            txt_nTaksitGun2.Enabled = False
            sec_bS_Bulundugu_Ay2.SelectedIndex = 0
            sec_bS_Bulundugu_Ay2.Enabled = False
        End If
    End Sub
    Private Sub txt_nAlisGun2_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_nAlisGun2.EditValueChanged
        If txt_nAlisGun2.EditValue > 0 And txt_nAlisGun2.EditValue < 31 Then
            SpinEdit3.EditValue = txt_nAlisGun2.EditValue + 1
            txt_nAlisGun3.EditValue = 31
            txt_nAlisGun3.Enabled = True
            txt_nTaksitGun3.EditValue = 31
            txt_nTaksitGun3.Enabled = True
            sec_bS_Bulundugu_Ay3.SelectedIndex = 0
            sec_bS_Bulundugu_Ay3.Enabled = True
        Else
            SpinEdit3.EditValue = 0
            txt_nAlisGun3.EditValue = 0
            txt_nAlisGun3.Enabled = False
            txt_nTaksitGun3.EditValue = 0
            txt_nTaksitGun3.Enabled = False
            sec_bS_Bulundugu_Ay3.SelectedIndex = 0
            sec_bS_Bulundugu_Ay3.Enabled = False
        End If
    End Sub
    Private Sub txt_nAlisGun3_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_nAlisGun3.EditValueChanged
        If txt_nAlisGun3.EditValue > 0 And txt_nAlisGun3.EditValue < 31 Then
            SpinEdit4.EditValue = txt_nAlisGun3.EditValue + 1
            txt_nAlisGun4.EditValue = 31
            txt_nAlisGun4.Enabled = True
            txt_nTaksitGun4.EditValue = 31
            txt_nTaksitGun4.Enabled = True
            sec_bS_Bulundugu_Ay4.SelectedIndex = 0
            sec_bS_Bulundugu_Ay4.Enabled = True
        Else
            SpinEdit4.EditValue = 0
            txt_nAlisGun4.EditValue = 0
            txt_nAlisGun4.Enabled = False
            txt_nTaksitGun4.EditValue = 0
            txt_nTaksitGun4.Enabled = False
            sec_bS_Bulundugu_Ay4.SelectedIndex = 0
            sec_bS_Bulundugu_Ay4.Enabled = False
        End If
    End Sub
    Private Sub txt_nAlisGun4_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_nAlisGun4.EditValueChanged
        If txt_nAlisGun4.EditValue > 0 And txt_nAlisGun4.EditValue < 31 Then
            SpinEdit5.EditValue = txt_nAlisGun4.EditValue + 1
            txt_nAlisGun5.EditValue = 31
            txt_nAlisGun5.Enabled = True
            txt_nTaksitGun5.EditValue = 31
            txt_nTaksitGun5.Enabled = True
            sec_bS_Bulundugu_Ay5.SelectedIndex = 0
            sec_bS_Bulundugu_Ay5.Enabled = True
        Else
            SpinEdit5.EditValue = 0
            txt_nAlisGun5.EditValue = 0
            txt_nAlisGun5.Enabled = False
            txt_nTaksitGun5.EditValue = 0
            txt_nTaksitGun5.Enabled = False
            sec_bS_Bulundugu_Ay5.SelectedIndex = 0
            sec_bS_Bulundugu_Ay5.Enabled = False
        End If
    End Sub
    Private Sub txt_nAlisGun5_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_nAlisGun5.EditValueChanged
        If txt_nAlisGun5.EditValue > 0 And txt_nAlisGun5.EditValue < 31 Then
            SpinEdit6.EditValue = txt_nAlisGun5.EditValue + 1
            txt_nAlisGun6.EditValue = 31
            txt_nAlisGun6.Enabled = True
            txt_nTaksitGun6.EditValue = 31
            txt_nTaksitGun6.Enabled = True
            sec_bS_Bulundugu_Ay6.SelectedIndex = 0
            sec_bS_Bulundugu_Ay6.Enabled = True
        Else
            SpinEdit6.EditValue = 0
            txt_nAlisGun6.EditValue = 0
            txt_nAlisGun6.Enabled = False
            txt_nTaksitGun6.EditValue = 0
            txt_nTaksitGun6.Enabled = False
            sec_bS_Bulundugu_Ay6.SelectedIndex = 0
            sec_bS_Bulundugu_Ay6.Enabled = False
        End If
    End Sub
    Private Sub txt_nAlisGun6_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_nAlisGun6.EditValueChanged
        'If txt_nAlisGun6.EditValue > 0 And txt_nAlisGun6.EditValue < 31 Then
        '    SpinEdit6.EditValue = txt_nAlisGun6.EditValue + 1
        '    txt_nAlisGun2.EditValue = 31
        '    txt_nAlisGun2.Enabled = True
        '    txt_nTaksitGun2.EditValue = 31
        '    txt_nTaksitGun2.Enabled = True
        '    sec_bS_Bulundugu_Ay2.SelectedIndex = 0
        '    sec_bS_Bulundugu_Ay2.Enabled = True
        'Else
        '    SpinEdit2.EditValue = 0
        '    txt_nAlisGun2.EditValue = 0
        '    txt_nAlisGun2.Enabled = False
        '    txt_nTaksitGun2.EditValue = 0
        '    txt_nTaksitGun2.Enabled = False
        '    sec_bS_Bulundugu_Ay2.SelectedIndex = 0
        '    sec_bS_Bulundugu_Ay2.Enabled = False
        'End If
    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        kayit_ekle()
    End Sub
    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        kayit_duzelt()
    End Sub
    Private Sub BarButtonItem3_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        kayit_sil()
    End Sub
    Private Sub BarButtonItem4_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        gorunum_yazdir()
    End Sub
    Private Sub BarButtonItem5_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        raporla_excel()
    End Sub
    Private Sub BarButtonItem6_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        raporla_text()
    End Sub
    Private Sub BarButtonItem7_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem7.ItemClick
        raporla_pdf()
    End Sub

    Private Sub sec_bS_Cuma_Pazar_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub sec_bTaksit_Tatil_Gunleri_CheckedChanged(sender As Object, e As EventArgs) Handles sec_bTaksit_Tatil_Gunleri.CheckedChanged

    End Sub
End Class
