'-------------------------------------------------------------------
'* Name:       Cesar Mendoza
'* Class:      CIS-2510
'* Assignment: Project 01
'* File:       frmNewDependent.vb
'* Purpose:    This form allows the user to add a new dependent
'-------------------------------------------------------------------

Imports System.Text.RegularExpressions

Public Class frmNewDependent
    Private Random As New Random

    Private firstName As String = ""
    Private lastName As String = ""
    Private middlName As String = ""
    Private birthDate As String = ""
    Private mobilePhone As String = ""
    Private personalPhone As String = ""
    Private personalEmail As String = ""
    Private dependentType As String = ""
    'Private empIndex As Integer

    Private Sub frmNewDependent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'txtEmpNum.Text = frmMain.employeeList(frmMain.nodeIndex.Index).EmployeeNumber
        'txtFirstName.Text = firstName

        ddlDependentType.Items.Add("Spouse")
        ddlDependentType.Items.Add("Child")
        ddlDependentType.Items.Add("Other")


    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim emailExpression As New Regex("^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$")
        frmMain.closingNewDep = False

        lblErrorBirthDate.Visible = False
        lblErrorDepType.Visible = False
        lblErrorFirstName.Visible = False
        lblErrorLastName.Visible = False

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

        frmMain.getEmpFirstName(txtFirstName.Text)
        frmMain.getLast(txtLastName.Text)
        frmMain.getMid(txtMiddleName.Text)

        If mstBirthDate.MaskCompleted Then
            frmMain.getBirthDate(mstBirthDate.Text)
        Else
            lblErrorBirthDate.Visible = True
            MsgBox("Please enter a valid Birth Date!", MsgBoxStyle.Critical, "Error")
            mstBirthDate.Select()
            mstBirthDate.SelectAll()
            Return
        End If

        If txtEmail.Text = "" Then
            frmMain.getWorkEmail(txtEmail.Text)
        ElseIf emailExpression.IsMatch(txtEmail.Text) Then
            frmMain.getWorkEmail(txtEmail.Text)
        Else
            lblErrorEmail.Visible = True
            MsgBox("Please enter a valid email adress! (example@example.com)", MsgBoxStyle.Critical, "Error")
            txtEmail.Select()
            txtEmail.SelectAll()
            Return
        End If

        frmMain.getMobPhn(mstMobilePhone.Text)
        frmMain.getPerPhn(mstPhone.Text)

        If ddlDependentType.SelectedIndex = 0 Then
            frmMain.getDependent("S")
        ElseIf ddlDependentType.SelectedIndex = 1 Then
            frmMain.getDependent("C")
        ElseIf ddlDependentType.SelectedIndex = 2 Then
            frmMain.getDependent("O")
        End If


        Me.Close()
    End Sub

    Private Sub btnTestAdd_Click(sender As Object, e As EventArgs) Handles btnTestAdd.Click
        frmMain.closingNewDep = False
        txtFirstName.Text = "F" + frmMain.employeeCount.ToString("000")
        txtLastName.Text = "L" + frmMain.employeeCount.ToString("000")
        txtMiddleName.Text = "M" + frmMain.employeeCount.ToString("000")
        mstBirthDate.Text = "05/05/1995"
        mstPhone.Text = "555-123-4568"
        mstMobilePhone.Text = "123-456-4567"
        txtEmail.Text = "sample@sample.com"

        ddlDependentType.SelectedIndex = 0

        'txtPhoneNumber.Text = Random.Next(200, 999) & "-" & Random.Next(200, 999) & "-" & Random.Next(0, 999).ToString("0000")

        btnSave_Click(Nothing, Nothing)
    End Sub

    Private Sub llbRandom_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llbRandom.LinkClicked
        frmMain.closingNewEmp = False

        txtFirstName.Text = RandomStrings.RandomFirstName()
        txtLastName.Text = RandomStrings.RandomLastName()
        txtMiddleName.Text = RandomStrings.RandomMiddleName()
        mstBirthDate.Text = "05/19/1965"
        txtEmail.Text = RandomStrings.WorkEmail(txtFirstName.Text, txtLastName.Text)
        mstMobilePhone.Text = RandomStrings.RandomPersonalMobilePhone()
        ddlDependentType.SelectedIndex = 0

        btnSave_Click(Nothing, Nothing)

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

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        frmMain.closingNewDep = True
        Me.Close()
    End Sub


End Class