Imports System.ComponentModel

Public Class SceneshotsHolder
    Inherits ABindingObject
    Implements ICloneable

    Public Event SceneshotList_assigned()
    Public Event SceneshotList_changed()
    Public Event SceneshotList_reset()
    Public Event Sceneshot_item_deleted()
    Public Event Sceneshot_item_added()

	Private Enum Sort
		POSITION = 0
		LABEL = 1
	End Enum

    Private _sceneshot As Image
    Public Property sceneshot() As Image
        Get
            Return _sceneshot
        End Get
        Set(ByVal value As Image)
            Dim oldVal As Image = _sceneshot
            _sceneshot = value
            NotifyPropertyChanged(oldVal, _sceneshot, "sceneshot")
        End Set
    End Property

    Private _movieinfo As MovieInfo
    Public Property movieinfo() As MovieInfo
        Get
            Return _movieinfo
        End Get
        Set(ByVal value As MovieInfo)
            Dim oldVal As MovieInfo = _movieinfo
            _movieinfo = value
            NotifyPropertyChanged(oldVal, _movieinfo, "movieinfo")
        End Set
    End Property


	Private WithEvents _scenes As BindingList(Of Sceneshot) = New BindingList(Of Sceneshot)
	Public Property scenes() As BindingList(Of Sceneshot)
		Get
			Return _scenes
		End Get
		Set(ByVal value As BindingList(Of Sceneshot))
			_scenes = value
			RaiseEvent SceneshotList_changed()
		End Set
	End Property

    Private Sub scenes_changed(ByVal sender As Object, ByVal e As ListChangedEventArgs) Handles _scenes.ListChanged
        If (e.ListChangedType = ListChangedType.Reset) Then
            RaiseEvent SceneshotList_reset()
        ElseIf (e.ListChangedType = ListChangedType.ItemDeleted) Then
            RaiseEvent Sceneshot_item_deleted()
        ElseIf (e.ListChangedType = ListChangedType.ItemAdded) Then
            RaiseEvent Sceneshot_item_added()
        End If

    End Sub

    ' Private WithEvents _configuration As Configuration
    ' Public Property Configuration() As Configuration
    '    Get
    '       Return _configuration
    '    End Get
    '    Set(ByVal value As Configuration)
    '        _configuration = value
    '    End Set
    'End Property

    Public Sub assignInitalSceneList(ByVal sList As BindingList(Of Sceneshot))
        _scenes = sList
        RaiseEvent SceneshotList_assigned()
    End Sub

    Public Sub sortScenesByPosition()
        sortScenes(Sort.POSITION)
    End Sub

    Public Sub sortScenesByLabel()
        sortScenes(Sort.LABEL)
    End Sub


    Private Sub sortScenes(ByVal sort As Sort)
        Dim listScenes As List(Of Sceneshot) = New List(Of Sceneshot)(Me.scenes.Count)
        Dim tmpListScenes As BindingList(Of Sceneshot) = New BindingList(Of Sceneshot)
        For Each item In scenes
            listScenes.Add(item)
        Next
        If sort = SceneshotsHolder.Sort.LABEL Then
            listScenes.Sort(New Sceneshot.SceneshotLabelComparer)
        Else
            listScenes.Sort(New Sceneshot.SceneshotPositionComparer)
        End If
        scenes.Clear()
        For Each item In listScenes
            tmpListScenes.Add(item)
        Next
        scenes = tmpListScenes
        RaiseEvent SceneshotList_assigned()
    End Sub


    Public Function Clone() As Object Implements System.ICloneable.Clone
        Dim s As New SceneshotsHolder
        s.scenes = New BindingList(Of Sceneshot)
        For Each i In Me.scenes
            s.scenes.Add(New Sceneshot(i.image, i.position, i.icon, i.label))
        Next
        '???
        s.movieinfo = Me.movieinfo
        '   s.Configuration = Me.Configuration
        s.sceneshot = Me.sceneshot
        Return s
    End Function
End Class
