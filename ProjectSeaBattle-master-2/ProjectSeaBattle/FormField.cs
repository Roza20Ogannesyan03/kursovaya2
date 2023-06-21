using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectSeaBattle
{
    public partial class FormField : Form
    {
        public Pen fill = new Pen(Color.White);

        public int columns = FormMain.columns;
        public int rows = FormMain.rows;
        public string[,] ships;
        public string[,] endGame;
        public List<string> shipsArr;
        public List<string> shipsArrEnd;
        FillField ff;
        public FormField()
        {
            InitializeComponent();
            ships = new string[rows, columns];
            endGame = new string[rows, columns];
            shipsArr = new List<string>(FormMain.ships);
            shipsArrEnd = new List<string>(FormMain.ships);
            ff = new FillField();
            ff.ResetToZero(ships);
            ff.ResetToZero(endGame);
        }

        

        private void buttonColor_Click(object sender, EventArgs e)
        {
            fill.Color = ((Button)sender).BackColor;
        }

        private void dgvField_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvField.DefaultCellStyle.SelectionBackColor = fill.Color;
            dgvField.CurrentCell.Style.BackColor = fill.Color;
            string s = fill.Color.ToString();
            int n = s.Length - 8;
            ships[dgvField.CurrentCell.RowIndex, dgvField.CurrentCell.ColumnIndex] = s.Substring(7, n);
            
        }


        public void FormField_Load(object sender, EventArgs e)
        {

            CreateField createField = new CreateField(253, 248, dgvField);
            CreateField createField2 = new CreateField(253, 248, dgvEnd);

        }

        private void buttonRestart_Click(object sender, EventArgs e)
        {
            

        }

        private void buttonToRun_Click(object sender, EventArgs e)
        {
            ff.ShipsArray(shipsArr, ships);
            ff.ShipsArray(shipsArrEnd, endGame);

            ff.FillTextFile(shipsArr);
            if (dgvField.DefaultCellStyle.SelectionBackColor == Color.White)
                MessageBox.Show("ВЫ НЕ СОЗДАЛИ КОРАБЛИ!");
            else if (shipsArr.Count != FormMain.ships)
                MessageBox.Show("КОРАБЛЕЙ НЕ ДОЛЖНО БЫТЬ СТОЛЬКО!");
            else if (shipsArrEnd.Count != FormMain.ships)
                MessageBox.Show("КОРАБЛЕЙ НЕ ДОЛЖНО БЫТЬ СТОЛЬКО ЖЕ, СКОЛЬКО И НА ПЕРВОМ ПОЛЕ!");
            else
            {
                ff.FillTextFile(ships, endGame);

                Level level = new Level();
                level.Show();
            }
        }

        private void dgvEnd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvEnd.DefaultCellStyle.SelectionBackColor = fill.Color;
            dgvEnd.CurrentCell.Style.BackColor = fill.Color;
            string s = fill.Color.ToString();
            int n = s.Length - 8;
            endGame[dgvEnd.CurrentCell.RowIndex, dgvEnd.CurrentCell.ColumnIndex] = s.Substring(7, n);
        }

        private void flowLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

