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
    public partial class Solutin : Form
    {
        TextBox[,] Tables = new TextBox[9, 9];
        private int[][] pans1 = new int[9][];

        static int margin = 30;
        static int btnWidth = 20;
        static int btnHeight = 20;
        public Solutin(int[][] pans)
        {
            InitializeComponent();
            CreateTable();

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Tables[i, j].Text = pans[i][j].ToString();
                }
            }

        }
        private void CreateTable()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Tables[i, j] = new TextBox();
                    Tables[i, j].Size = new Size(btnWidth, btnHeight);
                    Tables[i, j].Location = new Point(margin + (j * (Tables[i, j].Width + 1)), margin + i * (Tables[i, j].Height + 1));
                    Controls.Add(Tables[i, j]);
                }
            }

        }
        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void DrawLines(PaintEventArgs e)
        {

            e.Graphics.DrawLine(new Pen(Color.Black, 1), 29, 30, 29, 228);
            e.Graphics.DrawLine(new Pen(Color.Black, 1), 92, 30, 92, 228);
            e.Graphics.DrawLine(new Pen(Color.Black, 1), 155, 30, 155, 228);
            e.Graphics.DrawLine(new Pen(Color.Black, 1), 218, 30, 218, 228);

            e.Graphics.DrawLine(new Pen(Color.Black, 1), 30, 29, 218, 29);
            e.Graphics.DrawLine(new Pen(Color.Black, 1), 30, 95, 218, 95);
            e.Graphics.DrawLine(new Pen(Color.Black, 1), 30, 161, 218, 161);
            e.Graphics.DrawLine(new Pen(Color.Black, 1), 30, 228, 218, 228);
        }
        private void Form2_Paint(object sender, PaintEventArgs e)
        {

            DrawLines(e);
        }
    }
}
