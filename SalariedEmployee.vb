' Fig. 10.10: SalariedEmployee.vb
' SalariedEmployee class inherits Employee
Public Class SalariedEmployee
    Inherits Employee

    Private weeklySalaryValue As Decimal ' employee's weekly salary

    ' four-argument constructor
    Public Sub New(first As String, last As String,
       ssn As String, salary As Decimal)

        MyBase.New(first, last, ssn) ' pass to Employee constructor
        WeeklySalary = salary ' validate and store salary
    End Sub ' New

    ' property WeeklySalary
    Public Property WeeklySalary() As Decimal
        Get
            Return weeklySalaryValue
        End Get

        Set(salary As Decimal)
            If salary >= 0D Then ' validate salary
                weeklySalaryValue = salary ' valid
            Else
                MessageBox.Show("Salary must be greater than or equal to 0", "Salary",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Set
    End Property ' WeeklySalary

    ' calculate earnings; override abstract method CalculateEarnings
    Public Overrides Function CalculateEarnings() As Decimal
        Return WeeklySalary
    End Function ' CalculateEarnings                                

    ' return String representation of SalariedEmployee object           
    Public Overrides Function ToString() As String
        Return String.Format(
           "salaried employee: {0}{1}weekly salary: {2:C}",
           MyBase.ToString(), vbCrLf, WeeklySalary)
    End Function ' ToString 
End Class ' SalariedEmployee
