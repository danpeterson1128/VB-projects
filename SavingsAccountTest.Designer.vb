<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SavingsAccountTest
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
        Me.outputTextBox = New System.Windows.Forms.TextBox()
        Me.displayButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'outputTextBox
        '
        Me.outputTextBox.Location = New System.Drawing.Point(12, 12)
        Me.outputTextBox.Multiline = True
        Me.outputTextBox.Name = "outputTextBox"
        Me.outputTextBox.Size = New System.Drawing.Size(307, 278)
        Me.outputTextBox.TabIndex = 1
        '
        'displayButton
        '
        Me.displayButton.Location = New System.Drawing.Point(76, 307)
        Me.displayButton.Name = "displayButton"
        Me.displayButton.Size = New System.Drawing.Size(178, 23)
        Me.displayButton.TabIndex = 2
        Me.displayButton.Text = "Display"
        Me.displayButton.UseVisualStyleBackColor = True
        '
        'SavingsAccountTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(331, 351)
        Me.Controls.Add(Me.displayButton)
        Me.Controls.Add(Me.outputTextBox)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "SavingsAccountTest"
        Me.Text = "Dan Peterson: Savings Account"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents outputTextBox As System.Windows.Forms.TextBox
    Friend WithEvents displayButton As Button
End Class
