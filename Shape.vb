' Shapes base class.
Public MustInherit Class Shape
    ' return shape area
    Public Overridable Function GetArea() As Double
        Return 0.0
    End Function ' GetArea

    ' return shape volume
    Public Overridable Function GetVolume() As Double
        Return 0.0
    End Function ' GetVolume
End Class ' Shape