Imports System.Data.SqlClient

Public Class Tips
    Private Sub grid_style()
        Guna2DataGridView1.Columns(0).Width = 34
        Guna2DataGridView1.Columns(1).Width = 174
        Guna2DataGridView1.Columns(2).Width = 1190
        Guna2DataGridView1.Columns(4).Width = 50
    End Sub
    Private Sub sql_Code()
        Try
            Dim sql As String = "Select tips_id as '#',tips_title as 'العنوان',tips_decre as 'الوصف',tips_datecreate as 'تاريخ النشر' from Tips order by tips_datecreate DESC"
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
    Private Sub Tips_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sql_Code()
    End Sub
End Class