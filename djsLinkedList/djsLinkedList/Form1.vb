Public Class Form1
    Dim stuName(12) As String
    Dim qty(12) As Integer
    Dim link(12) As Integer
    Dim Current As Integer
    Dim First As Integer
    Dim Total As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        Total = 0
        First = 3
        stuName(1) = ”Barb” : qty(1) = 40 : link(1) = 12
        stuName(3) = ”Betty” : qty(3) = 20 : link(3) = 5
        stuName(5) = ”Jim” : qty(5) = 70 : link(5) = 10
        stuName(6) = ”Jon” : qty(6) = 100 : link(6) = 0
        stuName(7) = ”Sally” : qty(7) = 60 : link(7) = 1
        stuName(10) = ”Mike” : qty(10) = 80 : link(10) = 7
        stuName(12) = ”Julie” : qty(12) = 90 : link(12) = 6

    End Sub

    Private Sub btnMakeList_Click(sender As Object, e As EventArgs) Handles btnMakeList.Click
        Current = First
        Do Until (Current = 0)
            lstStu.Items.Add(stuName(Current))
            Current = link(Current)
        Loop

    End Sub

    Private Sub btnTotal_Click(sender As Object, e As EventArgs) Handles btnTotal.Click


    End Sub
End Class
