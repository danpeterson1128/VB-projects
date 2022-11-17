<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChildForm
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
        Me.inputRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'inputRichTextBox
        '
        Me.inputRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.inputRichTextBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.inputRichTextBox.Location = New System.Drawing.Point(0, 0)
        Me.inputRichTextBox.Name = "inputRichTextBox"
        Me.inputRichTextBox.Size = New System.Drawing.Size(349, 358)
        Me.inputRichTextBox.TabIndex = 1
        Me.inputRichTextBox.Text = ""
        '
        'ChildForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(349, 358)
        Me.Controls.Add(Me.inputRichTextBox)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "ChildForm"
        Me.Text = "Dan Peterson: Text File"
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents inputRichTextBox As System.Windows.Forms.RichTextBox
End Class
