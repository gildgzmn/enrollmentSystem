Imports MySql.Data.MySqlClient

Public Class StdSubjects

    Private Sub StdSubjects_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connStr As String = "server=localhost; userid=root; password=cpe123; database=enrollment"
        Dim conn As MySqlConnection = New MySqlConnection(connStr)

        Try
            ' Open the connection
            conn.Open()

            ' Select the enrolled subjects of the student from enrolled_stud table
            Dim cmd As New MySqlCommand("SELECT subj_code, year, section, semester FROM enrolled_stud WHERE stud_id = @stud_id", conn)

            cmd.Parameters.AddWithValue("@stud_id", MainForm.id)

            ' Create a new DataTable to store the subjects and their details
            Dim enrolledSubjectsTable As New DataTable()

            ' Add the columns to the DataTable
            enrolledSubjectsTable.Columns.Add("Subject Code", GetType(String))
            enrolledSubjectsTable.Columns.Add("Description", GetType(String))
            enrolledSubjectsTable.Columns.Add("Lecture Units", GetType(Integer))
            enrolledSubjectsTable.Columns.Add("Laboratory Units", GetType(Integer))
            enrolledSubjectsTable.Columns.Add("Prerequisite", GetType(String))
            enrolledSubjectsTable.Columns.Add("Year Level", GetType(Integer))
            enrolledSubjectsTable.Columns.Add("Section", GetType(String))
            enrolledSubjectsTable.Columns.Add("Semester", GetType(String)) ' Add the Semester column
            enrolledSubjectsTable.Columns.Add("Schedule", GetType(String))

            ' Create a new DataTable to store the subject schedules
            Dim subjectSchedulesTable As New DataTable()

            ' Add the columns to the DataTable
            subjectSchedulesTable.Columns.Add("Subject Code", GetType(String))
            subjectSchedulesTable.Columns.Add("Schedule", GetType(String))
            subjectSchedulesTable.Columns.Add("Year", GetType(Integer))
            subjectSchedulesTable.Columns.Add("Semester", GetType(String))
            subjectSchedulesTable.Columns.Add("Section", GetType(String))

            Using enrolledSubjectsReader As MySqlDataReader = cmd.ExecuteReader()
                While enrolledSubjectsReader.Read()
                    ' Get the subject codes and year level and section
                    Dim subjCodes As String() = enrolledSubjectsReader.GetString("subj_code").Split(","c)
                    Dim yearLevel As Integer = enrolledSubjectsReader.GetInt32("year")
                    Dim section As String = enrolledSubjectsReader.GetString("section")
                    Dim semester As String = enrolledSubjectsReader.GetString("semester") ' Get the semester value from enrolledSubjectsReader

                    For Each subjCode As String In subjCodes
                        ' Query the subjects table to get the subject details using a separate connection
                        Using conn2 As MySqlConnection = New MySqlConnection(connStr)
                            conn2.Open()

                            Dim subjectCmd As New MySqlCommand("SELECT subj_code, Description, lec, lab, prerequisite, semester FROM enrollment.subjects WHERE subj_code = @subj_code", conn2)
                            subjectCmd.Parameters.Add("@subj_code", MySqlDbType.VarChar).Value = subjCode.Trim()

                            Using subjectReader As MySqlDataReader = subjectCmd.ExecuteReader()
                                ' Add the subject details to the DataTable
                                While subjectReader.Read()
                                    Dim newRow As DataRow = enrolledSubjectsTable.NewRow()
                                    newRow("Subject Code") = subjectReader.GetString("subj_code")
                                    newRow("Description") = subjectReader.GetString("Description")
                                    newRow("Lecture Units") = subjectReader.GetInt32("lec")
                                    newRow("Laboratory Units") = subjectReader.GetInt32("lab")
                                    newRow("Prerequisite") = subjectReader.GetString("prerequisite")
                                    newRow("Year Level") = yearLevel
                                    newRow("Section") = section
                                    newRow("Semester") = enrolledSubjectsReader.GetString("semester") ' add the semester to the enrolledSubjectsTable
                                    enrolledSubjectsTable.Rows.Add(newRow)
                                End While
                            End Using

                            ' Query the sched_stud table to get the subject schedules
                            Dim scheduleCmd As New MySqlCommand("SELECT schedule FROM sched_stud WHERE year = @year AND semester = @semester AND section = @section AND subj_code = @subj_code", conn2)
                            scheduleCmd.Parameters.AddWithValue("@year", yearLevel)
                            scheduleCmd.Parameters.AddWithValue("@semester", enrolledSubjectsReader.GetString("semester"))
                            scheduleCmd.Parameters.AddWithValue("@section", section)
                            scheduleCmd.Parameters.AddWithValue("@subj_code", subjCode.Trim())

                            Using scheduleReader As MySqlDataReader = scheduleCmd.ExecuteReader()
                                ' Add the subject schedules to the DataTable
                                While scheduleReader.Read()
                                    ' Add the schedule to the "Schedule" column in enrolledSubjectsTable
                                    enrolledSubjectsTable.Rows(enrolledSubjectsTable.Rows.Count - 1)("Schedule") &= scheduleReader.GetString("schedule") & ", "
                                End While
                            End Using
                        End Using
                    Next

                End While

            End Using
            Enr_Subj.DataSource = enrolledSubjectsTable

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            ' Close the connection
            conn.Close()
        End Try
    End Sub
End Class
