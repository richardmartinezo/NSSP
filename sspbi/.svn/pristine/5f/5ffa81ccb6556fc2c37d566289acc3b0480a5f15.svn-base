Imports System.Data.SqlClient
Imports System.Reflection

Public Class reporte_accidentes_incidentes
    Inherits System.Web.UI.Page
    Private CorreosEnvío As New CorreosEnvío
    Private guardararchivosbd As New Guardar_Archivos_BD
    Private id_formulario As Integer

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub


    Protected Sub ASPxButtonEnviar_Click(sender As Object, e As EventArgs) Handles ASPxButtonEnviar.Click, ASPxUploadControlArchivo.FileUploadComplete
        ASPxPopupControl2.ShowOnPageLoad = True
        ScriptManager.RegisterClientScriptBlock(Me, Me.Page.GetType(), "dxsi_HidePopup", "ASPxPopupControl2.Show();", True)
        Ingreso_Formulario()
        Enviar_Formulario_Correo()

    End Sub
    Private Sub Enviar_Formulario_Correo()
        CorreosEnvío.Enviar_Formulario_Correo_Lista(Llenar_Correo_Formulario(), "Formulario Reportes Accidentes e Incidentes Operacionales")
    End Sub
    Private Function Llenar_Correo_Formulario() As ArrayList
        Dim datos_formulario As New ArrayList
        datos_formulario.Add("ID: " + id_formulario.ToString() + " " + "<br>")
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
        If RadioButtonListLatitudNorteSur.SelectedItem Is Nothing Then
            datos_formulario.Add("Latitud: " + ASPxTextBoxLatitud.Value + " " + "<br>")
            datos_formulario.Add("<br>")
        Else
            datos_formulario.Add("Latitud: " + ASPxTextBoxLatitud.Value + " " + RadioButtonListLatitudNorteSur.SelectedItem.Value + "<br>")
            datos_formulario.Add("<br>")
        End If
        If RadioButtonListLongitudEsteOeste.SelectedItem Is Nothing Then
            datos_formulario.Add("Longitud: " + ASPxTextBoxLongitud.Value + " " + "<br>")
            datos_formulario.Add("<br>")
        Else
            datos_formulario.Add("Longitud: " + ASPxTextBoxLongitud.Value + " " + RadioButtonListLongitudEsteOeste.SelectedItem.Value + "<br>")
            datos_formulario.Add("<br>")
        End If
        If ASPxDateEditFechaIncidente.Value Is Nothing Then
            datos_formulario.Add("Fecha: " + " " + "<br>")
            datos_formulario.Add("<br>")
        Else
            datos_formulario.Add("Fecha: " + ASPxDateEditFechaIncidente.Value.ToString() + " " + "<br>")
            datos_formulario.Add("<br>")
        End If
        If ASPxTimeEditHora.Value Is Nothing Then
            datos_formulario.Add("Hora: " + "" + " " + "<br>")
            datos_formulario.Add("<br>")
        Else
            datos_formulario.Add("Hora: " + ASPxTimeEditHora.Value.ToString().Substring(11) + " " + "<br>")
            datos_formulario.Add("<br>")

        End If
        datos_formulario.Add("Tripulantes: <br>")
        datos_formulario.Add("<br>")
        datos_formulario.Add("Fatalidad: " + ASPxTextBoxFatalidadT.Value + " " + "<br>")
        datos_formulario.Add("<br>")
        datos_formulario.Add("Graves: " + ASPxTextBoxGravesT.Value + " " + "<br>")
        datos_formulario.Add("<br>")
        datos_formulario.Add("Menores: " + ASPxTextBoxMenoresT.Value + " " + "<br>")
        datos_formulario.Add("<br>")
        datos_formulario.Add("Ninguno: " + ASPxTextBoxNingunoT.Value + " " + "<br>")
        datos_formulario.Add("<br>")
        datos_formulario.Add("Pasajeros: <br>")
        datos_formulario.Add("<br>")
        datos_formulario.Add("Fatalidad: " + ASPxTextBoxFatalidadP.Value + " " + "<br>")
        datos_formulario.Add("<br>")
        datos_formulario.Add("Menores: " + ASPxTextBoxMenoresP.Value + " " + "<br>")
        datos_formulario.Add("<br>")
        datos_formulario.Add("Ninguno: " + ASPxTextBoxNingunoP.Value + " " + "<br>")
        datos_formulario.Add("<br>")
        If RadioButtonListDanoAeronave.SelectedItem Is Nothing Then
            datos_formulario.Add("Daño Aeronave: " + " " + "<br>")
            datos_formulario.Add("<br>")
        Else
            datos_formulario.Add("Daño Aeronave: " + RadioButtonListDanoAeronave.SelectedItem.Value + " " + "<br>")
            datos_formulario.Add("<br>")
        End If
        datos_formulario.Add("Daño a Terceros: " + ASPxMemoTercerosEsp.Value + " " + "<br>")
        datos_formulario.Add("<br>")
        If RadioButtonCondicionesMet.SelectedItem Is Nothing Then
            datos_formulario.Add("Condiciones Meteorológicas: " + " " + "<br>")
            datos_formulario.Add("<br>")
        Else
            datos_formulario.Add("Condiciones Meteorológicas: " + RadioButtonCondicionesMet.SelectedItem.Value + " " + "<br>")
            datos_formulario.Add("<br>")

        End If
        If RadioButtonCondicionesLuz.SelectedItem Is Nothing Then
            datos_formulario.Add("Condiciones De Luz: " + " " + "<br>")
            datos_formulario.Add("<br>")
        Else
            datos_formulario.Add("Condiciones De Luz: " + RadioButtonCondicionesLuz.SelectedItem.Value + " " + "<br>")
            datos_formulario.Add("<br>")
        End If
        datos_formulario.Add("<br>")
        datos_formulario.Add("Identificación de la Aeronave: <br>")
        datos_formulario.Add("Tipo / Modelo: " + ASPxTextBoxTipoModelo.Value + " " + "<br>")
        datos_formulario.Add("<br>")
        datos_formulario.Add("Operador: " + ASPxTextBoxOperador.Value + " " + "<br>")
        datos_formulario.Add("<br>")
        datos_formulario.Add("Matrícula: " + ASPxTextBoxMatricula.Value + " " + "<br>")
        datos_formulario.Add("<br>")
        datos_formulario.Add("Aerodromo Salida: " + ASPxTextBoxAerodromoSalida.Value + " " + "<br>")
        datos_formulario.Add("<br>")
        datos_formulario.Add("Aerodromo Destino: " + ASPxTextBoxAerodromoDestino.Value + " " + "<br>")
        datos_formulario.Add("<br>")
        datos_formulario.Add("Fase Vuelo: " + ASPxTextBoxFaseVuelo.Value + " " + "<br>")
        datos_formulario.Add("<br>")
        datos_formulario.Add("Num Vuelo: " + ASPxTextBoxNumVuelo.Value + " " + "<br>")
        datos_formulario.Add("<br>")
        If RadioButtonCategoriaVuelo.SelectedItem Is Nothing Then
            datos_formulario.Add("Categoría Vuelo: " + " " + "<br>")
            datos_formulario.Add("<br>")
        Else
            datos_formulario.Add("Categoría Vuelo: " + RadioButtonCategoriaVuelo.SelectedItem.Value + " " + "<br>")
            datos_formulario.Add("<br>")
        End If
        If RadioButtonTipoOperacion.SelectedItem Is Nothing Then
            datos_formulario.Add("Tipo Operación: " + " " + "<br>")
            datos_formulario.Add("<br>")
        Else
            datos_formulario.Add("Tipo Operación: " + RadioButtonTipoOperacion.SelectedItem.Value + " " + "<br>")
            datos_formulario.Add("<br>")
        End If
        datos_formulario.Add("Tipo Operación Otra: " + ASPxTextBoxOtros.Value + " " + "<br>")
        datos_formulario.Add("<br>")

        Return datos_formulario
    End Function

    Private Sub Ingreso_Formulario()

        Dim numr As Integer
        Dim sql2 As String = "SELECT TOP 1 *  FROM [SSP_BI].[dbo].[Reportes_SSP_Master_test] ORDER BY id DESC "
        Dim cn As String = "Data Source=win-sqlserv-02;Initial Catalog=SSP_BI;User ID=adminsql;Password=sistema*-!;"
        Dim sql As String = "insert into Reportes_SSP_Master_Test(form_id, fecha_creacion, nombre, email, "
        sql = sql + "telefono, lugar_id, fecha, hora, longitud, latitud, longitud_este_oeste, latitud_norte_sur, Fatalidad_T, Graves_T, Menores_T, Ninguno_T, Fatalidad_P, Menores_P,"
        sql = sql + "Ninguno_P, Dano_Aeronave, Danos_Terceros_Esp, Condiciones_Meteorologicas, Condiciones_de_luz, Tipo_Modelo, Matricula, Operador, "
        sql = sql + "Aerodromo_Salida, Aerodromo_Destino, Fase_Vuelo, Duracion_vuelo, Tipo_de_Operacion, Categoria_Vuelo, numero_vuelo, descripcion) values"
        sql = sql + "(@form_id, @fecha_creacion, @nombre, @email, @telefono ,@lugar_id , @fecha, @hora, @longitud, @latitud, @longitud_este_oeste, @latitud_norte_sur, "
        sql = sql + "@Fatalidad_T, @Graves_T, @Menores_T, @Ninguno_T, @Fatalidad_P, @Menores_P, "
        sql = sql + "@Ninguno_P, @Dano_Aeronave, @Danos_Terceros_Esp, @Condiciones_Meteorologicas, @Condiciones_de_luz, @Tipo_Modelo, @Matricula, @Operador, "
        sql = sql + "@Aerodromo_Salida, @Aerodromo_Destino, @Fase_Vuelo, @Duracion_vuelo, @Tipo_de_Operacion, @Categoria_Vuelo, @numero_vuelo, @descripcion)"


        Using conn As New SqlConnection(cn)
            Dim cmd As New SqlCommand(sql, conn)
            Dim cmd_id As New SqlCommand(sql2, conn)
            cmd.Parameters.AddWithValue("@form_id", 6)
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

            'validar el vacio
            If ASPxComboBoxAeropuertos.SelectedItem.Value Is Nothing Then
                cmd.Parameters.AddWithValue("@lugar_id", "")
            ElseIf ASPxComboBoxAeropuertos.SelectedItem.Value.Equals("") Then
                cmd.Parameters.AddWithValue("@lugar_id", "")
            Else
                cmd.Parameters.AddWithValue("@lugar_id", ASPxComboBoxAeropuertos.SelectedItem.Value)
            End If

            If (ASPxDateEditFechaIncidente.Value Is Nothing) Then
                cmd.Parameters.AddWithValue("@fecha", Now)
            Else
                cmd.Parameters.AddWithValue("@fecha", ASPxDateEditFechaIncidente.Value)
            End If

            If ASPxTimeEditHora.Value Is Nothing Then
                cmd.Parameters.AddWithValue("@hora", "")
            ElseIf ASPxTimeEditHora.Value.Equals("") Then
                cmd.Parameters.AddWithValue("@hora", "")
            Else
                cmd.Parameters.AddWithValue("@hora", ASPxTimeEditHora.Value.ToString().Substring(11))

            End If

            If ASPxTextBoxLongitud.Value Is Nothing Then
                cmd.Parameters.AddWithValue("@longitud", "")
            Else
                cmd.Parameters.AddWithValue("@longitud", ASPxTextBoxLongitud.Value)
            End If

            If ASPxTextBoxLatitud.Value Is Nothing Then
                cmd.Parameters.AddWithValue("@latitud", "")
            Else
                cmd.Parameters.AddWithValue("@latitud", ASPxTextBoxLatitud.Value)
            End If

            '@longitud_este_oeste, @latitud_norte_sur, 
            'ingreso de radio button list
            If RadioButtonListLongitudEsteOeste.SelectedItem Is Nothing Then
                cmd.Parameters.AddWithValue("@longitud_este_oeste", "")
            Else
                cmd.Parameters.AddWithValue("@longitud_este_oeste", RadioButtonListLongitudEsteOeste.SelectedItem.Value)
            End If

            If RadioButtonListLatitudNorteSur.SelectedItem Is Nothing Then
                cmd.Parameters.AddWithValue("@latitud_norte_sur", "")
            Else
                cmd.Parameters.AddWithValue("@latitud_norte_sur", RadioButtonListLatitudNorteSur.SelectedItem.Value)
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

            If RadioButtonListDanoAeronave.SelectedItem Is Nothing Then
                cmd.Parameters.AddWithValue("@Dano_Aeronave", "")
            Else
                cmd.Parameters.AddWithValue("@Dano_Aeronave", RadioButtonListDanoAeronave.SelectedItem.Value)
            End If

            If ASPxMemoTercerosEsp.Value Is Nothing Then
                cmd.Parameters.AddWithValue("@Danos_Terceros_Esp", "")
            Else
                cmd.Parameters.AddWithValue("@Danos_Terceros_Esp", ASPxMemoTercerosEsp.Value)
            End If

            If RadioButtonCondicionesMet.SelectedItem Is Nothing Then
                cmd.Parameters.AddWithValue("@Condiciones_Meteorologicas", "")
            Else
                cmd.Parameters.AddWithValue("@Condiciones_Meteorologicas", RadioButtonCondicionesMet.SelectedItem.Value)
            End If

            If RadioButtonCondicionesLuz.SelectedItem Is Nothing Then
                cmd.Parameters.AddWithValue("@Condiciones_de_luz", "")
            Else
                cmd.Parameters.AddWithValue("@Condiciones_de_luz", RadioButtonCondicionesLuz.SelectedItem.Value)
            End If

            If ASPxTextBoxTipoModelo.Value Is Nothing Then
                cmd.Parameters.AddWithValue("@Tipo_Modelo", "")
            Else
                cmd.Parameters.AddWithValue("@Tipo_Modelo", ASPxTextBoxTipoModelo.Value)
            End If

            If ASPxTextBoxMatricula.Value Is Nothing Then
                cmd.Parameters.AddWithValue("@Matricula", "")
            Else
                cmd.Parameters.AddWithValue("@Matricula", ASPxTextBoxMatricula.Value)
            End If

            If ASPxTextBoxOperador.Value Is Nothing Then
                cmd.Parameters.AddWithValue("@Operador", "")
            Else
                cmd.Parameters.AddWithValue("@Operador", ASPxTextBoxOperador.Value)
            End If
            If ASPxTextBoxAerodromoSalida.Value Is Nothing Then
                cmd.Parameters.AddWithValue("@Aerodromo_Salida", "")
            Else
                cmd.Parameters.AddWithValue("@Aerodromo_Salida", ASPxTextBoxAerodromoSalida.Value)
            End If
            If ASPxTextBoxAerodromoDestino.Value Is Nothing Then
                cmd.Parameters.AddWithValue("@Aerodromo_Destino", "")
            Else
                cmd.Parameters.AddWithValue("@Aerodromo_Destino", ASPxTextBoxAerodromoDestino.Value)
            End If
            If ASPxTextBoxFaseVuelo.Value Is Nothing Then
                cmd.Parameters.AddWithValue("@Fase_Vuelo", "")
            Else
                cmd.Parameters.AddWithValue("@Fase_Vuelo", ASPxTextBoxFaseVuelo.Value)
            End If
            If ASPxTextBoxNumVuelo.Value Is Nothing Then
                cmd.Parameters.AddWithValue("@numero_vuelo", "")
            Else
                cmd.Parameters.AddWithValue("@numero_vuelo", ASPxTextBoxNumVuelo.Value)
            End If
            If ASPxTextBoxDuracionVuelo.Value Is Nothing Then
                cmd.Parameters.AddWithValue("@Duracion_Vuelo", "")
            Else
                cmd.Parameters.AddWithValue("@Duracion_Vuelo", ASPxTextBoxDuracionVuelo.Value)
            End If
            If RadioButtonTipoOperacion.SelectedItem Is Nothing Then
                cmd.Parameters.AddWithValue("@Tipo_de_Operacion", "")
            Else
                cmd.Parameters.AddWithValue("@Tipo_de_Operacion", RadioButtonTipoOperacion.SelectedItem.Value)
            End If
            If RadioButtonCategoriaVuelo.SelectedItem Is Nothing Then
                cmd.Parameters.AddWithValue("@Categoria_Vuelo", "")
            Else
                cmd.Parameters.AddWithValue("@Categoria_Vuelo", RadioButtonCategoriaVuelo.SelectedItem.Value)
            End If

            If ASPxMemoDescripcion.Value Is Nothing Then
                cmd.Parameters.AddWithValue("@descripcion", "")
            Else
                cmd.Parameters.AddWithValue("@descripcion", ASPxMemoDescripcion.Value)
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

    Protected Sub ASPxButton1_Click(sender As Object, e As EventArgs) Handles ASPxButton1.Click
        Response.Redirect("~/default.aspx")
    End Sub

    Protected Sub UpdatePanel2_Unload(sender As Object, e As EventArgs) 'Handles UpdatePanel2.Unload
        ' RegisterUpdatePanel(DirectCast(sender, UpdatePanel))
    End Sub

    Protected Sub RegisterUpdatePanel(ByVal panel As UpdatePanel)
        Dim sType = GetType(ScriptManager)
        Dim mInfo = sType.GetMethod("System.Web.UI.IScriptManagerInternal.RegisterUpdatePanel", BindingFlags.NonPublic Or BindingFlags.Instance)
        If mInfo IsNot Nothing Then
            mInfo.Invoke(ScriptManager.GetCurrent(Page), New Object() {panel})
        End If
    End Sub

    Protected Sub ASPxUploadControlArchivo_FileUploadComplete(sender As Object, e As DevExpress.Web.FileUploadCompleteEventArgs) Handles ASPxUploadControlArchivo.FileUploadComplete
        If id_formulario = Nothing Then
        Else
            guardararchivosbd.insertar_archivo(id_formulario, e.UploadedFile.FileName, e.UploadedFile.FileBytes)
        End If
    End Sub

    Protected Sub ASPxPopupControl2_Unload(sender As Object, e As EventArgs) ' Handles ASPxPopupControl2.Unload
        ' RegisterUpdatePanel(DirectCast(sender, UpdatePanel))
    End Sub
End Class