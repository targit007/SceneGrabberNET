Public Class frmStartup
	

	Public Sub New()

		' This call is required by the Windows Form Designer.
		InitializeComponent()

		' Add any initialization after the InitializeComponent() call.

		Me.Text = Util.APP_TITLE
		setVersionText(My.Application.Info.Version)
		Me.txt_text.TabStop = False
	End Sub


	Private Sub setVersionText(ByVal version As Version)
		Dim text As String = ""
		'text += vbCrLf
		text += "welcome to the first startup of SceneGrabber.NET"
        If (version.ToString = "0.9.3.6") Then
            text += vbCrLf + vbCrLf
            text += "new features:" + vbCrLf + vbCrLf
            text += "- using profiles" + vbCrLf
            text += "- mplayer support" + vbCrLf
            text += vbCrLf
            text += "bug fixes: " + vbCrLf + vbCrLf
            text += "- some bugfixes " + vbCrLf
            text += vbCrLf
            text += "IMPORTANT: SceneGrabber.NET need beta-tester" + vbCrLf + vbCrLf
            text += "- for infos plz contact info@scenegrabber.net" + vbCrLf
            text += vbCrLf
            text += "and dont forget to support SceneGrabber.NET :)"

        End If
		Me.txt_text.Text = text
	End Sub

	Private Sub _Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_donate1.MouseClick, lbl_donate2.MouseClick
		Cursor = Cursors.WaitCursor
		System.Diagnostics.Process.Start(Util.URL_DONATE)
		Cursor = Cursors.Default
	End Sub

	Private Sub _MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbl_donate1.MouseHover, lbl_donate2.MouseHover
		Cursor = Cursors.Hand
	End Sub

	Private Sub _MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbl_donate1.MouseLeave, lbl_donate2.MouseLeave
		Cursor = Cursors.Default
	End Sub

	Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
		Me.Close()
	End Sub
End Class