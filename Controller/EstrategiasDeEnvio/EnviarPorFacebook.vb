Public Class EnviarFacebook
    Inherits StrategyEnviarA
    Private Property oDatos As List(Of Object)

    Sub New(poDatos As List(Of Object))
        ' TODO: Complete member initialization 
        _oDatos = poDatos
    End Sub
    Public Overrides Sub Enviar(ByVal poDatos As List(Of Object))
        MsgBox("Enviar a Facebook")
    End Sub

End Class
