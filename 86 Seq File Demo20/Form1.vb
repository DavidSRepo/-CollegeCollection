' File Demo
' Demo of reading a few items from a sequential file.
' Remember that the sequential file is not part of the VB form or code.
' It is a separate file.

' By Lemery and ???
' Feb. 2020

' Task 1:  Run the program to see what it is doing.
' Task 2:  Read the code.
'            List the method that reads one item from the file:  ____.ReadLine()_________
' Task 3:  Read the comments to find out where the sequential file is stored.
'            List the usual locations here: __________bin/debug__________
' Task 4:  Read the comments to find the actual filename (as it would appear in My Documents).
'            List the actual filename here: _________SmallData.txt___________
' Task 5:  Using the Visual Studio menus, find and open the sequential file
'            called "SmallData.txt".  Edit it so that the first value
'            is "England".  Save your changes.
' Task 6:  Run your program again. It should be using the edited file,
'            so you should see the new data appear in the form.
' Task 7:  Change the 'Show' routine below to do what it tells you to do.
' Task 8:  Fix anything else that needs fixing.

Option Strict Off

Imports System.IO   ' required line when using files

Public Class Form1
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
    Friend WithEvents lblA As System.Windows.Forms.Label
    Friend WithEvents lblB As System.Windows.Forms.Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Public WithEvents btnShow As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.lblA = New System.Windows.Forms.Label()
        Me.lblB = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnShow
        '
        Me.btnShow.BackColor = System.Drawing.SystemColors.Control
        Me.btnShow.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnShow.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShow.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnShow.Location = New System.Drawing.Point(106, 140)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnShow.Size = New System.Drawing.Size(161, 49)
        Me.btnShow.TabIndex = 4
        Me.btnShow.Text = "&Show Next Item"
        Me.btnShow.UseVisualStyleBackColor = False
        '
        'lblA
        '
        Me.lblA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblA.Location = New System.Drawing.Point(19, 56)
        Me.lblA.Name = "lblA"
        Me.lblA.Size = New System.Drawing.Size(160, 55)
        Me.lblA.TabIndex = 5
        Me.lblA.Text = "the array index will show here in lblA"
        '
        'lblB
        '
        Me.lblB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblB.Location = New System.Drawing.Point(189, 56)
        Me.lblB.Name = "lblB"
        Me.lblB.Size = New System.Drawing.Size(224, 55)
        Me.lblB.TabIndex = 6
        Me.lblB.Text = "one item from the array will show here in lblB"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 20)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Array Index"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(184, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 20)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Country"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(8, 19)
        Me.ClientSize = New System.Drawing.Size(359, 179)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblB)
        Me.Controls.Add(Me.lblA)
        Me.Controls.Add(Me.btnShow)
        Me.Name = "Form1"
        Me.Text = "File Demo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    ' We store the actual filename into strFILENAME for use later.
    ' Remember that the file itself should be copied to
    '    the BIN or BIN/DEBUG folder of your project.
    Private Const strFILENAME As String = "SmallData.txt"

    Dim strA(5) As String       ' array to hold items from the file
    Dim J As Integer = 0


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' This procedure opens the file, reads a few values 
        ' from the file, and puts them into an array

        ' No changes are needed to this routine in this simple version

        Dim inputFile As StreamReader
        Dim strTemp As String

        ' The IF stmt checks to see if the file exists.
        ' if it does not, we show an error and exit the entire subroutine.
        If File.Exists(strFILENAME) = False Then
            MessageBox.Show("File not found: " & strFILENAME, "Error")
            Exit Sub
        End If

        ' at this point in the code, we know the file exists

        inputFile = File.OpenText(strFILENAME)

        ' This demo only reads a few items from the file
        ' [Don't change this program,
        '     but to read more items, you would change to a loop.]
        strTemp = inputFile.ReadLine()
        strA(1) = strTemp

        strTemp = inputFile.ReadLine()
        strA(2) = strTemp

        strTemp = inputFile.ReadLine()
        strA(3) = strTemp



        ' For J = 1 To 5
        'strA(J) = inputFile.ReadLine()
        ' Next J

        lblB.Text = "A few items were read from the file"
        lblB.BackColor = Color.Ivory

        ' later we will use the array (not the file) to show the data
        ' so we are done with the file
        inputFile.Close()


    End Sub

    Private Sub btnShow_Click(ByVal sender As System.Object,
        ByVal e As System.EventArgs) Handles btnShow.Click

        ' This procedure uses the array created by the form load.
        ' It should show one item at a time from the array.

        ' It has bugs that need fixing, since it always shows item 1
        ' You will need a subscript like J that changes once each time
        If J < 5 Then
            J = J + 1
            lblA.Text = J.ToString
            lblB.Text = strA(J)
        End If


        lblB.BackColor = Color.AliceBlue

    End Sub

End Class
