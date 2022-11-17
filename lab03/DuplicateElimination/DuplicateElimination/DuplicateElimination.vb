Public Class DuplicateElimination
    Dim inputArray(9) As Integer
    Dim count As Integer

    Private Sub okButton_Click(sender As Object, e As EventArgs) Handles okButton.Click
        Dim input As Integer = Convert.ToInt32(numberTextBox.Text)
        numberTextBox.Clear()
        numberTextBox.Focus()
        If input < 1 Or input > 10 Then
            MessageBox.Show("Please enter a number from 1 to 10",
                            "Invalid Input", MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        Else
            count = count + 1
            countLabel.Text = Convert.ToString(count)

            If isNewNumber(input) Then
                outputTextBox.AppendText(input & vbNewLine)

                If count <= inputArray.Length Then
                    inputArray(count - 1) = input
                End If

            End If
            If count > inputArray.Length Then
                MessageBox.Show("You have entered more than 10 numbers", "done")
                okButton.Enabled = False
                countLabel.Text = Convert.ToString(count - 1)
            End If
        End If

    End Sub

    Private Function isNewNumber(input As Integer) As Boolean
        For i = 0 To inputArray.GetUpperBound(0)
            If input = inputArray(i) Then
                Return False
            End If
        Next
        Return True
    End Function
    ' get input
    ' validate that input is within boundary (1 < input < 10)
    '   update display 
    '       display input
    '       If unique Then (Using a Function), add To array
    '       check if count > inputs.Lenght
    '       then disply message (you have entered more than 10 numbers)

    ' a function to check if number is already in the array
    '   if number already exists in array return false
    '   if not in the array, return true

End Class