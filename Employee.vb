' Fig. 10.9: Employee.vb
' Employee abstract base class.
Public MustInherit Class Employee
    Public Property FirstName() As String  ' auto-implemented
    Public Property LastName() As String  ' auto-implemented
    Public Property SocialSecurityNumber() As String ' auto-implemented

    ' three-argument constructor
    Public Sub New(first As String, last As String,
      ssn As String)
        FirstName = first ' invoke auto-implemented property
        LastName = last ' invoke auto-implemented property
        SocialSecurityNumber = ssn ' invoke auto-implemented property
    End Sub ' New

    ' return String representation of Employee object
    Public Overrides Function ToString() As String
        Return String.Format("{0} {1}{2}{3} {4}", FirstName, LastName,
         vbCrLf, "social security number:", SocialSecurityNumber)
    End Function ' ToString

    ' abstract method overridden by derived class              
    Public MustOverride Function CalculateEarnings() As Decimal
End Class ' Employee