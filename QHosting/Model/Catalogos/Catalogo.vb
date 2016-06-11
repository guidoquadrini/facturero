Imports System.Reflection
Imports Conexion.Conexion
Imports System.Data.DataColumn

Public Class Catalogo
    Public Catalogo As List(Of Object)
    Public tipo As Type
    Private oConn As Conexion.Conexion = Conexion.Conexion.GetInstance

    Public Sub New(ByVal pEntidad As String, ByVal pTabla As String)
        Try

            tipo = Type.GetType(pEntidad)
            Dim [obj] As Object = Nothing  '= Activator.CreateInstance(tipo)
            Catalogo = New List(Of Object)
            CargarCatalogo(tipo, pTabla)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CargarCatalogo(ByVal pTipo As Type, ByVal pTabla As String)
        Dim wQuery As String = String.Empty
        wQuery = "SELECT * FROM " + pTabla + ";"
        Dim wResultado As DataTable = Nothing
        Try
            wResultado = oConn.Query(wQuery)
            If wResultado Is Nothing Then Throw New Exception("No se encontraron datos para la consulta.")
        Catch ex As Exception
            '   MsgBox(ex.Message)
        End Try
        'Ejecuto Consulta y se la asigno a Resultado.
        Try
            Dim Obj As Object 'Model.Cliente
            For Each iRow As DataRow In wResultado.Rows
                Dim [ParamArray] As Object()
                [ParamArray] = New Object() {iRow}
                Obj = Activator.CreateInstance(pTipo, [ParamArray])
                Catalogo.Add(Obj)
            Next
        Catch ex As Exception
            '     MsgBox(ex.Message)
        End Try
    End Sub

    Function toDataTable() As DataTable
        Dim vRet As New DataTable
        'vRet = Nothing
        'Creo Tabla
        For Each iProperty In tipo.GetProperties
            vRet.Columns.Add(New DataColumn(iProperty.Name, iProperty.PropertyType))
        Next
        'Recorro Coleccion
        For Each iObject As Object In Catalogo
            '  09'Dim wDR As New DataRow(iObject.toArray)
            ' Dim wDR As DataRow
            ' wDR.Item(= CType(iObject, Model.Cliente)y




            vRet.Rows.Add(iObject.toArray)
        Next
        Return vRet
    End Function

End Class
