Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports DevExpress.DataAccess
Imports DevExpress.DashboardCommon

Namespace Win_Dashboards
    Partial Public Class Dashboard2
        Inherits DevExpress.DashboardCommon.Dashboard
        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Dashboard2_DataLoading(sender As Object, e As DashboardDataLoadingEventArgs) Handles MyBase.DataLoading

        End Sub

        Private Sub Dashboard2_DashboardLoading(sender As Object, e As EventArgs) Handles MyBase.DashboardLoading
            Dim i = 0
        End Sub
    End Class
End Namespace