' Drawing a series of concentric circles on a form.
Public Class ConcentricCircles

    Private Sub ConcentricCircles_Paint(sender As Object,
       e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint

        '*** declare a Grphics object.
        Dim g As Graphics = e.Graphics

        '*** declare a Pen (black color) object.
        Dim myPen As New Pen(Color.Black)

        '*** draw concentric circles using a For loop.
        '   Use DrawArc(pen, rect, startAngle, sweepAngle)
        For i As Integer = 0 To 70 Step 10
            Dim j As Integer = 160 - (i * 2)
            'draw individual circle
            g.DrawArc(myPen, i + 10, i + 10, j, j, 0, 360)
        Next


    End Sub
End Class