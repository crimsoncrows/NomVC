Public Class Pet
    Private strName As String
    Private intAge As Integer
    Private dtBirthday As Date
    Private dblWeight As Double
    Private strType As String 'Feline/Canine/Reptile'
    Private strVaccineStatus As String 'Complete/Incomplete'
    Private dtNextVisit As Date

    Public Sub New()
    End Sub

    Public Sub New(ByVal name As String, ByVal age As Integer, ByVal birthday As Date,
                   ByVal weight As Double, ByVal type As String, ByVal vaccineStatus As String,
                   ByVal nextVisit As Date)
        strName = name
        intAge = age
        dtBirthday = birthday
        dblWeight = weight
        strType = type
        strVaccineStatus = vaccineStatus
        dtNextVisit = nextVisit
    End Sub


    Public Sub setPetInfo(ByVal name As String, ByVal age As Integer, ByVal birthday As Date,
                          ByVal weight As Double, ByVal type As String, ByVal vaccineStatus As String,
                          ByVal nextVisit As Date)
        strName = name
        intAge = age
        dtBirthday = birthday
        dblWeight = weight
        strType = type
        strVaccineStatus = vaccineStatus
        dtNextVisit = nextVisit
    End Sub

    Public Function getName() As String
        Return strName
    End Function

    Public Function getAge() As Integer
        Return intAge
    End Function

    Public Function getBirthday() As Date
        Return dtBirthday
    End Function

    Public Function getWeight() As Double
        Return dblWeight
    End Function

    Public Function getPetType() As String
        Return strType
    End Function

    Public Function getVaccineStatus() As String
        Return strVaccineStatus
    End Function

    Public Function getNextVisit() As Date
        Return dtNextVisit
    End Function
End Class
