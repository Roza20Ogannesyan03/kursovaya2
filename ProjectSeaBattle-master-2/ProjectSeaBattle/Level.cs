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

    public partial class Level : Form
    {
        CreateField cf;
        CreateField cfEnd;
        CreateFieldImages cfArrows;
        MovementOfShips mos;
        public string[,] ships;
        public string[] sA;
        FillField ff;
        public Level()
        {
            InitializeComponent();

        }

        public void ReadTextFile(string[] s)
        {
            StreamReader file = new StreamReader("ships.txt");
            s = file.ReadLine().Split();
            for (int i = 0; i < FormMain.ships; i++)
            {
                sA[i] = s[i];
            }
            file.Close();
        }

        private void Level_Load(object sender, EventArgs e)
        {

            cf = new CreateField(255, 235, dgvLevel);
            cfEnd = new CreateField(255, 235, dgvEndLevel);
            cfArrows = new CreateFieldImages(dgvMove);

            mos = new MovementOfShips(dgvLevel, dgvMove, dgvEndLevel);
            ships = new string[cf.Rows, cf.Columns];

            ff = new FillField();
            ff.ReadTextFile(dgvLevel, dgvEndLevel);
            sA = new string[FormMain.ships];

            ReadTextFile(sA);
            CreatePictureBoxes();
        }

        public void CreatePictureBoxes()
        {
            int n = 325;

            for (int i = 1; i <= FormMain.ships; i++)
            {
                Color temp = Color.FromName(sA[i - 1]);
                PictureBox picture = new PictureBox
                {

                    Name = "pictureBox" + i,
                    Size = new Size(42, 37),
                    Location = new Point(n, 60),
                    BackColor = temp,
                };
                n += 42;
                this.Controls.Add(picture);
            }
        }

        public void buttonMove_Click(object sender, EventArgs e)
        {
            mos.Click(sender, e);
        }

        private void buttonToRun_Click(object sender, EventArgs e)
        {
            mos.ToRun();
        }

        private void buttonRestart_Click(object sender, EventArgs e)
        {
            mos.Restart();
            ff.ReadTextFile(dgvLevel, dgvEndLevel);
        }

        private void instruction_Click(object sender, EventArgs e)
        {
            Instruction inst = new Instruction();
            inst.Show();
        }

        //private void button_KeyDown(object sender, KeyEventArgs e)
        //{
        //    switch (e.KeyCode)
        //    {
        //        case Keys.Up:
        //            dgvMove.CurrentCell.Value = Image.FromFile("up.png");
        //            break;

        //        case Keys.Down:
        //            dgvMove.CurrentCell.Value = Image.FromFile("up.png");
        //            break;

        //        case Keys.Right:
        //            dgvMove.CurrentCell.Value = Image.FromFile("up.png");
        //            break;

        //        case Keys.Left:
        //            MessageBox.Show("bnm");
        //            dgvMove.CurrentCell.Value = Image.FromFile("up.png");
        //            break;

        //    }
        //}
    }
}
