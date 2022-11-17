<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClassAverage
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.closeFileButton = New System.Windows.Forms.Button()
        Me.selectFileButton = New System.Windows.Forms.Button()
        Me.submitGradeButton = New System.Windows.Forms.Button()
        Me.gradeTextBox = New System.Windows.Forms.TextBox()
        Me.enterGradeLabel = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.openFileButton = New System.Windows.Forms.Button()
        Me.clearGradesButton = New System.Windows.Forms.Button()
        Me.classAverageLabel = New System.Windows.Forms.Label()
        Me.resultsLabel = New System.Windows.Forms.Label()
        Me.calculateAverageButton = New System.Windows.Forms.Button()
        Me.gradesListBox = New System.Windows.Forms.ListBox()
        Me.gradesLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.closeFileButton)
        Me.GroupBox1.Controls.Add(Me.selectFileButton)
        Me.GroupBox1.Controls.Add(Me.submitGradeButton)
        Me.GroupBox1.Controls.Add(Me.gradeTextBox)
        Me.GroupBox1.Controls.Add(Me.enterGradeLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(203, 144)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Store Grades in a File"
        '
        'closeFileButton
        '
        Me.closeFileButton.Enabled = False
        Me.closeFileButton.Location = New System.Drawing.Point(7, 110)
        Me.closeFileButton.Name = "closeFileButton"
        Me.closeFileButton.Size = New System.Drawing.Size(188, 23)
        Me.closeFileButton.TabIndex = 15
        Me.closeFileButton.Text = "Close File"
        Me.closeFileButton.UseVisualStyleBackColor = True
        '
        'selectFileButton
        '
        Me.selectFileButton.Location = New System.Drawing.Point(6, 22)
        Me.selectFileButton.Name = "selectFileButton"
        Me.selectFileButton.Size = New System.Drawing.Size(189, 23)
        Me.selectFileButton.TabIndex = 14
        Me.selectFileButton.Text = "Select File to Store Grades"
        Me.selectFileButton.UseVisualStyleBackColor = True
        '
        'submitGradeButton
        '
        Me.submitGradeButton.Enabled = False
        Me.submitGradeButton.Location = New System.Drawing.Point(7, 80)
        Me.submitGradeButton.Name = "submitGradeButton"
        Me.submitGradeButton.Size = New System.Drawing.Size(189, 23)
        Me.submitGradeButton.TabIndex = 13
        Me.submitGradeButton.Text = "Submit Grade"
        Me.submitGradeButton.UseVisualStyleBackColor = True
        '
        'gradeTextBox
        '
        Me.gradeTextBox.Location = New System.Drawing.Point(79, 51)
        Me.gradeTextBox.Name = "gradeTextBox"
        Me.gradeTextBox.Size = New System.Drawing.Size(116, 23)
        Me.gradeTextBox.TabIndex = 11
        '
        'enterGradeLabel
        '
        Me.enterGradeLabel.AutoSize = True
        Me.enterGradeLabel.Location = New System.Drawing.Point(4, 54)
        Me.enterGradeLabel.Name = "enterGradeLabel"
        Me.enterGradeLabel.Size = New System.Drawing.Size(70, 15)
        Me.enterGradeLabel.TabIndex = 12
        Me.enterGradeLabel.Text = "Enter grade:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.openFileButton)
        Me.GroupBox2.Controls.Add(Me.clearGradesButton)
        Me.GroupBox2.Controls.Add(Me.classAverageLabel)
        Me.GroupBox2.Controls.Add(Me.resultsLabel)
        Me.GroupBox2.Controls.Add(Me.calculateAverageButton)
        Me.GroupBox2.Controls.Add(Me.gradesListBox)
        Me.GroupBox2.Controls.Add(Me.gradesLabel)
        Me.GroupBox2.Location = New System.Drawing.Point(221, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(264, 232)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Calculate Class Average"
        '
        'openFileButton
        '
        Me.openFileButton.Location = New System.Drawing.Point(69, 22)
        Me.openFileButton.Name = "openFileButton"
        Me.openFileButton.Size = New System.Drawing.Size(188, 23)
        Me.openFileButton.TabIndex = 17
        Me.openFileButton.Text = "Select File Containing Grades"
        Me.openFileButton.UseVisualStyleBackColor = True
        '
        'clearGradesButton
        '
        Me.clearGradesButton.Enabled = False
        Me.clearGradesButton.Location = New System.Drawing.Point(69, 153)
        Me.clearGradesButton.Name = "clearGradesButton"
        Me.clearGradesButton.Size = New System.Drawing.Size(189, 23)
        Me.clearGradesButton.TabIndex = 13
        Me.clearGradesButton.Text = "Clear Grades"
        Me.clearGradesButton.UseVisualStyleBackColor = True
        '
        'classAverageLabel
        '
        Me.classAverageLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.classAverageLabel.Location = New System.Drawing.Point(69, 104)
        Me.classAverageLabel.Name = "classAverageLabel"
        Me.classAverageLabel.Size = New System.Drawing.Size(188, 36)
        Me.classAverageLabel.TabIndex = 16
        Me.classAverageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'resultsLabel
        '
        Me.resultsLabel.AutoSize = True
        Me.resultsLabel.Location = New System.Drawing.Point(66, 84)
        Me.resultsLabel.Name = "resultsLabel"
        Me.resultsLabel.Size = New System.Drawing.Size(47, 15)
        Me.resultsLabel.TabIndex = 15
        Me.resultsLabel.Text = "Results:"
        '
        'calculateAverageButton
        '
        Me.calculateAverageButton.Enabled = False
        Me.calculateAverageButton.Location = New System.Drawing.Point(69, 54)
        Me.calculateAverageButton.Name = "calculateAverageButton"
        Me.calculateAverageButton.Size = New System.Drawing.Size(189, 23)
        Me.calculateAverageButton.TabIndex = 11
        Me.calculateAverageButton.Text = "Calculate Average"
        Me.calculateAverageButton.UseVisualStyleBackColor = True
        '
        'gradesListBox
        '
        Me.gradesListBox.FormattingEnabled = True
        Me.gradesListBox.ItemHeight = 15
        Me.gradesListBox.Location = New System.Drawing.Point(6, 41)
        Me.gradesListBox.Name = "gradesListBox"
        Me.gradesListBox.Size = New System.Drawing.Size(47, 184)
        Me.gradesListBox.TabIndex = 12
        '
        'gradesLabel
        '
        Me.gradesLabel.AutoSize = True
        Me.gradesLabel.Location = New System.Drawing.Point(3, 22)
        Me.gradesLabel.Name = "gradesLabel"
        Me.gradesLabel.Size = New System.Drawing.Size(46, 15)
        Me.gradesLabel.TabIndex = 14
        Me.gradesLabel.Text = "Grades:"
        '
        'ClassAverage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(497, 253)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "ClassAverage"
        Me.Text = "YOUR NAME: Class Average"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
   Friend WithEvents selectFileButton As System.Windows.Forms.Button
   Friend WithEvents submitGradeButton As System.Windows.Forms.Button
   Friend WithEvents gradeTextBox As System.Windows.Forms.TextBox
   Friend WithEvents enterGradeLabel As System.Windows.Forms.Label
   Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
   Friend WithEvents clearGradesButton As System.Windows.Forms.Button
   Friend WithEvents classAverageLabel As System.Windows.Forms.Label
   Friend WithEvents resultsLabel As System.Windows.Forms.Label
   Friend WithEvents calculateAverageButton As System.Windows.Forms.Button
   Friend WithEvents gradesListBox As System.Windows.Forms.ListBox
   Friend WithEvents gradesLabel As System.Windows.Forms.Label
   Friend WithEvents closeFileButton As System.Windows.Forms.Button
   Friend WithEvents openFileButton As System.Windows.Forms.Button

End Class
