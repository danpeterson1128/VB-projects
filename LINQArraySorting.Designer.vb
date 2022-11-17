<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LINQArraySorting
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
        Me.queryTwoTextBox = New System.Windows.Forms.TextBox()
        Me.sortedDescendingLabel = New System.Windows.Forms.Label()
        Me.displayButton = New System.Windows.Forms.Button()
        Me.createButton = New System.Windows.Forms.Button()
        Me.queryOneTextBox = New System.Windows.Forms.TextBox()
        Me.originalTextBox = New System.Windows.Forms.TextBox()
        Me.sortedAscendingLabel = New System.Windows.Forms.Label()
        Me.originalLabel = New System.Windows.Forms.Label()
        Me.queryThreeTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.queryFourTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'queryTwoTextBox
        '
        Me.queryTwoTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.queryTwoTextBox.Location = New System.Drawing.Point(229, 34)
        Me.queryTwoTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.queryTwoTextBox.Multiline = True
        Me.queryTwoTextBox.Name = "queryTwoTextBox"
        Me.queryTwoTextBox.Size = New System.Drawing.Size(100, 193)
        Me.queryTwoTextBox.TabIndex = 23
        Me.queryTwoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'sortedDescendingLabel
        '
        Me.sortedDescendingLabel.AutoSize = True
        Me.sortedDescendingLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sortedDescendingLabel.Location = New System.Drawing.Point(226, 14)
        Me.sortedDescendingLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.sortedDescendingLabel.Name = "sortedDescendingLabel"
        Me.sortedDescendingLabel.Size = New System.Drawing.Size(100, 15)
        Me.sortedDescendingLabel.TabIndex = 22
        Me.sortedDescendingLabel.Text = "Descending order"
        '
        'displayButton
        '
        Me.displayButton.Enabled = False
        Me.displayButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.displayButton.Location = New System.Drawing.Point(289, 243)
        Me.displayButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.displayButton.Name = "displayButton"
        Me.displayButton.Size = New System.Drawing.Size(130, 23)
        Me.displayButton.TabIndex = 21
        Me.displayButton.Text = "Display"
        '
        'createButton
        '
        Me.createButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.createButton.Location = New System.Drawing.Point(138, 243)
        Me.createButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.createButton.Name = "createButton"
        Me.createButton.Size = New System.Drawing.Size(130, 23)
        Me.createButton.TabIndex = 20
        Me.createButton.Text = "Create Random Data"
        '
        'queryOneTextBox
        '
        Me.queryOneTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.queryOneTextBox.Location = New System.Drawing.Point(121, 34)
        Me.queryOneTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.queryOneTextBox.Multiline = True
        Me.queryOneTextBox.Name = "queryOneTextBox"
        Me.queryOneTextBox.Size = New System.Drawing.Size(100, 193)
        Me.queryOneTextBox.TabIndex = 19
        Me.queryOneTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'originalTextBox
        '
        Me.originalTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.originalTextBox.Location = New System.Drawing.Point(13, 34)
        Me.originalTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.originalTextBox.Multiline = True
        Me.originalTextBox.Name = "originalTextBox"
        Me.originalTextBox.Size = New System.Drawing.Size(100, 193)
        Me.originalTextBox.TabIndex = 18
        Me.originalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'sortedAscendingLabel
        '
        Me.sortedAscendingLabel.AutoSize = True
        Me.sortedAscendingLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sortedAscendingLabel.Location = New System.Drawing.Point(118, 14)
        Me.sortedAscendingLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.sortedAscendingLabel.Name = "sortedAscendingLabel"
        Me.sortedAscendingLabel.Size = New System.Drawing.Size(94, 15)
        Me.sortedAscendingLabel.TabIndex = 17
        Me.sortedAscendingLabel.Text = "Ascending order"
        '
        'originalLabel
        '
        Me.originalLabel.AutoSize = True
        Me.originalLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.originalLabel.Location = New System.Drawing.Point(13, 14)
        Me.originalLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.originalLabel.Name = "originalLabel"
        Me.originalLabel.Size = New System.Drawing.Size(85, 15)
        Me.originalLabel.TabIndex = 16
        Me.originalLabel.Text = "Original values"
        '
        'queryThreeTextBox
        '
        Me.queryThreeTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.queryThreeTextBox.Location = New System.Drawing.Point(337, 34)
        Me.queryThreeTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.queryThreeTextBox.Multiline = True
        Me.queryThreeTextBox.Name = "queryThreeTextBox"
        Me.queryThreeTextBox.Size = New System.Drawing.Size(100, 193)
        Me.queryThreeTextBox.TabIndex = 24
        Me.queryThreeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(337, 14)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 15)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Even numbers"
        '
        'queryFourTextBox
        '
        Me.queryFourTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.queryFourTextBox.Location = New System.Drawing.Point(445, 34)
        Me.queryFourTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.queryFourTextBox.Multiline = True
        Me.queryFourTextBox.Name = "queryFourTextBox"
        Me.queryFourTextBox.Size = New System.Drawing.Size(100, 193)
        Me.queryFourTextBox.TabIndex = 26
        Me.queryFourTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(445, 14)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 15)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "40 - 49"
        '
        'LINQArraySorting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(559, 280)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.queryFourTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.queryThreeTextBox)
        Me.Controls.Add(Me.queryTwoTextBox)
        Me.Controls.Add(Me.sortedDescendingLabel)
        Me.Controls.Add(Me.displayButton)
        Me.Controls.Add(Me.createButton)
        Me.Controls.Add(Me.queryOneTextBox)
        Me.Controls.Add(Me.originalTextBox)
        Me.Controls.Add(Me.sortedAscendingLabel)
        Me.Controls.Add(Me.originalLabel)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "LINQArraySorting"
        Me.Text = "Dan Peterson: LINQ"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents queryTwoTextBox As System.Windows.Forms.TextBox
   Friend WithEvents sortedDescendingLabel As System.Windows.Forms.Label
   Friend WithEvents displayButton As System.Windows.Forms.Button
   Friend WithEvents createButton As System.Windows.Forms.Button
   Friend WithEvents queryOneTextBox As System.Windows.Forms.TextBox
   Friend WithEvents originalTextBox As System.Windows.Forms.TextBox
   Friend WithEvents sortedAscendingLabel As System.Windows.Forms.Label
   Friend WithEvents originalLabel As System.Windows.Forms.Label
    Friend WithEvents queryThreeTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents queryFourTextBox As TextBox
    Friend WithEvents Label2 As Label
End Class
