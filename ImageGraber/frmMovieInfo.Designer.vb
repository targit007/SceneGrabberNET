<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMovieInfo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
		Dim DataSourceColumnBinder1 As XPTable.Models.DataSourceColumnBinder = New XPTable.Models.DataSourceColumnBinder
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMovieInfo))
		Me.tblInfo = New XPTable.Models.Table
		Me.cmodel = New XPTable.Models.ColumnModel
		Me._name = New XPTable.Models.TextColumn
		Me._value = New XPTable.Models.TextColumn
		Me.tmodel = New XPTable.Models.TableModel
		Me.btnCancel = New System.Windows.Forms.Button
		Me._lbl_info = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.txt_detailtext = New System.Windows.Forms.TextBox
		Me.btn_ok = New System.Windows.Forms.Button
		Me.GroupBox1 = New System.Windows.Forms.GroupBox
		Me.GroupBox2 = New System.Windows.Forms.GroupBox
		Me.txt_preview = New System.Windows.Forms.TextBox
		CType(Me.tblInfo, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.GroupBox1.SuspendLayout()
		Me.GroupBox2.SuspendLayout()
		Me.SuspendLayout()
		'
		'tblInfo
		'
		Me.tblInfo.AllowSelection = False
		Me.tblInfo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
					Or System.Windows.Forms.AnchorStyles.Left) _
					Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.tblInfo.BorderColor = System.Drawing.Color.Black
		Me.tblInfo.ColumnModel = Me.cmodel
		Me.tblInfo.CustomEditKey = CType((((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
					Or System.Windows.Forms.Keys.Shift) _
					Or System.Windows.Forms.Keys.OemBackslash), System.Windows.Forms.Keys)
		Me.tblInfo.DataMember = Nothing
		Me.tblInfo.DataSourceColumnBinder = DataSourceColumnBinder1
		Me.tblInfo.EditStartAction = XPTable.Editors.EditStartAction.CustomKey
		Me.tblInfo.GridLines = XPTable.Models.GridLines.Both
		Me.tblInfo.Location = New System.Drawing.Point(0, -1)
		Me.tblInfo.Name = "tblInfo"
		Me.tblInfo.NoItemsText = ""
		Me.tblInfo.Size = New System.Drawing.Size(776, 313)
		Me.tblInfo.TabIndex = 0
		Me.tblInfo.TableModel = Me.tmodel
		Me.tblInfo.Text = "Table1"
		Me.tblInfo.UnfocusedBorderColor = System.Drawing.Color.Black
		'
		'cmodel
		'
		Me.cmodel.Columns.AddRange(New XPTable.Models.Column() {Me._name, Me._value})
		'
		'_name
		'
		Me._name.ContentWidth = 0
		Me._name.Text = "Name"
		'
		'_value
		'
		Me._value.ContentWidth = 0
		Me._value.Editable = False
		Me._value.Text = "Value"
		'
		'btnCancel
		'
		Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
		Me.btnCancel.Location = New System.Drawing.Point(447, 533)
		Me.btnCancel.Name = "btnCancel"
		Me.btnCancel.Size = New System.Drawing.Size(75, 23)
		Me.btnCancel.TabIndex = 1
		Me.btnCancel.Text = "cancel"
		Me.btnCancel.UseVisualStyleBackColor = True
		'
		'_lbl_info
		'
		Me._lbl_info.Anchor = System.Windows.Forms.AnchorStyles.Bottom
		Me._lbl_info.AutoSize = True
		Me._lbl_info.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lbl_info.ForeColor = System.Drawing.Color.Red
		Me._lbl_info.Location = New System.Drawing.Point(206, 471)
		Me._lbl_info.Name = "_lbl_info"
		Me._lbl_info.Size = New System.Drawing.Size(367, 26)
		Me._lbl_info.TabIndex = 2
		Me._lbl_info.Text = "You can use all the above information in the ""Details"" text info." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "e.g.: [WIDTH] " & _
			"for the width of the video"
		Me._lbl_info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label1
		'
		Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(243, 507)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(279, 13)
		Me.Label1.TabIndex = 3
		Me.Label1.Text = "Blue marked items are currently used in ""Details"" text info."
		'
		'txt_detailtext
		'
		Me.txt_detailtext.AcceptsTab = True
		Me.txt_detailtext.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
					Or System.Windows.Forms.AnchorStyles.Left) _
					Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.txt_detailtext.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txt_detailtext.Location = New System.Drawing.Point(7, 19)
		Me.txt_detailtext.Multiline = True
		Me.txt_detailtext.Name = "txt_detailtext"
		Me.txt_detailtext.ScrollBars = System.Windows.Forms.ScrollBars.Both
		Me.txt_detailtext.Size = New System.Drawing.Size(316, 121)
		Me.txt_detailtext.TabIndex = 11
		Me.txt_detailtext.Text = "Title:" & Global.Microsoft.VisualBasic.ChrW(9) & "[FILE.NAME] - [FILE.SIZE]" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Time:" & Global.Microsoft.VisualBasic.ChrW(9) & "[DURATION]" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Res.:" & Global.Microsoft.VisualBasic.ChrW(9) & "[WIDTH] x [HEIGHT] - [F" & _
			"PS]" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Aspect:" & Global.Microsoft.VisualBasic.ChrW(9) & "[ASPECT.RATIO]" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Video:" & Global.Microsoft.VisualBasic.ChrW(9) & "[CODEC] - [BITRATE]" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Audio:" & Global.Microsoft.VisualBasic.ChrW(9) & "[A.CODEC] - [A.B" & _
			"ITRATE]@[A.SAMPLE]"
		'
		'btn_ok
		'
		Me.btn_ok.Anchor = System.Windows.Forms.AnchorStyles.Bottom
		Me.btn_ok.Location = New System.Drawing.Point(246, 533)
		Me.btn_ok.Name = "btn_ok"
		Me.btn_ok.Size = New System.Drawing.Size(75, 23)
		Me.btn_ok.TabIndex = 12
		Me.btn_ok.Text = "ok"
		Me.btn_ok.UseVisualStyleBackColor = True
		'
		'GroupBox1
		'
		Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.GroupBox1.AutoSize = True
		Me.GroupBox1.Controls.Add(Me.txt_detailtext)
		Me.GroupBox1.Location = New System.Drawing.Point(5, 315)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(329, 150)
		Me.GroupBox1.TabIndex = 13
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Details"
		'
		'GroupBox2
		'
		Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
					Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.GroupBox2.Controls.Add(Me.txt_preview)
		Me.GroupBox2.Location = New System.Drawing.Point(340, 315)
		Me.GroupBox2.Name = "GroupBox2"
		Me.GroupBox2.Size = New System.Drawing.Size(431, 150)
		Me.GroupBox2.TabIndex = 14
		Me.GroupBox2.TabStop = False
		Me.GroupBox2.Text = "Details preview"
		'
		'txt_preview
		'
		Me.txt_preview.AcceptsTab = True
		Me.txt_preview.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
					Or System.Windows.Forms.AnchorStyles.Left) _
					Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.txt_preview.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txt_preview.Location = New System.Drawing.Point(6, 19)
		Me.txt_preview.Multiline = True
		Me.txt_preview.Name = "txt_preview"
		Me.txt_preview.ReadOnly = True
		Me.txt_preview.ScrollBars = System.Windows.Forms.ScrollBars.Both
		Me.txt_preview.Size = New System.Drawing.Size(418, 121)
		Me.txt_preview.TabIndex = 12
		Me.txt_preview.Text = "Title:" & Global.Microsoft.VisualBasic.ChrW(9) & "[FILE.NAME] - [FILE.SIZE]" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Time:" & Global.Microsoft.VisualBasic.ChrW(9) & "[DURATION]" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Res.:" & Global.Microsoft.VisualBasic.ChrW(9) & "[WIDTH] x [HEIGHT] - [F" & _
			"PS]" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Aspect:" & Global.Microsoft.VisualBasic.ChrW(9) & "[ASPECT.RATIO]" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Video:" & Global.Microsoft.VisualBasic.ChrW(9) & "[CODEC] - [BITRATE]" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Audio:" & Global.Microsoft.VisualBasic.ChrW(9) & "[A.CODEC] - [A.B" & _
			"ITRATE]@[A.SAMPLE]"
		'
		'frmMovieInfo
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(776, 568)
		Me.Controls.Add(Me.GroupBox2)
		Me.Controls.Add(Me.GroupBox1)
		Me.Controls.Add(Me.btn_ok)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me._lbl_info)
		Me.Controls.Add(Me.btnCancel)
		Me.Controls.Add(Me.tblInfo)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Name = "frmMovieInfo"
		Me.Text = "frmMovieInfo"
		CType(Me.tblInfo, System.ComponentModel.ISupportInitialize).EndInit()
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.GroupBox2.ResumeLayout(False)
		Me.GroupBox2.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents btnCancel As System.Windows.Forms.Button
	Friend WithEvents tmodel As XPTable.Models.TableModel
	Friend WithEvents cmodel As XPTable.Models.ColumnModel
	Friend WithEvents _name As XPTable.Models.TextColumn
	Friend WithEvents _value As XPTable.Models.TextColumn
	Friend WithEvents _lbl_info As System.Windows.Forms.Label
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents txt_detailtext As System.Windows.Forms.TextBox
	Friend WithEvents btn_ok As System.Windows.Forms.Button
	Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
	Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
	Private WithEvents tblInfo As XPTable.Models.Table
	Friend WithEvents txt_preview As System.Windows.Forms.TextBox
End Class
