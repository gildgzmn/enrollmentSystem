
Imports MySql.Data.MySqlClient
Public Class Curriculum
    Dim MysqlConn As MySqlConnection
    Public Function GetSubjectsForFirstYearFirstSemester() As DataTable
        Dim dt As New DataTable()
        Dim connString As String = "Server=localhost;Database=enrollment;Uid=root;Pwd=cpe123;"
        Dim query As String = "SELECT subj_code, Description, Lec, Lab, Prerequisite, Year, Semester 
    FROM subjects 
    WHERE Year = 1 AND Semester = 1
    ORDER BY Year, Semester"
        Using conn As New MySqlConnection(connString)
            Using cmd As New MySqlCommand(query, conn)
                conn.Open()
                Using da As New MySqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using
        End Using
        Return dt
    End Function

    Public Function GetSubjectsForFirstYearSecondSemester() As DataTable
        Dim dt As New DataTable()
        Dim connString As String = "Server=localhost;Database=enrollment;Uid=root;Pwd=cpe123;"
        Dim query As String = "SELECT subj_code, Description, Lec, Lab, Prerequisite, Year, Semester 
    FROM subjects 
    WHERE Year = 1 AND Semester = 2
    ORDER BY Year, Semester"
        Using conn As New MySqlConnection(connString)
            Using cmd As New MySqlCommand(query, conn)
                conn.Open()
                Using da As New MySqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using
        End Using
        Return dt
    End Function

    Public Function GetSubjectsForSecondYearFirstSemester() As DataTable
        Dim dt As New DataTable()
        Dim connString As String = "Server=localhost;Database=enrollment;Uid=root;Pwd=cpe123;"
        Dim query As String = "SELECT subj_code, Description, Lec, Lab, Prerequisite, Year, Semester 
    FROM subjects 
    WHERE Year = 2 AND Semester = 1
    ORDER BY Year, Semester"
        Using conn As New MySqlConnection(connString)
            Using cmd As New MySqlCommand(query, conn)
                conn.Open()
                Using da As New MySqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using
        End Using
        Return dt
    End Function

    Public Function GetSubjectsForSecondYearSecondSemester() As DataTable
        Dim dt As New DataTable()
        Dim connString As String = "Server=localhost;Database=enrollment;Uid=root;Pwd=cpe123;"
        Dim query As String = "SELECT subj_code, Description, Lec, Lab, Prerequisite, Year, Semester 
    FROM subjects 
    WHERE Year = 2 AND Semester = 2
    ORDER BY Year, Semester"
        Using conn As New MySqlConnection(connString)
            Using cmd As New MySqlCommand(query, conn)
                conn.Open()
                Using da As New MySqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using
        End Using
        Return dt
    End Function

    Public Function GetSubjectsForThirdYearFirstSemester() As DataTable
        Dim dt As New DataTable()
        Dim connString As String = "Server=localhost;Database=enrollment;Uid=root;Pwd=cpe123;"
        Dim query As String = "SELECT subj_code, Description, Lec, Lab, Prerequisite, Year, Semester 
    FROM subjects 
    WHERE Year = 3 AND Semester = 1
    ORDER BY Year, Semester"
        Using conn As New MySqlConnection(connString)
            Using cmd As New MySqlCommand(query, conn)
                conn.Open()
                Using da As New MySqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using
        End Using
        Return dt
    End Function

    Public Function GetSubjectsForThirdYearSecondSemester() As DataTable
        Dim dt As New DataTable()
        Dim connString As String = "Server=localhost;Database=enrollment;Uid=root;Pwd=cpe123;"
        Dim query As String = "SELECT subj_code, Description, Lec, Lab, Prerequisite, Year, Semester 
    FROM subjects 
    WHERE Year = 3 AND Semester = 2
    ORDER BY Year, Semester"
        Using conn As New MySqlConnection(connString)
            Using cmd As New MySqlCommand(query, conn)
                conn.Open()
                Using da As New MySqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using
        End Using
        Return dt
    End Function

    Public Function GetSubjectsForFourthYearFirstSemester() As DataTable
        Dim dt As New DataTable()
        Dim connString As String = "Server=localhost;Database=enrollment;Uid=root;Pwd=cpe123;"
        Dim query As String = "SELECT subj_code, Description, Lec, Lab, Prerequisite, Year, Semester 
    FROM subjects 
    WHERE Year = 4 AND Semester = 1
    ORDER BY Year, Semester"
        Using conn As New MySqlConnection(connString)
            Using cmd As New MySqlCommand(query, conn)
                conn.Open()
                Using da As New MySqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using
        End Using
        Return dt
    End Function

    Public Function GetSubjectsForFourthYearSecondSemester() As DataTable
        Dim dt As New DataTable()
        Dim connString As String = "Server=localhost;Database=enrollment;Uid=root;Pwd=cpe123;"
        Dim query As String = "SELECT subj_code, Description, Lec, Lab, Prerequisite, Year, Semester 
    FROM subjects 
    WHERE Year = 4 AND Semester = 2
    ORDER BY Year, Semester"
        Using conn As New MySqlConnection(connString)
            Using cmd As New MySqlCommand(query, conn)
                conn.Open()
                Using da As New MySqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using
        End Using
        Return dt
    End Function



    Private Sub Curriculum_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt1 As DataTable = GetSubjectsForFirstYearFirstSemester()
        Subj_DataGrid11.DataSource = dt1

        Dim dt2 As DataTable = GetSubjectsForFirstYearSecondSemester()
        Subj_DataGrid12.DataSource = dt2

        Dim dt3 As DataTable = GetSubjectsForSecondYearFirstSemester()
        Subj_DataGrid21.DataSource = dt3

        Dim dt4 As DataTable = GetSubjectsForSecondYearSecondSemester()
        Subj_DataGrid22.DataSource = dt4

        Dim dt5 As DataTable = GetSubjectsForThirdYearFirstSemester()
        Subj_DataGrid31.DataSource = dt5

        Dim dt6 As DataTable = GetSubjectsForThirdYearSecondSemester()
        Subj_DataGrid32.DataSource = dt6

        Dim dt7 As DataTable = GetSubjectsForFourthYearFirstSemester()
        Subj_DataGrid41.DataSource = dt7

        Dim dt8 As DataTable = GetSubjectsForFourthYearSecondSemester()
        Subj_DataGrid42.DataSource = dt8
    End Sub
End Class