Public Class Form1
    Private Sub TUsuarioBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TUsuarioBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TUsuarioBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BD_ProyectoDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_ProyectoDataSet.TUsuario' Puede moverla o quitarla según sea necesario.
        Me.TUsuarioTableAdapter.Fill(Me.BD_ProyectoDataSet.TUsuario)
        Me.TUsuarioTableAdapter.Fill(Me.BD_ProyectoDataSet.TUsuario)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If TextBox1.Text = ClaveLabel1.Text Then

            Form2.Show()
            Me.Hide()
        Else
            MsgBox("CONTRASEÑA O USUARIO INCORRECTO")
        End If




    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.TUsuarioTableAdapter.Fill(Me.BD_ProyectoDataSet.TUsuario)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
        End
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Form3.Show()
    End Sub
End Class