Imports System.Reflection

Public MustInherit Class BaseModel

    Public Sub New()

    End Sub

    Public Sub New(pObj As Object)
        Try
            If Not pObj.GetType.Name.Equals(Me.GetType.Name) Then
                Throw New Exception("Error al intentar cargar Instanciar un objecto con otro objeto de distinto tipo. Ambos deben ser del mismo tipo.")
            End If

            For Each iProp As PropertyInfo In Me.GetType.GetProperties
                iProp.SetValue(Me, iProp.GetValue(pObj))
            Next

        Catch ex As Exception
            Throw New Exception(ex.Message, ex.InnerException)
        End Try


    End Sub

    Public Sub New(iRow As DataRow)
        Dim i As Integer = 0
        For Each iProp As PropertyInfo In Me.GetType.GetProperties
            iProp.SetValue(Me, iRow(i))
            i += 1
        Next
    End Sub

    Public Function toArray() As ArrayList
        Dim vRet As ArrayList = Nothing
        vRet = New ArrayList
        For Each iProp As PropertyInfo In Me.GetType.GetProperties
            vRet.Add(iProp.GetValue(Me))
        Next
        Return vRet
    End Function

End Class

