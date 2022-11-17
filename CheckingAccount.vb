Public Class CheckingAccount
    Inherits Account
    Private transactionFee As Decimal

    Public Sub New(accountbalance As Decimal, fee As Decimal)
        MyBase.New(accountbalance)
        transactionFee = fee
    End Sub

    Public Property Fee() As Decimal
        Get
            Return transactionFee
        End Get
        Set(value As Decimal)
            If value < 0 Then
                transactionFee = 0
            Else
                transactionFee = value
            End If
        End Set
    End Property

    Public Overrides Sub Credit(amount As Decimal)
        MyBase.Credit(amount)
        Balance = Balance - transactionFee
        MessageBox.Show(FormatCurrency(transactionFee) + " transaction fee charged.", "Transaction Fee Charged", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Public Overrides Sub Debit(amount As Decimal)
        MyBase.Debit(amount)
        If Balance - amount < 0 Then
            MessageBox.Show("Debit amount exceeded account balance.", "Invalid Debit amount", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Balance = Balance - transactionFee
        End If
    End Sub
End Class
