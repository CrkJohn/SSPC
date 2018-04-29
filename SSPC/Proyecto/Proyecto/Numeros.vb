Imports System

Public Class Numeros
    Dim screenWidth As Integer = Screen.PrimaryScreen.Bounds.Width
    Dim screenHeight As Integer = Screen.PrimaryScreen.Bounds.Height
    Dim sizeScreenFrame As Size = New Size(626, 456)
    Dim jugador As String
    Dim respuesta As String
    Dim aciertos As Integer
    Private Sub Numeros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackgroundImage = System.Drawing.Image.FromFile("C:\Users\leidy\Downloads\SSPC-master\SSPC\Imagenes\Base.jpg")
        Me.MaximumSize = sizeScreenFrame
        Me.MinimumSize = sizeScreenFrame
        Me.Label1.BackColor = Color.Transparent
        Me.Label2.BackColor = Color.Transparent
        Me.Label3.BackColor = Color.Transparent
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        aciertos = 0
        Me.Label3.Text = "Puntaje de la acitividad es " + aciertos.ToString

    End Sub

    Sub newJugador(usuario)
        jugador = usuario
    End Sub

    Sub setRespuesta(newRespuesta)
        respuesta = newRespuesta.ToString.ToLower
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If respuesta.Equals(Me.TextBox1.Text.ToLower) Then
            Call actualiarPuntajeJugador(jugador, "PuntajeActividad2")
            Me.TextBox1.Clear()
            Call reinicar("Numeros")
            aciertos = aciertos + 1
            Me.Label3.Text = "Puntaje de la acitividad es " + aciertos.ToString
        Else
            MsgBox("La repuesta es incorrecta", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Call reinicar("Numeros")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Call actuliazacionPuntajeNumero(aciertos, jugador)
        Call actualizacionPuntaje(jugador)
        panelUsuario.Label2.Text = "Su promedio actual de actvidades es : " + promedio_mod(jugador)
        panelUsuario.setName(jugador)
        aciertos = 0
        panelUsuario.Show()
    End Sub

End Class