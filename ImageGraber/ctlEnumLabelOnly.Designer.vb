<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlEnumLabelOnly
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
        Me.tooltip = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'v_value
        '
        Me.v_value.AutoSize = True
        Me.v_value.ForeColor = System.Drawing.Color.Coral
        Me.v_value.Location = New System.Drawing.Point(3, 0)
        Me.v_value.Name = "v_value"
        Me.v_value.Size = New System.Drawing.Size(49, 13)
        Me.v_value.TabIndex = 0
        Me.v_value.TabStop = True
        Me.v_value.Text = "Seconds"
        Me.v_value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        '_ctx_menu
        '
        Me._ctx_menu.Name = "_ctx_menu"
        Me._ctx_menu.Size = New System.Drawing.Size(61, 4)
        '
        'ctlEnumLabelOnly
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Controls.Add(Me.v_value)
        Me.Name = "ctlEnumLabelOnly"
        Me.Size = New System.Drawing.Size(52, 15)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents v_value As System.Windows.Forms.LinkLabel
    Friend WithEvents _ctx_menu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents tooltip As System.Windows.Forms.ToolTip

End Class
