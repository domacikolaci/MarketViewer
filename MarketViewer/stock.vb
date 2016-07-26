Imports System.ComponentModel
Imports MarketViewer

Public Class frmStock
    Private Sub frmStock_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        frmMain.Show()
    End Sub

    Private Sub frmStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class