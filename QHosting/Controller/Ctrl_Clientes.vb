Imports Model

Public Class Ctrl_Clientes

    Event EstadoOperacion(pEstadoOperacion As Model.eEstadoOperacion, pTipoOperacion As Model.eTipoOperacion)

    Public Property Clientes As Model.Clientes
    Private Property Filtro As String
    Public Event MostrarFormularioAltaEdicion(ByVal Modo As eAMBC_Acciones)

    Public Sub New()
        Filtro = String.Empty
        Clientes = New Model.Clientes
    End Sub

    Public Function ObtenerCatalogo() As List(Of Model.Cliente)
        Dim vRet As New List(Of Model.Cliente)
        vRet = Clientes.Catalogo
        Return vRet
    End Function
    Public Sub ActualizarCatalogo()
        Clientes.Actualizar()
    End Sub

#Region "Filtrado"
    Function FiltrarClientes(pFiltro As String) As Object
        Dim Coleccion As New List(Of Model.Cliente)
        For Each iCliente In Me.Clientes.Catalogo
            Dim arrCliente As ArrayList = iCliente.toArray
            For i = 0 To arrCliente.Count - 1
                If arrCliente(i).ToString.ToUpper Like String.Format("*{0}*", pFiltro.ToUpper) Then
                    Coleccion.Add(iCliente)
                    Exit For
                End If
            Next
        Next
        Return Coleccion
    End Function

#End Region

    Sub Borrar(pList As List(Of Integer))
        Dim i As Integer = 0
        For Each iItem In pList
            If Clientes.Borrar(iItem) Then
                i += 1
            End If
        Next
        'MsgBox(String.Format("Se borraron {0} de {1} Clientes.", i, pList.Count))
    End Sub

    Sub Actualizacion(wCliente As Model.Cliente, ByVal pModo As Model.eAMBC_Acciones)
        Select Case pModo
            Case eAMBC_Acciones.Alta
                If Clientes.ActualizarModelo(wCliente, pModo) Then
                    RaiseEvent EstadoOperacion(Model.eEstadoOperacion.Finalizada, eAMBC_Acciones.Alta)
                End If
            Case eAMBC_Acciones.Modificacion
                If Clientes.ActualizarModelo(wCliente, pModo) Then
                    RaiseEvent EstadoOperacion(Model.eEstadoOperacion.Finalizada, eAMBC_Acciones.Modificacion)
                End If
            Case Else
        End Select
    End Sub

End Class


