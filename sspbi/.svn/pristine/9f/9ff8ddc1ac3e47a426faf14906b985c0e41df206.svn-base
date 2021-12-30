Imports System.Data.SqlClient

Public Class Login

    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Session("usuario") = ""
        Session("password") = ""
    End Sub

    Protected Sub ASPxButton1_Click(sender As Object, e As EventArgs) Handles ASPxButton1.Click
        'Response.Redirect("dashboard2.aspx")
        Consultar_Usuarios()
    End Sub
    Private Sub Consultar_Usuarios()
        Session("usuario") = ASPxTextBoxUsuario.Value
        Session("password") = ASPxTextBoxPassword.Value
        Dim respuesta As String = Usr_BD_Con(Session("usuario"), Session("password"))
        If respuesta.Equals("empty") Then
            Response.Redirect("../default.aspx")
        ElseIf respuesta.Equals("wrong") Then
            Response.Redirect("../default.aspx")
        ElseIf respuesta.Equals("ok") Then
            Session("autorizacion") = True
            Response.Redirect("../Main_Menu/Usuarios.aspx")
        End If

    End Sub

    Private Function Usr_BD_Con(ByVal usuario As String, ByVal password As String) As String
        Dim con As New SqlClient.SqlConnection
        Dim strCon As String = "Data Source=win-sqlserv-02;Initial Catalog=SSP_BI; User ID=adminsql;Password=sistema*-!;"
        con.ConnectionString = strCon
        con.Open()
        Dim datablasssp As New SqlDataAdapter("SELECT id, usuario, password FROM [SSP_BI].[dbo].[Usuarios_SSP] where [usuario] = '" & usuario & "'", con)
        Dim dataset As New DataSet("datasetablas")
        datablasssp.Fill(dataset)
        Dim tablasdgac As DataTable
        tablasdgac = dataset.Tables(0)


        If tablasdgac.Rows.Count = 0 Then
            Return "empty"
        End If

        If Trim(tablasdgac.Rows(0)("password")) <> password Then
            Return "wrong"
        Else
            Return "ok"
        End If
       

    End Function
End Class