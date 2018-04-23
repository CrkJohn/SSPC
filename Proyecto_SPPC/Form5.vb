Public Class Form5
    Private Sub TFormulaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TFormulaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TFormulaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BD_ProyectoDataSet)

    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_ProyectoDataSet.TTema' Puede moverla o quitarla según sea necesario.
        Me.TTemaTableAdapter.Fill(Me.BD_ProyectoDataSet.TTema)
        'TODO: esta línea de código carga datos en la tabla 'BD_ProyectoDataSet.TMateria' Puede moverla o quitarla según sea necesario.
        Me.TMateriaTableAdapter.Fill(Me.BD_ProyectoDataSet.TMateria)
        'TODO: esta línea de código carga datos en la tabla 'BD_ProyectoDataSet.TFormula' Puede moverla o quitarla según sea necesario.
        Me.TFormulaTableAdapter.Fill(Me.BD_ProyectoDataSet.TFormula)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'If TemaComboBox.Text = "Derivadas" Then
        ''Me.Close()
        'Form6.Show()
        'End If
        Me.TFormulaTableAdapter.FillByTema(Me.BD_ProyectoDataSet.TFormula, TemaComboBox.Text)
        Me.Close()
        Form6.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Me.Close()
        Form2.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TTemaComboBox.Text = "Cálculo Diferencial" Then
            MateriaLabel1.Visible = True
            DescripciónTemaLabel1.Visible = True
            TemaComboBox.Visible = True
            Button2.Visible = True
            Me.TTemaTableAdapter.FillBymateria(Me.BD_ProyectoDataSet.TTema, TTemaComboBox.Text)
        End If


        If TTemaComboBox.Text = "Cálculo Integral" Then
            MateriaLabel1.Visible = True
            DescripciónTemaLabel1.Visible = True
            TemaComboBox.Visible = True
            Button2.Visible = True
            Me.TTemaTableAdapter.FillBymateria(Me.BD_ProyectoDataSet.TTema, TTemaComboBox.Text)
        End If


        If TTemaComboBox.Text = "Cálculo Vectorial" Then
            MateriaLabel1.Visible = True
            DescripciónTemaLabel1.Visible = True
            TemaComboBox.Visible = True
            Button2.Visible = True
            Me.TTemaTableAdapter.FillBymateria(Me.BD_ProyectoDataSet.TTema, TTemaComboBox.Text)
        End If

        If TTemaComboBox.Text = "Ecuaciones Diferenciales" Then
            MateriaLabel1.Visible = True
            DescripciónTemaLabel1.Visible = True
            TemaComboBox.Visible = True
            Button2.Visible = True
            Me.TTemaTableAdapter.FillBymateria(Me.BD_ProyectoDataSet.TTema, TTemaComboBox.Text)
        End If

    End Sub
End Class