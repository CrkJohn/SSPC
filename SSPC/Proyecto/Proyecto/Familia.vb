Public Class Familia

    Dim puntaje As Integer
    Dim jugador As String
    Dim respuesta As String
    Dim aciertos As Integer
    Dim screenWidth As Integer = Screen.PrimaryScreen.Bounds.Width
    Dim screenHeight As Integer = Screen.PrimaryScreen.Bounds.Height
    Dim sizeScreenFrame As Size = New Size(626, 456)

    Private Sub Familia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackgroundImage = System.Drawing.Image.FromFile("C:\Users\leidy\Downloads\SSPC-master\SSPC\Imagenes\Base.jpg")
        Me.MaximumSize = sizeScreenFrame
        Me.MinimumSize = sizeScreenFrame
        Me.Label1.BackColor = Color.Transparent
        Me.Label2.BackColor = Color.Transparent
        Me.Label3.BackColor = Color.Transparent
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        aciertos = 0
        Me.Label3.Text = "Puntaje de Actividad " + aciertos.ToString()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Call actualizacionPuntajeFamilia(aciertos, jugador)
        Call actualizacionPuntaje(jugador)
        aciertos = 0
        panelUsuario.Label2.Text = "Su promedio actual de actvidades es : " + promedio_mod(jugador)
        panelUsuario.Show()
    End Sub

    Sub newJugador(m)
        jugador = m
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Call reinicar("Familia")
    End Sub

    Sub setRespuesta(newRespuesta)
        respuesta = newRespuesta.ToString.ToLower
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If respuesta.Equals(Me.TextBox1.Text.ToLower) Then
            Call actualiarPuntajeJugador(jugador, "PuntajeActividad4")
            Me.TextBox1.Clear()
            aciertos = aciertos + 1
            Me.Label3.Text = "Puntaje de Actividad " + aciertos.ToString()
            Call reinicar("Familia")
        Else
            MsgBox("Respuesta Inconrrecta", MsgBoxStyle.Information)
        End If
    End Sub
End Class