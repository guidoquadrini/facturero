Public Class Form_Cliente
    Public Modo As Model.eAMBC_Acciones
    Public Event DatosValidadosSatisfactoriamente(ByVal pModo As Model.eAMBC_Acciones)
    'Property Cliente As DataGridViewRow
    Property Cliente As Model.Cliente

#Region "Acciones"

    Private Sub BTN_Cancelar_Click(sender As Object, e As EventArgs) Handles BTN_Cancelar.Click
        LimpiarFormulario()
        Me.Close()
    End Sub
    Private Sub Button_Guadar_Click(sender As Object, e As EventArgs) Handles Button_Guadar.Click
        If DatosValidos() Then
            RaiseEvent DatosValidadosSatisfactoriamente(Modo)
            Me.Hide()
        Else
            MostrarInformeDatosInvalidos()
        End If
    End Sub
#End Region

#Region "Validaciones"
    Private Function DatosValidos() As Boolean
        Dim vRet As Boolean = True
        'Debo revisar que los campos del formulario sean correctos.
        Return vRet
    End Function
    Private Sub MostrarInformeDatosInvalidos()
        MsgBox("Revise los datos ingresados.")
        'Throw New NotImplementedException
    End Sub
#End Region

#Region "Conversiones"
    Public Function ToArray()
        Dim vRet As New ArrayList

        With vRet
            .Add(TextBox_ID)
            .Add(TextBox_Nombre)
            .Add(TextBox_Apellido)
            .Add(TextBox_Empresa)
            .Add(TextBox_Email)
            .Add(TextBox_Direccion)
            .Add(TextBox_Direccion2)
            .Add(TextBox_Telefono)
            .Add(TextBox_Ciudad)
            .Add(TextBox_Provincia)
            .Add(TextBox_CodigoPostal)
            .Add(TextBox_Pais)
            .Add(TextBox_Moneda)
            .Add(TextBox_Contraseña)
        End With

        Return vRet
    End Function
#End Region

    Public Sub CargarFormulario()
        If Not Cliente Is Nothing Then
            TextBox_ID.Text = Cliente.IdCliente
            TextBox_Nombre.Text = Cliente.PrimerNombre
            TextBox_Apellido.Text = Cliente.Apellido
            TextBox_Empresa.Text = Cliente.NombreEmpresa
            TextBox_Email.Text = Cliente.eMail
            TextBox_Direccion.Text = Cliente.Direccion1
            TextBox_Direccion2.Text = Cliente.Direccion2
            TextBox_Telefono.Text = Cliente.Telefono
            TextBox_Ciudad.Text = Cliente.Ciudad
            TextBox_Provincia.Text = Cliente.Provincia
            TextBox_CodigoPostal.Text = Cliente.CodigoPostal
            TextBox_Pais.Text = Cliente.Pais
            TextBox_Moneda.Text = Cliente.Moneda
            TextBox_Contraseña.Text = Cliente.Contraseña
        End If

    End Sub

    Sub LimpiarFormulario()
        Cliente = Nothing
        TextBox_ID.Text = String.Empty
        TextBox_Nombre.Text = String.Empty
        TextBox_Apellido.Text = String.Empty
        TextBox_Empresa.Text = String.Empty
        TextBox_Email.Text = String.Empty
        TextBox_Direccion.Text = String.Empty
        TextBox_Direccion2.Text = String.Empty
        TextBox_Telefono.Text = String.Empty
        TextBox_Ciudad.Text = String.Empty
        TextBox_Provincia.Text = String.Empty
        TextBox_CodigoPostal.Text = String.Empty
        TextBox_Pais.Text = String.Empty
        TextBox_Moneda.Text = String.Empty
        TextBox_Contraseña.Text = String.Empty
    End Sub

    
End Class