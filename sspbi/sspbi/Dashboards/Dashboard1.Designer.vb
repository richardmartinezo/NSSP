Namespace Win_Dashboards
    Partial Public Class Dashboard1
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
            Dim Dimension2 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim Dimension3 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
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
            Dim TableInfo2 As DevExpress.DataAccess.Sql.TableInfo = New DevExpress.DataAccess.Sql.TableInfo()
            Dim ColumnInfo114 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo115 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo116 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim TableInfo3 As DevExpress.DataAccess.Sql.TableInfo = New DevExpress.DataAccess.Sql.TableInfo()
            Dim ColumnInfo117 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo118 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo119 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo120 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo121 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo122 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo123 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo124 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo125 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo126 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim TableInfo4 As DevExpress.DataAccess.Sql.TableInfo = New DevExpress.DataAccess.Sql.TableInfo()
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
            Dim ColumnInfo147 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo148 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo149 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard1))
            Dim Dimension4 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim Dimension5 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim Dimension6 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim Dimension7 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim Dimension8 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim Dimension9 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim Measure1 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
            Dim Dimension10 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim Dimension11 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim ChartPane1 As DevExpress.DashboardCommon.ChartPane = New DevExpress.DashboardCommon.ChartPane()
            Dim SimpleSeries1 As DevExpress.DashboardCommon.SimpleSeries = New DevExpress.DashboardCommon.SimpleSeries()
            Dim Dimension12 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim Measure2 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
            Dim SimpleSeries2 As DevExpress.DashboardCommon.SimpleSeries = New DevExpress.DashboardCommon.SimpleSeries()
            Dim DashboardLayoutGroup1 As DevExpress.DashboardCommon.DashboardLayoutGroup = New DevExpress.DashboardCommon.DashboardLayoutGroup()
            Dim DashboardLayoutGroup2 As DevExpress.DashboardCommon.DashboardLayoutGroup = New DevExpress.DashboardCommon.DashboardLayoutGroup()
            Dim DashboardLayoutGroup3 As DevExpress.DashboardCommon.DashboardLayoutGroup = New DevExpress.DashboardCommon.DashboardLayoutGroup()
            Dim DashboardLayoutGroup4 As DevExpress.DashboardCommon.DashboardLayoutGroup = New DevExpress.DashboardCommon.DashboardLayoutGroup()
            Dim DashboardLayoutItem1 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
            Dim DashboardLayoutItem2 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
            Dim DashboardLayoutItem3 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
            Dim DashboardLayoutItem4 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
            Dim DashboardLayoutItem5 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
            Me.ListBoxDashboardItem1 = New DevExpress.DashboardCommon.ListBoxDashboardItem()
            Me.DashboardSqlDataSource1 = New DevExpress.DashboardCommon.DashboardSqlDataSource()
            Me.ListBoxDashboardItem3 = New DevExpress.DashboardCommon.ListBoxDashboardItem()
            Me.ListBoxDashboardItem2 = New DevExpress.DashboardCommon.ListBoxDashboardItem()
            Me.ChartDashboardItem1 = New DevExpress.DashboardCommon.ChartDashboardItem()
            Me.RangeFilterDashboardItem1 = New DevExpress.DashboardCommon.RangeFilterDashboardItem()
            CType(Me.ListBoxDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DashboardSqlDataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ListBoxDashboardItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ListBoxDashboardItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ChartDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension7, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension8, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension9, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Measure1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension10, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension11, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RangeFilterDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension12, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Measure2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            '
            'ListBoxDashboardItem1
            '
            Me.ListBoxDashboardItem1.ComponentName = "ListBoxDashboardItem1"
            Dimension1.DataMember = "form_id"
            Dimension2.DataMember = "abreviacion_formulario"
            Dimension2.SortOrder = DevExpress.DashboardCommon.DimensionSortOrder.Descending
            Dimension3.DataMember = "voluntario"
            Me.ListBoxDashboardItem1.DataItemRepository.Clear()
            Me.ListBoxDashboardItem1.DataItemRepository.Add(Dimension1, "DataItem1")
            Me.ListBoxDashboardItem1.DataItemRepository.Add(Dimension2, "DataItem0")
            Me.ListBoxDashboardItem1.DataItemRepository.Add(Dimension3, "DataItem2")
            Me.ListBoxDashboardItem1.DataMember = "Reportes_SSP_Master"
            Me.ListBoxDashboardItem1.DataSource = Me.DashboardSqlDataSource1
            Me.ListBoxDashboardItem1.FilterDimensions.AddRange(New DevExpress.DashboardCommon.Dimension() {Dimension1, Dimension2, Dimension3})
            Me.ListBoxDashboardItem1.InteractivityOptions.IgnoreMasterFilters = True
            Me.ListBoxDashboardItem1.Name = "Formularios"
            Me.ListBoxDashboardItem1.ShowCaption = True
            '
            'DashboardSqlDataSource1
            '
            Me.DashboardSqlDataSource1.ComponentName = "DashboardSqlDataSource1"
            Me.DashboardSqlDataSource1.ConnectionName = "win-sqlserv-02_SSP_BI_Connection"
            Me.DashboardSqlDataSource1.Name = "SQL Data Source 1"
            TableQuery1.Name = "Reportes_SSP_Master"
            RelationInfo1.JoinType = DevExpress.Xpo.DB.JoinType.LeftOuter
            RelationColumnInfo1.NestedKeyColumn = "id"
            RelationColumnInfo1.ParentKeyColumn = "lugar_id"
            RelationInfo1.KeyColumns.AddRange(New DevExpress.DataAccess.Sql.RelationColumnInfo() {RelationColumnInfo1})
            RelationInfo1.NestedTable = "Vista_aeropuertos"
            RelationInfo1.ParentTable = "Reportes_SSP_Master"
            RelationInfo2.JoinType = DevExpress.Xpo.DB.JoinType.LeftOuter
            RelationColumnInfo2.NestedKeyColumn = "id"
            RelationColumnInfo2.ParentKeyColumn = "form_id"
            RelationInfo2.KeyColumns.AddRange(New DevExpress.DataAccess.Sql.RelationColumnInfo() {RelationColumnInfo2})
            RelationInfo2.NestedTable = "Formularios_Descrip"
            RelationInfo2.ParentTable = "Reportes_SSP_Master"
            RelationInfo3.JoinType = DevExpress.Xpo.DB.JoinType.LeftOuter
            RelationColumnInfo3.NestedKeyColumn = "FECHA"
            RelationColumnInfo3.ParentKeyColumn = "date"
            RelationInfo3.KeyColumns.AddRange(New DevExpress.DataAccess.Sql.RelationColumnInfo() {RelationColumnInfo3})
            RelationInfo3.NestedTable = "DIMTIME"
            RelationInfo3.ParentTable = "Reportes_SSP_Master"
            TableQuery1.Relations.AddRange(New DevExpress.DataAccess.Sql.RelationInfo() {RelationInfo1, RelationInfo2, RelationInfo3})
            TableInfo1.Name = "Reportes_SSP_Master"
            ColumnInfo1.Name = "id"
            ColumnInfo2.Name = "form_id"
            ColumnInfo3.Name = "entry_id"
            ColumnInfo4.Name = "entry_date_created"
            ColumnInfo5.Alias = "Reportes_SSP_Master_nombre_formulario"
            ColumnInfo5.Name = "nombre_formulario"
            ColumnInfo6.Name = "fecha_creacion"
            ColumnInfo7.Name = "nombre"
            ColumnInfo8.Name = "email"
            ColumnInfo9.Name = "telefono"
            ColumnInfo10.Name = "ubicacion"
            ColumnInfo11.Name = "lugar"
            ColumnInfo12.Name = "lugar_id"
            ColumnInfo13.Name = "fecha"
            ColumnInfo14.Name = "hora"
            ColumnInfo15.Name = "descripcion"
            ColumnInfo16.Name = "01_02_Explotador"
            ColumnInfo17.Name = "03_04_Marca_Modelo_de_Aeronave"
            ColumnInfo18.Name = "05_06_Marca_Modelo_de_Motor"
            ColumnInfo19.Name = "07_Matricula_de_Aeronave"
            ColumnInfo20.Name = "08_Fecha_del_Choque"
            ColumnInfo21.Name = "08_Fecha"
            ColumnInfo22.Name = "09_Hora"
            ColumnInfo23.Name = "10_Condiciones_de_Luz"
            ColumnInfo24.Name = "11_12_Nombre_del_Aerodromo"
            ColumnInfo25.Name = "11_12_14_Aerodromo_Posicion_si_se_conoce"
            ColumnInfo26.Name = "13_Pista_Utilizada"
            ColumnInfo27.Name = "14_Posicion_si_fue_en_ruta"
            ColumnInfo28.Name = "15_Altura_pies"
            ColumnInfo29.Name = "16_Velocidad_Indicada_nudos"
            ColumnInfo30.Name = "17_Fase_de_vuelo"
            ColumnInfo31.Name = "37_Condiciones_del_Cielo"
            ColumnInfo32.Name = "41_Especie_de_Ave"
            ColumnInfo33.Name = "42_Observadas"
            ColumnInfo34.Name = "43_Golpeadas"
            ColumnInfo35.Name = "44_Tamano_de_las_Aves"
            ColumnInfo36.Name = "45_Se_Advirtio_del_Peligro"
            ColumnInfo37.Name = "46_47_Observaciones"
            ColumnInfo38.Name = "52_Tiempo_Aeronave_Fuera_Servicio"
            ColumnInfo39.Name = "53_Costes_Estimado_para_Reparacion_o_Sustitucion"
            ColumnInfo40.Name = "54_Otros_Costes_Estimados"
            ColumnInfo41.Name = "A1"
            ColumnInfo42.Name = "A2"
            ColumnInfo43.Name = "AD1"
            ColumnInfo44.Name = "AD2"
            ColumnInfo45.Name = "Adjuntar_Archivo"
            ColumnInfo46.Name = "Aerodromo_Destino"
            ColumnInfo47.Name = "Aerodromo_Salida"
            ColumnInfo48.Name = "AI_Motor_1"
            ColumnInfo49.Name = "AI_Motor_2"
            ColumnInfo50.Name = "AS1"
            ColumnInfo51.Name = "AS2"
            ColumnInfo52.Name = "Carga_Trabajo_ATC"
            ColumnInfo53.Name = "Categoria_Vuelo"
            ColumnInfo54.Name = "CCO_ATC"
            ColumnInfo55.Name = "Clase_de_Espacio_Aereo"
            ColumnInfo56.Name = "Condiciones_de_Luz"
            ColumnInfo57.Name = "Condiciones_Meteorologicas_Relevantes"
            ColumnInfo58.Name = "Condiciones_Meteorologicas"
            ColumnInfo59.Name = "CSR1"
            ColumnInfo60.Name = "CSR2"
            ColumnInfo61.Name = "Danadas"
            ColumnInfo62.Name = "Dano_Aeronave"
            ColumnInfo63.Name = "Duracion_Vuelo"
            ColumnInfo64.Name = "Fase_Vuelo"
            ColumnInfo65.Name = "Fatalidad_P"
            ColumnInfo66.Name = "Fatalidad_T"
            ColumnInfo67.Name = "Frecuencia_RTF"
            ColumnInfo68.Name = "Golpeados"
            ColumnInfo69.Name = "Graves_P"
            ColumnInfo70.Name = "Graves_T"
            ColumnInfo71.Name = "Horizontal_(NM)"
            ColumnInfo72.Name = "Jornada_Trabajo"
            ColumnInfo73.Name = "Latitud"
            ColumnInfo74.Name = "Lic_ATC"
            ColumnInfo75.Name = "Longitud"
            ColumnInfo76.Name = "M1"
            ColumnInfo77.Name = "M2"
            ColumnInfo78.Name = "Matricula"
            ColumnInfo79.Name = "Menores_P"
            ColumnInfo80.Name = "Menores_T"
            ColumnInfo81.Name = "Modelo_Matricula"
            ColumnInfo82.Name = "MSAW"
            ColumnInfo83.Name = "MSR1"
            ColumnInfo84.Name = "MSR2"
            ColumnInfo85.Name = "Ninguno_P"
            ColumnInfo86.Name = "Ninguno_T"
            ColumnInfo87.Name = "Nombre_Espacio_Aereo"
            ColumnInfo88.Name = "Nombre_Sector_ATC"
            ColumnInfo89.Name = "Nombre_Unidad_ATS"
            ColumnInfo90.Name = "NV1"
            ColumnInfo91.Name = "NV2"
            ColumnInfo92.Name = "O1"
            ColumnInfo93.Name = "O2"
            ColumnInfo94.Name = "Operador"
            ColumnInfo95.Name = "Otras_Consecuencias_Vuelo"
            ColumnInfo96.Name = "Otras_Danadas"
            ColumnInfo97.Name = "Otras_Golpeadas"
            ColumnInfo98.Name = "Otros_TO"
            ColumnInfo99.Name = "PE_Motor_1"
            ColumnInfo100.Name = "PE_Motor_2"
            ColumnInfo101.Name = "RV1"
            ColumnInfo102.Name = "RV2"
            ColumnInfo103.Name = "Servicio_ATC_Provisto"
            ColumnInfo104.Name = "STCA"
            ColumnInfo105.Name = "Tipo_Espacio_Aereo"
            ColumnInfo106.Name = "Tipo_Informacion_Trafico_Provisto"
            ColumnInfo107.Name = "Tipo_de_Operacion"
            ColumnInfo108.Name = "Tipo_Modulo"
            ColumnInfo109.Name = "V1"
            ColumnInfo110.Name = "V2"
            ColumnInfo111.Name = "Vertical_FT"
            ColumnInfo112.Name = "Validado"
            ColumnInfo113.Name = "date"
            TableInfo1.SelectedColumns.AddRange(New DevExpress.DataAccess.Sql.ColumnInfo() {ColumnInfo1, ColumnInfo2, ColumnInfo3, ColumnInfo4, ColumnInfo5, ColumnInfo6, ColumnInfo7, ColumnInfo8, ColumnInfo9, ColumnInfo10, ColumnInfo11, ColumnInfo12, ColumnInfo13, ColumnInfo14, ColumnInfo15, ColumnInfo16, ColumnInfo17, ColumnInfo18, ColumnInfo19, ColumnInfo20, ColumnInfo21, ColumnInfo22, ColumnInfo23, ColumnInfo24, ColumnInfo25, ColumnInfo26, ColumnInfo27, ColumnInfo28, ColumnInfo29, ColumnInfo30, ColumnInfo31, ColumnInfo32, ColumnInfo33, ColumnInfo34, ColumnInfo35, ColumnInfo36, ColumnInfo37, ColumnInfo38, ColumnInfo39, ColumnInfo40, ColumnInfo41, ColumnInfo42, ColumnInfo43, ColumnInfo44, ColumnInfo45, ColumnInfo46, ColumnInfo47, ColumnInfo48, ColumnInfo49, ColumnInfo50, ColumnInfo51, ColumnInfo52, ColumnInfo53, ColumnInfo54, ColumnInfo55, ColumnInfo56, ColumnInfo57, ColumnInfo58, ColumnInfo59, ColumnInfo60, ColumnInfo61, ColumnInfo62, ColumnInfo63, ColumnInfo64, ColumnInfo65, ColumnInfo66, ColumnInfo67, ColumnInfo68, ColumnInfo69, ColumnInfo70, ColumnInfo71, ColumnInfo72, ColumnInfo73, ColumnInfo74, ColumnInfo75, ColumnInfo76, ColumnInfo77, ColumnInfo78, ColumnInfo79, ColumnInfo80, ColumnInfo81, ColumnInfo82, ColumnInfo83, ColumnInfo84, ColumnInfo85, ColumnInfo86, ColumnInfo87, ColumnInfo88, ColumnInfo89, ColumnInfo90, ColumnInfo91, ColumnInfo92, ColumnInfo93, ColumnInfo94, ColumnInfo95, ColumnInfo96, ColumnInfo97, ColumnInfo98, ColumnInfo99, ColumnInfo100, ColumnInfo101, ColumnInfo102, ColumnInfo103, ColumnInfo104, ColumnInfo105, ColumnInfo106, ColumnInfo107, ColumnInfo108, ColumnInfo109, ColumnInfo110, ColumnInfo111, ColumnInfo112, ColumnInfo113})
            TableInfo2.Name = "Formularios_Descrip"
            ColumnInfo114.Name = "nombre_formulario"
            ColumnInfo115.Name = "abreviacion_formulario"
            ColumnInfo116.Name = "voluntario"
            TableInfo2.SelectedColumns.AddRange(New DevExpress.DataAccess.Sql.ColumnInfo() {ColumnInfo114, ColumnInfo115, ColumnInfo116})
            TableInfo3.Name = "Vista_aeropuertos"
            ColumnInfo117.Alias = "Vista_aeropuertos_id"
            ColumnInfo117.Name = "id"
            ColumnInfo118.Name = "ciudad"
            ColumnInfo119.Name = "pais"
            ColumnInfo120.Name = "aeropuerto"
            ColumnInfo121.Name = "aerodromo"
            ColumnInfo122.Name = "punto_ruta_oaci"
            ColumnInfo123.Name = "punto_ruta_iata"
            ColumnInfo124.Name = "aerop_descrip"
            ColumnInfo125.Name = "latitud"
            ColumnInfo126.Name = "longitud"
            TableInfo3.SelectedColumns.AddRange(New DevExpress.DataAccess.Sql.ColumnInfo() {ColumnInfo117, ColumnInfo118, ColumnInfo119, ColumnInfo120, ColumnInfo121, ColumnInfo122, ColumnInfo123, ColumnInfo124, ColumnInfo125, ColumnInfo126})
            TableInfo4.Name = "DIMTIME"
            ColumnInfo127.Name = "FECHA"
            ColumnInfo128.Name = "DATAKEY"
            ColumnInfo129.Name = "FECHAHORA"
            ColumnInfo130.Name = "ANIO"
            ColumnInfo131.Name = "TRIMESTRE"
            ColumnInfo132.Name = "YEARTRIMESTRE"
            ColumnInfo133.Name = "QUARTER"
            ColumnInfo134.Name = "YEARQUARTER"
            ColumnInfo135.Name = "MES"
            ColumnInfo136.Name = "YEARMONTH"
            ColumnInfo137.Name = "MONTHNAME"
            ColumnInfo138.Name = "SHORTMONTHNAME"
            ColumnInfo139.Name = "WEEK"
            ColumnInfo140.Name = "DAYINYEAR"
            ColumnInfo141.Name = "DAYINMONTH"
            ColumnInfo142.Name = "DAYNAME"
            ColumnInfo143.Name = "SHORTDAYNAME"
            ColumnInfo144.Name = "LASTDAYINMONTH"
            ColumnInfo145.Name = "MONTHYEAR"
            ColumnInfo146.Name = "HOLIDAY"
            ColumnInfo147.Name = "DAYINMONTH_ORD"
            ColumnInfo148.Name = "MES_ORD"
            ColumnInfo149.Name = "SEMANA_ORD"
            TableInfo4.SelectedColumns.AddRange(New DevExpress.DataAccess.Sql.ColumnInfo() {ColumnInfo127, ColumnInfo128, ColumnInfo129, ColumnInfo130, ColumnInfo131, ColumnInfo132, ColumnInfo133, ColumnInfo134, ColumnInfo135, ColumnInfo136, ColumnInfo137, ColumnInfo138, ColumnInfo139, ColumnInfo140, ColumnInfo141, ColumnInfo142, ColumnInfo143, ColumnInfo144, ColumnInfo145, ColumnInfo146, ColumnInfo147, ColumnInfo148, ColumnInfo149})
            TableQuery1.Tables.AddRange(New DevExpress.DataAccess.Sql.TableInfo() {TableInfo1, TableInfo2, TableInfo3, TableInfo4})
            Me.DashboardSqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {TableQuery1})
            Me.DashboardSqlDataSource1.ResultSchemaSerializable = resources.GetString("DashboardSqlDataSource1.ResultSchemaSerializable")
            '
            'ListBoxDashboardItem3
            '
            Me.ListBoxDashboardItem3.ComponentName = "ListBoxDashboardItem3"
            Dimension4.DataMember = "ANIO"
            Dimension4.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.General
            Dimension4.SortOrder = DevExpress.DashboardCommon.DimensionSortOrder.Descending
            Me.ListBoxDashboardItem3.DataItemRepository.Clear()
            Me.ListBoxDashboardItem3.DataItemRepository.Add(Dimension4, "DataItem0")
            Me.ListBoxDashboardItem3.DataMember = "Reportes_SSP_Master"
            Me.ListBoxDashboardItem3.DataSource = Me.DashboardSqlDataSource1
            Me.ListBoxDashboardItem3.FilterDimensions.AddRange(New DevExpress.DashboardCommon.Dimension() {Dimension4})
            Me.ListBoxDashboardItem3.InteractivityOptions.IgnoreMasterFilters = True
            Me.ListBoxDashboardItem3.Name = "Años"
            Me.ListBoxDashboardItem3.ShowCaption = True
            '
            'ListBoxDashboardItem2
            '
            Me.ListBoxDashboardItem2.ComponentName = "ListBoxDashboardItem2"
            Dimension5.DataMember = "ciudad"
            Dimension6.DataMember = "aeropuerto"
            Me.ListBoxDashboardItem2.DataItemRepository.Clear()
            Me.ListBoxDashboardItem2.DataItemRepository.Add(Dimension5, "DataItem0")
            Me.ListBoxDashboardItem2.DataItemRepository.Add(Dimension6, "DataItem1")
            Me.ListBoxDashboardItem2.DataMember = "Reportes_SSP_Master"
            Me.ListBoxDashboardItem2.DataSource = Me.DashboardSqlDataSource1
            Me.ListBoxDashboardItem2.FilterDimensions.AddRange(New DevExpress.DashboardCommon.Dimension() {Dimension5, Dimension6})
            Me.ListBoxDashboardItem2.InteractivityOptions.IgnoreMasterFilters = True
            Me.ListBoxDashboardItem2.Name = "Lugar del Suceso"
            Me.ListBoxDashboardItem2.ShowCaption = True
            '
            'ChartDashboardItem1
            '
            Dimension7.ColoringMode = DevExpress.DashboardCommon.ColoringMode.None
            Dimension7.DataMember = "ANIO"
            Dimension7.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.General
            Dimension8.ColoringMode = DevExpress.DashboardCommon.ColoringMode.None
            Dimension8.DataMember = "MES_ORD"
            Me.ChartDashboardItem1.Arguments.AddRange(New DevExpress.DashboardCommon.Dimension() {Dimension7, Dimension8})
            Me.ChartDashboardItem1.AxisX.TitleVisible = False
            Me.ChartDashboardItem1.ComponentName = "ChartDashboardItem1"
            Dimension9.DataMember = "ANIO"
            Dimension9.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.General
            Measure1.DataMember = "id"
            Measure1.SummaryType = DevExpress.DashboardCommon.SummaryType.Count
            Dimension9.SortByMeasure = Measure1
            Dimension10.ColoringMode = DevExpress.DashboardCommon.ColoringMode.None
            Dimension10.DataMember = "MONTHNAME"
            Dimension10.TextGroupInterval = DevExpress.DashboardCommon.TextGroupInterval.Alphabetical
            Dimension11.DataMember = "MES_ORD"
            Me.ChartDashboardItem1.DataItemRepository.Clear()
            Me.ChartDashboardItem1.DataItemRepository.Add(Dimension9, "DataItem1")
            Me.ChartDashboardItem1.DataItemRepository.Add(Dimension10, "DataItem2")
            Me.ChartDashboardItem1.DataItemRepository.Add(Dimension11, "DataItem3")
            Me.ChartDashboardItem1.DataItemRepository.Add(Dimension8, "DataItem8")
            Me.ChartDashboardItem1.DataItemRepository.Add(Dimension7, "DataItem10")
            Me.ChartDashboardItem1.DataItemRepository.Add(Measure1, "DataItem0")
            Me.ChartDashboardItem1.DataMember = "Reportes_SSP_Master"
            Me.ChartDashboardItem1.DataSource = Me.DashboardSqlDataSource1
            Me.ChartDashboardItem1.InteractivityOptions.IgnoreMasterFilters = False
            Me.ChartDashboardItem1.Legend.Visible = False
            Me.ChartDashboardItem1.Name = "Cantidad de Reportes"
            ChartPane1.Name = "Pane 1"
            ChartPane1.PrimaryAxisY.AlwaysShowZeroLevel = True
            ChartPane1.PrimaryAxisY.ShowGridLines = True
            ChartPane1.PrimaryAxisY.TitleVisible = True
            ChartPane1.SecondaryAxisY.AlwaysShowZeroLevel = True
            ChartPane1.SecondaryAxisY.ShowGridLines = False
            ChartPane1.SecondaryAxisY.TitleVisible = True
            SimpleSeries1.PointLabelOptions.ShowPointLabels = True
            SimpleSeries1.SeriesType = DevExpress.DashboardCommon.SimpleSeriesType.StackedBar
            SimpleSeries1.ShowPointMarkers = True
            SimpleSeries1.AddDataItem("Value", Measure1)
            ChartPane1.Series.AddRange(New DevExpress.DashboardCommon.ChartSeries() {SimpleSeries1})
            Me.ChartDashboardItem1.Panes.AddRange(New DevExpress.DashboardCommon.ChartPane() {ChartPane1})
            Me.ChartDashboardItem1.SeriesDimensions.AddRange(New DevExpress.DashboardCommon.Dimension() {Dimension9, Dimension11, Dimension10})
            Me.ChartDashboardItem1.ShowCaption = True
            '
            'RangeFilterDashboardItem1
            '
            Dimension12.DataMember = "FECHA"
            Dimension12.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.MonthYear
            Me.RangeFilterDashboardItem1.Argument = Dimension12
            Me.RangeFilterDashboardItem1.ComponentName = "RangeFilterDashboardItem1"
            Measure2.DataMember = "id"
            Measure2.SummaryType = DevExpress.DashboardCommon.SummaryType.Count
            Me.RangeFilterDashboardItem1.DataItemRepository.Clear()
            Me.RangeFilterDashboardItem1.DataItemRepository.Add(Measure2, "DataItem0")
            Me.RangeFilterDashboardItem1.DataItemRepository.Add(Dimension12, "DataItem2")
            Me.RangeFilterDashboardItem1.DataMember = "Reportes_SSP_Master"
            Me.RangeFilterDashboardItem1.DataSource = Me.DashboardSqlDataSource1
            Me.RangeFilterDashboardItem1.InteractivityOptions.IgnoreMasterFilters = True
            Me.RangeFilterDashboardItem1.Name = "Range Filter 1"
            SimpleSeries2.SeriesType = DevExpress.DashboardCommon.SimpleSeriesType.Line
            SimpleSeries2.AddDataItem("Value", Measure2)
            Me.RangeFilterDashboardItem1.Series.AddRange(New DevExpress.DashboardCommon.SimpleSeries() {SimpleSeries2})
            Me.RangeFilterDashboardItem1.ShowCaption = False
            '
            'Dashboard1
            '
            Me.DataSources.AddRange(New DevExpress.DashboardCommon.IDashboardDataSource() {Me.DashboardSqlDataSource1})
            Me.Items.AddRange(New DevExpress.DashboardCommon.DashboardItem() {Me.ListBoxDashboardItem1, Me.ChartDashboardItem1, Me.ListBoxDashboardItem2, Me.ListBoxDashboardItem3, Me.RangeFilterDashboardItem1})
            DashboardLayoutItem1.DashboardItem = Me.ListBoxDashboardItem1
            DashboardLayoutItem1.Weight = 50.0R
            DashboardLayoutItem2.DashboardItem = Me.ListBoxDashboardItem3
            DashboardLayoutItem2.Weight = 50.0R
            DashboardLayoutGroup4.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() {DashboardLayoutItem1, DashboardLayoutItem2})
            DashboardLayoutGroup4.DashboardItem = Nothing
            DashboardLayoutGroup4.Weight = 34.444444444444443R
            DashboardLayoutItem3.DashboardItem = Me.ListBoxDashboardItem2
            DashboardLayoutItem3.Weight = 65.555555555555557R
            DashboardLayoutGroup3.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() {DashboardLayoutGroup4, DashboardLayoutItem3})
            DashboardLayoutGroup3.DashboardItem = Nothing
            DashboardLayoutGroup3.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical
            DashboardLayoutGroup3.Weight = 50.0R
            DashboardLayoutItem4.DashboardItem = Me.ChartDashboardItem1
            DashboardLayoutItem4.Weight = 50.0R
            DashboardLayoutGroup2.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() {DashboardLayoutGroup3, DashboardLayoutItem4})
            DashboardLayoutGroup2.DashboardItem = Nothing
            DashboardLayoutGroup2.Weight = 85.918854415274467R
            DashboardLayoutItem5.DashboardItem = Me.RangeFilterDashboardItem1
            DashboardLayoutItem5.Weight = 14.081145584725537R
            DashboardLayoutGroup1.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() {DashboardLayoutGroup2, DashboardLayoutItem5})
            DashboardLayoutGroup1.DashboardItem = Nothing
            DashboardLayoutGroup1.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical
            Me.LayoutRoot = DashboardLayoutGroup1
            Me.Title.Text = "Dashboard"
            CType(Dimension1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ListBoxDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DashboardSqlDataSource1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ListBoxDashboardItem3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ListBoxDashboardItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension7, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension8, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Measure1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension9, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension10, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension11, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ChartDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension12, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Measure2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RangeFilterDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub
        Friend WithEvents DashboardSqlDataSource1 As DevExpress.DashboardCommon.DashboardSqlDataSource
        Friend WithEvents ListBoxDashboardItem1 As DevExpress.DashboardCommon.ListBoxDashboardItem
        Friend WithEvents ChartDashboardItem1 As DevExpress.DashboardCommon.ChartDashboardItem
        Friend WithEvents ListBoxDashboardItem2 As DevExpress.DashboardCommon.ListBoxDashboardItem
        Friend WithEvents ListBoxDashboardItem3 As DevExpress.DashboardCommon.ListBoxDashboardItem
        Friend WithEvents RangeFilterDashboardItem1 As DevExpress.DashboardCommon.RangeFilterDashboardItem

#End Region
    End Class
End Namespace