Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

''' <summary>
''' Global moduel for JSON code
''' Currently only working/setup for BTC JSON
''' </summary>
Module Module1
    'Declaring JSON "id's" for Bitcoin
    Structure btcJSON
        Friend symbol As String
        Friend position As String
        Friend name As String
        Structure marketcap
            Friend usd As String
            Friend eur As String
            Friend cny As String
            Friend gbp As String
            Friend cad As String
            Friend rub As String
            Friend hkd As String
            Friend jpy As String
            Friend aud As String
            Friend btc As String
        End Structure
        Structure price
            Friend usd As String
            Friend eur As String
            Friend cny As String
            Friend gbp As String
            Friend cad As String
            Friend rub As String
            Friend hkd As String
            Friend jpy As String
            Friend aud As String
            Friend btc As String
        End Structure
        Friend supply As String
        Structure volume
            Friend usd As String
            Friend eur As String
            Friend cny As String
            Friend gbp As String
            Friend cad As String
            Friend rub As String
            Friend hkd As String
            Friend jpy As String
            Friend aud As String
            Friend btc As String
        End Structure
        Friend change As String
        Friend timestamp As String
    End Structure

    Public element As JObject
    Dim obj As String
    Dim arrBtcJSON(10) As btcJSON
    Dim blnModified As Boolean = False

    Sub json()
        Try
            obj = System.IO.File.ReadAllText("btc.json")
            Dim result = JsonConvert.DeserializeObject(Of List(Of btcJSON))(obj)
            For Each value As btcJSON In result
                'NEED TO TALK TO MITCHEL ABOUT THIS BIT AY
            Next value
        Catch ex As NullReferenceException
            MsgBox("File is empty", vbInformation, "Information")
        Catch ex As System.IO.FileNotFoundException
            System.IO.File.CreateText("btc.json")
        End Try
    End Sub
End Module