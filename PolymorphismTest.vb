' Employee hierarchy test program.
Public Class PolymorphismTest
    Private Sub displayButton_Click(sender As Object, e As EventArgs) Handles displayButton.Click

        ' create derived-class objects                                     
        Dim salariedEmployee As New SalariedEmployee(
         "John", "Smith", "111-11-1111", 800D)
        Dim commissionEmployee As New CommissionEmployee(
         "Sue", "Jones", "333-33-3333", 10000D, 0.06)
        Dim basePlusCommissionEmployee As New BasePlusCommissionEmployee(
         "Bob", "Lewis", "444-44-4444", 5000D, 0.04, 300D)
        Dim hourlyWorker As New HourlyWorker(
         "Karen", "Price", "222-22-2222", 16.75D, 40D)
        Dim pieceWorker As New PieceWorker(
         "Rick", "Bridges", "555-55-5555", 2.25D, 400)

        '*** create five-element Employee array                              
        Dim employeeArray() As Employee = {salariedEmployee, commissionEmployee, basePlusCommissionEmployee, hourlyWorker, pieceWorker}
        outputTextBox.AppendText(
         "Employees processed polymorphically:" & vbCrLf & vbCrLf)

        '*** polymorphically process each element in array employees
        For Each currentemployee In employeeArray
            outputTextBox.AppendText(String.Format("{0}{1}earned {2:C}{1}{1}",
                                                   currentemployee.ToString(), vbCrLf,
                                                   currentemployee.CalculateEarnings()))
        Next


    End Sub
End Class ' PolymorphismTest