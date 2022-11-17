Public Class SortArray
    Dim integerArray(9) As Integer
    Dim randomNumber As New Random()
    ' create an array for 10 elements
    ' create a random object 

    Private Sub createDataButton_Click(sender As Object, e As EventArgs) Handles createDataButton.Click
        originalValuesListBox.Items.Clear()
        ascendingValuesListBox.Items.Clear()
        descendingValuesListBox.Items.Clear()
        For i = 0 To 9
            integerArray(i) = randomNumber.Next(100)
            originalValuesListBox.Items.Add(integerArray(i))
        Next
        sortButton.Enabled = True

        '-->createDataButton_Click
        ' clear originalValuesListBox
        ' clear sortedValuesListBox
        ' clear descendingValuesListBox
        ' create 10 random numbers between 0 and 99 
        '   (see the coding example in Fig 6.10, p.208) and append to output 
        ' enable Sort button 

    End Sub

    Private Sub sortButton_Click(sender As Object, e As EventArgs) Handles sortButton.Click
        Array.Sort(integerArray)
        For i = 0 To 9
            ascendingValuesListBox.Items.Add(integerArray(i))
        Next
        Array.Reverse(integerArray)
        For i = 0 To 9
            descendingValuesListBox.Items.Add(integerArray(i))
        Next
        sortButton.Enabled = False
        '-->sortButton_Click
        ' sorts and displays randomly generated numbers in ascending order 
        '   by using Array.Sort (see the coding example in Fig 7.12, p.258)
        ' sorts and displays them in descending order by using Array.Reverse
        ' disable Sort button
    End Sub




End Class
