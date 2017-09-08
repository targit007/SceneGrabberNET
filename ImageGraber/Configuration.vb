Imports System.ComponentModel
Imports System.Drawing.Imaging
Imports SceneGrabberNET.ImageUtil
Imports System.Xml.Serialization

Public Class Configuration
    Inherits ABindingObject
    Implements ICloneable

    Private Shared XML_VBCRLF As String = "###VBCRLF###"

    Public Event Configuration_reset()
    Public Event Configuration_reload()
    Public Event Configuration_save()

    Private Shared _me As Configuration
    'Layout

    Private _sceneshotmode As Integer
    Public Property sceneshotmode() As Integer
        Get
            Return _sceneshotmode
        End Get
        Set(ByVal value As Integer)
            Dim oldVal As Integer = _columns
            _sceneshotmode = value
            NotifyPropertyChanged(oldVal, _sceneshotmode, "sceneshotmode")
        End Set
    End Property

    Private _sceneshotcount As Integer
    Public Property sceneshotcount() As Integer
        Get
            Return _sceneshotcount
        End Get
        Set(ByVal value As Integer)
            Dim oldVal As Integer = _columns
            _sceneshotcount = value
            NotifyPropertyChanged(oldVal, _sceneshotcount, "sceneshotcount")
        End Set
    End Property


    Private _sceneshotsec As Integer
    Public Property sceneshotsec() As Integer
        Get
            Return _sceneshotsec
        End Get
        Set(ByVal value As Integer)
            Dim oldVal As Integer = _columns
            _sceneshotsec = value
            NotifyPropertyChanged(oldVal, _sceneshotsec, "sceneshotsec")
        End Set
    End Property



    Private _columns As Integer
    Public Property columns() As Integer
        Get
            Return _columns
        End Get
        Set(ByVal value As Integer)
            Dim oldVal As Integer = _columns
            _columns = value
            NotifyPropertyChanged(oldVal, _columns, "colums")
        End Set
    End Property
    Private _tilewidth As Integer
    Public Property tilewidth() As Integer
        Get
            Return _tilewidth
        End Get
        Set(ByVal value As Integer)
            Dim oldVal As Integer = _tilewidth
            _tilewidth = value
            NotifyPropertyChanged(oldVal, _tilewidth, "tilewidth")
        End Set
    End Property
    Private _tileheight As Integer
    Public Property tileheight() As Integer
        Get
            Return _tileheight
        End Get
        Set(ByVal value As Integer)
            Dim oldVal As Integer = _tileheight
            _tileheight = value
            NotifyPropertyChanged(oldVal, _tileheight, "tileheight")
        End Set
    End Property
    Private _gapheight As Integer
    Public Property gapheight() As Integer
        Get
            Return _gapheight
        End Get
        Set(ByVal value As Integer)
            Dim oldVal As Integer = _gapheight
            _gapheight = value
            NotifyPropertyChanged(oldVal, _gapheight, "gapheight")
        End Set
    End Property
    Private _gapwidth As Integer
    Public Property gapwidth() As Integer
        Get
            Return _gapwidth
        End Get
        Set(ByVal value As Integer)
            Dim oldVal As Integer = _gapwidth
            _gapwidth = value
            NotifyPropertyChanged(oldVal, _gapwidth, "gapwidth")
        End Set
    End Property

    Private _detailtextlocation As Integer
    Public Property detailtextlocation() As Integer
        Get
            Return _detailtextlocation
        End Get
        Set(ByVal value As Integer)
            Dim oldVal As Integer = _detailtextlocation
            _detailtextlocation = value
            NotifyPropertyChanged(oldVal, _detailtextlocation, "detailtextlocation")
        End Set
    End Property
    'image
    Private _bordertype As Integer
    Public Property bordertype() As Integer
        Get
            Return _bordertype
        End Get
        Set(ByVal value As Integer)
            Dim oldVal As Boolean = _bordertype
            _bordertype = value
            NotifyPropertyChanged(oldVal, _bordertype, "bordertype")
        End Set
    End Property
    Private _labels As Boolean
    Public Property labels() As Boolean
        Get
            Return _labels
        End Get
        Set(ByVal value As Boolean)
            Dim oldVal As Boolean = _labels
            _labels = value
            NotifyPropertyChanged(oldVal, _labels, "lables")
        End Set
    End Property


    Private _labelcolorxml As String
    Public Property labelcolorXml() As String
        Get
            Return ColorTranslator.ToHtml(labelcolor)
        End Get
        Set(ByVal value As String)
            Dim oldVal As String = _labelcolorxml
            _labelcolorxml = value
            labelcolor = ColorTranslator.FromHtml(_labelcolorxml)
        End Set
    End Property
    Private _labelcolor As Color
    <XmlIgnore()> Public Property labelcolor() As Color
        Get
            Return _labelcolor
        End Get
        Set(ByVal value As Color)
            Dim oldVal As Color = _labelcolor
            _labelcolor = value
            NotifyPropertyChanged(oldVal, _labelcolor, "labelcolor")
        End Set
    End Property

    Private _labelfont As Font
    <XmlIgnore()> Public Property labelfont() As Font
        Get
            Return _labelfont
        End Get
        Set(ByVal value As Font)
            Dim oldval As Font = _labelfont
            _labelfont = value
            NotifyPropertyChanged(oldval, _labelfont, "labelfont")
        End Set
    End Property

    Private _labelfontxml As String
    Public Property labelfontXml() As String
        Get
            Return TypeDescriptor.GetConverter(GetType(Font)).ConvertToString(labelfont)
        End Get
        Set(ByVal value As String)
            Dim oldVal As String = _labelfontxml
            _labelfontxml = value
            labelfont = TypeDescriptor.GetConverter(GetType(Font)).ConvertFromString(_labelfontxml)
        End Set
    End Property

    'detailtext
    Private _detailtext As String
    <XmlIgnore()> Public Property detailtext() As String
        Get
            Return _detailtext
        End Get
        Set(ByVal value As String)
            Dim oldVal As String = _detailtext
            _detailtext = value
            _maxtabstob = getLongestTabStob()
            NotifyPropertyChanged(oldVal, _detailtext, "detailtext")
        End Set
    End Property
    Private _detailtextxml As String
    Public Property detailtextXml() As String
        Get
            Return detailtext.Replace(vbCrLf, XML_VBCRLF)
        End Get
        Set(ByVal value As String)
            Dim oldVal As String = _detailtextxml
            _detailtextxml = value
            detailtext = _detailtextxml.Replace(XML_VBCRLF, vbCrLf)
        End Set
    End Property


    Private _maxtabstob As String
    Public ReadOnly Property maxtabstob() As String
        Get
            Return _maxtabstob
        End Get
    End Property



    Private _details As Boolean
    Public Property details() As Boolean
        Get
            Return _details
        End Get
        Set(ByVal value As Boolean)
            Dim oldVal As Boolean = _details
            _details = value
            NotifyPropertyChanged(oldVal, _details, "details")
        End Set
    End Property


    Private _detaillabelcolor As Color
    <XmlIgnore()>Public Property detaillabelcolor() As Color
        Get
            Return _detaillabelcolor
        End Get
        Set(ByVal value As Color)
            Dim oldval As Color = _detaillabelcolor
            _detaillabelcolor = value
            NotifyPropertyChanged(oldval, _detaillabelcolor, "detaillabelcolor")
        End Set
    End Property

    Private _detaillabelcolorxml As String
    Public Property detaillabelcolorXml() As String
        Get
            Return ColorTranslator.ToHtml(detaillabelcolor)
        End Get
        Set(ByVal value As String)
            Dim oldVal As String = _detaillabelcolorxml
            _detaillabelcolorxml = value
            detaillabelcolor = ColorTranslator.FromHtml(_detaillabelcolorxml)
        End Set
    End Property


    Private _detailfont As Font
    <XmlIgnore()> Public Property detailfont() As Font
        Get
            Return _detailfont
        End Get
        Set(ByVal value As Font)
            Dim oldval As Font = _detailfont
            _detailfont = value
            NotifyPropertyChanged(oldval, _detailfont, "detailfont")
        End Set
    End Property

    Private _detailfontxml As String
    Public Property labeldetailfontXml() As String
        Get
            Return TypeDescriptor.GetConverter(GetType(Font)).ConvertToString(detailfont)
        End Get
        Set(ByVal value As String)
            Dim oldVal As String = _detailfontxml
            _detailfontxml = value
            detailfont = TypeDescriptor.GetConverter(GetType(Font)).ConvertFromString(_detailfontxml)
        End Set
    End Property

    Private _color As Color
    <XmlIgnore()> Public Property color() As Color
        Get
            Return _color
        End Get
        Set(ByVal value As Color)
            Dim oldval As Color = color
            _color = value
            NotifyPropertyChanged(oldval, _color, "detailcolor")
        End Set
    End Property

    Private _colorxml As String
    Public Property colorXml() As String
        Get
            Return ColorTranslator.ToHtml(color)
        End Get
        Set(ByVal value As String)
            Dim oldVal As String = _colorxml
            _colorxml = value
            color = ColorTranslator.FromHtml(_colorxml)
        End Set
    End Property

    'jpg
    Private _quality As Integer
    Public Property quality() As Integer
        Get
            Return _quality
        End Get
        Set(ByVal value As Integer)
            Dim oldval As Integer = _quality
            _quality = value
            NotifyPropertyChanged(oldval, _quality, "quality")
        End Set
    End Property
    Private _progressive As Boolean
    Public Property progressive() As Boolean
        Get
            Return _progressive
        End Get
        Set(ByVal value As Boolean)
            Dim oldval = _progressive
            _progressive = value
            NotifyPropertyChanged(oldval, _progressive, "progressive")
        End Set
    End Property

    Private _imageformat As Integer
    Public Property imageFormat() As Integer
        Get
            Return _imageformat
        End Get
        Set(ByVal value As Integer)
            Dim oldval = _imageformat
            _imageformat = value
            NotifyPropertyChanged(oldval, _imageformat, "imageformat")
        End Set
    End Property

    Private _imagesizemode As Integer
    Public Property imagesizemode() As Integer
        Get
            Return _imagesizemode
        End Get
        Set(ByVal value As Integer)
            Dim oldval = imagesizemode
            _imagesizemode = value
            NotifyPropertyChanged(oldval, _imagesizemode, "imagesizemode")
        End Set
    End Property

    Private _imagepercent As Integer
    Public Property imagepercent() As Integer
        Get
            Return _imagepercent
        End Get
        Set(ByVal value As Integer)
            Dim oldval = _imagepercent
            _imagepercent = value
            NotifyPropertyChanged(oldval, _imagepercent, "imagepercent")
        End Set
    End Property

    Private _savemode As Integer
    Public Property savemode() As Integer
        Get
            Return _savemode
        End Get
        Set(ByVal value As Integer)
            Dim oldval = _savemode
            _savemode = value
            NotifyPropertyChanged(oldval, _savemode, "savemode")
        End Set
    End Property

    Private _savepath As String
    Public Property savepath() As String
        Get
            Return _savepath
        End Get
        Set(ByVal value As String)
            Dim oldval = _savepath
            _savepath = value
            NotifyPropertyChanged(oldval, _savepath, "savepath")
        End Set
    End Property

    Private _backgroundimage As String
    Public Property backgroundimage() As String
        Get
            Return _backgroundimage
        End Get
        Set(ByVal value As String)
            Dim oldval = _backgroundimage
            _backgroundimage = value
            NotifyPropertyChanged(oldval, _backgroundimage, "backgroundimage")
        End Set
    End Property

    Private _background As Integer
    Public Property background() As Integer
        Get
            Return _background
        End Get
        Set(ByVal value As Integer)
            Dim oldval = _background
            _background = value
            NotifyPropertyChanged(oldval, _background, "background")
        End Set
    End Property

    Private _border_shadow As Boolean
    Public Property border_shadow() As Boolean
        Get
            Return _border_shadow
        End Get
        Set(ByVal value As Boolean)
            Dim oldval = _border_shadow
            _border_shadow = value
            NotifyPropertyChanged(oldval, _border_shadow, "border_shadow")
        End Set
    End Property

    Private _bordercolor As Color
    <XmlIgnore()> Public Property bordercolor() As Color
        Get
            Return _bordercolor
        End Get
        Set(ByVal value As Color)
            Dim oldval = _bordercolor
            _bordercolor = value
            NotifyPropertyChanged(oldval, _bordercolor, "bordercolor")
        End Set
    End Property

    Private _bordercolorxml As String
    Public Property bordercolorXml() As String
        Get
            Return ColorTranslator.ToHtml(bordercolor)
        End Get
        Set(ByVal value As String)
            Dim oldVal As String = _bordercolorxml
            _bordercolorxml = value
            bordercolor = ColorTranslator.FromHtml(_bordercolorxml)
        End Set
    End Property

    Private _bordersize As Integer
    Public Property bordersize() As Integer
        Get
            Return _bordersize
        End Get
        Set(ByVal value As Integer)
            Dim oldval = _bordersize
            _bordersize = value
            NotifyPropertyChanged(oldval, _bordersize, "bordersize")
        End Set
    End Property

    Private _use_watermark As Boolean
    Public Property use_watermark() As Boolean
        Get
            Return _use_watermark
        End Get
        Set(ByVal value As Boolean)
            Dim oldval = _use_watermark
            _use_watermark = value
            NotifyPropertyChanged(oldval, _use_watermark, "use_watermark")
        End Set
    End Property


    Private _watermarktype As Integer
    Public Property watermarktype() As Integer
        Get
            Return _watermarktype
        End Get
        Set(ByVal value As Integer)
            Dim oldval = _watermarktype
            _watermarktype = value
            NotifyPropertyChanged(oldval, _watermarktype, "watermarktype")
        End Set
    End Property

    Private _watermarktlocation As Integer
    Public Property watermarktlocation() As Integer
        Get
            Return _watermarktlocation
        End Get
        Set(ByVal value As Integer)
            Dim oldval = _watermarktlocation
            _watermarktlocation = value
            NotifyPropertyChanged(oldval, _watermarktlocation, "watermarktlocation")
        End Set
    End Property

    Private _watermarktext As String
    <XmlIgnore()> Public Property watermarktext() As String
        Get
            Return _watermarktext
        End Get
        Set(ByVal value As String)
            Dim oldval = _watermarktext
            _watermarktext = value
            NotifyPropertyChanged(oldval, _watermarktext, "watermarktext")
        End Set
    End Property


    Private _watermarktextxml As String
    Public Property watermarktextXml() As String
        Get
            Return watermarktext.Replace(vbCrLf, XML_VBCRLF)
        End Get
        Set(ByVal value As String)
            Dim oldVal As String = _watermarktextxml
            _watermarktextxml = value
            watermarktext = _watermarktextxml.Replace(XML_VBCRLF, vbCrLf)
        End Set
    End Property



    Private _watermarkimage As String
    Public Property watermarkimage() As String
        Get
            Return _watermarkimage
        End Get
        Set(ByVal value As String)
            Dim oldval = _watermarkimage
            _watermarkimage = value
            NotifyPropertyChanged(oldval, _watermarkimage, "watermarkimage")
        End Set
    End Property

    Private _watermarkfont As Font
    <XmlIgnore()> Public Property watermarkfont() As Font
        Get
            Return _watermarkfont
        End Get
        Set(ByVal value As Font)
            Dim oldval As Font = _watermarkfont
            _watermarkfont = value
            NotifyPropertyChanged(oldval, _watermarkfont, "watermarkfont")
        End Set
    End Property

    Private _watermarkfontxml As String
    Public Property watermarkfontXml() As String
        Get
            Return TypeDescriptor.GetConverter(GetType(Font)).ConvertToString(watermarkfont)
        End Get
        Set(ByVal value As String)
            Dim oldVal As String = _watermarkfontxml
            _watermarkfontxml = value
            watermarkfont = TypeDescriptor.GetConverter(GetType(Font)).ConvertFromString(_watermarkfontxml)
        End Set
    End Property


    Private _watermarkoffsetX As Integer
    Public Property watermarkoffsetX() As Integer
        Get
            Return _watermarkoffsetX
        End Get
        Set(ByVal value As Integer)
            Dim oldval = _watermarkoffsetX
            _watermarkoffsetX = value
            NotifyPropertyChanged(oldval, _watermarkoffsetX, "watermarkoffsetX")
        End Set
    End Property

    Private _watermarkoffsetY As Integer
    Public Property watermarkoffsetY() As Integer
        Get
            Return _watermarkoffsetY
        End Get
        Set(ByVal value As Integer)
            Dim oldval = _watermarkoffsetY
            _watermarkoffsetY = value
            NotifyPropertyChanged(oldval, _watermarkoffsetY, "watermarkoffsetY")
        End Set
    End Property

    Private _watermarkcolor As Color
    <XmlIgnore()> Public Property watermarkcolor() As Color
        Get
            Return _watermarkcolor
        End Get
        Set(ByVal value As Color)
            Dim oldVal As Color = _watermarkcolor
            _watermarkcolor = value
            NotifyPropertyChanged(oldVal, _watermarkcolor, "watermarkcolor")
        End Set
    End Property

    Private _watermarkcolorxml As String
    Public Property watermarkcolorXml() As String
        Get
            Return ColorTranslator.ToHtml(watermarkcolor)
        End Get
        Set(ByVal value As String)
            Dim oldVal As String = _watermarkcolorxml
            _watermarkcolorxml = value
            watermarkcolor = ColorTranslator.FromHtml(_watermarkcolorxml)
        End Set
    End Property


    Private _labeltextlocation As Integer
    Public Property labeltextlocation() As Integer
        Get
            Return _labeltextlocation
        End Get
        Set(ByVal value As Integer)
            Dim oldval = _labeltextlocation
            _labeltextlocation = value
            NotifyPropertyChanged(oldval, _labeltextlocation, "labeltextlocation")
        End Set
    End Property


    Private _naming As Integer
    Public Property naming() As Integer
        Get
            Return _naming
        End Get
        Set(ByVal value As Integer)
            Dim oldval = _naming
            _naming = value
            NotifyPropertyChanged(oldval, _naming, "naming")
        End Set
    End Property


    Public Shared Function getInstance() As Configuration
        If (_me Is Nothing) Then
            _me = New Configuration
        End If
        Return _me
    End Function

    Public Shared Sub setInstance(ByVal conf As Configuration)
        _me = conf
    End Sub

    Private Sub New()
    End Sub


    Private Function getLongestTabStob() As String
        Dim maxLen As Integer
        Dim rc As String = ""
        Dim lines() As String = detailtext.Split(vbCrLf)
        For Each line In lines
            Dim pos = line.IndexOf(vbTab)
            If pos > 0 AndAlso pos > maxLen Then
                maxLen = pos
            End If
        Next
        For i = 0 To maxLen - 1
            rc = rc + "a"
        Next
        Return rc
    End Function


    Public Sub reset()
        detailtext = "Title:" + vbTab + "[FILE.NAME] - [FILE.SIZE]" + vbCrLf + _
                        "Time:" + vbTab + "[DURATION]" + vbCrLf + _
                        "Res.:" + vbTab + "[WIDTH] x [HEIGHT] - [FPS]" + vbCrLf + _
                        "Aspect:" + vbTab + "[ASPECT.RATIO]" + vbCrLf + _
                        "Video:" + vbTab + "[CODEC] - [BITRATE]" + vbCrLf + _
                        "Audio:" + vbTab + "[A.CODEC] - [A.BITRATE]@[A.SAMPLE]"
        columns = 4
        progressive = True
        quality = 100
        tileheight = 222
        tilewidth = 296
        gapheight = 10
        gapwidth = 10
        labels = True
        bordertype = ImageUtil.BorderType.None
        labelcolor = color.White
        labelfont = New Font("Arial", 10, FontStyle.Bold)
        details = True
        detaillabelcolor = color.Black
        detailfont = New Font("Arial", 10, FontStyle.Bold)
        detailtextlocation = ImageUtil.DetailTextLocation.TopLeft
        color = color.Beige
        imageFormat = ImageUtil.ImageTyp.JPG
        imagesizemode = 0
        imagepercent = 100
        savemode = ImageUtil.SaveMode.ASK
        background = ImageUtil.Background.Color
        savepath = ""
        use_watermark = True
        border_shadow = True
        bordercolor = color.White
        bordersize = 2
        watermarktlocation = ImageUtil.WatermarkLocation.TopRight
        watermarktype = ImageUtil.WatermarkType.TEXT
        watermarktext = "SceneGrabber.NET"
        watermarkimage = ""
        watermarkfont = New Font("Arial", 20, FontStyle.Bold)
        watermarkoffsetX = 10
        watermarkoffsetY = 10
        watermarkcolor = color.Gray
        labeltextlocation = ImageUtil.TextLocation.BottomLeft
        naming = ImageUtil.Naming.Filename
        sceneshotmode = ImageUtil.SceneshotMode.Count
        sceneshotsec = 90
        sceneshotcount = 16
        RaiseEvent Configuration_reset()
    End Sub

    Public Sub save()
        RaiseEvent Configuration_save()
    End Sub


    Public Function Clone() As Object Implements System.ICloneable.Clone
        Dim conf As New Configuration
        conf._detailtext = _detailtext
        conf._columns = _columns
        conf._progressive = _progressive
        conf._quality = _quality
        conf._tileheight = _tileheight
        conf._tilewidth = _tilewidth
        conf._gapheight = _gapheight
        conf._gapwidth = _gapwidth
        conf._labels = _labels
        conf._labelcolor = _labelcolor
        conf._labelfont = _labelfont
        conf._details = _details
        conf._detaillabelcolor = _detaillabelcolor
        conf._detailfont = _detailfont
        conf._color = _color
        conf._imageformat = _imageformat
        conf._imagesizemode = _imagesizemode
        conf._imagepercent = _imagepercent
        conf._savemode = _savemode
        conf._savepath = _savepath
        conf._background = _background
        conf._backgroundimage = _backgroundimage
        conf._use_watermark = _use_watermark
        conf._bordertype = _bordertype
        conf._border_shadow = _border_shadow
        conf._bordersize = _bordersize
        conf._bordercolor = _bordercolor
        conf._watermarktlocation = _watermarktlocation
        conf._watermarktype = _watermarktype
        conf._watermarktext = _watermarktext
        conf._watermarkimage = _watermarkimage
        conf._watermarkfont = _watermarkfont
        conf._watermarkoffsetX = _watermarkoffsetX
        conf._watermarkoffsetY = _watermarkoffsetY
        conf._watermarkcolor = _watermarkcolor
        conf._detailtextlocation = _detailtextlocation
        conf._labeltextlocation = _labeltextlocation
        conf._naming = _naming
        conf._sceneshotmode = _sceneshotmode
        conf._sceneshotcount = _sceneshotcount
        conf._sceneshotsec = _sceneshotsec
        Return conf
    End Function

    Public Sub createIntial()
        reset()
        save()
    End Sub
End Class
