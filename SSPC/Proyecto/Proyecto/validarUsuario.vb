Public Class validarUsuario

    Dim screenWidth As Integer = Screen.PrimaryScreen.Bounds.Width
    Dim screenHeight As Integer = Screen.PrimaryScreen.Bounds.Height
    Dim sizeScreenFrame As Size = New Size(626, 456)
    Dim intentos As Integer

    Private Sub validarUsuario_load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MaximumSize = sizeScreenFrame
        Me.MinimumSize = sizeScreenFrame
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        intentos = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Usuario.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If validarUsuer_mod() Then
            Me.Hide()
            panelUsuario.setName(Me.TextBox1.Text)
            Call llenarComboUsuario()
            panelUsuario.Show()
        ElseIf (intentos.Equals(3)) Then
            MsgBox("No se pudo ingresar su admin")
            Me.Hide()
            panelIncial.Show()
        End If
        intentos += 1


    End Sub


End Class