Namespace My

    ' The following events are available for MyApplication:
    ' 
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.
    Partial Friend Class MyApplication

        Private Sub MyApplication_Shutdown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shutdown
            My.Settings.Save()
        End Sub

        Private Sub MyApplication_Startup(ByVal sender As Object, ByVal e As Microsoft.VisualBasic.ApplicationServices.StartupEventArgs) Handles Me.Startup
            'TimeBomb check
            If (Util.isTimeBombExpired) Then
				Dim res As MsgBoxResult = MsgBox("Your Version of Scenegrabber.NET is expired." + vbCrLf + vbCrLf + "Please visit homepage " + Util.URL_HOME + " for a new Version !", MsgBoxStyle.YesNo, Util.APP_TITLE)
                If res = MsgBoxResult.Yes Then
                    System.Diagnostics.Process.Start(Util.URL_UPDATE)        
                End If
                Environment.Exit(0)
			Else
				'First Start check
				If (My.Settings.firststart) Then
					Try
                        Configuration.getInstance.createIntial()

						My.Settings.firststart = False
						My.Settings.Save()
						'Show Welcome Message
						frmStartup.ShowDialog()

					Catch ex As Exception
						MsgBox("Internal Error. Plz contact info@scenegrabber.net")
					End Try
                Else
                    'Update Check
                    If (My.Settings.updatecheck AndAlso Util.newVersionIsOut()) Then
                        Dim res As MsgBoxResult = MsgBox("A new Version of Scenegrabber.NET is out." + vbCrLf + vbCrLf + "Visit homepage " + Util.URL_HOME + " ?", MsgBoxStyle.YesNo, Util.APP_TITLE)
                        If res = MsgBoxResult.Yes Then
                            System.Diagnostics.Process.Start(Util.URL_UPDATE)
                            Environment.Exit(0)
                        End If
                    End If
				End If
			End If

            ProfileManager.getInstance.checkForCorrectDefaultProfile()

            'Command Line Support
            'If (e.CommandLine.Count > 0) Then
            'If (e.CommandLine(0) = "/?" Or e.CommandLine.Count = 1) Then
            'Util.notImplemented()





            'End If
            'Environment.Exit(0)
            'End If



        End Sub
    End Class

End Namespace

