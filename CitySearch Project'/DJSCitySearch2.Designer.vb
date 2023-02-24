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
        Me.components = New System.ComponentModel.Container()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.lstCity = New System.Windows.Forms.ListBox()
        Me.lstTemp = New System.Windows.Forms.ListBox()
        Me.btnC = New System.Windows.Forms.Button()
        Me.btnF = New System.Windows.Forms.Button()
        Me.btnT = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(12, 64)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(100, 20)
        Me.txtUser.TabIndex = 0
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'lstCity
        '
        Me.lstCity.FormattingEnabled = True
        Me.lstCity.Location = New System.Drawing.Point(251, 64)
        Me.lstCity.Name = "lstCity"
        Me.lstCity.Size = New System.Drawing.Size(120, 95)
        Me.lstCity.TabIndex = 2
        '
        'lstTemp
        '
        Me.lstTemp.FormattingEnabled = True
        Me.lstTemp.Location = New System.Drawing.Point(520, 64)
        Me.lstTemp.Name = "lstTemp"
        Me.lstTemp.Size = New System.Drawing.Size(120, 95)
        Me.lstTemp.TabIndex = 3
        '
        'btnC
        '
        Me.btnC.Location = New System.Drawing.Point(21, 165)
        Me.btnC.Name = "btnC"
        Me.btnC.Size = New System.Drawing.Size(75, 59)
        Me.btnC.TabIndex = 4
        Me.btnC.Text = "Click Here For Temp. in Celsius"
        Me.btnC.UseVisualStyleBackColor = True
        '
        'btnF
        '
        Me.btnF.Location = New System.Drawing.Point(21, 93)
        Me.btnF.Name = "btnF"
        Me.btnF.Size = New System.Drawing.Size(75, 66)
        Me.btnF.TabIndex = 5
        Me.btnF.Text = "Click Here For Temp. in Fahrenheit"
        Me.btnF.UseVisualStyleBackColor = True
        '
        'btnT
        '
        Me.btnT.Location = New System.Drawing.Point(12, 12)
        Me.btnT.Name = "btnT"
        Me.btnT.Size = New System.Drawing.Size(75, 23)
        Me.btnT.TabIndex = 6
        Me.btnT.Text = "Tester"
        Me.btnT.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnT)
        Me.Controls.Add(Me.btnF)
        Me.Controls.Add(Me.btnC)
        Me.Controls.Add(Me.lstTemp)
        Me.Controls.Add(Me.lstCity)
        Me.Controls.Add(Me.txtUser)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtUser As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents lstCity As ListBox
    Friend WithEvents lstTemp As ListBox
    Friend WithEvents btnC As Button
    Friend WithEvents btnF As Button
    Friend WithEvents btnT As Button
End Class
