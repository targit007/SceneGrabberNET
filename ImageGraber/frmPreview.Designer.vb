<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPreview
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPreview))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.picbox = New System.Windows.Forms.PictureBox
        Me.statusbar = New System.Windows.Forms.StatusStrip
        Me.statuslabel = New System.Windows.Forms.ToolStripStatusLabel
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btn_apply = New System.Windows.Forms.Button
        Me.btn_defaults = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.btn_save = New System.Windows.Forms.Button
        Me.btn_close = New System.Windows.Forms.Button
        Me._options = New SceneGrabberNET.CtlOptions3
        Me._listviewP = New SceneGrabberNET.ctlScenesListView
        Me.ctlProfile = New SceneGrabberNET.ctlProfile
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.picbox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.statusbar.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Location = New System.Drawing.Point(1, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(498, 733)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Preview"
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel1.Controls.Add(Me.picbox)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 16)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(492, 714)
        Me.Panel1.TabIndex = 0
        '
        'picbox
        '
        Me.picbox.Location = New System.Drawing.Point(0, 0)
        Me.picbox.Name = "picbox"
        Me.picbox.Size = New System.Drawing.Size(421, 472)
        Me.picbox.TabIndex = 0
        Me.picbox.TabStop = False
        '
        'statusbar
        '
        Me.statusbar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.statuslabel})
        Me.statusbar.Location = New System.Drawing.Point(0, 742)
        Me.statusbar.Name = "statusbar"
        Me.statusbar.Size = New System.Drawing.Size(967, 22)
        Me.statusbar.TabIndex = 3
        Me.statusbar.Text = "StatusStrip1"
        '
        'statuslabel
        '
        Me.statuslabel.Name = "statuslabel"
        Me.statuslabel.Size = New System.Drawing.Size(121, 17)
        Me.statuslabel.Text = "ToolStripStatusLabel1"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.ctlProfile)
        Me.GroupBox2.Controls.Add(Me.btn_apply)
        Me.GroupBox2.Controls.Add(Me.btn_defaults)
        Me.GroupBox2.Location = New System.Drawing.Point(505, 381)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(455, 52)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Profile"
        '
        'btn_apply
        '
        Me.btn_apply.Location = New System.Drawing.Point(365, 19)
        Me.btn_apply.Name = "btn_apply"
        Me.btn_apply.Size = New System.Drawing.Size(75, 23)
        Me.btn_apply.TabIndex = 6
        Me.btn_apply.Text = "Apply"
        Me.btn_apply.UseVisualStyleBackColor = True
        '
        'btn_defaults
        '
        Me.btn_defaults.Location = New System.Drawing.Point(273, 19)
        Me.btn_defaults.Name = "btn_defaults"
        Me.btn_defaults.Size = New System.Drawing.Size(75, 23)
        Me.btn_defaults.TabIndex = 4
        Me.btn_defaults.Text = "Defaults"
        Me.btn_defaults.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me._listviewP)
        Me.GroupBox3.Location = New System.Drawing.Point(505, 434)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(455, 271)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Image"
        '
        'btn_save
        '
        Me.btn_save.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_save.Location = New System.Drawing.Point(520, 713)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(75, 23)
        Me.btn_save.TabIndex = 7
        Me.btn_save.Text = "Save"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'btn_close
        '
        Me.btn_close.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_close.Location = New System.Drawing.Point(870, 713)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(75, 23)
        Me.btn_close.TabIndex = 8
        Me.btn_close.Text = "Close"
        Me.btn_close.UseVisualStyleBackColor = True
        '
        '_options
        '
        Me._options.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._options.Configuration = Nothing
        Me._options.Location = New System.Drawing.Point(500, 3)
        Me._options.Name = "_options"
        Me._options.Size = New System.Drawing.Size(470, 380)
        Me._options.TabIndex = 9
        '
        '_listviewP
        '
        Me._listviewP.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._listviewP.Location = New System.Drawing.Point(10, 16)
        Me._listviewP.Name = "_listviewP"
        Me._listviewP.OnlyViewMode = True
        Me._listviewP.SceneshotData = Nothing
        Me._listviewP.Size = New System.Drawing.Size(437, 245)
        Me._listviewP.TabIndex = 10
        '
        'ctlProfile
        '
        Me.ctlProfile.Configuration = Nothing
        Me.ctlProfile.Location = New System.Drawing.Point(10, 17)
        Me.ctlProfile.Name = "ctlProfile"
        Me.ctlProfile.Size = New System.Drawing.Size(249, 25)
        Me.ctlProfile.TabIndex = 7
        '
        'frmPreview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(967, 764)
        Me.Controls.Add(Me._options)
        Me.Controls.Add(Me.btn_close)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.statusbar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPreview"
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.picbox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.statusbar.ResumeLayout(False)
        Me.statusbar.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents picbox As System.Windows.Forms.PictureBox
    Friend WithEvents statusbar As System.Windows.Forms.StatusStrip
    Friend WithEvents statuslabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_apply As System.Windows.Forms.Button
    Friend WithEvents btn_defaults As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents btn_close As System.Windows.Forms.Button
    Private WithEvents _listviewP As SceneGrabberNET.ctlScenesListView
    Friend WithEvents _options As SceneGrabberNET.CtlOptions3
    Friend WithEvents ctlProfile As SceneGrabberNET.ctlProfile
End Class
