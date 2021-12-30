Imports DevExpress.Map.Native
Imports System.Net.Mail
Imports System.Data.SqlClient

Public Class ClaseStore
    Private Sub Enviar_Formulario_Correo()

        Dim warnings As Warning() = Nothing
        Dim streamids As String() = Nothing
        Dim mimeType As String = Nothing
        Dim encoding As String = Nothing
        Dim extension As String = Nothing
        Dim correos As ArrayList
        Dim body As New StringBuilder
        Dim body2 As String = ""
        Dim bytes As Byte()
        'bytes = ReportViewer1.ServerReport.Render("PDF", Nothing, mimeType, encoding, extension, streamids, warnings)
        '   Dim ms As New System.IO.MemoryStream(bytes)
        Dim attachment As Attachment
        Dim message As MailMessage = New MailMessage
        ' correos = CorreosEnvío.Obtener_Correos()
        'correos = Obtener_Correos()
        'message.Attachments.Add(attachment)
        message.From = New MailAddress("no.reply.ssp@aviacioncivil.gob.ec")

        For i As Integer = 0 To correos.Count - 1 Step 1
            message.To.Add(correos.Item(i))
        Next

        message.Subject = "Formulario Voluntario"
        message.IsBodyHtml = True

        

        message.Body = body.ToString()
        Dim smtp As SmtpClient = New SmtpClient("mail.aviacioncivil.gob.ec")
        smtp.Credentials = New System.Net.NetworkCredential("DGAC\no.reply.ssp", "no.reply")

        smtp.Send(message)


    End Sub

    
End Class
