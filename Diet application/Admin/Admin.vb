Imports System.Data.SqlClient
Imports System.Reflection.Emit

Public Class Admin

    Private Sub Guna2TileButton1_Click(sender As Object, e As EventArgs) Handles Guna2TileButton1.Click
        Meals_Manage.Show()
    End Sub

    Private Sub Guna2TileButton2_Click(sender As Object, e As EventArgs) Handles Guna2TileButton2.Click
        Tips_Manage.Show()
    End Sub

    Private Sub Guna2TileButton3_Click(sender As Object, e As EventArgs) Handles Guna2TileButton3.Click
        Login.Show()
        Me.Close()
    End Sub

    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        total()
    End Sub
    Private Sub total()
        Dim sql As String = "select COUNT(*) from Meals"
        Dim sql2 As String = "select COUNT(*) from Tips"
        Dim sql3 As String = "select COUNT(*) from Users"


        Dim command As New SqlCommand(sql, cn)
        Dim command2 As New SqlCommand(sql2, cn)
        Dim command3 As New SqlCommand(sql3, cn)


        cn.Open()
        Label6.Text = command.ExecuteScalar().ToString()
        Label8.Text = command2.ExecuteScalar().ToString()
        Label10.Text = command3.ExecuteScalar().ToString()
        cn.Close()
    End Sub

    Private Sub Guna2TileButton7_Click(sender As Object, e As EventArgs) Handles Guna2TileButton7.Click
        total()
    End Sub

    Private Sub Guna2TileButton5_Click(sender As Object, e As EventArgs) Handles Guna2TileButton5.Click
        Meals_course_Manage.Show()
    End Sub

    Private Sub Guna2TileButton4_Click(sender As Object, e As EventArgs) Handles Guna2TileButton4.Click
        Exercise_course_Manage.Show()
    End Sub
End Class