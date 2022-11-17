Imports System.IO
Public Class Form1
    Dim filewriter As StreamWriter
    Dim filereader As StreamReader
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim result As DialogResult ' stores result of Save dialog
        Dim fileName As String ' name of file to save data

        '*** display dialog so user can choose the name of the file to save
        '    get specified file name
        '    (coding example in Fig 8.9)
        Using fileWriter As New SaveFileDialog()
            result = fileWriter.ShowDialog()
            fileName = fileWriter.FileName
        End Using

        If result <> DialogResult.Cancel Then
            Try
                filewriter = New StreamWriter(fileName, True)
            Catch ex As Exception
                MessageBox.Show("Error Opening File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
End Class
