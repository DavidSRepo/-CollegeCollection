Friend Class Form1
    Inherits System.Windows.Forms.Form
    'Program: Move Easy
    'Author:  Lemery and ?
    'Date:    Feb 2020
    'Goal:    Demo of moving an image
    '         A timer is used to automatically move the image
    '         A scrollbar eventually controls the movement stepsize

    ' Student tasks:
    ' 1) Run the program and watch what happens
    ' 2) Change the timer's Interval property
    '       so that the image moves once every 1/2 second
    ' 3) In Form_Load, change mSidewaysStep from 25 to 10 and run the program.
    ' 4) Even though the scrollbar isn't fully working ...
    '       Fill in the blanks below:
    '       a) Experiment by dragging the slider
    '          What are the min __2__ and max __70___ values you can get?
    '       b) Experiment by clicking on the arrows
    '          By how much is the scrollbar value changing? __2__
    '       c) Experiment by clicking in the "shaft"
    '          By how much is the scrollbar value changing? _3___

    ' 5) Stop the program and examine the scrollbar properties.
    '    List the five key numeric properties of the scrollbar,
    '    and their initial (design) settings in this program.
    '    I have done two of the five as examples below.
    '       - Minimum:  2
    '       - Maximum: 72
    '       - large change:3
    '       -small change:2
    '       - Value:  25

    ' 6) Set the scrollbar property to 10 so that
    '       the user can click in the scrollbar 'shaft' 
    '       to change the value by 10 at a time.
    '       Test your program with the new setting.
    ' 7) Make the scrollbar work,
    '       so that it controls how far the image moves each step.

    ' 8) Change the tmrA_Timer code
    '       so that the image wraps back to the left
    '       only after it reaches the right edge of the form.

    '  9) Add a button to disable the timer, and test it.
    ' 10) Add a button to re-enable the timer, and test it.

    Dim mSidewaysStep As Integer     'amount of x movement

    Private Sub Form1_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        ' You can use Form_Load to give initial values to module level variables

        mSidewaysStep = 2

    End Sub

    Private Sub tmrA_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles tmrA.Tick
        ' if the timer interval setting is n,
        ' this routine automatically activates once every n milliseconds
        ' Examples: an Interval of 1000 means it activates once every 1.000 seconds
        '           an Interval of 50 means it activates once every .050 seconds

        ' The following code makes the image move sideways
        '   each time that tmrA is activated.

        Dim x, y, w, h As Integer

        x = imgA.Location.X
        y = imgA.Location.Y
        w = imgA.Width
        h = imgA.Height

        x = x + mSidewaysStep    ' adjust x coord of picture

        ' this code makes the image "wrap around" if too far to the right
        If x > 360 Then
            x = 0       ' move image to far left
        End If

        ' draw image using new x (other values the same)
        imgA.SetBounds(x, y, w, h)

        lblX.Text = x.ToString      ' show x location

    End Sub
    Private Sub hsbStepSize_Scroll(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.ScrollEventArgs) Handles hsbStepSize.Scroll

        ' Make this scrollbar do more than just show its value.
        ' It should also change the size of the animation step

        lblS.Text = hsbStepSize.Value.ToString
        mSidewaysStep = hsbStepSize.Value



    End Sub

    Private Sub tOff_Click(sender As Object, e As EventArgs) Handles tOff.Click
        tmrA.Stop()
    End Sub

    Private Sub TOn_Click(sender As Object, e As EventArgs) Handles TOn.Click
        tmrA.Start()
    End Sub
End Class