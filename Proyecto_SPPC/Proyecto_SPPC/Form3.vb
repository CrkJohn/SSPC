Public Class Form3
    Private Sub TUsuarioBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TUsuarioBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TUsuarioBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BD_ProyectoDataSet)

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_ProyectoDataSet.TUsuario' Puede moverla o quitarla según sea necesario.
        Me.TUsuarioTableAdapter.Fill(Me.BD_ProyectoDataSet.TUsuario)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.TUsuarioTableAdapter.Fill(Me.BD_ProyectoDataSet.TUsuario)
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or ComboBox1.Text = "" Then
            MsgBox("NO ES POSIBLE COMPLETAR EL REGISTRO, DEBE COMPLETAR TODOS LOS DATOS")
        Else
            Me.TUsuarioTableAdapter.Insert(TextBox1.Text, TextBox2.Text, TextBox3.Text, ComboBox1.Text, Now)
            MsgBox("USUARIO REGISTRADO")
            Me.TUsuarioTableAdapter.Fill(Me.BD_ProyectoDataSet.TUsuario)
        End If
    End Sub

    Private Sub TUsuarioDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles TUsuarioDataGridView.CellContentClick

    End Sub
End Class