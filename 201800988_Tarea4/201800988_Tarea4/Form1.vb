Public Class Form1
    Private Sub Boton1_Click(sender As Object, e As EventArgs) Handles Boton1.Click
        Dim num, i, factorial As Integer
        num = CInt(Texto1.Text)
        factorial = 1
        For i = 1 To num
            factorial = factorial * i
        Next
        Texto2.Text = factorial
    End Sub

    Private Sub Boton2_Click(sender As Object, e As EventArgs) Handles Boton2.Click
        Texto1.Text = ""
        Texto2.Text = ""
    End Sub

    Private Sub Link1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Link1.LinkClicked
        Process.Start("https://github.com/Sebsgabriel0604/201800988_Tarea4")
    End Sub
End Class
