<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ParentForm
   Inherits System.Windows.Forms.Form

   'Form overrides dispose to clean up the component list.
   <System.Diagnostics.DebuggerNonUserCode()> _
   Protected Overrides Sub Dispose(disposing As Boolean)
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
        Me.oneMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.fileMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.formatMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.windowMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.sizeMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.fontMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.colorMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.timesMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.sansSerifMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.arialMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.courierMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.blackMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.redMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.yellowMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.greenMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.blueMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.orangeMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.purpleMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pinkMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.size8MenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.size10MenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.size12MenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.size14MenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.size16MenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.size18MenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.newMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.closeMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.exitMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tileMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cascadeMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tileHorizontallyMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tileVerticallyMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.oneMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'oneMenuStrip
        '
        Me.oneMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.fileMenuItem, Me.formatMenuItem, Me.windowMenuItem})
        Me.oneMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.oneMenuStrip.Name = "oneMenuStrip"
        Me.oneMenuStrip.Size = New System.Drawing.Size(465, 24)
        Me.oneMenuStrip.TabIndex = 2
        Me.oneMenuStrip.Text = "menuStrip1"
        '
        'fileMenuItem
        '
        Me.fileMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.newMenuItem, Me.closeMenuItem, Me.exitMenuItem})
        Me.fileMenuItem.Name = "fileMenuItem"
        Me.fileMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.fileMenuItem.Text = "File"
        '
        'formatMenuItem
        '
        Me.formatMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.sizeMenuItem, Me.fontMenuItem, Me.colorMenuItem})
        Me.formatMenuItem.Name = "formatMenuItem"
        Me.formatMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.formatMenuItem.Text = "Format"
        '
        'windowMenuItem
        '
        Me.windowMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tileMenuItem})
        Me.windowMenuItem.Name = "windowMenuItem"
        Me.windowMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.windowMenuItem.Text = "Window"
        '
        'sizeMenuItem
        '
        Me.sizeMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.size8MenuItem, Me.size10MenuItem, Me.size12MenuItem, Me.size14MenuItem, Me.size16MenuItem, Me.size18MenuItem})
        Me.sizeMenuItem.Name = "sizeMenuItem"
        Me.sizeMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.sizeMenuItem.Text = "Size"
        '
        'fontMenuItem
        '
        Me.fontMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.timesMenuItem, Me.sansSerifMenuItem, Me.arialMenuItem, Me.courierMenuItem})
        Me.fontMenuItem.Name = "fontMenuItem"
        Me.fontMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.fontMenuItem.Text = "Font"
        '
        'colorMenuItem
        '
        Me.colorMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.blackMenuItem, Me.redMenuItem, Me.yellowMenuItem, Me.greenMenuItem, Me.blueMenuItem, Me.orangeMenuItem, Me.purpleMenuItem, Me.pinkMenuItem})
        Me.colorMenuItem.Name = "colorMenuItem"
        Me.colorMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.colorMenuItem.Text = "Color"
        '
        'timesMenuItem
        '
        Me.timesMenuItem.Name = "timesMenuItem"
        Me.timesMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.timesMenuItem.Text = "Times"
        '
        'sansSerifMenuItem
        '
        Me.sansSerifMenuItem.Name = "sansSerifMenuItem"
        Me.sansSerifMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.sansSerifMenuItem.Text = "MS Sans Serif"
        '
        'arialMenuItem
        '
        Me.arialMenuItem.Name = "arialMenuItem"
        Me.arialMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.arialMenuItem.Text = "Arial"
        '
        'courierMenuItem
        '
        Me.courierMenuItem.Name = "courierMenuItem"
        Me.courierMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.courierMenuItem.Text = "Courier New"
        '
        'blackMenuItem
        '
        Me.blackMenuItem.Name = "blackMenuItem"
        Me.blackMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.blackMenuItem.Text = "Black"
        '
        'redMenuItem
        '
        Me.redMenuItem.Name = "redMenuItem"
        Me.redMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.redMenuItem.Text = "Red"
        '
        'yellowMenuItem
        '
        Me.yellowMenuItem.Name = "yellowMenuItem"
        Me.yellowMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.yellowMenuItem.Text = "Yellow"
        '
        'greenMenuItem
        '
        Me.greenMenuItem.Name = "greenMenuItem"
        Me.greenMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.greenMenuItem.Text = "Green"
        '
        'blueMenuItem
        '
        Me.blueMenuItem.Name = "blueMenuItem"
        Me.blueMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.blueMenuItem.Text = "Blue"
        '
        'orangeMenuItem
        '
        Me.orangeMenuItem.Name = "orangeMenuItem"
        Me.orangeMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.orangeMenuItem.Text = "Orange"
        '
        'purpleMenuItem
        '
        Me.purpleMenuItem.Name = "purpleMenuItem"
        Me.purpleMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.purpleMenuItem.Text = "Purple"
        '
        'pinkMenuItem
        '
        Me.pinkMenuItem.Name = "pinkMenuItem"
        Me.pinkMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.pinkMenuItem.Text = "Pink"
        '
        'size8MenuItem
        '
        Me.size8MenuItem.Name = "size8MenuItem"
        Me.size8MenuItem.Size = New System.Drawing.Size(152, 22)
        Me.size8MenuItem.Text = "8"
        '
        'size10MenuItem
        '
        Me.size10MenuItem.Name = "size10MenuItem"
        Me.size10MenuItem.Size = New System.Drawing.Size(152, 22)
        Me.size10MenuItem.Text = "10"
        '
        'size12MenuItem
        '
        Me.size12MenuItem.Name = "size12MenuItem"
        Me.size12MenuItem.Size = New System.Drawing.Size(152, 22)
        Me.size12MenuItem.Text = "12"
        '
        'size14MenuItem
        '
        Me.size14MenuItem.Name = "size14MenuItem"
        Me.size14MenuItem.Size = New System.Drawing.Size(152, 22)
        Me.size14MenuItem.Text = "14"
        '
        'size16MenuItem
        '
        Me.size16MenuItem.Name = "size16MenuItem"
        Me.size16MenuItem.Size = New System.Drawing.Size(152, 22)
        Me.size16MenuItem.Text = "16"
        '
        'size18MenuItem
        '
        Me.size18MenuItem.Name = "size18MenuItem"
        Me.size18MenuItem.Size = New System.Drawing.Size(152, 22)
        Me.size18MenuItem.Text = "18"
        '
        'newMenuItem
        '
        Me.newMenuItem.Name = "newMenuItem"
        Me.newMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.newMenuItem.Text = "New"
        '
        'closeMenuItem
        '
        Me.closeMenuItem.Name = "closeMenuItem"
        Me.closeMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.closeMenuItem.Text = "Close"
        '
        'exitMenuItem
        '
        Me.exitMenuItem.Name = "exitMenuItem"
        Me.exitMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.exitMenuItem.Text = "Exit"
        '
        'tileMenuItem
        '
        Me.tileMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cascadeMenuItem, Me.tileHorizontallyMenuItem, Me.tileVerticallyMenuItem})
        Me.tileMenuItem.Name = "tileMenuItem"
        Me.tileMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.tileMenuItem.Text = "Tile"
        '
        'cascadeMenuItem
        '
        Me.cascadeMenuItem.Name = "cascadeMenuItem"
        Me.cascadeMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.cascadeMenuItem.Text = "Cascade"
        '
        'tileHorizontallyMenuItem
        '
        Me.tileHorizontallyMenuItem.Name = "tileHorizontallyMenuItem"
        Me.tileHorizontallyMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.tileHorizontallyMenuItem.Text = "Tile Horizontally"
        '
        'tileVerticallyMenuItem
        '
        Me.tileVerticallyMenuItem.Name = "tileVerticallyMenuItem"
        Me.tileVerticallyMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.tileVerticallyMenuItem.Text = "Tile Vertically"
        '
        'ParentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(465, 465)
        Me.Controls.Add(Me.oneMenuStrip)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IsMdiContainer = True
        Me.Name = "ParentForm"
        Me.Text = "Dan Peterson: Text Editor"
        Me.oneMenuStrip.ResumeLayout(False)
        Me.oneMenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents oneMenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents fileMenuItem As ToolStripMenuItem
    Friend WithEvents newMenuItem As ToolStripMenuItem
    Friend WithEvents closeMenuItem As ToolStripMenuItem
    Friend WithEvents exitMenuItem As ToolStripMenuItem
    Friend WithEvents formatMenuItem As ToolStripMenuItem
    Friend WithEvents sizeMenuItem As ToolStripMenuItem
    Friend WithEvents size8MenuItem As ToolStripMenuItem
    Friend WithEvents size10MenuItem As ToolStripMenuItem
    Friend WithEvents size12MenuItem As ToolStripMenuItem
    Friend WithEvents size14MenuItem As ToolStripMenuItem
    Friend WithEvents size16MenuItem As ToolStripMenuItem
    Friend WithEvents size18MenuItem As ToolStripMenuItem
    Friend WithEvents fontMenuItem As ToolStripMenuItem
    Friend WithEvents timesMenuItem As ToolStripMenuItem
    Friend WithEvents sansSerifMenuItem As ToolStripMenuItem
    Friend WithEvents arialMenuItem As ToolStripMenuItem
    Friend WithEvents courierMenuItem As ToolStripMenuItem
    Friend WithEvents colorMenuItem As ToolStripMenuItem
    Friend WithEvents blackMenuItem As ToolStripMenuItem
    Friend WithEvents redMenuItem As ToolStripMenuItem
    Friend WithEvents yellowMenuItem As ToolStripMenuItem
    Friend WithEvents greenMenuItem As ToolStripMenuItem
    Friend WithEvents blueMenuItem As ToolStripMenuItem
    Friend WithEvents orangeMenuItem As ToolStripMenuItem
    Friend WithEvents purpleMenuItem As ToolStripMenuItem
    Friend WithEvents pinkMenuItem As ToolStripMenuItem
    Friend WithEvents windowMenuItem As ToolStripMenuItem
    Friend WithEvents tileMenuItem As ToolStripMenuItem
    Friend WithEvents cascadeMenuItem As ToolStripMenuItem
    Friend WithEvents tileHorizontallyMenuItem As ToolStripMenuItem
    Friend WithEvents tileVerticallyMenuItem As ToolStripMenuItem
End Class
