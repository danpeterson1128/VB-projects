Public Class circle
    Inherits TwoDimensionalShape

    Private radius As Double

    Public Sub New(x As Integer, y As Integer, rad As Double)
        MyBase.New(x, y)
        radius = rad

    End Sub
    Public Property rad() As Double
        Get
            Return radius
        End Get
        Set(value As Double)
            If value > 0 Then
                radius = value
            Else
                Throw New ArgumentOutOfRangeException("Radius must be greater than 0")
            End If
        End Set
    End Property
    Public Overrides Function GetArea() As Double
        Return String.Format("{0:F5}", MyBase.GetArea() + (Math.PI * (radius * radius)))
    End Function
End Class
