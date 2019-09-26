'**************************************************************************
'* Name:       Cesar Mendoza
'* Class:      CIS-2510
'* Assignment: Project 01
'* File:       frmEditEmployee.vb
'* Purpose:    This form allows the user to edit the employee information
'***************************************************************************

Imports System.Text.RegularExpressions

Public Class frmEditEmployee
    Private Sub frmEditEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ddlEmployeeType.Items.Add("Full-Time")
        ddlEmployeeType.Items.Add("Part-Time")

        If frmMain.currEmpIndex > -1 Then
            txtEmpNum.Text = frmMain.employeeList(frmMain.currEmpIndex).EmployeeNumber
            txtFirstName.Text = frmMain.employeeList(frmMain.currEmpIndex).FirstName
            txtLastName.Text = frmMain.employeeList(frmMain.currEmpIndex).LastName
            txtMiddleName.Text = frmMain.employeeList(frmMain.currEmpIndex).MiddleName
            mstBirthDate.Text = frmMain.employeeList(frmMain.currEmpIndex).BirthDate
            mstHiredDate.Text = frmMain.employeeList(frmMain.currEmpIndex).HiredDate

            If frmMain.employeeList(frmMain.currEmpIndex).EmployeeType = "F" Then
                ddlEmployeeType.SelectedIndex = 0
            Else
                ddlEmployeeType.SelectedIndex = 1
            End If
            txtSalary.Text = frmMain.employeeList(frmMain.currEmpIndex).Salary
            txtOffLoc.Text = frmMain.employeeList(frmMain.currEmpIndex).OfficeCubeLoc
            mstbWorkPhone.Text = frmMain.employeeList(frmMain.currEmpIndex).WorkPhone
            txtEmail.Text = frmMain.employeeList(frmMain.currEmpIndex).WorkEmail
            mstPersonalPhone.Text = frmMain.employeeList(frmMain.currEmpIndex).PersonalPhone
            mstMobilePhone.Text = frmMain.employeeList(frmMain.currEmpIndex).MobilePhone
            txtPersonalEmail.Text = frmMain.employeeList(frmMain.currEmpIndex).PersonalEmail
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim emailExpression As New Regex("^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$")
        lblErrorBirthDate.Visible = False
        lblErrorEmail.Visible = False
        lblErrorEmpNum.Visible = False
        lblErrorEmpType.Visible = False
        lblErrorFirstName.Visible = False
        lblErrorHiredDate.Visible = False
        lblErrorLastName.Visible = False
        lblErrorMiddleName.Visible = False
        lblErrorMobile.Visible = False
        lblErrorOffice.Visible = False
        lblErrorPersEmail.Visible = False
        lblErrorPersPhone.Visible = False
        lblErrorSalary.Visible = False
        lblErrorWorkPhone.Visible = False

        If txtEmpNum.Text.Trim() = "" Then
            lblErrorEmpNum.Visible = True
            MsgBox("Please enter a valid Employee Number!", MsgBoxStyle.Critical, "Error")
            txtEmpNum.Select()
            txtEmpNum.SelectAll()
            Return
        ElseIf txtFirstName.Text.Trim() = "" Then
            lblErrorFirstName.Visible = True
            MsgBox("Please enter a valid First Name!", MsgBoxStyle.Critical, "Error")
            txtFirstName.Select()
            txtFirstName.SelectAll()
            Return
        ElseIf txtLastName.Text.Trim() = "" Then
            lblErrorLastName.Visible = True
            MsgBox("Please enter a valid Last Name!", MsgBoxStyle.Critical, "Error")
            txtLastName.Select()
            txtLastName.SelectAll()
            Return
        ElseIf ddlEmployeeType.SelectedIndex = -1 Then
            lblErrorEmpType.Visible = True
            MsgBox("Plese select an employee type!", MsgBoxStyle.Critical, "Error")
            Return
        ElseIf txtSalary.Text.Trim() = "" Then
            lblErrorSalary.Visible = True
            MsgBox("Please enter a valid salary!", MsgBoxStyle.Critical, "Error")
            txtSalary.Select()
            txtSalary.SelectAll()
            Return
        ElseIf txtOffLoc.Text.Trim() = "" Then
            lblErrorOffice.Visible = True
            MsgBox("Please enter a valid office/cubicle location!", MsgBoxStyle.Critical, "Error")
            txtOffLoc.Select()
            txtOffLoc.SelectAll()
            Return
        End If

        frmMain.employeeList(frmMain.currEmpIndex).EmployeeNumber = txtEmpNum.Text
        frmMain.employeeList(frmMain.currEmpIndex).FirstName = txtFirstName.Text
        frmMain.employeeList(frmMain.currEmpIndex).LastName = txtLastName.Text
        frmMain.employeeList(frmMain.currEmpIndex).MiddleName = txtMiddleName.Text

        If mstBirthDate.MaskCompleted Then
            frmMain.employeeList(frmMain.currEmpIndex).BirthDate = mstBirthDate.Text
        Else
            lblErrorBirthDate.Visible = True
            MsgBox("Please enter a valid Birth Date!", MsgBoxStyle.Critical, "Error")
            mstBirthDate.Select()
            mstBirthDate.SelectAll()
            Return
        End If

        If mstHiredDate.MaskCompleted Then
            frmMain.employeeList(frmMain.currEmpIndex).HiredDate = mstHiredDate.Text
        Else
            lblErrorHiredDate.Visible = True
            MsgBox("Please enter a valid Hired Date!", MsgBoxStyle.Critical, "Error")
            mstHiredDate.Select()
            mstHiredDate.SelectAll()
            Return
        End If

        If ddlEmployeeType.SelectedIndex = 0 Then
            frmMain.getEmpType("F")
        ElseIf ddlEmployeeType.SelectedIndex = 1 Then
            frmMain.getEmpType("P")
        End If

        If IsNumeric(txtSalary.Text) Then
            frmMain.employeeList(frmMain.currEmpIndex).Salary = txtSalary.Text
        Else
            lblErrorSalary.Visible = True
            MsgBox("Please enter a valid salary!", MsgBoxStyle.Critical, "Error")
            txtSalary.Select()
            txtSalary.SelectAll()
            Return
        End If

        frmMain.employeeList(frmMain.currEmpIndex).OfficeCubeLoc = txtOffLoc.Text

        If mstbWorkPhone.MaskCompleted Then
            frmMain.employeeList(frmMain.currEmpIndex).WorkPhone = mstbWorkPhone.Text
        Else
            lblErrorWorkPhone.Visible = True
            MsgBox("Please enter a valid Work Phone!", MsgBoxStyle.Critical, "Error")
            mstbWorkPhone.Select()
            mstbWorkPhone.SelectAll()
            Return
        End If

        If emailExpression.IsMatch(txtEmail.Text) Then
            frmMain.employeeList(frmMain.currEmpIndex).WorkEmail = txtEmail.Text
        Else
            lblErrorEmail.Visible = True
            MsgBox("Please enter a valid email! (example@example.com)", MsgBoxStyle.Critical, "Error")
            txtEmail.Select()
            txtEmail.SelectAll()
            Return
        End If



        If mstPersonalPhone.MaskCompleted Then
            frmMain.employeeList(frmMain.currEmpIndex).PersonalPhone = mstPersonalPhone.Text
        Else
            lblErrorPersPhone.Visible = True
            MsgBox("Please enter a valid Personal Phone!", MsgBoxStyle.Critical, "Error")
            mstPersonalPhone.Select()
            mstPersonalPhone.SelectAll()
            Return
        End If
        frmMain.employeeList(frmMain.currEmpIndex).PersonalPhone = mstPersonalPhone.Text
        frmMain.employeeList(frmMain.currEmpIndex).MobilePhone = mstMobilePhone.Text

        If emailExpression.IsMatch(txtPersonalEmail.Text) Then
            frmMain.employeeList(frmMain.currEmpIndex).PersonalEmail = txtEmail.Text
        Else
            lblErrorPersEmail.Visible = True
            MsgBox("Please enter a valid email! (example@example.com)", MsgBoxStyle.Critical, "Error")
            txtPersonalEmail.Select()
            txtPersonalEmail.SelectAll()
            Return
        End If


        MsgBox("Employee saved succesfully!")

        Me.Close()
    End Sub

    Private Sub txtFirstName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFirstName.KeyPress
        Dim validCharacters As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXZYZ- "
        e.Handled = Not (validCharacters.IndexOf(e.KeyChar) > -1 OrElse e.KeyChar = Convert.ToChar(Keys.Back))
        'btnSave.Enabled = True
    End Sub

    Private Sub txtLastName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLastName.KeyPress
        Dim validCharacters As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXZYZ- "
        e.Handled = Not (validCharacters.IndexOf(e.KeyChar) > -1 OrElse e.KeyChar = Convert.ToChar(Keys.Back))
        'btnSave.Enabled = True
    End Sub

    Private Sub txtMiddleName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMiddleName.KeyPress
        Dim validCharacters As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXZYZ- "
        e.Handled = Not (validCharacters.IndexOf(e.KeyChar) > -1 OrElse e.KeyChar = Convert.ToChar(Keys.Back))
        'btnSave.Enabled = True
    End Sub

    Private Sub txtEmail_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEmail.KeyPress
        Dim validCharacters As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXZYZ0123456789&=-@_. "
        e.Handled = Not (validCharacters.IndexOf(e.KeyChar) > -1 OrElse e.KeyChar = Convert.ToChar(Keys.Back))
        'btnSave.Enabled = True
    End Sub

    Private Sub txtEmpNum_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEmpNum.KeyPress
        Dim validCharacters As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXZYZ0123456789&=-@_. "
        e.Handled = Not (validCharacters.IndexOf(e.KeyChar) > -1 OrElse e.KeyChar = Convert.ToChar(Keys.Back))
    End Sub

    Private Sub txtSalary_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSalary.KeyPress
        Dim validCharacters As String = "0123456789. "
        e.Handled = Not (validCharacters.IndexOf(e.KeyChar) > -1 OrElse e.KeyChar = Convert.ToChar(Keys.Back))
    End Sub

    Private Sub txtOffLoc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtOffLoc.KeyPress
        Dim validCharacters As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXZYZ0123456789&=-@_. "
        e.Handled = Not (validCharacters.IndexOf(e.KeyChar) > -1 OrElse e.KeyChar = Convert.ToChar(Keys.Back))
    End Sub

    Private Sub txtPersonalEmail_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPersonalEmail.KeyPress
        Dim validCharacters As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXZYZ0123456789&=-@_. "
        e.Handled = Not (validCharacters.IndexOf(e.KeyChar) > -1 OrElse e.KeyChar = Convert.ToChar(Keys.Back))
    End Sub
End Class