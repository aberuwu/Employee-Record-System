<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.trvEmployeesDepend = New System.Windows.Forms.TreeView()
        Me.imgTreeIcons = New System.Windows.Forms.ImageList(Me.components)
        Me.tosMain = New System.Windows.Forms.ToolStrip()
        Me.tsbtnNew = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnOpen = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnSave = New System.Windows.Forms.ToolStripButton()
        Me.tosbtnSaveAs = New System.Windows.Forms.ToolStripButton()
        Me.lblFirstNameHeading = New System.Windows.Forms.Label()
        Me.lblLastNameHeading = New System.Windows.Forms.Label()
        Me.lblMiddleNameHeading = New System.Windows.Forms.Label()
        Me.lblHiredDateHeading = New System.Windows.Forms.Label()
        Me.lblBirthDateHeading = New System.Windows.Forms.Label()
        Me.lblEmpTypeHeading = New System.Windows.Forms.Label()
        Me.lblSalaryHeading = New System.Windows.Forms.Label()
        Me.lblOfficeLocHeading = New System.Windows.Forms.Label()
        Me.lblWorkPhoneHeading = New System.Windows.Forms.Label()
        Me.lblEmailHeading = New System.Windows.Forms.Label()
        Me.lblMobileHeading = New System.Windows.Forms.Label()
        Me.lblPersonalPhoneHeading = New System.Windows.Forms.Label()
        Me.lblPersonalEmailHeading = New System.Windows.Forms.Label()
        Me.lblEmpNumHeading = New System.Windows.Forms.Label()
        Me.lblEmpNum = New System.Windows.Forms.Label()
        Me.lblWorkEmail = New System.Windows.Forms.Label()
        Me.lblWorkPhone = New System.Windows.Forms.Label()
        Me.lblOfficeLoc = New System.Windows.Forms.Label()
        Me.lblSalary = New System.Windows.Forms.Label()
        Me.lblEmpType = New System.Windows.Forms.Label()
        Me.lblBirthDate = New System.Windows.Forms.Label()
        Me.lblHiredDate = New System.Windows.Forms.Label()
        Me.lblMiddleName = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblMobileNum = New System.Windows.Forms.Label()
        Me.lblPersonalEm = New System.Windows.Forms.Label()
        Me.lblPersonalNum = New System.Windows.Forms.Label()
        Me.btnAddDependent = New System.Windows.Forms.Button()
        Me.btnTestLists = New System.Windows.Forms.Button()
        Me.btnTraverse = New System.Windows.Forms.Button()
        Me.btnCount = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnAddEmployee = New System.Windows.Forms.Button()
        Me.tosMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'trvEmployeesDepend
        '
        Me.trvEmployeesDepend.AllowDrop = True
        Me.trvEmployeesDepend.ImageIndex = 0
        Me.trvEmployeesDepend.ImageList = Me.imgTreeIcons
        Me.trvEmployeesDepend.Location = New System.Drawing.Point(16, 39)
        Me.trvEmployeesDepend.Name = "trvEmployeesDepend"
        Me.trvEmployeesDepend.SelectedImageIndex = 0
        Me.trvEmployeesDepend.ShowNodeToolTips = True
        Me.trvEmployeesDepend.Size = New System.Drawing.Size(361, 507)
        Me.trvEmployeesDepend.TabIndex = 0
        '
        'imgTreeIcons
        '
        Me.imgTreeIcons.ImageStream = CType(resources.GetObject("imgTreeIcons.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgTreeIcons.TransparentColor = System.Drawing.Color.Transparent
        Me.imgTreeIcons.Images.SetKeyName(0, "ceo_man_To2_icon.ico")
        Me.imgTreeIcons.Images.SetKeyName(1, "employee_7G9_icon.ico")
        Me.imgTreeIcons.Images.SetKeyName(2, "family__1__PGf_icon.ico")
        '
        'tosMain
        '
        Me.tosMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbtnNew, Me.tsbtnOpen, Me.tsbtnSave, Me.tosbtnSaveAs})
        Me.tosMain.Location = New System.Drawing.Point(0, 0)
        Me.tosMain.Name = "tosMain"
        Me.tosMain.Size = New System.Drawing.Size(903, 25)
        Me.tosMain.TabIndex = 1
        Me.tosMain.Text = "ToolStrip1"
        '
        'tsbtnNew
        '
        Me.tsbtnNew.Image = Global.Mendoza_Cesar_47_Project01.My.Resources.Resources.NewTreeQuery_16x
        Me.tsbtnNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnNew.Name = "tsbtnNew"
        Me.tsbtnNew.Size = New System.Drawing.Size(51, 22)
        Me.tsbtnNew.Text = "New"
        '
        'tsbtnOpen
        '
        Me.tsbtnOpen.Image = Global.Mendoza_Cesar_47_Project01.My.Resources.Resources.OpenFile_16x
        Me.tsbtnOpen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnOpen.Name = "tsbtnOpen"
        Me.tsbtnOpen.Size = New System.Drawing.Size(56, 22)
        Me.tsbtnOpen.Text = "Open"
        '
        'tsbtnSave
        '
        Me.tsbtnSave.Enabled = False
        Me.tsbtnSave.Image = Global.Mendoza_Cesar_47_Project01.My.Resources.Resources.Save_16x
        Me.tsbtnSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnSave.Name = "tsbtnSave"
        Me.tsbtnSave.Size = New System.Drawing.Size(51, 22)
        Me.tsbtnSave.Text = "Save"
        '
        'tosbtnSaveAs
        '
        Me.tosbtnSaveAs.Image = Global.Mendoza_Cesar_47_Project01.My.Resources.Resources.SaveAs_16x
        Me.tosbtnSaveAs.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tosbtnSaveAs.Name = "tosbtnSaveAs"
        Me.tosbtnSaveAs.Size = New System.Drawing.Size(67, 22)
        Me.tosbtnSaveAs.Text = "Save As"
        '
        'lblFirstNameHeading
        '
        Me.lblFirstNameHeading.AutoSize = True
        Me.lblFirstNameHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstNameHeading.Location = New System.Drawing.Point(420, 83)
        Me.lblFirstNameHeading.Name = "lblFirstNameHeading"
        Me.lblFirstNameHeading.Size = New System.Drawing.Size(77, 15)
        Me.lblFirstNameHeading.TabIndex = 2
        Me.lblFirstNameHeading.Text = "First Name"
        '
        'lblLastNameHeading
        '
        Me.lblLastNameHeading.AutoSize = True
        Me.lblLastNameHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastNameHeading.Location = New System.Drawing.Point(420, 115)
        Me.lblLastNameHeading.Name = "lblLastNameHeading"
        Me.lblLastNameHeading.Size = New System.Drawing.Size(76, 15)
        Me.lblLastNameHeading.TabIndex = 3
        Me.lblLastNameHeading.Text = "Last Name"
        '
        'lblMiddleNameHeading
        '
        Me.lblMiddleNameHeading.AutoSize = True
        Me.lblMiddleNameHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMiddleNameHeading.Location = New System.Drawing.Point(420, 147)
        Me.lblMiddleNameHeading.Name = "lblMiddleNameHeading"
        Me.lblMiddleNameHeading.Size = New System.Drawing.Size(93, 15)
        Me.lblMiddleNameHeading.TabIndex = 4
        Me.lblMiddleNameHeading.Text = "Middle Name"
        '
        'lblHiredDateHeading
        '
        Me.lblHiredDateHeading.AutoSize = True
        Me.lblHiredDateHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHiredDateHeading.Location = New System.Drawing.Point(421, 211)
        Me.lblHiredDateHeading.Name = "lblHiredDateHeading"
        Me.lblHiredDateHeading.Size = New System.Drawing.Size(76, 15)
        Me.lblHiredDateHeading.TabIndex = 5
        Me.lblHiredDateHeading.Text = "Hired Date"
        '
        'lblBirthDateHeading
        '
        Me.lblBirthDateHeading.AutoSize = True
        Me.lblBirthDateHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBirthDateHeading.Location = New System.Drawing.Point(420, 179)
        Me.lblBirthDateHeading.Name = "lblBirthDateHeading"
        Me.lblBirthDateHeading.Size = New System.Drawing.Size(71, 15)
        Me.lblBirthDateHeading.TabIndex = 6
        Me.lblBirthDateHeading.Text = "Birth Date"
        '
        'lblEmpTypeHeading
        '
        Me.lblEmpTypeHeading.AutoSize = True
        Me.lblEmpTypeHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpTypeHeading.Location = New System.Drawing.Point(420, 243)
        Me.lblEmpTypeHeading.Name = "lblEmpTypeHeading"
        Me.lblEmpTypeHeading.Size = New System.Drawing.Size(104, 15)
        Me.lblEmpTypeHeading.TabIndex = 7
        Me.lblEmpTypeHeading.Text = "Employee Type"
        '
        'lblSalaryHeading
        '
        Me.lblSalaryHeading.AutoSize = True
        Me.lblSalaryHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalaryHeading.Location = New System.Drawing.Point(420, 275)
        Me.lblSalaryHeading.Name = "lblSalaryHeading"
        Me.lblSalaryHeading.Size = New System.Drawing.Size(47, 15)
        Me.lblSalaryHeading.TabIndex = 8
        Me.lblSalaryHeading.Text = "Salary"
        '
        'lblOfficeLocHeading
        '
        Me.lblOfficeLocHeading.AutoSize = True
        Me.lblOfficeLocHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOfficeLocHeading.Location = New System.Drawing.Point(421, 307)
        Me.lblOfficeLocHeading.Name = "lblOfficeLocHeading"
        Me.lblOfficeLocHeading.Size = New System.Drawing.Size(131, 15)
        Me.lblOfficeLocHeading.TabIndex = 9
        Me.lblOfficeLocHeading.Text = "Office/ Cubicle Loc."
        '
        'lblWorkPhoneHeading
        '
        Me.lblWorkPhoneHeading.AutoSize = True
        Me.lblWorkPhoneHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWorkPhoneHeading.Location = New System.Drawing.Point(420, 339)
        Me.lblWorkPhoneHeading.Name = "lblWorkPhoneHeading"
        Me.lblWorkPhoneHeading.Size = New System.Drawing.Size(84, 15)
        Me.lblWorkPhoneHeading.TabIndex = 10
        Me.lblWorkPhoneHeading.Text = "Work Phone"
        '
        'lblEmailHeading
        '
        Me.lblEmailHeading.AutoSize = True
        Me.lblEmailHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmailHeading.Location = New System.Drawing.Point(420, 371)
        Me.lblEmailHeading.Name = "lblEmailHeading"
        Me.lblEmailHeading.Size = New System.Drawing.Size(80, 15)
        Me.lblEmailHeading.TabIndex = 11
        Me.lblEmailHeading.Text = "Work Email"
        '
        'lblMobileHeading
        '
        Me.lblMobileHeading.AutoSize = True
        Me.lblMobileHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMobileHeading.Location = New System.Drawing.Point(420, 403)
        Me.lblMobileHeading.Name = "lblMobileHeading"
        Me.lblMobileHeading.Size = New System.Drawing.Size(51, 15)
        Me.lblMobileHeading.TabIndex = 12
        Me.lblMobileHeading.Text = "Mobile"
        '
        'lblPersonalPhoneHeading
        '
        Me.lblPersonalPhoneHeading.AutoSize = True
        Me.lblPersonalPhoneHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPersonalPhoneHeading.Location = New System.Drawing.Point(420, 435)
        Me.lblPersonalPhoneHeading.Name = "lblPersonalPhoneHeading"
        Me.lblPersonalPhoneHeading.Size = New System.Drawing.Size(109, 15)
        Me.lblPersonalPhoneHeading.TabIndex = 13
        Me.lblPersonalPhoneHeading.Text = "Personal Phone"
        '
        'lblPersonalEmailHeading
        '
        Me.lblPersonalEmailHeading.AutoSize = True
        Me.lblPersonalEmailHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPersonalEmailHeading.Location = New System.Drawing.Point(420, 467)
        Me.lblPersonalEmailHeading.Name = "lblPersonalEmailHeading"
        Me.lblPersonalEmailHeading.Size = New System.Drawing.Size(105, 15)
        Me.lblPersonalEmailHeading.TabIndex = 14
        Me.lblPersonalEmailHeading.Text = "Personal Email"
        '
        'lblEmpNumHeading
        '
        Me.lblEmpNumHeading.AutoSize = True
        Me.lblEmpNumHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpNumHeading.Location = New System.Drawing.Point(420, 51)
        Me.lblEmpNumHeading.Name = "lblEmpNumHeading"
        Me.lblEmpNumHeading.Size = New System.Drawing.Size(82, 15)
        Me.lblEmpNumHeading.TabIndex = 16
        Me.lblEmpNumHeading.Text = "Employee #"
        '
        'lblEmpNum
        '
        Me.lblEmpNum.AutoSize = True
        Me.lblEmpNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpNum.Location = New System.Drawing.Point(575, 51)
        Me.lblEmpNum.Name = "lblEmpNum"
        Me.lblEmpNum.Size = New System.Drawing.Size(35, 15)
        Me.lblEmpNum.TabIndex = 27
        Me.lblEmpNum.Text = "####"
        Me.lblEmpNum.Visible = False
        '
        'lblWorkEmail
        '
        Me.lblWorkEmail.AutoSize = True
        Me.lblWorkEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWorkEmail.Location = New System.Drawing.Point(575, 371)
        Me.lblWorkEmail.Name = "lblWorkEmail"
        Me.lblWorkEmail.Size = New System.Drawing.Size(35, 15)
        Me.lblWorkEmail.TabIndex = 26
        Me.lblWorkEmail.Text = "####"
        Me.lblWorkEmail.Visible = False
        '
        'lblWorkPhone
        '
        Me.lblWorkPhone.AutoSize = True
        Me.lblWorkPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWorkPhone.Location = New System.Drawing.Point(575, 339)
        Me.lblWorkPhone.Name = "lblWorkPhone"
        Me.lblWorkPhone.Size = New System.Drawing.Size(35, 15)
        Me.lblWorkPhone.TabIndex = 25
        Me.lblWorkPhone.Text = "####"
        Me.lblWorkPhone.Visible = False
        '
        'lblOfficeLoc
        '
        Me.lblOfficeLoc.AutoSize = True
        Me.lblOfficeLoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOfficeLoc.Location = New System.Drawing.Point(576, 307)
        Me.lblOfficeLoc.Name = "lblOfficeLoc"
        Me.lblOfficeLoc.Size = New System.Drawing.Size(35, 15)
        Me.lblOfficeLoc.TabIndex = 24
        Me.lblOfficeLoc.Text = "####"
        Me.lblOfficeLoc.Visible = False
        '
        'lblSalary
        '
        Me.lblSalary.AutoSize = True
        Me.lblSalary.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalary.Location = New System.Drawing.Point(575, 275)
        Me.lblSalary.Name = "lblSalary"
        Me.lblSalary.Size = New System.Drawing.Size(35, 15)
        Me.lblSalary.TabIndex = 23
        Me.lblSalary.Text = "####"
        Me.lblSalary.Visible = False
        '
        'lblEmpType
        '
        Me.lblEmpType.AutoSize = True
        Me.lblEmpType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpType.Location = New System.Drawing.Point(575, 243)
        Me.lblEmpType.Name = "lblEmpType"
        Me.lblEmpType.Size = New System.Drawing.Size(35, 15)
        Me.lblEmpType.TabIndex = 22
        Me.lblEmpType.Text = "####"
        Me.lblEmpType.Visible = False
        '
        'lblBirthDate
        '
        Me.lblBirthDate.AutoSize = True
        Me.lblBirthDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBirthDate.Location = New System.Drawing.Point(575, 179)
        Me.lblBirthDate.Name = "lblBirthDate"
        Me.lblBirthDate.Size = New System.Drawing.Size(35, 15)
        Me.lblBirthDate.TabIndex = 21
        Me.lblBirthDate.Text = "####"
        Me.lblBirthDate.Visible = False
        '
        'lblHiredDate
        '
        Me.lblHiredDate.AutoSize = True
        Me.lblHiredDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHiredDate.Location = New System.Drawing.Point(576, 211)
        Me.lblHiredDate.Name = "lblHiredDate"
        Me.lblHiredDate.Size = New System.Drawing.Size(35, 15)
        Me.lblHiredDate.TabIndex = 20
        Me.lblHiredDate.Text = "####"
        Me.lblHiredDate.Visible = False
        '
        'lblMiddleName
        '
        Me.lblMiddleName.AutoSize = True
        Me.lblMiddleName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMiddleName.Location = New System.Drawing.Point(575, 147)
        Me.lblMiddleName.Name = "lblMiddleName"
        Me.lblMiddleName.Size = New System.Drawing.Size(35, 15)
        Me.lblMiddleName.TabIndex = 19
        Me.lblMiddleName.Text = "####"
        Me.lblMiddleName.Visible = False
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastName.Location = New System.Drawing.Point(575, 115)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(35, 15)
        Me.lblLastName.TabIndex = 18
        Me.lblLastName.Text = "####"
        Me.lblLastName.Visible = False
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstName.Location = New System.Drawing.Point(575, 83)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(35, 15)
        Me.lblFirstName.TabIndex = 17
        Me.lblFirstName.Text = "####"
        Me.lblFirstName.Visible = False
        '
        'lblMobileNum
        '
        Me.lblMobileNum.AutoSize = True
        Me.lblMobileNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMobileNum.Location = New System.Drawing.Point(576, 403)
        Me.lblMobileNum.Name = "lblMobileNum"
        Me.lblMobileNum.Size = New System.Drawing.Size(35, 15)
        Me.lblMobileNum.TabIndex = 31
        Me.lblMobileNum.Text = "####"
        Me.lblMobileNum.Visible = False
        '
        'lblPersonalEm
        '
        Me.lblPersonalEm.AutoSize = True
        Me.lblPersonalEm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPersonalEm.Location = New System.Drawing.Point(576, 467)
        Me.lblPersonalEm.Name = "lblPersonalEm"
        Me.lblPersonalEm.Size = New System.Drawing.Size(35, 15)
        Me.lblPersonalEm.TabIndex = 29
        Me.lblPersonalEm.Text = "####"
        Me.lblPersonalEm.Visible = False
        '
        'lblPersonalNum
        '
        Me.lblPersonalNum.AutoSize = True
        Me.lblPersonalNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPersonalNum.Location = New System.Drawing.Point(576, 435)
        Me.lblPersonalNum.Name = "lblPersonalNum"
        Me.lblPersonalNum.Size = New System.Drawing.Size(35, 15)
        Me.lblPersonalNum.TabIndex = 28
        Me.lblPersonalNum.Text = "####"
        Me.lblPersonalNum.Visible = False
        '
        'btnAddDependent
        '
        Me.btnAddDependent.Enabled = False
        Me.btnAddDependent.Location = New System.Drawing.Point(761, 103)
        Me.btnAddDependent.Name = "btnAddDependent"
        Me.btnAddDependent.Size = New System.Drawing.Size(124, 47)
        Me.btnAddDependent.TabIndex = 32
        Me.btnAddDependent.Text = "&Add Dependent"
        Me.btnAddDependent.UseVisualStyleBackColor = True
        '
        'btnTestLists
        '
        Me.btnTestLists.Location = New System.Drawing.Point(572, 523)
        Me.btnTestLists.Name = "btnTestLists"
        Me.btnTestLists.Size = New System.Drawing.Size(91, 23)
        Me.btnTestLists.TabIndex = 33
        Me.btnTestLists.Text = "Test Lists"
        Me.btnTestLists.UseVisualStyleBackColor = True
        Me.btnTestLists.Visible = False
        '
        'btnTraverse
        '
        Me.btnTraverse.Location = New System.Drawing.Point(682, 523)
        Me.btnTraverse.Name = "btnTraverse"
        Me.btnTraverse.Size = New System.Drawing.Size(91, 23)
        Me.btnTraverse.TabIndex = 36
        Me.btnTraverse.Text = "Traverse"
        Me.btnTraverse.UseVisualStyleBackColor = True
        Me.btnTraverse.Visible = False
        '
        'btnCount
        '
        Me.btnCount.Location = New System.Drawing.Point(794, 523)
        Me.btnCount.Name = "btnCount"
        Me.btnCount.Size = New System.Drawing.Size(91, 23)
        Me.btnCount.TabIndex = 37
        Me.btnCount.Text = "Count"
        Me.btnCount.UseVisualStyleBackColor = True
        Me.btnCount.Visible = False
        '
        'btnEdit
        '
        Me.btnEdit.Enabled = False
        Me.btnEdit.Location = New System.Drawing.Point(761, 160)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(124, 47)
        Me.btnEdit.TabIndex = 38
        Me.btnEdit.Text = "&Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Enabled = False
        Me.btnDelete.Location = New System.Drawing.Point(761, 217)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(124, 47)
        Me.btnDelete.TabIndex = 40
        Me.btnDelete.Text = "D&elete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(761, 274)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(124, 47)
        Me.btnExit.TabIndex = 41
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnAddEmployee
        '
        Me.btnAddEmployee.Location = New System.Drawing.Point(761, 46)
        Me.btnAddEmployee.Name = "btnAddEmployee"
        Me.btnAddEmployee.Size = New System.Drawing.Size(124, 47)
        Me.btnAddEmployee.TabIndex = 42
        Me.btnAddEmployee.Text = "&Add Employee"
        Me.btnAddEmployee.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(903, 558)
        Me.Controls.Add(Me.btnAddEmployee)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnCount)
        Me.Controls.Add(Me.btnTraverse)
        Me.Controls.Add(Me.btnTestLists)
        Me.Controls.Add(Me.btnAddDependent)
        Me.Controls.Add(Me.lblMobileNum)
        Me.Controls.Add(Me.lblPersonalEm)
        Me.Controls.Add(Me.lblPersonalNum)
        Me.Controls.Add(Me.lblEmpNum)
        Me.Controls.Add(Me.lblWorkEmail)
        Me.Controls.Add(Me.lblWorkPhone)
        Me.Controls.Add(Me.lblOfficeLoc)
        Me.Controls.Add(Me.lblSalary)
        Me.Controls.Add(Me.lblEmpType)
        Me.Controls.Add(Me.lblBirthDate)
        Me.Controls.Add(Me.lblHiredDate)
        Me.Controls.Add(Me.lblMiddleName)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.lblFirstName)
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
        Me.Controls.Add(Me.tosMain)
        Me.Controls.Add(Me.trvEmployeesDepend)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmMain"
        Me.Text = "Employee Records (Cesar Mendoza #47)"
        Me.tosMain.ResumeLayout(False)
        Me.tosMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents trvEmployeesDepend As TreeView
    Friend WithEvents tosMain As ToolStrip
    Friend WithEvents tosbtnSaveAs As ToolStripButton
    Friend WithEvents lblFirstNameHeading As Label
    Friend WithEvents lblLastNameHeading As Label
    Friend WithEvents lblMiddleNameHeading As Label
    Friend WithEvents lblHiredDateHeading As Label
    Friend WithEvents lblBirthDateHeading As Label
    Friend WithEvents lblEmpTypeHeading As Label
    Friend WithEvents lblSalaryHeading As Label
    Friend WithEvents lblOfficeLocHeading As Label
    Friend WithEvents lblWorkPhoneHeading As Label
    Friend WithEvents lblEmailHeading As Label
    Friend WithEvents lblMobileHeading As Label
    Friend WithEvents lblPersonalPhoneHeading As Label
    Friend WithEvents lblPersonalEmailHeading As Label
    Friend WithEvents lblEmpNumHeading As Label
    Friend WithEvents lblEmpNum As Label
    Friend WithEvents lblWorkEmail As Label
    Friend WithEvents lblWorkPhone As Label
    Friend WithEvents lblOfficeLoc As Label
    Friend WithEvents lblSalary As Label
    Friend WithEvents lblEmpType As Label
    Friend WithEvents lblBirthDate As Label
    Friend WithEvents lblHiredDate As Label
    Friend WithEvents lblMiddleName As Label
    Friend WithEvents lblLastName As Label
    Friend WithEvents lblFirstName As Label
    Friend WithEvents lblMobileNum As Label
    Friend WithEvents lblPersonalEm As Label
    Friend WithEvents lblPersonalNum As Label
    Friend WithEvents tsbtnNew As ToolStripButton
    Friend WithEvents tsbtnOpen As ToolStripButton
    Friend WithEvents tsbtnSave As ToolStripButton
    Friend WithEvents btnAddDependent As Button
    Friend WithEvents btnTestLists As Button
    Friend WithEvents btnTraverse As Button
    Friend WithEvents btnCount As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents imgTreeIcons As ImageList
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnAddEmployee As Button
End Class
