<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StoreSurveyResponses
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
        Me.closeFileButton = New System.Windows.Forms.Button()
        Me.selectFileButton = New System.Windows.Forms.Button()
        Me.submitResponseButton = New System.Windows.Forms.Button()
        Me.responseTextBox = New System.Windows.Forms.TextBox()
        Me.enterGradeLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'closeFileButton
        '
        Me.closeFileButton.Enabled = False
        Me.closeFileButton.Location = New System.Drawing.Point(80, 100)
        Me.closeFileButton.Name = "closeFileButton"
        Me.closeFileButton.Size = New System.Drawing.Size(188, 23)
        Me.closeFileButton.TabIndex = 20
        Me.closeFileButton.Text = "Close File"
        Me.closeFileButton.UseVisualStyleBackColor = True
        '
        'selectFileButton
        '
        Me.selectFileButton.Location = New System.Drawing.Point(79, 12)
        Me.selectFileButton.Name = "selectFileButton"
        Me.selectFileButton.Size = New System.Drawing.Size(189, 23)
        Me.selectFileButton.TabIndex = 19
        Me.selectFileButton.Text = "Select File to Store Responses"
        Me.selectFileButton.UseVisualStyleBackColor = True
        '
        'submitResponseButton
        '
        Me.submitResponseButton.Enabled = False
        Me.submitResponseButton.Location = New System.Drawing.Point(80, 70)
        Me.submitResponseButton.Name = "submitResponseButton"
        Me.submitResponseButton.Size = New System.Drawing.Size(189, 23)
        Me.submitResponseButton.TabIndex = 18
        Me.submitResponseButton.Text = "Submit Response"
        Me.submitResponseButton.UseVisualStyleBackColor = True
        '
        'responseTextBox
        '
        Me.responseTextBox.Location = New System.Drawing.Point(210, 41)
        Me.responseTextBox.Name = "responseTextBox"
        Me.responseTextBox.Size = New System.Drawing.Size(58, 23)
        Me.responseTextBox.TabIndex = 16
        '
        'enterGradeLabel
        '
        Me.enterGradeLabel.AutoSize = True
        Me.enterGradeLabel.Location = New System.Drawing.Point(77, 44)
        Me.enterGradeLabel.Name = "enterGradeLabel"
        Me.enterGradeLabel.Size = New System.Drawing.Size(127, 15)
        Me.enterGradeLabel.TabIndex = 17
        Me.enterGradeLabel.Text = "Enter response (1 to 5):"
        '
        'StoreSurveyResponses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(349, 134)
        Me.Controls.Add(Me.closeFileButton)
        Me.Controls.Add(Me.selectFileButton)
        Me.Controls.Add(Me.submitResponseButton)
        Me.Controls.Add(Me.responseTextBox)
        Me.Controls.Add(Me.enterGradeLabel)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "StoreSurveyResponses"
        Me.Text = "Dan Peterson: Store Survey Responses"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents closeFileButton As System.Windows.Forms.Button
   Friend WithEvents selectFileButton As System.Windows.Forms.Button
   Friend WithEvents submitResponseButton As System.Windows.Forms.Button
   Friend WithEvents responseTextBox As System.Windows.Forms.TextBox
   Friend WithEvents enterGradeLabel As System.Windows.Forms.Label

End Class
