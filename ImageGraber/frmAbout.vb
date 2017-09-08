Public NotInheritable Class frmAbout

    Private Sub frmAbout_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Set the title of the form.
        Dim ApplicationTitle As String
        If My.Application.Info.Title <> "" Then
            ApplicationTitle = My.Application.Info.Title
        Else
            ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
		Me.Text = String.Format("About {0}", Util.APP_TITLE)
        ' Initialize all of the text displayed on the About Box.
        ' TODO: Customize the application's assembly information in the "Application" pane of the project 
        '    properties dialog (under the "Project" menu).
        Me.LabelProductName.Text = My.Application.Info.ProductName
		Me.LabelVersion.Text = String.Format("Version: {0}", My.Application.Info.Version.ToString)
        Me.LabelCopyright.Text = My.Application.Info.Copyright + " by targit"
		Me.LabelCompanyName.Text = Util.URL_HOME
		Me.regid.Text = "Reg.Id:"
		Me.txt_reg_id.Text = Util.getRegistrationId
    End Sub

	Private Sub LabelCompanyName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LabelCompanyName.MouseClick
		Cursor = Cursors.WaitCursor
        System.Diagnostics.Process.Start(Util.URL_HOME)
		Cursor = Cursors.Default
	End Sub

	Private Sub LabelCompanyName_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles LabelCompanyName.MouseHover
		Cursor = Cursors.Hand
	End Sub

	Private Sub LabelCompanyName_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles LabelCompanyName.MouseLeave
		Cursor = Cursors.Default
	End Sub

	Private Sub OKButton_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
		Me.Close()
	End Sub

End Class
