'--------------------------------------------------------------------
'* Name:       Cesar Mendoza
'* Class:      CIS-2510
'* Assignment: Project 01
'* File:       frmNewEmployee.vb
'* Purpose:    This form allows the user to add a new employee
'--------------------------------------------------------------------

Imports System.Text.RegularExpressions

Public Class frmNewEmployee

    Private Random As New Random


    Private Sub frmNewEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ddlEmployeeType.Items.Add("Full-Time")
        ddlEmployeeType.Items.Add("Part-Time")
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Dim emailExpression As New Regex("^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$")
        frmMain.closingNewEmp = False

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
        lblErrorEmail.Visible = False
        lblErrorPersEmail.Visible = False

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


        frmMain.getEmpNum(txtEmpNum.Text)
        frmMain.getEmpFirstName(txtFirstName.Text)
        frmMain.getLast(txtLastName.Text)
        frmMain.getMid(txtMiddleName.Text)

        If mstHiredDate.MaskCompleted Then
            frmMain.getHiredDate(mstHiredDate.Text)
        Else
            lblErrorHiredDate.Visible = True
            MsgBox("Please enter a valid Hired Date!", MsgBoxStyle.Critical, "Error")
            mstHiredDate.Select()
            mstHiredDate.SelectAll()
            Return
        End If

        If mstBirthDate.MaskCompleted Then
            frmMain.getBirthDate(mstBirthDate.Text)
        Else
            lblErrorBirthDate.Visible = True
            MsgBox("Please enter a valid Birth Date!", MsgBoxStyle.Critical, "Error")
            mstBirthDate.Select()
            mstBirthDate.SelectAll()
            Return
        End If



        If ddlEmployeeType.SelectedIndex = 0 Then
            frmMain.getEmpType("F")
        ElseIf ddlEmployeeType.SelectedIndex = 1 Then
            frmMain.getEmpType("P")
        End If
        If IsNumeric(txtSalary.Text) Then
            frmMain.getSalary(txtSalary.Text)
        Else
            lblErrorSalary.Visible = True
            MsgBox("Please enter a valid salary!", MsgBoxStyle.Critical, "Error")
            txtSalary.Select()
            txtSalary.SelectAll()
            Return
        End If

        frmMain.getOff(txtOffLoc.Text)

        If mstbWorkPhone.MaskCompleted Then
            frmMain.getWorkPhn(mstbWorkPhone.Text)
        Else
            lblErrorWorkPhone.Visible = True
            MsgBox("Please enter a valid Work Phone!", MsgBoxStyle.Critical, "Error")
            mstbWorkPhone.Select()
            mstbWorkPhone.SelectAll()
            Return
        End If



        If emailExpression.IsMatch(txtEmail.Text) Then
            frmMain.getWorkEmail(txtEmail.Text)
        Else
            lblErrorEmail.Visible = True
            MsgBox("Please enter a valid email! (example@example.com)", MsgBoxStyle.Critical, "Error")
            txtEmail.Select()
            txtEmail.SelectAll()
            Return
        End If

        frmMain.getMobPhn(mstMobilePhone.Text)

        If mstPersonalPhone.MaskCompleted Then
            frmMain.getPerPhn(mstPersonalPhone.Text)
        Else
            lblErrorPersPhone.Visible = True
            MsgBox("Please enter a valid Personal Phone!", MsgBoxStyle.Critical, "Error")
            mstPersonalPhone.Select()
            mstPersonalPhone.SelectAll()
            Return
        End If

        If emailExpression.IsMatch(txtPersonalEmail.Text) Then
            frmMain.getPerEmail(txtPersonalEmail.Text)
        Else
            lblErrorPersEmail.Visible = True
            MsgBox("Please enter a valid email! (example@example.com)", MsgBoxStyle.Critical, "Error")
            txtPersonalEmail.Select()
            txtPersonalEmail.SelectAll()
            Return
        End If



        Me.Close()

    End Sub

    Private Sub btnTestAdd_Click(sender As Object, e As EventArgs) Handles btnTestAdd.Click
        frmMain.closingNewEmp = False
        txtFirstName.Text = "F" + frmMain.employeeCount.ToString("000")
        txtLastName.Text = "L" + frmMain.employeeCount.ToString("000")
        txtEmpNum.Text = "E" + frmMain.employeeCount.ToString("000")
        txtMiddleName.Text = "M" + frmMain.employeeCount.ToString("000")
        mstBirthDate.Text = "05/19/1965"
        ddlEmployeeType.SelectedIndex = 0
        txtOffLoc.Text = "Some Place"
        mstbWorkPhone.Text = "123-412-4542"
        txtEmail.Text = "test@test.com"
        mstHiredDate.Text = "07/05/1999"
        mstMobilePhone.Text = "123-555-4514"
        mstPersonalPhone.Text = "516-455-7787"
        txtPersonalEmail.Text = "test@unu.com"
        txtSalary.Text = Random.Next(200, 999)
        'txtPhoneNumber.Text = Random.Next(200, 999) & "-" & Random.Next(200, 999) & "-" & Random.Next(0, 999).ToString("0000")

        btnSave_Click(Nothing, Nothing)
    End Sub

    Private Sub llbRandom_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llbRandom.LinkClicked
        frmMain.closingNewEmp = False

        txtFirstName.Text = RandomStrings.RandomFirstName()
        txtLastName.Text = RandomStrings.RandomLastName()
        txtEmpNum.Text = RandomStrings.RandomEmployeeNumber()
        txtMiddleName.Text = RandomStrings.RandomMiddleName()
        mstBirthDate.Text = "05/19/1965"
        ddlEmployeeType.SelectedIndex = 0
        txtOffLoc.Text = RandomStrings.RandomOfficeLocation()
        mstbWorkPhone.Text = RandomStrings.RandomWorkPhone()
        txtEmail.Text = RandomStrings.WorkEmail(txtFirstName.Text, txtLastName.Text)
        txtSalary.Text = RandomStrings.RandomFullTimeAnnualSalary()
        mstHiredDate.Text = "07/05/1999"
        mstMobilePhone.Text = RandomStrings.RandomPersonalMobilePhone()
        mstPersonalPhone.Text = RandomStrings.RandomPersonalMobilePhone()
        txtPersonalEmail.Text = RandomStrings.WorkEmail(txtFirstName.Text, txtLastName.Text)

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

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        frmMain.closingNewEmp = True
        Me.Close()
    End Sub


End Class