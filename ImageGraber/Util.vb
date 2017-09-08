Imports System.Net
Imports System.Globalization
Imports System.Reflection
Imports System.IO
Imports System.Management
Imports System.Text
Imports System.Security.Cryptography

Public Class Util

	Public Shared APP_TITLE As String = "SceneGrabber.NET" + " " + My.Application.Info.Version.ToString + " " + CType(isRegged(), String)

	Public Shared URL_DONATE As String = "https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=10606220"
	Public Const URL_HOME As String = "http://www.scenegrabber.net"
	Public Const URL_UPDATE As String = "http://www.scenegrabber.net/new"
	Public Const URL_UPDATE_CHECK As String = "http://www.scenegrabber.net/update.txt"
	Private Const DEFAULT_MOTHERBOARD_ID As String = "0800200C9A66"
	Private Const SHARED_KEY As String = "DONT_READ_THIS"


	Public Shared Function is32BitOSVersion() As Boolean
		If (IntPtr.Size = 4) Then
			Return True
		Else
			Return False
		End If
	End Function


	Private Shared Function getVersionFromServer() As String
		Dim rc As String = ""
		Try

            Dim req As HttpWebRequest = WebRequest.Create(URL_UPDATE_CHECK + "?" + My.Application.Info.Version.ToString + "&" + _
             CStr(My.Settings.use_count) + "&" + _
             CStr(My.Settings.ffmpeg_use) + "&" + _
             CStr(My.Settings.mplayer_use) + "&" + _
             Util.getRegistrationId())
			Dim res As HttpWebResponse = req.GetResponse
			Dim dataStream As IO.Stream = res.GetResponseStream
			Dim reader As New IO.StreamReader(dataStream)
			Dim responseFromServer As String = reader.ReadToEnd()
			If Not String.IsNullOrEmpty(responseFromServer) Then
				rc = responseFromServer
			End If
		Catch ex As Exception
			Trace.Write(ex.Message)
		End Try
		Return rc
	End Function


	Public Shared Function isRegged() As String
		'Read Registry and then decrpyt and test
		Dim regId As String = getRegistrationId()
		'Return "- Version is not activated."
		Return ""
	End Function



	Public Shared Function getRegistrationId() As String
		Return getDisk0Id()
	End Function



	Private Shared Function getDisk0Id() As String
		Dim ret As String = DEFAULT_MOTHERBOARD_ID
		Try
			'Dim searcher As New System.Management.ManagementObjectSearcher("SELECT SerialNumber FROM Win32_BaseBoard")
			'For Each obj As System.Management.ManagementObject In searcher.Get
			'ret = obj.Properties("SerialNumber").Value.ToString
			'Next
			Dim searcher As New System.Management.ManagementObjectSearcher("SELECT * FROM Win32_LogicalDisk")
			For Each mo As System.Management.ManagementObject In searcher.Get
				ret = mo.Properties("VolumeSerialNumber").Value.ToString()
				Exit For
			Next
			If (ret Is Nothing OrElse String.IsNullOrEmpty(ret.Trim)) Then
				ret = DEFAULT_MOTHERBOARD_ID
			End If
		Catch ex As Exception
			ret = DEFAULT_MOTHERBOARD_ID
		End Try
		Return ret
	End Function


	Public Shared Function newVersionIsOut() As Boolean
		Dim rc As String = getVersionFromServer()
		If rc.Equals(My.Application.Info.Version.ToString) Then
			Return False
		Else
			Return True
		End If
	End Function

	Public Shared Function isTimeBombExpired() As Boolean
		'Regel: Wenn UpdateCheck aus dann wird max 6 Monate die Version laufen
		'       Wenn UpdateCheck an und Version die Gleiche dann unbegrenzt
		'       Wenn UpdateCheck an und Version <> dann 3 Monate
		Dim serverVersion As String = getVersionFromServer()
		Dim expirationDateTime As DateTime = AssemblyExpirationDateTime.getExpirationDateTime
		Dim currentDateTime As DateTime = DateTime.Now

		If Not My.Settings.updatecheck Then
			If ((currentDateTime - expirationDateTime.AddMonths(6)).Ticks > 0) Then
				Return True
			End If
		Else
			If Not My.Application.Info.Version.ToString.Equals(serverVersion) Then
				If ((currentDateTime - expirationDateTime.AddMonths(3)).Ticks > 0) Then
					Return True
				End If
			End If
		End If
		Return False
	End Function


	Public Shared Function getDoubleTimeAsString(ByVal time As Double) As String
		Dim s As Integer = CInt(time)
		Dim h As Integer = Int(s / 3600)
		Dim m As Integer = Int((s - (h * 3600)) / 60)
		s = s - (h * 3600 + m * 60)
		Return String.Format("{0:D2}:{1:D2}:{2:D2}", h, m, s)
	End Function


	Public Shared Function openFileDialog(ByVal title As String, ByVal filepattern As String, ByVal filename As String)
		Return openFileDialog(title, filepattern, filename, False)
	End Function

	Public Shared Function FolderBrowserDialog(ByVal title As String, ByVal path As String)
		Return FolderBrowserDialog(title, path, False)
	End Function


	Public Shared Function FolderBrowserDialog(ByVal title As String, ByVal path As String, ByVal setpath As Boolean)
		Dim dlg As FolderBrowserDialog = New FolderBrowserDialog()
		dlg.Description = title
		If (setpath And Not String.IsNullOrEmpty(path)) Then
			dlg.SelectedPath = path
		End If
		Dim dlgRes As DialogResult = dlg.ShowDialog
		If (dlgRes = DialogResult.OK) Then
			path = dlg.SelectedPath
		End If
		Return path
	End Function


	Public Shared Function openFileDialog(ByVal title As String, ByVal filepattern As String, ByVal filename As String, ByVal setfilename As Boolean)
		Dim dlg As New OpenFileDialog
		dlg.Title = title
		dlg.Filter = filepattern
		If (setfilename And Not String.IsNullOrEmpty(filename)) Then
			dlg.FileName = filename
		End If
		If dlg.ShowDialog() = DialogResult.OK And Not String.IsNullOrEmpty(dlg.FileName) Then
			filename = dlg.FileName
		End If
		Return filename
	End Function

	Private Shared Function _GetEnumExtendedDescription(ByVal EnumConstant As [Enum], ByVal type As Integer) As String
		Dim fi As Reflection.FieldInfo = EnumConstant.GetType().GetField(EnumConstant.ToString())
		Dim attr() As EnumExtendedDescriptionAttribute = DirectCast(fi.GetCustomAttributes(GetType(EnumExtendedDescriptionAttribute), False), EnumExtendedDescriptionAttribute())
		If attr.Length > 0 Then
			If type = 0 Then
				Return attr(0).Description
			Else
				Return attr(0).ExtendedDescription
			End If
		Else
			Return EnumConstant.ToString()
		End If
	End Function

	Public Shared Function GetEnumDescription(ByVal EnumConstant As Type, ByVal value As Integer) As String
		Dim ec As [Enum] = [Enum].GetValues(EnumConstant)(value)
		Return _GetEnumExtendedDescription(ec, 0)
	End Function

	Public Shared Function GetEnumExtendedDescription(ByVal EnumConstant As Type, ByVal value As Integer) As String
		Dim ec As [Enum] = [Enum].GetValues(EnumConstant)(value)
		Return _GetEnumExtendedDescription(ec, 1)
	End Function


	Public Shared Sub notImplemented()
		MsgBox("this feature will be include in next releases of SceneGrabber.NET")
	End Sub

	Public Shared Function fileExists(ByVal file As String)
		If Not String.IsNullOrEmpty(file) Then
			Return System.IO.File.Exists(file)
		Else
			Return False
		End If

	End Function

	Public Shared Function isFFMpegValid() As Boolean
		If Not String.IsNullOrEmpty(My.Settings.ffmpeg_path) AndAlso fileExists(My.Settings.ffmpeg_path) Then
			Return True
		Else
			Return False
		End If
	End Function

    Public Shared Function isMPlayerValid() As Boolean
        If Not String.IsNullOrEmpty(My.Settings.mplayer_path) AndAlso fileExists(My.Settings.mplayer_path) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Shared Function saveChangesAfterMsgBox() As Boolean
        Dim ret As MsgBoxResult = MsgBox("Save changes ?", MsgBoxStyle.YesNo, APP_TITLE)
        If ret = MsgBoxResult.Yes Then
            Return True
        End If
        Return False
    End Function

    Public Shared Function getScenesCountBySeconds(ByVal duration As Double, ByVal intervall As Integer)
        Dim rc As Integer = 0
        Dim position As Double = 0
        position += intervall
        While (position <= duration)
            rc += 1
            position += intervall
        End While
        Return rc
    End Function
End Class
