Public Class ctlProfile

    Public Event Profile_Changed(ByVal name As String)
    Public Event Profile_Saved()
    Public Event Profile_Deleted()

    Private WithEvents _configuration As Configuration

    Public Property Configuration() As Configuration
        Get
            Return _configuration
        End Get
        Set(ByVal value As Configuration)
            _configuration = value
        End Set
    End Property

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        initialize()
    End Sub


    Public Sub initialize()
        updateCboProfile()

        If (cboProfile.Items.Count > 0) Then
            cboProfile.SelectedIndex = 0
        End If
    End Sub



    Private Sub updateCboProfile()

        btnSave.Enabled = False

        cboProfile.Items.Clear()
        Dim items() As String = ProfileManager.getInstance.getProfiles
        If Not items Is Nothing Then
            cboProfile.Items.AddRange(items)
        End If
        cboProfile.Refresh()
        initializeButtons()

    End Sub


    Private Sub initializeButtons()
        If Not String.Equals(cboProfile.Text, ProfileManager.defaultProfile, StringComparison.CurrentCultureIgnoreCase) Then
            btnDelete.Enabled = True
        Else
            btnDelete.Enabled = False
        End If
        btnSave.Enabled = False
    End Sub





    Private Sub cbo_selectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboProfile.SelectedIndexChanged
        Application.DoEvents()
        _configuration = ProfileManager.getInstance.loadProfile(cboProfile.Text)
        Configuration.setInstance(_configuration)
        initializeButtons()
        Application.DoEvents()
        RaiseEvent Profile_Changed(cboProfile.Text)
    End Sub


    Private Sub cboProfile_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboProfile.SelectionChangeCommitted
        Application.DoEvents()
        If (btnSave.Enabled = True) Then
            Dim rc As MsgBoxResult = MsgBox("Save configuration changes?", MsgBoxStyle.YesNo, Util.APP_TITLE)
            If (rc = MsgBoxResult.Yes) Then
                ProfileManager.getInstance.saveProfile(cboProfile.Text, _configuration)
            End If
        End If


    End Sub

    Private Sub ComboBox1(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboProfile.TextChanged
        Dim findString As String = String.Empty
        findString = cboProfile.Text
        If Not String.Equals(findString, ProfileManager.defaultProfile, StringComparison.CurrentCultureIgnoreCase) Then
            With cboProfile
                .SelectedIndex = cboProfile.FindString(findString)
            End With
            If cboProfile.SelectedIndex = -1 Then
                enableButtonSave(sender, e)
            End If
        End If
    End Sub

    Private Sub enableButtonSave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _configuration.PropertyChanged
        enableButtonSave()
    End Sub

    Private Sub enableButtonSave() Handles _configuration.Configuration_reset
        btnSave.Enabled = True
    End Sub


    Private Sub disableButtonSave() Handles _configuration.Configuration_reload
        btnSave.Enabled = False
    End Sub

    Private Sub saveConfiguration()
        ProfileManager.getInstance.saveProfile(cboProfile.Text, _configuration)
        updateCboProfile()
        RaiseEvent Profile_Saved()
    End Sub

    Private Sub configSave() Handles _configuration.Configuration_save
        saveConfiguration()
    End Sub

    Public Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        saveConfiguration()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click

        Dim result As MsgBoxResult = MsgBox("You are sure to delete profile " + cboProfile.Text + " ?", MsgBoxStyle.YesNoCancel, Util.APP_TITLE)
        If result = MsgBoxResult.Yes Then
            ProfileManager.getInstance.deleteProfile(cboProfile.Text) '
            cboProfile.Items.Remove(cboProfile.Text)
            cboProfile.SelectedIndex = cboProfile.FindString("default")
            RaiseEvent Profile_Deleted()
        End If
    End Sub

    Public Sub selectProfile(ByVal name As String)
        With cboProfile
            .SelectedIndex = cboProfile.FindString(name)
        End With
    End Sub
End Class
