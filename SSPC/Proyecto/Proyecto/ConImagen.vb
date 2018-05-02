
Module Module1

    Sub reinicar(actividad)
        Dim da As OleDb.OleDbDataAdapter
        Dim dt As DataTable
        Dim i As Integer
        Dim c1 As String
        Dim c2 As String
        Dim k As Integer
        c1 = "SELECT * from " & actividad & ""
        c2 = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source= " & ubic & "\Database11.mdb " & ";"
        da = New OleDb.OleDbDataAdapter(c1, c2)
        dt = New DataTable
        da.Fill(dt)
        i = dt.Rows.Count - 1
        Dim value As Integer = CInt(Int((i * Rnd())))
        If actividad.Equals("Animales") Then
            actividadAnimales.setRespuesta(dt.Rows(value)("nombreIngles").ToString())
            actividadAnimales.Label2.Text = "Cual  es el nombre de " & dt.Rows(value)("nombreEspanol").ToString() & " en ingles?"
            If dt.Rows(value)("nombreIngles").Equals("Dog") Or dt.Rows(value)("nombreIngles").Equals("cat") Then
                actividadAnimales.Box.Image = System.Drawing.Image.FromFile("C:\Users\leidy\Downloads\SSPC-master\SSPC\Imagenes\" & dt.Rows(value)("Imagen") & "")
            End If

        ElseIf actividad.Equals("Numeros") Then
            Numeros.setRespuesta(dt.Rows(value)("nombreIngles").ToString())
            Numeros.Label2.Text = "Como se escribe el  " & dt.Rows(value)("nombreEspanol").ToString() & " en ingles?"
        ElseIf actividad.Equals("Familia") Then
            Familia.setRespuesta(dt.Rows(value)("nombreIngles").ToString())
            Familia.Label2.Text = "Como se escribe el  " & dt.Rows(value)("nombreEspanol").ToString() & " en ingles?"
        ElseIf actividad.Equals("Frutas") Then
            Frutas.setRespuesta(dt.Rows(value)("nombreIngles").ToString())
            Frutas.Label2.Text = "Como se escribe el  " & dt.Rows(value)("nombreEspanol").ToString() & " en ingles?"
        ElseIf actividad.Equals("Colores") Then
            Colores.setRespuesta(dt.Rows(value)("nombreIngles").ToString())
            Colores.Label2.Text = "Como se escribe el  " & dt.Rows(value)("nombreEspanol").ToString() & " en ingles?"

        End If
    End Sub


End Module
