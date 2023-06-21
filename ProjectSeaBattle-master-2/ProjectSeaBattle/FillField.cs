using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectSeaBattle
{
    class FillField
    {
        public int Rows = FormMain.rows;
        public int Columns = FormMain.columns;

        public void ResetToZero(string[,] arr)
        {
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    arr[i, j] = "0";
                }
            }
        }

        //Заполнение текстового документа
        public void FillTextFile(string[,] field, string[,] end)
        {
            StreamWriter file = new StreamWriter("field.txt");
            StreamWriter file2 = new StreamWriter("end.txt");

            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    file.Write(field[i, j] + " ");
                    file2.Write(end[i, j] + " ");
                }
                file.WriteLine();
                file2.WriteLine();
            }
            file.Close();
            file2.Close();
        }

        //Заполнение dgv в форме Level
        public void ReadTextFile(DataGridView dgvLevel, DataGridView dgvEndLevel)
        {
            StreamReader file = new StreamReader("field.txt");
            StreamReader file2 = new StreamReader("end.txt");

            for (int i = 0; i < Rows; i++)
            {
                string[] s = file.ReadLine().Split();
                string[] s2 = file2.ReadLine().Split();
                for (int j = 0; j < Columns; j++)
                {
                    if (s[j] != "0")
                    {
                        dgvLevel.Rows[i].Cells[j].Style.BackColor = Color.FromName(s[j]);
                    }
                    if (s2[j] != "0")
                    {
                        dgvEndLevel.Rows[i].Cells[j].Style.BackColor = Color.FromName(s2[j]);
                    }

                }
            }
            file.Close();
            file2.Close();
        }

        // заполнение массивов для работы с ними в MovementOfShips
        public void ReadTextFile(string[,] field, string[,] end)
        {
            StreamReader file = new StreamReader("field.txt");
            StreamReader file2 = new StreamReader("end.txt");

            for (int i = 0; i < Rows; i++)
            {
                string[] s = file.ReadLine().Split();
                string[] s2 = file2.ReadLine().Split();
                for (int j = 0; j < Columns; j++)
                {
                    field[i, j] = s[j];
                    end[i, j] = s2[j];
                }
            }
            file.Close();
            file2.Close();
        }

        public void ShipsArray(List<string> shipsArray, string[,] field)
        {
            string s = string.Empty;

            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    s = field[i, j];
                    if (s != "0" && !shipsArray.Contains(s))
                    {
                        shipsArray.Add(s);
                    }
                }
            }
        }

        public void FillTextFile(List<string> s)
        {
            StreamWriter file = new StreamWriter("ships.txt");

            for (int i = 0; i < FormMain.ships; i++)
            {
                if(i== s.Count-1)
                    file.Write(s[i]);
                else file.Write(s[i] + " ");
            }
            file.Close();
        }
    }
}
