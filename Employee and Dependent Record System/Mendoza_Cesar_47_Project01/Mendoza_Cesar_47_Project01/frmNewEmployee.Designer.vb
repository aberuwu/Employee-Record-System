﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewEmployee
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblEmpNumHeading = New System.Windows.Forms.Label()
        Me.lblPersonalEmailHeading = New System.Windows.Forms.Label()
        Me.lblPersonalPhoneHeading = New System.Windows.Forms.Label()
        Me.lblMobileHeading = New System.Windows.Forms.Label()
        Me.lblEmailHeading = New System.Windows.Forms.Label()
        Me.lblWorkPhoneHeading = New System.Windows.Forms.Label()
        Me.lblOfficeLocHeading = New System.Windows.Forms.Label()
        Me.lblSalaryHeading = New System.Windows.Forms.Label()
        Me.lblEmpTypeHeading = New System.Windows.Forms.Label()
        Me.lblBirthDateHeading = New System.Windows.Forms.Label()
        Me.lblHiredDateHeading = New System.Windows.Forms.Label()
        Me.lblMiddleNameHeading = New System.Windows.Forms.Label()
        Me.lblLastNameHeading = New System.Windows.Forms.Label()
        Me.lblFirstNameHeading = New System.Windows.Forms.Label()
        Me.txtEmpNum = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtMiddleName = New System.Windows.Forms.TextBox()
        Me.txtOffLoc = New System.Windows.Forms.TextBox()
        Me.txtSalary = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtPersonalEmail = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnTestAdd = New System.Windows.Forms.Button()
        Me.ddlEmployeeType = New System.Windows.Forms.ComboBox()
        Me.mstBirthDate = New System.Windows.Forms.MaskedTextBox()
        Me.mstHiredDate = New System.Windows.Forms.MaskedTextBox()
        Me.mstbWorkPhone = New System.Windows.Forms.MaskedTextBox()
        Me.mstMobilePhone = New System.Windows.Forms.MaskedTextBox()
        Me.mstPersonalPhone = New System.Windows.Forms.MaskedTextBox()
        Me.lblErrorPersEmail = New System.Windows.Forms.Label()
        Me.lblErrorPersPhone = New System.Windows.Forms.Label()
        Me.lblErrorMobile = New System.Windows.Forms.Label()
        Me.lblErrorEmail = New System.Windows.Forms.Label()
        Me.lblErrorWorkPhone = New System.Windows.Forms.Label()
        Me.lblErrorOffice = New System.Windows.Forms.Label()
        Me.lblErrorSalary = New System.Windows.Forms.Label()
        Me.lblErrorEmpType = New System.Windows.Forms.Label()
        Me.lblErrorHiredDate = New System.Windows.Forms.Label()
        Me.lblErrorBirthDate = New System.Windows.Forms.Label()
        Me.lblErrorMiddleName = New System.Windows.Forms.Label()
        Me.lblErrorLastName = New System.Windows.Forms.Label()
        Me.lblErrorFirstName = New System.Windows.Forms.Label()
        Me.lblErrorEmpNum = New System.Windows.Forms.Label()
        Me.llbRandom = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'lblEmpNumHeading
        '
        Me.lblEmpNumHeading.AutoSize = True
        Me.lblEmpNumHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpNumHeading.Location = New System.Drawing.Point(24, 36)
        Me.lblEmpNumHeading.Name = "lblEmpNumHeading"
        Me.lblEmpNumHeading.Size = New System.Drawing.Size(102, 20)
        Me.lblEmpNumHeading.TabIndex = 46
        Me.lblEmpNumHeading.Text = "Employee #"
        '
        'lblPersonalEmailHeading
        '
        Me.lblPersonalEmailHeading.AutoSize = True
        Me.lblPersonalEmailHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPersonalEmailHeading.Location = New System.Drawing.Point(435, 117)
        Me.lblPersonalEmailHeading.Name = "lblPersonalEmailHeading"
        Me.lblPersonalEmailHeading.Size = New System.Drawing.Size(128, 20)
        Me.lblPersonalEmailHeading.TabIndex = 44
        Me.lblPersonalEmailHeading.Text = "Personal Email"
        '
        'lblPersonalPhoneHeading
        '
        Me.lblPersonalPhoneHeading.AutoSize = True
        Me.lblPersonalPhoneHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPersonalPhoneHeading.Location = New System.Drawing.Point(435, 74)
        Me.lblPersonalPhoneHeading.Name = "lblPersonalPhoneHeading"
        Me.lblPersonalPhoneHeading.Size = New System.Drawing.Size(135, 20)
        Me.lblPersonalPhoneHeading.TabIndex = 43
        Me.lblPersonalPhoneHeading.Text = "Personal Phone"
        '
        'lblMobileHeading
        '
        Me.lblMobileHeading.AutoSize = True
        Me.lblMobileHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMobileHeading.Location = New System.Drawing.Point(435, 31)
        Me.lblMobileHeading.Name = "lblMobileHeading"
        Me.lblMobileHeading.Size = New System.Drawing.Size(61, 20)
        Me.lblMobileHeading.TabIndex = 42
        Me.lblMobileHeading.Text = "Mobile"
        '
        'lblEmailHeading
        '
        Me.lblEmailHeading.AutoSize = True
        Me.lblEmailHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmailHeading.Location = New System.Drawing.Point(24, 441)
        Me.lblEmailHeading.Name = "lblEmailHeading"
        Me.lblEmailHeading.Size = New System.Drawing.Size(99, 20)
        Me.lblEmailHeading.TabIndex = 41
        Me.lblEmailHeading.Text = "Work Email"
        '
        'lblWorkPhoneHeading
        '
        Me.lblWorkPhoneHeading.AutoSize = True
        Me.lblWorkPhoneHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWorkPhoneHeading.Location = New System.Drawing.Point(24, 402)
        Me.lblWorkPhoneHeading.Name = "lblWorkPhoneHeading"
        Me.lblWorkPhoneHeading.Size = New System.Drawing.Size(106, 20)
        Me.lblWorkPhoneHeading.TabIndex = 40
        Me.lblWorkPhoneHeading.Text = "Work Phone"
        '
        'lblOfficeLocHeading
        '
        Me.lblOfficeLocHeading.AutoSize = True
        Me.lblOfficeLocHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOfficeLocHeading.Location = New System.Drawing.Point(24, 362)
        Me.lblOfficeLocHeading.Name = "lblOfficeLocHeading"
        Me.lblOfficeLocHeading.Size = New System.Drawing.Size(96, 20)
        Me.lblOfficeLocHeading.TabIndex = 39
        Me.lblOfficeLocHeading.Text = "Office Loc."
        '
        'lblSalaryHeading
        '
        Me.lblSalaryHeading.AutoSize = True
        Me.lblSalaryHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalaryHeading.Location = New System.Drawing.Point(24, 321)
        Me.lblSalaryHeading.Name = "lblSalaryHeading"
        Me.lblSalaryHeading.Size = New System.Drawing.Size(59, 20)
        Me.lblSalaryHeading.TabIndex = 38
        Me.lblSalaryHeading.Text = "Salary"
        '
        'lblEmpTypeHeading
        '
        Me.lblEmpTypeHeading.AutoSize = True
        Me.lblEmpTypeHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpTypeHeading.Location = New System.Drawing.Point(24, 283)
        Me.lblEmpTypeHeading.Name = "lblEmpTypeHeading"
        Me.lblEmpTypeHeading.Size = New System.Drawing.Size(130, 20)
        Me.lblEmpTypeHeading.TabIndex = 37
        Me.lblEmpTypeHeading.Text = "Employee Type"
        '
        'lblBirthDateHeading
        '
        Me.lblBirthDateHeading.AutoSize = True
        Me.lblBirthDateHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBirthDateHeading.Location = New System.Drawing.Point(24, 200)
        Me.lblBirthDateHeading.Name = "lblBirthDateHeading"
        Me.lblBirthDateHeading.Size = New System.Drawing.Size(91, 20)
        Me.lblBirthDateHeading.TabIndex = 36
        Me.lblBirthDateHeading.Text = "Birth Date"
        '
        'lblHiredDateHeading
        '
        Me.lblHiredDateHeading.AutoSize = True
        Me.lblHiredDateHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHiredDateHeading.Location = New System.Drawing.Point(24, 245)
        Me.lblHiredDateHeading.Name = "lblHiredDateHeading"
        Me.lblHiredDateHeading.Size = New System.Drawing.Size(96, 20)
        Me.lblHiredDateHeading.TabIndex = 35
        Me.lblHiredDateHeading.Text = "Hired Date"
        '
        'lblMiddleNameHeading
        '
        Me.lblMiddleNameHeading.AutoSize = True
        Me.lblMiddleNameHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMiddleNameHeading.Location = New System.Drawing.Point(24, 160)
        Me.lblMiddleNameHeading.Name = "lblMiddleNameHeading"
        Me.lblMiddleNameHeading.Size = New System.Drawing.Size(112, 20)
        Me.lblMiddleNameHeading.TabIndex = 34
        Me.lblMiddleNameHeading.Text = "Middle Name"
        '
        'lblLastNameHeading
        '
        Me.lblLastNameHeading.AutoSize = True
        Me.lblLastNameHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastNameHeading.Location = New System.Drawing.Point(24, 117)
        Me.lblLastNameHeading.Name = "lblLastNameHeading"
        Me.lblLastNameHeading.Size = New System.Drawing.Size(95, 20)
        Me.lblLastNameHeading.TabIndex = 33
        Me.lblLastNameHeading.Text = "Last Name"
        '
        'lblFirstNameHeading
        '
        Me.lblFirstNameHeading.AutoSize = True
        Me.lblFirstNameHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstNameHeading.Location = New System.Drawing.Point(24, 74)
        Me.lblFirstNameHeading.Name = "lblFirstNameHeading"
        Me.lblFirstNameHeading.Size = New System.Drawing.Size(96, 20)
        Me.lblFirstNameHeading.TabIndex = 32
        Me.lblFirstNameHeading.Text = "First Name"
        '
        'txtEmpNum
        '
        Me.txtEmpNum.Location = New System.Drawing.Point(162, 34)
        Me.txtEmpNum.MaxLength = 10
        Me.txtEmpNum.Name = "txtEmpNum"
        Me.txtEmpNum.Size = New System.Drawing.Size(102, 20)
        Me.txtEmpNum.TabIndex = 47
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(162, 74)
        Me.txtFirstName.MaxLength = 35
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(190, 20)
        Me.txtFirstName.TabIndex = 48
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(162, 115)
        Me.txtLastName.MaxLength = 25
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(190, 20)
        Me.txtLastName.TabIndex = 49
        '
        'txtMiddleName
        '
        Me.txtMiddleName.Location = New System.Drawing.Point(162, 158)
        Me.txtMiddleName.MaxLength = 20
        Me.txtMiddleName.Name = "txtMiddleName"
        Me.txtMiddleName.Size = New System.Drawing.Size(190, 20)
        Me.txtMiddleName.TabIndex = 50
        '
        'txtOffLoc
        '
        Me.txtOffLoc.Location = New System.Drawing.Point(162, 362)
        Me.txtOffLoc.MaxLength = 20
        Me.txtOffLoc.Name = "txtOffLoc"
        Me.txtOffLoc.Size = New System.Drawing.Size(190, 20)
        Me.txtOffLoc.TabIndex = 55
        '
        'txtSalary
        '
        Me.txtSalary.Location = New System.Drawing.Point(162, 321)
        Me.txtSalary.MaxLength = 10
        Me.txtSalary.Name = "txtSalary"
        Me.txtSalary.Size = New System.Drawing.Size(102, 20)
        Me.txtSalary.TabIndex = 54
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(162, 443)
        Me.txtEmail.MaxLength = 85
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(190, 20)
        Me.txtEmail.TabIndex = 57
        '
        'txtPersonalEmail
        '
        Me.txtPersonalEmail.Location = New System.Drawing.Point(588, 116)
        Me.txtPersonalEmail.MaxLength = 85
        Me.txtPersonalEmail.Name = "txtPersonalEmail"
        Me.txtPersonalEmail.Size = New System.Drawing.Size(190, 20)
        Me.txtPersonalEmail.TabIndex = 60
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(500, 307)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(94, 34)
        Me.btnSave.TabIndex = 62
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(636, 307)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(94, 34)
        Me.btnCancel.TabIndex = 63
        Me.btnCancel.Text = "C&ancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnTestAdd
        '
        Me.btnTestAdd.Location = New System.Drawing.Point(566, 435)
        Me.btnTestAdd.Name = "btnTestAdd"
        Me.btnTestAdd.Size = New System.Drawing.Size(94, 34)
        Me.btnTestAdd.TabIndex = 64
        Me.btnTestAdd.Text = "Add"
        Me.btnTestAdd.UseVisualStyleBackColor = True
        Me.btnTestAdd.Visible = False
        '
        'ddlEmployeeType
        '
        Me.ddlEmployeeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddlEmployeeType.FormattingEnabled = True
        Me.ddlEmployeeType.Location = New System.Drawing.Point(162, 283)
        Me.ddlEmployeeType.Name = "ddlEmployeeType"
        Me.ddlEmployeeType.Size = New System.Drawing.Size(121, 21)
        Me.ddlEmployeeType.TabIndex = 53
        '
        'mstBirthDate
        '
        Me.mstBirthDate.Location = New System.Drawing.Point(162, 200)
        Me.mstBirthDate.Mask = "00/00/0000"
        Me.mstBirthDate.Name = "mstBirthDate"
        Me.mstBirthDate.Size = New System.Drawing.Size(79, 20)
        Me.mstBirthDate.TabIndex = 51
        Me.mstBirthDate.ValidatingType = GetType(Date)
        '
        'mstHiredDate
        '
        Me.mstHiredDate.Location = New System.Drawing.Point(162, 245)
        Me.mstHiredDate.Mask = "00/00/0000"
        Me.mstHiredDate.Name = "mstHiredDate"
        Me.mstHiredDate.Size = New System.Drawing.Size(79, 20)
        Me.mstHiredDate.TabIndex = 52
        Me.mstHiredDate.ValidatingType = GetType(Date)
        '
        'mstbWorkPhone
        '
        Me.mstbWorkPhone.Location = New System.Drawing.Point(162, 404)
        Me.mstbWorkPhone.Mask = "(999) 000-0000"
        Me.mstbWorkPhone.Name = "mstbWorkPhone"
        Me.mstbWorkPhone.Size = New System.Drawing.Size(144, 20)
        Me.mstbWorkPhone.TabIndex = 56
        '
        'mstMobilePhone
        '
        Me.mstMobilePhone.Location = New System.Drawing.Point(588, 34)
        Me.mstMobilePhone.Mask = "(999) 000-0000"
        Me.mstMobilePhone.Name = "mstMobilePhone"
        Me.mstMobilePhone.Size = New System.Drawing.Size(144, 20)
        Me.mstMobilePhone.TabIndex = 58
        '
        'mstPersonalPhone
        '
        Me.mstPersonalPhone.Location = New System.Drawing.Point(588, 75)
        Me.mstPersonalPhone.Mask = "(999) 000-0000"
        Me.mstPersonalPhone.Name = "mstPersonalPhone"
        Me.mstPersonalPhone.Size = New System.Drawing.Size(144, 20)
        Me.mstPersonalPhone.TabIndex = 59
        '
        'lblErrorPersEmail
        '
        Me.lblErrorPersEmail.AutoSize = True
        Me.lblErrorPersEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblErrorPersEmail.ForeColor = System.Drawing.Color.Red
        Me.lblErrorPersEmail.Location = New System.Drawing.Point(784, 117)
        Me.lblErrorPersEmail.Name = "lblErrorPersEmail"
        Me.lblErrorPersEmail.Size = New System.Drawing.Size(15, 18)
        Me.lblErrorPersEmail.TabIndex = 130
        Me.lblErrorPersEmail.Text = "*"
        Me.lblErrorPersEmail.Visible = False
        '
        'lblErrorPersPhone
        '
        Me.lblErrorPersPhone.AutoSize = True
        Me.lblErrorPersPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblErrorPersPhone.ForeColor = System.Drawing.Color.Red
        Me.lblErrorPersPhone.Location = New System.Drawing.Point(738, 76)
        Me.lblErrorPersPhone.Name = "lblErrorPersPhone"
        Me.lblErrorPersPhone.Size = New System.Drawing.Size(15, 18)
        Me.lblErrorPersPhone.TabIndex = 129
        Me.lblErrorPersPhone.Text = "*"
        Me.lblErrorPersPhone.Visible = False
        '
        'lblErrorMobile
        '
        Me.lblErrorMobile.AutoSize = True
        Me.lblErrorMobile.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblErrorMobile.ForeColor = System.Drawing.Color.Red
        Me.lblErrorMobile.Location = New System.Drawing.Point(738, 37)
        Me.lblErrorMobile.Name = "lblErrorMobile"
        Me.lblErrorMobile.Size = New System.Drawing.Size(15, 18)
        Me.lblErrorMobile.TabIndex = 128
        Me.lblErrorMobile.Text = "*"
        Me.lblErrorMobile.Visible = False
        '
        'lblErrorEmail
        '
        Me.lblErrorEmail.AutoSize = True
        Me.lblErrorEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblErrorEmail.ForeColor = System.Drawing.Color.Red
        Me.lblErrorEmail.Location = New System.Drawing.Point(358, 443)
        Me.lblErrorEmail.Name = "lblErrorEmail"
        Me.lblErrorEmail.Size = New System.Drawing.Size(15, 18)
        Me.lblErrorEmail.TabIndex = 127
        Me.lblErrorEmail.Text = "*"
        Me.lblErrorEmail.Visible = False
        '
        'lblErrorWorkPhone
        '
        Me.lblErrorWorkPhone.AutoSize = True
        Me.lblErrorWorkPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblErrorWorkPhone.ForeColor = System.Drawing.Color.Red
        Me.lblErrorWorkPhone.Location = New System.Drawing.Point(312, 406)
        Me.lblErrorWorkPhone.Name = "lblErrorWorkPhone"
        Me.lblErrorWorkPhone.Size = New System.Drawing.Size(15, 18)
        Me.lblErrorWorkPhone.TabIndex = 126
        Me.lblErrorWorkPhone.Text = "*"
        Me.lblErrorWorkPhone.Visible = False
        '
        'lblErrorOffice
        '
        Me.lblErrorOffice.AutoSize = True
        Me.lblErrorOffice.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblErrorOffice.ForeColor = System.Drawing.Color.Red
        Me.lblErrorOffice.Location = New System.Drawing.Point(358, 364)
        Me.lblErrorOffice.Name = "lblErrorOffice"
        Me.lblErrorOffice.Size = New System.Drawing.Size(15, 18)
        Me.lblErrorOffice.TabIndex = 125
        Me.lblErrorOffice.Text = "*"
        Me.lblErrorOffice.Visible = False
        '
        'lblErrorSalary
        '
        Me.lblErrorSalary.AutoSize = True
        Me.lblErrorSalary.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblErrorSalary.ForeColor = System.Drawing.Color.Red
        Me.lblErrorSalary.Location = New System.Drawing.Point(270, 322)
        Me.lblErrorSalary.Name = "lblErrorSalary"
        Me.lblErrorSalary.Size = New System.Drawing.Size(15, 18)
        Me.lblErrorSalary.TabIndex = 124
        Me.lblErrorSalary.Text = "*"
        Me.lblErrorSalary.Visible = False
        '
        'lblErrorEmpType
        '
        Me.lblErrorEmpType.AutoSize = True
        Me.lblErrorEmpType.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblErrorEmpType.ForeColor = System.Drawing.Color.Red
        Me.lblErrorEmpType.Location = New System.Drawing.Point(289, 283)
        Me.lblErrorEmpType.Name = "lblErrorEmpType"
        Me.lblErrorEmpType.Size = New System.Drawing.Size(15, 18)
        Me.lblErrorEmpType.TabIndex = 123
        Me.lblErrorEmpType.Text = "*"
        Me.lblErrorEmpType.Visible = False
        '
        'lblErrorHiredDate
        '
        Me.lblErrorHiredDate.AutoSize = True
        Me.lblErrorHiredDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblErrorHiredDate.ForeColor = System.Drawing.Color.Red
        Me.lblErrorHiredDate.Location = New System.Drawing.Point(247, 246)
        Me.lblErrorHiredDate.Name = "lblErrorHiredDate"
        Me.lblErrorHiredDate.Size = New System.Drawing.Size(15, 18)
        Me.lblErrorHiredDate.TabIndex = 122
        Me.lblErrorHiredDate.Text = "*"
        Me.lblErrorHiredDate.Visible = False
        '
        'lblErrorBirthDate
        '
        Me.lblErrorBirthDate.AutoSize = True
        Me.lblErrorBirthDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblErrorBirthDate.ForeColor = System.Drawing.Color.Red
        Me.lblErrorBirthDate.Location = New System.Drawing.Point(247, 201)
        Me.lblErrorBirthDate.Name = "lblErrorBirthDate"
        Me.lblErrorBirthDate.Size = New System.Drawing.Size(15, 18)
        Me.lblErrorBirthDate.TabIndex = 121
        Me.lblErrorBirthDate.Text = "*"
        Me.lblErrorBirthDate.Visible = False
        '
        'lblErrorMiddleName
        '
        Me.lblErrorMiddleName.AutoSize = True
        Me.lblErrorMiddleName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblErrorMiddleName.ForeColor = System.Drawing.Color.Red
        Me.lblErrorMiddleName.Location = New System.Drawing.Point(358, 161)
        Me.lblErrorMiddleName.Name = "lblErrorMiddleName"
        Me.lblErrorMiddleName.Size = New System.Drawing.Size(15, 18)
        Me.lblErrorMiddleName.TabIndex = 120
        Me.lblErrorMiddleName.Text = "*"
        Me.lblErrorMiddleName.Visible = False
        '
        'lblErrorLastName
        '
        Me.lblErrorLastName.AutoSize = True
        Me.lblErrorLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblErrorLastName.ForeColor = System.Drawing.Color.Red
        Me.lblErrorLastName.Location = New System.Drawing.Point(358, 115)
        Me.lblErrorLastName.Name = "lblErrorLastName"
        Me.lblErrorLastName.Size = New System.Drawing.Size(15, 18)
        Me.lblErrorLastName.TabIndex = 119
        Me.lblErrorLastName.Text = "*"
        Me.lblErrorLastName.Visible = False
        '
        'lblErrorFirstName
        '
        Me.lblErrorFirstName.AutoSize = True
        Me.lblErrorFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblErrorFirstName.ForeColor = System.Drawing.Color.Red
        Me.lblErrorFirstName.Location = New System.Drawing.Point(358, 75)
        Me.lblErrorFirstName.Name = "lblErrorFirstName"
        Me.lblErrorFirstName.Size = New System.Drawing.Size(15, 18)
        Me.lblErrorFirstName.TabIndex = 118
        Me.lblErrorFirstName.Text = "*"
        Me.lblErrorFirstName.Visible = False
        '
        'lblErrorEmpNum
        '
        Me.lblErrorEmpNum.AutoSize = True
        Me.lblErrorEmpNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblErrorEmpNum.ForeColor = System.Drawing.Color.Red
        Me.lblErrorEmpNum.Location = New System.Drawing.Point(270, 34)
        Me.lblErrorEmpNum.Name = "lblErrorEmpNum"
        Me.lblErrorEmpNum.Size = New System.Drawing.Size(15, 18)
        Me.lblErrorEmpNum.TabIndex = 117
        Me.lblErrorEmpNum.Text = "*"
        Me.lblErrorEmpNum.Visible = False
        '
        'llbRandom
        '
        Me.llbRandom.AutoSize = True
        Me.llbRandom.Location = New System.Drawing.Point(741, 469)
        Me.llbRandom.Name = "llbRandom"
        Me.llbRandom.Size = New System.Drawing.Size(47, 13)
        Me.llbRandom.TabIndex = 131
        Me.llbRandom.TabStop = True
        Me.llbRandom.Text = "Random"
        '
        'frmNewEmployee
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 491)
        Me.Controls.Add(Me.llbRandom)
        Me.Controls.Add(Me.lblErrorPersEmail)
        Me.Controls.Add(Me.lblErrorPersPhone)
        Me.Controls.Add(Me.lblErrorMobile)
        Me.Controls.Add(Me.lblErrorEmail)
        Me.Controls.Add(Me.lblErrorWorkPhone)
        Me.Controls.Add(Me.lblErrorOffice)
        Me.Controls.Add(Me.lblErrorSalary)
        Me.Controls.Add(Me.lblErrorEmpType)
        Me.Controls.Add(Me.lblErrorHiredDate)
        Me.Controls.Add(Me.lblErrorBirthDate)
        Me.Controls.Add(Me.lblErrorMiddleName)
        Me.Controls.Add(Me.lblErrorLastName)
        Me.Controls.Add(Me.lblErrorFirstName)
        Me.Controls.Add(Me.lblErrorEmpNum)
        Me.Controls.Add(Me.mstPersonalPhone)
        Me.Controls.Add(Me.mstMobilePhone)
        Me.Controls.Add(Me.mstbWorkPhone)
        Me.Controls.Add(Me.mstHiredDate)
        Me.Controls.Add(Me.mstBirthDate)
        Me.Controls.Add(Me.ddlEmployeeType)
        Me.Controls.Add(Me.btnTestAdd)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtPersonalEmail)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtSalary)
        Me.Controls.Add(Me.txtOffLoc)
        Me.Controls.Add(Me.txtMiddleName)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.txtEmpNum)
        Me.Controls.Add(Me.lblEmpNumHeading)
        Me.Controls.Add(Me.lblPersonalEmailHeading)
        Me.Controls.Add(Me.lblPersonalPhoneHeading)
        Me.Controls.Add(Me.lblMobileHeading)
        Me.Controls.Add(Me.lblEmailHeading)
        Me.Controls.Add(Me.lblWorkPhoneHeading)
        Me.Controls.Add(Me.lblOfficeLocHeading)
        Me.Controls.Add(Me.lblSalaryHeading)
        Me.Controls.Add(Me.lblEmpTypeHeading)
        Me.Controls.Add(Me.lblBirthDateHeading)
        Me.Controls.Add(Me.lblHiredDateHeading)
        Me.Controls.Add(Me.lblMiddleNameHeading)
        Me.Controls.Add(Me.lblLastNameHeading)
        Me.Controls.Add(Me.lblFirstNameHeading)
        Me.Name = "frmNewEmployee"
        Me.Text = "frmNewEmployee"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblEmpNumHeading As Label
    Friend WithEvents lblPersonalEmailHeading As Label
    Friend WithEvents lblPersonalPhoneHeading As Label
    Friend WithEvents lblMobileHeading As Label
    Friend WithEvents lblEmailHeading As Label
    Friend WithEvents lblWorkPhoneHeading As Label
    Friend WithEvents lblOfficeLocHeading As Label
    Friend WithEvents lblSalaryHeading As Label
    Friend WithEvents lblEmpTypeHeading As Label
    Friend WithEvents lblBirthDateHeading As Label
    Friend WithEvents lblHiredDateHeading As Label
    Friend WithEvents lblMiddleNameHeading As Label
    Friend WithEvents lblLastNameHeading As Label
    Friend WithEvents lblFirstNameHeading As Label
    Friend WithEvents txtEmpNum As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtMiddleName As TextBox
    Friend WithEvents txtOffLoc As TextBox
    Friend WithEvents txtSalary As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPersonalEmail As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnTestAdd As Button
    Friend WithEvents ddlEmployeeType As ComboBox
    Friend WithEvents mstBirthDate As MaskedTextBox
    Friend WithEvents mstHiredDate As MaskedTextBox
    Friend WithEvents mstbWorkPhone As MaskedTextBox
    Friend WithEvents mstMobilePhone As MaskedTextBox
    Friend WithEvents mstPersonalPhone As MaskedTextBox
    Friend WithEvents lblErrorPersEmail As Label
    Friend WithEvents lblErrorPersPhone As Label
    Friend WithEvents lblErrorMobile As Label
    Friend WithEvents lblErrorEmail As Label
    Friend WithEvents lblErrorWorkPhone As Label
    Friend WithEvents lblErrorOffice As Label
    Friend WithEvents lblErrorSalary As Label
    Friend WithEvents lblErrorEmpType As Label
    Friend WithEvents lblErrorHiredDate As Label
    Friend WithEvents lblErrorBirthDate As Label
    Friend WithEvents lblErrorMiddleName As Label
    Friend WithEvents lblErrorLastName As Label
    Friend WithEvents lblErrorFirstName As Label
    Friend WithEvents lblErrorEmpNum As Label
    Friend WithEvents llbRandom As LinkLabel
End Class
