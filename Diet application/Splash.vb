Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Splash
    Dim x As Integer
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        x = Val(x) + 1
        If x = 1 Then
            Guna2CircleProgressBar1.Value = 12
        ElseIf x = 2 Then
            Guna2CircleProgressBar1.Value = 34
            Label2.Visible = True
        ElseIf x = 3 Then
            Guna2CircleProgressBar1.Value = 89
        ElseIf x = 4 Then
            Guna2CircleProgressBar1.Value = 100
        ElseIf x = 5 Then
            Login.Show()
            Me.Close()
        End If
    End Sub
End Class
