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
        Me.btnMakeList = New System.Windows.Forms.Button()
        Me.lstStu = New System.Windows.Forms.ListBox()
        Me.btnTotal = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnMakeList
        '
        Me.btnMakeList.Location = New System.Drawing.Point(12, 12)
        Me.btnMakeList.Name = "btnMakeList"
        Me.btnMakeList.Size = New System.Drawing.Size(128, 98)
        Me.btnMakeList.TabIndex = 0
        Me.btnMakeList.Text = "Make List"
        Me.btnMakeList.UseVisualStyleBackColor = True
        '
        'lstStu
        '
        Me.lstStu.FormattingEnabled = True
        Me.lstStu.Location = New System.Drawing.Point(260, 15)
        Me.lstStu.Name = "lstStu"
        Me.lstStu.Size = New System.Drawing.Size(120, 95)
        Me.lstStu.TabIndex = 1
        '
        'btnTotal
        '
        Me.btnTotal.Location = New System.Drawing.Point(12, 205)
        Me.btnTotal.Name = "btnTotal"
        Me.btnTotal.Size = New System.Drawing.Size(128, 84)
        Me.btnTotal.TabIndex = 2
        Me.btnTotal.Text = "Totals"
        Me.btnTotal.UseVisualStyleBackColor = True
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(257, 205)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(31, 13)
        Me.lblTotal.TabIndex = 3
        Me.lblTotal.Text = "Total"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.btnTotal)
        Me.Controls.Add(Me.lstStu)
        Me.Controls.Add(Me.btnMakeList)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnMakeList As Button
    Friend WithEvents lstStu As ListBox
    Friend WithEvents btnTotal As Button
    Friend WithEvents lblTotal As Label
End Class
