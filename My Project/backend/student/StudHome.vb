Imports MySql.Data.MySqlClient
Public Class StudHome
    Private Sub HideOtherForms(ByVal activeForm As Form)
        For Each form As Form In Panel2.Controls
            If form IsNot activeForm Then
                form.Hide()
            End If
        Next
    End Sub
    Private Sub BtnPrf_Click(sender As Object, e As EventArgs) Handles BtnPrf.Click
        HideOtherForms(FormPrfl)
        With FormPrfl
            .TopLevel = False
            Panel2.Controls.Add(FormPrfl)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub BtnGrd_Click(sender As Object, e As EventArgs) Handles BtnGrd.Click
        HideOtherForms(StdGradesView)
        With StdGradesView
            .TopLevel = False
            Panel2.Controls.Add(StdGradesView)
            .BringToFront()
            .Show()
        End With
    End Sub
    Private Sub BtnSubs_Click(sender As Object, e As EventArgs) Handles BtnSubs.Click

        HideOtherForms(StdSubjects)
        With StdSubjects
            .TopLevel = False
            Panel2.Controls.Add(StdSubjects)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub BtnEnr_Click(sender As Object, e As EventArgs) Handles BtnEnr.Click
        Dim MysqlConn As MySqlConnection = New MySqlConnection("server=localhost;user=root;password=cpe123;database=enrollment")
        Dim hasEnrolledQuery As String = "SELECT COUNT(*) FROM enrollment.enrolled_stud WHERE stud_id = " & MainForm.id & ""
        Dim hasEnrolledCmd As New MySqlCommand(hasEnrolledQuery, MysqlConn)


        ' Open the database connection before executing the query
        MysqlConn.Open()

        Dim hasEnrolled As Integer = CInt(hasEnrolledCmd.ExecuteScalar())

        ' Close the database connection after executing the query
        MysqlConn.Close()

        If hasEnrolled > 0 Then
            HideOtherForms(StdAssessment)
            StdAssessment.TopLevel = False
            StdAssessment.Parent = Panel2
            StdAssessment.BringToFront()
            StdAssessment.Show()
        Else
            ' Otherwise, show the enrollment form as usual
            HideOtherForms(StdEnroll)
            StdEnroll.TopLevel = False
            StdEnroll.Parent = Panel2
            StdEnroll.BringToFront()
            StdEnroll.Show()
        End If
    End Sub

    Private Sub BtnCrr_Click(sender As Object, e As EventArgs) Handles BtnCrr.Click
        HideOtherForms(Curriculum)
        With Curriculum
            .TopLevel = False
            Panel2.Controls.Add(Curriculum)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub BtnLO_Click(sender As Object, e As EventArgs) Handles BtnLO.Click
        Dim result As MsgBoxResult = MsgBox("Do you want to logout?", MsgBoxStyle.YesNo)
        If result = MsgBoxResult.Yes Then
            MainForm.MainForm_Load(sender, e)
            MainForm.Show()
            Me.Hide()
            FormPrfl.Dispose()
            StdEnroll.Dispose()
            StdSubjects.Dispose()
            Curriculum.Dispose()
            StdGradesView.Dispose()
        Else
            ' User clicked cancel or closed the message box
        End If
    End Sub

    Private Sub BtnDB_Click(sender As Object, e As EventArgs)

    End Sub

End Class