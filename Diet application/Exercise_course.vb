Imports System.Data.SqlClient

Public Class Exercise_course
    Private Sub grid_style()
        Guna2DataGridView1.Columns(0).Width = 12
        Guna2DataGridView1.Columns(1).Width = 40
        Guna2DataGridView1.Columns(2).Width = 40
        Guna2DataGridView1.Columns(3).Width = 40
        Guna2DataGridView1.Columns(4).Width = 140
    End Sub
    Private Sub sql_Code()
        Dim bmi_value As String
        Try
            Dim bmi As String = ""
            Dim sql As SqlCommand = New SqlCommand("Select bmi from Information where user_id='" + Main.Label13.Text + "'", cn)
            cn.Open()
            Dim reader As SqlDataReader = sql.ExecuteReader
            reader.Read()
            If reader.HasRows Then
                bmi = reader(0).ToString
                cn.Close()
            End If
            bmi_value = bmi
        Catch ex As Exception
            bmi_value = "0"
            'MsgBox(ex.Message)
        Finally
            cn.Close()
        End Try
        '-------------
        Try
            Dim sql As String = ""
            If bmi_value = "0" Then
                sql = "Select id as '#',title as 'عنوان التمرين',body as 'جزء الجسم',weekly as 'تكرار',date as 'تاريخ الاضافة' from Exercise_course"
            Else
                sql = "Select id as '#',title as 'عنوان التمرين',body as 'جزء الجسم',weekly as 'تكرار',date as 'تاريخ الاضافة' from Exercise_course where bmi>='" & bmi_value & "'"
            End If

            Dim dataadapter As New SqlDataAdapter(sql, cn)
            Dim ds As New DataSet()
            cn.Open()
            dataadapter.Fill(ds, "column_name")
            cn.Close()
            Guna2DataGridView1.DataSource = ds
            Guna2DataGridView1.DataMember = "column_name"
            grid_style()
        Catch ex As Exception
            'MsgBox(ex.Message)
        Finally
            cn.Close()
        End Try
    End Sub
    Private Sub Exercise_course_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
End Class