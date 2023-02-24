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
    Public WithEvents hsbStepSize As System.Windows.Forms.HScrollBar
	Public WithEvents tmrA As System.Windows.Forms.Timer
	Public WithEvents lblS As System.Windows.Forms.Label
	Public WithEvents imgA As System.Windows.Forms.PictureBox
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.hsbStepSize = New System.Windows.Forms.HScrollBar()
        Me.tmrA = New System.Windows.Forms.Timer(Me.components)
        Me.lblS = New System.Windows.Forms.Label()
        Me.imgA = New System.Windows.Forms.PictureBox()
        Me.lblX = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tOff = New System.Windows.Forms.Button()
        Me.TOn = New System.Windows.Forms.Button()
        CType(Me.imgA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'hsbStepSize
        '
        Me.hsbStepSize.Cursor = System.Windows.Forms.Cursors.Default
        Me.hsbStepSize.Location = New System.Drawing.Point(59, 210)
        Me.hsbStepSize.Maximum = 72
        Me.hsbStepSize.Minimum = 2
        Me.hsbStepSize.Name = "hsbStepSize"
        Me.hsbStepSize.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.hsbStepSize.Size = New System.Drawing.Size(177, 33)
        Me.hsbStepSize.SmallChange = 2
        Me.hsbStepSize.TabIndex = 1
        Me.hsbStepSize.TabStop = True
        Me.hsbStepSize.Value = 25
        '
        'tmrA
        '
        Me.tmrA.Enabled = True
        Me.tmrA.Interval = 500
        '
        'lblS
        '
        Me.lblS.BackColor = System.Drawing.SystemColors.Control
        Me.lblS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblS.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblS.Font = New System.Drawing.Font("Arial", 13.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblS.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblS.Location = New System.Drawing.Point(248, 210)
        Me.lblS.Name = "lblS"
        Me.lblS.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblS.Size = New System.Drawing.Size(53, 33)
        Me.lblS.TabIndex = 0
        Me.lblS.Text = "25"
        Me.lblS.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'imgA
        '
        Me.imgA.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgA.Image = CType(resources.GetObject("imgA.Image"), System.Drawing.Image)
        Me.imgA.Location = New System.Drawing.Point(50, 50)
        Me.imgA.Name = "imgA"
        Me.imgA.Size = New System.Drawing.Size(40, 59)
        Me.imgA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgA.TabIndex = 2
        Me.imgA.TabStop = False
        '
        'lblX
        '
        Me.lblX.BackColor = System.Drawing.SystemColors.Control
        Me.lblX.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblX.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblX.Font = New System.Drawing.Font("Arial", 13.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblX.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblX.Location = New System.Drawing.Point(50, 9)
        Me.lblX.Name = "lblX"
        Me.lblX.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblX.Size = New System.Drawing.Size(57, 29)
        Me.lblX.TabIndex = 4
        Me.lblX.Text = "X Loc"
        Me.lblX.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(248, 196)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 14)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Step Size"
        '
        'tOff
        '
        Me.tOff.Location = New System.Drawing.Point(12, 248)
        Me.tOff.Name = "tOff"
        Me.tOff.Size = New System.Drawing.Size(75, 23)
        Me.tOff.TabIndex = 6
        Me.tOff.Text = "Timer Off"
        Me.tOff.UseVisualStyleBackColor = True
        '
        'TOn
        '
        Me.TOn.Location = New System.Drawing.Point(103, 248)
        Me.TOn.Name = "TOn"
        Me.TOn.Size = New System.Drawing.Size(75, 23)
        Me.TOn.TabIndex = 7
        Me.TOn.Text = "Timer On"
        Me.TOn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(368, 283)
        Me.Controls.Add(Me.TOn)
        Me.Controls.Add(Me.tOff)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblX)
        Me.Controls.Add(Me.hsbStepSize)
        Me.Controls.Add(Me.lblS)
        Me.Controls.Add(Me.imgA)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Location = New System.Drawing.Point(634, 279)
        Me.Name = "Form1"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Move Easy Demo"
        CType(Me.imgA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents lblX As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tOff As Button
    Friend WithEvents TOn As Button
#End Region
End Class