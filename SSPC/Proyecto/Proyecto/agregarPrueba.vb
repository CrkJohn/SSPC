Public Class agregarPrueba

    Dim screenWidth As Integer = Screen.PrimaryScreen.Bounds.Width
    Dim screenHeight As Integer = Screen.PrimaryScreen.Bounds.Height
    Dim sizeScreenFrame As Size = New Size(626, 400)

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub agregarPrueba_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MaximumSize = sizeScreenFrame
        Me.MinimumSize = sizeScreenFrame
        Me.MaximizeBox = False
        Me.MinimizeBox = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Administrador.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Call registrarPrueba()
        Me.Hide()
        Administrador.Show()

    End Sub
End Class