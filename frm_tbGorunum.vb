Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Public Class frm_tbGorunum
    Private Sub frm_tbGorunum_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        gorunumler()
    End Sub
    Private Sub gorunumler()
        Dim skinname As String = DevExpress.LookAndFeel.UserLookAndFeel.Default.ActiveSkinName
        For Each cnt As SkinContainer In SkinManager.Default.Skins
            listBoxControl1.Items.Add(cnt.SkinName)
        Next cnt
        listBoxControl1.SelectedItem = skinname
    End Sub
    Public ReadOnly Property SelectedSkinName() As String
        Get
            Return listBoxControl1.SelectedItem.ToString()
        End Get
    End Property
    Public ReadOnly Property AllowAnimation() As Boolean
        Get
            Return checkEdit1.Checked
        End Get
    End Property
    Public ReadOnly Property AllowSkin4Form() As Boolean
        Get
            Return checkEdit2.Checked
        End Get
    End Property
    Private Sub simpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles simpleButton1.Click
        Me.Close()
    End Sub
    Private Sub listBoxControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles listBoxControl1.SelectedIndexChanged
        DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(SelectedSkinName)
    End Sub
End Class