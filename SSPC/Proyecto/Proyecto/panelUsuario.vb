Public Class panelUsuario

    Dim screenWidth As Integer = Screen.PrimaryScreen.Bounds.Width
    Dim screenHeight As Integer = Screen.PrimaryScreen.Bounds.Height
    Dim sizeScreenFrame As Size = New Size(626, 456)
    Dim intentos As Integer
    Dim usuario As String

    Private Sub panelUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackgroundImage = System.Drawing.Image.FromFile("C:\Users\leidy\Downloads\SSPC-master\SSPC\Imagenes\Base.jpg")
        Me.Label1.BackColor = Color.Transparent
        Me.Label2.BackColor = Color.Transparent
        Me.Label3.BackColor = Color.Transparent
        Me.ComboBox1.BackColor = Color.Transparent


        Call actualizacionPuntaje(usuario)
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
        ElseIf ComboBox1.SelectedItem.Equals("Numeros") Then
            Me.Hide()
            Numeros.newJugador(usuario)
            Numeros.Show()
        ElseIf ComboBox1.SelectedItem.Equals("Colores") Then
            Me.Hide()
            Colores.newJugador(usuario)
            Colores.Show()
        ElseIf ComboBox1.SelectedItem.Equals("Familia") Then
            Me.Hide()
            Familia.newJugador(usuario)
            Familia.Show()
        ElseIf ComboBox1.SelectedItem.Equals("Frutas") Then
            Me.Hide()
            Frutas.newJugador(usuario)
            Frutas.Show()
        End If
    End Sub
End Class