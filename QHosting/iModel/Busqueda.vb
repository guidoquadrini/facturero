Public Class Busqueda

    Shared Function NeedleInTheHaystack(Needle As String, Haystack() As Object) As Boolean
        Dim vRet As Boolean = False
        For Each Element In Haystack
            If Needle.Equals(Element) Then
                vRet = True
                Exit For
            End If
        Next
        Return vRet
    End Function

End Class
