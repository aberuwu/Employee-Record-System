'----------------------------------------------------------------------------
'* Name:       Cesar Mendoza
'* Class:      CIS-2510
'* Assignment: Project 01
'* File:       Employee.vb
'* Purpose:    Employee super class, contains getter and setter properties
'*             for private member variables
'---------------------------------------------------------------------------

Public Class Employee
    Private _employeeNumber As String = ""
    Private _firstName As String = ""
    Private _lastName As String = ""
    Private _middleName As String = ""
    Private _birthDate As String = ""
    Private _hiredDate As String = ""
    Private _employeeType As String = ""
    Private _salary As Double = 0
    Private _officeCubeLoc As String = ""
    Private _workPhone As String = ""
    Private _workEmail As String = ""
    Private _mobilePhone As String = ""
    Private _personalPhone As String = ""
    Private _personalEmail As String = ""
    Private _numOfDependents As Integer = 0

    Private _dependentType As String = ""


    Public Property DependentType As String
        Get
            Return _dependentType
        End Get
        Set(value As String)
            _dependentType = value
        End Set
    End Property

    Public Property EmployeeNumber As String
        Get
            Return _employeeNumber
        End Get
        Set(value As String)
            _employeeNumber = value
        End Set
    End Property

    Public Property FirstName As String
        Get
            Return _firstName
        End Get
        Set(value As String)
            _firstName = value
        End Set
    End Property

    Public Property LastName As String
        Get
            Return _lastName
        End Get
        Set(value As String)
            _lastName = value
        End Set
    End Property

    Public Property MiddleName As String
        Get
            Return _middleName
        End Get
        Set(value As String)
            _middleName = value
        End Set
    End Property

    Public Property BirthDate As String
        Get
            Return _birthDate
        End Get
        Set(value As String)
            _birthDate = value
        End Set
    End Property

    Public Property HiredDate As String
        Get
            Return _hiredDate
        End Get
        Set(value As String)
            _hiredDate = value
        End Set
    End Property

    Public Property EmployeeType As String
        Get
            Return _employeeType
        End Get
        Set(value As String)
            _employeeType = value
        End Set
    End Property

    Public Property Salary As Double
        Get
            Return _salary
        End Get
        Set(value As Double)
            _salary = value
        End Set
    End Property

    Public Property OfficeCubeLoc As String
        Get
            Return _officeCubeLoc
        End Get
        Set(value As String)
            _officeCubeLoc = value
        End Set
    End Property

    Public Property WorkPhone As String
        Get
            Return _workPhone
        End Get
        Set(value As String)
            _workPhone = value
        End Set
    End Property

    Public Property WorkEmail As String
        Get
            Return _workEmail
        End Get
        Set(value As String)
            _workEmail = value
        End Set
    End Property

    Public Property MobilePhone As String
        Get
            Return _mobilePhone
        End Get
        Set(value As String)
            _mobilePhone = value
        End Set
    End Property

    Public Property PersonalPhone As String
        Get
            Return _personalPhone
        End Get
        Set(value As String)
            _personalPhone = value
        End Set
    End Property

    Public Property PersonalEmail As String
        Get
            Return _personalEmail
        End Get
        Set(value As String)
            _personalEmail = value
        End Set
    End Property

    Public Property NumOfDependents As Integer
        Get
            Return _numOfDependents
        End Get
        Set(value As Integer)
            _numOfDependents = value
        End Set
    End Property
End Class
