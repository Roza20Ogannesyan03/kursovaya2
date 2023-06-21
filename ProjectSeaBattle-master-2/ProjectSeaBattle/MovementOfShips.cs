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
    class MovementOfShips
    {
        public int Rows;
        public int Columns;
        public DataGridView Dgv;
        public DataGridView DgvEnd;
        public DataGridView DgvMove;
        public int ships;
        public string[,] field;
        public string[,] end;
        public int[,] move;
        public Button button;
        public List<string> shipsArray;
        public FillField ff;

        public MovementOfShips(DataGridView dgv, DataGridView dgvMove, DataGridView dgvEnd)
        {
            ff = new FillField();
            Rows = FormMain.rows;
            Columns = FormMain.columns;
            Dgv = dgv;
            DgvEnd = dgvEnd;
            DgvMove = dgvMove;
            field = new string[Rows, Columns];
            end = new string[Rows, Columns];
            ships = FormMain.ships;
            move = new int[15, ships];
            shipsArray = new List<string>();


            ff.ReadTextFile(field, end);
            ff.ShipsArray(shipsArray, field);
            //ff.FillTextFile(shipsArray);
        }

        public int HowMuchRows(int[,] s)
        {
            int cnt = 0;
            for (int i = 0; i < 15; i++)
            { 
                cnt++;
                int n = 0;
                for (int j = 0; j < ships; j++)
                {
                    if (s[i, j] == 0)
                        n += 1;
                }
                if (n == ships) break;
            }
            return cnt;
        }
        public void Click(object sender, EventArgs e)
        {
            button = (Button)sender;
            DgvMove.CurrentCell.Value = button.Image;
            move[DgvMove.CurrentCell.RowIndex, DgvMove.CurrentCell.ColumnIndex] =
                Convert.ToInt32(button.Tag.ToString());
            DgvMove.CurrentCell.Selected = false;
        }

        public void DgvMove_KeyDown(object sender, KeyEventArgs e)
        {
            //if (mousOrKlav)
              //  return;
            switch (e.KeyCode)
            {
                case Keys.Up:
                    DgvMove.CurrentCell.Value = Image.FromFile("up.png");
                    break;

                case Keys.Down:
                    DgvMove.CurrentCell.Value = Image.FromFile("up.png");
                    break;

                case Keys.Right:
                    DgvMove.CurrentCell.Value = Image.FromFile("up.png");
                    break;

                case Keys.Left:
                    MessageBox.Show("bnm");
                    DgvMove.CurrentCell.Value = Image.FromFile("up.png");
                    break;
                    
            }
        }

        public bool TryStep(int StepShip, int x, int y, string[,] tempField)
        {
            //
            if (StepShip == 4 && y - 1 >= 0)
            {
                if (field[x, y - 1] != "0" && tempField[x, y - 1] != field[x, y - 1] && tempField[x, y - 1] != "0")
                {
                    korablivrezalis = true;
                    return false;
                }
                if (tempField[x, y - 1] == "0" || tempField[x, y] == tempField[x, y - 1])
                {
                    tempField[x, y - 1] = field[x, y];
                    return true;
                }
                return false;
            }
            //
            if (StepShip == 3 && y + 1 < Rows)
            {
                if (field[x, y + 1] != "0" && tempField[x, y + 1] != field[x, y + 1] && tempField[x, y + 1] != "0")
                {
                    korablivrezalis = true;
                    return false;
                }
                if (tempField[x, y + 1] == "0" || tempField[x, y] == tempField[x, y + 1])
                {
                    tempField[x, y + 1] = field[x, y];
                    return true;
                }
                return false;
            }
            //
            if (StepShip == 2 && x + 1 <= Columns - 1)
            {
                if (field[x + 1, y] != "0" && tempField[x + 1, y] != field[x + 1, y] && tempField[x + 1, y] != "0")
                {
                    korablivrezalis = true;
                    return false;
                }
                if (tempField[x + 1, y] == "0" || tempField[x, y] == tempField[x + 1, y])
                {
                    tempField[x + 1, y] = field[x, y];
                    return true;
                }
                return false;
            }
            //
            if (StepShip == 1 && x - 1 >= 0)
            {
                if (field[x - 1, y] != "0" && tempField[x - 1, y] != field[x - 1, y] && tempField[x - 1, y] != "0")
                {
                    korablivrezalis = true;
                    return false;
                }
                if (tempField[x - 1, y] == "0" || tempField[x, y] == tempField[x - 1, y])
                {
                    tempField[x - 1, y] = field[x, y];
                    return true;
                }
            }
            return false;
        }

        public void Join(string[,] a, string color, string[,] a2)
        {
            int cnt = 0;
            //Проверка. Не пустой ли массив
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    if (a[i, j] == color)
                    {
                        cnt++;
                        break;
                    }
                }
            }

            if (cnt != 0)
            {
                Delete(color, a2);
                ChangingLocationShip(a, a2);
            }

        }
        public void Delete(string color, string[,] arr2)
        {
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    if (arr2[i, j] == color)
                        arr2[i, j] = "0";
                }
            }
        }
        public void ChangingLocationShip(string[,] a1, string[,] a2)
        {
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    if (a1[i, j] != "0")
                        a2[i, j] = a1[i, j];
                }
            }
        }
        public bool korablivrezalis = false;
        public int howMuchRows;
        public async void ToRun()
        {
            howMuchRows = HowMuchRows(move);
            var tempField = new string[Rows, Columns];
            ff.ResetToZero(tempField);
            bool win = true;
            for (int i = 0; i < howMuchRows; i++)
            {
                win = true;
                int[] steps = new int[ships];
                List<string[,]> tempFields = new List<string[,]>();
                for (int n = 0; n < ships; n++)
                {
                    tempFields.Add(new string[Rows, Columns]);
                    ff.ResetToZero(tempFields[n]);
                }
                for (int k = 0; k < steps.Length; k++)
                {
                    steps[k] = move[i, k];
                }

                for (int x = 0; x < Rows; x++)
                {
                    for (int y = 0; y < Columns; y++)
                    {

                        for (int m = 0; m < ships; m++)
                        {
                            if (field[x, y] == shipsArray[m] && steps[m] != 0)
                                win = TryStep(steps[m], x, y, tempFields[m]);
                            if (win == false)
                            {
                                goto finish;
                            }
                        }
                    }
                }

                for (int j = 0; j < ships; j++)
                {
                    Join(tempFields[j], shipsArray[j], tempField);
                }

                field = tempField;
                await Task.Delay(1000);
                ColorTheField();
                
                
            }

            finish:
            if (win && CheckWin()) MessageBox.Show("Поздравляю, вы выиграли!");
            else MessageBox.Show("Вы проиграли");
            if (korablivrezalis)
                MessageBox.Show("Корабли не должны столкнуться!");
        }

        public void ColorTheField()
        {
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    if(Dgv.Rows[i].Cells[j].Style.BackColor != Color.White)
                        Dgv.Rows[i].Cells[j].Style.BackColor = Color.White;
                    if(field[i,j] != "0")
                    Dgv.Rows[i].Cells[j].Style.BackColor = Color.FromName(field[i, j]);
                }
            }
        }


        public bool CheckWin()
        {
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    if (field[i, j] != end[i, j])
                    {
                        ColorTheField();
                        return false;
                    }
                }
            }
            return true;
        }

        public void Restart()
        {
            for (int i = 0; i < howMuchRows; i++)
            {
                for (int j = 0; j < ships; j++)
                {
                    DgvMove.Rows[i].Cells[j].Value = null;
                }
            }
        }

        public void Restart2()
        {
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    Dgv.Rows[i].Cells[j].Style.BackColor = Color.White;
                    DgvEnd.Rows[i].Cells[j].Style.BackColor = Color.White;
                }
            }
            Dgv.DefaultCellStyle.SelectionBackColor = Color.White;
            DgvEnd.DefaultCellStyle.SelectionBackColor = Color.White;
        }

    }
}


