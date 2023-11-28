Imports System.Data.SqlClient

Public Class fusuario
    Inherits Conexion

    Public Function validar_usuario(us As String, pass As String) As DataTable
        conectado()
        cmd = New SqlCommand("validar_usuario", ccn)
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.AddWithValue("@usuario", us)
        cmd.Parameters.AddWithValue("@contraseña", pass)

        Dim dt As New DataTable
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        If dt.Rows.Count = 1 Then
            idUsuario = dt.Rows(0).Item("cod_usuario")
        End If
        Return dt

    End Function
    Public Function mostrar_usuario() As DataTable
        conectado()
        cmd = New SqlCommand("mostrar_usuario", ccn)
        cmd.CommandType = CommandType.StoredProcedure

        Dim dt As New DataTable
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        Return dt
    End Function

End Class
