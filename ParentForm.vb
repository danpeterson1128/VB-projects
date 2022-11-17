' Implementing a MDI text editor.
Imports System.Drawing
Public Class ParentForm
    Private childCount As Integer

    '*** handles click on New
    Private Sub newMenuItem_Click(sender As Object, e As EventArgs) Handles newMenuItem.Click
        Dim child As ChildForm = New ChildForm()
        child.MdiParent = Me
        child.Show()
        childCount += 1
        child.InitializeHeader(childCount)
    End Sub

    '*** handles click on Close 
    Private Sub closeMenuItem_Click(sender As Object, e As EventArgs) Handles closeMenuItem.Click
        Me.ActiveMdiChild.Close()
    End Sub

    '*** handles click on Exit (see Fig 14.25 for coding example)
    Private Sub exitMenuItem_Click(sender As Object, e As EventArgs) Handles exitMenuItem.Click
        Application.Exit()
    End Sub

    ' change font size depending on the MenuItem selected
    Private Sub sizeMenuItem_Click(sender As Object, e As EventArgs) Handles size8MenuItem.Click,
        size10MenuItem.Click, size12MenuItem.Click, size14MenuItem.Click, size16MenuItem.Click, size18MenuItem.Click

        '*** determine which child is active
        Dim current As ChildForm = CType(Me.ActiveMdiChild, ChildForm)


        '*** modify the font of that child
        current.input.Font = New Font(current.input.Font.FontFamily, Convert.ToInt32(sender.ToString()))



        '*** clear checks next to size MenuItems
        size8MenuItem.Checked = False
        size10MenuItem.Checked = False
        size12MenuItem.Checked = False
        size14MenuItem.Checked = False
        size16MenuItem.Checked = False
        size18MenuItem.Checked = False

        '*** place a check next to the right MenuItem
        CType(sender, ToolStripMenuItem).Checked = True
    End Sub

    ' sets font depending on the MenuItem selected
    Private Sub fontMenuItem_Click(sender As Object, e As EventArgs) Handles timesMenuItem.Click,
        sansSerifMenuItem.Click, arialMenuItem.Click, courierMenuItem.Click

        '*** determine which child is active
        Dim current As ChildForm = CType(Me.ActiveMdiChild, ChildForm)

        '*** modify the font of that child
        current.input.Font = New Font(sender.ToString(), current.input.Font.Size)

        '*** clear checks next to font MenuItems
        timesMenuItem.Checked = False
        arialMenuItem.Checked = False
        courierMenuItem.Checked = False
        sansSerifMenuItem.Checked = False

        '*** place a check next to the right MenuItem
        CType(sender, ToolStripMenuItem).Checked = True
    End Sub

    ' set font color depending on the MenuItem selected
    Private Sub colorMenuItem_Click(sender As Object, e As EventArgs) Handles blackMenuItem.Click,
      redMenuItem.Click, yellowMenuItem.Click, greenMenuItem.Click, blueMenuItem.Click, orangeMenuItem.Click, purpleMenuItem.Click,
      pinkMenuItem.Click

        '*** determine which child is active
        Dim current As ChildForm = CType(Me.ActiveMdiChild, ChildForm)


        '*** modify font color
        current.input.ForeColor = Color.FromName(sender.ToString())

        '*** clear checks next to the color MenuItems
        blackMenuItem.Checked = False
        redMenuItem.Checked = False
        yellowMenuItem.Checked = False
        greenMenuItem.Checked = False
        blueMenuItem.Checked = False
        orangeMenuItem.Checked = False
        purpleMenuItem.Checked = False
        pinkMenuItem.Checked = False


        '*** place a check next to the right MenuItem
        CType(sender, ToolStripMenuItem).Checked = True


    End Sub

    '*** set cascade layout (see Fig 14.42 for coding example)
    Private Sub cascadeMenuItem_Click(sender As Object, e As EventArgs) Handles cascadeMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub ' cascadeMenuItem_Click

    '*** set TileHorizontal layout (see Fig 14.42 for coding example)
    Private Sub tileHorizontallyMenuItem_Click(sender As Object, e As EventArgs) Handles tileHorizontallyMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    '*** set TileVertical layout (see Fig 14.42 for coding example)
    Private Sub tileVerticallyMenuItem_Click(sender As Object, e As EventArgs) Handles tileVerticallyMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub
End Class

