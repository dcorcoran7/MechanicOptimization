'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class tblMechanic
    Public Property mechanicId As Integer
    Public Property FirstName As String
    Public Property LastName As String
    Public Property HourlyRate As Nullable(Of Decimal)

    Public Overridable Property tblExpertises As ICollection(Of tblExpertise) = New HashSet(Of tblExpertise)

End Class
