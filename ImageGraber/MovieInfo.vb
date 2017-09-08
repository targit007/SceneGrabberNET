Imports System.Runtime.InteropServices
Imports System.Globalization
Imports System.Text.RegularExpressions
Imports System.IO

Public Class MovieInfo

#Region "MediaInfo"
    Private Declare Unicode Function MediaInfo32_New Lib "MediaInfo32.DLL" Alias "MediaInfo_New" () As IntPtr
    Private Declare Unicode Sub MediaInfo32_Delete Lib "MediaInfo32.DLL" Alias "MediaInfo_Delete" (ByVal Handle As IntPtr)
    Private Declare Unicode Function MediaInfo32_Open Lib "MediaInfo32.DLL" Alias "MediaInfo_Open" (ByVal Handle As IntPtr, ByVal FileName As String) As UIntPtr
    Private Declare Unicode Sub MediaInfo32_Close Lib "MediaInfo32.DLL" Alias "MediaInfo_Close" (ByVal Handle As IntPtr)
    Private Declare Unicode Function MediaInfo32_Inform Lib "MediaInfo32.DLL" Alias "MediaInfo_Inform" (ByVal Handle As IntPtr, ByVal Reserved As UIntPtr) As IntPtr
    Private Declare Unicode Function MediaInfo32_Option Lib "MediaInfo32.DLL" Alias "MediaInfo_Option" (ByVal Handle As IntPtr, ByVal Option_ As String, ByVal Value As String) As IntPtr

    Private Declare Unicode Function MediaInfo64_New Lib "MediaInfo64.DLL" Alias "MediaInfo_New" () As IntPtr
    Private Declare Unicode Sub MediaInfo64_Delete Lib "MediaInfo64.DLL" Alias "MediaInfo_Delete" (ByVal Handle As IntPtr)
    Private Declare Unicode Function MediaInfo64_Open Lib "MediaInfo64.DLL" Alias "MediaInfo_Open" (ByVal Handle As IntPtr, ByVal FileName As String) As UIntPtr
    Private Declare Unicode Sub MediaInfo64_Close Lib "MediaInfo64.DLL" Alias "MediaInfo_Close" (ByVal Handle As IntPtr)
    Private Declare Unicode Function MediaInfo64_Inform Lib "MediaInfo64.DLL" Alias "MediaInfo_Inform" (ByVal Handle As IntPtr, ByVal Reserved As UIntPtr) As IntPtr
    Private Declare Unicode Function MediaInfo64_Option Lib "MediaInfo64.DLL" Alias "MediaInfo_Option" (ByVal Handle As IntPtr, ByVal Option_ As String, ByVal Value As String) As IntPtr



    Private Function Inform(ByVal filename As String) As String
        Dim Handle As IntPtr
        Dim str As String
        If Util.is32BitOSVersion() Then
            Handle = MediaInfo32_New()
            MediaInfo32_Open(Handle, filename)
            MediaInfo32_Option(Handle, "Complete", "0")
            MediaInfo32_Option(Handle, "Inform", "")
            str = Marshal.PtrToStringAuto(MediaInfo32_Inform(Handle, 0))
            MediaInfo32_Close(Handle)
            MediaInfo32_Delete(Handle)
            Handle = Nothing
        Else
            Handle = MediaInfo64_New()
            MediaInfo64_Open(Handle, filename)
            MediaInfo64_Option(Handle, "Complete", "0")
            MediaInfo64_Option(Handle, "Inform", "")
            str = Marshal.PtrToStringAuto(MediaInfo64_Inform(Handle, 0))
            MediaInfo64_Close(Handle)
            MediaInfo64_Delete(Handle)
            Handle = Nothing
        End If
        Return str
    End Function

#End Region
    Private Const GENERAL_SECTION = "GENERAL"
    Private Const VIDEO_SECTION = "VIDEO"
    Private Const EMPTY = ""
    Private Const AUDIO_SECTION = "AUDIO"
    Private Const AUDIO_KEY = "A"

    Private Const GENERAL_COMPLETE_NAME = "COMPLETE.NAME"
    Private Const GENERAL_FILE_SIZE = "FILE.SIZE"
    Private Const GENERAL_FILE_SIZE_EXAKT = "FILE.SIZE.EXACT"
    Private Const GENERAL_FILENAME = "FILE.NAME"

	Private Const VIDEO_DURATION = "DURATION"
	Private Const VIDEO_DURATION_EXACT = "DURATION.EXACT"
    Private Const VIDEO_FRAMERATE = "FRAMERATE"
    Private Const VIDEO_WIDTH = "WIDTH"
    Private Const VIDEO_HEIGHT = "HEIGHT"
    Private Const VIDEO_CODEC_INFO = "CODEC.ID/HINT"
    Private Const VIDEO_CODEC_ID_INFO = "CODEC.ID/INFO"
    Private Const VIDEO_ASPECT_RATIO = "ASPECT.RATIO"
    Private Const VIDEO_BITRATE = "BITRATE"
    Private Const VIDEO_FRAMERATE_NOMINAL = "NOMINAL.FRAME.RATE"
    Private Const VIDEO_FORMAT = "FORMAT"
    Private Const VIDEO_CODEC = "CODEC"
    Private Const VIDEO_FRAMES = "FPS"

    Private Const AUDIO_CODEC = "A.CODEC"
    Private Const AUDIO_DURATION = "A.DURATION"
    Private Const AUDIO_FORMAT = "A.FORMAT"
    Private Const AUDIO_CODEC_INFO = "A.CODEC.ID/HINT"
    Private Const AUDIO_CODEC_ID_INFO = "A.CODEC.ID/INFO"
    Private Const AUDIO_BITRATE = "A.BITRATE"
    Private Const AUDIO_SAMPLE = "A.SAMPLE"
    Private Const AUDIO_SAMPLING_RATE = "A.SAMPLING.RATE"

    Private _attribues As Dictionary(Of String, String) = New Dictionary(Of String, String)
    Private _infoString As String

    Public ReadOnly Property info() As String
        Get
            Return _infoString
        End Get
    End Property

    Public Sub New(ByVal filePath As String)

        'test
        _infoString = Inform(filePath)
        Dim lines() = _infoString.Split(vbCrLf)
        Dim keyPart1 As String = ""
        For Each line As String In lines
            Dim keyPart2 As String = ""
            Dim value As String = ""
            line = line.Trim
            If (Not line.Equals("")) Then
                If (Not line.IndexOf(":") > 0) Then
                    keyPart1 = line.ToUpper.Trim
                    keyPart1 = keyPart1.Replace("#1", "").Trim
                    keyPart1 = keyPart1.Replace(GENERAL_SECTION, EMPTY)
                    keyPart1 = keyPart1.Replace(VIDEO_SECTION, EMPTY)
                    keyPart1 = keyPart1.Replace(AUDIO_SECTION, AUDIO_KEY)
                Else
                    Dim i As Integer = line.IndexOf(":")
                    'Normalize
                    keyPart2 = line.Substring(0, i).Trim.ToUpper
                    keyPart2 = Regex.Replace(keyPart2, "\s+", ".")
                    keyPart2 = keyPart2.Replace(",", ".")
                    keyPart2 = keyPart2.Replace("(", "")
                    keyPart2 = keyPart2.Replace(")", "")
                    keyPart2 = Regex.Replace(keyPart2, "\.+", ".")
                    keyPart2 = Regex.Replace(keyPart2, "FRAME.RATE", "FRAMERATE")
                    keyPart2 = Regex.Replace(keyPart2, "BIT.RATE", "BITRATE")
                    keyPart2 = Regex.Replace(keyPart2, "DISPLAY.", "")
                    value = line.Substring(i + 1).Trim
                    Dim key As String = IIf(String.IsNullOrEmpty(keyPart1), keyPart2, keyPart1 + "." + keyPart2)
                    Me.addAttribute(key, value)
                End If
            End If
        Next
        ' Defaults hinzufügen
        Dim f As FileInfo = New FileInfo(Me.getCompleteName)
        Me.addAttribute(GENERAL_FILE_SIZE_EXAKT.ToUpper, f.Length)

        'Filename
        Me.addAttribute(GENERAL_FILENAME, Me.getCompleteName.Substring(Me.getCompleteName.LastIndexOf("\") + 1))

        'Width & Height
        Me.addAttribute(VIDEO_HEIGHT, getCalcHeight)
        Me.addAttribute(VIDEO_WIDTH, getCalcWidth)

        'Codec
        Me.addAttribute(VIDEO_CODEC, getAttribute(VIDEO_CODEC_INFO, VIDEO_CODEC_ID_INFO, VIDEO_FORMAT))

        'Frames
        Me.addAttribute(VIDEO_FRAMES, getAttribute(VIDEO_FRAMERATE, VIDEO_FRAMERATE_NOMINAL))

        'Duration
        Me.addAttribute(VIDEO_DURATION, getAttribute(VIDEO_DURATION, AUDIO_DURATION))

        'Audio Codec
        Me.addAttribute(AUDIO_CODEC, getAttribute(AUDIO_CODEC_INFO, AUDIO_CODEC_ID_INFO, AUDIO_FORMAT))

        'Audio Sample
        Me.addAttribute(AUDIO_SAMPLE, getAttribute(AUDIO_SAMPLING_RATE))

		'Duration Exakt
		Me.addAttribute(VIDEO_DURATION_EXACT, getExaktDuration())


    End Sub

	Public Function getExaktDuration() As String
		Dim durationExakt As String = ""
		Try
			Dim oMedia As DexterLib.MediaDet = New DexterLib.MediaDet
			oMedia.Filename = Me.getAttribute(GENERAL_COMPLETE_NAME)
			durationExakt = Util.getDoubleTimeAsString(oMedia.StreamLength)
		Catch ex As Exception
			Console.WriteLine(ex.Message)
		End Try
		Return durationExakt
	End Function


	Private Sub addAttribute(ByVal key As String, ByVal value As String)
		If Not (String.IsNullOrEmpty(key)) AndAlso Not (String.IsNullOrEmpty(value)) Then
			Dim k As String = key.ToUpper
			If Not _attribues.ContainsKey(k) Then
				_attribues.Add(k, value)
			Else
				_attribues.Item(k) = value
			End If
		End If
	End Sub

	Private Function getInternalAttribute(ByVal key As String) As String
		If (_attribues.ContainsKey(key.ToUpper)) Then
			Return _attribues.Item(key.ToUpper)
		Else
			Return Nothing
		End If
	End Function

	Public Function getAttributes() As Dictionary(Of String, String)
		Return _attribues
	End Function

	Public Function getFrameRatePerSeconds() As Double
		Return getCalcFrameRatePerSeconds()
	End Function

	Private Function getCalcFrameRatePerSeconds() As Double
		Dim strFrameRate As String = Me.getAttribute(VIDEO_FRAMERATE)
		If (strFrameRate Is Nothing) Then
			strFrameRate = getFramerateNominal()
		End If
		If Not strFrameRate Is Nothing AndAlso Not String.IsNullOrEmpty(strFrameRate) Then
			strFrameRate = strFrameRate.Substring(0, strFrameRate.IndexOf(" "))
			Return Convert.ToDouble(strFrameRate, NumberFormatInfo.InvariantInfo)
		Else
			Return 0D
		End If
	End Function

	Private Function getCalcWidth() As Integer
		Dim strWidth As String = Me.getAttribute(VIDEO_WIDTH)
		strWidth = strWidth.Replace(" ", "")
		strWidth = strWidth.Replace("pixels", "")
		Return CInt(strWidth)
	End Function

	Private Function getCalcHeight() As Integer
		Dim strHeight As String = Me.getAttribute(VIDEO_HEIGHT)
		strHeight = strHeight.Replace(" ", "")
		strHeight = strHeight.Replace("pixels", "")
		Return CInt(strHeight)
	End Function

	Public Function getCompleteName() As String
		Return Me.getAttribute(GENERAL_COMPLETE_NAME)
	End Function

	Public Function getFileName() As String
		Return Me.getAttribute(GENERAL_FILENAME)
	End Function

	Public Function getWidth() As String
		Return Me.getAttribute(VIDEO_WIDTH)
	End Function

	Public Function getHeight() As String
		Return Me.getAttribute(VIDEO_HEIGHT)
	End Function

	Private Function getFramerateNominal() As String
		Return Me.getAttribute(VIDEO_FRAMERATE_NOMINAL)
	End Function

	Public Function evaluatePattern(ByVal str As String) As String
		'Replace with Values
		For Each key In getAttributes.Keys
			str = Regex.Replace(str, "\[" + key + "\]", getAttribute(key), RegexOptions.IgnoreCase)
		Next
		'Replace not Exists in Coll
		str = Regex.Replace(str, "\[.*\]", "")
		Return str
	End Function

	Public Function getAttribute(ByVal ParamArray Args()) As String
		Dim val As String
		For Each arg In Args
			val = Me.getInternalAttribute(arg)
			If (Not val Is Nothing) Then
				Return val
			End If
		Next
		Return ""
	End Function

End Class
