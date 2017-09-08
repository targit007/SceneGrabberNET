Public NotInheritable Class frmTextboxLink

	Private _value As String

	Public Property Value() As String
		Get
			Return _value
		End Get
		Set(ByVal value As String)
			_value = value
			_txtbox.Text = value
		End Set
	End Property

	Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
		Me.Close()
	End Sub

	Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
		Value = _txtbox.Text
		Me.Close()
	End Sub
End Class
