Public Class Invoice
    Public partNumber As Integer
    Public partDescription As String
    Public Quantity As Integer
    Public Price As Decimal

    Public Sub New(pN As Integer, pD As String, Q As Integer, P As Decimal)
        partNumber = pN
        partDescription = pD
        Quantity = Q
        Price = P
    End Sub

    Public Property pN() As Integer
        Get
            Return partNumber
        End Get
        Set(value As Integer)
            If value >= 0 Then
                partNumber = value
            Else
                Throw New ArgumentOutOfRangeException("Part Number must be greater than or equal to 0")
            End If
        End Set
    End Property
    Public ReadOnly Property pD() As String
        Get
            Return partDescription
        End Get
    End Property
    Public Property Q() As Integer
        Get
            Return Quantity
        End Get
        Set(value As Integer)
            If value >= 0 Then
                Quantity = value
            Else
                Throw New ArgumentOutOfRangeException("Quantity must be greater than or equal to 0")
            End If
        End Set
    End Property
    Public Property P As Decimal
        Get
            Return Price
        End Get
        Set(value As Decimal)
            If value >= 0 Then
                Price = value
            Else
                Throw New ArgumentOutOfRangeException("Price must be greater than or equal to 0")
            End If
        End Set
    End Property
    Public Overrides Function ToString() As String
        Return String.Format("{0, -5}     {1, -20}          {2, -5}      {3:C}", partNumber, partDescription, Quantity, Price)
    End Function
End Class
