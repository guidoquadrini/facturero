Public Class AlojamientoWeb
    Implements iTrivialObject
    Implements iContentObject
    Implements iInspectObject

    Private _Host As Host
    Private _Cliente As Cliente

    Public Property _ds As Integer Implements iTrivialObject._ds

    Public Property _id As Integer Implements iTrivialObject._id

    Public Property _estado As Estado Implements iContentObject._estado

    Public Property _log As Log Implements iInspectObject._log

    Public Property _obs As Observacion Implements iInspectObject._obs
End Class
