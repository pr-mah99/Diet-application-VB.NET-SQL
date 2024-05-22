Imports System.Data.SqlClient

Public Class Exercise_course_Manage
    Private Sub grid_style()
        Guna2DataGridView1.Columns(0).Width = 12
        Guna2DataGridView1.Columns(1).Width = 40
        Guna2DataGridView1.Columns(2).Width = 40
        Guna2DataGridView1.Columns(3).Width = 40
        Guna2DataGridView1.Columns(4).Width = 140
    End Sub
    Private Sub sql_Code()
        Try
            Dim sql As String = "Select id as '#',title as 'عنوان التمرين',body as 'جزء الجسم',weekly as 'تكرار',date as 'تاريخ الاضافة' from Exercise_course"
            Dim dataadapter As New SqlDataAdapter(sql, cn)
            Dim ds As New DataSet()
            cn.Open()
            dataadapter.Fill(ds, "column_name")
            cn.Close()
            Guna2DataGridView1.DataSource = ds
            Guna2DataGridView1.DataMember = "column_name"
            grid_style()
        Catch ex As Exception

        Finally
            cn.Close()
        End Try
    End Sub
    Private Sub Exercise_course_Manage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sql_Code()
    End Sub
    Public Sub FilterData(valueToSearch As String)
        If Guna2TextBox1.Text = "" Then
            sql_Code()
        Else
            Dim searchQuery As String = "Select id as '#',title as 'عنوان التمرين',body as 'جزء الجسم',weekly as 'تكرار',date as 'تاريخ الاضافة' from Exercise_course where CONCAT(title,body) like '%" & valueToSearch & "%'"
            Dim command As New SqlCommand(searchQuery, cn)
            Dim adapter As New SqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)
            Guna2DataGridView1.DataSource = table
            grid_style()
        End If
    End Sub
    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox1.TextChanged
        FilterData(Guna2TextBox1.Text)
    End Sub

    Private Sub Guna2CircleButton1_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton1.Click
        If Guna2TextBox3.Text = "" Then
            MsgBox("أملئ البيانات اولاً", MsgBoxStyle.Question)
        Else
            Try
                Dim max As Integer
                Try
                    Dim sql2 As String = "Select max(id) from Exercise_course"
                    Dim command As New SqlCommand(sql2, cn)
                    cn.Open()
                    max = 1 + Val(command.ExecuteScalar().ToString())
                    cn.Close()
                Catch ex As Exception
                Finally
                    cn.Close()
                End Try
                Dim sql As String = "INSERT INTO Exercise_course (id,title,body,weekly,bmi)  " _
        & "VALUES ('" & max & "','" & Guna2TextBox3.Text & "','" & Guna2TextBox4.Text & "','" & Guna2ComboBox1.Text & "','" & Guna2TextBox5.Text & "')"
                Dim sda As New SqlDataAdapter(sql, cn)
                Dim cmd As New SqlCommand(sql, cn)
                cn.Open()
                cmd.ExecuteNonQuery()
                cn.Close()
                MsgBox("تم اداخال البيانات بنجاح", MsgBoxStyle.Information, "!!")
                sql_Code()
                Guna2TextBox2.Text = max
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            Finally
                cn.Close()
            End Try
        End If
    End Sub

    Private Sub Guna2CircleButton2_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton2.Click
        Try
            Dim sql As String = "update Exercise_course set title='" & Guna2TextBox3.Text & "',body='" & Guna2TextBox4.Text & "',weekly='" & Guna2ComboBox1.Text & "',bmi='" & Guna2TextBox5.Text & "' where id='" & Guna2TextBox2.Text & "'"
            Dim sda As New SqlDataAdapter(sql, cn)
            Dim cmd As New SqlCommand(sql, cn)
            cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
            MsgBox("تم تحديث البيانات بنجاح", MsgBoxStyle.Information, "!!")
            sql_Code()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub Guna2CircleButton3_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton3.Click
        If Guna2TextBox2.Text = "" Then
        Else
            Try
                If MsgBox("هل انت متاكد من حذف هذا ؟ ", MessageBoxButtons.YesNo + MessageBoxIcon.Question, "تحذير !!") = DialogResult.Yes Then
                    'Delete Code
                    Dim DeleteQuery As String = "delete from Exercise_course where id='" & Guna2TextBox2.Text & "'"
                    Dim sda As New SqlDataAdapter(DeleteQuery, cn)
                    Dim com = New SqlCommand(DeleteQuery, cn)
                    cn.Open()
                    com.ExecuteNonQuery()
                    cn.Close()
                    MsgBox("تم حذف البيانات بنجاح", MsgBoxStyle.Information, "!!")
                    sql_Code()
                ElseIf DialogResult.No Then
                    MsgBox("تم الغاء الحذف", MsgBoxStyle.Information, "Warning !")
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            Finally
                cn.Close()
            End Try
        End If
    End Sub

    Private Sub Guna2DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DataGridView1.CellClick
        Guna2Button1.PerformClick()
        Guna2TextBox2.Text = Guna2DataGridView1.CurrentRow.Cells(0).Value.ToString()
        Guna2TextBox3.Text = Guna2DataGridView1.CurrentRow.Cells(1).Value.ToString()
        Guna2TextBox4.Text = Guna2DataGridView1.CurrentRow.Cells(2).Value.ToString()
        Guna2ComboBox1.Text = Guna2DataGridView1.CurrentRow.Cells(3).Value.ToString()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Guna2TextBox1.Clear()
        Guna2TextBox2.Clear()
        Guna2TextBox3.Clear()
        Guna2TextBox4.Clear()
        Guna2ComboBox1.Text = ""
    End Sub

    Private Sub Guna2ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Guna2ComboBox2.SelectedIndexChanged
        If Guna2ComboBox2.Text = "تمرين صعب" Then
            Guna2TextBox5.Text = "30"
        ElseIf Guna2ComboBox2.Text = "تمرين متوسط" Then
            Guna2TextBox5.Text = "25"
        ElseIf Guna2ComboBox2.Text = "تمرين بسيط" Then
            Guna2TextBox5.Text = "18"
        End If
    End Sub
End Class