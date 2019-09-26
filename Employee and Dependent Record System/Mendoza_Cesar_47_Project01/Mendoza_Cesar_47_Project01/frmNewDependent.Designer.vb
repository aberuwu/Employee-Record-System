<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewDependent
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
        Me.btnTestAdd = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtMiddleName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.lblMobileHeading = New System.Windows.Forms.Label()
        Me.lblEmailHeading = New System.Windows.Forms.Label()
        Me.lblPhoneHeading = New System.Windows.Forms.Label()
        Me.lblBirthDateHeading = New System.Windows.Forms.Label()
        Me.lblMiddleNameHeading = New System.Windows.Forms.Label()
        Me.lblLastNameHeading = New System.Windows.Forms.Label()
        Me.lblFirstNameHeading = New System.Windows.Forms.Label()
        Me.lblDependentTypeHeading = New System.Windows.Forms.Label()
        Me.ddlDependentType = New System.Windows.Forms.ComboBox()
        Me.mstBirthDate = New System.Windows.Forms.MaskedTextBox()
        Me.mstPhone = New System.Windows.Forms.MaskedTextBox()
        Me.mstMobilePhone = New System.Windows.Forms.MaskedTextBox()
        Me.lblErrorFirstName = New System.Windows.Forms.Label()
        Me.lblErrorLastName = New System.Windows.Forms.Label()
        Me.lblErrorBirthDate = New System.Windows.Forms.Label()
        Me.lblErrorDepType = New System.Windows.Forms.Label()
        Me.lblErrorEmail = New System.Windows.Forms.Label()
        Me.llbRandom = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'btnTestAdd
        '
        Me.btnTestAdd.Location = New System.Drawing.Point(441, 320)
        Me.btnTestAdd.Name = "btnTestAdd"
        Me.btnTestAdd.Size = New System.Drawing.Size(94, 34)
        Me.btnTestAdd.TabIndex = 91
        Me.btnTestAdd.Text = "Add"
        Me.btnTestAdd.UseVisualStyleBackColor = True
        Me.btnTestAdd.Visible = False
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(424, 96)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(94, 34)
        Me.btnCancel.TabIndex = 90
        Me.btnCancel.Text = "C&ancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(424, 47)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(94, 34)
        Me.btnSave.TabIndex = 89
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(159, 296)
        Me.txtEmail.MaxLength = 85
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(190, 20)
        Me.txtEmail.TabIndex = 87
        '
        'txtMiddleName
        '
        Me.txtMiddleName.Location = New System.Drawing.Point(160, 137)
        Me.txtMiddleName.MaxLength = 20
        Me.txtMiddleName.Name = "txtMiddleName"
        Me.txtMiddleName.Size = New System.Drawing.Size(190, 20)
        Me.txtMiddleName.TabIndex = 83
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(160, 94)
        Me.txtLastName.MaxLength = 25
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(190, 20)
        Me.txtLastName.TabIndex = 82
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(160, 53)
        Me.txtFirstName.MaxLength = 35
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(190, 20)
        Me.txtFirstName.TabIndex = 81
        '
        'lblMobileHeading
        '
        Me.lblMobileHeading.AutoSize = True
        Me.lblMobileHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMobileHeading.Location = New System.Drawing.Point(13, 260)
        Me.lblMobileHeading.Name = "lblMobileHeading"
        Me.lblMobileHeading.Size = New System.Drawing.Size(61, 20)
        Me.lblMobileHeading.TabIndex = 75
        Me.lblMobileHeading.Text = "Mobile"
        '
        'lblEmailHeading
        '
        Me.lblEmailHeading.AutoSize = True
        Me.lblEmailHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmailHeading.Location = New System.Drawing.Point(12, 294)
        Me.lblEmailHeading.Name = "lblEmailHeading"
        Me.lblEmailHeading.Size = New System.Drawing.Size(53, 20)
        Me.lblEmailHeading.TabIndex = 74
        Me.lblEmailHeading.Text = "Email"
        '
        'lblPhoneHeading
        '
        Me.lblPhoneHeading.AutoSize = True
        Me.lblPhoneHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhoneHeading.Location = New System.Drawing.Point(12, 222)
        Me.lblPhoneHeading.Name = "lblPhoneHeading"
        Me.lblPhoneHeading.Size = New System.Drawing.Size(60, 20)
        Me.lblPhoneHeading.TabIndex = 73
        Me.lblPhoneHeading.Text = "Phone"
        '
        'lblBirthDateHeading
        '
        Me.lblBirthDateHeading.AutoSize = True
        Me.lblBirthDateHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBirthDateHeading.Location = New System.Drawing.Point(13, 179)
        Me.lblBirthDateHeading.Name = "lblBirthDateHeading"
        Me.lblBirthDateHeading.Size = New System.Drawing.Size(91, 20)
        Me.lblBirthDateHeading.TabIndex = 69
        Me.lblBirthDateHeading.Text = "Birth Date"
        '
        'lblMiddleNameHeading
        '
        Me.lblMiddleNameHeading.AutoSize = True
        Me.lblMiddleNameHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMiddleNameHeading.Location = New System.Drawing.Point(13, 139)
        Me.lblMiddleNameHeading.Name = "lblMiddleNameHeading"
        Me.lblMiddleNameHeading.Size = New System.Drawing.Size(112, 20)
        Me.lblMiddleNameHeading.TabIndex = 67
        Me.lblMiddleNameHeading.Text = "Middle Name"
        '
        'lblLastNameHeading
        '
        Me.lblLastNameHeading.AutoSize = True
        Me.lblLastNameHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastNameHeading.Location = New System.Drawing.Point(13, 96)
        Me.lblLastNameHeading.Name = "lblLastNameHeading"
        Me.lblLastNameHeading.Size = New System.Drawing.Size(95, 20)
        Me.lblLastNameHeading.TabIndex = 66
        Me.lblLastNameHeading.Text = "Last Name"
        '
        'lblFirstNameHeading
        '
        Me.lblFirstNameHeading.AutoSize = True
        Me.lblFirstNameHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstNameHeading.Location = New System.Drawing.Point(13, 53)
        Me.lblFirstNameHeading.Name = "lblFirstNameHeading"
        Me.lblFirstNameHeading.Size = New System.Drawing.Size(96, 20)
        Me.lblFirstNameHeading.TabIndex = 65
        Me.lblFirstNameHeading.Text = "First Name"
        '
        'lblDependentTypeHeading
        '
        Me.lblDependentTypeHeading.AutoSize = True
        Me.lblDependentTypeHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDependentTypeHeading.Location = New System.Drawing.Point(13, 331)
        Me.lblDependentTypeHeading.Name = "lblDependentTypeHeading"
        Me.lblDependentTypeHeading.Size = New System.Drawing.Size(141, 20)
        Me.lblDependentTypeHeading.TabIndex = 98
        Me.lblDependentTypeHeading.Text = "Dependent Type"
        '
        'ddlDependentType
        '
        Me.ddlDependentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddlDependentType.FormattingEnabled = True
        Me.ddlDependentType.Location = New System.Drawing.Point(160, 333)
        Me.ddlDependentType.Name = "ddlDependentType"
        Me.ddlDependentType.Size = New System.Drawing.Size(121, 21)
        Me.ddlDependentType.TabIndex = 88
        '
        'mstBirthDate
        '
        Me.mstBirthDate.Location = New System.Drawing.Point(160, 178)
        Me.mstBirthDate.Mask = "00/00/0000"
        Me.mstBirthDate.Name = "mstBirthDate"
        Me.mstBirthDate.Size = New System.Drawing.Size(100, 20)
        Me.mstBirthDate.TabIndex = 84
        Me.mstBirthDate.ValidatingType = GetType(Date)
        '
        'mstPhone
        '
        Me.mstPhone.Location = New System.Drawing.Point(160, 222)
        Me.mstPhone.Mask = "(999) 000-0000"
        Me.mstPhone.Name = "mstPhone"
        Me.mstPhone.Size = New System.Drawing.Size(100, 20)
        Me.mstPhone.TabIndex = 85
        '
        'mstMobilePhone
        '
        Me.mstMobilePhone.Location = New System.Drawing.Point(160, 260)
        Me.mstMobilePhone.Mask = "(999) 000-0000"
        Me.mstMobilePhone.Name = "mstMobilePhone"
        Me.mstMobilePhone.Size = New System.Drawing.Size(100, 20)
        Me.mstMobilePhone.TabIndex = 86
        '
        'lblErrorFirstName
        '
        Me.lblErrorFirstName.AutoSize = True
        Me.lblErrorFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblErrorFirstName.ForeColor = System.Drawing.Color.Red
        Me.lblErrorFirstName.Location = New System.Drawing.Point(357, 53)
        Me.lblErrorFirstName.Name = "lblErrorFirstName"
        Me.lblErrorFirstName.Size = New System.Drawing.Size(15, 18)
        Me.lblErrorFirstName.TabIndex = 104
        Me.lblErrorFirstName.Text = "*"
        Me.lblErrorFirstName.Visible = False
        '
        'lblErrorLastName
        '
        Me.lblErrorLastName.AutoSize = True
        Me.lblErrorLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblErrorLastName.ForeColor = System.Drawing.Color.Red
        Me.lblErrorLastName.Location = New System.Drawing.Point(357, 96)
        Me.lblErrorLastName.Name = "lblErrorLastName"
        Me.lblErrorLastName.Size = New System.Drawing.Size(15, 18)
        Me.lblErrorLastName.TabIndex = 105
        Me.lblErrorLastName.Text = "*"
        Me.lblErrorLastName.Visible = False
        '
        'lblErrorBirthDate
        '
        Me.lblErrorBirthDate.AutoSize = True
        Me.lblErrorBirthDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblErrorBirthDate.ForeColor = System.Drawing.Color.Red
        Me.lblErrorBirthDate.Location = New System.Drawing.Point(266, 181)
        Me.lblErrorBirthDate.Name = "lblErrorBirthDate"
        Me.lblErrorBirthDate.Size = New System.Drawing.Size(15, 18)
        Me.lblErrorBirthDate.TabIndex = 106
        Me.lblErrorBirthDate.Text = "*"
        Me.lblErrorBirthDate.Visible = False
        '
        'lblErrorDepType
        '
        Me.lblErrorDepType.AutoSize = True
        Me.lblErrorDepType.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblErrorDepType.ForeColor = System.Drawing.Color.Red
        Me.lblErrorDepType.Location = New System.Drawing.Point(287, 336)
        Me.lblErrorDepType.Name = "lblErrorDepType"
        Me.lblErrorDepType.Size = New System.Drawing.Size(15, 18)
        Me.lblErrorDepType.TabIndex = 107
        Me.lblErrorDepType.Text = "*"
        Me.lblErrorDepType.Visible = False
        '
        'lblErrorEmail
        '
        Me.lblErrorEmail.AutoSize = True
        Me.lblErrorEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblErrorEmail.ForeColor = System.Drawing.Color.Red
        Me.lblErrorEmail.Location = New System.Drawing.Point(355, 298)
        Me.lblErrorEmail.Name = "lblErrorEmail"
        Me.lblErrorEmail.Size = New System.Drawing.Size(15, 18)
        Me.lblErrorEmail.TabIndex = 108
        Me.lblErrorEmail.Text = "*"
        Me.lblErrorEmail.Visible = False
        '
        'llbRandom
        '
        Me.llbRandom.AutoSize = True
        Me.llbRandom.Location = New System.Drawing.Point(488, 365)
        Me.llbRandom.Name = "llbRandom"
        Me.llbRandom.Size = New System.Drawing.Size(47, 13)
        Me.llbRandom.TabIndex = 109
        Me.llbRandom.TabStop = True
        Me.llbRandom.Text = "Random"
        '
        'frmNewDependent
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(543, 387)
        Me.Controls.Add(Me.llbRandom)
        Me.Controls.Add(Me.lblErrorEmail)
        Me.Controls.Add(Me.lblErrorDepType)
        Me.Controls.Add(Me.lblErrorBirthDate)
        Me.Controls.Add(Me.lblErrorLastName)
        Me.Controls.Add(Me.lblErrorFirstName)
        Me.Controls.Add(Me.mstMobilePhone)
        Me.Controls.Add(Me.mstPhone)
        Me.Controls.Add(Me.mstBirthDate)
        Me.Controls.Add(Me.ddlDependentType)
        Me.Controls.Add(Me.lblDependentTypeHeading)
        Me.Controls.Add(Me.btnTestAdd)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtMiddleName)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.lblMobileHeading)
        Me.Controls.Add(Me.lblEmailHeading)
        Me.Controls.Add(Me.lblPhoneHeading)
        Me.Controls.Add(Me.lblBirthDateHeading)
        Me.Controls.Add(Me.lblMiddleNameHeading)
        Me.Controls.Add(Me.lblLastNameHeading)
        Me.Controls.Add(Me.lblFirstNameHeading)
        Me.Name = "frmNewDependent"
        Me.Text = "New Dependent (Cesar Mendoza #47)"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnTestAdd As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtMiddleName As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents lblMobileHeading As Label
    Friend WithEvents lblEmailHeading As Label
    Friend WithEvents lblPhoneHeading As Label
    Friend WithEvents lblBirthDateHeading As Label
    Friend WithEvents lblMiddleNameHeading As Label
    Friend WithEvents lblLastNameHeading As Label
    Friend WithEvents lblFirstNameHeading As Label
    Friend WithEvents lblDependentTypeHeading As Label
    Friend WithEvents ddlDependentType As ComboBox
    Friend WithEvents mstBirthDate As MaskedTextBox
    Friend WithEvents mstPhone As MaskedTextBox
    Friend WithEvents mstMobilePhone As MaskedTextBox
    Friend WithEvents lblErrorFirstName As Label
    Friend WithEvents lblErrorLastName As Label
    Friend WithEvents lblErrorBirthDate As Label
    Friend WithEvents lblErrorDepType As Label
    Friend WithEvents lblErrorEmail As Label
    Friend WithEvents llbRandom As LinkLabel
End Class
