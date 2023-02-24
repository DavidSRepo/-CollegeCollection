<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class Form1
#Region "Windows Form Designer generated code "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
		'This call is required by the Windows Form Designer.
		InitializeComponent()
	End Sub
	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
		If Disposing Then
			If Not components Is Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(Disposing)
	End Sub
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
    Public WithEvents cmdDraw As System.Windows.Forms.Button
	Public WithEvents picA As System.Windows.Forms.PictureBox
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cmdDraw = New System.Windows.Forms.Button()
        Me.picA = New System.Windows.Forms.PictureBox()
        CType(Me.picA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdDraw
        '
        Me.cmdDraw.BackColor = System.Drawing.SystemColors.Control
        Me.cmdDraw.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdDraw.Font = New System.Drawing.Font("Arial", 13.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDraw.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdDraw.Location = New System.Drawing.Point(157, 375)
        Me.cmdDraw.Name = "cmdDraw"
        Me.cmdDraw.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdDraw.Size = New System.Drawing.Size(167, 33)
        Me.cmdDraw.TabIndex = 0
        Me.cmdDraw.Text = "&Draw"
        Me.cmdDraw.UseVisualStyleBackColor = False
        '
        'picA
        '
        Me.picA.BackColor = System.Drawing.SystemColors.Control
        Me.picA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picA.Cursor = System.Windows.Forms.Cursors.Default
        Me.picA.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.picA.ForeColor = System.Drawing.SystemColors.ControlText
        Me.picA.Location = New System.Drawing.Point(16, 16)
        Me.picA.Name = "picA"
        Me.picA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.picA.Size = New System.Drawing.Size(457, 353)
        Me.picA.TabIndex = 4
        Me.picA.TabStop = False
        '
        'Form1
        '
        Me.AcceptButton = Me.cmdDraw
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(494, 412)
        Me.Controls.Add(Me.cmdDraw)
        Me.Controls.Add(Me.picA)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Location = New System.Drawing.Point(4, 23)
        Me.Name = "Form1"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Intro Graphics Demo"
        CType(Me.picA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region
End Class