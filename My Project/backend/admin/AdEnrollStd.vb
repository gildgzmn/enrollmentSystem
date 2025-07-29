Imports MySql.Data.MySqlClient


Public Class AdEnrollStd
    Private Sub RefreshData()
        Dim query As String = "SELECT reg_idno, subj_code, course, year, section, semester, payment FROM enrollment.student_enrollees"
        Dim MysqlConn As New MySqlConnection("server=localhost; userid=root; password=cpe123; database=enrollment")
        Dim table As New DataTable()
        Dim Adapter As New MySqlDataAdapter(query, MysqlConn)
        Adapter.Fill(table)
        Std_Table.ClearSelection()
        Std_Table.DataSource = table
    End Sub

    Private Sub AdEnrollStd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim query As String = "SELECT reg_idno, subj_code, description, course, year, section, semester, payment FROM enrollment.student_enrollees"
        Dim MysqlConn As New MySqlConnection("server=localhost; userid=root; password=cpe123; database=enrollment")
        Dim table As New DataTable()
        Dim Adapter As New MySqlDataAdapter(query, MysqlConn)
        RefreshData()
        Adapter.Fill(table)
        Std_Table.ClearSelection()
        Std_Table.DataSource = table
    End Sub

    Private Sub Std_Table_SelectionChanged(sender As Object, e As EventArgs)
        If Std_Table.SelectedRows.Count > 0 Then
            BtnEnr.Enabled = True
            BtnDrop.Enabled = True
        Else
            BtnEnr.Enabled = False
            BtnDrop.Enabled = False
        End If
    End Sub

    Private Sub BtnEnr_Click(sender As Object, e As EventArgs) Handles BtnEnr.Click
        If Std_Table.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = Std_Table.SelectedRows(0)
            Dim reg_idno As Integer = selectedRow.Cells("reg_idno").Value
            Dim selectQuery As String = "SELECT subj_code FROM enrollment.student_enrollees WHERE reg_idno = @reg_idno"
            Dim deleteQuery As String = "DELETE FROM enrollment.student_enrollees WHERE reg_idno = @reg_idno"
            Dim insertQuery As String = "INSERT INTO enrollment.enrolled_stud (stud_id, lastname, firstname, middlename, course, year, section, semester, subj_code) VALUES (@stud_id, @lastname, @firstname, @middlename, @course, @year, @section, @semester, @subj_code)"
            Dim insertGradeQuery As String = "INSERT INTO enrollment.student_grades (stud_id, subj_code, grades, year, semester, section) VALUES (@stud_id, @subj_code, @grades, @year, @semester, @section)"

            Dim selectSubjectsQuery As String = "SELECT Description, Lec, Lab FROM enrollment.subjects"
            Dim MysqlConn As New MySqlConnection("server=localhost; userid=root; password=cpe123; database=enrollment")

            MysqlConn.Open()
            Dim selectCmd As New MySqlCommand(selectQuery, MysqlConn)
            selectCmd.Parameters.AddWithValue("@reg_idno", reg_idno)
            Dim reader As MySqlDataReader = selectCmd.ExecuteReader()

            Dim subjCodes As New List(Of String)
            While reader.Read()
                subjCodes.Add(reader.GetString("subj_code"))
            End While
            reader.Close()

            If subjCodes.Count > 0 Then
                Dim deleteCmd As New MySqlCommand(deleteQuery, MysqlConn)
                deleteCmd.Parameters.AddWithValue("@reg_idno", reg_idno)
                deleteCmd.ExecuteNonQuery()

                Dim selectInfoQuery As String = "SELECT firstname, lastname, middlename FROM enrollment.student_info WHERE reg_idno = @reg_idno"
                Dim selectInfoCmd As New MySqlCommand(selectInfoQuery, MysqlConn)
                selectInfoCmd.Parameters.AddWithValue("@reg_idno", reg_idno)
                Dim infoReader As MySqlDataReader = selectInfoCmd.ExecuteReader()

                If infoReader.Read() Then
                    Dim insertCmd As New MySqlCommand(insertQuery, MysqlConn)
                    insertCmd.Parameters.AddWithValue("@stud_id", reg_idno)
                    insertCmd.Parameters.AddWithValue("@lastname", infoReader.GetString("lastname"))
                    insertCmd.Parameters.AddWithValue("@firstname", infoReader.GetString("firstname"))
                    insertCmd.Parameters.AddWithValue("@middlename", infoReader.GetString("middlename"))
                    insertCmd.Parameters.AddWithValue("@course", selectedRow.Cells("course").Value.ToString())
                    insertCmd.Parameters.AddWithValue("@year", selectedRow.Cells("year").Value.ToString())
                    insertCmd.Parameters.AddWithValue("@section", selectedRow.Cells("section").Value.ToString())
                    insertCmd.Parameters.AddWithValue("@semester", selectedRow.Cells("semester").Value.ToString())
                    insertCmd.Parameters.AddWithValue("@subj_code", String.Join(",", subjCodes))
                    infoReader.Close() ' Close the infoReader before executing the insert
                    insertCmd.ExecuteNonQuery()

                    ' Insert into student_grades table
                    For Each subjCode As String In subjCodes
                        Dim insertGradeCmd As New MySqlCommand(insertGradeQuery, MysqlConn)
                        insertGradeCmd.Parameters.AddWithValue("@stud_id", reg_idno)
                        insertGradeCmd.Parameters.AddWithValue("@subj_code", subjCode)
                        insertGradeCmd.Parameters.AddWithValue("@grades", 0) ' Set default grade to 0
                        insertGradeCmd.Parameters.AddWithValue("@year", selectedRow.Cells("year").Value.ToString())
                        insertGradeCmd.Parameters.AddWithValue("@semester", selectedRow.Cells("semester").Value.ToString())
                        insertGradeCmd.Parameters.AddWithValue("@section", selectedRow.Cells("section").Value.ToString())
                        insertGradeCmd.ExecuteNonQuery()
                    Next
                    MessageBox.Show("Student Enrolled Successfully.", "Success")
                End If
                infoReader.Close() ' Close the infoReader
            End If
            MysqlConn.Close()
        Else
            MessageBox.Show("Please select a student to enroll.", "Error")
        End If
    End Sub
    Private Sub BtnDrop_Click(sender As Object, e As EventArgs) Handles BtnDrop.Click
        If Std_Table.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = Std_Table.SelectedRows(0)
            Dim reg_idno As Integer = selectedRow.Cells("reg_idno").Value

            Dim deleteQuery As String = "DELETE FROM enrollment.student_enrollees WHERE reg_idno = @reg_idno"
            Dim deleteInfoQuery As String = "DELETE FROM enrollment.student_info WHERE reg_idno = @reg_idno"
            Dim MysqlConn As New MySqlConnection("server=localhost; userid=root; password=cpe123; database=enrollment")

            MysqlConn.Open()
            Dim deleteCmd As New MySqlCommand(deleteQuery, MysqlConn)
            deleteCmd.Parameters.AddWithValue("@reg_idno", reg_idno)
            deleteCmd.ExecuteNonQuery()

            Dim deleteInfoCmd As New MySqlCommand(deleteInfoQuery, MysqlConn)
            deleteInfoCmd.Parameters.AddWithValue("@reg_idno", reg_idno)
            deleteInfoCmd.ExecuteNonQuery()

            MysqlConn.Close()
            MsgBox("Student information has been deleted!", MsgBoxStyle.OkOnly)
            RefreshData()
        End If
    End Sub

    Private Sub BtnRef_Click(sender As Object, e As EventArgs) Handles BtnRef.Click
        RefreshData()
    End Sub

End Class