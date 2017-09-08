Public Class frmShowScene

    Private Event resetView()

	Private _sceneshot As Sceneshot
    Public Property Sceneshot() As Sceneshot
        Get
            Return _sceneshot
        End Get
        Set(ByVal value As Sceneshot)
            _sceneshot = value
            RaiseEvent resetView()
        End Set
    End Property

    Private Sub frmShowScene_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Chr(27) Then
            Me.Close()
        End If
    End Sub


	Private Sub _resetView() Handles Me.resetView

		pbox.Image = Sceneshot.image
		pbox.Width = Sceneshot.image.Width
		pbox.Height = Sceneshot.image.Height
		Me.ClientSize = New System.Drawing.Size(Sceneshot.image.Width, Sceneshot.image.Height)
		Me.Text = Sceneshot.label
		Me.BringToFront()
	End Sub

    Private Sub pbox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbox.Click
        Me.Close()
    End Sub
End Class