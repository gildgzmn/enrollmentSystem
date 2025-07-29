Imports MySql.Data.MySqlClient

Public Class EnrolledStdForm
    Private Sub EnrolledStdForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub LoadData()
        Dim query As String = "SELECT stud_id, lastname, firstname, middlename, course, year, section, semester, subj_code FROM enrollment.enrolled_stud"
        Dim MysqlConn As New MySqlConnection("server=localhost; userid=root; password=cpe123; database=enrollment")
        Dim table As New DataTable()
        Dim Adapter As New MySqlDataAdapter(query, MysqlConn)
        Adapter.Fill(table)
        Std_Table.ClearSelection()
        Std_Table.DataSource = table
    End Sub


    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Dim stud_id As String = InputBox("Enter the Student ID:")
        If stud_id = "" Then
            Return
        End If
        ' Check if the student ID already exists in the database
        Dim query1 As String = "SELECT COUNT(*) FROM enrollment.enrolled_stud WHERE stud_id=@stud_id"
        Dim MysqlConn1 As New MySqlConnection("server=localhost; userid=root; password=cpe123; database=enrollment")
        Dim Cmd1 As New MySqlCommand(query1, MysqlConn1)
        Cmd1.Parameters.AddWithValue("@stud_id", stud_id)
        MysqlConn1.Open()
        Dim count As Integer = Convert.ToInt32(Cmd1.ExecuteScalar())
        MysqlConn1.Close()

        If count > 0 Then
            MessageBox.Show("Student ID already exists.")
            Return
        End If

        If Not IsNumeric(stud_id) Then
            MessageBox.Show("Student ID should be a numeric value.")
            Return
        End If

        Dim lastname As String = InputBox("Enter the last name:")
        If lastname = "" Then
            Return
        End If

        If IsNumeric(lastname) Then
            MessageBox.Show("Last name should be a string value.")
            Return
        End If

        Dim firstname As String = InputBox("Enter the first name:")
        If firstname = "" Then
            Return
        End If

        If IsNumeric(firstname) Then
            MessageBox.Show("First name should be a string value.")
            Return
        End If

        Dim middlename As String = InputBox("Enter the middle name:")
        If middlename = "" Then
            Return
        End If

        If IsNumeric(middlename) Then
            MessageBox.Show("Middle name should be a string value.")
            Return
        End If

        Dim course As String = InputBox("Enter the course:", "BS Computer Engineering")

        Dim year As String = InputBox("Enter the year level:")
        If year = "" Then
            Return
        End If

        If Not IsNumeric(year) OrElse (CInt(year) < 1 Or CInt(year) > 4) Then
            MessageBox.Show("Year level should be a numeric value between 1 and 4.")
            Return
        End If

        Dim section As String = InputBox("Enter the section:")
        If section = "" Then
            Return
        End If

        If IsNumeric(section) OrElse Not {"A", "B", "C"}.Contains(section.ToUpper()) Then
            MessageBox.Show("Section should be a string value with values A, B, or C.")
            Return
        End If

        Dim semester As String = InputBox("Enter the semester:")
        If semester = "" Then
            Return
        End If

        If semester.ToUpper() <> "1ST SEMESTER" AndAlso semester.ToUpper() <> "2ND SEMESTER" Then
            MessageBox.Show("Semester should be either 1st Semester or 2nd Semester.")
            Return
        End If

        ' Get the available subj_code based on the user's inputted year and semester
        Dim subjCodes As New List(Of String)()
        Dim query As String = "SELECT subj_code FROM subjects WHERE year = @year AND semester = @semester"
        Dim MysqlConn As New MySqlConnection("server=localhost; userid=root; password=cpe123; database=enrollment")
        Dim command As New MySqlCommand(query, MysqlConn)
        command.Parameters.AddWithValue("@year", year)
        command.Parameters.AddWithValue("@semester", semester)
        MysqlConn.Open()
        Dim reader As MySqlDataReader = command.ExecuteReader()
        While reader.Read()
            subjCodes.Add(reader("subj_code").ToString())
        End While
        MysqlConn.Close()

        ' Display the available subj_code to the user
        Dim subjCodeMsg As String = "Available subj_code: " & String.Join(", ", subjCodes)
        MessageBox.Show(subjCodeMsg, "Available Subjects", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' Ask the user to input the subj_code to enroll to
        Dim subjcode As String = InputBox("Available subj_code: " & String.Join(", ", subjCodes) & vbCrLf & "Enter the subj_code to enroll to:")
        If subjcode = "" Then
            Return
        End If
        ' Check if the inputted subj_code is present in the available subj_codes
        If Not subjCodes.Contains(subjcode) Then
            MessageBox.Show("The subj_code you entered is not available. Please enter a valid subj_code.", "Invalid Subject Code", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim username As String = InputBox("Enter the username:")
        If username = "" Then
            Return
        End If

        Dim password As String = InputBox("Enter the password:")
        If password = "" Then
            Return
        End If

        ' Check if username already exists in student_info table
        Dim queryCheckUsername As String = "SELECT COUNT(*) FROM student_info WHERE username = @username"
        Dim MysqlConnCheckUsername As New MySqlConnection("server=localhost; userid=root; password=cpe123; database=enrollment")
        Dim commandCheckUsername As New MySqlCommand(queryCheckUsername, MysqlConnCheckUsername)
        commandCheckUsername.Parameters.AddWithValue("@username", username)
        MysqlConnCheckUsername.Open()
        Dim countUsername As Integer = commandCheckUsername.ExecuteScalar()
        MysqlConnCheckUsername.Close()

        If countUsername > 0 Then
            MessageBox.Show("Username already exists. Please choose a different username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Check if both username and password already exist in student_info table
        Dim queryCheckLogin As String = "SELECT COUNT(*) FROM student_info WHERE username = @username AND password = @password"
        Dim MysqlConnCheckLogin As New MySqlConnection("server=localhost; userid=root; password=cpe123; database=enrollment")
        Dim commandCheckLogin As New MySqlCommand(queryCheckLogin, MysqlConnCheckLogin)
        commandCheckLogin.Parameters.AddWithValue("@username", username)
        commandCheckLogin.Parameters.AddWithValue("@password", password)
        MysqlConnCheckLogin.Open()
        Dim countLogin As Integer = commandCheckLogin.ExecuteScalar()
        MysqlConnCheckLogin.Close()

        If countLogin > 0 Then
            MessageBox.Show("A student with the same username and password already exists. Please choose a different username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Insert data into student_info table
        Dim reg_idno As String = stud_id
        Dim MysqlConn2 As New MySqlConnection("server=localhost; userid=root; password=cpe123; database=enrollment")
        Dim query2 As String = "INSERT INTO enrollment.student_info (reg_idno, lastname, firstname, middlename, username, password) VALUES (@reg_idno, @lastname, @firstname, @middlename, @username, @password)"
        Dim Cmd2 As New MySqlCommand(query2, MysqlConn2)
        Cmd2.Parameters.AddWithValue("@reg_idno", reg_idno)
        Cmd2.Parameters.AddWithValue("@lastname", lastname)
        Cmd2.Parameters.AddWithValue("@firstname", firstname)
        Cmd2.Parameters.AddWithValue("@middlename", middlename)
        Cmd2.Parameters.AddWithValue("@username", username)
        Cmd2.Parameters.AddWithValue("@password", password)
        MysqlConn2.Open()
        Cmd2.ExecuteNonQuery()
        MysqlConn2.Close()

        Dim Cmd As New MySqlCommand()
        Cmd.Connection = MysqlConn
        Cmd.CommandText = "INSERT INTO enrollment.enrolled_stud (subj_code, stud_id, lastname, firstname, middlename, course, year, section, semester) VALUES (@subj_code, @stud_id, @lastname, @firstname, @middlename, @course, @year, @section, @semester)"
        Cmd.Parameters.AddWithValue("@subj_code", subjcode)
        Cmd.Parameters.AddWithValue("@stud_id", stud_id)
        Cmd.Parameters.AddWithValue("@lastname", lastname)
        Cmd.Parameters.AddWithValue("@firstname", firstname)
        Cmd.Parameters.AddWithValue("@middlename", middlename)
        Cmd.Parameters.AddWithValue("@course", course)
        Cmd.Parameters.AddWithValue("@year", year)
        Cmd.Parameters.AddWithValue("@section", section)
        Cmd.Parameters.AddWithValue("@semester", semester)
        MysqlConn.Open()
        Cmd.ExecuteNonQuery()
        MysqlConn.Close()
        LoadData()
    End Sub

    Private Sub BtnDrop_Click(sender As Object, e As EventArgs) Handles BtnDrop.Click
        If Std_Table.SelectedRows.Count > 0 Then
            Dim stud_id As String = Std_Table.SelectedRows(0).Cells("stud_id").Value.ToString()
            Dim MysqlConn As New MySqlConnection("server=localhost; userid=root; password=cpe123; database=enrollment")
            Dim Cmd As New MySqlCommand()
            Cmd.Connection = MysqlConn
            Cmd.CommandText = "DELETE FROM enrollment.enrolled_stud WHERE stud_id=@stud_id"
            Cmd.Parameters.AddWithValue("@stud_id", stud_id)
            MysqlConn.Open()
            Cmd.ExecuteNonQuery()
            MysqlConn.Close()
            LoadData()
        Else
            MessageBox.Show("Please select a row to delete.")
        End If
    End Sub
End Class
