Public Class HealthProfileTest

    Private Sub displayButton_Click(sender As Object,
      e As EventArgs) Handles displayButton.Click

        Dim user As HealthProfile

        user = New HealthProfile(firstNameTextBox.Text,
                                 lastNameTextBox.Text,
                                 genderTextBox.Text,
                                 Convert.ToInt32(birthYearTextBox.Text),
                                 Convert.ToInt32(currentYearTextBox.Text),
                                 Convert.ToDouble(heightTextBox.Text),
                                 Convert.ToDouble(weightTextBox.Text))

        outputTextBox.Text = user.ToString()
    End Sub
End Class