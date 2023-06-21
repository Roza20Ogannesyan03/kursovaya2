using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectSeaBattle
{
    class CreateField
    {
        public int Height;
        public int Width;
        public int Columns;
        public int WidthCell;
        public int Rows;
        public int HeightCell;
        public CreateField(int height, int width, DataGridView dgv)
        {
            //MessageBox.Show(FormMain.columns + "");
            dgv.Height = height;
            dgv.Width = width;

            Height = dgv.Height;
            Width = dgv.Width;
            Columns = FormMain.columns;
            Rows = FormMain.rows;
            dgv.ClearSelection();

            WidthCell = (Width - 3) / Columns;
            HeightCell = (Height - 3) / Rows;

            dgv.ColumnHeadersVisible = false;
            dgv.RowHeadersVisible = false;

            for (int i = 1; i <= Columns; i++)
            {
                string name = "column" + i;
                dgv.Columns.Add(new DataGridViewTextBoxColumn() { Name = name, Width = WidthCell });
            }

            dgv.RowTemplate.Height = HeightCell;
            dgv.Rows.Add(Rows);
            dgv.ClearSelection();
        }

    }
}
