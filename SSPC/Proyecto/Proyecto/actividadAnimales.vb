Public Class actividadAnimales
    Dim puntaje As Integer
    Dim jugador As String
    Dim respuesta As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Call actualizacionPuntaje()
        panelUsuario.Show()
    End Sub

    Sub newJugador(m)
        jugador = m
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Call reinicar("Animales")
    End Sub

    Sub setRespuesta(newRespuesta)
        respuesta = newRespuesta
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If respuesta.Equals(Me.TextBox1.Text) Then
            MsgBox("Entre")
            Call actualiarPuntajeJugador(jugador)
            Me.TextBox1.Clear()
            Call reinicar("Animales")
            Call puntajeActividadGato(jugador)

        End If
    End Sub
End Class