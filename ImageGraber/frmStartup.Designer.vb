<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStartup
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
		Me.Panel1 = New System.Windows.Forms.Panel
		Me.txt_text = New System.Windows.Forms.RichTextBox
		Me.OKButton = New System.Windows.Forms.Button
		Me.lbl_donate1 = New System.Windows.Forms.Label
		Me.lbl_donate2 = New System.Windows.Forms.Label
		Me.Panel1.SuspendLayout()
		Me.SuspendLayout()
		'
		'Panel1
		'
		Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Panel1.Controls.Add(Me.txt_text)
		Me.Panel1.Location = New System.Drawing.Point(1, 3)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(330, 246)
		Me.Panel1.TabIndex = 1
		'
		'txt_text
		'
		Me.txt_text.BackColor = System.Drawing.SystemColors.ButtonHighlight
		Me.txt_text.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.txt_text.Dock = System.Windows.Forms.DockStyle.Fill
		Me.txt_text.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txt_text.HideSelection = False
		Me.txt_text.Location = New System.Drawing.Point(0, 0)
		Me.txt_text.Name = "txt_text"
		Me.txt_text.ReadOnly = True
		Me.txt_text.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
		Me.txt_text.ShortcutsEnabled = False
		Me.txt_text.Size = New System.Drawing.Size(328, 244)
		Me.txt_text.TabIndex = 1
		Me.txt_text.Text = ""
		'
		'OKButton
		'
		Me.OKButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.OKButton.Location = New System.Drawing.Point(128, 257)
		Me.OKButton.Name = "OKButton"
		Me.OKButton.Size = New System.Drawing.Size(75, 22)
		Me.OKButton.TabIndex = 8
		Me.OKButton.Text = "&OK"
		'
		'lbl_donate1
		'
		Me.lbl_donate1.AutoSize = True
		Me.lbl_donate1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbl_donate1.ForeColor = System.Drawing.SystemColors.Highlight
		Me.lbl_donate1.Location = New System.Drawing.Point(15, 262)
		Me.lbl_donate1.Margin = New System.Windows.Forms.Padding(6, 0, 3, 0)
		Me.lbl_donate1.MaximumSize = New System.Drawing.Size(0, 17)
		Me.lbl_donate1.Name = "lbl_donate1"
		Me.lbl_donate1.Size = New System.Drawing.Size(58, 13)
		Me.lbl_donate1.TabIndex = 7
		Me.lbl_donate1.Text = "DONATE"
		Me.lbl_donate1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'lbl_donate2
		'
		Me.lbl_donate2.AutoSize = True
		Me.lbl_donate2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbl_donate2.ForeColor = System.Drawing.SystemColors.Highlight
		Me.lbl_donate2.Location = New System.Drawing.Point(263, 262)
		Me.lbl_donate2.Margin = New System.Windows.Forms.Padding(6, 0, 3, 0)
		Me.lbl_donate2.MaximumSize = New System.Drawing.Size(0, 17)
		Me.lbl_donate2.Name = "lbl_donate2"
		Me.lbl_donate2.Size = New System.Drawing.Size(58, 13)
		Me.lbl_donate2.TabIndex = 9
		Me.lbl_donate2.Text = "DONATE"
		Me.lbl_donate2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'frmStartup
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(333, 291)
		Me.Controls.Add(Me.lbl_donate2)
		Me.Controls.Add(Me.lbl_donate1)
		Me.Controls.Add(Me.OKButton)
		Me.Controls.Add(Me.Panel1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "frmStartup"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "frmStartup"
		Me.Panel1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents Panel1 As System.Windows.Forms.Panel
	Friend WithEvents txt_text As System.Windows.Forms.RichTextBox
	Friend WithEvents OKButton As System.Windows.Forms.Button
	Friend WithEvents lbl_donate1 As System.Windows.Forms.Label
	Friend WithEvents lbl_donate2 As System.Windows.Forms.Label
End Class
