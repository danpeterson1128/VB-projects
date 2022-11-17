' Fig. 10.12: BasePlusCommissionEmployee.vb
' BasePlusCommissionEmployee inherits from class CommissionEmployee.
Public Class BasePlusCommissionEmployee
    Inherits CommissionEmployee

    Private baseSalaryValue As Decimal ' base salary per week

    ' six-argument constructor
    Public Sub New(first As String, last As String,
       ssn As String, sales As Decimal,
       rate As Double, salary As Decimal)

        ' call CommissionEmployee constructor
        MyBase.New(first, last, ssn, sales, rate)
        BaseSalary = salary ' validate and store base salary
    End Sub ' New

    ' property BaseSalary
    Public Property BaseSalary() As Decimal
        Get
            Return baseSalaryValue
        End Get

        Set(salary As Decimal)
            If salary >= 0D Then ' validate base salary
                baseSalaryValue = salary ' valid
            Else
                MessageBox.Show("Base salary must be greater than or equal to 0",
                                "Base Salary", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Set
    End Property ' BaseSalary

    ' calculate earnings
    Public Overrides Function CalculateEarnings() As Decimal
        Return BaseSalary + MyBase.CalculateEarnings()
    End Function ' CalculateEarnings

    ' return String representation of BasePlusCommissionEmployee object
    Public Overrides Function ToString() As String
        Return String.Format("base-plus-{0}{1}base salary: {2:C}",
           MyBase.ToString(), vbCrLf, BaseSalary)
    End Function ' ToString
End Class ' BasePlusCommissionEmployee
