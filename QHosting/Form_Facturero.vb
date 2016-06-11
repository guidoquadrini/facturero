Public Class Form_Factura

#Region "Barra de Herramientas"
    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        historial("Comprobantes")
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        control_de_herramientas(True, True, True, False, True)
        Me.LimpiarFormulario()
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        historial("Clientes")
    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
        enviar()
    End Sub

    Private Sub ToolStripButton1_Click_1(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.configuracion()
    End Sub

    Private Sub ToolStripButton9_Click(sender As Object, e As EventArgs) Handles ToolStripButton9.Click
        End
    End Sub
#End Region

    'Datos por defecto.
    Dim Fecha = Now()
    Dim tpo_comprobante = "Factura C"
    Dim tpo_venta = "Producto"
    Dim mi_pto_venta = "0001"

    'Datos Monotributista
    Dim mi_nombre = "Guido Nicolas Quadrini"
    Dim mi_domicilio = "Jujuy 1716 6°1, Rosario, Santa Fe, AR"
    Dim mi_telefono = "+54 9 341 3551542"
    Dim mi_cuit = "20-29639965-6"
    Dim mi_fecha_inscripcion = "04/06/2011"
    Dim mi_nro_iibb = "129-1188"

#Region "Acciones"
    Private Sub LimpiarFormulario()
        txt_nombre.Text = String.Empty
        txt_domicilio.Text = String.Empty
        txt_localidad.Text = String.Empty
        txt_telefono.Text = String.Empty
        txt_cond_iva.Text = String.Empty
        txt_cuit.Text = String.Empty
        dgv_detalle.DataSource = Nothing
        dgv_detalle.Refresh()
        txt_subtotal.Text = String.Empty
        txt_impuestos.Text = String.Empty
        txt_total.Text = String.Empty
        cbo_tipo_comprobante.Text = tpo_comprobante
        cbo_tipo_venta.Text = tpo_venta
        dtp_fecha.Value = Fecha
        lbl_cae.Text = ""
        lbl_fecha_vencimiento.Text = String.Empty
        lbl_barcode_nro.Text = "Comprobante sin registrar en AFIP."
        lbl_mi_nombre.Text = mi_nombre
        lbl_mi_telefono.Text = mi_telefono
        lbl_mi_domicilio.Text = mi_domicilio
        lbl_mi_cuit.Text = mi_cuit
        lbl_mi_cond_iibb.Text = mi_nro_iibb
        lbl_mi_fec_inicio_actividad.Text = mi_fecha_inscripcion
        lbl_pto_venta.Text = mi_pto_venta
        lbl_nro_factura.Text = "XXXXXXXX"

    End Sub

    Private Sub habilitar(ByRef estado As Boolean)
        txt_nombre.Enabled = estado
        txt_domicilio.Enabled = estado
        txt_localidad.Enabled = estado
        txt_telefono.Enabled = estado
        txt_cond_iva.Enabled = estado
        txt_cuit.Enabled = estado
        dgv_detalle.Enabled = estado
        cbo_tipo_comprobante.Enabled = estado
        cbo_tipo_venta.Enabled = estado
        dtp_fecha.Enabled = estado
    End Sub

    Private Sub historial(tipoHistorial As String)
        Select Case tipoHistorial
            Case "Clientes"
                ABMC_Clientes.ShowDialog(Me)

            Case "Comprobantes"
                'frm_comprobantes.Show()
        End Select
    End Sub

    Private Sub evento_callback_seleccion_cliente()
        ' Me.cargarComprobante(oComprobante)
    End Sub
    Private Sub evento_callback_seleccion_comprobante()
        ' Me.cargarCliente(oCliente)
    End Sub

    Private Sub cargarComprobante(oComprobante)
        txt_nombre.Text = oComprobante.cabecera.nombre
        txt_domicilio.Text = oComprobante.cabecera.domicilio
        txt_localidad.Text = oComprobante.cabecera.localidad
        txt_telefono.Text = oComprobante.cabecera.telefono
        txt_cond_iva.Text = oComprobante.cabecera.cond_iva
        txt_cuit.Text = oComprobante.cabecera.cuit
        dgv_detalle.DataSource = oComprobante.detalle
        dgv_detalle.Refresh()
        txt_subtotal.Text = oComprobante.cabecera.subtotal
        txt_impuestos.Text = oComprobante.cebecera.impuestos
        txt_total.Text = oComprobante.cabecera.total
        cbo_tipo_comprobante.Text = oComprobante.cabecera.tpo_comprobante
        cbo_tipo_venta.Text = oComprobante.cabecera.pto_venta
        dtp_fecha.Value = oComprobante.cabecera.fecha
        lbl_cae.Text = oComprobante.cebecera.cae
        lbl_fecha_vencimiento.Text = oComprobante.cabecera.fecha_vencimiento
        lbl_barcode_nro.Text = oComprobante.cebecera.codigoBarraNro
        lbl_mi_nombre.Text = oComprobante.cabecera.mi_nombre
        lbl_mi_telefono.Text = oComprobante.cabecera.mi_telefono
        lbl_mi_domicilio.Text = oComprobante.cabecera.mi_domicilio
        lbl_mi_cuit.Text = oComprobante.cabecera.mi_cuit
        lbl_mi_cond_iibb.Text = oComprobante.cabecera.mi_nro_iibb
        lbl_mi_fec_inicio_actividad.Text = oComprobante.cabecera.mi_fecha_inscripcion
        lbl_pto_venta.Text = oComprobante.cabecera.mi_pto_venta
        lbl_nro_factura.Text = oComprobante.cabecera.nroComprobante
        habilitar(False)
        control_de_herramientas(True, True, False, True, True)

    End Sub

    Private Sub cargarCliente(oComprobante)
        txt_nombre.Text = oComprobante.cabecera.nombre
        txt_domicilio.Text = oComprobante.cabecera.domicilio
        txt_localidad.Text = oComprobante.cabecera.localidad
        txt_telefono.Text = oComprobante.cabecera.telefono
        txt_cond_iva.Text = oComprobante.cabecera.cond_iva
        txt_cuit.Text = oComprobante.cabecera.cuit
        habilitar(True)
        control_de_herramientas(True, True, True, False, True)

    End Sub

    Private Sub control_de_herramientas(NuevoComprobante As Boolean, HistorialComprobante As Boolean, HistorialClientes As Boolean, EnviarA As Boolean, Configuracion As Boolean)
        barra_de_herramientas.Items(0).Enabled = NuevoComprobante
        barra_de_herramientas.Items(1).Enabled = HistorialComprobante
        barra_de_herramientas.Items(2).Enabled = HistorialClientes
        barra_de_herramientas.Items(3).Enabled = EnviarA
        barra_de_herramientas.Items(4).Enabled = Configuracion
    End Sub

    Private Sub enviar()
        Throw New NotImplementedException()
    End Sub

    Private Sub configuracion()
        Throw New NotImplementedException()
    End Sub

    Private Sub Form_Factura_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LimpiarFormulario()
        txt_subtotal.BackColor = Color.White
        txt_impuestos.BackColor = Color.White
        txt_total.BackColor = Color.White

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim estado As Boolean
        estado = Not txt_nombre.Enabled
        habilitar(estado)
    End Sub

    Private Sub dgv_detalle_KeyDown(sender As Object, e As KeyEventArgs) Handles dgv_detalle.KeyDown
        If e.KeyCode = Keys.Return Then
            Dim result As DialogResult = MessageBox.Show("¿Esta seguro que desea generar el comprobate?",
                              "Aviso antes de enviar datos al AFIP",
                              MessageBoxButtons.YesNo)

            If result = DialogResult.Yes Then
                control_de_herramientas(True, True, False, True, True)
                'ctrl_factura.ObtenerCae(datos)
            End If
        End If
    End Sub
#End Region


End Class