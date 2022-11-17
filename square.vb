Public Class Square
    Inherits TwoDimensionalShape

    Private squareSide As Double
    Public Sub New(x As Integer, y As Integer, side As Integer)
        MyBase.New(x, y)
        squareSide = side

    End Sub
    Public Property side() As Integer
        Get
            Return squareSide
        End Get
        Set(value As Integer)
            If value > 0 Then
                squareSide = value
            Else
                Throw New ArgumentOutOfRangeException("The side of the square must be greater than 0")
            End If
        End Set
    End Property
    Public Overrides Function GetArea() As Double
        Return String.Format("{0:C}", MyBase.GetArea() + (side * side))
    End Function
End Class
