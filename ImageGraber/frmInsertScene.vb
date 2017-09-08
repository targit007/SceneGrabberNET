Public Class frmInsertScene
    Public Enum EnumInsertionType
        replace = 0
        before = 1
        after = 2
        none = 3
    End Enum

    Private _insertionType As EnumInsertionType

    Public ReadOnly Property InsertionType() As EnumInsertionType
        Get
            Return _insertionType
        End Get
    End Property


    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _insertionType = EnumInsertionType.replace
        replace.Checked = True
        after.Checked = False
        before.Checked = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        If (after.Checked) Then
            _insertionType = EnumInsertionType.after
        ElseIf (before.Checked) Then
            _insertionType = EnumInsertionType.before
        ElseIf (replace.Checked) Then
            _insertionType = EnumInsertionType.replace
        End If
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        _insertionType = EnumInsertionType.none
        Me.Close()
    End Sub
End Class