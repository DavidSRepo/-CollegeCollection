Public Class Form1








    Private Sub btnA_Click(sender As Object, e As EventArgs) Handles btnA.Click
        Dim j As Integer

        For j = 100 To 400 Step 50
            Debug.Print(j & "  " & Math.Sqrt(j))
        Next j






    End Sub
End Class
