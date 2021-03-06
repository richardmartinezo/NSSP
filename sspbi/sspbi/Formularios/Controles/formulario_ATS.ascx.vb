Imports System.Data.SqlClient
Imports System.Reflection

Public Class formulario_ATS
    Inherits System.Web.UI.UserControl
    Private correosEnvio As New CorreosEnvío
    Private guardarArchivosbd As New Guardar_Archivos_BD
    Private id_formulario As Int32
    Private repeticiones As Integer
    Private ambiente As String
    Private nombre_archivo As String = ""
    Private archivo As Byte()

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        repeticiones = 0
    End Sub

    Protected Sub ASPxButtonEnviar_Click(sender As Object, e As EventArgs) Handles ASPxButtonEnviar.Click

        Ingreso_Formulario()
        Enviar_Formulario_Correo()
        ASPxPopupControl2.ShowOnPageLoad = True

        If id_formulario = 0 Then
        ElseIf id_formulario.Equals(Nothing) Then
        Else
            guardarArchivosbd.insertar_archivo(id_formulario, nombre_archivo, archivo)
        End If




    End Sub

    Private Sub Enviar_Formulario_Correo()
        correosEnvio.Enviar_Formulario_Correo_Lista(Llenar_Correo_Formulario(), "Formulario ATS", "ATS", ambiente)
        Try
            correosEnvio.Enviar_Formulario_Correo_Lista_Archivo(Llenar_Correo_Formulario(),
                                                        "Formulario ATS",
                                                            "ATS",
                                                            ambiente,
                                                           nombre_archivo,
                                                           archivo)
        Catch ex As Exception
            correosEnvio.Enviar_Formulario_Correo_Lista(Llenar_Correo_Formulario(),
                                                           "Formulario ATS",
                                                           "ATS",
                                                           ambiente)
        End Try
        Try
            correosEnvio.Enviar_Confirmacion_Correo("Formulario ATS", ASPxTextBoxEmail.Value)
        Catch ex As Exception

        End Try
      
    End Sub

    Private Function Llenar_Correo_Formulario() As ArrayList
        Dim datos_formulario As New ArrayList
        datos_formulario.Add("Formulario ATS" + "<br>")
        datos_formulario.Add("<br>")
        datos_formulario.Add("ID: " + id_formulario.ToString + " " + "<br>")
        datos_formulario.Add("<br>")
        datos_formulario.Add("Nombre: " + ASPxTextBoxNombreApellido.Value + " " + "<br>")
        datos_formulario.Add("<br>")
        datos_formulario.Add("Email: " + ASPxTextBoxEmail.Value + " " + "<br>")
        datos_formulario.Add("<br>")
        datos_formulario.Add("Teléfono: " + ASPxTextBoxTelefono.Value + " " + "<br>")
        datos_formulario.Add("<br>")

        If ASPxComboBoxAeropuertos.SelectedItem Is Nothing Then
            datos_formulario.Add("Ubicación: " + " " + "<br>")
            datos_formulario.Add("<br>")
        Else
            datos_formulario.Add("Ubicación: " + ASPxComboBoxAeropuertos.SelectedItem.Text + " " + "<br>")
            datos_formulario.Add("<br>")
        End If
        If ASPxDateEditFecha.Value Is Nothing Then
            datos_formulario.Add("Fecha: " + " " + "<br>")
            datos_formulario.Add("<br>")
        Else
            datos_formulario.Add("Fecha: " + ASPxDateEditFecha.Value.ToString() + " " + "<br>")
            datos_formulario.Add("<br>")
        End If
        If ASPxTimeEditHora.Value Is Nothing Then
            datos_formulario.Add("Hora: " + " " + "<br>")
            datos_formulario.Add("<br>")
        Else
            datos_formulario.Add("Hora: " + ASPxTimeEditHora.Value.ToString().Substring(11) + " " + "<br>")
            datos_formulario.Add("<br>")
        End If


        If ASPxComboBoxRadioAyuda.SelectedItem Is Nothing Then
            datos_formulario.Add("Radioayuda: " + " " + "<br>")
            datos_formulario.Add("<br>")
        Else
            datos_formulario.Add("Radioayuda: " + ASPxComboBoxRadioAyuda.SelectedItem.Value + " " + "<br>")
            datos_formulario.Add("<br>")
        End If

        If ASPxComboBoxWaypoint.SelectedItem Is Nothing Then
            datos_formulario.Add("Waypoint: " + " " + "<br>")
            datos_formulario.Add("<br>")
        Else
            datos_formulario.Add("Waypoint: " + ASPxComboBoxWaypoint.SelectedItem.Value + " " + "<br>")
            datos_formulario.Add("<br>")
        End If

        If ASPxComboBoxRutaAerovia.SelectedItem Is Nothing Then
            datos_formulario.Add("Ruta / Aerovía: " + " " + "<br>")
            datos_formulario.Add("<br>")
        Else
            datos_formulario.Add("Ruta / Aerovía: " + ASPxComboBoxRutaAerovia.SelectedItem.Value + " " + "<br>")
            datos_formulario.Add("<br>")
        End If


        If ASPxTextBoxHorizontalNM.Value Is Nothing Then
            datos_formulario.Add("Horizontal NM: " + " " + "<br>")
            datos_formulario.Add("<br>")
        Else
            datos_formulario.Add("Horizontal NM: " + ASPxTextBoxHorizontalNM.Value + " " + "<br>")
            datos_formulario.Add("<br>")
        End If

        If ASPxTextBoxVerticalFT.Value Is Nothing Then
            datos_formulario.Add("Vertical FT: " + " " + "<br>")
            datos_formulario.Add("<br>")
        Else
            datos_formulario.Add("Vertical FT: " + ASPxTextBoxVerticalFT.Value + " " + "<br>")
            datos_formulario.Add("<br>")
        End If

        If ASPxTextBoxVisibilidad.Value Is Nothing Then
            datos_formulario.Add("Visibilidad: " + " " + "<br>")
            datos_formulario.Add("<br>")
        Else
            datos_formulario.Add("Visibilidad: " + ASPxTextBoxVisibilidad.Value + " " + "<br>")
            datos_formulario.Add("<br>")
        End If

        If ASPxTextBoxRVR.Value Is Nothing Then
            datos_formulario.Add("RVR: " + " " + "<br>")
            datos_formulario.Add("<br>")
        Else
            datos_formulario.Add("RVR: " + ASPxTextBoxRVR.Value + " " + "<br>")
            datos_formulario.Add("<br>")
        End If

        If ASPxComboBoxDependenciaATS.SelectedItem Is Nothing Then
            datos_formulario.Add("Dependencia ATS: " + "" + " " + "<br>")
            datos_formulario.Add("<br>")
        Else
            datos_formulario.Add("Dependencia ATS: " + ASPxComboBoxDependenciaATS.SelectedItem.Value + " " + "<br>")
            datos_formulario.Add("<br>")
        End If

        If ASPxRadioButtonPosicionSuceso.SelectedItem Is Nothing Then
            datos_formulario.Add("Posicion Actividad Suceso: " + " " + "<br>")
            datos_formulario.Add("<br>")
        Else
            datos_formulario.Add("Posicion Actividad Suceso: " + ASPxRadioButtonPosicionSuceso.SelectedItem.Value + " " + "<br>")
            datos_formulario.Add("<br>")
        End If
       
        If ASPxTextBoxPosicionActividadDuranteSuceso.Value Is Nothing Then
            datos_formulario.Add("Posicion Actividad Suceso Otro: " + " " + "<br>")
            datos_formulario.Add("<br>")
        Else
            datos_formulario.Add("Posicion Actividad Suceso Otro: " + ASPxTextBoxPosicionActividadDuranteSuceso.Value + " " + "<br>")
            datos_formulario.Add("<br>")
        End If
       
        If ASPxComboBoxEspacioAereo.SelectedItem Is Nothing Then
            datos_formulario.Add("Espacion Aéreo: " + " " + "<br>")
            datos_formulario.Add("<br>")
        Else

            datos_formulario.Add("Espacion Aéreo: " + ASPxComboBoxEspacioAereo.SelectedItem.Value + " " + "<br>")
            datos_formulario.Add("<br>")
        End If

        
        If ASPxRadioButtonTipoIncidente.SelectedItem Is Nothing Then
            datos_formulario.Add("Tipo Incidente: " + " " + "<br>")
            datos_formulario.Add("<br>")
        Else
            datos_formulario.Add("Tipo Incidente: " + ASPxRadioButtonTipoIncidente.SelectedItem.Value + " " + "<br>")
            datos_formulario.Add("<br>")
        End If
        
        If ASPxTextBoxOtroIncidente.Value Is Nothing Then
            datos_formulario.Add("Tipo Incidente Otro: " + " " + "<br>")
            datos_formulario.Add("<br>")
        Else
            datos_formulario.Add("Tipo Incidente Otro: " + ASPxTextBoxOtroIncidente.Value + " " + "<br>")
            datos_formulario.Add("<br>")
        End If
       
        If ASPxTextBoxOperadorO1.Value Is Nothing Then
            datos_formulario.Add("Operador Aeronave 1: " + " " + "<br>")
            datos_formulario.Add("<br>")
        Else
            datos_formulario.Add("Operador Aeronave 1: " + ASPxTextBoxOperadorO1.Value + " " + "<br>")
            datos_formulario.Add("<br>")
        End If

        If ASPxTextBoxOperadorO2.Value Is Nothing Then
            datos_formulario.Add("Operador Aeronave 2: " + " " + "<br>")
            datos_formulario.Add("<br>")
        Else
            datos_formulario.Add("Operador Aeronave 2: " + ASPxTextBoxOperadorO2.Value + " " + "<br>")
            datos_formulario.Add("<br>")
        End If

        If ASPxTextBoxVuelo1.Value Is Nothing Then
            datos_formulario.Add("Numero de Vuelo Aeronave 1: " + " " + "<br>")
            datos_formulario.Add("<br>")
        Else
            datos_formulario.Add("Numero de Vuelo Aeronave 1: " + ASPxTextBoxVuelo1.Value + " " + "<br>")
            datos_formulario.Add("<br>")
        End If

        If ASPxTextBoxVuelo2.Value Is Nothing Then
            datos_formulario.Add("Numero de Vuelo Aeronave 2: " + " " + "<br>")
            datos_formulario.Add("<br>")
        Else
            datos_formulario.Add("Numero de Vuelo Aeronave 2: " + ASPxTextBoxVuelo2.Value + " " + "<br>")
            datos_formulario.Add("<br>")
        End If
      

        datos_formulario.Add("Descripción: " + "<br>")
        datos_formulario.Add("" + ASPxMemoDescripcionNarrativa.Value)
        datos_formulario.Add("<br>")

        Return datos_formulario
    End Function
    Private Sub Ingreso_Formulario()

        Dim numr As Integer
        ambiente = "PRODUCCION"
        Dim id_reporte As String = "SELECT TOP 1 * FROM Notificaciones_NSSP ORDER BY id DESC"
        Dim cn As String = "Data Source=win-sqlserv-02;Initial Catalog=SSP_BI;User ID=adminsql;Password=sistema*-!;"
        Dim sql As String = "insert into Notificaciones_NSSP(form_id, version, fecha_creacion, nombre, email, "
        sql = sql + "telefono, lugar_id, fecha, hora,  "
        sql = sql + "Radioayuda, Waypoint, Ruta_Aerovia, Vertical_FT, Horizontal_NM, Visibilidad, RVR, Dependencia_ATS, "
        sql = sql + "Espacio_Aereo, Tipo_Incidente, Tipo_Incidente_Otro, Posicion_actividad_suceso, Posicion_actividad_suceso_otro, descripcion) "
        'sql = sql + " descripcion)"
        sql = sql + "values(@form_id, @version, @fecha_creacion, @nombre, @email, @telefono, @lugar_id, @fecha, @hora, "
        sql = sql + "@Radioayuda, @Waypoint, @Ruta_Aerovia,  @Vertical_FT, @Horizontal_NM, @Visibilidad, "
        sql = sql + "@RVR, @Dependencia_ATS, @Espacio_Aereo, @Tipo_Incidente, @Tipo_Incidente_Otro, @Posicion_actividad_suceso, @Posicion_actividad_suceso_otro, @descripcion)"
        'sql = sql + " @descripcion)"


        Using conn As New SqlConnection(cn)
            Dim cmd As New SqlCommand(sql, conn)
            Dim cmd_id As New SqlCommand(id_reporte, conn)
            cmd.Parameters.AddWithValue("@form_id", 3)
            cmd.Parameters.AddWithValue("@fecha_creacion", Now)
            cmd.Parameters.AddWithValue("@version", 2)

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

            'validar el vacio
            If ASPxComboBoxAeropuertos.SelectedItem Is Nothing Then
                cmd.Parameters.AddWithValue("@lugar_id", "")
            ElseIf ASPxComboBoxAeropuertos.SelectedItem.Value.Equals("") Then
                cmd.Parameters.AddWithValue("@lugar_id", "")
            Else
                cmd.Parameters.AddWithValue("@lugar_id", ASPxComboBoxAeropuertos.SelectedItem.Value)
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
            '@Lic_ATC

            If ASPxTextBoxTelefono.Value Is Nothing Then
                cmd.Parameters.AddWithValue("@telefono", "")
            ElseIf ASPxTextBoxTelefono.Value.Equals("") Then
                cmd.Parameters.AddWithValue("@telefono", "")
            Else
                cmd.Parameters.AddWithValue("@telefono", ASPxTextBoxTelefono.Value)

            End If

            If ASPxComboBoxRadioAyuda.SelectedItem Is Nothing Then
                cmd.Parameters.AddWithValue("@Radioayuda", "")
            ElseIf ASPxComboBoxRadioAyuda.SelectedItem.Value.Equals("") Then
                cmd.Parameters.AddWithValue("@Radioayuda", "")
            Else
                cmd.Parameters.AddWithValue("@Radioayuda", ASPxComboBoxRadioAyuda.SelectedItem.Value)

            End If
            If ASPxComboBoxWaypoint.SelectedItem Is Nothing Then
                cmd.Parameters.AddWithValue("@Waypoint", "")
            ElseIf ASPxComboBoxWaypoint.SelectedItem.Value.Equals("") Then
                cmd.Parameters.AddWithValue("@Waypoint", "")
            Else
                cmd.Parameters.AddWithValue("@Waypoint", ASPxComboBoxWaypoint.SelectedItem.Value)

            End If
            If ASPxComboBoxRutaAerovia.SelectedItem Is Nothing Then
                cmd.Parameters.AddWithValue("@Ruta_Aerovia", "")
            ElseIf ASPxComboBoxRutaAerovia.SelectedItem.Equals("") Then
                cmd.Parameters.AddWithValue("@Ruta_Aerovia", "")
            Else
                cmd.Parameters.AddWithValue("@Ruta_Aerovia", ASPxComboBoxRutaAerovia.SelectedItem.Value)

            End If

            'If ASPxTextBoxOtroLugar.Value Is Nothing Then
            '    cmd.Parameters.AddWithValue("@Otro_Lugar", "")
            'ElseIf ASPxTextBoxOtroLugar.Value.Equals("") Then
            '    cmd.Parameters.AddWithValue("@Otro_Lugar", "")
            'Else
            '    cmd.Parameters.AddWithValue("@Otro_Lugar", ASPxTextBoxOtroLugar.Value)

            'End If

            If ASPxRadioButtonPosicionSuceso.SelectedItem Is Nothing Then
                cmd.Parameters.AddWithValue("@Posicion_actividad_suceso", "")
            ElseIf ASPxRadioButtonPosicionSuceso.SelectedItem.Equals("") Then
                cmd.Parameters.AddWithValue("@Posicion_actividad_suceso", "")
            Else
                cmd.Parameters.AddWithValue("@Posicion_actividad_suceso", ASPxRadioButtonPosicionSuceso.SelectedItem.Value)

            End If

            If ASPxTextBoxPosicionActividadDuranteSuceso.Value Is Nothing Then
                cmd.Parameters.AddWithValue("@Posicion_actividad_suceso_otro", "")
            ElseIf ASPxTextBoxPosicionActividadDuranteSuceso.Value.Equals("") Then
                cmd.Parameters.AddWithValue("@Posicion_actividad_suceso_otro", "")
            Else
                cmd.Parameters.AddWithValue("@Posicion_actividad_suceso_otro", ASPxTextBoxPosicionActividadDuranteSuceso.Value)

            End If


            If ASPxTextBoxVerticalFT.Value Is Nothing Then
                cmd.Parameters.AddWithValue("@Vertical_FT", "")
            ElseIf ASPxTextBoxVerticalFT.Value.Equals("") Then
                cmd.Parameters.AddWithValue("@Vertical_FT", "")
            Else
                cmd.Parameters.AddWithValue("@Vertical_FT", ASPxTextBoxVerticalFT.Value)

            End If

            If ASPxTextBoxHorizontalNM.Value Is Nothing Then
                cmd.Parameters.AddWithValue("@Horizontal_NM", "")
            ElseIf ASPxTextBoxHorizontalNM.Value.Equals("") Then
                cmd.Parameters.AddWithValue("@Horizontal_NM", "")
            Else
                cmd.Parameters.AddWithValue("@Horizontal_NM", ASPxTextBoxHorizontalNM.Value)

            End If


            If ASPxTextBoxVisibilidad.Value Is Nothing Then
                cmd.Parameters.AddWithValue("@Visibilidad", "")
            ElseIf ASPxTextBoxVisibilidad.Value.Equals("") Then
                cmd.Parameters.AddWithValue("@Visibilidad", "")
            Else
                cmd.Parameters.AddWithValue("@Visibilidad", ASPxTextBoxVisibilidad.Value)

            End If

            If ASPxTextBoxRVR.Value Is Nothing Then
                cmd.Parameters.AddWithValue("@RVR", "")
            ElseIf ASPxTextBoxRVR.Value.Equals("") Then
                cmd.Parameters.AddWithValue("@RVR", "")
            Else
                cmd.Parameters.AddWithValue("@RVR", ASPxTextBoxRVR.Value)

            End If


            If ASPxComboBoxDependenciaATS.SelectedItem Is Nothing Then
                cmd.Parameters.AddWithValue("@Dependencia_ATS", "")
            ElseIf ASPxComboBoxDependenciaATS.SelectedItem.Value.Equals("") Then
                cmd.Parameters.AddWithValue("@Dependencia_ATS", "")
            Else
                cmd.Parameters.AddWithValue("@Dependencia_ATS", ASPxComboBoxDependenciaATS.SelectedItem.Value)

            End If

            If ASPxComboBoxEspacioAereo.SelectedItem Is Nothing Then
                cmd.Parameters.AddWithValue("@Espacio_Aereo", "")
            ElseIf ASPxComboBoxEspacioAereo.SelectedItem.Value.Equals("") Then
                cmd.Parameters.AddWithValue("@Espacio_Aereo", "")
            Else
                cmd.Parameters.AddWithValue("@Espacio_Aereo", ASPxComboBoxEspacioAereo.SelectedItem.Value)

            End If

            If ASPxRadioButtonTipoIncidente.SelectedItem Is Nothing Then
                cmd.Parameters.AddWithValue("@Tipo_Incidente", "")
            ElseIf ASPxRadioButtonTipoIncidente.SelectedItem.Value.Equals("") Then
                cmd.Parameters.AddWithValue("@Tipo_Incidente", "")
            Else
                cmd.Parameters.AddWithValue("@Tipo_Incidente", ASPxRadioButtonTipoIncidente.SelectedItem.Value)

            End If

            If ASPxTextBoxOtroIncidente.Value Is Nothing Then
                cmd.Parameters.AddWithValue("@Tipo_Incidente_Otro", "")
            ElseIf ASPxTextBoxOtroIncidente.Value.Equals("") Then
                cmd.Parameters.AddWithValue("@Tipo_Incidente_Otro", "")
            Else
                cmd.Parameters.AddWithValue("@Tipo_Incidente_Otro", ASPxTextBoxOtroIncidente.Value)

            End If


            If ASPxMemoDescripcionNarrativa.Value Is Nothing Then
                cmd.Parameters.AddWithValue("@descripcion", "")
            ElseIf ASPxMemoDescripcionNarrativa.Value.Equals("") Then
                cmd.Parameters.AddWithValue("@descripcion", "")
            Else
                cmd.Parameters.AddWithValue("@descripcion", ASPxMemoDescripcionNarrativa.Value)
            End If

            Dim num_vuelo1, num_vuelo2, ops1, ops2, tip_aero1, tip_aero2, aerodromo_sal1, aerodromo_sal2, aerodromo_des1, aerodromo_des2, fas_vuel1, fas_vuel2, fas_vuel_otro1, fas_vuel_otro2 As String
            If ASPxTextBoxVuelo1.Value Is Nothing Then
                num_vuelo1 = ""
            Else
                num_vuelo1 = ASPxTextBoxVuelo1.Value
            End If
            If ASPxTextBoxVuelo2.Value Is Nothing Then
                num_vuelo2 = ""
            Else
                num_vuelo2 = ASPxTextBoxVuelo2.Value
            End If

            If ASPxTextBoxOperadorO1.Value Is Nothing Then
                ops1 = ""
            Else
                ops1 = ASPxTextBoxOperadorO1.Value
            End If

            If ASPxTextBoxOperadorO2.Value Is Nothing Then
                ops2 = ""
            Else
                ops2 = ASPxTextBoxOperadorO2.Value
            End If
            If ASPxTextBoxTipoAeronave1.Value Is Nothing Then
                tip_aero1 = ""
            Else
                tip_aero1 = ASPxTextBoxTipoAeronave1.Value
            End If
            If ASPxTextBoxTipoAeronave2.Value Is Nothing Then
                tip_aero2 = ""
            Else
                tip_aero2 = ASPxTextBoxTipoAeronave2.Value
            End If
            If ASPxComboBoxAeropuertos1Salida.SelectedItem Is Nothing Then
                aerodromo_sal1 = ""
            Else
                aerodromo_sal1 = ASPxComboBoxAeropuertos1Salida.SelectedItem.Value
            End If

            If ASPxComboBoxAeropuertos2Salida.SelectedItem Is Nothing Then
                aerodromo_sal2 = ""
            Else
                aerodromo_sal2 = ASPxComboBoxAeropuertos2Salida.SelectedItem.Value
            End If

            If ASPxComboBoxAeropuertos1Destino.SelectedItem Is Nothing Then
                aerodromo_des1 = ""
            Else
                aerodromo_des1 = ASPxComboBoxAeropuertos1Destino.SelectedItem.Value
            End If
            If ASPxComboBoxAeropuertos2Destino.SelectedItem Is Nothing Then
                aerodromo_des2 = ""
            Else
                aerodromo_des2 = ASPxComboBoxAeropuertos2Destino.SelectedItem.Value
            End If
            If ASPxRadioButtonFaseVuelo1.SelectedItem Is Nothing Then
                fas_vuel1 = ""
            Else
                fas_vuel1 = ASPxRadioButtonFaseVuelo1.SelectedItem.Value
            End If
            If ASPxRadioButtonFaseVuelo2.SelectedItem Is Nothing Then
                fas_vuel2 = ""
            Else
                fas_vuel2 = ASPxRadioButtonFaseVuelo2.SelectedItem.Value
            End If
            If ASPxTextBoxFaseVueloOtro1.Value Is Nothing Then
                fas_vuel_otro1 = ""
            Else
                fas_vuel_otro1 = ASPxTextBoxFaseVueloOtro1.Value
            End If
            If ASPxTextBoxFaseVueloOtro2.Value Is Nothing Then
                fas_vuel_otro2 = ""
            Else
                fas_vuel_otro2 = ASPxTextBoxFaseVueloOtro2.Value
            End If

            If ambiente.Equals("PRUEBAS") Then
                id_formulario = 0
            Else
                'aeronaves
               

                Try
                    conn.Open()
                    numr = Convert.ToInt32(cmd.ExecuteScalar())
                    id_formulario = Convert.ToInt32(cmd_id.ExecuteScalar())
                    Ingreso_Aeronave(num_vuelo1, ops1, tip_aero1, aerodromo_sal1, aerodromo_des1, fas_vuel1, fas_vuel_otro1)
                    Ingreso_Aeronave(num_vuelo2, ops2, tip_aero2, aerodromo_sal2, aerodromo_des2, fas_vuel2, fas_vuel_otro2)
                    conn.Close()

                Catch ex As Exception
                    Console.WriteLine(ex.Message)
                    ScriptManager.RegisterStartupScript(Page, Page.GetType, "alertjs", "alert(' " & ex.Message & "');", True)
                End Try

            End If
           
        End Using

    End Sub
    Private Sub Ingreso_Aeronave(numero_vuelo_matricula As String, Operador As String, Tipo_Aeronave As String, lugar_id_origen As String, lugar_id_destino As String, Fase_vuelo As String, Fase_vuelo_otro As String)


        Dim numr As Integer
        Dim id_reporte As String = "SELECT TOP 1 * FROM Notificaciones_NSSP ORDER BY id DESC"
        Dim cn As String = "Data Source=win-sqlserv-02;Initial Catalog=SSP_BI;User ID=adminsql;Password=sistema*-!;"
        Dim sql As String = "insert into aeronaves_notificaciones(id_formulario, Numero_vuelo_matricula, Operador, Tipo_Aeronave, "
        sql = sql + "lugar_id_origen, lugar_id_destino, Fase_vuelo, Fase_vuelo_otro) values(@id_formulario, @Numero_vuelo_matricula, @Operador, @Tipo_Aeronave, "
        sql = sql + "@lugar_id_origen, @lugar_id_destino, @Fase_vuelo, @Fase_vuelo_otro)"

        Using conn As New SqlConnection(cn)
            Dim cmd As New SqlCommand(sql, conn)
            Dim cmd_id As New SqlCommand(id_reporte, conn)

            cmd.Parameters.AddWithValue("@id_formulario", Me.id_formulario)
            If numero_vuelo_matricula Is Nothing Then
                cmd.Parameters.AddWithValue("@Numero_vuelo_matricula", "")
            Else
                cmd.Parameters.AddWithValue("@Numero_vuelo_matricula", numero_vuelo_matricula)
            End If
            If Operador Is Nothing Then
                cmd.Parameters.AddWithValue("@Operador", "")
            Else
                cmd.Parameters.AddWithValue("@Operador", Operador)
            End If

       

            If Tipo_Aeronave Is Nothing Then
                cmd.Parameters.AddWithValue("@Tipo_Aeronave", "")
            Else
                cmd.Parameters.AddWithValue("@Tipo_Aeronave", Tipo_Aeronave)
            End If

            If lugar_id_origen Is Nothing Then
                cmd.Parameters.AddWithValue("@lugar_id_origen", "")
            Else
                cmd.Parameters.AddWithValue("@lugar_id_origen", lugar_id_origen)
            End If

            If lugar_id_destino Is Nothing Then
                cmd.Parameters.AddWithValue("@lugar_id_destino", "")
            Else
                cmd.Parameters.AddWithValue("@lugar_id_destino", lugar_id_destino)
            End If

            If Fase_vuelo Is Nothing Then
                cmd.Parameters.AddWithValue("@Fase_vuelo", "")
            Else
                cmd.Parameters.AddWithValue("@Fase_vuelo", Fase_vuelo)
            End If

            If Fase_vuelo_otro Is Nothing Then
                cmd.Parameters.AddWithValue("@Fase_vuelo_otro", "")
            Else
                cmd.Parameters.AddWithValue("@Fase_vuelo_otro", Fase_vuelo_otro)
            End If


            Try
                conn.Open()
                numr = Convert.ToInt32(cmd.ExecuteScalar())
                id_formulario = Convert.ToInt32(cmd_id.ExecuteScalar())
                conn.Close()

            Catch ex As Exception
                Console.WriteLine(ex.Message)
                ScriptManager.RegisterStartupScript(Page, Page.GetType, "alertjs", "alert(' " & ex.Message & "');", True)
            End Try

        End Using






    End Sub


    Protected Sub ASPxPopupControl2_Unload(sender As Object, e As EventArgs) Handles ASPxPopupControl2.Unload

    End Sub


    Protected Sub ASPxButton2_Click(sender As Object, e As EventArgs) Handles ASPxButton2.Click
        Response.Redirect("../default.aspx")
    End Sub

    Protected Sub ASPxUploadControl1_FileUploadComplete(sender As Object, e As DevExpress.Web.FileUploadCompleteEventArgs)

    End Sub

    Protected Sub ASPxUploadControlArchivo_FileUploadComplete(sender As Object, e As DevExpress.Web.FileUploadCompleteEventArgs) Handles ASPxUploadControlArchivos.FileUploadComplete
       
        nombre_archivo = e.UploadedFile.FileName
        archivo = e.UploadedFile.FileBytes

    End Sub

    Protected Sub ASPxUploadControlArchivo_FilesUploadComplete(sender As Object, e As DevExpress.Web.FilesUploadCompleteEventArgs) ' Handles ASPxUploadControlArchivo.FilesUploadComplete

    End Sub
End Class