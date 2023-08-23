Imports Microsoft.SolverFoundation.Solvers
Imports Microsoft.SolverFoundation.Common
Imports Microsoft.SolverFoundation.Services

Public Class Optimization

    '=========== Simplex Model Helper Functions =================

    Private VarSList As New SortedList(Of String, Integer)
    Private FunSList As New SortedList(Of String, Integer)
    Private myModel As SimplexSolver


    ' Initialization of variable and function lists, and solver
    Private Sub InitSolver()
        VarSList.Clear()
        FunSList.Clear()
        myModel = New SimplexSolver
    End Sub

    ' Add a new variale to model
    Private Sub AddVar(varstr As String, lb As Decimal, ub As Decimal)
        VarSList.Add(varstr, 0)
        myModel.AddVariable(varstr, VarSList(varstr))
        myModel.SetBounds(VarSList(varstr), lb, ub)
    End Sub

    ' Add a new function to model
    Private Sub AddFun(funstr As String, lb As Decimal, ub As Decimal)
        FunSList.Add(funstr, 0)
        myModel.AddRow(funstr, FunSList(funstr))
        myModel.SetBounds(FunSList(funstr), lb, ub)
    End Sub

    ' Add an objective function
    Private Sub AddObj(funstr As String)
        FunSList.Add(funstr, 0)
        myModel.AddRow(funstr, FunSList(funstr))
    End Sub

    ' Set coefficient of a variable in a function
    Private Sub SetCoef(funstr As String, varstr As String, coef As Decimal)
        myModel.SetCoefficient(FunSList(funstr), VarSList(varstr), coef)
    End Sub

    ' Solve optimization model
    Private Sub SolveModel(funstr As String, isMin As Boolean)
        myModel.AddGoal(FunSList(funstr), 0, isMin)
        myModel.Solve(New SimplexSolverParams())
    End Sub

    'Get value of variable
    Private Function GetVarValue(varstr As String) As Decimal
        Return myModel.GetValue(VarSList(varstr)).ToDouble
    End Function

    ' Get value of function
    Private Function GetFunValue(funstr As String) As Decimal
        Return myModel.GetValue(FunSList(funstr)).ToDouble
    End Function

    ' Check optimality
    Private Function IsOptimal() As Boolean
        Return myModel.LpResult = 2
    End Function

    '=============================================================


    Public Function getOptimalAssignments(ByRef mechanics As List(Of tblMechanic), ByRef brands As List(Of tblBrand), ByRef assignmentOptions As List(Of Assignment)) As Integer

        'HOMEWORK REQUIREMENT #5
        'Complete the getOptimalAssignments function in Optimization.vb
        'Initialize the Solver

        InitSolver()

        'Add Variables from the assignmentOptions

        For Each assignment In assignmentOptions
            AddVar(assignment.Id, 0, 1)
        Next

        'Add Constraints(both Constraint 1 And Constraint 2)
        'Constraint 1 - Each mechanic has one brand
        For Each mechanic In mechanics
            AddFun("Mech" & mechanic.mechanicId, 1, 1)
            For Each brand In brands
                SetCoef("Mech" & mechanic.mechanicId, mechanic.mechanicId & brand.brandId, 1)
            Next
        Next

        'Constraint 2 - Each brand has one mechanic
        For Each brand In brands
            AddFun("Brand" & brand.brandId, 1, 1)
            For Each mechanic In mechanics
                SetCoef("Brand" & brand.brandId, mechanic.mechanicId & brand.brandId, 1)
            Next
        Next


        'Add Objective Function

        AddObj("obj")

        For Each assignment In assignmentOptions
            SetCoef("obj", assignment.Id, assignment.Expertise)
        Next

        'Solve

        SolveModel("obj", False)

        'If Optimal Then, the assignment In the list Of assignment Property {Assigned] should be Set To True. 

        If IsOptimal() Then
            For Each assignment In assignmentOptions
                If GetVarValue(assignment.Id) = 1 Then
                    assignment.Assigned = True
                End If

            Next

        End If

        'Return the Overall Expertise As an Integer

        Dim totalExpLst As New List(Of Integer)

        For Each assignment In assignmentOptions
            totalExpLst.Add(GetVarValue(assignment.Id) * assignment.Expertise)
        Next

        Dim totalExpertise As Integer = 0

        For i = 0 To totalExpLst.Count - 1
            totalExpertise += totalExpLst(i)
        Next

        Return totalExpertise

    End Function

End Class
