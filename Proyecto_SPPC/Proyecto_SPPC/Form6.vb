Public Class Form6
    Private Sub TFormulaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TFormulaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TFormulaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BD_ProyectoDataSet)
    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_ProyectoDataSet.TFormula' Puede moverla o quitarla según sea necesario.
        Me.TFormulaTableAdapter.Fill(Me.BD_ProyectoDataSet.TFormula)
    End Sub

    Private Sub TemaComboBox_SelectedIndexChanged(sender As Object, e As EventArgs)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Form5.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Form4.Show()
    End Sub
End Class