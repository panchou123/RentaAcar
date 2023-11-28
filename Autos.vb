Public Class Autos
    Dim dtautos As DataTable

    Private Sub FormAutos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bloqueacajas(False)
        mostrar_autos()
        limpiar()
    End Sub

    Public Sub mostrar_autos()
        Dim c As New FAutos
        dtautos = c.mostrar_autos
        dgvautos.DataSource = dtautos
    End Sub

    Sub nuevoAuto()
        btncancelarAuto.Enabled = True
        btnguardarAuto.Enabled = True
        limpiar()
        bloqueacajasAuto(True)
    End Sub

    Sub limpiarAuto()
        txtCodigoAuto.Clear()
        txtMarca.Clear()
        txtModelo.Clear()
        txtAnio.Clear()
    End Sub

    Sub cancelarAuto()
        btnNuevoAuto.Enabled = True
        btnguardarAuto.Enabled = False
        btnEliminarAuto.Enabled = False
        btncancelarAuto.Enabled = False
        btnModificarAuto.Enabled = False
        limpiarAuto()
        bloqueacajasAuto(False)
    End Sub

    Sub bloqueacajasAuto(va As Boolean)
        txtMarca.Enabled = va
        txtModelo.Enabled = va
        txtAnio.Enabled = va
    End Sub

    Private Sub btnNuevoAuto_Click(sender As Object, e As EventArgs) Handles btnNuevoAuto.Click
        nuevoAuto()
    End Sub

    Private Sub btncancelarAuto_Click(sender As Object, e As EventArgs) Handles btncancelarAuto.Click
        cancelarAuto()
    End Sub

    Private Sub btnguardarAuto_Click(sender As Object, e As EventArgs) Handles btnguardarAuto.Click
        Dim c As New FAutos
        If (txtMarca.Text <> String.Empty And txtModelo.Text <> String.Empty And txtAnio.Text <> String.Empty) Then
            Try
                If (txtCodigoAuto.Text <> String.Empty) Then
                    If (c.editarAuto(txtCodigoAuto.Text, txtMarca.Text, txtModelo.Text, txtAnio.Text) = True) Then
                        MessageBox.Show("Auto editado correctamente", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        cancelarAuto()
                        mostrar_autos()
                    Else
                        MessageBox.Show("Error al modificar el Auto")
                    End If
                Else
                    If (c.insertarAuto(txtCodigoAuto.Text, txtMarca.Text, txtModelo.Text, txtAño.Text) = True) Then
                        MessageBox.Show("Auto registrado correctamente", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        cancelarAuto()
                        mostrar_autos()
                    Else
                        MessageBox.Show("Error al registrar el Auto")
                    End If
                End If
            Catch ex As Exception
                MessageBox.Show("Verifique los datos ingresados", "Datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        Else
            MessageBox.Show("Complete todos los datos")
        End If
    End Sub

    Private Sub dgvautos_DoubleClick(sender As Object, e As EventArgs) Handles dgvautos.DoubleClick
        txtCodigoAuto.Text = dgvautos.CurrentRow.Cells("codigo_auto").Value
        txtMarca.Text = dgvautos.CurrentRow.Cells("marca").Value
        txtModelo.Text = dgvautos.CurrentRow.Cells("modelo").Value
        txtAnio.Text = dgvautos.CurrentRow.Cells("anio").Value

        btnguardarAuto.Enabled = False
        btnEliminarAuto.Enabled = True
        bloqueacajasAuto(True)
    End Sub

    Private Sub btnModificarAuto_Click(sender As Object, e As EventArgs) Handles btnModificarAuto.Click
        btnguardarAuto.Enabled = True
        btnEliminarAuto.Enabled = False
        bloqueacajasAuto(True)
    End Sub

    Private Sub btnEliminarAuto_Click(sender As Object, e As EventArgs) Handles btnEliminarAuto.Click
        Dim c As New FAutos
        If (c.eliminarAuto(txtCodigoAuto.Text) = True) Then
            MessageBox.Show("Auto eliminado correctamente", "Eliminación", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cancelarAuto()
            mostrar_autos()
        Else
            MessageBox.Show("Error al eliminar el Auto")
        End If
    End Sub
End Class