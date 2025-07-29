Imports MySql.Data.MySqlClient

Public Class MainForm
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim READER As MySqlDataReader = Nothing ' Initialize READER with a value of Nothing
    Public id As Integer
    Function getvariable() As Integer
        Return id
    End Function
    Public Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Hide LinkReg and Label5 controls when the form loads
        LinkReg.Visible = False
        Label5.Visible = False
    End Sub


    Public Sub LogChoice_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LogChoice.SelectedIndexChanged
        ' Hide or show text "Don't have an account yet?" depending on the selected option
        Dim selectedOption As String = LogChoice.SelectedItem.ToString()
        If selectedOption = "student" Then
            LinkReg.Visible = True
            Label5.Visible = True
        Else
            LinkReg.Visible = False
            Label5.Visible = False
        End If
    End Sub


    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click

        If LogChoice.SelectedIndex = -1 Then ' Check if no option is selected
            MsgBox("Please select a login option!", MsgBoxStyle.Exclamation)
            Return ' Exit the event handler
        End If

        MysqlConn = New MySqlConnection()
        MysqlConn.ConnectionString = "server=localhost; userid=root; password=cpe123; database=enrollment"


        Try

            MysqlConn.Open()
            Dim tb As New DataTable
            Dim loginOption As String = LogChoice.SelectedItem.ToString() ' Get the selected login option from the ComboBox
            Dim Query As String = "SELECT * FROM enrollment." & loginOption & "_info WHERE username='" & TbxUN.Text & "' AND password='" & TbxPW.Text & "'"


            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader

            Dim count As Integer = 0
            While READER.Read()
                count += 1
                Dim idString As String = READER.GetString(0) ' Get the value of the first field (assuming it is the ID)
                If Integer.TryParse(idString, id) Then ' Check if the value can be parsed as an integer
                    Console.WriteLine("ID: " & id)
                Else
                    Console.WriteLine("Invalid ID value: " & idString)
                End If
            End While

            If count = 1 Then
                MsgBox("Login Success! Welcome, " & TbxUN.Text & "!", MsgBoxStyle.Information)

                Select Case loginOption
                    Case "student"
                        StudHome.Show()
                        Me.Hide()
                        MysqlConn.Dispose()
                        LogChoice.Text = ""
                        TbxUN.Text = ""
                        TbxPW.Text = ""
                    Case "faculty"
                        FacHome.Show()
                        Me.Hide()
                        MysqlConn.Dispose()
                        LogChoice.Text = ""
                        TbxUN.Text = ""
                        TbxPW.Text = ""
                    Case "admin"
                        AdHome.Show()
                        Me.Hide()
                        MysqlConn.Dispose()
                        LogChoice.Text = ""
                        TbxUN.Text = ""
                        TbxPW.Text = ""
                End Select
            ElseIf count > 1 Then
                MsgBox("Username and password are duplicated!", MsgBoxStyle.Exclamation)
            Else
                MsgBox("Username and Password are Incorrect!", MsgBoxStyle.Critical)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        Finally
            If READER IsNot Nothing Then
                READER.Close()
            End If
            If MysqlConn IsNot Nothing AndAlso MysqlConn.State = ConnectionState.Open Then
                MysqlConn.Close()
            End If
        End Try
    End Sub
    Private Sub LinkReg_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkReg.LinkClicked
        Register.Show()
        Me.Hide()
        LogChoice.Text = ""
        TbxUN.Text = ""
        TbxPW.Text = ""
    End Sub
End Class