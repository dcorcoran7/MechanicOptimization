Public Class Assignment
    'HOMEWORK REQUIREMENT #1

    Public Property Mechanic As tblMechanic
    Public Property Brand As tblBrand
    Public Property Expertise As Integer
    Public Property Assigned As Boolean
    Public Property Id As String

    Dim db As New bit3444_AutoMechanicExpertise

    Public Sub New(ByVal mech As tblMechanic, ByVal brd As tblBrand)

        Dim exp = (From ex In db.tblExpertises
                   Where ex.mechanicId = mech.mechanicId And ex.brandId = brd.brandId
                   Select ex.Expertise).ToList

        Dim expertiseList As New List(Of Integer)
        For Each ex In exp
            expertiseList.Add(ex)
        Next

        Expertise = expertiseList(0)
        Mechanic = mech
        Brand = brd
        Assigned = False
        Id = mech.mechanicId & brd.brandId

    End Sub

    Public Overrides Function ToString() As String
        Return Mechanic.FirstName & " " & Mechanic.LastName & " >>> " & Brand.Brand & ": " & Expertise
    End Function

End Class
