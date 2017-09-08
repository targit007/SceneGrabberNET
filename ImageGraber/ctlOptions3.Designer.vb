<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CtlOptions3
	Inherits System.Windows.Forms.UserControl

	'UserControl overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> _
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.label_labelbordersize = New System.Windows.Forms.Label
        Me.num_labelbordersize = New System.Windows.Forms.NumericUpDown
        Me.GroupBox17 = New System.Windows.Forms.GroupBox
        Me.txt_watermark_offX = New System.Windows.Forms.TextBox
        Me.txt_watermark_offY = New System.Windows.Forms.TextBox
        Me.lbl_watermark_y = New System.Windows.Forms.Label
        Me.lbl_watermark_x = New System.Windows.Forms.Label
        Me.chk_watermark = New System.Windows.Forms.CheckBox
        Me.Label32 = New System.Windows.Forms.Label
        Me.chk_labelbordershadow = New System.Windows.Forms.CheckBox
        Me.GroupBox14 = New System.Windows.Forms.GroupBox
        Me.label_imagepercent = New System.Windows.Forms.Label
        Me.num_imagepercent = New System.Windows.Forms.NumericUpDown
        Me.Label35 = New System.Windows.Forms.Label
        Me.chk_progressive = New System.Windows.Forms.CheckBox
        Me.txt_columns = New System.Windows.Forms.TextBox
        Me.label_tilewidth = New System.Windows.Forms.Label
        Me.txt_gapwidth = New System.Windows.Forms.TextBox
        Me.Label_tileheight = New System.Windows.Forms.Label
        Me.txt_gapheight = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.txt_tilewidth = New System.Windows.Forms.TextBox
        Me.txt_tileheight = New System.Windows.Forms.TextBox
        Me.txt_scenes = New System.Windows.Forms.TextBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.GroupBox15 = New System.Windows.Forms.GroupBox
        Me.GroupBox13 = New System.Windows.Forms.GroupBox
        Me.chk_labeluse = New System.Windows.Forms.CheckBox
        Me.Label31 = New System.Windows.Forms.Label
        Me.llabel_detailinfo = New System.Windows.Forms.LinkLabel
        Me.txt_detailtext = New System.Windows.Forms.TextBox
        Me.GroupBox12 = New System.Windows.Forms.GroupBox
        Me.cko_detailtext = New System.Windows.Forms.CheckBox
        Me.GroupBox16 = New System.Windows.Forms.GroupBox
        Me.num_imagequality = New System.Windows.Forms.NumericUpDown
        Me.GroupBox18 = New System.Windows.Forms.GroupBox
        Me.label_num_imagequality = New System.Windows.Forms.Label
        Me.Label37 = New System.Windows.Forms.Label
        Me.grp_batch = New System.Windows.Forms.GroupBox
        Me.ll_watermarkcolor = New SceneGrabberNET.ctlColorLinkLabel
        Me.ll_watermark_type = New SceneGrabberNET.ctlEnumBrowseLabel
        Me.ll_watermark_location = New SceneGrabberNET.ctlAlignLinkLabel
        Me.ll_watermarkfont = New SceneGrabberNET.ctlFontLinkLabel
        Me.ll_watermarktext = New SceneGrabberNET.ctlTextboxLink
        Me.ll_tilesize = New SceneGrabberNET.ctlEnumLinkLabel
        Me.ll_labelbordercolor = New SceneGrabberNET.ctlColorLinkLabel
        Me.ll_labelbordertype = New SceneGrabberNET.ctlEnumLinkLabel
        Me.ll_labellocation = New SceneGrabberNET.ctlAlignLinkLabel
        Me.ll_labelcolor = New SceneGrabberNET.ctlColorLinkLabel
        Me.ll_labelfont = New SceneGrabberNET.ctlFontLinkLabel
        Me.ll_detailcolor = New SceneGrabberNET.ctlColorLinkLabel
        Me.ll_detailfont = New SceneGrabberNET.ctlFontLinkLabel
        Me.ll_detaillocation = New SceneGrabberNET.ctlAlignLinkLabel
        Me.ll_backgroundtype = New SceneGrabberNET.ctlEnumBrowseLabel
        Me.ll_backgroundcolor = New SceneGrabberNET.ctlColorLinkLabel
        Me.ll_naming = New SceneGrabberNET.ctlEnumLinkLabel
        Me.ll_imagesavemode = New SceneGrabberNET.ctlEnumBrowseLabel
        Me.ll_imagetyp = New SceneGrabberNET.ctlEnumLinkLabel
        Me.ll_sceneshotmode = New SceneGrabberNET.ctlEnumLabelOnly
        CType(Me.num_labelbordersize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox17.SuspendLayout()
        Me.GroupBox14.SuspendLayout()
        CType(Me.num_imagepercent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox15.SuspendLayout()
        Me.GroupBox13.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        Me.GroupBox16.SuspendLayout()
        CType(Me.num_imagequality, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox18.SuspendLayout()
        Me.grp_batch.SuspendLayout()
        Me.SuspendLayout()
        '
        'label_labelbordersize
        '
        Me.label_labelbordersize.AutoSize = True
        Me.label_labelbordersize.Location = New System.Drawing.Point(10, 70)
        Me.label_labelbordersize.Name = "label_labelbordersize"
        Me.label_labelbordersize.Size = New System.Drawing.Size(30, 13)
        Me.label_labelbordersize.TabIndex = 50
        Me.label_labelbordersize.Text = "Size:"
        '
        'num_labelbordersize
        '
        Me.num_labelbordersize.Location = New System.Drawing.Point(60, 68)
        Me.num_labelbordersize.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.num_labelbordersize.Name = "num_labelbordersize"
        Me.num_labelbordersize.Size = New System.Drawing.Size(40, 20)
        Me.num_labelbordersize.TabIndex = 49
        Me.num_labelbordersize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.num_labelbordersize.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'GroupBox17
        '
        Me.GroupBox17.Controls.Add(Me.ll_watermarkcolor)
        Me.GroupBox17.Controls.Add(Me.ll_watermark_type)
        Me.GroupBox17.Controls.Add(Me.ll_watermark_location)
        Me.GroupBox17.Controls.Add(Me.txt_watermark_offX)
        Me.GroupBox17.Controls.Add(Me.txt_watermark_offY)
        Me.GroupBox17.Controls.Add(Me.ll_watermarkfont)
        Me.GroupBox17.Controls.Add(Me.lbl_watermark_y)
        Me.GroupBox17.Controls.Add(Me.ll_watermarktext)
        Me.GroupBox17.Controls.Add(Me.lbl_watermark_x)
        Me.GroupBox17.Controls.Add(Me.chk_watermark)
        Me.GroupBox17.Controls.Add(Me.Label32)
        Me.GroupBox17.Location = New System.Drawing.Point(235, 130)
        Me.GroupBox17.Name = "GroupBox17"
        Me.GroupBox17.Size = New System.Drawing.Size(225, 125)
        Me.GroupBox17.TabIndex = 61
        Me.GroupBox17.TabStop = False
        Me.GroupBox17.Text = "Watermark"
        '
        'txt_watermark_offX
        '
        Me.txt_watermark_offX.Location = New System.Drawing.Point(175, 18)
        Me.txt_watermark_offX.Name = "txt_watermark_offX"
        Me.txt_watermark_offX.Size = New System.Drawing.Size(40, 20)
        Me.txt_watermark_offX.TabIndex = 51
        Me.txt_watermark_offX.Text = "10"
        '
        'txt_watermark_offY
        '
        Me.txt_watermark_offY.Location = New System.Drawing.Point(175, 43)
        Me.txt_watermark_offY.Name = "txt_watermark_offY"
        Me.txt_watermark_offY.Size = New System.Drawing.Size(40, 20)
        Me.txt_watermark_offY.TabIndex = 52
        Me.txt_watermark_offY.Text = "10"
        '
        'lbl_watermark_y
        '
        Me.lbl_watermark_y.AutoSize = True
        Me.lbl_watermark_y.Location = New System.Drawing.Point(125, 46)
        Me.lbl_watermark_y.Name = "lbl_watermark_y"
        Me.lbl_watermark_y.Size = New System.Drawing.Size(48, 13)
        Me.lbl_watermark_y.TabIndex = 50
        Me.lbl_watermark_y.Text = "Offset Y:"
        Me.lbl_watermark_y.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_watermark_x
        '
        Me.lbl_watermark_x.AutoSize = True
        Me.lbl_watermark_x.Location = New System.Drawing.Point(125, 21)
        Me.lbl_watermark_x.Name = "lbl_watermark_x"
        Me.lbl_watermark_x.Size = New System.Drawing.Size(48, 13)
        Me.lbl_watermark_x.TabIndex = 49
        Me.lbl_watermark_x.Text = "Offset X:"
        Me.lbl_watermark_x.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chk_watermark
        '
        Me.chk_watermark.AutoSize = True
        Me.chk_watermark.Location = New System.Drawing.Point(13, 22)
        Me.chk_watermark.Name = "chk_watermark"
        Me.chk_watermark.Size = New System.Drawing.Size(53, 17)
        Me.chk_watermark.TabIndex = 26
        Me.chk_watermark.Text = "Show"
        Me.chk_watermark.UseVisualStyleBackColor = True
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(6, 16)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(0, 13)
        Me.Label32.TabIndex = 37
        '
        'chk_labelbordershadow
        '
        Me.chk_labelbordershadow.AutoSize = True
        Me.chk_labelbordershadow.Location = New System.Drawing.Point(13, 22)
        Me.chk_labelbordershadow.Name = "chk_labelbordershadow"
        Me.chk_labelbordershadow.Size = New System.Drawing.Size(91, 17)
        Me.chk_labelbordershadow.TabIndex = 43
        Me.chk_labelbordershadow.Text = "Drop Shadow"
        Me.chk_labelbordershadow.UseVisualStyleBackColor = True
        '
        'GroupBox14
        '
        Me.GroupBox14.Controls.Add(Me.ll_tilesize)
        Me.GroupBox14.Controls.Add(Me.label_imagepercent)
        Me.GroupBox14.Controls.Add(Me.num_imagepercent)
        Me.GroupBox14.Controls.Add(Me.Label35)
        Me.GroupBox14.Controls.Add(Me.chk_progressive)
        Me.GroupBox14.Controls.Add(Me.txt_columns)
        Me.GroupBox14.Controls.Add(Me.label_tilewidth)
        Me.GroupBox14.Controls.Add(Me.txt_gapwidth)
        Me.GroupBox14.Controls.Add(Me.Label_tileheight)
        Me.GroupBox14.Controls.Add(Me.txt_gapheight)
        Me.GroupBox14.Controls.Add(Me.Label9)
        Me.GroupBox14.Controls.Add(Me.Label21)
        Me.GroupBox14.Controls.Add(Me.txt_tilewidth)
        Me.GroupBox14.Controls.Add(Me.txt_tileheight)
        Me.GroupBox14.Location = New System.Drawing.Point(5, 5)
        Me.GroupBox14.Name = "GroupBox14"
        Me.GroupBox14.Size = New System.Drawing.Size(225, 125)
        Me.GroupBox14.TabIndex = 58
        Me.GroupBox14.TabStop = False
        Me.GroupBox14.Text = "Layout"
        '
        'label_imagepercent
        '
        Me.label_imagepercent.AutoSize = True
        Me.label_imagepercent.Location = New System.Drawing.Point(120, 68)
        Me.label_imagepercent.Name = "label_imagepercent"
        Me.label_imagepercent.Size = New System.Drawing.Size(35, 13)
        Me.label_imagepercent.TabIndex = 48
        Me.label_imagepercent.Text = "Perc.:"
        Me.label_imagepercent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'num_imagepercent
        '
        Me.num_imagepercent.Location = New System.Drawing.Point(175, 66)
        Me.num_imagepercent.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.num_imagepercent.Name = "num_imagepercent"
        Me.num_imagepercent.Size = New System.Drawing.Size(40, 20)
        Me.num_imagepercent.TabIndex = 47
        Me.num_imagepercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.num_imagepercent.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(10, 20)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(30, 13)
        Me.Label35.TabIndex = 45
        Me.Label35.Text = "Cols:"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chk_progressive
        '
        Me.chk_progressive.AutoSize = True
        Me.chk_progressive.Checked = True
        Me.chk_progressive.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_progressive.Location = New System.Drawing.Point(123, 95)
        Me.chk_progressive.Name = "chk_progressive"
        Me.chk_progressive.Size = New System.Drawing.Size(81, 17)
        Me.chk_progressive.TabIndex = 40
        Me.chk_progressive.Text = "Progressive"
        Me.chk_progressive.UseVisualStyleBackColor = True
        '
        'txt_columns
        '
        Me.txt_columns.Location = New System.Drawing.Point(66, 17)
        Me.txt_columns.Name = "txt_columns"
        Me.txt_columns.Size = New System.Drawing.Size(40, 20)
        Me.txt_columns.TabIndex = 46
        Me.txt_columns.Text = "3"
        '
        'label_tilewidth
        '
        Me.label_tilewidth.AutoSize = True
        Me.label_tilewidth.Location = New System.Drawing.Point(10, 45)
        Me.label_tilewidth.Name = "label_tilewidth"
        Me.label_tilewidth.Size = New System.Drawing.Size(38, 13)
        Me.label_tilewidth.TabIndex = 44
        Me.label_tilewidth.Text = "Width:"
        Me.label_tilewidth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_gapwidth
        '
        Me.txt_gapwidth.Location = New System.Drawing.Point(175, 17)
        Me.txt_gapwidth.Name = "txt_gapwidth"
        Me.txt_gapwidth.Size = New System.Drawing.Size(40, 20)
        Me.txt_gapwidth.TabIndex = 42
        Me.txt_gapwidth.Text = "10"
        '
        'Label_tileheight
        '
        Me.Label_tileheight.AutoSize = True
        Me.Label_tileheight.Location = New System.Drawing.Point(10, 70)
        Me.Label_tileheight.Name = "Label_tileheight"
        Me.Label_tileheight.Size = New System.Drawing.Size(41, 13)
        Me.Label_tileheight.TabIndex = 45
        Me.Label_tileheight.Text = "Height:"
        Me.Label_tileheight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_gapheight
        '
        Me.txt_gapheight.Location = New System.Drawing.Point(175, 42)
        Me.txt_gapheight.Name = "txt_gapheight"
        Me.txt_gapheight.Size = New System.Drawing.Size(40, 20)
        Me.txt_gapheight.TabIndex = 43
        Me.txt_gapheight.Text = "10"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(120, 45)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 13)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Gap Y:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(120, 20)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(40, 13)
        Me.Label21.TabIndex = 28
        Me.Label21.Text = "Gap X:"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_tilewidth
        '
        Me.txt_tilewidth.Location = New System.Drawing.Point(66, 42)
        Me.txt_tilewidth.Name = "txt_tilewidth"
        Me.txt_tilewidth.Size = New System.Drawing.Size(40, 20)
        Me.txt_tilewidth.TabIndex = 27
        Me.txt_tilewidth.Text = "200"
        '
        'txt_tileheight
        '
        Me.txt_tileheight.Location = New System.Drawing.Point(66, 67)
        Me.txt_tileheight.Name = "txt_tileheight"
        Me.txt_tileheight.Size = New System.Drawing.Size(40, 20)
        Me.txt_tileheight.TabIndex = 26
        Me.txt_tileheight.Text = "200"
        '
        'txt_scenes
        '
        Me.txt_scenes.Location = New System.Drawing.Point(60, 19)
        Me.txt_scenes.Name = "txt_scenes"
        Me.txt_scenes.Size = New System.Drawing.Size(40, 20)
        Me.txt_scenes.TabIndex = 49
        Me.txt_scenes.Text = "3"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(6, 16)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(0, 13)
        Me.Label23.TabIndex = 37
        '
        'GroupBox15
        '
        Me.GroupBox15.Controls.Add(Me.ll_labelbordercolor)
        Me.GroupBox15.Controls.Add(Me.ll_labelbordertype)
        Me.GroupBox15.Controls.Add(Me.label_labelbordersize)
        Me.GroupBox15.Controls.Add(Me.num_labelbordersize)
        Me.GroupBox15.Controls.Add(Me.chk_labelbordershadow)
        Me.GroupBox15.Location = New System.Drawing.Point(350, 5)
        Me.GroupBox15.Name = "GroupBox15"
        Me.GroupBox15.Size = New System.Drawing.Size(110, 125)
        Me.GroupBox15.TabIndex = 56
        Me.GroupBox15.TabStop = False
        Me.GroupBox15.Text = "TimeCode Fx"
        '
        'GroupBox13
        '
        Me.GroupBox13.Controls.Add(Me.ll_labellocation)
        Me.GroupBox13.Controls.Add(Me.chk_labeluse)
        Me.GroupBox13.Controls.Add(Me.ll_labelcolor)
        Me.GroupBox13.Controls.Add(Me.ll_labelfont)
        Me.GroupBox13.Controls.Add(Me.Label31)
        Me.GroupBox13.Location = New System.Drawing.Point(235, 5)
        Me.GroupBox13.Name = "GroupBox13"
        Me.GroupBox13.Size = New System.Drawing.Size(110, 125)
        Me.GroupBox13.TabIndex = 55
        Me.GroupBox13.TabStop = False
        Me.GroupBox13.Text = "TimeCode Text"
        '
        'chk_labeluse
        '
        Me.chk_labeluse.AutoSize = True
        Me.chk_labeluse.Location = New System.Drawing.Point(13, 22)
        Me.chk_labeluse.Name = "chk_labeluse"
        Me.chk_labeluse.Size = New System.Drawing.Size(53, 17)
        Me.chk_labeluse.TabIndex = 42
        Me.chk_labeluse.Text = "Show"
        Me.chk_labeluse.UseVisualStyleBackColor = True
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(6, 16)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(0, 13)
        Me.Label31.TabIndex = 37
        '
        'llabel_detailinfo
        '
        Me.llabel_detailinfo.AutoSize = True
        Me.llabel_detailinfo.Location = New System.Drawing.Point(47, 0)
        Me.llabel_detailinfo.Name = "llabel_detailinfo"
        Me.llabel_detailinfo.Size = New System.Drawing.Size(60, 13)
        Me.llabel_detailinfo.TabIndex = 24
        Me.llabel_detailinfo.TabStop = True
        Me.llabel_detailinfo.Text = "(MovieInfo)"
        '
        'txt_detailtext
        '
        Me.txt_detailtext.AcceptsTab = True
        Me.txt_detailtext.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_detailtext.Location = New System.Drawing.Point(115, 15)
        Me.txt_detailtext.Multiline = True
        Me.txt_detailtext.Name = "txt_detailtext"
        Me.txt_detailtext.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txt_detailtext.Size = New System.Drawing.Size(330, 100)
        Me.txt_detailtext.TabIndex = 10
        Me.txt_detailtext.Text = "Title:" & Global.Microsoft.VisualBasic.ChrW(9) & "[FILE.NAME] - [FILE.SIZE]" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Time:" & Global.Microsoft.VisualBasic.ChrW(9) & "[DURATION]" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Res.:" & Global.Microsoft.VisualBasic.ChrW(9) & "[WIDTH] x [HEIGHT] - [F" & _
            "PS]" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Aspect:" & Global.Microsoft.VisualBasic.ChrW(9) & "[ASPECT.RATIO]" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Video:" & Global.Microsoft.VisualBasic.ChrW(9) & "[CODEC] - [BITRATE]" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Audio:" & Global.Microsoft.VisualBasic.ChrW(9) & "[A.CODEC] - [A.B" & _
            "ITRATE]@[A.SAMPLE]"
        '
        'GroupBox12
        '
        Me.GroupBox12.Controls.Add(Me.ll_detailcolor)
        Me.GroupBox12.Controls.Add(Me.ll_detailfont)
        Me.GroupBox12.Controls.Add(Me.ll_detaillocation)
        Me.GroupBox12.Controls.Add(Me.llabel_detailinfo)
        Me.GroupBox12.Controls.Add(Me.txt_detailtext)
        Me.GroupBox12.Controls.Add(Me.cko_detailtext)
        Me.GroupBox12.Location = New System.Drawing.Point(5, 255)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(455, 125)
        Me.GroupBox12.TabIndex = 54
        Me.GroupBox12.TabStop = False
        Me.GroupBox12.Text = "Details            "
        '
        'cko_detailtext
        '
        Me.cko_detailtext.AutoSize = True
        Me.cko_detailtext.Location = New System.Drawing.Point(13, 22)
        Me.cko_detailtext.Name = "cko_detailtext"
        Me.cko_detailtext.Size = New System.Drawing.Size(53, 17)
        Me.cko_detailtext.TabIndex = 12
        Me.cko_detailtext.Text = "Show"
        Me.cko_detailtext.UseVisualStyleBackColor = True
        '
        'GroupBox16
        '
        Me.GroupBox16.Controls.Add(Me.ll_backgroundtype)
        Me.GroupBox16.Controls.Add(Me.ll_backgroundcolor)
        Me.GroupBox16.Controls.Add(Me.Label23)
        Me.GroupBox16.Location = New System.Drawing.Point(5, 130)
        Me.GroupBox16.Name = "GroupBox16"
        Me.GroupBox16.Size = New System.Drawing.Size(110, 73)
        Me.GroupBox16.TabIndex = 57
        Me.GroupBox16.TabStop = False
        Me.GroupBox16.Text = "Background"
        '
        'num_imagequality
        '
        Me.num_imagequality.Location = New System.Drawing.Point(60, 43)
        Me.num_imagequality.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.num_imagequality.Name = "num_imagequality"
        Me.num_imagequality.Size = New System.Drawing.Size(40, 20)
        Me.num_imagequality.TabIndex = 49
        Me.num_imagequality.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.num_imagequality.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'GroupBox18
        '
        Me.GroupBox18.Controls.Add(Me.ll_naming)
        Me.GroupBox18.Controls.Add(Me.ll_imagesavemode)
        Me.GroupBox18.Controls.Add(Me.num_imagequality)
        Me.GroupBox18.Controls.Add(Me.ll_imagetyp)
        Me.GroupBox18.Controls.Add(Me.label_num_imagequality)
        Me.GroupBox18.Controls.Add(Me.Label37)
        Me.GroupBox18.Location = New System.Drawing.Point(120, 130)
        Me.GroupBox18.Name = "GroupBox18"
        Me.GroupBox18.Size = New System.Drawing.Size(110, 125)
        Me.GroupBox18.TabIndex = 59
        Me.GroupBox18.TabStop = False
        Me.GroupBox18.Text = "Output"
        '
        'label_num_imagequality
        '
        Me.label_num_imagequality.AutoSize = True
        Me.label_num_imagequality.Location = New System.Drawing.Point(10, 45)
        Me.label_num_imagequality.Name = "label_num_imagequality"
        Me.label_num_imagequality.Size = New System.Drawing.Size(42, 13)
        Me.label_num_imagequality.TabIndex = 47
        Me.label_num_imagequality.Text = "Quality:"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(6, 16)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(0, 13)
        Me.Label37.TabIndex = 37
        '
        'grp_batch
        '
        Me.grp_batch.Controls.Add(Me.ll_sceneshotmode)
        Me.grp_batch.Controls.Add(Me.txt_scenes)
        Me.grp_batch.Location = New System.Drawing.Point(5, 203)
        Me.grp_batch.Name = "grp_batch"
        Me.grp_batch.Size = New System.Drawing.Size(110, 52)
        Me.grp_batch.TabIndex = 60
        Me.grp_batch.TabStop = False
        Me.grp_batch.Text = "Batchmode"
        '
        'll_watermarkcolor
        '
        Me.ll_watermarkcolor.Location = New System.Drawing.Point(125, 95)
        Me.ll_watermarkcolor.Name = "ll_watermarkcolor"
        Me.ll_watermarkcolor.Size = New System.Drawing.Size(90, 20)
        Me.ll_watermarkcolor.TabIndex = 56
        Me.ll_watermarkcolor.Value = System.Drawing.Color.Empty
        '
        'll_watermark_type
        '
        Me.ll_watermark_type.BrowseIndex = 1
        Me.ll_watermark_type.BrowseTitle = Nothing
        Me.ll_watermark_type.BrowseType = 0
        Me.ll_watermark_type.BrowseValue = "0"
        Me.ll_watermark_type.EnumType = "SceneGrabberNET.ImageUtil+WatermarkType"
        Me.ll_watermark_type.LabelText = "Type:"
        Me.ll_watermark_type.Location = New System.Drawing.Point(10, 47)
        Me.ll_watermark_type.Margin = New System.Windows.Forms.Padding(0)
        Me.ll_watermark_type.Name = "ll_watermark_type"
        Me.ll_watermark_type.Size = New System.Drawing.Size(90, 20)
        Me.ll_watermark_type.TabIndex = 55
        Me.ll_watermark_type.Value = 0
        '
        'll_watermark_location
        '
        Me.ll_watermark_location.EnumType = "SceneGrabberNET.ImageUtil+WatermarkLocation"
        Me.ll_watermark_location.Location = New System.Drawing.Point(10, 70)
        Me.ll_watermark_location.Margin = New System.Windows.Forms.Padding(0)
        Me.ll_watermark_location.Name = "ll_watermark_location"
        Me.ll_watermark_location.Size = New System.Drawing.Size(90, 20)
        Me.ll_watermark_location.TabIndex = 53
        Me.ll_watermark_location.Value = 0
        '
        'll_watermarkfont
        '
        Me.ll_watermarkfont.Location = New System.Drawing.Point(125, 70)
        Me.ll_watermarkfont.Name = "ll_watermarkfont"
        Me.ll_watermarkfont.Size = New System.Drawing.Size(90, 20)
        Me.ll_watermarkfont.TabIndex = 43
        Me.ll_watermarkfont.Value = Nothing
        '
        'll_watermarktext
        '
        Me.ll_watermarktext.LabelText = "Text:"
        Me.ll_watermarktext.Location = New System.Drawing.Point(10, 96)
        Me.ll_watermarktext.Margin = New System.Windows.Forms.Padding(0)
        Me.ll_watermarktext.Name = "ll_watermarktext"
        Me.ll_watermarktext.Size = New System.Drawing.Size(90, 20)
        Me.ll_watermarktext.TabIndex = 41
        Me.ll_watermarktext.Value = "0"
        '
        'll_tilesize
        '
        Me.ll_tilesize.EnumType = "SceneGrabberNET.ImageUtil+ImageSizeMode"
        Me.ll_tilesize.LabelText = "Tile size:"
        Me.ll_tilesize.Location = New System.Drawing.Point(10, 95)
        Me.ll_tilesize.Name = "ll_tilesize"
        Me.ll_tilesize.Size = New System.Drawing.Size(95, 20)
        Me.ll_tilesize.TabIndex = 43
        Me.ll_tilesize.Value = 0
        '
        'll_labelbordercolor
        '
        Me.ll_labelbordercolor.Location = New System.Drawing.Point(10, 95)
        Me.ll_labelbordercolor.Name = "ll_labelbordercolor"
        Me.ll_labelbordercolor.Size = New System.Drawing.Size(90, 20)
        Me.ll_labelbordercolor.TabIndex = 52
        Me.ll_labelbordercolor.Value = System.Drawing.Color.Empty
        '
        'll_labelbordertype
        '
        Me.ll_labelbordertype.EnumType = "SceneGrabberNET.ImageUtil+BorderType"
        Me.ll_labelbordertype.LabelText = "Border:"
        Me.ll_labelbordertype.Location = New System.Drawing.Point(10, 45)
        Me.ll_labelbordertype.Name = "ll_labelbordertype"
        Me.ll_labelbordertype.Size = New System.Drawing.Size(90, 15)
        Me.ll_labelbordertype.TabIndex = 51
        Me.ll_labelbordertype.Value = 0
        '
        'll_labellocation
        '
        Me.ll_labellocation.EnumType = "SceneGrabberNET.ImageUtil+TextLocation"
        Me.ll_labellocation.Location = New System.Drawing.Point(10, 45)
        Me.ll_labellocation.Margin = New System.Windows.Forms.Padding(0)
        Me.ll_labellocation.Name = "ll_labellocation"
        Me.ll_labellocation.Size = New System.Drawing.Size(90, 20)
        Me.ll_labellocation.TabIndex = 53
        Me.ll_labellocation.Value = 0
        '
        'll_labelcolor
        '
        Me.ll_labelcolor.Location = New System.Drawing.Point(10, 95)
        Me.ll_labelcolor.Name = "ll_labelcolor"
        Me.ll_labelcolor.Size = New System.Drawing.Size(90, 20)
        Me.ll_labelcolor.TabIndex = 26
        Me.ll_labelcolor.Value = System.Drawing.Color.Empty
        '
        'll_labelfont
        '
        Me.ll_labelfont.Location = New System.Drawing.Point(10, 70)
        Me.ll_labelfont.Name = "ll_labelfont"
        Me.ll_labelfont.Size = New System.Drawing.Size(90, 20)
        Me.ll_labelfont.TabIndex = 26
        Me.ll_labelfont.Value = Nothing
        '
        'll_detailcolor
        '
        Me.ll_detailcolor.Location = New System.Drawing.Point(10, 95)
        Me.ll_detailcolor.Name = "ll_detailcolor"
        Me.ll_detailcolor.Size = New System.Drawing.Size(90, 20)
        Me.ll_detailcolor.TabIndex = 27
        Me.ll_detailcolor.Value = System.Drawing.Color.Empty
        '
        'll_detailfont
        '
        Me.ll_detailfont.Location = New System.Drawing.Point(10, 70)
        Me.ll_detailfont.Name = "ll_detailfont"
        Me.ll_detailfont.Size = New System.Drawing.Size(90, 16)
        Me.ll_detailfont.TabIndex = 26
        Me.ll_detailfont.Value = Nothing
        '
        'll_detaillocation
        '
        Me.ll_detaillocation.EnumType = "SceneGrabberNET.ImageUtil+DetailTextLocation"
        Me.ll_detaillocation.Location = New System.Drawing.Point(10, 45)
        Me.ll_detaillocation.Margin = New System.Windows.Forms.Padding(0)
        Me.ll_detaillocation.Name = "ll_detaillocation"
        Me.ll_detaillocation.Size = New System.Drawing.Size(90, 16)
        Me.ll_detaillocation.TabIndex = 25
        Me.ll_detaillocation.Value = 0
        '
        'll_backgroundtype
        '
        Me.ll_backgroundtype.BrowseIndex = 1
        Me.ll_backgroundtype.BrowseTitle = "Select background image"
        Me.ll_backgroundtype.BrowseType = 0
        Me.ll_backgroundtype.BrowseValue = Nothing
        Me.ll_backgroundtype.EnumType = "SceneGrabberNET.ImageUtil+Background"
        Me.ll_backgroundtype.LabelText = "Type:"
        Me.ll_backgroundtype.Location = New System.Drawing.Point(10, 20)
        Me.ll_backgroundtype.Name = "ll_backgroundtype"
        Me.ll_backgroundtype.Size = New System.Drawing.Size(90, 20)
        Me.ll_backgroundtype.TabIndex = 42
        Me.ll_backgroundtype.Value = 0
        '
        'll_backgroundcolor
        '
        Me.ll_backgroundcolor.Location = New System.Drawing.Point(10, 43)
        Me.ll_backgroundcolor.Name = "ll_backgroundcolor"
        Me.ll_backgroundcolor.Size = New System.Drawing.Size(90, 20)
        Me.ll_backgroundcolor.TabIndex = 41
        Me.ll_backgroundcolor.Value = System.Drawing.Color.Empty
        '
        'll_naming
        '
        Me.ll_naming.EnumType = "SceneGrabberNET.ImageUtil+Naming"
        Me.ll_naming.LabelText = "Filename:"
        Me.ll_naming.Location = New System.Drawing.Point(10, 96)
        Me.ll_naming.Name = "ll_naming"
        Me.ll_naming.Size = New System.Drawing.Size(90, 20)
        Me.ll_naming.TabIndex = 53
        Me.ll_naming.Value = 0
        '
        'll_imagesavemode
        '
        Me.ll_imagesavemode.BrowseIndex = 2
        Me.ll_imagesavemode.BrowseTitle = "Select folder for saving."
        Me.ll_imagesavemode.BrowseType = 2
        Me.ll_imagesavemode.BrowseValue = Nothing
        Me.ll_imagesavemode.EnumType = "SceneGrabberNET.ImageUtil+SaveMode"
        Me.ll_imagesavemode.LabelText = "Dest:"
        Me.ll_imagesavemode.Location = New System.Drawing.Point(10, 70)
        Me.ll_imagesavemode.Name = "ll_imagesavemode"
        Me.ll_imagesavemode.Size = New System.Drawing.Size(90, 20)
        Me.ll_imagesavemode.TabIndex = 52
        Me.ll_imagesavemode.Value = 0
        '
        'll_imagetyp
        '
        Me.ll_imagetyp.EnumType = "SceneGrabberNET.ImageUtil+ImageTyp"
        Me.ll_imagetyp.LabelText = "Format:"
        Me.ll_imagetyp.Location = New System.Drawing.Point(10, 20)
        Me.ll_imagetyp.Name = "ll_imagetyp"
        Me.ll_imagetyp.Size = New System.Drawing.Size(90, 20)
        Me.ll_imagetyp.TabIndex = 51
        Me.ll_imagetyp.Value = 0
        '
        'll_sceneshotmode
        '
        Me.ll_sceneshotmode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ll_sceneshotmode.EnumType = "SceneGrabberNET.ImageUtil+SceneshotMode"
        Me.ll_sceneshotmode.Location = New System.Drawing.Point(5, 23)
        Me.ll_sceneshotmode.Name = "ll_sceneshotmode"
        Me.ll_sceneshotmode.Size = New System.Drawing.Size(52, 15)
        Me.ll_sceneshotmode.TabIndex = 50
        Me.ll_sceneshotmode.Value = 0
        '
        'CtlOptions3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox17)
        Me.Controls.Add(Me.GroupBox14)
        Me.Controls.Add(Me.GroupBox15)
        Me.Controls.Add(Me.GroupBox13)
        Me.Controls.Add(Me.GroupBox12)
        Me.Controls.Add(Me.GroupBox16)
        Me.Controls.Add(Me.GroupBox18)
        Me.Controls.Add(Me.grp_batch)
        Me.Name = "CtlOptions3"
        Me.Size = New System.Drawing.Size(465, 385)
        CType(Me.num_labelbordersize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox17.ResumeLayout(False)
        Me.GroupBox17.PerformLayout()
        Me.GroupBox14.ResumeLayout(False)
        Me.GroupBox14.PerformLayout()
        CType(Me.num_imagepercent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox15.ResumeLayout(False)
        Me.GroupBox15.PerformLayout()
        Me.GroupBox13.ResumeLayout(False)
        Me.GroupBox13.PerformLayout()
        Me.GroupBox12.ResumeLayout(False)
        Me.GroupBox12.PerformLayout()
        Me.GroupBox16.ResumeLayout(False)
        Me.GroupBox16.PerformLayout()
        CType(Me.num_imagequality, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox18.ResumeLayout(False)
        Me.GroupBox18.PerformLayout()
        Me.grp_batch.ResumeLayout(False)
        Me.grp_batch.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents label_labelbordersize As System.Windows.Forms.Label
    Friend WithEvents num_labelbordersize As System.Windows.Forms.NumericUpDown
    Friend WithEvents GroupBox17 As System.Windows.Forms.GroupBox
    Friend WithEvents ll_watermarkcolor As SceneGrabberNET.ctlColorLinkLabel
    Friend WithEvents ll_watermark_type As SceneGrabberNET.ctlEnumBrowseLabel
    Friend WithEvents ll_watermark_location As SceneGrabberNET.ctlAlignLinkLabel
    Friend WithEvents txt_watermark_offX As System.Windows.Forms.TextBox
    Friend WithEvents txt_watermark_offY As System.Windows.Forms.TextBox
    Friend WithEvents ll_watermarkfont As SceneGrabberNET.ctlFontLinkLabel
    Friend WithEvents lbl_watermark_y As System.Windows.Forms.Label
    Friend WithEvents ll_watermarktext As SceneGrabberNET.ctlTextboxLink
    Friend WithEvents lbl_watermark_x As System.Windows.Forms.Label
    Friend WithEvents chk_watermark As System.Windows.Forms.CheckBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents ll_labelbordertype As SceneGrabberNET.ctlEnumLinkLabel
    Friend WithEvents chk_labelbordershadow As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox14 As System.Windows.Forms.GroupBox
    Friend WithEvents ll_tilesize As SceneGrabberNET.ctlEnumLinkLabel
    Friend WithEvents label_imagepercent As System.Windows.Forms.Label
    Friend WithEvents num_imagepercent As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents chk_progressive As System.Windows.Forms.CheckBox
    Friend WithEvents txt_columns As System.Windows.Forms.TextBox
    Friend WithEvents label_tilewidth As System.Windows.Forms.Label
    Friend WithEvents txt_gapwidth As System.Windows.Forms.TextBox
    Friend WithEvents Label_tileheight As System.Windows.Forms.Label
    Friend WithEvents txt_gapheight As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txt_tilewidth As System.Windows.Forms.TextBox
    Friend WithEvents txt_tileheight As System.Windows.Forms.TextBox
    Friend WithEvents ll_labelbordercolor As SceneGrabberNET.ctlColorLinkLabel
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents GroupBox15 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox13 As System.Windows.Forms.GroupBox
    Friend WithEvents ll_labellocation As SceneGrabberNET.ctlAlignLinkLabel
    Friend WithEvents chk_labeluse As System.Windows.Forms.CheckBox
    Friend WithEvents ll_labelcolor As SceneGrabberNET.ctlColorLinkLabel
    Friend WithEvents ll_labelfont As SceneGrabberNET.ctlFontLinkLabel
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents ll_detailcolor As SceneGrabberNET.ctlColorLinkLabel
    Friend WithEvents ll_detailfont As SceneGrabberNET.ctlFontLinkLabel
    Friend WithEvents ll_detaillocation As SceneGrabberNET.ctlAlignLinkLabel
    Friend WithEvents llabel_detailinfo As System.Windows.Forms.LinkLabel
    Friend WithEvents txt_detailtext As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox12 As System.Windows.Forms.GroupBox
    Friend WithEvents cko_detailtext As System.Windows.Forms.CheckBox
    Friend WithEvents ll_backgroundcolor As SceneGrabberNET.ctlColorLinkLabel
    Friend WithEvents ll_backgroundtype As SceneGrabberNET.ctlEnumBrowseLabel
    Friend WithEvents GroupBox16 As System.Windows.Forms.GroupBox
    Friend WithEvents ll_imagesavemode As SceneGrabberNET.ctlEnumBrowseLabel
    Friend WithEvents ll_naming As SceneGrabberNET.ctlEnumLinkLabel
    Friend WithEvents num_imagequality As System.Windows.Forms.NumericUpDown
    Friend WithEvents GroupBox18 As System.Windows.Forms.GroupBox
    Friend WithEvents ll_imagetyp As SceneGrabberNET.ctlEnumLinkLabel
    Friend WithEvents label_num_imagequality As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents grp_batch As System.Windows.Forms.GroupBox
    Friend WithEvents txt_scenes As System.Windows.Forms.TextBox
    Friend WithEvents ll_sceneshotmode As SceneGrabberNET.ctlEnumLabelOnly

End Class
