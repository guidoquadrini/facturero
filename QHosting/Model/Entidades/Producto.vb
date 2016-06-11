Public Class Producto
    Inherits BaseModel

    Property ID As Integer
    Property CodigoInteligente As String
    Property DescripcionCorta As String
    Property DescripcionLarga As String
    Property Cantidad As Decimal
    Property Proveedor As Integer
    Property Fabricante As Integer
    Property Estado As eEstadoRegistro
    Property Costo As Decimal
    Property OrdenDeCompra As Integer
    Property PuntoDePedido As Decimal
    Property Minimo As Decimal
    Property Maximo As Decimal

    Public Sub New()
        MyBase.New()
    End Sub
    Public Sub New(ByVal pObj As Object)
        MyBase.New(pObj)
    End Sub
    Public Sub New(ByVal pRow As DataRow)
        MyBase.New(pRow)
    End Sub

    'Sub New(pID As String, pDescripcion As String, pProveedor As String, pNombreEmpresa As String _
    '        , pEmail As String, pDireccion1 As String, pDireccion2 As String, pCiudad As String _
    '        , pProvincia As String, pCodigoPostal As String, pPais As String, pTelefono As String _
    '        , pMoneda As String, pContraseña As String)
    '    IdCliente = IIf(pIdCliente.Equals(String.Empty), Nothing, pIdCliente)
    '    PrimerNombre = pPrimerNombre
    '    Apellido = pApellido
    '    NombreEmpresa = pNombreEmpresa
    '    email = pEmail
    '    Direccion1 = pDireccion1
    '    Direccion2 = pDireccion2
    '    Ciudad = pCiudad
    '    Provincia = pProvincia
    '    CodigoPostal = pCodigoPostal
    '    Pais = pPais
    '    Telefono = pTelefono
    '    Contraseña = pContraseña
    '    Moneda = pMoneda
    'End Sub

End Class
