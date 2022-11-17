' Implementing the child text editor windows for an MDI application.
Public Class ChildForm
    '*** input property
    Public Property input() As RichTextBox
        Get
            Return inputRichTextBox
        End Get
        Set(value As RichTextBox)
            inputRichTextBox = value
        End Set
    End Property


    '*** intializes header method
    Public Sub initializeHeader(count As Integer)
        Me.Text &= " " & count
    End Sub

End Class
