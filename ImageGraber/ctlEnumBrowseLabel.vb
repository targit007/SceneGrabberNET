Public Class ctlEnumBrowseLabel
	Inherits ctlEnumLinkLabel

	Private _browseIndex As Integer
	<System.ComponentModel.Category("SceneGrabber.Net")> _
	  Public Property BrowseIndex() As Integer
		Get
			Return _browseIndex
		End Get

		Set(ByVal value As Integer)
			_browseIndex = value
		End Set
	End Property

	Private _browsetyp As Integer
	<System.ComponentModel.Category("SceneGrabber.Net")> _
	 Public Property BrowseType() As Integer
		Get
			Return _browseTyp
		End Get

		Set(ByVal value As Integer)
			_browseTyp = value
		End Set
	End Property


	Private _browsevalue As String
	<System.ComponentModel.Category("SceneGrabber.Net")> _
	Public Property BrowseValue() As String
		Get
			Return _browsevalue
		End Get
		Set(ByVal value As String)
			Dim oldVal As String = _browsevalue
			_browsevalue = value
			NotifyPropertyChanged(oldVal, _browsevalue, "browsevalue")
			setLinkLabel()
		End Set
	End Property

	Private _browsetitle As String
	Public Property BrowseTitle() As String
		Get
			Return _browsetitle
		End Get
		Set(ByVal value As String)
			_browsetitle = value
		End Set
	End Property

	Protected Overrides Sub setLinkLabel()
		If Not _Type Is Nothing Then
			v_value.Text = Util.GetEnumDescription(_Type, Me.Value)
			Dim tooltiptext As String = v_label.Text + " " + Util.GetEnumExtendedDescription(_Type, Me.Value)
			If (Me.Value = BrowseIndex) Then
				tooltiptext = tooltiptext + vbCrLf + "Current: " + BrowseValue
			End If
			tooltip.SetToolTip(v_label, tooltiptext)
			tooltip.SetToolTip(v_value, tooltiptext)
			tooltip.SetToolTip(Me, tooltiptext)
		End If
	End Sub



	Private Sub _ctx_menu_ItemClicked(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles _ctx_menu.ItemClicked
		If (e.ClickedItem.Tag = BrowseIndex) Then
			'File Open
			If (BrowseType = 0) Then
				_ctx_menu.Visible = False
				BrowseValue = Util.openFileDialog(BrowseTitle, ImageUtil.FILEOPEN_IMAGE_PATTERN, BrowseValue, True)
				'File Save
			ElseIf BrowseType = 1 Then


				'Folder Open
			Else
				_ctx_menu.Visible = False
				BrowseValue = Util.FolderBrowserDialog(BrowseTitle, BrowseValue, True)
			End If
		End If
	End Sub

End Class
