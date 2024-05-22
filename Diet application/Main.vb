Imports System.Data.SqlClient

Public Class Main
    Private Sub Guna2TileButton5_Click(sender As Object, e As EventArgs) Handles Guna2TileButton5.Click
        Login.Show()
        Me.Close()
    End Sub

    Private Sub Guna2TileButton4_Click(sender As Object, e As EventArgs) Handles Guna2TileButton4.Click
        Information.ShowDialog()
    End Sub

    Private Sub Guna2TileButton6_Click(sender As Object, e As EventArgs) Handles Guna2TileButton6.Click
        About_Project.ShowDialog()
    End Sub

    Private Sub Guna2TileButton1_Click(sender As Object, e As EventArgs) Handles Guna2TileButton1.Click
        Favorite_meals.Show()
    End Sub

    Private Sub Guna2TileButton2_Click(sender As Object, e As EventArgs) Handles Guna2TileButton2.Click
        Tips.Show()
    End Sub

    Private Sub Guna2TileButton3_Click(sender As Object, e As EventArgs) Handles Guna2TileButton3.Click
        Dislike_meals.Show()
    End Sub

    Private Sub total()
        Dim sql As String = "select COUNT(*) from Favorite_meals where user_id='" + Label13.Text + "'"
        Dim sql2 As String = "select COUNT(*) from Tips"
        Dim sql3 As String = "select COUNT(*) from Dislike_meals where user_id='" + Label13.Text + "'"

        Dim sql4 As String = "select weight from Information where user_id='" + Label13.Text + "'"
        Dim sql5 As String = "select required_weight from Information where user_id='" + Label13.Text + "'"


        Dim command As New SqlCommand(sql, cn)
        Dim command2 As New SqlCommand(sql2, cn)
        Dim command3 As New SqlCommand(sql3, cn)

        Dim command4 As New SqlCommand(sql4, cn)
        Dim command5 As New SqlCommand(sql5, cn)


        cn.Open()
        Label6.Text = command.ExecuteScalar().ToString()
        Label8.Text = command2.ExecuteScalar().ToString()
        Label10.Text = command3.ExecuteScalar().ToString()

        Label3.Text = command4.ExecuteScalar().ToString() & " كيلو" 'الوزن الحالي
        Label4.Text = command5.ExecuteScalar().ToString() & " كيلو" 'الوزن المطلوب
        cn.Close()
    End Sub

    Private Sub Guna2TileButton7_Click(sender As Object, e As EventArgs) Handles Guna2TileButton7.Click
        total()
    End Sub

    Private Sub Guna2TileButton8_Click(sender As Object, e As EventArgs) Handles Guna2TileButton8.Click
        Exercise_course.Show()
    End Sub

    Private Sub Guna2TileButton9_Click(sender As Object, e As EventArgs) Handles Guna2TileButton9.Click
        Meals_course.Show()
    End Sub
End Class