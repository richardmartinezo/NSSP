Imports System.Data.SqlClient
Imports System.Net.Mail
Imports DevExpress.Map.Native
Imports System.IO
Imports System.Text
Imports System.Data
Imports iTextSharp.text
Imports iTextSharp.text.html.simpleparser
Imports iTextSharp.text.pdf



Public Class CorreosEnvío

    Private Function IsValidEmail(email As String) As Boolean
        Try
            Dim addr = New System.Net.Mail.MailAddress(email)
            Return addr.Address = email
        Catch
            Return False
        End Try
    End Function
    Function EmailAddressCheck(ByVal emailAddress As String) As Boolean

        Dim pattern As String = "^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"
        Dim emailAddressMatch As Match = Regex.Match(emailAddress, pattern)
        If emailAddressMatch.Success Then
            Return True
        Else
            Return False
        End If

    End Function
    'Version 1.0
    Private Function Ultimo_Formulario_id() As String
        Dim ultimo_id As String
        Dim cn As String = "Data Source=win-sqlserv-02;Initial Catalog=SSP_BI;User ID=adminsql;Password=sistema*-!;"
        Dim sql As String = "SELECT TOP 1 * FROM Notificaciones_NSSP ORDER BY id DESC"
        Using conn As New SqlConnection(cn)
            Dim datablasdgac As New SqlDataAdapter(sql, conn)
            Dim dataset As New DataSet("Notificaciones_NSSP")
            datablasdgac.Fill(dataset)
            Dim tablasdgac As DataTable
            tablasdgac = dataset.Tables(0)
            conn.Open()
            If tablasdgac Is Nothing Then
                ultimo_id = 0
            Else
                ultimo_id = tablasdgac.Rows(0)("id")
            End If

            conn.Close()
        End Using
        Return ultimo_id

    End Function
    'Version 1.0
    'ingresar en parametro el nivel de acceso
    Public Overloads Function Obtener_Correos(nombreFormulario As String) As ArrayList
        'Dim con As New SqlClient.SqlConnection
        Dim cn As String = "Data Source=win-sqlserv-02;Initial Catalog=SSP_BI;User ID=adminsql;Password=sistema*-!;"
        Dim sql As String = "select * from Usuarios_SSP where nivel_acceso in "
        Dim where As String = ""
        Dim lista As New ArrayList
        'parametrización de niveles de acceso

        If nombreFormulario.Equals("Formulario Voluntario") Then
            where = "('A')"
            sql = sql + where
        ElseIf nombreFormulario.Equals("Formulario Voluntario ATS") Then
            where = "('A','SMS','ATS-LHD-VOLATC')"
            sql = sql + where
        ElseIf nombreFormulario.Equals("Formulario ATS") Then
            where = "('A','SMS','ATS-LHD-VOLATC')"
            sql = sql + where
        ElseIf nombreFormulario.Equals("Formulario de Aeronaves") Then
            where = "('A','DICA')"
            sql = sql + where
        ElseIf nombreFormulario.Equals("Formulario Reportes Accidentes e Incidentes Operacionales") Then
            where = "('A')"
            sql = sql + where
        ElseIf nombreFormulario.Equals("Formulario LHD") Then
            where = "('SMS','A')"
            sql = sql + where
        ElseIf nombreFormulario.Equals("Formulario ACTIL") Then
            where = "('A','AVSEC')"
            sql = sql + where
        ElseIf nombreFormulario.Equals("Formulario IBIS-AVIS") Then
            where = "('A','DICA-IBIS-AVIS')"
            sql = sql + where

        ElseIf nombreFormulario.Equals("PRUEBAS") Then
            where = "('PRUEBAS')"
            sql = sql + where

        End If


        '  Dim numr As Integer

        Using conn As New SqlConnection(cn)
            Dim datablasdgac As New SqlDataAdapter(sql, conn)
            ' Dim cmd As New SqlCommand(sql, conn)
            Dim dataset As New DataSet("usuarios.ssp")
            datablasdgac.Fill(dataset)
            Dim tablasdgac As DataTable
            tablasdgac = dataset.Tables(0)
            conn.Open()
            Dim i As Integer
            i = 0
            While i < tablasdgac.Rows.Count
                If IsValidEmail(tablasdgac.Rows(i)("mail")) Then
                    lista.Add(tablasdgac.Rows(i)("mail"))
                Else
                End If
                i = i + 1

            End While
            conn.Close()
        End Using
        Return lista

    End Function
    'Version 2.0
    Public Overloads Function Obtener_Correos(nombreFormulario As String, estado As String) As ArrayList
        'Dim con As New SqlClient.SqlConnection
        Dim cn As String = "Data Source=win-sqlserv-02;Initial Catalog=SSP_BI;User ID=adminsql;Password=sistema*-!;"
        Dim sql As String = "select * from Usuarios_SSP where nivel_acceso in "
        Dim where As String = ""
        Dim lista As New ArrayList
        'parametrización de niveles de acceso
        If estado.Equals("PRUEBAS") Then
            If nombreFormulario.Equals("Formulario Voluntario") Then
                where = "('PRUEBAS')"
                sql = sql + where
            ElseIf nombreFormulario.Equals("Formulario Voluntario ATS") Then
                where = "('PRUEBAS')"
                sql = sql + where
            ElseIf nombreFormulario.Equals("Formulario ATS") Then
                where = "('PRUEBAS')"
                sql = sql + where
            ElseIf nombreFormulario.Equals("Formulario de Aeronaves") Then
                where = "('PRUEBAS')"
                sql = sql + where
            ElseIf nombreFormulario.Equals("Formulario Reportes Accidentes e Incidentes Operacionales") Then
                where = "('PRUEBAS')"
                sql = sql + where
            ElseIf nombreFormulario.Equals("Formulario LHD") Then
                where = "('PRUEBAS')"
                sql = sql + where
            ElseIf nombreFormulario.Equals("Formulario ACTIL") Then
                where = "('PRUEBAS')"
                sql = sql + where
            ElseIf nombreFormulario.Equals("Formulario MERC") Then
                where = "('PRUEBAS')"
                sql = sql + where
            ElseIf nombreFormulario.Equals("Formulario IBIS-AVIS") Then
                where = "('PRUEBAS')"
                sql = sql + where

            End If

        Else

            If nombreFormulario.Equals("Formulario Libre") Then
                where = "('A')"
                sql = sql + where

            ElseIf nombreFormulario.Equals("Formulario Voluntario") Then
                where = "('A')"
                sql = sql + where
            ElseIf nombreFormulario.Equals("Formulario Voluntario ATS") Then
                where = "('A','SMS','ATS-LHD-VOLATC')"
                sql = sql + where
            ElseIf nombreFormulario.Equals("Formulario ATS") Then
                where = "('A','SMS','ATS-LHD-VOLATC')"
                sql = sql + where
            ElseIf nombreFormulario.Equals("Formulario de Aeronaves") Then
                where = "('A','DICA')"
                sql = sql + where
            ElseIf nombreFormulario.Equals("Formulario Reportes Accidentes e Incidentes Operacionales") Then
                where = "('A')"
                sql = sql + where
            ElseIf nombreFormulario.Equals("Formulario LHD") Then
                where = "('SMS','A')"
                sql = sql + where
            ElseIf nombreFormulario.Equals("Formulario ACTIL") Then
                where = "('A','AVSEC')"
                sql = sql + where
            ElseIf nombreFormulario.Equals("Formulario IBIS-AVIS") Then
                where = "('A','DICA-IBIS-AVIS')"
                sql = sql + where
            ElseIf nombreFormulario.Equals("Formulario MERC") Then
                where = "('A','MERC')"
                sql = sql + where

            End If
        End If

            '  Dim numr As Integer

            Using conn As New SqlConnection(cn)
                Dim datablasdgac As New SqlDataAdapter(sql, conn)
                ' Dim cmd As New SqlCommand(sql, conn)
                Dim dataset As New DataSet("usuarios.ssp")
                datablasdgac.Fill(dataset)
                Dim tablasdgac As DataTable
                tablasdgac = dataset.Tables(0)
                conn.Open()
                Dim i As Integer
                i = 0
                While i < tablasdgac.Rows.Count
                    If IsValidEmail(tablasdgac.Rows(i)("mail")) Then
                        lista.Add(tablasdgac.Rows(i)("mail"))
                    Else
                    End If
                    i = i + 1

                End While
                conn.Close()
            End Using
            Return lista

    End Function
    Public Function Obtener_Correos_ATS() As ArrayList
        'Dim con As New SqlClient.SqlConnection
        Dim cn As String = "Data Source=win-sqlserv-02;Initial Catalog=SSP_BI;User ID=adminsql;Password=sistema*-!;"
        Dim sql As String = "select * from Usuarios_SSP where nivel_acceso in ('A', 'SMS')"
        Dim lista As New ArrayList

        '  Dim numr As Integer

        Using conn As New SqlConnection(cn)
            Dim datablasdgac As New SqlDataAdapter(sql, conn)
            ' Dim cmd As New SqlCommand(sql, conn)
            Dim dataset As New DataSet("usuarios.ssp")
            datablasdgac.Fill(dataset)
            Dim tablasdgac As DataTable
            tablasdgac = dataset.Tables(0)
            conn.Open()
            Dim i As Integer
            i = 0
            While i < tablasdgac.Rows.Count
                If IsValidEmail(tablasdgac.Rows(i)("mail")) Then
                    lista.Add(tablasdgac.Rows(i)("mail"))
                Else
                End If
                i = i + 1

            End While
            conn.Close()
        End Using
        Return lista

    End Function
    'Version 1.0
    Public Overloads Sub Enviar_Formulario_Correo_Lista(campos_formulario As ArrayList, nombre_formulario As String)
        Dim warnings As Warning() = Nothing
        Dim streamids As String() = Nothing
        Dim mimeType As String = Nothing
        Dim encoding As String = Nothing
        Dim extension As String = Nothing
        Dim correos As ArrayList
        Dim body As New StringBuilder
        Dim stringreader As StringReader
        Dim pdfDoc As New Document(PageSize.A4, 10.0F, 10.0F, 10.0F, 0.0F)
        Dim htmlparser As New HTMLWorker(pdfDoc)
        Dim message As MailMessage = New MailMessage
        Dim ultimo_form As String = Ultimo_Formulario_id()

        correos = Obtener_Correos(nombre_formulario)
        'correos = Obtener_Correos(nombre_formulario, "PRUEBAS")

        message.From = New MailAddress("no.reply.ssp@aviacioncivil.gob.ec")
        'cargar correos de bd
        For i As Integer = 0 To correos.Count - 1 Step 1
            message.To.Add(correos.Item(i))
        Next
        message.Subject = nombre_formulario
        message.IsBodyHtml = True
        'cargar campos de formularios

        For Each cadena As String In campos_formulario
            body.AppendLine(cadena)
        Next
        'cargar el body en el correo y preparar texto de pdf
        message.Body = body.ToString()
        stringreader = New StringReader(body.ToString())
        ' envío de pdf hasta el fin del using
        Using memoryStream As New MemoryStream()
            Dim writer As PdfWriter = PdfWriter.GetInstance(pdfDoc, MemoryStream)
            pdfDoc.Open()
            htmlparser.Parse(stringreader)
            pdfDoc.Close()
            Dim bytes As Byte() = MemoryStream.ToArray()
            memoryStream.Close()
            message.Attachments.Add(New Attachment(
                                    New MemoryStream(bytes), nombre_formulario + "-" + ultimo_form + "-" + (Now.ToString().Substring(6)).Split(" ")(0) + ".pdf"))
        End Using

        Dim smtp As SmtpClient = New SmtpClient("172.20.16.21")
        smtp.Credentials = New System.Net.NetworkCredential("DGAC\no.reply.ssp", "no.reply.ssp2020")

        smtp.Send(message)

    End Sub
    'Version 2.0
    Public Overloads Sub Enviar_Formulario_Correo_Lista(campos_formulario As ArrayList, nombre_formulario As String, codigo_formulario As String, ambiente As String)
        Dim warnings As Warning() = Nothing
        Dim streamids As String() = Nothing
        Dim mimeType As String = Nothing
        Dim encoding As String = Nothing
        Dim extension As String = Nothing
        Dim correos As ArrayList
        Dim body As New StringBuilder
        Dim stringreader As StringReader
        Dim pdfDoc As New Document(PageSize.A4, 10.0F, 10.0F, 10.0F, 0.0F)
        Dim htmlparser As New HTMLWorker(pdfDoc)
        Dim message As MailMessage = New MailMessage
        Dim ultimo_form As String = Ultimo_Formulario_id()

        correos = Obtener_Correos(nombre_formulario, ambiente)


        message.From = New MailAddress("no.reply.ssp@aviacioncivil.gob.ec")
        'cargar correos de bd
        For i As Integer = 0 To correos.Count - 1 Step 1
            message.To.Add(correos.Item(i))
        Next
        If nombre_formulario.Equals("Formulario Voluntario") Then
            message.Subject = "Notificación Libre"
        ElseIf nombre_formulario.Equals("Formulario Voluntario ATS") Then
            message.Subject = "Formulario Voluntario ATS"
        ElseIf nombre_formulario.Equals("Formulario IBIS-AVIS") Then
            message.Subject = "Formulario IBIS"
        Else
            message.Subject = nombre_formulario
        End If

        message.IsBodyHtml = True
        'cargar campos de formularios

        For Each cadena As String In campos_formulario
            body.AppendLine(cadena)
        Next
        'cargar el body en el correo y preparar texto de pdf
        message.Body = body.ToString()
        stringreader = New StringReader(body.ToString())
        ' envío de pdf hasta el fin del using
        Using memoryStream As New MemoryStream()
            Dim writer As PdfWriter = PdfWriter.GetInstance(pdfDoc, memoryStream)
            pdfDoc.Open()
            htmlparser.Parse(stringreader)
            pdfDoc.Close()
            Dim bytes As Byte() = memoryStream.ToArray()
            memoryStream.Close()
            'cambiar el VOL por LIB
            message.Attachments.Add(New Attachment(
                                    New MemoryStream(bytes), codigo_formulario + "-" + ultimo_form + "-" + (Now.ToString().Substring(6)).Split(" ")(0) + ".pdf"))
        End Using

        Dim smtp As SmtpClient = New SmtpClient("172.20.16.21")
        smtp.Credentials = New System.Net.NetworkCredential("DGAC\no.reply.ssp", "no.reply.ssp2020")

        smtp.Send(message)

    End Sub
    'Version 3.0
    Public Overloads Sub Enviar_Formulario_Correo_Lista_Archivo(campos_formulario As ArrayList, nombre_formulario As String, codigo_formulario As String,
                                                                ambiente As String, nombre_archivo As String, byte_archivo As Byte())
        Dim warnings As Warning() = Nothing
        Dim streamids As String() = Nothing
        Dim mimeType As String = Nothing
        Dim encoding As String = Nothing
        Dim extension As String = Nothing
        Dim correos As ArrayList
        Dim body As New StringBuilder
        Dim stringreader As StringReader
        Dim pdfDoc As New Document(PageSize.A4, 10.0F, 10.0F, 10.0F, 0.0F)
        Dim htmlparser As New HTMLWorker(pdfDoc)
        Dim message As MailMessage = New MailMessage
        Dim ultimo_form As String = Ultimo_Formulario_id()

        correos = Obtener_Correos(nombre_formulario, ambiente)


        message.From = New MailAddress("no.reply.ssp@aviacioncivil.gob.ec")
        'cargar correos de bd
        For i As Integer = 0 To correos.Count - 1 Step 1
            message.To.Add(correos.Item(i))
        Next
        If nombre_formulario.Equals("Formulario Voluntario") Then
            message.Subject = "Notificación Libre"
        ElseIf nombre_formulario.Equals("Formulario Voluntario ATS") Then
            message.Subject = "Formulario Voluntario ATS"
        ElseIf nombre_formulario.Equals("Formulario IBIS-AVIS") Then
            message.Subject = "Formulario IBIS"
        Else
            message.Subject = nombre_formulario
        End If

        message.IsBodyHtml = True
        'cargar campos de formularios

        For Each cadena As String In campos_formulario
            body.AppendLine(cadena)
        Next
        'cargar el body en el correo y preparar texto de pdf
        message.Body = body.ToString()
        stringreader = New StringReader(body.ToString())
        ' envío de pdf hasta el fin del using
        Using memoryStream As New MemoryStream()
            Dim writer As PdfWriter = PdfWriter.GetInstance(pdfDoc, memoryStream)
            pdfDoc.Open()
            htmlparser.Parse(stringreader)
            pdfDoc.Close()
            Dim bytes As Byte() = memoryStream.ToArray()
            memoryStream.Close()
            'cambiar el VOL por LIB
            message.Attachments.Add(New Attachment(
                                    New MemoryStream(bytes),
                                    codigo_formulario + "-" + ultimo_form + "-" +
                                    (Now.ToString().Substring(6)).Split(" ")(0) + ".pdf"))

            If byte_archivo Is Nothing And nombre_archivo Is Nothing Then

            ElseIf nombre_archivo.Equals("") Then


            Else
                message.Attachments.Add(New Attachment(
                                    New MemoryStream(byte_archivo), nombre_archivo))
            End If
            
        End Using

        Dim smtp As SmtpClient = New SmtpClient("172.20.16.21")
        smtp.Credentials = New System.Net.NetworkCredential("DGAC\no.reply.ssp", "no.reply.ssp2020")

        smtp.Send(message)

    End Sub
    'Version 1.0
    'Envío de confirmación de correo
    Public Overloads Sub Enviar_Confirmacion_Correo(nombre_formulario As String, correo_electronico As String)
        Dim warnings As Warning() = Nothing
        Dim streamids As String() = Nothing
        Dim mimeType As String = Nothing
        Dim encoding As String = Nothing
        Dim extension As String = Nothing
        Dim correos As ArrayList
        Dim body As New StringBuilder
        Dim stringreader As StringReader

        Dim message As MailMessage = New MailMessage
        correos = Obtener_Correos(nombre_formulario, "PRODUCCION")
        message.From = New MailAddress("no.reply.ssp@aviacioncivil.gob.ec")
        'cargar correos de bd
        If EmailAddressCheck(correo_electronico) Then
            message.To.Add(correo_electronico)
        Else
            Exit Sub
        End If

        message.Subject = "Notificación Recibida por la Dirección General de Aviación Civil"
        message.IsBodyHtml = True
        'cargar campos de formularios
        body.AppendLine("Notificación Recibida por la Dirección General de Aviación Civil")
        body.AppendLine("<p></p>")
        body.AppendLine("La Dirección General de Aviación Civil agradece su notificación")
        body.AppendLine("<p></p>")
        body.AppendLine("Misma que será revisada a la brevedad posible.")
        'cargar el body en el correo y preparar texto de pdf
        message.Body = body.ToString()
        stringreader = New StringReader(body.ToString())

        Dim smtp As SmtpClient = New SmtpClient("172.20.16.21")
        smtp.Credentials = New System.Net.NetworkCredential("DGAC\no.reply.ssp", "no.reply.ssp2020")

        smtp.Send(message)

    End Sub


    Public Sub Enviar_Formulario_Correo_Lista_VOL_ATS(campos_formulario As ArrayList, nombre_formulario As String)
        Dim warnings As Warning() = Nothing
        Dim streamids As String() = Nothing
        Dim mimeType As String = Nothing
        Dim encoding As String = Nothing
        Dim extension As String = Nothing
        Dim correos As ArrayList
        Dim body As New StringBuilder
        Dim stringreader As StringReader
        Dim pdfDoc As New Document(PageSize.A4, 10.0F, 10.0F, 10.0F, 0.0F)
        Dim htmlparser As New HTMLWorker(pdfDoc)
        Dim message As MailMessage = New MailMessage
        Dim ultimo_form As String = Ultimo_Formulario_id()

        correos = Obtener_Correos_ATS()

        message.From = New MailAddress("no.reply.ssp@aviacioncivil.gob.ec")
        'cargar correos de bd
        For i As Integer = 0 To correos.Count - 1 Step 1
            message.To.Add(correos.Item(i))
        Next
        message.Subject = nombre_formulario
        message.IsBodyHtml = True
        'cargar campos de formularios

        For Each cadena As String In campos_formulario
            body.AppendLine(cadena)
        Next
        'cargar el body en el correo y preparar texto de pdf
        message.Body = body.ToString()
        stringreader = New StringReader(body.ToString())
        ' envío de pdf hasta el fin del using
        Using memoryStream As New MemoryStream()
            Dim writer As PdfWriter = PdfWriter.GetInstance(pdfDoc, memoryStream)
            pdfDoc.Open()
            htmlparser.Parse(stringreader)
            pdfDoc.Close()
            Dim bytes As Byte() = memoryStream.ToArray()
            memoryStream.Close()
            message.Attachments.Add(New Attachment(
                                    New MemoryStream(bytes), nombre_formulario + "-" + ultimo_form + "-" + (Now.ToString().Substring(6)).Split(" ")(0) + ".pdf"))
        End Using

        Dim smtp As SmtpClient = New SmtpClient("172.20.16.21")
        smtp.Credentials = New System.Net.NetworkCredential("DGAC\no.reply.ssp", "no.reply.ssp2020")

        smtp.Send(message)

    End Sub



End Class
