Public Class SavingsAccount
    Inherits Account
    Private interestRateValue As Double

    Public Sub New(accountBalance As Decimal, rate As Double)
        MyBase.New(accountBalance)
        Interest = rate
    End Sub
    Public Property Interest() As Double
        Get
            Return interestRateValue
        End Get
        Set(value As Double)
            If value < 0.0 Then
                interestRateValue = 0.0
            Else
                interestRateValue = value
            End If
        End Set
    End Property
    Public Function CalculateInterest() As Decimal
        Return Balance * Convert.ToDecimal(Interest)
    End Function
End Class
