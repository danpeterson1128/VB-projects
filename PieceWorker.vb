Public Class PieceWorker
    Inherits Employee
    Private wageValue As Decimal
    Private piecesValue As Integer

    Public Sub New(first As String, last As String, ssn As String, wage As Decimal, pieces As Integer)
        MyBase.New(first, last, ssn)
        piecesValue = pieces
        wageValue = wage
    End Sub
    Public Property pieces() As Integer
        Get
            Return piecesValue
        End Get
        Set(value As Integer)
            If value > 0 Then
                piecesValue = value
            Else
                MessageBox.Show("Pieces value must be greater than or equal to 0",
                                "Pieces value", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Set
    End Property
    Public Property wages() As Decimal
        Get
            Return wageValue
        End Get
        Set(value As Decimal)
            If value > 0 Then
                wageValue = value
            Else
                MessageBox.Show("Wage value must be greater than or equal to 0",
                                "Wage Value", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Set
    End Property

    Public Overrides Function CalculateEarnings() As Decimal
        Return wageValue * piecesValue
    End Function
    Public Overrides Function ToString() As String
        Return String.Format("Piece Worker: {0}{1}" &
           "Wage per piece: {2:C}{1}Pieces sold: {3:F}",
           MyBase.ToString(), vbCrLf, pieces, wages)
    End Function
End Class
