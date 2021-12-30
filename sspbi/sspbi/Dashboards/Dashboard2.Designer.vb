Namespace Win_Dashboards
    Partial Public Class Dashboard2
        ''' <summary> 
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

#Region "Component Designer generated code"

        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim Dimension1 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim TableQuery1 As DevExpress.DataAccess.Sql.TableQuery = New DevExpress.DataAccess.Sql.TableQuery()
            Dim RelationInfo1 As DevExpress.DataAccess.Sql.RelationInfo = New DevExpress.DataAccess.Sql.RelationInfo()
            Dim RelationColumnInfo1 As DevExpress.DataAccess.Sql.RelationColumnInfo = New DevExpress.DataAccess.Sql.RelationColumnInfo()
            Dim RelationInfo2 As DevExpress.DataAccess.Sql.RelationInfo = New DevExpress.DataAccess.Sql.RelationInfo()
            Dim RelationColumnInfo2 As DevExpress.DataAccess.Sql.RelationColumnInfo = New DevExpress.DataAccess.Sql.RelationColumnInfo()
            Dim RelationInfo3 As DevExpress.DataAccess.Sql.RelationInfo = New DevExpress.DataAccess.Sql.RelationInfo()
            Dim RelationColumnInfo3 As DevExpress.DataAccess.Sql.RelationColumnInfo = New DevExpress.DataAccess.Sql.RelationColumnInfo()
            Dim TableInfo1 As DevExpress.DataAccess.Sql.TableInfo = New DevExpress.DataAccess.Sql.TableInfo()
            Dim ColumnInfo1 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo2 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo3 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo4 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo5 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo6 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo7 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo8 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo9 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo10 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim TableInfo2 As DevExpress.DataAccess.Sql.TableInfo = New DevExpress.DataAccess.Sql.TableInfo()
            Dim ColumnInfo11 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo12 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo13 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo14 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo15 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo16 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo17 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo18 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo19 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo20 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo21 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo22 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo23 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo24 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo25 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo26 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo27 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo28 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo29 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo30 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo31 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo32 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo33 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo34 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo35 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo36 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo37 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo38 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo39 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo40 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo41 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo42 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo43 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo44 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo45 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo46 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo47 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo48 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo49 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo50 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo51 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo52 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo53 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo54 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo55 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo56 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo57 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo58 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo59 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo60 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo61 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo62 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo63 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo64 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo65 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo66 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo67 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo68 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo69 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo70 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo71 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo72 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo73 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo74 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo75 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo76 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo77 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo78 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo79 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo80 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo81 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo82 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo83 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo84 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo85 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo86 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo87 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo88 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo89 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo90 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo91 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo92 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo93 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo94 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo95 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo96 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo97 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo98 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo99 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo100 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo101 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo102 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo103 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo104 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo105 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo106 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo107 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo108 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo109 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo110 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo111 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo112 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo113 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo114 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo115 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo116 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo117 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo118 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo119 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo120 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo121 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo122 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo123 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim TableInfo3 As DevExpress.DataAccess.Sql.TableInfo = New DevExpress.DataAccess.Sql.TableInfo()
            Dim ColumnInfo124 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo125 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo126 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo127 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo128 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo129 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo130 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo131 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo132 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo133 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo134 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo135 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo136 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo137 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo138 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo139 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo140 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo141 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo142 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo143 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo144 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo145 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo146 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim TableInfo4 As DevExpress.DataAccess.Sql.TableInfo = New DevExpress.DataAccess.Sql.TableInfo()
            Dim ColumnInfo147 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo148 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo149 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo150 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo151 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard2))
            Dim Dimension2 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim Dimension3 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim Dimension4 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim Dimension5 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim Dimension6 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim Dimension7 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim Dimension8 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim Dimension9 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim Dimension10 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim Dimension11 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim Measure1 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
            Dim Dimension12 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim Dimension13 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim Dimension14 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim Measure2 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
            Dim ChartPane1 As DevExpress.DashboardCommon.ChartPane = New DevExpress.DashboardCommon.ChartPane()
            Dim SimpleSeries1 As DevExpress.DashboardCommon.SimpleSeries = New DevExpress.DashboardCommon.SimpleSeries()
            Dim Dimension15 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim Measure3 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
            Dim SimpleSeries2 As DevExpress.DashboardCommon.SimpleSeries = New DevExpress.DashboardCommon.SimpleSeries()
            Dim DashboardLayoutGroup1 As DevExpress.DashboardCommon.DashboardLayoutGroup = New DevExpress.DashboardCommon.DashboardLayoutGroup()
            Dim DashboardLayoutGroup2 As DevExpress.DashboardCommon.DashboardLayoutGroup = New DevExpress.DashboardCommon.DashboardLayoutGroup()
            Dim DashboardLayoutGroup3 As DevExpress.DashboardCommon.DashboardLayoutGroup = New DevExpress.DashboardCommon.DashboardLayoutGroup()
            Dim DashboardLayoutGroup4 As DevExpress.DashboardCommon.DashboardLayoutGroup = New DevExpress.DashboardCommon.DashboardLayoutGroup()
            Dim DashboardLayoutItem1 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
            Dim DashboardLayoutItem2 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
            Dim DashboardLayoutItem3 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
            Dim DashboardLayoutGroup5 As DevExpress.DashboardCommon.DashboardLayoutGroup = New DevExpress.DashboardCommon.DashboardLayoutGroup()
            Dim DashboardLayoutItem4 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
            Dim DashboardLayoutItem5 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
            Dim DashboardLayoutItem6 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
            Me.ListBoxDashboardItem1 = New DevExpress.DashboardCommon.ListBoxDashboardItem()
            Me.DashboardSqlDataSource1 = New DevExpress.DashboardCommon.DashboardSqlDataSource()
            Me.ListBoxDashboardItem2 = New DevExpress.DashboardCommon.ListBoxDashboardItem()
            Me.ListBoxDashboardItem3 = New DevExpress.DashboardCommon.ListBoxDashboardItem()
            Me.PieMapDashboardItem1 = New DevExpress.DashboardCommon.PieMapDashboardItem()
            Me.ChartDashboardItem1 = New DevExpress.DashboardCommon.ChartDashboardItem()
            Me.RangeFilterDashboardItem1 = New DevExpress.DashboardCommon.RangeFilterDashboardItem()
            CType(Me.ListBoxDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DashboardSqlDataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ListBoxDashboardItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ListBoxDashboardItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PieMapDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension7, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension8, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension9, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension10, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension11, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Measure1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension12, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ChartDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension13, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension14, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Measure2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RangeFilterDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension15, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Measure3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            '
            'ListBoxDashboardItem1
            '
            Me.ListBoxDashboardItem1.ComponentName = "ListBoxDashboardItem1"
            Dimension1.DataMember = "ANIO"
            Dimension1.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.General
            Dimension1.SortOrder = DevExpress.DashboardCommon.DimensionSortOrder.Descending
            Me.ListBoxDashboardItem1.DataItemRepository.Clear()
            Me.ListBoxDashboardItem1.DataItemRepository.Add(Dimension1, "DataItem0")
            Me.ListBoxDashboardItem1.DataMember = "Reportes_SSP_Master"
            Me.ListBoxDashboardItem1.DataSource = Me.DashboardSqlDataSource1
            Me.ListBoxDashboardItem1.FilterDimensions.AddRange(New DevExpress.DashboardCommon.Dimension() {Dimension1})
            Me.ListBoxDashboardItem1.InteractivityOptions.IgnoreMasterFilters = True
            Me.ListBoxDashboardItem1.Name = "Año"
            Me.ListBoxDashboardItem1.ShowCaption = True
            '
            'DashboardSqlDataSource1
            '
            Me.DashboardSqlDataSource1.ComponentName = "DashboardSqlDataSource1"
            Me.DashboardSqlDataSource1.ConnectionName = "win-sqlserv-02_SSP_BI_Connection"
            Me.DashboardSqlDataSource1.Name = "SQL Data Source 1"
            TableQuery1.FilterString = ""
            TableQuery1.GroupFilterString = ""
            TableQuery1.Name = "Reportes_SSP_Master"
            RelationInfo1.JoinType = DevExpress.Xpo.DB.JoinType.LeftOuter
            RelationColumnInfo1.NestedKeyColumn = "lugar_id"
            RelationColumnInfo1.ParentKeyColumn = "id"
            RelationInfo1.KeyColumns.AddRange(New DevExpress.DataAccess.Sql.RelationColumnInfo() {RelationColumnInfo1})
            RelationInfo1.NestedTable = "Reportes_SSP_Master"
            RelationInfo1.ParentTable = "Vista_aeropuertos"
            RelationInfo2.JoinType = DevExpress.Xpo.DB.JoinType.LeftOuter
            RelationColumnInfo2.NestedKeyColumn = "FECHA"
            RelationColumnInfo2.ParentKeyColumn = "date"
            RelationInfo2.KeyColumns.AddRange(New DevExpress.DataAccess.Sql.RelationColumnInfo() {RelationColumnInfo2})
            RelationInfo2.NestedTable = "DIMTIME"
            RelationInfo2.ParentTable = "Reportes_SSP_Master"
            RelationInfo3.JoinType = DevExpress.Xpo.DB.JoinType.LeftOuter
            RelationColumnInfo3.NestedKeyColumn = "id"
            RelationColumnInfo3.ParentKeyColumn = "form_id"
            RelationInfo3.KeyColumns.AddRange(New DevExpress.DataAccess.Sql.RelationColumnInfo() {RelationColumnInfo3})
            RelationInfo3.NestedTable = "Formularios_Descrip"
            RelationInfo3.ParentTable = "Reportes_SSP_Master"
            TableQuery1.Relations.AddRange(New DevExpress.DataAccess.Sql.RelationInfo() {RelationInfo1, RelationInfo2, RelationInfo3})
            TableInfo1.Name = "Vista_aeropuertos"
            ColumnInfo1.Name = "id"
            ColumnInfo2.Name = "ciudad"
            ColumnInfo3.Name = "pais"
            ColumnInfo4.Name = "aeropuerto"
            ColumnInfo5.Name = "aerodromo"
            ColumnInfo6.Name = "punto_ruta_oaci"
            ColumnInfo7.Name = "punto_ruta_iata"
            ColumnInfo8.Name = "aerop_descrip"
            ColumnInfo9.Name = "latitud"
            ColumnInfo10.Name = "longitud"
            TableInfo1.SelectedColumns.AddRange(New DevExpress.DataAccess.Sql.ColumnInfo() {ColumnInfo1, ColumnInfo2, ColumnInfo3, ColumnInfo4, ColumnInfo5, ColumnInfo6, ColumnInfo7, ColumnInfo8, ColumnInfo9, ColumnInfo10})
            TableInfo2.Name = "Reportes_SSP_Master"
            ColumnInfo11.Alias = "Reportes_SSP_Master_id"
            ColumnInfo11.Name = "id"
            ColumnInfo12.Name = "form_id"
            ColumnInfo13.Name = "entry_id"
            ColumnInfo14.Name = "entry_date_created"
            ColumnInfo15.Name = "nombre_formulario"
            ColumnInfo16.Name = "fecha_creacion"
            ColumnInfo17.Name = "nombre"
            ColumnInfo18.Name = "email"
            ColumnInfo19.Name = "telefono"
            ColumnInfo20.Name = "ubicacion"
            ColumnInfo21.Name = "lugar"
            ColumnInfo22.Name = "lugar_id"
            ColumnInfo23.Name = "fecha"
            ColumnInfo24.Name = "hora"
            ColumnInfo25.Name = "descripcion"
            ColumnInfo26.Name = "01_02_Explotador"
            ColumnInfo27.Name = "03_04_Marca_Modelo_de_Aeronave"
            ColumnInfo28.Name = "05_06_Marca_Modelo_de_Motor"
            ColumnInfo29.Name = "07_Matricula_de_Aeronave"
            ColumnInfo30.Name = "08_Fecha_del_Choque"
            ColumnInfo31.Name = "08_Fecha"
            ColumnInfo32.Name = "09_Hora"
            ColumnInfo33.Name = "10_Condiciones_de_Luz"
            ColumnInfo34.Name = "11_12_Nombre_del_Aerodromo"
            ColumnInfo35.Name = "11_12_14_Aerodromo_Posicion_si_se_conoce"
            ColumnInfo36.Name = "13_Pista_Utilizada"
            ColumnInfo37.Name = "14_Posicion_si_fue_en_ruta"
            ColumnInfo38.Name = "15_Altura_pies"
            ColumnInfo39.Name = "16_Velocidad_Indicada_nudos"
            ColumnInfo40.Name = "17_Fase_de_vuelo"
            ColumnInfo41.Name = "37_Condiciones_del_Cielo"
            ColumnInfo42.Name = "41_Especie_de_Ave"
            ColumnInfo43.Name = "42_Observadas"
            ColumnInfo44.Name = "43_Golpeadas"
            ColumnInfo45.Name = "44_Tamano_de_las_Aves"
            ColumnInfo46.Name = "45_Se_Advirtio_del_Peligro"
            ColumnInfo47.Name = "46_47_Observaciones"
            ColumnInfo48.Name = "52_Tiempo_Aeronave_Fuera_Servicio"
            ColumnInfo49.Name = "53_Costes_Estimado_para_Reparacion_o_Sustitucion"
            ColumnInfo50.Name = "54_Otros_Costes_Estimados"
            ColumnInfo51.Name = "A1"
            ColumnInfo52.Name = "A2"
            ColumnInfo53.Name = "AD1"
            ColumnInfo54.Name = "AD2"
            ColumnInfo55.Name = "Adjuntar_Archivo"
            ColumnInfo56.Name = "Aerodromo_Destino"
            ColumnInfo57.Name = "Aerodromo_Salida"
            ColumnInfo58.Name = "AI_Motor_1"
            ColumnInfo59.Name = "AI_Motor_2"
            ColumnInfo60.Name = "AS1"
            ColumnInfo61.Name = "AS2"
            ColumnInfo62.Name = "Carga_Trabajo_ATC"
            ColumnInfo63.Name = "Categoria_Vuelo"
            ColumnInfo64.Name = "CCO_ATC"
            ColumnInfo65.Name = "Clase_de_Espacio_Aereo"
            ColumnInfo66.Name = "Condiciones_de_Luz"
            ColumnInfo67.Name = "Condiciones_Meteorologicas_Relevantes"
            ColumnInfo68.Name = "Condiciones_Meteorologicas"
            ColumnInfo69.Name = "CSR1"
            ColumnInfo70.Name = "CSR2"
            ColumnInfo71.Name = "Danadas"
            ColumnInfo72.Name = "Dano_Aeronave"
            ColumnInfo73.Name = "Duracion_Vuelo"
            ColumnInfo74.Name = "Fase_Vuelo"
            ColumnInfo75.Name = "Fatalidad_P"
            ColumnInfo76.Name = "Fatalidad_T"
            ColumnInfo77.Name = "Frecuencia_RTF"
            ColumnInfo78.Name = "Golpeados"
            ColumnInfo79.Name = "Graves_P"
            ColumnInfo80.Name = "Graves_T"
            ColumnInfo81.Name = "Horizontal_(NM)"
            ColumnInfo82.Name = "Jornada_Trabajo"
            ColumnInfo83.Name = "Latitud"
            ColumnInfo84.Name = "Lic_ATC"
            ColumnInfo85.Name = "Longitud"
            ColumnInfo86.Name = "M1"
            ColumnInfo87.Name = "M2"
            ColumnInfo88.Name = "Matricula"
            ColumnInfo89.Name = "Menores_P"
            ColumnInfo90.Name = "Menores_T"
            ColumnInfo91.Name = "Modelo_Matricula"
            ColumnInfo92.Name = "MSAW"
            ColumnInfo93.Name = "MSR1"
            ColumnInfo94.Name = "MSR2"
            ColumnInfo95.Name = "Ninguno_P"
            ColumnInfo96.Name = "Ninguno_T"
            ColumnInfo97.Name = "Nombre_Espacio_Aereo"
            ColumnInfo98.Name = "Nombre_Sector_ATC"
            ColumnInfo99.Name = "Nombre_Unidad_ATS"
            ColumnInfo100.Name = "NV1"
            ColumnInfo101.Name = "NV2"
            ColumnInfo102.Name = "O1"
            ColumnInfo103.Name = "O2"
            ColumnInfo104.Name = "Operador"
            ColumnInfo105.Name = "Otras_Consecuencias_Vuelo"
            ColumnInfo106.Name = "Otras_Danadas"
            ColumnInfo107.Name = "Otras_Golpeadas"
            ColumnInfo108.Name = "Otros_TO"
            ColumnInfo109.Name = "PE_Motor_1"
            ColumnInfo110.Name = "PE_Motor_2"
            ColumnInfo111.Name = "RV1"
            ColumnInfo112.Name = "RV2"
            ColumnInfo113.Name = "Servicio_ATC_Provisto"
            ColumnInfo114.Name = "STCA"
            ColumnInfo115.Name = "Tipo_Espacio_Aereo"
            ColumnInfo116.Name = "Tipo_Informacion_Trafico_Provisto"
            ColumnInfo117.Name = "Tipo_de_Operacion"
            ColumnInfo118.Name = "Tipo_Modulo"
            ColumnInfo119.Name = "V1"
            ColumnInfo120.Name = "V2"
            ColumnInfo121.Name = "Vertical_FT"
            ColumnInfo122.Name = "Validado"
            ColumnInfo123.Name = "date"
            TableInfo2.SelectedColumns.AddRange(New DevExpress.DataAccess.Sql.ColumnInfo() {ColumnInfo11, ColumnInfo12, ColumnInfo13, ColumnInfo14, ColumnInfo15, ColumnInfo16, ColumnInfo17, ColumnInfo18, ColumnInfo19, ColumnInfo20, ColumnInfo21, ColumnInfo22, ColumnInfo23, ColumnInfo24, ColumnInfo25, ColumnInfo26, ColumnInfo27, ColumnInfo28, ColumnInfo29, ColumnInfo30, ColumnInfo31, ColumnInfo32, ColumnInfo33, ColumnInfo34, ColumnInfo35, ColumnInfo36, ColumnInfo37, ColumnInfo38, ColumnInfo39, ColumnInfo40, ColumnInfo41, ColumnInfo42, ColumnInfo43, ColumnInfo44, ColumnInfo45, ColumnInfo46, ColumnInfo47, ColumnInfo48, ColumnInfo49, ColumnInfo50, ColumnInfo51, ColumnInfo52, ColumnInfo53, ColumnInfo54, ColumnInfo55, ColumnInfo56, ColumnInfo57, ColumnInfo58, ColumnInfo59, ColumnInfo60, ColumnInfo61, ColumnInfo62, ColumnInfo63, ColumnInfo64, ColumnInfo65, ColumnInfo66, ColumnInfo67, ColumnInfo68, ColumnInfo69, ColumnInfo70, ColumnInfo71, ColumnInfo72, ColumnInfo73, ColumnInfo74, ColumnInfo75, ColumnInfo76, ColumnInfo77, ColumnInfo78, ColumnInfo79, ColumnInfo80, ColumnInfo81, ColumnInfo82, ColumnInfo83, ColumnInfo84, ColumnInfo85, ColumnInfo86, ColumnInfo87, ColumnInfo88, ColumnInfo89, ColumnInfo90, ColumnInfo91, ColumnInfo92, ColumnInfo93, ColumnInfo94, ColumnInfo95, ColumnInfo96, ColumnInfo97, ColumnInfo98, ColumnInfo99, ColumnInfo100, ColumnInfo101, ColumnInfo102, ColumnInfo103, ColumnInfo104, ColumnInfo105, ColumnInfo106, ColumnInfo107, ColumnInfo108, ColumnInfo109, ColumnInfo110, ColumnInfo111, ColumnInfo112, ColumnInfo113, ColumnInfo114, ColumnInfo115, ColumnInfo116, ColumnInfo117, ColumnInfo118, ColumnInfo119, ColumnInfo120, ColumnInfo121, ColumnInfo122, ColumnInfo123})
            TableInfo3.Name = "DIMTIME"
            ColumnInfo124.Name = "FECHA"
            ColumnInfo125.Name = "DATAKEY"
            ColumnInfo126.Name = "FECHAHORA"
            ColumnInfo127.Name = "ANIO"
            ColumnInfo128.Name = "TRIMESTRE"
            ColumnInfo129.Name = "YEARTRIMESTRE"
            ColumnInfo130.Name = "QUARTER"
            ColumnInfo131.Name = "YEARQUARTER"
            ColumnInfo132.Name = "MES"
            ColumnInfo133.Name = "YEARMONTH"
            ColumnInfo134.Name = "MONTHNAME"
            ColumnInfo135.Name = "SHORTMONTHNAME"
            ColumnInfo136.Name = "WEEK"
            ColumnInfo137.Name = "DAYINYEAR"
            ColumnInfo138.Name = "DAYINMONTH"
            ColumnInfo139.Name = "DAYNAME"
            ColumnInfo140.Name = "SHORTDAYNAME"
            ColumnInfo141.Name = "LASTDAYINMONTH"
            ColumnInfo142.Name = "MONTHYEAR"
            ColumnInfo143.Name = "HOLIDAY"
            ColumnInfo144.Name = "DAYINMONTH_ORD"
            ColumnInfo145.Name = "MES_ORD"
            ColumnInfo146.Name = "SEMANA_ORD"
            TableInfo3.SelectedColumns.AddRange(New DevExpress.DataAccess.Sql.ColumnInfo() {ColumnInfo124, ColumnInfo125, ColumnInfo126, ColumnInfo127, ColumnInfo128, ColumnInfo129, ColumnInfo130, ColumnInfo131, ColumnInfo132, ColumnInfo133, ColumnInfo134, ColumnInfo135, ColumnInfo136, ColumnInfo137, ColumnInfo138, ColumnInfo139, ColumnInfo140, ColumnInfo141, ColumnInfo142, ColumnInfo143, ColumnInfo144, ColumnInfo145, ColumnInfo146})
            TableInfo4.Name = "Formularios_Descrip"
            ColumnInfo147.Alias = "Formularios_Descrip_id"
            ColumnInfo147.Name = "id"
            ColumnInfo148.Alias = "Formularios_Descrip_nombre_formulario"
            ColumnInfo148.Name = "nombre_formulario"
            ColumnInfo149.Name = "abreviacion_formulario"
            ColumnInfo150.Alias = "Formularios_Descrip_descripcion"
            ColumnInfo150.Name = "descripcion"
            ColumnInfo151.Name = "voluntario"
            TableInfo4.SelectedColumns.AddRange(New DevExpress.DataAccess.Sql.ColumnInfo() {ColumnInfo147, ColumnInfo148, ColumnInfo149, ColumnInfo150, ColumnInfo151})
            TableQuery1.Tables.AddRange(New DevExpress.DataAccess.Sql.TableInfo() {TableInfo1, TableInfo2, TableInfo3, TableInfo4})
            Me.DashboardSqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {TableQuery1})
            Me.DashboardSqlDataSource1.ResultSchemaSerializable = resources.GetString("DashboardSqlDataSource1.ResultSchemaSerializable")
            '
            'ListBoxDashboardItem2
            '
            Me.ListBoxDashboardItem2.ComponentName = "ListBoxDashboardItem2"
            Dimension2.DataMember = "abreviacion_formulario"
            Dimension3.DataMember = "Formularios_Descrip_id"
            Me.ListBoxDashboardItem2.DataItemRepository.Clear()
            Me.ListBoxDashboardItem2.DataItemRepository.Add(Dimension2, "DataItem0")
            Me.ListBoxDashboardItem2.DataItemRepository.Add(Dimension3, "DataItem1")
            Me.ListBoxDashboardItem2.DataMember = "Reportes_SSP_Master"
            Me.ListBoxDashboardItem2.DataSource = Me.DashboardSqlDataSource1
            Me.ListBoxDashboardItem2.FilterDimensions.AddRange(New DevExpress.DashboardCommon.Dimension() {Dimension3, Dimension2})
            Me.ListBoxDashboardItem2.InteractivityOptions.IgnoreMasterFilters = True
            Me.ListBoxDashboardItem2.Name = "Formulario"
            Me.ListBoxDashboardItem2.ShowCaption = True
            '
            'ListBoxDashboardItem3
            '
            Me.ListBoxDashboardItem3.ComponentName = "ListBoxDashboardItem3"
            Dimension4.DataMember = "ciudad"
            Dimension5.DataMember = "aerodromo"
            Dimension6.DataMember = "punto_ruta_oaci"
            Me.ListBoxDashboardItem3.DataItemRepository.Clear()
            Me.ListBoxDashboardItem3.DataItemRepository.Add(Dimension4, "DataItem0")
            Me.ListBoxDashboardItem3.DataItemRepository.Add(Dimension5, "DataItem1")
            Me.ListBoxDashboardItem3.DataItemRepository.Add(Dimension6, "DataItem2")
            Me.ListBoxDashboardItem3.DataMember = "Reportes_SSP_Master"
            Me.ListBoxDashboardItem3.DataSource = Me.DashboardSqlDataSource1
            Me.ListBoxDashboardItem3.FilterDimensions.AddRange(New DevExpress.DashboardCommon.Dimension() {Dimension4, Dimension5, Dimension6})
            Me.ListBoxDashboardItem3.InteractivityOptions.IgnoreMasterFilters = True
            Me.ListBoxDashboardItem3.Name = "Lugares"
            Me.ListBoxDashboardItem3.ShowCaption = True
            '
            'PieMapDashboardItem1
            '
            Me.PieMapDashboardItem1.Area = DevExpress.DashboardCommon.ShapefileArea.SouthAmerica
            Dimension7.DataMember = "abreviacion_formulario"
            Me.PieMapDashboardItem1.Argument = Dimension7
            Me.PieMapDashboardItem1.ComponentName = "PieMapDashboardItem1"
            Dimension8.DataMember = "abreviacion_formulario"
            Dimension9.DataMember = "abreviacion_formulario"
            Dimension10.DataMember = "latitud"
            Dimension11.DataMember = "longitud"
            Measure1.DataMember = "Reportes_SSP_Master_id"
            Measure1.SummaryType = DevExpress.DashboardCommon.SummaryType.Count
            Dimension12.DataMember = "aerodromo"
            Me.PieMapDashboardItem1.DataItemRepository.Clear()
            Me.PieMapDashboardItem1.DataItemRepository.Add(Dimension8, "DataItem0")
            Me.PieMapDashboardItem1.DataItemRepository.Add(Dimension9, "DataItem1")
            Me.PieMapDashboardItem1.DataItemRepository.Add(Dimension10, "DataItem2")
            Me.PieMapDashboardItem1.DataItemRepository.Add(Dimension11, "DataItem3")
            Me.PieMapDashboardItem1.DataItemRepository.Add(Measure1, "DataItem4")
            Me.PieMapDashboardItem1.DataItemRepository.Add(Dimension7, "DataItem6")
            Me.PieMapDashboardItem1.DataItemRepository.Add(Dimension12, "DataItem7")
            Me.PieMapDashboardItem1.DataMember = "Reportes_SSP_Master"
            Me.PieMapDashboardItem1.DataSource = Me.DashboardSqlDataSource1
            Me.PieMapDashboardItem1.HiddenDimensions.AddRange(New DevExpress.DashboardCommon.Dimension() {Dimension8})
            Me.PieMapDashboardItem1.InteractivityOptions.IgnoreMasterFilters = False
            Me.PieMapDashboardItem1.InteractivityOptions.MasterFilterMode = DevExpress.DashboardCommon.DashboardItemMasterFilterMode.Multiple
            Me.PieMapDashboardItem1.IsMasterFilterCrossDataSource = True
            Me.PieMapDashboardItem1.Latitude = Dimension10
            Me.PieMapDashboardItem1.Longitude = Dimension11
            Me.PieMapDashboardItem1.Name = "Sucesos"
            Me.PieMapDashboardItem1.ShowCaption = True
            Me.PieMapDashboardItem1.TooltipDimensions.AddRange(New DevExpress.DashboardCommon.Dimension() {Dimension12, Dimension9})
            Me.PieMapDashboardItem1.Values.AddRange(New DevExpress.DashboardCommon.Measure() {Measure1})
            Me.PieMapDashboardItem1.Viewport.BottomLatitude = -5.1173057690892039R
            Me.PieMapDashboardItem1.Viewport.CenterPointLatitude = -1.4153187874045561R
            Me.PieMapDashboardItem1.Viewport.CenterPointLongitude = -80.556593822054523R
            Me.PieMapDashboardItem1.Viewport.CreateViewerPaddings = False
            Me.PieMapDashboardItem1.Viewport.LeftLongitude = -93.466929274701755R
            Me.PieMapDashboardItem1.Viewport.RightLongitude = -67.6462583694073R
            Me.PieMapDashboardItem1.Viewport.TopLatitude = 2.2925853009451358R
            '
            'ChartDashboardItem1
            '
            Dimension13.DataMember = "ANIO"
            Dimension13.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.General
            Dimension14.DataMember = "MES_ORD"
            Me.ChartDashboardItem1.Arguments.AddRange(New DevExpress.DashboardCommon.Dimension() {Dimension13, Dimension14})
            Me.ChartDashboardItem1.AxisX.TitleVisible = False
            Me.ChartDashboardItem1.ComponentName = "ChartDashboardItem1"
            Measure2.DataMember = "entry_id"
            Measure2.SummaryType = DevExpress.DashboardCommon.SummaryType.Count
            Me.ChartDashboardItem1.DataItemRepository.Clear()
            Me.ChartDashboardItem1.DataItemRepository.Add(Measure2, "DataItem0")
            Me.ChartDashboardItem1.DataItemRepository.Add(Dimension14, "DataItem2")
            Me.ChartDashboardItem1.DataItemRepository.Add(Dimension13, "DataItem3")
            Me.ChartDashboardItem1.DataMember = "Reportes_SSP_Master"
            Me.ChartDashboardItem1.DataSource = Me.DashboardSqlDataSource1
            Me.ChartDashboardItem1.InteractivityOptions.IgnoreMasterFilters = False
            Me.ChartDashboardItem1.Name = "Cantidad de Sucesos"
            ChartPane1.Name = "Pane 1"
            ChartPane1.PrimaryAxisY.AlwaysShowZeroLevel = True
            ChartPane1.PrimaryAxisY.ShowGridLines = True
            ChartPane1.PrimaryAxisY.TitleVisible = True
            ChartPane1.SecondaryAxisY.AlwaysShowZeroLevel = True
            ChartPane1.SecondaryAxisY.ShowGridLines = False
            ChartPane1.SecondaryAxisY.TitleVisible = True
            SimpleSeries1.PointLabelOptions.ShowPointLabels = True
            SimpleSeries1.AddDataItem("Value", Measure2)
            ChartPane1.Series.AddRange(New DevExpress.DashboardCommon.ChartSeries() {SimpleSeries1})
            Me.ChartDashboardItem1.Panes.AddRange(New DevExpress.DashboardCommon.ChartPane() {ChartPane1})
            Me.ChartDashboardItem1.ShowCaption = True
            '
            'RangeFilterDashboardItem1
            '
            Dimension15.DataMember = "FECHA"
            Dimension15.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.MonthYear
            Me.RangeFilterDashboardItem1.Argument = Dimension15
            Me.RangeFilterDashboardItem1.ComponentName = "RangeFilterDashboardItem1"
            Measure3.DataMember = "Reportes_SSP_Master_id"
            Measure3.SummaryType = DevExpress.DashboardCommon.SummaryType.Count
            Me.RangeFilterDashboardItem1.DataItemRepository.Clear()
            Me.RangeFilterDashboardItem1.DataItemRepository.Add(Measure3, "DataItem0")
            Me.RangeFilterDashboardItem1.DataItemRepository.Add(Dimension15, "DataItem1")
            Me.RangeFilterDashboardItem1.DataMember = "Reportes_SSP_Master"
            Me.RangeFilterDashboardItem1.DataSource = Me.DashboardSqlDataSource1
            Me.RangeFilterDashboardItem1.InteractivityOptions.IgnoreMasterFilters = True
            Me.RangeFilterDashboardItem1.Name = "Range Filter 1"
            SimpleSeries2.SeriesType = DevExpress.DashboardCommon.SimpleSeriesType.Line
            SimpleSeries2.AddDataItem("Value", Measure3)
            Me.RangeFilterDashboardItem1.Series.AddRange(New DevExpress.DashboardCommon.SimpleSeries() {SimpleSeries2})
            Me.RangeFilterDashboardItem1.ShowCaption = False
            '
            'Dashboard2
            '
            Me.DataSources.AddRange(New DevExpress.DashboardCommon.IDashboardDataSource() {Me.DashboardSqlDataSource1})
            Me.Items.AddRange(New DevExpress.DashboardCommon.DashboardItem() {Me.PieMapDashboardItem1, Me.ListBoxDashboardItem1, Me.ListBoxDashboardItem2, Me.ListBoxDashboardItem3, Me.RangeFilterDashboardItem1, Me.ChartDashboardItem1})
            DashboardLayoutItem1.DashboardItem = Me.ListBoxDashboardItem1
            DashboardLayoutItem1.Weight = 28.968253968253968R
            DashboardLayoutItem2.DashboardItem = Me.ListBoxDashboardItem2
            DashboardLayoutItem2.Weight = 71.031746031746039R
            DashboardLayoutGroup4.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() {DashboardLayoutItem1, DashboardLayoutItem2})
            DashboardLayoutGroup4.DashboardItem = Nothing
            DashboardLayoutGroup4.Weight = 39.8406374501992R
            DashboardLayoutItem3.DashboardItem = Me.ListBoxDashboardItem3
            DashboardLayoutItem3.Weight = 60.1593625498008R
            DashboardLayoutGroup3.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() {DashboardLayoutGroup4, DashboardLayoutItem3})
            DashboardLayoutGroup3.DashboardItem = Nothing
            DashboardLayoutGroup3.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical
            DashboardLayoutGroup3.Weight = 37.058823529411768R
            DashboardLayoutItem4.DashboardItem = Me.PieMapDashboardItem1
            DashboardLayoutItem4.Weight = 50.199203187250994R
            DashboardLayoutItem5.DashboardItem = Me.ChartDashboardItem1
            DashboardLayoutItem5.Weight = 49.800796812749006R
            DashboardLayoutGroup5.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() {DashboardLayoutItem4, DashboardLayoutItem5})
            DashboardLayoutGroup5.DashboardItem = Nothing
            DashboardLayoutGroup5.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical
            DashboardLayoutGroup5.Weight = 62.941176470588232R
            DashboardLayoutGroup2.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() {DashboardLayoutGroup3, DashboardLayoutGroup5})
            DashboardLayoutGroup2.DashboardItem = Nothing
            DashboardLayoutGroup2.Weight = 74.925373134328353R
            DashboardLayoutItem6.DashboardItem = Me.RangeFilterDashboardItem1
            DashboardLayoutItem6.Weight = 25.074626865671643R
            DashboardLayoutGroup1.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() {DashboardLayoutGroup2, DashboardLayoutItem6})
            DashboardLayoutGroup1.DashboardItem = Nothing
            DashboardLayoutGroup1.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical
            Me.LayoutRoot = DashboardLayoutGroup1
            Me.Title.Text = "Dashboard"
            CType(Dimension1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ListBoxDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DashboardSqlDataSource1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ListBoxDashboardItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ListBoxDashboardItem3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension7, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension8, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension9, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension10, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension11, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Measure1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension12, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PieMapDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension13, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension14, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Measure2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ChartDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension15, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Measure3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RangeFilterDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub
        Friend WithEvents DashboardSqlDataSource1 As DevExpress.DashboardCommon.DashboardSqlDataSource
        Friend WithEvents ListBoxDashboardItem1 As DevExpress.DashboardCommon.ListBoxDashboardItem
        Friend WithEvents ListBoxDashboardItem2 As DevExpress.DashboardCommon.ListBoxDashboardItem
        Friend WithEvents ListBoxDashboardItem3 As DevExpress.DashboardCommon.ListBoxDashboardItem
        Friend WithEvents RangeFilterDashboardItem1 As DevExpress.DashboardCommon.RangeFilterDashboardItem
        Friend WithEvents PieMapDashboardItem1 As DevExpress.DashboardCommon.PieMapDashboardItem
        Friend WithEvents ChartDashboardItem1 As DevExpress.DashboardCommon.ChartDashboardItem

#End Region
    End Class
End Namespace