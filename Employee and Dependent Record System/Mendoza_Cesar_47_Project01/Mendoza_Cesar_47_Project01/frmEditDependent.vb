'********************************************************************
'* Name:       Cesar Mendoza
'* Class:      CIS-2510
'* Assignment: Project 01
'* File:       frmEditDependent.vb
'* Purpose:    This form allows the user to edit a selected dependent
'********************************************************************

Imports System.Text.RegularExpressions

Public Class frmEditDependent
    Private Sub frmEditDependent_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ddlDependentType.Items.Add("Spouse")
        ddlDependentType.Items.Add("Child")
        ddlDependentType.Items.Add("Other")

        If frmMain.currEmpIndex > -1 Then
            txtFirstName.Text = frmMain.employeeList(frmMain.currEmpIndex).FirstName
            txtLastName.Text = frmMain.employeeList(frmMain.currEmpIndex).LastName
            txtMiddleName.Text = frmMain.employeeList(frmMain.currEmpIndex).MiddleName
            mstBirthDate.Text = frmMain.employeeList(frmMain.currEmpIndex).BirthDate
            mstPhone.Text = frmMain.employeeList(frmMain.currEmpIndex).PersonalPhone
            mstMobilePhone.Text = frmMain.employeeList(frmMain.currEmpIndex).MobilePhone
            txtEmail.Text = frmMain.employeeList(frmMain.currEmpIndex).PersonalEmail
            If frmMain.employeeList(frmMain.currEmpIndex).DependentType = "S" Then
                ddlDependentType.SelectedIndex = 0
            ElseIf frmMain.employeeList(frmMain.currEmpIndex).DependentType = "C" Then
                ddlDependentType.SelectedIndex = 1
            ElseIf frmMain.employeeList(frmMain.currEmpIndex).DependentType = "O" Then
                ddlDependentType.SelectedIndex = 2
            End If
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim emailExpression As New Regex("^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$")
        If txtFirstName.Text.Trim() = "" Then
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
        ElseIf ddlDependentType.SelectedIndex = -1 Then
            lblErrorDepType.Visible = True
            MsgBox("Please select a dependent type!", MsgBoxStyle.Critical, "Error")
            Return
        End If

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

        frmMain.employeeList(frmMain.currEmpIndex).PersonalPhone = mstPhone.Text
        frmMain.employeeList(frmMain.currEmpIndex).MobilePhone = mstMobilePhone.Text

        If txtEmail.Text = "" Then
            frmMain.employeeList(frmMain.currEmpIndex).PersonalEmail = txtEmail.Text
        ElseIf emailExpression.IsMatch(txtEmail.Text) Then
            frmMain.employeeList(frmMain.currEmpIndex).PersonalEmail = txtEmail.Text
        Else
            lblErrorEmail.Visible = True
            MsgBox("Please enter a valid email adress! (example@example.com)", MsgBoxStyle.Critical, "Error")
            txtEmail.Select()
            txtEmail.SelectAll()
            Return
        End If


        If ddlDependentType.SelectedIndex = 0 Then
            frmMain.employeeList(frmMain.currEmpIndex).DependentType = "S"
        ElseIf ddlDependentType.SelectedIndex = 1 Then
            frmMain.employeeList(frmMain.currEmpIndex).DependentType = "C"
        ElseIf ddlDependentType.SelectedIndex = 2 Then
            frmMain.employeeList(frmMain.currEmpIndex).DependentType = "O"
        End If

        MsgBox("Dependent saved succesfully!")

        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
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

    Private Sub txtPhone_KeyPress(sender As Object, e As KeyPressEventArgs)
        Dim validCharacters As String = "0123456789-()"
        e.Handled = Not (validCharacters.IndexOf(e.KeyChar) > -1 OrElse e.KeyChar = Convert.ToChar(Keys.Back))
        'btnSave.Enabled = True
    End Sub

    Private Sub txtMobilePhone_KeyPress(sender As Object, e As KeyPressEventArgs)
        Dim validCharacters As String = "0123456789-()"
        e.Handled = Not (validCharacters.IndexOf(e.KeyChar) > -1 OrElse e.KeyChar = Convert.ToChar(Keys.Back))
    End Sub

    Private Sub txtEmail_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEmail.KeyPress
        Dim validCharacters As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXZYZ0123456789&=-@_. "
        e.Handled = Not (validCharacters.IndexOf(e.KeyChar) > -1 OrElse e.KeyChar = Convert.ToChar(Keys.Back))
        'btnSave.Enabled = True
    End Sub
End Class