Imports XPTable.Models

Public Class frmMovieInfo

    Private _movieInfo As MovieInfo
    Private _configuration As Configuration
    
	Private oldDetailText As String

    Public Sub New(ByVal movieInfo As MovieInfo, ByRef configuration As Configuration)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.SuspendLayout()
        ' Add any initialization after the InitializeComponent() call.
        Me._movieInfo = movieInfo
        Me._configuration = configuration

        fillTModel()

        Me.cmodel.Columns(0).Width = Me.tblInfo.Width / 2 - 11
        Me.cmodel.Columns(1).Width = Me.tblInfo.Width / 2 - 11

        If Me._movieInfo Is Nothing Then
            Me.Text = "Movieinfo"
        Else
            Me.Text = "Movieinfo - " + Me._movieInfo.getFileName + " (" + Me._movieInfo.getCompleteName + ")"
        End If

        oldDetailText = _configuration.detailtext

        txt_detailtext.Text = oldDetailText

        updatePreviewText()
        Me.ResumeLayout()
    End Sub

	Private Sub updatePreviewText() Handles txt_detailtext.TextChanged
		If Not Me._movieInfo Is Nothing Then
			txt_preview.Text = _movieInfo.evaluatePattern(txt_detailtext.Text)
		Else
			txt_preview.Text = txt_detailtext.Text
		End If
		refreshTModel()
	End Sub

	Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        _configuration.detailtext = oldDetailText
		Me.Close()

	End Sub


    Private Sub fillTModel()

        If Not _movieInfo Is Nothing Then
            Dim dic As Dictionary(Of String, String) = _movieInfo.getAttributes

            For Each key As String In dic.Keys
                If _configuration.detailtext.Contains("[" + key + "]") Then
                    Dim r As Row = New Row(New String() {key, dic.Item(key)})
					markTableRowWithColor(r)
                    Me.tmodel.Rows.Add(r)
                End If
            Next
            For Each key As String In dic.Keys
                If Not _configuration.detailtext.Contains("[" + key + "]") Then
                    Dim r As Row = New Row(New String() {key, dic.Item(key)})
					markTableRowWithColor(r)
					Me.tmodel.Rows.Add(r)
                End If
            Next
        End If
	End Sub

	Private Sub markTableRowWithColor(ByVal r As Row)
		Dim colText As String = r.Cells(0).Text
		If txt_detailtext.Text.Contains("[" + colText + "]") Then
			r.BackColor = Color.LightBlue
		Else
			r.BackColor = Color.White
		End If
	End Sub

	Private Sub refreshTModel()
		For Each r As Row In Me.tmodel.Rows
			markTableRowWithColor(r)
		Next
	End Sub


	Private Sub frmMovieInfo_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
		Me.cmodel.Columns(0).Width = Me.tblInfo.Width / 2 - 11
		Me.cmodel.Columns(1).Width = Me.tblInfo.Width / 2 - 11
	End Sub


	Private Sub btn_ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ok.Click
        _configuration.detailtext = txt_detailtext.Text
		Me.Close()
	End Sub

	Private Sub tblInfo_CelldoubleClick(ByVal sender As Object, ByVal e As XPTable.Events.CellMouseEventArgs) Handles tblInfo.CellDoubleClick
		Me.SuspendLayout()
		Dim c As Cell = tblInfo.TableModel.Rows(e.Row).Cells(0)
		Dim text As String = c.Text
		If Not String.IsNullOrEmpty(text) Then
			Dim start As Integer = txt_detailtext.SelectionStart
			Dim length As Integer = txt_detailtext.SelectionLength
			If start > 0 Then
				Dim leftString As String = txt_detailtext.Text.Substring(0, start)
				Dim rightString As String = txt_detailtext.Text.Substring(start + length)
				txt_detailtext.Text = leftString + "[" + text + "]" + rightString
				txt_detailtext.SelectionStart = start + text.Length + 2
			Else
				txt_detailtext.Text = txt_detailtext.Text + "[" + text + "]"
				txt_detailtext.SelectionStart = txt_detailtext.Text.Length
			End If

			refreshTModel()
		End If
		Me.ResumeLayout()
	End Sub

End Class