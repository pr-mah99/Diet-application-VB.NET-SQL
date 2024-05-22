Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Guna.UI2.WinForms

Public Class Information
    Private Sub Guna2CircleButton2_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton2.Click
        Panel1.Visible = False
    End Sub

    Private Sub Guna2CircleButton3_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton3.Click
        Panel1.Visible = True
    End Sub

    Public bmi_value

    Private Sub Get_BMI()
        Dim x As Single
        If bmi_value = "" Then
        Else
            x = bmi_value
        End If
        Try
            If x = 0 Then
                Label5.Text = ""
            ElseIf x <= 18.5 Then
                Label5.Text = "Underweight(نحيف) = " & " يحتاج ان يزيد من وزنة "

            ElseIf x <= 25.0 Then
                Label5.Text = "Normal Weight(وزن طبيعي) = " & " لايحتاج ان يخسر من وزنة "

            ElseIf x < 30.0 Then
                Label5.Text = "Overweight(وزن زائد) = " & " يحتاج ان يخسر بعض الوزن "

            ElseIf x >= 30.0 Then
                Label5.Text = "Obesity(سمين) = " & " يحتاج ان يخسر الكثير  من الوزن "
            Else
                Label5.Text = "لاتوجد حالة الجسم"
            End If
        Catch ex As Exception
            MsgBox("خطا", "!!")
        End Try
    End Sub

    Private Sub Code_SQL()
        Try
            Dim fullname As String = "", username As String = "", Gender As String = "", lenght As String = "", width As String = "", bmi As String = "", width_requird As String = "", born As String = ""
            Dim sql As SqlCommand = New SqlCommand("Select fullname,username,Gender,Length,weight,bmi,required_weight,born from Users,Information where id_user=user_id and user_id='" + Main.Label13.Text + "'", cn)
            cn.Open()
            Dim reader As SqlDataReader = sql.ExecuteReader
            reader.Read()
            If reader.HasRows Then

                fullname = reader(0).ToString
                username = reader(1).ToString
                Gender = reader(2).ToString
                lenght = reader(3).ToString
                width = reader(4).ToString
                bmi = reader(5).ToString
                width_requird = reader(6).ToString
                born = reader(7).ToString

                cn.Close()
            End If
            Label1.Text = "أسم الكامل  : " + fullname
            Label2.Text = "أسم المستخدم  : " + username
            Label6.Text = "نوع الجنس  : " + Gender
            Label3.Text = "الطول  : " + lenght + " سم "
            Guna2TextBox1.Text = lenght
            Label4.Text = "الوزن  : " + width + " كيلو "
            Guna2TextBox2.Text = width
            Label7.Text = "BMI : " + bmi

            Label8.Text = "الوزن المطلوب  : " + width_requird + " كيلو "
            Guna2TextBox3.Text = width_requird
            Label9.Text = Convert.ToDateTime(born)
            Guna2DateTimePicker1.Value = born
            bmi_value = bmi
            Get_BMI()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cn.Close()
        End Try
    End Sub
    Private Sub Information_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Code_SQL()
    End Sub

    Private Sub Information_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Main.Guna2TileButton7.PerformClick()
    End Sub
    'دالة قياس كتلة الجسم
    Private Function BMI(Height As Single, Width As Single) As Double
        BMI = Width / Height ^ 2
    End Function
    Private Sub Guna2CircleButton1_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton1.Click
        'code bmi
        Dim a, b As Single
        a = Val(Guna2TextBox1.Text)
        b = Val(Guna2TextBox2.Text)
        Dim bmi_r = BMI(a, b)
        Try
            Dim sql As String = "update Information set Length='" & Guna2TextBox1.Text & "',weight='" & Guna2TextBox2.Text & "',required_weight='" & Guna2TextBox3.Text & "',born='" & Guna2DateTimePicker1.Value.ToShortDateString & "',bmi='" & bmi_r & "' where user_id='" & Main.Label13.Text & "'"
            Dim sda As New SqlDataAdapter(sql, cn)
            Dim cmd As New SqlCommand(sql, cn)
            cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
            MsgBox("تم تحديث البيانات بنجاح", MsgBoxStyle.Information, "!!")
            Code_SQL()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        Finally
            cn.Close()
        End Try
    End Sub
End Class