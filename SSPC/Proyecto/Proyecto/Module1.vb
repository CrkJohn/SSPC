
Module Module1
    Dim ubic As String = "C:\Users\leidy\Downloads\SSPC-master\SSPC"

    Dim j As OleDb.OleDbConnection


    Sub info_bd()
        Dim sent_SQL As String
        sent_SQL = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " & ubic & "\Database11.mdb "
        j = New OleDb.OleDbConnection(sent_SQL)
    End Sub
    Sub llenar_inf()
        Dim ds As New DataSet
        Dim dt As New DataTable
        Dim consultaSQL As String = "SELECT * FROM informacionBase"
        Dim conn As String = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source= " & ubic & "\Database11.mdb " & ";"
        Dim adp As New OleDb.OleDbDataAdapter(consultaSQL, conn)
        ds.Tables.Add("tabla")
        adp.Fill(ds.Tables("tabla"))
        InformacionAdmistrador.DataGridView1.DataSource = ds.Tables("Tabla")
    End Sub

    Function validarAdministrador_mod()
        Dim da As OleDb.OleDbDataAdapter
        Dim dt As DataTable

        Dim i As Integer
        Dim c1 As String
        Dim c2 As String
        Dim adminitrador As String
        Dim clave As Integer
        adminitrador = validarAdministrador.TextBox1.Text
        clave = Integer.Parse(validarAdministrador.TextBox2.Text)
        c1 = "Select  * From adminitradores Where Admin = '" & adminitrador & "' and pass = " & clave & ""
        c2 = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source= " & ubic & "\Database11.mdb " & ";"
        da = New OleDb.OleDbDataAdapter(c1, c2)
        dt = New DataTable
        da.Fill(dt)
        i = dt.Rows.Count
        If i > 0 Then
            MsgBox(dt.Rows(0)("Admin").ToString)
            Return dt.Rows(0)("Admin").ToString.Equals(adminitrador) And dt.Rows(0)("pass").Equals(clave)
        Else
            Return False
        End If
    End Function


    Function promedio_mod(m)
        Dim da As OleDb.OleDbDataAdapter
        Dim dt As DataTable
        Dim c1 As String
        Dim c2 As String
        c1 = "Select  promedio From  informacionBase Where Usuario = '" & m & "'"
        c2 = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source= " & ubic & "\Database11.mdb " & ";"
        da = New OleDb.OleDbDataAdapter(c1, c2)
        dt = New DataTable
        da.Fill(dt)
        Return dt.Rows(0)("Promedio").ToString
    End Function



    Function validarUsuer_mod()
        Dim da As OleDb.OleDbDataAdapter
        Dim dt As DataTable
        Dim i As Integer
        Dim c1 As String
        Dim c2 As String
        Dim Usuario As String
        Dim clave As Integer
        Usuario = validarUsuario.TextBox1.Text
        clave = Integer.Parse(validarUsuario.TextBox2.Text)
        c1 = "Select  * From Usuarios Where Usuario = '" & Usuario & "' and pass = " & clave & ""
        c2 = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source= " & ubic & "\Database11.mdb " & ";"
        da = New OleDb.OleDbDataAdapter(c1, c2)
        dt = New DataTable
        da.Fill(dt)
        i = dt.Rows.Count
        If i > 0 Then
            MsgBox(dt.Rows(0)("Usuario").ToString)
            Return dt.Rows(0)("Usuario").ToString.Equals(Usuario) And dt.Rows(0)("pass").Equals(clave)
        Else
            Return False
        End If


    End Function

    Sub registrar()
        Dim usuario As String
        Dim pass As Integer
        Dim nombre As String
        Dim apellido As String
        Dim Telefono As Integer
        Dim rs As OleDb.OleDbCommand
        usuario = registrarNuevoUsuario.TextBox1.Text
        pass = Integer.Parse(registrarNuevoUsuario.TextBox2.Text)
        nombre = registrarNuevoUsuario.TextBox3.Text
        apellido = registrarNuevoUsuario.TextBox4.Text
        Telefono = Integer.Parse(registrarNuevoUsuario.TextBox5.Text)
        j.Open()
        Dim n As String = "INSERT INTO Usuarios (usuario, pass, nombre, apellidos,telefono) 
         VALUES ('" & usuario & "', " & pass & ", '" & nombre & "', '" & apellido & "', " & Telefono & ")"
        rs = New OleDb.OleDbCommand(n, j)
        rs.ExecuteNonQuery()
        j.Close()
    End Sub

    Sub registrarPrueba()
        Dim usuario As String
        Dim nombreEspanol As String = agregarPrueba.TextBox1.Text
        Dim nombreIngles As String = agregarPrueba.TextBox2.Text

        Dim rs As OleDb.OleDbCommand
        j.Open()
        Dim n As String = "INSERT INTO " & agregarPrueba.ComboBox1.SelectedItem & " 
                                        (nombreEspanol,nombreIngles, imagen) 
         VALUES ('" & nombreEspanol & "', '" & nombreIngles & "', null )"
        rs = New OleDb.OleDbCommand(n, j)
        rs.ExecuteNonQuery()
        j.Close()
    End Sub

    Sub llenarCombo()
        Dim da As OleDb.OleDbDataAdapter
        Dim dt As DataTable
        Dim i As Integer
        Dim c1 As String
        Dim c2 As String
        Dim k As Integer
        c1 = "SELECT * from TablasBase "
        c2 = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source= " & ubic & "\Database11.mdb " & ";"
        da = New OleDb.OleDbDataAdapter(c1, c2)
        dt = New DataTable
        da.Fill(dt)
        i = dt.Rows.Count
        If i > 0 Then
            agregarPrueba.ComboBox1.Items.Clear()
            For k = 0 To i - 1
                agregarPrueba.ComboBox1.Items.Add(dt.Rows(k)("Tablas").ToString())
            Next k
        End If
    End Sub

    Sub llenarComboUsuario()
        Dim da As OleDb.OleDbDataAdapter
        Dim dt As DataTable
        Dim i As Integer
        Dim c1 As String
        Dim c2 As String
        Dim k As Integer
        c1 = "SELECT * from TablasBase "
        c2 = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source= " & ubic & "\Database11.mdb " & ";"
        da = New OleDb.OleDbDataAdapter(c1, c2)
        dt = New DataTable
        da.Fill(dt)
        i = dt.Rows.Count
        If i > 0 Then
            panelUsuario.ComboBox1.Items.Clear()
            For k = 0 To i - 1
                panelUsuario.ComboBox1.Items.Add(dt.Rows(k)("Tablas").ToString())
            Next k
        End If
    End Sub

    Sub actualizacionPuntaje()

    End Sub


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
        actividadAnimales.setRespuesta(dt.Rows(value)("nombreIngles").ToString())
        actividadAnimales.Label2.Text = "Cual  es el nombre de " & dt.Rows(value)("nombreEspanol").ToString() & " en ingles?"
    End Sub

    Sub actualiarPuntajeJugador(JUGADOR)
        Dim a As Integer
        Dim b As Integer
        Dim c As String
        Dim rsc As OleDb.OleDbCommand
        j.Open()
        c = "update informacionBase set PuntajeActividad1 = PuntajeActividad1 + 1 
              WHERE usuario = '" & JUGADOR & "'"
        rsc = New OleDb.OleDbCommand(c, j)
        rsc.ExecuteNonQuery()
        j.Close()

    End Sub
    Sub puntajeActividadGato(jugador)
        Dim da As OleDb.OleDbDataAdapter
        Dim dt As DataTable
        Dim i As Integer
        Dim c1 As String
        Dim c2 As String
        Dim k As Integer
        c1 = "SELECT * from informacionBase Where usuario = '" & jugador & "'"
        c2 = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source= " & ubic & "\Database11.mdb " & ";"
        da = New OleDb.OleDbDataAdapter(c1, c2)
        dt = New DataTable
        da.Fill(dt)
        i = dt.Rows.Count
        MsgBox(i)

        If i > 0 Then
            actividadAnimales.Label3.Text = "Puntaje de Actividad " & dt.Rows(i - 1)("PuntajeActividad1").ToString()
        End If
    End Sub
End Module
