using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rand = new Random();
        int row, col;
        char[,] bomb_square;
        Button[,] But;
        bool flag = false;
        int num_flag = 0;
        int right_flag = 0;

        private void Square_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            Bomb_Click(b.Location.Y / 25, b.Location.X / 25);
        }

        private void Bomb_Click(int i, int j)
        {
            if (0 <= i && i <= 9 && 0 <= j && j <= 9 && But[i,j].Enabled)
            {
                if (flag == false)
                {
                    if (But[i, j].Text != "f")
                    {
                        But[i, j].Text = bomb_square[i + 1, j + 1].ToString();
                        But[i, j].Enabled = false;
                        if (bomb_square[i + 1, j + 1] == '0')
                        {
                            Bomb_Click(i - 1, j - 1);
                            Bomb_Click(i - 1, j);
                            Bomb_Click(i - 1, j + 1);
                            Bomb_Click(i, j - 1);
                            Bomb_Click(i, j + 1);
                            Bomb_Click(i + 1, j - 1);
                            Bomb_Click(i + 1, j);
                            Bomb_Click(i + 1, j + 1);
                        }
                        if (bomb_square[i + 1, j + 1] == 'B')
                        {
                            fail(row, col);
                        }
                    }
                }
                else
                {
                    if(But[i,j].Text!="f")
                    {
                        But[i, j].Text = "f";
                        num_flag++;
                        if (bomb_square[i + 1, j + 1] == 'B') right_flag++;
                    }
                    else
                    {
                        But[i, j].Text = "";
                        num_flag--;
                        if (bomb_square[i + 1, j + 1] == 'B') right_flag--;
                    }
                    if (right_flag == num_flag && num_flag == row * col / 4) MessageBox.Show("You win!!");
                }
            }
        }

        private void fail(int r,int c)
        {
            for (int i = 0; i < r; i++)
                for (int j = 0; j < c; j++)
                {
                    But[i, j].Text = bomb_square[i + 1, j + 1].ToString();
                    But[i, j].Enabled = false;
                }
            MessageBox.Show("Fail");
        }

        private char[,] get_square(int r, int c)
        {
            char[,] b = new char[r + 2, c + 2];
            for (int i = 0; i < row * col / 4; i++)
            {
                int loc_row = rand.Next(row) + 1, loc_col = rand.Next(col) + 1;
                while (b[loc_row, loc_col] == 'B')
                {
                    loc_row = rand.Next(row) + 1;
                    loc_col = rand.Next(col) + 1;
                }
                b[loc_row, loc_col] = 'B';
            }

            for (int i = 1; i < row + 1; i++)
                for (int j = 1; j < col + 1; j++)
                {
                    if (b[i, j] == 'B') continue;
                    int bomb = 0;
                    if (b[i - 1, j - 1] == 'B') bomb++;
                    if (b[i - 1, j] == 'B') bomb++;
                    if (b[i - 1, j + 1] == 'B') bomb++;
                    if (b[i, j - 1] == 'B') bomb++;
                    if (b[i, j + 1] == 'B') bomb++;
                    if (b[i + 1, j - 1] == 'B') bomb++;
                    if (b[i + 1, j] == 'B') bomb++;
                    if (b[i + 1, j + 1] == 'B') bomb++;
                    b[i, j] = (char)('0' + bomb);
                }
            return b;
        }

        private void Change_button1_Click(object sender, EventArgs e)
        {
            flag = true;
            Change_button1.Enabled = false;
            Change_button2.Enabled = true;
        }

        private void Change_button2_Click(object sender, EventArgs e)
        {
            flag = false;
            Change_button1.Enabled = true;
            Change_button2.Enabled = false;
        }

        private void Reset(object sender, EventArgs e)
        {
            square.Controls.Clear();

            row = (int)Numeric_Row.Value;
            col = (int)Numeric_Col.Value;

            if (row > square.Height / 25) this.Height += (row - square.Height / 25) * 25;
            if (col > square.Width / 25) this.Width += (col - square.Width / 25) * 25;

            bomb_square = get_square(row,col);
            
            But = new Button[row, col];
            
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    But[i, j] = new Button();
                    But[i, j].Width = But[i, j].Height = 25;
                    //But[i, j].Text = bomb_square[i+1,j+1].ToString();
                    But[i, j].Location = new Point(j * 25, i * 25);
                    But[i, j].Click += Square_Click;
                    square.Controls.Add(But[i, j]);
                }
            }
        }
    }
}
