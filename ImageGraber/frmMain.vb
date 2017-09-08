Public Class frmMain

    Public SceneshotsHolder As SceneshotsHolder

    Private WithEvents cboProfile As ComboBox = New ComboBox
    Private WithEvents btnProfileSave As Button = New Button
    Private WithEvents btnProfileDelete As Button = New Button
    Public WithEvents profile As ctlProfile = New ctlProfile

	Public Sub updateStatusBar(ByVal e As String) Handles _mediaplayer.NotificationMsg, _scenebox.NotificationMsg
		_toolstrip_statuslabel.Text = e
		Application.DoEvents()
	End Sub

	Private Sub OpenFileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _mnu_openFile.Click
		Me.SuspendLayout()
		Dim files() As String = showOpenFilesDialog(False)
		If Not files Is Nothing Then
			_mediaplayer.openFile(files(0))
			_mediaplayer.Refresh()
			Me.Text = Util.APP_TITLE + " - " + _mediaplayer.getOpenedMovieTitle
		Else
			Me.Text = Util.APP_TITLE
			_mediaplayer.Refresh()
		End If
		Me.ResumeLayout()
	End Sub


    Private Function showOpenFilesDialog(ByVal multfiles As Boolean) As String()
        Dim dlg As New OpenFileDialog
        dlg.CheckFileExists = True
        If (multfiles) Then
            dlg.Title = "Open Files"
        Else
            dlg.Title = "Open File"
        End If
		dlg.Filter = "All Movies|*.avi;*.mpg;*.mpeg;*.asf;*.wmv;*.mov;*.mp4|All Files|*.*"
        dlg.Multiselect = multfiles

        Try
            If (My.Settings.use_lastsavedpath AndAlso Not String.IsNullOrEmpty(My.Settings.lastsavedpath) AndAlso IO.Directory.Exists(My.Settings.lastsavedpath)) Then
                dlg.InitialDirectory = My.Settings.lastsavedpath
            End If
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        If dlg.ShowDialog() = DialogResult.OK Then
            Try
                My.Settings.lastsavedpath = IO.Path.GetDirectoryName(dlg.FileNames(0))
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
            Return dlg.FileNames
        Else
            Return Nothing
        End If
    End Function


    Private Sub dispatchTickProgressBar() Handles _mediaplayer.tickProgressBar
        _scenebox.tickProgressBar()
    End Sub

    Private Sub dispatchSetMaxProgressBarValue(ByVal i As Integer) Handles _mediaplayer.setPrgressBarMaxValue
        _scenebox.setMaxProgressBarValue(i)
    End Sub


    Private Sub dispatchShowProgressBar() Handles _mediaplayer.showProgressBar
        _scenebox.showProgressBar()
    End Sub

    Private Sub dispatchCloseProgressBar() Handles _mediaplayer.closeProgressBar
        _scenebox.closeProgressBar()
    End Sub

    Public Sub New()
        Me.SceneshotsHolder = New SceneshotsHolder

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
		Me.Text = Util.APP_TITLE

        If My.Settings.updatecheck Then
            CheckForUpdatesToolStripMenuItem.Checked = True
        Else
            CheckForUpdatesToolStripMenuItem.Checked = False
        End If

        If My.Settings.use_lastsavedpath Then
            RemindPathToolStripMenuItem.Checked = True
        Else
            RemindPathToolStripMenuItem.Checked = False
        End If

        If My.Settings.gen_filenames Then
            GenerateFilenamesToolStripMenuItem.Checked = True
        Else
            GenerateFilenamesToolStripMenuItem.Checked = False
        End If

        If My.Settings.autoplay Then
            AutoplayMovieToolStripMenuItem.Checked = True
        Else
            AutoplayMovieToolStripMenuItem.Checked = False
        End If

		If My.Settings.ffmpeg_use Then
			If Not Util.isFFMpegValid Then
				selectFFmpegPath()
			Else
				UseFFMpegToolStripMenuItem.Checked = True
			End If
		Else
			UseFFMpegToolStripMenuItem.Checked = False
		End If

        If My.Settings.mplayer_use Then
            If Not Util.isMPlayerValid Then
                selectMPlayerPath()
            Else
                UseMPlayerToolStripMenuItem.Checked = True
            End If
        Else
            UseMPlayerToolStripMenuItem.Checked = False
        End If

        If My.Settings.internal_use Then
            UseInternalToolStripMenuItem.Checked = True
        Else
            UseInternalToolStripMenuItem.Checked = False
        End If


        _scenebox.sceneshotData = SceneshotsHolder
        '_scenebox.sceneshotData.Configuration = Configuration.getInstance
        _scenebox.initialize()


        'initialize statusstrip controls
        profile.Width = 220
        profile.Configuration = Configuration.getInstance

        _statusstrip.Items.Insert(2, New ToolStripControlHost(profile))
        _statusstrip.Renderer = New OwnToolStripSystemRenderer

        _mediaplayer.Configuration = Configuration.getInstance

    End Sub

    Private Class OwnToolStripSystemRenderer
        Inherits ToolStripSystemRenderer

        Protected Overrides Sub OnRenderToolStripBorder(ByVal e As System.Windows.Forms.ToolStripRenderEventArgs)
            'Do nothing
        End Sub

    End Class

	Private Sub mnuExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExit.Click
		Me.Close()
	End Sub


	Private Sub mnuOptions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuOptions.Click
		Me._scenebox._btn_options_Click(Me._scenebox._btn_options, New EventArgs())
	End Sub

	Private Sub AboutScenegrabberNETToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutScenegrabberNETToolStripMenuItem.Click
		frmAbout.ShowDialog()
	End Sub

	Private Sub _mnu_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _mnu_close.Click
		Me.Text = Util.APP_TITLE
		_mediaplayer.reset()
		_mediaplayer.Refresh()
	End Sub


	Private Sub _menustrip_paint(ByVal sender As Object, ByVal e As System.EventArgs) Handles _menustrip.Paint
		If (_mediaplayer.isMediaLoaded) Then
			_mnu_close.Enabled = True
			_mnu_closeclear.Enabled = True
		Else
			_mnu_close.Enabled = False
			_mnu_closeclear.Enabled = False
		End If
        '
        BatchFilesUsingProfileToolStripMenuItem.DropDownItems.Clear()
        For Each profile As String In ProfileManager.getInstance.getProfiles
            BatchFilesUsingProfileToolStripMenuItem.DropDownItems.Add(profile, Nothing, AddressOf menuBatchProfile)
        Next

    End Sub

    Private Sub BatchFilesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BatchFilesToolStripMenuItem.Click
        batchFiles(Configuration.getInstance)
    End Sub

    Public Sub menuBatchProfile(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim profileName As String = DirectCast(sender, ToolStripMenuItem).Text
        Dim conf As Configuration = ProfileManager.getInstance.loadProfile(profileName)
        batchFiles(conf)
    End Sub


    Private Sub CloseReToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _mnu_closeclear.Click
        Me.Text = Util.APP_TITLE
        _mediaplayer.reset()
        _mediaplayer.Refresh()
        _scenebox.reset()
    End Sub

    Private Sub frmMain_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Me.DragDrop
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            Dim files() As String
            files = e.Data.GetData(DataFormats.FileDrop)
            _mediaplayer.reset()
            _scenebox.reset()
            _mediaplayer.openFile(files(0))
        End If
    End Sub

    Private Sub frmMain_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Me.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.All
        End If
    End Sub

    Private Sub CheckForUpdatesToolStripMenuItem_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckForUpdatesToolStripMenuItem.CheckedChanged
        My.Settings.updatecheck = CheckForUpdatesToolStripMenuItem.Checked
    End Sub


    Private Sub RemindPathToolStripMenuItem_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RemindPathToolStripMenuItem.CheckedChanged
        My.Settings.use_lastsavedpath = RemindPathToolStripMenuItem.Checked
    End Sub


    Private Sub GenerateFilenamesToolStripMenuItem_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GenerateFilenamesToolStripMenuItem.CheckedChanged
        My.Settings.gen_filenames = GenerateFilenamesToolStripMenuItem.Checked
    End Sub

    Private Sub AutoplayMovieToolStripMenuItem_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles AutoplayMovieToolStripMenuItem.CheckedChanged
        My.Settings.autoplay = AutoplayMovieToolStripMenuItem.Checked
    End Sub


    Private Sub batchFiles(ByVal conf As Configuration)
        'Dateien auswählen
        _mediaplayer.reset()
        _scenebox.reset()
        Dim files() As String = showOpenFilesDialog(True)
        If Not files Is Nothing Then
            Me.Cursor = Cursors.WaitCursor
            Application.DoEvents()
            dispatchShowProgressBar()
            Application.DoEvents()
            dispatchSetMaxProgressBarValue(files.Length)
            dispatchTickProgressBar()
            Dim i As Integer = 0
            For Each file In files
                Application.DoEvents()
                i += 1
                Me.Cursor = Cursors.WaitCursor
                Dim mv As MovieInfo = New MovieInfo(file)
                Dim sbTitle As String = "File " + CStr(i) + " / " + CStr(files.Length) + " - " + mv.getFileName
                updateStatusBar(sbTitle)
                Application.DoEvents()
                Me.Cursor = Cursors.WaitCursor
                'generate
                Dim dataholder As SceneshotsHolder = ImageUtil.generateSceneShotFromFile(file, conf, _toolstrip_statuslabel)
                Me.Cursor = Cursors.WaitCursor
                Application.DoEvents()
                dispatchTickProgressBar()
                Application.DoEvents()
                'save
                Me.Cursor = Cursors.WaitCursor
                ImageUtil.saveImage(dataholder, True)
                Application.DoEvents()
            Next
            updateStatusBar("File " + CStr(files.Length) + "/" + CStr(files.Length) + " - all done")
            dispatchCloseProgressBar()
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub selectFFmpegPath()
        'Show Dialog
        Dim ffmpegExe As String = "ffmpeg.exe"
        Dim selectedFilename As String = Util.openFileDialog("Select ffmpeg executable", "ffmpeg.exe|ffmpeg.exe", ffmpegExe, True)
        If Not String.IsNullOrEmpty(selectedFilename) Then
            'Check if correct selected
            If (selectedFilename.ToLower.EndsWith(ffmpegExe)) Then
                My.Settings.ffmpeg_path = selectedFilename
                My.Settings.ffmpeg_use = UseFFMpegToolStripMenuItem.Checked
            Else
                MsgBox("You select not a valid ffmpeg executable !", MsgBoxStyle.Critical, Util.APP_TITLE)
                UseFFMpegToolStripMenuItem.Checked = False
            End If
        End If
    End Sub

    Private Sub selectMPlayerPath()
        'Show Dialog
        Dim MPlayerExe As String = "mplayer.exe"
        Dim selectedFilename As String = Util.openFileDialog("Select mplayer executable", "mplayer.exe|mplayer.exe", MPlayerExe, True)
        If Not String.IsNullOrEmpty(selectedFilename) Then
            'Check if correct selected
            If (selectedFilename.ToLower.EndsWith(MPlayerExe)) Then
                My.Settings.mplayer_path = selectedFilename
                My.Settings.mplayer_use = UseMPlayerToolStripMenuItem.Checked
            Else
                MsgBox("You select not a valid mplayer executable !", MsgBoxStyle.Critical, Util.APP_TITLE)
                UseMPlayerToolStripMenuItem.Checked = False
            End If
        End If
    End Sub

    Private Sub UseFFMpegToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UseFFMpegToolStripMenuItem.Click
        If UseFFMpegToolStripMenuItem.Checked AndAlso Not Util.isFFMpegValid Then
            selectFFmpegPath()
        Else
            My.Settings.ffmpeg_use = UseFFMpegToolStripMenuItem.Checked
        End If
    End Sub

    Private Sub UseMPlayerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UseMPlayerToolStripMenuItem.Click
        If UseMPlayerToolStripMenuItem.Checked AndAlso Not Util.isMPlayerValid Then
            selectMPlayerPath()
        Else
            My.Settings.mplayer_use = UseMPlayerToolStripMenuItem.Checked
        End If

    End Sub

    Private Sub mnu_Donate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_Donate.Click
        Cursor = Cursors.WaitCursor
        System.Diagnostics.Process.Start(Util.URL_DONATE)
        Cursor = Cursors.Default
    End Sub

    Private Sub UseInternalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UseInternalToolStripMenuItem.Click
        My.Settings.internal_use = UseInternalToolStripMenuItem.Checked
    End Sub

    Public Sub refreshCtlProfile() Handles profile.Profile_Changed, profile.Profile_Saved
        _mediaplayer.Configuration = Configuration.getInstance
    End Sub

End Class
