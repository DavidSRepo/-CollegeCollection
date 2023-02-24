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
    Public WithEvents cmdSort As System.Windows.Forms.Button
	Public WithEvents cmdCreate As System.Windows.Forms.Button
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cmdSort = New System.Windows.Forms.Button
        Me.cmdCreate = New System.Windows.Forms.Button
        Me.lblBefore = New System.Windows.Forms.Label
        Me.lblAfter = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'cmdSort
        '
        Me.cmdSort.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSort.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdSort.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSort.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdSort.Location = New System.Drawing.Point(175, 107)
        Me.cmdSort.Name = "cmdSort"
        Me.cmdSort.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdSort.Size = New System.Drawing.Size(73, 41)
        Me.cmdSort.TabIndex = 1
        Me.cmdSort.Text = "Sort"
        Me.cmdSort.UseVisualStyleBackColor = False
        '
        'cmdCreate
        '
        Me.cmdCreate.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCreate.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCreate.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCreate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCreate.Location = New System.Drawing.Point(85, 107)
        Me.cmdCreate.Name = "cmdCreate"
        Me.cmdCreate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCreate.Size = New System.Drawing.Size(73, 41)
        Me.cmdCreate.TabIndex = 0
        Me.cmdCreate.Text = "Create"
        Me.cmdCreate.UseVisualStyleBackColor = False
        '
        'lblBefore
        '
        Me.lblBefore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBefore.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBefore.Location = New System.Drawing.Point(17, 14)
        Me.lblBefore.Name = "lblBefore"
        Me.lblBefore.Size = New System.Drawing.Size(575, 33)
        Me.lblBefore.TabIndex = 3
        Me.lblBefore.Text = "Before: "
        Me.lblBefore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAfter
        '
        Me.lblAfter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAfter.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAfter.Location = New System.Drawing.Point(17, 58)
        Me.lblAfter.Name = "lblAfter"
        Me.lblAfter.Size = New System.Drawing.Size(575, 33)
        Me.lblAfter.TabIndex = 4
        Me.lblAfter.Text = "    After: "
        Me.lblAfter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(604, 162)
        Me.Controls.Add(Me.lblAfter)
        Me.Controls.Add(Me.lblBefore)
        Me.Controls.Add(Me.cmdSort)
        Me.Controls.Add(Me.cmdCreate)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 13.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Location = New System.Drawing.Point(4, 23)
        Me.Name = "Form1"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Sort Random Array Demo"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblBefore As System.Windows.Forms.Label
    Friend WithEvents lblAfter As System.Windows.Forms.Label
#End Region 
End Class