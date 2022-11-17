' Base class for all two-dimensional shapes.
Public MustInherit Class TwoDimensionalShape
    Inherits Shape

    ' point that defines shape location
    Private xValue As Integer
    Private yValue As Integer

    ' constructor
    Public Sub New(xCoordinate As Integer, yCoordinate As Integer)
        X = xCoordinate
        Y = yCoordinate
    End Sub ' New

    ' property X
    Public Property X() As Integer
        Get
            Return xValue
        End Get

        Set(xCoordinate As Integer)
            xValue = xCoordinate
        End Set
    End Property ' X

    ' property Y
    Public Property Y() As Integer
        Get
            Return yValue
        End Get

        Set(yCoordinate As Integer)
            yValue = yCoordinate
        End Set
    End Property ' Y

    ' display the shape location point
    Public Overrides Function ToString() As String
        Return String.Format("[{0}, {1}]", X, Y)
    End Function ' ToString
End Class ' TwoDimensionalShape