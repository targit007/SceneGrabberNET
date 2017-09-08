Public Class AUserControl
    Public Event NotificationMsg(ByVal eventMsg As String)

    Public Sub Notification(ByVal msg As String)
        RaiseEvent NotificationMsg(msg)
        Console.WriteLine(msg)
    End Sub
End Class
