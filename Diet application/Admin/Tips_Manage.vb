﻿Imports System.Data.SqlClient
Imports Guna.UI2.WinForms

Public Class Tips_Manage
    Private Sub grid_style()
        Guna2DataGridView1.Columns(0).Width = 12
        Guna2DataGridView1.Columns(1).Width = 20
        Guna2DataGridView1.Columns(2).Width = 40
        Guna2DataGridView1.Columns(3).Width = 140
    End Sub
    Private Sub sql_Code()
        Try
            Dim sql As String = "Select tips_id as '#',tips_title as 'الوصيفة',tips_decre as 'الوصف',tips_datecreate as 'تاريخ الاضافة' from Tips"
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
    Private Sub Tips_Manage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sql_Code()
    End Sub
    Public Sub FilterData(valueToSearch As String)
        If Guna2TextBox1.Text = "" Then
            sql_Code()
        Else
            Dim searchQuery As String = "Select tips_id as '#',tips_title as 'الوصيفة',tips_decre as 'الوصف',tips_datecreate as 'تاريخ الاضافة' from Tips where CONCAT(tips_title,tips_decre) like '%" & valueToSearch & "%'"
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
        Guna2TextBox4.Clear()
    End Sub

    Private Sub Guna2CircleButton1_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton1.Click
        If Guna2TextBox3.Text = "" Then
            MsgBox("أملئ البيانات اولاً", MsgBoxStyle.Question)
        Else
            Try
                Dim max As Integer
                Try
                    Dim sql2 As String = "Select max(tips_id) from Tips"
                    Dim command As New SqlCommand(sql2, cn)
                    cn.Open()
                    max = 1 + Val(command.ExecuteScalar().ToString())
                    cn.Close()
                Catch ex As Exception
                Finally
                    cn.Close()
                End Try
                Dim sql As String = "INSERT INTO Tips (tips_id,tips_title,tips_decre)  " _
        & "VALUES ('" & max & "','" & Guna2TextBox3.Text & "','" & Guna2TextBox4.Text & "')"
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
            Dim sql As String = "update Tips set tips_title='" & Guna2TextBox3.Text & "',tips_decre='" & Guna2TextBox4.Text & "' where tips_id='" & Guna2TextBox2.Text & "'"
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
                    Dim DeleteQuery As String = "delete from Tips where tips_id='" & Guna2TextBox2.Text & "'"
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
    End Sub
End Class