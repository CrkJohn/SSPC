Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        If RadioButton1.Checked = True Then
            Form3.Show()
        Else
            If RadioButton2.Checked = True Then
                Call llenar_listas
                Form4.Show()
            Else
                If RadioButton3.Checked = True Then
                    Call llenar_combo_f5
                    Form5.Show()
                Else
                    If RadioButton4.Checked = True Then
                        ' call llenar_combo_f6
                        Form6.Show()
                    Else
                        If RadioButton5.Checked = True Then
                            Call llenar_combo_f7()
                            Form7.Show()
                        Else
                            If RadioButton6.Checked = True Then
                                End
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub
End Class