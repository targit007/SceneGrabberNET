Imports System.ComponentModel

Public Class ctlMediaplayer
    Inherits AUserControl

    Private Const REWIND_FORWARD_FACTOR As Integer = 500
    Private Const DEFAULT_TIMELINE As String = "time: 00:00:00/00:00:00" + vbCrLf + "frame: 0/00000"

    Private Event timeline_changed()

    Public Event showProgressBar()
    Public Event closeProgressBar()
    Public Event setPrgressBarMaxValue(ByVal i As Integer)
    Public Event tickProgressBar()

    Private _filepath As String
    Private _autoplay As Boolean

    Private _framesPerSeconds As Double
    Private _SecondsPerFrame As Double
    Private _width As Integer
    Private _height As Integer

    Private _maxFrame As String
    Private _maxTime As String
    Private _duration As Double

	Private WithEvents volumeslider As TrackBar = New TrackBar

    Private WithEvents _dataholder As SceneshotsHolder
    Private WithEvents _configuration As Configuration


    Private WithEvents _toolstripSceneshotMode As ctlEnumLabelOnly



    Public Property Configuration() As Configuration
        Get
            Return _configuration
        End Get
        Set(ByVal value As Configuration)
            _configuration = value
            initBindings()
        End Set
    End Property


    Private Sub test() Handles _toolstripSceneshotMode.PropertyChanged
        _toolstrip_txtFrames.Control.DataBindings.Clear()
        If (_toolstripSceneshotMode.Value = ImageUtil.SceneshotMode.Count) Then
            _toolstrip_txtFrames.Control.DataBindings.Add(New Binding("text", Configuration, "sceneshotcount", False, DataSourceUpdateMode.OnPropertyChanged))
        Else
            _toolstrip_txtFrames.Control.DataBindings.Add(New Binding("text", Configuration, "sceneshotsec", False, DataSourceUpdateMode.OnPropertyChanged))
        End If

    End Sub


    Private Sub initBindings()
        _toolstripSceneshotMode.DataBindings.Clear()
        If (Not Configuration Is Nothing) Then
            _toolstripSceneshotMode.DataBindings.Add(New Binding("Value", Configuration, "sceneshotmode", False, DataSourceUpdateMode.OnPropertyChanged))
            _toolstrip_txtFrames.Control.DataBindings.Clear()
            If (_configuration.sceneshotmode = ImageUtil.SceneshotMode.Count) Then
                _toolstrip_txtFrames.Control.DataBindings.Add(New Binding("text", Configuration, "sceneshotcount", False, DataSourceUpdateMode.OnPropertyChanged))
            Else
                _toolstrip_txtFrames.Control.DataBindings.Add(New Binding("text", Configuration, "sceneshotsec", False, DataSourceUpdateMode.OnPropertyChanged))
            End If
        End If
    End Sub


    Private Sub init()

        _filepath = ""

        _mediaPlayer.settings.autoStart = False
        _mediaPlayer.settings.enableErrorDialogs = False
        _mediaPlayer.enableContextMenu = False
        _mediaPlayer.settings.setMode("showFrame", True)
        _mediaPlayer.fullScreen = False

        _mediaPlayer.Ctlenabled = False
        _mediaPlayer.uiMode = "none"

        _ticker.Enabled = False

        _scrollbar.Value = 0
        _scrollbar.Minimum = 0
        _scrollbar.Maximum = 0

        _toolstrip_labelTimeline.Text = DEFAULT_TIMELINE

        _toolstrip_buttonPlay.Enabled = False
        _toolstrip_buttonPause.Enabled = False
        _toolstrip_buttonStop.Enabled = False

        _toolstrip_buttonFirstFrame.Enabled = False
        _toolstrip_buttonLastFrame.Enabled = False
        _toolstrip_buttonForFrame.Enabled = False
        _toolstrip_buttonBackFrame.Enabled = False
        _toolstrip_buttonFastReverse.Enabled = False
        _toolbar_buttonFastForward.Enabled = False
        _toolstrip_buttonSceneshot.Enabled = False
        _toolstrip_buttonSceneshotList.Enabled = False

		_toolstrip_txtFrames.Enabled = True
        _toolstrip_buttonInfo.Enabled = False

		_toolstrip_mute.Enabled = False
		volumeslider.Enabled = False

        _autoplay = My.Settings.autoplay

		If My.Settings.mute = True Then
			_toolstrip_mute.Checked = True
		Else
			_toolstrip_mute.Checked = False
		End If

		volumeslider.Value = My.Settings.volume
		_mediaPlayer.settings.volume = volumeslider.Value
	
    End Sub

	Public Function getOpenedMovieTitle() As String
		If Not _dataholder Is Nothing And Not _dataholder.movieinfo Is Nothing Then
			Return _dataholder.movieinfo.getFileName()
		Else
			Return ""
		End If
	End Function

    Private Sub updateButtonsAndTimeline() Handles Me.timeline_changed
        'timeline updaten
        Dim currentFrame As String = CStr(CInt(_mediaPlayer.Ctlcontrols.currentPosition * _framesPerSeconds))
        'Dim maxFrame As String = CStr(CInt(_mediaPlayer.currentPlaylist.Item(0).duration * _framesPerSeconds))
        Dim maxFrame As String = _maxFrame
        Dim currentTime As String = IIf(_mediaPlayer.Ctlcontrols.currentPositionString = "", "00:00:00", Util.getDoubleTimeAsString(_mediaPlayer.Ctlcontrols.currentPosition))
        'Dim maxTime As String = _mediaPlayer.currentPlaylist.Item(0).durationString
        Dim maxTime As String = _maxTime
        _toolstrip_labelTimeline.Text = "time: " + currentTime + "/" + maxTime + vbCrLf + "frame: " + currentFrame + "/" + maxFrame

        'buttons updaten
        If (_mediaPlayer.playState = WMPLib.WMPPlayState.wmppsPlaying) Then
            _toolstrip_buttonPlay.Enabled = True
            _toolstrip_buttonPause.Enabled = True
            _toolstrip_buttonStop.Enabled = True

            _toolstrip_buttonFirstFrame.Enabled = True
            _toolstrip_buttonLastFrame.Enabled = True
            _toolstrip_buttonForFrame.Enabled = True
            _toolstrip_buttonBackFrame.Enabled = True
            _toolstrip_buttonFastReverse.Enabled = True
            _toolbar_buttonFastForward.Enabled = True
            _toolstrip_buttonSceneshot.Enabled = True
            _toolstrip_buttonSceneshotList.Enabled = True
			_toolstrip_txtFrames.Enabled = True
			_toolstrip_buttonInfo.Enabled = True
			_toolstrip_mute.Enabled = True
			volumeslider.Enabled = True


        ElseIf (_mediaPlayer.playState = WMPLib.WMPPlayState.wmppsPaused) Then
            _toolstrip_buttonPlay.Enabled = True
            _toolstrip_buttonPause.Enabled = False
            _toolstrip_buttonStop.Enabled = True

            _toolstrip_buttonFirstFrame.Enabled = True
            _toolstrip_buttonLastFrame.Enabled = True
            _toolstrip_buttonForFrame.Enabled = True
            _toolstrip_buttonBackFrame.Enabled = True
            _toolstrip_buttonFastReverse.Enabled = True
            _toolbar_buttonFastForward.Enabled = True
            _toolstrip_buttonSceneshot.Enabled = True
            _toolstrip_buttonSceneshotList.Enabled = True
            _toolstrip_txtFrames.Enabled = True
            _toolstrip_buttonInfo.Enabled = True
			_toolstrip_mute.Enabled = True
			volumeslider.Enabled = True


        ElseIf (_mediaPlayer.playState = WMPLib.WMPPlayState.wmppsStopped Or _
                _mediaPlayer.currentPlaylist.count > 0) Then
            _toolstrip_buttonPlay.Enabled = True
            _toolstrip_buttonPause.Enabled = False
            _toolstrip_buttonStop.Enabled = False

            _toolstrip_buttonFirstFrame.Enabled = True
            _toolstrip_buttonLastFrame.Enabled = True
            _toolstrip_buttonForFrame.Enabled = True
            _toolstrip_buttonBackFrame.Enabled = True
            _toolstrip_buttonFastReverse.Enabled = True
            _toolbar_buttonFastForward.Enabled = True
            _toolstrip_buttonSceneshot.Enabled = True
            _toolstrip_buttonSceneshotList.Enabled = True
            _toolstrip_txtFrames.Enabled = True
            _toolstrip_buttonInfo.Enabled = True
			_toolstrip_mute.Enabled = True
			volumeslider.Enabled = True

        End If

    End Sub


    Public Sub openFile(ByVal filePath As String)
        Dim oMedia As DexterLib.MediaDet = New DexterLib.MediaDet

        init()

        _dataholder = frmMain.SceneshotsHolder
        _filepath = filePath
        _dataholder.movieinfo = New MovieInfo(_filepath)
        _framesPerSeconds = _dataholder.movieinfo.getFrameRatePerSeconds
        _SecondsPerFrame = 1 / _framesPerSeconds
        _mediaPlayer.URL = filePath
        _height = _dataholder.movieinfo.getHeight
        _width = _dataholder.movieinfo.getWidth

        Try
            oMedia.Filename = _filepath
            _duration = oMedia.StreamLength
            _maxFrame = Int(_duration * _framesPerSeconds)
            _maxTime = Util.getDoubleTimeAsString(_duration)

        Catch ex As Exception
            Application.DoEvents()
            MsgBox("This movie type is currently not supported by scenegrabber.net !", MsgBoxStyle.Information)
        End Try

        updateButtonsAndTimeline()

        If (_autoplay) Then
            play()
        End If

        _ticker.Enabled = True

    End Sub


    Public Sub reset()
        [stop]()
        init()
        Notification("")
    End Sub


    Private Sub play()
		If (_mediaPlayer.URL <> "") Then
			If My.Settings.mute = True Then
				_mediaPlayer.settings.mute = True
			Else
				_mediaPlayer.settings.mute = False
			End If
			_mediaPlayer.Ctlcontrols.play()
		End If

    End Sub

    Private Sub pause()
        If (_mediaPlayer.URL <> "") Then
            _mediaPlayer.Ctlcontrols.pause()
        End If
    End Sub


    Private Sub [stop]()
        If (_mediaPlayer.URL <> "") Then
            _mediaPlayer.Ctlcontrols.stop()
        End If
    End Sub



    Private Sub _scrollbar_Scroll(ByVal sender As Object, ByVal e As System.EventArgs) Handles _scrollbar.Scroll
        My.Application.DoEvents()
        Try
            'refresh wenn gestoppt wurde // das ist mist hier 
            If _mediaPlayer.playState = WMPLib.WMPPlayState.wmppsStopped Or _
                _mediaPlayer.playState = WMPLib.WMPPlayState.wmppsPaused Then
                _mediaPlayer.Ctlcontrols.play()
                While (_mediaPlayer.playState <> WMPLib.WMPPlayState.wmppsPlaying)
                    Application.DoEvents()
                End While
                _mediaPlayer.Ctlcontrols.pause()

            End If
            If Not _autoplay AndAlso _mediaPlayer.playState = WMPLib.WMPPlayState.wmppsReady Then
                _mediaPlayer.Ctlcontrols.play()
                While (_mediaPlayer.playState <> WMPLib.WMPPlayState.wmppsPlaying)
                    Application.DoEvents()
                End While
                _mediaPlayer.Ctlcontrols.pause()

            End If

            _mediaPlayer.Ctlcontrols.currentPosition = _scrollbar.Value
            _mediaPlayer.Ctlcontrols.currentPosition = _mediaPlayer.Ctlcontrols.currentPosition

            RaiseEvent timeline_changed()
        Catch ex As Exception

        End Try
        My.Application.DoEvents()
    End Sub



    Private Sub _ticker_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles _ticker.Tick
        My.Application.DoEvents()
		Try

			'update Scrollbar
			If (_scrollbar.Minimum = 0 And _scrollbar.Maximum = 0) Then
				_scrollbar.Minimum = 0
				'_scrollbar.Maximum = CType(Math.Ceiling(_mediaPlayer.currentPlaylist.Item(0).duration), Integer)
				_scrollbar.Maximum = Int(_duration)
			End If
			'_scrollbar.Value = CType(Math.Ceiling(_mediaPlayer.Ctlcontrols.currentPosition), Integer)
			Dim i As Integer = Int(_mediaPlayer.Ctlcontrols.currentPosition)
			_scrollbar.Value = i
			'update labels
			RaiseEvent timeline_changed()
		Catch ex As Exception
			Console.WriteLine(ex.Message)
		End Try
		My.Application.DoEvents()
    End Sub

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

		'redraw slider (replace)
		volumeslider.Width = 60
		volumeslider.TickStyle = TickStyle.None
		volumeslider.Minimum = 0
		volumeslider.Maximum = 100
		volumeslider.TickFrequency = 1

		_toolstrip.Items.Insert(13, New ToolStripControlHost(volumeslider))
		_toolstrip.Renderer = New OwnToolStripSystemRenderer

		tooltip.SetToolTip(volumeslider, "volume control")

		' Add any initialization after the InitializeComponent() call.
        init()

        _toolstripSceneshotMode = New ctlEnumLabelOnly


        _toolstrip.Items.Insert(18, New ToolStripControlHost(_toolstripSceneshotMode))
        _toolstrip.Items(18).AutoSize = False
        _toolstrip.Items(18).Width = 51

        _toolstrip.Renderer = New OwnToolStripSystemRenderer
        _toolstripSceneshotMode.v_value.Location = New Point(1, 6)


    End Sub

	Private Class OwnToolStripSystemRenderer
		Inherits ToolStripSystemRenderer

		Protected Overrides Sub OnRenderToolStripBorder(ByVal e As System.Windows.Forms.ToolStripRenderEventArgs)
			'Do nothing
		End Sub

	End Class



    Private Sub _toolstrip_buttonPlay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _toolstrip_buttonPlay.Click
        play()
    End Sub

    Private Sub _toolstrip_buttonPause_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _toolstrip_buttonPause.Click
        pause()
    End Sub

    Private Sub _toolstrip_buttonStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _toolstrip_buttonStop.Click
        [stop]()
    End Sub

    Private Sub _toolstrip_buttonFirstFrame_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _toolstrip_buttonFirstFrame.Click
        _mediaPlayer.Ctlcontrols.currentPosition = 0 + _SecondsPerFrame
    End Sub

    Private Sub _toolstrip_buttonLastFrame_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _toolstrip_buttonLastFrame.Click
        _mediaPlayer.Ctlcontrols.currentPosition = _mediaPlayer.currentMedia.duration - _SecondsPerFrame - 1
    End Sub

    Private Sub _toolstrip_buttonFrameBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _toolstrip_buttonBackFrame.Click
        _mediaPlayer.Ctlcontrols.currentPosition -= _SecondsPerFrame
    End Sub

    Private Sub _toolstrip_buttonFrameFor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _toolstrip_buttonForFrame.Click
        _mediaPlayer.Ctlcontrols.currentPosition += _SecondsPerFrame
    End Sub

    Private Sub _toolstrip_buttonFastReverse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _toolstrip_buttonFastReverse.Click
        _mediaPlayer.Ctlcontrols.currentPosition -= (REWIND_FORWARD_FACTOR * _SecondsPerFrame)
    End Sub

    Private Sub _toolbar_buttonFastForward_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _toolbar_buttonFastForward.Click
        _mediaPlayer.Ctlcontrols.currentPosition += (REWIND_FORWARD_FACTOR * _SecondsPerFrame)
    End Sub

    Private Sub _toolstrip_buttonScreenshot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _toolstrip_buttonSceneshot.Click
        Me.Cursor = Cursors.WaitCursor
        Dim oMedia As DexterLib.MediaDet = New DexterLib.MediaDet()
		oMedia.Filename = _filepath
		'_mediaPlayer.Ctlcontrols.pause()
		Dim s As Sceneshot = ImageUtil.createSceneshot(oMedia, _mediaPlayer.Ctlcontrols.currentPosition, _width, _height)
		If Not s Is Nothing Then
			_dataholder.scenes.Add(s)
			Notification("Sceneshot is created")
		End If
		oMedia = Nothing
        Me.Cursor = Cursors.Default
    End Sub



    Private Sub _toolstrip_buttonScreenshotList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _toolstrip_buttonSceneshotList.Click
        Me.Cursor = Cursors.WaitCursor
        Dim oMedia As DexterLib.MediaDet = New DexterLib.MediaDet()
        oMedia.Filename = _filepath

        Dim anzClips As Integer
        Dim positionInc As Double
        Dim position As Double

		Dim sceneList As New BindingList(Of Sceneshot)

        RaiseEvent showProgressBar()
        Application.DoEvents()

        If (_configuration.sceneshotmode = ImageUtil.SceneshotMode.Count) Then
            anzClips = _configuration.sceneshotcount
            positionInc = oMedia.StreamLength / (anzClips + 1)
            RaiseEvent setPrgressBarMaxValue(anzClips)
            Application.DoEvents()

            For i As Integer = 1 To anzClips
                position = i * positionInc
                Dim s As Sceneshot = ImageUtil.createSceneshot(oMedia, position, _width, _height)
                If Not s Is Nothing Then
                    sceneList.Add(s)
                    RaiseEvent tickProgressBar()
                    Application.DoEvents()
                    Notification(String.Format("Sceneshot {0:d}/{1:d} is created", i, anzClips))
                End If
                Application.DoEvents()
            Next
        Else
            anzClips = Util.getScenesCountBySeconds(oMedia.StreamLength, _configuration.sceneshotsec)
            RaiseEvent setPrgressBarMaxValue(anzClips)
            Application.DoEvents()
            Dim i As Integer = 0
            position += _configuration.sceneshotsec
            While (position <= oMedia.StreamLength)
                i += 1
                Dim s As Sceneshot = ImageUtil.createSceneshot(oMedia, position, _width, _height)
                If Not s Is Nothing Then
                    sceneList.Add(s)
                    RaiseEvent tickProgressBar()
                    Application.DoEvents()
                    Notification(String.Format("Sceneshot {0:d}/{1:d} is created", i, anzClips))
                End If
                position += _configuration.sceneshotsec
            End While
        End If
        _dataholder.assignInitalSceneList(sceneList)
        RaiseEvent closeProgressBar()

        Me.Cursor = Cursors.Default
    End Sub


    Private Sub _toolstrip_buttonInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _toolstrip_buttonInfo.Click
        Dim movieInfo As MovieInfo = New MovieInfo(_filepath)
		Dim _frmfrmMovieInfo As frmMovieInfo = New frmMovieInfo(movieInfo, Configuration.getInstance)
        _frmfrmMovieInfo.ShowDialog()
    End Sub


    Public Function isMediaLoaded() As Boolean
        If (String.IsNullOrEmpty(_filepath)) Then
            Return False
        Else
            Return True
        End If
    End Function

	Private Sub _toolstrip_mute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _toolstrip_mute.Click
		'test to do
		If _toolstrip_mute.Checked = True Then
			_mediaPlayer.settings.mute = True
			My.Settings.mute = True
		Else
			_mediaPlayer.settings.mute = False
			My.Settings.mute = False
		End If
	End Sub

	Private Sub volumeslider_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles volumeslider.ValueChanged
		My.Settings.volume = volumeslider.Value
		_mediaPlayer.settings.volume = My.Settings.volume
		If (_toolstrip_mute.Checked = True) Then
			_toolstrip_mute_Click(_toolstrip_mute, New EventArgs())
		End If
	End Sub

End Class
