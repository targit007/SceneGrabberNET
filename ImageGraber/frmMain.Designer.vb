<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me._statusstrip = New System.Windows.Forms.StatusStrip
        Me._toolstrip_statuslabel = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me._mediaplayer = New SceneGrabberNET.ctlMediaplayer
        Me._scenebox = New SceneGrabberNET.ctlScenesBox
        Me._menustrip = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me._mnu_openFile = New System.Windows.Forms.ToolStripMenuItem
        Me.BatchFilesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BatchFilesUsingProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me._mnu_close = New System.Windows.Forms.ToolStripMenuItem
        Me._mnu_closeclear = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.mnuOptions = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem
        Me.UpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CheckForUpdatesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RemindPathToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GenerateFilenamesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AutoplayMovieToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AddOnsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.UseInternalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.UseFFMpegToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.UseMPlayerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutScenegrabberNETToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.mnu_Donate = New System.Windows.Forms.ToolStripMenuItem
        Me._statusstrip.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me._menustrip.SuspendLayout()
        Me.SuspendLayout()
        '
        '_statusstrip
        '
        Me._statusstrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me._toolstrip_statuslabel, Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2})
        Me._statusstrip.Location = New System.Drawing.Point(0, 584)
        Me._statusstrip.Name = "_statusstrip"
        Me._statusstrip.Size = New System.Drawing.Size(613, 22)
        Me._statusstrip.TabIndex = 6
        Me._statusstrip.Text = "_statusstrip"
        '
        '_toolstrip_statuslabel
        '
        Me._toolstrip_statuslabel.Name = "_toolstrip_statuslabel"
        Me._toolstrip_statuslabel.Size = New System.Drawing.Size(39, 17)
        Me._toolstrip_statuslabel.Text = "Ready"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(557, 17)
        Me.ToolStripStatusLabel1.Spring = True
        Me.ToolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.AutoSize = False
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(2, 17)
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 24)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me._mediaplayer)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me._scenebox)
        Me.SplitContainer1.Size = New System.Drawing.Size(613, 560)
        Me.SplitContainer1.SplitterDistance = 351
        Me.SplitContainer1.SplitterWidth = 1
        Me.SplitContainer1.TabIndex = 7
        '
        '_mediaplayer
        '
        Me._mediaplayer.BackColor = System.Drawing.SystemColors.Control
        Me._mediaplayer.Configuration = Nothing
        Me._mediaplayer.Dock = System.Windows.Forms.DockStyle.Fill
        Me._mediaplayer.Location = New System.Drawing.Point(0, 0)
        Me._mediaplayer.Name = "_mediaplayer"
        Me._mediaplayer.Size = New System.Drawing.Size(613, 351)
        Me._mediaplayer.TabIndex = 0
        '
        '_scenebox
        '
        Me._scenebox.Dock = System.Windows.Forms.DockStyle.Fill
        Me._scenebox.Location = New System.Drawing.Point(0, 0)
        Me._scenebox.Name = "_scenebox"
        Me._scenebox.sceneshotData = Nothing
        Me._scenebox.Size = New System.Drawing.Size(613, 208)
        Me._scenebox.TabIndex = 0
        '
        '_menustrip
        '
        Me._menustrip.BackColor = System.Drawing.SystemColors.Control
        Me._menustrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.UpdateToolStripMenuItem, Me.AddOnsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me._menustrip.Location = New System.Drawing.Point(0, 0)
        Me._menustrip.Name = "_menustrip"
        Me._menustrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me._menustrip.Size = New System.Drawing.Size(613, 24)
        Me._menustrip.TabIndex = 8
        Me._menustrip.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me._mnu_openFile, Me.BatchFilesToolStripMenuItem, Me.BatchFilesUsingProfileToolStripMenuItem, Me.ToolStripSeparator3, Me._mnu_close, Me._mnu_closeclear, Me.ToolStripSeparator1, Me.mnuOptions, Me.ToolStripSeparator2, Me.mnuExit})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        '_mnu_openFile
        '
        Me._mnu_openFile.Name = "_mnu_openFile"
        Me._mnu_openFile.Size = New System.Drawing.Size(208, 22)
        Me._mnu_openFile.Text = "Open File"
        '
        'BatchFilesToolStripMenuItem
        '
        Me.BatchFilesToolStripMenuItem.Name = "BatchFilesToolStripMenuItem"
        Me.BatchFilesToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.BatchFilesToolStripMenuItem.Text = "Batch Files"
        '
        'BatchFilesUsingProfileToolStripMenuItem
        '
        Me.BatchFilesUsingProfileToolStripMenuItem.Name = "BatchFilesUsingProfileToolStripMenuItem"
        Me.BatchFilesUsingProfileToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.BatchFilesUsingProfileToolStripMenuItem.Text = "Batch Files using Profile"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(205, 6)
        '
        '_mnu_close
        '
        Me._mnu_close.Name = "_mnu_close"
        Me._mnu_close.Size = New System.Drawing.Size(208, 22)
        Me._mnu_close.Text = "Close"
        '
        '_mnu_closeclear
        '
        Me._mnu_closeclear.Name = "_mnu_closeclear"
        Me._mnu_closeclear.Size = New System.Drawing.Size(208, 22)
        Me._mnu_closeclear.Text = "Close && Clear Sceneshots"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(205, 6)
        '
        'mnuOptions
        '
        Me.mnuOptions.Name = "mnuOptions"
        Me.mnuOptions.Size = New System.Drawing.Size(208, 22)
        Me.mnuOptions.Text = "Options"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(205, 6)
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(208, 22)
        Me.mnuExit.Text = "Exit"
        '
        'UpdateToolStripMenuItem
        '
        Me.UpdateToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CheckForUpdatesToolStripMenuItem, Me.RemindPathToolStripMenuItem, Me.GenerateFilenamesToolStripMenuItem, Me.AutoplayMovieToolStripMenuItem})
        Me.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem"
        Me.UpdateToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.UpdateToolStripMenuItem.Text = "Settings"
        '
        'CheckForUpdatesToolStripMenuItem
        '
        Me.CheckForUpdatesToolStripMenuItem.CheckOnClick = True
        Me.CheckForUpdatesToolStripMenuItem.Name = "CheckForUpdatesToolStripMenuItem"
        Me.CheckForUpdatesToolStripMenuItem.Size = New System.Drawing.Size(226, 22)
        Me.CheckForUpdatesToolStripMenuItem.Text = "Check for updates"
        '
        'RemindPathToolStripMenuItem
        '
        Me.RemindPathToolStripMenuItem.CheckOnClick = True
        Me.RemindPathToolStripMenuItem.Name = "RemindPathToolStripMenuItem"
        Me.RemindPathToolStripMenuItem.Size = New System.Drawing.Size(226, 22)
        Me.RemindPathToolStripMenuItem.Text = "Remind last saved path "
        '
        'GenerateFilenamesToolStripMenuItem
        '
        Me.GenerateFilenamesToolStripMenuItem.CheckOnClick = True
        Me.GenerateFilenamesToolStripMenuItem.Name = "GenerateFilenamesToolStripMenuItem"
        Me.GenerateFilenamesToolStripMenuItem.Size = New System.Drawing.Size(226, 22)
        Me.GenerateFilenamesToolStripMenuItem.Text = "Generate sceneshot filename"
        '
        'AutoplayMovieToolStripMenuItem
        '
        Me.AutoplayMovieToolStripMenuItem.CheckOnClick = True
        Me.AutoplayMovieToolStripMenuItem.Name = "AutoplayMovieToolStripMenuItem"
        Me.AutoplayMovieToolStripMenuItem.Size = New System.Drawing.Size(226, 22)
        Me.AutoplayMovieToolStripMenuItem.Text = "Autoplay movie"
        '
        'AddOnsToolStripMenuItem
        '
        Me.AddOnsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UseInternalToolStripMenuItem, Me.UseFFMpegToolStripMenuItem, Me.UseMPlayerToolStripMenuItem})
        Me.AddOnsToolStripMenuItem.Name = "AddOnsToolStripMenuItem"
        Me.AddOnsToolStripMenuItem.Size = New System.Drawing.Size(100, 20)
        Me.AddOnsToolStripMenuItem.Text = "Capture Engine"
        '
        'UseInternalToolStripMenuItem
        '
        Me.UseInternalToolStripMenuItem.CheckOnClick = True
        Me.UseInternalToolStripMenuItem.Name = "UseInternalToolStripMenuItem"
        Me.UseInternalToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.UseInternalToolStripMenuItem.Text = "Internal"
        '
        'UseFFMpegToolStripMenuItem
        '
        Me.UseFFMpegToolStripMenuItem.CheckOnClick = True
        Me.UseFFMpegToolStripMenuItem.Name = "UseFFMpegToolStripMenuItem"
        Me.UseFFMpegToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.UseFFMpegToolStripMenuItem.Text = "FFmpeg"
        '
        'UseMPlayerToolStripMenuItem
        '
        Me.UseMPlayerToolStripMenuItem.CheckOnClick = True
        Me.UseMPlayerToolStripMenuItem.Name = "UseMPlayerToolStripMenuItem"
        Me.UseMPlayerToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.UseMPlayerToolStripMenuItem.Text = "MPlayer"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutScenegrabberNETToolStripMenuItem, Me.mnu_Donate})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutScenegrabberNETToolStripMenuItem
        '
        Me.AboutScenegrabberNETToolStripMenuItem.Name = "AboutScenegrabberNETToolStripMenuItem"
        Me.AboutScenegrabberNETToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.AboutScenegrabberNETToolStripMenuItem.Text = "About Scenegrabber.NET"
        '
        'mnu_Donate
        '
        Me.mnu_Donate.Name = "mnu_Donate"
        Me.mnu_Donate.Size = New System.Drawing.Size(207, 22)
        Me.mnu_Donate.Text = "Donate and help !"
        '
        'frmMain
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(613, 606)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me._statusstrip)
        Me.Controls.Add(Me._menustrip)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me._menustrip
        Me.Name = "frmMain"
        Me.Text = "Form1"
        Me._statusstrip.ResumeLayout(False)
        Me._statusstrip.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me._menustrip.ResumeLayout(False)
        Me._menustrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents _statusstrip As System.Windows.Forms.StatusStrip
    Private WithEvents _mediaplayer As SceneGrabberNET.ctlMediaplayer
    Private WithEvents _toolstrip_statuslabel As System.Windows.Forms.ToolStripStatusLabel
    Private WithEvents _menustrip As System.Windows.Forms.MenuStrip
    Friend WithEvents _mnu_openFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents _scenebox As SceneGrabberNET.ctlScenesBox
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuOptions As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents UpdateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CheckForUpdatesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutScenegrabberNETToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents _mnu_close As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents _mnu_closeclear As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemindPathToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GenerateFilenamesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BatchFilesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AutoplayMovieToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddOnsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UseFFMpegToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_Donate As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UseMPlayerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UseInternalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents BatchFilesUsingProfileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
