Public Class Administrador
    Dim screenWidth As Integer = Screen.PrimaryScreen.Bounds.Width
    Dim screenHeight As Integer = Screen.PrimaryScreen.Bounds.Height
    Dim sizeScreenFrame As Size = New Size(626, 456)



    Private Sub Administrador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackgroundImage = System.Drawing.Image.FromFile("C:\Users\leidy\Downloads\SSPC-master\SSPC\Imagenes\Base.jpg")
        Me.Label1.BackColor = Color.Transparent
        Me.Label2.BackColor = Color.Transparent

        Me.MaximumSize = sizeScreenFrame
        Me.MinimumSize = sizeScreenFrame
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        CheckBox1.Refresh()
        CheckBox2.Refresh()
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        Me.Hide()
        Call llenarCombo()
        agregarPrueba.Show()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        Me.Hide()
        InformacionAdmistrador.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        panelIncial.Show()
    End Sub
End Class