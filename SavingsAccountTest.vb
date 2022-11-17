Public Class SavingsAccountTest
    Private Sub displayButton_Click(sender As Object, e As EventArgs) Handles displayButton.Click
        '*** create savings accounts
        Dim saver1 As New SavingsAccount(2000D)
        Dim saver2 As New SavingsAccount(3000D)


        '*** display balances of saver1 and saver2
        outputTextBox.Text = ("Opening Balances: " & vbCrLf)
        outputTextBox.AppendText("saver1: " & FormatCurrency(saver1.Balance) & vbCrLf)
        outputTextBox.AppendText("saver2: " & FormatCurrency(saver2.Balance) & vbCrLf)

        '*** set and display interest rate at 0.04
        '   by using shared method and variable\
        SavingsAccount.annualInterestRate = 0.04


        '*** calculate and display monthly interest earned
        '   and display new balances
        outputTextBox.AppendText("Interest Rate: " & SavingsAccount.annualInterestRate & vbCrLf)
        outputTextBox.AppendText("Interest Earned:" & vbCrLf)
        outputTextBox.AppendText("saver1: " & FormatCurrency(saver1.CalculateMonthlyInterest) & vbCrLf)
        outputTextBox.AppendText("saver2: " & FormatCurrency(saver2.CalculateMonthlyInterest) & vbCrLf)
        outputTextBox.AppendText("New balances" & vbCrLf)
        outputTextBox.AppendText("saver1: " & FormatCurrency(saver1.Balance) & vbCrLf)
        outputTextBox.AppendText("saver2: " & FormatCurrency(saver2.Balance) & vbCrLf)

        '*** set and display interest rate at 0.05
        '   by using shared method and variable
        SavingsAccount.annualInterestRate = 0.05


        '*** calculate and display monthly interest earned
        '   and display new balances
        outputTextBox.AppendText("Interest Rate: " & SavingsAccount.annualInterestRate & vbCrLf)
        outputTextBox.AppendText("Interest Earned:" & vbCrLf)
        outputTextBox.AppendText("saver1: " & FormatCurrency(saver1.CalculateMonthlyInterest) & vbCrLf)
        outputTextBox.AppendText("saver2: " & FormatCurrency(saver2.CalculateMonthlyInterest) & vbCrLf)
        outputTextBox.AppendText("New balances" & vbCrLf)
        outputTextBox.AppendText("saver1: " & FormatCurrency(saver1.Balance) & vbCrLf)
        outputTextBox.AppendText("saver2: " & FormatCurrency(saver2.Balance) & vbCrLf)
    End Sub
End Class

