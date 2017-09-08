<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOptions2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOptions2))
        Me.btn_apply = New System.Windows.Forms.Button
        Me.btn_cancel = New System.Windows.Forms.Button
        Me.btn_defaults = New System.Windows.Forms.Button
        Me._options = New SceneGrabberNET.CtlOptions3
        Me.SuspendLayout()
        '
        'btn_apply
        '
        Me.btn_apply.Location = New System.Drawing.Point(273, 390)
        Me.btn_apply.Name = "btn_apply"
        Me.btn_apply.Size = New System.Drawing.Size(75, 23)
        Me.btn_apply.TabIndex = 6
        Me.btn_apply.Text = "Apply"
        Me.btn_apply.UseVisualStyleBackColor = True
        '
        'btn_cancel
        '
        Me.btn_cancel.Location = New System.Drawing.Point(370, 390)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancel.TabIndex = 5
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'btn_defaults
        '
        Me.btn_defaults.Location = New System.Drawing.Point(23, 390)
        Me.btn_defaults.Name = "btn_defaults"
        Me.btn_defaults.Size = New System.Drawing.Size(75, 23)
        Me.btn_defaults.TabIndex = 4
        Me.btn_defaults.Text = "Defaults"
        Me.btn_defaults.UseVisualStyleBackColor = True
        '
        '_options
        '
        Me._options.Configuration = Nothing
        Me._options.Location = New System.Drawing.Point(-3, -1)
        Me._options.Name = "_options"
        Me._options.Size = New System.Drawing.Size(465, 383)
        Me._options.TabIndex = 7
        '
        'frmOptions2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(461, 426)
        Me.Controls.Add(Me._options)
        Me.Controls.Add(Me.btn_apply)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_defaults)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmOptions2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Options"
        Me.ResumeLayout(False)

    End Sub
	Friend WithEvents btn_apply As System.Windows.Forms.Button
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
	Friend WithEvents btn_defaults As System.Windows.Forms.Button
	Friend WithEvents _options As SceneGrabberNET.CtlOptions3
End Class
