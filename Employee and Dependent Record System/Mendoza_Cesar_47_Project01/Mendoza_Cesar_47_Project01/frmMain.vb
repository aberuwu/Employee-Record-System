'---------------------------------------------------------------------
'* Name:       Cesar Mendoza
'* Class:      CIS-2510
'* Assignment: Project 01
'* File:       frmMain.vb
'* Purpose:    This is the main form for the employee tree view
'*             It displays the treeview, allows user to create new 
'*             organization, add employees, dependents, save, move,
'*             and delete.
'---------------------------------------------------------------------

Imports System.Xml

Public Class frmMain
    Public Property employeeList As List(Of Employee) = New List(Of Employee)
    Public Property dependentList As List(Of Dependent) = New List(Of Dependent)
    Public Property employeeCount As Integer = 0
    Public Property dependentCount As Integer = 0
    Public Property currEmpIndex As Integer = 0

    Private BOOK_SOURCE_XML As String
    Public closingNewEmp As Boolean = False
    Public closingNewDep As Boolean = False
    Public Property nodeIndex As TreeNode

    Private employeeNumber As String = ""
    Private firstName As String = ""
    Private lastName As String = ""
    Private middlName As String = ""
    Private birthDate As String = ""
    Private hiredDate As String = ""
    Private employeeType As String = ""
    Private salary As Double = 0
    Private officeLocation As String = ""
    Private workPhone As String = ""
    Private workEmail As String = ""
    Private mobilePhone As String = ""
    Private personalPhone As String = ""
    Private personalEmail As String = ""
    Private dependentType As String = ""
    Private presCount As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub tsbtnNew_Click(sender As Object, e As EventArgs) Handles tsbtnNew.Click
        Dim result As Integer = MessageBox.Show("Are you sure you want to close? All unsaved work will be lost.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)

        If result = DialogResult.No Then
            Return
        Else
            employeeList.Clear()
            dependentList.Clear()
            trvEmployeesDepend.Nodes.Clear()

            lblEmpNum.Visible = False
            lblFirstName.Visible = False
            lblLastName.Visible = False
            lblMiddleName.Visible = False
            lblBirthDate.Visible = False
            lblMobileNum.Visible = False
            lblHiredDate.Visible = False
            lblEmpType.Visible = False
            lblSalary.Visible = False
            lblOfficeLoc.Visible = False
            lblWorkPhone.Visible = False
            lblWorkEmail.Visible = False
            lblWorkPhone.Visible = False
            lblPersonalEm.Visible = False
            lblPersonalNum.Visible = False

            btnAddEmployee.Enabled = True
            btnEdit.Enabled = False
            btnDelete.Enabled = False
            btnAddDependent.Enabled = False
        End If
    End Sub

    Private Sub btnAddEmployee_Click(sender As Object, e As EventArgs) Handles btnAddEmployee.Click
        Dim newEmpRecordForm As frmNewEmployee
        Dim newNode As TreeNode
        Dim userSelectedNode As TreeNode = trvEmployeesDepend.SelectedNode

        If presCount = 1 Then
            If userSelectedNode Is Nothing Then
                MsgBox("Please select a node")
                Return
            End If
        End If

        If userSelectedNode IsNot Nothing AndAlso userSelectedNode.Level = 5 Then 'Level 6
            MsgBox("You may only have up to six levels in your hierarchy")
            Return
        End If

        newEmpRecordForm = New frmNewEmployee()
        newEmpRecordForm.ShowDialog()

        If firstName = "" Then
            Return
        End If

        If closingNewEmp = True Then
            Return
        End If

        employeeList.Add(New Employee)

        employeeList(employeeCount).EmployeeNumber = employeeNumber
        employeeList(employeeCount).FirstName = firstName
        employeeList(employeeCount).LastName = lastName
        employeeList(employeeCount).MiddleName = middlName
        employeeList(employeeCount).BirthDate = birthDate
        employeeList(employeeCount).HiredDate = hiredDate
        employeeList(employeeCount).EmployeeType = employeeType
        employeeList(employeeCount).Salary = salary
        employeeList(employeeCount).OfficeCubeLoc = officeLocation
        employeeList(employeeCount).WorkPhone = workPhone
        employeeList(employeeCount).WorkEmail = workEmail
        employeeList(employeeCount).PersonalEmail = personalEmail
        employeeList(employeeCount).PersonalPhone = personalPhone
        employeeList(employeeCount).MobilePhone = mobilePhone
        employeeList(employeeCount).NumOfDependents = 0

        If employeeCount = 0 Then
            newNode = trvEmployeesDepend.Nodes.Add(employeeCount, lastName & ", " & firstName)
            newNode.ImageIndex = 0
            newNode.SelectedImageIndex = 0
            presCount += 1
        Else
            newNode = userSelectedNode.Nodes.Add(employeeCount, lastName & ", " & firstName)
            newNode.ImageIndex = 1
            newNode.SelectedImageIndex = 1
        End If

        newNode.ToolTipText = employeeList(employeeCount).EmployeeNumber & " [" & employeeList(employeeCount).OfficeCubeLoc & "]"

        employeeCount += 1
    End Sub

    Private Sub btnAddDependent_Click(sender As Object, e As EventArgs) Handles btnAddDependent.Click
        Dim newDependentRecordForm As frmNewDependent
        Dim newNode As TreeNode
        Dim userSelectedNode As TreeNode = trvEmployeesDepend.SelectedNode
        Dim empIndex As Integer = trvEmployeesDepend.SelectedNode.Name

        nodeIndex = trvEmployeesDepend.SelectedNode

        newDependentRecordForm = New frmNewDependent()
        newDependentRecordForm.ShowDialog()

        If firstName = "" Then
            Return
        End If

        employeeList.Add(New Employee)

        employeeList(employeeCount).FirstName = firstName
        employeeList(employeeCount).LastName = lastName
        employeeList(employeeCount).DependentType = dependentType
        employeeList(employeeCount).MiddleName = middlName
        employeeList(employeeCount).PersonalPhone = personalPhone
        employeeList(employeeCount).PersonalEmail = personalEmail
        employeeList(employeeCount).MobilePhone = mobilePhone
        employeeList(employeeCount).BirthDate = birthDate

        newNode = userSelectedNode.Nodes.Add(employeeCount, lastName & ", " & firstName)
        newNode.ImageIndex = 2
        newNode.SelectedImageIndex = 2

        If employeeList(employeeCount).DependentType = "S" Then
            newNode.ToolTipText = "Spouse"
        ElseIf employeeList(employeeCount).DependentType = "C" Then
            newNode.ToolTipText = "Child"
        Else
            newNode.ToolTipText = "Other"
        End If

        employeeCount += 1

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim editDependentRecordForm As frmEditDependent
        Dim editEmployeeRecordForm As frmEditEmployee
        Dim empIndex As Integer = trvEmployeesDepend.SelectedNode.Name
        Dim userSelectedNode As TreeNode = trvEmployeesDepend.SelectedNode

        If employeeList(empIndex).DependentType = "S" Or employeeList(empIndex).DependentType = "C" _
            Or employeeList(empIndex).DependentType = "O" Then 'Level 6
            editDependentRecordForm = New frmEditDependent()
            currEmpIndex = empIndex
            editDependentRecordForm.ShowDialog()

            trvEmployeesDepend.SelectedNode.Text = employeeList(empIndex).LastName & ", " & employeeList(empIndex).FirstName

            lblFirstName.Text = employeeList(empIndex).FirstName
            lblLastName.Text = employeeList(empIndex).LastName
            lblMiddleName.Text = employeeList(empIndex).MiddleName
            lblMobileNum.Text = employeeList(empIndex).MobilePhone
            lblPersonalNum.Text = employeeList(empIndex).PersonalPhone
            lblPersonalEm.Text = employeeList(empIndex).PersonalEmail
            lblBirthDate.Text = employeeList(empIndex).BirthDate
            lblEmpType.Text = employeeList(empIndex).DependentType

            If employeeList(empIndex).DependentType = "S" Then
                userSelectedNode.ToolTipText = "Spouse"
            ElseIf employeeList(empIndex).DependentType = "C" Then
                userSelectedNode.ToolTipText = "Child"
            Else
                userSelectedNode.ToolTipText = "Other"
            End If
        Else
            editEmployeeRecordForm = New frmEditEmployee()
            currEmpIndex = empIndex
            editEmployeeRecordForm.ShowDialog()

            trvEmployeesDepend.SelectedNode.Text = employeeList(empIndex).LastName & ", " & employeeList(empIndex).FirstName

            lblEmpNum.Text = employeeList(empIndex).EmployeeNumber
            lblFirstName.Text = employeeList(empIndex).FirstName
            lblLastName.Text = employeeList(empIndex).LastName
            lblMiddleName.Text = employeeList(empIndex).MiddleName
            lblSalary.Text = employeeList(empIndex).Salary
            lblOfficeLoc.Text = employeeList(empIndex).OfficeCubeLoc
            lblWorkPhone.Text = employeeList(empIndex).WorkPhone
            lblWorkEmail.Text = employeeList(empIndex).WorkEmail
            lblMobileNum.Text = employeeList(empIndex).MobilePhone
            lblPersonalNum.Text = employeeList(empIndex).PersonalPhone
            lblPersonalEm.Text = employeeList(empIndex).PersonalEmail
            lblBirthDate.Text = employeeList(empIndex).BirthDate
            lblHiredDate.Text = employeeList(empIndex).HiredDate
            lblEmpType.Text = employeeList(empIndex).EmployeeType

        End If
    End Sub

    Private Sub RecursNodesRefresh(NodeCollection As TreeNodeCollection)
        For Each tn As TreeNode In NodeCollection
            MsgBox(tn.Text)
            RecursNodesRefresh(tn.Nodes)
        Next
    End Sub

    Private Sub trvEmployeesDepend_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles trvEmployeesDepend.AfterSelect
        Dim empIndex As Integer = trvEmployeesDepend.SelectedNode.Name
        Dim depIndex As Integer = trvEmployeesDepend.SelectedNode.Name
        currEmpIndex = empIndex

        btnEdit.Enabled = True
        btnDelete.Enabled = True

        If employeeList(empIndex).DependentType = "S" Or employeeList(empIndex).DependentType = "C" _
            Or employeeList(empIndex).DependentType = "O" Then 'Level 6
            btnAddDependent.Enabled = False
            'tsbtnNew.Enabled = False
            btnAddEmployee.Enabled = False
            lblFirstName.Location = New Point(575, 51)
            lblFirstNameHeading.Location = New Point(420, 51)
            lblLastName.Location = New Point(575, 83)
            lblLastNameHeading.Location = New Point(420, 83)
            lblMiddleName.Location = New Point(575, 115)
            lblMiddleNameHeading.Location = New Point(420, 115)
            lblBirthDate.Location = New Point(575, 147)
            lblBirthDateHeading.Location = New Point(420, 147)
            lblEmpType.Location = New Point(575, 179)
            lblEmpTypeHeading.Location = New Point(420, 179)
            lblMobileNum.Location = New Point(575, 243)
            lblMobileHeading.Location = New Point(420, 243)
            lblPersonalNum.Location = New Point(576, 211)
            lblPersonalPhoneHeading.Location = New Point(420, 211)
            lblPersonalEm.Location = New Point(575, 275)
            lblPersonalEmailHeading.Location = New Point(420, 275)

            lblEmpNum.Visible = False
            lblEmpNumHeading.Visible = False
            lblHiredDate.Visible = False
            lblHiredDateHeading.Visible = False
            'lblEmpType.Visible = False
            'lblEmpTypeHeading.Visible = False
            lblSalary.Visible = False
            lblSalaryHeading.Visible = False
            lblOfficeLoc.Visible = False
            lblOfficeLocHeading.Visible = False
            lblWorkPhone.Visible = False
            lblWorkPhoneHeading.Visible = False
            lblWorkEmail.Visible = False
            lblEmailHeading.Visible = False
            lblWorkPhoneHeading.Visible = False

            lblFirstName.Visible = True
            lblLastName.Visible = True
            lblMiddleName.Visible = True
            lblEmpType.Visible = True
            lblMobileNum.Visible = True
            lblPersonalNum.Visible = True
            lblPersonalEm.Visible = True
            lblBirthDate.Visible = True

        ElseIf employeeList(empIndex).EmployeeType = "F" Or employeeList(empIndex).EmployeeType = "P" Then
            lblEmpNum.Location = New Point(575, 51)
            lblEmpNumHeading.Location = New Point(420, 51)
            lblFirstName.Location = New Point(575, 83)
            lblFirstNameHeading.Location = New Point(420, 83)
            lblLastName.Location = New Point(575, 115)
            lblLastNameHeading.Location = New Point(420, 115)
            lblMiddleName.Location = New Point(575, 147)
            lblMiddleNameHeading.Location = New Point(420, 147)
            lblBirthDate.Location = New Point(575, 179)
            lblBirthDateHeading.Location = New Point(420, 179)
            lblMobileNum.Location = New Point(576, 403)
            lblMobileHeading.Location = New Point(420, 403)
            lblPersonalNum.Location = New Point(576, 435)
            lblPersonalPhoneHeading.Location = New Point(420, 435)
            lblMobileNum.Location = New Point(576, 403)
            lblMobileHeading.Location = New Point(420, 403)
            lblPersonalEm.Location = New Point(576, 467)
            lblPersonalEmailHeading.Location = New Point(420, 467)
            lblEmpType.Location = New Point(575, 243)
            lblEmpTypeHeading.Location = New Point(420, 243)
            lblSalary.Location = New Point(575, 275)
            lblSalaryHeading.Location = New Point(420, 275)
            lblOfficeLoc.Location = New Point(576, 307)
            lblOfficeLocHeading.Location = New Point(420, 307)
            lblWorkPhone.Location = New Point(575, 339)
            lblWorkPhoneHeading.Location = New Point(420, 339)
            lblWorkEmail.Location = New Point(575, 371)
            lblEmailHeading.Location = New Point(420, 371)

            lblEmpNum.Visible = True
            lblFirstName.Visible = True
            lblLastName.Visible = True
            lblMiddleName.Visible = True
            lblEmpType.Visible = True
            lblSalary.Visible = True
            lblOfficeLoc.Visible = True
            lblWorkPhone.Visible = True
            lblWorkEmail.Visible = True
            lblMobileNum.Visible = True
            lblPersonalNum.Visible = True
            lblPersonalEm.Visible = True
            btnAddDependent.Visible = True
            lblHiredDate.Visible = True
            lblBirthDate.Visible = True
            lblEmpNumHeading.Visible = True
            lblHiredDateHeading.Visible = True
            lblSalaryHeading.Visible = True
            lblOfficeLocHeading.Visible = True
            lblWorkPhoneHeading.Visible = True
            lblEmailHeading.Visible = True

            btnAddDependent.Enabled = True
            'tsbtnNew.Enabled = True
            btnAddEmployee.Enabled = True
        End If

        lblEmpNum.Text = employeeList(empIndex).EmployeeNumber
        lblFirstName.Text = employeeList(empIndex).FirstName
        lblLastName.Text = employeeList(empIndex).LastName
        lblMiddleName.Text = employeeList(empIndex).MiddleName
        If employeeList(empIndex).EmployeeType = "F" Or employeeList(empIndex).EmployeeType = "P" Then
            lblEmpTypeHeading.Text = "Employee Type"
            lblEmpType.Text = employeeList(empIndex).EmployeeType
        ElseIf employeeList(empIndex).DependentType = "S" Or employeeList(empIndex).DependentType = "C" _
            Or employeeList(empIndex).DependentType = "O" Then
            lblEmpTypeHeading.Text = "Dependent Type"
            lblEmpType.Text = employeeList(empIndex).DependentType
        End If

        If employeeList(empIndex).EmployeeType = "F" Then
            lblSalaryHeading.Text = "Salary (yearly)"
        ElseIf employeeList(empIndex).EmployeeType = "P" Then
            lblSalaryHeading.Text = "Salary (hourly)"
        Else
            lblSalaryHeading.Text = "Salary"
        End If

        lblSalary.Text = "$ " & employeeList(empIndex).Salary.ToString("N2")
        lblOfficeLoc.Text = employeeList(empIndex).OfficeCubeLoc
        lblWorkPhone.Text = employeeList(empIndex).WorkPhone
        lblWorkEmail.Text = employeeList(empIndex).WorkEmail
        lblMobileNum.Text = employeeList(empIndex).MobilePhone
        lblPersonalNum.Text = employeeList(empIndex).PersonalPhone
        lblPersonalEm.Text = employeeList(empIndex).PersonalEmail
        lblBirthDate.Text = employeeList(empIndex).BirthDate
        lblHiredDate.Text = employeeList(empIndex).HiredDate
    End Sub

    Private Sub tsbtnOpen_Click(sender As Object, e As EventArgs) Handles tsbtnOpen.Click
        Dim ofpXml As OpenFileDialog = New OpenFileDialog()

        If ofpXml.ShowDialog = DialogResult.OK Then
            BOOK_SOURCE_XML = ofpXml.FileName
            loadXmlFile()
            tsbtnSave.Enabled = True
            lblEmpNum.Visible = False
            lblFirstName.Visible = False
            lblLastName.Visible = False
            lblMiddleName.Visible = False
            lblBirthDate.Visible = False
            lblMobileNum.Visible = False
            lblHiredDate.Visible = False
            lblEmpType.Visible = False
            lblSalary.Visible = False
            lblOfficeLoc.Visible = False
            lblWorkPhone.Visible = False
            lblWorkEmail.Visible = False
            lblWorkPhone.Visible = False
            lblPersonalEm.Visible = False
            lblPersonalNum.Visible = False
            btnEdit.Enabled = False
            btnDelete.Enabled = False
            btnAddDependent.Enabled = False
            trvEmployeesDepend.SelectedNode = trvEmployeesDepend.Nodes(0)
        End If
    End Sub

    Private Sub tsbtnSave_Click(sender As Object, e As EventArgs) Handles tsbtnSave.Click
        Dim settings As XmlWriterSettings = New XmlWriterSettings()
        settings.Indent = True
        settings.IndentChars = "    "

        Dim xmlOut As XmlWriter = XmlWriter.Create(BOOK_SOURCE_XML, settings)

        xmlOut.WriteStartDocument()
        xmlOut.WriteStartElement("organization")

        RecursNodesSaveToXml(trvEmployeesDepend.Nodes, xmlOut)

        xmlOut.WriteEndElement()
        xmlOut.Close()
    End Sub

    Private Sub tosbtnSaveAs_Click(sender As Object, e As EventArgs) Handles tosbtnSaveAs.Click
        Dim saveWindow As SaveFileDialog = New SaveFileDialog()
        saveWindow.Filter = "Employee File|*.xml"
        saveWindow.Title = "Save a Employee File"
        saveWindow.ShowDialog()

        If saveWindow.FileName = "" Then
            Return
        End If

        BOOK_SOURCE_XML = saveWindow.FileName

        Dim settings As XmlWriterSettings = New XmlWriterSettings()

        settings.Indent = True
        settings.IndentChars = "    "

        Dim xmlOut As XmlWriter = XmlWriter.Create(saveWindow.FileName, settings)

        xmlOut.WriteStartDocument()
        xmlOut.WriteStartElement("organization")

        RecursNodesSaveToXml(trvEmployeesDepend.Nodes, xmlOut)

        xmlOut.WriteEndElement()
        xmlOut.Close()
        tsbtnSave.Enabled = True
    End Sub

    Private Sub RecursNodesSaveToXml(ByVal NodeCollection As TreeNodeCollection, ByVal xmlWrite As XmlWriter)
        Dim tempDate As String
        Dim year As String
        Dim month As String
        Dim month2 As String
        Dim day As String
        Dim day2 As String
        Dim formatedDate As String

        For Each tn As TreeNode In NodeCollection
            If employeeList(tn.Name).DependentType = "S" Or employeeList(tn.Name).DependentType = "C" _
            Or employeeList(tn.Name).DependentType = "O" Then
                xmlWrite.WriteStartElement("dependent")
                xmlWrite.WriteAttributeString("lname", employeeList(tn.Name).LastName)
                xmlWrite.WriteAttributeString("fname", employeeList(tn.Name).FirstName)
                xmlWrite.WriteAttributeString("mname", employeeList(tn.Name).MiddleName)

                tempDate = employeeList(tn.Name).BirthDate.Replace("/", "")
                year = tempDate.Remove(0, 4)
                month = tempDate.Remove(1, 6)
                day = tempDate.Remove(0, 2)
                day2 = day.Remove(2, 4)
                formatedDate = year & month & day2
                xmlWrite.WriteAttributeString("bdate", formatedDate)
                xmlWrite.WriteAttributeString("type", employeeList(tn.Name).DependentType)
                xmlWrite.WriteAttributeString("phone", employeeList(tn.Name).PersonalPhone)
                xmlWrite.WriteAttributeString("mobile", employeeList(tn.Name).MobilePhone)
                xmlWrite.WriteAttributeString("email", employeeList(tn.Name).PersonalEmail)
            Else
                xmlWrite.WriteStartElement("employee")
                xmlWrite.WriteAttributeString("empno", employeeList(tn.Name).EmployeeNumber)
                xmlWrite.WriteAttributeString("lname", employeeList(tn.Name).LastName)
                xmlWrite.WriteAttributeString("fname", employeeList(tn.Name).FirstName)
                xmlWrite.WriteAttributeString("mname", employeeList(tn.Name).MiddleName)
                tempDate = employeeList(tn.Name).BirthDate.Replace("/", "")
                year = tempDate.Remove(0, 4)
                month = tempDate.Remove(1, 6)
                day = tempDate.Remove(0, 2)
                day2 = day.Remove(2, 4)
                formatedDate = year & month & day2
                xmlWrite.WriteAttributeString("bdate", formatedDate)
                tempDate = employeeList(tn.Name).HiredDate.Replace("/", "")
                year = tempDate.Remove(0, 4)
                month = tempDate.Remove(1, 6)
                day = tempDate.Remove(0, 2)
                day2 = day.Remove(2, 4)
                formatedDate = year & month & day2
                xmlWrite.WriteAttributeString("hired", formatedDate)
                xmlWrite.WriteAttributeString("type", employeeList(tn.Name).EmployeeType)
                If employeeList(tn.Name).EmployeeType = "P" Then
                    xmlWrite.WriteAttributeString("hourly", employeeList(tn.Name).Salary)
                Else
                    xmlWrite.WriteAttributeString("annual", employeeList(tn.Name).Salary)
                End If
                xmlWrite.WriteAttributeString("location", employeeList(tn.Name).OfficeCubeLoc)
                xmlWrite.WriteAttributeString("wphone", employeeList(tn.Name).WorkPhone)
                xmlWrite.WriteAttributeString("wemail", employeeList(tn.Name).WorkEmail)
                xmlWrite.WriteAttributeString("mobile", employeeList(tn.Name).MobilePhone)
                xmlWrite.WriteAttributeString("pphone", employeeList(tn.Name).PersonalPhone)
                xmlWrite.WriteAttributeString("pemail", employeeList(tn.Name).PersonalEmail)
            End If

            RecursNodesSaveToXml(tn.Nodes, xmlWrite)

            xmlWrite.WriteEndElement()
        Next
    End Sub

    Private Sub loadXmlFile()
        employeeList.Clear()
        dependentList.Clear()
        trvEmployeesDepend.Nodes.Clear()
        employeeCount = 0
        dependentCount = 0

        Dim settings As XmlReaderSettings = New XmlReaderSettings
        settings.IgnoreWhitespace = True
        settings.IgnoreComments = True

        Dim reader As XmlReader = XmlReader.Create(BOOK_SOURCE_XML, settings)

        reader.Read()

        While reader.ReadState <> ReadState.EndOfFile

            If reader.Name = "organization" AndAlso reader.NodeType = XmlNodeType.Element Then
                recursXmlReader(reader.ReadSubtree(), Nothing)
            End If

            reader.Read()
        End While

        reader.Close()
        trvEmployeesDepend.Nodes(0).ExpandAll()
    End Sub

    Private Sub recursXmlReader(reader As XmlReader, node As TreeNode)
        Dim newNode As TreeNode
        Dim tempDate As String
        Dim year As String
        Dim month As String
        Dim month2 As String
        Dim day As String
        Dim formatedDate As String

        reader.Read()

        While reader.ReadState <> ReadState.EndOfFile
            If reader.Name = "employee" AndAlso reader.NodeType = XmlNodeType.Element Then
                employeeList.Add(New Employee)
                employeeList(employeeCount).EmployeeNumber = reader("empno")
                employeeList(employeeCount).FirstName = reader("fname")
                employeeList(employeeCount).LastName = reader("lname")
                employeeList(employeeCount).MiddleName = reader("mname")
                tempDate = reader("bdate")

                If tempDate = "" Then
                    employeeList(employeeCount).BirthDate = tempDate
                Else
                    year = tempDate.Remove(4, 4)
                    month = tempDate.Remove(0, 4)
                    month2 = month.Remove(2, 2)
                    day = tempDate.Remove(0, 6)
                    formatedDate = month2 & "/" & day & "/" & year

                    employeeList(employeeCount).BirthDate = formatedDate
                End If

                tempDate = reader("hired")

                If tempDate = "" Then
                    employeeList(employeeCount).HiredDate = tempDate
                Else
                    year = tempDate.Remove(4, 4)
                    month = tempDate.Remove(0, 4)
                    month2 = month.Remove(2, 2)
                    day = tempDate.Remove(0, 6)
                    formatedDate = month2 & "/" & day & "/" & year
                    employeeList(employeeCount).HiredDate = formatedDate
                End If

                employeeList(employeeCount).EmployeeType = reader("type")
                If reader("type") = "F" Then
                    employeeList(employeeCount).Salary = reader("annual")
                Else
                    employeeList(employeeCount).Salary = reader("hourly")
                End If

                employeeList(employeeCount).OfficeCubeLoc = reader("location")
                employeeList(employeeCount).WorkPhone = reader("wphone")
                employeeList(employeeCount).WorkEmail = reader("wemail")
                employeeList(employeeCount).MobilePhone = reader("mobile")
                employeeList(employeeCount).PersonalPhone = reader("pphone")
                employeeList(employeeCount).PersonalEmail = reader("pemail")

                If employeeCount = 0 Then
                    newNode = trvEmployeesDepend.Nodes.Add(employeeCount, reader("lname") & ", " & reader("fname"))
                    newNode.ImageIndex = 0
                    newNode.SelectedImageIndex = 0
                Else
                    newNode = node.Nodes.Add(employeeCount, reader("lname") & ", " & reader("fname"))
                    newNode.ImageIndex = 1
                    newNode.SelectedImageIndex = 1
                End If
                newNode.ToolTipText = employeeList(employeeCount).EmployeeNumber & " [" & employeeList(employeeCount).OfficeCubeLoc & "]"

                employeeCount += 1
                reader.Read()

                While reader.ReadState <> ReadState.EndOfFile
                    If (reader.Name = "employee" OrElse reader.Name = "Subemployee" OrElse reader.Name = "dependent") AndAlso reader.NodeType = XmlNodeType.Element Then
                        recursXmlReader(reader.ReadSubtree(), newNode)
                    End If

                    reader.Read()
                End While

            ElseIf reader.Name = "Subemployee" AndAlso reader.NodeType = XmlNodeType.Element Then

                employeeList.Add(New Employee)
                employeeList(employeeCount).FirstName = reader("Subfname")
                employeeList(employeeCount).LastName = reader("Sublname")
                newNode = node.Nodes.Add(employeeCount, reader("Sublname" & ", " & "Subfname"))
                dependentCount += 1

            ElseIf reader.Name = "dependent" AndAlso reader.NodeType = XmlNodeType.Element Then

                employeeList.Add(New Employee)
                employeeList(employeeCount).FirstName = reader("fname")
                employeeList(employeeCount).LastName = reader("lname")
                employeeList(employeeCount).DependentType = reader("type")
                employeeList(employeeCount).MiddleName = reader("mname")
                tempDate = reader("bdate")

                If tempDate = "" Then
                    employeeList(employeeCount).BirthDate = tempDate
                Else
                    year = tempDate.Remove(4, 4)
                    month = tempDate.Remove(0, 4)
                    month2 = month.Remove(2, 2)
                    day = tempDate.Remove(0, 6)
                    formatedDate = month2 & "/" & day & "/" & year

                    employeeList(employeeCount).BirthDate = formatedDate
                End If

                employeeList(employeeCount).PersonalPhone = reader("phone")
                employeeList(employeeCount).MobilePhone = reader("mobile")
                employeeList(employeeCount).PersonalEmail = reader("email")

                newNode = node.Nodes.Add(employeeCount, employeeList(employeeCount).LastName & ", " & employeeList(employeeCount).FirstName)
                newNode.ImageIndex = 2
                newNode.SelectedImageIndex = 2
                If employeeList(employeeCount).DependentType = "S" Then
                    newNode.ToolTipText = "Spouse"
                ElseIf employeeList(employeeCount).DependentType = "C" Then
                    newNode.ToolTipText = "Child"
                Else
                    newNode.ToolTipText = "Other"
                End If

                employeeCount += 1
            End If

            reader.Read()

        End While

        reader.Close()
    End Sub

    'DRAG DROP
    Private Sub trvEmployeesDepend_ItemDrag(sender As Object, e As ItemDragEventArgs) Handles trvEmployeesDepend.ItemDrag

        If currEmpIndex = 0 Or employeeList(currEmpIndex).DependentType = "S" Or employeeList(currEmpIndex).DependentType = "C" _
            Or employeeList(currEmpIndex).DependentType = "O" Then
            trvEmployeesDepend.AllowDrop = False
        Else
            trvEmployeesDepend.AllowDrop = True
            DoDragDrop(e.Item, DragDropEffects.Move)
        End If
    End Sub

    Private Sub trvEmployeesDepend_DragEnter(sender As Object, e As DragEventArgs) Handles trvEmployeesDepend.DragEnter
        If currEmpIndex = 0 Or employeeList(currEmpIndex).DependentType = "S" Or employeeList(currEmpIndex).DependentType = "C" _
            Or employeeList(currEmpIndex).DependentType = "O" Then
            trvEmployeesDepend.AllowDrop = False
        Else
            trvEmployeesDepend.AllowDrop = True
            e.Effect = DragDropEffects.Move
        End If
    End Sub

    Private Sub trvEmployeesDepend_DragDrop(sender As Object, e As DragEventArgs) Handles trvEmployeesDepend.DragDrop
        Dim newNode As TreeNode
        If e.Data.GetDataPresent("System.Windows.Forms.TreeNode", False) Then
            Dim point As Point
            Dim destNode As TreeNode

            point = trvEmployeesDepend.PointToClient(New Point(e.X, e.Y))

            destNode = trvEmployeesDepend.GetNodeAt(point)

            newNode = CType(e.Data.GetData("System.Windows.Forms.TreeNode"), TreeNode)
            If Not destNode.Equals(newNode) Then
                destNode.Nodes.Add(CType(newNode.Clone, TreeNode))
                destNode.Expand()
                newNode.Remove()
            End If

        End If
    End Sub

    'Getter functions
    Public Sub getEmpNum(empNum As String)
        employeeNumber = empNum
    End Sub

    Public Sub getEmpFirstName(name As String)
        firstName = name
    End Sub

    Public Sub getLast(lname As String)
        lastName = lname
    End Sub

    Public Sub getMid(mName As String)
        middlName = mName
    End Sub

    Public Sub getEmpType(empT As String)
        employeeType = empT
    End Sub

    Public Sub getSalary(sal As Double)
        salary = sal
    End Sub

    Public Sub getOff(offLoc As String)
        officeLocation = offLoc
    End Sub

    Public Sub getWorkPhn(wrkPhn As String)
        workPhone = wrkPhn
    End Sub

    Public Sub getWorkEmail(wrkEm As String)
        workEmail = wrkEm
    End Sub

    Public Sub getMobPhn(mobPhn As String)
        mobilePhone = mobPhn
    End Sub

    Public Sub getPerPhn(perPhn As String)
        personalPhone = perPhn
    End Sub

    Public Sub getPerEmail(perEmail As String)
        personalEmail = perEmail
    End Sub

    Public Sub getDependent(depType As String)
        dependentType = depType
    End Sub

    Public Sub getBirthDate(bDate As String)
        birthDate = bDate
    End Sub

    Public Sub getHiredDate(hDate As String)
        hiredDate = hDate
    End Sub

    Private Sub testLists()
        For i As Integer = 0 To employeeCount - 1
            MsgBox("This is an employee: " & employeeList(i).EmployeeNumber)
        Next

        For i As Integer = 0 To dependentCount - 1
            MsgBox("This is a dependent: " & dependentList(i).FirstName)
        Next
    End Sub

    Private Sub btnTestLists_Click(sender As Object, e As EventArgs) Handles btnTestLists.Click
        testLists()
    End Sub

    Private Sub btnTraverse_Click(sender As Object, e As EventArgs) Handles btnTraverse.Click
        RecursNodesMessageBoxes(trvEmployeesDepend.Nodes)
    End Sub

    Private Sub RecursNodesMessageBoxes(NodeCollection As TreeNodeCollection)
        For Each tn As TreeNode In NodeCollection
            MsgBox(tn.Text)
            RecursNodesMessageBoxes(tn.Nodes)
        Next
    End Sub

    Private Sub btnCount_Click(sender As Object, e As EventArgs) Handles btnCount.Click
        MsgBox("The count of nodes is: " & employeeCount)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim result As Integer = MessageBox.Show("Are you sure you want to delete " & employeeList(currEmpIndex).FirstName & " " & employeeList(currEmpIndex).LastName & "?",
                                                "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
        Dim nodeToRemove As TreeNode = trvEmployeesDepend.SelectedNode
        Dim parentNode As TreeNode = nodeToRemove.Parent
        Dim childNode As TreeNode
        Dim childCount As Integer = 0

        If currEmpIndex = 0 Then
            MsgBox("You can't delete the company CEO!", MsgBoxStyle.Critical, "Error")
            Return
        End If

        If result = DialogResult.No Then
            Return
        Else
            If currEmpIndex = 0 Then
                Return
            Else
                For Each child As TreeNode In parentNode.Nodes
                    childCount += 1
                Next

                For i As Integer = nodeToRemove.Nodes.Count To childCount
                    If employeeList(i).DependentType = "S" Or employeeList(i).DependentType = "C" _
                    Or employeeList(i).DependentType = "O" Then
                        parentNode.Nodes.Remove(nodeToRemove)
                    Else
                        For c As Integer = nodeToRemove.Nodes.Count - 1 To 0 Step -1

                            childNode = nodeToRemove.Nodes(c)
                            nodeToRemove.Nodes.Remove(childNode)
                            parentNode.Nodes.Add(childNode)
                        Next
                    End If
                Next
            End If
        End If

    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim result As Integer = MessageBox.Show("Are you sure you want to close?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)

        If result = DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
