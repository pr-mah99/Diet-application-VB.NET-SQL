Imports Guna.UI2.WinForms
Imports System.Data.SqlClient

Public Class Gender
    Private Sub Check(Type As String)
        'Type
        Try
            Dim sql As String = "update Information set Gender='" & Type & "' where user_id='" & TextBox1.Text & "'"
            Dim cmd As New SqlCommand(sql, cn)
            cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
            Login.Show()
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        Finally
            cn.Close()
        End Try
    End Sub
    Private Sub Guna2CirclePictureBox1_Click(sender As Object, e As EventArgs) Handles Guna2CirclePictureBox1.Click
        Check("انثى")
    End Sub

    Private Sub Guna2CirclePictureBox2_Click(sender As Object, e As EventArgs) Handles Guna2CirclePictureBox2.Click
        Check("ذكر")
    End Sub

    Private Sub Guna2CirclePictureBox4_Click(sender As Object, e As EventArgs) Handles Guna2CirclePictureBox4.Click
        Check("طفل")
    End Sub

    Private Sub Guna2CirclePictureBox3_Click(sender As Object, e As EventArgs) Handles Guna2CirclePictureBox3.Click
        Check("طفلة")
    End Sub

    Private Sub Gender_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class