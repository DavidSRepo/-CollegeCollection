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
        Me.lblA = New System.Windows.Forms.Label
        Me.btnBack = New System.Windows.Forms.Button
        Me.btnAdvance = New System.Windows.Forms.Button
        Me.lblN = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'lblA
        '
        Me.lblA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblA.Location = New System.Drawing.Point(190, 31)
        Me.lblA.Name = "lblA"
        Me.lblA.Size = New System.Drawing.Size(82, 38)
        Me.lblA.TabIndex = 0
        Me.lblA.Text = "lblA"
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(92, 86)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(117, 40)
        Me.btnBack.TabIndex = 1
        Me.btnBack.Text = "Back Up"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnAdvance
        '
        Me.btnAdvance.Location = New System.Drawing.Point(225, 86)
        Me.btnAdvance.Name = "btnAdvance"
        Me.btnAdvance.Size = New System.Drawing.Size(117, 40)
        Me.btnAdvance.TabIndex = 2
        Me.btnAdvance.Text = "Next"
        Me.btnAdvance.UseVisualStyleBackColor = True
        '
        'lblN
        '
        Me.lblN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblN.Location = New System.Drawing.Point(159, 31)
        Me.lblN.Name = "lblN"
        Me.lblN.Size = New System.Drawing.Size(25, 38)
        Me.lblN.TabIndex = 3
        Me.lblN.Text = "1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 162)
        Me.Controls.Add(Me.lblN)
        Me.Controls.Add(Me.btnAdvance)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblA)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "Form1"
        Me.Text = "Simple Array Viewer"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblA As System.Windows.Forms.Label
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnAdvance As System.Windows.Forms.Button
    Friend WithEvents lblN As System.Windows.Forms.Label

End Class
