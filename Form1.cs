using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class Form1 : Form
    {
        static int margin = 30;
        static int btnWidth = 20;
        static int btnHeight = 20;

        int Hints = 3;
        int t = 0;
        int level = 0;

        private List<int>[] H = new List<int>[9];
        private List<int>[] V = new List<int>[9];
        private List<int>[] Matrix = new List<int>[9];

        private int[][] Pan = new int[9][];
        Random r = new Random();
        TextBox[,] Tables = new TextBox[9,9];

        public Form1()
        {
            InitializeComponent();
            CreateTable();
            CreateSudoku();

        }

      
     
        private void CreateSudoku()
        {
            Hints = 3;

            Random r1 = new Random();
            r = r1;

            while (true)
            {
                break1:
                
                for (int x = 0; x <9; x++)
                {
                    H[x] = new List<int>(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });
                    V[x] = new List<int>(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });
                    Matrix[x] = new List<int>(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });

                    int[] row = new int[9];

                    Pan[x] = row;
                }

                for (int x = 0; x <9; x++)
                {
                    for (int y = 0; y < 9; y++)
                    {
                        int z = (x / 3) * 3 + (y / 3);//
                        int[] Temp = H[x].Intersect(V[y]).Intersect(Matrix[z]).ToArray();

                        if (Temp.Count() == 0)
                        {
                            goto break1;
                        }

                        int randomNumber = Temp[this.r.Next(0, Temp.Count())];

                        H[x].Remove(randomNumber);
                        V[y].Remove(randomNumber);
                        Matrix[z].Remove(randomNumber);

                        Pan[x][y] = randomNumber;

                        if (x == 8 && y == 8)
                        {
                            goto break2;
                        }
                    }
                }
            };
            break2:;

            /* 실패
                int pro = 0;
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {


                    pro = r.Next(1, 10);
                    for (int k = 0; k < 9; k++)
                    {

                        //x 012,345,678
                        if ((x[i, k] != pro) && (x[k, j] != pro) && (((i == 0 || i == 1 || i == 2) &&
                            (j == 0 || j == 1 || j == 2)) && ((x[0, 0] != pro) && (x[0, 1] != pro) && (x[0, 2] != pro)
                            && (x[1, 0] != pro) && (x[1, 1] != pro) && (x[1, 2] != pro) &&
                            (x[2, 0] != pro) && (x[2, 1] != pro) && (x[2, 2] != pro))))
                        {

                            x[i, j] = pro;
                        }
                        else if ((x[i, k] != pro) && (x[k, j] != pro) && (((i == 0 || i == 1 || i == 2) &&
                          (j == 3 || j == 4 || j == 5)) && ((x[0, 3] != pro) && (x[0, 4] != pro) && (x[0, 5] != pro)
                          && (x[1, 3] != pro) && (x[1, 4] != pro) && (x[1, 5] != pro) &&
                          (x[2, 3] != pro) && (x[2, 4] != pro) && (x[2, 5] != pro))))
                        {

                            x[i, j] = pro;
                        }
                        else if ((x[i, k] != pro) && (x[k, j] != pro) && (((i == 0 || i == 1 || i == 2) &&
                          (j == 6 || j == 7 || j == 8)) && ((x[0, 8] != pro) && (x[0, 6] != pro) && (x[0, 7] != pro)
                          && (x[1, 6] != pro) && (x[1, 7] != pro) && (x[1, 8] != pro) &&
                          (x[2, 6] != pro) && (x[2, 7] != pro) && (x[2, 8] != pro))))
                      }*/

        }

        private void CreateTable() {
            for (int i = 0; i < 9; i++)
            {
                for (int j=0; j < 9; j++)
                {
                    Tables[i, j] = new TextBox();
                    Tables[i, j].Size = new Size(btnWidth, btnHeight);
                    Tables[i, j].Location = new Point(margin + (j * (Tables[i,j].Width+1)), margin + i* (Tables[i,j].Height+1));
                    Tables[i, j].MaxLength = 1;
                    Controls.Add(Tables[i,j]);
                }
            }         
            
        }

        private void LevelHigh() {
            for (int i = 0; i < 9; i++)
            {

                for (int j = 0; j < 9; j++)
                {
                    Tables[(i), j].ReadOnly = false;

                    Tables[i, j].BackColor = Color.White;
                }
            }

                    for (int i = 0; i < 9; i++)
            {

                int randomint = r.Next(0, 2);
                int randomint1 = r.Next(3, 5);
                int randomint2 = r.Next(6, 9);
                
                for (int j = 0; j < 9; j++)
                {
                    Tables[i, j].Text = null;

                    Tables[(i),  randomint].Text = (Pan[i][randomint]).ToString();
                    Tables[(i),  randomint1].Text = (Pan[i][randomint1]).ToString();
                    Tables[(i),  randomint2].Text = (Pan[i][randomint2]).ToString();


                    Tables[(i), randomint].ReadOnly = true;
                    Tables[(i), randomint1].ReadOnly = true;
                    Tables[(i), randomint2].ReadOnly = true;
                }
            }
            t = 0;
        }
        private void LevelMdium()
        {
            for (int i = 0; i < 9; i++)
            {

                for (int j = 0; j < 9; j++)
                {
                    Tables[(i), j].ReadOnly = false;

                    Tables[i, j].BackColor = Color.White;
                }
            }
            for (int i = 0; i < 9; i++)
            {

                int randomint = r.Next(0, 2);
                int randomint1 = r.Next(2, 5);
                int randomint2 = r.Next(5, 7);
                int randomint3 = r.Next(6, 9);

                for (int j = 0; j < 9; j++)
                {
                    Tables[i, j].Text = null;

                    Tables[(i), randomint].Text = (Pan[i][randomint]).ToString();
                    Tables[(i), randomint1].Text = (Pan[i][randomint1]).ToString();
                    Tables[(i), randomint2].Text = (Pan[i][randomint2]).ToString();
                    Tables[(i), randomint3].Text = (Pan[i][randomint3]).ToString();


                    Tables[(i), randomint].ReadOnly = true;
                    Tables[(i), randomint1].ReadOnly = true;
                    Tables[(i), randomint2].ReadOnly = true;
                    Tables[(i), randomint3].ReadOnly = true;
                }
            }

            t = 0;
        }
        private void LevelLow()
        {
            for (int i = 0; i < 9; i++)
            {

                for (int j = 0; j < 9; j++)
                {
                    Tables[(i), j].ReadOnly = false;

                    Tables[i, j].BackColor = Color.White;
                }
            }
            for (int i = 0; i < 9; i++)
            {

                int randomint = r.Next(0, 2);
                int randomint1 = r.Next(2, 5);
                int randomint2 = r.Next(5, 7);
                int randomint3 = r.Next(6, 8);
                int randomint4 = r.Next(6, 9);

                for (int j = 0; j < 9; j++)
                {
                    Tables[i, j].Text = null;

                    Tables[(i), randomint].Text = (Pan[i][randomint]).ToString();
                    Tables[(i), randomint1].Text = (Pan[i][randomint1]).ToString();
                    Tables[(i), randomint2].Text = (Pan[i][randomint2]).ToString();
                    Tables[(i), randomint3].Text = (Pan[i][randomint3]).ToString();
                    Tables[(i), randomint4].Text = (Pan[i][randomint4]).ToString();

                    Tables[(i), randomint].ReadOnly = true;
                    Tables[(i), randomint1].ReadOnly = true;
                    Tables[(i), randomint2].ReadOnly = true;
                    Tables[(i), randomint3].ReadOnly = true;
                    Tables[(i), randomint4].ReadOnly = true;
                }
            }

            t = 0;
        }
        private void DrawLines(PaintEventArgs e) {

            e.Graphics.DrawLine(new Pen(Color.Black, 1), 29, 30, 29, 228);
            e.Graphics.DrawLine(new Pen(Color.Black, 1), 92, 30, 92, 228);
            e.Graphics.DrawLine(new Pen(Color.Black, 1), 155, 30, 155, 228);
            e.Graphics.DrawLine(new Pen(Color.Black, 1), 218, 30, 218, 228);

            e.Graphics.DrawLine(new Pen(Color.Black, 1), 30, 29, 218, 29);
            e.Graphics.DrawLine(new Pen(Color.Black, 1), 30, 95, 218, 95);
            e.Graphics.DrawLine(new Pen(Color.Black, 1), 30, 161, 218, 161);
            e.Graphics.DrawLine(new Pen(Color.Black, 1), 30, 228, 218, 228);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            if (level == 0)
            {
                LevelLow();
            }
            else if (level == 1)
            {
                LevelMdium();
            }
            else {

                LevelHigh();
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            DrawLines(e);
           
        }

        private void Solution_Click(object sender, EventArgs e)
        {
            Solutin dlg = new Solutin(Pan);
            dlg.ShowDialog();
            dlg.Dispose();
        }

        private void 게임규칙ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("스도쿠 게임의 목표는 다음의 지침에 따라 나머지 빈 칸에 1에서 9까지의 숫자가 겹치지 않도록 (각각의 빈 칸에 하나의 숫자만 사용 가능) 채우는 것이다. 1. 각 가로줄의 빈 칸에 숫자를 한 번만 사용한다. 2. 각 세로줄의 빈 칸에 숫자를 한 번만 사용한다.");
        }

        private void New_Click(object sender, EventArgs e)
        {
            CreateSudoku();
            if (level == 0)
            {
                LevelLow();
            }
            else if (level == 1)
            {
                LevelMdium();
            }
            else
            {

                LevelHigh();
            }

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            t++;
            Time.Text = t.ToString()+"'s";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int i, j;
            for ( i = 0; i < 9; i++)
            {
                for ( j = 0; j < 9; j++)
                {
                    if (Tables[i, j].Text != Pan[i][j].ToString()){
                        MessageBox.Show("오답!");
                        break;
                    }
                    
                }

                if (j == 9)
                { j--; }

                if (Tables[i, j].Text != Pan[i][j].ToString())
                {
                    
                    break;
                }

                if(i==8 && j == 8)
                {
                    timer1.Enabled = false;
                    MessageBox.Show("정답! 기록 :" + t);

                    t = 0;
                    New_Click(sender, e);
                    timer1.Enabled = true;
                    level++;
                }
            }

        }

        private void 상ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            level = 2;
            CreateSudoku();
            LevelHigh();
        }

        private void 중ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            level = 1;
            CreateSudoku();
            LevelMdium();
        }

        private void 하ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            level = 0;
            CreateSudoku();
            LevelLow();
        }

        private void 제작ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" 제작 : 하성호\n 도움주신분 : 박관우 ");
        }

        private void Hint_Click(object sender, EventArgs e)
        {
            if (Hints == 0) {
                MessageBox.Show("정해진 도움 횟수를 다 사용하였습니다.");
            }
            while (true && Hints > 0 ) {

                int i = r.Next(9);
                int j = r.Next(9);

                if (Tables[i, j].ReadOnly == false && Tables[i, j].Text == "") {

                    Tables[i, j].Text = Pan[i][j].ToString();
                    Tables[i, j].BackColor = Color.Goldenrod;
                    Tables[i, j].ReadOnly = true;
                    Hints--;
                    break;

                }
                for (int x = 0; x <9; x++) {
                    for (int y =0; y <9;y++) {
                        if (Tables[x, y].Text == "") {
                             goto H;
                        }
                        if (x == 8 && y==8) {
                            MessageBox.Show("도움받을 칸 하나를 비워주세요");
                            goto z;
                        }
                    }
                }
            H:;
            }
        z:;
        }

        private void 게임방법ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("모든 칸을 채운후 검사 클릭 \n도움은 ? 클릭 3회 가능");
        }
    }
}
