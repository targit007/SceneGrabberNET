Imports System.Drawing.Design
Imports System.Drawing.Drawing2D
Imports System.ComponentModel
Imports System.ComponentModel.Design
Imports gCursorLib
Imports gCursorLib.TextShadower

<ToolboxBitmap(GetType(ListView))> _
Public Class gListView
    Inherits ListView

#Region "Initialize"

    Private LineStartPt As Point = New Point(0, 0)
    Private LineEndPt As Point = New Point(0, 0)
    Private LineAbove As Boolean
    Private LineIndex As Integer
    Private DrawPen As Pen = New Pen(Color.Red, 1)
    Private InvRect As Rectangle
    Private OffItems As Boolean = True

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        'gCurrCursor = New gCursor
        Me.OwnerDraw = True
        Me.SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
    End Sub

#End Region 'Initialize

#Region "Scrolling"

    Enum sHorzVert
        Horz
        Vert
    End Enum
    Private scrollHorzVert As sHorzVert
    Private scrollDirection As Integer
    Const SelLVColl As String = _
        "System.Windows.Forms.ListView+SelectedListViewItemCollection"
    Const LVItem As String = _
        "System.Windows.Forms.ListViewItem"

    Private WithEvents ScrollTimer As New Timer
    Private Const WM_HSCROLL As Integer = &H114S
    Private Const WM_VSCROLL As Integer = &H115S

    Private Declare Function SendMessage Lib "user32" Alias "SendMessageA" _
    (ByVal hwnd As Integer, _
     ByVal wMsg As Integer, _
     ByVal wParam As Integer, _
     ByRef lParam As Object) As Integer

    Private Sub ScrollTimer_Tick(ByVal sender As System.Object, _
        ByVal e As System.EventArgs) Handles ScrollTimer.Tick

        Try
            If scrollHorzVert = sHorzVert.Vert Then
                If _gCurrCursor.gScrolling = gCursor.eScrolling.ScrollDn Then
                    ScrollTimer.Interval = 300 - (10 * _
                        (Me.PointToClient(MousePosition).Y - Me.ClientSize.Height))
                ElseIf _gCurrCursor.gScrolling = gCursor.eScrolling.ScrollUp Then
                    ScrollTimer.Interval = 300 + (10 * _
                        (Me.PointToClient(MousePosition).Y - (Me.Font.Height \ 2)))
                End If
            Else
                If _gCurrCursor.gScrolling = gCursor.eScrolling.ScrollRight Then
                    ScrollTimer.Interval = 300 - (10 * _
                        (Me.PointToClient(MousePosition).X - Me.ClientSize.Width))
                ElseIf _gCurrCursor.gScrolling = gCursor.eScrolling.ScrollLeft Then
                    ScrollTimer.Interval = 300 + (10 * _
                        (Me.PointToClient(MousePosition).X))
                End If
            End If
        Catch ex As Exception
        End Try

        If MouseButtons <> System.Windows.Forms.MouseButtons.Left Or
            Me.PointToClient(MousePosition).Y >= Me.ClientSize.Height + 30 Or
            Me.PointToClient(MousePosition).Y <= Me.ClientRectangle.Top - 30 Or
            Me.PointToClient(MousePosition).X <= -40 Or
            Me.PointToClient(MousePosition).X >= Me.ClientSize.Width + 30 _
     Then
            ScrollTimer.Stop()
            _gCurrCursor.gScrolling = gCursor.eScrolling.No
            _gCurrCursor.MakeCursor()
        Else
            ScrollControl(Me, scrollDirection)
        End If

    End Sub

    Private Sub ScrollControl(ByRef objControl As Control, _
        ByRef intDirection As Integer)

        ' For intDirection, a value of 0 scrolls up and 1 scrolls down.
        If scrollHorzVert = sHorzVert.Horz Then
            SendMessage(objControl.Handle.ToInt32, _
                WM_HSCROLL, intDirection, VariantType.Null)
        Else
            SendMessage(objControl.Handle.ToInt32, _
                WM_VSCROLL, intDirection, VariantType.Null)
        End If
    End Sub

#End Region 'Scrolling

#Region "Properties"
    '    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _

    Private _gCurrCursor As gCursor
    <Description("Setup the gCursor")> _
    <Category("Appearance gListView")> _
   Public Property gCurrCursor() As gCursor
        Get
            Return _gCurrCursor
        End Get
        Set(ByVal value As gCursor)
            _gCurrCursor = value
        End Set
    End Property

    Private _gCursorVisible As Boolean = True
    <Description("Use or not use the gCursor")> _
    <Category("Appearance gListView")> _
    Public Property gCursorVisible() As Boolean
        Get
            Return _gCursorVisible
        End Get
        Set(ByVal value As Boolean)
            _gCursorVisible = value
        End Set
    End Property

    Private _DropBarColor As Color = Color.Red
    <Description("Color of the pointer for the insertion point")> _
    <Category("Appearance gListView")> _
   Public Property DropBarColor() As Color
        Get
            Return _DropBarColor
        End Get
        Set(ByVal value As Color)
            _DropBarColor = value
            DrawPen = New Pen(value, 1)
        End Set
    End Property

    Enum eAutoScroll
        None
        All
        Vertical
        Horizontal
    End Enum
    Private _AutoScroll As eAutoScroll = eAutoScroll.Vertical
    <Description("What type of Auto Scroll to use")> _
    <Category("Appearance gListView")> _
    Public Property AutoScroll() As eAutoScroll
        Get
            Return _AutoScroll
        End Get
        Set(ByVal value As eAutoScroll)
            _AutoScroll = value
        End Set
    End Property

    Private _MatchFont As Boolean = True
    <Description("When droping the ListViewItem does it " & _
                 "keep its original font or change to match " & _
                 " this ListView's font")> _
    <Category("Appearance gListView")> _
    Public Property MatchFont() As Boolean
        Get
            Return _MatchFont
        End Get
        Set(ByVal value As Boolean)
            _MatchFont = value
        End Set
    End Property

    Private _ColorRows As Boolean = True
    <Description("Use the ColorRowA and ColorRowB to alternate the color of the rows")> _
    <Category("Appearance gListView")> _
    Public Property ColorRows() As Boolean
        Get
            Return _ColorRows
        End Get
        Set(ByVal value As Boolean)
            _ColorRows = value
            Me.Refresh()
        End Set
    End Property

    Private _ColorRowA As Color = Color.White
    <Category("Appearance gListView")> _
    <Description("When ColorRows = True The Item Color Alternates between ColorRowA and ColorRowB")> _
    Public Property ColorRowA() As Color
        Get
            Return _ColorRowA
        End Get
        Set(ByVal value As Color)
            _ColorRowA = value
        End Set
    End Property

    Private _ColorRowB As Color = Color.Beige
    <Category("Appearance gListView")> _
    <Description("When ColorRows = True The Item Color Alternates between ColorRowA and ColorRowB")> _
    Public Property ColorRowB() As Color
        Get
            Return _ColorRowB
        End Get
        Set(ByVal value As Color)
            _ColorRowB = value
            Invalidate()
        End Set
    End Property

#End Region 'Properties

#Region "OwnerDraw"

    Protected Overrides Sub OnDrawItem(ByVal e As System.Windows.Forms.DrawListViewItemEventArgs)
        MyBase.OnDrawItem(e)

        e.DrawDefault = True
        If _ColorRows Then
            If e.ItemIndex Mod 2 = 0 Then
                e.Item.BackColor = _ColorRowA
            Else
                e.Item.BackColor = _ColorRowB
            End If
        Else
            e.Item.BackColor = Me.BackColor
        End If

    End Sub

    Protected Overrides Sub OnDrawColumnHeader(ByVal e As System.Windows.Forms.DrawListViewColumnHeaderEventArgs)
        MyBase.OnDrawColumnHeader(e)
        e.DrawDefault = True
    End Sub

#End Region 'OwnerDraw

#Region "Drag Drop"

    Private Sub gListView_DragDrop(ByVal sender As Object, _
        ByVal e As System.Windows.Forms.DragEventArgs) Handles Me.DragDrop

        If e.Data.GetDataPresent(SelLVColl, False) _
            Or e.Data.GetDataPresent(LVItem, False) Then

            'Determine where and how to add the item
            Dim insertItem As Boolean = True
            Dim dragItem, dragItem_Clone, InsertAtItem As New ListViewItem
            If Me.Items.Count = 0 Then
                insertItem = False
            Else
                If LineAbove Then
                    InsertAtItem = Me.Items(LineIndex)
                Else
                    If LineIndex + 1 < Me.Items.Count Then
                        InsertAtItem = Me.Items(LineIndex + 1)
                    Else
                        InsertAtItem = Me.Items(LineIndex)
                        insertItem = False
                    End If
                End If
            End If

            Me.BeginUpdate()

            'Flip the view to refresh the indexing
            Dim lvViewState As View = Nothing
            lvViewState = Me.View
            Me.View = View.List

            If e.Data.GetDataPresent(SelLVColl, False) Then
                Dim DragItems As SelectedListViewItemCollection = _
                    CType(e.Data.GetData(SelLVColl), _
                    SelectedListViewItemCollection)
                If Not DragItems.Contains(InsertAtItem) Then
                    For Each dragItem In DragItems
                        dragItem_Clone = CType(dragItem.Clone, ListViewItem)
                        If _MatchFont Then
                            dragItem_Clone.Font = Me.Font
                            dragItem_Clone.ForeColor = Me.ForeColor
                        End If
                        If insertItem = False Then
                            Me.Items.Add(dragItem_Clone)
                        Else
                            Me.Items.Insert(InsertAtItem.Index, dragItem_Clone)
                        End If
                        If e.Effect = DragDropEffects.Move Then
                            dragItem.Remove()
                        End If
                    Next
                End If

            ElseIf e.Data.GetDataPresent(LVItem, False) Then
                dragItem = CType(e.Data.GetData(LVItem), ListViewItem)
                dragItem_Clone = CType(dragItem.Clone, ListViewItem)
                If _MatchFont Then
                    dragItem_Clone.Font = Me.Font
                    dragItem_Clone.ForeColor = Me.ForeColor
                End If
                If insertItem = False Then
                    Me.Items.Add(dragItem_Clone)
                Else
                    Me.Items.Insert(InsertAtItem.Index, dragItem_Clone)
                End If
                If e.Effect = DragDropEffects.Move Then
                    dragItem.Remove()
                End If
            End If

            Me.View = lvViewState
            Me.EndUpdate()
            InsertAtItem.EnsureVisible()
        End If

    End Sub

    Private Sub gListView_DragLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.DragLeave
        Me.Refresh()
    End Sub

    Private Sub gListView_GiveFeedback(ByVal sender As Object, ByVal e As System.Windows.Forms.GiveFeedbackEventArgs) Handles Me.GiveFeedback
        If Not IsNothing(_gCurrCursor) AndAlso _gCursorVisible Then
            e.UseDefaultCursors = False

            If ((e.Effect And DragDropEffects.Copy) = DragDropEffects.Copy) Then
                _gCurrCursor.gEffect = gCursor.eEffect.Copy
            ElseIf ((e.Effect And DragDropEffects.Move) = DragDropEffects.Move) Then
                _gCurrCursor.gEffect = gCursor.eEffect.Move
            Else
                If _gCurrCursor.gEffect <> gCursor.eEffect.No Then
                    _gCurrCursor.gEffect = gCursor.eEffect.No
                End If
            End If

            Cursor.Current = _gCurrCursor.gCursor
        End If
    End Sub

    Private Sub gListView_DragOver(ByVal sender As Object, _
        ByVal e As System.Windows.Forms.DragEventArgs) _
        Handles Me.DragOver

        If e.Data.GetDataPresent(SelLVColl, False) _
          Or e.Data.GetDataPresent(LVItem, False) Then

            If (e.KeyState And 8) = 8 Then
                e.Effect = DragDropEffects.Copy
            Else
                e.Effect = DragDropEffects.Move
            End If

            Dim Mpt As Point = Me.PointToClient(New Point(e.X, e.Y))
            Dim MeItem As ListViewItem
            MeItem = CType(sender, ListView).GetItemAt(Mpt.X, Mpt.Y)

            If Not IsNothing(_gCurrCursor) _
              AndAlso _AutoScroll <> eAutoScroll.None Then
                CheckScroller(Mpt, MeItem, e)
            End If

            If IsNothing(_gCurrCursor) _
              OrElse _gCurrCursor.gScrolling = gCursor.eScrolling.No Then
                PaintPointer(Mpt, MeItem, e)
            End If

        Else
            e.Effect = DragDropEffects.None
        End If

    End Sub

#Region "DragOver Subs"

    Private Sub CheckScroller( _
        ByRef Mpt As Point, _
        ByRef MeItem As ListViewItem, _
        ByRef e As System.Windows.Forms.DragEventArgs)

        Dim ScrollMargin As Padding = New Padding
        If Me.View = System.Windows.Forms.View.Details Then
            ScrollMargin.Top = Me.TopItem.Bounds.Top + 5
        Else
            ScrollMargin.Top = Me.ClientRectangle.Top + 5
        End If
        ScrollMargin.Bottom = Me.ClientSize.Height - 5
        ScrollMargin.Left = 5
        ScrollMargin.Right = Me.ClientSize.Width - 5

        If Mpt.Y <= ScrollMargin.Top _
            AndAlso (_AutoScroll = eAutoScroll.All _
            Or _AutoScroll = eAutoScroll.Vertical) Then

            scrollDirection = 0
            scrollHorzVert = sHorzVert.Vert
            ScrollTimer.Start()
            _gCurrCursor.gScrolling = gCursor.eScrolling.ScrollUp
            e.Effect = DragDropEffects.None
            If IsNothing(MeItem) Then _gCurrCursor.MakeCursor()
            Me.Invalidate(InvRect)

        ElseIf Mpt.Y >= ScrollMargin.Bottom _
            AndAlso (_AutoScroll = eAutoScroll.All _
            Or _AutoScroll = eAutoScroll.Vertical) Then

            scrollDirection = 1
            scrollHorzVert = sHorzVert.Vert
            ScrollTimer.Start()
            _gCurrCursor.gScrolling = gCursor.eScrolling.ScrollDn
            e.Effect = DragDropEffects.None
            If IsNothing(MeItem) Then _gCurrCursor.MakeCursor()
            Me.Invalidate(InvRect)

        ElseIf Mpt.X <= ScrollMargin.Left _
            AndAlso (_AutoScroll = eAutoScroll.All _
            Or _AutoScroll = eAutoScroll.Horizontal) Then

            scrollDirection = 0
            scrollHorzVert = sHorzVert.Horz
            ScrollTimer.Start()
            _gCurrCursor.gScrolling = gCursor.eScrolling.ScrollLeft
            e.Effect = DragDropEffects.None
            If IsNothing(MeItem) Then _gCurrCursor.MakeCursor()
            Me.Invalidate(InvRect)

        ElseIf Mpt.X >= ScrollMargin.Right _
            AndAlso (_AutoScroll = eAutoScroll.All _
            Or _AutoScroll = eAutoScroll.Horizontal) Then

            scrollDirection = 1
            scrollHorzVert = sHorzVert.Horz
            ScrollTimer.Start()
            _gCurrCursor.gScrolling = gCursor.eScrolling.ScrollRight
            e.Effect = DragDropEffects.None
            If IsNothing(MeItem) Then _gCurrCursor.MakeCursor()
            Me.Invalidate(InvRect)

        Else
            _gCurrCursor.gScrolling = gCursor.eScrolling.No
            If ScrollTimer.Enabled Then _gCurrCursor.MakeCursor()
            ScrollTimer.Stop()
        End If
    End Sub

    Private Sub PaintPointer( _
        ByRef Mpt As Point, _
        ByRef MeItem As ListViewItem, _
        ByRef e As System.Windows.Forms.DragEventArgs)

        'Check if the mouse is over an Item
        If IsNothing(MeItem) Then
            'if there are 0 items let it add
            Me.Invalidate(InvRect)
            If Me.Items.Count > 0 Then e.Effect = DragDropEffects.None
            OffItems = True
        Else
            'Get the old pointer area to Invalidate
            If Me.View = System.Windows.Forms.View.LargeIcon Then
                InvRect = New Rectangle(LineStartPt.X - 6, LineStartPt.Y,
                        12, MeItem.Bounds.Height + 15)
            Else
                InvRect = New Rectangle(LineStartPt.X, LineStartPt.Y - 6, _
                        MeItem.Bounds.Width, 13)
            End If

            Dim ItemRect As Rectangle = MeItem.Bounds
            Dim StrtPt As Integer
            Dim LineStartPt_N As Point
            Dim LineEndPt_N As Point
            Dim LineAbove_N As Boolean

            'determine the new pointer location and position
            If Me.View = System.Windows.Forms.View.LargeIcon Then
                If Mpt.X < ItemRect.Left + (ItemRect.Width / 2) Then
                    StrtPt = ItemRect.Left
                    LineAbove_N = True
                Else
                    StrtPt = ItemRect.Right
                    LineAbove_N = False
                End If
                LineStartPt_N = New Point(StrtPt - 1, ItemRect.Top - 1)
                LineEndPt_N = New Point(StrtPt - 1, ItemRect.Bottom - 1)
            Else
                If Mpt.Y < ItemRect.Top + (ItemRect.Height / 2) Then
                    StrtPt = ItemRect.Top
                    LineAbove_N = True
                Else
                    StrtPt = ItemRect.Bottom
                    LineAbove_N = False
                End If
                LineStartPt_N = New Point(ItemRect.Left - 1, StrtPt - 1)
                LineEndPt_N = New Point(ItemRect.Right - 1, StrtPt - 1)
            End If

            'if the Pointer has moved clear the old area and paint a new pointer 
            If LineStartPt_N <> LineStartPt Or OffItems Then
                Me.Invalidate(InvRect)
                Me.Update()
                OffItems = False

                'Set the new position
                LineStartPt = LineStartPt_N
                LineEndPt = LineEndPt_N
                LineAbove = LineAbove_N

                DrawThePointer(ItemRect)

                LineIndex = MeItem.Index
            End If
        End If
    End Sub

    Private Sub DrawThePointer(ByRef ItemRect As Rectangle)
        Using g As Graphics = Me.CreateGraphics
            g.SmoothingMode = SmoothingMode.AntiAlias
            Dim gp As New GraphicsPath
            If Me.View = System.Windows.Forms.View.LargeIcon Then
                Dim mx As New Matrix
                mx.RotateAt(270, New Point(LineStartPt.X, LineStartPt.Y))
                mx.Translate(-ItemRect.Height, 0)
                g.Transform = mx
                mx.Dispose()
            End If

            gp.AddLine( _
                LineStartPt.X, LineStartPt.Y + 5, _
                LineStartPt.X, LineStartPt.Y - 5)
            gp.AddBezier( _
                LineStartPt.X, LineStartPt.Y - 6, _
                LineStartPt.X + 3, LineStartPt.Y - 2, _
                LineStartPt.X + 6, LineStartPt.Y - 1, _
                LineStartPt.X + 11, LineStartPt.Y)
            gp.AddBezier( _
                LineStartPt.X + 11, LineStartPt.Y, _
                LineStartPt.X + 6, LineStartPt.Y + 1, _
                LineStartPt.X + 3, LineStartPt.Y + 2, _
                LineStartPt.X, LineStartPt.Y + 6)
            gp.CloseFigure()
            g.FillPath(New SolidBrush(DrawPen.Color), gp)
            gp.Dispose()

            g.ResetTransform()
            If Me.View = System.Windows.Forms.View.LargeIcon Then
                Dim mx As New Matrix
                mx.RotateAt(180, New Point(LineStartPt.X, LineStartPt.Y))
                mx.Translate(0, -ItemRect.Height)
                g.Transform = mx
                mx.Dispose()

            End If

            DrawPen.Brush = New Drawing2D.LinearGradientBrush(LineStartPt, _
                Point.Add(LineEndPt, New Size(1, 1)), _
                DrawPen.Color, Color.Transparent)
            g.DrawLine(DrawPen, LineStartPt, LineEndPt)
        End Using
    End Sub

#End Region 'DragOver Subs

#End Region 'Drag Drop

End Class

