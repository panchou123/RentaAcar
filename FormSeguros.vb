Public Class FormSeguros
    Dim dtusuarios As DataTable
    Dim dtseguro As DataTable

    Private Sub FormSeguro_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        bloqueacajas(False)
        mostrar_seguro()
        limpiar()


    End Sub

    Public Sub mostrar_seguro()
        Dim c As New FSeguro
        dtseguro = c.mostrar_seguros
        dgvseguro.DataSource = dtseguro


    End Sub

    Sub nuevo()
        btncancelar.Enabled = True
        btnguardar.Enabled = True
        limpiar()
        bloqueacajas(True)
    End Sub

    Sub limpiar()
        txtcodigo.Clear()
        txtnombre.Clear()
        Txtdescripcion.Clear()
        txtprecio.Clear()

    End Sub

    Sub cancelar()
        btnnuevo.Enabled = True
        btnguardar.Enabled = False
        btneliminar.Enabled = False
        btncancelar.Enabled = False
        btnmodificar.Enabled = False
        limpiar()
        bloqueacajas(False)
    End Sub

    Sub bloqueacajas(va As Boolean)
        txtnombre.Enabled = va
        Txtdescripcion.Enabled = va
        txtprecio.Enabled = va



    End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        nuevo()
    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        cancelar()
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Dim c As New FSeguro
        If (txtnombre.Text <> String.Empty And txtprecio.Text <> String.Empty And Txtdescripcion.Text <> String.Empty) Then

            Try
                If (txtcodigo.Text <> String.Empty) Then

                    If (c.edita_Seguros(txtcodigo.Text, txtnombre.Text, Txtdescripcion.Text, txtprecio.Text, idUsuario) = True) Then
                        MessageBox.Show("Seguro editado Correctamente", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        cancelar()
                        mostrar_seguro()
                    Else
                        MessageBox.Show("Error al Modificar el Seguro")
                    End If
                Else

                    If (c.insertar_seguros(txtcodigo.Text, txtnombre.Text, Txtdescripcion.Text, txtprecio.Text, idUsuario) = True) Then
                        MessageBox.Show("Error al registrar el Seguro")
                    End If
                End If
            Catch ex As Exception
                MessageBox.Show("Verifique si el precio esta bien escrito ejemplo: 5,10", "Datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try



        Else
            MessageBox.Show("Complete todos los datos")
        End If

    End Sub

    Private Sub dgvseguro_DoubleClick(sender As Object, e As EventArgs) Handles dgvseguro.DoubleClick
        txtcodigo.Text = dgvseguro.CurrentRow.Cells("cod_seguro").Value
        txtnombre.Text = dgvseguro.CurrentRow.Cells("nombre").Value
        txtprecio.Text = dgvseguro.CurrentRow.Cells("precio").Value
        Txtdescripcion.Text = dgvseguro.CurrentRow.Cells("descripcion").Value


        btnguardar.Enabled = False
        btneliminar.Enabled = True
        bloqueacajas(True)
    End Sub

    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
        btnguardar.Enabled = True
        btneliminar.Enabled = False
        bloqueacajas(True)
    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        Dim c As New FSeguro
        If (c.eliminar_Seguros(txtcodigo.Text) = True) Then
            MessageBox.Show("Seguro Eliminado Correctamente", "Elimacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cancelar()
            mostrar_seguro()
        Else
            MessageBox.Show("Error al eliminar el Seguro")
        End If
    End Sub


End Class