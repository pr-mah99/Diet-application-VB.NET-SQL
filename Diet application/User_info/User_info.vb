Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class User_info
    Dim User_id As Integer
    'دالة قياس كتلة الجسم
    Private Function BMI(Height As Single, Width As Single) As Double
        BMI = Width / Height ^ 2
    End Function
    Private Sub Guna2TileButton1_Click(sender As Object, e As EventArgs) Handles Guna2TileButton1.Click
        If Guna2TextBox3.Text = "" Then
            MsgBox("أملئ البيانات اولاً", MsgBoxStyle.Question)
        Else
            Try
                Try
                    Dim sql2 As String = "Select max(id_user) from Users"
                    Dim command As New SqlCommand(sql2, cn)
                    cn.Open()
                    User_id = 1 + Val(command.ExecuteScalar().ToString())
                    cn.Close()
                Catch ex As Exception
                Finally
                    cn.Close()
                End Try
                Dim sql As String = "INSERT INTO Users (id_user,fullname,username,password)  " _
        & "VALUES ('" & User_id & "','" & Guna2TextBox1.Text & "','" & Guna2TextBox2.Text & "','" & Guna2TextBox3.Text & "')"
                Dim cmd As New SqlCommand(sql, cn)
                cn.Open()
                cmd.ExecuteNonQuery()
                cn.Close()
                update_info()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            Finally
                cn.Close()
            End Try
        End If
    End Sub
    Private Sub update_info()
        If Guna2TextBox3.Text = "" Then
            MsgBox("أملئ البيانات اولاً", MsgBoxStyle.Question)
        Else
            'code bmi
            Dim a, b As Single
            a = Val(Guna2TextBox4.Text)
            b = Val(Guna2TextBox5.Text)
            Dim bmi_r = BMI(a, b)
            Try
                Dim max_info As Integer
                Try
                    Dim sql2 As String = "Select max(info_id) from Information"
                    Dim command As New SqlCommand(sql2, cn)
                    cn.Open()
                    max_info = 1 + Val(command.ExecuteScalar().ToString())
                    cn.Close()
                Catch ex As Exception
                Finally
                    cn.Close()
                End Try
                Dim sql As String = "INSERT INTO Information (info_id,Length,weight,required_weight,born,bmi,user_id)  " _
        & "VALUES ('" & max_info & "','" & Guna2TextBox4.Text & "','" & Guna2TextBox5.Text & "','" & Guna2TextBox6.Text & "','" & Guna2DateTimePicker1.Value.Date.ToShortDateString & "','" & bmi_r & "','" & User_id & "')"
                Dim sda As New SqlDataAdapter(sql, cn)
                Dim cmd As New SqlCommand(sql, cn)
                cn.Open()
                cmd.ExecuteNonQuery()
                cn.Close()
                MsgBox("تم اداخال البيانات بنجاح", MsgBoxStyle.Information, "!!")
                Gender.Show()
                Gender.TextBox1.Text = User_id
                Me.Close()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            Finally
                cn.Close()
            End Try
        End If
    End Sub


    Private Sub Guna2TileButton2_Click(sender As Object, e As EventArgs) Handles Guna2TileButton2.Click
        Login.Show()
        Me.Close()
    End Sub
End Class