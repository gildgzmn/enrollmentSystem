Imports System.Reflection
Imports MySql.Data.MySqlClient
Public Class FacProfileForm
    Dim MysqlConn As MySqlConnection
    Dim table As DataTable

    Private Sub ResetForm()
        Dim adapter As New MySqlDataAdapter("SELECT * FROM enrollment.faculty_info where fac_id=" & MainForm.id & "", MysqlConn)
        table = New DataTable()
        adapter.Fill(table)
        LblUser.Text = MainForm.LogChoice.SelectedItem.ToString()
        LblPK.Text = table.Rows(0)(0).ToString
        LblPK.TextAlign = ContentAlignment.MiddleCenter
        FcFN.Text = table.Rows(0)(1).ToString
        FcSN.Text = table.Rows(0)(2).ToString
        FcDept.Text = table.Rows(0)(3).ToString
        FcCn.Text = table.Rows(0)(7).ToString
        FcGen.Text = table.Rows(0)(8).ToString
        FcNat.Text = table.Rows(0)(9).ToString
        LblName.Text = FcFN.Text & " " & FcSN.Text
    End Sub

    Private Sub FacProfileForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BtnClc.Visible = False
        BtnSave.Visible = False
        MysqlConn = New MySqlConnection()
        MysqlConn.ConnectionString = "server=localhost; userid=root; password=cpe123; database=enrollment"
        MysqlConn.Open()
        Dim adapter As New MySqlDataAdapter("SELECT * FROM enrollment.faculty_info where fac_id=" & MainForm.id & "", MysqlConn)
        table = New DataTable()
        adapter.Fill(table)
        LblUser.Text = MainForm.LogChoice.SelectedItem.ToString()
        LblPK.Text = table.Rows(0)(0).ToString
        LblPK.TextAlign = ContentAlignment.MiddleCenter
        FcFN.Text = table.Rows(0)(1).ToString
        FcSN.Text = table.Rows(0)(2).ToString
        FcDept.Text = table.Rows(0)(3).ToString
        FcCn.Text = table.Rows(0)(7).ToString
        FcGen.Text = table.Rows(0)(8).ToString
        FcNat.Text = table.Rows(0)(9).ToString
        LblName.Text = FcFN.Text & " " & FcSN.Text
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        BtnClc.Visible = True
        BtnSave.Visible = True

        FcSN.Enabled = True
        FcFN.Enabled = True
        FcDept.Enabled = True
        FcCn.Enabled = True
        FcGen.Enabled = True
        FcNat.Enabled = True
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Dim COMMAND As MySqlCommand
        MysqlConn = New MySqlConnection()
        MysqlConn.ConnectionString = "server=localhost; userid=root; password=cpe123; database=enrollment"
        Dim READER As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "UPDATE enrollment.faculty_info SET firstname = '" & FcFN.Text & "', lastname = '" & FcSN.Text & "', department = '" & FcDept.Text & "', contact = '" & FcCn.Text & "', gender = '" & FcGen.Text & "', nationality = '" & FcNat.Text & "' WHERE fac_id = " & MainForm.id
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader
            MsgBox("Data Saved!", MsgBoxStyle.Information)
            MysqlConn.Close()
            ' update the text boxes with the new values
            LblName.Text = FcFN.Text & " " & FcSN.Text
            FcSN.Enabled = False
            FcFN.Enabled = False
            FcDept.Enabled = False
            FcCn.Enabled = False
            FcGen.Enabled = False
            FcNat.Enabled = False
            BtnClc.Visible = False
            BtnSave.Visible = False
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub BtnClc_Click(sender As Object, e As EventArgs) Handles BtnClc.Click

        ResetForm()
        BtnClc.Visible = False
        BtnSave.Visible = False
        FcSN.Enabled = False
        FcFN.Enabled = False
        FcDept.Enabled = False
        FcCn.Enabled = False
        FcGen.Enabled = False
        FcNat.Enabled = False
        BtnClc.Visible = False
        BtnSave.Visible = False
    End Sub
End Class