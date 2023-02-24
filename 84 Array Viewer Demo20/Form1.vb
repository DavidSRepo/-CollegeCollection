' array viewer
' incomplete demo of viewing an array one item at a time
' by Lemery and ??
' Feb 2020

Public Class Form1
    Dim strA(5) As String
    Dim J As Integer

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        strA(1) = "ant"        'init the array, starting with index 1, not 0
        strA(2) = "bee"
        strA(3) = "cat"
        strA(4) = "dog"
        strA(5) = "emu"

        J = 1
        lblA.Text = strA(J)     ' show first item in the array
        lblN.Text = J.ToString
    End Sub

    Private Sub btnAdvance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdvance.Click
        ' advance one step in the array
        ' fix the code, which has a bug
        If J < 5 Then
            J = J + 1
            lblA.Text = strA(J)
            lblN.Text = J.ToString
        End If


    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        ' back up one step in the array
        ' fix the code, which has two bugs
        If J > 1 Then
            J = J - 1
            lblA.Text = strA(J)
            lblN.Text = J.ToString
        End If

    End Sub
End Class
