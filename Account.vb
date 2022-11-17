Public Class Account
    Private accountBalance As Decimal

    Public Sub New(balanceValue As Decimal)
        Balance = balanceValue
    End Sub
    Public Property Balance() As Decimal
        Get
            Return accountBalance
        End Get
        Set(value As Decimal)
            If value < 0D Then
                MessageBox.Show("Error: Initial balance cannot be negative.", "Invalid Balance", MessageBoxButtons.OK, MessageBoxIcon.Error)
                accountBalance = 0D
            Else
                accountBalance = value
            End If
        End Set
    End Property
    Public Overridable Sub Credit(amount As Decimal)
        Balance = Balance + amount
    End Sub
    Public Overridable Sub Debit(amount As Decimal)
        If Balance - amount < 0 Then
            MessageBox.Show("Debit amount exceeded account balance.", "Invalid Debit amount", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Balance = Balance - amount
        End If
    End Sub
End Class
