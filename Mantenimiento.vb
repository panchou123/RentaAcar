Public Class Mantenimiento
    Dim dtMantenimiento As New DataTable
    Private Sub Formcliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpiar()
        btnnuevo.Enabled = True
        btnguardar.Enabled = False
        btncancelar.Enabled = False
        btneliminar.Enabled = False
        btnmodificar.Enabled = False
        mostrar_clientes()
    End Sub
    Sub buscar_cliente()
        Dim fc As New fmantenimiento
        dtmantenimiento = fc.buscar_mantenimiento(txtbuscar.Text)
        dgvmantenimiento.DataSource = dtmantenimiento
    End Sub
    Sub mostrar_clientes()
        Dim fc As New fmantenimiento
        dtmantenimiento = fc.mostrar_mantenimiento()
        dgvmantenimiento.DataSource = dtmantenimiento
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
        txtapellidos.Clear()
        txtdni.Clear()

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
        txtapellidos.Enabled = va
        txtdni.Enabled = va


    End Sub

    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
        btnguardar.Enabled = True
        btneliminar.Enabled = False
        bloqueacajas(True)
    End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        nuevo()
    End Sub


    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        cancelar()
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Dim fc As New fmantenimiento
        If (txtnombre.Text <> String.Empty And txtapellidos.Text <> String.Empty <> 0) Then

            If (txtcodigo.Text <> String.Empty) Then
                If (fc.editar_mantenimiento(txtcodigo.Text, txtnombre.Text, txtapellidos.Text, txtdni.Text) = True) Then
                    MessageBox.Show("Cliente editado Correctamente", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    cancelar()
                    mostrar_clientes()
                Else
                    MessageBox.Show("Error al Modificar el cliente")
                End If
            Else


                If (fc.ingresa_mantenimiento(txtcodigo.Text, txtnombre.Text, txtapellidos.Text, txtdni.Text) = True) Then
                    MessageBox.Show("Cliente registrado Correctamente", "Modificacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    cancelar()
                    mostrar_clientes()
                Else
                    MessageBox.Show("Error al registrar el cliente")
                End If
            End If

        Else
            MessageBox.Show("Complete todos los datos")
        End If
    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        Dim c As New fmantenimiento
        If (c.eliminar_mantenimiento(txtcodigo.Text) = True) Then
            MessageBox.Show("Cliente Eliminadaa Correctamente", "Elimacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cancelar()
            mostrar_clientes()
        Else
            MessageBox.Show("Error al eliminar el cliente")
        End If
    End Sub
    Private Sub dgvmantenimiento_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvmantenimiento.CellContentClick
        txtcodigo.Text = dgvmantenimiento.CurrentRow.Cells("cod_cliente").Value
        txtnombre.Text = dgvmantenimiento.CurrentRow.Cells("nombres").Value
        txtapellidos.Text = dgvmantenimiento.CurrentRow.Cells("fecha_inicio").Value
        txtdni.Text = dgvmantenimiento.CurrentRow.Cells("fecha_final").Value

        btnguardar.Enabled = False
        btnmodificar.Enabled = True
        btneliminar.Enabled = True
        btncancelar.Enabled = True
        btnnuevo.Enabled = True
    End Sub


    Private Sub txtcodigo_TextChanged(sender As Object, e As EventArgs) Handles txtcodigo.TextChanged

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        buscar_cliente()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs)
        mostrar_clientes()
        txtbuscar.Clear()
    End Sub


    Private Sub txtnombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnombre.KeyPress
        SoloLetras(e)
    End Sub

    Private Sub txtapellidos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtapellidos.KeyPress
        SoloLetras(e)
    End Sub



    Private Sub txtbuscar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbuscar.KeyPress
        SoloLetras(e)
    End Sub
    Private Sub FormVenta_Deactivate(sender As Object, e As EventArgs) Handles MyBase.Deactivate
        ' Check if the mouse is outside the form's bounds
        If Not Me.Bounds.Contains(Cursor.Position) Then
            Me.Close()
        End If
    End Sub




End Class