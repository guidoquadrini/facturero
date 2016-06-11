Public Class CTRL_EnviarA
    Public EnviarA As StrategyEnviarA

    Public Sub New(EstrategiaDeEnvio As StrategyEnviarA)
        EnviarA = EstrategiaDeEnvio
    End Sub

    Public Sub Enviar(ByVal poDatos As List(Of Object))
        EnviarA.Enviar(poDatos)
    End Sub
End Class
