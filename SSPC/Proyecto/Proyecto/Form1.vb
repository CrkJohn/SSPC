Imports System

Public Class Form1
    Dim screenWidth As Integer = Screen.PrimaryScreen.Bounds.Width
    Dim screenHeight As Integer = Screen.PrimaryScreen.Bounds.Height
    Dim sizeScreen As Size = New Size(600, 420)
    Dim sizeScreenFrame As Size = New Size(615, 460)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.MaximumSize = sizeScreenFrame
        Me.MinimumSize = sizeScreenFrame
        Me.MaximizeBox = False
        Me.MinimizeBox = False


        bottomInicio.Size = sizeScreen
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles bottomInicio.Click
        Call info_bd()
        Me.Hide()
        panelIncial.Show()
    End Sub
End Class
