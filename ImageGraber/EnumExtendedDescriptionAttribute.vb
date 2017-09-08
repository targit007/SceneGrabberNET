<AttributeUsage(AttributeTargets.Field)> _
Public Class EnumExtendedDescriptionAttribute
	Inherits Attribute

	Private _description As String
	Private _extendeddescription As String

	Public Property Description() As String
		Get
			Return _description
		End Get
		Set(ByVal Value As String)
			_description = Value
		End Set
	End Property

	Public Property ExtendedDescription() As String
		Get
			Return _extendeddescription
		End Get
		Set(ByVal Value As String)
			_extendeddescription = Value
		End Set
	End Property

	Public Sub New(ByVal desc As String, ByVal exdesc As String)
		Description = desc
		ExtendedDescription = exdesc
	End Sub

	Public Sub New(ByVal desc As String)
		Description = desc
		ExtendedDescription = desc
	End Sub

End Class
