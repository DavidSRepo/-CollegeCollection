Public Class DJSCitySearch2
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        Dim strCity(20) As String
        Dim intFahrtemp(20) As Integer
        Dim j As Integer



        'City Data              Fahrenheit Temperature

        strCity(0) = "Danville" : intFahrtemp(0) = 55
        strCity(1) = "Chicago" : intFahrtemp(1) = 32
        strCity(2) = "Orlando" : intFahrtemp(2) = 77
        strCity(3) = "Denver" : intFahrtemp(3) = 41
        strCity(4) = "London" : intFahrtemp(4) = 48
        strCity(5) = "Tightsqueeze" : intFahrtemp(5) = 56
        strCity(6) = "Hyrule" : intFahrtemp(6) = 85
        strCity(7) = "Namek" : intFahrtemp(7) = 75
        strCity(8) = "Quebec" : intFahrtemp(8) = 67
        strCity(9) = "Richmond" : intFahrtemp(9) = 80
        strCity(10) = "Toronto" : intFahrtemp(10) = 70
        strCity(11) = "Kansas City" : intFahrtemp(11) = 57
        strCity(12) = "Mexico City" : intFahrtemp(12) = 45
        strCity(13) = "San Juan" : intFahrtemp(13) = 90
        strCity(14) = "Manhattan" : intFahrtemp(14) = 20
        strCity(15) = "Los Angeles" : intFahrtemp(15) = 87
        strCity(16) = "Varina" : intFahrtemp(16) = 95
        strCity(17) = "Raleigh" : intFahrtemp(17) = 50
        strCity(18) = "North City" : intFahrtemp(18) = 67
        strCity(19) = "South City" : intFahrtemp(19) = 74
        strCity(20) = "East City" : intFahrtemp(20) = 38
    End Sub

    Private Sub btnF_Click(sender As Object, e As EventArgs) Handles btnF.Click


        For j = 0 To 20
            If strCity(j) = txtUser.Text Then
                lstCity.Items.Add(strCity(j))
                lstTemp.Items.Add(intFehrTemp(j))
            End If
        Next

    End Sub


    Private Sub btnC_Click(sender As Object, e As EventArgs) Handles btnC.Click
        ' (x - 32) * 5/9 = Celsius

        (lstTemp.Items(j) - 32) * 5/9

    End Sub
End Class