Public Class frmAssignment

    'Use this Entity to Connect to the Database
    Dim db As New bit3444_AutoMechanicExpertise
    Dim mechList As New List(Of tblMechanic)
    Dim brandList As New List(Of tblBrand)
    Dim assignmentList As New List(Of Assignment)

    Dim newOpt As New Optimization

    Private Sub frmAssignment_Load(sender As Object, e As EventArgs) Handles Me.Load
        'HOMEWORK REQUIREMENT #4
        'set values to the class level variables, including the assginmentList. Populate the list boxes of all the mechanics and brands    

        Dim mechanics = (From ex In db.tblMechanics
                         Select ex.LastName).ToList

        Dim brands = (From ex In db.tblBrands
                      Select ex.Brand).ToList

        For Each mechanic In mechanics
            lstboxMechanic.Items.Add(mechanic)
        Next

        For Each brand In brands
            lstboxBrand.Items.Add(brand)
        Next

        mechList = (From mechanic In db.tblMechanics).ToList

        brandList = (From brand In db.tblBrands).ToList

        For Each mechanic In mechList
            For Each brand In brandList
                assignmentList.Add(New Assignment(mechanic, brand))
            Next
        Next

        lstboxBrand.Enabled = False
        lstboxMechanic.Enabled = False

    End Sub

    Private Sub btnSolve_Click(sender As Object, e As EventArgs) Handles btnCreateAssignments.Click
        '--------------------------------------------------------- ^^^^^^^^^ Add in the Handles for Your Button

        'HOMEWORK REQUIREMENT #6
        'On the Click event handler for the button, run the optimization code after completing the function 
        'getOptimalAssignments on the class Optimization.  
        Dim optimalExpertise As Integer = newOpt.getOptimalAssignments(mechList, brandList, assignmentList)

        'Once the optimization Is run, the list boxes On frmAssignment should be enabled. 
        'Prior To this point, the list boxes should be disabled. 
        lstboxBrand.Enabled = True
        lstboxMechanic.Enabled = True

        'The Total Expertise label should be filled after the optimization has run with the Total Expertise. 
        txtTotalExpertise.Text = optimalExpertise


    End Sub

    Private Sub lstboxMechanic_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstboxMechanic.SelectedIndexChanged

        For Each assignment In assignmentList
            If assignment.Assigned = True And assignment.Mechanic.mechanicId = lstboxMechanic.SelectedIndex + 1 Then
                lstboxBrand.SelectedIndex = assignment.Brand.brandId - 1
            End If
        Next

        'Dim mech As New tblMechanic
        'Dim brd As New tblBrand
        'txtAssignment.Text = New Assignment(mech, brd).ToString()

        Dim Name = (From mechanic In db.tblMechanics
                    Select mechanic.FirstName).ToList

        Dim brandName = (From brand In db.tblBrands
                         Select brand.Brand).ToList

        Dim Exp As Integer

        For Each assignment In assignmentList
            If assignment.Assigned = True And assignment.Mechanic.mechanicId = lstboxMechanic.SelectedIndex + 1 Then
                Exp = assignment.Expertise
            End If
        Next

        txtAssignment.Text = Name(lstboxMechanic.SelectedIndex) & " " & lstboxMechanic.SelectedItem & " >>> " & brandName(lstboxBrand.SelectedIndex) & ": " & Exp.ToString

    End Sub

    Private Sub lstboxBrand_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstboxBrand.SelectedIndexChanged

        For Each assignment In assignmentList
            If assignment.Assigned = True And assignment.Brand.brandId = lstboxBrand.SelectedIndex + 1 Then
                lstboxMechanic.SelectedIndex = assignment.Mechanic.mechanicId - 1
            End If
        Next

    End Sub

    Private Sub txtTotalExpertise_TextChanged(sender As Object, e As EventArgs) Handles txtTotalExpertise.TextChanged

    End Sub

    Private Sub txtAssignment_TextChanged(sender As Object, e As EventArgs) Handles txtAssignment.TextChanged

    End Sub

End Class
