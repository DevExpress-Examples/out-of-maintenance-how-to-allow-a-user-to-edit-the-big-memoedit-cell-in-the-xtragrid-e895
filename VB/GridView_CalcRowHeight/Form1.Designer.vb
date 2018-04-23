Imports Microsoft.VisualBasic
Imports System
Namespace GridView_CalcRowHeight
	Partial Public Class Form1
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

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim gridLevelNode1 As New DevExpress.XtraGrid.GridLevelNode()
			Me.gridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.gridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.repositoryItemMemoEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.dataSet1 = New System.Data.DataSet()
			Me.dataTable1 = New System.Data.DataTable()
			Me.dataColumn1 = New System.Data.DataColumn()
			Me.dataTable2 = New System.Data.DataTable()
			Me.dataColumn2 = New System.Data.DataColumn()
			Me.dataColumn3 = New System.Data.DataColumn()
			Me.dataColumn4 = New System.Data.DataColumn()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.gridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.repositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
			CType(Me.gridView2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemMemoEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dataTable2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridView2
			' 
			Me.gridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.gridColumn2, Me.gridColumn3, Me.gridColumn4})
			Me.gridView2.GridControl = Me.gridControl1
			Me.gridView2.Name = "gridView2"
			Me.gridView2.OptionsView.RowAutoHeight = True
'			Me.gridView2.CalcRowHeight += New DevExpress.XtraGrid.Views.Grid.RowHeightEventHandler(Me.gridView1_CalcRowHeight);
			' 
			' gridColumn2
			' 
			Me.gridColumn2.Caption = "gridColumn2"
			Me.gridColumn2.FieldName = "I"
			Me.gridColumn2.Name = "gridColumn2"
			' 
			' gridColumn3
			' 
			Me.gridColumn3.Caption = "gridColumn3"
			Me.gridColumn3.FieldName = "P"
			Me.gridColumn3.Name = "gridColumn3"
			' 
			' gridColumn4
			' 
			Me.gridColumn4.Caption = "gridColumn4"
			Me.gridColumn4.ColumnEdit = Me.repositoryItemMemoEdit2
			Me.gridColumn4.FieldName = "T"
			Me.gridColumn4.Name = "gridColumn4"
			Me.gridColumn4.Visible = True
			Me.gridColumn4.VisibleIndex = 0
			' 
			' repositoryItemMemoEdit2
			' 
			Me.repositoryItemMemoEdit2.Name = "repositoryItemMemoEdit2"
			' 
			' gridControl1
			' 
			Me.gridControl1.DataMember = "Parent"
			Me.gridControl1.DataSource = Me.dataSet1
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			gridLevelNode1.LevelTemplate = Me.gridView2
			gridLevelNode1.RelationName = "Relation1"
			Me.gridControl1.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() { gridLevelNode1})
			Me.gridControl1.Location = New System.Drawing.Point(0, 0)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemMemoEdit1, Me.repositoryItemMemoEdit2})
			Me.gridControl1.Size = New System.Drawing.Size(405, 354)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1, Me.gridView2})
			' 
			' dataSet1
			' 
			Me.dataSet1.DataSetName = "NewDataSet"
			Me.dataSet1.Relations.AddRange(New System.Data.DataRelation() { New System.Data.DataRelation("Relation1", "Parent", "Child", New String() { "I"}, New String() { "P"}, False)})
			Me.dataSet1.Tables.AddRange(New System.Data.DataTable() { Me.dataTable1, Me.dataTable2})
			' 
			' dataTable1
			' 
			Me.dataTable1.Columns.AddRange(New System.Data.DataColumn() { Me.dataColumn1})
			Me.dataTable1.Constraints.AddRange(New System.Data.Constraint() { New System.Data.UniqueConstraint("Constraint1", New String() { "I"}, True)})
			Me.dataTable1.PrimaryKey = New System.Data.DataColumn() { Me.dataColumn1}
			Me.dataTable1.TableName = "Parent"
			' 
			' dataColumn1
			' 
			Me.dataColumn1.AllowDBNull = False
			Me.dataColumn1.AutoIncrement = True
			Me.dataColumn1.ColumnName = "I"
			Me.dataColumn1.DataType = GetType(Integer)
			' 
			' dataTable2
			' 
			Me.dataTable2.Columns.AddRange(New System.Data.DataColumn() { Me.dataColumn2, Me.dataColumn3, Me.dataColumn4})
			Me.dataTable2.Constraints.AddRange(New System.Data.Constraint() { New System.Data.UniqueConstraint("Constraint1", New String() { "I"}, True), New System.Data.ForeignKeyConstraint("Relation1", "Parent", New String() { "I"}, New String() { "P"}, System.Data.AcceptRejectRule.None, System.Data.Rule.Cascade, System.Data.Rule.Cascade)})
			Me.dataTable2.PrimaryKey = New System.Data.DataColumn() { Me.dataColumn2}
			Me.dataTable2.TableName = "Child"
			' 
			' dataColumn2
			' 
			Me.dataColumn2.AllowDBNull = False
			Me.dataColumn2.AutoIncrement = True
			Me.dataColumn2.ColumnName = "I"
			Me.dataColumn2.DataType = GetType(Integer)
			' 
			' dataColumn3
			' 
			Me.dataColumn3.AllowDBNull = False
			Me.dataColumn3.ColumnName = "P"
			Me.dataColumn3.DataType = GetType(Integer)
			' 
			' dataColumn4
			' 
			Me.dataColumn4.AllowDBNull = False
			Me.dataColumn4.ColumnName = "T"
			' 
			' gridView1
			' 
			Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.gridColumn1})
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
			Me.gridView1.OptionsView.RowAutoHeight = True
			' 
			' gridColumn1
			' 
			Me.gridColumn1.Caption = "gridColumn1"
			Me.gridColumn1.FieldName = "I"
			Me.gridColumn1.Name = "gridColumn1"
			Me.gridColumn1.Visible = True
			Me.gridColumn1.VisibleIndex = 0
			' 
			' repositoryItemMemoEdit1
			' 
			Me.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(405, 354)
			Me.Controls.Add(Me.gridControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.gridView2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemMemoEdit2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dataSet1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dataTable1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dataTable2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private repositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
		Private dataSet1 As System.Data.DataSet
		Private dataTable1 As System.Data.DataTable
		Private dataColumn1 As System.Data.DataColumn
		Private dataTable2 As System.Data.DataTable
		Private dataColumn2 As System.Data.DataColumn
		Private dataColumn3 As System.Data.DataColumn
		Private dataColumn4 As System.Data.DataColumn
		Private WithEvents gridView2 As DevExpress.XtraGrid.Views.Grid.GridView
		Private gridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
		Private repositoryItemMemoEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
		Private gridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumn4 As DevExpress.XtraGrid.Columns.GridColumn

	End Class
End Namespace

