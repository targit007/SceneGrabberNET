<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlTextboxLink
	Inherits System.Windows.Forms.UserControl

	'UserControl overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container
        Me.v_label = New System.Windows.Forms.Label
        Me.v_value = New System.Windows.Forms.LinkLabel
        Me._tooltip = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'v_label
        '
        Me.v_label.AutoSize = True
        Me.v_label.Dock = System.Windows.Forms.DockStyle.Left
        Me.v_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.v_label.Location = New System.Drawing.Point(0, 0)
        Me.v_label.Name = "v_label"
        Me.v_label.Size = New System.Drawing.Size(31, 13)
        Me.v_label.TabIndex = 5
        Me.v_label.Text = "Text:"
        Me.v_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'v_value
        '
        Me.v_value.AutoSize = True
        Me.v_value.Dock = System.Windows.Forms.DockStyle.Right
        Me.v_value.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.v_value.Location = New System.Drawing.Point(53, 0)
        Me.v_value.Name = "v_value"
        Me.v_value.Size = New System.Drawing.Size(37, 12)
        Me.v_value.TabIndex = 4
        Me.v_value.TabStop = True
        Me.v_value.Text = "Change"
        '
        'ctlTextboxLink
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.v_label)
        Me.Controls.Add(Me.v_value)
        Me.Name = "ctlTextboxLink"
        Me.Size = New System.Drawing.Size(90, 16)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
	Friend WithEvents v_label As System.Windows.Forms.Label
	Friend WithEvents v_value As System.Windows.Forms.LinkLabel
	Friend WithEvents _tooltip As System.Windows.Forms.ToolTip

End Class
