Imports Microsoft.Win32

Public Class RegEdit

    Public Shared Function ObtenerRegistro(ByVal Ruta As String, ByVal Registro As String) As String
        Dim vRet As String = String.Empty
        Dim RegEdit As RegistryKey
        Try
            RegEdit = Registry.LocalMachine.OpenSubKey(Ruta, False)
            vRet = RegEdit.GetValue(Registro).ToString
        Catch ex As Exception
            MsgBox("No existe valores en el registro." & "ObtenerRegistro(Ruta: " & Ruta & " - Registro: " & Registro & ")", MsgBoxStyle.Critical, "Aviso Importante")
            vRet = String.Empty
        End Try
        Return vRet
    End Function

End Class