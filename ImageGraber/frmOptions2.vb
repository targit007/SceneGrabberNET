Public Class frmOptions2
    Private WithEvents _configuration As Configuration

    Public Property Configuration() As Configuration
        Get
            Return _configuration
        End Get
        Set(ByVal value As Configuration)
            _configuration = value
            _options.Configuration = _configuration.Clone
        End Set
    End Property

    Private Sub enableApplyButton() Handles _options.Configuration_Property_Changed
        btn_apply.Enabled = True
    End Sub


    Private Sub btn_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub

    Private Sub btn_apply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_apply.Click
        _configuration = _options.Configuration
        ProfileManager.getInstance.saveProfile(frmMain.profile.cboProfile.Text, _configuration)
        Configuration.setInstance(_configuration)
        frmMain.refreshCtlProfile()
        Me.Close()
    End Sub

    Private Sub btn_defaults_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_defaults.Click
        _options.Configuration.reset()
        _options.initBindings()
    End Sub

    Public Sub New()
        Me.SuspendLayout()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.ResumeLayout()

        btn_defaults.Enabled = True
        btn_cancel.Enabled = True
        btn_apply.Enabled = False

    End Sub



End Class