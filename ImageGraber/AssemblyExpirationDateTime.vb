Imports System.Globalization

<AttributeUsage(AttributeTargets.Assembly)> _
Public Class AssemblyExpirationDateTime
    Inherits System.Attribute

    Private _bomb As String

    Public Sub New(ByVal bomb As String)
        _bomb = bomb
    End Sub

    Public Overridable ReadOnly Property expirationDateTime() As String
        Get
            Return _bomb
        End Get
    End Property


    Public Shared Function getExpirationDateTime() As DateTime
        Dim rc As DateTime = Nothing
        Dim attribs = System.Reflection.Assembly.GetCallingAssembly.GetCustomAttributes(False)
        For Each attrib In attribs
            Dim t As Type = attrib.GetType
            If t.Name = "AssemblyExpirationDateTime" Then
                rc = DateTime.ParseExact(CType(attrib, AssemblyExpirationDateTime).expirationDateTime, "dd.MM.yyyy", CultureInfo.InvariantCulture)
            End If
        Next
        Return rc
    End Function
End Class

