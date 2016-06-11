Public Class ArrayAsociativo
    Property [Array] As New List(Of Binomio)
End Class
Public Class Binomio
    Property Key As String
    Property Value As Object
    Sub New()
    End Sub
    Sub New(ByVal pKey As String, ByVal pValue As Object)
        Key = pKey
        value = pValue
    End Sub
End Class
