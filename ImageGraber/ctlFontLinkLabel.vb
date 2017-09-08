Imports System.ComponentModel

Public Class ctlFontLinkLabel
	Implements INotifyPropertyChanged

	Public Event PropertyChanged As PropertyChangedEventHandler _
	   Implements INotifyPropertyChanged.PropertyChanged

	Protected Sub NotifyPropertyChanged(ByVal oldVal As Object, ByVal newVal As Object, ByVal info As String)
		If oldVal IsNot Nothing AndAlso Not oldVal.Equals(newVal) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(info))
		End If
	End Sub

	Private _Value As Font

	Public Property Value() As Font
		Get
			Return _Value
		End Get
		Set(ByVal value As Font)
			Dim oldVal As Font = _Value
			_Value = value
			NotifyPropertyChanged(oldVal, _Value, "value")
			setLinkLabel()
		End Set
	End Property


	Private Sub setLinkLabel()
		If Not _Value Is Nothing Then
			v_font.Text = "Abc"
			v_font.Font = New Font(Value.FontFamily, 8, FontStyle.Regular)
			v_value.Text = "Change"
			Dim tooltip As String = "Font: " + Value.Name + "; Style: " + [Enum].GetName(GetType(FontStyle), Value.Style) + "; Size: " + CStr(Value.Size)
			Me.tooltip.SetToolTip(v_label, tooltip)
			Me.tooltip.SetToolTip(Me, tooltip)
			Me.tooltip.SetToolTip(v_value, tooltip)
		End If
	End Sub


	Private Sub v_value_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles v_value.LinkClicked
		Dim fntDlg As FontDialog = New FontDialog()
		fntDlg.Font = Value
		Dim dlgRes As DialogResult = fntDlg.ShowDialog
		If (dlgRes = DialogResult.OK) Then
			Value = fntDlg.Font
		End If
	End Sub
End Class
