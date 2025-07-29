Imports System.Text

Public Class AdHome
    Private Sub HideOtherForms(ByVal activeForm As Form)
        For Each form As Form In Panel2.Controls
            If form IsNot activeForm Then
                form.Hide()
            End If
        Next
    End Sub
    Private Sub BtnEnr_Click(sender As Object, e As EventArgs) Handles BtnEnr.Click
        HideOtherForms(AdEnrollStd)
        With AdEnrollStd
            .TopLevel = False
            Panel2.Controls.Add(AdEnrollStd)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub BtnStd_Click(sender As Object, e As EventArgs) Handles BtnStd.Click
        HideOtherForms(EnrolledStdForm)
        With EnrolledStdForm
            .TopLevel = False
            Panel2.Controls.Add(EnrolledStdForm)
            .BringToFront()
            .Show()
        End With

    End Sub

    Private Sub BtnFac_Click(sender As Object, e As EventArgs) Handles BtnFac.Click
        HideOtherForms(Faculties)
        With Faculties
            .TopLevel = False
            Panel2.Controls.Add(Faculties)
            .BringToFront()
            .Show()
        End With

    End Sub

    Private Sub BtnSbj_Click(sender As Object, e As EventArgs) Handles BtnSbj.Click
        HideOtherForms(Subjects)
        With Subjects
            .TopLevel = False
            Panel2.Controls.Add(Subjects)
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
        Else
            ' User clicked cancel or closed the message box
        End If

    End Sub
End Class

