Imports MySql.Data.MySqlClient
Public Class Subjects
    Private Sub Subjects_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim query As String = "SELECT subj_code, Description, Lec, Lab, Prerequisite, Year, Semester FROM enrollment.subjects"
        Dim MysqlConn As New MySqlConnection("server=localhost; userid=root; password=cpe123; database=enrollment")
        Dim table As New DataTable()
        Dim Adapter As New MySqlDataAdapter(query, MysqlConn)
        Adapter.Fill(table)
        Subj_tbl.ClearSelection()
        Subj_tbl.DataSource = table
    End Sub
End Class