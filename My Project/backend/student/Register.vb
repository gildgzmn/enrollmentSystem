
Imports MySql.Data.MySqlClient

Public Class Register
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand

    'GENDER COMBOBOX
    Private Sub StdSex_ValueMemberChanged(sender As Object, e As EventArgs) Handles StdSex.ValueMemberChanged
        Dim MysqlConn As New MySqlConnection("datasource=localhost;port=3306;username=root;password=cpe123")
        Dim adapter As New MySqlDataAdapter("SELECT DISTINCT gender FROM student_info", MysqlConn)
        Dim table As New DataTable()

        Try
            adapter.Fill(table)
            StdSex.DataSource = table
            StdSex.ValueMember = "gender"
            StdSex.DisplayMember = "gender"
        Catch ex As Exception
            MessageBox.Show("Error fetching gender data from database: " & ex.Message)
        Finally
            MysqlConn.Close()
        End Try
    End Sub

    'BIRTHDAY CALCULATION
    Private Sub StdBDAY_ValueChanged(sender As Object, e As EventArgs) Handles StdBDAY.ValueChanged
        Try
            Dim datecheck As String
            Dim today As DateTime = Date.Now
            Dim bday As DateTime = StdBDAY.Value
            datecheck = StdAge.Text

            Dim curage As Integer = today.Year - bday.Year

            If today.Month < bday.Month Or (today.Month = bday.Month And today.Day < bday.Day) Then
                curage -= 1

            End If

            StdAge.Text = curage
            StdAge.Show()
        Catch ex As Exception
            MessageBox.Show("Error calculating age: " & ex.Message)
        End Try
    End Sub


    Private Function AllFieldsFilled() As Boolean
        'Check if all required fields are filled

        If StdFN.Text = "" Or StdMN.Text = "" Or StdLN.Text = "" Or StdAdr.Text = "" Or StdCn.Text = "" Or StdAge.Text = "" Or StdSex.Text = "" Or StdCtz.Text = "" Or StdBP.Text = "" Or StdBDAY.Text = "" Or F_name.Text = "" Or F_Oc.Text = "" Or F_Cn.Text = "" Or M_name.Text = "" Or M_Oc.Text = "" Or M_Cn.Text = "" Or StdPrim.Text = "" Or YrPrim.Text = "" Or StdInter.Text = "" Or YrInter.Text = "" Or StdHS7.Text = "" Or Yr7.Text = "" Or StdHS8.Text = "" Or Yr8.Text = "" Or StdHS9.Text = "" Or Yr9.Text = "" Or StdHS10.Text = "" Or Yr10.Text = "" Or StdHS11.Text = "" Or Yr11.Text = "" Or StdHS12.Text = "" Or Yr12.Text = "" Or RegUser.Text = "" Or RegPass.Text = "" Or ConfPass.Text = "" Then
            MsgBox("Please fill in all the required fields.", MsgBoxStyle.Critical)
            Return False
        Else
            Return True
        End If
    End Function
    Private Function IsValidName(ByVal name As String) As Boolean
        'Check if name does not contain int
        Dim regex As New System.Text.RegularExpressions.Regex("^[a-zA-Z\s]+$")
        Return regex.IsMatch(name)
    End Function

    'REGISTER USER  
    Private Sub BtnReg_Click(sender As Object, e As EventArgs) Handles BtnReg.Click
        Dim errorList As New List(Of String)
        MysqlConn = New MySqlConnection()
        MysqlConn.ConnectionString = "server=localhost; userid=root; password=cpe123; database=enrollment"
        Dim READER As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String
            Dim qadd As String = "SELECT Count(username) FROM enrollment.student_info WHERE username='" & RegUser.Text & "'"

            'Check if all required fields are filled
            If Not AllFieldsFilled() Then

                Exit Sub
            End If

            'Check if all required fields are filled
            If StdFN.Text = "" Or StdMN.Text = "" Or StdLN.Text = "" Or StdAdr.Text = "" Or StdCn.Text = "" Or StdAge.Text = "" Or StdSex.Text = "" Or StdCtz.Text = "" Or StdBP.Text = "" Or StdBDAY.Text = "" Or F_name.Text = "" Or F_Oc.Text = "" Or F_Cn.Text = "" Or M_name.Text = "" Or M_Oc.Text = "" Or M_Cn.Text = "" Or StdPrim.Text = "" Or YrPrim.Text = "" Or StdInter.Text = "" Or YrInter.Text = "" Or StdHS7.Text = "" Or Yr7.Text = "" Or StdHS8.Text = "" Or Yr8.Text = "" Or StdHS9.Text = "" Or Yr9.Text = "" Or StdHS10.Text = "" Or Yr10.Text = "" Or StdHS11.Text = "" Or Yr11.Text = "" Or StdHS12.Text = "" Or Yr12.Text = "" Or RegUser.Text = "" Or RegPass.Text = "" Or ConfPass.Text = "" Then

                errorList.Add("Please Fill in all the Required Fields.")
            End If

            ' Check if StdCn and M_Cn contain only integers
            If Not IsNumeric(StdCn.Text) Then

                MsgBox("Student Contact Number must be an Integer.")
                errorList.Add("Student Contact Number must be an Integer.")
                StdCn.BackColor = Color.LightPink
                StdCn.Focus()
            Else
                StdCn.BackColor = Color.White
            End If

            If Not IsNumeric(M_Cn.Text) Then

                MsgBox("Mother's Contact Number must be an Integer.")
                errorList.Add("Mother's Contact Number must be an Integer.")
                M_Cn.BackColor = Color.LightPink
                M_Cn.Focus()
            Else
                M_Cn.BackColor = Color.White
            End If

            If Not IsNumeric(F_Cn.Text) Then

                MsgBox("Father's Contact Number must be an Integer.")
                errorList.Add("Father's Contact Number must be an Integer.")
                F_Cn.BackColor = Color.LightPink
                F_Cn.Focus()
            Else
                F_Cn.BackColor = Color.White
            End If

            ' Check if StdCn and M_Cn contain only integers and have 11 characters
            If Not IsNumeric(StdCn.Text) OrElse StdCn.Text.Length <> 11 Then

                MsgBox("Student Contact Number must be 11 digits.")
                errorList.Add("Student Contact Number must be 11 digits.")
                StdCn.BackColor = Color.LightPink
                StdCn.Focus()
            Else
                StdCn.BackColor = Color.White
            End If

            If Not IsNumeric(M_Cn.Text) OrElse M_Cn.Text.Length <> 11 Then

                MsgBox("Mother's Contact Number must be 11 digits.")
                errorList.Add("Mother's Contact Number must be 11 digits.")
                M_Cn.BackColor = Color.LightPink
                M_Cn.Focus()
            Else
                M_Cn.BackColor = Color.White
            End If

            If Not IsNumeric(F_Cn.Text) OrElse F_Cn.Text.Length <> 11 Then

                MsgBox("Father's Contact Number must be 11 digits.")
                errorList.Add("Father's Contact Number must be 11 digits.")
                F_Cn.BackColor = Color.LightPink
                F_Cn.Focus()
            Else
                F_Cn.BackColor = Color.White

            End If

            'Age checking
            If StdAge.Text < "16" Then

                MsgBox("Invalid Age!")
                errorList.Add("Invalid Age!")
                StdAge.BackColor = Color.LightPink
                StdAge.Focus()
                Exit Sub
            Else
                StdAge.BackColor = Color.White
            End If

            'Check if name fields are valid
            If Not IsValidName(F_name.Text) Then

                MsgBox("Invalid Father Name!")
                errorList.Add("Invalid Father Name!")
                F_name.BackColor = Color.LightPink
                F_name.Focus()
                Exit Sub
            Else
                F_name.BackColor = Color.White
            End If

            If Not IsValidName(M_name.Text) Then

                MsgBox("Invalid Mother Name!")
                errorList.Add("Invalid Mother Name!")
                M_name.BackColor = Color.LightPink
                M_name.Focus()
                Exit Sub
            Else
                M_name.BackColor = Color.White
            End If

            If Not IsValidName(StdFN.Text) Then

                MsgBox("Invalid Student First Name!")
                errorList.Add("Invalid Student First Name!")
                StdFN.BackColor = Color.LightPink
                StdFN.Focus()
                Exit Sub
            Else
                StdFN.BackColor = Color.White
            End If

            If Not IsValidName(StdMN.Text) Then

                MsgBox("Invalid Student Middle Name!")
                errorList.Add("Invalid Student Middle Name!")
                StdMN.BackColor = Color.LightPink
                StdMN.Focus()
                Exit Sub
            Else
                StdMN.BackColor = Color.White
            End If

            If Not IsValidName(StdLN.Text) Then

                MsgBox("Invalid Student Last Name!")
                errorList.Add("Invalid Student Last Name!")
                StdLN.BackColor = Color.LightPink
                StdLN.Focus()
                Exit Sub
            Else
                StdLN.BackColor = Color.White

            End If

            ' Check if YrPrim contains only 4 numbers
            If Not IsNumeric(YrPrim.Text) OrElse YrPrim.Text.Length <> 4 Then

                MsgBox("Completion year must be 4 digits!")
                errorList.Add("Completion year must be 4 digits!")
                YrPrim.Focus()
                Exit Sub
            End If

            If Not IsNumeric(YrInter.Text) OrElse YrInter.Text.Length <> 4 Then

                MsgBox("Completion year must be 4 digits!")
                errorList.Add("Completion year must be 4 digits!")
                YrInter.Focus()
                Exit Sub
            End If

            If Not IsNumeric(Yr7.Text) OrElse Yr7.Text.Length <> 4 Then

                MsgBox("Completion year must be 4 digits!")
                errorList.Add("Completion year must be 4 digits!")
                Yr7.Focus()
                Exit Sub
            End If

            If Not IsNumeric(Yr8.Text) OrElse Yr8.Text.Length <> 4 Then

                MsgBox("Completion year must be 4 digits!")
                errorList.Add("Completion year must be 4 digits!")
                Yr8.Focus()
                Exit Sub
            End If

            If Not IsNumeric(Yr9.Text) OrElse Yr9.Text.Length <> 4 Then

                MsgBox("Completion year must be 4 digits!")
                errorList.Add("Completion year must be 4 digits!")
                Yr9.Focus()
                Exit Sub
            End If

            If Not IsNumeric(Yr10.Text) OrElse Yr10.Text.Length <> 4 Then

                MsgBox("Completion year must be 4 digits!")
                errorList.Add("Completion year must be 4 digits!")
                Yr10.Focus()
                Exit Sub
            End If

            If Not IsNumeric(Yr11.Text) OrElse Yr11.Text.Length <> 4 Then
                MsgBox("Completion year must be 4 digits!")
                errorList.Add("Completion year must be 4 digits!")
                Yr11.Focus()
                Exit Sub
            End If

            If Not IsNumeric(Yr12.Text) OrElse Yr12.Text.Length <> 4 Then
                MsgBox("Completion year must be 4 digits!")
                errorList.Add("Completion year must be 4 digits!")
                Yr12.Focus()
                Exit Sub
            End If

            Dim qcheck As New MySqlCommand(qadd, MysqlConn)
            Dim count As Integer = CInt(qcheck.ExecuteScalar())

            If count > 0 Then
                MsgBox("Username and password are duplicated!", MsgBoxStyle.Critical)

            ElseIf RegPass.Text <> ConfPass.Text Then
                MsgBox("Password unmatched!", MsgBoxStyle.Critical)
            Else
                Query = "INSERT INTO enrollment.student_info " _
                & "(firstname, middlename, lastname, address, contact, age, gender, nationality, birthplace, birthday, father_name, f_occupation, f_contact, mother_name, m_occupation, m_contact, ed_primary, yr_prim, ed_interm, yr_inter, ed_gr7, yr_gr7 , ed_gr8, yr_gr8 , ed_gr9, yr_gr9 , ed_gr10, yr_gr10 , ed_gr11, yr_gr11 , ed_gr12, yr_gr12, username, password) " _
                & "VALUES ('" & StdFN.Text & "', '" & StdMN.Text & "', '" & StdLN.Text & "', '" & StdAdr.Text & "', '" & StdCn.Text & "', '" & StdAge.Text & "','" & StdSex.Text & "','" & StdCtz.Text & "', '" & StdBP.Text & "', '" & StdBDAY.Text & "' , '" & F_name.Text & "', '" & F_Oc.Text & "', '" & F_Cn.Text & "', '" & M_name.Text & "', '" & M_Oc.Text & "', '" & M_Cn.Text & "', '" & StdPrim.Text & "', '" & YrPrim.Text & "', '" & StdInter.Text & "', '" & YrInter.Text & "', '" & StdHS7.Text & "', '" & Yr7.Text & "', '" & StdHS8.Text & "', '" & Yr8.Text & "', '" & StdHS9.Text & "', '" & Yr9.Text & "', '" & StdHS10.Text & "', '" & Yr10.Text & "', '" & StdHS11.Text & "', '" & Yr11.Text & "', '" & StdHS12.Text & "', '" & Yr12.Text & "', '" & RegUser.Text & "', '" & RegPass.Text & "')"
                COMMAND = New MySqlCommand(Query, MysqlConn)
                READER = COMMAND.ExecuteReader

                MsgBox("Successfully Registered! Please Proceed to Login.", MsgBoxStyle.Information)
                MainForm.Show()
                Me.Hide()
                MysqlConn.Close()
                StdFN.Text = ""
                StdMN.Text = ""
                StdLN.Text = ""
                StdAdr.Text = ""
                StdCn.Text = ""
                StdAge.Text = ""
                StdSex.Text = ""
                StdCtz.Text = ""
                StdBP.Text = ""
                StdBDAY.Text = ""
                F_name.Text = ""
                F_Oc.Text = ""
                F_Cn.Text = ""
                M_name.Text = ""
                M_Oc.Text = ""
                M_Cn.Text = ""
                RegUser.Text = ""
                RegPass.Text = ""
                ConfPass.Text = ""
                StdPrim.Text = ""
                YrPrim.Text = ""
                StdInter.Text = ""
                YrInter.Text = ""
                StdHS7.Text = ""
                Yr7.Text = ""
                StdHS8.Text = ""
                Yr8.Text = ""
                StdHS9.Text = ""
                Yr9.Text = ""
                StdHS10.Text = ""
                Yr10.Text = ""
                StdHS11.Text = ""
                Yr11.Text = ""
                StdHS12.Text = ""
                Yr12.Text = ""

            End If

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        MainForm.MainForm_Load(sender, e)
        MainForm.Show()
        Me.Hide()
        StdFN.Text = ""
        StdMN.Text = ""
        StdLN.Text = ""
        StdAdr.Text = ""
        StdCn.Text = ""
        StdAge.Text = ""
        StdSex.Text = ""
        StdCtz.Text = ""
        StdBP.Text = ""
        StdBDAY.Text = ""
        F_name.Text = ""
        F_Oc.Text = ""
        F_Cn.Text = ""
        M_name.Text = ""
        M_Oc.Text = ""
        M_Cn.Text = ""
        RegUser.Text = ""
        RegPass.Text = ""
        ConfPass.Text = ""
        StdPrim.Text = ""
        YrPrim.Text = ""
        StdInter.Text = ""
        YrInter.Text = ""
        StdHS7.Text = ""
        Yr7.Text = ""
        StdHS8.Text = ""
        Yr8.Text = ""
        StdHS9.Text = ""
        Yr9.Text = ""
        StdHS10.Text = ""
        Yr10.Text = ""
        StdHS11.Text = ""
        Yr11.Text = ""
        StdHS12.Text = ""
        Yr12.Text = ""
    End Sub
End Class