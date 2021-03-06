Imports System.Reflection
Imports System.Data.SqlClient
Imports DevExpress.Web.ASPxEditors
Imports DevExpress.Web


Public Class formulario_RIPO
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
        'ingresa formulario en bd
        Ingreso_Formulario()
        'se ingresa archivo
        If id_formulario = 0 Then
        ElseIf id_formulario.Equals(Nothing) Then
        Else
            guardararchivosbd.insertar_archivo(id_formulario, nombre_archivo, archivo)
        End If
        'se envia correo
        Enviar_Formulario_Correo()


    End Sub
    Private Sub Enviar_Formulario_Correo()
        Try
            CorreosEnvío.Enviar_Formulario_Correo_Lista_Archivo(Llenar_Correo_Formulario(),
                                                           "Formulario Reportes Accidentes e Incidentes Operacionales",
                                                           "RIPO",
                                                           ambiente,
                                                           nombre_archivo,
                                                           archivo)
        Catch ex As Exception
            CorreosEnvío.Enviar_Formulario_Correo_Lista(Llenar_Correo_Formulario(),
                                                           "Formulario Reportes Accidentes e Incidentes Operacionales",
                                                           "RIPO",
                                                           ambiente)
        End Try

        'Try
        '    CorreosEnvío.Enviar_Formulario_Correo_Lista_Archivo(Llenar_Correo_Formulario(),
        '                                                   "Formulario Reportes Accidentes e Incidentes Operacionales",
        '                                                   "RIPO",
        '                                                   ambiente,
        '                                                   nombre_archivo,
        '                                                   archivo)
        'Catch ex As Exception
        '    CorreosEnvío.Enviar_Formulario_Correo_Lista(Llenar_Correo_Formulario(),
        '                                                   "Formulario Reportes Accidentes e Incidentes Operacionales",
        '                                                   "RIPO",
        '                                                   ambiente)
        'End Try
       

    End Sub
    Private Function Llenar_Correo_Formulario() As ArrayList

       
        Dim datos_formulario As New ArrayList
        datos_formulario.Add("<b>Formulario RIPO</b>" + "</br>")
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

        If ASPxRadioButtonListActividadDedica.SelectedItem Is Nothing Then

        ElseIf ASPxRadioButtonListActividadDedica.SelectedItem.Value.Equals("Otro") Then

            datos_formulario.Add("<td><b></b></td>")
            datos_formulario.Add("<td><b>Otra actividad a la que se dedica: </b></td>")
            datos_formulario.Add("<td>" + ASPxTextBoxActividadOtro.Value + "</td>")


        Else
            datos_formulario.Add("<td><b>Actividad a la que se dedica: </b></td>")
            datos_formulario.Add("<td>" + ASPxRadioButtonListActividadDedica.SelectedItem.Value + "</td>")

        End If


        datos_formulario.Add("</tr>")
        datos_formulario.Add("</table>")


        'datos_formulario.Add("<div style=" + comilla + "text-align:left; width:80%; margin: 20px auto;" + comilla + ">")
        datos_formulario.Add("<h2>DETALLE INDICENTE/ACCIDENTE/PELIGROS/OPERACIONALES</h2>")
        'datos_formulario.Add("</div>")


        datos_formulario.Add("<table>")
        datos_formulario.Add("<tr>")
        datos_formulario.Add("<td><b>Ubicacion:</b></td>")

        If ASPxComboBoxAeropuertos.SelectedItem Is Nothing Then

            datos_formulario.Add("<td></br></td>")

        Else

            datos_formulario.Add("<td>" + ASPxComboBoxAeropuertos.SelectedItem.Text + "</br></td>")
            
        End If
        datos_formulario.Add("</tr>")

        datos_formulario.Add("<tr>")
        datos_formulario.Add("<td><b>Hora: </b></td>")

        If ASPxTimeEditHora.Value Is Nothing Then

            datos_formulario.Add("<td></td>")
        Else
            datos_formulario.Add("<td>" + ASPxTimeEditHora.Value.ToString().Substring(11) + " </td>")
            datos_formulario.Add("<br>")
        End If
        datos_formulario.Add("</tr>")
        datos_formulario.Add("<tr>")
        datos_formulario.Add("<td><b>Coordenadas:</b></td> ")
        datos_formulario.Add("<td>" + ASPxTextBoxCoordenadas.Value + "</td>")
        datos_formulario.Add("</tr>")
        datos_formulario.Add("<tr>")
        datos_formulario.Add("<td>Coordenadas Otro: </td>")
        datos_formulario.Add("<td>" + ASPxTextBoxCoordenadasOtros.Value + "</td>")
        datos_formulario.Add("</tr>")
        datos_formulario.Add("</table>")
        'datos_formulario.Add("<div style=" + comilla + "text-align:left; width:80%; margin: 20px auto;" + comilla + ">")
        datos_formulario.Add("<h2>TRIPULANTES</h2>")
        'datos_formulario.Add("</div>")
        datos_formulario.Add("<table>")
        datos_formulario.Add("<tr>")
        datos_formulario.Add("<td><b>Fatalidad:</b> </td>")
        datos_formulario.Add("<td>" + ASPxTextBoxFatalidadT.Value + "</td>")
        datos_formulario.Add("<td></td>")
        datos_formulario.Add("</tr>")
        datos_formulario.Add("<tr>")
        datos_formulario.Add("<td><b>Graves: </b></td>")
        datos_formulario.Add("<td>" + ASPxTextBoxGravesT.Value + "</td>")
        datos_formulario.Add("<td></td>")
        datos_formulario.Add("</tr>")
        datos_formulario.Add("<tr>")
        datos_formulario.Add("<td><b>Menores:</b> </td>")
        datos_formulario.Add("<td>" + ASPxTextBoxMenoresT.Value + "</td>")
        datos_formulario.Add("<td></td>")
        datos_formulario.Add("</tr>")
        datos_formulario.Add("<tr>")
        datos_formulario.Add("<td><b>Ninguno:</b> </td>")
        datos_formulario.Add("<td>" + ASPxTextBoxNingunoT.Value + "</td>")
        datos_formulario.Add("<td></td>")
        datos_formulario.Add("</tr>")
        datos_formulario.Add("</table>")
        'datos_formulario.Add("<div style= " + comilla + "text-align:left; width:80%; margin: 20px auto;" + comilla + ">")
        datos_formulario.Add("<h2>PASAJEROS</h2>")
        datos_formulario.Add("<table>")
        'datos_formulario.Add("</div>")
        datos_formulario.Add("<tr>")
        datos_formulario.Add("<td><b>Fatalidad:</b> </td>")
        datos_formulario.Add("<td>" + ASPxTextBoxFatalidadP.Value + "</td>")
        datos_formulario.Add("<td></td>")
        datos_formulario.Add("</tr>")
        datos_formulario.Add("<tr>")
        datos_formulario.Add("<td><b>Graves: </b></td>")
        datos_formulario.Add("<td>" + ASPxTextBoxGravesP.Value + "</td>")
        datos_formulario.Add("<td></td>")
        datos_formulario.Add("</tr>")
        datos_formulario.Add("<tr>")
        datos_formulario.Add("<td><b>Menores:</b> </td>")
        datos_formulario.Add("<td>" + ASPxTextBoxMenoresP.Value + "</td>")
        datos_formulario.Add("<td></td>")
        datos_formulario.Add("</tr>")
        datos_formulario.Add("<tr>")
        datos_formulario.Add("<td><b>Ninguno:</b> </td>")
        datos_formulario.Add("<td>" + ASPxTextBoxNingunoP.Value + "</td>")
        datos_formulario.Add("<td></td>")
        datos_formulario.Add("</tr>")
        datos_formulario.Add("<tr>")
        datos_formulario.Add("<td><b>Daños a Terceros:</b> </td>")
        datos_formulario.Add("<td>" + ASPxMemoDanosTerceros.Value + "</td>")
        datos_formulario.Add("<td></td>")
        datos_formulario.Add("</tr>")
        datos_formulario.Add("</table>")
        'datos_formulario.Add("<div style=" + comilla + "text-align:left; width:80%; margin: 20px auto;" + comilla + ">")
        datos_formulario.Add("<h2>DAÑOS A LA AERONAVE</h2>")
        'datos_formulario.Add("</div>")
        datos_formulario.Add("<table>")
        datos_formulario.Add("<tr>")
        datos_formulario.Add("<td><b>Daños a la Aeronave:</b> </td>")
        If ASPxRadioButtonListDaniosAeronave.SelectedItem Is Nothing Then
            datos_formulario.Add("<td><b></b></td>")
        Else
            datos_formulario.Add("<td>" + ASPxRadioButtonListDaniosAeronave.SelectedItem.Value + " </td>")
        End If
        datos_formulario.Add("</tr>")
        datos_formulario.Add("<tr>")
        datos_formulario.Add("<td><b>Condiciones MET: </b> </td>")
        If ASPxComboBoxCondicionesMET.SelectedItem Is Nothing Then
            datos_formulario.Add("<td></td>")
        Else
            datos_formulario.Add("<td>" + ASPxComboBoxCondicionesMET.SelectedItem.Value + "</td>")
        End If
        datos_formulario.Add("</tr>")
        datos_formulario.Add("<tr>")
        datos_formulario.Add("<td><b>Condiciones de Luz: </b></td>")
        If ASPxComboBoxCondicionesLuz.SelectedItem Is Nothing Then
            datos_formulario.Add("<td></td>")

        Else
            datos_formulario.Add("<td>" + ASPxComboBoxCondicionesLuz.SelectedItem.Value + " </td>")

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
        datos_formulario.Add("<td>" + ASPxTextBoxTipoAeronave.Value + "</td>")
        datos_formulario.Add("</tr>")

        datos_formulario.Add("<tr>")
        datos_formulario.Add("<td><b>Reglas de Vuelo:</b> </td>")
        If ASPxComboBoxReglasVuelo.SelectedItem Is Nothing Then
            datos_formulario.Add("<td>" + "" + "</td>")
        Else
            datos_formulario.Add("<td>" + ASPxComboBoxReglasVuelo.SelectedItem.Value + "</td>")
        End If
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
        datos_formulario.Add("<td><b>Fase Vuelo:</b> </td>")
        If ASPxRadioButtonListFaseVuelo.SelectedItem Is Nothing Then
            datos_formulario.Add("<td>" + "" + "</td>")
        Else
            datos_formulario.Add("<td>" + ASPxRadioButtonListFaseVuelo.SelectedItem.Text + "</td>")
        End If

        datos_formulario.Add("<td><b>Fase Vuelo Otro:</b> </td>")
        If ASPxTextBoxFaseVueloOtro.Value Is Nothing Then
            datos_formulario.Add("<td>" + "" + "</td>")
        Else
            datos_formulario.Add("<td>" + ASPxTextBoxFaseVueloOtro.Value + "</td>")
        End If
        datos_formulario.Add("</tr>")

        datos_formulario.Add("<tr>")
        datos_formulario.Add("<td><b>Altitud Nivel Vuelo:</b> </td>")
        If ASPxTextBoxAltitudNivelVuelo.Value Is Nothing Then
            datos_formulario.Add("<td>" + "" + "</td>")
        Else
            datos_formulario.Add("<td>" + ASPxTextBoxAltitudNivelVuelo.Value + "</td>")
        End If

        datos_formulario.Add("<td><b>Tipo Operación:</b> </td>")
        If ASPxComboBoxTipoOperacion.SelectedItem Is Nothing Then
            datos_formulario.Add("<td>" + "" + "</td>")
        Else
            datos_formulario.Add("<td>" + ASPxComboBoxTipoOperacion.SelectedItem.Value + "</td>")
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
        sql = sql + "telefono, lugar_id, Actividad_dedica, fecha, hora, Coordenadas, Coordenadas_Otro, "
        sql = sql + "Fatalidad_T, Graves_T, Menores_T, Ninguno_T, Fatalidad_P, Menores_P, "
        sql = sql + "Ninguno_P, Dano_Aeronave, Danos_Terceros_Esp, Condiciones_Meteorologicas, "
        sql = sql + "Condiciones_de_luz,  Matricula, Operador, Tipo_Aeronave, "
        sql = sql + "Aerodromo_Salida, Aerodromo_Destino, Nivel_vuelo, Fase_Vuelo, Fase_Vuelo_Otro,  "
        sql = sql + "Tipo_de_Operacion, Categoria_Vuelo,  descripcion, ambiente) values"
        sql = sql + "(@form_id, @version, @fecha_creacion, @nombre, @email, @telefono, "
        sql = sql + "@lugar_id , @Actividad_dedica, @fecha, @hora, @Coordenadas, @Coordenadas_Otro, "
        sql = sql + "@Fatalidad_T, @Graves_T, @Menores_T, @Ninguno_T, @Fatalidad_P, @Menores_P, "
        sql = sql + "@Ninguno_P, @Dano_Aeronave, @Danos_Terceros_Esp,"
        sql = sql + "@Condiciones_Meteorologicas, @Condiciones_de_luz,  "
        sql = sql + "@Matricula, @Operador, @Tipo_Aeronave,"
        sql = sql + "@Aerodromo_Salida, @Aerodromo_Destino, @Nivel_vuelo, @Fase_Vuelo, @Fase_Vuelo_Otro,"
        sql = sql + " @Tipo_de_Operacion, @Categoria_Vuelo,  @descripcion, @ambiente)"


        Using conn As New SqlConnection(cn)
            Dim cmd As New SqlCommand(sql, conn)
            Dim cmd_id As New SqlCommand(sql2, conn)
            cmd.Parameters.AddWithValue("@form_id", 1)
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

            If ASPxRadioButtonListActividadDedica.SelectedItem Is Nothing Then
                cmd.Parameters.AddWithValue("@Actividad_dedica", "")
            ElseIf ASPxRadioButtonListActividadDedica.SelectedItem.Value.Equals("") Then
                cmd.Parameters.AddWithValue("@Actividad_dedica", "")
            Else
                cmd.Parameters.AddWithValue("@Actividad_dedica", ASPxRadioButtonListActividadDedica.SelectedItem.Value)
            End If

            If ASPxTextBoxCoordenadas.Value Is Nothing Then
                cmd.Parameters.AddWithValue("@Coordenadas", "")
            
            Else
                cmd.Parameters.AddWithValue("@Coordenadas", ASPxTextBoxCoordenadas.Value)
            End If

            If ASPxTextBoxCoordenadasOtros.Value Is Nothing Then
                cmd.Parameters.AddWithValue("@Coordenadas_Otro", "")

            Else
                cmd.Parameters.AddWithValue("@Coordenadas_Otro", ASPxTextBoxCoordenadasOtros.Value)
            End If

            If ASPxTextBoxFatalidadT.Value Is Nothing Then
                cmd.Parameters.AddWithValue("@Fatalidad_T", "")
            Else
                cmd.Parameters.AddWithValue("@Fatalidad_T", ASPxTextBoxFatalidadT.Value)
            End If

            If ASPxTextBoxGravesT.Value Is Nothing Then
                cmd.Parameters.AddWithValue("@Graves_T", "")
            Else
                cmd.Parameters.AddWithValue("@Graves_T", ASPxTextBoxGravesT.Value)
            End If
            If ASPxTextBoxMenoresT.Value Is Nothing Then
                cmd.Parameters.AddWithValue("@Menores_T", "")
            Else
                cmd.Parameters.AddWithValue("@Menores_T", ASPxTextBoxMenoresT.Value)
            End If

            If ASPxTextBoxNingunoT.Value Is Nothing Then
                cmd.Parameters.AddWithValue("@Ninguno_T", "")
            Else
                cmd.Parameters.AddWithValue("@Ninguno_T", ASPxTextBoxNingunoT.Value)
            End If

            If ASPxTextBoxFatalidadP.Value Is Nothing Then
                cmd.Parameters.AddWithValue("@Fatalidad_P", "")
            Else
                cmd.Parameters.AddWithValue("@Fatalidad_P", ASPxTextBoxFatalidadP.Value)
            End If

            If ASPxTextBoxGravesP.Value Is Nothing Then
                cmd.Parameters.AddWithValue("@Graves_P", "")
            Else
                cmd.Parameters.AddWithValue("@Graves_P", ASPxTextBoxGravesP.Value)
            End If

            If ASPxTextBoxMenoresP.Value Is Nothing Then
                cmd.Parameters.AddWithValue("@Menores_P", "")
            Else
                cmd.Parameters.AddWithValue("@Menores_P", ASPxTextBoxMenoresP.Value)
            End If


            If ASPxTextBoxNingunoP.Value Is Nothing Then
                cmd.Parameters.AddWithValue("@Ninguno_P", "")
            Else
                cmd.Parameters.AddWithValue("@Ninguno_P", ASPxTextBoxNingunoP.Value)
            End If

            If ASPxMemoDanosTerceros.Value Is Nothing Then
                cmd.Parameters.AddWithValue("@Danos_Terceros_Esp", "")
            Else
                cmd.Parameters.AddWithValue("@Danos_Terceros_Esp", ASPxMemoDanosTerceros.Value)
            End If

            If ASPxRadioButtonListDaniosAeronave.SelectedItem Is Nothing Then
                cmd.Parameters.AddWithValue("@Dano_Aeronave", "")
            ElseIf ASPxRadioButtonListDaniosAeronave.SelectedItem.Value.Equals("") Then
                cmd.Parameters.AddWithValue("@Dano_Aeronave", "")
            Else
                cmd.Parameters.AddWithValue("@Dano_Aeronave", ASPxRadioButtonListDaniosAeronave.SelectedItem.Value)
            End If

            If ASPxComboBoxCondicionesMET.SelectedItem Is Nothing Then
                cmd.Parameters.AddWithValue("@Condiciones_Meteorologicas", "")
            ElseIf ASPxComboBoxCondicionesMET.SelectedItem.Value.Equals("") Then
                cmd.Parameters.AddWithValue("@Condiciones_Meteorologicas", "")
            Else
                cmd.Parameters.AddWithValue("@Condiciones_Meteorologicas", ASPxComboBoxCondicionesMET.SelectedItem.Value)
            End If

            If ASPxComboBoxCondicionesLuz.SelectedItem Is Nothing Then
                cmd.Parameters.AddWithValue("@Condiciones_de_luz", "")
            ElseIf ASPxComboBoxCondicionesLuz.SelectedItem.Value.Equals("") Then
                cmd.Parameters.AddWithValue("@Condiciones_de_luz", "")
            Else
                cmd.Parameters.AddWithValue("@Condiciones_de_luz", ASPxComboBoxCondicionesLuz.SelectedItem.Value)
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
            If ASPxTextBoxAltitudNivelVuelo.Value Is Nothing Then
                cmd.Parameters.AddWithValue("@Nivel_vuelo", "")
            Else
                cmd.Parameters.AddWithValue("@Nivel_vuelo", ASPxTextBoxAltitudNivelVuelo.Value)
            End If
            If ASPxComboBoxTipoOperacion.SelectedItem Is Nothing Then
                cmd.Parameters.AddWithValue("@Tipo_de_Operacion", "")
            ElseIf ASPxComboBoxTipoOperacion.SelectedItem.Value.Equals("") Then
                cmd.Parameters.AddWithValue("@Tipo_de_Operacion", "")
            Else
                cmd.Parameters.AddWithValue("@Tipo_de_Operacion", ASPxComboBoxTipoOperacion.SelectedItem.Value)
            End If
            If ASPxRadioButtonListFaseVuelo.SelectedItem Is Nothing Then
                cmd.Parameters.AddWithValue("@Fase_Vuelo", "")
            ElseIf ASPxRadioButtonListFaseVuelo.SelectedItem.Value.Equals("") Then
                cmd.Parameters.AddWithValue("@Fase_Vuelo", "")
            Else
                cmd.Parameters.AddWithValue("@Fase_Vuelo", ASPxRadioButtonListFaseVuelo.SelectedItem.Value)
            End If
            If ASPxTextBoxFaseVueloOtro.Value Is Nothing Then
                cmd.Parameters.AddWithValue("@Fase_Vuelo_Otro", "")

            Else
                cmd.Parameters.AddWithValue("@Fase_Vuelo_Otro", ASPxTextBoxFaseVueloOtro.Value)
            End If

           
            If ASPxComboBoxReglasVuelo.SelectedItem Is Nothing Then
                cmd.Parameters.AddWithValue("@Categoria_Vuelo", "")
            ElseIf ASPxComboBoxReglasVuelo.SelectedItem.Value.Equals("") Then
                cmd.Parameters.AddWithValue("@Categoria_Vuelo", "")
            Else
                cmd.Parameters.AddWithValue("@Categoria_Vuelo", ASPxComboBoxReglasVuelo.SelectedItem.Value)
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
                    conn.Close()

                Catch ex As Exception
                    Console.WriteLine(ex.Message)
                    ScriptManager.RegisterStartupScript(Page, Page.GetType, "alertjs", "alert(' " & ex.Message & "');", True)
                End Try

            End If

           
        End Using

    End Sub

    Protected Sub ASPxButtonRegresar_Click(sender As Object, e As EventArgs)  Handles ASPxButtonRegresar.Click
        Response.Redirect("~/default.aspx")

    End Sub

    Protected Sub ASPxPopupControl2_Unload(sender As Object, e As EventArgs)
       

    End Sub
    Protected Sub RegisterUpdatePanel(ByVal panel As UpdatePanel)
        Dim sType = GetType(ScriptManager)
        Dim mInfo = sType.GetMethod("System.Web.UI.IScriptManagerInternal.RegisterUpdatePanel", BindingFlags.NonPublic Or BindingFlags.Instance)
        If mInfo IsNot Nothing Then
            mInfo.Invoke(ScriptManager.GetCurrent(Page), New Object() {panel})
        End If
    End Sub

    Protected Sub UpdatePanel2_Unload(sender As Object, e As EventArgs) 
    End Sub

    Protected Sub ScriptManager1_Unload(sender As Object, e As EventArgs) 'Handles ScriptManager1.Unload

    End Sub

   
    Protected Sub ASPxUploadControl1_FileUploadComplete(sender As Object, e As DevExpress.Web.FileUploadCompleteEventArgs) Handles ASPxUploadControl1.FileUploadComplete
        nombre_archivo = e.UploadedFile.FileName
        archivo = e.UploadedFile.FileBytes

    End Sub

    Protected Sub ASPxUploadControl1_FilesUploadComplete(sender As Object, e As FilesUploadCompleteEventArgs) Handles ASPxUploadControl1.FilesUploadComplete
        
    End Sub
End Class