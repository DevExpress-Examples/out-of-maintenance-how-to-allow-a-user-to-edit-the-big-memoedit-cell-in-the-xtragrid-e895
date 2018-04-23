Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Collections
Imports System.Reflection
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo

Namespace GridView_CalcRowHeight
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
			gridView1.DetailHeight = Integer.MaxValue
			InitData()
		End Sub

		Public Sub InitData()
			dataTable1.Rows.Add(dataTable1.NewRow())
			dataTable1.Rows.Add(dataTable1.NewRow())
			dataTable1.Rows.Add(dataTable1.NewRow())
			Dim row As DataRow = dataTable2.NewRow()
			row("P") = 0
			row("T") = LongText(2)
			dataTable2.Rows.Add(row)
			row = dataTable2.NewRow()
			row("P") = 1
			row("T") = LongText(1)
			dataTable2.Rows.Add(row)
			row = dataTable2.NewRow()
			row("P") = 2
			row("T") = LongText(3)
			dataTable2.Rows.Add(row)
		End Sub

		Public Function LongText(ByVal n As Integer) As String
			Dim t As String = ""
			For i As Integer = 0 To n - 1
				t = t & "Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat. Ut wisi enim ad minim veniam, quis nostrud exerci tation ullamcorper suscipit lobortis nisl ut aliquip ex ea commodo consequat. Duis autem vel eum iriure dolor in hendrerit in vulputate velit esse molestie consequat, vel illum dolore eu feugiat nulla facilisis at vero eros et accumsan et iusto odio dignissim qui blandit praesent luptatum zzril delenit augue duis dolore te feugait nulla facilisi. Nam liber tempor cum soluta nobis eleifend option congue nihil imperdiet doming id quod mazim placerat facer possim assum. Typi non habent claritatem insitam; est usus legentis in iis qui facit eorum claritatem. Investigationes demonstraverunt lectores legere me lius quod ii legunt saepius. Claritas est etiam processus dynamicus, qui sequitur mutationem consuetudium lectorum. Mirum est notare quam littera gothica, quam nunc putamus parum claram, anteposuerit litterarum formas humanitatis per seacula quarta decima et quinta decima. Eodem modo typi, qui nunc nobis videntur parum clari, fiant sollemnes in futurum."
			Next i
			Return t
		End Function
		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
		End Sub

		Private Sub gridView1_CalcRowHeight(ByVal sender As Object, ByVal e As RowHeightEventArgs) Handles gridView2.CalcRowHeight
			Dim gv As GridView = TryCast(sender, GridView)
			If gv IsNot Nothing Then
				Dim vi As GridViewInfo = TryCast(gv.GetViewInfo(), GridViewInfo)
				If vi IsNot Nothing Then
					Dim h As Integer = vi.ViewRects.Rows.Height - 1
					If e.RowHeight > h Then
					e.RowHeight = h
					End If
				End If
			End If

		End Sub
	End Class
End Namespace