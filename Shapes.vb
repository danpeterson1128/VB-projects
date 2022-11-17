Public Class Shapes
    Private Sub displayButton_Click(sender As Object, e As EventArgs) Handles displayButton.Click
        Dim square As New Square(0, 0, 5)
        Dim circle As New circle(4, 4, 3)
        Dim cube As New cube(0, 0, 0, 5)
        Dim sphere As New sphere(3, 4, 5, 5)

        outputTextBox.AppendText("Square:" & vbCrLf & square.ToString & " Side: " & square.side & vbCrLf)
        outputTextBox.AppendText("Square's area is " & square.GetArea & vbCrLf & vbCrLf)
        outputTextBox.AppendText("Circle: " & vbCrLf & circle.ToString & " Radius: " & circle.rad & vbCrLf)
        outputTextBox.AppendText("Circle's area is " & circle.GetArea & vbCrLf & vbCrLf)
        outputTextBox.AppendText("Cube: " & vbCrLf & cube.ToString & " Side: " & cube.side & vbCrLf)
        outputTextBox.AppendText("Cube's area is " & cube.GetArea & vbCrLf & "Cube's volume is: " & cube.GetVolume & vbCrLf & vbCrLf)
        outputTextBox.AppendText("Sphere: " & vbCrLf & sphere.ToString & " Sphere: " & sphere.rad & vbCrLf)
        outputTextBox.AppendText("Sphere's area is " & sphere.GetArea & vbCrLf & "Sphere's volume is: " & sphere.GetVolume & vbCrLf & vbCrLf)


    End Sub
End Class
