Public Class EmployeeTest
    Private Sub displayButton_Click(sender As Object, e As EventArgs) Handles displayButton.Click
        Dim emp1 As New Employee("Bob", "Jones", 2850.88)
        Dim emp2 As New Employee("Susan", "Baker", 3150.92)
        outputTextBox.Text = ("Employee 1: " & emp1.FirstName & " " & emp1.LastName & "; Yearly Salary: " &
            FormatCurrency(emp1.mSalary * 12, 2) & vbCrLf)
        outputTextBox.AppendText("Employee 2: " & emp2.FirstName & " " & emp2.LastName & "; Yearly Salary: " &
            FormatCurrency(emp2.mSalary * 12, 2) & vbCrLf)

        emp1.mSalary = emp1.mSalary * 1.1
        emp2.mSalary = emp2.mSalary * 1.1
        outputTextBox.AppendText(vbCrLf & "Increasing employee salaries by 10%" & vbCrLf)
        outputTextBox.AppendText("Employee 1: " & emp1.FirstName & " " & emp1.LastName & "; Yearly Salary: " &
            FormatCurrency(emp1.mSalary * 12, 2) & vbCrLf)
        outputTextBox.AppendText("Employee 2: " & emp2.FirstName & " " & emp2.LastName & "; Yearly Salary: " &
            FormatCurrency(emp2.mSalary * 12, 2) & vbCrLf)
    End Sub
End Class
