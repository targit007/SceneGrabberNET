Imports System.ComponentModel

Public Class ctlScenesBox
    Inherits AUserControl

    Public WithEvents sceneshotData As SceneshotsHolder

    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        pbar.Visible = False

        _listview.OnlyViewMode = False

    End Sub


    Private Sub dispatchNotificationListView(ByVal msg As String) Handles _listview.NotificationMsg
        Notification(msg)
    End Sub


    Public Sub initialize()
        _listview.SceneshotData = sceneshotData
        _listview.Configuration = Configuration.getInstance
        _updateButtons()
    End Sub


    Private Sub _updateButtons() Handles sceneshotData.Sceneshot_item_deleted, sceneshotData.SceneshotList_changed, sceneshotData.SceneshotList_reset, sceneshotData.SceneshotList_assigned
        If _sceneshotData.scenes.Count = 0 Then
            _btn_delete.Enabled = False
            _btn_delete_all.Enabled = False
            _btn_options.Enabled = True
            _btn_preview.Enabled = False
            _btn_save.Enabled = False
        Else
            _btn_delete.Enabled = True
            _btn_delete_all.Enabled = True
            _btn_options.Enabled = True
            _btn_preview.Enabled = True
            _btn_save.Enabled = True
        End If
    End Sub

    Public Sub setMaxProgressBarValue(ByVal i As Integer)
        pbar.Maximum = (i) * 10 + 1
        pbar.Minimum = 1
        pbar.Step = 10
        pbar.Value = 1

    End Sub

    Public Sub tickProgressBar()
        If pbar.Value <> pbar.Maximum Then
            pbar.Value = pbar.Value + 10
        End If

    End Sub

    Public Sub showProgressBar()
        pbar.Visible = True
    End Sub

    Public Sub closeProgressBar()
        pbar.Visible = False
    End Sub

    Public Sub reset()
        _listview.[reset]()
    End Sub

    Private Sub _btn_delete_all_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _btn_delete_all.Click
        _listview._cntMenu_deleteAll_Click(_listview._cntMenu_deleteAll, New System.EventArgs)
    End Sub

    Private Sub _btn_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _btn_delete.Click
        _listview._cntMenu_delete_Click(_listview._cntMenu_delete, New System.EventArgs)
    End Sub

    Private Sub _btn_preview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _btn_preview.Click
        _listview._cntMenu_preview_Click(_listview._cntMenu_preview, New System.EventArgs)
    End Sub

    Public Sub _btn_options_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _btn_options.Click
        _listview._cntMenu_options_Click(_listview._cntMenu_options, New System.EventArgs)
    End Sub

    Private Sub _btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _btn_save.Click
        _listview._cntMenu_save_Click(_listview._cntMenu_save, New System.EventArgs)
    End Sub

End Class
