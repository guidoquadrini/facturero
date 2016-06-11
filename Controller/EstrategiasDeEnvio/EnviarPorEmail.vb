Imports System.Net.Mail
Imports System.Configuration

Public Class EnviarEmail
    Inherits StrategyEnviarA

    Property Smtp_Server As New SmtpClient
    Property EmailMessage As New MailMessage()
    Private AppReader As New AppSettingsReader
    Property Usuario As String
    Property Password As String
    Property CorreoSaliente
    Property PuertoCorreoSaliente
    Property ProtocoloCorreoSaliente
    Property CorreoEntrante As String
    Property PuertoCorreoEntrante As Integer
    Property ProtocoloCorreoEntrante As String
    Property RequiereAutenticacion As Boolean
    Property Email As MailAddress
    Private Property oDatos As List(Of Object)

    Sub New(poDatos As List(Of Object))
        ' TODO: Complete member initialization 
        _oDatos = poDatos

        Usuario = "guidoquadrini@hotmail.com" 'AppReader.GetValue("Email_Usuario", GetType(String))
        Password = AppReader.GetValue("Email_Contraseña", GetType(String))
        Email = New MailAddress("guidquadrini@hotmail.com") 'AppReader.GetValue("Email_Email", GetType(String))
        ProtocoloCorreoSaliente = "smtp.live.com" 'AppReader.GetValue("Email_SMTP", GetType(String))
        PuertoCorreoSaliente = 587
    End Sub

    Public Overrides Sub Enviar(ByVal pDatos As List(Of Object))
        ' MsgBox("Enviar por Email")

        Try
            Smtp_Server.UseDefaultCredentials = False
            Smtp_Server.Credentials = New Net.NetworkCredential(Usuario, Password)
            Smtp_Server.Port = 587
            Smtp_Server.EnableSsl = True
            Smtp_Server.Host = ProtocoloCorreoSaliente

            EmailMessage = New MailMessage()
            EmailMessage.From = New MailAddress(Email.Address)
            EmailMessage.To.Add("guidoquadrini@hotmail.com")
            EmailMessage.Subject = "Estrategia Email"
            EmailMessage.IsBodyHtml = False
            EmailMessage.Body = "Cuerpo del Mensaje"
            Smtp_Server.EnableSsl = True

            Smtp_Server.Port = PuertoCorreoSaliente
            Smtp_Server.Send(EmailMessage)

            MsgBox("Correo Enviado")

        Catch error_t As Exception
            MsgBox(error_t.ToString)
        End Try


    End Sub

End Class


