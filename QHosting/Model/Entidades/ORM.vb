Imports System
Imports System.Data.Entity
Imports System.Linq

Public Class ORM
    Inherits DbContext

    ' El contexto se ha configurado para usar una cadena de conexión 'ORM' del archivo 
        ' de configuración de la aplicación (App.config o Web.config). De forma predeterminada, 
        ' esta cadena de conexión tiene como destino la base de datos 'Model.ORM' de la instancia LocalDb. 
        ' 
        ' Si desea tener como destino una base de datos y/o un proveedor de base de datos diferente, 
        ' modifique la cadena de conexión 'ORM'  en el archivo de configuración de la aplicación.
    Public Sub New()
        MyBase.New("name=ORM")
    End Sub

    ' Agregue un DbSet para cada tipo de entidad que desee incluir en el modelo. Para obtener más información 
        ' sobre cómo configurar y usar un modelo Code First, vea http://go.microsoft.com/fwlink/?LinkId=390109.
    ' Public Overridable Property MyEntities() As DbSet(Of MyEntity)

End Class

'Public Class MyEntity
'    Public Property Id() As Int32
'    Public Property Name() As String
'End Class

Public Class Applicacion
    Public Property Id() As Int32
    Public Property Name() As String
End Class
