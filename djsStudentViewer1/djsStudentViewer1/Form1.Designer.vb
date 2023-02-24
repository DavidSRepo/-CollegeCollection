<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblA = New System.Windows.Forms.Label()
        Me.lblB = New System.Windows.Forms.Label()
        Me.lblC = New System.Windows.Forms.Label()
        Me.lblD = New System.Windows.Forms.Label()
        Me.lblE = New System.Windows.Forms.Label()
        Me.btnA = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblA
        '
        Me.lblA.AutoSize = True
        Me.lblA.Location = New System.Drawing.Point(12, 18)
        Me.lblA.Name = "lblA"
        Me.lblA.Size = New System.Drawing.Size(44, 13)
        Me.lblA.TabIndex = 0
        Me.lblA.Text = "Number"
        '
        'lblB
        '
        Me.lblB.AutoSize = True
        Me.lblB.Location = New System.Drawing.Point(167, 18)
        Me.lblB.Name = "lblB"
        Me.lblB.Size = New System.Drawing.Size(57, 13)
        Me.lblB.TabIndex = 1
        Me.lblB.Text = "First Name"
        '
        'lblC
        '
        Me.lblC.AutoSize = True
        Me.lblC.Location = New System.Drawing.Point(300, 18)
        Me.lblC.Name = "lblC"
        Me.lblC.Size = New System.Drawing.Size(58, 13)
        Me.lblC.TabIndex = 2
        Me.lblC.Text = "Last Name"
        '
        'lblD
        '
        Me.lblD.AutoSize = True
        Me.lblD.Location = New System.Drawing.Point(454, 18)
        Me.lblD.Name = "lblD"
        Me.lblD.Size = New System.Drawing.Size(61, 13)
        Me.lblD.TabIndex = 3
        Me.lblD.Text = "Class Level"
        '
        'lblE
        '
        Me.lblE.AutoSize = True
        Me.lblE.Location = New System.Drawing.Point(614, 18)
        Me.lblE.Name = "lblE"
        Me.lblE.Size = New System.Drawing.Size(29, 13)
        Me.lblE.TabIndex = 4
        Me.lblE.Text = "GPA"
        '
        'btnA
        '
        Me.btnA.Location = New System.Drawing.Point(303, 136)
        Me.btnA.Name = "btnA"
        Me.btnA.Size = New System.Drawing.Size(89, 37)
        Me.btnA.TabIndex = 5
        Me.btnA.Text = "Click to show info"
        Me.btnA.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnA)
        Me.Controls.Add(Me.lblE)
        Me.Controls.Add(Me.lblD)
        Me.Controls.Add(Me.lblC)
        Me.Controls.Add(Me.lblB)
        Me.Controls.Add(Me.lblA)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblA As Label
    Friend WithEvents lblB As Label
    Friend WithEvents lblC As Label
    Friend WithEvents lblD As Label
    Friend WithEvents lblE As Label
    Friend WithEvents btnA As Button
End Class
