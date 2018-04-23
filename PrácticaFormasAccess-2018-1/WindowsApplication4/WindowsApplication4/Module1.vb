Module Module1
    Dim j As OleDb.OleDbConnection
    Dim ubic As String = "C:\Users\salaestudio\Downloads\PrácticaFormasAccess-2018-1"
    Structure libro
        Dim tit As String
        Dim aut As String
        Dim pre As String
        Dim copias As Integer
    End Structure
    Sub info_bd()
        Dim sent_SQL As String
        sent_SQL = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " & ubic & "\base2.mdb "
        j = New OleDb.OleDbConnection(sent_SQL)
    End Sub

    Sub grabar_datos()
        Dim e As libro
        Dim n As String
        Dim rs As OleDb.OleDbCommand
        e.tit = Form3.TextBox1.Text
        e.aut = Form3.TextBox2.Text
        e.pre = Form3.TextBox3.Text
        e.copias = Form3.TextBox4.Text
        j.Open()
        n = "insert into lib (titulo, autor, precio, copias) values ('" & e.tit & "', '" & e.aut & "', " & e.pre & ", " & e.copias & ")"
        rs = New OleDb.OleDbCommand(n, j)
        rs.ExecuteNonQuery()
        j.Close()
    End Sub
    Sub llenar_listas()
        Dim da As OleDb.OleDbDataAdapter
        Dim dt As DataTable
        Dim i As Integer
        Dim c1 As String
        Dim c2 As String
        Dim m As String
        Dim k As Integer

        c1 = "SELECT * from lib "
        c2 = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source= " & ubic & "\base2.mdb " & ";"
        da = New OleDb.OleDbDataAdapter(c1, c2)
        dt = New DataTable
        da.Fill(dt)
        i = dt.Rows.Count
        If i > 0 Then
            Form4.ListBox1.Items.Clear()
            Form4.ListBox2.Items.Clear()
            Form4.ListBox3.Items.Clear()
            For k = 0 To i - 1
                Form4.ListBox1.Items.Add(dt.Rows(k)("titulo").ToString())
                Form4.ListBox2.Items.Add(dt.Rows(k)("autor").ToString())
                Form4.ListBox3.Items.Add(dt.Rows(k)("precio").ToString())
            Next k
        End If
    End Sub
    Sub llenar_combo_f5()
        Dim da As OleDb.OleDbDataAdapter
        Dim dt As DataTable
        Dim i As Integer
        Dim c1 As String
        Dim c2 As String
        Dim m As String
        Dim k As Integer

        c1 = "SELECT titulo from lib "
        c2 = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source= " & ubic & "\base2.mdb " & ";"
        da = New OleDb.OleDbDataAdapter(c1, c2)
        dt = New DataTable
        da.Fill(dt)
        i = dt.Rows.Count
        If i > 0 Then
            Form5.ComboBox1.Items.Clear()
            For k = 0 To i - 1
                Form5.ComboBox1.Items.Add(dt.Rows(k)("titulo").ToString())
            Next k
        End If
    End Sub
    Sub buscar_libro()
        Dim da As OleDb.OleDbDataAdapter
        Dim dt As DataTable
        Dim i As Integer
        Dim c1 As String
        Dim c2 As String
        Dim m As String
        Dim k As Integer
        m = Form5.ComboBox1.SelectedItem
        c1 = "SELECT * from lib where titulo = '" & m & "'"
        c2 = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source= " & ubic & "\base2.mdb " & ";"
        da = New OleDb.OleDbDataAdapter(c1, c2)
        dt = New DataTable
        da.Fill(dt)
        i = dt.Rows.Count
        If i > 0 Then
            Form5.Label7.Text = dt.Rows(k)("autor").ToString()
            Form5.Label8.Text = dt.Rows(k)("precio").ToString()
            Form5.Label9.Text = dt.Rows(k)("copias").ToString()
            Form5.Label10.Text = dt.Rows(k)("Id").ToString()
        End If
    End Sub
    Sub llenar_combo_f7()
        Dim da As OleDb.OleDbDataAdapter
        Dim dt As DataTable
        Dim i As Integer
        Dim c1 As String
        Dim c2 As String
        Dim m As String
        Dim k As Integer

        c1 = "SELECT titulo from lib "
        c2 = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source= " & ubic & "\base2.mdb " & ";"
        da = New OleDb.OleDbDataAdapter(c1, c2)
        dt = New DataTable
        da.Fill(dt)
        i = dt.Rows.Count
        If i > 0 Then
            Form7.ComboBox1.Items.Clear()
            For k = 0 To i - 1
                Form7.ComboBox1.Items.Add(dt.Rows(k)("titulo").ToString())
            Next k
        End If
    End Sub
    Sub buscar_libro_f7()
        Dim da As OleDb.OleDbDataAdapter
        Dim dt As DataTable
        Dim i As Integer
        Dim c1 As String
        Dim c2 As String
        Dim m As String
        Dim k As Integer
        m = Form7.ComboBox1.SelectedItem
        c1 = "SELECT * from lib where titulo = '" & m & "'"
        c2 = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source= " & ubic & "\base2.mdb " & ";"
        da = New OleDb.OleDbDataAdapter(c1, c2)
        dt = New DataTable
        da.Fill(dt)
        i = dt.Rows.Count
        If i > 0 Then
            Form7.Label5.Text = dt.Rows(k)("precio").ToString()
            Form7.Label7.Text = dt.Rows(k)("Id").ToString()
        End If
    End Sub
    Sub modificar()
        Dim a As Integer
        Dim b As Integer
        Dim c As String
        Dim rsc As OleDb.OleDbCommand
        a = Form7.Label7.Text
        b = Form7.TextBox1.Text
        j.Open()
        c = "update lib set precio = " & b & " where Id = " & a
        rsc = New OleDb.OleDbCommand(c, j)
        rsc.ExecuteNonQuery()
        j.Close()
    End Sub
End Module
