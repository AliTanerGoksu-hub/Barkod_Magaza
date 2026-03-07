Imports Microsoft.Win32

Public Class frm_KampanyaTanim
    Dim conn As New OleDb.OleDbConnection
    Dim con As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand
    Dim adapter As New OleDb.OleDbDataAdapter
    Dim DS As New DataSet
    Dim satir
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        Dim ds As DataSet
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        If list1_Check.Checked = True Then
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbKampanyaTanim SET list1_Check= '" & list1_Check.Checked & "',Liste1_basla = '" & liste1_bas.Value & "', Liste1_bitis = '" & liste1_bit.Value & "'")
        Else
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbKampanyaTanim SET list1_Check= '" & list1_Check.Checked & "',Liste1_basla = '" & 0 & "', Liste1_bitis = '" & 0 & "' ")
        End If
        If list2_Check.Checked = True Then
            cmd.CommandText += sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbKampanyaTanim SET list2_Check= '" & list2_Check.Checked & "' ,Liste2_basla = '" & liste2_bas.Value & "', Liste2_bitis = '" & liste2_bit.Value & "'")
        Else
            cmd.CommandText += sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbKampanyaTanim SET list2_Check= '" & list2_Check.Checked & "',Liste2_basla = '" & 0 & "', Liste2_bitis = '" & 0 & "'")
        End If
        If list3_Check.Checked = True Then
            cmd.CommandText += sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbKampanyaTanim SET list3_Check= '" & list3_Check.Checked & "',Liste3_basla = '" & liste3_bas.Value & "', Liste3_bitis = '" & liste3_bit.Value & "'")
        Else
            cmd.CommandText += sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbKampanyaTanim SET list3_Check= '" & list3_Check.Checked & "',Liste3_basla = '" & 0 & "', Liste3_bitis = '" & 0 & "' ")
        End If
        If list4_Check.Checked = True Then
            cmd.CommandText += sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbKampanyaTanim SET list4_Check= '" & list4_Check.Checked & "',Liste4_basla = '" & liste4_bas.Value & "', Liste4_bitis = '" & liste4_bit.Value & "'")
        Else
            cmd.CommandText += sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbKampanyaTanim SET list4_Check= '" & list4_Check.Checked & "', Liste4_basla = '" & 0 & "', Liste4_bitis = '" & 0 & "'")
        End If
        If list5_Check.Checked = True Then
            cmd.CommandText += sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbKampanyaTanim SET list5_Check= '" & list5_Check.Checked & "',Liste5_basla = '" & liste5_bas.Value & "', Liste5_bitis = '" & liste5_bit.Value & "'")
        Else
            cmd.CommandText += sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbKampanyaTanim SET list5_Check= '" & list5_Check.Checked & "',Liste5_basla = '" & 0 & "', Liste5_bitis = '" & 0 & "'")
        End If
        If list6_Check.Checked = True Then
            cmd.CommandText += sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbKampanyaTanim SET list6_Check= '" & list6_Check.Checked & "',Liste6_basla = '" & liste6_bas.Value & "', Liste6_bitis = '" & liste6_bit.Value & "' ")
        Else
            cmd.CommandText += sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbKampanyaTanim SET list6_Check= '" & list6_Check.Checked & "',Liste6_basla = '" & 0 & "', Liste6_bitis = '" & liste6_bit.Value & "' ")
        End If

        'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbKampanyaTanim SET Liste1_basla = '" & liste1_bas.Value & "', Liste1_bitis = '" & liste1_bit.Value & "',Liste2_basla = '" & liste2_bas.Value & "', Liste2_bitis = '" & liste2_bit.Value & "',Liste3_basla = '" & liste3_bas.Value & "', Liste3_bitis = '" & liste3_bit.Value & "',Liste4_basla = '" & liste4_bas.Value & "', Liste4_bitis = '" & liste4_bit.Value & "',Liste5_basla = '" & liste5_bas.Value & "', Liste5_bitis = '" & liste5_bit.Value & "',Liste6_basla = '" & liste6_bas.Value & "', Liste6_bitis = '" & liste6_bit.Value & "' ")
        cmd.ExecuteNonQuery()
        con.Close()
        Form1.list1_Check = list1_Check.Checked
        Form1.list2_Check = list2_Check.Checked
        Form1.list3_Check = list3_Check.Checked
        Form1.list4_Check = list4_Check.Checked
        Form1.list5_Check = list5_Check.Checked
        Form1.list6_Check = list6_Check.Checked
        Form1.liste1_bas = liste1_bas.Value
        Form1.liste1_bit = liste1_bit.Value
        Form1.liste2_bas = liste2_bas.Value
        Form1.liste2_bit = liste2_bit.Value
        Form1.liste3_bas = liste3_bas.Value
        Form1.liste3_bit = liste3_bit.Value
        Form1.liste4_bas = liste4_bas.Value
        Form1.liste4_bit = liste4_bit.Value
        Form1.liste5_bas = liste5_bas.Value
        Form1.liste5_bit = liste5_bit.Value
        Form1.liste6_bas = liste6_bas.Value
        Form1.liste6_bit = liste6_bit.Value
        Me.Close()
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub


    Private Sub frm_KampanyaTanim_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        liste1_bas.Enabled = list1_Check.Checked
        liste1_bit.Enabled = list1_Check.Checked
        liste2_bas.Enabled = list2_Check.Checked
        liste2_bit.Enabled = list2_Check.Checked
        liste3_bas.Enabled = list3_Check.Checked
        liste3_bit.Enabled = list3_Check.Checked
        liste4_bas.Enabled = list4_Check.Checked
        liste4_bit.Enabled = list4_Check.Checked
        liste5_bas.Enabled = list5_Check.Checked
        liste5_bit.Enabled = list5_Check.Checked
        liste6_bas.Enabled = list6_Check.Checked
        liste6_bit.Enabled = list6_Check.Checked

        Dataload_tbKampanyaTanim()

    End Sub
    Private Sub Dataload_tbKampanyaTanim()
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        con.ConnectionString = connection
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * From tbKampanyaTanim ")
        cmd.Connection = con
        con.Open()
        Dim DR As OleDb.OleDbDataReader = cmd.ExecuteReader
        While DR.Read
            liste1_bas.Value = DR("Liste1_basla")
            liste1_bit.Value = DR("Liste1_bitis")
            liste2_bas.Value = DR("Liste2_basla")
            liste2_bit.Value = DR("Liste2_bitis")
            liste3_bas.Value = DR("Liste3_basla")
            liste3_bit.Value = DR("Liste3_bitis")
            liste4_bas.Value = DR("Liste4_basla")
            liste4_bit.Value = DR("Liste4_bitis")
            liste5_bas.Value = DR("Liste5_basla")
            liste5_bit.Value = DR("Liste5_bitis")
            liste6_bas.Value = DR("Liste6_basla")
            liste6_bit.Value = DR("Liste6_bitis")
            list1_Check.Enabled = DR("list1_Check")
            list2_Check.Enabled = DR("list2_Check")
            list3_Check.Enabled = DR("list3_Check")
            list4_Check.Enabled = DR("list4_Check")
            list5_Check.Enabled = DR("list5_Check")
            list6_Check.Enabled = DR("list6_Check")

            If list1_Check.Enabled = True Then
                list1_Check.Checked = True
            Else
                list1_Check.Enabled = True
            End If
            If list2_Check.Enabled = True Then
                list2_Check.Checked = True
            Else
                list2_Check.Enabled = True
            End If
            If list3_Check.Enabled = True Then
                list3_Check.Checked = True
            Else
                list3_Check.Enabled = True
            End If
            If list4_Check.Enabled = True Then
                list4_Check.Checked = True
            Else
                list4_Check.Enabled = True
            End If
            If list5_Check.Enabled = True Then
                list5_Check.Checked = True
            Else
                list5_Check.Enabled = True
            End If
            If list6_Check.Enabled = True Then
                list6_Check.Checked = True
            Else
                list6_Check.Enabled = True
            End If
        End While
        con.Close()
    End Sub

    Private Sub list1_Check_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles list1_Check.CheckedChanged
        liste1_bas.Enabled = list1_Check.Checked
        liste1_bit.Enabled = list1_Check.Checked
    End Sub
    Private Sub list2_Check_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles list2_Check.CheckedChanged
        liste2_bas.Enabled = list2_Check.Checked
        liste2_bit.Enabled = list2_Check.Checked
    End Sub
    Private Sub list3_Check_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles list3_Check.CheckedChanged
        liste3_bas.Enabled = list3_Check.Checked
        liste3_bit.Enabled = list3_Check.Checked
    End Sub
    Private Sub list4_Check_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles list4_Check.CheckedChanged
        liste4_bas.Enabled = list4_Check.Checked
        liste4_bit.Enabled = list4_Check.Checked
    End Sub
    Private Sub list5_Check_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles list5_Check.CheckedChanged
        liste5_bas.Enabled = list5_Check.Checked
        liste5_bit.Enabled = list5_Check.Checked
    End Sub
    Private Sub list6_Check_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles list6_Check.CheckedChanged
        liste6_bas.Enabled = list6_Check.Checked
        liste6_bit.Enabled = list6_Check.Checked
    End Sub
End Class
