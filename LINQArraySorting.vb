Public Class LINQArraySorting

    Dim integerArray(9) As Integer

    ' creates random generated numbers
    Private Sub createButton_Click(sender As Object, e As EventArgs) Handles createButton.Click

        Dim randomNumber As New Random()

        '*** clear all textboxes
        originalTextBox.Clear()
        queryOneTextBox.Clear()
        queryTwoTextBox.Clear()
        queryThreeTextBox.Clear()
        queryFourTextBox.Clear()




        '*** For loop to create 10 random numbers (0-99) and 
        '   display them in the originalTextBox
        For i = 0 To integerArray.GetUpperBound(0)
            integerArray(i) = randomNumber.Next(100)
            originalTextBox.AppendText(integerArray(i) & vbCrLf)
        Next


        '*** enable Display button
        displayButton.Enabled = True



    End Sub

    ' sorts randomly generated numbers
    Private Sub sortButton_Click(sender As Object, e As EventArgs) Handles displayButton.Click

        '*** use LINQ to sort array in ascending order
        Dim sorted =
            From value In integerArray
            Order By value
            Select value


        '*** use For Each to display the query results in the queryOneTextBox
        For Each element In sorted
            queryOneTextBox.AppendText(element & vbCrLf)
        Next


        '*** use LINQ to sort array in descending order
        Dim dSorted =
            From value In integerArray
            Order By value Descending
            Select value


        '*** use For Each to display the query results in the queryTwoTextBox
        For Each element In dSorted
            queryTwoTextBox.AppendText(element & vbCrLf)
        Next


        '*** use LINQ to select unique even numbers from integerArray
        Dim evenSorted =
            From value In integerArray
            Where (value Mod 2 = 0)
            Select value


        '*** use For Each to display the query results in the queryThreeTextBox
        For Each element In evenSorted
            queryThreeTextBox.AppendText(element & vbCrLf)
        Next


        '*** use LINQ to select 40-49 (no duplication) 
        Dim selectSorted =
            From value In integerArray
            Where (value > 39 And value < 50)
            Select value
            Distinct


        '*** use For Each to display the qury results in the queryFourTextBox
        For Each element In selectSorted
            queryFourTextBox.AppendText(element & vbCrLf)
        Next


        displayButton.Enabled = False ' disable Display Button
        createButton.Focus() ' set focus to the Create Random Data Button
    End Sub
End Class
