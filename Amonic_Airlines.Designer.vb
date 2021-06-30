<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Amonic_Airlines
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
        Me.components = New System.ComponentModel.Container()
        Me.LoginPanel = New System.Windows.Forms.Panel()
        Me.txtloginid = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtloginpassword = New System.Windows.Forms.TextBox()
        Me.txtloginussername = New System.Windows.Forms.TextBox()
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.btnInvalidDisplay = New System.Windows.Forms.Button()
        Me.UserTypePanel = New System.Windows.Forms.Panel()
        Me.AdminPanel = New System.Windows.Forms.Panel()
        Me.btnAdminEnableuser = New System.Windows.Forms.Button()
        Me.btnAdminChangeRole = New System.Windows.Forms.Button()
        Me.AdminDGV = New System.Windows.Forms.DataGridView()
        Me.ComboBoxOffices = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.OfficeUserPanel = New System.Windows.Forms.Panel()
        Me.lblUserLoginMessage = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AddUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddUserPanel = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnAddUserCancel = New System.Windows.Forms.Button()
        Me.btnAdduserSave = New System.Windows.Forms.Button()
        Me.txtAddUserPassword = New System.Windows.Forms.TextBox()
        Me.txtAddUserBithDate = New System.Windows.Forms.DateTimePicker()
        Me.txtAddUserOffice = New System.Windows.Forms.ComboBox()
        Me.txtAddUserLname = New System.Windows.Forms.TextBox()
        Me.txtAddUserFname = New System.Windows.Forms.TextBox()
        Me.txtAddUserEmail = New System.Windows.Forms.TextBox()
        Me.EditRolePanel = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnEditRoleCancel = New System.Windows.Forms.Button()
        Me.btnEditRoleApply = New System.Windows.Forms.Button()
        Me.rbtnEditRoleAdmin = New System.Windows.Forms.RadioButton()
        Me.rbtnEditRoleUser = New System.Windows.Forms.RadioButton()
        Me.txtEditRoleOffice = New System.Windows.Forms.ComboBox()
        Me.txtEditRoleLname = New System.Windows.Forms.TextBox()
        Me.txtEditRoleFname = New System.Windows.Forms.TextBox()
        Me.txtEditRoleEmail = New System.Windows.Forms.TextBox()
        Me.btnMessage = New System.Windows.Forms.Button()
        Me.MessageHideTimer = New System.Windows.Forms.Timer(Me.components)
        Me.InvalidLoginTimer = New System.Windows.Forms.Timer(Me.components)
        Me.LoginPanel.SuspendLayout()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UserTypePanel.SuspendLayout()
        Me.AdminPanel.SuspendLayout()
        CType(Me.AdminDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.OfficeUserPanel.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.AddUserPanel.SuspendLayout()
        Me.EditRolePanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'LoginPanel
        '
        Me.LoginPanel.Controls.Add(Me.txtloginid)
        Me.LoginPanel.Controls.Add(Me.btnExit)
        Me.LoginPanel.Controls.Add(Me.btnLogin)
        Me.LoginPanel.Controls.Add(Me.Label2)
        Me.LoginPanel.Controls.Add(Me.Label1)
        Me.LoginPanel.Controls.Add(Me.txtloginpassword)
        Me.LoginPanel.Controls.Add(Me.txtloginussername)
        Me.LoginPanel.Controls.Add(Me.LogoPictureBox)
        Me.LoginPanel.Controls.Add(Me.btnInvalidDisplay)
        Me.LoginPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginPanel.Location = New System.Drawing.Point(74, 92)
        Me.LoginPanel.Name = "LoginPanel"
        Me.LoginPanel.Size = New System.Drawing.Size(225, 117)
        Me.LoginPanel.TabIndex = 0
        '
        'txtloginid
        '
        Me.txtloginid.Location = New System.Drawing.Point(170, 387)
        Me.txtloginid.Name = "txtloginid"
        Me.txtloginid.Size = New System.Drawing.Size(41, 27)
        Me.txtloginid.TabIndex = 8
        Me.txtloginid.Visible = False
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(457, 365)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(143, 48)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(259, 366)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(127, 48)
        Me.btnLogin.TabIndex = 5
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(166, 300)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 22)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(166, 225)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 22)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Username"
        '
        'txtloginpassword
        '
        Me.txtloginpassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtloginpassword.Location = New System.Drawing.Point(327, 300)
        Me.txtloginpassword.Name = "txtloginpassword"
        Me.txtloginpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtloginpassword.Size = New System.Drawing.Size(273, 30)
        Me.txtloginpassword.TabIndex = 2
        Me.txtloginpassword.UseSystemPasswordChar = True
        '
        'txtloginussername
        '
        Me.txtloginussername.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtloginussername.Location = New System.Drawing.Point(327, 220)
        Me.txtloginussername.Name = "txtloginussername"
        Me.txtloginussername.Size = New System.Drawing.Size(273, 30)
        Me.txtloginussername.TabIndex = 1
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.Image = Global.Amonic_Airlines.My.Resources.Resources.Logo
        Me.LogoPictureBox.Location = New System.Drawing.Point(110, 24)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(565, 168)
        Me.LogoPictureBox.TabIndex = 0
        Me.LogoPictureBox.TabStop = False
        '
        'btnInvalidDisplay
        '
        Me.btnInvalidDisplay.FlatAppearance.BorderSize = 0
        Me.btnInvalidDisplay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnInvalidDisplay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnInvalidDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInvalidDisplay.ForeColor = System.Drawing.Color.Red
        Me.btnInvalidDisplay.Location = New System.Drawing.Point(259, 366)
        Me.btnInvalidDisplay.Name = "btnInvalidDisplay"
        Me.btnInvalidDisplay.Size = New System.Drawing.Size(341, 47)
        Me.btnInvalidDisplay.TabIndex = 7
        Me.btnInvalidDisplay.Text = "Attempt Limit Reached"
        Me.btnInvalidDisplay.UseVisualStyleBackColor = True
        Me.btnInvalidDisplay.Visible = False
        '
        'UserTypePanel
        '
        Me.UserTypePanel.Controls.Add(Me.AdminPanel)
        Me.UserTypePanel.Controls.Add(Me.OfficeUserPanel)
        Me.UserTypePanel.Controls.Add(Me.MenuStrip1)
        Me.UserTypePanel.Controls.Add(Me.AddUserPanel)
        Me.UserTypePanel.Controls.Add(Me.EditRolePanel)
        Me.UserTypePanel.Location = New System.Drawing.Point(382, 92)
        Me.UserTypePanel.Name = "UserTypePanel"
        Me.UserTypePanel.Size = New System.Drawing.Size(219, 117)
        Me.UserTypePanel.TabIndex = 1
        Me.UserTypePanel.Visible = False
        '
        'AdminPanel
        '
        Me.AdminPanel.Controls.Add(Me.btnAdminEnableuser)
        Me.AdminPanel.Controls.Add(Me.btnAdminChangeRole)
        Me.AdminPanel.Controls.Add(Me.AdminDGV)
        Me.AdminPanel.Controls.Add(Me.ComboBoxOffices)
        Me.AdminPanel.Controls.Add(Me.Label3)
        Me.AdminPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminPanel.Location = New System.Drawing.Point(23, 157)
        Me.AdminPanel.Name = "AdminPanel"
        Me.AdminPanel.Size = New System.Drawing.Size(152, 100)
        Me.AdminPanel.TabIndex = 1
        Me.AdminPanel.Visible = False
        '
        'btnAdminEnableuser
        '
        Me.btnAdminEnableuser.Location = New System.Drawing.Point(273, 362)
        Me.btnAdminEnableuser.Name = "btnAdminEnableuser"
        Me.btnAdminEnableuser.Size = New System.Drawing.Size(194, 52)
        Me.btnAdminEnableuser.TabIndex = 4
        Me.btnAdminEnableuser.Text = "Enable/Disable Login"
        Me.btnAdminEnableuser.UseVisualStyleBackColor = True
        '
        'btnAdminChangeRole
        '
        Me.btnAdminChangeRole.Location = New System.Drawing.Point(71, 362)
        Me.btnAdminChangeRole.Name = "btnAdminChangeRole"
        Me.btnAdminChangeRole.Size = New System.Drawing.Size(158, 52)
        Me.btnAdminChangeRole.TabIndex = 3
        Me.btnAdminChangeRole.Text = "Change Role"
        Me.btnAdminChangeRole.UseVisualStyleBackColor = True
        '
        'AdminDGV
        '
        Me.AdminDGV.AllowUserToAddRows = False
        Me.AdminDGV.AllowUserToDeleteRows = False
        Me.AdminDGV.AllowUserToResizeColumns = False
        Me.AdminDGV.AllowUserToResizeRows = False
        Me.AdminDGV.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.AdminDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AdminDGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.AdminDGV.Location = New System.Drawing.Point(30, 45)
        Me.AdminDGV.MultiSelect = False
        Me.AdminDGV.Name = "AdminDGV"
        Me.AdminDGV.ReadOnly = True
        Me.AdminDGV.RowHeadersVisible = False
        Me.AdminDGV.RowTemplate.Height = 35
        Me.AdminDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.AdminDGV.Size = New System.Drawing.Size(727, 285)
        Me.AdminDGV.StandardTab = True
        Me.AdminDGV.TabIndex = 2
        Me.AdminDGV.VirtualMode = True
        '
        'ComboBoxOffices
        '
        Me.ComboBoxOffices.FormattingEnabled = True
        Me.ComboBoxOffices.Location = New System.Drawing.Point(139, 11)
        Me.ComboBoxOffices.Name = "ComboBoxOffices"
        Me.ComboBoxOffices.Size = New System.Drawing.Size(173, 28)
        Me.ComboBoxOffices.TabIndex = 1
        Me.ComboBoxOffices.Text = "All Offices"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(74, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Office :"
        '
        'OfficeUserPanel
        '
        Me.OfficeUserPanel.Controls.Add(Me.lblUserLoginMessage)
        Me.OfficeUserPanel.Location = New System.Drawing.Point(204, 157)
        Me.OfficeUserPanel.Name = "OfficeUserPanel"
        Me.OfficeUserPanel.Size = New System.Drawing.Size(179, 100)
        Me.OfficeUserPanel.TabIndex = 2
        Me.OfficeUserPanel.Visible = False
        '
        'lblUserLoginMessage
        '
        Me.lblUserLoginMessage.AutoSize = True
        Me.lblUserLoginMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserLoginMessage.Location = New System.Drawing.Point(80, 53)
        Me.lblUserLoginMessage.Name = "lblUserLoginMessage"
        Me.lblUserLoginMessage.Size = New System.Drawing.Size(66, 24)
        Me.lblUserLoginMessage.TabIndex = 0
        Me.lblUserLoginMessage.Text = "Label4"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddUserToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(219, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AddUserToolStripMenuItem
        '
        Me.AddUserToolStripMenuItem.Name = "AddUserToolStripMenuItem"
        Me.AddUserToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.AddUserToolStripMenuItem.Text = "Add User"
        Me.AddUserToolStripMenuItem.Visible = False
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(38, 20)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'AddUserPanel
        '
        Me.AddUserPanel.Controls.Add(Me.Label14)
        Me.AddUserPanel.Controls.Add(Me.Label13)
        Me.AddUserPanel.Controls.Add(Me.Label12)
        Me.AddUserPanel.Controls.Add(Me.Label11)
        Me.AddUserPanel.Controls.Add(Me.Label10)
        Me.AddUserPanel.Controls.Add(Me.Label9)
        Me.AddUserPanel.Controls.Add(Me.btnAddUserCancel)
        Me.AddUserPanel.Controls.Add(Me.btnAdduserSave)
        Me.AddUserPanel.Controls.Add(Me.txtAddUserPassword)
        Me.AddUserPanel.Controls.Add(Me.txtAddUserBithDate)
        Me.AddUserPanel.Controls.Add(Me.txtAddUserOffice)
        Me.AddUserPanel.Controls.Add(Me.txtAddUserLname)
        Me.AddUserPanel.Controls.Add(Me.txtAddUserFname)
        Me.AddUserPanel.Controls.Add(Me.txtAddUserEmail)
        Me.AddUserPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddUserPanel.Location = New System.Drawing.Point(400, 157)
        Me.AddUserPanel.Name = "AddUserPanel"
        Me.AddUserPanel.Size = New System.Drawing.Size(185, 100)
        Me.AddUserPanel.TabIndex = 3
        Me.AddUserPanel.Visible = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(157, 300)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(89, 22)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "Password"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(157, 244)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(90, 22)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Birth Date"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(157, 192)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(57, 22)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Office"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(157, 141)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(96, 22)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Last Name"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(157, 90)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(97, 22)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "First Name"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(157, 37)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(125, 22)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Email Address"
        '
        'btnAddUserCancel
        '
        Me.btnAddUserCancel.Location = New System.Drawing.Point(422, 357)
        Me.btnAddUserCancel.Name = "btnAddUserCancel"
        Me.btnAddUserCancel.Size = New System.Drawing.Size(137, 44)
        Me.btnAddUserCancel.TabIndex = 7
        Me.btnAddUserCancel.Text = "Cancel"
        Me.btnAddUserCancel.UseVisualStyleBackColor = True
        '
        'btnAdduserSave
        '
        Me.btnAdduserSave.Location = New System.Drawing.Point(220, 357)
        Me.btnAdduserSave.Name = "btnAdduserSave"
        Me.btnAdduserSave.Size = New System.Drawing.Size(126, 44)
        Me.btnAdduserSave.TabIndex = 6
        Me.btnAdduserSave.Text = "Save"
        Me.btnAdduserSave.UseVisualStyleBackColor = True
        '
        'txtAddUserPassword
        '
        Me.txtAddUserPassword.Location = New System.Drawing.Point(299, 295)
        Me.txtAddUserPassword.Name = "txtAddUserPassword"
        Me.txtAddUserPassword.Size = New System.Drawing.Size(260, 27)
        Me.txtAddUserPassword.TabIndex = 5
        '
        'txtAddUserBithDate
        '
        Me.txtAddUserBithDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtAddUserBithDate.Location = New System.Drawing.Point(300, 239)
        Me.txtAddUserBithDate.Name = "txtAddUserBithDate"
        Me.txtAddUserBithDate.Size = New System.Drawing.Size(259, 27)
        Me.txtAddUserBithDate.TabIndex = 4
        '
        'txtAddUserOffice
        '
        Me.txtAddUserOffice.FormattingEnabled = True
        Me.txtAddUserOffice.Location = New System.Drawing.Point(302, 186)
        Me.txtAddUserOffice.Name = "txtAddUserOffice"
        Me.txtAddUserOffice.Size = New System.Drawing.Size(257, 28)
        Me.txtAddUserOffice.TabIndex = 3
        '
        'txtAddUserLname
        '
        Me.txtAddUserLname.Location = New System.Drawing.Point(300, 136)
        Me.txtAddUserLname.Name = "txtAddUserLname"
        Me.txtAddUserLname.Size = New System.Drawing.Size(259, 27)
        Me.txtAddUserLname.TabIndex = 2
        '
        'txtAddUserFname
        '
        Me.txtAddUserFname.Location = New System.Drawing.Point(299, 85)
        Me.txtAddUserFname.Name = "txtAddUserFname"
        Me.txtAddUserFname.Size = New System.Drawing.Size(260, 27)
        Me.txtAddUserFname.TabIndex = 1
        '
        'txtAddUserEmail
        '
        Me.txtAddUserEmail.Location = New System.Drawing.Point(299, 32)
        Me.txtAddUserEmail.Name = "txtAddUserEmail"
        Me.txtAddUserEmail.Size = New System.Drawing.Size(260, 27)
        Me.txtAddUserEmail.TabIndex = 0
        '
        'EditRolePanel
        '
        Me.EditRolePanel.Controls.Add(Me.Label8)
        Me.EditRolePanel.Controls.Add(Me.Label7)
        Me.EditRolePanel.Controls.Add(Me.Label6)
        Me.EditRolePanel.Controls.Add(Me.Label5)
        Me.EditRolePanel.Controls.Add(Me.Label4)
        Me.EditRolePanel.Controls.Add(Me.btnEditRoleCancel)
        Me.EditRolePanel.Controls.Add(Me.btnEditRoleApply)
        Me.EditRolePanel.Controls.Add(Me.rbtnEditRoleAdmin)
        Me.EditRolePanel.Controls.Add(Me.rbtnEditRoleUser)
        Me.EditRolePanel.Controls.Add(Me.txtEditRoleOffice)
        Me.EditRolePanel.Controls.Add(Me.txtEditRoleLname)
        Me.EditRolePanel.Controls.Add(Me.txtEditRoleFname)
        Me.EditRolePanel.Controls.Add(Me.txtEditRoleEmail)
        Me.EditRolePanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditRolePanel.Location = New System.Drawing.Point(591, 157)
        Me.EditRolePanel.Name = "EditRolePanel"
        Me.EditRolePanel.Size = New System.Drawing.Size(197, 100)
        Me.EditRolePanel.TabIndex = 4
        Me.EditRolePanel.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(177, 263)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 22)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Role"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(177, 211)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 22)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Office"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(177, 153)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 22)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Last Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(177, 92)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 22)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "First Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(177, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 22)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Email Address"
        '
        'btnEditRoleCancel
        '
        Me.btnEditRoleCancel.Location = New System.Drawing.Point(446, 352)
        Me.btnEditRoleCancel.Name = "btnEditRoleCancel"
        Me.btnEditRoleCancel.Size = New System.Drawing.Size(136, 46)
        Me.btnEditRoleCancel.TabIndex = 7
        Me.btnEditRoleCancel.Text = "Cancel"
        Me.btnEditRoleCancel.UseVisualStyleBackColor = True
        '
        'btnEditRoleApply
        '
        Me.btnEditRoleApply.Location = New System.Drawing.Point(225, 352)
        Me.btnEditRoleApply.Name = "btnEditRoleApply"
        Me.btnEditRoleApply.Size = New System.Drawing.Size(137, 46)
        Me.btnEditRoleApply.TabIndex = 6
        Me.btnEditRoleApply.Text = "Apply"
        Me.btnEditRoleApply.UseVisualStyleBackColor = True
        '
        'rbtnEditRoleAdmin
        '
        Me.rbtnEditRoleAdmin.AutoSize = True
        Me.rbtnEditRoleAdmin.Location = New System.Drawing.Point(348, 291)
        Me.rbtnEditRoleAdmin.Name = "rbtnEditRoleAdmin"
        Me.rbtnEditRoleAdmin.Size = New System.Drawing.Size(133, 26)
        Me.rbtnEditRoleAdmin.TabIndex = 5
        Me.rbtnEditRoleAdmin.TabStop = True
        Me.rbtnEditRoleAdmin.Text = "Administrator"
        Me.rbtnEditRoleAdmin.UseVisualStyleBackColor = True
        '
        'rbtnEditRoleUser
        '
        Me.rbtnEditRoleUser.AutoSize = True
        Me.rbtnEditRoleUser.Location = New System.Drawing.Point(348, 259)
        Me.rbtnEditRoleUser.Name = "rbtnEditRoleUser"
        Me.rbtnEditRoleUser.Size = New System.Drawing.Size(66, 26)
        Me.rbtnEditRoleUser.TabIndex = 4
        Me.rbtnEditRoleUser.TabStop = True
        Me.rbtnEditRoleUser.Text = "User"
        Me.rbtnEditRoleUser.UseVisualStyleBackColor = True
        '
        'txtEditRoleOffice
        '
        Me.txtEditRoleOffice.FormattingEnabled = True
        Me.txtEditRoleOffice.Location = New System.Drawing.Point(348, 202)
        Me.txtEditRoleOffice.Name = "txtEditRoleOffice"
        Me.txtEditRoleOffice.Size = New System.Drawing.Size(234, 28)
        Me.txtEditRoleOffice.TabIndex = 3
        '
        'txtEditRoleLname
        '
        Me.txtEditRoleLname.Location = New System.Drawing.Point(348, 145)
        Me.txtEditRoleLname.Name = "txtEditRoleLname"
        Me.txtEditRoleLname.Size = New System.Drawing.Size(237, 27)
        Me.txtEditRoleLname.TabIndex = 2
        '
        'txtEditRoleFname
        '
        Me.txtEditRoleFname.Location = New System.Drawing.Point(348, 87)
        Me.txtEditRoleFname.Name = "txtEditRoleFname"
        Me.txtEditRoleFname.Size = New System.Drawing.Size(237, 27)
        Me.txtEditRoleFname.TabIndex = 1
        '
        'txtEditRoleEmail
        '
        Me.txtEditRoleEmail.Location = New System.Drawing.Point(348, 32)
        Me.txtEditRoleEmail.Name = "txtEditRoleEmail"
        Me.txtEditRoleEmail.Size = New System.Drawing.Size(237, 27)
        Me.txtEditRoleEmail.TabIndex = 0
        '
        'btnMessage
        '
        Me.btnMessage.AutoSize = True
        Me.btnMessage.BackColor = System.Drawing.Color.LightCoral
        Me.btnMessage.FlatAppearance.BorderSize = 0
        Me.btnMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMessage.ForeColor = System.Drawing.Color.Snow
        Me.btnMessage.Location = New System.Drawing.Point(512, 12)
        Me.btnMessage.Name = "btnMessage"
        Me.btnMessage.Size = New System.Drawing.Size(276, 50)
        Me.btnMessage.TabIndex = 1
        Me.btnMessage.Text = "Message"
        Me.btnMessage.UseVisualStyleBackColor = False
        Me.btnMessage.Visible = False
        '
        'MessageHideTimer
        '
        Me.MessageHideTimer.Interval = 1000
        '
        'InvalidLoginTimer
        '
        Me.InvalidLoginTimer.Interval = 1000
        '
        'Amonic_Airlines
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnMessage)
        Me.Controls.Add(Me.LoginPanel)
        Me.Controls.Add(Me.UserTypePanel)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Amonic_Airlines"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Amonic_Airlines"
        Me.LoginPanel.ResumeLayout(False)
        Me.LoginPanel.PerformLayout()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UserTypePanel.ResumeLayout(False)
        Me.UserTypePanel.PerformLayout()
        Me.AdminPanel.ResumeLayout(False)
        Me.AdminPanel.PerformLayout()
        CType(Me.AdminDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.OfficeUserPanel.ResumeLayout(False)
        Me.OfficeUserPanel.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.AddUserPanel.ResumeLayout(False)
        Me.AddUserPanel.PerformLayout()
        Me.EditRolePanel.ResumeLayout(False)
        Me.EditRolePanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LoginPanel As Panel
    Friend WithEvents btnExit As Button
    Friend WithEvents btnLogin As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtloginpassword As TextBox
    Friend WithEvents txtloginussername As TextBox
    Friend WithEvents LogoPictureBox As PictureBox
    Friend WithEvents UserTypePanel As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AddUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnMessage As Button
    Friend WithEvents EditRolePanel As Panel
    Friend WithEvents AddUserPanel As Panel
    Friend WithEvents OfficeUserPanel As Panel
    Friend WithEvents AdminPanel As Panel
    Friend WithEvents MessageHideTimer As Timer
    Friend WithEvents InvalidLoginTimer As Timer
    Friend WithEvents btnInvalidDisplay As Button
    Friend WithEvents txtloginid As TextBox
    Friend WithEvents ComboBoxOffices As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lblUserLoginMessage As Label
    Friend WithEvents AdminDGV As DataGridView
    Friend WithEvents btnAdminEnableuser As Button
    Friend WithEvents btnAdminChangeRole As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnEditRoleCancel As Button
    Friend WithEvents btnEditRoleApply As Button
    Friend WithEvents rbtnEditRoleAdmin As RadioButton
    Friend WithEvents rbtnEditRoleUser As RadioButton
    Friend WithEvents txtEditRoleOffice As ComboBox
    Friend WithEvents txtEditRoleLname As TextBox
    Friend WithEvents txtEditRoleFname As TextBox
    Friend WithEvents txtEditRoleEmail As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnAddUserCancel As Button
    Friend WithEvents btnAdduserSave As Button
    Friend WithEvents txtAddUserPassword As TextBox
    Friend WithEvents txtAddUserBithDate As DateTimePicker
    Friend WithEvents txtAddUserOffice As ComboBox
    Friend WithEvents txtAddUserLname As TextBox
    Friend WithEvents txtAddUserFname As TextBox
    Friend WithEvents txtAddUserEmail As TextBox
End Class
