Public Class TipoTelefono
    Implements iTrivialObject
    Implements iInspectObject
    Implements iContentObject

    Public Property _ds As Integer Implements iTrivialObject._ds

    Public Property _id As Integer Implements iTrivialObject._id

    Public Property _log As Log Implements iInspectObject._log

    Public Property _obs As Observacion Implements iInspectObject._obs

    Public Property _estado As Estado Implements iContentObject._estado
End Class