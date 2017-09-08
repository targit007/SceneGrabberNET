Imports System.ComponentModel

Public Class ABindingObject
    Implements INotifyPropertyChanged

    Public Event PropertyChanged As PropertyChangedEventHandler _
          Implements INotifyPropertyChanged.PropertyChanged

	Protected Sub NotifyPropertyChanged(ByVal oldVal As Object, ByVal newVal As Object, ByVal info As String)
		If oldVal IsNot Nothing AndAlso Not oldVal.Equals(newVal) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(info))
		End If
	End Sub

End Class
