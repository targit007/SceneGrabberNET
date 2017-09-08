Imports System.Drawing.Drawing2D
Imports System.Drawing.Imaging
Imports System.ComponentModel
Imports System.IO

Public Class ImageUtil

    Public Enum SceneshotMode
        <EnumExtendedDescriptionAttribute("Scenes", "Number of scenes overall")> Count = 0
        <EnumExtendedDescriptionAttribute("Seconds", "Make every n-second a scene")> Seconds = 1
    End Enum



    Public Enum Naming
        <EnumExtendedDescriptionAttribute("File")> Filename = 0
        <EnumExtendedDescriptionAttribute("Path+File")> Filepath = 1
    End Enum


	Public Enum Background
		<EnumExtendedDescriptionAttribute("Color")> Color = 0
		<EnumExtendedDescriptionAttribute("Image")> Image = 1
	End Enum

	Public Enum BorderType
		<EnumExtendedDescriptionAttribute("None")> None = 0
		<EnumExtendedDescriptionAttribute("Solid")> Solid = 1
	End Enum


	Public Enum ImageSizeMode
		<EnumExtendedDescriptionAttribute("Custom", "Custom")> Custom = 0
		<EnumExtendedDescriptionAttribute("Source", "Same as source")> Source = 1
		<EnumExtendedDescriptionAttribute("Percent", "Percent from source")> Percent = 2
	End Enum


	Public Enum TextLocation
		<EnumExtendedDescriptionAttribute("Top Left")> TopLeft = 0
		<EnumExtendedDescriptionAttribute("Top Center")> TopCenter = 1
		<EnumExtendedDescriptionAttribute("Top Right")> TopRight = 2
		<EnumExtendedDescriptionAttribute("Middle Left")> MiddleLeft = 3
		<EnumExtendedDescriptionAttribute("Middle Center")> MiddleCenter = 4
		<EnumExtendedDescriptionAttribute("Middle Right")> MiddleRight = 5
		<EnumExtendedDescriptionAttribute("Bottom Left")> BottomLeft = 6
		<EnumExtendedDescriptionAttribute("Bottom Center")> BottomCenter = 7
		<EnumExtendedDescriptionAttribute("Bottom Right")> BottomRight = 8
	End Enum

	Public Enum DetailTextLocation
		<EnumExtendedDescriptionAttribute("Left")> TopLeft = 0
		<EnumExtendedDescriptionAttribute("Center")> TopCenter = 1
		<EnumExtendedDescriptionAttribute("Right")> TopRight = 2
	End Enum


	Public Enum ImageTyp
		<EnumExtendedDescriptionAttribute("JPG")> JPG = 0
		<EnumExtendedDescriptionAttribute("BMP")> BMP = 1
		<EnumExtendedDescriptionAttribute("PNG")> PNG = 2
		<EnumExtendedDescriptionAttribute("TIFF")> TIFF = 3
	End Enum

	Public Enum SaveMode
		<EnumExtendedDescriptionAttribute("Ask", "Ask every time")> ASK = 0
		<EnumExtendedDescriptionAttribute("Source", "Same as source")> SOURCE_PATH = 1
		<EnumExtendedDescriptionAttribute("Folder", "Single folder")> SINGLE_PATH = 2
	End Enum

	Public Enum WatermarkType
		<EnumExtendedDescriptionAttribute("Text")> TEXT = 0
		<EnumExtendedDescriptionAttribute("Image")> IMAGE = 1
	End Enum

	Public Enum WatermarkLocation
		<EnumExtendedDescriptionAttribute("Top Left")> TopLeft = 0
		<EnumExtendedDescriptionAttribute("Top Center")> TopCenter = 1
		<EnumExtendedDescriptionAttribute("Top Right")> TopRight = 2
		<EnumExtendedDescriptionAttribute("Middle Left")> MiddleLeft = 3
		<EnumExtendedDescriptionAttribute("Middle Center")> MiddleCenter = 4
		<EnumExtendedDescriptionAttribute("Middle Right")> MiddleRight = 5
		<EnumExtendedDescriptionAttribute("Bottom Left")> BottomLeft = 6
		<EnumExtendedDescriptionAttribute("Bottom Center")> BottomCenter = 7
		<EnumExtendedDescriptionAttribute("Bottom Right")> BottomRight = 8
	End Enum


	Public Const FILEOPEN_IMAGE_PATTERN As String = "Images|*.jpg;*.jpeg;*.tiff;*.png;*.bmp|All Files|*.*"

	Private Shared shadowDownRight As Image = New Bitmap(My.Resources.tshadowdownright)
	Private Shared shadowDownLeft As Image = New Bitmap(My.Resources.tshadowdownleft)
	Private Shared shadowDown As Image = New Bitmap(My.Resources.tshadowdown)
	Private Shared shadowRight As Image = New Bitmap(My.Resources.tshadowright)
	Private Shared shadowTopRight As Image = New Bitmap(My.Resources.tshadowtopright)

	Private Const SHADOW_SIZE As Integer = 5
	Private Const EXTENSION_MP4 As String = ".mp4"
	Private Const EXTENSION_MOV As String = ".mov"

	'Liefert den benötigiten Encoder
	Private Shared Function GetEncoder(ByVal format As ImageFormat) As ImageCodecInfo

		Dim codecs As ImageCodecInfo() = ImageCodecInfo.GetImageDecoders()

		Dim codec As ImageCodecInfo
		For Each codec In codecs
			If codec.FormatID = format.Guid Then
				Return codec
			End If
		Next codec
		Return Nothing

	End Function

	'Bild resizen mit Max X oder Y auf 100

	Public Shared Function resizeMax100(ByVal img As Image) As Image
		Dim aspectRatio As Double = 0
		Dim x As Integer = 0
		Dim y As Integer = 0

		If (img.Width > img.Height) Then
			aspectRatio = img.Width / img.Height
			x = 120
			y = x / aspectRatio
		Else
			aspectRatio = img.Height / img.Width
			y = 120
			x = y / aspectRatio
		End If
		Return resize(img, x, y, True)
	End Function

	'Bild resizen
	Public Shared Function resize(ByVal img As Image, ByVal x As Integer, ByVal y As Integer, ByVal highQuality As Boolean) As Image
		Dim bm_dest As New Bitmap(x, y)
		Dim gr As Graphics = Graphics.FromImage(bm_dest)
		gr = setGraphicsMode(gr, highQuality)
		gr.DrawImage(img, New Rectangle(0, 0, x, y))
		gr.Dispose()
		Return bm_dest
	End Function

	'Generiert den eigentlichen zusammengestellten Sceneshot

    Public Shared Function generateSceneshotImage(ByVal sceneShotData As SceneshotsHolder, ByVal conf As Configuration, ByVal highQuality As Boolean) As Image       
        Dim conf_offset_X As Integer = conf.gapwidth
        Dim conf_offset_Y As Integer = conf.gapheight
        Dim conf_coloums As Integer = conf.columns
        Dim conf_tile_X As Integer = conf.tilewidth
        Dim conf_tile_Y As Integer = conf.tileheight

        Dim conf_labels As Boolean = conf.labels
        Dim conf_label_fnt_color As Color = conf.labelcolor
        Dim conf_label_fnt As Font = conf.labelfont
        Dim conf_label_location As Integer = conf.labeltextlocation

        Dim conf_details As Boolean = conf.details

        Dim conf_text As String = conf.detailtext

        Dim conf_color As Color = conf.color

        Dim conf_imagesizemode As Integer = conf.imagesizemode
        Dim conf_imagepercent As Integer = conf.imagepercent

        Dim conf_infotext_location As TextLocation = conf.detailtextlocation

        Dim conf_background As Integer = conf.background
        Dim conf_backgroundimage As String = conf.backgroundimage

        Dim conf_border_shadow As Boolean = conf.border_shadow
        Dim conf_bordertype As Integer = conf.bordertype
        Dim conf_bordercolor As Color = conf.bordercolor
        Dim conf_bordersize As Integer = conf.bordersize


        Dim conf_use_watermark As Boolean = conf.use_watermark
        Dim conf_watermark_type As Integer = conf.watermarktype
        Dim conf_watermark_location As Integer = conf.watermarktlocation
        Dim conf_watermark_text As String = conf.watermarktext
        Dim conf_watermark_image As String = conf.watermarkimage
        Dim conf_watermark_font As Font = conf.watermarkfont
        Dim conf_watermark_offset_X As Integer = conf.watermarkoffsetX
        Dim conf_watermark_offset_Y As Integer = conf.watermarkoffsetY
        Dim conf_watermark_color As Color = conf.watermarkcolor

        Dim tiles As Integer = sceneShotData.scenes.Count
        Dim tile_X As Integer = 0
        Dim tile_Y As Integer = 0

        Dim text = sceneShotData.movieinfo.evaluatePattern(conf_text)

        'Das ReferenzImage
        Dim refImage As Image = sceneShotData.scenes(0).image

        Dim info_offset_y As Integer = 0
        Dim info_width As Integer = 0
        Dim info_height As Integer = 0

        Dim sformat As New StringFormat

        'Berrechnen der Größe des Info-Feldes
        If (conf_details) Then
            Dim gtmp As Graphics = Graphics.FromImage(refImage)
            Dim size As SizeF = gtmp.MeasureString(conf.maxtabstob, conf.detailfont)
            sformat.SetTabStops(0, New Single() {size.Width})
            info_width = CInt(gtmp.MeasureString(text, conf.detailfont, Integer.MaxValue, sformat).Width)
            info_height = CInt(gtmp.MeasureString(text, conf.detailfont, Integer.MaxValue, sformat).Height)
            info_offset_y = conf_offset_Y + info_height
            gtmp.Dispose()
        End If

        'Bestimmen der Größe der einzelen Scenes anhand ReferenzImage
        'alternativ percent
        Select Case conf_imagesizemode
            Case ImageUtil.ImageSizeMode.Custom
                Dim ratio As Double = 0.0
                If (refImage.Width > refImage.Height) Then
                    ratio = refImage.Width / refImage.Height
                    tile_X = conf_tile_X
                    tile_Y = tile_X / ratio
                Else
                    ratio = refImage.Height / refImage.Width
                    tile_Y = conf_tile_Y
                    tile_X = tile_Y / ratio
                End If
            Case ImageUtil.ImageSizeMode.Percent
                tile_X = refImage.Width / 100 * conf_imagepercent
                tile_Y = refImage.Height / 100 * conf_imagepercent
            Case ImageUtil.ImageSizeMode.Source
                tile_X = refImage.Width
                tile_Y = refImage.Height
        End Select

        'Berechnung der Zeilen und Spalten
        'nicht lachen
        Dim coloums As Integer = IIf(conf_coloums > tiles, tiles, conf_coloums)
        Dim rows As Integer = Fix(tiles / coloums)
        If (tiles Mod coloums <> 0) Then
            rows += 1
        End If

        Dim width As Integer = (coloums * tile_X) + ((coloums + 1) * conf_offset_X)
        Dim height As Integer = info_offset_y + (rows * tile_Y) + ((rows + 1) * conf_offset_Y)

        'Erstellen der BasisBitmap
        Dim bmp As Bitmap = Nothing
        If conf_background = ImageUtil.Background.Image AndAlso Util.fileExists(conf_backgroundimage) Then
            bmp = Bitmap.FromFile(conf_backgroundimage)
            bmp = ImageUtil.resize(bmp, width, height, highQuality)
        Else
            bmp = New Bitmap(width, height)
        End If

        Dim g As Graphics = Graphics.FromImage(bmp)
        g = setGraphicsMode(g, highQuality)

        If conf_background = ImageUtil.Background.Color Then
            g.Clear(conf_color)
        End If

        'Draw Info Text
        If (conf_details) Then
            Dim pos_x As Integer
            Dim pos_y As Integer
            pos_y = conf_offset_Y
            Select Case conf_infotext_location
                Case TextLocation.TopLeft
                    pos_x = conf_offset_X
                Case TextLocation.TopCenter
                    pos_x = CInt(width / 2 - info_width / 2)
                Case TextLocation.TopRight
                    pos_x = width - info_width - conf_offset_X
            End Select
            g.DrawString(text, conf.detailfont, New SolidBrush(conf.detaillabelcolor), pos_x, pos_y, sformat)
        End If

        'draw shots
        Dim cnt As Integer = 0
        For i As Integer = 1 To rows

            For j As Integer = 1 To coloums
                If (cnt < sceneShotData.scenes.Count) Then
                    Dim img As Image = sceneShotData.scenes.Item(cnt).image
                    'Muss abgezogen werden wenn conf-border
                    If (conf_border_shadow) Then
                        img = ImageUtil.resize(img, tile_X - SHADOW_SIZE, tile_Y - SHADOW_SIZE, highQuality)
                    Else
                        img = ImageUtil.resize(img, tile_X, tile_Y, highQuality)
                    End If
                    'Bordern
                    If (conf_bordertype = ImageUtil.BorderType.Solid And conf_bordersize > 0) Then
                        img = ImageUtil.border(img, conf_bordersize, conf_bordercolor, highQuality)
                    End If

                    'Labeln
                    If (conf_labels) Then
                        img = labels(img, sceneShotData.scenes(cnt).label, conf_label_fnt, conf_label_fnt_color, conf_label_location, highQuality)
                    End If
                    'drop shadows
                    If (conf_border_shadow) Then
                        img = shadow(img, conf_color, conf_background, highQuality)
                    End If
                    g.DrawImage(img, New Rectangle((j * conf_offset_X) + ((j - 1) * tile_X), info_offset_y + (i * conf_offset_Y) + ((i - 1) * tile_Y), tile_X, tile_Y))
                End If
                cnt += 1
            Next
        Next

        'Watermarkern
        If (conf_use_watermark) Then
            If conf_watermark_type = ImageUtil.WatermarkType.IMAGE AndAlso Util.fileExists(conf_watermark_image) Then
                watermark(g, conf_watermark_type, conf_watermark_location, width, height, conf_watermark_offset_X, conf_watermark_offset_Y, conf_watermark_text, conf_watermark_font, conf_watermark_color, conf_watermark_image)
            Else
                watermark(g, conf_watermark_type, conf_watermark_location, width, height, conf_watermark_offset_X, conf_watermark_offset_Y, conf_watermark_text, conf_watermark_font, conf_watermark_color, conf_watermark_image)
            End If
        End If

        g.Dispose()
        g = Nothing

        Return bmp
    End Function

	'Labelt ein Image

	Private Shared Function labels(ByVal img As Image, ByVal label As String, ByVal font As Font, ByVal col As Color, ByVal location As TextLocation, ByVal highQuality As Boolean) As Image
		'Bildbereich wo der Text gezeichnet werden soll
		Dim g As Graphics = Graphics.FromImage(img)
		g = setGraphicsMode(g, highQuality)
		drawString(g, img.Width, img.Height, font.Size / 2, font.Size / 2, location, font, col, label)
		g.Dispose()
		Return img
	End Function


	Private Shared Sub drawString(ByRef g As Graphics, ByVal width As Long, ByVal height As Long, ByVal offset_x As Long, _
									ByVal offset_y As Long, ByVal location As TextLocation, ByVal font As Font, ByVal color As Color, ByVal text As String)

		Dim r As Rectangle = New Rectangle(offset_x, offset_y, width - 2 * offset_x, height - 2 * offset_y)
		Dim sFormat As StringFormat = New StringFormat(StringFormat.GenericTypographic)
		sFormat.FormatFlags = sFormat.FormatFlags Or StringFormatFlags.NoClip Or StringFormatFlags.NoWrap

		Select Case location
			Case TextLocation.TopLeft
				sFormat.Alignment = StringAlignment.Near
				sFormat.LineAlignment = StringAlignment.Near
			Case TextLocation.TopRight
				sFormat.Alignment = StringAlignment.Far
				sFormat.LineAlignment = StringAlignment.Near
			Case TextLocation.TopCenter
				sFormat.Alignment = StringAlignment.Center
				sFormat.LineAlignment = StringAlignment.Near
			Case TextLocation.MiddleLeft
				sFormat.Alignment = StringAlignment.Near
				sFormat.LineAlignment = StringAlignment.Center
			Case TextLocation.MiddleCenter
				sFormat.Alignment = StringAlignment.Center
				sFormat.LineAlignment = StringAlignment.Center
			Case TextLocation.MiddleRight
				sFormat.Alignment = StringAlignment.Far
				sFormat.LineAlignment = StringAlignment.Center
			Case TextLocation.BottomLeft
				sFormat.Alignment = StringAlignment.Near
				sFormat.LineAlignment = StringAlignment.Far
			Case TextLocation.BottomCenter
				sFormat.Alignment = StringAlignment.Center
				sFormat.LineAlignment = StringAlignment.Far
			Case TextLocation.BottomRight
				sFormat.Alignment = StringAlignment.Far
				sFormat.LineAlignment = StringAlignment.Far
		End Select

		g.DrawString(text, font, New SolidBrush(color), r, sFormat)

	End Sub

	Private Shared Sub drawWatermarkString(ByRef g As Graphics, ByVal width As Long, ByVal height As Long, ByVal offset_x As Long, _
			ByVal offset_y As Long, ByVal location As WatermarkLocation, ByVal font As Font, ByVal color As Color, ByVal text As String)

		Dim r1 As Rectangle = New Rectangle(offset_x + 1, offset_y + 1, width - 2 * offset_x, height - 2 * offset_y)
		Dim r2 As Rectangle = New Rectangle(offset_x, offset_y, width - 2 * offset_x, height - 2 * offset_y)
		Dim sFormat As StringFormat = New StringFormat(StringFormat.GenericTypographic)
		sFormat.FormatFlags = sFormat.FormatFlags Or StringFormatFlags.NoClip Or StringFormatFlags.NoWrap

		Select Case location
			Case TextLocation.TopLeft
				sFormat.Alignment = StringAlignment.Near
				sFormat.LineAlignment = StringAlignment.Near
			Case TextLocation.TopRight
				sFormat.Alignment = StringAlignment.Far
				sFormat.LineAlignment = StringAlignment.Near
			Case TextLocation.TopCenter
				sFormat.Alignment = StringAlignment.Center
				sFormat.LineAlignment = StringAlignment.Near
			Case TextLocation.MiddleLeft
				sFormat.Alignment = StringAlignment.Near
				sFormat.LineAlignment = StringAlignment.Center
			Case TextLocation.MiddleCenter
				sFormat.Alignment = StringAlignment.Center
				sFormat.LineAlignment = StringAlignment.Center
			Case TextLocation.MiddleRight
				sFormat.Alignment = StringAlignment.Far
				sFormat.LineAlignment = StringAlignment.Center
			Case TextLocation.BottomLeft
				sFormat.Alignment = StringAlignment.Near
				sFormat.LineAlignment = StringAlignment.Far
			Case TextLocation.BottomCenter
				sFormat.Alignment = StringAlignment.Center
				sFormat.LineAlignment = StringAlignment.Far
			Case TextLocation.BottomRight
				sFormat.Alignment = StringAlignment.Far
				sFormat.LineAlignment = StringAlignment.Far
		End Select


		'Dim semiTransBrush2 As SolidBrush = New SolidBrush(Color.FromArgb(153, 0, 0, 0))
		Dim semiTransBrush2 As SolidBrush = New SolidBrush(color.FromArgb(153, color.R, color.G, color.B))

		g.DrawString(text, font, semiTransBrush2, r1, sFormat)
		'Dim semiTransBrush As SolidBrush = New SolidBrush(Color.FromArgb(153, 255, 255, 255))
		Dim semiTransBrush As SolidBrush = New SolidBrush(color.FromArgb(153, 255, 255, 255))
		g.DrawString(text, font, semiTransBrush, r2, sFormat)

	End Sub


	Private Shared Sub drawWatermarkImage(ByRef g As Graphics, ByVal width As Long, ByVal height As Long, ByVal x As Long, ByVal y As Long, ByVal location As WatermarkLocation, ByVal image As String)
		If Util.fileExists(image) Then
			Dim img As Image = Bitmap.FromFile(image)
			Dim gWatermark As Graphics = Graphics.FromImage(img)
			Dim imgAttr As ImageAttributes = New ImageAttributes
			Dim colorMap As ColorMap = New ColorMap
			colorMap.OldColor = Color.FromArgb(255, 0, 255, 0)
			colorMap.NewColor = Color.FromArgb(0, 0, 0, 0)
			Dim remapTable() As ColorMap = {colorMap}
			imgAttr.SetRemapTable(remapTable, ColorAdjustType.Bitmap)
			Dim colorMatrixElements As Single()() = {New Single() {1.0F, 0.0F, 0.0F, 0.0F, 0.0F}, _
			   New Single() {0.0F, 1.0F, 0.0F, 0.0F, 0.0F}, _
			   New Single() {0.0F, 0.0F, 1.0F, 0.0F, 0.0F}, _
			   New Single() {0.0F, 0.0F, 0.0F, 0.3F, 0.0F}, _
			   New Single() {0.0F, 0.0F, 0.0F, 0.0F, 1.0F}}
			Dim wmColorMatrix As ColorMatrix = New ColorMatrix(colorMatrixElements)
			imgAttr.SetColorMatrix(wmColorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap)

			Dim _x As Integer
			Dim _y As Integer

			Select Case location
				Case WatermarkLocation.TopLeft
					_x = x
					_y = y
				Case WatermarkLocation.TopCenter
					_x = width / 2 - img.Width / 2
					_y = y
				Case WatermarkLocation.TopRight
					_x = width - img.Width - x
					_y = y
				Case WatermarkLocation.MiddleLeft
					_x = x
					_y = height / 2 - img.Height / 2
				Case WatermarkLocation.MiddleCenter
					_x = width / 2 - img.Width / 2
					_y = height / 2 - img.Height / 2
				Case WatermarkLocation.MiddleRight
					_x = width - img.Width - x
					_y = height / 2 - img.Height / 2
				Case WatermarkLocation.BottomLeft
					_x = x
					_y = height - img.Height - y
				Case WatermarkLocation.BottomCenter
					_x = width / 2 - img.Width / 2
					_y = height - img.Height - y
				Case WatermarkLocation.BottomRight
					_x = width - img.Width - x
					_y = height - img.Height - y
			End Select

			g.DrawImage(img, _
			  New Rectangle(_x, _y, img.Width, img.Height), _
			  0, _
			  0, _
			  img.Width, _
			  img.Height, _
			  GraphicsUnit.Pixel, _
			  imgAttr)

		End If
	End Sub




	Private Shared Function border(ByVal img As Image, ByVal size As Integer, ByVal color As Color, ByVal highQuality As Boolean) As Image
		Dim g As Graphics = Graphics.FromImage(img)
		g = setGraphicsMode(g, highQuality)
		' weißen Rahmen zeichnen    
		Dim r As Rectangle
		'If size Mod 2 > 0 Then
		r = New Rectangle(0, 0, img.Width - 1, img.Height - 1)
		'Else
		'	r = New Rectangle(1, 1, img.Width - 2, img.Height - 2)
		'End If
		g.DrawRectangle(New Pen(color, CDbl(size)), r)
		g.Dispose()
		Return img
	End Function



	Private Shared Sub watermark(ByVal g As Graphics, ByVal type As ImageUtil.WatermarkType, ByVal location As ImageUtil.WatermarkLocation, ByVal width As Integer, ByVal height As Integer, ByVal x As Integer, ByVal y As Integer, ByVal text As String, ByVal font As Font, ByVal color As Color, ByVal image As String)
		'Text
		If type = WatermarkType.TEXT Then
			drawWatermarkString(g, width, height, x, y, location, font, color, text)
		Else
			drawWatermarkImage(g, width, height, x, y, location, image)
		End If

	End Sub



	' Setzt den Rahmen eines Bildes (inkl. Schatten)

	Private Shared Function shadow(ByVal img As Image, ByVal col As Color, ByVal backgroundimage As Boolean, ByVal highQuality As Boolean) As Image

		Dim shadowMargin As Integer = 0

		Dim bmp As Bitmap = New Bitmap(img.Width + SHADOW_SIZE, img.Height + SHADOW_SIZE)
		Dim g As Graphics = Graphics.FromImage(bmp)
		g = setGraphicsMode(g, highQuality)

		If Not backgroundimage Then
			g.Clear(col)
		End If
		g.DrawImage(img, 0, 0, img.Width, img.Height)
		g.Dispose()

		g = Graphics.FromImage(bmp)
		g = setGraphicsMode(g, highQuality)

		Dim shadowRightBrush As TextureBrush = New TextureBrush(shadowRight, WrapMode.Tile)
		Dim shadowDownBrush As TextureBrush = New TextureBrush(shadowDown, WrapMode.Tile)

		shadowDownBrush.TranslateTransform(0, img.Height)
		shadowRightBrush.TranslateTransform(img.Width, 0)

		Dim shadowDownRectangle As Rectangle = New Rectangle( _
		  SHADOW_SIZE + shadowMargin, _
		  img.Height, _
		  img.Width - (SHADOW_SIZE * 1 + shadowMargin), SHADOW_SIZE)

		Dim shadowRightRectangle As Rectangle = New Rectangle( _
		  img.Width, _
		  SHADOW_SIZE - shadowMargin, SHADOW_SIZE, _
		  img.Height - (SHADOW_SIZE * 1 + shadowMargin))

		g.FillRectangle(shadowDownBrush, shadowDownRectangle)
		g.FillRectangle(shadowRightBrush, shadowRightRectangle)

		g.DrawImage(shadowTopRight, New Rectangle(img.Width, shadowMargin, SHADOW_SIZE, SHADOW_SIZE))
		g.DrawImage(shadowDownRight, New Rectangle(img.Width, img.Height, SHADOW_SIZE, SHADOW_SIZE))
		g.DrawImage(shadowDownLeft, New Rectangle(shadowMargin, img.Height, SHADOW_SIZE, SHADOW_SIZE))

		shadowDownBrush.Dispose()
		shadowRightBrush.Dispose()
		g.Dispose()

		Return bmp
	End Function

	Public Shared Function saveImages(ByVal sceneshots As List(Of Sceneshot), ByVal config As Configuration) As Boolean
		Dim rc As Boolean = False
		Dim filePath As String = Nothing
		filePath = Util.FolderBrowserDialog("Save Images", filePath)
		If (Not filePath Is Nothing) Then
			Dim jgpEncoder As ImageCodecInfo = ImageUtil.GetEncoder(getImageFormatFromEnumImageFormat(config.imageFormat))
			Dim params As EncoderParameters = New EncoderParameters(2)
			params.Param(0) = New EncoderParameter(Encoder.Quality, config.quality)
			If config.progressive Then
				params.Param(1) = New EncoderParameter(Encoder.RenderMethod, EncoderValue.RenderProgressive.ToString())
			Else
				params.Param(1) = New EncoderParameter(Encoder.RenderMethod, EncoderValue.RenderNonProgressive.ToString())
			End If
			Application.DoEvents()
			For Each s In sceneshots
				Dim filename As String = s.label.Replace(":", "_") + getExtensionFromImageFormat(config.imageFormat)
				filename = filePath + Path.DirectorySeparatorChar + filename
				s.image.Save(filename, jgpEncoder, params)
				Application.DoEvents()
			Next
			rc = True
		End If
		Return rc
	End Function

	'Speichert ein einzelnes Bild
	Public Shared Function saveSingleImage(ByVal s As Sceneshot, ByVal config As Configuration) As Boolean
		Dim rc As Boolean = False
		Dim filename As String = Nothing

		Dim dlg As New SaveFileDialog
		dlg.Title = "Save Image"
		dlg.Filter = FILEOPEN_IMAGE_PATTERN
		Try
			dlg.FileName = s.label.Replace(":", "_") + getExtensionFromImageFormat(config.imageFormat)
		Catch ex As Exception
			Console.WriteLine(ex.Message)
		End Try
		If dlg.ShowDialog() = DialogResult.OK And Not String.IsNullOrEmpty(dlg.FileName) Then
			filename = dlg.FileName
		End If

		If Not filename Is Nothing Then
			Dim jgpEncoder As ImageCodecInfo = ImageUtil.GetEncoder(getImageFormatFromEnumImageFormat(config.imageFormat))
			Dim params As EncoderParameters = New EncoderParameters(2)
			params.Param(0) = New EncoderParameter(Encoder.Quality, config.quality)
			If config.progressive Then
				params.Param(1) = New EncoderParameter(Encoder.RenderMethod, EncoderValue.RenderProgressive.ToString())
			Else
				params.Param(1) = New EncoderParameter(Encoder.RenderMethod, EncoderValue.RenderNonProgressive.ToString())
			End If
			Application.DoEvents()
			s.image.Save(filename, jgpEncoder, params)
			Application.DoEvents()
			rc = True
		End If
		Return rc
	End Function


	Public Shared Function saveImage(ByVal sceneData As SceneshotsHolder) As Boolean
		Return saveImage(sceneData, False)
	End Function


	'Generiert den Filename für das finale Image
	Private Shared Function generateFilePathForFinalSceneshots(ByVal config As Configuration, ByVal movieinfo As MovieInfo) As String
		Dim filePath As String = Nothing
		Dim fileName As String = Nothing

		Select Case config.naming
			Case ImageUtil.Naming.Filename
				fileName = movieinfo.getFileName
			Case ImageUtil.Naming.Filepath
				fileName = movieinfo.getCompleteName.Replace(Path.DirectorySeparatorChar, "-").Replace(Path.VolumeSeparatorChar, "")
		End Select

		Select Case config.savemode
			Case SaveMode.SINGLE_PATH
				filePath = config.savepath + Path.DirectorySeparatorChar + fileName + getExtensionFromImageFormat(config.imageFormat)
			Case SaveMode.SOURCE_PATH
				filePath = New FileInfo(movieinfo.getCompleteName).DirectoryName + Path.DirectorySeparatorChar + fileName + getExtensionFromImageFormat(config.imageFormat)

		End Select

		Return filePath

	End Function






	'Speichert den Sceneshot
	Public Shared Function saveImage(ByVal sceneData As SceneshotsHolder, ByVal batch As Boolean) As Boolean
		Dim rc As Boolean = False
		Dim filename As String = Nothing
		Dim showDialog As Boolean = False

        Dim config As Configuration = Configuration.getInstance
		Dim savedMode As Integer = config.savemode

		'Batch hat kein ASK
		If batch And savedMode = SaveMode.ASK Then
			savedMode = SaveMode.SOURCE_PATH
		End If

		'Dateinamen genereieren
		filename = generateFilePathForFinalSceneshots(config, sceneData.movieinfo)

		If String.IsNullOrEmpty(filename) Then
			showDialog = True
		End If

		If showDialog Then
			Dim dlg As New SaveFileDialog
			dlg.Title = "Save Image"
			dlg.Filter = FILEOPEN_IMAGE_PATTERN
			Try
				'Set Dir
				If (My.Settings.use_lastsavedpath) Then
					dlg.InitialDirectory = My.Settings.lastsavedpath
				Else
					dlg.InitialDirectory = System.IO.Path.GetDirectoryName(sceneData.movieinfo.getCompleteName())
				End If

				If (My.Settings.gen_filenames) Then
					'Set File
					dlg.FileName = sceneData.movieinfo.getFileName + getExtensionFromImageFormat(config.imageFormat)
				End If

			Catch ex As Exception
				Console.WriteLine(ex.Message)
			End Try
			If dlg.ShowDialog() = DialogResult.OK And Not String.IsNullOrEmpty(dlg.FileName) Then
				filename = dlg.FileName
			End If
		End If

		If Not String.IsNullOrEmpty(filename) Then
			Dim imageEncoder As ImageCodecInfo = ImageUtil.GetEncoder(getImageFormatFromEnumImageFormat(config.imageFormat))
			Dim params As EncoderParameters = New EncoderParameters(2)
			params.Param(0) = New EncoderParameter(Encoder.Quality, config.quality)
			If config.progressive Then
				params.Param(1) = New EncoderParameter(Encoder.RenderMethod, EncoderValue.RenderProgressive.ToString())
			Else
				params.Param(1) = New EncoderParameter(Encoder.RenderMethod, EncoderValue.RenderNonProgressive.ToString())
			End If
			Application.DoEvents()
			sceneData.sceneshot.Save(filename, imageEncoder, params)
			My.Settings.use_count = My.Settings.use_count + 1
			My.Settings.Save()
			Application.DoEvents()
			rc = True
		End If
		Return rc
	End Function


	Private Shared Function getExtensionFromImageFormat(ByVal format As ImageTyp) As String
		Select Case format
			Case ImageTyp.JPG
				Return ".jpg"
			Case ImageTyp.BMP
				Return ".bmp"
			Case ImageTyp.PNG
				Return ".png"
			Case ImageTyp.TIFF
				Return ".tiff"
			Case Else
				Return Nothing
		End Select
	End Function

	Private Shared Function getImageFormatFromEnumImageFormat(ByVal format As ImageTyp) As System.Drawing.Imaging.ImageFormat
		Select Case format
			Case ImageTyp.JPG
				Return System.Drawing.Imaging.ImageFormat.Jpeg
			Case ImageTyp.BMP
				Return System.Drawing.Imaging.ImageFormat.Bmp
			Case ImageTyp.PNG
				Return System.Drawing.Imaging.ImageFormat.Png
			Case ImageTyp.TIFF
				Return System.Drawing.Imaging.ImageFormat.Tiff
			Case Else
				Return Nothing
		End Select
	End Function

	Public Shared Function generateSceneShotFromFile(ByVal file As String, ByVal config As Configuration, ByVal label As ToolStripStatusLabel) As SceneshotsHolder

		Dim oMedia As DexterLib.MediaDet = New DexterLib.MediaDet()
		Dim oMovieInfo As MovieInfo = New MovieInfo(file)
		oMedia.Filename = file
        Dim labelText As String = label.Text
        Dim anzClips As Integer = 0
        Dim sceneList As New BindingList(Of Sceneshot)
        Dim position As Double = 0

        If (config.sceneshotmode = ImageUtil.SceneshotMode.Count) Then
            anzClips = config.sceneshotcount
            Dim positionInc As Double = oMedia.StreamLength / (anzClips + 1)
            For i As Integer = 1 To anzClips
                label.Text = labelText + " - (" + CStr(i) + "/" + CStr(anzClips) + ")"
                Application.DoEvents()
                position = i * positionInc
                Dim s As Sceneshot = createSceneshot(oMedia, position, oMovieInfo.getWidth, oMovieInfo.getHeight)
                If Not s Is Nothing Then
                    sceneList.Add(s)
                End If
            Next
        Else
            anzClips = Util.getScenesCountBySeconds(oMedia.StreamLength, config.sceneshotsec)
            Dim i As Integer = 0
            position += config.sceneshotsec
            While (position <= oMedia.StreamLength)
                i += 1
                label.Text = labelText + " - (" + CStr(i) + "/" + CStr(anzClips) + ")"
                Application.DoEvents()
                Dim s As Sceneshot = createSceneshot(oMedia, position, oMovieInfo.getWidth, oMovieInfo.getHeight)
                If Not s Is Nothing Then
                    sceneList.Add(s)
                End If
                position += config.sceneshotsec
            End While
        End If

        Dim dataholder As SceneshotsHolder = New SceneshotsHolder
        'dataholder.Configuration = config
        dataholder.movieinfo = oMovieInfo
        dataholder.assignInitalSceneList(sceneList)
        dataholder.sceneshot = generateSceneshotImage(dataholder, Configuration.getInstance, True)
        label.Text = labelText
        Application.DoEvents()
        Return dataholder
    End Function

	'Erstellt ein Screenshot von einem Movie ab Postion und mit Dimensionen
	Public Shared Function createSceneshot(ByVal media As DexterLib.MediaDet, ByVal position As Double, ByVal width As Integer, ByVal height As Integer) As Sceneshot
		Dim x As Integer = width
		Dim y As Integer = height
		Dim bmp As Bitmap = Nothing

        ' test internal engine
        Try
            If (bmp Is Nothing AndAlso My.Settings.internal_use) Then
                bmp = Imaging.Imaging.generateSceneshot(Imaging.Imaging.CaptureType.internal, Nothing, media, position, x, y)
            End If
        Catch ex As Exception
            bmp = Nothing
        End Try

        'test mplayer engine
        Try
            If (bmp Is Nothing AndAlso My.Settings.mplayer_use) Then
                bmp = Imaging.Imaging.generateSceneshot(Imaging.Imaging.CaptureType.mplayer, My.Settings.mplayer_path, media, position, x, y)
            End If
        Catch ex As Exception
            bmp = Nothing
        End Try

        'test ffmpeg engine
        Try
            If (bmp Is Nothing AndAlso My.Settings.ffmpeg_use) Then
                bmp = Imaging.Imaging.generateSceneshot(Imaging.Imaging.CaptureType.ffmpeg, My.Settings.ffmpeg_path, media, position, x, y)
            End If
        Catch ex As Exception
            bmp = Nothing
        End Try

        If bmp Is Nothing Then
            Dim msg As String = "Image is null. cpature failed!" + vbCrLf + vbCrLf + "Try a different capture engine." + vbCrLf + vbCrLf + "Download ffmpeg/mplayer and " + vbCrLf + vbCrLf + "Select this under menu-> capture engine !"
            MsgBox(msg, MsgBoxStyle.Critical, Util.APP_TITLE)
        End If

        Dim s As Sceneshot = Nothing
        If (Not bmp Is Nothing) Then
            s = New Sceneshot(bmp, position)
        End If
        Return s
	End Function


	Private Shared Function setGraphicsMode(ByVal g As Graphics, ByVal highQuality As Boolean)
		If highQuality Then
			g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality
			g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic
			g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
		Else
			g.SmoothingMode = SmoothingMode.AntiAlias
		End If
		Return g
	End Function

End Class
