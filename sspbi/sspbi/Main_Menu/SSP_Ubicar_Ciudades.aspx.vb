Imports DevExpress.Web
Imports DevExpress.Web.ASPxGridView

Public Class sspbi
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("autorizacion") <> True Then
            Response.Redirect("../default.aspx")
        End If
        If (Not IsPostBack) AndAlso (Not IsPostBack) Then
            ASPxGridView1.DataBind()

        End If

    End Sub

   
   
    Protected Sub ASPxGridView2_BeforePerformDataSelect(sender As Object, e As EventArgs)

        Session("id_formulario") = (TryCast(sender, ASPxGridView)).GetMasterRowKeyValue


    End Sub

    Protected Sub ASPxGridView1_DetailRowExpandedChanged(sender As Object, e As ASPxGridViewDetailRowEventArgs) Handles ASPxGridView1.DetailRowExpandedChanged

        Session("id_formulario") = sender.GetDataRow(e.VisibleIndex)("id")

        Me.Sql_SSP3.DataBind()








        




    End Sub

    Protected Sub DetailGridView_CellEditorInitialize(sender As Object, e As ASPxGridViewEditorEventArgs)
       
    End Sub
    
    Protected Sub DetailGridView_CustomUnboundColumnData(sender As Object, e As ASPxGridViewColumnDataEventArgs)
        ' Session("id_formulario") = (TryCast(sender, ASPxGridView)).GetMasterRowKeyValue()

    End Sub

    Protected Sub Sql_SSP3_Selecting(sender As Object, e As SqlDataSourceSelectingEventArgs) Handles Sql_SSP3.Selecting
        e.Command.Parameters("@master_id").Value = Session("id_formulario")

    End Sub

    Protected Sub ASPxGridView1_DetailsChanged(sender As Object, e As EventArgs) Handles ASPxGridView1.DetailsChanged


    End Sub

    Protected Sub ASPxButtonAdministracionUsuarios_Click(sender As Object, e As EventArgs) Handles ASPxButtonAdministracionUsuarios.Click
        Response.Redirect("../Main_Menu/Usuarios.aspx")
    End Sub
End Class