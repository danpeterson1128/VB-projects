Public Class cube
    Inherits ThreeDimensionalShape

    Private cubeSide As Double

    Public Sub New(x As Integer, y As Integer, z As Integer, side As Double)
        MyBase.New(x, y, z)
        cubeSide = side
    End Sub

    Public Property side() As Double
        Get
            Return cubeSide
        End Get
        Set(value As Double)
            If value > 0 Then
                cubeSide = value
            Else
                Throw New ArgumentOutOfRangeException("The side of the cube must be greater than 0")
            End If
        End Set
    End Property
    Public Overrides Function GetArea() As Double
        Return MyBase.GetArea() + (6 * (side * side))
    End Function
    Public Overrides Function GetVolume() As Double
        Return MyBase.GetVolume() + (side * side * side)
    End Function

End Class
