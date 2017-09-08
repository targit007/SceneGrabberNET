Imports System.ComponentModel

Public Class ctlColorLinkLabel
	Implements INotifyPropertyChanged

	Public Event PropertyChanged As PropertyChangedEventHandler _
	   Implements INotifyPropertyChanged.PropertyChanged

	Protected Sub NotifyPropertyChanged(ByVal oldVal As Object, ByVal newVal As Object, ByVal info As String)
		If oldVal IsNot Nothing AndAlso Not oldVal.Equals(newVal) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(info))
		End If
	End Sub

	Private _Value As Color

	Public Property Value() As Color
		Get
			Return _Value
		End Get
		Set(ByVal value As Color)
			Dim oldVal As Color = _Value
			_Value = value
			NotifyPropertyChanged(oldVal, _Value, "value")
			setButtonColor()
		End Set
	End Property


	Private Sub setButtonColor()
		v_value.ButtonColor = Value
		Dim tooltip As String = "Color: " + Value.Name
		Me.tooltip.SetToolTip(v_label, tooltip)
		Me.tooltip.SetToolTip(Me, tooltip)
		Me.tooltip.SetToolTip(v_value, tooltip)
		'End If
	End Sub


	Private Sub v_value_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles v_value.Click
		Dim colDlg As ColorDialog = New ColorDialog()
		colDlg.Color = Value
		Dim dlgRes As DialogResult = colDlg.ShowDialog
		If (dlgRes = DialogResult.OK) Then
			Value = colDlg.Color
		End If
	End Sub
End Class
