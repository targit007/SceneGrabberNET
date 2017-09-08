<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlScenesBox
    Inherits SceneGrabberNET.AUserControl

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
        Me.Panel1 = New System.Windows.Forms.Panel
        Me._btn_save = New System.Windows.Forms.Button
        Me._btn_preview = New System.Windows.Forms.Button
        Me._btn_delete_all = New System.Windows.Forms.Button
        Me._btn_options = New System.Windows.Forms.Button
        Me._btn_delete = New System.Windows.Forms.Button
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me._listview = New SceneGrabberNET.ctlScenesListView
        Me.pbar = New System.Windows.Forms.ProgressBar
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me._btn_save)
        Me.Panel1.Controls.Add(Me._btn_preview)
        Me.Panel1.Controls.Add(Me._btn_delete_all)
        Me.Panel1.Controls.Add(Me._btn_options)
        Me.Panel1.Controls.Add(Me._btn_delete)
        Me.Panel1.Location = New System.Drawing.Point(545, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(34, 481)
        Me.Panel1.TabIndex = 2
        '
        '_btn_save
        '
        Me._btn_save.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._btn_save.Image = Global.SceneGrabberNET.My.Resources.Resources.disk_black
        Me._btn_save.Location = New System.Drawing.Point(4, 123)
        Me._btn_save.Name = "_btn_save"
        Me._btn_save.Size = New System.Drawing.Size(25, 25)
        Me._btn_save.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me._btn_save, "save sceneshot image")
        Me._btn_save.UseVisualStyleBackColor = True
        '
        '_btn_preview
        '
        Me._btn_preview.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._btn_preview.Image = Global.SceneGrabberNET.My.Resources.Resources.zoom
        Me._btn_preview.Location = New System.Drawing.Point(4, 93)
        Me._btn_preview.Name = "_btn_preview"
        Me._btn_preview.Size = New System.Drawing.Size(25, 25)
        Me._btn_preview.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me._btn_preview, "edit/preview sceneshot image")
        Me._btn_preview.UseVisualStyleBackColor = True
        '
        '_btn_delete_all
        '
        Me._btn_delete_all.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._btn_delete_all.Image = Global.SceneGrabberNET.My.Resources.Resources.cancel
        Me._btn_delete_all.Location = New System.Drawing.Point(4, 33)
        Me._btn_delete_all.Name = "_btn_delete_all"
        Me._btn_delete_all.Size = New System.Drawing.Size(25, 25)
        Me._btn_delete_all.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me._btn_delete_all, "delete all scene")
        Me._btn_delete_all.UseVisualStyleBackColor = True
        '
        '_btn_options
        '
        Me._btn_options.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._btn_options.Image = Global.SceneGrabberNET.My.Resources.Resources.table_edit
        Me._btn_options.Location = New System.Drawing.Point(4, 63)
        Me._btn_options.Name = "_btn_options"
        Me._btn_options.Size = New System.Drawing.Size(25, 25)
        Me._btn_options.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me._btn_options, "options")
        Me._btn_options.UseVisualStyleBackColor = True
        '
        '_btn_delete
        '
        Me._btn_delete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._btn_delete.Image = Global.SceneGrabberNET.My.Resources.Resources.delete
        Me._btn_delete.Location = New System.Drawing.Point(4, 3)
        Me._btn_delete.Name = "_btn_delete"
        Me._btn_delete.Size = New System.Drawing.Size(25, 25)
        Me._btn_delete.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me._btn_delete, "delete selected scenes")
        Me._btn_delete.UseVisualStyleBackColor = True
        '
        '_listview
        '
        Me._listview.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._listview.Location = New System.Drawing.Point(3, 1)
        Me._listview.Name = "_listview"
        Me._listview.OnlyViewMode = False
        Me._listview.SceneshotData = Nothing
        Me._listview.Size = New System.Drawing.Size(542, 482)
        Me._listview.TabIndex = 6
        '
        'pbar
        '
        Me.pbar.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbar.Location = New System.Drawing.Point(102, 231)
        Me.pbar.MarqueeAnimationSpeed = 100000
        Me.pbar.Maximum = 10
        Me.pbar.Minimum = 1
        Me.pbar.Name = "pbar"
        Me.pbar.Size = New System.Drawing.Size(378, 23)
        Me.pbar.TabIndex = 7
        Me.pbar.Value = 1
        '
        'ctlScenesBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pbar)
        Me.Controls.Add(Me._listview)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ctlScenesBox"
        Me.Size = New System.Drawing.Size(582, 484)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Private WithEvents _btn_delete As System.Windows.Forms.Button
    Private WithEvents _btn_preview As System.Windows.Forms.Button
    Private WithEvents _btn_delete_all As System.Windows.Forms.Button
    Private WithEvents _btn_save As System.Windows.Forms.Button
    Friend WithEvents _btn_options As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents pbar As System.Windows.Forms.ProgressBar
    Private WithEvents _listview As SceneGrabberNET.ctlScenesListView

End Class
