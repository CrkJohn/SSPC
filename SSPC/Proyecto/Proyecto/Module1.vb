Module Module1
    Dim ubic As String = "C:\Users\2129082\Downloads\SSPC-master\SSPC-master\SSPC"

    Dim j As OleDb.OleDbConnection


    Sub info_bd()
        Dim sent_SQL As String
        sent_SQL = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " & ubic & "\Database11.mdb "
        j = New OleDb.OleDbConnection(sent_SQL)
    End Sub
    Sub llenar_inf()
        Dim ds As New DataSet
        Dim dt As New DataTable
        Dim consultaSQL As String = "SELECT * FROM InformacionBase"
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
        clave = validarAdministrador.TextBox2.Text
        c1 = "SELECT * from adminitradores where admin = '" & adminitrador & "' pass = " & clave & ""
        c2 = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source= " & ubic & "\base2.mdb " & ";"
        da = New OleDb.OleDbDataAdapter(c1, c2)
        dt = New DataTable
        Return dt.Rows.Count = 1
    End Function
End Module
