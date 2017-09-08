Public Class Sceneshot

    Private _label As String
    Private _position As Double
    Private _image As Image
    Private _icon As Image


    Public ReadOnly Property image() As Image
        Get
            Return _image
        End Get
    End Property

    Public ReadOnly Property icon() As Image
        Get
            Return _icon
        End Get
    End Property

    Public ReadOnly Property position() As Double
        Get
            Return _position
        End Get
    End Property


    Public Property label() As String
        Get
            Return _label
        End Get
        Set(ByVal value As String)
            _label = value
        End Set
    End Property

    Public Sub New(ByVal image As Image, ByVal position As Double, ByVal icon As Image, ByVal label As String)
        _image = image
        _position = position
        _icon = icon
        _label = label
    End Sub

    Public Sub New(ByVal image As Image, ByVal position As Double)
        _image = image
        _position = position
        Dim CTime As TimeSpan = TimeSpan.FromSeconds(CLng(position))
        label = String.Format("{0:00}:{1:00}:{2:00}", CTime.Hours, CTime.Minutes, CTime.Seconds)
        _icon = ImageUtil.resizeMax100(_image)

    End Sub

	Public Class SceneshotPositionComparer
		Implements IComparer(Of Sceneshot)

		Public Function Compare(ByVal x As Sceneshot, ByVal y As Sceneshot) As Integer Implements System.Collections.Generic.IComparer(Of Sceneshot).Compare
			If x.position = y.position Then
				Return 0
			ElseIf x.position > y.position Then
				Return 1
			Else
				Return -1
			End If
		End Function
	End Class

	Public Class SceneshotLabelComparer
		Implements IComparer(Of Sceneshot)

		Public Function Compare(ByVal x As Sceneshot, ByVal y As Sceneshot) As Integer Implements System.Collections.Generic.IComparer(Of Sceneshot).Compare
			Return String.Compare(x.label, y.label)
		End Function
	End Class

End Class
