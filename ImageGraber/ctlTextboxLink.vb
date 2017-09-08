Imports System.ComponentModel

Public Class ctlTextboxLink
	Implements INotifyPropertyChanged

	Public Event PropertyChanged As PropertyChangedEventHandler _
	   Implements INotifyPropertyChanged.PropertyChanged

	Protected Sub NotifyPropertyChanged(ByVal oldVal As Object, ByVal newVal As Object, ByVal info As String)
		If oldVal IsNot Nothing AndAlso Not oldVal.Equals(newVal) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(info))
		End If
	End Sub

	Private _Value As String
	Public Property Value() As String
		Get
			Return _Value
		End Get
		Set(ByVal value As String)
			Dim oldVal As String = _Value
			_Value = value
			NotifyPropertyChanged(oldVal, _Value, "value")
			setLinkLabel()
		End Set
	End Property

	Private _label As String
	<System.ComponentModel.Category("SceneGrabber.Net")> _
	Public Property LabelText() As String
		Get
			Return _label
		End Get
		Set(ByVal value As String)
			_label = value
			v_label.Text = _label
		End Set
	End Property


	Protected Sub setLinkLabel()
		Dim tooltiptext As String = v_label.Text + " " + Me.Value
		_tooltip.SetToolTip(v_label, tooltiptext)
		_tooltip.SetToolTip(v_value, tooltiptext)
		_tooltip.SetToolTip(Me, tooltiptext)

	End Sub

	
	Private Sub v_value_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles v_value.LinkClicked
		Dim frm As frmTextboxLink = New frmTextboxLink
		frm.Value = Me.Value
		Dim r As Rectangle = New Rectangle(sender.Left, sender.Top, sender.Width, sender.Height)
		r = Me.RectangleToScreen(r)
		frm.Location = New Point(r.Left - (frm.Width / 2), r.Bottom)
		frm.ShowDialog(Me)
		Value = frm.Value
	End Sub
End Class
