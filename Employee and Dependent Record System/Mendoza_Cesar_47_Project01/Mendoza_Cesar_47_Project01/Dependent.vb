'--------------------------------------------------------------------------
'* Name:       Cesar Mendoza
'* Class:      CIS-2510
'* Assignment: Project 01
'* File:       Dependent.vb
'* Purpose:    Dependent derived class that inherits super class Employee
'--------------------------------------------------------------------------

Public Class Dependent
    Inherits Employee

    Private baseClassInstance As Employee

    Private _dependentType As String = ""


    Public Property DependentType As String
        Get
            Return _dependentType
        End Get
        Set(value As String)
            _dependentType = value
        End Set
    End Property
End Class
