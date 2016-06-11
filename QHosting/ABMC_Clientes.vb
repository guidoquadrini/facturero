Imports Controller

Public Class ABMC_Clientes
    Public WithEvents Form_Cliente As New Form_Cliente
    Public WithEvents ctrl_Clientes As New Ctrl_Clientes

    Private Sub frm_Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ctrl_Clientes = New Controller.Ctrl_Clientes()
        DGV_Clientes.DataSource = ctrl_Clientes.Clientes.Catalogo
        DGV_Clientes.Refresh()
        ToolTips()
    End Sub

#Region "Acciones"
    Private Sub BTN_Agregar_Click(sender As Object, e As EventArgs) Handles BTN_Agregar.Click
        MostrarFormularioAltaEdicion(Model.eAMBC_Acciones.Alta)
    End Sub
    Private Sub BTN_Modificar_Click(sender As Object, e As EventArgs) Handles BTN_Modificar.Click
        If DGV_Clientes.SelectedRows.Count = 1 Then
            MostrarFormularioAltaEdicion(Model.eAMBC_Acciones.Modificacion)
        Else
            MsgBox("Debe seleccionar una fila y solo una para poder modificarla.", MsgBoxStyle.Information, "Advertencia")
        End If
    End Sub
    Private Sub BTN_Borrar_Click(sender As Object, e As EventArgs) Handles BTN_Borrar.Click
        If DGV_Clientes.SelectedRows.Count > 0 Then
            Dim wList As List(Of Integer) = ObtenerIDsSelecionados()
            Dim Respuesta As Microsoft.VisualBasic.MsgBoxResult
            Dim CadenaDeIDs As String = wList(0)
            For i = 1 To wList.Count - 1
                CadenaDeIDs += "; " & wList(i)
            Next
            If Not CadenaDeIDs.Substring(CadenaDeIDs.Length - 1, 1) = ";" Then CadenaDeIDs += ";"
            Respuesta = MsgBox("¿Esta usted seguro que desea borrar los siguientes IDs? " + CadenaDeIDs, MsgBoxStyle.YesNo, "Advertencia")
            If Respuesta.Equals(MsgBoxResult.Yes) Then
                ProcesarDatos(Model.eAMBC_Acciones.Baja, wList)
            End If
            Me.ActualizarFormulario()
        Else
            MsgBox("No hay filas seleccionadas.", MsgBoxStyle.Information, "Advertencia")
        End If
    End Sub
    Private Sub BTN_Ayuda_Click(sender As Object, e As EventArgs) Handles BTN_Ayuda.Click
        MsgBox("Funcionalidad en desarrollo.")
        'ctrl_Clientes.Ayuda()
    End Sub
#End Region
#Region "Panel Arriba"
    Private Sub TextBox_Filtro_TextChanged(sender As Object, e As EventArgs) Handles TextBox_Filtro.TextChanged
        DGV_Clientes.DataSource = ctrl_Clientes.FiltrarClientes(TextBox_Filtro.Text)
    End Sub
#End Region
#Region "Panel Abajo"
    Private Sub BTN_EnviarA_Click(sender As Object, e As EventArgs) Handles BTN_EnviarA.Click
        '  MsgBox("Funcionalidad en desarrollo.")
        'Revisar estas lineas para asegurar los errores.
        Dim form_enviar As New Form_EnviarA
        form_enviar.oDatos = New List(Of Object) ' = CType(DGV_Clientes.DataSource, IEnumerable(Of Model.Cliente))
        form_enviar.ShowDialog() 'ctrl_Clientes.EnviarA()
    End Sub
    Private Sub BTN_Salir_Click(sender As Object, e As EventArgs) Handles BTN_Salir.Click
        Me.Close()
    End Sub
    Private Sub DGV_Clientes_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_Clientes.CellContentDoubleClick
        MostrarFormularioAltaEdicion(Model.eAMBC_Acciones.Modificacion)
    End Sub
#End Region

    Private Sub Form_Cliente_DatosValidadosSatisfactoriamente(ByVal pModo As Model.eAMBC_Acciones) Handles Form_Cliente.DatosValidadosSatisfactoriamente
        Select Case pModo
            Case Model.eAMBC_Acciones.Alta
                ProcesarDatos(Model.eAMBC_Acciones.Alta)
            Case Model.eAMBC_Acciones.Modificacion
                ProcesarDatos(Model.eAMBC_Acciones.Modificacion)
        End Select
        Form_Cliente.Cliente = Nothing
        Me.ActualizarFormulario()
    End Sub
    Private Sub ProcesarDatos(pAccion As Model.eAMBC_Acciones, Optional ByVal pList As List(Of Integer) = Nothing)
        Select Case pAccion
            Case Model.eAMBC_Acciones.Alta, Model.eAMBC_Acciones.Modificacion

                With Form_Cliente
                    Dim wCliente As New Model.Cliente( _
                                                         .TextBox_ID.Text _
                                                       , .TextBox_Nombre.Text _
                                                       , .TextBox_Apellido.Text _
                                                       , .TextBox_Empresa.Text _
                                                       , .TextBox_Email.Text _
                                                       , .TextBox_Direccion.Text _
                                                       , .TextBox_Direccion2.Text _
                                                       , .TextBox_Telefono.Text _
                                                       , .TextBox_Ciudad.Text _
                                                       , .TextBox_Provincia.Text _
                                                       , .TextBox_CodigoPostal.Text _
                                                       , .TextBox_Pais.Text _
                                                       , .TextBox_Moneda.Text _
                                                       , .TextBox_Contraseña.Text _
                                                       )
                    ctrl_Clientes.Actualizacion(wCliente, pAccion)
                End With
            Case Model.eAMBC_Acciones.Baja
                If Not pList Is Nothing Then
                    ctrl_Clientes.Borrar(pList)
                Else
                    MsgBox("No hay filas seleccionadas.", MsgBoxStyle.Information, "Advertencia")
                End If

        End Select
    End Sub
    Private Sub MostrarFormularioAltaEdicion(pAccion As Model.eAMBC_Acciones)
        With Form_Cliente
            .LimpiarFormulario()
            Select Case pAccion
                Case Model.eAMBC_Acciones.Alta
                    .Text = "Formulario de Alta de Cliente"
                    .Label_Titulo.Text = "Formulario de Alta"
                    .PictureBox_Icon.Image = My.Resources.plus_48
                Case Model.eAMBC_Acciones.Modificacion
                    .Text = "Formulario de Modificacion de Cliente"
                    .Label_Titulo.Text = "Formulario de Modificacion"
                    .PictureBox_Icon.Image = My.Resources.pencil_48
                    .Cliente = DGV_Clientes.DataSource(DGV_Clientes.SelectedRows(0).Index)
            End Select
            .CargarFormulario()
            .Modo = pAccion
            .ShowDialog()
        End With
    End Sub
    Private Sub ctrl_Clientes_EstadoOperacion(pEstadoOperacion As Model.eEstadoOperacion, pTipoOperacion As Model.eTipoOperacion) Handles ctrl_Clientes.EstadoOperacion
        Select Case pTipoOperacion
            Case Model.eTipoOperacion.Alta Or Model.eTipoOperacion.Ediicion Or Model.eTipoOperacion.Borrado
                Select Case pEstadoOperacion
                    Case Model.eEstadoOperacion.Finalizada
                        ActualizarFormulario()
                End Select
        End Select
    End Sub

#Region "Metodos, Funciones y Mejoras del Formulario"
    Public Sub ActualizarFormulario()
        ctrl_Clientes.ActualizarCatalogo()
        DGV_Clientes.DataSource = Nothing
        DGV_Clientes.DataSource = ctrl_Clientes.ObtenerCatalogo
        DGV_Clientes.Refresh()
        DGV_Clientes.Update()
    End Sub

    Private Sub ToolTips()
        ToolTip_AMBC.SetToolTip(BTN_Agregar, "Agregar nuevo cliente.")
        ToolTip_AMBC.SetToolTip(BTN_Modificar, "Modificar el cliente selecionado.")
        ToolTip_AMBC.SetToolTip(BTN_Borrar, "Borrar el o los clientes seleccionados.")
        ToolTip_AMBC.SetToolTip(BTN_Ayuda, "Mostrar ayuda sobre la pantalla.")
    End Sub
    Private Function ObtenerIDsSelecionados() As List(Of Integer)
        Dim vRet As New List(Of Integer)
        'vRet.Clear()
        If DGV_Clientes.SelectedRows.Count > 0 Then
            For i = 0 To DGV_Clientes.Rows.Count - 1
                If DGV_Clientes.Rows(i).Selected Then
                    vRet.Add(DGV_Clientes.Rows(i).Cells.Item(0).Value)
                End If
            Next
        End If
        Return vRet
    End Function
#End Region



    
    Private Sub DGV_Clientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_Clientes.CellContentClick

    End Sub
End Class