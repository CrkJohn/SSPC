Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call info_bd()
        Me.Hide()
        Form2.Show()
    End Sub
End Class
