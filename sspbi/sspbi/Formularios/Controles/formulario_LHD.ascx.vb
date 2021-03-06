Imports System.Data.SqlClient
Imports System.Reflection

Public Class formulario_LHD
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

    Protected Sub ASPxButtonEnviar_Click(sender As Object, e As EventArgs) Handles ASPxButtonEnviar.Click, ASPxUploadControlArchivos.FileUploadComplete
        If HiddenFieldValor.Get("valor").Equals("vacio") Then
        Else
            Ingreso_Formulario()
            Enviar_Formulario_Correo()
            Session("formulario_LHD") = True
            ASPxPopupControl2.ShowOnPageLoad = True
        End If


        If id_formulario = 0 Then
        ElseIf id_formulario.Equals(Nothing) Then
        Else
            guardarArchivosbd.insertar_archivo(id_formulario, nombre_archivo, archivo)
        End If



    End Sub

    Private Sub Enviar_Formulario_Correo()
        'correosEnvio.Enviar_Formulario_Correo_Lista(Llenar_Correo_Formulario(), "Formulario LHD", "LHD", ambiente)
        Try
            correosEnvio.Enviar_Formulario_Correo_Lista_Archivo(Llenar_Correo_Formulario(),
                                                          "Formulario LHD",
                                                          "LHD",
                                                           ambiente,
                                                           nombre_archivo,
                                                           archivo)
        Catch ex As Exception
            correosEnvio.Enviar_Formulario_Correo_Lista(Llenar_Correo_Formulario(),
                                                            "Formulario LHD",
                                                          "LHD",
                                                           ambiente)
        End Try
        Try
            correosEnvio.Enviar_Confirmacion_Correo("Formulario LHD", ASPxTextBoxEmail.Value)
        Catch ex As Exception

        End Try

      
    End Sub

    Private Function Llenar_Correo_Formulario() As ArrayList
        Dim datos_formulario As New ArrayList
        datos_formulario.Add("Formulario LHD" + "<br>")
        datos_formulario.Add("<br>")
        datos_formulario.Add("ID: " + id_formulario.ToString + " " + "<br>")
        datos_formulario.Add("<br>")
        datos_formulario.Add("Nombre: " + ASPxTextBoxNombreApellido.Value + " " + "<br>")
        datos_formulario.Add("<br>")
        datos_formulario.Add("Email: " + ASPxTextBoxEmail.Value + " " + "<br>")
        datos_formulario.Add("<br>")
        datos_formulario.Add("Teléfono: " + ASPxTextBoxTelefono.Value + " " + "<br>")
        datos_formulario.Add("<br>")

        If ASPxTextBoxLicenciaATC.Value Is Nothing Then
            datos_formulario.Add("Licencia ATC: " + " " + "<br>")
            datos_formulario.Add("<br>")
        Else
            datos_formulario.Add("Licencia ATC: " + ASPxTextBoxLicenciaATC.Value + " " + "<br>")
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

        If ASPxTextBoxRegistro1.Value Is Nothing Then
            datos_formulario.Add("Registro de Aeronave 1: " + " " + "<br>")
            datos_formulario.Add("<br>")
        Else
            datos_formulario.Add("Registro de Aeronave 1: " + ASPxTextBoxRegistro1.Value + " " + "<br>")
            datos_formulario.Add("<br>")
        End If

        If ASPxTextBoxRegistro2.Value Is Nothing Then
            datos_formulario.Add("Registro de Aeronave 2: " + " " + "<br>")
            datos_formulario.Add("<br>")
        Else
            datos_formulario.Add("Registro de Aeronave 2: " + ASPxTextBoxRegistro2.Value + " " + "<br>")
            datos_formulario.Add("<br>")
        End If

        If ASPxTextBoxModelo1.Value Is Nothing Then
            datos_formulario.Add("Modelo de Aeronave 1: " + " " + "<br>")
            datos_formulario.Add("<br>")
        Else
            datos_formulario.Add("Modelo de Aeronave 1: " + ASPxTextBoxModelo1.Value + " " + "<br>")
            datos_formulario.Add("<br>")
        End If

        If ASPxTextBoxModelo2.Value Is Nothing Then
            datos_formulario.Add("Modelo de Aeronave 2: " + " " + "<br>")
            datos_formulario.Add("<br>")
        Else
            datos_formulario.Add("Modelo de Aeronave 2: " + ASPxTextBoxModelo2.Value + " " + "<br>")
            datos_formulario.Add("<br>")
        End If

        If ASPxComboBoxAeropuertos1Salida.SelectedItem Is Nothing Then
            datos_formulario.Add("Aerodromo de Salida 1: " + " " + "<br>")
            datos_formulario.Add("<br>")
        Else
            datos_formulario.Add("Aerodromo de Salida 1: " + ASPxComboBoxAeropuertos1Salida.SelectedItem.Value + " " + "<br>")
            datos_formulario.Add("<br>")
        End If

        If ASPxComboBoxAeropuertos2Salida.SelectedItem Is Nothing Then
            datos_formulario.Add("Aerodromo de Salida 2: " + " " + "<br>")
            datos_formulario.Add("<br>")
        Else
            datos_formulario.Add("Aerodromo de Salida 2: " + ASPxComboBoxAeropuertos2Salida.SelectedItem.Value + " " + "<br>")
            datos_formulario.Add("<br>")
        End If

        If ASPxComboBoxAeropuertos1Destino.SelectedItem Is Nothing Then
            datos_formulario.Add("Aerodromo de Llegada 1: " + " " + "<br>")
            datos_formulario.Add("<br>")
        Else
            datos_formulario.Add("Aerodromo de Llegada 1: " + ASPxComboBoxAeropuertos1Destino.SelectedItem.Value + " " + "<br>")
            datos_formulario.Add("<br>")
        End If

        If ASPxComboBoxAeropuertos2Destino.SelectedItem Is Nothing Then
            datos_formulario.Add("Aerodromo de Llegada 2: " + " " + "<br>")
            datos_formulario.Add("<br>")
        Else
            datos_formulario.Add("Aerodromo de Llegada 2: " + ASPxComboBoxAeropuertos2Destino.SelectedItem.Value + " " + "<br>")
            datos_formulario.Add("<br>")
        End If

        datos_formulario.Add("Lugar Ocurrencia: " + " " + "<br>")

        If ASPxTextBoxLongitud.Value Is Nothing Then
            datos_formulario.Add("Longitud: " + " " + "<br>")
            datos_formulario.Add("<br>")
        Else
            datos_formulario.Add("Longitud: " + ASPxTextBoxLongitud.Value + " " + "<br>")
            datos_formulario.Add("<br>")
        End If

        If ASPxTextBoxLatitud.Value Is Nothing Then
            datos_formulario.Add("Latitud " + " " + "<br>")
            datos_formulario.Add("<br>")
        Else
            datos_formulario.Add("Longitud: " + ASPxTextBoxLatitud.Value + " " + "<br>")
            datos_formulario.Add("<br>")
        End If

        If ASPxComboBoxRutaAerovia.SelectedItem Is Nothing Then
            datos_formulario.Add("Ruta / Aerovía: " + " " + "<br>")
            datos_formulario.Add("<br>")
        Else
            datos_formulario.Add("Ruta / Aerovía: " + ASPxComboBoxRutaAerovia.SelectedItem.Value + " " + "<br>")
            datos_formulario.Add("<br>")
        End If

        If ASPxComboBoxCondicionesMET.SelectedItem Is Nothing Then
            datos_formulario.Add("Condiciones MET: " + " " + "<br>")
            datos_formulario.Add("<br>")
        Else
            datos_formulario.Add("Condiciones MET: " + ASPxComboBoxCondicionesMET.SelectedItem.Value + " " + "<br>")
            datos_formulario.Add("<br>")
        End If

        If ASPxRadioButtonListVisualizadoSSR.SelectedItem Is Nothing Then
            datos_formulario.Add("Visualizado SSR: " + " " + "<br>")
            datos_formulario.Add("<br>")
        Else
            datos_formulario.Add("Visualizado SSR: " + ASPxRadioButtonListVisualizadoSSR.SelectedItem.Value + " " + "<br>")
            datos_formulario.Add("<br>")
        End If

        If ASPxTextBoxFLautorizado.Value Is Nothing Then
            datos_formulario.Add("FL Autorizado: " + " " + "<br>")
            datos_formulario.Add("<br>")
        Else
            datos_formulario.Add("FL Autorizado: " + ASPxTextBoxFLautorizado.Value + " " + "<br>")
            datos_formulario.Add("<br>")
        End If

        If ASPxTextBoxFLincorrecto.Value Is Nothing Then
            datos_formulario.Add("FL Incorrecto (Segundos): " + " " + "<br>")
            datos_formulario.Add("<br>")
        Else
            datos_formulario.Add("FL Incorrecto (Segundos): " + ASPxTextBoxFLincorrecto.Value + " " + "<br>")
            datos_formulario.Add("<br>")
        End If

        If ASPxTextBoxNivelVuelo.Value Is Nothing Then
            datos_formulario.Add("Nivel Vuelo: " + " " + "<br>")
            datos_formulario.Add("<br>")
        Else
            datos_formulario.Add("Nivel Vuelo: " + ASPxTextBoxNivelVuelo.Value + " " + "<br>")
            datos_formulario.Add("<br>")
        End If

        If ASPxRadioButtonListFuenteInformacion.SelectedItem Is Nothing Then
            datos_formulario.Add("Fuente de Información: " + " " + "<br>")
            datos_formulario.Add("<br>")
        Else
            datos_formulario.Add("Fuente de Información: " + ASPxRadioButtonListFuenteInformacion.SelectedItem.Value + " " + "<br>")
            datos_formulario.Add("<br>")
        End If

        If ASPxRadioButtonListcumpliranexo2.SelectedItem Is Nothing Then
            datos_formulario.Add("El FL al final cumplió con las tablas de crucero del ANEXO 2: " + " " + "<br>")
            datos_formulario.Add("<br>")
        Else
            datos_formulario.Add("El FL al final cumplió con las tablas de crucero del ANEXO 2: " + ASPxRadioButtonListcumpliranexo2.SelectedItem.Value + " " + "<br>")
            datos_formulario.Add("<br>")
        End If

        If ASPxRadioButtonListCargaTrabajo.SelectedItem Is Nothing Then
            datos_formulario.Add("Carga Trabajo: " + " " + "<br>")
            datos_formulario.Add("<br>")
        Else
            datos_formulario.Add("Carga Trabajo: " + ASPxRadioButtonListCargaTrabajo.SelectedItem.Value + " " + "<br>")
            datos_formulario.Add("<br>")
        End If

        If ASPxTextBoxCausasDesviacion.Value Is Nothing Then
            datos_formulario.Add("Causa Desviación: " + " " + "<br>")
            datos_formulario.Add("<br>")
        Else
            datos_formulario.Add("Causa Desviación: " + ASPxTextBoxCausasDesviacion.Value + " " + "<br>")
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
        sql = sql + "telefono, fecha, hora, Licencia_ATC, Distancia_Aeronaves, Latitud, Longitud, Ruta_Aerovia, Condiciones_Meteorologicas, "
        sql = sql + "Visualizado_SSR, FL_Autorizado, Tiempo_estimado_FL_incorrecto, Nivel_vuelo, Fuente_informacion, FL_anexo2, "
        sql = sql + "Carga_Trabajo_ATC, Causa_desviacion, descripcion) values"
        sql = sql + "(@form_id, @version, @fecha_creacion, @nombre, @email, "
        sql = sql + "@telefono, @fecha, @hora, @Licencia_ATC, @Distancia_Aeronaves, @Latitud, @Longitud, @Ruta_Aerovia, @Condiciones_Meteorologicas, "
        sql = sql + "@Visualizado_SSR, @FL_Autorizado, @Tiempo_estimado_FL_incorrecto, @Nivel_vuelo, @Fuente_informacion, @FL_anexo2, "
        sql = sql + "@Carga_Trabajo_ATC, @Causa_desviacion, @descripcion) "

        Using conn As New SqlConnection(cn)
            Dim cmd As New SqlCommand(sql, conn)
            Dim cmd_id As New SqlCommand(id_reporte, conn)
            cmd.Parameters.AddWithValue("@form_id", 10)
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

            If ASPxTextBoxTelefono.Value Is Nothing Then
                cmd.Parameters.AddWithValue("@telefono", "")
            ElseIf ASPxTextBoxTelefono.Value.Equals("") Then
                cmd.Parameters.AddWithValue("@telefono", "")
            Else
                cmd.Parameters.AddWithValue("@telefono", ASPxTextBoxTelefono.Value)

            End If

            If ASPxTextBoxDistanciaAeronaves.Value Is Nothing Then
                cmd.Parameters.AddWithValue("@Distancia_Aeronaves", "")
            ElseIf ASPxTextBoxLatitud.Value.Equals("") Then
                cmd.Parameters.AddWithValue("@Distancia_Aeronaves", "")
            Else
                cmd.Parameters.AddWithValue("@Distancia_Aeronaves", ASPxTextBoxDistanciaAeronaves.Value)

            End If


            If ASPxTextBoxLatitud.Value Is Nothing Then
                cmd.Parameters.AddWithValue("@Latitud", "")
            ElseIf ASPxTextBoxLatitud.Value.Equals("") Then
                cmd.Parameters.AddWithValue("@Latitud", "")
            Else
                cmd.Parameters.AddWithValue("@Latitud", ASPxTextBoxLatitud.Value)

            End If

            If ASPxTextBoxLongitud.Value Is Nothing Then
                cmd.Parameters.AddWithValue("@Longitud", "")
            ElseIf ASPxTextBoxLongitud.Value.Equals("") Then
                cmd.Parameters.AddWithValue("@Longitud", "")
            Else
                cmd.Parameters.AddWithValue("@Longitud", ASPxTextBoxLongitud.Value)

            End If

            If ASPxComboBoxCondicionesMET.SelectedItem Is Nothing Then
                cmd.Parameters.AddWithValue("@Condiciones_Meteorologicas", "")
            ElseIf ASPxComboBoxCondicionesMET.SelectedItem.Value.Equals("") Then
                cmd.Parameters.AddWithValue("@Condiciones_Meteorologicas", "")
            Else
                cmd.Parameters.AddWithValue("@Condiciones_Meteorologicas", ASPxComboBoxCondicionesMET.SelectedItem.Value)

            End If


            If ASPxComboBoxRutaAerovia.SelectedItem Is Nothing Then
                cmd.Parameters.AddWithValue("@Ruta_Aerovia", "")
            ElseIf ASPxComboBoxRutaAerovia.SelectedItem.Equals("") Then
                cmd.Parameters.AddWithValue("@Ruta_Aerovia", "")
            Else
                cmd.Parameters.AddWithValue("@Ruta_Aerovia", ASPxComboBoxRutaAerovia.SelectedItem.Value)

            End If


            If ASPxTextBoxLicenciaATC.Value Is Nothing Then
                cmd.Parameters.AddWithValue("@Licencia_ATC", "")
            ElseIf ASPxTextBoxLicenciaATC.Value.Equals("") Then
                cmd.Parameters.AddWithValue("@Licencia_ATC", "")
            Else
                cmd.Parameters.AddWithValue("@Licencia_ATC", ASPxTextBoxLicenciaATC.Value)

            End If

            If ASPxRadioButtonListVisualizadoSSR.SelectedItem Is Nothing Then
                cmd.Parameters.AddWithValue("@Visualizado_SSR", "")
            ElseIf ASPxRadioButtonListVisualizadoSSR.SelectedItem.Value.Equals("") Then
                cmd.Parameters.AddWithValue("@Visualizado_SSR", "")
            Else
                cmd.Parameters.AddWithValue("@Visualizado_SSR", ASPxRadioButtonListVisualizadoSSR.SelectedItem.Value)

            End If

            If ASPxTextBoxFLautorizado.Value Is Nothing Then
                cmd.Parameters.AddWithValue("@FL_Autorizado", "")
            ElseIf ASPxTextBoxFLautorizado.Value.Equals("") Then
                cmd.Parameters.AddWithValue("@FL_Autorizado", "")
            Else
                cmd.Parameters.AddWithValue("@FL_Autorizado", ASPxTextBoxFLautorizado.Value)

            End If



            If ASPxTextBoxFLincorrecto.Value Is Nothing Then
                cmd.Parameters.AddWithValue("@Tiempo_estimado_FL_incorrecto", "")
            ElseIf ASPxTextBoxFLincorrecto.Value.Equals("") Then
                cmd.Parameters.AddWithValue("@Tiempo_estimado_FL_incorrecto", "")
            Else
                cmd.Parameters.AddWithValue("@Tiempo_estimado_FL_incorrecto", ASPxTextBoxFLincorrecto.Value)

            End If

            If ASPxTextBoxNivelVuelo.Value Is Nothing Then
                cmd.Parameters.AddWithValue("@Nivel_vuelo", "")
            ElseIf ASPxTextBoxNivelVuelo.Value.Equals("") Then
                cmd.Parameters.AddWithValue("@Nivel_vuelo", "")
            Else
                cmd.Parameters.AddWithValue("@Nivel_vuelo", ASPxTextBoxNivelVuelo.Value)
            End If

            If ASPxRadioButtonListFuenteInformacion.SelectedItem Is Nothing Then
                cmd.Parameters.AddWithValue("@Fuente_informacion", "")
            ElseIf ASPxRadioButtonListFuenteInformacion.SelectedItem.Value.Equals("") Then
                cmd.Parameters.AddWithValue("@Fuente_informacion", "")
            Else
                cmd.Parameters.AddWithValue("@Fuente_informacion", ASPxRadioButtonListFuenteInformacion.SelectedItem.Value)

            End If

            If ASPxRadioButtonListcumpliranexo2.SelectedItem Is Nothing Then
                cmd.Parameters.AddWithValue("@FL_anexo2", "")
            ElseIf ASPxRadioButtonListcumpliranexo2.SelectedItem.Value.Equals("") Then
                cmd.Parameters.AddWithValue("@FL_anexo2", "")
            Else
                cmd.Parameters.AddWithValue("@FL_anexo2", ASPxRadioButtonListcumpliranexo2.SelectedItem.Value)
            End If

            If ASPxRadioButtonListCargaTrabajo.SelectedItem Is Nothing Then
                cmd.Parameters.AddWithValue("@Carga_Trabajo_ATC", "")
            ElseIf ASPxRadioButtonListCargaTrabajo.SelectedItem.Value.Equals("") Then
                cmd.Parameters.AddWithValue("@Carga_Trabajo_ATC", "")
            Else
                cmd.Parameters.AddWithValue("@Carga_Trabajo_ATC", ASPxRadioButtonListCargaTrabajo.SelectedItem.Value)
            End If


            If ASPxTextBoxCausasDesviacion.Value Is Nothing Then
                cmd.Parameters.AddWithValue("@Causa_desviacion", "")
            ElseIf ASPxTextBoxCausasDesviacion.Value.Equals("") Then
                cmd.Parameters.AddWithValue("@Causa_desviacion", "")
            Else
                cmd.Parameters.AddWithValue("@Causa_desviacion", ASPxTextBoxCausasDesviacion.Value)
            End If

            If ASPxMemoDescripcionNarrativa.Value Is Nothing Then
                cmd.Parameters.AddWithValue("@descripcion", "")
            ElseIf ASPxMemoDescripcionNarrativa.Value.Equals("") Then
                cmd.Parameters.AddWithValue("@descripcion", "")
            Else
                cmd.Parameters.AddWithValue("@descripcion", ASPxMemoDescripcionNarrativa.Value)
            End If

            Dim num_vuelo1, num_vuelo2, reg1, reg2, ops1, ops2, mod1, mod2, tip_aero1, tip_aero2, aerodromo_sal1, aerodromo_sal2, aerodromo_des1, aerodromo_des2, fas_vuel1, fas_vuel2, fas_vuel_otro1, fas_vuel_otro2 As String

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

            If ASPxTextBoxRegistro1.Value Is Nothing Then
                reg1 = ""
            Else
                reg1 = ASPxTextBoxRegistro1.Value
            End If

            If ASPxTextBoxRegistro2.Value Is Nothing Then
                reg2 = ""
            Else
                reg2 = ASPxTextBoxRegistro2.Value
            End If

            If ASPxTextBoxModelo1.Value Is Nothing Then
                mod1 = ""
            Else
                mod1 = ASPxTextBoxModelo1.Value
            End If

            If ASPxTextBoxModelo2.Value Is Nothing Then
                mod2 = ""
            Else
                mod2 = ASPxTextBoxModelo2.Value
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

            If ASPxComboBoxAeropuertos1Salida.SelectedItem Is Nothing Then
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


            If ambiente.Equals("PRUEBAS") Then
                id_formulario = 0
            Else
                'aeronaves


                Try
                    conn.Open()
                    numr = Convert.ToInt32(cmd.ExecuteScalar())
                    id_formulario = Convert.ToInt32(cmd_id.ExecuteScalar())
                    Ingreso_Aeronave(num_vuelo1, reg1, mod1, ops1, tip_aero1, aerodromo_sal1, aerodromo_des1)
                    Ingreso_Aeronave(num_vuelo2, reg2, mod2, ops2, tip_aero2, aerodromo_sal2, aerodromo_des2)
                    conn.Close()

                Catch ex As Exception
                    Console.WriteLine(ex.Message)
                    ScriptManager.RegisterStartupScript(Page, Page.GetType, "alertjs", "alert(' " & ex.Message & "');", True)
                End Try

            End If

        End Using

    End Sub
    Private Sub Ingreso_Aeronave(numero_vuelo_matricula As String, Registro As String, Modelo As String, Operador As String, Tipo_Aeronave As String, lugar_id_origen As String, lugar_id_destino As String)


        Dim numr As Integer
        Dim id_reporte As String = "SELECT TOP 1 * FROM Notificaciones_NSSP ORDER BY id DESC"
        Dim cn As String = "Data Source=win-sqlserv-02;Initial Catalog=SSP_BI;User ID=adminsql;Password=sistema*-!;"
        Dim sql As String = "insert into aeronaves_notificaciones(id_formulario, Numero_vuelo_matricula, Registro, Modelo, Operador, Tipo_Aeronave, "
        sql = sql + "lugar_id_origen, lugar_id_destino) values(@id_formulario, @Numero_vuelo_matricula, @Registro, @Modelo, @Operador, @Tipo_Aeronave, "
        sql = sql + "@lugar_id_origen, @lugar_id_destino)"


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

            If Registro Is Nothing Then
                cmd.Parameters.AddWithValue("@Registro", "")
            Else
                cmd.Parameters.AddWithValue("@Registro", Registro)
            End If

            If Modelo Is Nothing Then
                cmd.Parameters.AddWithValue("@Modelo", "")
            Else
                cmd.Parameters.AddWithValue("@Modelo", Modelo)
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


    'Protected Sub ASPxButton2_Click(sender As Object, e As EventArgs) Handles ASPxButton2.Click
    '    Response.Redirect("../default.aspx")
    'End Sub

    Protected Sub ASPxUploadControl1_FileUploadComplete(sender As Object, e As DevExpress.Web.FileUploadCompleteEventArgs)
        nombre_archivo = e.UploadedFile.FileName
        archivo = e.UploadedFile.FileBytes
    End Sub

    Protected Sub ASPxUploadControlArchivo_FileUploadComplete(sender As Object, e As DevExpress.Web.FileUploadCompleteEventArgs) Handles ASPxUploadControlArchivos.FileUploadComplete
        If id_formulario = Nothing Then
        Else
            guardarArchivosbd.insertar_archivo(id_formulario, e.UploadedFile.FileName, e.UploadedFile.FileBytes)
        End If
        nombre_archivo = e.UploadedFile.FileName
        archivo = e.UploadedFile.FileBytes

    End Sub

    Protected Sub ASPxUploadControlArchivo_FilesUploadComplete(sender As Object, e As DevExpress.Web.FilesUploadCompleteEventArgs) ' Handles ASPxUploadControlArchivo.FilesUploadComplete

    End Sub

    Protected Sub ASPxButtonRegresoMenu_Click(sender As Object, e As EventArgs) Handles ASPxButtonRegresoMenu.Click
        Response.Redirect("../default.aspx")
    End Sub
End Class