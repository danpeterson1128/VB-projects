<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HealthProfileTest
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
        Me.displayButton = New System.Windows.Forms.Button()
        Me.outputTextBox = New System.Windows.Forms.TextBox()
        Me.currentYearTextBox = New System.Windows.Forms.TextBox()
        Me.birthYearTextBox = New System.Windows.Forms.TextBox()
        Me.lastNameTextBox = New System.Windows.Forms.TextBox()
        Me.firstNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.heightTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.weightTextBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.genderTextBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'displayButton
        '
        Me.displayButton.Location = New System.Drawing.Point(15, 250)
        Me.displayButton.Name = "displayButton"
        Me.displayButton.Size = New System.Drawing.Size(178, 23)
        Me.displayButton.TabIndex = 7
        Me.displayButton.Text = "Display Heart Rate Information"
        Me.displayButton.UseVisualStyleBackColor = True
        '
        'outputTextBox
        '
        Me.outputTextBox.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.outputTextBox.Location = New System.Drawing.Point(199, 12)
        Me.outputTextBox.Multiline = True
        Me.outputTextBox.Name = "outputTextBox"
        Me.outputTextBox.Size = New System.Drawing.Size(324, 261)
        Me.outputTextBox.TabIndex = 18
        '
        'currentYearTextBox
        '
        Me.currentYearTextBox.Location = New System.Drawing.Point(93, 128)
        Me.currentYearTextBox.Name = "currentYearTextBox"
        Me.currentYearTextBox.Size = New System.Drawing.Size(100, 23)
        Me.currentYearTextBox.TabIndex = 4
        '
        'birthYearTextBox
        '
        Me.birthYearTextBox.Location = New System.Drawing.Point(93, 99)
        Me.birthYearTextBox.Name = "birthYearTextBox"
        Me.birthYearTextBox.Size = New System.Drawing.Size(100, 23)
        Me.birthYearTextBox.TabIndex = 3
        '
        'lastNameTextBox
        '
        Me.lastNameTextBox.Location = New System.Drawing.Point(93, 41)
        Me.lastNameTextBox.Name = "lastNameTextBox"
        Me.lastNameTextBox.Size = New System.Drawing.Size(100, 23)
        Me.lastNameTextBox.TabIndex = 1
        '
        'firstNameTextBox
        '
        Me.firstNameTextBox.Location = New System.Drawing.Point(93, 12)
        Me.firstNameTextBox.Name = "firstNameTextBox"
        Me.firstNameTextBox.Size = New System.Drawing.Size(100, 23)
        Me.firstNameTextBox.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 15)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Current year:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 15)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Birth year:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 15)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Last name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 15)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "First name:"
        '
        'heightTextBox
        '
        Me.heightTextBox.Location = New System.Drawing.Point(93, 157)
        Me.heightTextBox.Name = "heightTextBox"
        Me.heightTextBox.Size = New System.Drawing.Size(100, 23)
        Me.heightTextBox.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 160)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 15)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Height (in):"
        '
        'weightTextBox
        '
        Me.weightTextBox.Location = New System.Drawing.Point(93, 186)
        Me.weightTextBox.Name = "weightTextBox"
        Me.weightTextBox.Size = New System.Drawing.Size(100, 23)
        Me.weightTextBox.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 189)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 15)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Weight (lbs):"
        '
        'genderTextBox
        '
        Me.genderTextBox.Location = New System.Drawing.Point(93, 70)
        Me.genderTextBox.Name = "genderTextBox"
        Me.genderTextBox.Size = New System.Drawing.Size(100, 23)
        Me.genderTextBox.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(39, 73)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 15)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Gender:"
        '
        'HealthProfileTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(535, 285)
        Me.Controls.Add(Me.genderTextBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.weightTextBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.heightTextBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.displayButton)
        Me.Controls.Add(Me.outputTextBox)
        Me.Controls.Add(Me.currentYearTextBox)
        Me.Controls.Add(Me.birthYearTextBox)
        Me.Controls.Add(Me.lastNameTextBox)
        Me.Controls.Add(Me.firstNameTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "HealthProfileTest"
        Me.Text = "Dan Peterson Lab Exam: Health Records by  YOUR NAME"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents displayButton As System.Windows.Forms.Button
   Friend WithEvents outputTextBox As System.Windows.Forms.TextBox
   Friend WithEvents currentYearTextBox As System.Windows.Forms.TextBox
   Friend WithEvents birthYearTextBox As System.Windows.Forms.TextBox
   Friend WithEvents lastNameTextBox As System.Windows.Forms.TextBox
   Friend WithEvents firstNameTextBox As System.Windows.Forms.TextBox
   Friend WithEvents Label4 As System.Windows.Forms.Label
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents heightTextBox As System.Windows.Forms.TextBox
   Friend WithEvents Label5 As System.Windows.Forms.Label
   Friend WithEvents weightTextBox As System.Windows.Forms.TextBox
   Friend WithEvents Label6 As System.Windows.Forms.Label
   Friend WithEvents genderTextBox As System.Windows.Forms.TextBox
   Friend WithEvents Label7 As System.Windows.Forms.Label

End Class
