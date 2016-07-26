Imports System.ComponentModel

Public Class frmAbout
    Private Sub frmAbout_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        frmMain.Show()
    End Sub

    Private Sub frmAbout_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class