Imports DevExpress.XtraEditors
Public Class frm_tbAlisVerisAdres
    Public firmano
    Public donemno
    Public connection
    Public nStokFisiID As String = ""
    Public nAlisVerisID As String = ""
    Public nSiparisTipi As Int64 = 1
    Public nFirmaID As Int64 = 0
    Public nAdresID As Int64 = 0
    Public bFatura As Boolean = False
    Public bSiparis As Boolean = False
    Public bParekende As Boolean = False
    Public bAdres As Boolean = False
    Dim ds_tbIl As DataSet
    Dim ds_tbUlke As DataSet
    Private Sub frm_tbAlisVerisAdres_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dataload_tbIl()
        dataload_tbUlke()
        lbl_sTelefon1.Visible = False
        lbl_sTelefon2.Visible = False
        lbl_sTelefon3.Visible = False
        lbl_sFaks.Visible = False
        lbl_sMail.Visible = False
        txt_sTelefon1.Visible = False
        txt_sTelefon2.Visible = False
        txt_sTelefon3.Visible = False
        txt_sFaks.Visible = False
        txt_sEmail.Visible = False
        If bSiparis = True Then
            Dataload_tbFirma(nStokFisiID)
        ElseIf bFatura = True Then
            Dataload_tbFirma(nStokFisiID)
        ElseIf bParekende = True Then
            Dataload_tbFirma(nAlisVerisID)
        ElseIf bAdres = True Then
            lbl_sTelefon1.Visible = True
            lbl_sTelefon2.Visible = True
            lbl_sTelefon3.Visible = True
            lbl_sFaks.Visible = True
            lbl_sMail.Visible = True
            txt_sTelefon1.Visible = True
            txt_sTelefon2.Visible = True
            txt_sTelefon3.Visible = True
            txt_sFaks.Visible = True
            txt_sEmail.Visible = True
            Dataload_tbFirma(nStokFisiID)
        End If
    End Sub
    Private Sub dataload_tbIl()
        ds_tbIl = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sIl FROM         tbIl order by sIl"))
        txt_sIl.Properties.DataSource = ds_tbIl.Tables(0)
    End Sub
    Private Sub dataload_tbUlke()
        ds_tbUlke = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sUlke FROM         tbUlke Order by sUlke"))
        txt_sUlke.Properties.DataSource = ds_tbUlke.Tables(0)
    End Sub
    Public Sub Dataload_tbFirma(ByVal nStokFisiID As String)
        Try
            ds_tbFirma.Tables(0).Clear()
        Catch ex As Exception
        End Try
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        If bSiparis = True Then
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * from tbSiparisPesinAdres WHERE nSiparisTipi= " & nSiparisTipi & " and lSiparisNo ='" & nStokFisiID & "'")
        ElseIf bFatura = True Then
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * from tbStokFisiPesinAdres WHERE nStokFisiID ='" & nStokFisiID & "'")
        ElseIf bParekende = True Then
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * from tbAlisVerisAdres WHERE nAlisVerisID ='" & nStokFisiID & "'")
        ElseIf bAdres = True Then
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * from tbFirmaAdresi WHERE nAdresID ='" & nStokFisiID & "'")
        End If
        cmd.Connection = conn
        conn.Open()
        Dim N As Integer = adapter.Fill(ds_tbFirma, "Table1")
        conn.Close()
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        kaydet()
    End Sub
    Private Sub kaydet()
        Try
            If bFatura = True Or bSiparis = True Then
                tbAlisVerisAdres_kaydet_degistir(nStokFisiID, txt_sAdi.Text, txt_sAdres1.Text, txt_sAdres2.Text, txt_sSemt.Text, txt_sIl.Text, txt_sUlke.Text, txt_sPostaKodu.Text, txt_sVergiDairesi.Text, txt_sVergiNo.Text, sSubeMagaza, txt_sTelefon1.Text, txt_sTelefon2.Text, txt_sTelefon3.Text, txt_sFaks.Text, txt_sEmail.Text)
            ElseIf bParekende = True Then
                tbAlisVerisAdres_kaydet_degistir(nAlisVerisID, txt_sAdi.Text, txt_sAdres1.Text, txt_sAdres2.Text, txt_sSemt.Text, txt_sIl.Text, txt_sUlke.Text, txt_sPostaKodu.Text, txt_sVergiDairesi.Text, txt_sVergiNo.Text, sSubeMagaza, txt_sTelefon1.Text, txt_sTelefon2.Text, txt_sTelefon3.Text, txt_sFaks.Text, txt_sEmail.Text)
            ElseIf bAdres = True Then
                tbAlisVerisAdres_kaydet_degistir(nStokFisiID, txt_sAdi.Text, txt_sAdres1.Text, txt_sAdres2.Text, txt_sSemt.Text, txt_sIl.Text, txt_sUlke.Text, txt_sPostaKodu.Text, txt_sVergiDairesi.Text, txt_sVergiNo.Text, sSubeMagaza, txt_sTelefon1.Text, txt_sTelefon2.Text, txt_sTelefon3.Text, txt_sFaks.Text, txt_sEmail.Text)
            End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.ToString)
        End Try
        Me.Close()
    End Sub
    Private Sub tbAlisVerisAdres_kaydet_degistir(ByVal nStokFisiID As String, ByVal sAciklama As String, ByVal sAdres1 As String, ByVal sAdres2 As String, ByVal sSemt As String, ByVal sIl As String, ByVal sUlke As String, ByVal sPostaKodu As String, ByVal sVergiDairesi As String, ByVal sVergiNo As String, ByVal sSubeMagaza As String, ByVal sTelefon1 As String, ByVal sTelefon2 As String, ByVal sTelefon3 As String, ByVal sFaks As String, ByVal sMail As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        If bSiparis = True Then
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbSiparisPesinAdres SET              sAciklama = N'" & sAciklama & "', sAdres1 = '" & sAdres1 & "', sAdres2 = '" & sAdres2 & "', sSemt = '" & sSemt & "', sIl = '" & sIl & "', sUlke = '" & sUlke & "', sPostaKodu = '" & sPostaKodu & "', sVergiDairesi = '" & sVergiDairesi & "', sVergiNo = '" & sVergiNo & "', sSubeMagaza = '" & sSubeMagaza & "' WHERE nSiparisTipi = " & nSiparisTipi & " and lSiparisNo = '" & nStokFisiID & "'")
        ElseIf bFatura = True Then
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbStokFisiPesinAdres SET              sAciklama = N'" & sAciklama & "', sAdres1 = '" & sAdres1 & "', sAdres2 = '" & sAdres2 & "', sSemt = '" & sSemt & "', sIl = '" & sIl & "', sUlke = '" & sUlke & "', sPostaKodu = '" & sPostaKodu & "', sVergiDairesi = '" & sVergiDairesi & "', sVergiNo = '" & sVergiNo & "', sSubeMagaza = '" & sSubeMagaza & "' WHERE nStokFisiID = '" & nStokFisiID & "'")
        ElseIf bParekende = True Then
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbAlisVerisAdres SET              sAciklama = N'" & sAciklama & "', sAdres1 = '" & sAdres1 & "', sAdres2 = '" & sAdres2 & "', sSemt = '" & sSemt & "', sIl = '" & sIl & "', sUlke = '" & sUlke & "', sPostaKodu = '" & sPostaKodu & "', sVergiDairesi = '" & sVergiDairesi & "', sVergiNo = '" & sVergiNo & "', sSubeMagaza = '" & sSubeMagaza & "' WHERE nAlisVerisID = '" & nStokFisiID & "'")
        ElseIf bAdres = True Then
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbFirmaAdresi SET              sAciklama = N'" & sAciklama & "', sAdres1 = '" & sAdres1 & "', sAdres2 = '" & sAdres2 & "', sSemt = '" & sSemt & "', sIl = '" & sIl & "', sUlke = '" & sUlke & "', sPostaKodu = '" & sPostaKodu & "', sVergiDairesi = '" & sVergiDairesi & "', sVergiNo = '" & sVergiNo & "', sSubeMagaza = '" & sSubeMagaza & "',sTelefon1 = '" & sTelefon1 & "',sTelefon2 = '" & sTelefon2 & "',sTelefon3 = '" & sTelefon3 & "',sFaks = '" & sFaks & "',sMail = '" & sMail & "' WHERE nAdresID = '" & nStokFisiID & "'")
        End If
        cmd.ExecuteNonQuery()
        con.Close()
        con.Dispose()
        cmd.Dispose()
        con = Nothing
        cmd = Nothing
    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Me.Close()
    End Sub
    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        firma_sec()
    End Sub
    Private Sub firma_sec(Optional ByVal islem As Integer = 0)
        'If bFatura = True Or bSiparis = True Then
        Dim frm As New frm_firma_liste
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.islemstatus = True
        frm.kullanici = kullanici
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim dr1 As DataRow
            dr1 = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
            txt_sAdi.Text = Trim(dr1("sAciklama").ToString)
            txt_sAdres1.Text = Trim(dr1("sAdres1").ToString)
            txt_sAdres2.Text = Trim(dr1("sAdres2").ToString)
            txt_sSemt.Text = Trim(dr1("sSemt").ToString)
            txt_sPostaKodu.Text = Trim(dr1("sPostaKodu").ToString)
            txt_sIl.Text = Trim(dr1("sIl").ToString)
            txt_sUlke.Text = Trim(dr1("sUlke").ToString)
            txt_sVergiDairesi.Text = Trim(dr1("sVergiDairesi").ToString)
            txt_sVergiNo.Text = Trim(dr1("sVergiNo").ToString)
            dr1 = Nothing
        End If
        'Else
        'Dim frm As New frm_musteri_liste
        'frm.firmano = firmano
        'frm.donemno = donemno
        'frm.connection = connection
        'frm.islemstatus = True
        'frm.kullanici = kullanici
        'If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
        '    Dim dr1 As DataRow
        '    dr1 = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
        '    txt_sAdi.Text = Trim(dr1("sAdi").ToString) & " " & Trim(dr1("sSoyAdi").ToString)
        '    txt_sAdres1.Text = Trim(dr1("sEvAdresi1").ToString)
        '    txt_sAdres2.Text = Trim(dr1("sEvAdresi2").ToString)
        '    txt_sSemt.Text = Trim(dr1("sEvSemt").ToString)
        '    txt_sPostaKodu.Text = Trim(dr1("sEvPostaKodu").ToString)
        '    txt_sIl.Text = Trim(dr1("sEvIl").ToString)
        '    txt_sUlke.Text = "" 'Trim(dr1("sEvUlke").ToString)
        '    txt_sVergiDairesi.Text = Trim(dr1("sVergiDairesi").ToString)
        '    txt_sVergiNo.Text = Trim(dr1("sVergiNo").ToString)
        '    dr1 = Nothing
        'End If
        'End If
    End Sub
    Private Sub BarButtonItem3_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        If nFirmaID <> 0 Then
            Dim frm As New frm_firma_Adresi
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.islemstatus = True
            frm.kullanici = kullanici
            frm.musterino = nFirmaID
            If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                Dim dr1 As DataRow
                dr1 = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
                txt_sAdi.Text = Trim(dr1("sAciklama").ToString)
                txt_sAdres1.Text = Trim(dr1("sAdres1").ToString)
                txt_sAdres2.Text = Trim(dr1("sAdres2").ToString)
                txt_sSemt.Text = Trim(dr1("sSemt").ToString)
                txt_sPostaKodu.Text = Trim(dr1("sPostaKodu").ToString)
                txt_sIl.Text = Trim(dr1("sIl").ToString)
                txt_sUlke.Text = Trim(dr1("sUlke").ToString)
                txt_sVergiDairesi.Text = Trim(dr1("sVergiDairesi").ToString)
                txt_sVergiNo.Text = Trim(dr1("sVergiNo").ToString)
                dr1 = Nothing
            End If
        End If
    End Sub
End Class