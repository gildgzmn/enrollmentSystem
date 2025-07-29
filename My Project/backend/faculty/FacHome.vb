Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Status

Public Class FacHome
    Private Sub HideOtherForms(ByVal activeForm As Form)
        For Each form As Form In Panel2.Controls
            If form IsNot activeForm Then
                form.Hide()
            End If
        Next
    End Sub
    Private Sub BtnPrf_Click(sender As Object, e As EventArgs) Handles BtnPrf.Click
        HideOtherForms(FacProfileForm)
        With FacProfileForm
            .TopLevel = False
            Panel2.Controls.Add(FacProfileForm)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub BtnGrd_Click(sender As Object, e As EventArgs) Handles BtnGrd.Click
        HideOtherForms(FacEncode)
        With FacEncode
            .TopLevel = False
            Panel2.Controls.Add(FacEncode)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub BtnClass_Click(sender As Object, e As EventArgs) Handles BtnClass.Click
        HideOtherForms(FacClassList)
        With FacClassList
            .TopLevel = False
            Panel2.Controls.Add(FacClassList)
            .BringToFront()
            .Show()
        End With
    End Sub
    Private Sub BtnSubjs_Click(sender As Object, e As EventArgs) Handles BtnSubjs.Click
        HideOtherForms(FacSubjs)
        With FacSubjs
            .TopLevel = False
            Panel2.Controls.Add(FacSubjs)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub BtnSched_Click(sender As Object, e As EventArgs) Handles BtnSched.Click
        HideOtherForms(FacScheds)
        With FacScheds
            .TopLevel = False
            Panel2.Controls.Add(FacScheds)
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