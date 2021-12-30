Public Class Usuarios
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("autorizacion") <> True Then
            Response.Redirect("../default.aspx")

        End If
    End Sub

    Protected Sub ASPxButtonAdministracionUsuarios_Click(sender As Object, e As EventArgs) Handles ASPxButtonRegresar.Click
        Response.Redirect("../Main_Menu/Login.aspx")
    End Sub
End Class