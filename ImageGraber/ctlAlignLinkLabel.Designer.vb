<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlAlignLinkLabel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ctlAlignLinkLabel))
        Me._ctx_menu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.v_label = New System.Windows.Forms.Label()
        Me.v_value = New System.Windows.Forms.LinkLabel()
        Me._imagelist = New System.Windows.Forms.ImageList(Me.components)
        Me.tooltip = New System.Windows.Forms.ToolTip(Me.components)
        Me.v_label_picture = New System.Windows.Forms.Label()
        Me.SuspendLayout()
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
        Me.v_label.Padding = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.v_label.Size = New System.Drawing.Size(33, 15)
        Me.v_label.TabIndex = 3
        Me.v_label.Text = "Align:"
        Me.v_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'v_value
        '
        Me.v_value.AutoSize = True
        Me.v_value.ContextMenuStrip = Me._ctx_menu
        Me.v_value.Dock = System.Windows.Forms.DockStyle.Right
        Me.v_value.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.v_value.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.v_value.Location = New System.Drawing.Point(53, 0)
        Me.v_value.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.v_value.Name = "v_value"
        Me.v_value.Padding = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.v_value.Size = New System.Drawing.Size(37, 14)
        Me.v_value.TabIndex = 2
        Me.v_value.TabStop = True
        Me.v_value.Text = "Change"
        Me.v_value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        '_imagelist
        '
        Me._imagelist.ImageStream = CType(resources.GetObject("_imagelist.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me._imagelist.TransparentColor = System.Drawing.Color.White
        Me._imagelist.Images.SetKeyName(0, "top_left.bmp")
        Me._imagelist.Images.SetKeyName(1, "top_center.bmp")
        Me._imagelist.Images.SetKeyName(2, "top_right.bmp")
        Me._imagelist.Images.SetKeyName(3, "middle_left.bmp")
        Me._imagelist.Images.SetKeyName(4, "middle_center.bmp")
        Me._imagelist.Images.SetKeyName(5, "middle_right.bmp")
        Me._imagelist.Images.SetKeyName(6, "bottom_left.bmp")
        Me._imagelist.Images.SetKeyName(7, "bottom_center.bmp")
        Me._imagelist.Images.SetKeyName(8, "bottom_right.bmp")
        '
        'v_label_picture
        '
        Me.v_label_picture.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.v_label_picture.ImageIndex = 0
        Me.v_label_picture.ImageList = Me._imagelist
        Me.v_label_picture.Location = New System.Drawing.Point(33, 0)
        Me.v_label_picture.Margin = New System.Windows.Forms.Padding(0)
        Me.v_label_picture.Name = "v_label_picture"
        Me.v_label_picture.Size = New System.Drawing.Size(22, 16)
        Me.v_label_picture.TabIndex = 4
        Me.v_label_picture.Text = "     "
        '
        'ctlAlignLinkLabel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.v_value)
        Me.Controls.Add(Me.v_label_picture)
        Me.Controls.Add(Me.v_label)
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "ctlAlignLinkLabel"
        Me.Size = New System.Drawing.Size(90, 16)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents _ctx_menu As System.Windows.Forms.ContextMenuStrip
	Friend WithEvents v_label As System.Windows.Forms.Label
	Friend WithEvents v_value As System.Windows.Forms.LinkLabel
	Friend WithEvents _imagelist As System.Windows.Forms.ImageList
	Friend WithEvents v_label_picture As System.Windows.Forms.Label
	Friend WithEvents tooltip As System.Windows.Forms.ToolTip

End Class
