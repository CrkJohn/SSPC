Public Class panelUsuario

    Dim screenWidth As Integer = Screen.PrimaryScreen.Bounds.Width
    Dim screenHeight As Integer = Screen.PrimaryScreen.Bounds.Height
    Dim sizeScreenFrame As Size = New Size(626, 456)
    Dim intentos As Integer
    Dim usuario As String

    Private Sub panelUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MaximumSize = sizeScreenFrame
        Me.MinimumSize = sizeScreenFrame
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.bv.Text = "Bienvenidio " + usuario
        Me.Label2.Text = "Su promedio actual de actvidades es : " + promedio_mod(usuario)
        intentos = 0
    End Sub

    Sub setName(a)
        usuario = a
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        panelIncial.Show()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ComboBox1.SelectedItem.Equals("Animales") Then
            Me.Hide()
            actividadAnimales.newJugador(usuario)
            actividadAnimales.Show()

        End If
    End Sub
End Class