
Imports MySql.Data.MySqlClient

Public Class Faculties
    Private Sub Faculties_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub
    Private Sub LoadData()
        Dim query As String = "SELECT fac_id, lastname, firstname, department, subjectload, username, password FROM enrollment.faculty_info"
        Dim MysqlConn As New MySqlConnection("server=localhost; userid=root; password=cpe123; database=enrollment")
        Dim table As New DataTable()
        Dim Adapter As New MySqlDataAdapter(query, MysqlConn)
        Adapter.Fill(table)
        Fac_tbl.ClearSelection()
        Fac_tbl.DataSource = table
    End Sub


    Private Sub BtnEnr_Click(sender As Object, e As EventArgs) Handles BtnEnr.Click
        Dim fac_id As String = InputBox("Enter the Faculty ID:")
        If fac_id = "" Then
            Return
        End If

        If Not IsNumeric(fac_id) Then
            MessageBox.Show("Faculty ID should be a numeric value.")
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

        Dim department As String = InputBox("Enter department:")
        If department = "" Then
            Return
        End If

        Dim subjectload As String = InputBox("Enter subject load:")
        If subjectload = "" Then
            Return
        End If

        Dim username As String = InputBox("Enter username:")
        If username = "" Then
            Return
        End If

        Dim password As String = InputBox("Enter password:")
        If password = "" Then
            Return
        End If

        Dim MysqlConn As New MySqlConnection("server=localhost; userid=root; password=cpe123; database=enrollment")
        Dim Cmd As New MySqlCommand()
        Cmd.Connection = MysqlConn
        Cmd.CommandText = "INSERT INTO enrollment.faculty_info (fac_id, lastname, firstname, department, subjectload, username, password) VALUES (@fac_id, @lastname, @firstname, @department, @subjectload, @username, @password)"
        Cmd.Parameters.AddWithValue("@fac_id", fac_id)
        Cmd.Parameters.AddWithValue("@lastname", lastname)
        Cmd.Parameters.AddWithValue("@firstname", firstname)
        Cmd.Parameters.AddWithValue("@department", department)
        Cmd.Parameters.AddWithValue("@subjectload", subjectload)
        Cmd.Parameters.AddWithValue("@username", username)
        Cmd.Parameters.AddWithValue("@password", password)
        MysqlConn.Open()
        Cmd.ExecuteNonQuery()
        MysqlConn.Close()
        LoadData()
    End Sub

    Private Sub BtnUpd_Click(sender As Object, e As EventArgs) Handles BtnUpd.Click

    End Sub

    Private Sub BtnDrop_Click(sender As Object, e As EventArgs) Handles BtnDrop.Click

    End Sub
End Class