<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlEnumLinkLabel
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
        Me.v_value = New System.Windows.Forms.LinkLabel
        Me._ctx_menu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.v_label = New System.Windows.Forms.Label
        Me.tooltip = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'v_value
        '
        Me.v_value.AutoSize = True
        Me.v_value.ContextMenuStrip = Me._ctx_menu
        Me.v_value.Dock = System.Windows.Forms.DockStyle.Right
        Me.v_value.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.v_value.Location = New System.Drawing.Point(36, 0)
        Me.v_value.Margin = New System.Windows.Forms.Padding(0)
        Me.v_value.Name = "v_value"
        Me.v_value.Size = New System.Drawing.Size(44, 12)
        Me.v_value.TabIndex = 0
        Me.v_value.TabStop = True
        Me.v_value.Text = "Top Right"
        Me.v_value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        '_ctx_menu
        '
        Me._ctx_menu.Name = "_ctx_menu"
        Me._ctx_menu.Size = New System.Drawing.Size(61, 4)
        '
        'v_label
        '
        Me.v_label.AutoSize = True
        Me.v_label.Dock = System.Windows.Forms.DockStyle.Left
        Me.v_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.v_label.Location = New System.Drawing.Point(0, 0)
        Me.v_label.Margin = New System.Windows.Forms.Padding(0)
        Me.v_label.Name = "v_label"
        Me.v_label.Size = New System.Drawing.Size(33, 13)
        Me.v_label.TabIndex = 1
        Me.v_label.Text = "Align:"
        Me.v_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ctlEnumLinkLabel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ContextMenuStrip = Me._ctx_menu
        Me.Controls.Add(Me.v_value)
        Me.Controls.Add(Me.v_label)
        Me.Name = "ctlEnumLinkLabel"
        Me.Size = New System.Drawing.Size(80, 15)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
	Friend WithEvents v_value As System.Windows.Forms.LinkLabel
	Friend WithEvents v_label As System.Windows.Forms.Label
	Friend WithEvents _ctx_menu As System.Windows.Forms.ContextMenuStrip
	Friend WithEvents tooltip As System.Windows.Forms.ToolTip

End Class
