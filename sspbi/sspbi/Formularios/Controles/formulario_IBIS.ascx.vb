Imports System.Reflection
Imports System.Data.SqlClient

Public Class formulario_IBIS
    Inherits System.Web.UI.UserControl
    Private CorreosEnvío As New CorreosEnvío
    Private guardararchivosbd As New Guardar_Archivos_BD
    Private id_formulario As Integer
    Private repeticiones As Integer
    Private ambiente As String
    Private nombre_archivo As String = ""
    Private archivo As Byte()

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        '   repeticiones = 0
        'ASPxButtonRecargar.Visible = False


    End Sub

    Protected Sub ASPxButton1_Click(sender As Object, e As EventArgs) Handles ASPxButtonEnviar.Click

        If HiddenFieldValor.Get("valor").Equals("vacio") Then
        Else
            ASPxPopupControl2.ShowOnPageLoad = True
            ScriptManager.RegisterClientScriptBlock(Me, Me.Page.GetType(), "dxsi_HidePopup", "ASPxPopupControl2.Show();", True)

            Ingreso_Formulario()
            Enviar_Formulario_Correo()
        End If
        If id_formulario = 0 Then
        ElseIf id_formulario.Equals(Nothing) Then
        Else
            guardararchivosbd.insertar_archivo(id_formulario, nombre_archivo, archivo)
        End If

    End Sub
    Private Sub Enviar_Formulario_Correo()
        'CorreosEnvío.Enviar_Formulario_Correo_Lista(Llenar_Correo_Formulario(), "Formulario IBIS-AVIS", "IBIS", ambiente)
        Try
            CorreosEnvío.Enviar_Formulario_Correo_Lista_Archivo(Llenar_Correo_Formulario(),
                                                           "Formulario IBIS-AVIS",
                                                           "IBIS",
                                                           ambiente,
                                                           nombre_archivo,
                                                           archivo)
        Catch ex As Exception
            CorreosEnvío.Enviar_Formulario_Correo_Lista(Llenar_Correo_Formulario(),
                                                           "Formulario IBIS-AVIS",
                                                           "IBIS",
                                                           ambiente)
        End Try

        Try
            CorreosEnvío.Enviar_Confirmacion_Correo("Formulario IBIS-AVIS", ASPxTextBoxEmail.Value)
        Catch ex As Exception

        End Try
       
    End Sub
    Private Function Llenar_Correo_Formulario() As ArrayList
        Dim datos_formulario As New ArrayList
        datos_formulario.Add("Formulario IBIS" + "<br>")
        datos_formulario.Add("<br>")
        datos_formulario.Add("ID: " + id_formulario.ToString() + " " + "<br>")
        datos_formulario.Add("<br>")
        datos_formulario.Add("Nombre: " + ASPxTextBoxNombreApellido.Value + " " + "<br>")
        datos_formulario.Add("<br>")
        datos_formulario.Add("Email: " + ASPxTextBoxEmail.Value + " " + "<br>")
        datos_formulario.Add("<br>")
        datos_formulario.Add("Teléfono: " + ASPxTextBoxTelefono.Value + " " + "<br>")
        datos_formulario.Add("<br>")
        If ASPxRadioButtonListActividadDedica.SelectedItem Is Nothing Then
            datos_formulario.Add("Actividad a la que se dedica: " + "" + " " + "<br>")
            datos_formulario.Add("<br>")

        Else
            datos_formulario.Add("Actividad a la que se dedica: " + ASPxRadioButtonListActividadDedica.SelectedItem.Value + " " + "<br>")
            datos_formulario.Add("<br>")

        End If
        If ASPxDateEditFecha.Value Is Nothing Then
            datos_formulario.Add("Fecha: " + Now() + "<br>")
            datos_formulario.Add("<br>")
        Else
            datos_formulario.Add("Fecha: " + ASPxDateEditFecha.Value.ToString() + "<br>")
            datos_formulario.Add("<br>")
        End If

        If ASPxTimeEditHora.Value Is Nothing Then
            datos_formulario.Add("Hora: " + " " + "<br>")
            datos_formulario.Add("<br>")
        Else
            datos_formulario.Add("Hora: " + ASPxTimeEditHora.Value.ToString().Substring(11) + " " + "<br>")
            datos_formulario.Add("<br>")
        End If

        If ASPxComboBoxAeropuertos.SelectedItem Is Nothing Then
            datos_formulario.Add("Ubicación: " + " " + "<br>")
            datos_formulario.Add("<br>")
        Else
            datos_formulario.Add("Ubicación: " + ASPxComboBoxAeropuertos.SelectedItem.Text + " " + "<br>")
            datos_formulario.Add("<br>")
        End If
        datos_formulario.Add("Coordenadas: " + ASPxTextBoxCoordenadas.Value + " " + "<br>")
        datos_formulario.Add("<br>")
        If ASPxRadioButtonCoordenadasNorteSur.SelectedItem Is Nothing Then
            datos_formulario.Add("Coordenadas Norte/Sur: " + " " + "<br>")
            datos_formulario.Add("<br>")
        Else
            datos_formulario.Add("Coordenadas Norte/Sur: " + ASPxRadioButtonCoordenadasNorteSur.SelectedItem.Value + " " + "<br>")
            datos_formulario.Add("<br>")
        End If
        datos_formulario.Add("Coordenadas Otro: " + ASPxRadioButtonCoordenadasNorteSur.SelectedItem.Value + " " + "<br>")
        datos_formulario.Add("<br>")


        If ASPxComboBoxCondicionesLuz.SelectedItem Is Nothing Then
            datos_formulario.Add("Condiciones de Luz: " + " " + "<br>")
            datos_formulario.Add("<br>")
        Else
            datos_formulario.Add("Condiciones de Luz: " + ASPxComboBoxCondicionesLuz.SelectedItem.Value + " " + "<br>")
            datos_formulario.Add("<br>")
        End If
        If ASPxTextBoxIdentificacion.Value Is Nothing Then
            datos_formulario.Add("Identificación de la Aeronave " + " " + "<br>")
            datos_formulario.Add("<br>")
        Else
            datos_formulario.Add("Identificación de la Aeronave " + ASPxTextBoxIdentificacion.Value + "<br>")
            datos_formulario.Add("<br>")
        End If
        If ASPxTextBoxOperador.Value Is Nothing Then
            datos_formulario.Add("Operador: " + "" + "<br>")
            datos_formulario.Add("<br>")
        Else
            datos_formulario.Add("Operador: " + ASPxTextBoxOperador.Value + "<br>")
            datos_formulario.Add("<br>")
        End If

        If ASPxTextBoxTipoAeronave.Value Is Nothing Then
            datos_formulario.Add("Tipo de Aeronave: " + "" + "<br>")
            datos_formulario.Add("<br>")
        Else
            datos_formulario.Add("Tipo de Aeronave: " + ASPxTextBoxTipoAeronave.Value + "<br>")
            datos_formulario.Add("<br>")
        End If

        If ASPxRadioButtonListFaseVuelo.SelectedItem Is Nothing Then
            datos_formulario.Add("Fase de Vuelo: " + " " + "<br>")
            datos_formulario.Add("<br>")
        Else
            datos_formulario.Add("Fase de Vuelo: " + ASPxRadioButtonListFaseVuelo.SelectedItem.Value + "<br>")
            datos_formulario.Add("<br>")
        End If

        If ASPxTextBoxModeloMotor.Value Is Nothing Then
            datos_formulario.Add("Modelo Motor: " + "" + "<br>")
            datos_formulario.Add("<br>")
        Else
            datos_formulario.Add("Modelo Motor: " + ASPxTextBoxModeloMotor.Value + "<br>")
            datos_formulario.Add("<br>")
        End If

        If ASPxTextBoxPosicionRuta.Value Is Nothing Then
            datos_formulario.Add("Posición si fue en ruta: " + "" + "<br>")
            datos_formulario.Add("<br>")
        Else
            datos_formulario.Add("Posición si fue en ruta: " + ASPxTextBoxPosicionRuta.Value + "<br>")
            datos_formulario.Add("<br>")
        End If
        If ASPxRadioButtonListCantidadAvesObservadas.SelectedItem Is Nothing Then
            datos_formulario.Add("Aves Observadas: " + "" + "<br>")
            datos_formulario.Add("<br>")
        Else
            datos_formulario.Add("Aves Observadas: " + ASPxRadioButtonListCantidadAvesObservadas.SelectedItem.Value + "<br>")
            datos_formulario.Add("<br>")
        End If

        If ASPxRadioButtonListCantidadAvesGolpeadas.SelectedItem Is Nothing Then
            datos_formulario.Add("Aves Golpeadas: " + "" + "<br>")
            datos_formulario.Add("<br>")
        Else
            datos_formulario.Add("Aves Golpeadas: " + ASPxRadioButtonListCantidadAvesGolpeadas.SelectedItem.Value + "<br>")
            datos_formulario.Add("<br>")
        End If

      
        If ASPxTextBoxPosicionRuta.Value Is Nothing Then
        Else
            datos_formulario.Add("Posición si fue en ruta: " + ASPxTextBoxPosicionRuta.Value + "<br>")
            datos_formulario.Add("<br>")
        End If
        
        'array de consecuencias
        If ASPxCheckBoxListConsecuenciasVuelo.SelectedItems Is Nothing Then
            datos_formulario.Add("Consecuencia de Vuelo: " + "" + "<br>")
            datos_formulario.Add("<br>")
        Else

            For Each check As DevExpress.Web.ListEditItem In ASPxCheckBoxListConsecuenciasVuelo.Items
                If check.Selected.Equals(True) Then

                    datos_formulario.Add("Consecuencia de Vuelo: " + check.Text + "<br>")
                    datos_formulario.Add("<br>")


                End If
            Next

        End If

        'array de condiciones
        If ASPxCheckBoxListCondicionesCielo.SelectedItems.Count.Equals(0) Then
            datos_formulario.Add("Condiciones de Cielo: " + "" + "<br>")
            datos_formulario.Add("<br>")
        Else
            For Each check As DevExpress.Web.ListEditItem In ASPxCheckBoxListCondicionesCielo.Items
                If check.Selected.Equals(True) Then
                    datos_formulario.Add("Condiciones de Cielo: " + check.Text + "<br>")
                    datos_formulario.Add("<br>")
                End If
            Next
        End If

        'array de precipitaciones
        If ASPxCheckBoxListPrecipitacion.SelectedItems.Count.Equals(0) Then
            datos_formulario.Add("Precipitación: " + "" + "<br>")
            datos_formulario.Add("<br>")
        Else
            For Each check As DevExpress.Web.ListEditItem In ASPxCheckBoxListPrecipitacion.Items
                If check.Selected.Equals(True) Then
                    datos_formulario.Add("Precipitación: " + check.Text + "<br>")
                    datos_formulario.Add("<br>")
                End If
            Next
        End If



        'demas del formulario

        If ASPxRadioButtonListTamanioAves.SelectedItem Is Nothing Then
            datos_formulario.Add("Tamaño de Aves: " + "" + "<br>")
            datos_formulario.Add("<br>")
        Else
            datos_formulario.Add("Tamaño de Aves: " + ASPxRadioButtonListTamanioAves.SelectedItem.Value + "<br>")
            datos_formulario.Add("<br>")
        End If

        If ASPxRadioButtonListAdvertenciaPiloto.SelectedItem Is Nothing Then
            datos_formulario.Add("Advertencia al Piloto: " + "" + "<br>")
            datos_formulario.Add("<br>")
        Else
            datos_formulario.Add("Advertencia al Piloto: " + ASPxRadioButtonListAdvertenciaPiloto.SelectedItem.Value + "<br>")
            datos_formulario.Add("<br>")
        End If

        If ASPxTextBoxTiempoFueraServicioAeronave.Value Then
            datos_formulario.Add("Tiempo Fuera de Servicio: " + "" + "<br>")
            datos_formulario.Add("<br>")
        Else
            datos_formulario.Add("Tiempo Fuera de Servicio: " + ASPxTextBoxTiempoFueraServicioAeronave.Value + "<br>")
            datos_formulario.Add("<br>")
        End If

        If ASPxTextBoxCostoReparacion.Value Then
            datos_formulario.Add("Costo Reparación: " + "" + "<br>")
            datos_formulario.Add("<br>")
        Else
            datos_formulario.Add("Costo Reparación: " + ASPxTextBoxCostoReparacion.Value + "<br>")
            datos_formulario.Add("<br>")
        End If
        If ASPxTextBoxOtrosCostos.Value Then
            datos_formulario.Add("Otros Costos: " + "" + "<br>")
            datos_formulario.Add("<br>")
        Else
            datos_formulario.Add("Otros Costos: " + ASPxTextBoxOtrosCostos.Value + "<br>")
            datos_formulario.Add("<br>")
        End If

        datos_formulario.Add("Descripción: " + ASPxMemoDescripcion.Value + "<br>")
        datos_formulario.Add("<br>")



        Return datos_formulario
    End Function

    Private Sub Ingreso_Formulario()
        ambiente = "PRODUCCION"
        Dim numr As Integer
        Dim sql2 As String = "SELECT TOP 1 *  FROM [SSP_BI].[dbo].[Notificaciones_NSSP] ORDER BY id DESC "
        Dim cn As String = "Data Source=win-sqlserv-02;Initial Catalog=SSP_BI;User ID=adminsql;Password=sistema*-!;"
        Dim sql As String = "insert into Notificaciones_NSSP(form_id, version, ambiente, fecha_creacion, nombre, email, "
        sql = sql + "telefono, lugar_id, Actividad_dedica, fecha, hora, pista, Coordenadas, Coordenadas_Direccion, "
        sql = sql + "Condiciones_de_Luz, Altura_pies, Velocidad_Indicada_Nudos, Matricula, Operador, Tipo_Aeronave, "
        sql = sql + "modelo_motor, posicion_actividad_suceso, Fase_Vuelo,  "
        sql = sql + " Cantidad_Aves_Observadas, Cantidad_Aves_Golpeadas, Identificacion_Fauna, "
        sql = sql + "Tamanio_Fauna, Advertencia_Piloto, Tiempo_Fuera_Servicio_Aeronave, Costo_Estimado_Reparacion_Substitucion_Aeronave, "
        sql = sql + "Otros_Costos, descripcion) values"
        sql = sql + "(@form_id, @version, @ambiente, @fecha_creacion, @nombre, @email, "
        sql = sql + "@telefono, @lugar_id, @Actividad_dedica, @fecha, @hora, @pista, @Coordenadas, @Coordenadas_Direccion, "
        sql = sql + "@Condiciones_de_Luz, @Altura_pies, @Velocidad_Indicada_Nudos, @Matricula, @Operador, @Tipo_Aeronave, "
        sql = sql + "@modelo_motor, @posicion_actividad_suceso, @Fase_Vuelo, "
        sql = sql + " @Cantidad_Aves_Observadas, @Cantidad_Aves_Golpeadas, @Identificacion_Fauna, "
        sql = sql + "@Tamanio_Fauna, @Advertencia_Piloto, @Tiempo_Fuera_Servicio_Aeronave, @Costo_Estimado_Reparacion_Substitucion_Aeronave, "
        sql = sql + "@Otros_Costos, @descripcion) "

        Using conn As New SqlConnection(cn)
            Dim cmd As New SqlCommand(sql, conn)
            Dim cmd_id As New SqlCommand(sql2, conn)
            cmd.Parameters.AddWithValue("@form_id", 6)
            cmd.Parameters.AddWithValue("@version", 2)
            cmd.Parameters.AddWithValue("@ambiente", ambiente)
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
            If ASPxComboBoxAeropuertos.SelectedItem Is Nothing Then
                cmd.Parameters.AddWithValue("@lugar_id", "")
            ElseIf ASPxComboBoxAeropuertos.SelectedItem.Value.Equals("") Then
                cmd.Parameters.AddWithValue("@lugar_id", "")
            Else
                cmd.Parameters.AddWithValue("@lugar_id", ASPxComboBoxAeropuertos.SelectedItem.Value)
            End If

            If ASPxRadioButtonListActividadDedica.SelectedItem Is Nothing Then
                cmd.Parameters.AddWithValue("@Actividad_dedica", Now)
            Else
                cmd.Parameters.AddWithValue("@Actividad_dedica", ASPxRadioButtonListActividadDedica.SelectedItem.Value)
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
            If ASPxTextBoxPista.Value Is Nothing Then
                cmd.Parameters.AddWithValue("@pista", "")
            Else
                cmd.Parameters.AddWithValue("@pista", ASPxTextBoxPista.Value)
            End If

            If ASPxTextBoxCoordenadas.Value Is Nothing Then
                cmd.Parameters.AddWithValue("@Coordenadas", "")
            Else
                cmd.Parameters.AddWithValue("@Coordenadas", ASPxTextBoxCoordenadas.Value)
            End If

            If ASPxRadioButtonCoordenadasNorteSur.SelectedItem Is Nothing Then
                cmd.Parameters.AddWithValue("@Coordenadas_Direccion", "")
            Else
                cmd.Parameters.AddWithValue("@Coordenadas_Direccion", ASPxRadioButtonCoordenadasNorteSur.SelectedItem.Value)
            End If

            If ASPxTextBoxModeloMotor.Value Is Nothing Then
                cmd.Parameters.AddWithValue("@modelo_motor", "")
            Else
                cmd.Parameters.AddWithValue("@modelo_motor", ASPxTextBoxModeloMotor.Value)
            End If

            If ASPxComboBoxCondicionesLuz.SelectedItem Is Nothing Then
                cmd.Parameters.AddWithValue("@Condiciones_de_Luz", "")
            Else
                cmd.Parameters.AddWithValue("@Condiciones_de_Luz", ASPxComboBoxCondicionesLuz.SelectedItem.Value)
            End If

            If ASPxTextBoxAlturaPies.Value Is Nothing Then
                cmd.Parameters.AddWithValue("@Altura_pies", "")
            Else
                cmd.Parameters.AddWithValue("@Altura_pies", ASPxTextBoxAlturaPies.Value)
            End If

            If ASPxTextBoxVelocidadIndicada.Value Is Nothing Then
                cmd.Parameters.AddWithValue("@Velocidad_Indicada_Nudos", "")
            Else
                cmd.Parameters.AddWithValue("@Velocidad_Indicada_Nudos", ASPxTextBoxVelocidadIndicada.Value)
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


            If ASPxTextBoxTipoAeronave.Value Is Nothing Then
                cmd.Parameters.AddWithValue("@Tipo_Aeronave", "")
            Else
                cmd.Parameters.AddWithValue("@Tipo_Aeronave", ASPxTextBoxTipoAeronave.Value)
            End If
            

            If ASPxTextBoxPosicionRuta.Value Is Nothing Then
                cmd.Parameters.AddWithValue("@posicion_actividad_suceso", "")
            Else
                cmd.Parameters.AddWithValue("@posicion_actividad_suceso", ASPxTextBoxPosicionRuta.Value)
            End If

            If ASPxRadioButtonListFaseVuelo.SelectedItem Is Nothing Then
                cmd.Parameters.AddWithValue("@Fase_Vuelo", "")
            Else
                cmd.Parameters.AddWithValue("@Fase_Vuelo", ASPxRadioButtonListFaseVuelo.SelectedItem.Value)
            End If

            'If ASPxCheckBoxListConsecuenciasVuelo.SelectedItem Is Nothing Then
            '    cmd.Parameters.AddWithValue("@Consecuencias_Vuelo", "")
            'Else
            '    cmd.Parameters.AddWithValue("@Consecuencias_Vuelo", ASPxCheckBoxListConsecuenciasVuelo.SelectedItem.Value)
            'End If

            'If ASPxCheckBoxListCondicionesCielo.SelectedItem Is Nothing Then
            '    cmd.Parameters.AddWithValue("@Condiciones_Cielo", "")
            'Else
            '    cmd.Parameters.AddWithValue("@Condiciones_Cielo", ASPxCheckBoxListCondicionesCielo.SelectedItem.Value)
            'End If

            'If ASPxCheckBoxListPrecipitacion.SelectedItem Is Nothing Then
            '    cmd.Parameters.AddWithValue("@Precipitacion", "")
            'Else
            '    cmd.Parameters.AddWithValue("@Precipitacion", ASPxCheckBoxListPrecipitacion.SelectedItem.Value)
            'End If

            If ASPxRadioButtonListCantidadAvesObservadas.SelectedItem Is Nothing Then
                cmd.Parameters.AddWithValue("@Cantidad_Aves_Observadas", "")
            Else
                cmd.Parameters.AddWithValue("@Cantidad_Aves_Observadas", ASPxRadioButtonListCantidadAvesObservadas.SelectedItem.Value)
            End If

            If ASPxRadioButtonListCantidadAvesGolpeadas.SelectedItem Is Nothing Then
                cmd.Parameters.AddWithValue("@Cantidad_Aves_Golpeadas", "")
            Else
                cmd.Parameters.AddWithValue("@Cantidad_Aves_Golpeadas", ASPxRadioButtonListCantidadAvesGolpeadas.SelectedItem.Value)
            End If

            If ASPxTextBoxIdentificacionfauna.Value Is Nothing Then
                cmd.Parameters.AddWithValue("@Identificacion_Fauna", "")
            Else
                cmd.Parameters.AddWithValue("@Identificacion_Fauna", ASPxTextBoxIdentificacionfauna.Value)
            End If

            If ASPxRadioButtonListTamanioAves.SelectedItem Is Nothing Then
                cmd.Parameters.AddWithValue("@Tamanio_Fauna", "")
            Else
                cmd.Parameters.AddWithValue("@Tamanio_Fauna", ASPxRadioButtonListTamanioAves.SelectedItem.Value)
            End If

            If ASPxRadioButtonListAdvertenciaPiloto.SelectedItem Is Nothing Then
                cmd.Parameters.AddWithValue("@Advertencia_Piloto", "")
            Else
                cmd.Parameters.AddWithValue("@Advertencia_Piloto", ASPxRadioButtonListAdvertenciaPiloto.SelectedItem.Value)
            End If

            If ASPxTextBoxTiempoFueraServicioAeronave.Value Is Nothing Then
                cmd.Parameters.AddWithValue("@Tiempo_Fuera_Servicio_Aeronave", "")
            Else
                cmd.Parameters.AddWithValue("@Tiempo_Fuera_Servicio_Aeronave", ASPxTextBoxTiempoFueraServicioAeronave.Value)
            End If


            If ASPxTextBoxCostoReparacion.Value Is Nothing Then
                cmd.Parameters.AddWithValue("@Costo_Estimado_Reparacion_Substitucion_Aeronave", "")
            Else
                cmd.Parameters.AddWithValue("@Costo_Estimado_Reparacion_Substitucion_Aeronave", ASPxTextBoxCostoReparacion.Value)
            End If

            If ASPxTextBoxOtrosCostos.Value Is Nothing Then
                cmd.Parameters.AddWithValue("@Otros_Costos", "")
            Else
                cmd.Parameters.AddWithValue("@Otros_Costos", ASPxTextBoxOtrosCostos.Value)
            End If

           
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

                    If ASPxCheckBoxListCondicionesCielo.SelectedItems Is Nothing Then

                    Else
                        For i As Integer = 0 To ASPxCheckBoxListCondicionesCielo.Items.Count - 1
                            If ASPxCheckBoxListCondicionesCielo.Items(i).Selected.Equals(True) Then
                                Ingreso_Condicion_Consecuencia_Precipitacion(id_formulario, ASPxCheckBoxListCondicionesCielo.Items(i).Value, "condicion")

                            Else

                            End If

                        Next

                    End If
                    If ASPxCheckBoxListConsecuenciasVuelo.SelectedItems Is Nothing Then

                    Else
                        For i As Integer = 0 To ASPxCheckBoxListConsecuenciasVuelo.Items.Count - 1
                            If ASPxCheckBoxListConsecuenciasVuelo.Items(i).Selected.Equals(True) Then
                                Ingreso_Condicion_Consecuencia_Precipitacion(id_formulario, ASPxCheckBoxListConsecuenciasVuelo.Items(i).Value, "consecuencia")
                            Else

                            End If

                        Next

                    End If
                    If ASPxCheckBoxListPrecipitacion.SelectedItems Is Nothing Then

                    Else
                        For i As Integer = 0 To ASPxCheckBoxListPrecipitacion.Items.Count - 1
                            If ASPxCheckBoxListPrecipitacion.Items(i).Selected.Equals(True) Then
                                Ingreso_Condicion_Consecuencia_Precipitacion(id_formulario, ASPxCheckBoxListPrecipitacion.Items(i).Value, "precipitacion")
                            Else
                            End If
                        Next
                    End If
                    If ASPxCheckBoxListPartesDaniadas.SelectedItems Is Nothing Then
                    Else

                        For i As Integer = 0 To ASPxCheckBoxListPartesDaniadas.Items.Count - 1
                            If ASPxCheckBoxListPartesDaniadas.Items(i).Selected.Equals(True) Then
                                Ingreso_Aeronave_Estado(id_formulario, ASPxCheckBoxListPartesDaniadas.Items(i).Text, ASPxCheckBoxListPartesDaniadas.Items(i).Value, False, "DAN")
                            Else
                            End If

                        Next
                    End If

                    If ASPxCheckBoxListPartesGolpeadas.SelectedItems Is Nothing Then
                    Else
                        For i As Integer = 0 To ASPxCheckBoxListPartesGolpeadas.Items.Count - 1
                            If ASPxCheckBoxListPartesGolpeadas.Items(i).Selected.Equals(True) Then
                                Ingreso_Aeronave_Estado(id_formulario, ASPxCheckBoxListPartesGolpeadas.Items(i).Text, False, ASPxCheckBoxListPartesGolpeadas.Items(i).Value, "GOL")
                            Else
                            End If

                        Next
                    End If

                    If id_formulario.Equals(0) Then
                        id_formulario = Convert.ToInt32(cmd_id.ExecuteScalar())
                    Else

                    End If
                    conn.Close()

                Catch ex As Exception
                    Console.WriteLine(ex.Message)
                    ScriptManager.RegisterStartupScript(Page, Page.GetType, "alertjs", "alert(' " & ex.Message & "');", True)
                End Try

            End If


        End Using

    End Sub

    Private Sub Ingreso_Condicion_Consecuencia_Precipitacion(id_formulario As Integer, descripcion As String, tabla As String)
        Dim numr As Integer
        '  Dim id_reporte As String = "SELECT TOP 1 * FROM Notificaciones_NSSP ORDER BY id DESC"
        Dim cn As String = "Data Source=win-sqlserv-02;Initial Catalog=SSP_BI;User ID=adminsql;Password=sistema*-!;"
        Dim sql_condicion As String = "insert into Condicion_Cielo(id_notificacion, condicion) "
        sql_condicion = sql_condicion + "values(@id_notificacion, @condicion)"
        Dim sql_consecuencia As String = "insert into Consecuencia_Vuelo(id_notificacion, consecuencia) "
        sql_consecuencia = sql_consecuencia + "values(@id_notificacion, @consecuencia)"
        Dim sql_precipitacion As String = "insert into Precipitacion(id_notificacion, precipitacion) "
        sql_precipitacion = sql_precipitacion + "values(@id_notificacion, @precipitacion)"

        Using conn As New SqlConnection(cn)
            Dim cmd_condicion As New SqlCommand(sql_condicion, conn)
            Dim cmd_consecuencia As New SqlCommand(sql_consecuencia, conn)
            Dim cmd_precipitacion As New SqlCommand(sql_precipitacion, conn)
            'Dim cmd_id As New SqlCommand(0, conn)
            ' necesito el id
            'cmd.Parameters.AddWithValue("@id_formulario", id_formulario)
            If tabla.Equals("condicion") Then
                cmd_condicion.Parameters.AddWithValue("@id_notificacion", id_formulario)
                cmd_condicion.Parameters.AddWithValue("@condicion", descripcion)
                Try
                    conn.Open()
                    numr = Convert.ToInt32(cmd_condicion.ExecuteScalar())
                    conn.Close()
                Catch ex As Exception
                    Console.WriteLine(ex.Message)
                    ScriptManager.RegisterStartupScript(Page, Page.GetType, "alertjs", "alert(' " & ex.Message & "');", True)
                End Try
            ElseIf tabla.Equals("consecuencia") Then
                cmd_consecuencia.Parameters.AddWithValue("@id_notificacion", id_formulario)
                cmd_consecuencia.Parameters.AddWithValue("@consecuencia", descripcion)
                Try
                    conn.Open()
                    numr = Convert.ToInt32(cmd_consecuencia.ExecuteScalar())
                    conn.Close()
                Catch ex As Exception
                    Console.WriteLine(ex.Message)
                    ScriptManager.RegisterStartupScript(Page, Page.GetType, "alertjs", "alert(' " & ex.Message & "');", True)
                End Try
            ElseIf tabla.Equals("precipitacion") Then
                cmd_precipitacion.Parameters.AddWithValue("@id_notificacion", id_formulario)
                cmd_precipitacion.Parameters.AddWithValue("@precipitacion", descripcion)
                Try
                    conn.Open()
                    numr = Convert.ToInt32(cmd_precipitacion.ExecuteScalar())
                    conn.Close()
                Catch ex As Exception
                    Console.WriteLine(ex.Message)
                    ScriptManager.RegisterStartupScript(Page, Page.GetType, "alertjs", "alert(' " & ex.Message & "');", True)
                End Try
            End If
           

        End Using



    End Sub


    Private Sub Ingreso_Aeronave_Estado(id_notificacion As Integer, nombre_item As String, daniado As Boolean, golpeado As Boolean, numero_pregunta As String)
        Dim numr As Integer
        '  Dim id_reporte As String = "SELECT TOP 1 * FROM Notificaciones_NSSP ORDER BY id DESC"
        Dim cn As String = "Data Source=win-sqlserv-02;Initial Catalog=SSP_BI;User ID=adminsql;Password=sistema*-!;"
        Dim sql As String = "insert into parte_daniada_golpeada(id_notificacion, nombre_item, estado_golpeado, estado_daniado, numero_pregunta) "
        sql = sql + "values(@id_notificacion, @nombre_item, @estado_golpeado, @estado_daniado, @numero_pregunta)"

        Using conn As New SqlConnection(cn)
            Dim cmd As New SqlCommand(sql, conn)
            Dim cmd_id As New SqlCommand(0, conn)
            ' necesito el id
            cmd.Parameters.AddWithValue("@id_notificacion", id_notificacion)
            cmd.Parameters.AddWithValue("@nombre_item", nombre_item)
            cmd.Parameters.AddWithValue("@estado_golpeado", golpeado)
            cmd.Parameters.AddWithValue("@estado_daniado", daniado)
            cmd.Parameters.AddWithValue("@numero_pregunta", numero_pregunta)

            Try
                conn.Open()
                numr = Convert.ToInt32(cmd.ExecuteScalar())
                conn.Close()

            Catch ex As Exception
                Console.WriteLine(ex.Message)
                ScriptManager.RegisterStartupScript(Page, Page.GetType, "alertjs", "alert(' " & ex.Message & "');", True)
            End Try

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