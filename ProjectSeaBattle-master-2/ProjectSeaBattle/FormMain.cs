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
    public partial class FormMain : Form
    {
        public static int rows = 1;
        public static int columns = 1;
        public static int ships = 1;
        public int count { get; set; } = 1;

        public FormMain()
        {
            
            InitializeComponent();
        }

        private void comboBoxFirst_SelectedIndexChanged(object sender, EventArgs e)
        {
            rows = int.Parse(comboBoxFirst.Text);
        }

        private void comboBoxSecond_SelectedIndexChanged(object sender, EventArgs e)
        {
            columns = int.Parse(comboBoxSecond.Text);
        }

        private void shipsCount_SelectedIndexChanged(object sender, EventArgs e)
        {
            ships = int.Parse(shipsCount.Text);
            //count = ships;
           
        }

        private void buttonGreate_Click(object sender, EventArgs e)
        {
            
            if (shipsCount.Text != string.Empty || comboBoxFirst.Text != string.Empty || comboBoxSecond.Text != string.Empty)
            {
                comboBoxFirst_SelectedIndexChanged(sender, e);
                comboBoxSecond_SelectedIndexChanged(sender, e);
                shipsCount_SelectedIndexChanged(sender, e);
                FormField formField = new FormField();
                formField.Show();
            }
            else MessageBox.Show("Заполните все поля!");
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            comboBoxFirst.ResetText();
            comboBoxSecond.ResetText();
            shipsCount.ResetText();
        }

    }
}
