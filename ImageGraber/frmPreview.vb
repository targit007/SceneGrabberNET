Imports System.ComponentModel

Public Class frmPreview

    Private Const STATUS_READY As String = "Ready"
    Private Const STATUS_ERROR As String = "Wrong Parameter. Image cant create !!! "
    Private Const STATUS_CREATE As String = "Create Image ... "
	Private Const FORM_TITLE As String = "Edit/Preview  Sceneshots"

    Private _sceneshotData As SceneshotsHolder
	Private WithEvents _configuration As Configuration
	Private imgOrg As Image

    Public Sub New(ByVal s As SceneshotsHolder, ByVal profile As String)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _sceneshotData = s.Clone

        initialize()

        ctlProfile.selectProfile(profile)

        statuslabel.Text = STATUS_READY

        Me.Text = FORM_TITLE + " - " + s.movieinfo.getFileName

    End Sub

    Private Sub initialize()
        _configuration = Configuration.getInstance.Clone
        _options.setPreviewMode()
        _options.Configuration = _configuration
        ctlProfile.Configuration = _configuration
        _listviewP.OnlyViewMode = True
        _listviewP.SceneshotData = _sceneshotData
        _listviewP.Configuration = _configuration
        _listviewP._updateView()

        btn_apply.Enabled = False

    End Sub

    
    Private Sub reloadConfigurationOnProfileChanged() Handles ctlProfile.Profile_Changed
        'If (btn_apply.Enabled = True) Then
        '    Dim rc As Boolean = Util.saveChangesAfterMsgBox()
        '    If (rc) Then
        '        'unklar
        '    End If
        'End If
        initialize()
    End Sub

    Private Sub updatePreview() Handles _configuration.PropertyChanged, _listviewP.UpdateView
        Me.Cursor = Cursors.WaitCursor
        Me.SuspendLayout()
        Try
            If Me.Visible = True And Not _sceneshotData.scenes Is Nothing And Not _sceneshotData.movieinfo Is Nothing Then
                If _sceneshotData.scenes.Count = 0 Then
                    Me.picbox.Visible = False
                    statuslabel.Text = STATUS_READY
                    Me.btn_save.Enabled = False
                Else
                    Console.WriteLine("redraw")
                    Console.WriteLine(_configuration.columns)
                    Me.btn_save.Enabled = True
                    Me.picbox.Visible = True
                    statuslabel.Text = STATUS_CREATE
                    Application.DoEvents()
                    imgOrg = ImageUtil.generateSceneshotImage(_sceneshotData, _configuration, False)
                    Dim img As Image = imgOrg
                    Me.Panel1.AutoScroll = True
                    Me.Panel1.AutoSize = False
                    Me.picbox.SizeMode = PictureBoxSizeMode.AutoSize
                    Dim width As Integer = Me.Panel1.Width - SystemInformation.VerticalScrollBarWidth
                    Dim height As Integer = (img.Height / img.Width) * width
                    img = ImageUtil.resize(img, width, height, False)
                    Me.picbox.Image = img
                    statuslabel.Text = STATUS_READY + "   Imagesize: " + CStr(imgOrg.Width) + "x" + CStr(imgOrg.Height)
                End If
            Else
                Me.picbox.Visible = False
            End If
        Catch ex As Exception
            statuslabel.Text = STATUS_ERROR
        End Try
        Me.Cursor = Cursors.Default
        Me.ResumeLayout()
    End Sub

    Private Sub frmPreview_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        If Me.Visible = True Then
            updatePreview()
        End If
    End Sub

    Private Sub btn_defaults_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_defaults.Click
        Me.Cursor = Cursors.WaitCursor
        Me.SuspendLayout()
        _configuration.reset()
        ctlProfile.Configuration = _configuration
        Me._options.initBindings()
        Me.Cursor = Cursors.Default
        Me.ResumeLayout()
    End Sub

    Private Sub disableApplyButton() Handles ctlProfile.Profile_Saved
        btn_apply.Enabled = False
    End Sub

    Private Sub msgFrmMainCtlProfile() Handles ctlProfile.Profile_Deleted, ctlProfile.Profile_Saved
        frmMain.profile.Configuration = _configuration
        frmMain.profile.initialize()
    End Sub


    Private Sub enableApplyButton() Handles _configuration.PropertyChanged
        btn_apply.Enabled = True
    End Sub

    Private Sub btn_apply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_apply.Click
        Me.Cursor = Cursors.WaitCursor
        _configuration.save()
        Configuration.setInstance(_configuration)
        initialize()
        Me.Cursor = Cursors.Default
        btn_apply.Enabled = False
    End Sub

    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        Me.Cursor = Cursors.WaitCursor
        _sceneshotData.sceneshot = ImageUtil.generateSceneshotImage(_sceneshotData, _configuration, True)
        Me.Cursor = Cursors.Default
        ImageUtil.saveImage(_sceneshotData)
    End Sub

    Private Sub btn_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_close.Click, Me.FormClosed
        Me.Cursor = Cursors.WaitCursor
        Me.SuspendLayout()
        Me.Visible = False
        '  _configuration.reload()
        Me.Close()
        Me.ResumeLayout()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub frmPreview_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        updatePreview()
    End Sub

    Private Sub picbox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picbox.Click
        If (Not picbox.Image Is Nothing) Then
            Dim s As Sceneshot = New Sceneshot(imgOrg, 0)
            frmShowScene.Sceneshot = s
            frmShowScene.ShowDialog()
        End If
    End Sub
End Class