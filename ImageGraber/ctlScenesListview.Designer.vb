<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlScenesListView
    Inherits SceneGrabberNET.AUserControl

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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ctlScenesListView))
		Dim TextShadower1 As gCursorLib.TextShadower = New gCursorLib.TextShadower
		Me._lview = New SceneGrabberNET.gListView
		Me._cntMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
		Me._cntMenu_changeLabel = New System.Windows.Forms.ToolStripMenuItem
		Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
		Me._cntMenu_show = New System.Windows.Forms.ToolStripMenuItem
		Me._cntMenu_saveimage = New System.Windows.Forms.ToolStripMenuItem
		Me._cntMenu_saveimages = New System.Windows.Forms.ToolStripMenuItem
		Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
		Me._cntMenu_delete = New System.Windows.Forms.ToolStripMenuItem
		Me._cntMenu_deleteAll = New System.Windows.Forms.ToolStripMenuItem
		Me._sep1 = New System.Windows.Forms.ToolStripSeparator
		Me._cntMenu_SortByLabel = New System.Windows.Forms.ToolStripMenuItem
		Me._cntMenu_SortByTimeCode = New System.Windows.Forms.ToolStripMenuItem
		Me._sep3 = New System.Windows.Forms.ToolStripSeparator
		Me._cntMenu_options = New System.Windows.Forms.ToolStripMenuItem
		Me._sep2 = New System.Windows.Forms.ToolStripSeparator
		Me._cntMenu_preview = New System.Windows.Forms.ToolStripMenuItem
		Me._cntMenu_save = New System.Windows.Forms.ToolStripMenuItem
		Me.GCursor1 = New gCursorLib.gCursor(Me.components)
		Me._cntMenu.SuspendLayout()
		Me.SuspendLayout()
		'
		'_lview
		'
		Me._lview.AllowDrop = True
		Me._lview.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
					Or System.Windows.Forms.AnchorStyles.Left) _
					Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me._lview.AutoScroll = SceneGrabberNET.gListView.eAutoScroll.Vertical
		Me._lview.ColorRowA = System.Drawing.Color.White
		Me._lview.ColorRowB = System.Drawing.Color.White
		Me._lview.ColorRows = True
		Me._lview.ContextMenuStrip = Me._cntMenu
		Me._lview.DropBarColor = System.Drawing.Color.Red
		Me._lview.gCurrCursor = Me.GCursor1
		Me._lview.gCursorVisible = True
		Me._lview.LabelEdit = True
		Me._lview.Location = New System.Drawing.Point(0, 0)
		Me._lview.MatchFont = True
		Me._lview.Name = "_lview"
		Me._lview.OwnerDraw = True
		Me._lview.ShowGroups = False
		Me._lview.Size = New System.Drawing.Size(532, 496)
		Me._lview.TabIndex = 5
		Me._lview.UseCompatibleStateImageBehavior = False
		'
		'_cntMenu
		'
		Me._cntMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me._cntMenu_changeLabel, Me.ToolStripSeparator1, Me._cntMenu_show, Me._cntMenu_saveimage, Me._cntMenu_saveimages, Me.ToolStripSeparator3, Me._cntMenu_delete, Me._cntMenu_deleteAll, Me._sep1, Me._cntMenu_SortByLabel, Me._cntMenu_SortByTimeCode, Me._sep3, Me._cntMenu_options, Me._sep2, Me._cntMenu_preview, Me._cntMenu_save})
		Me._cntMenu.Name = "ContextMenuStrip1"
		Me._cntMenu.Size = New System.Drawing.Size(170, 276)
		'
		'_cntMenu_changeLabel
		'
		Me._cntMenu_changeLabel.Name = "_cntMenu_changeLabel"
		Me._cntMenu_changeLabel.Size = New System.Drawing.Size(169, 22)
		Me._cntMenu_changeLabel.Text = "Change Label"
		'
		'ToolStripSeparator1
		'
		Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
		Me.ToolStripSeparator1.Size = New System.Drawing.Size(166, 6)
		'
		'_cntMenu_show
		'
		Me._cntMenu_show.Name = "_cntMenu_show"
		Me._cntMenu_show.Size = New System.Drawing.Size(169, 22)
		Me._cntMenu_show.Text = "Show Image"
		'
		'_cntMenu_saveimage
		'
		Me._cntMenu_saveimage.Name = "_cntMenu_saveimage"
		Me._cntMenu_saveimage.Size = New System.Drawing.Size(169, 22)
		Me._cntMenu_saveimage.Text = "Save Image(s)"
		'
		'_cntMenu_saveimages
		'
		Me._cntMenu_saveimages.Name = "_cntMenu_saveimages"
		Me._cntMenu_saveimages.Size = New System.Drawing.Size(169, 22)
		Me._cntMenu_saveimages.Text = "Save all Images"
		'
		'ToolStripSeparator3
		'
		Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
		Me.ToolStripSeparator3.Size = New System.Drawing.Size(166, 6)
		'
		'_cntMenu_delete
		'
		Me._cntMenu_delete.Name = "_cntMenu_delete"
		Me._cntMenu_delete.Size = New System.Drawing.Size(169, 22)
		Me._cntMenu_delete.Text = "Delete"
		'
		'_cntMenu_deleteAll
		'
		Me._cntMenu_deleteAll.Name = "_cntMenu_deleteAll"
		Me._cntMenu_deleteAll.Size = New System.Drawing.Size(169, 22)
		Me._cntMenu_deleteAll.Text = "Delete All"
		'
		'_sep1
		'
		Me._sep1.Name = "_sep1"
		Me._sep1.Size = New System.Drawing.Size(166, 6)
		'
		'_cntMenu_SortByLabel
		'
		Me._cntMenu_SortByLabel.Name = "_cntMenu_SortByLabel"
		Me._cntMenu_SortByLabel.Size = New System.Drawing.Size(169, 22)
		Me._cntMenu_SortByLabel.Text = "Sort by Label"
		'
		'_cntMenu_SortByTimeCode
		'
		Me._cntMenu_SortByTimeCode.Name = "_cntMenu_SortByTimeCode"
		Me._cntMenu_SortByTimeCode.Size = New System.Drawing.Size(169, 22)
		Me._cntMenu_SortByTimeCode.Text = "Sort by TimeCode"
		'
		'_sep3
		'
		Me._sep3.Name = "_sep3"
		Me._sep3.Size = New System.Drawing.Size(166, 6)
		'
		'_cntMenu_options
		'
		Me._cntMenu_options.Name = "_cntMenu_options"
		Me._cntMenu_options.Size = New System.Drawing.Size(169, 22)
		Me._cntMenu_options.Text = "Options"
		'
		'_sep2
		'
		Me._sep2.Name = "_sep2"
		Me._sep2.Size = New System.Drawing.Size(166, 6)
		'
		'_cntMenu_preview
		'
		Me._cntMenu_preview.Name = "_cntMenu_preview"
		Me._cntMenu_preview.Size = New System.Drawing.Size(169, 22)
		Me._cntMenu_preview.Text = "Edit/Preview"
		'
		'_cntMenu_save
		'
		Me._cntMenu_save.Name = "_cntMenu_save"
		Me._cntMenu_save.Size = New System.Drawing.Size(169, 22)
		Me._cntMenu_save.Text = "Save"
		'
		'GCursor1
		'
		Me.GCursor1.gBlackBitBack = False
		Me.GCursor1.gBoxShadow = True
		Me.GCursor1.gCursorImage = CType(resources.GetObject("GCursor1.gCursorImage"), System.Drawing.Bitmap)
		Me.GCursor1.gEffect = gCursorLib.gCursor.eEffect.No
		Me.GCursor1.gFont = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.GCursor1.gHotSpot = System.Drawing.ContentAlignment.MiddleCenter
		Me.GCursor1.gIBTransp = 80
		Me.GCursor1.gImage = CType(resources.GetObject("GCursor1.gImage"), System.Drawing.Bitmap)
		Me.GCursor1.gImageBorderColor = System.Drawing.Color.White
		Me.GCursor1.gImageBox = New System.Drawing.Size(75, 56)
		Me.GCursor1.gImageBoxColor = System.Drawing.Color.White
		Me.GCursor1.gITransp = 0
		Me.GCursor1.gScrolling = gCursorLib.gCursor.eScrolling.No
		Me.GCursor1.gShowImageBox = False
		Me.GCursor1.gShowTextBox = False
		Me.GCursor1.gTBTransp = 80
		Me.GCursor1.gText = "Example Text" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Second Line" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Third Line"
		Me.GCursor1.gTextAlignment = System.Drawing.ContentAlignment.MiddleCenter
		Me.GCursor1.gTextAutoFit = gCursorLib.gCursor.eTextAutoFit.None
		Me.GCursor1.gTextBorderColor = System.Drawing.Color.Red
		Me.GCursor1.gTextBox = New System.Drawing.Size(100, 30)
		Me.GCursor1.gTextBoxColor = System.Drawing.Color.Blue
		Me.GCursor1.gTextColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
		Me.GCursor1.gTextFade = gCursorLib.gCursor.eTextFade.Solid
		Me.GCursor1.gTextMultiline = False
		Me.GCursor1.gTextShadow = False
		Me.GCursor1.gTextShadowColor = System.Drawing.Color.Black
		TextShadower1.Alignment = System.Drawing.ContentAlignment.MiddleCenter
		TextShadower1.Blur = 2.0!
		TextShadower1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		TextShadower1.Offset = CType(resources.GetObject("TextShadower1.Offset"), System.Drawing.PointF)
		TextShadower1.Padding = New System.Windows.Forms.Padding(0)
		TextShadower1.ShadowColor = System.Drawing.Color.Black
		TextShadower1.ShadowTransp = 128
		TextShadower1.Text = "Drop Shadow"
		TextShadower1.TextColor = System.Drawing.Color.Blue
		Me.GCursor1.gTextShadower = TextShadower1
		Me.GCursor1.gTTransp = 0
		Me.GCursor1.gType = gCursorLib.gCursor.eType.Both
		'
		'ctlScenesListView
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me._lview)
		Me.Name = "ctlScenesListView"
		Me.Size = New System.Drawing.Size(533, 497)
		Me._cntMenu.ResumeLayout(False)
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents _cntMenu As System.Windows.Forms.ContextMenuStrip
	Friend WithEvents _cntMenu_changeLabel As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents _cntMenu_show As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents _cntMenu_delete As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents _cntMenu_deleteAll As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents _sep1 As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents _cntMenu_options As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents _sep2 As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents _cntMenu_preview As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents _cntMenu_save As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents GCursor1 As gCursorLib.gCursor
	Private WithEvents _lview As SceneGrabberNET.gListView
	Friend WithEvents _cntMenu_saveimage As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents _cntMenu_SortByTimeCode As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents _sep3 As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents _cntMenu_SortByLabel As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents _cntMenu_saveimages As System.Windows.Forms.ToolStripMenuItem

End Class
