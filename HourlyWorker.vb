Public Class HourlyWorker
    Inherits Employee
    Private hoursValue As Decimal
    Private wageValue As Decimal

    Public Sub New(first As String, last As String, ssn As String, hours As Decimal, wage As Decimal)
        MyBase.New(first, last, ssn)
        hoursValue = hours
        wageValue = wage
    End Sub
    Public Property hoursWorked As Decimal
        Get
            Return hoursValue
        End Get
        Set(value As Decimal)
            If value > 0 Then
                hoursValue = value
            Else
                MessageBox.Show("Hours worked must be greater than or equal to 0",
                                "Hours Worked", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Set
    End Property
    Public Property wages() As Decimal
        Get
            Return wageValue
        End Get
        Set(value As Decimal)
            If value > 0 Then
                wageValue = value
            Else
                MessageBox.Show("Wage value must be greater than or equal to 0",
                                "Wage Value", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Set
    End Property
    Public Overrides Function CalculateEarnings() As Decimal
        Dim overtimeHours As Decimal
        Dim overtimePay As Decimal
        If hoursWorked > 40 Then
            overtimeHours = hoursWorked - 40
            overtimePay = CDec((wages * overtimeHours) * 1.5)
            Return (Me.hoursValue - overtimeHours) * wageValue + overtimePay
        Else
            Return hoursWorked * wageValue
        End If

    End Function
    Public Overrides Function ToString() As String
        Return String.Format("Hourly Employee: {0}{1}" &
           "Hourly Wage: {2:C}{1}Hours Worked: {3:F}",
           MyBase.ToString(), vbCrLf, hoursWorked, wages)
    End Function
End Class
