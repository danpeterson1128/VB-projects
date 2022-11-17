<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DuplicateElimination
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
        Me.countLabel = New System.Windows.Forms.Label()
        Me.outputTextBox = New System.Windows.Forms.TextBox()
        Me.numbersEnteredLabel = New System.Windows.Forms.Label()
        Me.okButton = New System.Windows.Forms.Button()
        Me.numberTextBox = New System.Windows.Forms.TextBox()
        Me.numberLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'countLabel
        '
        Me.countLabel.AutoSize = True
        Me.countLabel.Location = New System.Drawing.Point(118, 52)
        Me.countLabel.Name = "countLabel"
        Me.countLabel.Size = New System.Drawing.Size(0, 15)
        Me.countLabel.TabIndex = 23
        '
        'outputTextBox
        '
        Me.outputTextBox.Location = New System.Drawing.Point(16, 70)
        Me.outputTextBox.Multiline = True
        Me.outputTextBox.Name = "outputTextBox"
        Me.outputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.outputTextBox.Size = New System.Drawing.Size(277, 176)
        Me.outputTextBox.TabIndex = 22
        '
        'numbersEnteredLabel
        '
        Me.numbersEnteredLabel.AutoSize = True
        Me.numbersEnteredLabel.Location = New System.Drawing.Point(13, 52)
        Me.numbersEnteredLabel.Name = "numbersEnteredLabel"
        Me.numbersEnteredLabel.Size = New System.Drawing.Size(99, 15)
        Me.numbersEnteredLabel.TabIndex = 21
        Me.numbersEnteredLabel.Text = "Numbers entered"
        '
        'okButton
        '
        Me.okButton.Location = New System.Drawing.Point(207, 12)
        Me.okButton.Name = "okButton"
        Me.okButton.Size = New System.Drawing.Size(86, 23)
        Me.okButton.TabIndex = 20
        Me.okButton.Text = "OK"
        '
        'numberTextBox
        '
        Me.numberTextBox.Location = New System.Drawing.Point(101, 12)
        Me.numberTextBox.Name = "numberTextBox"
        Me.numberTextBox.Size = New System.Drawing.Size(100, 23)
        Me.numberTextBox.TabIndex = 19
        '
        'numberLabel
        '
        Me.numberLabel.AutoSize = True
        Me.numberLabel.Location = New System.Drawing.Point(13, 15)
        Me.numberLabel.Name = "numberLabel"
        Me.numberLabel.Size = New System.Drawing.Size(82, 15)
        Me.numberLabel.TabIndex = 18
        Me.numberLabel.Text = "Enter number:"
        '
        'DuplicateElimination
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(307, 260)
        Me.Controls.Add(Me.countLabel)
        Me.Controls.Add(Me.outputTextBox)
        Me.Controls.Add(Me.numbersEnteredLabel)
        Me.Controls.Add(Me.okButton)
        Me.Controls.Add(Me.numberTextBox)
        Me.Controls.Add(Me.numberLabel)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "DuplicateElimination"
        Me.Text = "Dan Peterson: Duplicate Elimination"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents countLabel As System.Windows.Forms.Label
   Friend WithEvents outputTextBox As System.Windows.Forms.TextBox
   Friend WithEvents numbersEnteredLabel As System.Windows.Forms.Label
   Friend WithEvents okButton As System.Windows.Forms.Button
   Friend WithEvents numberTextBox As System.Windows.Forms.TextBox
   Friend WithEvents numberLabel As System.Windows.Forms.Label

End Class
