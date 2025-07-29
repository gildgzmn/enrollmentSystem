
Imports MySql.Data.MySqlClient


Public Class StdEnroll
    Dim MysqlConn As New MySqlConnection("server=localhost; userid=root; password=cpe123; database=enrollment")
    Dim paymentAmount As Decimal = 0
    Dim clickedRows As New HashSet(Of DataGridViewRow)()

    Private Sub DisplaySubjects()
        Enr_subj.DataSource = Nothing
        clickedRows.Clear()

        Dim selectedOption As String = ""
        Dim selectedsem As String = ""

        If CbxYear.SelectedItem IsNot Nothing Then
            selectedOption = CbxYear.SelectedItem.ToString()
        End If

        If CbxSem.SelectedItem IsNot Nothing Then
            selectedsem = CbxSem.SelectedItem.ToString()
        End If

        Dim subjPaymentCOdes As String = ""
        If selectedOption = "1" And selectedsem = "1st Semester" Then
            Req.Visible = True
            Dim subjCodes As String = "'MMW 101', 'UTS 101', 'PCM 101', 'COE 102', 'COE 103', 'COE 103L', 'CPE 102L', 'CPE 103', 'PE 10', 'NSTP 10'"
            Dim subj As String = "SELECT * FROM enrollment.subjects WHERE subj_code IN (" & subjCodes & ")"
            Dim table1 As New DataTable()
            Dim Adapter1 As New MySqlDataAdapter(subj, MysqlConn)
            Adapter1.Fill(table1)
            Enr_subj.DataSource = table1

        ElseIf selectedOption = "1" And selectedsem = "2nd Semester" Then
            Req.Visible = False
            Dim subjCodes As String = "'RPH 101 ', 'AAP 101', 'STS 101', 'COE 104', 'COE 105', 'COE 105L', 'CPE 104L', 'PE 11', 'NSTP 11'"
            Dim subj As String = "SELECT * FROM enrollment.subjects WHERE subj_code IN (" & subjCodes & ")"
            Dim table1 As New DataTable()
            Dim Adapter1 As New MySqlDataAdapter(subj, MysqlConn)
            Adapter1.Fill(table1)
            Enr_subj.DataSource = table1
        ElseIf selectedOption = "2" And selectedsem = "1st Semester" Then
            Req.Visible = False
            Dim subjCodes As String = "'TCW 101', 'COE 201', 'COE 202', 'CPE 201', 'CPE 202L', 'CPE 203', 'CPE 203L', 'CPE 204L', 'PE 12'"
            Dim subj As String = "SELECT * FROM enrollment.subjects WHERE subj_code IN (" & subjCodes & ")"
            Dim table1 As New DataTable()
            Dim Adapter1 As New MySqlDataAdapter(subj, MysqlConn)
            Adapter1.Fill(table1)
            Enr_subj.DataSource = table1
        ElseIf selectedOption = "2" And selectedsem = "2nd Semester" Then
            Req.Visible = False
            Dim subjCodes As String = "'ETH 101', 'CPE 205', 'CPE 206L', 'CPE 207', 'CPE 207L', 'CPE 208', 'CPE 209', 'CPE 209L', 'PE 13'"
            Dim subj As String = "SELECT * FROM enrollment.subjects WHERE subj_code IN (" & subjCodes & ")"
            Dim table1 As New DataTable()
            Dim Adapter1 As New MySqlDataAdapter(subj, MysqlConn)
            Adapter1.Fill(table1)
            Enr_subj.DataSource = table1
        ElseIf selectedOption = "3" And selectedsem = "1st Semester" Then
            Req.Visible = False
            Dim subjCodes As String = "'RLW 101', 'CPE 301', 'CPE 301L', 'CPE 302', 'CPE 303', 'CPE 304', 'CPE 304L', 'CPE 305', 'CPE 306', 'AAH 101d'"
            Dim subj As String = "SELECT * FROM enrollment.subjects WHERE subj_code IN (" & subjCodes & ")"
            Dim table1 As New DataTable()
            Dim Adapter1 As New MySqlDataAdapter(subj, MysqlConn)
            Adapter1.Fill(table1)
            Enr_subj.DataSource = table1
        ElseIf selectedOption = "3" And selectedsem = "2nd Semester" Then
            Req.Visible = False
            Dim subjCodes As String = "'CPE 307', 'CPE 308', 'CPE 308L', 'CPE 309', 'CPE 309L', 'CPE 310', 'CPE 311L', 'CPE 312', 'CPE 313L', 'CPE 314' , 'MST 101d', 'SSP 101d', 'CPE 315'"
            Dim subj As String = "SELECT * FROM enrollment.subjects WHERE subj_code IN (" & subjCodes & ")"
            Dim table1 As New DataTable()
            Dim Adapter1 As New MySqlDataAdapter(subj, MysqlConn)
            Adapter1.Fill(table1)
            Enr_subj.DataSource = table1
        ElseIf selectedOption = "4" And selectedsem = "1st Semester" Then
            Req.Visible = False
            Dim subjCodes As String = "'CPE 401', 'CPE 401L', 'CPE 402', 'CPE 402L', 'CPE 403', 'CPE 404D', 'CPE 405', 'CPE 405L'"
            Dim subj As String = "SELECT * FROM enrollment.subjects WHERE subj_code IN (" & subjCodes & ")"
            Dim table1 As New DataTable()
            Dim Adapter1 As New MySqlDataAdapter(subj, MysqlConn)
            Adapter1.Fill(table1)
            Enr_subj.DataSource = table1
        ElseIf selectedOption = "4" And selectedsem = "2nd Semester" Then
            Req.Visible = False
            Dim subjCodes As String = "'CPE 406D', 'CPE 407D', 'CPE 408', 'CPE 409', 'CPE 410', 'CPE 411', 'CPE 411L'"
            Dim subj As String = "SELECT * FROM enrollment.subjects WHERE subj_code IN (" & subjCodes & ")"
            Dim table1 As New DataTable()
            Dim Adapter1 As New MySqlDataAdapter(subj, MysqlConn)
            Adapter1.Fill(table1)
            Enr_subj.DataSource = table1

        End If
    End Sub
    Private Sub StdEnroll_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Req.Visible = False
        DisplaySubjects()
        CheckInputs()

    End Sub
    Private Sub CbxYear_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbxYear.SelectedIndexChanged
        DisplaySubjects()
        CheckInputs()
        ResetPaymentAmount()
        Payment.Text = ""
    End Sub
    Private Sub CbxSem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbxSem.SelectedIndexChanged
        DisplaySubjects()
        CheckInputs()
        ResetPaymentAmount()
        Payment.Text = ""
    End Sub
    Private Sub ResetPaymentAmount()
        TbxFee.Text = ""
        Me.paymentAmount = 0
        clickedRows.Clear()
    End Sub
    Private Sub Enr_subj_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Enr_subj.CellClick
        Dim selectedsem As String = CbxSem.SelectedItem.ToString()
        Dim selectedyear As String = CbxYear.SelectedItem.ToString()
        'Dim selectedsec As String = CbxSec.SelectedItem.ToString()

        Dim selectedRow As DataGridViewRow = Enr_subj.Rows(e.RowIndex)
        If Not clickedRows.Contains(selectedRow) Then
            clickedRows.Add(selectedRow)
            Dim paymentCode As String = selectedRow.Cells("subj_code").Value.ToString()
            Dim paymentAmount As Decimal = GetPaymentAmount(paymentCode)
            TbxFee.Text = String.Format("{0:N2}", Me.paymentAmount + paymentAmount)
            Me.paymentAmount += paymentAmount
        End If
    End Sub
    Private Sub Payment_TextChanged(sender As Object, e As EventArgs) Handles Payment.TextChanged
        If Payment.Text <> TbxFee.Text Then
            BtnEnr.Enabled = False
        Else
            BtnEnr.Enabled = True
        End If
    End Sub

    Private Sub TbxFee_TextChanged(sender As Object, e As EventArgs) Handles TbxFee.TextChanged
        CheckInputs()
        If Payment.Text <> TbxFee.Text Then
            BtnEnr.Enabled = False
        Else
            BtnEnr.Enabled = True
        End If
    End Sub
    Private Function GetPaymentAmount(paymentCode As String) As Decimal
        Select Case paymentCode
            Case "MMW 101", "UTS 101", "PCM 101", "TCW 101", "RLW 101", "AAH 101d", "MST 101d", "SSP 101d", "ETH 101", "AAP 101"
                Return 500.0
            Case "COE 102", "COE 103", "CPE 103", "COE 104", "COE 105", "COE 202", "STS 101", "CPE 201", "COE 201", "CPE 202", "CPE 203", "CPE 205", "CPE 301", "CPE 302", "CPE 303", "CPE 305", "CPE 306", "CPE 309", "CPE 307", "CPE 304", "CPE 401", "CPE 408", "CPE 409", "CPE 411", "CPE 402", "CPE 405", "CPE 403"
                Return 800.0
            Case "COE 103L", "CPE 104L", "CPE 102L", "COE 105L", "CPE 201L", "CPE 202L", "CPE 203L", "CPE 204L", "CPE 206L", "CPE 207L", "CPE 209L", "CPE 301L", "CPE 304L", "CPE 308L", "CPE 309L", "CPE 311L", "CPE 313L", "CPE 402L", "CPE 411L", "CPE 408", "CPE 401L", "CPE 405L"
                Return 1000.0
            Case "PE 10", "PE 11", "PE 12", "PE 13"
                Return 400.0
            Case "NSTP 10", "NSTP 11", "CPE 315"
                Return 500.0
            Case "CPE 207", "CPE 208", "CPE 308", "CPE 209", "CPE 310", "CPE 312", "CPE 314", "CPE 406D", "CPE 407D", "CPE 406D", "CPE 410", "CPE 404D"
                Return 1000.0
            Case Else
                ' If the subjCode is not recognized, throw an exception
                MsgBox("Subject Code is not recognized!")
        End Select
        Return 0
    End Function
    Private Sub CheckInputs()
        ' Disable and hide the button if any of the inputs are empty
        If String.IsNullOrEmpty(TbxFee.Text) Or String.IsNullOrEmpty(CbxYear.Text) Or String.IsNullOrEmpty(CbxSem.Text) Or String.IsNullOrEmpty(CbxSec.Text) Then
            BtnEnr.Enabled = False
            BtnEnr.Visible = False
        Else
            BtnEnr.Enabled = True
            BtnEnr.Visible = True
        End If
    End Sub
    Private Sub ResetDisplayedData()
        ' Reset the displayed data in Enr_subj
        Enr_subj.DataSource = Nothing
        Enr_subj.Rows.Clear()
        Enr_subj.Refresh()
    End Sub


    Private Sub BtnEnr_Click(sender As Object, e As EventArgs) Handles BtnEnr.Click
        MysqlConn.Open()
        Dim transaction As MySqlTransaction = MysqlConn.BeginTransaction()
        Try
            ' Check if the student has completed the prerequisite year and semester
            Dim prereqYear As Integer = CbxYear.SelectedIndex - 1 ' index of previous year
            Dim prereqSemester As String = "" ' previous semester
            If CbxSem.SelectedIndex = 0 Then ' if current semester is 1st Semester
                prereqSemester = "2nd Semester" ' previous semester is 2nd Semester
            Else ' if current semester is 2nd Semester
                prereqSemester = "1st Semester" ' previous semester is 1st Semester
            End If

            If CbxYear.SelectedItem.ToString() = "1" AndAlso CbxSem.SelectedItem.ToString() = "1st Semester" Then
                ' Student can enroll because it is the first year and semester
            ElseIf CbxYear.SelectedItem.ToString() = prereqYear.ToString() AndAlso CbxSem.SelectedItem.ToString() = prereqSemester Then
                ' Student can enroll because they have completed the prerequisite year and semester
            Else
                ' Student needs to enroll in the prerequisite year and semester before they can enroll in the selected year and semester
                MessageBox.Show("You cannot enroll for this semester and year because you have not completed the prerequisite year and semester.")
                Exit Sub
            End If

            ' Check if the student has data in student_grades table and exclude 1st year 1st semester
            Dim hasGradesQuery As String = "SELECT COUNT(*) FROM enrollment.student_grades WHERE stud_id = " & MainForm.id & " AND subj_code IS NOT NULL AND year != '1' AND semester != '1st Semester'"
            Dim hasGradesCmd As New MySqlCommand(hasGradesQuery, MysqlConn, transaction)
            hasGradesCmd.Parameters.AddWithValue("@reg_idno", MainForm.id)
            Dim hasGrades As Integer = hasGradesCmd.ExecuteScalar()

            ' Check if the student has already enrolled
            Dim hasEnrolledQuery1 As String = "SELECT COUNT(*) FROM enrollment.student_enrollees WHERE reg_idno = @reg_idno AND year = @year AND semester = @semester"
            Dim hasEnrolledCmd1 As New MySqlCommand(hasEnrolledQuery1, MysqlConn, transaction)
            hasEnrolledCmd1.Parameters.AddWithValue("@reg_idno", MainForm.id)
            hasEnrolledCmd1.Parameters.AddWithValue("@year", CbxYear.SelectedItem.ToString())
            hasEnrolledCmd1.Parameters.AddWithValue("@semester", CbxSem.SelectedItem.ToString())
            Dim hasEnrolled1 As Integer = hasEnrolledCmd1.ExecuteScalar()

            ' Check if the student is already enrolled
            Dim isEnrolledQuery As String = "SELECT COUNT(*) FROM enrollment.enrolled_stud WHERE stud_id = " & MainForm.id & ""
            Dim isEnrolledCmd As New MySqlCommand(isEnrolledQuery, MysqlConn, transaction)
            isEnrolledCmd.Parameters.AddWithValue("@reg_idno", MainForm.id)
            Dim isEnrolled As Integer = isEnrolledCmd.ExecuteScalar()

            ' Check if the student has already enrolled for this semester and year
            Dim hasEnrolledQuery2 As String = "SELECT COUNT(*) FROM enrollment.student_enrollees WHERE reg_idno = " & MainForm.id & " AND year = @year AND semester = @semester"
            Dim hasEnrolledCmd2 As New MySqlCommand(hasEnrolledQuery2, MysqlConn, transaction)
            hasEnrolledCmd2.Parameters.AddWithValue("@reg_idno", MainForm.id)
            hasEnrolledCmd2.Parameters.AddWithValue("@year", CbxYear.SelectedItem.ToString())
            hasEnrolledCmd2.Parameters.AddWithValue("@semester", CbxSem.SelectedItem.ToString())
            Dim hasEnrolled2 As Integer = hasEnrolledCmd2.ExecuteScalar()

            ' Check if the student is already enrolled in student_enrollees or enrolled_stud
            Dim isDuplicateQuery As String = "SELECT COUNT(*) FROM enrollment.student_enrollees WHERE reg_idno = @reg_idno AND year = @year AND semester = @semester AND subj_code IN (SELECT subj_code FROM enrollment.enrolled_stud WHERE stud_id = @reg_idno)"
            Dim isDuplicateCmd As New MySqlCommand(isDuplicateQuery, MysqlConn, transaction)
            isDuplicateCmd.Parameters.AddWithValue("@reg_idno", MainForm.id)
            isDuplicateCmd.Parameters.AddWithValue("@year", CbxYear.SelectedItem.ToString())
            isDuplicateCmd.Parameters.AddWithValue("@semester", CbxSem.SelectedItem.ToString())
            Dim isDuplicate As Integer = isDuplicateCmd.ExecuteScalar()

            If hasGrades = 0 AndAlso (CbxYear.SelectedItem.ToString() <> "1" OrElse CbxSem.SelectedItem.ToString() <> "1st Semester") Then
                ' Student cannot enroll because they do not have any grades yet except for 1st year 1st semester
                MessageBox.Show("You cannot enroll for this semester and year because you have no grades yet in your previous subjects.")
                Exit Sub
            ElseIf isDuplicate > 0 OrElse isEnrolled > 0 Then
                ' Student has enrolled already
                MessageBox.Show("You have already enrolled or your enrollment is being processed.")
            ElseIf hasEnrolled1 > 0 Then
                ' Student has already enrolled for this semester and year
                MessageBox.Show("You have already enrolled for this semester and year.")
                Exit Sub
            ElseIf hasEnrolled2 > 0 Then
                ' Student has already enrolled for this semester and year
                MessageBox.Show("You have already enrolled for this semester and year.")
                Exit Sub
            Else

                For Each row As DataGridViewRow In clickedRows
                    Dim subjCode As String = row.Cells("subj_code").Value.ToString()
                    Dim subjDesc As String = row.Cells("description").Value.ToString()

                    ' Check if the record already exists in the database
                    Dim existsQuery As String = "SELECT COUNT(*) FROM enrollment.student_enrollees WHERE reg_idno = " & MainForm.id & " AND subj_code = @subj_code AND description = @description AND course = @course AND year = @year AND section = @section AND semester = @semester"
                    Dim existsCmd As New MySqlCommand(existsQuery, MysqlConn, transaction)
                    existsCmd.Parameters.AddWithValue("@reg_idno", " " & MainForm.id & "")
                    existsCmd.Parameters.AddWithValue("@subj_code", subjCode)
                    existsCmd.Parameters.AddWithValue("@description", subjDesc)
                    existsCmd.Parameters.AddWithValue("@course", TbxCour.Text)
                    existsCmd.Parameters.AddWithValue("@year", CbxYear.SelectedItem.ToString())
                    existsCmd.Parameters.AddWithValue("@section", CbxSec.SelectedItem.ToString())
                    existsCmd.Parameters.AddWithValue("@semester", CbxSem.SelectedItem.ToString())
                    Dim recordCount As Integer = existsCmd.ExecuteScalar()

                    If recordCount = 0 Then ' Record does not exist, so insert it

                        Dim query As String = "INSERT INTO enrollment.student_enrollees (reg_idno, subj_code, description, course, year, section, semester, payment) VALUES (" & MainForm.id & ", @subj_code, @description, @course, @year, @section, @semester, @payment)"
                        Dim cmd As New MySqlCommand(query, MysqlConn, transaction)
                        cmd.Parameters.AddWithValue("@reg_idno", " " & MainForm.id & "")
                        cmd.Parameters.AddWithValue("@subj_code", subjCode)
                        cmd.Parameters.AddWithValue("@description", subjDesc)
                        cmd.Parameters.AddWithValue("@course", TbxCour.Text)
                        cmd.Parameters.AddWithValue("@year", CbxYear.SelectedItem.ToString())
                        cmd.Parameters.AddWithValue("@section", CbxSec.SelectedItem.ToString())
                        cmd.Parameters.AddWithValue("@semester", CbxSem.SelectedItem.ToString())
                        Dim paymentValue As Decimal = GetPaymentAmount(subjCode)
                        cmd.Parameters.AddWithValue("@payment", paymentValue)
                        cmd.ExecuteNonQuery()

                    End If

                Next
                transaction.Commit() ' commit the transaction if successful
                MsgBox("You have successfully enrolled for this semester and year. Please wait for confirmation.", MsgBoxStyle.Information)
                ResetDisplayedData()

                TbxFee.Text = ""
                Payment.Text = ""
                CbxYear.Text = ""
                CbxSem.Text = ""
                CbxSec.Text = ""
            End If
        Catch ex As Exception
            If transaction.Connection IsNot Nothing AndAlso transaction.Connection.State = ConnectionState.Open Then
                transaction.Rollback()
            End If
            MessageBox.Show("Error: " & ex.Message)
        Finally
            MysqlConn.Close()
            TbxFee.Text = ""
            Payment.Text = ""
            CbxYear.Text = ""
            CbxSem.Text = ""
            CbxSec.Text = ""
        End Try
    End Sub
End Class
