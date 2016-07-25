'Project - MarketViewer
'Author - Adam "domacikolaci" Knezevic
'Last modified - Adam Knezevic 25/07/2016

Public Class frmMain
    Private Sub btnStocks_Click(sender As Object, e As EventArgs) Handles btnStocks.Click
        'Loads frmStock
        frmStock.Show()
    End Sub

    Private Sub btnCrypto_Click(sender As Object, e As EventArgs) Handles btnCrypto.Click
        'Load frmCrypto
        frmCrypto.Show()
    End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        'Load frmAbout
        frmAbout.Show()
    End Sub
End Class
