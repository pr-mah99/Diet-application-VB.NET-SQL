Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports Guna.UI2.WinForms

Public Class Meals_course
    Private Sub sql_Code(type As String)
        Try
            ' تفريغ FlowLayoutPanel من الأزرار الحالية
            FlowLayoutPanel1.Controls.Clear()

            'Panel1.Location = New Point(349, 12)
            'Panel1.Size = New Size(1020, 358)
            'Panel1.BorderStyle = BorderStyle.FixedSingle           

            '1. جلب البيانات من جدول البيانات المطلوب
            Dim sql As String = ""
            If type = "search" Then
                sql = "Select * from Meals_course where CONCAT(title,descr) like '%" & Guna2TextBox1.Text.ToString & "%'"
            ElseIf type = "get" Then
                sql = "SELECT * FROM Meals_course"
            End If

            '2. فتح الاتصال بقاعدة البيانات
            cn.Open()

            Dim adapter As New SqlDataAdapter(sql, cn)
            Dim dt As New DataTable()
            adapter.Fill(dt)

            Dim x = 10, y = 10

            FlowLayoutPanel1.FlowDirection = FlowDirection.TopDown
            FlowLayoutPanel1.WrapContents = True
            FlowLayoutPanel1.AutoScroll = True

            '3. إنشاء زر (Button) لكل سجل في الجدول وتعيين الخصائص الخاصة به
            For Each row As DataRow In dt.Rows
                Dim btn As New Guna2TileButton()
                btn.Font = New Font("Tajawal", 12, FontStyle.Bold)
                btn.FillColor = Color.Teal
                btn.Cursor = Cursors.Hand
                btn.Animated = True
                btn.Text = row("title").ToString()
                btn.Size = New Size(250, 250)
                btn.Image = My.Resources.icons8_bowl_with_spoon_150px
                btn.ImageSize = New Size(80, 80)


                btn.Location = New Point(x, y + (dt.Rows.IndexOf(row) * 60))


                '4. التعامل مع حدث النقر (Click) على الزر
                AddHandler btn.Click, Sub(sender As Object, e As EventArgs)
                                          'الإجراء الذي يجري عند النقر على الزر
                                          'يمكن استخدام قيمة btn.Text لتحديد الإجراء الصحيح

                                          Dim descr As String = row("descr").ToString()

                                          'MessageBox.Show(title)                                  

                                          Dim f As New Meals_course_Details
                                          f.RichTextBox1.Text = descr
                                          f.ShowDialog()

                                      End Sub
                '5. إضافة الزر
                FlowLayoutPanel1.Controls.Add(btn)
            Next
        Catch ex As Exception
            'MsgBox(ex.Message)
        Finally
            cn.Close()
        End Try

    End Sub
    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox1.TextChanged
        If Guna2TextBox1.Text = "" Then
            sql_Code("get")
        Else
            sql_Code("search")
        End If
    End Sub
End Class