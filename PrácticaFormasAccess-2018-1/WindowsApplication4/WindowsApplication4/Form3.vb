Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call grabar_datos()
        Me.Hide()
        Form2.Show()
    End Sub
End Class