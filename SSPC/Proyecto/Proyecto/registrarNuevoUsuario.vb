Public Class registrarNuevoUsuario

    Dim screenWidth As Integer = Screen.PrimaryScreen.Bounds.Width
    Dim screenHeight As Integer = Screen.PrimaryScreen.Bounds.Height
    Dim sizeScreenFrame As Size = New Size(626, 456)
    Private Sub registrarNuevoUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MaximumSize = sizeScreenFrame
        Me.MinimumSize = sizeScreenFrame
        Me.MaximizeBox = False
        Me.MinimizeBox = False

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        panelIncial.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call registrar()
        MsgBox("Se ha registrado")
        Me.Hide()
        Usuario.Show()
    End Sub
End Class