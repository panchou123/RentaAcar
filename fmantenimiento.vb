Imports System.Data.SqlClient

Public Class fmantenimiento
    Inherits Conexion

    Public Function ingresa_mantenimiento(cod As String, nom As String, ape As String, rf As String) As Boolean
        conectado()
        cmd = New SqlCommand("insertar_mantenimiento", ccn)
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.AddWithValue("@cod_mantenimiento", cod)
        cmd.Parameters.AddWithValue("@nombres", nom)
        cmd.Parameters.AddWithValue("@fecha_inicio", ape)
        cmd.Parameters.AddWithValue("@fecha_final", rf)


        If (cmd.ExecuteNonQuery) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function editar_mantenimiento(cod As String, nom As String, ape As String, rf As String) As Boolean
        conectado()
        cmd = New SqlCommand("editar_mantenimiento", ccn)
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.AddWithValue("@cod_mantenimiento", cod)
        cmd.Parameters.AddWithValue("@nombres", nom)
        cmd.Parameters.AddWithValue("@fecha_inicio", ape)
        cmd.Parameters.AddWithValue("@fecha_final", rf)

        If (cmd.ExecuteNonQuery) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function eliminar_mantenimiento(cod As String) As Boolean
        conectado()
        cmd = New SqlCommand("eliminar_mantenimiento", ccn)
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.AddWithValue("@cod_mantenimiento", cod)

        If (cmd.ExecuteNonQuery) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function mostrar_mantenimiento() As DataTable
        conectado()
        cmd = New SqlCommand("mostrar_mantenimiento", ccn)
        cmd.CommandType = CommandType.StoredProcedure

        Dim dt As New DataTable
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        Return dt
    End Function

    Public Function buscar_mantenimiento(txtbus As String) As DataTable
        conectado()
        cmd = New SqlCommand("buscar_mantenimiento", ccn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@texto", txtbus)
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        Return dt
    End Function
End Class
