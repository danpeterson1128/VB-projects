Public Class sphere
    Inherits ThreeDimensionalShape

    Private radius As Double
    Public Sub New(x, y, z, rad)
        MyBase.New(x, y, z)
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
                Throw New ArgumentOutOfRangeException("The radius must be greater than 0")
            End If
        End Set
    End Property
    Public Overrides Function GetVolume() As Double
        Return String.Format("{0:F5}", MyBase.GetVolume() + ((4 / 3) * Math.PI * (radius * radius * radius)))
    End Function
    Public Overrides Function GetArea() As Double
        Return String.Format("{0:F5}", MyBase.GetArea() + (4 * Math.PI * (radius * radius)))
    End Function
End Class
