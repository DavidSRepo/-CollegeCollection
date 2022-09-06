Public Class Form1
    ' program: DJSCH3AddingDemo
    ' coded by: David Shelton
    ' date: Aug 27, 2018
    ' goal: repeatedly add a user value to a total


    Dim strWeekDay() As String = {"Mon", "Tues", "Wed", "Thurs", "Fri"}

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click


        Debug.Print(strWeekDay(4))

        lblA.Text = strWeekDay(0)


        lblB.Text = strWeekDay(1) & strWeekDay(3)


        Debug.Print(strWeekDay.Length)

        Dim J As Integer
        For J = 0 To 4
            Debug.Print(strWeekDay(J))
        Next J
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click

        Dim R As Integer
        For R = 4 To 0 Step -1
            Debug.Print(strWeekDay(R))
        Next R




        Dim O As Integer
        Dim strSmallest As String
        strSmallest = strWeekDay(0)
        For O = 0 To 4
            If strWeekDay(O) < strSmallest Then
                strSmallest = strWeekDay(O)
            End If


        Next O
        lblB.Text = "The smallest is " & strSmallest



    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click



        Dim K As Integer
        K = CInt(txtN.Text)
        lblC.Text = strWeekDay(K)


        Dim J As Integer
        For J = 0 To 4
            lstDays.Items.Add(strWeekDay(J))

        Next J
    End Sub
End Class