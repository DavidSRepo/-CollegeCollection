Option Strict Off
Friend Class Form1
    Inherits System.Windows.Forms.Form
    ' Sort Random Array Demo, by Lemery, Feb. 2020
    ' Corrections made by ???

    ' create an array A(1)thru A(20)
    ' each value should be a random integer 10 thru 99 (needs fixing)
    ' show that array
    ' sort that array (needs fixing) and show the sorted version.

    Dim A(20) As Integer
    Dim j As Integer

    Private Sub cmdCreate_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCreate.Click
        ' add code for random number generator      

        Dim randNumb As New Random                   'fixed

        ' fill the array with random values 
        For j = 1 To 20
            ' fix these lines to use random integers
            ' in the range 10 thru 99.

            A(j) = randNumb.Next(10, 100)

        Next j

        ' show the array in lblBefore
        lblBefore.Text = "Before: "
        For j = 1 To 20
            lblBefore.Text = lblBefore.Text & A(j) & " "
        Next j
        lblAfter.Text = "    After: "   'reset lblAfter
    End Sub

    Private Sub cmdSort_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSort.Click
        ' add code to sort the array using the Exchange sort

        Dim ReplacePosn As Integer
        Dim Smallest As Integer
        Dim SmallestPosn As Integer
        Dim SwapHolder As Integer

        For ReplacePosn = 1 To 19

            ' look for the smallest entry in the array,
            ' and its position in the array

            ' initialize ...
            ' code as much as you can without peeking at the handout
            Smallest = A(ReplacePosn)                    'fixed
            SmallestPosn = ReplacePosn

            ' now look for a smaller value in the rest of the array
            For j = (ReplacePosn + 1) To 20      'fixed
                If A(j) < Smallest Then                   'fixed

                    Smallest = A(j)             'fixed

                    SmallestPosn = j            'fixed
                End If
            Next j

            ' write the code to swap the the proper stuff

            SwapHolder = A(ReplacePosn)
            A(ReplacePosn) = Smallest
            A(SmallestPosn) = SwapHolder
            ' ??                                'fix


        Next ReplacePosn

        ' then show the sorted array in lblAfter
        lblAfter.Text = "    After: "
        For j = 1 To 20
            lblAfter.Text = lblAfter.Text & A(j) & " "
        Next j

    End Sub

End Class