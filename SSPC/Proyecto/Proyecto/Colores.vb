Public Class Colores


    Dim puntaje As Integer
    Dim jugador As String
    Dim respuesta As String
    Dim screenWidth As Integer = Screen.PrimaryScreen.Bounds.Width
    Dim screenHeight As Integer = Screen.PrimaryScreen.Bounds.Height
    Dim sizeScreenFrame As Size = New Size(626, 456)
    Dim Aciertos As Integer

    Private Sub Colores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackgroundImage = System.Drawing.Image.FromFile("C:\Users\leidy\Downloads\SSPC-master\SSPC\Imagenes\Base.jpg")
        Me.Label1.BackColor = Color.Transparent
        Me.Label2.BackColor = Color.Transparent
        Me.Label3.BackColor = Color.Transparent
        Aciertos = 0
        Me.MaximumSize = sizeScreenFrame
        Me.MinimumSize = sizeScreenFrame
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Label3.Text = "Puntaje de la actividad es " + Aciertos.ToString

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Call actualizacionPuntajeColores(Aciertos, jugador)
        Call actualizacionPuntaje(jugador)
        Aciertos = 0
        panelUsuario.Label2.Text = "Su promedio actual de actvidades es : " + promedio_mod(jugador)
        panelUsuario.Show()
    End Sub

    Sub newJugador(m)
        jugador = m
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Call reinicar("Colores")
    End Sub

    Sub setRespuesta(newRespuesta)
        respuesta = newRespuesta.ToString.ToLower
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If respuesta.Equals(Me.TextBox1.Text.ToLower) Then
            Call actualiarPuntajeJugador(jugador, "PuntajeActividad3")
            Me.TextBox1.Clear()
            Call reinicar("Colores")
            Aciertos = Aciertos + 1
            Me.Label3.Text = "Puntaje de la actividad es " + Aciertos.ToString()
        Else
            MsgBox("La respuesta es incorrecta", MsgBoxStyle.Information)
        End If
    End Sub
End Class