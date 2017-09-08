Imports System.ComponentModel

Public Class ctlScenesListView
    Inherits AUserControl

    Declare Auto Function SendMessage Lib "user32" (ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer

    Public Event UpdateView()

    Private _onlyViewMode As Boolean
    <Category("Custom Properties"), Description("Nur AnsichtModus")> _
    Public Property OnlyViewMode() As Boolean
        Get
            Return _onlyViewMode
        End Get
        Set(ByVal value As Boolean)
            _onlyViewMode = value
        End Set

    End Property

    Public WithEvents SceneshotData As SceneshotsHolder
    Public WithEvents Configuration As Configuration

    Private _imageList As ImageList = New ImageList

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _lview.ListViewItemSorter = New ListViewItemComparer(_lview)

    End Sub

    Public Sub _updateView() Handles SceneshotData.SceneshotList_assigned
        Me._lview.SuspendLayout()
        _lview.Clear()
        If Not _SceneshotData Is Nothing AndAlso _SceneshotData.scenes.Count > 0 Then
            Dim s As Sceneshot = _SceneshotData.scenes.Item(0)
            initializeImageList(s.icon.Width, s.icon.Height)
            For Each s In _SceneshotData.scenes
                _imageList.Images.Add(s.icon)
                Dim lvItem As New ListViewItem(s.label, _imageList.Images.Count - 1)
                lvItem.Tag = s
                _lview.Items.Add(lvItem)
            Next
        End If
        RaiseEvent UpdateView()
        Me._lview.ResumeLayout()
    End Sub



    Public Sub reset()
        _lview.Items.Clear()
        _imageList.Images.Clear()
        _sceneshotData.scenes = getSceneShotsFromListView()
        _updateView()
    End Sub

    Private Sub addSceneShot() Handles SceneshotData.Sceneshot_item_added
        Me._lview.SuspendLayout()
        Dim s As Sceneshot = _SceneshotData.scenes.Item(_SceneshotData.scenes.Count - 1)
        initializeImageList(s.icon.Width, s.icon.Height)

        _imageList.Images.Add(s.icon)
        Dim lvItem As New ListViewItem(s.label, _imageList.Images.Count - 1)
        lvItem.Tag = s

        ' 1 selektiert        
        If (_lview.SelectedItems.Count = 1) Then
            Dim i As Integer = _lview.SelectedIndices(0)
            frmInsertScene.ShowDialog()
            If frmInsertScene.InsertionType = frmInsertScene.EnumInsertionType.after Then
                _lview.Items.Insert(i + 1, lvItem)
                _lview.SelectedItems.Clear()
            ElseIf frmInsertScene.InsertionType = frmInsertScene.EnumInsertionType.before Then
                _lview.Items.Insert(i, lvItem)
                _lview.SelectedItems.Clear()
            ElseIf frmInsertScene.InsertionType = frmInsertScene.EnumInsertionType.replace Then
                _lview.Items.Item(i) = lvItem
                _lview.SelectedItems.Clear()
            End If
            'n-selektiert
        ElseIf (_lview.SelectedItems.Count > 0) Then
            frmInsertScene.ShowDialog()
            Dim i As Integer = _lview.SelectedIndices(0)
            If frmInsertScene.InsertionType = frmInsertScene.EnumInsertionType.after Then
                i = _lview.SelectedIndices(_lview.SelectedIndices.Count - 1)
                _lview.Items.Insert(i + 1, lvItem)
                _lview.SelectedItems.Clear()
            ElseIf frmInsertScene.InsertionType = frmInsertScene.EnumInsertionType.before Then
                _lview.Items.Insert(i, lvItem)
                _lview.SelectedItems.Clear()
            ElseIf frmInsertScene.InsertionType = frmInsertScene.EnumInsertionType.replace Then
                For Each j In _lview.SelectedItems
                    _lview.Items.Remove(j)
                Next
                _lview.Items.Insert(i, lvItem)
                _lview.SelectedItems.Clear()
            End If
            'keine selektiert
        Else
            _lview.Items.Add(lvItem)
        End If
        _SceneshotData.scenes = getSceneShotsFromListView()
        If OnlyViewMode Then
            _updateView()
        End If
        Me._lview.ResumeLayout()
    End Sub


    Private Sub deleteAllSceneshots() Handles SceneshotData.SceneshotList_reset
        _lview.Items.Clear()
        _imageList.Images.Clear()
        _SceneshotData.scenes = getSceneShotsFromListView()
        If OnlyViewMode Then
            _updateView()
        End If
        Notification("all sceneshots deleted")
    End Sub


    Private Sub deleteSelectedSceneShots()
        If (_lview.SelectedItems.Count = 0) Then
            MsgBox("no image(s) are selected !!!")
        Else
            For Each viewItem In _lview.SelectedItems
                _lview.Items.Remove(viewItem)
            Next
            _sceneshotData.scenes = getSceneShotsFromListView()
            Notification("sceneshot deleted")
            If OnlyViewMode Then
                _updateView()
            End If
        End If
	End Sub

	Private Sub _lview_AfterLabelEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.LabelEditEventArgs) Handles _lview.AfterLabelEdit
		CType(_lview.Items(e.Item).Tag, Sceneshot).label = e.Label
	End Sub


    Private Sub _listview_ItemDrag(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemDragEventArgs) Handles _lview.ItemDrag
        Application.DoEvents()
        Dim glist As gListView = CType(sender, gListView)
        Dim glistitem As ListViewItem = CType(e.Item, ListViewItem)
        Dim selectedSceneshot As Sceneshot = _lview.Items(glist.SelectedItems(0).Index).Tag
        With glist.gCurrCursor
            .gImage = selectedSceneshot.icon
            .gType = gCursorLib.gCursor.eType.Picture
            .MakeCursor()
        End With

        glist.DoDragDrop(glist.SelectedItems(0), DragDropEffects.Move)

        _SceneshotData.scenes = getSceneShotsFromListView()

        If OnlyViewMode Then
            _updateView()
        End If
        Application.DoEvents()
    End Sub

    Private Sub setSpacing(ByVal x As Integer, ByVal y As Integer)
        Dim LVM_FIRST As Integer = &H1000
        Dim LVM_SETICONSPACING As Integer = LVM_FIRST + 53
        SendMessage(_lview.Handle, LVM_SETICONSPACING, 0, y * 65536 + x)
        _lview.Refresh()
    End Sub


    Private Sub initializeImageList(ByVal x As Integer, ByVal y As Integer)
        If (_imageList.Images.Count = 0) Then
            _imageList.ImageSize = New Size(x, y)
            _imageList.ColorDepth = ColorDepth.Depth32Bit
            _lview.LargeImageList = _imageList
            If (OnlyViewMode) Then
                setSpacing(x + 10, y + 20)
            Else
                setSpacing(x + 20, y + 20)
            End If

        End If
    End Sub


    Class ListViewItemComparer
        Implements IComparer
        Private _me As ListView

        Public Sub New(ByVal listview As ListView)
            _me = listview
        End Sub


        Public Function Compare(ByVal x As Object, ByVal y As Object) As Integer _
           Implements IComparer.Compare
            Dim index1 As Integer = _me.Items.IndexOf(x)
            Dim index2 As Integer = _me.Items.IndexOf(y)
            Return index1.CompareTo(index2)
        End Function
    End Class

	Private Function getSceneShotsFromListView() As BindingList(Of Sceneshot)
		Dim scenes As BindingList(Of Sceneshot) = New BindingList(Of Sceneshot)
		For i As Integer = 0 To _lview.Items.Count - 1
			scenes.Add(_lview.Items(i).Tag)
		Next
		Return scenes
	End Function


    Private Sub _cntMenu_Opening(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles _cntMenu.Opening
        If _lview.Items.Count > 0 Then
			If _lview.SelectedItems.Count = 1 Then
				_cntMenu_changeLabel.Enabled = True
				_cntMenu_show.Enabled = True
				_cntMenu_saveimage.Enabled = True
				_cntMenu_delete.Enabled = True
			ElseIf _lview.SelectedItems.Count >= 1 Then
				_cntMenu_changeLabel.Enabled = False
				_cntMenu_show.Enabled = False
				_cntMenu_saveimage.Enabled = True
				_cntMenu_delete.Enabled = True
			Else
				_cntMenu_changeLabel.Enabled = False
				_cntMenu_show.Enabled = False
				_cntMenu_saveimage.Enabled = False
				_cntMenu_delete.Enabled = False
			End If

			_cntMenu_deleteAll.Enabled = True
            _cntMenu_options.Enabled = True
            _cntMenu_preview.Enabled = True
			_cntMenu_save.Enabled = True
			_cntMenu_SortByTimeCode.Enabled = True
			_cntMenu_SortByLabel.Enabled = True
			_cntMenu_saveimages.Enabled = True
        Else
            _cntMenu_changeLabel.Enabled = False
            _cntMenu_delete.Enabled = False
            _cntMenu_deleteAll.Enabled = False
            _cntMenu_options.Enabled = True
            _cntMenu_preview.Enabled = False
            _cntMenu_save.Enabled = False
            _cntMenu_show.Enabled = False
			_cntMenu_saveimage.Enabled = False
			_cntMenu_SortByTimeCode.Enabled = False
			_cntMenu_SortByLabel.Enabled = False
			_cntMenu_saveimages.Enabled = False

        End If

        If (OnlyViewMode) Then
            _sep1.Visible = False
			_sep2.Visible = False
			_sep3.Visible = False
            _cntMenu_options.Visible = False
            _cntMenu_preview.Visible = False
			_cntMenu_save.Visible = False

        End If

    End Sub


    Private Sub _cntMenu_changeLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _cntMenu_changeLabel.Click
        Dim item As ListViewItem = _lview.SelectedItems.Item(0)
        Dim frm As New frmChangeLabel(item.Text)
        Dim dlgResult As DialogResult = frm.ShowDialog()
        If dlgResult = DialogResult.OK Then
            item.Tag.label = frm.Label
            item.Text = frm.Label
            _lview.Refresh()
            If OnlyViewMode Then
                _updateView()
            End If
        End If
    End Sub



    Public Sub _cntMenu_show_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _cntMenu_show.Click, _lview.MouseDoubleClick
        If _lview.SelectedIndices.Count = 1 Then
            Dim s As Sceneshot = _lview.SelectedItems(0).Tag
            frmShowScene.Sceneshot = s
            frmShowScene.ShowDialog()
        End If
    End Sub

    Public Sub _cntMenu_preview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _cntMenu_preview.Click
        Me.Cursor = Cursors.WaitCursor
        Application.DoEvents()
        Dim frmPreview As New frmPreview(SceneshotData, frmMain.profile.cboProfile.Text)
        Me.Cursor = Cursors.Default
        frmPreview.ShowDialog()

        frmMain.profile.selectProfile(frmPreview.ctlProfile.cboProfile.Text)

    End Sub

    Public Sub _cntMenu_options_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _cntMenu_options.Click
        Me.Cursor = Cursors.WaitCursor
        Application.DoEvents()
		Me.Cursor = Cursors.Default
        Dim frm As frmOptions2 = New frmOptions2
        frm.Configuration = Configuration.getInstance
        frm.ShowDialog()
    End Sub

    Public Sub _cntMenu_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _cntMenu_save.Click
        Me.Cursor = Cursors.WaitCursor
        _SceneshotData.sceneshot = ImageUtil.generateSceneshotImage(_SceneshotData, _Configuration, True)
        Me.Cursor = Cursors.Default
        Dim rc = ImageUtil.saveImage(_SceneshotData)
        If rc Then
            Notification("sceneshots saved")
        End If
    End Sub

    Public Sub _cntMenu_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _cntMenu_delete.Click
        deleteSelectedSceneShots()
    End Sub

    Public Sub _cntMenu_deleteAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _cntMenu_deleteAll.Click
        deleteAllSceneshots()
    End Sub

    Private Sub _cntMenu_saveimage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _cntMenu_saveimage.Click
        If _lview.SelectedIndices.Count = 1 Then
            Dim rc = ImageUtil.saveSingleImage(_lview.SelectedItems(0).Tag, _Configuration)
            If rc Then
                Notification("Image is saved")
            End If
		Else
			Dim sceneshots As List(Of Sceneshot) = New List(Of Sceneshot)(_lview.SelectedItems.Count)
			For Each s As ListViewItem In _lview.SelectedItems
				sceneshots.Add(s.Tag)
			Next
            Dim rc = ImageUtil.saveImages(sceneshots, _Configuration)
			If rc Then
				Notification("Images are saved")
			End If
		End If
    End Sub

	Private Sub SortByTimeCodeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _cntMenu_SortByTimeCode.Click
		Me.Cursor = Cursors.WaitCursor
		SceneshotData.sortScenesByPosition()
		Me.Cursor = Cursors.Default
	End Sub

	Private Sub _cntMenu_SortByLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _cntMenu_SortByLabel.Click
		Me.Cursor = Cursors.WaitCursor
		SceneshotData.sortScenesByLabel()
		Me.Cursor = Cursors.Default
	End Sub

	Private Sub _cntMenu_saveimages_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _cntMenu_saveimages.Click
		Me.Cursor = Cursors.WaitCursor
		If _lview.Items.Count > 0 Then
			Dim sceneshots As List(Of Sceneshot) = New List(Of Sceneshot)(_lview.Items.Count)
			For Each s As ListViewItem In _lview.Items
				sceneshots.Add(s.Tag)
			Next
            Dim rc = ImageUtil.saveImages(sceneshots, _Configuration)
			If rc Then
				Notification("Images are saved")
			End If

		End If
		Me.Cursor = Cursors.Default
	End Sub
End Class
