Imports System.Data.SqlClient
Imports System.Reflection
Imports System.Net.Mail
Imports Microsoft.Reporting.WebForms

Public Class reporte_voluntario
    Inherits System.Web.UI.Page
    Private CorreosEnvío As New CorreosEnvío
    Private guardarArchivosbd As New Guardar_Archivos_BD
    Private id_formulario As Integer
    Private repeticiones As Double
    Private ambiente As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    End Sub


    Protected Sub ASPxButtonEnviar_Click(sender As Object, e As EventArgs) Handles ASPxButtonEnviar.Click, ASPxUploadControlArchivo.FileUploadComplete

        'ASPxButtonEnviar.Enabled = False
       
        If HiddenFieldValor.Get("valor").Equals("vacio") Then
            '   ASPxButtonEnviar.Visible = True
        Else
            ASPxPopupControl2.ShowOnPageLoad = True
            ScriptManager.RegisterClientScriptBlock(Me, Me.Page.GetType(), "dxsi_HidePopup", "ASPxPopupControl2.Show();", True)
            '  ASPxButtonEnviar.Visible = False
            Ingreso_Formulario()
            Enviar_Formulario_Correo()
        End If
       

    End Sub


    'enviar formularios por correo
    Private Sub Enviar_Formulario_Correo()
        CorreosEnvío.Enviar_Formulario_Correo_Lista(Llenar_Correo_Formulario(), "Formulario Voluntario", "VOL-LIB", ambiente)
        If ASPxTextBoxEmail.Value Is Nothing Then
        Else
            CorreosEnvío.Enviar_Confirmacion_Correo("Formulario Libre", ASPxTextBoxEmail.Value)
        End If

    End Sub
    'llenar correo con datos del formulario
    Private Function Llenar_Correo_Formulario() As ArrayList


        Dim datos_formulario As New ArrayList
        datos_formulario.Add("Notificación Libre " + "<br>")

        datos_formulario.Add("<b>ID: </b>" + id_formulario.ToString() + " " + " <br></br>")

        datos_formulario.Add("Nombre: " + ASPxTextBoxNombreApellido.Value + " " + "<br>")
        datos_formulario.Add("<br>")
        datos_formulario.Add("Email: " + ASPxTextBoxEmail.Value + " " + "<br>")
        datos_formulario.Add("<br>")
        datos_formulario.Add("Teléfono: " + ASPxTextBoxTelefono.Value + " " + "<br>")
        datos_formulario.Add("<br>")
        If ASPxComboBoxAeropuertos.SelectedItem Is Nothing Then
            datos_formulario.Add("Aeropuertos: " + " " + "<br>")
            datos_formulario.Add("<br>")
        Else
            datos_formulario.Add("Aeropuertos: " + ASPxComboBoxAeropuertos.SelectedItem.Text + " " + "<br>")
            datos_formulario.Add("<br>")
        End If

        If ASPxTextBoxProveedorServicios.Value Is Nothing Then
            datos_formulario.Add("Proveedor de Servicios:" + " " + " <br>")
            datos_formulario.Add("<br>")
        Else
            datos_formulario.Add("Proveedor de Servicios: " + ASPxTextBoxProveedorServicios.Value + " " + "<br>")
            datos_formulario.Add("<br>")
        End If


        If ASPxDateEditFecha.Value Is Nothing Then
            datos_formulario.Add("Fecha: " + Now.ToString() + " " + "<br>")
            datos_formulario.Add("<br>")
        Else
            datos_formulario.Add("Fecha: " + ASPxDateEditFecha.Value.ToString() + " " + "<br>")
            datos_formulario.Add("<br>")
        End If

        If ASPxTimeEditHora.Value Is Nothing Then
            datos_formulario.Add("Hora " + Now.ToString().Substring(11) + " " + "<br>")
            datos_formulario.Add("<br>")
        Else
            datos_formulario.Add("Hora: " + ASPxTimeEditHora.Value.ToString().Substring(11) + " " + "<br>")
            datos_formulario.Add("<br>")
        End If


        datos_formulario.Add("Descripción: " + ASPxMemoDescripcionNarrativa.Value + " " + "<br>")
        Return datos_formulario
    End Function

    'ingreso a la BD
    Private Sub Ingreso_Formulario()


        Dim numr As Integer
        ambiente = "PRODUCCION"
        Dim cn As String = "Data Source=win-sqlserv-02;Initial Catalog=SSP_BI;User ID=adminsql;Password=sistema*-!;"
        Dim sql As String = "insert into Notificaciones_NSSP(form_id, version, fecha_creacion, nombre, email, telefono, lugar_id, Proveedor_Servicios, fecha, hora, descripcion, ambiente) values"
        sql = sql + "(@form_id, @version, @fecha_creacion, @nombre, @email, @telefono ,@lugar_id ,@Proveedor_Servicios, @fecha, @hora, @descripcion, @ambiente)"
        Dim sql_id As String = "SELECT TOP 1 * FROM [SSP_BI].[dbo].[Notificaciones_NSSP] ORDER BY id DESC"
        '  Dim sql_id2 As String = "SELECT SCOPE_IDENTITY()"
        Using conn As New SqlConnection(cn)
            Dim cmd As New SqlCommand(sql, conn)
            Dim cmd_id As New SqlCommand(sql_id, conn)
            ' Dim cmd_id2 As New SqlCommand(sql_id2, conn)
            cmd.Parameters.AddWithValue("@form_id", 4)
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
            If ASPxTextBoxTelefono.Value Is Nothing Then
                cmd.Parameters.AddWithValue("@telefono", "")
            ElseIf ASPxTextBoxTelefono.Value.Equals("") Then
                cmd.Parameters.AddWithValue("@telefono", "")
            Else
                cmd.Parameters.AddWithValue("@telefono", ASPxTextBoxTelefono.Value)
            End If


            'validar el vacio
            If ASPxComboBoxAeropuertos.SelectedItem Is Nothing Then
                cmd.Parameters.AddWithValue("@lugar_id", "")
            ElseIf ASPxComboBoxAeropuertos.SelectedItem.Value.Equals("") Then
                cmd.Parameters.AddWithValue("@lugar_id", "")
            Else
                cmd.Parameters.AddWithValue("@lugar_id", ASPxComboBoxAeropuertos.SelectedItem.Value)
            End If
            If ASPxTextBoxProveedorServicios.Value Is Nothing Then
                cmd.Parameters.AddWithValue("@Proveedor_Servicios", "")
            ElseIf ASPxTextBoxProveedorServicios.Value.Equals("") Then
                cmd.Parameters.AddWithValue("@Proveedor_Servicios", "")
            Else
                cmd.Parameters.AddWithValue("@Proveedor_Servicios", ASPxTextBoxProveedorServicios.Value)

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


            If ASPxMemoDescripcionNarrativa.Value Is Nothing Then
                cmd.Parameters.AddWithValue("@descripcion", "")
            ElseIf ASPxMemoDescripcionNarrativa.Value.Equals("") Then
                cmd.Parameters.AddWithValue("@descripcion", "")
            Else
                cmd.Parameters.AddWithValue("@descripcion", ASPxMemoDescripcionNarrativa.Value)
            End If

            cmd.Parameters.AddWithValue("@ambiente", ambiente)


            Try
                If ambiente.Equals("PRUEBAS") Then
                    id_formulario = 0
                Else
                    conn.Open()
                    numr = Convert.ToInt32(cmd.ExecuteScalar())
                    id_formulario = Convert.ToInt32(cmd_id.ExecuteScalar())
                    '  Convert.ToInt32(cmd_id2.ExecuteScalar())
                    conn.Close()
                End If

            Catch ex As Exception
                Console.WriteLine(ex.Message)
                ScriptManager.RegisterStartupScript(Page, Page.GetType, "alertjs", "alert(' " & ex.Message & "');", True)
            End Try
            
        End Using
       


    End Sub

    Protected Sub ASPxButton1_Click(sender As Object, e As EventArgs) Handles ASPxButton1.Click
        Response.Redirect("~/default.aspx")
    End Sub

    Protected Sub UpdatePanel2_Unload(sender As Object, e As EventArgs) Handles UpdatePanel2.Unload
        RegisterUpdatePanel(DirectCast(sender, UpdatePanel))
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
            guardarArchivosbd.insertar_archivo(id_formulario, e.UploadedFile.FileName, e.UploadedFile.FileBytes)
        End If

    End Sub
End Class