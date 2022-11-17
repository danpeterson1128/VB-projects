
Public Class HealthProfile
    Private fName As String
    Private lName As String
    Private gender As Char
    Private bYear As Integer
    Private cYear As Integer
    Private height As Double
    Private weight As Double

    Public Sub New(firstName As String, lastName As String, sex As Char, birthYear As Integer,
                   currentYear As Integer, inHeight As Double, lbsWeight As Double)
        fName = firstName
        lName = lastName
        gender = sex
        bYear = birthYear
        cYear = currentYear
        height = inHeight
        weight = lbsWeight
    End Sub
    Public ReadOnly Property firstName() As String
        Get
            Return fName
        End Get
    End Property
    Public ReadOnly Property lastName() As String
        Get
            Return lName
        End Get
    End Property
    Public ReadOnly Property sex() As Char
        Get
            Return gender
        End Get
    End Property
    Public Property birthYear() As Integer
        Get
            Return bYear
        End Get
        Set(value As Integer)
            If value >= 1900.0 Then
                bYear = value
            Else
                MessageBox.Show("Invalid birthyear: ", value & vbCrLf)
            End If
        End Set
    End Property
    Public Property currentYear() As Integer
        Get
            Return cYear
        End Get
        Set(value As Integer)
            If value >= bYear Then
                cYear = value
            Else
                MessageBox.Show("Invalid current year: ", value & vbCrLf)
            End If
        End Set
    End Property
    Public Property inHeight() As Double
        Get
            Return height
        End Get
        Set(value As Double)
            If value > 0 Then
                height = value
            Else
                MessageBox.Show("Invalid height: ", value & vbCrLf & "Set to default: 55 inches")
                height = 55
            End If
        End Set
    End Property
    Public Property lbsweight() As Double
        Get
            Return weight
        End Get
        Set(value As Double)
            If value > 0 Then
                weight = value
            Else
                MessageBox.Show("Invalid weight: ", value & vbCrLf & "Set to default: 150 lbs")
                weight = 150
            End If
        End Set
    End Property
    Public Function userAge() As Double
        Return currentYear - birthYear
    End Function
    Public Function maxHRate() As Double
        Return 220 - userAge()
    End Function
    Public Function lowtargetHRate() As Double
        Return maxHRate() * 0.5 & vbCrLf
    End Function
    Public Function maxtargetHRate() As Double
        Return maxHRate() * 0.85 & vbCrLf
    End Function
    Public Function BMI() As Double
        Return ((lbsweight / Math.Pow(height, 2)) * 703) & vbCrLf & vbCrLf
    End Function
    Public Overrides Function ToString() As String
        Return "Health Profile for: " & firstName & " " & lastName & vbCrLf & "Gender: " & sex & vbCrLf &
        "Age: " & Me.userAge & vbCrLf & "Height (in inches): " & inHeight & vbCrLf &
        "Weight (in pounds): " & lbsweight & vbCrLf & "Maximum heart rate: " & Me.maxHRate & vbCrLf &
        "Target Heart Rate Range: " & vbCrLf & "Minimum: " & Me.lowtargetHRate & vbCrLf & "Maximum: " & Me.maxtargetHRate & vbCrLf &
        "BMI: " & Format(Me.BMI, "#####.##") & vbCrLf & vbCrLf & "BMI Values: " & vbCrLf & "Underweight: less than 18.5" & vbCrLf &
        "Normal: between 18.5 and 24.9" & vbCrLf & "Overweight: between 25 and 29.9" & vbCrLf &
        "Obese: 30 or greater"
    End Function

End Class
