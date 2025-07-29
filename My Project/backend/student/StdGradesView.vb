Imports MySql.Data.MySqlClient

Public Class StdGradesView
    Private Sub StdGradesView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connStr As String = "server=localhost; userid=root; password=cpe123; database=enrollment"
        Dim conn As MySqlConnection = New MySqlConnection(connStr)
        Try
            conn.Open()
            ' Retrieve grades from student_grades table
            Dim cmd As New MySqlCommand("SELECT stud_id, subj_code, CAST(year AS CHAR) AS year, section, semester, grades FROM student_grades WHERE stud_id = @stud_id", conn)
            cmd.Parameters.AddWithValue("@stud_id", MainForm.id)
            Dim gradesTable As New DataTable()
            gradesTable.Columns.Add("Subject Code", GetType(String))
            gradesTable.Columns.Add("Description", GetType(String))
            gradesTable.Columns.Add("Units", GetType(Integer))
            gradesTable.Columns.Add("Year", GetType(String))
            gradesTable.Columns.Add("Semester", GetType(String))
            gradesTable.Columns.Add("Final Grade", GetType(String))
            gradesTable.Columns.Add("Remarks", GetType(String))

            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            While reader.Read()
                ' Retrieve subject description and units from sched_stud table
                Dim subjectCode As String = reader.GetString("subj_code")
                Dim selectSchedConn As MySqlConnection = New MySqlConnection(connStr)
                selectSchedConn.Open()
                Dim selectSchedQuery As String = "SELECT Description, Units FROM sched_stud WHERE subj_code = @subj_code AND year = @year AND section = @section AND semester = @semester"
                Dim selectSchedCmd As New MySqlCommand(selectSchedQuery, selectSchedConn)
                selectSchedCmd.Parameters.AddWithValue("@subj_code", subjectCode)
                selectSchedCmd.Parameters.AddWithValue("@year", reader.GetString("year"))
                selectSchedCmd.Parameters.AddWithValue("@section", reader.GetString("section"))
                selectSchedCmd.Parameters.AddWithValue("@semester", reader.GetString("semester"))
                Dim schedReader As MySqlDataReader = selectSchedCmd.ExecuteReader()

                Dim subjectDesc As String = ""
                Dim units As Integer = 0
                If schedReader.Read() Then
                    subjectDesc = schedReader.GetString("Description")
                    units = schedReader.GetInt32("Units")
                End If
                schedReader.Close()
                selectSchedConn.Close()

                Dim yearSection As String = reader.GetString("year") & reader.GetString("section")
                Dim finalGrade As String = If(reader.GetInt32("grades") = 0, "", reader.GetString("grades"))

                gradesTable.Rows.Add(reader.GetString("subj_code"), subjectDesc, units, "CPE-" & yearSection, reader.GetString("semester"), finalGrade, "")
            End While
            reader.Close()

            GradesTbl.DataSource = gradesTable
        Catch ex As Exception
            MessageBox.Show("An error occurred while retrieving grades: " + ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
End Class