' Base class for all three-dimensional shapes.
Public MustInherit Class ThreeDimensionalShape
   Inherits Shape

   ' point that defines shape location
   Private xValue As Double
   Private yValue As Double
   Private zValue As Double

   ' initialize location variables
   Public Sub New(xCoordinate As Integer, _
      yCoordinate As Integer, zCoordinate As Integer)
      X = xCoordinate
      Y = yCoordinate
      Z = zCoordinate
   End Sub ' New

   ' property X
   Public Property X() As Double
      Get
         Return xValue
      End Get

      Set(xCoordinate As Double)
         xValue = xCoordinate
      End Set
   End Property ' X

   ' property Y
   Public Property Y() As Double
      Get
         Return yValue
      End Get

      Set(yCoordinate As Double)
         yValue = yCoordinate
      End Set
   End Property ' Y

   ' property Z
   Public Property Z() As Double
      Get
         Return zValue
      End Get

      Set(zCoordinate As Double)
         zValue = zCoordinate
      End Set
   End Property ' Z

   ' return three-dimensional shape location
   Public Overrides Function ToString() As String
      Return String.Format("[{0}, {1}, {2}]", X, Y, Z)
   End Function ' ToString
End Class ' ThreeDimensionalShape
