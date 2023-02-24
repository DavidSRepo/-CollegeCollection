' David Shelton
' djsStudentViewer1
'2/12/2020
'Put 20 students information into an array, click a button to show the information one at a time
'




Imports System.IO

Public Class Form1
    Private Const strFILENAME As String = "StudentData.txt"

    Structure StudentRecord
        Public strFirstName As String
        Public strLastName As String
        Public intClassLevel As Integer
        Public dblGPA As Double
    End Structure

    Dim Student(20) As StudentRecord 'array that holds student data record
    Dim J As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim inputFile As StreamReader


        If File.Exists(strFILENAME) = False Then
            MessageBox.Show("File not found: " & strFILENAME, "Error")
            Exit Sub
        End If

        inputFile = File.OpenText(strFILENAME)
        'Putting the students into an array
        For J = 1 To 20
            Student(J).strFirstName = inputFile.ReadLine()
            Student(J).strLastName = inputFile.ReadLine()
            Student(J).intClassLevel = inputFile.ReadLine()
            Student(J).dblGPA = inputFile.ReadLine()

        Next J


        'shows the first item
        J = 1
        lblA.Text = J.ToString
        lblB.Text = Student(J).strFirstName
        lblC.Text = Student(J).strLastName
        lblD.Text = Student(J).intClassLevel
        lblE.Text = Student(J).dblGPA



    End Sub

    Private Sub btnA_Click(sender As Object, e As EventArgs) Handles btnA.Click
        'shows the stuff

        If J < 20 Then
            J = J + 1
            lblA.Text = J.ToString
            lblB.Text = Student(J).strFirstName
            lblC.Text = Student(J).strLastName
            lblD.Text = Student(J).intClassLevel
            lblE.Text = Student(J).dblGPA
        End If


    End Sub
End Class
