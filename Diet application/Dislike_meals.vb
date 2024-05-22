Imports System.Data.SqlClient

Public Class Dislike_meals
    Private Sub Dislike_meals_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fillItemName("select * from Meals", Guna2ComboBox1)
        sql_Code()
    End Sub
    Private Sub grid_style()
        Guna2DataGridView1.Columns(0).Width = 14
        Guna2DataGridView1.Columns(1).Width = 36
        Guna2DataGridView1.Columns(2).Width = 25
        Guna2DataGridView1.Columns(3).Width = 20
        Guna2DataGridView1.Columns(4).Width = 220
    End Sub
    Private Sub sql_Code()
        Try
            Dim sql As String = "Select Dislike_id as '#',meal_name as 'اسم الوجبة',meal_type as 'نوع الوجبة',meal_desc as 'الوصف',Dislike_meals.createdate as 'تاريخ الاضافة' from Dislike_meals,Meals where Dislike_meals.meal_id=Meals.meal_id and user_id=" & Main.Label13.Text
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
    Private Sub fillItemName(sql As String, ItemName As ComboBox)
        ItemName.Items.Clear()
        Dim adp As New SqlClient.SqlDataAdapter(sql, cn)
        Dim ds As New DataSet
        adp.Fill(ds)
        Dim dt = ds.Tables(0)
        For i = 0 To dt.Rows.Count - 1
            ItemName.Items.Add(dt.Rows(i).Item("meal_name"))
        Next
    End Sub
    Public Sub FilterData(valueToSearch As String)
        If Guna2TextBox1.Text = "" Then
            sql_Code()
        Else
            Dim searchQuery As String = "Select Dislike_id as '#',meal_name as 'اسم الوجبة',meal_type as 'نوع الوجبة',meal_desc as 'الوصف',Dislike_meals.createdate as 'تاريخ الاضافة' from Dislike_meals,Meals where user_id='" & Main.Label13.Text & "' And Dislike_meals.meal_id=Meals.meal_id And CONCAT(meal_name,meal_desc) like '%" & valueToSearch & "%'"
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

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Guna2TextBox1.Clear()
        Guna2TextBox2.Clear()
        Guna2TextBox3.Clear()
        Guna2ComboBox1.Text = ""
    End Sub

    Private Sub Guna2CircleButton3_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton3.Click
        If Guna2TextBox2.Text = "" Then
        Else
            Try
                If MsgBox("هل انت متاكد من حذف هذا ؟ ", MessageBoxButtons.YesNo + MessageBoxIcon.Question, "تحذير !!") = DialogResult.Yes Then
                    'Delete Code
                    Dim DeleteQuery As String = "delete from Dislike_meals where Dislike_id='" & Guna2TextBox2.Text & "'"
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

    Private Sub Guna2CircleButton1_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton1.Click
        If Guna2TextBox3.Text = "" Then
            MsgBox("أملئ البيانات اولاً", MsgBoxStyle.Question)
        Else
            Try
                Dim max As Integer
                Try
                    Dim sql2 As String = "Select max(Dislike_id) from Dislike_meals"
                    Dim command As New SqlCommand(sql2, cn)
                    cn.Open()
                    max = 1 + Val(command.ExecuteScalar().ToString())
                    cn.Close()
                Catch ex As Exception
                Finally
                    cn.Close()
                End Try
                Dim sql As String = "INSERT INTO Dislike_meals (Dislike_id,meal_id,user_id)  " _
        & "VALUES ('" & max & "','" & Guna2TextBox3.Text & "','" & Main.Label13.Text & "')"
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
            Dim sql As String = "update Dislike_meals set meal_id='" & Guna2TextBox3.Text & "' where Dislike_id='" & Guna2TextBox2.Text & "'"
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

    Private Sub Guna2DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DataGridView1.CellClick
        Guna2Button1.PerformClick()
        Guna2TextBox2.Text = Guna2DataGridView1.CurrentRow.Cells(0).Value.ToString()
        Guna2ComboBox1.Text = Guna2DataGridView1.CurrentRow.Cells(1).Value.ToString()
    End Sub

    Private Sub Guna2ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Guna2ComboBox1.SelectedIndexChanged
        If (Guna2ComboBox1.Text = "") Then
        Else
            Try
                Dim sql2 As String = "Select meal_id From Meals WHERE meal_name='" & Guna2ComboBox1.Text & "'"
                Dim command As New SqlCommand(sql2, cn)
                cn.Open()
                Guna2TextBox3.Text = command.ExecuteScalar().ToString()
                cn.Close()
            Catch ex As Exception
                'MsgBox("Not Found !!", MsgBoxStyle.Critical)
            Finally
                cn.Close()
            End Try
        End If
    End Sub

    Private Sub Dislike_meals_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Main.Guna2TileButton7.PerformClick()
    End Sub
End Class