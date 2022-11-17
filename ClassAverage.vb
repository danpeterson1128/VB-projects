'*** import the related namespace for IO (coding example in Fig 8.7)
Imports System.IO
Public Class ClassAverage
    Dim fileWriter As StreamWriter ' writes data to a text file
    Dim fileReader As StreamReader ' reads data from a text file

    ' specify file in which grades will be stored
    Private Sub selectFileButton_Click(sender As Object,
       e As EventArgs) Handles selectFileButton.Click

        Dim result As DialogResult ' stores result of Save dialog
        Dim fileName As String ' name of file to save data

        '*** display dialog so user can choose the name of the file to save
        '    get specified file name
        '    (coding example in Fig 8.9)
        Using fileWriter As New SaveFileDialog()
            result = fileWriter.ShowDialog()
            fileName = fileWriter.FileName
        End Using


        '*** if user did not click Cancel
        '    open or create file for writing
        '    enable Submit Grade and Close File buttons
        '    disable Select File button
        '    (coding example in Fig 8.9)
        If result <> DialogResult.Cancel Then
            Try
                fileWriter = New StreamWriter(fileName, True)

                submitGradeButton.Enabled = True
                closeFileButton.Enabled = True
            Catch ex As Exception
                MessageBox.Show("Error Opening File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try


        End If
    End Sub

    ' places a grade in the file
    Private Sub submitGradeButton_Click(sender As Object,
       e As EventArgs) Handles submitGradeButton.Click

        ' if the user entered a grade
        If gradeTextBox.Text <> String.Empty Then
            '*** add the grade to the end of the file
            '    clear the gradeTextBox
            '    (coding example in Fig 8.10)
            Dim grade As Integer = Convert.ToInt32(gradeTextBox.Text)
            If grade > 0 Then
                fileWriter.WriteLine(gradeTextBox.Text)
            Else
                MessageBox.Show("Invalid Grade", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            gradeTextBox.Clear()
        End If

        '*** give the focuse to the gradeTextBox
        gradeTextBox.Focus()

    End Sub

    ' close file in which grades were written
    Private Sub closeFileButton_Click(sender As Object,
       e As EventArgs) Handles closeFileButton.Click

        '*** close StreamWriter
        '    disable Submit Grade and close File buttons
        '    enable Select File button
        '    (see the coding example in Fig 8.11)
        If fileWriter IsNot Nothing Then
            Try
                fileWriter.Close()
            Catch ex As Exception
                MessageBox.Show("Error closing file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

        submitGradeButton.Enabled = False
        closeFileButton.Enabled = False
        selectFileButton.Enabled = True

    End Sub

    ' open a file containing grades
    Private Sub openFileButton_Click(sender As Object,
       e As EventArgs) Handles openFileButton.Click

        Dim result As DialogResult ' stores result of Open dialog
        Dim fileName As String ' name of file to save data

        '*** create dialog box enabling user to open file
        '    get specified file name
        '    (coding example in Fig 8.15)
        Using fileReader As New OpenFileDialog()
            result = fileReader.ShowDialog()
            fileName = fileReader.FileName
        End Using



        ' if user did not click Cancel, enable Buttons
        If result <> Windows.Forms.DialogResult.Cancel Then

            ' read and display grades information
            Try
                '*** open file for reading
                '    read file and display it in the gradesListBox whie not end of file
                '    (coding example in Fig 8.17)

                fileReader = New StreamReader(fileName)

                Do While Not fileReader.EndOfStream
                    gradesListBox.Items.Add(fileReader.ReadLine())
                Loop
            Catch ex As IOException
                MessageBox.Show("Cannot Read File", "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                '*** ensure that file gets closed by closing StreamReader
                '    (coding example in Fig 8.17)
                If fileReader IsNot Nothing Then
                    Try
                        fileReader.Close()
                    Catch ex As Exception
                        MessageBox.Show("Error closing file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End If




            End Try

            '*** disable Select File Containing Grades button
            '    enable Calculate Average and Clear Grades buttons
            openFileButton.Enabled = False
            calculateAverageButton.Enabled = True
            clearGradesButton.Enabled = True



        End If
    End Sub

    ' calculates the class average based on the grades in gradesListBox
    Private Sub calculateAverageButton_Click(sender As Object,
      e As EventArgs) Handles calculateAverageButton.Click

        Dim total As Integer ' sum of grades entered by user
        Dim gradeCounter As Integer ' counter for grades 
        Dim grade As Integer ' grade input by user
        Dim average As Double ' average of grades

        ' initialization phase
        total = 0 ' set total to zero before adding grades to it
        gradeCounter = 0 ' prepare to loop

        ' processing phase
        Do While gradeCounter < gradesListBox.Items.Count
            grade = gradesListBox.Items(gradeCounter) ' get next grade
            total += grade ' add grade to total
            gradeCounter += 1 ' add 1 to gradeCounter
        Loop

        ' termination phase
        If gradeCounter <> 0 Then
            average = total / gradesListBox.Items.Count ' calculate average

            ' display total and average (with two digits of precision)
            classAverageLabel.Text = "Total of the " & gradeCounter &
            " grade(s) is " & total & vbCrLf & "Class average is " &
            String.Format("{0:F}", average)
        Else
            classAverageLabel.Text = "No grades were entered"
        End If

        calculateAverageButton.Enabled = False
    End Sub

    ' clears grades from gradeListBox and results from classAverageLabel
    Private Sub clearGradesButton_Click(sender As Object,
      e As EventArgs) Handles clearGradesButton.Click

        gradesListBox.Items.Clear() ' removes all items from gradesListBox
        classAverageLabel.Text = String.Empty ' clears classAverageLabel
        openFileButton.Enabled = True
        calculateAverageButton.Enabled = False
        clearGradesButton.Enabled = False
    End Sub
End Class
