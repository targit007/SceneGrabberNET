Imports System.Windows.Forms

Public Class frmChangeLabel

    Private _label As String

    Public Property Label() As String
        Get
            Return _label
        End Get
        Set(ByVal value As String)
            _label = value
        End Set
    End Property



    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Public Sub New(ByVal label As String)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _label = label

        Me._txtbox.DataBindings.Add(New Binding("text", Me, "label", False, DataSourceUpdateMode.OnPropertyChanged))

        Me._txtbox.Focus()
    End Sub

    Private Sub frmChangeLabel_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus
        Me._txtbox.SelectAll()
    End Sub

    Private Sub frmChangeLabel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me._txtbox.SelectAll()
    End Sub

    Private Sub _txtbox_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles _txtbox.Enter
        Me._txtbox.SelectAll()
    End Sub

End Class
