'imports related namespace 
Imports System.IO
Public Class StoreSurveyResponses
    Dim filewriter As StreamWriter      'writes data to a text file
    Dim filereader As StreamReader      'reads data from a text file
    Private Sub selectFileButton_Click(sender As Object, e As EventArgs) Handles selectFileButton.Click
        Dim result As DialogResult ' stores result of Save dialog
        Dim fileName As String ' name of file to save data
        '    get specified file name
        '    (coding example in Fig 8.9)
        Using fileWriter As New SaveFileDialog()
            result = fileWriter.ShowDialog()
            fileName = fileWriter.FileName
        End Using


        '*** if user did not click Cancel
        '    open or create file for writing
        '    enable Submit response and Close File buttons
        '    disable Select File button
        '    (coding example in Fig 8.9)
        If result <> DialogResult.Cancel Then
            Try
                filewriter = New StreamWriter(fileName, True)
                selectFileButton.Enabled = False
                submitResponseButton.Enabled = True
                closeFileButton.Enabled = True
            Catch ex As Exception
                MessageBox.Show("Error Opening File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try


        End If
    End Sub
    'place response into file
    Private Sub submitResponseButton_Click(sender As Object, e As EventArgs) Handles submitResponseButton.Click
        If responseTextBox.Text <> String.Empty Then
            '*** add the response to the end of the file
            Dim response As Integer = Convert.ToInt32(responseTextBox.Text)
            If response >= 1 And response <= 5 Then
                filewriter.WriteLine(responseTextBox.Text)
            Else
                MessageBox.Show("Invalid Grade", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            '    clear the responseTextBox
            responseTextBox.Clear()
        End If

        '*** give the focuse to the responseTextBox
        responseTextBox.Focus()
    End Sub

    Private Sub closeFileButton_Click(sender As Object, e As EventArgs) Handles closeFileButton.Click
        '*** close StreamWriter
        '    disable Submit Response and close File buttons
        '    enable Select File button
        If filewriter IsNot Nothing Then
            Try
                filewriter.Close()
            Catch ex As Exception
                MessageBox.Show("Error closing file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
        submitResponseButton.Enabled = False
        closeFileButton.Enabled = False
        selectFileButton.Enabled = True

    End Sub
End Class
