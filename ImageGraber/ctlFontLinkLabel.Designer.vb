<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlFontLinkLabel
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
		Me.components = New System.ComponentModel.Container()
		Me.v_label = New System.Windows.Forms.Label()
		Me.v_value = New System.Windows.Forms.LinkLabel()
		Me.tooltip = New System.Windows.Forms.ToolTip(Me.components)
		Me.v_font = New System.Windows.Forms.Label()
		Me.SuspendLayout()
		'
		'v_label
		'
		Me.v_label.AutoSize = True
		Me.v_label.Dock = System.Windows.Forms.DockStyle.Left
		Me.v_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.v_label.Location = New System.Drawing.Point(0, 0)
		Me.v_label.Name = "v_label"
		Me.v_label.Padding = New System.Windows.Forms.Padding(0, 2, 0, 0)
		Me.v_label.Size = New System.Drawing.Size(31, 15)
		Me.v_label.TabIndex = 3
		Me.v_label.Text = "Font:"
		Me.v_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'v_value
		'
		Me.v_value.AutoSize = True
		Me.v_value.Dock = System.Windows.Forms.DockStyle.Right
		Me.v_value.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.v_value.Location = New System.Drawing.Point(53, 0)
		Me.v_value.Name = "v_value"
		Me.v_value.Padding = New System.Windows.Forms.Padding(0, 2, 0, 0)
		Me.v_value.Size = New System.Drawing.Size(37, 14)
		Me.v_value.TabIndex = 2
		Me.v_value.TabStop = True
		Me.v_value.Text = "Change"
		'
		'v_font
		'
		Me.v_font.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
					Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.v_font.AutoSize = True
		Me.v_font.Location = New System.Drawing.Point(28, 2)
		Me.v_font.Name = "v_font"
		Me.v_font.Size = New System.Drawing.Size(25, 13)
		Me.v_font.TabIndex = 4
		Me.v_font.Text = "abc"
		'
		'ctlFontLinkLabel
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.v_font)
		Me.Controls.Add(Me.v_label)
		Me.Controls.Add(Me.v_value)
		Me.Name = "ctlFontLinkLabel"
		Me.Size = New System.Drawing.Size(90, 16)
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents v_label As System.Windows.Forms.Label
	Friend WithEvents v_value As System.Windows.Forms.LinkLabel
	Friend WithEvents tooltip As System.Windows.Forms.ToolTip
	Friend WithEvents v_font As System.Windows.Forms.Label

End Class
