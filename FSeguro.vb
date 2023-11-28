Imports System.Data.SqlClient
Imports System.Security.Cryptography

Public Class FSeguro
    Inherits Conexion

    Public Function insertar_seguros(cod As String, nom As String, des As String, pre As Decimal, codusr As Integer) As Boolean
        conectado()
        cmd = New SqlCommand("insertar_seguros", ccn)
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.AddWithValue("@cod_Seguro", cod)
        cmd.Parameters.AddWithValue("@nombre", nom)
        cmd.Parameters.AddWithValue("@descripcion", des)
        cmd.Parameters.AddWithValue("@Precio", pre)

        cmd.Parameters.AddWithValue("@cod_usuario", codusr)


        If (cmd.ExecuteNonQuery) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function edita_Seguros(cod As String, nom As String, des As String, pre As Decimal, codusr As Integer) As Boolean
        conectado()
        cmd = New SqlCommand("edita_Seguros", ccn)
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.AddWithValue("@cod_Seguro", cod)
        cmd.Parameters.AddWithValue("@nombre", nom)
        cmd.Parameters.AddWithValue("@descripcion", des)
        cmd.Parameters.AddWithValue("@Precio", pre)
        cmd.Parameters.AddWithValue("@cod_usuario", codusr)


        If (cmd.ExecuteNonQuery) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function eliminar_Seguros(cod As String) As Boolean
        conectado()
        cmd = New SqlCommand("eliminar_Seguros", ccn)
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.AddWithValue("@cod_Seguro", cod)

        If (cmd.ExecuteNonQuery) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function mostrar_seguros() As DataTable
        conectado()
        cmd = New SqlCommand("mostrar_seguros", ccn)
        cmd.CommandType = CommandType.StoredProcedure

        Dim dt As New DataTable
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        Return dt
    End Function

    Public Function buscar_Seguros(txtbus As String) As DataTable
        conectado()
        cmd = New SqlCommand("buscar_Seguros", ccn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@texto", txtbus)
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        Return dt
    End Function
End Class
