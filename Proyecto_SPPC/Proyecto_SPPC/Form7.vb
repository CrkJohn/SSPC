Public Class Form7
    Private Sub TFormulaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TFormulaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TFormulaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BD_ProyectoDataSet)

    End Sub

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_ProyectoDataSet.TFormula' Puede moverla o quitarla según sea necesario.
        Me.TFormulaTableAdapter.Fill(Me.BD_ProyectoDataSet.TFormula)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" And TextBox2.Text = "" And TextBox3.Text = "" And TextBox4.Text = "" And TextBox5.Text = "" Then
            MsgBox("INGRESE TODOS LOS CAMPOS")
        Else

            Me.TFormulaTableAdapter.Insert(TFormulaComboBox.Text, TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, NumericUpDown1.Value)
            Me.TFormulaTableAdapter.Fill(Me.BD_ProyectoDataSet.TFormula)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form2.Show()
    End Sub
End Class