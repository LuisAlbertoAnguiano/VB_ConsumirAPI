Imports RestSharp
Public Class GetAPI
    Public Function GetAPI(url As String)
        'Enviar la url
        Dim client = New RestClient()
        client.BaseUrl = New Uri(url)

        'Obtener la respuesta
        Dim request = New RestRequest()
        request.Method = Method.GET

        Dim response = client.Execute(request).Content.ToString

        Return response
    End Function
End Class