using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectSeaBattle
{
    public partial class Instruction : Form
    {
        public Instruction()
        {
            InitializeComponent();
        }

        private void Instruction_Load(object sender, EventArgs e)
        {
            dgvField.Rows.Add(4);
            dgvEnd.Rows.Add(4);
            dgvField.ClearSelection();
            dgvEnd.ClearSelection();

            dgvField.Enabled = false;
            dgvEnd.Enabled = false;

            dgvField.Rows[0].Cells[0].Style.BackColor = Color.HotPink;
            dgvField.Rows[1].Cells[0].Style.BackColor = Color.HotPink;
            dgvField.Rows[0].Cells[1].Style.BackColor = Color.HotPink;

            dgvField.Rows[3].Cells[3].Style.BackColor = Color.Pink;
            dgvField.Rows[3].Cells[2].Style.BackColor = Color.Pink;
            dgvField.Rows[2].Cells[3].Style.BackColor = Color.Pink;


            dgvEnd.Rows[0].Cells[1].Style.BackColor = Color.HotPink;
            dgvEnd.Rows[1].Cells[1].Style.BackColor = Color.HotPink;
            dgvEnd.Rows[1].Cells[0].Style.BackColor = Color.HotPink;

            dgvEnd.Rows[2].Cells[3].Style.BackColor = Color.Pink;
            dgvEnd.Rows[2].Cells[2].Style.BackColor = Color.Pink;
            dgvEnd.Rows[3].Cells[2].Style.BackColor = Color.Pink;

            label1.Text = " Суть этой игры заключается в том,\n\nчтобы управлять кораблями с помощью стрелок,\n\n" +
                    "чтобы в конечном итоге они оказались \n\nна нужных местах(положение на втором поле)\n\n" +
                    "местами. Форма кораблей не меняется!\n\n" +
                    "Корабли ходят одновременно\n\n (построчно)";

        }
    }
}
