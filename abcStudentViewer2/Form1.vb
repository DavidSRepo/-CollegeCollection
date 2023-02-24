
' add your name here -- David Shelton
' StudentViewer2
' Date: 2/21/2020

' Reads student data from a text file, stores it in an array of structures.
' Shows one student at a time.
' Will be updated with new tasks.

Imports System.IO

Public Class Form1

    'Global variables
    Dim i As Integer
    Dim k As Integer
    Dim numberOfStudents As Integer = 7    ' size of array
    Dim student(numberOfStudents) As StudentRecord
    Dim inputFile As StreamReader
    Dim B(7) As Integer
    Dim randbox As New Random

    'Prepare the structure
    Structure StudentRecord
        Dim strFName As String
        Dim strLName As String
        Dim intClass As Integer
        Dim sngGPA As Single
    End Structure

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' no changes needed in this subroutine

        ' it reads 7 students data from the file into the array
        ' no error checks needed for this version

        inputFile = File.OpenText("StudentData7.txt")

        For k = 1 To numberOfStudents
            student(k).strFName = inputFile.ReadLine()
            student(k).strLName = inputFile.ReadLine()
            student(k).intClass = inputFile.ReadLine()
            student(k).sngGPA = inputFile.ReadLine()
        Next k

        inputFile.Close()

        k = HScrollBar1.Value  ' set current student as 1 and show info
        ShowAStudent(k)

        For i = 1 To 7      ' creates array B with random values
            B(i) = randbox.Next(20, 80)
        Next
        ShowArrayB()

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        ' no changes needed here (advances to next student)

        If k < numberOfStudents Then  ' advance if not at end
            k = k + 1
        End If

        ShowAStudent(k)     ' call function to show student k
    End Sub

    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        ' write code to back up one student (if not at beginning) by changing k
        If k > 1 Then
            k = k - 1
        End If



        ' do not change the next line, which shows student k
        ShowAStudent(k)
    End Sub

    Private Sub ShowAStudent(HScrollbar)
        ' shows one student's array data based on parameter k
        lblRecordNum.Text = k
        lblFName.Text = student(k).strFName
        lblLName.Text = student(k).strLName
        '  lblClass.Text = student(k).intClass
        If student(k).intClass = 1 Then
            lblClass.Text = " Freshman"
        ElseIf student(k).intClass = 2 Then
            lblClass.Text = "Sophmore"
        Else
            lblClass.Text = "Junior"
        End If
        lblGPA.Text = student(k).sngGPA

    End Sub

    Private Sub ShowArrayB()
        ' call this routine to show array B
        ' no changes needed
        lblB.Text = " "
        For i = 1 To 7
            lblB.Text &= B(i) & "  "
        Next
    End Sub

    Private Sub btnSort_Click(sender As Object, e As EventArgs) Handles btnSort.Click
        ' write the Exchange sort code to sort array B
        Dim ReplacePosn As Integer
        Dim Smallest As Integer
        Dim SmallestPosn As Integer
        Dim SwapHolder As Integer

        For ReplacePosn = 1 To 6
            Smallest = B(7)
            SmallestPosn = 7
            For k = (ReplacePosn - 1) To 7
                If B(k) < B(ReplacePosn) Then
                    Smallest = B(k)
                    SmallestPosn = k
                End If
            Next k

            SwapHolder = B(ReplacePosn)
            B(ReplacePosn) = B(SmallestPosn)
            B(SmallestPosn) = SwapHolder
        Next ReplacePosn



        ' do not change the next line, which shows the array B
        ShowArrayB()
    End Sub

    Private Sub btnSwap_Click(sender As Object, e As EventArgs) Handles btnSwap.Click
        'write code to swap all of student 3's info with all of student 4's info




    End Sub

    Private Sub HScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar1.Scroll
        k = HScrollBar1.Value

        lblRecordNum.Text = k
        lblFName.Text = student(k).strFName
        lblLName.Text = student(k).strLName
        '  lblClass.Text = student(k).intClass
        If student(k).intClass = 1 Then
            lblClass.Text = " Freshman"
        ElseIf student(k).intClass = 2 Then
            lblClass.Text = "Sophmore"
        Else
            lblClass.Text = "Junior"
        End If
        lblGPA.Text = student(k).sngGPA

    End Sub
End Class
