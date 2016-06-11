Imports Controller
Public Class Form_EnviarA
    Public Property CTRL_EnviarA As Ctrl_enviarA
    Private Property Hab_Email As Boolean
    Private Property Hab_Reporte As Boolean
    Private Property Hab_PDF As Boolean
    Private Property Hab_Excel As Boolean
    Private Property Hab_Impresion As Boolean

    Property DT_Datos As DataTable
    Property oDatos As List(Of Object)


    Private Sub EnviarA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Hab_Email = True
        'Hab_Facebook = True
        ' Hab_WhatsApp = True
        Hab_Impresion = True
        Hab_Reporte = True
        Hab_Excel = True
        '  Hab_Word = True
        Hab_PDF = True
        ' Hab_RedesSociales = True
        '  Hab_Twitter = True
        'TomarConfiguraciones()
        'CargarServiciosActivos("AMBC_Clientes")
        ' CargarListadoDeServiciosDisponibles()

    End Sub

    Private Sub ListView1_ItemActivate(sender As Object, e As EventArgs) Handles ListView_Estrategias.ItemActivate
        Select Case ListView_Estrategias.SelectedIndices.Item(0)
            Case eEstrategia.Email
                CTRL_EnviarA = New CTRL_EnviarA(New EnviarEmail(oDatos))
            Case eEstrategia.Facebook
                CTRL_EnviarA = New CTRL_EnviarA(New EnviarFacebook(oDatos))
                'Case eEstrategia.WhatsApp
                '    CTRL_EnviarA = New CTRL_EnviarA(New EnviarEmail())
                'Case eEstrategia.Reporte
                '    CTRL_EnviarA = New CTRL_EnviarA(New EnviarEmail())
                'Case eEstrategia.Impresion
                '    CTRL_EnviarA = New CTRL_EnviarA(New EnviarEmail())
                'Case eEstrategia.PDF
                '    CTRL_EnviarA = New CTRL_EnviarA(New EnviarEmail())
                'Case eEstrategia.Excel
                '    CTRL_EnviarA = New CTRL_EnviarA(New EnviarEmail())
        End Select
        CTRL_EnviarA.Enviar(oDatos)
        Me.Hide()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView_Estrategias.SelectedIndexChanged

    End Sub

    Private Enum eEstrategia
        Email = 0
        Facebook = 1
        WhatsApp = 2
        Reporte = 3
        Impresion = 4
        PDF = 5
        Excel = 6
    End Enum
End Class