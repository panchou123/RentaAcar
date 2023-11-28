<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormVenta
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormVenta))
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtnumdocu = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.txtfecha = New System.Windows.Forms.DateTimePicker()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.Producto = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BusquedaProductos = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtcabtidad = New System.Windows.Forms.NumericUpDown()
        Me.btnegregar = New System.Windows.Forms.Button()
        Me.cbproducto = New System.Windows.Forms.ComboBox()
        Me.dgvdetalles = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Producto.SuspendLayout()
        CType(Me.txtcabtidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvdetalles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(390, 50)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 13)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "Numero"
        '
        'txtnumdocu
        '
        Me.txtnumdocu.Enabled = False
        Me.txtnumdocu.Location = New System.Drawing.Point(489, 50)
        Me.txtnumdocu.Name = "txtnumdocu"
        Me.txtnumdocu.Size = New System.Drawing.Size(100, 20)
        Me.txtnumdocu.TabIndex = 30
        '
        'PictureBox2
        '
        Me.PictureBox2.Enabled = False
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(136, 224)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(75, 73)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 35
        Me.PictureBox2.TabStop = False
        '
        'txtfecha
        '
        Me.txtfecha.Enabled = False
        Me.txtfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtfecha.Location = New System.Drawing.Point(489, 82)
        Me.txtfecha.Name = "txtfecha"
        Me.txtfecha.Size = New System.Drawing.Size(171, 20)
        Me.txtfecha.TabIndex = 29
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.CadetBlue
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button2.Location = New System.Drawing.Point(449, 132)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(140, 33)
        Me.Button2.TabIndex = 37
        Me.Button2.Text = "Registrar Cliente"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(397, 82)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Fecha"
        '
        'PictureBox3
        '
        Me.PictureBox3.Enabled = False
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(217, 224)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(75, 73)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 34
        Me.PictureBox3.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(136, 222)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 73)
        Me.Button1.TabIndex = 36
        Me.Button1.Text = "Facturar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(117, 14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(225, 161)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 33
        Me.PictureBox1.TabStop = False
        '
        'btnguardar
        '
        Me.btnguardar.Enabled = False
        Me.btnguardar.Location = New System.Drawing.Point(217, 222)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(75, 73)
        Me.btnguardar.TabIndex = 32
        Me.btnguardar.Text = "Guardar Venta"
        Me.btnguardar.UseVisualStyleBackColor = True
        '
        'Producto
        '
        Me.Producto.Controls.Add(Me.Label4)
        Me.Producto.Controls.Add(Me.BusquedaProductos)
        Me.Producto.Controls.Add(Me.Label3)
        Me.Producto.Controls.Add(Me.Label2)
        Me.Producto.Controls.Add(Me.txtcabtidad)
        Me.Producto.Controls.Add(Me.btnegregar)
        Me.Producto.Controls.Add(Me.cbproducto)
        Me.Producto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Producto.Location = New System.Drawing.Point(297, 192)
        Me.Producto.Name = "Producto"
        Me.Producto.Size = New System.Drawing.Size(386, 137)
        Me.Producto.TabIndex = 27
        Me.Producto.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(39, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Codigo"
        '
        'BusquedaProductos
        '
        Me.BusquedaProductos.Location = New System.Drawing.Point(131, 103)
        Me.BusquedaProductos.Name = "BusquedaProductos"
        Me.BusquedaProductos.Size = New System.Drawing.Size(100, 22)
        Me.BusquedaProductos.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Cantidad"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Producto"
        '
        'txtcabtidad
        '
        Me.txtcabtidad.Enabled = False
        Me.txtcabtidad.Location = New System.Drawing.Point(131, 65)
        Me.txtcabtidad.Name = "txtcabtidad"
        Me.txtcabtidad.Size = New System.Drawing.Size(143, 22)
        Me.txtcabtidad.TabIndex = 2
        Me.txtcabtidad.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'btnegregar
        '
        Me.btnegregar.BackgroundImage = CType(resources.GetObject("btnegregar.BackgroundImage"), System.Drawing.Image)
        Me.btnegregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnegregar.Enabled = False
        Me.btnegregar.Location = New System.Drawing.Point(302, 46)
        Me.btnegregar.Name = "btnegregar"
        Me.btnegregar.Size = New System.Drawing.Size(78, 59)
        Me.btnegregar.TabIndex = 1
        Me.btnegregar.UseVisualStyleBackColor = True
        '
        'cbproducto
        '
        Me.cbproducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbproducto.Enabled = False
        Me.cbproducto.FormattingEnabled = True
        Me.cbproducto.Location = New System.Drawing.Point(131, 21)
        Me.cbproducto.Name = "cbproducto"
        Me.cbproducto.Size = New System.Drawing.Size(143, 24)
        Me.cbproducto.TabIndex = 0
        '
        'dgvdetalles
        '
        Me.dgvdetalles.AllowUserToAddRows = False
        Me.dgvdetalles.AllowUserToDeleteRows = False
        Me.dgvdetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvdetalles.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.dgvdetalles.EnableHeadersVisualStyles = False
        Me.dgvdetalles.GridColor = System.Drawing.SystemColors.ActiveBorder
        Me.dgvdetalles.Location = New System.Drawing.Point(127, 335)
        Me.dgvdetalles.Name = "dgvdetalles"
        Me.dgvdetalles.ReadOnly = True
        Me.dgvdetalles.Size = New System.Drawing.Size(545, 58)
        Me.dgvdetalles.TabIndex = 26
        '
        'Column1
        '
        Me.Column1.HeaderText = "codproducto"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'Column2
        '
        Me.Column2.HeaderText = "cantidad"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "descripcion"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 200
        '
        'Column4
        '
        Me.Column4.HeaderText = "P. Unitario"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "Importe"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'txttotal
        '
        Me.txttotal.Enabled = False
        Me.txttotal.Location = New System.Drawing.Point(508, 408)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(113, 20)
        Me.txttotal.TabIndex = 39
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(445, 408)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 21)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Total"
        '
        'FormVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtnumdocu)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.txtfecha)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.Producto)
        Me.Controls.Add(Me.dgvdetalles)
        Me.Name = "FormVenta"
        Me.Text = "FormVenta"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Producto.ResumeLayout(False)
        Me.Producto.PerformLayout()
        CType(Me.txtcabtidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvdetalles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label9 As Label
    Friend WithEvents txtnumdocu As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents txtfecha As DateTimePicker
    Friend WithEvents Button2 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnguardar As Button
    Friend WithEvents Producto As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents BusquedaProductos As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtcabtidad As NumericUpDown
    Friend WithEvents btnegregar As Button
    Friend WithEvents cbproducto As ComboBox
    Friend WithEvents dgvdetalles As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents txttotal As TextBox
    Friend WithEvents Label1 As Label
End Class
