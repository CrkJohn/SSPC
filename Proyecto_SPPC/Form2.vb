Public Class Form2
    Private Sub TMateriaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TMateriaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TMateriaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BD_ProyectoDataSet)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_ProyectoDataSet.TTema' Puede moverla o quitarla según sea necesario.
        Me.TTemaTableAdapter.Fill(Me.BD_ProyectoDataSet.TTema)
        'TODO: esta línea de código carga datos en la tabla 'BD_ProyectoDataSet.TMateria' Puede moverla o quitarla según sea necesario.
        Me.TMateriaTableAdapter.Fill(Me.BD_ProyectoDataSet.TMateria)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If TMateriaComboBox.Text = "Área Matemáticas" Then
            Me.Hide()
            Form5.Show()
        Else
            If TMateriaComboBox.Text = "Área Física" Then
                Me.Hide()
                Form8.Show()
            End If
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Form1.Show()

    End Sub
End Class