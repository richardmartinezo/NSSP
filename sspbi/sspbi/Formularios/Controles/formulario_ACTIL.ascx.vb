Imports System.Reflection
Imports System.Data.SqlClient

Public Class formulario_ACTIL
    Inherits System.Web.UI.UserControl
    Private CorreosEnvío As New CorreosEnvío
    Private guardararchivosbd As New Guardar_Archivos_BD
    Private id_formulario As Integer
    Private repeticiones As Integer
    Private comilla As String = "'\u0022'"
    Private ambiente As String
    Private nombre_archivo As String = ""
    Private archivo As Byte()

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        repeticiones = 0
    End Sub

    Protected Sub ASPxButton1_Click(sender As Object, e As EventArgs) Handles ASPxButtonEnviar.Click

       
            ASPxPopupControl2.ShowOnPageLoad = True
            ScriptManager.RegisterClientScriptBlock(Me, Me.Page.GetType(), "dxsi_HidePopup", "ASPxPopupControl2.Show();", True)

            Ingreso_Formulario()
        Enviar_Formulario_Correo()
        If id_formulario = Nothing Then
        Else
            guardararchivosbd.insertar_archivo(id_formulario, nombre_archivo, archivo)
        End If


        

    End Sub
    Private Sub Enviar_Formulario_Correo()
        ' CorreosEnvío.Enviar_Formulario_Correo_Lista(Llenar_Correo_Formulario(), "Formulario ACTIL", "ACTIL", ambiente)
        Try
            CorreosEnvío.Enviar_Formulario_Correo_Lista_Archivo(Llenar_Correo_Formulario(),
                                                           "Formulario ACTIL",
                                                           "ACTIL",
                                                           ambiente,
                                                           nombre_archivo,
                                                           archivo)
        Catch ex As Exception
            CorreosEnvío.Enviar_Formulario_Correo_Lista(Llenar_Correo_Formulario(),
                                                           "Formulario ACTIL",
                                                           "ACTIL",
                                                           ambiente)
        End Try
        Try
            CorreosEnvío.Enviar_Confirmacion_Correo("Formulario ACTIL", ASPxTextBoxEmail.Value)
        Catch ex As Exception

        End Try
       
        ' CorreosEnvío.Enviar_Formulario_Correo_Lista(Llenar_Correo_Formulario(), "PRUEBAS")
    End Sub
    Private Function Llenar_Correo_Formulario() As ArrayList


        Dim datos_formulario As New ArrayList
        datos_formulario.Add("<b>Formulario ACTIL</b>" + "</br>")
        datos_formulario.Add("</br>")

        datos_formulario.Add("<h2>DATOS PERSONALES</h2>")
        datos_formulario.Add("<table>")
        datos_formulario.Add("<tr>")
        datos_formulario.Add("<td><b>ID: </b></td>")
        datos_formulario.Add("<td><b>" + id_formulario.ToString() + "</b></td>")

        If ASPxDateEditFecha.Value Is Nothing Then
            datos_formulario.Add("<td><b>Fecha: </b></td>")
            datos_formulario.Add("<td>" + Now() + "</td>")
            datos_formulario.Add("</tr>")
        Else
            datos_formulario.Add("<td><b>Fecha: </b></td>")
            datos_formulario.Add("<td>" + ASPxDateEditFecha.Value.ToString() + "</td>")
            datos_formulario.Add("</tr>")
        End If

        datos_formulario.Add("<tr>")
        datos_formulario.Add("<td><b>Nombre y Apellido: </b></td>")
        datos_formulario.Add("<td>" + ASPxTextBoxNombreApellido.Value + "</td>")
        datos_formulario.Add("<td><b>Telefono: </b></td>")
        datos_formulario.Add("<td>" + ASPxTextBoxTelefono.Value + "</td>")
        datos_formulario.Add("</tr>")


        datos_formulario.Add("<tr>")
        datos_formulario.Add("<td><b>E-mail:</b></td>")
        datos_formulario.Add("<td>" + ASPxTextBoxEmail.Value + " " + "</td>")
        datos_formulario.Add("<td><b>Actividad a la que se dedica: </b></td>")

        datos_formulario.Add("</tr>")
        datos_formulario.Add("</table>")


        'datos_formulario.Add("<div style=" + comilla + "text-align:left; width:80%; margin: 20px auto;" + comilla + ">")
        datos_formulario.Add("<h2>DETALLE INDICENTE/ACCIDENTE/PELIGROS/OPERACIONALES</h2>")
        'datos_formulario.Add("</div>")


        datos_formulario.Add("<table>")

        datos_formulario.Add("<tr>")
        datos_formulario.Add("<td><b>Hora: </b></td>")

        If ASPxTimeEditHora.Value Is Nothing Then
            datos_formulario.Add("<td></td>")
        Else
            datos_formulario.Add("<td>" + ASPxTimeEditHora.Value.ToString().Substring(11) + " </td>")
            datos_formulario.Add("<br>")
        End If
        datos_formulario.Add("</tr>")
        
        datos_formulario.Add("</table>")
       
       

        'datos_formulario.Add("<div style=" + comilla + "text-align:left; width:80%; margin: 20px auto;" + comilla + ">")
        datos_formulario.Add("<h2>IDENTIFICADOR DE LA AERONAVE</h2>")
        'datos_formulario.Add("</div>")
        datos_formulario.Add("<table >")
        datos_formulario.Add("<tr>")
        datos_formulario.Add("<td><b>Identificador:</b> </td>")
        If ASPxTextBoxIdentificacion.Value Is Nothing Then
            datos_formulario.Add("<td><b></b></td>")
            datos_formulario.Add("<br>")
        Else
            datos_formulario.Add("<td>" + ASPxTextBoxIdentificacion.Value + " </td>")
        End If
        datos_formulario.Add("</tr>")
        datos_formulario.Add("<tr>")
        datos_formulario.Add("<td><b>Operador: </b> </td>")
        datos_formulario.Add("<td>" + ASPxTextBoxOperador.Value + "</td>")
        datos_formulario.Add("</tr>")
        datos_formulario.Add("<tr>")
        datos_formulario.Add("<td><b>Tipo de Aeronave: </b> </td>")
        datos_formulario.Add("<td>" + ASPxTextBoxAeronave.Value + "</td>")
        datos_formulario.Add("</tr>")
        datos_formulario.Add("<tr>")
        datos_formulario.Add("<td><b>Aeródromo Salida:</b> </td>")
        If ASPxComboBoxAeropuertosSalida.SelectedItem Is Nothing Then
            datos_formulario.Add("<td>" + "" + "</td>")
        Else
            datos_formulario.Add("<td>" + ASPxComboBoxAeropuertosSalida.SelectedItem.Text + "</td>")
        End If

        datos_formulario.Add("<td><b>Aeródromo Destino:</b> </td>")
        If ASPxComboBoxAeropuertosDestino.SelectedItem Is Nothing Then
            datos_formulario.Add("<td>" + "" + "</td>")
        Else
            datos_formulario.Add("<td>" + ASPxComboBoxAeropuertosDestino.SelectedItem.Text + "</td>")
        End If
        datos_formulario.Add("</tr>")

        datos_formulario.Add("<tr>")
        datos_formulario.Add("<td><b>Instalación:</b> </td>")
        If ASPxTextBoxInstalacion.Value Is Nothing Then
            datos_formulario.Add("<td>" + "" + "</td>")
        Else
            datos_formulario.Add("<td>" + ASPxTextBoxInstalacion.Value + "</td>")
        End If
        datos_formulario.Add("</tr>")
        datos_formulario.Add("<tr>")
        datos_formulario.Add("<td><b>Descripción:</b> </td>")
        If ASPxMemoDescripcion.Value Is Nothing Then
            datos_formulario.Add("<td>" + "" + "</td>")
        Else
            datos_formulario.Add("<td>" + ASPxMemoDescripcion.Value + "</td>")
        End If

        datos_formulario.Add("</tr>")
        datos_formulario.Add("</table>")




        Return datos_formulario
    End Function

    Private Sub Ingreso_Formulario()
        ambiente = "PRODUCCION"
        Dim numr As Integer
        Dim sql2 As String = "SELECT TOP 1 *  FROM [SSP_BI].[dbo].[Notificaciones_NSSP] ORDER BY id DESC "
        Dim cn As String = "Data Source=win-sqlserv-02;Initial Catalog=SSP_BI;User ID=adminsql;Password=sistema*-!;"
        Dim sql As String = "insert into Notificaciones_NSSP(form_id, version, fecha_creacion, nombre, email, "
        sql = sql + "telefono, fecha, hora, Instalacion, Tipo_Aeronave, "
        sql = sql + "Operador, Aerodromo_Salida, Aerodromo_Destino, Matricula, descripcion, ambiente) values"
        sql = sql + "(@form_id, @version, @fecha_creacion, @nombre, @email, "
        sql = sql + "@telefono,  @fecha, @hora, @Instalacion, @Tipo_Aeronave, "
        sql = sql + "@Operador, @Aerodromo_Salida, @Aerodromo_Destino, @Matricula, @descripcion, @ambiente)"


        Using conn As New SqlConnection(cn)
            Dim cmd As New SqlCommand(sql, conn)
            Dim cmd_id As New SqlCommand(sql2, conn)
            cmd.Parameters.AddWithValue("@form_id", 10)
            'cmd.Parameters.AddWithValue("@form_id", 1)
            cmd.Parameters.AddWithValue("@version", 2)
            cmd.Parameters.AddWithValue("@fecha_creacion", Now)
            cmd.Parameters.AddWithValue("@ambiente", ambiente)

            If ASPxTextBoxNombreApellido.Value Is Nothing Then
                cmd.Parameters.AddWithValue("@nombre", "")
            ElseIf ASPxTextBoxNombreApellido.Value.Equals("") Then
                cmd.Parameters.AddWithValue("@nombre", "")
            Else
                cmd.Parameters.AddWithValue("@nombre", ASPxTextBoxNombreApellido.Value)
            End If

            If ASPxTextBoxEmail.Value Is Nothing Then
                cmd.Parameters.AddWithValue("@email", "")
            ElseIf ASPxTextBoxEmail.Value.Equals("") Then
                cmd.Parameters.AddWithValue("@email", "")
            Else
                cmd.Parameters.AddWithValue("@email", ASPxTextBoxEmail.Value)
            End If

            If ASPxTextBoxTelefono.Value Is Nothing Then
                cmd.Parameters.AddWithValue("@telefono", "")
            ElseIf ASPxTextBoxTelefono.Value.Equals("") Then
                cmd.Parameters.AddWithValue("@telefono", "")
            Else
                cmd.Parameters.AddWithValue("@telefono", ASPxTextBoxTelefono.Value)

            End If
            
            If ASPxDateEditFecha.Value Is Nothing Then
                cmd.Parameters.AddWithValue("@fecha", Now)
            Else
                cmd.Parameters.AddWithValue("@fecha", ASPxDateEditFecha.Value)
            End If
            If ASPxTimeEditHora.Value Is Nothing Then
                cmd.Parameters.AddWithValue("@hora", "")
            ElseIf ASPxTimeEditHora.Value.Equals("") Then
                cmd.Parameters.AddWithValue("@hora", "")
            Else
                cmd.Parameters.AddWithValue("@hora", ASPxTimeEditHora.Value.ToString().Substring(11))

            End If

            If ASPxTextBoxInstalacion.Value Is Nothing Then
                cmd.Parameters.AddWithValue("@Instalacion", "")
            Else
                cmd.Parameters.AddWithValue("@Instalacion", ASPxTextBoxInstalacion.Value)
            End If
           

            If ASPxTextBoxIdentificacion.Value Is Nothing Then
                cmd.Parameters.AddWithValue("@Matricula", "")
            Else
                cmd.Parameters.AddWithValue("@Matricula", ASPxTextBoxIdentificacion.Value)
            End If

            If ASPxTextBoxOperador.Value Is Nothing Then
                cmd.Parameters.AddWithValue("@Operador", "")
            Else
                cmd.Parameters.AddWithValue("@Operador", ASPxTextBoxOperador.Value)
            End If
            If ASPxTextBoxAeronave.Value Is Nothing Then
                cmd.Parameters.AddWithValue("@Tipo_Aeronave", "")
            Else
                cmd.Parameters.AddWithValue("@Tipo_Aeronave", ASPxTextBoxAeronave.Value)
            End If
            If ASPxComboBoxAeropuertosSalida.SelectedItem Is Nothing Then
                cmd.Parameters.AddWithValue("@Aerodromo_Salida", "")
            ElseIf ASPxComboBoxAeropuertosSalida.SelectedItem.Value.Equals("") Then
                cmd.Parameters.AddWithValue("@Aerodromo_Salida", "")
            Else
                cmd.Parameters.AddWithValue("@Aerodromo_Salida", ASPxComboBoxAeropuertosSalida.SelectedItem.Value)
            End If
            If ASPxComboBoxAeropuertosDestino.SelectedItem Is Nothing Then
                cmd.Parameters.AddWithValue("@Aerodromo_Destino", "")
            ElseIf ASPxComboBoxAeropuertosDestino.SelectedItem.Value.Equals("") Then
                cmd.Parameters.AddWithValue("@Aerodromo_Destino", "")
            Else
                cmd.Parameters.AddWithValue("@Aerodromo_Destino", ASPxComboBoxAeropuertosDestino.SelectedItem.Value)
            End If
            ' @Tipo_Modelo
           

            If ASPxMemoDescripcion.Value Is Nothing Then
                cmd.Parameters.AddWithValue("@descripcion", "")
            Else
                cmd.Parameters.AddWithValue("@descripcion", ASPxMemoDescripcion.Value)
            End If

            If ambiente.Equals("PRUEBAS") Then
                id_formulario = 0
            Else
                Try
                    conn.Open()
                    numr = Convert.ToInt32(cmd.ExecuteScalar())
                    id_formulario = Convert.ToInt32(cmd_id.ExecuteScalar())
                    conn.Close()

                Catch ex As Exception
                    Console.WriteLine(ex.Message)
                    ScriptManager.RegisterStartupScript(Page, Page.GetType, "alertjs", "alert(' " & ex.Message & "');", True)
                End Try

            End If


        End Using

    End Sub

    Protected Sub ASPxButtonRegresar_Click(sender As Object, e As EventArgs) Handles ASPxButtonRegresar.Click
        Response.Redirect("~/default.aspx")

    End Sub

    Protected Sub ASPxPopupControl2_Unload(sender As Object, e As EventArgs) ' Handles ASPxPopupControl2.Unload
        ' RegisterUpdatePanel(DirectCast(sender, UpdatePanel))
    End Sub
    Protected Sub RegisterUpdatePanel(ByVal panel As UpdatePanel)
        Dim sType = GetType(ScriptManager)
        Dim mInfo = sType.GetMethod("System.Web.UI.IScriptManagerInternal.RegisterUpdatePanel", BindingFlags.NonPublic Or BindingFlags.Instance)
        If mInfo IsNot Nothing Then
            mInfo.Invoke(ScriptManager.GetCurrent(Page), New Object() {panel})
        End If
    End Sub

    Protected Sub UpdatePanel2_Unload(sender As Object, e As EventArgs) ' Handles UpdatePanel2.Unload
        '  RegisterUpdatePanel(DirectCast(sender, UpdatePanel))
    End Sub

    Protected Sub ScriptManager1_Unload(sender As Object, e As EventArgs) 'Handles ScriptManager1.Unload

    End Sub

    'Protected Sub ASPxButton2_Click(sender As Object, e As EventArgs) Handles ASPxButton2.Click

    'End Sub

    Protected Sub ASPxUploadControl1_FileUploadComplete(sender As Object, e As DevExpress.Web.FileUploadCompleteEventArgs) Handles ASPxUploadControl1.FileUploadComplete
        nombre_archivo = e.UploadedFile.FileName
        archivo = e.UploadedFile.FileBytes
    End Sub
End Class