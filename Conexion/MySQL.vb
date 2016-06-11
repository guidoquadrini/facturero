Imports MySql.Data.MySqlClient

Public Class Conexion
    Public Property Servidor As String
    Public Property DataBase As String
    Public Property Usuario As String
    Public Property Password As String
    Public Property Conexion As MySqlConnection

    Public Shared ReadOnly Property GetInstance As Conexion
        Get
            Static Instance As Conexion = New Conexion
            Return Instance
        End Get
    End Property
    Private Sub New()
        Servidor = My.Settings.Servidor
        DataBase = My.Settings.DataBase
        Usuario = My.Settings.Usuario
        Password = My.Settings.Password
        Try
            Conexion = New MySqlConnection()
            Conexion.ConnectionString = String.Format("Server={0};Database={1};Uid={2};Pwd={3};Allow Zero Datetime=True;" _
                                                      , Servidor, DataBase, Usuario, Password)
        Catch ex As Exception
            Throw New Exception("No se puede instanciar la conexion. " + ex.Message)
        End Try
    End Sub
    Public Function Conectar() As Boolean
        Try
            Conexion.Open()
            Return True
        Catch ex As MySqlException
            Return False
        End Try
    End Function
    Public Function Desconectar() As Boolean
        Try
            Conexion.Close()
            Return True
        Catch ex As MySqlException
            Return False
        End Try
    End Function
    Public Function Query(ByVal pComando As String, Optional ByVal TipoDeQuery As CommandType = CommandType.Text _
                         , Optional ByVal Accion As Integer = 0 _
                         , Optional ByVal pParamList As List(Of KeyValuePair(Of String, Object)) = Nothing) As DataTable
        Dim wParams As New List(Of Object)
        If Not pParamList Is Nothing Then
            For Each iParam As KeyValuePair(Of String, Object) In pParamList
                wParams.Add(New MySqlParameter("@" + iParam.Key, iParam.Value))
            Next
        End If
        Dim vRet As DataTable = Nothing
        Dim Transaccion As MySqlTransaction
        Conectar()
        Transaccion = Conexion.BeginTransaction
        Dim Comando As MySqlCommand
        Dim DataAdapter As New MySqlDataAdapter
        Dim DataSet As DataSet = Nothing
        DataSet = New DataSet
        Try
            Comando = New MySqlCommand
            With Comando
                .Connection = Conexion
                .Transaction = Transaccion
                .CommandType = TipoDeQuery
                .CommandText = pComando
                If Not pParamList Is Nothing Then
                    .Parameters.Clear()
                    For Each iParm In wParams
                        .Parameters.Add(iParm)
                    Next
                End If
            End With
            DataAdapter.SelectCommand = Comando
            DataAdapter.Fill(DataSet)
            Transaccion.Commit()
            If pParamList Is Nothing And Not Accion = 3 Then vRet = DataSet.Tables(0)

        Catch ex As MySqlException
            Transaccion.Rollback()
            Throw New Exception("Transaccion cancelada. " + ex.Message)
        End Try
        Desconectar()
        Return vRet
    End Function
    Public Function IsConected() As Boolean
        Dim vRet As Boolean = False
        If Conexion.State = ConnectionState.Open Then
            vRet = True
        End If
        Return vRet
    End Function

End Class
