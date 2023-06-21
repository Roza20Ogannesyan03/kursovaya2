using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectSeaBattle
{
    class CreateFieldImages
    {
        public int Columns;
        public int WidthCell;
        public int Rows;
        public int HeightCell;

        public CreateFieldImages(DataGridView dgv)
        {
            
            Columns = FormMain.ships;
            Rows = 15;
            dgv.ClearSelection();

            WidthCell = 42;
            HeightCell = 42;
            dgv.Width = WidthCell * Columns + 20;
            dgv.ColumnHeadersVisible = false;
            dgv.RowHeadersVisible = false;

            for (int i = 1; i <= Columns; i++)
            {
                string name = "column" + i;
                dgv.Columns.Add(new DataGridViewImageColumn() { Name = name, Width = WidthCell});
                //var assignChargeColumn = (DataGridViewImageColumn)this.GrdChargeArrivalPart.Columns["AssignCharge"];
                //assignChargeColumn.DefaultCellStyle.NullValue = null;
                //assignChargeColumn.DefaultCellStyle.NullValue = Properties.Resources.Assign_OneToMany;
            }

            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    dgv.DefaultCellStyle.Format = System.String.Empty;
                }
            }

            dgv.RowTemplate.Height = HeightCell;
            dgv.Rows.Add(15);
            dgv.ClearSelection();
        }
    }
}
