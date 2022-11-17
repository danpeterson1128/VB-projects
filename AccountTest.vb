
Public Class AccountTest

    '*** create Account object(account1): initial balace $50
    '*** create SavingsAccount object (account2): initial balance $25, interest rate 3%
    '*** create CheckingAccount objects (account3): initial balance $80, charge fee $1
    Dim account1 As New Account(50)
    Dim account2 As New SavingsAccount(25, 0.03)
    Dim account3 As New CheckingAccount(80, 1)


    Private Sub displayButton_Click(sender As Object, e As EventArgs) Handles displayButton.Click

        DisplayBalance() ' display initial balance of each object

        ' debit from accounts
        outputTextBox.AppendText("Attempting to debit $25.00 from account1" & vbCrLf)
        account1.Debit(25D) ' try to debit $25.00 from account1
        outputTextBox.AppendText("Attempting to debit $30.00 from account2" & vbCrLf)
        account2.Debit(30D) ' try to debit $30.00 from account2
        outputTextBox.AppendText("Attempting to debit $40.00 from account3" & vbCrLf)
        account3.Debit(40D) ' try to debit $40.00 from account3

        DisplayBalance() ' display balances

        ' credit to accounts
        outputTextBox.AppendText("Crediting $40.00 to account1" & vbCrLf)
        account1.Credit(40D) ' credit $40.00 to account1
        outputTextBox.AppendText("Crediting $65.00 to account2" & vbCrLf)
        account2.Credit(65D) ' credit $65.00 to account2
        outputTextBox.AppendText("Crediting $20.00 to account3" & vbCrLf)
        account3.Credit(20D) ' credit $20.00 to account3

        DisplayBalance() ' display balances

        ' add interest to SavingsAccount object account2
        outputTextBox.AppendText("Adding " & FormatCurrency(account2.CalculateInterest) & " interest to account2" & vbCrLf)
        account2.Credit(account2.CalculateInterest)
        outputTextBox.AppendText("New account2 balance: " & account2.Balance & vbCrLf)
    End Sub ' 

    ' display account balance
    Private Sub DisplayBalance()
        outputTextBox.AppendText(vbCrLf & "account1 balance: " & FormatCurrency(account1.Balance) & vbCrLf)
        outputTextBox.AppendText("account2 balance: " & FormatCurrency(account2.Balance) & vbCrLf)
        outputTextBox.AppendText("account3 balance: " & FormatCurrency(account3.Balance) & vbCrLf & vbCrLf)
    End Sub ' DisplayBalance
End Class
