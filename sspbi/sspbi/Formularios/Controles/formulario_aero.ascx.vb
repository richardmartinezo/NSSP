Imports System.Data.SqlClient
Imports DevExpress.Web.ASPxEditors


Public Class formulario_aero
    Inherits System.Web.UI.UserControl
    Private correosEnvio As New CorreosEnvío
    Private guardarArchivosbd As New Guardar_Archivos_BD
    Private id_formulario As New Int32
    Private ambiente As String
    Private nombre_archivo As String = ""
    Private archivo As Byte()

    Private repeticiones As Integer
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub ASPxDateEditFecha_DateChanged(sender As Object, e As EventArgs) Handles ASPxDateEditFecha.DateChanged

    End Sub

    Protected Sub ASPxButtonEnviar_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub Enviar_Formulario_Correo()
        ' correosEnvio.Enviar_Formulario_Correo_Lista(Llenar_Correo_Formulario(), "Formulario de Aeronaves", "AERO", ambiente)
        Try
            correosEnvio.Enviar_Formulario_Correo_Lista_Archivo(Llenar_Correo_Formulario(),
                                                           "Formulario de Aeronaves",
                                                           "AERO",
                                                           ambiente,
                                                           nombre_archivo,
                                                           archivo)
        Catch ex As Exception
            correosEnvio.Enviar_Formulario_Correo_Lista(Llenar_Correo_Formulario(),
                                                           "Formulario de Aeronaves",
                                                           "AERO",
                                                           ambiente)
        End Try
        Try
            correosEnvio.Enviar_Confirmacion_Correo("Formulario de Aeronaves", ASPxTextBoxEmail.Value)
        Catch ex As Exception

        End Try
        
    End Sub
   

    Private Function Llenar_Correo_Formulario() As ArrayList
        Dim datos_formulario As New ArrayList
        datos_formulario.Add("Formulario AERO " + "<br>")
        datos_formulario.Add("<br>")
        datos_formulario.Add("ID:" + id_formulario.ToString + "<br>")
        datos_formulario.Add("<br>")
        datos_formulario.Add("Nombre: " + ASPxTextBoxNombreApellido.Value + " " + "<br>")
        datos_formulario.Add("<br>")
        datos_formulario.Add("Email: " + ASPxTextBoxEmail.Value + " " + "<br>")
        datos_formulario.Add("<br>")
        datos_formulario.Add("Teléfono: " + ASPxTextBoxTelefono.Value + " " + "<br>")
        datos_formulario.Add("<br>")
        datos_formulario.Add("Fabricante: " + ASPxTextBoxFabricante.Value + " " + "<br>")
        datos_formulario.Add("<br>")
        datos_formulario.Add("Modelo: " + ASPxTextBoxModeloAeronave.Value + " " + "<br>")
        datos_formulario.Add("<br>")
        datos_formulario.Add("No. Serie: " + ASPxTextBoxNumeroSerieAeronave.Value + " " + "<br>")
        datos_formulario.Add("<br>")
        datos_formulario.Add("Fabricante: " + ASPxTextBoxFabricanteMotor.Value + " " + "<br>")
        datos_formulario.Add("<br>")
        datos_formulario.Add("Modelo: " + ASPxTextBoxModeloMotor.Value + " " + "<br>")
        datos_formulario.Add("<br>")
        datos_formulario.Add("No. Serie: " + ASPxTextBoxNumeroSerieMotor.Value + " " + "<br>")
        datos_formulario.Add("<br>")
        datos_formulario.Add("Fabricante: " + ASPxTextBoxFabricanteHelice.Value + " " + "<br>")
        datos_formulario.Add("<br>")
        datos_formulario.Add("Modelo: " + ASPxTextBoxNumeroSerieMotor.Value + " " + "<br>")
        datos_formulario.Add("<br>")
        datos_formulario.Add("No. Serie: " + ASPxTextBoxNumeroSerieHelice.Value + " " + "<br>")
        datos_formulario.Add("<br>")
        If ASPxDateEditFecha.Value Is Nothing Then
            datos_formulario.Add("Fecha: " + "<br>")
            datos_formulario.Add("<br>")
        Else
            datos_formulario.Add("Fecha: " + ASPxDateEditFecha.Value + " " + "<br>")
            datos_formulario.Add("<br>")
        End If
        'agregando hora
        If ASPxTimeEditHora.Value Is Nothing Then
            datos_formulario.Add("Hora: " + " " + "<br>")
            datos_formulario.Add("<br>")
        Else
            datos_formulario.Add("Hora: " + ASPxTimeEditHora.Value.ToString().Substring(11) + " " + "<br>")
            datos_formulario.Add("<br>")
        End If
        
        If ASPxRadioButtonListFasesFuncionamiento.SelectedItem Is Nothing Then
            datos_formulario.Add("Fases Funcionamiento: " + "<br>")
            datos_formulario.Add("<br>")
        Else
            datos_formulario.Add("Fases Funcionamiento: " + ASPxRadioButtonListFasesFuncionamiento.SelectedItem.Value + " " + "<br>")
            datos_formulario.Add("<br>")

        End If

        'If ASPxRadioButtonListNacionalInternacional.SelectedItem Is Nothing Then
        '    datos_formulario.Add("Lugar: " + " " + "<br>")
        '    datos_formulario.Add("<br>")
        'Else
        '    datos_formulario.Add("Lugar: " + ASPxRadioButtonListNacionalInternacional.SelectedItem.Value + " " + "<br>")
        '    datos_formulario.Add("<br>")
        'End If
        datos_formulario.Add("Texto: <br>" + "")
        datos_formulario.Add(ASPxMemoTexto.Value + " " + "<br>")
        datos_formulario.Add("<br>")
        datos_formulario.Add("Nombre de la Parte: " + ASPxTextBoxNombreParte.Value + " " + "<br>")
        datos_formulario.Add("<br>")
        datos_formulario.Add("No. Parte del Fabricante: " + ASPxTextBoxNumeroParteFabricante.Value + " " + "<br>")
        datos_formulario.Add("<br>")
        datos_formulario.Add("Condición: " + ASPxTextBoxCondicionParte.Value + " " + "<br>")
        datos_formulario.Add("<br>")
        datos_formulario.Add("Componente / Sistema en el que está instalada la parte: " + ASPxTextBoxComponenteSistema.Value + " " + "<br>")
        datos_formulario.Add("<br>")
        datos_formulario.Add("Tiempo Total: " + ASPxTextBoxTiempoTotal.Value + " " + "<br>")
        datos_formulario.Add("<br>")
        datos_formulario.Add("Tiempo OVH: " + ASPxTextBoxTiempoOVH.Value + " " + "<br>")
        datos_formulario.Add("<br>")
        datos_formulario.Add("Nombre Componente / sistema: " + ASPxTextBoxNombreComponente.Value + " " + "<br>")
        datos_formulario.Add("<br>")
        datos_formulario.Add("Fabricante: " + ASPxTextBoxFabricante.Value + " " + "<br>")
        datos_formulario.Add("<br>")
        datos_formulario.Add("No. Parte / modelo del fabricante: " + ASPxTextBoxModeloFabricante.Value + " " + "<br>")
        datos_formulario.Add("<br>")
        datos_formulario.Add("No. Serie: " + ASPxTextBoxNumSerie.Value + " " + "<br>")
        datos_formulario.Add("<br>")

        If ASPxRadioButtonListEnviadoPor.SelectedItem Is Nothing Then
            datos_formulario.Add("Enviado por: (seleccione uno) " + " " + "<br>")
            datos_formulario.Add("<br>")
        Else
            datos_formulario.Add("Enviado por: (seleccione uno) " + ASPxRadioButtonListEnviadoPor.SelectedItem.Value + " " + "<br>")
            datos_formulario.Add("<br>")
        End If
        datos_formulario.Add("Descripción: " + ASPxMemoTexto.Value + " " + "<br>")
        datos_formulario.Add("<br>")
        'datos_formulario.Add("Comentarios Adicionales " + ASPxMemoComentariosPersonales.Value + " " + "<br>")
        datos_formulario.Add("<br>")

        Return datos_formulario
    End Function

    Private Sub Ingreso_Formulario()

        ambiente = "PRODUCCION"
        Dim numr As Integer
        Dim id_reporte As String = "SELECT TOP 1 *  FROM [SSP_BI].[dbo].[Reportes_SSP_Master_test] ORDER BY id DESC "
        Dim cn As String = "Data Source=win-sqlserv-02;Initial Catalog=SSP_BI;User ID=adminsql;Password=sistema*-!;"
        Dim sql As String = "insert into Reportes_SSP_Master_Test(form_id, version, fecha_creacion, nombre, email, "
        sql = sql + "telefono,  fecha, hora,"
        sql = sql + "fabricante_aeronave, modelo_aeronave, num_serie_aeronave, fabricante_motor, "
        sql = sql + "modelo_motor, num_serie_motor, fabricante_helice, modelo_helice, num_serie_helice, fases_funcionamiento,  nombre_parte, num_parte, "
        sql = sql + "condicion_parte, ubicacion_parte, componente_instalado_parte, tiempo_total, tiempo_OVH, nombre_componente_sistema, "
        sql = sql + "fabricante_parte, num_parte_mod_fabricante, num_serie, enviado_por, descripcion) values"
        sql = sql + "(@form_id, @version, @fecha_creacion, @nombre, @email, "
        sql = sql + "@telefono,  @fecha, @hora,"
        sql = sql + "@fabricante_aeronave, @modelo_aeronave, @num_serie_aeronave, @fabricante_motor, "
        sql = sql + "@modelo_motor, @num_serie_motor, @fabricante_helice, @modelo_helice, @num_serie_helice, @fases_funcionamiento,  @nombre_parte, @num_parte, "
        sql = sql + "@condicion_parte, @ubicacion_parte, @componente_instalado_parte, @tiempo_total, @tiempo_OVH, @nombre_componente_sistema, "
        sql = sql + "@fabricante_parte, @num_parte_mod_fabricante, @num_serie, @enviado_por,  @descripcion)"


        Using conn As New SqlConnection(cn)
            Dim cmd As New SqlCommand(sql, conn)
            Dim cmd_id As New SqlCommand(id_reporte, conn)
            cmd.Parameters.AddWithValue("@form_id", 8)
            cmd.Parameters.AddWithValue("@version", 2)
            cmd.Parameters.AddWithValue("@fecha_creacion", Now)

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
            'agregando hora
            If ASPxTimeEditHora.Value Is Nothing Then
                cmd.Parameters.AddWithValue("@hora", "")
            ElseIf ASPxTimeEditHora.Value.Equals("") Then
                cmd.Parameters.AddWithValue("@hora", "")
            Else
                cmd.Parameters.AddWithValue("@hora", ASPxTimeEditHora.Value.ToString().Substring(11))

            End If
            If ASPxTextBoxFabricanteAeronave.Value Is Nothing Then
                cmd.Parameters.AddWithValue("@fabricante_aeronave", "")
            ElseIf ASPxTextBoxFabricanteAeronave.Value.Equals("") Then
                cmd.Parameters.AddWithValue("@fabricante_aeronave", "")
            Else
                cmd.Parameters.AddWithValue("@fabricante_aeronave", ASPxTextBoxFabricanteAeronave.Value)

            End If

            If ASPxTextBoxModeloAeronave.Value Is Nothing Then
                cmd.Parameters.AddWithValue("@modelo_aeronave", "")
            ElseIf ASPxTextBoxModeloAeronave.Value.Equals("") Then
                cmd.Parameters.AddWithValue("@modelo_aeronave", "")
            Else
                cmd.Parameters.AddWithValue("@modelo_aeronave", ASPxTextBoxModeloAeronave.Value)

            End If

            If ASPxTextBoxNumeroSerieAeronave.Value Is Nothing Then
                cmd.Parameters.AddWithValue("@num_serie_aeronave", "")
            ElseIf ASPxTextBoxNumeroSerieAeronave.Value.Equals("") Then
                cmd.Parameters.AddWithValue("@num_serie_aeronave", "")
            Else
                cmd.Parameters.AddWithValue("@num_serie_aeronave", ASPxTextBoxNumeroSerieAeronave.Value)

            End If

            If ASPxTextBoxFabricanteMotor.Value Is Nothing Then
                cmd.Parameters.AddWithValue("@fabricante_motor", "")
            ElseIf ASPxTextBoxFabricanteMotor.Value.Equals("") Then
                cmd.Parameters.AddWithValue("@fabricante_motor", "")
            Else
                cmd.Parameters.AddWithValue("@fabricante_motor", ASPxTextBoxFabricanteMotor.Value)

            End If

            If ASPxTextBoxModeloMotor.Value Is Nothing Then
                cmd.Parameters.AddWithValue("@modelo_motor", "")
            ElseIf ASPxTextBoxModeloMotor.Value.Equals("") Then
                cmd.Parameters.AddWithValue("@modelo_motor", "")
            Else
                cmd.Parameters.AddWithValue("@modelo_motor", ASPxTextBoxModeloMotor.Value)

            End If

            If ASPxTextBoxNumeroSerieMotor.Value Is Nothing Then
                cmd.Parameters.AddWithValue("@num_serie_motor", "")
            ElseIf ASPxTextBoxNumeroSerieMotor.Value.Equals("") Then
                cmd.Parameters.AddWithValue("@num_serie_motor", "")
            Else
                cmd.Parameters.AddWithValue("@num_serie_motor", ASPxTextBoxNumeroSerieMotor.Value)

            End If

            If ASPxTextBoxFabricanteHelice.Value Is Nothing Then
                cmd.Parameters.AddWithValue("@fabricante_helice", "")
            ElseIf ASPxTextBoxFabricanteHelice.Value.Equals("") Then
                cmd.Parameters.AddWithValue("@fabricante_helice", "")
            Else
                cmd.Parameters.AddWithValue("@fabricante_helice", ASPxTextBoxFabricanteHelice.Value)

            End If

            If ASPxTextBoxModeloHelice.Value Is Nothing Then
                cmd.Parameters.AddWithValue("@modelo_helice", "")
            ElseIf ASPxTextBoxModeloHelice.Value.Equals("") Then
                cmd.Parameters.AddWithValue("@modelo_helice", "")
            Else
                cmd.Parameters.AddWithValue("@modelo_helice", ASPxTextBoxModeloHelice.Value)

            End If

            If ASPxTextBoxNumeroSerieHelice.Value Is Nothing Then
                cmd.Parameters.AddWithValue("@num_serie_helice", "")
            ElseIf ASPxTextBoxNumeroSerieHelice.Value.Equals("") Then
                cmd.Parameters.AddWithValue("@num_serie_helice", "")
            Else
                cmd.Parameters.AddWithValue("@num_serie_helice", ASPxTextBoxNumeroSerieHelice.Value)

            End If

            If ASPxRadioButtonListFasesFuncionamiento.SelectedItem Is Nothing Then
                cmd.Parameters.AddWithValue("@fases_funcionamiento", "")
            ElseIf ASPxRadioButtonListFasesFuncionamiento.SelectedItem.Value.Equals("") Then
                cmd.Parameters.AddWithValue("@fases_funcionamiento", "")
            Else
                cmd.Parameters.AddWithValue("@fases_funcionamiento", ASPxRadioButtonListFasesFuncionamiento.SelectedItem.Value)

            End If

            If ASPxTextBoxNombreParte.Value Is Nothing Then
                cmd.Parameters.AddWithValue("@nombre_parte", "")
            ElseIf ASPxTextBoxNombreParte.Value.Equals("") Then
                cmd.Parameters.AddWithValue("@nombre_parte", "")
            Else
                cmd.Parameters.AddWithValue("@nombre_parte", ASPxTextBoxNombreParte.Value)

            End If

            If ASPxTextBoxNumeroParteFabricante.Value Is Nothing Then
                cmd.Parameters.AddWithValue("@num_parte", "")
            ElseIf ASPxTextBoxNumeroParteFabricante.Value.Equals("") Then
                cmd.Parameters.AddWithValue("@num_parte", "")
            Else
                cmd.Parameters.AddWithValue("@num_parte", ASPxTextBoxNumeroParteFabricante.Value)

            End If

            If ASPxTextBoxCondicionParte.Value Is Nothing Then
                cmd.Parameters.AddWithValue("@condicion_parte", "")
            ElseIf ASPxTextBoxCondicionParte.Value.Equals("") Then
                cmd.Parameters.AddWithValue("@condicion_parte", "")
            Else
                cmd.Parameters.AddWithValue("@condicion_parte", ASPxTextBoxCondicionParte.Value)

            End If

            If ASPxTextBoxUbicacionParte.Value Is Nothing Then
                cmd.Parameters.AddWithValue("@ubicacion_parte", "")
            ElseIf ASPxTextBoxUbicacionParte.Value.Equals("") Then
                cmd.Parameters.AddWithValue("@ubicacion_parte", "")
            Else
                cmd.Parameters.AddWithValue("@ubicacion_parte", ASPxTextBoxUbicacionParte.Value)

            End If

            If ASPxTextBoxComponenteSistema.Value Is Nothing Then
                cmd.Parameters.AddWithValue("@componente_instalado_parte", "")
            ElseIf ASPxTextBoxComponenteSistema.Value.Equals("") Then
                cmd.Parameters.AddWithValue("@componente_instalado_parte", "")
            Else
                cmd.Parameters.AddWithValue("@componente_instalado_parte", ASPxTextBoxComponenteSistema.Value)

            End If

            If ASPxTextBoxTiempoTotal.Value Is Nothing Then
                cmd.Parameters.AddWithValue("@tiempo_total", "")
            ElseIf ASPxTextBoxTiempoTotal.Value.Equals("") Then
                cmd.Parameters.AddWithValue("@tiempo_total", "")
            Else
                cmd.Parameters.AddWithValue("@tiempo_total", ASPxTextBoxTiempoTotal.Value)

            End If

            If ASPxTextBoxTiempoOVH.Value Is Nothing Then
                cmd.Parameters.AddWithValue("@tiempo_OVH", "")
            ElseIf ASPxTextBoxTiempoOVH.Value.Equals("") Then
                cmd.Parameters.AddWithValue("@tiempo_OVH", "")
            Else
                cmd.Parameters.AddWithValue("@tiempo_OVH", ASPxTextBoxTiempoOVH.Value)

            End If

            If ASPxTextBoxNombreComponente.Value Is Nothing Then
                cmd.Parameters.AddWithValue("@nombre_componente_sistema", "")
            ElseIf ASPxTextBoxNombreComponente.Value.Equals("") Then
                cmd.Parameters.AddWithValue("@nombre_componente_sistema", "")
            Else
                cmd.Parameters.AddWithValue("@nombre_componente_sistema", ASPxTextBoxNombreComponente.Value)

            End If

            If ASPxTextBoxFabricante.Value Is Nothing Then
                cmd.Parameters.AddWithValue("@fabricante_parte", "")
            ElseIf ASPxTextBoxFabricante.Value.Equals("") Then
                cmd.Parameters.AddWithValue("@fabricante_parte", "")
            Else
                cmd.Parameters.AddWithValue("@fabricante_parte", ASPxTextBoxFabricante.Value)

            End If

            If ASPxTextBoxNumSerie.Value Is Nothing Then
                cmd.Parameters.AddWithValue("@num_serie", "")
            ElseIf ASPxTextBoxNumSerie.Value.Equals("") Then
                cmd.Parameters.AddWithValue("@num_serie", "")
            Else
                cmd.Parameters.AddWithValue("@num_serie", ASPxTextBoxNumSerie.Value)

            End If

            If ASPxRadioButtonListEnviadoPor.SelectedItem Is Nothing Then
                cmd.Parameters.AddWithValue("@enviado_por", "")
            ElseIf ASPxRadioButtonListEnviadoPor.SelectedItem.Value.Equals("") Then
                cmd.Parameters.AddWithValue("@enviado_por", "")
            Else
                cmd.Parameters.AddWithValue("@enviado_por", ASPxRadioButtonListEnviadoPor.SelectedItem.Value)

            End If


            'If ASPxRadioButtonListNacionalInternacional.SelectedItem Is Nothing Then
            '    cmd.Parameters.AddWithValue("@lugar_nac_int", "")
            'ElseIf ASPxRadioButtonListNacionalInternacional.SelectedItem.Value.Equals("") Then
            '    cmd.Parameters.AddWithValue("@lugar_nac_int", "")
            'Else
            '    cmd.Parameters.AddWithValue("@lugar_nac_int", ASPxRadioButtonListNacionalInternacional.SelectedItem.Value)

            'End If

            If ASPxTextBoxModeloFabricante.Value Is Nothing Then
                cmd.Parameters.AddWithValue("@num_parte_mod_fabricante", "")
            ElseIf ASPxTextBoxModeloFabricante.Value.Equals("") Then
                cmd.Parameters.AddWithValue("@num_parte_mod_fabricante", "")
            Else
                cmd.Parameters.AddWithValue("@num_parte_mod_fabricante", ASPxTextBoxModeloFabricante.Value)

            End If
         
            'texto
            If ASPxMemoTexto.Value Is Nothing Then

                cmd.Parameters.AddWithValue("@descripcion", "")
            ElseIf ASPxMemoTexto.Value.Equals("@descripcion") Then
                cmd.Parameters.AddWithValue("@descripcion", "")

            Else
                cmd.Parameters.AddWithValue("@descripcion", ASPxMemoTexto.Value)
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

    Protected Sub ASPxButton2_Click(sender As Object, e As EventArgs) Handles ASPxButton2.Click
        Response.Redirect("../default.aspx")
    End Sub

   
   
    Protected Sub ASPxUploadControlArchivos_FileUploadComplete(sender As Object, e As DevExpress.Web.FileUploadCompleteEventArgs) Handles ASPxUploadControlArchivos.FileUploadComplete
      
        nombre_archivo = e.UploadedFile.FileName
        archivo = e.UploadedFile.FileBytes
    End Sub

    Protected Sub ASPxButtonEnviarFormulario_Click(sender As Object, e As EventArgs) Handles ASPxButtonEnviarFormulario.Click


        Ingreso_Formulario()
        Enviar_Formulario_Correo()
        ASPxPopupControl2.ShowOnPageLoad = True
        If id_formulario = Nothing Then
        Else
            guardarArchivosbd.insertar_archivo(id_formulario, nombre_archivo, archivo)
        End If

    End Sub
End Class