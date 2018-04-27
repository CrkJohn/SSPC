Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing.Imaging

Module Module1
    Dim ubic As String = "C:\Users\2127790\Downloads\SSPC"

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
    Sub llenar()
        Dim ds As New DataSet
        Dim dt As New DataTable
        Dim consultaSQL As String = "SELECT * FROM Animales"
        Dim conn As String = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source= " & ubic & "\Database11.mdb " & ";"
        Dim adp As New OleDb.OleDbDataAdapter(consultaSQL, conn)
        ds.Tables.Add("tabla")
        adp.Fill(ds.Tables("tabla"))
        Dim c As Integer = ds.Tables("tabla").Rows.Count
        If c > 0 Then
            Dim bytBLOBData() As Byte = ds.Tables("tabla").Rows(c - 1)("Imagen")
            Dim stmBLOBData As New MemoryStream(bytBLOBData)
            animales.pb.Image = Image.FromStream(stmBLOBData)
        End If
    End Sub





End Module
