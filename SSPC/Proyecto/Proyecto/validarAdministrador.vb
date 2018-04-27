Public Class validarAdministrador
    Dim screenWidth As Integer = Screen.PrimaryScreen.Bounds.Width
    Dim screenHeight As Integer = Screen.PrimaryScreen.Bounds.Height
    Dim sizeScreenFrame As Size = New Size(626, 456)
    Dim intentos As Integer
    Private Sub validarAdministrador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MaximumSize = sizeScreenFrame
        Me.MinimumSize = sizeScreenFrame
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        intentos = 0
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If validarAdministrador_mod() Then
            Me.Hide()
            Administrador.Show()
        ElseIf (intentos.Equals(3)) Then
            MsgBox("No se pudo ingresar su admin")
            Me.Hide()
            Form2.Show()
        End If
        intentos += 1




    End Sub
End Class