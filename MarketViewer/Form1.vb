'Project - MarketViewer
'Author - Adam "domacikolaci" Knezevic
'Last modified - Adam Knezevic 26/07/2016

''' <summary>
''' TODO
''' - https://coinmarketcap-nexuist.rhcloud.com/ use this for the JSON
''' - 
''' </summary>
Public Class frmMain
    Private Sub btnStocks_Click(sender As Object, e As EventArgs) Handles btnStocks.Click
        'Loads frmStock
        frmStock.Show()
        Me.Close()
    End Sub

    Private Sub btnCrypto_Click(sender As Object, e As EventArgs) Handles btnCrypto.Click
        'Load frmCrypto
        frmCrypto.Show()
        Me.Close()
    End Sub
    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        'Load frmAbout
        frmAbout.Show()
    End Sub
End Class
