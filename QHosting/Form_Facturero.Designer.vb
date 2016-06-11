<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Factura
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Factura))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_fecha_vencimiento = New System.Windows.Forms.Label()
        Me.lbl_cae = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.lbl_barcode_nro = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_impuestos = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_subtotal = New System.Windows.Forms.TextBox()
        Me.txt_cond_iva = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_cuit = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_telefono = New System.Windows.Forms.TextBox()
        Me.txt_localidad = New System.Windows.Forms.TextBox()
        Me.txt_domicilio = New System.Windows.Forms.TextBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.dgv_detalle = New System.Windows.Forms.DataGridView()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioUnitario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.lbl_mi_nombre = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.lbl_pto_venta = New System.Windows.Forms.Label()
        Me.lbl_mi_domicilio = New System.Windows.Forms.Label()
        Me.lbl_mi_telefono = New System.Windows.Forms.Label()
        Me.lbl_mi_fec_inicio_actividad = New System.Windows.Forms.Label()
        Me.lbl_mi_cond_iibb = New System.Windows.Forms.Label()
        Me.lbl_mi_cuit = New System.Windows.Forms.Label()
        Me.cbo_tipo_venta = New System.Windows.Forms.ComboBox()
        Me.cbo_tipo_comprobante = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.dtp_fecha = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lbl_nro_factura = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.barra_de_herramientas = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripProgressBar2 = New System.Windows.Forms.ToolStripProgressBar()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton9 = New System.Windows.Forms.ToolStripButton()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_detalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.barra_de_herramientas.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lbl_fecha_vencimiento)
        Me.Panel1.Controls.Add(Me.lbl_cae)
        Me.Panel1.Controls.Add(Me.Label23)
        Me.Panel1.Controls.Add(Me.lbl_barcode_nro)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.txt_total)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.txt_impuestos)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txt_subtotal)
        Me.Panel1.Controls.Add(Me.txt_cond_iva)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.txt_cuit)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txt_telefono)
        Me.Panel1.Controls.Add(Me.txt_localidad)
        Me.Panel1.Controls.Add(Me.txt_domicilio)
        Me.Panel1.Controls.Add(Me.txt_nombre)
        Me.Panel1.Controls.Add(Me.dgv_detalle)
        Me.Panel1.Location = New System.Drawing.Point(14, 148)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(436, 373)
        Me.Panel1.TabIndex = 12
        '
        'lbl_fecha_vencimiento
        '
        Me.lbl_fecha_vencimiento.AutoSize = True
        Me.lbl_fecha_vencimiento.Location = New System.Drawing.Point(204, 343)
        Me.lbl_fecha_vencimiento.Name = "lbl_fecha_vencimiento"
        Me.lbl_fecha_vencimiento.Size = New System.Drawing.Size(65, 13)
        Me.lbl_fecha_vencimiento.TabIndex = 102
        Me.lbl_fecha_vencimiento.Text = "01/01/2015"
        '
        'lbl_cae
        '
        Me.lbl_cae.AutoSize = True
        Me.lbl_cae.Location = New System.Drawing.Point(38, 343)
        Me.lbl_cae.Name = "lbl_cae"
        Me.lbl_cae.Size = New System.Drawing.Size(109, 13)
        Me.lbl_cae.TabIndex = 101
        Me.lbl_cae.Text = "00000000000000001"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(153, 343)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(53, 13)
        Me.Label23.TabIndex = 45
        Me.Label23.Text = "Fec. Vto.:"
        '
        'lbl_barcode_nro
        '
        Me.lbl_barcode_nro.Location = New System.Drawing.Point(11, 330)
        Me.lbl_barcode_nro.Name = "lbl_barcode_nro"
        Me.lbl_barcode_nro.Size = New System.Drawing.Size(249, 13)
        Me.lbl_barcode_nro.TabIndex = 44
        Me.lbl_barcode_nro.Text = "312858754987213468726918274"
        Me.lbl_barcode_nro.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(11, 343)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(31, 13)
        Me.Label17.TabIndex = 43
        Me.Label17.Text = "CAE:"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(14, 290)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(246, 37)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 23
        Me.PictureBox2.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(266, 336)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 13)
        Me.Label10.TabIndex = 42
        Me.Label10.Text = "Total:"
        '
        'txt_total
        '
        Me.txt_total.Enabled = False
        Me.txt_total.Location = New System.Drawing.Point(325, 333)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.Size = New System.Drawing.Size(100, 20)
        Me.txt_total.TabIndex = 100
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(266, 313)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 13)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = "Impuestos:"
        '
        'txt_impuestos
        '
        Me.txt_impuestos.Enabled = False
        Me.txt_impuestos.Location = New System.Drawing.Point(325, 310)
        Me.txt_impuestos.Name = "txt_impuestos"
        Me.txt_impuestos.Size = New System.Drawing.Size(100, 20)
        Me.txt_impuestos.TabIndex = 90
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(266, 290)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 13)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "SubTotal:"
        '
        'txt_subtotal
        '
        Me.txt_subtotal.Enabled = False
        Me.txt_subtotal.Location = New System.Drawing.Point(325, 287)
        Me.txt_subtotal.Name = "txt_subtotal"
        Me.txt_subtotal.Size = New System.Drawing.Size(100, 20)
        Me.txt_subtotal.TabIndex = 80
        '
        'txt_cond_iva
        '
        Me.txt_cond_iva.FormattingEnabled = True
        Me.txt_cond_iva.Location = New System.Drawing.Point(94, 97)
        Me.txt_cond_iva.Name = "txt_cond_iva"
        Me.txt_cond_iva.Size = New System.Drawing.Size(153, 21)
        Me.txt_cond_iva.TabIndex = 50
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(253, 101)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "CUIT Nº:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(11, 101)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 13)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "Condicion IVA:"
        '
        'txt_cuit
        '
        Me.txt_cuit.Location = New System.Drawing.Point(311, 97)
        Me.txt_cuit.Name = "txt_cuit"
        Me.txt_cuit.Size = New System.Drawing.Size(114, 20)
        Me.txt_cuit.TabIndex = 60
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Señor(es):"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Domicilio:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Localidad:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(253, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Telefono:"
        '
        'txt_telefono
        '
        Me.txt_telefono.Location = New System.Drawing.Point(311, 74)
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.Size = New System.Drawing.Size(114, 20)
        Me.txt_telefono.TabIndex = 40
        '
        'txt_localidad
        '
        Me.txt_localidad.Location = New System.Drawing.Point(69, 74)
        Me.txt_localidad.Name = "txt_localidad"
        Me.txt_localidad.Size = New System.Drawing.Size(178, 20)
        Me.txt_localidad.TabIndex = 30
        '
        'txt_domicilio
        '
        Me.txt_domicilio.Location = New System.Drawing.Point(69, 51)
        Me.txt_domicilio.Name = "txt_domicilio"
        Me.txt_domicilio.Size = New System.Drawing.Size(356, 20)
        Me.txt_domicilio.TabIndex = 20
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(69, 28)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(356, 20)
        Me.txt_nombre.TabIndex = 10
        '
        'dgv_detalle
        '
        Me.dgv_detalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_detalle.BackgroundColor = System.Drawing.Color.White
        Me.dgv_detalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_detalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cantidad, Me.Descripcion, Me.PrecioUnitario, Me.SubTotal})
        Me.dgv_detalle.Location = New System.Drawing.Point(12, 124)
        Me.dgv_detalle.Name = "dgv_detalle"
        Me.dgv_detalle.RowHeadersVisible = False
        Me.dgv_detalle.Size = New System.Drawing.Size(413, 157)
        Me.dgv_detalle.TabIndex = 70
        '
        'Cantidad
        '
        Me.Cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Cantidad.FillWeight = 61.54823!
        Me.Cantidad.HeaderText = "Cant."
        Me.Cantidad.Name = "Cantidad"
        '
        'Descripcion
        '
        Me.Descripcion.FillWeight = 253.8071!
        Me.Descripcion.HeaderText = "Descripcion"
        Me.Descripcion.Name = "Descripcion"
        '
        'PrecioUnitario
        '
        Me.PrecioUnitario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PrecioUnitario.FillWeight = 61.54823!
        Me.PrecioUnitario.HeaderText = "Precio"
        Me.PrecioUnitario.Name = "PrecioUnitario"
        '
        'SubTotal
        '
        Me.SubTotal.FillWeight = 61.54823!
        Me.SubTotal.HeaderText = "SubTotal"
        Me.SubTotal.Name = "SubTotal"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(6, 80)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(28, 15)
        Me.Label22.TabIndex = 21
        Me.Label22.Text = "Tel. "
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Haettenschweiler", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(69, 13)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(115, 33)
        Me.Label21.TabIndex = 20
        Me.Label21.Text = "Q-Informatica"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_mi_nombre
        '
        Me.lbl_mi_nombre.AutoSize = True
        Me.lbl_mi_nombre.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_mi_nombre.Location = New System.Drawing.Point(6, 65)
        Me.lbl_mi_nombre.Name = "lbl_mi_nombre"
        Me.lbl_mi_nombre.Size = New System.Drawing.Size(130, 15)
        Me.lbl_mi_nombre.TabIndex = 19
        Me.lbl_mi_nombre.Text = "Guido Nicolas Quadrini"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(266, 87)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(36, 15)
        Me.Label14.TabIndex = 16
        Me.Label14.Text = "CUIT:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(266, 108)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(67, 15)
        Me.Label16.TabIndex = 14
        Me.Label16.Text = "Ing. Brutos:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(265, 127)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(98, 15)
        Me.Label13.TabIndex = 10
        Me.Label13.Text = "Inicio. Actividad: "
        '
        'Label12
        '
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label12.Font = New System.Drawing.Font("Arial Narrow", 24.0!, System.Drawing.FontStyle.Bold)
        Me.Label12.Location = New System.Drawing.Point(190, -1)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(55, 51)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "X"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label24)
        Me.Panel2.Controls.Add(Me.lbl_pto_venta)
        Me.Panel2.Controls.Add(Me.lbl_mi_domicilio)
        Me.Panel2.Controls.Add(Me.lbl_mi_telefono)
        Me.Panel2.Controls.Add(Me.lbl_mi_fec_inicio_actividad)
        Me.Panel2.Controls.Add(Me.lbl_mi_cond_iibb)
        Me.Panel2.Controls.Add(Me.lbl_mi_cuit)
        Me.Panel2.Controls.Add(Me.cbo_tipo_venta)
        Me.Panel2.Controls.Add(Me.cbo_tipo_comprobante)
        Me.Panel2.Controls.Add(Me.Label19)
        Me.Panel2.Controls.Add(Me.dtp_fecha)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.lbl_nro_factura)
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.lbl_mi_nombre)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Label22)
        Me.Panel2.Controls.Add(Me.Label21)
        Me.Panel2.Location = New System.Drawing.Point(14, 11)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(436, 155)
        Me.Panel2.TabIndex = 22
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(336, 64)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(12, 15)
        Me.Label24.TabIndex = 40
        Me.Label24.Text = "-"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_pto_venta
        '
        Me.lbl_pto_venta.AutoSize = True
        Me.lbl_pto_venta.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pto_venta.Location = New System.Drawing.Point(303, 64)
        Me.lbl_pto_venta.Name = "lbl_pto_venta"
        Me.lbl_pto_venta.Size = New System.Drawing.Size(25, 15)
        Me.lbl_pto_venta.TabIndex = 39
        Me.lbl_pto_venta.Text = "001"
        Me.lbl_pto_venta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_mi_domicilio
        '
        Me.lbl_mi_domicilio.AutoSize = True
        Me.lbl_mi_domicilio.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_mi_domicilio.Location = New System.Drawing.Point(63, 96)
        Me.lbl_mi_domicilio.Name = "lbl_mi_domicilio"
        Me.lbl_mi_domicilio.Size = New System.Drawing.Size(81, 15)
        Me.lbl_mi_domicilio.TabIndex = 38
        Me.lbl_mi_domicilio.Text = "Jujuy 1716 6º1"
        '
        'lbl_mi_telefono
        '
        Me.lbl_mi_telefono.AutoSize = True
        Me.lbl_mi_telefono.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_mi_telefono.Location = New System.Drawing.Point(35, 80)
        Me.lbl_mi_telefono.Name = "lbl_mi_telefono"
        Me.lbl_mi_telefono.Size = New System.Drawing.Size(101, 15)
        Me.lbl_mi_telefono.TabIndex = 37
        Me.lbl_mi_telefono.Text = "+54 (341) 3551542"
        '
        'lbl_mi_fec_inicio_actividad
        '
        Me.lbl_mi_fec_inicio_actividad.AutoSize = True
        Me.lbl_mi_fec_inicio_actividad.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_mi_fec_inicio_actividad.Location = New System.Drawing.Point(357, 127)
        Me.lbl_mi_fec_inicio_actividad.Name = "lbl_mi_fec_inicio_actividad"
        Me.lbl_mi_fec_inicio_actividad.Size = New System.Drawing.Size(65, 15)
        Me.lbl_mi_fec_inicio_actividad.TabIndex = 36
        Me.lbl_mi_fec_inicio_actividad.Text = "01/04/2012"
        Me.lbl_mi_fec_inicio_actividad.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl_mi_cond_iibb
        '
        Me.lbl_mi_cond_iibb.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_mi_cond_iibb.Location = New System.Drawing.Point(342, 108)
        Me.lbl_mi_cond_iibb.Name = "lbl_mi_cond_iibb"
        Me.lbl_mi_cond_iibb.Size = New System.Drawing.Size(80, 15)
        Me.lbl_mi_cond_iibb.TabIndex = 35
        Me.lbl_mi_cond_iibb.Text = "Exento"
        Me.lbl_mi_cond_iibb.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl_mi_cuit
        '
        Me.lbl_mi_cuit.AutoSize = True
        Me.lbl_mi_cuit.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_mi_cuit.Location = New System.Drawing.Point(339, 87)
        Me.lbl_mi_cuit.Name = "lbl_mi_cuit"
        Me.lbl_mi_cuit.Size = New System.Drawing.Size(83, 15)
        Me.lbl_mi_cuit.TabIndex = 34
        Me.lbl_mi_cuit.Text = "20-29639965-6"
        Me.lbl_mi_cuit.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cbo_tipo_venta
        '
        Me.cbo_tipo_venta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_tipo_venta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbo_tipo_venta.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_tipo_venta.FormattingEnabled = True
        Me.cbo_tipo_venta.Items.AddRange(New Object() {"Producto", "Servicio", "Producto y Servicio"})
        Me.cbo_tipo_venta.Location = New System.Drawing.Point(135, 121)
        Me.cbo_tipo_venta.Name = "cbo_tipo_venta"
        Me.cbo_tipo_venta.Size = New System.Drawing.Size(119, 21)
        Me.cbo_tipo_venta.TabIndex = 33
        '
        'cbo_tipo_comprobante
        '
        Me.cbo_tipo_comprobante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_tipo_comprobante.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbo_tipo_comprobante.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_tipo_comprobante.FormattingEnabled = True
        Me.cbo_tipo_comprobante.Items.AddRange(New Object() {"Factura A", "Factura B", "Factura C", "Recibo C", "Remito", "Nota de Credito A", "Nota de Credito B", "Nota de Credito C"})
        Me.cbo_tipo_comprobante.Location = New System.Drawing.Point(11, 121)
        Me.cbo_tipo_comprobante.Name = "cbo_tipo_comprobante"
        Me.cbo_tipo_comprobante.Size = New System.Drawing.Size(119, 21)
        Me.cbo_tipo_comprobante.TabIndex = 31
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(266, 64)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(21, 15)
        Me.Label19.TabIndex = 30
        Me.Label19.Text = "Nº"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtp_fecha
        '
        Me.dtp_fecha.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha.Location = New System.Drawing.Point(268, 25)
        Me.dtp_fecha.Name = "dtp_fecha"
        Me.dtp_fecha.Size = New System.Drawing.Size(154, 25)
        Me.dtp_fecha.TabIndex = 29
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(6, 96)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(61, 15)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Domicilio:"
        '
        'lbl_nro_factura
        '
        Me.lbl_nro_factura.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nro_factura.Location = New System.Drawing.Point(351, 62)
        Me.lbl_nro_factura.Name = "lbl_nro_factura"
        Me.lbl_nro_factura.Size = New System.Drawing.Size(71, 20)
        Me.lbl_nro_factura.TabIndex = 19
        Me.lbl_nro_factura.Text = "00000058"
        Me.lbl_nro_factura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(7, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(60, 60)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'barra_de_herramientas
        '
        Me.barra_de_herramientas.BackColor = System.Drawing.Color.White
        Me.barra_de_herramientas.Dock = System.Windows.Forms.DockStyle.Right
        Me.barra_de_herramientas.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.barra_de_herramientas.ImageScalingSize = New System.Drawing.Size(40, 40)
        Me.barra_de_herramientas.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton2, Me.ToolStripButton4, Me.ToolStripButton3, Me.ToolStripButton5, Me.ToolStripButton1, Me.ToolStripLabel1, Me.ToolStripProgressBar2, Me.ToolStripLabel2, Me.ToolStripButton9})
        Me.barra_de_herramientas.Location = New System.Drawing.Point(469, 0)
        Me.barra_de_herramientas.Margin = New System.Windows.Forms.Padding(3)
        Me.barra_de_herramientas.Name = "barra_de_herramientas"
        Me.barra_de_herramientas.Padding = New System.Windows.Forms.Padding(0, 20, 0, 20)
        Me.barra_de_herramientas.Size = New System.Drawing.Size(71, 531)
        Me.barra_de_herramientas.TabIndex = 23
        Me.barra_de_herramientas.Text = "Barra de Herramientas"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(70, 44)
        Me.ToolStripButton2.Text = "Nuevo comprobante"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Margin = New System.Windows.Forms.Padding(0, 10, 0, 2)
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(70, 44)
        Me.ToolStripButton4.Text = "Historial de comprobantes emitidos"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Margin = New System.Windows.Forms.Padding(0, 10, 0, 2)
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(70, 44)
        Me.ToolStripButton3.Text = "Historico de Clientes"
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Margin = New System.Windows.Forms.Padding(0, 15, 0, 2)
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(70, 44)
        Me.ToolStripButton5.Text = "Enviar a ..."
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Margin = New System.Windows.Forms.Padding(0, 30, 0, 2)
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(70, 44)
        Me.ToolStripButton1.Text = "Configuracion"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Margin = New System.Windows.Forms.Padding(0, 35, 0, 2)
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(70, 15)
        Me.ToolStripLabel1.Text = "En espera..."
        '
        'ToolStripProgressBar2
        '
        Me.ToolStripProgressBar2.Margin = New System.Windows.Forms.Padding(1, 5, 1, 1)
        Me.ToolStripProgressBar2.Name = "ToolStripProgressBar2"
        Me.ToolStripProgressBar2.Size = New System.Drawing.Size(68, 20)
        Me.ToolStripProgressBar2.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ToolStripProgressBar2.Tag = ""
        Me.ToolStripProgressBar2.Value = 50
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.AutoSize = False
        Me.ToolStripLabel2.Image = CType(resources.GetObject("ToolStripLabel2.Image"), System.Drawing.Image)
        Me.ToolStripLabel2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripLabel2.Margin = New System.Windows.Forms.Padding(0, 10, 0, 2)
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(70, 35)
        '
        'ToolStripButton9
        '
        Me.ToolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton9.Image = CType(resources.GetObject("ToolStripButton9.Image"), System.Drawing.Image)
        Me.ToolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton9.Margin = New System.Windows.Forms.Padding(0, 20, 0, 2)
        Me.ToolStripButton9.Name = "ToolStripButton9"
        Me.ToolStripButton9.Size = New System.Drawing.Size(70, 44)
        Me.ToolStripButton9.Text = "Salir"
        '
        'Form_Factura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Navy
        Me.ClientSize = New System.Drawing.Size(540, 531)
        Me.Controls.Add(Me.barra_de_herramientas)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "Form_Factura"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Facturero"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_detalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.barra_de_herramientas.ResumeLayout(False)
        Me.barra_de_herramientas.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_mi_nombre As System.Windows.Forms.Label
    Friend WithEvents dgv_detalle As System.Windows.Forms.DataGridView
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lbl_nro_factura As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_telefono As System.Windows.Forms.TextBox
    Friend WithEvents txt_localidad As System.Windows.Forms.TextBox
    Friend WithEvents txt_domicilio As System.Windows.Forms.TextBox
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents lbl_barcode_nro As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_total As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_impuestos As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_subtotal As System.Windows.Forms.TextBox
    Friend WithEvents txt_cond_iva As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_cuit As System.Windows.Forms.TextBox
    Friend WithEvents dtp_fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents cbo_tipo_comprobante As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_tipo_venta As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_mi_cond_iibb As Label
    Friend WithEvents lbl_mi_cuit As Label
    Friend WithEvents lbl_mi_fec_inicio_actividad As Label
    Friend WithEvents lbl_mi_domicilio As Label
    Friend WithEvents lbl_mi_telefono As Label
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents PrecioUnitario As DataGridViewTextBoxColumn
    Friend WithEvents SubTotal As DataGridViewTextBoxColumn
    Friend WithEvents barra_de_herramientas As ToolStrip
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents ToolStripButton5 As ToolStripButton
    Friend WithEvents ToolStripButton9 As ToolStripButton
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents ToolStripProgressBar2 As ToolStripProgressBar
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents Label24 As Label
    Friend WithEvents lbl_pto_venta As Label
    Friend WithEvents lbl_cae As Label
    Friend WithEvents lbl_fecha_vencimiento As Label
End Class
