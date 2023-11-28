Imports System.Data.SqlClient

Public Class Conexion

    Protected ccn As New SqlConnection
    Protected cmd As New SqlCommand

    Public Sub conectado()
        ccn = New SqlConnection("Data Source=DESKTOP-6AIFGAG\SQLEXPRESS;Initial Catalog=RentaAcar;Integrated Security=True")
        ccn.Open()
    End Sub

End Class
