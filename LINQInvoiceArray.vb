Public Class LINQInvoiceArray

    Private Sub displayButton_Click(sender As Object, e As EventArgs) Handles displayButton.Click

        '*** initialize array of invoices
        Dim invoices() As Invoice = {
            New Invoice(83, "Electric sander", 7, 57.98),
            New Invoice(24, "Power saw", 18, 19.99),
            New Invoice(7, "Sledge hammer", 11, 21.5),
            New Invoice(77, "Hammer", 76, 11.99),
            New Invoice(39, "Lawn mower", 3, 79.5),
            New Invoice(68, "Screwdriver", 106, 6.99),
            New Invoice(56, "Jig saw", 21, 11.0),
            New Invoice(3, "Wrench", 34, 7.5)}


        '*** use LINQ to sort invoices by description
        Dim descriptionSorted =
            From element In invoices
            Order By element.partDescription
            Select element



        '*** display invoices, sorted by description
        outputTextBox.AppendText("Invoices sorted by description" & vbCrLf)
        For Each element In descriptionSorted
            outputTextBox.AppendText(element.ToString & vbCrLf)
        Next



        '*** use LINQ to sort invoices by price
        Dim priceSorted =
            From element In invoices
            Order By element.Price
            Select element



        '*** display invoices, sorted by price
        outputTextBox.AppendText(vbCrLf & "Invoices sorted by price" & vbCrLf)
        For Each element In priceSorted
            outputTextBox.AppendText(element.ToString & vbCrLf)
        Next



        '*** use LINQ to select description and quantity, sort by quantity
        Dim qSorted =
            From element In invoices
            Order By element.Quantity
            Select element.partDescription, element.Quantity




        '*** display description and quantity, sorted by quantity
        outputTextBox.AppendText(vbCrLf & "Select Description and quantity, sort by quantity" & vbCrLf)
        For Each element In qSorted
            outputTextBox.AppendText(element.ToString & vbCrLf)
        Next



        '*** use LINQ to select description and calculated
        '   invoice total; sort by invoice total
        Dim totalsorted =
            From element In invoices
            Select element.partDescription, invoicetotal = element.Quantity * element.Price
            Order By invoicetotal





        '*** display description and calculated invoice total
        outputTextBox.AppendText(vbCrLf & "Select description and invoice total, sort by invoice total: " & vbCrLf)
        For Each element In totalsorted
            outputTextBox.AppendText(element.ToString & vbCrLf)
        Next



        '*** use LINQ to filter previous query results on range of totals
        Dim rangesort =
            From element In invoices
            Select element.partDescription, invoicetotal = element.Quantity * element.Price
            Where (invoicetotal >= 200 AndAlso invoicetotal <= 500)
            Order By invoicetotal






        '*** display filtered descriptions and invoice totals
        outputTextBox.AppendText(vbCrLf & "Invoice totals between $200.00 and $500.00" & vbCrLf)
        For Each element In rangesort
            outputTextBox.AppendText(element.ToString & vbCrLf)
        Next



    End Sub
End Class
