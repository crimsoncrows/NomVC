Public Class Owner

    Private strName As String
    Private intAge As Integer
    Private strSex As String
    Private strAddress As String
    Private lstPets As List(Of Pet)



    Public Sub New()
        lstPets = New List(Of Pet)()
    End Sub

    Public Sub New(ByVal name As String, ByVal age As Integer, ByVal sex As String, ByVal address As String)
        strName = name
        intAge = age
        strSex = sex
        strAddress = address
        lstPets = New List(Of Pet)()
    End Sub

    Public Sub setOwnerInfo(ByVal name As String, ByVal age As Integer, ByVal sex As String, ByVal address As String)
        strName = name
        intAge = age
        strSex = sex
        strAddress = address
    End Sub

    Public Sub setPets(ByVal pets As List(Of Pet))
        lstPets = pets
    End Sub

    Public Function getName() As String
        Return strName
    End Function

    Public Function getAge() As Integer
        Return intAge
    End Function

    Public Function getSex() As String
        Return strSex
    End Function

    Public Function getAddress() As String
        Return strAddress
    End Function

    Public Function getPets() As List(Of Pet)
        Return lstPets
    End Function



    Public Sub getUserFromOwnerTable()



    End Sub

    Public Sub displayOwnerInfo()

        Dim owner As New Homepage
        owner.lblNameVal.Text = getName()
        owner.lblAddressVal.Text = getAddress()
        owner.lblSexVal.Text = getSex()
        owner.lblAgeVal.Text = getAge()


    End Sub


End Class
