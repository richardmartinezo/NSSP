Namespace Win_Dashboards
    Partial Public Class Dashboard3
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
            Dim TableQuery1 As DevExpress.DataAccess.Sql.TableQuery = New DevExpress.DataAccess.Sql.TableQuery()
            Dim RelationInfo1 As DevExpress.DataAccess.Sql.RelationInfo = New DevExpress.DataAccess.Sql.RelationInfo()
            Dim RelationColumnInfo1 As DevExpress.DataAccess.Sql.RelationColumnInfo = New DevExpress.DataAccess.Sql.RelationColumnInfo()
            Dim RelationInfo2 As DevExpress.DataAccess.Sql.RelationInfo = New DevExpress.DataAccess.Sql.RelationInfo()
            Dim RelationColumnInfo2 As DevExpress.DataAccess.Sql.RelationColumnInfo = New DevExpress.DataAccess.Sql.RelationColumnInfo()
            Dim RelationInfo3 As DevExpress.DataAccess.Sql.RelationInfo = New DevExpress.DataAccess.Sql.RelationInfo()
            Dim RelationColumnInfo3 As DevExpress.DataAccess.Sql.RelationColumnInfo = New DevExpress.DataAccess.Sql.RelationColumnInfo()
            Dim RelationInfo4 As DevExpress.DataAccess.Sql.RelationInfo = New DevExpress.DataAccess.Sql.RelationInfo()
            Dim RelationColumnInfo4 As DevExpress.DataAccess.Sql.RelationColumnInfo = New DevExpress.DataAccess.Sql.RelationColumnInfo()
            Dim RelationInfo5 As DevExpress.DataAccess.Sql.RelationInfo = New DevExpress.DataAccess.Sql.RelationInfo()
            Dim RelationColumnInfo5 As DevExpress.DataAccess.Sql.RelationColumnInfo = New DevExpress.DataAccess.Sql.RelationColumnInfo()
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
            Dim TableInfo2 As DevExpress.DataAccess.Sql.TableInfo = New DevExpress.DataAccess.Sql.TableInfo()
            Dim ColumnInfo12 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo13 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim TableInfo3 As DevExpress.DataAccess.Sql.TableInfo = New DevExpress.DataAccess.Sql.TableInfo()
            Dim ColumnInfo14 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo15 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim TableInfo4 As DevExpress.DataAccess.Sql.TableInfo = New DevExpress.DataAccess.Sql.TableInfo()
            Dim ColumnInfo16 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo17 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim TableInfo5 As DevExpress.DataAccess.Sql.TableInfo = New DevExpress.DataAccess.Sql.TableInfo()
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
            Dim TableInfo6 As DevExpress.DataAccess.Sql.TableInfo = New DevExpress.DataAccess.Sql.TableInfo()
            Dim ColumnInfo32 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo33 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo34 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim ColumnInfo35 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard3))
            Dim Dimension3 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim Dimension4 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim Dimension5 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim GridDimensionColumn1 As DevExpress.DashboardCommon.GridDimensionColumn = New DevExpress.DashboardCommon.GridDimensionColumn()
            Dim Dimension6 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim GridDimensionColumn2 As DevExpress.DashboardCommon.GridDimensionColumn = New DevExpress.DashboardCommon.GridDimensionColumn()
            Dim Dimension7 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim GridDimensionColumn3 As DevExpress.DashboardCommon.GridDimensionColumn = New DevExpress.DashboardCommon.GridDimensionColumn()
            Dim Dimension8 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim GridDimensionColumn4 As DevExpress.DashboardCommon.GridDimensionColumn = New DevExpress.DashboardCommon.GridDimensionColumn()
            Dim Dimension9 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim GridDimensionColumn5 As DevExpress.DashboardCommon.GridDimensionColumn = New DevExpress.DashboardCommon.GridDimensionColumn()
            Dim Dimension10 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim GridDimensionColumn6 As DevExpress.DashboardCommon.GridDimensionColumn = New DevExpress.DashboardCommon.GridDimensionColumn()
            Dim Dimension11 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim Dimension12 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim Measure1 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
            Dim ChartPane1 As DevExpress.DashboardCommon.ChartPane = New DevExpress.DashboardCommon.ChartPane()
            Dim SimpleSeries1 As DevExpress.DashboardCommon.SimpleSeries = New DevExpress.DashboardCommon.SimpleSeries()
            Dim Dimension13 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim Measure2 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
            Dim Dimension14 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim ChartPane2 As DevExpress.DashboardCommon.ChartPane = New DevExpress.DashboardCommon.ChartPane()
            Dim SimpleSeries2 As DevExpress.DashboardCommon.SimpleSeries = New DevExpress.DashboardCommon.SimpleSeries()
            Dim DashboardLayoutGroup1 As DevExpress.DashboardCommon.DashboardLayoutGroup = New DevExpress.DashboardCommon.DashboardLayoutGroup()
            Dim DashboardLayoutGroup2 As DevExpress.DashboardCommon.DashboardLayoutGroup = New DevExpress.DashboardCommon.DashboardLayoutGroup()
            Dim DashboardLayoutGroup3 As DevExpress.DashboardCommon.DashboardLayoutGroup = New DevExpress.DashboardCommon.DashboardLayoutGroup()
            Dim DashboardLayoutItem1 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
            Dim DashboardLayoutItem2 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
            Dim DashboardLayoutItem3 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
            Dim DashboardLayoutItem4 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
            Dim DashboardLayoutGroup4 As DevExpress.DashboardCommon.DashboardLayoutGroup = New DevExpress.DashboardCommon.DashboardLayoutGroup()
            Dim DashboardLayoutItem5 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
            Dim DashboardLayoutItem6 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
            Me.ListBoxDashboardItem1 = New DevExpress.DashboardCommon.ListBoxDashboardItem()
            Me.DashboardSqlDataSource1 = New DevExpress.DashboardCommon.DashboardSqlDataSource()
            Me.ListBoxDashboardItem2 = New DevExpress.DashboardCommon.ListBoxDashboardItem()
            Me.ListBoxDashboardItem3 = New DevExpress.DashboardCommon.ListBoxDashboardItem()
            Me.GridDashboardItem1 = New DevExpress.DashboardCommon.GridDashboardItem()
            Me.ChartDashboardItem1 = New DevExpress.DashboardCommon.ChartDashboardItem()
            Me.ChartDashboardItem2 = New DevExpress.DashboardCommon.ChartDashboardItem()
            CType(Me.ListBoxDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DashboardSqlDataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ListBoxDashboardItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ListBoxDashboardItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension7, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension8, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension9, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension10, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ChartDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension11, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension12, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Measure1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ChartDashboardItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension13, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Measure2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Dimension14, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            '
            'ListBoxDashboardItem1
            '
            Me.ListBoxDashboardItem1.ComponentName = "ListBoxDashboardItem1"
            Dimension1.DataMember = "punto_ruta_oaci"
            Dimension2.DataMember = "aerodromo"
            Me.ListBoxDashboardItem1.DataItemRepository.Clear()
            Me.ListBoxDashboardItem1.DataItemRepository.Add(Dimension1, "DataItem0")
            Me.ListBoxDashboardItem1.DataItemRepository.Add(Dimension2, "DataItem1")
            Me.ListBoxDashboardItem1.DataMember = "Reportes_SSP_Master"
            Me.ListBoxDashboardItem1.DataSource = Me.DashboardSqlDataSource1
            Me.ListBoxDashboardItem1.FilterDimensions.AddRange(New DevExpress.DashboardCommon.Dimension() {Dimension1, Dimension2})
            Me.ListBoxDashboardItem1.InteractivityOptions.IgnoreMasterFilters = True
            Me.ListBoxDashboardItem1.Name = "Aerodromos"
            Me.ListBoxDashboardItem1.ShowCaption = True
            '
            'DashboardSqlDataSource1
            '
            Me.DashboardSqlDataSource1.ComponentName = "DashboardSqlDataSource1"
            Me.DashboardSqlDataSource1.ConnectionName = "win-sqlserv-02_SSP_BI_Connection"
            Me.DashboardSqlDataSource1.Name = "SQL Data Source SSP"
            TableQuery1.Name = "Reportes_SSP_Master"
            RelationInfo1.JoinType = DevExpress.Xpo.DB.JoinType.LeftOuter
            RelationColumnInfo1.NestedKeyColumn = "id"
            RelationColumnInfo1.ParentKeyColumn = "lugar_id"
            RelationInfo1.KeyColumns.AddRange(New DevExpress.DataAccess.Sql.RelationColumnInfo() {RelationColumnInfo1})
            RelationInfo1.NestedTable = "Vista_aeropuertos"
            RelationInfo1.ParentTable = "Reportes_SSP_Master"
            RelationInfo2.JoinType = DevExpress.Xpo.DB.JoinType.LeftOuter
            RelationColumnInfo2.NestedKeyColumn = "id"
            RelationColumnInfo2.ParentKeyColumn = "Estado"
            RelationInfo2.KeyColumns.AddRange(New DevExpress.DataAccess.Sql.RelationColumnInfo() {RelationColumnInfo2})
            RelationInfo2.NestedTable = "Estado"
            RelationInfo2.ParentTable = "Reportes_SSP_Master"
            RelationInfo3.JoinType = DevExpress.Xpo.DB.JoinType.LeftOuter
            RelationColumnInfo3.NestedKeyColumn = "Id"
            RelationColumnInfo3.ParentKeyColumn = "id_categorias"
            RelationInfo3.KeyColumns.AddRange(New DevExpress.DataAccess.Sql.RelationColumnInfo() {RelationColumnInfo3})
            RelationInfo3.NestedTable = "Categorias"
            RelationInfo3.ParentTable = "Reportes_SSP_Master"
            RelationInfo4.JoinType = DevExpress.Xpo.DB.JoinType.LeftOuter
            RelationColumnInfo4.NestedKeyColumn = "FECHA"
            RelationColumnInfo4.ParentKeyColumn = "date"
            RelationInfo4.KeyColumns.AddRange(New DevExpress.DataAccess.Sql.RelationColumnInfo() {RelationColumnInfo4})
            RelationInfo4.NestedTable = "DIMTIME"
            RelationInfo4.ParentTable = "Reportes_SSP_Master"
            RelationColumnInfo5.NestedKeyColumn = "id"
            RelationColumnInfo5.ParentKeyColumn = "form_id"
            RelationInfo5.KeyColumns.AddRange(New DevExpress.DataAccess.Sql.RelationColumnInfo() {RelationColumnInfo5})
            RelationInfo5.NestedTable = "Formularios_Descrip"
            RelationInfo5.ParentTable = "Reportes_SSP_Master"
            TableQuery1.Relations.AddRange(New DevExpress.DataAccess.Sql.RelationInfo() {RelationInfo1, RelationInfo2, RelationInfo3, RelationInfo4, RelationInfo5})
            TableInfo1.Name = "Reportes_SSP_Master"
            ColumnInfo1.Name = "entry_id"
            ColumnInfo2.Name = "email"
            ColumnInfo3.Name = "nombre"
            ColumnInfo4.Name = "telefono"
            ColumnInfo5.Name = "ubicacion"
            ColumnInfo6.Name = "nombre_formulario"
            ColumnInfo7.Name = "descripcion"
            ColumnInfo8.Name = "Estado"
            ColumnInfo9.Name = "id_categorias"
            ColumnInfo10.Name = "id"
            ColumnInfo11.Name = "form_id"
            TableInfo1.SelectedColumns.AddRange(New DevExpress.DataAccess.Sql.ColumnInfo() {ColumnInfo1, ColumnInfo2, ColumnInfo3, ColumnInfo4, ColumnInfo5, ColumnInfo6, ColumnInfo7, ColumnInfo8, ColumnInfo9, ColumnInfo10, ColumnInfo11})
            TableInfo2.Name = "Vista_aeropuertos"
            ColumnInfo12.Name = "punto_ruta_oaci"
            ColumnInfo13.Name = "aerodromo"
            TableInfo2.SelectedColumns.AddRange(New DevExpress.DataAccess.Sql.ColumnInfo() {ColumnInfo12, ColumnInfo13})
            TableInfo3.Name = "Estado"
            ColumnInfo14.Alias = "Estado_Estado"
            ColumnInfo14.Name = "Estado"
            ColumnInfo15.Name = "Descripcion"
            TableInfo3.SelectedColumns.AddRange(New DevExpress.DataAccess.Sql.ColumnInfo() {ColumnInfo14, ColumnInfo15})
            TableInfo4.Name = "Categorias"
            ColumnInfo16.Name = "Cat_Abreviacion"
            ColumnInfo17.Name = "Categoria"
            TableInfo4.SelectedColumns.AddRange(New DevExpress.DataAccess.Sql.ColumnInfo() {ColumnInfo16, ColumnInfo17})
            TableInfo5.Name = "DIMTIME"
            ColumnInfo18.Name = "FECHA"
            ColumnInfo19.Name = "ANIO"
            ColumnInfo20.Name = "TRIMESTRE"
            ColumnInfo21.Name = "QUARTER"
            ColumnInfo22.Name = "YEARTRIMESTRE"
            ColumnInfo23.Name = "MES"
            ColumnInfo24.Name = "YEARMONTH"
            ColumnInfo25.Name = "MONTHNAME"
            ColumnInfo26.Name = "MES_ORD"
            ColumnInfo27.Name = "SEMANA_ORD"
            ColumnInfo28.Name = "DAYNAME"
            ColumnInfo29.Name = "DAYINMONTH"
            ColumnInfo30.Name = "DAYINYEAR"
            ColumnInfo31.Name = "WEEK"
            TableInfo5.SelectedColumns.AddRange(New DevExpress.DataAccess.Sql.ColumnInfo() {ColumnInfo18, ColumnInfo19, ColumnInfo20, ColumnInfo21, ColumnInfo22, ColumnInfo23, ColumnInfo24, ColumnInfo25, ColumnInfo26, ColumnInfo27, ColumnInfo28, ColumnInfo29, ColumnInfo30, ColumnInfo31})
            TableInfo6.Name = "Formularios_Descrip"
            ColumnInfo32.Alias = "Formularios_Descrip_nombre_formulario"
            ColumnInfo32.Name = "nombre_formulario"
            ColumnInfo33.Name = "abreviacion_formulario"
            ColumnInfo34.Alias = "Formularios_Descrip_descripcion"
            ColumnInfo34.Name = "descripcion"
            ColumnInfo35.Name = "voluntario"
            TableInfo6.SelectedColumns.AddRange(New DevExpress.DataAccess.Sql.ColumnInfo() {ColumnInfo32, ColumnInfo33, ColumnInfo34, ColumnInfo35})
            TableQuery1.Tables.AddRange(New DevExpress.DataAccess.Sql.TableInfo() {TableInfo1, TableInfo2, TableInfo3, TableInfo4, TableInfo5, TableInfo6})
            Me.DashboardSqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {TableQuery1})
            Me.DashboardSqlDataSource1.ResultSchemaSerializable = resources.GetString("DashboardSqlDataSource1.ResultSchemaSerializable")
            '
            'ListBoxDashboardItem2
            '
            Me.ListBoxDashboardItem2.ComponentName = "ListBoxDashboardItem2"
            Dimension3.DataMember = "abreviacion_formulario"
            Me.ListBoxDashboardItem2.DataItemRepository.Clear()
            Me.ListBoxDashboardItem2.DataItemRepository.Add(Dimension3, "DataItem0")
            Me.ListBoxDashboardItem2.DataMember = "Reportes_SSP_Master"
            Me.ListBoxDashboardItem2.DataSource = Me.DashboardSqlDataSource1
            Me.ListBoxDashboardItem2.FilterDimensions.AddRange(New DevExpress.DashboardCommon.Dimension() {Dimension3})
            Me.ListBoxDashboardItem2.InteractivityOptions.IgnoreMasterFilters = True
            Me.ListBoxDashboardItem2.Name = "Reportes"
            Me.ListBoxDashboardItem2.ShowCaption = True
            '
            'ListBoxDashboardItem3
            '
            Me.ListBoxDashboardItem3.ComponentName = "ListBoxDashboardItem3"
            Dimension4.DataMember = "ANIO"
            Dimension4.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.General
            Me.ListBoxDashboardItem3.DataItemRepository.Clear()
            Me.ListBoxDashboardItem3.DataItemRepository.Add(Dimension4, "DataItem0")
            Me.ListBoxDashboardItem3.DataMember = "Reportes_SSP_Master"
            Me.ListBoxDashboardItem3.DataSource = Me.DashboardSqlDataSource1
            Me.ListBoxDashboardItem3.FilterDimensions.AddRange(New DevExpress.DashboardCommon.Dimension() {Dimension4})
            Me.ListBoxDashboardItem3.InteractivityOptions.IgnoreMasterFilters = True
            Me.ListBoxDashboardItem3.Name = "Años"
            Me.ListBoxDashboardItem3.ShowCaption = True
            '
            'GridDashboardItem1
            '
            Dimension5.DataMember = "entry_id"
            GridDimensionColumn1.Weight = 19.95967741935484R
            GridDimensionColumn1.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight
            GridDimensionColumn1.AddDataItem("Dimension", Dimension5)
            Dimension6.DataMember = "nombre_formulario"
            GridDimensionColumn2.Weight = 84.979838709677423R
            GridDimensionColumn2.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight
            GridDimensionColumn2.AddDataItem("Dimension", Dimension6)
            Dimension7.DataMember = "aerodromo"
            GridDimensionColumn3.Weight = 120.06048387096774R
            GridDimensionColumn3.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight
            GridDimensionColumn3.AddDataItem("Dimension", Dimension7)
            Dimension8.DataMember = "Estado_Estado"
            GridDimensionColumn4.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight
            GridDimensionColumn4.AddDataItem("Dimension", Dimension8)
            Dimension9.DataMember = "Cat_Abreviacion"
            GridDimensionColumn5.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight
            GridDimensionColumn5.AddDataItem("Dimension", Dimension9)
            Dimension10.DataMember = "Categoria"
            GridDimensionColumn6.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight
            GridDimensionColumn6.AddDataItem("Dimension", Dimension10)
            Me.GridDashboardItem1.Columns.AddRange(New DevExpress.DashboardCommon.GridColumnBase() {GridDimensionColumn1, GridDimensionColumn2, GridDimensionColumn3, GridDimensionColumn4, GridDimensionColumn5, GridDimensionColumn6})
            Me.GridDashboardItem1.ComponentName = "GridDashboardItem1"
            Me.GridDashboardItem1.DataItemRepository.Clear()
            Me.GridDashboardItem1.DataItemRepository.Add(Dimension5, "DataItem1")
            Me.GridDashboardItem1.DataItemRepository.Add(Dimension6, "DataItem0")
            Me.GridDashboardItem1.DataItemRepository.Add(Dimension7, "DataItem2")
            Me.GridDashboardItem1.DataItemRepository.Add(Dimension8, "DataItem3")
            Me.GridDashboardItem1.DataItemRepository.Add(Dimension9, "DataItem4")
            Me.GridDashboardItem1.DataItemRepository.Add(Dimension10, "DataItem5")
            Me.GridDashboardItem1.DataMember = "Reportes_SSP_Master"
            Me.GridDashboardItem1.DataSource = Me.DashboardSqlDataSource1
            Me.GridDashboardItem1.GridOptions.ColumnWidthMode = DevExpress.DashboardCommon.GridColumnWidthMode.Manual
            Me.GridDashboardItem1.InteractivityOptions.IgnoreMasterFilters = False
            Me.GridDashboardItem1.Name = "Descripcion Formularios"
            Me.GridDashboardItem1.ShowCaption = True
            '
            'ChartDashboardItem1
            '
            Dimension11.ColoringMode = DevExpress.DashboardCommon.ColoringMode.Hue
            Dimension11.DataMember = "ANIO"
            Dimension11.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.General
            Dimension12.DataMember = "MES_ORD"
            Me.ChartDashboardItem1.Arguments.AddRange(New DevExpress.DashboardCommon.Dimension() {Dimension11, Dimension12})
            Me.ChartDashboardItem1.AxisX.TitleVisible = False
            Me.ChartDashboardItem1.ComponentName = "ChartDashboardItem1"
            Measure1.DataMember = "entry_id"
            Measure1.SummaryType = DevExpress.DashboardCommon.SummaryType.Count
            Me.ChartDashboardItem1.DataItemRepository.Clear()
            Me.ChartDashboardItem1.DataItemRepository.Add(Measure1, "DataItem0")
            Me.ChartDashboardItem1.DataItemRepository.Add(Dimension12, "DataItem1")
            Me.ChartDashboardItem1.DataItemRepository.Add(Dimension11, "DataItem2")
            Me.ChartDashboardItem1.DataMember = "Reportes_SSP_Master"
            Me.ChartDashboardItem1.DataSource = Me.DashboardSqlDataSource1
            Me.ChartDashboardItem1.InteractivityOptions.IgnoreMasterFilters = False
            Me.ChartDashboardItem1.Name = "Reportes de Inicidentes"
            ChartPane1.Name = "Pane 1"
            ChartPane1.PrimaryAxisY.AlwaysShowZeroLevel = True
            ChartPane1.PrimaryAxisY.ShowGridLines = True
            ChartPane1.PrimaryAxisY.TitleVisible = True
            ChartPane1.SecondaryAxisY.AlwaysShowZeroLevel = True
            ChartPane1.SecondaryAxisY.ShowGridLines = False
            ChartPane1.SecondaryAxisY.TitleVisible = True
            SimpleSeries1.AddDataItem("Value", Measure1)
            ChartPane1.Series.AddRange(New DevExpress.DashboardCommon.ChartSeries() {SimpleSeries1})
            Me.ChartDashboardItem1.Panes.AddRange(New DevExpress.DashboardCommon.ChartPane() {ChartPane1})
            Me.ChartDashboardItem1.ShowCaption = True
            '
            'ChartDashboardItem2
            '
            Dimension13.ColoringMode = DevExpress.DashboardCommon.ColoringMode.Hue
            Dimension13.DataMember = "SEMANA_ORD"
            Me.ChartDashboardItem2.Arguments.AddRange(New DevExpress.DashboardCommon.Dimension() {Dimension13})
            Me.ChartDashboardItem2.AxisX.TitleVisible = False
            Me.ChartDashboardItem2.ComponentName = "ChartDashboardItem2"
            Measure2.DataMember = "entry_id"
            Measure2.SummaryType = DevExpress.DashboardCommon.SummaryType.Count
            Dimension14.DataMember = "ANIO"
            Dimension14.NumericFormat.FormatType = DevExpress.DashboardCommon.DataItemNumericFormatType.General
            Me.ChartDashboardItem2.DataItemRepository.Clear()
            Me.ChartDashboardItem2.DataItemRepository.Add(Measure2, "DataItem0")
            Me.ChartDashboardItem2.DataItemRepository.Add(Dimension13, "DataItem1")
            Me.ChartDashboardItem2.DataItemRepository.Add(Dimension14, "DataItem2")
            Me.ChartDashboardItem2.DataMember = "Reportes_SSP_Master"
            Me.ChartDashboardItem2.DataSource = Me.DashboardSqlDataSource1
            Me.ChartDashboardItem2.InteractivityOptions.IgnoreMasterFilters = False
            Me.ChartDashboardItem2.Name = "Reportes de Inicidentes"
            ChartPane2.Name = "Pane 1"
            ChartPane2.PrimaryAxisY.AlwaysShowZeroLevel = True
            ChartPane2.PrimaryAxisY.ShowGridLines = True
            ChartPane2.PrimaryAxisY.TitleVisible = True
            ChartPane2.SecondaryAxisY.AlwaysShowZeroLevel = True
            ChartPane2.SecondaryAxisY.ShowGridLines = False
            ChartPane2.SecondaryAxisY.TitleVisible = True
            SimpleSeries2.AddDataItem("Value", Measure2)
            ChartPane2.Series.AddRange(New DevExpress.DashboardCommon.ChartSeries() {SimpleSeries2})
            Me.ChartDashboardItem2.Panes.AddRange(New DevExpress.DashboardCommon.ChartPane() {ChartPane2})
            Me.ChartDashboardItem2.SeriesDimensions.AddRange(New DevExpress.DashboardCommon.Dimension() {Dimension14})
            Me.ChartDashboardItem2.ShowCaption = True
            '
            'Dashboard3
            '
            Me.DataSources.AddRange(New DevExpress.DashboardCommon.IDashboardDataSource() {Me.DashboardSqlDataSource1})
            Me.Items.AddRange(New DevExpress.DashboardCommon.DashboardItem() {Me.GridDashboardItem1, Me.ListBoxDashboardItem1, Me.ListBoxDashboardItem2, Me.ChartDashboardItem1, Me.ChartDashboardItem2, Me.ListBoxDashboardItem3})
            DashboardLayoutItem1.DashboardItem = Me.ListBoxDashboardItem1
            DashboardLayoutItem1.Weight = 56.849315068493148R
            DashboardLayoutItem2.DashboardItem = Me.ListBoxDashboardItem2
            DashboardLayoutItem2.Weight = 21.575342465753426R
            DashboardLayoutItem3.DashboardItem = Me.ListBoxDashboardItem3
            DashboardLayoutItem3.Weight = 21.575342465753426R
            DashboardLayoutGroup3.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() {DashboardLayoutItem1, DashboardLayoutItem2, DashboardLayoutItem3})
            DashboardLayoutGroup3.DashboardItem = Nothing
            DashboardLayoutGroup3.Weight = 33.057851239669418R
            DashboardLayoutItem4.DashboardItem = Me.GridDashboardItem1
            DashboardLayoutItem4.Weight = 66.942148760330582R
            DashboardLayoutGroup2.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() {DashboardLayoutGroup3, DashboardLayoutItem4})
            DashboardLayoutGroup2.DashboardItem = Nothing
            DashboardLayoutGroup2.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical
            DashboardLayoutGroup2.Weight = 37.971391417425231R
            DashboardLayoutItem5.DashboardItem = Me.ChartDashboardItem1
            DashboardLayoutItem5.Weight = 55.991735537190081R
            DashboardLayoutItem6.DashboardItem = Me.ChartDashboardItem2
            DashboardLayoutItem6.Weight = 44.008264462809919R
            DashboardLayoutGroup4.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() {DashboardLayoutItem5, DashboardLayoutItem6})
            DashboardLayoutGroup4.DashboardItem = Nothing
            DashboardLayoutGroup4.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical
            DashboardLayoutGroup4.Weight = 62.028608582574769R
            DashboardLayoutGroup1.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() {DashboardLayoutGroup2, DashboardLayoutGroup4})
            DashboardLayoutGroup1.DashboardItem = Nothing
            Me.LayoutRoot = DashboardLayoutGroup1
            Me.Title.Text = "Dashboard"
            CType(Dimension1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ListBoxDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DashboardSqlDataSource1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ListBoxDashboardItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ListBoxDashboardItem3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension7, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension8, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension9, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension10, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension11, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension12, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Measure1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ChartDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension13, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Measure2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Dimension14, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ChartDashboardItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub
        Friend WithEvents DashboardSqlDataSource1 As DevExpress.DashboardCommon.DashboardSqlDataSource
        Friend WithEvents GridDashboardItem1 As DevExpress.DashboardCommon.GridDashboardItem
        Friend WithEvents ListBoxDashboardItem1 As DevExpress.DashboardCommon.ListBoxDashboardItem
        Friend WithEvents ListBoxDashboardItem2 As DevExpress.DashboardCommon.ListBoxDashboardItem
        Friend WithEvents ChartDashboardItem1 As DevExpress.DashboardCommon.ChartDashboardItem
        Friend WithEvents ChartDashboardItem2 As DevExpress.DashboardCommon.ChartDashboardItem
        Friend WithEvents ListBoxDashboardItem3 As DevExpress.DashboardCommon.ListBoxDashboardItem

#End Region
    End Class
End Namespace