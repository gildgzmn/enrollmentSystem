
Imports MySql.Data.MySqlClient


Public Class FormPrfl
    Dim MysqlConn As MySqlConnection

    Dim table As DataTable
    'Dim COMMAND As MySqlCommand
    'Dim Reader As MySqlDataReader
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        Me.Dispose()
    End Sub

    Private Sub FormPrfl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BtnClc.Visible = False
        BtnSave.Visible = False
        MysqlConn = New MySqlConnection()
        MysqlConn.ConnectionString = "server=localhost; userid=root; password=cpe123; database=enrollment"
        MysqlConn.Open()
        Dim adapter As New MySqlDataAdapter("SELECT * FROM enrollment.student_info where reg_idno=" & MainForm.id & "", MysqlConn)
        table = New DataTable()
        adapter.Fill(table)

        LblUser.Text = MainForm.LogChoice.SelectedItem.ToString()
        LblPK.Text = table.Rows(0)(0).ToString
        LblPK.TextAlign = ContentAlignment.MiddleCenter
        StdFN.Text = table.Rows(0)(1).ToString
        StdMN.Text = table.Rows(0)(2).ToString
        StdSN.Text = table.Rows(0)(3).ToString
        LblName.Text = StdFN.Text & " " & StdMN.Text & " " & StdSN.Text
        LblName.TextAlign = ContentAlignment.MiddleCenter
        StdAdd.Text = table.Rows(0)(4).ToString
        StdCn.Text = table.Rows(0)(5).ToString
        StdAge.Text = table.Rows(0)(6).ToString
        StdSex.Text = table.Rows(0)(7).ToString
        StdCtz.Text = table.Rows(0)(8).ToString
        StdBP.Text = table.Rows(0)(9).ToString
        StdBDAY.Text = table.Rows(0)(10).ToString
        F_name.Text = table.Rows(0)(11).ToString
        F_Oc.Text = table.Rows(0)(12).ToString
        F_Cn.Text = table.Rows(0)(13).ToString
        M_name.Text = table.Rows(0)(14).ToString
        M_Oc.Text = table.Rows(0)(15).ToString
        M_Cn.Text = table.Rows(0)(16).ToString
        StdPrim.Text = table.Rows(0)(17).ToString
        YrPrim.Text = table.Rows(0)(18).ToString
        StdInter.Text = table.Rows(0)(19).ToString
        YrInter.Text = table.Rows(0)(20).ToString
        StdHS7.Text = table.Rows(0)(21).ToString
        Yr7.Text = table.Rows(0)(22).ToString
        StdHS8.Text = table.Rows(0)(23).ToString
        Yr8.Text = table.Rows(0)(24).ToString
        StdHS9.Text = table.Rows(0)(25).ToString
        Yr9.Text = table.Rows(0)(26).ToString
        StdHS10.Text = table.Rows(0)(27).ToString
        Yr10.Text = table.Rows(0)(28).ToString
        StdHS11.Text = table.Rows(0)(29).ToString
        Yr11.Text = table.Rows(0)(30).ToString
        StdHS12.Text = table.Rows(0)(31).ToString
        Yr12.Text = table.Rows(0)(32).ToString
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        BtnClc.Visible = True
        BtnSave.Visible = True

        StdFN.Enabled = True
        StdMN.Enabled = True
        StdSN.Enabled = True
        StdAdd.Enabled = True
        StdCn.Enabled = True
        StdSex.Enabled = True
        StdCtz.Enabled = True
        StdBP.Enabled = True
        F_name.Enabled = True
        F_Oc.Enabled = True
        F_Cn.Enabled = True
        M_name.Enabled = True
        M_Oc.Enabled = True
        M_Cn.Enabled = True

    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click

        Dim COMMAND As MySqlCommand
        MysqlConn = New MySqlConnection()
        MysqlConn.ConnectionString = "server=localhost; userid=root; password=cpe123; database=enrollment"
        Dim READER As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "UPDATE enrollment.student_info SET firstname = '" & StdFN.Text & "', middlename = '" & StdMN.Text & "', lastname = '" & StdSN.Text & "', address = '" & StdAdd.Text & "', contact = '" & StdCn.Text & "', age = '" & StdAge.Text & "', gender = '" & StdSex.Text & "', nationality = '" & StdCtz.Text & "', birthplace = '" & StdBP.Text & "', birthday = '" & StdBDAY.Text & "', father_name = '" & F_name.Text & "', f_occupation = '" & F_Oc.Text & "', f_contact = '" & F_Cn.Text & "', mother_name = '" & M_name.Text & "', m_occupation = '" & M_Oc.Text & "', m_contact = '" & M_Cn.Text & "', ed_primary = '" & StdPrim.Text & "', yr_prim = '" & YrPrim.Text & "', ed_interm = '" & StdInter.Text & "', yr_inter = '" & YrInter.Text & "', ed_gr7 = '" & StdHS7.Text & "', yr_gr7 = '" & Yr7.Text & "', ed_gr8 = '" & StdHS8.Text & "', yr_gr8 = '" & Yr8.Text & "', ed_gr9 = '" & StdHS9.Text & "', yr_gr9 = '" & Yr9.Text & "', ed_gr10 = '" & StdHS10.Text & "', yr_gr10 = '" & Yr10.Text & "', ed_gr11 = '" & StdHS11.Text & "', yr_gr11 = '" & Yr11.Text & "', ed_gr12 = '" & StdHS12.Text & "', yr_gr12 = '" & Yr12.Text & "' WHERE reg_idno = " & MainForm.id
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader
            MsgBox("Data Saved!", MsgBoxStyle.Information)
            MysqlConn.Close()
            ' update the text boxes with the new values
            LblName.Text = StdFN.Text & " " & StdMN.Text & " " & StdSN.Text
            StdFN.Enabled = False
            StdMN.Enabled = False
            StdSN.Enabled = False
            StdAdd.Enabled = False
            StdCn.Enabled = False
            StdSex.Enabled = False
            StdCtz.Enabled = False
            StdBP.Enabled = False
            F_name.Enabled = False
            F_Oc.Enabled = False
            F_Cn.Enabled = False
            M_name.Enabled = False
            M_Oc.Enabled = False
            M_Cn.Enabled = False
            BtnClc.Visible = False
            BtnSave.Visible = False
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub ResetForm()
        Dim adapter As New MySqlDataAdapter("SELECT * FROM enrollment.student_info where reg_idno=" & MainForm.id & "", MysqlConn)
        table = New DataTable()
        adapter.Fill(table)

        LblPK.Text = table.Rows(0)(0).ToString
        StdFN.Text = table.Rows(0)(1).ToString
        StdMN.Text = table.Rows(0)(2).ToString
        StdSN.Text = table.Rows(0)(3).ToString
        LblName.Text = StdFN.Text & " " & StdMN.Text & " " & StdSN.Text
        StdAdd.Text = table.Rows(0)(4).ToString
        StdCn.Text = table.Rows(0)(5).ToString
        StdAge.Text = table.Rows(0)(6).ToString
        StdSex.Text = table.Rows(0)(7).ToString
        StdCtz.Text = table.Rows(0)(8).ToString
        StdBP.Text = table.Rows(0)(9).ToString
        StdBDAY.Text = table.Rows(0)(10).ToString
        F_name.Text = table.Rows(0)(11).ToString
        F_Oc.Text = table.Rows(0)(12).ToString
        F_Cn.Text = table.Rows(0)(13).ToString
        M_name.Text = table.Rows(0)(14).ToString
        M_Oc.Text = table.Rows(0)(15).ToString
        M_Cn.Text = table.Rows(0)(16).ToString
        StdPrim.Text = table.Rows(0)(17).ToString
        YrPrim.Text = table.Rows(0)(18).ToString
        StdInter.Text = table.Rows(0)(19).ToString
        YrInter.Text = table.Rows(0)(20).ToString
        StdHS7.Text = table.Rows(0)(21).ToString
        Yr7.Text = table.Rows(0)(22).ToString
        StdHS8.Text = table.Rows(0)(23).ToString
        Yr8.Text = table.Rows(0)(24).ToString
        StdHS9.Text = table.Rows(0)(25).ToString
        Yr9.Text = table.Rows(0)(26).ToString
        StdHS10.Text = table.Rows(0)(27).ToString
        Yr10.Text = table.Rows(0)(28).ToString
        StdHS11.Text = table.Rows(0)(29).ToString
        Yr11.Text = table.Rows(0)(30).ToString
        StdHS12.Text = table.Rows(0)(31).ToString
        Yr12.Text = table.Rows(0)(32).ToString
    End Sub


    Private Sub BtnClc_Click(sender As Object, e As EventArgs) Handles BtnClc.Click
        ResetForm()
        BtnClc.Visible = False
        BtnSave.Visible = False
        StdFN.Enabled = False
        StdMN.Enabled = False
        StdSN.Enabled = False
        StdAdd.Enabled = False
        StdCn.Enabled = False
        StdSex.Enabled = False
        StdCtz.Enabled = False
        StdBP.Enabled = False
        F_name.Enabled = False
        F_Oc.Enabled = False
        F_Cn.Enabled = False
        M_name.Enabled = False
        M_Oc.Enabled = False
        M_Cn.Enabled = False
    End Sub


End Class