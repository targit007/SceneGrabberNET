<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlColorLinkLabel
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
		Me.v_value = New Imaging.ColorButton
		Me.tooltip = New System.Windows.Forms.ToolTip(Me.components)
		Me.SuspendLayout()
		'
		'v_label
		'
		Me.v_label.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
					Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.v_label.Location = New System.Drawing.Point(0, 2)
		Me.v_label.Margin = New System.Windows.Forms.Padding(0)
		Me.v_label.Name = "v_label"
		Me.v_label.Size = New System.Drawing.Size(34, 17)
		Me.v_label.TabIndex = 3
		Me.v_label.Text = "Color:"
		'
		'v_value
		'
		Me.v_value.ButtonColor = System.Drawing.SystemColors.ControlDark
		Me.v_value.Dock = System.Windows.Forms.DockStyle.Right
		Me.v_value.Location = New System.Drawing.Point(40, 0)
		Me.v_value.Name = "v_value"
		Me.v_value.Size = New System.Drawing.Size(50, 16)
		Me.v_value.TabIndex = 4
		Me.v_value.UseVisualStyleBackColor = True
		'
		'ctlColorLinkLabel
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.v_value)
		Me.Controls.Add(Me.v_label)
		Me.Name = "ctlColorLinkLabel"
		Me.Size = New System.Drawing.Size(90, 16)
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents v_label As System.Windows.Forms.Label
	Friend WithEvents v_value As Imaging.ColorButton
	Friend WithEvents tooltip As System.Windows.Forms.ToolTip

End Class
