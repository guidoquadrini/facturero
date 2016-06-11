Imports Conexion.Conexion
Imports System.Reflection

Public Class Clientes

    Public Property Catalogo As List(Of Model.Cliente)
    Private oConn As Conexion.Conexion = Conexion.Conexion.GetInstance
    Private table = "crm_clientes"
    'Deben solo escribirse las variable autoincrementales.
    Private CLAVES As New List(Of String)

    Public Sub New()
        CLAVES.Add("Id")
        Try
            Catalogo = New List(Of Model.Cliente)
            CargarCatalogo()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub CargarCatalogo()
        Dim wQuery As String = String.Empty
        wQuery = "SELECT * FROM " + Me.table + ";"
        Dim wResultado As DataTable = Nothing
        Try
            wResultado = oConn.Query(wQuery)
            If wResultado Is Nothing Then Throw New Exception("No se encontraron datos para la consulta.")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'Ejecuto Consulta y se la asigno a Resultado.
        Try
            Dim wCliente As Model.Cliente = Nothing
            Catalogo.Clear()
            For Each iRow As DataRow In wResultado.Rows
                wCliente = New Model.Cliente(iRow)
                Catalogo.Add(wCliente)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function BuscarPorId(ByVal pID As Integer) As Model.Cliente
        Dim vRet As Model.Cliente = Nothing
        For Each iCliente As Model.Cliente In Catalogo
            If iCliente.IdCliente.Equals(pID) Then
                vRet = iCliente
                Exit For
            End If
        Next
        Return vRet
    End Function

    Public Function Borrar(ByVal pID As Integer) As Boolean
        Dim wQuery As String = String.Empty
        Try
            wQuery = String.Format("DELETE FROM Clientes WHERE ID = {0};", pID)
            oConn.Query(wQuery, , 3)
            MsgBox(String.Format("El Cliente con ID={0}, fue eliminado con exito.", pID))
        Catch ex As Exception
            If oConn.IsConected Then
                oConn.Desconectar()
            End If
            MsgBox(ex.Message)
        End Try
        Return True
    End Function
    ''' <summary>
    ''' Metodo para actualizar el Catalogo de Clientes
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Actualizar()
        CargarCatalogo()
    End Sub
    ''' <summary>
    ''' Metodo para guardar o actualizar nuevos Clientes.
    ''' </summary>
    ''' <param name="pObjeto">Objeto Cliente</param>
    ''' <param name="pModo">Accion Baja o Modificacion</param>
    ''' <returns>Booleano. True si la operacion se realizo con exito y False en caso contrario.</returns>
    ''' <remarks></remarks>
    Function ActualizarModelo(ByVal pObjeto As Model.Cliente, ByVal pModo As Model.eAMBC_Acciones) As Boolean
        Dim wQuery As String = String.Empty
        Dim vRet As Boolean = False
        Dim wParamList As New List(Of KeyValuePair(Of String, Object))
        Select Case pModo
            Case eAMBC_Acciones.Alta
                wQuery = "INSERT INTO " + Split(Me.GetType.Name, ".")(Split(Me.GetType.Name, ".").Count - 1) + " ("
                For Each iProp In pObjeto.GetType.GetProperties
                    If CLAVES.Any(Function(x As String) x.Equals(iProp.Name)) Then Continue For
                    wQuery += iProp.Name + ", "
                Next
                'Aqui se quita la ultima coma.
                wQuery = wQuery.Substring(0, wQuery.Length - 2)
                wQuery += ") VALUES("
                For Each iProp In pObjeto.GetType.GetProperties
                    If CLAVES.Any(Function(x As String) x.Equals(iProp.Name)) Then Continue For
                    wQuery += "@" + iProp.Name + ", "
                Next
                'Aqui se quita la ultima coma.
                wQuery = wQuery.Substring(0, wQuery.Length - 2)
                wQuery += ")"
                For Each iProp In pObjeto.GetType.GetProperties
                    If CLAVES.Any(Function(x As String) x.Equals(iProp.Name)) Then Continue For
                    wParamList.Add(New KeyValuePair(Of String, Object)(iProp.Name, iProp.GetValue(pObjeto)))
                Next
                MsgBox("Query de Alta: " + wQuery)

            Case eAMBC_Acciones.Modificacion
                wQuery = "UPDATE " + Split(Me.GetType.Name, ".")(Split(Me.GetType.Name, ".").Count - 1) + " SET "
                For Each iProp In pObjeto.GetType.GetProperties
                    If CLAVES.Any(Function(x As String) x.Equals(iProp.Name)) Then Continue For
                    wQuery += iProp.Name + " = @" + iProp.Name + ", "
                Next
                'Aqui se quita la ultima coma.
                wQuery = wQuery.Substring(0, wQuery.Length - 2)
                wQuery += "WHERE "
                For Each iProp In pObjeto.GetType.GetProperties
                    If CLAVES.Any(Function(x As String) Not x.Equals(iProp.Name)) Then Continue For
                    wQuery += iProp.Name + " = @" + iProp.Name + "AND "
                Next
                'Aqui se quita el AND final.
                wQuery = wQuery.Substring(0, wQuery.Length - 4)
                'Asignacion de Parametros No Claves
                For Each iProp In pObjeto.GetType.GetProperties
                    If CLAVES.Any(Function(x As String) x.Equals(iProp.Name)) Then Continue For
                    wParamList.Add(New KeyValuePair(Of String, Object)(iProp.Name, iProp.GetValue(pObjeto)))
                Next
                'Asignacion de Parametros Claves
                For Each iProp In pObjeto.GetType.GetProperties
                    If CLAVES.Any(Function(x As String) Not x.Equals(iProp.Name)) Then Continue For
                    wParamList.Add(New KeyValuePair(Of String, Object)(iProp.Name, iProp.GetValue(pObjeto)))
                Next
                MsgBox("Query de Actualizacion: " + wQuery)
            Case Else
                Throw New Exception("El metodo de la Capa Cliente no puede manipular correctamente el modo solicitado. Modo:" + pModo.ToString)
        End Select
        Try
            If oConn.Query(wQuery, CommandType.Text, , wParamList) Is Nothing Then
                vRet = True
            End If

        Catch ex As Exception
            If oConn.IsConected Then
                oConn.Desconectar()
            End If
            Throw New Exception(ex.Message)
        End Try
        Return vRet
    End Function

End Class
