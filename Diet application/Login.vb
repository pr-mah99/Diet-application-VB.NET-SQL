Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Login
    Private Sub allow()
        Try
            Dim allow, type, fullname, userId As String
            Dim sql As SqlCommand = New SqlCommand("Select allow,type,fullname,id_user from Users where username='" + Guna2TextBox1.Text + "'", cn)
            Dim reader As SqlDataReader = sql.ExecuteReader
            reader.Read()
            If reader.HasRows Then
                allow = reader(0)
                type = reader(1)
                fullname = reader(2)
                userId = reader(3)

                cn.Close()
                If type = "مدير" Then
                    Admin.Show()
                    Me.Close()
                Else type = "مستخدم"

                    If allow = "False" Then
                        MsgBox("عذرا لقد تم حظرك من استخدام التطبيق", MsgBoxStyle.Critical)
                    Else
                        Main.Show()
                        Main.Label13.Text = userId
                        Main.Label12.Text = fullname
                        Main.Guna2TileButton7.PerformClick()
                        Me.Close()
                    End If
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cn.Close()
        End Try
    End Sub
    Private Sub Guna2TileButton1_Click(sender As Object, e As EventArgs) Handles Guna2TileButton1.Click
        'login
        Try
            Dim sql As SqlCommand = New SqlCommand("Select * from Users where username='" + Guna2TextBox1.Text + "' And password='" + Guna2TextBox2.Text + "'", cn)
            Dim dt As New DataTable()
            cn.Open()
            Dim dataadapter As New SqlDataAdapter(sql)
            dataadapter.Fill(dt)
            If (dt.Rows.Count > 0) Then
                allow()
            Else
                MsgBox("تفقد اسم المستخدم او كلمة المرور", MsgBoxStyle.Critical)
                cn.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Erorr !!", vbCritical)
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub Guna2TileButton2_Click(sender As Object, e As EventArgs) Handles Guna2TileButton2.Click
        User_info.Show()
        Me.Close()
    End Sub
End Class