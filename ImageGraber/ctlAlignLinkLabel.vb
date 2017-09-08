﻿Imports System.ComponentModel
Imports System.Drawing.Design

Public Class ctlAlignLinkLabel

	Implements INotifyPropertyChanged

	Public Event PropertyChanged As PropertyChangedEventHandler _
	   Implements INotifyPropertyChanged.PropertyChanged

	Protected Sub NotifyPropertyChanged(ByVal oldVal As Object, ByVal newVal As Object, ByVal info As String)
		If oldVal IsNot Nothing AndAlso Not oldVal.Equals(newVal) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(info))
		End If
	End Sub

	Private _Value As Integer
	Public Property Value() As Integer
		Get
			Return _Value
		End Get
		Set(ByVal value As Integer)
			Dim oldVal As Integer = _Value
			_Value = value
			NotifyPropertyChanged(oldVal, _Value, "value")
			setLinkLabel()
		End Set
	End Property

	Private _Type As Type = Type.GetType("SceneGrabberNET.ImageUtil+TextLocation")
	<System.ComponentModel.Category("SceneGrabber.Net")> _
	Public Property EnumType() As String
		Get
			If _Type Is Nothing Then
				Return ""
			Else
				Return _Type.ToString
			End If
		End Get

		Set(ByVal value As String)
			_Type = Type.GetType(value)
		End Set
	End Property




	Private Sub setLinkLabel()
		If Not _Type Is Nothing Then
			v_value.Text = "Change"
			v_label_picture.Image = _imagelist.Images(Value)
			Dim tooltiptext As String = "Align: " + Util.GetEnumDescription(_Type, Me.Value)
			tooltip.SetToolTip(v_label, tooltiptext)
			tooltip.SetToolTip(v_value, tooltiptext)
			tooltip.SetToolTip(v_label_picture, tooltiptext)
		End If
	End Sub

	Private Sub generateContextMenu()
		_ctx_menu.Items.Clear()
		For Each enumKey As Integer In [Enum].GetValues(_Type)
			Dim o As ToolStripItem = New ToolStripMenuItem(Util.GetEnumDescription(_Type, enumKey), _imagelist.Images(enumKey))
			o.Tag = enumKey
			_ctx_menu.Items.Add(o)
		Next
	End Sub


	Private Sub _align_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles v_value.Click

		Dim mouseEventArgs As MouseEventArgs = e
		generateContextMenu()
		_ctx_menu.Show(Me, New Point(mouseEventArgs.X, mouseEventArgs.Y))

	End Sub


	Private Sub _ctx_menu_ItemClicked(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles _ctx_menu.ItemClicked
		Value = e.ClickedItem.Tag
	End Sub


End Class

