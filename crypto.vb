Imports System.ComponentModel

Public Class frmCrypto
    Private Sub frmCrypto_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        frmMain.Show()
    End Sub

    Private Sub frmCrypto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class