<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlMediaplayer
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ctlMediaplayer))
		Me._scrollbar = New System.Windows.Forms.TrackBar
		Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
		Me._mediaPlayer = New AxWMPLib.AxWindowsMediaPlayer
		Me._toolstrip = New System.Windows.Forms.ToolStrip
		Me._toolstrip_buttonPlay = New System.Windows.Forms.ToolStripButton
		Me._toolstrip_buttonPause = New System.Windows.Forms.ToolStripButton
		Me._toolstrip_buttonStop = New System.Windows.Forms.ToolStripButton
		Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
		Me._toolstrip_buttonFirstFrame = New System.Windows.Forms.ToolStripButton
		Me._toolstrip_buttonFastReverse = New System.Windows.Forms.ToolStripButton
		Me._toolstrip_buttonBackFrame = New System.Windows.Forms.ToolStripButton
		Me._toolstrip_buttonForFrame = New System.Windows.Forms.ToolStripButton
		Me._toolbar_buttonFastForward = New System.Windows.Forms.ToolStripButton
		Me._toolstrip_buttonLastFrame = New System.Windows.Forms.ToolStripButton
		Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
		Me._toolstrip_labelTimeline = New System.Windows.Forms.ToolStripLabel
		Me._toolstrip_mute = New System.Windows.Forms.ToolStripButton
		Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
		Me._toolstrip_buttonSceneshot = New System.Windows.Forms.ToolStripButton
		Me._toolstrip_buttonSceneshotList = New System.Windows.Forms.ToolStripButton
		Me._toolstrip_txtFrames = New System.Windows.Forms.ToolStripTextBox
		Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
		Me._toolstrip_buttonInfo = New System.Windows.Forms.ToolStripButton
		Me._ticker = New System.Windows.Forms.Timer(Me.components)
		Me.tooltip = New System.Windows.Forms.ToolTip(Me.components)
		CType(Me._scrollbar, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.TableLayoutPanel1.SuspendLayout()
		CType(Me._mediaPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
		Me._toolstrip.SuspendLayout()
		Me.SuspendLayout()
		'
		'_scrollbar
		'
		Me._scrollbar.BackColor = System.Drawing.SystemColors.Control
		Me._scrollbar.Dock = System.Windows.Forms.DockStyle.Fill
		Me._scrollbar.LargeChange = 10
		Me._scrollbar.Location = New System.Drawing.Point(3, 30)
		Me._scrollbar.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
		Me._scrollbar.Maximum = 100
		Me._scrollbar.Name = "_scrollbar"
		Me._scrollbar.Size = New System.Drawing.Size(740, 30)
		Me._scrollbar.TabIndex = 10
		Me._scrollbar.TickStyle = System.Windows.Forms.TickStyle.None
		'
		'TableLayoutPanel1
		'
		Me.TableLayoutPanel1.ColumnCount = 1
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel1.Controls.Add(Me._scrollbar, 0, 1)
		Me.TableLayoutPanel1.Controls.Add(Me._mediaPlayer, 0, 2)
		Me.TableLayoutPanel1.Controls.Add(Me._toolstrip, 0, 0)
		Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
		Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
		Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
		Me.TableLayoutPanel1.RowCount = 3
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
		Me.TableLayoutPanel1.Size = New System.Drawing.Size(746, 461)
		Me.TableLayoutPanel1.TabIndex = 1
		'
		'_mediaPlayer
		'
		Me._mediaPlayer.Dock = System.Windows.Forms.DockStyle.Fill
		Me._mediaPlayer.Enabled = True
		Me._mediaPlayer.Location = New System.Drawing.Point(3, 63)
		Me._mediaPlayer.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
		Me._mediaPlayer.Name = "_mediaPlayer"
		Me._mediaPlayer.OcxState = CType(resources.GetObject("_mediaPlayer.OcxState"), System.Windows.Forms.AxHost.State)
		Me._mediaPlayer.Size = New System.Drawing.Size(740, 398)
		Me._mediaPlayer.TabIndex = 7
		'
		'_toolstrip
		'
		Me._toolstrip.BackColor = System.Drawing.SystemColors.Control
		Me._toolstrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me._toolstrip.Dock = System.Windows.Forms.DockStyle.Fill
		Me._toolstrip.GripMargin = New System.Windows.Forms.Padding(0)
		Me._toolstrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me._toolstrip_buttonPlay, Me._toolstrip_buttonPause, Me._toolstrip_buttonStop, Me.ToolStripSeparator1, Me._toolstrip_buttonFirstFrame, Me._toolstrip_buttonFastReverse, Me._toolstrip_buttonBackFrame, Me._toolstrip_buttonForFrame, Me._toolbar_buttonFastForward, Me._toolstrip_buttonLastFrame, Me.ToolStripSeparator2, Me._toolstrip_labelTimeline, Me._toolstrip_mute, Me.ToolStripSeparator4, Me._toolstrip_buttonSceneshot, Me._toolstrip_buttonSceneshotList, Me._toolstrip_txtFrames, Me.ToolStripSeparator3, Me._toolstrip_buttonInfo})
		Me._toolstrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
		Me._toolstrip.Location = New System.Drawing.Point(0, 0)
		Me._toolstrip.Name = "_toolstrip"
		Me._toolstrip.Padding = New System.Windows.Forms.Padding(0)
		Me._toolstrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
		Me._toolstrip.Size = New System.Drawing.Size(746, 30)
		Me._toolstrip.Stretch = True
		Me._toolstrip.TabIndex = 11
		Me._toolstrip.Text = "ToolStrip1"
		'
		'_toolstrip_buttonPlay
		'
		Me._toolstrip_buttonPlay.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me._toolstrip_buttonPlay.Image = Global.SceneGrabberNET.My.Resources.Resources.play_blue
		Me._toolstrip_buttonPlay.ImageTransparentColor = System.Drawing.Color.Magenta
		Me._toolstrip_buttonPlay.Name = "_toolstrip_buttonPlay"
		Me._toolstrip_buttonPlay.Size = New System.Drawing.Size(23, 27)
		Me._toolstrip_buttonPlay.Text = "ToolStripButton1"
		Me._toolstrip_buttonPlay.ToolTipText = "play movie"
		'
		'_toolstrip_buttonPause
		'
		Me._toolstrip_buttonPause.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me._toolstrip_buttonPause.Image = Global.SceneGrabberNET.My.Resources.Resources.pause_blue
		Me._toolstrip_buttonPause.ImageTransparentColor = System.Drawing.Color.Magenta
		Me._toolstrip_buttonPause.Name = "_toolstrip_buttonPause"
		Me._toolstrip_buttonPause.Size = New System.Drawing.Size(23, 27)
		Me._toolstrip_buttonPause.Text = "ToolStripButton1"
		Me._toolstrip_buttonPause.ToolTipText = "pause movie"
		'
		'_toolstrip_buttonStop
		'
		Me._toolstrip_buttonStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me._toolstrip_buttonStop.Image = Global.SceneGrabberNET.My.Resources.Resources.stop_blue
		Me._toolstrip_buttonStop.ImageTransparentColor = System.Drawing.Color.Magenta
		Me._toolstrip_buttonStop.Name = "_toolstrip_buttonStop"
		Me._toolstrip_buttonStop.Size = New System.Drawing.Size(23, 27)
		Me._toolstrip_buttonStop.Text = "ToolStripButton1"
		Me._toolstrip_buttonStop.ToolTipText = "stop movie"
		'
		'ToolStripSeparator1
		'
		Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
		Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 30)
		'
		'_toolstrip_buttonFirstFrame
		'
		Me._toolstrip_buttonFirstFrame.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me._toolstrip_buttonFirstFrame.Image = Global.SceneGrabberNET.My.Resources.Resources.previous_green
		Me._toolstrip_buttonFirstFrame.ImageTransparentColor = System.Drawing.Color.Magenta
		Me._toolstrip_buttonFirstFrame.Name = "_toolstrip_buttonFirstFrame"
		Me._toolstrip_buttonFirstFrame.Size = New System.Drawing.Size(23, 27)
		Me._toolstrip_buttonFirstFrame.Text = "ToolStripButton1"
		Me._toolstrip_buttonFirstFrame.ToolTipText = "first frame"
		'
		'_toolstrip_buttonFastReverse
		'
		Me._toolstrip_buttonFastReverse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me._toolstrip_buttonFastReverse.Image = Global.SceneGrabberNET.My.Resources.Resources.rewind_green
		Me._toolstrip_buttonFastReverse.ImageTransparentColor = System.Drawing.Color.Magenta
		Me._toolstrip_buttonFastReverse.Name = "_toolstrip_buttonFastReverse"
		Me._toolstrip_buttonFastReverse.Size = New System.Drawing.Size(23, 27)
		Me._toolstrip_buttonFastReverse.Text = "ToolStripButton1"
		Me._toolstrip_buttonFastReverse.ToolTipText = "fast rewind frame"
		'
		'_toolstrip_buttonBackFrame
		'
		Me._toolstrip_buttonBackFrame.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me._toolstrip_buttonBackFrame.Image = Global.SceneGrabberNET.My.Resources.Resources.reverse_green
		Me._toolstrip_buttonBackFrame.ImageTransparentColor = System.Drawing.Color.Magenta
		Me._toolstrip_buttonBackFrame.Name = "_toolstrip_buttonBackFrame"
		Me._toolstrip_buttonBackFrame.Size = New System.Drawing.Size(23, 27)
		Me._toolstrip_buttonBackFrame.Text = "ToolStripButton1"
		Me._toolstrip_buttonBackFrame.ToolTipText = "last frame"
		'
		'_toolstrip_buttonForFrame
		'
		Me._toolstrip_buttonForFrame.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me._toolstrip_buttonForFrame.Image = Global.SceneGrabberNET.My.Resources.Resources.play_green
		Me._toolstrip_buttonForFrame.ImageTransparentColor = System.Drawing.Color.Magenta
		Me._toolstrip_buttonForFrame.Name = "_toolstrip_buttonForFrame"
		Me._toolstrip_buttonForFrame.Size = New System.Drawing.Size(23, 27)
		Me._toolstrip_buttonForFrame.Text = "ToolStripButton1"
		Me._toolstrip_buttonForFrame.ToolTipText = "next frame"
		'
		'_toolbar_buttonFastForward
		'
		Me._toolbar_buttonFastForward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me._toolbar_buttonFastForward.Image = Global.SceneGrabberNET.My.Resources.Resources.forward_green
		Me._toolbar_buttonFastForward.ImageTransparentColor = System.Drawing.Color.Magenta
		Me._toolbar_buttonFastForward.Name = "_toolbar_buttonFastForward"
		Me._toolbar_buttonFastForward.Size = New System.Drawing.Size(23, 27)
		Me._toolbar_buttonFastForward.Text = "ToolStripButton2"
		Me._toolbar_buttonFastForward.ToolTipText = "fast forward frame"
		'
		'_toolstrip_buttonLastFrame
		'
		Me._toolstrip_buttonLastFrame.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me._toolstrip_buttonLastFrame.Image = Global.SceneGrabberNET.My.Resources.Resources.next_green
		Me._toolstrip_buttonLastFrame.ImageTransparentColor = System.Drawing.Color.Magenta
		Me._toolstrip_buttonLastFrame.Name = "_toolstrip_buttonLastFrame"
		Me._toolstrip_buttonLastFrame.Size = New System.Drawing.Size(23, 27)
		Me._toolstrip_buttonLastFrame.Text = "ToolStripButton1"
		Me._toolstrip_buttonLastFrame.ToolTipText = "last frame"
		'
		'ToolStripSeparator2
		'
		Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
		Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 30)
		'
		'_toolstrip_labelTimeline
		'
		Me._toolstrip_labelTimeline.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
		Me._toolstrip_labelTimeline.Name = "_toolstrip_labelTimeline"
		Me._toolstrip_labelTimeline.Size = New System.Drawing.Size(89, 27)
		Me._toolstrip_labelTimeline.Text = "ToolStripLabel1"
		Me._toolstrip_labelTimeline.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'_toolstrip_mute
		'
		Me._toolstrip_mute.CheckOnClick = True
		Me._toolstrip_mute.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me._toolstrip_mute.Image = CType(resources.GetObject("_toolstrip_mute.Image"), System.Drawing.Image)
		Me._toolstrip_mute.ImageTransparentColor = System.Drawing.Color.Magenta
		Me._toolstrip_mute.Name = "_toolstrip_mute"
		Me._toolstrip_mute.Size = New System.Drawing.Size(23, 27)
		Me._toolstrip_mute.Text = "ToolStripButton1"
		Me._toolstrip_mute.ToolTipText = "Sound on/off"
		'
		'ToolStripSeparator4
		'
		Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
		Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 30)
		'
		'_toolstrip_buttonSceneshot
		'
		Me._toolstrip_buttonSceneshot.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me._toolstrip_buttonSceneshot.Image = Global.SceneGrabberNET.My.Resources.Resources.camera_picture
		Me._toolstrip_buttonSceneshot.ImageTransparentColor = System.Drawing.Color.Magenta
		Me._toolstrip_buttonSceneshot.Name = "_toolstrip_buttonSceneshot"
		Me._toolstrip_buttonSceneshot.Size = New System.Drawing.Size(23, 27)
		Me._toolstrip_buttonSceneshot.Text = "ToolStripButton1"
		Me._toolstrip_buttonSceneshot.ToolTipText = "create sceneshot"
		'
		'_toolstrip_buttonSceneshotList
		'
		Me._toolstrip_buttonSceneshotList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me._toolstrip_buttonSceneshotList.Image = Global.SceneGrabberNET.My.Resources.Resources.camera_start
		Me._toolstrip_buttonSceneshotList.ImageTransparentColor = System.Drawing.Color.Magenta
		Me._toolstrip_buttonSceneshotList.Name = "_toolstrip_buttonSceneshotList"
		Me._toolstrip_buttonSceneshotList.Size = New System.Drawing.Size(23, 27)
		Me._toolstrip_buttonSceneshotList.Text = "ToolStripButton2"
		Me._toolstrip_buttonSceneshotList.ToolTipText = "create scenehotS"
		'
		'_toolstrip_txtFrames
		'
		Me._toolstrip_txtFrames.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me._toolstrip_txtFrames.Margin = New System.Windows.Forms.Padding(5, 3, 1, 0)
		Me._toolstrip_txtFrames.Name = "_toolstrip_txtFrames"
		Me._toolstrip_txtFrames.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never
		Me._toolstrip_txtFrames.Size = New System.Drawing.Size(30, 27)
		Me._toolstrip_txtFrames.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me._toolstrip_txtFrames.ToolTipText = "number of screenshots"
		'
		'ToolStripSeparator3
		'
		Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
		Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 30)
		'
		'_toolstrip_buttonInfo
		'
		Me._toolstrip_buttonInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me._toolstrip_buttonInfo.Image = Global.SceneGrabberNET.My.Resources.Resources.book_open_mark
		Me._toolstrip_buttonInfo.ImageTransparentColor = System.Drawing.Color.Magenta
		Me._toolstrip_buttonInfo.Name = "_toolstrip_buttonInfo"
		Me._toolstrip_buttonInfo.Size = New System.Drawing.Size(23, 27)
		Me._toolstrip_buttonInfo.ToolTipText = "show movie info"
		'
		'_ticker
		'
		Me._ticker.Interval = 1000
		'
		'ctlMediaplayer
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.TableLayoutPanel1)
		Me.Name = "ctlMediaplayer"
		Me.Size = New System.Drawing.Size(746, 461)
		CType(Me._scrollbar, System.ComponentModel.ISupportInitialize).EndInit()
		Me.TableLayoutPanel1.ResumeLayout(False)
		Me.TableLayoutPanel1.PerformLayout()
		CType(Me._mediaPlayer, System.ComponentModel.ISupportInitialize).EndInit()
		Me._toolstrip.ResumeLayout(False)
		Me._toolstrip.PerformLayout()
		Me.ResumeLayout(False)

	End Sub
	Private WithEvents _mediaPlayer As AxWMPLib.AxWindowsMediaPlayer
	Private WithEvents _scrollbar As System.Windows.Forms.TrackBar
	Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
	Friend WithEvents _toolstrip As System.Windows.Forms.ToolStrip
	Private WithEvents _ticker As System.Windows.Forms.Timer
	Friend WithEvents _toolstrip_buttonPlay As System.Windows.Forms.ToolStripButton
	Friend WithEvents _toolstrip_buttonPause As System.Windows.Forms.ToolStripButton
	Friend WithEvents _toolstrip_buttonStop As System.Windows.Forms.ToolStripButton
	Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents _toolstrip_buttonFirstFrame As System.Windows.Forms.ToolStripButton
	Friend WithEvents _toolstrip_buttonBackFrame As System.Windows.Forms.ToolStripButton
	Friend WithEvents _toolstrip_buttonForFrame As System.Windows.Forms.ToolStripButton
	Friend WithEvents _toolstrip_buttonLastFrame As System.Windows.Forms.ToolStripButton
	Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents _toolstrip_labelTimeline As System.Windows.Forms.ToolStripLabel
	Friend WithEvents _toolstrip_buttonFastReverse As System.Windows.Forms.ToolStripButton
	Friend WithEvents _toolbar_buttonFastForward As System.Windows.Forms.ToolStripButton
	Friend WithEvents _toolstrip_buttonSceneshot As System.Windows.Forms.ToolStripButton
	Friend WithEvents _toolstrip_buttonSceneshotList As System.Windows.Forms.ToolStripButton
	Friend WithEvents _toolstrip_txtFrames As System.Windows.Forms.ToolStripTextBox
	Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents _toolstrip_buttonInfo As System.Windows.Forms.ToolStripButton
	Friend WithEvents _toolstrip_mute As System.Windows.Forms.ToolStripButton
	Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents tooltip As System.Windows.Forms.ToolTip

End Class
