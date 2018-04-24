Public Class Form2

    Dim screenWidth As Integer = Screen.PrimaryScreen.Bounds.Width
    Dim screenHeight As Integer = Screen.PrimaryScreen.Bounds.Height
    Dim sizeScreenFrame As Size = New Size(626, 456)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MaximumSize = sizeScreenFrame
        Me.MinimumSize = sizeScreenFrame
        Me.MaximizeBox = False
        Me.MinimizeBox = False
    End Sub

    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        Me.Hide()
        'Form3.show()'
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        Me.Hide()
        'Form4.show()'
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Application.ExitThread()
    End Sub
End Class