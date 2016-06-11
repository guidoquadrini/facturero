Public Class Cliente
    Public Property IdCliente As Integer
    Public Property PrimerNombre As String
    Public Property Apellido As String
    Public Property NombreEmpresa As String   
    Public Property eMail As String
    Public Property Direccion1 As String
    Public Property Direccion2 As String
    Public Property Ciudad As String
    Public Property Provincia As String
    Public Property CodigoPostal As String
    Public Property Pais As String
    Public Property Telefono As String
    Public Property Contraseña As String
    Public Property Moneda As Integer

    Public Sub New()
    End Sub
    Sub New(pIdCliente As String, pPrimerNombre As String, pApellido As String, pNombreEmpresa As String _
            , pEmail As String, pDireccion1 As String, pDireccion2 As String, pCiudad As String _
            , pProvincia As String, pCodigoPostal As String, pPais As String, pTelefono As String _
            , pMoneda As String, pContraseña As String)
        IdCliente = IIf(pIdCliente.Equals(String.Empty), Nothing, pIdCliente)
        PrimerNombre = pPrimerNombre
        Apellido = pApellido
        NombreEmpresa = pNombreEmpresa
        eMail = pEmail
        Direccion1 = pDireccion1
        Direccion2 = pDireccion2
        Ciudad = pCiudad
        Provincia = pProvincia
        CodigoPostal = pCodigoPostal
        Pais = pPais
        Telefono = pTelefono
        Contraseña = pContraseña
        Moneda = pMoneda
    End Sub

    Public Sub New(iRow As DataRow)
        IdCliente = iRow(0)
        PrimerNombre = iRow(1)
        Apellido = iRow(2)
        NombreEmpresa = iRow(3)
        eMail = iRow(4)
        Direccion1 = iRow(5)
        Direccion2 = iRow(6)
        Ciudad = iRow(7)
        Provincia = iRow(8)
        CodigoPostal = iRow(9)
        Pais = iRow(10)
        Telefono = iRow(11)
        Contraseña = iRow(12)
        Moneda = iRow(13)
    End Sub

    Public Function toArray() As ArrayList
        Dim vRet As ArrayList = Nothing
        vRet = New ArrayList
        vRet.Add(IdCliente)
        vRet.Add(PrimerNombre)
        vRet.Add(Apellido)
        vRet.Add(NombreEmpresa)
        vRet.Add(eMail)
        vRet.Add(Direccion1)
        vRet.Add(Direccion2)
        vRet.Add(Ciudad)
        vRet.Add(Provincia)
        vRet.Add(CodigoPostal)
        vRet.Add(Pais)
        vRet.Add(Telefono)
        vRet.Add(Contraseña)
        vRet.Add(Moneda)
        Return vRet
    End Function



End Class
