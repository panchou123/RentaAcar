Public Class GenerarFactura
    Dim dtcliente As New DataTable
    Dim dtventas As New DataTable
    Dim daventas As New DataTable


    Private Sub GenerarFactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar_clientes()
        ver_ventas()
        verr_ventas()
    End Sub
    Sub verr_ventas()
        Dim fa As New Fventa
        daventas = fa.verr_ventas()
        DataGridView1.DataSource = daventas
    End Sub
    Sub mostrar_clientes()
        Dim fc As New Fcliente
        dtcliente = fc.mostrar_cliente()
        dgvcliente.DataSource = dtcliente
    End Sub

    Sub ver_ventas()
        Dim fv As New Fventa
        dtventas = fv.ver_ventas()
        Dgventas.DataSource = dtventas
    End Sub

    Private Sub dgvcliente_DoubleClick(sender As Object, e As EventArgs) Handles dgvcliente.DoubleClick
        txtcodigo.Text = dgvcliente.CurrentRow.Cells("cod_cliente").Value
        txtnombre.Text = dgvcliente.CurrentRow.Cells("nombres").Value
        txtapellidos.Text = dgvcliente.CurrentRow.Cells("apellidos").Value
        txtdni.Text = dgvcliente.CurrentRow.Cells("rfc").Value
        txtdireccion.Text = dgvcliente.CurrentRow.Cells("direccion").Value
        txttelefono.Text = dgvcliente.CurrentRow.Cells("telefono").Value

    End Sub



    Private Sub btnfacturar_Click(sender As Object, e As EventArgs) Handles btnfacturar.Click
        Abrir()
        Dim apellidos As String = txtapellidos.Text
        Dim nombre As String = txtnombre.Text
        Hoja.Cells(4, 4).Value = txtFecha.Text
        Hoja.Cells(8, 2).Value = nombre & "  " & apellidos
        Hoja.Cells(9, 2).Value = txtdni.Text
        Hoja.Cells(12, 4).Value = txtGanancia.Text
        Hoja.Cells(7, 4).Value = txtDocumento.Text
        Hoja.Cells(10, 2).Value = txtcodigo.Text
    End Sub



    Private Sub FormVenta_Deactivate(sender As Object, e As EventArgs) Handles MyBase.Deactivate
        ' Check if the mouse is outside the form's bounds
        If Not Me.Bounds.Contains(Cursor.Position) Then
            Me.Close()
        End If
    End Sub

    Private Sub Dgventas_DoubleClick(sender As Object, e As EventArgs) Handles Dgventas.DoubleClick
        txtDocumento.Text = Dgventas.CurrentRow.Cells("Numero de Documento").Value
        txtFecha.Text = Dgventas.CurrentRow.Cells("fecha").Value
        txtGanancia.Text = Dgventas.CurrentRow.Cells("Ganancia").Value
    End Sub
End Class