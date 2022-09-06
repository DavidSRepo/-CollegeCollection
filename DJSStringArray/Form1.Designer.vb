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
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.txtN = New System.Windows.Forms.TextBox()
        Me.lstDays = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lblA
        '
        Me.lblA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblA.Location = New System.Drawing.Point(12, 13)
        Me.lblA.Name = "lblA"
        Me.lblA.Size = New System.Drawing.Size(219, 23)
        Me.lblA.TabIndex = 0
        '
        'lblB
        '
        Me.lblB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblB.Location = New System.Drawing.Point(12, 46)
        Me.lblB.Name = "lblB"
        Me.lblB.Size = New System.Drawing.Size(219, 20)
        Me.lblB.TabIndex = 1
        '
        'lblC
        '
        Me.lblC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblC.Location = New System.Drawing.Point(12, 90)
        Me.lblC.Name = "lblC"
        Me.lblC.Size = New System.Drawing.Size(219, 18)
        Me.lblC.TabIndex = 2
        '
        'btn1
        '
        Me.btn1.Location = New System.Drawing.Point(237, 9)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(75, 23)
        Me.btn1.TabIndex = 3
        Me.btn1.Text = "First"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.Location = New System.Drawing.Point(237, 46)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(75, 23)
        Me.btn2.TabIndex = 4
        Me.btn2.Text = "Reverse"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'btn3
        '
        Me.btn3.Location = New System.Drawing.Point(237, 85)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(75, 23)
        Me.btn3.TabIndex = 5
        Me.btn3.Text = "List"
        Me.btn3.UseVisualStyleBackColor = True
        '
        'txtN
        '
        Me.txtN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtN.Location = New System.Drawing.Point(380, 46)
        Me.txtN.Name = "txtN"
        Me.txtN.Size = New System.Drawing.Size(100, 20)
        Me.txtN.TabIndex = 6
        '
        'lstDays
        '
        Me.lstDays.FormattingEnabled = True
        Me.lstDays.Location = New System.Drawing.Point(360, 193)
        Me.lstDays.Name = "lstDays"
        Me.lstDays.Size = New System.Drawing.Size(120, 95)
        Me.lstDays.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(520, 416)
        Me.Controls.Add(Me.lstDays)
        Me.Controls.Add(Me.txtN)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn1)
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
    Friend WithEvents btn1 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents txtN As TextBox
    Friend WithEvents lstDays As ListBox
End Class
