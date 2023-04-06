Imports Newtonsoft.Json
Public Class Interfaz
    Private Sub Interfaz_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BT_Buscar_MouseClick(sender As Object, e As MouseEventArgs) Handles BT_Buscar.MouseClick
        Try
            Dim API = New GetAPI
            Dim url = "https://ipapi.co/"
            Dim IP = TBX_IP.Text
            Dim Formato = "/json/"
            Dim direccion = url + IP + Formato
            Dim response = API.GetAPI(direccion)

            Dim j = JsonConvert.DeserializeObject(Of Atributos)(response)

            TBX_IP.Text = j.ip
            TBX_Version.Text = j.version
            TBX_Continente.Text = j.continent_code
            TBX_Pais.Text = j.country_name
            TBX_Region.Text = j.region
            TBX_Ciudad.Text = j.city
            TBX_CP.Text = j.postal
            TBX_Latitud.Text = j.latitude
            TBX_Longitud.Text = j.longitude
            TBX_Moneda.Text = j.currency_name
        Catch ex As Exception
            MessageBox.Show("IP no valida")
        End Try

    End Sub
End Class
