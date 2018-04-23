using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections;
using System.Reflection;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace GridView_CalcRowHeight
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            gridView1.DetailHeight = int.MaxValue;
            InitData();
        }

        public void InitData()
        {
            dataTable1.Rows.Add(dataTable1.NewRow());
			dataTable1.Rows.Add(dataTable1.NewRow());
            dataTable1.Rows.Add(dataTable1.NewRow());
			DataRow row = dataTable2.NewRow();
			row["P"] = 0;
			row["T"] = LongText(2);
			dataTable2.Rows.Add(row);
			row = dataTable2.NewRow();
			row["P"] = 1;
			row["T"] = LongText(1);
			dataTable2.Rows.Add(row);
			row = dataTable2.NewRow();
			row["P"] = 2;
			row["T"] = LongText(3);
            dataTable2.Rows.Add(row);
        }

        public string LongText(int n)
        {
            string t = "";
            for (int i = 0; i< n; i++)
                t = t + "Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat. Ut wisi enim ad minim veniam, quis nostrud exerci tation ullamcorper suscipit lobortis nisl ut aliquip ex ea commodo consequat. Duis autem vel eum iriure dolor in hendrerit in vulputate velit esse molestie consequat, vel illum dolore eu feugiat nulla facilisis at vero eros et accumsan et iusto odio dignissim qui blandit praesent luptatum zzril delenit augue duis dolore te feugait nulla facilisi. Nam liber tempor cum soluta nobis eleifend option congue nihil imperdiet doming id quod mazim placerat facer possim assum. Typi non habent claritatem insitam; est usus legentis in iis qui facit eorum claritatem. Investigationes demonstraverunt lectores legere me lius quod ii legunt saepius. Claritas est etiam processus dynamicus, qui sequitur mutationem consuetudium lectorum. Mirum est notare quam littera gothica, quam nunc putamus parum claram, anteposuerit litterarum formas humanitatis per seacula quarta decima et quinta decima. Eodem modo typi, qui nunc nobis videntur parum clari, fiant sollemnes in futurum.";
            return t;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void gridView1_CalcRowHeight(object sender, RowHeightEventArgs e)
        {
            GridView gv = sender as GridView;
            if (gv != null)
            {
                GridViewInfo vi = gv.GetViewInfo() as GridViewInfo;
                if (vi != null)
                {
                    int h = vi.ViewRects.Rows.Height - 1;
                    if (e.RowHeight > h)
                    e.RowHeight = h;
                }
            }

        }
    }  
}