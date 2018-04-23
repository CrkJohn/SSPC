Public Class Form7
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call modificar()
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call buscar_libro_f7()
    End Sub
End Class