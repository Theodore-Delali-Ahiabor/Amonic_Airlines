Imports System.Data.OleDb
Public Class Amonic_Airlines
    ReadOnly con As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\theod\Desktop\  \HTU\Level 200\2nd Semister\Visual Basic ii\Amonic_Airlines\Airlines_db.accdb"
    Dim AdminDA, AdminDA1, AdminDA2 As OleDbDataAdapter
    Dim LoginSQLstmt, RoleSQLstmt, OfficeSQLStmt, AdminDefaultSQLstmt, AdminSearchSQLstmt As String
    Dim Role As String
    Dim invalidcount As Integer = 0
    Dim InvalidTS, MessageHideTS As TimeSpan
    ReadOnly LoginCon As New OleDbConnection(con)
    Private Sub Amonic_Airlines_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Login"
        LoginPanel.Show()
        LoginPanel.Dock = DockStyle.Fill
        UserTypePanel.Hide()
        txtloginussername.Text = "yaotog@gmail.com"
        txtloginpassword.Text = "welcome"
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim repos As DialogResult = MessageBox.Show("Are you sure you want to close ?", "WARNIG!!!", MessageBoxButtons.YesNo)
        If repos = DialogResult.Yes Then
            Close()
        End If
    End Sub
    Private Sub AddUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddUserToolStripMenuItem.Click
        Me.Text = "Add user"
        MenuStrip1.Hide()
        AdminPanel.Hide()
        AddUserPanel.Show()
        AddUserPanel.Dock = DockStyle.Fill
    End Sub
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        btnExit_Click(sender, e)
    End Sub
    Private Sub MessageHideTimer_Tick(sender As Object, e As EventArgs) Handles MessageHideTimer.Tick
        If MessageHideTS.Seconds = 0 Then
            btnMessage.Hide()
            MessageHideTimer.Stop()
        Else
            MessageHideTS = MessageHideTS.Subtract(New TimeSpan(0, 0, 1))
        End If
    End Sub
    Private Sub InvalidLoginTimer_Tick(sender As Object, e As EventArgs) Handles InvalidLoginTimer.Tick
        If InvalidTS.Minutes = 0 AndAlso InvalidTS.Seconds = 0 Then
            btnInvalidDisplay.Hide()
            btnLogin.Show()
            btnExit.Show()
            txtloginpassword.Enabled = True
            txtloginussername.Enabled = True
            txtloginussername.Focus()
            InvalidLoginTimer.Stop()
        Else
            InvalidTS = InvalidTS.Subtract(New TimeSpan(0, 0, 1))
            btnInvalidDisplay.Text = String.Format("Try Again in  {0} Mins : {1} Secs", InvalidTS.Minutes, InvalidTS.Seconds)
        End If
    End Sub
    Public Sub ShowMessage()
        btnMessage.Show()
        MessageHideTimer.Enabled = True
        MessageHideTS = New TimeSpan(0, 0, 2)
    End Sub
    Private Sub btnMessage_Click(sender As Object, e As EventArgs) Handles btnMessage.Click
        btnMessage.Hide()
    End Sub
    Private Sub btnAdminChangeRole_Click(sender As Object, e As EventArgs) Handles btnAdminChangeRole.Click
        AdminPanel.Hide()
        Me.Text = "Edit Role"
        MenuStrip1.Hide()
        EditRolePanel.Show()
        EditRolePanel.Dock = DockStyle.Fill
        Try
            txtEditRoleEmail.Text = AdminDGV.CurrentRow.Cells(3).Value
            txtEditRoleFname.Text = AdminDGV.CurrentRow.Cells(5).Value
            txtEditRoleLname.Text = AdminDGV.CurrentRow.Cells(6).Value
            txtEditRoleOffice.Text = AdminDGV.CurrentRow.Cells(17).Value
            If AdminDGV.CurrentRow.Cells(15).Value = "Administrator" Then
                rbtnEditRoleAdmin.Checked = True
            ElseIf AdminDGV.CurrentRow.Cells(15).Value = "Office User" Then
                rbtnEditRoleUser.Checked = True
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub btnEditRoleApply_Click(sender As Object, e As EventArgs) Handles btnEditRoleApply.Click
        If rbtnEditRoleAdmin.Checked Then
            Role = "Administrator"
        ElseIf rbtnEditRoleUser.Checked Then
            Role = "Office User"
        End If
        If txtEditRoleEmail.Text <> "" And txtEditRoleOffice.Text <> "" Then
            Try
                Dim AdminDS, AdminDS1, AdminDS2 As New DataSet
                Dim EditRoleSQLstmt, EditRoleSQLstmt1, EditRoleSQLstmt2 As String
                EditRoleSQLstmt = "UPDATE Users SET Firstname ='" & CStr(txtEditRoleFname.Text) & "', Lastname ='" & CStr(txtEditRoleLname.Text) & "', Email = '" & CStr(txtEditRoleEmail.Text) & "' Where CStr(ID) = '" & CStr(AdminDGV.CurrentRow.Cells(0).Value) & "'"
                EditRoleSQLstmt1 = "UPDATE Countries SET  Name ='" & CStr(txtEditRoleOffice.Text) & "' Where CStr(ID) = '" & CStr(AdminDGV.CurrentRow.Cells(0).Value) & "'"
                EditRoleSQLstmt2 = "UPDATE  Roles SET  Title =  '" & Role & "' Where CStr(ID) = '" & CStr(AdminDGV.CurrentRow.Cells(0).Value) & "'"
                AdminDA = New OleDbDataAdapter(EditRoleSQLstmt1, LoginCon)
                AdminDA.Fill(AdminDS, "Users")
                Dim AdminDA1 = New OleDbDataAdapter(EditRoleSQLstmt1, LoginCon)
                AdminDA1.Fill(AdminDS1, "Countries")
                Dim AdminDA2 = New OleDbDataAdapter(EditRoleSQLstmt2, LoginCon)
                AdminDA2.Fill(AdminDS2, "Roles")
                btnEditRoleCancel_Click(sender, e)
                ShowMessage()
                ComboBoxOffices_SelectedIndexChanged(sender, e)
                btnMessage.Text = "Record Updated Succesfully"
                btnMessage.BackColor = Color.PaleGreen
                btnMessage.ForeColor = Color.Green
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub
    Private Sub btnEditRoleCancel_Click(sender As Object, e As EventArgs) Handles btnEditRoleCancel.Click
        EditRolePanel.Hide()
        Me.Text = "Amonic Airlines Automation System"
        MenuStrip1.Show()
        AdminPanel.Show()
        AdminPanel.Dock = DockStyle.Fill
    End Sub
    Private Sub btnAdminEnableuser_Click(sender As Object, e As EventArgs) Handles btnAdminEnableuser.Click
        Try
            If AdminDGV.CurrentRow.Cells(8).Value.ToString = True Then
                Dim repos As DialogResult = MessageBox.Show("Are you sure you want Disable This User ?", "Information", MessageBoxButtons.YesNo)
                If repos = DialogResult.Yes Then
                    AdminDGV.CurrentRow.Cells(8).Value = False
                    Dim AdminDS As New DataSet
                    Dim UpdateGridSQLStmt As String
                    UpdateGridSQLStmt = "UPDATE Users SET [Active] = False Where CStr(ID) = '" & CStr(AdminDGV.CurrentRow.Cells(0).Value) & "'"
                    AdminDA = New OleDbDataAdapter(UpdateGridSQLStmt, con)
                    AdminDA.Fill(AdminDS, "Users")
                    ComboBoxOffices_SelectedIndexChanged(sender, e)
                    ShowMessage()
                    btnMessage.Text = "User Successfully Disabled"
                    btnMessage.BackColor = Color.PaleGreen
                    btnMessage.ForeColor = Color.Green
                End If
            Else
                Dim repos As DialogResult = MessageBox.Show("Are you sure you want Enable This User ?", "Information", MessageBoxButtons.YesNo)
                If repos = DialogResult.Yes Then
                    Dim AdminDS As New DataSet
                    Dim UpdateGridSQLStmt As String
                    UpdateGridSQLStmt = "UPDATE Users SET [Active] = True Where CStr(ID) = '" & CStr(AdminDGV.CurrentRow.Cells(0).Value) & "'"
                    AdminDA = New OleDbDataAdapter(UpdateGridSQLStmt, con)
                    AdminDA.Fill(AdminDS, "Users")
                    ComboBoxOffices_SelectedIndexChanged(sender, e)
                    ShowMessage()
                    AdminDGV.CurrentRow.Cells(8).Value = True
                    btnMessage.Text = "User Successfully Enabled"
                    btnMessage.BackColor = Color.PaleGreen
                    btnMessage.ForeColor = Color.Green
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub ComboBoxOffices_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxOffices.SelectedIndexChanged
        Try
            AdminDefaultSQLstmt = "SELECT  Users.*, Offices.*, Roles.*, Countries.*, Age_Query.* FROM   ((Roles INNER JOIN  (Countries INNER JOIN   (Offices INNER JOIN   Users ON Offices.ID = Users.OfficeID) ON Countries.ID = Offices.CountryID) ON Roles.ID = Users.RoleID) INNER JOIN   Age_Query ON Users.ID = Age_Query.ID)"
            AdminSearchSQLstmt = "SELECT  Users.*, Offices.*, Roles.*, Countries.*, Age_Query.* FROM   ((Roles INNER JOIN  (Countries INNER JOIN   (Offices INNER JOIN   Users ON Offices.ID = Users.OfficeID) ON Countries.ID = Offices.CountryID) ON Roles.ID = Users.RoleID) INNER JOIN   Age_Query ON Users.ID = Age_Query.ID) Where Offices.Title = '" & ComboBoxOffices.Text & "'"
            If ComboBoxOffices.SelectedIndex = 0 Then
                AdminDA = New OleDbDataAdapter(AdminDefaultSQLstmt, LoginCon)
                Dim AdminDT As New DataTable
                AdminDA.Fill(AdminDT)
                AdminDGV.DataSource = AdminDT
            Else
                AdminDA = New OleDbDataAdapter(AdminSearchSQLstmt, LoginCon)
                Dim AdminDT As New DataTable
                AdminDA.Fill(AdminDT)
                AdminDGV.DataSource = AdminDT
            End If
            AdminDGV.Columns(0).Width = 0 'Users.ID
            AdminDGV.Columns(1).Visible = False 'OfficeID
            AdminDGV.Columns(2).Visible = False 'RoleID
            AdminDGV.Columns(3).Width = 210 'User.Email
            AdminDGV.Columns(4).Visible = False 'Password
            AdminDGV.Columns(5).Width = 105 'Firstname
            AdminDGV.Columns(6).Width = 105 'Lastname
            AdminDGV.Columns(7).Width = 100 'BirthDate
            AdminDGV.Columns(8).Visible = False 'Active
            AdminDGV.Columns(9).Visible = False 'Office.ID
            AdminDGV.Columns(10).Visible = False 'CountryID
            AdminDGV.Columns(11).Visible = False 'Phone
            AdminDGV.Columns(12).Visible = False 'Contract
            AdminDGV.Columns(13).HeaderText = "Office" 'Office.Title
            AdminDGV.Columns(14).Visible = False 'Roles.ID
            AdminDGV.Columns(15).Visible = False 'Roles.Title
            AdminDGV.Columns(16).Visible = False 'Countries.ID
            AdminDGV.Columns(17).Visible = False  'Countries.Name
            AdminDGV.Columns(18).Visible = False 'Age_Query.ID
            AdminDGV.Columns(19).Width = 80
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Dim newuser As String = "Office User"
    Private Sub btnAdduserSave_Click(sender As Object, e As EventArgs) Handles btnAdduserSave.Click
        If txtAddUserEmail.Text <> "" And txtAddUserFname.Text <> "" And txtAddUserLname.Text <> "" And txtAddUserPassword.Text <> "" Then
            Try
                Dim AddUserSQLStmt, AddUserSQLStmt1, AddUserSQLStmt2 As String
                Dim AdminDS As New DataSet
                'ADDING NEW USER EMAIL, PASSWORD ,FIRST NAME, LAST NAME, BITH DATE, ACTIVE
                AddUserSQLStmt = "INSERT INTO Users(Email, [Password], Firstname, Lastname, Birthdate,Active) VALUES ('" & txtAddUserEmail.Text & "','" & txtAddUserPassword.Text & "','" & txtAddUserFname.Text & "','" & txtAddUserLname.Text & "','" & txtAddUserBithDate.Text & "',True)"
                AdminDA = New OleDbDataAdapter(AddUserSQLStmt, LoginCon)
                AdminDA.Fill(AdminDS, "Users")
                'ADDING NEW USER OFFICE TITTLE
                AddUserSQLStmt1 = "INSERT INTO Offices(Title) VALUES('" & txtAddUserOffice.Text & "')"
                AdminDA = New OleDbDataAdapter(AddUserSQLStmt1, LoginCon)
                AdminDA.Fill(AdminDS, "Offices")
                'ADDING NEW USER ROLE TITTLE
                AddUserSQLStmt2 = "INSERT INTO Roles(Title) VALUES('" & "Office User" & "')"
                AdminDA = New OleDbDataAdapter(AddUserSQLStmt2, LoginCon)
                AdminDA.Fill(AdminDS, "Roles")
                ShowMessage()
                ComboBoxOffices_SelectedIndexChanged(sender, e)
                btnMessage.Text = "Record Added Succesfully"
                btnMessage.BackColor = Color.PaleGreen
                btnMessage.ForeColor = Color.Green
                btnAddUserCancel_Click(sender, e)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Else
            ShowMessage()
            btnMessage.Text = "Fill-Out the Form Completely"
            btnMessage.BackColor = Color.LightCoral
            btnMessage.ForeColor = Color.Snow
        End If
    End Sub
    Private Sub btnAddUserCancel_Click(sender As Object, e As EventArgs) Handles btnAddUserCancel.Click
        Me.Text = "Amonic Airlines Automation System"
        MenuStrip1.Show()
        AdminPanel.Show()
        AddUserPanel.Hide()
        AdminPanel.Dock = DockStyle.Fill
        txtAddUserBithDate.ResetText()
        txtAddUserEmail.Clear()
        txtAddUserFname.Clear()
        txtAddUserLname.Clear()
        txtAddUserPassword.Clear()
    End Sub
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtloginpassword.Text <> "" And txtloginussername.Text <> "" Then
            If txtloginussername.Text.Contains("'") Then
                ShowMessage()
                btnMessage.Text = "Unexpeted Character"
                txtloginussername.Focus()
            Else
                Try
                    LoginSQLstmt = "Select * from [Users] where [Email] = '" & CStr(txtloginussername.Text) & "' and [Password] = '" & CStr(txtloginpassword.Text) & "'"
                    RoleSQLstmt = "Select Roles.*, Users.* From (Users INNER JOIN Roles ON Users.RoleID = Roles.ID) where [Email] = '" & CStr(txtloginussername.Text) & "' and [Password] = '" & CStr(txtloginpassword.Text) & "'"
                    OfficeSQLStmt = "Select * from Offices"
                    Dim LoginCmd As New OleDbCommand(LoginSQLstmt, LoginCon)
                    Dim RoleCmd As New OleDbCommand(RoleSQLstmt, LoginCon)
                    Dim OfficeCmd As New OleDbCommand(OfficeSQLStmt, LoginCon)
                    LoginCmd.Connection.Open()
                    Dim LoginRead As OleDbDataReader = LoginCmd.ExecuteReader(CommandBehavior.CloseConnection)
                    If LoginRead.Read And LoginRead.HasRows Then
                        txtloginid.Text = LoginRead.Item("RoleID").ToString
                        If LoginRead.Item("Active").ToString = True Then
                            txtloginpassword.Focus()
                            LoginPanel.Hide()
                            UserTypePanel.Show()
                            Me.Text = "Amonic Airlines Automation System"
                            UserTypePanel.Dock = DockStyle.Fill
                            ShowMessage()
                            btnMessage.Text = "Login was Succesfull"
                            btnMessage.BackColor = Color.PaleGreen
                            btnMessage.ForeColor = Color.Green
                            Dim RoleRead As OleDbDataReader = RoleCmd.ExecuteReader(CommandBehavior.CloseConnection)
                            If RoleRead.Read And RoleRead.HasRows Then
                                If RoleRead.Item("Title").ToString = "Administrator" Then
                                    AddUserToolStripMenuItem.Visible = True
                                    AdminPanel.Visible = True
                                    AdminPanel.Dock = DockStyle.Fill
                                    'FILLING THE ADMIN COMBOBOX WITH THE OFFICES AVAILABLE IN THE OFFICE TABLE
                                    Dim OfficeRead As OleDbDataReader = OfficeCmd.ExecuteReader(CommandBehavior.CloseConnection)
                                    ComboBoxOffices.Items.Add("All Offices")
                                    ComboBoxOffices.SelectedIndex() = 0
                                    While OfficeRead.Read
                                        ComboBoxOffices.Items.Add(OfficeRead.Item("Title").ToString)
                                        txtAddUserOffice.Items.Add(OfficeRead.Item("Title").ToString)
                                        txtEditRoleOffice.Items.Add(OfficeRead.Item("Title").ToString)
                                    End While
                                    ComboBoxOffices_SelectedIndexChanged(sender, e)
                                Else
                                    OfficeUserPanel.Visible = True
                                    OfficeUserPanel.Dock = DockStyle.Fill
                                    lblUserLoginMessage.Text = "Hi, " & LoginRead.Item("Firstname") & " " & LoginRead.Item("Lastname") & " Welcome to AMONIC Airlines "
                                End If
                            End If
                        Else
                            ShowMessage()
                            btnMessage.Text = "User Disabled, Contact Admin"
                        End If
                    Else
                        invalidcount += 1
                        ShowMessage()
                        btnMessage.Text = "Invalid Ussername or Password"
                        txtloginussername.Clear()
                        txtloginpassword.Clear()
                        txtloginussername.Focus()
                        If invalidcount > 3 Then
                            btnExit.Hide()
                            btnLogin.Hide()
                            txtloginpassword.Enabled = False
                            txtloginussername.Enabled = False
                            btnInvalidDisplay.Show()
                            InvalidTS = New TimeSpan(0, 59, 59)
                            InvalidLoginTimer.Enabled = True
                            ShowMessage()
                            btnMessage.Text = "Out Of Attempts"
                            btnInvalidDisplay.Focus()
                            'invalidcount = 0
                        End If
                    End If
                    LoginCon.Close()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End If
        ElseIf txtloginussername.Text = "" Then
            ShowMessage()
            btnMessage.Text = "Ussername Field is Empty"
            txtloginussername.Focus()
        ElseIf txtloginpassword.Text = "" Then
            ShowMessage()
            btnMessage.Text = " Password Field is Empty"
            txtloginpassword.Focus()
        End If
    End Sub
End Class