Imports MySql.Data.MySqlClient

Public Class FacClassList
    Private Sub CbxYear_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbxYear.SelectedIndexChanged
        'Faculty can select what year level to view for their ClassList
    End Sub

    Private Sub CbxSem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbxSem.SelectedIndexChanged
        'Faculty can select what semester to view for their ClassList
    End Sub

    Private Sub CbxSec_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbxSec.SelectedIndexChanged
        'Faculty can select what section to view for their ClassList
    End Sub

    Private Sub FacClassList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class